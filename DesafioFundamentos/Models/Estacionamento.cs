namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        public string placa;
        public string modelo;
        public string nome;
        public string codigo;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
          if (veiculos.Count() < 12){ 
            Console.WriteLine("Digite a placa do veículo, o nome do dono, o modelo do carro e codigo do cliente para estacionar:");
              placa = Console.ReadLine();
              nome = Console.ReadLine();
              modelo = Console.ReadLine();
              codigo = Console.ReadLine();
            veiculos.Add(modelo);
            veiculos.Add(nome);
            veiculos.Add(codigo);
            veiculos.Add(placa);
           }
          else
            Console.WriteLine("O estacionamento está lotado");
        }

        public void RemoverVeiculo()
        {
            

            Console.WriteLine("Por favor, para remover o veículo, digite o id de resgate");
             codigo = Console.ReadLine();
             
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == codigo.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = (precoInicial + precoPorHora) * horas; 
                
                
                veiculos.Remove(codigo);
                veiculos.Remove(placa);
                veiculos.Remove(nome);
                veiculos.Remove(modelo);


                Console.WriteLine($"O veículo de id {codigo} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou o codigo corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
               
                
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine(veiculos[0]);
                Console.WriteLine(veiculos[1]);
                Console.WriteLine(veiculos[2]);
                Console.WriteLine(veiculos[3]);
                Console.WriteLine("");
                Console.WriteLine(veiculos[4]);
                Console.WriteLine(veiculos[5]);
                Console.WriteLine(veiculos[6]);
                Console.WriteLine(veiculos[7]);
                Console.WriteLine("");
                Console.WriteLine(veiculos[8]);
                Console.WriteLine(veiculos[9]);
                Console.WriteLine(veiculos[10]);
                Console.WriteLine(veiculos[11]);


                
                         

                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}