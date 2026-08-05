using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum GNAFNOGKEJG
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
public enum DMEEIKFEODH
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
public class PCKJHKDEMDM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type BNPCAENAMLA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69E0780", Offset = "0x69DF180", VA = "0x1869E0780")]
	public PCKJHKDEMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
	public PCKJHKDEMDM(Type FAMIOLJANFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Field)]
public class KOAGJHHPIAF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
	public KOAGJHHPIAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
[IMCMBHOHDOO]
public class IHABPOHGELI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string IMACFOGGFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly GNAFNOGKEJG LKJGGBMGNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DMEEIKFEODH KCCCGMDGKIF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6880", Offset = "0x6CD5280", VA = "0x186CD6880")]
	public IHABPOHGELI(string FDEAILAGNFH, GNAFNOGKEJG GJEEFAGOKEO = GNAFNOGKEJG.All, DMEEIKFEODH DLEPOKFBANG = DMEEIKFEODH.Default)
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
