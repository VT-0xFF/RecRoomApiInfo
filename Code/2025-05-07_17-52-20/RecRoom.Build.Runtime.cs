using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum HAHGGGFLCBD
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
public enum MHNJMFDGGNB
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
public class GENPBBPPBOP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly Type BIDGANJABAO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x774AF40", Offset = "0x7749F40", VA = "0x18774AF40")]
	public GENPBBPPBOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
	public GENPBBPPBOP(Type DAPOBDHLIDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class HFNDOHMNDKN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
	public HFNDOHMNDKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
[HDOFECNEBCF]
public class DPLLDPLMIMF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly string IGEFPDLMKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly HAHGGGFLCBD IHIBPGOGCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly MHNJMFDGGNB LMPFHKHMEGH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B33D70", Offset = "0x7B32D70", VA = "0x187B33D70")]
	public DPLLDPLMIMF(string CPPCOFPOHNJ, HAHGGGFLCBD KEJHAPEFGNI = HAHGGGFLCBD.All, MHNJMFDGGNB FCBHEGJABIG = MHNJMFDGGNB.Default)
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
