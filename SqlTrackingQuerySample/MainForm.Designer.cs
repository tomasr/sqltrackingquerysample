namespace SqlTrackingQuerySample
{
   partial class MainForm
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
         if ( disposing && (components != null) )
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.instancesGrid = new System.Windows.Forms.DataGridView();
         this.workflowInstanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.workflowTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.invokingWorkflowInstanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.workflowInstanceInternalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.trackingBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.connectDbButton = new System.Windows.Forms.ToolStripButton();
         this.RefreshButton = new System.Windows.Forms.ToolStripButton();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.wfDescTextBox = new System.Windows.Forms.TextBox();
         this.wfNameTextBox = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.userEventsGrid = new System.Windows.Forms.DataGridView();
         this.userEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.wfEventsGrid = new System.Windows.Forms.DataGridView();
         this.ArgsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.wfEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.instancesGrid)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackingBindingSource)).BeginInit();
         this.toolStrip1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.userEventsGrid)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.userEventsBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.wfEventsGrid)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.wfEventsBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.instancesGrid);
         this.groupBox1.Controls.Add(this.toolStrip1);
         this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
         this.groupBox1.Location = new System.Drawing.Point(0, 0);
         this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.groupBox1.Size = new System.Drawing.Size(662, 158);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Workflow Instances";
         // 
         // instancesGrid
         // 
         this.instancesGrid.AllowUserToAddRows = false;
         this.instancesGrid.AllowUserToDeleteRows = false;
         this.instancesGrid.AutoGenerateColumns = false;
         this.instancesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
         this.instancesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.instancesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.instancesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workflowInstanceIdDataGridViewTextBoxColumn,
            this.workflowTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.invokingWorkflowInstanceIdDataGridViewTextBoxColumn,
            this.workflowInstanceInternalIdDataGridViewTextBoxColumn});
         this.instancesGrid.DataSource = this.trackingBindingSource;
         this.instancesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
         this.instancesGrid.Location = new System.Drawing.Point(2, 40);
         this.instancesGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.instancesGrid.MultiSelect = false;
         this.instancesGrid.Name = "instancesGrid";
         this.instancesGrid.ReadOnly = true;
         this.instancesGrid.RowTemplate.Height = 24;
         this.instancesGrid.Size = new System.Drawing.Size(658, 116);
         this.instancesGrid.TabIndex = 1;
         // 
         // workflowInstanceIdDataGridViewTextBoxColumn
         // 
         this.workflowInstanceIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.workflowInstanceIdDataGridViewTextBoxColumn.DataPropertyName = "WorkflowInstanceId";
         this.workflowInstanceIdDataGridViewTextBoxColumn.HeaderText = "WorkflowInstanceId";
         this.workflowInstanceIdDataGridViewTextBoxColumn.Name = "workflowInstanceIdDataGridViewTextBoxColumn";
         this.workflowInstanceIdDataGridViewTextBoxColumn.ReadOnly = true;
         this.workflowInstanceIdDataGridViewTextBoxColumn.Width = 127;
         // 
         // workflowTypeDataGridViewTextBoxColumn
         // 
         this.workflowTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.workflowTypeDataGridViewTextBoxColumn.DataPropertyName = "WorkflowType";
         this.workflowTypeDataGridViewTextBoxColumn.HeaderText = "WorkflowType";
         this.workflowTypeDataGridViewTextBoxColumn.Name = "workflowTypeDataGridViewTextBoxColumn";
         this.workflowTypeDataGridViewTextBoxColumn.ReadOnly = true;
         this.workflowTypeDataGridViewTextBoxColumn.Width = 101;
         // 
         // statusDataGridViewTextBoxColumn
         // 
         this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
         this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
         this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
         this.statusDataGridViewTextBoxColumn.ReadOnly = true;
         this.statusDataGridViewTextBoxColumn.Width = 62;
         // 
         // invokingWorkflowInstanceIdDataGridViewTextBoxColumn
         // 
         this.invokingWorkflowInstanceIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.invokingWorkflowInstanceIdDataGridViewTextBoxColumn.DataPropertyName = "InvokingWorkflowInstanceId";
         this.invokingWorkflowInstanceIdDataGridViewTextBoxColumn.HeaderText = "InvokingWorkflowInstanceId";
         this.invokingWorkflowInstanceIdDataGridViewTextBoxColumn.Name = "invokingWorkflowInstanceIdDataGridViewTextBoxColumn";
         this.invokingWorkflowInstanceIdDataGridViewTextBoxColumn.ReadOnly = true;
         this.invokingWorkflowInstanceIdDataGridViewTextBoxColumn.Width = 168;
         // 
         // workflowInstanceInternalIdDataGridViewTextBoxColumn
         // 
         this.workflowInstanceInternalIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.workflowInstanceInternalIdDataGridViewTextBoxColumn.DataPropertyName = "WorkflowInstanceInternalId";
         this.workflowInstanceInternalIdDataGridViewTextBoxColumn.HeaderText = "WorkflowInstanceInternalId";
         this.workflowInstanceInternalIdDataGridViewTextBoxColumn.Name = "workflowInstanceInternalIdDataGridViewTextBoxColumn";
         this.workflowInstanceInternalIdDataGridViewTextBoxColumn.ReadOnly = true;
         this.workflowInstanceInternalIdDataGridViewTextBoxColumn.Width = 162;
         // 
         // trackingBindingSource
         // 
         this.trackingBindingSource.DataSource = typeof(System.Workflow.Runtime.Tracking.SqlTrackingWorkflowInstance);
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectDbButton,
            this.RefreshButton});
         this.toolStrip1.Location = new System.Drawing.Point(2, 15);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(658, 25);
         this.toolStrip1.TabIndex = 0;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // connectDbButton
         // 
         this.connectDbButton.Image = ((System.Drawing.Image)(resources.GetObject("connectDbButton.Image")));
         this.connectDbButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.connectDbButton.Name = "connectDbButton";
         this.connectDbButton.Size = new System.Drawing.Size(129, 22);
         this.connectDbButton.Text = "Connect to Database";
         this.connectDbButton.Click += new System.EventHandler(this.connectDbButton_Click);
         // 
         // RefreshButton
         // 
         this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
         this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.RefreshButton.Name = "RefreshButton";
         this.RefreshButton.Size = new System.Drawing.Size(65, 22);
         this.RefreshButton.Text = "Refresh";
         this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.wfDescTextBox);
         this.groupBox2.Controls.Add(this.wfNameTextBox);
         this.groupBox2.Controls.Add(this.label4);
         this.groupBox2.Controls.Add(this.label3);
         this.groupBox2.Controls.Add(this.userEventsGrid);
         this.groupBox2.Controls.Add(this.wfEventsGrid);
         this.groupBox2.Controls.Add(this.label2);
         this.groupBox2.Controls.Add(this.label1);
         this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox2.Location = new System.Drawing.Point(0, 158);
         this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.groupBox2.Size = new System.Drawing.Size(662, 281);
         this.groupBox2.TabIndex = 1;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Instance Information";
         // 
         // wfDescTextBox
         // 
         this.wfDescTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.wfDescTextBox.BackColor = System.Drawing.SystemColors.Info;
         this.wfDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trackingBindingSource, "WorkflowDefinition.Description", true));
         this.wfDescTextBox.Location = new System.Drawing.Point(128, 32);
         this.wfDescTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.wfDescTextBox.Name = "wfDescTextBox";
         this.wfDescTextBox.ReadOnly = true;
         this.wfDescTextBox.Size = new System.Drawing.Size(525, 20);
         this.wfDescTextBox.TabIndex = 6;
         // 
         // wfNameTextBox
         // 
         this.wfNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.wfNameTextBox.BackColor = System.Drawing.SystemColors.Info;
         this.wfNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trackingBindingSource, "WorkflowDefinition.Name", true));
         this.wfNameTextBox.Location = new System.Drawing.Point(128, 12);
         this.wfNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.wfNameTextBox.Name = "wfNameTextBox";
         this.wfNameTextBox.ReadOnly = true;
         this.wfNameTextBox.Size = new System.Drawing.Size(525, 20);
         this.wfNameTextBox.TabIndex = 5;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(9, 35);
         this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(111, 13);
         this.label4.TabIndex = 4;
         this.label4.Text = "Workflow Description:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(9, 15);
         this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(80, 13);
         this.label3.TabIndex = 3;
         this.label3.Text = "Worflow Name:";
         // 
         // userEventsGrid
         // 
         this.userEventsGrid.AllowUserToAddRows = false;
         this.userEventsGrid.AllowUserToDeleteRows = false;
         this.userEventsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.userEventsGrid.AutoGenerateColumns = false;
         this.userEventsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.userEventsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
         this.userEventsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.userEventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.userEventsGrid.DataSource = this.userEventsBindingSource;
         this.userEventsGrid.Location = new System.Drawing.Point(9, 202);
         this.userEventsGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.userEventsGrid.Name = "userEventsGrid";
         this.userEventsGrid.ReadOnly = true;
         this.userEventsGrid.RowTemplate.Height = 24;
         this.userEventsGrid.Size = new System.Drawing.Size(644, 74);
         this.userEventsGrid.TabIndex = 2;
         // 
         // userEventsBindingSource
         // 
         this.userEventsBindingSource.DataMember = "UserEvents";
         this.userEventsBindingSource.DataSource = this.trackingBindingSource;
         // 
         // wfEventsGrid
         // 
         this.wfEventsGrid.AllowUserToAddRows = false;
         this.wfEventsGrid.AllowUserToDeleteRows = false;
         this.wfEventsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.wfEventsGrid.AutoGenerateColumns = false;
         this.wfEventsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
         this.wfEventsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.wfEventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.wfEventsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArgsColumn});
         this.wfEventsGrid.DataSource = this.wfEventsBindingSource;
         this.wfEventsGrid.Location = new System.Drawing.Point(9, 69);
         this.wfEventsGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.wfEventsGrid.Name = "wfEventsGrid";
         this.wfEventsGrid.ReadOnly = true;
         this.wfEventsGrid.RowTemplate.Height = 24;
         this.wfEventsGrid.Size = new System.Drawing.Size(644, 107);
         this.wfEventsGrid.TabIndex = 1;
         this.wfEventsGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.wfEventsGrid_RowsAdded);
         // 
         // ArgsColumn
         // 
         this.ArgsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.ArgsColumn.HeaderText = "Args";
         this.ArgsColumn.Name = "ArgsColumn";
         this.ArgsColumn.ReadOnly = true;
         this.ArgsColumn.Width = 53;
         // 
         // wfEventsBindingSource
         // 
         this.wfEventsBindingSource.DataMember = "WorkflowEvents";
         this.wfEventsBindingSource.DataSource = this.trackingBindingSource;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(9, 186);
         this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(65, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "User Events";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(9, 53);
         this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(88, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Workflow Events";
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "UserData";
         this.dataGridViewTextBoxColumn1.HeaderText = "UserData";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.Width = 93;
         // 
         // statusStrip1
         // 
         this.statusStrip1.Location = new System.Drawing.Point(0, 439);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
         this.statusStrip1.Size = new System.Drawing.Size(662, 22);
         this.statusStrip1.TabIndex = 7;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "UserData";
         this.dataGridViewTextBoxColumn2.HeaderText = "UserData";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         this.dataGridViewTextBoxColumn2.ReadOnly = true;
         this.dataGridViewTextBoxColumn2.Width = 93;
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "UserData";
         this.dataGridViewTextBoxColumn3.HeaderText = "UserData";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         this.dataGridViewTextBoxColumn3.Width = 93;
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(662, 461);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.groupBox1);
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "MainForm";
         this.Text = "Windows Workflow Sql Tracking Viewer";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.instancesGrid)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackingBindingSource)).EndInit();
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.userEventsGrid)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.userEventsBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.wfEventsGrid)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.wfEventsBindingSource)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton RefreshButton;
      private System.Windows.Forms.DataGridView instancesGrid;
      private System.Windows.Forms.BindingSource trackingBindingSource;
      private System.Windows.Forms.DataGridViewTextBoxColumn workflowInstanceIdDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn workflowTypeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn invokingWorkflowInstanceIdDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn workflowInstanceInternalIdDataGridViewTextBoxColumn;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.BindingSource wfEventsBindingSource;
      private System.Windows.Forms.DataGridView wfEventsGrid;
      private System.Windows.Forms.DataGridView userEventsGrid;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.BindingSource userEventsBindingSource;
      private System.Windows.Forms.DataGridViewTextBoxColumn eventOrderDataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn qualifiedNameDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn userDataKeyDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn userDataDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn activityTypeDataGridViewTextBoxColumn;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox wfDescTextBox;
      private System.Windows.Forms.TextBox wfNameTextBox;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.ToolStripButton connectDbButton;
      private System.Windows.Forms.DataGridViewTextBoxColumn eventOrderDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn trackingWorkflowEventDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn eventDateTimeDataGridViewTextBoxColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn ArgsColumn;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
   }
}