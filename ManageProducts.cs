using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }


        MySqlConnection Con = new MySqlConnection("datasource=localhost;database=shoprite_ims; username=root;password=;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillCombo()
        {
            



                Con.Open();

                
                MySqlCommand cmd = new MySqlCommand("select CatName from categorytable", Con);
                MySqlDataReader sda;
                sda = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Catname", typeof(string));
                dt.Load(sda);
                ProdCatcombo.DataSource = dt;
                ProdCatcombo.ValueMember = "CatName";
                comboBox2.DataSource = dt;
                comboBox2.ValueMember = "CatName";



            Con.Close();



            
           




        }




       /* private void FillCombo1()
        {




            Con.Open();


            MySqlCommand cmd = new MySqlCommand("select Catname from productcattable", Con);
            MySqlDataReader sda;
            sda = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Catname", typeof(string));
            dt.Load(sda);
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "CatName";



            Con.Close();





        }*/



        
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
            string query = "select * from product";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            DGV2.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
         FillCombo();
         populate();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageCategory cat = new ManageCategory();
            cat.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {




                //MySqlConnection Conn = new MySqlConnection("server=localhost;database=shopritedb;uid=root;pwd=;");

                Con.Open();

                //string sqlStatement = $"INSERT INTO `productcattable`( `CatId`, `CatName`, `CatDesc`) VALUES ('{this.CatId.Text}','{this.Catname.Text}','{this.Catdesc.Text}')";
                string sqlStatement = "INSERT INTO shoprite_ims.product( ProdId, ProdName, ProdQty, ProdPrice, ProdCat) VALUES ('" + this.ProdId.Text + "','" + this.Prodname.Text + "','" + this.Prodqty.Text + "', '"+ this.ProdPrice.Text + "','"+ this.ProdCatcombo.Text+ "' );";
                MySqlCommand cmd = new MySqlCommand(sqlStatement, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(this.Prodname.Text + " has been successfully added to the product catalog");



                string query = "select * from product";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

                var ds = new DataSet();
                sda.Fill(ds);
                DGV2.DataSource = ds.Tables[0];


                Con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select The Category to delete");
                }

                else
                {
                    Con.Open();
                    string query = "delete from product where ProdId=" + ProdId.Text + "";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product successfuly deleted");
                    Con.Close();
                    populate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "" || Prodname.Text == "" || Prodqty.Text == "" || ProdPrice.Text == "" || ProdCatcombo.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }

                else
                {
                    Con.Open();
                    string query = "update product set  ProdName='" + Prodname.Text+"', ProdQty='" + Prodqty.Text + "', ProdPrice ='" + ProdPrice.Text + "', ProdCat='" + ProdCatcombo.Text+"', where ProdId=" + ProdId.Text + ";";
                    
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product successfuly updated");




                  

                    Con.Close();
                    populate();





                    /*Con.Open();
                    string query = "update productcattable set CatName='" + Catname.Text + "', CatDesc ='" + Catdesc.Text + "' where CatId=" + CatId.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfuly updated");
                    Con.Close();
                    populate();*/



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = DGV2.SelectedRows[0].Cells[0].Value.ToString();
            Prodname.Text = DGV2.SelectedRows[0].Cells[1].Value.ToString();
            Prodqty.Text = DGV2.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = DGV2.SelectedRows[0].Cells[3].Value.ToString();
            
            ProdCatcombo.Text = DGV2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* Con.Open();

            //string sqlStatement = $"INSERT INTO `productcattable`( `CatId`, `CatName`, `CatDesc`) VALUES ('{this.CatId.Text}','{this.Catname.Text}','{this.Catdesc.Text}')";
            string sqlStatement = "SELECT * shopritedb.producttable where ProdCat='" + ProdCatcombo.SelectedValue + "';";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlStatement, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGV2.DataSource = ds.Tables[0];
            
            Con.Close();*/

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from product where ProdCat='"+ comboBox2.SelectedValue.ToString()+"';";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
        
            var ds = new DataSet();
            sda.Fill(ds);
            DGV2.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
