using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dobro.Domain.Entities
{
    public class Doing
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Имя, пожалуйста")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Описание, пожалуйста")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Метро, пожалуйста")]
        public string Metro { get; set; }

        [Required(ErrorMessage = "Время, пожалуйста")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "Время на выполнение, пожалуйста")]
        public DateTime FinishTime { get; set; }

    }
}
