using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Workflow.ComponentModel;
using System.Workflow.Runtime;
using System.Workflow.Runtime.Hosting;
using System.Workflow.Runtime.Tracking;

namespace SqlTrackingQuerySample
{
   public partial class MainForm : Form
   {
      private string _connString;

      public MainForm()
      {
         _connString = "Data Source=(local); Initial Catalog=TrackingStore; Integrated Security=SSPI";
         InitializeComponent();
      }

      private void RefreshButton_Click(object sender, EventArgs e)
      {
         if ( !String.IsNullOrEmpty(_connString) )
         {
            RefreshData();
         }
      }

      #region Private Methods
      //
      // Private Methods
      //

      private void RefreshData()
      {
         SqlTrackingQuery query = new SqlTrackingQuery(_connString);
         SqlTrackingQueryOptions options = new SqlTrackingQueryOptions();
         trackingBindingSource.DataSource = query.GetWorkflows(options);
      }
      #endregion // Private Methods

      private void connectDbButton_Click(object sender, EventArgs e)
      {
         using ( SelectDbForm dlg = new SelectDbForm() )
         {
            DialogResult res = dlg.ShowDialog(this);
            if ( res == DialogResult.OK )
            {
               _connString = dlg.ConnectionString;
               RefreshData();
            }
         }
      }

      private void wfEventsGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
      {
         for ( int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++ )
         {
            DataGridViewRow row = wfEventsGrid.Rows[i];
            WorkflowTrackingRecord record = 
               (WorkflowTrackingRecord)row.DataBoundItem;

            string argsText = "";

            switch ( record.TrackingWorkflowEvent )
            {
            case TrackingWorkflowEvent.Suspended:
               argsText = ((TrackingWorkflowSuspendedEventArgs)record.EventArgs).Error;
               break;
            case TrackingWorkflowEvent.Exception:
               argsText = ((TrackingWorkflowExceptionEventArgs)record.EventArgs).Exception.Message;
               break;
            case TrackingWorkflowEvent.Changed:
               argsText = string.Format("Number of Changes: {0}", ((TrackingWorkflowChangedEventArgs)record.EventArgs).Changes.Count);
               break;
            case TrackingWorkflowEvent.Terminated:
               argsText = ((TrackingWorkflowTerminatedEventArgs)record.EventArgs).Exception.Message;
               break;
            default:
               // no need to do anything;
               break;
            }
            row.Cells[ArgsColumn.Name].Value = argsText;
         }
      }

   }
}