namespace Exercises._3___Behavioral.Section_17___Mediator
{
    public class MediatorTester : BaseTester
    {
        public override void Test()
        {
            Mediator mediator = new Mediator();

            Participant p1 = new Participant(mediator);
            Participant p2 = new Participant(mediator);

            p1.Say(2);

            p2.Say(4);
        }
    }
}
