﻿#pragma checksum "..\..\GestionFonctionsServices.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1DF12C656271BA6C17702B2767AA41E852CF00717ED08B74377ABFE8CD1C5BF5"
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
    /// GestionFonctionsServices
    /// </summary>
    public partial class GestionFonctionsServices : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblNomSorF;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRetour;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbServices;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbFonctions;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSupprimer;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnModifier;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MenuNouveau;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuINouveau;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AjouterService;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AjouterFonction;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\GestionFonctionsServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtBNomSorF;
        
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
            System.Uri resourceLocater = new System.Uri("/AppliWPF-BDD-Personels;component/gestionfonctionsservices.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GestionFonctionsServices.xaml"
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
            this.LblNomSorF = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.BtnRetour = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\GestionFonctionsServices.xaml"
            this.BtnRetour.Click += new System.Windows.RoutedEventHandler(this.Retour);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LbServices = ((System.Windows.Controls.ListBox)(target));
            
            #line 12 "..\..\GestionFonctionsServices.xaml"
            this.LbServices.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LbServices_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LbFonctions = ((System.Windows.Controls.ListBox)(target));
            
            #line 21 "..\..\GestionFonctionsServices.xaml"
            this.LbFonctions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LbFonctions_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnSupprimer = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.BtnModifier = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\GestionFonctionsServices.xaml"
            this.BtnModifier.Click += new System.Windows.RoutedEventHandler(this.BtnModifier_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MenuNouveau = ((System.Windows.Controls.Menu)(target));
            return;
            case 8:
            this.MenuINouveau = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 9:
            this.AjouterService = ((System.Windows.Controls.MenuItem)(target));
            
            #line 35 "..\..\GestionFonctionsServices.xaml"
            this.AjouterService.Click += new System.Windows.RoutedEventHandler(this.ouvrirAjservices);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AjouterFonction = ((System.Windows.Controls.MenuItem)(target));
            
            #line 36 "..\..\GestionFonctionsServices.xaml"
            this.AjouterFonction.Click += new System.Windows.RoutedEventHandler(this.ouvrirAjfonctions);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TxtBNomSorF = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

