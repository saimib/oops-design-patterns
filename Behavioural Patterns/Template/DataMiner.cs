namespace design_patterns.Template
{
    abstract class DataMiner {
      public void Mine(string path) {
        var file = OpenFile(path);
        var rawdata = ExtractData(file);
        var data = ParseData(rawdata);
        CloseFile(file);
      }

      protected abstract string OpenFile(string path);
      
      protected abstract string ExtractData(string path);
      
      protected abstract string ParseData(string path);
      
      protected abstract void CloseFile(string path);
    }
}