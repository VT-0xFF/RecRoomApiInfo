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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C2F980", Offset = "0x1C2E780", VA = "0x181C2F980")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum FOLCNEIOBKG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Follow,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Orbit,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Attached,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Detached
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct HBPFLNJBBKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly NBEIOMNAHGH PBIJANGFMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly BFKEOOGHBIP ALELPKGABJM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DFA0", Offset = "0x1C2CDA0", VA = "0x181C2DFA0")]
	public HBPFLNJBBKM([In] NBEIOMNAHGH MFKPIJLKLHA, BFKEOOGHBIP NEFJKEGBDFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NBEIOMNAHGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly ICPANFIDEEC FMHJFCMDNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly HGJAPEMBOLA LIHECCHDFEC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F1EC0", Offset = "0x7F0CC0", VA = "0x1807F1EC0")]
	public NBEIOMNAHGH(ICPANFIDEEC PLANPFCHABC, HGJAPEMBOLA ONJOBEGMNDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BFKEOOGHBIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly KOEJGCBBPJC KMINBMONBNK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F19C0", Offset = "0x7F07C0", VA = "0x1807F19C0")]
	public BFKEOOGHBIP(KOEJGCBBPJC MPDOPIGCPLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct HMKNNOCBHCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly HIIAPPKLABP NHDPCNKGDHF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F19C0", Offset = "0x7F07C0", VA = "0x1807F19C0")]
	public HMKNNOCBHCF(HIIAPPKLABP FOBBAPNDCDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum HGECBIKFCEN
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Digit,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Integer,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Decimal,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Regex,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CustomValidator
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum BHHHGADGDOC
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Custom
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BMOBMBJMPOM : BFLPLNACJIL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeRecorderData(string PIEEKDPHIFD, Action<string, float> AKPLNAGBBLB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KMCJAPGOOKG : MFJHIEPHMDF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHMHMFOJFIE();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BFLPLNACJIL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnHide();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DoneEditing();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CGMGIGLMEFO
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FBJBCONADBC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string AJMAPMCDFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int LONLOIKBJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BGOBMCFNCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EOILIBEFGIE : MFJHIEPHMDF
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAFNAGDLNDC(MFJHIEPHMDF EGJHEDOJEBL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOCKAINKMIG();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILBKIBAINPM(MFJHIEPHMDF EGJHEDOJEBL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JKKDAPEMKDN
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDPAPNGAKPF(string AAAAOINJGOG, Func<string> JBIPOCIMLEM, Action<string> AJLENIHKDOA, Func<bool> IMNHLOKMLDA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBMDFHOCCJP(string AAAAOINJGOG, Action NGOFEPBCOKF, Func<bool> IMNHLOKMLDA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJAJLJJOFJD(string AAAAOINJGOG, Func<int> NANJMBFHPEE, Action<int> ECJLKKCHFGP, Func<bool> IMNHLOKMLDA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIJMABHCEGF(string AAAAOINJGOG, Func<int> JBIPOCIMLEM, Action<int> AJLENIHKDOA, Func<bool> IMNHLOKMLDA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCLPHNJKAFH(string AAAAOINJGOG, Func<int> NODDAOHANKE, Action<object> PKFBODMLBBI, Func<object, string> AIMHGGIHECD, Func<bool> IMNHLOKMLDA, Type GOCAMACBFDC, IReadOnlyList<object> HIHKIBFEAIM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKHNNOAOMKN(string AAAAOINJGOG, Func<string> JBIPOCIMLEM, Action<string> AJLENIHKDOA, Func<bool> IMNHLOKMLDA);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGGJEKAKDAI(string AAAAOINJGOG, Func<bool> JBIPOCIMLEM, Action<bool> AJLENIHKDOA, Func<bool> IMNHLOKMLDA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PALLFOJMPAM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface FBEFOMGFHKK
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Action<PALLFOJMPAM>? FONECAHEMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Action<PALLFOJMPAM>? NLJBDEJODLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MFJHIEPHMDF BJMIEGNFNBA(Func<byte> FNIHDDIFNBA, Action<byte> CONMOPKKJLA, Func<int> BNFGGCMDPDD, Action<int> MCNPAGKIEBI, [Optional] Func<bool>? IMNHLOKMLDA);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HPIDPKGKFAH();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PAENKFGCGBB(MFJHIEPHMDF EGJHEDOJEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FBEFOMGFHKK AADGFJENKML
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MFJHIEPHMDF LKDNJNFMJCH(Action NGOFEPBCOKF, string AAAAOINJGOG = "", [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, [Optional] Func<bool>? IHHMKHKIBFI, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFJHIEPHMDF ANBODIGELOH(IReadOnlyList<MFJHIEPHMDF> GBGFELNIFAG, [Optional] float? KNDGDNELKFA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MFJHIEPHMDF NABNNJOFIFH(Func<int> NANJMBFHPEE, Action<int> ECJLKKCHFGP, [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, bool DIPMNNHGGPF = false, string AAAAOINJGOG = "Color", [Optional] Func<bool>? IHHMKHKIBFI, bool GKHHFMKBBIA = true, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MFJHIEPHMDF GAJNIAAAHOM(MFJHIEPHMDF EGJHEDOJEBL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EOILIBEFGIE DJPMFKKHNIM(int HNKBNELEHOC, string AAAAOINJGOG, string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] List<MFJHIEPHMDF>? GBGFELNIFAG, [Optional] Func<bool>? IMNHLOKMLDA, bool DMLKPDCENFG = true, [Optional] Func<bool>? LFGLBDKDEOP, [Optional] Action<bool>? NOHAIKGAENH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MFJHIEPHMDF DHADHFFCIMA(string IHLOILEDGMI, [Optional] Func<bool>? IMNHLOKMLDA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MFJHIEPHMDF NLMOAFHKJCF(Func<string> JBIPOCIMLEM, Action<string> AJLENIHKDOA, [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, [Optional] int? GCJLIMCBHDJ, bool NIAJKFEKEMC = false, string AAAAOINJGOG = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] Func<bool>? IHHMKHKIBFI, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MFJHIEPHMDF LNOJOAAEEGA(Func<float> JBIPOCIMLEM, Action<float> AJLENIHKDOA, string AAAAOINJGOG = "", string CJKMAGJHDOJ = "", string IMNFDLMBLPM = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", bool CMKMDFPNLCP = false, float BJNNOEEFBHO = 0f, float EGAGMPJAPPE = 1000f, [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, [Optional] Func<bool>? IHHMKHKIBFI, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MFJHIEPHMDF EHAPHJDEKAF(Func<int> JBIPOCIMLEM, Action<int> AJLENIHKDOA, string AAAAOINJGOG = "", [Optional] Func<string>? MIOPINAPGPN, string CJKMAGJHDOJ = "", [Optional] Func<string>? LKALMOCEBNM, string IMNFDLMBLPM = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", bool CMKMDFPNLCP = false, int BJNNOEEFBHO = 0, int EGAGMPJAPPE = 1000, [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, [Optional] Func<bool>? IHHMKHKIBFI, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MFJHIEPHMDF MCNHDLKHKDO(Type GOCAMACBFDC, IReadOnlyList<object> HIHKIBFEAIM, Func<int> NODDAOHANKE, Action<object> PKFBODMLBBI, string AAAAOINJGOG = "", string CJKMAGJHDOJ = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, [Optional] Func<object, string>? AIMHGGIHECD, bool LEJKELHEPEJ = true, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MFJHIEPHMDF KFJNBCJOHDJ(Func<string> JBIPOCIMLEM, Action<string> AJLENIHKDOA, int JCCJPIDAFGC = 1000, BHHHGADGDOC GBDNKPDINEK = BHHHGADGDOC.Alphanumeric, [Optional] Func<string, bool>? APCGIMNMOGG, [Optional] string? EBGHKGOJDBA, [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, string AAAAOINJGOG = "", string CJKMAGJHDOJ = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", bool NIAJKFEKEMC = false, [Optional] Func<bool>? IHHMKHKIBFI, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MFJHIEPHMDF PJCMEMPNIAC(Func<float> JBIPOCIMLEM, Action<float> AJLENIHKDOA, float BJNNOEEFBHO = 0f, float EGAGMPJAPPE = 1000f, [Optional] Func<bool>? BOEOOAKLNEC, int EEPGJAGKFCE = -1, string AAAAOINJGOG = "", string CJKMAGJHDOJ = "", string IMNFDLMBLPM = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] Func<float, float>? GJONJFDKKPE, [Optional] Func<float, float>? IILMHNAEKID, [Optional] Func<bool>? IHHMKHKIBFI, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MFJHIEPHMDF KOPKJLDCPJP(Func<string> JBIPOCIMLEM, Action<string> AJLENIHKDOA, Action NGOFEPBCOKF, [Optional] Func<bool>? IMNHLOKMLDA, BHHHGADGDOC GBDNKPDINEK = BHHHGADGDOC.Alphanumeric, [Optional] Func<string, bool>? APCGIMNMOGG, HGECBIKFCEN PEBMKCFKCNL = HGECBIKFCEN.Alphanumeric, [Optional] string? EBGHKGOJDBA, [Optional] List<MFJHIEPHMDF>? DPFDICMOABK, string AAAAOINJGOG = "", string EKDIOGCIGAN = "", string GBIMKNGCOHN = "", string JPJHECPFDBN = "", bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MFJHIEPHMDF ONKENFBABPO(Func<string> JBIPOCIMLEM, Action<string> AJLENIHKDOA, [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, [Optional] int? GCJLIMCBHDJ, bool NIAJKFEKEMC = false, string AAAAOINJGOG = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] Func<bool>? IHHMKHKIBFI, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MFJHIEPHMDF DEFFECLHJFB(Func<bool> JBIPOCIMLEM, Action<bool> AJLENIHKDOA, [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, string AAAAOINJGOG = "", string CJKMAGJHDOJ = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] int? HNKBNELEHOC, [Optional] Func<bool>? IHHMKHKIBFI, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KMCJAPGOOKG OEJCGEGAPMO(Dictionary<string, CCCPMPNPNDP> JIHPAFENIMM, Func<int> NANJMBFHPEE, Action<int> ECJLKKCHFGP, string AAAAOINJGOG, string CJKMAGJHDOJ = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] Action? OKGJCDNOFBL, [Optional] Action? IFGLFANCFIM, [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, [Optional] Func<int, string>? KKKNINBPGDM, bool LEJKELHEPEJ = true, bool JFHGBENKOMN = true, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	KMCJAPGOOKG FHFBNPILGMJ(Func<Dictionary<string, CCCPMPNPNDP>> DODNOPFCHOG, Func<int> NANJMBFHPEE, Action<int> ECJLKKCHFGP, string AAAAOINJGOG, string CJKMAGJHDOJ = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, [Optional] Func<bool>? BBOFAKPIGIN, [Optional] Func<int, string>? KKKNINBPGDM, bool LEJKELHEPEJ = true, bool JFHGBENKOMN = true, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	MFJHIEPHMDF AINNHAPGDKO(Func<List<KeyValuePair<string, CCCPMPNPNDP>>> DODNOPFCHOG, Func<int> NANJMBFHPEE, Action<int> ECJLKKCHFGP, string AAAAOINJGOG, string CJKMAGJHDOJ = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, [Optional] Func<bool>? BBOFAKPIGIN, [Optional] Func<int, string>? KKKNINBPGDM, [Optional] Action? OKGJCDNOFBL, [Optional] Action? IFGLFANCFIM, bool LEJKELHEPEJ = true, bool JFHGBENKOMN = true, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	MFJHIEPHMDF KBGDLCGBMJK(Func<List<object>> DODNOPFCHOG, Func<object> NODDAOHANKE, Action<object> PKFBODMLBBI, Func<object, string> AIMHGGIHECD, string AAAAOINJGOG = "", string CJKMAGJHDOJ = "", string EKDIOGCIGAN = "", string BAHLHCADFEH = "", [Optional] Func<bool>? IMNHLOKMLDA, [Optional] Func<bool>? GAHBJEADJDN, bool LEJKELHEPEJ = true, bool LDJDBBPLFAC = true);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	MFJHIEPHMDF GLIKFMGJEKF(string AAAAOINJGOG, Func<object> NODDAOHANKE, Action<object> PKFBODMLBBI, Func<object, string> AIMHGGIHECD, Func<IReadOnlyList<object>> HMKFOBGGCJP, [Optional] Func<bool>? IMNHLOKMLDA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BNKIHKNFECB(MFJHIEPHMDF EGJHEDOJEBL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GIIBENEINAG(string OBDELHIFICF, Action BHOOFJLNACL, bool BJLDNNOHNLF, string CGLLKOBHBFA, Action LBFAPMHEJEM, string JIGBFCEILIK, string GHLBNBHOOGO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MKEHNHMKOIB(string AJENIIGBMEF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MFJHIEPHMDF
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MANCDAHHAEF
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJOBFFAFDLI();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IPGPAEOMNKL
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMKEAOOCKMC();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKBOABFODHD(string INPHBJMLGGC, [In] EIAMGFEEJBF BJLKCDOCMJA);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIANGOCDILD(string JIGBFCEILIK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IMFNGPBLACM(string IHLOILEDGMI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JMGNCFGHONO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ENHCAFJFPED? GOPCOAILBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CEGOHEAOPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool AFDDIIJFELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<ENHCAFJFPED> IAJNADPMJNB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IHFDHMKEEAA<NBEIOMNAHGH, IABAFDHJPAP> DLEACLIDILF([In] NBEIOMNAHGH AJMCIEBICCK, IEnumerable<MEEBAJFNOLB> EJHDEDCBBCG, int MCGBAAEGFEE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ENHCAFJFPED
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct CIGKMMCKGCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly PBAGCDGOAEH OGJILBGNCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly HMKNNOCBHCF DFCBHFPENFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly IEnumerable<MEEBAJFNOLB> JJLHKFKCIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly bool EDHIOIIDMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly GFAOOEEFFDF<OHLKKMMGEAJ> DAMDDOCKOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly int? AAIGGMGCKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly HIJPHOGDNIB? IIJCJIKPEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly HIJPHOGDNIB? ODEJPOEINHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly ELBBDMCMJCB? DIHIALLFDHN;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1C2DEE0", Offset = "0x1C2CCE0", VA = "0x181C2DEE0")]
		public CIGKMMCKGCI(PBAGCDGOAEH BKGBBNIFACI, [In] HMKNNOCBHCF AJMCIEBICCK, IEnumerable<MEEBAJFNOLB> EJHDEDCBBCG, bool APKAALJJFLC, [In] GFAOOEEFFDF<OHLKKMMGEAJ> HFCFJDOGGKD, int? BMPCMGIJHMN, [In] HIJPHOGDNIB? JDMPDGNIFPF, [In] HIJPHOGDNIB? NJLBPCNMGCP, [In] ELBBDMCMJCB? MHCDFDCBEFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct ELBBDMCMJCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly IReadOnlyCollection<ByteString> BFJBJONJLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly IReadOnlyCollection<ByteString> PFJEBCLAHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly IReadOnlyCollection<ByteString> NNPBHBHDIHD;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x18C51C0", Offset = "0x18C3FC0", VA = "0x1818C51C0")]
		public ELBBDMCMJCB(IReadOnlyCollection<ByteString> BPAHKHCNKLJ, IReadOnlyCollection<ByteString> CBDNMNLFOEI, IReadOnlyCollection<ByteString> MOPNIGKIBLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public readonly struct BPPOIEHMACF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly HMKNNOCBHCF DFCBHFPENFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly IReadOnlyDictionary<Guid, Guid> ONFLHJJBOHK;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1C2DDB0", Offset = "0x1C2CBB0", VA = "0x181C2DDB0")]
		public BPPOIEHMACF(HMKNNOCBHCF AJMCIEBICCK, IReadOnlyDictionary<Guid, Guid> BMDOHMBCBAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GLIHNBJPFLK? DBHELMCNNAN([In] GFAOOEEFFDF<OHLKKMMGEAJ> JLBBMGLDMCI);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CKFBFGPKEME? JEPPBDDBBGJ([In] GFAOOEEFFDF<COFJGPIBAKG> HPBOKIMIODG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JENNBMPLKJL> CJLNNMABIGL(bool KLHHKFFONEG, bool DCILCNDGJLB, bool ECNPFOOECJL, bool FCLHFJGDPLF);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IHFDHMKEEAA<BPPOIEHMACF, IABAFDHJPAP> KMGIEJAJGJI([In] CIGKMMCKGCI HGIPKCLMBHH);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HBPFLNJBBKM PEFBGLJBBCM(IEnumerable<MEEBAJFNOLB> EJHDEDCBBCG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HBPFLNJBBKM OFDMHKBCEIL();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HMKNNOCBHCF CLGKNDNJHDG(PBAGCDGOAEH BKGBBNIFACI, IEnumerable<GFAOOEEFFDF<COFJGPIBAKG>> MIJDCCCCJCF, IEnumerable<MEEBAJFNOLB> EJHDEDCBBCG);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ECLNJENKDHC : JOHFAELLJHG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JMGNCFGHONO CCAAIOCKOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BENEMAACKKC : IABAFDHJPAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GLIHNBJPFLK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EFMDEAAHFDF? LJPAKDHGGII
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HGHHFNCILOD : KFFFFOGGFHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JJOPOCFIJLE<BMPEHEOGHCF> FEOOBBOODHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ODCGONDBBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONAEDJBIJGB(MANCDAHHAEF NFFLMIDJILC);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LNHLEOLAIJA(JKKDAPEMKDN PGFDACNCOBC);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string GGMNGMDDMLB(int GFGPAGHIAOJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCKIACNDLEC(HAMIIMOLGFC IHHEKDONMBP);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LCOEONPMCMP(HAMIIMOLGFC IHHEKDONMBP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HAMIIMOLGFC
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CKFBFGPKEME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	object AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	GFAOOEEFFDF<NMPOJINFIAE> PINGFDLHFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FBCMIGIBCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int MKICFNHIEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	EIAMGFEEJBF KLBKCPLOPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string DDLFLODDKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NodeVisualizationKey FPPHOMLMMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JJOPOCFIJLE<ALMIILMJAMK> GKFNDBIGLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IAODGPFFFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DMNLCCGPKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	PMNBFFBCHNB BIDLCHBPPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OONEKAJCHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool JEKDAJLCJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool DLEOFLCFALH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	int AMBBKKFHGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool OLKCLHOFHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string JPODJGFGBNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DIFGINNEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MLCCKNEGOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool FEMCKLKCPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool HABJHGKAIEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool LCJHENBJBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	CALDJAGICJC IINMIFPFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CHHNDLNPPKM KEJKODFGKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	[IMHHKPCFHNB(true, "FloatingText")]
	bool MNLCCLENKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	FBJBCONADBC? ONPNAJFCILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GFAOOEEFFDF<OHLKKMMGEAJ> GEHHCNKONMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[CALCKJNFMHO("This isn't great UX and we should consider removing it.")]
	bool CBMDAMNJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	GFAOOEEFFDF<OHLKKMMGEAJ>? OGFJLINNPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	IEnumerable<GFAOOEEFFDF<COFJGPIBAKG>>? CGIFFHEHLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool GAJLEKJKAGH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool CNOPLDAFGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GFAOOEEFFDF<COFJGPIBAKG> JHAMFEJEHPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	CNLINFNBFDM<KEGKGLLIGNA, BANCDKBDKNF> GNCMNKBKMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	JJOPOCFIJLE<KEGKGLLIGNA>? FOALLKADBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LGNOAHIIHPA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event DOHONPGOOKD EFEMKKDKFEB;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event BPDHJPELGHK LBBDLFDECKP;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action ALGOPMFAKCJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action EBHIAPKCIKA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JJOPOCFIJLE<KEGKGLLIGNA>, BANCDKBDKNF> IHEPOOBPLDF;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<JJOPOCFIJLE<KEGKGLLIGNA>> OBMIBEGNBPP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<JJOPOCFIJLE<KEGKGLLIGNA>, BANCDKBDKNF> BKGDEJPCCOF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<JJOPOCFIJLE<KEGKGLLIGNA>, JJOPOCFIJLE<KEGKGLLIGNA>> DMKCJFNPKGD;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<JJOPOCFIJLE<KEGKGLLIGNA>, BANCDKBDKNF> BPAHNJGFPFD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PDFGAACBHIF(int LLLNHDIGJLF);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool BLGAAIADLPP([In] CALDJAGICJC GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool FHKHLABDHDC([In] CHHNDLNPPKM GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MMNIBMICPDB();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> MDHDOGNKCKA(CALDJAGICJC? ELHIODNHAHA, CHHNDLNPPKM? FIIPDOPILCE);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DDIMLFIADLN();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MBJCPJAJGEI();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool BHPINJEMMCL([Out] Guid GGLMLEJEMJP);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool CLHNHBOFHOK([In] Guid JLBBMGLDMCI);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void AOMGIBAKPFH();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void MBGENFFAMLK(bool MNFKBOHJEEP);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "45")]
	BFLPLNACJIL CCCNIDHNMBF([In] BMOBMBJMPOM GOHLMAIGBMP);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void KJAIGJBBKLF(object LBNNPDDIBPB);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void HLKMFLFILGD(object LBNNPDDIBPB);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void LNHLEOLAIJA(PALLFOJMPAM DGOEFCNDMLB);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "71")]
	HIJPHOGDNIB IOKNDGJGNGD();

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> HHOJMHLMAPN(JJOPOCFIJLE<KEGKGLLIGNA> EHGJLEBHHHD);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface OCICEKLADLB : KFFFFOGGFHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	JJOPOCFIJLE<HEMHNFODANG> GOKILOKIGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface KFFFFOGGFHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	IEnumerable<StaticEdge> OLNFGFDNBOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	DisplayKind OEDKMJPNBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	GFAOOEEFFDF<OHLKKMMGEAJ> GEHHCNKONMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GFAOOEEFFDF<COFJGPIBAKG> JHAMFEJEHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JJOPOCFIJLE<KEGKGLLIGNA> OECALGKLHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JJOPOCFIJLE<BFMMICNPPJG> OBMJFLHJAPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	JBNHMHPFPEB ELGDOBAEGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PortImage ONFJGMLJHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FHEJDKAOLEE(JOMPDGBDMDH IHHEKDONMBP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NGDGLOLLFEI(ANHJHJBFGIC IHHEKDONMBP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MMFDGACADME(IPGPAEOMNKL ONMACPILIKM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GNEGPKBBBOB(JOMPDGBDMDH IHHEKDONMBP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OOCPFILMAJG(ANHJHJBFGIC IHHEKDONMBP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JOMPDGBDMDH
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BANCDKBDKNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate void CHMBOILDLFE(JJOPOCFIJLE<KEGKGLLIGNA> LEDLLMJPAFI, JJOPOCFIJLE<KEGKGLLIGNA> FKDIDOCGBFM);

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool EHFJIOAPMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool IECDBEBDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool PICHGPDBFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	GFAOOEEFFDF<OHLKKMMGEAJ> GEHHCNKONMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool BGNNKEOPEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	CNLINFNBFDM<BMPEHEOGHCF, HGHHFNCILOD> IABBLJKFCFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	GFAOOEEFFDF<COFJGPIBAKG> JHAMFEJEHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	CNLINFNBFDM<HEMHNFODANG, OCICEKLADLB> PGHEEGHCKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JJOPOCFIJLE<KEGKGLLIGNA> OECALGKLHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action NKMPANCGPEO;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JJOPOCFIJLE<BMPEHEOGHCF>, JJOPOCFIJLE<BMPEHEOGHCF>> IHPCBCEMBIA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JJOPOCFIJLE<HEMHNFODANG>, JJOPOCFIJLE<HEMHNFODANG>> BNDAPNDMHBA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<JJOPOCFIJLE<BMPEHEOGHCF>, HGHHFNCILOD> DBOGIIAGHLO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<JJOPOCFIJLE<BMPEHEOGHCF>> CNLOCCAADHF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<JJOPOCFIJLE<BMPEHEOGHCF>, HGHHFNCILOD> KNNIGOGBDBF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<JJOPOCFIJLE<HEMHNFODANG>, OCICEKLADLB> KDGBFEFHPAB;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<JJOPOCFIJLE<HEMHNFODANG>> DMEGAPCPFDI;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<JJOPOCFIJLE<HEMHNFODANG>, OCICEKLADLB> OJAOKPODKOH;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> EGCCCMHKLID();

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> KLGJOMJLLPJ(JJOPOCFIJLE<LKAABMGPPCC> BGBGHHKGLLM);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> OHAAAINJMPJ(JJOPOCFIJLE<EDDBCKBOIEH> DJJNOMMHOAD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> HNMMBOAOKEG(JJOPOCFIJLE<LKAABMGPPCC> BGBGHHKGLLM, JJOPOCFIJLE<LKAABMGPPCC> HGCBGDNEKCJ);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> KFOBLNDOEPC(JJOPOCFIJLE<EDDBCKBOIEH> DJJNOMMHOAD, JJOPOCFIJLE<EDDBCKBOIEH> HGCBGDNEKCJ);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> MLFIDLNJPFM();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> ILEJGKGPKBH(string CAPPJGBHJKJ);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> JEDGHAFGPEK(JJOPOCFIJLE<LKAABMGPPCC> BGBGHHKGLLM, string ONIBECKLJDD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<IHFDHMKEEAA<LIGKMPLCELA, BENEMAACKKC>> HDBBDIHCEKC(JJOPOCFIJLE<EDDBCKBOIEH> DJJNOMMHOAD, string ONIBECKLJDD);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface JENNBMPLKJL
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string NOHLDAAABDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IHFDHMKEEAA<JJOPOCFIJLE<LKAABMGPPCC>, BENEMAACKKC>> GKHOCIIGCIO(GFAOOEEFFDF<OHLKKMMGEAJ> JLBBMGLDMCI, GFAOOEEFFDF<COFJGPIBAKG> HPBOKIMIODG, JJOPOCFIJLE<KEGKGLLIGNA> EHGJLEBHHHD, string ONIBECKLJDD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<IHFDHMKEEAA<JJOPOCFIJLE<EDDBCKBOIEH>, BENEMAACKKC>> PFJNKEJHPAH(GFAOOEEFFDF<OHLKKMMGEAJ> JLBBMGLDMCI, GFAOOEEFFDF<COFJGPIBAKG> HPBOKIMIODG, JJOPOCFIJLE<KEGKGLLIGNA> EHGJLEBHHHD, string ONIBECKLJDD);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface ANHJHJBFGIC
{
	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed([In] JDHNNNMKLEE HINIIBAPOAN);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JBNHMHPFPEB
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OPDHLCEBNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FLCHCAFELEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	TypeKey FPPHOMLMMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool KDJIINDGEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class NMPOJINFIAE
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class OHLKKMMGEAJ
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class MEAKLBOOMML : OFNHFKEKNDA
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class LKAABMGPPCC
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class COFJGPIBAKG
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class GNMDFHEANGG
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CGBPGDLKJPH : OFNHFKEKNDA
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class EDDBCKBOIEH
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public abstract class OFNHFKEKNDA
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CALCKJNFMHO("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class KEGKGLLIGNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class BMPEHEOGHCF : BFMMICNPPJG
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class HEMHNFODANG : BFMMICNPPJG
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class BFMMICNPPJG
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class CKNIPNEKBMN
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class ALMIILMJAMK
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class FINFECCDFJA
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class AEFLCEOJPCM
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct EFMDEAAHFDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GFAOOEEFFDF<COFJGPIBAKG> KAFBNBBEKMO;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DF90", Offset = "0x1C2CD90", VA = "0x181C2DF90")]
	public EFMDEAAHFDF([In] GFAOOEEFFDF<COFJGPIBAKG> KHFIGOOCOKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void LKIEBAGCLBJ([In] JDHNNNMKLEE HINIIBAPOAN);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum PortImage
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		List,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		StateTransition
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public delegate void DOHONPGOOKD([In] CALDJAGICJC IAOBMGELIKG);
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct BFNLPHHBJIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly JENNBMPLKJL NCCIBFKJOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly JENNBMPLKJL FIAEKFGNHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly JENNBMPLKJL GJGLPBHFHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly JENNBMPLKJL AFCJDBAKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly JENNBMPLKJL MCGIDKGEINN;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0xEBF850", Offset = "0xEBE650", VA = "0x180EBF850")]
	public BFNLPHHBJIA(JENNBMPLKJL JELLJLEFIBD, JENNBMPLKJL MIADBGBMAHP, JENNBMPLKJL JEKPBNONPCB, JENNBMPLKJL BGHJPECFOCP, JENNBMPLKJL FAJHPODKGNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public delegate void BPDHJPELGHK([In] CHHNDLNPPKM BIOBPMHCIFO);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly GFAOOEEFFDF<COFJGPIBAKG> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly JJOPOCFIJLE<KEGKGLLIGNA> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly JJOPOCFIJLE<HEMHNFODANG> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly GFAOOEEFFDF<COFJGPIBAKG> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly JJOPOCFIJLE<KEGKGLLIGNA> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly JJOPOCFIJLE<BMPEHEOGHCF> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1C30660", Offset = "0x1C2F460", VA = "0x181C30660")]
		public StaticEdge([In] GFAOOEEFFDF<COFJGPIBAKG> DFLLMIGCALD, JJOPOCFIJLE<KEGKGLLIGNA> BLCPONPJJJP, JJOPOCFIJLE<HEMHNFODANG> DFCGIGDGHCD, [In] GFAOOEEFFDF<COFJGPIBAKG> EPKMNGBLKKF, JJOPOCFIJLE<KEGKGLLIGNA> ODNEBPBGDGC, JJOPOCFIJLE<BMPEHEOGHCF> OPNDHBGPMEO)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1C30100", Offset = "0x1C2EF00", VA = "0x181C30100")]
		public static bool NOLBLOCHCOA([In] StaticEdge HADGDMKFEOD, [In] StaticEdge CJIAEKJDMKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1C2FF20", Offset = "0x1C2ED20", VA = "0x181C2FF20", Slot = "4")]
		public bool Equals(StaticEdge MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1C2FE70", Offset = "0x1C2EC70", VA = "0x181C2FE70", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1C30010", Offset = "0x1C2EE10", VA = "0x181C30010", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1C301F0", Offset = "0x1C2EFF0", VA = "0x181C301F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BLJOPKPNMED
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DC90", Offset = "0x1C2CA90", VA = "0x181C2DC90")]
	public static StaticEdge EFHLMHLMFOG(this LFFMCLDDOBH LNKCIHFCLHG)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct NDPGNCECBCB : IEquatable<NDPGNCECBCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string BHEJALKFKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly int HLPMGILCGDA;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1665CC0", Offset = "0x1664AC0", VA = "0x181665CC0")]
	public NDPGNCECBCB(string KNKKDNJPFFO, int AMLHBMNLBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1C2F930", Offset = "0x1C2E730", VA = "0x181C2F930", Slot = "4")]
	public bool Equals(NDPGNCECBCB MFMJJEFODHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct OOABEECFAHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string KKCKMDALLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly FDNIELKEGCB.OHAHHDLLNHJ.LHMMPJJDIDN HGKOCHPFNFL;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1665CC0", Offset = "0x1664AC0", VA = "0x181665CC0")]
	public OOABEECFAHI(string ONIBECKLJDD, FDNIELKEGCB.OHAHHDLLNHJ.LHMMPJJDIDN FHFJCLAEAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1C2FA00", Offset = "0x1C2E800", VA = "0x181C2FA00")]
	internal static OOABEECFAHI EFHLMHLMFOG(FDNIELKEGCB PFDMLBFKIAP)
	{
		return default(OOABEECFAHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1C2FB00", Offset = "0x1C2E900", VA = "0x181C2FB00")]
	internal FDNIELKEGCB GKMCGBDALGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1C2FB70", Offset = "0x1C2E970", VA = "0x181C2FB70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1C2FA50", Offset = "0x1C2E850", VA = "0x181C2FA50", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1C2F930", Offset = "0x1C2E730", VA = "0x181C2F930")]
	public bool PILEKNKGKOK(OOABEECFAHI MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1C2FBE0", Offset = "0x1C2E9E0", VA = "0x181C2FBE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct HDPNIGAMIPJ : IEquatable<HDPNIGAMIPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly LGGJPEFABPB LKGFGFAOLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string JPLLDDNFOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly IReadOnlyDictionary<GFAOOEEFFDF<AEFLCEOJPCM>, NDPGNCECBCB> KBGGMMEEOLF;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool EHIDAKAHKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E330", Offset = "0x1C2D130", VA = "0x181C2E330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1C2EA20", Offset = "0x1C2D820", VA = "0x181C2EA20")]
	public HDPNIGAMIPJ(LGGJPEFABPB KLLFAGOOJPM, IReadOnlyDictionary<GFAOOEEFFDF<AEFLCEOJPCM>, NDPGNCECBCB> NCHCPHDIMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DFE0", Offset = "0x1C2CDE0", VA = "0x181C2DFE0")]
	public static HDPNIGAMIPJ EFHLMHLMFOG(DNPHFDIIDLM PFDMLBFKIAP)
	{
		return default(HDPNIGAMIPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E880", Offset = "0x1C2D680", VA = "0x181C2E880")]
	public DNPHFDIIDLM GKMCGBDALGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E3B0", Offset = "0x1C2D1B0", VA = "0x181C2E3B0", Slot = "4")]
	public bool Equals(HDPNIGAMIPJ MFMJJEFODHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct LGGJPEFABPB : IEquatable<LGGJPEFABPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string KKCKMDALLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly IReadOnlyList<OOABEECFAHI> IABBLJKFCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly IReadOnlyList<OOABEECFAHI> PGHEEGHCKJN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool EHIDAKAHKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1C2F190", Offset = "0x1C2DF90", VA = "0x181C2F190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x18C51C0", Offset = "0x18C3FC0", VA = "0x1818C51C0")]
	public LGGJPEFABPB(string ONIBECKLJDD, IReadOnlyList<OOABEECFAHI> CACPHCAJGJE, IReadOnlyList<OOABEECFAHI> ICJINMPHMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1C2EEB0", Offset = "0x1C2DCB0", VA = "0x181C2EEB0")]
	public static LGGJPEFABPB EFHLMHLMFOG(ONOHLDACGON PFDMLBFKIAP)
	{
		return default(LGGJPEFABPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1C2F260", Offset = "0x1C2E060", VA = "0x181C2F260")]
	public ONOHLDACGON GKMCGBDALGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1C2F4F0", Offset = "0x1C2E2F0", VA = "0x181C2F4F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1C2ECC0", Offset = "0x1C2DAC0", VA = "0x181C2ECC0")]
	private static int COHIBMMAGNO(IReadOnlyList<OOABEECFAHI> KKKHOBEMBED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1C2F1B0", Offset = "0x1C2DFB0", VA = "0x181C2F1B0", Slot = "4")]
	public bool Equals(LGGJPEFABPB MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1C2F570", Offset = "0x1C2E370", VA = "0x181C2F570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public enum PBAGCDGOAEH
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class ENBICFIAKKD
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA8D0C0", Offset = "0xA8BEC0", VA = "0x180A8D0C0")]
	public static bool HDBJJNJDMCF(this PBAGCDGOAEH GHFGMAKMGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA8D0C0", Offset = "0xA8BEC0", VA = "0x180A8D0C0")]
	public static bool AHNAJIAKGLI(this PBAGCDGOAEH GHFGMAKMGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA8D0C0", Offset = "0xA8BEC0", VA = "0x180A8D0C0")]
	public static bool DPPPBACJFGG(this PBAGCDGOAEH GHFGMAKMGKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public enum EBMKKCAKCJA
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct JDHNNNMKLEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool AHFCCAAJCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly EBMKKCAKCJA PHELEHNBBNM;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1C2ECB0", Offset = "0x1C2DAB0", VA = "0x181C2ECB0")]
	public JDHNNNMKLEE(bool BNCPGHFGADP, EBMKKCAKCJA MJINBABFIMG)
	{
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
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
