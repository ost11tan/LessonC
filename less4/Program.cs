string[,] table = new string[2,5];
//индексы идут с 0 
//String.Empty
table[1,2]="слово";


//for (int rows = 0; rows < 2; rows++)
//{
//   for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows,columns]}-");
//    }
//}

void FillArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
         matrix[i,j]= new Random().Next(1,11);
       } 
    }
}


int [,] matrix = new int [3,4];

void PrintArray(int[,] matrix)
{

    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows,columns]}");
        }
        Console.WriteLine();
    }
}


PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);