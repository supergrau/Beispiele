using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PasswordGeneator
{
    internal class PasswordGenerator
    {
        private int length;
        private String password;

        public int Length { get => this.length; set => this.length = value; }

        public PasswordGenerator()
        {
            password = "";
            length = 8;
        }

        public PasswordGenerator(int length)
        {
            this.length = length;
            password = "";
        }

        public String generate()
        {

            Random r = new Random();
            int rand = 0;
            int i = 0;
            int upper, mu, lower, ml, special, ms, digit, md;
            ml = mu = ms = md = upper = lower = special = digit = 0;
            if (length % 4 == 0)
            {
                mu = ml = ms = md = length / 4;
            }
            if (length % 4 == 1)
            {
                mu = ml = ms = length / 4;
                md = length / 4 + 1;
            }
            if (length % 4 == 2)
            {
                mu = ml = length / 4;
                md = ms = length / 4 + 1;
            }
            if (length % 4 == 3)
            {
                mu = length / 4;
                md = ms = ml = length / 4 + 1;
            }

            do
            {
                rand = r.Next(126) + 1;
                if (32 < rand && rand < 127)
                { // alle Druckbaren Zeichen
                    if (47 < rand && rand < 58 && (digit < md))
                    { // Ziffern
                        password = password + (char)rand;
                        digit++;
                        i++;
                    }
                    else if (64 < rand && rand < 91 && (upper < mu))
                    { // Großbuchstaben
                        password = password + (char)rand;
                        upper++;
                        i++;
                    }
                    else if (96 < rand && rand < 123 && (lower < ml))
                    { // Kleinbuchstaben
                        password = password + (char)rand;
                        lower++;
                        i++;
                    }
                    else if (((32 < rand && rand < 48) ||
                               (57 < rand && rand < 65) ||
                               (90 < rand && rand < 97) ||
                               (122 < rand && rand < 127)) && (special < ms))
                    { // Sonderzeichen 
                        password = password + (char)rand;
                        special++;
                        i++;
                    }

                }
            } while (i < length);


            return password;

        }

    }
}
