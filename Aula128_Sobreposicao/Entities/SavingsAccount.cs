/* >>> CLASSE SAVINGSACCOUNT <<< */
namespace Aula128_Sobreposicao.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) // OVERRIDE para sobrepor a Virtual
        {
            base.Withdraw(amount); // BASE reaproveita o metodo da Superclasse (no caso, metodo Withdraw da superclasse Account)
            Balance -= 2.0; // Aplica a operacao da Superclasse e acrescenta a operacao
            // Balance -= amount;
        }
    }
}
