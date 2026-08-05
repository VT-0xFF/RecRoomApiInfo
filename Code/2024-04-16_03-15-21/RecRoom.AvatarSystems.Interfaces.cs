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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6013C30", Offset = "0x6012E30", VA = "0x186013C30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KLPDOPKPHKI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	COCGFAABOCL EMMKGGEFHKO(bool JAAFIEKCIBD = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	COCGFAABOCL ANJKMCLPOBA(bool JAAFIEKCIBD = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DIAHKBOPENA EDFAPBOABIH(COCGFAABOCL MJGHOBDIDHD, int JAHEMDLBNNH, string? MPENHPFDCDK, string? OOJIPCFEOEI, OIILNFAJHOF DPHCJMIHJPA, List<GGJGHOJGBDF>? CCEGFNPMINL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLMLMLNJEDB(BHONFEMDFPM MPFJIKIGBLJ, [Out] COCGFAABOCL? KGHNHOEHCKK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HIOJCMCLNCN(DIAHKBOPENA BBKENDFLMFJ, [Out] COCGFAABOCL? KGHNHOEHCKK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OBJJBMGLLPA(DIAHKBOPENA BBKENDFLMFJ, [Out] IKJNEDKDEAI? MPFJIKIGBLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NJIDIBONBOI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DKKCJDCNCOL ILHCHPKKHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float LHJJOPCPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DKKCJDCNCOL CKGJKJPABCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLOAFNAPFBI(IDMAOGIEMDD GAEMKAANAID, bool IKGCBKDCEAJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNBKGJGGCMO();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KICDPMKDFOI(int NDCJPBDNIEJ, float NKEILBODOPC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMCGHIHKHLD();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IFMBPHCDIAB(bool CCMFFLCDHGJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EDGCNHMLDLB();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PPHIDHLLOCA();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CFMBCPCNGJB(bool CCMFFLCDHGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EFMFEGLEECB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DPAIEAIPOBP IPKJJLIEHAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DPAIEAIPOBP GLKEOGMFEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NPFDDHCGFMC PFACNMAHAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ICINPJGBCED AHHELLCKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	NJIDIBONBOI KLECPPGLCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NJIDIBONBOI PEKIONMMAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GameObject CHIOFKOKCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AvatarConfiguration OFPBEIMJBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform IFLNMGHIKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform FEKGAHFEOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform LHKOIDDGAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBHCILFHOMP(MFGGFOFOHEO ACEALKICFPA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFBJPHIGJHH(CHBALIPKHIK KOODNDJJFGP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ODLPHKIECGG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INIHEAIPEML(float BBFEENEAMBD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGGANGKMECE();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GIJAMKLAIJN();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMFGDDDBCJF();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OENNIIDGNAL(bool HOKGLCHOMJM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BMJLPNCNALO([Out] Vector3 MDHNNFCBLGK, [Out] Quaternion JGKHMBOABAE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Transform EGDEINKMFFB(string OLOFMGICJII);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3? IPNDCFGMLJH(string OLOFMGICJII);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MEOILFDLPFL(float IKIDPDHLLGG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	HandLogicOffsets EKMAPMGNMME();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	PlatformSpecificPlayerHandOffsets BJCANBFMMHD();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BCBKMFCPNND
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	EFMFEGLEECB FMNOFIDGJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform OIPIBFGMDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdatePostIKAnimControllers(float PJADGMHMMIA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LEJMMEPMPBM
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KJBAGDGNIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EFMFEGLEECB ICOPBENHKCN(string IEJEBCICBCB, AvatarSystemConfiguration DLHOBAFFKOB);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MABIBLPIJLE(string IEJEBCICBCB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NDKCHNAFIBD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DGCLIPNNKEP EIOKEAGPIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MIEIJBMPPGI LFANIFLAIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KFBDCNHKDOH PDHLPHGAOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KFBDCNHKDOH ABKGMBPHDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NFAAHILECNI OIPCFGCJHMH(FaceFeatureType IBKCBKMLPGC);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NFAAHILECNI GMAMAJNCDGK(FaceFeatureType IBKCBKMLPGC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DGCLIPNNKEP LFNIDBKJOEE();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MIEIJBMPPGI GDECAEHCHBC();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MHLCCJMBBJE EOBNPEGKBBF();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MHLCCJMBBJE OGJBDHNDGDE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MHLCCJMBBJE CFKCLBBEBKJ();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MHLCCJMBBJE HEBIPLNCHEE();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KFBDCNHKDOH NDLEOGFHJJJ();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<ILIHPJMAOHB> NAJOMPOJHNA(bool MPCEOFKBGIK = false);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<ILIHPJMAOHB> NIMENCPAJPC(bool MPCEOFKBGIK = false);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task HGGLHHJPGCM(bool GLEGGMPOIDH, [Optional] CancellationToken IOOGCHJMBIE);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task JFBBNIBJOOD(DIAHKBOPENA BILOOHPNOIB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MLDLNFLHFKF
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 GDPPBCFOEAH(FaceFeatureType IBKCBKMLPGC, JHFENCGDOHE DPKJBPAKEGH);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float LHIBIEDKFBO(FaceFeatureType IBKCBKMLPGC, JHFENCGDOHE DPKJBPAKEGH);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EAJEPKIDLDF(JHFENCGDOHE DPKJBPAKEGH, AvatarConfiguration DLHOBAFFKOB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float GNAGOKCMOCD(FaceFeatureType NNBAMFNODIO, float JCBFEOMEHBH, JHFENCGDOHE DPKJBPAKEGH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float OGLBDCIJPBI(FaceFeatureType NNBAMFNODIO, float LJGLFNCFCMC, JHFENCGDOHE DPKJBPAKEGH);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 CIOCDCHNCAE(FaceFeatureType NNBAMFNODIO, Vector2 NPEMMJBHJLH, JHFENCGDOHE DPKJBPAKEGH);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 MDFBNBIHHKO(FaceFeatureType NNBAMFNODIO, Vector2 JEAFKJOCOEE, Vector2 GAMAFPKKFAP, Vector2 MCIFMCBEGOD, JHFENCGDOHE DPKJBPAKEGH);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 GLLAIJHPNMB(FaceFeatureType NNBAMFNODIO, Vector2 NPEMMJBHJLH, Vector2 GAMAFPKKFAP, Vector2 MCIFMCBEGOD, JHFENCGDOHE DPKJBPAKEGH);
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
