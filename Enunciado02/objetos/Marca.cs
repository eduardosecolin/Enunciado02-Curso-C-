using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado02.objetos {
    class Marca {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<Carro> listaCarro { get; set; }

        public Marca(int cod, string name, string pais) {
            this.codigo = cod;
            this.nome = name;
            this.pais = pais;
            this.listaCarro = new List<Carro>();
        }
        public void adicionarCarro(Carro c) {
            listaCarro.Add(c);
            listaCarro.Sort();
        }
        public override string ToString() {
            return this.codigo + " , MARCA: " + this.nome + " , PAÍS: " + this.pais+" , Numero de Carros: "+listaCarro.Count;
        }

    }
}
