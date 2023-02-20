using Demo.Dependency.Injection.Service.LifeTimes.Interfaces;

namespace Demo.Dependency.Injection.Service.LifeTimes.Services
{
    public class ScopedService:IScopedService
    {
        private Guid _guid;
        public ScopedService()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
