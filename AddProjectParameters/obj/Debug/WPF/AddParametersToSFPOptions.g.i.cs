#pragma checksum "..\..\..\WPF\AddParametersToSFPOptions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A013946C1B0A8EEE2EC81C482CC235BBEF55380ADF47565F6222C016950AB729"
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
    /// AddParametersToSFPOptions
    /// </summary>
    public partial class AddParametersToSFPOptions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\WPF\AddParametersToSFPOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GroupsNames;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\WPF\AddParametersToSFPOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddGroup;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\WPF\AddParametersToSFPOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypesNames;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\WPF\AddParametersToSFPOptions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OK;
        
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
            System.Uri resourceLocater = new System.Uri("/DS.AddProjectParameters;component/wpf/addparameterstosfpoptions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WPF\AddParametersToSFPOptions.xaml"
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
            
            #line 15 "..\..\..\WPF\AddParametersToSFPOptions.xaml"
            this.GroupsNames.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypesNames_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddGroup = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\WPF\AddParametersToSFPOptions.xaml"
            this.AddGroup.Click += new System.Windows.RoutedEventHandler(this.Button_AddGroup_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TypesNames = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\WPF\AddParametersToSFPOptions.xaml"
            this.TypesNames.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypesNames_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OK = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\WPF\AddParametersToSFPOptions.xaml"
            this.OK.Click += new System.Windows.RoutedEventHandler(this.Button_OK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

