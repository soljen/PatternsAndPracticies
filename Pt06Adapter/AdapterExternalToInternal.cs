using Pt06Adapter.External;
using Pt06Adapter.Internal;

namespace Pt06Adapter
{
    public class AdapterExternalToInternal : IUseObject
    {
        private IExternalInterface _obj;

        public AdapterExternalToInternal(IExternalInterface obj)
        {
            _obj = obj;
        }

        public void SaySomething()
        {
            _obj.BlaBlaSomething();
        }
    }
}