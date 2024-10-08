﻿namespace any20;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;

	private int pula3vezes=0;
	int pula=0;

	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5, Pontuacao, Nivel);
	}

	void ButtonResposta1Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(1);
	}
	void ButtonResposta2Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(2);
	}
	void ButtonResposta3Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(3);
	}
	void ButtonResposta4Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(4);
	}
	void ButtonResposta5Clicked(object sender, EventArgs args)
	{
		gerenciador.VerificaCorreta(5);
	}

	void retirarClicked(object sender, EventArgs args)
	{
		var ajuda = new RetiraErrada();
		ajuda.ConfiguraDesenho( ButtonResposta1, ButtonResposta2,  ButtonResposta3,  ButtonResposta4, ButtonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible = false;

	}

	void pulaclicado(object sender, EventArgs args)

{
		pula3vezes++;
		pula++;
		gerenciador.ProximaQuestao();

	if ( pula == 2 )
	{
	(sender as Button).IsVisible = false;
	}
	else
	{
	gerenciador.ProximaQuestao();
	pula++;
	}

		gerenciador.ProximaQuestao();
		

		if (pula3vezes==1)
		{
			pular.Text="pula2x";
		}
		else if (pula3vezes==2)
		{
			pular.Text="pula1x";
		}
		else if(pula3vezes>=3)
		{
			(sender as Button).IsVisible = false;
		}

	}
void universitarioClicked(object sender, EventArgs args)
	{
		var ajuda = new Universitario();
		ajuda.ConfiguraDesenho( ButtonResposta1, ButtonResposta2,  ButtonResposta3,  ButtonResposta4, ButtonResposta5);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible = false;





	}

}