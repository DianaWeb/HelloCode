// Вид 1 - нет входящих аргументов и ничего не возвращает
void Method1()
{
	System.Console.WriteLine("Автор ...");
}
// Method1();

// Вид 2 - есть входящие аргументы. Ничего не возвращает
void Method2(string msg, int count)
{
	int i = 0;
	while (i < count)
	{
		System.Console.WriteLine("Text");
		i++;
	}
}
//Method2("Текст сообщения.", 4);
//Method2(count: 4, msg: "Текст сообщения.");  //именованные аргументы

// Вид 3 - Что то возвращают, но ничего не принимают 
int Method3()
{
	return DateTime.Now.Year;
}
// int year = Method3();
// System.Console.WriteLine(year);

// Вид 3 - что то принимают и что то возвращают
/* string Method4(int count, string text)
{
	int i = 0;
	string result = String.Empty;
	while (i < count)
	{
		result = result + text;
		i++;
	}
	return result;
} */
string Method4(int count, string text)
{
	string result = String.Empty;
	for (int i = 0; i < count; i++)
	{
		result = result + text;
	}
	return result;
}
//string res = Method4(10, "asdf");
//System.Console.WriteLine(res);

/* for (int i = 0; i <= 10; i++)
{
	for (int j = 0; j <= 10; j++)
	{
		System.Console.WriteLine($"{i} * {j} = {i * j}");
	}
	System.Console.WriteLine();
} */

//Дан текст. Нужно пробелы заменить на черточки, к на К, С на с
string text = "ккккТаким образом реализация намеченных плановых заданий позволяет оценить ССССзначение новых предложений. "
+ "Повседневная практика показывает, "
+ "что укрепление и развитие структуры обеспечивает широкому кругу (специалистов) участие в формировании дальнейших направлений развития.";
// string s ="qwerty"
//            012345
// s[3] -> r
string Replace(string text, char oldValue, char newValue)
{
	string result = String.Empty;
	int lenght = text.Length;
	for (int i = 0; i < lenght; i++)
	{
		if (text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}
	return result;
}
/* string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();

newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);
System.Console.WriteLine(); */

int[] arr = { 1, 6, 8, 2, 2, 7, 3, 5, 7 };

void PrintArray(int[] array)
{
	int count = array.Length;
	for (int i = 0; i < count; i++)
	{
		System.Console.Write($"{array[i]} ");
	}
}
void SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; i++)
	{
		int minPosition = i;
		for (int j = i + 1; j < array.Length; j++)
		{
			if (array[j] < array[minPosition]) minPosition = j;
		}
		int temp = array[i];
		array[i] = array[minPosition];
		array[minPosition] = temp;
	}
}
PrintArray(arr);
System.Console.WriteLine();

SelectionSort(arr);
PrintArray(arr);

