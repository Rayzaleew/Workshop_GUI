using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Workshop_GUI
{
    public partial class Form1 : Form
    {
        private DatabaseManager databaseManager;
        //public void showCars()
        //{
        //    this.dataGridView1.DataSource = databaseManager.getCars();
        //    return;
        //}
        public void renderTable(string tableName)
        {
            this.dataGridView1.DataSource = databaseManager.getTable(tableName);
        }
        public void updateTable(string tableName)
        {
            DataTable current_table = (DataTable)this.dataGridView1.DataSource;
            databaseManager.updateTable(current_table, tableName);
        }
        public enum tables { cars, masters, repair_jobs }
        public Form1()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            renderTable("cars");
            //showCars();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculate_profit_Click(object sender, EventArgs e)
        {
            DateTime startDate = this.startDate.Value;
            DateTime endDate = this.EndDate.Value;
            this.incomeResult.Text = Convert.ToString(databaseManager.CalculateWorkshopIncome(startDate, endDate));
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            int tableIndex = this.comboBox1.SelectedIndex;
            string tableName = ((tables)tableIndex).ToString();
            renderTable(tableName);

        }

        private void save_changes_Click(object sender, EventArgs e)
        {
            int tableIndex = this.comboBox1.SelectedIndex;
            string tableName;
            if (tableIndex == -1)
            {
                tableName = "cars";
            }
            else
            {
                tableName = ((tables)tableIndex).ToString();
            }


            updateTable(tableName);

        }
    }
}
