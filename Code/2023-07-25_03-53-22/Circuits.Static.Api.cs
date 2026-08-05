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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72CA660", Offset = "0x72C9660", VA = "0x1872CA660")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB40", Offset = "0xA3EB40", VA = "0x180A3FB40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCF9C40", Offset = "0xCF8C40", VA = "0x180CF9C40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LJMDGLOBLBL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed(in NFMFIKFNJIC KBDCHPJMEFP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PHIHHJPDEJD : KENFKNCLLGA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLBOIMHPGF(KENFKNCLLGA IJGDOPEJJDL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPNJFNMKMCA();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNDEJFPIDIA(KENFKNCLLGA IJGDOPEJJDL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MAIGKMLAAMN(in FDGGAFLCIEB KDJHMFNDHML);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class ONMFNJFAIDE
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NIMOLKDAGPC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KEKNEOGGJFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly MLDELLCLPMG HBLILDEFCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly IOHEBCNKGJJ ILOEFMPMAJJ;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA891D0", Offset = "0xA881D0", VA = "0x180A891D0")]
	public KEKNEOGGJFO(MLDELLCLPMG PKGENJJGNHK, IOHEBCNKGJJ ADAPPILCLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KENFKNCLLGA
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AKOJOPAAJFL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FJFGAFNLJOE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface KIBLONLDOMD
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734AF0", Offset = "0x733EF0")]
		Action<FJFGAFNLJOE> JAGMOEBEGPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "1")]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734A30", Offset = "0x733E30")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734B50", Offset = "0x733F50")]
		Action<FJFGAFNLJOE> IJPGFKBGEMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "3")]
			[param: Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734A90", Offset = "0x733E90")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		KENFKNCLLGA CPNIIFIFEHK(Func<byte> GPIBPOBNBFC, Action<byte> PBKHNOHLKID, Func<int> LJIHFMAGNJG, Action<int> CFBJMNNNKDG, [Optional] Func<bool>? CCHINJDJKFD);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void DHAOIEFMPBN();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void EHJCNAKGHHN(KENFKNCLLGA IJGDOPEJJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KIBLONLDOMD OFBFFNBNALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KENFKNCLLGA OPPDAJKBJIH(Action JCGHGMEJPEL, string ADDJFHOCMGG = "", [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, [Optional] Func<bool>? IMEMJJIEIKN, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KENFKNCLLGA OANNPNIOGEB(Func<int> KJFCHEGOGIP, Action<int> MJONFHFFBHE, [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, bool DFBJLNLPLAK = false, string ADDJFHOCMGG = "Color", [Optional] Func<bool>? IMEMJJIEIKN, bool CKOJKFICPCJ = true, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KENFKNCLLGA DNNBFGNDJJB(KENFKNCLLGA IJGDOPEJJDL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PHIHHJPDEJD IFCFBABCLFN(int FGJNCOCMMCF, string ADDJFHOCMGG, string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734610", Offset = "0x733A10")] List<KENFKNCLLGA> DLHPGJHCOIO, [Optional] Func<bool>? CCHINJDJKFD, bool GBGOLLFHAOA = true, [Optional] Func<bool>? BEENJKPBCMA, [Optional] Action<bool>? NKOCBABCHDC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KENFKNCLLGA KILIEJDFMDK(string FNFHAMDAPNA, [Optional] Func<bool>? CCHINJDJKFD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KENFKNCLLGA JEOCNNOMOCN(Func<string> FANOAOOLMAG, Action<string> ANILLJFMKPE, [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, [Optional] int? NFLMCBFIGFI, bool BJFPIFGECPI = false, string ADDJFHOCMGG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional] Func<bool>? IMEMJJIEIKN, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KENFKNCLLGA IFEMAELKEBO(Func<float> FANOAOOLMAG, Action<float> ANILLJFMKPE, string ADDJFHOCMGG = "", string LEMFMLAIEDG = "", string ONBOFFFDMHG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", bool DLIJCFMNPCL = false, float INNGLEGFBCM = 0f, float EANDNNJOGMC = 1000f, [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, [Optional] Func<bool>? IMEMJJIEIKN, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KENFKNCLLGA IDAJEHEJGOC(Func<int> FANOAOOLMAG, Action<int> ANILLJFMKPE, string ADDJFHOCMGG = "", [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734670", Offset = "0x733A70")] Func<string> IDOLOANBOKI, string LEMFMLAIEDG = "", [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7346D0", Offset = "0x733AD0")] Func<string> CPLOGGAMAMP, string ONBOFFFDMHG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", bool DLIJCFMNPCL = false, int INNGLEGFBCM = 0, int EANDNNJOGMC = 1000, [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, [Optional] Func<bool>? IMEMJJIEIKN, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KENFKNCLLGA EEEHEMGIGKN(Type OFOCKLKFJPP, IReadOnlyList<object> KNNKEPDNFLK, Func<int> ABECGENPOEJ, Action<object> EMDFEKHHFMA, string ADDJFHOCMGG = "", string LEMFMLAIEDG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734730", Offset = "0x733B30")] Func<object, string> FPACMABPDOO, bool ACPADGBOOKE = true, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KENFKNCLLGA EPFEEEHIDFI(Func<string> FANOAOOLMAG, Action<string> ANILLJFMKPE, int CABDLHBKLGH = 1000, APOLLLEFEFI CMBONAPPMMM = APOLLLEFEFI.Alphanumeric, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734790", Offset = "0x733B90")] Func<string, bool> HFJBNMCGDCI, [Optional] string? CCJMBOPHDAF, [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, string ADDJFHOCMGG = "", string LEMFMLAIEDG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", bool BJFPIFGECPI = false, [Optional] Func<bool>? IMEMJJIEIKN, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KENFKNCLLGA CPADFLNOFLN(Func<float> FANOAOOLMAG, Action<float> ANILLJFMKPE, float INNGLEGFBCM = 0f, float EANDNNJOGMC = 1000f, [Optional] Func<bool>? OHHKLCOAEFL, int NFNODNHEMHK = -1, string ADDJFHOCMGG = "", string LEMFMLAIEDG = "", string ONBOFFFDMHG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional] Func<float, float>? BCAABDBKIKI, [Optional] Func<float, float>? GHPDJEHMPCM, [Optional] Func<bool>? IMEMJJIEIKN, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KENFKNCLLGA BGFEEPBFAHD(Func<string> FANOAOOLMAG, Action<string> ANILLJFMKPE, Action JCGHGMEJPEL, [Optional] Func<bool>? CCHINJDJKFD, APOLLLEFEFI CMBONAPPMMM = APOLLLEFEFI.Alphanumeric, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7347F0", Offset = "0x733BF0")] Func<string, bool> HFJBNMCGDCI, NEBJFLIBGKI ECKDPFFEMMA = NEBJFLIBGKI.Alphanumeric, [Optional] string? CCJMBOPHDAF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734850", Offset = "0x733C50")] List<KENFKNCLLGA> JADNFNECKHH, string ADDJFHOCMGG = "", string BALOLHKIBCJ = "", string CIFMMLHFKOA = "", string EFHONHKKBKE = "", bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KENFKNCLLGA IGAMDAKCJLO(Func<string> FANOAOOLMAG, Action<string> ANILLJFMKPE, [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, [Optional] int? NFLMCBFIGFI, bool BJFPIFGECPI = false, string ADDJFHOCMGG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional] Func<bool>? IMEMJJIEIKN, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KENFKNCLLGA PNAGIIMFBAF(Func<bool> FANOAOOLMAG, Action<bool> ANILLJFMKPE, [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, string ADDJFHOCMGG = "", string LEMFMLAIEDG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional] int? FGJNCOCMMCF, [Optional] Func<bool>? IMEMJJIEIKN, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IHFOECHDKNL FPNLLMEEANM(Dictionary<string, ENEKLEEHPKH> LPNPMOOMCIB, Func<int> KJFCHEGOGIP, Action<int> MJONFHFFBHE, string ADDJFHOCMGG, string LEMFMLAIEDG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional] Action? NGKABFEPNEG, [Optional] Action? LHAOBCMNADN, [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7348B0", Offset = "0x733CB0")] Func<int, string> DPKBAEPDBBC, bool ACPADGBOOKE = true, bool APOGJNMNKHB = true, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "16")]
	IHFOECHDKNL AHHBGFOFMBF(Func<Dictionary<string, ENEKLEEHPKH>> NJPKJKHELLM, Func<int> KJFCHEGOGIP, Action<int> MJONFHFFBHE, string ADDJFHOCMGG, string LEMFMLAIEDG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, [Optional] Func<bool>? OBAKNHMCJGL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734910", Offset = "0x733D10")] Func<int, string> DPKBAEPDBBC, bool ACPADGBOOKE = true, bool APOGJNMNKHB = true, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "17")]
	KENFKNCLLGA KNLJACDCKLO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734970", Offset = "0x733D70")] Func<List<KeyValuePair<string, ENEKLEEHPKH>>> NJPKJKHELLM, Func<int> KJFCHEGOGIP, Action<int> MJONFHFFBHE, string ADDJFHOCMGG, string LEMFMLAIEDG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, [Optional] Func<bool>? OBAKNHMCJGL, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7349D0", Offset = "0x733DD0")] Func<int, string> DPKBAEPDBBC, [Optional] Action? NGKABFEPNEG, [Optional] Action? LHAOBCMNADN, bool ACPADGBOOKE = true, bool APOGJNMNKHB = true, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KENFKNCLLGA MCMNIJOBGNP(Func<List<object>> NJPKJKHELLM, Func<object> ABECGENPOEJ, Action<object> EMDFEKHHFMA, Func<object, string> FPACMABPDOO, string ADDJFHOCMGG = "", string LEMFMLAIEDG = "", string BALOLHKIBCJ = "", string ECPFCDAIBGH = "", [Optional] Func<bool>? CCHINJDJKFD, [Optional] Func<bool>? FKMIDIEOHLL, bool ACPADGBOOKE = true, bool NPFFPDJEODN = true);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "19")]
	KENFKNCLLGA CFIKOOPLDLO(string ADDJFHOCMGG, Func<object> ABECGENPOEJ, Action<object> EMDFEKHHFMA, Func<object, string> FPACMABPDOO, Func<IReadOnlyList<object>> OHAEAGHHGPM, [Optional] Func<bool>? CCHINJDJKFD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PDNLDDGIEGD(KENFKNCLLGA IJGDOPEJJDL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EFHHGOHGDIO(string HJIPCGFIFJE, Action JBMNNIGNPJO, bool OKHFMHKOIAC, string ONNDPABEKHH, Action BJNGOAOLCDL, string HJJLMCEMDKN, string EOFFACGNFMG);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734BF0", Offset = "0x733FF0")]
		public readonly NODALFOGOFI<AFEANCMMGBK> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734C50", Offset = "0x734050")]
		public readonly KNIEPEGFJMC<ABENJALBIME> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734CB0", Offset = "0x7340B0")]
		public readonly KNIEPEGFJMC<KIBKGDLOJMD> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734D10", Offset = "0x734110")]
		public readonly NODALFOGOFI<AFEANCMMGBK> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734D70", Offset = "0x734170")]
		public readonly KNIEPEGFJMC<ABENJALBIME> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734DD0", Offset = "0x7341D0")]
		public readonly KNIEPEGFJMC<BNJDEMGAJII> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6006280", Offset = "0x6005280", VA = "0x186006280")]
		public StaticEdge([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734E30", Offset = "0x734230")] in NODALFOGOFI<AFEANCMMGBK> FLPNBLDJBAI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734EA0", Offset = "0x7342A0")] KNIEPEGFJMC<ABENJALBIME> ALHGOGMLMCP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734F00", Offset = "0x734300")] KNIEPEGFJMC<KIBKGDLOJMD> NAFKCHAHHPH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734F60", Offset = "0x734360")] in NODALFOGOFI<AFEANCMMGBK> MABCEINHLGN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x734FD0", Offset = "0x7343D0")] KNIEPEGFJMC<ABENJALBIME> PHNLCKALCJD, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735030", Offset = "0x734430")] KNIEPEGFJMC<BNJDEMGAJII> OCHEIOKJONG)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72CA980", Offset = "0x72C9980", VA = "0x1872CA980")]
		public static bool LFCPNLBCIDE(in StaticEdge EEDCFNGAAFO, in StaticEdge OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72CA6F0", Offset = "0x72C96F0", VA = "0x1872CA6F0", Slot = "4")]
		public bool Equals(StaticEdge BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x72CA7E0", Offset = "0x72C97E0", VA = "0x1872CA7E0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x72CA890", Offset = "0x72C9890", VA = "0x1872CA890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72CAA70", Offset = "0x72C9A70", VA = "0x1872CAA70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HOALAIDJCPC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x72CA2F0", Offset = "0x72C92F0", VA = "0x1872CA2F0")]
	public static StaticEdge EILKNJCKJNI(this LAPLPJBGCJM FKGCCPKFEDE)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ILAHFDOLFOI
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGNJCBLHOAI();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HFACOOGMOBL
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JGFLNFNDKFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void NCJNPKCFAOG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735E90", Offset = "0x735290")] KNIEPEGFJMC<ABENJALBIME> LEBBAONJLBL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735EF0", Offset = "0x7352F0")] KNIEPEGFJMC<ABENJALBIME> DHCGIIGPCGA);

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HMLDFHBKFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BENMDMNIIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EKOIABCBPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735990", Offset = "0x734D90")]
	NODALFOGOFI<KENHKAMFBHD> IPHECHHJFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool IJEAOIBJLGM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735A00", Offset = "0x734E00")]
	NIIMLJEIDCA<BNJDEMGAJII, IAFNHCBFHIL> PJDEIHOJGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735A60", Offset = "0x734E60")]
	NODALFOGOFI<AFEANCMMGBK> BKPOAEJBANG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735AD0", Offset = "0x734ED0")]
	NIIMLJEIDCA<KIBKGDLOJMD, MEMGLFJBEEH> HDDLEKLJCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735B30", Offset = "0x734F30")]
	KNIEPEGFJMC<ABENJALBIME> LMJEKEPDPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OPAHHAJBFAJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KNIEPEGFJMC<BNJDEMGAJII>, KNIEPEGFJMC<BNJDEMGAJII>> DDDKNENIONE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<KNIEPEGFJMC<KIBKGDLOJMD>, KNIEPEGFJMC<KIBKGDLOJMD>> MJAFENHBOOG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<KNIEPEGFJMC<BNJDEMGAJII>, IAFNHCBFHIL> HPEDCKFBGFN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<KNIEPEGFJMC<BNJDEMGAJII>> GCJGFLIPCKC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<KNIEPEGFJMC<BNJDEMGAJII>, IAFNHCBFHIL> LAJOEOCPEMC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<KNIEPEGFJMC<KIBKGDLOJMD>, MEMGLFJBEEH> OMBCKBFBEJH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<KNIEPEGFJMC<KIBKGDLOJMD>> AMHFDECDCJL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<KNIEPEGFJMC<KIBKGDLOJMD>, MEMGLFJBEEH> PPDDECLOELB;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> CANJHEPNKMG();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> NDOENNKIOCF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735690", Offset = "0x734A90")] KNIEPEGFJMC<AAMHDNABOJE> MNALEJEEOFH);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> KAJDOANKMMH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7356F0", Offset = "0x734AF0")] KNIEPEGFJMC<HGLJBPOHHCE> EOHFJKHGIHM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> NGDJFHAGGHP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735750", Offset = "0x734B50")] KNIEPEGFJMC<AAMHDNABOJE> MNALEJEEOFH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7357B0", Offset = "0x734BB0")] KNIEPEGFJMC<AAMHDNABOJE> DBCIHEOLGOF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> ICAIGDDEKIF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735810", Offset = "0x734C10")] KNIEPEGFJMC<HGLJBPOHHCE> EOHFJKHGIHM, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735870", Offset = "0x734C70")] KNIEPEGFJMC<HGLJBPOHHCE> DBCIHEOLGOF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> CCLCDHOHNAD();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> IMBADFIJFCA(string JLILMMCAPPL);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> PIDLPHHPMIJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7358D0", Offset = "0x734CD0")] KNIEPEGFJMC<AAMHDNABOJE> MNALEJEEOFH, string OALFIBFPPAC);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> JDDOHIFNHMG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x735930", Offset = "0x734D30")] KNIEPEGFJMC<HGLJBPOHHCE> EOHFJKHGIHM, string OALFIBFPPAC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void FMEHENPJOJG(in NFMFIKFNJIC KBDCHPJMEFP);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IEKPCHLFPFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<StaticEdge> AJKLNDPHLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DisplayKind BAIEGDIIABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736010", Offset = "0x735410")]
	NODALFOGOFI<KENHKAMFBHD> IPHECHHJFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736080", Offset = "0x735480")]
	NODALFOGOFI<AFEANCMMGBK> BKPOAEJBANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7360F0", Offset = "0x7354F0")]
	KNIEPEGFJMC<ABENJALBIME> LMJEKEPDPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736150", Offset = "0x735550")]
	KNIEPEGFJMC<HBBKLLNHPPM> LAIEOMMEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	CHBNKNPLHHM GNELFDEBGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NHKIEOAIKNI(AKOJOPAAJFL HMEDGJPMOLD);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EFMEINPCHDO(LJMDGLOBLBL HMEDGJPMOLD);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OMFBCHFJOGA(GKAPGKIMPAE OHCDCFAOCFE);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JCGJDCMNLFJ(AKOJOPAAJFL HMEDGJPMOLD);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KJMLKOFMFCH(LJMDGLOBLBL HMEDGJPMOLD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MECEPDJLLII
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DPFILEMKJBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly DAGLEIOGDNH DKGJMPALONI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly IReadOnlyDictionary<Guid, Guid> DDKNKONGEIC;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x20DC370", Offset = "0x20DB370", VA = "0x1820DC370")]
		public DPFILEMKJBA(DAGLEIOGDNH GGFFIPFHIKF, IReadOnlyDictionary<Guid, Guid> CJJDOCAGJFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct CIIICNALBAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly IReadOnlyCollection<ByteString> IPBJKICOFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly IReadOnlyCollection<ByteString> OCEMHEHPLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly IReadOnlyCollection<ByteString> HEHJKEPFADC;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x916640", Offset = "0x915640", VA = "0x180916640")]
		public CIIICNALBAP(IReadOnlyCollection<ByteString> JIOLFNLGOPL, IReadOnlyCollection<ByteString> DLGPBMBPGJL, IReadOnlyCollection<ByteString> PHIKCPKECEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct NENHINDIALB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly DAGLEIOGDNH DKGJMPALONI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly IEnumerable<NEMHKEECLGO> GPOFIBAHLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly bool LEAMJBFAAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736320", Offset = "0x735720")]
		public readonly NODALFOGOFI<KENHKAMFBHD> ODIDCEPBMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly int? CDEJMDGKGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly EFNJGHMADBN? MMCDEGCNJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly EFNJGHMADBN? KJACPECAIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly CIIICNALBAP? BPBJLMODEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly NIMOLKDAGPC DGDJLCCLGBM;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72CA5B0", Offset = "0x72C95B0", VA = "0x1872CA5B0")]
		public NENHINDIALB(in DAGLEIOGDNH GGFFIPFHIKF, IEnumerable<NEMHKEECLGO> NEEAIBMMKKA, bool CHIOJNILGCA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736380", Offset = "0x735780")] in NODALFOGOFI<KENHKAMFBHD> DEMEAAODJBP, int? PNFPMNMCLBO, in EFNJGHMADBN? BGLFNMLEMIN, in EFNJGHMADBN? BFCGBNDNFAD, in CIIICNALBAP? GIDOFPDMKFF, NIMOLKDAGPC DNCGPGDJDBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KJOKAFLFFPO? HFEKMPKNDED([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7361B0", Offset = "0x7355B0")] in NODALFOGOFI<KENHKAMFBHD?> CIPOMGPCAOA);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JDIFOMPPIIF? MBEHBFCFCBI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736220", Offset = "0x735620")] in NODALFOGOFI<AFEANCMMGBK?> LILJFFJEADL);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<IJBELCJODPF> CECFNINALCC(bool HCGIEHAAAJB, bool JADIPCHFHGO, bool IOEPEKPEOEM, bool PKNBMLJFLLE);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EEONHCOMEMH<DPFILEMKJBA, FAFNPLJEJLD> CLEHFGEJNEA(in NENHINDIALB CIIMHINGMLG);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KBKFEIFGDJG HIICBGICFPK(IEnumerable<NEMHKEECLGO> NEEAIBMMKKA);

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KBKFEIFGDJG MFOKMNMNGIN();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DAGLEIOGDNH BFOLODJLCBB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736290", Offset = "0x735690")] IEnumerable<NODALFOGOFI<AFEANCMMGBK>> LDOMABCHHML, IEnumerable<NEMHKEECLGO> NEEAIBMMKKA, NIMOLKDAGPC DNCGPGDJDBF = NIMOLKDAGPC.CopyPaste);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IHFOECHDKNL : KENFKNCLLGA
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLJPBJJFGJH();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface CHBNKNPLHHM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool DHLAHOIHKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FHMGCOINJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	TypeKey MJKKBFJJOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool NALAKEEMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class EEOMGKGINAH
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MKNCAOCAFDG
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string DECGBHFEHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int GHENODECFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool CBJMFABDPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KIBKGDLOJMD : HBBKLLNHPPM
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum APOLLLEFEFI
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ABAOGEMOFAA("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class ABENJALBIME
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct HFEHGIKLIKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly EOMDDKFOOGO LAKNPOEJLON;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA2BF10", Offset = "0xA2AF10", VA = "0x180A2BF10")]
	public HFEHGIKLIKN(EOMDDKFOOGO PEJKOJGJBGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum NEBJFLIBGKI
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Digit,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Integer,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Decimal,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Regex,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	CustomValidator
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MEMGLFJBEEH : IEKPCHLFPFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736420", Offset = "0x735820")]
	KNIEPEGFJMC<KIBKGDLOJMD> CGEKFHMCOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BNJDEMGAJII : HBBKLLNHPPM
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class HGLJBPOHHCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface IJBELCJODPF
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string NKAOLODAHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> HDGIKEBPDOB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736480", Offset = "0x735880")] NODALFOGOFI<KENHKAMFBHD> CIPOMGPCAOA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7364E0", Offset = "0x7358E0")] NODALFOGOFI<AFEANCMMGBK> LILJFFJEADL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736540", Offset = "0x735940")] KNIEPEGFJMC<ABENJALBIME> BHJEPBFGCOJ, string OALFIBFPPAC);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> OIOJBLAFHJG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7365A0", Offset = "0x7359A0")] NODALFOGOFI<KENHKAMFBHD> CIPOMGPCAOA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736600", Offset = "0x735A00")] NODALFOGOFI<AFEANCMMGBK> LILJFFJEADL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736660", Offset = "0x735A60")] KNIEPEGFJMC<ABENJALBIME> BHJEPBFGCOJ, string OALFIBFPPAC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HMLDEHFPDOK
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	MECEPDJLLII? HIEJPGCOIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CLMFGCLCHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PGNOAPLGOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<MECEPDJLLII> HBFJMEEJOGO();

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EEONHCOMEMH<KEKNEOGGJFO, FAFNPLJEJLD> EDCAEEMFIFF(in KEKNEOGGJFO GGFFIPFHIKF, IEnumerable<NEMHKEECLGO> NEEAIBMMKKA, int LFNFLIBLAEF);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class KENHKAMFBHD
{
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KJOKAFLFFPO
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	AGAFKOCGBJJ? LNFIJPBEHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JDIFOMPPIIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	object LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool CHPIILDKFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int MKGELMCJLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	FDABEGOCPMK CHIMEBJOOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	NodeVisualizationKey MJKKBFJJOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736BA0", Offset = "0x735FA0")]
	KNIEPEGFJMC<ONMFNJFAIDE> JBHNIKOMFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool OPGCADGMPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OFLGIIMJMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool DNIOGGMBCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool GMBPBMHKGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool AOFBLDAFEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool GMEFNIONLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int ICHHENKOPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool HKCPAGGJPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string PBEPAIKNOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool PJAHIDBEMIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool AFCFMPMFBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool FPAHABJHFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool LLDLCJCLFED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool EDOPDOFNHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	AICFOEHJNOF MHKFHAGBNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	FDGGAFLCIEB PPGNDJFMMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[MMPIJJKIAFB(true, "FloatingText")]
	bool LNHILNMEMPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MKNCAOCAFDG? HKNFMPPIHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NHMHIAONPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736C30", Offset = "0x736030")]
	NODALFOGOFI<KENHKAMFBHD> IPHECHHJFJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[ABAOGEMOFAA("This isn't great UX and we should consider removing it.")]
	bool GJMBMJDKLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736CD0", Offset = "0x7360D0")]
	NODALFOGOFI<KENHKAMFBHD>? IEKBEBFAENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool DKJCJBKPMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736D40", Offset = "0x736140")]
	NODALFOGOFI<AFEANCMMGBK> BKPOAEJBANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736DB0", Offset = "0x7361B0")]
	NIIMLJEIDCA<ABENJALBIME, JGFLNFNDKFF> PAAECKICGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736E10", Offset = "0x736210")]
	KNIEPEGFJMC<ABENJALBIME>? HNEGEKPKLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool JPMJLMNCBLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action DHBADFGEKKJ;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event AOFAAAPFNAJ BEHJPDKIEHD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event MAIGKMLAAMN OPHEDMCPDID;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action PLAFHDGLCHN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action BFHJNPLAKHK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<KNIEPEGFJMC<ABENJALBIME>, JGFLNFNDKFF> HMBKNHHGDDH;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<KNIEPEGFJMC<ABENJALBIME>> JOJKIJCNMCG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<KNIEPEGFJMC<ABENJALBIME>, JGFLNFNDKFF> HHCFGPAIDPI;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<KNIEPEGFJMC<ABENJALBIME>, KNIEPEGFJMC<ABENJALBIME>> KAGDAOJJHDG;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<KNIEPEGFJMC<ABENJALBIME>, JGFLNFNDKFF> OAFGJPJNJCB;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEFOBJIBEBM(int IEEOINCHAHK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PMGOPHBLPKK(in AICFOEHJNOF CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NDEIAIEFPAK(in FDGGAFLCIEB CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MMPMENIHDAD();

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void INHBHHNONNO();

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BAFOEACLIIL();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void FNFEBICNKMK(string OALFIBFPPAC);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void FMLOPIMDGDL(int CCELBNKPBGB);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "40")]
	EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF> OEKBKGLBMIE(string JLILMMCAPPL);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool JLCINMMKJBI(out Guid DEMBPJHNCPE);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool BGFGAKLDMGC(in Guid CIPOMGPCAOA);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void NJJHHEGPENJ();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void DFNHDJJFENP(bool GJHMFJDFMJN);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void PBALMIJELOG(FJFGAFNLJOE AJCMGEHLJLM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "67")]
	EFNJGHMADBN PMLDDEGKJEG();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "68")]
	bool POACCEMNBAC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736A80", Offset = "0x735E80")] KNIEPEGFJMC<ABENJALBIME> BHJEPBFGCOJ);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "69")]
	Task<EEONHCOMEMH<MPPFCKMNLHP, BINCKAOMJCF>> CNAJBHNNFOI(string JLILMMCAPPL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void GNEMMHEKBFP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736AE0", Offset = "0x735EE0")] KNIEPEGFJMC<ABENJALBIME> CCELBNKPBGB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x736B40", Offset = "0x735F40")] KNIEPEGFJMC<ABENJALBIME> FBOMMBLFPCD);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public abstract class HBBKLLNHPPM
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KBKFEIFGDJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly KEKNEOGGJFO LEHIKMCFIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly HFEHGIKLIKN DOALONLMAJN;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x72CA450", Offset = "0x72C9450", VA = "0x1872CA450")]
	public KBKFEIFGDJG(in KEKNEOGGJFO CAPINCBBCIM, HFEHGIKLIKN PLNEIMJEEFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class BFGJKAJPCFK
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		String,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Color
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface IAFNHCBFHIL : IEKPCHLFPFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737050", Offset = "0x736450")]
	KNIEPEGFJMC<BNJDEMGAJII> CMDMDMEAHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool HCOAFPHLFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGBHLOKAKIL(ILAHFDOLFOI CFNFNBEEOMN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PBALMIJELOG(IIEFAHFHFIB KJAJAELLHDO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string DBDNPJBEGED(int HMFMJIGINKG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LCELMPKJOGI(HFACOOGMOBL HMEDGJPMOLD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MOLINPAKBKF(HFACOOGMOBL HMEDGJPMOLD);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GKAPGKIMPAE
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFPJMBFLMFP();

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FELDAHHCHBL(string AFHNMAGNDMK, in FDABEGOCPMK IFAEOGGHLKI);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPLALANLEKP(string HJJLMCEMDKN);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPPLOEPNMHM(string FNFHAMDAPNA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class AAMHDNABOJE
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct NFMFIKFNJIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool IMAKDEJLHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly KBFLNILOJFM OMGBHAENKHD;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x12EB710", Offset = "0x12EA710", VA = "0x1812EB710")]
	public NFMFIKFNJIC(bool NDMOFIMCDKD, KBFLNILOJFM IEHDDOBPHAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class AFEANCMMGBK
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public delegate void AOFAAAPFNAJ(in AICFOEHJNOF NHLFKICLGLO);
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct DAGLEIOGDNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly FFKEIKEAAEM NFMHCOCBCNE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0xA2BF10", Offset = "0xA2AF10", VA = "0x180A2BF10")]
	public DAGLEIOGDNH(FFKEIKEAAEM LKFINPICJAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BINCKAOMJCF : FAFNPLJEJLD
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IIEFAHFHFIB
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCMAECKOAOJ(string ADDJFHOCMGG, Func<string> FANOAOOLMAG, Action<string> ANILLJFMKPE, Func<bool> CCHINJDJKFD);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJOPBKAMKNJ(string ADDJFHOCMGG, Action JCGHGMEJPEL, Func<bool> CCHINJDJKFD);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAFEFFLMLPL(string ADDJFHOCMGG, Func<int> KJFCHEGOGIP, Action<int> MJONFHFFBHE, Func<bool> CCHINJDJKFD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHMEEMNHGJH(string ADDJFHOCMGG, Func<int> FANOAOOLMAG, Action<int> ANILLJFMKPE, Func<bool> CCHINJDJKFD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DGCPPKGKKKM(string ADDJFHOCMGG, Func<int> ABECGENPOEJ, Action<object> EMDFEKHHFMA, Func<object, string> FPACMABPDOO, Func<bool> CCHINJDJKFD, Type OFOCKLKFJPP, IReadOnlyList<object> KNNKEPDNFLK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KKBNEHFDEEC(string ADDJFHOCMGG, Func<string> FANOAOOLMAG, Action<string> ANILLJFMKPE, Func<bool> CCHINJDJKFD);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INDJOPILDBM(string ADDJFHOCMGG, Func<bool> FANOAOOLMAG, Action<bool> ANILLJFMKPE, Func<bool> CCHINJDJKFD);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum KBFLNILOJFM
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MHFMBCMOIHK
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ANBGFFNKHMO : PCBHEGKADAG
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	HMLDEHFPDOK KLCPKBFDFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct AGAFKOCGBJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7370F0", Offset = "0x7364F0")]
	public readonly NODALFOGOFI<AFEANCMMGBK> NEBJGMKEJFH;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0xBE2EF0", Offset = "0xBE1EF0", VA = "0x180BE2EF0")]
	public AGAFKOCGBJJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x737150", Offset = "0x736550")] in NODALFOGOFI<AFEANCMMGBK> JECNBOAKJFO)
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
