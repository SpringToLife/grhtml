using Microsoft.Extensions.Options;

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrapesJsEditorHtml.ViewModel
{
  public class MyOptions
  {
    public Dictionary<string?, string?> KeyValuePairs { get; set; }
  }
  public class ColumnMetadata
  {
    public string COLUMN_NAME { get; set; }
    public string DATA_TYPE { get; set; }
  }
  public class TableAttribute : Attribute
  {
    public string AttributeName { get; set; }

    public TableAttribute(string attributeName)
    {
      AttributeName = attributeName;
    }
  }

  public class AttributeModel
  {
    public string? Name { get; set; }
    public string AttributeName { get; set; }
  }
  public class MyOptionsConfiguration : IConfigureOptions<MyOptions>
  {
    private readonly IConfiguration _configuration;

    public MyOptionsConfiguration(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    public void Configure(MyOptions options)
    {
      options.KeyValuePairs = _configuration.GetSection("MyOptions:KeyValuePairs")
          .GetChildren()
          .ToDictionary(x => x.Key, x => x.Value);
    }
  }
}
