﻿#pragma checksum "C:\Users\JoseMiguel\Documents\Visual Studio 2012\Projects\tomaNotas\tomaNotas\NuevaNota.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F08F8ACC89E5730E89EC45C5FCBDB299"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
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


namespace tomaNotas {
    
    
    public partial class NuevaNota : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox boxTitulo;
        
        internal System.Windows.Controls.TextBox boxContenido;
        
        internal System.Windows.Controls.Button buttonGuardar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/tomaNotas;component/NuevaNota.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.boxTitulo = ((System.Windows.Controls.TextBox)(this.FindName("boxTitulo")));
            this.boxContenido = ((System.Windows.Controls.TextBox)(this.FindName("boxContenido")));
            this.buttonGuardar = ((System.Windows.Controls.Button)(this.FindName("buttonGuardar")));
        }
    }
}
