using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Avatars.Protobuf;
using RecRoom.DataLayer;
using RecRoom.OnlineRestrictions;
using RecRoom.Protobuf;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class RSMDMJCMLCI
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly string HZBZAOOPWOD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83C94C0", Offset = "0x83C7AC0", VA = "0x1883C94C0")]
		public static AvatarSystemUpdateState KJFLSOKUWIN()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83C8AC0", Offset = "0x83C70C0", VA = "0x1883C8AC0")]
		public static AvatarSystemInitState ALKFXUWDEIL(AvatarBodyType a, Transform b, Transform c, AvatarConfiguration d, Animator e, VRIK f, GameObject[] g, Transform h, AvatarSkinAssetItem i, AssetReference j, AssetReference k, AssetReference l, AssetReference m, GameObject n, GameObject o, GameObject p, SkinnedMeshRenderer q, AvatarSkinnedMeshBoneOrderRemapsData r, Material s, Material t, Material u, Texture2D v, Material w, Material x, Shader y, Shader z, Transform ba, Transform bb, Transform bc, Transform bd, Transform be, Transform bf, Renderer[] bg, WWHBNSZLZGH bh, WWHBNSZLZGH bi, WWHBNSZLZGH bj, WWHBNSZLZGH bk, WWHBNSZLZGH bl, WWHBNSZLZGH bm, WWHBNSZLZGH bn, WWHBNSZLZGH bo, Transform bp, Transform bq, Transform br, Transform bs, GameObject bt, GameObject bu, AvatarBodyPartShapesManager bv, Transform bw, Transform bx, Transform by, Transform bz, Transform ca)
		{
			return default(AvatarSystemInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83C9510", Offset = "0x83C7B10", VA = "0x1883C9510")]
		public static AvatarSystemPlayerSetupState YVKMPLAHLYD(string a, bool b, bool c, AvatarSystemUpdateDriver d, Func<AvatarSystemUpdateRateState> e, Func<Vector3, AvatarSystemUpdateState> f, RigidbodyEx g, Transform h, Transform i, Transform j, Transform k, Transform l, float m, float n, PlayerAvatarColliders o, SkinnedMeshRenderer[] p, SkinnedMeshRenderer[] q, SkinnedMeshRenderer[] r, SkinnedMeshRenderer[] s)
		{
			return default(AvatarSystemPlayerSetupState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83C9010", Offset = "0x83C7610", VA = "0x1883C9010")]
		public static PositionAndRotation DHSOAEEMESK(Transform a, Transform b)
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83C91A0", Offset = "0x83C77A0", VA = "0x1883C91A0")]
		public static void HHYJVFLYLZR(Transform a, Transform b, PositionAndRotation c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface KBUWEQMSEPV
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Transform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LYCSRMNJHHM : KBUWEQMSEPV
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform HBZICNJLAVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 VIKMSUDCMNA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1A0A210", Offset = "0x1A08810", VA = "0x181A0A210", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1A0A170", Offset = "0x1A08770", VA = "0x181A0A170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float? OKBNCUEIRZH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x143A2D0", Offset = "0x14388D0", VA = "0x18143A2D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x111B4B0", Offset = "0x1119AB0", VA = "0x18111B4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public LYCSRMNJHHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class NWPRWDYMTXO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected readonly LYCSRMNJHHM SMEAKSLQHUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected readonly LYCSRMNJHHM JOKYAGGEXPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected readonly LYCSRMNJHHM MGUDLOJPXPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly LYCSRMNJHHM DUQFLZORJIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly LYCSRMNJHHM UHBGXAKEYSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly LYCSRMNJHHM DGNYKDJJLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly LYCSRMNJHHM BLFYWAAFBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly LYCSRMNJHHM NPXSBMIREPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected readonly LYCSRMNJHHM AJUTLWRHYUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		protected readonly LYCSRMNJHHM FJDIYASWSKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected readonly LYCSRMNJHHM RUUMXXBFGRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		protected readonly LYCSRMNJHHM BGVHAJPKXKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		protected readonly LYCSRMNJHHM YDJYLLVDVIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected LYCSRMNJHHM EXGFYNWXGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected readonly LYCSRMNJHHM ESXQTSGWMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly LYCSRMNJHHM YCBHMAIHWFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly LYCSRMNJHHM DFNRNAHZQWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected LYCSRMNJHHM RHCWQVRJZYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly LYCSRMNJHHM OFILZEDBDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly LYCSRMNJHHM SIXSUIQYHJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly LYCSRMNJHHM BMQCBWRJGRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected ReadOnlyCollection<LYCSRMNJHHM> WNVGVXXAUCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Transform ZNMLEONGKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private (LYCSRMNJHHM Start, LYCSRMNJHHM End)[] XHLCDQYLFUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Dictionary<string, LYCSRMNJHHM> DEFIVJPXDCP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public KBUWEQMSEPV TAEGGTYMEFK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public KBUWEQMSEPV SWQHPZJUWMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public KBUWEQMSEPV XOELPUQUIPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KBUWEQMSEPV DSZQZZTBGNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public KBUWEQMSEPV PDRKOMZUAJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public KBUWEQMSEPV GVYHPJJZQFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KBUWEQMSEPV CEAJEAHLPJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KBUWEQMSEPV QPILHDEUVUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAACD50", Offset = "0xAAB350", VA = "0x180AACD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KBUWEQMSEPV AGTALZQKFVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83C5590", Offset = "0x83C3B90", VA = "0x1883C5590")]
		public void NDBODFAISIK(VRIK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83C5360", Offset = "0x83C3960", VA = "0x1883C5360")]
		private void CBFMPNAHRGN(Transform a, LYCSRMNJHHM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83C53F0", Offset = "0x83C39F0", VA = "0x1883C53F0")]
		public LYCSRMNJHHM CXXPIPEEVCD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83C64A0", Offset = "0x83C4AA0", VA = "0x1883C64A0")]
		public void XPSCSMHQABV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83C5320", Offset = "0x83C3920", VA = "0x1883C5320")]
		public float BWJUKENVGVL([In] (LYCSRMNJHHM Start, LYCSRMNJHHM End) limb)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83C68A0", Offset = "0x83C4EA0", VA = "0x1883C68A0")]
		public void YCNBZMGZANZ([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83C5460", Offset = "0x83C3A60", VA = "0x1883C5460")]
		private Vector3 FFJCVJPCZWN([In] (LYCSRMNJHHM Start, LYCSRMNJHHM End) limb)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83C6A40", Offset = "0x83C5040", VA = "0x1883C6A40")]
		public NWPRWDYMTXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83C4C50", Offset = "0x83C3250", VA = "0x1883C4C50")]
		public string GetAvatarSystemIdentifier(string playerName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83C4CA0", Offset = "0x83C32A0", VA = "0x1883C4CA0")]
		public AvatarSystemConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum AvatarSystemUpdateDriver
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Input,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		AnimationPlayback,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		HolotarPreviewOrPlayback
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum AvatarStance
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Medium,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Cute,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Low,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Narrow,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Narrow2,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Wide,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		HipShift,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		Slouch,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		NumStances
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct AvatarSystemPlayerSetupState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public string PlayerAvatarName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public bool IsPlayerUsingScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool IsPlayerLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float PlayerHeadRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float PlayerMaxCapsuleHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AvatarSystemUpdateDriver UpdateDriver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Func<AvatarSystemUpdateRateState> GetUpdateRateState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Func<Vector3, AvatarSystemUpdateState> GetUpdateStateFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public RigidbodyEx OriginTrackedSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Transform Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Transform MovementTrackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Transform HeadIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Transform LeftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Transform RightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[FormerlySerializedAs("PlayerAvatarFullBodyColliders")]
		[FormerlySerializedAs("playerAvatarModernBodyColliders")]
		public PlayerAvatarColliders playerAvatarColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public SkinnedMeshRenderer[] CurrentThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public SkinnedMeshRenderer[] NextThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public SkinnedMeshRenderer[] CurrentFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public SkinnedMeshRenderer[] NextFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool EPTQGFVMMYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x80F0650", Offset = "0x80EEC50", VA = "0x1880F0650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool TXBXQFQYUDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x80F0660", Offset = "0x80EEC60", VA = "0x1880F0660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83C4CF0", Offset = "0x83C32F0", VA = "0x1883C4CF0")]
		public AvatarSystemUpdateState JAXFABWQCOS(Vector3 a)
		{
			return default(AvatarSystemUpdateState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct AvatarSystemInitState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AvatarBodyType AvatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Transform RootTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Transform DeformRigRootTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AvatarConfiguration AvatarConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public VRIK SkeletonVRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public GameObject[] HideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Transform HeadAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AvatarSkinAssetItem PotatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AssetReference SkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AssetReference TorsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AssetReference LegsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AssetReference TorsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public GameObject AllBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public GameObject FirstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GameObject ThirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Texture2D BodyEmissiveMapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Renderer[] WatchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public WWHBNSZLZGH LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public WWHBNSZLZGH LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public WWHBNSZLZGH LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public WWHBNSZLZGH LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public WWHBNSZLZGH RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public WWHBNSZLZGH RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public WWHBNSZLZGH RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public WWHBNSZLZGH RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AvatarBodyPartShapesManager AvatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Transform RightHipSlotAnchor;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct AvatarSystemUpdateRateState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public bool IsPlayerVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public UpdateLOD DistanceBand;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct AvatarSystemUpdateState
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class VXPGLOFCQZO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public readonly bool VFDOOUEHXTV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public readonly bool ETTVVRAEJUX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public readonly bool QTBOXYDBOWO;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x83C9700", Offset = "0x83C7D00", VA = "0x1883C9700")]
			public VXPGLOFCQZO(bool a, bool b, bool c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float DeltaTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool IsLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float DesiredAvatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Vector3 PlayerUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Vector3 ForwardYawReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Vector3? TorsoForwardOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Vector3? PelvisAnchorPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool IsPlayerSteering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public bool IsPlayerSeated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool IsPlayerFlying;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool IsPlayerWallClimbing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Vector3? WallClimbNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool IsPlayerWallRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3? WallRunWallTangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool IsPlayerClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Vector3? ClamberWallNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public float ClamberTimeRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3? PlayerSteeringVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool IsPlayerFalling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public bool IsPlayerStartingSlide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public bool IsPlayerSliding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public bool IsPlayerLanding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public bool IsPlayerSeatedInSittingPosture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public bool IsPlayerWallRunOnRightSide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public bool IsPlayerStartingJump;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public bool IsPlayerStartingTeleport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool IsPlayerTeleporting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool IsPlayerCrouching;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool IsPlayerProne;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Vector3? ProneNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public HandGestureType RightHandGestureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public HandGestureType LeftHandGestureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public float RightHandIKWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float LeftHandIKWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AnimationPoseType LeftHandAnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AnimationPoseType RightHandAnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public bool IsThirdPersonCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public bool IsPlayerUsingFullBodyCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public bool ShowHandsWhenGrabbing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float GroundOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public float GroundOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float HeelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AvatarStance IdleStance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public float IdleStanceLeftRightBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public FullBodyAnimationOverride UGCOverideAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public VXPGLOFCQZO DiagnosticOnlyState;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OGMBTPSFWPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x83C4EA0", Offset = "0x83C34A0", VA = "0x1883C4EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OSNHUVDGPTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x83C4EB0", Offset = "0x83C34B0", VA = "0x1883C4EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83C4EC0", Offset = "0x83C34C0", VA = "0x1883C4EC0")]
		public void Rotate(Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class FFJOBVWXQEQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83C5300", Offset = "0x83C3900", VA = "0x1883C5300")]
		public static AvatarBodyPart JDYVDTRAKGR(this DOUQKMCCEPT a)
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83C52E0", Offset = "0x83C38E0", VA = "0x1883C52E0")]
		public static void COJCZMXNXIN(this DOUQKMCCEPT a, AvatarBodyPart b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class ZUHZCSXPJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83C9940", Offset = "0x83C7F40", VA = "0x1883C9940")]
		public static bool QXIZNGIKEIL(this UBXVIKGBBKG a, SLGKQDZWFPJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83C9750", Offset = "0x83C7D50", VA = "0x1883C9750")]
		public static bool JKXLOFXYNMH(this UBXVIKGBBKG a, ZMUFVRWVYIY b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class PlayerAvatarColliders : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum ColliderEnabledState
		{
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			EnabledForFullBody,
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			EnabledForModernBeanBody
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const string TQLRNVUBUIG = "Avatars.DisableFullBodySpecificColliders";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private AYCTVZMEYXV JCXGMIFKRIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private List<Collider> OUCBDBZGGBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private List<Collider> ZBYDVWJYIMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private List<Collider> WOJVVGAZZAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private ColliderEnabledState? CABOPHKWPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private SGWOUGLKKLH XFRHJOLJFZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private Collider[] FullBodyOnlyColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] IHXCLEROVQI;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> XUELLMLKQXY
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x83C8A60", Offset = "0x83C7060", VA = "0x1883C8A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<Collider> NWEHXJKCQYI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x83C8A80", Offset = "0x83C7080", VA = "0x1883C8A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Collider> TCVEYPOHVHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x83C8AA0", Offset = "0x83C70A0", VA = "0x1883C8AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private AYCTVZMEYXV GRHCRZTBLKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x83C89B0", Offset = "0x83C6FB0", VA = "0x1883C89B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ZSOFFANUBDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1D3F430", Offset = "0x1D3DA30", VA = "0x181D3F430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83C7AF0", Offset = "0x83C60F0", VA = "0x1883C7AF0")]
		private void OLRIPTKAYJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83C7A50", Offset = "0x83C6050", VA = "0x1883C7A50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83C8A40", Offset = "0x83C7040", VA = "0x1883C8A40")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer skinnedMeshRenderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83C85D0", Offset = "0x83C6BD0", VA = "0x1883C85D0")]
		public void SetCollidersEnabled(ColliderEnabledState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83C8190", Offset = "0x83C6790", VA = "0x1883C8190")]
		public void ReparentBonesUnderOtherBoneCollection(AYCTVZMEYXV otherBoneCollection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83C7F10", Offset = "0x83C6510", VA = "0x1883C7F10")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public PlayerAvatarColliders()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PRSDTAJNNUT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Transform WOGKPJQAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Transform OBGJPQGOREL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Transform RSSWQSFIJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Transform RHRGHSXLBAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Transform KYOGHONZZIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Transform MLXYMRWOFWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Transform WLBWKLYADPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Transform GYCBUDELRTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Transform EDSDFPRFBGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private PositionAndRotation RQSEVVHXBRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private PositionAndRotation YDMLTJZKGZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private PositionAndRotation CUSBPVZHQHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private PositionAndRotation PSYPGOTFWYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private PositionAndRotation RBTELUBQIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private PositionAndRotation ZITDYCDRNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private PositionAndRotation TJIYELUZZBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private PositionAndRotation CMCNNAFRDYY;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83C75F0", Offset = "0x83C5BF0", VA = "0x1883C75F0")]
		public void Initialize(Transform handRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83C6E50", Offset = "0x83C5450", VA = "0x1883C6E50")]
		public void BFZCGCZJWGX(HandLogicOffsets a, HandType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83C7800", Offset = "0x83C5E00", VA = "0x1883C7800")]
		public void QEYRKHUEVFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PRSDTAJNNUT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AHTDHEYTYKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Transform KJRHGKDNGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Transform NASXVCRUDDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Transform NQVNLCMWCOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Transform QOECYEAWTVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Transform MLWUHZUMXJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private PositionAndRotation USVBQYCLJVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private PositionAndRotation MMMVFPFEFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private PositionAndRotation BIDQANMJETJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private PositionAndRotation UCGEDECOCOS;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83C4990", Offset = "0x83C2F90", VA = "0x1883C4990")]
		public void Initialize(Transform headRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83C4790", Offset = "0x83C2D90", VA = "0x1883C4790")]
		public void DPFJEJGAVMS(HeadLogicOffsets a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83C4AC0", Offset = "0x83C30C0", VA = "0x1883C4AC0")]
		public void WYUMUUQAHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public AHTDHEYTYKE()
		{
		}
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
