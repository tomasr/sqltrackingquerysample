namespace SqlTrackingQuerySample
{
   partial class SelectDbForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.okButton = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.instancesComboBox = new System.Windows.Forms.ComboBox();
         this.dbsComboBox = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(329, 37);
         this.label1.TabIndex = 0;
         this.label1.Text = "Select the SQL server tracking database to connect to from the list below:";
         // 
         // okButton
         // 
         this.okButton.Location = new System.Drawing.Point(266, 126);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(75, 23);
         this.okButton.TabIndex = 2;
         this.okButton.Text = "OK";
         this.okButton.UseVisualStyleBackColor = true;
         this.okButton.Click += new System.EventHandler(this.okButton_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 58);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(86, 17);
         this.label2.TabIndex = 3;
         this.label2.Text = "SQL Server:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 90);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(73, 17);
         this.label3.TabIndex = 4;
         this.label3.Text = "Database:";
         // 
         // instancesComboBox
         // 
         this.instancesComboBox.FormattingEnabled = true;
         this.instancesComboBox.Location = new System.Drawing.Point(104, 55);
         this.instancesComboBox.Name = "instancesComboBox";
         this.instancesComboBox.Size = new System.Drawing.Size(237, 24);
         this.instancesComboBox.TabIndex = 5;
         this.instancesComboBox.SelectedIndexChanged += new System.EventHandler(this.instancesComboBox_SelectedIndexChanged);
         // 
         // dbsComboBox
         // 
         this.dbsComboBox.FormattingEnabled = true;
         this.dbsComboBox.Location = new System.Drawing.Point(104, 87);
         this.dbsComboBox.Name = "dbsComboBox";
         this.dbsComboBox.Size = new System.Drawing.Size(237, 24);
         this.dbsComboBox.TabIndex = 6;
         // 
         // SelectDbForm
         // 
         this.AcceptButton = this.okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(352, 161);
         this.Controls.Add(this.dbsComboBox);
         this.Controls.Add(this.instancesComboBox);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.okButton);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "SelectDbForm";
         this.ShowInTaskbar = false;
         this.Text = "Select Tracking Database";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button okButton;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox instancesComboBox;
      private System.Windows.Forms.ComboBox dbsComboBox;
   }
}