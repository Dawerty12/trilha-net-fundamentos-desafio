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
        public int contador = 0;
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
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
            if (veiculos.Any())
            {

                foreach (string veiculo in veiculos)
                {
                    
                    Console.WriteLine(veiculo);
                    contador = contador + 1; 
                         if (contador == 4){ 
                          Console.WriteLine("");
                          contador = 0;
                        }
                         
                        }
    
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}