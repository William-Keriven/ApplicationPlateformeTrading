using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPlateformeTrading.Modele
{
    public class coursAction
    {
        #region Attributs

        private static List<coursAction> CollClasse = new List<coursAction>();

        private int _id;
        private DateTime _date;
        private double _prix;
        private action _action;


        #endregion

        #region Constructeurs

        public coursAction(int id, DateTime date, double prix, action action)
        {
            _id = id;
            _date = date;
            _prix = prix;
            _action = action;

            CollClasse.Add(this);
        }


        #endregion

        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public double Prix { get => _prix; set => _prix = value; }
        public action Action { get => _action; set => _action = value; }



        #endregion

        #region Methodes



        #endregion
    }
}
