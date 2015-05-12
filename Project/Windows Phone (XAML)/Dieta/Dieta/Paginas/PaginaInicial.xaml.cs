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
using System.Text;
using System.Windows.Media.Imaging;

namespace Dieta
{
    public partial class PaginaInicial : PhoneApplicationPage
    {
        private const string ConnectionString = @"isostore:/MeuBanco.sdf";

        public IList<Usuario> GetUsuario()
        {
            IList<Usuario> lista = null;
            using (var context = new MeuBanco(ConnectionString))
            {
                IQueryable<Usuario> query = context.Usuario;
                lista = query.ToList();
            }
            return lista;
        }

        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void BotaoAtualizar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Paginas/PaginaAtualizar.xaml",UriKind.RelativeOrAbsolute));
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StringBuilder Aviso = new StringBuilder();
            Aviso.Append("É Importante lembrar que :");
            Aviso.AppendLine();
            Aviso.Append("Para você obter os resultados corretos, ");
            Aviso.AppendLine();
            Aviso.Append("além da utilização deste software");
            Aviso.AppendLine();
            Aviso.Append("você deve fazer 5 refeições diárias");
            Aviso.AppendLine();
            Aviso.Append("e procurar ter uma vida saudável.");
            
            MessageBox.Show(Aviso.ToString());
            new Microsoft.Xna.Framework.Game().Exit();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            IList<Usuario> Lista = GetUsuario();

            foreach(Usuario b in Lista)
            {
                BlockNome.Text = b.Nome;
                BlockIdade.Text = b.Idade.ToString() + " Anos";
                BlockPeso.Text = b.Peso.ToString() + " Quilos";
                BlockData.Text = DateTime.Today.ToLongDateString();

                switch (b.Sexo)
                {
                    case "Masculino":

                        b.CaloriaIdeal = (int)(66 + (13.7 * b.Peso) + (5 * b.Altura) - (6.8 * b.Idade));

                        break;

                    case "Feminino":

                        b.CaloriaIdeal = (int)(655 + (9.6 * b.Peso) + (1.8 * b.Altura) - (4.7 * b.Idade));

                        break;
                }

                float alturametros = (float)b.Altura / 100;
                float alturaquadrado = (float)Math.Pow(alturametros, 2);

                b.IMC = b.Peso / alturaquadrado;

                BlockAltura.Text = alturametros.ToString() + " Metros";

                if (b.IMC <= 18.5f)
                {
                    BlockEstadoUsuario.Text = "ABAIXO do Peso";
                    Uri uri = new Uri("/Dieta;component/Images/Triste.png", UriKind.Relative);
                    ImageSource imgSource = new BitmapImage(uri);
                    ImagemEstado.Source = imgSource;
                    b.CaloriaIdeal += 500;
                }
                if (b.IMC > 18.5f && b.IMC < 24.9f)
                {
                    BlockEstadoUsuario.Text = "Saudável";
                    Uri uri = new Uri("/Dieta;component/Images/Alegre.png", UriKind.Relative);
                    ImageSource imgSource = new BitmapImage(uri);
                    ImagemEstado.Source = imgSource;
                }
                if (b.IMC >= 24.9)
                {
                    BlockEstadoUsuario.Text = "ACIMA do Peso";
                    Uri uri = new Uri("/Dieta;component/Images/Triste.png", UriKind.Relative);
                    ImageSource imgSource = new BitmapImage(uri);
                    ImagemEstado.Source = imgSource;
                    b.CaloriaIdeal -= 500;
                }

                BlockValueCaloriasMax.Text = b.CaloriaIdeal.ToString();
                BlockValueCaloriasHoje.Text = b.CaloriaAtual.ToString();
            }
        }

        private void BotaoEditar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Paginas/PaginaEditar.xaml",UriKind.RelativeOrAbsolute));
        }
    }
}