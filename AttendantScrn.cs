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

namespace ShopRite_IMS
{
    public partial class AttendantScrn : Form
    {
        public AttendantScrn()
        {
            InitializeComponent();
        }


        MySqlConnection Con = new MySqlConnection("datasource=localhost;database=shoprite_ims; username=root;password=;");
        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerId.Text == "")
                {
                    MessageBox.Show("Select The User to delete");
                }

                else
                {
                    Con.Open();
                    string query = "delete from attendant where Id=" + SellerId.Text + "";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfuly deleted");
                    Con.Close();
                    populate();

                    SellerId.Text = "";
                    this.SellerName.Text = " ";
                    this.SellerAge.Text = "";
                    this.SellerMobile.Text = "";
                    this.SellerPass.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


         private void populate()
        {
            /*Con.Open();
            string query = "select * from productcattable";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            //MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            var ds = new DataSet();
            sda.Fill(dt);
            DGV1.DataSource = dt;
            Con.Close();*/


            Con.Open();
            string query = "select * from attendant";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            DGV3.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            //MySqlConnection Conn = new MySqlConnection("server=localhost;database=shopritedb;uid=root;pwd=;");

            Con.Open();

            //string sqlStatement = $"INSERT INTO `productcattable`( `CatId`, `CatName`, `CatDesc`) VALUES ('{this.CatId.Text}','{this.Catname.Text}','{this.Catdesc.Text}')";
            string sqlStatement = "INSERT INTO shoprite_ims.attendant( ID, Name, Age, Contact, Password) VALUES ('" + this.SellerId.Text + "','" + this.SellerName.Text + "','" + this.SellerAge.Text + "','" + this.SellerMobile.Text + "','" + this.SellerPass.Text + "');";
            MySqlCommand cmd = new MySqlCommand(sqlStatement, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(this.SellerName.Text + " has been successfully added as an attendant");



            string query = "select * from attendant";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            DGV3.DataSource = ds.Tables[0];


            Con.Close();
            populate();
            SellerId.Text = "";
            this.SellerName.Text = " ";
            this.SellerAge.Text = "";
            this.SellerMobile.Text = "";
            this.SellerPass.Text = "";



        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerId.Text == "" || SellerName.Text == "" || SellerAge.Text == "" || SellerMobile.Text == "" || SellerPass.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }

                else
                {
                    Con.Open();
                    string query = "update attendant set Name='" + SellerName.Text + "', Age ='" + SellerAge.Text + "', Contact ='" + SellerMobile.Text + "', Password ='" + SellerPass.Text + "' where ID=" + SellerId.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfuly updated");
                    Con.Close();
                    populate();

                    SellerId.Text = "";
                    this.SellerName.Text = " ";
                    this.SellerAge.Text = "";
                    this.SellerMobile.Text = "";
                    this.SellerPass.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DGV3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellerId.Text = DGV3.SelectedRows[0].Cells[0].Value.ToString();
            SellerName.Text = DGV3.SelectedRows[0].Cells[1].Value.ToString();
            SellerAge.Text = DGV3.SelectedRows[0].Cells[2].Value.ToString();
            SellerMobile.Text = DGV3.SelectedRows[0].Cells[3].Value.ToString();
            SellerPass.Text = DGV3.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AttendantScrn_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProductScrn prod = new ProductScrn();
            prod.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CatScrn cat = new CatScrn();
            cat.Show();
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScrn log = new LoginScrn();
            log.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellingScrn log = new SellingScrn();
            log.Show();
        }
    }
    }

