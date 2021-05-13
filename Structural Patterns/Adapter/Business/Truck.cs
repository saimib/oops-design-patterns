namespace design_patterns.Adapter.Business
{
  class Truck {

    private IDataSource _dataSource;
    public Truck(IDataSource dataSource)
    {
        this._dataSource = dataSource;
    }
    public void deliver() {
      this._dataSource.save("I am saving this data, using Adapter");
    }

  }
}