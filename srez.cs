string someString = " Hello, 2, world, :-) ";
string[] firstStringArray = new string[]{};
firstStringArray = someString.Split(',');
firstStringArray = someString.Split(' ');
string[] secondStringArray =  new string[firstStringArray.Length] ;
int count = 0;
PrintArrayOne(firstStringArray);

for (int i = 0; i < firstStringArray.Length; i++) 
{
if(firstStringArray[i].Length <=3)

secondStringArray[count] = firstStringArray[i];
count++;
Console.Write(secondStringArray[i] + " ");
}
void PrintArrayOne(string[] firstStringArray)
{
for (int i = 0; i < firstStringArray.Length; i++)
{
Console.Write(firstStringArray[i] + " ");
}
}
