using System;

public interface INotificable
{
    void Notificar();
}


public class NotificacionEmail : INotificable
{
    private string DireccionEmail;

   
    public NotificacionEmail(string email)
    {
        this.DireccionEmail = email;
    }

   
    public void Notificar()
    {
        Console.WriteLine("Se envio una notificacion de correo electronico a: " + DireccionEmail);
     
    }
}

public class NotificacionSMS : INotificable
{
    private string NumeroTelefono;

    public NotificacionSMS(string numeroTelefono)
    {
        this.NumeroTelefono = numeroTelefono;
    }

   
    public void Notificar()
    {
        Console.WriteLine("Se ha enviado una sms a: " + NumeroTelefono);
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        NotificacionSMS notificacionSMS = new NotificacionSMS("41890712");
        notificacionSMS.Notificar();

        NotificacionEmail notificacionEmail = new NotificacionEmail("chernandezl19@miumg.edu.gt");
        notificacionEmail.Notificar();

        
    }
}