using System;
using System.IO;

namespace PoolPuzzle
{
    public class Program
    {
        public static void Main()
        {
            Kangaroo joey = new Kangaroo();
            //int koala = joey.Wombat(joey.Wombat(joey.Wombat(1)));
            int koala = 0;

            try
            {
                Console.WriteLine((15 / koala) + " eggs per pound");
            }

            /* This catch block only
            catches exceptions where
            the code divides by zero. */
            catch (DivideByZeroException)
            {
                Console.WriteLine("G’Day Mate!");
            }

            finally
            {
                Console.ReadLine();
            }
        }

        class Kangaroo
        {
            /* it has
            an OpenRead() method and
            throws an IOException. */
            FileStream fs;
            int croc;
            int dingo = 0;
            public int Wombat(int wallaby)
            {
                dingo++;
                try
                {
                    /* This code opens a file called “wobbiegong”
                    and keeps it open the first time it’s
                    called. Later on, it opens the file again.
                    But it never closed the file, which causes
                    it to throw an IOException. */
                    if (wallaby > 0)
                    {
                        fs = File.OpenWrite("wobbiegong");
                        croc = 0;
                    }
                    else if (wallaby < 0)
                        croc = 3;
                    else
                    {
                        fs = File.OpenRead("wobbiegong");
                        croc = 1;
                    }
                }

                /* If not close the file, the file will be
                locked open, and if you try to open it
                again it’ll throw an IOException. */
                catch (IOException)
                {
                    croc = -3;
                }

                /* avoid catch all exceptions in code */
                catch
                {
                    croc = 4;
                }
                finally
                {
                    if (dingo > 2)
                    {
                        croc -= dingo;
                    }
                }
                return croc;
            }
        }
    }
}