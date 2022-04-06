using Algorithms;

//Lesson 1: SolveMeFirst
int output_1 = SolveMeFirst.Run(3, 5); //output: 8

//Lesson 2: SimpleArraySum
int output_2 = SimpleArraySum.Run(new() { 1, 2, 3, 4, 10, 11 }); //output: 31

//Lesson 3: CompareTheTriplets
List<int> output_3 = CompareTheTriplets.Run(new() { 5, 6, 7 }, new() { 3, 6, 10 }); //output: 1 1
Console.WriteLine(String.Join(" ", output_3));

//Lesson 8: BirthdayCakeCandles
int output_8 = BirthdayCakeCandles.Run(new() { 3, 2, 1, 3 }); //output: 2

//Lesson 9: TimeConversion
string output_9 = TimeConversion.Run("07:05:45PM"); //output: 19:05:45

