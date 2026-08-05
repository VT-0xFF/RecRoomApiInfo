using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EIBCAEJLPJA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PEBDKGDPILO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public IFNJBMDJFEC logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public PEBDKGDPILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x22A0460", Offset = "0x229F460", VA = "0x1822A0460")]
		internal bool EKFJCNJBCFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22A03B0", Offset = "0x229F3B0", VA = "0x1822A03B0")]
		internal void DMFKHNLOLAE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22A0560", Offset = "0x229F560", VA = "0x1822A0560")]
		internal bool PEAAELBKEMD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x22A0250", Offset = "0x229F250", VA = "0x1822A0250")]
		internal void BLAIBECIGON(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x22A04B0", Offset = "0x229F4B0", VA = "0x1822A04B0")]
		internal bool MNGODPKNJCF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x22A0300", Offset = "0x229F300", VA = "0x1822A0300")]
		internal void CIOMBOIGMHK(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly FPCPIOFMBGF LONLOOPDCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x229F520", Offset = "0x229E520", VA = "0x18229F520")]
	private static BDLCOGNBOKL CNJMEMLLKKD(IFNJBMDJFEC HGMIOHEIHIP)
	{
		return default(BDLCOGNBOKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x229F840", Offset = "0x229E840", VA = "0x18229F840")]
	private static FPCPIOFMBGF NJBOHEJFPJL()
	{
		return default(FPCPIOFMBGF);
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
