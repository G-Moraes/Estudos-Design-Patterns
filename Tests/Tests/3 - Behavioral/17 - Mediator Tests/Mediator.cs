using MediatorExercise = Exercises._3___Behavioral.Section_17___Mediator;

namespace Tests.Tests._3___Behavioral._17___Mediator_Tests
{
    public class Mediator
    {
        [Fact]
        public void AssertMediator()
        {
            // Arrange
            MediatorExercise.Mediator mediator = new MediatorExercise.Mediator();

            MediatorExercise.Participant p1 = new MediatorExercise.Participant(mediator);

            MediatorExercise.Participant p2 = new MediatorExercise.Participant(mediator);

            // Assert
            Assert.Equal(0, p1.Value);
            Assert.Equal(0, p2.Value);

            // Act
            p1.Say(2);

            // Assert
            Assert.Equal(0, p1.Value);
            Assert.Equal(2, p2.Value);

            // Act
            p2.Say(4);

            // Assert
            Assert.Equal(4, p1.Value);
            Assert.Equal(2, p2.Value);
        }
    }
}
