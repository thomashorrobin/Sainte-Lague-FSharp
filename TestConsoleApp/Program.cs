using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sainte_Lague_FSharp;
using Microsoft.FSharp.Collections;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====");
            foreach (var election in allElections)
            {
                List<Party> parties = Election.RunElection(ListModule.OfSeq(election), 120).ToList();
                foreach (Party party in parties)
                {
                    Console.WriteLine(string.Format("{0}: {1}",party.PartyName, party.TotalSeats.ToString()));
                }
                Console.WriteLine("=====");
            }
            Console.ReadLine();
        }
        
        static List<List<Party>> allElections
        {
            get
            {
                var elections = new List<List<Party>>();
                elections.Add(election2014);
                elections.Add(election2011);
                elections.Add(election2008);
                elections.Add(election2005);
                elections.Add(election2002);
                return elections;
            }
        }

        static List<Party> election2014
        {
            get
            {
                var parties = new List<Party>();
                parties.Add(new Party("National Party", 41, 1131501, 0));
                parties.Add(new Party("Labour Party", 27, 604535, 0));
                parties.Add(new Party("Green Party", 0, 257359, 0));
                parties.Add(new Party("New Zealand First Party", 0, 208300, 0));
                parties.Add(new Party("Māori Party", 1, 31849, 0));
                parties.Add(new Party("ACT New Zealand", 1, 16689, 0));
                parties.Add(new Party("United Future", 1, 5286, 0));
                parties.Add(new Party("Conservative", 0, 95598, 0));
                parties.Add(new Party("Internet MANA", 0, 34094, 0));
                parties.Add(new Party("Aotearoa Legalise Cannabis Party", 0, 10961, 0));
                parties.Add(new Party("Ban1080", 0, 5113, 0));
                parties.Add(new Party("Democrats for Social Credit", 0, 1730, 0));
                parties.Add(new Party("The Civilian Party", 0, 1096, 0));
                parties.Add(new Party("NZ Independent Coalition", 0, 872, 0));
                parties.Add(new Party("Focus New Zealand", 0, 639, 0));
                return parties;
            }
        }

        static List<Party> election2011
        {
            get
            {
                var parties = new List<Party>();
                parties.Add(new Party("National Party", 42, 1058636, 0));
                parties.Add(new Party("Labour Party", 22, 614937, 0));
                parties.Add(new Party("Green Party", 0, 247372, 0));
                parties.Add(new Party("New Zealand First Party", 0, 147544, 0));
                parties.Add(new Party("Māori Party", 3, 31982, 0));
                parties.Add(new Party("Mana", 1, 24168, 0));
                parties.Add(new Party("ACT New Zealand", 1, 23889, 0));
                parties.Add(new Party("United Future", 1, 13443, 0));
                parties.Add(new Party("Conservative Party", 0, 59237, 0));
                parties.Add(new Party("Aotearoa Legalise Cannabis Party", 0, 11738, 0));
                parties.Add(new Party("Democrats for Social Credit", 0, 1714, 0));
                parties.Add(new Party("Libertarianz", 0, 1595, 0));
                parties.Add(new Party("Alliance", 0, 1209, 0));
                return parties;
            }
        }

        static List<Party> election2008
        {
            get
            {
                var parties = new List<Party>();
                parties.Add(new Party("National Party", 41, 1053398, 0));
                parties.Add(new Party("Labour Party", 21, 796880, 0));
                parties.Add(new Party("Green Party", 0, 157613, 0));
                parties.Add(new Party("ACT New Zealand", 1, 85496, 0));
                parties.Add(new Party("Māori Party", 5, 55980, 0));
                parties.Add(new Party("Jim Anderton's Progressive", 1, 21241, 0));
                parties.Add(new Party("United Future", 1, 20497, 0));
                parties.Add(new Party("New Zealand First Party", 0, 95356, 0));
                parties.Add(new Party("The Bill and Ben Party", 0, 13016, 0));
                parties.Add(new Party("Kiwi Party", 0, 12755, 0));
                parties.Add(new Party("Aotearoa Legalise Cannabis Party", 0, 9515, 0));
                parties.Add(new Party("New Zealand Pacific Party", 0, 8640, 0));
                parties.Add(new Party("Family Party", 0, 8176, 0));
                parties.Add(new Party("Alliance", 0, 1909, 0));
                parties.Add(new Party("Democrats for Social Credit", 0, 1208, 0));
                parties.Add(new Party("Libertarianz", 0, 1176, 0));
                parties.Add(new Party("Workers Party", 0, 932, 0));
                parties.Add(new Party("RAM - Residents Action Movement", 0, 465, 0));
                parties.Add(new Party("The Republic of New Zealand Party", 0, 313, 0));
                return parties;
            }
        }

        static List<Party> election2005
        {
            get
            {
                var parties = new List<Party>();
                parties.Add(new Party("Labour Party", 31, 935319, 0));
                parties.Add(new Party("National Party", 31, 889813, 0));
                parties.Add(new Party("New Zealand First Party", 0, 130115, 0));
                parties.Add(new Party("Green Party", 0, 120521, 0));
                parties.Add(new Party("Mâori Party", 4, 48263, 0));
                parties.Add(new Party("United Future New Zealand", 1, 60860, 0));
                parties.Add(new Party("ACT New Zealand", 1, 34469, 0));
                parties.Add(new Party("Jim Anderton's Progressive", 1, 26441, 0));
                parties.Add(new Party("Destiny New Zealand", 0, 14210, 0));
                parties.Add(new Party("Aotearoa Legalise Cannabis Party", 0, 5748, 0));
                parties.Add(new Party("Christian Heritage NZ", 0, 2821, 0));
                parties.Add(new Party("Alliance", 0, 1641, 0));
                parties.Add(new Party("New Zealand Family Rights Protection Party", 0, 1178, 0));
                parties.Add(new Party("Democrats for Social Credit", 0, 1079, 0));
                parties.Add(new Party("Libertarianz", 0, 946, 0));
                parties.Add(new Party("Direct Democracy Party", 0, 782, 0));
                parties.Add(new Party("99 MP Party", 0, 601, 0));
                parties.Add(new Party("OneNZ Party", 0, 478, 0));
                parties.Add(new Party("The Republic of New Zealand Party", 0, 344, 0));
                return parties;
            }
        }

        static List<Party> election2002
        {
            get
            {
                var parties = new List<Party>();
                parties.Add(new Party("Labour Party", 45, 838219, 0));
                parties.Add(new Party("National Party", 21, 425310, 0));
                parties.Add(new Party("New Zealand First Party", 1, 210912, 0));
                parties.Add(new Party("ACT New Zealand", 0, 145078, 0));
                parties.Add(new Party("Green Party", 0, 142250, 0));
                parties.Add(new Party("United Future", 1, 135918, 0));
                parties.Add(new Party("Jim Anderton's Progressive Coalition", 1, 34542, 0));
                parties.Add(new Party("Christian Heritage Party", 0, 27492, 0));
                parties.Add(new Party("Outdoor Recreation NZ", 0, 25985, 0));
                parties.Add(new Party("Alliance", 0, 25888, 0));
                parties.Add(new Party("Aotearoa Legalise Cannabis Party", 0, 12987, 0));
                parties.Add(new Party("Mana Maori Movement", 0, 4980, 0));
                parties.Add(new Party("OneNZ Party", 0, 1782, 0));
                parties.Add(new Party("NMP", 0, 274, 0));
                return parties;
            }
        }
    }
}
