Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(ураааа, выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("такого дня не существует");
  }
  else Console.WriteLine("(этот день рабочий, быстро за работу!) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);