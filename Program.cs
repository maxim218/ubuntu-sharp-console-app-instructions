using System;
using System.Collections;

class Program {
	static void Main(string[] args) {
		int x = 1;
		int y = 2;
		int s = x + y;
		string message = "Summa: " + s + '\n';
		Console.WriteLine(message);
		
		for(int i = 0; i < 10; i++) {
			string msg = "Number: " + i;
			Console.WriteLine(msg);
		}
	}
}
