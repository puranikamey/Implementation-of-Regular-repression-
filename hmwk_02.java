//Name:Amey Puranik
//Netid - axp1390
//Date : 03/27/2018

import java.nio.file.Paths;
import java.nio.file.Files;
import java.util.Arrays;

public class hmwk_02{
public static void processToken( String token ) {
   String inttoken= "^[0][dD][0-9]+$";
   String Flotingpoint= "^[0-9]+\\.[0-9]+$";
   String ID= "^[_a-mN-Z][n-zA-M_0-9]*$";
   String EFP= "^[0-9][0-9]*[eE+-]+[0-9]+$||^[0-9]*\\.[0-9]*[eE+-]*[0-9]*$";
   String HX= "^[0][xX][a-fA-F0-9]+$";
   
   if (token.matches(inttoken)) {
	   
	   System.out.println( ">" + token + "< Matches INT." );
	   
                                 }
   
   else if (token.matches(Flotingpoint)) {
	   
	   System.out.println( ">" + token + "< Matches FP." );
	   
                                 }
   
   else if (token.matches(ID)) {
	   
	   System.out.println( ">" + token + "< Matches ID." );
	   
                                 }
   
   else if (token.matches(HX)) {
	   
	   System.out.println( ">" + token + "< Matches HEXINT." );
	   
                                 }
   else if (token.matches(EFP)) {
	   
	   System.out.println( ">" + token + "< Matches EFP." );
	   
                                 }
   else {

          System.out.println( ">" + token + "< does not match." );
      }	

 
}

public static void main( String[] args ) {
 System.out.println( "processing tokens from " + args[ 0 ] + " ..." );

 try {
   Files.lines( Paths.get( args[ 0 ] ) ).forEachOrdered(
     line -> Arrays.stream( line.split( "\\s+" )  )
         .forEachOrdered( token -> processToken( token ) ) );
 } catch ( java.io.IOException e ) {
   e.printStackTrace();
 }
}
}