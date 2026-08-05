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
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x345DF0", Offset = "0x3451F0", VA = "0x180345DF0")]
		[DebuggerHidden]
		public <Start>d__10(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2513720", Offset = "0x2512B20", VA = "0x182513720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2514110", Offset = "0x2513510", VA = "0x182514110", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x345DF0", Offset = "0x3451F0", VA = "0x180345DF0")]
		[DebuggerHidden]
		public <MergeRoots>d__12(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2512930", Offset = "0x2511D30", VA = "0x182512930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x25136D0", Offset = "0x2512AD0", VA = "0x1825136D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x25118E0", Offset = "0x2510CE0", VA = "0x1825118E0")]
	public static void AddExistingSingleton(IGameSingleton s)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2511960", Offset = "0x2510D60", VA = "0x182511960", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2511A40", Offset = "0x2510E40", VA = "0x182511A40", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2511AC0", Offset = "0x2510EC0", VA = "0x182511AC0")]
	[IteratorStateMachine(typeof(<Start>d__10))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "6")]
	protected virtual void OnInitializationComplete()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25119E0", Offset = "0x2510DE0", VA = "0x1825119E0")]
	[IteratorStateMachine(typeof(<MergeRoots>d__12))]
	public static IEnumerator MergeRoots(List<GameRoot> gameRoots)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x311310", Offset = "0x310710", VA = "0x180311310")]
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
		[Cpp2IlInjected.Address(RVA = "0x47EFD0", Offset = "0x47E3D0", VA = "0x18047EFD0", Slot = "4")]
		get
		{
			return default(GameRestartBehaviors);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GameObject GameObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF60", Offset = "0x7BA360", VA = "0x1807BAF60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2511BD0", Offset = "0x2510FD0", VA = "0x182511BD0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2511E60", Offset = "0x2511260", VA = "0x182511E60")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2511F80", Offset = "0x2511380", VA = "0x182511F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x18869C0", Offset = "0x1885DC0", VA = "0x1818869C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1886C20", Offset = "0x1886020", VA = "0x181886C20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static bool IsInitialized
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1886AC0", Offset = "0x1885EC0", VA = "0x181886AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x18864F0", Offset = "0x18858F0", VA = "0x1818864F0", Slot = "7")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1886790", Offset = "0x1885B90", VA = "0x181886790", Slot = "8")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x18869A0", Offset = "0x1885DA0", VA = "0x1818869A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x50B950", Offset = "0x50AD50", VA = "0x18050B950", Slot = "6")]
		get
		{
			return default(GameRestartBehaviors);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject GameObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF60", Offset = "0x7BA360", VA = "0x1807BAF60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xC73020", Offset = "0xC72420", VA = "0x180C73020")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B6E880", Offset = "0x1B6DC80", VA = "0x181B6E880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B6E750", Offset = "0x1B6DB50", VA = "0x181B6E750")]
	public TimeSeriesRollingWindow(float sampleInterval, float windowLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B6E490", Offset = "0x1B6D890", VA = "0x181B6E490")]
	public bool TryToAddSample(float time, T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1B6DD30", Offset = "0x1B6D130", VA = "0x181B6DD30")]
	public IEnumerable<T> GetSamples(float time, [Optional] float? minTime)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1B6DD00", Offset = "0x1B6D100", VA = "0x181B6DD00")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1B6E3D0", Offset = "0x1B6D7D0", VA = "0x181B6E3D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x349360", Offset = "0x348760", VA = "0x180349360")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x349490", Offset = "0x348890", VA = "0x180349490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F890", Offset = "0x1B6EC90", VA = "0x181B6F890")]
	public TimestampedRollingBuffer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F7C0", Offset = "0x1B6EBC0", VA = "0x181B6F7C0")]
	public TimestampedRollingBuffer(int size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1B6E900", Offset = "0x1B6DD00", VA = "0x181B6E900")]
	public void Add(float time, T value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B6EAB0", Offset = "0x1B6DEB0", VA = "0x181B6EAB0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F2B0", Offset = "0x1B6E6B0", VA = "0x181B6F2B0")]
	public bool TryGetAverageValueOverTime(float startTime, float endTime, out T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F620", Offset = "0x1B6EA20", VA = "0x181B6F620")]
	public bool TryGetMaximumValueOverTime(float startTime, float endTime, out T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1B6EEC0", Offset = "0x1B6E2C0", VA = "0x181B6EEC0")]
	public void GetValuesInTimeWindow(float startTime, float endTime, List<T> buffer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F050", Offset = "0x1B6E450", VA = "0x181B6F050")]
	private int RollingHeadOffset(int headOffset)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F010", Offset = "0x1B6E410", VA = "0x181B6F010")]
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
	[Cpp2IlInjected.Address(RVA = "0x25123B0", Offset = "0x25117B0", VA = "0x1825123B0", Slot = "4")]
	protected override Vector3 ZeroValue()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2512260", Offset = "0x2511660", VA = "0x182512260", Slot = "5")]
	protected override Vector3 Scale(Vector3 value, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2512300", Offset = "0x2511700", VA = "0x182512300", Slot = "6")]
	protected override Vector3 Sum(Vector3 lhs, Vector3 rhs)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x25121F0", Offset = "0x25115F0", VA = "0x1825121F0", Slot = "7")]
	protected override Vector3 Max(Vector3 lhs, Vector3 rhs)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2512420", Offset = "0x2511820", VA = "0x182512420")]
	public TimestampedRollingBufferVector3()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xEBA620", Offset = "0xEB9A20", VA = "0x180EBA620")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x145AF10", Offset = "0x145A310", VA = "0x18145AF10")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x17BC100", Offset = "0x17BB500", VA = "0x1817BC100")]
	internal static int CombineHashCodes(int h1, int h2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x219AC90", Offset = "0x219A090", VA = "0x18219AC90")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B702D0", Offset = "0x1B6F6D0", VA = "0x181B702D0")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1B6F8C0", Offset = "0x1B6ECC0", VA = "0x181B6F8C0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1B6FB00", Offset = "0x1B6EF00", VA = "0x181B6FB00", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1B6FE00", Offset = "0x1B6F200", VA = "0x181B6FE00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1B70170", Offset = "0x1B6F570", VA = "0x181B70170", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B70B00", Offset = "0x1B6FF00", VA = "0x181B70B00")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1B70420", Offset = "0x1B6F820", VA = "0x181B70420", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1B70520", Offset = "0x1B6F920", VA = "0x181B70520", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1B70780", Offset = "0x1B6FB80", VA = "0x181B70780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1B70880", Offset = "0x1B6FC80", VA = "0x181B70880", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x3457B0", Offset = "0x344BB0", VA = "0x1803457B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x34D880", Offset = "0x34CC80", VA = "0x18034D880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float Duration
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x344210", Offset = "0x343610", VA = "0x180344210")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2527C30", Offset = "0x2527030", VA = "0x182527C30")]
	public T Evaluate(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2527900", Offset = "0x2526D00", VA = "0x182527900")]
	public T EvaluateNonNormalized(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T Interpolate(T lhs, T rhs, float t);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xD7ABB0", Offset = "0xD79FB0", VA = "0x180D7ABB0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2511820", Offset = "0x2510C20", VA = "0x182511820", Slot = "4")]
	protected override float Interpolate(float lhs, float rhs, float t)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x2510CA0", VA = "0x1825118A0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2514160", Offset = "0x2513560", VA = "0x182514160", Slot = "4")]
	protected override Vector3 Interpolate(Vector3 lhs, Vector3 rhs, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2514220", Offset = "0x2513620", VA = "0x182514220")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2511750", Offset = "0x2510B50", VA = "0x182511750", Slot = "4")]
	protected override Color Interpolate(Color lhs, Color rhs, float t)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x25117A0", Offset = "0x2510BA0", VA = "0x1825117A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x112A00", Offset = "0x111E00", VA = "0x180112A00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public T Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x1129F0", Offset = "0x111DF0", VA = "0x1801129F0")]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x194090", Offset = "0x193490", VA = "0x180194090")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x193FD0", Offset = "0x1933D0", VA = "0x180193FD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x1257B0", Offset = "0x124BB0", VA = "0x1801257B0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x193B50", Offset = "0x192F50", VA = "0x180193B50", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x193F20", Offset = "0x193320", VA = "0x180193F20")]
			public Enumerator(CircularBuffer<T> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x10B190", Offset = "0x10A590", VA = "0x18010B190", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x193640", Offset = "0x192A40", VA = "0x180193640", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x193950", Offset = "0x192D50", VA = "0x180193950", Slot = "8")]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1933C0", Offset = "0x1927C0", VA = "0x1801933C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1000E80", Offset = "0x1000280", VA = "0x181000E80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1000F40", Offset = "0x1000340", VA = "0x181000F40")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1001040", Offset = "0x1000440", VA = "0x181001040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1000DF0", Offset = "0x10001F0", VA = "0x181000DF0")]
		public CircularBuffer(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xFFFFA0", Offset = "0xFFF3A0", VA = "0x180FFFFA0")]
		public void Add(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x10001F0", Offset = "0xFFF5F0", VA = "0x1810001F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1000BD0", Offset = "0xFFFFD0", VA = "0x181000BD0")]
		public void RemoveFromFront(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10004B0", Offset = "0xFFF8B0", VA = "0x1810004B0")]
		public void CopyTo(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1000B90", Offset = "0xFFFF90", VA = "0x181000B90")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1000CF0", Offset = "0x10000F0", VA = "0x181000CF0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1000CF0", Offset = "0x10000F0", VA = "0x181000CF0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1000840", Offset = "0xFFFC40", VA = "0x181000840")]
		private int ExternalToInternalIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x10001C0", Offset = "0xFFF5C0", VA = "0x1810001C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3107E0", Offset = "0x30FBE0", VA = "0x1803107E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD96610", Offset = "0xD95A10", VA = "0x180D96610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xD96520", Offset = "0xD95920", VA = "0x180D96520")]
		public ListEvent(int capacity, bool useTryCatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xD96230", Offset = "0xD95630", VA = "0x180D96230")]
		protected void ProcessQueuedModifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xD960F0", Offset = "0xD954F0", VA = "0x180D960F0")]
		public void Add(T action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xD963E0", Offset = "0xD957E0", VA = "0x180D963E0")]
		public void Remove(T action)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class ActionEvent : ListEvent<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2511630", Offset = "0x2510A30", VA = "0x182511630")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x25113E0", Offset = "0x25107E0", VA = "0x1825113E0")]
		public void Invoke(bool clearAfterInvoke = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2511350", Offset = "0x2510750", VA = "0x182511350", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2511690", Offset = "0x2510A90", VA = "0x182511690")]
		public static ActionEvent operator +(ActionEvent actionEvent, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x25116F0", Offset = "0x2510AF0", VA = "0x1825116F0")]
		public static ActionEvent operator -(ActionEvent actionEvent, Action action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class ActionEvent<T> : ListEvent<Action<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x19157A0", Offset = "0x1914BA0", VA = "0x1819157A0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1915220", Offset = "0x1914620", VA = "0x181915220")]
		public void Invoke(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x19144C0", Offset = "0x19138C0", VA = "0x1819144C0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x19157D0", Offset = "0x1914BD0", VA = "0x1819157D0")]
		public static ActionEvent<T> operator +(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1915870", Offset = "0x1914C70", VA = "0x181915870")]
		public static ActionEvent<T> operator -(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class ActionEvent<T, U> : ListEvent<Action<T, U>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x19157A0", Offset = "0x1914BA0", VA = "0x1819157A0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1915FA0", Offset = "0x19153A0", VA = "0x181915FA0")]
		public void Invoke(T t, U u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1915E00", Offset = "0x1915200", VA = "0x181915E00", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1915870", Offset = "0x1914C70", VA = "0x181915870")]
		public static ActionEvent<T, U> operator +(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1916AA0", Offset = "0x1915EA0", VA = "0x181916AA0")]
		public static ActionEvent<T, U> operator -(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class ActionEvent<T, U, V> : ListEvent<Action<T, U, V>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x19157A0", Offset = "0x1914BA0", VA = "0x1819157A0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1916D50", Offset = "0x1916150", VA = "0x181916D50")]
		public void Invoke(T t, U u, V v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1916B40", Offset = "0x1915F40", VA = "0x181916B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x374030", Offset = "0x373430", VA = "0x180374030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x110F4C0", Offset = "0x110E8C0", VA = "0x18110F4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x110F400", Offset = "0x110E800", VA = "0x18110F400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsLeaf
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x110F380", Offset = "0x110E780", VA = "0x18110F380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public UniqueTreeNode<T> Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x110F430", Offset = "0x110E830", VA = "0x18110F430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x110F250", Offset = "0x110E650", VA = "0x18110F250")]
		public UniqueTreeNode(T nodeContent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x110CF40", Offset = "0x110C340", VA = "0x18110CF40")]
		public UniqueTreeNode<T> AddChild(T newNodeContent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x110D9C0", Offset = "0x110CDC0", VA = "0x18110D9C0")]
		public UniqueTreeNode<T> RemoveDescendant(T nodeContentToRemove)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x110DD60", Offset = "0x110D160", VA = "0x18110DD60")]
		public UniqueTreeNode<T> Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x110D300", Offset = "0x110C700", VA = "0x18110D300")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x110DEA0", Offset = "0x110D2A0", VA = "0x18110DEA0")]
		public UniqueTreeNode<T> Reparent(T newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x110EB70", Offset = "0x110DF70", VA = "0x18110EB70")]
		public static void TraverseTree(UniqueTreeNode<T> traversalRoot, TreeTraversalOperation operation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xBB7F80", Offset = "0xBB7380", VA = "0x180BB7F80")]
		public static void TraverseTree<A>(UniqueTreeNode<T> traversalRoot, Func<UniqueTreeNode<T>, A, bool> operation, A arg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x110E080", Offset = "0x110D480", VA = "0x18110E080")]
		public static string ToString(UniqueTreeNode<T> traversalRoot, int depth = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x110D5A0", Offset = "0x110C9A0", VA = "0x18110D5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x25117E0", Offset = "0x2510BE0", VA = "0x1825117E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3108E0", Offset = "0x30FCE0", VA = "0x1803108E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD935B0", Offset = "0xD929B0", VA = "0x180D935B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xD94F10", Offset = "0xD94310", VA = "0x180D94F10")]
		public EmptyResourceHandle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3108E0", Offset = "0x30FCE0", VA = "0x1803108E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD935B0", Offset = "0xD929B0", VA = "0x180D935B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xD94FF0", Offset = "0xD943F0", VA = "0x180D94FF0")]
		public ExceptionResourceHandle(Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x311320", Offset = "0x310720", VA = "0x180311320", Slot = "7")]
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
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Promise<T> resourcePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected readonly CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private SynchronizationContext synchronizationContext;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Task<T> ResourceTask
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x3108E0", Offset = "0x30FCE0", VA = "0x1803108E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		IPromise IResourceHandle.ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3108E0", Offset = "0x30FCE0", VA = "0x1803108E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xD9E900", Offset = "0xD9DD00", VA = "0x180D9E900")]
		protected ResourceHandleBase(TTask task)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD9E720", Offset = "0xD9DB20", VA = "0x180D9E720", Slot = "1")]
		~ResourceHandleBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD9E620", Offset = "0xD9DA20", VA = "0x180D9E620", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xD9E650", Offset = "0xD9DA50", VA = "0x180D9E650")]
		private void Dispose(bool isDestructor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract T TransformTaskResult(TTask originalTask);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void ReleaseResource();

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xD9E4C0", Offset = "0xD9D8C0", VA = "0x180D9E4C0")]
		protected void CompleteHandleSuccess(T payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xD9E3C0", Offset = "0xD9D7C0", VA = "0x180D9E3C0")]
		protected void CompleteHandleError(string error)
		{
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class IndexedMap<T> : IEnumerable<IndexedMap<T>.Pair>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public struct Pair
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public T value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int index;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public class Enumerator : IEnumerator<Pair>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private IndexedMap<T> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0xD6EEF0", Offset = "0xD6E2F0", VA = "0x180D6EEF0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0xD6EF90", Offset = "0xD6E390", VA = "0x180D6EF90", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xD6EF60", Offset = "0xD6E360", VA = "0x180D6EF60")]
			public Enumerator(IndexedMap<T> map)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xD6EE50", Offset = "0xD6E250", VA = "0x180D6EE50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xD6EEE0", Offset = "0xD6E2E0", VA = "0x180D6EEE0", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xD6EE40", Offset = "0xD6E240", VA = "0x180D6EE40", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private struct ListEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public bool hasValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public T value;
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private const int DEFAULT_CAPACITY = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Dictionary<T, int> valueToIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private ListEntry[] indexToValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int firstEmptyIndex;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xE31880", Offset = "0xE30C80", VA = "0x180E31880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x12DC2F0", Offset = "0x12DB6F0", VA = "0x1812DC2F0")]
		public static IndexedMap<T> FromArray(Pair[] pairs, bool expand)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x12DCB20", Offset = "0x12DBF20", VA = "0x1812DCB20")]
		public IndexedMap(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x12DC6C0", Offset = "0x12DBAC0", VA = "0x1812DC6C0")]
		public int GetIndex(T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x12DC710", Offset = "0x12DBB10", VA = "0x1812DC710")]
		public T GetValue(int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x12DC930", Offset = "0x12DBD30", VA = "0x1812DC930")]
		public bool TryAdd(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x12DC950", Offset = "0x12DBD50", VA = "0x1812DC950")]
		public bool TryAdd(T value, int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x12DC7F0", Offset = "0x12DBBF0", VA = "0x1812DC7F0")]
		public Pair[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x12DC290", Offset = "0x12DB690", VA = "0x1812DC290")]
		private int FindNextEmptyIndex(int startIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x12DC780", Offset = "0x12DBB80", VA = "0x1812DC780", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x12DC780", Offset = "0x12DBB80", VA = "0x1812DC780", Slot = "4")]
		private IEnumerator<Pair> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class PriorityMap<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Dictionary<int, T> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x3108F0", Offset = "0x30FCF0", VA = "0x1803108F0", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x3109E0", Offset = "0x30FDE0", VA = "0x1803109E0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x12DCBE0", Offset = "0x12DBFE0", VA = "0x1812DCBE0")]
		public bool AddValue(T value, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x12D6730", Offset = "0x12D5B30", VA = "0x1812D6730")]
		public bool RemoveValue(int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x12DCC40", Offset = "0x12DC040", VA = "0x1812DCC40")]
		public T GetPriorityValue(int maxPriority)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x12DCED0", Offset = "0x12DC2D0", VA = "0x1812DCED0")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x12DCF60", Offset = "0x12DC360", VA = "0x1812DCF60")]
		public PriorityMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class TokenLockMap<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly Dictionary<T, object> itemLockMap;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x12E1440", Offset = "0x12E0840", VA = "0x1812E1440")]
		public bool IsLocked(T itemId, object token, out object lockingToken)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x12E1670", Offset = "0x12E0A70", VA = "0x1812E1670")]
		public bool TryAcquireLock(T itemId, object token, out object lockingToken)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x12E1410", Offset = "0x12E0810", VA = "0x1812E1410")]
		public void ForceAcquireLock(T itemId, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x12E1540", Offset = "0x12E0940", VA = "0x1812E1540")]
		public void ReleaseLock(T itemId, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x12E1700", Offset = "0x12E0B00", VA = "0x1812E1700")]
		public TokenLockMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class WalkableStack<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int nextIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private List<T> elements;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public T Next
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x12E4570", Offset = "0x12E3970", VA = "0x1812E4570")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public T Head
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x12E4530", Offset = "0x12E3930", VA = "0x1812E4530")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x12E44A0", Offset = "0x12E38A0", VA = "0x1812E44A0")]
		public WalkableStack(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x12E42C0", Offset = "0x12E36C0", VA = "0x1812E42C0")]
		public void Add(T command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x12E4400", Offset = "0x12E3800", VA = "0x1812E4400")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x12E4450", Offset = "0x12E3850", VA = "0x1812E4450")]
		public void WalkForward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x12E4440", Offset = "0x12E3840", VA = "0x1812E4440")]
		public void WalkBack()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ExplicitTokenMap<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct PrioritizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public int Priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private Dictionary<object, PrioritizedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x837FB0", Offset = "0x8373B0", VA = "0x180837FB0", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x837FD0", Offset = "0x8373D0", VA = "0x180837FD0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public object HighestPriorityToken
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3220C0", Offset = "0x3214C0", VA = "0x1803220C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x344320", Offset = "0x343720", VA = "0x180344320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x12DC160", Offset = "0x12DB560", VA = "0x1812DC160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x12D6210", Offset = "0x12D5610", VA = "0x1812D6210")]
		public bool AddValue(T value, object token, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x12D6730", Offset = "0x12D5B30", VA = "0x1812D6730")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x12D6880", Offset = "0x12D5C80", VA = "0x1812D6880")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x12DACC0", Offset = "0x12DA0C0", VA = "0x1812DACC0")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x12DC0E0", Offset = "0x12DB4E0", VA = "0x1812DC0E0")]
		public ExplicitTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class MultiplicativeTokenMap
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Dictionary<object, float> dictionary;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float Product
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x349380", Offset = "0x348780", VA = "0x180349380")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x3494B0", Offset = "0x3488B0", VA = "0x1803494B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2511F90", Offset = "0x2511390", VA = "0x182511F90")]
		public void AddValue(float value, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2512000", Offset = "0x2511400", VA = "0x182512000")]
		public void RemoveValue(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2512060", Offset = "0x2511460", VA = "0x182512060")]
		private void UpdateProduct()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2512190", Offset = "0x2511590", VA = "0x182512190")]
		public MultiplicativeTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class TokenFlag
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private List<object> tokens;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HasTokens
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x25128E0", Offset = "0x2511CE0", VA = "0x1825128E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2512480", Offset = "0x2511880", VA = "0x182512480")]
		public void Add(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2512500", Offset = "0x2511900", VA = "0x182512500")]
		public void Remove(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2512560", Offset = "0x2511960", VA = "0x182512560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2512880", Offset = "0x2511C80", VA = "0x182512880")]
		public TokenFlag()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class TokenMap<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Dictionary<object, TimestampedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private T _latestValue;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public virtual T LatestValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x12DC1F0", Offset = "0x12DB5F0", VA = "0x1812DC1F0", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x12DC250", Offset = "0x12DB650", VA = "0x1812DC250", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public object LatestToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x3457B0", Offset = "0x344BB0", VA = "0x1803457B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x34D880", Offset = "0x34CC80", VA = "0x18034D880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x12E4160", Offset = "0x12E3560", VA = "0x1812E4160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x12E1C20", Offset = "0x12E1020", VA = "0x1812E1C20")]
		public bool AddValue(T value, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x12E1EE0", Offset = "0x12E12E0", VA = "0x1812E1EE0")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x12E20D0", Offset = "0x12E14D0", VA = "0x1812E20D0")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x12E3CB0", Offset = "0x12E30B0", VA = "0x1812E3CB0")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x12E40E0", Offset = "0x12E34E0", VA = "0x1812E40E0")]
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
