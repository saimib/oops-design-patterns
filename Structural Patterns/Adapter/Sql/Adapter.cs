using design_patterns.Adapter.Business;

namespace design_patterns.Adapter.Sql
{
  class DataSourceAdapter : IDataSource
  {

    private IDriver _driver;

    public DataSourceAdapter(IDriver driver)
    {
        this._driver = driver;
    }
    public void save(string data)
    {
      this._driver.CreateSQLCommand(data);
      this._driver.Execute();
    }
  }
}