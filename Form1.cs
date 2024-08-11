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
using System.Net;
using System.Diagnostics.Eventing.Reader;

namespace MARİO_İLE_BİLBAKALIM
{
    public partial class Form1 : Form
    {

        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-0S71UUMC\SQLEXPRESS;Initial Catalog=MARİO_İLE_BİL;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

      

        private void pictureBox1_Move(object sender, EventArgs e)
        {
            

        }
        private void pictureBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

       

        private void button1_KeyDown_1(object sender, KeyEventArgs e)
        {
           



            
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand getir = new SqlCommand("select SORU from TBLMARİO where SORUID=@p1 ", baglan);
            getir.Parameters.AddWithValue("@p1", int.Parse(alan1.Text));
            SqlDataReader okut= getir.ExecuteReader();
            while (okut.Read())
            {
                richTextBox1.Text = okut[0].ToString();
            }
            baglan.Close();
            label6.Text ="1";
            alan1.Enabled = false;
        }

        private void alan2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand getir = new SqlCommand("select SORU from TBLMARİO where SORUID=@p1 ", baglan);
            getir.Parameters.AddWithValue("@p1", int.Parse(alan2.Text));
            SqlDataReader okut = getir.ExecuteReader();
            while (okut.Read())
            {
                richTextBox1.Text = okut[0].ToString();
            }
            baglan.Close();
            label6.Text = "2";
            alan2.Enabled = false;
        }

        private void alan4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand getir = new SqlCommand("select SORU from TBLMARİO where SORUID=@p1 ", baglan);
            getir.Parameters.AddWithValue("@p1", int.Parse(alan4.Text));
            SqlDataReader okut = getir.ExecuteReader();
            while (okut.Read())
            {
                richTextBox1.Text = okut[0].ToString();
            }
            baglan.Close();
            label6.Text = "4";
            if(alan1.Enabled==true & alan2.Enabled==true & alan3.Enabled == true)
            {
                alan4.Enabled = true;
            }
            else if(alan1.Enabled==false && alan2.Enabled==false && alan3.Enabled == false)
            {
                alan4.Enabled=false;
            }
            
        }

        private void alan3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand getir = new SqlCommand("select SORU from TBLMARİO where SORUID=@p1 ", baglan);
            getir.Parameters.AddWithValue("@p1", int.Parse(alan3.Text));
            SqlDataReader okut = getir.ExecuteReader();
            while (okut.Read())
            {
                richTextBox1.Text = okut[0].ToString();
            }
            baglan.Close();
            label6.Text = "3";
            alan3.Enabled = false;
        }
        int dogru = 0, yanlıs = 0;

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                pictureBox1.Left -= 10;

            }
            else if (e.KeyCode == Keys.D)
            {
                pictureBox1.Left += 10;
            }
            else if (e.KeyCode == Keys.S)
            {
                pictureBox1.Top += 10;
            }
            else if (e.KeyCode == Keys.W)
            {
                pictureBox1.Top -= 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
                
            
                    baglan.Open();
                    SqlCommand getir = new SqlCommand("select SORUID=@p2 from TBLMARİO where CEVAP=@p1", baglan);
                    getir.Parameters.AddWithValue("@p1",textBox1.Text);
                    getir.Parameters.AddWithValue("@p2", int.Parse(label6.Text));
                    SqlDataReader okut = getir.ExecuteReader();
                    if (okut.Read())
                    {
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                        canavar3.Visible = true;
                        if (lbldogru.Text == "2")
                            {
                                canavar2.Visible = true;

                            }
                        else if (lbldogru.Text == "3")
                            {
                                canavar4.Visible = true;
                            }
                        else if (lbldogru.Text == "4")
                        {
                            canavar1.Visible = true;
                        }
            }
                    else
                    {
                        MessageBox.Show("tekrar cevaplayınız");
                        yanlıs++;
                        lblyanlıs.Text=yanlıs.ToString();
                    }
                    baglan.Close();
            if (lbldogru.Text == "4")
            {
                MessageBox.Show("tebrikler bütün canavarları ortaya çıkardınız");
                SON.Visible = true;
            }



        }
        }
    }
    

