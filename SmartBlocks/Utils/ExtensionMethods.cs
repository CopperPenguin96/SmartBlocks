using System.Text;
using java.util;
using SmartNbt.Tags;

namespace SmartBlocks.Utils;

public static class ExtensionMethods
{
    public static NbtList ToNbtList<T>(this List<T> list, string listName)
    {
        NbtList lst = new(listName);

        if (typeof(T) == typeof(byte))
        {
            foreach (var b in list)
            {
                lst.Add(new NbtByte(Convert.ToByte(b)));
            }
        }
        else if (typeof(T) == typeof(short))
        {
            foreach (var b in list)
            {
                lst.Add(new NbtShort(Convert.ToInt16(b)));
            }
        }
        else if (typeof(T) == typeof(int))
        {
            foreach (var b in list)
            {
                lst.Add(new NbtInt(Convert.ToInt32(b)));
            }
        }
        else if (typeof(T) == typeof(long))
        {
            foreach (var b in list)
            {
                lst.Add(new NbtLong(Convert.ToInt64(b)));
            }
        }
        else if (typeof(T) == typeof(float))
        {
            foreach (var b in list)
            {
                lst.Add(new NbtFloat(Convert.ToSingle(b)));
            }
        }
        else if (typeof(T) == typeof(double))
        {
            foreach (var b in list)
            {
                lst.Add(new NbtDouble(Convert.ToDouble(b)));
            }
        }
        else if (typeof(T) == typeof(string))
        {
            foreach (var b in list)
            {
                lst.Add(new NbtShort(Convert.ToString(b)));
            }
        }

        return lst;
    }

    public static string Join(this string[] parts, string glue)
    {
        string str = "";
        bool isFirst = true;
        foreach (string part in parts)
        {
            if (!isFirst)
            {
                str += glue;
            }
            else
            {
                isFirst = false;
            }

            str += part;
        }

        return str;
    }

    public static string Join(this List<string> parts, string glue)
    {
        return Join(parts.ToArray(), glue);
    }

    public static int[] GetIntArray(this UUID uuid)
    {
        if (uuid == null) throw new NullReferenceException(nameof(uuid));

        int[] i = new int[4];
        long msb = uuid.getMostSignificantBits();
        long lsb = uuid.getLeastSignificantBits();

        i[0] = (int)(msb >> 32);
        i[1] = (int)(msb);
        i[2] = (int)(lsb >> 32);
        i[3] = (int)(lsb);
        return i;
    }

    public static byte ToByte(this bool b)
    {
        return b ? (byte)1 : (byte)0;
    }

    public static string Base64Encode(this string original)
    {
        if (original == null) throw new NullReferenceException(nameof(original));

        byte[] plainBytes = Encoding.UTF8.GetBytes(original);
        return System.Convert.ToBase64String(plainBytes);
    }

    public static byte[] ToBytes(this string str, Encoding enc)
    {
        return enc.GetBytes(str);
    }

    public static byte[] ToBytes(this string str)
    {
        return ToBytes(str, Encoding.UTF8);
    }
}