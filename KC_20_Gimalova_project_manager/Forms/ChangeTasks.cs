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
    public partial class ChangeTasks : Form
    {
        DataBase dataBase = new DataBase();
        
        public ChangeTasks()
        {
            InitializeComponent();
        }
        private void ChangeTasks_Load(object sender, EventArgs e)
        {
            DataBank.createItemsProject(listProjects);
            DataBank.createItemsStatus(Status);
        }

        private void btnChange_Click(object sender, EventArgs e)
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
                    DataBank.projectName = listProjects.Text;
                    DataBank.taskName = TaskName.Text;
                    DataBank.startDate = StartDate.Value.Date;
                    DataBank.endDate = EndDate.Value.Date;
                    DataBank.status = Status.Text;

                    Change();

                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Change()
        {
            //проверка на пустую строку 
            if (DataBank.row.Cells[0].Value.ToString() != string.Empty)
            {

                DataBank.row.SetValues(DataBank.id, DataBank.projectName, DataBank.taskName, DataBank.startDate.ToString("dd/MM/yyyy"),
                DataBank.endDate.ToString("dd/MM/yyyy"), DataBank.status );
                DataBank.row.Cells[6].Value = RowState.Modified;

            }

        }

        
    }
}
