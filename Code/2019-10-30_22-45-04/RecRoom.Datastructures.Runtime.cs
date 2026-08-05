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
			[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x378C80", Offset = "0x377680", VA = "0x180378C80")]
		[DebuggerHidden]
		public <Start>d__10(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x31CA70", Offset = "0x31B470", VA = "0x18031CA70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x24C8870", Offset = "0x24C7270", VA = "0x1824C8870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x24C9260", Offset = "0x24C7C60", VA = "0x1824C9260", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x378C80", Offset = "0x377680", VA = "0x180378C80")]
		[DebuggerHidden]
		public <MergeRoots>d__12(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x31CA70", Offset = "0x31B470", VA = "0x18031CA70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x24C7A80", Offset = "0x24C6480", VA = "0x1824C7A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x24C8820", Offset = "0x24C7220", VA = "0x1824C8820", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x24C6BC0", Offset = "0x24C55C0", VA = "0x1824C6BC0")]
	public static void AddExistingSingleton(IGameSingleton s)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24C6C40", Offset = "0x24C5640", VA = "0x1824C6C40", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24C6D20", Offset = "0x24C5720", VA = "0x1824C6D20", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24C6DA0", Offset = "0x24C57A0", VA = "0x1824C6DA0")]
	[IteratorStateMachine(typeof(<Start>d__10))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x31CA70", Offset = "0x31B470", VA = "0x18031CA70", Slot = "6")]
	protected virtual void OnInitializationComplete()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24C6CC0", Offset = "0x24C56C0", VA = "0x1824C6CC0")]
	[IteratorStateMachine(typeof(<MergeRoots>d__12))]
	public static IEnumerator MergeRoots(List<GameRoot> gameRoots)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3197A0", Offset = "0x3181A0", VA = "0x1803197A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F3290", Offset = "0x3F1C90", VA = "0x1803F3290", Slot = "4")]
		get
		{
			return default(GameRestartBehaviors);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GameObject GameObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xDE45D0", Offset = "0xDE2FD0", VA = "0x180DE45D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x24C6EB0", Offset = "0x24C58B0", VA = "0x1824C6EB0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x24C7140", Offset = "0x24C5B40", VA = "0x1824C7140")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x24C7260", Offset = "0x24C5C60", VA = "0x1824C7260")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F66C30", Offset = "0x1F65630", VA = "0x181F66C30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F66E90", Offset = "0x1F65890", VA = "0x181F66E90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static bool IsInitialized
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1F66D30", Offset = "0x1F65730", VA = "0x181F66D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F66760", Offset = "0x1F65160", VA = "0x181F66760", Slot = "7")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F66A00", Offset = "0x1F65400", VA = "0x181F66A00", Slot = "8")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F66C10", Offset = "0x1F65610", VA = "0x181F66C10")]
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
		[Cpp2IlInjected.Address(RVA = "0x378830", Offset = "0x377230", VA = "0x180378830", Slot = "6")]
		get
		{
			return default(GameRestartBehaviors);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject GameObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDE45D0", Offset = "0xDE2FD0", VA = "0x180DE45D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x12FA9A0", Offset = "0x12F93A0", VA = "0x1812FA9A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B71200", Offset = "0x1B6FC00", VA = "0x181B71200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B710D0", Offset = "0x1B6FAD0", VA = "0x181B710D0")]
	public TimeSeriesRollingWindow(float sampleInterval, float windowLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B70E10", Offset = "0x1B6F810", VA = "0x181B70E10")]
	public bool TryToAddSample(float time, T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1B706B0", Offset = "0x1B6F0B0", VA = "0x181B706B0")]
	public IEnumerable<T> GetSamples(float time, [Optional] float? minTime)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1B70680", Offset = "0x1B6F080", VA = "0x181B70680")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1B70D50", Offset = "0x1B6F750", VA = "0x181B70D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F40A0", Offset = "0x3F2AA0", VA = "0x1803F40A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A40", Offset = "0x5A4440", VA = "0x1805A5A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1B72210", Offset = "0x1B70C10", VA = "0x181B72210")]
	public TimestampedRollingBuffer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1B72140", Offset = "0x1B70B40", VA = "0x181B72140")]
	public TimestampedRollingBuffer(int size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1B71280", Offset = "0x1B6FC80", VA = "0x181B71280")]
	public void Add(float time, T value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B71430", Offset = "0x1B6FE30", VA = "0x181B71430")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B71C30", Offset = "0x1B70630", VA = "0x181B71C30")]
	public bool TryGetAverageValueOverTime(float startTime, float endTime, out T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1B71FA0", Offset = "0x1B709A0", VA = "0x181B71FA0")]
	public bool TryGetMaximumValueOverTime(float startTime, float endTime, out T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1B71840", Offset = "0x1B70240", VA = "0x181B71840")]
	public void GetValuesInTimeWindow(float startTime, float endTime, List<T> buffer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1B719D0", Offset = "0x1B703D0", VA = "0x181B719D0")]
	private int RollingHeadOffset(int headOffset)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1B71990", Offset = "0x1B70390", VA = "0x181B71990")]
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
	[Cpp2IlInjected.Address(RVA = "0x24C7690", Offset = "0x24C6090", VA = "0x1824C7690", Slot = "4")]
	protected override Vector3 ZeroValue()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x24C7540", Offset = "0x24C5F40", VA = "0x1824C7540", Slot = "5")]
	protected override Vector3 Scale(Vector3 value, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x24C75E0", Offset = "0x24C5FE0", VA = "0x1824C75E0", Slot = "6")]
	protected override Vector3 Sum(Vector3 lhs, Vector3 rhs)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x24C74D0", Offset = "0x24C5ED0", VA = "0x1824C74D0", Slot = "7")]
	protected override Vector3 Max(Vector3 lhs, Vector3 rhs)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x24C7700", Offset = "0x24C6100", VA = "0x1824C7700")]
	public TimestampedRollingBufferVector3()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x15EBBA0", Offset = "0x15EA5A0", VA = "0x1815EBBA0")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1D07C10", Offset = "0x1D06610", VA = "0x181D07C10")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8E66F0", Offset = "0x8E50F0", VA = "0x1808E66F0")]
	internal static int CombineHashCodes(int h1, int h2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9B2260", Offset = "0x9B0C60", VA = "0x1809B2260")]
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
	[Cpp2IlInjected.Address(RVA = "0x15B3820", Offset = "0x15B2220", VA = "0x1815B3820")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1B72240", Offset = "0x1B70C40", VA = "0x181B72240", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1B728C0", Offset = "0x1B712C0", VA = "0x181B728C0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1B72BA0", Offset = "0x1B715A0", VA = "0x181B72BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1B742D0", Offset = "0x1B72CD0", VA = "0x181B742D0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B753B0", Offset = "0x1B73DB0", VA = "0x181B753B0")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1B746A0", Offset = "0x1B730A0", VA = "0x181B746A0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1B747A0", Offset = "0x1B731A0", VA = "0x181B747A0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1B74A90", Offset = "0x1B73490", VA = "0x181B74A90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1B75130", Offset = "0x1B73B30", VA = "0x181B75130", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x31B950", Offset = "0x31A350", VA = "0x18031B950")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x31BA90", Offset = "0x31A490", VA = "0x18031BA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float Duration
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7242D0", Offset = "0x722CD0", VA = "0x1807242D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24BDC10", Offset = "0x24BC610", VA = "0x1824BDC10")]
	public T Evaluate(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24BD8E0", Offset = "0x24BC2E0", VA = "0x1824BD8E0")]
	public T EvaluateNonNormalized(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T Interpolate(T lhs, T rhs, float t);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1469B40", Offset = "0x1468540", VA = "0x181469B40")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24C6B00", Offset = "0x24C5500", VA = "0x1824C6B00", Slot = "4")]
	protected override float Interpolate(float lhs, float rhs, float t)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24C6B80", Offset = "0x24C5580", VA = "0x1824C6B80")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24C92B0", Offset = "0x24C7CB0", VA = "0x1824C92B0", Slot = "4")]
	protected override Vector3 Interpolate(Vector3 lhs, Vector3 rhs, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24C9370", Offset = "0x24C7D70", VA = "0x1824C9370")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24C6A30", Offset = "0x24C5430", VA = "0x1824C6A30", Slot = "4")]
	protected override Color Interpolate(Color lhs, Color rhs, float t)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24C6A80", Offset = "0x24C5480", VA = "0x1824C6A80")]
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
				[Cpp2IlInjected.Address(RVA = "0x1DB400", Offset = "0x1DA800", VA = "0x1801DB400")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public T Value
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x293F0", Offset = "0x287F0", VA = "0x1800293F0")]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x2B3080", Offset = "0x2B2480", VA = "0x1802B3080")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2B3000", Offset = "0x2B2400", VA = "0x1802B3000")]
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
				[Cpp2IlInjected.Address(RVA = "0xAD10", Offset = "0xA110", VA = "0x18000AD10", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x2B2B80", Offset = "0x2B1F80", VA = "0x1802B2B80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2B2F50", Offset = "0x2B2350", VA = "0x1802B2F50")]
			public Enumerator(CircularBuffer<T> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2A70", Offset = "0x1E70", VA = "0x180002A70", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2B2670", Offset = "0x2B1A70", VA = "0x1802B2670", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x2B2980", Offset = "0x2B1D80", VA = "0x1802B2980", Slot = "8")]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2B23F0", Offset = "0x2B17F0", VA = "0x1802B23F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D77740", Offset = "0x1D76140", VA = "0x181D77740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1D77800", Offset = "0x1D76200", VA = "0x181D77800")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1D77900", Offset = "0x1D76300", VA = "0x181D77900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1D776B0", Offset = "0x1D760B0", VA = "0x181D776B0")]
		public CircularBuffer(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D76860", Offset = "0x1D75260", VA = "0x181D76860")]
		public void Add(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1D76AB0", Offset = "0x1D754B0", VA = "0x181D76AB0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1D77490", Offset = "0x1D75E90", VA = "0x181D77490")]
		public void RemoveFromFront(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1D76D70", Offset = "0x1D75770", VA = "0x181D76D70")]
		public void CopyTo(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1D77450", Offset = "0x1D75E50", VA = "0x181D77450")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1D775B0", Offset = "0x1D75FB0", VA = "0x181D775B0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1D775B0", Offset = "0x1D75FB0", VA = "0x181D775B0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1D77100", Offset = "0x1D75B00", VA = "0x181D77100")]
		private int ExternalToInternalIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1D76A80", Offset = "0x1D75480", VA = "0x181D76A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x31C720", Offset = "0x31B120", VA = "0x18031C720")]
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
			[Cpp2IlInjected.Address(RVA = "0x148D850", Offset = "0x148C250", VA = "0x18148D850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x148D760", Offset = "0x148C160", VA = "0x18148D760")]
		public ListEvent(int capacity, bool useTryCatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x148D470", Offset = "0x148BE70", VA = "0x18148D470")]
		protected void ProcessQueuedModifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x148D330", Offset = "0x148BD30", VA = "0x18148D330")]
		public void Add(T action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x148D620", Offset = "0x148C020", VA = "0x18148D620")]
		public void Remove(T action)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class ActionEvent : ListEvent<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x24C6910", Offset = "0x24C5310", VA = "0x1824C6910")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x24C66C0", Offset = "0x24C50C0", VA = "0x1824C66C0")]
		public void Invoke(bool clearAfterInvoke = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x24C6630", Offset = "0x24C5030", VA = "0x1824C6630", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x24C6970", Offset = "0x24C5370", VA = "0x1824C6970")]
		public static ActionEvent operator +(ActionEvent actionEvent, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x24C69D0", Offset = "0x24C53D0", VA = "0x1824C69D0")]
		public static ActionEvent operator -(ActionEvent actionEvent, Action action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class ActionEvent<T> : ListEvent<Action<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1610", Offset = "0x1DF0010", VA = "0x181DF1610")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1DF0DF0", Offset = "0x1DEF7F0", VA = "0x181DF0DF0")]
		public void Invoke(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1DEFDF0", Offset = "0x1DEE7F0", VA = "0x181DEFDF0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1640", Offset = "0x1DF0040", VA = "0x181DF1640")]
		public static ActionEvent<T> operator +(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF16E0", Offset = "0x1DF00E0", VA = "0x181DF16E0")]
		public static ActionEvent<T> operator -(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class ActionEvent<T, U> : ListEvent<Action<T, U>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1610", Offset = "0x1DF0010", VA = "0x181DF1610")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF25B0", Offset = "0x1DF0FB0", VA = "0x181DF25B0")]
		public void Invoke(T t, U u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1780", Offset = "0x1DF0180", VA = "0x181DF1780", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF16E0", Offset = "0x1DF00E0", VA = "0x181DF16E0")]
		public static ActionEvent<T, U> operator +(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF3630", Offset = "0x1DF2030", VA = "0x181DF3630")]
		public static ActionEvent<T, U> operator -(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class ActionEvent<T, U, V> : ListEvent<Action<T, U, V>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1610", Offset = "0x1DF0010", VA = "0x181DF1610")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1DF38E0", Offset = "0x1DF22E0", VA = "0x181DF38E0")]
		public void Invoke(T t, U u, V v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1DF36D0", Offset = "0x1DF20D0", VA = "0x181DF36D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x31B8F0", Offset = "0x31A2F0", VA = "0x18031B8F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x1756AC0", Offset = "0x17554C0", VA = "0x181756AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IsRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x1756A00", Offset = "0x1755400", VA = "0x181756A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsLeaf
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1756980", Offset = "0x1755380", VA = "0x181756980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public UniqueTreeNode<T> Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1756A30", Offset = "0x1755430", VA = "0x181756A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1756850", Offset = "0x1755250", VA = "0x181756850")]
		public UniqueTreeNode(T nodeContent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1754540", Offset = "0x1752F40", VA = "0x181754540")]
		public UniqueTreeNode<T> AddChild(T newNodeContent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1754FC0", Offset = "0x17539C0", VA = "0x181754FC0")]
		public UniqueTreeNode<T> RemoveDescendant(T nodeContentToRemove)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1755360", Offset = "0x1753D60", VA = "0x181755360")]
		public UniqueTreeNode<T> Remove()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1754900", Offset = "0x1753300", VA = "0x181754900")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x17554A0", Offset = "0x1753EA0", VA = "0x1817554A0")]
		public UniqueTreeNode<T> Reparent(T newParent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1756170", Offset = "0x1754B70", VA = "0x181756170")]
		public static void TraverseTree(UniqueTreeNode<T> traversalRoot, TreeTraversalOperation operation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x131B090", Offset = "0x1319A90", VA = "0x18131B090")]
		public static void TraverseTree<A>(UniqueTreeNode<T> traversalRoot, Func<UniqueTreeNode<T>, A, bool> operation, A arg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1755680", Offset = "0x1754080", VA = "0x181755680")]
		public static string ToString(UniqueTreeNode<T> traversalRoot, int depth = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1754BA0", Offset = "0x17535A0", VA = "0x181754BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24C6AC0", Offset = "0x24C54C0", VA = "0x1824C6AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x385FC0", Offset = "0x3849C0", VA = "0x180385FC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x148A770", Offset = "0x1489170", VA = "0x18148A770", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x148C150", Offset = "0x148AB50", VA = "0x18148C150")]
		public EmptyResourceHandle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x31CA70", Offset = "0x31B470", VA = "0x18031CA70", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x385FC0", Offset = "0x3849C0", VA = "0x180385FC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x148A770", Offset = "0x1489170", VA = "0x18148A770", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x148C230", Offset = "0x148AC30", VA = "0x18148C230")]
		public ExceptionResourceHandle(Exception e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x31CA70", Offset = "0x31B470", VA = "0x18031CA70", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public IPromise<T> ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x385FC0", Offset = "0x3849C0", VA = "0x180385FC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		IPromise IResourceHandle.ResourcePromise
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x385FC0", Offset = "0x3849C0", VA = "0x180385FC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1496EA0", Offset = "0x14958A0", VA = "0x181496EA0")]
		static ResourceHandleBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1497010", Offset = "0x1495A10", VA = "0x181497010")]
		protected ResourceHandleBase(TTask task)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1496B50", Offset = "0x1495550", VA = "0x181496B50", Slot = "1")]
		~ResourceHandleBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x14969B0", Offset = "0x14953B0", VA = "0x1814969B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x14969E0", Offset = "0x14953E0", VA = "0x1814969E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14967B0", Offset = "0x14951B0", VA = "0x1814967B0")]
		protected void CompleteHandleSuccess(T payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x14966B0", Offset = "0x14950B0", VA = "0x1814966B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x1894D10", Offset = "0x1893710", VA = "0x181894D10", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x193A8D0", Offset = "0x19392D0", VA = "0x18193A8D0", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5FAA50", Offset = "0x5F9450", VA = "0x1805FAA50")]
			public Enumerator(IndexedMap<T> map)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x193A840", Offset = "0x1939240", VA = "0x18193A840", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4B2510", Offset = "0x4B0F10", VA = "0x1804B2510", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x538430", Offset = "0x536E30", VA = "0x180538430", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1941600", Offset = "0x1940000", VA = "0x181941600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1940D10", Offset = "0x193F710", VA = "0x181940D10")]
		public static IndexedMap<T> FromArray(Pair[] pairs, bool expand)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1941540", Offset = "0x193FF40", VA = "0x181941540")]
		public IndexedMap(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x19410E0", Offset = "0x193FAE0", VA = "0x1819410E0")]
		public int GetIndex(T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1941130", Offset = "0x193FB30", VA = "0x181941130")]
		public T GetValue(int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1941350", Offset = "0x193FD50", VA = "0x181941350")]
		public bool TryAdd(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1941370", Offset = "0x193FD70", VA = "0x181941370")]
		public bool TryAdd(T value, int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1941210", Offset = "0x193FC10", VA = "0x181941210")]
		public Pair[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1940CB0", Offset = "0x193F6B0", VA = "0x181940CB0")]
		private int FindNextEmptyIndex(int startIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x19411A0", Offset = "0x193FBA0", VA = "0x1819411A0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x19411A0", Offset = "0x193FBA0", VA = "0x1819411A0", Slot = "4")]
		private IEnumerator<Pair> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class SimplePool<T> where T : new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private List<T> availableEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private List<T> allEntries;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x19457E0", Offset = "0x19441E0", VA = "0x1819457E0")]
		public SimplePool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1945810", Offset = "0x1944210", VA = "0x181945810")]
		public SimplePool(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x19455C0", Offset = "0x1943FC0", VA = "0x1819455C0")]
		public T Acquire()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x19456C0", Offset = "0x19440C0", VA = "0x1819456C0")]
		public void Release(T toRelease)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class PriorityMap<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private Dictionary<int, T> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x3161A0", Offset = "0x314BA0", VA = "0x1803161A0", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x3161C0", Offset = "0x314BC0", VA = "0x1803161C0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1941630", Offset = "0x1940030", VA = "0x181941630")]
		public bool AddValue(T value, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1941920", Offset = "0x1940320", VA = "0x181941920")]
		public bool RemoveValue(int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1941690", Offset = "0x1940090", VA = "0x181941690")]
		public T GetPriorityValue(int maxPriority)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1941980", Offset = "0x1940380", VA = "0x181941980")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1941A10", Offset = "0x1940410", VA = "0x181941A10")]
		public PriorityMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class PriorityQueue<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		protected struct Entry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public T Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public int Priority;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected readonly List<Entry> entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private T highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x148F1D0", Offset = "0x148DBD0", VA = "0x18148F1D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1941B70", Offset = "0x1940570", VA = "0x181941B70")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1941A90", Offset = "0x1940490", VA = "0x181941A90")]
		public void Add(T value, int priority)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1941E70", Offset = "0x1940870", VA = "0x181941E70")]
		public bool Remove(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1941B10", Offset = "0x1940510", VA = "0x181941B10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1941DE0", Offset = "0x19407E0", VA = "0x181941DE0")]
		public T Peek()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1941F90", Offset = "0x1940990", VA = "0x181941F90")]
		private void UpdateHighestPriorityValue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x19421E0", Offset = "0x1940BE0", VA = "0x1819421E0")]
		public PriorityQueue()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class WalkableStack<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int nextIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private List<T> elements;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public T Next
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1948290", Offset = "0x1946C90", VA = "0x181948290")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public T Head
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1948250", Offset = "0x1946C50", VA = "0x181948250")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x19481C0", Offset = "0x1946BC0", VA = "0x1819481C0")]
		public WalkableStack(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1947FE0", Offset = "0x19469E0", VA = "0x181947FE0")]
		public void Add(T command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1948120", Offset = "0x1946B20", VA = "0x181948120")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1948170", Offset = "0x1946B70", VA = "0x181948170")]
		public void WalkForward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1948160", Offset = "0x1946B60", VA = "0x181948160")]
		public void WalkBack()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class ExplicitTokenMap<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct PrioritizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int Priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Dictionary<object, PrioritizedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1120EA0", Offset = "0x111F8A0", VA = "0x181120EA0", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1120EC0", Offset = "0x111F8C0", VA = "0x181120EC0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1940B90", Offset = "0x193F590", VA = "0x181940B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public object HighestPriorityToken
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x31B900", Offset = "0x31A300", VA = "0x18031B900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x31BA60", Offset = "0x31A460", VA = "0x18031BA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x193ABD0", Offset = "0x19395D0", VA = "0x18193ABD0")]
		public bool AddValue(T value, object token, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x193B0D0", Offset = "0x1939AD0", VA = "0x18193B0D0")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x193B220", Offset = "0x1939C20", VA = "0x18193B220")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x193F6F0", Offset = "0x193E0F0", VA = "0x18193F6F0")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1940B10", Offset = "0x193F510", VA = "0x181940B10")]
		public ExplicitTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class MultiplicativeTokenMap
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private Dictionary<object, float> dictionary;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float Product
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5A5930", Offset = "0x5A4330", VA = "0x1805A5930")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5A5A60", Offset = "0x5A4460", VA = "0x1805A5A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x24C7270", Offset = "0x24C5C70", VA = "0x1824C7270")]
		public void AddValue(float value, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x24C72E0", Offset = "0x24C5CE0", VA = "0x1824C72E0")]
		public void RemoveValue(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x24C7340", Offset = "0x24C5D40", VA = "0x1824C7340")]
		private void UpdateProduct()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x24C7470", Offset = "0x24C5E70", VA = "0x1824C7470")]
		public MultiplicativeTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class TokenFlag
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly List<object> tokens;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HasTokens
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x24C7A30", Offset = "0x24C6430", VA = "0x1824C7A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x24C7760", Offset = "0x24C6160", VA = "0x1824C7760")]
		public void Add(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x24C77E0", Offset = "0x24C61E0", VA = "0x1824C77E0")]
		public void Remove(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x24C7840", Offset = "0x24C6240", VA = "0x1824C7840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x24C79D0", Offset = "0x24C63D0", VA = "0x1824C79D0")]
		public TokenFlag()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class TokenMap<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Dictionary<object, TimestampedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private T _latestValue;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public virtual T LatestValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1940C20", Offset = "0x193F620", VA = "0x181940C20", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1940C70", Offset = "0x193F670", VA = "0x181940C70", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public object LatestToken
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x31B950", Offset = "0x31A350", VA = "0x18031B950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x31BA90", Offset = "0x31A490", VA = "0x18031BA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x1947E80", Offset = "0x1946880", VA = "0x181947E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1945D40", Offset = "0x1944740", VA = "0x181945D40")]
		public bool AddValue(T value, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1946000", Offset = "0x1944A00", VA = "0x181946000")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1946190", Offset = "0x1944B90", VA = "0x181946190")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x19479D0", Offset = "0x19463D0", VA = "0x1819479D0")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1947E00", Offset = "0x1946800", VA = "0x181947E00")]
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
