namespace Exercises._3___Behavioral.Section_17___Mediator
{
    /*    
        Our system has any number of instances of Participant classes. Each Participant has a Value integer, initially zero.

        A participant can Say() a particular value, which is broadcast to all other participants. At this point in time, every other participant is obliged to increase their Value by the value being broadcast.

        Example:

        - Two participants start with values 0 and 0 respectively
        - Participant 1 broadcasts the value 3. We now have Participant 1 value = 0, Participant 2 value = 3
        - Participant 2 broadcasts the value 2. We now have Participant 1 value = 2, Participant 2 value = 3
    */

    public class Participant
    {
        public int Value { get; set; }
        public int Identifier = 0;
        private readonly Mediator Mediator;

        public Participant(Mediator mediator)
        {
            this.Mediator = mediator;
            Identifier++;

            mediator.Join(this);
        }

        public void Say(int n)
        {
            Mediator.Broadcast(Identifier, n);
        }
    }

    public class Mediator
    {
        List<Participant> participants = new List<Participant>();

        public void Join(Participant p)
        {
            p.Identifier = participants.Count + 1;
            participants.Add(p);
        }

        public void Broadcast(int source, int message)
        {
            foreach(Participant participant in participants)
            {
                if(participant.Identifier == source)
                {
                    continue;
                }

                participant.Value = message;
                Console.WriteLine($"Participant {participant.Identifier} now has value: {participant.Value}");
            }
        }
    }
}
