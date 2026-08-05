using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KPGFPCGNBME
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8B99B50", Offset = "0x8B98950", VA = "0x188B99B50")]
	public static DADOAAIAOMF OFACCHGGJAP([In] this Color DBBEADIHLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8B99BD0", Offset = "0x8B989D0", VA = "0x188B99BD0")]
	public static Color PPEAGMPJINO(this DADOAAIAOMF DBBEADIHLKO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8B99AD0", Offset = "0x8B988D0", VA = "0x188B99AD0")]
	public static Color? JMJJBGECOBB(this DADOAAIAOMF DBBEADIHLKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NKIJBKOCDGL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8B99D90", Offset = "0x8B98B90", VA = "0x188B99D90")]
	public static Quaternion NAPIDDMEGMC(MFMJGJKICJA KANAIIDGHCH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B99C00", Offset = "0x8B98A00", VA = "0x188B99C00")]
	public static FPBJHBMNKNH FCJDHDCBHIA(Quaternion KCNDECHNAML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8B99CF0", Offset = "0x8B98AF0", VA = "0x188B99CF0")]
	public static Quaternion IANCLBDLGFH(FPBJHBMNKNH KANAIIDGHCH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GLCHGBOOBAG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8B99910", Offset = "0x8B98710", VA = "0x188B99910")]
	public static IOKGLNFDHEE OFACCHGGJAP([In] this Quaternion DBBEADIHLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8B99990", Offset = "0x8B98790", VA = "0x188B99990")]
	public static Quaternion PPEAGMPJINO(this IOKGLNFDHEE DBBEADIHLKO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8B99870", Offset = "0x8B98670", VA = "0x188B99870")]
	public static Quaternion? JMJJBGECOBB(this IOKGLNFDHEE DBBEADIHLKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GPNIBKHPFIO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B99A00", Offset = "0x8B98800", VA = "0x188B99A00")]
	public static JHKIFIDEDCL OFACCHGGJAP([In] this Vector2 DBBEADIHLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8B99A70", Offset = "0x8B98870", VA = "0x188B99A70")]
	public static Vector2 PPEAGMPJINO(this JHKIFIDEDCL DBBEADIHLKO)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FNELJMLNDEC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B99790", Offset = "0x8B98590", VA = "0x188B99790")]
	public static FPBJHBMNKNH OFACCHGGJAP([In] this Vector3 DBBEADIHLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B99640", Offset = "0x8B98440", VA = "0x188B99640")]
	public static FPBJHBMNKNH FCIDDEIAAOI([In] this Vector3? DBBEADIHLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8B99800", Offset = "0x8B98600", VA = "0x188B99800")]
	public static Vector3 PPEAGMPJINO(this FPBJHBMNKNH DBBEADIHLKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8B99700", Offset = "0x8B98500", VA = "0x188B99700")]
	public static Vector3? JMJJBGECOBB(this FPBJHBMNKNH DBBEADIHLKO)
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
