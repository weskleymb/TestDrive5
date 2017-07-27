using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive5.Models
{
    public class Veiculo
    {

        public const decimal FREIO_ABS = 700;
        public const decimal AR_CONDICIONADO = 1500;
        public const decimal MP3_PLAYER = 400;

        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }
        public bool TemFreioAbs { get; set; }
        public bool TemArCondicionado { get; set; }
        public bool TemMp3Player { get; set; }

        public string PrecoTotalFormatado
        {
            get
            {
                return string.Format("Valor Total: R$ {0}",
                    Preco
                    + (TemFreioAbs ? FREIO_ABS : 0)
                    + (TemArCondicionado ? AR_CONDICIONADO : 0)
                    + (TemMp3Player ? MP3_PLAYER : 0)
                    );
            }
        }
    }
}
