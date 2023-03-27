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
        public CBDDPersonels1( User ID, string Password, string Host, string Database)//connexion en gestionnaire
        {
            string connectionString = "User ID=userBDDW; Password=Password1234@il;  Database=bddpersonnels";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            dc = new BddpersonnelDataContext(connection);
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
