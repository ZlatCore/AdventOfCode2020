using System;
using System.Collections.Generic;
using System.Text;

namespace dec04
{
    public class ScanData
    {
        public int BirthYear { get; set; }
        public int IssueYear { get; set; }
        public int ExpirationYear { get; set; }
        public string Heigth { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string PassportId { get; set; }
        public string CountryId { get; set; }
        public int FieldCount = 0;

        public bool ScannedRequired
        {
            get { return this.fieldsScanned >= 7; }
        }

        public bool NotValid
        {
            get { return (this.fieldsScanned < 7) || (!string.IsNullOrWhiteSpace(this.CountryId) && this.fieldsScanned == 7); }
        }

        public bool Valid
        {
            get { return (this.fieldsScanned == 8) || (string.IsNullOrWhiteSpace(this.CountryId) && this.fieldsScanned == 7); }
        }

    private string[] scanInput;
        public int fieldsScanned;

        private ScanData()
        {
            BirthYear = 0;
            IssueYear = 0;
            ExpirationYear = 0;
            Heigth = string.Empty;
            HairColor = string.Empty;
            EyeColor = string.Empty;
            PassportId = string.Empty;
            CountryId = string.Empty;
            this.fieldsScanned = 0;
        }
        public ScanData(string[] input) : base()
        {
            this.scanInput = input;

            foreach (var inputLine in input)
            {
                var singleValues = inputLine.Split(" ");
                foreach (var entry in singleValues)
                {

                    var pair = entry.Split(":");
                    if (pair[0] != "cid")
                    {
                        this.FieldCount++;
                    }
                    this.FillAppropriate(pair);
                }
            }

        }

        public bool ValidateFull()
        {
            bool result = true;
            if (this.FieldCount < 7)
            {
                return false;
            }

            if (this.BirthYear < 1920 || this.BirthYear > 2002)
            {
                return false;
            }

            if (this.IssueYear < 2010 || this.IssueYear > 2020)
            {
                return false;
            }

            if (this.ExpirationYear < 2020 || this.ExpirationYear > 2030)
            {
                return false;
            }


            var hunit = this.Heigth.Substring(Math.Max(0, this.Heigth.Length - 2));
            var hvalues = this.Heigth.Substring(0, Math.Max(0, this.Heigth.Length - 2));
            int hvalue = int.Parse(hvalues);
            if (hunit == "cm")
            {
                if (hvalue < 150 || hvalue > 193)
                {
                    return false;
                }
            }
            else if (hunit == "in")
            {
                if (hvalue < 59 || hvalue > 76)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            try
            {
                var color = System.Drawing.ColorTranslator.FromHtml(this.HairColor);
                if (color.IsEmpty)
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

            //amb blu brn gry grn hzl oth.
            var eyeColors = new List<string>() { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
            if (!eyeColors.Contains(this.EyeColor))
            {
                return false;
            }

            if (this.PassportId.Length != 9)
            {
                return false;
            }

            foreach (char c in this.PassportId)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return result;
        }

        public bool IsValidExceptCid()
        {
            bool result = BirthYear != null && BirthYear != 0;
            result &= IssueYear != null && IssueYear != 0;
            result &= ExpirationYear != null && ExpirationYear != 0;
            result &= Heigth != null && Heigth != string.Empty;
            result &= HairColor != null && HairColor != string.Empty;
            result &= EyeColor != null && EyeColor != string.Empty;
            result &= PassportId != null && PassportId != string.Empty;

            return result;
        }

        private void FillAppropriate(string[] pair)
        {
            this.fieldsScanned++;
            switch (pair[0])
            {
                case "byr":
                    BirthYear = int.Parse(pair[1]);
                    break;
                case "iyr":
                    IssueYear = int.Parse(pair[1]);
                    break;
                case "eyr":
                    ExpirationYear = int.Parse(pair[1]);
                    break;
                case "hgt":
                    Heigth = pair[1];
                    break;
                case "hcl":
                    HairColor = pair[1];
                    break;
                case "ecl":
                    EyeColor = pair[1];
                    break;
                case "pid":
                    PassportId = pair[1];
                    break;
                case "cid":
                     CountryId = pair[1];
                    break;
            }
        }
    }
}
