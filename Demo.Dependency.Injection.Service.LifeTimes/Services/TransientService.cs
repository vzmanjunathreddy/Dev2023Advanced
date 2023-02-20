using Demo.Dependency.Injection.Service.LifeTimes.Interfaces;

namespace Demo.Dependency.Injection.Service.LifeTimes.Services
{
    public class TransientService:ITransientService
    {
        private Guid _guid;
        public TransientService()
        {
            _guid = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
