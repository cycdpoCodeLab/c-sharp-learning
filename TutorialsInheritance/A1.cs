namespace TutorialsInheritance
{
    public class A1
    {
        private int value = 10;

        public class B : A1
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }
}