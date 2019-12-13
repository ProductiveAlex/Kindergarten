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
    public partial class Redactirovanie : Form
    {
        public static string upform = "Provider = Microsoft.Jet.OLEDB.4.0; data source = Kindergarten.mdb";
        OleDbConnection con = new OleDbConnection(upform);
        OleDbDataAdapter ad = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Redactirovanie()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            OleDbConnection conn = new OleDbConnection(upform);
            conn.Open();

            string CmdText = "Update [Родители] SET [ФИО Матери]=[@ФИО Матери], [Место работы Матери] = [@Место работы Матери], [Адрес Матери] = [@Адрес Матери], [ФИО Отца] = [@ФИО Отца], [Место работы Отца] = [@Место работы Отца], [Адрес Отца] = [@Адрес Отца], [Номер телефона Отца] = [@Номер телефона Отца], [Номер телефона Матери] = [@Номер телефона Матери]";
            OleDbCommand UP = new OleDbCommand(CmdText, conn);

            UP.Parameters.AddWithValue("ФИО Матери", textBox7.Text);
            UP.Parameters.AddWithValue("Место работы Матери", textBox8.Text);
            UP.Parameters.AddWithValue("Адрес Матери", textBox9.Text);
            UP.Parameters.AddWithValue("ФИО Отца", textBox10.Text);
            UP.Parameters.AddWithValue("Место работы Отца", textBox1.Text);
            UP.Parameters.AddWithValue("Адрес Отца", textBox2.Text);
            UP.Parameters.AddWithValue("Номер телефона Отца", textBox4.Text);
            UP.Parameters.AddWithValue("Номер телефона Матери", textBox5.Text);

            UP.ExecuteNonQuery();
            MessageBox.Show("Данные успешно изменены");
            //  conn.Close();
            f1.РодителиUP();
        }

        private void Redactirovanie_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            OleDbConnection conn = new OleDbConnection(upform);
            conn.Open();

            string CmdText = "Update [Родители] SET [ФИО]=[@ФИО], [Дата рождения] = [@Дата рождения], [Адрес] = [@Адрес], [Телефон] = [@Телефон], [Номер группы] = [@Номер группы]" + "Where [Код ребёнка] = [@Код ребёнка]";
            OleDbCommand UP = new OleDbCommand(CmdText, conn);

            UP.Parameters.AddWithValue("ФИО", textBox11.Text);
            UP.Parameters.AddWithValue("Дата рождения", textBox12.Text);
            UP.Parameters.AddWithValue("Адрес", textBox13.Text);
            UP.Parameters.AddWithValue("Телефон", textBox14.Text);
            UP.Parameters.AddWithValue("Номер группы", textBox15.Text);
            
            UP.ExecuteNonQuery();
            MessageBox.Show("Данные успешно изменены");
            //  conn.Close();
            f1.РебёнокUP();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
