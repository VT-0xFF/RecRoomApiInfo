using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Async;
using RecRoom.Avatars.AvatarEffectsDataTypes;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.Protobuf;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Consumable.AvatarItemEffects
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface TTEMNFQTUNB : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ZGCXLZOIQZJ : TTEMNFQTUNB, IDisposable
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface WERZWYBEDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UpdateController(float deltaTime);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface SXWUXIZWKRC
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		AQWXMNIFQIV CLDRPOGOSKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		AQWXMNIFQIV VBBESCTYTSK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		SkinnedMeshRenderer[] VDINTQDQCOP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Material SRVYUAYNXMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Renderer[] WZVVFEQIMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		RRSNZGUWRZN.SkinCullingMask VPBBRDPJKDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool NNSRXGZWUGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		AvatarBodyType XUPYGORFOUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		AvatarConfiguration RDITDXZBMDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		AQWXMNIFQIV OGTPIRDOILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AAGRWYMTYTA([In] AvatarDisplaySetupState avatarDisplaySetupState);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RKLAKEVQLPG(int a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WGGCWIUTEIE(PYBXYCPUXPU a, Texture b, Color c);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CZEKQKEGTJU(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FWGKLGLZCDJ(URBRDOBSRHB a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IYTLBXBFPYO(AvatarColorType a, Color? b);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DULIABOUTCC(AvatarTextureType a, Texture2D b);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KREONBAJSEI();

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		TVVSFJCWLRF FTHMSAKYNJV(PQTLQVUGDIW a, bool b, int[] c, Func<Dictionary<string, PYBXYCPUXPU>, (TVVSFJCWLRF, EWYSBGHBSNQ<Dictionary<string, FPZMXFTLOMZ<Texture2D>>>)> d);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		TVVSFJCWLRF HWBYGOOREAJ(PQTLQVUGDIW a, bool b, int[] c);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void MQSDZVFKBNL();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool LOQSMPQTREZ(RRSNZGUWRZN.SkinCullingMask a);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void SLYHDORBKCT(AvatarFaceShape a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void YAJNUXROUOI(AvatarBodyShape a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void WWPWJWOZXHI(BodyProperty a, float b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void GHRJFHBACPM(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void XRDAYTIPCHJ(FaceProperty a, float b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void LJNTPTWHMNT(NoseProperty a, float b, bool c);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void GDTQVDJIFHV(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void ZHTWHNWEMWN(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void JVLTUUTAFRW(NoseType a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void DNKESXCUSLB(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void ETVACZXXXYI();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void MCXEWRCVMUU();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void XTMNKSIJAHF([Optional] EGXISHAOLQW a, [Optional] bool? b);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "35")]
		Task UCPXIRZYEMT(string a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void GCVWUORPWBM(float a, Color b, bool c = false);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void TVHRDYVEVOK(TextureEffectMaterialProperties a, TextureEffectMaterialTextures b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface VEYNEEJCJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		SXWUXIZWKRC GRRXEUEFXXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		OBAYVHASZMX BBOMCUSNEML
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		VDCGHNUMNLV AXUMAMNNWYI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		VDCGHNUMNLV GJUZZSYPECD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Transform DZRJHSNZXEB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TeardownAvatarDisplaySystem();

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CleanupDisplayMeshes();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OBAYVHASZMX : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MAKTUEXERWX([In] AvatarFaceDisplayUpdateRenderersState updateState);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TIIVLYYRXLS(AvatarFaceDisplayUpdateFeatureSelectionState a);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void USRGENZWGUK([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface VDCGHNUMNLV
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		HandVisualState XMBJQAULJQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		float ISCQQKZVKRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		HandVisualState GRYNZLYCQZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		bool GQWNIUVHXBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Vector3 NPRTQELOTTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Quaternion RSJEBCMTHFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IWWBBOTCQGB(HandAnimationOverrideState a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GGAQEYAIRWJ();

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AOWNMUTIJXV(int a, float b);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void XWYAOFPNLAZ();

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void TLLCCVKECDV(bool a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool IIEHWFSTHWL();

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool FLOJOLCTAVX();

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void VYBSCWVTSUW(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void QSBXWPXIUIP(Transform a, Vector3 b, Quaternion c);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface BONQXDVYAXY
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		OutfitType JOJEAXYHAVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		IReadOnlyList<OutfitType> UNLJEPJMAIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		IEnumerable<OutfitType> DGFSCTARJZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		RRSNZGUWRZN.SkinCullingMask HKCSYYRNMDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		Guid AXUVQJAOTPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool KLXRBDEUOUU
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8806540", Offset = "0x8805140", VA = "0x188806540", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool JGWYFTCOQDF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8806630", Offset = "0x8805230", VA = "0x188806630", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		string JWKDZJKIEQD
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool YQELQBJOREJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IVTIIOXLUEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool YATPABAYWAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool CQGYYQAASZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		Color VUKQBNAJIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool GHLKUICDABA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool TLXVXTRJQOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool UXSOPNYZSEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		AdditionalOutfitTypeData IRMEZRMGUHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		AdditionalHatData JDHFXVRTMGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		HairData GBTYIRRXXWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		HelmetHairMode QJISWYBFHRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x88064A0", Offset = "0x88050A0", VA = "0x1888064A0", Slot = "20")]
			get
			{
				return default(HelmetHairMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool JDZKXHYEQFO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8806400", Offset = "0x8805000", VA = "0x188806400", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool AOQQSLYHVUV
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		AnchorParamsRestrictions IIIHAMNOKDP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8806590", Offset = "0x8805190", VA = "0x188806590", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool CLMWPWRZBHX(AvatarItemBodyType a);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		bool VSNJVCWWBMI(bool a = true);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface GVLQCLWBCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BONQXDVYAXY YZTCKSDOVKJ(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PFBPLSKALVW(PYBXYCPUXPU a, BONQXDVYAXY b, AvatarItemBodyType c);
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
