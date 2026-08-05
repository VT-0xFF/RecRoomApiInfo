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
public interface ISchedulerContext
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
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private delegate List<PlayerLoopSystem> SubsystemListModification(List<PlayerLoopSystem> systems, int subsystemIndex);

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public struct CustomSystems
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			public struct PostUpdateSystem
			{
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static ActionEvent OnPostUpdate;

				[Cpp2IlInjected.Token(Token = "0x6000181")]
				[Cpp2IlInjected.Address(RVA = "0x24A0E20", Offset = "0x24A0220", VA = "0x1824A0E20")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003A")]
			public struct RigidbodyExLateUpdateSystem
			{
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static ActionEvent OnRigidbodyExLateUpdate;

				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x24A1250", Offset = "0x24A0650", VA = "0x1824A1250")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003B")]
			public struct PreRenderSystem
			{
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static ActionEvent OnPreRenderUpdate;

				[Cpp2IlInjected.Token(Token = "0x6000185")]
				[Cpp2IlInjected.Address(RVA = "0x24A0FC0", Offset = "0x24A03C0", VA = "0x1824A0FC0")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003C")]
			internal struct WrapperPreSystem
			{
				[Cpp2IlInjected.Token(Token = "0x6000187")]
				[Cpp2IlInjected.Address(RVA = "0x24ACD70", Offset = "0x24AC170", VA = "0x1824ACD70")]
				public static PlayerLoopSystem GetNewSystem(TimerAnalytics.WrapperKey key)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003D")]
			internal struct WrapperPostSystem
			{
				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x24ACC70", Offset = "0x24AC070", VA = "0x1824ACC70")]
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
			[Cpp2IlInjected.Address(RVA = "0x249F770", Offset = "0x249EB70", VA = "0x18249F770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x249F7B0", Offset = "0x249EBB0", VA = "0x18249F7B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x249E210", Offset = "0x249D610", VA = "0x18249E210")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x249F510", Offset = "0x249E910", VA = "0x18249F510")]
		private static void TryTimerWrapSubSystem(TimerAnalytics.WrapperKey key, ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x249F070", Offset = "0x249E470", VA = "0x18249F070")]
		private static void ModifySubsystemList(ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType, SubsystemListModification subsystemListModification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x249F410", Offset = "0x249E810", VA = "0x18249F410")]
		private static void TryInsertSystems(ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType, PlayerLoopSystem? before, PlayerLoopSystem? after)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class TimerAnalytics
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum WrapperKey
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			SchedulerUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			PreRenderUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			PhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			PhysicsUpdate,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			SendFrameStarted,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			FinishFrameRendering,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			PhysicsResetInterpolatedPosition,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			FullPlayerLoop
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public class CallWrapper
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public readonly WrapperKey WrapperKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private Stopwatch stopwatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public readonly RollingBufferAverageStats AverageStats;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private long startTicks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private long endTicks;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x249E110", Offset = "0x249D510", VA = "0x18249E110")]
			public CallWrapper(WrapperKey wrapperKey, int bufferSize = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x249E0F0", Offset = "0x249D4F0", VA = "0x18249E0F0")]
			public void SetBufferLength(int bufferLength)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x249E030", Offset = "0x249D430", VA = "0x18249E030")]
			public void ResetTimer()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x249E000", Offset = "0x249D400", VA = "0x18249E000")]
			public void RegisterStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x249DEB0", Offset = "0x249D2B0", VA = "0x18249DEB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24AAD30", Offset = "0x24AA130", VA = "0x1824AAD30")]
		public static CallWrapper CreateWrapper(WrapperKey key, int bufferSize = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x24AAEF0", Offset = "0x24AA2F0", VA = "0x1824AAEF0")]
		public static CallWrapper GetWrapper(WrapperKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x24AAF80", Offset = "0x24AA380", VA = "0x1824AAF80")]
		public static void ResetAllWrappers()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x320880", Offset = "0x31FC80", VA = "0x180320880")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x24A1160", Offset = "0x24A0560", VA = "0x1824A1160", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IReadOnlyReactiveProperty<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable Observe(Action<T> onValueChanged);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IDisposable Observe(UnityEngine.Object context, Action<T> onValueChanged);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface IReactiveProperty<T> : IReadOnlyReactiveProperty<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		new T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
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

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private static UnityEngine.Object DefaultContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1A7BEE0", Offset = "0x1A7B2E0", VA = "0x181A7BEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3237E0", Offset = "0x322BE0", VA = "0x1803237E0", Slot = "6")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1A7C300", Offset = "0x1A7B700", VA = "0x181A7C300", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B390", Offset = "0x1A7A790", VA = "0x181A7B390")]
		private static bool AreEqual(T a, T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1A7BE20", Offset = "0x1A7B220", VA = "0x181A7BE20")]
		public ReactiveProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1A7BE50", Offset = "0x1A7B250", VA = "0x181A7BE50")]
		public ReactiveProperty(T initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B400", Offset = "0x1A7A800", VA = "0x181A7B400")]
		public void ForceUpdate(T newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1A7BAA0", Offset = "0x1A7AEA0", VA = "0x181A7BAA0", Slot = "7")]
		public IDisposable Observe(Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1A7BC50", Offset = "0x1A7B050", VA = "0x181A7BC50", Slot = "8")]
		public IDisposable Observe(UnityEngine.Object context, Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1A7B770", Offset = "0x1A7AB70", VA = "0x181A7B770")]
		private void NotifyObservers()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class Schedule
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class <Example>d__8 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <Example>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x24AB310", Offset = "0x24AA710", VA = "0x1824AB310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x24AB400", Offset = "0x24AA800", VA = "0x1824AB400", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x24A2D10", Offset = "0x24A2110", VA = "0x1824A2D10")]
		public static ISchedule Wait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x24A2CB0", Offset = "0x24A20B0", VA = "0x1824A2CB0")]
		public static ISchedule Until(Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x24A2BB0", Offset = "0x24A1FB0", VA = "0x1824A2BB0")]
		public static ISchedule AfterCompleted(IPromise promise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x24A2C60", Offset = "0x24A2060", VA = "0x1824A2C60")]
		[IteratorStateMachine(typeof(<Example>d__8))]
		public static IEnumerator<ISchedule> Example()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ISchedule
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Ready();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class ScheduledUpdate : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class <RequeueFromErrorNextFrame>d__13 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public Action requeueAction;

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x24AB560", Offset = "0x24AA960", VA = "0x1824AB560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x24AB6C0", Offset = "0x24AAAC0", VA = "0x1824AB6C0", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x24A5960", Offset = "0x24A4D60", VA = "0x1824A5960")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x24A5B00", Offset = "0x24A4F00", VA = "0x1824A5B00")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x24A5CA0", Offset = "0x24A50A0", VA = "0x1824A5CA0")]
		public ScheduledUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x24A54F0", Offset = "0x24A48F0", VA = "0x1824A54F0")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x24A5370", Offset = "0x24A4770", VA = "0x1824A5370")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x24A5240", Offset = "0x24A4640", VA = "0x1824A5240")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x24A56D0", Offset = "0x24A4AD0", VA = "0x1824A56D0")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x24A5670", Offset = "0x24A4A70", VA = "0x1824A5670")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x24A51F0", Offset = "0x24A45F0", VA = "0x1824A51F0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ScheduledUpdateMonoBehaviourExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x24A4E10", Offset = "0x24A4210", VA = "0x1824A4E10")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x24A4C50", Offset = "0x24A4050", VA = "0x1824A4C50")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x24A5180", Offset = "0x24A4580", VA = "0x1824A5180")]
		public static IDisposable Update(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x24A4860", Offset = "0x24A3C60", VA = "0x1824A4860")]
		public static IDisposable FixedUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x24A4AE0", Offset = "0x24A3EE0", VA = "0x1824A4AE0")]
		public static IDisposable LateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x24A4E90", Offset = "0x24A4290", VA = "0x1824A4E90")]
		public static IDisposable RigidbodyExLateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x24A4B50", Offset = "0x24A3F50", VA = "0x1824A4B50")]
		public static IDisposable PreRenderUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x24A4BC0", Offset = "0x24A3FC0", VA = "0x1824A4BC0")]
		public static IDisposable QueueUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x24A5100", Offset = "0x24A4500", VA = "0x1824A5100")]
		public static IDisposable UpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x24A5000", Offset = "0x24A4400", VA = "0x1824A5000")]
		public static IDisposable Update30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x24A4F00", Offset = "0x24A4300", VA = "0x1824A4F00")]
		public static IDisposable Update10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x24A5080", Offset = "0x24A4480", VA = "0x1824A5080")]
		public static IDisposable Update5hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x24A4F80", Offset = "0x24A4380", VA = "0x1824A4F80")]
		public static IDisposable Update1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x24A47D0", Offset = "0x24A3BD0", VA = "0x1824A47D0")]
		public static IDisposable FixedUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x24A4750", Offset = "0x24A3B50", VA = "0x1824A4750")]
		public static IDisposable FixedUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x24A4650", Offset = "0x24A3A50", VA = "0x1824A4650")]
		public static IDisposable FixedUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x24A46D0", Offset = "0x24A3AD0", VA = "0x1824A46D0")]
		public static IDisposable FixedUpdate1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x24A4A50", Offset = "0x24A3E50", VA = "0x1824A4A50")]
		public static IDisposable LateUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x24A49D0", Offset = "0x24A3DD0", VA = "0x1824A49D0")]
		public static IDisposable LateUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x24A48D0", Offset = "0x24A3CD0", VA = "0x1824A48D0")]
		public static IDisposable LateUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x24A4950", Offset = "0x24A3D50", VA = "0x1824A4950")]
		public static IDisposable LateUpdate1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class ScheduledContextUpdate : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class <RequeueFromErrorNextFrame>d__13 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Action requeueAction;

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x24AB610", Offset = "0x24AAA10", VA = "0x1824AB610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x24AB710", Offset = "0x24AAB10", VA = "0x1824AB710", Slot = "8")]
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
		private ISchedulerContext context;

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

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x24A3830", Offset = "0x24A2C30", VA = "0x1824A3830")]
		public ScheduledContextUpdate(ISchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x24A3690", Offset = "0x24A2A90", VA = "0x1824A3690")]
		public ScheduledContextUpdate(ISchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x24A39D0", Offset = "0x24A2DD0", VA = "0x1824A39D0")]
		public ScheduledContextUpdate(ISchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x24A3210", Offset = "0x24A2610", VA = "0x1824A3210")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x24A3090", Offset = "0x24A2490", VA = "0x1824A3090")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x24A2F60", Offset = "0x24A2360", VA = "0x1824A2F60")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x24A33F0", Offset = "0x24A27F0", VA = "0x1824A33F0")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x24A3390", Offset = "0x24A2790", VA = "0x1824A3390")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x24A2F10", Offset = "0x24A2310", VA = "0x1824A2F10", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class ScheduledUpdateContextExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x24A42F0", Offset = "0x24A36F0", VA = "0x1824A42F0")]
		public static IDisposable QueueUpdateJobbed(this ISchedulerContext behaviour, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x24A4130", Offset = "0x24A3530", VA = "0x1824A4130")]
		public static IDisposable QueueUpdateJobbed(this ISchedulerContext behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x24A45E0", Offset = "0x24A39E0", VA = "0x1824A45E0")]
		public static IDisposable UpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x24A3D40", Offset = "0x24A3140", VA = "0x1824A3D40")]
		public static IDisposable FixedUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x24A3FC0", Offset = "0x24A33C0", VA = "0x1824A3FC0")]
		public static IDisposable LateUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x24A4370", Offset = "0x24A3770", VA = "0x1824A4370")]
		public static IDisposable RigidbodyExLateUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x24A4030", Offset = "0x24A3430", VA = "0x1824A4030")]
		public static IDisposable PreRenderUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x24A40A0", Offset = "0x24A34A0", VA = "0x1824A40A0")]
		public static IDisposable QueueUpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x24A4560", Offset = "0x24A3960", VA = "0x1824A4560")]
		public static IDisposable UpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x24A44E0", Offset = "0x24A38E0", VA = "0x1824A44E0")]
		public static IDisposable Update30hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x24A43E0", Offset = "0x24A37E0", VA = "0x1824A43E0")]
		public static IDisposable Update10hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x24A4460", Offset = "0x24A3860", VA = "0x1824A4460")]
		public static IDisposable Update1hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x24A3CB0", Offset = "0x24A30B0", VA = "0x1824A3CB0")]
		public static IDisposable FixedUpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x24A3C30", Offset = "0x24A3030", VA = "0x1824A3C30")]
		public static IDisposable FixedUpdate30hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x24A3B30", Offset = "0x24A2F30", VA = "0x1824A3B30")]
		public static IDisposable FixedUpdate10hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x24A3BB0", Offset = "0x24A2FB0", VA = "0x1824A3BB0")]
		public static IDisposable FixedUpdate1hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x24A3F30", Offset = "0x24A3330", VA = "0x1824A3F30")]
		public static IDisposable LateUpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x24A3EB0", Offset = "0x24A32B0", VA = "0x1824A3EB0")]
		public static IDisposable LateUpdate30hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x24A3DB0", Offset = "0x24A31B0", VA = "0x1824A3DB0")]
		public static IDisposable LateUpdate10hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x24A3E30", Offset = "0x24A3230", VA = "0x1824A3E30")]
		public static IDisposable LateUpdate1hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class ScheduleNextFrame : ISchedule
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class <UpdateCoroutine>d__14 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action update;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private ScheduleNextFrame <schedule>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x24AC650", Offset = "0x24ABA50", VA = "0x1824AC650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x24AC720", Offset = "0x24ABB20", VA = "0x1824AC720", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class <UpdateCoroutine>d__15 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public Action<float> update;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private ScheduleNextFrame <schedule>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000110")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x24AC770", Offset = "0x24ABB70", VA = "0x1824AC770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x24AC860", Offset = "0x24ABC60", VA = "0x1824AC860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x31CE60", Offset = "0x31C260", VA = "0x18031CE60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7D0", Offset = "0x3FEBD0", VA = "0x1803FF7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2D0", Offset = "0xA5D6D0", VA = "0x180A5E2D0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
		public ScheduleNextFrame(Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x31B4F0", Offset = "0x31A8F0", VA = "0x18031B4F0", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x24A1800", Offset = "0x24A0C00", VA = "0x1824A1800")]
		public static ISchedulerPromise QueueUpdate(Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x24A1B20", Offset = "0x24A0F20", VA = "0x1824A1B20")]
		public static ISchedulerPromise QueueUpdate(Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x24A1A10", Offset = "0x24A0E10", VA = "0x1824A1A10")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x24A1900", Offset = "0x24A0D00", VA = "0x1824A1900")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x24A16F0", Offset = "0x24A0AF0", VA = "0x1824A16F0")]
		public static ISchedulerPromise QueueUpdate(ISchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x24A1C20", Offset = "0x24A1020", VA = "0x1824A1C20")]
		public static ISchedulerPromise QueueUpdate(ISchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x24A1D30", Offset = "0x24A1130", VA = "0x1824A1D30")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__14))]
		private static IEnumerator<ISchedule> UpdateCoroutine(Scheduler.QueueType queue, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x24A1DA0", Offset = "0x24A11A0", VA = "0x1824A1DA0")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__15))]
		private static IEnumerator<ISchedule> UpdateCoroutine(Scheduler.QueueType queue, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ISchedulerPromise : ICancelablePromise, IPromise, IEnumerator, ISchedule, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface IJobbedSchedulerCoroutine
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class Scheduler : SingletonMonoBehaviour<Scheduler>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum QueueType
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			PreRender,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			EndOfFrame
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private sealed class SchedulerPromise : CancelablePromise, ISchedulerPromise, ICancelablePromise, IPromise, IEnumerator, ISchedule, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public JobbedSchedulerCoroutine Routine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private QueueType _queue;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			QueueType ISchedule.Queue
			{
				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x3870C0", Offset = "0x3864C0", VA = "0x1803870C0", Slot = "22")]
				get
				{
					return default(QueueType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public QueueType Queue
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x3870C0", Offset = "0x3864C0", VA = "0x1803870C0")]
				get
				{
					return default(QueueType);
				}
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x3B1690", Offset = "0x3B0A90", VA = "0x1803B1690")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			float ISchedule.NextPossibleReady
			{
				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0xA5E2D0", Offset = "0xA5D6D0", VA = "0x180A5E2D0", Slot = "24")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x24A6290", Offset = "0x24A5690", VA = "0x1824A6290", Slot = "23")]
			bool ISchedule.Ready()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x24A62A0", Offset = "0x24A56A0", VA = "0x1824A62A0")]
			public SchedulerPromise()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x24A6250", Offset = "0x24A5650", VA = "0x1824A6250")]
			private void CancelRoutine()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x24A6280", Offset = "0x24A5680", VA = "0x1824A6280", Slot = "25")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[BurstCompile]
		public struct ScheduleSortJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			[ReadOnly]
			public float Now;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			[ReadOnly]
			public int ActiveCoroutineCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private NativeArray<int> Indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private NativeArray<int> scratchLeft;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private NativeArray<int> scratchRight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			[ReadOnly]
			public NativeArray<CoroutineState> AllCoroutineStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			[ReadOnly]
			public NativeArray<float> AllNextUpdateTimes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			[WriteOnly]
			public NativeArray<int> SortedIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			[WriteOnly]
			public NativeArray<int> NumberToExecute;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x24A2250", Offset = "0x24A1650", VA = "0x1824A2250")]
			public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
			{
				return default(ScheduleSortJob);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA50", Offset = "0x2DEE50", VA = "0x1802DFA50", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x2DFB00", Offset = "0x2DEF00", VA = "0x1802DFB00")]
			private bool ShouldExecute(int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2DFAA0", Offset = "0x2DEEA0", VA = "0x1802DFAA0")]
			private void MergeSort(NativeArray<int> arr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA60", Offset = "0x2DEE60", VA = "0x1802DFA60")]
			private int IndexCompare(int indexA, int indexB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA70", Offset = "0x2DEE70", VA = "0x1802DFA70")]
			private void MergeSortImpl(NativeArray<int> arr, int l, int r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2DFAC0", Offset = "0x2DEEC0", VA = "0x1802DFAC0")]
			private void Merge(NativeArray<int> arr, int leftStart, int middle, int rightEnd)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private class JobbedSchedulerCoroutine : IJobbedSchedulerCoroutine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public SchedulerQueue Queue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int Index
			{
				[Cpp2IlInjected.Token(Token = "0x6000122")]
				[Cpp2IlInjected.Address(RVA = "0x31CE60", Offset = "0x31C260", VA = "0x18031CE60", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x3FF7D0", Offset = "0x3FEBD0", VA = "0x1803FF7D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x24A0C10", Offset = "0x24A0010", VA = "0x1824A0C10")]
			public static ISchedule Step(IEnumerator<ISchedule> coroutine, SchedulerPromise promise)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x24A0D40", Offset = "0x24A0140", VA = "0x1824A0D40")]
			public ISchedule Step(SchedulerPromise[] allScheduledPromises, IEnumerator<ISchedule>[] coroutines, ISchedule[] currentSchedules)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x24A0A60", Offset = "0x249FE60", VA = "0x1824A0A60")]
			public void OnContextDestroyed()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x24A0B50", Offset = "0x249FF50", VA = "0x1824A0B50")]
			public void OnContextEnabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x24A0A90", Offset = "0x249FE90", VA = "0x1824A0A90")]
			public void OnContextDisabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x24A0A60", Offset = "0x249FE60", VA = "0x1824A0A60")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x320620", Offset = "0x31FA20", VA = "0x180320620")]
			public JobbedSchedulerCoroutine()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class SchedulerCoroutine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private readonly SchedulerPromise promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private readonly Behaviour context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private readonly bool wasCreatedWithContext;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public IEnumerator<ISchedule> Coroutine
			{
				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x31A520", Offset = "0x319920", VA = "0x18031A520")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x3310B0", Offset = "0x3304B0", VA = "0x1803310B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public ISchedule CurrentSchedule
			{
				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0x37FAB0", Offset = "0x37EEB0", VA = "0x18037FAB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public bool Paused
			{
				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x24A61C0", Offset = "0x24A55C0", VA = "0x1824A61C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public bool Canceled
			{
				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x39D7B0", Offset = "0x39CBB0", VA = "0x18039D7B0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x463940", Offset = "0x462D40", VA = "0x180463940")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x31CBD0", Offset = "0x31BFD0", VA = "0x18031CBD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x3A06A0", Offset = "0x39FAA0", VA = "0x1803A06A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public float NextUpdateKey
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0xE247B0", Offset = "0xE23BB0", VA = "0x180E247B0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0xE24800", Offset = "0xE23C00", VA = "0x180E24800")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x24A6040", Offset = "0x24A5440", VA = "0x1824A6040")]
			public SchedulerCoroutine(IEnumerator<ISchedule> coroutine, Behaviour context, SchedulerPromise promise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x24A5E00", Offset = "0x24A5200", VA = "0x1824A5E00")]
			public ISchedule Step()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x24A5FB0", Offset = "0x24A53B0", VA = "0x1824A5FB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[Flags]
		public enum CoroutineState : byte
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

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private sealed class SchedulerQueue : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200003E")]
			private class SortCoroutinesChronologically : IComparer<SchedulerCoroutine>
			{
				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x24AABF0", Offset = "0x24A9FF0", VA = "0x1824AABF0", Slot = "4")]
				public int Compare(SchedulerCoroutine x, SchedulerCoroutine y)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x320620", Offset = "0x31FA20", VA = "0x180320620")]
				public SortCoroutinesChronologically()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003F")]
			public enum SubQueue
			{
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000040")]
			private enum TickResult : byte
			{
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				None,
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				Remove,
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				Reinsert,
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				NextUpdateChanged
			}

			[Cpp2IlInjected.Token(Token = "0x2000041")]
			public struct ReinsertBuffer
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public QueueType QueueType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public SubQueue SubQueue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<SchedulerCoroutine> Coroutines;
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			public struct JobbedReinsertBuffer
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public QueueType QueueType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public List<JobbedInsertionData> Insertions;
			}

			[Cpp2IlInjected.Token(Token = "0x2000043")]
			public struct JobbedInsertionData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public JobbedSchedulerCoroutine Routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public ISchedulerContext Context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public SchedulerPromise Promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public IEnumerator<ISchedule> Coroutine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public ISchedule CurrentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public CoroutineState CoroutineState;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private bool[] mainThreadCancels;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private NativeArray<CoroutineState> sharedCoroutineStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private NativeArray<float> NextUpdateTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private NativeArray<int> NumberToExecute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private NativeArray<int> UnsortedIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private NativeArray<int> SortedIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private NativeArray<int> MergeSortScratchLeft;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private NativeArray<int> MergeSortScratchRight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private JobbedSchedulerCoroutine[] allJobbedSchedulerJobbedRoutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private SchedulerPromise[] allScheduledPromises;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private ISchedulerContext[] allContexts;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private IEnumerator<ISchedule>[] allCoroutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private ISchedule[] allCurrentSchedules;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int coroutineCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private int capacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private readonly int initialCapacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private bool lockedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private readonly SchedulerCoroutine[] singleCoroutineArrayBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private readonly List<SchedulerCoroutine> immediateCoroutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private readonly Stack<int> immediateUpdateHoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private readonly List<SchedulerCoroutine> futureCoroutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private readonly Stack<int> futureUpdateHoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private ScheduleSortJob queueSortJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private JobHandle sortJobHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private List<JobbedSchedulerCoroutine> queuedRemoves;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private bool jobInProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private List<Action> queuedCoroutineStateChanges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private List<Action> queuedAddRemoveActions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private readonly List<SchedulerCoroutine> toRemoveBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private bool _disposed;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private float nextScaleDownArraySizeTime;

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int CoroutineCount
			{
				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0x61D320", Offset = "0x61C720", VA = "0x18061D320")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public int Capacity
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x61D3C0", Offset = "0x61C7C0", VA = "0x18061D3C0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public QueueType Queue
			{
				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0x38B0A0", Offset = "0x38A4A0", VA = "0x18038B0A0")]
				[CompilerGenerated]
				get
				{
					return default(QueueType);
				}
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x1852FA0", Offset = "0x18523A0", VA = "0x181852FA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public ReinsertBuffer[,] ReinsertionQueues
			{
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x7F72E0", Offset = "0x7F66E0", VA = "0x1807F72E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public JobbedReinsertBuffer[] JobbedReinsertionQueues
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0x7F0FB0", Offset = "0x7F03B0", VA = "0x1807F0FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x24A6AF0", Offset = "0x24A5EF0", VA = "0x1824A6AF0")]
			private static int GetInitialCapacity(QueueType queueType)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x24A8F00", Offset = "0x24A8300", VA = "0x1824A8F00")]
			public SchedulerQueue(QueueType queue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x24A7480", Offset = "0x24A6880", VA = "0x1824A7480")]
			public void LogFutureRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x24A7490", Offset = "0x24A6890", VA = "0x1824A7490")]
			public void LogImmediateRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x24A74A0", Offset = "0x24A68A0", VA = "0x1824A74A0")]
			private void LogRoutines(IReadOnlyList<SchedulerCoroutine> routines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x24A8350", Offset = "0x24A7750", VA = "0x1824A8350")]
			private void ResizeArrays(ref int oldCapacity, int newCapacity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x24A7060", Offset = "0x24A6460", VA = "0x1824A7060")]
			public void InsertJobbedSchedulerCoroutine(ISchedulerContext context, ISchedule currentSchedule, IEnumerator<ISchedule> coroutine, SchedulerPromise promise, [Optional] JobbedSchedulerCoroutine routine, CoroutineState coroutineState = CoroutineState.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x24A7F10", Offset = "0x24A7310", VA = "0x1824A7F10")]
			private JobbedInsertionData RemoveSchedulerCoroutine(int indexToRemove)
			{
				return default(JobbedInsertionData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x24A63C0", Offset = "0x24A57C0", VA = "0x1824A63C0")]
			private void CleanupAllContexts()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xF2F0A0", Offset = "0xF2E4A0", VA = "0x180F2F0A0")]
			private static void SwapBackFill<T>(int indexToRemove, T[] myArray, int size, [Optional] T fillValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xF2F080", Offset = "0xF2E480", VA = "0x180F2F080")]
			private static void SwapBackFill<T>(int indexToRemove, NativeArray<T> myArray, int size, [Optional] T fillValue) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x24A7390", Offset = "0x24A6790", VA = "0x1824A7390")]
			public void InsertSingleCoroutine(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x24A6DC0", Offset = "0x24A61C0", VA = "0x1824A6DC0")]
			public void InsertImmediates(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x24A7190", Offset = "0x24A6590", VA = "0x1824A7190")]
			public void InsertJobbed(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x24A7AF0", Offset = "0x24A6EF0", VA = "0x1824A7AF0")]
			private void QueueMultipleForInsertion(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x24A6B20", Offset = "0x24A5F20", VA = "0x1824A6B20")]
			public void InsertFutures(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x24A7770", Offset = "0x24A6B70", VA = "0x1824A7770")]
			private void QueueForReinsertJobbed(JobbedInsertionData jobbedInsertionData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x24A7840", Offset = "0x24A6C40", VA = "0x1824A7840")]
			private void QueueForReinsert(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x24A7DA0", Offset = "0x24A71A0", VA = "0x1824A7DA0")]
			private void QueueMultipleForReinsert(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x24A84D0", Offset = "0x24A78D0", VA = "0x1824A84D0")]
			private TickResult TickCoroutine(SchedulerCoroutine coroutine)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x24A8650", Offset = "0x24A7A50", VA = "0x1824A8650")]
			private TickResult TickJobbedCoroutine(int scheduleIndex)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x24A7940", Offset = "0x24A6D40", VA = "0x1824A7940")]
			public void QueueJob(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x24A7670", Offset = "0x24A6A70", VA = "0x1824A7670")]
			private void QueueAddRemoveAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x24A76F0", Offset = "0x24A6AF0", VA = "0x1824A76F0")]
			private void QueueCoroutineStateChangeAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x24A89C0", Offset = "0x24A7DC0", VA = "0x1824A89C0")]
			public void UpdateJobSortedCoroutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x24A8E60", Offset = "0x24A8260", VA = "0x1824A8E60")]
			public void Update(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x24A6920", Offset = "0x24A5D20", VA = "0x1824A6920")]
			private void DoImmediateUpdates()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x24A6720", Offset = "0x24A5B20", VA = "0x1824A6720")]
			private void DoFutureUpdates(float now)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x24A6650", Offset = "0x24A5A50", VA = "0x1824A6650", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x24A6310", Offset = "0x24A5710", VA = "0x1824A6310")]
			public void Cancel(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x24A75C0", Offset = "0x24A69C0", VA = "0x1824A75C0")]
			public void Pause(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x24A8910", Offset = "0x24A7D10", VA = "0x1824A8910")]
			public void Unpause(JobbedSchedulerCoroutine schedule)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class <EndOfFrameRoutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__29(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x24AB240", Offset = "0x24AA640", VA = "0x1824AB240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x24AB2C0", Offset = "0x24AA6C0", VA = "0x1824AB2C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly QueueType[] queueTypes;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly QueueType[] nonFixedUpdateQueueTypes;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public const CoroutineState PAUSED_INACTIVE_OR_CANCELLED = CoroutineState.Cancelled | CoroutineState.Paused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private SchedulerQueue[] queues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Coroutine endOfFrameRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private WaitForEndOfFrame waitForEndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ISchedulerTimer Timer
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x37FAB0", Offset = "0x37EEB0", VA = "0x18037FAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x24A9E50", Offset = "0x24A9250", VA = "0x1824A9E50")]
		public static ISchedulerPromise GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x24A96E0", Offset = "0x24A8AE0", VA = "0x1824A96E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x24A9F50", Offset = "0x24A9350", VA = "0x1824A9F50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x24A9F00", Offset = "0x24A9300", VA = "0x1824A9F00")]
		private SchedulerQueue GetQueue(QueueType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x24AA220", Offset = "0x24A9620", VA = "0x1824AA220")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAB83B0", Offset = "0xAB77B0", VA = "0x180AB83B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x24AA940", Offset = "0x24A9D40", VA = "0x1824AA940")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x24AA290", Offset = "0x24A9690", VA = "0x1824AA290")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x24AA2B0", Offset = "0x24A96B0", VA = "0x1824AA2B0")]
		private void OnRigidbodyExLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x24A9B10", Offset = "0x24A8F10", VA = "0x1824A9B10")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x24A9F40", Offset = "0x24A9340", VA = "0x1824A9F40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x24AA2A0", Offset = "0x24A96A0", VA = "0x1824AA2A0")]
		private void OnPreRenderUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x24A9AB0", Offset = "0x24A8EB0", VA = "0x1824A9AB0")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__29))]
		private IEnumerator EndOfFrameRoutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x24AA2C0", Offset = "0x24A96C0", VA = "0x1824AA2C0")]
		public ISchedulerPromise RunJobbed(IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x24AA2D0", Offset = "0x24A96D0", VA = "0x1824AA2D0")]
		public ISchedulerPromise RunJobbed(ISchedulerContext context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x24A9B20", Offset = "0x24A8F20", VA = "0x1824A9B20")]
		private void FlushJobbedReinserts(SchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x24AA420", Offset = "0x24A9820", VA = "0x1824AA420")]
		public ISchedulerPromise Run(Behaviour context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x24AA740", Offset = "0x24A9B40", VA = "0x1824AA740")]
		public void UpdateQueue(QueueType currentQueueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x24A9C70", Offset = "0x24A9070", VA = "0x1824A9C70")]
		private void FlushReinserts(SchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x24AAB70", Offset = "0x24A9F70", VA = "0x1824AAB70")]
		public Scheduler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ScheduleRate : ISchedule
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class <UpdateCoroutine>d__25 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public float hz;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public Action<float> update;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private ScheduleRate <schedule>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x24AC8B0", Offset = "0x24ABCB0", VA = "0x1824AC8B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x24ACA60", Offset = "0x24ABE60", VA = "0x1824ACA60", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7C03F0", Offset = "0x7BF7F0", VA = "0x1807C03F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x75C380", Offset = "0x75B780", VA = "0x18075C380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x328600", Offset = "0x327A00", VA = "0x180328600", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x45E2A0", Offset = "0x45D6A0", VA = "0x18045E2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7C0410", Offset = "0x7BF810", VA = "0x1807C0410", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x94E4F0", Offset = "0x94D8F0", VA = "0x18094E4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7B24D0", Offset = "0x7B18D0", VA = "0x1807B24D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7B25E0", Offset = "0x7B19E0", VA = "0x1807B25E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x24A2170", Offset = "0x24A1570", VA = "0x1824A2170")]
		public ScheduleRate(float targetRateHz, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x24A2040", Offset = "0x24A1440", VA = "0x1824A2040", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x24A2060", Offset = "0x24A1460", VA = "0x1824A2060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x24A1E10", Offset = "0x24A1210", VA = "0x1824A1E10")]
		public static ISchedulerPromise QueueUpdate(float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x24A1EC0", Offset = "0x24A12C0", VA = "0x1824A1EC0")]
		public static ISchedulerPromise QueueUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x24A1F80", Offset = "0x24A1380", VA = "0x1824A1F80")]
		public static ISchedulerPromise QueueUpdate(ISchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x24A20F0", Offset = "0x24A14F0", VA = "0x1824A20F0")]
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
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		float FixedDeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		double RealtimeSinceStartup
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
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
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x249F840", Offset = "0x249EC40", VA = "0x18249F840", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x249F7F0", Offset = "0x249EBF0", VA = "0x18249F7F0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float FixedDeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x249F800", Offset = "0x249EC00", VA = "0x18249F800", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x249F810", Offset = "0x249EC10", VA = "0x18249F810", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public double RealtimeSinceStartup
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x249F820", Offset = "0x249EC20", VA = "0x18249F820", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x320620", Offset = "0x31FA20", VA = "0x180320620")]
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
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x320E60", Offset = "0x320260", VA = "0x180320E60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x4B7530", Offset = "0x4B6930", VA = "0x1804B7530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7C03F0", Offset = "0x7BF7F0", VA = "0x1807C03F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x75C380", Offset = "0x75B780", VA = "0x18075C380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x24A2A40", Offset = "0x24A1E40", VA = "0x1824A2A40")]
		public ScheduleUntil(Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x24A2A00", Offset = "0x24A1E00", VA = "0x1824A2A00")]
		public ScheduleUntil(Scheduler.QueueType queueType, Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x24A29B0", Offset = "0x24A1DB0", VA = "0x1824A29B0", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class UntilUpdateExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class <UntilCoroutine>d__0 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Scheduler.QueueType queueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public Func<bool> condition;

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <UntilCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x24AC560", Offset = "0x24AB960", VA = "0x1824AC560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x24AC600", Offset = "0x24ABA00", VA = "0x1824AC600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x24ACC00", Offset = "0x24AC000", VA = "0x1824ACC00")]
		[IteratorStateMachine(typeof(<UntilCoroutine>d__0))]
		private static IEnumerator<ISchedule> UntilCoroutine(Scheduler.QueueType queueType, Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x24ACAB0", Offset = "0x24ABEB0", VA = "0x1824ACAB0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x3EDEF0", Offset = "0x3ED2F0", VA = "0x1803EDEF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x39B850", Offset = "0x39AC50", VA = "0x18039B850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7B7460", Offset = "0x7B6860", VA = "0x1807B7460", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x75C390", Offset = "0x75B790", VA = "0x18075C390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x24A2B00", Offset = "0x24A1F00", VA = "0x1824A2B00")]
		public ScheduleWait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x24A2A70", Offset = "0x24A1E70", VA = "0x1824A2A70", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class DelayedUpdateExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class <DelayedCoroutine>d__0 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public float seconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public Action function;

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <DelayedCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x24AB140", Offset = "0x24AA540", VA = "0x1824AB140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x24AB1F0", Offset = "0x24AA5F0", VA = "0x1824AB1F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class <InvokeRepeatedCoroutine>d__1 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public float seconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public Action function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private ISchedule <wait>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000180")]
				[Cpp2IlInjected.Address(RVA = "0x3185C0", Offset = "0x3179C0", VA = "0x1803185C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x321930", Offset = "0x320D30", VA = "0x180321930")]
			[DebuggerHidden]
			public <InvokeRepeatedCoroutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x31D100", Offset = "0x31C500", VA = "0x18031D100", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x24AB450", Offset = "0x24AA850", VA = "0x1824AB450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x24AB510", Offset = "0x24AA910", VA = "0x1824AB510", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x249F850", Offset = "0x249EC50", VA = "0x18249F850")]
		[IteratorStateMachine(typeof(<DelayedCoroutine>d__0))]
		private static IEnumerator<ISchedule> DelayedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x24A0460", Offset = "0x249F860", VA = "0x1824A0460")]
		[IteratorStateMachine(typeof(<InvokeRepeatedCoroutine>d__1))]
		private static IEnumerator<ISchedule> InvokeRepeatedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x24A0640", Offset = "0x249FA40", VA = "0x1824A0640")]
		public static IDisposable InvokeRepeated(this MonoBehaviour behaviour, float seconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x24A0780", Offset = "0x249FB80", VA = "0x1824A0780")]
		public static ISchedulerPromise ScheduleDelay(this MonoBehaviour behaviour, float seconds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x24A04E0", Offset = "0x249F8E0", VA = "0x1824A04E0")]
		public static ISchedulerPromise InvokeRepeated(this MonoBehaviour behaviour, float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x24A0320", Offset = "0x249F720", VA = "0x1824A0320")]
		public static ISchedulerPromise InvokeNextUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x24A00A0", Offset = "0x249F4A0", VA = "0x1824A00A0")]
		public static ISchedulerPromise InvokeNextLateUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x249FF60", Offset = "0x249F360", VA = "0x18249FF60")]
		public static ISchedulerPromise InvokeNextFixedUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x249FE20", Offset = "0x249F220", VA = "0x18249FE20")]
		public static ISchedulerPromise InvokeNextEndOfFrame(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x24A01E0", Offset = "0x249F5E0", VA = "0x1824A01E0")]
		public static ISchedulerPromise InvokeNextPreRender(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x249FD10", Offset = "0x249F110", VA = "0x18249FD10")]
		public static ISchedulerPromise InvokeInUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x249FAF0", Offset = "0x249EEF0", VA = "0x18249FAF0")]
		public static ISchedulerPromise InvokeInLateUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x249F9E0", Offset = "0x249EDE0", VA = "0x18249F9E0")]
		public static ISchedulerPromise InvokeInFixedUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x249F8D0", Offset = "0x249ECD0", VA = "0x18249F8D0")]
		public static ISchedulerPromise InvokeInEndOfFrame(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x249FC00", Offset = "0x249F000", VA = "0x18249FC00")]
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
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x24A1610", Offset = "0x24A0A10", VA = "0x1824A1610")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x24A1660", Offset = "0x24A0A60", VA = "0x1824A1660", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x19FEA20", Offset = "0x19FDE20", VA = "0x1819FEA20", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x19FEA10", Offset = "0x19FDE10", VA = "0x1819FEA10", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x24A1580", Offset = "0x24A0980", VA = "0x1824A1580")]
		public RollingBufferAverageStats(int maxBufferLength)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x24A1460", Offset = "0x24A0860", VA = "0x1824A1460", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x24A13F0", Offset = "0x24A07F0", VA = "0x1824A13F0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x31A520", Offset = "0x319920", VA = "0x18031A520")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x470650", Offset = "0x46FA50", VA = "0x180470650", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x19FEA40", Offset = "0x19FDE40", VA = "0x1819FEA40", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public double Variance
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x19FEA10", Offset = "0x19FDE10", VA = "0x1819FEA10")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public double StdDev
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x24A0A50", Offset = "0x249FE50", VA = "0x1824A0A50")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x19FE980", Offset = "0x19FDD80", VA = "0x1819FE980", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x24A0900", Offset = "0x249FD00", VA = "0x1824A0900", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x24A08C0", Offset = "0x249FCC0", VA = "0x1824A08C0", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x24A0A20", Offset = "0x249FE20", VA = "0x1824A0A20")]
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
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Track(double val);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Reset();
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
