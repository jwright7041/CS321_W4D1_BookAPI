﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_W4D1_BookAPI.Models;

namespace CS321_W4D1_BookAPI.Services
{
    public interface IPublisherService
    {
        // create
        Publisher Add(Publisher publisher);
        // read
        Publisher Get(int id);
        // update
        Publisher Update(Publisher publisher);
        // delete
        void Remove(Publisher todo);
        // list
        IEnumerable<Publisher> GetAll();
    }
}
