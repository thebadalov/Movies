using Microsoft.EntityFrameworkCore;
using Movie.Data.Entities;

namespace Movie.Data.Contexts
{
    public class MovieContext : DbContext
    {
        public DbSet<Character> Charahters { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<MovieEpisodePersonCharacter> MovieEpisodePersonCharacters { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieEpisodePerson> MovieEpisodePersons { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MoviePerson> MoviePersons { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }
        public DbSet<Entities.Movie> Movies { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>(e =>
            {
                e.Property(p => p.Name)
                .IsRequired(true);

                e.Property(p => p.Surname)
                .IsRequired(true);

                e.Property(p => p.Birthday)
                .IsRequired();
            });

            modelBuilder.Entity<User>(e =>
            {
                e.Property(p => p.Name)
                .IsRequired(true);

                e.Property(p => p.Surname)
                .IsRequired(true);

                e.Property(p => p.Email)
                .IsRequired(true);

                e.Property(p => p.Password)
                .IsRequired(true);

                e.Property(p => p.Birthday)
                .IsRequired();
            });

            modelBuilder.Entity<Episode>(e =>
            {
                e.Property(p => p.Number)
                .IsRequired(true);

                e.Property(p => p.Title)
                .IsRequired(true);

                e.Property(p => p.Duration)
                .IsRequired(true);

                e.Property(p => p.ReleaseAt)
                .IsRequired();

                e.HasOne(p => p.Movie)
                .WithMany(p => p.Episodes)
                .HasForeignKey(p => p.MovieId)
                .IsRequired(true);
            });

            modelBuilder.Entity<MovieEpisodePersonCharacter>(e =>
            {
                e.HasOne(p => p.Character)
                .WithMany(p => p.MovieEpisodePersonCharacters)
                .HasForeignKey(p => p.CharacterId)
                .IsRequired(true);

                e.HasOne(p => p.MovieEpisodePerson)
                .WithMany(p => p.MovieEpisodePersonCharacters)
                .HasForeignKey(p => p.MovieEpisodePersonId)
                .IsRequired(true);
            }); ;

            modelBuilder.Entity<Genre>(e =>
            {
                e.Property(p => p.Name)
                .IsRequired(true);
            });

            modelBuilder.Entity<MovieEpisodePerson>(e =>
            {
                e.HasOne(p => p.Episode)
                .WithMany(p => p.MovieEpisodePersons)
                .HasForeignKey(p => p.EpisodeId)
                .IsRequired(true);

                e.HasOne(p => p.Person)
                .WithMany(p => p.MovieEpisodePersons)
                .HasForeignKey(p => p.PersonId)
                .IsRequired(true);

                e.Property(p => p.IsDirector)
               .IsRequired(true);
            });

            modelBuilder.Entity<MovieGenre>(e =>
            {
                e.HasOne(p => p.Movie)
               .WithMany(p => p.MovieGenres)
               .HasForeignKey(p => p.MovieId)
               .IsRequired(true);

                e.HasOne(p => p.Genre)
               .WithMany(p => p.MovieGenres)
               .HasForeignKey(p => p.GenreId)
               .IsRequired(true);
            });

            modelBuilder.Entity<MoviePerson>(e =>
            {
                e.HasOne(p => p.Movie)
                .WithMany(p => p.MoviePersons)
                .HasForeignKey(p => p.MovieId)
                .IsRequired(true);

                e.HasOne(p => p.Person)
                 .WithMany(p => p.MoviePersons)
                 .HasForeignKey(p => p.PersonId)
                 .IsRequired(true);

                e.HasOne(p => p.Character)
                   .WithMany(p => p.MoviePersons)
                   .HasForeignKey(p => p.CharacterId)
                   .IsRequired(true);

                e.Property(p => p.PersonType)
               .IsRequired(true);
            });

            modelBuilder.Entity<MovieRating>(e => {
                e.HasOne(p => p.Movie)
                .WithMany(p => p.MovieRatings)
                .HasForeignKey(p => p.MovieId)
                .IsRequired(true);

                e.HasOne(p => p.User)
                .WithMany(p => p.MovieRatings)
                .HasForeignKey(p => p.UserId)
                .IsRequired(true);

                e.Property(p => p.Rating)
               .IsRequired();
            });

            modelBuilder.Entity<Entities.Movie>(e => {
                e.Property(p => p.Title)
                .IsRequired(true);

                e.Property(p => p.MovieType)
                .IsRequired(true);

                e.Property(p => p.ReleaseAt)
                .IsRequired();

                e.Property(p => p.EndAt)
                .IsRequired();

                e.Property(p => p.Description)
                .IsRequired();

                e.Property(p => p.Duration)
                .IsRequired();

                e.Property(p => p.PGRating)
                .IsRequired(true);

                e.Property(p => p.Photo)
                .IsRequired(true);
            });

            modelBuilder.Entity<Person>(e => {
                e.Property(p => p.Name)
                .IsRequired(true);

                e.Property(p => p.Surname)
                .IsRequired(true);

                e.Property(p => p.Birthday)
                .IsRequired();
            });

            modelBuilder.Entity<Character>().ToTable("Chracters");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Episode>().ToTable("Episodes");
            modelBuilder.Entity<MovieEpisodePersonCharacter>().ToTable("MovieEpisodePersonCharacters");
            modelBuilder.Entity<Genre>().ToTable("Genres");
            modelBuilder.Entity<MovieEpisodePerson>().ToTable("MovieEpisodePersons");
            modelBuilder.Entity<MovieGenre>().ToTable("MovieGenres");
            modelBuilder.Entity<MoviePerson>().ToTable("MoviePersons");
            modelBuilder.Entity<MovieRating>().ToTable("MovieRatings");
            modelBuilder.Entity<Entities.Movie>().ToTable("Movies");
            modelBuilder.Entity<Person>().ToTable("Persons");
        }
    }
}
