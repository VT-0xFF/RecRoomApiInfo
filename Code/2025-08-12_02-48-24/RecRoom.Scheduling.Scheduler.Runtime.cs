using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8830", Offset = "0x8FC6E30", VA = "0x188FC8830", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB810", Offset = "0x8FC9E10", VA = "0x188FCB810", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2960290", Offset = "0x295E890", VA = "0x182960290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class CustomPlayerLoopInjector
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct EHIKLDNIALJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			[CompilerGenerated]
			private sealed class DANEIIAFJEN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public EAHCEJKIAAC.LONFDIGNGLH key;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
				public DANEIIAFJEN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8FBE4A0", Offset = "0x8FBCAA0", VA = "0x188FBE4A0")]
				internal void GLCPPPANGNC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000002")]
			public static IDisposable GIHKGDIIKFD;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8FBFCD0", Offset = "0x8FBE2D0", VA = "0x188FBFCD0")]
			public static PlayerLoopSystem OPNKDKOGPHB(EAHCEJKIAAC.LONFDIGNGLH HFLDIIIPBCG)
			{
				return default(PlayerLoopSystem);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct OBLGCNFBCIH
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class IKHENCEHDEM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public EAHCEJKIAAC.LONFDIGNGLH key;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
				public IKHENCEHDEM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x8FC51C0", Offset = "0x8FC37C0", VA = "0x188FC51C0")]
				internal void GLCPPPANGNC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8FC90C0", Offset = "0x8FC76C0", VA = "0x188FC90C0")]
			public static PlayerLoopSystem OPNKDKOGPHB(EAHCEJKIAAC.LONFDIGNGLH HFLDIIIPBCG)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly IDGHEFJHGEI FEFALLLFAGB;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8FBCF90", Offset = "0x8FBB590", VA = "0x188FBCF90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8FBE3C0", Offset = "0x8FBC9C0", VA = "0x188FBE3C0")]
		private static void OMCDDPPLBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD670", Offset = "0x8FBBC70", VA = "0x188FBD670")]
		private static void NEJGDDKMIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD170", Offset = "0x8FBB770", VA = "0x188FBD170")]
		private static void GJFCJLBNBOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD840", Offset = "0x8FBBE40", VA = "0x188FBD840")]
		private static void ODNIADLPPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6C10", Offset = "0x3BC5210", VA = "0x183BC6C10")]
		private static (PlayerLoopSystem, OFEPKEBEDCJ.NIOKKIHLGAL) LIJOICNDJHE<T>()
		{
			return default((PlayerLoopSystem, OFEPKEBEDCJ.NIOKKIHLGAL));
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD5D0", Offset = "0x8FBBBD0", VA = "0x188FBD5D0")]
		private static (PlayerLoopSystem, OFEPKEBEDCJ.NIOKKIHLGAL) LIJOICNDJHE(PlayerLoopSystem FMMLFDLDKHA)
		{
			return default((PlayerLoopSystem, OFEPKEBEDCJ.NIOKKIHLGAL));
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3BC6910", Offset = "0x3BC4F10", VA = "0x183BC6910")]
		private static (PlayerLoopSystem, OFEPKEBEDCJ.NIOKKIHLGAL) HCDNAOEAAEJ<T>()
		{
			return default((PlayerLoopSystem, OFEPKEBEDCJ.NIOKKIHLGAL));
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5090", Offset = "0x3BC3690", VA = "0x183BC5090")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) DFNHHAMNJFG<TParent, TSub>(EAHCEJKIAAC.LONFDIGNGLH HFLDIIIPBCG)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD010", Offset = "0x8FBB610", VA = "0x188FBD010")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) DFNHHAMNJFG(EAHCEJKIAAC.LONFDIGNGLH HFLDIIIPBCG, Type IGDHFGFJBMG, Type PIFNFFFJEJO)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EAHCEJKIAAC
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum LONFDIGNGLH
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		NetworkReceive,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		NetworkSend,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		OMPreGameplayUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		OMPrePhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		OMPostPhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		OMPostGameplayUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		OMPreNetworkReceive,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		OMNetworkReceive,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		OMPostNetworkReceive,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		OMNetworkSend,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		OMPostLateUpdate
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class JKBMGBJECEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly LONFDIGNGLH EKEHGHHEGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly GEELFAHLHFB EGCKLGCCKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long NHOINDJANCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long DEOPIOGNAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long DELMKOEMLKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int AOCMKACNEJB;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5910", Offset = "0x8FC3F10", VA = "0x188FC5910")]
		public JKBMGBJECEO(LONFDIGNGLH EEPFBCBOFJH, int NMBDPLPODMD = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8FC58F0", Offset = "0x8FC3EF0", VA = "0x188FC58F0")]
		public void HKPPJFKOANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8FC58A0", Offset = "0x8FC3EA0", VA = "0x188FC58A0")]
		public void FEJEDBEOBPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8FC57C0", Offset = "0x8FC3DC0", VA = "0x188FC57C0")]
		public void DEFODPIHCEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static LONFDIGNGLH[] LFIAJGEJJJC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static JKBMGBJECEO[] CJPNCGDMOJD;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8FBF210", Offset = "0x8FBD810", VA = "0x188FBF210")]
	public static JKBMGBJECEO IBCJOFENENG(LONFDIGNGLH HFLDIIIPBCG, int NMBDPLPODMD = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8FBF370", Offset = "0x8FBD970", VA = "0x188FBF370")]
	public static JKBMGBJECEO KDEBGBFHNEO(LONFDIGNGLH HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8FBF3E0", Offset = "0x8FBD9E0", VA = "0x188FBF3E0")]
	public static void OCEIDJPDPNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DDHJHHJMDPJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface CCLLNFBMIMB
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool ENBDCNOGIPE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IMDIPNPDNOK();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class JBDCGGEANBJ : CCLLNFBMIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Action CBDPHPPPDFI;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool ENBDCNOGIPE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
		public JBDCGGEANBJ(Action CBDPHPPPDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x13194B0", Offset = "0x1317AB0", VA = "0x1813194B0", Slot = "5")]
		public void IMDIPNPDNOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<CCLLNFBMIMB> OGMDEBDBNPH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool EHFAJNLFEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8FBEDA0", Offset = "0x8FBD3A0", VA = "0x188FBEDA0")]
	public static void NCMILIOBNHE(Action CBDPHPPPDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8FBE830", Offset = "0x8FBCE30", VA = "0x188FBE830")]
	private static void IEEBPIEKBHI(CCLLNFBMIMB CGHEIECFFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8FBEAA0", Offset = "0x8FBD0A0", VA = "0x188FBEAA0")]
	private static void KGDIEGAAFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8FBE6E0", Offset = "0x8FBCCE0", VA = "0x188FBE6E0")]
	private static void CLFLGPMCCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8FBEE40", Offset = "0x8FBD440", VA = "0x188FBEE40")]
	private static void ONLHLDMOKHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HILIGGFMKIL
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3870", Offset = "0x8FC1E70", VA = "0x188FC3870")]
	public static IDisposable FDAEFGEFIJO(this LGFFGBFJLCF HHPFOCCGJIF, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3900", Offset = "0x8FC1F00", VA = "0x188FC3900")]
	public static IDisposable MKIICHBDKEF(this LGFFGBFJLCF HHPFOCCGJIF, Action<float> NEJLJLKMLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8FC37F0", Offset = "0x8FC1DF0", VA = "0x188FC37F0")]
	public static IDisposable AJNECAGLLFN(this LGFFGBFJLCF HHPFOCCGJIF, Action<float> NEJLJLKMLAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LGGFJGFCKHA
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C590", Offset = "0x3E7AB90", VA = "0x183E7C590")]
	[APKFIPDHNMB]
	public static IDisposable JIBNOFMLOIK<T>(this T FOIJIDBLNAC, Action NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C3E0", Offset = "0x3E7A9E0", VA = "0x183E7C3E0")]
	[APKFIPDHNMB]
	public static IDisposable JIBNOFMLOIK<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C270", Offset = "0x3E7A870", VA = "0x183E7C270")]
	[APKFIPDHNMB]
	public static IDisposable FLHPFKIPOFF<T>(this T FOIJIDBLNAC, Action NEJLJLKMLAF, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C810", Offset = "0x3E7AE10", VA = "0x183E7C810")]
	[APKFIPDHNMB]
	public static IDisposable NJLNHFMMFAM<T>(this T FOIJIDBLNAC, Action NEJLJLKMLAF, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C810", Offset = "0x3E7AE10", VA = "0x183E7C810")]
	[APKFIPDHNMB]
	public static IDisposable NJLNHFMMFAM<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C840", Offset = "0x3E7AE40", VA = "0x183E7C840")]
	[APKFIPDHNMB]
	public static IDisposable OBDOAEFBKPA<T>(this T FOIJIDBLNAC, Action NEJLJLKMLAF, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C7A0", Offset = "0x3E7ADA0", VA = "0x183E7C7A0")]
	[APKFIPDHNMB]
	public static IDisposable LELILOBIMDF<T>(this T FOIJIDBLNAC, Action NEJLJLKMLAF, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C770", Offset = "0x3E7AD70", VA = "0x183E7C770")]
	[APKFIPDHNMB]
	public static IDisposable LAFLKNHHHHB<T>(this T FOIJIDBLNAC, Action NEJLJLKMLAF, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C320", Offset = "0x3E7A920", VA = "0x183E7C320")]
	[APKFIPDHNMB]
	public static IDisposable HELOAOMEBOI<T>(this T FOIJIDBLNAC, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6B90", Offset = "0x8FC5190", VA = "0x188FC6B90")]
	[APKFIPDHNMB]
	public static IDisposable HELOAOMEBOI(this MonoBehaviour FOIJIDBLNAC, AAJMNAIDLEH HHPFOCCGJIF, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C0C0", Offset = "0x3E7A6C0", VA = "0x183E7C0C0")]
	[APKFIPDHNMB]
	public static IDisposable FIEPFOLJMKA<T>(this T FOIJIDBLNAC, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C7D0", Offset = "0x3E7ADD0", VA = "0x183E7C7D0")]
	[APKFIPDHNMB]
	public static IDisposable LIPJCHODHLK<T>(this T FOIJIDBLNAC, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C3A0", Offset = "0x3E7A9A0", VA = "0x183E7C3A0")]
	[APKFIPDHNMB]
	public static IDisposable IDKFMHDKMLP<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C2A0", Offset = "0x3E7A8A0", VA = "0x183E7C2A0")]
	[APKFIPDHNMB]
	public static IDisposable FPGLFJAPNGG<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C730", Offset = "0x3E7AD30", VA = "0x183E7C730")]
	[APKFIPDHNMB]
	public static IDisposable KOAPGCIOKCL<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C8B0", Offset = "0x3E7AEB0", VA = "0x183E7C8B0")]
	[APKFIPDHNMB]
	public static IDisposable PDNAHHNJCFO<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C080", Offset = "0x3E7A680", VA = "0x183E7C080")]
	[APKFIPDHNMB]
	public static IDisposable EDIMCHEMEDP<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C360", Offset = "0x3E7A960", VA = "0x183E7C360")]
	[APKFIPDHNMB]
	public static IDisposable IBPGHIFPMHH<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C870", Offset = "0x3E7AE70", VA = "0x183E7C870")]
	[APKFIPDHNMB]
	public static IDisposable OKNNIGILFEI<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C8F0", Offset = "0x3E7AEF0", VA = "0x183E7C8F0")]
	[APKFIPDHNMB]
	public static IDisposable PGGOMIEKEHC<T>(this T FOIJIDBLNAC, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E7C2E0", Offset = "0x3E7A8E0", VA = "0x183E7C2E0")]
	[APKFIPDHNMB]
	public static IDisposable GCALJGOABCP<T>(this T FOIJIDBLNAC, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true) where T : MonoBehaviour, AAJMNAIDLEH
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FPMJPBOMDLN
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class ADHEBOCOHMM : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public FBGHAEGJECI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private NPADGJEPDBM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public ADHEBOCOHMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB97A0", Offset = "0x8FB7DA0", VA = "0x188FB97A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9880", Offset = "0x8FB7E80", VA = "0x188FB9880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NJEPOEEJBPJ : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public FBGHAEGJECI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private NPADGJEPDBM <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public NJEPOEEJBPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8F80", Offset = "0x8FC7580", VA = "0x188FC8F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8FC9070", Offset = "0x8FC7670", VA = "0x188FC9070", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2050", Offset = "0x8FC0650", VA = "0x188FC2050")]
	public static APLPOCKIJEJ JIBNOFMLOIK(Action NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1FC0", Offset = "0x8FC05C0", VA = "0x188FC1FC0")]
	public static APLPOCKIJEJ JIBNOFMLOIK(Behaviour HHPFOCCGJIF, Action NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8FC20D0", Offset = "0x8FC06D0", VA = "0x188FC20D0")]
	public static APLPOCKIJEJ JIBNOFMLOIK(Behaviour HHPFOCCGJIF, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1EA0", Offset = "0x8FC04A0", VA = "0x188FC1EA0")]
	[IteratorStateMachine(typeof(ADHEBOCOHMM))]
	private static IEnumerator<BJJPNELKDDJ> HJFDOFIPPNG(FBGHAEGJECI GPJGBKHIBFO, Action NEJLJLKMLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1F30", Offset = "0x8FC0530", VA = "0x188FC1F30")]
	[IteratorStateMachine(typeof(NJEPOEEJBPJ))]
	private static IEnumerator<BJJPNELKDDJ> HJFDOFIPPNG(FBGHAEGJECI GPJGBKHIBFO, Action<float> NEJLJLKMLAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GEGAODLBPKG : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class DFNDAHKJPNC : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GEGAODLBPKG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public DFNDAHKJPNC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8FBEFF0", Offset = "0x8FBD5F0", VA = "0x188FBEFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8FBF080", Offset = "0x8FBD680", VA = "0x188FBF080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly FBGHAEGJECI PMIIIDHPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Action DENHDEEJJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool IGJAIAIDHAE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ALMJMEFJFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA95030", Offset = "0xA93630", VA = "0x180A95030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8FC22D0", Offset = "0x8FC08D0", VA = "0x188FC22D0")]
	public GEGAODLBPKG(FBGHAEGJECI PMIIIDHPIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8FC21B0", Offset = "0x8FC07B0", VA = "0x188FC21B0")]
	[IteratorStateMachine(typeof(DFNDAHKJPNC))]
	private IEnumerator<BJJPNELKDDJ> LPBPFEAPEKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2230", Offset = "0x8FC0830", VA = "0x188FC2230", Slot = "4")]
	public void OnCompleted(Action PKEMBIGMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	public void LBEEOLPLCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ANEEFIOHFKE
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8FB98D0", Offset = "0x8FB7ED0", VA = "0x188FB98D0")]
	public static GEGAODLBPKG PMJGCHFEIKP(this FBGHAEGJECI PMIIIDHPIAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class PPEAKOMHAHM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LHLAOMCOGFO : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public HFHAGBLKCAM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public LHLAOMCOGFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6D70", Offset = "0x8FC5370", VA = "0x188FC6D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6DF0", Offset = "0x8FC53F0", VA = "0x188FC6DF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA150", Offset = "0x8FC8750", VA = "0x188FCA150")]
	public static APLPOCKIJEJ JIBNOFMLOIK(float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA080", Offset = "0x8FC8680", VA = "0x188FCA080")]
	public static APLPOCKIJEJ JIBNOFMLOIK(MonoBehaviour FOIJIDBLNAC, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA220", Offset = "0x8FC8820", VA = "0x188FCA220")]
	public static APLPOCKIJEJ OGJEJDOFBPK(MonoBehaviour FOIJIDBLNAC, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9FB0", Offset = "0x8FC85B0", VA = "0x188FC9FB0")]
	public static APLPOCKIJEJ IOGFGNIEKIM(LGFFGBFJLCF HHPFOCCGJIF, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9EF0", Offset = "0x8FC84F0", VA = "0x188FC9EF0")]
	private static IEnumerator<BJJPNELKDDJ> HJFDOFIPPNG(IPHPJEMCHLH MEFDKNIBHBD, float DLMJNGDJPDG, FBGHAEGJECI GPJGBKHIBFO, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9E00", Offset = "0x8FC8400", VA = "0x188FC9E00")]
	private static IEnumerator<BJJPNELKDDJ> DLOIMKBAONH(IPHPJEMCHLH MEFDKNIBHBD, float DLMJNGDJPDG, FBGHAEGJECI GPJGBKHIBFO, Action<float> NEJLJLKMLAF, bool MNKEOCMKALO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9E60", Offset = "0x8FC8460", VA = "0x188FC9E60")]
	[IteratorStateMachine(typeof(LHLAOMCOGFO))]
	private static IEnumerator<BJJPNELKDDJ> EKDKIBEIEEA(HFHAGBLKCAM OECBKCAKFPM, float DLMJNGDJPDG, FBGHAEGJECI GPJGBKHIBFO, Action<float> NEJLJLKMLAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PMKIIAOGFIE
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HJEKHLDKMLC : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public FBGHAEGJECI queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public HJEKHLDKMLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3980", Offset = "0x8FC1F80", VA = "0x188FC3980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3A40", Offset = "0x8FC2040", VA = "0x188FC3A40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9D70", Offset = "0x8FC8370", VA = "0x188FC9D70")]
	[IteratorStateMachine(typeof(HJEKHLDKMLC))]
	private static IEnumerator<BJJPNELKDDJ> MOJNIBBMHCK(FBGHAEGJECI PMIIIDHPIAD, Func<bool> OEOGIGLGCGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9C90", Offset = "0x8FC8290", VA = "0x188FC9C90")]
	public static APLPOCKIJEJ JNGMJHHNOMC(this MonoBehaviour FOIJIDBLNAC, Func<bool> OEOGIGLGCGF, FBGHAEGJECI PMIIIDHPIAD = FBGHAEGJECI.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KKNLJDDGAND
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FPHPDIAOKHK : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public FBGHAEGJECI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public FPHPDIAOKHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8FC1DE0", Offset = "0x8FC03E0", VA = "0x188FC1DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8FC1E50", Offset = "0x8FC0450", VA = "0x188FC1E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FNJDILGMGGP<T> : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FBGHAEGJECI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public FNJDILGMGGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D7A0", Offset = "0x4F4BDA0", VA = "0x184F4D7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4F4D820", Offset = "0x4F4BE20", VA = "0x184F4D820", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IIIJIHNFJEF : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public FBGHAEGJECI queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private BJJPNELKDDJ <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public IIIJIHNFJEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8FC50E0", Offset = "0x8FC36E0", VA = "0x188FC50E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5170", Offset = "0x8FC3770", VA = "0x188FC5170", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8FC69C0", Offset = "0x8FC4FC0", VA = "0x188FC69C0")]
	[IteratorStateMachine(typeof(FPHPDIAOKHK))]
	private static IEnumerator<BJJPNELKDDJ> LPBPFEAPEKO(float AEKHJIAHDFD, FBGHAEGJECI GPJGBKHIBFO, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3E66890", Offset = "0x3E64E90", VA = "0x183E66890")]
	[IteratorStateMachine(typeof(FNJDILGMGGP<>))]
	private static IEnumerator<BJJPNELKDDJ> LPBPFEAPEKO<T>(float AEKHJIAHDFD, FBGHAEGJECI GPJGBKHIBFO, Action<T> MGENEOADHDD, T HOOMHDKIGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8FC66B0", Offset = "0x8FC4CB0", VA = "0x188FC66B0")]
	[IteratorStateMachine(typeof(IIIJIHNFJEF))]
	private static IEnumerator<BJJPNELKDDJ> GPEAIIKMEMC(float AEKHJIAHDFD, FBGHAEGJECI GPJGBKHIBFO, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6490", Offset = "0x8FC4A90", VA = "0x188FC6490")]
	public static IDisposable BPBDHLJJAEL(this MonoBehaviour FOIJIDBLNAC, float AEKHJIAHDFD, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6A60", Offset = "0x8FC5060", VA = "0x188FC6A60")]
	public static APLPOCKIJEJ NFDIEHBMNHM(this MonoBehaviour FOIJIDBLNAC, float AEKHJIAHDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8FC63A0", Offset = "0x8FC49A0", VA = "0x188FC63A0")]
	public static APLPOCKIJEJ BPBDHLJJAEL(this MonoBehaviour FOIJIDBLNAC, float AEKHJIAHDFD, FBGHAEGJECI GPJGBKHIBFO, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8FC61C0", Offset = "0x8FC47C0", VA = "0x188FC61C0")]
	public static APLPOCKIJEJ ALHNKLPFDMB(this MonoBehaviour FOIJIDBLNAC, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3E66740", Offset = "0x3E64D40", VA = "0x183E66740")]
	public static APLPOCKIJEJ ALHNKLPFDMB<T>(this MonoBehaviour FOIJIDBLNAC, Action<T> MGENEOADHDD, T HOOMHDKIGBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8FC67E0", Offset = "0x8FC4DE0", VA = "0x188FC67E0")]
	public static APLPOCKIJEJ HINDPCDDEJM(this MonoBehaviour FOIJIDBLNAC, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6300", Offset = "0x8FC4900", VA = "0x188FC6300")]
	public static APLPOCKIJEJ BPAAPEJJEIN(this MonoBehaviour FOIJIDBLNAC, Action MGENEOADHDD, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6610", Offset = "0x8FC4C10", VA = "0x188FC6610")]
	public static APLPOCKIJEJ DKCMJNIONCF(this MonoBehaviour FOIJIDBLNAC, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6AF0", Offset = "0x8FC50F0", VA = "0x188FC6AF0")]
	public static APLPOCKIJEJ PMDAFPCIOFL(this MonoBehaviour FOIJIDBLNAC, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6920", Offset = "0x8FC4F20", VA = "0x188FC6920")]
	public static APLPOCKIJEJ KBICLLCICEN(MonoBehaviour FOIJIDBLNAC, FBGHAEGJECI PMIIIDHPIAD, Action MGENEOADHDD, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3E66770", Offset = "0x3E64D70", VA = "0x183E66770")]
	public static APLPOCKIJEJ KBICLLCICEN<T>(MonoBehaviour FOIJIDBLNAC, FBGHAEGJECI PMIIIDHPIAD, Action<T> MGENEOADHDD, T HOOMHDKIGBG, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6750", Offset = "0x8FC4D50", VA = "0x188FC6750")]
	public static APLPOCKIJEJ HEJEIEGCIPP(this MonoBehaviour FOIJIDBLNAC, float LNECFOGGICP, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6880", Offset = "0x8FC4E80", VA = "0x188FC6880")]
	public static APLPOCKIJEJ IDEHDGBCBFG(this MonoBehaviour FOIJIDBLNAC, float LNECFOGGICP, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6570", Offset = "0x8FC4B70", VA = "0x188FC6570")]
	public static APLPOCKIJEJ CMNFLFHEKEI(this MonoBehaviour FOIJIDBLNAC, float LNECFOGGICP, Action MGENEOADHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6260", Offset = "0x8FC4860", VA = "0x188FC6260")]
	public static APLPOCKIJEJ BKDPAHNMACK(this MonoBehaviour FOIJIDBLNAC, float LNECFOGGICP, Action MGENEOADHDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CDEFDOIGIFL : LCIELCNAEBE, IEnumerable<LCIELCNAEBE>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly List<LCIELCNAEBE> CDEHANEHNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool BBEJIPCPMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Action LIGLAJLLFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool DGNCPCIIBFJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PAKGBMMMGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9CF0", Offset = "0x8FB82F0", VA = "0x188FB9CF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action NELCOHPDBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA460", Offset = "0x8FB8A60", VA = "0x188FBA460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9C50", Offset = "0x8FB8250", VA = "0x188FB9C50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8FBA500", Offset = "0x8FB8B00", VA = "0x188FBA500")]
	public CDEFDOIGIFL([Optional] Action LIGLAJLLFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8FBA330", Offset = "0x8FB8930", VA = "0x188FBA330")]
	public void KMLBEHGKDFG(LCIELCNAEBE FDHIIHDJCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8FBA1D0", Offset = "0x8FB87D0", VA = "0x188FBA1D0")]
	private void HKJCMLHLGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8FB9EB0", Offset = "0x8FB84B0", VA = "0x188FB9EB0", Slot = "7")]
	public bool HJCMDHPAHAM(bool MKJGBAFLMBJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8FB9EC0", Offset = "0x8FB84C0", VA = "0x188FB9EC0", Slot = "8")]
	public bool HJCMDHPAHAM(Action CBDPHPPPDFI, bool MKJGBAFLMBJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8FB9E30", Offset = "0x8FB8430", VA = "0x188FB9E30", Slot = "9")]
	public IEnumerator<LCIELCNAEBE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8FB9E30", Offset = "0x8FB8430", VA = "0x188FB9E30", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MHDLKDJMMNG : HILGDBFENII
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JHLJBNPPFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public MHDLKDJMMNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public JHLJBNPPFJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5440", Offset = "0x8FC3A40", VA = "0x188FC5440")]
		internal void IOKPPEELHHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LGFAKEEHAIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public MHDLKDJMMNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LGFAKEEHAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8FC5440", Offset = "0x8FC3A40", VA = "0x188FC5440")]
		internal void ODCONFKIGKF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly float MHLBFNCCCID;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8FB9A20", Offset = "0x8FB8020", VA = "0x188FB9A20")]
	public MHDLKDJMMNG(Behaviour HHPFOCCGJIF, float MHLBFNCCCID, [Optional] Action LIGLAJLLFIC, [Optional] CAOKIAILIEC MDPKAHPJNNM, [Optional] IPHPJEMCHLH MEFDKNIBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8FC8E70", Offset = "0x8FC7470", VA = "0x188FC8E70", Slot = "9")]
	protected override bool PICNAMBEKFB(Action CBDPHPPPDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8FC8D60", Offset = "0x8FC7360", VA = "0x188FC8D60", Slot = "10")]
	protected override bool NIDGCPFEFPD(Action CBDPHPPPDFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LCIELCNAEBE
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool PAKGBMMMGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NELCOHPDBAC;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HJCMDHPAHAM(bool MKJGBAFLMBJ = false);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HJCMDHPAHAM(Action CBDPHPPPDFI, bool MKJGBAFLMBJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class HILGDBFENII : LCIELCNAEBE
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HDHDKHJHAGD : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public HILGDBFENII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public HDHDKHJHAGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8FC2FE0", Offset = "0x8FC15E0", VA = "0x188FC2FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FC30B0", Offset = "0x8FC16B0", VA = "0x188FC30B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Behaviour HHPFOCCGJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Action LIGLAJLLFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private BCEMNDENGIG IFBNIDOJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly CAOKIAILIEC MDPKAHPJNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly IPHPJEMCHLH MEFDKNIBHBD;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool PAKGBMMMGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D49EB0", Offset = "0x1D484B0", VA = "0x181D49EB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action NELCOHPDBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8FC32F0", Offset = "0x8FC18F0", VA = "0x188FC32F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3100", Offset = "0x8FC1700", VA = "0x188FC3100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8FC36C0", Offset = "0x8FC1CC0", VA = "0x188FC36C0")]
	protected HILGDBFENII(Behaviour HHPFOCCGJIF, [Optional] Action LIGLAJLLFIC, [Optional] CAOKIAILIEC MDPKAHPJNNM, [Optional] IPHPJEMCHLH MEFDKNIBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3230", Offset = "0x8FC1830", VA = "0x188FC3230", Slot = "7")]
	public bool HJCMDHPAHAM(bool MKJGBAFLMBJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3290", Offset = "0x8FC1890", VA = "0x188FC3290", Slot = "8")]
	public bool HJCMDHPAHAM(Action CBDPHPPPDFI, bool MKJGBAFLMBJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool PICNAMBEKFB(Action CBDPHPPPDFI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool NIDGCPFEFPD(Action CBDPHPPPDFI);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8FC36A0", Offset = "0x8FC1CA0", VA = "0x188FC36A0")]
	protected void OOLJEIGBLJD(Action CBDPHPPPDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3410", Offset = "0x8FC1A10", VA = "0x188FC3410")]
	protected CNOKEDEBLOH MLDLFMGDHDH(float ECPJMMFGCIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3390", Offset = "0x8FC1990", VA = "0x188FC3390")]
	private void MKFOMHLHLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8FC31A0", Offset = "0x8FC17A0", VA = "0x188FC31A0")]
	[IteratorStateMachine(typeof(HDHDKHJHAGD))]
	private IEnumerator<BJJPNELKDDJ> GMKCDBOBFLJ(float ECPJMMFGCIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3660", Offset = "0x8FC1C60", VA = "0x188FC3660")]
	[CompilerGenerated]
	private void ONGIDPKBFAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OGPJNKBPLDM : HILGDBFENII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly float KMFIPMBELAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int MEMNBBHBCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly float CEIKHDNLEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly float[] NEGJPPOOPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int MHKMFGHBOHB;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9470", Offset = "0x8FC7A70", VA = "0x188FC9470")]
	public OGPJNKBPLDM(Behaviour HHPFOCCGJIF, float NOGHIECNBAP, int MEMNBBHBCPA, [Optional] Action LIGLAJLLFIC, float CEIKHDNLEFF = 0f, [Optional] CAOKIAILIEC MDPKAHPJNNM, [Optional] IPHPJEMCHLH MEFDKNIBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "9")]
	protected override bool PICNAMBEKFB(Action CBDPHPPPDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9270", Offset = "0x8FC7870", VA = "0x188FC9270", Slot = "10")]
	protected override bool NIDGCPFEFPD(Action CBDPHPPPDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8FC91F0", Offset = "0x8FC77F0", VA = "0x188FC91F0")]
	private void AIJOCDBLONL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BBKABBPAKOO : HILGDBFENII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float MHLBFNCCCID;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8FB9A20", Offset = "0x8FB8020", VA = "0x188FB9A20")]
	public BBKABBPAKOO(Behaviour HHPFOCCGJIF, float MHLBFNCCCID, [Optional] Action LIGLAJLLFIC, [Optional] CAOKIAILIEC MDPKAHPJNNM, [Optional] IPHPJEMCHLH MEFDKNIBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "9")]
	protected override bool PICNAMBEKFB(Action CBDPHPPPDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8FB99E0", Offset = "0x8FB7FE0", VA = "0x188FB99E0", Slot = "10")]
	protected override bool NIDGCPFEFPD(Action CBDPHPPPDFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class ECIHMBGHBOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class DIKIFOHENFI : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public DIKIFOHENFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9B60", Offset = "0x8FB8160", VA = "0x188FB9B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FBF0D0", Offset = "0x8FBD6D0", VA = "0x188FBF0D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private APLPOCKIJEJ GMBHPHKGKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private LGFFGBFJLCF HHPFOCCGJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Action<float> DOPMCHLANNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private FBGHAEGJECI PMIIIDHPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private float FKJODENKDNL;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8FBFB30", Offset = "0x8FBE130", VA = "0x188FBFB30")]
	public ECIHMBGHBOA(LGFFGBFJLCF HHPFOCCGJIF, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8FBF940", Offset = "0x8FBDF40", VA = "0x188FBF940")]
	private void KOFGJAAHCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8FBF630", Offset = "0x8FBDC30", VA = "0x188FBF630")]
	private void AILNEMKILLA(string GJJJIJGCEEO, Action PPIBLPPDOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8FBFAB0", Offset = "0x8FBE0B0", VA = "0x188FBFAB0")]
	[IteratorStateMachine(typeof(DIKIFOHENFI))]
	private IEnumerator<BJJPNELKDDJ> LDEKIJCAOBJ(Action PPIBLPPDOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8FBF760", Offset = "0x8FBDD60", VA = "0x188FBF760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8FBF7C0", Offset = "0x8FBDDC0", VA = "0x188FBF7C0")]
	[CompilerGenerated]
	private void IDPMAAIGPCA(string ANEOEAMDEHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class PPPHNDEPKOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BJHMDGOJKCD : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public BJHMDGOJKCD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9B60", Offset = "0x8FB8160", VA = "0x188FB9B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9BD0", Offset = "0x8FB81D0", VA = "0x188FB9BD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private APLPOCKIJEJ GMBHPHKGKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private MonoBehaviour FOIJIDBLNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Action NEJLJLKMLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Action<float> DOPMCHLANNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private FBGHAEGJECI PMIIIDHPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private float FKJODENKDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private bool MNKEOCMKALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CAOKIAILIEC MDPKAHPJNNM;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8FCB190", Offset = "0x8FC9790", VA = "0x188FCB190")]
	public PPPHNDEPKOA(MonoBehaviour FOIJIDBLNAC, Action NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8FCAFC0", Offset = "0x8FC95C0", VA = "0x188FCAFC0")]
	public PPPHNDEPKOA(MonoBehaviour FOIJIDBLNAC, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8FCB320", Offset = "0x8FC9920", VA = "0x188FCB320")]
	public PPPHNDEPKOA(MonoBehaviour FOIJIDBLNAC, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xF153F0", Offset = "0xF139F0", VA = "0x180F153F0")]
	private PPPHNDEPKOA(CAOKIAILIEC MDPKAHPJNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA5B0", Offset = "0x8FC8BB0", VA = "0x188FCA5B0")]
	internal static PPPHNDEPKOA EOCJPINDKKP(MonoBehaviour FOIJIDBLNAC, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, [Optional] CAOKIAILIEC MDPKAHPJNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA990", Offset = "0x8FC8F90", VA = "0x188FCA990")]
	private void JIBNOFMLOIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8FCACB0", Offset = "0x8FC92B0", VA = "0x188FCACB0")]
	private void LLNMFJGAOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8FCAAC0", Offset = "0x8FC90C0", VA = "0x188FCAAC0")]
	private void KOFGJAAHCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8FCAE30", Offset = "0x8FC9430", VA = "0x188FCAE30")]
	private void OCJCDHDHLFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA390", Offset = "0x8FC8990", VA = "0x188FCA390")]
	private void AILNEMKILLA(string GJJJIJGCEEO, Action PPIBLPPDOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8FCAC30", Offset = "0x8FC9230", VA = "0x188FCAC30")]
	[IteratorStateMachine(typeof(BJHMDGOJKCD))]
	private IEnumerator<BJJPNELKDDJ> LDEKIJCAOBJ(Action PPIBLPPDOKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA4C0", Offset = "0x8FC8AC0", VA = "0x188FCA4C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA870", Offset = "0x8FC8E70", VA = "0x188FCA870")]
	[CompilerGenerated]
	private void HFNJNMPDFFD(string ANEOEAMDEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA7E0", Offset = "0x8FC8DE0", VA = "0x188FCA7E0")]
	[CompilerGenerated]
	private void FKAKLBKKKJE(string ANEOEAMDEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA900", Offset = "0x8FC8F00", VA = "0x188FCA900")]
	[CompilerGenerated]
	private void HOMPHBAFDDK(string ANEOEAMDEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA520", Offset = "0x8FC8B20", VA = "0x188FCA520")]
	[CompilerGenerated]
	private void EFBODEDCOEI(string ANEOEAMDEHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
internal enum NACIIIDFNHF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class PMIIKPMCBLI : IPHPJEMCHLH
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float ABINFPFCBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8FC9C50", Offset = "0x8FC8250", VA = "0x188FC9C50", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float CFMJMCFIOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8FC9C60", Offset = "0x8FC8260", VA = "0x188FC9C60", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double BGHDNEKOEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8FC9C70", Offset = "0x8FC8270", VA = "0x188FC9C70", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9BE0", Offset = "0x8FC81E0", VA = "0x188FC9BE0")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	internal static void ADENDBKKDEC(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	[UnityEngine.Scripting.Preserve]
	internal PMIIKPMCBLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface HHKKDIOIGKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DNDIKDDJFOO(string DJFMCHMDHGK);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKACCNPKAFH();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface KKMDMIIIDOG
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MBMNEAKACJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PGPOIJGDKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal class GMOEEKOALME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public CLCMMOODHMN EOILEMAMDIA;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int LBGMECNKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2510", Offset = "0x8FC0B10", VA = "0x188FC2510")]
	public static BJJPNELKDDJ GGLKMIOKJEL(IEnumerator<BJJPNELKDDJ> DDMNGNNHGGN, PPPGHGLLKIB HHBMPHLBJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2670", Offset = "0x8FC0C70", VA = "0x188FC2670")]
	public BJJPNELKDDJ GGLKMIOKJEL(PPPGHGLLKIB[] PNPIFMOBDPO, IEnumerator<BJJPNELKDDJ>[] CGEJAOCHPJJ, BJJPNELKDDJ[] BLEALOECDMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8FC23A0", Offset = "0x8FC09A0", VA = "0x188FC23A0")]
	public void EEPGFNAEIPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8FC23D0", Offset = "0x8FC09D0", VA = "0x188FC23D0")]
	public void EMFINMFCDFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8FC2730", Offset = "0x8FC0D30", VA = "0x188FC2730")]
	public void GKENIIFKMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8FC23A0", Offset = "0x8FC09A0", VA = "0x188FC23A0")]
	public void NEPOCHBBDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public GMOEEKOALME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CLCMMOODHMN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct DIKKPEMKPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public GMOEEKOALME NHNOGMMPANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public LGFFGBFJLCF AEJAJAHGPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public PPPGHGLLKIB ENJMNFKJEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IEnumerator<BJJPNELKDDJ> GOMJDDLCABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public BJJPNELKDDJ HNGIKHMHOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public NACIIIDFNHF OCKAKPMKGBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct OHIDNOBPFCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public FBGHAEGJECI NBABDFOAEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public List<DIKKPEMKPHO> IAFHFACMGPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class JOJKOFLCAIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public PPPGHGLLKIB promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CLCMMOODHMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public LGFFGBFJLCF context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public GMOEEKOALME routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public NACIIIDFNHF coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public BJJPNELKDDJ currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public IEnumerator<BJJPNELKDDJ> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public JOJKOFLCAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8FC59A0", Offset = "0x8FC3FA0", VA = "0x188FC59A0")]
		internal void EHHNMKJIDMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class PJOOIIFGAPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public GMOEEKOALME schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CLCMMOODHMN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public PJOOIIFGAPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8FC9BA0", Offset = "0x8FC81A0", VA = "0x188FC9BA0")]
		internal void BJIGGONGCBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KBAHMDFKECJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public GMOEEKOALME schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CLCMMOODHMN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public KBAHMDFKECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6180", Offset = "0x8FC4780", VA = "0x188FC6180")]
		internal void ECOMOFALINO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HDEDFMFLNIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public GMOEEKOALME schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CLCMMOODHMN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public HDEDFMFLNIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8FC2FA0", Offset = "0x8FC15A0", VA = "0x188FC2FA0")]
		internal void GLGHAAGCFAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const NACIIIDFNHF HCOLOGAINOM = NACIIIDFNHF.Cancelled | NACIIIDFNHF.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly FBGHAEGJECI PMIIIDHPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool[] CCLEBHDCIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private NativeArray<NACIIIDFNHF> PHNOHONBPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NativeArray<float> FCFDIMIMGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private NativeArray<int> CCIIMIADFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeArray<int> EFKEOFLKFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<int> CLMMNDEBFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<int> LCPAFIHBIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<int> LABLKBFHJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private GMOEEKOALME[] AJMHPONMPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private PPPGHGLLKIB[] PNPIFMOBDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private LGFFGBFJLCF[] EHPMDHCLCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private IEnumerator<BJJPNELKDDJ>[] EJMNDINGPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private BJJPNELKDDJ[] FDIFEEGDEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int NOJMPPGMLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int FAALOCBOHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly int FAFEDGNEKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float MEAIKJOMJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private PEHLLDKCDKB DJGBBAIAEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private JobHandle IHNCEDDCLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private List<GMOEEKOALME> NAOEIDBIIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool ADJILNJCEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private List<Action> JCNMGCFMIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private List<Action> EDPMKLEIGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool HMDAGKKAAPC;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public OHIDNOBPFCJ[] ADPBJLBCEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xC045E0", Offset = "0xC02BE0", VA = "0x180C045E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8FBBEF0", Offset = "0x8FBA4F0", VA = "0x188FBBEF0")]
	private static int HIOIIJMCFAH(FBGHAEGJECI PMIIIDHPIAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8FBC930", Offset = "0x8FBAF30", VA = "0x188FBC930")]
	public CLCMMOODHMN(FBGHAEGJECI PMIIIDHPIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8FBC620", Offset = "0x8FBAC20", VA = "0x188FBC620")]
	private void OFKBADNDCOM(int ABNEEHKEKIJ, int NPBLGGNFAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8FBAB40", Offset = "0x8FB9140", VA = "0x188FBAB40")]
	public void EBOCMJIOPGE(LGFFGBFJLCF HHPFOCCGJIF, BJJPNELKDDJ JBNOHCPCMOI, IEnumerator<BJJPNELKDDJ> DDMNGNNHGGN, PPPGHGLLKIB HHBMPHLBJOF, [Optional] GMOEEKOALME JLNMEONNLHF, NACIIIDFNHF FPJBGPAFILJ = NACIIIDFNHF.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8FBC050", Offset = "0x8FBA650", VA = "0x188FBC050")]
	public void LIJOICNDJHE(IEnumerable<DIKKPEMKPHO> FBCNPHDKDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8FBBA20", Offset = "0x8FBA020", VA = "0x188FBBA20")]
	private DIKKPEMKPHO GNIOOOECEOH(int KJDCLAICMBF)
	{
		return default(DIKKPEMKPHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8FBB3E0", Offset = "0x8FB99E0", VA = "0x188FBB3E0")]
	private void FHJGFHFELIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A870", Offset = "0x3B88E70", VA = "0x183B8A870")]
	private static void NMFMHCKPFJC<T>(int KJDCLAICMBF, T[] ODDPDNGABCG, int MLMBLBFOLPC, [Optional] T CPNJOIGGGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A8C0", Offset = "0x3B88EC0", VA = "0x183B8A8C0")]
	private static void NMFMHCKPFJC<T>(int KJDCLAICMBF, NativeArray<T> ODDPDNGABCG, int MLMBLBFOLPC, [Optional] T CPNJOIGGGPF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8FBA620", Offset = "0x8FB8C20", VA = "0x188FBA620")]
	private void AIJALMHHGCA(IEnumerable<DIKKPEMKPHO> FBCNPHDKDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8FBB750", Offset = "0x8FB9D50", VA = "0x188FBB750")]
	private void FNHKEINAMEL(DIKKPEMKPHO BBHHPPFECKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8FBC290", Offset = "0x8FBA890", VA = "0x188FBC290")]
	private FPOACKAAMMJ MNHKNKIIEPL(int BANALCOHFIB)
	{
		return default(FPOACKAAMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8FBB820", Offset = "0x8FB9E20", VA = "0x188FBB820")]
	public void GLLINKHDKJF(float LECEFMDDLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8FBAAC0", Offset = "0x8FB90C0", VA = "0x188FBAAC0")]
	private void EBKBKAIKBII(Action IAFDMJDNHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8FBA5A0", Offset = "0x8FB8BA0", VA = "0x188FBA5A0")]
	private void AEDFGCCLAFC(Action IAFDMJDNHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8FBACC0", Offset = "0x8FB92C0", VA = "0x188FBACC0")]
	public void EJGDFLADDAN(float LECEFMDDLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8FBA9C0", Offset = "0x8FB8FC0", VA = "0x188FBA9C0")]
	public void CKBKAMMKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8FBC4F0", Offset = "0x8FBAAF0", VA = "0x188FBC4F0")]
	public void NEPOCHBBDNF(GMOEEKOALME OECBKCAKFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8FBC800", Offset = "0x8FBAE00", VA = "0x188FBC800")]
	public void PCEOJEMCNIE(GMOEEKOALME OECBKCAKFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8FBBF20", Offset = "0x8FBA520", VA = "0x188FBBF20")]
	public void JOOKIIALCMB(GMOEEKOALME OECBKCAKFPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class IHGNDFKFMHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public static readonly IHGNDFKFMHI KBCDDOOGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Action CANPFBOHDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool JBOBNJDEDEL;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public IHGNDFKFMHI(Action CANPFBOHDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x85CC080", Offset = "0x85CA680", VA = "0x1885CC080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FNICMOGIHIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable NMOKDKLMPKL(UnityEngine.Object HHPFOCCGJIF, Action<T> HBOAJPCBBJH);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FGHCLEMEGIK<T> : FNICMOGIHIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class BNJOKHBCIAE<T> : FGHCLEMEGIK<T>, FNICMOGIHIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BBDHMAFPIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BNJOKHBCIAE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public KPACIKFJNGN<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public BBDHMAFPIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6788080", Offset = "0x6786680", VA = "0x186788080")]
		internal void NHKIMAFPJMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static GameObject JPHLNJGHLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<KPACIKFJNGN<UnityEngine.Object, Action<T>>> NIHNBIELKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private T NNLANCIBNLL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D9D0", Offset = "0x6A1BFD0", VA = "0x186A1D9D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E160", Offset = "0x6A1C760", VA = "0x186A1E160")]
	private static bool NKOCFOKLDAM(T IAFDMJDNHDH, T DFKKOPOBCBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E550", Offset = "0x6A1CB50", VA = "0x186A1E550")]
	public BNJOKHBCIAE(T MOELPNNFBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E230", Offset = "0x6A1C830", VA = "0x186A1E230", Slot = "6")]
	public IDisposable NMOKDKLMPKL(UnityEngine.Object HHPFOCCGJIF, Action<T> HBOAJPCBBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DE00", Offset = "0x6A1C400", VA = "0x186A1DE00")]
	private void KHFHOJAGMLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class EIJFALDMLBB : IADHOCBLLMC
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class MCDIBNHMDGA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class BJOFKIGCMNI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int JIEJOKBHEMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private MCDIBNHMDGA GPJGBKHIBFO;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x106B260", Offset = "0x1069860", VA = "0x18106B260")]
			public BJOFKIGCMNI(int JIEJOKBHEMF, MCDIBNHMDGA GPJGBKHIBFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8FB9C20", Offset = "0x8FB8220", VA = "0x188FB9C20", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class NFJGGPPHGKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public NFJGGPPHGKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB79BD0", Offset = "0xB781D0", VA = "0x180B79BD0")]
			internal bool HDNIBIBJKDE(HANMMIHEBGP e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class JIIILPIOHCK : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private BJJPNELKDDJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public MCDIBNHMDGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public IPHPJEMCHLH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private NPADGJEPDBM <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private List<HANMMIHEBGP> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public JIIILPIOHCK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x8FC5470", Offset = "0x8FC3A70", VA = "0x188FC5470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8FC5770", Offset = "0x8FC3D70", VA = "0x188FC5770", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly FBGHAEGJECI PMIIIDHPIAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private APLPOCKIJEJ HHBMPHLBJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly List<HANMMIHEBGP> OJKALEKNNGO;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8CC0", Offset = "0x8FC72C0", VA = "0x188FC8CC0")]
		public MCDIBNHMDGA(FBGHAEGJECI PMIIIDHPIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8B30", Offset = "0x8FC7130", VA = "0x188FC8B30")]
		public IDisposable MCCANEKBBLD(HANMMIHEBGP EANFEDODFKL, CAOKIAILIEC MDPKAHPJNNM, IPHPJEMCHLH AGEIHALJKLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8FC89A0", Offset = "0x8FC6FA0", VA = "0x188FC89A0")]
		private void JEKNBAIFJHL(int JIEJOKBHEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8FC8910", Offset = "0x8FC6F10", VA = "0x188FC8910")]
		[IteratorStateMachine(typeof(JIIILPIOHCK))]
		private IEnumerator<BJJPNELKDDJ> HJFDOFIPPNG(IPHPJEMCHLH AGEIHALJKLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8FC88C0", Offset = "0x8FC6EC0", VA = "0x188FC88C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class HANMMIHEBGP
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public enum FHNIFBGAJBE : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static int OKMKCAHIAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int AFPIOPNCMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly AAJMNAIDLEH AEJAJAHGPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly MonoBehaviour DAOMEBOICGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Action FLHPFKIPOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Action<float> DIKDKPJGKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly float KEMFCHJLIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public float FCFDIMIMGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly string CLGAHBNBCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly bool GFMGKMDBDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly FHNIFBGAJBE FJKFJEEFDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool HJMCOIHLMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public bool ABNGPKPJGHG;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8FC2E20", Offset = "0x8FC1420", VA = "0x188FC2E20")]
		public HANMMIHEBGP(AAJMNAIDLEH HHPFOCCGJIF, Action NEJLJLKMLAF, bool MDHJCAMJAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8FC2CA0", Offset = "0x8FC12A0", VA = "0x188FC2CA0")]
		public HANMMIHEBGP(AAJMNAIDLEH HHPFOCCGJIF, Action<float> NEJLJLKMLAF, bool MDHJCAMJAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8FC2AC0", Offset = "0x8FC10C0", VA = "0x188FC2AC0")]
		public HANMMIHEBGP(AAJMNAIDLEH HHPFOCCGJIF, float DLMJNGDJPDG, Action<float> NEJLJLKMLAF, IPHPJEMCHLH AGEIHALJKLD, FHNIFBGAJBE COKDOIIBDHE, bool MNKEOCMKALO, bool MDHJCAMJAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8FC2870", Offset = "0x8FC0E70", VA = "0x188FC2870")]
		public bool ENOPMCNBNHL(float FLCAFPMKFLE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly CAOKIAILIEC MDPKAHPJNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly IPHPJEMCHLH MEFDKNIBHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<FBGHAEGJECI, MCDIBNHMDGA> ANEBAPAHMDC;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8FBFF00", Offset = "0x8FBE500", VA = "0x188FBFF00")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	internal static void FCJGOJDAJDA(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8FC08D0", Offset = "0x8FBEED0", VA = "0x188FC08D0")]
	[UnityEngine.Scripting.Preserve]
	internal EIJFALDMLBB([OEKMEJFDAAI(null)] CAOKIAILIEC MDPKAHPJNNM, [OEKMEJFDAAI(null)] IPHPJEMCHLH MEFDKNIBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8FC0160", Offset = "0x8FBE760", VA = "0x188FC0160", Slot = "4")]
	public IDisposable FLHPFKIPOFF(AAJMNAIDLEH HHPFOCCGJIF, Action GDMDDGECOJI, FBGHAEGJECI PMIIIDHPIAD, bool MDHJCAMJAPJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8FBFF70", Offset = "0x8FBE570", VA = "0x188FBFF70", Slot = "5")]
	public IDisposable FLHPFKIPOFF(AAJMNAIDLEH HHPFOCCGJIF, Action<float> GDMDDGECOJI, FBGHAEGJECI PMIIIDHPIAD, bool MDHJCAMJAPJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8FC07D0", Offset = "0x8FBEDD0", VA = "0x188FC07D0", Slot = "7")]
	public IDisposable LIPJCHODHLK(AAJMNAIDLEH HHPFOCCGJIF, float DLMJNGDJPDG, Action<float> GDMDDGECOJI, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8FBFE00", Offset = "0x8FBE400", VA = "0x188FBFE00", Slot = "8")]
	public IDisposable DIHFKGDINEC(AAJMNAIDLEH HHPFOCCGJIF, float DLMJNGDJPDG, Action<float> GDMDDGECOJI, FBGHAEGJECI PMIIIDHPIAD, bool MNKEOCMKALO = true, bool MDHJCAMJAPJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8FC0650", Offset = "0x8FBEC50", VA = "0x188FC0650", Slot = "6")]
	public IDisposable LIPJCHODHLK(float DLMJNGDJPDG, Action<float> GDMDDGECOJI, bool MNKEOCMKALO = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8FC0350", Offset = "0x8FBE950", VA = "0x188FC0350", Slot = "9")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8FC0510", Offset = "0x8FBEB10", VA = "0x188FC0510")]
	private MCDIBNHMDGA KKKLLEEOCCM(FBGHAEGJECI PMIIIDHPIAD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class IHPPNLKDBCM : FKGGKLOAPOA, CAOKIAILIEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private CLCMMOODHMN[] HLIMCPIGHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private HHKKDIOIGKJ OPEDMONFIPG;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8FC4450", Offset = "0x8FC2A50", VA = "0x188FC4450")]
	[LAFCEDCMNGK.DCDCJCFDIHP]
	internal static void ADENDBKKDEC(CFPMHDJNIAH LOLOEONEEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8FC5020", Offset = "0x8FC3620", VA = "0x188FC5020")]
	[UnityEngine.Scripting.Preserve]
	public IHPPNLKDBCM([OEKMEJFDAAI(null)] GJCGDMLMGEI PANKBOKPMNP, [OEKMEJFDAAI(null)] IPHPJEMCHLH MEFDKNIBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8FC4C90", Offset = "0x8FC3290", VA = "0x188FC4C90", Slot = "19")]
	public override APLPOCKIJEJ JGLGBKDHDHD(LGFFGBFJLCF HHPFOCCGJIF, IEnumerator<BJJPNELKDDJ> NOJMIPFAOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8FC4A00", Offset = "0x8FC3000", VA = "0x188FC4A00", Slot = "20")]
	public override void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8FC47D0", Offset = "0x8FC2DD0", VA = "0x188FC47D0", Slot = "22")]
	public override void HHCNIGFIIKL(FBGHAEGJECI PMIIIDHPIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8FC4700", Offset = "0x8FC2D00", VA = "0x188FC4700", Slot = "21")]
	protected override void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8FC4DC0", Offset = "0x8FC33C0", VA = "0x188FC4DC0")]
	private CLCMMOODHMN MJMHBGOJMFB(FBGHAEGJECI EHLAHNIAPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8FC4DF0", Offset = "0x8FC33F0", VA = "0x188FC4DF0", Slot = "23")]
	internal override IEKBJAOCAOD OLMNFFDFJPJ(IEnumerator<BJJPNELKDDJ> NOJMIPFAOCB, Behaviour HHPFOCCGJIF, PPPGHGLLKIB HHBMPHLBJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8FC45E0", Offset = "0x8FC2BE0", VA = "0x188FC45E0", Slot = "24")]
	internal override LPKCEPDKGCO DMFDJKNCGNC(FBGHAEGJECI GPJGBKHIBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8FC44C0", Offset = "0x8FC2AC0", VA = "0x188FC44C0")]
	private void ADIOFGMHEEK(CLCMMOODHMN LLDAODOJLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8FC46A0", Offset = "0x8FC2CA0", VA = "0x188FC46A0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[BurstCompile]
internal struct PEHLLDKCDKB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[ReadOnly]
	public float HEBBLLBAPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[ReadOnly]
	public int LGKOHDPFNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> JEAGFLJKHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeArray<int> IACBNDDCLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<int> HDGKBLJIMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	public NativeArray<NACIIIDFNHF> NDKAIIOIOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	public NativeArray<float> GJFOKBGPDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[WriteOnly]
	public NativeArray<int> CLMMNDEBFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<int> CCIIMIADFMD;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9680", Offset = "0x8FC7C80", VA = "0x188FC9680")]
	public static PEHLLDKCDKB EEPJBIPIECL(int HBODFJGICIH, float LECEFMDDLMN, NativeArray<NACIIIDFNHF> FGAPEINFHEP, NativeArray<float> LGHGDHHOAFA, NativeArray<int> OHJBHFJODMK, NativeArray<int> NANPOLLIMLO, NativeArray<int> KCEDPDIJOMA, NativeArray<int> IACBNDDCLDF, NativeArray<int> HDGKBLJIMKI)
	{
		return default(PEHLLDKCDKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8FC96E0", Offset = "0x8FC7CE0", VA = "0x188FC96E0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9640", Offset = "0x8FC7C40", VA = "0x188FC9640")]
	private bool CBGFENHEAOE(int LEPAEEGOBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9890", Offset = "0x8FC7E90", VA = "0x188FC9890")]
	private void GFNEKJEICBJ(NativeArray<int> OBACHLEFMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8FC98C0", Offset = "0x8FC7EC0", VA = "0x188FC98C0")]
	private int HHDIDEKCMBD(int BAKMHGELNCE, int GFFHLLNHALB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8FC97C0", Offset = "0x8FC7DC0", VA = "0x188FC97C0")]
	private void FIDPCKNMCHF(NativeArray<int> OBACHLEFMJL, int JCGKHFGDEIH, int FIECNFDCBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8FC9960", Offset = "0x8FC7F60", VA = "0x188FC9960")]
	private void MHODMGCLAID(NativeArray<int> OBACHLEFMJL, int LNDFFNFJDCO, int OLKACMMMBPC, int JHJBIJFKGEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class FKGGKLOAPOA : CAOKIAILIEC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly GJCGDMLMGEI PANKBOKPMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	protected readonly IPHPJEMCHLH MEFDKNIBHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private LPKCEPDKGCO[] FOKLLNKGAEO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static CAOKIAILIEC DOBPPELCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8FC14C0", Offset = "0x8FBFAC0", VA = "0x188FC14C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool MMNPCHICOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public FBGHAEGJECI BNJBOEHNPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FBGHAEGJECI);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA80", Offset = "0xA9E080", VA = "0x180A9FA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IPHPJEMCHLH MPNMFMDOJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BJJPNELKDDJ JLEIIACMLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public BJJPNELKDDJ FKDODFEJLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public BJJPNELKDDJ IJIDBINELOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public BJJPNELKDDJ GCAJFEKDFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA962C0", Offset = "0xA948C0", VA = "0x180A962C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1770", Offset = "0x8FBFD70", VA = "0x188FC1770")]
	public static APLPOCKIJEJ MBDNCOFCIPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8FC18F0", Offset = "0x8FBFEF0", VA = "0x188FC18F0")]
	[UnityEngine.Scripting.Preserve]
	protected FKGGKLOAPOA([OEKMEJFDAAI(null)] GJCGDMLMGEI PANKBOKPMNP, [OEKMEJFDAAI(null)] IPHPJEMCHLH MEFDKNIBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1360", Offset = "0x8FBF960", VA = "0x188FC1360", Slot = "6")]
	public APLPOCKIJEJ FIJDFIALNIE(IEnumerator<BJJPNELKDDJ> NOJMIPFAOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1160", Offset = "0x8FBF760", VA = "0x188FC1160", Slot = "7")]
	public APLPOCKIJEJ FIJDFIALNIE(Behaviour HHPFOCCGJIF, IEnumerator<BJJPNELKDDJ> NOJMIPFAOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract APLPOCKIJEJ JGLGBKDHDHD(LGFFGBFJLCF HHPFOCCGJIF, IEnumerator<BJJPNELKDDJ> NOJMIPFAOCB);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1530", Offset = "0x8FBFB30", VA = "0x188FC1530", Slot = "20")]
	public virtual void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8FC0F20", Offset = "0x8FBF520", VA = "0x188FC0F20", Slot = "9")]
	public void EJGDCJHBBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1390", Offset = "0x8FBF990", VA = "0x188FC1390", Slot = "21")]
	protected virtual void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1730", Offset = "0x8FBFD30", VA = "0x188FC1730")]
	private void LDAHGJONKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8FC14A0", Offset = "0x8FBFAA0", VA = "0x188FC14A0")]
	private void HNDIBPLHFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8FC18B0", Offset = "0x8FBFEB0", VA = "0x188FC18B0")]
	private void NJLNHFMMFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8FC18D0", Offset = "0x8FBFED0", VA = "0x188FC18D0")]
	private void OBDOAEFBKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1370", Offset = "0x8FBF970", VA = "0x188FC1370")]
	private void FKILHLIMMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1750", Offset = "0x8FBFD50", VA = "0x188FC1750")]
	private void LOEBECPFCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1800", Offset = "0x8FBFE00", VA = "0x188FC1800")]
	private void MJEGMEGBPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1410", Offset = "0x8FBFA10", VA = "0x188FC1410", Slot = "22")]
	public virtual void HHCNIGFIIKL(FBGHAEGJECI PMIIIDHPIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8FC0990", Offset = "0x8FBEF90", VA = "0x188FC0990")]
	private void CHBNKPKJNHJ(LPKCEPDKGCO LLDAODOJLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2987B80", Offset = "0x2986180", VA = "0x182987B80")]
	private LPKCEPDKGCO JIGMOBJNCHN(FBGHAEGJECI EHLAHNIAPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract IEKBJAOCAOD OLMNFFDFJPJ(IEnumerator<BJJPNELKDDJ> NOJMIPFAOCB, Behaviour FOIJIDBLNAC, PPPGHGLLKIB LKPDPOENNAN);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract LPKCEPDKGCO DMFDJKNCGNC(FBGHAEGJECI PMIIIDHPIAD);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8FC0B60", Offset = "0x8FBF160", VA = "0x188FC0B60", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8FC13B0", Offset = "0x8FBF9B0", VA = "0x188FC13B0", Slot = "15")]
	public BJJPNELKDDJ HANGOHNLCID(FBGHAEGJECI GPJGBKHIBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8FC1820", Offset = "0x8FBFE20", VA = "0x188FC1820", Slot = "16")]
	public BJJPNELKDDJ NEOEAEIMNPL(float AEKHJIAHDFD, FBGHAEGJECI GPJGBKHIBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8FC16D0", Offset = "0x8FBFCD0", VA = "0x188FC16D0", Slot = "17")]
	public BJJPNELKDDJ JODNNJJMNOP(Func<bool> OEOGIGLGCGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class IEKBJAOCAOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly PPPGHGLLKIB HHBMPHLBJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly KKMDMIIIDOG HHPFOCCGJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly bool NIPHLDEKAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private string DJFMCHMDHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private StackTrace ICJIENOMAHN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<BJJPNELKDDJ> GOMJDDLCABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BJJPNELKDDJ HNGIKHMHOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FE0", Offset = "0xA935E0", VA = "0x180A94FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool JGFOENPKIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3DB0", Offset = "0x8FC23B0", VA = "0x188FC3DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JDLHJNNBENM
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xD94690", Offset = "0xD92C90", VA = "0x180D94690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xDB03D0", Offset = "0xDAE9D0", VA = "0x180DB03D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8FC3E30", Offset = "0x8FC2430", VA = "0x188FC3E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float MAMNLNNGAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xF2EA00", Offset = "0xF2D000", VA = "0x180F2EA00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xF2EA10", Offset = "0xF2D010", VA = "0x180F2EA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8FC4180", Offset = "0x8FC2780", VA = "0x188FC4180")]
	public IEKBJAOCAOD(IEnumerator<BJJPNELKDDJ> DDMNGNNHGGN, KKMDMIIIDOG HHPFOCCGJIF, PPPGHGLLKIB HHBMPHLBJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3A90", Offset = "0x8FC2090", VA = "0x188FC3A90")]
	public BJJPNELKDDJ GGLKMIOKJEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8FC3FE0", Offset = "0x8FC25E0", VA = "0x188FC3FE0")]
	public bool LMFBCCOBEFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8FC4050", Offset = "0x8FC2650", VA = "0x188FC4050")]
	public void NEPOCHBBDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8FC40A0", Offset = "0x8FC26A0", VA = "0x188FC40A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0xE08F40", Offset = "0xE07540", VA = "0x180E08F40")]
	[CompilerGenerated]
	private void LGKEIHNEFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class PPPGHGLLKIB : PGFLBANDMJA, APLPOCKIJEJ, BCEMNDENGIG, CNOKEDEBLOH, IEnumerator, BJJPNELKDDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private FBGHAEGJECI KLCFEFCJFDC;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private FBGHAEGJECI NOJCJHIGEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB66060", Offset = "0xB64660", VA = "0x180B66060", Slot = "23")]
		get
		{
			return default(FBGHAEGJECI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public FBGHAEGJECI EOILEMAMDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x10B7CA0", Offset = "0x10B62A0", VA = "0x1810B7CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float LLOFDMFIBIF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAE6850", Offset = "0xAE4E50", VA = "0x180AE6850", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool NKJHFAEOEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA320", Offset = "0x8FC8920", VA = "0x188FCA320", Slot = "24")]
	private bool IEJAJGIJECN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA310", Offset = "0x8FC8910", VA = "0x188FCA310", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8FCA340", Offset = "0x8FC8940", VA = "0x188FCA340")]
	public PPPGHGLLKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal enum FPOACKAAMMJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class LPKCEPDKGCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum NFFFOMBDIEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct CIEIHFJFOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FBGHAEGJECI NBABDFOAEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public NFFFOMBDIEG HPHHNGNHNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public List<IEKBJAOCAOD> BGAJLNMFLOK;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly NFFFOMBDIEG[] AHPCBCCIIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly FBGHAEGJECI PMIIIDHPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool HCADMOCGJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly IEKBJAOCAOD[] KMIPPHIAKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<IEKBJAOCAOD> JGJHFOCICGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Stack<int> OBBOMKHNFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly List<IEKBJAOCAOD> PGBGJPALGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Stack<int> MAADOLNDFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly HHKKDIOIGKJ EGOCNPNEAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool HMDAGKKAAPC;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public CIEIHFJFOGG[,] KHLGIIEJNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8FC8380", Offset = "0x8FC6980", VA = "0x188FC8380")]
	public LPKCEPDKGCO(FBGHAEGJECI GPJGBKHIBFO, HHKKDIOIGKJ EGOCNPNEAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8FC7BA0", Offset = "0x8FC61A0", VA = "0x188FC7BA0")]
	public void KAAIMIFMIEH(IEKBJAOCAOD DDMNGNNHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8FC6E40", Offset = "0x8FC5440", VA = "0x188FC6E40")]
	public void AOCMGEBAPMD(IList<IEKBJAOCAOD> CGEJAOCHPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8FC78B0", Offset = "0x8FC5EB0", VA = "0x188FC78B0")]
	public void IENEOCNIKGK(IList<IEKBJAOCAOD> CGEJAOCHPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8FC8010", Offset = "0x8FC6610", VA = "0x188FC8010")]
	private void MPMBFIFCLKH(IEKBJAOCAOD DDMNGNNHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8FC72B0", Offset = "0x8FC58B0", VA = "0x188FC72B0")]
	private void BDLILCJDFFF(IList<IEKBJAOCAOD> CGEJAOCHPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8FC7130", Offset = "0x8FC5730", VA = "0x188FC7130")]
	private FPOACKAAMMJ AOLNBMAOOBN(IEKBJAOCAOD DDMNGNNHGGN)
	{
		return default(FPOACKAAMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8FC7740", Offset = "0x8FC5D40", VA = "0x188FC7740")]
	public void FLHPFKIPOFF(float LECEFMDDLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8FC7550", Offset = "0x8FC5B50", VA = "0x188FC7550")]
	public void EJGDCJHBBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8FC7CB0", Offset = "0x8FC62B0", VA = "0x188FC7CB0")]
	private void LFJGGDCJLOC(List<IEKBJAOCAOD> CGEJAOCHPJJ, Stack<int> CMGKDEGMLCD, bool COGAMHGMLEM, float JOGGHNFMMBC = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8FC7430", Offset = "0x8FC5A30", VA = "0x188FC7430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8FC8100", Offset = "0x8FC6700", VA = "0x188FC8100")]
	private void OCAMMLDBHMC(List<IEKBJAOCAOD> CGEJAOCHPJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class ANCOLNANFAK : HHKKDIOIGKJ
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void DNDIKDDJFOO(string DJFMCHMDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
	public void GKACCNPKAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public ANCOLNANFAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class EABMKDEMBMJ : KKMDMIIIDOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Behaviour FOIJIDBLNAC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string CLGAHBNBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8FBF170", Offset = "0x8FBD770", VA = "0x188FBF170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MBMNEAKACJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FBF120", Offset = "0x8FBD720", VA = "0x188FBF120", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PGPOIJGDKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8FBF1F0", Offset = "0x8FBD7F0", VA = "0x188FBF1F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB40", Offset = "0xA99140", VA = "0x180A9AB40")]
	public EABMKDEMBMJ(Behaviour FOIJIDBLNAC)
	{
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
