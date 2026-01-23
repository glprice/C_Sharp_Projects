# Terminology for C#:

**Variable:**   
Variables are used to store and manipulate data. In C#, each variable has a type that determines the values it can store.

**Data Structures:**  
Data structures are formats designed to store larger amounts of information in an organized fashion.

**Array:**
Arrays are a data structure used in C# to store a sequential collection of elements.

**String:**   
Strings are an instance of the System.String object in C# and represents an immutable sequence of Char objects.

**Classes:**   
A blueprint or template for creating objects.

**Loops:**  
loops are a logical structure that allows for the repeated execution of a block of code.


# Array types:
**int**  
int[] numbers = { 1, 2, 3 };

**string**  
string[] words = { "one", "two", "three" };

**double**    
double[] preciseNumbers = { 1, 2.2, 3.3 };


### var:

When working with arrays in C#, the var keyword allows for implicitly typed array initialization, where the compiler determines the array type based on the elements provided in the initializer. 

var numbers = new[] { 1, 10, 100, 1000 };  
Inferred as int[]

var names = new[] { "hello", null, "world" };  
Inferred as string[]

var mixedNumbers = new[] { 1, 2.5, 3.7f };  
Inferred as double[]






