using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MGLPDEFJAFA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F517D0", Offset = "0x7F50BD0", VA = "0x187F517D0")]
	public static DGNAIGPGJAH LMGGAKIACNI([In] this Color CAMFIHKHJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F51850", Offset = "0x7F50C50", VA = "0x187F51850")]
	public static Color OJJOMCGFFJC(this DGNAIGPGJAH CAMFIHKHJNG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F51750", Offset = "0x7F50B50", VA = "0x187F51750")]
	public static Color? BKLNJCDEFMO(this DGNAIGPGJAH CAMFIHKHJNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IJEIJNOANGF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F51450", Offset = "0x7F50850", VA = "0x187F51450")]
	public static Quaternion CNAEAALCOBC(OBAECELAFJN AMHCLKHIFKH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F51660", Offset = "0x7F50A60", VA = "0x187F51660")]
	public static GLKBMMMIIPK DBKHIMLOBDB(Quaternion JPJFAHNDBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F513B0", Offset = "0x7F507B0", VA = "0x187F513B0")]
	public static Quaternion BIAMDMDGBIM(GLKBMMMIIPK AMHCLKHIFKH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DNCPGKGIEED
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F511F0", Offset = "0x7F505F0", VA = "0x187F511F0")]
	public static FDPEAMDINHN LMGGAKIACNI([In] this Quaternion CAMFIHKHJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F51270", Offset = "0x7F50670", VA = "0x187F51270")]
	public static Quaternion OJJOMCGFFJC(this FDPEAMDINHN CAMFIHKHJNG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F51150", Offset = "0x7F50550", VA = "0x187F51150")]
	public static Quaternion? BKLNJCDEFMO(this FDPEAMDINHN CAMFIHKHJNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FMCKIHPHLHL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F512E0", Offset = "0x7F506E0", VA = "0x187F512E0")]
	public static ONGNFCOHMJH LMGGAKIACNI([In] this Vector2 CAMFIHKHJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F51350", Offset = "0x7F50750", VA = "0x187F51350")]
	public static Vector2 OJJOMCGFFJC(this ONGNFCOHMJH CAMFIHKHJNG)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NAPJBBCEKJC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F519D0", Offset = "0x7F50DD0", VA = "0x187F519D0")]
	public static GLKBMMMIIPK LMGGAKIACNI([In] this Vector3 CAMFIHKHJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F51910", Offset = "0x7F50D10", VA = "0x187F51910")]
	public static GLKBMMMIIPK JJGEAMIELDI([In] this Vector3? CAMFIHKHJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F51A40", Offset = "0x7F50E40", VA = "0x187F51A40")]
	public static Vector3 OJJOMCGFFJC(this GLKBMMMIIPK CAMFIHKHJNG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F51880", Offset = "0x7F50C80", VA = "0x187F51880")]
	public static Vector3? BKLNJCDEFMO(this GLKBMMMIIPK CAMFIHKHJNG)
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
