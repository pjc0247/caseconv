# caseconv
caseconv for C#


Usage
----
```c#
var tokens = CaseTokenizer.Tokenize("caseConv_testFwer_e");
            Console.WriteLine(string.Join(", ", tokens));
            Console.WriteLine(CaseConv.Join(tokens, CaseType.Snake));
```
