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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x221EDF0", Offset = "0x221E1F0", VA = "0x18221EDF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ILHPHKPKLNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public FGLBFCBPBCD<CDBBGAHMFBO> LAFHBDBFHOO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x221ED90", Offset = "0x221E190", VA = "0x18221ED90")]
	public static ILHPHKPKLNC AALKPJMFIHM()
	{
		return default(ILHPHKPKLNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x221EDC0", Offset = "0x221E1C0", VA = "0x18221EDC0")]
	[CompilerGenerated]
	internal static FGLBFCBPBCD<CDBBGAHMFBO> GLCBJGOICOB(int LIHHDPOHLDK)
	{
		return default(FGLBFCBPBCD<CDBBGAHMFBO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LGGHEIPLBFI
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LEAPALBMBMK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int DAIMIKDPLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int PDAIJFBKMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float FAKALNMBIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float CDJAGKIHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HGLEDPAALCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HMMIJHAOGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool HDGMHAKLKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NCPKMBPEBOJ<OKFEIOHLOGM> CV2SetMaxAmmo(BJNCCIMDKNP PBLCLNMOIGC, int GGBNJANNJDO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NCPKMBPEBOJ<OKFEIOHLOGM> CV2SetCurrentAmmo(BJNCCIMDKNP PBLCLNMOIGC, int JADKKKPBPMA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NCPKMBPEBOJ<OKFEIOHLOGM> CV2SetADSEnabled(BJNCCIMDKNP PBLCLNMOIGC, bool PNHMPKNFDBD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NCPKMBPEBOJ<OKFEIOHLOGM> CV2SetCanReload(BJNCCIMDKNP PBLCLNMOIGC, bool FMAGMAADAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NCPKMBPEBOJ<OKFEIOHLOGM> CV2SetContinuousFire(BJNCCIMDKNP PBLCLNMOIGC, bool FDNPIKNBJBA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NCPKMBPEBOJ<OKFEIOHLOGM> CV2SetRateOfFire(BJNCCIMDKNP PBLCLNMOIGC, float DIPFNOEBNME);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NCPKMBPEBOJ<OKFEIOHLOGM> CV2SetReloadDuration(BJNCCIMDKNP PBLCLNMOIGC, float LBFLJPCMBIG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NGDAMMBNFEH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string LBMLJBBKPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NCPKMBPEBOJ<OKFEIOHLOGM> SetHandleControlLabel(BJNCCIMDKNP PBLCLNMOIGC, string GLEFGBFPDGL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FEAMJGBDECL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(LGGHEIPLBFI, LGGHEIPLBFI, LGGHEIPLBFI, LGGHEIPLBFI, LGGHEIPLBFI) IKEAPEPNHAB(object PBJBOGHPHPG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	object GLFCACNIEGF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OOLCMFGMABL(object PBJBOGHPHPG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string JLHCGHKALNH(object PBJBOGHPHPG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BJNFMEPKONK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DIKNDKKPDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OCCBOFEKEOG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBPMOKFJJOF PKMOHJDCFNI(int HAEHBACPPHL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int PNJIDJCCDMC([In] CBPMOKFJJOF BIOLFKMCBMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface INAFGMBJJAA
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NCPKMBPEBOJ<OKFEIOHLOGM> SetEnabled(BJNCCIMDKNP PBLCLNMOIGC, bool JDDHPBEGEAD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct OAPJNBELDLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly CBLNGKFOFNO IAMCEECJBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly OCCBOFEKEOG JBLLDIDPHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly FEAMJGBDECL GKNJIIGHILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly ILHPHKPKLNC JALLOECFACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly NENHCOJPKLI OKPHCCGADHO;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x221EE70", Offset = "0x221E270", VA = "0x18221EE70")]
	public OAPJNBELDLC(CBLNGKFOFNO HJLJFAKKENB, OCCBOFEKEOG DKELPNBGBNM, FEAMJGBDECL EKKNCLJNCHP, [In] ILHPHKPKLNC AFCOBOOJKAC, NENHCOJPKLI PMOPFCHIHCJ)
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
