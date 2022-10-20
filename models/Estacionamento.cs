using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEstacionamento.models
{


    //TODO: criar metodo para verificar validade e não nulicidade de placas
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicioarVeiculo(){
            //TODO:incluir metodo de verificação de validade e não nulicidade de placas
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            this.veiculos.Add(Console.ReadLine().ToUpper());
            
        }

        public void RemoverVeiculo(){
            //TODO: incluir metodo de verificação de validade e não nulicidade de placas
            Console.WriteLine("Digite a placa do veiculo para remover: ");
            
            string placa = Console.ReadLine().ToUpper();
            while(string.IsNullOrEmpty(placa)){
                Console.WriteLine("Placa invalida, digite novamente: ");
                placa = Console.ReadLine();
            }

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                //TODO: tratamento de exceção para valores não conversiveis.
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R${valorTotal}");

            }
            else{
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira a placa e tente novamente.");
            }
        }

        public void ListarVeiculos(){
            if(veiculos.Any()){
                Console.WriteLine("Os veiculos estacionados são:");
                foreach(string veiculo in veiculos){
                    Console.WriteLine(veiculo);
                }
            }
            else{
                Console.Write("Não há veículos estacionados");
            }
        }
    }
}