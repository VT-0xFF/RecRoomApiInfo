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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x60E01A0", Offset = "0x60DEFA0", VA = "0x1860E01A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HJMLIIMGDID
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJLOHKODJBP HMOPPGPAIEB(bool GEGMFOKPDDO = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IJLOHKODJBP LJJKKNCPFFF(bool GEGMFOKPDDO = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGEGDHMEOJO OMLNLAKLCPI(IJLOHKODJBP LHODDAGAJKC, int GCKLCCFNEOF, string? PHEKPMAPPHM, string? PPEHFDGOFKN, MJJNFOHHDCK JHNDDENOMJD, List<ECEIAOLOCKM>? LEBCOGMGIOB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EMJLFDICDLO(GFCECLODFCP NALFNLGOMBO, [Out] IJLOHKODJBP? ENCLAEMGMOK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AGBJGMCDEOI(FGEGDHMEOJO HFFLLIHEOCG, [Out] IJLOHKODJBP? ENCLAEMGMOK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OGDJHCMFBEN(FGEGDHMEOJO HFFLLIHEOCG, [Out] PIDGFKNCBKI? NALFNLGOMBO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LCJDDELCFDD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OLDFGPPKNAJ KNPOAGCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float FFPGKFOGOPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OLDFGPPKNAJ IJOJKDJGBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPNPEFNBFFJ(OLHELEJCABF DEPIDMABJHK, bool PKGLPIFLEIB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PPCJBOGJBKO();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJOHIFODOMF(int HKGEODFGOGC, float OMGEAJNKGEE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BMNBBNDDHGG();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NODLMIIFKEK(bool AIBEMFNIBFC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MKFLLABHKGJ();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EPDLIJMAMLN();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NNIPFPCDKMG(bool AIBEMFNIBFC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FHPJOLOBJGI(Transform OGCHMLDLLMJ, Vector3 BCJHDAAHOBJ, Quaternion FMIIAKNBPBH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JOHGCDOBMBI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BFNGIAHHPKE MGNFKJAGPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BFNGIAHHPKE BGDHBHJHFKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	EPNBCNMGLDK DHCENJGGKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MAPDIKIMPAN EHDOHGHHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LCJDDELCFDD ANMOICIFEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LCJDDELCFDD OAOKLGEHDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GameObject EBIGFKEAJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AvatarConfiguration PPPBHIOPKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform PDKGHDNBHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform KIDFHDFNDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Vector3 LBFGODPCIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float HLCFELBIJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform GKIHNOHMJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOCAGEDMPIC(KPJCGEGCCBE EKMCKBFMIKN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBLLAIBMCCA(OOJIHOHDEFL KDJOHIDKNFG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFIOFNLENHH();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DEIKOBOKGOD();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BECEFNCIAMA(float JMKIGDJHFGL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCMFGKAJNCK();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PIGGOBCCFLA();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MLFDHHPFBOF();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CDEODGNDIGB(bool FNMAIPHMMJP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NGOBMFFIKLK([Out] Vector3 LGEGLPMLHDE, [Out] Quaternion MMAKOFCCDJA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Transform BHHCEMIIPPN(string GNBBHFKFKMF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Vector3? BEDKOCGBECP(string GNBBHFKFKMF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JOBDNJBKAIJ(float OHPDFFBHKIP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HandLogicOffsets CPKEHJEEHCA();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	PlatformSpecificPlayerHandOffsets HLBOCKFLPLA();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CEFEBKMFEBH
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	JOHGCDOBMBI BKPBBKCEPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform ICGDMMPBBHM
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
	void UpdatePostIKAnimControllers(float KAFHCFGLIGM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FHFMNFEJJMK
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool KCIGMCHJGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JOHGCDOBMBI MCAHDFIKJOD(string GJMLAHKFDLE, AvatarSystemConfiguration IBPFJAOGNJF);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLMPADEMFFB(string GJMLAHKFDLE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NOACLOCNEBB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LJOCEFIPDEA ALMOJIIIMAH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JDOGLLHFBNN MPAAILFDEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KMLPMOPGMKE AHAKHKMJDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KMLPMOPGMKE NFOCCKBFEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BEPKGBHJAIF EIDIICKMMJK(FaceFeatureType COBKEODNNJE);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BEPKGBHJAIF GBBFHMLMPGE(FaceFeatureType COBKEODNNJE);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LJOCEFIPDEA CGLONDENKBK();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JDOGLLHFBNN NDMFPDFACPC();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CKKKBFEOKEM CJLOIHBPJMI();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CKKKBFEOKEM FCJFHDDHMGN();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CKKKBFEOKEM ILFBBILPBDB();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CKKKBFEOKEM EDAOPLJINIP();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "12")]
	KMLPMOPGMKE DAAAEFAAPMC();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<LCBHLOHHMDF> DFPGGLDPBCF(bool LCGNEONAGDC = false, bool HFDHJGEOIPM = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<LCBHLOHHMDF> DAIJONEHDGI(bool LCGNEONAGDC = false);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task JGAHLKKJJHC(bool AIGKPDHMPHA, [Optional] CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task LMILPCHCNBM(FGEGDHMEOJO DKHHEKEGHGD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LFNJALOCJNI
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 LGIKLPJFLEL(FaceFeatureType COBKEODNNJE, HLGLPBEKDBI NEAHLFDNODJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float BOPCEGHIJKM(FaceFeatureType COBKEODNNJE, HLGLPBEKDBI NEAHLFDNODJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMIOAJMDBDL(HLGLPBEKDBI NEAHLFDNODJ, AvatarConfiguration IBPFJAOGNJF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float MIKFCLINCMG(FaceFeatureType GEMNHOACOIN, float BLDOJKAMOBN, HLGLPBEKDBI NEAHLFDNODJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float MMILOMFOAGG(FaceFeatureType GEMNHOACOIN, float CFCGJCBCDJI, HLGLPBEKDBI NEAHLFDNODJ);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 HCHLLOKOFDP(FaceFeatureType GEMNHOACOIN, Vector2 OBEMCGEALAJ, HLGLPBEKDBI NEAHLFDNODJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 NMEHNGCDFEO(FaceFeatureType GEMNHOACOIN, Vector2 CCKECCPNKPN, Vector2 HPEGEJEDLOF, Vector2 PKPHOMMBMHC, HLGLPBEKDBI NEAHLFDNODJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 HIDPKLKLBOI(FaceFeatureType GEMNHOACOIN, Vector2 OBEMCGEALAJ, Vector2 HPEGEJEDLOF, Vector2 PKPHOMMBMHC, HLGLPBEKDBI NEAHLFDNODJ);
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
