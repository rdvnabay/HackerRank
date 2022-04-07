﻿using Algorithms;

//Lesson 1: Solve Me First
int output_1 = SolveMeFirst.Run(3, 5); //output: 8

//Lesson 2: Simple Array Sum
int output_2 = SimpleArraySum.Run(new() { 1, 2, 3, 4, 10, 11 }); //output: 31

//Lesson 3: Compare The Triplets
List<int> output_3 = CompareTheTriplets.Run(new() { 5, 6, 7 }, new() { 3, 6, 10 }); //output: 1 1
Console.WriteLine(String.Join(" ", output_3));

//Lesson 4: A Very Big Sum
long output_4 = AVeryBigSum.Run(new() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }); //output: 5000000015

//Lesson 5: Diagonal Difference
List<List<int>> input_5 = new();
input_5.Add(new List<int> { 11, 2, 4 });
input_5.Add(new List<int> { 4, 5, 6 });
input_5.Add(new List<int> { 10, 8, -12 });
int output_5 = DiagonalDifference.Run(input_5); //output: 15

//Lesson 6: Plus Minus
PlusMinus.Run(new() { -4, 3, -9, 0, 4, 1 }); //output: 0,5 0,33.. 0,16..

//Lesson 7: Mini-Max Sum
MiniMaxSum.Run(new() { 1, 2, 3, 4, 5 }); //output: 10 14

//Lesson 8: Birthday Cake Candles
int output_8 = BirthdayCakeCandles.Run(new() { 3, 2, 1, 3 }); //output: 2

//Lesson 9: Time Conversion
string output_9 = TimeConversion.Run("07:05:45PM"); //output: 19:05:45

//Lesson 10: Grading Students
List<int> output_10 = GradingStudents.Run(new() { 73, 67, 38, 33 });
output_10.ForEach((item => Console.WriteLine(item)));

//Lesson 11: Apple and Orange

//Lesson 12: Number Line Jumps
string output_12 = NumberLineJumps.Run(0, 2, 5, 3); //output: "NO"



