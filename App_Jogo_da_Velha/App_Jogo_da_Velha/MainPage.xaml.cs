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

        string jogador_atual = "";

        int primeira_jogada = 0;

        int contador = 0;

        public MainPage()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void btn_1_Clicked(object sender, EventArgs e)
        {
            
            if(btn_1.Text != "")
            {

                await DisplayAlert("Aviso", "Este campo já foi usado", "OK");

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

                    }

                    else if (rdbtn_O.IsChecked == true)
                    {

                        jogador_atual = "O";

                        btn_1.Text = jogador_atual.ToString();

                        rdbtn_X.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                    {

                        await DisplayAlert("Aviso", "Escolha uma das opções antes de jogar", "OK");

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

        private async void btn_2_Clicked(object sender, EventArgs e)
        {

            if(btn_2.Text != "")
            {

                await DisplayAlert("Aviso", "Este campo já foi usado", "OK");

            }

            else
            {

                if (primeira_jogada == 0)
                {

                    if (rdbtn_X.IsChecked == true)
                    {

                        jogador_atual = "X";

                        btn_2.Text = jogador_atual.ToString();

                        rdbtn_O.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_O.IsChecked == true)
                    {

                        jogador_atual = "O";

                        btn_2.Text = jogador_atual.ToString();

                        rdbtn_X.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                    {

                        await DisplayAlert("Aviso", "Escolha uma das opções antes de jogar", "OK");

                    }

                }

                else
                {

                    if (jogador_atual == "X")
                    {

                        jogador_atual = "O";

                        btn_2.Text = jogador_atual.ToString();

                        contador++;

                    }

                    else
                    {

                        jogador_atual = "X";

                        btn_2.Text = jogador_atual.ToString();

                        contador++;

                    }

                }

                verificar();

            }

        }

        private async void btn_3_Clicked(object sender, EventArgs e)
        {

            if(btn_3.Text != "")
            {

                await DisplayAlert("Aviso", "Este campo já foi usado", "OK");

            }

            else
            {

                if (primeira_jogada == 0)
                {

                    if (rdbtn_X.IsChecked == true)
                    {

                        jogador_atual = "X";

                        btn_3.Text = jogador_atual.ToString();

                        rdbtn_O.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_O.IsChecked == true)
                    {

                        jogador_atual = "O";

                        btn_3.Text = jogador_atual.ToString();

                        rdbtn_X.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                    {

                        await DisplayAlert("Aviso", "Escolha uma das opções antes de jogar", "OK");

                    }

                }

                else
                {

                    if (jogador_atual == "X")
                    {

                        jogador_atual = "O";

                        btn_3.Text = jogador_atual.ToString();

                        contador++;

                    }

                    else
                    {

                        jogador_atual = "X";

                        btn_3.Text = jogador_atual.ToString();

                        contador++;

                    }

                }

                verificar();

            }

        }

        private async void btn_4_Clicked(object sender, EventArgs e)
        {

            if(btn_4.Text != "")
            {

                await DisplayAlert("Aviso", "Este campo já foi usado", "OK");

            }

            else
            {

                if (primeira_jogada == 0)
                {

                    if (rdbtn_X.IsChecked == true)
                    {

                        jogador_atual = "X";

                        btn_4.Text = jogador_atual.ToString();

                        rdbtn_O.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_O.IsChecked == true)
                    {

                        jogador_atual = "O";

                        btn_4.Text = jogador_atual.ToString();

                        rdbtn_X.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                    {

                        await DisplayAlert("Aviso", "Escolha uma das opções antes de jogar", "OK");

                    }

                }

                else
                {

                    if (jogador_atual == "X")
                    {

                        jogador_atual = "O";

                        btn_4.Text = jogador_atual.ToString();

                        contador++;

                    }

                    else
                    {

                        jogador_atual = "X";

                        btn_4.Text = jogador_atual.ToString();

                        contador++;

                    }

                }

                verificar();

            }

        }

        private async void btn_5_Clicked(object sender, EventArgs e)
        {

            if(btn_5.Text != "")
            {

                await DisplayAlert("Aviso", "Este campo já foi usado", "OK");

            }

            else
            {

                if (primeira_jogada == 0)
                {

                    if (rdbtn_X.IsChecked == true)
                    {

                        jogador_atual = "X";

                        btn_5.Text = jogador_atual.ToString();

                        rdbtn_O.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_O.IsChecked == true)
                    {

                        jogador_atual = "O";

                        btn_5.Text = jogador_atual.ToString();

                        rdbtn_X.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                    {

                        await DisplayAlert("Aviso", "Escolha uma das opções antes de jogar", "OK");

                    }

                }

                else
                {

                    if (jogador_atual == "X")
                    {

                        jogador_atual = "O";

                        btn_5.Text = jogador_atual.ToString();

                        contador++;

                    }

                    else
                    {

                        jogador_atual = "X";

                        btn_5.Text = jogador_atual.ToString();

                        contador++;

                    }

                }

                verificar();

            }

        }

        private async void btn_6_Clicked(object sender, EventArgs e)
        {

            if(btn_6.Text != "")
            {
                await DisplayAlert("Aviso", "Este campo já foi usado", "OK");
            }

            else
            {

                if (primeira_jogada == 0)
                {

                    if (rdbtn_X.IsChecked == true)
                    {

                        jogador_atual = "X";

                        btn_6.Text = jogador_atual.ToString();

                        rdbtn_O.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_O.IsChecked == true)
                    {

                        jogador_atual = "O";

                        btn_6.Text = jogador_atual.ToString();

                        rdbtn_X.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                    {

                        await DisplayAlert("Aviso", "Escolha uma das opções antes de jogar", "OK");

                    }

                }

                else
                {

                    if (jogador_atual == "X")
                    {

                        jogador_atual = "O";

                        btn_6.Text = jogador_atual.ToString();

                        contador++;

                    }

                    else
                    {

                        jogador_atual = "X";

                        btn_6.Text = jogador_atual.ToString();

                        contador++;

                    }

                }

                verificar();

            }

        }

        private async void btn_7_Clicked(object sender, EventArgs e)
        {

            if(btn_7.Text != "")
            {

                await DisplayAlert("Aviso", "Este campo já foi usado", "OK");

            }

            else
            {

                if (primeira_jogada == 0)
                {

                    if (rdbtn_X.IsChecked == true)
                    {

                        jogador_atual = "X";

                        btn_7.Text = jogador_atual.ToString();

                        rdbtn_O.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_O.IsChecked == true)
                    {

                        jogador_atual = "O";

                        btn_7.Text = jogador_atual.ToString();

                        rdbtn_X.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                    {

                        await DisplayAlert("Aviso", "Escolha uma das opções antes de jogar", "OK");

                    }

                }

                else
                {

                    if (jogador_atual == "X")
                    {

                        jogador_atual = "O";

                        btn_7.Text = jogador_atual.ToString();

                        contador++;

                    }

                    else
                    {

                        jogador_atual = "X";

                        btn_7.Text = jogador_atual.ToString();

                        contador++;

                    }

                }

                verificar();

            }

        }

        private async void btn_8_Clicked(object sender, EventArgs e)
        {

            if(btn_8.Text != "")
            {

                await DisplayAlert("Aviso", "Este campo já foi usado", "OK");

            }

            else
            {

                if (primeira_jogada == 0)
                {

                    if (rdbtn_X.IsChecked == true)
                    {

                        jogador_atual = "X";

                        btn_8.Text = jogador_atual.ToString();

                        rdbtn_O.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_O.IsChecked == true)
                    {

                        jogador_atual = "O";

                        btn_8.Text = jogador_atual.ToString();

                        rdbtn_X.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                    {

                        await DisplayAlert("Aviso", "Escolha uma das opções antes de jogar", "OK");

                    }

                }

                else
                {

                    if (jogador_atual == "X")
                    {

                        jogador_atual = "O";

                        btn_8.Text = jogador_atual.ToString();

                        contador++;

                    }

                    else
                    {

                        jogador_atual = "X";

                        btn_8.Text = jogador_atual.ToString();

                        contador++;

                    }

                }

                verificar();

            }

        }

        private async void btn_9_Clicked(object sender, EventArgs e)
        {

            if(btn_9.Text != "")
            {

                await DisplayAlert("Aviso", "Este campo já foi usado", "OK");

            }

            else
            {

                if (primeira_jogada == 0)
                {

                    if (rdbtn_X.IsChecked == true)
                    {

                        jogador_atual = "X";

                        btn_9.Text = jogador_atual.ToString();

                        rdbtn_O.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_O.IsChecked == true)
                    {

                        jogador_atual = "O";

                        btn_9.Text = jogador_atual.ToString();

                        rdbtn_X.IsEnabled = false;

                        primeira_jogada++;

                        contador++;

                    }

                    else if (rdbtn_X.IsChecked == false && rdbtn_O.IsChecked == false)
                    {

                        await DisplayAlert("Aviso", "Escolha uma das opções antes de jogar", "OK");

                    }

                }

                else
                {

                    if (jogador_atual == "X")
                    {

                        jogador_atual = "O";

                        btn_9.Text = jogador_atual.ToString();

                        contador++;

                    }

                    else
                    {

                        jogador_atual = "X";

                        btn_9.Text = jogador_atual.ToString();

                        contador++;

                    }

                }

                verificar();

            }

        }

        private void btn_reset_Clicked(object sender, EventArgs e)
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

            primeira_jogada = 0;

            contador = 0;

        }

        async void verificar()
        {

            /* Esse método servirá para verificar se alguém venceu, portanto o jogo acaba, ou se o jogo continuará. */

            // Linhas:

            if(btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: X", "OK");

                contador = 0;

            }

            else if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: O", "OK");

                contador = 0;

            }

            else if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: X", "OK");

                contador = 0;

            }

            else if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: O", "OK");

                contador = 0;

            }

            else if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: X", "OK");

                contador = 0;

            }

            else if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: O", "OK");

                contador = 0;

            }

            // Colunas:

            else if (btn_1.Text == "X" && btn_4.Text == "X" && btn_7.Text == "X")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: X", "OK");

                contador = 0;

            }

            else if (btn_1.Text == "O" && btn_4.Text == "O" && btn_7.Text == "O")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: O", "OK");

                contador = 0;

            }

            else if (btn_2.Text == "X" && btn_5.Text == "X" && btn_8.Text == "X")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: X", "OK");

                contador = 0;

            }

            else if (btn_2.Text == "O" && btn_5.Text == "O" && btn_8.Text == "O")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: O", "OK");

                contador = 0;

            }

            else if (btn_3.Text == "X" && btn_6.Text == "X" && btn_9.Text == "X")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: X", "OK");

                contador = 0;

            }

            else if (btn_3.Text == "O" && btn_6.Text == "O" && btn_9.Text == "O")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: O", "OK");

                contador = 0;

            }

            // Diagonais:

            else if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: X", "OK");

                contador = 0;

            }

            else if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: O", "OK");

                contador = 0;

            }

            else if (btn_3.Text == "X" && btn_5.Text == "X" && btn_7.Text == "X")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: X", "OK");

                contador = 0;

            }

            else if (btn_3.Text == "O" && btn_5.Text == "O" && btn_7.Text == "O")
            {

                await DisplayAlert("Aviso", "🏆 Vencedor: O", "OK");

                contador = 0;

            }

            // Velha:

            else if(btn_1.Text != "" && btn_2.Text != "" && btn_3.Text != "" && btn_4.Text != "" 
                    && btn_5.Text != "" && btn_6.Text != "" && btn_7.Text != "" && btn_8.Text != "" && btn_9.Text != "" 
                    && contador == 9)
            {

                await DisplayAlert("Atenção", "🤝 Deu Velha!", "OK");

            }

        }

    }
}
