using Microsoft.EntityFrameworkCore.Migrations;

namespace movie_app_task_backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Release_year = table.Column<string>(type: "TEXT", nullable: true),
                    img_url = table.Column<string>(type: "TEXT", nullable: true),
                    isSeries = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorMedia",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "INTEGER", nullable: false),
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMedia", x => new { x.ActorsId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_ActorMedia_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMedia_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rating_value = table.Column<float>(type: "REAL", nullable: false),
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Chris Hemsworth" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "Angelia Ruiz" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Mccullough Curry" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Henry Molina" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Simpson Evans" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Vinson Moran" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "Hinton Love" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "James Hines" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Carver Wong" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Brianna Howe" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Tom Hiddleston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Natalie Portman" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Leon Jarvis" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 15, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 16, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 17, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 18, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 21, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 20, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 22, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 23, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 14, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 19, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 13, "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.", "2018-06-20", "Yellowstone", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 6, "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to", "2013-09-17", "Lord Of The Rings: The Return Of The King", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 11, "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.", "2010-10-31", "The Walking Dead", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 10, "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.", "2013-09-17", "Rick and Morty", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN85RB/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 9, "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.", "2014-12-11", "The Hobbit: The Battle of the Five Armies", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZTH3PF/image?locale=en-nz&purposes=BoxArt&mode=scale&q=90&w=162", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 8, "Bilbo Baggins, a hobbit, and his companions face great dangers on their journey to Laketown. Soon, they reach the Lonely Mountain, where Bilbo comes face-to-face with the fearsome dragon Smaug.", "2013-12-12", "The Hobbit: The Desolation of Smaug", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZJ5NLV/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 7, "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "2013-09-17", "The Hobbit: An Unexpected Journey", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 24, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 5, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 4, "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "2012-12-13", "The Hobbit: An Unexpected Journey", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 3, "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain", "2002-12-18", "Lord Of The Rings: The Two Towers", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 2, "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.", "1977-05-17", "Star Wars: A New Hope", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 1, "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.", "1983-05-25", "Star Wars: Return of the Jedi", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 12, "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.", "2017-09-24", "Star Trek: Discovery", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 25, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 1, 1, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 22, 22, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 21, 21, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 20, 20, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 19, 19, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 18, 18, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 17, 17, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 16, 16, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 15, 15, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 14, 14, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 13, 13, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 12, 12, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 11, 11, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 10, 10, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 9, 9, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 8, 8, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 7, 7, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 6, 6, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 5, 5, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 4, 4, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 3, 3, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 2, 2, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 23, 23, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 24, 24, 4.5f });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMedia_MediaId",
                table: "ActorMedia",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MediaId",
                table: "Ratings",
                column: "MediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMedia");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Medias");
        }
    }
}
