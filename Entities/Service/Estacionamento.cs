using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Entities.Service {
    internal class Estacionamento {

        public double PrecoInicial = 15.00;
        public double PrecoHora = 4.00;
        public List<Vehicle> Carro { get; set; }

        public Estacionamento() { }
        public Estacionamento(double precoInicial, double precoHora) {
            PrecoInicial = precoInicial;
            PrecoHora = precoHora;
        }

        public void AddCarro(Vehicle carro) {
            Carro.Add(carro);
        }

        public void RemoveCarro(Vehicle carro) {
            Carro.Remove(carro);
        }

        public void ListarCarros(List<Vehicle> carros) {
            foreach (Vehicle carro in carros) {
                Console.WriteLine(carro);
            }
        }

        public double FinalPrice() {
            double precoFinal = PrecoInicial * PrecoHora;
            return precoFinal;
        }

    }
}
