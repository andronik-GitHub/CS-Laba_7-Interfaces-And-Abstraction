using System;

class Mission : IMission
{
    string? codeName;
    string? state;

    public string? CodeName { get => codeName; set => codeName = value; }
    public string? State { get => state; set => state = value; }

    public Mission(string? codeName, string? state)
    {
        if (codeName == null)
            CodeName = "";

        CodeName = codeName;
        State = state;
    }

    public override string ToString()
    {
        if (State == null) return "";
        else if (State.ToLower() == "isprogress") return $"Code Name: {CodeName} State: {State}";
        else  return $"Code Name: {CodeName} State: {State}";
    }
}