using System;
using System.Globalization;
/// <summary>
///TwoLetterISOLanguageName
/// </summary>
public class CultureInfoTwoLetterISOLanguageName
{
    public static int Main()
    {
        CultureInfoTwoLetterISOLanguageName CultureInfoTwoLetterISOLanguageName = new CultureInfoTwoLetterISOLanguageName();
        TestLibrary.TestFramework.BeginTestCase("CultureInfoTwoLetterISOLanguageName");
        if (CultureInfoTwoLetterISOLanguageName.RunTests())
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

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: CultureTypes.SpecificCultures");
        try
        {

            CultureInfo myCultureInfo = new CultureInfo("de-DE");
            string expectedstring = "de";

            if (myCultureInfo.TwoLetterISOLanguageName != expectedstring)
            {
                TestLibrary.TestFramework.LogError("001", "the TwoLetterISOLanguageName  of 'zh-CHT' should be 'zh'.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest2: CultureTypes.NeutralCultures");
        try
        {

            CultureInfo myCultureInfo = new CultureInfo("en");
            string expectedstring = "en";
            if (myCultureInfo.TwoLetterISOLanguageName != expectedstring)
            {
                TestLibrary.TestFramework.LogError("003", "the TwoLetterISOLanguageName  of 'en' should be 'en'.");
                retVal = false;
            }
            if (TestLibrary.Utilities.IsWindows)
            {
                TestLibrary.TestFramework.LogError("003.1", "On Windows expected an ArgumentException");
            }
        }
        catch (ArgumentException)
        {
            if (!TestLibrary.Utilities.IsWindows)
            {
                TestLibrary.TestFramework.LogError("003.2", "Expect no exception on Macintosh; instead got ArgumentException");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest3()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest3: invariant culture");
        try
        {

            CultureInfo myTestCulture = CultureInfo.InvariantCulture;
            string expectedstring = "iv";
            if (myTestCulture.TwoLetterISOLanguageName != expectedstring)
            {
                TestLibrary.TestFramework.LogError("004", "the TwoLetterISOLanguageName  of InvariantCulture should be 'iv'.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
}

