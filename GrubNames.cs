using HutongGames.PlayMaker.Actions;
using ItemChanger;
using ItemChanger.UIDefs;
using Modding;
using System.Collections.Generic;
using System.Linq;

namespace GrubNames
{
    public class GrubNames : Mod, IGlobalSettings<GlobalSettingsClass>

    {
        public static GlobalSettingsClass GS { get; set; } = new GlobalSettingsClass();
        new public string GetName() => "GrubNames";
        public override string GetVersion() => "2.0.0.0";
        GrubDict userGrubs = new GrubDict();

        List<Grub> grubs = new List<Grub>();

        public override void Initialize()
        {
            foreach (KeyValuePair<string, string> kvp in userGrubs.grubNamesDict)
            {
                grubs.Add(new(kvp.Key, kvp.Value));
            }

            AbstractItem.ModifyItemGlobal += args =>
            {
                if (args.Placement.Name.StartsWith("Grub") && args.Placement.Name != "Grubfather")
                {
                    Grub grub = grubs.First((grub) => grub.LocationName == args.Placement.Name);
                    string grubName = grub.Name + " (#" + (PlayerData.instance.grubsCollected + 1) + ")";
                    ((MsgUIDef)args.Item.UIDef).name = new BoxedString(grubName);
                }
            };
        }

        public void OnLoadGlobal(GlobalSettingsClass settings)
        {
            GS = settings;
        }

        public GlobalSettingsClass OnSaveGlobal()
        {
            return GS;
        }


    }
}