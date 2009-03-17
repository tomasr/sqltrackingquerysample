using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SqlTrackingQuerySample
{
   public partial class AssemblyLoadForm : Form
   {
      public string AssemblyName
      {
         get { return assemblyNameLabel.Text; }
         set { assemblyNameLabel.Text = value; }
      }

      public string AssemblyFile
      {
         get { return assemblyPathTextBox.Text; }
         set { assemblyPathTextBox.Text = value; }
      }

      public AssemblyLoadForm()
      {
         InitializeComponent();
      }

      private void findButton_Click(object sender, EventArgs e)
      {
         using ( OpenFileDialog dlg = new OpenFileDialog() )
         {
            dlg.CheckFileExists = true;
            dlg.FilterIndex = 0;
            dlg.Filter = "Assemblies (*.dll;*.exe)|*.dll;*.exe";

            DialogResult res = dlg.ShowDialog(this);
            if ( res == DialogResult.OK )
            {
               AssemblyFile = dlg.FileName;
            }
         }
      }

      private void okButton_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.OK;
         Close();
      }

      private void assemblyPathTextBox_TextChanged(object sender, EventArgs e)
      {
         okButton.Enabled = !String.IsNullOrEmpty(AssemblyFile);
      }
   }
}