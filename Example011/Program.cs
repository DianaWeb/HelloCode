void FillArray(int[] collection)
{
	int lenght = collection.Length;
	int index = 0;
	while (index < lenght)
	{
		collection[index] = new Random().Next(1, 10);
		index++;
	}
}
void PrintArray(int[] col)
{
	int count = col.Length;
	int posishion = 0;
	while (posishion < count)
	{
		System.Console.WriteLine(col[posishion]);
		posishion++;
	}
}
int IndexOf(int[] collection, int find)
{
	int count = collection.Length;
	int index = 0;
	int posishion = -1;
	while (index < count)
	{
		if (collection[index] == find)
		{
			posishion = index;
			break;
		}
		index++;
	}
	return posishion;
}

int[] array = new int[10];

FillArray(array);
array[3] = 4;
array[6] = 4;

PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 44);
System.Console.WriteLine(pos);