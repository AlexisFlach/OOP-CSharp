namespace App.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {   
                string fullName = FirstName;

                if(!string.IsNullOrEmpty(LastName)) {
                    if(!string.IsNullOrEmpty(fullName))
                    {
                        fullName += " "; 
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }
    }

}