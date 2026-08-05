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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678D4A0", Offset = "0x678C0A0", VA = "0x18678D4A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FAAFCMNNOIM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHKINBELDHE HIOLDMLBEOC(bool LNAONEPEPIG = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KHKINBELDHE HJPDHDHGNCL(bool LNAONEPEPIG = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LAMBMCGFGPC GJMNHBPIMOF(KHKINBELDHE IMCLGJBJJKP, int MBCOCMLNCKC, string? GFLNGGKHEOH, string? ADFEIFMKMOO, KKMJODEAJKG NGGLNLGICPK, List<DJGPLGBNDEL>? AIKHGIAMAMP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AFDHBEFEMKP(JPCLLNBNEEM AHMPPPKJMKO, [Out] KHKINBELDHE? NEELLKGBEDH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AHHJBNDONPC(LAMBMCGFGPC KOHFLCKFGPJ, [Out] KHKINBELDHE? NEELLKGBEDH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CCOPAJDHIPE(LAMBMCGFGPC KOHFLCKFGPJ, [Out] HHEBJPOEEJJ? AHMPPPKJMKO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JNNDDPMPGOI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LLEOMDDHGBI CCPPDLDKFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float MBEFEJHFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LLEOMDDHGBI DLJNFMNJKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FAMBFNMOBJB(HCCLLALHLCD GJEHPOMDLIP, bool FDMPLBLFINE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGOKOFJIDDF();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OAGPDOCODJF(int DFOONGDPCGA, float EJHNCKBGMON);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHAJBAGENME();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MKOCJHMPLIM(bool MOAICLIJDKD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OFPHJGKOCBF();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HHKFPOCANEH();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CABBGJILBDH(bool MOAICLIJDKD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HMBDGDJPNGO(Transform GPMGJNAOOEP, Vector3 JJIFNHGBJHM, Quaternion OJOBOFCMDFI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JOODJDONNFI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DEHOLECDIJP PJEBPILBMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DEHOLECDIJP KOCAMCDMBBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KGCFGBIOMLM ECDLDCNPKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OGDFMPCHDJF BFBJAOBOOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JNNDDPMPGOI NDPPECHGBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JNNDDPMPGOI OBLPJEJNGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GameObject OLFFLDPKCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AvatarConfiguration LJLMIEPKHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform MOHHBBAHOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform OEGLCIGICBH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Vector3 GHHHCGEIMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float EJOIOKEPMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform GPPPEKJIILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGNJENKFAAI(ANDALEBLIHI BMIMICLNABN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDOBOCIEIKG(AGBFGICDBPI HFGNELEKBHG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMPNOPHMODH();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DENONPNJFIK();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKGJEKEPGKJ(float PLPEBHOMICD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGCGCHEDING();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LALDJECNCKB();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IBFFJMLEMEK();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FNAGNHOPPNO(bool GNJGNFHMCAC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MHMAIAJALCK([Out] Vector3 CCNDJKMHMEB, [Out] Quaternion GAAMKNOKECA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Transform LMMHPMOFBBE(string LFLHDCPMFGM);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Vector3? NJLLHKKLAKF(string LFLHDCPMFGM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BELPAPJIFEJ(float MIFIAIBOKGO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HandLogicOffsets FIEKCGMOOKH();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	PlatformSpecificPlayerHandOffsets OINFPOKHBFD();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IPJGIHMHELG
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	JOODJDONNFI AHBIPGIPNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform NBNKENEGEGN
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
	void UpdatePostIKAnimControllers(float HHCAAOJDKHN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CKNDLMKNDEL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool GJDFKCPCLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JOODJDONNFI FNDBBINDDLC(string LCGBGLEHPPO, AvatarSystemConfiguration PBPFIONKOGP);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INGPFMPHDJA(string LCGBGLEHPPO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FHDDNKHICNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FKGKDBCHMBL BJHGFDNJMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	CPONPOCPOHL KJDDBKDGHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DCNMLPGLGPB EIHEMJCMFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DCNMLPGLGPB PFGGNIHEIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EPAIPDBBJOB DJNAKHLGOGI(FaceFeatureType DGLKEMHNODA);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EPAIPDBBJOB CCJDDIPEPCC(FaceFeatureType DGLKEMHNODA);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FKGKDBCHMBL AHIFJKNAMGO();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CPONPOCPOHL DAIIPMDGLDA();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GBBJJGFDJCC NFOCEELNLEJ();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GBBJJGFDJCC IBPJACIEDDP();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GBBJJGFDJCC NMGPFELOPOD();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GBBJJGFDJCC JDAGHGNACGN();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DCNMLPGLGPB JDBOMLCICHH();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<DFANCAMLMFG> OBCOFLMFJMM(bool ONBFPBKKNDA = false, bool IMGFHMEANDK = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<DFANCAMLMFG> JKNKOCBINIP(bool ONBFPBKKNDA = false);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task NAADJIJMLBP(bool KJKNFFFMJBP, [Optional] CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task EPICOLCFMJB(LAMBMCGFGPC KANLAAILAIP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LMNEMHKFMDH
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 BGEPJMDLKNH(FaceFeatureType DGLKEMHNODA, PHGHBONDFAJ BNOOPHIBANK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float BHGFOELMIPJ(FaceFeatureType DGLKEMHNODA, PHGHBONDFAJ BNOOPHIBANK);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIDAPMKHNKE(PHGHBONDFAJ BNOOPHIBANK, AvatarConfiguration PBPFIONKOGP);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float BMPOPHGALBI(FaceFeatureType HBFBJIHKKNO, float MBBNFKOPDBP, PHGHBONDFAJ BNOOPHIBANK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float JCNOCLEKCLO(FaceFeatureType HBFBJIHKKNO, float GMGNMIKDEIG, PHGHBONDFAJ BNOOPHIBANK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 EOPGICOOPPE(FaceFeatureType HBFBJIHKKNO, Vector2 KALBBOPGHPI, PHGHBONDFAJ BNOOPHIBANK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 JFKIGJABLKF(FaceFeatureType HBFBJIHKKNO, Vector2 OMNDJDEHBKM, Vector2 JELONFHPIIK, Vector2 OKKJLHBHJFF, PHGHBONDFAJ BNOOPHIBANK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 GBILCPFHNLA(FaceFeatureType HBFBJIHKKNO, Vector2 KALBBOPGHPI, Vector2 JELONFHPIIK, Vector2 OKKJLHBHJFF, PHGHBONDFAJ BNOOPHIBANK);
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
