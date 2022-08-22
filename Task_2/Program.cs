// Написать программу масштабирования фигуры

void print (int [] A)
{
    int l = A.Length;
    int i = 0;
    while (i < l)
    {
        Console.Write (A [i] + " ");
        i++;
    }
}
void fill (int [] A)
{
    int l = A.Length;
    int i = 0;
    while (i < l)
    {
        A [i] = new Random().Next(-10, 11);
        i++; 
    }
}
void obnl (int [] A)
{
    int l = A.Length;
    int i = 0;
    Console.WriteLine ("Введите коэффициент масштабирования фигуры k: ");
    int k = int.Parse (Console.ReadLine ());
    while (i < l)
    {
        A [i] = A [i] * k;
        i++; 
    }
}
int [] array = new int [8];
fill (array);
print (array);
Console.WriteLine (); 

obnl (array);
print (array);
