using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XanderUI;

namespace Task._Manangement
{
    internal class Card : XUICard
    {

        public bool starred { get; set; }

        public Card()
        {

          
          this.Color1 = System.Drawing.Color.DodgerBlue;
          this.Color2 = System.Drawing.Color.BlueViolet;
          this.Dock = System.Windows.Forms.DockStyle.Left;
            starred = false;

            


        }
    }
}
