﻿#pragma checksum "..\..\EditApartament.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0E0783F6C224602CA2CF4F0E25C50E1AA88EB38647289F3664605D10BC80B8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
using Practice2.Pages;
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


namespace Practice2 {
    
    
    /// <summary>
    /// Editapartment
    /// </summary>
    public partial class Editapartment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\EditApartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.ComboBox ComboBoxApartmentsChoise;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\EditApartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.TextBox TextBoxOwner;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\EditApartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NumericUpDown NumericUpDownFloor;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\EditApartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NumericUpDown NumericUpDownArea;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\EditApartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NumericUpDown NumericUpDownBill;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\EditApartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSave;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\EditApartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.ComboBox ComboBoxApartmentsChoiseDelete;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\EditApartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/Practice2;component/editapartament.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditApartament.xaml"
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
            this.ComboBoxApartmentsChoise = ((HandyControl.Controls.ComboBox)(target));
            
            #line 35 "..\..\EditApartament.xaml"
            this.ComboBoxApartmentsChoise.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxOwner = ((HandyControl.Controls.TextBox)(target));
            
            #line 45 "..\..\EditApartament.xaml"
            this.TextBoxOwner.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxOwnerIsEmpty);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NumericUpDownFloor = ((HandyControl.Controls.NumericUpDown)(target));
            return;
            case 4:
            this.NumericUpDownArea = ((HandyControl.Controls.NumericUpDown)(target));
            return;
            case 5:
            this.NumericUpDownBill = ((HandyControl.Controls.NumericUpDown)(target));
            return;
            case 6:
            this.ButtonSave = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\EditApartament.xaml"
            this.ButtonSave.Click += new System.Windows.RoutedEventHandler(this.ButtonEditSave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ComboBoxApartmentsChoiseDelete = ((HandyControl.Controls.ComboBox)(target));
            
            #line 118 "..\..\EditApartament.xaml"
            this.ComboBoxApartmentsChoiseDelete.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxDeleteSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonDelete = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\EditApartament.xaml"
            this.ButtonDelete.Click += new System.Windows.RoutedEventHandler(this.ButtonDeleteClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

