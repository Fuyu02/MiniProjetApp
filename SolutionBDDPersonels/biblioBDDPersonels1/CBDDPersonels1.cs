using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BddpersonnelContext;
using Devart.Common;

namespace biblioBDDPersonels1

{
    public class CBDDPersonels1
    {
        private BddpersonnelDataContext dc=null;

        //pour accéder à la base de façon normal(simple utilisateur)
        public CBDDPersonels1()
        {
            dc = new BddpersonnelDataContext();
        }

        //constructeur pour accéder à la base en gestionnaire
        public CBDDPersonels1( string UserId, string Password, string Host, string Database)
        {
            //string connectionString = "User Id=userBDDW;Password=Password1234@il;Host=172.16.32.235;Database=bddpersonnels;Persist Security Info=True";
            string connectionString = "User Id="+UserId+";Password="+Password+";Host="+Host+";Database="+Database+";Persist Security Info=True";
            //  SqlConnection connection = new SqlConnection(connectionString); //mot clé host non pris en charge
            dc = new BddpersonnelDataContext(connectionString);
           
        }



        //tableau de services à revoir
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


        //tableau des fonctions

        public List<Fonction> GetAllFonctions()
        {
            try
            {
                return dc.Fonctions.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //tableau du personnels
        public List<Personnel> GetAllPersonnels()
        {
            try
            {
                return dc.Personnels.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }



    
}
