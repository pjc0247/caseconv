class CaseTokenizer
{
    public static string[] Tokenize(string input)
    {
        List<string> tokens = new List<string>();
        var lastOffset = 0;

        for(int i = 1; i < input.Length; i++)
        {
            if (input[i] == '_' ||
                char.IsUpper(input[i]))
            {
                tokens.Add(input.Substring(lastOffset, i - lastOffset));

                if (input[i] == '_')
                    lastOffset = i + 1;
                else
                    lastOffset = i;
            }
        }
        tokens.Add(input.Substring(lastOffset));

        return tokens.Select(x => x.ToLower()).ToArray();
    }
}

enum CaseType {
    Camel,
    Pascal,
    Snake,
    Train
}
class CaseConv
{
    public static string Join(string[] input, CaseType type)
    {
        var sb = new StringBuilder();
        var isFirstToken = true;

        foreach(var token in input)
        {
            switch(type)
            {
                case CaseType.Camel:
                    sb.Append(isFirstToken ? token : ToUpperFirstCh(token));
                    break;
                case CaseType.Pascal:
                    sb.Append(ToUpperFirstCh(token));
                    break;
                case CaseType.Snake:
                    sb.Append(token + "_");
                    break;
                case CaseType.Train:
                    sb.Append(ToUpperFirstCh(token) + "-");
                    break;
            }

            isFirstToken = false;
        }

        if (type == CaseType.Snake || type == CaseType.Train)
            sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }

    private static string ToUpperFirstCh(string input)
    {
        return char.ToUpper(input.First()) + input.Substring(1);
    }
}
