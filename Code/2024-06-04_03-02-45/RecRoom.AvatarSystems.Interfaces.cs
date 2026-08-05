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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67182F0", Offset = "0x6716AF0", VA = "0x1867182F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GDLNNNKECMN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BGEKPNHNABN IHGBLEBGFIE(bool BKELHAELDAG = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BGEKPNHNABN PNDIOGLFBHH(bool BKELHAELDAG = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PIJELOHKNKB FNPHIEMHJML(BGEKPNHNABN MLKNGAFFKGE, int MPGHECCBKFA, string? GCDLMFGKKMH, string? NHKBHFHBLIH, ODGMKINPFBN FNGANFOBOIH, List<BKGGCPNPCAA>? HAPHEALFDML);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EOKOLNLLCMI(AHDOLPLLHFG MEJBEJHMLPO, [Out] BGEKPNHNABN? LGJMDPAEIIH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool COIKPIEIOBK(PIJELOHKNKB PGGBHJAAIEH, [Out] BGEKPNHNABN? LGJMDPAEIIH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JCIHKICNBOK(PIJELOHKNKB PGGBHJAAIEH, [Out] DHFKGLJPJBM? MEJBEJHMLPO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GFOLMCEBPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KGKILIPHNPL MJPPDKACGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float CKODHDOCHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	KGKILIPHNPL IICLBJFBFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBAMEDBACEJ(FMEDBBIHPJK DAGLKLOEBMA, bool GBHPPBEDPMD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CHCJPAKPIMN();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BPABIKKJMNM(int NAKJNOOFGGJ, float CMMHCOBALGH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DKPFNNLPMPA();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LAEDPMPNAGG(bool IOAFJLAKIKP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FGGCADFOBEI();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GPDOHNLHNJK();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNNHDHKHMIC(bool IOAFJLAKIKP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HCHKJFEMAIF(Transform GGJNHHDMGON, Vector3 AMLFGBAFEIN, Quaternion BCLJBLAEDFE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GDBHNPFGFMA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LFHDLKLNBFG COMINOEIDIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LFHDLKLNBFG FEILIEEJPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FAICNNGHKAN EBBNHAEHPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PNAOPNKBNGF KOHNOCHDNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GFOLMCEBPKC GCIJCPPLCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GFOLMCEBPKC AHEPFPCEDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GameObject DLBGNHFNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AvatarConfiguration FKCODEIKNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform NLLPGBBADGN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform MONNBGJDOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Vector3 POBIBLIJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float JMPLEDNGEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform NHFFNCFFBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNBNJPOANFJ(CFHNEDCHEKI EPGJJKACGBC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MMHICNOHBAH(NNPAMPJFNNC EIPGPNFAEKN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KFCDFMDHAKA();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMMAPHKEADF();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBNCOLDEFND(float HHANHFPADCH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GDJJFGJOKPE();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NHMKDKLHCHJ();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CMPCFDGHKBP();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GEKFMJEPDJM(bool COBPBACJPEK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NBNHLKCNIKN([Out] Vector3 JNNHOAAAIGP, [Out] Quaternion CABDPFOEAMO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Transform NNHCPHAOCNA(string HPFJOEMPMIE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Vector3? DBIFFNBMABH(string HPFJOEMPMIE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OLHFHDIBHNE(float OCPJMGGCICO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HandLogicOffsets BGILOBGNCFN();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	PlatformSpecificPlayerHandOffsets OCFMLFAMFII();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GPJPKABEJAA
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	GDBHNPFGFMA LOGMNECDIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform HIFHCBPDOKA
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
	void UpdatePostIKAnimControllers(float PNBNBIDOECN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NINHCBMGBMI
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool DHGJJMBNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GDBHNPFGFMA JOEDDLPJHDM(string NKHLJKJEKPC, AvatarSystemConfiguration AILGHLBLAFC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKAOKIPIHJN(string NKHLJKJEKPC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FCCCCLHBAGC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MHJGBGNNDJI OMPMALBMHED
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	IMGHHJDAPBF FFFMGJIFCCI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OCAJLLGKCNC GCHADNMCJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	OCAJLLGKCNC BLKIBLBNPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CFAGBELJJDL OOEBJONCEFM(FaceFeatureType KHIDKLAJDFE);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CFAGBELJJDL HGJNCFNMMIA(FaceFeatureType KHIDKLAJDFE);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MHJGBGNNDJI HKNDOJNPJJJ();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IMGHHJDAPBF BEHHDMFNBBJ();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GJGDDNMDCIJ EBHBOBPDLKJ();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GJGDDNMDCIJ EHEBHPDGLBL();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GJGDDNMDCIJ PDPNICOMNKI();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GJGDDNMDCIJ LOLBHFFLJPH();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OCAJLLGKCNC MKBNOGGCEKA();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<HADOENGGMPL> DBAHKHAHDOC(bool BGBLONFICML = false, bool EMBFOMLBBKC = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<HADOENGGMPL> HADNMADBJJM(bool BGBLONFICML = false);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task NMLHABIIEJE(bool NIFCJNEDLOM, [Optional] CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task AGENJDGEANI(PIJELOHKNKB PJEJIJCIFHH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OBBNHONMJAJ
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 MJBHHPAIOBP(FaceFeatureType KHIDKLAJDFE, JNBBILMHJPI ECGCEDDHANK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float PDNAMBPHBEA(FaceFeatureType KHIDKLAJDFE, JNBBILMHJPI ECGCEDDHANK);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPPPEIEGJIH(JNBBILMHJPI ECGCEDDHANK, AvatarConfiguration AILGHLBLAFC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float FIFAJLNLNJF(FaceFeatureType MMFDDGOJNCB, float LCNEFMHPBJL, JNBBILMHJPI ECGCEDDHANK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float PMBGOIDNBKI(FaceFeatureType MMFDDGOJNCB, float NPAKCGCAODL, JNBBILMHJPI ECGCEDDHANK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 DDNIJLJGKLM(FaceFeatureType MMFDDGOJNCB, Vector2 BOOOMFONEAG, JNBBILMHJPI ECGCEDDHANK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 OIANMECIKNG(FaceFeatureType MMFDDGOJNCB, Vector2 EPKOGBHGJEF, Vector2 DCLLGJMFNJO, Vector2 DCAJMJHCGHA, JNBBILMHJPI ECGCEDDHANK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 FHILAPEEFHI(FaceFeatureType MMFDDGOJNCB, Vector2 BOOOMFONEAG, Vector2 DCLLGJMFNJO, Vector2 DCAJMJHCGHA, JNBBILMHJPI ECGCEDDHANK);
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
