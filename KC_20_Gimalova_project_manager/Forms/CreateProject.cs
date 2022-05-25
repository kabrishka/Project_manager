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
using System.IO;

namespace KC_20_Gimalova_project_manager.Forms
{
    public partial class CreateProject : Form
    {
        DataBase dataBase = new DataBase();
        public CreateProject()
        {
            InitializeComponent();
            StartDate.Format = DateTimePickerFormat.Short;
            EndDate.Format = DateTimePickerFormat.Short;

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {              
                if(ProjectName.Text == "")
                {
                    MessageBox.Show("Вы не ввели имя проекта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (StartDate.Value.Date > EndDate.Value.Date)
                {
                    MessageBox.Show("Даты не в верном порядке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var projectName = ProjectName.Text;
                    var startDate = StartDate.Value.Date;
                    var endDate = EndDate.Value.Date;

                    dataBase.openConnection();
                    var addQuery = $"INSERT INTO [Project] (NameProject, StartDate, EndDate) VALUES (N'{projectName}', @StartDate, @EndDate)";

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
            ProjectName.Clear();
            StartDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {

        }
    }
}
