using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartBlocks.Worlds;
using SmartNbt.Tags;

namespace SmartBlocks.Blocks;

public class PotionEffect : ITagProvider
{
    public bool Ambient { get; set; }

    public bool Amplifier { get; set; }

    public int Duration { get; set; }

    public PotionEffect HiddenEffect { get; set; }

    public byte Id { get; set; }

    public bool ShowIcon { get; set; }

    public bool ShowParticles { get; set; }

    public NbtTag Tag =>
        new NbtCompound
        {
            new NbtBoolean("Ambient", Ambient),
            new NbtBoolean("Amplifier", Amplifier),
            new NbtInt("Duration", Duration),
            HiddenEffect.Tag,
            new NbtByte("Id", Id),
            new NbtBoolean("ShowIcon", ShowIcon),
            new NbtBoolean("ShowParticles", ShowParticles)
        };
}