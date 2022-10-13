using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlConnectorAPP
{
    public partial class SQLconnector : Form
    {
        public SQLconnector()
        {
            InitializeComponent();
        }

        private void 加入連線設定ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddConnection AC = new AddConnection();
            AC.Show();
            AC.StartPosition = FormStartPosition.CenterScreen;

        }
        private void cbdata_show()
        {
            //path of data base
            string path = "data_table.db";
            string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db"; //database creat debug folder
            SQLiteConnection con;
            SQLiteCommand cmd;
            SQLiteDataReader dr;

            var sqllitecon = new SQLiteConnection(cs);
            sqllitecon.Open();
            using (SQLiteConnection conn = new SQLiteConnection(sqllitecon))
            {
                SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT dbname,ConnStr FROM DBconnection", conn);
                DataSet dataset = new DataSet();
                DataTable table = new DataTable();
                sda.Fill(table);
                cbbDBName.DataSource = table;
                cbbDBName.DisplayMember = "dbname";
                cbbDBName.ValueMember = "ConnStr";
                cbbDBName.Enabled = true;
            }
        }

        private void dgvDBname_show()
        {
            if (cbbDBName.SelectedValue.ToString() != null)
            {
                SqlConnection con = new SqlConnection(cbbDBName.SelectedValue.ToString());
                DataSet ds = new DataSet();

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT name FROM sys.tables", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "database");
                    con.Close();

                    foreach (DataRow item in ds.Tables[0].Rows)
                    {
                        string a = item.ItemArray[0].ToString();
                        listBox1.Items.Add(a);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void SQLconnectorLoad(object sender, EventArgs e)
        {
            cbdata_show();
            dgvDBname_show();
        }

        private void btnSqlCommand_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = new DataSet();
                SqlConnection conn = null;
                conn = new SqlConnection(cbbDBName.SelectedValue.ToString());
                conn.Open();
                string[] strSQLCommands = txtSqlcommand.Text.Split(';').Where(x => !string.IsNullOrEmpty(x)).ToArray();

                foreach (string strSQLCommand in strSQLCommands)
                {
                    var dataAdapter = new SqlDataAdapter(strSQLCommand, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(ds);
                }

                if (ds.Tables.Count != 0)
                {
                    dgvSqlCommand.ReadOnly = true;
                    dgvSqlCommand.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("指令輸入完成");
                }
                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "CatchMessage");
            }
        }
    }
}
