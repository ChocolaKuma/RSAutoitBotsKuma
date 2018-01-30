public static void SendMail(MailMessage Message)
{
    SmtpClient client = new SmtpClient();
    client.Host = "smtp.googlemail.com";
    client.Port = 587;
    client.UseDefaultCredentials = false;
    client.DeliveryMethod = SmtpDeliveryMethod.Network;
    client.EnableSsl = true;
    client.Credentials = new NetworkCredential("myemail@gmail.com", "password");
    client.Send(Message); 
}
