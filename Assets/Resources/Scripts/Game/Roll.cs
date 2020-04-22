public class Roll
{
    public Roll(byte value1, byte value2)
    {
        die1Value = value1;
        die2Value = value2;
    }

    byte die1Value, die2Value;

    public bool isDouble => (die1Value == die2Value);
    public bool isEven => die1Value % 2 == 0;
    public ushort Value => (ushort)(die1Value + die2Value);
}