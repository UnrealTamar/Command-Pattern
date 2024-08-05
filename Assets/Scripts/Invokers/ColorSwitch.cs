//INVOKER

using System.Collections.Generic;

public class ColorSwitch
{
   ICommand onCommand;

   public ColorSwitch(ICommand _onCommand)
   {
    onCommand = _onCommand;
   }

   public void Switch()
   {
    onCommand.Execute();
   }
}
