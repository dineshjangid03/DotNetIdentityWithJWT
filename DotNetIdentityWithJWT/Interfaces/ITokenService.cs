namespace DotNetIdentityWithJWT.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
