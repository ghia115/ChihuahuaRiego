using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficaRiegoManzanaMaiz.Grafica
{
    public class GraficaRiego
    {

        public string GraficaDinamica(string valor)
        {

            string html = string.Format("<html><body><h1>{0}</h1></body></html>", valor);

            return html;
        }


    }
}
