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
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class <Start>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public GameRoot <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x339BC0", Offset = "0x338DC0", VA = "0x180339BC0")]
		[DebuggerHidden]
		public <Start>d__6(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24218F0", Offset = "0x2420AF0", VA = "0x1824218F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2421970", Offset = "0x2420B70", VA = "0x182421970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private GameObject StartupObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private Transform coreSystems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private Transform UI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static HashSet<GameObject> dontDestoyOnLoadGameObjects;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2420CE0", Offset = "0x241FEE0", VA = "0x182420CE0")]
	public static void RegisterDontDestroyOnLoad(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2420AF0", Offset = "0x241FCF0", VA = "0x182420AF0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2420D80", Offset = "0x241FF80", VA = "0x182420D80")]
	[IteratorStateMachine(typeof(<Start>d__6))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "6")]
	protected virtual void OnInitializationComplete()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2420E40", Offset = "0x2420040", VA = "0x182420E40")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GameObject GameObject
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4D20", Offset = "0x7B3F20", VA = "0x1807B4D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2420EA0", Offset = "0x24200A0", VA = "0x182420EA0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2421000", Offset = "0x2420200", VA = "0x182421000")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x313000", Offset = "0x312200", VA = "0x180313000")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static T instance;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1E15CE0", Offset = "0x1E14EE0", VA = "0x181E15CE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1E15F40", Offset = "0x1E15140", VA = "0x181E15F40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool IsInitialized
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E15DE0", Offset = "0x1E14FE0", VA = "0x181E15DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E15830", Offset = "0x1E14A30", VA = "0x181E15830", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E15B20", Offset = "0x1E14D20", VA = "0x181E15B20", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD59520", Offset = "0xD58720", VA = "0x180D59520")]
	public SingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class TimeSeriesRollingWindow<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly float SampleInterval;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly float WindowLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private List<Tuple<float, T>> samples;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MaxSampleCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1685520", Offset = "0x1684720", VA = "0x181685520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x16853F0", Offset = "0x16845F0", VA = "0x1816853F0")]
	public TimeSeriesRollingWindow(float sampleInterval, float windowLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1685130", Offset = "0x1684330", VA = "0x181685130")]
	public bool TryToAddSample(float time, T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x16849D0", Offset = "0x1683BD0", VA = "0x1816849D0")]
	public IEnumerable<T> GetSamples(float time, [Optional] float? minTime)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x16849A0", Offset = "0x1683BA0", VA = "0x1816849A0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1685070", Offset = "0x1684270", VA = "0x181685070")]
	private void RemoveOldSamples(float time)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class TimestampedRollingBuffer<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct BufferEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float Timestamp;
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static float InvalidTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<T> scratchBuffer;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const int MAX_SIZE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private BufferEntry[] array;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int head;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float LatestTime
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x564BB0", Offset = "0x563DB0", VA = "0x180564BB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x75CEA0", Offset = "0x75C0A0", VA = "0x18075CEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1686530", Offset = "0x1685730", VA = "0x181686530")]
	public TimestampedRollingBuffer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1686460", Offset = "0x1685660", VA = "0x181686460")]
	public TimestampedRollingBuffer(int size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x16855A0", Offset = "0x16847A0", VA = "0x1816855A0")]
	public void Add(float time, T value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1685750", Offset = "0x1684950", VA = "0x181685750")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1685F50", Offset = "0x1685150", VA = "0x181685F50")]
	public bool TryGetAverageValueOverTime(float startTime, float endTime, out T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x16862C0", Offset = "0x16854C0", VA = "0x1816862C0")]
	public bool TryGetMaximumValueOverTime(float startTime, float endTime, out T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1685B60", Offset = "0x1684D60", VA = "0x181685B60")]
	public void GetValuesInTimeWindow(float startTime, float endTime, List<T> buffer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1685CF0", Offset = "0x1684EF0", VA = "0x181685CF0")]
	private int RollingHeadOffset(int headOffset)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1685CB0", Offset = "0x1684EB0", VA = "0x181685CB0")]
	private void IncrementHead()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ZeroValue();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T Scale(T value, float t);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T Sum(T lhs, T rhs);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T Max(T lhs, T rhs);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class TimestampedRollingBufferVector3 : TimestampedRollingBuffer<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2421500", Offset = "0x2420700", VA = "0x182421500", Slot = "4")]
	protected override Vector3 ZeroValue()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x24213B0", Offset = "0x24205B0", VA = "0x1824213B0", Slot = "5")]
	protected override Vector3 Scale(Vector3 value, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2421450", Offset = "0x2420650", VA = "0x182421450", Slot = "6")]
	protected override Vector3 Sum(Vector3 lhs, Vector3 rhs)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2421340", Offset = "0x2420540", VA = "0x182421340", Slot = "7")]
	protected override Vector3 Max(Vector3 lhs, Vector3 rhs)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2421570", Offset = "0x2420770", VA = "0x182421570")]
	public TimestampedRollingBufferVector3()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xE58370", Offset = "0xE57570", VA = "0x180E58370")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1BEA980", Offset = "0x1BE9B80", VA = "0x181BEA980")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x178A040", Offset = "0x1789240", VA = "0x18178A040")]
	internal static int CombineHashCodes(int h1, int h2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x20797E0", Offset = "0x20789E0", VA = "0x1820797E0")]
	internal static int CombineHashCodes(int h1, int h2, int h3)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class Tuple<T1, T2> : IComparable<Tuple<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly T2 Item2;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xDF2890", Offset = "0xDF1A90", VA = "0x180DF2890")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1686560", Offset = "0x1685760", VA = "0x181686560", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1686BE0", Offset = "0x1685DE0", VA = "0x181686BE0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1686EC0", Offset = "0x16860C0", VA = "0x181686EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x16885F0", Offset = "0x16877F0", VA = "0x1816885F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class Tuple<T1, T2, T3> : IComparable<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T2 Item2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly T3 Item3;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x16896D0", Offset = "0x16888D0", VA = "0x1816896D0")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x16889C0", Offset = "0x1687BC0", VA = "0x1816889C0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1688AC0", Offset = "0x1687CC0", VA = "0x181688AC0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1688DB0", Offset = "0x1687FB0", VA = "0x181688DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1689450", Offset = "0x1688650", VA = "0x181689450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public T Value
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3163B0", Offset = "0x3155B0", VA = "0x1803163B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3412D0", Offset = "0x3404D0", VA = "0x1803412D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float Duration
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3244A0", Offset = "0x3236A0", VA = "0x1803244A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x23B42B0", Offset = "0x23B34B0", VA = "0x1823B42B0")]
	public T Evaluate(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x23B3F80", Offset = "0x23B3180", VA = "0x1823B3F80")]
	public T EvaluateNonNormalized(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T Interpolate(T lhs, T rhs, float t);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xBF56B0", Offset = "0xBF48B0", VA = "0x180BF56B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2420A30", Offset = "0x241FC30", VA = "0x182420A30", Slot = "4")]
	protected override float Interpolate(float lhs, float rhs, float t)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2420AB0", Offset = "0x241FCB0", VA = "0x182420AB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x24219C0", Offset = "0x2420BC0", VA = "0x1824219C0", Slot = "4")]
	protected override Vector3 Interpolate(Vector3 lhs, Vector3 rhs, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2421A80", Offset = "0x2420C80", VA = "0x182421A80")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2420960", Offset = "0x241FB60", VA = "0x182420960", Slot = "4")]
	protected override Color Interpolate(Color lhs, Color rhs, float t)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x24209B0", Offset = "0x241FBB0", VA = "0x1824209B0")]
	public ColorValueCurve()
	{
	}
}
namespace RecRoom
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct CachedProperty
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct UntilCleared<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private T value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private bool initialized;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public bool HasValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x894E0", Offset = "0x888E0", VA = "0x1800894E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public T Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x894D0", Offset = "0x888D0", VA = "0x1800894D0")]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xA6A80", Offset = "0xA5E80", VA = "0x1800A6A80")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA69C0", Offset = "0xA5DC0", VA = "0x1800A69C0")]
			public void Clear()
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private CircularBuffer<T> buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private T current;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x9D530", Offset = "0x9C930", VA = "0x18009D530", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0xA6500", Offset = "0xA5900", VA = "0x1800A6500", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA68D0", Offset = "0xA5CD0", VA = "0x1800A68D0")]
			public Enumerator(CircularBuffer<T> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x88CE0", Offset = "0x880E0", VA = "0x180088CE0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA5FF0", Offset = "0xA53F0", VA = "0x1800A5FF0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA6300", Offset = "0xA5700", VA = "0x1800A6300", Slot = "8")]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA5D70", Offset = "0xA5170", VA = "0x1800A5D70")]
			private void CheckVersion()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private T[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int startIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int endIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private int version;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xBEE800", Offset = "0xBEDA00", VA = "0x180BEE800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xBEE8C0", Offset = "0xBEDAC0", VA = "0x180BEE8C0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xBEE9C0", Offset = "0xBEDBC0", VA = "0x180BEE9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xBEE770", Offset = "0xBED970", VA = "0x180BEE770")]
		public CircularBuffer(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xBED920", Offset = "0xBECB20", VA = "0x180BED920")]
		public void Add(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xBEDB70", Offset = "0xBECD70", VA = "0x180BEDB70")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xBEE550", Offset = "0xBED750", VA = "0x180BEE550")]
		public void RemoveFromFront(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xBEDE30", Offset = "0xBED030", VA = "0x180BEDE30")]
		public void CopyTo(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xBEE510", Offset = "0xBED710", VA = "0x180BEE510")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xBEE670", Offset = "0xBED870", VA = "0x180BEE670", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xBEE670", Offset = "0xBED870", VA = "0x180BEE670", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBEE1C0", Offset = "0xBED3C0", VA = "0x180BEE1C0")]
		private int ExternalToInternalIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBEDB40", Offset = "0xBECD40", VA = "0x180BEDB40")]
		private int ClampIndexToRange(int index)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class ListEvent
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void DynamicInvoke(object[] args);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x31EE50", Offset = "0x31E050", VA = "0x18031EE50")]
		protected ListEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class ListEvent<T> : ListEvent
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		protected struct ModificationData
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				ADD,
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				REMOVE,
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				CLEAR
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public T action;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		protected bool isIterating;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		protected readonly bool useTryCatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected readonly List<T> actionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly List<ModificationData> queuedModifications;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HasEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD49910", Offset = "0xD48B10", VA = "0x180D49910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD49820", Offset = "0xD48A20", VA = "0x180D49820")]
		public ListEvent(int capacity, bool useTryCatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD49500", Offset = "0xD48700", VA = "0x180D49500", Slot = "1")]
		~ListEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xD49530", Offset = "0xD48730", VA = "0x180D49530")]
		protected void ProcessQueuedModifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD492A0", Offset = "0xD484A0", VA = "0x180D492A0")]
		public void Add(T action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xD496E0", Offset = "0xD488E0", VA = "0x180D496E0")]
		public void Remove(T action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xD493E0", Offset = "0xD485E0", VA = "0x180D493E0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class ActionEvent : ListEvent<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2420840", Offset = "0x241FA40", VA = "0x182420840")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x24205F0", Offset = "0x241F7F0", VA = "0x1824205F0")]
		public void Invoke(bool clearAfterInvoke = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2420560", Offset = "0x241F760", VA = "0x182420560", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x24208A0", Offset = "0x241FAA0", VA = "0x1824208A0")]
		public static ActionEvent operator +(ActionEvent actionEvent, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2420900", Offset = "0x241FB00", VA = "0x182420900")]
		public static ActionEvent operator -(ActionEvent actionEvent, Action action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class ActionEvent<T> : ListEvent<Action<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1C211C0", Offset = "0x1C203C0", VA = "0x181C211C0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1C20C60", Offset = "0x1C1FE60", VA = "0x181C20C60")]
		public void Invoke(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1C2E980", Offset = "0x1C2DB80", VA = "0x181C2E980", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1C211F0", Offset = "0x1C203F0", VA = "0x181C211F0")]
		public static ActionEvent<T> operator +(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1C21290", Offset = "0x1C20490", VA = "0x181C21290")]
		public static ActionEvent<T> operator -(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class ActionEvent<T, U> : ListEvent<Action<T, U>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1C211C0", Offset = "0x1C203C0", VA = "0x181C211C0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1C23790", Offset = "0x1C22990", VA = "0x181C23790")]
		public void Invoke(T t, U u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C214D0", Offset = "0x1C206D0", VA = "0x181C214D0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1C21290", Offset = "0x1C20490", VA = "0x181C21290")]
		public static ActionEvent<T, U> operator +(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1C24820", Offset = "0x1C23A20", VA = "0x181C24820")]
		public static ActionEvent<T, U> operator -(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class ActionEvent<T, U, V> : ListEvent<Action<T, U, V>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1C211C0", Offset = "0x1C203C0", VA = "0x181C211C0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1C256B0", Offset = "0x1C248B0", VA = "0x181C256B0")]
		public void Invoke(T t, U u, V v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1C24D30", Offset = "0x1C23F30", VA = "0x181C24D30", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1C24820", Offset = "0x1C23A20", VA = "0x181C24820")]
		public static ActionEvent<T, U, V> operator +(ActionEvent<T, U, V> actionEvent, Action<T, U, V> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1C263D0", Offset = "0x1C255D0", VA = "0x181C263D0")]
		public static ActionEvent<T, U, V> operator -(ActionEvent<T, U, V> actionEvent, Action<T, U, V> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class ActionEvent<T, U, V, W> : ListEvent<Action<T, U, V, W>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1C211C0", Offset = "0x1C203C0", VA = "0x181C211C0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1C270B0", Offset = "0x1C262B0", VA = "0x181C270B0")]
		public void Invoke(T t, U u, V v, W w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1C26470", Offset = "0x1C25670", VA = "0x181C26470", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1C263D0", Offset = "0x1C255D0", VA = "0x181C263D0")]
		public static ActionEvent<T, U, V, W> operator +(ActionEvent<T, U, V, W> actionEvent, Action<T, U, V, W> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1C273B0", Offset = "0x1C265B0", VA = "0x181C273B0")]
		public static ActionEvent<T, U, V, W> operator -(ActionEvent<T, U, V, W> actionEvent, Action<T, U, V, W> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class UniqueTreeNode<T> where T : IEquatable<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate bool TreeTraversalOperation(UniqueTreeNode<T> node);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public T Content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public LinkedList<UniqueTreeNode<T>> Children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public UniqueTreeNode<T> _parent;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public UniqueTreeNode<T> Parent
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x337490", Offset = "0x336690", VA = "0x180337490")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x10699C0", Offset = "0x1068BC0", VA = "0x1810699C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1069900", Offset = "0x1068B00", VA = "0x181069900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IsLeaf
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1069880", Offset = "0x1068A80", VA = "0x181069880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public UniqueTreeNode<T> Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1069930", Offset = "0x1068B30", VA = "0x181069930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1069750", Offset = "0x1068950", VA = "0x181069750")]
		public UniqueTreeNode(T nodeContent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1067440", Offset = "0x1066640", VA = "0x181067440")]
		public UniqueTreeNode<T> AddChild(T newNodeContent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1067EC0", Offset = "0x10670C0", VA = "0x181067EC0")]
		public UniqueTreeNode<T> RemoveDescendant(T nodeContentToRemove)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1068260", Offset = "0x1067460", VA = "0x181068260")]
		public UniqueTreeNode<T> Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1067800", Offset = "0x1066A00", VA = "0x181067800")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x10683A0", Offset = "0x10675A0", VA = "0x1810683A0")]
		public UniqueTreeNode<T> Reparent(T newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1069070", Offset = "0x1068270", VA = "0x181069070")]
		public static void TraverseTree(UniqueTreeNode<T> traversalRoot, TreeTraversalOperation operation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA7A660", Offset = "0xA79860", VA = "0x180A7A660")]
		public static void TraverseTree<A>(UniqueTreeNode<T> traversalRoot, Func<UniqueTreeNode<T>, A, bool> operation, A arg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1068580", Offset = "0x1067780", VA = "0x181068580")]
		public static string ToString(UniqueTreeNode<T> traversalRoot, int depth = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1067AA0", Offset = "0x1066CA0", VA = "0x181067AA0")]
		public static UniqueTreeNode<T> FindNode(UniqueTreeNode<T> traversalRoot, T nodeContentToFind)
		{
			return null;
		}
	}
}
namespace RecRoom.DataStructures.ResourceHandles
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class EmptyResourceHandle : EmptyResourceHandle<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x24209F0", Offset = "0x241FBF0", VA = "0x1824209F0")]
		public EmptyResourceHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class EmptyResourceHandle<T> : IResourceHandle<T>, IResourceHandle, IDisposable where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Task<T> ResourceTask
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x38C020", Offset = "0x38B220", VA = "0x18038C020", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		IPromise IResourceHandle.ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xBF0010", Offset = "0xBEF210", VA = "0x180BF0010", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xD482A0", Offset = "0xD474A0", VA = "0x180D482A0")]
		public EmptyResourceHandle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "7")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ExceptionResourceHandle<T> : IResourceHandle<T>, IResourceHandle, IDisposable where T : UnityEngine.Object
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Task<T> ResourceTask
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x38C020", Offset = "0x38B220", VA = "0x18038C020", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		IPromise IResourceHandle.ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xBF0010", Offset = "0xBEF210", VA = "0x180BF0010", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xD48380", Offset = "0xD47580", VA = "0x180D48380")]
		public ExceptionResourceHandle(Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x31D8C0", Offset = "0x31CAC0", VA = "0x18031D8C0", Slot = "7")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IResourceHandle : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		[NotNull]
		IPromise ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface IResourceHandle<T> : IResourceHandle, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		[NotNull]
		Task<T> ResourceTask
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		[NotNull]
		new IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class ResourceHandleBase<TTask, T> : IResourceHandle<T>, IResourceHandle, IDisposable where TTask : Task
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static bool isQuitting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Promise<T> resourcePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		protected readonly CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private SynchronizationContext synchronizationContext;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Task<T> ResourceTask
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x38C020", Offset = "0x38B220", VA = "0x18038C020", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		IPromise IResourceHandle.ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x38C020", Offset = "0x38B220", VA = "0x18038C020", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xD4F200", Offset = "0xD4E400", VA = "0x180D4F200")]
		static ResourceHandleBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xD4F370", Offset = "0xD4E570", VA = "0x180D4F370")]
		protected ResourceHandleBase(TTask task)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xD4EEB0", Offset = "0xD4E0B0", VA = "0x180D4EEB0", Slot = "1")]
		~ResourceHandleBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xD4ED10", Offset = "0xD4DF10", VA = "0x180D4ED10", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xD4ED40", Offset = "0xD4DF40", VA = "0x180D4ED40")]
		private void Dispose(bool isDestructor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract T TransformTaskResult(TTask originalTask);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void ReleaseResource();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD4EB10", Offset = "0xD4DD10", VA = "0x180D4EB10")]
		protected void CompleteHandleSuccess(T payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xD4EA10", Offset = "0xD4DC10", VA = "0x180D4EA10")]
		protected void CompleteHandleError(string error)
		{
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class IndexedMap<T> : IEnumerable<IndexedMap<T>.Pair>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public struct Pair
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public T value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int index;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public class Enumerator : IEnumerator<Pair>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private IndexedMap<T> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0xF9DD80", Offset = "0xF9CF80", VA = "0x180F9DD80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0xF9DE20", Offset = "0xF9D020", VA = "0x180F9DE20", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xF9DDF0", Offset = "0xF9CFF0", VA = "0x180F9DDF0")]
			public Enumerator(IndexedMap<T> map)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xF9DCE0", Offset = "0xF9CEE0", VA = "0x180F9DCE0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xF9DD70", Offset = "0xF9CF70", VA = "0x180F9DD70", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xF9DCD0", Offset = "0xF9CED0", VA = "0x180F9DCD0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private struct ListEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public bool hasValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public T value;
		}

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const int DEFAULT_CAPACITY = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Dictionary<T, int> valueToIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private ListEntry[] indexToValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int firstEmptyIndex;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xFA4B50", Offset = "0xFA3D50", VA = "0x180FA4B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xFA4260", Offset = "0xFA3460", VA = "0x180FA4260")]
		public static IndexedMap<T> FromArray(Pair[] pairs, bool expand)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xFA4A90", Offset = "0xFA3C90", VA = "0x180FA4A90")]
		public IndexedMap(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xFA4630", Offset = "0xFA3830", VA = "0x180FA4630")]
		public int GetIndex(T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xFA4680", Offset = "0xFA3880", VA = "0x180FA4680")]
		public T GetValue(int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xFA48A0", Offset = "0xFA3AA0", VA = "0x180FA48A0")]
		public bool TryAdd(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xFA48C0", Offset = "0xFA3AC0", VA = "0x180FA48C0")]
		public bool TryAdd(T value, int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xFA4760", Offset = "0xFA3960", VA = "0x180FA4760")]
		public Pair[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xFA4200", Offset = "0xFA3400", VA = "0x180FA4200")]
		private int FindNextEmptyIndex(int startIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xFA46F0", Offset = "0xFA38F0", VA = "0x180FA46F0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xFA46F0", Offset = "0xFA38F0", VA = "0x180FA46F0", Slot = "4")]
		private IEnumerator<Pair> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class SimplePool<T> where T : new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private List<T> availableEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private List<T> allEntries;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xFAA790", Offset = "0xFA9990", VA = "0x180FAA790")]
		public SimplePool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xFAA7C0", Offset = "0xFA99C0", VA = "0x180FAA7C0")]
		public SimplePool(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xFAA570", Offset = "0xFA9770", VA = "0x180FAA570")]
		public T Acquire()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xFAA670", Offset = "0xFA9870", VA = "0x180FAA670")]
		public void Release(T toRelease)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PriorityMap<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private Dictionary<int, T> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x339B60", Offset = "0x338D60", VA = "0x180339B60", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x381A60", Offset = "0x380C60", VA = "0x180381A60", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xFA72F0", Offset = "0xFA64F0", VA = "0x180FA72F0")]
		public bool AddValue(T value, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xFA75E0", Offset = "0xFA67E0", VA = "0x180FA75E0")]
		public bool RemoveValue(int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xFA7350", Offset = "0xFA6550", VA = "0x180FA7350")]
		public T GetPriorityValue(int maxPriority)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xFA7640", Offset = "0xFA6840", VA = "0x180FA7640")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xFA76D0", Offset = "0xFA68D0", VA = "0x180FA76D0")]
		public PriorityMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class PriorityQueue<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		protected struct Entry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public T Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int Priority;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		protected readonly List<Entry> entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private T highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xFA7F20", Offset = "0xFA7120", VA = "0x180FA7F20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xFA7830", Offset = "0xFA6A30", VA = "0x180FA7830")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xFA7750", Offset = "0xFA6950", VA = "0x180FA7750")]
		public void Add(T value, int priority)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xFA7B30", Offset = "0xFA6D30", VA = "0x180FA7B30")]
		public bool Remove(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xFA77D0", Offset = "0xFA69D0", VA = "0x180FA77D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xFA7AA0", Offset = "0xFA6CA0", VA = "0x180FA7AA0")]
		public T Peek()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xFA7C50", Offset = "0xFA6E50", VA = "0x180FA7C50")]
		private void UpdateHighestPriorityValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xFA7EA0", Offset = "0xFA70A0", VA = "0x180FA7EA0")]
		public PriorityQueue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class WalkableStack<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int nextIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private List<T> elements;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T Next
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x12641A0", Offset = "0x12633A0", VA = "0x1812641A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T Head
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x1264160", Offset = "0x1263360", VA = "0x181264160")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x12640D0", Offset = "0x12632D0", VA = "0x1812640D0")]
		public WalkableStack(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1263EF0", Offset = "0x12630F0", VA = "0x181263EF0")]
		public void Add(T command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1264030", Offset = "0x1263230", VA = "0x181264030")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1264080", Offset = "0x1263280", VA = "0x181264080")]
		public void WalkForward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1264070", Offset = "0x1263270", VA = "0x181264070")]
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
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int Priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Dictionary<object, PrioritizedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x93EA50", Offset = "0x93DC50", VA = "0x18093EA50", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x93EA70", Offset = "0x93DC70", VA = "0x18093EA70", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xFA40E0", Offset = "0xFA32E0", VA = "0x180FA40E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public object HighestPriorityToken
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3163C0", Offset = "0x3155C0", VA = "0x1803163C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3163F0", Offset = "0x3155F0", VA = "0x1803163F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xF9E120", Offset = "0xF9D320", VA = "0x180F9E120")]
		public bool AddValue(T value, object token, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xF9E620", Offset = "0xF9D820", VA = "0x180F9E620")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xF9E770", Offset = "0xF9D970", VA = "0x180F9E770")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xFA2C40", Offset = "0xFA1E40", VA = "0x180FA2C40")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xFA4060", Offset = "0xFA3260", VA = "0x180FA4060")]
		public ExplicitTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class MultiplicativeTokenMap
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private Dictionary<object, float> dictionary;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float Product
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3485D0", Offset = "0x3477D0", VA = "0x1803485D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x917D50", Offset = "0x916F50", VA = "0x180917D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x24210E0", Offset = "0x24202E0", VA = "0x1824210E0")]
		public void AddValue(float value, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2421150", Offset = "0x2420350", VA = "0x182421150")]
		public void RemoveValue(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x24211B0", Offset = "0x24203B0", VA = "0x1824211B0")]
		private void UpdateProduct()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x24212E0", Offset = "0x24204E0", VA = "0x1824212E0")]
		public MultiplicativeTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public sealed class TokenFlag
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly List<object> tokens;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool HasTokens
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x24218A0", Offset = "0x2420AA0", VA = "0x1824218A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x24215D0", Offset = "0x24207D0", VA = "0x1824215D0")]
		public void Add(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2421650", Offset = "0x2420850", VA = "0x182421650")]
		public void Remove(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x24216B0", Offset = "0x24208B0", VA = "0x1824216B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2421840", Offset = "0x2420A40", VA = "0x182421840")]
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
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private Dictionary<object, TimestampedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private T _latestValue;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public virtual T LatestValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xFA4170", Offset = "0xFA3370", VA = "0x180FA4170", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xFA41C0", Offset = "0xFA33C0", VA = "0x180FA41C0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public object LatestToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3163B0", Offset = "0x3155B0", VA = "0x1803163B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3412D0", Offset = "0x3404D0", VA = "0x1803412D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xFABFD0", Offset = "0xFAB1D0", VA = "0x180FABFD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1263060", Offset = "0x1262260", VA = "0x181263060")]
		public bool AddValue(T value, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xFAAD00", Offset = "0xFA9F00", VA = "0x180FAAD00")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xFAADD0", Offset = "0xFA9FD0", VA = "0x180FAADD0")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xFABB20", Offset = "0xFAAD20", VA = "0x180FABB20")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xFABF50", Offset = "0xFAB150", VA = "0x180FABF50")]
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
