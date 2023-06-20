using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrubNames
{
    public class GrubDict
    {
        public static GlobalSettingsClass GS { get; set; } = new GlobalSettingsClass();
        public readonly Dictionary<string, string> grubNamesDict = new Dictionary<string, string>();

        public readonly List<string> grubLocationsList = new List<string>
        {
            "Grub-Crossroads_Acid",
            "Grub-Crossroads_Center",
            "Grub-Crossroads_Stag",
            "Grub-Crossroads_Spike",
            "Grub-Crossroads_Guarded",
            "Grub-Greenpath_Cornifer",
            "Grub-Greenpath_Journal",
            "Grub-Greenpath_MMC",
            "Grub-Greenpath_Stag",
            "Grub-Fog_Canyon",
            "Grub-Fungal_Bouncy",
            "Grub-Fungal_Spore_Shroom",
            "Grub-Deepnest_Mimic",
            "Grub-Deepnest_Nosk",
            "Grub-Deepnest_Spike",
            "Grub-Dark_Deepnest",
            "Grub-Beasts_Den",
            "Grub-Kingdoms_Edge_Oro",
            "Grub-Kingdoms_Edge_Camp",
            "Grub-Hive_External",
            "Grub-Hive_Internal",
            "Grub-Basin_Requires_Wings",
            "Grub-Basin_Requires_Dive",
            "Grub-Waterways_Main",
            "Grub-Ismas_Grove",
            "Grub-Waterways_Requires_Tram",
            "Grub-City_of_Tears_Left",
            "Grub-Soul_Sanctum",
            "Grub-Watchers_Spire",
            "Grub-City_of_Tears_Guarded",
            "Grub-Kings_Station",
            "Grub-Resting_Grounds",
            "Grub-Crystal_Peak_Below_Chest",
            "Grub-Crystallized_Mound",
            "Grub-Crystal_Peak_Spike",
            "Grub-Crystal_Peak_Mimic",
            "Grub-Crystal_Peak_Crushers",
            "Grub-Crystal_Heart",
            "Grub-Hallownest_Crown",
            "Grub-Howling_Cliffs",
            "Grub-Queens_Gardens_Stag",
            "Grub-Queens_Gardens_Marmu",
            "Grub-Queens_Gardens_Top",
            "Grub-Collector_1",
            "Grub-Collector_2",
            "Grub-Collector_3",

        };

        public List<string> grubUserNames = new List<string>() {
            GS.Grub_Crossroads_Acid,
            GS.Grub_Crossroads_Center,
            GS.Grub_Crossroads_Stag,
            GS.Grub_Crossroads_Spike,
            GS.Grub_Crossroads_Guarded,
            GS.Grub_Greenpath_Cornifer,
            GS.Grub_Greenpath_Journal,
            GS.Grub_Greenpath_MMC,
            GS.Grub_Greenpath_Stag,
            GS.Grub_Fog_Canyon,
            GS.Grub_Fungal_Bouncy,
            GS.Grub_Fungal_Spore_Shroom,
            GS.Grub_Deepnest_Mimic,
            GS.Grub_Deepnest_Nosk,
            GS.Grub_Deepnest_Spike,
            GS.Grub_Dark_Deepnest,
            GS.Grub_Beasts_Den,
            GS.Grub_Kingdoms_Edge_Oro,
            GS.Grub_Kingdoms_Edge_Camp,
            GS.Grub_Hive_External,
            GS.Grub_Hive_Internal,
            GS.Grub_Basin_Requires_Wings,
            GS.Grub_Basin_Requires_Dive,
            GS.Grub_Waterways_Main,
            GS.Grub_Ismas_Grove,
            GS.Grub_Waterways_Requires_Tram,
            GS.Grub_City_of_Tears_Left,
            GS.Grub_Soul_Sanctum,
            GS.Grub_Watchers_Spire,
            GS.Grub_City_of_Tears_Guarded,
            GS.Grub_Kings_Station,
            GS.Grub_Resting_Grounds,
            GS.Grub_Crystal_Peak_Below_Chest,
            GS.Grub_Crystallized_Mound,
            GS.Grub_Crystal_Peak_Spike,
            GS.Grub_Crystal_Peak_Mimic,
            GS.Grub_Crystal_Peak_Crushers,
            GS.Grub_Crystal_Heart,
            GS.Grub_Hallownest_Crown,
            GS.Grub_Howling_Cliffs,
            GS.Grub_Queens_Gardens_Stag,
            GS.Grub_Queens_Gardens_Marmu,
            GS.Grub_Queens_Gardens_Top,
            GS.Grub_Collector_1,
            GS.Grub_Collector_2,
            GS.Grub_Collector_3,
        };

        public GrubDict()
        {
            for (int i = 0; i < grubLocationsList.Count; i++)
            {
                grubNamesDict.Add(grubUserNames[i], grubLocationsList[i]);
            }
        }

    }
}
