using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class Grid
    {
        public List<List<object>> Warzone;

        public Grid () {
            Warzone = new List<List<object>> ();
            List<object> row1 = new List<object> ();
            List<object> row2 = new List<object> ();
            List<object> row3 = new List<object> ();
            List<object> row4 = new List<object> ();
            List<object> row5 = new List<object> ();
            List<object> row6 = new List<object> ();
            List<object> row7 = new List<object> ();
            List<object> row8 = new List<object> ();
            List<object> row9 = new List<object> ();
            List<object> row10 = new List<object> ();
            List<object> row11 = new List<object> ();
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        row1.Add(" ");
                    }
                    if (i == 0 && j > 0)
                    {
                        row1.Add(j);
                    }
                    else if (i == 1)
                    {
                        if (i == 1 && j == 0)
                        {
                            row2.Add("A");
                        } 
                        else
                        {
                            row2.Add("A" + j);
                        }
                    }
                    else if (i == 2)
                    {
                        if (i == 2 && j == 0)
                        {
                            row3.Add("B");
                        } else
                        {
                            row3.Add("B" + j);
                        }
                    }
                    else if (i == 3)
                    {
                        if (i == 3 && j == 0)
                        {
                            row4.Add("C");
                        } else
                        {
                            row4.Add("C" + j);
                        }
                    }
                    else if (i == 4)
                    {
                        if (i == 4 && j == 0)
                        {
                            row5.Add("D");
                        } else
                        {
                            row5.Add("D" + j);
                        }
                    }
                    else if (i == 5)
                    {
                        if (i == 5 && j == 0)
                        {
                            row6.Add("E");
                        } else
                        {
                            row6.Add("E" + j);
                        }
                    }
                    else if (i == 6)
                    {
                        if (i == 6 && j == 0)
                        {
                            row7.Add("F");
                        } else
                        {
                            row7.Add("F" + j);
                        }
                    }
                    else if (i == 7)
                    {
                        if (i == 7 && j == 0)
                        {
                            row8.Add("G");
                        } else
                        {
                            row8.Add("G" + j);
                        }
                    }
                    else if (i == 8)
                    {
                        if (i == 8 && j == 0)
                        {
                            row9.Add("H");
                        } else
                        {
                            row9.Add("H" + j);
                        }
                    }
                    else if (i == 9)
                    {
                        if (i == 9 && j == 0)
                        {
                            row10.Add("I");
                        } else
                        {
                            row10.Add("I" + j);
                        }
                    }
                    else if (i == 10)
                    {
                        if (i == 10 && j == 0)
                        {
                            row11.Add("J");
                        } else
                        {
                            row11.Add("J" + j);
                        }
                    }
                }
            }
        this.Warzone.Add(row1);
        this.Warzone.Add(row2);
        this.Warzone.Add(row3);
        this.Warzone.Add(row4);
        this.Warzone.Add(row5);
        this.Warzone.Add(row6);
        this.Warzone.Add(row7);
        this.Warzone.Add(row8);
        this.Warzone.Add(row9);
        this.Warzone.Add(row10);
        this.Warzone.Add(row11);
        }
    }
}