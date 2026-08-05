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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x82EDD60", Offset = "0x82ECF60", VA = "0x1882EDD60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class EBXWVCGCCUM
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly string KLTIBSORFUX;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82ECBE0", Offset = "0x82EBDE0", VA = "0x1882ECBE0")]
		public static AvatarSystemUpdateState VWVJFDVNOOF()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82EC390", Offset = "0x82EB590", VA = "0x1882EC390")]
		public static AvatarSystemInitState GUOGVEIKPZB(AvatarBodyType a, Transform b, Transform c, AvatarConfiguration d, Animator e, VRIK f, GameObject[] g, Transform h, AvatarSkinAssetItem i, AssetReference j, AssetReference k, AssetReference l, AssetReference m, GameObject n, GameObject o, GameObject p, SkinnedMeshRenderer q, AvatarSkinnedMeshBoneOrderRemapsData r, Material s, Material t, Material u, Texture2D v, Material w, Material x, Shader y, Shader z, Transform ba, Transform bb, Transform bc, Transform bd, Transform be, Transform bf, Renderer[] bg, ABVLWIFRBHR bh, ABVLWIFRBHR bi, ABVLWIFRBHR bj, ABVLWIFRBHR bk, ABVLWIFRBHR bl, ABVLWIFRBHR bm, ABVLWIFRBHR bn, ABVLWIFRBHR bo, Transform bp, Transform bq, Transform br, Transform bs, GameObject bt, GameObject bu, AvatarBodyPartShapesManager bv, Transform bw, Transform bx, Transform by, Transform bz, Transform ca)
		{
			return default(AvatarSystemInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82EC8E0", Offset = "0x82EBAE0", VA = "0x1882EC8E0")]
		public static AvatarSystemPlayerSetupState QNFCUAUTNMH(string a, bool b, bool c, AvatarSystemUpdateDriver d, Func<AvatarSystemUpdateRateState> e, Func<Vector3, AvatarSystemUpdateState> f, RigidbodyEx g, Transform h, Transform i, Transform j, Transform k, Transform l, float m, float n, PlayerAvatarColliders o, SkinnedMeshRenderer[] p, SkinnedMeshRenderer[] q, SkinnedMeshRenderer[] r, SkinnedMeshRenderer[] s)
		{
			return default(AvatarSystemPlayerSetupState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82ECA70", Offset = "0x82EBC70", VA = "0x1882ECA70")]
		public static PositionAndRotation RRKJSCVWMNY(Transform a, Transform b)
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82ECC30", Offset = "0x82EBE30", VA = "0x1882ECC30")]
		public static void ZVBTNCKYWKH(Transform a, Transform b, PositionAndRotation c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface OGQGJPDTCKT
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Transform HUSVRZMONUM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class LUFSNSLNEJA : OGQGJPDTCKT
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform HUSVRZMONUM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 AEZEPYSMJZA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1756090", Offset = "0x1755290", VA = "0x181756090", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1756020", Offset = "0x1755220", VA = "0x181756020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float? RGIOFTTWXKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x1196200", Offset = "0x1195400", VA = "0x181196200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xE5A7D0", Offset = "0xE599D0", VA = "0x180E5A7D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public LUFSNSLNEJA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SKNGBARXWSQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected readonly LUFSNSLNEJA KZXMDWARBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly LUFSNSLNEJA QIBDJXJCSBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly LUFSNSLNEJA NZVURAQLCNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly LUFSNSLNEJA GOHSFIDVYQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly LUFSNSLNEJA IIGETWCDTGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly LUFSNSLNEJA KFEHBFWFAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected readonly LUFSNSLNEJA WNTPLBTBEQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		protected readonly LUFSNSLNEJA CGLHQSAFDAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected readonly LUFSNSLNEJA NCBPSGLULSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		protected readonly LUFSNSLNEJA CBRZYQTGMXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		protected readonly LUFSNSLNEJA TATKTIKTTZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected readonly LUFSNSLNEJA KQHRSLSDJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected readonly LUFSNSLNEJA OPBLEENGFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected LUFSNSLNEJA GSGQNDYHMRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly LUFSNSLNEJA WTOYRPIRIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly LUFSNSLNEJA IXCOLTSLDUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly LUFSNSLNEJA GZIVKBVYQOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected LUFSNSLNEJA KLAABMZBCYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly LUFSNSLNEJA GDDYUIADPTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected readonly LUFSNSLNEJA JRUMXEGJNTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		protected readonly LUFSNSLNEJA CNWAYFWJNBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		protected ReadOnlyCollection<LUFSNSLNEJA> TMKIWNIOXER;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Transform KHFWPXBGSTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private (LUFSNSLNEJA Start, LUFSNSLNEJA End)[] QAJIXHKSFWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Dictionary<string, LUFSNSLNEJA> GHUOVIDPHJF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public OGQGJPDTCKT IIBJBGIGGUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OGQGJPDTCKT PHJEIIEXJBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OGQGJPDTCKT QLCHFOSDAVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OGQGJPDTCKT RIETESDNHXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public OGQGJPDTCKT KUBRRCMYBNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OGQGJPDTCKT RXKJWHWPOOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OGQGJPDTCKT TSOQRNNGUJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xABC9A0", Offset = "0xABBBA0", VA = "0x180ABC9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public OGQGJPDTCKT OPOFAPNKQRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xABC970", Offset = "0xABBB70", VA = "0x180ABC970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OGQGJPDTCKT CDBOHJWHMIO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xABF5C0", Offset = "0xABE7C0", VA = "0x180ABF5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82EF680", Offset = "0x82EE880", VA = "0x1882EF680")]
		public void LTBLUXNRRMK(VRIK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82F0CA0", Offset = "0x82EFEA0", VA = "0x1882F0CA0")]
		private void WQUOLLULLWZ(Transform a, LUFSNSLNEJA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82F0A90", Offset = "0x82EFC90", VA = "0x1882F0A90")]
		public LUFSNSLNEJA TKHEVWLQUCL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82F0690", Offset = "0x82EF890", VA = "0x1882F0690")]
		public void PHCVKBVSVJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82EF640", Offset = "0x82EE840", VA = "0x1882EF640")]
		public float GASJTLAXPGB([In] (LUFSNSLNEJA Start, LUFSNSLNEJA End) limb)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82F0B00", Offset = "0x82EFD00", VA = "0x1882F0B00")]
		public void WKHWHLFMXTV([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82F0560", Offset = "0x82EF760", VA = "0x1882F0560")]
		private Vector3 LWXQUVIGUZX([In] (LUFSNSLNEJA Start, LUFSNSLNEJA End) limb)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82F0D30", Offset = "0x82EFF30", VA = "0x1882F0D30")]
		public SKNGBARXWSQ()
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
		[Cpp2IlInjected.Address(RVA = "0x82EBD00", Offset = "0x82EAF00", VA = "0x1882EBD00")]
		public string GetAvatarSystemIdentifier(string playerName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82EBD50", Offset = "0x82EAF50", VA = "0x1882EBD50")]
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
		public bool JUABPLBQLMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7FE2D00", Offset = "0x7FE1F00", VA = "0x187FE2D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ZCRXONCWLLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7FE2D10", Offset = "0x7FE1F10", VA = "0x187FE2D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82EBDA0", Offset = "0x82EAFA0", VA = "0x1882EBDA0")]
		public AvatarSystemUpdateState MPOGGXWYJXA(Vector3 a)
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
		public ABVLWIFRBHR LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public ABVLWIFRBHR LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public ABVLWIFRBHR LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public ABVLWIFRBHR LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public ABVLWIFRBHR RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public ABVLWIFRBHR RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public ABVLWIFRBHR RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public ABVLWIFRBHR RightKneeBendTargetController;

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
		public class LMTUSUKCXEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public readonly bool AVOXNHOQWAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public readonly bool YJNSRHPFSAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public readonly bool IZZEEDOQDSG;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x82EDD10", Offset = "0x82ECF10", VA = "0x1882EDD10")]
			public LMTUSUKCXEQ(bool a, bool b, bool c)
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
		public LMTUSUKCXEQ DiagnosticOnlyState;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool IXNTFADVROG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x82EBF50", Offset = "0x82EB150", VA = "0x1882EBF50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EOBVGXSIXWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x82EC380", Offset = "0x82EB580", VA = "0x1882EC380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82EBF60", Offset = "0x82EB160", VA = "0x1882EBF60")]
		public void Rotate(Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class AGRLLUUGIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82EBCE0", Offset = "0x82EAEE0", VA = "0x1882EBCE0")]
		public static AvatarBodyPart PJMIBJYXIRP(this VRDRGWMZESR a)
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82EBCC0", Offset = "0x82EAEC0", VA = "0x1882EBCC0")]
		public static void IJNRTVWZZRP(this VRDRGWMZESR a, AvatarBodyPart b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class PEACGHQNCRS
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82EDDE0", Offset = "0x82ECFE0", VA = "0x1882EDDE0")]
		public static bool HIHHMNHBUBV(this MHQVBDZAPHQ a, COPKHIGAUKL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82EDF20", Offset = "0x82ED120", VA = "0x1882EDF20")]
		public static bool JPMNWHKGWVV(this MHQVBDZAPHQ a, KTYWCOLBVEI b)
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
		private const string AKFMJRYQZLQ = "Avatars.DisableFullBodySpecificColliders";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private ZIIQOWXNUFV TUZNTWWESVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private List<Collider> ZTSFKKSOEFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private List<Collider> PWEZCHADCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private List<Collider> XISFKTOCZPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private ColliderEnabledState? XKFMKHRVAQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TSCPVZNNMEJ ECVZUXISQVB;

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
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] TYDTJLTMIEQ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> DTGIHKVDVPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x82EF120", Offset = "0x82EE320", VA = "0x1882EF120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<Collider> CDKWXPAVQVK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x82EF140", Offset = "0x82EE340", VA = "0x1882EF140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Collider> WBDRYJWAYLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x82EF160", Offset = "0x82EE360", VA = "0x1882EF160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private ZIIQOWXNUFV LRAQYRBNQQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x82EF070", Offset = "0x82EE270", VA = "0x1882EF070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool RBHXTLRLLOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD44530", Offset = "0xD43730", VA = "0x180D44530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82EEC50", Offset = "0x82EDE50", VA = "0x1882EEC50")]
		private void UWILOASQPOR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82EE110", Offset = "0x82ED310", VA = "0x1882EE110")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82EF100", Offset = "0x82EE300", VA = "0x1882EF100")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer skinnedMeshRenderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82EE870", Offset = "0x82EDA70", VA = "0x1882EE870")]
		public void SetCollidersEnabled(ColliderEnabledState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82EE430", Offset = "0x82ED630", VA = "0x1882EE430")]
		public void ReparentBonesUnderOtherBoneCollection(ZIIQOWXNUFV otherBoneCollection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82EE1B0", Offset = "0x82ED3B0", VA = "0x1882EE1B0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
		public PlayerAvatarColliders()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class IQIAFTWUJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Transform? OQQANHUSXAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Transform? GTNNCTFCHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Transform? KBYVABJSRGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Transform? ZAKBVWBRHVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Transform? OTMWSALAFLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Transform? XUGVWSAXDYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Transform? DODKHKFTLRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Transform? GYUMFGPPZRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Transform? TVJBALVSJZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Transform? PJDXWGSSPIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private PositionAndRotation? MXUOYNPOLXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private PositionAndRotation? FFPZQFICXSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private PositionAndRotation? NCSJHLRHMIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private PositionAndRotation? IKTCSLZFBDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private PositionAndRotation? EXYUFKJOJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private PositionAndRotation? NZLNEVYHRVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private PositionAndRotation? PJTWARMSSUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private PositionAndRotation? MOOLQTKKKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private PositionAndRotation? DDOIWDUXFPK;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool SKRCPBVXMIC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x82ED480", Offset = "0x82EC680", VA = "0x1882ED480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82ED0C0", Offset = "0x82EC2C0", VA = "0x1882ED0C0")]
		public void Initialize(Transform handRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82ED2C0", Offset = "0x82EC4C0", VA = "0x1882ED2C0")]
		public void RVNNQVHXYEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82ED4D0", Offset = "0x82EC6D0", VA = "0x1882ED4D0")]
		public void ZZLWZBMMDVZ(HandLogicOffsets? a, HandType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82ED1A0", Offset = "0x82EC3A0", VA = "0x1882ED1A0")]
		public void MPLZOZAITLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public IQIAFTWUJCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82ECFB0", Offset = "0x82EC1B0", VA = "0x1882ECFB0")]
		[CompilerGenerated]
		private void AHTFPUINVDQ(Transform? a, PositionAndRotation? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82ED390", Offset = "0x82EC590", VA = "0x1882ED390")]
		[CompilerGenerated]
		private void UMIUALUIHTL(Transform? a, [In] PositionAndRotation? posAndRot)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class RAHTNAHUZEY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Transform KSPZTFGLGRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Transform PQWKAIEGBGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Transform RPTHKPFHVUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Transform EWSENKYNEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private Transform FWNKPKNJKVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private PositionAndRotation SZNGNHCIUAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private PositionAndRotation UXOTAUJQMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private PositionAndRotation VTJFMAGEWXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private PositionAndRotation JEJXITXBBUG;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82EF380", Offset = "0x82EE580", VA = "0x1882EF380")]
		public void Initialize(Transform headRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82EF180", Offset = "0x82EE380", VA = "0x1882EF180")]
		public void IKBWGCSDKYS(HeadLogicOffsets a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82EF4B0", Offset = "0x82EE6B0", VA = "0x1882EF4B0")]
		public void WSIOTYONYJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public RAHTNAHUZEY()
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
