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

            string CmdText = "Update [Родители] SET [ФИО Матери]=[@ФИО Матери], [Место работы Матери] = [@Место работы Матери], [Адрес Матери] = [@Адрес Матери], [ФИО Отца] = [@ФИО Отца], [Место работы Отца] = [@Место работы Отца], [Адрес Отца] = [@Адрес Отца], [Номер телефона Отца] = [@Номер телефона Отца], [Номер телефона Матери] = [@Номер телефона Матери]" + "Where [Код родителя] = [@Код родителя]";
            OleDbCommand UP = new OleDbCommand(CmdText, conn);

            UP.Parameters.AddWithValue("ФИО Матери", textBox2.Text);
            UP.Parameters.AddWithValue("Место работы Матери", textBox8.Text);
            UP.Parameters.AddWithValue("Адрес Матери", textBox4.Text);
            UP.Parameters.AddWithValue("ФИО Отца", textBox5.Text);
            UP.Parameters.AddWithValue("Место работы Отца", textBox6.Text);
            UP.Parameters.AddWithValue("Адрес Отца", textBox7.Text);
            UP.Parameters.AddWithValue("Номер телефона Отца", textBox9.Text);
            UP.Parameters.AddWithValue("Номер телефона Матери", textBox10.Text);

            UP.ExecuteNonQuery();
            MessageBox.Show("Данные успешно изменены");
            //  conn.Close();
            f1.РодителиUP();
        }
    }
}
