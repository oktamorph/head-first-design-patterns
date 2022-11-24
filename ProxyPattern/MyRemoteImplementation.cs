namespace ProxyPattern
{
    public class MyRemoteImplementation : MarshalByRefObject, IMyRemote
    {
        private static long _serialVersionUID = 1L;
        public MyRemoteImplementation()
        {
            // throw RemoteException();
        }
        public string SayHello()
        {
            return "Server says, 'Hey'";
        }
    }
}
