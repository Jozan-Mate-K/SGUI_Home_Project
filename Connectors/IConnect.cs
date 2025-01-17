﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connectors
{
    public interface IConnect<T> where T : class
    { 
        T Get(int ID);
        List<T> GetAll();
        void Put(T item);
        void Post(T item);
        void Delete(int ID);
    }
}
