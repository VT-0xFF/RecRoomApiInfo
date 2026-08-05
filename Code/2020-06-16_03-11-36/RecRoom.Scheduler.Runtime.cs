using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Analytics;
using RecRoom.Async;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Experimental.LowLevel;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IJobbedSchedulerContext
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ActionEvent OnDestroyed
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ActionEvent OnEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ActionEvent OnDisabled
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IsActiveAndEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool IsDestroyed
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private delegate List<PlayerLoopSystem> SubsystemListModification(List<PlayerLoopSystem> systems, int subsystemIndex);

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct CustomSystems
		{
			[Cpp2IlInjected.Token(Token = "0x2000040")]
			public struct PostUpdateSystem
			{
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public static ActionEvent OnPostUpdate;

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x2CDB4F0", Offset = "0x2CD9AF0", VA = "0x182CDB4F0")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000041")]
			public struct RigidbodyExLateUpdateSystem
			{
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public static ActionEvent OnRigidbodyExLateUpdate;

				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x2CDBB30", Offset = "0x2CDA130", VA = "0x182CDBB30")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			public struct PreRenderSystem
			{
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public static ActionEvent OnPreRenderUpdate;

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x2CDB690", Offset = "0x2CD9C90", VA = "0x182CDB690")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			internal struct WrapperPreSystem
			{
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x2CE5940", Offset = "0x2CE3F40", VA = "0x182CE5940")]
				public static PlayerLoopSystem GetNewSystem(TimerAnalytics.WrapperKey key)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000044")]
			internal struct WrapperPostSystem
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x2CE5840", Offset = "0x2CE3E40", VA = "0x182CE5840")]
				public static PlayerLoopSystem GetNewSystem(TimerAnalytics.WrapperKey key)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _injected;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool Injected
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2CD6FE0", Offset = "0x2CD55E0", VA = "0x182CD6FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2CD7020", Offset = "0x2CD5620", VA = "0x182CD7020")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2CD5AA0", Offset = "0x2CD40A0", VA = "0x182CD5AA0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6D80", Offset = "0x2CD5380", VA = "0x182CD6D80")]
		private static void TryTimerWrapSubSystem(TimerAnalytics.WrapperKey key, ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6900", Offset = "0x2CD4F00", VA = "0x182CD6900")]
		private static void ModifySubsystemList(ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType, SubsystemListModification subsystemListModification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6C80", Offset = "0x2CD5280", VA = "0x182CD6C80")]
		private static void TryInsertSystems(ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType, PlayerLoopSystem? before, PlayerLoopSystem? after)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class TimerAnalytics
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public enum WrapperKey
		{
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			SchedulerUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			PreRenderUpdate,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			PhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			PhysicsUpdate,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			SendFrameStarted,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			FinishFrameRendering,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			PhysicsResetInterpolatedPosition,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			FullPlayerLoop
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public class CallWrapper
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public readonly WrapperKey WrapperKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private Stopwatch stopwatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public readonly RollingBufferAverageStats AverageStats;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private long startTicks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private long endTicks;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2CD59A0", Offset = "0x2CD3FA0", VA = "0x182CD59A0")]
			public CallWrapper(WrapperKey wrapperKey, int bufferSize = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2CD5980", Offset = "0x2CD3F80", VA = "0x182CD5980")]
			public void SetBufferLength(int bufferLength)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2CD58C0", Offset = "0x2CD3EC0", VA = "0x182CD58C0")]
			public void ResetTimer()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2CD5890", Offset = "0x2CD3E90", VA = "0x182CD5890")]
			public void RegisterStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x2CD5740", Offset = "0x2CD3D40", VA = "0x182CD5740")]
			public void RegisterEnd()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const int DEFAULT_BUFFER_SIZE = 90;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public static WrapperKey[] WrapperKeys;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static CallWrapper[] _callWrappers;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE38F0", Offset = "0x2CE1EF0", VA = "0x182CE38F0")]
		public static CallWrapper CreateWrapper(WrapperKey key, int bufferSize = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3AB0", Offset = "0x2CE20B0", VA = "0x182CE3AB0")]
		public static CallWrapper GetWrapper(WrapperKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3B40", Offset = "0x2CE2140", VA = "0x182CE3B40")]
		public static void ResetAllWrappers()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface IJobbedSchedulerCoroutine
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ISchedulerPromise : ICancelablePromise, IPromise, IEnumerator, ISchedule, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class Receipt : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Receipt Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Action onDispose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool disposed;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B60", Offset = "0x3A8160", VA = "0x1803A9B60")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBA40", Offset = "0x2CDA040", VA = "0x182CDBA40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface IReadOnlyReactiveProperty<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable Observe(Action<T> onValueChanged);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IDisposable Observe(UnityEngine.Object context, Action<T> onValueChanged);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface IReactiveProperty<T> : IReadOnlyReactiveProperty<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		new T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ReactiveProperty<T> : IReactiveProperty<T>, IReadOnlyReactiveProperty<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static GameObject _defaultContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Tuple<UnityEngine.Object, Action<T>>> observers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private T _value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static UnityEngine.Object DefaultContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1AE1F40", Offset = "0x1AE0540", VA = "0x181AE1F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x4E2AE0", Offset = "0x4E10E0", VA = "0x1804E2AE0", Slot = "6")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1AE2360", Offset = "0x1AE0960", VA = "0x181AE2360", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1AE1410", Offset = "0x1ADFA10", VA = "0x181AE1410")]
		private static bool AreEqual(T a, T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1AE1E80", Offset = "0x1AE0480", VA = "0x181AE1E80")]
		public ReactiveProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1AE1EB0", Offset = "0x1AE04B0", VA = "0x181AE1EB0")]
		public ReactiveProperty(T initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1AE1480", Offset = "0x1ADFA80", VA = "0x181AE1480")]
		public void ForceUpdate(T newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1AE1B00", Offset = "0x1AE0100", VA = "0x181AE1B00", Slot = "7")]
		public IDisposable Observe(Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1AE1CB0", Offset = "0x1AE02B0", VA = "0x181AE1CB0", Slot = "8")]
		public IDisposable Observe(UnityEngine.Object context, Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1AE17E0", Offset = "0x1ADFDE0", VA = "0x181AE17E0")]
		private void NotifyObservers()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class Schedule
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class <Example>d__8 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000101")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <Example>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x2CE3ED0", Offset = "0x2CE24D0", VA = "0x182CE3ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2CE3FC0", Offset = "0x2CE25C0", VA = "0x182CE3FC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly ISchedule NextFrame;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly ISchedule NextFixedUpdate;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly ISchedule NextLateUpdate;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public static readonly ISchedule NextEndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public static readonly ISchedule NextPreRender;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD560", Offset = "0x2CDBB60", VA = "0x182CDD560")]
		public static ISchedule Wait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD500", Offset = "0x2CDBB00", VA = "0x182CDD500")]
		public static ISchedule Until(Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD400", Offset = "0x2CDBA00", VA = "0x182CDD400")]
		public static ISchedule AfterCompleted(IPromise promise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD4B0", Offset = "0x2CDBAB0", VA = "0x182CDD4B0")]
		[IteratorStateMachine(typeof(<Example>d__8))]
		public static IEnumerator<ISchedule> Example()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface ISchedule
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Ready();
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class ScheduledUpdate : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class <RequeueFromErrorNextFrame>d__13 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public Action requeueAction;

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2CE4120", Offset = "0x2CE2720", VA = "0x182CE4120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2CE4280", Offset = "0x2CE2880", VA = "0x182CE4280", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ISchedulerPromise activeRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MonoBehaviour behaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Action<float> updateWithTimeParameter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Scheduler.QueueType queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float updateHz;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0090", Offset = "0x2CDE690", VA = "0x182CE0090")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0260", Offset = "0x2CDE860", VA = "0x182CE0260")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE0430", Offset = "0x2CDEA30", VA = "0x182CE0430")]
		public ScheduledUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2CDFBE0", Offset = "0x2CDE1E0", VA = "0x182CDFBE0")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2CDFA20", Offset = "0x2CDE020", VA = "0x182CDFA20")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF8F0", Offset = "0x2CDDEF0", VA = "0x182CDF8F0")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2CDFE00", Offset = "0x2CDE400", VA = "0x182CDFE00")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2CDFDA0", Offset = "0x2CDE3A0", VA = "0x182CDFDA0")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF8A0", Offset = "0x2CDDEA0", VA = "0x182CDF8A0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class ScheduledUpdateMonoBehaviourExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF4C0", Offset = "0x2CDDAC0", VA = "0x182CDF4C0")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF440", Offset = "0x2CDDA40", VA = "0x182CDF440")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF830", Offset = "0x2CDDE30", VA = "0x182CDF830")]
		public static IDisposable Update(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF050", Offset = "0x2CDD650", VA = "0x182CDF050")]
		public static IDisposable FixedUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF2D0", Offset = "0x2CDD8D0", VA = "0x182CDF2D0")]
		public static IDisposable LateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF540", Offset = "0x2CDDB40", VA = "0x182CDF540")]
		public static IDisposable RigidbodyExLateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF340", Offset = "0x2CDD940", VA = "0x182CDF340")]
		public static IDisposable PreRenderUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF3B0", Offset = "0x2CDD9B0", VA = "0x182CDF3B0")]
		public static IDisposable QueueUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF7B0", Offset = "0x2CDDDB0", VA = "0x182CDF7B0")]
		public static IDisposable UpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF6B0", Offset = "0x2CDDCB0", VA = "0x182CDF6B0")]
		public static IDisposable Update30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF5B0", Offset = "0x2CDDBB0", VA = "0x182CDF5B0")]
		public static IDisposable Update10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF730", Offset = "0x2CDDD30", VA = "0x182CDF730")]
		public static IDisposable Update5hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF630", Offset = "0x2CDDC30", VA = "0x182CDF630")]
		public static IDisposable Update1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEFC0", Offset = "0x2CDD5C0", VA = "0x182CDEFC0")]
		public static IDisposable FixedUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEF40", Offset = "0x2CDD540", VA = "0x182CDEF40")]
		public static IDisposable FixedUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEE40", Offset = "0x2CDD440", VA = "0x182CDEE40")]
		public static IDisposable FixedUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEEC0", Offset = "0x2CDD4C0", VA = "0x182CDEEC0")]
		public static IDisposable FixedUpdate1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF240", Offset = "0x2CDD840", VA = "0x182CDF240")]
		public static IDisposable LateUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF1C0", Offset = "0x2CDD7C0", VA = "0x182CDF1C0")]
		public static IDisposable LateUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF0C0", Offset = "0x2CDD6C0", VA = "0x182CDF0C0")]
		public static IDisposable LateUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF140", Offset = "0x2CDD740", VA = "0x182CDF140")]
		public static IDisposable LateUpdate1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class ScheduledJobbedUpdate : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class <RequeueFromErrorNextFrame>d__13 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Action requeueAction;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2CE41D0", Offset = "0x2CE27D0", VA = "0x182CE41D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2CE42D0", Offset = "0x2CE28D0", VA = "0x182CE42D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private ISchedulerPromise activeRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private IJobbedSchedulerContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Action<float> updateWithTimeParameter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Scheduler.QueueType queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float updateHz;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2CDDF60", Offset = "0x2CDC560", VA = "0x182CDDF60")]
		public ScheduledJobbedUpdate(IJobbedSchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE130", Offset = "0x2CDC730", VA = "0x182CDE130")]
		public ScheduledJobbedUpdate(IJobbedSchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE300", Offset = "0x2CDC900", VA = "0x182CDE300")]
		public ScheduledJobbedUpdate(IJobbedSchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2CDDAA0", Offset = "0x2CDC0A0", VA = "0x182CDDAA0")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD8E0", Offset = "0x2CDBEE0", VA = "0x182CDD8E0")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD7B0", Offset = "0x2CDBDB0", VA = "0x182CDD7B0")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2CDDCC0", Offset = "0x2CDC2C0", VA = "0x182CDDCC0")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2CDDC60", Offset = "0x2CDC260", VA = "0x182CDDC60")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD760", Offset = "0x2CDBD60", VA = "0x182CDD760", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class ScheduledUpdateContextExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEA60", Offset = "0x2CDD060", VA = "0x182CDEA60")]
		public static IDisposable QueueUpdateJobbed(this IJobbedSchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEAE0", Offset = "0x2CDD0E0", VA = "0x182CDEAE0")]
		public static IDisposable QueueUpdateJobbed(this IJobbedSchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEDD0", Offset = "0x2CDD3D0", VA = "0x182CDEDD0")]
		public static IDisposable UpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE670", Offset = "0x2CDCC70", VA = "0x182CDE670")]
		public static IDisposable FixedUpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE8F0", Offset = "0x2CDCEF0", VA = "0x182CDE8F0")]
		public static IDisposable LateUpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEB60", Offset = "0x2CDD160", VA = "0x182CDEB60")]
		public static IDisposable RigidbodyExLateUpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE960", Offset = "0x2CDCF60", VA = "0x182CDE960")]
		public static IDisposable PreRenderUpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE9D0", Offset = "0x2CDCFD0", VA = "0x182CDE9D0")]
		public static IDisposable QueueUpdateAtRateJobbed(this IJobbedSchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2CDED50", Offset = "0x2CDD350", VA = "0x182CDED50")]
		public static IDisposable UpdateAtRateJobbed(this IJobbedSchedulerContext context, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2CDECD0", Offset = "0x2CDD2D0", VA = "0x182CDECD0")]
		public static IDisposable Update30hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEBD0", Offset = "0x2CDD1D0", VA = "0x182CDEBD0")]
		public static IDisposable Update10hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2CDEC50", Offset = "0x2CDD250", VA = "0x182CDEC50")]
		public static IDisposable Update1hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE5E0", Offset = "0x2CDCBE0", VA = "0x182CDE5E0")]
		public static IDisposable FixedUpdateAtRateJobbed(this IJobbedSchedulerContext context, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE560", Offset = "0x2CDCB60", VA = "0x182CDE560")]
		public static IDisposable FixedUpdate30hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE460", Offset = "0x2CDCA60", VA = "0x182CDE460")]
		public static IDisposable FixedUpdate10hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE4E0", Offset = "0x2CDCAE0", VA = "0x182CDE4E0")]
		public static IDisposable FixedUpdate1hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE860", Offset = "0x2CDCE60", VA = "0x182CDE860")]
		public static IDisposable LateUpdateAtRateJobbed(this IJobbedSchedulerContext context, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE7E0", Offset = "0x2CDCDE0", VA = "0x182CDE7E0")]
		public static IDisposable LateUpdate30hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE6E0", Offset = "0x2CDCCE0", VA = "0x182CDE6E0")]
		public static IDisposable LateUpdate10hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDE760", Offset = "0x2CDCD60", VA = "0x182CDE760")]
		public static IDisposable LateUpdate1hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class ScheduleNextFrame : ISchedule
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class <UpdateCoroutine>d__14 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public Action update;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private ScheduleNextFrame <schedule>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x2CE51E0", Offset = "0x2CE37E0", VA = "0x182CE51E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2CE52B0", Offset = "0x2CE38B0", VA = "0x182CE52B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class <UpdateCoroutine>d__15 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public Action<float> update;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private ScheduleNextFrame <schedule>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2CE5300", Offset = "0x2CE3900", VA = "0x182CE5300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2CE53F0", Offset = "0x2CE39F0", VA = "0x182CE53F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A8490", VA = "0x1803A9E90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A8420", VA = "0x1803A9E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x66CAA0", Offset = "0x66B0A0", VA = "0x18066CAA0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
		public ScheduleNextFrame(Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3BE210", Offset = "0x3BC810", VA = "0x1803BE210", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC250", Offset = "0x2CDA850", VA = "0x182CDC250")]
		public static ISchedulerPromise QueueUpdate(Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC610", Offset = "0x2CDAC10", VA = "0x182CDC610")]
		public static ISchedulerPromise QueueUpdate(Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC4D0", Offset = "0x2CDAAD0", VA = "0x182CDC4D0")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC390", Offset = "0x2CDA990", VA = "0x182CDC390")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBFD0", Offset = "0x2CDA5D0", VA = "0x182CDBFD0")]
		public static ISchedulerPromise QueueUpdateJobbed(IJobbedSchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC110", Offset = "0x2CDA710", VA = "0x182CDC110")]
		public static ISchedulerPromise QueueUpdateJobbed(IJobbedSchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC750", Offset = "0x2CDAD50", VA = "0x182CDC750")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__14))]
		private static IEnumerator<ISchedule> UpdateCoroutine(Scheduler.QueueType queue, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC7C0", Offset = "0x2CDADC0", VA = "0x182CDC7C0")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__15))]
		private static IEnumerator<ISchedule> UpdateCoroutine(Scheduler.QueueType queue, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class Scheduler : SingletonMonoBehaviour<Scheduler>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum QueueType
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			PreRender,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			EndOfFrame
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[Flags]
		public enum CoroutineState : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private class JobbedSchedulerCoroutine : IJobbedSchedulerCoroutine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public JobbedSchedulerQueue Queue;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public int Index
			{
				[Cpp2IlInjected.Token(Token = "0x600011C")]
				[Cpp2IlInjected.Address(RVA = "0x3A9E90", Offset = "0x3A8490", VA = "0x1803A9E90", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0x3A9E20", Offset = "0x3A8420", VA = "0x1803A9E20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2CD87B0", Offset = "0x2CD6DB0", VA = "0x182CD87B0")]
			public static ISchedule Step(IEnumerator<ISchedule> coroutine, SchedulerPromise promise)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8900", Offset = "0x2CD6F00", VA = "0x182CD8900")]
			public ISchedule Step(SchedulerPromise[] allScheduledPromises, IEnumerator<ISchedule>[] coroutines, ISchedule[] currentSchedules)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8600", Offset = "0x2CD6C00", VA = "0x182CD8600")]
			public void OnContextDestroyed()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2CD86F0", Offset = "0x2CD6CF0", VA = "0x182CD86F0")]
			public void OnContextEnabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8630", Offset = "0x2CD6C30", VA = "0x182CD8630")]
			public void OnContextDisabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8600", Offset = "0x2CD6C00", VA = "0x182CD8600")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3816F0", VA = "0x1803830F0")]
			public JobbedSchedulerCoroutine()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class JobbedSchedulerQueue
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			public struct JobbedInsertionData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public JobbedSchedulerCoroutine Routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public IJobbedSchedulerContext Context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public SchedulerPromise Promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public IEnumerator<ISchedule> Coroutine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public ISchedule CurrentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public CoroutineState CoroutineState;
			}

			[Cpp2IlInjected.Token(Token = "0x2000046")]
			public struct JobbedReinsertBuffer
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public QueueType QueueType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public List<JobbedInsertionData> Insertions;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private readonly QueueType queueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private bool[] mainThreadCancels;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private NativeArray<CoroutineState> sharedCoroutineStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private NativeArray<float> NextUpdateTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private NativeArray<int> NumberToExecute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private NativeArray<int> UnsortedIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private NativeArray<int> SortedIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private NativeArray<int> MergeSortScratchLeft;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private NativeArray<int> MergeSortScratchRight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private JobbedSchedulerCoroutine[] allJobbedSchedulerJobbedRoutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private SchedulerPromise[] allScheduledPromises;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private IJobbedSchedulerContext[] allContexts;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private IEnumerator<ISchedule>[] allCoroutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private ISchedule[] allCurrentSchedules;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int coroutineCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int capacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private readonly int initialCapacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private float nextScaleDownArraySizeTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private ScheduleSortJob queueSortJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private JobHandle sortJobHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private List<JobbedSchedulerCoroutine> queuedRemoves;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private bool jobInProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private List<Action> queuedCoroutineStateChanges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private List<Action> queuedAddRemoveActions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private bool _disposed;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public JobbedReinsertBuffer[] JobbedReinsertionQueues
			{
				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x445FC0", Offset = "0x4445C0", VA = "0x180445FC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8EB0", Offset = "0x2CD74B0", VA = "0x182CD8EB0")]
			private static int GetInitialCapacity(QueueType queueType)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x2CDA760", Offset = "0x2CD8D60", VA = "0x182CDA760")]
			public JobbedSchedulerQueue(QueueType queueType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x2CD9DC0", Offset = "0x2CD83C0", VA = "0x182CD9DC0")]
			private void ResizeArrays(ref int oldCapacity, int newCapacity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8EE0", Offset = "0x2CD74E0", VA = "0x182CD8EE0")]
			public void InsertJobbedSchedulerCoroutine(IJobbedSchedulerContext context, ISchedule currentSchedule, IEnumerator<ISchedule> coroutine, SchedulerPromise promise, [Optional] JobbedSchedulerCoroutine routine, CoroutineState coroutineState = CoroutineState.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2CD9010", Offset = "0x2CD7610", VA = "0x182CD9010")]
			public void Insert(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2CD9980", Offset = "0x2CD7F80", VA = "0x182CD9980")]
			private JobbedInsertionData RemoveSchedulerCoroutine(int indexToRemove)
			{
				return default(JobbedInsertionData);
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8A90", Offset = "0x2CD7090", VA = "0x182CD8A90")]
			private void CleanupAllContexts()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xE1CD00", Offset = "0xE1B300", VA = "0x180E1CD00")]
			private static void SwapBackFill<T>(int indexToRemove, T[] myArray, int size, [Optional] T fillValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xE1CCE0", Offset = "0xE1B2E0", VA = "0x180E1CCE0")]
			private static void SwapBackFill<T>(int indexToRemove, NativeArray<T> myArray, int size, [Optional] T fillValue) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x2CD96A0", Offset = "0x2CD7CA0", VA = "0x182CD96A0")]
			private void QueueMultipleForInsertion(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x2CD93F0", Offset = "0x2CD79F0", VA = "0x182CD93F0")]
			private void QueueForReinsertJobbed(JobbedInsertionData jobbedInsertionData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x2CD9F50", Offset = "0x2CD8550", VA = "0x182CD9F50")]
			private TickResult TickJobbedCoroutine(int scheduleIndex)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x2CD94C0", Offset = "0x2CD7AC0", VA = "0x182CD94C0")]
			public void QueueJob(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2CD92F0", Offset = "0x2CD78F0", VA = "0x182CD92F0")]
			private void QueueAddRemoveAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2CD9370", Offset = "0x2CD7970", VA = "0x182CD9370")]
			private void QueueCoroutineStateChangeAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x2CDA2C0", Offset = "0x2CD88C0", VA = "0x182CDA2C0")]
			public void UpdateJobSortedCoroutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x2CD8DD0", Offset = "0x2CD73D0", VA = "0x182CD8DD0")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x2CD89E0", Offset = "0x2CD6FE0", VA = "0x182CD89E0")]
			public void Cancel(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x2CD9240", Offset = "0x2CD7840", VA = "0x182CD9240")]
			public void Pause(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x2CDA210", Offset = "0x2CD8810", VA = "0x182CDA210")]
			public void Unpause(JobbedSchedulerCoroutine schedule)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private sealed class SchedulerCoroutine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private readonly SchedulerPromise promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private readonly Behaviour context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private readonly bool wasCreatedWithContext;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public IEnumerator<ISchedule> Coroutine
			{
				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A3210", VA = "0x1803A4C10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x3832E0", Offset = "0x3818E0", VA = "0x1803832E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public ISchedule CurrentSchedule
			{
				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3927A0", VA = "0x1803941A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public bool Paused
			{
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x2CE0A10", Offset = "0x2CDF010", VA = "0x182CE0A10")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public bool Canceled
			{
				[Cpp2IlInjected.Token(Token = "0x600013F")]
				[Cpp2IlInjected.Address(RVA = "0x705640", Offset = "0x703C40", VA = "0x180705640")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000140")]
				[Cpp2IlInjected.Address(RVA = "0xAE3790", Offset = "0xAE1D90", VA = "0x180AE3790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x390F70", Offset = "0x38F570", VA = "0x180390F70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0x430690", Offset = "0x42EC90", VA = "0x180430690")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public float NextUpdateKey
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x406770", Offset = "0x404D70", VA = "0x180406770")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x406590", Offset = "0x404B90", VA = "0x180406590")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0890", Offset = "0x2CDEE90", VA = "0x182CE0890")]
			public SchedulerCoroutine(IEnumerator<ISchedule> coroutine, Behaviour context, SchedulerPromise promise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0620", Offset = "0x2CDEC20", VA = "0x182CE0620")]
			public ISchedule Step()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0590", Offset = "0x2CDEB90", VA = "0x182CE0590")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x2CE07F0", Offset = "0x2CDEDF0", VA = "0x182CE07F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private sealed class SchedulerPromise : CancelablePromise, ISchedulerPromise, ICancelablePromise, IPromise, IEnumerator, ISchedule, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private QueueType _queue;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			QueueType ISchedule.Queue
			{
				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0x4A0C00", Offset = "0x49F200", VA = "0x1804A0C00", Slot = "22")]
				get
				{
					return default(QueueType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public QueueType Queue
			{
				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x4A0C00", Offset = "0x49F200", VA = "0x1804A0C00")]
				get
				{
					return default(QueueType);
				}
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0x6506B0", Offset = "0x64ECB0", VA = "0x1806506B0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			float ISchedule.NextPossibleReady
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x66CAA0", Offset = "0x66B0A0", VA = "0x18066CAA0", Slot = "24")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0AB0", Offset = "0x2CDF0B0", VA = "0x182CE0AB0", Slot = "23")]
			bool ISchedule.Ready()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0AA0", Offset = "0x2CDF0A0", VA = "0x182CE0AA0", Slot = "25")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0AC0", Offset = "0x2CDF0C0", VA = "0x182CE0AC0")]
			public SchedulerPromise()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private enum TickResult : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class SchedulerQueue : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public enum SubQueue
			{
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			public struct ReinsertBuffer
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public QueueType QueueType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public SubQueue SubQueue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public List<SchedulerCoroutine> Coroutines;
			}

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private static readonly SubQueue[] subQueueTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private readonly QueueType queueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private bool lockedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private readonly SchedulerCoroutine[] singleCoroutineArrayBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private readonly List<SchedulerCoroutine> immediateCoroutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private readonly Stack<int> immediateUpdateHoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private readonly List<SchedulerCoroutine> futureCoroutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private readonly Stack<int> futureUpdateHoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private readonly List<SchedulerCoroutine> toRemoveBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private bool _disposed;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public ReinsertBuffer[,] ReinsertBuffers
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x3B12D0", Offset = "0x3AF8D0", VA = "0x1803B12D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1E00", Offset = "0x2CE0400", VA = "0x182CE1E00")]
			public SchedulerQueue(QueueType queue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1750", Offset = "0x2CDFD50", VA = "0x182CE1750")]
			public void LogFutureRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1760", Offset = "0x2CDFD60", VA = "0x182CE1760")]
			public void LogImmediateRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1770", Offset = "0x2CDFD70", VA = "0x182CE1770")]
			private void LogRoutines(IReadOnlyList<SchedulerCoroutine> routines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1660", Offset = "0x2CDFC60", VA = "0x182CE1660")]
			public void InsertSingleCoroutine(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x2CE13C0", Offset = "0x2CDF9C0", VA = "0x182CE13C0")]
			public void InsertImmediates(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1120", Offset = "0x2CDF720", VA = "0x182CE1120")]
			public void InsertFutures(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1890", Offset = "0x2CDFE90", VA = "0x182CE1890")]
			private void QueueForReinsert(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1990", Offset = "0x2CDFF90", VA = "0x182CE1990")]
			private void QueueMultipleForReinsert(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1B00", Offset = "0x2CE0100", VA = "0x182CE1B00")]
			private TickResult TickCoroutine(SchedulerCoroutine coroutine)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x2CE1C80", Offset = "0x2CE0280", VA = "0x182CE1C80")]
			public void Update(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0F80", Offset = "0x2CDF580", VA = "0x182CE0F80")]
			private void DoImmediateUpdates()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0D90", Offset = "0x2CDF390", VA = "0x182CE0D90")]
			private void DoFutureUpdates(float now)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0C40", Offset = "0x2CDF240", VA = "0x182CE0C40", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2CE0AD0", Offset = "0x2CDF0D0", VA = "0x182CE0AD0")]
			private void ClearQueuedRoutines(List<SchedulerCoroutine> coroutines)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[BurstCompile]
		public struct ScheduleSortJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			[ReadOnly]
			public float Now;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			[ReadOnly]
			public int ActiveCoroutineCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private NativeArray<int> Indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<int> scratchLeft;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<int> scratchRight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			[ReadOnly]
			public NativeArray<CoroutineState> AllCoroutineStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			[ReadOnly]
			public NativeArray<float> AllNextUpdateTimes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			[WriteOnly]
			public NativeArray<int> SortedIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[WriteOnly]
			public NativeArray<int> NumberToExecute;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2CDCC70", Offset = "0x2CDB270", VA = "0x182CDCC70")]
			public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
			{
				return default(ScheduleSortJob);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x2C1BD0", Offset = "0x2C0FD0", VA = "0x1802C1BD0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2C1C80", Offset = "0x2C1080", VA = "0x1802C1C80")]
			private bool ShouldExecute(int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x2C1C20", Offset = "0x2C1020", VA = "0x1802C1C20")]
			private void MergeSort(NativeArray<int> arr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2C1BE0", Offset = "0x2C0FE0", VA = "0x1802C1BE0")]
			private int IndexCompare(int indexA, int indexB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x2C1BF0", Offset = "0x2C0FF0", VA = "0x1802C1BF0")]
			private void MergeSortImpl(NativeArray<int> arr, int l, int r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2C1C40", Offset = "0x2C1040", VA = "0x1802C1C40")]
			private void Merge(NativeArray<int> arr, int leftStart, int middle, int rightEnd)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class <EndOfFrameRoutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__24(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x2CE3E00", Offset = "0x2CE2400", VA = "0x182CE3E00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2CE3E80", Offset = "0x2CE2480", VA = "0x182CE3E80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly QueueType[] queueTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private SchedulerQueue[] queues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobbedSchedulerQueue[] jobbedQueues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Coroutine endOfFrameRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private WaitForEndOfFrame waitForEndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const CoroutineState PAUSED_INACTIVE_OR_CANCELLED = CoroutineState.Cancelled | CoroutineState.Paused;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ISchedulerTimer Timer
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x3941A0", Offset = "0x3927A0", VA = "0x1803941A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2A70", Offset = "0x2CE1070", VA = "0x182CE2A70")]
		public static ISchedulerPromise GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2220", Offset = "0x2CE0820", VA = "0x182CE2220", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2B20", Offset = "0x2CE1120", VA = "0x182CE2B20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2AD0", Offset = "0x2CE10D0", VA = "0x182CE2AD0")]
		private SchedulerQueue GetQueue(QueueType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1A55F40", Offset = "0x1A54540", VA = "0x181A55F40")]
		private JobbedSchedulerQueue GetJobbedQueue(QueueType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2FC0", Offset = "0x2CE15C0", VA = "0x182CE2FC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2F90", Offset = "0x2CE1590", VA = "0x182CE2F90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3660", Offset = "0x2CE1C60", VA = "0x182CE3660")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3030", Offset = "0x2CE1630", VA = "0x182CE3030")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3050", Offset = "0x2CE1650", VA = "0x182CE3050")]
		private void OnRigidbodyExLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2730", Offset = "0x2CE0D30", VA = "0x182CE2730")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2B10", Offset = "0x2CE1110", VA = "0x182CE2B10")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3040", Offset = "0x2CE1640", VA = "0x182CE3040")]
		private void OnPreRenderUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2CE26D0", Offset = "0x2CE0CD0", VA = "0x182CE26D0")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__24))]
		private IEnumerator EndOfFrameRoutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3420", Offset = "0x2CE1A20", VA = "0x182CE3420")]
		public ISchedulerPromise Run(IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3160", Offset = "0x2CE1760", VA = "0x182CE3160")]
		public ISchedulerPromise Run(Behaviour context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3060", Offset = "0x2CE1660", VA = "0x182CE3060")]
		public ISchedulerPromise RunJobbed(IJobbedSchedulerContext context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE3430", Offset = "0x2CE1A30", VA = "0x182CE3430")]
		public void UpdateQueue(QueueType currentQueueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2890", Offset = "0x2CE0E90", VA = "0x182CE2890")]
		private void FlushReinserts(SchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE2740", Offset = "0x2CE0D40", VA = "0x182CE2740")]
		private void FlushJobbedReinserts(JobbedSchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2CE37E0", Offset = "0x2CE1DE0", VA = "0x182CE37E0")]
		public Scheduler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ScheduleRate : ISchedule
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class <UpdateCoroutine>d__25 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public float hz;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Action<float> update;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private ScheduleRate <schedule>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x2CE5440", Offset = "0x2CE3A40", VA = "0x182CE5440", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x2CE55F0", Offset = "0x2CE3BF0", VA = "0x182CE55F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly float firstUpdateTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private int timesUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly float secondsPerUpdate;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float TargetHz
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3AE7D0", Offset = "0x3ACDD0", VA = "0x1803AE7D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3AE870", Offset = "0x3ACE70", VA = "0x1803AE870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3AB450", Offset = "0x3A9A50", VA = "0x1803AB450", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x3AB340", Offset = "0x3A9940", VA = "0x1803AB340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x41D610", Offset = "0x41BC10", VA = "0x18041D610", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x703050", Offset = "0x701650", VA = "0x180703050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x41D620", Offset = "0x41BC20", VA = "0x18041D620")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x66F760", Offset = "0x66DD60", VA = "0x18066F760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCB90", Offset = "0x2CDB190", VA = "0x182CDCB90")]
		public ScheduleRate(float targetRateHz, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCA60", Offset = "0x2CDB060", VA = "0x182CDCA60", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCA80", Offset = "0x2CDB080", VA = "0x182CDCA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC8F0", Offset = "0x2CDAEF0", VA = "0x182CDC8F0")]
		public static ISchedulerPromise QueueUpdate(float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC9A0", Offset = "0x2CDAFA0", VA = "0x182CDC9A0")]
		public static ISchedulerPromise QueueUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2CDC830", Offset = "0x2CDAE30", VA = "0x182CDC830")]
		public static ISchedulerPromise QueueJobbedUpdate(IJobbedSchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCB10", Offset = "0x2CDB110", VA = "0x182CDCB10")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__25))]
		private static IEnumerator<ISchedule> UpdateCoroutine(float hz, Scheduler.QueueType queue, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ISchedulerTimer
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float FixedDeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		double RealtimeSinceStartup
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class DefaultTimer : ISchedulerTimer
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2CD70B0", Offset = "0x2CD56B0", VA = "0x182CD70B0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2CD7060", Offset = "0x2CD5660", VA = "0x182CD7060", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float FixedDeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2CD7070", Offset = "0x2CD5670", VA = "0x182CD7070", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2CD7080", Offset = "0x2CD5680", VA = "0x182CD7080", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public double RealtimeSinceStartup
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x2CD7090", Offset = "0x2CD5690", VA = "0x182CD7090", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3830F0", Offset = "0x3816F0", VA = "0x1803830F0")]
		public DefaultTimer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ScheduleUntil : ISchedule
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3AB310", Offset = "0x3A9910", VA = "0x1803AB310", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x3AB430", Offset = "0x3A9A30", VA = "0x1803AB430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x3AE7D0", Offset = "0x3ACDD0", VA = "0x1803AE7D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3AE870", Offset = "0x3ACE70", VA = "0x1803AE870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD290", Offset = "0x2CDB890", VA = "0x182CDD290")]
		public ScheduleUntil(Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD250", Offset = "0x2CDB850", VA = "0x182CDD250")]
		public ScheduleUntil(Scheduler.QueueType queueType, Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD200", Offset = "0x2CDB800", VA = "0x182CDD200", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class UntilUpdateExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class <UntilCoroutine>d__0 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Scheduler.QueueType queueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Func<bool> condition;

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <UntilCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2CE50F0", Offset = "0x2CE36F0", VA = "0x182CE50F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x2CE5190", Offset = "0x2CE3790", VA = "0x182CE5190", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2CE57D0", Offset = "0x2CE3DD0", VA = "0x182CE57D0")]
		[IteratorStateMachine(typeof(<UntilCoroutine>d__0))]
		private static IEnumerator<ISchedule> UntilCoroutine(Scheduler.QueueType queueType, Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2CE5640", Offset = "0x2CE3C40", VA = "0x182CE5640")]
		public static ISchedulerPromise ScheduleUntil(this MonoBehaviour behaviour, Func<bool> condition, Scheduler.QueueType queueType = Scheduler.QueueType.Update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class ScheduleWait : ISchedule
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly float waitTime;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x3AB330", Offset = "0x3A9930", VA = "0x1803AB330", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3AB350", Offset = "0x3A9950", VA = "0x1803AB350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x45ACA0", Offset = "0x4592A0", VA = "0x18045ACA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x45AC90", Offset = "0x459290", VA = "0x18045AC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD350", Offset = "0x2CDB950", VA = "0x182CDD350")]
		public ScheduleWait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2CDD2C0", Offset = "0x2CDB8C0", VA = "0x182CDD2C0", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class DelayedUpdateExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class <DelayedCoroutine>d__0 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public float seconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public Action function;

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <DelayedCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2CE3D00", Offset = "0x2CE2300", VA = "0x182CE3D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2CE3DB0", Offset = "0x2CE23B0", VA = "0x182CE3DB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class <InvokeRepeatedCoroutine>d__1 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public float seconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public Action function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private ISchedule <wait>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000186")]
				[Cpp2IlInjected.Address(RVA = "0x383200", Offset = "0x381800", VA = "0x180383200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x383270", Offset = "0x381870", VA = "0x180383270")]
			[DebuggerHidden]
			public <InvokeRepeatedCoroutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x2CE4010", Offset = "0x2CE2610", VA = "0x182CE4010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x2CE40D0", Offset = "0x2CE26D0", VA = "0x182CE40D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2CD70C0", Offset = "0x2CD56C0", VA = "0x182CD70C0")]
		[IteratorStateMachine(typeof(<DelayedCoroutine>d__0))]
		private static IEnumerator<ISchedule> DelayedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7F40", Offset = "0x2CD6540", VA = "0x182CD7F40")]
		[IteratorStateMachine(typeof(<InvokeRepeatedCoroutine>d__1))]
		private static IEnumerator<ISchedule> InvokeRepeatedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8160", Offset = "0x2CD6760", VA = "0x182CD8160")]
		public static IDisposable InvokeRepeated(this MonoBehaviour behaviour, float seconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2CD82F0", Offset = "0x2CD68F0", VA = "0x182CD82F0")]
		public static ISchedulerPromise ScheduleDelay(this MonoBehaviour behaviour, float seconds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7FC0", Offset = "0x2CD65C0", VA = "0x182CD7FC0")]
		public static ISchedulerPromise InvokeRepeated(this MonoBehaviour behaviour, float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7DC0", Offset = "0x2CD63C0", VA = "0x182CD7DC0")]
		public static ISchedulerPromise InvokeNextUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7AC0", Offset = "0x2CD60C0", VA = "0x182CD7AC0")]
		public static ISchedulerPromise InvokeNextLateUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7940", Offset = "0x2CD5F40", VA = "0x182CD7940")]
		public static ISchedulerPromise InvokeNextFixedUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2CD77C0", Offset = "0x2CD5DC0", VA = "0x182CD77C0")]
		public static ISchedulerPromise InvokeNextEndOfFrame(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7C40", Offset = "0x2CD6240", VA = "0x182CD7C40")]
		public static ISchedulerPromise InvokeNextPreRender(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7680", Offset = "0x2CD5C80", VA = "0x182CD7680")]
		public static ISchedulerPromise InvokeInUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2CD73E0", Offset = "0x2CD59E0", VA = "0x182CD73E0")]
		public static ISchedulerPromise InvokeInLateUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7290", Offset = "0x2CD5890", VA = "0x182CD7290")]
		public static ISchedulerPromise InvokeInFixedUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7140", Offset = "0x2CD5740", VA = "0x182CD7140")]
		public static ISchedulerPromise InvokeInEndOfFrame(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2CD7530", Offset = "0x2CD5B30", VA = "0x182CD7530")]
		public static ISchedulerPromise InvokeInPreRender(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}
	}
}
namespace RecRoom.Analytics
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RollingBufferAverageStats : IAveragedStats
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int MaxBufferLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private readonly Queue<double> valuesBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private double min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private double max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private double sum;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int BufferCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2CDBEF0", Offset = "0x2CDA4F0", VA = "0x182CDBEF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2CDBF40", Offset = "0x2CDA540", VA = "0x182CDBF40", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BAB0", Offset = "0x1E1A0B0", VA = "0x181E1BAB0", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BAA0", Offset = "0x1E1A0A0", VA = "0x181E1BAA0", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBE60", Offset = "0x2CDA460", VA = "0x182CDBE60")]
		public RollingBufferAverageStats(int maxBufferLength)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBD40", Offset = "0x2CDA340", VA = "0x182CDBD40", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2CDBCD0", Offset = "0x2CDA2D0", VA = "0x182CDBCD0", Slot = "5")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class EWMAStats : IAveragedStats
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private long count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private double mean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private double m2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private double variance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private double stdDev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private double min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private double max;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3A4C10", Offset = "0x3A3210", VA = "0x1803A4C10")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x1B287D0", Offset = "0x1B26DD0", VA = "0x181B287D0", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BAD0", Offset = "0x1E1A0D0", VA = "0x181E1BAD0", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public double Variance
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BAA0", Offset = "0x1E1A0A0", VA = "0x181E1BAA0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public double StdDev
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x274BEF0", Offset = "0x274A4F0", VA = "0x18274BEF0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x1E1BA10", Offset = "0x1E1A010", VA = "0x181E1BA10", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2CD84B0", Offset = "0x2CD6AB0", VA = "0x182CD84B0", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2CD8470", Offset = "0x2CD6A70", VA = "0x182CD8470", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2CD85D0", Offset = "0x2CD6BD0", VA = "0x182CD85D0")]
		public EWMAStats()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface IAveragedStats
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Track(double val);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Reset();
	}
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class MainThreadDispatcher
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private interface IQueuedDispatch
		{
			[Cpp2IlInjected.Token(Token = "0x17000050")]
			bool IsReady
			{
				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void Complete();

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private abstract class PromiseDispatchBase<TPromise, TMainThreadPromise> : IQueuedDispatch where TPromise : IPromise where TMainThreadPromise : TPromise
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private readonly TPromise backgroundPromise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			protected readonly TMainThreadPromise MainThreadInternalPromise;

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public TPromise MainThreadPromise
			{
				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x2481F90", Offset = "0x2480590", VA = "0x182481F90")]
				get
				{
					return (TPromise)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public bool IsReady
			{
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(RVA = "0x2481F40", Offset = "0x2480540", VA = "0x182481F40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x18A0080", Offset = "0x189E680", VA = "0x1818A0080")]
			protected PromiseDispatchBase(TPromise backgroundPromise, TMainThreadPromise mainThreadInternalPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x2481F10", Offset = "0x2480510", VA = "0x182481F10", Slot = "5")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x1346460", Offset = "0x1344A60", VA = "0x181346460", Slot = "6")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			protected abstract void CompleteInternal(TPromise backgroundPromise);

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(Slot = "8")]
			protected abstract void CancelInternal();
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private class PromiseDispatch<T> : PromiseDispatchBase<IPromise<T>, Promise<T>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x24824B0", Offset = "0x2480AB0", VA = "0x1824824B0")]
			public PromiseDispatch(IPromise<T> backgroundPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x24820B0", Offset = "0x24806B0", VA = "0x1824820B0", Slot = "7")]
			protected override void CompleteInternal(IPromise<T> backgroundPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x2482050", Offset = "0x2480650", VA = "0x182482050", Slot = "8")]
			protected override void CancelInternal()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private class PromiseDispatch : PromiseDispatchBase<IPromise, Promise>
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x2CDB9D0", Offset = "0x2CD9FD0", VA = "0x182CDB9D0")]
			public PromiseDispatch(IPromise backgroundPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x2CDB880", Offset = "0x2CD9E80", VA = "0x182CDB880", Slot = "7")]
			protected override void CompleteInternal(IPromise backgroundPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2CDB830", Offset = "0x2CD9E30", VA = "0x182CDB830", Slot = "8")]
			protected override void CancelInternal()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private class ActionDispatch : IQueuedDispatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private readonly Action action;

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public bool IsReady
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x3BE210", Offset = "0x3BC810", VA = "0x1803BE210", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3A9B60", Offset = "0x3A8160", VA = "0x1803A9B60")]
			public ActionDispatch(Action action)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x95A4A0", Offset = "0x958AA0", VA = "0x18095A4A0", Slot = "5")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x383260", Offset = "0x381860", VA = "0x180383260", Slot = "6")]
			public void Cancel()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly List<IQueuedDispatch> queuedDispatches;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x126FBA0", Offset = "0x126E1A0", VA = "0x18126FBA0")]
		public static IPromise<T> DispatchOntoMainThread<T>(IPromise<T> backgroundPromise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2CDAEF0", Offset = "0x2CD94F0", VA = "0x182CDAEF0")]
		public static IPromise DispatchOntoMainThread(IPromise backgroundPromise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2CDAFD0", Offset = "0x2CD95D0", VA = "0x182CDAFD0")]
		public static void DispatchOntoMainThread(Action action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2CDAC30", Offset = "0x2CD9230", VA = "0x182CDAC30")]
		private static void AddDispatch(IQueuedDispatch dispatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB050", Offset = "0x2CD9650", VA = "0x182CDB050")]
		private static void ProcessUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB3C0", Offset = "0x2CD99C0", VA = "0x182CDB3C0")]
		private static void RegisterDispatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2CDAE40", Offset = "0x2CD9440", VA = "0x182CDAE40")]
		private static void DeregisterDispatch()
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
