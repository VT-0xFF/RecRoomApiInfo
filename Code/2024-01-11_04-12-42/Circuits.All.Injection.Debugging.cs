using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OCALMHLMLDC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class MBFPOCBIFEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DFCHEDNHJND logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public MBFPOCBIFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2610", Offset = "0x1CE1010", VA = "0x181CE2610")]
		internal bool DFALHLBJLNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2560", Offset = "0x1CE0F60", VA = "0x181CE2560")]
		internal void AEKDEMIMPAN(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CE27D0", Offset = "0x1CE11D0", VA = "0x181CE27D0")]
		internal bool LLCPCBHNBNA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2660", Offset = "0x1CE1060", VA = "0x181CE2660")]
		internal void DKEBCLOKOEI(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2710", Offset = "0x1CE1110", VA = "0x181CE2710")]
		internal bool EBLBMHJPBLL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2890", Offset = "0x1CE1290", VA = "0x181CE2890")]
		internal void OGKLHIOMNNH(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IABJLAFFDPC KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1CE31F0", Offset = "0x1CE1BF0", VA = "0x181CE31F0")]
	private static GNMIEGLEGIH FJBFHMODLCA(DFCHEDNHJND PLADBDFPBHG)
	{
		return default(GNMIEGLEGIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2940", Offset = "0x1CE1340", VA = "0x181CE2940")]
	private static IABJLAFFDPC AKGLIONCKLM()
	{
		return default(IABJLAFFDPC);
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
