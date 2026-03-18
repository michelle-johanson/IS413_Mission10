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
            SELECT b.BowlerFirstName, COALESCE(b.BowlerMiddleInit, '') AS BowlerMiddleInit, b.BowlerLastName,
                   t.TeamName, COALESCE(b.BowlerAddress, '') AS BowlerAddress, COALESCE(b.BowlerCity, '') AS BowlerCity,
                   COALESCE(b.BowlerState, '') AS BowlerState, COALESCE(b.BowlerZip, '') AS BowlerZip,
                   COALESCE(b.BowlerPhoneNumber, '') AS BowlerPhoneNumber
            FROM Bowlers b
            JOIN Teams t ON b.TeamID = t.TeamID
            WHERE t.TeamName IN ('Marlins', 'Sharks')
        ").ToList();

        return Ok(bowlers);
    }
}
