using Algorithms;

//Chapter 1: Solve Me First
int output_1 = SolveMeFirst.Run(3, 5); //output: 8

//Chapter 2: Simple Array Sum
int output_2 = SimpleArraySum.Run(new() { 1, 2, 3, 4, 10, 11 }); //output: 31

//Chapter 3: Compare The Triplets
List<int> output_3 = CompareTheTriplets.Run(new() { 5, 6, 7 }, new() { 3, 6, 10 }); //output: 1 1
Console.WriteLine(String.Join(" ", output_3));

//Chapter 4: A Very Big Sum
long output_4 = AVeryBigSum.Run(new() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }); //output: 5000000015

//Chapter 5: Diagonal Difference
List<List<int>> input_5 = new();
input_5.Add(new List<int> { 11, 2, 4 });
input_5.Add(new List<int> { 4, 5, 6 });
input_5.Add(new List<int> { 10, 8, -12 });
int output_5 = DiagonalDifference.Run(input_5); //output: 15

//Chapter 6: Plus Minus
PlusMinus.Run(new() { -4, 3, -9, 0, 4, 1 }); //output: 0,5 0,33.. 0,16..

//Chapter 7: Mini-Max Sum
MiniMaxSum.Run(new() { 1, 2, 3, 4, 5 }); //output: 10 14

//Chapter 8: Birthday Cake Candles
int output_8 = BirthdayCakeCandles.Run(new() { 3, 2, 1, 3 }); //output: 2

//Chapter 9: Time Conversion
string output_9 = TimeConversion.Run("07:05:45PM"); //output: 19:05:45

//Chapter 10: Grading Students
List<int> output_10 = GradingStudents.Run(new() { 73, 67, 38, 33 }); //output: 75 67 40 33
output_10.ForEach((item => Console.WriteLine(item)));

//Chapter 11: Apple and Orange
AppleAndOrange.Run(7, 11, 5, 15, new() { -2, 2, 1 }, new() { 5, -6 });

//Chapter 12: Number Line Jumps
string output_12 = NumberLineJumps.Run(0, 2, 5, 3); //output: "NO"

//Chapter 13: Between Two Sets

//Chapter 14: Breaking the Records
List<int> output_14 = BreakingTheRecords.Run(new() { 10, 5, 20, 20, 4, 5, 2, 25, 1 }); //output: 2 4
Console.WriteLine(String.Join(" ", output_14));

//Chapter 15: Subarray Division
int output_15 = SubarrayDivision.Run(new() { 1, 2, 1, 3, 2 }, 3, 2); //output: 2
Console.WriteLine(output_15);

//Chapter 16: Divisible Sum Pairs
int output_16 = DivisibleSumPairs.Run(6, 3, new() { 1, 3, 2, 6, 1, 2 }); //output: 5

//Chapter 17: Migratory Birds
int output_17 = MigratoryBirds.Run(new() { 1, 4, 4, 4, 5, 3 }); //output: 4




