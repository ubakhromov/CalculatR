namespace CalculatR
{
    class Security
    {
        public void CheckPassword()
        {
            string password = "";

            do
            {
                Console.WriteLine("Enter the password: ");
                password = Console.ReadLine();
            }while(password != "p@ssw0rd");
            

        }
    }
}