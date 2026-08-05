using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LFJCOALPLLP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FKPBGDIKFOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AKHLLDOOCCK logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FKPBGDIKFOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5AF0", Offset = "0x1DB46F0", VA = "0x181DB5AF0")]
		internal bool PEHEKLDLMNG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DB58E0", Offset = "0x1DB44E0", VA = "0x181DB58E0")]
		internal void DHLPKHMFLBK(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5760", Offset = "0x1DB4360", VA = "0x181DB5760")]
		internal bool CLADFKEMNPI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5A40", Offset = "0x1DB4640", VA = "0x181DB5A40")]
		internal void PAHEAIDGIIL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5820", Offset = "0x1DB4420", VA = "0x181DB5820")]
		internal bool CPMGGAOEADA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5990", Offset = "0x1DB4590", VA = "0x181DB5990")]
		internal void KECCAFDHALI(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly PLMCPELBDJB EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DB63F0", Offset = "0x1DB4FF0", VA = "0x181DB63F0")]
	private static KIDCFOMALKM GNCNAIFDBHA(AKHLLDOOCCK EDLGEIBJOEI)
	{
		return default(KIDCFOMALKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5B40", Offset = "0x1DB4740", VA = "0x181DB5B40")]
	private static PLMCPELBDJB GHBCELHMFHF()
	{
		return default(PLMCPELBDJB);
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
