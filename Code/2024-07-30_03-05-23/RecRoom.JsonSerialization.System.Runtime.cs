using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GFPBNIPJNCM<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void JJCBAEDJIGE(Utf8JsonReader JPKMILJIBCP);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AD00", Offset = "0x3D09300", VA = "0x183D0AD00", Slot = "27")]
	public override T Read(Utf8JsonReader MMDEOFGAFEK, Type OMJKGAMFGPH, JsonSerializerOptions EFDCDFNAODA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AF00", Offset = "0x3D09500", VA = "0x183D0AF00", Slot = "28")]
	public override void Write(Utf8JsonWriter JFIDOOOHFIL, T DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void AGAFFGCJPBN(Utf8JsonReader MMDEOFGAFEK, JsonSerializerOptions EFDCDFNAODA, string BHPJGALIOMC, T JAGONPFFNPO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void LOAPPJDDFGA(Utf8JsonWriter JFIDOOOHFIL, T DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x38498A0", Offset = "0x3847EA0", VA = "0x1838498A0")]
	protected GFPBNIPJNCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ABHBIABJEJE : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C6A0", Offset = "0x6A2ACA0", VA = "0x186A2C6A0")]
	public ABHBIABJEJE(string BHPJGALIOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KKFBHIMFNAP<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x41BD240", Offset = "0x41BB840", VA = "0x1841BD240", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader MMDEOFGAFEK, Type OMJKGAMFGPH, JsonSerializerOptions EFDCDFNAODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x41BD480", Offset = "0x41BBA80", VA = "0x1841BD480", Slot = "28")]
	public override void Write(Utf8JsonWriter JFIDOOOHFIL, Dictionary<TKey, int> DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x41BD6A0", Offset = "0x41BBCA0", VA = "0x1841BD6A0")]
	public KKFBHIMFNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class KKPECMIEHBA<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x41BF300", Offset = "0x41BD900", VA = "0x1841BF300", Slot = "27")]
	public override T[] Read(Utf8JsonReader MMDEOFGAFEK, Type OMJKGAMFGPH, JsonSerializerOptions EFDCDFNAODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x41BF620", Offset = "0x41BDC20", VA = "0x1841BF620", Slot = "28")]
	public override void Write(Utf8JsonWriter JFIDOOOHFIL, T[] DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3849130", Offset = "0x3847730", VA = "0x183849130")]
	protected KKPECMIEHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class FEECAKGAMOM<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? NPKHCBIJGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x868CB0", Offset = "0x8672B0", VA = "0x180868CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T GJOCMGCACIL(float[] EJHPODPBOEP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] HPKFMOENKFN(T DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F070", Offset = "0x3C0D670", VA = "0x183C0F070", Slot = "27")]
	public override T Read(Utf8JsonReader MMDEOFGAFEK, Type OMJKGAMFGPH, JsonSerializerOptions EFDCDFNAODA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C0F720", Offset = "0x3C0DD20", VA = "0x183C0F720", Slot = "28")]
	public override void Write(Utf8JsonWriter JFIDOOOHFIL, T DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3849130", Offset = "0x3847730", VA = "0x183849130")]
	protected FEECAKGAMOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NIPBMBONHDB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C980", Offset = "0x6A2AF80", VA = "0x186A2C980")]
	public static void GAGBNBKFKOM(this Utf8JsonWriter JFIDOOOHFIL, string BHPJGALIOMC, bool DMNGPNKHPKF, bool DNKAMNBGFFH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C960", Offset = "0x6A2AF60", VA = "0x186A2C960")]
	public static bool DHGEOPEDFEI(this Utf8JsonReader MMDEOFGAFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C710", Offset = "0x6A2AD10", VA = "0x186A2C710")]
	public static void AHPDELCKHPJ(this Utf8JsonWriter JFIDOOOHFIL, string BHPJGALIOMC, int? DMNGPNKHPKF, int DNKAMNBGFFH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD86B0", Offset = "0x2CD6CB0", VA = "0x182CD86B0")]
	public static void FKNBHMEDDCI<T>(this Utf8JsonWriter JFIDOOOHFIL, string BHPJGALIOMC, JsonSerializerOptions EFDCDFNAODA, T KPJDKHEOHPO, T JEPMEOKEDGK) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C7C0", Offset = "0x6A2ADC0", VA = "0x186A2C7C0")]
	public static void AOIMPBKMJJE(this Utf8JsonWriter JFIDOOOHFIL, float DMNGPNKHPKF, int DPKAKCFPDEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FGPMNMJNENL<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C17100", Offset = "0x3C15700", VA = "0x183C17100", Slot = "27")]
	public override T Read(Utf8JsonReader MMDEOFGAFEK, Type OMJKGAMFGPH, JsonSerializerOptions EFDCDFNAODA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C171B0", Offset = "0x3C157B0", VA = "0x183C171B0", Slot = "28")]
	public override void Write(Utf8JsonWriter JFIDOOOHFIL, T DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38DB520", Offset = "0x38D9B20", VA = "0x1838DB520")]
	public FGPMNMJNENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NJAKFPBNAPM : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GCLKHGOKFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x874B30", Offset = "0x873130", VA = "0x180874B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x874EB0", Offset = "0x8734B0", VA = "0x180874EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C9B0", Offset = "0x6A2AFB0", VA = "0x186A2C9B0", Slot = "27")]
	public override float Read(Utf8JsonReader MMDEOFGAFEK, Type OMJKGAMFGPH, JsonSerializerOptions EFDCDFNAODA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C9C0", Offset = "0x6A2AFC0", VA = "0x186A2C9C0", Slot = "28")]
	public override void Write(Utf8JsonWriter JFIDOOOHFIL, float DMNGPNKHPKF, JsonSerializerOptions EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CB60", Offset = "0x6A2B160", VA = "0x186A2CB60")]
	public NJAKFPBNAPM()
	{
	}
}
namespace Cpp2IlInjected;

internal class AddressAttribute : Attribute
{
	public string RVA;

	public string Offset;

	public string VA;

	public string Slot;
}
internal class FieldOffsetAttribute : Attribute
{
	public string Offset;
}
internal class AttributeAttribute : Attribute
{
	public string Name;

	public string RVA;

	public string Offset;
}
internal class MetadataOffsetAttribute : Attribute
{
	public string Offset;
}
internal class TokenAttribute : Attribute
{
	public string Token;
}
internal class AnalysisFailedException : Exception
{
	public AnalysisFailedException(string message)
		: base(message)
	{
	}
}
