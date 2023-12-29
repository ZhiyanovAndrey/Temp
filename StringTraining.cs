using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Temp
{
    public class StringTraining
    {
        IPAddress address;

        // возврат IP в нормальном виде
        public static string rightIP(string Address)
        {
            string ip = string.Empty;
            string pattern = @"dd?d?.dd?d?.dd?d?.dd?d?";
            System.Text.RegularExpressions.Regex regex =
            new System.Text.RegularExpressions.Regex(pattern);
            System.Text.RegularExpressions.Match match = regex.Match(Address);
            while (match.Success)
            {
                ip = match.Value;
                match = match.NextMatch();
            }
            return ip;
        }
        public static bool IsIPAddress2(string ipAddres)
        {
            //Инициализируем новый экземпляр класса System.Text.RegularExpressions.Regex
            //для указанного регулярного выражения.
            System.Text.RegularExpressions.Regex IpMatch = new System.Text.RegularExpressions.Regex(@"b(?:d{1,3}.){3}d{1,3}b");
            //Выполняем проверку обнаружено ли в указанной входной строке
            //соответствие регулярному выражению, заданному в
            //конструкторе System.Text.RegularExpressions.Regex.
            //если да то возвращаем true, если нет то false
            return IpMatch.IsMatch(ipAddres);
        }

        public static bool IPValidation(string ipAddress)
        {
            bool isIPAddres = false;
            Match match = Regex.Match(ipAddress, @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            if (match.Success)
            {
                isIPAddres = true;
            }
            return isIPAddres;
        }

        // Метод проверки ip-адреса
        internal static bool IsIPAddress(string ipAddress)
        {
            bool isIPAddres = false;

            try
            {
                IPAddress address;
                // Определяем является ли строка ip-адресом
                isIPAddres = IPAddress.TryParse(ipAddress, out address);
            }
            catch (Exception e) { }
            return isIPAddres;
        }

        internal static string BreakCamelCase(string str)
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

            string result = string.Empty;
            int startindex = 0;

            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == str.ToUpper()[i])
                {


                    //result= str.Insert(i, " ");
                    stringBuilder.Append(str, startindex, i - startindex);
                    stringBuilder.Append(' ');
                    startindex = i;

                }


            }

            stringBuilder = stringBuilder.Append(str, startindex, str.Length - startindex);


            return stringBuilder.ToString();
        }
    }


}
