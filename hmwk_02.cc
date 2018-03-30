//Amey J Puranik
//axp1390
//03/27/2018

#include <iostream>
#include <fstream>
#include <regex>

using namespace std;

void processToken( string token )
{
regex Intt ("[0][dD][0-9]+");
regex FP("[0-9]+\\.[0-9]+");
regex ID("[_a-mN-Z][n-zA-M_0-9]*");
regex Hexnt("[0][xX][a-fA-F0-9]+");
regex EP ("[0-9][0-9]*[eE+-]+[0-9]+||[0-9]*\\.[0-9]*[eE+-]*[0-9]*");


if (regex_match (token, Intt))
      cout << ">" << token << "< Matches INT.\n";

else if (regex_match (token, FP))
     cout << ">" << token << "< Matches FP.\n";

else if (regex_match (token, ID))
     cout << ">" << token << "< Matches ID.\n";

else if (regex_match (token, Hexnt))
     cout << ">" << token << "< Matches HEXINT.\n";

else if (regex_match (token, EP))
     cout << ">" << token << "< Matches EFP.\n";
else
    cout << ">" << token << "< Does Not Match.\n";

}

int main( int argc, char *argv[] )
{
  if ( argc > 1 ) {
    cout << "processing tokens from " << argv[ 1 ] << " ...\n";

    ifstream inputFile;
    string   token;

    inputFile.open( argv[ 1 ] );

    if ( inputFile.is_open() ) {
      while ( inputFile >> token ) {
        processToken( token );
      }
      inputFile.close();
    } else {
      cout << "unable to open " << argv[ 1 ] << "?\n";
    }
  } else {
    cout << "No input file specified.\n";
  }
}
