using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Налоговая.Models;
using System.Security.Principal;

namespace Налоговая
{
    public static class MyIdentity
    {
        private static НалоговаяEntities db = new НалоговаяEntities();

        public static string FullName(this IIdentity identity)
        {
            string FullName = db.users.Where(u => u.login == identity.Name).Select(u => u.surname + " " + u.name + " " + u.patronymic).FirstOrDefault();
            return FullName;
        }
    }
}