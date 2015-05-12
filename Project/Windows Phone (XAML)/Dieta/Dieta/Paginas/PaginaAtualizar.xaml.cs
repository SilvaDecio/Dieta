using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Dieta.Paginas
{
    public partial class PaginaAtualizar : PhoneApplicationPage
    {
        private const string ConnectionString = @"isostore:/MeuBanco.sdf";

        public PaginaAtualizar()
        {
            InitializeComponent();

            List<Exercicio> exercicios = null;
            using (var context = new MeuBanco(ConnectionString))
            {
                var ct = context.Exercicio.OrderBy(p => p.Nome).ToList();
                exercicios = ct as List<Exercicio>;
            }
            PickerExercicio.ItemsSource = exercicios;

            List<Comida> comidas = null;
            using (var context = new MeuBanco(ConnectionString))
            {
                var ct = context.Comida.OrderBy(p => p.Nome).ToList();
                comidas = ct as List<Comida>;
            }
            PickerComida.ItemsSource = comidas;

            List<Bebida> bebidas = null;
            using (var context = new MeuBanco(ConnectionString))
            {
                var ct = context.Bebida.OrderBy(p => p.Nome).ToList();
                bebidas = ct as List<Bebida>;
            }
            PickerBebida.ItemsSource = bebidas;
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml",UriKind.RelativeOrAbsolute));
        }

        private void BotaoAdicionar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Paginas/PaginaAdicionar.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BotaoConcluirExercicio_Click(object sender, RoutedEventArgs e)
        {
                if (BoxdoTempoExercicio.Text != "Tempo de Prática (minutos)")
                {
                    using (var context = new MeuBanco(ConnectionString))
                    {
                        Usuario b = context.Usuario.First();

                        Exercicio ex = PickerExercicio.SelectedItem as Exercicio;

                        float oldtime = (float)ex.TempoPadrao;
                        float oldcal = (float)ex.CaloriasTempo;

                        float newtime = float.Parse(BoxdoTempoExercicio.Text);
                        float newcal = (newtime * oldcal) / oldtime;

                        b.CaloriaAtual -= (int)newcal;
                        context.SubmitChanges();
                    }

                    NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    MessageBox.Show("Tempo Incorreto");
                }
        }

        private void BotaoConcluirComida_Click(object sender, RoutedEventArgs e)
        {
                if (BoxdaPorçãoComida.Text != "Qtd ou Porção Ingerida")
                {
                    using (var context = new MeuBanco(ConnectionString))
                    {
                        Usuario b = context.Usuario.First();

                        Comida ex = PickerComida.SelectedItem as Comida;

                        float oldporcion = (float)ex.PorcaoPadrao;
                        float oldcal = (float)ex.CaloriasPorcao;

                        float newporcion = float.Parse(BoxdaPorçãoComida.Text);
                        float newcal = (newporcion * oldcal) / oldporcion;

                        b.CaloriaAtual += (int)newcal;
                        context.SubmitChanges();
                    }
                    NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    MessageBox.Show("Porção Incorreta");
                }
        }

        private void BotaoConcluirBebida_Click(object sender, RoutedEventArgs e)
        {
            if (BoxdaPorçãoBebida.Text != "Porção Ingerida (mililitros)")
                {
                    using (var context = new MeuBanco(ConnectionString))
                    {
                        Usuario b = context.Usuario.First();

                        Bebida ex = PickerBebida.SelectedItem as Bebida;

                        float oldporcion = (float)ex.PorcaoPadrao;
                        float oldcal = (float)ex.CaloriaPorcao;

                        float newporcion = float.Parse(BoxdaPorçãoBebida.Text);
                        float newcal = (newporcion * oldcal) / oldporcion;

                        b.CaloriaAtual += (int)newcal;
                        context.SubmitChanges();
                    }
                    NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    MessageBox.Show("Porção Incorreta");
                }
        }

        private void BoxQualquerExercicio_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdoTempoExercicio":
                    if (b.Text == "Tempo de Prática (minutos)")
                        b.Text = "";
                    break;
            }
        }

        private void BoxQualquerComida_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdaPorçãoComida":
                    if (b.Text == "Porção Ingerida (gramas)")
                        b.Text = "";
                    break;
            }
        }

        private void BoxQualquerBebida_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdaPorçãoBebida":
                    if (b.Text == "Porção Ingerida (mililitros)")
                        b.Text = "";
                    break;
            }
        }

        private void BoxQualquerExercicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox b = (TextBox)e.OriginalSource;

                switch (b.Name)
                {
                    case "BoxdoTempoExercicio":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Tempo de Prática (minutos)";
                                break;
                        }
                        break;
                }
                BotaoConcluirExercicio.Focus();
            }
        }

        private void BoxQualquerComida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox b = (TextBox)e.OriginalSource;

                switch (b.Name)
                {
                    case "BoxdaPorçãoComida":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Porção Ingerida (gramas)";
                                break;
                        }
                        break;
                }
                BotaoConcluirComida.Focus();
            }
        }

        private void BoxQualquerBebida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox b = (TextBox)e.OriginalSource;

                switch (b.Name)
                {
                    case "BoxdaPorçãoBebida":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Porção Ingerida (mililitros)";
                                break;
                        }
                        break;
                }
                BotaoConcluirBebida.Focus();
            }
        }

        private void BoxQualquerExercicio_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdoTempoExercicio":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Tempo de Prática (minutos)";
                            break;
                    }
                    break;
            }
        }

        private void BoxQualquerComida_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdaPorçãoComida":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Porção Ingerida (gramas)";
                            break;
                    }
                    break;
            }
        }

        private void BoxQualquerBebida_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdaPorçãoBebida":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Porção Ingerida (mililitros)";
                            break;
                    }
                    break;
            }
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}