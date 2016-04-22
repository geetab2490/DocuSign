using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTest
{
    interface BusinessRules
    {
         String checkAllClothesWorn(StringBuilder op, int v);
        String checkShirtBeforeHeadWear(StringBuilder op, int v);
        String checkShirtBeforeJacket(StringBuilder op, int v);
        String checkForShoes(StringBuilder op, int v);
    }
}
