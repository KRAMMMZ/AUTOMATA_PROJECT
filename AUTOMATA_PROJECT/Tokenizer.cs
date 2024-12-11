using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Tokenizer
{
    public static List<(string TokenType, string Value, int LineNumber)> Tokenize(string sourceCode)
    {
        var tokenDefinitions = new List<(string, string)>
        {
            ("KEYWORD", "\\b(if|else|while|return)\\b"),
            ("IDENTIFIER", "[a-zA-Z_][a-zA-Z0-9_]*"),
            ("OPERATOR", "[+\\-*/=<>!]+"),
            ("NUMBER", "\\d+(\\.\\d+)?"),
            ("DELIMITER", "[;,(){}]"),
            ("STRING", "\"(\\\\.|[^\"])*\""),
            ("WHITESPACE", "\\s+"),
            ("UNKNOWN", ".")
        };

        string tokenRegex = string.Join("|", tokenDefinitions.ConvertAll(td => $"(?<{td.Item1}>{td.Item2})"));
        var regex = new Regex(tokenRegex);
        var matches = regex.Matches(sourceCode);

        var tokens = new List<(string TokenType, string Value, int LineNumber)>();
        int lineNumber = 1;

        foreach (Match match in matches)
        {
            string tokenType = null;
            string tokenValue = match.Value;

            foreach (var groupName in tokenDefinitions.ConvertAll(td => td.Item1))
            {
                if (match.Groups[groupName].Success)
                {
                    tokenType = groupName;
                    break;
                }
            }

            if (tokenType == "WHITESPACE")
            {
                lineNumber += tokenValue.Count(c => c == '\n');
                continue;
            }

            tokens.Add((tokenType, tokenValue, lineNumber));
        }

        return tokens;
    }
}
