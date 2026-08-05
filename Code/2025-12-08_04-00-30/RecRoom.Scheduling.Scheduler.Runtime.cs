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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D1CBF0", Offset = "0x8D1B3F0", VA = "0x188D1CBF0", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D29560", Offset = "0x8D27D60", VA = "0x188D29560", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2735A30", Offset = "0x2734230", VA = "0x182735A30")]
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
			private sealed class CGPLWVDWZDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public MQLBUATGJGQ.WrapperKey UWHDEJCLXLY;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
				public CGPLWVDWZDM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x8D17FB0", Offset = "0x8D167B0", VA = "0x188D17FB0")]
				internal void UYMOZABEZHK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static IDisposable frameScope;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8D27B60", Offset = "0x8D26360", VA = "0x188D27B60")]
			public static PlayerLoopSystem PFUNHNYRHRK(MQLBUATGJGQ.WrapperKey a)
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
			private sealed class QFMADIQWEXT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public MQLBUATGJGQ.WrapperKey UWHDEJCLXLY;

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
				public QFMADIQWEXT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x8D1F6C0", Offset = "0x8D1DEC0", VA = "0x188D1F6C0")]
				internal void UYMOZABEZHK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D27A40", Offset = "0x8D26240", VA = "0x188D27A40")]
			public static PlayerLoopSystem PFUNHNYRHRK(MQLBUATGJGQ.WrapperKey a)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D186E0", Offset = "0x8D16EE0", VA = "0x188D186E0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D18760", Offset = "0x8D16F60", VA = "0x188D18760")]
		private static void CDVAFABEMTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D18C10", Offset = "0x8D17410", VA = "0x188D18C10")]
		private static void EQSWMMBXJWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D187B0", Offset = "0x8D16FB0", VA = "0x188D187B0")]
		private static void DZRIXDHVTGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D18E80", Offset = "0x8D17680", VA = "0x188D18E80")]
		private static void RQAWGIJJFIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3526CB0", Offset = "0x35254B0", VA = "0x183526CB0")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8D18DE0", Offset = "0x8D175E0", VA = "0x188D18DE0")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3526CB0", Offset = "0x35254B0", VA = "0x183526CB0")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3526DC0", Offset = "0x35255C0", VA = "0x183526DC0")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) ZLWQJUJROUL<a, b>(MQLBUATGJGQ.WrapperKey a)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D19A00", Offset = "0x8D18200", VA = "0x188D19A00")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) ZLWQJUJROUL(MQLBUATGJGQ.WrapperKey a, Type b, Type c)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class MQLBUATGJGQ
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
		public class IENQSLAXMAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly WrapperKey KVCKWVVIWZX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public readonly FWFXOCROZZW TVYBOBFTUMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private long BKBIUDAVTTP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private long KJXBPBZNRRU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public long VPHYNQGUNYV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int FYJUSAHVMOI;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B7D0", Offset = "0x8D19FD0", VA = "0x188D1B7D0")]
			public IENQSLAXMAK(WrapperKey a, int b = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B680", Offset = "0x8D19E80", VA = "0x188D1B680")]
			public void GJBMSLNOKHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B6A0", Offset = "0x8D19EA0", VA = "0x188D1B6A0")]
			public void VVOYCZEPAVM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B6F0", Offset = "0x8D19EF0", VA = "0x188D1B6F0")]
			public void WMZKSLORXYP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static WrapperKey[] SXNFWNSTDAK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IENQSLAXMAK[] IPLIROSQDSM;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1CDC0", Offset = "0x8D1B5C0", VA = "0x188D1CDC0")]
		public static IENQSLAXMAK VDWGSTNWENQ(WrapperKey a, int b = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D1CD50", Offset = "0x8D1B550", VA = "0x188D1CD50")]
		public static IENQSLAXMAK MJFKAFSGKFS(WrapperKey a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D1CCB0", Offset = "0x8D1B4B0", VA = "0x188D1CCB0")]
		public static void GUCDSLLOQMB()
		{
		}
	}
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class JVBTZGOFQQP
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private interface KLCZSLIJEVD
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			bool JYJXSMJLOLY
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
		private class JBUTJJVLELB : KLCZSLIJEVD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private readonly Action USRVGKKSQBX;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool JYJXSMJLOLY
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
			public JBUTJJVLELB(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1075170", Offset = "0x1073970", VA = "0x181075170", Slot = "5")]
			public void Complete()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly List<KLCZSLIJEVD> UTSUSUNHAEY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool TLUCNTQIECH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D1BD10", Offset = "0x8D1A510", VA = "0x188D1BD10")]
		public static void JUSHYESRXDO(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8D1BA50", Offset = "0x8D1A250", VA = "0x188D1BA50")]
		private static void BNHPRGEKYAQ(KLCZSLIJEVD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D1BEB0", Offset = "0x8D1A6B0", VA = "0x188D1BEB0")]
		private static void UJXVTKKISTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D1C190", Offset = "0x8D1A990", VA = "0x188D1C190")]
		private static void VDILWNJFCUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D1BDA0", Offset = "0x8D1A5A0", VA = "0x188D1BDA0")]
		private static void TZQQOMHRBYD()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class XENEVEVCEBW
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D27C80", Offset = "0x8D26480", VA = "0x188D27C80")]
		public static IDisposable AIMLUKMDIMD(this FRNFKJLNSJK a, float b, Action<float> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D27D00", Offset = "0x8D26500", VA = "0x188D27D00")]
		public static IDisposable OPTREGQWFJJ(this FRNFKJLNSJK a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D27D80", Offset = "0x8D26580", VA = "0x188D27D80")]
		public static IDisposable ORVNYUUQMWF(this FRNFKJLNSJK a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class DKBXWDMZPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3529F90", Offset = "0x3528790", VA = "0x183529F90")]
		[MustUseReturnValue]
		public static IDisposable RRGJZGTUZPR<a>(this a a, Action b, ScheduleQueueType c, bool d = true) where a : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x352A130", Offset = "0x3528930", VA = "0x18352A130")]
		[MustUseReturnValue]
		public static IDisposable RRGJZGTUZPR<b>(this b a, Action<float> b, ScheduleQueueType c, bool d = true) where b : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x352A2D0", Offset = "0x3528AD0", VA = "0x18352A2D0")]
		[MustUseReturnValue]
		public static IDisposable Update<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x35296C0", Offset = "0x3527EC0", VA = "0x1835296C0")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3529730", Offset = "0x3527F30", VA = "0x183529730")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action<float> update, bool validateContext = true) where T : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3529D20", Offset = "0x3528520", VA = "0x183529D20")]
		[MustUseReturnValue]
		public static IDisposable LateUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3529CB0", Offset = "0x35284B0", VA = "0x183529CB0")]
		[MustUseReturnValue]
		public static IDisposable KLURCAIVXWC<c>(this c a, Action b, bool c = true) where c : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3529C00", Offset = "0x3528400", VA = "0x183529C00")]
		[MustUseReturnValue]
		public static IDisposable IIZUZZOMCDX<d>(this d a, Action b, bool c = true) where d : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3529C70", Offset = "0x3528470", VA = "0x183529C70")]
		[MustUseReturnValue]
		public static IDisposable IPIZKJXGRXC<f>(this f a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where f : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D19BE0", Offset = "0x8D183E0", VA = "0x188D19BE0")]
		[MustUseReturnValue]
		public static IDisposable IPIZKJXGRXC(this MonoBehaviour a, POKLIYYXBNR b, float c, Action<float> d, ScheduleQueueType e, bool f = true, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x35298E0", Offset = "0x35280E0", VA = "0x1835298E0")]
		[MustUseReturnValue]
		public static IDisposable HAXIRQENQLA<g>(this g a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where g : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3529E10", Offset = "0x3528610", VA = "0x183529E10")]
		[MustUseReturnValue]
		public static IDisposable OWEJDKYXKRT<h>(this h a, float b, Action<float> c, bool d = true, bool e = true) where h : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3529A80", Offset = "0x3528280", VA = "0x183529A80")]
		[MustUseReturnValue]
		public static IDisposable HHAJVLSMMNI<i>(this i a, Action<float> b, bool c = true, bool d = true) where i : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3529D90", Offset = "0x3528590", VA = "0x183529D90")]
		[MustUseReturnValue]
		public static IDisposable ONUKMPVJSYL<j>(this j a, Action<float> b, bool c = true, bool d = true) where j : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x35295C0", Offset = "0x3527DC0", VA = "0x1835295C0")]
		[MustUseReturnValue]
		public static IDisposable CKZEEGZUGFQ<k>(this k a, Action<float> b, bool c = true, bool d = true) where k : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3529B80", Offset = "0x3528380", VA = "0x183529B80")]
		[MustUseReturnValue]
		public static IDisposable IASHWQKWSDT<l>(this l a, Action<float> b, bool c = true, bool d = true) where l : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3529F10", Offset = "0x3528710", VA = "0x183529F10")]
		[MustUseReturnValue]
		public static IDisposable QYXZSEUSSBF<m>(this m a, Action<float> b, bool c = true, bool d = true) where m : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3529B00", Offset = "0x3528300", VA = "0x183529B00")]
		[MustUseReturnValue]
		public static IDisposable HYZGBQWDBIP<n>(this n a, Action<float> b, bool c = true, bool d = true) where n : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3529E90", Offset = "0x3528690", VA = "0x183529E90")]
		[MustUseReturnValue]
		public static IDisposable OXXUVRNFNFX<q>(this q a, Action<float> b, bool c = true, bool d = true) where q : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3529640", Offset = "0x3527E40", VA = "0x183529640")]
		[MustUseReturnValue]
		public static IDisposable FCDIRRDWASN<s>(this s a, float b, Action<float> c, bool d = true, bool e = true) where s : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x352A340", Offset = "0x3528B40", VA = "0x18352A340")]
		[MustUseReturnValue]
		public static IDisposable XDIHJTIVJBP<u>(this u a, Action<float> b, bool c = true, bool d = true) where u : MonoBehaviour, POKLIYYXBNR
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class VQGIYSHJHQD
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class EJIPXHWGIUE : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ScheduleQueueType HZHLYVZJFSS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Action FKRPBUNJVLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private IYKJEBKIKYE QSNTXTLRKLZ;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public EJIPXHWGIUE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8D19E70", Offset = "0x8D18670", VA = "0x188D19E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8D19F40", Offset = "0x8D18740", VA = "0x188D19F40", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class EJNWUOQDSFN : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public ScheduleQueueType HZHLYVZJFSS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Action<float> FKRPBUNJVLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private IYKJEBKIKYE QSNTXTLRKLZ;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public EJNWUOQDSFN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8D19F80", Offset = "0x8D18780", VA = "0x188D19F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A060", Offset = "0x8D18860", VA = "0x188D1A060", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8D26820", Offset = "0x8D25020", VA = "0x188D26820")]
		public static XEXLSJPFYXK RRGJZGTUZPR(Action a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8D26980", Offset = "0x8D25180", VA = "0x188D26980")]
		public static XEXLSJPFYXK RRGJZGTUZPR(Behaviour a, Action b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D268A0", Offset = "0x8D250A0", VA = "0x188D268A0")]
		public static XEXLSJPFYXK RRGJZGTUZPR(Behaviour a, Action<float> b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D267A0", Offset = "0x8D24FA0", VA = "0x188D267A0")]
		[IteratorStateMachine(typeof(EJIPXHWGIUE))]
		private static IEnumerator<YTAMKWOJLST> HMZQGKANLEY(ScheduleQueueType a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8D26720", Offset = "0x8D24F20", VA = "0x188D26720")]
		[IteratorStateMachine(typeof(EJNWUOQDSFN))]
		private static IEnumerator<YTAMKWOJLST> HMZQGKANLEY(ScheduleQueueType a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class VPATSQCTOOC : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class PRONQDIHGHJ : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public VPATSQCTOOC VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public PRONQDIHGHJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F4E0", Offset = "0x8D1DCE0", VA = "0x188D1F4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F570", Offset = "0x8D1DD70", VA = "0x188D1F570", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ScheduleQueueType LFURNCIKTKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Action BODZNLYQACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool ZOLKCNSSLXO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BRHRKHOCZMU
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAA8640", Offset = "0xAA6E40", VA = "0x180AA8640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8D26650", Offset = "0x8D24E50", VA = "0x188D26650")]
		public VPATSQCTOOC(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D26540", Offset = "0x8D24D40", VA = "0x188D26540")]
		[IteratorStateMachine(typeof(PRONQDIHGHJ))]
		private IEnumerator<YTAMKWOJLST> HKYRERKGRUP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D265B0", Offset = "0x8D24DB0", VA = "0x188D265B0", Slot = "4")]
		public void OnCompleted(Action continuation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public void UIBMINFWSGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class QLFSAVWWFRN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F970", Offset = "0x8D1E170", VA = "0x188D1F970")]
		public static VPATSQCTOOC EWBVATDWNDU(this ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class VQPIWZFLFOD
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class PEWAZXGZYXK : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public VVXAPUBUBDG PVSPYGAZFXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Action<float> FKRPBUNJVLI;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public PEWAZXGZYXK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8D1EF40", Offset = "0x8D1D740", VA = "0x188D1EF40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8D1EFC0", Offset = "0x8D1D7C0", VA = "0x188D1EFC0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D26D50", Offset = "0x8D25550", VA = "0x188D26D50")]
		public static XEXLSJPFYXK RRGJZGTUZPR(float a, Action<float> b, ScheduleQueueType c, bool d = true, [Optional] SEPEWOFBWYL e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D26C80", Offset = "0x8D25480", VA = "0x188D26C80")]
		public static XEXLSJPFYXK RRGJZGTUZPR(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SEPEWOFBWYL f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8D26E20", Offset = "0x8D25620", VA = "0x188D26E20")]
		public static XEXLSJPFYXK TPWSUMLAICT(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SEPEWOFBWYL f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8D26AC0", Offset = "0x8D252C0", VA = "0x188D26AC0")]
		public static XEXLSJPFYXK LMVHFNWSKUN(FRNFKJLNSJK a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SEPEWOFBWYL f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D26A10", Offset = "0x8D25210", VA = "0x188D26A10")]
		private static IEnumerator<YTAMKWOJLST> HMZQGKANLEY(MUGMONEUUMI a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D26C20", Offset = "0x8D25420", VA = "0x188D26C20")]
		private static IEnumerator<YTAMKWOJLST> OHVVXUVVGBC(MUGMONEUUMI a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8D26B90", Offset = "0x8D25390", VA = "0x188D26B90")]
		[IteratorStateMachine(typeof(PEWAZXGZYXK))]
		private static IEnumerator<YTAMKWOJLST> LXEMIFRSUIM(VVXAPUBUBDG a, float b, ScheduleQueueType c, Action<float> d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class GUCSXUTHDSR
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class RPRKDGRARGR : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public ScheduleQueueType LFURNCIKTKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public Func<bool> XVLSXCAOVFO;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public RPRKDGRARGR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8D20870", Offset = "0x8D1F070", VA = "0x188D20870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8D20920", Offset = "0x8D1F120", VA = "0x188D20920", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A3F0", Offset = "0x8D18BF0", VA = "0x188D1A3F0")]
		[IteratorStateMachine(typeof(RPRKDGRARGR))]
		private static IEnumerator<YTAMKWOJLST> CUIJVMYJGFD(ScheduleQueueType a, Func<bool> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A470", Offset = "0x8D18C70", VA = "0x188D1A470")]
		public static XEXLSJPFYXK DLLRBZFOIWW(this MonoBehaviour a, Func<bool> b, ScheduleQueueType c = ScheduleQueueType.Update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class TGWRKAIYVJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class PQTMBCGRUNZ : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float LDZMNMLDFNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public ScheduleQueueType HZHLYVZJFSS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action SASQIIXTNHB;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public PQTMBCGRUNZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F430", Offset = "0x8D1DC30", VA = "0x188D1F430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F4A0", Offset = "0x8D1DCA0", VA = "0x188D1F4A0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class EFPGDSGIMAD<a> : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float LDZMNMLDFNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public ScheduleQueueType HZHLYVZJFSS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Action<a> SASQIIXTNHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public a VQMISCAQNCJ;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public EFPGDSGIMAD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4670150", Offset = "0x466E950", VA = "0x184670150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x3D305A0", Offset = "0x3D2EDA0", VA = "0x183D305A0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class IPRHEGVEZNZ : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float LDZMNMLDFNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ScheduleQueueType HZHLYVZJFSS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Action SASQIIXTNHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private YTAMKWOJLST SIYOHBCEBOD;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public IPRHEGVEZNZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B850", Offset = "0x8D1A050", VA = "0x188D1B850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8D1B8E0", Offset = "0x8D1A0E0", VA = "0x188D1B8E0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D24DC0", Offset = "0x8D235C0", VA = "0x188D24DC0")]
		[IteratorStateMachine(typeof(PQTMBCGRUNZ))]
		private static IEnumerator<YTAMKWOJLST> HKYRERKGRUP(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3A68E50", Offset = "0x3A67650", VA = "0x183A68E50")]
		[IteratorStateMachine(typeof(EFPGDSGIMAD<>))]
		private static IEnumerator<YTAMKWOJLST> HKYRERKGRUP<a>(float a, ScheduleQueueType b, Action<a> c, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D25150", Offset = "0x8D23950", VA = "0x188D25150")]
		[IteratorStateMachine(typeof(IPRHEGVEZNZ))]
		private static IEnumerator<YTAMKWOJLST> LZHEZZBVDGF(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D24FD0", Offset = "0x8D237D0", VA = "0x188D24FD0")]
		public static IDisposable ITNJHPAKLUB(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D24E50", Offset = "0x8D23650", VA = "0x188D24E50")]
		public static XEXLSJPFYXK HTBVIOTSQZT(this MonoBehaviour a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8D24EE0", Offset = "0x8D236E0", VA = "0x188D24EE0")]
		public static XEXLSJPFYXK ITNJHPAKLUB(this MonoBehaviour a, float b, ScheduleQueueType c, Action d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8D25320", Offset = "0x8D23B20", VA = "0x188D25320")]
		public static XEXLSJPFYXK QXLLCLLJZAX(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3A692F0", Offset = "0x3A67AF0", VA = "0x183A692F0")]
		public static XEXLSJPFYXK QXLLCLLJZAX<b>(this MonoBehaviour a, Action<b> b, b c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8D25460", Offset = "0x8D23C60", VA = "0x188D25460")]
		public static XEXLSJPFYXK TPHRZCWDYCJ(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8D250B0", Offset = "0x8D238B0", VA = "0x188D250B0")]
		public static XEXLSJPFYXK JUUSGJQNKEH(this MonoBehaviour a, Action b, [Optional] SEPEWOFBWYL c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8D25590", Offset = "0x8D23D90", VA = "0x188D25590")]
		public static XEXLSJPFYXK WOBMWNONPGX(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8D25630", Offset = "0x8D23E30", VA = "0x188D25630")]
		public static XEXLSJPFYXK YCJRLZAWHYP(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8D25280", Offset = "0x8D23A80", VA = "0x188D25280")]
		public static XEXLSJPFYXK ORWOCPNDBVR(MonoBehaviour a, ScheduleQueueType b, Action c, [Optional] SEPEWOFBWYL d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3A690B0", Offset = "0x3A678B0", VA = "0x183A690B0")]
		public static XEXLSJPFYXK ORWOCPNDBVR<h>(MonoBehaviour a, ScheduleQueueType b, Action<h> c, h d, [Optional] SEPEWOFBWYL e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8D25500", Offset = "0x8D23D00", VA = "0x188D25500")]
		public static XEXLSJPFYXK VTWDXDSWQXL(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8D253C0", Offset = "0x8D23BC0", VA = "0x188D253C0")]
		public static XEXLSJPFYXK SEBIQFRSDBH(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8D251E0", Offset = "0x8D239E0", VA = "0x188D251E0")]
		public static XEXLSJPFYXK MSXMDAZVCYV(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D24D20", Offset = "0x8D23520", VA = "0x188D24D20")]
		public static XEXLSJPFYXK BIXSLGWHFQF(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class ZLTYTWPXHPC : OEVXLFINOMM, IEnumerable<OEVXLFINOMM>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly List<OEVXLFINOMM> FJLTEHPKUAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool SAFGKYTYDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Action RILTLGXVFUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool ETMDBTSSVMI;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool EAXOIIWYBBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8D290A0", Offset = "0x8D278A0", VA = "0x188D290A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OFFKSGVYCZC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8D29000", Offset = "0x8D27800", VA = "0x188D29000", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8D28D90", Offset = "0x8D27590", VA = "0x188D28D90", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D294C0", Offset = "0x8D27CC0", VA = "0x188D294C0")]
		public ZLTYTWPXHPC([Optional] Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D28C20", Offset = "0x8D27420", VA = "0x188D28C20")]
		public void Add(OEVXLFINOMM limiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D28E30", Offset = "0x8D27630", VA = "0x188D28E30")]
		private void EBUECJAOXBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D291C0", Offset = "0x8D279C0", VA = "0x188D291C0", Slot = "7")]
		public bool YOBASLOTEPG(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D291D0", Offset = "0x8D279D0", VA = "0x188D291D0", Slot = "8")]
		public bool YOBASLOTEPG(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D28F80", Offset = "0x8D27780", VA = "0x188D28F80", Slot = "9")]
		public IEnumerator<OEVXLFINOMM> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D28F80", Offset = "0x8D27780", VA = "0x188D28F80", Slot = "10")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class OJFVIMJEEJI : QNLKOBXBXOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class GZWDQNLWZKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public OJFVIMJEEJI VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Action USRVGKKSQBX;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public GZWDQNLWZKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A550", Offset = "0x8D18D50", VA = "0x188D1A550")]
			internal void QWOSNSZEHGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KSOSAENBDBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public OJFVIMJEEJI VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action USRVGKKSQBX;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KSOSAENBDBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8D1A550", Offset = "0x8D18D50", VA = "0x188D1A550")]
			internal void MJXZRAEVWVR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly float UVGJPEZHSZZ;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D1EE00", Offset = "0x8D1D600", VA = "0x188D1EE00")]
		public OJFVIMJEEJI(Behaviour a, float b, [Optional] Action c, [Optional] SEPEWOFBWYL d, [Optional] MUGMONEUUMI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ECF0", Offset = "0x8D1D4F0", VA = "0x188D1ECF0", Slot = "9")]
		protected override bool KYPQGLPYIXA(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D1EBE0", Offset = "0x8D1D3E0", VA = "0x188D1EBE0", Slot = "10")]
		protected override bool DRFQVXMRSKZ(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface OEVXLFINOMM
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool EAXOIIWYBBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action OFFKSGVYCZC;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool YOBASLOTEPG(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool YOBASLOTEPG(Action a, bool b = false);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class QNLKOBXBXOC : OEVXLFINOMM
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class QCZXMQOSCSF : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public QNLKOBXBXOC VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float ONAFKCQMWTB;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public QCZXMQOSCSF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F5B0", Offset = "0x8D1DDB0", VA = "0x188D1F5B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8D1F680", Offset = "0x8D1DE80", VA = "0x188D1F680", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly Behaviour ZJYUDPTNQRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action RILTLGXVFUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private IHSGGRZWIQF CYCUGNTGSUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly SEPEWOFBWYL TTKVAEMBSNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected readonly MUGMONEUUMI EQHBWPPJJCJ;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool EAXOIIWYBBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xB61AB0", Offset = "0xB602B0", VA = "0x180B61AB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action OFFKSGVYCZC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8D1FD80", Offset = "0x8D1E580", VA = "0x188D1FD80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8D1FCE0", Offset = "0x8D1E4E0", VA = "0x188D1FCE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D20000", Offset = "0x8D1E800", VA = "0x188D20000")]
		protected QNLKOBXBXOC(Behaviour a, [Optional] Action b, [Optional] SEPEWOFBWYL c, [Optional] MUGMONEUUMI d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FF40", Offset = "0x8D1E740", VA = "0x188D1FF40", Slot = "7")]
		public bool YOBASLOTEPG(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FFA0", Offset = "0x8D1E7A0", VA = "0x188D1FFA0", Slot = "8")]
		public bool YOBASLOTEPG(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool KYPQGLPYIXA(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool DRFQVXMRSKZ(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FF20", Offset = "0x8D1E720", VA = "0x188D1FF20")]
		protected void VPIXMMXUJOR(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FAB0", Offset = "0x8D1E2B0", VA = "0x188D1FAB0")]
		protected DNXWICJZUNF BPHAINUOBVV(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FE20", Offset = "0x8D1E620", VA = "0x188D1FE20")]
		private void NRYBHPCYWCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FEA0", Offset = "0x8D1E6A0", VA = "0x188D1FEA0")]
		[IteratorStateMachine(typeof(QCZXMQOSCSF))]
		private IEnumerator<YTAMKWOJLST> PFXCTRYXJGW(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D1FA70", Offset = "0x8D1E270", VA = "0x188D1FA70")]
		[CompilerGenerated]
		private void ADJTOMBQZOD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class VOKFNKVLZDB : QNLKOBXBXOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly float XVEVCSRWWRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int OUMPTDTQKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly float QVRFQHBCSPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly float[] PYETKJFIHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int ARXYAWXVKUW;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D26370", Offset = "0x8D24B70", VA = "0x188D26370")]
		public VOKFNKVLZDB(Behaviour a, float b, int c, [Optional] Action d, float e = 0f, [Optional] SEPEWOFBWYL f, [Optional] MUGMONEUUMI g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "9")]
		protected override bool KYPQGLPYIXA(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D260F0", Offset = "0x8D248F0", VA = "0x188D260F0", Slot = "10")]
		protected override bool DRFQVXMRSKZ(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D262F0", Offset = "0x8D24AF0", VA = "0x188D262F0")]
		private void UQEBEZWYOBO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class YKGUXEFVPOH : QNLKOBXBXOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly float UVGJPEZHSZZ;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D1EE00", Offset = "0x8D1D600", VA = "0x188D1EE00")]
		public YKGUXEFVPOH(Behaviour a, float b, [Optional] Action c, [Optional] SEPEWOFBWYL d, [Optional] MUGMONEUUMI e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "9")]
		protected override bool KYPQGLPYIXA(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D28BE0", Offset = "0x8D273E0", VA = "0x188D28BE0", Slot = "10")]
		protected override bool DRFQVXMRSKZ(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class UMWXPSDCPKV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class TQBPDYVCDRF : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public Action EAHLSMITFYD;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public TQBPDYVCDRF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8D256D0", Offset = "0x8D23ED0", VA = "0x188D256D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8D25780", Offset = "0x8D23F80", VA = "0x188D25780", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private XEXLSJPFYXK LOLGPBGRZDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private FRNFKJLNSJK ZJYUDPTNQRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private Action<float> DPOORHSIOYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private ScheduleQueueType LFURNCIKTKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private float JCLBXKIOYXW;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D25F50", Offset = "0x8D24750", VA = "0x188D25F50")]
		public UMWXPSDCPKV(FRNFKJLNSJK a, float b, Action<float> c, ScheduleQueueType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D25C60", Offset = "0x8D24460", VA = "0x188D25C60")]
		private void SZOVVGPVHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D25DC0", Offset = "0x8D245C0", VA = "0x188D25DC0")]
		private void VKAYBLFEIMZ(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D25EE0", Offset = "0x8D246E0", VA = "0x188D25EE0")]
		[IteratorStateMachine(typeof(TQBPDYVCDRF))]
		private IEnumerator<YTAMKWOJLST> YDHLXGYIQPD(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D25C00", Offset = "0x8D24400", VA = "0x188D25C00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D25A90", Offset = "0x8D24290", VA = "0x188D25A90")]
		[CompilerGenerated]
		private void AUKBCXRHNVC(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class IBXNXEEAWHF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class TOQSXDLUPPU : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Action EAHLSMITFYD;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public TOQSXDLUPPU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8D256D0", Offset = "0x8D23ED0", VA = "0x188D256D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8D25740", Offset = "0x8D23F40", VA = "0x188D25740", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private XEXLSJPFYXK LOLGPBGRZDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private MonoBehaviour JWIRPHXUYDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Action FKRPBUNJVLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Action<float> DPOORHSIOYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private ScheduleQueueType LFURNCIKTKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private float JCLBXKIOYXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool MLVMDUJDZQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly SEPEWOFBWYL TTKVAEMBSNW;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B160", Offset = "0x8D19960", VA = "0x188D1B160")]
		public IBXNXEEAWHF(MonoBehaviour a, Action b, ScheduleQueueType c, [Optional] SEPEWOFBWYL d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B4C0", Offset = "0x8D19CC0", VA = "0x188D1B4C0")]
		public IBXNXEEAWHF(MonoBehaviour a, Action<float> b, ScheduleQueueType c, [Optional] SEPEWOFBWYL d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B2E0", Offset = "0x8D19AE0", VA = "0x188D1B2E0")]
		public IBXNXEEAWHF(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SEPEWOFBWYL f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xC68590", Offset = "0xC66D90", VA = "0x180C68590")]
		private IBXNXEEAWHF(SEPEWOFBWYL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A750", Offset = "0x8D18F50", VA = "0x188D1A750")]
		internal static IBXNXEEAWHF FRSQHOMMLJP(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] SEPEWOFBWYL f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8D1AC10", Offset = "0x8D19410", VA = "0x188D1AC10")]
		private void RRGJZGTUZPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A580", Offset = "0x8D18D80", VA = "0x188D1A580")]
		private void BFBTYOBPZRX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D1AD40", Offset = "0x8D19540", VA = "0x188D1AD40")]
		private void SZOVVGPVHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A970", Offset = "0x8D19170", VA = "0x188D1A970")]
		private void JLELSYUXNSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8D1AEB0", Offset = "0x8D196B0", VA = "0x188D1AEB0")]
		private void VKAYBLFEIMZ(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B060", Offset = "0x8D19860", VA = "0x188D1B060")]
		[IteratorStateMachine(typeof(TOQSXDLUPPU))]
		private IEnumerator<YTAMKWOJLST> YDHLXGYIQPD(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D1A6F0", Offset = "0x8D18EF0", VA = "0x188D1A6F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8D1AFD0", Offset = "0x8D197D0", VA = "0x188D1AFD0")]
		[CompilerGenerated]
		private void XTUQLPZSWCM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8D1AAF0", Offset = "0x8D192F0", VA = "0x188D1AAF0")]
		[CompilerGenerated]
		private void JTHICAZWUKL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8D1AB80", Offset = "0x8D19380", VA = "0x188D1AB80")]
		[CompilerGenerated]
		private void LKOWJQNDTHC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B0D0", Offset = "0x8D198D0", VA = "0x188D1B0D0")]
		[CompilerGenerated]
		private void YXTZMMLGQDX(string a)
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
	internal sealed class OIQQSYRXPSG : MUGMONEUUMI
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float IHVIPGGUYKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8D1EB60", Offset = "0x8D1D360", VA = "0x188D1EB60", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float BZRWBGEFTHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8D1EB30", Offset = "0x8D1D330", VA = "0x188D1EB30", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public double QRAIJYHXFEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x8D1EB40", Offset = "0x8D1D340", VA = "0x188D1EB40", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D1EB70", Offset = "0x8D1D370", VA = "0x188D1EB70")]
		[UKOBXVXKPZF.Root]
		internal static void SKEBEIJGPGG(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		[UnityEngine.Scripting.Preserve]
		internal OIQQSYRXPSG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal interface EQPABMEAVZV
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CMKCAWPRFLU(string a);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QBEXEMQDFTI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal interface RCLIIGYRNCC
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool BNNDFGNXEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool YNYVGUCJUYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal class PPOBFQXIZMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public SLEMKTZSLRD XOQALWFTSJY;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int NMPLFXDGBRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xA9E110", Offset = "0xA9C910", VA = "0x180A9E110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAA9530", Offset = "0xAA7D30", VA = "0x180AA9530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F2D0", Offset = "0x8D1DAD0", VA = "0x188D1F2D0")]
		public static YTAMKWOJLST OUBCIUKUNYN(IEnumerator<YTAMKWOJLST> a, DKLTLVPTWAB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F210", Offset = "0x8D1DA10", VA = "0x188D1F210")]
		public YTAMKWOJLST OUBCIUKUNYN(DKLTLVPTWAB[] a, IEnumerator<YTAMKWOJLST>[] b, YTAMKWOJLST[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F0F0", Offset = "0x8D1D8F0", VA = "0x188D1F0F0")]
		public void ICAWLIOPPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F120", Offset = "0x8D1D920", VA = "0x188D1F120")]
		public void NXZLMXBSPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F000", Offset = "0x8D1D800", VA = "0x188D1F000")]
		public void AUOLHJCVDLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8D1F0F0", Offset = "0x8D1D8F0", VA = "0x188D1F0F0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public PPOBFQXIZMM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class SLEMKTZSLRD
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct JobbedInsertionData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public PPOBFQXIZMM Routine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public FRNFKJLNSJK Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public DKLTLVPTWAB Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public IEnumerator<YTAMKWOJLST> Coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public YTAMKWOJLST CurrentSchedule;

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
		private sealed class BEAFSXJMGRW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public DKLTLVPTWAB UAIIZOLEBCY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public SLEMKTZSLRD VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public FRNFKJLNSJK ZJYUDPTNQRI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public PPOBFQXIZMM AJHSTLTFXWR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public CoroutineState PYUHNXIELNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public YTAMKWOJLST RCNZUJGFEVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public IEnumerator<YTAMKWOJLST> CLRPVVGOCOH;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public BEAFSXJMGRW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8D17840", Offset = "0x8D16040", VA = "0x188D17840")]
			internal void TCDUWSVWESP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class EDWFKKNFIJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public PPOBFQXIZMM PVSPYGAZFXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public SLEMKTZSLRD VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public EDWFKKNFIJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8D19E30", Offset = "0x8D18630", VA = "0x188D19E30")]
			internal void MKMLCVPHAFN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class RCUVDQBECHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public PPOBFQXIZMM PVSPYGAZFXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public SLEMKTZSLRD VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public RCUVDQBECHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8D20830", Offset = "0x8D1F030", VA = "0x188D20830")]
			internal void FCWIYKJBTFP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class MJODJXTEBZU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public PPOBFQXIZMM PVSPYGAZFXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public SLEMKTZSLRD VIXLAPAPYNX;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public MJODJXTEBZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8D1CC70", Offset = "0x8D1B470", VA = "0x188D1CC70")]
			internal void ABOUHPDYVPU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const CoroutineState GAERTMQHDPD = CoroutineState.Cancelled | CoroutineState.Paused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ScheduleQueueType LFURNCIKTKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool[] YYWSOKINNUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private NativeArray<CoroutineState> ZWLLVVYVMSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NativeArray<float> FYEGVTDSLRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private NativeArray<int> WBOVUBVOQFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private NativeArray<int> YDFDGGNCHQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private NativeArray<int> FEYAGWUVNAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private NativeArray<int> JTSPHTSKRCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<int> FXJOLYYUCOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private PPOBFQXIZMM[] JMICTTVVZFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private DKLTLVPTWAB[] LLVEJMWQZVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private FRNFKJLNSJK[] ONGNIJRHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<YTAMKWOJLST>[] JYJFTBQIUKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private YTAMKWOJLST[] FCCLDJQWDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int JYUZVOJLVUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int NEKWUZIRPDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly int YHSOBYSATDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private float GBHZGIYYQSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ScheduleSortJob DASHOIXTPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private JobHandle CKNKPTJILMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<PPOBFQXIZMM> MLKULTFYWMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private bool PRRQGLXJEJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private List<Action> RGBZPHZVBSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private List<Action> WLOTBAZOYWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool JISGXLDLPAP;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JobbedReinsertBuffer[] PBEHCPCSXGN
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xBF04D0", Offset = "0xBEECD0", VA = "0x180BF04D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8D240A0", Offset = "0x8D228A0", VA = "0x188D240A0")]
		private static int YDSCOBMIRXV(ScheduleQueueType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8D241B0", Offset = "0x8D229B0", VA = "0x188D241B0")]
		public SLEMKTZSLRD(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8D22070", Offset = "0x8D20870", VA = "0x188D22070")]
		private void CNNGJBFYRDH(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8D22E90", Offset = "0x8D21690", VA = "0x188D22E90")]
		public void GXYDJLNOVCJ(FRNFKJLNSJK a, YTAMKWOJLST b, IEnumerator<YTAMKWOJLST> c, DKLTLVPTWAB d, [Optional] PPOBFQXIZMM e, CoroutineState f = CoroutineState.Running)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8D23060", Offset = "0x8D21860", VA = "0x188D23060")]
		public void Insert(IEnumerable<JobbedInsertionData> insertionDatas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8D23B10", Offset = "0x8D22310", VA = "0x188D23B10")]
		private JobbedInsertionData XLCSXZJLPCO(int a)
		{
			return default(JobbedInsertionData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8D22430", Offset = "0x8D20C30", VA = "0x188D22430")]
		private void FZEIIVLGJUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3A250E0", Offset = "0x3A238E0", VA = "0x183A250E0")]
		private static void MCJYYEHKWJU<a>(int a, a[] b, int c, [Optional] a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3A25130", Offset = "0x3A23930", VA = "0x183A25130")]
		private static void MCJYYEHKWJU<b>(int a, NativeArray<b> b, int c, [Optional] b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8D232A0", Offset = "0x8D21AA0", VA = "0x188D232A0")]
		private void JNAIYXCXNYC(IEnumerable<JobbedInsertionData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8D23620", Offset = "0x8D21E20", VA = "0x188D23620")]
		private void KRFQDGXTHIL(JobbedInsertionData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8D237D0", Offset = "0x8D21FD0", VA = "0x188D237D0")]
		private TickResult MLSTTJQOPRA(int a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8D21E70", Offset = "0x8D20670", VA = "0x188D21E70")]
		public void BABJWHCLTXL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8D240D0", Offset = "0x8D228D0", VA = "0x188D240D0")]
		private void YHIUYLNIRDZ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8D23FC0", Offset = "0x8D227C0", VA = "0x188D23FC0")]
		private void XYDSKMEOFAH(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8D22780", Offset = "0x8D20F80", VA = "0x188D22780")]
		public void GDRALERGFDB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8D22330", Offset = "0x8D20B30", VA = "0x188D22330")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8D22250", Offset = "0x8D20A50", VA = "0x188D22250")]
		public void Cancel(PPOBFQXIZMM schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8D23A30", Offset = "0x8D22230", VA = "0x188D23A30")]
		public void Pause(PPOBFQXIZMM schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8D236F0", Offset = "0x8D21EF0", VA = "0x188D236F0")]
		public void MJTHUWIWTFA(PPOBFQXIZMM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class Receipt : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly Receipt ZVPUUHTUYEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Action BBKOWNTBBET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private bool IWZTIHAPXBS;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8397680", Offset = "0x8395E80", VA = "0x188397680", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface JILOYSBCXCF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		a GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable PNWUPUPYIZL(UnityEngine.Object a, Action<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface HHKIQAEUCCX<a> : JILOYSBCXCF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		new a GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class GOSMKESIMBQ<a> : HHKIQAEUCCX<a>, JILOYSBCXCF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class CGWGTPBDRTH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public GOSMKESIMBQ<a> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public Tuple<UnityEngine.Object, Action<a>> KPOZBHWSOAY;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CGWGTPBDRTH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x3D352B0", Offset = "0x3D33AB0", VA = "0x183D352B0")]
			internal void OCEPCQOPXYH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static GameObject RCZASGNUVHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly List<Tuple<UnityEngine.Object, Action<a>>> UTHUHXHIWKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private a NOPAUJVPRGV;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xBE0F00", Offset = "0xBDF700", VA = "0x180BE0F00", Slot = "5")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x4DD1A90", Offset = "0x4DD0290", VA = "0x184DD1A90", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4DD29B0", Offset = "0x4DD11B0", VA = "0x184DD29B0")]
		private static bool PWDZYRWYSXT(a a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4DD2BA0", Offset = "0x4DD13A0", VA = "0x184DD2BA0")]
		public GOSMKESIMBQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4DD22C0", Offset = "0x4DD0AC0", VA = "0x184DD22C0", Slot = "6")]
		public IDisposable PNWUPUPYIZL(UnityEngine.Object a, Action<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4DD1C10", Offset = "0x4DD0410", VA = "0x184DD1C10")]
		private void PGMOMCBJERH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class WWGYAQTNHWG : EMRIVLJUJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class COLVPAIDAPX : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private class FUFXEZNZFZM : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				private int MGJVPXFWRUS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private COLVPAIDAPX HZHLYVZJFSS;

				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0xDC4580", Offset = "0xDC2D80", VA = "0x180DC4580")]
				public FUFXEZNZFZM(int a, COLVPAIDAPX b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A3C0", Offset = "0x8D18BC0", VA = "0x188D1A3C0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class CDBDDHGPLTW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public int MGJVPXFWRUS;

				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
				public CDBDDHGPLTW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xCA8AF0", Offset = "0xCA72F0", VA = "0x180CA8AF0")]
				internal bool HFIYBZJGPLN(QWNPCUUNZKK a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class EKOFGWLQNKG : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int ILQFHFJYACP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private YTAMKWOJLST YDRMGGSTAGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public COLVPAIDAPX VIXLAPAPYNX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public MUGMONEUUMI JDNGKJGUBIU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private IYKJEBKIKYE QSNTXTLRKLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private List<QWNPCUUNZKK> WLLQCESOSQF;

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				private YTAMKWOJLST DOMZTRRLMSO
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				private object IDRIDRBRWXH
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
				[DebuggerHidden]
				public EKOFGWLQNKG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A0A0", Offset = "0x8D188A0", VA = "0x188D1A0A0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x8D1A380", Offset = "0x8D18B80", VA = "0x188D1A380", Slot = "8")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private readonly ScheduleQueueType LFURNCIKTKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private XEXLSJPFYXK UAIIZOLEBCY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private readonly List<QWNPCUUNZKK> KAEWAGQSVZT;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8D18650", Offset = "0x8D16E50", VA = "0x188D18650")]
			public COLVPAIDAPX(ScheduleQueueType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8D18300", Offset = "0x8D16B00", VA = "0x188D18300")]
			public IDisposable KFWKCBVYABE(QWNPCUUNZKK a, SEPEWOFBWYL b, MUGMONEUUMI c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8D184D0", Offset = "0x8D16CD0", VA = "0x188D184D0")]
			private void UICDGFQDCHT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8D18270", Offset = "0x8D16A70", VA = "0x188D18270")]
			[IteratorStateMachine(typeof(EKOFGWLQNKG))]
			private IEnumerator<YTAMKWOJLST> HMZQGKANLEY(MUGMONEUUMI a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8D18220", Offset = "0x8D16A20", VA = "0x188D18220", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class QWNPCUUNZKK
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
			private static int XEGJOGZHQKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public readonly int CXQIBDZHUDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public readonly POKLIYYXBNR CZBFJPEOKFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private readonly MonoBehaviour NKPOERJNDXG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public readonly Action JACTXBOEIBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public readonly Action<float> UIUBQAYNWLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public readonly float THYLETPNMIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public float FYEGVTDSLRU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public readonly string NRBYPZADYJW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public readonly bool HWAUUDJVHAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public readonly UpdateTypes XNIRVYMXLLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool IVGIGIDKGCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public bool JKQTTWYBVAM;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x8D204F0", Offset = "0x8D1ECF0", VA = "0x188D204F0")]
			public QWNPCUUNZKK(POKLIYYXBNR a, Action b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8D20380", Offset = "0x8D1EB80", VA = "0x188D20380")]
			public QWNPCUUNZKK(POKLIYYXBNR a, Action<float> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8D20660", Offset = "0x8D1EE60", VA = "0x188D20660")]
			public QWNPCUUNZKK(POKLIYYXBNR a, float b, Action<float> c, MUGMONEUUMI d, UpdateTypes e, bool f, bool g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8D20130", Offset = "0x8D1E930", VA = "0x188D20130")]
			public bool XRNNOVDTRVX(float a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly SEPEWOFBWYL TTKVAEMBSNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly MUGMONEUUMI EQHBWPPJJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<ScheduleQueueType, COLVPAIDAPX> CFLDGZYWSZQ;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8D27340", Offset = "0x8D25B40", VA = "0x188D27340")]
		[UKOBXVXKPZF.Root]
		internal static void UYNXFXXNCHI(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8D27980", Offset = "0x8D26180", VA = "0x188D27980")]
		[UnityEngine.Scripting.Preserve]
		internal WWGYAQTNHWG([Inject(null)] SEPEWOFBWYL scheduler, [Inject(null)] MUGMONEUUMI schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8D273B0", Offset = "0x8D25BB0", VA = "0x188D273B0", Slot = "4")]
		public IDisposable Update(POKLIYYXBNR context, Action callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8D27580", Offset = "0x8D25D80", VA = "0x188D27580", Slot = "5")]
		public IDisposable Update(POKLIYYXBNR context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8D26F10", Offset = "0x8D25710", VA = "0x188D26F10", Slot = "7")]
		public IDisposable OWEJDKYXKRT(POKLIYYXBNR a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8D27880", Offset = "0x8D26080", VA = "0x188D27880", Slot = "8")]
		public IDisposable WBQAIMOAAVP(POKLIYYXBNR a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8D27010", Offset = "0x8D25810", VA = "0x188D27010", Slot = "6")]
		public IDisposable OWEJDKYXKRT(float a, Action<float> b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8D27180", Offset = "0x8D25980", VA = "0x188D27180", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8D27750", Offset = "0x8D25F50", VA = "0x188D27750")]
		private COLVPAIDAPX VQWXMBIFXYD(ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class XXJCQPZLNEU : SBZLIIFZGEF, SEPEWOFBWYL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private SLEMKTZSLRD[] IBNCJYCMMGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private EQPABMEAVZV MRMCYLCONGF;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8D28740", Offset = "0x8D26F40", VA = "0x188D28740")]
		[UKOBXVXKPZF.Root]
		internal static void SKEBEIJGPGG(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8D28B30", Offset = "0x8D27330", VA = "0x188D28B30")]
		[UnityEngine.Scripting.Preserve]
		public XXJCQPZLNEU([Inject(null)] RMMQJRHEEFS unityLifecycleEvents, [Inject(null)] MUGMONEUUMI schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8D28290", Offset = "0x8D26A90", VA = "0x188D28290", Slot = "20")]
		public override XEXLSJPFYXK IEPBFOFACHA(FRNFKJLNSJK a, IEnumerator<YTAMKWOJLST> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8D283C0", Offset = "0x8D26BC0", VA = "0x188D283C0", Slot = "21")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8D27E30", Offset = "0x8D26630", VA = "0x188D27E30", Slot = "23")]
		public override void COLVPAIDAPX(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8D287B0", Offset = "0x8D26FB0", VA = "0x188D287B0", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8D27E00", Offset = "0x8D26600", VA = "0x188D27E00")]
		private SLEMKTZSLRD AFFRQRWAWSW(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8D28920", Offset = "0x8D27120", VA = "0x188D28920", Slot = "24")]
		internal override LFKOBMJBINI ZTQAGQTDBAW(IEnumerator<YTAMKWOJLST> a, Behaviour b, DKLTLVPTWAB c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8D28060", Offset = "0x8D26860", VA = "0x188D28060", Slot = "25")]
		internal override OCPCLGCDWRN CTBZAYHWBBJ(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8D28170", Offset = "0x8D26970", VA = "0x188D28170")]
		private void EXVEBNEVIAK(SLEMKTZSLRD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8D28110", Offset = "0x8D26910", VA = "0x188D28110", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D248B0", Offset = "0x8D230B0", VA = "0x188D248B0")]
		public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
		{
			return default(ScheduleSortJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8D24910", Offset = "0x8D23110", VA = "0x188D24910", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8D24C60", Offset = "0x8D23460", VA = "0x188D24C60")]
		private bool QSEXPPPUKKT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8D24C30", Offset = "0x8D23430", VA = "0x188D24C30")]
		private void OTCGQNLUJPT(NativeArray<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8D24CA0", Offset = "0x8D234A0", VA = "0x188D24CA0")]
		private int YBZNHMMTAPK(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8D247E0", Offset = "0x8D22FE0", VA = "0x188D247E0")]
		private void AFVKRMBXSYP(NativeArray<int> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8D249F0", Offset = "0x8D231F0", VA = "0x188D249F0")]
		private void Merge(NativeArray<int> arr, int leftStart, int middle, int rightEnd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class SBZLIIFZGEF : SEPEWOFBWYL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class MTJUHHTQZRG
		{
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private sealed class JKALTHSHSPZ : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private int ILQFHFJYACP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private YTAMKWOJLST YDRMGGSTAGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public MTJUHHTQZRG VIXLAPAPYNX;

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				private YTAMKWOJLST DOMZTRRLMSO
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				private object IDRIDRBRWXH
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
				[DebuggerHidden]
				public JKALTHSHSPZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x8D1B920", Offset = "0x8D1A120", VA = "0x188D1B920", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x8D1BA10", Offset = "0x8D1A210", VA = "0x188D1BA10", Slot = "8")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public SBZLIIFZGEF VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public float LDZMNMLDFNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public ScheduleQueueType HZHLYVZJFSS;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public MTJUHHTQZRG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D070", Offset = "0x8D1B870", VA = "0x188D1D070")]
			[IteratorStateMachine(typeof(JKALTHSHSPZ))]
			internal IEnumerator<YTAMKWOJLST> HQNRYTNHPDJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly RMMQJRHEEFS HSTDBILYFZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		protected readonly MUGMONEUUMI EQHBWPPJJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private OCPCLGCDWRN[] BGCTENPWPIH;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static SEPEWOFBWYL GUPHEVFTUDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x8D213E0", Offset = "0x8D1FBE0", VA = "0x188D213E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static bool BXPTSGXIQZR
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ScheduleQueueType XYVOJVUJEVL
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xA9E110", Offset = "0xA9C910", VA = "0x180A9E110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ScheduleQueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAA9530", Offset = "0xAA7D30", VA = "0x180AA9530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MUGMONEUUMI OUYSUPPXFVK
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public YTAMKWOJLST SURLRAXDWXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public YTAMKWOJLST UZPUIHGPOEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public YTAMKWOJLST BQJFSKWGIUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public YTAMKWOJLST SGXCASDZXQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA9E160", Offset = "0xA9C960", VA = "0x180A9E160", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8D21550", Offset = "0x8D1FD50", VA = "0x188D21550")]
		public static XEXLSJPFYXK RKIOKMBFKTV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8D219F0", Offset = "0x8D201F0", VA = "0x188D219F0")]
		[UnityEngine.Scripting.Preserve]
		protected SBZLIIFZGEF([Inject(null)] RMMQJRHEEFS unityLifecycleEvents, [Inject(null)] MUGMONEUUMI schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8D21920", Offset = "0x8D20120", VA = "0x188D21920", Slot = "6")]
		public XEXLSJPFYXK Run(IEnumerator<YTAMKWOJLST> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8D21750", Offset = "0x8D1FF50", VA = "0x188D21750", Slot = "7")]
		public XEXLSJPFYXK Run(Behaviour context, IEnumerator<YTAMKWOJLST> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract XEXLSJPFYXK IEPBFOFACHA(FRNFKJLNSJK a, IEnumerator<YTAMKWOJLST> b);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8D215E0", Offset = "0x8D1FDE0", VA = "0x188D215E0", Slot = "21")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8D20D10", Offset = "0x8D1F510", VA = "0x188D20D10", Slot = "9")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8D219B0", Offset = "0x8D201B0", VA = "0x188D219B0", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8D21490", Offset = "0x8D1FC90", VA = "0x188D21490")]
		private void KGHATVPMPZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8D214B0", Offset = "0x8D1FCB0", VA = "0x188D214B0")]
		private void LHMWEGETRYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8D21450", Offset = "0x8D1FC50", VA = "0x188D21450")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8D214D0", Offset = "0x8D1FCD0", VA = "0x188D214D0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8D219D0", Offset = "0x8D201D0", VA = "0x188D219D0")]
		private void VFGHBOGDWIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8D213C0", Offset = "0x8D1FBC0", VA = "0x188D213C0")]
		private void EBSQVGPACHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8D21470", Offset = "0x8D1FC70", VA = "0x188D21470")]
		private void ITGEIBOBXSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8D20C20", Offset = "0x8D1F420", VA = "0x188D20C20", Slot = "23")]
		public virtual void COLVPAIDAPX(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8D20A50", Offset = "0x8D1F250", VA = "0x188D20A50")]
		private void AZZNEZFWWTO(OCPCLGCDWRN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x275C1E0", Offset = "0x275A9E0", VA = "0x18275C1E0")]
		private OCPCLGCDWRN NCAVRANEEGE(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "24")]
		internal abstract LFKOBMJBINI ZTQAGQTDBAW(IEnumerator<YTAMKWOJLST> a, Behaviour b, DKLTLVPTWAB c);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "25")]
		internal abstract OCPCLGCDWRN CTBZAYHWBBJ(ScheduleQueueType a);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8D21040", Offset = "0x8D1F840", VA = "0x188D21040", Slot = "26")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8D20CB0", Offset = "0x8D1F4B0", VA = "0x188D20CB0", Slot = "15")]
		public YTAMKWOJLST COZSVWMOSHZ(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8D21930", Offset = "0x8D20130", VA = "0x188D21930", Slot = "16")]
		public YTAMKWOJLST TYNZDYVVWBA(float a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8D20F50", Offset = "0x8D1F750", VA = "0x188D20F50", Slot = "17")]
		public XEXLSJPFYXK DFSMWGCJRER(float a, ScheduleQueueType b = ScheduleQueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8D214F0", Offset = "0x8D1FCF0", VA = "0x188D214F0", Slot = "18")]
		public YTAMKWOJLST QYCCHFSBLDD(Func<bool> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal sealed class LFKOBMJBINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly DKLTLVPTWAB UAIIZOLEBCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly RCLIIGYRNCC ZJYUDPTNQRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly bool GAMGVSJPGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private string PLLGHUJCWXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private StackTrace QPTXPQYQEMG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerator<YTAMKWOJLST> ZHYHYYYLIYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public YTAMKWOJLST CJGREXYJQDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool TQBXSXAKKEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C9C0", Offset = "0x8D1B1C0", VA = "0x188D1C9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool VIRMPAWEOWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB6CA30", Offset = "0xB6B230", VA = "0x180B6CA30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xBB7E80", Offset = "0xBB6680", VA = "0x180BB7E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C350", Offset = "0x8D1AB50", VA = "0x188D1C350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float IYMVEWIKZSS
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xC63F80", Offset = "0xC62780", VA = "0x180C63F80")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xC63F90", Offset = "0xC62790", VA = "0x180C63F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8D1CA40", Offset = "0x8D1B240", VA = "0x188D1CA40")]
		public LFKOBMJBINI(IEnumerator<YTAMKWOJLST> a, RCLIIGYRNCC b, DKLTLVPTWAB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8D1C550", Offset = "0x8D1AD50", VA = "0x188D1C550")]
		public YTAMKWOJLST OUBCIUKUNYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1C870", Offset = "0x8D1B070", VA = "0x188D1C870")]
		public bool SEITWWMGGGT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D1C500", Offset = "0x8D1AD00", VA = "0x188D1C500")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D1C8E0", Offset = "0x8D1B0E0", VA = "0x188D1C8E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xC69700", Offset = "0xC67F00", VA = "0x180C69700")]
		[CompilerGenerated]
		private void EUUTBIMIWKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class DKLTLVPTWAB : DKIBBYYTMUS, XEXLSJPFYXK, IHSGGRZWIQF, DNXWICJZUNF, IEnumerator, YTAMKWOJLST, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private ScheduleQueueType IFFGMRHKBIX;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private ScheduleQueueType CCBQXZQGPJK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xDF7610", Offset = "0xDF5E10", VA = "0x180DF7610", Slot = "23")]
			get
			{
				return default(ScheduleQueueType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ScheduleQueueType XOQALWFTSJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xDF7800", Offset = "0xDF6000", VA = "0x180DF7800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private float CTIVUWPVHYK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xAEE860", Offset = "0xAED060", VA = "0x180AEE860", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool HXQEXYTOCEN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D19DC0", Offset = "0x8D185C0", VA = "0x188D19DC0", Slot = "24")]
		private bool HEPZODGKGKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D19DB0", Offset = "0x8D185B0", VA = "0x188D19DB0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D19DE0", Offset = "0x8D185E0", VA = "0x188D19DE0")]
		public DKLTLVPTWAB()
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
	internal sealed class OCPCLGCDWRN : IDisposable
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
			public List<LFKOBMJBINI> Coroutines;
		}

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static readonly SubQueue[] CKJETWUQXXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ScheduleQueueType LFURNCIKTKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private bool RKWLZXEFOVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly LFKOBMJBINI[] PERGRWZWSUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly List<LFKOBMJBINI> GGXPLLIVMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly Stack<int> UDRZTSEETLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<LFKOBMJBINI> ASBLRXTONPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Stack<int> GEOTJMYCPPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly EQPABMEAVZV BYYOUTZBAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private bool JISGXLDLPAP;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ReinsertBuffer[,] YSKLCLKNMWS
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E6D0", Offset = "0x8D1CED0", VA = "0x188D1E6D0")]
		public OCPCLGCDWRN(ScheduleQueueType a, EQPABMEAVZV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D4E0", Offset = "0x8D1BCE0", VA = "0x188D1D4E0")]
		public void FKMKTNZKQVK(LFKOBMJBINI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DBC0", Offset = "0x8D1C3C0", VA = "0x188D1DBC0")]
		public void OHYDVSEBIOM(IList<LFKOBMJBINI> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E020", Offset = "0x8D1C820", VA = "0x188D1E020")]
		public void TFPQYDNOCWS(IList<LFKOBMJBINI> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D5A0", Offset = "0x8D1BDA0", VA = "0x188D1D5A0")]
		private void HZFDTMVRUAZ(LFKOBMJBINI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DEA0", Offset = "0x8D1C6A0", VA = "0x188D1DEA0")]
		private void QIESFJDJZIZ(IList<LFKOBMJBINI> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D1DA50", Offset = "0x8D1C250", VA = "0x188D1DA50")]
		private TickResult KFYHVLMGUSI(LFKOBMJBINI a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E300", Offset = "0x8D1CB00", VA = "0x188D1E300")]
		public void Update(float currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D1D0", Offset = "0x8D1B9D0", VA = "0x188D1D1D0")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D6F0", Offset = "0x8D1BEF0", VA = "0x188D1D6F0")]
		private void ILOAKXHYWPS(List<LFKOBMJBINI> a, Stack<int> b, bool c, float d = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D1D3C0", Offset = "0x8D1BBC0", VA = "0x188D1D3C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D1E470", Offset = "0x8D1CC70", VA = "0x188D1E470")]
		private void WMQYSJCTSHK(List<LFKOBMJBINI> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class MGPSTIKWIKR : EQPABMEAVZV
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "4")]
		public void CMKCAWPRFLU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public void QBEXEMQDFTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public MGPSTIKWIKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class NWRQKRKAWME : RCLIIGYRNCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly Behaviour JWIRPHXUYDI;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D100", Offset = "0x8D1B900", VA = "0x188D1D100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool BNNDFGNXEUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D180", Offset = "0x8D1B980", VA = "0x188D1D180", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool YNYVGUCJUYH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8D1D0E0", Offset = "0x8D1B8E0", VA = "0x188D1D0E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public NWRQKRKAWME(Behaviour a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__266003199
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8D29820", Offset = "0x8D28020", VA = "0x188D29820")]
	public static void JTEJSBRAGJR()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8D29810", Offset = "0x8D28010", VA = "0x188D29810")]
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
