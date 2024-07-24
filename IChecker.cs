using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
  public interface IChecker
  {
      bool Check(float value);
      void DisplayStatus(float value);
      void Warn();
  }
}
