using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Workshop_GUI
{
    public class DatabaseManager
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=Toor1470;Database=workshop;";
        private NpgsqlConnection ?connection;

        //private static DatabaseManager instance;

        //public static DatabaseManager Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new DatabaseManager();
        //        }
        //        return instance;
        //    }
        //}

        

        public NpgsqlConnection GetConnection()
        {
            try
            {
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        

        public DataTable getTable(string tableName)
        {
            DataTable dataTable = new DataTable();
            string sql_query = $"SELECT * FROM {tableName}";
            //switch (tableName)
            //{
            //    case "cars":
            //        sql_query = "SELECT cars.id, registration_number, car_types.name, repair_start_date, " +
            //            "issue_description, order_number, end_date, cost FROM cars " +
            //            "INNER JOIN car_types on cars.type_id = car_types.id";
            //        break;
            //    case "masters":
            //        sql_query = "SELECT masters.id, first_name, last_name, " +
            //            "number, specialties.name, hire_date FROM masters " +
            //            "INNER JOIN specialties on masters.speciality_id = specialties.id";
            //        break;
            //    case "repair_jobs":
            //        sql_query = "SELECT * from repair_jobs;";
            //        break;
            //    default:
            //        sql_query = "SELECT * FROM cars;";
            //        break;
            //}

            try
            {
                using (NpgsqlConnection connection = this.GetConnection())
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(sql_query, connection))
                    {
                        using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении операции: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        public double CalculateWorkshopIncome(DateTime startDate, DateTime endDate)
        {
            double totalIncome = 0;

            try
            {
                using (NpgsqlConnection connection = GetConnection())
                {
                    // Выполнение запроса для получения доходов за заданный период
                    string query = "SELECT SUM(cost) FROM cars WHERE end_date >= @StartDate AND end_date <= @EndDate";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        

                        // Получение результата запроса
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            totalIncome = Convert.ToDouble(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка исключения, если возникла ошибка при выполнении запроса
                MessageBox.Show("Ошибка при расчете доходов мастерской: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalIncome;
        }

        public void updateTable(DataTable dataTable, string tableName)
        {
            //DataTable dataTable = new DataTable();
            string sql_query = $"SELECT * FROM {tableName}";
            try
            {
                using (NpgsqlConnection connection = this.GetConnection())
                {
                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql_query, connection))
                    {
                        using (NpgsqlCommandBuilder commandBuilder = new NpgsqlCommandBuilder(dataAdapter))
                        {
                            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                            dataAdapter.Update(dataTable);
                        }
                    }

                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении таблицы: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //return dataTable;
            
        }

    }
}

