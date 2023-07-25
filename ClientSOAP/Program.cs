using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSOAP.Banguat;

namespace ClientSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Banguat.TipoCambio client = new TipoCambio();
            var result = client.TipoCambioDia();
            foreach (var item in result.CambioDolar)
            {
                Console.WriteLine(item.referencia);
            }
            Console.WriteLine(result.CambioDolar.First().fecha);
            Console.WriteLine(result.CambioDolar.First().referencia);
        }
    }
}
