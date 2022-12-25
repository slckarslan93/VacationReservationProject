﻿using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);

        void Delete(T t);

        void Udpate(T t);

        List<T> GetList();
    }
}