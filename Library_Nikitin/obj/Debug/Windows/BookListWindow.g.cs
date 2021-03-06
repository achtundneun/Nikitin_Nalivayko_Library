#pragma checksum "..\..\..\Windows\BookListWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C400E61B039D415AADC958ADC4C1D1AD5A5F9BE26C02B2ED8E3BEC8EE6D4217A"
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
    /// BookListWindow
    /// </summary>
    public partial class BookListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Windows\BookListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBookName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\BookListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSort;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Windows\BookListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listBook;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\Windows\BookListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\Windows\BookListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddBook;
        
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
            System.Uri resourceLocater = new System.Uri("/Library_Nikitin;component/windows/booklistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\BookListWindow.xaml"
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
            this.SearchBookName = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\Windows\BookListWindow.xaml"
            this.SearchBookName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\..\Windows\BookListWindow.xaml"
            this.cmbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listBook = ((System.Windows.Controls.ListView)(target));
            
            #line 57 "..\..\..\Windows\BookListWindow.xaml"
            this.listBook.KeyUp += new System.Windows.Input.KeyEventHandler(this.listBook_KeyUp);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\Windows\BookListWindow.xaml"
            this.listBook.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listBook_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\Windows\BookListWindow.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.btnExit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAddBook = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\..\Windows\BookListWindow.xaml"
            this.btnAddBook.Click += new System.Windows.RoutedEventHandler(this.btnAddBook_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

