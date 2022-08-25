int a1=12 ;
int b1=85;
int c1=54;
int a2=55;
int b2=89;
int c2=644;
int a3=571;
int b3=382;
int c3=12;



int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


//Вариант 1 
//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1,max2,max3);




//Вариант2
//int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

//Вариант 3
int[] array= {29,35,14,1,25,18,963,44,7};
int max = Max(Max(array[0],array[1],array[2]),
            Max(array[3],array[4],array[5]),
            Max(array[6],array[7],array[8]));


Console.WriteLine ( max );