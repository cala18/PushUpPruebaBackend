using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ContacttypeDto : BaseDto
    {
        public int ID { get; set; }

        public string Description { get; set; }


    }
}