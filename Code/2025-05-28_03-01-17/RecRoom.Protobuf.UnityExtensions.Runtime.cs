using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EDNDCAEBPHP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x855DDF0", Offset = "0x855CBF0", VA = "0x18855DDF0")]
	public static EEHENIALAEA KIDMEGDOMCG([In] this Color FPFHIDBMBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x855DE70", Offset = "0x855CC70", VA = "0x18855DE70")]
	public static Color LGDBIGPAFJK(this EEHENIALAEA FPFHIDBMBMI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x855DEA0", Offset = "0x855CCA0", VA = "0x18855DEA0")]
	public static Color? NOOFLAPJJEK(this EEHENIALAEA FPFHIDBMBMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DGHJJMJOLJH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x855DA50", Offset = "0x855C850", VA = "0x18855DA50")]
	public static Quaternion NGPPPMNDNCF(FLOOGJDOJKN FFEMKICJPKP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x855DD00", Offset = "0x855CB00", VA = "0x18855DD00")]
	public static FPBNFGGKMFN OCNDLPLFABO(Quaternion DKHHLEDHEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x855DC60", Offset = "0x855CA60", VA = "0x18855DC60")]
	public static Quaternion NHLCOHOLFCL(FPBNFGGKMFN FFEMKICJPKP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DANDDILFILH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x855D8C0", Offset = "0x855C6C0", VA = "0x18855D8C0")]
	public static PFAIAJNFLGG KIDMEGDOMCG([In] this Quaternion FPFHIDBMBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x855D940", Offset = "0x855C740", VA = "0x18855D940")]
	public static Quaternion LGDBIGPAFJK(this PFAIAJNFLGG FPFHIDBMBMI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x855D9B0", Offset = "0x855C7B0", VA = "0x18855D9B0")]
	public static Quaternion? NOOFLAPJJEK(this PFAIAJNFLGG FPFHIDBMBMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KGACLINGBPA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x855DF20", Offset = "0x855CD20", VA = "0x18855DF20")]
	public static KPPANECEOJD KIDMEGDOMCG([In] this Vector2 FPFHIDBMBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x855DF90", Offset = "0x855CD90", VA = "0x18855DF90")]
	public static Vector2 LGDBIGPAFJK(this KPPANECEOJD FPFHIDBMBMI)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LIFMDLKAOFL
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x855E0B0", Offset = "0x855CEB0", VA = "0x18855E0B0")]
	public static FPBNFGGKMFN KIDMEGDOMCG([In] this Vector3 FPFHIDBMBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x855DFF0", Offset = "0x855CDF0", VA = "0x18855DFF0")]
	public static FPBNFGGKMFN ADBGKOHAPKO([In] this Vector3? FPFHIDBMBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x855E120", Offset = "0x855CF20", VA = "0x18855E120")]
	public static Vector3 LGDBIGPAFJK(this FPBNFGGKMFN FPFHIDBMBMI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x855E190", Offset = "0x855CF90", VA = "0x18855E190")]
	public static Vector3? NOOFLAPJJEK(this FPBNFGGKMFN FPFHIDBMBMI)
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
