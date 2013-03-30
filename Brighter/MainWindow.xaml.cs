﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Brighter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        MenuBar menu;

        public MainWindow()
        {
            InitializeComponent();
            InitializeOtherComponents();
        }

        private void InitializeOtherComponents()
        {
            menu = new MenuBar();
            Grid.SetColumn(menu, 0);
            Grid.SetRow(menu, 0);
            Grid.SetColumnSpan(menu, 2);
            this.MainGrid.Children.Add(menu);
        }
    }
}
