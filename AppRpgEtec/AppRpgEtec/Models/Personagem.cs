using System;
using System.Collections.Generic;
using System.Text;

namespace AppRpgEtec.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClasseEnum Classe { get; set; }
        public Byte[] FotoPersonagem { get; set; }

        public int Disputas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
    }
}
