using Microsoft.AspNetCore.Mvc;

namespace productAPI.Controllers
{
        public class AppController : Controller
        {
            /// <summary>
            /// Invoke the provided function and get relevant status code action results for handled exceptions.
            /// </summary>
            /// <param name="request">The HTTP request.</param>
            /// <param name="func">The function to invoke.</param>
            /// <returns>The return value from the provided function, or a status code action result if an exception was caught.</returns>
            [NonAction]
            protected async Task<IActionResult> GetResultWithErrorHandling(HttpRequest request, Func<Task<IActionResult>> func)
            {
#pragma warning disable CS0168 // Variable is declared but never used
                try
                {
                    return await func();
                }
                // Catch exceptions caused by bad user input.
                catch (BadInputException exception)
                {
                    return BadRequest(exception.Message);
                }

                // Catch all other exceptions.
                catch (Exception exception)
                {
#if DEBUG
                    // Don't catch the exception so it's easier to debug.
                    throw;
#else
				// TODO: Properly log the error.
				Console.Error.WriteLine($"Caught exception for API endpoint \"{request.Path}\" - {exception}");
				return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
#endif
                }
#pragma warning restore CS0168 // Variable is declared but never used
            }
        }
    }

