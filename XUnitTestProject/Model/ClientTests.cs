using Cafe.Model;
namespace XUnitTestProject.Model
{
    public class ClientTests
    {
        [Fact]
        public void TConstructor()
        {
            //p1
            {
                string fullName = "fullName1";
                string email = "email1";
                string phone = "phone1";
                int age = 19;

                Client client = new Client(fullName, email, phone, age);

                Assert.True(fullName == client.FullName);
                Assert.True(email == client.Email);
                Assert.True(phone == client.Phone);
                Assert.True(age == client.Age);
            }//p1
             //p2
            {
                string fullName = "fullName2";
                string email = "email2";
                string phone = "phone2";
                int age = 20;

                Client client = new Client(fullName, email, phone, age);

                Assert.True(fullName == client.FullName);
                Assert.True(email == client.Email);
                Assert.True(phone == client.Phone);
                Assert.True(age == client.Age);
            }//p2
             //p3
            {
                string fullName = "fullName3";
                string email = "email3";
                string phone = "phone3";
                int age = 18;

                Client client = new Client(fullName, email, phone, age);

                Assert.True(fullName == client.FullName);
                Assert.True(email == client.Email);
                Assert.True(phone == client.Phone);
                Assert.True(age == client.Age);
            }//p3
             //empty constructor
            {
                Client client = new Client();

                Assert.True("" == client.FullName);
                Assert.True("" == client.Email);
                Assert.True("" == client.Phone);
                Assert.True(0 == client.Age);
            }//empty constructor
        }
    }
}
