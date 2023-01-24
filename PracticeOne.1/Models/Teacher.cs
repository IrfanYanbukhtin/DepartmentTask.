namespace PracticeOne._1.Models
{
    internal class Teacher : Person
    {
        internal Group[] Groups { get; set; } = new Group[10];
        internal DateTime EntryDate { get; set; }
        internal string StudySubjects { get; set; }

        public override string ToString()
        {
            string groups = "";
            foreach (var item in Groups)
            {
                if (item == null)
                    continue;

                groups += item + "\n";
            }

            return $"{Id} {Firstname} {Lastname} {FatherName} {Age}\n{Groups}\n{EntryDate}\nSubjects:\n{StudySubjects}";

        }

    }
}