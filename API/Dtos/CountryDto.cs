using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class CountryDto : BaseDto
    {
        public int Id { get; set; }
        public int Name { get; set; }
        
    }
}