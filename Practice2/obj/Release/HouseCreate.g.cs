﻿#pragma checksum "..\..\HouseCreate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2C8B2434AAA30B4E1A6C35A0CB65DAC19A47AD2554DF9CF88D00A7FD6AC8023C"
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
using Practice2;
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
    /// HouseCreate
    /// </summary>
    public partial class HouseCreate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\HouseCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NumericUpDown ApartamentsMinArea;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\HouseCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NumericUpDown ApartamentsMaxArea;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\HouseCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NumericUpDown ApartamentsMinBill;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\HouseCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NumericUpDown ApartamentsMaxBill;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\HouseCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NumericUpDown ApartamentsCount;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\HouseCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HandyControl.Controls.NumericUpDown ApartamentsFloorCount;
        
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
            System.Uri resourceLocater = new System.Uri("/Practice2;component/housecreate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HouseCreate.xaml"
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
            this.ApartamentsMinArea = ((HandyControl.Controls.NumericUpDown)(target));
            return;
            case 2:
            this.ApartamentsMaxArea = ((HandyControl.Controls.NumericUpDown)(target));
            return;
            case 3:
            this.ApartamentsMinBill = ((HandyControl.Controls.NumericUpDown)(target));
            return;
            case 4:
            this.ApartamentsMaxBill = ((HandyControl.Controls.NumericUpDown)(target));
            return;
            case 5:
            this.ApartamentsCount = ((HandyControl.Controls.NumericUpDown)(target));
            return;
            case 6:
            this.ApartamentsFloorCount = ((HandyControl.Controls.NumericUpDown)(target));
            return;
            case 7:
            
            #line 113 "..\..\HouseCreate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCreateClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
