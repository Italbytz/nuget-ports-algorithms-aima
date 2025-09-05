// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System.Collections.Generic;

namespace Italbytz.AI.Learning;

public interface IExample
{
    Dictionary<string, IAttribute> Attributes { get; }

    public string TargetValue();

    public string GetAttributeValueAsString(string attributeName);
}