using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial8._1
{
    class cRobot
    {
        public string sName;

        public int iWeight;

        public byte[] aCoordinates;
    }


    class cRobobot
    {

        private string sName;

        private int iWeight;

        private byte[] aCoordinates;

        public void setValues(string name, int weight, byte[] coordinates)
        {
            sName = name;
            iWeight = weight;
            aCoordinates = coordinates;
        }

        public void printValues()
        {
            Console.WriteLine(sName + "weight: " + iWeight + ".Coordinates: ");
            foreach (byte el in aCoordinates)
            {
                Console.WriteLine(el);

            }


        }











    }
}
