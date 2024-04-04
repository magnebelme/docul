// Define a constant for the relative path to the commits directory.
// This path assumes the 'commits' directory is one level up from the current directory.
private const string COMMITS_PATH = "../commits";

// Method to get the full path to the commits directory.
// This method uses the current environment's base directory to construct the full path.
public static string GetCommitsDirectoryFullPath()
{
    // Combine the base directory of the app with the relative commits path.
    return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, COMMITS_PATH);
}

// Ensure the commits directory exists and create it if it doesn't.
// This is useful to avoid errors when trying to access the directory.
public static void EnsureCommitsDirectoryExists()
{
    // Get the full path to the commits directory.
    string fullPath = GetCommitsDirectoryFullPath();

    // Check if the directory exists.
    if (!Directory.Exists(fullPath))
    {
        // Create the directory if it does not exist.
        Directory.CreateDirectory(fullPath);
    }
}
