﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiniPaint
{
    /// <summary>
    /// Interaction logic for Quadrado_Area.xaml
    /// </summary>
    public partial class Quadrado_Area : UserControl
    {
        public Quadrado_Area()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
              
                    quadrado.Width = double.Parse(lado.Text);
                    quadrado.Length = double.Parse(lado.Text);
                    res.Content = double.Parse(lado.Text) * double.Parse(lado.Text);
                }
            
            catch (Exception ex)
            {
                Mensagem_Numero_Vazio M = new Mensagem_Numero_Vazio();
                M.Show();
            }
        }
    }
}
