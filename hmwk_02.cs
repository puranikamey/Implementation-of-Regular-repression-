// Amey Jayant Puranik
// 1001451390
// 2018-02-28

using System;
using System.IO;
using System.Text.RegularExpressions;

public class hmwk_02
{
  static public void processToken( string token ) {
   
       Regex intger = new Regex(@"^[0][dD][0-9]+$");
       Regex ID = new Regex(@"^[_a-mN-Z][n-zA-M_0-9.]*$");
       Regex deci = new Regex(@"^[0-9]+\.[0-9]+$");
       Regex Hexnt = new Regex(@"^[0][xX][a-fA-F0-9]+$");
       Regex EFP = new Regex(@"^((^[0-9][0-9]*[eE]+[-+]+[0-9]+$)||(^[0-9]*\.[0-9]*[eE]*[+-]*[0-9]*$))$");
      if (intger.IsMatch(token))
 { 
   Console.WriteLine( ">" + token + "< Matches Integer." );
          
 }

    else if (ID.IsMatch(token))
  { 
   Console.WriteLine( ">" + token + "< Matches ID." );
          
 }
   else if (deci.IsMatch(token))
  { 
   Console.WriteLine( ">" + token + "< Matches FP." );
          
 } 
 else if (EFP.IsMatch(token))
  { 
   Console.WriteLine( ">" + token + "< Matches EFP." );
          
   }  
 else if (Hexnt.IsMatch(token))
  { 
   Console.WriteLine( ">" + token + "< Matches HEXINT." );
          
  } 
   
   else
      { 
   Console.WriteLine( ">" + token + "< Does not Match." );
          
      }  
      
    
  }

  static public void Main( string[] args )
  {
    Console.WriteLine( "processing tokens from " + args[ 0 ] + " ..." );

    foreach ( string line in File.ReadAllLines( args[ 0 ] ) ) {
      foreach ( string token in line.Split( (char []) null, StringSplitOptions.RemoveEmptyEntries ) ) {
        processToken( token );
      }
    }
  }
}
