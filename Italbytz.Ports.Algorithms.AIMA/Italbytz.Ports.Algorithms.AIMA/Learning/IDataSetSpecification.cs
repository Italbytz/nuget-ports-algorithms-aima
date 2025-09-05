// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System.Collections.Generic;

namespace Italbytz.AI.Learning;

public interface IDataSetSpecification
{
    public string TargetAttribute { get; }
    public bool IsValid(IEnumerable<string> uncheckedAttributes);

    public IEnumerable<string> GetAttributeNames();

    public IAttributeSpecification GetAttributeSpecFor(string name);
    IEnumerable<string> GetPossibleAttributeValues(string attributeName);
}