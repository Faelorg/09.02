﻿#pragma checksum "..\..\..\pages\1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "49726BB0308CAB9DDB6CCE23C4F683BC9AD5E56CB424E828210C321101B42C9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using practice2.pages;


namespace practice2.pages {
    
    
    /// <summary>
    /// _1
    /// </summary>
    public partial class _1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\pages\1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbInput;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pages\1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbInput2;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\pages\1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRes1;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\pages\1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbInput3;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\pages\1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRes2;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\pages\1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txblockRes;
        
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
            System.Uri resourceLocater = new System.Uri("/practice2;component/pages/1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages\1.xaml"
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
            this.txbInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbInput2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnRes1 = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\pages\1.xaml"
            this.btnRes1.Click += new System.Windows.RoutedEventHandler(this.btnRes1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbInput3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnRes2 = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\pages\1.xaml"
            this.btnRes2.Click += new System.Windows.RoutedEventHandler(this.btnRes2_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txblockRes = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 70 "..\..\..\pages\1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
