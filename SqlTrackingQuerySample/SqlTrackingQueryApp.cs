
//
// SqlTrackingQueryApp.cs
//
// Author:
//    Tomas Restrepo (tomasr@mvps.org)
//

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace SqlTrackingQuerySample
{
   /// <summary>
   /// Sample application that shows the use of the
   /// SqlTrackingQuery class in Windows
   /// Workflow Foundation beta 2.
   /// </summary>
   class SqlTrackingQueryApp
   {
      [STAThread]
      static void Main(string[] args)
      {
         AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
         Application.EnableVisualStyles();
         Application.Run(new MainForm());
      }

      /// <summary>
      /// Handle the AssemblyResolve event of the AppDomain
      /// to load workflow assemblies as needed
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="args"></param>
      /// <returns></returns>
      static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
      {
         using ( AssemblyLoadForm dlg = new AssemblyLoadForm() )
         {
            dlg.AssemblyName = args.Name;

            DialogResult res = dlg.ShowDialog();
            if ( res == DialogResult.OK )
            {
               return Assembly.LoadFile(dlg.AssemblyFile);
            }
         }
         return null;
      }

   } // class SqlTrackingQueryApp

} // namespace SqlTrackingQuerySample
