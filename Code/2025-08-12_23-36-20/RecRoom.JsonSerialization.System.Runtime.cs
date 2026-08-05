using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class OPGIDGAGAID<T> : JsonConverter<T> where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	protected delegate void LPCPKHGJKOK(Utf8JsonReader BIHPDMNFJGD);

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5B2E8C0", Offset = "0x5B2D6C0", VA = "0x185B2E8C0", Slot = "27")]
	public override T Read(Utf8JsonReader CCOEJPOOOPD, Type DBHMJBFCIIF, JsonSerializerOptions PMEODJMCJOL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B2EAB0", Offset = "0x5B2D8B0", VA = "0x185B2EAB0", Slot = "28")]
	public override void Write(Utf8JsonWriter AOOOLDFNADH, T HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "35")]
	public abstract void BIIDMPKJJJK(Utf8JsonReader CCOEJPOOOPD, JsonSerializerOptions PMEODJMCJOL, string BPCKHCGHBJN, T IIHDHELGAFA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "36")]
	public abstract void NHEFOMBPPHA(Utf8JsonWriter AOOOLDFNADH, T HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4A061B0", Offset = "0x4A04FB0", VA = "0x184A061B0")]
	protected OPGIDGAGAID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class LMPHIHGFDOE : JsonException
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83CB1C0", Offset = "0x83C9FC0", VA = "0x1883CB1C0")]
	public LMPHIHGFDOE(string BPCKHCGHBJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HLCHJGMNGBL<TKey> : JsonConverter<Dictionary<TKey, int>> where TKey : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x50C8DA0", Offset = "0x50C7BA0", VA = "0x1850C8DA0", Slot = "27")]
	public override Dictionary<TKey, int> Read(Utf8JsonReader CCOEJPOOOPD, Type DBHMJBFCIIF, JsonSerializerOptions PMEODJMCJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50C8FA0", Offset = "0x50C7DA0", VA = "0x1850C8FA0", Slot = "28")]
	public override void Write(Utf8JsonWriter AOOOLDFNADH, Dictionary<TKey, int> HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4F5A870", Offset = "0x4F59670", VA = "0x184F5A870")]
	public HLCHJGMNGBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class LBPGFKLMCEP<T> : JsonConverter<T[]> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x56769C0", Offset = "0x56757C0", VA = "0x1856769C0", Slot = "27")]
	public override T[] Read(Utf8JsonReader CCOEJPOOOPD, Type DBHMJBFCIIF, JsonSerializerOptions PMEODJMCJOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5676CA0", Offset = "0x5675AA0", VA = "0x185676CA0", Slot = "28")]
	public override void Write(Utf8JsonWriter AOOOLDFNADH, T[] HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A254F0", Offset = "0x4A242F0", VA = "0x184A254F0")]
	protected LBPGFKLMCEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class PJAEBIFOHDB<T> : JsonConverter<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected abstract int KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int? OECEHGBNIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA98B70", Offset = "0xA97970", VA = "0x180A98B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "36")]
	protected abstract T LFLGOBPLNLF(float[] OOFDDMCKJPA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "37")]
	protected abstract float[] EKFIPPAFKPM(T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5BFC550", Offset = "0x5BFB350", VA = "0x185BFC550", Slot = "27")]
	public override T Read(Utf8JsonReader CCOEJPOOOPD, Type DBHMJBFCIIF, JsonSerializerOptions PMEODJMCJOL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5BFCF60", Offset = "0x5BFBD60", VA = "0x185BFCF60", Slot = "28")]
	public override void Write(Utf8JsonWriter AOOOLDFNADH, T HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A254F0", Offset = "0x4A242F0", VA = "0x184A254F0")]
	protected PJAEBIFOHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MCBLLNLMLLH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x83CB4A0", Offset = "0x83CA2A0", VA = "0x1883CB4A0")]
	public static void OJKGMGNNEJL(this Utf8JsonWriter AOOOLDFNADH, string BPCKHCGHBJN, bool HGMAIPELJHM, bool PGFMONBPOJI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83CB480", Offset = "0x83CA280", VA = "0x1883CB480")]
	public static bool FACKCIJBLNM(this Utf8JsonReader CCOEJPOOOPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x83CB4D0", Offset = "0x83CA2D0", VA = "0x1883CB4D0")]
	public static void ONFBGJIOAIE(this Utf8JsonWriter AOOOLDFNADH, string BPCKHCGHBJN, int? HGMAIPELJHM, int PGFMONBPOJI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x83CB230", Offset = "0x83CA030", VA = "0x1883CB230")]
	public static void CENBLGFEBBO(this Utf8JsonWriter AOOOLDFNADH, string BPCKHCGHBJN, long? HGMAIPELJHM, long PGFMONBPOJI = 0L)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF89D0", Offset = "0x3DF77D0", VA = "0x183DF89D0")]
	public static void KAJBDLFAEPB<T>(this Utf8JsonWriter AOOOLDFNADH, string BPCKHCGHBJN, JsonSerializerOptions PMEODJMCJOL, T DOMECMGKIBN, T DAAJIEJNDCF) where T : IEquatable<T>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83CB2E0", Offset = "0x83CA0E0", VA = "0x1883CB2E0")]
	public static void DOPHGFLANNK(this Utf8JsonWriter AOOOLDFNADH, float HGMAIPELJHM, int ECJOLECKGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CNPIKEMDMMH<T> : JsonConverter<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D43110", Offset = "0x6D41F10", VA = "0x186D43110", Slot = "27")]
	public override T Read(Utf8JsonReader CCOEJPOOOPD, Type DBHMJBFCIIF, JsonSerializerOptions PMEODJMCJOL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D431B0", Offset = "0x6D41FB0", VA = "0x186D431B0", Slot = "28")]
	public override void Write(Utf8JsonWriter AOOOLDFNADH, T HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4ACE190", Offset = "0x4ACCF90", VA = "0x184ACE190")]
	public CNPIKEMDMMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OBOFCGLLJIM : JsonConverter<float>
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BHDFCAFIBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAA2200", Offset = "0xAA1000", VA = "0x180AA2200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAA23A0", Offset = "0xAA11A0", VA = "0x180AA23A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83CB580", Offset = "0x83CA380", VA = "0x1883CB580", Slot = "27")]
	public override float Read(Utf8JsonReader CCOEJPOOOPD, Type DBHMJBFCIIF, JsonSerializerOptions PMEODJMCJOL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83CB590", Offset = "0x83CA390", VA = "0x1883CB590", Slot = "28")]
	public override void Write(Utf8JsonWriter AOOOLDFNADH, float HGMAIPELJHM, JsonSerializerOptions PMEODJMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83CB730", Offset = "0x83CA530", VA = "0x1883CB730")]
	public OBOFCGLLJIM()
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
