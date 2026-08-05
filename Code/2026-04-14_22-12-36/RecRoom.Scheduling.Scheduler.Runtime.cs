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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA359D80", Offset = "0xA358980", VA = "0x18A359D80", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3631B0", Offset = "0xA361DB0", VA = "0x18A3631B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29F8180", Offset = "0x29F6D80", VA = "0x1829F8180")]
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
			private sealed class HGOHUZHWDLD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public CXFRZXTFJOP.WrapperKey YVOBJQTFQPB;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public HGOHUZHWDLD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xA356AA0", Offset = "0xA3556A0", VA = "0x18A356AA0")]
				internal void SMLNGIETAVJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static IDisposable frameScope;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA362510", Offset = "0xA361110", VA = "0x18A362510")]
			public static PlayerLoopSystem ZMQYHUNDUUD(CXFRZXTFJOP.WrapperKey a)
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
			private sealed class UBYOUQYNJZM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public CXFRZXTFJOP.WrapperKey YVOBJQTFQPB;

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public UBYOUQYNJZM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0xA35FEE0", Offset = "0xA35EAE0", VA = "0x18A35FEE0")]
				internal void SMLNGIETAVJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA3623F0", Offset = "0xA360FF0", VA = "0x18A3623F0")]
			public static PlayerLoopSystem ZMQYHUNDUUD(CXFRZXTFJOP.WrapperKey a)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA3538F0", Offset = "0xA3524F0", VA = "0x18A3538F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA353970", Offset = "0xA352570", VA = "0x18A353970")]
		private static void GQDJCGMTKNT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA354BA0", Offset = "0xA3537A0", VA = "0x18A354BA0")]
		private static void XBHVJHDTPIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA353BC0", Offset = "0xA3527C0", VA = "0x18A353BC0")]
		private static void KZTZEKQDEOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA354020", Offset = "0xA352C20", VA = "0x18A354020")]
		private static void OJAZEWZNZDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x38CAE90", Offset = "0x38C9A90", VA = "0x1838CAE90")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA3539C0", Offset = "0xA3525C0", VA = "0x18A3539C0")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x38CAE90", Offset = "0x38C9A90", VA = "0x1838CAE90")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x38CAF20", Offset = "0x38C9B20", VA = "0x1838CAF20")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) JUAPLQCUDCU<a, b>(CXFRZXTFJOP.WrapperKey a)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA353A60", Offset = "0xA352660", VA = "0x18A353A60")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) JUAPLQCUDCU(CXFRZXTFJOP.WrapperKey a, Type b, Type c)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class CXFRZXTFJOP
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
		public class ZJISKNQZVPZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly WrapperKey BXLZOGILCJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public readonly QFBKXOQNDNP WUDASWUNGSW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private long XUDBTXPBZBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private long VUNIJQHSURL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public long PSOSMRVWHRK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int STIKYADUZCT;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA362780", Offset = "0xA361380", VA = "0x18A362780")]
			public ZJISKNQZVPZ(WrapperKey a, int b = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA362630", Offset = "0xA361230", VA = "0x18A362630")]
			public void OLGZVMNVDYA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA362730", Offset = "0xA361330", VA = "0x18A362730")]
			public void ZLTZLNKZSMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA362650", Offset = "0xA361250", VA = "0x18A362650")]
			public void VHXEWHBIVXU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static WrapperKey[] YDAJBVROPKD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static ZJISKNQZVPZ[] VGRLUZRCAOV;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA353500", Offset = "0xA352100", VA = "0x18A353500")]
		public static ZJISKNQZVPZ PZURVMARFJR(WrapperKey a, int b = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA353640", Offset = "0xA352240", VA = "0x18A353640")]
		public static ZJISKNQZVPZ XAHLDETTNYT(WrapperKey a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA3536B0", Offset = "0xA3522B0", VA = "0x18A3536B0")]
		public static void XMEMZITQKGG()
		{
		}
	}
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class AOWSVZXIDVW
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private interface AOWETOHGPBO
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			bool DIMNVFRBHLN
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
		private class DUMFDRJDVFG : AOWETOHGPBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private readonly Action GGMTSJNJOKG;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool DIMNVFRBHLN
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
			public DUMFDRJDVFG(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x135ABC0", Offset = "0x13597C0", VA = "0x18135ABC0", Slot = "5")]
			public void Complete()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly List<AOWETOHGPBO> UEAJHGYTOYP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool NDJOXMKLKKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA352040", Offset = "0xA350C40", VA = "0x18A352040")]
		public static void BXTDJPWOEKL(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA352320", Offset = "0xA350F20", VA = "0x18A352320")]
		private static void MTIWDWAGRFD(AOWETOHGPBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3525E0", Offset = "0xA3511E0", VA = "0x18A3525E0")]
		private static void ZXDSKWPWXVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3520D0", Offset = "0xA350CD0", VA = "0x18A3520D0")]
		private static void HWERXFURMMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA352210", Offset = "0xA350E10", VA = "0x18A352210")]
		private static void JGNKDWSYSRW()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class QOMOESSFWWZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA35ECF0", Offset = "0xA35D8F0", VA = "0x18A35ECF0")]
		public static IDisposable GVOFQOPGYAQ(this NOHHZXOITKB a, float b, Action<float> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA35EC70", Offset = "0xA35D870", VA = "0x18A35EC70")]
		public static IDisposable AOBIPCMBXNS(this NOHHZXOITKB a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA35ED70", Offset = "0xA35D970", VA = "0x18A35ED70")]
		public static IDisposable OSYJMSVVXTW(this NOHHZXOITKB a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class MCRZNRHUVHY
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3C1BA60", Offset = "0x3C1A660", VA = "0x183C1BA60")]
		[MustUseReturnValue]
		public static IDisposable XGFTZCNDYZM<a>(this a a, Action b, ScheduleQueueType c, bool d = true) where a : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B8C0", Offset = "0x3C1A4C0", VA = "0x183C1B8C0")]
		[MustUseReturnValue]
		public static IDisposable XGFTZCNDYZM<b>(this b a, Action<float> b, ScheduleQueueType c, bool d = true) where b : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B850", Offset = "0x3C1A450", VA = "0x183C1B850")]
		[MustUseReturnValue]
		public static IDisposable Update<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B020", Offset = "0x3C19C20", VA = "0x183C1B020")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B090", Offset = "0x3C19C90", VA = "0x183C1B090")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action<float> update, bool validateContext = true) where T : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B330", Offset = "0x3C19F30", VA = "0x183C1B330")]
		[MustUseReturnValue]
		public static IDisposable LateUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AFB0", Offset = "0x3C19BB0", VA = "0x183C1AFB0")]
		[MustUseReturnValue]
		public static IDisposable ERAJCFQAUEL<c>(this c a, Action b, bool c = true) where c : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B2C0", Offset = "0x3C19EC0", VA = "0x183C1B2C0")]
		[MustUseReturnValue]
		public static IDisposable KLALXGVBYQI<d>(this d a, Action b, bool c = true) where d : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AF70", Offset = "0x3C19B70", VA = "0x183C1AF70")]
		[MustUseReturnValue]
		public static IDisposable AMIZPJHWNGR<f>(this f a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where f : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA359F30", Offset = "0xA358B30", VA = "0x18A359F30")]
		[MustUseReturnValue]
		public static IDisposable AMIZPJHWNGR(this MonoBehaviour a, AWBPBYERTJE b, float c, Action<float> d, ScheduleQueueType e, bool f = true, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B4A0", Offset = "0x3C1A0A0", VA = "0x183C1B4A0")]
		[MustUseReturnValue]
		public static IDisposable PLUCZWGCTSR<g>(this g a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where g : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B240", Offset = "0x3C19E40", VA = "0x183C1B240")]
		[MustUseReturnValue]
		public static IDisposable JKHCFWAEWJM<h>(this h a, float b, Action<float> c, bool d = true, bool e = true) where h : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3C1BD00", Offset = "0x3C1A900", VA = "0x183C1BD00")]
		[MustUseReturnValue]
		public static IDisposable ZCWZGARYFMB<i>(this i a, Action<float> b, bool c = true, bool d = true) where i : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B3A0", Offset = "0x3C19FA0", VA = "0x183C1B3A0")]
		[MustUseReturnValue]
		public static IDisposable MWLEFUWTMWY<j>(this j a, Action<float> b, bool c = true, bool d = true) where j : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B750", Offset = "0x3C1A350", VA = "0x183C1B750")]
		[MustUseReturnValue]
		public static IDisposable TVUIUGAQIOR<k>(this k a, Action<float> b, bool c = true, bool d = true) where k : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3C1BC00", Offset = "0x3C1A800", VA = "0x183C1BC00")]
		[MustUseReturnValue]
		public static IDisposable YQOFNPSWXES<l>(this l a, Action<float> b, bool c = true, bool d = true) where l : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3C1BC80", Offset = "0x3C1A880", VA = "0x183C1BC80")]
		[MustUseReturnValue]
		public static IDisposable YRMUXVDDCZY<m>(this m a, Action<float> b, bool c = true, bool d = true) where m : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B420", Offset = "0x3C1A020", VA = "0x183C1B420")]
		[MustUseReturnValue]
		public static IDisposable NQMDFVTLCXQ<n>(this n a, Action<float> b, bool c = true, bool d = true) where n : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B7D0", Offset = "0x3C1A3D0", VA = "0x183C1B7D0")]
		[MustUseReturnValue]
		public static IDisposable UVPMFLZWUME<q>(this q a, Action<float> b, bool c = true, bool d = true) where q : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B650", Offset = "0x3C1A250", VA = "0x183C1B650")]
		[MustUseReturnValue]
		public static IDisposable PWKSATVXCWW<s>(this s a, float b, Action<float> c, bool d = true, bool e = true) where s : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B6D0", Offset = "0x3C1A2D0", VA = "0x183C1B6D0")]
		[MustUseReturnValue]
		public static IDisposable RPBEYSCODOK<u>(this u a, Action<float> b, bool c = true, bool d = true) where u : MonoBehaviour, AWBPBYERTJE
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class UCYNNKNFMLG
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class AJUVQVPSVMF : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ScheduleQueueType XRSJLIPPVGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Action HPNKQHTYABX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private CYPGEUCQKIF GMPRENJVAAE;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public AJUVQVPSVMF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA351F70", Offset = "0xA350B70", VA = "0x18A351F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA351F30", Offset = "0xA350B30", VA = "0x18A351F30", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class AJPOTOVVMAW : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public ScheduleQueueType XRSJLIPPVGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Action<float> HPNKQHTYABX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private CYPGEUCQKIF GMPRENJVAAE;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public AJPOTOVVMAW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA351E50", Offset = "0xA350A50", VA = "0x18A351E50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA351E10", Offset = "0xA350A10", VA = "0x18A351E10", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA3602E0", Offset = "0xA35EEE0", VA = "0x18A3602E0")]
		public static YDHSMJLFZLP XGFTZCNDYZM(Action a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA360250", Offset = "0xA35EE50", VA = "0x18A360250")]
		public static YDHSMJLFZLP XGFTZCNDYZM(Behaviour a, Action b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA360360", Offset = "0xA35EF60", VA = "0x18A360360")]
		public static YDHSMJLFZLP XGFTZCNDYZM(Behaviour a, Action<float> b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA360150", Offset = "0xA35ED50", VA = "0x18A360150")]
		[IteratorStateMachine(typeof(AJUVQVPSVMF))]
		private static IEnumerator<NVIJVYVFXPY> UWVECPMAZLX(ScheduleQueueType a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3601D0", Offset = "0xA35EDD0", VA = "0x18A3601D0")]
		[IteratorStateMachine(typeof(AJPOTOVVMAW))]
		private static IEnumerator<NVIJVYVFXPY> UWVECPMAZLX(ScheduleQueueType a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class JIFSKKPIUCB : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class BGXAIYFFJCA : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public JIFSKKPIUCB DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public BGXAIYFFJCA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA352F70", Offset = "0xA351B70", VA = "0x18A352F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA352F30", Offset = "0xA351B30", VA = "0x18A352F30", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ScheduleQueueType EXXXXTBADXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Action APEQHZDRTNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool JPWPBLTXSNP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool SQVJFZTNKTD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF3830", VA = "0x180CF4C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA357180", Offset = "0xA355D80", VA = "0x18A357180")]
		public JIFSKKPIUCB(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA357070", Offset = "0xA355C70", VA = "0x18A357070")]
		[IteratorStateMachine(typeof(BGXAIYFFJCA))]
		private IEnumerator<NVIJVYVFXPY> OOOSIFZNMYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA3570E0", Offset = "0xA355CE0", VA = "0x18A3570E0", Slot = "4")]
		public void OnCompleted(Action continuation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public void MVUJCEMZVBP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class AWHTOYRTUEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA352970", Offset = "0xA351570", VA = "0x18A352970")]
		public static JIFSKKPIUCB ZIWBNELVIQR(this ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class MKISVGNBXMG
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class DHBRWBRCMGN : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public WHOJVRGECQH PCLESGCLNDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Action<float> HPNKQHTYABX;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public DHBRWBRCMGN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA355270", Offset = "0xA353E70", VA = "0x18A355270", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA355230", Offset = "0xA353E30", VA = "0x18A355230", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA35BE60", Offset = "0xA35AA60", VA = "0x18A35BE60")]
		public static YDHSMJLFZLP XGFTZCNDYZM(float a, Action<float> b, ScheduleQueueType c, bool d = true, [Optional] EIGPTYHGYCM e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA35BD90", Offset = "0xA35A990", VA = "0x18A35BD90")]
		public static YDHSMJLFZLP XGFTZCNDYZM(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] EIGPTYHGYCM f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA35BB90", Offset = "0xA35A790", VA = "0x18A35BB90")]
		public static YDHSMJLFZLP EDEWXPEORDO(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] EIGPTYHGYCM f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA35BF30", Offset = "0xA35AB30", VA = "0x18A35BF30")]
		public static YDHSMJLFZLP ZVZQOJROYME(NOHHZXOITKB a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] EIGPTYHGYCM f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA35BCE0", Offset = "0xA35A8E0", VA = "0x18A35BCE0")]
		private static IEnumerator<NVIJVYVFXPY> UWVECPMAZLX(XOOBCRGRVTH a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA35BC80", Offset = "0xA35A880", VA = "0x18A35BC80")]
		private static IEnumerator<NVIJVYVFXPY> PRXJSWGGSST(XOOBCRGRVTH a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA35BB00", Offset = "0xA35A700", VA = "0x18A35BB00")]
		[IteratorStateMachine(typeof(DHBRWBRCMGN))]
		private static IEnumerator<NVIJVYVFXPY> DCFNZMJYBDH(WHOJVRGECQH a, float b, ScheduleQueueType c, Action<float> d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class KRMBGZLYQJA
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class GIYFPPVLPCG : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public ScheduleQueueType EXXXXTBADXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public Func<bool> UUCAJYYDFMR;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public GIYFPPVLPCG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA356780", Offset = "0xA355380", VA = "0x18A356780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA356740", Offset = "0xA355340", VA = "0x18A356740", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA359CC0", Offset = "0xA3588C0", VA = "0x18A359CC0")]
		[IteratorStateMachine(typeof(GIYFPPVLPCG))]
		private static IEnumerator<NVIJVYVFXPY> WEOHBRSRJHQ(ScheduleQueueType a, Func<bool> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA359BE0", Offset = "0xA3587E0", VA = "0x18A359BE0")]
		public static YDHSMJLFZLP PPEYXQGSSUX(this MonoBehaviour a, Func<bool> b, ScheduleQueueType c = ScheduleQueueType.Update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class OJEIHZNJSXF
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class BHSBXZGUUVK : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float UGBWVKUXDFX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public ScheduleQueueType XRSJLIPPVGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action GVJJOWKGTWQ;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public BHSBXZGUUVK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA353040", Offset = "0xA351C40", VA = "0x18A353040", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA353000", Offset = "0xA351C00", VA = "0x18A353000", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class OBOXDLLCQSQ<a> : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float UGBWVKUXDFX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public ScheduleQueueType XRSJLIPPVGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Action<a> GVJJOWKGTWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public a WEUXBQLUTEY;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public OBOXDLLCQSQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x729CFD0", Offset = "0x729BBD0", VA = "0x18729CFD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class HAHJTVLMRKS : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float UGBWVKUXDFX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ScheduleQueueType XRSJLIPPVGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Action GVJJOWKGTWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private NVIJVYVFXPY VSACEDYEHCQ;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public HAHJTVLMRKS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA356920", Offset = "0xA355520", VA = "0x18A356920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA3568E0", Offset = "0xA3554E0", VA = "0x18A3568E0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA35E7D0", Offset = "0xA35D3D0", VA = "0x18A35E7D0")]
		[IteratorStateMachine(typeof(BHSBXZGUUVK))]
		private static IEnumerator<NVIJVYVFXPY> OOOSIFZNMYQ(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3D83820", Offset = "0x3D82420", VA = "0x183D83820")]
		[IteratorStateMachine(typeof(OBOXDLLCQSQ<>))]
		private static IEnumerator<NVIJVYVFXPY> OOOSIFZNMYQ<a>(float a, ScheduleQueueType b, Action<a> c, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA35E440", Offset = "0xA35D040", VA = "0x18A35E440")]
		[IteratorStateMachine(typeof(HAHJTVLMRKS))]
		private static IEnumerator<NVIJVYVFXPY> ESASRIXPSZO(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA35E360", Offset = "0xA35CF60", VA = "0x18A35E360")]
		public static IDisposable DSLQGNZPXQK(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA35E600", Offset = "0xA35D200", VA = "0x18A35E600")]
		public static YDHSMJLFZLP JLFAKSIVPPG(this MonoBehaviour a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA35E270", Offset = "0xA35CE70", VA = "0x18A35E270")]
		public static YDHSMJLFZLP DSLQGNZPXQK(this MonoBehaviour a, float b, ScheduleQueueType c, Action d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA35E9A0", Offset = "0xA35D5A0", VA = "0x18A35E9A0")]
		public static YDHSMJLFZLP YDZOSDFKLOY(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3D839F0", Offset = "0x3D825F0", VA = "0x183D839F0")]
		public static YDHSMJLFZLP YDZOSDFKLOY<b>(this MonoBehaviour a, Action<b> b, b c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA35E4D0", Offset = "0xA35D0D0", VA = "0x18A35E4D0")]
		public static YDHSMJLFZLP HAKZDEURIWA(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA35E130", Offset = "0xA35CD30", VA = "0x18A35E130")]
		public static YDHSMJLFZLP AQCQEIMLYWQ(this MonoBehaviour a, Action b, [Optional] EIGPTYHGYCM c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA35E900", Offset = "0xA35D500", VA = "0x18A35E900")]
		public static YDHSMJLFZLP XQSZDGGSRPM(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA35E690", Offset = "0xA35D290", VA = "0x18A35E690")]
		public static YDHSMJLFZLP LOUSVCFZRYA(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA35E730", Offset = "0xA35D330", VA = "0x18A35E730")]
		public static YDHSMJLFZLP LXMFBFQIZLG(MonoBehaviour a, ScheduleQueueType b, Action c, [Optional] EIGPTYHGYCM d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3D83510", Offset = "0x3D82110", VA = "0x183D83510")]
		public static YDHSMJLFZLP LXMFBFQIZLG<h>(MonoBehaviour a, ScheduleQueueType b, Action<h> c, h d, [Optional] EIGPTYHGYCM e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA35E570", Offset = "0xA35D170", VA = "0x18A35E570")]
		public static YDHSMJLFZLP ITPMKNREONU(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA35E860", Offset = "0xA35D460", VA = "0x18A35E860")]
		public static YDHSMJLFZLP RVSFWPJPEHE(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA35E1D0", Offset = "0xA35CDD0", VA = "0x18A35E1D0")]
		public static YDHSMJLFZLP BVZHBWWFRWG(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA35EA40", Offset = "0xA35D640", VA = "0x18A35EA40")]
		public static YDHSMJLFZLP ZYLYMXJOPUE(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NZPIHTKBIHB : IHOOIXPGOAP, IEnumerable<IHOOIXPGOAP>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly List<IHOOIXPGOAP> RRVAUJIPOUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool EAOHJUDUNFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Action EAIIOPQBNZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool IMKJXKJLMID;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool OZOTRCPXHBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA35D800", Offset = "0xA35C400", VA = "0x18A35D800", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JBKFIGOWNAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA35D930", Offset = "0xA35C530", VA = "0x18A35D930", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA35D760", Offset = "0xA35C360", VA = "0x18A35D760", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA35D9D0", Offset = "0xA35C5D0", VA = "0x18A35D9D0")]
		public NZPIHTKBIHB([Optional] Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA35D410", Offset = "0xA35C010", VA = "0x18A35D410")]
		public void Add(IHOOIXPGOAP limiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA35D600", Offset = "0xA35C200", VA = "0x18A35D600")]
		private void LQONGNJIHMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA35D100", Offset = "0xA35BD00", VA = "0x18A35D100", Slot = "7")]
		public bool ABAVKSUXNZL(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA35D110", Offset = "0xA35BD10", VA = "0x18A35D110", Slot = "8")]
		public bool ABAVKSUXNZL(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA35D580", Offset = "0xA35C180", VA = "0x18A35D580", Slot = "9")]
		public IEnumerator<IHOOIXPGOAP> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA35D580", Offset = "0xA35C180", VA = "0x18A35D580", Slot = "10")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class JCZSWTINGJV : OAWKIFZJTOH
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class UFMXOEVUXJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public JCZSWTINGJV DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Action GGMTSJNJOKG;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UFMXOEVUXJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA35EC40", Offset = "0xA35D840", VA = "0x18A35EC40")]
			internal void BDQQLABCVKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public JCZSWTINGJV DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action GGMTSJNJOKG;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA35EC40", Offset = "0xA35D840", VA = "0x18A35EC40")]
			internal void ZXLAGEWIQAO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly float AKQVPNFDRJI;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA356D10", Offset = "0xA355910", VA = "0x18A356D10")]
		public JCZSWTINGJV(Behaviour a, float b, [Optional] Action c, [Optional] EIGPTYHGYCM d, [Optional] XOOBCRGRVTH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA356F60", Offset = "0xA355B60", VA = "0x18A356F60", Slot = "9")]
		protected override bool GUGAXTMTNRZ(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA356E50", Offset = "0xA355A50", VA = "0x18A356E50", Slot = "10")]
		protected override bool GMIEOYOFYSM(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface IHOOIXPGOAP
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool OZOTRCPXHBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action JBKFIGOWNAV;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ABAVKSUXNZL(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool ABAVKSUXNZL(Action a, bool b = false);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class OAWKIFZJTOH : IHOOIXPGOAP
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class ZTBDMGYYPYK : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public OAWKIFZJTOH DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float DKAIYABSIXK;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public ZTBDMGYYPYK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA3630E0", Offset = "0xA361CE0", VA = "0x18A3630E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xA3630A0", Offset = "0xA361CA0", VA = "0x18A3630A0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly Behaviour SZKFOUDUREX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action EAIIOPQBNZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private ZSWOFHRQHTQ VTFGUOIHOEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly EIGPTYHGYCM KWAEVTXZJMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected readonly XOOBCRGRVTH SNXWOZXVAXM;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool OZOTRCPXHBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xE06A00", Offset = "0xE05600", VA = "0x180E06A00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action JBKFIGOWNAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA35DEE0", Offset = "0xA35CAE0", VA = "0x18A35DEE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA35DDA0", Offset = "0xA35C9A0", VA = "0x18A35DDA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA35E000", Offset = "0xA35CC00", VA = "0x18A35E000")]
		protected OAWKIFZJTOH(Behaviour a, [Optional] Action b, [Optional] EIGPTYHGYCM c, [Optional] XOOBCRGRVTH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA35DAD0", Offset = "0xA35C6D0", VA = "0x18A35DAD0", Slot = "7")]
		public bool ABAVKSUXNZL(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA35DA70", Offset = "0xA35C670", VA = "0x18A35DA70", Slot = "8")]
		public bool ABAVKSUXNZL(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool GUGAXTMTNRZ(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool GMIEOYOFYSM(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA35DEC0", Offset = "0xA35CAC0", VA = "0x18A35DEC0")]
		protected void RFHEHFGPIDU(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA35DB30", Offset = "0xA35C730", VA = "0x18A35DB30")]
		protected GMTKWIVSBCA NFEWVFVNHXW(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA35DF80", Offset = "0xA35CB80", VA = "0x18A35DF80")]
		private void WIXZOQPDFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA35DE40", Offset = "0xA35CA40", VA = "0x18A35DE40")]
		[IteratorStateMachine(typeof(ZTBDMGYYPYK))]
		private IEnumerator<NVIJVYVFXPY> QVBZSFFTGBF(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA35DD60", Offset = "0xA35C960", VA = "0x18A35DD60")]
		[CompilerGenerated]
		private void NULVMSKMIFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class BYUPGCFPKQQ : OAWKIFZJTOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly float KPATWKAIIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int OJIIOAVKNAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly float PCHNXFDNPQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly float[] XBJZCRUHUFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int YGOFPURYYHV;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA353330", Offset = "0xA351F30", VA = "0x18A353330")]
		public BYUPGCFPKQQ(Behaviour a, float b, int c, [Optional] Action d, float e = 0f, [Optional] EIGPTYHGYCM f, [Optional] XOOBCRGRVTH g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "9")]
		protected override bool GUGAXTMTNRZ(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3530B0", Offset = "0xA351CB0", VA = "0x18A3530B0", Slot = "10")]
		protected override bool GMIEOYOFYSM(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA3532B0", Offset = "0xA351EB0", VA = "0x18A3532B0")]
		private void SPYYRXVBOGH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class HOJVIBLGTJQ : OAWKIFZJTOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly float AKQVPNFDRJI;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA356D10", Offset = "0xA355910", VA = "0x18A356D10")]
		public HOJVIBLGTJQ(Behaviour a, float b, [Optional] Action c, [Optional] EIGPTYHGYCM d, [Optional] XOOBCRGRVTH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "9")]
		protected override bool GUGAXTMTNRZ(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA356CD0", Offset = "0xA3558D0", VA = "0x18A356CD0", Slot = "10")]
		protected override bool GMIEOYOFYSM(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class AIBIGRBOCII : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class HFTWSNUHYWE : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public Action TCMQYCYMKIO;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public HFTWSNUHYWE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xA3569F0", Offset = "0xA3555F0", VA = "0x18A3569F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xA356A60", Offset = "0xA355660", VA = "0x18A356A60", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private YDHSMJLFZLP OMZEHSBRSTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private NOHHZXOITKB SZKFOUDUREX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private Action<float> EIIPQMPPSVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private ScheduleQueueType EXXXXTBADXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private float EEJLFXWHQBR;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA351950", Offset = "0xA350550", VA = "0x18A351950")]
		public AIBIGRBOCII(NOHHZXOITKB a, float b, Action<float> c, ScheduleQueueType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA3516D0", Offset = "0xA3502D0", VA = "0x18A3516D0")]
		private void OLLVZKIDZSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA351830", Offset = "0xA350430", VA = "0x18A351830")]
		private void XQNOMKMHAJY(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA351660", Offset = "0xA350260", VA = "0x18A351660")]
		[IteratorStateMachine(typeof(HFTWSNUHYWE))]
		private IEnumerator<NVIJVYVFXPY> JYTODEDZVIA(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA351490", Offset = "0xA350090", VA = "0x18A351490", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3514F0", Offset = "0xA3500F0", VA = "0x18A3514F0")]
		[CompilerGenerated]
		private void IULVFMCGLFN(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class MZBGLNEEGUK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class HETOGFYVDRL : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Action TCMQYCYMKIO;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public HETOGFYVDRL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA3569F0", Offset = "0xA3555F0", VA = "0x18A3569F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA3569B0", Offset = "0xA3555B0", VA = "0x18A3569B0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private YDHSMJLFZLP OMZEHSBRSTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private MonoBehaviour GAARZFPEYGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Action HPNKQHTYABX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Action<float> EIIPQMPPSVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private ScheduleQueueType EXXXXTBADXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private float EEJLFXWHQBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool IDFEETLVBLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly EIGPTYHGYCM KWAEVTXZJMZ;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA35CBE0", Offset = "0xA35B7E0", VA = "0x18A35CBE0")]
		public MZBGLNEEGUK(MonoBehaviour a, Action b, ScheduleQueueType c, [Optional] EIGPTYHGYCM d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA35CF40", Offset = "0xA35BB40", VA = "0x18A35CF40")]
		public MZBGLNEEGUK(MonoBehaviour a, Action<float> b, ScheduleQueueType c, [Optional] EIGPTYHGYCM d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA35CD60", Offset = "0xA35B960", VA = "0x18A35CD60")]
		public MZBGLNEEGUK(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] EIGPTYHGYCM f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6507040", Offset = "0x6505C40", VA = "0x186507040")]
		private MZBGLNEEGUK(EIGPTYHGYCM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA35C000", Offset = "0xA35AC00", VA = "0x18A35C000")]
		internal static MZBGLNEEGUK DLKJYFEXVOO(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] EIGPTYHGYCM f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA35C870", Offset = "0xA35B470", VA = "0x18A35C870")]
		private void XGFTZCNDYZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA35C670", Offset = "0xA35B270", VA = "0x18A35C670")]
		private void TOLQWUVAHZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA35C500", Offset = "0xA35B100", VA = "0x18A35C500")]
		private void OLLVZKIDZSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA35C280", Offset = "0xA35AE80", VA = "0x18A35C280")]
		private void GRWEWIGWQQW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA35C9A0", Offset = "0xA35B5A0", VA = "0x18A35C9A0")]
		private void XQNOMKMHAJY(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA35C400", Offset = "0xA35B000", VA = "0x18A35C400")]
		[IteratorStateMachine(typeof(HETOGFYVDRL))]
		private IEnumerator<NVIJVYVFXPY> JYTODEDZVIA(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA35C220", Offset = "0xA35AE20", VA = "0x18A35C220", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA35C7E0", Offset = "0xA35B3E0", VA = "0x18A35C7E0")]
		[CompilerGenerated]
		private void VLVGXCICOYP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA35CAC0", Offset = "0xA35B6C0", VA = "0x18A35CAC0")]
		[CompilerGenerated]
		private void YITJOKQDTKO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA35CB50", Offset = "0xA35B750", VA = "0x18A35CB50")]
		[CompilerGenerated]
		private void ZSKHMEUOTCH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA35C470", Offset = "0xA35B070", VA = "0x18A35C470")]
		[CompilerGenerated]
		private void LFKIGVLHYLC(string a)
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
	internal sealed class GXCXYALNEET : XOOBCRGRVTH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float FJTWFODLAKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA356830", Offset = "0xA355430", VA = "0x18A356830", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JUSTTZOQSHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xA3568D0", Offset = "0xA3554D0", VA = "0x18A3568D0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public double UXUAXSCMTPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA3568B0", Offset = "0xA3554B0", VA = "0x18A3568B0", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA356840", Offset = "0xA355440", VA = "0x18A356840")]
		[GEPWJNEAFDW.Root]
		internal static void RDUKEQTCCWZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		[UnityEngine.Scripting.Preserve]
		internal GXCXYALNEET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal interface RXRTLWDJMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SNGVOHWMBYT(string a);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NSSGIHSZVJB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal interface BTWUXUFIUID
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool CZNZYGZCSPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool TDQCPOHGXRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal class DDIPTNQHBGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public KEMZWFRBFHE KSPHNULACNF;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int RNGYLFLSPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0640", VA = "0x180CF1A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA354F20", Offset = "0xA353B20", VA = "0x18A354F20")]
		public static NVIJVYVFXPY OTNHODRRPZE(IEnumerator<NVIJVYVFXPY> a, MFYSHEZDMOG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA355080", Offset = "0xA353C80", VA = "0x18A355080")]
		public NVIJVYVFXPY OTNHODRRPZE(MFYSHEZDMOG[] a, IEnumerator<NVIJVYVFXPY>[] b, NVIJVYVFXPY[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA354E00", Offset = "0xA353A00", VA = "0x18A354E00")]
		public void MOVSUSXDRJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA355140", Offset = "0xA353D40", VA = "0x18A355140")]
		public void ZZIMWIXZHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA354E30", Offset = "0xA353A30", VA = "0x18A354E30")]
		public void HTVYLRXUEZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA354E00", Offset = "0xA353A00", VA = "0x18A354E00")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public DDIPTNQHBGH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class KEMZWFRBFHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct JobbedInsertionData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public DDIPTNQHBGH Routine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public NOHHZXOITKB Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public MFYSHEZDMOG Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public IEnumerator<NVIJVYVFXPY> Coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public NVIJVYVFXPY CurrentSchedule;

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
		private sealed class TBMIUWRZTOR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public MFYSHEZDMOG MXZXSYNLTDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public KEMZWFRBFHE DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public NOHHZXOITKB SZKFOUDUREX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public DDIPTNQHBGH UHVEYXVSVVK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public CoroutineState FWYNUWNDVZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public NVIJVYVFXPY OOBPITBIIUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public IEnumerator<NVIJVYVFXPY> EWTRUHBOLWC;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public TBMIUWRZTOR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA35F430", Offset = "0xA35E030", VA = "0x18A35F430")]
			internal void JNRADJXLOBS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class UUZPLKPRMYV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public DDIPTNQHBGH PCLESGCLNDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public KEMZWFRBFHE DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public UUZPLKPRMYV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA360440", Offset = "0xA35F040", VA = "0x18A360440")]
			internal void NEDIHDLFCWQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class OYBLYKBVHUG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public DDIPTNQHBGH PCLESGCLNDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public KEMZWFRBFHE DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public OYBLYKBVHUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA35EAE0", Offset = "0xA35D6E0", VA = "0x18A35EAE0")]
			internal void FMMSRFZBLEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class LIXGIGXYRMX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public DDIPTNQHBGH PCLESGCLNDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public KEMZWFRBFHE DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public LIXGIGXYRMX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA359D40", Offset = "0xA358940", VA = "0x18A359D40")]
			internal void DXEWBTMVDOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const CoroutineState IOIJCFCWMYW = CoroutineState.Cancelled | CoroutineState.Paused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ScheduleQueueType EXXXXTBADXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool[] TYTFUKOOLOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private NativeArray<CoroutineState> CCFBLBJWJWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NativeArray<float> BEHQAJVOXPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private NativeArray<int> SRAPTFYZAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private NativeArray<int> TEYFYBBZDCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private NativeArray<int> OKIVIEWZLTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private NativeArray<int> EJYSFKWOYGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<int> MPZWKENHAAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private DDIPTNQHBGH[] WRECGOFMVDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private MFYSHEZDMOG[] LGQBUDDYZIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private NOHHZXOITKB[] NTOHCGICKTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<NVIJVYVFXPY>[] TRORBAYGUCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NVIJVYVFXPY[] JOJWWSOUYSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int JFLRLXHOKPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int SDLAPPGURBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly int XUIMYDZIPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private float PRPQVAYXTRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ScheduleSortJob CRYZFKYQUKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private JobHandle IMLZPVRKQLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<DDIPTNQHBGH> SUBCPYLUCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private bool GFHPOFHRHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private List<Action> OKIGAXEHKDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private List<Action> HXYUDSFEXGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool QDNWQXVJNWG;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JobbedReinsertBuffer[] DADTSUNCPBG
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xDB5A80", Offset = "0xDB4680", VA = "0x180DB5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA358800", Offset = "0xA357400", VA = "0x18A358800")]
		private static int IEUGMRLSZEY(ScheduleQueueType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA359590", Offset = "0xA358190", VA = "0x18A359590")]
		public KEMZWFRBFHE(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA3592D0", Offset = "0xA357ED0", VA = "0x18A3592D0")]
		private void XGVSOSWOFKK(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA357330", Offset = "0xA355F30", VA = "0x18A357330")]
		public void BOFKIAALQDE(NOHHZXOITKB a, NVIJVYVFXPY b, IEnumerator<NVIJVYVFXPY> c, MFYSHEZDMOG d, [Optional] DDIPTNQHBGH e, CoroutineState f = CoroutineState.Running)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA358830", Offset = "0xA357430", VA = "0x18A358830")]
		public void Insert(IEnumerable<JobbedInsertionData> insertionDatas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA358E20", Offset = "0xA357A20", VA = "0x18A358E20")]
		private JobbedInsertionData VCIJWDMFVHT(int a)
		{
			return default(JobbedInsertionData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA358250", Offset = "0xA356E50", VA = "0x18A358250")]
		private void FTRKOCTKVPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3BE5140", Offset = "0x3BE3D40", VA = "0x183BE5140")]
		private static void WIIGIJWMOSJ<a>(int a, a[] b, int c, [Optional] a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3BE5190", Offset = "0x3BE3D90", VA = "0x183BE5190")]
		private static void WIIGIJWMOSJ<b>(int a, NativeArray<b> b, int c, [Optional] b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA3577C0", Offset = "0xA3563C0", VA = "0x18A3577C0")]
		private void EBQOVBADYQD(IEnumerable<JobbedInsertionData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA358A70", Offset = "0xA357670", VA = "0x18A358A70")]
		private void PENFISMPTNK(JobbedInsertionData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA3585A0", Offset = "0xA3571A0", VA = "0x18A3585A0")]
		private TickResult GZLRDCISUJR(int a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA358C20", Offset = "0xA357820", VA = "0x18A358C20")]
		public void TTMYJBVNIRE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA357250", Offset = "0xA355E50", VA = "0x18A357250")]
		private void BJQLSYFVGPO(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA3594B0", Offset = "0xA3580B0", VA = "0x18A3594B0")]
		private void ZAESFSDMSCG(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA357B40", Offset = "0xA356740", VA = "0x18A357B40")]
		public void FLSCPMEVSUK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA3576C0", Offset = "0xA3562C0", VA = "0x18A3576C0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA3575E0", Offset = "0xA3561E0", VA = "0x18A3575E0")]
		public void Cancel(DDIPTNQHBGH schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA358B40", Offset = "0xA357740", VA = "0x18A358B40")]
		public void Pause(DDIPTNQHBGH schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA357500", Offset = "0xA356100", VA = "0x18A357500")]
		public void CRBMBLCPEDF(DDIPTNQHBGH a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class Receipt : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly Receipt IYCZABTNUWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Action EGXCDUGOZRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private bool INFOAPNSOCD;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x99B06E0", Offset = "0x99AF2E0", VA = "0x1899B06E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface FNJUMFATBCY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		a YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable WRXKTHOTEQE(UnityEngine.Object a, Action<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface NKKIVTPPYHE<a> : FNJUMFATBCY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		new a YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class DWUSCWPKSZT<a> : NKKIVTPPYHE<a>, FNJUMFATBCY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class JRFIKRCKNGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public DWUSCWPKSZT<a> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public Tuple<UnityEngine.Object, Action<a>> ECDJJVDXUYZ;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public JRFIKRCKNGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x668EB70", Offset = "0x668D770", VA = "0x18668EB70")]
			internal void ERCSZYKPCJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static GameObject LLXIEDXIGYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly List<Tuple<UnityEngine.Object, Action<a>>> XDKWMQSPTYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private a RSAUMCLBEKG;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2A30", VA = "0x180EA3E30", Slot = "5")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x53EF050", Offset = "0x53EDC50", VA = "0x1853EF050", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x53EEFC0", Offset = "0x53EDBC0", VA = "0x1853EEFC0")]
		private static bool LCFVHEHHDJY(a a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x53EF770", Offset = "0x53EE370", VA = "0x1853EF770")]
		public DWUSCWPKSZT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x53EF2C0", Offset = "0x53EDEC0", VA = "0x1853EF2C0", Slot = "6")]
		public IDisposable WRXKTHOTEQE(UnityEngine.Object a, Action<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x53EE4E0", Offset = "0x53ED0E0", VA = "0x1853EE4E0")]
		private void DNDRJGXERXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class WKNGDEOGIAB : ZAWWRGOZLHU
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class AZLEKKEIHYA : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private class PYHUEKXFXRL : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				private int CHFCRKUIPAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private AZLEKKEIHYA XRSJLIPPVGX;

				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x108C5B0", Offset = "0x108B1B0", VA = "0x18108C5B0")]
				public PYHUEKXFXRL(int a, AZLEKKEIHYA b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0xA35EB20", Offset = "0xA35D720", VA = "0x18A35EB20", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class ACFWOTACWWL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public int CHFCRKUIPAB;

				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public ACFWOTACWWL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xF604F0", Offset = "0xF5F0F0", VA = "0x180F604F0")]
				internal bool BSYHWUHRVFE(DPHTBTXWNZR a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class AIPGHHAIQWD : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int NSYFVIOVDQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private NVIJVYVFXPY PGYMGSMZHLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public AZLEKKEIHYA DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public XOOBCRGRVTH IPAFJWBYNGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private CYPGEUCQKIF GMPRENJVAAE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private List<DPHTBTXWNZR> SQOHEVROZRG;

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				private NVIJVYVFXPY YPZFRLKUQEB
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				private object RTHQPUQEOJM
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public AIPGHHAIQWD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xA351B30", Offset = "0xA350730", VA = "0x18A351B30", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xA351AF0", Offset = "0xA3506F0", VA = "0x18A351AF0", Slot = "8")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private readonly ScheduleQueueType EXXXXTBADXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private YDHSMJLFZLP MXZXSYNLTDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private readonly List<DPHTBTXWNZR> VYGEEIDFVGY;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA352EA0", Offset = "0xA351AA0", VA = "0x18A352EA0")]
			public AZLEKKEIHYA(ScheduleQueueType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xA352CD0", Offset = "0xA3518D0", VA = "0x18A352CD0")]
			public IDisposable VQXOIPJZTJP(DPHTBTXWNZR a, EIGPTYHGYCM b, XOOBCRGRVTH c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xA352AC0", Offset = "0xA3516C0", VA = "0x18A352AC0")]
			private void FOWODIIDFDS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xA352C40", Offset = "0xA351840", VA = "0x18A352C40")]
			[IteratorStateMachine(typeof(AIPGHHAIQWD))]
			private IEnumerator<NVIJVYVFXPY> UWVECPMAZLX(XOOBCRGRVTH a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xA352A70", Offset = "0xA351670", VA = "0x18A352A70", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class DPHTBTXWNZR
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
			private static int ELARJCINMJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public readonly int JQCTFOCWOYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public readonly AWBPBYERTJE AEOZTIYAYYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private readonly MonoBehaviour CIGICPRLGZR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public readonly Action YMWGDHQDGEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public readonly Action<float> TVRRGDUSXGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public readonly float HIUAWEERMAV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public float BEHQAJVOXPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public readonly string AZGBUIWNJKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public readonly bool XNJXBXWCOKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public readonly UpdateTypes TVYLUAAUPHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool CLHFQNWVRUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public bool ETWRXEYBFST;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA355880", Offset = "0xA354480", VA = "0x18A355880")]
			public DPHTBTXWNZR(AWBPBYERTJE a, Action b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA355710", Offset = "0xA354310", VA = "0x18A355710")]
			public DPHTBTXWNZR(AWBPBYERTJE a, Action<float> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA355540", Offset = "0xA354140", VA = "0x18A355540")]
			public DPHTBTXWNZR(AWBPBYERTJE a, float b, Action<float> c, XOOBCRGRVTH d, UpdateTypes e, bool f, bool g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xA3552F0", Offset = "0xA353EF0", VA = "0x18A3552F0")]
			public bool PAWDZZADDQE(float a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly EIGPTYHGYCM KWAEVTXZJMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly XOOBCRGRVTH SNXWOZXVAXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<ScheduleQueueType, AZLEKKEIHYA> VEEMOAKRJRH;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA360480", Offset = "0xA35F080", VA = "0x18A360480")]
		[GEPWJNEAFDW.Root]
		internal static void DYFLBUGKMGB(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA360F10", Offset = "0xA35FB10", VA = "0x18A360F10")]
		[UnityEngine.Scripting.Preserve]
		internal WKNGDEOGIAB([Inject(null)] EIGPTYHGYCM scheduler, [Inject(null)] XOOBCRGRVTH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA360D30", Offset = "0xA35F930", VA = "0x18A360D30", Slot = "4")]
		public IDisposable Update(AWBPBYERTJE context, Action callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA360B50", Offset = "0xA35F750", VA = "0x18A360B50", Slot = "5")]
		public IDisposable Update(AWBPBYERTJE context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA360790", Offset = "0xA35F390", VA = "0x18A360790", Slot = "7")]
		public IDisposable JKHCFWAEWJM(AWBPBYERTJE a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA360890", Offset = "0xA35F490", VA = "0x18A360890", Slot = "8")]
		public IDisposable MMGCMKWBCFS(AWBPBYERTJE a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA360620", Offset = "0xA35F220", VA = "0x18A360620", Slot = "6")]
		public IDisposable JKHCFWAEWJM(float a, Action<float> b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA360990", Offset = "0xA35F590", VA = "0x18A360990", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA3604F0", Offset = "0xA35F0F0", VA = "0x18A3604F0")]
		private AZLEKKEIHYA IASYZPOUJOM(ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class FQIMSMPJIOJ : WUSNJLNWOGM, EIGPTYHGYCM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private KEMZWFRBFHE[] ONAFGTISRJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private RXRTLWDJMEC QCIAMDQPUKY;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA356060", Offset = "0xA354C60", VA = "0x18A356060")]
		[GEPWJNEAFDW.Root]
		internal static void RDUKEQTCCWZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA356690", Offset = "0xA355290", VA = "0x18A356690")]
		[UnityEngine.Scripting.Preserve]
		public FQIMSMPJIOJ([Inject(null)] IMVETHGUJYJ unityLifecycleEvents, [Inject(null)] XOOBCRGRVTH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA356560", Offset = "0xA355160", VA = "0x18A356560", Slot = "20")]
		public override YDHSMJLFZLP VGCUWBELPQH(NOHHZXOITKB a, IEnumerator<NVIJVYVFXPY> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA3560D0", Offset = "0xA354CD0", VA = "0x18A3560D0", Slot = "21")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA3559F0", Offset = "0xA3545F0", VA = "0x18A3559F0", Slot = "23")]
		public override void AZLEKKEIHYA(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA356460", Offset = "0xA355060", VA = "0x18A356460", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA356530", Offset = "0xA355130", VA = "0x18A356530")]
		private KEMZWFRBFHE VCCAXOOZLZT(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA355C80", Offset = "0xA354880", VA = "0x18A355C80", Slot = "24")]
		internal override ZNRMNJLAPDD FBSHLDHWOUZ(IEnumerator<NVIJVYVFXPY> a, Behaviour b, MFYSHEZDMOG c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA355E90", Offset = "0xA354A90", VA = "0x18A355E90", Slot = "25")]
		internal override MJYHVPEDXTO LYLKDVSEKNS(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA355F40", Offset = "0xA354B40", VA = "0x18A355F40")]
		private void NDMSEXCVGFL(KEMZWFRBFHE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA355C20", Offset = "0xA354820", VA = "0x18A355C20", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35EEF0", Offset = "0xA35DAF0", VA = "0x18A35EEF0")]
		public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
		{
			return default(ScheduleSortJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA35EF50", Offset = "0xA35DB50", VA = "0x18A35EF50", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA35F3F0", Offset = "0xA35DFF0", VA = "0x18A35F3F0")]
		private bool VZRSRTJUKCC(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA35F3C0", Offset = "0xA35DFC0", VA = "0x18A35F3C0")]
		private void OJHMGQXYQVW(NativeArray<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA35F100", Offset = "0xA35DD00", VA = "0x18A35F100")]
		private int MDHTFABXKHF(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA35F030", Offset = "0xA35DC30", VA = "0x18A35F030")]
		private void FNFPQHFVTDE(NativeArray<int> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA35F180", Offset = "0xA35DD80", VA = "0x18A35F180")]
		private void Merge(NativeArray<int> arr, int leftStart, int middle, int rightEnd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class WUSNJLNWOGM : EIGPTYHGYCM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class TUWMLQHCVLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private sealed class MBRSLIPDEQU : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private int NSYFVIOVDQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private NVIJVYVFXPY PGYMGSMZHLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public TUWMLQHCVLH DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				private NVIJVYVFXPY YPZFRLKUQEB
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				private object RTHQPUQEOJM
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public MBRSLIPDEQU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0xA359E40", Offset = "0xA358A40", VA = "0x18A359E40", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xA359E00", Offset = "0xA358A00", VA = "0x18A359E00", Slot = "8")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public WUSNJLNWOGM DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public float UGBWVKUXDFX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public ScheduleQueueType XRSJLIPPVGX;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public TUWMLQHCVLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA35FBA0", Offset = "0xA35E7A0", VA = "0x18A35FBA0")]
			[IteratorStateMachine(typeof(MBRSLIPDEQU))]
			internal IEnumerator<NVIJVYVFXPY> IPHIPTZYRFM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly IMVETHGUJYJ KVVIJTHLLUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		protected readonly XOOBCRGRVTH SNXWOZXVAXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private MJYHVPEDXTO[] WUAAQAACGLO;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static EIGPTYHGYCM UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xA361AB0", Offset = "0xA3606B0", VA = "0x18A361AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ScheduleQueueType LENZHWFPAXI
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ScheduleQueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0640", VA = "0x180CF1A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public XOOBCRGRVTH TQBGLRZHWUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public NVIJVYVFXPY NEUDPLFIZUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public NVIJVYVFXPY CDQGXOQCRPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public NVIJVYVFXPY JCEIKNPHQAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public NVIJVYVFXPY STLRDTKIJTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA361790", Offset = "0xA360390", VA = "0x18A361790")]
		public static YDHSMJLFZLP EOZMKLWZAMW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA361F70", Offset = "0xA360B70", VA = "0x18A361F70")]
		[UnityEngine.Scripting.Preserve]
		protected WUSNJLNWOGM([Inject(null)] IMVETHGUJYJ unityLifecycleEvents, [Inject(null)] XOOBCRGRVTH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA361D10", Offset = "0xA360910", VA = "0x18A361D10", Slot = "6")]
		public YDHSMJLFZLP Run(IEnumerator<NVIJVYVFXPY> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA361D20", Offset = "0xA360920", VA = "0x18A361D20", Slot = "7")]
		public YDHSMJLFZLP Run(Behaviour context, IEnumerator<NVIJVYVFXPY> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract YDHSMJLFZLP VGCUWBELPQH(NOHHZXOITKB a, IEnumerator<NVIJVYVFXPY> b);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA361BA0", Offset = "0xA3607A0", VA = "0x18A361BA0", Slot = "21")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA361190", Offset = "0xA35FD90", VA = "0x18A361190", Slot = "9")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA361EF0", Offset = "0xA360AF0", VA = "0x18A361EF0", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA361B20", Offset = "0xA360720", VA = "0x18A361B20")]
		private void QULIQCMMXTA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA3613F0", Offset = "0xA35FFF0", VA = "0x18A3613F0")]
		private void DYBCUVFQURK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA361820", Offset = "0xA360420", VA = "0x18A361820")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA361A10", Offset = "0xA360610", VA = "0x18A361A10")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA3613D0", Offset = "0xA35FFD0", VA = "0x18A3613D0")]
		private void DQDTVKOEWVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA361150", Offset = "0xA35FD50", VA = "0x18A361150")]
		private void CTSSKRDURCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA361170", Offset = "0xA35FD70", VA = "0x18A361170")]
		private void CUXLRAYZHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA360FD0", Offset = "0xA35FBD0", VA = "0x18A360FD0", Slot = "23")]
		public virtual void AZLEKKEIHYA(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA361840", Offset = "0xA360440", VA = "0x18A361840")]
		private void KDROJMMTWWP(MJYHVPEDXTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2A1ECD0", Offset = "0x2A1D8D0", VA = "0x182A1ECD0")]
		private MJYHVPEDXTO YPWPBSLMUBZ(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "24")]
		internal abstract ZNRMNJLAPDD FBSHLDHWOUZ(IEnumerator<NVIJVYVFXPY> a, Behaviour b, MFYSHEZDMOG c);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "25")]
		internal abstract MJYHVPEDXTO LYLKDVSEKNS(ScheduleQueueType a);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA361410", Offset = "0xA360010", VA = "0x18A361410", Slot = "26")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA361B40", Offset = "0xA360740", VA = "0x18A361B40", Slot = "15")]
		public NVIJVYVFXPY RHTOTKRXNUM(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA361A30", Offset = "0xA360630", VA = "0x18A361A30", Slot = "16")]
		public NVIJVYVFXPY MQEAISSGYGV(float a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA361060", Offset = "0xA35FC60", VA = "0x18A361060", Slot = "17")]
		public YDHSMJLFZLP CQSKYZRLDRC(float a, ScheduleQueueType b = ScheduleQueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA361F10", Offset = "0xA360B10", VA = "0x18A361F10", Slot = "18")]
		public NVIJVYVFXPY YOVFHKLTEEY(Func<bool> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal sealed class ZNRMNJLAPDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly MFYSHEZDMOG MXZXSYNLTDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly BTWUXUFIUID SZKFOUDUREX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly bool BQUJKDVJNYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private string ACBKEEQTANZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private StackTrace YOBBILYRVKR;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerator<NVIJVYVFXPY> KRGUTLXBRLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public NVIJVYVFXPY ZCXAPPLKNDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool HGZHUMHDMEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA362D20", Offset = "0xA361920", VA = "0x18A362D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool YKVCEYSQSAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xD94380", Offset = "0xD92F80", VA = "0x180D94380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xE76F00", Offset = "0xE75B00", VA = "0x180E76F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA362850", Offset = "0xA361450", VA = "0x18A362850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float HCUAJTQZYMP
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xF1C510", Offset = "0xF1B110", VA = "0x180F1C510")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xF1C520", Offset = "0xF1B120", VA = "0x180F1C520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA362EF0", Offset = "0xA361AF0", VA = "0x18A362EF0")]
		public ZNRMNJLAPDD(IEnumerator<NVIJVYVFXPY> a, BTWUXUFIUID b, MFYSHEZDMOG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA362A00", Offset = "0xA361600", VA = "0x18A362A00")]
		public NVIJVYVFXPY OTNHODRRPZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA362E80", Offset = "0xA361A80", VA = "0x18A362E80")]
		public bool ZDYEOTKZKKG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA362800", Offset = "0xA361400", VA = "0x18A362800")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA362DA0", Offset = "0xA3619A0", VA = "0x18A362DA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xF3B2E0", Offset = "0xF39EE0", VA = "0x180F3B2E0")]
		[CompilerGenerated]
		private void EZPGQYYIZSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class MFYSHEZDMOG : FLVJWJHSBGP, YDHSMJLFZLP, ZSWOFHRQHTQ, GMTKWIVSBCA, IEnumerator, NVIJVYVFXPY, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private ScheduleQueueType FLWWKJCKBKY;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private ScheduleQueueType MVWPLHKKPXN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x10C2A00", Offset = "0x10C1600", VA = "0x1810C2A00", Slot = "23")]
			get
			{
				return default(ScheduleQueueType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ScheduleQueueType KSPHNULACNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x10C2440", Offset = "0x10C1040", VA = "0x1810C2440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private float FWZWZUOARYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xD3F500", Offset = "0xD3E100", VA = "0x180D3F500", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool UQZUKICHXPO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA35A110", Offset = "0xA358D10", VA = "0x18A35A110", Slot = "24")]
		private bool GUAZUTSWMUP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA35A100", Offset = "0xA358D00", VA = "0x18A35A100", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA35A130", Offset = "0xA358D30", VA = "0x18A35A130")]
		public MFYSHEZDMOG()
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
	internal sealed class MJYHVPEDXTO : IDisposable
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
			public List<ZNRMNJLAPDD> Coroutines;
		}

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static readonly SubQueue[] OJYZTOWFXSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ScheduleQueueType EXXXXTBADXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private bool JIGAQHGQPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly ZNRMNJLAPDD[] NIBFFSUQRDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly List<ZNRMNJLAPDD> ZREJSRTWMZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly Stack<int> ZZFWULVDSIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<ZNRMNJLAPDD> ILLXBGJQERK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Stack<int> WZYIBYTPNUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly RXRTLWDJMEC QFLUIKRBEUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private bool QDNWQXVJNWG;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ReinsertBuffer[,] TDMRNVYVPVR
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA35B680", Offset = "0xA35A280", VA = "0x18A35B680")]
		public MJYHVPEDXTO(ScheduleQueueType a, RXRTLWDJMEC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA35B350", Offset = "0xA359F50", VA = "0x18A35B350")]
		public void VHLPTPLARJT(ZNRMNJLAPDD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA35A180", Offset = "0xA358D80", VA = "0x18A35A180")]
		public void BWLGVWGAYNZ(IList<ZNRMNJLAPDD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA35ABA0", Offset = "0xA3597A0", VA = "0x18A35ABA0")]
		public void RRFZWTGENMT(IList<ZNRMNJLAPDD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA35B410", Offset = "0xA35A010", VA = "0x18A35B410")]
		private void XUJMRUGKXZI(ZNRMNJLAPDD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA35AA20", Offset = "0xA359620", VA = "0x18A35AA20")]
		private void RDCIARMJUUS(IList<ZNRMNJLAPDD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA35A8B0", Offset = "0xA3594B0", VA = "0x18A35A8B0")]
		private TickResult GUOZQXQGLZH(ZNRMNJLAPDD a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA35B1E0", Offset = "0xA359DE0", VA = "0x18A35B1E0")]
		public void Update(float currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA35A460", Offset = "0xA359060", VA = "0x18A35A460")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA35AE80", Offset = "0xA359A80", VA = "0x18A35AE80")]
		private void SZJDBYBSHLZ(List<ZNRMNJLAPDD> a, Stack<int> b, bool c, float d = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA35A650", Offset = "0xA359250", VA = "0x18A35A650", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA35A770", Offset = "0xA359370", VA = "0x18A35A770")]
		private void GNTEQKJBCKJ(List<ZNRMNJLAPDD> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class ZNJVNGKONUY : RXRTLWDJMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
		public void SNGVOHWMBYT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
		public void NSSGIHSZVJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public ZNJVNGKONUY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class PYIBMLRLLYR : BTWUXUFIUID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly Behaviour GAARZFPEYGP;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA35EB70", Offset = "0xA35D770", VA = "0x18A35EB70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool CZNZYGZCSPU
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA35EBF0", Offset = "0xA35D7F0", VA = "0x18A35EBF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool TDQCPOHGXRC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA35EB50", Offset = "0xA35D750", VA = "0x18A35EB50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public PYIBMLRLLYR(Behaviour a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3869927814
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0xA363470", Offset = "0xA362070", VA = "0x18A363470")]
	public static void JUZPHBOHHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xA363460", Offset = "0xA362060", VA = "0x18A363460")]
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
