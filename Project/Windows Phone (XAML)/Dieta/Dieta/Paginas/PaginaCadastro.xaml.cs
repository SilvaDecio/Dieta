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
using Dieta.Paginas;

namespace Dieta.Paginas
{
    public partial class PaginaCadastro : PhoneApplicationPage
    {
        public PaginaCadastro()
        {
            InitializeComponent();
        }

        private const string ConnectionString = @"isostore:/MeuBanco.sdf";

        private void BotaoConcluir_Click(object sender, RoutedEventArgs e)
        {
            if (BoxdoNome.Text != "Nome")
            {
                if (!PickerSexo.SelectedItem.Equals("Sexo"))
                {
                    
                    if (BoxdaIdade.Text != "Idade")
                    {
                        int idade = Convert.ToInt32(BoxdaIdade.Text);
                        if (idade >= 14 && idade <= 60)
                        {
                            if (BoxdaAltura.Text != "Altura (centímetros)")
                            {
                                if (BoxdoPeso.Text != "Peso(quilos)")
                                {
                                    using (var context = new MeuBanco(ConnectionString))
                                    {
                                        Usuario a = new Usuario()
                                        {
                                            Nome = BoxdoNome.Text,
                                            Sexo = PickerSexo.SelectedItem.ToString(),
                                            Idade = int.Parse(BoxdaIdade.Text),
                                            Altura = int.Parse(BoxdaAltura.Text),
                                            Peso = int.Parse(BoxdoPeso.Text),
                                            UltimaData = DateTime.Today,
                                            CaloriaAtual = 0
                                        };
                                        context.Usuario.InsertOnSubmit(a);
                                        context.SubmitChanges();
                                    }

                                    NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
                                }
                                else
                                {
                                    MessageBox.Show("Peso Incorreto");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Altura Incorreta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Você deve ter entre 14 e 60 anos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Idade Incorreta");
                    }
                }
                else
                {
                    MessageBox.Show("Sexo Incorreto");
                }
            }
            else
            {
                MessageBox.Show("Nome Incorreto");
            }
        }

        private void BoxQualquer_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdoNome" :
                    if (b.Text == "Nome")
                        b.Text = "";
                    break;
                case "BoxdaIdade":
                    if (b.Text == "Idade")
                        b.Text = "";
                    break;
                case "BoxdaAltura":
                    if (b.Text == "Altura (centímetros)")
                        b.Text = "";
                    break;
                case "BoxdoPeso":
                    if (b.Text == "Peso (quilos)")
                        b.Text = "";
                    break;
            }
        }

        private void BoxQualquer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox b = (TextBox)e.OriginalSource;


                switch (b.Name)
                {
                    case "BoxdoNome":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Nome";
                                break;
                        }
                        break;
                    case "BoxdaIdade":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Idade";
                                break;
                        }
                        break;
                    case "BoxdaAltura":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Altura (centímetros)";
                                break;
                        }
                        break;
                    case "BoxdoPeso":
                        switch (b.Text)
                        {
                            case "":
                                b.Text = "Peso (quilos)";
                                break;
                        }
                        break;
                }
                BotaoConcluir.Focus();
            }
        }

        private void BoxQualquer_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox b = (TextBox)e.OriginalSource;

            switch (b.Name)
            {
                case "BoxdoNome":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Nome";
                            break;
                    }
                    break;
                case "BoxdaIdade":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Idade";
                            break;
                    }
                    break;
                case "BoxdaAltura":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Altura (centímetros)";
                            break;
                    }
                    break;
                case "BoxdoPeso":
                    switch (b.Text)
                    {
                        case "":
                            b.Text = "Peso (quilos)";
                            break;
                    }
                    break;
            }
        }

        private void PageQualquer_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new Microsoft.Xna.Framework.Game().Exit();
        }
    }
}