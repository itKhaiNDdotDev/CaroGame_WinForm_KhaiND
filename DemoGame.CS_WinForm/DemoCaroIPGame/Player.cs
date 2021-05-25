using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCaroIPGame
{
    public class Player
    {

        #region properties

        private string name;
        public string Name { get => name; set => name = value; }

        private Image caro;
        public Image Caro { get => caro; set => caro = value; }

        #endregion



        #region initializes

        public Player(string name, Image caro)
        {
            this.Name = name;
            this.Caro = caro;
        }

        #endregion



        #region mothods

        #endregion


    }
}
