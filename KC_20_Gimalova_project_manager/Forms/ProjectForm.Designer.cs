namespace KC_20_Gimalova_project_manager.Forms
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchProject = new System.Windows.Forms.Button();
            this.ProjectsTable = new System.Windows.Forms.DataGridView();
            this.txtSearchProject = new System.Windows.Forms.TextBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearchProject, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProjectsTable, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchProject, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddProject, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnChange, 4, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchProject.FlatAppearance.BorderSize = 0;
            this.btnSearchProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProject.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProject.Image")));
            this.btnSearchProject.Location = new System.Drawing.Point(209, 3);
            this.btnSearchProject.Name = "btnSearchProject";
            this.tableLayoutPanel1.SetRowSpan(this.btnSearchProject, 3);
            this.btnSearchProject.Size = new System.Drawing.Size(76, 63);
            this.btnSearchProject.TabIndex = 1;
            this.btnSearchProject.UseVisualStyleBackColor = false;
            // 
            // ProjectsTable
            // 
            this.ProjectsTable.AllowUserToAddRows = false;
            this.ProjectsTable.AllowUserToDeleteRows = false;
            this.ProjectsTable.BackgroundColor = System.Drawing.Color.White;
            this.ProjectsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.ProjectsTable, 5);
            this.ProjectsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsTable.Location = new System.Drawing.Point(44, 72);
            this.ProjectsTable.Name = "ProjectsTable";
            this.ProjectsTable.ReadOnly = true;
            this.ProjectsTable.RowHeadersVisible = false;
            this.ProjectsTable.RowHeadersWidth = 51;
            this.ProjectsTable.RowTemplate.Height = 24;
            this.ProjectsTable.Size = new System.Drawing.Size(694, 318);
            this.ProjectsTable.TabIndex = 2;
            this.ProjectsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsTable_CellClick);
            // 
            // txtSearchProject
            // 
            this.txtSearchProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(33)))));
            this.txtSearchProject.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearchProject.Location = new System.Drawing.Point(52, 26);
            this.txtSearchProject.Name = "txtSearchProject";
            this.txtSearchProject.Size = new System.Drawing.Size(151, 22);
            this.txtSearchProject.TabIndex = 0;
            this.txtSearchProject.TextChanged += new System.EventHandler(this.txtSearchProject_TextChanged);
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProject.FlatAppearance.BorderSize = 0;
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProject.Image")));
            this.btnAddProject.Location = new System.Drawing.Point(662, 3);
            this.btnAddProject.Name = "btnAddProject";
            this.tableLayoutPanel1.SetRowSpan(this.btnAddProject, 3);
            this.btnAddProject.Size = new System.Drawing.Size(76, 63);
            this.btnAddProject.TabIndex = 3;
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(580, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.tableLayoutPanel1.SetRowSpan(this.btnUpdate, 3);
            this.btnUpdate.Size = new System.Drawing.Size(76, 63);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(662, 396);
            this.btnDelete.Name = "btnDelete";
            this.tableLayoutPanel1.SetRowSpan(this.btnDelete, 2);
            this.btnDelete.Size = new System.Drawing.Size(76, 64);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(580, 396);
            this.btnChange.Name = "btnChange";
            this.tableLayoutPanel1.SetRowSpan(this.btnChange, 2);
            this.btnChange.Size = new System.Drawing.Size(76, 64);
            this.btnChange.TabIndex = 6;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearchProject;
        private System.Windows.Forms.Button btnSearchProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView ProjectsTable;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
    }
}