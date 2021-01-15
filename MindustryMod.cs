using Terraria.ModLoader;
using MindustryMod.Content;

namespace MindustryMod {
    public class MindustryMod : Mod {
        internal FeatureList[] features;

        public MindustryMod() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
                AutoloadBackgrounds = true
            };

            features = new FeatureList[] {
                new Items()
            };
        }

        public override void Load() {
            foreach(FeatureList feature in features) {
                feature.Load(this);
            }
        }
    }
}
