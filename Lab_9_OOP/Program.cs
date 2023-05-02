namespace Lab_9_OOP
{
    public delegate void MyDel(int m);
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Sashko";
            Parent parent = new Parent();
            Bughalteria stipuha = new Bughalteria();

            student.MarkChange += parent.OnMarkChange;

            student.MarkChange += stipuha.ScholarshipPayment;

            student.AddMark(99);
            student.AddMark(76);
            student.AddMark(34);
            student.AddMark(45);

            
            
        }
    }
}