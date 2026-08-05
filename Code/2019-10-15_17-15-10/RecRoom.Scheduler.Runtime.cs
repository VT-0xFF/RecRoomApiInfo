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
				[Cpp2IlInjected.Token(Token = "0x14000001")]
				public static event Action OnPostUpdate
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0x24139D0", Offset = "0x24125D0", VA = "0x1824139D0")]
					[CompilerGenerated]
					add
					{
					}
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0x2413AC0", Offset = "0x24126C0", VA = "0x182413AC0")]
					[CompilerGenerated]
					remove
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x2413890", Offset = "0x2412490", VA = "0x182413890")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003A")]
			public struct RigidbodyExLateUpdateSystem
			{
				[Cpp2IlInjected.Token(Token = "0x14000002")]
				public static event Action OnRigidbodyExLateUpdate
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0x2414100", Offset = "0x2412D00", VA = "0x182414100")]
					[CompilerGenerated]
					add
					{
					}
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0x24141F0", Offset = "0x2412DF0", VA = "0x1824141F0")]
					[CompilerGenerated]
					remove
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000186")]
				[Cpp2IlInjected.Address(RVA = "0x2413FC0", Offset = "0x2412BC0", VA = "0x182413FC0")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003B")]
			public struct PreRenderSystem
			{
				[Cpp2IlInjected.Token(Token = "0x14000003")]
				public static event Action OnPreRenderUpdate
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0x2413CF0", Offset = "0x24128F0", VA = "0x182413CF0")]
					[CompilerGenerated]
					add
					{
					}
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0x2413DE0", Offset = "0x24129E0", VA = "0x182413DE0")]
					[CompilerGenerated]
					remove
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x2413BB0", Offset = "0x24127B0", VA = "0x182413BB0")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003C")]
			internal struct WrapperPreSystem
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x241FA80", Offset = "0x241E680", VA = "0x18241FA80")]
				public static PlayerLoopSystem GetNewSystem(TimerAnalytics.WrapperKey key)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003D")]
			internal struct WrapperPostSystem
			{
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x241F980", Offset = "0x241E580", VA = "0x18241F980")]
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
			[Cpp2IlInjected.Address(RVA = "0x2412570", Offset = "0x2411170", VA = "0x182412570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x24125B0", Offset = "0x24111B0", VA = "0x1824125B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2411010", Offset = "0x240FC10", VA = "0x182411010")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2412310", Offset = "0x2410F10", VA = "0x182412310")]
		private static void TryTimerWrapSubSystem(TimerAnalytics.WrapperKey key, ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2411E70", Offset = "0x2410A70", VA = "0x182411E70")]
		private static void ModifySubsystemList(ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType, SubsystemListModification subsystemListModification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2412210", Offset = "0x2410E10", VA = "0x182412210")]
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
			[Cpp2IlInjected.Address(RVA = "0x2410F10", Offset = "0x240FB10", VA = "0x182410F10")]
			public CallWrapper(WrapperKey wrapperKey, int bufferSize = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2410EF0", Offset = "0x240FAF0", VA = "0x182410EF0")]
			public void SetBufferLength(int bufferLength)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2410E30", Offset = "0x240FA30", VA = "0x182410E30")]
			public void ResetTimer()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x2410E00", Offset = "0x240FA00", VA = "0x182410E00")]
			public void RegisterStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2410CB0", Offset = "0x240F8B0", VA = "0x182410CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x241DAB0", Offset = "0x241C6B0", VA = "0x18241DAB0")]
		public static CallWrapper CreateWrapper(WrapperKey key, int bufferSize = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x241DC70", Offset = "0x241C870", VA = "0x18241DC70")]
		public static CallWrapper GetWrapper(WrapperKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x241DD00", Offset = "0x241C900", VA = "0x18241DD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A0950", Offset = "0x39F550", VA = "0x1803A0950")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2413ED0", Offset = "0x2412AD0", VA = "0x182413ED0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x140AF90", Offset = "0x1409B90", VA = "0x18140AF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3420D0", Offset = "0x340CD0", VA = "0x1803420D0", Slot = "6")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x140B3B0", Offset = "0x1409FB0", VA = "0x18140B3B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x140A440", Offset = "0x1409040", VA = "0x18140A440")]
		private static bool AreEqual(T a, T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x140AED0", Offset = "0x1409AD0", VA = "0x18140AED0")]
		public ReactiveProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x140AF00", Offset = "0x1409B00", VA = "0x18140AF00")]
		public ReactiveProperty(T initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x140A4B0", Offset = "0x14090B0", VA = "0x18140A4B0")]
		public void ForceUpdate(T newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x140AB50", Offset = "0x1409750", VA = "0x18140AB50", Slot = "7")]
		public IDisposable Observe(Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x140AD00", Offset = "0x1409900", VA = "0x18140AD00", Slot = "8")]
		public IDisposable Observe(UnityEngine.Object context, Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x140A820", Offset = "0x1409420", VA = "0x18140A820")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <Example>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x241E090", Offset = "0x241CC90", VA = "0x18241E090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x241E180", Offset = "0x241CD80", VA = "0x18241E180", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2415B40", Offset = "0x2414740", VA = "0x182415B40")]
		public static ISchedule Wait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2415AE0", Offset = "0x24146E0", VA = "0x182415AE0")]
		public static ISchedule Until(Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x24159E0", Offset = "0x24145E0", VA = "0x1824159E0")]
		public static ISchedule AfterCompleted(IPromise promise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2415A90", Offset = "0x2414690", VA = "0x182415A90")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x241E2E0", Offset = "0x241CEE0", VA = "0x18241E2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x241E440", Offset = "0x241D040", VA = "0x18241E440", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2418630", Offset = "0x2417230", VA = "0x182418630")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x24187A0", Offset = "0x24173A0", VA = "0x1824187A0")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2418910", Offset = "0x2417510", VA = "0x182418910")]
		public ScheduledUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x24181F0", Offset = "0x2416DF0", VA = "0x1824181F0")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x24180A0", Offset = "0x2416CA0", VA = "0x1824180A0")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2417F70", Offset = "0x2416B70", VA = "0x182417F70")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x24183A0", Offset = "0x2416FA0", VA = "0x1824183A0")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2418340", Offset = "0x2416F40", VA = "0x182418340")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2417F20", Offset = "0x2416B20", VA = "0x182417F20", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ScheduledUpdateMonoBehaviourExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2417B40", Offset = "0x2416740", VA = "0x182417B40")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x24179A0", Offset = "0x24165A0", VA = "0x1824179A0")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2417EB0", Offset = "0x2416AB0", VA = "0x182417EB0")]
		public static IDisposable Update(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x24175B0", Offset = "0x24161B0", VA = "0x1824175B0")]
		public static IDisposable FixedUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2417830", Offset = "0x2416430", VA = "0x182417830")]
		public static IDisposable LateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2417BC0", Offset = "0x24167C0", VA = "0x182417BC0")]
		public static IDisposable RigidbodyExLateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x24178A0", Offset = "0x24164A0", VA = "0x1824178A0")]
		public static IDisposable PreRenderUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2417910", Offset = "0x2416510", VA = "0x182417910")]
		public static IDisposable QueueUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2417E30", Offset = "0x2416A30", VA = "0x182417E30")]
		public static IDisposable UpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2417D30", Offset = "0x2416930", VA = "0x182417D30")]
		public static IDisposable Update30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2417C30", Offset = "0x2416830", VA = "0x182417C30")]
		public static IDisposable Update10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2417DB0", Offset = "0x24169B0", VA = "0x182417DB0")]
		public static IDisposable Update5hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2417CB0", Offset = "0x24168B0", VA = "0x182417CB0")]
		public static IDisposable Update1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2417520", Offset = "0x2416120", VA = "0x182417520")]
		public static IDisposable FixedUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x24174A0", Offset = "0x24160A0", VA = "0x1824174A0")]
		public static IDisposable FixedUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x24173A0", Offset = "0x2415FA0", VA = "0x1824173A0")]
		public static IDisposable FixedUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2417420", Offset = "0x2416020", VA = "0x182417420")]
		public static IDisposable FixedUpdate1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x24177A0", Offset = "0x24163A0", VA = "0x1824177A0")]
		public static IDisposable LateUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2417720", Offset = "0x2416320", VA = "0x182417720")]
		public static IDisposable LateUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2417620", Offset = "0x2416220", VA = "0x182417620")]
		public static IDisposable LateUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x24176A0", Offset = "0x24162A0", VA = "0x1824176A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x241E390", Offset = "0x241CF90", VA = "0x18241E390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x241E490", Offset = "0x241D090", VA = "0x18241E490", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x24165D0", Offset = "0x24151D0", VA = "0x1824165D0")]
		public ScheduledContextUpdate(ISchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2416460", Offset = "0x2415060", VA = "0x182416460")]
		public ScheduledContextUpdate(ISchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2416740", Offset = "0x2415340", VA = "0x182416740")]
		public ScheduledContextUpdate(ISchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2416010", Offset = "0x2414C10", VA = "0x182416010")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2415EC0", Offset = "0x2414AC0", VA = "0x182415EC0")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2415D90", Offset = "0x2414990", VA = "0x182415D90")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x24161C0", Offset = "0x2414DC0", VA = "0x1824161C0")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2416160", Offset = "0x2414D60", VA = "0x182416160")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2415D40", Offset = "0x2414940", VA = "0x182415D40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class ScheduledUpdateContextExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2417040", Offset = "0x2415C40", VA = "0x182417040")]
		public static IDisposable QueueUpdateJobbed(this ISchedulerContext behaviour, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2416EA0", Offset = "0x2415AA0", VA = "0x182416EA0")]
		public static IDisposable QueueUpdateJobbed(this ISchedulerContext behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2417330", Offset = "0x2415F30", VA = "0x182417330")]
		public static IDisposable UpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2416AB0", Offset = "0x24156B0", VA = "0x182416AB0")]
		public static IDisposable FixedUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2416D30", Offset = "0x2415930", VA = "0x182416D30")]
		public static IDisposable LateUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x24170C0", Offset = "0x2415CC0", VA = "0x1824170C0")]
		public static IDisposable RigidbodyExLateUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2416DA0", Offset = "0x24159A0", VA = "0x182416DA0")]
		public static IDisposable PreRenderUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2416E10", Offset = "0x2415A10", VA = "0x182416E10")]
		public static IDisposable QueueUpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x24172B0", Offset = "0x2415EB0", VA = "0x1824172B0")]
		public static IDisposable UpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2417230", Offset = "0x2415E30", VA = "0x182417230")]
		public static IDisposable Update30hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2417130", Offset = "0x2415D30", VA = "0x182417130")]
		public static IDisposable Update10hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x24171B0", Offset = "0x2415DB0", VA = "0x1824171B0")]
		public static IDisposable Update1hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2416A20", Offset = "0x2415620", VA = "0x182416A20")]
		public static IDisposable FixedUpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x24169A0", Offset = "0x24155A0", VA = "0x1824169A0")]
		public static IDisposable FixedUpdate30hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x24168A0", Offset = "0x24154A0", VA = "0x1824168A0")]
		public static IDisposable FixedUpdate10hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2416920", Offset = "0x2415520", VA = "0x182416920")]
		public static IDisposable FixedUpdate1hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2416CA0", Offset = "0x24158A0", VA = "0x182416CA0")]
		public static IDisposable LateUpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2416C20", Offset = "0x2415820", VA = "0x182416C20")]
		public static IDisposable LateUpdate30hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2416B20", Offset = "0x2415720", VA = "0x182416B20")]
		public static IDisposable LateUpdate10hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2416BA0", Offset = "0x24157A0", VA = "0x182416BA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x241F3C0", Offset = "0x241DFC0", VA = "0x18241F3C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x241F490", Offset = "0x241E090", VA = "0x18241F490", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x241F4E0", Offset = "0x241E0E0", VA = "0x18241F4E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x241F5D0", Offset = "0x241E1D0", VA = "0x18241F5D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x337C70", Offset = "0x336870", VA = "0x180337C70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x337CA0", Offset = "0x3368A0", VA = "0x180337CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x595F20", Offset = "0x594B20", VA = "0x180595F20", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
		public ScheduleNextFrame(Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x363590", Offset = "0x362190", VA = "0x180363590", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x24146D0", Offset = "0x24132D0", VA = "0x1824146D0")]
		public static ISchedulerPromise QueueUpdate(Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2414990", Offset = "0x2413590", VA = "0x182414990")]
		public static ISchedulerPromise QueueUpdate(Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x24148A0", Offset = "0x24134A0", VA = "0x1824148A0")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x24147B0", Offset = "0x24133B0", VA = "0x1824147B0")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x24145E0", Offset = "0x24131E0", VA = "0x1824145E0")]
		public static ISchedulerPromise QueueUpdate(ISchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2414A70", Offset = "0x2413670", VA = "0x182414A70")]
		public static ISchedulerPromise QueueUpdate(ISchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2414B60", Offset = "0x2413760", VA = "0x182414B60")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__14))]
		private static IEnumerator<ISchedule> UpdateCoroutine(Scheduler.QueueType queue, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2414BD0", Offset = "0x24137D0", VA = "0x182414BD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x31A550", Offset = "0x319150", VA = "0x18031A550", Slot = "22")]
				get
				{
					return default(QueueType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public QueueType Queue
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x31A550", Offset = "0x319150", VA = "0x18031A550")]
				get
				{
					return default(QueueType);
				}
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x31A590", Offset = "0x319190", VA = "0x18031A590")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			float ISchedule.NextPossibleReady
			{
				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x595F20", Offset = "0x594B20", VA = "0x180595F20", Slot = "24")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2418F00", Offset = "0x2417B00", VA = "0x182418F00", Slot = "23")]
			bool ISchedule.Ready()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2418F10", Offset = "0x2417B10", VA = "0x182418F10")]
			public SchedulerPromise()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2418EC0", Offset = "0x2417AC0", VA = "0x182418EC0")]
			private void CancelRoutine()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2418EF0", Offset = "0x2417AF0", VA = "0x182418EF0", Slot = "25")]
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
			[Cpp2IlInjected.Address(RVA = "0x2415080", Offset = "0x2413C80", VA = "0x182415080")]
			public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
			{
				return default(ScheduleSortJob);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x2580E0", Offset = "0x2574E0", VA = "0x1802580E0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x258190", Offset = "0x257590", VA = "0x180258190")]
			private bool ShouldExecute(int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x258130", Offset = "0x257530", VA = "0x180258130")]
			private void MergeSort(NativeArray<int> arr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2580F0", Offset = "0x2574F0", VA = "0x1802580F0")]
			private int IndexCompare(int indexA, int indexB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x258100", Offset = "0x257500", VA = "0x180258100")]
			private void MergeSortImpl(NativeArray<int> arr, int l, int r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x258150", Offset = "0x257550", VA = "0x180258150")]
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
				[Cpp2IlInjected.Address(RVA = "0x337C70", Offset = "0x336870", VA = "0x180337C70", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x337CA0", Offset = "0x3368A0", VA = "0x180337CA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2413680", Offset = "0x2412280", VA = "0x182413680")]
			public static ISchedule Step(IEnumerator<ISchedule> coroutine, SchedulerPromise promise)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x24137B0", Offset = "0x24123B0", VA = "0x1824137B0")]
			public ISchedule Step(SchedulerPromise[] allScheduledPromises, IEnumerator<ISchedule>[] coroutines, ISchedule[] currentSchedules)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x24134D0", Offset = "0x24120D0", VA = "0x1824134D0")]
			public void OnContextDestroyed()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x24135C0", Offset = "0x24121C0", VA = "0x1824135C0")]
			public void OnContextEnabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x2413500", Offset = "0x2412100", VA = "0x182413500")]
			public void OnContextDisabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x24134D0", Offset = "0x24120D0", VA = "0x1824134D0")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x342100", Offset = "0x340D00", VA = "0x180342100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public ISchedule CurrentSchedule
			{
				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0x337CB0", Offset = "0x3368B0", VA = "0x180337CB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public bool Paused
			{
				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2418E30", Offset = "0x2417A30", VA = "0x182418E30")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public bool Canceled
			{
				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x668E10", Offset = "0x667A10", VA = "0x180668E10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xBB0FF0", Offset = "0xBAFBF0", VA = "0x180BB0FF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x322020", Offset = "0x320C20", VA = "0x180322020")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x322030", Offset = "0x320C30", VA = "0x180322030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public float NextUpdateKey
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x4830C0", Offset = "0x481CC0", VA = "0x1804830C0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x483200", Offset = "0x481E00", VA = "0x180483200")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x2418CB0", Offset = "0x24178B0", VA = "0x182418CB0")]
			public SchedulerCoroutine(IEnumerator<ISchedule> coroutine, Behaviour context, SchedulerPromise promise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x2418A70", Offset = "0x2417670", VA = "0x182418A70")]
			public ISchedule Step()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x2418C20", Offset = "0x2417820", VA = "0x182418C20", Slot = "3")]
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
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x241D970", Offset = "0x241C570", VA = "0x18241D970", Slot = "4")]
				public int Compare(SchedulerCoroutine x, SchedulerCoroutine y)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x8BDEC0", Offset = "0x8BCAC0", VA = "0x1808BDEC0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public int Capacity
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x1281EE0", Offset = "0x1280AE0", VA = "0x181281EE0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public QueueType Queue
			{
				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0x12C48C0", Offset = "0x12C34C0", VA = "0x1812C48C0")]
				[CompilerGenerated]
				get
				{
					return default(QueueType);
				}
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x15BBE40", Offset = "0x15BAA40", VA = "0x1815BBE40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public ReinsertBuffer[,] ReinsertionQueues
			{
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x395FD0", Offset = "0x394BD0", VA = "0x180395FD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x465950", Offset = "0x464550", VA = "0x180465950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x24194C0", Offset = "0x24180C0", VA = "0x1824194C0")]
			private static int GetInitialCapacity(QueueType queueType)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x241B8D0", Offset = "0x241A4D0", VA = "0x18241B8D0")]
			public SchedulerQueue(QueueType queue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2419E50", Offset = "0x2418A50", VA = "0x182419E50")]
			public void LogFutureRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x2419E60", Offset = "0x2418A60", VA = "0x182419E60")]
			public void LogImmediateRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2419E70", Offset = "0x2418A70", VA = "0x182419E70")]
			private void LogRoutines(IReadOnlyList<SchedulerCoroutine> routines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x241AD20", Offset = "0x2419920", VA = "0x18241AD20")]
			private void ResizeArrays(ref int oldCapacity, int newCapacity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2419A30", Offset = "0x2418630", VA = "0x182419A30")]
			public void InsertJobbedSchedulerCoroutine(ISchedulerContext context, ISchedule currentSchedule, IEnumerator<ISchedule> coroutine, SchedulerPromise promise, [Optional] JobbedSchedulerCoroutine routine, CoroutineState coroutineState = CoroutineState.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x241A8E0", Offset = "0x24194E0", VA = "0x18241A8E0")]
			private JobbedInsertionData RemoveSchedulerCoroutine(int indexToRemove)
			{
				return default(JobbedInsertionData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xBA54E0", Offset = "0xBA40E0", VA = "0x180BA54E0")]
			private static void SwapBackFill<T>(int indexToRemove, T[] myArray, int size, [Optional] T fillValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xBA54C0", Offset = "0xBA40C0", VA = "0x180BA54C0")]
			private static void SwapBackFill<T>(int indexToRemove, NativeArray<T> myArray, int size, [Optional] T fillValue) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2419D60", Offset = "0x2418960", VA = "0x182419D60")]
			public void InsertSingleCoroutine(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2419790", Offset = "0x2418390", VA = "0x182419790")]
			public void InsertImmediates(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2419B60", Offset = "0x2418760", VA = "0x182419B60")]
			public void InsertJobbed(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x241A4C0", Offset = "0x24190C0", VA = "0x18241A4C0")]
			private void QueueMultipleForInsertion(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x24194F0", Offset = "0x24180F0", VA = "0x1824194F0")]
			public void InsertFutures(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x241A140", Offset = "0x2418D40", VA = "0x18241A140")]
			private void QueueForReinsertJobbed(JobbedInsertionData jobbedInsertionData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x241A210", Offset = "0x2418E10", VA = "0x18241A210")]
			private void QueueForReinsert(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x241A770", Offset = "0x2419370", VA = "0x18241A770")]
			private void QueueMultipleForReinsert(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x241AEA0", Offset = "0x2419AA0", VA = "0x18241AEA0")]
			private TickResult TickCoroutine(SchedulerCoroutine coroutine)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x241B020", Offset = "0x2419C20", VA = "0x18241B020")]
			private TickResult TickJobbedCoroutine(int scheduleIndex)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x241A310", Offset = "0x2418F10", VA = "0x18241A310")]
			public void QueueJob(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x241A040", Offset = "0x2418C40", VA = "0x18241A040")]
			private void QueueAddRemoveAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x241A0C0", Offset = "0x2418CC0", VA = "0x18241A0C0")]
			private void QueueCoroutineStateChangeAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x241B390", Offset = "0x2419F90", VA = "0x18241B390")]
			public void UpdateJobSortedCoroutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x241B830", Offset = "0x241A430", VA = "0x18241B830")]
			public void Update(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x24192F0", Offset = "0x2417EF0", VA = "0x1824192F0")]
			private void DoImmediateUpdates()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x24190F0", Offset = "0x2417CF0", VA = "0x1824190F0")]
			private void DoFutureUpdates(float now)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x2419030", Offset = "0x2417C30", VA = "0x182419030", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x2418F80", Offset = "0x2417B80", VA = "0x182418F80")]
			public void Cancel(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x2419F90", Offset = "0x2418B90", VA = "0x182419F90")]
			public void Pause(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x241B2E0", Offset = "0x2419EE0", VA = "0x18241B2E0")]
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
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000164")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__29(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x241DFC0", Offset = "0x241CBC0", VA = "0x18241DFC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x241E040", Offset = "0x241CC40", VA = "0x18241E040", Slot = "8")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private SchedulerQueue[] queues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private Coroutine endOfFrameRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private WaitForEndOfFrame waitForEndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ISchedulerTimer Timer
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x31A680", Offset = "0x319280", VA = "0x18031A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x31A700", Offset = "0x319300", VA = "0x18031A700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x241CA10", Offset = "0x241B610", VA = "0x18241CA10")]
		public static ISchedulerPromise GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x241C0B0", Offset = "0x241ACB0", VA = "0x18241C0B0", Slot = "7")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x241CAD0", Offset = "0x241B6D0", VA = "0x18241CAD0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x182EA20", Offset = "0x182D620", VA = "0x18182EA20")]
		private SchedulerQueue GetQueue(QueueType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x241CFA0", Offset = "0x241BBA0", VA = "0x18241CFA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x241CF70", Offset = "0x241BB70", VA = "0x18241CF70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x241D6C0", Offset = "0x241C2C0", VA = "0x18241D6C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x241D010", Offset = "0x241BC10", VA = "0x18241D010")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x241D030", Offset = "0x241BC30", VA = "0x18241D030")]
		private void OnRigidbodyExLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x241C6D0", Offset = "0x241B2D0", VA = "0x18241C6D0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x241CAC0", Offset = "0x241B6C0", VA = "0x18241CAC0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x241D020", Offset = "0x241BC20", VA = "0x18241D020")]
		private void OnPreRenderUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x241C670", Offset = "0x241B270", VA = "0x18241C670")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__29))]
		private IEnumerator EndOfFrameRoutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x241D040", Offset = "0x241BC40", VA = "0x18241D040")]
		public ISchedulerPromise RunJobbed(IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x241D050", Offset = "0x241BC50", VA = "0x18241D050")]
		public ISchedulerPromise RunJobbed(ISchedulerContext context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x241C6E0", Offset = "0x241B2E0", VA = "0x18241C6E0")]
		private void FlushJobbedReinserts(SchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x241D1A0", Offset = "0x241BDA0", VA = "0x18241D1A0")]
		public ISchedulerPromise Run(Behaviour context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x241D4C0", Offset = "0x241C0C0", VA = "0x18241D4C0")]
		public void UpdateQueue(QueueType currentQueueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x241C830", Offset = "0x241B430", VA = "0x18241C830")]
		private void FlushReinserts(SchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x241D8F0", Offset = "0x241C4F0", VA = "0x18241D8F0")]
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
				[Cpp2IlInjected.Token(Token = "0x600016B")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x241F620", Offset = "0x241E220", VA = "0x18241F620", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x241F7D0", Offset = "0x241E3D0", VA = "0x18241F7D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x321A00", Offset = "0x320600", VA = "0x180321A00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x96F6B0", Offset = "0x96E2B0", VA = "0x18096F6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x445120", Offset = "0x443D20", VA = "0x180445120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x59D7B0", Offset = "0x59C3B0", VA = "0x18059D7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5B30A0", Offset = "0x5B1CA0", VA = "0x1805B30A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5B32B0", Offset = "0x5B1EB0", VA = "0x1805B32B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x4E9B30", Offset = "0x4E8730", VA = "0x1804E9B30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x407D00", Offset = "0x406900", VA = "0x180407D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2414FA0", Offset = "0x2413BA0", VA = "0x182414FA0")]
		public ScheduleRate(float targetRateHz, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2414E70", Offset = "0x2413A70", VA = "0x182414E70", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2414E90", Offset = "0x2413A90", VA = "0x182414E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2414C40", Offset = "0x2413840", VA = "0x182414C40")]
		public static ISchedulerPromise QueueUpdate(float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2414CF0", Offset = "0x24138F0", VA = "0x182414CF0")]
		public static ISchedulerPromise QueueUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2414DB0", Offset = "0x24139B0", VA = "0x182414DB0")]
		public static ISchedulerPromise QueueUpdate(ISchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2414F20", Offset = "0x2413B20", VA = "0x182414F20")]
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
			[Cpp2IlInjected.Address(RVA = "0x2412640", Offset = "0x2411240", VA = "0x182412640", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x24125F0", Offset = "0x24111F0", VA = "0x1824125F0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float FixedDeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2412600", Offset = "0x2411200", VA = "0x182412600", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2412610", Offset = "0x2411210", VA = "0x182412610", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public double RealtimeSinceStartup
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2412620", Offset = "0x2411220", VA = "0x182412620", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x33A7F0", Offset = "0x3393F0", VA = "0x18033A7F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3581E0", Offset = "0x356DE0", VA = "0x1803581E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x321A00", Offset = "0x320600", VA = "0x180321A00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x96F6B0", Offset = "0x96E2B0", VA = "0x18096F6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2415870", Offset = "0x2414470", VA = "0x182415870")]
		public ScheduleUntil(Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2415830", Offset = "0x2414430", VA = "0x182415830")]
		public ScheduleUntil(Scheduler.QueueType queueType, Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x24157E0", Offset = "0x24143E0", VA = "0x1824157E0", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <UntilCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x241F2D0", Offset = "0x241DED0", VA = "0x18241F2D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x241F370", Offset = "0x241DF70", VA = "0x18241F370", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x241F910", Offset = "0x241E510", VA = "0x18241F910")]
		[IteratorStateMachine(typeof(<UntilCoroutine>d__0))]
		private static IEnumerator<ISchedule> UntilCoroutine(Scheduler.QueueType queueType, Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x241F820", Offset = "0x241E420", VA = "0x18241F820")]
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
			[Cpp2IlInjected.Address(RVA = "0x5196C0", Offset = "0x5182C0", VA = "0x1805196C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5196D0", Offset = "0x5182D0", VA = "0x1805196D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x3219F0", Offset = "0x3205F0", VA = "0x1803219F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x536720", Offset = "0x535320", VA = "0x180536720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2415930", Offset = "0x2414530", VA = "0x182415930")]
		public ScheduleWait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x24158A0", Offset = "0x24144A0", VA = "0x1824158A0", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <DelayedCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x241DEC0", Offset = "0x241CAC0", VA = "0x18241DEC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x241DF70", Offset = "0x241CB70", VA = "0x18241DF70", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
			[DebuggerHidden]
			public <InvokeRepeatedCoroutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x241E1D0", Offset = "0x241CDD0", VA = "0x18241E1D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x241E290", Offset = "0x241CE90", VA = "0x18241E290", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2412650", Offset = "0x2411250", VA = "0x182412650")]
		[IteratorStateMachine(typeof(<DelayedCoroutine>d__0))]
		private static IEnumerator<ISchedule> DelayedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2412FE0", Offset = "0x2411BE0", VA = "0x182412FE0")]
		[IteratorStateMachine(typeof(<InvokeRepeatedCoroutine>d__1))]
		private static IEnumerator<ISchedule> InvokeRepeatedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2413160", Offset = "0x2411D60", VA = "0x182413160")]
		public static IDisposable InvokeRepeated(this MonoBehaviour behaviour, float seconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2413250", Offset = "0x2411E50", VA = "0x182413250")]
		public static ISchedulerPromise ScheduleDelay(this MonoBehaviour behaviour, float seconds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2413060", Offset = "0x2411C60", VA = "0x182413060")]
		public static ISchedulerPromise InvokeRepeated(this MonoBehaviour behaviour, float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2412F00", Offset = "0x2411B00", VA = "0x182412F00")]
		public static ISchedulerPromise InvokeNextUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2412D40", Offset = "0x2411940", VA = "0x182412D40")]
		public static ISchedulerPromise InvokeNextLateUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2412C60", Offset = "0x2411860", VA = "0x182412C60")]
		public static ISchedulerPromise InvokeNextFixedUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2412B80", Offset = "0x2411780", VA = "0x182412B80")]
		public static ISchedulerPromise InvokeNextEndOfFrame(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2412E20", Offset = "0x2411A20", VA = "0x182412E20")]
		public static ISchedulerPromise InvokeNextPreRender(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2412A90", Offset = "0x2411690", VA = "0x182412A90")]
		public static ISchedulerPromise InvokeInUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x24128B0", Offset = "0x24114B0", VA = "0x1824128B0")]
		public static ISchedulerPromise InvokeInLateUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x24127C0", Offset = "0x24113C0", VA = "0x1824127C0")]
		public static ISchedulerPromise InvokeInFixedUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x24126D0", Offset = "0x24112D0", VA = "0x1824126D0")]
		public static ISchedulerPromise InvokeInEndOfFrame(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x24129A0", Offset = "0x24115A0", VA = "0x1824129A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2414500", Offset = "0x2413100", VA = "0x182414500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2414550", Offset = "0x2413150", VA = "0x182414550", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x173ED30", Offset = "0x173D930", VA = "0x18173ED30", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x173ED20", Offset = "0x173D920", VA = "0x18173ED20", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2414470", Offset = "0x2413070", VA = "0x182414470")]
		public RollingBufferAverageStats(int maxBufferLength)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2414350", Offset = "0x2412F50", VA = "0x182414350", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x24142E0", Offset = "0x2412EE0", VA = "0x1824142E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x14C7A40", Offset = "0x14C6640", VA = "0x1814C7A40", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x173ED50", Offset = "0x173D950", VA = "0x18173ED50", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public double Variance
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x173ED20", Offset = "0x173D920", VA = "0x18173ED20")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public double StdDev
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x24134C0", Offset = "0x24120C0", VA = "0x1824134C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x173EC90", Offset = "0x173D890", VA = "0x18173EC90", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2413370", Offset = "0x2411F70", VA = "0x182413370", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2413330", Offset = "0x2411F30", VA = "0x182413330", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2413490", Offset = "0x2412090", VA = "0x182413490")]
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
