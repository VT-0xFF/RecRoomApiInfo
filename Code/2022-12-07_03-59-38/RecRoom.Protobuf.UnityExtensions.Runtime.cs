using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ELIHFHCCGLI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6098E40", Offset = "0x6097A40", VA = "0x186098E40")]
	public static EEGFKLICEFP ANBECOLJJND(this in Color JELCPGCJLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6098F80", Offset = "0x6097B80", VA = "0x186098F80")]
	public static Color PPPEOPKFADK(this EEGFKLICEFP JELCPGCJLIH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6098EC0", Offset = "0x6097AC0", VA = "0x186098EC0")]
	public static Color? GIPMKMKANFF(this EEGFKLICEFP JELCPGCJLIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PMHDOKCOEAF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6099450", Offset = "0x6098050", VA = "0x186099450")]
	public static Quaternion GELIFNIEJAN(BNPJFHKLGFI GAGLKGONONJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6099650", Offset = "0x6098250", VA = "0x186099650")]
	public static NJNCFLICPCM PCIGHHMBFEN(Quaternion PEAJACFFINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60995E0", Offset = "0x60981E0", VA = "0x1860995E0")]
	public static Quaternion KOHPAOFJCHH(NJNCFLICPCM GAGLKGONONJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IMNOCEKEFPE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6098FE0", Offset = "0x6097BE0", VA = "0x186098FE0")]
	public static HCDLCEADMFK ANBECOLJJND(this in Quaternion JELCPGCJLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6099120", Offset = "0x6097D20", VA = "0x186099120")]
	public static HCDLCEADMFK GJKACEMENLL(this in Quaternion? JELCPGCJLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60991E0", Offset = "0x6097DE0", VA = "0x1860991E0")]
	public static Quaternion PPPEOPKFADK(this HCDLCEADMFK JELCPGCJLIH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6099060", Offset = "0x6097C60", VA = "0x186099060")]
	public static Quaternion? GIPMKMKANFF(this HCDLCEADMFK JELCPGCJLIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MJIEIPCFBBN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6099240", Offset = "0x6097E40", VA = "0x186099240")]
	public static NJNCFLICPCM ANBECOLJJND(this in Vector3 JELCPGCJLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6099340", Offset = "0x6097F40", VA = "0x186099340")]
	public static NJNCFLICPCM GJKACEMENLL(this in Vector3? JELCPGCJLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6099400", Offset = "0x6098000", VA = "0x186099400")]
	public static Vector3 PPPEOPKFADK(this NJNCFLICPCM JELCPGCJLIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60992B0", Offset = "0x6097EB0", VA = "0x1860992B0")]
	public static Vector3? GIPMKMKANFF(this NJNCFLICPCM JELCPGCJLIH)
	{
		return null;
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
