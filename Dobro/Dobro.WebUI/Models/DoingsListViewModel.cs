using Dobro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dobro.WebUI.Models
{
    public class DoingsListViewModel
    {
        public IEnumerable<Doing> Doings { get; set; }
    }
}