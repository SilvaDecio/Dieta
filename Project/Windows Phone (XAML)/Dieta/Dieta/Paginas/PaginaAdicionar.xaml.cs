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
    public partial class PaginaAdicionar : PhoneApplicationPage
    {
        private const string ConnectionString = @"isostore:/MeuBanco.sdf";

        public PaginaAdicionar()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Paginas/PaginaAtualizar.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BotaoConcluirExercicio_Click(object sender, RoutedEventArgs e)
        {
            if (BoxdoNomeExercicio.Text != "Nome")
            {
                if (BoxdoTempoExercicio.Text != "Tempo Padrão (minutos)")
                {
                    if (BoxdaCaloriaExercicio.Text != "Calorias por Tempo Padrão")
                    {
                        using (var context = new MeuBanco(ConnectionString))
                        {
                            Exercicio p = new Exercicio()
                            {
                                Nome = BoxdoNomeExercicio.Text,
                                TempoPadrao = int.Parse(BoxdoTempoExercicio.Text),
                                CaloriasTempo = int.Parse(BoxdaCaloriaExercicio.Text)
                            };
                            context.Exercicio.InsertOnSubmit(p);
                            context.SubmitChanges();
                        }
                        NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
                    }
                    else
                    {
                        MessageBox.Show("Caloria Incorreta");
                    }
                }
                else
                {
                    MessageBox.Show("Tempo Incorreto");
                }
            }
            else
            {
                MessageBox.Show("Nome Incorreto");
            }
        }

        private void BotaoConcluirComida_Click(object sender, RoutedEventArgs e)
        {
            if (BoxdoNomeComida.Text != "Nome")
            {
                if (BoxdaPorçãoComida.Text != "Porção Padrão (gramas)")
                {
                    if (BoxdaCaloriaComida.Text != "Calorias por Porção Padrão")
                    {
                        using (var context = new MeuBanco(ConnectionString))
                        {
                            Comida p = new Comida()
                            {
                                Nome = BoxdoNomeComida.Text,
                                PorcaoPadrao = int.Parse(BoxdaPorçãoComida.Text),
                                CaloriasPorcao = int.Parse(BoxdaCaloriaComida.Text)
                            };
                            context.Comida.InsertOnSubmit(p);
                            context.SubmitChanges();
                        }
                        NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
                    }
                    else
                    {
                        MessageBox.Show("Caloria Incorreta");
                    }
                }
                else
                {
                    MessageBox.Show("Porção Incorreta");
                }
            }
            else
            {
                MessageBox.Show("Nome Incorreto");
            }
        }

        private void BotaoConcluirBebida_Click(object sender, RoutedEventArgs e)
        {
            if (BoxdoNomeBebida.Text != "Nome")
            {
                if (BoxdaPorçãoBebida.Text != "Porção Padrão (mililitros)")
                {
                    if (BoxdaCaloriaBebida.Text != "Calorias por Porção Padrão")
                    {
                        using (var context = new MeuBanco(ConnectionString))
                        {
                            Bebida p = new Bebida()
                            {
                                Nome = BoxdoNomeBebida.Text,
                                PorcaoPadrao = int.Parse(BoxdaPorçãoBebida.Text),
                                CaloriaPorcao = int.Parse(BoxdaCaloriaBebida.Text)
                            };
                            context.Bebida.InsertOnSubmit(p);
                            context.SubmitChanges();
                        }
                        NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
                    }
                    else
                    {
                        MessageBox.Show("Dados Incorretos");
                    }
                }
                else
                {
                    MessageBox.Show("Dados Incorretos");
                }
            }
            else
            {
                MessageBox.Show("Dados Incorretos");
            }
        }

        private void BoxQualquerExercicio_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdoNomeExercicio":
                    if (b.Text == "Nome")
                        b.Text = "";
                    break;
                case "BoxdoTempoExercicio":
                    if (b.Text == "Tempo Padrão (minutos)")
                        b.Text = "";
                    break;
                case "BoxdaCaloriaExercicio":
                    if (b.Text == "Calorias por Tempo Padrão")
                        b.Text = "";
                    break;
            }
        }

        private void BoxQualquerComida_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdoNomeComida":
                    if (b.Text == "Nome")
                        b.Text = "";
                    break;
                case "BoxdaPorçãoComida":
                    if (b.Text == "Porção Padrão (gramas)")
                        b.Text = "";
                    break;
                case "BoxdaCaloriaComida":
                    if (b.Text == "Calorias por Porção Padrão")
                        b.Text = "";
                    break;
            }
        }

        private void BoxQualquerBebida_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdoNomeBebida":
                    if (b.Text == "Nome")
                        b.Text = "";
                    break;
                case "BoxdaPorçãoBebida":
                    if (b.Text == "Porção Padrão (mililitros)")
                        b.Text = "";
                    break;
                case "BoxdaCaloriaBebida":
                    if (b.Text == "Calorias por Porção Padrão")
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
                    case "BoxdoNomeExercicio":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Nome";
                                break;
                        }
                        break;
                    case "BoxdoTempoExercicio":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Tempo Padrão (minutos)";
                                break;
                        }
                        break;
                    case "BoxdaCaloriaExercicio":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Calorias por Tempo Padrão";
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
                    case "BoxdoNomeComida":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Nome";
                                break;
                        }
                        break;
                    case "BoxdaPorçãoComida":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Porção Padrão (gramas)";
                                break;
                        }
                        break;
                    case "BoxdaCaloriaComida":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Calorias por Porção Padrão";
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
                    case "BoxdoNomeBebida":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Nome";
                                break;
                        }
                        break;
                    case "BoxdaPorçãoBebida":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Porção Padrão (mililitros)";
                                break;
                        }
                        break;
                    case "BoxdaCaloriaBebida":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Calorias por Porção Padrão";
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
                case "BoxdoNomeExercicio":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Nome";
                            break;
                    }
                    break;
                case "BoxdoTempoExercicio":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Tempo Padrão (minutos)";
                            break;
                    }
                    break;
                case "BoxdaCaloriaExercicio":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Calorias por Tempo Padrão";
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
                case "BoxdoNomeComida":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Nome";
                            break;
                    }
                    break;
                case "BoxdaPorçãoComida":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Porção Padrão (gramas)";
                            break;
                    }
                    break;
                case "BoxdaCaloriaComida":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Calorias por Porção Padrão";
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
                case "BoxdoNomeBebida":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Nome";
                            break;
                    }
                    break;
                case "BoxdaPorçãoBebida":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Porção Padrão (mililitros)";
                            break;
                    }
                    break;
                case "BoxdaCaloriaBebida":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Calorias por Porção Padrão";
                            break;
                    }
                    break;
            }
        }
    }
}
