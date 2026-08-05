using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BILOJNDLILJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DF10", Offset = "0x5E8CD10", VA = "0x185E8DF10")]
	public static bool BBAPFDENPIH(this float3 BMPDKJEHGIN, float3 BMMLDIMMAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DEA0", Offset = "0x5E8CCA0", VA = "0x185E8DEA0")]
	public static bool BBAPFDENPIH(this quaternion AIAIDPGGDMM, quaternion PHPKEGMGOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E190", Offset = "0x5E8CF90", VA = "0x185E8E190")]
	private static bool DDMGNMLDEPM(float CHMLKIKEGLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E1A0", Offset = "0x5E8CFA0", VA = "0x185E8E1A0")]
	private static float JBALAGNLCGF(quaternion ICAMECEGLEK, quaternion AFMPNKLPJHI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct BHJJOINCPMJ : IEquatable<BHJJOINCPMJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly BHJJOINCPMJ KBNGHFIKFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 EIIEKPIPEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion DCNMMHNEEEM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BHJJOINCPMJ DOIJBLBFFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D4D0", Offset = "0x5E8C2D0", VA = "0x185E8D4D0")]
		get
		{
			return default(BHJJOINCPMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE27480", Offset = "0xE26280", VA = "0x180E27480")]
	public BHJJOINCPMJ(float3 EIIEKPIPEEF, quaternion DCNMMHNEEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DD60", Offset = "0x5E8CB60", VA = "0x185E8DD60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D8F0", Offset = "0x5E8C6F0", VA = "0x185E8D8F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D510", Offset = "0x5E8C310", VA = "0x185E8D510", Slot = "4")]
	public bool Equals(BHJJOINCPMJ HNOJKNGFFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D630", Offset = "0x5E8C430", VA = "0x185E8D630", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DA80", Offset = "0x5E8C880", VA = "0x185E8DA80")]
	public static BHJJOINCPMJ LJIEKPFDLCA(BHJJOINCPMJ MLCJCNMDILL, BHJJOINCPMJ HIGNDDEOKAL)
	{
		return default(BHJJOINCPMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D6E0", Offset = "0x5E8C4E0", VA = "0x185E8D6E0")]
	private BHJJOINCPMJ FAOGBPENJNH()
	{
		return default(BHJJOINCPMJ);
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
