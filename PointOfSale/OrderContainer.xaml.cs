﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderContainer.xaml
    /// </summary>
    public partial class OrderContainer : UserControl
    {

        BindingList<string> vs;

        public OrderContainer()
        {
            InitializeComponent();

            userOrder.ItemsSource = vs;


        }

        
    }
}
