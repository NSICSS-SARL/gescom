using System;
using System.Collections.Generic;
using System.Globalization;

namespace gescom.data.Models
{
    public static class StdCalcul
    {
        public static string AfficherPrix(double prix)
        {
            prix = Math.Round(prix);
            return prix.ToString(CultureInfo.InvariantCulture);
        }

        public static bool ComparaisonChaine(string entre, string code)
        {
            if (entre != null)
            {
                int n = entre.Length;
                int c = code.Length;
                if (n <= c)
                {
                    string s = code.Substring(0, n);
                    entre = entre.ToUpper();
                    s = s.ToUpper();
                    if (entre == s)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        public static bool CompareChaineCentre(string strFixe, string strVar)
        {
            if (strVar == null)
            {
                return true;
            }
            if (strFixe == null)
            {
                return false;
            }
            int longFixe = strFixe.Length;
            int longVar = strVar.Length;
            strFixe = strFixe.ToUpper();
            strVar = strVar.ToUpper();
            string str;
            if (longFixe >= longVar)
            {
                str = strFixe.Substring(0, longVar);
                if (str == strVar)
                {
                    return true;
                }
            }
            else
            {
                str = strVar.Substring(0, longFixe);
                if (str == strFixe)
                {
                    return true;
                }
            }
            return false;
        }

        // comparer les deux premiers nombres au préfix.
        public static bool ComparerNombre(int fixe, string chaineVariable)
        {
            if (chaineVariable == null)
            {
                return true;
            }
            int longueurChaine = chaineVariable.Length;
            string s = fixe.ToString(CultureInfo.InvariantCulture);
            int longueurChiffre = s.Length;
            string str = chaineVariable;
            if (longueurChiffre >= longueurChaine)
            {
                s = s.Substring(0, longueurChaine);
            }
            else
            {
                str = chaineVariable.Substring(0, longueurChiffre);
            }
            if (str == s)
            {
                return true;
            }
            return false;
        }

        public static int CountPlaceContenance(long id)
        {
            var query = new MssqlQuery("DistItem");
            int result = query.CountRecordsByNumero(id);
            return result;
        }

        public static bool DateIntervalValidation(DateTime debut, DateTime fin)
        {
            if (!MonthIntevalValidation(debut, fin)) { return false; }
            int dayEnd = fin.Day;
            int dayBegin = debut.Day;
            if (dayBegin >= dayEnd) { return false; }
            if (dayEnd - dayBegin > 31) { return false; }
            if (debut.Month == 2)
            {
                if (dayEnd - dayBegin > 29) { return false; }
            }
            if (dayBegin != 1) { return false; }
            if (fin.Month == 2)
            {
                if (fin.Day == 28)
                {
                    return true;
                }
            }
            int dayEndValid = EndMonth(fin);
            if (dayEndValid == dayEnd) { return true; }
            return false;
        }

        public static bool DateValidation(DateTime debut, DateTime fin)
        {
            if (fin.Date >= debut.Date)
            {
                return true;
            }
            return true;
        }

        public static double DecimalToDouble(decimal d)
        {
            string s = d.ToString(CultureInfo.InvariantCulture);
            double result = double.Parse(s);
            return result;
        }

        public static float DecimalToFloat(decimal d)
        {
            string s = d.ToString(CultureInfo.InvariantCulture);
            float result = float.Parse(s);
            return result;
        }

        public static bool DoubleConversion(string text)
        {
            var n = 0.0;
            bool result = true;
            try
            {
                n = double.Parse(text);
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public static decimal DoubleToDecimal(double d)
        {
            string s = d.ToString(CultureInfo.InvariantCulture);
            decimal result = decimal.Parse(s);
            return result;
        }

        public static string DoubleToSpaceFormat(double f)
        {
            string s = f.ToString(CultureInfo.InvariantCulture);
            return Spacing(s);
        }

        public static bool EntierConversion(string text)
        {
            var n = 0;
            bool result = true;
            try
            {
                n = int.Parse(text);
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public static string FormatEnLettre(double chiffre)
        {
            Int64 c = DoubleVersEntier(chiffre);
            string converted = Milliard(c);
            int n = converted.Length;
            if (n > 0)
            {
                string prefix = converted.Substring(0, 1);
                prefix = prefix.ToUpper();
                n -= 1;
                string suffix = converted.Substring(1, n);
                converted = prefix + suffix;
            }
            return converted;
        }

        public static string FormatGasy(double chiffre)
        {
            return FormatEnLettre(chiffre) + @" Ariary.";
        }

        public static string Formating(string text)
        {
            string result = "0";
            int n = text.Length;
            if (n > 0)
            {
                result = n > 3 ? StringFormat(text) : text;
            }
            return result;
        }

        public static int GetCategoryId(string nom)
        {
            var query = new MssqlQuery("FamilleItem");
            int result = query.SelectIdByName(nom);
            return result;
        }

        public static double GetCoefficient(double rate)
        {
            rate = rate / 100;
            double result = 1 + rate;
            return result;
        }

        public static float GetCoefficientF(float rate)
        {
            rate = rate / 100;
            float result = 1 + rate;
            return result;
        }

        public static double GetCompleteLisse(double prix, double rate)
        {
            return LissagePrix(GetPrixComplete(prix, rate));
        }

        public static float GetCompleteLisseF(float prix, float rate)
        {
            return LissagePrixF(GetPrixCompleteF(prix, rate));
        }

        public static int GetIndexList(List<string> liste, string name)
        {
            int count = 0;
            int result = 0;
            if (liste.Count <= 0) return -1;
            foreach (string t in liste)
            {
                count++;
                if (t == name)
                {
                    result = count;
                }
            }
            return result;
        }

        // obtenir le nombre de caractères avant entrée de chaînes
        public static int GetlastNumber(string chaine)
        {
            //nombre de caractères.
            int n = chaine.Length;
            // compter nombre de caractères dans la chaîne.
            int p = 0;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                char c = chaine[i];
                if ((c == '0') || (c == '1') || (c == '2') || (c == '3') || (c == '4') || (c == '5') || (c == '6') ||
                    (c == '7') || (c == '8') || (c == '9'))
                {
                    p += 1;
                }
            }
            if (p > 0)
            {
                for (int j = 0; j < p; j++)
                {
                    char c = chaine[j];
                    if ((c == '0') || (c == '1') || (c == '2') || (c == '3') || (c == '4') || (c == '5') || (c == '6') ||
                        (c == '7') || (c == '8') || (c == '9'))
                    {
                        result++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result;
        }

        // obtenir le numéro correspondant aux chiffres consécutifs avant entrées de chaîne*/
        public static int GetNumeroPreced(string chaine)
        {
            int z = GetlastNumber(chaine);
            if (z > 0)
            {
                string s = chaine.Substring(0, z);
                int result = int.Parse(s);
                return result;
            }
            return -1;
        }

        public static double GetPrixComplete(double prix, double rate)
        {
            prix = prix * GetCoefficient(rate);
            return prix;
        }

        public static float GetPrixCompleteF(float prix, float rate)
        {
            prix = prix * GetCoefficientF(rate);
            return prix;
        }

        public static double GetPrixLisse(double prix)
        {
            return LissagePrix(prix);
        }

        public static double GetSimpleLisse(double prix)
        {
            return LissageSimple(prix);
        }

        public static float GetSimpleLisseF(float prix)
        {
            return LissageSimpleF(prix);
        }

        public static double GetTaxe()
        {
            var query = new MssqlQuery();
            return query.GetTaxe();
        }

        public static double GetTaxeFraction()
        {
            double taux = GetTaxe();
            return taux / 100;
        }

        public static string GetTexteNext(string chaine)
        {
            int longueurChaine = chaine.Length;
            int longueurNumero = GetlastNumber(chaine);
            // obtenir le numéro.
            int nb = GetNumeroPreced(chaine);
            if (nb > 0)
            {
                if (longueurChaine > longueurNumero)
                {
                    string result = chaine.Substring(longueurNumero, longueurChaine - longueurNumero);
                    return result;
                }
            }
            return null;
        }

        public static int GetUnityId(string nom)
        {
            var query = new MssqlQuery("UniteItem");
            int result = query.SelectIdByName(nom);
            return result;
        }

        public static int GetVendorId(string nom)
        {
            var query = new MssqlQuery("PersonItem");
            int result = query.SelectIdByName(nom);
            return result;
        }

        public static double LissagePrix(double prix)
        {
            // arrondir le nombre
            double result = Math.Round(prix);
            if (result <= 0)
            {
                return 0;
            }
            if (result <= 10)
            {
                return result;
            }
            if (result <= 100)
            {
                result /= 10;
                result = Math.Round(result);
                result *= 10;
                return result;
            }
            result /= 100;
            result = Math.Round(result);
            result *= 100;
            return result;
        }

        public static float LissagePrixF(float prix)
        {
            // arrondir le nombre
            var result = (float)Math.Round(prix);
            if (result <= 0)
            {
                return 0;
            }
            if (result <= 10)
            {
                return result;
            }
            if (result <= 100)
            {
                result /= 10;
                result = (float)Math.Round(result);
                result *= 10;
                return result;
            }
            result /= 100;
            result = (float)Math.Round(result);
            result *= 100;
            return result;
        }

        public static double LissageSimple(double prix)
        {
            // arrondir le nombre
            double result = Math.Round(prix);
            if (result <= 0)
            {
                return 0;
            }
            if (result <= 10)
            {
                return result;
            }
            result /= 10;
            result = Math.Round(result);
            result *= 10;
            return result;
        }

        public static float LissageSimpleF(float prix)
        {
            // arrondir le nombre
            var result = (float)Math.Round(prix);
            if (result <= 0)
            {
                return 0;
            }
            if (result <= 10)
            {
                return result;
            }
            result /= 10;
            result = (float)Math.Round(result);
            result *= 10;
            return result;
        }

        public static bool MonthIntevalValidation(DateTime debut, DateTime fin)
        {
            if (!YearIntervalValidation(debut, fin)) { return false; }
            return debut.Month == fin.Month;
        }

        public static string SetInfo(DateTime date, string hote, string operateur)
        {
            string result = date.ToString("G") + @"-" + hote + @"-" + operateur;
            return result;
        }

        public static string Spacing(string text)
        {
            string result = "0";
            int n = text.Length;
            if (n > 0)
            {
                result = n > 3 ? SpaceFormat(text) : text;
            }
            return result;
        }

        public static string TitlePeriod(DateTime debut, DateTime fin)
        {
            string text = @"JOURNAL: PERIODE DU " + debut.ToString("d") + @" AU " + fin.ToString("d");
            return text;
        }

        public static string TitleReport(string result, string id)
        {
            switch (result)
            {
                case "AV":
                    result = "AVOIR";
                    break;

                case "VT":
                    result = "VENTE";
                    break;

                case "RE":
                    result = "REBUT ERREUR";
                    break;

                case "RD":
                    result = "REBUT DEFECTION";
                    break;

                case "RV":
                    result = "REBUT VOL";
                    break;

                case "CO":
                    result = "COMMANDE";
                    break;

                case "CP":
                    result = "COMPTAGE";
                    break;

                case "AN":
                    result = "ANNULATION VENTE";
                    break;

                case "DP":
                    result = "DEMANDE DE PRIX";
                    break;

                default:
                    result = "ENTREE";
                    break;
            }
            result += @" N° ";
            result += id;
            return result;
        }

        public static string TitleReport(string label, string debut, string fin)
        {
            string text = label + debut + @" AU " + fin;
            return text;
        }

        public static string TitleSimple(DateTime debut, DateTime fin)
        {
            string text = @": PERIODE DU " + debut.ToString("d") + @" AU " + fin.ToString("d");
            return text;
        }

        public static bool YearIntervalValidation(DateTime debut, DateTime fin)
        {
            return (debut.Year - fin.Year >= 0) || (debut.Year - fin.Year <= 1);
        }

        internal static string Basing12Format(string text)
        {
            string result = null;
            int n = text.Length;
            if ((n >= 10) && (n < 13))
            {
                int p = n - 9;
                string prefix = text.Substring(0, p);
                string suffix = text.Substring(p, 9);
                suffix = Basing9Format(suffix);
                result = prefix + "." + suffix;
            }

            return result;
        }

        internal static string Basing6Format(string text)
        {
            string result = null;
            int n = text.Length;
            if ((n >= 4) && (n < 7))
            {
                int p = n - 3;
                string prefix = text.Substring(0, p);
                string suffix = text.Substring(p, 3);
                result = prefix + "." + suffix;
            }

            return result;
        }

        internal static string Basing9Format(string text)
        {
            string result = null;
            int n = text.Length;
            if ((n >= 7) && (n < 10))
            {
                int p = n - 6;
                string prefix = text.Substring(0, p);
                string suffix = text.Substring(p, 6);
                suffix = Basing6Format(suffix);
                result = prefix + "." + suffix;
            }

            return result;
        }

        internal static string Centaine(Int64 a)
        {
            string c = null;
            switch (a)
            {
                case 1:
                    c = "un";
                    break;

                case 2:
                    c = "deux";
                    break;

                case 3:
                    c = "trois";
                    break;

                case 4:
                    c = "quatre";
                    break;

                case 5:
                    c = "cinq";
                    break;

                case 6:
                    c = "six";
                    break;

                case 7:
                    c = "sept";
                    break;

                case 8:
                    c = "huit";
                    break;

                case 9:
                    c = "neuf";
                    break;

                case 10:
                    c = "dix";
                    break;

                case 11:
                    c = "onze";
                    break;

                case 12:
                    c = "douze";
                    break;

                case 13:
                    c = "treize";
                    break;

                case 14:
                    c = "quatorze";
                    break;

                case 15:
                    c = "quinze";
                    break;

                case 16:
                    c = "seize";
                    break;

                case 17:
                    c = "dix-sept";
                    break;

                case 18:
                    c = "dix huit";
                    break;

                case 19:
                    c = "dix-neuf";
                    break;

                case 20:
                    c = "vingt";
                    break;

                case 21:
                    c = "vingt et un";
                    break;

                case 22:
                    c = "vingt-deux";
                    break;

                case 23:
                    c = "vingt trois";
                    break;

                case 24:
                    c = "vingt-quatre";
                    break;

                case 25:
                    c = "vingt-cinq";
                    break;

                case 26:
                    c = "vingt six";
                    break;

                case 27:
                    c = "vingt-sept";
                    break;

                case 28:
                    c = "vingt huit";
                    break;

                case 29:
                    c = "vingt neuf";
                    break;

                case 30:
                    c = "trente";
                    break;

                case 31:
                    c = "trente et un";
                    break;

                case 32:
                    c = "trente deux";
                    break;

                case 33:
                    c = "trente trois";
                    break;

                case 34:
                    c = "trente quatre";
                    break;

                case 35:
                    c = "trente cinq";
                    break;

                case 36:
                    c = "trente six";
                    break;

                case 37:
                    c = "trente sept";
                    break;

                case 38:
                    c = "trente huit";
                    break;

                case 39:
                    c = "trente neuf";
                    break;

                case 40:
                    c = "quarante";
                    break;

                case 41:
                    c = "quarante et un";
                    break;

                case 42:
                    c = "quarante deux";
                    break;

                case 43:
                    c = "quarante trois";
                    break;

                case 44:
                    c = "quarante quatre";
                    break;

                case 45:
                    c = "quarante cinq";
                    break;

                case 46:
                    c = "quarante six";
                    break;

                case 47:
                    c = "quarante sept";
                    break;

                case 48:
                    c = "quarante huit";
                    break;

                case 49:
                    c = "quarante neuf";
                    break;

                case 50:
                    c = "cinquante";
                    break;

                case 51:
                    c = "cinquante et un";
                    break;

                case 52:
                    c = "cinquante deux";
                    break;

                case 53:
                    c = "cinquante trois";
                    break;

                case 54:
                    c = "cinquante quatre";
                    break;

                case 55:
                    c = "cinquante cinq";
                    break;

                case 56:
                    c = "cinquante six";
                    break;

                case 57:
                    c = "cinquante sept";
                    break;

                case 58:
                    c = "cinquante huit";
                    break;

                case 59:
                    c = "cinquante neuf";
                    break;

                case 60:
                    c = "soixante";
                    break;

                case 61:
                    c = "soixante et un";
                    break;

                case 62:
                    c = "soixante deux";
                    break;

                case 63:
                    c = "soixante trois";
                    break;

                case 64:
                    c = "soixante quatre";
                    break;

                case 65:
                    c = "soixante cinq";
                    break;

                case 66:
                    c = "soixante six";
                    break;

                case 67:
                    c = "soixante sept";
                    break;

                case 68:
                    c = "soixante huit";
                    break;

                case 69:
                    c = "soixante neuf";
                    break;

                case 70:
                    c = "soixante dix";
                    break;

                case 71:
                    c = "soixante et onze";
                    break;

                case 72:
                    c = "soixante douze";
                    break;

                case 73:
                    c = "soixante treize";
                    break;

                case 74:
                    c = "soixante quatorze";
                    break;

                case 75:
                    c = "soixante quinze";
                    break;

                case 76:
                    c = "soixante seize";
                    break;

                case 77:
                    c = "soixante dix-sept";
                    break;

                case 78:
                    c = "soixante dix huit";
                    break;

                case 79:
                    c = "soixante dix neuf";
                    break;

                case 80:
                    c = "quatre vingt";
                    break;

                case 81:
                    c = "quatre vingt et un";
                    break;

                case 82:
                    c = "quatre vingt deux";
                    break;

                case 83:
                    c = "quatre vingt trois";
                    break;

                case 84:
                    c = "quatre vingt quatre";
                    break;

                case 85:
                    c = "quatre vingt cinq";
                    break;

                case 86:
                    c = "quatre vingt six";
                    break;

                case 87:
                    c = "quatre vingt sept";
                    break;

                case 88:
                    c = "quatre vingt huit";
                    break;

                case 89:
                    c = "quatre vingt neuf";
                    break;

                case 90:
                    c = "quatre vingt dix";
                    break;

                case 91:
                    c = "quatre vingt onze";
                    break;

                case 92:
                    c = "quatre vingt douze";
                    break;

                case 93:
                    c = "quatre vingt treize";
                    break;

                case 94:
                    c = "quatre vingt quatorze";
                    break;

                case 95:
                    c = "quatre vingt quinze";
                    break;

                case 96:
                    c = "quatre vingt seize";
                    break;

                case 97:
                    c = "quatre vingt dix sept";
                    break;

                case 98:
                    c = "quatre vingt dix huit";
                    break;

                case 99:
                    c = "quatre vingt dix neuf";
                    break;
            }
            return c;
        }

        internal static string CentMille(Int64 c)
        {
            string result = null;
            string prefix = null;
            string suffix = null;
            string s = c.ToString(CultureInfo.InvariantCulture);
            if (c < 10000)
            {
                result = Millier(c);
            }
            else
            {
                if ((c >= 10000) && (c <= 99999))
                {
                    prefix = s.Substring(0, 2);
                    suffix = s.Substring(2, 3);
                }
                if ((c >= 100000) && (c <= 999999))
                {
                    prefix = s.Substring(0, 3);
                    suffix = s.Substring(3, 3);
                }
                if (prefix != null)
                {
                    int pre = int.Parse(prefix);
                    int suf = int.Parse(suffix);
                    result = Millier(pre) + " mille " + Millier(suf);
                }
            }
            return result;
        }

        internal static Int64 DoubleVersEntier(double r)
        {
            r = Math.Round(r);
            string s = r.ToString(CultureInfo.InvariantCulture);
            long result = Int64.Parse(s);
            return result;
        }

        internal static string Milliard(Int64 c)
        {
            string result = null;
            string s = c.ToString(CultureInfo.InvariantCulture);
            string prefix = null;
            string suffix = null;
            int suf;
            double r = c;
            if ((r < 999999999) && (r > 0))
            {
                result = Million(c);
            }
            if ((r >= 1000000000) && (r <= 9999999999))
            {
                prefix = s.Substring(0, 1);
                suffix = s.Substring(1, 9);
                if (c < 2000000000)
                {
                    suf = int.Parse(suffix);
                    result = "un milliard " + Million(suf);
                }
            }
            if ((r >= 10000000000) && (r <= 99999999999))
            {
                prefix = s.Substring(0, 2);
                suffix = s.Substring(2, 9);
            }
            if ((r >= 100000000000) && (r <= 999999999999))
            {
                prefix = s.Substring(0, 3);
                suffix = s.Substring(3, 9);
            }
            if (r >= 2000000000)
            {
                if (prefix != null)
                {
                    int pre = int.Parse(prefix);
                    suf = int.Parse(suffix);
                    result = Million(pre) + " milliards " + Million(suf);
                }
            }
            if (r == 1000000000)
            {
                result = "un milliard";
            }
            if (r == 0)
            {
                result = "zéro";
            }
            return result;
        }

        internal static string Millier(Int64 c)
        {
            string result = null;
            if (c < 1000)
            {
                result = PlusCent(c);
            }
            if (c == 1000)
            {
                result = "mille";
            }
            if (c == 2000)
            {
                result = "deux mille";
            }
            if (c == 3000)
            {
                result = "trois mille";
            }
            if (c == 4000)
            {
                result = "quatre mille";
            }
            if (c == 5000)
            {
                result = "cinq mille";
            }
            if (c == 6000)
            {
                result = "six mille";
            }
            if (c == 7000)
            {
                result = "sept mille";
            }
            if (c == 8000)
            {
                result = "huit mille";
            }
            if (c == 9000)
            {
                result = "neuf mille";
            }
            Int64 x;
            string s;
            if ((c >= 1001) && (c <= 1999))
            {
                x = c - 1000;
                s = PlusCent(x);
                result = "mille " + s;
            }
            if ((c >= 2001) && (c <= 2999))
            {
                x = c - 2000;
                s = PlusCent(x);
                result = "deux mille " + s;
            }
            if ((c >= 3001) && (c <= 3999))
            {
                x = c - 3000;
                s = PlusCent(x);
                result = "trois mille " + s;
            }
            if ((c >= 4001) && (c <= 4999))
            {
                x = c - 4000;
                s = PlusCent(x);
                result = "quatre mille " + s;
            }
            if ((c >= 5001) && (c <= 5999))
            {
                x = c - 5000;
                s = PlusCent(x);
                result = "cinq mille " + s;
            }
            if ((c >= 6001) && (c <= 6999))
            {
                x = c - 6000;
                s = PlusCent(x);
                result = "six mille " + s;
            }
            if ((c >= 7001) && (c <= 7999))
            {
                x = c - 7000;
                s = PlusCent(x);
                result = "sept mille " + s;
            }
            if ((c >= 8001) && (c <= 8999))
            {
                x = c - 8000;
                s = PlusCent(x);
                result = "huit mille " + s;
            }
            if ((c >= 9001) && (c <= 9999))
            {
                x = c - 9000;
                s = PlusCent(x);
                result = "neuf mille " + s;
            }
            return result;
        }

        internal static string Million(Int64 c)
        {
            string result = null;
            string s = c.ToString(CultureInfo.InvariantCulture);
            string prefix = null;
            string suffix = null;
            int pre = 0;
            int suf = 0;
            if (c < 1000000)
            {
                result = CentMille(c);
            }
            if (c == 1000000)
            {
                result = "un million";
            }
            if ((c > 1000000) && (c <= 9999999))
            {
                prefix = s.Substring(0, 1);
                suffix = s.Substring(1, 6);
                if (c < 2000000)
                {
                    suf = int.Parse(suffix);
                    result = "un million " + CentMille(suf);
                }
            }
            if ((c >= 10000000) && (c <= 99999999))
            {
                prefix = s.Substring(0, 2);
                suffix = s.Substring(2, 6);
            }
            if ((c >= 100000000) && (c <= 999999999))
            {
                prefix = s.Substring(0, 3);
                suffix = s.Substring(3, 6);
            }
            if (c >= 2000000)
            {
                if (prefix != null) pre = int.Parse(prefix);
                if (suffix != null) suf = int.Parse(suffix);
                result = Millier(pre) + " millions " + CentMille(suf);
            }
            return result;
        }

        internal static string PlusCent(Int64 c)
        {
            string result = null;
            switch (c)
            {
                case 100:
                    result = "cent";
                    break;

                case 200:
                    result = "deux cent";
                    break;

                case 300:
                    result = "trois cent";
                    break;

                case 400:
                    result = "quatre cent";
                    break;

                case 500:
                    result = "cinq cent";
                    break;

                case 600:
                    result = "six cent";
                    break;

                case 700:
                    result = "sept cent";
                    break;

                case 800:
                    result = "huit cent";
                    break;

                case 900:
                    result = "neuf cent";
                    break;
            }
            if ((c >= 1) && (c <= 99))
            {
                result = Centaine(c);
            }
            if ((c >= 101) && (c <= 199))
            {
                result = "cent " + Centaine(c - 100);
            }
            if ((c >= 201) && (c <= 299))
            {
                result = "deux cent " + Centaine(c - 200);
            }
            if ((c >= 301) && (c <= 399))
            {
                result = "trois cent " + Centaine(c - 300);
            }
            if ((c >= 401) & (c <= 499))
            {
                result = "quatre cent " + Centaine(c - 400);
            }
            if ((c >= 501) && (c <= 599))
            {
                result = "cinq cent " + Centaine(c - 500);
            }
            if ((c >= 601) && (c <= 699))
            {
                result = "six cent " + Centaine(c - 600);
            }
            if ((c >= 701) && (c <= 799))
            {
                result = "sept cent " + Centaine(c - 700);
            }
            if ((c >= 801) && (c <= 899))
            {
                result = "huit cent " + Centaine(c - 800);
            }
            if ((c >= 901) && (c <= 999))
            {
                result = "neuf cent " + Centaine(c - 900);
            }
            return result;
        }

        internal static string SpaceFormat(string text)
        {
            int n = text.Length;
            string result = null;
            if ((n >= 4) && (n <= 12))
            {
                if ((n >= 4) && (n < 7))
                {
                    result = Spacing6Format(text);
                }
                if ((n >= 7) && (n < 10))
                {
                    result = Spacing9Format(text);
                }
                if ((n >= 10) && (n < 13))
                {
                    result = Spacing12Format(text);
                }
            }
            else
            {
                result = "0";
            }
            return result;
        }

        internal static string Spacing12Format(string text)
        {
            string result = null;
            int n = text.Length;
            if ((n >= 10) && (n < 13))
            {
                int p = n - 9;
                string prefix = text.Substring(0, p);
                string suffix = text.Substring(p, 9);
                suffix = Spacing9Format(suffix);
                result = prefix + " " + suffix;
            }

            return result;
        }

        internal static string Spacing6Format(string text)
        {
            string result = null;
            int n = text.Length;
            if ((n >= 4) && (n < 7))
            {
                int p = n - 3;
                string prefix = text.Substring(0, p);
                string suffix = text.Substring(p, 3);
                result = prefix + " " + suffix;
            }

            return result;
        }

        internal static string Spacing9Format(string text)
        {
            string result = null;
            int n = text.Length;
            if ((n >= 7) && (n < 10))
            {
                int p = n - 6;
                string prefix = text.Substring(0, p);
                string suffix = text.Substring(p, 6);
                suffix = Spacing6Format(suffix);
                result = prefix + " " + suffix;
            }

            return result;
        }

        internal static string StringFormat(string text)
        {
            int n = text.Length;
            string result = null;
            if ((n >= 4) && (n <= 12))
            {
                if ((n >= 4) && (n < 7))
                {
                    result = Basing6Format(text);
                }
                if ((n >= 7) && (n < 10))
                {
                    result = Basing9Format(text);
                }
                if ((n >= 10) && (n < 13))
                {
                    result = Basing12Format(text);
                }
            }
            else
            {
                result = "0";
            }
            return result;
        }

        private static int EndMonth(DateTime date)
        {
            int result;
            int month = date.Month;
            switch (month)
            {
                case 2:
                    result = 29;
                    break;

                case 4:
                    result = 30;
                    break;

                case 6:
                    result = 30;
                    break;

                case 9:
                    result = 30;
                    break;

                case 10:
                    result = 30;
                    break;

                default:
                    result = 31;
                    break;
            }
            return result;
        }
    }
}