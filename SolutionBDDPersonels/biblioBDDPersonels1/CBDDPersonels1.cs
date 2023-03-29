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

        //constructeur de base pour accéder à la bdd
        public CBDDPersonels1()
        {
            dc = new BddpersonnelDataContext();
        }

        //constructeur pour accéder à la base en gestionnaire(mais pas uniquement)
        public CBDDPersonels1( string UserId, string Password, string Host, string Database)
        {
            
            string connectionString = "User Id="+UserId+";Password="+Password+";Host="+Host+";Database="+Database+";Persist Security Info=True";
            dc = new BddpersonnelDataContext(connectionString);
           
        }

        public  User GetUser()
        {
            try
            {
                
                return dc.Users.FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
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
