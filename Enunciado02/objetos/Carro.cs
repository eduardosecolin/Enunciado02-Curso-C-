using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enunciado02.objetos{
    class Carro : IComparable{
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public Marca marca { get; set; }
        public List<Acessorio> listaAcessorio { get; set; }

        public Carro(int codigo,string modelo,int ano,double preco,Marca marca) {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = preco;
            this.marca = marca;
            this.listaAcessorio = new List<Acessorio>();
        }
        public double precoTotal() {
            double soma = precoBasico;
            for(int i = 0; i < listaAcessorio.Count; i++) {
                soma = soma + listaAcessorio[i].preco;
            }
            return soma;
        }
        public override string ToString() {
            String s = codigo + " , MODELO: " + modelo + " , ANO: " + ano +
                " , Preço Basico: " + precoBasico.ToString("F2", CultureInfo.InvariantCulture)+
                " , Preço Total: "+precoTotal().ToString("F2",CultureInfo.InvariantCulture);
            if(listaAcessorio.Count > 0) {
                for (int i = 0; i < listaAcessorio.Count; i++) {
                    s = s + "\nACESSORIOS---\n" + listaAcessorio[i];
                }
            }
            return s;
        }
        public string detalhes() {
            return codigo + " , MODELO: " + modelo + " , ANO: " + ano;
        }

        public int CompareTo(object obj) {
            Carro outro = ((Carro)obj);
            int resultado = this.modelo.CompareTo(outro.modelo);
            if(resultado != 0) {
                return resultado;
            }else {
                return -precoTotal().CompareTo(outro.precoTotal());
            }
        }
    }
}
