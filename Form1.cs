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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; data source = Kindergarten.mdb");
        OleDbDataAdapter ad = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Родители". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter.Fill(this.kindergartenDataSet.Родители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Ребёнок". При необходимости она может быть перемещена или удалена.
            this.ребёнокTableAdapter.Fill(this.kindergartenDataSet.Ребёнок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.kindergartenDataSet.Персонал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.kindergartenDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Воспитатели". При необходимости она может быть перемещена или удалена.
            this.воспитателиTableAdapter.Fill(this.kindergartenDataSet.Воспитатели);

        }
        public void РодителиUP()
        {
            ad.SelectCommand = new OleDbCommand("select* from [Родители]", con);

            ds.Clear();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Open();
            ad.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
        public void РебёнокUP()
        {
            ad.SelectCommand = new OleDbCommand("select* from [Ребёнок]", con);

            ds.Clear();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Open();
            ad.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
        public void ПерсоналUP()
        {
            ad.SelectCommand = new OleDbCommand("select* from [Персонал]", con);

            ds.Clear();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Open();
            ad.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
        public void ГруппаUP()
        {
            ad.SelectCommand = new OleDbCommand("select* from [Группа]", con);

            ds.Clear();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Open();
            ad.SelectCommand.ExecuteNonQuery();
            con.Close();
        }
        public void ВоспитателиUP()
        {
            ad.SelectCommand = new OleDbCommand("select* from [Воспитатели]", con);

            ds.Clear();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Open();
            ad.SelectCommand.ExecuteNonQuery();
            con.Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled == true)
            {
                dataGridView1.DataSource = родителиBindingSource;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Enabled == true)
            {
                dataGridView1.DataSource = ребёнокBindingSource;
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Enabled == true)
            {
                dataGridView1.DataSource = воспитателиBindingSource;
            }
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Enabled == true)
            {
                dataGridView1.DataSource = персоналBindingSource;
            }
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Enabled == true)
            {
                dataGridView1.DataSource = группаBindingSource;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Zaprosi zaprosi = new Zaprosi();
            zaprosi.Show();
            // ....
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dobvlenie D = new Dobvlenie();
            D.Show();
            РодителиUP();
            РебёнокUP();
            ПерсоналUP();
            ГруппаUP();
            ВоспитателиUP();
        }
    }
}
