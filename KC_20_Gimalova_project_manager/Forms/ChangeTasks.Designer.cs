namespace KC_20_Gimalova_project_manager.Forms
{
    partial class ChangeTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeTasks));
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.listProjects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDate.Location = new System.Drawing.Point(97, 339);
            this.EndDate.MinimumSize = new System.Drawing.Size(4, 40);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(227, 40);
            this.EndDate.TabIndex = 33;
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDate.Location = new System.Drawing.Point(97, 237);
            this.StartDate.MinimumSize = new System.Drawing.Size(4, 40);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(227, 40);
            this.StartDate.TabIndex = 32;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.Location = new System.Drawing.Point(211, 504);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(89, 73);
            this.btnClearAll.TabIndex = 31;
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(306, 504);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(89, 73);
            this.btnChange.TabIndex = 30;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(255, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(251, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Проект";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(249, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Задача";
            // 
            // Status
            // 
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(94, 436);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(228, 37);
            this.Status.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(178, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Дата окончания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Дата начала";
            // 
            // TaskName
            // 
            this.TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskName.Location = new System.Drawing.Point(94, 149);
            this.TaskName.MinimumSize = new System.Drawing.Size(4, 40);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(228, 34);
            this.TaskName.TabIndex = 23;
            // 
            // listProjects
            // 
            this.listProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProjects.FormattingEnabled = true;
            this.listProjects.Location = new System.Drawing.Point(94, 65);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(228, 37);
            this.listProjects.TabIndex = 22;
            // 
            // ChangeTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 590);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.listProjects);
            this.Name = "ChangeTasks";
            this.Text = "ChangeTasks";
            this.Load += new System.EventHandler(this.ChangeTasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker EndDate;
        public System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TaskName;
        public System.Windows.Forms.ComboBox listProjects;
    }
}