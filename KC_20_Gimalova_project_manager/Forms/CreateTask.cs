using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KC_20_Gimalova_project_manager.Forms
{
    public partial class CreateTask : Form
    {
        DataBase dataBase = new DataBase();
        public CreateTask()
        {
            InitializeComponent();
        }

        private void CreateTask_Load(object sender, EventArgs e)
        {
            DataBank.createItemsProject(listProjects);
            DataBank.createItemsStatus(Status);
        }

        

        
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TaskName.Text == "")
                {
                    MessageBox.Show("Вы не ввели имя задачи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (StartDate.Value.Date > EndDate.Value.Date)
                {
                    MessageBox.Show("Даты не в верном порядке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var projectName = listProjects.Text;
                    var taskName = TaskName.Text;
                    var startDate = StartDate.Value.Date;
                    var endDate = EndDate.Value.Date;
                    var status = Status.Text;

                    dataBase.openConnection();
                    var addQuery = $"INSERT INTO [Tasks] (ProjectName, TaskName, StartDate, EndDate, Status) VALUES (N'{projectName}', N'{taskName}', @StartDate, @EndDate, N'{status}')";

                    var command = new SqlCommand(addQuery, dataBase.getConnection());
                    command.Parameters.Add("StartDate", startDate.ToString("yyyy/MM/dd"));
                    command.Parameters.Add("EndDate", endDate.ToString("yyyy/MM/dd"));
                    command.ExecuteNonQuery();

                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            dataBase.closeConnection();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listProjects.SelectedIndex = 0;
            TaskName.Text = "";
            StartDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
            Status.SelectedIndex = 0;
        }
    }
}
