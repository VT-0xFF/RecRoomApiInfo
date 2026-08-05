using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
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
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x83DECF0", Offset = "0x83DDAF0", VA = "0x1883DECF0")]
		public NullableAttribute(byte P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class ZFVIOLRNVSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly string JYESMTESOYH;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83E0730", Offset = "0x83DF530", VA = "0x1883E0730")]
		public static AvatarSystemUpdateState DROTLMPJOFD()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83E0780", Offset = "0x83DF580", VA = "0x1883E0780")]
		public static AvatarSystemInitState KWZDFZNBDUX(AvatarBodyType a, Transform b, Transform c, AvatarConfiguration d, Animator e, VRIK f, GameObject[] g, Transform h, AvatarSkinAssetItem i, AssetReference j, AssetReference k, AssetReference l, AssetReference m, GameObject n, GameObject o, GameObject p, SkinnedMeshRenderer q, AvatarSkinnedMeshBoneOrderRemapsData r, Material s, Material t, Material u, Texture2D v, Material w, Material x, Shader y, Shader z, Transform ba, Transform bb, Transform bc, Transform bd, Transform be, Transform bf, Renderer[] bg, UFYYEJVXETJ bh, UFYYEJVXETJ bi, UFYYEJVXETJ bj, UFYYEJVXETJ bk, UFYYEJVXETJ bl, UFYYEJVXETJ bm, UFYYEJVXETJ bn, UFYYEJVXETJ bo, Transform bp, Transform bq, Transform br, Transform bs, GameObject bt, GameObject bu, AvatarBodyPartShapesManager bv, Transform bw, Transform bx, Transform by, Transform bz, Transform ca)
		{
			return default(AvatarSystemInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83E0CD0", Offset = "0x83DFAD0", VA = "0x1883E0CD0")]
		public static AvatarSystemPlayerSetupState QIKXZXYQXOP(string a, bool b, bool c, AvatarSystemUpdateDriver d, Func<AvatarSystemUpdateRateState> e, Func<Vector3, AvatarSystemUpdateState> f, RigidbodyEx g, Transform h, Transform i, Transform j, Transform k, Transform l, float m, float n, PlayerAvatarColliders o, SkinnedMeshRenderer[] p, SkinnedMeshRenderer[] q, SkinnedMeshRenderer[] r, SkinnedMeshRenderer[] s)
		{
			return default(AvatarSystemPlayerSetupState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83E05C0", Offset = "0x83DF3C0", VA = "0x1883E05C0")]
		public static PositionAndRotation BSIVQQGOEKK(Transform a, Transform b)
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83E02A0", Offset = "0x83DF0A0", VA = "0x1883E02A0")]
		public static void ANSTXPDPRZB(Transform a, Transform b, PositionAndRotation c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface WOEAPVEVDYX
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Transform RGLPWOKCTFW
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KOBSDRYUSZE : WOEAPVEVDYX
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform RGLPWOKCTFW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 WDYDPSOSCJA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x179CEC0", Offset = "0x179BCC0", VA = "0x18179CEC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x179CEE0", Offset = "0x179BCE0", VA = "0x18179CEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float? ZMZSHFOSOPH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x11D0610", Offset = "0x11CF410", VA = "0x1811D0610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xE8E100", Offset = "0xE8CF00", VA = "0x180E8E100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public KOBSDRYUSZE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class IXKLUMTIEEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected readonly KOBSDRYUSZE FJTIMKLJHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly KOBSDRYUSZE FGFJVPWRZHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly KOBSDRYUSZE LUBXRYMJYDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly KOBSDRYUSZE FBFVEQFMVWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly KOBSDRYUSZE BNGMUDMRDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly KOBSDRYUSZE XOSBETKYPGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected readonly KOBSDRYUSZE KUTLJYLYKZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		protected readonly KOBSDRYUSZE EYIZIJCFPMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected readonly KOBSDRYUSZE PGPAMCGMRSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		protected readonly KOBSDRYUSZE YQOJAPWAGGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		protected readonly KOBSDRYUSZE YLAYQKXWDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected readonly KOBSDRYUSZE QYINGWRUENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected readonly KOBSDRYUSZE BMFSCYWFBKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected KOBSDRYUSZE WIIDQFNRTPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly KOBSDRYUSZE QZLQJXTVIWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly KOBSDRYUSZE MBEQNPEBWYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly KOBSDRYUSZE FGFOTHNOEZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected KOBSDRYUSZE UDYYHLTKCYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly KOBSDRYUSZE WBPSUOCORIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected readonly KOBSDRYUSZE GAPCAFVGQTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		protected readonly KOBSDRYUSZE GYCYLAMWBVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		protected ReadOnlyCollection<KOBSDRYUSZE> POTIJHQVREV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Transform OZHZXKOBAOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private (KOBSDRYUSZE Start, KOBSDRYUSZE End)[] YXVXVRPHPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Dictionary<string, KOBSDRYUSZE> IINWPIMQAOL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public WOEAPVEVDYX HSTPSPZSXYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public WOEAPVEVDYX VYAAFWTCAKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public WOEAPVEVDYX XPRCLLDZZTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public WOEAPVEVDYX FCWJQQBCYRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public WOEAPVEVDYX GQQJCQXCBNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public WOEAPVEVDYX FKBCQPCDWHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public WOEAPVEVDYX KPIXRRPDNUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAC63E0", Offset = "0xAC51E0", VA = "0x180AC63E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public WOEAPVEVDYX CNNNJLVMBLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAC6140", Offset = "0xAC4F40", VA = "0x180AC6140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public WOEAPVEVDYX ZIWQCLAYQXE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAC63F0", Offset = "0xAC51F0", VA = "0x180AC63F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83DC140", Offset = "0x83DAF40", VA = "0x1883DC140")]
		public void FRJBZGOIBGC(VRIK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83DD430", Offset = "0x83DC230", VA = "0x1883DD430")]
		private void LOKOJQFUEGJ(Transform a, KOBSDRYUSZE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83DD7E0", Offset = "0x83DC5E0", VA = "0x1883DD7E0")]
		public KOBSDRYUSZE YMARATINFLR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83DD020", Offset = "0x83DBE20", VA = "0x1883DD020")]
		public void IXQJQYWFDED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83DD7A0", Offset = "0x83DC5A0", VA = "0x1883DD7A0")]
		public float YLPKXBYDEPP([In] (KOBSDRYUSZE Start, KOBSDRYUSZE End) limb)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83DD4C0", Offset = "0x83DC2C0", VA = "0x1883DD4C0")]
		public void NHCKVDWHPBF([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83DD670", Offset = "0x83DC470", VA = "0x1883DD670")]
		private Vector3 ODESPKHAEFL([In] (KOBSDRYUSZE Start, KOBSDRYUSZE End) limb)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83DD850", Offset = "0x83DC650", VA = "0x1883DD850")]
		public IXKLUMTIEEI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83DBA20", Offset = "0x83DA820", VA = "0x1883DBA20")]
		public string GetAvatarSystemIdentifier(string playerName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83DBA70", Offset = "0x83DA870", VA = "0x1883DBA70")]
		public AvatarSystemConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum AvatarSystemUpdateDriver
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Input,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		AnimationPlayback,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		HolotarPreviewOrPlayback
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum AvatarStance
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Medium,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Cute,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Low,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Narrow,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Narrow2,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		Wide,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		HipShift,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Slouch,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		NumStances
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct AvatarSystemPlayerSetupState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public string PlayerAvatarName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool IsPlayerUsingScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool IsPlayerLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float PlayerHeadRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float PlayerMaxCapsuleHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AvatarSystemUpdateDriver UpdateDriver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<AvatarSystemUpdateRateState> GetUpdateRateState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Func<Vector3, AvatarSystemUpdateState> GetUpdateStateFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public RigidbodyEx OriginTrackedSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Transform Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public Transform MovementTrackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public Transform HeadIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Transform LeftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Transform RightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[FormerlySerializedAs("PlayerAvatarFullBodyColliders")]
		[FormerlySerializedAs("playerAvatarModernBodyColliders")]
		public PlayerAvatarColliders playerAvatarColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public SkinnedMeshRenderer[] CurrentThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public SkinnedMeshRenderer[] NextThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public SkinnedMeshRenderer[] CurrentFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public SkinnedMeshRenderer[] NextFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool GYQNTNVVTEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x80CAAD0", Offset = "0x80C98D0", VA = "0x1880CAAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool KINDTTEPNVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x80CAAE0", Offset = "0x80C98E0", VA = "0x1880CAAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83DBAC0", Offset = "0x83DA8C0", VA = "0x1883DBAC0")]
		public AvatarSystemUpdateState ZTBAVWBBSDY(Vector3 a)
		{
			return default(AvatarSystemUpdateState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct AvatarSystemInitState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AvatarBodyType AvatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Transform RootTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Transform DeformRigRootTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AvatarConfiguration AvatarConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public VRIK SkeletonVRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public GameObject[] HideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Transform HeadAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AvatarSkinAssetItem PotatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AssetReference SkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AssetReference TorsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AssetReference LegsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AssetReference TorsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GameObject AllBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public GameObject FirstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public GameObject ThirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Texture2D BodyEmissiveMapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Renderer[] WatchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public UFYYEJVXETJ LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public UFYYEJVXETJ LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public UFYYEJVXETJ LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public UFYYEJVXETJ LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public UFYYEJVXETJ RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public UFYYEJVXETJ RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public UFYYEJVXETJ RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public UFYYEJVXETJ RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AvatarBodyPartShapesManager AvatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Transform RightHipSlotAnchor;
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AvatarSystemUpdateRateState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool IsPlayerVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public UpdateLOD DistanceBand;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct AvatarSystemUpdateState
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class CJINWFUNWZO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public readonly bool JROUMQVFYWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public readonly bool FCHMVPTSUNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public readonly bool QRTEOHQNSAK;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83DC0B0", Offset = "0x83DAEB0", VA = "0x1883DC0B0")]
			public CJINWFUNWZO(bool a, bool b, bool c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float DeltaTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public bool IsLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float DesiredAvatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Vector3 PlayerUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Vector3 ForwardYawReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Vector3? TorsoForwardOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Vector3? PelvisAnchorPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool IsPlayerSteering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool IsPlayerSeated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool IsPlayerFlying;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool IsPlayerWallClimbing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Vector3? WallClimbNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool IsPlayerWallRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Vector3? WallRunWallTangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public bool IsPlayerClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3? ClamberWallNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public float ClamberTimeRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Vector3? PlayerSteeringVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public bool IsPlayerFalling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public bool IsPlayerStartingSlide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public bool IsPlayerSliding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public bool IsPlayerLanding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public bool IsPlayerSeatedInSittingPosture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public bool IsPlayerWallRunOnRightSide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public bool IsPlayerStartingJump;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool IsPlayerStartingTeleport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public bool IsPlayerTeleporting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public bool IsPlayerCrouching;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public bool IsPlayerProne;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Vector3? ProneNormal;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public HandGestureType RightHandGestureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HandGestureType LeftHandGestureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public float RightHandIKWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public float LeftHandIKWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public AnimationPoseType LeftHandAnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AnimationPoseType RightHandAnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public bool IsThirdPersonCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public bool IsPlayerUsingFullBodyCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public bool ShowHandsWhenGrabbing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float GroundOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public float GroundOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public float HeelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AvatarStance IdleStance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float IdleStanceLeftRightBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public FullBodyAnimationOverride UGCOverideAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CJINWFUNWZO DiagnosticOnlyState;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PPGCNAZQTGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x83DC0A0", Offset = "0x83DAEA0", VA = "0x1883DC0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ELSNFDZLMIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83DC090", Offset = "0x83DAE90", VA = "0x1883DC090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83DBC70", Offset = "0x83DAA70", VA = "0x1883DBC70")]
		public void Rotate(Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class IMHAKQUQIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83DC120", Offset = "0x83DAF20", VA = "0x1883DC120")]
		public static AvatarBodyPart XAUMIAWZZNH(this NOQAHKXACAB a)
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83DC100", Offset = "0x83DAF00", VA = "0x1883DC100")]
		public static void FHVRCGOASPD(this NOQAHKXACAB a, AvatarBodyPart b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class NDHMFDJTZWQ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83DDC60", Offset = "0x83DCA60", VA = "0x1883DDC60")]
		public static bool ABMKIESNEIT(this UBHZIHBGLJA a, UKUNFBVHYIL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83DDDA0", Offset = "0x83DCBA0", VA = "0x1883DDDA0")]
		public static bool WJAOIQSGOTN(this UBHZIHBGLJA a, RHCRJWPAXMM b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class PlayerAvatarColliders : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum ColliderEnabledState
		{
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			EnabledForFullBody,
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			EnabledForModernBeanBody
		}

		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private const string PPFSMYAVDPU = "Avatars.DisableFullBodySpecificColliders";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private XESQFQRBWDN MSWZZZZYIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private List<Collider> EFNAWDJPNZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private List<Collider> NFPWNTKNDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private List<Collider> PJDUPMVJNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private ColliderEnabledState? TFLCKLZYUPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private MNPPKFJRFBH PTPHNIWKITR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Collider[] FullBodyOnlyColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] LJHZUOVLELG;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> DTQBLSUBSGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x83DFD80", Offset = "0x83DEB80", VA = "0x1883DFD80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<Collider> OUOCIJMNWBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x83DFDA0", Offset = "0x83DEBA0", VA = "0x1883DFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Collider> LVIMJSSIINY
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x83DFDC0", Offset = "0x83DEBC0", VA = "0x1883DFDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private XESQFQRBWDN TIBNZGEWAMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x83DEE10", Offset = "0x83DDC10", VA = "0x1883DEE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool TCFGLMLVVLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD7EA80", Offset = "0xD7D880", VA = "0x180D7EA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83DEEA0", Offset = "0x83DDCA0", VA = "0x1883DEEA0")]
		private void PJXAYYGJXON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83DED70", Offset = "0x83DDB70", VA = "0x1883DED70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83DFD60", Offset = "0x83DEB60", VA = "0x1883DFD60")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer skinnedMeshRenderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83DF980", Offset = "0x83DE780", VA = "0x1883DF980")]
		public void SetCollidersEnabled(ColliderEnabledState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83DF540", Offset = "0x83DE340", VA = "0x1883DF540")]
		public void ReparentBonesUnderOtherBoneCollection(XESQFQRBWDN otherBoneCollection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83DF2C0", Offset = "0x83DE0C0", VA = "0x1883DF2C0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public PlayerAvatarColliders()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NPTVVAIONGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Transform? AMZTPZUBTDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Transform? OYQBUXMSXFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Transform? UJTXHPJHOZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Transform? JDSTUTDTKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Transform? TSSSBYVJWVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Transform? IVNSRUMBSGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Transform? XMZFMUVNKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Transform? FPRYBDFLGHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Transform? FEQTIICEAXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Transform? LNVGAQGSUXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private PositionAndRotation? KMIDXGJBUSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private PositionAndRotation? GVPWRUXYKXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private PositionAndRotation? ESKOTPWWXQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private PositionAndRotation? HEXHMTOFPMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private PositionAndRotation? OMGVXDBEEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private PositionAndRotation? ZLJDAJEIUEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private PositionAndRotation? NYONPMTYXEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private PositionAndRotation? XPLBRSNUCSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private PositionAndRotation? UMRQNDZAIJG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83DE8A0", Offset = "0x83DD6A0", VA = "0x1883DE8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83DE8F0", Offset = "0x83DD6F0", VA = "0x1883DE8F0")]
		public void Initialize(Transform handRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83DE7D0", Offset = "0x83DD5D0", VA = "0x1883DE7D0")]
		public void FRAZURHWLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83DDF90", Offset = "0x83DCD90", VA = "0x1883DDF90")]
		public void CJGPWXZTVFF(HandLogicOffsets? a, HandType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83DEAE0", Offset = "0x83DD8E0", VA = "0x1883DEAE0")]
		public void TXSSXNGFAAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public NPTVVAIONGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83DE9D0", Offset = "0x83DD7D0", VA = "0x1883DE9D0")]
		[CompilerGenerated]
		private void PZNGGETMTFY(Transform? a, PositionAndRotation? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83DEC00", Offset = "0x83DDA00", VA = "0x1883DEC00")]
		[CompilerGenerated]
		private void YSXNMFXNWKF(Transform? a, [In] PositionAndRotation? posAndRot)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class UGKKTFDAZQM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Transform AEVRKTTRPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Transform OSYUOEMTTXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Transform KGTDRXKCFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Transform QJQJLGJKFUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private Transform ETCIEPLSJQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private PositionAndRotation EZJXZHCJZVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private PositionAndRotation JJMDCLZEALX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private PositionAndRotation NCMGITLCOAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private PositionAndRotation YIYPLSHOWRE;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83DFDE0", Offset = "0x83DEBE0", VA = "0x1883DFDE0")]
		public void Initialize(Transform headRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83DFF10", Offset = "0x83DED10", VA = "0x1883DFF10")]
		public void SZMUMSMIUFM(HeadLogicOffsets a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83E0110", Offset = "0x83DEF10", VA = "0x1883E0110")]
		public void YFORICALOZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public UGKKTFDAZQM()
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
