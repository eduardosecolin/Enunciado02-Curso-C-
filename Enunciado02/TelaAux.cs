using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enunciado02.objetos;
using System.Globalization;

namespace Enunciado02 {
    class TelaAux {
        //MOSTRAR O MENU
        public static void mostrarMenu() {
            Console.WriteLine("---- MENU ----");
            Console.WriteLine("1 - Listar Marcas");
            Console.WriteLine("2 - Listar Carros de uma Marca Ordenadamente");
            Console.WriteLine("3 - Cadastrar Marca");
            Console.WriteLine("4 - Cadastrar Carro");
            Console.WriteLine("5 - Cadastrar Acessorio");
            Console.WriteLine("6 - Mostrar detalhes de um carro");
            Console.WriteLine("7 - Sair");
            Console.Write("Escolha um item do menu: ");
        }
        //LISTAR AS MARCAS
        public static void listarMarcas() {
            Console.WriteLine();
            for (int i = 0; i < Program.listaMarca.Count; i++) {
                Console.WriteLine(Program.listaMarca[i]);
            }
        }
        //LISTAR OS CARROS DE UMA MARCA
        public static void listarCarrosDeUmaMarca() {
            Console.WriteLine();
            Console.Write("Digite o codigo da marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.listaMarca.FindIndex(user => user.codigo == codMarca);
            if(pos == -1) {
                throw new Excecoes("Codigo não encontrado" + codMarca);
            }
            Console.WriteLine("Carros da marca: "+Program.listaMarca[pos].nome);
            List<Carro> lista = Program.listaMarca[pos].listaCarro;
            for(int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i].detalhes());
            }
           
        }
        //CADASTRAR MARCA
        public static void cadastarMarca() {
            Console.WriteLine();
            Console.WriteLine("¬[DIGITE OS DADOS DA MARCA]¬");
            Console.Write("CODIGO        : ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("NOME          : ");
            string nome = Console.ReadLine();
            Console.Write("PAÍS DE ORIGEM: ");
            string pais = Console.ReadLine();
            Marca M = new Marca(codigo, nome, pais);
            Program.listaMarca.Add(M);
        }
        //CADASTRAR CARRO
        public static void cadastrarCarro() {
            Console.WriteLine();
            Console.WriteLine("¨[DIGITE OS DADOS DO CARRO]¨");
            Console.Write("CODIGO (MARCA): ");
            int codMarca = int.Parse(Console.ReadLine());
            int posicao = Program.listaMarca.FindIndex(user => user.codigo == codMarca);
            if(posicao == -1) {
                throw new Excecoes("Codigo não encontrado" + codMarca);
            }
            Console.Write("CODIGO: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("MODELO: ");
            string modelo = Console.ReadLine();
            Console.Write("ANO   : ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("PREÇO : ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Marca M = Program.listaMarca[posicao];
            Carro C = new Carro(codigo, modelo, ano, preco, M);
            M.adicionarCarro(C);
            Program.listaCarro.Add(C);
        }
        //CADASTRO DE ACESSORIO
        public static void cadastrarAcessorio() {
            Console.WriteLine();
            Console.WriteLine("*[DIGITE OS DADOS DO ACESSORIO]*");
            Console.Write("CODIGO (CARRO): ");
            int codCarro = int.Parse(Console.ReadLine());
            int posicao = Program.listaCarro.FindIndex(user => user.codigo == codCarro);
            if(posicao == -1) {
                throw new Excecoes("Codigo não existe!" + codCarro);
            }
            Console.Write("NOME : ");
            string nome = Console.ReadLine();
            Console.Write("PREÇO: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Carro c = Program.listaCarro[posicao];
            Acessorio a = new Acessorio(nome, preco, c);
            c.listaAcessorio.Add(a);           
        }
        //LISTAR DETALHES DE UM CARRO
        public static void listarDetalhesDeUmCarro(List<Carro> listaCarro) {
            Console.WriteLine();
            Console.Write("Digite o codigo do carro: ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = listaCarro.FindIndex(x => x.codigo == codCarro);
            if(pos == -1) {
                throw new Excecoes("Codigo incorreto!" + codCarro);
            }
            Console.WriteLine(listaCarro[pos]);
        }
    }
}
