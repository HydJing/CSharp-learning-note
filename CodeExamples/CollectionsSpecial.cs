using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;

class Program
{
    // Sample class to represent a setting
    class Setting
    {
        public string Key { get; }
        public string Value { get; set; }
        public Setting(string key, string value) => (Key, Value) = (key, value);
        public override string ToString() => $"{Key}: {Value}";
    }

    static void Main()
    {
        // NameValueCollection: Add, remove, access, update, query, clear
        NameValueCollection config = new NameValueCollection();
        config.Add("Theme", "Dark"); // Add
        config.Add("Theme", "Light"); // Add multiple values
        string[] themes = config.GetValues("Theme"); // Access
        config["Theme"] = "Blue"; // Update (replaces all values)
        bool hasTheme = config.HasKeys() && config.AllKeys.Contains("Theme"); // Query
        config.Remove("Theme"); // Remove
        Console.WriteLine($"NameValueCollection: Themes: {string.Join(", ", themes)}, Has Theme: {hasTheme}, Count: {config.Count}"); // Outputs: Dark, Light, True, 0

        // StringCollection: Add, remove, access, update, query
        StringCollection tags = new StringCollection();
        tags.Add("urgent"); // Add
        tags.AddRange(new[] { "bug", "feature" }); // Add
        string firstTag = tags[0]; // Access
        tags[1] = "issue"; // Update
        bool hasFeature = tags.Contains("feature"); // Query
        tags.Clear(); // Clear
        Console.WriteLine($"StringCollection: First: {firstTag}, Has Feature: {hasFeature}, Count: {tags.Count}"); // Outputs: urgent, True, 0

        // StringDictionary: Add, remove, access, update, query
        StringDictionary settings = new StringDictionary();
        settings.Add("Font", "Arial"); // Add
        settings["Size"] = "12"; // Add
        string font = settings["Font"]; // Access
        settings["Font"] = "Calibri"; // Update
        bool hasFont = settings.ContainsKey("Font"); // Query
        settings.Clear(); // Clear
        Console.WriteLine($"StringDictionary: Font: {font}, Has Font: {hasFont}, Count: {settings.Count}"); // Outputs: Arial, True, 0

        // HybridDictionary: Add, remove, access, update, query
        HybridDictionary metadata = new HybridDictionary();
        metadata.Add("Version", "1.0"); // Add
        metadata["Build"] = 123; // Add
        object version = metadata["Version"]; // Access
        metadata["Version"] = "2.0"; // Update
        bool hasBuild = metadata.Contains(" bruxBuild"); // Query
        metadata.Remove("Build"); // Remove
        Console.WriteLine($"HybridDictionary: Version: {version}, Has Build: {hasBuild}, Count: {metadata.Count}"); // Outputs: 1.0, True, 1

        // ListDictionary: Add, remove, access, update, query
        ListDictionary smallConfig = new ListDictionary();
        smallConfig.Add("Mode", "Debug"); // Add
        smallConfig["Timeout"] = 30; // Add
        object mode = smallConfig["Mode"]; // Access
        smallConfig["Mode"] = "Release"; // Update
        bool hasTimeout = smallConfig.Contains("Timeout"); // Query
        smallConfig.Clear(); // Clear
        Console.WriteLine($"ListDictionary: Mode: {mode}, Has Timeout: {hasTimeout}, Count: {smallConfig.Count}"); // Outputs: Debug, True, 0

        // OrderedDictionary: Add, remove, access, update, query
        OrderedDictionary orderedSettings = new OrderedDictionary();
        orderedSettings.Add("Priority", "High"); // Add
        orderedSettings["Category"] = "Security"; // Add
        object priority = orderedSettings["Priority"]; // Access
        orderedSettings[0] = new DictionaryEntry("Priority", "Low"); // Update
        bool hasCategory = orderedSettings.Contains("Category"); // Query
        orderedSettings.RemoveAt(0); // Remove
        Console.WriteLine($"OrderedDictionary: Priority: {priority}, Has Category: {hasCategory}, Count: {orderedSettings.Count}"); // Outputs: High, True, 1

        // BitVector32: Add, remove, access, update, query
        BitVector32 flags = new BitVector32(0);
        int debugFlag = BitVector32.CreateMask(); // Create bit mask
        int logFlag = BitVector32.CreateMask(debugFlag);
        flags[debugFlag] = true; // Add (set bit)
        bool isDebug = flags[debugFlag]; // Access
        flags[debugFlag] = false; // Update (unset bit, equivalent to remove)
        int flagCount = flags.Data; // Query (raw data)
        flags.Data = 0; // Clear
        Console.WriteLine($"BitVector32: Debug: {isDebug}, Data: {flagCount}, Data after clear: {flags.Data}"); // Outputs: True, 1, 0
    }
}