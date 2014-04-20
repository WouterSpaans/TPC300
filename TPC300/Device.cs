using System.Threading;

namespace TPC300
{
    public static class Device
    {
        // Devices:
        // type is always 1
        // code can be 0 to 15, and higher for other rooms??
        // Level can be:
        // 0 = Off
        // 1..16 = Level
        // 17 = On / Fading
        public static void On(byte code)
        {
            Wrapper.Send(1, code, 17);
        }

        public static void Off(byte code)
        {
            Wrapper.Send(1, code, 0);
        }

        public static void ForcedOn(byte code)
        {
            Wrapper.Send(1, code, 0);
            Thread.Sleep(600);
            Wrapper.Send(1, code, 17);
        }

        public static void ForcedFade(byte code)
        {
            Wrapper.Send(1, code, 1);
            Thread.Sleep(600);
            Wrapper.Send(1, code, 17);
        }

        public static void Level(byte code, byte level)
        {
            Wrapper.Send(1, code, level);
        }
    }
}