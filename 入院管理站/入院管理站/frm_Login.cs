using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace 入院管理站
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $@"SELECT COUNT(1) FROM tb_User
                 WHERE No='{this.tbx_No.Text.Trim()}'
                 AND Mima=HASHBYTES('MD5','{this.tbx_Password.Text.Trim()}');";
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (rowCount==1)
            {
                MessageBox.Show("登陆成功！");

            }
            else
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");							
                this.tbx_Password.Focus();                                               
                this.tbx_Password.SelectAll();
            }
        }
    }
}
