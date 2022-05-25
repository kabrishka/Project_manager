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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class ProjectForm : Form
    {
        DataBase dataBase = new DataBase();
        SqlCommand command;
        SqlDataReader sqlDataReader;

        CreateProject createProject;
        ChangeProjects changeProjects;

        public int selectedRow;
        public ProjectForm()
        {
            InitializeComponent();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            createColumns();
            refreshDataGrid(ProjectsTable);

            btnDelete.Visible = false;
            btnChange.Visible = false;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            createProject = new CreateProject();
            createProject.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //обновление при удалении
            Update(ProjectsTable);

            refreshDataGrid(ProjectsTable);

            
        }

        private void txtSearchProject_TextChanged(object sender, EventArgs e)
        {
            Search(ProjectsTable, txtSearchProject);
        }
        private void ProjectsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible = true;
            btnChange.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow(ProjectsTable);
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            changeProjects = new ChangeProjects();

            int selectedRowIndex = ProjectsTable.CurrentCell.RowIndex;

            //e.RowIndex >= 0, тк если мы нажмем, например, на строку с названиями столбцов, то 
            //выйдет ошибка, что мы за границами индекса
            if (selectedRowIndex >= 0)
            {
                DataBank.row = ProjectsTable.Rows[selectedRowIndex];

                changeProjects.Show();

                DataBank.id = Convert.ToInt32(DataBank.row.Cells[0].Value);
                changeProjects.ProjectName.Text = DataBank.row.Cells[1].Value.ToString();
                changeProjects.StartDate.Value = Convert.ToDateTime(DataBank.row.Cells[2].Value);
                changeProjects.EndDate.Value = Convert.ToDateTime(DataBank.row.Cells[3].Value);

            }
        }

        //название стобцов в DataGridView
        private void createColumns()
        {
            ProjectsTable.Columns.Add("id", "ID");
            ProjectsTable.Columns.Add("ProjectName", "Проект");
            ProjectsTable.Columns.Add("StartDate", "Начало");
            ProjectsTable.Columns.Add("EndDate", "Конец");
            ProjectsTable.Columns.Add("IsNew", string.Empty);

            ProjectsTable.Columns[0].Visible = false;
            ProjectsTable.Columns[4].Visible = false;
        }

        //IDataRecord - предоставляет доступ к значениям столбцов для каждой строки
        private void readSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDateTime(2).ToShortDateString(),
                record.GetDateTime(3).ToShortDateString(), RowState.ModifiedNew);
        }

        //вывод данных в таблицу
        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT * FROM Project";

            command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                readSingleRow(dgw, sqlDataReader);
            }

            sqlDataReader.Close();
        }

        //поиск в БД
        private void Search(DataGridView dgw, TextBox txt)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM Project WHERE  CONCAT (id,NameProject,StartDate,EndDate) LIKE N'%" + txt.Text + "%'";

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
                dataGridView.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridView.Rows[index].Cells[4].Value = RowState.Deleted;

        }

        private void Update(DataGridView dataGridView)
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    //занесем индекс той строки, в которой находимся
                    var id = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                    DataBank.projectNameToDelete = dataGridView.Rows[index].Cells[1].Value.ToString();
                  
                    var deleteQuery = $"DELETE FROM Project WHERE id = {id}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());

                    command.ExecuteNonQuery();
                    
                }
                if (rowState == RowState.Modified)
                {
                    var id = ProjectsTable.Rows[index].Cells[0].Value.ToString();
                    var nameProject = ProjectsTable.Rows[index].Cells[1].Value.ToString();
                    var startDate = Convert.ToDateTime(ProjectsTable.Rows[index].Cells[2].Value);
                    var endDate = Convert.ToDateTime(ProjectsTable.Rows[index].Cells[3].Value);

                    var changeQuery = $"UPDATE Project SET NameProject = N'{nameProject}'," +
                        $"StartDate = N'{startDate.ToString("yyyy/MM/dd")}'," +
                        $"EndDate = '{endDate.ToString("yyyy/MM/dd")}' WHERE id = '{id}'";

                    var commad = new SqlCommand(changeQuery, dataBase.getConnection());
                    commad.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();

        }

        
    }
}
