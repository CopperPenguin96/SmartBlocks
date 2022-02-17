using SmartNbt;
using SmartNbt.Tags;

namespace SmartBlocks.Worlds.Raids
{
    public class RaidList : List<Raid>, ITagProvider
    {
        public int NextAvailableId 
            => this[Array.IndexOf(ToArray(), this.Min())].Id;
       
        public TimeSpan EternalClock { get; set; }

        public NbtTag Tag
        {
            get
            {
                NbtList raids = new(NbtTagType.Compound);
                foreach (Raid raid in this)
                {
                    raids.Add(raid.Tag);
                }

                return new NbtCompound
                {
                    new NbtInt("NextAvailableID", NextAvailableId),
                    raids,
                    new NbtInt("Tick", (int) EternalClock.Ticks)
                };
            }
        }
    }
}
