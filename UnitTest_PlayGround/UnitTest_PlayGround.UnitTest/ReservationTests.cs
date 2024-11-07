using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
namespace UnitTest_PlayGround.UnitTest
{
    //[TestClass]
    [TestFixture]
    public class ReservationTests
    {
        //all test mehtods should public void 
        //[TestMethod]
        [Test]
        public void CanCancelledBy_CancelByAdmin_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanCancelledBy(new User { IsAdmin = true });

            //Assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanCancelledBy_CancelBySameUser_ReturnTrue() 
        {
            //Arrange
            var user = new User { IsAdmin = false };
            var reservation = new Reservation { MadeBy = user};

            //Act
           var result =  reservation.CanCancelledBy(user);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanCancelledBy_CancelByAnotherUser_ReturnFalse()
        {
            //Arrange
           
            var reservation = new Reservation { MadeBy = new User() };

            //Act
            var result = reservation.CanCancelledBy(new User());

            //Assert
            Assert.That(result, Is.False);
        }
    }
}