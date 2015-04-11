using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Taller_2
{
    public partial class Form2 : Form
    {
        private string dirr;
        private String user;
        private String pass;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            validatestatus();
        }

        private void txtbxdirr_TextChanged(object sender, EventArgs e)
        {
            validatestatus();
        }
        private void validatestatus()
        {
            if (txtbxdirr.Text == "" | txtbxuser.Text=="" | txtbxpass.Text=="")
            {
                btnstart.Enabled = false;
            }
            else
            {
                btnstart.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            validatestatus();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            validatestatus();
        }
        System.Data.SqlClient.SqlConnection con;
        private void btntest1_Click(object sender, EventArgs e)
        {
            

            try
            {
                
                dirr=txtbxdirr.Text;
                user = txtbxuser.Text;
                pass = txtbxpass.Text;
                con = new System.Data.SqlClient.SqlConnection();                
                con.ConnectionString = "Data Source="+dirr+";Initial Catalog=master;User ID="+user+";Password="+pass+"";
                con.Open();
                MessageBox.Show("Conectado al servidor");
                string query = "SELECT name FROM sysdatabases";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader res = cmd.ExecuteReader();
                try
                {
                    cmbeligebd.Items.Add(("Elige una base de datos a conectar") + Environment.NewLine);
                    while (res.Read())
                    {
                        cmbeligebd.Items.Add(String.Format(" {0} " + Environment.NewLine, res[0]));
                    }
                    cmbeligebd.SelectedIndex = 0;
                    cmbeligebd.SelectedIndex = 7; //quitar
                }
                   
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                res.Close(); 
                con.Close();
                btnstart.Enabled = false;
                btnend.Enabled = true;
                groupBox2.Visible = true;
                btnnext.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a: " + dirr + ", con usuario: " + user);
                ex = null;
            }
        }

        private void comboeligebd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbtable.Items.Clear();
            try
            {
                con = new System.Data.SqlClient.SqlConnection();                
                con.ConnectionString = "Data Source="+dirr+";Initial Catalog=master;User ID="+user+";Password="+pass+"";
                con.Open();

                string query = "use "+cmbeligebd.Text+"; sELECT name FROM sys.Tables";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader res = cmd.ExecuteReader();
                try
                {
                    cmbtable.Items.Add(("Elige una tabla a tratar") + Environment.NewLine);
                    while (res.Read())
                    {
                        cmbtable.Items.Add(String.Format(" {0} " + Environment.NewLine, res[0]));
                    }
                    cmbtable.SelectedIndex = 0;
                    cmbtable.SelectedIndex = 1; //quitar
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                res.Close(); 
                con.Close();
            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void cmbtable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnend_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            btnstart.Enabled = true;
            btnend.Enabled = false;
            btnnext.Enabled = false;

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (cmbeligebd.SelectedIndex == 0 | cmbtable.SelectedIndex == 0)
            {
                MessageBox.Show("Error al conectar a la tabla ''"+cmbtable.Text+"'', de la base de datos ''"+cmbeligebd.Text+"''");
            }
        }

    }   
}
