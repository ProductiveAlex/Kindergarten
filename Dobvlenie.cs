using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten
{
    public partial class Dobvlenie : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; data source = Kindergarten.mdb");
        OleDbDataAdapter ad = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Dobvlenie()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            try
            {
                con.Open();
                OleDbCommand AD = new OleDbCommand("insert into [Родители]([Код родителя], [ФИО Матери], [Место работы Матери], [Адрес Матери], [ФИО Отца], [Место работы Отца], [Адрес Отца], [Код ребёнка], [Номер телефона Отца], [Номер телефона Матери]) values ([@Код родителя], [@ФИО Матери], [@Место работы Матери], [@Адрес Матери], [@ФИО Отца], [@Место работы Отца], [@Адрес Отца], [@Код ребёнка], [@Номер телефона Отца], [@Номер телефона Матери])", con);
                AD.Parameters.Add("@Код родителя", OleDbType.VarChar).Value = textBox1.Text.ToString();
                AD.Parameters.Add("@ФИО Матери", OleDbType.VarChar).Value = textBox2.Text.ToString();
                AD.Parameters.Add("@Место работы Матери", OleDbType.VarChar).Value = textBox3.Text.ToString();
                AD.Parameters.Add("@Адрес Матери", OleDbType.VarChar).Value = textBox4.Text.ToString();
                AD.Parameters.Add("@ФИО Отца", OleDbType.VarChar).Value = textBox5.Text.ToString();
                AD.Parameters.Add("@Место работы Отца", OleDbType.VarChar).Value = textBox6.Text.ToString();
                AD.Parameters.Add("@Адрес Отца", OleDbType.VarChar).Value = textBox7.Text.ToString();
                AD.Parameters.Add("@Код ребёнка", OleDbType.VarChar).Value = textBox8.Text.ToString();
                AD.Parameters.Add("@Номер телефона Отца", OleDbType.VarChar).Value = textBox9.Text.ToString();
                AD.Parameters.Add("@Номер телефона Матери", OleDbType.VarChar).Value = textBox10.Text.ToString();

                AD.ExecuteNonQuery();
                MessageBox.Show("Данные успешно сохранены");
                f1.РодителиUP();
                con.Close();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void Dobvlenie_Load(object sender, EventArgs e)
        {

        }
    }
}
