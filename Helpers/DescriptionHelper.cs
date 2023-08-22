
namespace GrapesJsEditorHtml.Helpers
{

  public class DescriptionHelper
  {

    public String GenerateDropdownHtml(List<Utils.PropertyData> modelTypes)
    {
      List<string> optionsHtml = new List<string>();
      Dictionary<string, string> opti = new Dictionary<string, string>();
      foreach (Utils.PropertyData modelType in modelTypes)
      {
        if (modelType.Description != null && !modelType.Description.Contains("$$") && !modelType.Description.Contains("Chars"))
        { 
          opti.Add(modelType.Nom, modelType.Description);
          RemoveDuplicates(opti);
        }
                
      }
      optionsHtml.AddRange(opti.OrderBy(kv => kv.Value).Select(kv => $"<option value=\"{kv.Key}\" class=\"others\">{kv.Value}</option>"));
      string dropdownHtml = $"<select>{string.Join("", optionsHtml)}</select>";

      return dropdownHtml;
    }

    public Dictionary<string, string> RemoveDuplicates(Dictionary<string, string> dictionary)
    {
    
      Dictionary<string, string> uniqueDictionary = new Dictionary<string, string>();
      var distinctPairs = dictionary.GroupBy(pair => pair.Value)
                                    .Select(group => group.First());

          foreach (var pair in distinctPairs)
          {
            uniqueDictionary.Add(pair.Key, pair.Value);
          }
        return uniqueDictionary;
    }
    public static List<Utils.PropertyData> RemoveDuplicates(List<Utils.PropertyData> modelTypes)
    {
      List<Utils.PropertyData> uniqueModelTypes = modelTypes.Distinct().ToList();
      return uniqueModelTypes;
    }
    public static List<string> RemoveDuplicates(List<string> strings)
    {
      HashSet<string> uniqueStrings = new HashSet<string>();
      List<string> result = new List<string>();

      foreach (string str in strings)
      {
        if (!uniqueStrings.Contains(str))
        {
          uniqueStrings.Add(str);
          result.Add(str);
        }
      }

      return result;
    }

  }
}

    
  


       