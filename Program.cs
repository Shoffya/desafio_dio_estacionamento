using DesafioDioEstacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal valorInicial = 0;
decimal valorPorHora = 0;

Console.WriteLine("------------------------- MaxLuy -------------------------\n");
Console.WriteLine("| Seja bem vindo ao sistema de estacionamento da MaxLuy! |\n");
Console.WriteLine("----------------------------------------------------------\n");
Console.WriteLine("Digite o preço inicial: \n");
valorInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------\n");
Console.WriteLine($"| Digite o preço o preço final: \n");
valorPorHora = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------\n");
Console.WriteLine("|                                                        |\n");

Estacionamento est = new Estacionamento(valorInicial, valorPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("------------------------------------------ MaxLuy -------------------------------------------\n");
    Console.WriteLine("|                             Escolha a opção que deseja fazer                              |\n");
    Console.WriteLine("---------------------------------------------------------------------------------------------\n");
    Console.WriteLine("|                                                                                           |\n");
    Console.WriteLine("| 1 - Cadastrar Veículo                                                                     |\n");
    Console.WriteLine("---------------------------------------------------------------------------------------------\n");
    Console.WriteLine("| 2 - Remover Veículo                                                                       |\n");
    Console.WriteLine("---------------------------------------------------------------------------------------------\n");
    Console.WriteLine("| 3 - Listar Veículos                                                                       |\n");
    Console.WriteLine("---------------------------------------------------------------------------------------------\n");
    Console.WriteLine("| 4 - Encerrar                                                                              |\n");
    Console.WriteLine("---------------------------------------------------------------------------------------------\n");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            est.CadastrarVeiculo();
            break;

        case "2":
            Console.Clear();
            est.RemoverVeiculo();
            break;

        case "3":
            Console.Clear();
            est.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}