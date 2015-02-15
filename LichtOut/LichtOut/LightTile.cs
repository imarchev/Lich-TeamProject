using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LichtOut
{
    class LightTile : Button
    {
        //TODO: make a button
        //list of neightbours
        //onclick event

        public List<LightTile> Neighbours { get; set; }
    }
}
