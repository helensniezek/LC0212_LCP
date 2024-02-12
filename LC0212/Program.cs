// SMIS 3013 001
// Feb 12, 2024
// Helen Sniezek
// 113552793

// write loop// collect grades and calculate average grade

int n;
n = 0;
double sumGrades;
sumGrades = 0;

while(true)// infinite loop
{
    Console.Write("Another grade? (yes/no) ");
    string userChoiceStr;
    userChoiceStr = Console.ReadLine();

    if(userChoiceStr == "no")
    {
        break;// stop this loop; go to the next line of this loop
    }

    Console.Write("Input a grade: ");
    string gradeStr;
    gradeStr = Console.ReadLine();// grade string

    double grade;
    grade=Convert.ToDouble(gradeStr);

    n = n + 1;
    sumGrades=sumGrades + grade;

}
// we get the total number of grades
// sum of the grades
double aveGrade;
aveGrade = sumGrades / n;
string mesStr;
mesStr = string.Format($"The number of grades: {n}");
Console.WriteLine(mesStr);

mesStr = string.Format($"The average grade is: {aveGrade:F2}");
Console.WriteLine(mesStr);



