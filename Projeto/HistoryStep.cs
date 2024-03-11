public class HistoryStep
{
public int Id; // Esse é o código da parte da história que deve ser unico para cada historyStep
public string? Texto; //Atributo para guardar um texto qu vai aparecer para o usuario
public bool TemImagem= false;// atributo para dizer se tem ou não uma imagem para mostrar
public string? UrlDaImagem;// em caso de ter imagem esse atributo vai guardar ou o endereço da imagem ou o nome da imagem
public bool TemResposta=false;// atributo para dizer se é um texto para contar  histório ou se é preciso responder algo para continuar
public string? TextoDaResposta01;// texto do botãpo 1
public string? TextoDaResposta02;//texto do botão 2
public string? TextoDaResposta03;//texto do botão 3
public int IdLevelResposta01;// para qual código do historiStep o primeiro botão de resposta deve levar
public int IdLevelResposta02;//para qual código do historiStep o segundo botão de resposta deve levar
public int IdLevelResposta03;//para qual código do historiStep o terceiro botão de resposta deve levar
public bool herolIsDead= false;// Atributo para dizer se nesse passo o heroi morreu
}
       