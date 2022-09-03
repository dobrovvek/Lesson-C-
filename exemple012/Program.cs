//Методы которые ничего не возвращают и ничего не принимают
/* void Method1(){
    Console.WriteLine("Avtor ....");
}
Method1();

// Принимают но не возврфщают

void Method2(string msg){
    Console.WriteLine(msg);
}
Method2("text"); 

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count){
    Console.WriteLine(msg);
    i++;
    }
}
Method21(msg: "text", count: 4); // можно не именовать Method21("text", 4); 


// Метожы что то возвращают но не принимают

int Method3(){
    return DateTime.Now.Year;
}
int year = Method3();

Console.WriteLine(year); 

//что то принимают и что то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;    
}

string res = Method4(10,"z");
Console.WriteLine(res); 

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;    
}
string res = Method4(10,"z");
Console.WriteLine(res); 
 

    for(int i = 2; i <= 10; i++)
    {
        for(int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i*j}");
        }
        Console.WriteLine();
    } 

    // задача 1 

    string text = "- Я думаю, - сказал князь улыбаясь - что, "
                    +"ежели бы вас послали вместо нашего милого";

// string s = "qwerty" 

    string Replace(string text, char oldValue, char newValue)
    {
        string result = String.Empty;

        int length = text.Length;
        for (int i = 0; i < length; i++)
        {
            if(text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}";
        }
        return result;
    }
string newText = Replace( text, ' ', '|' );
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace( text, 'к', '9' );
Console.WriteLine(newText); */



void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++ )
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++ )
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
