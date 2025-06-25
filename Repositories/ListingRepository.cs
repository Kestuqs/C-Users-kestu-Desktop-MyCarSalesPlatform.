using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCarSalesPlatform.Core.Models;
using MyCarSalesPlatform.Core.Interfaces;
using MyCarSalesPlatform.Infrastructure.Data;

namespace MyCarSalesPlatform.Infrastructure.Repositories
{
    public class ListingRepository : IListingRepository
    {
        private readonly AppDbContext _context;

        public ListingRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Listing> GetAll() => _context.Listings.ToList();
        public Listing GetById(int id) => _context.Listings.Find(id);

        public void Add(Listing listing) => _context.Listings.Add(listing);
        public void Update(Listing listing) => _context.Listings.Update(listing);
        public void Delete(int id)
        {
            var listing = _context.Listings.Find(id);
            if (listing != null)
            {
                _context.Listings.Remove(listing);
            }
        }
        public void Save() => _context.SaveChanges();
    }   
}
