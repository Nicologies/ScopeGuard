# ScopeGuard

Allows the dispose method of a guard object call a user specified cleanup action at the end of a scope

# Usage

```cs
using(var scopeGuard = new ScopeGuard(() => {CleanUp();}){
  
}
```
