using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApp.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Red Dead Redemption is a 2010 action-adventure game developed by Rockstar San Diego and published by Rockstar Games. A spiritual successor to 2004's Red Dead Revolver, it is the second game in the Red Dead series. Red Dead Redemption is set during the decline of the American frontier in the year 1911 and follows John Marston, a former outlaw whose wife and son are taken hostage by the government in ransom for his services as a hired gun. Having no other choice, Marston sets out to bring three members of his former gang to justice.", "https://upload.wikimedia.org/wikipedia/en/a/a7/Red_Dead_Redemption.jpg", 19.79m, "Red Dead Redemption" },
                    { 2, "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh main entry in the Grand Theft Auto series, following 2008's Grand Theft Auto IV, and the fifteenth instalment overall. Set within the fictional state of San Andreas, based on Southern California, the single-player story follows three protagonists—retired bank robber Michael De Santa, street gangster Franklin Clinton, and drug dealer and gunrunner Trevor Philips—and their attempts to commit heists while under pressure from a corrupt government agency and powerful criminals. The open world design lets players freely roam San Andreas' open countryside and the fictional city of Los Santos, based on Los Angeles.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", 19.99m, "Grand Theft Auto V" },
                    { 3, "Wolfenstein II: The New Colossus is a 2017 action-adventure first-person shooter video game developed by MachineGames and published by Bethesda Softworks. It was released on 27 October 2017 for Microsoft Windows, PlayStation 4, and Xbox One, and was released on 29 June 2018 for Nintendo Switch. The eighth main entry in the Wolfenstein series and the sequel to 2014's Wolfenstein: The New Order, the game is set in an alternate history which takes place in 1961 following the Nazi victory in the Second World War. The story follows war veteran William Blazkowicz and his efforts to fight against the Nazi regime in the United States.", "https://upload.wikimedia.org/wikipedia/en/5/54/Wolfenstein-ii-the-new-colossus-cover.jpeg", 39.99m, "Wolfenstein II: The New Colossus" },
                    { 4, "Call of Duty: Black Ops is a 2010 first-person shooter game developed by Treyarch and published by Activision. It was released worldwide in November 2010 for Microsoft Windows, the PlayStation 3, Wii, and Xbox 360, with a separate version for Nintendo DS developed by n-Space. Aspyr later released the game for OS X in September 2012. It is the seventh title in the Call of Duty series and the sequel to Call of Duty: World at War.", "https://upload.wikimedia.org/wikipedia/en/0/02/CoD_Black_Ops_cover.png", 35.98m, "Call of Duty: Black Ops" },
                    { 5, "Battlefield 1 is a first-person shooter game developed by DICE and published by Electronic Arts. It is the tenth installment in the Battlefield series and the first main entry in the series since Battlefield 4 in 2013. It was released for Microsoft Windows, PlayStation 4 and Xbox One in October 2016.", "https://upload.wikimedia.org/wikipedia/en/f/fc/Battlefield_1_cover_art.jpg", 19.20m, "Battlefield 1" },
                    { 6, "NBA 2K23 is a basketball video game developed by Visual Concepts and published by Take-Two Interactive under the 2K label, based on the National Basketball Association (NBA). It is the 24th installment in the NBA 2K franchise and the successor to NBA 2K22. The game was released on September 9, 2022 for Microsoft Windows, Nintendo Switch, PlayStation 4, PlayStation 5, Xbox One, and Xbox Series X/S. The NBA 2K23 Arcade Edition will be released on Apple Arcade on October 18, 2022.", "https://upload.wikimedia.org/wikipedia/en/d/d7/NBA_2K23_cover_art.jpg", 69.99m, "NBA 2K23" },
                    { 7, "The Elder Scrolls V: Skyrim is an action role-playing video game developed by Bethesda Game Studios and published by Bethesda Softworks. It is the fifth main installment in the Elder Scrolls series, following 2006's The Elder Scrolls IV: Oblivion, and was released worldwide for Microsoft Windows, PlayStation 3, and Xbox 360 on November 11, 2011.", "https://upload.wikimedia.org/wikipedia/en/1/15/The_Elder_Scrolls_V_Skyrim_cover.png", 49.99m, "The Elder Scrolls V: Skyrim" },
                    { 8, "Borderlands 2 is a 2012 first-person shooter video game developed by Gearbox Software and published by 2K Games. Taking place five years following the events of Borderlands (2009), the game is once again set on the planet of Pandora. The story follows a new group of Vault Hunters who must ally with the Crimson Raiders, a resistance group made up of civilian survivors and guerrilla fighters, to defeat the tyrannical Handsome Jack before he can unlock the power of a new Vault. The game features the ability to explore the in-game world and complete both main missions and optional side quests, either in offline splitscreen, single-player or online cooperative gameplay. Like its predecessor, the game features a procedurally generated loot system which is capable of generating numerous combinations of weapons and other gear.", "https://upload.wikimedia.org/wikipedia/en/5/51/Borderlands_2_cover_art.png", 14.87m, "Borderlands 2" },
                    { 9, "Star Wars Jedi: Fallen Order is an 2019 action-adventure game developed by Respawn Entertainment and published by Electronic Arts. The story, set in the Star Wars universe five years after Star Wars: Episode III – Revenge of the Sith, follows Jedi Padawan Cal Kestis, who becomes a target of the Galactic Empire and is hunted throughout the galaxy by the Imperial Inquisitorius while attempting to complete his training, reconcile with his troubled past, and rebuild the fallen Jedi Order. In the game, Cal can use his lightsaber and Force powers to defeat enemies ranging from stormtroopers to wild beasts that are native to each planet he explores. The game adopts a Metroidvania style of exploration and progression, as each location is filled with multiple shortcuts and secret rooms that are inaccessible until Cal gains the appropriate abilities or tools.", "https://upload.wikimedia.org/wikipedia/en/1/13/Cover_art_of_Star_Wars_Jedi_Fallen_Order.jpg", 28.24m, "Star Wars Jedi: Fallen Order" },
                    { 10, "The Last of Us is a 2013 action-adventure game developed by Naughty Dog and published by Sony Computer Entertainment. Players control Joel, a smuggler tasked with escorting a teenage girl, Ellie, across a post-apocalyptic United States. The Last of Us is played from a third-person perspective. Players use firearms and improvised weapons, and can use stealth to defend against hostile humans and cannibalistic creatures infected by a mutated fungus in the genus Cordyceps. In the online multiplayer mode, up to eight players engage in cooperative and competitive gameplay.", "https://upload.wikimedia.org/wikipedia/en/4/46/Video_Game_Cover_-_The_Last_of_Us.jpg", 17.69m, "The Last of Us" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
