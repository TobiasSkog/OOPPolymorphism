namespace OOPPolymorphism.DataVerification
{
    // Public static class VerifiedUserInput that will is in place to help
    // us help the user to get acceptable values in the software
    public static class VerifiedUserInput
    {
        // public static method that takes an int and a prompt as input. The method checks if the value is greater than 0
        // in other words, it's making sure that the value is not a negative value
        public static int GetPositveInt(int unkownInt, string prompt)
        {
            // If the int have a positive value we return the int
            if (unkownInt > 0)
            {
                return unkownInt;
            }
            // If the int have a negative value we start a do while (true) loop (infite loop until we get a value we accept)
            else
            {
                do
                {
                    // Writing the prompt to the console
                    Console.Write(prompt);
                    // if statement that uses int.TryParse with the Console.ReadLine as input
                    // it tries to convert the input from the user to an int and returns a true or false
                    // value. True if it succeeds in parsing it as an int and it outputs a new int validInt
                    // False if the TryParse fails and we cannot parse it as an int
                    if (int.TryParse(Console.ReadLine(), out int validInt))
                    {
                        // The user input succeeded in parsing as an int, making sure tha value is greater than 0
                        if (validInt > 0)
                        {
                            // The value is greater than 0, returning the value
                            return validInt;
                        }
                    }
                    // The value was either not an integer or its value was not greater than 0
                    // The loop will restart
                } while (true);
            }
        }
        // public static method that takes a double and a prompt as input. The method checks if the value is greater than 0
        // in other words, it's making sure that the value is not a negative value
        public static double GetPositveDouble(double unkownDouble, string prompt)
        {
            // If the double have a positive value we return the double
            if (unkownDouble > 0.0)
            {
                return unkownDouble;
            }
            // If the double have a negative value we start a do while (true) loop (infite loop until we get a value we accept)
            else
            {
                do
                {
                    // Writing the prompt to the console
                    Console.Write(prompt);
                    // if statement that uses double.TryParse with the Console.ReadLine as input
                    // it tries to convert the input from the user to a double and returns a true or false
                    // value. True if it succeeds in parsing it as a double and it outputs a new double validDouble
                    // False if the TryParse fails and we cannot parse it as a double
                    if (double.TryParse(Console.ReadLine(), out double validDouble))
                    {
                        // The user input succeeded in parsing as an double, making sure tha value is greater than 0.0
                        if (validDouble > 0.0)
                        {
                            // The value is greater than 0.0, returning the value
                            return validDouble;
                        }
                    }
                    // The value was either not a double or its value was not greater than 0.0
                    // The loop will restart
                } while (true);
            }
        }
    }
}
