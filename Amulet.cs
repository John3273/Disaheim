using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Amulet
    {
        public string ItemId;
        public string Design;
        public Level Quality {  get; set; }
        
        public Amulet(string itemId, Level quality,string design)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }
        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId;
            Quality = quality;
        }
        public Amulet(string itemId)
        {
            ItemId = itemId;
            Quality = Level.Medium;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
