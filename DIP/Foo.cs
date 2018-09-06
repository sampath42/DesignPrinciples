namespace dip
{
    using System;
    public interface IFoo { string GetFoo(); }
    public class Foo : IFoo
    {
        MyConfig _config;
        public Foo(MyConfig config)
        {
            _config = config;
        }
        public string GetFoo()
        {
            return _config.AppName;
        }
    }
}