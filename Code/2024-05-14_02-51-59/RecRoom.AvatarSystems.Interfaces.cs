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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x62022A0", Offset = "0x6200CA0", VA = "0x1862022A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ACDCIOHCIKD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OFACNJAMAEN MOMHNCEMFCO(bool LBDPCGDFCKK = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OFACNJAMAEN CIDPIFJKJPI(bool LBDPCGDFCKK = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HLJDKLFNOBH JJMOIGBCLHI(OFACNJAMAEN ABDLEBPKDKC, int BCBPFMFEAHC, string? GKDOOPOCBPP, string? OLCNPPPDBHP, KCMDKMFGMIO INLJBNBBCKM, List<PLFJENGLHGM>? CLGDKAPAPJF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AAILGILHJNA(DIEPDBDMEGI CBMEMELEHAE, [Out] OFACNJAMAEN? EHILAAAAAOH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IBEMLIAGJHE(HLJDKLFNOBH FDDHLNNMJOH, [Out] OFACNJAMAEN? EHILAAAAAOH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool COOECCMHGPL(HLJDKLFNOBH FDDHLNNMJOH, [Out] FIBBCEMKLGG? CBMEMELEHAE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GKHMLJOEGEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MLJIIJGFFHE HDFBOBMBIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float PEBJPLPDDJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MLJIIJGFFHE NFOOFAGHPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMACOAGPFPP(JIOOCOJMACC MLJADEFEEPB, bool LPFEOFHGOJN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCBCIDGOJFK();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EKLMEBFLCAB(int KPGHNNAKIJF, float FOIHBOKMFON);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPCEEOKOBJG();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GBPOJGNLPKH(bool EPKGBANDAOF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool COOJMECNLLL();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IKGCJCCFFLI();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PPGIGGOBPGE(bool EPKGBANDAOF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FEEABHECNNA(Transform HHJLJBMAMDD, Vector3 AABFABCMHCJ, Quaternion JCDHEFIFJHH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IGMDLNOEPHG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KMHDPFOFGLH OJDGAICDOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KMHDPFOFGLH AKCAJHPEFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GOJDIMLAHCA IJEAECICPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DGANKBFPJAD BPPPFMGBKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GKHMLJOEGEB IOGCGDLKBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GKHMLJOEGEB DLBMLINBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GameObject PACDKKMGCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AvatarConfiguration FMLCLHPAHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform IPLBHEJNJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform IKAICKFDONF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Vector3 DLCCCBDKCPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float BBBOIINJBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform EPCHJJGGIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEAENCAGNNO(MINOBPJNDBN EABNPCNMFFK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIBDBIOOJAM(INKOKDMKPEE BELGCNKCKBN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMFNICJIJNA();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KGLJCPJBJGM();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGPIHFMJBNC(float LIBHBFDDNDN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BMONKCCKBIB();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NGLOOPGOIHO();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MCNAOEIHDDO();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BOIFMJELJFI(bool FBKCJHAEPBM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FKIHHFOAGGC([Out] Vector3 PAEDNOFBPJJ, [Out] Quaternion KEFCJMIEEDH);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Transform INHJGEOBADH(string CKOCOBJKKJB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Vector3? IJHMECMKACG(string CKOCOBJKKJB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OGDEIDGNOAM(float EEBMKLPLCBN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HandLogicOffsets EGCOIDHKEBO();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	PlatformSpecificPlayerHandOffsets OGLKJFNECDO();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OAFDGKHMAII
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IGMDLNOEPHG OONBGOCJIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform AHCEHMHEBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdatePostIKAnimControllers(float JFNONBMGLIA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NIPKPIDMEKE
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool AILPDJKFIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IGMDLNOEPHG KDEPJEDOMCD(string JJNGIKMDGEL, AvatarSystemConfiguration FJJFOHOHMDC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCHBGGIFBOB(string JJNGIKMDGEL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JIPIHMKGMNC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NPPGCJBCMBB LLOIGBKPLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	BENBKFHMAMC GCBIPPDDJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	GNIEBFPNHCO HMIKEOKNAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GNIEBFPNHCO AFGHFCEACAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FMIFMPDKCJC AEAPCJJOGGG(FaceFeatureType KIDMEJEMJHF);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FMIFMPDKCJC PIMEOHDKFNH(FaceFeatureType KIDMEJEMJHF);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NPPGCJBCMBB CKPGMEGFGEL();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BENBKFHMAMC MHPOKNCLMCH();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DLPMGCADPIG NDGEHNFIENM();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DLPMGCADPIG GPJIBNJMDBK();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DLPMGCADPIG MANKNENBJNA();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DLPMGCADPIG GMFHBFBFICG();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GNIEBFPNHCO KHMAFGDFBCG();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<LMHGPJNKIML> IAEEJLCKKGD(bool FNPBOJELCLJ = false, bool NMFDFAFFAJN = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<LMHGPJNKIML> DHLHIHIBJAC(bool FNPBOJELCLJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task OCCMMMBGHOM(bool DNDAMENNADL, [Optional] CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task FNLMDFLJPDD(HLJDKLFNOBH IOLAPPGGFOM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MAMEICAOAJG
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 GHOGICGHBBN(FaceFeatureType KIDMEJEMJHF, HOOKFBKAAPJ MKFJIMNEHJN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float DJNDKDENJPA(FaceFeatureType KIDMEJEMJHF, HOOKFBKAAPJ MKFJIMNEHJN);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKKJAPACEIB(HOOKFBKAAPJ MKFJIMNEHJN, AvatarConfiguration FJJFOHOHMDC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float LDBADMFCHCO(FaceFeatureType BHLNJGBFGEM, float NMJLMNGCOCB, HOOKFBKAAPJ MKFJIMNEHJN);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float MPLDIKJCENK(FaceFeatureType BHLNJGBFGEM, float NCDCOCIMMBO, HOOKFBKAAPJ MKFJIMNEHJN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 NLHJODOAFKF(FaceFeatureType BHLNJGBFGEM, Vector2 OODCIEHPNID, HOOKFBKAAPJ MKFJIMNEHJN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 HLPFKANNAJM(FaceFeatureType BHLNJGBFGEM, Vector2 GNAHAPKPEBH, Vector2 EGHJPEKMLDK, Vector2 PCNGLECLBDO, HOOKFBKAAPJ MKFJIMNEHJN);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 HPDGICNMBGD(FaceFeatureType BHLNJGBFGEM, Vector2 OODCIEHPNID, Vector2 EGHJPEKMLDK, Vector2 PCNGLECLBDO, HOOKFBKAAPJ MKFJIMNEHJN);
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
