// See https://aka.ms/new-console-template for more information
using DesafioEstacionamento.models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento.\n" +
                  "Digite o preço inicial:");

precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o valor por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);
//Instancia um objeto da classe Estacionamento, aplicando os valores de acordo com o obtido anteriomente.

bool exibirMenu = true;

while(exibirMenu){
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar um Veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - encerrar");

    switch(Console.ReadLine())
    {
        case "1":
            estacionamento.AdicioarVeiculo();
            break;
        
        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;
        
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção invalida, tente novamente.");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");