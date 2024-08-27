using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class UploadController : ControllerBase {
    [HttpPost("upload")]
    public async Task<IActionResult> UploadFile([FromForm] IFormFile file) {
        if (file == null || file.Length == 0)
            return BadRequest("No file uploaded.");

        var filePath = Path.Combine("wwwroot", "uploads", file.FileName);

        using (var stream = new FileStream(filePath, FileMode.Create)) {
            await file.CopyToAsync(stream);
        }

        return Ok(new { message = "File uploaded successfully." });
    }
}
