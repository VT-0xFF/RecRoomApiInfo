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
using RecRoom.Core;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;

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
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		private delegate List<PlayerLoopSystem> SubsystemListModification(List<PlayerLoopSystem> systems, int subsystemIndex);

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public struct CustomSystems
		{
			[Cpp2IlInjected.Token(Token = "0x200004F")]
			public struct PostUpdateSystem
			{
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public static ActionEvent OnPostUpdate;

				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x2EBC720", Offset = "0x2EBAF20", VA = "0x182EBC720")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000050")]
			public struct RigidbodyExLateUpdateSystem
			{
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public static ActionEvent OnRigidbodyExLateUpdate;

				[Cpp2IlInjected.Token(Token = "0x60001EF")]
				[Cpp2IlInjected.Address(RVA = "0x2EBD1B0", Offset = "0x2EBB9B0", VA = "0x182EBD1B0")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000051")]
			public struct PreRenderSystem
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public static ActionEvent OnPreRenderUpdate;

				[Cpp2IlInjected.Token(Token = "0x60001F1")]
				[Cpp2IlInjected.Address(RVA = "0x2EBC8C0", Offset = "0x2EBB0C0", VA = "0x182EBC8C0")]
				public static PlayerLoopSystem CreateSystem()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000052")]
			internal struct WrapperPreSystem
			{
				[Cpp2IlInjected.Token(Token = "0x60001F3")]
				[Cpp2IlInjected.Address(RVA = "0x2EC88E0", Offset = "0x2EC70E0", VA = "0x182EC88E0")]
				public static PlayerLoopSystem GetNewSystem(TimerAnalytics.WrapperKey key)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000053")]
			internal struct WrapperPostSystem
			{
				[Cpp2IlInjected.Token(Token = "0x60001F4")]
				[Cpp2IlInjected.Address(RVA = "0x2EC87E0", Offset = "0x2EC6FE0", VA = "0x182EC87E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EB8400", Offset = "0x2EB6C00", VA = "0x182EB8400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2EB8440", Offset = "0x2EB6C40", VA = "0x182EB8440")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2EB6EE0", Offset = "0x2EB56E0", VA = "0x182EB6EE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2EB81A0", Offset = "0x2EB69A0", VA = "0x182EB81A0")]
		private static void TryTimerWrapSubSystem(TimerAnalytics.WrapperKey key, ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2EB7D30", Offset = "0x2EB6530", VA = "0x182EB7D30")]
		private static void ModifySubsystemList(ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType, SubsystemListModification subsystemListModification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2EB80A0", Offset = "0x2EB68A0", VA = "0x182EB80A0")]
		private static void TryInsertSystems(ref PlayerLoopSystem playerLoop, Type parentSystemType, Type subSystemType, PlayerLoopSystem? before, PlayerLoopSystem? after)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class TimerAnalytics
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum WrapperKey
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			SchedulerUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			PreRenderUpdate,
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			PhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			PhysicsUpdate,
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			SendFrameStarted,
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			FinishFrameRendering,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			PhysicsResetInterpolatedPosition,
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			FullPlayerLoop
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class CallWrapper
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public readonly WrapperKey WrapperKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private Stopwatch stopwatch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public readonly RollingBufferAverageStats AverageStats;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private long startTicks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private long endTicks;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2EB6DE0", Offset = "0x2EB55E0", VA = "0x182EB6DE0")]
			public CallWrapper(WrapperKey wrapperKey, int bufferSize = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2EB6DC0", Offset = "0x2EB55C0", VA = "0x182EB6DC0")]
			public void SetBufferLength(int bufferLength)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x2EB6D00", Offset = "0x2EB5500", VA = "0x182EB6D00")]
			public void ResetTimer()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x2EB6CD0", Offset = "0x2EB54D0", VA = "0x182EB6CD0")]
			public void RegisterStart()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x2EB6B90", Offset = "0x2EB5390", VA = "0x182EB6B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EC5FB0", Offset = "0x2EC47B0", VA = "0x182EC5FB0")]
		public static CallWrapper CreateWrapper(WrapperKey key, int bufferSize = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6170", Offset = "0x2EC4970", VA = "0x182EC6170")]
		public static CallWrapper GetWrapper(WrapperKey key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2EC6200", Offset = "0x2EC4A00", VA = "0x182EC6200")]
		public static void ResetAllWrappers()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class DebounceRateLimiter : RateLimiterBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly float cooldownSeconds;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8620", Offset = "0x2EB6E20", VA = "0x182EB8620")]
		public DebounceRateLimiter(Behaviour context, float cooldownSeconds, [Optional] Action defaultAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8480", Offset = "0x2EB6C80", VA = "0x182EB8480", Slot = "9")]
		protected override bool TryInvokeDuringActiveCooldown(Action action)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8550", Offset = "0x2EB6D50", VA = "0x182EB8550", Slot = "10")]
		protected override bool TryInvokeDuringInactiveCooldown(Action action)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IRateLimiter
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IsCooldownActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action CooldownActiveChanged;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TryInvoke(bool force = false);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool TryInvoke(Action action, bool force = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class RateLimiterBase : IRateLimiter
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class <CooldownRoutine>d__16 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float duration;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <CooldownRoutine>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2EC63C0", Offset = "0x2EC4BC0", VA = "0x182EC63C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6460", Offset = "0x2EC4C60", VA = "0x182EC6460", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Behaviour context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Action defaultAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ICancelablePromise cooldownPromise;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IsCooldownActive
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6CA310", Offset = "0x6C8B10", VA = "0x1806CA310", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action CooldownActiveChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCF80", Offset = "0x2EBB780", VA = "0x182EBCF80", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2EBD020", Offset = "0x2EBB820", VA = "0x182EBD020", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E8DBD0", Offset = "0x1E8C3D0", VA = "0x181E8DBD0")]
		protected RateLimiterBase(Behaviour context, [Optional] Action defaultAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2EBCEB0", Offset = "0x2EBB6B0", VA = "0x182EBCEB0", Slot = "7")]
		public bool TryInvoke(bool force = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2EBCF10", Offset = "0x2EBB710", VA = "0x182EBCF10", Slot = "8")]
		public bool TryInvoke(Action action, bool force = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool TryInvokeDuringActiveCooldown(Action action);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryInvokeDuringInactiveCooldown(Action action);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2EBCCC0", Offset = "0x2EBB4C0", VA = "0x182EBCCC0")]
		protected void InvokeAction(Action action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2EBCCE0", Offset = "0x2EBB4E0", VA = "0x182EBCCE0")]
		protected IPromise ScheduleCooldown(float duration)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2EBCBF0", Offset = "0x2EBB3F0", VA = "0x182EBCBF0")]
		private void CancelCooldown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2EBCC60", Offset = "0x2EBB460", VA = "0x182EBCC60")]
		[IteratorStateMachine(typeof(<CooldownRoutine>d__16))]
		private static IEnumerator<ISchedule> CooldownRoutine(float duration)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SlidingWindowRateLimiter : RateLimiterBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly float durationSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly int maxInvocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly float minCooldownSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly float[] previousInvokeTimes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int previousInvokeTimeIdx;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ISchedulerTimer Timer
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3D3250", Offset = "0x3D1A50", VA = "0x1803D3250")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3D3290", Offset = "0x3D1A90", VA = "0x1803D3290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5DD0", Offset = "0x2EC45D0", VA = "0x182EC5DD0")]
		public SlidingWindowRateLimiter(Behaviour context, float windowDurationSeconds, int maxInvocations, [Optional] Action defaultAction, float minCooldownSeconds = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x425970", Offset = "0x424170", VA = "0x180425970", Slot = "9")]
		protected override bool TryInvokeDuringActiveCooldown(Action action)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5BB0", Offset = "0x2EC43B0", VA = "0x182EC5BB0", Slot = "10")]
		protected override bool TryInvokeDuringInactiveCooldown(Action action)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5B20", Offset = "0x2EC4320", VA = "0x182EC5B20")]
		private void RecordInvocation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class ThrottleRateLimiter : RateLimiterBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly float cooldownSeconds;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8620", Offset = "0x2EB6E20", VA = "0x182EB8620")]
		public ThrottleRateLimiter(Behaviour context, float cooldownSeconds, [Optional] Action defaultAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x425970", Offset = "0x424170", VA = "0x180425970", Slot = "9")]
		protected override bool TryInvokeDuringActiveCooldown(Action action)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5F70", Offset = "0x2EC4770", VA = "0x182EC5F70", Slot = "10")]
		protected override bool TryInvokeDuringInactiveCooldown(Action action)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface IJobbedSchedulerCoroutine
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface ISchedulerPromise : ICancelablePromise, IPromise, IEnumerator, ISchedule, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class Receipt : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public static readonly Receipt Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Action onDispose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private bool disposed;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D5A30", Offset = "0x3D4230", VA = "0x1803D5A30")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD0C0", Offset = "0x2EBB8C0", VA = "0x182EBD0C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IReadOnlyReactiveProperty<T>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable Observe(Action<T> onValueChanged);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IDisposable Observe(UnityEngine.Object context, Action<T> onValueChanged);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface IReactiveProperty<T> : IReadOnlyReactiveProperty<T>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		new T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ReactiveProperty<T> : IReactiveProperty<T>, IReadOnlyReactiveProperty<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static GameObject _defaultContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly List<Tuple<UnityEngine.Object, Action<T>>> observers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private T _value;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private static UnityEngine.Object DefaultContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2A1EF50", Offset = "0x2A1D750", VA = "0x182A1EF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x4F0650", Offset = "0x4EEE50", VA = "0x1804F0650", Slot = "6")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x2A1F370", Offset = "0x2A1DB70", VA = "0x182A1F370", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E450", Offset = "0x2A1CC50", VA = "0x182A1E450")]
		private static bool AreEqual(T a, T b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2416CE0", Offset = "0x24154E0", VA = "0x182416CE0")]
		public ReactiveProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2A1EEC0", Offset = "0x2A1D6C0", VA = "0x182A1EEC0")]
		public ReactiveProperty(T initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E4C0", Offset = "0x2A1CCC0", VA = "0x182A1E4C0")]
		public void ForceUpdate(T newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2A1EB40", Offset = "0x2A1D340", VA = "0x182A1EB40", Slot = "7")]
		public IDisposable Observe(Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2A1ECF0", Offset = "0x2A1D4F0", VA = "0x182A1ECF0", Slot = "8")]
		public IDisposable Observe(UnityEngine.Object context, Action<T> onValueChanged)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2A1E820", Offset = "0x2A1D020", VA = "0x182A1E820")]
		private void NotifyObservers()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class Schedule
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class <Example>d__8 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <Example>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6680", Offset = "0x2EC4E80", VA = "0x182EC6680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6770", Offset = "0x2EC4F70", VA = "0x182EC6770", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly ISchedule NextFrame;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly ISchedule NextFixedUpdate;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly ISchedule NextLateUpdate;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly ISchedule NextEndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly ISchedule NextPreRender;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF030", Offset = "0x2EBD830", VA = "0x182EBF030")]
		public static ISchedule Wait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEFD0", Offset = "0x2EBD7D0", VA = "0x182EBEFD0")]
		public static ISchedule Until(Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEED0", Offset = "0x2EBD6D0", VA = "0x182EBEED0")]
		public static ISchedule AfterCompleted(IPromise promise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEF80", Offset = "0x2EBD780", VA = "0x182EBEF80")]
		[IteratorStateMachine(typeof(<Example>d__8))]
		public static IEnumerator<ISchedule> Example()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ISchedule
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool Ready();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class ScheduleNextFrame : ISchedule
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class <UpdateCoroutine>d__14 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public Action update;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ScheduleNextFrame <schedule>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x2EC81D0", Offset = "0x2EC69D0", VA = "0x182EC81D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2EC82A0", Offset = "0x2EC6AA0", VA = "0x182EC82A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class <UpdateCoroutine>d__15 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public Action<float> update;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private ScheduleNextFrame <schedule>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000141")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2EC82F0", Offset = "0x2EC6AF0", VA = "0x182EC82F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x2EC83E0", Offset = "0x2EC6BE0", VA = "0x182EC83E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C50", Offset = "0x3D2450", VA = "0x1803D3C50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3D3C90", Offset = "0x3D2490", VA = "0x1803D3C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3F48D0", Offset = "0x3F30D0", VA = "0x1803F48D0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
		public ScheduleNextFrame(Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4CCE40", Offset = "0x4CB640", VA = "0x1804CCE40", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDE20", Offset = "0x2EBC620", VA = "0x182EBDE20")]
		public static ISchedulerPromise QueueUpdate(Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE130", Offset = "0x2EBC930", VA = "0x182EBE130")]
		public static ISchedulerPromise QueueUpdate(Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE020", Offset = "0x2EBC820", VA = "0x182EBE020")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDF10", Offset = "0x2EBC710", VA = "0x182EBDF10")]
		public static ISchedulerPromise QueueUpdate(Behaviour context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDC00", Offset = "0x2EBC400", VA = "0x182EBDC00")]
		public static ISchedulerPromise QueueUpdateJobbed(IJobbedSchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDD10", Offset = "0x2EBC510", VA = "0x182EBDD10")]
		public static ISchedulerPromise QueueUpdateJobbed(IJobbedSchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE220", Offset = "0x2EBCA20", VA = "0x182EBE220")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__14))]
		private static IEnumerator<ISchedule> UpdateCoroutine(Scheduler.QueueType queue, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE290", Offset = "0x2EBCA90", VA = "0x182EBE290")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__15))]
		private static IEnumerator<ISchedule> UpdateCoroutine(Scheduler.QueueType queue, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ScheduleRate : ISchedule
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class <UpdateCoroutine>d__25 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public float hz;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public Action<float> update;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private ScheduleRate <schedule>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <UpdateCoroutine>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x2EC8430", Offset = "0x2EC6C30", VA = "0x182EC8430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x2EC85D0", Offset = "0x2EC6DD0", VA = "0x182EC85D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly float firstUpdateTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private int timesUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly float secondsPerUpdate;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float TargetHz
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x558C40", Offset = "0x557440", VA = "0x180558C40")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x558C80", Offset = "0x557480", VA = "0x180558C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4F0450", Offset = "0x4EEC50", VA = "0x1804F0450", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4DD800", Offset = "0x4DC000", VA = "0x1804DD800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x568C10", Offset = "0x567410", VA = "0x180568C10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x568C30", Offset = "0x567430", VA = "0x180568C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x45C500", Offset = "0x45AD00", VA = "0x18045C500")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x45C9E0", Offset = "0x45B1E0", VA = "0x18045C9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE660", Offset = "0x2EBCE60", VA = "0x182EBE660")]
		public ScheduleRate(float targetRateHz, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE530", Offset = "0x2EBCD30", VA = "0x182EBE530", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE550", Offset = "0x2EBCD50", VA = "0x182EBE550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE3C0", Offset = "0x2EBCBC0", VA = "0x182EBE3C0")]
		public static ISchedulerPromise QueueUpdate(float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE470", Offset = "0x2EBCC70", VA = "0x182EBE470")]
		public static ISchedulerPromise QueueUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE300", Offset = "0x2EBCB00", VA = "0x182EBE300")]
		public static ISchedulerPromise QueueJobbedUpdate(IJobbedSchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2EBE5E0", Offset = "0x2EBCDE0", VA = "0x182EBE5E0")]
		[IteratorStateMachine(typeof(<UpdateCoroutine>d__25))]
		private static IEnumerator<ISchedule> UpdateCoroutine(float hz, Scheduler.QueueType queue, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ScheduleUntil : ISchedule
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4008D0", Offset = "0x3FF0D0", VA = "0x1804008D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x4ED330", Offset = "0x4EBB30", VA = "0x1804ED330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x558C40", Offset = "0x557440", VA = "0x180558C40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x558C80", Offset = "0x557480", VA = "0x180558C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2EBED60", Offset = "0x2EBD560", VA = "0x182EBED60")]
		public ScheduleUntil(Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2EBED20", Offset = "0x2EBD520", VA = "0x182EBED20")]
		public ScheduleUntil(Scheduler.QueueType queueType, Func<bool> condition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2EBECD0", Offset = "0x2EBD4D0", VA = "0x182EBECD0", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class UntilUpdateExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class <UntilCoroutine>d__0 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Scheduler.QueueType queueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public Func<bool> condition;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <UntilCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x2EC80E0", Offset = "0x2EC68E0", VA = "0x182EC80E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x2EC8180", Offset = "0x2EC6980", VA = "0x182EC8180", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8770", Offset = "0x2EC6F70", VA = "0x182EC8770")]
		[IteratorStateMachine(typeof(<UntilCoroutine>d__0))]
		private static IEnumerator<ISchedule> UntilCoroutine(Scheduler.QueueType queueType, Func<bool> condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC8620", Offset = "0x2EC6E20", VA = "0x182EC8620")]
		public static ISchedulerPromise ScheduleUntil(this MonoBehaviour behaviour, Func<bool> condition, Scheduler.QueueType queueType = Scheduler.QueueType.Update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class ScheduleWait : ISchedule
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly float waitTime;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Scheduler.QueueType Queue
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x568C20", Offset = "0x567420", VA = "0x180568C20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Scheduler.QueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x568C40", Offset = "0x567440", VA = "0x180568C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NextPossibleReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x558C30", Offset = "0x557430", VA = "0x180558C30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x558C70", Offset = "0x557470", VA = "0x180558C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2EBEE20", Offset = "0x2EBD620", VA = "0x182EBEE20")]
		public ScheduleWait(float seconds, Scheduler.QueueType queue = Scheduler.QueueType.Update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2EBED90", Offset = "0x2EBD590", VA = "0x182EBED90", Slot = "5")]
		public bool Ready()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class DelayedUpdateExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class <DelayedCoroutine>d__0 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public float seconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public Action function;

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <DelayedCoroutine>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2EC64B0", Offset = "0x2EC4CB0", VA = "0x182EC64B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6560", Offset = "0x2EC4D60", VA = "0x182EC6560", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class <InvokeRepeatedCoroutine>d__1 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public float seconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public Scheduler.QueueType queue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public Action function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private ISchedule <wait>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <InvokeRepeatedCoroutine>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x2EC67C0", Offset = "0x2EC4FC0", VA = "0x182EC67C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6880", Offset = "0x2EC5080", VA = "0x182EC6880", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2EB86D0", Offset = "0x2EB6ED0", VA = "0x182EB86D0")]
		[IteratorStateMachine(typeof(<DelayedCoroutine>d__0))]
		private static IEnumerator<ISchedule> DelayedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2EB92E0", Offset = "0x2EB7AE0", VA = "0x182EB92E0")]
		[IteratorStateMachine(typeof(<InvokeRepeatedCoroutine>d__1))]
		private static IEnumerator<ISchedule> InvokeRepeatedCoroutine(float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2EB94B0", Offset = "0x2EB7CB0", VA = "0x182EB94B0")]
		public static IDisposable InvokeRepeated(this MonoBehaviour behaviour, float seconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2EB95F0", Offset = "0x2EB7DF0", VA = "0x182EB95F0")]
		public static ISchedulerPromise ScheduleDelay(this MonoBehaviour behaviour, float seconds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9360", Offset = "0x2EB7B60", VA = "0x182EB9360")]
		public static ISchedulerPromise InvokeRepeated(this MonoBehaviour behaviour, float seconds, Scheduler.QueueType queue, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2EB91A0", Offset = "0x2EB79A0", VA = "0x182EB91A0")]
		public static ISchedulerPromise InvokeNextUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8F20", Offset = "0x2EB7720", VA = "0x182EB8F20")]
		public static ISchedulerPromise InvokeNextLateUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8DE0", Offset = "0x2EB75E0", VA = "0x182EB8DE0")]
		public static ISchedulerPromise InvokeNextFixedUpdate(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8CA0", Offset = "0x2EB74A0", VA = "0x182EB8CA0")]
		public static ISchedulerPromise InvokeNextEndOfFrame(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9060", Offset = "0x2EB7860", VA = "0x182EB9060")]
		public static ISchedulerPromise InvokeNextPreRender(this MonoBehaviour behaviour, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8B90", Offset = "0x2EB7390", VA = "0x182EB8B90")]
		public static ISchedulerPromise InvokeInUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8970", Offset = "0x2EB7170", VA = "0x182EB8970")]
		public static ISchedulerPromise InvokeInLateUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8860", Offset = "0x2EB7060", VA = "0x182EB8860")]
		public static ISchedulerPromise InvokeInFixedUpdate(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8750", Offset = "0x2EB6F50", VA = "0x182EB8750")]
		public static ISchedulerPromise InvokeInEndOfFrame(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2EB8A80", Offset = "0x2EB7280", VA = "0x182EB8A80")]
		public static ISchedulerPromise InvokeInPreRender(this MonoBehaviour behaviour, float waitSeconds, Action function)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class ScheduledUpdate : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class <RequeueFromErrorNextFrame>d__13 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Action requeueAction;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6B20", Offset = "0x2EC5320", VA = "0x182EC6B20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6C80", Offset = "0x2EC5480", VA = "0x182EC6C80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private ISchedulerPromise activeRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private MonoBehaviour behaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Action<float> updateWithTimeParameter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Scheduler.QueueType queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float updateHz;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1D50", Offset = "0x2EC0550", VA = "0x182EC1D50")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1EE0", Offset = "0x2EC06E0", VA = "0x182EC1EE0")]
		public ScheduledUpdate(MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2070", Offset = "0x2EC0870", VA = "0x182EC2070")]
		public ScheduledUpdate(MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2EC18E0", Offset = "0x2EC00E0", VA = "0x182EC18E0")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1760", Offset = "0x2EBFF60", VA = "0x182EC1760")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1630", Offset = "0x2EBFE30", VA = "0x182EC1630")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1AC0", Offset = "0x2EC02C0", VA = "0x182EC1AC0")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1A60", Offset = "0x2EC0260", VA = "0x182EC1A60")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC15E0", Offset = "0x2EBFDE0", VA = "0x182EC15E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class ScheduledUpdateMonoBehaviourExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1100", Offset = "0x2EBF900", VA = "0x182EC1100")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0F40", Offset = "0x2EBF740", VA = "0x182EC0F40")]
		public static IDisposable QueueUpdate(this MonoBehaviour behaviour, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1570", Offset = "0x2EBFD70", VA = "0x182EC1570")]
		public static IDisposable Update(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0B50", Offset = "0x2EBF350", VA = "0x182EC0B50")]
		public static IDisposable FixedUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0DD0", Offset = "0x2EBF5D0", VA = "0x182EC0DD0")]
		public static IDisposable LateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1180", Offset = "0x2EBF980", VA = "0x182EC1180")]
		public static IDisposable RigidbodyExLateUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0E40", Offset = "0x2EBF640", VA = "0x182EC0E40")]
		public static IDisposable PreRenderUpdate(this MonoBehaviour behaviour, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0EB0", Offset = "0x2EBF6B0", VA = "0x182EC0EB0")]
		public static IDisposable QueueUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2EC14F0", Offset = "0x2EBFCF0", VA = "0x182EC14F0")]
		public static IDisposable UpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1470", Offset = "0x2EBFC70", VA = "0x182EC1470")]
		public static IDisposable Update60hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1370", Offset = "0x2EBFB70", VA = "0x182EC1370")]
		public static IDisposable Update30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2EC1270", Offset = "0x2EBFA70", VA = "0x182EC1270")]
		public static IDisposable Update15hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2EC11F0", Offset = "0x2EBF9F0", VA = "0x182EC11F0")]
		public static IDisposable Update10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2EC13F0", Offset = "0x2EBFBF0", VA = "0x182EC13F0")]
		public static IDisposable Update5hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC12F0", Offset = "0x2EBFAF0", VA = "0x182EC12F0")]
		public static IDisposable Update1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0AC0", Offset = "0x2EBF2C0", VA = "0x182EC0AC0")]
		public static IDisposable FixedUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0A40", Offset = "0x2EBF240", VA = "0x182EC0A40")]
		public static IDisposable FixedUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0940", Offset = "0x2EBF140", VA = "0x182EC0940")]
		public static IDisposable FixedUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2EC09C0", Offset = "0x2EBF1C0", VA = "0x182EC09C0")]
		public static IDisposable FixedUpdate1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0D40", Offset = "0x2EBF540", VA = "0x182EC0D40")]
		public static IDisposable LateUpdateAtRate(this MonoBehaviour behaviour, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0CC0", Offset = "0x2EBF4C0", VA = "0x182EC0CC0")]
		public static IDisposable LateUpdate30hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0BC0", Offset = "0x2EBF3C0", VA = "0x182EC0BC0")]
		public static IDisposable LateUpdate10hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0C40", Offset = "0x2EBF440", VA = "0x182EC0C40")]
		public static IDisposable LateUpdate1hz(this MonoBehaviour behaviour, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class ScheduledJobbedUpdate : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class <RequeueFromErrorNextFrame>d__13 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public Action requeueAction;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <RequeueFromErrorNextFrame>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6BD0", Offset = "0x2EC53D0", VA = "0x182EC6BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6CD0", Offset = "0x2EC54D0", VA = "0x182EC6CD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private ISchedulerPromise activeRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IJobbedSchedulerContext context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private Action<float> updateWithTimeParameter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Scheduler.QueueType queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private float updateHz;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF9B0", Offset = "0x2EBE1B0", VA = "0x182EBF9B0")]
		public ScheduledJobbedUpdate(IJobbedSchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2EBFB40", Offset = "0x2EBE340", VA = "0x182EBFB40")]
		public ScheduledJobbedUpdate(IJobbedSchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2EBFCD0", Offset = "0x2EBE4D0", VA = "0x182EBFCD0")]
		public ScheduledJobbedUpdate(IJobbedSchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF530", Offset = "0x2EBDD30", VA = "0x182EBF530")]
		private void QueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF3B0", Offset = "0x2EBDBB0", VA = "0x182EBF3B0")]
		private void QueueUpdateWithTimeParameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF280", Offset = "0x2EBDA80", VA = "0x182EBF280")]
		private void QueueUpdateRate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF710", Offset = "0x2EBDF10", VA = "0x182EBF710")]
		private void RequeueFromError(string error, Action requeueAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF6B0", Offset = "0x2EBDEB0", VA = "0x182EBF6B0")]
		[IteratorStateMachine(typeof(<RequeueFromErrorNextFrame>d__13))]
		private IEnumerator<ISchedule> RequeueFromErrorNextFrame(Action requeueAction)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2EBF230", Offset = "0x2EBDA30", VA = "0x182EBF230", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class ScheduledUpdateContextExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0420", Offset = "0x2EBEC20", VA = "0x182EC0420")]
		public static IDisposable QueueUpdateJobbed(this IJobbedSchedulerContext context, Action update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC04A0", Offset = "0x2EBECA0", VA = "0x182EC04A0")]
		public static IDisposable QueueUpdateJobbed(this IJobbedSchedulerContext context, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC08D0", Offset = "0x2EBF0D0", VA = "0x182EC08D0")]
		public static IDisposable UpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0030", Offset = "0x2EBE830", VA = "0x182EC0030")]
		public static IDisposable FixedUpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC02B0", Offset = "0x2EBEAB0", VA = "0x182EC02B0")]
		public static IDisposable LateUpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0660", Offset = "0x2EBEE60", VA = "0x182EC0660")]
		public static IDisposable RigidbodyExLateUpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0320", Offset = "0x2EBEB20", VA = "0x182EC0320")]
		public static IDisposable PreRenderUpdateJobbed(this IJobbedSchedulerContext context, Action update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0390", Offset = "0x2EBEB90", VA = "0x182EC0390")]
		public static IDisposable QueueUpdateAtRateJobbed(this IJobbedSchedulerContext context, float hz, Action<float> update, Scheduler.QueueType queueType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0850", Offset = "0x2EBF050", VA = "0x182EC0850")]
		public static IDisposable UpdateAtRateJobbed(this IJobbedSchedulerContext context, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2EC07D0", Offset = "0x2EBEFD0", VA = "0x182EC07D0")]
		public static IDisposable Update30hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2EC06D0", Offset = "0x2EBEED0", VA = "0x182EC06D0")]
		public static IDisposable Update10hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0750", Offset = "0x2EBEF50", VA = "0x182EC0750")]
		public static IDisposable Update1hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x2EBFFA0", Offset = "0x2EBE7A0", VA = "0x182EBFFA0")]
		public static IDisposable FixedUpdateAtRateJobbed(this IJobbedSchedulerContext context, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2EBFF20", Offset = "0x2EBE720", VA = "0x182EBFF20")]
		public static IDisposable FixedUpdate30hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2EBFE20", Offset = "0x2EBE620", VA = "0x182EBFE20")]
		public static IDisposable FixedUpdate10hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2EBFEA0", Offset = "0x2EBE6A0", VA = "0x182EBFEA0")]
		public static IDisposable FixedUpdate1hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0220", Offset = "0x2EBEA20", VA = "0x182EC0220")]
		public static IDisposable LateUpdateAtRateJobbed(this IJobbedSchedulerContext context, float hz, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC01A0", Offset = "0x2EBE9A0", VA = "0x182EC01A0")]
		public static IDisposable LateUpdate30hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC00A0", Offset = "0x2EBE8A0", VA = "0x182EC00A0")]
		public static IDisposable LateUpdate10hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC0120", Offset = "0x2EBE920", VA = "0x182EC0120")]
		public static IDisposable LateUpdate1hzJobbed(this IJobbedSchedulerContext context, Action<float> update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class Scheduler : SingletonMonoBehaviour<Scheduler>
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private class JobbedSchedulerCoroutine : IJobbedSchedulerCoroutine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public JobbedSchedulerQueue Queue;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public int Index
			{
				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x3D3C50", Offset = "0x3D2450", VA = "0x1803D3C50", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000169")]
				[Cpp2IlInjected.Address(RVA = "0x3D3C90", Offset = "0x3D2490", VA = "0x1803D3C90")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x2EB9A70", Offset = "0x2EB8270", VA = "0x182EB9A70")]
			public static ISchedule Step(IEnumerator<ISchedule> coroutine, SchedulerPromise promise)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x2EB9BB0", Offset = "0x2EB83B0", VA = "0x182EB9BB0")]
			public ISchedule Step(SchedulerPromise[] allScheduledPromises, IEnumerator<ISchedule>[] coroutines, ISchedule[] currentSchedules)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x2EB98C0", Offset = "0x2EB80C0", VA = "0x182EB98C0")]
			public void OnContextDestroyed()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x2EB99B0", Offset = "0x2EB81B0", VA = "0x182EB99B0")]
			public void OnContextEnabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x2EB98F0", Offset = "0x2EB80F0", VA = "0x182EB98F0")]
			public void OnContextDisabled()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x2EB98C0", Offset = "0x2EB80C0", VA = "0x182EB98C0")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x3D3670", Offset = "0x3D1E70", VA = "0x1803D3670")]
			public JobbedSchedulerCoroutine()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private sealed class JobbedSchedulerQueue
		{
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct JobbedInsertionData
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				public JobbedSchedulerCoroutine Routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public IJobbedSchedulerContext Context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public SchedulerPromise Promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public IEnumerator<ISchedule> Coroutine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public ISchedule CurrentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public CoroutineState CoroutineState;
			}

			[Cpp2IlInjected.Token(Token = "0x2000055")]
			public struct JobbedReinsertBuffer
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public QueueType QueueType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public List<JobbedInsertionData> Insertions;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private readonly QueueType queueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private bool[] mainThreadCancels;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private NativeArray<CoroutineState> sharedCoroutineStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private NativeArray<float> NextUpdateTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private NativeArray<int> NumberToExecute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private NativeArray<int> UnsortedIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private NativeArray<int> SortedIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private NativeArray<int> MergeSortScratchLeft;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private NativeArray<int> MergeSortScratchRight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private JobbedSchedulerCoroutine[] allJobbedSchedulerJobbedRoutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private SchedulerPromise[] allScheduledPromises;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private IJobbedSchedulerContext[] allContexts;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private IEnumerator<ISchedule>[] allCoroutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private ISchedule[] allCurrentSchedules;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int coroutineCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private int capacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private readonly int initialCapacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private float nextScaleDownArraySizeTime;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private ScheduleSortJob queueSortJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private JobHandle sortJobHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private List<JobbedSchedulerCoroutine> queuedRemoves;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private bool jobInProgress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private List<Action> queuedCoroutineStateChanges;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private List<Action> queuedAddRemoveActions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private bool _disposed;

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public JobbedReinsertBuffer[] JobbedReinsertionQueues
			{
				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x3F4900", Offset = "0x3F3100", VA = "0x1803F4900")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public int CoroutineCount
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0x66FA80", Offset = "0x66E280", VA = "0x18066FA80")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA140", Offset = "0x2EB8940", VA = "0x182EBA140")]
			private static int GetInitialCapacity(QueueType queueType)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x2EBB9D0", Offset = "0x2EBA1D0", VA = "0x182EBB9D0")]
			public JobbedSchedulerQueue(QueueType queueType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x2EBB030", Offset = "0x2EB9830", VA = "0x182EBB030")]
			private void ResizeArrays(ref int oldCapacity, int newCapacity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA170", Offset = "0x2EB8970", VA = "0x182EBA170")]
			public void InsertJobbedSchedulerCoroutine(IJobbedSchedulerContext context, ISchedule currentSchedule, IEnumerator<ISchedule> coroutine, SchedulerPromise promise, [Optional] JobbedSchedulerCoroutine routine, CoroutineState coroutineState = CoroutineState.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA2A0", Offset = "0x2EB8AA0", VA = "0x182EBA2A0")]
			public void Insert(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAC00", Offset = "0x2EB9400", VA = "0x182EBAC00")]
			private JobbedInsertionData RemoveSchedulerCoroutine(int indexToRemove)
			{
				return default(JobbedInsertionData);
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x2EB9D30", Offset = "0x2EB8530", VA = "0x182EB9D30")]
			private void CleanupAllContexts()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1F34B30", Offset = "0x1F33330", VA = "0x181F34B30")]
			private static void SwapBackFill<T>(int indexToRemove, T[] myArray, int size, [Optional] T fillValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1F34B10", Offset = "0x1F33310", VA = "0x181F34B10")]
			private static void SwapBackFill<T>(int indexToRemove, NativeArray<T> myArray, int size, [Optional] T fillValue) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA930", Offset = "0x2EB9130", VA = "0x182EBA930")]
			private void QueueMultipleForInsertion(IEnumerable<JobbedInsertionData> insertionDatas)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA680", Offset = "0x2EB8E80", VA = "0x182EBA680")]
			private void QueueForReinsertJobbed(JobbedInsertionData jobbedInsertionData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x2EBB1C0", Offset = "0x2EB99C0", VA = "0x182EBB1C0")]
			private TickResult TickJobbedCoroutine(int scheduleIndex)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA740", Offset = "0x2EB8F40", VA = "0x182EBA740")]
			public void QueueJob(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA580", Offset = "0x2EB8D80", VA = "0x182EBA580")]
			private void QueueAddRemoveAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA600", Offset = "0x2EB8E00", VA = "0x182EBA600")]
			private void QueueCoroutineStateChangeAction(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x2EBB510", Offset = "0x2EB9D10", VA = "0x182EBB510")]
			public void UpdateJobSortedCoroutines(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA060", Offset = "0x2EB8860", VA = "0x182EBA060")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x2EB9C80", Offset = "0x2EB8480", VA = "0x182EB9C80")]
			public void Cancel(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x2EBA4D0", Offset = "0x2EB8CD0", VA = "0x182EBA4D0")]
			public void Pause(JobbedSchedulerCoroutine schedule)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x2EBB460", Offset = "0x2EB9C60", VA = "0x182EBB460")]
			public void Unpause(JobbedSchedulerCoroutine schedule)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[BurstCompile]
		public struct ScheduleSortJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			[ReadOnly]
			public float Now;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			[ReadOnly]
			public int ActiveCoroutineCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> Indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> scratchLeft;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> scratchRight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			[ReadOnly]
			public NativeArray<CoroutineState> AllCoroutineStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			[ReadOnly]
			public NativeArray<float> AllNextUpdateTimes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			[WriteOnly]
			public NativeArray<int> SortedIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			[WriteOnly]
			public NativeArray<int> NumberToExecute;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x2EBE740", Offset = "0x2EBCF40", VA = "0x182EBE740")]
			public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
			{
				return default(ScheduleSortJob);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x398C60", Offset = "0x398060", VA = "0x180398C60", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x398D10", Offset = "0x398110", VA = "0x180398D10")]
			private bool ShouldExecute(int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x398CB0", Offset = "0x3980B0", VA = "0x180398CB0")]
			private void MergeSort(NativeArray<int> arr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x398C70", Offset = "0x398070", VA = "0x180398C70")]
			private int IndexCompare(int indexA, int indexB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x398C80", Offset = "0x398080", VA = "0x180398C80")]
			private void MergeSortImpl(NativeArray<int> arr, int l, int r)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x398CD0", Offset = "0x3980D0", VA = "0x180398CD0")]
			private void Merge(NativeArray<int> arr, int leftStart, int middle, int rightEnd)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private sealed class SchedulerCoroutine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private readonly SchedulerPromise promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private readonly Behaviour context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private readonly bool wasCreatedWithContext;

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public IEnumerator<ISchedule> Coroutine
			{
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0x3D59A0", Offset = "0x3D41A0", VA = "0x1803D59A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x3D59B0", Offset = "0x3D41B0", VA = "0x1803D59B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public ISchedule CurrentSchedule
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x3D3280", Offset = "0x3D1A80", VA = "0x1803D3280")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public bool Paused
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x2EC26E0", Offset = "0x2EC0EE0", VA = "0x182EC26E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public bool Canceled
			{
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0x6FFD40", Offset = "0x6FE540", VA = "0x1806FFD40")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x708160", Offset = "0x706960", VA = "0x180708160")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x4008E0", Offset = "0x3FF0E0", VA = "0x1804008E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x433E00", Offset = "0x432600", VA = "0x180433E00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public float NextUpdateKey
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x5E2460", Offset = "0x5E0C60", VA = "0x1805E2460")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x5E2520", Offset = "0x5E0D20", VA = "0x1805E2520")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2560", Offset = "0x2EC0D60", VA = "0x182EC2560")]
			public SchedulerCoroutine(IEnumerator<ISchedule> coroutine, Behaviour context, SchedulerPromise promise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2EC22E0", Offset = "0x2EC0AE0", VA = "0x182EC22E0")]
			public ISchedule Step()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2EC21C0", Offset = "0x2EC09C0", VA = "0x182EC21C0")]
			public bool CancelIfExpired()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2250", Offset = "0x2EC0A50", VA = "0x182EC2250")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x2EC24D0", Offset = "0x2EC0CD0", VA = "0x182EC24D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private sealed class SchedulerPromise : CancelablePromise, ISchedulerPromise, ICancelablePromise, IPromise, IEnumerator, ISchedule, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private QueueType _queue;

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			QueueType ISchedule.Queue
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x3E50B0", Offset = "0x3E38B0", VA = "0x1803E50B0", Slot = "24")]
				get
				{
					return default(QueueType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			public QueueType Queue
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0x3E50B0", Offset = "0x3E38B0", VA = "0x1803E50B0")]
				get
				{
					return default(QueueType);
				}
				[Cpp2IlInjected.Token(Token = "0x60001A1")]
				[Cpp2IlInjected.Address(RVA = "0x3E5330", Offset = "0x3E3B30", VA = "0x1803E5330")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			float ISchedule.NextPossibleReady
			{
				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0x3F48D0", Offset = "0x3F30D0", VA = "0x1803F48D0", Slot = "26")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4BF990", Offset = "0x4BE190", VA = "0x1804BF990", Slot = "25")]
			bool ISchedule.Ready()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2770", Offset = "0x2EC0F70", VA = "0x182EC2770", Slot = "27")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2780", Offset = "0x2EC0F80", VA = "0x182EC2780")]
			public SchedulerPromise()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private enum TickResult : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class SchedulerQueue : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			public enum SubQueue
			{
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public struct ReinsertBuffer
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public QueueType QueueType;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public SubQueue SubQueue;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public List<SchedulerCoroutine> Coroutines;
			}

			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private static readonly SubQueue[] subQueueTypes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private readonly QueueType queueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private bool lockedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private readonly SchedulerCoroutine[] singleCoroutineArrayBuffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private readonly List<SchedulerCoroutine> immediateCoroutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private readonly Stack<int> immediateUpdateHoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private readonly List<SchedulerCoroutine> futureCoroutines;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private readonly Stack<int> futureUpdateHoles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private bool _disposed;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public ReinsertBuffer[,] ReinsertBuffers
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x3E52F0", Offset = "0x3E3AF0", VA = "0x1803E52F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			public int CoroutineCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x2EC3F10", Offset = "0x2EC2710", VA = "0x182EC3F10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x2EC3B30", Offset = "0x2EC2330", VA = "0x182EC3B30")]
			public SchedulerQueue(QueueType queue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x2EC3280", Offset = "0x2EC1A80", VA = "0x182EC3280")]
			public void LogFutureRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x2EC3290", Offset = "0x2EC1A90", VA = "0x182EC3290")]
			public void LogImmediateRoutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2EC32A0", Offset = "0x2EC1AA0", VA = "0x182EC32A0")]
			private void LogRoutines(IReadOnlyList<SchedulerCoroutine> routines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x2EC3180", Offset = "0x2EC1980", VA = "0x182EC3180")]
			public void InsertSingleCoroutine(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2F00", Offset = "0x2EC1700", VA = "0x182EC2F00")]
			public void InsertImmediates(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2C80", Offset = "0x2EC1480", VA = "0x182EC2C80")]
			public void InsertFutures(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x2EC33C0", Offset = "0x2EC1BC0", VA = "0x182EC33C0")]
			private void QueueForReinsert(SchedulerCoroutine coroutine)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x2EC34B0", Offset = "0x2EC1CB0", VA = "0x182EC34B0")]
			private void QueueMultipleForReinsert(IList<SchedulerCoroutine> coroutines)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x2EC3620", Offset = "0x2EC1E20", VA = "0x182EC3620")]
			private TickResult TickCoroutine(SchedulerCoroutine coroutine)
			{
				return default(TickResult);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x2EC3980", Offset = "0x2EC2180", VA = "0x182EC3980")]
			public void Update(float currentTime)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2EC27E0", Offset = "0x2EC0FE0", VA = "0x182EC27E0")]
			public void ClearExpiredCoroutines()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x2EC37A0", Offset = "0x2EC1FA0", VA = "0x182EC37A0")]
			private void UpdateCoroutinesInternal(List<SchedulerCoroutine> coroutines, Stack<int> updateHoles, bool removalOnly, float now = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x2EC2B40", Offset = "0x2EC1340", VA = "0x182EC2B40", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x2EC29E0", Offset = "0x2EC11E0", VA = "0x182EC29E0")]
			private void ClearQueuedRoutines(List<SchedulerCoroutine> coroutines)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public enum QueueType
		{
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			PreRender,
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			EndOfFrame
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[Flags]
		public enum CoroutineState : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class <EndOfFrameRoutine>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000058")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <EndOfFrameRoutine>d__34(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x2EC65B0", Offset = "0x2EC4DB0", VA = "0x182EC65B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6630", Offset = "0x2EC4E30", VA = "0x182EC6630", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const CoroutineState PAUSED_INACTIVE_OR_CANCELLED = CoroutineState.Cancelled | CoroutineState.Paused;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly QueueType[] queueTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private SchedulerQueue[] queues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private JobbedSchedulerQueue[] jobbedQueues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Coroutine endOfFrameRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private WaitForEndOfFrame waitForEndOfFrame;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ISchedulerTimer Timer
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3D3280", Offset = "0x3D1A80", VA = "0x1803D3280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int CoroutineCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x2EC58F0", Offset = "0x2EC40F0", VA = "0x182EC58F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC48C0", Offset = "0x2EC30C0", VA = "0x182EC48C0")]
		public static ISchedulerPromise GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4080", Offset = "0x2EC2880", VA = "0x182EC4080", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2EC49B0", Offset = "0x2EC31B0", VA = "0x182EC49B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4960", Offset = "0x2EC3160", VA = "0x182EC4960")]
		private SchedulerQueue GetQueue(QueueType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83D0F0", Offset = "0x83B8F0", VA = "0x18083D0F0")]
		private JobbedSchedulerQueue GetJobbedQueue(QueueType type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4E40", Offset = "0x2EC3640", VA = "0x182EC4E40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4E10", Offset = "0x2EC3610", VA = "0x182EC4E10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2EC56F0", Offset = "0x2EC3EF0", VA = "0x182EC56F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4EB0", Offset = "0x2EC36B0", VA = "0x182EC4EB0")]
		private void OnPostUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4ED0", Offset = "0x2EC36D0", VA = "0x182EC4ED0")]
		private void OnRigidbodyExLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2EC45D0", Offset = "0x2EC2DD0", VA = "0x182EC45D0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2EC49A0", Offset = "0x2EC31A0", VA = "0x182EC49A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4EC0", Offset = "0x2EC36C0", VA = "0x182EC4EC0")]
		private void OnPreRenderUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4570", Offset = "0x2EC2D70", VA = "0x182EC4570")]
		[IteratorStateMachine(typeof(<EndOfFrameRoutine>d__34))]
		private IEnumerator EndOfFrameRoutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5330", Offset = "0x2EC3B30", VA = "0x182EC5330")]
		public ISchedulerPromise Run(IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5010", Offset = "0x2EC3810", VA = "0x182EC5010")]
		public ISchedulerPromise Run(Behaviour context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4EE0", Offset = "0x2EC36E0", VA = "0x182EC4EE0")]
		public ISchedulerPromise RunJobbed(IJobbedSchedulerContext context, IEnumerator<ISchedule> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4510", Offset = "0x2EC2D10", VA = "0x182EC4510")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5340", Offset = "0x2EC3B40", VA = "0x182EC5340")]
		public void UpdateQueue(QueueType currentQueueType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2EC4700", Offset = "0x2EC2F00", VA = "0x182EC4700")]
		private void FlushReinserts(SchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2EC45E0", Offset = "0x2EC2DE0", VA = "0x182EC45E0")]
		private void FlushJobbedReinserts(JobbedSchedulerQueue currentQueue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2EC5870", Offset = "0x2EC4070", VA = "0x182EC5870")]
		public Scheduler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface ISchedulerTimer
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float FixedDeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		double RealtimeSinceStartup
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class DefaultTimer : ISchedulerTimer
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float Time
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2EB86C0", Offset = "0x2EB6EC0", VA = "0x182EB86C0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float DeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2EB8670", Offset = "0x2EB6E70", VA = "0x182EB8670", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float FixedDeltaTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2EB8680", Offset = "0x2EB6E80", VA = "0x182EB8680", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int FrameCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2EB8690", Offset = "0x2EB6E90", VA = "0x182EB8690", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public double RealtimeSinceStartup
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x2EB86A0", Offset = "0x2EB6EA0", VA = "0x182EB86A0", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D3670", Offset = "0x3D1E70", VA = "0x1803D3670")]
		public DefaultTimer()
		{
		}
	}
}
namespace RecRoom.Analytics
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class RollingBufferAverageStats : IAveragedStats
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int MaxBufferLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Queue<double> valuesBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private double min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private double max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private double sum;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int BufferCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x2EBD550", Offset = "0x2EBBD50", VA = "0x182EBD550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x2EBD590", Offset = "0x2EBBD90", VA = "0x182EBD590", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xA9B260", Offset = "0xA99A60", VA = "0x180A9B260", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xA9B250", Offset = "0xA99A50", VA = "0x180A9B250", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD4C0", Offset = "0x2EBBCC0", VA = "0x182EBD4C0")]
		public RollingBufferAverageStats(int maxBufferLength)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD3C0", Offset = "0x2EBBBC0", VA = "0x182EBD3C0", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD350", Offset = "0x2EBBB50", VA = "0x182EBD350", Slot = "5")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class EWMAStats : IAveragedStats
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private long count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private double mean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private double m2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private double variance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private double stdDev;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private double min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private double max;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public long Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3D59A0", Offset = "0x3D41A0", VA = "0x1803D59A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x715090", Offset = "0x713890", VA = "0x180715090", Slot = "7")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xA9B280", Offset = "0xA99A80", VA = "0x180A9B280", Slot = "8")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public double Variance
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA9B250", Offset = "0xA99A50", VA = "0x180A9B250")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public double StdDev
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x2BF4BE0", Offset = "0x2BF33E0", VA = "0x182BF4BE0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA9B1B0", Offset = "0xA999B0", VA = "0x180A9B1B0", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9770", Offset = "0x2EB7F70", VA = "0x182EB9770", Slot = "4")]
		public void Track(double val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9730", Offset = "0x2EB7F30", VA = "0x182EB9730", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2EB9890", Offset = "0x2EB8090", VA = "0x182EB9890")]
		public EWMAStats()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface IAveragedStats
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		double Mean
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		double Min
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		double Max
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Track(double val);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Reset();
	}
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class MainThreadDispatcher
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private interface IQueuedDispatch
		{
			[Cpp2IlInjected.Token(Token = "0x17000059")]
			bool IsReady
			{
				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void Complete();

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void Cancel();
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private abstract class PromiseDispatchBase<TPromise, TMainThreadPromise> : IQueuedDispatch where TPromise : IPromise where TMainThreadPromise : TPromise
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private readonly TPromise backgroundPromise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			protected readonly TMainThreadPromise MainThreadInternalPromise;

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public TPromise MainThreadPromise
			{
				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x21E05A0", Offset = "0x21DEDA0", VA = "0x1821E05A0")]
				get
				{
					return (TPromise)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public bool IsReady
			{
				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0x21E0550", Offset = "0x21DED50", VA = "0x1821E0550", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x1FF1C60", Offset = "0x1FF0460", VA = "0x181FF1C60")]
			protected PromiseDispatchBase(TPromise backgroundPromise, TMainThreadPromise mainThreadInternalPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x21E0520", Offset = "0x21DED20", VA = "0x1821E0520", Slot = "5")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x20B1DF0", Offset = "0x20B05F0", VA = "0x1820B1DF0", Slot = "6")]
			public void Cancel()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "7")]
			protected abstract void CompleteInternal(TPromise backgroundPromise);

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "8")]
			protected abstract void CancelInternal();
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class PromiseDispatch<T> : PromiseDispatchBase<IPromise<T>, Promise<T>>
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x21E0A70", Offset = "0x21DF270", VA = "0x1821E0A70")]
			public PromiseDispatch(IPromise<T> backgroundPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x21E0860", Offset = "0x21DF060", VA = "0x1821E0860", Slot = "7")]
			protected override void CompleteInternal(IPromise<T> backgroundPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x21E0660", Offset = "0x21DEE60", VA = "0x1821E0660", Slot = "8")]
			protected override void CancelInternal()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private class PromiseDispatch : PromiseDispatchBase<IPromise, Promise>
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCB80", Offset = "0x2EBB380", VA = "0x182EBCB80")]
			public PromiseDispatch(IPromise backgroundPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCAB0", Offset = "0x2EBB2B0", VA = "0x182EBCAB0", Slot = "7")]
			protected override void CompleteInternal(IPromise backgroundPromise)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2EBCA60", Offset = "0x2EBB260", VA = "0x182EBCA60", Slot = "8")]
			protected override void CancelInternal()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private class ActionDispatch : IQueuedDispatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private readonly Action action;

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			public bool IsReady
			{
				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0x4CCE40", Offset = "0x4CB640", VA = "0x1804CCE40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x3D5A30", Offset = "0x3D4230", VA = "0x1803D5A30")]
			public ActionDispatch(Action action)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x7446B0", Offset = "0x742EB0", VA = "0x1807446B0", Slot = "5")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "6")]
			public void Cancel()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static readonly List<IQueuedDispatch> queuedDispatches;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2322D60", Offset = "0x2321560", VA = "0x182322D60")]
		public static IPromise<T> DispatchOntoMainThread<T>(IPromise<T> backgroundPromise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC150", Offset = "0x2EBA950", VA = "0x182EBC150")]
		public static IPromise DispatchOntoMainThread(IPromise backgroundPromise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC230", Offset = "0x2EBAA30", VA = "0x182EBC230")]
		public static void DispatchOntoMainThread(Action action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2EBBEA0", Offset = "0x2EBA6A0", VA = "0x182EBBEA0")]
		private static void AddDispatch(IQueuedDispatch dispatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC2B0", Offset = "0x2EBAAB0", VA = "0x182EBC2B0")]
		private static void ProcessUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC5F0", Offset = "0x2EBADF0", VA = "0x182EBC5F0")]
		private static void RegisterDispatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2EBC0A0", Offset = "0x2EBA8A0", VA = "0x182EBC0A0")]
		private static void DeregisterDispatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class SceneHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public Promise onCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x3D3670", Offset = "0x3D1E70", VA = "0x1803D3670")]
			public <>c__DisplayClass12_0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class <LoadSceneRoutine>d__12 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Promise onCompletePromise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public LoadSceneMode loadSceneMode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private <>c__DisplayClass12_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public bool async;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public int sceneIndex;

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <LoadSceneRoutine>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2EC68D0", Offset = "0x2EC50D0", VA = "0x182EC68D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2EC6AD0", Offset = "0x2EC52D0", VA = "0x182EC6AD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass14_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Promise onCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x3D3670", Offset = "0x3D1E70", VA = "0x1803D3670")]
			public <>c__DisplayClass14_0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class <UnloadSceneRoutine>d__14 : IEnumerator<ISchedule>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private ISchedule <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public string sceneName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Promise onCompletePromise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private <>c__DisplayClass14_0 <>8__1;

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			ISchedule IEnumerator<ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EA")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3D3240", Offset = "0x3D1A40", VA = "0x1803D3240", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3F66E0", Offset = "0x3F4EE0", VA = "0x1803F66E0")]
			[DebuggerHidden]
			public <UnloadSceneRoutine>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF60", Offset = "0x3DA760", VA = "0x1803DBF60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2EC7F40", Offset = "0x2EC6740", VA = "0x182EC7F40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2EC8090", Offset = "0x2EC6890", VA = "0x182EC8090", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string EMPTY_SCENE_NAME = "empty";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public const string MODERATOR_ROOM_SCENE_NAME = "moderator";

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public const string MAIN_ROOT_SCENE_NAME = "main_root";

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public const string LOGOUT_SCENE_NAME = "LogoutScene";

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static ICancelablePromise activeLoadScenePromise;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static AsyncOperation activeLoadSceneOperation;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static bool IsSceneLoadPending
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x2EBDBA0", Offset = "0x2EBC3A0", VA = "0x182EBDBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD8C0", Offset = "0x2EBC0C0", VA = "0x182EBD8C0")]
		public static ICancelablePromise LoadScene(string sceneName, LoadSceneMode loadSceneMode = LoadSceneMode.Single)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD5F0", Offset = "0x2EBBDF0", VA = "0x182EBD5F0")]
		public static ICancelablePromise LoadSceneAsync(int sceneIndex, LoadSceneMode loadSceneMode = LoadSceneMode.Single)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD8F0", Offset = "0x2EBC0F0", VA = "0x182EBD8F0")]
		public static ICancelablePromise UnloadSceneAsync(string sceneName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD620", Offset = "0x2EBBE20", VA = "0x182EBD620")]
		private static ICancelablePromise LoadSceneInternal(string sceneName, int sceneIndex, LoadSceneMode loadSceneMode, bool async)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD820", Offset = "0x2EBC020", VA = "0x182EBD820")]
		[IteratorStateMachine(typeof(<LoadSceneRoutine>d__12))]
		private static IEnumerator<ISchedule> LoadSceneRoutine(string sceneName, int sceneIndex, LoadSceneMode loadSceneMode, bool async, Promise onCompletePromise)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2EBD900", Offset = "0x2EBC100", VA = "0x182EBD900")]
		private static ICancelablePromise UnloadSceneInternal(string sceneName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2EBDB30", Offset = "0x2EBC330", VA = "0x182EBDB30")]
		[IteratorStateMachine(typeof(<UnloadSceneRoutine>d__14))]
		private static IEnumerator<ISchedule> UnloadSceneRoutine(string sceneName, Promise onCompletePromise)
		{
			return null;
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
