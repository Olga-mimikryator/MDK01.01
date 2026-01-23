namespace WinFormConstructElements
{
    class Student
    {
        private string name_;
        private int age_;
        private string number_; ///номер билета
        private double argBall_; ///средний балл
        private string photo_;

        public Student()
        {
            name_ = "Вася Пупкин";
            age_ = 15;
        }
        public Student(string name, int age, string number, double argBall, string photo_)
        {
            this.name_ = name;
            this.age_ = age;
            this.number_ = number;
            this.argBall_ = argBall;
            this.photo_ = photo_;
        }

        public string Name
        {
            get { return name_; }
        }
        public int Age
        {
            get { return age_; }
        }
        public string Number
        {
            get { return number_; }
        }
        public double ArgBall
        {
            get { return argBall_; }
        }
        public string Photo
        {
            get { return photo_; }
        }
    }
}
