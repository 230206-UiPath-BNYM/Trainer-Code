Imports System
'modules in vb are class like artifacts that contains helper methods
'every module has exactly one instance and does not need to be
' created or assigned to a variable
Module Program
' This is the main method, the starting point of the program 
' two kinds of methods in vb: 
' functions - return something  
'subs - return nothing, return void 
    Sub Main(args As String())
    ' something else to note: vb has not grouping symbols like curly braces
    ' that define the scope of a code block, instead, it relies on closing statements
    ' also, tabbing for documentation purposes
    ' vb.net doesn't use semi colons, you get an error if you end your statements in 
    ' a semi colon 
        Console.WriteLine("Hello World!")
    ' variables - holds data , reference in memory, placeholder 
    ' with vb, we create variables using the dim keyword
    ' using dim, the syntax is dim name of var as datatype
    ' the greeter function returns a string that we are passing to the 
    ' greeting variable 
    dim greeting as String =  greeter("casual")
    Console.WriteLine(greeting)
    End Sub
    ' you set the datatype with the as keyword 
    Function greeter(greeting_type as String) As String
        ' flow control statements, used to channel logic based on certain 
        ' conditions
        ' select case AKA switch
        Select Case greeting_type
            Case "casual"
                Return "'sup"
            Case "business casual"
                Return "salutations!"
            Case "full business"
                Return "to whom it may concern"
            Case Else
                Return "hello"
        End Select
    End Function
    
End Module
