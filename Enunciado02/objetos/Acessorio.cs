﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enunciado02.objetos {
    class Acessorio {
        public string nome { get; set; }
        public double preco { get; set; }
        public Carro carro { get; set; }

        public Acessorio(string nome,double preco,Carro carro) {
            this.nome = nome;
            this.preco = preco;
            this.carro = carro;
        }

        public override string ToString() {
            return "NOME: " + nome + " , PREÇO: " + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
