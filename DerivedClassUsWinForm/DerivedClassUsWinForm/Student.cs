namespace DerivedClassUsWinForm
{
    public class Student : HomoSapiens
    {
        private string numberTicket_;

        public string NumberTicket
        {
            get { return numberTicket_; }
        }
        public Student(string numberTicket_) : base("Василий Стипендиянеполучайкин", 21)
        {
            numberTicket_ = numberTicket_;
        }
        public override string ToString()
        {
            return base.ToString() +", номер билета: "+ numberTicket_;
        }
    }
}
