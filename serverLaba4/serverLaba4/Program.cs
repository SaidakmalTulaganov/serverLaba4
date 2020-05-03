using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace serverLaba4
{
    class Program
    {
        static void Main()
        {
            // Register channel
            TcpChannel channel = new TcpChannel(9000);
            ChannelServices.RegisterChannel(channel, false);
            TovarOperationImpl lstTovar = new TovarOperationImpl();
            lstTovar.addNewTovar(new Tovar("1 этаж", 10, 10, 300, "Ставь на 10 часов, 11 - й бесплатно"));
            lstTovar.addNewTovar(new Tovar("2 этаж", 20, 20, 400, "Ставь на 10 часов, 11 - й бесплатно"));
            lstTovar.addNewTovar(new Tovar("3 этаж", 30, 30, 500, "Ставь на 10 часов, 11 - й бесплатно"));
            lstTovar.addNewTovar(new Tovar("4 этаж", 40, 40, 600, "Ставь на 10 часов, 11 - й бесплатно"));
            // Register MyRemoteObject
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(TovarOperationImpl), "TalkIsGood", WellKnownObjectMode.Singleton);
            // Также можно зарегестрировать не тип, а неоходимый объект:
            //RemotingServices.Marshal(lstTovar, "TalkIsGood");
            //lstTovar – объект, который необходимо передать, "TalkIsGood" - параметр, который 
            //используется клиентом для активизации объекта (унифицированный идентификатор ресурса)
            Console.WriteLine("Press enter to stop this process.");
            Console.ReadLine();

        }
    }

}
