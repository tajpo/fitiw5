﻿
using AdvancedConstructsInCsharp.Events;
using AdvancedConstructsInCsharp.Exceptions;

namespace AdvancedConstructsInCsharp
{
  public class Program
  {
    static void Main(string[] args)
    {
      ExceptionExamples.RunExamples();
      DelegateExamples.RunExamples();
      EventExamples.RunExamples();
      LambdaExpressions.RunExamples();
    }
  }
}
