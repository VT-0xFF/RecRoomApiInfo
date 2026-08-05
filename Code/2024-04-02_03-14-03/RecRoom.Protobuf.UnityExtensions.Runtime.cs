using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KFIHHCHIGIH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66B7B50", Offset = "0x66B6750", VA = "0x1866B7B50")]
	public static DKIMJOOIKFA GAPNIKJAJOO([In] this Color NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66B7B20", Offset = "0x66B6720", VA = "0x1866B7B20")]
	public static Color DPCADENMEMJ(this DKIMJOOIKFA NOLNJDLEMAA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66B7BD0", Offset = "0x66B67D0", VA = "0x1866B7BD0")]
	public static Color? HFHEKBHBBEG(this DKIMJOOIKFA NOLNJDLEMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DLJKFEIMEMP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x66B7770", Offset = "0x66B6370", VA = "0x1866B7770")]
	public static Quaternion OMBFEGOKFOG(IPAEICKHHHK KOMCCCIEHEA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66B7680", Offset = "0x66B6280", VA = "0x1866B7680")]
	public static EDAHAFEHFKO OLPOPMPFBJG(Quaternion PMHNKFMELGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x66B75E0", Offset = "0x66B61E0", VA = "0x1866B75E0")]
	public static Quaternion ALCIANGAMHH(EDAHAFEHFKO KOMCCCIEHEA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ECAGEHCEANC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66B7A00", Offset = "0x66B6600", VA = "0x1866B7A00")]
	public static HNCBJDAKCGF GAPNIKJAJOO([In] this Quaternion NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66B7990", Offset = "0x66B6590", VA = "0x1866B7990")]
	public static Quaternion DPCADENMEMJ(this HNCBJDAKCGF NOLNJDLEMAA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66B7A80", Offset = "0x66B6680", VA = "0x1866B7A80")]
	public static Quaternion? HFHEKBHBBEG(this HNCBJDAKCGF NOLNJDLEMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NEBOLPPGOAH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x66B7CB0", Offset = "0x66B68B0", VA = "0x1866B7CB0")]
	public static AGGBALCMADL GAPNIKJAJOO([In] this Vector2 NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66B7C50", Offset = "0x66B6850", VA = "0x1866B7C50")]
	public static Vector2 DPCADENMEMJ(this AGGBALCMADL NOLNJDLEMAA)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AOILNABACOC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66B74E0", Offset = "0x66B60E0", VA = "0x1866B74E0")]
	public static EDAHAFEHFKO GAPNIKJAJOO([In] this Vector3 NOLNJDLEMAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66B7470", Offset = "0x66B6070", VA = "0x1866B7470")]
	public static Vector3 DPCADENMEMJ(this EDAHAFEHFKO NOLNJDLEMAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x66B7550", Offset = "0x66B6150", VA = "0x1866B7550")]
	public static Vector3? HFHEKBHBBEG(this EDAHAFEHFKO NOLNJDLEMAA)
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
