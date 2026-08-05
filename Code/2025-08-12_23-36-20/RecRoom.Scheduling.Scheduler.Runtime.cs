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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8ED6220", Offset = "0x8ED5020", VA = "0x188ED6220", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ED8A60", Offset = "0x8ED7860", VA = "0x188ED8A60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2941360", Offset = "0x2940160", VA = "0x182941360")]
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
		private struct JBNPNJDAGCL
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			[CompilerGenerated]
			private sealed class IPBDFCEOEHG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public DHGHBCHOJNI.OAGJKJINNJB key;

				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
				public IPBDFCEOEHG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8ED0140", Offset = "0x8ECEF40", VA = "0x188ED0140")]
				internal void EGEJPABEECI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000002")]
			public static IDisposable LNPCLHEDPMA;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8ED0D80", Offset = "0x8ECFB80", VA = "0x188ED0D80")]
			public static PlayerLoopSystem JJEBAMNBBDC(DHGHBCHOJNI.OAGJKJINNJB OPGJHIOADCK)
			{
				return default(PlayerLoopSystem);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct NLKLNBFPAJE
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			[CompilerGenerated]
			private sealed class DMEGJBLCEIC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public DHGHBCHOJNI.OAGJKJINNJB key;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
				public DMEGJBLCEIC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x8EC9A10", Offset = "0x8EC8810", VA = "0x188EC9A10")]
				internal void EGEJPABEECI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8ED6DA0", Offset = "0x8ED5BA0", VA = "0x188ED6DA0")]
			public static PlayerLoopSystem JJEBAMNBBDC(DHGHBCHOJNI.OAGJKJINNJB OPGJHIOADCK)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly ALMLLDBPKBM IPEKLICENHF;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8120", Offset = "0x8EC6F20", VA = "0x188EC8120")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8800", Offset = "0x8EC7600", VA = "0x188EC8800")]
		private static void HGIIIOIMJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8EC93D0", Offset = "0x8EC81D0", VA = "0x188EC93D0")]
		private static void NOFDIEOPPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8EC81A0", Offset = "0x8EC6FA0", VA = "0x188EC81A0")]
		private static void BDEMEMMKCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8850", Offset = "0x8EC7650", VA = "0x188EC8850")]
		private static void NBMIFFBHFJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B4D6D0", Offset = "0x3B4C4D0", VA = "0x183B4D6D0")]
		private static (PlayerLoopSystem, JHIMDICPOID.JJJEEKDAPHE) BFILBEHJCAP<T>()
		{
			return default((PlayerLoopSystem, JHIMDICPOID.JJJEEKDAPHE));
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8EC8600", Offset = "0x8EC7400", VA = "0x188EC8600")]
		private static (PlayerLoopSystem, JHIMDICPOID.JJJEEKDAPHE) BFILBEHJCAP(PlayerLoopSystem MINBKONEKBI)
		{
			return default((PlayerLoopSystem, JHIMDICPOID.JJJEEKDAPHE));
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3B4F0D0", Offset = "0x3B4DED0", VA = "0x183B4F0D0")]
		private static (PlayerLoopSystem, JHIMDICPOID.JJJEEKDAPHE) MDNHCHGJFLC<T>()
		{
			return default((PlayerLoopSystem, JHIMDICPOID.JJJEEKDAPHE));
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B4D850", Offset = "0x3B4C650", VA = "0x183B4D850")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) GCIKHPIAIJN<TParent, TSub>(DHGHBCHOJNI.OAGJKJINNJB OPGJHIOADCK)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8EC86A0", Offset = "0x8EC74A0", VA = "0x188EC86A0")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) GCIKHPIAIJN(DHGHBCHOJNI.OAGJKJINNJB OPGJHIOADCK, Type PJGOIMBEKPK, Type GOGLGNDGHOF)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DHGHBCHOJNI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum OAGJKJINNJB
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
	public class OBFELFGKNNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly OAGJKJINNJB BEMGLIBFJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly PNBDJNFOOBF OEJGEABNNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long EGNGEFNCFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long KMEKDIHLMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long ODJMFPPJODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int NNMHDNGCEFB;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7020", Offset = "0x8ED5E20", VA = "0x188ED7020")]
		public OBFELFGKNNM(OAGJKJINNJB PENOCPICAAI, int HJHGJJAOCMD = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7000", Offset = "0x8ED5E00", VA = "0x188ED7000")]
		public void NKGBEBGIBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8ED6ED0", Offset = "0x8ED5CD0", VA = "0x188ED6ED0")]
		public void FABMEOPOBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8ED6F20", Offset = "0x8ED5D20", VA = "0x188ED6F20")]
		public void JFKOEJCIDEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static OAGJKJINNJB[] BCEGKLCGAEG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static OBFELFGKNNM[] CDLIGPKOGED;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8EC9730", Offset = "0x8EC8530", VA = "0x188EC9730")]
	public static OBFELFGKNNM PEANECEBMCA(OAGJKJINNJB OPGJHIOADCK, int HJHGJJAOCMD = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8EC96C0", Offset = "0x8EC84C0", VA = "0x188EC96C0")]
	public static OBFELFGKNNM KFEBKBNFKHL(OAGJKJINNJB OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8EC9620", Offset = "0x8EC8420", VA = "0x188EC9620")]
	public static void ANHEMCCLDGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FMAMAKNDEMP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface KELFMIAPFJL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool KIIPOFKFFKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HNMLKBBINMN();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class FKLIIHEMABC : KELFMIAPFJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Action IJBAPONMLAP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KIIPOFKFFKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
		public FKLIIHEMABC(Action IJBAPONMLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x13091E0", Offset = "0x1307FE0", VA = "0x1813091E0", Slot = "5")]
		public void HNMLKBBINMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<KELFMIAPFJL> PBLLPINNIIO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static bool IADKMMNPFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8ECBDD0", Offset = "0x8ECABD0", VA = "0x188ECBDD0")]
	public static void MJENOEJGFJJ(Action IJBAPONMLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8ECBE70", Offset = "0x8ECAC70", VA = "0x188ECBE70")]
	private static void OOHIOPDPIGM(KELFMIAPFJL OBCKIAAMEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8ECBAF0", Offset = "0x8ECA8F0", VA = "0x188ECBAF0")]
	private static void JGLLKGKNHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8ECB880", Offset = "0x8ECA680", VA = "0x188ECB880")]
	private static void AIBEMNGEOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8ECB9D0", Offset = "0x8ECA7D0", VA = "0x188ECB9D0")]
	private static void GCJEAIKMKOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class INFLJPCICCB
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8ED0030", Offset = "0x8ECEE30", VA = "0x188ED0030")]
	public static IDisposable IMKNBDCAPDK(this LFEBOEMIPAD KKBNGKDBMPF, float NKPFOAEBPDM, Action<float> PCOHPKACIBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8ED00C0", Offset = "0x8ECEEC0", VA = "0x188ED00C0")]
	public static IDisposable IOLOHJLEJLE(this LFEBOEMIPAD KKBNGKDBMPF, Action<float> PCOHPKACIBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8ECFFB0", Offset = "0x8ECEDB0", VA = "0x188ECFFB0")]
	public static IDisposable AEOMFPDBLOG(this LFEBOEMIPAD KKBNGKDBMPF, Action<float> PCOHPKACIBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OEGFHOKMJFG
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE510", Offset = "0x3EAD310", VA = "0x183EAE510")]
	[ALDAICPKDJG]
	public static IDisposable MOCJBDHNBPI<T>(this T AAJIFFABDID, Action PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE6C0", Offset = "0x3EAD4C0", VA = "0x183EAE6C0")]
	[ALDAICPKDJG]
	public static IDisposable MOCJBDHNBPI<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3EADFB0", Offset = "0x3EACDB0", VA = "0x183EADFB0")]
	[ALDAICPKDJG]
	public static IDisposable AFCEEABIEMI<T>(this T AAJIFFABDID, Action PCOHPKACIBI, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE020", Offset = "0x3EACE20", VA = "0x183EAE020")]
	[ALDAICPKDJG]
	public static IDisposable BMCMNOGFHGB<T>(this T AAJIFFABDID, Action PCOHPKACIBI, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE020", Offset = "0x3EACE20", VA = "0x183EAE020")]
	[ALDAICPKDJG]
	public static IDisposable BMCMNOGFHGB<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE460", Offset = "0x3EAD260", VA = "0x183EAE460")]
	[ALDAICPKDJG]
	public static IDisposable JLHMIEDFEEL<T>(this T AAJIFFABDID, Action PCOHPKACIBI, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE2C0", Offset = "0x3EAD0C0", VA = "0x183EAE2C0")]
	[ALDAICPKDJG]
	public static IDisposable GAFLDHGBJAL<T>(this T AAJIFFABDID, Action PCOHPKACIBI, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE3B0", Offset = "0x3EAD1B0", VA = "0x183EAE3B0")]
	[ALDAICPKDJG]
	public static IDisposable GLLEIMDJLFP<T>(this T AAJIFFABDID, Action PCOHPKACIBI, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE490", Offset = "0x3EAD290", VA = "0x183EAE490")]
	[ALDAICPKDJG]
	public static IDisposable KDANKKKFEGI<T>(this T AAJIFFABDID, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7400", Offset = "0x8ED6200", VA = "0x188ED7400")]
	[ALDAICPKDJG]
	public static IDisposable KDANKKKFEGI(this MonoBehaviour AAJIFFABDID, HNBEDMLJAOM KKBNGKDBMPF, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE090", Offset = "0x3EACE90", VA = "0x183EAE090")]
	[ALDAICPKDJG]
	public static IDisposable CNAFABJCBMP<T>(this T AAJIFFABDID, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE050", Offset = "0x3EACE50", VA = "0x183EAE050")]
	[ALDAICPKDJG]
	public static IDisposable CDMCHPMFPFF<T>(this T AAJIFFABDID, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE4D0", Offset = "0x3EAD2D0", VA = "0x183EAE4D0")]
	[ALDAICPKDJG]
	public static IDisposable MFKGCJHOLHH<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE280", Offset = "0x3EAD080", VA = "0x183EAE280")]
	[ALDAICPKDJG]
	public static IDisposable EFBFFIKHDPD<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE2F0", Offset = "0x3EAD0F0", VA = "0x183EAE2F0")]
	[ALDAICPKDJG]
	public static IDisposable GBDDJAFEOOK<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3EADFE0", Offset = "0x3EACDE0", VA = "0x183EADFE0")]
	[ALDAICPKDJG]
	public static IDisposable BCLELFPAMED<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE330", Offset = "0x3EAD130", VA = "0x183EAE330")]
	[ALDAICPKDJG]
	public static IDisposable GBGGJJPAJLE<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE420", Offset = "0x3EAD220", VA = "0x183EAE420")]
	[ALDAICPKDJG]
	public static IDisposable IDFAGGADKLN<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE370", Offset = "0x3EAD170", VA = "0x183EAE370")]
	[ALDAICPKDJG]
	public static IDisposable GDIPFBCNGGK<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE240", Offset = "0x3EAD040", VA = "0x183EAE240")]
	[ALDAICPKDJG]
	public static IDisposable DAPMCMLJHCI<T>(this T AAJIFFABDID, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE3E0", Offset = "0x3EAD1E0", VA = "0x183EAE3E0")]
	[ALDAICPKDJG]
	public static IDisposable HBGJIFPOFJG<T>(this T AAJIFFABDID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true) where T : MonoBehaviour, HNBEDMLJAOM
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OEFLDOMNOAP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class OFPNJNBIAGP : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AANAJHMODAE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private KJLHLJMIKMJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public OFPNJNBIAGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8ED75E0", Offset = "0x8ED63E0", VA = "0x188ED75E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8ED76C0", Offset = "0x8ED64C0", VA = "0x188ED76C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class AEPGCMHKLBD : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AANAJHMODAE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private KJLHLJMIKMJ <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public AEPGCMHKLBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8EC69E0", Offset = "0x8EC57E0", VA = "0x188EC69E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8EC6AD0", Offset = "0x8EC58D0", VA = "0x188EC6AD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8ED72A0", Offset = "0x8ED60A0", VA = "0x188ED72A0")]
	public static GMJHELKMAKL MOCJBDHNBPI(Action PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7210", Offset = "0x8ED6010", VA = "0x188ED7210")]
	public static GMJHELKMAKL MOCJBDHNBPI(Behaviour KKBNGKDBMPF, Action PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7320", Offset = "0x8ED6120", VA = "0x188ED7320")]
	public static GMJHELKMAKL MOCJBDHNBPI(Behaviour KKBNGKDBMPF, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8ED70F0", Offset = "0x8ED5EF0", VA = "0x188ED70F0")]
	[IteratorStateMachine(typeof(OFPNJNBIAGP))]
	private static IEnumerator<PHFDFIIIMCE> AKALLFMAEAB(AANAJHMODAE CFBEEIBDCID, Action PCOHPKACIBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7180", Offset = "0x8ED5F80", VA = "0x188ED7180")]
	[IteratorStateMachine(typeof(AEPGCMHKLBD))]
	private static IEnumerator<PHFDFIIIMCE> AKALLFMAEAB(AANAJHMODAE CFBEEIBDCID, Action<float> PCOHPKACIBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AFIFIMDPEJM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FLGNMHEDGBI : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AFIFIMDPEJM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public FLGNMHEDGBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB7A0", Offset = "0x8ECA5A0", VA = "0x188ECB7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB830", Offset = "0x8ECA630", VA = "0x188ECB830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly AANAJHMODAE PAKKOLECNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private Action BMACCFIOKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool LAOMEDFNGCM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FCMNOCKJCIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8EC6C40", Offset = "0x8EC5A40", VA = "0x188EC6C40")]
	public AFIFIMDPEJM(AANAJHMODAE PAKKOLECNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8EC6B20", Offset = "0x8EC5920", VA = "0x188EC6B20")]
	[IteratorStateMachine(typeof(FLGNMHEDGBI))]
	private IEnumerator<PHFDFIIIMCE> BLOMMGPJOLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8EC6BA0", Offset = "0x8EC59A0", VA = "0x188EC6BA0", Slot = "4")]
	public void OnCompleted(Action JGIIFIKIOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	public void PBHLDDBJPIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JALCBJNOELI
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8ED0C70", Offset = "0x8ECFA70", VA = "0x188ED0C70")]
	public static AFIFIMDPEJM MPIMODFPFBE(this AANAJHMODAE PAKKOLECNNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IAJDNOEMMKM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PLDKKLIDIIC : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public OFEFHKKLJGH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public PLDKKLIDIIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8ED86C0", Offset = "0x8ED74C0", VA = "0x188ED86C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8ED8740", Offset = "0x8ED7540", VA = "0x188ED8740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD860", Offset = "0x8ECC660", VA = "0x188ECD860")]
	public static GMJHELKMAKL MOCJBDHNBPI(float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD930", Offset = "0x8ECC730", VA = "0x188ECD930")]
	public static GMJHELKMAKL MOCJBDHNBPI(MonoBehaviour AAJIFFABDID, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD770", Offset = "0x8ECC570", VA = "0x188ECD770")]
	public static GMJHELKMAKL EIOFHMACMHF(MonoBehaviour AAJIFFABDID, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD6A0", Offset = "0x8ECC4A0", VA = "0x188ECD6A0")]
	public static GMJHELKMAKL DAKIJOEJEGL(LFEBOEMIPAD KKBNGKDBMPF, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD550", Offset = "0x8ECC350", VA = "0x188ECD550")]
	private static IEnumerator<PHFDFIIIMCE> AKALLFMAEAB(FHOODIECIHH NDHKHNKGOHL, float NKPFOAEBPDM, AANAJHMODAE CFBEEIBDCID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD4F0", Offset = "0x8ECC2F0", VA = "0x188ECD4F0")]
	private static IEnumerator<PHFDFIIIMCE> AEHMPKKLDIC(FHOODIECIHH NDHKHNKGOHL, float NKPFOAEBPDM, AANAJHMODAE CFBEEIBDCID, Action<float> PCOHPKACIBI, bool DAKOPHEHOGL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD610", Offset = "0x8ECC410", VA = "0x188ECD610")]
	[IteratorStateMachine(typeof(PLDKKLIDIIC))]
	private static IEnumerator<PHFDFIIIMCE> BDILDMOEJMM(OFEFHKKLJGH OOBDFIINHDJ, float NKPFOAEBPDM, AANAJHMODAE CFBEEIBDCID, Action<float> PCOHPKACIBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class COMGFBFNPKL
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JJLLKDIIMLM : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AANAJHMODAE queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public JJLLKDIIMLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8ED10D0", Offset = "0x8ECFED0", VA = "0x188ED10D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8ED1190", Offset = "0x8ECFF90", VA = "0x188ED1190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8EC8090", Offset = "0x8EC6E90", VA = "0x188EC8090")]
	[IteratorStateMachine(typeof(JJLLKDIIMLM))]
	private static IEnumerator<PHFDFIIIMCE> NLBEHAPCLKE(AANAJHMODAE PAKKOLECNNK, Func<bool> ECNHPJKBPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8EC7FB0", Offset = "0x8EC6DB0", VA = "0x188EC7FB0")]
	public static GMJHELKMAKL GCBCOOJJLOF(this MonoBehaviour AAJIFFABDID, Func<bool> ECNHPJKBPID, AANAJHMODAE PAKKOLECNNK = AANAJHMODAE.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OOFKAPOKIEI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class OOBAHJAEKBE : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AANAJHMODAE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public OOBAHJAEKBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7710", Offset = "0x8ED6510", VA = "0x188ED7710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8ED7780", Offset = "0x8ED6580", VA = "0x188ED7780", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FDFPJINEOHO<T> : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AANAJHMODAE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Action<T> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public T arg;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public FDFPJINEOHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4EFFB70", Offset = "0x4EFE970", VA = "0x184EFFB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4EFFBF0", Offset = "0x4EFE9F0", VA = "0x184EFFBF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HHLPKMFNOOM : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AANAJHMODAE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private PHFDFIIIMCE <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public HHLPKMFNOOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8ECD410", Offset = "0x8ECC210", VA = "0x188ECD410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8ECD4A0", Offset = "0x8ECC2A0", VA = "0x188ECD4A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7900", Offset = "0x8ED6700", VA = "0x188ED7900")]
	[IteratorStateMachine(typeof(OOBAHJAEKBE))]
	private static IEnumerator<PHFDFIIIMCE> BLOMMGPJOLK(float KBODPDIPNAF, AANAJHMODAE CFBEEIBDCID, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0AC0", Offset = "0x3EEF8C0", VA = "0x183EF0AC0")]
	[IteratorStateMachine(typeof(FDFPJINEOHO<>))]
	private static IEnumerator<PHFDFIIIMCE> BLOMMGPJOLK<T>(float KBODPDIPNAF, AANAJHMODAE CFBEEIBDCID, Action<T> OHHICGADAKK, T EIENELGOLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7E90", Offset = "0x8ED6C90", VA = "0x188ED7E90")]
	[IteratorStateMachine(typeof(HHLPKMFNOOM))]
	private static IEnumerator<PHFDFIIIMCE> HLKLIPHLAMG(float KBODPDIPNAF, AANAJHMODAE CFBEEIBDCID, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7B80", Offset = "0x8ED6980", VA = "0x188ED7B80")]
	public static IDisposable EEKOOKDNOCG(this MonoBehaviour AAJIFFABDID, float KBODPDIPNAF, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7870", Offset = "0x8ED6670", VA = "0x188ED7870")]
	public static GMJHELKMAKL BHCBPOPLCBD(this MonoBehaviour AAJIFFABDID, float KBODPDIPNAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7C60", Offset = "0x8ED6A60", VA = "0x188ED7C60")]
	public static GMJHELKMAKL EEKOOKDNOCG(this MonoBehaviour AAJIFFABDID, float KBODPDIPNAF, AANAJHMODAE CFBEEIBDCID, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7AE0", Offset = "0x8ED68E0", VA = "0x188ED7AE0")]
	public static GMJHELKMAKL EDBKJNMBPJJ(this MonoBehaviour AAJIFFABDID, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0CB0", Offset = "0x3EEFAB0", VA = "0x183EF0CB0")]
	public static GMJHELKMAKL EDBKJNMBPJJ<T>(this MonoBehaviour AAJIFFABDID, Action<T> OHHICGADAKK, T EIENELGOLAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8ED8060", Offset = "0x8ED6E60", VA = "0x188ED8060")]
	public static GMJHELKMAKL LAEFOICIDLF(this MonoBehaviour AAJIFFABDID, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7D50", Offset = "0x8ED6B50", VA = "0x188ED7D50")]
	public static GMJHELKMAKL FKNACCPNAKN(this MonoBehaviour AAJIFFABDID, Action OHHICGADAKK, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8ED79A0", Offset = "0x8ED67A0", VA = "0x188ED79A0")]
	public static GMJHELKMAKL CEECJMIGFLA(this MonoBehaviour AAJIFFABDID, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8ED8100", Offset = "0x8ED6F00", VA = "0x188ED8100")]
	public static GMJHELKMAKL PEAKLDFLEOB(this MonoBehaviour AAJIFFABDID, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7A40", Offset = "0x8ED6840", VA = "0x188ED7A40")]
	public static GMJHELKMAKL DMBPCPADIBI(MonoBehaviour AAJIFFABDID, AANAJHMODAE PAKKOLECNNK, Action OHHICGADAKK, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3EF0B80", Offset = "0x3EEF980", VA = "0x183EF0B80")]
	public static GMJHELKMAKL DMBPCPADIBI<T>(MonoBehaviour AAJIFFABDID, AANAJHMODAE PAKKOLECNNK, Action<T> OHHICGADAKK, T EIENELGOLAB, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7F30", Offset = "0x8ED6D30", VA = "0x188ED7F30")]
	public static GMJHELKMAKL KMCIDACCBIJ(this MonoBehaviour AAJIFFABDID, float IPPIKDFBJOI, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8ED77D0", Offset = "0x8ED65D0", VA = "0x188ED77D0")]
	public static GMJHELKMAKL BAGLHFJFLIN(this MonoBehaviour AAJIFFABDID, float IPPIKDFBJOI, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7FC0", Offset = "0x8ED6DC0", VA = "0x188ED7FC0")]
	public static GMJHELKMAKL KNBJECODNDC(this MonoBehaviour AAJIFFABDID, float IPPIKDFBJOI, Action OHHICGADAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8ED7DF0", Offset = "0x8ED6BF0", VA = "0x188ED7DF0")]
	public static GMJHELKMAKL GAIHDOPKCJD(this MonoBehaviour AAJIFFABDID, float IPPIKDFBJOI, Action OHHICGADAKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JLCHCFGMCEK : OKBAHHLOHBD, IEnumerable<OKBAHHLOHBD>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly List<OKBAHHLOHBD> PAHLFCPMLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool CEOIBDIJOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private Action CJJOBOOGFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool BMBOPHKOJKN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GMINEBGDLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8ED1390", Offset = "0x8ED0190", VA = "0x188ED1390", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action MKFEGECKFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8ED14C0", Offset = "0x8ED02C0", VA = "0x188ED14C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8ED1870", Offset = "0x8ED0670", VA = "0x188ED1870", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8ED1A60", Offset = "0x8ED0860", VA = "0x188ED1A60")]
	public JLCHCFGMCEK([Optional] Action CJJOBOOGFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8ED11E0", Offset = "0x8ECFFE0", VA = "0x188ED11E0")]
	public void DPHJBDIDPOG(OKBAHHLOHBD IFPGMLFABHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8ED1910", Offset = "0x8ED0710", VA = "0x188ED1910")]
	private void MPBOPACHFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8ED1560", Offset = "0x8ED0360", VA = "0x188ED1560", Slot = "7")]
	public bool JJCDFFKBJIK(bool PPPGPLMAHNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8ED1570", Offset = "0x8ED0370", VA = "0x188ED1570", Slot = "8")]
	public bool JJCDFFKBJIK(Action IJBAPONMLAP, bool PPPGPLMAHNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8ED1310", Offset = "0x8ED0110", VA = "0x188ED1310", Slot = "9")]
	public IEnumerator<OKBAHHLOHBD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8ED1310", Offset = "0x8ED0110", VA = "0x188ED1310", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JCGJNBHNPJJ : KIAGFIADJHA
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IJLFLFMHBGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public JCGJNBHNPJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public IJLFLFMHBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8ECFF80", Offset = "0x8ECED80", VA = "0x188ECFF80")]
		internal void FGMMHLHFFLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JMMMDHDJJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JCGJNBHNPJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public JMMMDHDJJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8ECFF80", Offset = "0x8ECED80", VA = "0x188ECFF80")]
		internal void LNEMIFLPKFA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly float LBNPMGAKGJO;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8EC7480", Offset = "0x8EC6280", VA = "0x188EC7480")]
	public JCGJNBHNPJJ(Behaviour KKBNGKDBMPF, float LBNPMGAKGJO, [Optional] Action CJJOBOOGFLP, [Optional] HKHGONAOEBE BJPOEFBBDNM, [Optional] FHOODIECIHH NDHKHNKGOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8ED0EB0", Offset = "0x8ECFCB0", VA = "0x188ED0EB0", Slot = "9")]
	protected override bool OBMAIGEPHLI(Action IJBAPONMLAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8ED0FC0", Offset = "0x8ECFDC0", VA = "0x188ED0FC0", Slot = "10")]
	protected override bool PICMKEOGKAA(Action IJBAPONMLAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OKBAHHLOHBD
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GMINEBGDLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MKFEGECKFPJ;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JJCDFFKBJIK(bool PPPGPLMAHNI = false);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JJCDFFKBJIK(Action IJBAPONMLAP, bool PPPGPLMAHNI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class KIAGFIADJHA : OKBAHHLOHBD
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class JODAODGGNLE : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public KIAGFIADJHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public JODAODGGNLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8ED1B00", Offset = "0x8ED0900", VA = "0x188ED1B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8ED1BD0", Offset = "0x8ED09D0", VA = "0x188ED1BD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Behaviour KKBNGKDBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Action CJJOBOOGFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private MDIEIFNFGHA LJDLNPOKHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HKHGONAOEBE BJPOEFBBDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly FHOODIECIHH NDHKHNKGOHL;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GMINEBGDLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D25DE0", Offset = "0x1D24BE0", VA = "0x181D25DE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MKFEGECKFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2D10", Offset = "0x8ED1B10", VA = "0x188ED2D10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8ED2E70", Offset = "0x8ED1C70", VA = "0x188ED2E70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2F10", Offset = "0x8ED1D10", VA = "0x188ED2F10")]
	protected KIAGFIADJHA(Behaviour KKBNGKDBMPF, [Optional] Action CJJOBOOGFLP, [Optional] HKHGONAOEBE BJPOEFBBDNM, [Optional] FHOODIECIHH NDHKHNKGOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2DB0", Offset = "0x8ED1BB0", VA = "0x188ED2DB0", Slot = "7")]
	public bool JJCDFFKBJIK(bool PPPGPLMAHNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2E10", Offset = "0x8ED1C10", VA = "0x188ED2E10", Slot = "8")]
	public bool JJCDFFKBJIK(Action IJBAPONMLAP, bool PPPGPLMAHNI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OBMAIGEPHLI(Action IJBAPONMLAP);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool PICMKEOGKAA(Action IJBAPONMLAP);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2C30", Offset = "0x8ED1A30", VA = "0x188ED2C30")]
	protected void DKDPDNMODGM(Action IJBAPONMLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2950", Offset = "0x8ED1750", VA = "0x188ED2950")]
	protected BFMPGGMMDDD BKFOHANECEF(float DFOOIFEDPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2C50", Offset = "0x8ED1A50", VA = "0x188ED2C50")]
	private void EMAEBMNEKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2BA0", Offset = "0x8ED19A0", VA = "0x188ED2BA0")]
	[IteratorStateMachine(typeof(JODAODGGNLE))]
	private IEnumerator<PHFDFIIIMCE> DDPMMDCCIPI(float DFOOIFEDPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2CD0", Offset = "0x8ED1AD0", VA = "0x188ED2CD0")]
	[CompilerGenerated]
	private void JEMEFMOBGDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PGIGIEGHPDN : KIAGFIADJHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly float AHKMLMAEOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly int GAIKGOCGBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly float MCBGNCGNOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly float[] PHHPPEFBBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int MADMHMKPEML;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8ED8470", Offset = "0x8ED7270", VA = "0x188ED8470")]
	public PGIGIEGHPDN(Behaviour KKBNGKDBMPF, float IFPJBBGFDBO, int GAIKGOCGBBF, [Optional] Action CJJOBOOGFLP, float MCBGNCGNOFC = 0f, [Optional] HKHGONAOEBE BJPOEFBBDNM, [Optional] FHOODIECIHH NDHKHNKGOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "9")]
	protected override bool OBMAIGEPHLI(Action IJBAPONMLAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8ED8270", Offset = "0x8ED7070", VA = "0x188ED8270", Slot = "10")]
	protected override bool PICMKEOGKAA(Action IJBAPONMLAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8ED81F0", Offset = "0x8ED6FF0", VA = "0x188ED81F0")]
	private void FHHCHFHKNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BGKMHMBJMGK : KIAGFIADJHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly float LBNPMGAKGJO;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8EC7480", Offset = "0x8EC6280", VA = "0x188EC7480")]
	public BGKMHMBJMGK(Behaviour KKBNGKDBMPF, float LBNPMGAKGJO, [Optional] Action CJJOBOOGFLP, [Optional] HKHGONAOEBE BJPOEFBBDNM, [Optional] FHOODIECIHH NDHKHNKGOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "9")]
	protected override bool OBMAIGEPHLI(Action IJBAPONMLAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8EC7440", Offset = "0x8EC6240", VA = "0x188EC7440", Slot = "10")]
	protected override bool PICMKEOGKAA(Action IJBAPONMLAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public sealed class BJAEBPBEFKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class OOPFOKDACHC : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public OOPFOKDACHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8ED6780", Offset = "0x8ED5580", VA = "0x188ED6780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8ED81A0", Offset = "0x8ED6FA0", VA = "0x188ED81A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private GMJHELKMAKL MIPKJNIEGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private LFEBOEMIPAD KKBNGKDBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Action<float> GHPPOCAEHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private AANAJHMODAE PAKKOLECNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private float COICNDEIDHJ;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8EC7AC0", Offset = "0x8EC68C0", VA = "0x188EC7AC0")]
	public BJAEBPBEFKE(LFEBOEMIPAD KKBNGKDBMPF, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8EC7950", Offset = "0x8EC6750", VA = "0x188EC7950")]
	private void OLNHPGMNHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8EC75C0", Offset = "0x8EC63C0", VA = "0x188EC75C0")]
	private void CJJGIBHFIDA(string DFOJBJDIKPM, Action DNPACECEAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8EC76F0", Offset = "0x8EC64F0", VA = "0x188EC76F0")]
	[IteratorStateMachine(typeof(OOPFOKDACHC))]
	private IEnumerator<PHFDFIIIMCE> DGPHEFOENHF(Action DNPACECEAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8EC7770", Offset = "0x8EC6570", VA = "0x188EC7770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8EC77D0", Offset = "0x8EC65D0", VA = "0x188EC77D0")]
	[CompilerGenerated]
	private void JBAHGKLCMOJ(string DNLEOFNAGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class FNKBLBDDPBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MDECKIJPEEI : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private PHFDFIIIMCE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public MDECKIJPEEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8ED6780", Offset = "0x8ED5580", VA = "0x188ED6780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8ED67F0", Offset = "0x8ED55F0", VA = "0x188ED67F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private GMJHELKMAKL MIPKJNIEGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private MonoBehaviour AAJIFFABDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Action PCOHPKACIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Action<float> GHPPOCAEHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private AANAJHMODAE PAKKOLECNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private float COICNDEIDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private bool DAKOPHEHOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly HKHGONAOEBE BJPOEFBBDNM;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8ECCDE0", Offset = "0x8ECBBE0", VA = "0x188ECCDE0")]
	public FNKBLBDDPBB(MonoBehaviour AAJIFFABDID, Action PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD150", Offset = "0x8ECBF50", VA = "0x188ECD150")]
	public FNKBLBDDPBB(MonoBehaviour AAJIFFABDID, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8ECCF70", Offset = "0x8ECBD70", VA = "0x188ECCF70")]
	public FNKBLBDDPBB(MonoBehaviour AAJIFFABDID, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xF16B40", Offset = "0xF15940", VA = "0x180F16B40")]
	private FNKBLBDDPBB(HKHGONAOEBE BJPOEFBBDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8ECC3F0", Offset = "0x8ECB1F0", VA = "0x188ECC3F0")]
	internal static FNKBLBDDPBB DOFFBPGHNPI(MonoBehaviour AAJIFFABDID, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, [Optional] HKHGONAOEBE BJPOEFBBDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8ECC990", Offset = "0x8ECB790", VA = "0x188ECC990")]
	private void MOCJBDHNBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8ECC680", Offset = "0x8ECB480", VA = "0x188ECC680")]
	private void HPLAIGGEJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8ECCBE0", Offset = "0x8ECB9E0", VA = "0x188ECCBE0")]
	private void OLNHPGMNHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8ECC800", Offset = "0x8ECB600", VA = "0x188ECC800")]
	private void JNOMEGOEBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8ECC1B0", Offset = "0x8ECAFB0", VA = "0x188ECC1B0")]
	private void CJJGIBHFIDA(string DFOJBJDIKPM, Action DNPACECEAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8ECC2E0", Offset = "0x8ECB0E0", VA = "0x188ECC2E0")]
	[IteratorStateMachine(typeof(MDECKIJPEEI))]
	private IEnumerator<PHFDFIIIMCE> DGPHEFOENHF(Action DNPACECEAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8ECC620", Offset = "0x8ECB420", VA = "0x188ECC620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8ECCB50", Offset = "0x8ECB950", VA = "0x188ECCB50")]
	[CompilerGenerated]
	private void OHIKEMAIAJH(string DNLEOFNAGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8ECCD50", Offset = "0x8ECBB50", VA = "0x188ECCD50")]
	[CompilerGenerated]
	private void POECGPMEAEA(string DNLEOFNAGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8ECC360", Offset = "0x8ECB160", VA = "0x188ECC360")]
	[CompilerGenerated]
	private void DHJHFDBAOAM(string DNLEOFNAGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8ECCAC0", Offset = "0x8ECB8C0", VA = "0x188ECCAC0")]
	[CompilerGenerated]
	private void MPFBIFBBNAH(string DNLEOFNAGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
internal enum FCOJKINLOGE : byte
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
internal sealed class HBKHJOLCDGK : FHOODIECIHH
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public float EKCKINLNALO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8ECD3F0", Offset = "0x8ECC1F0", VA = "0x188ECD3F0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public float BEEJILACJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8ECD400", Offset = "0x8ECC200", VA = "0x188ECD400", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public double ABPJADIJECB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8ECD360", Offset = "0x8ECC160", VA = "0x188ECD360", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x8ECD380", Offset = "0x8ECC180", VA = "0x188ECD380")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void ODAPPKPCBLD(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	[UnityEngine.Scripting.Preserve]
	internal HBKHJOLCDGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface EENFEGGFGDO
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GAALCDKKNNJ(string PFLDDMDPCBI);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNLBHMJNMDN();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface GCJKNNBEHDC
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IKLOPDIDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool MIEEPFGDAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal class MANEKFDMJLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public KMNFMDELGDC ICKKOANNGJB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int NELPMDCEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6420", Offset = "0x8ED5220", VA = "0x188ED6420")]
	public static PHFDFIIIMCE CAFDDMOMBCL(IEnumerator<PHFDFIIIMCE> AENONOIGDOI, PGLHDADPCBH LDOEPLPMHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6580", Offset = "0x8ED5380", VA = "0x188ED6580")]
	public PHFDFIIIMCE CAFDDMOMBCL(PGLHDADPCBH[] EHCJCMCNMMF, IEnumerator<PHFDFIIIMCE>[] IFLODIFMIAL, PHFDFIIIMCE[] IEGJCBMIPLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8ED63F0", Offset = "0x8ED51F0", VA = "0x188ED63F0")]
	public void AECGNHLLOJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6640", Offset = "0x8ED5440", VA = "0x188ED6640")]
	public void GCCHMNBJFJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x8ED62B0", Offset = "0x8ED50B0", VA = "0x188ED62B0")]
	public void AALJBDJJCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x8ED63F0", Offset = "0x8ED51F0", VA = "0x188ED63F0")]
	public void HHJCEDNCEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public MANEKFDMJLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KMNFMDELGDC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct HLJNOFFAAOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public MANEKFDMJLJ LIBEBNEGLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public LFEBOEMIPAD NIGPLCANCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public PGLHDADPCBH LHFGIHJIPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public IEnumerator<PHFDFIIIMCE> FFLAGNKANPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public PHFDFIIIMCE ALGCABOEJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public FCOJKINLOGE MBIPEOOMDFD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct PKNFJIAAOKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AANAJHMODAE BDGKJGDBOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public List<HLJNOFFAAOM> DPCMACIDFMG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class KJEBJJJCEOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public PGLHDADPCBH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public KMNFMDELGDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public LFEBOEMIPAD context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public MANEKFDMJLJ routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public FCOJKINLOGE coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public PHFDFIIIMCE currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public IEnumerator<PHFDFIIIMCE> coroutine;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KJEBJJJCEOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8ED3040", Offset = "0x8ED1E40", VA = "0x188ED3040")]
		internal void GHPIMGHBPEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GHDLKOFEJLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public MANEKFDMJLJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public KMNFMDELGDC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GHDLKOFEJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8ECD320", Offset = "0x8ECC120", VA = "0x188ECD320")]
		internal void ANGBFCDMHIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class FMKNBMMBNII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public MANEKFDMJLJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public KMNFMDELGDC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public FMKNBMMBNII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8ECC170", Offset = "0x8ECAF70", VA = "0x188ECC170")]
		internal void GNPCCJPIIPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class ODEBBAIMGNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public MANEKFDMJLJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public KMNFMDELGDC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public ODEBBAIMGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8ED70B0", Offset = "0x8ED5EB0", VA = "0x188ED70B0")]
		internal void CEHAFEODCJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private const FCOJKINLOGE GHODBBIHEAE = FCOJKINLOGE.Cancelled | FCOJKINLOGE.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AANAJHMODAE PAKKOLECNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool[] EKIFKMEEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private NativeArray<FCOJKINLOGE> CIINPOGNPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private NativeArray<float> EMNAOOCJBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private NativeArray<int> NIMJBPPMABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeArray<int> NLLLLGMNBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<int> AMLEGHKKAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<int> PPLLKNFNENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<int> EOMKCOCMDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private MANEKFDMJLJ[] EIMDKOOGKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private PGLHDADPCBH[] EHCJCMCNMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private LFEBOEMIPAD[] GFLBBONIJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private IEnumerator<PHFDFIIIMCE>[] ADPPNLCEPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private PHFDFIIIMCE[] MENHNLDMIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int HHPENBMFMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int FIBLEJKLMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly int LABFPKGJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float NLOOOPILGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private MOKCLOIAAHH POFKGEBIJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private JobHandle GDOCAEPKIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private List<MANEKFDMJLJ> MKIFAIFCIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool DCNHAELEDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private List<Action> OLOAKHFBNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private List<Action> OADAPOPHPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool KMAEIODOBDK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public PKNFJIAAOKO[] PMBDNGGEKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xC0E3F0", Offset = "0xC0D1F0", VA = "0x180C0E3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8ED4A70", Offset = "0x8ED3870", VA = "0x188ED4A70")]
	private static int HJGMEOFLCMA(AANAJHMODAE PAKKOLECNNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8ED5BA0", Offset = "0x8ED49A0", VA = "0x188ED5BA0")]
	public KMNFMDELGDC(AANAJHMODAE PAKKOLECNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8ED52A0", Offset = "0x8ED40A0", VA = "0x188ED52A0")]
	private void PDGHEGCKBLJ(int BNPIOKAPMHI, int LFFLNFPOCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8ED3B80", Offset = "0x8ED2980", VA = "0x188ED3B80")]
	public void CMLIGNGEPDC(LFEBOEMIPAD KKBNGKDBMPF, PHFDFIIIMCE NGILONMEJHM, IEnumerator<PHFDFIIIMCE> AENONOIGDOI, PGLHDADPCBH LDOEPLPMHHM, [Optional] MANEKFDMJLJ PMOBKOJPPJI, FCOJKINLOGE CKILHBCNBLF = FCOJKINLOGE.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8ED3940", Offset = "0x8ED2740", VA = "0x188ED3940")]
	public void BFILBEHJCAP(IEnumerable<HLJNOFFAAOM> MMJLOHJNNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8ED4100", Offset = "0x8ED2F00", VA = "0x188ED4100")]
	private HLJNOFFAAOM GJLNGPMLJIJ(int HFCPJBKCMDM)
	{
		return default(HLJNOFFAAOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8ED45D0", Offset = "0x8ED33D0", VA = "0x188ED45D0")]
	private void HBGDEFBOFLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6C00", Offset = "0x3DB5A00", VA = "0x183DB6C00")]
	private static void HBDHNHMLMHM<T>(int HFCPJBKCMDM, T[] NPIGGLAKION, int BCMFMCHGEKF, [Optional] T LOKBGKOOLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6C50", Offset = "0x3DB5A50", VA = "0x183DB6C50")]
	private static void HBDHNHMLMHM<T>(int HFCPJBKCMDM, NativeArray<T> NPIGGLAKION, int BCMFMCHGEKF, [Optional] T LOKBGKOOLHI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x8ED4F00", Offset = "0x8ED3D00", VA = "0x188ED4F00")]
	private void OOMKNDEBGAF(IEnumerable<HLJNOFFAAOM> MMJLOHJNNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8ED4E30", Offset = "0x8ED3C30", VA = "0x188ED4E30")]
	private void IDNIMNMIKHN(HLJNOFFAAOM LKCKCPDDBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x8ED4AA0", Offset = "0x8ED38A0", VA = "0x188ED4AA0")]
	private NFONMELJMJI HPNNLDDNAPE(int PHPGHLKNFGB)
	{
		return default(NFONMELJMJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8ED3D80", Offset = "0x8ED2B80", VA = "0x188ED3D80")]
	public void EMIKIKCEGIE(float NDIHBLABBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8ED4080", Offset = "0x8ED2E80", VA = "0x188ED4080")]
	private void FIGJHFDPAJP(Action GENJGFGGINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8ED3D00", Offset = "0x8ED2B00", VA = "0x188ED3D00")]
	private void DEMGPOBJIEL(Action GENJGFGGINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8ED5480", Offset = "0x8ED4280", VA = "0x188ED5480")]
	public void PLBJMFEHEOP(float NDIHBLABBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8ED3F80", Offset = "0x8ED2D80", VA = "0x188ED3F80")]
	public void FFICDEPBOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8ED4940", Offset = "0x8ED3740", VA = "0x188ED4940")]
	public void HHJCEDNCEAF(MANEKFDMJLJ OOBDFIINHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8ED3810", Offset = "0x8ED2610", VA = "0x188ED3810")]
	public void BDCEPMMAHDG(MANEKFDMJLJ OOBDFIINHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8ED4D00", Offset = "0x8ED3B00", VA = "0x188ED4D00")]
	public void ICGBDPEJFKN(MANEKFDMJLJ OOBDFIINHDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FCFJPCBKLGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public static readonly FCFJPCBKLGJ FBGBKFBLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Action GAOPJHAPCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool PJLPIIDDCCN;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public FCFJPCBKLGJ(Action GAOPJHAPCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x84F3750", Offset = "0x84F2550", VA = "0x1884F3750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MNBAPCMGGIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable JLFOIMMDNID(UnityEngine.Object KKBNGKDBMPF, Action<T> PEDPFOLMEFD);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BGJLECLNHMC<T> : MNBAPCMGGIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	new T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NKJPLBLJGIB<T> : BGJLECLNHMC<T>, MNBAPCMGGIL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KDLMMJLDECP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public NKJPLBLJGIB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public OGJHBMKKKLB<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public KDLMMJLDECP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x55CAD10", Offset = "0x55C9B10", VA = "0x1855CAD10")]
		internal void PNPEFPAACHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static GameObject MGODFJKBEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<OGJHBMKKKLB<UnityEngine.Object, Action<T>>> FEBKNJGBGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private T PMNHFDHGLNK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAE1A10", Offset = "0xAE0810", VA = "0x180AE1A10", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5991640", Offset = "0x5990440", VA = "0x185991640", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5991740", Offset = "0x5990540", VA = "0x185991740")]
	private static bool JBOFJBMGBKH(T GENJGFGGINA, T KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x59921C0", Offset = "0x5990FC0", VA = "0x1859921C0")]
	public NKJPLBLJGIB(T EGEPJFCEHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5991840", Offset = "0x5990640", VA = "0x185991840", Slot = "6")]
	public IDisposable JLFOIMMDNID(UnityEngine.Object KKBNGKDBMPF, Action<T> PEDPFOLMEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5991B60", Offset = "0x5990960", VA = "0x185991B60")]
	private void LHDFANGJBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal class IDDJELPGFHL : JIJKLEDFEOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class DOHEIIFNIOO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private class LDHHNBDELPA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int FMFDAFLDAAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private DOHEIIFNIOO CFBEEIBDCID;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x105CC60", Offset = "0x105BA60", VA = "0x18105CC60")]
			public LDHHNBDELPA(int FMFDAFLDAAK, DOHEIIFNIOO CFBEEIBDCID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8ED61F0", Offset = "0x8ED4FF0", VA = "0x188ED61F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class KNMJJLODEMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int id;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public KNMJJLODEMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB761E0", Offset = "0xB74FE0", VA = "0x180B761E0")]
			internal bool FLCELNIDBFK(BDAAIDHKECF e)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class CJAFABENNBG : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private PHFDFIIIMCE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public DOHEIIFNIOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public FHOODIECIHH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private KJLHLJMIKMJ <schedule>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private List<BDAAIDHKECF> <updateIterationList>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public CJAFABENNBG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x8EC7C60", Offset = "0x8EC6A60", VA = "0x188EC7C60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8EC7F60", Offset = "0x8EC6D60", VA = "0x188EC7F60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly AANAJHMODAE PAKKOLECNNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private GMJHELKMAKL LDOEPLPMHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly List<BDAAIDHKECF> EIJDIHIGGMH;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8ECA0C0", Offset = "0x8EC8EC0", VA = "0x188ECA0C0")]
		public DOHEIIFNIOO(AANAJHMODAE PAKKOLECNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9F30", Offset = "0x8EC8D30", VA = "0x188EC9F30")]
		public IDisposable PFBDAGEDMEM(BDAAIDHKECF PJBMLGBHDLI, HKHGONAOEBE BJPOEFBBDNM, FHOODIECIHH CIEPDNOLKJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9DA0", Offset = "0x8EC8BA0", VA = "0x188EC9DA0")]
		private void LIBCEJPELKM(int FMFDAFLDAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9CC0", Offset = "0x8EC8AC0", VA = "0x188EC9CC0")]
		[IteratorStateMachine(typeof(CJAFABENNBG))]
		private IEnumerator<PHFDFIIIMCE> AKALLFMAEAB(FHOODIECIHH CIEPDNOLKJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8EC9D50", Offset = "0x8EC8B50", VA = "0x188EC9D50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class BDAAIDHKECF
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public enum JNEJLOJMAKM : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			EveryFrame,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Scheduled,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			ScheduledNonFramerateLimited
		}

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static int FDCJIOGMBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int FBLHFPABBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly HNBEDMLJAOM NIGPLCANCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly MonoBehaviour CLIEGAGADJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly Action AFCEEABIEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly Action<float> OMILHFHKDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly float AHKNOGODCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public float EMNAOOCJBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly string LBDOKALIJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly bool GBEGCKBIFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly JNEJLOJMAKM MABNIFNFHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool MKLKNACDLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public bool INEPNBHIDNG;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8EC72C0", Offset = "0x8EC60C0", VA = "0x188EC72C0")]
		public BDAAIDHKECF(HNBEDMLJAOM KKBNGKDBMPF, Action PCOHPKACIBI, bool PIOMBPAPGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8EC6F60", Offset = "0x8EC5D60", VA = "0x188EC6F60")]
		public BDAAIDHKECF(HNBEDMLJAOM KKBNGKDBMPF, Action<float> PCOHPKACIBI, bool PIOMBPAPGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8EC70E0", Offset = "0x8EC5EE0", VA = "0x188EC70E0")]
		public BDAAIDHKECF(HNBEDMLJAOM KKBNGKDBMPF, float NKPFOAEBPDM, Action<float> PCOHPKACIBI, FHOODIECIHH CIEPDNOLKJK, JNEJLOJMAKM GNKGOEGBACJ, bool DAKOPHEHOGL, bool PIOMBPAPGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8EC6D10", Offset = "0x8EC5B10", VA = "0x188EC6D10")]
		public bool KGPDGCMJNLL(float GJEDFMHCPFI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly HKHGONAOEBE BJPOEFBBDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly FHOODIECIHH NDHKHNKGOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<AANAJHMODAE, DOHEIIFNIOO> DLCNAFDLIMM;

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x8ECE060", Offset = "0x8ECCE60", VA = "0x188ECE060")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void FEDJKBMJONH(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8ECE4D0", Offset = "0x8ECD2D0", VA = "0x188ECE4D0")]
	[UnityEngine.Scripting.Preserve]
	internal IDDJELPGFHL([POMNKOCGGBN(null)] HKHGONAOEBE BJPOEFBBDNM, [POMNKOCGGBN(null)] FHOODIECIHH NDHKHNKGOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8ECDA00", Offset = "0x8ECC800", VA = "0x188ECDA00", Slot = "4")]
	public IDisposable AFCEEABIEMI(HNBEDMLJAOM KKBNGKDBMPF, Action LBJMJKFNAPH, AANAJHMODAE PAKKOLECNNK, bool PIOMBPAPGAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8ECDBF0", Offset = "0x8ECC9F0", VA = "0x188ECDBF0", Slot = "5")]
	public IDisposable AFCEEABIEMI(HNBEDMLJAOM KKBNGKDBMPF, Action<float> LBJMJKFNAPH, AANAJHMODAE PAKKOLECNNK, bool PIOMBPAPGAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8ECDF60", Offset = "0x8ECCD60", VA = "0x188ECDF60", Slot = "7")]
	public IDisposable CDMCHPMFPFF(HNBEDMLJAOM KKBNGKDBMPF, float NKPFOAEBPDM, Action<float> LBJMJKFNAPH, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8ECE0D0", Offset = "0x8ECCED0", VA = "0x188ECE0D0", Slot = "8")]
	public IDisposable KDGOLAFEFON(HNBEDMLJAOM KKBNGKDBMPF, float NKPFOAEBPDM, Action<float> LBJMJKFNAPH, AANAJHMODAE PAKKOLECNNK, bool DAKOPHEHOGL = true, bool PIOMBPAPGAN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8ECDDE0", Offset = "0x8ECCBE0", VA = "0x188ECDDE0", Slot = "6")]
	public IDisposable CDMCHPMFPFF(float NKPFOAEBPDM, Action<float> LBJMJKFNAPH, bool DAKOPHEHOGL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8ECE1D0", Offset = "0x8ECCFD0", VA = "0x188ECE1D0", Slot = "9")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8ECE390", Offset = "0x8ECD190", VA = "0x188ECE390")]
	private DOHEIIFNIOO MJBHICABPLD(AANAJHMODAE PAKKOLECNNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KABKNNJBDJC : DOLHPJAGODA, HKHGONAOEBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private KMNFMDELGDC[] EJEBPBCCKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private EENFEGGFGDO FFLEOBMIPMJ;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2820", Offset = "0x8ED1620", VA = "0x188ED2820")]
	[NKOKDPHOKEP.APMGAGDLDLC]
	internal static void ODAPPKPCBLD(HJFNEHLLJBB HPOMHCIJOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2890", Offset = "0x8ED1690", VA = "0x188ED2890")]
	[UnityEngine.Scripting.Preserve]
	public KABKNNJBDJC([POMNKOCGGBN(null)] AEGMEBNPFBL DABOEGJDMFN, [POMNKOCGGBN(null)] FHOODIECIHH NDHKHNKGOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8ED25D0", Offset = "0x8ED13D0", VA = "0x188ED25D0", Slot = "19")]
	public override GMJHELKMAKL NAPPNDGNILA(LFEBOEMIPAD KKBNGKDBMPF, IEnumerator<PHFDFIIIMCE> KAKFDALDNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2340", Offset = "0x8ED1140", VA = "0x188ED2340", Slot = "20")]
	public override void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8ED1E50", Offset = "0x8ED0C50", VA = "0x188ED1E50", Slot = "22")]
	public override void AJAGGFHPFEC(AANAJHMODAE PAKKOLECNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8ED1CE0", Offset = "0x8ED0AE0", VA = "0x188ED1CE0", Slot = "21")]
	protected override void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2080", Offset = "0x8ED0E80", VA = "0x188ED2080")]
	private KMNFMDELGDC DLBNDKNIOHE(AANAJHMODAE ADGMECOLKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2110", Offset = "0x8ED0F10", VA = "0x188ED2110", Slot = "23")]
	internal override IPHEKDLBFAA GOOJKEOONAD(IEnumerator<PHFDFIIIMCE> KAKFDALDNFE, Behaviour KKBNGKDBMPF, PGLHDADPCBH LDOEPLPMHHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8ED1C20", Offset = "0x8ED0A20", VA = "0x188ED1C20", Slot = "24")]
	internal override IIOPKOCAOHO AEHPMFIKNNC(AANAJHMODAE CFBEEIBDCID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8ED2700", Offset = "0x8ED1500", VA = "0x188ED2700")]
	private void NGBEGDMLCNP(KMNFMDELGDC OBPMIAFFLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8ED20B0", Offset = "0x8ED0EB0", VA = "0x188ED20B0", Slot = "25")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[BurstCompile]
internal struct MOKCLOIAAHH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[ReadOnly]
	public float DHKAJDMFDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[ReadOnly]
	public int LJOECBLKNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> OGGADOMBNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeArray<int> EMIIAIBKBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<int> BMINMILKMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	public NativeArray<FCOJKINLOGE> JLIJMHLAJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	public NativeArray<float> PHMGOBKEIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	[WriteOnly]
	public NativeArray<int> AMLEGHKKAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	[WriteOnly]
	public NativeArray<int> NIMJBPPMABH;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6A90", Offset = "0x8ED5890", VA = "0x188ED6A90")]
	public static MOKCLOIAAHH INIHOJCCLPM(int NLPFKHJNDDL, float NDIHBLABBCI, NativeArray<FCOJKINLOGE> CONJCJHEIEI, NativeArray<float> CPHJPHJMEIL, NativeArray<int> HHIKKFFAHDE, NativeArray<int> IPPNNADIGHP, NativeArray<int> BFBDOILEGAB, NativeArray<int> EMIIAIBKBIJ, NativeArray<int> BMINMILKMDH)
	{
		return default(MOKCLOIAAHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8ED69B0", Offset = "0x8ED57B0", VA = "0x188ED69B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6B20", Offset = "0x8ED5920", VA = "0x188ED6B20")]
	private bool KGOOAPANPLC(int JJJJBEGKNIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6AF0", Offset = "0x8ED58F0", VA = "0x188ED6AF0")]
	private void JDEMJDCFMCA(NativeArray<int> FECLLLBAKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6910", Offset = "0x8ED5710", VA = "0x188ED6910")]
	private int ECIDMKDHAAG(int IMPLPGBIOEH, int NOMFFKDDEEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6840", Offset = "0x8ED5640", VA = "0x188ED6840")]
	private void BGGNOFCOJPA(NativeArray<int> FECLLLBAKJD, int JKOPHEIOEAB, int BIHPDMNFJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8ED6B60", Offset = "0x8ED5960", VA = "0x188ED6B60")]
	private void LGICCNNHHED(NativeArray<int> FECLLLBAKJD, int NOCHCNKBONJ, int DJDMODEPKAD, int ELOBEIHMJGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class DOLHPJAGODA : HKHGONAOEBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly AEGMEBNPFBL DABOEGJDMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	protected readonly FHOODIECIHH NDHKHNKGOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private IIOPKOCAOHO[] OEHFLDDJHKK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static HKHGONAOEBE MOIOIMEFPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8ECAE40", Offset = "0x8EC9C40", VA = "0x188ECAE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static bool KOBMDGOKJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public AANAJHMODAE GDLBOHKIFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AANAJHMODAE);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public FHOODIECIHH DBMKIIADBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PHFDFIIIMCE CKGJALDOBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public PHFDFIIIMCE HDIAKCDKGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public PHFDFIIIMCE EPKHJPBBFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PHFDFIIIMCE NMJDGNKBMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8ECAB30", Offset = "0x8EC9930", VA = "0x188ECAB30")]
	public static GMJHELKMAKL FDEKEAEMFEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8ECB0C0", Offset = "0x8EC9EC0", VA = "0x188ECB0C0")]
	[UnityEngine.Scripting.Preserve]
	protected DOLHPJAGODA([POMNKOCGGBN(null)] AEGMEBNPFBL DABOEGJDMFN, [POMNKOCGGBN(null)] FHOODIECIHH NDHKHNKGOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8ECAEB0", Offset = "0x8EC9CB0", VA = "0x188ECAEB0", Slot = "6")]
	public GMJHELKMAKL PLBGJCCDHGP(IEnumerator<PHFDFIIIMCE> KAKFDALDNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8ECAEC0", Offset = "0x8EC9CC0", VA = "0x188ECAEC0", Slot = "7")]
	public GMJHELKMAKL PLBGJCCDHGP(Behaviour KKBNGKDBMPF, IEnumerator<PHFDFIIIMCE> KAKFDALDNFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract GMJHELKMAKL NAPPNDGNILA(LFEBOEMIPAD KKBNGKDBMPF, IEnumerator<PHFDFIIIMCE> KAKFDALDNFE);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8ECAC00", Offset = "0x8EC9A00", VA = "0x188ECAC00", Slot = "20")]
	public virtual void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA8F0", Offset = "0x8EC96F0", VA = "0x188ECA8F0", Slot = "9")]
	public void EGIAAGLNDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA160", Offset = "0x8EC8F60", VA = "0x188ECA160", Slot = "21")]
	protected virtual void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA420", Offset = "0x8EC9220", VA = "0x188ECA420")]
	private void CEFDCLBAPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA210", Offset = "0x8EC9010", VA = "0x188ECA210")]
	private void BCICGCEDJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA230", Offset = "0x8EC9030", VA = "0x188ECA230")]
	private void BMCMNOGFHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8ECABE0", Offset = "0x8EC99E0", VA = "0x188ECABE0")]
	private void JLHMIEDFEEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8ECABC0", Offset = "0x8EC99C0", VA = "0x188ECABC0")]
	private void GLLHJGOKPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8ECADA0", Offset = "0x8EC9BA0", VA = "0x188ECADA0")]
	private void NIJDPHNKHFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8ECADC0", Offset = "0x8EC9BC0", VA = "0x188ECADC0")]
	private void ONGLIANAMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA180", Offset = "0x8EC8F80", VA = "0x188ECA180", Slot = "22")]
	public virtual void AJAGGFHPFEC(AANAJHMODAE PAKKOLECNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA250", Offset = "0x8EC9050", VA = "0x188ECA250")]
	private void CBKHNONPFJE(IIOPKOCAOHO OBPMIAFFLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x29687F0", Offset = "0x29675F0", VA = "0x1829687F0")]
	private IIOPKOCAOHO BHICHANGPID(AANAJHMODAE ADGMECOLKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	internal abstract IPHEKDLBFAA GOOJKEOONAD(IEnumerator<PHFDFIIIMCE> KAKFDALDNFE, Behaviour AAJIFFABDID, PGLHDADPCBH NJHCLGBNDNB);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	internal abstract IIOPKOCAOHO AEHPMFIKNNC(AANAJHMODAE PAKKOLECNNK);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA4A0", Offset = "0x8EC92A0", VA = "0x188ECA4A0", Slot = "25")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA440", Offset = "0x8EC9240", VA = "0x188ECA440", Slot = "15")]
	public PHFDFIIIMCE DOCKPPIODBD(AANAJHMODAE CFBEEIBDCID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8ECA860", Offset = "0x8EC9660", VA = "0x188ECA860", Slot = "16")]
	public PHFDFIIIMCE EAACAOIAIEP(float KBODPDIPNAF, AANAJHMODAE CFBEEIBDCID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x8ECADE0", Offset = "0x8EC9BE0", VA = "0x188ECADE0", Slot = "17")]
	public PHFDFIIIMCE PCEGKLKKBCF(Func<bool> ECNHPJKBPID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class IPHEKDLBFAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly PGLHDADPCBH LDOEPLPMHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly GCJKNNBEHDC KKBNGKDBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly bool GNLEGNGHHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private string PFLDDMDPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private StackTrace LBCBKPKPFDC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IEnumerator<PHFDFIIIMCE> FFLAGNKANPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PHFDFIIIMCE ALGCABOEJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LIGLAMOIDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8ED03C0", Offset = "0x8ECF1C0", VA = "0x188ED03C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JHPJJLFPJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xD913B0", Offset = "0xD901B0", VA = "0x180D913B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xDACDA0", Offset = "0xDABBA0", VA = "0x180DACDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8ED0820", Offset = "0x8ECF620", VA = "0x188ED0820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float AGPGCCPAHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xF29370", Offset = "0xF28170", VA = "0x180F29370")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xF29380", Offset = "0xF28180", VA = "0x180F29380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8ED0AB0", Offset = "0x8ECF8B0", VA = "0x188ED0AB0")]
	public IPHEKDLBFAA(IEnumerator<PHFDFIIIMCE> AENONOIGDOI, GCJKNNBEHDC KKBNGKDBMPF, PGLHDADPCBH LDOEPLPMHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x8ED0440", Offset = "0x8ECF240", VA = "0x188ED0440")]
	public PHFDFIIIMCE CAFDDMOMBCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8ED0760", Offset = "0x8ECF560", VA = "0x188ED0760")]
	public bool GNNNDEAOMID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8ED07D0", Offset = "0x8ECF5D0", VA = "0x188ED07D0")]
	public void HHJCEDNCEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8ED09D0", Offset = "0x8ECF7D0", VA = "0x188ED09D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0xE05600", Offset = "0xE04400", VA = "0x180E05600")]
	[CompilerGenerated]
	private void AOEPLFFJCOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class PGLHDADPCBH : OBGJBBNBLIP, GMJHELKMAKL, MDIEIFNFGHA, BFMPGGMMDDD, IEnumerator, PHFDFIIIMCE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private AANAJHMODAE BMJOCPFJFAH;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private AANAJHMODAE LENLILCNKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB63410", Offset = "0xB62210", VA = "0x180B63410", Slot = "23")]
		get
		{
			return default(AANAJHMODAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public AANAJHMODAE ICKKOANNGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x10B0CF0", Offset = "0x10AFAF0", VA = "0x1810B0CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private float KMNCCJEIFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAE5B60", Offset = "0xAE4960", VA = "0x180AE5B60", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CJGJMGCPMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8ED8650", Offset = "0x8ED7450", VA = "0x188ED8650", Slot = "24")]
	private bool FIBNEGMKKAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8ED8640", Offset = "0x8ED7440", VA = "0x188ED8640", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8ED8670", Offset = "0x8ED7470", VA = "0x188ED8670")]
	public PGLHDADPCBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal enum NFONMELJMJI : byte
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
internal sealed class IIOPKOCAOHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum PGJJFGCCLDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct GEOGHLMGPGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public AANAJHMODAE BDGKJGDBOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public PGJJFGCCLDD CKMPGJEFMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public List<IPHEKDLBFAA> FPHDCMEPEIC;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly PGJJFGCCLDD[] BAHMONGKHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly AANAJHMODAE PAKKOLECNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool PFCNPBEDFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly IPHEKDLBFAA[] LGDBCAACGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly List<IPHEKDLBFAA> MCOEIJDHALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Stack<int> GICEFNHHFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly List<IPHEKDLBFAA> JENBADHPGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Stack<int> ANNOLPIIDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly EENFEGGFGDO FDHGGCDPFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool KMAEIODOBDK;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public GEOGHLMGPGN[,] JOJCLMOMEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8ECFB00", Offset = "0x8ECE900", VA = "0x188ECFB00")]
	public IIOPKOCAOHO(AANAJHMODAE CFBEEIBDCID, EENFEGGFGDO FDHGGCDPFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8ECF8D0", Offset = "0x8ECE6D0", VA = "0x188ECF8D0")]
	public void OHKOLKPDODM(IPHEKDLBFAA AENONOIGDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8ECE700", Offset = "0x8ECD500", VA = "0x188ECE700")]
	public void BNFGOMKOEGL(IList<IPHEKDLBFAA> IFLODIFMIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8ECF120", Offset = "0x8ECDF20", VA = "0x188ECF120")]
	public void KGANCBNGHFO(IList<IPHEKDLBFAA> IFLODIFMIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8ECEEA0", Offset = "0x8ECDCA0", VA = "0x188ECEEA0")]
	private void FIMLNMKJHPF(IPHEKDLBFAA AENONOIGDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8ECEF90", Offset = "0x8ECDD90", VA = "0x188ECEF90")]
	private void JDKGEEBNBPM(IList<IPHEKDLBFAA> IFLODIFMIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8ECEA10", Offset = "0x8ECD810", VA = "0x188ECEA10")]
	private NFONMELJMJI DFJPPMFKJJG(IPHEKDLBFAA AENONOIGDOI)
	{
		return default(NFONMELJMJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8ECE590", Offset = "0x8ECD390", VA = "0x188ECE590")]
	public void AFCEEABIEMI(float NDIHBLABBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x8ECECB0", Offset = "0x8ECDAB0", VA = "0x188ECECB0")]
	public void EGIAAGLNDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x8ECF430", Offset = "0x8ECE230", VA = "0x188ECF430")]
	private void MHBHEMELGJA(List<IPHEKDLBFAA> IFLODIFMIAL, Stack<int> BHLCMBECJDD, bool KMOBNHEIGGP, float EHFAIKHEELB = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8ECEB90", Offset = "0x8ECD990", VA = "0x188ECEB90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8ECF790", Offset = "0x8ECE590", VA = "0x188ECF790")]
	private void OGJJCGODGII(List<IPHEKDLBFAA> IFLODIFMIAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class HNFOFLLAHAL : EENFEGGFGDO
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
	public void GAALCDKKNNJ(string PFLDDMDPCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
	public void MNLBHMJNMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public HNFOFLLAHAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class FHPOICNLCAA : GCJKNNBEHDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Behaviour AAJIFFABDID;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB720", Offset = "0x8ECA520", VA = "0x188ECB720", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool IKLOPDIDEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB6B0", Offset = "0x8ECA4B0", VA = "0x188ECB6B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MIEEPFGDAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB700", Offset = "0x8ECA500", VA = "0x188ECB700", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	public FHPOICNLCAA(Behaviour AAJIFFABDID)
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
