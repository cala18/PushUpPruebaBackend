using System;
using System.Threading.Tasks;
using Aplicacion.Repository;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace APP.UnitOfWork
{
    public record UnitOfWork(ClayContext Context) : IUnitOfWork, IDisposable
    {
        private IAddresstype Addresstype;
        private ICity _cities;
        private ICountry _countries;
        private IEmployee _employees;
        private IPerson _persons;
        private IPersonaddress _personAddresses;
        private IPersoncategory _personCategories;
        private IPersoncontact _personContacts;
        private IPersontype _personTypes;
        private ISchedule _schedules;
        private IShift _shifts;
        private IClient _clients;
        private IContacttype _contactTypes;
        private IContract _contracts;
        private IContracttype _contractTypes;
        private AddresstypeRepository _addressTypes;

        public IAddresstype AddressTypes => _addressTypes ??= new AddresstypeRepository(Context);
        public ICity Cities => _cities ??= new CityRepository(Context);
        public ICountry Countries => _countries ??= new CountryRepository(Context);
        public IEmployee Employees => _employees ??= new EmployeeRespository(Context);
        public IPerson Persons => _persons ??= new PersoRepository(Context);
        public IPersonaddress PersonAddresses => _personAddresses ??= new PersonAdressRepository(Context);
        public IPersoncategory PersonCategories => _personCategories ??= new PersonCategoryRepository(Context);
        public IPersoncontact PersonContacts => _personContacts ??= new PersoncontactRepository(Context);
        public IPersontype PersonTypes => _personTypes ??= new PersontypeRepository(Context);
        public ISchedule Schedules => _schedules ??= new ScheduleRepository(Context);
        public IShift Shifts => _shifts ??= new ShiftRepository(Context);
        public IClient Clients => _clients ??= new ClientRepository(Context);
        public IContacttype ContactTypes => _contactTypes ??= new ContacttypeRepository(Context);
        public IContract Contracts => _contracts ??= new ContractRepository(Context);
        public IContracttype ContractTypes => _contractTypes ??= new ContracttypeRepository(Context);

        public void Dispose() => Context.Dispose();

        public async Task<int> SaveAsync() => await Context.SaveChangesAsync();
    }
}
