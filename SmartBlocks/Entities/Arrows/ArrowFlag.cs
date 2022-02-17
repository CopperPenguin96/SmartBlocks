namespace SmartBlocks.Entities.Arrows
{
    public enum ArrowFlag : byte
    {
        Critical = 0x01,

        /// <summary>
        /// Used by loyalty tridents when returning
        /// </summary>
        NoClip = 0x02
    }
}
