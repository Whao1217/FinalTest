﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMag
{
    public partial class ReUserName : Form
    {
        public ReUserName()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("Database=student;Data Source=127.0.0.1;User Id = root; Password = root; pooling = false; CharSet = utf8; port = 3306");
            try
            {
                connection.Open();
                String sql = "select name from adacount where name='" + tbName.Text + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("此用户名已被使用", "提示", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (MySqlException ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                connection.Close();
            }
            try
            {
                connection.Open();
                string sqlcmd = "update adacount set name = '" + tbName.Text + "' where name='" + tbUsedName.Text + "'";
                MySqlCommand command2 = new MySqlCommand(sqlcmd, connection);
                command2.ExecuteNonQuery();
                MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
            }
            catch (MySqlException ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
