using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverLaba4
{
    public class TovarOperationImpl : MarshalByRefObject, TovarOperation
    {
        public static List<Tovar> lstTovar = new List<Tovar>();
        public List<Tovar> getListOfTovar()
        {
            return lstTovar;
        }
        public List<Tovar> addNewTovar(Tovar item)
        {
            lstTovar.Add(item);
            return lstTovar;
        }
        public List<Tovar> delTovar(int index)
        {
            lstTovar.RemoveAt(index);
            return lstTovar;
        }
        public int getSumOfTovar()
        {
            int sum = 0;
            foreach (Tovar tovar in lstTovar)
                sum += tovar.getSumma();
            return sum;
        }
    }
}
