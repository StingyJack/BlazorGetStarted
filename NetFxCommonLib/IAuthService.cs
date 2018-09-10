namespace NetFxCommonLib
{
    using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        AuthResult AttemptUserAuth
            (string userName, string password);
    }
}