using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session1Api.Base
{
    public class AppData
    {
        private static KazanNeftSession1DBEntities context;
        public static KazanNeftSession1DBEntities GetContext()
        {
            if (context == null)
                context = new KazanNeftSession1DBEntities();
            return context;
        }
    }
}