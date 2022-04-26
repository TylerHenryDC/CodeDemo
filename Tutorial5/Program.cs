//Name: Tyler Henry
//Date: March 13, 2022
//Title Tutorial 5
//Description: Calcualtes volume of boxes in a list and then sorts then using overload operators
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list of boxes and object variable
            var boxes = new List<Box>();
            var box = new Box(1,1,1);

           //add to list of boxes
            boxes.Add(new Box(10, 23, 54));
            boxes.Add(new Box(10, 2, 54));
            boxes.Add(new Box(10, 23, 4));
            boxes.Add(new Box(10, 3, 54));
            boxes.Add(new Box(1, 23, 54));
            boxes.Add(new Box(1, 23, 5));
            boxes.Add(new Box(10, 3, 54));
            boxes.Add(new Box(10, 23, 54));
            boxes.Add(new Box(10, 23, 59));
            boxes.Add(new Box(1, 1, 4));

            //Sort and output list
            boxes.Sort(sort);
            Console.WriteLine(box.toString(boxes));        
        }
        /// <summary>
        /// Sorts given list by volume
        /// </summary>
        /// <param name="boxes"></param>
        /// <returns></returns>
        static int sort (Box box1, Box box2)
        {
            if (box1==box2)
            {
                return 0;
            }
            else if (box1>=box2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        } 
    }
}