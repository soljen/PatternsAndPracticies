namespace Pt05Singlton
{
    class SingltonObject
    {
        private static SingltonObject Instance { get; set; }
        public string InstanceData { get; set; }

        private SingltonObject()
        {

        }

        public static SingltonObject GetInstance()
        {
            return Instance ?? (Instance = new SingltonObject());
        }
    }
}