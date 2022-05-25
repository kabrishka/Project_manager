namespace KC_20_Gimalova_project_manager.Forms
{
    partial class ChangeProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeProjects));
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDate.Location = new System.Drawing.Point(75, 275);
            this.EndDate.MinimumSize = new System.Drawing.Size(4, 40);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(229, 40);
            this.EndDate.TabIndex = 20;
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDate.Location = new System.Drawing.Point(75, 173);
            this.StartDate.MinimumSize = new System.Drawing.Size(4, 40);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(229, 40);
            this.StartDate.TabIndex = 19;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.Location = new System.Drawing.Point(180, 371);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(89, 73);
            this.btnClearAll.TabIndex = 18;
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(275, 371);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(89, 73);
            this.btnChange.TabIndex = 17;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(158, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Дата окончания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(187, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Дата начала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя проекта";
            // 
            // ProjectName
            // 
            this.ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectName.Location = new System.Drawing.Point(75, 65);
            this.ProjectName.MinimumSize = new System.Drawing.Size(4, 40);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(228, 34);
            this.ProjectName.TabIndex = 13;
            // 
            // ChangeProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 456);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectName);
            this.Name = "ChangeProjects";
            this.Text = "ChangeForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker EndDate;
        public System.Windows.Forms.DateTimePicker StartDate;
        public System.Windows.Forms.TextBox ProjectName;
    }
}