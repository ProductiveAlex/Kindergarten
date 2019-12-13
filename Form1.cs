using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Родители". При необходимости она может быть перемещена или удалена.
            this.родителиTableAdapter.Fill(this.kindergartenDataSet.Родители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.kindergartenDataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.kindergartenDataSet.Персонал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Воспитатели". При необходимости она может быть перемещена или удалена.
            this.воспитателиTableAdapter.Fill(this.kindergartenDataSet.Воспитатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindergartenDataSet.Ребёнок". При необходимости она может быть перемещена или удалена.
            this.ребёнокTableAdapter.Fill(this.kindergartenDataSet.Ребёнок);

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

        }
    }
}
