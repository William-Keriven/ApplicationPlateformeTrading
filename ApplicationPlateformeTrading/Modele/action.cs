using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPlateformeTrading.Modele
{
    public class action
    {

        #region Attributs

        public static List<action> CollClasse = new List<action>();

        private string _codeIsin;
        private string _nom;
        private double _prixInitial;

        #endregion

        #region Constructeurs

        public action(string codeIsin, string nom, double prixInitial)
        {
            _codeIsin = codeIsin;
            _nom = nom;
            _prixInitial = prixInitial;

            CollClasse.Add(this);
        }



        #endregion

        #region Getters/Setters
        public string CodeIsin { get => _codeIsin; set => _codeIsin = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public double PrixInitial { get => _prixInitial; set => _prixInitial = value; }

        #endregion

        #region Methodes

        #endregion
    }

}
