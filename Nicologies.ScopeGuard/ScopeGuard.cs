using System;

namespace Nicologies.ScopeGuard
{
  public class ScopeGuard
  {
    private Action _exit;
    public ScopeGuard(Action enter, Action exit)
    {
      enter();
      _exit = exit;
    }

    public ScopeGuard(Action exit)
    {
      _exit = exit;
    }
    public void Dispose()
    {
      _exit();
      _exit = null;
    }
  }
}
