using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA4C0", Offset = "0x1FA8EC0", VA = "0x181FAA4C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct OGCCCFJLFMD : IEquatable<OGCCCFJLFMD>, FHPHFFGJALG<OGCCCFJLFMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly AEAOKLPMJLF<OCMNEPAAPCH> DPAMGNBHBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly AEAOKLPMJLF<IMGNCICAHLN> MPIDJHJMKAD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3A60", Offset = "0x1FA2460", VA = "0x181FA3A60")]
	public OGCCCFJLFMD([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, AEAOKLPMJLF<IMGNCICAHLN> HJFFFLJOLGJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA6F0", Offset = "0x1FA90F0", VA = "0x181FAA6F0")]
	public static bool IKJGJDJDJIH([In] OGCCCFJLFMD NNEJNMNIIPM, [In] OGCCCFJLFMD MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA610", Offset = "0x1FA9010", VA = "0x181FAA610", Slot = "4")]
	public bool Equals(OGCCCFJLFMD HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA540", Offset = "0x1FA8F40", VA = "0x181FAA540")]
	public bool EBHDDKLMPJG([In] OGCCCFJLFMD HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA550", Offset = "0x1FA8F50", VA = "0x181FAA550", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA630", Offset = "0x1FA9030", VA = "0x181FAA630", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA540", Offset = "0x1FA8F40", VA = "0x181FAA540", Slot = "5")]
	private bool OFKFLPODBCK([In] OGCCCFJLFMD HENLEJBGFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct CONJBDNJPOL : IEquatable<CONJBDNJPOL>, FHPHFFGJALG<CONJBDNJPOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly AEAOKLPMJLF<OCMNEPAAPCH> DPAMGNBHBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly AEAOKLPMJLF<LBFLHFCOJJC> LNLJPMNILOK;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3A60", Offset = "0x1FA2460", VA = "0x181FA3A60")]
	public CONJBDNJPOL([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, AEAOKLPMJLF<LBFLHFCOJJC> JGFEKNLNGHM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA39A0", Offset = "0x1FA23A0", VA = "0x181FA39A0")]
	public static bool IKJGJDJDJIH([In] CONJBDNJPOL NNEJNMNIIPM, [In] CONJBDNJPOL MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA38C0", Offset = "0x1FA22C0", VA = "0x181FA38C0", Slot = "4")]
	public bool Equals(CONJBDNJPOL HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA37F0", Offset = "0x1FA21F0", VA = "0x181FA37F0")]
	public bool EBHDDKLMPJG([In] CONJBDNJPOL HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3800", Offset = "0x1FA2200", VA = "0x181FA3800", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FA38E0", Offset = "0x1FA22E0", VA = "0x181FA38E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FA37F0", Offset = "0x1FA21F0", VA = "0x181FA37F0", Slot = "5")]
	private bool DMMBIEHFGNC([In] CONJBDNJPOL HENLEJBGFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GCFGKBCHKND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
	public GCFGKBCHKND(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum LIHOALIELHA
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Follow,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Orbit,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Attached,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Detached
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct EBBJNKNCBAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly NGNPIEADDLG CNKDNOKJEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly OGKMMBABDLC OCNNKCCCBEN;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4340", Offset = "0x1FA2D40", VA = "0x181FA4340")]
	public EBBJNKNCBAP([In] NGNPIEADDLG IJFOGIEFCHH, OGKMMBABDLC BGFCCPEMGBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NGNPIEADDLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly MLMDFOAIEPL HHCANDFKNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly HAOHCHFGEKA PLNMILMCFGG;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xAA6F80", Offset = "0xAA5980", VA = "0x180AA6F80")]
	public NGNPIEADDLG(MLMDFOAIEPL PJIAKDPLFAN, HAOHCHFGEKA BKMFCLCFBJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct OGKMMBABDLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly FLIADCLBMOC DGFIHJCFJNA;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	public OGKMMBABDLC(FLIADCLBMOC IBIMAFGOANC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HOCEKIJNPGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly OPDPMBOOOHH AEMDGHADKCC;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x921B20", Offset = "0x920520", VA = "0x180921B20")]
	public HOCEKIJNPGF(OPDPMBOOOHH BGKOCMPEHBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum BJOFMICAAKI
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Digit,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Integer,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Decimal,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Regex,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	CustomValidator
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum JPGEEFFNPKB
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Custom
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FEJEMLCOPNG : CHBBJDMPBJH
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeRecorderData(string LFIMJEBHNMK, Action<string, float> EPLGFBCOLHH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DCKBLKOIALI : ODJBMADOOFC
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBJJFLEBNIB();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CHBBJDMPBJH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnHide();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DoneEditing();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BICLLAEGCJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface INFKKFICBPM
{
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EACNPILCMOK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string AFHFMKIMMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int FMGJKEMHBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GHFMKEPIGME
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JPIIKBAONKN : ODJBMADOOFC
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KODKNHDNNHA(ODJBMADOOFC HGIEFJADOPH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EIMPLACCFNH();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLMGPBLKDNE(ODJBMADOOFC HGIEFJADOPH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FHGCHDCGJEO
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPAKKOPLFBP(string GIHAKFMCIGK, Func<string> DANPNGEGMMJ, Action<string> BDONPBIAOLL, Func<bool> GKGBCOJOGBL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHEHLPKEMPB(string GIHAKFMCIGK, Action ILIBCLLCAFN, Func<bool> GKGBCOJOGBL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GJGJAKGCLEF(string GIHAKFMCIGK, Func<int> IJPBAMOGJHI, Action<int> LINJHGKIFGG, Func<bool> GKGBCOJOGBL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHGLJPAHDJD(string GIHAKFMCIGK, Func<int> DANPNGEGMMJ, Action<int> BDONPBIAOLL, Func<bool> GKGBCOJOGBL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DHMGCIPJOLI(string GIHAKFMCIGK, Func<int> LIPHFDGKPOL, Action<object> JBBMCNMNNFB, Func<object, string> PCDNJNAHFPE, Func<bool> GKGBCOJOGBL, Type FALNMJPDMOJ, IReadOnlyList<object> BBKMCAJIOJF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EAOAEKFALEM(string GIHAKFMCIGK, Func<string> DANPNGEGMMJ, Action<string> BDONPBIAOLL, Func<bool> GKGBCOJOGBL);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJBFKIDHEPJ(string GIHAKFMCIGK, Func<bool> DANPNGEGMMJ, Action<bool> BDONPBIAOLL, Func<bool> GKGBCOJOGBL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JNLKIMCIIGL
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface ENIMCAGMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Action<JNLKIMCIIGL>? PPJDLPMMAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Action<JNLKIMCIIGL>? DKEINFJNPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ODJBMADOOFC JNCJDCEJGDD(Func<bool> FODONDOHEBB, Action<bool> EHEDNEACOEM, Func<byte> CKHKNKDMBFK, Action<byte> HGJNFBFDDEC, Func<int> BKAACNBJLJB, Action<int> JLINHDEJAKH, Func<IReadOnlyList<string>> PAKBGGEDOGH, Action<IReadOnlyList<string>> GJBJPMIOFNM, [Optional] Func<IReadOnlyList<string>>? DNBIDKFCGBB, [Optional] Action<IReadOnlyList<string>>? FNLOOGKGLGF, [Optional] Func<bool>? GKGBCOJOGBL);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JBODALPAEOF();
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ENIMCAGMDOK DBPHAGOFPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODJBMADOOFC BKBPLPKCLMF(Action ILIBCLLCAFN, string GIHAKFMCIGK = "", [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODJBMADOOFC COGEJEBGCBF(IReadOnlyList<ODJBMADOOFC> BMPGIBDBMEA, [Optional] float? BECGGBMGLCJ, [Optional] int? MFFEFICGAKE, [Optional] bool? ELKLOEMHGKN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ODJBMADOOFC JPGLJFPLKHK(IReadOnlyList<ODJBMADOOFC> BMPGIBDBMEA, [Optional] float? BECGGBMGLCJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ODJBMADOOFC IGKEFKLLGNA(Func<int> IJPBAMOGJHI, Action<int> LINJHGKIFGG, [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, bool PFNOCKIEBBN = false, string GIHAKFMCIGK = "Color", [Optional] Func<bool>? FOFHKJNJKID, bool DGBMINNOCGA = true, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ODJBMADOOFC MMPMMDGBCCN(Action ILIBCLLCAFN, string GIHAKFMCIGK = "", [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ODJBMADOOFC EKPMLLKODBP(Func<KMLAHJFMIMO<NBLNJAIONPA>> IAFBNHBGPNL, Func<int> BCEEHECCLPK, [Optional] Func<bool>? GKGBCOJOGBL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ODJBMADOOFC FNACGCMENNP(ODJBMADOOFC HGIEFJADOPH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JPIIKBAONKN HLIBINBHDJI(int AJDJDACIIPE, string GIHAKFMCIGK, string PFPNJCFPCDP = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] List<ODJBMADOOFC>? BMPGIBDBMEA, [Optional] Func<bool>? GKGBCOJOGBL, bool KMKMNNLOKGL = true, [Optional] Func<bool>? AFOBOFLNLEN, [Optional] Action<bool>? MDPOAKJAPKM, [Optional] float? KGCPBGHNFCE);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ODJBMADOOFC GNKDAGCPJGC(string GFPEPHMDHLM, [Optional] Func<bool>? GKGBCOJOGBL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ODJBMADOOFC BIMKHILJLBL(Func<string> DANPNGEGMMJ, Action<string> BDONPBIAOLL, [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] int? FILKAKKJHAN, bool MACFDFHINIO = false, string GIHAKFMCIGK = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ODJBMADOOFC LDMJBMEJPKP(Func<float> DANPNGEGMMJ, Action<float> BDONPBIAOLL, string GIHAKFMCIGK = "", string PFPNJCFPCDP = "", string LNHFHFPAJDI = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", bool KFBABMFJFPB = false, float IOGMIBOGPHG = 0f, float MLGABKDBHND = 1000f, [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ODJBMADOOFC JEKCCOMFHIN(Func<int> DANPNGEGMMJ, Action<int> BDONPBIAOLL, string GIHAKFMCIGK = "", [Optional] Func<string>? LDJDAPLDEEL, string PFPNJCFPCDP = "", [Optional] Func<string>? IGGNNLANFJA, string LNHFHFPAJDI = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", bool KFBABMFJFPB = false, int IOGMIBOGPHG = 0, int MLGABKDBHND = 1000, [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ODJBMADOOFC DADKMMMILJD(Type FALNMJPDMOJ, IReadOnlyList<object> BBKMCAJIOJF, Func<int> LIPHFDGKPOL, Action<object> JBBMCNMNNFB, string GIHAKFMCIGK = "", string PFPNJCFPCDP = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] Func<object, string>? PCDNJNAHFPE, bool HKGPBLJHEGH = true, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ODJBMADOOFC JKNELAFEHDD(Func<string> DANPNGEGMMJ, Action<string> BDONPBIAOLL, int BCABLKNCKJB = 1000, JPGEEFFNPKB BFCBMHIDKED = JPGEEFFNPKB.Alphanumeric, [Optional] Func<string, bool>? DJHKMENGGGE, [Optional] string? PDPNNKFCLLH, [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, string GIHAKFMCIGK = "", string PFPNJCFPCDP = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", bool MACFDFHINIO = false, [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true, float HHCODIAFDON = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ODJBMADOOFC NBKEOELBNOP(Func<float> DANPNGEGMMJ, Action<float> BDONPBIAOLL, float IOGMIBOGPHG = 0f, float MLGABKDBHND = 1000f, [Optional] Func<bool>? CLIEMFOLNCB, int OBCCJIGAJFH = -1, string GIHAKFMCIGK = "", string PFPNJCFPCDP = "", string LNHFHFPAJDI = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] Func<float, float>? MEBKIJDPCIO, [Optional] Func<float, float>? CIHDPMDLLDM, [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "16")]
	ODJBMADOOFC LMIDCGAMJCA(Func<string> DANPNGEGMMJ, Action<string> BDONPBIAOLL, Action ILIBCLLCAFN, [Optional] Func<bool>? GKGBCOJOGBL, JPGEEFFNPKB BFCBMHIDKED = JPGEEFFNPKB.Alphanumeric, [Optional] Func<string, bool>? DJHKMENGGGE, BJOFMICAAKI GPJJALFIBKD = BJOFMICAAKI.Alphanumeric, [Optional] string? PDPNNKFCLLH, [Optional] List<ODJBMADOOFC>? GNNOBKLFHAH, string GIHAKFMCIGK = "", string DIHGHELDAOG = "", string KHICEBLCOOE = "", string EPHLOAEBKBF = "", bool CHFKECPIBPC = true, float HHCODIAFDON = 0f);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	ODJBMADOOFC MNNIECDBCNF(Func<string> DANPNGEGMMJ, Action<string> BDONPBIAOLL, [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] int? FILKAKKJHAN, bool MACFDFHINIO = false, string GIHAKFMCIGK = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	ODJBMADOOFC INELILLNAPH(Func<bool> DANPNGEGMMJ, Action<bool> BDONPBIAOLL, [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, string GIHAKFMCIGK = "", string PFPNJCFPCDP = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] int? AJDJDACIIPE, [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	ODJBMADOOFC GJGGNLDKMCM(Func<bool> DANPNGEGMMJ, Action<bool> BDONPBIAOLL, [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, string GIHAKFMCIGK = "", string PFPNJCFPCDP = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] int? AJDJDACIIPE, [Optional] Func<bool>? FOFHKJNJKID, [Optional] Func<bool>? CBMKAPKFLEL, string DCINBDMIHIK = "", [Optional] Func<string>? PIDOCKANGOA, string NCCMNOAHLKD = "", [Optional] Func<string>? DPDNALKHGOB, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DCKBLKOIALI HIAFLCBIBLG(Dictionary<string, JOFDKDIOOGF> LBIKMBJEOGO, Func<int> IJPBAMOGJHI, Action<int> LINJHGKIFGG, string GIHAKFMCIGK, string PFPNJCFPCDP = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] Action? KPGEBECNKFF, [Optional] Action? IBBKOMNKJCP, [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] Func<int, string>? DDHFPMLNGFN, bool HKGPBLJHEGH = true, bool PLGONDCFMKP = true, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	DCKBLKOIALI EFMLOABHMGL(Func<Dictionary<string, JOFDKDIOOGF>> MHHNJFIACFJ, Func<int> IJPBAMOGJHI, Action<int> LINJHGKIFGG, string GIHAKFMCIGK, string PFPNJCFPCDP = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] Func<bool>? AKDJGELDNND, [Optional] Func<int, string>? DDHFPMLNGFN, bool HKGPBLJHEGH = true, bool PLGONDCFMKP = true, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	ODJBMADOOFC AHMKHFHIMMF(Func<IReadOnlyList<KeyValuePair<string, JOFDKDIOOGF>>> MHHNJFIACFJ, Func<int> IJPBAMOGJHI, Action<int> LINJHGKIFGG, string GIHAKFMCIGK, string PFPNJCFPCDP = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] Func<bool>? AKDJGELDNND, [Optional] Func<int, string>? DDHFPMLNGFN, [Optional] Action? KPGEBECNKFF, [Optional] Action? IBBKOMNKJCP, bool HKGPBLJHEGH = true, bool PLGONDCFMKP = true, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "23")]
	ODJBMADOOFC HDOGDBNNMFO(Func<List<object>> MHHNJFIACFJ, Func<object> LIPHFDGKPOL, Action<object> JBBMCNMNNFB, Func<object, string> PCDNJNAHFPE, string GIHAKFMCIGK = "", string PFPNJCFPCDP = "", string DIHGHELDAOG = "", string AKGDEEEBIDE = "", [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, bool HKGPBLJHEGH = true, bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ODJBMADOOFC LFHIODJKKMB(string GIHAKFMCIGK, Func<object> LIPHFDGKPOL, Action<object> JBBMCNMNNFB, Func<object, string> PCDNJNAHFPE, Func<IReadOnlyList<object>> ALFMMBFKLBO, [Optional] Func<bool>? GKGBCOJOGBL);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LIIFNLJKGAC(ODJBMADOOFC HGIEFJADOPH);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NIOMEFIBDDM(string IPHHFDBMNEH, Action? EJMENHJOANM, string IJOPPBBFHFC, Action? EBFIEEPFAJG, string BDCMABOIIFF, string GGLEFNIGOIN);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OOMOILKLNKJ(Func<string> DANPNGEGMMJ, Action<string> BDONPBIAOLL, Action ILIBCLLCAFN, [Optional] Func<bool>? GKGBCOJOGBL, JPGEEFFNPKB BFCBMHIDKED = JPGEEFFNPKB.Alphanumeric, [Optional] Func<string, bool>? DJHKMENGGGE, BJOFMICAAKI GPJJALFIBKD = BJOFMICAAKI.Alphanumeric, [Optional] string? PDPNNKFCLLH, [Optional] List<ODJBMADOOFC>? GNNOBKLFHAH, string GIHAKFMCIGK = "", string DIHGHELDAOG = "", string KHICEBLCOOE = "", string EPHLOAEBKBF = "", bool CHFKECPIBPC = true);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CNFKBHEKBGP(string OGKHNGIAPJO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "29")]
	ODJBMADOOFC GEKFLNFKFMM(List<object> LBIKMBJEOGO, List<string> PCDNJNAHFPE, Func<int> IJPBAMOGJHI, Action<int> LINJHGKIFGG, string BMNDJKMDKNL = "", [Optional] Func<bool>? GKGBCOJOGBL, [Optional] Func<bool>? FNNLJBLFOBK, [Optional] Func<bool>? FOFHKJNJKID, bool CHFKECPIBPC = true, bool IBLCLPJIEMB = false);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ODJBMADOOFC
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OFBNOEDAAOO
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMJNPAKBDLJ();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AHLDAMNKPHE
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHKLLGHNAJP();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLPICPNKCHJ(string GFKLEIBLLFL, [In] AFAGIPIINNN COGPPELINPO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFLCIIKENHC(string BDCMABOIIFF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHNBNBOEGIG(string GFPEPHMDHLM);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CGMLAKELBPB : AEFDHDNANIN, LHAJNHDLEEF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IPNMFHEHFND ABBELPKKKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JAJBGLOOLKD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GEBOBBNKDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KGCCENLNABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GDJONEAEEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IDJMNCFHNEE(Guid FIIAJGODPKM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GOLDGPBMDNO(FKBBAHCCEMF EEOBDBMOHPL, IReadOnlyDictionary<KMLAHJFMIMO<NBLNJAIONPA>, Guid>? LDNAMIOKMJB, bool GPLGNBAOHLL);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FBCALAOEPLO(KMLAHJFMIMO<MCIBNEMMFIH> FIIAJGODPKM);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HMCNDDKKNAH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IKIIDFAANID? OHJMENPNAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HGCHNFAGFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool GIBAMLOLIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<IKIIDFAANID> APHGMHJEMLA();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FNBKHJCMJJM<NGNPIEADDLG, LHAJNHDLEEF> GMPMIBPOGKE([In] NGNPIEADDLG BAILEBDHIKH, IEnumerable<APDBPBGHHNA> CFBOHCAIEKI, int GGNDINAAKJO);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ANKLHBNCNND
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnEdgeDidAdd(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnEdgeWillRemove(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHENALOAEAA(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnFunctionDeclsRefreshed();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnEditGraphDidPush();

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnEditGraphDidPop();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IKIIDFAANID
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct GIPHNMOBNPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly MHPBBFJHHCA NDEIGDCAPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly bool FDHJOPELGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly HOCEKIJNPGF KPGKNELKNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly IEnumerable<APDBPBGHHNA> FOLNHIFMOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly bool LIDGKPELLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly KMLAHJFMIMO<NBLNJAIONPA> HANMEEKJCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly int? MDMJKKMICMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly CNGFDBIEJIM? BCIBHHLBLKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly CNGFDBIEJIM? BDBOAFMMOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly FNMHHELFHLH? LALKFHPCGBH;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA4BB0", Offset = "0x1FA35B0", VA = "0x181FA4BB0")]
		public GIPHNMOBNPE(MHPBBFJHHCA ICMMIEHMPPG, bool NNCBOGGFKGE, [In] HOCEKIJNPGF BAILEBDHIKH, IEnumerable<APDBPBGHHNA> CFBOHCAIEKI, bool MAOMJCNBOFL, [In] KMLAHJFMIMO<NBLNJAIONPA> KJJMDODENIL, int? KCICAEPBOAI, [In] CNGFDBIEJIM? NFPBJDLAPAN, [In] CNGFDBIEJIM? ANGBNBCPFFN, [In] FNMHHELFHLH? ELCHALGAFFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct FNMHHELFHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly IReadOnlyCollection<ByteString> BFJNLNBHLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly IReadOnlyCollection<ByteString> CCPPBMOAFJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly IReadOnlyCollection<ByteString> ODPLBANICFK;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1E8A6D0", Offset = "0x1E890D0", VA = "0x181E8A6D0")]
		public FNMHHELFHLH(IReadOnlyCollection<ByteString> KEIIEMOHKKB, IReadOnlyCollection<ByteString> GAFIKHONIBH, IReadOnlyCollection<ByteString> MDCKFNBCMPC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public readonly struct BICCDLPDGPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly HOCEKIJNPGF KPGKNELKNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly IReadOnlyDictionary<Guid, Guid> MFCACNKHAFI;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA21C0", Offset = "0x1FA0BC0", VA = "0x181FA21C0")]
		public BICCDLPDGPG(HOCEKIJNPGF BAILEBDHIKH, IReadOnlyDictionary<Guid, Guid> AMAFKGDLAGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	KMLAHJFMIMO<NBLNJAIONPA> GAFNJGFCJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NHEDIDADICB DOICHCPCCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BMNHLKMMHPH(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KIKJCHCNICB(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] PBADMIJDKPN BNOJOENHOJB);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MEOBNCLFCGL(BKBAMFMLOIC KLMIDHGMDBH);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NCFKMJNMPDC(CNDAGCONHCP GGBKJFAPPKB);

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OGCCCFJLFMD? CEEDJIEHPMB(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CONJBDNJPOL? DBELMEGNBOG(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<AEAOKLPMJLF<NBLNJAIONPA>> PBDBHJLJKNM();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KBKMAHEHBMM? JDJELAPDKHN([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AEAOKLPMJLF<NBLNJAIONPA> DNMPJFKDMEL([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AEAOKLPMJLF<NBLNJAIONPA>? OALJCFLMNHC([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DJEHKJIICEM? LDCJFDEMBNC([In] KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AEAOKLPMJLF<KLHFMEEJLPO> IMPHALGFBIC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<KGGAJFCGDBP> IJOEECMIPHE(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IEnumerable<PBADMIJDKPN> ABIADJCKGPN(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IEnumerable<PBADMIJDKPN> GPFDDOLHFHA(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerable<DJEHKJIICEM> IBKCAJKECHD([In] KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "18")]
	AEAOKLPMJLF<BDBPCEJKAMG> DEGKPCIIJGN(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<AGCGLEPJAOD> OPIPICHPLDD);

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "19")]
	AEAOKLPMJLF<KLHFMEEJLPO> DJONPOGAKMC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "20")]
	AEAOKLPMJLF<KLHFMEEJLPO> LCBAEHAEMKC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "21")]
	AEAOKLPMJLF<IHEDEIEMLNB> GNCCNEKABOP(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OGJLJKJMPCN> KIAKECHEIHO);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IEnumerable<LIAGKFIKHBA> GKOGIICMGOO(PMONCBPNDLN HDMDABBJBJJ, bool ANAACABIBNG, bool HLINCNFBHLE, bool BHGLODFHPJO, bool OENOIPLOKNL);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	LIAGKFIKHBA HNEDKABEGEE(PMONCBPNDLN HDMDABBJBJJ, KBICAKDPENL DBOBAGJCEKG, bool ANAACABIBNG, bool HLINCNFBHLE, bool BHGLODFHPJO, bool OENOIPLOKNL);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KGGAJFCGDBP EGGONJPPDLC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] PBADMIJDKPN BNOJOENHOJB);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KMLAHJFMIMO<NBLNJAIONPA> FMDDHDMIHLF(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	PBADMIJDKPN BOAFIJOBNIB(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LJBNCDPHCEG(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool MOPPPOKHPKC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool OPNKMKOFKBC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "30")]
	FNBKHJCMJJM<BICCDLPDGPG, CGMLAKELBPB> HHOEOGMPENJ([In] GIPHNMOBNPE BKANBMHGIEE);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> DLMANPMKIDC(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "32")]
	FNBKHJCMJJM<ANOINPKCLCH, LHAJNHDLEEF> NKMGOOKLEGP(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, ANOINPKCLCH FKNKHGNACDP, GIFPODEIHBO EILGLGGJDAP);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> JDJCFDNJMEF(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<KLHFMEEJLPO> IEMDKHKMNCL, AEAOKLPMJLF<OCMNEPAAPCH> MMMOMKOGNGK, AEAOKLPMJLF<IMGNCICAHLN> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> AAHEELOOOME(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<KLHFMEEJLPO> FHPBBBHFMKO, AEAOKLPMJLF<OCMNEPAAPCH> DKPAKFMODFF, AEAOKLPMJLF<LBFLHFCOJJC> JALOBJNANCK);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "35")]
	EBBJNKNCBAP BHLILIBIBJJ(IEnumerable<APDBPBGHHNA> CFBOHCAIEKI);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "36")]
	EBBJNKNCBAP DCPPIBKPMIK();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "37")]
	HOCEKIJNPGF ICPIFLHHDKI(MHPBBFJHHCA ICMMIEHMPPG, AEAOKLPMJLF<NBLNJAIONPA> MGFMAFPODJC, IEnumerable<KMLAHJFMIMO<KLHFMEEJLPO>> MBEICLDDFIM, IEnumerable<APDBPBGHHNA> CFBOHCAIEKI);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<BICLLAEGCJD> IFHNPGIMNBE();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool CNHKLGHEPMP(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface NFLHIENJCCC : MJPEAHBDIBA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HMCNDDKKNAH DHAIIGCHMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AEFDHDNANIN : LHAJNHDLEEF
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KBKMAHEHBMM
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	AEAOKLPMJLF<NBLNJAIONPA>? MFFMFEPOLPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FKNCMICMPDN? LAMLPJLHGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BKBAMFMLOIC : KBICAKDPENL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AEAOKLPMJLF<IMGNCICAHLN> CJJDNPJHHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	AEAOKLPMJLF<BDBPCEJKAMG> EJLEKAONHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool PJGMNIHNODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPNHNFFFINN(OFBNOEDAAOO CMLCIAEOMJM);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCLPKCKAIMH(FHGCHDCGJEO PEMAADDPJNG);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "5")]
	string FNABHHKGHGG(int CEBCLCHGCPJ);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CKJDHEDKJGO(KOLLCHLGNHJ EHOKAKKEOJP);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JJJODFNBAAE(KOLLCHLGNHJ EHOKAKKEOJP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface KOLLCHLGNHJ
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DJEHKJIICEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	object OGIEGFFHDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KMLAHJFMIMO<MCIBNEMMFIH> FOEJDELHLCK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	AEAOKLPMJLF<KHFDMNMLHIH> IDCACNLFECP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MJHLJNEEEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int CFMBBGMFHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	AFAGIPIINNN MCGGHMPCMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string BNKFALAODOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NodeVisualizationKey KJIEMALOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AEAOKLPMJLF<FGJJJGNCGHO> GKJAGNIJDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ONJJCABNCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MOIDJKCOKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	EHCPIANDPJL HFOOPKNDBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool LHAEOLOFLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HKNIAAOPGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KGDMOPJDLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int BHBFHDEDHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool FBGCGHFACPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool BDDDCFANOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool BIHIIOLGNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool ACAKFHPMNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ADHPJNPCHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool CPNGCPNCIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BOAACDJMEAE ILAABAGNPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GIFPODEIHBO MNPKHAFPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	[AIONDLNGFIN(true, "FloatingText")]
	bool JNLJIPMGMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "47")]
		[AIONDLNGFIN(true, "FloatingText")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	EACNPILCMOK? GEIJPJOICJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool JBKEFMBPBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AEAOKLPMJLF<NBLNJAIONPA>? HFHKDEJHIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IEnumerable<KMLAHJFMIMO<KLHFMEEJLPO>>? DIPDPMOFBID
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool ELGPBANJDCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool AKOCAJOPIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GHNOBFHKCJH<OCMNEPAAPCH, PPGHCJKEHLK> JOAEGMOOAED
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AEAOKLPMJLF<OCMNEPAAPCH>? DBCPPBLGOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool NHGFLOFHMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "78")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool HNDAPHCDBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "79")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EPAEABBGKIB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LKDDLKNNGPG EBMENLKGCFJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event GENAJNHCDIC PEHOAAHFFGP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action DPMFDBMAPDL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action FMDHIBEELMD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<AEAOKLPMJLF<OCMNEPAAPCH>, PPGHCJKEHLK> GPJLILGKOFL;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<AEAOKLPMJLF<OCMNEPAAPCH>> HJFDEGELPJL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<AEAOKLPMJLF<OCMNEPAAPCH>, PPGHCJKEHLK> FEBJCODPPDK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<AEAOKLPMJLF<OCMNEPAAPCH>, AEAOKLPMJLF<OCMNEPAAPCH>> EPFPFIKKEAL;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<AEAOKLPMJLF<OCMNEPAAPCH>, PPGHCJKEHLK> BGNHEMBOGDI;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<AEAOKLPMJLF<OCMNEPAAPCH>, AEAOKLPMJLF<OCMNEPAAPCH>> IGPEEIEJEBD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBGBABLJMGM(int FMIPNGCLIPH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool HLBINKAJEJE([In] BOAACDJMEAE DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool GEIDLINCCDL([In] GIFPODEIHBO DBOBEHLEAAE);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KOCJDENJAKO();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> MIGFNHLNHLF(BOAACDJMEAE? KHAKKIFNDKN, GIFPODEIHBO? IMKGMPHEJPJ);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OMJMIDHHPPD();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MKAFIGLJJGG();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void OKJALKJLOPB();

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool EIDKPDOEMCA([Out] Guid LACHIMFDJHG);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool AFBBEJBMAFB([In] Guid OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void GLMNPCAHJLC();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void HAIHIJBCBGB(bool HENDPJDONKM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "46")]
	CHBBJDMPBJH CMBDBBOHPOP([In] FEJEMLCOPNG GAFAGDAJGNB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void KJFNLEAJFAJ(object EHKEIGANPJL);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void OEDEFCJEFGI(object EHKEIGANPJL);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task<FNBKHJCMJJM<AEAOKLPMJLF<OCMNEPAAPCH>, AEFDHDNANIN>> DDENPBIFNMN(string CCMEKJGADHN);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void MCLPKCKAIMH(JNLKIMCIIGL BNKMBKIJGCK);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "76")]
	CNGFDBIEJIM NCOCHNHGMKK();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool FLHKKJIBHKK(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "80")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> NNNAKMEPDEL(AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CNDAGCONHCP : KBICAKDPENL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	AEAOKLPMJLF<IHEDEIEMLNB> HCBNEGKHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	AEAOKLPMJLF<LBFLHFCOJJC> EAJOLKFKPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface KBICAKDPENL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	IEnumerable<StaticEdge> PBAJAOPMKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	DisplayKind LIGPOPJEPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	AEAOKLPMJLF<OCMNEPAAPCH> DPAMGNBHBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	AEAOKLPMJLF<LFJOPAANECO> GMOIOCJLGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	EBHKBKFGBJI DELMIOEDGCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	PortImage EBIKDLPKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DABPKCBIDBG(PIPCEJIDDML EHOKAKKEOJP);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OFFHPKKEPLC(BIKOHGFDEKO EHOKAKKEOJP);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AJEABJJGHOH(AHLDAMNKPHE MFCDNFDCOHC);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OFOMMPEGNAE(PIPCEJIDDML EHOKAKKEOJP);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IMFINAIEPPB(BIKOHGFDEKO EHOKAKKEOJP);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PIPCEJIDDML
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface PPGHCJKEHLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate void KDCHMFHEIOG(AEAOKLPMJLF<OCMNEPAAPCH> JHNCHHHEDDG, AEAOKLPMJLF<OCMNEPAAPCH> CIJLPDDPPNH);

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool GEKFJCHBOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool CLCOEEKMDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool KKJGPHLFFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool LGFICCBKKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GHNOBFHKCJH<IMGNCICAHLN, BKBAMFMLOIC> LBHANEMIHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string JGFOABOCNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	GHNOBFHKCJH<LBFLHFCOJJC, CNDAGCONHCP> PKEHGCGDANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	AEAOKLPMJLF<OCMNEPAAPCH> DPAMGNBHBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action GFGKDAODNGG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action GPGCEHGLOID;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<AEAOKLPMJLF<IMGNCICAHLN>, AEAOKLPMJLF<IMGNCICAHLN>> EACLBMGDMLA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AEAOKLPMJLF<IMGNCICAHLN>, AEAOKLPMJLF<IMGNCICAHLN>> JKDBAMIBALA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AEAOKLPMJLF<LBFLHFCOJJC>, AEAOKLPMJLF<LBFLHFCOJJC>> GAOOFODGBAC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<AEAOKLPMJLF<LBFLHFCOJJC>, AEAOKLPMJLF<LBFLHFCOJJC>> MAGHHIBFBFO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<AEAOKLPMJLF<IMGNCICAHLN>, BKBAMFMLOIC> JEAJAGDGFHA;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<AEAOKLPMJLF<IMGNCICAHLN>> DILJAKNCPFM;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<AEAOKLPMJLF<IMGNCICAHLN>, BKBAMFMLOIC> NMDIGJHIPNL;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<AEAOKLPMJLF<LBFLHFCOJJC>, CNDAGCONHCP> HGCMDJIJEJK;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<AEAOKLPMJLF<LBFLHFCOJJC>> PFKLHPAGLHN;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event Action<AEAOKLPMJLF<LBFLHFCOJJC>, CNDAGCONHCP> EHDADJOFNNM;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> EHLLCNHIPGC();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> OHEHPMMKCBO(AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> BAMGDNHLGFE(AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> CIPDOONDBJL(AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN, AEAOKLPMJLF<BFOFNGJHPOB> NGLIMKHNLHO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> IADAMBDFBNI(AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB, AEAOKLPMJLF<MDOKFDDKFCD> NGLIMKHNLHO);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> PNIOMHFPBIO();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> IHGFJKMKOMB(string MDMFBDANHFO);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> OLILHGOLLFK(AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN, string CCMEKJGADHN);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> BHPPGLKDAAG(AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB, string CCMEKJGADHN);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> EJKCDEPJLBA(AEAOKLPMJLF<BFOFNGJHPOB> KGIPJGFDAIN, LIAGKFIKHBA ADDOHDGDFOD);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<FNBKHJCMJJM<LMMCANLFCCL, AEFDHDNANIN>> LPMIEOHALBH(AEAOKLPMJLF<MDOKFDDKFCD> EMEMEBKMKJB, LIAGKFIKHBA ADDOHDGDFOD);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LIAGKFIKHBA
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	TypeKey BIGLIOCAMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	string CKKGADOKLAI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<FNBKHJCMJJM<AEAOKLPMJLF<BFOFNGJHPOB>, AEFDHDNANIN>> CGLGNNLIDBL(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, string CCMEKJGADHN);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<FNBKHJCMJJM<AEAOKLPMJLF<MDOKFDDKFCD>, AEFDHDNANIN>> GIHKDALOFEC(KMLAHJFMIMO<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<KLHFMEEJLPO> OAAAKELMLJG, AEAOKLPMJLF<OCMNEPAAPCH> OJKOEGHEJMC, string CCMEKJGADHN);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface BIKOHGFDEKO
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed([In] JNABDEJALON PIOKPPIBBDE);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EBHKBKFGBJI
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool ENADOMBMJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool HINONGNEJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	TypeKey KJIEMALOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool DKLJCCHJDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class JLKGHBACJLF : BICLLAEGCJD, IEquatable<JLKGHBACJLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> BKJBEIKDHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> AFPMFNIDLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> KDGNOLKKKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BIHDIOOJFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly AEAOKLPMJLF<BDBPCEJKAMG> KIMMDPAFJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly AEAOKLPMJLF<IHEDEIEMLNB> PPACJJDFPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly string GBLKFGJBNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly string CPHDEKGNAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1FA74D0", Offset = "0x1FA5ED0", VA = "0x181FA74D0")]
	public JLKGHBACJLF(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> NHNCHIFBIFL, [In] KMLAHJFMIMO<KLHFMEEJLPO> FKEHCJGIACG, AEAOKLPMJLF<KLHFMEEJLPO> MNBJIOFGMKI, [In] KMLAHJFMIMO<KLHFMEEJLPO> LOFNEJNBPOC, AEAOKLPMJLF<BDBPCEJKAMG> BPLDBIKNBFO, AEAOKLPMJLF<IHEDEIEMLNB> MAECFIFHOEP, string FOKIMMMGAJM, string BMHPFPJOJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x84FCC0", Offset = "0x84E6C0", VA = "0x18084FCC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7010", Offset = "0x1FA5A10", VA = "0x181FA7010", Slot = "4")]
	public bool Equals(JLKGHBACJLF MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7190", Offset = "0x1FA5B90", VA = "0x181FA7190", Slot = "0")]
	public override bool Equals(object? MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7350", Offset = "0x1FA5D50", VA = "0x181FA7350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class KMLAGNNKNKF : BICLLAEGCJD, IEquatable<KMLAGNNKNKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA86D0", Offset = "0x1FA70D0", VA = "0x181FA86D0")]
	public KMLAGNNKNKF(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8510", Offset = "0x1FA6F10", VA = "0x181FA8510", Slot = "4")]
	public bool Equals(KMLAGNNKNKF MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA85A0", Offset = "0x1FA6FA0", VA = "0x181FA85A0", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8660", Offset = "0x1FA7060", VA = "0x181FA8660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class LNPMMNLDJHM : BICLLAEGCJD, IEquatable<LNPMMNLDJHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly AEAOKLPMJLF<BDBPCEJKAMG> PIGLBDAEMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly AEAOKLPMJLF<BDBPCEJKAMG> HBODMPGJDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly int PHAKPFLFNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9500", Offset = "0x1FA7F00", VA = "0x181FA9500")]
	public LNPMMNLDJHM(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, AEAOKLPMJLF<BDBPCEJKAMG> KBLDFNCHHGO, AEAOKLPMJLF<BDBPCEJKAMG> ENBHLMHBGGK, int OPIPICHPLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9150", Offset = "0x1FA7B50", VA = "0x181FA9150", Slot = "4")]
	public bool Equals(LNPMMNLDJHM HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9280", Offset = "0x1FA7C80", VA = "0x181FA9280", Slot = "0")]
	public override bool Equals(object? GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9410", Offset = "0x1FA7E10", VA = "0x181FA9410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class ICJNGIPHLAI : BICLLAEGCJD, IEquatable<ICJNGIPHLAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly int GIFDEMPHMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly int GEBOPIHNMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4F80", Offset = "0x1FA3980", VA = "0x181FA4F80")]
	public ICJNGIPHLAI(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, [In] KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, int CGHONOMCCBG, int EGIAGLGJBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4D90", Offset = "0x1FA3790", VA = "0x181FA4D90", Slot = "4")]
	public bool Equals(ICJNGIPHLAI MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4C60", Offset = "0x1FA3660", VA = "0x181FA4C60", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4E80", Offset = "0x1FA3880", VA = "0x181FA4E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class AKJHFFDKKFA : BICLLAEGCJD, IEquatable<AKJHFFDKKFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA06B0", Offset = "0x1F9F0B0", VA = "0x181FA06B0")]
	public AKJHFFDKKFA(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, [In] KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0410", Offset = "0x1F9EE10", VA = "0x181FA0410", Slot = "4")]
	public bool Equals(AKJHFFDKKFA MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA04E0", Offset = "0x1F9EEE0", VA = "0x181FA04E0", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA05F0", Offset = "0x1F9EFF0", VA = "0x181FA05F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class MLDAIIJLDIL : BICLLAEGCJD, IEquatable<MLDAIIJLDIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly AEAOKLPMJLF<IHEDEIEMLNB> CEHCDHIPGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly AEAOKLPMJLF<IHEDEIEMLNB> JKKCHJNFDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly int FLNHBIBPAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9E60", Offset = "0x1FA8860", VA = "0x181FA9E60")]
	public MLDAIIJLDIL(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, AEAOKLPMJLF<IHEDEIEMLNB> HAFIDPBBMNF, AEAOKLPMJLF<IHEDEIEMLNB> AGHPGMJNGIM, int KIAKECHEIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9C40", Offset = "0x1FA8640", VA = "0x181FA9C40", Slot = "4")]
	public bool Equals(MLDAIIJLDIL? HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9AB0", Offset = "0x1FA84B0", VA = "0x181FA9AB0", Slot = "0")]
	public override bool Equals(object? GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9D70", Offset = "0x1FA8770", VA = "0x181FA9D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PCPNNNOHMPB : BICLLAEGCJD, IEquatable<PCPNNNOHMPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly int BOGOEJANHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly int LKLMNKBFMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB140", Offset = "0x1FA9B40", VA = "0x181FAB140")]
	public PCPNNNOHMPB(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, [In] KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, int OPJNIHKDOHC, int BGJIMFJEAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAE20", Offset = "0x1FA9820", VA = "0x181FAAE20", Slot = "4")]
	public bool Equals(PCPNNNOHMPB MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAF10", Offset = "0x1FA9910", VA = "0x181FAAF10", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB040", Offset = "0x1FA9A40", VA = "0x181FAB040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class DBDIIKOJMPB
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class MCIBNEMMFIH
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class NBLNJAIONPA
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class LOEJABGCBCC
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class BDBPCEJKAMG : JIDADGKJHCM
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class BFOFNGJHPOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class AGCGLEPJAOD : GLAFOLBMDJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class KLHFMEEJLPO
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class KHFDMNMLHIH
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class JCPPPGDAEIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class IHEDEIEMLNB : JIDADGKJHCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class MDOKFDDKFCD
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class OGJLJKJMPCN : GLAFOLBMDJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class JIDADGKJHCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[AFLDEPHJFEH("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class OCMNEPAAPCH
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class IMGNCICAHLN : LFJOPAANECO
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class LBFLHFCOJJC : LFJOPAANECO
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class LFJOPAANECO
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class GLAFOLBMDJJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class APDNBCAGDFM
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class FGJJJGNCGHO
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class NKJLILGJMGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class MMCELLIDCGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class JDEKKAJANBP : BICLLAEGCJD, IEquatable<JDEKKAJANBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public StaticEdge DABJAPIAJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6400", Offset = "0x1FA4E00", VA = "0x181FA6400")]
	public JDEKKAJANBP(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, [In] StaticEdge BDNKJKPAPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x84FCD0", Offset = "0x84E6D0", VA = "0x18084FCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA62E0", Offset = "0x1FA4CE0", VA = "0x181FA62E0", Slot = "4")]
	public bool Equals(JDEKKAJANBP MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6200", Offset = "0x1FA4C00", VA = "0x181FA6200", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6380", Offset = "0x1FA4D80", VA = "0x181FA6380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class AKCGEFGFDKM : BICLLAEGCJD, IEquatable<AKCGEFGFDKM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0350", Offset = "0x1F9ED50", VA = "0x181FA0350")]
	public AKCGEFGFDKM([In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1FA02B0", Offset = "0x1F9ECB0", VA = "0x181FA02B0", Slot = "4")]
	public bool Equals(AKCGEFGFDKM MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0210", Offset = "0x1F9EC10", VA = "0x181FA0210", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0310", Offset = "0x1F9ED10", VA = "0x181FA0310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class LDNMHNEHLPH : BICLLAEGCJD, IEquatable<LDNMHNEHLPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public readonly AEAOKLPMJLF<BDBPCEJKAMG> PIGLBDAEMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly AEAOKLPMJLF<BDBPCEJKAMG> CLJAKMLOMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public readonly int PHAKPFLFNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8BA0", Offset = "0x1FA75A0", VA = "0x181FA8BA0")]
	public LDNMHNEHLPH(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, AEAOKLPMJLF<BDBPCEJKAMG> KBLDFNCHHGO, AEAOKLPMJLF<BDBPCEJKAMG> PBNABHKCIHF, int OPIPICHPLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8980", Offset = "0x1FA7380", VA = "0x181FA8980", Slot = "4")]
	public bool Equals(LDNMHNEHLPH? HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1FA87F0", Offset = "0x1FA71F0", VA = "0x181FA87F0", Slot = "0")]
	public override bool Equals(object? GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8AB0", Offset = "0x1FA74B0", VA = "0x181FA8AB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public sealed class JADDPKHFGHA : BICLLAEGCJD, IEquatable<JADDPKHFGHA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly int GIFDEMPHMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly int GEBOPIHNMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5D00", Offset = "0x1FA4700", VA = "0x181FA5D00")]
	public JADDPKHFGHA(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, [In] KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, int CGHONOMCCBG, int EGIAGLGJBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5B10", Offset = "0x1FA4510", VA = "0x181FA5B10", Slot = "4")]
	public bool Equals(JADDPKHFGHA MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA59E0", Offset = "0x1FA43E0", VA = "0x181FA59E0", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5C00", Offset = "0x1FA4600", VA = "0x181FA5C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public sealed class INDPAAGAFFK : BICLLAEGCJD, IEquatable<INDPAAGAFFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA56B0", Offset = "0x1FA40B0", VA = "0x181FA56B0")]
	public INDPAAGAFFK(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, [In] KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5570", Offset = "0x1FA3F70", VA = "0x181FA5570", Slot = "4")]
	public bool Equals(INDPAAGAFFK MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5480", Offset = "0x1FA3E80", VA = "0x181FA5480", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5620", Offset = "0x1FA4020", VA = "0x181FA5620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class CEFOCHLPIDL : BICLLAEGCJD, IEquatable<CEFOCHLPIDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly AEAOKLPMJLF<IHEDEIEMLNB> CEHCDHIPGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly AEAOKLPMJLF<IHEDEIEMLNB> FIGDNIOMCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly int FLNHBIBPAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1FA31F0", Offset = "0x1FA1BF0", VA = "0x181FA31F0")]
	public CEFOCHLPIDL(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, AEAOKLPMJLF<IHEDEIEMLNB> HAFIDPBBMNF, AEAOKLPMJLF<IHEDEIEMLNB> JPHMMMLPELG, int KIAKECHEIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2FD0", Offset = "0x1FA19D0", VA = "0x181FA2FD0", Slot = "4")]
	public bool Equals(CEFOCHLPIDL? HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2E40", Offset = "0x1FA1840", VA = "0x181FA2E40", Slot = "0")]
	public override bool Equals(object? GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3100", Offset = "0x1FA1B00", VA = "0x181FA3100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class FOILKEGPGLL : BICLLAEGCJD, IEquatable<FOILKEGPGLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly int BOGOEJANHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly int LKLMNKBFMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x1FA46B0", Offset = "0x1FA30B0", VA = "0x181FA46B0")]
	public FOILKEGPGLL(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, [In] KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, [In] KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, int OPJNIHKDOHC, int BGJIMFJEAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA44C0", Offset = "0x1FA2EC0", VA = "0x181FA44C0", Slot = "4")]
	public bool Equals(FOILKEGPGLL MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4390", Offset = "0x1FA2D90", VA = "0x181FA4390", Slot = "0")]
	public override bool Equals(object? MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA45B0", Offset = "0x1FA2FB0", VA = "0x181FA45B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[NAEMOJOGDHL("StaticEdge")]
public readonly struct KGGAJFCGDBP : IEquatable<KGGAJFCGDBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public readonly AEAOKLPMJLF<IHEDEIEMLNB> NHEMMHDEKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public readonly AEAOKLPMJLF<BDBPCEJKAMG> OKJEOJJLHMM;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
	public KGGAJFCGDBP(AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8250", Offset = "0x1FA6C50", VA = "0x181FA8250")]
	public void DNIPHOADCKN([Out] AEAOKLPMJLF<IHEDEIEMLNB> JCBKAKLLMGE, [Out] AEAOKLPMJLF<BDBPCEJKAMG> IGIGNPMCDHI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8370", Offset = "0x1FA6D70", VA = "0x181FA8370")]
	public static bool IKJGJDJDJIH(KGGAJFCGDBP FKJLOGAHGLJ, KGGAJFCGDBP MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8260", Offset = "0x1FA6C60", VA = "0x181FA8260", Slot = "4")]
	public bool Equals(KGGAJFCGDBP HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8270", Offset = "0x1FA6C70", VA = "0x181FA8270", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8300", Offset = "0x1FA6D00", VA = "0x181FA8300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class DPBLMMKBNKP : BICLLAEGCJD, IEquatable<DPBLMMKBNKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public readonly int KAKOLNADGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly int BFANOECIBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly int MNNEGHIHJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3DB0", Offset = "0x1FA27B0", VA = "0x181FA3DB0")]
	public DPBLMMKBNKP(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, int PMPADMLEDOB, int FLHLGGLGODN, int PLJFJGMGKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3BB0", Offset = "0x1FA25B0", VA = "0x181FA3BB0", Slot = "4")]
	public bool Equals(DPBLMMKBNKP MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3A80", Offset = "0x1FA2480", VA = "0x181FA3A80", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3CA0", Offset = "0x1FA26A0", VA = "0x181FA3CA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class JDLEPHGEHDB : BICLLAEGCJD, IEquatable<JDLEPHGEHDB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly AEAOKLPMJLF<NBLNJAIONPA> NFLCFAHEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly KMLAHJFMIMO<NBLNJAIONPA> LJHLLJEFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public readonly AEAOKLPMJLF<KLHFMEEJLPO> PDGNDMNFBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BNODLMJFKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public readonly int KAKOLNADGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly int OEDLIJDPNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public readonly int CDFELDFOPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6A80", Offset = "0x1FA5480", VA = "0x181FA6A80")]
	public JDLEPHGEHDB(AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, KMLAHJFMIMO<NBLNJAIONPA> DLDDICLBBMP, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, KMLAHJFMIMO<KLHFMEEJLPO> PHBIOMHPOHE, int PMPADMLEDOB, int JMJEJHBPMJI, int BNANGDMFJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6750", Offset = "0x1FA5150", VA = "0x181FA6750", Slot = "4")]
	public bool Equals(JDLEPHGEHDB MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6840", Offset = "0x1FA5240", VA = "0x181FA6840", Slot = "0")]
	public override bool Equals(object MENCHHOFOIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6970", Offset = "0x1FA5370", VA = "0x181FA6970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct FKNCMICMPDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> OBKCHDEEEMF;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4380", Offset = "0x1FA2D80", VA = "0x181FA4380")]
	public FKNCMICMPDN([In] KMLAHJFMIMO<KLHFMEEJLPO> JIBFJBIIGJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public delegate void DIJOKFLPICL([In] JNABDEJALON PIOKPPIBBDE);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum PortImage
	{
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		List,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		StateTransition
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public delegate void LKDDLKNNGPG([In] BOAACDJMEAE CDCOLBIEICK);
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum IPNMFHEHFND
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Versioning,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	NodesNotAllowedInTargetGraph,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	SyncedVariablesNotAllowedInTargetGraphOrDescendents
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct NHEDIDADICB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly LIAGKFIKHBA GAPAAPMPOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly LIAGKFIKHBA KNPNCMMCNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly LIAGKFIKHBA CEJIPFEEPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly LIAGKFIKHBA HLMOELHFEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly LIAGKFIKHBA DOJCIDFIKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly LIAGKFIKHBA ICKPMIECFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly LIAGKFIKHBA ECGOHEHLNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly LIAGKFIKHBA CFMBBGMFHHC;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA410", Offset = "0x1FA8E10", VA = "0x181FAA410")]
	public NHEDIDADICB(LIAGKFIKHBA MOCAGHFEIFE, LIAGKFIKHBA HFHKIOBKLBD, LIAGKFIKHBA KFFCGALKCOB, LIAGKFIKHBA NMCMFFNKPBD, LIAGKFIKHBA OENECLLHEOJ, LIAGKFIKHBA IBDDJBFEFDB, LIAGKFIKHBA KNLKNGIBAFB, LIAGKFIKHBA COGPPELINPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate void GENAJNHCDIC([In] GIFPODEIHBO KIJAKHEBLHL);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct PBADMIJDKPN : IEquatable<PBADMIJDKPN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> BKJBEIKDHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly AEAOKLPMJLF<OGJLJKJMPCN> CKGGOIEMPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public readonly KMLAHJFMIMO<KLHFMEEJLPO> KDGNOLKKKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public readonly AEAOKLPMJLF<AGCGLEPJAOD> OGKBCLKIDNC;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAE00", Offset = "0x1FA9800", VA = "0x181FAAE00")]
	public PBADMIJDKPN([In] KMLAHJFMIMO<KLHFMEEJLPO> NHNCHIFBIFL, AEAOKLPMJLF<OGJLJKJMPCN> OGOCDMBOGEM, [In] KMLAHJFMIMO<KLHFMEEJLPO> MNBJIOFGMKI, AEAOKLPMJLF<AGCGLEPJAOD> BLDEOOGMHIG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA9D0", Offset = "0x1FA93D0", VA = "0x181FAA9D0")]
	public static bool IKJGJDJDJIH([In] PBADMIJDKPN FKJLOGAHGLJ, [In] PBADMIJDKPN MJMNBMLJKJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA7B0", Offset = "0x1FA91B0", VA = "0x181FAA7B0", Slot = "4")]
	public bool Equals(PBADMIJDKPN HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA870", Offset = "0x1FA9270", VA = "0x181FAA870", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA920", Offset = "0x1FA9320", VA = "0x181FAA920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAAA90", Offset = "0x1FA9490", VA = "0x181FAAA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly KMLAHJFMIMO<KLHFMEEJLPO> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly AEAOKLPMJLF<OCMNEPAAPCH> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly AEAOKLPMJLF<LBFLHFCOJJC> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly KMLAHJFMIMO<KLHFMEEJLPO> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly AEAOKLPMJLF<OCMNEPAAPCH> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly AEAOKLPMJLF<IMGNCICAHLN> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1FABD80", Offset = "0x1FAA780", VA = "0x181FABD80")]
		public StaticEdge([In] KMLAHJFMIMO<KLHFMEEJLPO> NHNCHIFBIFL, AEAOKLPMJLF<OCMNEPAAPCH> FBGFLFJCDKB, AEAOKLPMJLF<LBFLHFCOJJC> OBINCBNJCCC, [In] KMLAHJFMIMO<KLHFMEEJLPO> MNBJIOFGMKI, AEAOKLPMJLF<OCMNEPAAPCH> EPGCEPONHKA, AEAOKLPMJLF<IMGNCICAHLN> MKFJCFMONII)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB800", Offset = "0x1FAA200", VA = "0x181FAB800")]
		public static bool IKJGJDJDJIH([In] StaticEdge FKJLOGAHGLJ, [In] StaticEdge MJMNBMLJKJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB6F0", Offset = "0x1FAA0F0", VA = "0x181FAB6F0", Slot = "4")]
		public bool Equals(StaticEdge HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB640", Offset = "0x1FAA040", VA = "0x181FAB640", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB710", Offset = "0x1FAA110", VA = "0x181FAB710", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FAB8F0", Offset = "0x1FAA2F0", VA = "0x181FAB8F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class KIAIDACNNEK
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1FA83F0", Offset = "0x1FA6DF0", VA = "0x181FA83F0")]
	public static StaticEdge FIOJCIMJMME(this PENIAGMKBEI BBCPNLGGBMJ)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public readonly struct CGJMJLICBBF : IEquatable<CGJMJLICBBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly string HMOHJILNKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly int GOBIGDEPIMF;

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1AA4970", Offset = "0x1AA3370", VA = "0x181AA4970")]
	public CGJMJLICBBF(string MGIDEFLKNJN, int HHHHLPIAMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1FA37A0", Offset = "0x1FA21A0", VA = "0x181FA37A0", Slot = "4")]
	public bool Equals(CGJMJLICBBF HENLEJBGFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct JLLFHCCFBDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly string JGFOABOCNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly LCPPJMABLCL.HINDJIMFCLL.DGFDMNFMIFO EOHIMOJAOAL;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1AA4970", Offset = "0x1AA3370", VA = "0x181AA4970")]
	public JLLFHCCFBDP(string CCMEKJGADHN, LCPPJMABLCL.HINDJIMFCLL.DGFDMNFMIFO KHBEPMPMJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7D70", Offset = "0x1FA6770", VA = "0x181FA7D70")]
	internal static JLLFHCCFBDP FIOJCIMJMME(LCPPJMABLCL EEOBDBMOHPL)
	{
		return default(JLLFHCCFBDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7E30", Offset = "0x1FA6830", VA = "0x181FA7E30")]
	internal LCPPJMABLCL KJCBMOAEMAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7DC0", Offset = "0x1FA67C0", VA = "0x181FA7DC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7CC0", Offset = "0x1FA66C0", VA = "0x181FA7CC0", Slot = "0")]
	public override bool Equals(object GKHPLGCJCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x1FA37A0", Offset = "0x1FA21A0", VA = "0x181FA37A0")]
	public bool KGOKJGAEDPI(JLLFHCCFBDP HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1FA7EA0", Offset = "0x1FA68A0", VA = "0x181FA7EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public readonly struct AMLNGDLILHM : IEquatable<AMLNGDLILHM>
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly IReadOnlyDictionary<KMLAHJFMIMO<MMCELLIDCGD>, CGJMJLICBBF> FBAGANMCDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public readonly BMHHJJAJKMB ELJHJONKMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public readonly string ANONOEJEAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly IReadOnlyDictionary<KMLAHJFMIMO<MMCELLIDCGD>, CGJMJLICBBF> FIMEJGLBGIC;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool JPOGMMCJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FA0A70", Offset = "0x1F9F470", VA = "0x181FA0A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1E80", Offset = "0x1FA0880", VA = "0x181FA1E80")]
	public AMLNGDLILHM(BMHHJJAJKMB LCCJDDLAHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1F30", Offset = "0x1FA0930", VA = "0x181FA1F30")]
	public AMLNGDLILHM(BMHHJJAJKMB LCCJDDLAHPK, IReadOnlyDictionary<KMLAHJFMIMO<MMCELLIDCGD>, CGJMJLICBBF> PMPDEGOLKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0AF0", Offset = "0x1F9F4F0", VA = "0x181FA0AF0")]
	public static AMLNGDLILHM DNOKAKFNIEA(AMLNGDLILHM DDBAOJNPMKI, AMLNGDLILHM CKAPMIGPPBJ)
	{
		return default(AMLNGDLILHM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1820", Offset = "0x1FA0220", VA = "0x181FA1820")]
	public static AMLNGDLILHM FIOJCIMJMME(FHEKNCIIBCE EEOBDBMOHPL)
	{
		return default(AMLNGDLILHM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1C50", Offset = "0x1FA0650", VA = "0x181FA1C50")]
	public FHEKNCIIBCE KJCBMOAEMAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1FA13E0", Offset = "0x1F9FDE0", VA = "0x181FA13E0", Slot = "4")]
	public bool Equals(AMLNGDLILHM HENLEJBGFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public readonly struct BMHHJJAJKMB : IEquatable<BMHHJJAJKMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public readonly string JGFOABOCNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public readonly IReadOnlyList<JLLFHCCFBDP> LBHANEMIHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public readonly IReadOnlyList<JLLFHCCFBDP> PKEHGCGDANI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool JPOGMMCJBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2200", Offset = "0x1FA0C00", VA = "0x181FA2200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1E8A6D0", Offset = "0x1E890D0", VA = "0x181E8A6D0")]
	public BMHHJJAJKMB(string CCMEKJGADHN, IReadOnlyList<JLLFHCCFBDP> DCAOKMPCLKP, IReadOnlyList<JLLFHCCFBDP> KPHKLBAABGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FA22D0", Offset = "0x1FA0CD0", VA = "0x181FA22D0")]
	public static BMHHJJAJKMB FIOJCIMJMME(KPFGHODMJMG EEOBDBMOHPL)
	{
		return default(BMHHJJAJKMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2810", Offset = "0x1FA1210", VA = "0x181FA2810")]
	public KPFGHODMJMG KJCBMOAEMAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FA25B0", Offset = "0x1FA0FB0", VA = "0x181FA25B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2630", Offset = "0x1FA1030", VA = "0x181FA2630")]
	private static int HFDIHPKNAFP(IReadOnlyList<JLLFHCCFBDP> LMJJJMBKIKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2220", Offset = "0x1FA0C20", VA = "0x181FA2220", Slot = "4")]
	public bool Equals(BMHHJJAJKMB HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2AA0", Offset = "0x1FA14A0", VA = "0x181FA2AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public enum MHPBBFJHHCA
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class FNLNJGHIMBL
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
	public static bool BHDGJJFEECI(this MHPBBFJHHCA GDIKEMIFDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
	public static bool PBCCDMMNELE(this MHPBBFJHHCA GDIKEMIFDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
	public static bool CMFKDEHLHHN(this MHPBBFJHHCA GDIKEMIFDHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public enum DDEANIGBKFC
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct JNABDEJALON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public readonly bool IIGAICHNPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public readonly DDEANIGBKFC JGAJFJEJBCF;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FA8150", Offset = "0x1FA6B50", VA = "0x181FA8150")]
	public JNABDEJALON(bool MDJNANMCCOF, DDEANIGBKFC NJNLOLBJAEJ)
	{
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		String,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Color
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
