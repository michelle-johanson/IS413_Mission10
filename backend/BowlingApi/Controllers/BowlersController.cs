using BowlingApi.Data;
using BowlingApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BowlingApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BowlersController : ControllerBase
{
    private readonly BowlingContext _context;

    public BowlersController(BowlingContext context) => _context = context;

    [HttpGet]
    public IActionResult GetBowlers()
    {
        var bowlers = _context.Bowlers.FromSqlRaw(@"
            SELECT b.BowlerFirstName, b.BowlerMiddleInit, b.BowlerLastName,
                   t.TeamName, b.BowlerAddress, b.BowlerCity,
                   b.BowlerState, b.BowlerZip, b.BowlerPhoneNumber
            FROM Bowlers b
            JOIN Teams t ON b.TeamID = t.TeamID
            WHERE t.TeamName IN ('Marlins', 'Sharks')
        ").ToList();

        return Ok(bowlers);
    }
}
