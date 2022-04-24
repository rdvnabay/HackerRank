using Implementation;


//Chapter 10: Grading Students
List<int> output_10 = GradingStudents.Run(new() { 73, 67, 38, 33 }); //output: 75 67 40 33
output_10.ForEach((item => Console.WriteLine(item)));

//Chapter 11: Apple and Orange
AppleAndOrange.Run(7, 11, 5, 15, new() { -2, 2, 1 }, new() { 5, -6 }); //output: 1 1

//Chapter 12: Number Line Jumps
string output_12 = NumberLineJumps.Run(0, 2, 5, 3); //output: "NO"

//Chapter 13: Between Two Sets
int output_13 = BetweenTwoSets.Run(new() { 2, 4 }, new() { 16, 32, 96 }); //output: 3

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

//Chapter 18: Day of the Programmer

//Chapter 19: Bill Division
BillDivision.Run(new() { 3, 10, 2, 9 }, 1, 12); //output: 5

//Chapter 20: Sales by Match
int output_20 = SalesByMatch.Run(9, new() { 10, 20, 20, 10, 10, 30, 50, 10, 20 }); //output: 3

//Chapter 21: Drawing Book 
int output_21 = DrawingBook.Run(6, 2); //output: 1

//Chapter 22: Counting Valleys
int output_22 = CountingValleys.Run(8, "UDDDUDUU"); //output: 1

//Chapter 23: Electronics Shop
int output_23 = ElectronicsShop.Run(new[] { 3, 1 }, new[] { 5, 2, 8 }, 10); //output: 9

//Chapter 24: Cats and a Mouse
string output_24 = CatsAndAMouse.Run(1, 2, 3); //output: "Cat B"

//Chapter 25: Forming a Magic Square
int output_25 = FormingAMagicSquare.Run(new List<List<int>>
{
    new (){4, 8, 2},
    new (){4, 5, 7},
    new (){6, 1, 6}
}); //output: 4

//Chapter 26: Picking Numbers
int output_26 = PickingNumbers.Run(new() { 4, 6, 5, 3, 3, 1 }); //output: 3

//Chapter 27: Climbing the Leaderboard
List<int> output_27 = ClimbingTheLeaderboard.Run(new() { 100, 100, 50, 40, 40, 20, 10 }, new() { 5, 25, 50, 120 });

//Chapter 28: The Hurdle Race
int output_28 = TheHurdleRace.Run(4, new() { 1, 6, 3, 5, 2 }); //output: 2

//Chapter 29: Designer PDF Viewer
int ouput_29 = DesignerPDFViewer.Run(new() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, "abc"); //output: 9

//Chaper 30: Utopian Tree
int output_30 = UtopianTree.Run(4);

//Chapter 31: Angry Professor
string output_31 = AngryProfessor.Run(3, new() { -1, -3, 4, 2 }); //output: "NO"

//Chapter 32: Beautiful Days at the Movies
int output_32 = BeautifulDaysAtTheMovies.Run(20, 23, 6); //output: 2

//Chapter 33: Viral Advertising
int output_33 = ViralAdvertising.Run(3); //output: 9

//Chapter 34: Save the Prisoner
int output_34 = SaveThePrisoner.Run(5, 2, 1); //output: 2

//Chapter 35: Circular Array Rotation
//List<int> output_35 = CircularArrayRotation.Run(new() { 3, 4, 5, 6 }, 2, new() { 1, 2 });

//Chaper 36: Sequence Equation
List<int> output_36 = SequenceEquation.Run(new() { 5, 2, 1, 3, 4 }); //output [4,2,5,1,3]
Console.WriteLine(String.Join(" ", output_36));

//Chapter 37: Jumping on the Clouds: Revisited 
//int output_37 = JumpingOnTheCloudsRevisited.Run(new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 }, 3); //bug

//Chapter 38: Find Digits
int output_38 = FindDigits.Run(1012); //output: 3

//Chaper 39: Extra Long Factorials
ExtraLongFactorials.Run(25); //output: 15511210043330985984000000

//Chapter 40: Append and Delete
string output_40 = AppendAndDelete.Run("zzzzz", "zzzzzzz", 4); //output: Yes

//Chapter 41: Sherlock and Squares
int output_41 = SherlockAndSquares.Run(3, 9); //output: 2

//Chapter 42: Library Fine
int output_42 = LibraryFine.Run(9, 6, 2015, 6, 6, 2015); //output:45

//Chapter 43: Cut the sticks
List<int> output_43 = CutTheSticks.Run(new() { 5, 4, 4, 2, 2, 8 }); //output: [6,4,2,1]

//Chapter 44: Non-Divisible Subset
//int output_44 = NonDivisibleSubset.Run(3, new() { 1, 7, 2, 4 }); //output: 3
int output_44 = NonDivisibleSubset.Run(7, new() { 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 });

//Chapter 45: Repeated String
long output_45 = RepeatedString.Run("aba", 10); //output: 7

//Chapter 46: Jumping on the Clouds
int output_46 = JumpingOnTheClouds.Run(new() { 0, 0, 0, 1, 0, 0 }); //output: 3

//Chapter 47: Equalize the Array
int output_47 = EqualizeTheArray.Run(new() { 3, 3, 2, 1, 3 }); //output: 2

//Chapter 48: ACM ICPC Team
List<int> output_48 = ACM_ICPCTeam.Run(new() { "10101", "11100", "11010", "00101" }); //output: 5 2
Console.WriteLine($"output_48 {String.Join(" ", output_48)}");

//Chapter 49: Taum and B'day
long output_49 = TaumAndBday.Run(3, 5, 3, 4, 1);

//Chapter 50: Organizing Containers of Balls
string output_50 = OrganizingContainersOfBalls.Run(new List<List<int>> { new() { 0, 2, 1 }, new() { 1, 1, 1 }, new() { 2, 0, 0 } });

//Chapter 51: Encryption
string output_51 = Encryption.Run("haveaniceday");




