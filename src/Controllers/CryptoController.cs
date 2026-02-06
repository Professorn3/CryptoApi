using Microsoft.AspNetCore.Mvc;
using CryptoApi.Models;
using CryptoApi.Services;

namespace CryptoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CryptoController : ControllerBase
{
    [HttpPost("encrypt")]
    public ActionResult<CryptoResponse> Encrypt([FromBody] CryptoRequest request)
    {
        if (request is null || string.IsNullOrWhiteSpace(request.Text))
            return BadRequest("Text is required.");

        var encrypted = CaesarCipher.Encrypt(request.Text, request.Shift);
        return Ok(new CryptoResponse { Result = encrypted });
    }

    [HttpPost("decrypt")]
    public ActionResult<CryptoResponse> Decrypt([FromBody] CryptoRequest request)
    {
        if (request is null || string.IsNullOrWhiteSpace(request.Text))
            return BadRequest("Text is required.");

        var decrypted = CaesarCipher.Decrypt(request.Text, request.Shift);
        return Ok(new CryptoResponse { Result = decrypted });
    }
}
