using System;
using System.Collections.Generic;

namespace NightClub
{
    public class Dj
    {
        private static List<string> songs = new List<string>()
        {
            "LADIPOE & Buju - Feeling",
            "Olamide - Rock",
            "Ruger - Bounce",
            "Blaqbonez - Bling (feat. Amaarae & Buju)",
            "Buju - Outside",
            "JAE5 - Dimension (feat. Skepta & Rema)",
            "Tion Wayne X Russ Millions - Body (Remix) [feat. ArrDee, E1 (3x3), ZT (3x3), Bugzy Malone, Buni, Fivio Foreign & Darkoo], Naira Marley & Busiswa - Coming",
            "Burna Boy - Kilometre",
            "Joeboy - Show Me",
            "Wizkid - Essence (feat. Tems)",
            "Gyakie & Omah Lay - Forever (Remix)",
            "Ajebo Hustlers & Omah Lay - Pronto",
            "Cheque & Fireboy DML - History",
            "CKay - Felony",
            "Adekunle Gold - It Is What It Is",
            "Focalistic & Davido - Ke Star (feat. Virgo Deep) [Remix]",
            "Peruzzi & Davido - Somebody Baby",
            "Joeboy - Focus",
            "Davido - La La (feat. CKay)",
            "Terri, Bella Shmurda & MohBad - Money",
            "Wizkid - Ginger (feat. Burna Boy)",
            "Peruzzi - Southy Love (feat. Fireboy DML)",
            "Justin Bieber - Loved By You (feat. Burna Boy)",
            "Chike & Simi - Running (To You)",
            "Rema - Bounce",
            "Dangbana Republik & Bella Shmurda - World",
            "Ice Prince - KOLO (feat. Oxlade)",
            "J. Cole, 21 Savage & Morray - m y . l i f e",
            "J. Cole - a m a r i",
            "Vector - Early Momo (feat. GoodGirl LA)",
            "Wizkid - Blessed (feat. Damian 'Jr. Gong' Marley)",
            "Justin Bieber - Peaches (feat. Daniel Caesar & GIVĒON)",
            "J. Cole & Lil Baby - p r i d e . i s . t h e . d e v i l",
            "Davido - The Best (feat. Mayorkun)",
            "Burna Boy - 23",
            "Teni - FOR YOU (feat. Davido)",
            "Dangbana Republik & Bella Shmurda - Rush",
            "Teni - INJURE ME",
            "DJ Kaywise & Phyno - High Way",
            "Central Cee - Commitment Issues",
            "Omah Lay - Godly",
            "Masterkraft - Hallelu (feat. Bella Shmurda & Zlatan)",
            "J. Cole - 9 5 . s o u t h",
            "Blaqbonez - Okwaraji",
            "Rexxie & MohBad - Kpk (Ko Por Ke)",
            "Crayon & Rema - Too Correct",
            "Zinoleesky - Kilofeshe",
            "Ruger - Abu Dhabi",
            "Burna Boy - Way Too Big",
            "Davido - Jowo",
            "Burna Boy - Bank On It",
            "Blaqbonez - Fendi (feat. Joeboy)",
            "Wizkid - Reckless"
        };

        //Has a list of current music 
        //And selects from the list at random and store in a variable..
        public static void GetCurrentMusic()
        {
            Random pick = new Random();
            int index = pick.Next(songs.Count);
            Console.WriteLine($"{songs[index]} Playing by DJ SamAndre");
            // Console.ReadKey();
        }
    }
}