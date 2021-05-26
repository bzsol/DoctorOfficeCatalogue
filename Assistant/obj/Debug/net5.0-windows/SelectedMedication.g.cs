﻿#pragma checksum "..\..\..\SelectedMedication.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "498FF523A17BDB6A506F79854CACCC7AE7628AA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Assistant;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Assistant {
    
    
    /// <summary>
    /// SelectedMedication
    /// </summary>
    public partial class SelectedMedication : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MedicationNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MedNameBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ActIngredientBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MinAgeBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaxAgeBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DosageBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PackagingBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DiagnosisTextBox;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeletePatient;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SavePatientData;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\SelectedMedication.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClosePatientDataWindow;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Assistant;component/selectedmedication.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SelectedMedication.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MedicationNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.MedNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ActIngredientBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.MinAgeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.MaxAgeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DosageBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PackagingBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.DiagnosisTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ErrorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.DeletePatient = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\SelectedMedication.xaml"
            this.DeletePatient.Click += new System.Windows.RoutedEventHandler(this.DeleteMedication_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SavePatientData = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\SelectedMedication.xaml"
            this.SavePatientData.Click += new System.Windows.RoutedEventHandler(this.SaveMedicationData_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ClosePatientDataWindow = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\SelectedMedication.xaml"
            this.ClosePatientDataWindow.Click += new System.Windows.RoutedEventHandler(this.CloseMedicationDataWindow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

