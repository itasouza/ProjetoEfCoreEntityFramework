using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEF.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string nome { get; set; }

        public override string ToString()
        {
            return "Id:" + this.id + "Nome:" + this.nome;
        }
    }
}
