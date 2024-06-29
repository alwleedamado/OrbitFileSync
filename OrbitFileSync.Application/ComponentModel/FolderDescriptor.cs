using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitFileSync.Application.ComponentModel
{
    public class FolderDescriptor : AbstractDescriptor
    {
        public List<FileDescriptor> Files { get; set; } = new();
        public decimal Size => Files.Sum(f => f.Size);
    }
}
