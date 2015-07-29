# Lesson 1
### First of lets talk about the [Boolean](https://msdn.microsoft.com/en-us/library/system.boolean.aspx).

[System.Boolean](https://msdn.microsoft.com/en-us/library/system.boolean.aspx) is a struct type in C# it can have the value true or false more information can be found [here](https://msdn.microsoft.com/en-us/library/system.boolean.aspx)

It is usally abreaviated as [bool](https://msdn.microsoft.com/en-us/library/c8f5xwh7.aspx) which is just a sort cut to System.Boolean type

The keyworks [true](https://msdn.microsoft.com/en-us/library/06d3w013.aspx) and [false](https://msdn.microsoft.com/en-us/library/vstudio/x4bbw9d7(v=vs.100).aspx) are the only accepted value to the boolean class.

The reason this is important is because the if statement uses bool to determain if the code block should be executed.

In the code block below True will be outputed to the screen because the when the if condition is check it will be true so the code block should be executed.

<code lang="csharp">
if(true)
{
	Console.WriteLine("True");
}
</code>

In the code block below False will not be outputed to the screen because when the if condition is check it will be false which means it should not execute the code block.

<code lang="csharp">
if(false)
{
	Console.WriteLine("False");
}
</code>

Now for Exercise one 
