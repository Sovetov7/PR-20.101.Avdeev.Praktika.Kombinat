using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktika.Avdeev.Pages;
using Praktika.Avdeev.Entities;

namespace Praktika.Avdeev.Entities
{
    internal class Helper
    {
        private static PrEntities entities;
        public static PrEntities getContext()
        {
            if (entities == null)
            {
                entities = new PrEntities();
            }
            return entities;
        }
        public static void Create(User user)
        {
            entities.User.Add(user);
            entities.SaveChanges();
        }
    }
}
