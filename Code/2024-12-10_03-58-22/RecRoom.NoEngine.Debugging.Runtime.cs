using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum FMKJGCPEMBN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Assignable,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Equal
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class GGJJOMFGFJD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2E05920", Offset = "0x2E04520", VA = "0x182E05920")]
	public static Func<Type, bool> ALNOMJIKOAJ<T>(this FMKJGCPEMBN GMNCELIMKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2C8D780", Offset = "0x2C8C380", VA = "0x182C8D780")]
	private static bool JAKCNMGNILA<T>(Type KNFCMJNOIOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E05D00", Offset = "0x2E04900", VA = "0x182E05D00")]
	private static bool ELOBBOMPHLA<T>(Type KNFCMJNOIOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CFGKMPIAPCM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE7B0", Offset = "0x2BFD3B0", VA = "0x182BFE7B0")]
	public static string PCHGOHGJPJJ<T>(T DIBAENLMLKH, string HGKFJIOFOLJ = ", ", [Optional] T IEDAFAANJNE) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE4F0", Offset = "0x2BFD0F0", VA = "0x182BFE4F0")]
	public static string LOMAKFGAPLI<T>(T DIBAENLMLKH, string HGKFJIOFOLJ = ", ", params T[] MMIMHLJNGNP) where T : struct, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE290", Offset = "0x2BFCE90", VA = "0x182BFE290")]
	private static bool FCOEHEAOGKL<T>(T[] MMIMHLJNGNP, T JEFLNAOAGOK, IEqualityComparer<T> DMMDHIPDEFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class GMGHGCFCDOA<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly Func<Type, bool> DECJLAHDDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Action<JsonWriter, T> OCBKJFAHNNN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC450", Offset = "0x3DFB050", VA = "0x183DFC450", Slot = "6")]
	public override bool CanConvert(Type KNFCMJNOIOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0A50", Offset = "0x3EEF650", VA = "0x183EF0A50", Slot = "5")]
	public override object ReadJson(JsonReader DMECMNHFOBP, Type KNFCMJNOIOG, object KOLEBPHAPFH, JsonSerializer JMBMMMHNFMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3EF10D0", Offset = "0x3EEFCD0", VA = "0x183EF10D0", Slot = "4")]
	public override void WriteJson(JsonWriter CDCPEBLNAND, object CABLCDOIFFL, JsonSerializer JMBMMMHNFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF16A0", Offset = "0x3EF02A0", VA = "0x183EF16A0")]
	internal GMGHGCFCDOA(Func<Type, bool> DECJLAHDDGH, Action<JsonWriter, T> OCBKJFAHNNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JGMOCABFACA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2E99790", Offset = "0x2E98390", VA = "0x182E99790")]
	public static GMGHGCFCDOA<T> LMDPPDEOAIA<T>(Action<JsonWriter, T> OCBKJFAHNNN, FMKJGCPEMBN EKDMGEBLGOD = FMKJGCPEMBN.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FGDEKKMKPPL
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static JsonConverter[] DDBAMDFGILF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter HCLAEMMEKNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DEC0", Offset = "0x6D3CAC0", VA = "0x186D3DEC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter DHIALCBJCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DF10", Offset = "0x6D3CB10", VA = "0x186D3DF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter FPPGELHLPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DDD0", Offset = "0x6D3C9D0", VA = "0x186D3DDD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter PIPJDDEONNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DE20", Offset = "0x6D3CA20", VA = "0x186D3DE20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JsonConverter JEFCIJNMDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D3DE70", Offset = "0x6D3CA70", VA = "0x186D3DE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IOPKGGPPHMK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D3E470", Offset = "0x6D3D070", VA = "0x186D3E470")]
	public static string KJPJKBKBGNI(this object GMNCELIMKIF, JsonConverter[] GIAJAHPCDGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class FEPNDAGPEKO<T> : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Func<Type, bool> DECJLAHDDGH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC450", Offset = "0x3DFB050", VA = "0x183DFC450", Slot = "6")]
	public override bool CanConvert(Type KNFCMJNOIOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC480", Offset = "0x3DFB080", VA = "0x183DFC480", Slot = "5")]
	public override object ReadJson(JsonReader DMECMNHFOBP, Type KNFCMJNOIOG, object KOLEBPHAPFH, JsonSerializer JMBMMMHNFMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC550", Offset = "0x3DFB150", VA = "0x183DFC550", Slot = "4")]
	public override void WriteJson(JsonWriter CDCPEBLNAND, object CABLCDOIFFL, JsonSerializer JMBMMMHNFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
	internal FEPNDAGPEKO(Func<Type, bool> DECJLAHDDGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CHECCMMCGJL
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C00700", Offset = "0x2BFF300", VA = "0x182C00700")]
	public static FEPNDAGPEKO<T> LMDPPDEOAIA<T>(FMKJGCPEMBN EKDMGEBLGOD = FMKJGCPEMBN.Assignable)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class BPEGNCOINEP : JsonConverter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Func<Type, bool> DECJLAHDDGH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC450", Offset = "0x3DFB050", VA = "0x183DFC450", Slot = "6")]
	public override bool CanConvert(Type KNFCMJNOIOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DCC0", Offset = "0x6D3C8C0", VA = "0x186D3DCC0", Slot = "5")]
	public override object ReadJson(JsonReader DMECMNHFOBP, Type KNFCMJNOIOG, object KOLEBPHAPFH, JsonSerializer JMBMMMHNFMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DD60", Offset = "0x6D3C960", VA = "0x186D3DD60", Slot = "4")]
	public override void WriteJson(JsonWriter CDCPEBLNAND, object CABLCDOIFFL, JsonSerializer JMBMMMHNFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
	public BPEGNCOINEP(Func<Type, bool> DECJLAHDDGH)
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
