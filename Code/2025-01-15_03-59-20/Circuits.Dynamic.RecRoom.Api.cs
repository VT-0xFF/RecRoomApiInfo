using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x231E920", Offset = "0x231DD20", VA = "0x18231E920")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MHPCOEAHIBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public AHPCDKCOAJM<KICLFNHBFCK> LMNLFCFHBKG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x231E8F0", Offset = "0x231DCF0", VA = "0x18231E8F0")]
	public static MHPCOEAHIBC ODOFIFAGLAJ()
	{
		return default(MHPCOEAHIBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x231E8C0", Offset = "0x231DCC0", VA = "0x18231E8C0")]
	[CompilerGenerated]
	internal static AHPCDKCOAJM<KICLFNHBFCK> MNDAFCHKECF(int HCPAOILCJCB)
	{
		return default(AHPCDKCOAJM<KICLFNHBFCK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GJNAEBEDANI
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BHOLIOHLKPB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HFMIDPHAHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int INODODHMJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float JCCKNEEKCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float HDGMBNEONHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GJEAAILKBOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LPEHGMIMMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FLJCBPKKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PIEJLMECNNC<ALHKDJHEAFJ> CV2SetMaxAmmo(AAMMKAFBOOJ EAIPGJCIAMN, int CDDAELCNAGM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PIEJLMECNNC<ALHKDJHEAFJ> CV2SetCurrentAmmo(AAMMKAFBOOJ EAIPGJCIAMN, int DGIHPBFPHDE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PIEJLMECNNC<ALHKDJHEAFJ> CV2SetADSEnabled(AAMMKAFBOOJ EAIPGJCIAMN, bool JCDOMELOGPP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	PIEJLMECNNC<ALHKDJHEAFJ> CV2SetCanReload(AAMMKAFBOOJ EAIPGJCIAMN, bool KNKGBFCPKCK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PIEJLMECNNC<ALHKDJHEAFJ> CV2SetContinuousFire(AAMMKAFBOOJ EAIPGJCIAMN, bool FGEGFBKGBPN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PIEJLMECNNC<ALHKDJHEAFJ> CV2SetRateOfFire(AAMMKAFBOOJ EAIPGJCIAMN, float ADEFDGEPLPD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	PIEJLMECNNC<ALHKDJHEAFJ> CV2SetReloadDuration(AAMMKAFBOOJ EAIPGJCIAMN, float HCHBEBADBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JLAPKBNFEDA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string BCDCIDCCFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIEJLMECNNC<ALHKDJHEAFJ> SetHandleControlLabel(AAMMKAFBOOJ EAIPGJCIAMN, string BLNFCPHILBB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PHABHLOBDND
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(GJNAEBEDANI, GJNAEBEDANI, GJNAEBEDANI, GJNAEBEDANI, GJNAEBEDANI) LKGAIEICDCN(object FFBDHANOEPC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object GPLKLKEHFMH();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BDPCGJLEFCD(object FFBDHANOEPC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string KPOMOCPCFCD(object FFBDHANOEPC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JIJOOEFDCBA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool IJCJNIDBKPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MMOOFMPPKIF
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPIFOJLDALK OEHDBJMHNAC(int EMHHDLNIDMD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int OFANKPINFKP([In] KPIFOJLDALK DPMKFGDEKHD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KMEBKLMMLGC
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PIEJLMECNNC<ALHKDJHEAFJ> SetEnabled(AAMMKAFBOOJ EAIPGJCIAMN, bool KPLNAJENPCF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct HJKPJONFCBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly APMDAGIPMFO LILJFGDPFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly MMOOFMPPKIF PIDEGGBGGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly PHABHLOBDND BKLFPPPBBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly MHPCOEAHIBC CIGEKOJKNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly NCNNDMGCFLO EGNMMHOMKKA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x231E850", Offset = "0x231DC50", VA = "0x18231E850")]
	public HJKPJONFCBL(APMDAGIPMFO FHBKDFOBODK, MMOOFMPPKIF ECKCMEOIJOA, PHABHLOBDND CDKHLKKJONN, [In] MHPCOEAHIBC LPEGELHMCOM, NCNNDMGCFLO GGCJEKGKLNM)
	{
	}
}
namespace Cpp2IlInjected
{
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
}
