﻿#pragma checksum "E:\WP7\S2B\Fase3\Projeto\Dieta\Dieta\Paginas\PaginaEditar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B539E004E20DA26DA4B3D74CC85B4B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Dieta.Paginas {
    
    
    public partial class PaginaEditar : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox BoxdoPeso;
        
        internal System.Windows.Controls.Button BotaoConcluir;
        
        internal System.Windows.Controls.TextBox BoxdaAltura;
        
        internal System.Windows.Controls.TextBox BoxdaIdade;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Dieta;component/Paginas/PaginaEditar.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.BoxdoPeso = ((System.Windows.Controls.TextBox)(this.FindName("BoxdoPeso")));
            this.BotaoConcluir = ((System.Windows.Controls.Button)(this.FindName("BotaoConcluir")));
            this.BoxdaAltura = ((System.Windows.Controls.TextBox)(this.FindName("BoxdaAltura")));
            this.BoxdaIdade = ((System.Windows.Controls.TextBox)(this.FindName("BoxdaIdade")));
        }
    }
}
