using ATM.Helper;
using ATM.Service;

namespace ATM.Models;

public class AtmCardRequestModel
{
    public string CardNo { get; set; }
    public int Amount { get; set; }
    public int UserId { get; set; }

    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}