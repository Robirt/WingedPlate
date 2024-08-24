namespace WingedPlate.Domain.Entities;

public class UserEntity : EntityBase
{
    public string UserName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public int RoleId { get; set; } = 0;

    public RoleEntity RoleName { get; set; } = new();   

    public byte[]? PasswordHash { get; set; }

    public byte[]? PasswordSalt { get; set; }

}
