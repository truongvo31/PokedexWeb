using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;

namespace PokedexWeb.Services;

public class EmailService
{
    private readonly EmailSettings _emailSettings;
    private readonly ILogger<EmailService> _logger;

    public EmailService(IOptions<EmailSettings> emailSettings, ILogger<EmailService> logger)
    {
        _emailSettings = emailSettings.Value;
        _logger = logger;
    }

    public async Task SendEmailAsync(string toEmail, string subject, string body, bool isHtml = true)
    {
        await SendEmailAsync(toEmail, string.Empty, subject, body, isHtml);
    }

    public async Task SendEmailAsync(string toEmail, string toName, string subject, string body, bool isHtml = true)
    {
        try
        {
            using var message = new MailMessage();
            message.From = new MailAddress(_emailSettings.SenderEmail, _emailSettings.SenderName);
            message.To.Add(new MailAddress(toEmail, string.IsNullOrEmpty(toName) ? null : toName));
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = isHtml;

            await SendEmailInternalAsync(message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to send email to {Email}", toEmail);
            throw;
        }
    }

    public async Task SendEmailAsync(List<string> toEmails, string subject, string body, bool isHtml = true)
    {
        try
        {
            using var message = new MailMessage();
            message.From = new MailAddress(_emailSettings.SenderEmail, _emailSettings.SenderName);

            foreach (var email in toEmails)
            {
                message.To.Add(new MailAddress(email));
            }

            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = isHtml;

            await SendEmailInternalAsync(message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to send email to multiple recipients");
            throw;
        }
    }

    private async Task SendEmailInternalAsync(MailMessage message)
    {
        using var smtpClient = new SmtpClient(_emailSettings.SmtpServer, _emailSettings.SmtpPort);
        smtpClient.Credentials = new NetworkCredential(_emailSettings.Username, _emailSettings.Password);
        smtpClient.EnableSsl = _emailSettings.EnableSsl;

        await smtpClient.SendMailAsync(message);
        _logger.LogInformation("Email sent successfully to {Recipients}", string.Join(", ", message.To.Select(t => t.Address)));
    }

    public class EmailSettings
    {
        public string SmtpServer { get; set; } = string.Empty;
        public int SmtpPort { get; set; }
        public string SenderEmail { get; set; } = string.Empty;
        public string SenderName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool EnableSsl { get; set; } = true;
    }
}