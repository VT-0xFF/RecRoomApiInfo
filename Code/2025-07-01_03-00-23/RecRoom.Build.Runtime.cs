using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum CNFIDEOBGMD
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
public enum PCPEBGMLLHB
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
	ScriptableObjects = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	AllObjects = 0x818,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class AKMGCHAMAFN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly Type NPDAGKIBOOG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A600F0", Offset = "0x7A5E6F0", VA = "0x187A600F0")]
	public AKMGCHAMAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
	public AKMGCHAMAFN(Type BMGGIJHAALN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class ECKJDEJCDHF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
	public ECKJDEJCDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
[FGPLGOMCLID]
public class LINAGGHLKHF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly string AKFILGPNLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly CNFIDEOBGMD CHNEJFIALHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly PCPEBGMLLHB PKMOLLDNDCF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E76DC0", Offset = "0x7E753C0", VA = "0x187E76DC0")]
	public LINAGGHLKHF(string IFCCFEIMACN, CNFIDEOBGMD LKBCCCOPNHK = CNFIDEOBGMD.All, PCPEBGMLLHB NNNBNABDGFN = PCPEBGMLLHB.Default)
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
