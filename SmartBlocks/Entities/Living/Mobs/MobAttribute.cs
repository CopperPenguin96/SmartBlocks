using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using java.util;
using SmartBlocks.Utils;
using SmartBlocks.Worlds;
using SmartNbt.Tags;

namespace SmartBlocks.Entities.Living.Mobs
{
    public class MobAttribute : ITagProvider
    {
        public double Base { get; set; }

        public List<MobAttributeModifier> Modifiers { get; set; }

        public string Name { get; set; }

        public double Min { get; set; }

        public double Max { get; set; }

        internal MobAttribute(string name, double bs, double min, double max, List<MobAttributeModifier> mods)
        {
            Base = bs;
            Modifiers = mods;
            Name = name;
            Min = min;
            Max = max;
        }

        public NbtTag Tag
        {
            get
            {
                NbtList mods = new("Modifiers");
                foreach (var mob in Modifiers)
                {
                    mods.Add(mob.Tag);
                }

                NbtCompound attribute = new()
                {
                    new NbtDouble("Base", Base),
                    mods,
                    new NbtString("Name", Name)
                };

                return attribute;
            }
        }
    }

    public class MobAttributeModifier : ITagProvider
    {
        public double Amount { get; set; }

        public string Name { get; set; }

        public int Operation { get; set; }

        public UUID UniqueId { get; set; }

        public NbtTag Tag =>
            new NbtCompound
            {
                new NbtDouble("Amount", Amount),
                new NbtString("Name", Name),
                new NbtInt("Operation", Operation),
                new NbtIntArray("UUID", UniqueId.GetIntArray())
            };
    }
}
