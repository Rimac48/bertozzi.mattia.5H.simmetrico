using System;
using System.Collections.Generic;
using System.Linq;

public static class Simmetrico
{
    public static bool Verifica( int[] valori ) 
    {
        for(int i=0;i<valori.Length;i++)
        {
            if(valori[i]==valori[valori.Length-1-i])
            {
                return true;
            }
        }
        return false;
    }
}