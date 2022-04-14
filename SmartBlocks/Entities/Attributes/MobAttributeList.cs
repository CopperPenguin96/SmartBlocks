using MinecraftTypes;

namespace SmartBlocks.Entities.Attributes
{
    public class MobAttributeList : List<MobAttribute>
    {
        public MobAttribute this[Identifier id]
        {
            get
            {
                foreach (var attribute in this)
                {
                    if (attribute.Name == id.Name) return attribute;
                    continue;
                }

                throw new IndexOutOfRangeException();
            }
            set
            {
                for (int x = 0; x < this.Count; x++)
                {
                    MobAttribute attribute = this[x];
                    if (attribute.Name == value.Name)
                    {
                        this[x] = value;
                        return;
                    }
                }

                throw new IndexOutOfRangeException();
            }
        }
    }
}