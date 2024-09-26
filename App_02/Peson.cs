/*
    Задача: Дефинирайте клас Person, като за него
    пазете информация за името и възрастта на
    човек и реализирайте единствено действието
    IntroduceYourself(), което отпечатва
    представяне на човека. След това създайте и
    използвайте обект от класа Person.
*/
class Peson
{    
    //props and fields, => характеристики на обекта
    private int age;
    private string name;
    private List<BankAccount> bankAccounts = new List<BankAccount>();
    //methods => поведението на обекта
    
    //реализираме свойство Name
    public int Age
    { 
        get 
        { 
            return this.age; 
        }
        set 
        { 
            if(value > 0)
            {
                this.age = value; 
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }
    }
    public string Name
    { 
        get 
        { 
            return this.name; 
        }
        set 
        { 
            if(value.Length > 3)
            {
                this.name = value; 
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }
    }
    
    public void AddBankAccount(BankAccount bankAccount)
    {
        this.bankAccounts.Add(bankAccount);
    }

    public double GetBalance()
    {
        double sum = 0;
        for(int i = 0; i < this.bankAccounts.Count; i++)
        {   
            BankAccount currentBankAccount = bankAccounts[i];
            sum += currentBankAccount.Balance;
        }
        return sum;
    }

    private void IntroduceYourself()
    {
        System.Console.WriteLine("My name is " + this.name + " and " + this.age + " years old.");
        System.Console.WriteLine("Balance on all accounts is: " + this.GetBalance());
    }
}