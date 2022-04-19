﻿using System.Text;

namespace CommandPattern
{
    public class RemoteControl
    {
        readonly ICommand[] onCommands;
        readonly ICommand[] offCommands;
        ICommand undoCommand;
        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }
        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + onCommands[i].GetType().Name + " " +
                    offCommands[i].GetType().Name + "\n");
            }

            // Console.WriteLine(undoCommand.ToString());

            return stringBuilder.ToString();
        }
    }
}
