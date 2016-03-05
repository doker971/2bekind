using Dobro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dobro.Domain.Abstract;

namespace Dobro.Domain.Concrete
{
    public class EFDoingRepository : IDoingRepository
    {
        private EFDbContext repository = new EFDbContext();

        public IEnumerable<Doing> Doings
        {
            get { return repository.Doings; } //возвращаем базу
        }
    }
}
