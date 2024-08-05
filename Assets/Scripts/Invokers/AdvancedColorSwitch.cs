//INVOKER

using System.Collections;
using System.Collections.Generic;

public class AdvancedColorSwitch
{
    Stack<ICommand> commandList;

   public AdvancedColorSwitch()
    {
        commandList = new Stack<ICommand>();
    }

    public void AddCommand(ICommand newCommand)
    {
        newCommand.Execute();
        commandList.Push(newCommand);
    }

    public void UndoCommand()
    {
        if(commandList.Count > 0)
        {
            ICommand lastCommand = commandList.Pop();
            lastCommand.Undo();
        }
    }
}
