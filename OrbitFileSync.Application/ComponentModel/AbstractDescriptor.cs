using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitFileSync.Application.ComponentModel
{
    public class AbstractDescriptor
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
