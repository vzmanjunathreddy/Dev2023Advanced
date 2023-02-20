using Demo.Dependency.Injection.Service.LifeTimes.Interfaces;

namespace Demo.Dependency.Injection.Service.LifeTimes.Services
{
    public class SingletonService : ISignleTonService
    {
        private Guid _guid;
        public SingletonService()
        {
            _guid= Guid.NewGuid();
        }

        public string GetGuid()
        {
             return _guid.ToString();
        }
    }
}
