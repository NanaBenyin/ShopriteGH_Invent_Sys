using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.SigI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ShopRite_IMS
{
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();

        }


        MySqlConnection Con = new MySqlConnection("datasource=localhost;database=shoprite_ims; username=root;password=;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                

               
                //MySqlConnection Conn = new MySqlConnection("server=localhost;database=shopritedb;uid=root;pwd=;");

                Con.Open();

                //string sqlStatement = $"INSERT INTO `productcattable`( `CatId`, `CatName`, `CatDesc`) VALUES ('{this.CatId.Text}','{this.Catname.Text}','{this.Catdesc.Text}')";
                string sqlStatement = "INSERT INTO shoprite_ims.categorytable( CatId, CatName, CatDesc) VALUES ('" +this.CatId.Text+"','" + this.Catname.Text + "','" + this.Catdesc.Text + "');";
                MySqlCommand cmd = new MySqlCommand(sqlStatement, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(this.Catname.Text +  " has been successfully added to the product category catalog");



                string query = "select * from categorytable";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

                var ds = new DataSet();
                sda.Fill(ds);
                DGV1.DataSource = ds.Tables[0];

                this.CatId.Text ="" ;
                this.Catname.Text ="";
                this.Catdesc.Text = "";


                Con.Close();







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
            string query = "select * from categorytable";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            
            var ds = new DataSet();
            sda.Fill(ds);
            DGV1.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void ManageCategory_Load(object sender, EventArgs e)
        {
            
            populate();


        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatId.Text = DGV1.SelectedRows[0].Cells[0].Value.ToString();
            Catname.Text = DGV1.SelectedRows[0].Cells[1].Value.ToString();
            Catdesc.Text = DGV1.SelectedRows[0].Cells[2].Value.ToString();

        }

  

       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatId.Text == "")
                {
                    MessageBox.Show("Select The Category to delete");
                }

                else
                {
                    Con.Open();
                    string query = "delete from categorytable where CatId=" + CatId.Text + "";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfuly deleted");
                    Con.Close();
                    populate();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatId.Text == "" || Catname.Text == "" || Catdesc.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }

                else
                {
                    Con.Open();
                    string query = "update categorytable set CatName='" + Catname.Text + "', CatDesc ='" +Catdesc.Text + "' where CatId=" + CatId.Text+";";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfuly updated");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageProducts prod = new ManageProducts();
            prod.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageSellers prod = new ManageSellers();
            prod.Show();
            this.Hide();
        }
    }
}

