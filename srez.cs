string someString = " Hello, 2, world, :-) ";
string[] firstStringArray = new string[]{};
firstStringArray = someString.Split(',');
firstStringArray = someString.Split(' ');
string[] secondStringArray =  new string[firstStringArray.Length] ;
int count = 0;
