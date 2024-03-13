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
			TemResposta= false,
			BackMainPage=true
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
			IdLevelResposta02=200,
			IdLevelResposta03=2000
		});
		historia.Add(new HistoryStep()
		{
			Id = 2,
			Texto = "Desde a  minha infância James sempre esteve presente na Casa de Abuela, ele era  mordomo mas para Abuela era seu confidente e melhor amigo já que se conheciam desde muito jovens quando o pai de minha avó o acolheu em sua casa quando veio dos Estados Unidos. Eles cresceram Juntos! Como ele seria capaz de uma atrocidade dessas? Você acha que ele faria algo de tamanha crueldade?",
			TemResposta=true,
			TextoDaResposta01="SIM",
			TextoDaResposta02="NÃO",
			TextoDaResposta03="MUDAR PARA TELA INICIAL",
			IdLevelResposta01=3,
			IdLevelResposta02=300,
			IdLevelResposta03=0
		});
		historia.Add(new HistoryStep()
		{
			Id = 3,
			Texto = "James sabia da existência e tinha  acesso a toda dispensa da casa, para ele não seria difícil também saber aonde ficavam os inseticidas muito menos coloca-lo no chá que ele mesmo preparava para minha avó antes dela dormir. Tudo por que seu amor não foi correspondido o sentimento que cultivava desde a juventude foi ignorado por ela . para ele era injusto passar todos os dias olhando para ela e não receber a atenção que aquele sentimento pedia.",
			TemResposta=false,
		});
		historia.Add(new HistoryStep()
		{
			Id=4,
			Texto = "O que não sabíamos e que foi descoberto anos mais tarde , uma carta que com a letra inegável de minha Abuela  que declarava  que aquele sentimento era mutuo mas por vergonha de também não ser correspondida o guardava a sete chaves.",
			TemResposta=false,
		});
		historia.Add(new HistoryStep()
		{
			Id = 5,
			Texto = "(FIM DO CASO!)",
			TemResposta=false,
			HeroIsDead=true
		});

		//--------------------------------------------------------------------------------------------------------------
		// Caminho do Botao 2 (na escolha 2)
		historia.Add(new HistoryStep()
		{
			Id = 200,
			Texto = "Carlos e eu crescemos juntos na casa de Abuela, depois que a mãe de Carlos o deixou com a avó e não voltou mais. Sempre mantivemos uma rixa, que no começo era normal por sermos crianças, mas então fomos crescendo e percebi que Carlos realmente não suportava a minha presença. Seja por ciúmes ou por disputar a herança da abuela, nunca soube que ele seria capaz de tirar a vida de nossa amada avó. ",
			TemResposta=false
		});
		historia.Add(new HistoryStep()
		{
			Id = 201,
			Texto = "Na manhã seguinte do triste acontecimento, Carlos já não estava mais na mansão. Suas coisas e sua mala não estavam mais no seu quarto. As investigações encontraram uma carta na gaveta da avó. Gostaria de ler a carta?",
            TemResposta=true,
			TextoDaResposta01="SIM",
			TextoDaResposta02="NÃO",
			TextoDaResposta03="MUDAR PARA TELA INICIAL",
			IdLevelResposta01=202,
			IdLevelResposta02=203,
			IdLevelResposta03=0
		});
		historia.Add(new HistoryStep()
		{
			Id = 202,
			Texto = "Para todos os Garcia. Pensei em muito tempo no que deveria fazer, mas na manhã, antes do acontecido, depois de provar a minha hipótese, de que Alejandro sempre foi o neto preferido, embora seja eu que abri mão dos meus planos e sonhos para se adequar a vida na mansão. Os homens que aqui vieram pela manhã traziam consigo o testamento para abuela assinar, que garantia boa parte da herança para meu primo mais novo, que sequer merecia morar nessa casa. Nesse momento estou bem longe, mas o que posso dizer é que abuela  teve uma morte passiva, assim como foi a falta de sua presença e atenção em minha vida.",
            TemResposta=false
		});
        historia.Add(new HistoryStep()
		{
			Id = 203,
			Texto = "(FIM DO CASO!)",
            TemResposta=false,
			HeroIsDead=true
		});
		historia.Add(new HistoryStep()
		{
			Id = 204,
			Texto = "(FIM DO CASO!)",
            TemResposta=false,
			HeroIsDead=true
		});

		//--------------------------------------------------------------------------------------------------------------
		

		//--------------------------------------------------------------------------------------------------------------
		// Caminho do Botao 2 (na escolha 3)
		historia.Add(new HistoryStep()
		{
			Id = 300,
			Texto = "Sabia que ele não seria capaz de uma coisa dessas. Abuela pediu por confiar muito nele que forjasse sua morte para que pudessem desmascarar a tradicional  Familia  Garcia que só se preocupava com a herança da matriarca.",
			TemResposta=false,
		});
		historia.Add(new HistoryStep()
		{
			Id = 301,
			Texto = "(FIM DO CASO!)",
			TemResposta=false,
			HeroIsDead=true
		});

		//--------------------------------------------------------------------------------------------------------------
		// Caminho do Botao 3 (na escolha 3)
		historia.Add(new HistoryStep()
		{
			Id = 2000,
			Texto = "Fazia tempo que não via minha tia Tereza. Sua presença era estranha e suspeita, voltar anos mais tarde, sem dar dar notícias, e ainda querer a compreensão de Carlos? Será que ela mataria minha vó?",
            TemResposta=true,
			TextoDaResposta01="SIM",
			TextoDaResposta02="NÃO",
			TextoDaResposta03="MUDAR PARA TELA INICIAL",
			IdLevelResposta01=2001,
			IdLevelResposta02=2003,
			IdLevelResposta03=0
		});
		 historia.Add(new HistoryStep()
		{
			Id = 2001,
			Texto = "Descobrimos que sua visita inesperada realmente tinha um motivo, Tia Tereza tinha segredos, antes de ir embora deixou na mansão parte do dinheiro que seu marido possuía, antes de morrer, mas com a pressa de sair logo da casa, acabou deixando o saco com as notas no assoalho do quarto de Abuela. Aúnica forma de recuperar o dinheiro perdido era matar nossa avó",
            TemResposta=false	
		});
		 historia.Add(new HistoryStep()
		{
			Id = 2002,
			Texto = "Tia Tereza, trouxe de onde vinha, ainda desconhecido, uma torta que parecia muito gostosa. O que Abuela não sabia, era que a torta era preenchida de amendoim, alimento que minha avó era alérgica. Entretando percebeu tarde demais e começou a ter uma asfixia. Minha tia foi embora novamente, mas dessa vez , o dinheiro do assoalho não foi encontrado.",
            TemResposta=false	
		});
		 historia.Add(new HistoryStep()
		{
			Id = 2003,
			Texto = "(FIM DO CASO!)",
            TemResposta=false,	
			HeroIsDead=true
		});
		 historia.Add(new HistoryStep()
		{
			Id = 2004,
			Texto = "Descobrimos com sua visita inesperada, que sempre tentou contato, mas por proibição de nossa própria avó, Carlos foi privado de ter sua mãe por perto. Na verdade, por mais que fosse difícil, Tia Tereza nunca teria abandonado seu filho, mas abuela a expulsou, porque a culpava da morte do filho . Carlos também descobriu que as cartas pela morte do filho. Carlos descobriu também que sua abuela escondia as cartas que a mãe enviava, na gaveta em que era proibida ser aberta. Com essa visita repentina, abuela ficou com medo da reação de Carlos e morreu com uma parada cardíaca.",
            TemResposta=false,	
			HeroIsDead=true
		});

		
		
		
		Iniciar();
	}



	void Iniciar()
	{
		TrocaHistoryStepAtual(0);
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
	if (HistoryStepAtual.BackMainPage)
	{
		Voltar.IsVisible = true;
		
    }
	else
	{
		Voltar.IsVisible = false;
	}
		
  }
  void TrocaHistoryStepAtual(int id)
	{
		HistoryStepAtual = historia.Where(d => d.Id == id).First();
		PreencherPagina();
	}
	void OnButtonVerMaisCliked(object sender, EventArgs args)
	{
		var proximoId = HistoryStepAtual.Id + 1;
		TrocaHistoryStepAtual (proximoId);
	}
	 void OnButton01Clicked(object sender, EventArgs args)
	{
		TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta01);
	}

     void OnButtonBackClicked(object sender, EventArgs args)
	 {
		Application.Current.MainPage = new MainPage();
	 }
 

  void OnButton02Clicked(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta02);
  }
  

  void OnButton03Clicked(object sender, EventArgs args)
  {
    TrocaHistoryStepAtual(HistoryStepAtual.IdLevelResposta03);
  }


  void OnGameOverButtonClicked(object sender, EventArgs args)
  {
    Iniciar();
  }
}