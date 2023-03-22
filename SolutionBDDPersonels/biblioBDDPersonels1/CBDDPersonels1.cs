using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;
namespace biblioBDDPersonels1
{
    public class CBDDPersonels1
    {
        private BddpersonnelDataContext dc=null;

        //pour accéder à la base
        public CBDDPersonels1()
        {
            dc = new BddpersonnelDataContext();
        }
        //tableau de services
        public List<Service> GetAllServices()
        {
            try
            {
                return dc.Services.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
