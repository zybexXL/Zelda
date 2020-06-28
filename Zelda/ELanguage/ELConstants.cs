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
        Field, Load, Note, Save, SaveAdd, Tag,
        // conditional
        If, IfElse, FirstNotEmpty, IfCase, And, Or,
        // date and time
        ConvertDate, FormatDate, Now, DateInRange,
        // file path and identifier
        DBLocation, FileDBLocation, FileFolder, FileKey, FileName, FilePath, FileVolume,
        FileLookup, IsDriveMissing,
        // formatting
        Delimit, FormatBoolean, FormatDuration, FormatFileSize, FormatNumber,
        FormatRange, Orientation, PadNumber, RatingStars, RatingStars10, Watched,
        // grouping
        GroupCount, GroupSummary, GroupCountQuery, GroupSummaryQuery,
        // list manipulation
        ListBuild, ListClean, ListCombine, ListContains, ListCount, ListEqual, ListFind,
        ListFormat, ListGrep, ListItem, ListLimit, ListMix, ListRemove, ListShuffle, ListSort,
        // miscellaneous
        AlbumArtist, AlbumKey, AlbumType, AudioAnalysisState, Char, Counter,
        CustomData, FilePlaylists, Number, Range, Size, TrackNumber, TVInfo, StackCount,
        // string manipulation
        Clean, Enviro, Find, FixCase, FixSpacing, Hexify, Left, Length, Letter, Mid,
        MoveArticles, Regex, RemoveCharacters, RemoveLeft, RemoveRight, Replace,
        Right, Swap, Trim, TrimLines, UnMoveArticles, Unswap, NoArticles,
        // test and comparison
        Compare, IsDigit, IsEqual, IsEmpty, IsInPlayingNow, IsLowerCase, IsMissing,
        IsPlaying, IsRange, IsRemovable, IsUpperCase, SearchTags,
        // math + subfunctions
        // Note: Rand() works both inside and outside Math()
        Math,
        abs, sign, log, log10, pow, rand, randn, min, max, equal, below, above,
        Int, frac, round, trunc, cos, sin, atan, tan, abscos, abssin,

        // other - to classify
        Literal, Row, Translate, URLify
    }

    public enum ELCategory
    {
        LoadStore, Conditional, DateTime, Identifier, Formatting,
        Grouping, Lists, Miscellaneous, Strings, TestCompare, Math
    }

    public class ELConstants
    {
        public static readonly List<ELFunction> ELFunctions = new List<ELFunction>()
        {
            new ELFunction(ELCategory.LoadStore, "Field", "Returns a field's value.", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Field"),
            new ELFunction(ELCategory.LoadStore, "Load", "Outputs the value of a global variable.", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Load"),
            new ELFunction(ELCategory.LoadStore, "Note", "Retrieve note fields.", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Note"),
            new ELFunction(ELCategory.LoadStore, "Save", "Saves a value to a global variable.", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Save"),
            new ELFunction(ELCategory.LoadStore, "SaveAdd", "Adds to a global variable.", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#SaveAdd"),
            new ELFunction(ELCategory.LoadStore, "Tag", "Returns a file's physical tag", "https://wiki.jriver.com/index.php/Accessing_and_Storing_Functions#Tag"),
            new ELFunction(ELCategory.Conditional, "And", "Tests a set of values and returns 1 if all are true.", "https://wiki.jriver.com/index.php/Conditional_Functions#And"),
            new ELFunction(ELCategory.Conditional, "FirstNotEmpty", "Returns the first non-empty argument.", "https://wiki.jriver.com/index.php/Conditional_Functions#FirstNotEmpty"),
            new ELFunction(ELCategory.Conditional, "If", "Conditional ifelse evaluator.", "https://wiki.jriver.com/index.php/Conditional_Functions#If"),
            new ELFunction(ELCategory.Conditional, "IfCase", "Functions as a switch or select case statement.", "https://wiki.jriver.com/index.php/Conditional_Functions#IfCase"),
            new ELFunction(ELCategory.Conditional, "IfElse", "Conditional if-elseif evaluator.", "https://wiki.jriver.com/index.php/Conditional_Functions#IfElse"),
            new ELFunction(ELCategory.Conditional, "Or", "Tests a set of values and returns 1 if any are true.", "https://wiki.jriver.com/index.php/Conditional_Functions#Or"),
            new ELFunction(ELCategory.DateTime, "ConvertDate", "Converts a human-readable date to the internal format required for use in date fields", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#ConvertDate"),
            new ELFunction(ELCategory.DateTime, "DateInRange", "Compares a date with a range of dates", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#DateInRange"),
            new ELFunction(ELCategory.DateTime, "FormatDate", "Formats a date value in a specified manner", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#FormatDate"),
            new ELFunction(ELCategory.DateTime, "Now", "Retrieve and display the system date", "https://wiki.jriver.com/index.php/Date_and_Time_Functions#Now"),
            new ELFunction(ELCategory.Identifier, "DBLocation", "Returns the current database location", null),
            new ELFunction(ELCategory.Identifier, "FileDBLocation", "Identifies a file's databases", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileDBLocation"),
            new ELFunction(ELCategory.Identifier, "FileFolder", "Returns the name of a file's parent", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileFolder"),
            new ELFunction(ELCategory.Identifier, "FileKey", "Returns a file's unique internal identifier", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileKey"),
            new ELFunction(ELCategory.Identifier, "FileLookup", "Looks up a file based on its filename", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileLookup"),
            new ELFunction(ELCategory.Identifier, "FileName", "Returns a file's name component", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileName"),
            new ELFunction(ELCategory.Identifier, "FilePath", "Returns a file's path component", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FilePath"),
            new ELFunction(ELCategory.Identifier, "FileVolume", "Returns a file's volume name component", "https://wiki.jriver.com/index.php/File_Path_and_Identifier_Functions#FileVolume"),
            new ELFunction(ELCategory.Identifier, "IsDriveMissing", "Returns true if the File cannot be accessed", null),
            new ELFunction(ELCategory.Formatting, "Delimit", "Outputs a value with head/tail strings when value is non-empty", "https://wiki.jriver.com/index.php/Formatting_Functions#Delimit"),
            new ELFunction(ELCategory.Formatting, "FormatBoolean", "Formats a boolean (true / false) value in a specified manner", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatBoolean"),
            new ELFunction(ELCategory.Formatting, "FormatDuration", "Presents a duration of seconds in a reader friendly format", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatDuration"),
            new ELFunction(ELCategory.Formatting, "FormatFileSize", "Presents a number of bytes in a reader friendly format", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatFileSize"),
            new ELFunction(ELCategory.Formatting, "FormatNumber", "Formats and rounds a number to a specified number of decimal places", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatNumber"),
            new ELFunction(ELCategory.Formatting, "FormatRange", "Formats a value as a range", "https://wiki.jriver.com/index.php/Formatting_Functions#FormatRange"),
            new ELFunction(ELCategory.Formatting, "Orientation", "Outputs the orientation of an image", "https://wiki.jriver.com/index.php/Formatting_Functions#Orientation"),
            new ELFunction(ELCategory.Formatting, "PadNumber", "Adds leading zeros to any given number", "https://wiki.jriver.com/index.php/Formatting_Functions#PadNumber"),
            new ELFunction(ELCategory.Formatting, "RatingStars", "Outputs the value of Rating as a number of star characters", "https://wiki.jriver.com/index.php/Formatting_Functions#RatingStars"),
            new ELFunction(ELCategory.Formatting, "RatingStars10", "Outputs the value of Rating as a number of star characters (0 to 10)", null),
            new ELFunction(ELCategory.Formatting, "Watched", "Outputs a formatted video bookmark", "https://wiki.jriver.com/index.php/Formatting_Functions#Watched"),
            new ELFunction(ELCategory.Grouping, "GroupCount", "Counts the members of a specified group (in a category or field).", "https://wiki.jriver.com/index.php/Grouping_Functions#GroupCount"),
            new ELFunction(ELCategory.Grouping, "GroupCountQuery", "[description missing]", null),
            new ELFunction(ELCategory.Grouping, "GroupSummary", "Smartly summarizes the members of a specified group (mode, mean, min, max, etc as is most logical for that grouping).", "https://wiki.jriver.com/index.php/Grouping_Functions#GroupSummary"),
            new ELFunction(ELCategory.Grouping, "GroupSummaryQuery", "[description missing]", null),
            new ELFunction(ELCategory.Lists, "ListBuild", "Constructs a list from a series of items", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListBuild"),
            new ELFunction(ELCategory.Lists, "ListClean", "Various list operations", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListClean"),
            new ELFunction(ELCategory.Lists, "ListCombine", "Combines two delimited lists into a single delimited list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListCombine"),
            new ELFunction(ELCategory.Lists, "ListContains", "Checks for a value being in a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListContains"),
            new ELFunction(ELCategory.Lists, "ListCount", "Returns the number of items in a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListCount"),
            new ELFunction(ELCategory.Lists, "ListEqual", "Checks for equality between two lists", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListEqual"),
            new ELFunction(ELCategory.Lists, "ListFind", "Search a list for a value and return that value, or its index # in the list.", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListFind"),
            new ELFunction(ELCategory.Lists, "ListFormat", "Outputs a given list in a reader friendly format.", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListFormat"),
            new ELFunction(ELCategory.Lists, "ListGrep", "Returns list items containing specified text", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListGrep"),
            new ELFunction(ELCategory.Lists, "ListItem", "Returns an item from a location in a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListItem"),
            new ELFunction(ELCategory.Lists, "ListLimit", "Limits the length of a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListLimit"),
            new ELFunction(ELCategory.Lists, "ListMix", "Combine corresponding values from multiple lists into a new list, using a template to process each item.", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListMix"),
            new ELFunction(ELCategory.Lists, "ListRemove", "Removes a string from a list.", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListRemove"),
            new ELFunction(ELCategory.Lists, "ListShuffle", "Shuffles a list", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListShuffle"),
            new ELFunction(ELCategory.Lists, "ListSort", "Sort a list of values", "https://wiki.jriver.com/index.php/List_Manipulation_Functions#ListSort"),
            new ELFunction(ELCategory.Miscellaneous, "AlbumArtist", "Returns a file's calculated album artist", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#AlbumArtist"),
            new ELFunction(ELCategory.Miscellaneous, "AlbumKey", "Returns a unique album key for a file", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#AlbumKey"),
            new ELFunction(ELCategory.Miscellaneous, "AlbumType", "Returns the album type for a file", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#AlbumType"),
            new ELFunction(ELCategory.Miscellaneous, "AudioAnalysisState", "Returns the state of audio analysis for a file", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#AudioAnalysisState"),
            new ELFunction(ELCategory.Miscellaneous, "Char", "Returns a character from the numeric code of that character", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Char"),
            new ELFunction(ELCategory.Miscellaneous, "Counter", "Counts upwards in specified increments", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Counter"),
            new ELFunction(ELCategory.Miscellaneous, "CustomData", "Returns internal data to the expression language", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#CustomData"),
            new ELFunction(ELCategory.Miscellaneous, "FilePlaylists", "Returns a list of playlists a file belongs to (Can also be used to search)", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#FilePlaylists"),
            new ELFunction(ELCategory.Math, "Math", "Evaluates a given mathematical formula", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Miscellaneous, "Number", "Returns the first number , including decimals, from a given string", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Number"),
            new ELFunction(ELCategory.Miscellaneous, "Rand", "Returns a random number between two given numbers", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Rand"),
            new ELFunction(ELCategory.Miscellaneous, "Range", "Creates a semi-colon delimited list of numbers in a field", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Range"),
            new ELFunction(ELCategory.Miscellaneous, "Size", "Returns a file's size in a format specific to the media type", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Size"),
            new ELFunction(ELCategory.Miscellaneous, "StackCount", "[Description missing]", null),
            new ELFunction(ELCategory.Miscellaneous, "Literal", "[Description missing]", null),
            new ELFunction(ELCategory.Miscellaneous, "Row", "[Description missing]", null),
            new ELFunction(ELCategory.Miscellaneous, "URLify", "[Description missing]", null),
            new ELFunction(ELCategory.Miscellaneous, "Translate", "[Description missing]", null),
            new ELFunction(ELCategory.Miscellaneous, "TrackNumber", "Returns a file's track # value", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#TrackNumber"),
            new ELFunction(ELCategory.Miscellaneous, "TVInfo", "Miscellaneous television and other pre-formatted information", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#TVInfo"),
            new ELFunction(ELCategory.Strings, "Clean", "Clean a string to be used for various operations", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Clean"),
            new ELFunction(ELCategory.Strings, "Enviro", "Retrieves the value of an environment variable", null),
            new ELFunction(ELCategory.Strings, "Find", "Finds a string or character in another string, returning its zero-based position in that string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Find"),
            new ELFunction(ELCategory.Strings, "FixCase", "Changes the case of a given string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#FixCase"),
            new ELFunction(ELCategory.Strings, "FixSpacing", "Intelligently splits adjacent camel-cased words", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#FixSpacing"),
            new ELFunction(ELCategory.Strings, "Hexify", "Hexifies a string to make it suitable for web usage", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Hexify"),
            new ELFunction(ELCategory.Strings, "Left", "Retrieves a specified number of characters from the left of a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Left"),
            new ELFunction(ELCategory.Strings, "Length", "Returns the number of characters in a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Length"),
            new ELFunction(ELCategory.Strings, "Letter", "Returns the starting letter or letters of a given string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Letter"),
            new ELFunction(ELCategory.Strings, "Mid", "Retrieves specified characters from a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Mid"),
            new ELFunction(ELCategory.Strings, "MoveArticles", "Takes 'The Beatles' and reverses it to 'Beatles, The'", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#MoveArticles"),
            new ELFunction(ELCategory.Strings, "NoArticles", "Takes 'The Beatles' and removes the article, returning 'Beatles'", null),
            new ELFunction(ELCategory.Strings, "Regex", "Regular expression pattern matching and capture", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Regex"),
            new ELFunction(ELCategory.Strings, "RemoveCharacters", "Removes a list of characters from a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#RemoveCharacters"),
            new ELFunction(ELCategory.Strings, "RemoveLeft", "Trims characters from the beginning of a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#RemoveLeft"),
            new ELFunction(ELCategory.Strings, "RemoveRight", "Trims characters from the end of a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#RemoveRight"),
            new ELFunction(ELCategory.Strings, "Replace", "Replace or remove a string segment", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Replace"),
            new ELFunction(ELCategory.Strings, "Right", "Retrieves a specified number of characters from the right of a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Right"),
            new ELFunction(ELCategory.Strings, "Swap", "Takes Firstname Lastname and swaps to Lastname, Firstname", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Swap"),
            new ELFunction(ELCategory.Strings, "Trim", "Removes leading and trailing non-printable characters and new lines from a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Trim"),
            new ELFunction(ELCategory.Strings, "TrimLines", "Removes leading and trailing non-printable characters and new lines from a string", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#TrimLines"),
            new ELFunction(ELCategory.Strings, "UnMoveArticles", "Takes 'Beatles, The' and reverses it to restore the normal word order, 'The Beatles'", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#UnMoveArticles"),
            new ELFunction(ELCategory.Strings, "Unswap", "Takes Lastname, Firstname and reverses it to Firstname Lastname", "https://wiki.jriver.com/index.php/String_Manipulation_Functions#Unswap"),
            new ELFunction(ELCategory.TestCompare, "Compare", "Compares two numbers.", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#Compare"),
            new ELFunction(ELCategory.TestCompare, "IsDigit", "Tests a value to check if it's numeric", null),
            new ELFunction(ELCategory.TestCompare, "IsEqual", "Compares two values in one of seventeen specified modes", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsEqual"),
            new ELFunction(ELCategory.TestCompare, "IsEmpty", "Tests a value for emptiness", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsEmpty"),
            new ELFunction(ELCategory.TestCompare, "IsLowerCase", "Tests a value to check if it's all in lower case", null),
            new ELFunction(ELCategory.TestCompare, "IsUpperCase", "Tests a value to check if it's all in upper case", null),
            new ELFunction(ELCategory.TestCompare, "IsRange", "Tests a value for inclusion within a given range", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsRange"),
            new ELFunction(ELCategory.TestCompare, "IsMissing", "Tests to see if a file exists on the system", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsMissing"),
            new ELFunction(ELCategory.TestCompare, "IsRemovable", "Tests to see if a file is stored on removable media", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsRemovable"),
            new ELFunction(ELCategory.TestCompare, "IsInPlayingNow", "Tests to see if a file is in the Playing Now playlist", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsInPlayingNow"),
            new ELFunction(ELCategory.TestCompare, "IsPlaying", "Tests to see if a file is in currently being played", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#IsPlaying"),
            new ELFunction(ELCategory.TestCompare, "SearchTags", "Finds all fields that contain a value", "https://wiki.jriver.com/index.php/Test_and_Comparison_Functions#SearchTags"),
            new ELFunction(ELCategory.Math, "abs", "Returns the absolute value of x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "sign", "Returns the sign of x (1 when x >= 0, -1 when x < 0).", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "log", "Returns the natural logarithm (base e) of x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "log10", "Returns the common logarithm (base 10) of x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "pow", "Returns x raised to the y-th power.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "rand", "Returns a random value ranging between x and y.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "randn", "Returns a random value ranging between -x and x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "min", "Returns the minimum value of x and y.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "max", "Returns the maximum value of x and y.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "equal", "Returns 1 when x = y, 0 otherwise.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "below", "Returns 1 when x < y, 0 otherwise.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "above", "Returns 1 when x > y, 0 otherwise.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "int", "Returns the integer portion of x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "frac", "Returns the fractional portion of x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "round", "Returns x rounded to the nearest whole number.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "trunc", "Returns x truncated to n decimal places.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "atan", "Returns the arctangent of x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "cos", "Returns the cosine of x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "sin", "Returns the sine of x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "tan", "Returns the tangent of x.", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "abscos", "Returns the absolute value of cosine(x).", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
            new ELFunction(ELCategory.Math, "abssin", "Returns the absolute value of sin(x).", "https://wiki.jriver.com/index.php/Miscellaneous_Functions#Math"),
        };
    } 
}
