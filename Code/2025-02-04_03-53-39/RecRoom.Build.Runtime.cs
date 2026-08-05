using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum PHMBGBLPLLC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Release = 1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Debug = 2,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Promo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	All = 7
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum DBKEPLEOEHB
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Default = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	ArtAssets = 4,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Scenes = 8,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Prefabs = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Localization = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	RRUI = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Circuits = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	CodeOnly = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Addressables = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Settings = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	AllObjects = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class LKHJBNCKCPE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type DDGHDJLIJOA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E31B70", Offset = "0x6E30970", VA = "0x186E31B70")]
	public LKHJBNCKCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
	public LKHJBNCKCPE(Type LHBKGCMHHPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class FLJEFEJAJLI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
	public FLJEFEJAJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
[EPAGCKJMNGC]
public class OOAOFKBEMDD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string JPLFKJOMPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly PHMBGBLPLLC BGIFNEDMMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DBKEPLEOEHB CEENMCKGOGI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x715FF20", Offset = "0x715ED20", VA = "0x18715FF20")]
	public OOAOFKBEMDD(string JKCGKCGJDHA, PHMBGBLPLLC JADINKDNPDP = PHMBGBLPLLC.All, DBKEPLEOEHB BLNAIMPCFJA = DBKEPLEOEHB.Default)
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
