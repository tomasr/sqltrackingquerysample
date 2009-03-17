namespace SqlTrackingQuerySample
{
   partial class AssemblyLoadForm
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
         this.assemblyNameLabel = new System.Windows.Forms.Label();
         this.assemblyPathTextBox = new System.Windows.Forms.TextBox();
         this.findButton = new System.Windows.Forms.Button();
         this.okButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(464, 55);
         this.label1.TabIndex = 0;
         this.label1.Text = "An assembly required to enumerate workflow instances from the Tracking Database i" +
             "s needed and cannot be loaded. Please select the appropriate assembly from disk " +
             "to allow enumeration to continue.";
         // 
         // assemblyNameLabel
         // 
         this.assemblyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.assemblyNameLabel.BackColor = System.Drawing.SystemColors.Info;
         this.assemblyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.assemblyNameLabel.Location = new System.Drawing.Point(12, 73);
         this.assemblyNameLabel.Name = "assemblyNameLabel";
         this.assemblyNameLabel.Size = new System.Drawing.Size(464, 56);
         this.assemblyNameLabel.TabIndex = 1;
         // 
         // assemblyPathTextBox
         // 
         this.assemblyPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.assemblyPathTextBox.Location = new System.Drawing.Point(12, 145);
         this.assemblyPathTextBox.Name = "assemblyPathTextBox";
         this.assemblyPathTextBox.Size = new System.Drawing.Size(428, 22);
         this.assemblyPathTextBox.TabIndex = 2;
         this.assemblyPathTextBox.TextChanged += new System.EventHandler(this.assemblyPathTextBox_TextChanged);
         // 
         // findButton
         // 
         this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.findButton.Location = new System.Drawing.Point(446, 144);
         this.findButton.Name = "findButton";
         this.findButton.Size = new System.Drawing.Size(30, 23);
         this.findButton.TabIndex = 3;
         this.findButton.Text = "...";
         this.findButton.UseVisualStyleBackColor = true;
         this.findButton.Click += new System.EventHandler(this.findButton_Click);
         // 
         // okButton
         // 
         this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.okButton.Enabled = false;
         this.okButton.Location = new System.Drawing.Point(401, 181);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(75, 23);
         this.okButton.TabIndex = 4;
         this.okButton.Text = "OK";
         this.okButton.UseVisualStyleBackColor = true;
         this.okButton.Click += new System.EventHandler(this.okButton_Click);
         // 
         // AssemblyLoadForm
         // 
         this.AcceptButton = this.okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(488, 210);
         this.Controls.Add(this.okButton);
         this.Controls.Add(this.findButton);
         this.Controls.Add(this.assemblyPathTextBox);
         this.Controls.Add(this.assemblyNameLabel);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AssemblyLoadForm";
         this.ShowInTaskbar = false;
         this.Text = "Find Workflow Assembly";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label assemblyNameLabel;
      private System.Windows.Forms.TextBox assemblyPathTextBox;
      private System.Windows.Forms.Button findButton;
      private System.Windows.Forms.Button okButton;
   }
}