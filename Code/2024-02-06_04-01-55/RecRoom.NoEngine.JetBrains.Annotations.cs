using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
public sealed class ODBKCIMGCLG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
	public ODBKCIMGCLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.All)]
public sealed class EIHCBHFOBFN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6111A10", Offset = "0x6110E10", VA = "0x186111A10")]
	public EIHCBHFOBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5382A60", Offset = "0x5381E60", VA = "0x185382A60")]
	public EIHCBHFOBFN(LMCJBJDMPBN PMEBFBICFIB, BNKPMDOJOME EEJCLNNPOIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
public sealed class GEJPPJEKHNI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6111A10", Offset = "0x6110E10", VA = "0x186111A10")]
	public GEJPPJEKHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5382A60", Offset = "0x5381E60", VA = "0x185382A60")]
	public GEJPPJEKHNI(LMCJBJDMPBN PMEBFBICFIB, BNKPMDOJOME EEJCLNNPOIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Flags]
public enum LMCJBJDMPBN
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
public enum BNKPMDOJOME
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
public sealed class MGDCJEFAPMO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
	public MGDCJEFAPMO()
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
