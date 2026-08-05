using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
public sealed class HBJJANJBCJJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public HBJJANJBCJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.All)]
public sealed class COEGLMEJGKI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x82271D0", Offset = "0x8225FD0", VA = "0x1882271D0")]
	public COEGLMEJGKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70CC9E0", Offset = "0x70CB7E0", VA = "0x1870CC9E0")]
	public COEGLMEJGKI(NMIBGCJJHLL CIPNOIAIJLF, CHKPHFGNACA OKDEOCAAHHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
public sealed class NDFOMBGNBPL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82271D0", Offset = "0x8225FD0", VA = "0x1882271D0")]
	public NDFOMBGNBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x70CC9E0", Offset = "0x70CB7E0", VA = "0x1870CC9E0")]
	public NDFOMBGNBPL(NMIBGCJJHLL CIPNOIAIJLF, CHKPHFGNACA OKDEOCAAHHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Flags]
public enum NMIBGCJJHLL
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Default = 7,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Access = 1,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Assign = 2,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InstantiatedWithFixedConstructorSignature = 4,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InstantiatedNoFixedConstructorSignature = 8
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum CHKPHFGNACA
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Itself = 1,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Members = 2,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	WithInheritors = 4,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	WithMembers = 3
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public sealed class LLGEDOLAEHA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
	public LLGEDOLAEHA()
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
