using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enunciado02.objetos;

namespace Enunciado02 {
    class Program {

       public static List<Marca> listaMarca = new List<Marca>();
       public static List<Carro> listaCarro = new List<Carro>();

        static void Main(string[] args) {
            listaMarca.Add(new Marca(1000, "Renault", "Franca"));
            listaMarca.Add(new Marca(1001, "Fiat", "Itália"));
            listaMarca.Add(new Marca(1002, "Ford", "EUA"));


            int opc = 0;
            while(opc != 7) {
                Console.WriteLine();
                TelaAux.mostrarMenu();
                try {
                    opc = int.Parse(Console.ReadLine());
                }
                catch (Excecoes e) {
                    Console.WriteLine("Erro inesperado!!!" + e.Message);
                }
                switch (opc) {
                    case 1:
                        TelaAux.listarMarcas();
                        break;
                    case 2:
                        TelaAux.listarCarrosDeUmaMarca();
                        break;
                    case 3:
                        TelaAux.cadastarMarca();
                        break;
                    case 4:
                        TelaAux.cadastrarCarro();
                        break;
                    case 5:
                        TelaAux.cadastrarAcessorio();
                        break;
                    case 6:
                        TelaAux.listarDetalhesDeUmCarro(listaCarro);
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Opção invalida!!!");
                        break;
                }
            }
        }
    }
}
