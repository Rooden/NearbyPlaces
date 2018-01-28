namespace NearbyPlaces.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Places (Name, Longitude, Latitude) VALUES ('Test', 10, 20),
                    ('Kupol, Lviv', 24.027191, 49.83574),
                    ('Lviv High Castle Park', 24.039352, 49.848112),
                    ('Lviv Beer Brewing Museum', 24.015577, 49.848568),
                    ('Lviv National Academic Opera and Ballet Theatre ', 24.026134, 49.84414),
                    ('Lviv Latin Cathedral', 24.030458, 49.840729),
                    ('St. George’s Cathedral, Lviv ', 24.012465, 49.838633),
                    ('Bernardine Church and Monastery, Lviv', 24.034696, 49.839408),
                    ('Lviv Armenian Cathedral', 24.031032, 49.843189),
                    ('Italian Yard, Lviv', 24.031595, 49.841961),
                    ('Hyatt Regency Kiev Hotel', 30.518367, 50.453242),
                    ('Arena Entertainment, Kiev', 30.52018, 50.440862),
                    ('Musuem of Folk Architecture and Life, Kiev', 30.513153, 50.354032),
                    ('Marinsky Palace, Kiev', 30.537379, 50.44835),
                    ('Verkhovna Rada (Supreme Council of Ukraine), Kiev', 30.536901, 50.44724),
                    ('St. Michael’s Monastery of the Golden Domes, Kiev', 30.522659, 50.455619),
                    ('Hydropark', 30.576303, 50.446123),
                    ('Ukrainian House, Kiev', 30.526741, 50.453177),
                    ('St. Sophia’s Cathedral, Kiev', 30.514269, 50.452886),
                    ('Museum of the Great Patriotic War, Kiev', 30.562999, 50.426538),
                    ('St. Volodymyr’s Cathedral, Kiev', 30.508647, 50.44464),
                    ('Ukrainian National Opera House, Kiev', 30.512627, 50.446642),
                    ('Independence Square (Maidan Nezalezhnosti), Kiev', 30.522627, 50.450933),
                    ('Donetsk Theatre of Opera and Ballet', 37.802807, 48.005975),
                    ('Donbass Palace Hotel, Donetsk', 37.804046, 48.003591),
                    ('Donetsk Regional Museum of Art', 37.800382, 48.008322),
                    ('Donetsk Digital Planetarium', 37.803655, 47.99214),
                    ('Donbass Arena, Donetsk', 37.810092, 48.021054),
                    ('Lenin Square (Ploshchad Lenina), Donetsk', 37.805068, 48.002019),
                    ('Detroit, Donetsk', 37.8295, 48.001283),
                    ('Park of Forged Figures, Donetsk', 37.800157, 48.015908),
                    ('The Cathedral of Christ Transfigured, Donetsk', 37.805307, 48.010425),
                    ('Sherbakova Amusement Park, Donetsk', 37.790608, 47.994919),
                    ('Metsalov’s Palm, Donetsk', 37.805827, 48.024846),
                    ('John James Hughes Brewery, Donetsk', 37.806154, 48.009388),
                    ('Freedom Square, Kharkiv', 36.229091, 50.005808),
                    ('Kharkiv Railway Station', 36.206367, 49.989353),
                    ('The N. Lysenko National Academic Opera and Ballet Theater, Kharkiv', 36.232304, 49.999123),
                    ('Blagoveschensky Cathedral, Kharkiv', 36.22407, 49.990532),
                    ('Uspensky Cathedral, Kharkiv', 36.230786, 49.989901),
                    ('Pokrovsky Cathedral, Kharkiv', 36.229107, 49.991715),
                    ('Kharkiv Historical Museum', 36.230485, 49.992664),
                    ('Kharkiv Museum of Art', 36.238559, 49.999043),
                    ('Irish Pub, Kharkiv', 36.239028, 50.006572),
                    ('InterContinental Kiev', 30.519387, 50.455496),
                    ('Hotel Gintama', 30.523646, 50.454307),
                    ('KievInn', 30.521897, 50.452531),
                    ('St Andrew’s Church', 30.518003, 50.458952)");
        }
        
        public override void Down()
        {
        }
    }
}
