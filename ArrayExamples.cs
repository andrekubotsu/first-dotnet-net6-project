// Unidimensional Array

int[] a = new int[10];
for (int i = 0; i < a.Length; i++)
{
    a[i] = i * i;
}
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine($"a[{i}] = {a[i]}");
}

// Multi - Matrix

int[,] a2 = new int[10, 5]; // two dimensions
int[,,] a3 = new int[10, 5, 2]; //three dimension

// initializator
int[] b = new int[] { 1, 2, 3 };
int[] c = { 1, 2, 3 };