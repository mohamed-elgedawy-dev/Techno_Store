using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store.Interfaces
{
    internal interface Iinfo
    {
        public int? TakingId(Data data);

        public void TakingAmount();

        public string TakingName();


        public bool AskToContinueOrFinish();







    }
}
