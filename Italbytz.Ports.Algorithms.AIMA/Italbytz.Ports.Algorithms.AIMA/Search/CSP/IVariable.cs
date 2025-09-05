using System;

namespace Italbytz.AI.Search.CSP;

public interface IVariable : IEquatable<IVariable>
{
    public string Name { get;  }
}