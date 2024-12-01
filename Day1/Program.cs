using Day1;

string input = File.ReadAllText(@"C:\Users\cisci\OneDrive\Dokument\Repos\AdventOfCode2024\Day1\Input.txt");
string[] inputSplit = input.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

//Part1 part1 = new Part1();
//int totalDist = part1.GetIds(inputSplit);
//Console.WriteLine(totalDist);

Part2 part2 = new Part2();
int similarityScore = part2.CalculateSimilarityScore(inputSplit);
Console.WriteLine(similarityScore);