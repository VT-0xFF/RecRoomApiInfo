using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AIAABHBLLAN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8015630", Offset = "0x8014A30", VA = "0x188015630")]
	public static ABKKLIPACEH PELCBGJOJPC([In] this Color JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8015600", Offset = "0x8014A00", VA = "0x188015600")]
	public static Color HFAEDKNMEEN(this ABKKLIPACEH JOCJBPPJMJJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8015580", Offset = "0x8014980", VA = "0x188015580")]
	public static Color? CHNIEAFPDIH(this ABKKLIPACEH JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DEHACEBKECN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8015780", Offset = "0x8014B80", VA = "0x188015780")]
	public static Quaternion AIIBHEONFAJ(MPMCGMKEFCJ HPMNBNLACCC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8015A30", Offset = "0x8014E30", VA = "0x188015A30")]
	public static KLFDFGFPLDF EIIPIDPLNNC(Quaternion KJGFLPNPPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8015990", Offset = "0x8014D90", VA = "0x188015990")]
	public static Quaternion CIPJNAMCOHE(KLFDFGFPLDF HPMNBNLACCC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JCIMJNFJFMC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8015C30", Offset = "0x8015030", VA = "0x188015C30")]
	public static HHGFGLHBDAG PELCBGJOJPC([In] this Quaternion JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8015BC0", Offset = "0x8014FC0", VA = "0x188015BC0")]
	public static Quaternion HFAEDKNMEEN(this HHGFGLHBDAG JOCJBPPJMJJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8015B20", Offset = "0x8014F20", VA = "0x188015B20")]
	public static Quaternion? CHNIEAFPDIH(this HHGFGLHBDAG JOCJBPPJMJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BMNJMIPADHD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8015710", Offset = "0x8014B10", VA = "0x188015710")]
	public static HNKILIIAFOG PELCBGJOJPC([In] this Vector2 JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80156B0", Offset = "0x8014AB0", VA = "0x1880156B0")]
	public static Vector2 HFAEDKNMEEN(this HNKILIIAFOG JOCJBPPJMJJ)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NFBNPGDJPLH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8015E70", Offset = "0x8015270", VA = "0x188015E70")]
	public static KLFDFGFPLDF PELCBGJOJPC([In] this Vector3 JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8015D40", Offset = "0x8015140", VA = "0x188015D40")]
	public static KLFDFGFPLDF EIALLFHKNNO([In] this Vector3? JOCJBPPJMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8015E00", Offset = "0x8015200", VA = "0x188015E00")]
	public static Vector3 HFAEDKNMEEN(this KLFDFGFPLDF JOCJBPPJMJJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8015CB0", Offset = "0x80150B0", VA = "0x188015CB0")]
	public static Vector3? CHNIEAFPDIH(this KLFDFGFPLDF JOCJBPPJMJJ)
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
