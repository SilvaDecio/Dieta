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
using System.Threading;
using Dieta;

namespace Dieta.Paginas
{
    public partial class PaginaLoading : PhoneApplicationPage
    {
        private const string ConnectionString = @"isostore:/MeuBanco.sdf";

        public PaginaLoading()
        {
            InitializeComponent();

            using (var context = new MeuBanco(ConnectionString))
            {
                if (!context.DatabaseExists())
                {
                    context.CreateDatabase();

                    Comida Manga = new Comida() { Nome = "Manga", PorcaoPadrao = 1, CaloriasPorcao = 82 };
                    context.Comida.InsertOnSubmit(Manga);
                    Comida Maca = new Comida() { Nome = "Maçã", PorcaoPadrao = 1, CaloriasPorcao = 81 };
                    context.Comida.InsertOnSubmit(Maca);
                    Comida MacaVerde = new Comida() { Nome = "Maçã Verde", PorcaoPadrao = 1, CaloriasPorcao = 54 };
                    context.Comida.InsertOnSubmit(MacaVerde);
                    Comida HotDog = new Comida() { Nome = "Cachorro Quente", PorcaoPadrao = 1, CaloriasPorcao = 330 };
                    context.Comida.InsertOnSubmit(HotDog);
                    Comida Hamburguer = new Comida() { Nome = "Hamburguer", PorcaoPadrao = 1, CaloriasPorcao = 290 };
                    context.Comida.InsertOnSubmit(Hamburguer);
                    Comida PaoFrances = new Comida() { Nome = "Pão Francês", PorcaoPadrao = 1, CaloriasPorcao = 134 };
                    context.Comida.InsertOnSubmit(PaoFrances);
                    Comida PaoQueijo = new Comida() { Nome = "Pão de Queijo", PorcaoPadrao = 1, CaloriasPorcao = 173 };
                    context.Comida.InsertOnSubmit(PaoQueijo);
                    Comida Yakissoba = new Comida() { Nome = "Yakissoba", PorcaoPadrao = 75, CaloriasPorcao = 112 };
                    context.Comida.InsertOnSubmit(Yakissoba);
                    Comida Acaraje = new Comida() { Nome = "Acarajé", PorcaoPadrao = 1, CaloriasPorcao = 169 };
                    context.Comida.InsertOnSubmit(Acaraje);
                    Comida Coxinha = new Comida() { Nome = "Coxinha de Frango", PorcaoPadrao = 1, CaloriasPorcao = 400 };
                    context.Comida.InsertOnSubmit(Coxinha);
                    Comida Empadinha = new Comida() { Nome = "Empadinha", PorcaoPadrao = 1, CaloriasPorcao = 108 };
                    context.Comida.InsertOnSubmit(Empadinha);
                    Comida Quibe = new Comida() { Nome = "Quibe", PorcaoPadrao = 1, CaloriasPorcao = 318 };
                    context.Comida.InsertOnSubmit(Quibe);
                    Comida EsfihaQueijo = new Comida() { Nome = "Esfiha de Queijo", PorcaoPadrao = 1, CaloriasPorcao = 238 };
                    context.Comida.InsertOnSubmit(EsfihaQueijo);
                    Comida EsfihaCarne = new Comida() { Nome = "Esfiha de Carne", PorcaoPadrao = 1, CaloriasPorcao = 206 };
                    context.Comida.InsertOnSubmit(EsfihaCarne);
                    Comida PastelCarne = new Comida() { Nome = "Pastel de Carne", PorcaoPadrao = 1, CaloriasPorcao = 324 };
                    context.Comida.InsertOnSubmit(PastelCarne);
                    Comida PastelQueijo = new Comida() { Nome = "Pastel de Queijo", PorcaoPadrao = 1, CaloriasPorcao = 361 };
                    context.Comida.InsertOnSubmit(PastelQueijo);
                    Comida PanquecaCarne = new Comida() { Nome = "Panqueca de Carne", PorcaoPadrao = 1, CaloriasPorcao = 95 };
                    context.Comida.InsertOnSubmit(PanquecaCarne);
                    Comida PizzaMussarela = new Comida() { Nome = "Pizza de Mussarela", PorcaoPadrao = 1, CaloriasPorcao = 278 };
                    context.Comida.InsertOnSubmit(PizzaMussarela);
                    Comida PizzaCalabresa = new Comida() { Nome = "Pizza de Calabresa", PorcaoPadrao = 1, CaloriasPorcao = 239 };
                    context.Comida.InsertOnSubmit(PizzaCalabresa);
                    Comida PizzaPortuguesa = new Comida() { Nome = "Pizza Portuguesa", PorcaoPadrao = 1, CaloriasPorcao = 302 };
                    context.Comida.InsertOnSubmit(PizzaPortuguesa);
                    Comida TortaFrango = new Comida() { Nome = "Torta de Frango", PorcaoPadrao = 1, CaloriasPorcao = 282 };
                    context.Comida.InsertOnSubmit(TortaFrango);
                    Comida Pipoca = new Comida() { Nome = "Pipoca", PorcaoPadrao = 1, CaloriasPorcao = 240 };
                    context.Comida.InsertOnSubmit(Pipoca);
                    Comida BarreCereal = new Comida() { Nome = "Barra de Cereais", PorcaoPadrao = 25, CaloriasPorcao = 90 };
                    context.Comida.InsertOnSubmit(BarreCereal);
                    Comida BoloComum = new Comida() { Nome = "Bolo Comum", PorcaoPadrao = 60, CaloriasPorcao = 215 };
                    context.Comida.InsertOnSubmit(BoloComum);
                    Comida Beijinho = new Comida() { Nome = "Beijinho", PorcaoPadrao = 1, CaloriasPorcao = 105 };
                    context.Comida.InsertOnSubmit(Beijinho);
                    Comida Brigadeiro = new Comida() { Nome = "Brigadeiro", PorcaoPadrao = 1, CaloriasPorcao = 121 };
                    context.Comida.InsertOnSubmit(Brigadeiro);
                    Comida TrufaChocolate = new Comida() { Nome = "Trufa de Chocolate", PorcaoPadrao = 1, CaloriasPorcao = 121 };
                    context.Comida.InsertOnSubmit(TrufaChocolate);
                    Comida Sundae = new Comida() { Nome = "Sundae", PorcaoPadrao = 1, CaloriasPorcao = 265 };
                    context.Comida.InsertOnSubmit(Sundae);
                    Comida Suspiro = new Comida() { Nome = "Suspiro", PorcaoPadrao = 1, CaloriasPorcao = 38 };
                    context.Comida.InsertOnSubmit(Suspiro);


                    Bebida RefrigeranteDiet = new Bebida() { Nome = "Refrigerante Diet", PorcaoPadrao = 200, CaloriaPorcao = 3 };
                    context.Bebida.InsertOnSubmit(RefrigeranteDiet);
                    Bebida Cerveja = new Bebida() { Nome = "Cerveja", PorcaoPadrao = 350, CaloriaPorcao = 147 };
                    context.Bebida.InsertOnSubmit(Cerveja);
                    Bebida AguaCoco = new Bebida() { Nome = "Água de Coco", PorcaoPadrao = 200, CaloriaPorcao = 40 };
                    context.Bebida.InsertOnSubmit(AguaCoco);
                    Bebida Refrigerante = new Bebida() { Nome = "Refrigerante", PorcaoPadrao = 200, CaloriaPorcao = 115 };
                    context.Bebida.InsertOnSubmit(Refrigerante);
                    Bebida VitaminaFrutas = new Bebida() { Nome = "Vitamina de Frutas", PorcaoPadrao = 250, CaloriaPorcao = 95 };
                    context.Bebida.InsertOnSubmit(VitaminaFrutas);
                    Bebida Caipirinha = new Bebida() { Nome = "Caipirinha", PorcaoPadrao = 100, CaloriaPorcao = 260 };
                    context.Bebida.InsertOnSubmit(Caipirinha);
                    Bebida Iogurte = new Bebida() { Nome = "Iogurte", PorcaoPadrao = 200, CaloriaPorcao = 154 };
                    context.Bebida.InsertOnSubmit(Iogurte);
                    Bebida Leite = new Bebida() { Nome = "Leite", PorcaoPadrao = 200, CaloriaPorcao = 126 };
                    context.Bebida.InsertOnSubmit(Leite);
                    Bebida MilkShakeMorango = new Bebida() { Nome = "Milk Shake de Morango", PorcaoPadrao = 250, CaloriaPorcao = 379 };
                    context.Bebida.InsertOnSubmit(MilkShakeMorango);
                    Bebida MilkShakeChocolate = new Bebida() { Nome = "Milk Shake de Chocolate", PorcaoPadrao = 250, CaloriaPorcao = 575 };
                    context.Bebida.InsertOnSubmit(MilkShakeChocolate);


                    Exercicio Ciclismo = new Exercicio() { Nome = "Ciclismo", TempoPadrao = 30, CaloriasTempo = 126 };
                    context.Exercicio.InsertOnSubmit(Ciclismo);
                    Exercicio Futebol = new Exercicio() { Nome = "Futebol", TempoPadrao = 30, CaloriasTempo = 330 };
                    context.Exercicio.InsertOnSubmit(Futebol);
                    Exercicio Game = new Exercicio() { Nome = "VideoGame", TempoPadrao = 30, CaloriasTempo = 50 };
                    context.Exercicio.InsertOnSubmit(Game);
                    Exercicio Leitura = new Exercicio() { Nome = "Leitura", TempoPadrao = 30, CaloriasTempo = 50 };
                    context.Exercicio.InsertOnSubmit(Leitura);
                    Exercicio Danca = new Exercicio() { Nome = "Dança", TempoPadrao = 30, CaloriasTempo = 200 };
                    context.Exercicio.InsertOnSubmit(Danca);
                    Exercicio Escalada = new Exercicio() { Nome = "Escalada", TempoPadrao = 30, CaloriasTempo = 290 };
                    context.Exercicio.InsertOnSubmit(Escalada);
                    Exercicio Canto = new Exercicio() { Nome = "Canto", TempoPadrao = 30, CaloriasTempo = 55 };
                    context.Exercicio.InsertOnSubmit(Canto);
                    Exercicio Patinacao = new Exercicio() { Nome = "Patinação", TempoPadrao = 30, CaloriasTempo = 96 };
                    context.Exercicio.InsertOnSubmit(Patinacao);
                    Exercicio Dirigir = new Exercicio() { Nome = "Dirigir", TempoPadrao = 30, CaloriasTempo = 85};
                    context.Exercicio.InsertOnSubmit(Dirigir);
                    Exercicio Aerobica = new Exercicio() { Nome = "Aeróbica", TempoPadrao = 30, CaloriasTempo = 200 };
                    context.Exercicio.InsertOnSubmit(Aerobica);
                    Exercicio MusculacaoLeve = new Exercicio() { Nome = "MusculaçãoLeve", TempoPadrao = 30, CaloriasTempo = 160 };
                    context.Exercicio.InsertOnSubmit(MusculacaoLeve);
                    Exercicio MusculacaoPesada = new Exercicio() { Nome = "MusculaçãoPesada", TempoPadrao = 30, CaloriasTempo = 240 };
                    context.Exercicio.InsertOnSubmit(MusculacaoPesada);
                    Exercicio Ioga = new Exercicio() { Nome = "Ioga", TempoPadrao = 30, CaloriasTempo = 50 };
                    context.Exercicio.InsertOnSubmit(Ioga);
                    Exercicio Basquete = new Exercicio() { Nome = "Basquete", TempoPadrao = 30, CaloriasTempo = 280 };
                    context.Exercicio.InsertOnSubmit(Basquete);
                    Exercicio FuteVolei = new Exercicio() { Nome = "FuteVôlei", TempoPadrao = 30, CaloriasTempo = 200 };
                    context.Exercicio.InsertOnSubmit(FuteVolei);
                    Exercicio Volei = new Exercicio() { Nome = "Vôlei", TempoPadrao = 30, CaloriasTempo = 110 };
                    context.Exercicio.InsertOnSubmit(Volei);
                    Exercicio Tenis = new Exercicio() { Nome = "Tênis", TempoPadrao = 30, CaloriasTempo = 240 };
                    context.Exercicio.InsertOnSubmit(Tenis);
                    Exercicio Natacao = new Exercicio() { Nome = "Natação", TempoPadrao = 30, CaloriasTempo = 255 };
                    context.Exercicio.InsertOnSubmit(Natacao);
                    Exercicio Sexo = new Exercicio() { Nome = "Sexo", TempoPadrao = 30, CaloriasTempo = 280 };
                    context.Exercicio.InsertOnSubmit(Sexo);

                    context.SubmitChanges();

                }
            }
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(1500);
            using (var context = new MeuBanco(ConnectionString))
            {
                if (context.Usuario.Count() == 0)
                {
                    NavigationService.Navigate(new Uri("/Paginas/PaginaCadastro.xaml", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    Usuario u = context.Usuario.First();
                    if (u.UltimaData != DateTime.Today)
                    {
                        context.Usuario.First().UltimaData = DateTime.Today;
                        context.Usuario.First().CaloriaAtual = 0;
                    }
                    NavigationService.Navigate(new Uri("/Paginas/PaginaInicial.xaml", UriKind.RelativeOrAbsolute));
                }
            }

        }
    }
}