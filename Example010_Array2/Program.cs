int[] array = { 1, 12, 81, 4, 5, 61, 7, 81 };
int n = array.Length;
int find = 81;
int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		System.Console.WriteLine(index);
		break;
	}
	index++;
}
