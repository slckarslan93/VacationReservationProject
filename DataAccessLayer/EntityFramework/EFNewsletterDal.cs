﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFNewsletterDal : GenericRepository<Newsletter>, INewsletterDal
    {
    }
}