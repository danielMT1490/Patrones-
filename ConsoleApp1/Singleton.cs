using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Estas dos interface son incompatibles dentro de la misma clase ya que comparten metodos con el mismo nombre
    public interface IEjemplo
    {
        int Suma();
        int Resta();
    }
    public interface Iejemplo2
    {
        int Suma(int x);
        int Resta(int y);

    }
    public class Calculo : Iejemplo2
    {
        
        public int Resta(int x)
        {
            throw new NotImplementedException();
        }

        public int Suma(int y)
        {
            throw new NotImplementedException();
        }
    }
    public class Adapter : IEjemplo 
    {
        Iejemplo2 iejemplo2;
        int x;
        public Adapter()
        {
            iejemplo2 = new Calculo();
        }
        public int Resta()
        {
            return iejemplo2.Resta(x);
        }

        public int Suma()
        {
            return iejemplo2.Resta(x);
        }
    }
}
