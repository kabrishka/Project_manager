using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KC_20_Gimalova_project_manager
{
    public partial class Form1 : Form
    {
        //поля
        private Button currentButton;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Проекты";
            OpenChildForm(new Forms.ProjectForm(), sender);
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Задачи";
            OpenChildForm(new Forms.TasksForm(), sender);
        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        //Выделяем активную кнопку
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(253, 238, 33);
                    currentButton.ForeColor = Color.Black;
                    //увеличительный эффект
                    currentButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);                   
                    //работа с кнопкой закрытия вложенной формы
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        //Деактивация кнопки (дефолтное значение)
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.FromArgb(0,0,0);
                    previousBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        //Создаем метод, открывающий форму в container panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Reset()
        {
            //работа с кнопкой закрытия вложенной формы
            DisableButton();
            lblTitle.Text = "Домашняя страница";
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }      
    }
}
