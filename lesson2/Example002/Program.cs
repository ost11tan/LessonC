int [] array={67,15,62,55,218,7,9};
int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
   if (array[index]== find)
   {
    Console.WriteLine(index);
   } 
   index++;
}