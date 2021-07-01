using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Identity;
using sykeplayer_1.Models;

namespace sykeplayer_1.Data
{
    public class questionDbInitializer
    {
        public static void Initialize(ApplicationDbContext context, UserManager<ApplicationUser> um, RoleManager<IdentityRole> rm)
        {
            // Delete the database before we initialize it.    
            // This is common to do during development.
            //context.Database.EnsureDeleted();

            // Make sure the database and tables exist
            //context.Database.EnsureCreated();
            var db = context;
            

            // Test data is typically added here
          
            /*
            
            var hansHansen = new Character()
            {
                Id = "HansHansen", Description = "Dette er Hans Hansen",
                ImageUrl = "Hanshansennytral.gif"
            };
            db.Characters.Add(hansHansen);
            var karstein = new Character()
            {
                Id = "Karstein", Description = "Dette er Karstein",
                ImageUrl = "Karstein.gif"
            };
            db.Characters.Add(karstein);
            var merethe = new Character()
            {
                Id = "Merethe", Description = "Dette er Merethe",
                ImageUrl = "Merethe.gif"
            };
            db.Characters.Add(merethe);
            var linda = new Character()
            {
                Id = "Linda", Description = "Dette er Linda",
                ImageUrl = "Lindanytral.gif"
            };
            db.Characters.Add(linda);
            var tore = new Character()
            {
                Id = "Tore", Description = "Dette er Tore Hansen",
                ImageUrl = "ToreHansen.gif"
            };
            db.Characters.Add(tore);
            
            */
            
            /*
            var adminRole = new IdentityRole("Admin");
            rm.CreateAsync(adminRole).Wait();

            var adminUser = new ApplicationUser
            {
                Nickname = "AdminUser",
                Name = "Admin",
                Email = "admin@uia.no",
                UserName = "admin@uia.no",
                EmailConfirmed = true
            };
            um.CreateAsync(adminUser, "Passord1.").Wait();
            um.AddToRoleAsync(adminUser, "Admin").Wait();

            var Index = new IndexInfo()
            {
                Html = "<h1>Hei og velkommen til SykePlayer</h1>", Id = "Index"
            };
            db.IndexInfo.Add(Index);*/
            
            //context.Questions.Add(new Questions(0, "funker dette00?", "ja00", "nei00", "kanskje00", "vet ikke", 1));
            //context.Questions.Add(new Questions(1, "funker dette?", "ja", "nei", "kanskje", "vet ikke", 0));
            

            // Finally save changes to the database
            
            /*
            var GPS = new GameModel()
            {
                Description = "Test av ekte scenario fra sykepleien", Version = 1, DisplayName = "GPS", Id = "GPS", MaxPoints = 200, Visible = true, LastModified = DateTime.Now
            };


            
            db.Games.Add(GPS);
            
            /* standard for hvordan question ser ut
               var GPS7 = new Questions
            {
                Nr = 7, Question = "...",
                Answer1 = "", Answer2 = "", Answer3 = "", Answer4 = "",
                Next1 = 5, Next2 = 2, Next3 = 3, Next4 = 4, Image = "Merethe.gif",
                GameModel = GPS
            };
            db.Questions.Add(GPS7);
             */
            
            
            /*
            var GPS1 = new Questions
            {
                Id = "GPS1",Nr = 1, Question = "Du er sykepleier i hjemmetjenesten i din kommune. Hans Hansen er 83 år, og bor alene i en leilighet. Han har flere kroniske sykdommer, og får tilsyn av hjemmetjenesten for hjelp med medisiner og hjelp til dusj. Du blir kontaktet av hans sønn Lars på telefon",
                Answer1 = "Neste", Answer2 = "", Answer3 = "",
                Answer4 = "", Next1 = 2,Image = "Merethe.gif", GameModel = GPS, Type = Questions.QuestionType.Standard
            };
            db.Questions.Add(GPS1);
            
            var GPS2 = new Questions
            {
                Id = "GPS2",Nr = 2, Question = "...",
                Answer1 = "Hei lars, hva kan jeg hjelpe deg med?",  Next1 = 3, Image = "ToreHansen.gif", GameModel = GPS, Type = Questions.QuestionType.Standard
            };
            db.Questions.Add(GPS2);
            
            var GPS3 = new Questions
            {
                Id = "GPS3",Nr = 3, Question = "Hei, ja nå er det jo slik at pappa er begynt å bli litt rotete, ja det vet dere jo. Han finner jo av og til ikke helt veien så godt som før. Naboen har gitt meg beskjed om at han av og til har måttet vise ham til rett inngangsdør i blokka.",
                Answer1 = "Neste",  Next1 = 4, Image = "ToreHansen.gif", GameModel = GPS, Type = Questions.QuestionType.Standard
            };
            db.Questions.Add(GPS3);
            
            var GPS4 = new Questions
            {
                Id = "GPS4",Nr = 4, Question = "Han er jo sprek og går masse på tur, så vi vil gjerne at han får en sånn GPS-sak-slik at dere kan følge med på hvor han er",
                Answer1 = "ja, du mener kanskje en trygghetsalarm med GPS som han kan utløse ved behov?",
                Answer2 = "Tenker du på overvåking ved hjelp av GPS-armbånd eller GPS-brikke?", Answer3 = "", Answer4 = "",
                Next1 = 5, Next2 = 5, Next3 = 3, Next4 = 4, Image = "ToreHansen.gif", GameModel = GPS, Type = Questions.QuestionType.Standard
            };
            db.Questions.Add(GPS4);
            
            var GPS5 = new Questions
            {
                Id = "GPS5",Nr = 5, Question = "Jeg mener en GPS som han kan ha på armen sånn at dere kan se hvor han er, -det har vi krav på å få, ikke sant?",
                Answer1 = "Ja, det har dere",
                Answer2 = "Nei, det har dere ikke krav på",
                Answer3 = "Vi har tilbud om dette i kommunen, men vi må vurdere om dette er aktuelt for Hans",
                Answer4 = "",
                Next1 = 6, Next2 = 7, Next3 = 8, Next4 = 4, Image = "ToreHansen.gif", GameModel = GPS, Type = Questions.QuestionType.Standard
            };
            db.Questions.Add(GPS5);
            
            var GPS6 = new Questions
            {
                Id = "GPS6",Nr = 6, Question = "Dette er feil. I følge Pasient- og brukerrettighetsloven (https://lovdata.no/dokument/NL/lov/1999-07-02-63) har pasienter og brukere rett til nødvendige helse- og omsorgstjenester fra kommunen og spesialisthelsetjenesten. Det er imidlertid kommunen som avgjør hvordan et tjenestetilbud skal utformes, herunder om velferdsteknologi skal inngå i tjenestetilbudet. Etter pasient- og brukerrettighetsloven § 3-1 har imidlertid pasient og bruker rett til å medvirke til utformingen av tjenestetilbudet og gjennomføringen av tjenesten",
                Answer1 = "Start på nytt", 
                Next1 = 1, Image = "Toreglad.gif",
                GameModel = GPS,
                Type = Questions.QuestionType.TextBox
            };
            db.Questions.Add(GPS6);
            
            
            
            var GPS7 = new Questions
            {
                Id = "GPS7",Nr = 7, Question = "Men vil dere ikke uansett se på om han bør få dette?",
                Answer1 = "Hva tenker Hans om dette selv?",
                Answer2 = "Jeg kan selvfølgelig undersøke om Hans kan ha rett til og behov for dette",
                Next1 = 9, Next2 = 10, Image = "ToreHansen.gif",
                GameModel = GPS,
                Type = Questions.QuestionType.Standard
            };
            db.Questions.Add(GPS7);
            
            var GPS8 = new Questions
            {
                Id = "GPS8",Nr = 8, Question = "Men vil dere ikke uansett se på om han bør få dette?",
                Answer1 = "Hva tenker Hans om dette selv?", 
                Answer2 = "Jeg kan selvfølgelig undersøke om Hans kan ha rett til og behov for dette",
                Next1 = 9, Next2 = 10, Image = "Toresure.gif",
                GameModel = GPS,
                Type = Questions.QuestionType.Standard
            };
            db.Questions.Add(GPS8);
            
            var GPS9 = new Questions
            {
                Id = "GPS9",Nr = 9, Question = "Det har han vi ikke spurt ham om, han vet jo ikke sitt eget beste. Er ikke dette noe vi kan bestemme?",
                Answer1 = "Nei, dette må vi nok involvere Hans i",
                Answer2 = "OK, hvis dere som pårørende mener det, så skal jeg ta det videre", 
                Next1 = 12, Next2 = 11,  Image = "Toresure.gif",
                GameModel = GPS,
                Type = Questions.QuestionType.Standard
            };
            db.Questions.Add(GPS9);
            
            var GPS10 = new Questions
            {
                Id = "GPS10",Nr = 10, Question = "Fint, da ordner du det",
                Answer1 = "Neste", Answer2 = "", Answer3 = "", Answer4 = "",
                Next1 = 11, Image = "Toreglad.gif",
                GameModel = GPS,
                Type = Questions.QuestionType.Standard
            };
            db.Questions.Add(GPS10);
            
            var GPS11 = new Questions
            {
                Id = "GPS11",Nr = 11, Question = "Dette er feil. Hvis pasienten eller brukeren mangler samtykkekompetanse, har nærmeste pårørende rett til å medvirke sammen med pasienten. Pasientens eller brukerens tilstand og funksjonsnivå avgjør om han eller hun selv kan delta i medvirkningen, eller om nærmeste pårørende må ivareta retten til å medvirke på en mer selvstendig måte. Det er viktig å huske at pårørende bare har rett til å medvirke så langt medvirkningen er i pasientens eller brukerens interesse.",
                Answer1 = "Neste", Answer2 = "", Answer3 = "", Answer4 = "",
                Next1 = 13, Image = "Toreglad.gif",
                GameModel = GPS,
                Type = Questions.QuestionType.TextBox
            };
            db.Questions.Add(GPS11);
            
            var GPS12 = new Questions
            {
                Id = "GPS12",Nr = 12, Question = "Dette er riktig. Men hvis pasienten eller brukeren mangler samtykkekompetanse, har nærmeste pårørende rett til å medvirke sammen med pasienten. Pasientens eller brukerens tilstand og funksjonsnivå avgjør om han eller hun selv kan delta i medvirkningen, eller om nærmeste pårørende må ivareta retten til å medvirke på en mer selvstendig måte. Det er viktig å huske at pårørende bare har rett til å medvirke så langt medvirkningen er i pasientens eller brukerens interesse.",
                Answer1 = "Neste", Answer2 = "", Answer3 = "", Answer4 = "",
                Next1 = 13, Next2 = 2, Next3 = 3, Next4 = 4, Image = "Toresure.gif",
                GameModel = GPS,
                Type = Questions.QuestionType.TextBox
            };
            db.Questions.Add(GPS12);
            
            var GPS13= new Questions
            {
                Id = "GPS13",Nr = 13, Question = "Hvem vil du snakke med nå?",
                Answer1 = "Hans", Answer2 = "Leder", Answer3 = "", Answer4 = "",
                Next1 = 14, Next2 = 15, Next3 = 3, Next4 = 4, Image = "ToreHansen.gif",
                GameModel = GPS,
                Type = Questions.QuestionType.Character
            };
            db.Questions.Add(GPS13);

            var adminRole = new IdentityRole("Admin");
            rm.CreateAsync(adminRole).Wait();

            var adminUser = new ApplicationUser
            {
                Nickname = "AdminUser",
                Name = "Admin",
                Email = "admin@uia.no",
                UserName = "admin@uia.no",
                EmailConfirmed = true
            };
            um.CreateAsync(adminUser, "Passord1.").Wait();
            um.AddToRoleAsync(adminUser, "Admin").Wait();

            var Index = new IndexInfo()
            {
                Html = "<h1>Hei og velkommen til SykePlayer</h1>", Id = "Index"
            };
            db.IndexInfo.Add(Index);
            var testGame = new GameModel()
            {
                Id = "Test", Version = 1, Visible = true
            };
            db.Games.Add(testGame);
            var testQ = new Questions()
            {
                Id = "Testv1", Question = "idk kev", Answer1 = "lole", Nr = 1, GameModel = testGame
                ,Type = Questions.QuestionType.LastQuestion
            };
            db.Questions.Add(testQ);
            */
            
            context.SaveChanges();
        }
    }
}
