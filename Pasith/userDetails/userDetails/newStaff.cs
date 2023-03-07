using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace userDetails
{
    public partial class newStaff : Form
    {
        public newStaff()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OP92QQ7\SQLEXPRESS;Initial Catalog=bookshop;Integrated Security=True");
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnReg_Click(object sender, EventArgs e)
        {
            string cat =cmbCategory.Text;
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.CustomFormat = "yyyy/MM/dd";
            string gender;
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            string password=txtpass.Text;
            string password_check = txtpass1.Text;

            if(cat=="Admin" || cat=="Cashier" || cat== "Stores Manager")
            {
                try
                {
                    if (password == password_check)
                    {
                        con.Open();
                        string add = "INSERT INTO mebDetails VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + DOB.Text + "','" + txtId.Text + "','" + gender + "','" + txtAddress.Text + "','" + txtEmail.Text + "'," + txtMno.Text + "," + txtHno.Text + ",'" + cat + "','" + txtuser.Text + "','" + txtpass.Text + "')";
                        SqlCommand cmd = new SqlCommand(add, con);
                        cmd.ExecuteNonQuery();

                        if (cat == "Admin")
                        {
                            string admin = "INSERT INTO addminAccess VALUES('" + txtuser.Text + "','" + txtpass.Text + "')";
                            SqlCommand acmd = new SqlCommand(admin, con);
                            acmd.ExecuteNonQuery();
                        }
                        else if (cat == "Cashier")
                        {
                            string cashier = "INSERT INTO cashierAccess VALUES('" + txtuser.Text + "','" + txtpass.Text + "')";
                            SqlCommand ccmd = new SqlCommand(cashier, con);
                            ccmd.ExecuteNonQuery();
                        }
                        else if (cat == "Stores Manager")
                        {
                            string stm = "INSERT INTO stmAccess VALUES('" + txtuser.Text + "','" + txtpass.Text + "')";
                            SqlCommand stmcmd = new SqlCommand(stm, con);
                            stmcmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Registration Fail!!!", " Staff Member Not Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }


                        MessageBox.Show("Registration Successfully!!!", " Staff Member Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password Not Matching, Try Again!!!", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Select Category!!!", " Empty Category ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void newStaff_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("Admin");
            cmbCategory.Items.Add("Cashier");
            cmbCategory.Items.Add("Stores Manager");
                       
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //cmbSection.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.CustomFormat = "yyyy/MM/dd";
            DateTime dateTime = DateTime.Now;
            DOB.Text= dateTime.ToString();
            txtId.Text = "";
            rbMale.Checked= false;
            rbFemale.Checked= false;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMno.Text = "";
            txtHno.Text = "";
            txtuser.Text = "";
            txtpass.Text = "";
            txtpass1.Text = "";
        }
    }
}
