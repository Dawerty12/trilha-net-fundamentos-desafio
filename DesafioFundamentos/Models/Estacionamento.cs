namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
        
            Console.WriteLine("Digite a placa do veículo, o nome do dono, o modelo do carro e código do cliente para estacionar:");
            var placa = Console.ReadLine();
            var nome = Console.ReadLine();
            var modelo = Console.ReadLine();
            var código = Console.ReadLine();
            veiculos.Add(modelo + nome + código + placa);
           
        }

        public void RemoverVeiculo()
        {
            

            Console.WriteLine("Por favor, para remover o veículo, digite o id de resgate");
            var código = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == código.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = (precoInicial + precoPorHora) * horas; 
                
                veiculos.Remove(código);

                Console.WriteLine($"O veículo de id {código} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou o código corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
              
                foreach (string veiculo in veiculos)
                {
                    
                    Console.WriteLine(veiculo);
                    
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}