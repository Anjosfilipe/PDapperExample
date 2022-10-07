using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDapperExample.Model
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }


        public readonly static string INSERT = "INSERT INTO TB_Cliente (Nome,Telefone) VALUES(@Nome,@Telefone)";
        public readonly static string SELECT = "SELECT ID,Nome,Telefone FROM TB_Cliente";

        public override string ToString()
        {
            return "ID: "+this.ID+"\nNome: "+this.Nome+"\nTelefone: "+this.Telefone; 
        }
    }
}
