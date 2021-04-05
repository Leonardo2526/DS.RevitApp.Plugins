﻿using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;

namespace DS.RevitApp.RibbonTab
{
    public class MyApplication : IExternalApplication
    {
        // class instance
        internal static MyApplication thisApp = null;
         

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            // Create a custom ribbon tab
            string tabName = "ГЦМ_ДС";
            application.CreateRibbonTab(tabName);

            var button1Path = Environment.ExpandEnvironmentVariables(@"%AppData%\Autodesk\Revit\Addins\2020\DS.RVTtoNWC\DS.RVTtoNWC.dll");
            var button2Path = Environment.ExpandEnvironmentVariables(@"%AppData%\Autodesk\Revit\Addins\2020\DS.FamiliesUpdate\DS.FamiliesUpdate.dll");
            var button3Path = Environment.ExpandEnvironmentVariables(@"%AppData%\Autodesk\Revit\Addins\2020\DS.AddProjectParameters\DS.AddProjectParameters.dll");


            // Create two push buttons
            //PushButtonData button1 = new PushButtonData("Button1", "Hello World", button1Path, "DS_RevitSpace.HelloWorld");
            PushButtonData button1 = new PushButtonData("Button1", "RVTtoNWC", button1Path, "DS.RevitApp.RVTtoNWC.DS_MainClass");
            PushButtonData button2 = new PushButtonData("Button2", "FamiliesUpdate", button2Path, "DS.RevitApp.FamiliesUpdate.EntryCommand");
            PushButtonData button3 = new PushButtonData("Button3", "AddProjectParameters", button3Path, "AddProjectParameters.EntryCommand");

            button1.ToolTip = "Export files from *.rvt to *.nwc. \nVer.2";

            // Create a ribbon panel
            RibbonPanel m_projectPanel_1 = application.CreateRibbonPanel(tabName, "Tools");
            //RibbonPanel m_projectPanel_2 = application.CreateRibbonPanel(tabName, "DS_Panel_2");

            // Add the buttons to the panel
            List<RibbonItem> projectButtons = new List<RibbonItem>();
            projectButtons.AddRange(m_projectPanel_1.AddStackedItems(button1, button2, button3));
            //projectButtons.AddRange(m_projectPanel_2.AddStackedItems(button1, button2));


            return Result.Succeeded;
        }


    }


}
