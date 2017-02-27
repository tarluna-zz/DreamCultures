using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamCultures
{
    public class Dreaming
    {
        int userID = 0;
        int quarter = 0;
        DatabaseLayerDataContext context = new DatabaseLayerDataContext();
        
        public List<Dream> GetDreamsByUser()
        {
            return context.Dreams.Where(c => c.UserID == userID).ToList();
        }
    }
}