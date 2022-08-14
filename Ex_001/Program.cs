//6. Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray –
// первая добавляет к числовому массиву значение, тем самым увеличивая массив,
// а вторая удаляет элемент под нужным индексом и уменьшает массив на 1.
int[] AddToArray(int[] array, int lenght)
{
    Console.Write("Введите число, которое хотите добавить: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int [] myArray = new int[lenght + 1];
    int index = 0 ; 
    for(int i = 0; i < myArray.Length; i++)
    {
        if(i  == myArray.Length-1)
        {
       
            myArray[i] = number;
        }
        else
        {
            myArray[i] = array[i];
        }
    }
    return myArray;
}
int [] RemoveFromArray(int[] array, int lenght, int index)
{      
    int [] myArray = new int[lenght  - 1];    
    int score = index+ 1;
    for(int i =0,b = 0; i < myArray.Length;i++, b++ )
    {
        if(i == index)
        {
            b = score;
            myArray[i] = array[b];
        }
        else
        {
            myArray[i] = array[b];
        }
    }
    return myArray;
}
void PrintArra(int [] myArr)
{
     Console.Write("Вывести полученный массив: ");
    string decisionPrint = Console.ReadLine();
    if(decisionPrint.ToLower() == "да")
    {
        for(int i = 0; i < myArr.Length; i ++)
            {
                Console.WriteLine(myArr[i]);
            }
    }
    else
    {
        Console.WriteLine("Досвидания))");   
    }
}
//*******************************//
int [] myArray = {5,35,56,45};
int lenght = myArray.Length ;
Console.Write("Введите,что вы хотите сделать: (AddToArray - добавить число в массив. RemoveFromArray - удалить элемент из массива под нужным индексом): ");
string decisionChoice = Console.ReadLine();
if(decisionChoice.ToLower() == "addtoarray")
{
    int [] array = new int[lenght+ 1];
    array = AddToArray(myArray, lenght);
    PrintArra(array);
}
else if(decisionChoice.ToLower() == "removefromarray")
{    
    Console.Write("Введите индекс элемента, который нужно удалить: ");
    int numberIndex = Convert.ToInt32(Console.ReadLine()) ;
    if(numberIndex > lenght - 1 && numberIndex < 0)
    {
        Console.WriteLine("Такого индекса нер в массиве!(")   ;
    }
    else
    {
        int [] array = new int[lenght -1];
        array = RemoveFromArray(myArray,lenght, numberIndex);
        PrintArra(array);
    }   
}
else
{
    Console.WriteLine("Вы ввели неверную команду.");
}



