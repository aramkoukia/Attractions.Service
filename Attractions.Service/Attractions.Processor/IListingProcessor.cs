﻿using Attractions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attractions.Processor
{
    public interface IListingProcessor
    {
        Task<IEnumerable<Listing>> GetAllListingsAsync();

        Task<Listing> GetListingByIdAsync(int id);

        Task InsertListingAsync(Listing listing);

        Task UpdateListingAsync(Listing listing);

        Task DeleteListingAsync(int id);
    }
}