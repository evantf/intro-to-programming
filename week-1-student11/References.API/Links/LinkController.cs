using Microsoft.AspNetCore.Mvc;

namespace References.API.Links
{
    public class LinkController : ControllerBase
    {
        // This is where the class controller code goes

        [HttpGet("/links")]
        public async Task<ActionResult> GetAllLinksAsync(CancellationToken token)
        {
            return Ok();
        }
    }
}
