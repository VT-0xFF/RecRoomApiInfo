using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IOPBALECMNN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8EE7D0", Offset = "0x8EDBD0", VA = "0x1808EE7D0")]
	public IOPBALECMNN()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4BAF70", Offset = "0x4BA370", VA = "0x1804BAF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4F88B0", Offset = "0x4F7CB0", VA = "0x1804F88B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "4")]
	public virtual void NMFPDEMBIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	[IOPBALECMNN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D136C0", Offset = "0x2D12AC0", VA = "0x182D136C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2D13200", Offset = "0x2D12600", VA = "0x182D13200", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2D13CC0", Offset = "0x2D130C0", VA = "0x182D13CC0")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EJAPOJAIPBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public EJAPOJAIPBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2D86570", Offset = "0x2D85970", VA = "0x182D86570")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[IOPBALECMNN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x16EC900", Offset = "0x16EBD00", VA = "0x1816EC900", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x16EC930", Offset = "0x16EBD30", VA = "0x1816EC930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x16EC8A0", Offset = "0x16EBCA0", VA = "0x1816EC8A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey IDFIPMLKMCO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x16EC8D0", Offset = "0x16EBCD0", VA = "0x1816EC8D0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16EC7B0", Offset = "0x16EBBB0", VA = "0x1816EC7B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D89F20", Offset = "0x2D89320", VA = "0x182D89F20", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2D89BC0", Offset = "0x2D88FC0", VA = "0x182D89BC0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D897F0", Offset = "0x2D88BF0", VA = "0x182D897F0", Slot = "14")]
	protected virtual string CGIGDGJHCBC(TKeyVal HIOHIDJJBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x16EC090", Offset = "0x16EB490", VA = "0x1816EC090", Slot = "4")]
	public bool ContainsKey(TKey IDFIPMLKMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x16EC6B0", Offset = "0x16EBAB0", VA = "0x1816EC6B0", Slot = "5")]
	public bool TryGetValue(TKey IDFIPMLKMCO, out TVal ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x16EC0C0", Offset = "0x16EB4C0", VA = "0x1816EC0C0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x16EC0C0", Offset = "0x16EB4C0", VA = "0x1816EC0C0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x16EC6E0", Offset = "0x16EBAE0", VA = "0x1816EC6E0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OFICFDOKJFD : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public GameRoot <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x448120", Offset = "0x447520", VA = "0x180448120")]
		[DebuggerHidden]
		public OFICFDOKJFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4033240", Offset = "0x4032640", VA = "0x184033240", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x40330F0", Offset = "0x40324F0", VA = "0x1840330F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x40332B0", Offset = "0x40326B0", VA = "0x1840332B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x40331F0", Offset = "0x40325F0", VA = "0x1840331F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	private GameObject StartupObject;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static HashSet<GameObject> HIJHMCPKPLC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static HashSet<UnityEngine.Object> HEEKPFLJEEP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4031CC0", Offset = "0x40310C0", VA = "0x184031CC0")]
	public static void RegisterDontDestroyOnLoad(GameObject IPDDCJCGLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4031D60", Offset = "0x4031160", VA = "0x184031D60")]
	public static void RegisterHideFlagsDontSaveObejct(UnityEngine.Object HLLMFMGFIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4031970", Offset = "0x4030D70", VA = "0x184031970", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4031DE0", Offset = "0x40311E0", VA = "0x184031DE0")]
	[IteratorStateMachine(typeof(OFICFDOKJFD))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "6")]
	protected virtual void KMHEPFBDAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4031ED0", Offset = "0x40312D0", VA = "0x184031ED0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MNJAHNIHIGK
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29DCFA0", Offset = "0x29DC3A0", VA = "0x1829DCFA0")]
	public static void BKMOKEMOIJI<T>(this T OKCBEIFOFED) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4032D10", Offset = "0x4032110", VA = "0x184032D10")]
	public static void BKMOKEMOIJI(this GameObject HOFKJFFOLNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : MonoBehaviour where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static TImpl NBFDMFGLOEL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected static TImpl EELIJCAPGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x448950", Offset = "0x447D50", VA = "0x180448950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1CD7030", Offset = "0x1CD6430", VA = "0x181CD7030", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1CD7500", Offset = "0x1CD6900", VA = "0x181CD7500", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x16EC960", Offset = "0x16EBD60", VA = "0x1816EC960")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GameObject MCDIKBOFMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68BCC0", Offset = "0x68B0C0", VA = "0x18068BCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4032DF0", Offset = "0x40321F0", VA = "0x184032DF0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4033010", Offset = "0x4032410", VA = "0x184033010")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x44EFE0", Offset = "0x44E3E0", VA = "0x18044EFE0")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static T NBFDMFGLOEL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static T EELIJCAPGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x448950", Offset = "0x447D50", VA = "0x180448950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool GONEBMAOJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2D14BA0", Offset = "0x2D13FA0", VA = "0x182D14BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D14660", Offset = "0x2D13A60", VA = "0x182D14660", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D149E0", Offset = "0x2D13DE0", VA = "0x182D149E0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x16EC960", Offset = "0x16EBD60", VA = "0x1816EC960")]
	public SingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LLOGFBNIJIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MACJFAMFBIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public MACJFAMFBIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3011EC0", Offset = "0x30112C0", VA = "0x183011EC0")]
		internal bool <GetSamples>b__0(global::MCFNINDADBC<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float FCHBCFOLKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float FDGJAPLOGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<global::MCFNINDADBC<float, T>> OMAFCDEDEDE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BPDCMEHNIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3010CC0", Offset = "0x30100C0", VA = "0x183010CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x30117D0", Offset = "0x3010BD0", VA = "0x1830117D0")]
	public LLOGFBNIJIJ(float MIOAOAAPIKP, float EPIHNLIPDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3010DF0", Offset = "0x30101F0", VA = "0x183010DF0")]
	public bool IHGCGEOCOFN(float BGMGGELKPHN, T ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x30114A0", Offset = "0x30108A0", VA = "0x1830114A0")]
	public IEnumerable<T> LEDAKOODPMH(float BGMGGELKPHN, [Optional] float? DIHIECFIFGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3010DC0", Offset = "0x30101C0", VA = "0x183010DC0")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30110B0", Offset = "0x30104B0", VA = "0x1830110B0")]
	private void JNFGJDIAPPB(float BGMGGELKPHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HGODODNHFPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct GBOJIBDKAAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public T IGCHKCCOFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public float NPFEFKJEJNM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static float INCMPFBFNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private List<T> JOMMHHKFNOP;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private const int BHBIBOPMIAD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private GBOJIBDKAAC[] HBOJCEMNMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int FGHKIBHDMPG;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float JEBBNDDJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4B4420", Offset = "0x4B3820", VA = "0x1804B4420")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x57B040", Offset = "0x57A440", VA = "0x18057B040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x307E650", Offset = "0x307DA50", VA = "0x18307E650")]
	public HGODODNHFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x307E680", Offset = "0x307DA80", VA = "0x18307E680")]
	public HGODODNHFPH(int JKPCFCCBIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x307DB60", Offset = "0x307CF60", VA = "0x18307DB60")]
	public void IKAEHHFCPPJ(float BGMGGELKPHN, T ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x307D900", Offset = "0x307CD00", VA = "0x18307D900")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x307DE50", Offset = "0x307D250", VA = "0x18307DE50")]
	public bool JGGKKACMDMJ(float GBIOPJHDJOL, float GNAOPPGPMLA, out T ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x307E460", Offset = "0x307D860", VA = "0x18307E460")]
	public bool NAPFNJEFBND(float GBIOPJHDJOL, float GNAOPPGPMLA, out T ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x307E160", Offset = "0x307D560", VA = "0x18307E160")]
	public void KIILLCGJCJK(float GBIOPJHDJOL, float GNAOPPGPMLA, List<T> PEJLPPMKLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x307DA50", Offset = "0x307CE50", VA = "0x18307DA50")]
	private int HJJBCHAGPHM(int EHPOFABCFJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x307E5C0", Offset = "0x307D9C0", VA = "0x18307E5C0")]
	private void OKKICOFGLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JDBAPGGDKND();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T AHBBCBECELI(T ELCLILAGMPD, float DMDHNJAFDJJ);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CAEFLIFLPBN(T DLAEBDDDPDK, T ABKABEONAAM);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BOONALDPKDA(T DLAEBDDDPDK, T ABKABEONAAM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KPCHFOLIHIP : global::HGODODNHFPH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4032460", Offset = "0x4031860", VA = "0x184032460", Slot = "4")]
	protected override Vector3 JDBAPGGDKND()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x40322A0", Offset = "0x40316A0", VA = "0x1840322A0", Slot = "5")]
	protected override Vector3 AHBBCBECELI(Vector3 ELCLILAGMPD, float DMDHNJAFDJJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40323B0", Offset = "0x40317B0", VA = "0x1840323B0", Slot = "6")]
	protected override Vector3 CAEFLIFLPBN(Vector3 DLAEBDDDPDK, Vector3 ABKABEONAAM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4032340", Offset = "0x4031740", VA = "0x184032340", Slot = "7")]
	protected override Vector3 BOONALDPKDA(Vector3 DLAEBDDDPDK, Vector3 ABKABEONAAM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40324D0", Offset = "0x40318D0", VA = "0x1840324D0")]
	public KPCHFOLIHIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class COGIFIKNPBD
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1534EC0", Offset = "0x15342C0", VA = "0x181534EC0")]
	public static global::MCFNINDADBC<T1, T2> LFIKOCHGCKP<T1, T2>(T1 MLHPKCEEJOK, T2 AOBHJBKOOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x20F4580", Offset = "0x20F3980", VA = "0x1820F4580")]
	public static global::HKKJEOCPBHI<T1, T2, T3> LFIKOCHGCKP<T1, T2, T3>(T1 MLHPKCEEJOK, T2 AOBHJBKOOIC, T3 LKCEACLNEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27CF2A0", Offset = "0x27CE6A0", VA = "0x1827CF2A0")]
	internal static int JBNEADJFBAP(int LAECJDJPBOO, int ENHANNEFDIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x32BE630", Offset = "0x32BDA30", VA = "0x1832BE630")]
	internal static int JBNEADJFBAP(int LAECJDJPBOO, int ENHANNEFDIN, int LKBLCGGOFGA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MCFNINDADBC<T1, T2> : IComparable<global::MCFNINDADBC<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 CDPLLFALFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 DMPEPNMLDDF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF8C0", Offset = "0x1FEECC0", VA = "0x181FEF8C0")]
	public MCFNINDADBC(T1 MLHPKCEEJOK, T2 AOBHJBKOOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE080", Offset = "0x1FED480", VA = "0x181FEE080", Slot = "4")]
	public int CompareTo(global::MCFNINDADBC<T1, T2> NODHJONKKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE860", Offset = "0x1FEDC60", VA = "0x181FEE860", Slot = "0")]
	public override bool Equals(object NODHJONKKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEC10", Offset = "0x1FEE010", VA = "0x181FEEC10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF530", Offset = "0x1FEE930", VA = "0x181FEF530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HKKJEOCPBHI<T1, T2, T3> : IComparable<global::HKKJEOCPBHI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T1 CDPLLFALFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T2 DMPEPNMLDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T3 HLBFMGOFFPJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E93990", Offset = "0x2E92D90", VA = "0x182E93990")]
	public HKKJEOCPBHI(T1 MLHPKCEEJOK, T2 AOBHJBKOOIC, T3 LKCEACLNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E932B0", Offset = "0x2E926B0", VA = "0x182E932B0", Slot = "4")]
	public int CompareTo(global::HKKJEOCPBHI<T1, T2, T3> NODHJONKKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2E934A0", Offset = "0x2E928A0", VA = "0x182E934A0", Slot = "0")]
	public override bool Equals(object NODHJONKKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E936A0", Offset = "0x2E92AA0", VA = "0x182E936A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2E93710", Offset = "0x2E92B10", VA = "0x182E93710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T IGCHKCCOFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x45E610", Offset = "0x45DA10", VA = "0x18045E610")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x45B860", Offset = "0x45AC60", VA = "0x18045B860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float JABNIKNCCJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x562280", Offset = "0x561680", VA = "0x180562280")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3EBFD00", Offset = "0x3EBF100", VA = "0x183EBFD00")]
	public T KLLBIMNEEIK(float DMDHNJAFDJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3EBFB50", Offset = "0x3EBEF50", VA = "0x183EBFB50")]
	public T KFNJNLBFOBF(float DMDHNJAFDJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EMFNKGHFJCL(T DLAEBDDDPDK, T ABKABEONAAM, float DMDHNJAFDJJ);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4031710", Offset = "0x4030B10", VA = "0x184031710", Slot = "4")]
	protected override float EMFNKGHFJCL(float DLAEBDDDPDK, float ABKABEONAAM, float DMDHNJAFDJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4031790", Offset = "0x4030B90", VA = "0x184031790")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4033A70", Offset = "0x4032E70", VA = "0x184033A70", Slot = "4")]
	protected override Vector3 EMFNKGHFJCL(Vector3 DLAEBDDDPDK, Vector3 ABKABEONAAM, float DMDHNJAFDJJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4033B30", Offset = "0x4032F30", VA = "0x184033B30")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x40101B0", Offset = "0x400F5B0", VA = "0x1840101B0", Slot = "4")]
	protected override Color EMFNKGHFJCL(Color DLAEBDDDPDK, Color ABKABEONAAM, float DMDHNJAFDJJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4030890", Offset = "0x402FC90", VA = "0x184030890")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class BEKHLGGKOGD<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private global::BEKHLGGKOGD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x4B4420", Offset = "0x4B3820", VA = "0x1804B4420", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x205A050", Offset = "0x2059450", VA = "0x18205A050", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x205A590", Offset = "0x2059990", VA = "0x18205A590")]
		public Enumerator(global::BEKHLGGKOGD<T> PEJLPPMKLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2059A30", Offset = "0x2058E30", VA = "0x182059A30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2059F10", Offset = "0x2059310", VA = "0x182059F10", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2059830", Offset = "0x2058C30", VA = "0x182059830")]
		private void CGMBLGFDHDE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] NAFJFADOPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int PPACOGEHLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int KKLGLPJNOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int JGNLFPLJJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AMPKIFMGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x20564E0", Offset = "0x20558E0", VA = "0x1820564E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T CGBECAEJOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2056A90", Offset = "0x2055E90", VA = "0x182056A90")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2056A20", Offset = "0x2055E20", VA = "0x182056A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2057280", Offset = "0x2056680", VA = "0x182057280")]
	public BEKHLGGKOGD(int MFPOMLBLLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2056540", Offset = "0x2055940", VA = "0x182056540")]
	public void IKAEHHFCPPJ(T DMDHNJAFDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2056520", Offset = "0x2055920", VA = "0x182056520")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2056820", Offset = "0x2055C20", VA = "0x182056820")]
	public void IMDICNOCGPK(int FHFJLIAMIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2056240", Offset = "0x2055640", VA = "0x182056240")]
	public void CFIMLMHPAFE(T[] HBOJCEMNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2056FD0", Offset = "0x20563D0", VA = "0x182056FD0")]
	public Enumerator LMCBDBNPLGP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x20570F0", Offset = "0x20564F0", VA = "0x1820570F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x20570F0", Offset = "0x20564F0", VA = "0x1820570F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2056D00", Offset = "0x2056100", VA = "0x182056D00")]
	private int LEDMCJOLMBF(int NBHNFEGDDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x20570C0", Offset = "0x20564C0", VA = "0x1820570C0")]
	private int NPAMLFFMEEI(int NBHNFEGDDAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class GHOEGCMDEGF
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
	protected GHOEGCMDEGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class HDBPAHMKBPA<T> : GHOEGCMDEGF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	protected struct IAGOPBMEDMB
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum CGKLIHBNPEG
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public CGKLIHBNPEG ENGLKMHLBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public T MLDCBHAMEIH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int CPLAPDAFNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly bool DPNAHEJCNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	protected readonly bool OKHKMBNFDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	protected List<T> NLBHHPMECOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<IAGOPBMEDMB> LEGPIIOKHDJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OPDMGMILABB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x307CE80", Offset = "0x307C280", VA = "0x18307CE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x307D2D0", Offset = "0x307C6D0", VA = "0x18307D2D0")]
	protected HDBPAHMKBPA(bool OKHKMBNFDJG, bool DPNAHEJCNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x307D010", Offset = "0x307C410", VA = "0x18307D010")]
	protected bool JAPMEKIKOBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x307D1F0", Offset = "0x307C5F0", VA = "0x18307D1F0")]
	protected void MMEGKKOAFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x307CBA0", Offset = "0x307BFA0", VA = "0x18307CBA0")]
	protected void GNDONEMAGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x17C5770", Offset = "0x17C4B70", VA = "0x1817C5770")]
	private static void GJDGPKPFOGP<U>(ref List<U> JPAJBNDBIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x307CEC0", Offset = "0x307C2C0", VA = "0x18307CEC0", Slot = "4")]
	public void IKAEHHFCPPJ(T MLDCBHAMEIH, bool CHIBLFAOOJL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x307D0B0", Offset = "0x307C4B0", VA = "0x18307D0B0", Slot = "5")]
	public void KCCDFDIBBBL(T MLDCBHAMEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x307CD50", Offset = "0x307C150", VA = "0x18307CD50")]
	public void HFPHLCGNKJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class MLLONMNEMBP : global::HDBPAHMKBPA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4032CB0", Offset = "0x40320B0", VA = "0x184032CB0")]
	public MLLONMNEMBP(bool OKHKMBNFDJG = false, bool DPNAHEJCNLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4032AA0", Offset = "0x4031EA0", VA = "0x184032AA0")]
	public void JPMBBKBDEDN()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4032C50", Offset = "0x4032050", VA = "0x184032C50")]
	public static MLLONMNEMBP PDHNFFBJJKC(MLLONMNEMBP MICBCIJMGMA, Action MLDCBHAMEIH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4032A40", Offset = "0x4031E40", VA = "0x184032A40")]
	public static MLLONMNEMBP CKAJPLMJPGO(MLLONMNEMBP MICBCIJMGMA, Action MLDCBHAMEIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HAMMMKJPLJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKAEHHFCPPJ(Action<T> MLDCBHAMEIH, bool CHIBLFAOOJL = false);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCCDFDIBBBL(Action<T> MLDCBHAMEIH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PFLGKBBBIBL<T> : global::HDBPAHMKBPA<Action<T>>, global::HAMMMKJPLJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x16F6710", Offset = "0x16F5B10", VA = "0x1816F6710")]
	public PFLGKBBBIBL(bool OKHKMBNFDJG = false, bool DPNAHEJCNLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x369F3B0", Offset = "0x369E7B0", VA = "0x18369F3B0")]
	public void JPMBBKBDEDN(T DMDHNJAFDJJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x16F6670", Offset = "0x16F5A70", VA = "0x1816F6670")]
	public static global::PFLGKBBBIBL<T> PDHNFFBJJKC(global::PFLGKBBBIBL<T> MICBCIJMGMA, Action<T> MLDCBHAMEIH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x16F2C40", Offset = "0x16F2040", VA = "0x1816F2C40")]
	public static global::PFLGKBBBIBL<T> CKAJPLMJPGO(global::PFLGKBBBIBL<T> MICBCIJMGMA, Action<T> MLDCBHAMEIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CFMHGNNDOPJ<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GDHDMOEJPKO<T, U> : global::HDBPAHMKBPA<Action<T, U>>, global::CFMHGNNDOPJ<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x16F6710", Offset = "0x16F5B10", VA = "0x1816F6710")]
	public GDHDMOEJPKO(bool OKHKMBNFDJG = false, bool DPNAHEJCNLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x16F5500", Offset = "0x16F4900", VA = "0x1816F5500")]
	public void JPMBBKBDEDN(T DMDHNJAFDJJ, U IOEOPOOMLBN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x16F6670", Offset = "0x16F5A70", VA = "0x1816F6670")]
	public static global::GDHDMOEJPKO<T, U> PDHNFFBJJKC(global::GDHDMOEJPKO<T, U> MICBCIJMGMA, Action<T, U> MLDCBHAMEIH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x16F2C40", Offset = "0x16F2040", VA = "0x1816F2C40")]
	public static global::GDHDMOEJPKO<T, U> CKAJPLMJPGO(global::GDHDMOEJPKO<T, U> MICBCIJMGMA, Action<T, U> MLDCBHAMEIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CJIOOMKGBAO<T, U, V> : global::HDBPAHMKBPA<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x16F6710", Offset = "0x16F5B10", VA = "0x1816F6710")]
	public CJIOOMKGBAO(bool OKHKMBNFDJG = false, bool DPNAHEJCNLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x24559F0", Offset = "0x2454DF0", VA = "0x1824559F0")]
	public void JPMBBKBDEDN(T DMDHNJAFDJJ, U IOEOPOOMLBN, V LEDOAJPGBHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x16F6670", Offset = "0x16F5A70", VA = "0x1816F6670")]
	public static global::CJIOOMKGBAO<T, U, V> PDHNFFBJJKC(global::CJIOOMKGBAO<T, U, V> MICBCIJMGMA, Action<T, U, V> MLDCBHAMEIH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x16F2C40", Offset = "0x16F2040", VA = "0x1816F2C40")]
	public static global::CJIOOMKGBAO<T, U, V> CKAJPLMJPGO(global::CJIOOMKGBAO<T, U, V> MICBCIJMGMA, Action<T, U, V> MLDCBHAMEIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EJHDFJBPMGG<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class BGDCAKNFCKN<T, U, V, W> : global::HDBPAHMKBPA<Action<T, U, V, W>>, global::EJHDFJBPMGG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x16F6710", Offset = "0x16F5B10", VA = "0x1816F6710")]
	public BGDCAKNFCKN(bool OKHKMBNFDJG = false, bool DPNAHEJCNLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE8F0", Offset = "0x2EEDCF0", VA = "0x182EEE8F0")]
	public void JPMBBKBDEDN(T DMDHNJAFDJJ, U IOEOPOOMLBN, V LEDOAJPGBHP, W GCLCDDHJIMD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x16F6670", Offset = "0x16F5A70", VA = "0x1816F6670")]
	public static global::BGDCAKNFCKN<T, U, V, W> PDHNFFBJJKC(global::BGDCAKNFCKN<T, U, V, W> MICBCIJMGMA, Action<T, U, V, W> MLDCBHAMEIH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x16F2C40", Offset = "0x16F2040", VA = "0x1816F2C40")]
	public static global::BGDCAKNFCKN<T, U, V, W> CKAJPLMJPGO(global::BGDCAKNFCKN<T, U, V, W> MICBCIJMGMA, Action<T, U, V, W> MLDCBHAMEIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class CMBMFHMDFFI<T, U, V, W, X> : global::HDBPAHMKBPA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x16F6710", Offset = "0x16F5B10", VA = "0x1816F6710")]
	public CMBMFHMDFFI(bool OKHKMBNFDJG = false, bool DPNAHEJCNLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2FA1880", Offset = "0x2FA0C80", VA = "0x182FA1880")]
	public void JPMBBKBDEDN(T DMDHNJAFDJJ, U IOEOPOOMLBN, V LEDOAJPGBHP, W GCLCDDHJIMD, X MMBLLPPAIIG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x16F6670", Offset = "0x16F5A70", VA = "0x1816F6670")]
	public static global::CMBMFHMDFFI<T, U, V, W, X> PDHNFFBJJKC(global::CMBMFHMDFFI<T, U, V, W, X> MICBCIJMGMA, Action<T, U, V, W, X> MLDCBHAMEIH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x16F2C40", Offset = "0x16F2040", VA = "0x1816F2C40")]
	public static global::CMBMFHMDFFI<T, U, V, W, X> CKAJPLMJPGO(global::CMBMFHMDFFI<T, U, V, W, X> MICBCIJMGMA, Action<T, U, V, W, X> MLDCBHAMEIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class BAKFPIBJODE<T, U, V, W, X, Y> : global::HDBPAHMKBPA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x16F6710", Offset = "0x16F5B10", VA = "0x1816F6710")]
	public BAKFPIBJODE(bool OKHKMBNFDJG = false, bool DPNAHEJCNLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x20495B0", Offset = "0x20489B0", VA = "0x1820495B0")]
	public void JPMBBKBDEDN(T DMDHNJAFDJJ, U IOEOPOOMLBN, V LEDOAJPGBHP, W GCLCDDHJIMD, X MMBLLPPAIIG, Y KMPPMDDMCKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x16F6670", Offset = "0x16F5A70", VA = "0x1816F6670")]
	public static global::BAKFPIBJODE<T, U, V, W, X, Y> PDHNFFBJJKC(global::BAKFPIBJODE<T, U, V, W, X, Y> MICBCIJMGMA, Action<T, U, V, W, X, Y> MLDCBHAMEIH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x16F2C40", Offset = "0x16F2040", VA = "0x1816F2C40")]
	public static global::BAKFPIBJODE<T, U, V, W, X, Y> CKAJPLMJPGO(global::BAKFPIBJODE<T, U, V, W, X, Y> MICBCIJMGMA, Action<T, U, V, W, X, Y> MLDCBHAMEIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BNNLEEOBKPA<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool MOPFKKGDHPJ(global::BNNLEEOBKPA<T> JOOIPNKOODI);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FDOHDLPIOLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public global::BNNLEEOBKPA<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public FDOHDLPIOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2EF8400", Offset = "0x2EF7800", VA = "0x182EF8400")]
		internal bool <FindNode>b__0(global::BNNLEEOBKPA<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public T NAJCLDEJIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LinkedList<global::BNNLEEOBKPA<T>> JBNNBCEJIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public global::BNNLEEOBKPA<T> CONENAKGGEA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::BNNLEEOBKPA<T> DNFABAHMHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x477040", Offset = "0x476440", VA = "0x180477040")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2EF6C20", Offset = "0x2EF6020", VA = "0x182EF6C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DFKKDJDCLDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2EF5030", Offset = "0x2EF4430", VA = "0x182EF5030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LAHGLKPKLEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2EF5C50", Offset = "0x2EF5050", VA = "0x182EF5C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::BNNLEEOBKPA<T> JICCMNECLFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2EF6700", Offset = "0x2EF5B00", VA = "0x182EF6700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7390", Offset = "0x2EF6790", VA = "0x182EF7390")]
	public BNNLEEOBKPA(T JKPGCNDHCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2EF4E20", Offset = "0x2EF4220", VA = "0x182EF4E20")]
	public global::BNNLEEOBKPA<T> AGNPBLFCJAB(T LNINMCOAKPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5400", Offset = "0x2EF4800", VA = "0x182EF5400")]
	public global::BNNLEEOBKPA<T> CMPDONGAGBF(T IHGAGNOCGHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6E30", Offset = "0x2EF6230", VA = "0x182EF6E30")]
	public global::BNNLEEOBKPA<T> KCCDFDIBBBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2EF6780", Offset = "0x2EF5B80", VA = "0x182EF6780")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2EF5060", Offset = "0x2EF4460", VA = "0x182EF5060")]
	public global::BNNLEEOBKPA<T> CLNHFHAJFAI(T CFOJGLDOCPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2EF55D0", Offset = "0x2EF49D0", VA = "0x182EF55D0")]
	public static void DEMBLKALPPK(global::BNNLEEOBKPA<T> IIIGELHJMJJ, MOPFKKGDHPJ JLIAJAIOOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x17BA9D0", Offset = "0x17B9DD0", VA = "0x1817BA9D0")]
	public static void DEMBLKALPPK<A>(global::BNNLEEOBKPA<T> IIIGELHJMJJ, Func<global::BNNLEEOBKPA<T>, A, bool> JLIAJAIOOBA, A LICCOBEBHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2EF61F0", Offset = "0x2EF55F0", VA = "0x182EF61F0")]
	public static string FONBIGFPLFC(global::BNNLEEOBKPA<T> IIIGELHJMJJ, int DCMOCEFAPFM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2EF70E0", Offset = "0x2EF64E0", VA = "0x182EF70E0")]
	public static global::BNNLEEOBKPA<T> LPAPDKCMDFF(global::BNNLEEOBKPA<T> IIIGELHJMJJ, T ONENGFKCAOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DefaultMember("Item")]
public class ADECJFOBGGD<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate int BHKGBPIKHCD(TKey IDFIPMLKMCO, TVal ELCLILAGMPD);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class DOPLMMILBKK
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey ADIOLHMGEME
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal IGCHKCCOFHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x4F8240", Offset = "0x4F7640", VA = "0x1804F8240")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x4F83A0", Offset = "0x4F77A0", VA = "0x1804F83A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int JAPPHFBEBOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4F83B0", Offset = "0x4F77B0", VA = "0x1804F83B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4F80C0", Offset = "0x4F74C0", VA = "0x1804F80C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime LDIBFFLFBEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x4553E0", Offset = "0x4547E0", VA = "0x1804553E0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x4553A0", Offset = "0x4547A0", VA = "0x1804553A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x345DDC0", Offset = "0x345D1C0", VA = "0x18345DDC0")]
		public DOPLMMILBKK(TKey IDFIPMLKMCO, TVal BDAHFCMEKMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const int OHHKBCIANKB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly Dictionary<TKey, LinkedListNode<DOPLMMILBKK>> BNLHINLDMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly LinkedList<DOPLMMILBKK> PBMIEMPPOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BHKGBPIKHCD DOGBHLELGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly TimeSpan LCIPLDKCIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly FJEBFCDHOFE KGKCMNAJOEA;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int PNFJADIDPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x47A390", Offset = "0x479790", VA = "0x18047A390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool GDONFFGNBMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3450EF0", Offset = "0x34502F0", VA = "0x183450EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int EEJDDHEFPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x565610", Offset = "0x564A10", VA = "0x180565610")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x565880", Offset = "0x564C80", VA = "0x180565880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey CGBECAEJOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3451600", Offset = "0x3450A00", VA = "0x183451600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3451FA0", Offset = "0x34513A0", VA = "0x183451FA0")]
	public ADECJFOBGGD(int MFPOMLBLLBN, [Optional] BHKGBPIKHCD DOGBHLELGFN, [Optional] IEqualityComparer<TKey> CFOIDJAPPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3451CB0", Offset = "0x34510B0", VA = "0x183451CB0")]
	public ADECJFOBGGD(int MFPOMLBLLBN, BHKGBPIKHCD DOGBHLELGFN, TimeSpan LCIPLDKCIMM, [Optional] IEqualityComparer<TKey> CFOIDJAPPMP, [Optional] FJEBFCDHOFE KGKCMNAJOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3451930", Offset = "0x3450D30", VA = "0x183451930")]
	public void PIBKOGDEPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3451540", Offset = "0x3450940", VA = "0x183451540")]
	public void JFOMDNCKGDL(TKey IDFIPMLKMCO, TVal ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3451630", Offset = "0x3450A30", VA = "0x183451630")]
	public bool KCCDFDIBBBL(TKey IDFIPMLKMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x34505D0", Offset = "0x344F9D0", VA = "0x1834505D0")]
	public bool AJFKIGLDKOK(TKey PBCBOJHBCHP, out TVal ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3450E70", Offset = "0x3450270", VA = "0x183450E70")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x34517B0", Offset = "0x3450BB0", VA = "0x1834517B0")]
	private bool LANJGLOGLHG(DOPLMMILBKK LFGEODKKJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3450F80", Offset = "0x3450380", VA = "0x183450F80")]
	private void JDDFFLDOKGC(LinkedListNode<DOPLMMILBKK> BEPNLCPHLBL, TVal FFDPLJGPGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3450720", Offset = "0x344FB20", VA = "0x183450720")]
	private void CMJDONAKHEO(TKey IDFIPMLKMCO, TVal ELCLILAGMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3450B30", Offset = "0x344FF30", VA = "0x183450B30")]
	private void DDBGOELAGLA(DOPLMMILBKK LFGEODKKJPA, TVal FFDPLJGPGOC, int EJLJEMCFIFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class DJPJIDJHKFO<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly List<T> JPAJBNDBIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private HashSet<T> AEMOFFKNGGI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AMPKIFMGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1133E20", Offset = "0x1133220", VA = "0x181133E20", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool BHOOGIICNBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x456CA0", Offset = "0x4560A0", VA = "0x180456CA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T CGBECAEJOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x24EAB40", Offset = "0x24E9F40", VA = "0x1824EAB40", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C82AE0", Offset = "0x2C81EE0", VA = "0x182C82AE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1CD84A0", Offset = "0x1CD78A0", VA = "0x181CD84A0", Slot = "11")]
	public void Add(T DIPIFECJPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2C823F0", Offset = "0x2C817F0", VA = "0x182C823F0")]
	public bool AGLNOEONDLP(T DIPIFECJPJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C82990", Offset = "0x2C81D90", VA = "0x182C82990", Slot = "15")]
	public bool Remove(T DIPIFECJPJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x16EF5F0", Offset = "0x16EE9F0", VA = "0x1816EF5F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x184F9D0", Offset = "0x184EDD0", VA = "0x18184F9D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C82540", Offset = "0x2C81940", VA = "0x182C82540", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1CD2D40", Offset = "0x1CD2140", VA = "0x181CD2D40", Slot = "13")]
	public bool Contains(T DIPIFECJPJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C825A0", Offset = "0x2C819A0", VA = "0x182C825A0", Slot = "14")]
	public void CopyTo(T[] HBOJCEMNMGN, int HIGPBBEBFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1FED490", Offset = "0x1FEC890", VA = "0x181FED490", Slot = "6")]
	public int IndexOf(T DIPIFECJPJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C826A0", Offset = "0x2C81AA0", VA = "0x182C826A0", Slot = "7")]
	public void Insert(int NBHNFEGDDAF, T DIPIFECJPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C82830", Offset = "0x2C81C30", VA = "0x182C82830", Slot = "8")]
	public void RemoveAt(int NBHNFEGDDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C82A10", Offset = "0x2C81E10", VA = "0x182C82A10")]
	public DJPJIDJHKFO()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3985A90", Offset = "0x3984E90", VA = "0x183985A90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4033A40", Offset = "0x4032E40", VA = "0x184033A40")]
		public SerializedGuid(in Guid PEBFODPOHLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4033900", Offset = "0x4032D00", VA = "0x184033900")]
		public static SerializedGuid NHHAJGEKIIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4033870", Offset = "0x4032C70", VA = "0x184033870")]
		public static SerializedGuid GPDBHCBPMHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4033630", Offset = "0x4032A30", VA = "0x184033630")]
		public bool CIDBHDCEPLO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4033A20", Offset = "0x4032E20", VA = "0x184033A20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4033980", Offset = "0x4032D80", VA = "0x184033980", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x40336F0", Offset = "0x4032AF0", VA = "0x1840336F0", Slot = "7")]
		public bool Equals(SerializedGuid NODHJONKKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4033790", Offset = "0x4032B90", VA = "0x184033790", Slot = "0")]
		public override bool Equals(object HLLMFMGFIPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x40338F0", Offset = "0x4032CF0", VA = "0x1840338F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x40336C0", Offset = "0x4032AC0", VA = "0x1840336C0", Slot = "6")]
		public int CompareTo(SerializedGuid NODHJONKKEO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class OGKINHNFPLJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly Type DKDJGHPHJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string HHNIHBIECCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool JOEIODENDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool BBNNOLNNMKN;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4033370", Offset = "0x4032770", VA = "0x184033370")]
	public OGKINHNFPLJ(Type HFHJMFLAEAC, string LGPGEDAOHEH, bool IFKIDGPGBKF = false, bool MAAOFJJDNEE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface PGAHGBDMDHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T IGCHKCCOFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool NKPKLJMFBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::PGAHGBDMDHA<T> GECFKOJCBOI(Action<T> KLACKBEHDHJ);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::PGAHGBDMDHA<T> GEJHPOGEICH(Action<T> KLACKBEHDHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NIEANHBMKKB<T> : global::PGAHGBDMDHA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private global::GDHDMOEJPKO<T, T> GDBDKEOPGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private global::PFLGKBBBIBL<T> CEFDEJABNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private global::PFLGKBBBIBL<string> AFNIICLOIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private string KBFLGMGIPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private T JBNMPONKACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool AKBEADCFEJN;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T IGCHKCCOFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x45E610", Offset = "0x45DA10", VA = "0x18045E610", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x16BDD00", Offset = "0x16BD100", VA = "0x1816BDD00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool NKPKLJMFBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4EFE80", Offset = "0x4EF280", VA = "0x1804EFE80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x32ED990", Offset = "0x32ECD90", VA = "0x1832ED990")]
	private void GEOPKJHFLGK(T BLEFCLFINGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x32ED8E0", Offset = "0x32ECCE0", VA = "0x1832ED8E0", Slot = "4")]
	public global::PGAHGBDMDHA<T> GECFKOJCBOI(Action<T> MGLHIFIJHAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x32ED960", Offset = "0x32ECD60", VA = "0x1832ED960", Slot = "5")]
	public global::PGAHGBDMDHA<T> GEJHPOGEICH(Action<T> KLACKBEHDHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x32EDA10", Offset = "0x32ECE10", VA = "0x1832EDA10")]
	public NIEANHBMKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DDHHAPONHFC
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KFEKBCFKPLK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public global::PGAHGBDMDHA<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public global::DMMMIOPAMGD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public KFEKBCFKPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2C85CB0", Offset = "0x2C850B0", VA = "0x182C85CB0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1C9F7A0", Offset = "0x1C9EBA0", VA = "0x181C9F7A0")]
	public static global::KCBHFPPLLKO<T> JHJPDFMEJGP<T>(this global::PGAHGBDMDHA<T> IDJHAEGHFNM, Action<T> MCNIGODLGGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public abstract class FJEBFCDHOFE
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private class GCEEDLLBBCC : FJEBFCDHOFE
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static FJEBFCDHOFE EELIJCAPGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4031820", Offset = "0x4030C20", VA = "0x184031820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime EBIDEFOCPOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x40317D0", Offset = "0x4030BD0", VA = "0x1840317D0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4031910", Offset = "0x4030D10", VA = "0x184031910")]
		public GCEEDLLBBCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static FJEBFCDHOFE NJAMDJIGFIA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static FJEBFCDHOFE LMLLPIIMPII
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x40308D0", Offset = "0x402FCD0", VA = "0x1840308D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime EBIDEFOCPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
	protected FJEBFCDHOFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class FNCKLJPJKIB : global::KNCPAEBIINN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x40316D0", Offset = "0x4030AD0", VA = "0x1840316D0")]
	public FNCKLJPJKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KNCPAEBIINN<T> : global::ONICLGIKPEA<T>, FLGIPAFJBLD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> IODAFHNFIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::KCBHFPPLLKO<T> OAFNOIEOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private GMANCKGDIIA PCEOABEIPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x11317E0", Offset = "0x1130BE0", VA = "0x1811317E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2106B80", Offset = "0x2105F80", VA = "0x182106B80")]
	public KNCPAEBIINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GFKILOICABH<T> : global::ONICLGIKPEA<T>, FLGIPAFJBLD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> IODAFHNFIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::KCBHFPPLLKO<T> OAFNOIEOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private GMANCKGDIIA PCEOABEIPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x11317E0", Offset = "0x1130BE0", VA = "0x1811317E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x16F6810", Offset = "0x16F5C10", VA = "0x1816F6810")]
	public GFKILOICABH(Exception BNNOFOEFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FLGIPAFJBLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	GMANCKGDIIA OAFNOIEOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ONICLGIKPEA<T> : FLGIPAFJBLD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> IODAFHNFIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::KCBHFPPLLKO<T> OAFNOIEOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class ACCIBJFFLAM<TTask, T> : global::ONICLGIKPEA<T>, FLGIPAFJBLD, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HHNOJIGLHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public global::ACCIBJFFLAM<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public HHNOJIGLHLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class JIHGACECJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public HHNOJIGLHLE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		public JIHGACECJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x345EF70", Offset = "0x345E370", VA = "0x18345EF70")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static bool IJKAAFANCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly global::DMMMIOPAMGD<T> KBLHHMHMNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Task<T> LKHNANAPIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly CancellationTokenSource JLDEDJEBJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool DNMIJNLAGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private SynchronizationContext OADFFFGIIIN;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> IODAFHNFIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4480B0", Offset = "0x4474B0", VA = "0x1804480B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::KCBHFPPLLKO<T> OAFNOIEOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private GMANCKGDIIA PCEOABEIPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OLBDPDJKIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x518400", Offset = "0x517800", VA = "0x180518400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x344EAC0", Offset = "0x344DEC0", VA = "0x18344EAC0")]
	static ACCIBJFFLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x344EE80", Offset = "0x344E280", VA = "0x18344EE80")]
	protected ACCIBJFFLAM(TTask LKHNANAPIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x344E3A0", Offset = "0x344D7A0", VA = "0x18344E3A0", Slot = "1")]
	~ACCIBJFFLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x344E370", Offset = "0x344D770", VA = "0x18344E370", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x344E760", Offset = "0x344DB60", VA = "0x18344E760")]
	private void OCOMLAAOFCK(bool GPGNGLLDJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T NLIGNMBGDCP(TTask IICEMBOFCPB);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void IFBANIFDHDM();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x344E4E0", Offset = "0x344D8E0", VA = "0x18344E4E0")]
	protected void NBCNBMMAPEI(T BLEFCLFINGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x344E8D0", Offset = "0x344DCD0", VA = "0x18344E8D0")]
	protected void PMLEAGIHOMP(string KBFLGMGIPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x344E2D0", Offset = "0x344D6D0", VA = "0x18344E2D0")]
	[CompilerGenerated]
	private void APKFKFDCDON(object GFOHJOKHOPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class DFNPMCIFPKL<T> : IEnumerable<global::DFNPMCIFPKL<T>.GMOAEJEHMKE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct GMOAEJEHMKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public T ELCLILAGMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int NBHNFEGDDAF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class NMILFAGOGMP : IEnumerator<GMOAEJEHMKE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private global::DFNPMCIFPKL<T> NKMMICAMHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int NBHNFEGDDAF;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x20C0420", Offset = "0x20BF820", VA = "0x1820C0420", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public GMOAEJEHMKE PGABEPGDOIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x2C862D0", Offset = "0x2C856D0", VA = "0x182C862D0", Slot = "4")]
			get
			{
				return default(GMOAEJEHMKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x173EAF0", Offset = "0x173DEF0", VA = "0x18173EAF0")]
		public NMILFAGOGMP(global::DFNPMCIFPKL<T> NKMMICAMHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2C86240", Offset = "0x2C85640", VA = "0x182C86240", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xD8E3D0", Offset = "0xD8D7D0", VA = "0x180D8E3D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xE1C6B0", Offset = "0xE1BAB0", VA = "0x180E1C6B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private struct MHIKHPOMJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public bool LCGALJJPENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public T ELCLILAGMPD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private const int HCEJKLNPAAI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Dictionary<T, int> GHKIACLNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private MHIKHPOMJAL[] MHPAJIDMJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private int HMJNCNFJBCC;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int AMPKIFMGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2C80690", Offset = "0x2C7FA90", VA = "0x182C80690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2C80780", Offset = "0x2C7FB80", VA = "0x182C80780")]
	public static global::DFNPMCIFPKL<T> PAALJBPIFFF(GMOAEJEHMKE[] OEKNGCDJMBL, bool KPPPNPPIDGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2C80BB0", Offset = "0x2C7FFB0", VA = "0x182C80BB0")]
	public DFNPMCIFPKL(int MFPOMLBLLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2C80730", Offset = "0x2C7FB30", VA = "0x182C80730")]
	public int MNAFOAHOKLA(T ELCLILAGMPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2C806C0", Offset = "0x2C7FAC0", VA = "0x182C806C0")]
	public T JHJPDFMEJGP(int NBHNFEGDDAF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2C804E0", Offset = "0x2C7F8E0", VA = "0x182C804E0")]
	public bool AGLNOEONDLP(T ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2C80310", Offset = "0x2C7F710", VA = "0x182C80310")]
	public bool AGLNOEONDLP(T ELCLILAGMPD, int NBHNFEGDDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2C80550", Offset = "0x2C7F950", VA = "0x182C80550")]
	public GMOAEJEHMKE[] FJIDBHFDELC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2C80500", Offset = "0x2C7F900", VA = "0x182C80500")]
	private int CGMKGPPKPHN(int PPACOGEHLIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2C80B40", Offset = "0x2C7FF40", VA = "0x182C80B40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2C80B40", Offset = "0x2C7FF40", VA = "0x182C80B40", Slot = "4")]
	private IEnumerator<GMOAEJEHMKE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class DJPEAMFNOKE<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<T> COHAEEBPFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<T> NHBNIJKDLEI;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2C82260", Offset = "0x2C81660", VA = "0x182C82260")]
	public DJPEAMFNOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2C82290", Offset = "0x2C81690", VA = "0x182C82290")]
	public DJPEAMFNOKE(int MFPOMLBLLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2C82160", Offset = "0x2C81560", VA = "0x182C82160")]
	public T PNAMHFODIIC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2C82040", Offset = "0x2C81440", VA = "0x182C82040")]
	public void KIAAAGGDGKC(T IEBAAFEJPBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class IFFCKLOOHHB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	protected struct FEIOCOEBPDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T IGCHKCCOFHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int HAFGKNJLBLL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected readonly List<FEIOCOEBPDC> NAFJFADOPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private T NPJEIKNJHIF;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int AMPKIFMGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x1133E20", Offset = "0x1133220", VA = "0x181133E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3386D10", Offset = "0x3386110", VA = "0x183386D10")]
	public bool OJOJJIOLEMD(T ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3386AE0", Offset = "0x3385EE0", VA = "0x183386AE0")]
	public void IKAEHHFCPPJ(T ELCLILAGMPD, int JJFKODFJFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3386B60", Offset = "0x3385F60", VA = "0x183386B60")]
	public bool KCCDFDIBBBL(T ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3386A80", Offset = "0x3385E80", VA = "0x183386A80")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3386C80", Offset = "0x3386080", VA = "0x183386C80")]
	public T MHADHIPKEKC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3386870", Offset = "0x3385C70", VA = "0x183386870")]
	private void ELBJBBOMGML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3386F60", Offset = "0x3386360", VA = "0x183386F60")]
	public IFFCKLOOHHB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1143630", Offset = "0x1142A30", VA = "0x181143630", Slot = "4")]
		public virtual T EKHCEJFAIEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1131E10", Offset = "0x1131210", VA = "0x181131E10")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FKCLFCCPIGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<byte, LPNPJLMHOJB> HDONHOHADEN;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LPNPJLMHOJB IEKINDOLCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4B5750", Offset = "0x4B4B50", VA = "0x1804B5750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x472460", Offset = "0x471860", VA = "0x180472460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 FMCLILJBJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB80", Offset = "0xEA9F80", VA = "0x180EAAB80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x16C2F40", Offset = "0x16C2340", VA = "0x1816C2F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector2 GCAMHPJAMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xB3FC40", Offset = "0xB3F040", VA = "0x180B3FC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 KBMFAMLLPKG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2E39AE0", Offset = "0x2E38EE0", VA = "0x182E39AE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2E39B00", Offset = "0x2E38F00", VA = "0x182E39B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int NHPBKGPNIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4DF7E0", Offset = "0x4DEBE0", VA = "0x1804DF7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4DF800", Offset = "0x4DEC00", VA = "0x1804DF800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x40311E0", Offset = "0x40305E0", VA = "0x1840311E0")]
	public FKCLFCCPIGG(Bounds IPPOIMNJFKL, Vector2[] KHEMEKNLDIA, int GPNLHAKDJCO, byte PPACOGEHLIC, float GOGJKINPMKG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4031160", Offset = "0x4030560", VA = "0x184031160")]
	public LPNPJLMHOJB ILLCPMOMJFD(byte NBHNFEGDDAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4030B60", Offset = "0x402FF60", VA = "0x184030B60")]
	public void BHLCLIDMFNB(Vector3 MCGEJBMPCCF, float LKOOCMCNPMD, float NHHJNJNJGIM, ref List<byte> PBODHAJICIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x40311C0", Offset = "0x40305C0", VA = "0x1840311C0")]
	public void MLBLLHAGIHO(LPNPJLMHOJB.LKOADOGAFJH CPMMDLCGEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4030A40", Offset = "0x402FE40", VA = "0x184030A40")]
	private LPNPJLMHOJB ANMHGNFFIIA(byte NBHNFEGDDAF, LPNPJLMHOJB.DICHAAPMELF DPAPGDHHBCP, LPNPJLMHOJB GOLJDAHPMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4030C40", Offset = "0x4030040", VA = "0x184030C40")]
	private void FPAKLADPGFD(LPNPJLMHOJB GOLJDAHPMAF, Vector2[] KHEMEKNLDIA, int DFBOBFAJOAN, int AIJBMEMOIJC, int PEMJHDOBJJF, int JJLKBLGCOHD, float GOGJKINPMKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class LPNPJLMHOJB
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum DICHAAPMELF
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum LKOADOGAFJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public byte PALEOFHBJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Vector3 DKIHFKPANAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Vector3 JAPPHFBEBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 BOMFMFPACFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Vector3 FEFCHAAJIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public DICHAAPMELF NOPJICEDHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public LPNPJLMHOJB DNFABAHMHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public List<LPNPJLMHOJB> AAANFPNGJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public bool OBELMBPLEBO;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x40328F0", Offset = "0x4031CF0", VA = "0x1840328F0")]
	public LPNPJLMHOJB(byte GLOEJNOCKGC, DICHAAPMELF DPAPGDHHBCP, LPNPJLMHOJB GOLJDAHPMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4032530", Offset = "0x4031930", VA = "0x184032530")]
	public void AGNPBLFCJAB(LPNPJLMHOJB DNGLHAMGLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110")]
	public void MLBLLHAGIHO(int FEPEKCNHHLH, LKOADOGAFJH CPMMDLCGEKF, int FLOPOINAGGA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x40325C0", Offset = "0x40319C0", VA = "0x1840325C0")]
	public void BHLCLIDMFNB(List<byte> PBODHAJICIH, Vector3 MCGEJBMPCCF, float LKOOCMCNPMD, float NHHJNJNJGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x4032850", Offset = "0x4031C50", VA = "0x184032850")]
	public bool JINAHMKKFBE(Vector3 PKEEGKDNOBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x40328B0", Offset = "0x4031CB0", VA = "0x1840328B0")]
	public bool NLIPCPAJADK(Vector3 PKEEGKDNOBD, float IHGGJBIFFNK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class PJHIJHLLLMI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int MFPOMLBLLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int IKIEPOBBADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private List<T> MPKPFFMAFKE;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public T LNPAJCAKNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x36A0EE0", Offset = "0x36A02E0", VA = "0x1836A0EE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T ONFOAIFPLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x36A10B0", Offset = "0x36A04B0", VA = "0x1836A10B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T HPNONABEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x36A0E20", Offset = "0x36A0220", VA = "0x1836A0E20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x36A13D0", Offset = "0x36A07D0", VA = "0x1836A13D0")]
	public PJHIJHLLLMI(int MFPOMLBLLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x36A1280", Offset = "0x36A0680", VA = "0x1836A1280")]
	public void IKAEHHFCPPJ(T EIPIGDBPLPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x36A1000", Offset = "0x36A0400", VA = "0x1836A1000")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x36A10F0", Offset = "0x36A04F0", VA = "0x1836A10F0")]
	public void HKIGBHHMDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x36A13C0", Offset = "0x36A07C0", VA = "0x1836A13C0")]
	public void MELHJPKOPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class ECOLCHDIFKP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct GADEGIOAKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int HAFGKNJLBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public T IGCHKCCOFHI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Dictionary<object, GADEGIOAKOC> OIMABFLKNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private T PHDGHEOKJLE;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T NEPDMFNLKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xEAAB80", Offset = "0xEA9F80", VA = "0x180EAAB80", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x16C2F40", Offset = "0x16C2340", VA = "0x1816C2F40", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool PBKMNABGMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x16C3CC0", Offset = "0x16C30C0", VA = "0x1816C3CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object NDJDMJLEPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4553E0", Offset = "0x4547E0", VA = "0x1804553E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4553A0", Offset = "0x4547A0", VA = "0x1804553A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x16C3800", Offset = "0x16C2C00", VA = "0x1816C3800")]
	public bool CMJDONAKHEO(T ELCLILAGMPD, object FCBCFMOCHKO, int JJFKODFJFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x16C3CF0", Offset = "0x16C30F0", VA = "0x1816C3CF0")]
	public bool ONMCKMMNGFI(object FCBCFMOCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x16C3370", Offset = "0x16C2770", VA = "0x1816C3370")]
	public bool AJFKIGLDKOK(object FCBCFMOCHKO, out T ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x16C3C90", Offset = "0x16C3090", VA = "0x1816C3C90")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x16BF820", Offset = "0x16BEC20", VA = "0x1816BF820")]
	private bool ABNHFHPOFGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x16C3D60", Offset = "0x16C3160", VA = "0x1816C3D60")]
	public ECOLCHDIFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class PCMBFBIIDMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Dictionary<object, float> OIMABFLKNOP;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float KMHIEFFKNME
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BA0", Offset = "0x6A2FA0", VA = "0x1806A3BA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7627B0", Offset = "0x761BB0", VA = "0x1807627B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x40333D0", Offset = "0x40327D0", VA = "0x1840333D0")]
	public void CMJDONAKHEO(float ELCLILAGMPD, object FCBCFMOCHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4033560", Offset = "0x4032960", VA = "0x184033560")]
	public void ONMCKMMNGFI(object FCBCFMOCHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4033440", Offset = "0x4032840", VA = "0x184033440")]
	private void GDDCJAPIMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x40335C0", Offset = "0x40329C0", VA = "0x1840335C0")]
	public PCMBFBIIDMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class HJINJKDFNGN
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class MIMCJCIGOLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly string DKDMPBKIOEO;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
		private MIMCJCIGOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4B5760", Offset = "0x4B4B60", VA = "0x1804B5760")]
		public MIMCJCIGOLM(string DKDMPBKIOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x40329F0", Offset = "0x4031DF0", VA = "0x1840329F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MCGAGPBHAGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x448150", Offset = "0x447550", VA = "0x180448150")]
		public MCGAGPBHAGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4032940", Offset = "0x4031D40", VA = "0x184032940")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly HashSet<object> MFJECKEPJIF;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool DLMPJINIBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x40320A0", Offset = "0x40314A0", VA = "0x1840320A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4031F80", Offset = "0x4031380", VA = "0x184031F80")]
	public void IKAEHHFCPPJ(object FCBCFMOCHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4031FE0", Offset = "0x40313E0", VA = "0x184031FE0")]
	public void KCCDFDIBBBL(object FCBCFMOCHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4032040", Offset = "0x4031440", VA = "0x184032040")]
	public bool OJOJJIOLEMD(object FCBCFMOCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4031F30", Offset = "0x4031330", VA = "0x184031F30")]
	public void HILHOOPEDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x40320E0", Offset = "0x40314E0", VA = "0x1840320E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4032240", Offset = "0x4031640", VA = "0x184032240")]
	public HJINJKDFNGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class DCBMHJCEHLH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private struct LHGJEJMIBDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float NPFEFKJEJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public T IGCHKCCOFHI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<object, LHGJEJMIBDF> OIMABFLKNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private T LLMOAEJGPGJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T FFBPLFCDAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xBFB360", Offset = "0xBFA760", VA = "0x180BFB360", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x16C2F70", Offset = "0x16C2370", VA = "0x1816C2F70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object KMGLAFOKLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x45E610", Offset = "0x45DA10", VA = "0x18045E610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x45B860", Offset = "0x45AC60", VA = "0x18045B860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool PBKMNABGMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2C7E840", Offset = "0x2C7DC40", VA = "0x182C7E840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E380", Offset = "0x2C7D780", VA = "0x182C7E380")]
	public bool CMJDONAKHEO(T ELCLILAGMPD, object FCBCFMOCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E880", Offset = "0x2C7DC80", VA = "0x182C7E880")]
	public bool ONMCKMMNGFI(object FCBCFMOCHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x16C3C90", Offset = "0x16C3090", VA = "0x1816C3C90")]
	public void HFPHLCGNKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DE70", Offset = "0x2C7D270", VA = "0x182C7DE70")]
	public bool AJFKIGLDKOK(object FCBCFMOCHKO, out T ELCLILAGMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D3D0", Offset = "0x2C7C7D0", VA = "0x182C7D3D0")]
	private bool ABNHFHPOFGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E8E0", Offset = "0x2C7DCE0", VA = "0x182C7E8E0")]
	public DCBMHJCEHLH()
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
