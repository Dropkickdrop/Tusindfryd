using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tusindfryd.Repos;

namespace Tusindfryd
{
    internal class Controller
    {
        private FlowersortRepo sortRepo;
        private ProductiontrayRepo trayRepo;

        public Controller(FlowersortRepo sortRepo, ProductiontrayRepo trayRepo)
        {
            this.sortRepo = sortRepo;
            this.trayRepo = trayRepo;
        }   

        public void AddToList(Flowersort flowersort) { }

        public void AddToList(Productiontray tray) { }
    }
}