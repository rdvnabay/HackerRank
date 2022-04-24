using Warmup;


//Chapter 1: Solve Me First
int output_1 = SolveMeFirst.Run(3, 5); //output: 8

//Chapter 2: Simple Array Sum
int output_2 = SimpleArraySum.Run(new() { 1, 2, 3, 4, 10, 11 }); //output: 31

//Chapter 3: Compare The Triplets
List<int> output_3 = CompareTheTriplets.Run(new() { 5, 6, 7 }, new() { 3, 6, 10 }); //output: 1 1

//Chapter 4: A Very Big Sum
long output_4 = AVeryBigSum.Run(new() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }); //output: 5000000015

//Chapter 5: Diagonal Difference
int output_5 = DiagonalDifference.Run(new List<List<int>> { new() { 11, 2, 4 },
                                                            new() { 4, 5, 6 }, 
                                                            new() { 10, 8, -12 } }); //output: 15

//Chapter 6: Plus Minus
PlusMinus.Run(new() { -4, 3, -9, 0, 4, 1 }); //output: 0,5 0,33.. 0,16..

//Chapter 7: Mini-Max Sum
MiniMaxSum.Run(new() { 1, 2, 3, 4, 5 }); //output: 10 14

//Chapter 8: Birthday Cake Candles
int output_8 = BirthdayCakeCandles.Run(new() { 3, 2, 1, 3 }); //output: 2

//Chapter 9: Time Conversion
string output_9 = TimeConversion.Run("07:05:45PM"); //output: 19:05:45