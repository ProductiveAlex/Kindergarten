using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kindergarten
{
    public partial class Zaprosi : Form
    {
        public Zaprosi()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; data source = Kindergarten.mdb"); // Подключение

        private void button1_Click(object sender, EventArgs e)
        {
            //string name = adding.branch[i].name_of_assortment;
            con.Open();
            OleDbDataAdapter Adapter = new OleDbDataAdapter("SELECT * FROM Ребёнок", con);
            DataTable Table = new DataTable();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Table;
            Adapter.Fill(Table);
            MessageBox.Show("Успешно");
            con.Close();
        }


        public void search_by_name(int checker)
        {

            switch (checker)
            {
                case 1:
                   

                           
                            con.Open();
         
                            OleDbDataAdapter Adapter = new OleDbDataAdapter("SELECT * FROM Воспитатели", con);
                            DataTable Table = new DataTable();
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = Table;
                            Adapter.Fill(Table);
                            MessageBox.Show("Успешно");
                            con.Close();
                 


                    break;
                case 2:
                    
                        
                            con.Open();
                            //OleDbDataAdapter Adapter = new OleDbDataAdapter("SELECT * FROM Ассортимент Where Наименование = '" + name + "'", con);
                           // DataTable Table = new DataTable();

                            dataGridView1.AutoGenerateColumns = true;
                          //  dataGridView1.DataSource = Table;
                         //   Adapter.Fill(Table);
                            MessageBox.Show("Успешно");
                            con.Close();
                        
                    
                    break;
                case 3:
                    break;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            search_by_name(checker);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       
        private void Zaprosi_Load(object sender, EventArgs e)
        {

        }
        public int checker;
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                checker = 3;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                checker = 2;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                checker = 1;
            }
        }
    }
}
