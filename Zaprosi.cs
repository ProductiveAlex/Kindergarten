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
    }
}
