using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x830FAE0", Offset = "0x830E8E0", VA = "0x18830FAE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface FMSXREWNLVU
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AvatarData ZTCVSFRCIWT(AvatarBodyType a);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AvatarData SMNMEDPBGXN(AvatarBodyType a);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OutfitDTO HPWTMGRTSJU(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool FNRGOBYCNBC(JZWUPZCAVYY a, [Out] AvatarData? avatarData);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool JRSLRNHEMDM(OutfitDTO a, [Out] AvatarData? avatarData);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NXFYWRXICTL(OutfitDTO a, [Out] LTZSFXRYEKR? outfitData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface OGUVYQLADLQ
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
		VYROOIAXTCX NHJNOZELIXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		VYROOIAXTCX ILZWXRTJVJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		AvatarSystemPlayerSetupState UWEXKZDYPHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		VOFTTVKCXFM FMEYFNPTHQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		HIRVRSWRHSJ PALDRCZWSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		YEUBVQTUYOF NBFZZAOEOBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		YEUBVQTUYOF IBUDLDGZAZH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		string RMMKMJSZRBO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		GameObject WUVBCURWBJM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		AvatarConfiguration PATMBHBIPHN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		AvatarBodyType VPRWSZEENKS
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		HeadLogicOffsets MGPGIMMKTMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Transform VTUMSFPTORB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Transform QXEGUTXCHJS
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Transform NNISNFFFAZW
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		Transform ARLLYMVPLEH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Vector3 OZULHVNIQJC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		float LNYZWEEUYJT
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "36")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		Transform COPOGZPBVNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Transform YKGTZPNEAJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Transform ZJTKXWDMFWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "40")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		Transform KJLVTONGTQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		YVFAYFMDPIA<FootEvent> BKKELWIDWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "42")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UYUOIXTTHUV(string a, AvatarSystemInitState b);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RPZKVVDNOPP(AvatarSystemPlayerSetupState a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ROXDIYJLRBW();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VHCOEUXNKLH();

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PKZPBPEIPQL();

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JJMIJWCNVPI(float a);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void KIHEWQPOPFU();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void DOSSZJWZIJG();

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void IPJPQNYSVVV();

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void SQWVZYCMFZI(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void JHOMRMNRIYR([Out] Vector3 a, [Out] Quaternion b);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Transform UAOLPICDOYF(string a);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Vector3? FKXFLNGUVAS(string a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void KZHBKIVXXXA(float a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void LPDCNCGYCWH(float a);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void EJZHVTFYAPS(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "27")]
		HandLogicOffsets IQPMBODGCYX();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "28")]
		PlatformSpecificPlayerHandOffsets CHILTXETIYA();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Vector3 EANQOAGSQUK();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "38")]
		AvatarSystemUpdateState BDPOQCESZDL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface VYUWEDVUPLH
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		OGUVYQLADLQ TSMFWTLDVUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		Transform AMZZYNWPYAP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OGUVYQLADLQ CreateAvatarSystem(string identifier);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TeardownAvatarSystem();

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool CleanupDisplayMeshes();

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UpdatePostIKAnimControllers(float deltaTime);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface BOGGZLIIMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OGUVYQLADLQ BPRCZSPSEGQ(string a, AvatarSystemConfiguration b);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UGVDOXVDIBY(string a);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		string WDZKQOMJKDD(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface NKLTPFPFNHC
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		AvatarConfiguration QERVUCKEIRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		FaceShapeId VSBJYGLQZNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		BodyShapeId COYQYONGLPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		HairPatternId FRKYNIIKCUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		HairPatternId WWPVVZLXILT
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		FaceFeatureId UATVWSPFKJJ(FaceFeatureType a);

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		FaceFeatureId WRIPLOXTXBQ(FaceFeatureType a);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		AvatarBodyShapeData.BlendShapeName SHNJQCTILRX(BodyShapeId a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "8")]
		AvatarFaceShapeData.BlendShapeName SVDFDFLVTWC(FaceShapeId a);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "9")]
		NoseType EOHGFEYGCCW(FaceFeatureId a);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		FaceShapeId MAKDKVGGEQV();

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		BodyShapeId MMPUWMRVQWW();

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		ColorId MVADHZGHYAQ();

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ColorId OFLLMNPTTME();

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ColorId GXUZEZFXFEL();

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ColorId CTINHPTEGYP();

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "16")]
		HairPatternId PMIEJZPJXGO();

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "17")]
		List<OEHKSYFBEYM> PRNWHIXCMWY(AvatarItemBodyType a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "18")]
		List<OEHKSYFBEYM> EQESFNDFWSZ(AvatarItemBodyType a);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "19")]
		Task OJNUBCNDXRT(bool a, [Optional] CancellationToken b);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "20")]
		Task KIUAAGEBFAD();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "21")]
		Task UGHBACJMJRN(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "22")]
		Task PNERYPVZVXZ(OutfitDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "23")]
		Task PNERYPVZVXZ(IEnumerable<StorefrontGiftDrop> a);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "24")]
		Task PNERYPVZVXZ(List<CustomAvatarItem> a);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Task PNERYPVZVXZ(IReadOnlyList<ARAIZKZLBQI> a);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		Task PNERYPVZVXZ(IEnumerable<SerializedCustomAvatarItemId> a);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool DBVNSKMJGRI(CustomAvatarItem a);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void JYKCSEXOIGU(IReadOnlyList<CustomAvatarItem> a);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "29")]
		Task AENXUUIBDUR();

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Task<GiftDropStorefront> ZWUPKKIPWFT(StorefrontTypes a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "31")]
		bool WZWUQXVUYHJ(ARAIZKZLBQI a, [Out] string b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "32")]
		bool ESPYAAKOFHV(IEnumerable<StorefrontGiftDrop> a);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "33")]
		OutfitType VJSYBNTWWRA(ARAIZKZLBQI a);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "34")]
		ConsumableCategory HXXOBGPUOFE(ARAIZKZLBQI a);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool ORTNBULQEAL(ARAIZKZLBQI a, [Out] PurchasableGiftDrop b);
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
