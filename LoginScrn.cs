using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopRite_IMS
{
    public partial class LoginScrn : Form
    {
        public LoginScrn()
        {
            InitializeComponent();
        }

        public static string Sellername = "";

        MySqlConnection Con = new MySqlConnection("datasource=localhost;database=shoprite_ims;username=root;password=;");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
       
      



      

        private void LoginScrn_Load(object sender, EventArgs e)
        {


        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (logUsername.Text == "" || logPassword.Text == "")
            {
                MessageBox.Show("Enter Username and Password ");
            }
            else
            {
                if (comboBox1.SelectedIndex > -1)
                {

                    if (comboBox1.SelectedItem.ToString() == "Admin")
                    {
                        if (this.logUsername.Text == "Admin" && this.logPassword.Text == "Admin")
                        {
                            ProductScrn prod = new ProductScrn();
                            prod.Show();
                            this.Hide();

                        }





                        else
                        {
                            MessageBox.Show("If You are the Admin, Enter the Correct logins");
                        }
                    }


                    else
                    {



                        //MessageBox.Show("You are in the Seller Section");
                        Con.Open();
                        string query = "Select count(8) from attendant where Name='" + logUsername.Text + "' and Password='" + logPassword.Text + "' ";
                        MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
                        MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        int n = 0;

                        if (n==0)
                        {
                            Sellername = logUsername.Text;
                            SellingScrn sell = new SellingScrn();
                            sell.Show();
                            this.Hide();

                            Con.Close();



                        }

                        else
                        {

                            MessageBox.Show("Wrong username or password");


                        }

                        Con.Close();






                    }

                }


                else
                {
                    MessageBox.Show("Select a Role");
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }


        }
    


      


