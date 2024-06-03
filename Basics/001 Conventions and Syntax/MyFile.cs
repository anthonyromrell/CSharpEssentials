namespace MyApplication;

public class MyFile
{
    int number = 10;
    float decimalNumber = 2.5f;
    string userName = "Phil";
    string sentence = "Hello World";
    void MyFunction()
    {
        var otherNumber = 5;
        if (number > otherNumber)
        {
            Console.WriteLine("Number is greater than otherNumber");
            console.WriteLine(number + otherNumber = 15);
        }
        else if (number == otherNumber)
        {
            Console.WriteLine("Number is equal to otherNumber");
        }
        else
        {
            Console.WriteLine("Number is less than otherNumber");
            MyFunction();
        }
        
        switch (userName)
        {
            case "Phil":
                Console.WriteLine("Hello Phil");
                break;
            case "Bob":
                Console.WriteLine("Hello Bob");
                break;
            case "Mary":
                Console.WriteLine("Hello Bob");
                break;
            default:
                Console.WriteLine("Hello" + userName);
                break;
        }
    }
}