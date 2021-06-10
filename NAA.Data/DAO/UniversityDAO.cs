﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.IDAO;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;

namespace NAA.Data.DAO
{
    public class UniversityDAO : IUniversityDAO
    {
        public IList<University> GetUniversities(NAAContext context)
        {
            return context.Universities.ToList();
        }

        public University GetUniversity(NAAContext context, int id)
        {
            return context.Universities.Find(id);
        }
    }
}