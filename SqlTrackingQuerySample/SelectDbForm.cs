using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SqlTrackingQuerySample
{
   public partial class SelectDbForm : Form
   {
      private string _connString;

      public string ConnectionString
      {
         get { return _connString; }
         set { _connString = value; }
      }

      public SelectDbForm()
      {
         _connString = "";
         InitializeComponent();

         LoadServerList();
      }

      private void LoadServerList()
      {
         DataTable instances = SqlDataSourceEnumerator.Instance.GetDataSources();
         List<string> servers = new List<string>();
         foreach ( DataRow row in instances.Rows )
         {
            string instanceName = row["InstanceName"] as string;
            if ( String.IsNullOrEmpty(instanceName) )
            {
               servers.Add((string)row["ServerName"]);
            } else
            {
               servers.Add((string)row["ServerName"] + "\\" + instanceName);
            }
         }

         instancesComboBox.DataSource = servers;
      }

      private void okButton_Click(object sender, EventArgs e)
      {
         DbConnectionStringBuilder builder = new DbConnectionStringBuilder();
         builder.Add("Data Source", instancesComboBox.Text);
         builder.Add("Initial Catalog", dbsComboBox.Text);
         builder.Add("Integrated Security", "SSPI");

         ConnectionString = builder.ConnectionString;
         DialogResult = DialogResult.OK;
         Close();
      }

      private void instancesComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         string server = (string)instancesComboBox.SelectedItem;

         DbConnectionStringBuilder builder = new DbConnectionStringBuilder();
         builder.Add("Data Source", server);
         builder.Add("Initial Catalog", "master");
         builder.Add("Integrated Security", "SSPI");

         using ( SqlConnection conn = new SqlConnection(builder.ConnectionString) )
         {
            SqlCommand cmd = new SqlCommand("select name from sys.databases", conn);
            conn.Open();

            using ( SqlDataReader reader = cmd.ExecuteReader() )
            {
               List<string> dbs = new List<string>();
               while ( reader.Read() )
               {
                  dbs.Add(reader.GetString(0));
               }
               dbsComboBox.DataSource = dbs;
            }
         }

      }
   }
}