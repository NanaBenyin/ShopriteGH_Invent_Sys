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

namespace ShopRite_IMS
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

       /* private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Open();

           //string sqlStatement = $"INSERT INTO `productcattable`( `CatId`, `CatName`, `CatDesc`) VALUES ('{this.CatId.Text}','{this.Catname.Text}','{this.Catdesc.Text}')";
          string sqlStatement = "select ProdName,ProdQty from shopritedb.producttable where ProdCat='" + ProdCatcombo.SelectedValue.ToString() + "';";
           MySqlDataAdapter sda = new MySqlDataAdapter(sqlStatement, Con);
           MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
           var ds = new DataSet();
           sda.Fill(ds);
            DGV6.DataSource = ds.Tables[0];

           Con.Close();
        }*/

        MySqlConnection Con = new MySqlConnection("datasource=localhost;database=shoprite_ims; username=root;password=;");

       private void FillCombo()
        {

            Con.Open();


            MySqlCommand cmd = new MySqlCommand("select Catname from categorytable", Con);
            MySqlDataReader sda;
            sda = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Catname", typeof(string));
            dt.Load(sda);
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "CatName";



            Con.Close();
        }




        private void populate()
        {
            


            Con.Open();
            string query = "select ProdName,ProdQty from product";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            DGV6.DataSource = ds.Tables[0];
            Con.Close();
        }



        private void populatebill()
        {
            


            Con.Open();
            string query = "select * from shoprite_ims.bill";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            DGV7.DataSource = ds.Tables[0];
            Con.Close();
        }




        private void SellingForm_Load(object sender, EventArgs e)
        {

            populate();
            populatebill();
            FillCombo();
        }

        int flag = 0;


        private void date1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            date1.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }
        int GrdTotal = 0, n = 0;
        private void button5_Click(object sender, EventArgs e)
        {

            
            


            if (Prodname.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }

            else
            {

                

                int total = Convert.ToInt32(this.ProdPrice.Text) * Convert.ToInt32(this.ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = Prodname.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(this.ProdPrice.Text) * Convert.ToInt32(this.ProdQty.Text);
                ORDERDGV.Rows.Add(newRow);
               
                GrdTotal = GrdTotal + total;
                Ghc.Text = "Ghc "+GrdTotal;

                n++;
            }



        }

        private void DGV5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Prodname.Text = DGV6.SelectedRows[0].Cells[0].Value.ToString();
            ProdQty.Text = DGV6.SelectedRows[0].Cells[1].Value.ToString();
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


        private void DGV7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1  ;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SUPERCHEK SHOPRITE", new Font("Century Gothic", 25,FontStyle.Bold), Brushes.Red, new Point(230) );
            e.Graphics.DrawString("bill ID: " + DGV7.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,70));
            e.Graphics.DrawString("Sender Name: " + DGV7.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + DGV7.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + DGV7.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Supercheck ShopRite c 2022. All rights reserved.", new Font("Century Gothic", 12, FontStyle.Italic), Brushes.Red, new Point(230,230));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*populate();*/
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        /*  Con.Open();
            string query = "select ProdName,ProdQty from producttable where ProdCat='" + comboBox2.SelectedValue.ToString() + "';";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            DGV6.DataSource = ds.Tables[0];
            Con.Close();*/

        }

        private void button1_Click(object sender , EventArgs e)
        {

            if (BILLID.Text == "")
            {
                MessageBox.Show("Missing BILL ID");

            }
            else
            {
                try
                {




                    //MySqlConnection Conn = new MySqlConnection("server=localhost;database=shopritedb;uid=root;pwd=;");

                    Con.Open();

                    //string sqlStatement = $"INSERT INTO `productcattable`( `CatId`, `CatName`, `CatDesc`) VALUES ('{this.CatId.Text}','{this.Catname.Text}','{this.Catdesc.Text}')";
                    string sqlStatement = "INSERT INTO shoprite_ims.bill VALUES ('" + this.BILLID.Text + "','" + this.Seller1.Text + "','" + this.date1.Text + "', '" + this.GrdTotal + "');";
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this.Prodname.Text + " order added successfuly");
                    Con.Close();
                    populatebill();
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
          
        }
    }
}
