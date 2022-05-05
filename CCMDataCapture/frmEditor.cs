using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCMDataCapture
{
    public partial class frmEditor : Form
    {

        public static DataSet DS;

        private static string cnstr;
        private string strpath = AppDomain.CurrentDomain.BaseDirectory.ToString();

        public frmEditor()
        {
            InitializeComponent();
            DS = new DataSet();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (txtDate.EditValue == null || txtMachines.Text.Trim() == "" || txtShift.Text.Trim() == "")
            {
                MessageBox.Show("Please Select required parameters..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LockCtrl();

            string err = string.Empty;
            string sql = "select InchargeName from ccmShiftWiseInfo where tDate='" + txtDate.DateTime.Date.ToString("yyyy-MM-dd") + "' and tShift ='" + txtShift.Text.Trim().ToString() + "'";

            txtIncharge.Text = Utility.GetDescription(sql, cnstr, out err);

            //load grid..
            string tablename = GetTableName(txtMachines.Text.Trim());
            sql =
                "Select SrNo, Convert(varchar(23),LogDateTime,121) as LogDateTime," +
                "PipeNumber,PipeDia,PipeClass,ActWt,PipeStatus " +
                " From [" + tablename + "] " +
                " where tDate='" + txtDate.DateTime.Date.ToString("yyyy-MM-dd") + "' and tShift ='" + txtShift.Text.Trim().ToString() + "'";

                       
            grd_report.DataSource = null;

            DataTable dt;
            DataSet ds = Utility.GetData(sql, cnstr,out err);
            dt = null;
           
            try
            {
                dt = ds.Tables[0].Copy();
                dt.TableName = GetTableName(txtMachines.Text.Trim());
                DS = new DataSet();
                DS.Tables.Add(dt);

                grd_report.DataSource = DS;
                grd_report.DataMember = tablename;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetCtrl();
                return ;
            }
           

        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            txtDate.EditValue = DateTime.Now.Date;
            txtShift.SelectedText = "A";
            txtMachines.SelectedText = "P";

            string sqlconfig = "sql_connection.txt";
            string fullpath = Path.Combine(strpath, sqlconfig);
            cnstr = File.ReadLines(fullpath).First();

            using (SqlConnection cn = new SqlConnection(cnstr))
            {
                string str = "select Description from ccmDefect Order by Description ";                             
                SqlCommand cmd = new SqlCommand(str, cn);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ComboBoxItemCollection items_DT = this.rptStatus.Items;
                items_DT = this.rptStatus.Items;
                while (dr.Read())
                {
                    items_DT.Add(dr["Description"].ToString());
                }
                dr.Close();
                this.rptStatus.TextEditStyle = TextEditStyles.DisableTextEditor;

                this.gridView1.Columns["PipeStatus"].ColumnEdit = this.rptStatus;


                txtMachines.Items.Clear();
                str = "select MachineName from ccmMachineConfig  ";
                cmd = new SqlCommand(str, cn);
                dr = cmd.ExecuteReader();                
               
                while (dr.Read())
                {
                    txtMachines.Items.Add(dr["MachineName"].ToString());
                }
                dr.Close();
            }

        }

        private void LockCtrl()
        {
            txtDate.Enabled = false;
            txtShift.Enabled = false;
            txtMachines.Enabled = false;
            btnRefresh.Enabled = false;
            btnSave.Enabled = true;
        }

        private void UnlockCtrl()
        {
            txtDate.Enabled = true;
            txtShift.Enabled = true;
            txtMachines.Enabled = true;
            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
        }

        private void ResetCtrl()
        {
            txtDate.EditValue = null;
            txtIncharge.Text = "";
            txtShift.Text = "";
            txtMachines.Text = "";
            txtMachines.SelectedIndex = -1;
            txtShift.SelectedIndex = -1;
            btnSave.Enabled = false;
            btnRefresh.Enabled = true;
        }


        private string GetTableName(string tmachine)
        {
            string tablename = string.Empty;

            if (!string.IsNullOrEmpty(tmachine))
            {

                string err = string.Empty;
                tablename = Utility.GetDescription("Select TableName from ccmMachineConfig Where MachineName = '" + tmachine + "'", cnstr, out err);



            }
            return tablename;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grd_report.DataSource = null;
            ResetCtrl();
            UnlockCtrl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDate.EditValue == null || txtMachines.Text.Trim() == "" || txtShift.Text.Trim() == "")
            {
                MessageBox.Show("Please Select required parameters..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            string sql = "select count(*) from ccmShiftWiseInfo where tDate='" + txtDate.DateTime.Date.ToString("yyyy-MM-dd") + "' and tShift ='" + txtShift.Text.Trim().ToString() + "'";
            string err = string.Empty;
            string rec = Utility.GetDescription(sql, cnstr, out err);

            int t = 0;

            int.TryParse(rec, out t);

            if (t == 0)
            {
                sql = "Insert into ccmShiftWiseInfo (tDate,tShift,InchargeName,AddDt) Values ('" + txtDate.DateTime.Date.ToString("yyyy-MM-dd") + "','" + txtShift.Text.Trim() + "','" + txtIncharge.Text.Trim().ToString() + "',getdate())";
            }
            else
            {
                sql = "Update ccmShiftWiseInfo Set InchargeName ='" + txtIncharge.Text.Trim().ToString() + "', UpdDt = GetDate() where tDate='" + txtDate.DateTime.Date.ToString("yyyy-MM-dd") + "' and tShift ='" + txtShift.Text.Trim().ToString() + "'";
            }

            using (SqlConnection cn = new SqlConnection(cnstr))
            {
                try
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();

                        string tablename = GetTableName(txtMachines.Text.Trim());

                        //foreach datarow and save pipe status
                        DataTable HrlyView = DS.Tables[GetTableName(txtMachines.Text.Trim())].Copy();
                        foreach (DataRow Nhr in HrlyView.Rows)
                        {
                            sql = "update [" + tablename + "] Set PipeStatus ='" + Nhr["PipeStatus"].ToString() + "', UpdDt = GetDate() Where " +
                                " tDate ='" + txtDate.DateTime.Date.ToString("yyyy-MM-dd") + "' and tShift ='" + txtShift.Text.Trim() + "' " +
                                " And SrNo ='" + Nhr["SrNo"].ToString() + "'";
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = cn;
                            cmd.ExecuteNonQuery();
                        }
                        
                        MessageBox.Show("Information Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Cursor = Cursors.Default;
                        btnRefresh_Click(sender, e);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                
            }

        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string pstatus = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "PipeStatus"));
            if (string.IsNullOrEmpty(pstatus))
            {
                e.Valid = false;
                e.ErrorText = string.Format("Defect Code is Requred.\n");
                return;
            }
        }

    }
}
