using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
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

        // pour récupérer le login et mdp utilisateur gestionnaire dans la bdd et pour pouvoir le vérifier quand on le tape dans la fenêtre de connexion
        //fait en link, et pas avec select
        public  bool isUserAdmin(string user, string mdp)
        {
            try
            {

              List<User> listeUtilisateurs = dc.Users.ToList();
              if( listeUtilisateurs.Where(x => x.Password == mdp).Count()>0 && listeUtilisateurs.Where(x => x.Login == user).Count() >0)
                return true;
                return false;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Fonction Getfonction(int _IdFonction)
        {
            Fonction fonction = new Fonction();
            fonction.Id = _IdFonction;
            return fonction;
        }

        public Service Getservice(int _IdService) {
            Service service = new Service();
            service.Id = _IdService;
            return service;
        }

        //ajouter fonction (METTRE EXPLICATION CODE)
        public void Ajoutfonction(Fonction fonction)
        {
            try
            {
                dc.Fonctions.InsertOnSubmit(fonction);
                dc.SubmitChanges();
            }
            catch (Exception ex) { 
                throw ex; 
            };
        }

        //modifier une fonction (METTRE EXPLICATION CODE)
        public void ModifFonction(Fonction fonction)
        {
            dc.Connection.Open();
            using (System.Data.Common.DbTransaction transaction = dc.Connection.BeginTransaction())
            try
            {
                    int fn = fonction.Id;
                    Fonction fonction2 = dc.Fonctions.Single(x => x.Id == fn);
                    dc.SubmitChanges();
                    dc.Fonctions.InsertOnSubmit(fonction);
                    dc.Fonctions.DeleteOnSubmit(fonction2);
                    dc.SubmitChanges();
                    transaction.Commit();
                }
            catch(Exception ex) {
                    transaction.Rollback();
                    throw ex;
            }
        }

        //supprimer une fonction (METTRE EXPLICATION CODE)
        public void SuppFonction(int id)
        {
            try
            {

                Fonction fonction2 = dc.Fonctions.Single(x => x.Id == id);
                dc.Fonctions.DeleteOnSubmit(fonction2);
                dc.SubmitChanges();
            }
            catch (Exception ex) { 
                throw ex; 
            };
        }


        //ajouter service(METTRE EXPLICATION CODE)
        public void Ajoutservice(Service service)
        {
            try
            {
                dc.Services.InsertOnSubmit(service);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }

        //Modifier Service(METTRE EXPLICATION CODE)
        public void Modifservice(Service service)
        {
            dc.Connection.Open();
            using (System.Data.Common.DbTransaction transaction = dc.Connection.BeginTransaction())
            try
            {
                    int ser = service.Id;
                    Service service2 = dc.Services.Single(x => x.Id == ser);
                    dc.SubmitChanges();
                    dc.Services.InsertOnSubmit(service);
                    dc.Services.DeleteOnSubmit(service2);
                    dc.SubmitChanges();
                 transaction.Commit();
             }

            catch (Exception ex)
            {
                    transaction.Rollback();
                    throw ex;
            }
        }

        //supprimer Service(METTRE EXPLICATION CODE)

        public void SuppService(int ser)
        {
            try
            {
                Service service2= dc.Services.Single(x => x.Id == ser);
                dc.Services.DeleteOnSubmit(service2);
                dc.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
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



   
