﻿#pragma checksum "..\..\..\Windows\UserListWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1CB358CAD77B0029FDA99572A24391B663B92E33092ACB5F2C9DFD0C377FD246"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Library_Nikitin.Windows;
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


namespace Library_Nikitin.Windows {
    
    
    /// <summary>
    /// UserListWindow
    /// </summary>
    public partial class UserListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 96 "..\..\..\Windows\UserListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Windows\UserListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSort;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Windows\UserListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvReader;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\..\Windows\UserListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddReader;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\Windows\UserListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Library_Nikitin;component/windows/userlistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\UserListWindow.xaml"
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
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 99 "..\..\..\Windows\UserListWindow.xaml"
            this.txtSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 104 "..\..\..\Windows\UserListWindow.xaml"
            this.cmbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lvReader = ((System.Windows.Controls.ListView)(target));
            
            #line 110 "..\..\..\Windows\UserListWindow.xaml"
            this.lvReader.KeyUp += new System.Windows.Input.KeyEventHandler(this.lvReader_KeyUp);
            
            #line default
            #line hidden
            
            #line 111 "..\..\..\Windows\UserListWindow.xaml"
            this.lvReader.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lvReader_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAddReader = ((System.Windows.Controls.Button)(target));
            
            #line 221 "..\..\..\Windows\UserListWindow.xaml"
            this.btnAddReader.Click += new System.Windows.RoutedEventHandler(this.btnAddReader_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 236 "..\..\..\Windows\UserListWindow.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

