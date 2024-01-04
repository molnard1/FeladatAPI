namespace FeladatAPI
{
    public record GetBookResponse(Guid BookId, string Title, int PublicationYear, string Genre, Guid AuthorId);

    public record CreateBookRequest(string Title, int PublicationYear, string Genre, Guid AuthorId);

    public record ModifyBookRequest(string Title, int PublicationYear, string Genre);

    public record GetAuthorResponse(Guid AuthorId, string FirstName, string LastName);

    public record CreateAuthorRequest(string FirstName, string LastName);

    public record ModifyAuthorRequest(string FirstName, string LastName);
    public record GetBookWithAuthorResponse(Guid BookId, string Title, string Genre, int PublicationYear, string AuthorFirstName, string AuthorLastName);
}