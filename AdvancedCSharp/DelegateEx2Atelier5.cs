using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp
{
    //ajouter delegate qui va pointer sur une méthode ayant la même signature
    public delegate int BinaryOp(int x, int y);
    class DelegateEx2Atelier5
    {
        //Contient les mêthodes sur lesquelles delegate va ppointer.
        public static int Addition(int x, int y)
        {
            return x + y;
        }
        public static int Soustraction(int x, int y)
        {
            return x - y;
        }
    }
}
