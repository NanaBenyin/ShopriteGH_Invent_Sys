using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopRite_IMS
{
    public partial class SellingScrn : Form
    {
        public SellingScrn()
        {
            InitializeComponent();
        }

        MySqlConnection Con = new MySqlConnection("datasource=localhost;database=shoprite_ims; username=root;password=;");

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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SellingScrn_Load(object sender, EventArgs e)
        {
            populate();
            populatebill();
            Seller1.Text = LoginScrn.Sellername;
            date1.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void date1_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            populate();

        }


        int GrdTotal = 0, n = 0;




        private void button4_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SHOPRITE GHANA LTD", new Font("Candara", 25, FontStyle.Bold), Brushes.Navy, new Point(230));
            e.Graphics.DrawString("bill ID: " + DGV7.SelectedRows[0].Cells[0].Value.ToString(), new Font("Candara", 20, FontStyle.Bold), Brushes.DodgerBlue, new Point(100, 70));
            e.Graphics.DrawString("Sender Name: " + DGV7.SelectedRows[0].Cells[1].Value.ToString(), new Font("Candara", 20, FontStyle.Bold), Brushes.DodgerBlue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + DGV7.SelectedRows[0].Cells[2].Value.ToString(), new Font("Candara", 20, FontStyle.Bold), Brushes.DodgerBlue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + DGV7.SelectedRows[0].Cells[3].Value.ToString(), new Font("Candara", 20, FontStyle.Bold), Brushes.DodgerBlue, new Point(100, 160));
            e.Graphics.DrawString("Shoprite Gh_Ltd-IMS Ⓒ. All rights reserved.", new Font("Candara", 12, FontStyle.Italic), Brushes.Gold, new Point(230, 230));
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScrn log = new LoginScrn();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

                    //string sqlStatement = $"INSERT INTO categorytable( CatId, CatName, CatDesc) VALUES ('{this.CatId.Text}','{this.Catname.Text}','{this.Catdesc.Text}')";
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
                Ghc.Text = "Ghc " + GrdTotal;

                n++;
            }


        }
    }
}
