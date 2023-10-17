namespace Library;

public class WhatsAppMessage : Message
{
    public WhatsAppMessage(Contact contact) :
        base(null, contact.Phone)
    {
        // Intencionalmente en blanco
    }
    public new string To { get; set; }
}