class BankAccount {
    private int id;
    private double balance;
    public int ID 
    {
        get 
        { 
            return this.id; 
        }
        set 
        {
            if(value > 0)
            {
                id = value; 
            } 
            else
            {
                throw new ArgumentException("Error");
            }
        }
    }
    public double Balance 
    {
        get 
        { 
            return this.balance; 
        }
        set 
        {
            if(value > 0)
            {
                balance = value; 
            } 
            else
            {
                throw new ArgumentException("Error");
            }
        }
    }
}