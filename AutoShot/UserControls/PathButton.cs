﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AutoShot.UserControls
{
    class PathButton : Button
    {
        public PathButton()
        {
            this.Style = FindResource("PathButtonStyle") as Style;
        }
        public static DependencyProperty DataProperty =
            DependencyProperty.Register(nameof(Data), typeof(Geometry), typeof(PathButton));
        
        public Geometry Data
        {
            get { return (Geometry)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }
    }
}
