using System;
using System.Collections;
 
class STACKEx {
 

    static public void Main()
    {
 
        Stack my_stack = new Stack();
 
        my_stack.Push(11);
        my_stack.Push(8);
        my_stack.Push(6);
        my_stack.Push(5);
        my_stack.Push(12);
        my_stack.Push(7);

	my_stack.pop();
 
        foreach(var elem in my_stack)
        {
		Console.WriteLine(elem);
        }
    }
}
