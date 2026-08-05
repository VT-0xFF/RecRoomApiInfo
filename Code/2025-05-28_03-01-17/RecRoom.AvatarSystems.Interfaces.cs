using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C35CE0", Offset = "0x7C34AE0", VA = "0x187C35CE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MGCFNIMNJAL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PALPOLFGBAG BLKACEODPHC(JBJPAOBCEOK EKOJNMDAFEL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PALPOLFGBAG GLCEEIBDJNA(JBJPAOBCEOK EKOJNMDAFEL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BFNIAFOELEN OMHCADNEOAE(PALPOLFGBAG FFEMKICJPKP, int DNPDDCMEHGG, string? IHGFMOMOADA, string? OPJEMGBEBPP, LBKDEAGGCAC FIFIPCHEABN, List<JLMAAIOIKHE>? DBBCKHLDOFC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KFFHIKPIICE(PMILHMJJIGB JKLFKHGACIE, [Out] PALPOLFGBAG? IHBJMAABOGM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DNIGMELMMLN(BFNIAFOELEN IADPNJOJEPD, [Out] PALPOLFGBAG? IHBJMAABOGM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IOHJPKBBMDP(BFNIAFOELEN IADPNJOJEPD, [Out] JKOFBLLOAJM? JKLFKHGACIE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EHGJPIFCOHC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LLEAAEBCCKF MLGDNIBNPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LLEAAEBCCKF CKMOOIJMPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PDKDHDCEIHG DIIAMAHOODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IGHDDCGAHHH JJKJIGFHEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OCOBFHIIAOB HCLOIMANNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PPBDPCLLEJH AONEOOBHNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PPBDPCLLEJH OIOPJCLOHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string HLFNKPBADEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GameObject MMMAEDGEACA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AvatarConfiguration AMKHKKEKGHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JBJPAOBCEOK POBDILOHIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HeadLogicOffsets HMAIOBLLMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform BIKNMBCKCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform GGIODPJHIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform FBNPICBFEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform BMJGMLNHPML
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 ODLAILNLOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float GLEBFPCCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform EHAKEFDGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform KLEHPJOMDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Transform IOFGGAJDGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform JILFPINJPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJKOOBOOLBG(string GKKCIMNLBNN, JLADPHJBMNG EGOGPDKHPBA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPLADDPPIOO(PDKDHDCEIHG LFOLKPONNCO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOELIJFGDPF();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBECKDHMKJK();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLBPAABKCEM();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GPLNBAGIMOB(float MAKNDMFAFAL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BJAHIBJICMJ();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FPOAGPJJHLN();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ELDNMOOOPEE();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JNABOGNDMOC(bool KGAKOCEBOEK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NAAECMHFHHD([Out] Vector3 FMJBNJMBPIC, [Out] Quaternion EGLCCJEOOAE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Transform HANFPGNPCKD(string CEPIIIDDDLH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3? HOMNHBKOAHM(string CEPIIIDDDLH);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LMABNOMOBDF(float OGPGODMGPOC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void ODECLOFNHMI(float LJEDFFKLNGA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IGNEJIPJOKF(bool CMBECGIJLEJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "27")]
	HandLogicOffsets JEOOFEFNEKP();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PlatformSpecificPlayerHandOffsets JCADPAPLHJM();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "37")]
	NPLHNMCAPBN PGBLGNIKLIA();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JMAKHBHIDPO
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	EHGJPIFCOHC MHKBPCNLLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Transform HNEEAFIEIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EHGJPIFCOHC CreateAvatarSystem(string GKKCIMNLBNN);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UpdatePostIKAnimControllers(float GNNOPFAGLOD);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GPIGIDOHDKN
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHGJPIFCOHC IPPNDIAPCGK(string JPKIEEFALPG, AvatarSystemConfiguration CPNLIEEKIKN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPLGDDHGLBD(string JPKIEEFALPG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string KHHNFDGLHJK(string COAJAPGALMC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PMHBGCDIHII
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	AvatarConfiguration ACKHLLCDHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	CBAHPMHAMOB MKLPPJHPEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DLCELNHJJPH KCBOKDBDBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	OKFOPPGKGEK FFMOHKCMFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	OKFOPPGKGEK HJKJPJHJLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ACMJCOIHLAN AOBHAAJFBCI(FaceFeatureType GNCGGJIBPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ACMJCOIHLAN IHFHKBKDJIK(FaceFeatureType GNCGGJIBPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AvatarBodyShapeData.CAPOGDIJEHA DJLFBDAABNN(DLCELNHJJPH ICENAFKNHKO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AvatarFaceShapeData.NHODMBGPCDK PFPEHJCBKKC(CBAHPMHAMOB EPCDPFKCCIK);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GEMMNCOLLPK EAHCFNGDCOE(ACMJCOIHLAN PMFJBCODHPP);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CBAHPMHAMOB JLMOPMKCFKK();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DLCELNHJJPH DGPLIHFPFAL();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NJLPOIFALEJ GGBHMKIJNAH();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NJLPOIFALEJ LHAKIJCHGBO();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NJLPOIFALEJ NLOMHDANFAB();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NJLPOIFALEJ HPNOCKPDMPE();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OKFOPPGKGEK PPNKFMGHNFD();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	List<PGKLGCKGPFC> CNJNLHJNECL(AvatarItemBodyType EJCCGGFDKNA, bool PPBFEDOHFKL = false);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "18")]
	List<PGKLGCKGPFC> FMHGIHDEILC(AvatarItemBodyType EJCCGGFDKNA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task HBJFPKFFOCI(bool HNLHOAOGIEE, [Optional] CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task DKMGLFPFBOI();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task JDOJDCIHICL(bool HNLHOAOGIEE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task OPMNBPJDKJK(BFNIAFOELEN EAGCCPCCAEL);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task OPMNBPJDKJK(IEnumerable<DNPOKPBKAFM> KLHJJPHJJDB);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task OPMNBPJDKJK(List<BADAFKCAGKI> DBBCKHLDOFC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task OPMNBPJDKJK(IReadOnlyList<PAJCNFAEALM> NBINCMHNOOC);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool HMIEEKLFLHB(BADAFKCAGKI NFKPLLMBIOK);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LPFKJNGDFJC(IReadOnlyList<BADAFKCAGKI> DBBCKHLDOFC);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<OLKDAMFMFBC> LPMJPGCGGCH(MOKDLLFJIKJ HGELOFJPHBB, bool DOBKPBPDACL = false);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool PLHALKECBAM(PAJCNFAEALM HKJHOBKHAKF, [Out] string OCGFKGDCJDN);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KBBCGICKKCL(IEnumerable<DNPOKPBKAFM> KLHJJPHJJDB);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	OutfitType BHLIBNMICPM(PAJCNFAEALM HHHFHHLBBIL);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	NOPCKFPFFFL MBJEPAKIEIA(PAJCNFAEALM HHHFHHLBBIL);
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
