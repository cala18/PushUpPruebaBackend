using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IUnitOfWork
    {
        IAddresstype AddressTypes { get; }
        ICity Cities { get; }
        IClient Clients { get; }
        IContacttype ContactTypes { get; }
        IContract Contracts { get; }
        IContracttype ContractTypes { get; }
        ICountry Countries { get; }
        IEmployee Employees { get; }
        IPerson Persons { get; }
        IPersonaddress PersonAddresses { get; }
        IPersoncategory PersonCategories { get; }
        IPersoncontact PersonContacts { get; }
        IPersontype PersonTypes { get; }
        ISchedule Schedules { get; }
        IShift Shifts { get; }
        Task<int> SaveAsync();
    }
}