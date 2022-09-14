using labs_assignment;

string ConcatenateMethod(string wordArg, int numArg)
{
    List<string> resultList = new List<string>();

    for (int i = 0; i < numArg; i++)
    {
        resultList.Add(wordArg);
    }

    string result = string.Join("", resultList);

    return result;
}

string ShortenMethod(string wordArg, int numArg)
{
    int lengthOfWord = wordArg.Length;

    int finalLengthOfWord = lengthOfWord - numArg;

    return wordArg.Substring(0, finalLengthOfWord);
}

MyDelegate concatenateDelegate = ConcatenateMethod;
MyDelegate shortenDelegate = ShortenMethod;

Console.WriteLine(concatenateDelegate("Hi", 5));
Console.WriteLine(shortenDelegate("Umbrella", 5));

//RandomDelegate ourBox = ConcatenateMethod;
//RandomDelegate ourBox2 = ShortenMethod;

//Console.WriteLine(DelegateSample.RandomFunction("Umbrella", 2, ourBox));
//Console.WriteLine(DelegateSample.RandomFunction("Umbrella", 2, ourBox2));


LinkedList myStringList = new LinkedList();

myStringList.Add("hello");

myStringList.Add("hi");

myStringList.Add("yes!");

myStringList.PrintNodes();

LinkedList myIntegerList = new LinkedList();

myIntegerList.Add(1);

myIntegerList.Add(2);

myIntegerList.Add(3);

myIntegerList.PrintNodes();

Console.WriteLine("abc");


































delegate string MyDelegate(string wordArg, int numArg);
