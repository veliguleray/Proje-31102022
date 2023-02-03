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

namespace Proje_31102022
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=302-10;Initial Catalog=proje_31.10.2022;User ID=WebMobile_302;Password=A869869a%");

        int sayac = 1;
        public void verigoster(string veriler)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }


        void kayitlar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(*) from kayit", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kayitsayisi.Text = dr[0].ToString();
            }
            baglanti.Close();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From kayit where tckimlikno=@V1", baglanti);
            komutsil.Parameters.AddWithValue("@V1", tckimlikno.Text);
            komutsil.ExecuteNonQuery();
            label8.Text = sayac--.ToString();
            if (sayac == -1)
            {
                MessageBox.Show("Silindi.");
            }
            baglanti.Close();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into kayit(tckimlikno,adisoyadi,yasi,mezuniyet,cinsiyet,telefonno) values (@V1,@V2,@V3,@V4,@V5,@V7)", baglanti);
            komut.Parameters.AddWithValue("@V1", tckimlikno.Text);
            komut.Parameters.AddWithValue("@V2", adisoyadi.Text);
            komut.Parameters.AddWithValue("@V3", yas.Text);
            komut.Parameters.AddWithValue("@V4", mezuniyet.Text);
           
            komut.Parameters.AddWithValue("@V7", telefon.Text);


            string Cins;
            if (bay.Checked)
            {

                Cins = "Bay";
                komut.Parameters.AddWithValue("@V5", Cins.ToString());
            }
            else if (bayan.Checked)
            {
                Cins = "Bayan";
                komut.Parameters.AddWithValue("@V5", Cins.ToString());
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyet Seçiniz..");

            }

            komut.ExecuteNonQuery();
            baglanti.Close();
            kayitlar();
            verigoster("select * from kayit");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verigoster("select * from kayit");
            kayitlar();
        }

        private void buttontumsil_Click(object sender, EventArgs e)
        {


            dataGridView1.Columns.Clear();

        }

        private void buttonara_Click(object sender, EventArgs e)
        {
            verigoster("select * from kayit");

        }

        private void buttonsiln_Click(object sender, EventArgs e)
        {

            tckimlikno.Clear();
            adisoyadi.Clear();
            yas.Clear();



        }

        private void buttonyeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
