using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoeda
{
    class ConversorDeMoeda
    {   // Porcentagem de IOF
        public static double Iof = 6.0/100.0;
        // Método "VlrTotal" lembrando que as variaveis vlrD e qtdD 
        //serão incrementadas na chamada do método na classe principal.
        public static double VlrTotal(double vlrD,double qtdD)
        {
            double resultado = vlrD * qtdD;
            return resultado + resultado * Iof;
        }
    }
}
