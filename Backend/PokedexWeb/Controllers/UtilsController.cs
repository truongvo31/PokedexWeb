using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using PokedexWeb.Services;
using System.ComponentModel.DataAnnotations;

namespace PokedexWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilsController : ControllerBase
    {
        private readonly ILogger<UtilsController> _logger;
        private readonly EmailService _emailService;

        public UtilsController(ILogger<UtilsController> logger, EmailService emailService)
        {
            _logger = logger;
            _emailService = emailService;
        }

        [HttpPost("sendmail")]
        [EnableRateLimiting("SendMailPolicy")]
        [RequestSizeLimit(8 * 1024)]
        public async Task<IActionResult> SendMailAsync([FromBody] ContactRequest request)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            if (!string.IsNullOrWhiteSpace(request.Website))
            {
                _logger.LogWarning("Blocked honeypot contact request from {Ip}", HttpContext.Connection.RemoteIpAddress);
                return Ok(new { message = "Email sent successfully" });
            }

            try
            {
                await _emailService.SendEmailAsync(
                    request.Email.Trim(),
                    request.Name.Trim(),
                    request.Subject.Trim(),
                    request.Message.Trim()
                );

                return Ok(new { message = "Email sent successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to send email");
                return StatusCode(500, new { message = "Failed to send email", error = ex.Message });
            }
        }
    }

    public class ContactRequest
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(256)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(120, MinimumLength = 3)]
        public string Subject { get; set; } = string.Empty;

        [Required]
        [StringLength(4000, MinimumLength = 10)]
        public string Message { get; set; } = string.Empty;

        [StringLength(200)]
        public string Website { get; set; } = string.Empty;
    }
}
