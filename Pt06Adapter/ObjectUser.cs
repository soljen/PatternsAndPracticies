using Pt06Adapter.Internal;

namespace Pt06Adapter
{
    public class ObjectUser
    {
        private IUseObject _obj;

        public ObjectUser(IUseObject obj)
        {
            _obj = obj;
        }

        public void Use()
        {
            _obj.SaySomething();
        }
    }
}