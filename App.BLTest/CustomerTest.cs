using Xunit;

using App.BL;
namespace App.BLTest;

public class CustomerTest
{
    [Fact] 
    public void FullNameTestValid()
    {
        // Arrange
        Customer customer = new Customer
        {
            FirstName = "Gabriel",
            LastName = "Batistuta"

        };

        string expected = "Gabriel Batistuta";

        // Actuall
        string actual = customer.FullName;

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]

    public void FullNameMissingLastName()
    {
        Customer customer = new Customer
        {
            FirstName = "Gabriel",
        };

        string expected = "Gabriel";

        string actual = customer.FullName;

        Assert.Equal(expected, actual);
    }
}