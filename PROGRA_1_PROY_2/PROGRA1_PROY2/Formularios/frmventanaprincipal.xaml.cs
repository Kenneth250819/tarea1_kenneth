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
using System.Windows.Shapes;

namespace PROGRA1_PROY2.Formularios
{
    /// <summary>
    /// Lógica de interacción para frmventanaprincipal.xaml
    /// </summary>
    public partial class frmventanaprincipal : Window
    {
        public frmventanaprincipal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmventanaprincipal ventanaprincipal = new frmventanaprincipal();
            ventanaprincipal.Close();

            frmventana1 ventana1 = new frmventana1();
            ventana1.Show();
            





        }
    }
}
