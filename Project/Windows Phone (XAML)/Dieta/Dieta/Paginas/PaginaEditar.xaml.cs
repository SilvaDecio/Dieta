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
    public partial class PaginaEditar : PhoneApplicationPage
    {
        private const string ConnectionString = @"isostore:/MeuBanco.sdf";

        public PaginaEditar()
        {
            InitializeComponent();
        }

        private void BoxQualquer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox b = (TextBox)e.OriginalSource;

                switch (b.Name)
                {
                    case "BoxdaIdade":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Nova Idade";
                                break;
                        }
                        break;

                    case "BoxdaAltura":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Nova Altura (centimetros)";
                                break;
                        }
                        break;
                    case "BoxdoPeso":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Novo Peso (quilos)";
                                break;
                        }
                        break;
                }
            }
        }

        private void BoxQualquer_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdaIdade":
                    if (b.Text == "Nova Idade")
                        b.Text = "";
                    break;
                case "BoxdaAltura":
                    if (b.Text == "Nova Altura (centimetros)")
                        b.Text = "";
                    break;
                case "BoxdoPeso":
                    if (b.Text == "Novo Peso (quilos)")
                        b.Text = "";
                    break;
            }
        }

        private void BoxQualquer_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdaIdade":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Nova Idade";
                            break;
                    }
                    break;
                case "BoxdaAltura":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Nova Altura (centimetros)";
                            break;
                    }
                    break;
                case "BoxdoPeso":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Novo Peso (quilos)";
                            break;
                    }
                    break;
            }
        }

        private void BotaoConcluir_Click(object sender, RoutedEventArgs e)
        {
            if (BoxdaIdade.Text == "Nova Idade" && BoxdaAltura.Text == "Nova Altura (metros)" && BoxdoPeso.Text == "Novo Peso (quilos)")
            {
                MessageBox.Show("Dados Inválidos");
            }
            else
            {
                int age = 0;
                if(BoxdaIdade.Text != "Nova Idade")
                    age = int.Parse(BoxdaIdade.Text);

                if (age >= 14 && age <= 60)
                {
                    using (var context = new MeuBanco(ConnectionString))
                    {
                        Usuario b = context.Usuario.First();

                        if (BoxdaIdade.Text != "Nova Idade")
                        {
                            b.Idade = int.Parse(BoxdaIdade.Text);
                        }
                        if (BoxdaAltura.Text != "Nova Altura (centimetros)")
                        {
                            b.Altura = int.Parse(BoxdaAltura.Text);
                        }
                        if (BoxdoPeso.Text != "Novo Peso (quilos)")
                        {
                            b.Peso = int.Parse(BoxdoPeso.Text);
                        }

                        context.SubmitChanges();
                    }
                    NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    MessageBox.Show("A idade deve estar entre 14 e 60 anos"); 
                }
            }
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}