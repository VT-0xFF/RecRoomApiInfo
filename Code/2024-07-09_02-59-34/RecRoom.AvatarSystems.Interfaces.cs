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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x688A250", Offset = "0x6888E50", VA = "0x18688A250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LNJLCHAAKFG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKEEHAKOMGN BBMPAMAOJNJ(bool EOINDNHPGMC = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKEEHAKOMGN IHDFBIGMBGL(bool EOINDNHPGMC = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NEFICIJOBBJ AJGJCJJNKOL(HKEEHAKOMGN JGFKFMMOAJO, int HLLGOLOIKLA, string? LONKACOOPGJ, string? AGFPEFFNOBC, EMCFGHOJEPP NKOJACBBKBN, List<PIGNFJGILAH>? PAJMHKCIEPH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CLBIIPKHIPD(IGAHDNPAOAH BNJPDANCNKG, [Out] HKEEHAKOMGN? KNLCFJMHCLN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DHNJAKFEBKK(NEFICIJOBBJ AKKDGEHPEBN, [Out] HKEEHAKOMGN? KNLCFJMHCLN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PCGOOLEDOIB(NEFICIJOBBJ AKKDGEHPEBN, [Out] GGAPEJLBDID? BNJPDANCNKG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HLHMBDNBENO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MOHACDPOFED DCGNNKOCEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float DKAFPPKJAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MOHACDPOFED OBLBONKOANP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 LLMMOIPCHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Quaternion EPKDDIDCJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEIIFCEAHDM(DIHIDCHNPMP FFBJIDDDHKC, bool NIKNNKAMGHO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNPIDBMHOHA();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLCIKLANBID(int JBAOBDNBIMJ, float LFLAKHPGKGG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NLKLFBJNOEJ();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMNOEDNEDKA(bool NCJAANPMPCE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HHPJGFDPHDN();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MCAGCLLKIIP();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CLHCGEBOPIP(bool NCJAANPMPCE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LDAEGPFMMOO(Transform DELFIACNBGK, Vector3 JBBEFLJOMLO, Quaternion GLCFOEGPNCE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ELLPOHGPOAN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MMAIJBDFGNK DPBAIELKCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MMAIJBDFGNK PGJEIDDKOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JGMGICCJDMN MGBMGPLIKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JEDFGLFPNJF POJEDHDDGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HLHMBDNBENO HOLLEKHPGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HLHMBDNBENO BIIOIPGPAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GameObject OJCNPGOLEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	AvatarConfiguration APKMPNMDHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform HPBBHNMNCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform IALEAABCKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 GLJNBMBAEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float NIHMAEGKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform ALPMLBCFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INFINBPBMPJ(LGINAHDHIGK OANDOCGGCKM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGCCOKHHJDF(PEPAIEEAPFC AHNGLDFAIOE);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EPLDLMAKBEG();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHJBKJKNCLA();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBMOOIBGKBG(float NFFNILPGEOA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BHGCJOKHHBE();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IHBNGKFNGFN();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BENOJCLPMBP();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NJHOPHJLBHD(bool ONMGINNKBMM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MKOPGGFHLGE([Out] Vector3 GAIOFIFECPN, [Out] Quaternion EBDBECBIELL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Transform HPDBCKKMKGH(string DAONFMLPOKK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Vector3? CEPHEIJKKIE(string DAONFMLPOKK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KCBKIGAFEPP(float GBJPEIEGGCN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ALJFMCCIDDC(float OMINLCGMFEM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "22")]
	HandLogicOffsets ODENINHCHFN();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "23")]
	PlatformSpecificPlayerHandOffsets EOIJNODPDBL();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KONGAOEAGDH
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ELLPOHGPOAN DCKHMLHNLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform GFACDNEFOGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdatePostIKAnimControllers(float GFJHAHMFGFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IHBPONKLCFB
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DNFOEDOMFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ELLPOHGPOAN KBIJOCEJEON(string DAEBMLBPNOF, AvatarSystemConfiguration AAPAGCKHJDD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGDFNBFIDIB(string DAEBMLBPNOF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JPLAALBLNCN
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DEIDGKDGHJK JAPKFLEFGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HGHOKGOAIFO DDHABAANGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NMOAOFAHBEC DGCJIAOEIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	NMOAOFAHBEC JGDHKDLEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	APOLGJPCPMJ JPNGNLNNJOO(FaceFeatureType FFEIFKLKPPL);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	APOLGJPCPMJ FHFMJKKECNI(FaceFeatureType FFEIFKLKPPL);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DEIDGKDGHJK IBLMPCBLCFA();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HGHOKGOAIFO OFABPLGMCHI();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HHBFBBPCPOI GBIOKJLKIEK();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HHBFBBPCPOI FJCDOEMDLFL();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HHBFBBPCPOI BFCNCLOPJDH();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HHBFBBPCPOI CJIAADAHEEH();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NMOAOFAHBEC CFBNLNKFHOO();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<HPGPCNLFDMN> AIJFJFKMOEP(bool GDODBHEKALB = false, bool HIOLPFDHDEP = false);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<HPGPCNLFDMN> FNBPBLOGEDH(bool GDODBHEKALB = false);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task ECEJAJMPPPG(bool ADPMJGJNIHJ, [Optional] CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task HJIMACMPBMN(NEFICIJOBBJ GMIOJAGOGBL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CMLDGCDNBOD
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 PKIPOOLJHLK(FaceFeatureType FFEIFKLKPPL, KLACEAHOGOL HDHCJEGBAPK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float APGEBIJJGGH(FaceFeatureType FFEIFKLKPPL, KLACEAHOGOL HDHCJEGBAPK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MJFHPEGEDPK(KLACEAHOGOL HDHCJEGBAPK, AvatarConfiguration AAPAGCKHJDD);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float FNODMODDPBF(FaceFeatureType LKOKPNNCBEM, float MKLJELEIIMG, KLACEAHOGOL HDHCJEGBAPK);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float BIJCOLGABMG(FaceFeatureType LKOKPNNCBEM, float HKIEDDODMMD, KLACEAHOGOL HDHCJEGBAPK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 CBOCIBKLNGO(FaceFeatureType LKOKPNNCBEM, Vector2 ANMNNJMLCOB, KLACEAHOGOL HDHCJEGBAPK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 ILBLLICGDNO(FaceFeatureType LKOKPNNCBEM, Vector2 LLCPDDNFBMB, Vector2 KKGPEMOBMAI, Vector2 JKFBJAMCLHA, KLACEAHOGOL HDHCJEGBAPK);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 IFAAFKLACCC(FaceFeatureType LKOKPNNCBEM, Vector2 ANMNNJMLCOB, Vector2 KKGPEMOBMAI, Vector2 JKFBJAMCLHA, KLACEAHOGOL HDHCJEGBAPK);
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
