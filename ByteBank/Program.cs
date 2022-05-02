// See https://aka.ms/new-console-template for more information
using ByteBank;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

UsarSistema();
static void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

    Designer pedro = new(3000, "Pedro", "7839948323");
    Diretor roberta = new(5000, "Roberta", "87984094043");
    Auxiliar igor = new(2000, "Igor", "24521344323");
    GerenteConta camila = new(4000, "Camila", "32332332326");
    Desenvolvedor guilherme = new(3000, "Guilherme", "98237823241");

    gerenciadorBonificacao.Registrar(pedro);
    gerenciadorBonificacao.Registrar(roberta);
    gerenciadorBonificacao.Registrar(igor);
    gerenciadorBonificacao.Registrar(camila);
    gerenciadorBonificacao.Registrar(guilherme);

    Console.WriteLine(gerenciadorBonificacao.GetTotalBonificacao());
}

static void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new(5000, "Roberta", "42879474800");
    roberta.Senha = "teste1234";
    sistemaInterno.Logar(roberta, roberta.Senha);

    GerenteConta camila = new(4000, "Camila", "24355223553");
    camila.Senha = "123";
    sistemaInterno.Logar(camila, camila.Senha);

    ParceiroComercial parceiro = new("123");
    sistemaInterno.Logar(parceiro, "123");
}