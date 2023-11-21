#region Lambda
string[] people = {"Greg", "Emilli", "Aurora" };
char letter = 'G';
Console.WriteLine($"People with name started with, '{letter}':{string.Join(", ", people.Where(x => x.StartsWith(letter)))}");
#endregion

#region MultiplosDe3
List<int> list = new() {1, 2, 3, 4, 5};
var squaredList = list.Select(x => x * x);
Console.WriteLine($"Original List: {string.Join(", ", list)}");
Console.WriteLine($"Squared List: {string.Join(", ", squaredList)}");

var summedList = list.Select((x, index) => x + squaredList.ElementAt(index));
Console.WriteLine($"Summed  List: {string.Join(", ", summedList)}");

var listMultipleOfThree = list.Where(x => x % 3 == 0).ToList();
listMultipleOfThree.addrange(squaredList.Where(x => x % 3 == 0).ToList());
listMultipleOfThree.addrange(summedList.)Where(x => x % 3 == 0).ToList());
Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleOfThree)}");
Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleOfThree.Order())}");
#endregion