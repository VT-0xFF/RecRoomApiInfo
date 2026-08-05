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
	public static class KNDGWWHBEUR
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly string GUMDXDZWUEU;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88A5530", Offset = "0x88A4130", VA = "0x1888A5530")]
		public static AvatarSystemUpdateState YIAFWPLCIBQ()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88A4A40", Offset = "0x88A3640", VA = "0x1888A4A40")]
		public static AvatarSystemInitState CEQZYNPOHYY(AvatarBodyType a, Transform b, Transform c, AvatarConfiguration d, Animator e, VRIK f, GameObject[] g, Transform h, AvatarSkinAssetItem i, AssetReference j, GameObject k, GameObject l, SkinnedMeshRenderer m, AvatarSkinnedMeshBoneOrderRemapsData n, Material o, Material p, Material q, Material r, Shader s, Shader t, Transform u, Transform v, Transform w, Transform x, Transform y, Transform z, Renderer[] ba, WERZWYBEDOI bb, WERZWYBEDOI bc, WERZWYBEDOI bd, WERZWYBEDOI be, WERZWYBEDOI bf, WERZWYBEDOI bg, WERZWYBEDOI bh, WERZWYBEDOI bi, Transform bj, Transform bk, Transform bl, Transform bm, GameObject bn, GameObject bo, AvatarBodyPartShapesManager bp, Transform bq, Transform br, Transform bs, Transform bt, Transform bu)
		{
			return default(AvatarSystemInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88A5210", Offset = "0x88A3E10", VA = "0x1888A5210")]
		public static AvatarSystemPlayerSetupState PRDTQPUKYAO(string a, bool b, bool c, AvatarSystemUpdateDriver d, Func<AvatarSystemUpdateRateState> e, Func<Vector3, AvatarSystemUpdateState> f, RigidbodyEx g, Transform h, Transform i, Transform j, Transform k, Transform l, float m, float n, PlayerAvatarColliders o, SkinnedMeshRenderer[] p, SkinnedMeshRenderer[] q, SkinnedMeshRenderer[] r, SkinnedMeshRenderer[] s)
		{
			return default(AvatarSystemPlayerSetupState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88A53A0", Offset = "0x88A3FA0", VA = "0x1888A53A0")]
		public static PositionAndRotation QPIZRXVERCJ(Transform a, Transform b)
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88A4EF0", Offset = "0x88A3AF0", VA = "0x1888A4EF0")]
		public static void PICHWFXGGUI(Transform a, Transform b, PositionAndRotation c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface HGDAMKZQCBK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Transform GZVGTXLLTNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class FFMGBURXUAH : HGDAMKZQCBK
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform GZVGTXLLTNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 TPHVYHXHMWV
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1A9AEA0", Offset = "0x1A99AA0", VA = "0x181A9AEA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1A9ADF0", Offset = "0x1A999F0", VA = "0x181A9ADF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float? UKRGLDOJNRU
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x14C0250", Offset = "0x14BEE50", VA = "0x1814C0250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1195440", Offset = "0x1194040", VA = "0x181195440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public FFMGBURXUAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class LYBHQCHKOIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		protected readonly FFMGBURXUAH XWHWGXDLHWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		protected readonly FFMGBURXUAH UBUVQQQEMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected readonly FFMGBURXUAH ECFKRMRRJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly FFMGBURXUAH CRZTEWZTACU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly FFMGBURXUAH UORTQQRSYFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly FFMGBURXUAH CSEZWPBNGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly FFMGBURXUAH ADMVBEJKMDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly FFMGBURXUAH EEGQNNLVYJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected readonly FFMGBURXUAH CEFKZDAZLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		protected readonly FFMGBURXUAH LHCBELWGRVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected readonly FFMGBURXUAH DIHMRRAMADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		protected readonly FFMGBURXUAH BLHRSVWWWFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		protected readonly FFMGBURXUAH AIQIQVXPCLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected FFMGBURXUAH HWRQBYSBNKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected readonly FFMGBURXUAH HGIMGKLGTPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly FFMGBURXUAH VNMTSMRZMSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly FFMGBURXUAH QTMZRDXPWMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected FFMGBURXUAH SLRAKKMNFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly FFMGBURXUAH HKBNHUDHQMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly FFMGBURXUAH PTXDCMEWXPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly FFMGBURXUAH QTPTPQBRPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected ReadOnlyCollection<FFMGBURXUAH> KZIUAFHWKQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Transform WKMQGLSGCII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private (FFMGBURXUAH Start, FFMGBURXUAH End)[] EVNTQXKDTAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Dictionary<string, FFMGBURXUAH> HBRDQSZNLEC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public HGDAMKZQCBK INOBHLSYJGB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public HGDAMKZQCBK JEFNBZNLXJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public HGDAMKZQCBK XQONXURBLWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HGDAMKZQCBK MPHFHWXWOUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HGDAMKZQCBK UTDPUVETQKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HGDAMKZQCBK UKUYUGFTDSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public HGDAMKZQCBK ETTYVKYDBMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HGDAMKZQCBK TBVHPURCHSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB14930", Offset = "0xB13530", VA = "0x180B14930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HGDAMKZQCBK BMJXBEOAVTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88A5CF0", Offset = "0x88A48F0", VA = "0x1888A5CF0")]
		public void QQKFZNZAIGD(VRIK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88A5C60", Offset = "0x88A4860", VA = "0x1888A5C60")]
		private void OWQHDSHVOCC(Transform a, FFMGBURXUAH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88A5A40", Offset = "0x88A4640", VA = "0x1888A5A40")]
		public FFMGBURXUAH JDPCFXMOQPO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88A55F0", Offset = "0x88A41F0", VA = "0x1888A55F0")]
		public void CDSDRZUOPXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88A5A00", Offset = "0x88A4600", VA = "0x1888A5A00")]
		public float EGSRFGWOZTK([In] (FFMGBURXUAH Start, FFMGBURXUAH End) limb)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88A5AB0", Offset = "0x88A46B0", VA = "0x1888A5AB0")]
		public void MIQMSNOJEVK([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88A6C00", Offset = "0x88A5800", VA = "0x1888A6C00")]
		private Vector3 YXAICEDQZWU([In] (FFMGBURXUAH Start, FFMGBURXUAH End) limb)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88A6D30", Offset = "0x88A5930", VA = "0x1888A6D30")]
		public LYBHQCHKOIF()
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
		[Cpp2IlInjected.Address(RVA = "0x88A4080", Offset = "0x88A2C80", VA = "0x1888A4080")]
		public string GetAvatarSystemIdentifier(string playerName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88A40D0", Offset = "0x88A2CD0", VA = "0x1888A40D0")]
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
		public bool DCRFLXRZWFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x85EAB30", Offset = "0x85E9730", VA = "0x1885EAB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool RDEMEQTOOSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x85EAB40", Offset = "0x85E9740", VA = "0x1885EAB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88A4120", Offset = "0x88A2D20", VA = "0x1888A4120")]
		public AvatarSystemUpdateState FDTRSDISJFV(Vector3 a)
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
		public GameObject FirstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GameObject ThirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Renderer[] WatchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public WERZWYBEDOI LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public WERZWYBEDOI LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public WERZWYBEDOI LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public WERZWYBEDOI LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public WERZWYBEDOI RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public WERZWYBEDOI RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public WERZWYBEDOI RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public WERZWYBEDOI RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AvatarBodyPartShapesManager AvatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Transform RightHipSlotAnchor;
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct AvatarSystemUpdateRateState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public bool IsPlayerVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public UpdateLOD DistanceBand;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct AvatarSystemUpdateState
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class YKCHGKSQPHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public readonly bool RYFYCXFBNOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public readonly bool CIZMKEJYKIU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public readonly bool LSTLOUHICXD;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x88A92B0", Offset = "0x88A7EB0", VA = "0x1888A92B0")]
			public YKCHGKSQPHB(bool a, bool b, bool c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public float DeltaTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public bool IsLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float DesiredAvatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Vector3 PlayerUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Vector3 ForwardYawReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Vector3? TorsoForwardOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Vector3? PelvisAnchorPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool IsPlayerSteering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public bool IsPlayerSeated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public bool IsPlayerFlying;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public bool IsPlayerWallClimbing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Vector3? WallClimbNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool IsPlayerWallRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Vector3? WallRunWallTangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public bool IsPlayerClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Vector3? ClamberWallNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public float ClamberTimeRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Vector3? PlayerSteeringVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool IsPlayerFalling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool IsPlayerStartingSlide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool IsPlayerSliding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public bool IsPlayerLanding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public bool IsPlayerSeatedInSittingPosture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public bool IsPlayerWallRunOnRightSide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool IsPlayerStartingJump;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public bool IsPlayerStartingTeleport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public bool IsPlayerTeleporting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public bool IsPlayerCrouching;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public bool IsPlayerProne;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Vector3? ProneNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public HandGestureType RightHandGestureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HandGestureType LeftHandGestureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public float RightHandIKWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float LeftHandIKWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AnimationPoseType LeftHandAnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AnimationPoseType RightHandAnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool IsThirdPersonCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public bool IsPlayerUsingFullBodyCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public bool ShowHandsWhenGrabbing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float GroundOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public float GroundOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public float HeelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AvatarStance IdleStance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public float IdleStanceLeftRightBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public FullBodyAnimationOverride UGCOverideAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public YKCHGKSQPHB DiagnosticOnlyState;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool QBDPRGQXUVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88A4700", Offset = "0x88A3300", VA = "0x1888A4700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NMSADJLAQDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x88A46F0", Offset = "0x88A32F0", VA = "0x1888A46F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88A42D0", Offset = "0x88A2ED0", VA = "0x1888A42D0")]
		public void Rotate(Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class WTHOYHKPKAR
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88A9270", Offset = "0x88A7E70", VA = "0x1888A9270")]
		public static AvatarBodyPart AWDPHQLUJLA(this FHZGNEPHGZA a)
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88A9290", Offset = "0x88A7E90", VA = "0x1888A9290")]
		public static void PBEEJLPDMBE(this FHZGNEPHGZA a, AvatarBodyPart b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class FZHMFDUSROL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88A4900", Offset = "0x88A3500", VA = "0x1888A4900")]
		public static bool ZNGPXJSLKBU(this KIRITOEHSDL a, EJOQRXHTGDS b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88A4710", Offset = "0x88A3310", VA = "0x1888A4710")]
		public static bool UKFCRODHTSE(this KIRITOEHSDL a, CTHAAJUENRD b)
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
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			EnabledForFullBody,
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			EnabledForModernBeanBody
		}

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private const string ENNNUOCBKHP = "Avatars.DisableFullBodySpecificColliders";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private ZDCVOOTPXNU EHOHTEXGKKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private List<Collider> XYXWXDRXLRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private List<Collider> SCFVUVOKAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private List<Collider> CTRFJMSQAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private ColliderEnabledState? AKQTWTHARCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private EDFELDUZHLG XLMRJPQOBRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private Collider[] FullBodyOnlyColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] DNINJKHURIF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> XVJSJYOLITN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x88A8610", Offset = "0x88A7210", VA = "0x1888A8610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<Collider> IEYRAUXNPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x88A8630", Offset = "0x88A7230", VA = "0x1888A8630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Collider> QYLPOPOFTFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x88A8650", Offset = "0x88A7250", VA = "0x1888A8650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private ZDCVOOTPXNU FSWXSBPZMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x88A8560", Offset = "0x88A7160", VA = "0x1888A8560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool MNXBJWRJYRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1FF6060", Offset = "0x1FF4C60", VA = "0x181FF6060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88A76A0", Offset = "0x88A62A0", VA = "0x1888A76A0")]
		private void KKTJXVMWRUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88A7600", Offset = "0x88A6200", VA = "0x1888A7600")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88A85F0", Offset = "0x88A71F0", VA = "0x1888A85F0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer skinnedMeshRenderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88A8180", Offset = "0x88A6D80", VA = "0x1888A8180")]
		public void SetCollidersEnabled(ColliderEnabledState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88A7D40", Offset = "0x88A6940", VA = "0x1888A7D40")]
		public void ReparentBonesUnderOtherBoneCollection(ZDCVOOTPXNU otherBoneCollection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88A7AC0", Offset = "0x88A66C0", VA = "0x1888A7AC0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public PlayerAvatarColliders()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SKCCXNYVAHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Transform IKAYAEHNBRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Transform JZYVOXYBBXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Transform ZLCPOIIGFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Transform YWSADGWRYMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Transform BHAAAZSHRJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Transform NIRJYYRAERH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Transform EJRPYCLOLSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Transform MUBFQHYZRNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Transform CQTHOWLFFVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private PositionAndRotation GYCFVGTCNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private PositionAndRotation BXHQCXODNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private PositionAndRotation HPTUADWOWOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private PositionAndRotation LALEJIVYKWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private PositionAndRotation ATNTRMTOUJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private PositionAndRotation NBUULJYIQAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private PositionAndRotation OIRPYLCOKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private PositionAndRotation DFUVNDJUSIN;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88A8E10", Offset = "0x88A7A10", VA = "0x1888A8E10")]
		public void Initialize(Transform handRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88A8670", Offset = "0x88A7270", VA = "0x1888A8670")]
		public void BRUKVYNUGSG(HandLogicOffsets a, HandType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88A9020", Offset = "0x88A7C20", VA = "0x1888A9020")]
		public void KIURMEEYCLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public SKCCXNYVAHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class PFKDQKZFDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Transform AUQARIZSXMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Transform BVHBXGEXTMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Transform KSCWGLKKISP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Transform TMQJCGBCAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Transform LFXCCYVFZVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private PositionAndRotation QTGYFCTGMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private PositionAndRotation FUKMNTJYETG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private PositionAndRotation UVPQSFAJFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private PositionAndRotation UAVAXTFRBQF;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88A7140", Offset = "0x88A5D40", VA = "0x1888A7140")]
		public void Initialize(Transform headRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88A7400", Offset = "0x88A6000", VA = "0x1888A7400")]
		public void RULKJMVGZVB(HeadLogicOffsets a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88A7270", Offset = "0x88A5E70", VA = "0x1888A7270")]
		public void MMMPRXVGBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public PFKDQKZFDAN()
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
