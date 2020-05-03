using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverLaba4
{
    public interface TovarOperation
    {
        List<Tovar> getListOfTovar();
        List<Tovar> addNewTovar(Tovar item);
        List<Tovar> delTovar(int index);
        int getSumOfTovar();
    }
}
