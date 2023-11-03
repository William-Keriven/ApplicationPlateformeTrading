using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPlateformeTrading.Modele
{
    public class trader
    {
        #region Attributs
        private List<action> _listeInteret = new List<action>();

        public static List<trader> CollClasse = new List<trader>();

        //private int _id;//
        private string _nom;
        private string _prenom;
        private DateTime _dateDeNaissance;
        private string _sexe;
        private string _email;
        private int _numeroTelephone;
        
        
        
        #endregion

        #region Constructeurs

        public trader( string nom, string prenom ,DateTime dateDeNaissance, string sexe, string email, int numeroTelephone)
        {
            _nom = nom;
            _prenom = prenom;
            _dateDeNaissance = dateDeNaissance;
            _sexe = sexe;
            _email = email;
            _numeroTelephone = numeroTelephone;

            CollClasse.Add(this);

        }


        #endregion

        #region Getters/Setters
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public DateTime DateDeNaissance { get => _dateDeNaissance; set => _dateDeNaissance = value; }
        public string Sexe { get => _sexe; set => _sexe = value; }
        public string Email { get => _email; set => _email = value; }
        public int NumeroTelephone { get => _numeroTelephone; set => _numeroTelephone = value; }



        #endregion

        #region Methodes
        public void AjouterActionsInteret(action monAction)
        {
            if (_listeInteret.Contains(monAction))
            {
                return;
            }

            else
            {
                _listeInteret.Add(monAction);


            }
        }

        public void RetirActionInteret(action monAction)
        {
            if (_listeInteret.Contains(monAction))
            { 
                _listeInteret.Remove(monAction);
            }
        }


        public bool ListerTradersAdressses(action monAction)
        {
            if (_listeInteret.Contains(monAction)
                return true else return false;
        }







        #endregion
    }
}
