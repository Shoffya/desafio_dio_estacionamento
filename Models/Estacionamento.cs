namespace DesafioDioEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal valorInicial = 0;
        private decimal valorPorHora = 0;
        private List<string> veiculos = new List<string>();

        string placa;

        public Estacionamento(decimal valorInicial, decimal valorPorHora)
        {
            this.valorInicial = valorInicial;
            this.valorPorHora = valorPorHora;
        }

        public void CadastrarVeiculo()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------\n");
            Console.WriteLine("                          Digite a placa do veículo para estacionar:                         ");
            placa = Console.ReadLine();

            if (placa.Length != 8)
            {
                Console.WriteLine("\n                                     Placa Invalida!                                   ");

                CadastrarVeiculo();
            }
            else if(veiculos.Any(x => x == placa)){
                Console.WriteLine("---------------------------------------------------------------------------------------------\n");
                Console.WriteLine("                                     Placa já cadastrada!                                    ");

                Console.WriteLine("                                Pressione ENTER para continuar                               ");
                Console.ReadLine();
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("---------------------------------------------------------------------------------------------\n");
                Console.WriteLine("                                Placa Cadastrada com Sucesso!                                ");

                Console.WriteLine("                                Pressione ENTER para continuar                               ");
                Console.ReadLine();
            }
        }

        // Console.WriteLine("Itens na lista:");
        //     foreach (string item in veiculos)
        //     {
        //         Console.WriteLine(item);
        //     }

        public void RemoverVeiculo()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------\n");
            Console.WriteLine("                             Digite a placa do veículo para remover:                         \n");
            string placaDesejada = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------\n");

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaDesejada.ToUpper()))
            {
                Console.WriteLine("             Digite a quantidade de horas que o veículo permaneceu estacionado:              \n");

                int horas = 0;
                decimal valorTotal = 0;

                horas = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------------------------------------------------\n");

                valorTotal += valorInicial + (valorPorHora * horas);

                veiculos.Remove(placaDesejada);

                Console.WriteLine($"       O veículo {placaDesejada} foi removido e o preço total foi de: {valorTotal:C}        \n");
                Console.WriteLine("                                Pressione ENTER para continuar                               ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("  Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente  \n");
                Console.WriteLine("                                Pressione ENTER para continuar                               ");
                Console.ReadLine();
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------\n");
                Console.WriteLine("                                 Os veículos estacionados são:                                 \n");
                foreach (string item in veiculos)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("                                Pressione ENTER para continuar                                 ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("                                 Não há veículos estacionados.                                 ");
            }
        }
    }
}
