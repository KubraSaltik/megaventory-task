using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Dto
{
    public class InventoryLocationDto
    {
        public string APIKEY { get; set; }
        public MvInventoryLocation mvInventoryLocation { get; set; }
        public string mvRecordAction { get; set; }
        
    }
    public class MvInventoryLocation
    {
        public string InventoryLocationAbbreviation { get; set; }
        public string InventoryLocationName { get; set; }
        public string InventoryLocationAddress { get; set; }
    }
}
