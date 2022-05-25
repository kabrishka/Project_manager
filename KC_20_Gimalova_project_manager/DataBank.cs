using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KC_20_Gimalova_project_manager
{
    class DataBank
    {
        public static int id;
        public static string projectName;

        public static string projectNameToDelete = "";

        public static string taskName;
        public static DateTime startDate;
        public static DateTime endDate;
        public static string status;

        public static DataGridViewRow row;

        //создает в combobox 
        public static void createItemsProject(ComboBox comboBox)
        {
            DataBase dataBase = new DataBase();

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Clear();

            var query = "SELECT * FROM Project";
            using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
            {
                command.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                comboBox.DataSource = table;
                comboBox.DisplayMember = "NameProject";

            }
        }

        //создает в combobox статусы
        public static void createItemsStatus(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Clear();

            List<string> items = new List<string>() { "В разработке", "Завершено", "Отменен" };
            comboBox.DataSource = items;
        }
    }
}
