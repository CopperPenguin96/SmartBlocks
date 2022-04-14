namespace SmartBlocks.Entities.Attributes
{
    internal class AttributeList : List<MobAttribute>
    {
        public MobAttribute this[string key]
        {
            get
            {
                foreach (MobAttribute mobAttribute in this)
                {
                    if (mobAttribute.Name.Name == key) return mobAttribute;
                    else continue;
                }

                return null!;
            }
        }
    }
}
