namespace NetFxTestConsole
{
    using System;
    using System.ServiceModel;
    using NetFxControllers;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when debugging ready");
            Console.ReadLine();

            var ctlr = new AuthController();
            var result = ctlr.AttemptUserAuth("Abc", "123");
            Console.WriteLine($"Result was {result?.IsAuthed}, {result?.UserTicket}");

            using (var svc = new ServiceReference1.AuthServiceClient(new BasicHttpBinding(), new EndpointAddress("http://localhost:62433/AuthService.svc")))
            {
                var generatedResult = svc.AttemptUserAuth("abc", "123");
                Console.WriteLine($"Generated result was {generatedResult?.IsAuthed}, {generatedResult?.UserTicket}");
            }


            
            Console.ReadLine();
        }
    }
}
