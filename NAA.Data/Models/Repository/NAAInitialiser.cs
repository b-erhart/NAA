using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Data.Models.Domain;

namespace NAA.Data.Models.Repository
{
    public class NAAInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<NAAContext>
    {
        protected override void Seed(NAAContext context)
        {
            University university = new University
            {
                Name = "Sheffield"
            };
            University university2 = new University
            {
                Name = "Sheffield Hallam"
            };

            context.Universities.Add(university);
            context.Universities.Add(university2);


            context.SaveChanges();
        }
    }
}
