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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2217BA0", Offset = "0x2216FA0", VA = "0x182217BA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OKJFIPIKCFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MIEEFIOIIBN<KCAKPNEBCJB> OMNAOMHGDAE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2217C20", Offset = "0x2217020", VA = "0x182217C20")]
	public static OKJFIPIKCFN AHLALEPNKFA()
	{
		return default(OKJFIPIKCFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2217C50", Offset = "0x2217050", VA = "0x182217C50")]
	[CompilerGenerated]
	internal static MIEEFIOIIBN<KCAKPNEBCJB> EBFKAGJHIFL(int EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<KCAKPNEBCJB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GLONMKGDABK
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HEFOAMGKLEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int JLAFBGKANJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int HPPNHCHIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float IHCONIHBIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float IEEPMICPGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NCJBEEEGDAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DJEBKKIKDFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MKFKABNEKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FANKOKNCEAP<IOADHBFKJOJ> CV2SetMaxAmmo(MMMCOPNJLPM CDCDIGHMBPL, int EGCLLCBPEBE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FANKOKNCEAP<IOADHBFKJOJ> CV2SetCurrentAmmo(MMMCOPNJLPM CDCDIGHMBPL, int APDLENCJHAI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FANKOKNCEAP<IOADHBFKJOJ> CV2SetADSEnabled(MMMCOPNJLPM CDCDIGHMBPL, bool BOCGODCJHIA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FANKOKNCEAP<IOADHBFKJOJ> CV2SetCanReload(MMMCOPNJLPM CDCDIGHMBPL, bool BMKLHBPMPBG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FANKOKNCEAP<IOADHBFKJOJ> CV2SetContinuousFire(MMMCOPNJLPM CDCDIGHMBPL, bool NFCMPICMKFD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FANKOKNCEAP<IOADHBFKJOJ> CV2SetRateOfFire(MMMCOPNJLPM CDCDIGHMBPL, float KAACBPPJGNO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FANKOKNCEAP<IOADHBFKJOJ> CV2SetReloadDuration(MMMCOPNJLPM CDCDIGHMBPL, float EBOOIPGOPKP);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MLGJNLAHNOD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string BEODPIBOKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FANKOKNCEAP<IOADHBFKJOJ> SetHandleControlLabel(MMMCOPNJLPM CDCDIGHMBPL, string FOOMCLEFIFH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ACAGFFLNNBB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(GLONMKGDABK, GLONMKGDABK, GLONMKGDABK, GLONMKGDABK, GLONMKGDABK) MGKDAMJDGDI(object PEIJBHPINLD);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object JIFACPKLCCA();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CPKPPJFCLGP(object PEIJBHPINLD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string LLEKPCCFIAB(object PEIJBHPINLD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IIIAOBHINDF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JNHMNOOGKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LGONICPEPLH
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKEEOAFKEJI NBIOMFFEIBI(int PMAEFODMHKF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int EKFKGCDIMBP([In] NKEEOAFKEJI HCKEGOHHEHB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CEDHBKIDPBA
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FANKOKNCEAP<IOADHBFKJOJ> SetEnabled(MMMCOPNJLPM CDCDIGHMBPL, bool IOIBOFIFFAN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct AEFGBPILBNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly OACILKLGGLD EFFGHNPNBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LGONICPEPLH BLLMHFCABCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly ACAGFFLNNBB ELOLIPMEKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly OKJFIPIKCFN JCMLNEGBNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly HJIFHEOEJKN LELAPOLENDB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2217B30", Offset = "0x2216F30", VA = "0x182217B30")]
	public AEFGBPILBNB(OACILKLGGLD GNLALCNDJKA, LGONICPEPLH IONAHGLJMAL, ACAGFFLNNBB PCGLPIKMJFK, [In] OKJFIPIKCFN EGDEMLHPAGF, HJIFHEOEJKN JCBLPFGICGM)
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
