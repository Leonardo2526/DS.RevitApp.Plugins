﻿#pragma checksum "..\..\..\WPF\SelectParameters.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A2D2A31028919C2A85701286221ECAF93BABDE4F25E6F93AFBECA76B8DBC8377"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AddProjectParameters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AddProjectParameters {
    
    
    /// <summary>
    /// SelectParameters
    /// </summary>
    public partial class SelectParameters : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\WPF\SelectParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GroupsNames;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\WPF\SelectParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ParametersNames;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\WPF\SelectParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplySelection;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\WPF\SelectParameters.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyAllSelection;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DS.AddProjectParameters;component/wpf/selectparameters.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WPF\SelectParameters.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GroupsNames = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\WPF\SelectParameters.xaml"
            this.GroupsNames.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GroupsNames_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ParametersNames = ((System.Windows.Controls.ListBox)(target));
            
            #line 22 "..\..\..\WPF\SelectParameters.xaml"
            this.ParametersNames.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ParametersNames_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ApplySelection = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\WPF\SelectParameters.xaml"
            this.ApplySelection.Click += new System.Windows.RoutedEventHandler(this.ApplySelection_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ApplyAllSelection = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\WPF\SelectParameters.xaml"
            this.ApplyAllSelection.Click += new System.Windows.RoutedEventHandler(this.ApplyAllSelection_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

