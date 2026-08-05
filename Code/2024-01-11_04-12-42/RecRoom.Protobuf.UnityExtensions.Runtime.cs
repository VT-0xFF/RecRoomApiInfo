using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NLHGKCCFOHO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x656C4A0", Offset = "0x656AEA0", VA = "0x18656C4A0")]
	public static AOCAIJDLMDO JLKDILEIJOC([In] this Color JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x656C470", Offset = "0x656AE70", VA = "0x18656C470")]
	public static Color DCJJDHFPDEL(this AOCAIJDLMDO JFFAAHPEFOB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x656C520", Offset = "0x656AF20", VA = "0x18656C520")]
	public static Color? PJEPBIFDNPJ(this AOCAIJDLMDO JFFAAHPEFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NGEKKDHKNAO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x656C1B0", Offset = "0x656ABB0", VA = "0x18656C1B0")]
	public static Quaternion PHNHKIIJALH(JOJOBNDAKMC OBAHLGOPPIK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x656C0C0", Offset = "0x656AAC0", VA = "0x18656C0C0")]
	public static JHKLOLBNEAP GCLHPGCEBIH(Quaternion MMFHNEACMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x656C3D0", Offset = "0x656ADD0", VA = "0x18656C3D0")]
	public static Quaternion PKOONJMBONG(JHKLOLBNEAP OBAHLGOPPIK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FEPGFANFOIN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x656BED0", Offset = "0x656A8D0", VA = "0x18656BED0")]
	public static KKOGNACOPFO JLKDILEIJOC([In] this Quaternion JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x656BE60", Offset = "0x656A860", VA = "0x18656BE60")]
	public static Quaternion DCJJDHFPDEL(this KKOGNACOPFO JFFAAHPEFOB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x656BF50", Offset = "0x656A950", VA = "0x18656BF50")]
	public static Quaternion? PJEPBIFDNPJ(this KKOGNACOPFO JFFAAHPEFOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MFLPNEAOJOB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x656C050", Offset = "0x656AA50", VA = "0x18656C050")]
	public static DKNLDHKCHMA JLKDILEIJOC([In] this Vector2 JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x656BFF0", Offset = "0x656A9F0", VA = "0x18656BFF0")]
	public static Vector2 DCJJDHFPDEL(this DKNLDHKCHMA JFFAAHPEFOB)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PAFFJMBFBBN
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x656C610", Offset = "0x656B010", VA = "0x18656C610")]
	public static JHKLOLBNEAP JLKDILEIJOC([In] this Vector3 JFFAAHPEFOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x656C5A0", Offset = "0x656AFA0", VA = "0x18656C5A0")]
	public static Vector3 DCJJDHFPDEL(this JHKLOLBNEAP JFFAAHPEFOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x656C680", Offset = "0x656B080", VA = "0x18656C680")]
	public static Vector3? PJEPBIFDNPJ(this JHKLOLBNEAP JFFAAHPEFOB)
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
