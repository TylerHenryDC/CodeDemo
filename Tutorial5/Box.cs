//Name: Tyler Henry
//Date: March 13, 2022
//Title Tutorial 5
//Description: Calcualtes volume of boxes in a list and then sorts then using overload operators
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemo
{
    class Box
    {
        //Variable declarations
        private double length { get; set; }
        private double width { get; set; }
        private double height { get; set; }

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="m_length"></param>
        /// <param name="m_width"></param>
        /// <param name="m_height"></param>
        public Box(double m_length, double m_width, double m_height)
        {
            this.length = m_length;
            this.width = m_width;
            this.height = m_height;
        }

        /// <summary>
        /// Calculates volume of object
        /// </summary>
        /// <returns></returns>
        public double getVolume()
        {
            return (length * width * height);
        }

        /// <summary>
        /// Overloads >= to use get volume
        /// </summary>
        /// <param name="volA"></param>
        /// <param name="volB"></param>
        /// <returns></returns>
        public static bool operator >=(Box volA, Box volB)
        {
            return volA.getVolume() >= volB.getVolume();
        }
        /// <summary>
        /// Overloads <= to use get volume
        /// </summary>
        /// <param name="volA"></param>
        /// <param name="volB"></param>
        /// <returns></returns>
        public static bool operator <=(Box volA, Box volB)
        {
            return volA.getVolume() <= volB.getVolume();
        }

        /// <summary>
        /// Overloads == to use get volume
        /// </summary>
        /// <param name="volA"></param>
        /// <param name="volB"></param>
        /// <returns></returns>
        public static bool operator ==(Box volA, Box volB)
        {
            return volA.getVolume() == volB.getVolume();
        }

        /// <summary>
        /// Overloads != to use get volume
        /// </summary>
        /// <param name="volA"></param>
        /// <param name="volB"></param>
        /// <returns></returns>
        public static bool operator !=(Box volA, Box volB)
        {
            return volA.getVolume() != volB.getVolume();
        }

        /// <summary>
        /// output box volumes
        /// </summary>
        /// <param name="boxes"></param>
        /// <returns></returns>
        public string toString(IEnumerable<Box> boxes)
        {
            //Output each object in given list and return string
            string outputString = "";
            foreach (Box box in boxes)
            {
                outputString += box.getVolume();
                outputString += ("\n");

            }
            return outputString;
        }
    }
}
