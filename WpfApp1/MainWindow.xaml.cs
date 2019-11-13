﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Persona> listaPersonas = new ObservableCollection<Persona>();
            listaPersonas = Persona.GetPersonas();

            ContenedorComboBox.DataContext = listaPersonas;

        }

        private void ContenedorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ContenedorComboBox.SelectedValue != null)
                IdentificadorTextBlock.Text = "El identificador del elemento seleccionado es: " + ContenedorComboBox.SelectedValue.ToString();
        }
    }
}