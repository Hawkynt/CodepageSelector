using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace CodepageSelector.Classes;
internal class SelectionReaderWriter {

  private static readonly FileInfo _FILE = new(@"Data\Selection.dict");
  private static readonly Regex _PATTERN = new(@"{\s*(\d+),\s*\[(.*?)\]\s*}", RegexOptions.Compiled);

  public static bool[]? GetSelection(int codepage) => ParseFileContents(_FILE.ReadAllText()).GetValueOrDefault(codepage, null);

  public static void SetSelection(int codepage, bool[] selection) {
    var dict = ParseFileContents(_FILE.ReadAllText());
    dict[codepage]=selection;
    WriteFileContents(_FILE, dict);
  }

  private static void WriteFileContents(FileInfo file, Dictionary<int, bool[]> dict) {
    using var writer = new StreamWriter(file.FullName);
    
    foreach (var entry in dict.OrderBy(kvp => kvp.Key)) {
      var selection = entry.Value;
      
      // we do not write empty sets
      if(!selection.Any(s=>s))
        continue;
      
      writer.Write($"{{ {entry.Key}, [");
      var isFirst = true;
      int? rangeStart = null;

      for (var i = 0; i < selection.Length; ++i)
        if (selection[i])
          rangeStart ??= i;
        else if (rangeStart != null) {
          if (!isFirst)
            writer.Write(",");
          
          writer.Write(rangeStart == i - 1 ? $"0x{rangeStart:X2}..0x{rangeStart:X2}" : $"0x{rangeStart:X2}..0x{i - 1:X2}");
          isFirst = false;
          rangeStart = null;
        }

      if (rangeStart != null) {
        if (!isFirst)
          writer.Write(",");
        
        writer.Write(rangeStart == selection.Length - 1 ? $"0x{rangeStart:X2}..0x{rangeStart:X2}" : $"0x{rangeStart:X2}..0x{selection.Length - 1:X2}");
      }

      writer.WriteLine("] }},");
    }
  }

  private static Dictionary<int, bool[]> ParseFileContents(string fileContent) {
    
    Dictionary<int, bool[]> result = [];
    
    var matches = _PATTERN.Matches(fileContent);

    foreach (Match match in matches) {
      var codepage = int.Parse(match.Groups[1].Value);
      var ranges = match.Groups[2].Value;

      var selectedValues = new bool[256];
      var parts = ranges.Split(',');
      foreach (var part in parts) {
        if (!part.Contains(".."))
          continue;
        
        var rangeParts = part.Split([".."], StringSplitOptions.None);
        var start = Convert.ToInt32(rangeParts[0].Trim(), 16);
        var end = Convert.ToInt32(rangeParts[1].Trim(), 16);

        for (var i = start; i <= end; ++i)
          selectedValues[i]=true;
      }

      result.Add(codepage, selectedValues);
    }

    return result;
  }
}
