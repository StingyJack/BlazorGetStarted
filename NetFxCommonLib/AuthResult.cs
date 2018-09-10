namespace NetFxCommonLib
{
    using System.Runtime.Serialization;

    [DataContract]
    public class AuthResult
    {
        [DataMember]
        public bool IsAuthed { get; set; }

        [DataMember]
        public string UserTicket { get; set; } = string.Empty;

        [DataMember]
        public string ErrorMessage { get; set; } = string.Empty;

    }
}