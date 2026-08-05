using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Async;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)3, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GameRestartBehaviors
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	DestroyNew,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DestroyOld
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class GameRoot : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public GameRoot <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3458D0", Offset = "0x343ED0", VA = "0x1803458D0")]
		[DebuggerHidden]
		public <Start>d__10(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xFE7B50", Offset = "0xFE6150", VA = "0x180FE7B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xFE8540", Offset = "0xFE6B40", VA = "0x180FE8540", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class <MergeRoots>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public List<GameRoot> gameRoots;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private GameRoot <gameRoot0>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private GameRoot <gameRoot1>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3458D0", Offset = "0x343ED0", VA = "0x1803458D0")]
		[DebuggerHidden]
		public <MergeRoots>d__12(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xFE6D60", Offset = "0xFE5360", VA = "0x180FE6D60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xFE7B00", Offset = "0xFE6100", VA = "0x180FE7B00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private GameObject StartupObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	private Transform coreSystems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	private Transform UI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static GameRoot Instance;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static int index;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static HashSet<IGameSingleton> ExistingGameSingletons;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static List<GameRoot> GameRoots;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xFE5E90", Offset = "0xFE4490", VA = "0x180FE5E90")]
	public static void AddExistingSingleton(IGameSingleton s)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xFE5F10", Offset = "0xFE4510", VA = "0x180FE5F10", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xFE5FF0", Offset = "0xFE45F0", VA = "0x180FE5FF0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xFE6070", Offset = "0xFE4670", VA = "0x180FE6070")]
	[IteratorStateMachine(typeof(<Start>d__10))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "6")]
	protected virtual void OnInitializationComplete()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xFE5F90", Offset = "0xFE4590", VA = "0x180FE5F90")]
	[IteratorStateMachine(typeof(<MergeRoots>d__12))]
	public static IEnumerator MergeRoots(List<GameRoot> gameRoots)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x32A3F0", Offset = "0x3289F0", VA = "0x18032A3F0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IGameSingleton
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameRestartBehaviors GameRestartBehavior
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GameObject GameObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ManagedSingletonObject : MonoBehaviour, IGameSingleton
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	private GameRestartBehaviors gameRestartBehavior;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameRestartBehaviors GameRestartBehavior
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D40", Offset = "0x3CF340", VA = "0x1803D0D40", Slot = "4")]
		get
		{
			return default(GameRestartBehaviors);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GameObject GameObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x357E60", Offset = "0x356460", VA = "0x180357E60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xFE6180", Offset = "0xFE4780", VA = "0x180FE6180")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xFE6410", Offset = "0xFE4A10", VA = "0x180FE6410")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xFE6530", Offset = "0xFE4B30", VA = "0x180FE6530")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class SingletonMonoBehaviour<T> : SingletonMonoBehaviourBase where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T instance;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static T Instance
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xDBEB10", Offset = "0xDBD110", VA = "0x180DBEB10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xDBED70", Offset = "0xDBD370", VA = "0x180DBED70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static bool IsInitialized
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDBEC10", Offset = "0xDBD210", VA = "0x180DBEC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xDBE640", Offset = "0xDBCC40", VA = "0x180DBE640", Slot = "7")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xDBE8E0", Offset = "0xDBCEE0", VA = "0x180DBE8E0", Slot = "8")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xDBEAF0", Offset = "0xDBD0F0", VA = "0x180DBEAF0")]
	public SingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SingletonMonoBehaviourBase : MonoBehaviour, IGameSingleton
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[SerializeField]
	private GameRestartBehaviors gameRestartBehavior;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public virtual GameRestartBehaviors GameRestartBehavior
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x32A820", Offset = "0x328E20", VA = "0x18032A820", Slot = "6")]
		get
		{
			return default(GameRestartBehaviors);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject GameObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x357E60", Offset = "0x356460", VA = "0x180357E60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5163F0", Offset = "0x5149F0", VA = "0x1805163F0")]
	protected SingletonMonoBehaviourBase()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class TimeSeriesRollingWindow<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly float SampleInterval;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly float WindowLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private List<Tuple<float, T>> samples;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int MaxSampleCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1DCBA40", Offset = "0x1DCA040", VA = "0x181DCBA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB910", Offset = "0x1DC9F10", VA = "0x181DCB910")]
	public TimeSeriesRollingWindow(float sampleInterval, float windowLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB650", Offset = "0x1DC9C50", VA = "0x181DCB650")]
	public bool TryToAddSample(float time, T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCAEF0", Offset = "0x1DC94F0", VA = "0x181DCAEF0")]
	public IEnumerable<T> GetSamples(float time, [Optional] float? minTime)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCAEC0", Offset = "0x1DC94C0", VA = "0x181DCAEC0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB590", Offset = "0x1DC9B90", VA = "0x181DCB590")]
	private void RemoveOldSamples(float time)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class TimestampedRollingBuffer<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BufferEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float Timestamp;
	}

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static float InvalidTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private List<T> scratchBuffer;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const int MAX_SIZE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private BufferEntry[] array;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int head;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float LatestTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x50BA70", Offset = "0x50A070", VA = "0x18050BA70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x50BAC0", Offset = "0x50A0C0", VA = "0x18050BAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCA50", Offset = "0x1DCB050", VA = "0x181DCCA50")]
	public TimestampedRollingBuffer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC980", Offset = "0x1DCAF80", VA = "0x181DCC980")]
	public TimestampedRollingBuffer(int size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBAC0", Offset = "0x1DCA0C0", VA = "0x181DCBAC0")]
	public void Add(float time, T value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBC70", Offset = "0x1DCA270", VA = "0x181DCBC70")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC470", Offset = "0x1DCAA70", VA = "0x181DCC470")]
	public bool TryGetAverageValueOverTime(float startTime, float endTime, out T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC7E0", Offset = "0x1DCADE0", VA = "0x181DCC7E0")]
	public bool TryGetMaximumValueOverTime(float startTime, float endTime, out T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC080", Offset = "0x1DCA680", VA = "0x181DCC080")]
	public void GetValuesInTimeWindow(float startTime, float endTime, List<T> buffer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC210", Offset = "0x1DCA810", VA = "0x181DCC210")]
	private int RollingHeadOffset(int headOffset)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC1D0", Offset = "0x1DCA7D0", VA = "0x181DCC1D0")]
	private void IncrementHead()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ZeroValue();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T Scale(T value, float t);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T Sum(T lhs, T rhs);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T Max(T lhs, T rhs);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class TimestampedRollingBufferVector3 : TimestampedRollingBuffer<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xFE6960", Offset = "0xFE4F60", VA = "0x180FE6960", Slot = "4")]
	protected override Vector3 ZeroValue()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xFE6810", Offset = "0xFE4E10", VA = "0x180FE6810", Slot = "5")]
	protected override Vector3 Scale(Vector3 value, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xFE68B0", Offset = "0xFE4EB0", VA = "0x180FE68B0", Slot = "6")]
	protected override Vector3 Sum(Vector3 lhs, Vector3 rhs)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xFE67A0", Offset = "0xFE4DA0", VA = "0x180FE67A0", Slot = "7")]
	protected override Vector3 Max(Vector3 lhs, Vector3 rhs)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xFE69D0", Offset = "0xFE4FD0", VA = "0x180FE69D0")]
	public TimestampedRollingBufferVector3()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x19A0D60", Offset = "0x199F360", VA = "0x1819A0D60")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x19A0C40", Offset = "0x199F240", VA = "0x1819A0C40")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA93B20", Offset = "0xA92120", VA = "0x180A93B20")]
	internal static int CombineHashCodes(int h1, int h2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xFE6D50", Offset = "0xFE5350", VA = "0x180FE6D50")]
	internal static int CombineHashCodes(int h1, int h2, int h3)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class Tuple<T1, T2> : IComparable<Tuple<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 Item2;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1949230", Offset = "0x1947830", VA = "0x181949230")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCA80", Offset = "0x1DCB080", VA = "0x181DCCA80", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCFE0", Offset = "0x1DCB5E0", VA = "0x181DCCFE0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD2C0", Offset = "0x1DCB8C0", VA = "0x181DCD2C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCDCD0", Offset = "0x1DCC2D0", VA = "0x181DCDCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Tuple<T1, T2, T3> : IComparable<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T2 Item2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T3 Item3;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1DCED10", Offset = "0x1DCD310", VA = "0x181DCED10")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE000", Offset = "0x1DCC600", VA = "0x181DCE000", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE100", Offset = "0x1DCC700", VA = "0x181DCE100", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE3F0", Offset = "0x1DCC9F0", VA = "0x181DCE3F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEA90", Offset = "0x1DCD090", VA = "0x181DCEA90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T Value
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x32DC80", Offset = "0x32C280", VA = "0x18032DC80")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3CB890", Offset = "0x3C9E90", VA = "0x1803CB890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float Duration
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4D1D20", Offset = "0x4D0320", VA = "0x1804D1D20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x260D690", Offset = "0x260BC90", VA = "0x18260D690")]
	public T Evaluate(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x260D360", Offset = "0x260B960", VA = "0x18260D360")]
	public T EvaluateNonNormalized(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T Interpolate(T lhs, T rhs, float t);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x535E00", Offset = "0x534400", VA = "0x180535E00")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xFE5DD0", Offset = "0xFE43D0", VA = "0x180FE5DD0", Slot = "4")]
	protected override float Interpolate(float lhs, float rhs, float t)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xFE5E50", Offset = "0xFE4450", VA = "0x180FE5E50")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xFE8590", Offset = "0xFE6B90", VA = "0x180FE8590", Slot = "4")]
	protected override Vector3 Interpolate(Vector3 lhs, Vector3 rhs, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xFE8650", Offset = "0xFE6C50", VA = "0x180FE8650")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xFE5D00", Offset = "0xFE4300", VA = "0x180FE5D00", Slot = "4")]
	protected override Color Interpolate(Color lhs, Color rhs, float t)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xFE5D50", Offset = "0xFE4350", VA = "0x180FE5D50")]
	public ColorValueCurve()
	{
	}
}
namespace RecRoom
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct CachedProperty
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct UntilCleared<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private T value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool initialized;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool HasValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x7030", Offset = "0x6430", VA = "0x180007030")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public T Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x7060", Offset = "0x6460", VA = "0x180007060")]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2D320", Offset = "0x2C720", VA = "0x18002D320")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2D290", Offset = "0x2C690", VA = "0x18002D290")]
			public void Clear()
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private CircularBuffer<T> buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private T current;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0xF4E0", Offset = "0xE8E0", VA = "0x18000F4E0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2CDD0", Offset = "0x2C1D0", VA = "0x18002CDD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2D1A0", Offset = "0x2C5A0", VA = "0x18002D1A0")]
			public Enumerator(CircularBuffer<T> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2A20", Offset = "0x1E20", VA = "0x180002A20", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C0", Offset = "0x2BCC0", VA = "0x18002C8C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2CBD0", Offset = "0x2BFD0", VA = "0x18002CBD0", Slot = "8")]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2C640", Offset = "0x2BA40", VA = "0x18002C640")]
			private void CheckVersion()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private T[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int startIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int endIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xD0F4F0", Offset = "0xD0DAF0", VA = "0x180D0F4F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD0F5B0", Offset = "0xD0DBB0", VA = "0x180D0F5B0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD0F6B0", Offset = "0xD0DCB0", VA = "0x180D0F6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xD0F460", Offset = "0xD0DA60", VA = "0x180D0F460")]
		public CircularBuffer(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD0E610", Offset = "0xD0CC10", VA = "0x180D0E610")]
		public void Add(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xD0E860", Offset = "0xD0CE60", VA = "0x180D0E860")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xD0F240", Offset = "0xD0D840", VA = "0x180D0F240")]
		public void RemoveFromFront(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xD0EB20", Offset = "0xD0D120", VA = "0x180D0EB20")]
		public void CopyTo(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xD0F200", Offset = "0xD0D800", VA = "0x180D0F200")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD0F360", Offset = "0xD0D960", VA = "0x180D0F360", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD0F360", Offset = "0xD0D960", VA = "0x180D0F360", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xD0EEB0", Offset = "0xD0D4B0", VA = "0x180D0EEB0")]
		private int ExternalToInternalIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD0E830", Offset = "0xD0CE30", VA = "0x180D0E830")]
		private int ClampIndexToRange(int index)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class ListEvent
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void DynamicInvoke(object[] args);

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x346C00", Offset = "0x345200", VA = "0x180346C00")]
		protected ListEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class ListEvent<T> : ListEvent
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		protected struct ModificationData
		{
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x4000041")]
				ADD,
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				REMOVE,
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				CLEAR
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public T action;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected bool isIterating;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		protected readonly bool useTryCatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected readonly List<T> actionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly List<ModificationData> queuedModifications;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HasEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1842FF0", Offset = "0x18415F0", VA = "0x181842FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1842F00", Offset = "0x1841500", VA = "0x181842F00")]
		public ListEvent(int capacity, bool useTryCatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1842C10", Offset = "0x1841210", VA = "0x181842C10")]
		protected void ProcessQueuedModifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1842AD0", Offset = "0x18410D0", VA = "0x181842AD0")]
		public void Add(T action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1842DC0", Offset = "0x18413C0", VA = "0x181842DC0")]
		public void Remove(T action)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class ActionEvent : ListEvent<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xFE5BE0", Offset = "0xFE41E0", VA = "0x180FE5BE0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xFE5990", Offset = "0xFE3F90", VA = "0x180FE5990")]
		public void Invoke(bool clearAfterInvoke = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xFE5900", Offset = "0xFE3F00", VA = "0x180FE5900", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xFE5C40", Offset = "0xFE4240", VA = "0x180FE5C40")]
		public static ActionEvent operator +(ActionEvent actionEvent, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xFE5CA0", Offset = "0xFE42A0", VA = "0x180FE5CA0")]
		public static ActionEvent operator -(ActionEvent actionEvent, Action action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class ActionEvent<T> : ListEvent<Action<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xCF6550", Offset = "0xCF4B50", VA = "0x180CF6550")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xCF5FD0", Offset = "0xCF45D0", VA = "0x180CF5FD0")]
		public void Invoke(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCF4FD0", Offset = "0xCF35D0", VA = "0x180CF4FD0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xCF6580", Offset = "0xCF4B80", VA = "0x180CF6580")]
		public static ActionEvent<T> operator +(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6620", Offset = "0xCF4C20", VA = "0x180CF6620")]
		public static ActionEvent<T> operator -(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class ActionEvent<T, U> : ListEvent<Action<T, U>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6550", Offset = "0xCF4B50", VA = "0x180CF6550")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCF7090", Offset = "0xCF5690", VA = "0x180CF7090")]
		public void Invoke(T t, U u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xCF66C0", Offset = "0xCF4CC0", VA = "0x180CF66C0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6620", Offset = "0xCF4C20", VA = "0x180CF6620")]
		public static ActionEvent<T, U> operator +(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xCF8110", Offset = "0xCF6710", VA = "0x180CF8110")]
		public static ActionEvent<T, U> operator -(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class ActionEvent<T, U, V> : ListEvent<Action<T, U, V>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xCF6550", Offset = "0xCF4B50", VA = "0x180CF6550")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xCF83C0", Offset = "0xCF69C0", VA = "0x180CF83C0")]
		public void Invoke(T t, U u, V v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCF81B0", Offset = "0xCF67B0", VA = "0x180CF81B0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class UniqueTreeNode<T> where T : IEquatable<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public delegate bool TreeTraversalOperation(UniqueTreeNode<T> node);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public T Content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LinkedList<UniqueTreeNode<T>> Children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public UniqueTreeNode<T> _parent;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public UniqueTreeNode<T> Parent
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3759C0", Offset = "0x373FC0", VA = "0x1803759C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6E0D40", Offset = "0x6DF340", VA = "0x1806E0D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6E0C80", Offset = "0x6DF280", VA = "0x1806E0C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsLeaf
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6E0C00", Offset = "0x6DF200", VA = "0x1806E0C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public UniqueTreeNode<T> Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6E0CB0", Offset = "0x6DF2B0", VA = "0x1806E0CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AD0", Offset = "0x6DF0D0", VA = "0x1806E0AD0")]
		public UniqueTreeNode(T nodeContent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6DE7C0", Offset = "0x6DCDC0", VA = "0x1806DE7C0")]
		public UniqueTreeNode<T> AddChild(T newNodeContent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6DF240", Offset = "0x6DD840", VA = "0x1806DF240")]
		public UniqueTreeNode<T> RemoveDescendant(T nodeContentToRemove)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF5E0", Offset = "0x6DDBE0", VA = "0x1806DF5E0")]
		public UniqueTreeNode<T> Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB80", Offset = "0x6DD180", VA = "0x1806DEB80")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF720", Offset = "0x6DDD20", VA = "0x1806DF720")]
		public UniqueTreeNode<T> Reparent(T newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E03F0", Offset = "0x6DE9F0", VA = "0x1806E03F0")]
		public static void TraverseTree(UniqueTreeNode<T> traversalRoot, TreeTraversalOperation operation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x18065E0", Offset = "0x1804BE0", VA = "0x1818065E0")]
		public static void TraverseTree<A>(UniqueTreeNode<T> traversalRoot, Func<UniqueTreeNode<T>, A, bool> operation, A arg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6DF900", Offset = "0x6DDF00", VA = "0x1806DF900")]
		public static string ToString(UniqueTreeNode<T> traversalRoot, int depth = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE20", Offset = "0x6DD420", VA = "0x1806DEE20")]
		public static UniqueTreeNode<T> FindNode(UniqueTreeNode<T> traversalRoot, T nodeContentToFind)
		{
			return null;
		}
	}
}
namespace RecRoom.DataStructures.ResourceHandles
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class EmptyResourceHandle : EmptyResourceHandle<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xFE5D90", Offset = "0xFE4390", VA = "0x180FE5D90")]
		public EmptyResourceHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class EmptyResourceHandle<T> : IResourceHandle<T>, IResourceHandle, IDisposable where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Task<T> ResourceTask
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		IPromise IResourceHandle.ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x671030", Offset = "0x66F630", VA = "0x180671030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x18418F0", Offset = "0x183FEF0", VA = "0x1818418F0")]
		public EmptyResourceHandle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "7")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ExceptionResourceHandle<T> : IResourceHandle<T>, IResourceHandle, IDisposable where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Task<T> ResourceTask
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		IPromise IResourceHandle.ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x671030", Offset = "0x66F630", VA = "0x180671030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x18419D0", Offset = "0x183FFD0", VA = "0x1818419D0")]
		public ExceptionResourceHandle(Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x32DB10", Offset = "0x32C110", VA = "0x18032DB10", Slot = "7")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface IResourceHandle : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		[NotNull]
		IPromise ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface IResourceHandle<T> : IResourceHandle, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		[NotNull]
		Task<T> ResourceTask
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		[NotNull]
		new IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class ResourceHandleBase<TTask, T> : IResourceHandle<T>, IResourceHandle, IDisposable where TTask : Task
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static bool isQuitting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Promise<T> resourcePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected readonly CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private SynchronizationContext synchronizationContext;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Task<T> ResourceTask
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		IPromise IResourceHandle.ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x374310", Offset = "0x372910", VA = "0x180374310", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x184C5E0", Offset = "0x184ABE0", VA = "0x18184C5E0")]
		static ResourceHandleBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x184C750", Offset = "0x184AD50", VA = "0x18184C750")]
		protected ResourceHandleBase(TTask task)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x184C290", Offset = "0x184A890", VA = "0x18184C290", Slot = "1")]
		~ResourceHandleBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x184C0F0", Offset = "0x184A6F0", VA = "0x18184C0F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x184C120", Offset = "0x184A720", VA = "0x18184C120")]
		private void Dispose(bool isDestructor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract T TransformTaskResult(TTask originalTask);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void ReleaseResource();

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x184BEF0", Offset = "0x184A4F0", VA = "0x18184BEF0")]
		protected void CompleteHandleSuccess(T payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x184BDF0", Offset = "0x184A3F0", VA = "0x18184BDF0")]
		protected void CompleteHandleError(string error)
		{
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class IndexedMap<T> : IEnumerable<IndexedMap<T>.Pair>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public struct Pair
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public T value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int index;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public class Enumerator : IEnumerator<Pair>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private IndexedMap<T> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x8A5650", Offset = "0x8A3C50", VA = "0x1808A5650", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x8A56F0", Offset = "0x8A3CF0", VA = "0x1808A56F0", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8A56C0", Offset = "0x8A3CC0", VA = "0x1808A56C0")]
			public Enumerator(IndexedMap<T> map)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8A55C0", Offset = "0x8A3BC0", VA = "0x1808A55C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x793390", Offset = "0x791990", VA = "0x180793390", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x82F210", Offset = "0x82D810", VA = "0x18082F210", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct ListEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public bool hasValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public T value;
		}

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private const int DEFAULT_CAPACITY = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Dictionary<T, int> valueToIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private ListEntry[] indexToValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int firstEmptyIndex;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8AC480", Offset = "0x8AAA80", VA = "0x1808AC480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB90", Offset = "0x8AA190", VA = "0x1808ABB90")]
		public static IndexedMap<T> FromArray(Pair[] pairs, bool expand)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AC3C0", Offset = "0x8AA9C0", VA = "0x1808AC3C0")]
		public IndexedMap(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8ABF60", Offset = "0x8AA560", VA = "0x1808ABF60")]
		public int GetIndex(T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8ABFB0", Offset = "0x8AA5B0", VA = "0x1808ABFB0")]
		public T GetValue(int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1D0", Offset = "0x8AA7D0", VA = "0x1808AC1D0")]
		public bool TryAdd(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AC1F0", Offset = "0x8AA7F0", VA = "0x1808AC1F0")]
		public bool TryAdd(T value, int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AC090", Offset = "0x8AA690", VA = "0x1808AC090")]
		public Pair[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8ABB30", Offset = "0x8AA130", VA = "0x1808ABB30")]
		private int FindNextEmptyIndex(int startIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AC020", Offset = "0x8AA620", VA = "0x1808AC020", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8AC020", Offset = "0x8AA620", VA = "0x1808AC020", Slot = "4")]
		private IEnumerator<Pair> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class PriorityMap<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Dictionary<int, T> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x32A400", Offset = "0x328A00", VA = "0x18032A400", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3C0B60", Offset = "0x3BF160", VA = "0x1803C0B60", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4B0", Offset = "0x8AAAB0", VA = "0x1808AC4B0")]
		public bool AddValue(T value, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EE0", Offset = "0x8A44E0", VA = "0x1808A5EE0")]
		public bool RemoveValue(int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8AC510", Offset = "0x8AAB10", VA = "0x1808AC510")]
		public T GetPriorityValue(int maxPriority)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8AC7A0", Offset = "0x8AADA0", VA = "0x1808AC7A0")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8AC830", Offset = "0x8AAE30", VA = "0x1808AC830")]
		public PriorityMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class TokenLockMap<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly Dictionary<T, object> itemLockMap;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCE0", Offset = "0x8AE2E0", VA = "0x1808AFCE0")]
		public bool IsLocked(T itemId, object token, out object lockingToken)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC70", Offset = "0x8AE270", VA = "0x1808AFC70")]
		public bool CanAcquireLock(T itemId, object token, out object lockingToken)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCB0", Offset = "0x8AE2B0", VA = "0x1808AFCB0")]
		public void ForceAcquireLock(T itemId, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8AFDE0", Offset = "0x8AE3E0", VA = "0x1808AFDE0")]
		public void ReleaseLock(T itemId, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE70", Offset = "0x8AE470", VA = "0x1808AFE70")]
		public TokenLockMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class WalkableStack<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private int nextIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private List<T> elements;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public T Next
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8B2810", Offset = "0x8B0E10", VA = "0x1808B2810")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public T Head
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8B27D0", Offset = "0x8B0DD0", VA = "0x1808B27D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B2740", Offset = "0x8B0D40", VA = "0x1808B2740")]
		public WalkableStack(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B2560", Offset = "0x8B0B60", VA = "0x1808B2560")]
		public void Add(T command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B26A0", Offset = "0x8B0CA0", VA = "0x1808B26A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B26F0", Offset = "0x8B0CF0", VA = "0x1808B26F0")]
		public void WalkForward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B26E0", Offset = "0x8B0CE0", VA = "0x1808B26E0")]
		public void WalkBack()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class ExplicitTokenMap<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct PrioritizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public int Priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Dictionary<object, PrioritizedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA30", Offset = "0x8AA030", VA = "0x1808ABA30", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8ABAA0", Offset = "0x8AA0A0", VA = "0x1808ABAA0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public object HighestPriorityToken
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x32A410", Offset = "0x328A10", VA = "0x18032A410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x33A9A0", Offset = "0x338FA0", VA = "0x18033A9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8AB9A0", Offset = "0x8A9FA0", VA = "0x1808AB9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A59F0", Offset = "0x8A3FF0", VA = "0x1808A59F0")]
		public bool AddValue(T value, object token, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A5EE0", Offset = "0x8A44E0", VA = "0x1808A5EE0")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A6030", Offset = "0x8A4630", VA = "0x1808A6030")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8AA500", Offset = "0x8A8B00", VA = "0x1808AA500")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8AB920", Offset = "0x8A9F20", VA = "0x1808AB920")]
		public ExplicitTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class MultiplicativeTokenMap
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Dictionary<object, float> dictionary;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Product
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x50BA90", Offset = "0x50A090", VA = "0x18050BA90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x50BAE0", Offset = "0x50A0E0", VA = "0x18050BAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xFE6540", Offset = "0xFE4B40", VA = "0x180FE6540")]
		public void AddValue(float value, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xFE65B0", Offset = "0xFE4BB0", VA = "0x180FE65B0")]
		public void RemoveValue(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xFE6610", Offset = "0xFE4C10", VA = "0x180FE6610")]
		private void UpdateProduct()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xFE6740", Offset = "0xFE4D40", VA = "0x180FE6740")]
		public MultiplicativeTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class TokenFlag
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly List<object> tokens;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HasTokens
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xFE6D00", Offset = "0xFE5300", VA = "0x180FE6D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xFE6A30", Offset = "0xFE5030", VA = "0x180FE6A30")]
		public void Add(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xFE6AB0", Offset = "0xFE50B0", VA = "0x180FE6AB0")]
		public void Remove(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xFE6B10", Offset = "0xFE5110", VA = "0x180FE6B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xFE6CA0", Offset = "0xFE52A0", VA = "0x180FE6CA0")]
		public TokenFlag()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class TokenMap<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private Dictionary<object, TimestampedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T _latestValue;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public virtual T LatestValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8ABA80", Offset = "0x8AA080", VA = "0x1808ABA80", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8ABAF0", Offset = "0x8AA0F0", VA = "0x1808ABAF0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public object LatestToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x32DC80", Offset = "0x32C280", VA = "0x18032DC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x3CB890", Offset = "0x3C9E90", VA = "0x1803CB890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8B2400", Offset = "0x8B0A00", VA = "0x1808B2400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8B02C0", Offset = "0x8AE8C0", VA = "0x1808B02C0")]
		public bool AddValue(T value, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8B0580", Offset = "0x8AEB80", VA = "0x1808B0580")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8B0710", Offset = "0x8AED10", VA = "0x1808B0710")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F50", Offset = "0x8B0550", VA = "0x1808B1F50")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2380", Offset = "0x8B0980", VA = "0x1808B2380")]
		public TokenMap()
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
