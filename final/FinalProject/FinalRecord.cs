using System;

namespace CSVSearchExportApp
{
    public class FinalRecord
    {
        public string Meat1 { get; set; }
        public string Meat1Photo { get; set; }
        public string Meat1Blurb { get; set; }
        public string Meat2 { get; set; }
        public string Meat2Photo { get; set; }
        public string Meat2Blurb { get; set; }
        public string Meat3 { get; set; }
        public string Meat3Photo { get; set; }
        public string Meat3Blurb { get; set; }

        public string Pairing { get; set; }
        public string PairingPhoto { get; set; }
        public string PairingBlurb { get; set; }

        public string Produce1 { get; set; }
        public string Produce1Photo { get; set; }
        public string Produce1Blurb { get; set; }
        public string Produce2 { get; set; }
        public string Produce2Photo { get; set; }
        public string Produce2Blurb { get; set; }

        public string Cheese1 { get; set; }
        public string Cheese1Photo { get; set; }
        public string Cheese1Blurb { get; set; }
        public string Cheese2 { get; set; }
        public string Cheese2Photo { get; set; }
        public string Cheese2Blurb { get; set; }

        public string Deli1 { get; set; }
        public string Deli1Photo { get; set; }
        public string Deli1Blurb { get; set; }
        public string Deli2 { get; set; }
        public string Deli2Photo { get; set; }
        public string Deli2Blurb { get; set; }

        public string Bakery { get; set; }
        public string BakeryPhoto { get; set; }
        public string BakeryBlurb { get; set; }

        public string Bar1 { get; set; }
        public string Bar1Photo { get; set; }
        public string Bar2 { get; set; }
        public string Bar2Photo { get; set; }
        public string Bar3 { get; set; }
        public string Bar3Photo { get; set; }
        public string Bar4 { get; set; }
        public string Bar4Photo { get; set; }

        public string Grocery1 { get; set; }
        public string Grocery1Photo { get; set; }
        public string Grocery2 { get; set; }
        public string Grocery2Photo { get; set; }
        public string Grocery3 { get; set; }
        public string Grocery3Photo { get; set; }
        public string Grocery4 { get; set; }
        public string Grocery4Photo { get; set; }

        public static string[] GetCsvHeaders()
        {
            return new string[]
            {
                "Listed Item-Meat_1", "@Stock Photo-Meat_1", "Blurb-Meat-1",
                "Listed Item-Meat_2", "@Stock Photo-Meat_2", "Blurb-Meat-2",
                "Listed Item-Meat_3", "@Stock Photo-Meat_3", "Blurb-Meat-3",
                "Listed Item-Pairing", "@Product Photo-Pairing", "Blurb-Pairing",
                "Listed Item-Produce-1", "@Stock Photo-Produce-1", "Blurb-Produce-1",
                "Listed Item-Produce-2", "@Stock Photo-Produce-2", "Blurb-Produce-2",
                "Listed Item-Cheese-1", "@Product Photo-Cheese-1", "Blurb-Cheese-1",
                "Listed Item-Cheese-2", "@Product Photo-Cheese-2", "Blurb-Cheese-2",
                "Listed Item-Deli-1", "@Stock Photo-Deli-1", "Blurb-Deli-1",
                "Listed Item-Deli-2", "@Stock Photo-Deli-2", "Blurb-Deli-2",
                "Listed Item-Bakery", "@Product Photo-Bakery", "Blurb-Bakery",
                "Listed Item-Bar-1", "@Product Photo-Bar-1", "Listed Item-Bar-2", "@Product Photo-Bar-2",
                "Listed Item-Bar-3", "@Product Photo-Bar-3", "Listed Item-Bar-4", "@Product Photo-Bar-4",
                "Listed Item-Grocery-1", "@Product Photo-Grocery-1", "Listed Item-Grocery-2", "@Product Photo-Grocery-2",
                "Listed Item-Grocery-3", "@Product Photo-Grocery-3", "Listed Item-Grocery-4", "@Product Photo-Grocery-4"
            };
        }

        public string[] ToCsvRow()
        {
            return new string[]
            {
                Meat1, Meat1Photo, Meat1Blurb,
                Meat2, Meat2Photo, Meat2Blurb,
                Meat3, Meat3Photo, Meat3Blurb,
                Pairing, PairingPhoto, PairingBlurb,
                Produce1, Produce1Photo, Produce1Blurb,
                Produce2, Produce2Photo, Produce2Blurb,
                Cheese1, Cheese1Photo, Cheese1Blurb,
                Cheese2, Cheese2Photo, Cheese2Blurb,
                Deli1, Deli1Photo, Deli1Blurb,
                Deli2, Deli2Photo, Deli2Blurb,
                Bakery, BakeryPhoto, BakeryBlurb,
                Bar1, Bar1Photo, Bar2, Bar2Photo, Bar3, Bar3Photo, Bar4, Bar4Photo,
                Grocery1, Grocery1Photo, Grocery2, Grocery2Photo, Grocery3, Grocery3Photo, Grocery4, Grocery4Photo
            };
        }
    }
}
