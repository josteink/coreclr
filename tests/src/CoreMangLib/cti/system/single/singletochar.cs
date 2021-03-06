using System;
using System.Globalization;
/// <summary>
///System.IConvertible.ToChar(System.IFormatProvider)
/// </summary>
public class SingleToChar
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Negtive]");
        retVal = NegTest1() && retVal;
        return retVal;
    }

    #region Positive Test Cases
	//CultureInfo.GetCultureInfo has been removed. Replaced by CultureInfo ctor.
    public bool NegTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest1: Check a single which is  -.123.");

        try
        {
            Single i1 = (Single)(-.123);
            CultureInfo myCulture = new CultureInfo("en-us");
            char actualValue = ((IConvertible)i1).ToChar(myCulture);
            TestLibrary.TestFramework.LogError("101.1", "InvalidCastException should be caught. ");
            retVal = false;
        }
        catch (InvalidCastException)
        {

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("101.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
 
   
    #endregion

    #endregion

    public static int Main()
    {
        SingleToChar test = new SingleToChar();

        TestLibrary.TestFramework.BeginTestCase("SingleToChar");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

}
