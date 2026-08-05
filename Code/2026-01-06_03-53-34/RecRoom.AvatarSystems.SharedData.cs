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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82046E0", Offset = "0x82030E0", VA = "0x1882046E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class JDKOZSNPYTB
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static readonly string PLCOTZSLEOO;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82036F0", Offset = "0x82020F0", VA = "0x1882036F0")]
		public static AvatarSystemUpdateState SEVNVKZLBWE()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8202D10", Offset = "0x8201710", VA = "0x188202D10")]
		public static AvatarSystemInitState JOOVIMUXSGS(AvatarBodyType a, Transform b, Transform c, AvatarConfiguration d, Animator e, VRIK f, GameObject[] g, Transform h, AvatarSkinAssetItem i, AssetReference j, AssetReference k, AssetReference l, AssetReference m, GameObject n, GameObject o, GameObject p, SkinnedMeshRenderer q, AvatarSkinnedMeshBoneOrderRemapsData r, Material s, Material t, Material u, Texture2D v, Material w, Material x, Shader y, Shader z, Transform ba, Transform bb, Transform bc, Transform bd, Transform be, Transform bf, Renderer[] bg, GXRHCUSEJGW bh, GXRHCUSEJGW bi, GXRHCUSEJGW bj, GXRHCUSEJGW bk, GXRHCUSEJGW bl, GXRHCUSEJGW bm, GXRHCUSEJGW bn, GXRHCUSEJGW bo, Transform bp, Transform bq, Transform br, Transform bs, GameObject bt, GameObject bu, AvatarBodyPartShapesManager bv, Transform bw, Transform bx, Transform by, Transform bz, Transform ca)
		{
			return default(AvatarSystemInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8203740", Offset = "0x8202140", VA = "0x188203740")]
		public static AvatarSystemPlayerSetupState WMSRUMBEZWQ(string a, bool b, bool c, AvatarSystemUpdateDriver d, Func<AvatarSystemUpdateRateState> e, Func<Vector3, AvatarSystemUpdateState> f, RigidbodyEx g, Transform h, Transform i, Transform j, Transform k, Transform l, float m, float n, PlayerAvatarColliders o, SkinnedMeshRenderer[] p, SkinnedMeshRenderer[] q, SkinnedMeshRenderer[] r, SkinnedMeshRenderer[] s)
		{
			return default(AvatarSystemPlayerSetupState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8203260", Offset = "0x8201C60", VA = "0x188203260")]
		public static PositionAndRotation NUBQOVYJPOX(Transform a, Transform b)
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82033D0", Offset = "0x8201DD0", VA = "0x1882033D0")]
		public static void PDMTFVAQSIS(Transform a, Transform b, PositionAndRotation c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface OXQMHXPUCNU
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		Transform YTQQQFYHIEF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class BNCEKXYLBXP : OXQMHXPUCNU
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform YTQQQFYHIEF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 GRVORXWVSKT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x17006D0", Offset = "0x16FF0D0", VA = "0x1817006D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x1700730", Offset = "0x16FF130", VA = "0x181700730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float? XAJUYKFJDKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x11404F0", Offset = "0x113EEF0", VA = "0x1811404F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xE0F380", Offset = "0xE0DD80", VA = "0x180E0F380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public BNCEKXYLBXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class OVBHJHMRRWX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected readonly BNCEKXYLBXP MOGQIBNFUZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected readonly BNCEKXYLBXP IMBLADWDHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected readonly BNCEKXYLBXP ZYHNDURJTZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly BNCEKXYLBXP XBZRLGFTMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected readonly BNCEKXYLBXP PDEZNTHBZBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected readonly BNCEKXYLBXP PMPUQZCJBVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected readonly BNCEKXYLBXP WSDHCDOQTMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		protected readonly BNCEKXYLBXP INGEUEQWIJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected readonly BNCEKXYLBXP GTCLFDZNNCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		protected readonly BNCEKXYLBXP IRYRLFLMXQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		protected readonly BNCEKXYLBXP KHOSKVIETWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		protected readonly BNCEKXYLBXP BCBWIVNRPYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		protected readonly BNCEKXYLBXP CDGIMOUBXRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected BNCEKXYLBXP VIQQKLQCQVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly BNCEKXYLBXP OUQGKHFVZGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly BNCEKXYLBXP MPAFKHTRYTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly BNCEKXYLBXP SCLRROBACAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected BNCEKXYLBXP XYKLIKNWCQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected readonly BNCEKXYLBXP CLRSUQKNFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		protected readonly BNCEKXYLBXP YQNAQMQPHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		protected readonly BNCEKXYLBXP JWTIRLDONTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		protected ReadOnlyCollection<BNCEKXYLBXP> GQJCPLSUFUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Transform ZFBZRCCBFEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private (BNCEKXYLBXP Start, BNCEKXYLBXP End)[] INPYEQAOUVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Dictionary<string, BNCEKXYLBXP> ZFLZYVHJWUY;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public OXQMHXPUCNU HKULJDENTIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OXQMHXPUCNU QHTGJNELRXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OXQMHXPUCNU BMSOJKRGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OXQMHXPUCNU FOYEHRYMHMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public OXQMHXPUCNU YLKJDMKRXYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OXQMHXPUCNU ONNOPXTHRRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xABF4A0", Offset = "0xABDEA0", VA = "0x180ABF4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OXQMHXPUCNU CJKMTJAGMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAB5160", Offset = "0xAB3B60", VA = "0x180AB5160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public OXQMHXPUCNU ZUIBQAUJQLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OXQMHXPUCNU POPPBIWOSOR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8204B00", Offset = "0x8203500", VA = "0x188204B00")]
		public void KUUVQGRXTMN(VRIK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82060F0", Offset = "0x8204AF0", VA = "0x1882060F0")]
		private void ZVXFLFLPAMQ(Transform a, BNCEKXYLBXP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8204A90", Offset = "0x8203490", VA = "0x188204A90")]
		public BNCEKXYLBXP KMFIVLLJEXE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8205B50", Offset = "0x8204550", VA = "0x188205B50")]
		public void VCLBAJDDLRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82059E0", Offset = "0x82043E0", VA = "0x1882059E0")]
		public float OWKSCJQCDGO([In] (BNCEKXYLBXP Start, BNCEKXYLBXP End) limb)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8205F50", Offset = "0x8204950", VA = "0x188205F50")]
		public void WSDGGFCPIKW([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8205A20", Offset = "0x8204420", VA = "0x188205A20")]
		private Vector3 UQFOUVWRVVM([In] (BNCEKXYLBXP Start, BNCEKXYLBXP End) limb)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8206180", Offset = "0x8204B80", VA = "0x188206180")]
		public OVBHJHMRRWX()
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
		[Cpp2IlInjected.Address(RVA = "0x82021C0", Offset = "0x8200BC0", VA = "0x1882021C0")]
		public string GetAvatarSystemIdentifier(string playerName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8202210", Offset = "0x8200C10", VA = "0x188202210")]
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
		public bool JKMDDRBEEYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B020", Offset = "0x7F09A20", VA = "0x187F0B020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool CQKJXOKGULF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B030", Offset = "0x7F09A30", VA = "0x187F0B030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8202260", Offset = "0x8200C60", VA = "0x188202260")]
		public AvatarSystemUpdateState XQWXFHFLSAB(Vector3 a)
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
		public GXRHCUSEJGW LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GXRHCUSEJGW LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public GXRHCUSEJGW LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public GXRHCUSEJGW LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public GXRHCUSEJGW RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public GXRHCUSEJGW RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GXRHCUSEJGW RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public GXRHCUSEJGW RightKneeBendTargetController;

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
		public class LTCWIYQJQKZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public readonly bool QZGKKOUSVTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public readonly bool IUHCAMGUYAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public readonly bool WGVUZETYZVF;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8203930", Offset = "0x8202330", VA = "0x188203930")]
			public LTCWIYQJQKZ(bool a, bool b, bool c)
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
		public LTCWIYQJQKZ DiagnosticOnlyState;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool UUNPUJFGKOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8202410", Offset = "0x8200E10", VA = "0x188202410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JTXKYYOMRCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8202420", Offset = "0x8200E20", VA = "0x188202420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8202430", Offset = "0x8200E30", VA = "0x188202430")]
		public void Rotate(Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class WBSYUVJPWJR
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8207620", Offset = "0x8206020", VA = "0x188207620")]
		public static AvatarBodyPart OMSXROGJWBC(this RLFEASYWAVG a)
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8207600", Offset = "0x8206000", VA = "0x188207600")]
		public static void EQQWSFAHCPS(this RLFEASYWAVG a, AvatarBodyPart b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class ORFXQLJETPX
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8204950", Offset = "0x8203350", VA = "0x188204950")]
		public static bool ZOPONVTZVDW(this DSVKDBMNMML a, VZVYRIFALVM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8204760", Offset = "0x8203160", VA = "0x188204760")]
		public static bool LYPKMSBLKKC(this DSVKDBMNMML a, KVICVKGLPQH b)
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
		private const string DPHCLDCPIFZ = "Avatars.DisableFullBodySpecificColliders";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private XDMFHUNJNNC AOMSQEQNYWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private List<Collider> SDQNAYZDOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private List<Collider> ELMINJGBEYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private List<Collider> YIDOGBPSCLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private ColliderEnabledState? BOQRGMUSZBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private VPWSVWWBFFU XTFGFXBOCBW;

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
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] YZEEGVZLSJZ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> RANDRZZUJZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x82075A0", Offset = "0x8205FA0", VA = "0x1882075A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<Collider> FVWYCVWYGRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x82075C0", Offset = "0x8205FC0", VA = "0x1882075C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Collider> MMRBPRNPQCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x82075E0", Offset = "0x8205FE0", VA = "0x1882075E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private XDMFHUNJNNC YJCOHRCOGEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8206630", Offset = "0x8205030", VA = "0x188206630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool QKMMEBXWXWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD20D00", Offset = "0xD1F700", VA = "0x180D20D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8206940", Offset = "0x8205340", VA = "0x188206940")]
		private void RZCZZYIYMZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8206590", Offset = "0x8204F90", VA = "0x188206590")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8207580", Offset = "0x8205F80", VA = "0x188207580")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer skinnedMeshRenderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82071A0", Offset = "0x8205BA0", VA = "0x1882071A0")]
		public void SetCollidersEnabled(ColliderEnabledState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8206D60", Offset = "0x8205760", VA = "0x188206D60")]
		public void ReparentBonesUnderOtherBoneCollection(XDMFHUNJNNC otherBoneCollection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82066C0", Offset = "0x82050C0", VA = "0x1882066C0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public PlayerAvatarColliders()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NXLGBXSMARS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Transform? BHWHRAZLTRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Transform? GLJFBFBOXSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Transform? AMXRWLDDAZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Transform? ARYVLBIOWJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Transform? APPSQFQVXOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Transform? BNRAUOOBWYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Transform? KJHQWEPBIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Transform? IJPRLELCVWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Transform? EVIXSTQGSCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Transform? MWUMRXZYZGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private PositionAndRotation? BYUZFRGGUDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private PositionAndRotation? ZQKXYBTSPWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private PositionAndRotation? VJFLYEXBZCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private PositionAndRotation? YFMZGXBKPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private PositionAndRotation? MHYAQFZKWJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private PositionAndRotation? AGUHACYCHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private PositionAndRotation? BWGGYWYJOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private PositionAndRotation? RXPSUTGMRLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private PositionAndRotation? JZCOHAFOSWJ;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool BXPTSGXIQZR
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x82044B0", Offset = "0x8202EB0", VA = "0x1882044B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82042E0", Offset = "0x8202CE0", VA = "0x1882042E0")]
		public void Initialize(Transform handRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8204610", Offset = "0x8203010", VA = "0x188204610")]
		public void YFPJWRPEXBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8203980", Offset = "0x8202380", VA = "0x188203980")]
		public void BHLUNTODKGU(HandLogicOffsets? a, HandType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82041C0", Offset = "0x8202BC0", VA = "0x1882041C0")]
		public void DMROBBJXMVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public NXLGBXSMARS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8204500", Offset = "0x8202F00", VA = "0x188204500")]
		[CompilerGenerated]
		private void RTUAXSICMKL(Transform? a, PositionAndRotation? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82043C0", Offset = "0x8202DC0", VA = "0x1882043C0")]
		[CompilerGenerated]
		private void LQAFCJMFGNQ(Transform? a, [In] PositionAndRotation? posAndRot)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class GUXPPSNEHEX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Transform WMSFUETWHXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Transform GMAEJPCFCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Transform IEKLUWTPGKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Transform BMZTFKLMNFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private Transform HIDBPAOQVOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private PositionAndRotation SISJNADQXUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private PositionAndRotation MDMJGFTMNFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private PositionAndRotation VDFILJGVDVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private PositionAndRotation IPKETWMGZLB;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82029E0", Offset = "0x82013E0", VA = "0x1882029E0")]
		public void Initialize(Transform headRoot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8202B10", Offset = "0x8201510", VA = "0x188202B10")]
		public void PZRRGYNEPPH(HeadLogicOffsets a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8202850", Offset = "0x8201250", VA = "0x188202850")]
		public void CFDXXOSUWVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GUXPPSNEHEX()
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
