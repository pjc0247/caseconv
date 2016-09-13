# caseconv
caseconv for C#


Usage
----
```c#
var tokens = CaseTokenizer.Tokenize("caseConv_testWorld_bye");
            
// case, conv, test, world, bye
string.Join(", ", tokens);

// case_conv_test_world_bye
CaseConv.Join(tokens, CaseType.Snake);

// Case-Conv-Test-World-Bye
CaseConv.Join(tokens, CaseType.Train);

// caseConvTestWorldBye
CaseConv.Join(tokens, CaseType.Camel);
```
