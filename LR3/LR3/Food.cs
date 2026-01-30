namespace LR3
{
    public class Food
    {
        private string name_;
        private double price_;
        private string supplier_;
        private string manufacturer_;
        private string expirationDate_;
        private string photo_;
        private string type_;

        public Food(string name_, double price_, string supplier_, string manufacturer_, 
                        string expirationDate_, string photo_, string type_)
        {
            this.name_ = name_;
            this.price_ = price_;
            this.supplier_ = supplier_;
            this.manufacturer_ = manufacturer_;
            this.expirationDate_ = expirationDate_;
            this.photo_ = photo_;
            this.type_ = type_;
        }
    }
}
