using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class LBAFJCNIFAL<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void DKCOPMBBMLN(Utf8JsonReader NOMFBHAJODM);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x47BA320", Offset = "0x47B9720", VA = "0x1847BA320", Slot = "27")]
	public override T Read(Utf8JsonReader IEMPDPINHLH, Type LLCOMEBJFJG, JsonSerializerOptions MFKLHLPHDGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47BA520", Offset = "0x47B9920", VA = "0x1847BA520", Slot = "28")]
	public override void Write(Utf8JsonWriter EEKKIBDAGAJ, T HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void DBIFBBKNPKJ(Utf8JsonReader IEMPDPINHLH, JsonSerializerOptions MFKLHLPHDGD, string NHHEMHBDHEB, T FKIFNEPLBJJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void IFIHNDEFPII(Utf8JsonWriter EEKKIBDAGAJ, T HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F5A0", Offset = "0x3C4E9A0", VA = "0x183C4F5A0")]
	protected LBAFJCNIFAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FKCADIFNPCN : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70283F0", Offset = "0x70277F0", VA = "0x1870283F0")]
	public FKCADIFNPCN(string NHHEMHBDHEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HEILGEFHAHB<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x423D5A0", Offset = "0x423C9A0", VA = "0x18423D5A0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader IEMPDPINHLH, Type LLCOMEBJFJG, JsonSerializerOptions MFKLHLPHDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x423D7E0", Offset = "0x423CBE0", VA = "0x18423D7E0", Slot = "28")]
	public override void Write(Utf8JsonWriter EEKKIBDAGAJ, Dictionary<TKey, int> HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x40DEE80", Offset = "0x40DE280", VA = "0x1840DEE80")]
	public HEILGEFHAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class CGGJHBBCHJJ<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5708FB0", Offset = "0x57083B0", VA = "0x185708FB0", Slot = "27")]
	public override T[] Read(Utf8JsonReader IEMPDPINHLH, Type LLCOMEBJFJG, JsonSerializerOptions MFKLHLPHDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x57092C0", Offset = "0x57086C0", VA = "0x1857092C0", Slot = "28")]
	public override void Write(Utf8JsonWriter EEKKIBDAGAJ, T[] HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A0E0", Offset = "0x3C694E0", VA = "0x183C6A0E0")]
	protected CGGJHBBCHJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class LALLFLLFHHM<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? JJILBBJBEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D0CC0", Offset = "0x8D00C0", VA = "0x1808D0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T GIKNPLOBEMO(float[] KLODBELJCDF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] GPFELNBEICA(T HCPAOILCJCB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x47B7E60", Offset = "0x47B7260", VA = "0x1847B7E60", Slot = "27")]
	public override T Read(Utf8JsonReader IEMPDPINHLH, Type LLCOMEBJFJG, JsonSerializerOptions MFKLHLPHDGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x47B8DE0", Offset = "0x47B81E0", VA = "0x1847B8DE0", Slot = "28")]
	public override void Write(Utf8JsonWriter EEKKIBDAGAJ, T HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C6A0E0", Offset = "0x3C694E0", VA = "0x183C6A0E0")]
	protected LALLFLLFHHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IAOFPPFKLDC
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7028650", Offset = "0x7027A50", VA = "0x187028650")]
	public static void DMLEKGGEFAD(this Utf8JsonWriter EEKKIBDAGAJ, string NHHEMHBDHEB, bool HCPAOILCJCB, bool EKFBHIJFHMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7028680", Offset = "0x7027A80", VA = "0x187028680")]
	public static bool FAAOODGDMEI(this Utf8JsonReader IEMPDPINHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x70286A0", Offset = "0x7027AA0", VA = "0x1870286A0")]
	public static void GEJPPFOJJIJ(this Utf8JsonWriter EEKKIBDAGAJ, string NHHEMHBDHEB, int? HCPAOILCJCB, int EKFBHIJFHMA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x308E450", Offset = "0x308D850", VA = "0x18308E450")]
	public static void LBGJDFCNAPA<T>(this Utf8JsonWriter EEKKIBDAGAJ, string NHHEMHBDHEB, JsonSerializerOptions MFKLHLPHDGD, T BBFFJMPBBGO, T BPMEEKFEKMC) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7028750", Offset = "0x7027B50", VA = "0x187028750")]
	public static void LLOJNEHABNN(this Utf8JsonWriter EEKKIBDAGAJ, float HCPAOILCJCB, int AFDGMBOCHEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GPKGMJFJAPL<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x41B7A30", Offset = "0x41B6E30", VA = "0x1841B7A30", Slot = "27")]
	public override T Read(Utf8JsonReader IEMPDPINHLH, Type LLCOMEBJFJG, JsonSerializerOptions MFKLHLPHDGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x41B7AD0", Offset = "0x41B6ED0", VA = "0x1841B7AD0", Slot = "28")]
	public override void Write(Utf8JsonWriter EEKKIBDAGAJ, T HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D2DD30", Offset = "0x3D2D130", VA = "0x183D2DD30")]
	public GPKGMJFJAPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GELHOGEMKLE : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LADJIOLCAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B70", Offset = "0x8C6F70", VA = "0x1808C7B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D80", Offset = "0x8C7180", VA = "0x1808C7D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7028460", Offset = "0x7027860", VA = "0x187028460", Slot = "27")]
	public override float Read(Utf8JsonReader IEMPDPINHLH, Type LLCOMEBJFJG, JsonSerializerOptions MFKLHLPHDGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7028470", Offset = "0x7027870", VA = "0x187028470", Slot = "28")]
	public override void Write(Utf8JsonWriter EEKKIBDAGAJ, float HCPAOILCJCB, JsonSerializerOptions MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7028610", Offset = "0x7027A10", VA = "0x187028610")]
	public GELHOGEMKLE()
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
