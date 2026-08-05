using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.AssetIds;
using RecRoom.Avatars.Face;
using RecRoom.DataLayer;
using RecRoom.Protobuf;
using RecRoom.RoomEconomy.Store;
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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x832A2E0", Offset = "0x83292E0", VA = "0x18832A2E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface OAAWCSXFESG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AvatarData GVHFUXOVLDV(AvatarBodyType a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AvatarData UOACRYDEVCT(AvatarBodyType a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OutfitDTO TCJGJCMTLLE(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JUDGXYESRCA(ZADCCUXUXYI a, [Out] AvatarData? avatarData);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool XOQAPGCUUGG(OutfitDTO a, [Out][NotNullWhen(true)] AvatarData? avatarData);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool TDOXCUPSKJH(OutfitDTO a, [Out] ZEOURFDLLTL? outfitData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface TEVLQPNXWZI
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct FootEvent
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public bool Left;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public Vector3 WorldPos;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public Vector3 WorldForward;
		}

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		ZUUFDARDSJN JWMXUGSTZUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		ZUUFDARDSJN MRZLYJZBOGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		AvatarSystemPlayerSetupState YGQRZATVZPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NVMYCLIJNAG WRHNTLAFNOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		YQUMJVMQBIV KOMGWMIXKIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		MKOZOBXCSZX DSDKIXLLLPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		MKOZOBXCSZX RVFIZOXQUUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string LFCZHHAXZHK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		GameObject GQALGTRMTTI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		AvatarConfiguration EFPICKPODOP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		AvatarBodyType SUILNBIGIBY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		HeadLogicOffsets NFYTJMNKAGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Transform TFHRJTXTSAT
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Transform EGBTXYYZBSA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Transform XHKVJUYDLGA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		Transform XNEHYGHIVRN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Vector3 RGZGFCDWYOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		float KIEKLAUCGJD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Transform AATYJCMAREK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Transform MLWUEQCNRBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Transform QDGJQZQGTWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "40")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Transform BZXWLNPLCYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		KIWXAPDLTBO<FootEvent> OMCEQJCZENE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "42")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BKJUOEZIUIZ(string a, AvatarSystemInitState b);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AOPUYULPHNH(AvatarSystemPlayerSetupState a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SQWXIBONLMI();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SMCSWVPPWWR();

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZMYIDZFGTAT();

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NQAFYYGHNHA(float a);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void IXFGQIPIYHU();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UAGSADUFBUM();

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void YKPQKLCPSPN();

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void PPFJKERTZIS(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void BMEYJMRNVGZ([Out] Vector3 a, [Out] Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Transform LEOMQBABWGR(string a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Vector3? XCWEPTLBDTM(string a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void YNUVQGAGKVY(float a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void FCJHVHUHSVB(float a);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void MAEWJSMBCYQ(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "27")]
		HandLogicOffsets CWPJSOBFZMD();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "28")]
		PlatformSpecificPlayerHandOffsets SUFCEWAMWVG();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Vector3 PCTVUZKTCUC();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "38")]
		AvatarSystemUpdateState GPNKDTALCGZ();

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "43")]
		void KYHVXSZWIUI(float a, object b, int c);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void NXJISVWWGYT(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface BRURJHPTWVX
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		TEVLQPNXWZI QJNSSNHGKTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Transform HLDWPFSXQPR
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TEVLQPNXWZI CreateAvatarSystem(string identifier);

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TeardownAvatarSystem();

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool CleanupDisplayMeshes();

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UpdatePostIKAnimControllers(float deltaTime);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface VSKACGMSSMZ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TEVLQPNXWZI EUSDKTHDTZW(string a, AvatarSystemConfiguration b);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PHPCVMUNXPY(string a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string IIEMBLZMRTX(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface EVJFYWQYHQA
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		AvatarConfiguration NUJNCHBFCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		FaceShapeId VCWWRWQLXWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		BodyShapeId GGWVTQAWEEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		HairPatternId IPKWBOFBHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		HairPatternId PJGSODCKKKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		FaceFeatureId UONMNXJLWOP(FaceFeatureType a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		FaceFeatureId VCXYHLVMKZU(FaceFeatureType a);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		AvatarBodyShapeData.BlendShapeName LRZZKIGCLNX(BodyShapeId a);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		AvatarFaceShapeData.BlendShapeName BUUSJTESRMO(FaceShapeId a);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		NoseType MFWSCCEETWC(FaceFeatureId a);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		FaceShapeId OCGQWGYRHBP();

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		BodyShapeId BESFFCWBCBY();

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		ColorId BMGWEPYZCWE();

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ColorId UHGCDLLRPWI();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ColorId VNNWXKZNSYX();

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ColorId HNVUVSOACFV();

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "16")]
		HairPatternId CNZYTBVELDM();

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "17")]
		List<EBPRCKVSCLW> SWHIEAONIGI(AvatarItemBodyType a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "18")]
		List<EBPRCKVSCLW> GTCWDKBHKCB(AvatarItemBodyType a);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task NUZNSHTKKFP(bool a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task DJWYSVDHVSH();

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task ICRESRCAJUX(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task WGZLBTJFBQX(OutfitDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Task WGZLBTJFBQX(IEnumerable<StorefrontGiftDrop> a);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Task WGZLBTJFBQX(List<CustomAvatarItem> a);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Task WGZLBTJFBQX(IReadOnlyList<BQABMXCLJGE> a);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Task WGZLBTJFBQX(IEnumerable<SerializedCustomAvatarItemId> a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool LOSILGJQKNQ(CustomAvatarItem a);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void GXULQLPMGDS(IReadOnlyList<CustomAvatarItem> a);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task STPTDGJWRFP();

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Task<GiftDropStorefront> ITHPXWUCEAN(StorefrontTypes a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool OPGHZVWJNAL(BQABMXCLJGE a, [Out] string b);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "32")]
		bool ZKPTDCTYAIX(IEnumerable<StorefrontGiftDrop> a);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "33")]
		OutfitType CTEVUSDILPY(BQABMXCLJGE a);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "34")]
		ConsumableCategory OMLKXBMHOFU(BQABMXCLJGE a);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool HUXVXBENTBF(BQABMXCLJGE a, [Out] PurchasableGiftDrop b);
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
