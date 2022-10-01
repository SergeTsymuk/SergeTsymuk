
int[,] matrix = new int[3,3]
{
    {1,2,3},{4,5,6},{7,8,9},
};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]);
        if (j != matrix.GetLength(1) -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

int l, c;

Console.Write(matrix[0,0]+", ");

for (int i = 1; i < matrix.GetLength(0); i++)
{
     if (i % 2 == 0)
     {
        l = i; c = 0;
        while (l > -1)
        {
            Console.Write(matrix[l, c]+", ");
            l--; c++;
        }
     }
     else
     {
        c = i; l  = 0;
        while (c > -1)
        {
            Console.Write(matrix[l, c]+ ", ");
            l++; c--;
        }
     }
}
int l2 = 1;
int c2 = matrix.GetLength(1) -1;

int length = matrix.GetLength(0)-1;
    
for (int j = 1; j < matrix.GetLength(1); j++)
{
    if (length % 2 == 0)
    {
        while (l2 < matrix.GetLength(1))
        {
            Console.Write(matrix[l2, c2] + ", ");
            l2++; c2--;
        }
    }
    length ++;
    if (length % 2 != 0)
    {
        c2 = matrix.GetLength(1) ;
        while (l2 < matrix.GetLength(1))
        {
            Console.Write(matrix[l2, c2] + ", ");
            l2--; c2++;
        }
    }
}
