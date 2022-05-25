namespace KC_20_Gimalova_project_manager.Forms
{
    partial class CreateProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProject));
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ProjectName
            // 
            this.ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectName.Location = new System.Drawing.Point(76, 65);
            this.ProjectName.MinimumSize = new System.Drawing.Size(4, 40);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(228, 34);
            this.ProjectName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя проекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(159, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата окончания";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(276, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 73);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.Location = new System.Drawing.Point(181, 371);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(89, 73);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDate.Location = new System.Drawing.Point(76, 173);
            this.StartDate.MinimumSize = new System.Drawing.Size(4, 40);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(229, 40);
            this.StartDate.TabIndex = 11;
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDate.Location = new System.Drawing.Point(76, 275);
            this.EndDate.MinimumSize = new System.Drawing.Size(4, 40);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(229, 40);
            this.EndDate.TabIndex = 12;
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 456);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectName);
            this.Name = "CreateProject";
            this.Text = "CreateProject";
            this.Load += new System.EventHandler(this.CreateProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
    }
}