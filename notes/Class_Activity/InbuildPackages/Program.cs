/*| ---------------------------- | ------------------------------------ |
| `System`                     | Core classes (Console, String, Math) |
| `System.IO`                  | File handling                        |
| `System.Data`                | Database operations                  |
| `System.Linq`                | LINQ queries                         |
| `System.Collections.Generic` | List, Dictionary                     |
*/

using System;
using System.IO;

class Test
{
    static void Main()
    {
        File.WriteAllText("data.txt", "Hello C#");
        Console.WriteLine("File Created");
    }
}