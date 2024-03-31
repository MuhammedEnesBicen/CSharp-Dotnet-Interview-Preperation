[ApiController]
[Route("api/[controller]s")]
public class RoomController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public RoomController(ApplicationDbContext context)
    {
        _context = context;
        _context.Database.EnsureCreated();
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_context.Rooms.ToList());
    }

    [HttpPost]
    public ActionResult Post([FromBody] Room room)
    {
        _context.Rooms.Add(room);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = room.Id }, room);
    }

    [HttpGet("{id}")]
    public ActionResult Get(int id)
    {
        var room = _context.Rooms.Find(id);
        if (room == null)
        {
            return NotFound();
        }
        return Ok(room);
    }


    [HttpGet("floors")]
    public IActionResult GetByFloor(int floor1, int floor2)
    {
        var rooms = _context.Rooms.Where(r => r.Floor == floor1 || r.Floor == floor2).ToList();
        return Ok(rooms);
    }
}
