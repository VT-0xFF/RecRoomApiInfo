using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Analytics;
using RecRoom.ApplicationLifecycle;
using RecRoom.Async;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.PlayerLoop;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using UJect;
using UJect.Injection;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.Scripting;

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
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9020430", Offset = "0x901F230", VA = "0x189020430", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9027180", Offset = "0x9025F80", VA = "0x189027180", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27B5590", Offset = "0x27B4390", VA = "0x1827B5590")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class CustomPlayerLoopInjector
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct WrapperPreSystem
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class NHMYBFFRWAV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public BXPWMUXSAWD.WrapperKey IBCPJYJQVFR;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
				public NHMYBFFRWAV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x9020F20", Offset = "0x901FD20", VA = "0x189020F20")]
				internal void TQJGESOUHRF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static IDisposable frameScope;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x90262B0", Offset = "0x90250B0", VA = "0x1890262B0")]
			public static PlayerLoopSystem RKVBDYBCJSD(BXPWMUXSAWD.WrapperKey a)
			{
				return default(PlayerLoopSystem);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private struct WrapperPostSystem
		{
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class ZIQJURSSQGO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public BXPWMUXSAWD.WrapperKey IBCPJYJQVFR;

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
				public ZIQJURSSQGO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x9026F10", Offset = "0x9025D10", VA = "0x189026F10")]
				internal void TQJGESOUHRF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9026190", Offset = "0x9024F90", VA = "0x189026190")]
			public static PlayerLoopSystem RKVBDYBCJSD(BXPWMUXSAWD.WrapperKey a)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9018A00", Offset = "0x9017800", VA = "0x189018A00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9018A80", Offset = "0x9017880", VA = "0x189018A80")]
		private static void HXSKIJHJGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9019B50", Offset = "0x9018950", VA = "0x189019B50")]
		private static void UHYOHCHOFUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x90196F0", Offset = "0x90184F0", VA = "0x1890196F0")]
		private static void OTMKNFAENZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9018B70", Offset = "0x9017970", VA = "0x189018B70")]
		private static void NPLMZDXPEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x35ECB00", Offset = "0x35EB900", VA = "0x1835ECB00")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9018AD0", Offset = "0x90178D0", VA = "0x189018AD0")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x35ECB00", Offset = "0x35EB900", VA = "0x1835ECB00")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x35ECC10", Offset = "0x35EBA10", VA = "0x1835ECC10")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) VVRLUZCZTUA<a, b>(BXPWMUXSAWD.WrapperKey a)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9019D20", Offset = "0x9018B20", VA = "0x189019D20")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) VVRLUZCZTUA(BXPWMUXSAWD.WrapperKey a, Type b, Type c)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class BXPWMUXSAWD
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public enum WrapperKey
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			SchedulerUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			NetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			NetworkSend,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			PreRenderUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			LatePreRenderUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			PhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			PhysicsUpdate,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			SendFrameStarted,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			FinishFrameRendering,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			PhysicsResetInterpolatedPosition,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			FullPlayerLoop,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			OMPreGameplayUpdate,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			OMPrePhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			OMPostPhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			OMPostGameplayUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			OMPreNetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			OMNetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			OMPostNetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			OMNetworkSend,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			OMPreRenderSystem,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			OMPostLateUpdate
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class YEZPAGOMYAT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly WrapperKey XSYLVXXJCAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public readonly OIRXHHSHJMJ TNXNMEYKJOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private long EGQZCFSDRDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private long RGZMCVPVUHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public long SGRPFYTWUQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int SZCEGDANAPF;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9026E90", Offset = "0x9025C90", VA = "0x189026E90")]
			public YEZPAGOMYAT(WrapperKey a, int b = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9026D40", Offset = "0x9025B40", VA = "0x189026D40")]
			public void DNIGIHELABK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9026E40", Offset = "0x9025C40", VA = "0x189026E40")]
			public void OMGLJSVXKNR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9026D60", Offset = "0x9025B60", VA = "0x189026D60")]
			public void FTMITCRYDRQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static WrapperKey[] NZBCYOZVHRN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static YEZPAGOMYAT[] SZNNCVFGCJX;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9018610", Offset = "0x9017410", VA = "0x189018610")]
		public static YEZPAGOMYAT RDXXLHWDYSD(WrapperKey a, int b = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9018750", Offset = "0x9017550", VA = "0x189018750")]
		public static YEZPAGOMYAT USNEBSHSHRR(WrapperKey a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x90187C0", Offset = "0x90175C0", VA = "0x1890187C0")]
		public static void WMSFAZGLFFU()
		{
		}
	}
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class JCLSTYLSGTW
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private interface WJURSFJGAOA
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			bool NUJJSYEXPTV
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void Complete();
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private class ZXVHMIFXKXW : WJURSFJGAOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private readonly Action EADFRJBYSJQ;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool NUJJSYEXPTV
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
			public ZXVHMIFXKXW(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1144E90", Offset = "0x1143C90", VA = "0x181144E90", Slot = "5")]
			public void Complete()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly List<WJURSFJGAOA> TYJYSURRKLZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool HNRENYVSDOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x901DAA0", Offset = "0x901C8A0", VA = "0x18901DAA0")]
		public static void RPQCRZFOZNR(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x901D3D0", Offset = "0x901C1D0", VA = "0x18901D3D0")]
		private static void DQWCVOJUKTL(WJURSFJGAOA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x901D7A0", Offset = "0x901C5A0", VA = "0x18901D7A0")]
		private static void PAINJUHYNDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x901DB30", Offset = "0x901C930", VA = "0x18901DB30")]
		private static void SXCDHQOPYTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x901D690", Offset = "0x901C490", VA = "0x18901D690")]
		private static void OVMGKUIOMFO()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ESXBOUAWKUN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x901B180", Offset = "0x9019F80", VA = "0x18901B180")]
		public static IDisposable IPLTBEBSJFS(this QXWEXSDXBNL a, float b, Action<float> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x901B200", Offset = "0x901A000", VA = "0x18901B200")]
		public static IDisposable JAIPDXVZCGU(this QXWEXSDXBNL a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x901B100", Offset = "0x9019F00", VA = "0x18901B100")]
		public static IDisposable CQFSZFZNMWM(this QXWEXSDXBNL a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class NUKCMPBMMHU
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x39384B0", Offset = "0x39372B0", VA = "0x1839384B0")]
		[MustUseReturnValue]
		public static IDisposable NSLYEFKDRMC<a>(this a a, Action b, ScheduleQueueType c, bool d = true) where a : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3938650", Offset = "0x3937450", VA = "0x183938650")]
		[MustUseReturnValue]
		public static IDisposable NSLYEFKDRMC<b>(this b a, Action<float> b, ScheduleQueueType c, bool d = true) where b : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3938960", Offset = "0x3937760", VA = "0x183938960")]
		[MustUseReturnValue]
		public static IDisposable Update<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x39380E0", Offset = "0x3936EE0", VA = "0x1839380E0")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3938150", Offset = "0x3936F50", VA = "0x183938150")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action<float> update, bool validateContext = true) where T : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3938440", Offset = "0x3937240", VA = "0x183938440")]
		[MustUseReturnValue]
		public static IDisposable LateUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x39388F0", Offset = "0x39376F0", VA = "0x1839388F0")]
		[MustUseReturnValue]
		public static IDisposable SZAEYBSLXBN<c>(this c a, Action b, bool c = true) where c : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x39389D0", Offset = "0x39377D0", VA = "0x1839389D0")]
		[MustUseReturnValue]
		public static IDisposable ZGPUPVSKKWU<d>(this d a, Action b, bool c = true) where d : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3938380", Offset = "0x3937180", VA = "0x183938380")]
		[MustUseReturnValue]
		public static IDisposable KEAUGGGEWLD<f>(this f a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where f : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9021150", Offset = "0x901FF50", VA = "0x189021150")]
		[MustUseReturnValue]
		public static IDisposable KEAUGGGEWLD(this MonoBehaviour a, ZICDSLSKRWK b, float c, Action<float> d, ScheduleQueueType e, bool f = true, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3937DB0", Offset = "0x3936BB0", VA = "0x183937DB0")]
		[MustUseReturnValue]
		public static IDisposable CAAFPLJEXRD<g>(this g a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where g : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3938060", Offset = "0x3936E60", VA = "0x183938060")]
		[MustUseReturnValue]
		public static IDisposable ERHQMBQLVMS<h>(this h a, float b, Action<float> c, bool d = true, bool e = true) where h : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3938A40", Offset = "0x3937840", VA = "0x183938A40")]
		[MustUseReturnValue]
		public static IDisposable ZYMCCMJBKWJ<i>(this i a, Action<float> b, bool c = true, bool d = true) where i : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3938870", Offset = "0x3937670", VA = "0x183938870")]
		[MustUseReturnValue]
		public static IDisposable SQCSFZAEPAI<j>(this j a, Action<float> b, bool c = true, bool d = true) where j : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x39387F0", Offset = "0x39375F0", VA = "0x1839387F0")]
		[MustUseReturnValue]
		public static IDisposable SGOGGGVNKTX<k>(this k a, Action<float> b, bool c = true, bool d = true) where k : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3937F60", Offset = "0x3936D60", VA = "0x183937F60")]
		[MustUseReturnValue]
		public static IDisposable DNBDMCTDJRI<l>(this l a, Action<float> b, bool c = true, bool d = true) where l : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3937FE0", Offset = "0x3936DE0", VA = "0x183937FE0")]
		[MustUseReturnValue]
		public static IDisposable DSOLUCIEEHE<m>(this m a, Action<float> b, bool c = true, bool d = true) where m : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x39383C0", Offset = "0x39371C0", VA = "0x1839383C0")]
		[MustUseReturnValue]
		public static IDisposable LIQDNZPYEGS<n>(this n a, Action<float> b, bool c = true, bool d = true) where n : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3937CB0", Offset = "0x3936AB0", VA = "0x183937CB0")]
		[MustUseReturnValue]
		public static IDisposable BCVWQLULPRW<q>(this q a, Action<float> b, bool c = true, bool d = true) where q : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3937D30", Offset = "0x3936B30", VA = "0x183937D30")]
		[MustUseReturnValue]
		public static IDisposable BPHHIDGJAZI<s>(this s a, float b, Action<float> c, bool d = true, bool e = true) where s : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3938300", Offset = "0x3937100", VA = "0x183938300")]
		[MustUseReturnValue]
		public static IDisposable JMFGVXOUUKW<u>(this u a, Action<float> b, bool c = true, bool d = true) where u : MonoBehaviour, ZICDSLSKRWK
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class XEQBULEFGAU
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class XWCPHLZNPSB : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ScheduleQueueType WOJIXGXKJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Action JBJMLZHMKRX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private UPBAQOQITIJ DDOPFAPOUSA;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public XWCPHLZNPSB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9026910", Offset = "0x9025710", VA = "0x189026910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x90269E0", Offset = "0x90257E0", VA = "0x1890269E0", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class XVXIKFFQGGS : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public ScheduleQueueType WOJIXGXKJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Action<float> JBJMLZHMKRX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private UPBAQOQITIJ DDOPFAPOUSA;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public XVXIKFFQGGS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x90267F0", Offset = "0x90255F0", VA = "0x1890267F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x90268D0", Offset = "0x90256D0", VA = "0x1890268D0", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9026680", Offset = "0x9025480", VA = "0x189026680")]
		public static JHHJDZQKJVL NSLYEFKDRMC(Action a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x90265F0", Offset = "0x90253F0", VA = "0x1890265F0")]
		public static JHHJDZQKJVL NSLYEFKDRMC(Behaviour a, Action b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9026510", Offset = "0x9025310", VA = "0x189026510")]
		public static JHHJDZQKJVL NSLYEFKDRMC(Behaviour a, Action<float> b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9026410", Offset = "0x9025210", VA = "0x189026410")]
		[IteratorStateMachine(typeof(XWCPHLZNPSB))]
		private static IEnumerator<NCPAWUBDFGC> MJAMJBYVNGZ(ScheduleQueueType a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9026490", Offset = "0x9025290", VA = "0x189026490")]
		[IteratorStateMachine(typeof(XVXIKFFQGGS))]
		private static IEnumerator<NCPAWUBDFGC> MJAMJBYVNGZ(ScheduleQueueType a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class LMRSHKYZSOB : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OUKQPKXPDHO : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public LMRSHKYZSOB FNBWZDPUGEI;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public OUKQPKXPDHO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9021470", Offset = "0x9020270", VA = "0x189021470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9021500", Offset = "0x9020300", VA = "0x189021500", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ScheduleQueueType ODWHGXRVINV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Action LYJWVMGIDWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool AKXGVLZDFPH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool UWJBLFXKALL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xACC870", Offset = "0xACB670", VA = "0x180ACC870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x901EA80", Offset = "0x901D880", VA = "0x18901EA80")]
		public LMRSHKYZSOB(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x901E970", Offset = "0x901D770", VA = "0x18901E970")]
		[IteratorStateMachine(typeof(OUKQPKXPDHO))]
		private IEnumerator<NCPAWUBDFGC> IIXYUFKHBAU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x901E9E0", Offset = "0x901D7E0", VA = "0x18901E9E0", Slot = "4")]
		public void OnCompleted(Action continuation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		public void FMJIDINXVPL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class JDHTIVWPJOS
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x901DD00", Offset = "0x901CB00", VA = "0x18901DD00")]
		public static LMRSHKYZSOB WYHHBUUWOYJ(this ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class LCDKTULEOZI
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MLOOWYAYDAF : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public SZCAQDLFZDN LHMHFGEZRUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Action<float> JBJMLZHMKRX;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public MLOOWYAYDAF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9020E30", Offset = "0x901FC30", VA = "0x189020E30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9020EB0", Offset = "0x901FCB0", VA = "0x189020EB0", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x901E7B0", Offset = "0x901D5B0", VA = "0x18901E7B0")]
		public static JHHJDZQKJVL NSLYEFKDRMC(float a, Action<float> b, ScheduleQueueType c, bool d = true, [Optional] SPRKFJGZVXG e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x901E6E0", Offset = "0x901D4E0", VA = "0x18901E6E0")]
		public static JHHJDZQKJVL NSLYEFKDRMC(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SPRKFJGZVXG f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x901E880", Offset = "0x901D680", VA = "0x18901E880")]
		public static JHHJDZQKJVL WFOJRNTDLTW(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SPRKFJGZVXG f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x901E470", Offset = "0x901D270", VA = "0x18901E470")]
		public static JHHJDZQKJVL CCWBFAEXJSE(QXWEXSDXBNL a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SPRKFJGZVXG f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x901E630", Offset = "0x901D430", VA = "0x18901E630")]
		private static IEnumerator<NCPAWUBDFGC> MJAMJBYVNGZ(YGPMNQYCYVH a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x901E5D0", Offset = "0x901D3D0", VA = "0x18901E5D0")]
		private static IEnumerator<NCPAWUBDFGC> KXSRGIAPOYH(YGPMNQYCYVH a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x901E540", Offset = "0x901D340", VA = "0x18901E540")]
		[IteratorStateMachine(typeof(MLOOWYAYDAF))]
		private static IEnumerator<NCPAWUBDFGC> CIWHSQPFGYB(SZCAQDLFZDN a, float b, ScheduleQueueType c, Action<float> d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class HYBXLJOKOES
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class VGBTQBHFLDE : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public ScheduleQueueType ODWHGXRVINV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public Func<bool> GULMIANLAMN;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public VGBTQBHFLDE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9023FC0", Offset = "0x9022DC0", VA = "0x189023FC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9024070", Offset = "0x9022E70", VA = "0x189024070", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x901CBC0", Offset = "0x901B9C0", VA = "0x18901CBC0")]
		[IteratorStateMachine(typeof(VGBTQBHFLDE))]
		private static IEnumerator<NCPAWUBDFGC> RICLNMHLSVY(ScheduleQueueType a, Func<bool> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x901CAE0", Offset = "0x901B8E0", VA = "0x18901CAE0")]
		public static JHHJDZQKJVL ONOQQTYTYYX(this MonoBehaviour a, Func<bool> b, ScheduleQueueType c = ScheduleQueueType.Update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class DRIMBTKBDEX
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class OVFSELZEPAY : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float KXNTNVINGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public ScheduleQueueType WOJIXGXKJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action HIDJGOBXOFO;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public OVFSELZEPAY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9021540", Offset = "0x9020340", VA = "0x189021540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x90215B0", Offset = "0x90203B0", VA = "0x1890215B0", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class TTBAYJJNUGI<a> : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float KXNTNVINGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public ScheduleQueueType WOJIXGXKJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Action<a> HIDJGOBXOFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public a DPAFBEWEXTK;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public TTBAYJJNUGI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x616A0E0", Offset = "0x6168EE0", VA = "0x18616A0E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x3DD1D80", Offset = "0x3DD0B80", VA = "0x183DD1D80", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class OUHLRBARXTQ : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float KXNTNVINGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ScheduleQueueType WOJIXGXKJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Action HIDJGOBXOFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private NCPAWUBDFGC BQLVFLEJOJO;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public OUHLRBARXTQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x90213A0", Offset = "0x90201A0", VA = "0x1890213A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9021430", Offset = "0x9020230", VA = "0x189021430", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x901A190", Offset = "0x9018F90", VA = "0x18901A190")]
		[IteratorStateMachine(typeof(OVFSELZEPAY))]
		private static IEnumerator<NCPAWUBDFGC> IIXYUFKHBAU(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3620990", Offset = "0x361F790", VA = "0x183620990")]
		[IteratorStateMachine(typeof(TTBAYJJNUGI<>))]
		private static IEnumerator<NCPAWUBDFGC> IIXYUFKHBAU<a>(float a, ScheduleQueueType b, Action<a> c, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x901A7A0", Offset = "0x90195A0", VA = "0x18901A7A0")]
		[IteratorStateMachine(typeof(OUHLRBARXTQ))]
		private static IEnumerator<NCPAWUBDFGC> XWNZENBVXBS(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x901A220", Offset = "0x9019020", VA = "0x18901A220")]
		public static IDisposable OGWEEMQWXAK(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x901A830", Offset = "0x9019630", VA = "0x18901A830")]
		public static JHHJDZQKJVL YFZFJEHRTIU(this MonoBehaviour a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x901A300", Offset = "0x9019100", VA = "0x18901A300")]
		public static JHHJDZQKJVL OGWEEMQWXAK(this MonoBehaviour a, float b, ScheduleQueueType c, Action d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x901A520", Offset = "0x9019320", VA = "0x18901A520")]
		public static JHHJDZQKJVL ROAGJCEZDHO(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3620B60", Offset = "0x361F960", VA = "0x183620B60")]
		public static JHHJDZQKJVL ROAGJCEZDHO<b>(this MonoBehaviour a, Action<b> b, b c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x901A0F0", Offset = "0x9018EF0", VA = "0x18901A0F0")]
		public static JHHJDZQKJVL GJXXRSDOPMI(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x901A480", Offset = "0x9019280", VA = "0x18901A480")]
		public static JHHJDZQKJVL REYGWMSHPEA(this MonoBehaviour a, Action b, [Optional] SPRKFJGZVXG c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9019F10", Offset = "0x9018D10", VA = "0x189019F10")]
		public static JHHJDZQKJVL AAOMBXWCDJI(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9019FB0", Offset = "0x9018DB0", VA = "0x189019FB0")]
		public static JHHJDZQKJVL AUMTYWRVBUA(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x901A050", Offset = "0x9018E50", VA = "0x18901A050")]
		public static JHHJDZQKJVL FZKTLSFZYJO(MonoBehaviour a, ScheduleQueueType b, Action c, [Optional] SPRKFJGZVXG d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3620680", Offset = "0x361F480", VA = "0x183620680")]
		public static JHHJDZQKJVL FZKTLSFZYJO<h>(MonoBehaviour a, ScheduleQueueType b, Action<h> c, h d, [Optional] SPRKFJGZVXG e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x901A3F0", Offset = "0x90191F0", VA = "0x18901A3F0")]
		public static JHHJDZQKJVL OXFTIOQHWFE(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x901A5C0", Offset = "0x90193C0", VA = "0x18901A5C0")]
		public static JHHJDZQKJVL SFCTZBRBWBA(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x901A700", Offset = "0x9019500", VA = "0x18901A700")]
		public static JHHJDZQKJVL UQFLGPZQIDI(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x901A660", Offset = "0x9019460", VA = "0x18901A660")]
		public static JHHJDZQKJVL TVEBLJVSLRK(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class MECSYOHOZJZ : OAYYVKROOKD, IEnumerable<OAYYVKROOKD>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly List<OAYYVKROOKD> ITKQNGQPSAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool HMCMLITWVMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Action XTDCYDNYGSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool PWSVDSPYBGT;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool HSWHBUBKUGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9020BC0", Offset = "0x901F9C0", VA = "0x189020BC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action RBYWTAIMLYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9020810", Offset = "0x901F610", VA = "0x189020810", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9020CF0", Offset = "0x901FAF0", VA = "0x189020CF0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9020D90", Offset = "0x901FB90", VA = "0x189020D90")]
		public MECSYOHOZJZ([Optional] Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x90204B0", Offset = "0x901F2B0", VA = "0x1890204B0")]
		public void Add(OAYYVKROOKD limiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9020630", Offset = "0x901F430", VA = "0x189020630")]
		private void CJIEPXPBDNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x90208B0", Offset = "0x901F6B0", VA = "0x1890208B0", Slot = "7")]
		public bool IHOCANSKLUF(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x90208C0", Offset = "0x901F6C0", VA = "0x1890208C0", Slot = "8")]
		public bool IHOCANSKLUF(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9020790", Offset = "0x901F590", VA = "0x189020790", Slot = "9")]
		public IEnumerator<OAYYVKROOKD> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9020790", Offset = "0x901F590", VA = "0x189020790", Slot = "10")]
		private IEnumerator HTHYFOXNRHD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class KWGQRXKSLIL : ERSHXMARKIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class IOBBVAODQCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public KWGQRXKSLIL FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Action EADFRJBYSJQ;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IOBBVAODQCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x901CC40", Offset = "0x901BA40", VA = "0x18901CC40")]
			internal void HJEQWKNCXPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class NLBGUTCZJKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public KWGQRXKSLIL FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action EADFRJBYSJQ;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public NLBGUTCZJKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x901CC40", Offset = "0x901BA40", VA = "0x18901CC40")]
			internal void AOZNKBKPCOK()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly float TVKFUFSGWBE;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x901A900", Offset = "0x9019700", VA = "0x18901A900")]
		public KWGQRXKSLIL(Behaviour a, float b, [Optional] Action c, [Optional] SPRKFJGZVXG d, [Optional] YGPMNQYCYVH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x901DE00", Offset = "0x901CC00", VA = "0x18901DE00", Slot = "9")]
		protected override bool INCTFDCIEXB(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x901DF10", Offset = "0x901CD10", VA = "0x18901DF10", Slot = "10")]
		protected override bool JSBFEWPRENW(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface OAYYVKROOKD
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool HSWHBUBKUGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action RBYWTAIMLYV;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool IHOCANSKLUF(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool IHOCANSKLUF(Action a, bool b = false);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class ERSHXMARKIP : OAYYVKROOKD
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class WBDMUGFDMUO : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public ERSHXMARKIP FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float JXRPSQWRUZW;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public WBDMUGFDMUO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9026080", Offset = "0x9024E80", VA = "0x189026080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9026150", Offset = "0x9024F50", VA = "0x189026150", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly Behaviour XXDCRZIVRTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action XTDCYDNYGSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private JWWHWLOHQXU PHVLVUKUOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly SPRKFJGZVXG YYJGUBRGQVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected readonly YGPMNQYCYVH NMSSYCJEURI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HSWHBUBKUGX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xBD8F50", Offset = "0xBD7D50", VA = "0x180BD8F50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action RBYWTAIMLYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x901AA40", Offset = "0x9019840", VA = "0x18901AA40", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x901AEB0", Offset = "0x9019CB0", VA = "0x18901AEB0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x901AFD0", Offset = "0x9019DD0", VA = "0x18901AFD0")]
		protected ERSHXMARKIP(Behaviour a, [Optional] Action b, [Optional] SPRKFJGZVXG c, [Optional] YGPMNQYCYVH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x901AAE0", Offset = "0x90198E0", VA = "0x18901AAE0", Slot = "7")]
		public bool IHOCANSKLUF(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x901AB40", Offset = "0x9019940", VA = "0x18901AB40", Slot = "8")]
		public bool IHOCANSKLUF(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool INCTFDCIEXB(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool JSBFEWPRENW(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x901AC60", Offset = "0x9019A60", VA = "0x18901AC60")]
		protected void ROJWDBDQGHU(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x901AC80", Offset = "0x9019A80", VA = "0x18901AC80")]
		protected ILWLFVTHXJS SWJARYJENNC(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x901ABE0", Offset = "0x90199E0", VA = "0x18901ABE0")]
		private void KQECCKZZCJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x901AF50", Offset = "0x9019D50", VA = "0x18901AF50")]
		[IteratorStateMachine(typeof(WBDMUGFDMUO))]
		private IEnumerator<NCPAWUBDFGC> YGEKXGGOOBV(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x901ABA0", Offset = "0x90199A0", VA = "0x18901ABA0")]
		[CompilerGenerated]
		private void IOJARYYVLUG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class KWQLXBPXKVG : ERSHXMARKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly float CYZVZKTMVJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int AUTRTAGAXQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly float JODJVERLIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly float[] EYMWHXTEIFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int MIGFIFDVWBJ;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x901E2A0", Offset = "0x901D0A0", VA = "0x18901E2A0")]
		public KWQLXBPXKVG(Behaviour a, float b, int c, [Optional] Action d, float e = 0f, [Optional] SPRKFJGZVXG f, [Optional] YGPMNQYCYVH g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "9")]
		protected override bool INCTFDCIEXB(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x901E0A0", Offset = "0x901CEA0", VA = "0x18901E0A0", Slot = "10")]
		protected override bool JSBFEWPRENW(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x901E020", Offset = "0x901CE20", VA = "0x18901E020")]
		private void HJNNKOKNKFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class EFDFVVMOEDA : ERSHXMARKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly float TVKFUFSGWBE;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x901A900", Offset = "0x9019700", VA = "0x18901A900")]
		public EFDFVVMOEDA(Behaviour a, float b, [Optional] Action c, [Optional] SPRKFJGZVXG d, [Optional] YGPMNQYCYVH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "9")]
		protected override bool INCTFDCIEXB(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x901A8C0", Offset = "0x90196C0", VA = "0x18901A8C0", Slot = "10")]
		protected override bool JSBFEWPRENW(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class VRFQUUKVHOI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class UHTJPUSGWDK : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public Action PJDBIQUJVDE;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public UHTJPUSGWDK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x90237A0", Offset = "0x90225A0", VA = "0x1890237A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9023810", Offset = "0x9022610", VA = "0x189023810", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private JHHJDZQKJVL YJGERRBQNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private QXWEXSDXBNL XXDCRZIVRTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private Action<float> PAXPKRDSUKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private ScheduleQueueType ODWHGXRVINV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private float NATVAFMQDLB;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9025EE0", Offset = "0x9024CE0", VA = "0x189025EE0")]
		public VRFQUUKVHOI(QXWEXSDXBNL a, float b, Action<float> c, ScheduleQueueType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9025D80", Offset = "0x9024B80", VA = "0x189025D80")]
		private void ZKIRPWFEOHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9025C60", Offset = "0x9024A60", VA = "0x189025C60")]
		private void SHBKSKUSWWO(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9025BF0", Offset = "0x90249F0", VA = "0x189025BF0")]
		[IteratorStateMachine(typeof(UHTJPUSGWDK))]
		private IEnumerator<NCPAWUBDFGC> OMBNBDABYPG(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9025A20", Offset = "0x9024820", VA = "0x189025A20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9025A80", Offset = "0x9024880", VA = "0x189025A80")]
		[CompilerGenerated]
		private void GPXBPQKECZR(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class FANIUBQUWKG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class UJZHLRDDVYF : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Action PJDBIQUJVDE;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public UJZHLRDDVYF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x90237A0", Offset = "0x90225A0", VA = "0x1890237A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9023850", Offset = "0x9022650", VA = "0x189023850", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private JHHJDZQKJVL YJGERRBQNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private MonoBehaviour VIIYKXWAKVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Action JBJMLZHMKRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Action<float> PAXPKRDSUKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private ScheduleQueueType ODWHGXRVINV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private float NATVAFMQDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool WKFNPKXVUYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly SPRKFJGZVXG YYJGUBRGQVD;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x901C200", Offset = "0x901B000", VA = "0x18901C200")]
		public FANIUBQUWKG(MonoBehaviour a, Action b, ScheduleQueueType c, [Optional] SPRKFJGZVXG d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x901BE60", Offset = "0x901AC60", VA = "0x18901BE60")]
		public FANIUBQUWKG(MonoBehaviour a, Action<float> b, ScheduleQueueType c, [Optional] SPRKFJGZVXG d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x901C020", Offset = "0x901AE20", VA = "0x18901C020")]
		public FANIUBQUWKG(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SPRKFJGZVXG f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xCFD120", Offset = "0xCFBF20", VA = "0x180CFD120")]
		private FANIUBQUWKG(SPRKFJGZVXG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x901B2E0", Offset = "0x901A0E0", VA = "0x18901B2E0")]
		internal static FANIUBQUWKG GFJAWPMHUNU(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SPRKFJGZVXG f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x901B620", Offset = "0x901A420", VA = "0x18901B620")]
		private void NSLYEFKDRMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x901BB80", Offset = "0x901A980", VA = "0x18901BB80")]
		private void YGPGLUVHUBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x901BCF0", Offset = "0x901AAF0", VA = "0x18901BCF0")]
		private void ZKIRPWFEOHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x901B750", Offset = "0x901A550", VA = "0x18901B750")]
		private void NWFRKSMIGZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x901B9D0", Offset = "0x901A7D0", VA = "0x18901B9D0")]
		private void SHBKSKUSWWO(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x901B8D0", Offset = "0x901A6D0", VA = "0x18901B8D0")]
		[IteratorStateMachine(typeof(UJZHLRDDVYF))]
		private IEnumerator<NCPAWUBDFGC> OMBNBDABYPG(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x901B280", Offset = "0x901A080", VA = "0x18901B280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x901BAF0", Offset = "0x901A8F0", VA = "0x18901BAF0")]
		[CompilerGenerated]
		private void UFFPMLERHOP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x901B500", Offset = "0x901A300", VA = "0x18901B500")]
		[CompilerGenerated]
		private void KXDVHSQZGFM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x901B940", Offset = "0x901A740", VA = "0x18901B940")]
		[CompilerGenerated]
		private void QFIOZVPQGDZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x901B590", Offset = "0x901A390", VA = "0x18901B590")]
		[CompilerGenerated]
		private void NMXNKLRAXLG(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Flags]
	internal enum CoroutineState : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Inactive = 0,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Running = 1,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Cancelled = 2,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Paused = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class FNPUCGDOCSP : YGPMNQYCYVH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float GHQGUQBAJXX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x901C3F0", Offset = "0x901B1F0", VA = "0x18901C3F0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float TDXCKSGQUTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x901C3C0", Offset = "0x901B1C0", VA = "0x18901C3C0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public double WMBEAAUAKVY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x901C3D0", Offset = "0x901B1D0", VA = "0x18901C3D0", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x901C400", Offset = "0x901B200", VA = "0x18901C400")]
		[AUEAKLYJEMA.Root]
		internal static void UUQSMFQOYUN(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		[UnityEngine.Scripting.Preserve]
		internal FNPUCGDOCSP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal interface MVGHAAVSFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZXFAGCJEDLF(string a);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ACAWYMNPGZF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal interface RELLEZGJQML
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		string CANLOGIQDOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool NDANQTLGWKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool ELZDVARIWWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal class FYTNOMEDZGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AGPSBGPNVTU JPGGZSSUQGL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int BFTLLAUIUZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D80", Offset = "0xAD2B80", VA = "0x180AD3D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x901C510", Offset = "0x901B310", VA = "0x18901C510")]
		public static NCPAWUBDFGC FWAFHHGRCJQ(IEnumerator<NCPAWUBDFGC> a, OBIVKHVOQZY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x901C670", Offset = "0x901B470", VA = "0x18901C670")]
		public NCPAWUBDFGC FWAFHHGRCJQ(OBIVKHVOQZY[] a, IEnumerator<NCPAWUBDFGC>[] b, NCPAWUBDFGC[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x901C4E0", Offset = "0x901B2E0", VA = "0x18901C4E0")]
		public void KKJPSDYEOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x901C730", Offset = "0x901B530", VA = "0x18901C730")]
		public void FZZGAIRUNSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x901C870", Offset = "0x901B670", VA = "0x18901C870")]
		public void TXFRGPUODWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x901C4E0", Offset = "0x901B2E0", VA = "0x18901C4E0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public FYTNOMEDZGP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class AGPSBGPNVTU
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct JobbedInsertionData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public FYTNOMEDZGP Routine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public QXWEXSDXBNL Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public OBIVKHVOQZY Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public IEnumerator<NCPAWUBDFGC> Coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public NCPAWUBDFGC CurrentSchedule;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CoroutineState CoroutineState;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct JobbedReinsertBuffer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ScheduleQueueType QueueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public List<JobbedInsertionData> Insertions;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class JBJUYEWRLZL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public OBIVKHVOQZY KZYXZROMHKR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public AGPSBGPNVTU FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public QXWEXSDXBNL XXDCRZIVRTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public FYTNOMEDZGP PYUVWOLCWYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public CoroutineState MCMSLQJYTKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public NCPAWUBDFGC IRVESPFSXDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public IEnumerator<NCPAWUBDFGC> HBVFKFZJUBA;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public JBJUYEWRLZL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x901CC70", Offset = "0x901BA70", VA = "0x18901CC70")]
			internal void XCCEJLIQQVS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class XBOIVBGNKWJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public FYTNOMEDZGP LHMHFGEZRUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AGPSBGPNVTU FNBWZDPUGEI;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public XBOIVBGNKWJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x90263D0", Offset = "0x90251D0", VA = "0x1890263D0")]
			internal void WLRGTSQAXFW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class AUGXESHRONI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public FYTNOMEDZGP LHMHFGEZRUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AGPSBGPNVTU FNBWZDPUGEI;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public AUGXESHRONI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9017D30", Offset = "0x9016B30", VA = "0x189017D30")]
			internal void CGQEEQGQKDW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class FNNOYKPROUT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public FYTNOMEDZGP LHMHFGEZRUB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AGPSBGPNVTU FNBWZDPUGEI;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public FNNOYKPROUT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x901C380", Offset = "0x901B180", VA = "0x18901C380")]
			internal void XAATPCOZMFZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const CoroutineState LDREBIUHOZU = CoroutineState.Cancelled | CoroutineState.Paused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ScheduleQueueType ODWHGXRVINV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool[] WILNCFKYWEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private NativeArray<CoroutineState> SMSSCJYOVFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NativeArray<float> QLTJXEOUDWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private NativeArray<int> RWMEDHWIBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private NativeArray<int> MVHTVKEKGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private NativeArray<int> OZSEWXCKDTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private NativeArray<int> YXLHAJVWZTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<int> IHQQGFGKPKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private FYTNOMEDZGP[] CWLKVIRAUXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private OBIVKHVOQZY[] JCXBOVOJAQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private QXWEXSDXBNL[] ZBTDWERBHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<NCPAWUBDFGC>[] TCQGAMGIIUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NCPAWUBDFGC[] HIRDTREWXIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int WTZNPPKMTHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int YABWGXUYVAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly int FIIOFXIYAXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private float OAXFNVKJOWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ScheduleSortJob AMYAZBEDOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private JobHandle TVRHLDKZGZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<FYTNOMEDZGP> CFGMVVJHXAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private bool FCMZOLWGRUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private List<Action> RYIODAIDFRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private List<Action> CAHKAGPROGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool LTNTISIDYIO;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JobbedReinsertBuffer[] QVVZHJPDEXW
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xB8B9A0", Offset = "0xB8A7A0", VA = "0x180B8B9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9017110", Offset = "0x9015F10", VA = "0x189017110")]
		private static int RRHCPHMCAZC(ScheduleQueueType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x90176F0", Offset = "0x90164F0", VA = "0x1890176F0")]
		public AGPSBGPNVTU(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9017140", Offset = "0x9015F40", VA = "0x189017140")]
		private void SVKAHGPCLWC(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9015700", Offset = "0x9014500", VA = "0x189015700")]
		public void DFTWMENVIRA(QXWEXSDXBNL a, NCPAWUBDFGC b, IEnumerator<NCPAWUBDFGC> c, OBIVKHVOQZY d, [Optional] FYTNOMEDZGP e, CoroutineState f = CoroutineState.Running)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9016B20", Offset = "0x9015920", VA = "0x189016B20")]
		public void Insert(IEnumerable<JobbedInsertionData> insertionDatas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9015BE0", Offset = "0x90149E0", VA = "0x189015BE0")]
		private JobbedInsertionData FXLMPVNOUTP(int a)
		{
			return default(JobbedInsertionData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9017320", Offset = "0x9016120", VA = "0x189017320")]
		private void VCLZKGPOQLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x30E82A0", Offset = "0x30E70A0", VA = "0x1830E82A0")]
		private static void DJYLJECZLCV<a>(int a, a[] b, int c, [Optional] a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x30E82F0", Offset = "0x30E70F0", VA = "0x1830E82F0")]
		private static void DJYLJECZLCV<b>(int a, NativeArray<b> b, int c, [Optional] b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9016090", Offset = "0x9014E90", VA = "0x189016090")]
		private void GGNZXNMBXXZ(IEnumerable<JobbedInsertionData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x90153D0", Offset = "0x90141D0", VA = "0x1890153D0")]
		private void BFMCWUZSJCA(JobbedInsertionData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9015980", Offset = "0x9014780", VA = "0x189015980")]
		private TickResult FVTTDKMXKJJ(int a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9016DE0", Offset = "0x9015BE0", VA = "0x189016DE0")]
		public void PYTKSONUATA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9017670", Offset = "0x9016470", VA = "0x189017670")]
		private void YECAHYXDSMU(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9016D60", Offset = "0x9015B60", VA = "0x189016D60")]
		private void MXXGYGVVFTA(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9016410", Offset = "0x9015210", VA = "0x189016410")]
		public void HNGFHITKLGC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9015880", Offset = "0x9014680", VA = "0x189015880")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x90154A0", Offset = "0x90142A0", VA = "0x1890154A0")]
		public void Cancel(FYTNOMEDZGP schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9016FE0", Offset = "0x9015DE0", VA = "0x189016FE0")]
		public void Pause(FYTNOMEDZGP schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x90155D0", Offset = "0x90143D0", VA = "0x1890155D0")]
		public void DEERVPIOFYP(FYTNOMEDZGP a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class Receipt : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly Receipt ZMRLUQHZNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Action LSKYZILGSCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private bool ROXLLTQYQAX;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8676170", Offset = "0x8674F70", VA = "0x188676170", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface UYMUWXNEEQA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		a JMWYIQGMJFT
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable RNSOFIMCDEQ(UnityEngine.Object a, Action<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface VJCEPFRTPQW<a> : UYMUWXNEEQA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		new a JMWYIQGMJFT
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KURJTXBKDEJ<a> : VJCEPFRTPQW<a>, UYMUWXNEEQA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class LXUBUHTGLEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public KURJTXBKDEJ<a> FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public Tuple<UnityEngine.Object, Action<a>> BXCREHUZLXP;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public LXUBUHTGLEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x547E7E0", Offset = "0x547D5E0", VA = "0x18547E7E0")]
			internal void MTDQLTVPTXA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static GameObject COPANPYRFJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly List<Tuple<UnityEngine.Object, Action<a>>> SLDAKTRMXMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private a CFLKIBHXLLI;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a JMWYIQGMJFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xC70C00", Offset = "0xC6FA00", VA = "0x180C70C00", Slot = "5")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x5392D60", Offset = "0x5391B60", VA = "0x185392D60", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5392B20", Offset = "0x5391920", VA = "0x185392B20")]
		private static bool TQVVBPRHTFY(a a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5392FA0", Offset = "0x5391DA0", VA = "0x185392FA0")]
		public KURJTXBKDEJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x53925C0", Offset = "0x53913C0", VA = "0x1853925C0", Slot = "6")]
		public IDisposable RNSOFIMCDEQ(UnityEngine.Object a, Action<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5391CE0", Offset = "0x5390AE0", VA = "0x185391CE0")]
		private void MTOGUKNTYCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class QFQTZTWFVVL : CNHKWPYWVGW
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class LVZCJKMHNII : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private class MPVAEDHGKVX : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				private int QNDOOLLXLQB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private LVZCJKMHNII WOJIXGXKJAD;

				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0xE64E90", Offset = "0xE63C90", VA = "0x180E64E90")]
				public MPVAEDHGKVX(int a, LVZCJKMHNII b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0x9020EF0", Offset = "0x901FCF0", VA = "0x189020EF0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class FIXROTUIDDN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public int QNDOOLLXLQB;

				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
				public FIXROTUIDDN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xD25460", Offset = "0xD24260", VA = "0x180D25460")]
				internal bool GKURDGNIBVU(VCRWGUOPMDR a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class XYDGGBQNGBN : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int GTWEEXJFPKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private NCPAWUBDFGC LBVZGXVZPSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public LVZCJKMHNII FNBWZDPUGEI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public YGPMNQYCYVH XZFIJSWTJVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private UPBAQOQITIJ DDOPFAPOUSA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private List<VCRWGUOPMDR> WZROCCYBJVO;

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				private NCPAWUBDFGC HYUNTVFBJEN
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				private object UUTAULZFDNA
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
				[DebuggerHidden]
				public XYDGGBQNGBN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
				[DebuggerHidden]
				private void NFYYAPEFSFX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x9026A20", Offset = "0x9025820", VA = "0x189026A20", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x9026D00", Offset = "0x9025B00", VA = "0x189026D00", Slot = "8")]
				[DebuggerHidden]
				private void USEBYPNATQY()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private readonly ScheduleQueueType ODWHGXRVINV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private JHHJDZQKJVL KZYXZROMHKR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private readonly List<VCRWGUOPMDR> PKLNDBFCIZO;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x90203A0", Offset = "0x901F1A0", VA = "0x1890203A0")]
			public LVZCJKMHNII(ScheduleQueueType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x90201D0", Offset = "0x901EFD0", VA = "0x1890201D0")]
			public IDisposable QYGKIPJTVRP(VCRWGUOPMDR a, SPRKFJGZVXG b, YGPMNQYCYVH c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x901FFC0", Offset = "0x901EDC0", VA = "0x18901FFC0")]
			private void GAHWVRFGPMQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x9020140", Offset = "0x901EF40", VA = "0x189020140")]
			[IteratorStateMachine(typeof(XYDGGBQNGBN))]
			private IEnumerator<NCPAWUBDFGC> MJAMJBYVNGZ(YGPMNQYCYVH a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x901FF70", Offset = "0x901ED70", VA = "0x18901FF70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class VCRWGUOPMDR
		{
			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public enum UpdateTypes : byte
			{
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				EveryFrame,
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				Scheduled,
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				ScheduledNonFramerateLimited
			}

			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private static int ONQCLVWHMQL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public readonly int ZVXCDESMJGV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public readonly ZICDSLSKRWK NAJBYSCIJYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private readonly MonoBehaviour TMMHRACDFTJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public readonly Action DMCKQCIRAIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public readonly Action<float> WKCWSUVLAVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public readonly float RXAORPWRIZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public float QLTJXEOUDWJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public readonly string CANLOGIQDOT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public readonly bool KTJNBNWRZNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public readonly UpdateTypes PGCJQKXHIIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool XKSRJKJXSIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public bool SDSDKEEKPNN;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9023E40", Offset = "0x9022C40", VA = "0x189023E40")]
			public VCRWGUOPMDR(ZICDSLSKRWK a, Action b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x9023AE0", Offset = "0x90228E0", VA = "0x189023AE0")]
			public VCRWGUOPMDR(ZICDSLSKRWK a, Action<float> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x9023C60", Offset = "0x9022A60", VA = "0x189023C60")]
			public VCRWGUOPMDR(ZICDSLSKRWK a, float b, Action<float> c, YGPMNQYCYVH d, UpdateTypes e, bool f, bool g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x9023890", Offset = "0x9022690", VA = "0x189023890")]
			public bool YBKORFVYKPS(float a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly SPRKFJGZVXG YYJGUBRGQVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly YGPMNQYCYVH NMSSYCJEURI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<ScheduleQueueType, LVZCJKMHNII> WGTCVQGLGNT;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9021860", Offset = "0x9020660", VA = "0x189021860")]
		[AUEAKLYJEMA.Root]
		internal static void JOXQJZBYFWF(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9022080", Offset = "0x9020E80", VA = "0x189022080")]
		[UnityEngine.Scripting.Preserve]
		internal QFQTZTWFVVL([Inject(null)] SPRKFJGZVXG scheduler, [Inject(null)] YGPMNQYCYVH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9021BC0", Offset = "0x90209C0", VA = "0x189021BC0", Slot = "4")]
		public IDisposable Update(ZICDSLSKRWK context, Action callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9021DA0", Offset = "0x9020BA0", VA = "0x189021DA0", Slot = "5")]
		public IDisposable Update(ZICDSLSKRWK context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x90215F0", Offset = "0x90203F0", VA = "0x1890215F0", Slot = "7")]
		public IDisposable ERHQMBQLVMS(ZICDSLSKRWK a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9021F80", Offset = "0x9020D80", VA = "0x189021F80", Slot = "8")]
		public IDisposable ZIGYMJKCVYI(ZICDSLSKRWK a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x90216F0", Offset = "0x90204F0", VA = "0x1890216F0", Slot = "6")]
		public IDisposable ERHQMBQLVMS(float a, Action<float> b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9021A00", Offset = "0x9020800", VA = "0x189021A00", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x90218D0", Offset = "0x90206D0", VA = "0x1890218D0")]
		private LVZCJKMHNII KSJGKSESFOE(ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class SUPCDAFVYLP : LNIOUXPNHMM, SPRKFJGZVXG, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private AGPSBGPNVTU[] UUZCAELYZVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private MVGHAAVSFDI NBZLRPYNIVS;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9022B90", Offset = "0x9021990", VA = "0x189022B90")]
		[AUEAKLYJEMA.Root]
		internal static void UUQSMFQOYUN(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9022EE0", Offset = "0x9021CE0", VA = "0x189022EE0")]
		[UnityEngine.Scripting.Preserve]
		public SUPCDAFVYLP([Inject(null)] ZQINOWIUIGJ unityLifecycleEvents, [Inject(null)] YGPMNQYCYVH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x90222A0", Offset = "0x90210A0", VA = "0x1890222A0", Slot = "20")]
		public override JHHJDZQKJVL LCUCJLWZTHZ(QXWEXSDXBNL a, IEnumerator<NCPAWUBDFGC> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9022800", Offset = "0x9021600", VA = "0x189022800", Slot = "21")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9022400", Offset = "0x9021200", VA = "0x189022400", Slot = "23")]
		public override void LVZCJKMHNII(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9022C00", Offset = "0x9021A00", VA = "0x189022C00", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x90223D0", Offset = "0x90211D0", VA = "0x1890223D0")]
		private AGPSBGPNVTU LGXEHEYUDZD(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9022CD0", Offset = "0x9021AD0", VA = "0x189022CD0", Slot = "24")]
		internal override BOCVLSYCQUN XZXDOSKGZMV(IEnumerator<NCPAWUBDFGC> a, Behaviour b, OBIVKHVOQZY c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9022750", Offset = "0x9021550", VA = "0x189022750", Slot = "25")]
		internal override VHVCNMCTOLK PNLKFWBLKYU(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9022630", Offset = "0x9021430", VA = "0x189022630")]
		private void NBSJIOIVRQJ(AGPSBGPNVTU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9022240", Offset = "0x9021040", VA = "0x189022240", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[BurstCompile]
	internal struct ScheduleSortJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[ReadOnly]
		public float Now;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[ReadOnly]
		public int ActiveCoroutineCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private NativeArray<int> Indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private NativeArray<int> scratchLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private NativeArray<int> scratchRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[ReadOnly]
		public NativeArray<CoroutineState> AllCoroutineStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[ReadOnly]
		public NativeArray<float> AllNextUpdateTimes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[WriteOnly]
		public NativeArray<int> SortedIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[WriteOnly]
		public NativeArray<int> NumberToExecute;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9022F90", Offset = "0x9021D90", VA = "0x189022F90")]
		public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
		{
			return default(ScheduleSortJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x90230C0", Offset = "0x9021EC0", VA = "0x1890230C0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9023490", Offset = "0x9022290", VA = "0x189023490")]
		private bool URRTAUGXYVM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x90231A0", Offset = "0x9021FA0", VA = "0x1890231A0")]
		private void LTWKISCVAPS(NativeArray<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9023410", Offset = "0x9022210", VA = "0x189023410")]
		private int PPQTHALSTNF(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9022FF0", Offset = "0x9021DF0", VA = "0x189022FF0")]
		private void DYZHOWBILOW(NativeArray<int> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x90231D0", Offset = "0x9021FD0", VA = "0x1890231D0")]
		private void Merge(NativeArray<int> arr, int leftStart, int middle, int rightEnd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class LNIOUXPNHMM : SPRKFJGZVXG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class FRBXRYMZCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private sealed class HASRJEVTAVK : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private int GTWEEXJFPKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private NCPAWUBDFGC LBVZGXVZPSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public FRBXRYMZCEJ FNBWZDPUGEI;

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				private NCPAWUBDFGC HYUNTVFBJEN
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				private object UUTAULZFDNA
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
				[DebuggerHidden]
				public HASRJEVTAVK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
				[DebuggerHidden]
				private void NFYYAPEFSFX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x901C9B0", Offset = "0x901B7B0", VA = "0x18901C9B0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x901CAA0", Offset = "0x901B8A0", VA = "0x18901CAA0", Slot = "8")]
				[DebuggerHidden]
				private void USEBYPNATQY()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public LNIOUXPNHMM FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public float KXNTNVINGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public ScheduleQueueType WOJIXGXKJAD;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public FRBXRYMZCEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x901C470", Offset = "0x901B270", VA = "0x18901C470")]
			[IteratorStateMachine(typeof(HASRJEVTAVK))]
			internal IEnumerator<NCPAWUBDFGC> LIIVMCJYNYG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly ZQINOWIUIGJ XIEJOAMWBEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		protected readonly YGPMNQYCYVH NMSSYCJEURI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private VHVCNMCTOLK[] ZOVNICROXGE;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static SPRKFJGZVXG PKFRARWZTTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x901FA80", Offset = "0x901E880", VA = "0x18901FA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ScheduleQueueType NRREHVFWTNA
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ScheduleQueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D80", Offset = "0xAD2B80", VA = "0x180AD3D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public YGPMNQYCYVH DNOSKRZAQQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public NCPAWUBDFGC RMFPFXLXVAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public NCPAWUBDFGC DGUPNOHFGAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public NCPAWUBDFGC YNROIQQQVOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public NCPAWUBDFGC CKFBGLODJZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAC63E0", Offset = "0xAC51E0", VA = "0x180AC63E0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x901F460", Offset = "0x901E260", VA = "0x18901F460")]
		public static JHHJDZQKJVL KVHXAMANQJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x901FAF0", Offset = "0x901E8F0", VA = "0x18901FAF0")]
		[UnityEngine.Scripting.Preserve]
		protected LNIOUXPNHMM([Inject(null)] ZQINOWIUIGJ unityLifecycleEvents, [Inject(null)] YGPMNQYCYVH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x901FA50", Offset = "0x901E850", VA = "0x18901FA50", Slot = "6")]
		public JHHJDZQKJVL Run(IEnumerator<NCPAWUBDFGC> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x901F880", Offset = "0x901E680", VA = "0x18901F880", Slot = "7")]
		public JHHJDZQKJVL Run(Behaviour context, IEnumerator<NCPAWUBDFGC> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract JHHJDZQKJVL LCUCJLWZTHZ(QXWEXSDXBNL a, IEnumerator<NCPAWUBDFGC> b);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x901F710", Offset = "0x901E510", VA = "0x18901F710", Slot = "21")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x901EB70", Offset = "0x901D970", VA = "0x18901EB70", Slot = "9")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x901FA60", Offset = "0x901E860", VA = "0x18901FA60", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x901F1F0", Offset = "0x901DFF0", VA = "0x18901F1F0")]
		private void ESAMRGVCLUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x901F440", Offset = "0x901E240", VA = "0x18901F440")]
		private void IBFUXHAEMQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x901F400", Offset = "0x901E200", VA = "0x18901F400")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x901F580", Offset = "0x901E380", VA = "0x18901F580")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x901EB50", Offset = "0x901D950", VA = "0x18901EB50")]
		private void BTMTSJJDKPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x901F420", Offset = "0x901E220", VA = "0x18901F420")]
		private void HHQYPURIVKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x901F210", Offset = "0x901E010", VA = "0x18901F210")]
		private void EWTNTZZMHRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x901F4F0", Offset = "0x901E2F0", VA = "0x18901F4F0", Slot = "23")]
		public virtual void LVZCJKMHNII(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x901F230", Offset = "0x901E030", VA = "0x18901F230")]
		private void FDKRBUBYMFB(VHVCNMCTOLK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x27DC0A0", Offset = "0x27DAEA0", VA = "0x1827DC0A0")]
		private VHVCNMCTOLK LWCCNHHFNMX(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "24")]
		internal abstract BOCVLSYCQUN XZXDOSKGZMV(IEnumerator<NCPAWUBDFGC> a, Behaviour b, OBIVKHVOQZY c);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "25")]
		internal abstract VHVCNMCTOLK PNLKFWBLKYU(ScheduleQueueType a);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x901EDB0", Offset = "0x901DBB0", VA = "0x18901EDB0", Slot = "26")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x901F190", Offset = "0x901DF90", VA = "0x18901F190", Slot = "15")]
		public NCPAWUBDFGC EBPMXDNRMHK(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x901F690", Offset = "0x901E490", VA = "0x18901F690", Slot = "16")]
		public NCPAWUBDFGC QLZCPSWQXCJ(float a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x901F5A0", Offset = "0x901E3A0", VA = "0x18901F5A0", Slot = "17")]
		public JHHJDZQKJVL MYCOFPYVRIM(float a, ScheduleQueueType b = ScheduleQueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x901F130", Offset = "0x901DF30", VA = "0x18901F130", Slot = "18")]
		public NCPAWUBDFGC EAIDNQBXODS(Func<bool> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal sealed class BOCVLSYCQUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly OBIVKHVOQZY KZYXZROMHKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly RELLEZGJQML XXDCRZIVRTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly bool KOHSTNVHBQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private string GDOZECFRVGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private StackTrace GXHPFIRFEGF;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerator<NCPAWUBDFGC> FTLHKZTEQBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public NCPAWUBDFGC IWFSVHXLKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool BEDMGHYOLZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x9017D70", Offset = "0x9016B70", VA = "0x189017D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool RQNAWGBHWPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB6CC80", Offset = "0xB6BA80", VA = "0x180B6CC80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xC4E250", Offset = "0xC4D050", VA = "0x180C4E250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string CANLOGIQDOT
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x90181D0", Offset = "0x9016FD0", VA = "0x1890181D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float XVVCWYZZFSH
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xCF7DB0", Offset = "0xCF6BB0", VA = "0x180CF7DB0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xCF7DC0", Offset = "0xCF6BC0", VA = "0x180CF7DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9018460", Offset = "0x9017260", VA = "0x189018460")]
		public BOCVLSYCQUN(IEnumerator<NCPAWUBDFGC> a, RELLEZGJQML b, OBIVKHVOQZY c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9017E40", Offset = "0x9016C40", VA = "0x189017E40")]
		public NCPAWUBDFGC FWAFHHGRCJQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9018160", Offset = "0x9016F60", VA = "0x189018160")]
		public bool HHAGCOQSBXY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9017DF0", Offset = "0x9016BF0", VA = "0x189017DF0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9018380", Offset = "0x9017180", VA = "0x189018380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF03D0", Offset = "0xCEF1D0", VA = "0x180CF03D0")]
		[CompilerGenerated]
		private void OPCQAPOTQXG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class OBIVKHVOQZY : QLPFPLZGVKP, JHHJDZQKJVL, JWWHWLOHQXU, ILWLFVTHXJS, IEnumerator, NCPAWUBDFGC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private ScheduleQueueType GYVNPJTCBVC;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private ScheduleQueueType QIORYWTLSBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xE99480", Offset = "0xE98280", VA = "0x180E99480", Slot = "23")]
			get
			{
				return default(ScheduleQueueType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ScheduleQueueType JPGGZSSUQGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xE99140", Offset = "0xE97F40", VA = "0x180E99140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private float YMRCTAEZCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xB17E70", Offset = "0xB16C70", VA = "0x180B17E70", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool SLVSTCSVHOQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9021320", Offset = "0x9020120", VA = "0x189021320", Slot = "24")]
		private bool DSAQKJVKDJZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9021340", Offset = "0x9020140", VA = "0x189021340", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9021350", Offset = "0x9020150", VA = "0x189021350")]
		public OBIVKHVOQZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal enum TickResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Remove,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Reinsert,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		NextUpdateChanged
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal sealed class VHVCNMCTOLK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum SubQueue
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			Future
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct ReinsertBuffer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public ScheduleQueueType QueueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public SubQueue SubQueue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public List<BOCVLSYCQUN> Coroutines;
		}

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static readonly SubQueue[] YYDRNKBVDDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ScheduleQueueType ODWHGXRVINV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private bool MOIFHDPOUJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly BOCVLSYCQUN[] BCVQGTMVCFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly List<BOCVLSYCQUN> PDSRIJYTZVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly Stack<int> FWHUOLMDDXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<BOCVLSYCQUN> GTAJZEFMSIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Stack<int> HRZKAGZJEUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly MVGHAAVSFDI IBNKDUOWWVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private bool LTNTISIDYIO;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ReinsertBuffer[,] IVFNFHABLBB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x90255B0", Offset = "0x90243B0", VA = "0x1890255B0")]
		public VHVCNMCTOLK(ScheduleQueueType a, MVGHAAVSFDI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9024870", Offset = "0x9023670", VA = "0x189024870")]
		public void LIIHPFOINDX(BOCVLSYCQUN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x90251B0", Offset = "0x9023FB0", VA = "0x1890251B0")]
		public void YLJWZHHJFWL(IList<BOCVLSYCQUN> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9024ED0", Offset = "0x9023CD0", VA = "0x189024ED0")]
		public void XVFWNLIANYT(IList<BOCVLSYCQUN> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9024720", Offset = "0x9023520", VA = "0x189024720")]
		private void JUKDPPFTWVU(BOCVLSYCQUN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9024A70", Offset = "0x9023870", VA = "0x189024A70")]
		private void MFNJXDUFCPU(IList<BOCVLSYCQUN> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9024BF0", Offset = "0x90239F0", VA = "0x189024BF0")]
		private TickResult UUTBYAVHZER(BOCVLSYCQUN a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9024D60", Offset = "0x9023B60", VA = "0x189024D60")]
		public void Update(float currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9024410", Offset = "0x9023210", VA = "0x189024410")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x90240B0", Offset = "0x9022EB0", VA = "0x1890240B0")]
		private void ARPKIJILPVF(List<BOCVLSYCQUN> a, Stack<int> b, bool c, float d = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9024600", Offset = "0x9023400", VA = "0x189024600", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9024930", Offset = "0x9023730", VA = "0x189024930")]
		private void LKECBGGFUPH(List<BOCVLSYCQUN> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class LZYLCXELXUA : MVGHAAVSFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
		public void ZXFAGCJEDLF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void ACAWYMNPGZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public LZYLCXELXUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class XJYCAGPEXHL : RELLEZGJQML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly Behaviour VIIYKXWAKVZ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string CANLOGIQDOT
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x9026720", Offset = "0x9025520", VA = "0x189026720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool NDANQTLGWKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x90267A0", Offset = "0x90255A0", VA = "0x1890267A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool ELZDVARIWWM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x9026700", Offset = "0x9025500", VA = "0x189026700", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public XJYCAGPEXHL(Behaviour a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3769488181
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x9027440", Offset = "0x9026240", VA = "0x189027440")]
	public static void UVBMKKQUWLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x9027430", Offset = "0x9026230", VA = "0x189027430")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
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
