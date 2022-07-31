using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Jogo_da_Velha
{
    public partial class MainPage : ContentPage
    {

        // Variáveis Públicas:

        string jogador_atual = "";

        bool primeira_jogada = true;

        int contador = 0;

        bool vencedor = false;

        public MainPage()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            btn_reset.IsEnabled = false;

            logo.Source = ImageSource.FromResource("App_Jogo_da_Velha.Image.download.jpg");

        }

        private async void btn_Clicked(object sender, EventArgs e)
        {

            try
            {

                Button botao = (Button)sender;

                if (vencedor.Equals(false))
                {

                    if (botao.Text != "")
                    {

                        await DisplayAlert("Aviso!", "Este campo já foi usado!", "OK");

                    }

                    else
                    {

                        if (primeira_jogada.Equals(true))
                        {

                            if (rdbtn_X.IsChecked == true)
                            {

                                jogador_atual = "X";

                                botao.Text = jogador_atual.ToString();

                                rdbtn_O.IsEnabled = false;

                                primeira_jogada = false;

                                contador++;

                                btn_reset.IsEnabled = true;

                            }

                            else if (rdbtn_O.IsChecked == true)
                            {

                                jogador_atual = "O";

                                botao.Text = jogador_atual.ToString();

                                rdbtn_X.IsEnabled = false;

                                primeira_jogada = false;

                                contador++;

                                btn_reset.IsEnabled = true;

                            }

                            else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                            {

                                await DisplayAlert("Atenção!", "Escolha uma das opções antes de jogar!", "OK");

                            }

                        }

                        else
                        {

                            if (jogador_atual == "X")
                            {

                                jogador_atual = "O";

                                botao.Text = jogador_atual.ToString();

                                contador++;

                            }

                            else
                            {

                                jogador_atual = "X";

                                botao.Text = jogador_atual.ToString();

                                contador++;

                            }

                        }

                        verificar();

                    }

                }

                else
                {

                    await DisplayAlert("Atenção!", "A partida já terminou! Clique em reiniciar para começar outra partida.", "OK");

                }


            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

            /*try
            {

                if (vencedor == "")
                {

                    if (btn_1.Text != "")
                    {

                        await DisplayAlert("Aviso!", "Este campo já foi usado!", "OK");

                    }

                    else
                    {

                        if (primeira_jogada == 0)
                        {

                            if (rdbtn_X.IsChecked == true)
                            {

                                jogador_atual = "X";

                                btn_1.Text = jogador_atual.ToString();

                                rdbtn_O.IsEnabled = false;

                                primeira_jogada++;

                                contador++;

                                btn_reset.IsEnabled = true;

                            }

                            else if (rdbtn_O.IsChecked == true)
                            {

                                jogador_atual = "O";

                                btn_1.Text = jogador_atual.ToString();

                                rdbtn_X.IsEnabled = false;

                                primeira_jogada++;

                                contador++;

                                btn_reset.IsEnabled = true;

                            }

                            else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                            {

                                await DisplayAlert("Atenção!", "Escolha uma das opções antes de jogar!", "OK");

                            }

                        }

                        else
                        {

                            if (jogador_atual == "X")
                            {

                                jogador_atual = "O";

                                btn_1.Text = jogador_atual.ToString();

                                contador++;

                            }

                            else
                            {

                                jogador_atual = "X";

                                btn_1.Text = jogador_atual.ToString();

                                contador++;

                            }

                        }

                        verificar();

                    }

                }

                else
                {

                    await DisplayAlert("Atenção!", "A partida já terminou! Clique em reiniciar para começar outra partida.", "OK");

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro", ex.Message, "OK");

            }*/

        }

        private async void btn_reset_Clicked(object sender, EventArgs e)
        {

            try
            {

                rdbtn_X.IsChecked = false;
                rdbtn_O.IsChecked = false;

                rdbtn_X.IsEnabled = true;
                rdbtn_O.IsEnabled = true;

                btn_1.Text = "";
                btn_2.Text = "";
                btn_3.Text = "";

                btn_4.Text = "";
                btn_5.Text = "";
                btn_6.Text = "";

                btn_7.Text = "";
                btn_8.Text = "";
                btn_9.Text = "";

                jogador_atual = "";

                primeira_jogada = true;

                contador = 0;

                vencedor = false;

                btn_reset.IsEnabled = false;

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro", ex.Message, "OK");

            }

        }

        async void verificar()
        {

            try
            {

                /* Esse método servirá para verificar se alguém venceu, portanto o jogo acaba, ou se o jogo continuará. */

                // Linhas:

                if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: X.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: O.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: X.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: O.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: X.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: O.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                // Colunas:

                else if (btn_1.Text == "X" && btn_4.Text == "X" && btn_7.Text == "X")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: X.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_1.Text == "O" && btn_4.Text == "O" && btn_7.Text == "O")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: O.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_2.Text == "X" && btn_5.Text == "X" && btn_8.Text == "X")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: X.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_2.Text == "O" && btn_5.Text == "O" && btn_8.Text == "O")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: O.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_3.Text == "X" && btn_6.Text == "X" && btn_9.Text == "X")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: X.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_3.Text == "O" && btn_6.Text == "O" && btn_9.Text == "O")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: O.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                // Diagonais:

                else if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: X.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: O.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_3.Text == "X" && btn_5.Text == "X" && btn_7.Text == "X")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: X.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                else if (btn_3.Text == "O" && btn_5.Text == "O" && btn_7.Text == "O")
                {

                    await DisplayAlert("Fim de Jogo!", "🏆 Vencedor: O.", "OK");

                    contador = 0;

                    vencedor = true;

                }

                // Velha:

                else if (btn_1.Text != "" && btn_2.Text != "" && btn_3.Text != "" && btn_4.Text != ""
                        && btn_5.Text != "" && btn_6.Text != "" && btn_7.Text != "" && btn_8.Text != "" && btn_9.Text != ""
                        && contador == 9)
                {

                    await DisplayAlert("Fim de Jogo!", "🤝🏼 Deu Velha!", "OK");

                    vencedor = true;

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro", ex.Message, "OK");

            }

        }

    }

}
