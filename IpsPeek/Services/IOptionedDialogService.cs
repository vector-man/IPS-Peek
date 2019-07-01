using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpsPeek.Services
{
    public interface IOptionedDialogService<in T>
    {
        bool ShowDialog(T options);
    }
}
