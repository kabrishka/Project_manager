using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KC_20_Gimalova_project_manager.Forms
{
    //состояние данных в таблице

    public partial class TasksForm : Form
    {
        //поля
        DataBase dataBase = new DataBase();
        SqlCommand command;
        SqlDataReader sqlDataReader;

        CreateTask createTask;
        ChangeTasks changeTasks;

        public int selectedRow;

        public TasksForm()
        {
            InitializeComponent();
        }
        private void TasksForm_Load(object sender, EventArgs e)
        {
            createColumns();
            refreshDataGrid(TasksTable);

            btnDelete.Visible = false;
            btnChange.Visible = false;

            if (DataBank.projectNameToDelete != "")
            {
                deleteAllItems(DataBank.projectNameToDelete, TasksTable);

                Update(TasksTable);
                refreshDataGrid(TasksTable);
            }
            
        }

        private void TasksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;
            btnChange.Visible = true;
        }

        //название стобцов в DataGridView
        private void createColumns()
        {
            TasksTable.Columns.Add("id", "ID");
            TasksTable.Columns.Add("ProjectName", "Проект");
            TasksTable.Columns.Add("TaskName", "Задача");
            TasksTable.Columns.Add("StartDate", "Начало");
            TasksTable.Columns.Add("EndDate", "Конец");
            TasksTable.Columns.Add("Status", "Статус");
            TasksTable.Columns.Add("IsNew", string.Empty);

            TasksTable.Columns[0].Visible = false;
            TasksTable.Columns[6].Visible = false;
        }

        //IDataRecord - предоставляет доступ к значениям столбцов для каждой строки
        private void readSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), 
                record.GetDateTime(3).ToShortDateString(), record.GetDateTime(4).ToShortDateString(),
                record.GetString(5), RowState.ModifiedNew);
        }

        //вывод данных в таблицу
        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT * FROM Tasks";

            command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                readSingleRow(dgw, sqlDataReader);
            }

            sqlDataReader.Close();
        }

        

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            createTask = new CreateTask();
            createTask.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update(TasksTable);

            refreshDataGrid(TasksTable);
        }

        private void txtSearchTask_TextChanged(object sender, EventArgs e)
        {
            Search(TasksTable, txtSearchTask);
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            changeTasks = new ChangeTasks();

            int selectedRowIndex = TasksTable.CurrentCell.RowIndex;

            //e.RowIndex >= 0, тк если мы нажмем, например, на строку с названиями столбцов, то 
            //выйдет ошибка, что мы за границами индекса
            if (selectedRowIndex >= 0)
            {
                DataBank.row = TasksTable.Rows[selectedRowIndex];

                changeTasks.Show();

                DataBank.id = Convert.ToInt32(DataBank.row.Cells[0].Value);
                changeTasks.listProjects.SelectedItem = DataBank.row.Cells[1].Value.ToString();
                changeTasks.TaskName.Text = DataBank.row.Cells[2].Value.ToString();
                changeTasks.StartDate.Value = Convert.ToDateTime(DataBank.row.Cells[3].Value);
                changeTasks.EndDate.Value = Convert.ToDateTime(DataBank.row.Cells[4].Value);
                changeTasks.Status.SelectedItem = DataBank.row.Cells[5].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow(TasksTable);
        }

        //поиск в БД
        private void Search(DataGridView dgw, TextBox txt)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM Tasks WHERE  CONCAT (id,ProjectName,TaskName,StartDate,EndDate, Status) LIKE N'%" + txt.Text + "%'";

            command = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                readSingleRow(dgw, sqlDataReader);
            }
            sqlDataReader.Close();
        }

        //удаление
        private void deleteRow(DataGridView dataGridView)
        {
            //передаем индекс той строки, в которой находимся
            int index = dataGridView.CurrentCell.RowIndex;

            //скрываем 
            dataGridView.Rows[index].Visible = false;

            //проверяем, если пустая строка
            if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView.Rows[index].Cells[6].Value = RowState.Deleted;

        }

        //удаление всех строк, где есть схожесть с названием удаленного проекта
        private void deleteAllItems(string del, DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                        if (dataGridView.Rows[i].Cells[j].Value.ToString().Contains(del))
                        {
                            dataGridView.Rows[i].Selected = false;
                            dataGridView.Rows[i].Cells[6].Value = RowState.Deleted;
                            break;
                        }
            }
        }

        private void Update(DataGridView dataGridView)
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    //занесем индекс той строки, в которой находимся
                    var id = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM Tasks WHERE id = {id}";

                    var commad = new SqlCommand(deleteQuery, dataBase.getConnection());
                    commad.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {


                    var id = TasksTable.Rows[index].Cells[0].Value.ToString();
                    var nameProject = TasksTable.Rows[index].Cells[1].Value.ToString();
                    var nameTask = TasksTable.Rows[index].Cells[2].Value.ToString();
                    var startDate = Convert.ToDateTime(TasksTable.Rows[index].Cells[3].Value);
                    var endDate = Convert.ToDateTime(TasksTable.Rows[index].Cells[4].Value);
                    var status = TasksTable.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"UPDATE Tasks SET ProjectName = N'{nameProject}'," +
                        $"TaskName = N'{nameTask}'," +
                        $"StartDate = N'{startDate.ToString("yyyy/MM/dd")}'," +
                        $"EndDate = '{endDate.ToString("yyyy/MM/dd")}'," +
                        $"Status = N'{status}' WHERE id = '{id}'";

                    var commad = new SqlCommand(changeQuery, dataBase.getConnection());
                    commad.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();

        }

        
    }
}
