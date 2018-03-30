# Amey Jayant Puranik
# axp1390
# 03-28-2018
#--------------------------------------------------
import re
import sys

#--------------------------------------------------
def processToken( token ) :
  global integ
  global fp
  global ID
  global Hexnt
  global EFP
  integ ='false'
  pattern=re.compile("^[0][dD][0-9]+$")
  integ=pattern.match(token)
  fp='false'
  pattern=re.compile("^[0-9]+\\.[0-9]+$")
  fp=pattern.match(token)
  ID='false'
  pattern=re.compile("^[_a-mN-Z][n-zA-M_0-9]*$")
  ID=pattern.match(token)
  Hexnt='false'
  pattern=re.compile("^[0][xX][a-fA-F0-9]+$")
  Hexnt=pattern.match(token)
  EFP='false'
  pattern=re.compile("^[0-9][0-9]*[eE+-]+[0-9]+$|^[0-9]*\\.[0-9]*[eE+-]*[0-9]*$")
  EFP=pattern.match(token)
  if integ:
    print( '>%s< Matches INT' % ( token ) )
  elif fp: 
    print( '>%s< Matches FP' % ( token ) )
  elif ID: 
    print( '>%s< Matches ID ' % ( token ) )
  elif Hexnt: 
    print( '>%s< Matches HEXINT ' % ( token ) )
  elif EFP: 
    print( '>%s< Matches EFP ' % ( token ) )
  else :
    print( '>%s< Does not match ' % ( token ) )
#--------------------------------------------------
def main() :
  fName = sys.argv[ 1 ]
  print( 'processing tokens from ' + fName + ' ...' )

  with open( fName, 'r' ) as fp :
    lines = fp.read().replace( '\r', '' ).split( '\n' )

  for line in lines :
    for token in line.split() :
      processToken( token )

#--------------------------------------------------
if ( __name__ == '__main__' ) :
  main()

#--------------------------------------------------
