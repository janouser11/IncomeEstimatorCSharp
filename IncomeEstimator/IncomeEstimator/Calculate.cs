namespace IncomeEstimator

{
  
    internal class Calculate
    {

        public int hourlyWage, weeklyHours, wageForWeek, wageForMonth;
        int wageForYear = 0;
        public int[] arrayOfWages = new int[3];

        public Calculate()
        {
        }

        public Calculate(int wage, int hours)
        {
             hourlyWage = wage;
             weeklyHours = hours;

             arrayOfWages[0] = calculatePayForYear(hourlyWage, weeklyHours);
             arrayOfWages[1] = calculatePayForMonth(hourlyWage, weeklyHours);
             arrayOfWages[2] = calculatePayForWeek(hourlyWage, weeklyHours);
        }



        public int calculatePayForYear(int wage, int hours)
        {
            if (hours > 40)
            {
                int difference = hours - 40;
                int overTime = (((wage / 2) + wage)) * difference;
                this.wageForYear = ((wage * 40 * 52) + overTime * 52);
            }
            else
            {
                this.wageForYear = wage * hours * 52;
            }

            return wageForYear;
        }

        public int calculatePayForMonth(int wage, int hours)
        {
            if (hours > 40)
            {
                int difference = hours - 40;
                int overTime = (((wage / 2) + wage)) * difference;
                this.wageForMonth = ((wage * 40 * 4) + overTime *4);
            } else
            {
                this.wageForMonth = wage * hours * 4;
            }

            return wageForMonth;
        }


        public int calculatePayForWeek(int wage, int hours)
        {
            if (hours > 40)
            {
                int difference = hours - 40;
                int overTime = (((wage / 2) + wage)) * difference;
                this.wageForWeek = ((wage * 40) + overTime);
            } else
            {
                this.wageForWeek = wage * hours;
            }    

            return wageForWeek;
        }
    }  
}