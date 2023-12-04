namespace Decorator
{
    public interface DataSource
    {
        public void writeData(DataSource data);
        public void readData();

    }

    public abstract class DataSourceDecorator : DataSource
    {
        private DataSource wrappee;

        public DataSourceDecorator(DataSource s)
        {
            this.wrappee = s;
        }

        public virtual void readData()
        {
           wrappee.readData();
        }

        public virtual void writeData(DataSource data)
        {
           wrappee.writeData(data);
        }
    }

    public class EncryptDecorator : DataSourceDecorator
    {
        public EncryptDecorator(DataSource s) : base(s)
        {

        }

        public override void readData()
        {
           base.readData(); 
        }

        public override void writeData(DataSource data)
        {
          base.writeData(data);
        }
    }

    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource s) : base(s)
        {
        }

        public override void readData()
        {
            base.readData();
        }

        public override void writeData(DataSource data)
        {
            base.writeData(data);
        }
    }

    public class FileDataSource : DataSource
    {

        private string fileName;

        public FileDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public void readData()
        {
           //do work
        }

        public void writeData(DataSource data)
        {
            //do work
        }
    }
}