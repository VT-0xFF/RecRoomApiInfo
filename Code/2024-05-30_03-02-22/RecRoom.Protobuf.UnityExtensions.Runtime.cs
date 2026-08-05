using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LDMKOLNFCEK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69D4070", Offset = "0x69D3270", VA = "0x1869D4070")]
	public static AECEJGDPAAN GKNEHCEDNDE([In] this Color CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69D40F0", Offset = "0x69D32F0", VA = "0x1869D40F0")]
	public static Color IHPADLGFHBL(this AECEJGDPAAN CJKIBFNGPNM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D4120", Offset = "0x69D3320", VA = "0x1869D4120")]
	public static Color? OCPEOKCLNGL(this AECEJGDPAAN CJKIBFNGPNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OPCLOCAKMED
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69D43B0", Offset = "0x69D35B0", VA = "0x1869D43B0")]
	public static Quaternion NPOBFHFFKFM(AKIJLGBAABG JLJKEBMIIPF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69D45D0", Offset = "0x69D37D0", VA = "0x1869D45D0")]
	public static OIFGOBLEKDD OBNNMLIJLJK(Quaternion ALKPEGLICLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69D4310", Offset = "0x69D3510", VA = "0x1869D4310")]
	public static Quaternion EBJHGMFNCBJ(OIFGOBLEKDD JLJKEBMIIPF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FEAKJIANCGA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69D3EE0", Offset = "0x69D30E0", VA = "0x1869D3EE0")]
	public static MHGHHMKPIDJ GKNEHCEDNDE([In] this Quaternion CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69D3F60", Offset = "0x69D3160", VA = "0x1869D3F60")]
	public static Quaternion IHPADLGFHBL(this MHGHHMKPIDJ CJKIBFNGPNM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69D3FD0", Offset = "0x69D31D0", VA = "0x1869D3FD0")]
	public static Quaternion? OCPEOKCLNGL(this MHGHHMKPIDJ CJKIBFNGPNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BCMOICHFNAD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69D3E10", Offset = "0x69D3010", VA = "0x1869D3E10")]
	public static NEHJKNGNCPD GKNEHCEDNDE([In] this Vector2 CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69D3E80", Offset = "0x69D3080", VA = "0x1869D3E80")]
	public static Vector2 IHPADLGFHBL(this NEHJKNGNCPD CJKIBFNGPNM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MNGPKKEOIAA
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69D41A0", Offset = "0x69D33A0", VA = "0x1869D41A0")]
	public static OIFGOBLEKDD GKNEHCEDNDE([In] this Vector3 CJKIBFNGPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69D4210", Offset = "0x69D3410", VA = "0x1869D4210")]
	public static Vector3 IHPADLGFHBL(this OIFGOBLEKDD CJKIBFNGPNM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x69D4280", Offset = "0x69D3480", VA = "0x1869D4280")]
	public static Vector3? OCPEOKCLNGL(this OIFGOBLEKDD CJKIBFNGPNM)
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
