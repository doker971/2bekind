using Dobro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobro.Domain.Abstract
{
    public interface IDoingRepository
    {
        IEnumerable<Doing> Doings { get; }
    }
}
