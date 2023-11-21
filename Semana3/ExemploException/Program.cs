#region Exceptions Example

try{
    int result = Divide(10,0);
    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex){
    Console.WriteLine("Erro: Cannot divide by zero");
    Console.WriteLine(ex.Message);
}
catch(Exception ex){
    Console.WriteLine("An error occurred");
    Console.WriteLine(ex.Message);
}
finally{
    Console.WriteLine("Finally block executed");
}

int Divide(int a, int b){
    if(b == 0)
    {
        throw new DivideByZeroException("Cannot divide by zero");
    }
    return a / b;
}
#endregion