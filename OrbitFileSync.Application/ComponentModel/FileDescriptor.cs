using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitFileSync.Application.ComponentModel
{
    public class FileDescriptor : AbstractDescriptor
    {
        public decimal Size { get; set; }
        public string Extension { get; set; }
        public DateTime AccessedOn { get; set; }
    }
}
