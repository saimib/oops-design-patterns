using System;

namespace design_patterns.Template
{
    class PDFDataMiner: DataMiner {
    protected override string OpenFile(string path)
    {
      Console.WriteLine("Opening PDF File");
      return "file";
    }
    protected override string ExtractData(string path)
    {
      Console.WriteLine("Extracting PDF File");
      return "file";
    }
    protected override string ParseData(string path)
    {
      Console.WriteLine("Parsing PDF File");
      return "file";
    }
    protected override void CloseFile(string path)
    {
      Console.WriteLine("Closing PDF File");
    }
  }
}