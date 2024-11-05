using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GarageDoorApplication
{
    public class GarageDoor
    {
        public static void Main(string[] args)
        {
           
                string events = "..P...O.....";
                Console.WriteLine(DoorStatus(events));
                Console.ReadLine();

            }
            public static string DoorStatus(string events)
            {
                int doorPosition = 0;
                bool moving = false;
                int direction = 1;
                StringBuilder output = new StringBuilder();
                foreach (char eventChar in events)
                {
                    if (eventChar == 'P')
                    {
                        if (moving)
                        {
                            moving = false;
                        }
                        else
                        {
                            moving = true;
                        }
                    }
                    else if (eventChar == 'O')
                    {
                        direction *= -1;
                        moving = true;
                    }

                    if (moving)
                    {
                        doorPosition += direction;
                        if (doorPosition >= 5)
                        {
                            doorPosition = 5;
                            direction = -1;
                        }
                        else if (doorPosition <= 0)
                        {
                            doorPosition = 0;
                            direction = -1;
                    }
                }

                    output.Append(doorPosition);

                }

                return output.ToString();
            }
        }
    }






