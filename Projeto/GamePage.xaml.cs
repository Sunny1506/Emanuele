using Microsoft.Maui.Controls;

namespace Projeto;

public partial class GamePage : ContentPage
{ 
	List<HistoryStep> historia = new List<HistoryStep>();
	HistoryStep HistoryStepAtual;
	

	public GamePage()
	{
		InitializeComponent();
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
	void OnButtonVerMaisCliked(object sender, EventArgs args)
	{
	var proximoId = HistoryStepAtual.Id + 1;
	TrocaHistoryStepAtual (proximoId);
	}
}