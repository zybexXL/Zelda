using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelda
{
    public enum ELFunctions
    {
        Unknown, 
        // access/store
        Field, FieldQuery, Load, Note, Save, SaveAdd, SetField, Tag, ItemCount,
        // conditional
        If, IfElse, FirstNotEmpty, IfCase, And, Or, Not,
        // date and time
        CompareDates, ConvertDate, DateInRange, FormatDate, Now, PlaylistTime,
        // file path and identifier
        DBLocation, Enviro, FileDBLocation, FileExtension, FileFolder, FileKey, FileLookup, FileName, FilePath, FileVolume,
        // formatting
        Delimit, FormatBoolean, FormatDuration, FormatFileSize, FormatNumber,
        FormatRange, Orientation, PadNumber, RatingStars, RatingStars10, Watched,
        // grouping
        GroupCount, GroupSummary, GroupCountQuery, GroupSummaryQuery,
        // list manipulation
        ListBuild, ListClean, ListCombine, ListContains, ListCount, ListEqual, ListFilter, ListFind,
        ListFormat, ListGrep, ListItem, ListLimit, ListMath, ListMix, ListMix2, ListRemove, ListShuffle, ListSort,
        // miscellaneous
        AlbumArtist, AlbumKey, AlbumType, AudioAnalysisState, Char, 
        CustomData, FilePlaylists, Literal, PlaylistAdd, PlaylistRemove, Repeat, Row, ShellRun, Size,
        Translate, TreeNode, TVInfo,
        // Number functions
        Avg, Decimal, Counter, Max, Min, Number, Rand, Range, Roman, StackCount, Sum, TrackNumber,
        // string manipulation
        Clean, Dehexify, Extract, Find, FixCase, FixSpacing, Hexify, Left, Length, Letter, Mid,
        MoveArticles, NoArticles, PadLeft, PadRight, Regex, RemoveCharacters, RemoveLeft, RemoveRight, Replace,
        Right, Swap, Trim, TrimLines, UnMoveArticles, Unswap, URLify,
        // test and comparison
        Compare, FieldExists, IsDigit, IsDriveMissing, IsEmpty, IsEqual, IsInPlayingNow, IsLowerCase, IsMissing,
        IsOverridden, IsPlaying, IsRange, IsRemovable, IsUpperCase, SearchTags,
        // math + subfunctions
        Math,
        abs, sign, log, log10, pow, randn, equal, below, above,
        Int, frac, round, trunc, cos, sin, atan, tan, abscos, abssin
    }

    public enum ELCategory
    {
        LoadStore, Conditional, DateTime, Identifier, Formatting,
        Grouping, Lists, Miscellaneous, Number, Strings, TestCompare, Math
    }

    public class ELConstants
    {
        public static readonly List<ELFunction> ELFunctionWiki = new List<ELFunction>()
        {
            new ELFunction(ELCategory.LoadStore, ELFunctions.Field, "Returns a field's value", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Field"),
            new ELFunction(ELCategory.LoadStore, ELFunctions.FieldQuery, "Return a list of matches based on a list of fields to search, from a selected scope of files", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#FieldQuery"),
            new ELFunction(ELCategory.LoadStore, ELFunctions.ItemCount, "Globally counts the number of files that have share the same Field value", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#ItemCount"),
            new ELFunction(ELCategory.LoadStore, ELFunctions.Load, "Outputs the value of a global variable", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Load"),
            new ELFunction(ELCategory.LoadStore, ELFunctions.Note, "Retrieve note fields", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Note"),
            new ELFunction(ELCategory.LoadStore, ELFunctions.Save, "Saves a value to a global variable", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Save"),
            new ELFunction(ELCategory.LoadStore, ELFunctions.SaveAdd, "Adds to a global variable", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#SaveAdd"),
            new ELFunction(ELCategory.LoadStore, ELFunctions.SetField, "Sets a field's value", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#SetField"),
            new ELFunction(ELCategory.LoadStore, ELFunctions.Tag, "Returns a file's physical tag", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Tag"),

            new ELFunction(ELCategory.Conditional, ELFunctions.And, "Tests a set of values and returns 1 if all are true", "https://wiki.jriver.com/index.php/Conditional_Functions#And"),
            new ELFunction(ELCategory.Conditional, ELFunctions.FirstNotEmpty, "Returns the first non-empty argument", "https://wiki.jriver.com/index.php/Conditional_Functions#FirstNotEmpty"),
            new ELFunction(ELCategory.Conditional, ELFunctions.If, "Conditional ifelse evaluator", "https://wiki.jriver.com/index.php/Conditional_Functions#If"),
            new ELFunction(ELCategory.Conditional, ELFunctions.IfCase, "Functions as a switch or select case statement", "https://wiki.jriver.com/index.php/Conditional_Functions#IfCase"),
            new ELFunction(ELCategory.Conditional, ELFunctions.IfElse, "Conditional if-elseif evaluator", "https://wiki.jriver.com/index.php/Conditional_Functions#IfElse"),
            new ELFunction(ELCategory.Conditional, ELFunctions.Not, "Inverts a boolean value", "https://wiki.jriver.com/index.php/Conditional_Functions#Not"),
            new ELFunction(ELCategory.Conditional, ELFunctions.Or, "Tests a set of values and returns 1 if any are true", "https://wiki.jriver.com/index.php/Conditional_Functions#Or"),

            new ELFunction(ELCategory.DateTime, ELFunctions.CompareDates, "Calculates the diference between two dates", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#CompareDates"),
            new ELFunction(ELCategory.DateTime, ELFunctions.ConvertDate, "Converts a human-readable date to the internal format", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#ConvertDate"),
            new ELFunction(ELCategory.DateTime, ELFunctions.DateInRange, "Compares a date with a range of dates", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#DateInRange"),
            new ELFunction(ELCategory.DateTime, ELFunctions.FormatDate, "Formats a date value in a specified manner", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#FormatDate"),
            new ELFunction(ELCategory.DateTime, ELFunctions.Now, "Retrieve and display the system date", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#Now"),
            new ELFunction(ELCategory.DateTime, ELFunctions.PlaylistTime, "Return the start/remaining time of a track in the current playlist", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#PlaylistTime"),

            new ELFunction(ELCategory.Identifier, ELFunctions.DBLocation, "Returns the current database location", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#DBLocation"),
            new ELFunction(ELCategory.Identifier, ELFunctions.Enviro, "Retrieves the value of an environment variable", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#Enviro"),
            new ELFunction(ELCategory.Identifier, ELFunctions.FileDBLocation, "Identifies a file's databases", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileDBLocation"),
            new ELFunction(ELCategory.Identifier, ELFunctions.FileExtension, "Returns the file's extension", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileExtension"),
            new ELFunction(ELCategory.Identifier, ELFunctions.FileFolder, "Returns the name of a file's parent folder", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileFolder"),
            new ELFunction(ELCategory.Identifier, ELFunctions.FileKey, "Returns a file's unique internal identifier", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileKey"),
            new ELFunction(ELCategory.Identifier, ELFunctions.FileLookup, "Looks up a file based on its filename", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileLookup"),
            new ELFunction(ELCategory.Identifier, ELFunctions.FileName, "Returns a file's name component", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileName"),
            new ELFunction(ELCategory.Identifier, ELFunctions.FilePath, "Returns a file's path component", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FilePath"),
            new ELFunction(ELCategory.Identifier, ELFunctions.FileVolume, "Returns a file's volume name component", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileVolume"),

            new ELFunction(ELCategory.Formatting, ELFunctions.Delimit, "Outputs a value with head/tail strings when value is non-empty", "https://wiki.jriver.com/index.php/Formatting_Functions#Delimit"),
            new ELFunction(ELCategory.Formatting, ELFunctions.FormatBoolean, "Formats a boolean (true / false) value in a specified manner", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatBoolean"),
            new ELFunction(ELCategory.Formatting, ELFunctions.FormatDuration, "Presents a duration of seconds in a reader friendly format", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatDuration"),
            new ELFunction(ELCategory.Formatting, ELFunctions.FormatFileSize, "Presents a number of bytes in a reader friendly format", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatFileSize"),
            new ELFunction(ELCategory.Formatting, ELFunctions.FormatNumber, "Formats and rounds a number to a specified number of decimal places", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatNumber"),
            new ELFunction(ELCategory.Formatting, ELFunctions.FormatRange, "Formats a value as a range", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatRange"),
            new ELFunction(ELCategory.Formatting, ELFunctions.Orientation, "Outputs the orientation of an image", "https://wiki.jriver.com/index.php/Formatting_Functions#Orientation"),
            new ELFunction(ELCategory.Formatting, ELFunctions.PadNumber, "Adds leading zeros to any given number", "https://wiki.jriver.com/index.php/Formatting_Functions#PadNumber"),
            new ELFunction(ELCategory.Formatting, ELFunctions.RatingStars, "Outputs the value of Rating as a number of star characters", "https://wiki.jriver.com/index.php/Formatting_Functions#RatingStars"),
            new ELFunction(ELCategory.Formatting, ELFunctions.RatingStars10, "Outputs the value of Rating as a number of star characters (0 to 10)", "https://wiki.jriver.com/index.php/Formatting_Functions#RatingStars10"),
            new ELFunction(ELCategory.Formatting, ELFunctions.Watched, "Outputs a formatted video bookmark", "https://wiki.jriver.com/index.php/Formatting_Functions#Watched"),

            new ELFunction(ELCategory.Grouping, ELFunctions.GroupCount, "Counts the members of a specified group (in a category or field)", "https://wiki.jriver.com/index.php/Grouping_Functions#GroupCount"),
            new ELFunction(ELCategory.Grouping, ELFunctions.GroupCountQuery, "Globally counts the number of different Field2 entries for files that share Field1 value", "https://wiki.jriver.com/index.php/Grouping_Functions#GroupCountQuery"),
            new ELFunction(ELCategory.Grouping, ELFunctions.GroupSummary, "Summarises the members of a specified group (in a category or field)", "https://wiki.jriver.com/index.php/Grouping_Functions#GroupSummary"),
            new ELFunction(ELCategory.Grouping, ELFunctions.GroupSummaryQuery, "Globally summarises the Field entries for files that share a Match with the current file", "https://wiki.jriver.com/index.php/Grouping_Functions#GroupSummaryQuery"),

            new ELFunction(ELCategory.Lists, ELFunctions.ListBuild, "Constructs a list from a series of items", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListBuild"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListClean, "Various list operations", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListClean"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListCombine, "Combines two delimited lists into a single delimited list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListCombine"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListContains, "Checks for a value being in a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListContains"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListCount, "Returns the number of items in a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListCount"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListEqual, "Checks for equality between two lists", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListEqual"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListFilter, "Filter any list, returning only values within a given range", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListFilter"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListFind, "Search a list for a value and return that value, or its index # in the list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListFind"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListFormat, "Outputs a given list in a reader friendly format", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListFormat"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListGrep, "Returns list items containing specified text", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListGrep"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListItem, "Returns an item from a location in a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListItem"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListLimit, "Limits the length of a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListLimit"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListMath, "Calculates min/max/sum/avg of all list items", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListMath"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListMix, "Combine values from multiple lists into a new list, using a template to process each item", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListMix"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListMix2, "ListMix wrapper - unescapes and evaluates expression before calling ListMix", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListMix"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListRemove, "Removes a string from a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListRemove"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListShuffle, "Shuffles a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListShuffle"),
            new ELFunction(ELCategory.Lists, ELFunctions.ListSort, "Sort a list of values", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListSort"),

            new ELFunction(ELCategory.Miscellaneous, ELFunctions.AlbumArtist, "Returns a file's calculated album artist", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#AlbumArtist"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.AlbumKey, "Returns a unique album key for a file", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#AlbumKey"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.AlbumType, "Returns the album type for a file", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#AlbumType"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.AudioAnalysisState, "Returns the state of audio analysis for a file", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#AudioAnalysisState"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.Char, "Returns a character from the numeric code of that character", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Char"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.CustomData, "Returns internal data to the expression language", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#CustomData"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.FilePlaylists, "Returns a list of playlists a file belongs to (Can also be used to search)", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#FilePlaylists"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.Literal, "Returns a string as given without any formatting or processing", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Literal"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.PlaylistAdd, "Adds an item to a playlist", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#PlaylistAdd"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.PlaylistRemove, "Removes an item from a playlist", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#PlaylistRemove"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.Repeat, "Returns any given string repeated the specified number of times", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Repeat"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.Row, "Returns the row number of a list entry", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Row"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.Size, "Returns a file's size in a format specific to the media type", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Size"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.ShellRun, "Executes an external command and returns the output", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#ShellRun"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.Translate, "Converts an English string found in the program to the currently selected language", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Translate"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.TreeNode, "Returns the currently active tree node", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#TreeNode"),
            new ELFunction(ELCategory.Miscellaneous, ELFunctions.TVInfo, "Miscellaneous television and other pre-formatted information", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#TVInfo"),

            new ELFunction(ELCategory.Number, ELFunctions.Avg, "Returns the average value of a series of values", "https://wiki.jriver.com/index.php/Number_Functions#Avg"),
            new ELFunction(ELCategory.Number, ELFunctions.Counter, "Counts upwards in specified increments", "https://wiki.jriver.com/index.php/Number_Functions#Counter"),
            new ELFunction(ELCategory.Number, ELFunctions.Decimal, "Converts decimal commas to dots", "https://wiki.jriver.com/index.php/Number_Functions#Decimal"),
            new ELFunction(ELCategory.Number, ELFunctions.Max, "Returns the maximum value of a series of values", "https://wiki.jriver.com/index.php/Number_Functions#Max"),
            new ELFunction(ELCategory.Number, ELFunctions.Min, "Returns the minimum value of a series of values", "https://wiki.jriver.com/index.php/Number_Functions#Min"),
            new ELFunction(ELCategory.Number, ELFunctions.Number, "Returns the first number , including decimals, from a given string", "https://wiki.jriver.com/index.php/Number_Functions#Number"),
            new ELFunction(ELCategory.Number, ELFunctions.Rand, "Returns a random number between two given numbers", "https://wiki.jriver.com/index.php/Number_Functions#Rand"),
            new ELFunction(ELCategory.Number, ELFunctions.Range, "Creates a semi-colon delimited list of numbers in a field", "https://wiki.jriver.com/index.php/Number_Functions#Range"),
            new ELFunction(ELCategory.Number, ELFunctions.Roman, "Converts any given number to, or from, roman numerals", "https://wiki.jriver.com/index.php/Number_Functions#Roman"),
            new ELFunction(ELCategory.Number, ELFunctions.StackCount, "Returns the number of files in a stack", "https://wiki.jriver.com/index.php/Number_Functions#StackCount"),
            new ELFunction(ELCategory.Number, ELFunctions.Sum, "Returns the sum of a series of values", "https://wiki.jriver.com/index.php/Number_Functions#Sum"),
            new ELFunction(ELCategory.Number, ELFunctions.TrackNumber, "Returns a file's track # value", "https://wiki.jriver.com/index.php/Number_Functions#TrackNumber"),
            
            new ELFunction(ELCategory.Strings, ELFunctions.Clean, "Clean a string to be used for various operations", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Clean"),
            new ELFunction(ELCategory.Strings, ELFunctions.Dehexify, "De-hexifies a web-formatted string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Dehexify"),
            new ELFunction(ELCategory.Strings, ELFunctions.Extract, "Extract a substring from a string with custom delimiters", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Extract"),
            new ELFunction(ELCategory.Strings, ELFunctions.Find, "Finds a string or character in another string, returning its zero-based position in that string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Find"),
            new ELFunction(ELCategory.Strings, ELFunctions.FixCase, "Changes the case of a given string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#FixCase"),
            new ELFunction(ELCategory.Strings, ELFunctions.FixSpacing, "Intelligently splits adjacent camel-cased words", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#FixSpacing"),
            new ELFunction(ELCategory.Strings, ELFunctions.Hexify, "Hexifies a string to make it suitable for web usage", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Hexify"),
            new ELFunction(ELCategory.Strings, ELFunctions.Left, "Retrieves a specified number of characters from the left of a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Left"),
            new ELFunction(ELCategory.Strings, ELFunctions.Length, "Returns the number of characters in a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Length"),
            new ELFunction(ELCategory.Strings, ELFunctions.Letter, "Returns the starting letter or letters of a given string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Letter"),
            new ELFunction(ELCategory.Strings, ELFunctions.Mid, "Retrieves specified characters from a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Mid"),
            new ELFunction(ELCategory.Strings, ELFunctions.MoveArticles, "Takes 'The Beatles' and reverses it to 'Beatles, The'", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#MoveArticles"),
            new ELFunction(ELCategory.Strings, ELFunctions.NoArticles, "Takes 'The Beatles' and removes the article, returning 'Beatles'", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#NoArticles"),
            new ELFunction(ELCategory.Strings, ELFunctions.PadLeft, "Pad any string with any character, to the left", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#PadLeft"),
            new ELFunction(ELCategory.Strings, ELFunctions.PadRight, "Pad any string with any character, to the right", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#PadRight"),
            new ELFunction(ELCategory.Strings, ELFunctions.Regex, "Regular expression pattern matching and capture", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Regex"),
            new ELFunction(ELCategory.Strings, ELFunctions.RemoveCharacters, "Removes a list of characters from a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#RemoveCharacters"),
            new ELFunction(ELCategory.Strings, ELFunctions.RemoveLeft, "Trims characters from the beginning of a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#RemoveLeft"),
            new ELFunction(ELCategory.Strings, ELFunctions.RemoveRight, "Trims characters from the end of a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#RemoveRight"),
            new ELFunction(ELCategory.Strings, ELFunctions.Replace, "Replace or remove a string segment", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Replace"),
            new ELFunction(ELCategory.Strings, ELFunctions.Right, "Retrieves a specified number of characters from the right of a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Right"),
            new ELFunction(ELCategory.Strings, ELFunctions.Swap, "Takes Firstname Lastname and swaps to Lastname, Firstname", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Swap"),
            new ELFunction(ELCategory.Strings, ELFunctions.Trim, "Removes leading and trailing non-printable characters and new lines from a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Trim"),
            new ELFunction(ELCategory.Strings, ELFunctions.TrimLines, "Removes leading and trailing non-printable characters and new lines from a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#TrimLines"),
            new ELFunction(ELCategory.Strings, ELFunctions.UnMoveArticles, "Takes 'Beatles, The' and reverses it to restore the normal word order, 'The Beatles'", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#UnMoveArticles"),
            new ELFunction(ELCategory.Strings, ELFunctions.Unswap, "Takes Lastname, Firstname and reverses it to Firstname Lastname", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Unswap"),
            new ELFunction(ELCategory.Strings, ELFunctions.URLify, "Takes a string and applies html formatting for browser consumption", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Urlify"),

            new ELFunction(ELCategory.TestCompare, ELFunctions.Compare, "Compares two numbers", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#Compare"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.FieldExists, "Checks if a Field exists", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#FieldExists"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsDigit, "Tests a value to check if it's numeric", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsDigit"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsDriveMissing, "Returns true if the File cannot be accessed", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsDriveMissing"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsEmpty, "Tests a value for emptiness", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsEmpty"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsEqual, "Compares two values in one of seventeen specified modes", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsEqual"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsInPlayingNow, "Tests to see if a file is in the Playing Now playlist", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsInPlayingNow"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsLowerCase, "Tests a value to check if it's all in lower case", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsLowerCase"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsMissing, "Tests to see if a file exists on the system", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsMissing"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsOverridden, "Tests a calculated field to check for an expression override value", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsOverridden"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsPlaying, "Tests to see if a file is in currently being played", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsPlaying"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsRange, "Tests a value for inclusion within a given range", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsRange"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsRemovable, "Tests to see if a file is stored on removable media", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsRemovable"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.IsUpperCase, "Tests a value to check if it's all in upper case", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsUpperCase"),
            new ELFunction(ELCategory.TestCompare, ELFunctions.SearchTags, "Finds all fields that contain a value", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#SearchTags"),

            new ELFunction(ELCategory.Math, ELFunctions.Math, "Evaluates a given mathematical formula", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.abs, "Returns the absolute value of x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.sign, "Returns the sign of x (1 when x >= 0, -1 when x < 0)", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.log, "Returns the natural logarithm (base e) of x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.log10, "Returns the common logarithm (base 10) of x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.pow, "Returns x raised to the y-th power", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.randn, "Returns a random value ranging between -x and x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.equal, "Returns 1 when x = y, 0 otherwise", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.below, "Returns 1 when x < y, 0 otherwise", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.above, "Returns 1 when x > y, 0 otherwise", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.Int, "Returns the integer portion of x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.frac, "Returns the fractional portion of x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.round, "Returns x rounded to the nearest whole number", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.trunc, "Returns x truncated to n decimal places", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.atan, "Returns the arctangent of x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.cos, "Returns the cosine of x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.sin, "Returns the sine of x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.tan, "Returns the tangent of x", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.abscos, "Returns the absolute value of cosine(x)", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
            new ELFunction(ELCategory.Math, ELFunctions.abssin, "Returns the absolute value of sin(x)", "https://wiki.jriver.com/index.php/Number_Functions#Math"),
        };
    } 
}
