﻿#pragma checksum "..\..\WinConnexion.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D9208DA020FC660121D724FAD5C497D5D8818D57B31839C8DC1AEFF29177CB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using AppliWPF_BDD_Personels;
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


namespace AppliWPF_BDD_Personels {
    
    
    /// <summary>
    /// WinConnexion
    /// </summary>
    public partial class WinConnexion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\WinConnexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblLogin;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\WinConnexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblMdp;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\WinConnexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSeConnecter;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\WinConnexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAnnuler;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WinConnexion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PwdBox;
        
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
            System.Uri resourceLocater = new System.Uri("/AppliWPF-BDD-Personels;component/winconnexion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WinConnexion.xaml"
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
            this.LblLogin = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LblMdp = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.BtnSeConnecter = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\WinConnexion.xaml"
            this.BtnSeConnecter.Click += new System.Windows.RoutedEventHandler(this.SeConnecter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnAnnuler = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\WinConnexion.xaml"
            this.BtnAnnuler.Click += new System.Windows.RoutedEventHandler(this.Annuler);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PwdBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

