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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9070F30", Offset = "0x906FD30", VA = "0x189070F30", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x907D080", Offset = "0x907BE80", VA = "0x18907D080", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
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
			private sealed class CEXFFSBJGFA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public YNPTGWGMAGI.WrapperKey NFCNRPBPDKW;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public CEXFFSBJGFA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x906BE20", Offset = "0x906AC20", VA = "0x18906BE20")]
				internal void TECPRAHOBSI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static IDisposable frameScope;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9079A30", Offset = "0x9078830", VA = "0x189079A30")]
			public static PlayerLoopSystem UAXVCGGSJIA(YNPTGWGMAGI.WrapperKey a)
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
			private sealed class WRZXCNXOEJD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public YNPTGWGMAGI.WrapperKey NFCNRPBPDKW;

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public WRZXCNXOEJD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x9079660", Offset = "0x9078460", VA = "0x189079660")]
				internal void TECPRAHOBSI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9079910", Offset = "0x9078710", VA = "0x189079910")]
			public static PlayerLoopSystem UAXVCGGSJIA(YNPTGWGMAGI.WrapperKey a)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x906C090", Offset = "0x906AE90", VA = "0x18906C090")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x906CE60", Offset = "0x906BC60", VA = "0x18906CE60")]
		private static void GPDSCXRWSZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x906CC90", Offset = "0x906BA90", VA = "0x18906CC90")]
		private static void DXJEUJOFGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x906CF50", Offset = "0x906BD50", VA = "0x18906CF50")]
		private static void JDNKRJFGNZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x906C110", Offset = "0x906AF10", VA = "0x18906C110")]
		private static void BIFZCBSRCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3616080", Offset = "0x3614E80", VA = "0x183616080")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x906CEB0", Offset = "0x906BCB0", VA = "0x18906CEB0")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3616080", Offset = "0x3614E80", VA = "0x183616080")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37A11C0", Offset = "0x379FFC0", VA = "0x1837A11C0")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) TNRPIYSYLZJ<a, b>(YNPTGWGMAGI.WrapperKey a)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x906D3B0", Offset = "0x906C1B0", VA = "0x18906D3B0")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) TNRPIYSYLZJ(YNPTGWGMAGI.WrapperKey a, Type b, Type c)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class YNPTGWGMAGI
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
		public class MGBBLNVOJES
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly WrapperKey IMFTNNKGQXP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public readonly OJXHRRTGSDC TWXQRUGYDAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private long AMNAZPQTOWR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private long HVCKBRZUSRM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public long ULGTLNWNHOV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int DPCPQBNYVMU;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9071100", Offset = "0x906FF00", VA = "0x189071100")]
			public MGBBLNVOJES(WrapperKey a, int b = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9070FB0", Offset = "0x906FDB0", VA = "0x189070FB0")]
			public void HRVFHEATIEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9070FD0", Offset = "0x906FDD0", VA = "0x189070FD0")]
			public void NKGJEXYTBPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9071020", Offset = "0x906FE20", VA = "0x189071020")]
			public void PZPAKHCUOKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static WrapperKey[] TEYBSVEGSYK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static MGBBLNVOJES[] XMHQHKWNSMI;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9079B50", Offset = "0x9078950", VA = "0x189079B50")]
		public static MGBBLNVOJES FJXPTAYHTLE(WrapperKey a, int b = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9079D30", Offset = "0x9078B30", VA = "0x189079D30")]
		public static MGBBLNVOJES WXEXIFEHWNW(WrapperKey a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9079C90", Offset = "0x9078A90", VA = "0x189079C90")]
		public static void TAZJUEXPITP()
		{
		}
	}
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class OVDYNMSIRBN
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private interface JWSPJFTANSJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			bool VTTJTEIGKOO
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
		private class OROTQITUYAD : JWSPJFTANSJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private readonly Action EPDNLWJBQOJ;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool VTTJTEIGKOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
			public OROTQITUYAD(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x133F600", Offset = "0x133E400", VA = "0x18133F600", Slot = "5")]
			public void Complete()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly List<JWSPJFTANSJ> HVKAJTGGLWE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool NNUJYZTGGFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9075A10", Offset = "0x9074810", VA = "0x189075A10")]
		public static void XYQHOEDLXBO(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9075AA0", Offset = "0x90748A0", VA = "0x189075AA0")]
		private static void ZKQJRCYTDLK(JWSPJFTANSJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x90755F0", Offset = "0x90743F0", VA = "0x1890755F0")]
		private static void FSGWSRSNDRX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x90758D0", Offset = "0x90746D0", VA = "0x1890758D0")]
		private static void UBYLDSMAZJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x90754E0", Offset = "0x90742E0", VA = "0x1890754E0")]
		private static void DQYFLFWUGTN()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class RWHWMOKFUSY
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x90779D0", Offset = "0x90767D0", VA = "0x1890779D0")]
		public static IDisposable UUZFZWOVHML(this SAMRDZOWKNO a, float b, Action<float> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x90778D0", Offset = "0x90766D0", VA = "0x1890778D0")]
		public static IDisposable EOOOUPCHMNJ(this SAMRDZOWKNO a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9077950", Offset = "0x9076750", VA = "0x189077950")]
		public static IDisposable PUAONJVOORT(this SAMRDZOWKNO a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class TARAMMQVTLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F220", Offset = "0x3D2E020", VA = "0x183D2F220")]
		[MustUseReturnValue]
		public static IDisposable EPMRXZSFYEX<a>(this a a, Action b, ScheduleQueueType c, bool d = true) where a : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F080", Offset = "0x3D2DE80", VA = "0x183D2F080")]
		[MustUseReturnValue]
		public static IDisposable EPMRXZSFYEX<b>(this b a, Action<float> b, ScheduleQueueType c, bool d = true) where b : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F8C0", Offset = "0x3D2E6C0", VA = "0x183D2F8C0")]
		[MustUseReturnValue]
		public static IDisposable Update<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F530", Offset = "0x3D2E330", VA = "0x183D2F530")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F5A0", Offset = "0x3D2E3A0", VA = "0x183D2F5A0")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action<float> update, bool validateContext = true) where T : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F7D0", Offset = "0x3D2E5D0", VA = "0x183D2F7D0")]
		[MustUseReturnValue]
		public static IDisposable LateUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F3C0", Offset = "0x3D2E1C0", VA = "0x183D2F3C0")]
		[MustUseReturnValue]
		public static IDisposable FIFRBTHXPZA<c>(this c a, Action b, bool c = true) where c : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F9B0", Offset = "0x3D2E7B0", VA = "0x183D2F9B0")]
		[MustUseReturnValue]
		public static IDisposable YGLLJZEHMCF<d>(this d a, Action b, bool c = true) where d : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2ED10", Offset = "0x3D2DB10", VA = "0x183D2ED10")]
		[MustUseReturnValue]
		public static IDisposable AUXIZXREHDG<f>(this f a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where f : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9078A30", Offset = "0x9077830", VA = "0x189078A30")]
		[MustUseReturnValue]
		public static IDisposable AUXIZXREHDG(this MonoBehaviour a, YFIQJDPXTBF b, float c, Action<float> d, ScheduleQueueType e, bool f = true, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EED0", Offset = "0x3D2DCD0", VA = "0x183D2EED0")]
		[MustUseReturnValue]
		public static IDisposable EKCYNBKUUFA<g>(this g a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where g : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F430", Offset = "0x3D2E230", VA = "0x183D2F430")]
		[MustUseReturnValue]
		public static IDisposable FRWGVXLREYR<h>(this h a, float b, Action<float> c, bool d = true, bool e = true) where h : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3D2ED50", Offset = "0x3D2DB50", VA = "0x183D2ED50")]
		[MustUseReturnValue]
		public static IDisposable BIWVZHKAIBM<i>(this i a, Action<float> b, bool c = true, bool d = true) where i : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EC90", Offset = "0x3D2DA90", VA = "0x183D2EC90")]
		[MustUseReturnValue]
		public static IDisposable ARSZVEHSOLJ<j>(this j a, Action<float> b, bool c = true, bool d = true) where j : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F750", Offset = "0x3D2E550", VA = "0x183D2F750")]
		[MustUseReturnValue]
		public static IDisposable KUCMUDCLOQW<k>(this k a, Action<float> b, bool c = true, bool d = true) where k : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F4B0", Offset = "0x3D2E2B0", VA = "0x183D2F4B0")]
		[MustUseReturnValue]
		public static IDisposable FZIQATKFAAV<l>(this l a, Action<float> b, bool c = true, bool d = true) where l : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F840", Offset = "0x3D2E640", VA = "0x183D2F840")]
		[MustUseReturnValue]
		public static IDisposable TPBJLGRPFVN<m>(this m a, Action<float> b, bool c = true, bool d = true) where m : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F930", Offset = "0x3D2E730", VA = "0x183D2F930")]
		[MustUseReturnValue]
		public static IDisposable VGNEFHDIRVR<n>(this n a, Action<float> b, bool c = true, bool d = true) where n : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EC10", Offset = "0x3D2DA10", VA = "0x183D2EC10")]
		[MustUseReturnValue]
		public static IDisposable ALCMYXXEBEN<q>(this q a, Action<float> b, bool c = true, bool d = true) where q : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EE50", Offset = "0x3D2DC50", VA = "0x183D2EE50")]
		[MustUseReturnValue]
		public static IDisposable DXBTDLYPFPD<s>(this s a, float b, Action<float> c, bool d = true, bool e = true) where s : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EDD0", Offset = "0x3D2DBD0", VA = "0x183D2EDD0")]
		[MustUseReturnValue]
		public static IDisposable BRMYWAIQXGJ<u>(this u a, Action<float> b, bool c = true, bool d = true) where u : MonoBehaviour, YFIQJDPXTBF
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class MYIOPGKDBNF
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class KGOEUOUIVYE : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ScheduleQueueType LBWVEQYHYDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Action BHFFJDOOGUW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private YSMRVGGAPSA WWUTYZIVWQL;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public KGOEUOUIVYE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x906F2A0", Offset = "0x906E0A0", VA = "0x18906F2A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x906F260", Offset = "0x906E060", VA = "0x18906F260", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class KGTLRVOGFJN : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public ScheduleQueueType LBWVEQYHYDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Action<float> BHFFJDOOGUW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private YSMRVGGAPSA WWUTYZIVWQL;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public KGTLRVOGFJN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x906F3B0", Offset = "0x906E1B0", VA = "0x18906F3B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x906F370", Offset = "0x906E170", VA = "0x18906F370", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9072A00", Offset = "0x9071800", VA = "0x189072A00")]
		public static DLHIAPQRHVO EPMRXZSFYEX(Action a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9072970", Offset = "0x9071770", VA = "0x189072970")]
		public static DLHIAPQRHVO EPMRXZSFYEX(Behaviour a, Action b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9072890", Offset = "0x9071690", VA = "0x189072890")]
		public static DLHIAPQRHVO EPMRXZSFYEX(Behaviour a, Action<float> b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9072B00", Offset = "0x9071900", VA = "0x189072B00")]
		[IteratorStateMachine(typeof(KGOEUOUIVYE))]
		private static IEnumerator<IMKAVQMVTAL> XKKMHXXLEDK(ScheduleQueueType a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9072A80", Offset = "0x9071880", VA = "0x189072A80")]
		[IteratorStateMachine(typeof(KGTLRVOGFJN))]
		private static IEnumerator<IMKAVQMVTAL> XKKMHXXLEDK(ScheduleQueueType a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class GWAZYTCGQWG : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MORHJBFZHLZ : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public GWAZYTCGQWG WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public MORHJBFZHLZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9071520", Offset = "0x9070320", VA = "0x189071520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x90714E0", Offset = "0x90702E0", VA = "0x1890714E0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ScheduleQueueType CALTPJHTDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Action QUQEWZOSVAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool TFJENLKMKXW;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ZGWVPPYLWBK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xAC0160", VA = "0x180AC1360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x906E210", Offset = "0x906D010", VA = "0x18906E210")]
		public GWAZYTCGQWG(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x906E100", Offset = "0x906CF00", VA = "0x18906E100")]
		[IteratorStateMachine(typeof(MORHJBFZHLZ))]
		private IEnumerator<IMKAVQMVTAL> CKDVPXUFVQL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x906E170", Offset = "0x906CF70", VA = "0x18906E170", Slot = "4")]
		public void OnCompleted(Action continuation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public void BPZXAXKNMSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class UVSEDERAHIT
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9078F00", Offset = "0x9077D00", VA = "0x189078F00")]
		public static GWAZYTCGQWG RMUULWGIHOS(this ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class UZHNLKFDSDR
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class PDIHYLAZUYE : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public ACZEHNVHTDS GXJWGLVPGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Action<float> BHFFJDOOGUW;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public PDIHYLAZUYE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9075E20", Offset = "0x9074C20", VA = "0x189075E20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9075DE0", Offset = "0x9074BE0", VA = "0x189075DE0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9079000", Offset = "0x9077E00", VA = "0x189079000")]
		public static DLHIAPQRHVO EPMRXZSFYEX(float a, Action<float> b, ScheduleQueueType c, bool d = true, [Optional] TQPUKRRDZNZ e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x90790D0", Offset = "0x9077ED0", VA = "0x1890790D0")]
		public static DLHIAPQRHVO EPMRXZSFYEX(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] TQPUKRRDZNZ f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x90791A0", Offset = "0x9077FA0", VA = "0x1890791A0")]
		public static DLHIAPQRHVO FLRDPBPVCFB(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] TQPUKRRDZNZ f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9079290", Offset = "0x9078090", VA = "0x189079290")]
		public static DLHIAPQRHVO GOFYBHDJDMF(SAMRDZOWKNO a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] TQPUKRRDZNZ f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x90793C0", Offset = "0x90781C0", VA = "0x1890793C0")]
		private static IEnumerator<IMKAVQMVTAL> XKKMHXXLEDK(BHTOMZEUOYU a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9079360", Offset = "0x9078160", VA = "0x189079360")]
		private static IEnumerator<IMKAVQMVTAL> SOUUCGIEJZC(BHTOMZEUOYU a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9079470", Offset = "0x9078270", VA = "0x189079470")]
		[IteratorStateMachine(typeof(PDIHYLAZUYE))]
		private static IEnumerator<IMKAVQMVTAL> YTTPEHRHIQY(ACZEHNVHTDS a, float b, ScheduleQueueType c, Action<float> d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class VIUCIKKLWKR
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BWTLKQZAFGN : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public ScheduleQueueType CALTPJHTDPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public Func<bool> ECAVBJRPDDO;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public BWTLKQZAFGN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x906BC60", Offset = "0x906AA60", VA = "0x18906BC60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x906BC20", Offset = "0x906AA20", VA = "0x18906BC20", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x90795E0", Offset = "0x90783E0", VA = "0x1890795E0")]
		[IteratorStateMachine(typeof(BWTLKQZAFGN))]
		private static IEnumerator<IMKAVQMVTAL> VXFHATDRDSB(ScheduleQueueType a, Func<bool> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9079500", Offset = "0x9078300", VA = "0x189079500")]
		public static DLHIAPQRHVO LWCFVQDQICC(this MonoBehaviour a, Func<bool> b, ScheduleQueueType c = ScheduleQueueType.Update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class SBUQAGBAKJU
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class MPMIYCHOTFJ : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float WWQSBBONECY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public ScheduleQueueType LBWVEQYHYDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action HTYFBWMGLPV;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public MPMIYCHOTFJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x90715F0", Offset = "0x90703F0", VA = "0x1890715F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x90715B0", Offset = "0x90703B0", VA = "0x1890715B0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class AVVZZZGYRJZ<a> : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float WWQSBBONECY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public ScheduleQueueType LBWVEQYHYDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Action<a> HTYFBWMGLPV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public a GRDMTIYKAWJ;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public AVVZZZGYRJZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5689940", Offset = "0x5688740", VA = "0x185689940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class QDHXGNPDFVN : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float WWQSBBONECY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ScheduleQueueType LBWVEQYHYDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Action HTYFBWMGLPV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private IMKAVQMVTAL JFVWXSNLHQL;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public QDHXGNPDFVN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9075F10", Offset = "0x9074D10", VA = "0x189075F10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9075ED0", Offset = "0x9074CD0", VA = "0x189075ED0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9077DA0", Offset = "0x9076BA0", VA = "0x189077DA0")]
		[IteratorStateMachine(typeof(MPMIYCHOTFJ))]
		private static IEnumerator<IMKAVQMVTAL> CKDVPXUFVQL(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5AE0", Offset = "0x3CE48E0", VA = "0x183CE5AE0")]
		[IteratorStateMachine(typeof(AVVZZZGYRJZ<>))]
		private static IEnumerator<IMKAVQMVTAL> CKDVPXUFVQL<a>(float a, ScheduleQueueType b, Action<a> c, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9077D10", Offset = "0x9076B10", VA = "0x189077D10")]
		[IteratorStateMachine(typeof(QDHXGNPDFVN))]
		private static IEnumerator<IMKAVQMVTAL> CFVIWBXOMWN(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9078230", Offset = "0x9077030", VA = "0x189078230")]
		public static IDisposable QVOGDESNXIN(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9078010", Offset = "0x9076E10", VA = "0x189078010")]
		public static DLHIAPQRHVO HYMLGQNGUVH(this MonoBehaviour a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9078140", Offset = "0x9076F40", VA = "0x189078140")]
		public static DLHIAPQRHVO QVOGDESNXIN(this MonoBehaviour a, float b, ScheduleQueueType c, Action d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9077BD0", Offset = "0x90769D0", VA = "0x189077BD0")]
		public static DLHIAPQRHVO BPVYTVJGSNV(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3CE57E0", Offset = "0x3CE45E0", VA = "0x183CE57E0")]
		public static DLHIAPQRHVO BPVYTVJGSNV<b>(this MonoBehaviour a, Action<b> b, b c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9077E30", Offset = "0x9076C30", VA = "0x189077E30")]
		public static DLHIAPQRHVO CXNEMXPBUPT(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x90780A0", Offset = "0x9076EA0", VA = "0x1890780A0")]
		public static DLHIAPQRHVO QVJECWQDGLF(this MonoBehaviour a, Action b, [Optional] TQPUKRRDZNZ c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9077F70", Offset = "0x9076D70", VA = "0x189077F70")]
		public static DLHIAPQRHVO HJHATLJEQFR(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9077ED0", Offset = "0x9076CD0", VA = "0x189077ED0")]
		public static DLHIAPQRHVO FUYUDTRQXXV(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9078450", Offset = "0x9077250", VA = "0x189078450")]
		public static DLHIAPQRHVO XAVWXCGSNLR(MonoBehaviour a, ScheduleQueueType b, Action c, [Optional] TQPUKRRDZNZ d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5D30", Offset = "0x3CE4B30", VA = "0x183CE5D30")]
		public static DLHIAPQRHVO XAVWXCGSNLR<h>(MonoBehaviour a, ScheduleQueueType b, Action<h> c, h d, [Optional] TQPUKRRDZNZ e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9077B40", Offset = "0x9076940", VA = "0x189077B40")]
		public static DLHIAPQRHVO BNCHPTDHJWF(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x90783B0", Offset = "0x90771B0", VA = "0x1890783B0")]
		public static DLHIAPQRHVO VYOAXSOKKNX(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9077C70", Offset = "0x9076A70", VA = "0x189077C70")]
		public static DLHIAPQRHVO BVSKUXSYDOJ(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9078310", Offset = "0x9077110", VA = "0x189078310")]
		public static DLHIAPQRHVO TZBLLVLQRXT(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class MSJQOUACNKQ : DYLDWGCQIJO, IEnumerable<DYLDWGCQIJO>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly List<DYLDWGCQIJO> ULSFAIVTWKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool FXHCHNYPMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Action VIJDPXQBJWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool FFFLGDFOODC;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool GLLELUSLNZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9071CA0", Offset = "0x9070AA0", VA = "0x189071CA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LWMFRBOXXAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9071C00", Offset = "0x9070A00", VA = "0x189071C00", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9071B60", Offset = "0x9070960", VA = "0x189071B60", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9071F10", Offset = "0x9070D10", VA = "0x189071F10")]
		public MSJQOUACNKQ([Optional] Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9071660", Offset = "0x9070460", VA = "0x189071660")]
		public void Add(DYLDWGCQIJO limiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9071DC0", Offset = "0x9070BC0", VA = "0x189071DC0")]
		private void XZRSSZGTHPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9071860", Offset = "0x9070660", VA = "0x189071860", Slot = "7")]
		public bool KATHSRHTFXG(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9071870", Offset = "0x9070670", VA = "0x189071870", Slot = "8")]
		public bool KATHSRHTFXG(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x90717E0", Offset = "0x90705E0", VA = "0x1890717E0", Slot = "9")]
		public IEnumerator<DYLDWGCQIJO> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x90717E0", Offset = "0x90705E0", VA = "0x1890717E0", Slot = "10")]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class MMHIRRIHCPI : ARAYKMXHKWK
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class URZEQUFXAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public MMHIRRIHCPI WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Action EPDNLWJBQOJ;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public URZEQUFXAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9078ED0", Offset = "0x9077CD0", VA = "0x189078ED0")]
			internal void TRVGFBHEQNY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class ZLLAWYXLGFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public MMHIRRIHCPI WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action EPDNLWJBQOJ;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZLLAWYXLGFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9078ED0", Offset = "0x9077CD0", VA = "0x189078ED0")]
			internal void SCGYTTUXQIX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly float HDNAFIVQGVN;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x90713A0", Offset = "0x90701A0", VA = "0x1890713A0")]
		public MMHIRRIHCPI(Behaviour a, float b, [Optional] Action c, [Optional] TQPUKRRDZNZ d, [Optional] BHTOMZEUOYU e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9071180", Offset = "0x906FF80", VA = "0x189071180", Slot = "9")]
		protected override bool KGEUEDFTVOS(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9071290", Offset = "0x9070090", VA = "0x189071290", Slot = "10")]
		protected override bool KKHPSQXNVKJ(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface DYLDWGCQIJO
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool GLLELUSLNZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action LWMFRBOXXAM;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KATHSRHTFXG(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KATHSRHTFXG(Action a, bool b = false);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class ARAYKMXHKWK : DYLDWGCQIJO
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class CCBUNLTNLMB : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public ARAYKMXHKWK WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float WATRWENWGNZ;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public CCBUNLTNLMB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x906BD50", Offset = "0x906AB50", VA = "0x18906BD50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x906BD10", Offset = "0x906AB10", VA = "0x18906BD10", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly Behaviour ADKEKNLASFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action VIJDPXQBJWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private SGMUANPBQKN KAVUGBOVSML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly TQPUKRRDZNZ LDPTRROTLSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected readonly BHTOMZEUOYU TKZRNOFRIPP;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GLLELUSLNZS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xE2C170", Offset = "0xE2AF70", VA = "0x180E2C170", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action LWMFRBOXXAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x906B9D0", Offset = "0x906A7D0", VA = "0x18906B9D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x906B930", Offset = "0x906A730", VA = "0x18906B930", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x906BA70", Offset = "0x906A870", VA = "0x18906BA70")]
		protected ARAYKMXHKWK(Behaviour a, [Optional] Action b, [Optional] TQPUKRRDZNZ c, [Optional] BHTOMZEUOYU d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x906B5C0", Offset = "0x906A3C0", VA = "0x18906B5C0", Slot = "7")]
		public bool KATHSRHTFXG(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x906B560", Offset = "0x906A360", VA = "0x18906B560", Slot = "8")]
		public bool KATHSRHTFXG(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool KGEUEDFTVOS(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool KKHPSQXNVKJ(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x906B910", Offset = "0x906A710", VA = "0x18906B910")]
		protected void QGFGVKKEVAJ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x906B620", Offset = "0x906A420", VA = "0x18906B620")]
		protected WGVXBSAEBCD KHFUPRAGSFF(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x906B890", Offset = "0x906A690", VA = "0x18906B890")]
		private void OMBUNXAUDRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x906B4E0", Offset = "0x906A2E0", VA = "0x18906B4E0")]
		[IteratorStateMachine(typeof(CCBUNLTNLMB))]
		private IEnumerator<IMKAVQMVTAL> DIMWWMLLIFQ(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x906B850", Offset = "0x906A650", VA = "0x18906B850")]
		[CompilerGenerated]
		private void LBXPEZNMRUD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RVIPZLOSCRF : ARAYKMXHKWK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly float GUTIEFRUNRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int UAOXEYPEIBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly float SBBQQJAJNTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly float[] DJKHTEAUAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int HDKSHSOINOK;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9077700", Offset = "0x9076500", VA = "0x189077700")]
		public RVIPZLOSCRF(Behaviour a, float b, int c, [Optional] Action d, float e = 0f, [Optional] TQPUKRRDZNZ f, [Optional] BHTOMZEUOYU g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "9")]
		protected override bool KGEUEDFTVOS(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9077480", Offset = "0x9076280", VA = "0x189077480", Slot = "10")]
		protected override bool KKHPSQXNVKJ(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9077680", Offset = "0x9076480", VA = "0x189077680")]
		private void KMOYXSFOVBO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class MYDGWKWFSTF : ARAYKMXHKWK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly float HDNAFIVQGVN;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x90713A0", Offset = "0x90701A0", VA = "0x1890713A0")]
		public MYDGWKWFSTF(Behaviour a, float b, [Optional] Action c, [Optional] TQPUKRRDZNZ d, [Optional] BHTOMZEUOYU e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "9")]
		protected override bool KGEUEDFTVOS(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9072850", Offset = "0x9071650", VA = "0x189072850", Slot = "10")]
		protected override bool KKHPSQXNVKJ(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class ZAWOYQOUPGB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class FDWAAPTUWKL : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public Action AIWQKDAEOCP;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public FDWAAPTUWKL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x906E050", Offset = "0x906CE50", VA = "0x18906E050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x906E0C0", Offset = "0x906CEC0", VA = "0x18906E0C0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private DLHIAPQRHVO FMOYZNSLNZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private SAMRDZOWKNO ADKEKNLASFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private Action<float> YREXHPEKFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private ScheduleQueueType CALTPJHTDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private float TEYSBPANOAQ;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x907B4D0", Offset = "0x907A2D0", VA = "0x18907B4D0")]
		public ZAWOYQOUPGB(SAMRDZOWKNO a, float b, Action<float> c, ScheduleQueueType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x907B370", Offset = "0x907A170", VA = "0x18907B370")]
		private void ZGXXHPKKZFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x907B070", Offset = "0x9079E70", VA = "0x18907B070")]
		private void FOYRZZBESWB(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x907B190", Offset = "0x9079F90", VA = "0x18907B190")]
		[IteratorStateMachine(typeof(FDWAAPTUWKL))]
		private IEnumerator<IMKAVQMVTAL> TIKNUQYIKHH(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x907B010", Offset = "0x9079E10", VA = "0x18907B010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x907B200", Offset = "0x907A000", VA = "0x18907B200")]
		[CompilerGenerated]
		private void XFYTBMHFPJO(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class YYUSVNPEVIL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class FCLDTUKNIJA : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Action AIWQKDAEOCP;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public FCLDTUKNIJA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x906E050", Offset = "0x906CE50", VA = "0x18906E050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x906E010", Offset = "0x906CE10", VA = "0x18906E010", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private DLHIAPQRHVO FMOYZNSLNZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private MonoBehaviour IRBBZLGLRLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Action BHFFJDOOGUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Action<float> YREXHPEKFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private ScheduleQueueType CALTPJHTDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private float TEYSBPANOAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool ICGSVEYJAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly TQPUKRRDZNZ LDPTRROTLSU;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x907ACB0", Offset = "0x9079AB0", VA = "0x18907ACB0")]
		public YYUSVNPEVIL(MonoBehaviour a, Action b, ScheduleQueueType c, [Optional] TQPUKRRDZNZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x907AAF0", Offset = "0x90798F0", VA = "0x18907AAF0")]
		public YYUSVNPEVIL(MonoBehaviour a, Action<float> b, ScheduleQueueType c, [Optional] TQPUKRRDZNZ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x907AE30", Offset = "0x9079C30", VA = "0x18907AE30")]
		public YYUSVNPEVIL(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] TQPUKRRDZNZ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xF2E420", Offset = "0xF2D220", VA = "0x180F2E420")]
		private YYUSVNPEVIL(TQPUKRRDZNZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x907A8D0", Offset = "0x90796D0", VA = "0x18907A8D0")]
		internal static YYUSVNPEVIL ZNQQWSAJMDD(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] TQPUKRRDZNZ f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x907A000", Offset = "0x9078E00", VA = "0x18907A000")]
		private void EPMRXZSFYEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x907A470", Offset = "0x9079270", VA = "0x18907A470")]
		private void WKUMTLGCENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x907A760", Offset = "0x9079560", VA = "0x18907A760")]
		private void ZGXXHPKKZFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x907A5E0", Offset = "0x90793E0", VA = "0x18907A5E0")]
		private void WNEAHNQDEFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x907A130", Offset = "0x9078F30", VA = "0x18907A130")]
		private void FOYRZZBESWB(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x907A400", Offset = "0x9079200", VA = "0x18907A400")]
		[IteratorStateMachine(typeof(FCLDTUKNIJA))]
		private IEnumerator<IMKAVQMVTAL> TIKNUQYIKHH(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9079FA0", Offset = "0x9078DA0", VA = "0x189079FA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x907A370", Offset = "0x9079170", VA = "0x18907A370")]
		[CompilerGenerated]
		private void NXPZNWAQSJC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x907A2E0", Offset = "0x90790E0", VA = "0x18907A2E0")]
		[CompilerGenerated]
		private void MWVEZZIFBCT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x907A250", Offset = "0x9079050", VA = "0x18907A250")]
		[CompilerGenerated]
		private void JFATXAQCUWE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9079F10", Offset = "0x9078D10", VA = "0x189079F10")]
		[CompilerGenerated]
		private void DEAUWLPQLDP(string a)
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
	internal sealed class EYLPYAHFCUS : BHTOMZEUOYU
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float DIHMSZUWUBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x906DF60", Offset = "0x906CD60", VA = "0x18906DF60", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float GLTPWQWSTBY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x906DF70", Offset = "0x906CD70", VA = "0x18906DF70", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public double DFBNQKMZLER
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x906DFF0", Offset = "0x906CDF0", VA = "0x18906DFF0", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x906DF80", Offset = "0x906CD80", VA = "0x18906DF80")]
		[FDNTPBIGLET.Root]
		internal static void NHOBNFBSGEC(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		[UnityEngine.Scripting.Preserve]
		internal EYLPYAHFCUS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal interface HLMZVHGZLMT
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UVQXAFBYVFE(string a);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QPQVIISMJGO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal interface HSTSVYBTCWS
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool VZFJAZRJIEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool WSVZFPUSALF
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal class DWIBNRUPTJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public OORXEODWUFL IHLVWRQKHAS;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int ABEZYRMIUQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x906DA90", Offset = "0x906C890", VA = "0x18906DA90")]
		public static IMKAVQMVTAL CYPNWFFDHEZ(IEnumerator<IMKAVQMVTAL> a, BJGDMAIJSKB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x906DBF0", Offset = "0x906C9F0", VA = "0x18906DBF0")]
		public IMKAVQMVTAL CYPNWFFDHEZ(BJGDMAIJSKB[] a, IEnumerator<IMKAVQMVTAL>[] b, IMKAVQMVTAL[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x906DCB0", Offset = "0x906CAB0", VA = "0x18906DCB0")]
		public void DRETHZCBMCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x906DE20", Offset = "0x906CC20", VA = "0x18906DE20")]
		public void KFCOOESYJVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x906DCE0", Offset = "0x906CAE0", VA = "0x18906DCE0")]
		public void GFXFZNBCJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x906DCB0", Offset = "0x906CAB0", VA = "0x18906DCB0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DWIBNRUPTJO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class OORXEODWUFL
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct JobbedInsertionData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public DWIBNRUPTJO Routine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public SAMRDZOWKNO Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public BJGDMAIJSKB Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public IEnumerator<IMKAVQMVTAL> Coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public IMKAVQMVTAL CurrentSchedule;

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
		private sealed class LZXPMSDOCGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public BJGDMAIJSKB VVXTPEZYXEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public OORXEODWUFL WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public SAMRDZOWKNO ADKEKNLASFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public DWIBNRUPTJO GXCOOCQUOPX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public CoroutineState XNXHSOOXHWI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public IMKAVQMVTAL XTZZUFNPGQV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public IEnumerator<IMKAVQMVTAL> MPENPONBJZR;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LZXPMSDOCGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x90707C0", Offset = "0x906F5C0", VA = "0x1890707C0")]
			internal void YDLRNTFNSKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class JCDRCVVBTGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public DWIBNRUPTJO GXJWGLVPGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public OORXEODWUFL WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public JCDRCVVBTGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x906E3D0", Offset = "0x906D1D0", VA = "0x18906E3D0")]
			internal void HCEHEDWTCDV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class DPGIZRRGRKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public DWIBNRUPTJO GXJWGLVPGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public OORXEODWUFL WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public DPGIZRRGRKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x906D590", Offset = "0x906C390", VA = "0x18906D590")]
			internal void EZBAQTMOHRL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class ZPLDCYVNNAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public DWIBNRUPTJO GXJWGLVPGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public OORXEODWUFL WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZPLDCYVNNAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x907D040", Offset = "0x907BE40", VA = "0x18907D040")]
			internal void SIJLXPODOCW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const CoroutineState YIMUWTUMJPP = CoroutineState.Cancelled | CoroutineState.Paused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ScheduleQueueType CALTPJHTDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool[] FLQHEVCYNZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private NativeArray<CoroutineState> OSEIOWSVISO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NativeArray<float> MGOWHFMQTYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private NativeArray<int> GIZVZBIQMZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private NativeArray<int> NKTURPPRPTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private NativeArray<int> IPCSFJBFRNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private NativeArray<int> MGJLXYBJQXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<int> TFBWFIQXUCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private DWIBNRUPTJO[] LWIFDHEZHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private BJGDMAIJSKB[] GPNHGVQYEDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private SAMRDZOWKNO[] GXJGYZRZSVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<IMKAVQMVTAL>[] UYDQIAELLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private IMKAVQMVTAL[] CLTVXJUYQXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int BCLZWIHWPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int JUGYBYZDXUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly int YZHHKNXULRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private float XHECKJJRPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ScheduleSortJob OTSNXUTRKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private JobHandle CVKRUEICCWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<DWIBNRUPTJO> PPXHNSXKNVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private bool CAUTBBSZNUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private List<Action> TDMEECWANWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private List<Action> HQSJFEHQETW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool NYTUELYXCQH;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JobbedReinsertBuffer[] PMJJLCJPWAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xC3C320", Offset = "0xC3B120", VA = "0x180C3C320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9073890", Offset = "0x9072690", VA = "0x189073890")]
		private static int IUWXMEYRMYT(ScheduleQueueType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9074EB0", Offset = "0x9073CB0", VA = "0x189074EB0")]
		public OORXEODWUFL(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9074CD0", Offset = "0x9073AD0", VA = "0x189074CD0")]
		private void ZBCNEDNOEDP(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9073B00", Offset = "0x9072900", VA = "0x189073B00")]
		public void NSORHUSXZBX(SAMRDZOWKNO a, IMKAVQMVTAL b, IEnumerator<IMKAVQMVTAL> c, BJGDMAIJSKB d, [Optional] DWIBNRUPTJO e, CoroutineState f = CoroutineState.Running)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x90738C0", Offset = "0x90726C0", VA = "0x1890738C0")]
		public void Insert(IEnumerable<JobbedInsertionData> insertionDatas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x90733E0", Offset = "0x90721E0", VA = "0x1890733E0")]
		private JobbedInsertionData HQOHTCZRTFU(int a)
		{
			return default(JobbedInsertionData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9072DB0", Offset = "0x9071BB0", VA = "0x189072DB0")]
		private void EFLJDMFXMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3B10C80", Offset = "0x3B0FA80", VA = "0x183B10C80")]
		private static void LAFLAUHOLYO<a>(int a, a[] b, int c, [Optional] a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3B10CD0", Offset = "0x3B0FAD0", VA = "0x183B10CD0")]
		private static void LAFLAUHOLYO<b>(int a, NativeArray<b> b, int c, [Optional] b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9073C80", Offset = "0x9072A80", VA = "0x189073C80")]
		private void NUBXOTDLRRM(IEnumerable<JobbedInsertionData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9074850", Offset = "0x9073650", VA = "0x189074850")]
		private void SNGFRPQZNOD(JobbedInsertionData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9073180", Offset = "0x9071F80", VA = "0x189073180")]
		private TickResult HKEQEROUVZE(int a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9074AD0", Offset = "0x90738D0", VA = "0x189074AD0")]
		public void YSPHBMJZZTH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9073100", Offset = "0x9071F00", VA = "0x189073100")]
		private void FHISRFSPQQX(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9074920", Offset = "0x9073720", VA = "0x189074920")]
		private void TBJZBYUGJJR(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9074140", Offset = "0x9072F40", VA = "0x189074140")]
		public void QGFGNGAEGXJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9072CB0", Offset = "0x9071AB0", VA = "0x189072CB0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9072B80", Offset = "0x9071980", VA = "0x189072B80")]
		public void Cancel(DWIBNRUPTJO schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9074010", Offset = "0x9072E10", VA = "0x189074010")]
		public void Pause(DWIBNRUPTJO schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x90749A0", Offset = "0x90737A0", VA = "0x1890749A0")]
		public void YKSZEQIXTYG(DWIBNRUPTJO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class Receipt : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly Receipt VSOKYOXGMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Action PJEXWVELIDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private bool UYCAAIVFHWU;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x86F2310", Offset = "0x86F1110", VA = "0x1886F2310", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface JVIRFXFAXKB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		a REKHREVTQMM
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable BACBTBTGNMF(UnityEngine.Object a, Action<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface GZMBLRYFRHV<a> : JVIRFXFAXKB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		new a REKHREVTQMM
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class QWQEJTASXBQ<a> : GZMBLRYFRHV<a>, JVIRFXFAXKB<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class LYLAIXIKLRH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public QWQEJTASXBQ<a> WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public Tuple<UnityEngine.Object, Action<a>> JXCSAIDHUCQ;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LYLAIXIKLRH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x55982F0", Offset = "0x55970F0", VA = "0x1855982F0")]
			internal void MQVIZITIBTV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static GameObject RJGFOLMDRTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly List<Tuple<UnityEngine.Object, Action<a>>> CIRMQGMWJVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private a QBCVCHJWVDH;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a REKHREVTQMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50", Slot = "5")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x5E416B0", Offset = "0x5E404B0", VA = "0x185E416B0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5E40B80", Offset = "0x5E3F980", VA = "0x185E40B80")]
		private static bool MZGTSGJNWFD(a a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5E419F0", Offset = "0x5E407F0", VA = "0x185E419F0")]
		public QWQEJTASXBQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5E409C0", Offset = "0x5E3F7C0", VA = "0x185E409C0", Slot = "6")]
		public IDisposable BACBTBTGNMF(UnityEngine.Object a, Action<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5E40FB0", Offset = "0x5E3FDB0", VA = "0x185E40FB0")]
		private void PFGQKMEIDAZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class JQWRDPISIBY : CICYNVXEOJB
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class DTRFHPJUDBL : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private class QAZVPKGUNHE : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				private int HPCDEAFZVKK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private DTRFHPJUDBL LBWVEQYHYDY;

				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x1088910", Offset = "0x1087710", VA = "0x181088910")]
				public QAZVPKGUNHE(int a, DTRFHPJUDBL b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0x9075EA0", Offset = "0x9074CA0", VA = "0x189075EA0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class ZRSJAVAQQNC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public int HPCDEAFZVKK;

				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
				public ZRSJAVAQQNC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xB992D0", Offset = "0xB980D0", VA = "0x180B992D0")]
				internal bool MYGSMEKEOKH(QUEVGAMHALI a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class KGDRABGODBM : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int YSBBACYODYD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private IMKAVQMVTAL QSNUDDCEMPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public DTRFHPJUDBL WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public BHTOMZEUOYU SHJHFDTVCGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private YSMRVGGAPSA WWUTYZIVWQL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private List<QUEVGAMHALI> YGJLTCBSAPT;

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				private IMKAVQMVTAL TBVNXHVEJNY
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				private object OXAJVRVSDJL
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
				[DebuggerHidden]
				public KGDRABGODBM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
				[DebuggerHidden]
				private void HQYJSAUBZEC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x906EF80", Offset = "0x906DD80", VA = "0x18906EF80", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x906EF40", Offset = "0x906DD40", VA = "0x18906EF40", Slot = "8")]
				[DebuggerHidden]
				private void EYXYBZSNHNN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private readonly ScheduleQueueType CALTPJHTDPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private DLHIAPQRHVO VVXTPEZYXEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private readonly List<QUEVGAMHALI> YLNUZUJCPJH;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x906DA00", Offset = "0x906C800", VA = "0x18906DA00")]
			public DTRFHPJUDBL(ScheduleQueueType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x906D7A0", Offset = "0x906C5A0", VA = "0x18906D7A0")]
			public IDisposable JWOLGAEBWLM(QUEVGAMHALI a, TQPUKRRDZNZ b, BHTOMZEUOYU c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x906D620", Offset = "0x906C420", VA = "0x18906D620")]
			private void EPAIPKWPABT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x906D970", Offset = "0x906C770", VA = "0x18906D970")]
			[IteratorStateMachine(typeof(KGDRABGODBM))]
			private IEnumerator<IMKAVQMVTAL> XKKMHXXLEDK(BHTOMZEUOYU a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x906D5D0", Offset = "0x906C3D0", VA = "0x18906D5D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class QUEVGAMHALI
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
			private static int HHKAYLVZNPY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public readonly int QXVQSTMOTBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public readonly YFIQJDPXTBF IGKASUHZGUG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private readonly MonoBehaviour EXFBOGRWWOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public readonly Action XRUANWNTUEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public readonly Action<float> VXEREWOEWZB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public readonly float IKCLRTFIVKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public float MGOWHFMQTYS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public readonly string JDIPTDKIYCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public readonly bool SRGIJEEYBPW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public readonly UpdateTypes RUUZZMKKXNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool PSGKFABXFQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public bool YGDHUMUKTFG;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x90761F0", Offset = "0x9074FF0", VA = "0x1890761F0")]
			public QUEVGAMHALI(YFIQJDPXTBF a, Action b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x9076530", Offset = "0x9075330", VA = "0x189076530")]
			public QUEVGAMHALI(YFIQJDPXTBF a, Action<float> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x9076360", Offset = "0x9075160", VA = "0x189076360")]
			public QUEVGAMHALI(YFIQJDPXTBF a, float b, Action<float> c, BHTOMZEUOYU d, UpdateTypes e, bool f, bool g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x9075FA0", Offset = "0x9074DA0", VA = "0x189075FA0")]
			public bool IWWNNIWWCJX(float a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly TQPUKRRDZNZ LDPTRROTLSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly BHTOMZEUOYU TKZRNOFRIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<ScheduleQueueType, DTRFHPJUDBL> OBMCISPZBMC;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x906E780", Offset = "0x906D580", VA = "0x18906E780")]
		[FDNTPBIGLET.Root]
		internal static void HXFBVLRWIQC(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x906EE80", Offset = "0x906DC80", VA = "0x18906EE80")]
		[UnityEngine.Scripting.Preserve]
		internal JQWRDPISIBY([Inject(null)] TQPUKRRDZNZ scheduler, [Inject(null)] BHTOMZEUOYU schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x906ECB0", Offset = "0x906DAB0", VA = "0x18906ECB0", Slot = "4")]
		public IDisposable Update(YFIQJDPXTBF context, Action callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x906EAE0", Offset = "0x906D8E0", VA = "0x18906EAE0", Slot = "5")]
		public IDisposable Update(YFIQJDPXTBF context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x906E510", Offset = "0x906D310", VA = "0x18906E510", Slot = "7")]
		public IDisposable FRWGVXLREYR(YFIQJDPXTBF a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x906E410", Offset = "0x906D210", VA = "0x18906E410", Slot = "8")]
		public IDisposable EHDNKOPFZAB(YFIQJDPXTBF a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x906E610", Offset = "0x906D410", VA = "0x18906E610", Slot = "6")]
		public IDisposable FRWGVXLREYR(float a, Action<float> b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x906E920", Offset = "0x906D720", VA = "0x18906E920", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x906E7F0", Offset = "0x906D5F0", VA = "0x18906E7F0")]
		private DTRFHPJUDBL IGHBSNDKJZV(ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class RBBZZQMJQDW : KXZSSWDJURX, TQPUKRRDZNZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private OORXEODWUFL[] PZMLTNCEAYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private HLMZVHGZLMT IOKLHVOERLX;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9076DC0", Offset = "0x9075BC0", VA = "0x189076DC0")]
		[FDNTPBIGLET.Root]
		internal static void NHOBNFBSGEC(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x90773D0", Offset = "0x90761D0", VA = "0x1890773D0")]
		[UnityEngine.Scripting.Preserve]
		public RBBZZQMJQDW([Inject(null)] UNUYTWDRHRK unityLifecycleEvents, [Inject(null)] BHTOMZEUOYU schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9076C90", Offset = "0x9075A90", VA = "0x189076C90", Slot = "19")]
		public override DLHIAPQRHVO GPGIKFCIMMK(SAMRDZOWKNO a, IEnumerator<IMKAVQMVTAL> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9076EE0", Offset = "0x9075CE0", VA = "0x189076EE0", Slot = "20")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9076A00", Offset = "0x9075800", VA = "0x189076A00", Slot = "22")]
		public override void DTRFHPJUDBL(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9077260", Offset = "0x9076060", VA = "0x189077260", Slot = "21")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x90766A0", Offset = "0x90754A0", VA = "0x1890766A0")]
		private OORXEODWUFL BBOTECGMTCW(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x90766D0", Offset = "0x90754D0", VA = "0x1890766D0", Slot = "23")]
		internal override MVQSDIGYMWS CENDADAJPVA(IEnumerator<IMKAVQMVTAL> a, Behaviour b, BJGDMAIJSKB c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9076E30", Offset = "0x9075C30", VA = "0x189076E30", Slot = "24")]
		internal override ZCUMYKAZZJN PESEBJUCLEH(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x90768E0", Offset = "0x90756E0", VA = "0x1890768E0")]
		private void CKEHKWGWLUC(OORXEODWUFL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9076C30", Offset = "0x9075A30", VA = "0x189076C30", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x9078530", Offset = "0x9077330", VA = "0x189078530")]
		public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
		{
			return default(ScheduleSortJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9078610", Offset = "0x9077410", VA = "0x189078610", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x90784F0", Offset = "0x90772F0", VA = "0x1890784F0")]
		private bool CXXYUQOVSZZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9078A00", Offset = "0x9077800", VA = "0x189078A00")]
		private void VHYMCJXJMLD(NativeArray<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9078590", Offset = "0x9077390", VA = "0x189078590")]
		private int ECEUJDJFBCM(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9078930", Offset = "0x9077730", VA = "0x189078930")]
		private void NBUYFYSXQRZ(NativeArray<int> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x90786F0", Offset = "0x90774F0", VA = "0x1890786F0")]
		private void Merge(NativeArray<int> arr, int leftStart, int middle, int rightEnd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class KXZSSWDJURX : TQPUKRRDZNZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly UNUYTWDRHRK CJKZVBQYJPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		protected readonly BHTOMZEUOYU TKZRNOFRIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private ZCUMYKAZZJN[] AONIYKRQYCT;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static TQPUKRRDZNZ GUIRZRNRSLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x906F490", Offset = "0x906E290", VA = "0x18906F490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ScheduleQueueType JUEBRAMHDZD
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ScheduleQueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BHTOMZEUOYU AHFNHSREMJS
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public IMKAVQMVTAL ZWKMYPUCKMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IMKAVQMVTAL TGSLFQTRGYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IMKAVQMVTAL EZJLGFDQYYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public IMKAVQMVTAL FUBVLMBNZPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x906FC50", Offset = "0x906EA50", VA = "0x18906FC50")]
		public static DLHIAPQRHVO MIMGKLUPTHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9070340", Offset = "0x906F140", VA = "0x189070340")]
		[UnityEngine.Scripting.Preserve]
		protected KXZSSWDJURX([Inject(null)] UNUYTWDRHRK unityLifecycleEvents, [Inject(null)] BHTOMZEUOYU schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9070100", Offset = "0x906EF00", VA = "0x189070100", Slot = "6")]
		public DLHIAPQRHVO Run(IEnumerator<IMKAVQMVTAL> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x906FF30", Offset = "0x906ED30", VA = "0x18906FF30", Slot = "7")]
		public DLHIAPQRHVO Run(Behaviour context, IEnumerator<IMKAVQMVTAL> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract DLHIAPQRHVO GPGIKFCIMMK(SAMRDZOWKNO a, IEnumerator<IMKAVQMVTAL> b);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x906FDC0", Offset = "0x906EBC0", VA = "0x18906FDC0", Slot = "20")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x906F500", Offset = "0x906E300", VA = "0x18906F500", Slot = "9")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9070130", Offset = "0x906EF30", VA = "0x189070130", Slot = "21")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x906FBF0", Offset = "0x906E9F0", VA = "0x18906FBF0")]
		private void GRIXDJDSUOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x906FC10", Offset = "0x906EA10", VA = "0x18906FC10")]
		private void HTGSKALCZXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x906FB70", Offset = "0x906E970", VA = "0x18906FB70")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x906FC30", Offset = "0x906EA30", VA = "0x18906FC30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x906F740", Offset = "0x906E540", VA = "0x18906F740")]
		private void DQWRXVIROHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9070150", Offset = "0x906EF50", VA = "0x189070150")]
		private void VIBXMNMVOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9070110", Offset = "0x906EF10", VA = "0x189070110")]
		private void UJAFGEMFQMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x906F760", Offset = "0x906E560", VA = "0x18906F760", Slot = "22")]
		public virtual void DTRFHPJUDBL(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9070170", Offset = "0x906EF70", VA = "0x189070170")]
		private void ZPXCGZPBXJS(ZCUMYKAZZJN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x298A5B0", Offset = "0x29893B0", VA = "0x18298A5B0")]
		private ZCUMYKAZZJN ZRIXQSIQGYE(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "23")]
		internal abstract MVQSDIGYMWS CENDADAJPVA(IEnumerator<IMKAVQMVTAL> a, Behaviour b, BJGDMAIJSKB c);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "24")]
		internal abstract ZCUMYKAZZJN PESEBJUCLEH(ScheduleQueueType a);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x906F7F0", Offset = "0x906E5F0", VA = "0x18906F7F0", Slot = "25")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x906FB90", Offset = "0x906E990", VA = "0x18906FB90", Slot = "15")]
		public IMKAVQMVTAL GJCPHUXKTFV(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x906FD40", Offset = "0x906EB40", VA = "0x18906FD40", Slot = "16")]
		public IMKAVQMVTAL PYORZQZYTLU(float a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x906FCE0", Offset = "0x906EAE0", VA = "0x18906FCE0", Slot = "17")]
		public IMKAVQMVTAL PHRAEDCHEUR(Func<bool> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal sealed class MVQSDIGYMWS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly BJGDMAIJSKB VVXTPEZYXEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly HSTSVYBTCWS ADKEKNLASFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly bool BXFUNAUNIRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private string ZKYCZECDPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private StackTrace PBNAFFRLVZE;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IEnumerator<IMKAVQMVTAL> IXXZEQRBBXF
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public IMKAVQMVTAL UQOELWVKMSR
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GCKOIXIBNRD
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9072320", Offset = "0x9071120", VA = "0x189072320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool WTNYJIIAAVG
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xDAAA60", Offset = "0xDA9860", VA = "0x180DAAA60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xE9A850", Offset = "0xE99650", VA = "0x180E9A850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x90723A0", Offset = "0x90711A0", VA = "0x1890723A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float RIYWABDTAGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xF44220", Offset = "0xF43020", VA = "0x180F44220")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xF44230", Offset = "0xF43030", VA = "0x180F44230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x90726A0", Offset = "0x90714A0", VA = "0x1890726A0")]
		public MVQSDIGYMWS(IEnumerator<IMKAVQMVTAL> a, HSTSVYBTCWS b, BJGDMAIJSKB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9071FB0", Offset = "0x9070DB0", VA = "0x189071FB0")]
		public IMKAVQMVTAL CYPNWFFDHEZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9072550", Offset = "0x9071350", VA = "0x189072550")]
		public bool REHRZURQKOX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x90722D0", Offset = "0x90710D0", VA = "0x1890722D0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x90725C0", Offset = "0x90713C0", VA = "0x1890725C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xF4C4F0", Offset = "0xF4B2F0", VA = "0x180F4C4F0")]
		[CompilerGenerated]
		private void EBMDWSFKZIX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal sealed class BJGDMAIJSKB : JJHUMDULGGC, DLHIAPQRHVO, SGMUANPBQKN, WGVXBSAEBCD, IEnumerator, IMKAVQMVTAL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private ScheduleQueueType IQLDUPYKRFB;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private ScheduleQueueType CYMVIQMNGBK
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xB882F0", Offset = "0xB870F0", VA = "0x180B882F0", Slot = "23")]
			get
			{
				return default(ScheduleQueueType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public ScheduleQueueType IHLVWRQKHAS
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x10D0AA0", Offset = "0x10CF8A0", VA = "0x1810D0AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private float QGVWKOLJNBM
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB0DD50", Offset = "0xB0CB50", VA = "0x180B0DD50", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool JGEYXGXUITT
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x906BBA0", Offset = "0x906A9A0", VA = "0x18906BBA0", Slot = "24")]
		private bool BDLYGIRJCKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x906BBC0", Offset = "0x906A9C0", VA = "0x18906BBC0", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x906BBD0", Offset = "0x906A9D0", VA = "0x18906BBD0")]
		public BJGDMAIJSKB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal enum TickResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Remove,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		Reinsert,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		NextUpdateChanged
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class ZCUMYKAZZJN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public enum SubQueue
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			Future
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct ReinsertBuffer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public ScheduleQueueType QueueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public SubQueue SubQueue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public List<MVQSDIGYMWS> Coroutines;
		}

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private static readonly SubQueue[] CDNFFURAQED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly ScheduleQueueType CALTPJHTDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private bool HUPKDXDUYCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly MVQSDIGYMWS[] OQSBPTSOWCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly List<MVQSDIGYMWS> NHFWDMQORTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly Stack<int> GCDZWDGFFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly List<MVQSDIGYMWS> DWFGPWXCSDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly Stack<int> AYJGAEOMVBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly HLMZVHGZLMT XTMGZYXTOQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private bool NYTUELYXCQH;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public ReinsertBuffer[,] NNONOGYTVHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x907CBE0", Offset = "0x907B9E0", VA = "0x18907CBE0")]
		public ZCUMYKAZZJN(ScheduleQueueType a, HLMZVHGZLMT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x907B670", Offset = "0x907A470", VA = "0x18907B670")]
		public void BZCVBMFCWQY(MVQSDIGYMWS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x907BEE0", Offset = "0x907ACE0", VA = "0x18907BEE0")]
		public void MPBULAHIZVW(IList<MVQSDIGYMWS> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x907C360", Offset = "0x907B160", VA = "0x18907C360")]
		public void TJHSLSISXAW(IList<MVQSDIGYMWS> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x907C970", Offset = "0x907B770", VA = "0x18907C970")]
		private void XKRSIYBEOYN(MVQSDIGYMWS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x907C670", Offset = "0x907B470", VA = "0x18907C670")]
		private void TKYGUXQMICV(IList<MVQSDIGYMWS> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x907C1F0", Offset = "0x907AFF0", VA = "0x18907C1F0")]
		private TickResult OBFUARLNOUY(MVQSDIGYMWS a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x907C800", Offset = "0x907B600", VA = "0x18907C800")]
		public void Update(float currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x907B730", Offset = "0x907A530", VA = "0x18907B730")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x907BB80", Offset = "0x907A980", VA = "0x18907BB80")]
		private void JFUKLSIUBNG(List<MVQSDIGYMWS> a, Stack<int> b, bool c, float d = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x907B920", Offset = "0x907A720", VA = "0x18907B920", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x907BA40", Offset = "0x907A840", VA = "0x18907BA40")]
		private void IUZFOUIJGME(List<MVQSDIGYMWS> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal class VDABBLPGHZT : HLMZVHGZLMT
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void UVQXAFBYVFE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public void QPQVIISMJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public VDABBLPGHZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal class HRPUEKRJVXG : HSTSVYBTCWS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly Behaviour IRBBZLGLRLY;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string JDIPTDKIYCA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x906E2E0", Offset = "0x906D0E0", VA = "0x18906E2E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool VZFJAZRJIEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x906E380", Offset = "0x906D180", VA = "0x18906E380", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool WSVZFPUSALF
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x906E360", Offset = "0x906D160", VA = "0x18906E360", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public HRPUEKRJVXG(Behaviour a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3211238242
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x907D340", Offset = "0x907C140", VA = "0x18907D340")]
	public static void HLHXEDCBNRB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x907D330", Offset = "0x907C130", VA = "0x18907D330")]
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
