namespace KC_20_Gimalova_project_manager.Forms
{
    partial class TasksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchTask = new System.Windows.Forms.Button();
            this.TasksTable = new System.Windows.Forms.DataGridView();
            this.txtSearchTask = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearchTask, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TasksTable, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchTask, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddTask, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 5, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSearchTask
            // 
            this.btnSearchTask.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchTask.FlatAppearance.BorderSize = 0;
            this.btnSearchTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTask.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTask.Image")));
            this.btnSearchTask.Location = new System.Drawing.Point(203, 3);
            this.btnSearchTask.Name = "btnSearchTask";
            this.tableLayoutPanel1.SetRowSpan(this.btnSearchTask, 3);
            this.btnSearchTask.Size = new System.Drawing.Size(74, 60);
            this.btnSearchTask.TabIndex = 1;
            this.btnSearchTask.UseVisualStyleBackColor = false;
            // 
            // TasksTable
            // 
            this.TasksTable.AllowUserToAddRows = false;
            this.TasksTable.AllowUserToDeleteRows = false;
            this.TasksTable.BackgroundColor = System.Drawing.Color.White;
            this.TasksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.TasksTable, 5);
            this.TasksTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksTable.Location = new System.Drawing.Point(43, 69);
            this.TasksTable.Name = "TasksTable";
            this.TasksTable.ReadOnly = true;
            this.TasksTable.RowHeadersVisible = false;
            this.TasksTable.RowHeadersWidth = 51;
            this.TasksTable.RowTemplate.Height = 24;
            this.TasksTable.Size = new System.Drawing.Size(714, 309);
            this.TasksTable.TabIndex = 2;
            this.TasksTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TasksTable_CellClick);
            // 
            // txtSearchTask
            // 
            this.txtSearchTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(238)))), ((int)(((byte)(33)))));
            this.txtSearchTask.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearchTask.Location = new System.Drawing.Point(43, 25);
            this.txtSearchTask.Name = "txtSearchTask";
            this.txtSearchTask.Size = new System.Drawing.Size(154, 22);
            this.txtSearchTask.TabIndex = 0;
            this.txtSearchTask.TextChanged += new System.EventHandler(this.txtSearchTask_TextChanged);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTask.Image")));
            this.btnAddTask.Location = new System.Drawing.Point(603, 3);
            this.btnAddTask.Name = "btnAddTask";
            this.tableLayoutPanel1.SetRowSpan(this.btnAddTask, 3);
            this.btnAddTask.Size = new System.Drawing.Size(74, 60);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(683, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.tableLayoutPanel1.SetRowSpan(this.btnUpdate, 3);
            this.btnUpdate.Size = new System.Drawing.Size(74, 60);
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
            this.btnDelete.Location = new System.Drawing.Point(683, 384);
            this.btnDelete.Name = "btnDelete";
            this.tableLayoutPanel1.SetRowSpan(this.btnDelete, 2);
            this.btnDelete.Size = new System.Drawing.Size(74, 63);
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
            this.btnChange.Location = new System.Drawing.Point(603, 384);
            this.btnChange.Name = "btnChange";
            this.tableLayoutPanel1.SetRowSpan(this.btnChange, 2);
            this.btnChange.Size = new System.Drawing.Size(74, 63);
            this.btnChange.TabIndex = 6;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TasksForm";
            this.Text = "TasksForm";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSearchTask;
        private System.Windows.Forms.DataGridView TasksTable;
        private System.Windows.Forms.TextBox txtSearchTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
    }
}