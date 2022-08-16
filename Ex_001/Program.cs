//6. Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray –
// первая добавляет к числовому массиву значение, тем самым увеличивая массив,
// а вторая удаляет элемент под нужным индексом и уменьшает массив на 1.

/***Corrections***/
// Задача 6:
// 1. AddToArray - смешение ответственностей. Она и число запрашивает, и добавляет значение - Completed
// 2. AddToArray - зачем нужен index = 0? - провлывал мимо,случайно заплыл
// 3. AddToArray - лишние проверки. Можно просто пройтись по длине изначального массива, а после цикла занести новое значение в конец. - Competed
// 4. if(numberIndex > lenght - 1 && numberIndex < 0) - неверное условие, проверка не проходит - Completed
// 5. PrintArra - y потерялась. Тоже смешивание ответственности. Метод должен печатать и все.  - Completed
// Вот захотим мы с консоли на wpf переехать. Придется идти все твои методы править. -  Completed
// 6. score - плохое название - Completed
// 7. AddToArray - зачем методу lenght в параметрах? С RemoveFromArray тот же вопрос Completed
// 8. RemoveFromArray - почему бы при достижении нужного индекса просто не прибавлять к i единицу? Аж 2 лишние переменные уберешь

int[] AddToArray(int[] array, int numbertoAdd)
{
    int [] myArray = new int[array.Length + 1];
    for(int i = 0; i < array.Length; i++)
    {
        myArray[i] = array[i];
    }
    myArray[myArray.Length-1] = numbertoAdd ;
    return myArray;
}
int [] RemoveFromArray(int[] array, int index)
{      
    int [] myArray = new int[array.Length  - 1];
    for(int i = 0, b = 0; i < myArray.Length; i++, b ++)
    {
        Console.WriteLine( i );
        if(i==index)
        {    
            b++; 
        }
        myArray[i]=array[b];
        
    }
    return myArray;
}
void PrintArray(int [] myArr)
{
    for(int i = 0; i < myArr.Length; i ++)
        {
            Console.WriteLine(myArr[i]);
        }   
}
void DecisionforPrint(int[] array)
{
    Console.Write("Вывести полученный массив: ");
    string decisionPrint = Console.ReadLine();
    if(decisionPrint.ToLower() == "да")
    {
        PrintArray(array);
    }
    else
    {
        Console.WriteLine("Досвидания))");   
    }
}
//*******************************//
int [] myArray = {5,35,56,45};
Console.Write("Введите,что вы хотите сделать: (AddToArray - добавить число в массив. RemoveFromArray - удалить элемент из массива под нужным индексом): ");
string decisionChoice = Console.ReadLine();
if(decisionChoice.ToLower() == "addtoarray")
{
    Console.Write("Введите число, которое хотите добавить: ");
    int numberAdd = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[myArray.Length+ 1];
    array = AddToArray(myArray,numberAdd);
    DecisionforPrint(array); 
}
else if(decisionChoice.ToLower() == "removefromarray")
{    
    Console.Write("Введите индекс элемента, который нужно удалить: ");
    int numberIndex = Convert.ToInt32(Console.ReadLine()) ;
    if(( numberIndex > (myArray.Length - 1)) || (numberIndex < 0 ) )
    {
        Console.WriteLine("Такого индекса нет в массиве!(")   ;
    }
    else
    {
        int [] array = new int[myArray.Length -1];
        array = RemoveFromArray(myArray, numberIndex);
        DecisionforPrint(array); 
    }   
}
else
{
    Console.WriteLine("Вы ввели неверную команду.");
}


