﻿#pragma checksum "E:\WP7\S2B\3ª Fase\Projeto\Dieta\Dieta\Paginas\PaginaCadastro.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "16C6135E74A8101C8000D47F08C7A30A"
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
    
    
    public partial class PaginaCadastro : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel stackPanel1;
        
        internal System.Windows.Controls.TextBox BoxdoNome;
        
        internal Microsoft.Phone.Controls.ListPicker PickerSexo;
        
        internal System.Windows.Controls.TextBox BoxdaIdade;
        
        internal System.Windows.Controls.TextBox BoxdaAltura;
        
        internal System.Windows.Controls.TextBox BoxdoPeso;
        
        internal System.Windows.Controls.Button BotaoConcluir;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Dieta;component/Paginas/PaginaCadastro.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.stackPanel1 = ((System.Windows.Controls.StackPanel)(this.FindName("stackPanel1")));
            this.BoxdoNome = ((System.Windows.Controls.TextBox)(this.FindName("BoxdoNome")));
            this.PickerSexo = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("PickerSexo")));
            this.BoxdaIdade = ((System.Windows.Controls.TextBox)(this.FindName("BoxdaIdade")));
            this.BoxdaAltura = ((System.Windows.Controls.TextBox)(this.FindName("BoxdaAltura")));
            this.BoxdoPeso = ((System.Windows.Controls.TextBox)(this.FindName("BoxdoPeso")));
            this.BotaoConcluir = ((System.Windows.Controls.Button)(this.FindName("BotaoConcluir")));
        }
    }
}

