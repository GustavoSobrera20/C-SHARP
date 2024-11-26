using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loja_roupa
{
    internal class produtoCad
    {
        public produtoCad(string pro)
        { 
            DescPro = pro;
        }
        public string DescPro { get; set; }
        public string  MarcaPro { get; set; }
        public string TamPro { get; set; }
        public string CorPro { get; set; }
        public double ValPro { get; set; }
        public double PesoPro { get; set; }

    }
}
