using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GAKMPEJNGGB<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void OHBBJCLIMKK(Utf8JsonReader NAEIDONDAPA);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x47E43B0", Offset = "0x47E37B0", VA = "0x1847E43B0", Slot = "27")]
	public override T Read(Utf8JsonReader KILJCGGJECG, Type EJDCEKIJDOM, JsonSerializerOptions PJIJGMDDLKH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47E45A0", Offset = "0x47E39A0", VA = "0x1847E45A0", Slot = "28")]
	public override void Write(Utf8JsonWriter NACIMEJMHHK, T FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void MIJEFDICLCI(Utf8JsonReader KILJCGGJECG, JsonSerializerOptions PJIJGMDDLKH, string CGIHFPMPHOC, T DENKIGKMPCB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void IJFLMPCGHAA(Utf8JsonWriter NACIMEJMHHK, T FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x41CADF0", Offset = "0x41CA1F0", VA = "0x1841CADF0")]
	protected GAKMPEJNGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class APNKKPEJGHF : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7851A30", Offset = "0x7850E30", VA = "0x187851A30")]
	public APNKKPEJGHF(string CGIHFPMPHOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CAEIBOFJLFH<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x612AEA0", Offset = "0x612A2A0", VA = "0x18612AEA0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader KILJCGGJECG, Type EJDCEKIJDOM, JsonSerializerOptions PJIJGMDDLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x612B0E0", Offset = "0x612A4E0", VA = "0x18612B0E0", Slot = "28")]
	public override void Write(Utf8JsonWriter NACIMEJMHHK, Dictionary<TKey, int> FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4777B50", Offset = "0x4776F50", VA = "0x184777B50")]
	public CAEIBOFJLFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class ACIDIKDAFCJ<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x47F39A0", Offset = "0x47F2DA0", VA = "0x1847F39A0", Slot = "27")]
	public override T[] Read(Utf8JsonReader KILJCGGJECG, Type EJDCEKIJDOM, JsonSerializerOptions PJIJGMDDLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x47F3CB0", Offset = "0x47F30B0", VA = "0x1847F3CB0", Slot = "28")]
	public override void Write(Utf8JsonWriter NACIMEJMHHK, T[] FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x41E6340", Offset = "0x41E5740", VA = "0x1841E6340")]
	protected ACIDIKDAFCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class CKNIAACGDCF<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int DLMGPHHMEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? NNLLAPJIDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x993360", Offset = "0x992760", VA = "0x180993360")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T NCCEDEPPPHA(float[] EDJBENPLFOA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] ICFDPGCHGNH(T FIIKLGCIAGG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6210AD0", Offset = "0x620FED0", VA = "0x186210AD0", Slot = "27")]
	public override T Read(Utf8JsonReader KILJCGGJECG, Type EJDCEKIJDOM, JsonSerializerOptions PJIJGMDDLKH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6211310", Offset = "0x6210710", VA = "0x186211310", Slot = "28")]
	public override void Write(Utf8JsonWriter NACIMEJMHHK, T FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x41E6340", Offset = "0x41E5740", VA = "0x1841E6340")]
	protected CKNIAACGDCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KLAAICBBFOH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7851FB0", Offset = "0x78513B0", VA = "0x187851FB0")]
	public static void KFGLECFCHLK(this Utf8JsonWriter NACIMEJMHHK, string CGIHFPMPHOC, bool FIIKLGCIAGG, bool MBADHELIPJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7851EE0", Offset = "0x78512E0", VA = "0x187851EE0")]
	public static bool EHCPJLFMBAF(this Utf8JsonReader KILJCGGJECG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7851C90", Offset = "0x7851090", VA = "0x187851C90")]
	public static void AEJIPFCLBJL(this Utf8JsonWriter NACIMEJMHHK, string CGIHFPMPHOC, int? FIIKLGCIAGG, int MBADHELIPJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7851F00", Offset = "0x7851300", VA = "0x187851F00")]
	public static void JHLKKAKNNBJ(this Utf8JsonWriter NACIMEJMHHK, string CGIHFPMPHOC, long? FIIKLGCIAGG, long MBADHELIPJM = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x36B51F0", Offset = "0x36B45F0", VA = "0x1836B51F0")]
	public static void DJHOPJAADNL<T>(this Utf8JsonWriter NACIMEJMHHK, string CGIHFPMPHOC, JsonSerializerOptions PJIJGMDDLKH, T NMBONOELKFM, T ADFNCKOMLCE) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7851D40", Offset = "0x7851140", VA = "0x187851D40")]
	public static void EBABIEDBCJM(this Utf8JsonWriter NACIMEJMHHK, float FIIKLGCIAGG, int CBEPAEDCGCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BDCINLOIEPD<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5B5C3D0", Offset = "0x5B5B7D0", VA = "0x185B5C3D0", Slot = "27")]
	public override T Read(Utf8JsonReader KILJCGGJECG, Type EJDCEKIJDOM, JsonSerializerOptions PJIJGMDDLKH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5B5C470", Offset = "0x5B5B870", VA = "0x185B5C470", Slot = "28")]
	public override void Write(Utf8JsonWriter NACIMEJMHHK, T FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x430D3A0", Offset = "0x430C7A0", VA = "0x18430D3A0")]
	public BDCINLOIEPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KANOFPKFAON : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EICNJJOLBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99F890", Offset = "0x99EC90", VA = "0x18099F890")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99F880", Offset = "0x99EC80", VA = "0x18099F880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7851AA0", Offset = "0x7850EA0", VA = "0x187851AA0", Slot = "27")]
	public override float Read(Utf8JsonReader KILJCGGJECG, Type EJDCEKIJDOM, JsonSerializerOptions PJIJGMDDLKH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7851AB0", Offset = "0x7850EB0", VA = "0x187851AB0", Slot = "28")]
	public override void Write(Utf8JsonWriter NACIMEJMHHK, float FIIKLGCIAGG, JsonSerializerOptions PJIJGMDDLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7851C50", Offset = "0x7851050", VA = "0x187851C50")]
	public KANOFPKFAON()
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
