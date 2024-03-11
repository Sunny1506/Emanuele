using Microsoft.Maui.Controls;

namespace Projeto;

public partial class GamePage : ContentPage
{ 
	List<HistoryStep> historia = new List<HistoryStep>();
	HistoryStep HistoryStepAtual;
	

	public GamePage()
	{
		InitializeComponent();

		historia.Add(new HistoryStep()  
		{
			Id=0, 
			Texto="Minha Avó se encontrava em sua grande mansão em uma quinta feira de outono tomando seu chá de camomila, James que  foi o primeiro a encontra-la disse que abuela  desde o inicio da manhã estava em um dia atípico  cheio de reuniões com homens suspeito que usavam ternos e maletas. O que sera que realmente aconteceu para ela terminar o dia sem vida?",
			TemResposta= false
		});
		historia.Add(new HistoryStep()
		{
			Id=1,
			Texto= "Oque mais me espanta é a decisão de minha avó, que dentre toda família Garcia deixou todos seus bens em meu nome. O que ela pretendia fazer? Por que eu e não meu primo Carlos? Ou James que sempre foi seu melhor amigo? Ou talvez minha mãe que se manteve firme mesmo após a morte de meu pai e mesmo com tanta desfeita não cortou laços daminha relação com ela. Minha missão foi dada investigar quem foi o  autor crime dentre aqueles que eu chamava de “família” Quem você acha que a matou?",
		TemResposta= true,
		TextoDaResposta01="JAMES O MODRDOMO",
		TextoDaResposta02="CARLOS",
		TextoDaResposta03="TIA TEREZA",
		IdLevelResposta01=2,
		IdLevelResposta02=100,
		IdLevelResposta03=200
		
		});
		historia.Add(new HistoryStep()
		{
		Id = 2,
		Texto = "Desde a  minha infância James sempre esteve presente na Casa de Abuela, ele era  mordomo mas para Abuela era seu confidente e melhor amigo já que se conheciam desde muito jovens quando o pai de minha avó o acolheu em sua casa quando veio dos Estados Unidos. Eles cresceram Juntos! Como ele seria capaz de uma atrocidade dessas? Você acha que ele faria algo de tamanha crueldade?",
		TemResposta=true,
		TextoDaResposta01="SIM",
		TextoDaResposta02="NÃO",
		TextoDaResposta03="MUDAR PARA TELA INICIAL",
		IdLevelResposta01=6,
		IdLevelResposta02=150,
		IdLevelResposta03=250
		
		});
		historia.Add(new HistoryStep()
		{
			Id = 6,
		Texto = "James sabia da existência e tinha  acesso a toda dispensa da casa, para ele não seria difícil também saber aonde ficavam os inseticidas muito menos coloca-lo no chá que ele mesmo preparava para minha avó antes dela dormir. Tudo por que seu amor não foi correspondido o sentimento que cultivava desde a juventude foi ignorado por ela . para ele era injusto passar todos os dias olhando para ela e não receber a atenção que aquele sentimento pedia.",
		TemResposta=false,
		});
		historia.Add(new HistoryStep()
		{
			Id=7,
		Texto = "O que não sabíamos e que foi descoberto anos mais tarde , uma carta que com a letra inegável de minha Abuela  que declarava  que aquele sentimento era mutuo mas por vergonha de também não ser correspondida o guardava a sete chaves.",
		TemResposta=false,
		});
		historia.Add(new HistoryStep()
		{
		Id = 8,
		Texto = "(FIM DO CASO!)",
		TemResposta=false,
		HeroIsDead=true
		});
		historia.Add(new HistoryStep()
		{
		Id = 150,
		Texto = "Sabia que ele não seria capaz de uma coisa dessas. Abuela pediu por confiar muito nele que forjasse sua morte para que pudessem desmascarar a tradicional  Familia  Garcia que só se preocupava com a herança da matriarca.",
		TemResposta=false,
		});
		historia.Add(new HistoryStep()
		{
		Id = 151,
		Texto = "(FIM DO CASO!)",
		TemResposta=false,
		HeroIsDead=true
		});
	}



	void Iniciar()
	{
		TrocaHistoryStepAtual(0);
	}
	void TrocaHistoryStepAtual(int id)
	{
		HistoryStepAtual = historia.Where(d => d.IdLevelResposta01 == id).First;
		PreencherPagina();
	}
		void PreencherPagina()
  {
    labelTexto.Text = HistoryStepAtual.Texto;

    if (HistoryStepAtual.HeroIsDead)
      frameGameOver.IsVisible = true;
    else
      frameGameOver.IsVisible = false;

    if (HistoryStepAtual.TemResposta)
    {
      buttonVerMais.IsVisible = false;
      buttonResposta01.IsVisible = true;
      buttonResposta02.IsVisible = true;
      buttonResposta03.IsVisible = true;
      buttonResposta01.Text = HistoryStepAtual.TextoDaResposta01;
      buttonResposta02.Text = HistoryStepAtual.TextoDaResposta02;
      buttonResposta03.Text = HistoryStepAtual.TextoDaResposta03;
    }
    else
    {
      buttonVerMais.IsVisible = true;
      buttonResposta01.IsVisible = false;
      buttonResposta02.IsVisible = false;
      buttonResposta03.IsVisible = false;
    }
  }
	void OnButtonVerMaisCliked(object sender, EventArgs args)
	{
	var proximoId = HistoryStepAtual.Id + 1;
	TrocaHistoryStepAtual (proximoId);
	}
}