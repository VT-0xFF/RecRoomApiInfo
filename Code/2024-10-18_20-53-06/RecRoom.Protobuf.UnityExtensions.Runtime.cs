using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FNPNPPAAOFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7449C00", Offset = "0x7449000", VA = "0x187449C00")]
	public static EDNIOONDGDD IFDLICGNEEM([In] this Color MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7449BD0", Offset = "0x7448FD0", VA = "0x187449BD0")]
	public static Color AJCCBGLJAMD(this EDNIOONDGDD MCPMOAEEEOJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7449C80", Offset = "0x7449080", VA = "0x187449C80")]
	public static Color? LPBAHPMPEMD(this EDNIOONDGDD MCPMOAEEEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MHBNICNAMHD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7449DF0", Offset = "0x74491F0", VA = "0x187449DF0")]
	public static Quaternion IFBIDGLBHLM(GNDAGHPFHNB AIKOCCMKKAE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7449D00", Offset = "0x7449100", VA = "0x187449D00")]
	public static BDIAEBOELKP HLBMDGAFJIL(Quaternion HPHNCDLICLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x744A000", Offset = "0x7449400", VA = "0x18744A000")]
	public static Quaternion LFCOJLLALIP(BDIAEBOELKP AIKOCCMKKAE)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EMHNIAPMMGL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7449880", Offset = "0x7448C80", VA = "0x187449880")]
	public static KOIMMLDCPHL IFDLICGNEEM([In] this Quaternion MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7449810", Offset = "0x7448C10", VA = "0x187449810")]
	public static Quaternion AJCCBGLJAMD(this KOIMMLDCPHL MCPMOAEEEOJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7449900", Offset = "0x7448D00", VA = "0x187449900")]
	public static Quaternion? LPBAHPMPEMD(this KOIMMLDCPHL MCPMOAEEEOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PNGIPHOJDNA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x744A100", Offset = "0x7449500", VA = "0x18744A100")]
	public static HHCLOKDJPMA IFDLICGNEEM([In] this Vector2 MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x744A0A0", Offset = "0x74494A0", VA = "0x18744A0A0")]
	public static Vector2 AJCCBGLJAMD(this HHCLOKDJPMA MCPMOAEEEOJ)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FLJJHIAHFKD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7449AD0", Offset = "0x7448ED0", VA = "0x187449AD0")]
	public static BDIAEBOELKP IFDLICGNEEM([In] this Vector3 MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7449A10", Offset = "0x7448E10", VA = "0x187449A10")]
	public static BDIAEBOELKP EMLDDAGALBA([In] this Vector3? MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x74499A0", Offset = "0x7448DA0", VA = "0x1874499A0")]
	public static Vector3 AJCCBGLJAMD(this BDIAEBOELKP MCPMOAEEEOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7449B40", Offset = "0x7448F40", VA = "0x187449B40")]
	public static Vector3? LPBAHPMPEMD(this BDIAEBOELKP MCPMOAEEEOJ)
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
