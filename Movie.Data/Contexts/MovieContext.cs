using Microsoft.EntityFrameworkCore;
using Movie.Data.Entities;

namespace Movie.Data.Contexts
{
    public class MovieContext : DbContext
    {
        public DbSet<Character> Charahters { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }
        public DbSet<Entities.Movie> Movie { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
        

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }
        public  MovieContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>(e =>
            {
                e.HasOne(p => p.Movie)
                .WithMany(p => p.Characters)
                .HasForeignKey(p => p.MovieId)
                .IsRequired(true);

                e.HasOne(p => p.Person)
                .WithMany(p => p.Characters)
                .HasForeignKey(p => p.PersonId)
                .IsRequired(true);

                e.Property(p => p.Name)
                .IsRequired(true);

                e.Property(p => p.Surname)
                .IsRequired(true);

                //e.Property(p => p.Birthday)
                //.IsRequired(false);
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

                //e.Property(p => p.Birthday)
                //.IsRequired(false);
            });

            modelBuilder.Entity<Comment>(e =>
            {
                e.Property(p => p.Comments)
                .IsRequired(true);

                e.HasOne(p => p.Movie)
                .WithMany(p => p.Comments)
                .HasForeignKey(p => p.MovieId)
                .IsRequired(true);

                e.HasOne(p => p.User)
                .WithMany(p => p.Comments)
                .HasForeignKey(p => p.UserId)
                .IsRequired(true);
            });


            modelBuilder.Entity<Genre>(e =>
            {
                e.Property(p => p.Name)
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


            modelBuilder.Entity<MovieRating>(e =>
            {
                e.HasOne(p => p.Movie)
                .WithMany(p => p.MovieRatings)
                .HasForeignKey(p => p.MovieId)
                .IsRequired(true);

                e.HasOne(p => p.User)
                .WithMany(p => p.MovieRatings)
                .HasForeignKey(p => p.UserId)
                .IsRequired(true);

                e.Property(p => p.Rating)
               .IsRequired(true);
            });

            modelBuilder.Entity<Entities.Movie>(e =>
            {
                e.Property(p => p.Title)
                .IsRequired(true);

                e.Property(p => p.MovieType)
                .IsRequired(true);

                e.Property(p => p.MovieKind)
                .IsRequired(true);

                e.Property(p => p.Season)
                .IsRequired(true);

                e.Property(p => p.Episode)
                .IsRequired(true);

                e.Property(p => p.ReleaseAt)
                .IsRequired(false);

                e.Property(p => p.EndAt)
                .IsRequired(false);

                e.Property(p => p.Description)
                .IsRequired(true);

                e.Property(p => p.Duration)
                .IsRequired(true);

                e.Property(p => p.PGRating)
                .IsRequired(true);

                e.Property(p => p.Photo)
                .IsRequired(true);
            });

            modelBuilder.Entity<Person>(e =>
            {
                e.Property(p => p.Name)
                .IsRequired(true);

                e.Property(p => p.Surname)
                .IsRequired(true);

                //e.Property(p => p.Birthday)
                //.IsRequired(false);
                //using (var contex = new MovieContext())
                //{
                //    var std = new Entities.Movie()
                //    {


                //    };
                //    contex.Movie.Add(std);
                //    contex.SaveChanges();
                //}
            });

            modelBuilder.Entity<Character>().ToTable("Chracters");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Genre>().ToTable("Genres");
            modelBuilder.Entity<MovieGenre>().ToTable("MovieGenres");
            modelBuilder.Entity<MovieRating>().ToTable("MovieRatings");
            modelBuilder.Entity<Entities.Movie>().ToTable("Movies");
            modelBuilder.Entity<Person>().ToTable("Persons");
        }
    }
}
