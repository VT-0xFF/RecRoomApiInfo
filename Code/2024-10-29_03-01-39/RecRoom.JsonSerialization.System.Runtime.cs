using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class OEBNCDGEMAM<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void LMFBOGDNPHB(Utf8JsonReader AAGDOBFBLJM);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4AF2360", Offset = "0x4AF1360", VA = "0x184AF2360", Slot = "27")]
	public override T Read(Utf8JsonReader EEKHIEJPCBE, Type JPKGEFOHBCJ, JsonSerializerOptions HKFJGLOCDGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4AF2560", Offset = "0x4AF1560", VA = "0x184AF2560", Slot = "28")]
	public override void Write(Utf8JsonWriter FOJCOMJJHIM, T BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void ABMCBADKGAH(Utf8JsonReader EEKHIEJPCBE, JsonSerializerOptions HKFJGLOCDGD, string ODFHIAEGOOC, T KBDJJFPFPLD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void EPJFEGONELN(Utf8JsonWriter FOJCOMJJHIM, T BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3C153C0", Offset = "0x3C143C0", VA = "0x183C153C0")]
	protected OEBNCDGEMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CLMAKCIKIAK : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD920", Offset = "0x6EDC920", VA = "0x186EDD920")]
	public CLMAKCIKIAK(string ODFHIAEGOOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NCGEONKLFIG<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49C5270", Offset = "0x49C4270", VA = "0x1849C5270", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader EEKHIEJPCBE, Type JPKGEFOHBCJ, JsonSerializerOptions HKFJGLOCDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49C54B0", Offset = "0x49C44B0", VA = "0x1849C54B0", Slot = "28")]
	public override void Write(Utf8JsonWriter FOJCOMJJHIM, Dictionary<TKey, int> BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x49C56E0", Offset = "0x49C46E0", VA = "0x1849C56E0")]
	public NCGEONKLFIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class DAEEOIJLHGC<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D24A40", Offset = "0x5D23A40", VA = "0x185D24A40", Slot = "27")]
	public override T[] Read(Utf8JsonReader EEKHIEJPCBE, Type JPKGEFOHBCJ, JsonSerializerOptions HKFJGLOCDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D24D50", Offset = "0x5D23D50", VA = "0x185D24D50", Slot = "28")]
	public override void Write(Utf8JsonWriter FOJCOMJJHIM, T[] BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E110", Offset = "0x3C2D110", VA = "0x183C2E110")]
	protected DAEEOIJLHGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class NIGHKGKCPAG<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? HENJFDHDDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EC0", Offset = "0x8B8EC0", VA = "0x1808B9EC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T BNBIBPPNJLJ(float[] CMDOFHABOHN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] LKGOBMDPHFJ(T BJDKOHEGDOK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x49E9D20", Offset = "0x49E8D20", VA = "0x1849E9D20", Slot = "27")]
	public override T Read(Utf8JsonReader EEKHIEJPCBE, Type JPKGEFOHBCJ, JsonSerializerOptions HKFJGLOCDGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x49EA770", Offset = "0x49E9770", VA = "0x1849EA770", Slot = "28")]
	public override void Write(Utf8JsonWriter FOJCOMJJHIM, T BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C2E110", Offset = "0x3C2D110", VA = "0x183C2E110")]
	protected NIGHKGKCPAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NODPPIJPLHB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDDF0", Offset = "0x6EDCDF0", VA = "0x186EDDDF0")]
	public static void LLKJOAGJJGP(this Utf8JsonWriter FOJCOMJJHIM, string ODFHIAEGOOC, bool BJDKOHEGDOK, bool MJBMFFMBOMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDC30", Offset = "0x6EDCC30", VA = "0x186EDDC30")]
	public static bool BNFGHNDDFMB(this Utf8JsonReader EEKHIEJPCBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDB80", Offset = "0x6EDCB80", VA = "0x186EDDB80")]
	public static void AMPACIIOFGO(this Utf8JsonWriter FOJCOMJJHIM, string ODFHIAEGOOC, int? BJDKOHEGDOK, int MJBMFFMBOMO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x312C1B0", Offset = "0x312B1B0", VA = "0x18312C1B0")]
	public static void FNIBNEKILLE<T>(this Utf8JsonWriter FOJCOMJJHIM, string ODFHIAEGOOC, JsonSerializerOptions HKFJGLOCDGD, T ADMAMDKLPIC, T GJOAKGBDOOO) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDC50", Offset = "0x6EDCC50", VA = "0x186EDDC50")]
	public static void JHKHCNDJMKC(this Utf8JsonWriter FOJCOMJJHIM, float BJDKOHEGDOK, int GJHAPLMJCBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MHNOGHKKEND<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4950BA0", Offset = "0x494FBA0", VA = "0x184950BA0", Slot = "27")]
	public override T Read(Utf8JsonReader EEKHIEJPCBE, Type JPKGEFOHBCJ, JsonSerializerOptions HKFJGLOCDGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4950C40", Offset = "0x494FC40", VA = "0x184950C40", Slot = "28")]
	public override void Write(Utf8JsonWriter FOJCOMJJHIM, T BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFEA0", Offset = "0x3CBEEA0", VA = "0x183CBFEA0")]
	public MHNOGHKKEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LLPACHGLPAF : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HBOFFDEEFJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C3130", Offset = "0x8C2130", VA = "0x1808C3130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C34A0", Offset = "0x8C24A0", VA = "0x1808C34A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD990", Offset = "0x6EDC990", VA = "0x186EDD990", Slot = "27")]
	public override float Read(Utf8JsonReader EEKHIEJPCBE, Type JPKGEFOHBCJ, JsonSerializerOptions HKFJGLOCDGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD9A0", Offset = "0x6EDC9A0", VA = "0x186EDD9A0", Slot = "28")]
	public override void Write(Utf8JsonWriter FOJCOMJJHIM, float BJDKOHEGDOK, JsonSerializerOptions HKFJGLOCDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDB40", Offset = "0x6EDCB40", VA = "0x186EDDB40")]
	public LLPACHGLPAF()
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
