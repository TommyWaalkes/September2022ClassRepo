namespace MockAssessment5.Models
{
    public class Person
    {
        public int Age { get; set; }
        public string UserName { get; set; }

        //These properties update as Age updates, I don't have set them myself
        public bool CanDrive => Age >= 16;
        public bool CanDrink => Age >= 21;
    }
}
