using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPlateformeTrading.Modele
{
    public class transaction
    {


        #region Attributs

        public List<transaction> Collclasse = new List<transaction>();

        private int _id;
        private DateTime _date;
        private int _quantite;
        //private string _type;//


        #endregion

        #region Constructeurs

        private transaction(int id, DateTime date, int quantite)
        {

            _id = id;
            _date = date;
            _quantite = quantite;



            Collclasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int ID { get => _id; set => _id = value; }

        public DateTime Date { get => _date; set => _date = value; }

        public int Quantite { get => _quantite; set => _quantite = value; }




        #endregion

        #region Methodes



        #endregion
    }
}
