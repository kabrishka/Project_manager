using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KC_20_Gimalova_project_manager.Forms
{
    public partial class ChangeProjects : Form
    {
        public ChangeProjects()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProjectName.Text == "")
                {
                    MessageBox.Show("Вы не ввели имя проекта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (StartDate.Value.Date > EndDate.Value.Date)
                {
                    MessageBox.Show("Даты не в верном порядке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataBank.projectName = ProjectName.Text;
                    DataBank.startDate = StartDate.Value.Date;
                    DataBank.endDate = EndDate.Value.Date;

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

                DataBank.row.SetValues(DataBank.id, DataBank.projectName, DataBank.startDate.ToString("dd/MM/yyyy"),
                DataBank.endDate.ToString("dd/MM/yyyy"));
                DataBank.row.Cells[4].Value = RowState.Modified;

            }

        }
    }
}
