using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum BOECCJPJNJC
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
public enum KDIDEOPEOKO
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
public class CPJHCBMNPMK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type PBKMFLLJAPH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x687CE10", Offset = "0x687C010", VA = "0x18687CE10")]
	public CPJHCBMNPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
	public CPJHCBMNPMK(Type AFIALKEDALA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class NJIABFDNMJE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
	public NJIABFDNMJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
[EHOBLBPLFLK]
public class NJAIIPLKMMP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string OADBOFMGEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly BOECCJPJNJC FIKDHBNGFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly KDIDEOPEOKO KIHOOLJJMLH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B49370", Offset = "0x6B48570", VA = "0x186B49370")]
	public NJAIIPLKMMP(string NIEMKMPHDOD, BOECCJPJNJC JGCOBKJDHMN = BOECCJPJNJC.All, KDIDEOPEOKO ADOOJAAPALH = KDIDEOPEOKO.Default)
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
