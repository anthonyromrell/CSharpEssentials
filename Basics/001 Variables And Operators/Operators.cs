//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Operations");
		myOperator.DoMath(2, 10);
		myOperator.DoMath(60, 23);
		myOperator.DoMath(-3, 15);
	}
	public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	}
}