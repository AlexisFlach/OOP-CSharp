using Xunit;
using BusinessApp.BL;

namespace BusinessApp.BLTest;


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
    public void FullNameTestNoLastname()
    {
        // Arrange
        Customer customer = new Customer
        {
            FirstName = "Gabriel",

        };

        string expected = "Gabriel";

        // Actuall
        string actual = customer.FullName;

        // Assert
        Assert.Equal(expected, actual);
    }
}
