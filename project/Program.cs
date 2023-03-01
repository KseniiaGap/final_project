// ["hello", "2", "world",":;-)"]-> ["2", " :-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ("Russia", "Denmark", "Kazan" -> []

int lengthResultArray = 0;
string[] array = {"hello", "2", "world",":-)"};
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
       lengthResultArray ++;
    }
}
string[] resultArray = new string[lengthResultArray];
int index = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultArray[index] = array[i];
        index ++;
    }
}
foreach (var item in resultArray)
{
    Console.WriteLine($" {item}");
}