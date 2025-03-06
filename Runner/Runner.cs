using SharedLibrary.FileUtils;
using SharedLibrary.TesterUtils;
using SharedLibrary.JsonUtils;
using Exercises;

public class Runner
{
    public static void Main()
    {
        string appSettingsString = FileUtils.LoadFileFromPath("AppSettings/appsettings.json");

        if (String.IsNullOrEmpty(appSettingsString))
        {
            Console.WriteLine("Press any key before exit...");
            Console.ReadKey();
            return;
        }

        AppSettings appSettingsObject = JsonUtils.SafelyDeserializeJson<AppSettings>(appSettingsString);

        if(appSettingsObject == default(AppSettings))
        {
            Console.WriteLine("Press any key before exit...");
            Console.ReadKey();
            return;
        }

        try
        {
            BaseTester baseTester = BaseTester.LoadTester(appSettingsObject.WhichTestShouldBeRun);

            baseTester.Test();
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Something went wrong trying to run the test, with error: {ex.Message}");
        }

        Console.WriteLine("Press any key before exit...");
        Console.ReadKey();
        return;
    }
}