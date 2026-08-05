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
					[Cpp2IlInjected.Address(RVA = "0x2097600", Offset = "0x2096800", VA = "0x182097600")]
					[CompilerGenerated]
					add
					{
					}
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0x20976F0", Offset = "0x20968F0", VA = "0x1820976F0")]
					[CompilerGenerated]
					remove
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000182")]
				[Cpp2IlInjected.Address(RVA = "0x20974C0", Offset = "0x20966C0", VA = "0x1820974C0")]
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
					[Cpp2IlInjected.Address(RVA = "0x2097D30", Offset = "0x2096F30", VA = "0x182097D30")]
					[CompilerGenerated]
					add
					{
					}
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0x2097E20", Offset = "0x2097020", VA = "0x182097E20")]
					[CompilerGenerated]
					remove
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000186")]
				[Cpp2IlInjected.Address(RVA = "0x2097BF0", Offset = "0x2096DF0", VA = "0x182097BF0")]
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
					[Cpp2IlInjected.Address(RVA = "0x2097920", Offset = "0x2096B20", VA = "0x182097920")]
					[CompilerGenerated]
					add
					{
					}
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0x2097A10", Offset = "0x2096C10", VA = "0x182097A10")]
					[CompilerGenerated]
					remove
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x20977E0", Offset = "0x20969E0", VA = "0x1820977E0")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003C")]
			internal struct WrapperPreSystem
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(RVA = "0x20A36B0", Offset = "0x20A28B0", VA = "0x1820A36B0")]
				public static PlayerLoopSystem GetNewSystem(TimerAnalytics.WrapperKey key)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200003D")]
			internal struct WrapperPostSystem
			{
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0x20A35B0", Offset = "0x20A27B0", VA = "0x1820A35B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2096190", Offset = "0x2095390", VA = "0x182096190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x20961D0", Offset = "0x20953D0", VA = "0x1820961D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2094C30", Offset = "0x2093E30", VA = "0x182094C30")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2095F30", Offset = "0x2095130", VA = "0x182095F30")]
		private static void TryTimerWrapSubSystem(TimerAnalytics.WrapperKey key, ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2095A90", Offset = "0x2094C90", VA = "0x182095A90")]
		private static void ModifySubsystemList(ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType, SubsystemListModification subsystemListModification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2095E30", Offset = "0x2095030", VA = "0x182095E30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2094B30", Offset = "0x2093D30", VA = "0x182094B30")]
			public CallWrapper(WrapperKey wrapperKey, int bufferSize = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2094B10", Offset = "0x2093D10", VA = "0x182094B10")]
			public void SetBufferLength(int bufferLength)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2094A50", Offset = "0x2093C50", VA = "0x182094A50")]
			public void ResetTimer()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x2094A20", Offset = "0x2093C20", VA = "0x182094A20")]
			public void RegisterStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x20948D0", Offset = "0x2093AD0", VA = "0x1820948D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x20A16E0", Offset = "0x20A08E0", VA = "0x1820A16E0")]
		public static CallWrapper CreateWrapper(WrapperKey key, int bufferSize = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x20A18A0", Offset = "0x20A0AA0", VA = "0x1820A18A0")]
		public static CallWrapper GetWrapper(WrapperKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x20A1930", Offset = "0x20A0B30", VA = "0x1820A1930")]
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
		[Cpp2IlInjected.Address(RVA = "0x3214B0", Offset = "0x3206B0", VA = "0x1803214B0")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2097B00", Offset = "0x2096D00", VA = "0x182097B00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1739E80", Offset = "0x1739080", VA = "0x181739E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3096B0", Offset = "0x3088B0", VA = "0x1803096B0", Slot = "6")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x173A2A0", Offset = "0x17394A0", VA = "0x18173A2A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1739330", Offset = "0x1738530", VA = "0x181739330")]
		private static bool AreEqual(T a, T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1739DC0", Offset = "0x1738FC0", VA = "0x181739DC0")]
		public ReactiveProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1739DF0", Offset = "0x1738FF0", VA = "0x181739DF0")]
		public ReactiveProperty(T initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x17393A0", Offset = "0x17385A0", VA = "0x1817393A0")]
		public void ForceUpdate(T newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1739A40", Offset = "0x1738C40", VA = "0x181739A40", Slot = "7")]
		public IDisposable Observe(Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1739BF0", Offset = "0x1738DF0", VA = "0x181739BF0", Slot = "8")]
		public IDisposable Observe(UnityEngine.Object context, Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1739710", Offset = "0x1738910", VA = "0x181739710")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <Example>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x20A1CC0", Offset = "0x20A0EC0", VA = "0x1820A1CC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x20A1DB0", Offset = "0x20A0FB0", VA = "0x1820A1DB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x2099770", Offset = "0x2098970", VA = "0x182099770")]
		public static ISchedule Wait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2099710", Offset = "0x2098910", VA = "0x182099710")]
		public static ISchedule Until(Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2099610", Offset = "0x2098810", VA = "0x182099610")]
		public static ISchedule AfterCompleted(IPromise promise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x20996C0", Offset = "0x20988C0", VA = "0x1820996C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x20A1F10", Offset = "0x20A1110", VA = "0x1820A1F10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x20A2070", Offset = "0x20A1270", VA = "0x1820A2070", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x209C260", Offset = "0x209B460", VA = "0x18209C260")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x209C3D0", Offset = "0x209B5D0", VA = "0x18209C3D0")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x209C540", Offset = "0x209B740", VA = "0x18209C540")]
		public ScheduledUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x209BE20", Offset = "0x209B020", VA = "0x18209BE20")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x209BCD0", Offset = "0x209AED0", VA = "0x18209BCD0")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x209BBA0", Offset = "0x209ADA0", VA = "0x18209BBA0")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x209BFD0", Offset = "0x209B1D0", VA = "0x18209BFD0")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x209BF70", Offset = "0x209B170", VA = "0x18209BF70")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x209BB50", Offset = "0x209AD50", VA = "0x18209BB50", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class ScheduledUpdateMonoBehaviourExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x209B770", Offset = "0x209A970", VA = "0x18209B770")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x209B5D0", Offset = "0x209A7D0", VA = "0x18209B5D0")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x209BAE0", Offset = "0x209ACE0", VA = "0x18209BAE0")]
		public static IDisposable Update(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x209B1E0", Offset = "0x209A3E0", VA = "0x18209B1E0")]
		public static IDisposable FixedUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x209B460", Offset = "0x209A660", VA = "0x18209B460")]
		public static IDisposable LateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x209B7F0", Offset = "0x209A9F0", VA = "0x18209B7F0")]
		public static IDisposable RigidbodyExLateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x209B4D0", Offset = "0x209A6D0", VA = "0x18209B4D0")]
		public static IDisposable PreRenderUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x209B540", Offset = "0x209A740", VA = "0x18209B540")]
		public static IDisposable QueueUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x209BA60", Offset = "0x209AC60", VA = "0x18209BA60")]
		public static IDisposable UpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x209B960", Offset = "0x209AB60", VA = "0x18209B960")]
		public static IDisposable Update30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x209B860", Offset = "0x209AA60", VA = "0x18209B860")]
		public static IDisposable Update10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x209B9E0", Offset = "0x209ABE0", VA = "0x18209B9E0")]
		public static IDisposable Update5hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x209B8E0", Offset = "0x209AAE0", VA = "0x18209B8E0")]
		public static IDisposable Update1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x209B150", Offset = "0x209A350", VA = "0x18209B150")]
		public static IDisposable FixedUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x209B0D0", Offset = "0x209A2D0", VA = "0x18209B0D0")]
		public static IDisposable FixedUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x209AFD0", Offset = "0x209A1D0", VA = "0x18209AFD0")]
		public static IDisposable FixedUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x209B050", Offset = "0x209A250", VA = "0x18209B050")]
		public static IDisposable FixedUpdate1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x209B3D0", Offset = "0x209A5D0", VA = "0x18209B3D0")]
		public static IDisposable LateUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x209B350", Offset = "0x209A550", VA = "0x18209B350")]
		public static IDisposable LateUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x209B250", Offset = "0x209A450", VA = "0x18209B250")]
		public static IDisposable LateUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x209B2D0", Offset = "0x209A4D0", VA = "0x18209B2D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x20A1FC0", Offset = "0x20A11C0", VA = "0x1820A1FC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x20A20C0", Offset = "0x20A12C0", VA = "0x1820A20C0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x209A200", Offset = "0x2099400", VA = "0x18209A200")]
		public ScheduledContextUpdate(ISchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x209A090", Offset = "0x2099290", VA = "0x18209A090")]
		public ScheduledContextUpdate(ISchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x209A370", Offset = "0x2099570", VA = "0x18209A370")]
		public ScheduledContextUpdate(ISchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2099C40", Offset = "0x2098E40", VA = "0x182099C40")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2099AF0", Offset = "0x2098CF0", VA = "0x182099AF0")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x20999C0", Offset = "0x2098BC0", VA = "0x1820999C0")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2099DF0", Offset = "0x2098FF0", VA = "0x182099DF0")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2099D90", Offset = "0x2098F90", VA = "0x182099D90")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2099970", Offset = "0x2098B70", VA = "0x182099970", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class ScheduledUpdateContextExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x209AC70", Offset = "0x2099E70", VA = "0x18209AC70")]
		public static IDisposable QueueUpdateJobbed(this ISchedulerContext behaviour, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x209AAD0", Offset = "0x2099CD0", VA = "0x18209AAD0")]
		public static IDisposable QueueUpdateJobbed(this ISchedulerContext behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x209AF60", Offset = "0x209A160", VA = "0x18209AF60")]
		public static IDisposable UpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x209A6E0", Offset = "0x20998E0", VA = "0x18209A6E0")]
		public static IDisposable FixedUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x209A960", Offset = "0x2099B60", VA = "0x18209A960")]
		public static IDisposable LateUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x209ACF0", Offset = "0x2099EF0", VA = "0x18209ACF0")]
		public static IDisposable RigidbodyExLateUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x209A9D0", Offset = "0x2099BD0", VA = "0x18209A9D0")]
		public static IDisposable PreRenderUpdateJobbed(this ISchedulerContext behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x209AA40", Offset = "0x2099C40", VA = "0x18209AA40")]
		public static IDisposable QueueUpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x209AEE0", Offset = "0x209A0E0", VA = "0x18209AEE0")]
		public static IDisposable UpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x209AE60", Offset = "0x209A060", VA = "0x18209AE60")]
		public static IDisposable Update30hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x209AD60", Offset = "0x2099F60", VA = "0x18209AD60")]
		public static IDisposable Update10hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x209ADE0", Offset = "0x2099FE0", VA = "0x18209ADE0")]
		public static IDisposable Update1hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x209A650", Offset = "0x2099850", VA = "0x18209A650")]
		public static IDisposable FixedUpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x209A5D0", Offset = "0x20997D0", VA = "0x18209A5D0")]
		public static IDisposable FixedUpdate30hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x209A4D0", Offset = "0x20996D0", VA = "0x18209A4D0")]
		public static IDisposable FixedUpdate10hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x209A550", Offset = "0x2099750", VA = "0x18209A550")]
		public static IDisposable FixedUpdate1hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x209A8D0", Offset = "0x2099AD0", VA = "0x18209A8D0")]
		public static IDisposable LateUpdateAtRateC(this ISchedulerContext behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x209A850", Offset = "0x2099A50", VA = "0x18209A850")]
		public static IDisposable LateUpdate30hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x209A750", Offset = "0x2099950", VA = "0x18209A750")]
		public static IDisposable LateUpdate10hzC(this ISchedulerContext behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x209A7D0", Offset = "0x20999D0", VA = "0x18209A7D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x20A2FF0", Offset = "0x20A21F0", VA = "0x1820A2FF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x20A30C0", Offset = "0x20A22C0", VA = "0x1820A30C0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x20A3110", Offset = "0x20A2310", VA = "0x1820A3110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x20A3200", Offset = "0x20A2400", VA = "0x1820A3200", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x30A980", Offset = "0x309B80", VA = "0x18030A980", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x35A820", Offset = "0x359A20", VA = "0x18035A820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x769C30", Offset = "0x768E30", VA = "0x180769C30", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
		public ScheduleNextFrame(Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3D6740", Offset = "0x3D5940", VA = "0x1803D6740", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2098300", Offset = "0x2097500", VA = "0x182098300")]
		public static ISchedulerPromise QueueUpdate(Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x20985C0", Offset = "0x20977C0", VA = "0x1820985C0")]
		public static ISchedulerPromise QueueUpdate(Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x20984D0", Offset = "0x20976D0", VA = "0x1820984D0")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x20983E0", Offset = "0x20975E0", VA = "0x1820983E0")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2098210", Offset = "0x2097410", VA = "0x182098210")]
		public static ISchedulerPromise QueueUpdate(ISchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x20986A0", Offset = "0x20978A0", VA = "0x1820986A0")]
		public static ISchedulerPromise QueueUpdate(ISchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2098790", Offset = "0x2097990", VA = "0x182098790")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__14))]
		private static IEnumerator<ISchedule> UpdateCoroutine(Scheduler.QueueType queue, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2098800", Offset = "0x2097A00", VA = "0x182098800")]
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
				[Cpp2IlInjected.Address(RVA = "0x319790", Offset = "0x318990", VA = "0x180319790", Slot = "22")]
				get
				{
					return default(QueueType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public QueueType Queue
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x319790", Offset = "0x318990", VA = "0x180319790")]
				get
				{
					return default(QueueType);
				}
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x3197E0", Offset = "0x3189E0", VA = "0x1803197E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			float ISchedule.NextPossibleReady
			{
				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x769C30", Offset = "0x768E30", VA = "0x180769C30", Slot = "24")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x209CB30", Offset = "0x209BD30", VA = "0x18209CB30", Slot = "23")]
			bool ISchedule.Ready()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x209CB40", Offset = "0x209BD40", VA = "0x18209CB40")]
			public SchedulerPromise()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x209CAF0", Offset = "0x209BCF0", VA = "0x18209CAF0")]
			private void CancelRoutine()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x209CB20", Offset = "0x209BD20", VA = "0x18209CB20", Slot = "25")]
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
			[Cpp2IlInjected.Address(RVA = "0x2098CB0", Offset = "0x2097EB0", VA = "0x182098CB0")]
			public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
			{
				return default(ScheduleSortJob);
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x2C7F80", Offset = "0x2C7380", VA = "0x1802C7F80", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x2C8030", Offset = "0x2C7430", VA = "0x1802C8030")]
			private bool ShouldExecute(int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2C7FD0", Offset = "0x2C73D0", VA = "0x1802C7FD0")]
			private void MergeSort(NativeArray<int> arr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2C7F90", Offset = "0x2C7390", VA = "0x1802C7F90")]
			private int IndexCompare(int indexA, int indexB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2C7FA0", Offset = "0x2C73A0", VA = "0x1802C7FA0")]
			private void MergeSortImpl(NativeArray<int> arr, int l, int r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2C7FF0", Offset = "0x2C73F0", VA = "0x1802C7FF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x30A980", Offset = "0x309B80", VA = "0x18030A980", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000123")]
				[Cpp2IlInjected.Address(RVA = "0x35A820", Offset = "0x359A20", VA = "0x18035A820")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x20972B0", Offset = "0x20964B0", VA = "0x1820972B0")]
			public static ISchedule Step(IEnumerator<ISchedule> coroutine, SchedulerPromise promise)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x20973E0", Offset = "0x20965E0", VA = "0x1820973E0")]
			public ISchedule Step(SchedulerPromise[] allScheduledPromises, IEnumerator<ISchedule>[] coroutines, ISchedule[] currentSchedules)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2097100", Offset = "0x2096300", VA = "0x182097100")]
			public void OnContextDestroyed()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x20971F0", Offset = "0x20963F0", VA = "0x1820971F0")]
			public void OnContextEnabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x2097130", Offset = "0x2096330", VA = "0x182097130")]
			public void OnContextDisabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2097100", Offset = "0x2096300", VA = "0x182097100")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x318C70", Offset = "0x317E70", VA = "0x180318C70")]
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
				[Cpp2IlInjected.Address(RVA = "0x3082D0", Offset = "0x3074D0", VA = "0x1803082D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x315450", Offset = "0x314650", VA = "0x180315450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public ISchedule CurrentSchedule
			{
				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0x323580", Offset = "0x322780", VA = "0x180323580")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public bool Paused
			{
				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x209CA60", Offset = "0x209BC60", VA = "0x18209CA60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public bool Canceled
			{
				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x3051F0", Offset = "0x3043F0", VA = "0x1803051F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x327F20", Offset = "0x327120", VA = "0x180327F20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x3088B0", Offset = "0x307AB0", VA = "0x1803088B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x308160", Offset = "0x307360", VA = "0x180308160")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public float NextUpdateKey
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0xA42D20", Offset = "0xA41F20", VA = "0x180A42D20")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x35B330", Offset = "0x35A530", VA = "0x18035B330")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x209C8E0", Offset = "0x209BAE0", VA = "0x18209C8E0")]
			public SchedulerCoroutine(IEnumerator<ISchedule> coroutine, Behaviour context, SchedulerPromise promise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x209C6A0", Offset = "0x209B8A0", VA = "0x18209C6A0")]
			public ISchedule Step()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x209C850", Offset = "0x209BA50", VA = "0x18209C850", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0x20A15A0", Offset = "0x20A07A0", VA = "0x1820A15A0", Slot = "4")]
				public int Compare(SchedulerCoroutine x, SchedulerCoroutine y)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x318C70", Offset = "0x317E70", VA = "0x180318C70")]
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
				[Cpp2IlInjected.Address(RVA = "0x813610", Offset = "0x812810", VA = "0x180813610")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public int Capacity
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x14AC980", Offset = "0x14ABB80", VA = "0x1814AC980")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public QueueType Queue
			{
				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0x12A16C0", Offset = "0x12A08C0", VA = "0x1812A16C0")]
				[CompilerGenerated]
				get
				{
					return default(QueueType);
				}
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x1589A70", Offset = "0x1588C70", VA = "0x181589A70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public ReinsertBuffer[,] ReinsertionQueues
			{
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0x55A740", Offset = "0x559940", VA = "0x18055A740")]
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
				[Cpp2IlInjected.Address(RVA = "0x674A40", Offset = "0x673C40", VA = "0x180674A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x209D0F0", Offset = "0x209C2F0", VA = "0x18209D0F0")]
			private static int GetInitialCapacity(QueueType queueType)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x209F500", Offset = "0x209E700", VA = "0x18209F500")]
			public SchedulerQueue(QueueType queue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x209DA80", Offset = "0x209CC80", VA = "0x18209DA80")]
			public void LogFutureRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x209DA90", Offset = "0x209CC90", VA = "0x18209DA90")]
			public void LogImmediateRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x209DAA0", Offset = "0x209CCA0", VA = "0x18209DAA0")]
			private void LogRoutines(IReadOnlyList<SchedulerCoroutine> routines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x209E950", Offset = "0x209DB50", VA = "0x18209E950")]
			private void ResizeArrays(ref int oldCapacity, int newCapacity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x209D660", Offset = "0x209C860", VA = "0x18209D660")]
			public void InsertJobbedSchedulerCoroutine(ISchedulerContext context, ISchedule currentSchedule, IEnumerator<ISchedule> coroutine, SchedulerPromise promise, [Optional] JobbedSchedulerCoroutine routine, CoroutineState coroutineState = CoroutineState.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x209E510", Offset = "0x209D710", VA = "0x18209E510")]
			private JobbedInsertionData RemoveSchedulerCoroutine(int indexToRemove)
			{
				return default(JobbedInsertionData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x1133CC0", Offset = "0x1132EC0", VA = "0x181133CC0")]
			private static void SwapBackFill<T>(int indexToRemove, T[] myArray, int size, [Optional] T fillValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x1133CA0", Offset = "0x1132EA0", VA = "0x181133CA0")]
			private static void SwapBackFill<T>(int indexToRemove, NativeArray<T> myArray, int size, [Optional] T fillValue) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x209D990", Offset = "0x209CB90", VA = "0x18209D990")]
			public void InsertSingleCoroutine(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x209D3C0", Offset = "0x209C5C0", VA = "0x18209D3C0")]
			public void InsertImmediates(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x209D790", Offset = "0x209C990", VA = "0x18209D790")]
			public void InsertJobbed(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x209E0F0", Offset = "0x209D2F0", VA = "0x18209E0F0")]
			private void QueueMultipleForInsertion(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x209D120", Offset = "0x209C320", VA = "0x18209D120")]
			public void InsertFutures(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x209DD70", Offset = "0x209CF70", VA = "0x18209DD70")]
			private void QueueForReinsertJobbed(JobbedInsertionData jobbedInsertionData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x209DE40", Offset = "0x209D040", VA = "0x18209DE40")]
			private void QueueForReinsert(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x209E3A0", Offset = "0x209D5A0", VA = "0x18209E3A0")]
			private void QueueMultipleForReinsert(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x209EAD0", Offset = "0x209DCD0", VA = "0x18209EAD0")]
			private TickResult TickCoroutine(SchedulerCoroutine coroutine)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x209EC50", Offset = "0x209DE50", VA = "0x18209EC50")]
			private TickResult TickJobbedCoroutine(int scheduleIndex)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x209DF40", Offset = "0x209D140", VA = "0x18209DF40")]
			public void QueueJob(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x209DC70", Offset = "0x209CE70", VA = "0x18209DC70")]
			private void QueueAddRemoveAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x209DCF0", Offset = "0x209CEF0", VA = "0x18209DCF0")]
			private void QueueCoroutineStateChangeAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x209EFC0", Offset = "0x209E1C0", VA = "0x18209EFC0")]
			public void UpdateJobSortedCoroutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x209F460", Offset = "0x209E660", VA = "0x18209F460")]
			public void Update(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x209CF20", Offset = "0x209C120", VA = "0x18209CF20")]
			private void DoImmediateUpdates()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x209CD20", Offset = "0x209BF20", VA = "0x18209CD20")]
			private void DoFutureUpdates(float now)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x209CC60", Offset = "0x209BE60", VA = "0x18209CC60", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x209CBB0", Offset = "0x209BDB0", VA = "0x18209CBB0")]
			public void Cancel(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x209DBC0", Offset = "0x209CDC0", VA = "0x18209DBC0")]
			public void Pause(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x209EF10", Offset = "0x209E110", VA = "0x18209EF10")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__29(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x20A1BF0", Offset = "0x20A0DF0", VA = "0x1820A1BF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x20A1C70", Offset = "0x20A0E70", VA = "0x1820A1C70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x3208D0", Offset = "0x31FAD0", VA = "0x1803208D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x3584A0", Offset = "0x3576A0", VA = "0x1803584A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x20A0640", Offset = "0x209F840", VA = "0x1820A0640")]
		public static ISchedulerPromise GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x209FCE0", Offset = "0x209EEE0", VA = "0x18209FCE0", Slot = "7")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x20A0700", Offset = "0x209F900", VA = "0x1820A0700", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x14DF4C0", Offset = "0x14DE6C0", VA = "0x1814DF4C0")]
		private SchedulerQueue GetQueue(QueueType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x20A0BD0", Offset = "0x209FDD0", VA = "0x1820A0BD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x20A0BA0", Offset = "0x209FDA0", VA = "0x1820A0BA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x20A12F0", Offset = "0x20A04F0", VA = "0x1820A12F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x20A0C40", Offset = "0x209FE40", VA = "0x1820A0C40")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x20A0C60", Offset = "0x209FE60", VA = "0x1820A0C60")]
		private void OnRigidbodyExLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20A0300", Offset = "0x209F500", VA = "0x1820A0300")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x20A06F0", Offset = "0x209F8F0", VA = "0x1820A06F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x20A0C50", Offset = "0x209FE50", VA = "0x1820A0C50")]
		private void OnPreRenderUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x20A02A0", Offset = "0x209F4A0", VA = "0x1820A02A0")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__29))]
		private IEnumerator EndOfFrameRoutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x20A0C70", Offset = "0x209FE70", VA = "0x1820A0C70")]
		public ISchedulerPromise RunJobbed(IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x20A0C80", Offset = "0x209FE80", VA = "0x1820A0C80")]
		public ISchedulerPromise RunJobbed(ISchedulerContext context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x20A0310", Offset = "0x209F510", VA = "0x1820A0310")]
		private void FlushJobbedReinserts(SchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x20A0DD0", Offset = "0x209FFD0", VA = "0x1820A0DD0")]
		public ISchedulerPromise Run(Behaviour context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x20A10F0", Offset = "0x20A02F0", VA = "0x1820A10F0")]
		public void UpdateQueue(QueueType currentQueueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x20A0460", Offset = "0x209F660", VA = "0x1820A0460")]
		private void FlushReinserts(SchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x20A1520", Offset = "0x20A0720", VA = "0x1820A1520")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x20A3250", Offset = "0x20A2450", VA = "0x1820A3250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x20A3400", Offset = "0x20A2600", VA = "0x1820A3400", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AE4F0", Offset = "0x5AD6F0", VA = "0x1805AE4F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x35B360", Offset = "0x35A560", VA = "0x18035B360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x313B50", Offset = "0x312D50", VA = "0x180313B50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x322810", Offset = "0x321A10", VA = "0x180322810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x551D00", Offset = "0x550F00", VA = "0x180551D00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x551D10", Offset = "0x550F10", VA = "0x180551D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x54B850", Offset = "0x54AA50", VA = "0x18054B850")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x391840", Offset = "0x390A40", VA = "0x180391840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2098BD0", Offset = "0x2097DD0", VA = "0x182098BD0")]
		public ScheduleRate(float targetRateHz, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2098AA0", Offset = "0x2097CA0", VA = "0x182098AA0", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2098AC0", Offset = "0x2097CC0", VA = "0x182098AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2098870", Offset = "0x2097A70", VA = "0x182098870")]
		public static ISchedulerPromise QueueUpdate(float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2098920", Offset = "0x2097B20", VA = "0x182098920")]
		public static ISchedulerPromise QueueUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x20989E0", Offset = "0x2097BE0", VA = "0x1820989E0")]
		public static ISchedulerPromise QueueUpdate(ISchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2098B50", Offset = "0x2097D50", VA = "0x182098B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x2096260", Offset = "0x2095460", VA = "0x182096260", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x2096210", Offset = "0x2095410", VA = "0x182096210", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float FixedDeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x2096220", Offset = "0x2095420", VA = "0x182096220", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x2096230", Offset = "0x2095430", VA = "0x182096230", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public double RealtimeSinceStartup
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x2096240", Offset = "0x2095440", VA = "0x182096240", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x318C70", Offset = "0x317E70", VA = "0x180318C70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3082E0", Offset = "0x3074E0", VA = "0x1803082E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3495A0", Offset = "0x3487A0", VA = "0x1803495A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5AE4F0", Offset = "0x5AD6F0", VA = "0x1805AE4F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x35B360", Offset = "0x35A560", VA = "0x18035B360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x20994A0", Offset = "0x20986A0", VA = "0x1820994A0")]
		public ScheduleUntil(Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2099460", Offset = "0x2098660", VA = "0x182099460")]
		public ScheduleUntil(Scheduler.QueueType queueType, Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2099410", Offset = "0x2098610", VA = "0x182099410", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <UntilCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x20A2F00", Offset = "0x20A2100", VA = "0x1820A2F00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x20A2FA0", Offset = "0x20A21A0", VA = "0x1820A2FA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x20A3540", Offset = "0x20A2740", VA = "0x1820A3540")]
		[IteratorStateMachine(typeof(<UntilCoroutine>d__0))]
		private static IEnumerator<ISchedule> UntilCoroutine(Scheduler.QueueType queueType, Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x20A3450", Offset = "0x20A2650", VA = "0x1820A3450")]
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
			[Cpp2IlInjected.Address(RVA = "0x41A7A0", Offset = "0x4199A0", VA = "0x18041A7A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x303270", Offset = "0x302470", VA = "0x180303270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x550930", Offset = "0x54FB30", VA = "0x180550930", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x550A60", Offset = "0x54FC60", VA = "0x180550A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2099560", Offset = "0x2098760", VA = "0x182099560")]
		public ScheduleWait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x20994D0", Offset = "0x20986D0", VA = "0x1820994D0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <DelayedCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x20A1AF0", Offset = "0x20A0CF0", VA = "0x1820A1AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x20A1BA0", Offset = "0x20A0DA0", VA = "0x1820A1BA0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x321310", Offset = "0x320510", VA = "0x180321310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x305660", Offset = "0x304860", VA = "0x180305660")]
			[DebuggerHidden]
			public <InvokeRepeatedCoroutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3040D0", Offset = "0x3032D0", VA = "0x1803040D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x20A1E00", Offset = "0x20A1000", VA = "0x1820A1E00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x20A1EC0", Offset = "0x20A10C0", VA = "0x1820A1EC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2096270", Offset = "0x2095470", VA = "0x182096270")]
		[IteratorStateMachine(typeof(<DelayedCoroutine>d__0))]
		private static IEnumerator<ISchedule> DelayedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2096C00", Offset = "0x2095E00", VA = "0x182096C00")]
		[IteratorStateMachine(typeof(<InvokeRepeatedCoroutine>d__1))]
		private static IEnumerator<ISchedule> InvokeRepeatedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2096D80", Offset = "0x2095F80", VA = "0x182096D80")]
		public static IDisposable InvokeRepeated(this MonoBehaviour behaviour, float seconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2096E70", Offset = "0x2096070", VA = "0x182096E70")]
		public static ISchedulerPromise ScheduleDelay(this MonoBehaviour behaviour, float seconds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2096C80", Offset = "0x2095E80", VA = "0x182096C80")]
		public static ISchedulerPromise InvokeRepeated(this MonoBehaviour behaviour, float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2096B20", Offset = "0x2095D20", VA = "0x182096B20")]
		public static ISchedulerPromise InvokeNextUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2096960", Offset = "0x2095B60", VA = "0x182096960")]
		public static ISchedulerPromise InvokeNextLateUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2096880", Offset = "0x2095A80", VA = "0x182096880")]
		public static ISchedulerPromise InvokeNextFixedUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x20967A0", Offset = "0x20959A0", VA = "0x1820967A0")]
		public static ISchedulerPromise InvokeNextEndOfFrame(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2096A40", Offset = "0x2095C40", VA = "0x182096A40")]
		public static ISchedulerPromise InvokeNextPreRender(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x20966B0", Offset = "0x20958B0", VA = "0x1820966B0")]
		public static ISchedulerPromise InvokeInUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x20964D0", Offset = "0x20956D0", VA = "0x1820964D0")]
		public static ISchedulerPromise InvokeInLateUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x20963E0", Offset = "0x20955E0", VA = "0x1820963E0")]
		public static ISchedulerPromise InvokeInFixedUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x20962F0", Offset = "0x20954F0", VA = "0x1820962F0")]
		public static ISchedulerPromise InvokeInEndOfFrame(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x20965C0", Offset = "0x20957C0", VA = "0x1820965C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2098130", Offset = "0x2097330", VA = "0x182098130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x2098180", Offset = "0x2097380", VA = "0x182098180", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1677160", Offset = "0x1676360", VA = "0x181677160", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x1677150", Offset = "0x1676350", VA = "0x181677150", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x20980A0", Offset = "0x20972A0", VA = "0x1820980A0")]
		public RollingBufferAverageStats(int maxBufferLength)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2097F80", Offset = "0x2097180", VA = "0x182097F80", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2097F10", Offset = "0x2097110", VA = "0x182097F10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3082D0", Offset = "0x3074D0", VA = "0x1803082D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x334C80", Offset = "0x333E80", VA = "0x180334C80", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x20970E0", Offset = "0x20962E0", VA = "0x1820970E0", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public double Variance
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1677150", Offset = "0x1676350", VA = "0x181677150")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public double StdDev
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x20970F0", Offset = "0x20962F0", VA = "0x1820970F0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1AC2B00", Offset = "0x1AC1D00", VA = "0x181AC2B00", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2096F90", Offset = "0x2096190", VA = "0x182096F90", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2096F50", Offset = "0x2096150", VA = "0x182096F50", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x20970B0", Offset = "0x20962B0", VA = "0x1820970B0")]
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
