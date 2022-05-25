namespace KC_20_Gimalova_project_manager.Forms
{
    partial class CreateTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTask));
            this.listProjects = new System.Windows.Forms.ComboBox();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listProjects
            // 
            this.listProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(94, 65);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(228, 37);
            this.listProjects.TabIndex = 0;
            // 
            // TaskName
            // 
            this.TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskName.Location = new System.Drawing.Point(94, 150);
            this.TaskName.MinimumSize = new System.Drawing.Size(4, 40);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(228, 34);
            this.TaskName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(178, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата окончания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Дата начала";
            // 
            // Status
            // 
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(94, 437);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(228, 37);
            this.Status.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(249, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Задача";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(251, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Проект";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(255, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Статус";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.Location = new System.Drawing.Point(211, 505);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(89, 73);
            this.btnClearAll.TabIndex = 19;
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(306, 505);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 73);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDate.Location = new System.Drawing.Point(97, 238);
            this.StartDate.MinimumSize = new System.Drawing.Size(4, 40);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(227, 40);
            this.StartDate.TabIndex = 20;
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDate.Location = new System.Drawing.Point(97, 340);
            this.EndDate.MinimumSize = new System.Drawing.Size(4, 40);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(227, 40);
            this.EndDate.TabIndex = 21;
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 590);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.listProjects);
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.Load += new System.EventHandler(this.CreateTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listProjects;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
    }
}