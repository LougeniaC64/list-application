using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListApplication
{
    public class ListItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public override string ToString()
        {
            return nameof(this.Name);//$"{this.Name}";
        }
    }
}
