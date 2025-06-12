enum State { On, Off }

class Lamp(State State)
{
    public void Operate()
    {
        State = State == State.On ? State.Off : State.On;
        Console.WriteLine("Luz " + (State == State.On ? "Ligada" : "Deslgiada"));
    }
}

class Switch
{
    private Lamp lamp;
    public Switch(Lamp device)
    {
        lamp = device;
    }

    public void Press()
    {
        lamp.Operate();
    }
}
