using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class ANCNMPOLBHF<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void LFAKLDNOEPL(Utf8JsonReader KBNPICMCGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4537590", Offset = "0x4536790", VA = "0x184537590", Slot = "27")]
	public override T Read(Utf8JsonReader NHPBIOODHLE, Type DMMPIANBNPK, JsonSerializerOptions GPDCLNOGPJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4537780", Offset = "0x4536980", VA = "0x184537780", Slot = "28")]
	public override void Write(Utf8JsonWriter JPECNBJOJNA, T OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void EIMLJGHKFLK(Utf8JsonReader NHPBIOODHLE, JsonSerializerOptions GPDCLNOGPJC, string LFNMBEJGJCH, T OCLIEIADJMI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void OJOHCAOMGPM(Utf8JsonWriter JPECNBJOJNA, T OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3EA3150", Offset = "0x3EA2350", VA = "0x183EA3150")]
	protected ANCNMPOLBHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DCIDMGOGEHA : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7253790", Offset = "0x7252990", VA = "0x187253790")]
	public DCIDMGOGEHA(string LFNMBEJGJCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AABFLBCPCOI<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x437FD60", Offset = "0x437EF60", VA = "0x18437FD60", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader NHPBIOODHLE, Type DMMPIANBNPK, JsonSerializerOptions GPDCLNOGPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x437FFA0", Offset = "0x437F1A0", VA = "0x18437FFA0", Slot = "28")]
	public override void Write(Utf8JsonWriter JPECNBJOJNA, Dictionary<TKey, int> OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4341580", Offset = "0x4340780", VA = "0x184341580")]
	public AABFLBCPCOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BBCGIPPBLCE<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x56319C0", Offset = "0x5630BC0", VA = "0x1856319C0", Slot = "27")]
	public override T[] Read(Utf8JsonReader NHPBIOODHLE, Type DMMPIANBNPK, JsonSerializerOptions GPDCLNOGPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5631CC0", Offset = "0x5630EC0", VA = "0x185631CC0", Slot = "28")]
	public override void Write(Utf8JsonWriter JPECNBJOJNA, T[] OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3EBD040", Offset = "0x3EBC240", VA = "0x183EBD040")]
	protected BBCGIPPBLCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class PAOGFDDEOIK<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? IJDHAKKDNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0B0", Offset = "0x8FA2B0", VA = "0x1808FB0B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T MDPHKHCBBAN(float[] CJALOAIIOIM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] ECDJLKNEFPJ(T OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F0EC30", Offset = "0x4F0DE30", VA = "0x184F0EC30", Slot = "27")]
	public override T Read(Utf8JsonReader NHPBIOODHLE, Type DMMPIANBNPK, JsonSerializerOptions GPDCLNOGPJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F0F4F0", Offset = "0x4F0E6F0", VA = "0x184F0F4F0", Slot = "28")]
	public override void Write(Utf8JsonWriter JPECNBJOJNA, T OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3EBD040", Offset = "0x3EBC240", VA = "0x183EBD040")]
	protected PAOGFDDEOIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KOPDHMHJOOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7253AC0", Offset = "0x7252CC0", VA = "0x187253AC0")]
	public static void GEGOMIIBBLP(this Utf8JsonWriter JPECNBJOJNA, string LFNMBEJGJCH, bool OMEFCJCOLII, bool JEBHMGJFPIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7253AA0", Offset = "0x7252CA0", VA = "0x187253AA0")]
	public static bool EHAMHHOELLF(this Utf8JsonReader NHPBIOODHLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72539F0", Offset = "0x7252BF0", VA = "0x1872539F0")]
	public static void ALJDMMIFMJF(this Utf8JsonWriter JPECNBJOJNA, string LFNMBEJGJCH, int? OMEFCJCOLII, int JEBHMGJFPIP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x33313A0", Offset = "0x33305A0", VA = "0x1833313A0")]
	public static void IICJHLLGPHE<T>(this Utf8JsonWriter JPECNBJOJNA, string LFNMBEJGJCH, JsonSerializerOptions GPDCLNOGPJC, T IAPIOFHOONE, T JFCGHDLACEG) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7253AF0", Offset = "0x7252CF0", VA = "0x187253AF0")]
	public static void HEEADEJBMNH(this Utf8JsonWriter JPECNBJOJNA, float OMEFCJCOLII, int ONAGNBOOGMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GOPAEMJAFEC<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x445E340", Offset = "0x445D540", VA = "0x18445E340", Slot = "27")]
	public override T Read(Utf8JsonReader NHPBIOODHLE, Type DMMPIANBNPK, JsonSerializerOptions GPDCLNOGPJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x445E3E0", Offset = "0x445D5E0", VA = "0x18445E3E0", Slot = "28")]
	public override void Write(Utf8JsonWriter JPECNBJOJNA, T OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3FAD2A0", Offset = "0x3FAC4A0", VA = "0x183FAD2A0")]
	public GOPAEMJAFEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FGEJGMDLCPO : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FDEKNFMJLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8FD6F0", Offset = "0x8FC8F0", VA = "0x1808FD6F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8FD8E0", Offset = "0x8FCAE0", VA = "0x1808FD8E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7253800", Offset = "0x7252A00", VA = "0x187253800", Slot = "27")]
	public override float Read(Utf8JsonReader NHPBIOODHLE, Type DMMPIANBNPK, JsonSerializerOptions GPDCLNOGPJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7253810", Offset = "0x7252A10", VA = "0x187253810", Slot = "28")]
	public override void Write(Utf8JsonWriter JPECNBJOJNA, float OMEFCJCOLII, JsonSerializerOptions GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72539B0", Offset = "0x7252BB0", VA = "0x1872539B0")]
	public FGEJGMDLCPO()
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
