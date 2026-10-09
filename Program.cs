using System;
using static System.Console;
class Program{
    static void Main(string[] args){
        WriteLine("This app shows differences between default " +
        "method parameter whitch passed to method as a value type. "+
        "And reference type method parameter.");
        WriteLine("===========================================================================");
        WriteLine("Here we go with VALUE type : ");
        string messageToChange = "Started message of string (unchanged).";
        WriteLine(messageToChange);
        ChangeByValueType(messageToChange);
        WriteLine(messageToChange);
        WriteLine("===========================================================================");
        WriteLine("Here we go with REFERENCE type : ");
        messageToChange = "Started message of string (unchanged).";
        WriteLine(messageToChange);
        ChangeByReferenceType(ref messageToChange);
        WriteLine(messageToChange);
    }
    static void ChangeByValueType(string msg){
        msg = "This message was changed by VALUE type!";
        WriteLine(msg);
    }
    static void ChangeByReferenceType(ref string msg){
        msg = "This message was changed by REFERENCE type!";
        WriteLine(msg);
    }
}