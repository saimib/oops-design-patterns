using System;

namespace design_patterns.Template
{
    class TextDataMiner: DataMiner {
    protected override string OpenFile(string path)
    {
      Console.WriteLine("Opening Text File");
      return "file";
    }
    protected override string ExtractData(string path)
    {
      Console.WriteLine("Extracting Text File");
      return "file";
    }
    protected override string ParseData(string path)
    {
      Console.WriteLine("Parsing Text File");
      return "file";
    }
    protected override void CloseFile(string path)
    {
      Console.WriteLine("Closing Text File");
    }
  }
}