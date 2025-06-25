using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MyCarSalesPlatform.Core.Models;

namespace MyCarSalesPlatform.Core.Interfaces
{
    public interface IListingRepository
    {
        IEnumerable<Listing> GetAll();
        Listing GetById(int id);
        void Add(Listing listing);
        void Update(Listing listing);
        void Delete(int id);
        void Save();
    }
}
