int[] array = {1, 0, 6, 0, 43, 21, 67, 76};

int n = array.Length;
int find = 0;

int index = 0;
while (index < n)
{ 
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1
    index ++;

}