﻿#pragma checksum "..\..\..\..\Forms\FormRequest\Object.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3A2CE468B34D32666DEC32D0645054D10A4E7721"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AccessSystem;
using AccessSystem.Forms.FormRequest;
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


namespace AccessSystem.Forms.FormRequest {
    
    
    /// <summary>
    /// Object
    /// </summary>
    public partial class Object : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\Forms\FormRequest\Object.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AccessSystem.Forms.FormRequest.Object ObjectRequest;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Forms\FormRequest\Object.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemSaveClose;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Forms\FormRequest\Object.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemSave;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Forms\FormRequest\Object.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Forms\FormRequest\Object.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCode;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Forms\FormRequest\Object.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerDate;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Forms\FormRequest\Object.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxStatus;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Forms\FormRequest\Object.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxComment;
        
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
            System.Uri resourceLocater = new System.Uri("/AccessSystem;component/forms/formrequest/object.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forms\FormRequest\Object.xaml"
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
            this.ObjectRequest = ((AccessSystem.Forms.FormRequest.Object)(target));
            return;
            case 2:
            this.MenuItemSaveClose = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\..\Forms\FormRequest\Object.xaml"
            this.MenuItemSaveClose.Click += new System.Windows.RoutedEventHandler(this.MenuItemSaveClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MenuItemSave = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\..\Forms\FormRequest\Object.xaml"
            this.MenuItemSave.Click += new System.Windows.RoutedEventHandler(this.MenuItemSave_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.TextBoxCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\..\Forms\FormRequest\Object.xaml"
            this.TextBoxCode.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBoxCode_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\..\Forms\FormRequest\Object.xaml"
            this.TextBoxCode.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBoxCode_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\..\Forms\FormRequest\Object.xaml"
            this.TextBoxCode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxCode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DatePickerDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.ComboBoxStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.TextBoxComment = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

