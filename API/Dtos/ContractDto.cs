using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ContractDto : BaseDto
    {
    public int ID { get; set; }

    public int? ClientId { get; set; }
    }
}