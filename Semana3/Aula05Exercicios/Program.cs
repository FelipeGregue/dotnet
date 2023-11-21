#region Tuples Example
var tuple1 = (10, 20);
Console.WriteLine($"Tuple 1: {tuple1.Item1}, {tuple1.Item2}");
//Tuple 1: 10,20

var tuple2 = (x: 5, y: 50);
Console.WriteLine($"Tuple 2: {tuple2.x}, {tuple2.y}");
//Tuple 2: 5, 50

var tuple3 = (id: 10, name: "Helder", born: new DateTime(1987, 9, 24));
Console.WriteLine($"Tuple 3: {tuple3.id}, {tuple3.name}, {tuple3.born}");
//Tuple 3: 10, Helder, 24/09/1987 00:00:00

List<(int id, string name, DateTime born)> list = new();
list.add(tuple3)
list.add((11, "Nicole", new DataTime(2019, 1, 12)));
list.foreach(x => Console.WriteLine($"Tuple 4: {x.id}, {x.name}, {x.born.ToShortDateString()}"));
//Tuple 4: 10, Helder, 24/09/1987
//Tuple 4: 11, Nicole, 12/01/2019
#endregion

#region Question 1
Console.WriteLine($"{CalcAge("Helder", new DateTime(1987, 9, 24))}");

(string, int) CalcAge(string name, DateTime BirthDate){
    var age = DateTime.Today.Year - BirthDate.Year;
    if(DateTime.Today.Year < BirthDate.DayOfYear)
    age--;

    return (name,age);
}

#endregion