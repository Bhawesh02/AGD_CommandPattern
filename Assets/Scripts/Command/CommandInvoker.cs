using System.Collections.Generic;

public class CommandInvoker
{
   private Stack<ICommand> m_commandRegistry = new();

   public void ProcessCommand(ICommand commandToProcess)
   {
      ExecuteCommand(commandToProcess);
      RegisterCommand(commandToProcess);
   }

   private void ExecuteCommand(ICommand commandToExecute)
   {
      commandToExecute.Execute();
   }

   private void RegisterCommand(ICommand commandToRegister)
   {
      m_commandRegistry.Push(commandToRegister);
   }
}
