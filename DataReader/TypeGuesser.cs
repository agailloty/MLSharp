using System;
namespace DataReader;
public static class TypeGuesser
{
    public static Type GuessType(string value)
    {
        // List all primitive data types that we can guess based on the
        // string provided as parameter of the method. 
        int integerType;
        double doubleType;
        DateTime dateTimeType;
        string stringType;

        if (Int32.TryParse(value, out integerType))
            return typeof(int);
        if (double.TryParse(value, out doubleType)) 
            return typeof(double);
        if (DateTime.TryParse(value, out dateTimeType))
            return typeof(DateTime);

        return typeof(string);
    }
}

 