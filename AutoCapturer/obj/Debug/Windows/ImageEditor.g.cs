﻿#pragma checksum "..\..\..\Windows\ImageEditor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9F5064DE5815D75C12983017B8F43AA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoCapturer.UserControls;
using AutoCapturer.Windows;
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


namespace AutoCapturer.Windows {
    
    
    /// <summary>
    /// ImageEditor
    /// </summary>
    public partial class ImageEditor : AutoCapturer.Windows.ChromeWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 102 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton EditBtn1;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton EditBtn2;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CropInfoTB;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCopyToClipBoard;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOriginSizeReturn;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AutoCapturer.UserControls.ImageEdit Editor;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RatioCB;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WidthTB;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HeightTB;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\Windows\ImageEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoCapturer;component/windows/imageeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ImageEditor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.EditBtn1 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.EditBtn2 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.CropInfoTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.BtnCopyToClipBoard = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\Windows\ImageEditor.xaml"
            this.BtnCopyToClipBoard.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnOriginSizeReturn = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\Windows\ImageEditor.xaml"
            this.BtnOriginSizeReturn.Click += new System.Windows.RoutedEventHandler(this.BtnOriginSizeReturn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Editor = ((AutoCapturer.UserControls.ImageEdit)(target));
            return;
            case 7:
            this.RatioCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.WidthTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.HeightTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 178 "..\..\..\Windows\ImageEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 183 "..\..\..\Windows\ImageEditor.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

