using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pt01AbstractFactory
{
    class Client
    {
        private AbstractWheel _wheel;
        private AbstractEngine _engine;
        private AbstractCore _core;

        public Client(AbstractFactory factory)
        {
            _wheel = factory.BuildWheels(4);
            _engine = factory.BuildEngine(1);
            _core = factory.BuildCore(1);
        }

        public void BuildCar()
        {
            _core.ConnectWheels(_wheel);
            _core.ConnectEngine(_engine);
        }
    }
}
