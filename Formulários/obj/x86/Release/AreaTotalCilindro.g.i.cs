﻿#pragma checksum "..\..\..\AreaTotalCilindro.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "488E50F4E1A95F5EF63A70C0390DD223"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HelixToolkit.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MiniPaint {
    
    
    /// <summary>
    /// AreaTotalCilindro
    /// </summary>
    public partial class AreaTotalCilindro : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HelixToolkit.Wpf.HelixViewport3D camera;
        
        #line default
        #line hidden
        
        /// <summary>
        /// cilindroobjeto Name Field
        /// </summary>
        
        #line 26 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public HelixToolkit.Wpf.TruncatedConeVisual3D cilindroobjeto;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Raio;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Altura;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label doisvezesraiovezespi;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Raio1;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PI_Copy;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label res;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label raiomaisaltura;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\AreaTotalCilindro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RaioCopia;
        
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
            System.Uri resourceLocater = new System.Uri("/SharpGLWinformsApplication3;component/areatotalcilindro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AreaTotalCilindro.xaml"
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
            this.camera = ((HelixToolkit.Wpf.HelixViewport3D)(target));
            return;
            case 2:
            this.cilindroobjeto = ((HelixToolkit.Wpf.TruncatedConeVisual3D)(target));
            return;
            case 3:
            this.Raio = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            
            #line 42 "..\..\..\AreaTotalCilindro.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Altura = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.doisvezesraiovezespi = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Raio1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.PI_Copy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.res = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.raiomaisaltura = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.RaioCopia = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

