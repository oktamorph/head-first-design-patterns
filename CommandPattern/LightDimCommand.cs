namespace CommandPattern
{
    public class LightDimCommand : ICommand
    {
        readonly Light light;
        public LightDimCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Dim();
        }
        public void Undo()
        {
            // Method intentionally left empty.
        }
    }
}
