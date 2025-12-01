using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryAndSales
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connString = "server=localhost;userid=root;password=;database=pharmacy_inventorys;";
            string query = "SELECT TransactionID, SaleID, CustomerName, Quantity, Price, DateBought FROM transaction";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No data found in the transaction table.");
                        }
                        else
                        {
                           
                            dataGridView1.Columns.Clear();

                         
                            dataGridView1.DataSource = dt;

                            
                            dataGridView1.Columns["DateBought"].DefaultCellStyle.Format = "yyyy-MM-dd";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction data: " + ex.Message);
            }
        }
    }
}
