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
public class GJEBLPANPPB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x595A10", Offset = "0x594C10", VA = "0x180595A10")]
	public GJEBLPANPPB()
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
		[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x449E60", Offset = "0x449060", VA = "0x180449E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x449450", Offset = "0x448650", VA = "0x180449450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "4")]
	public virtual void PLHEOMLMOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
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
	[GJEBLPANPPB]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x318E4C0", Offset = "0x318D6C0", VA = "0x18318E4C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x318E000", Offset = "0x318D200", VA = "0x18318E000", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x318EAC0", Offset = "0x318DCC0", VA = "0x18318EAC0")]
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
	private sealed class JNAODEILDKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public JNAODEILDKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2197A20", Offset = "0x2196C20", VA = "0x182197A20")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[GJEBLPANPPB]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2196380", Offset = "0x2195580", VA = "0x182196380", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x21963B0", Offset = "0x21955B0", VA = "0x1821963B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x21962D0", Offset = "0x21954D0", VA = "0x1821962D0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey KPLFFOGJEBN]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2196300", Offset = "0x2195500", VA = "0x182196300", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x21961E0", Offset = "0x21953E0", VA = "0x1821961E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2195A50", Offset = "0x2194C50", VA = "0x182195A50", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x21953C0", Offset = "0x21945C0", VA = "0x1821953C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2194FC0", Offset = "0x21941C0", VA = "0x182194FC0", Slot = "14")]
	protected virtual string MEOBPCINACO(TKeyVal OMCDBPNABIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2194F00", Offset = "0x2194100", VA = "0x182194F00", Slot = "4")]
	public bool ContainsKey(TKey KPLFFOGJEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21960E0", Offset = "0x21952E0", VA = "0x1821960E0", Slot = "5")]
	public bool TryGetValue(TKey KPLFFOGJEBN, out TVal DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2194F30", Offset = "0x2194130", VA = "0x182194F30", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2194F30", Offset = "0x2194130", VA = "0x182194F30", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2196110", Offset = "0x2195310", VA = "0x182196110")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HNJLNAIDHHC : IEnumerator<object>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x627DE0", Offset = "0x626FE0", VA = "0x180627DE0")]
		[DebuggerHidden]
		public HNJLNAIDHHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x409D650", Offset = "0x409C850", VA = "0x18409D650", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x409D500", Offset = "0x409C700", VA = "0x18409D500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x409D6C0", Offset = "0x409C8C0", VA = "0x18409D6C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x409D600", Offset = "0x409C800", VA = "0x18409D600", Slot = "8")]
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
	private static HashSet<GameObject> LENDMKAJKAG;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static HashSet<UnityEngine.Object> BHDBGJAKENF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x409D290", Offset = "0x409C490", VA = "0x18409D290")]
	public static void RegisterDontDestroyOnLoad(GameObject AAHEJJAIDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x409D330", Offset = "0x409C530", VA = "0x18409D330")]
	public static void RegisterHideFlagsDontSaveObejct(UnityEngine.Object LBCPAPMBFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x409CF40", Offset = "0x409C140", VA = "0x18409CF40", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x409D3B0", Offset = "0x409C5B0", VA = "0x18409D3B0")]
	[IteratorStateMachine(typeof(HNJLNAIDHHC))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "6")]
	protected virtual void ENFOMHHDCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x409D4A0", Offset = "0x409C6A0", VA = "0x18409D4A0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GJFOOIFOIIM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2106290", Offset = "0x2105490", VA = "0x182106290")]
	public static void KDIFMLHGFNA<T>(this T JOKPACJLGPE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x409CE10", Offset = "0x409C010", VA = "0x18409CE10")]
	public static void KDIFMLHGFNA(this GameObject MJANMHEBNKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : MonoBehaviour where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static TImpl EBGEKJODCFM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected static TImpl PBJALEFDLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDBC710", Offset = "0xDBB910", VA = "0x180DBC710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA4C0", Offset = "0x2EE96C0", VA = "0x182EEA4C0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA990", Offset = "0x2EE9B90", VA = "0x182EEA990", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x21963E0", Offset = "0x21955E0", VA = "0x1821963E0")]
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
	public GameObject PNHJCEOAEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x103A930", Offset = "0x1039B30", VA = "0x18103A930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x409E220", Offset = "0x409D420", VA = "0x18409E220")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x409E440", Offset = "0x409D640", VA = "0x18409E440")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4B6B60", Offset = "0x4B5D60", VA = "0x1804B6B60")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static T EBGEKJODCFM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static T PBJALEFDLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xDBC710", Offset = "0xDBB910", VA = "0x180DBC710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool GBGNMJCIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x318F9A0", Offset = "0x318EBA0", VA = "0x18318F9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x318F460", Offset = "0x318E660", VA = "0x18318F460", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x318F7E0", Offset = "0x318E9E0", VA = "0x18318F7E0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x21963E0", Offset = "0x21955E0", VA = "0x1821963E0")]
	public SingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IKLNBNBEHIK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class LKMJDFFDIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public LKMJDFFDIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x36C5200", Offset = "0x36C4400", VA = "0x1836C5200")]
		internal bool <GetSamples>b__0(global::AOFBLJDNDEO<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float BKIMICKAIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float KBJEJMGEOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<global::AOFBLJDNDEO<float, T>> EMJLLIADAKN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int NEEDKKKLKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x36C2870", Offset = "0x36C1A70", VA = "0x1836C2870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x36C3010", Offset = "0x36C2210", VA = "0x1836C3010")]
	public IKLNBNBEHIK(float FHAMBIHJFMD, float APLDBEKKOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36C2690", Offset = "0x36C1890", VA = "0x1836C2690")]
	public bool JBNACOJAJGJ(float NKHOKGGOHMI, T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x36C2C20", Offset = "0x36C1E20", VA = "0x1836C2C20")]
	public IEnumerable<T> LDOJDIFHLAK(float NKHOKGGOHMI, [Optional] float? BMNENLFEJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x36C2500", Offset = "0x36C1700", VA = "0x1836C2500")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36C2F50", Offset = "0x36C2150", VA = "0x1836C2F50")]
	private void LJKNFMBOANE(float NKHOKGGOHMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class FJJNGGDCDEL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct OCCFNDEJAGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public T NMGCHANKNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public float PEFNIAHHMDE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static float MLKIILCMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private List<T> JEIJDCMEDHN;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private const int KPLBAFINICJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private OCCFNDEJAGP[] OBEKMDCFBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int BGEIKDLPBHI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float CFFHDFOAOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x61FFA0", Offset = "0x61F1A0", VA = "0x18061FFA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x620080", Offset = "0x61F280", VA = "0x180620080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2B51A00", Offset = "0x2B50C00", VA = "0x182B51A00")]
	public FJJNGGDCDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2B51930", Offset = "0x2B50B30", VA = "0x182B51930")]
	public FJJNGGDCDEL(int LMCPNDFGEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B51810", Offset = "0x2B50A10", VA = "0x182B51810")]
	public void OAGNENAKIKD(float NKHOKGGOHMI, T DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B50FE0", Offset = "0x2B501E0", VA = "0x182B50FE0")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B50CE0", Offset = "0x2B4FEE0", VA = "0x182B50CE0")]
	public bool DCLJLJHIHFM(float NPMPGFDNGOJ, float KHFHIBDLKNJ, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2B51420", Offset = "0x2B50620", VA = "0x182B51420")]
	public bool NPFOIMIKHLE(float NPMPGFDNGOJ, float KHFHIBDLKNJ, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B51130", Offset = "0x2B50330", VA = "0x182B51130")]
	public void FIPJKCLBHPE(float NPMPGFDNGOJ, float KHFHIBDLKNJ, List<T> MMHBGLAEGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B50A90", Offset = "0x2B4FC90", VA = "0x182B50A90")]
	private int BDIIKLJGEPA(int PCKMBBPGBHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B513E0", Offset = "0x2B505E0", VA = "0x182B513E0")]
	private void NIECPGLFLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BLPHPHFDKAP();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T IEJLIGOLGLB(T DIDEMEECIEC, float EAJMLGJNCKN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T FEMMHAALNND(T GEDCCIPGINO, T HBHGMAMLFGI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T PKGAOFIMBPJ(T GEDCCIPGINO, T HBHGMAMLFGI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GCMCGCHFLOF : global::FJJNGGDCDEL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x409CB80", Offset = "0x409BD80", VA = "0x18409CB80", Slot = "4")]
	protected override Vector3 BLPHPHFDKAP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x409CCA0", Offset = "0x409BEA0", VA = "0x18409CCA0", Slot = "5")]
	protected override Vector3 IEJLIGOLGLB(Vector3 DIDEMEECIEC, float EAJMLGJNCKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x409CBF0", Offset = "0x409BDF0", VA = "0x18409CBF0", Slot = "6")]
	protected override Vector3 FEMMHAALNND(Vector3 GEDCCIPGINO, Vector3 HBHGMAMLFGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x409CD40", Offset = "0x409BF40", VA = "0x18409CD40", Slot = "7")]
	protected override Vector3 PKGAOFIMBPJ(Vector3 GEDCCIPGINO, Vector3 HBHGMAMLFGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x409CDB0", Offset = "0x409BFB0", VA = "0x18409CDB0")]
	public GCMCGCHFLOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JPIAGLCOGNJ
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x206EC80", Offset = "0x206DE80", VA = "0x18206EC80")]
	public static global::AOFBLJDNDEO<T1, T2> BAHAJJMALOP<T1, T2>(T1 CGJJGNKDFMD, T2 MLBFPNHBDFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x253D4C0", Offset = "0x253C6C0", VA = "0x18253D4C0")]
	public static global::KIFDKCKPDCM<T1, T2, T3> BAHAJJMALOP<T1, T2, T3>(T1 CGJJGNKDFMD, T2 MLBFPNHBDFF, T3 PDGHFNOBNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xBDFD90", Offset = "0xBDEF90", VA = "0x180BDFD90")]
	internal static int CEGDPFANOAG(int DDAPFLADAMO, int GHNPMJAILAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x359F410", Offset = "0x359E610", VA = "0x18359F410")]
	internal static int CEGDPFANOAG(int DDAPFLADAMO, int GHNPMJAILAK, int ICAOGFAAGOA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AOFBLJDNDEO<T1, T2> : IComparable<global::AOFBLJDNDEO<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 FHOHKEAKPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 AADOMEOLLIO;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2709850", Offset = "0x2708A50", VA = "0x182709850")]
	public AOFBLJDNDEO(T1 CGJJGNKDFMD, T2 MLBFPNHBDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2708270", Offset = "0x2707470", VA = "0x182708270", Slot = "4")]
	public int CompareTo(global::AOFBLJDNDEO<T1, T2> JJPLNCEMCNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27089F0", Offset = "0x2707BF0", VA = "0x1827089F0", Slot = "0")]
	public override bool Equals(object JJPLNCEMCNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2708CB0", Offset = "0x2707EB0", VA = "0x182708CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2709340", Offset = "0x2708540", VA = "0x182709340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KIFDKCKPDCM<T1, T2, T3> : IComparable<global::KIFDKCKPDCM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T1 FHOHKEAKPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T2 AADOMEOLLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T3 BMLLOBMLKKM;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4840", Offset = "0x1FE3A40", VA = "0x181FE4840")]
	public KIFDKCKPDCM(T1 CGJJGNKDFMD, T2 MLBFPNHBDFF, T3 PDGHFNOBNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4060", Offset = "0x1FE3260", VA = "0x181FE4060", Slot = "4")]
	public int CompareTo(global::KIFDKCKPDCM<T1, T2, T3> JJPLNCEMCNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4350", Offset = "0x1FE3550", VA = "0x181FE4350", Slot = "0")]
	public override bool Equals(object JJPLNCEMCNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FE44C0", Offset = "0x1FE36C0", VA = "0x181FE44C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1FE45C0", Offset = "0x1FE37C0", VA = "0x181FE45C0", Slot = "3")]
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
	public T NMGCHANKNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x470670", Offset = "0x46F870", VA = "0x180470670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4E71A0", Offset = "0x4E63A0", VA = "0x1804E71A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float PMIEBFEGJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4EDB80", Offset = "0x4ECD80", VA = "0x1804EDB80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x35C2A50", Offset = "0x35C1C50", VA = "0x1835C2A50")]
	public T LJGEHOGMNCF(float EAJMLGJNCKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x35C27B0", Offset = "0x35C19B0", VA = "0x1835C27B0")]
	public T BHKDLDOKNNI(float EAJMLGJNCKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EBMJHDBFACJ(T GEDCCIPGINO, T HBHGMAMLFGI, float EAJMLGJNCKN);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x409CAC0", Offset = "0x409BCC0", VA = "0x18409CAC0", Slot = "4")]
	protected override float EBMJHDBFACJ(float GEDCCIPGINO, float HBHGMAMLFGI, float EAJMLGJNCKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x409CB40", Offset = "0x409BD40", VA = "0x18409CB40")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x409FC70", Offset = "0x409EE70", VA = "0x18409FC70", Slot = "4")]
	protected override Vector3 EBMJHDBFACJ(Vector3 GEDCCIPGINO, Vector3 HBHGMAMLFGI, float EAJMLGJNCKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x409FD30", Offset = "0x409EF30", VA = "0x18409FD30")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x408BFC0", Offset = "0x408B1C0", VA = "0x18408BFC0", Slot = "4")]
	protected override Color EBMJHDBFACJ(Color GEDCCIPGINO, Color HBHGMAMLFGI, float EAJMLGJNCKN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x409CA80", Offset = "0x409BC80", VA = "0x18409CA80")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class HPMODOKJBAP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private global::HPMODOKJBAP<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x61FFA0", Offset = "0x61F1A0", VA = "0x18061FFA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x2A80160", Offset = "0x2A7F360", VA = "0x182A80160", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2A80270", Offset = "0x2A7F470", VA = "0x182A80270")]
		public Enumerator(global::HPMODOKJBAP<T> MMHBGLAEGGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FFE0", Offset = "0x2A7F1E0", VA = "0x182A7FFE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2A80110", Offset = "0x2A7F310", VA = "0x182A80110", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2A7FF60", Offset = "0x2A7F160", VA = "0x182A7FF60")]
		private void JACEABMBMIC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] GHFGMGKKCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int BEAMIBGJJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int AAODMEEANMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int ALLGOKCDAJA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JHLGEIGBNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x36B9950", Offset = "0x36B8B50", VA = "0x1836B9950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T PHLIBLBIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x36B9AC0", Offset = "0x36B8CC0", VA = "0x1836B9AC0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x36B9210", Offset = "0x36B8410", VA = "0x1836B9210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x36BA3C0", Offset = "0x36B95C0", VA = "0x1836BA3C0")]
	public HPMODOKJBAP(int PLJFHAMCAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x36B9D40", Offset = "0x36B8F40", VA = "0x1836B9D40")]
	public void OAGNENAKIKD(T EAJMLGJNCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x36B9280", Offset = "0x36B8480", VA = "0x1836B9280")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x36B9010", Offset = "0x36B8210", VA = "0x1836B9010")]
	public void DIIJPBGJCHO(int CLGAFDJGDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x36B9560", Offset = "0x36B8760", VA = "0x1836B9560")]
	public void ICEMKAABKIJ(T[] OBEKMDCFBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x36B9340", Offset = "0x36B8540", VA = "0x1836B9340")]
	public Enumerator GINCIBHFNPP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x36BA230", Offset = "0x36B9430", VA = "0x1836BA230", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x36BA230", Offset = "0x36B9430", VA = "0x1836BA230", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x36B9FD0", Offset = "0x36B91D0", VA = "0x1836B9FD0")]
	private int OMPOBGGABCI(int DLGFKHPJLDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x36B93E0", Offset = "0x36B85E0", VA = "0x1836B93E0")]
	private int HKADPOBANGE(int DLGFKHPJLDA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ENAIJJABJJN
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
	protected ENAIJJABJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class OGDDBKOGOHK<T> : ENAIJJABJJN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	protected struct KDNDHNIEGBF
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum MCPPOFEFHGN
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
		public MCPPOFEFHGN NAFKNBEJLOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public T HIOFDPALGPA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int KMPOEIOLIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly bool JJBAGMMPCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	protected readonly bool HLPHPKGJJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	protected List<T> CDEFCDDOLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<KDNDHNIEGBF> OLFFEKGPEIB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool GDPEHAIFCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x382DA10", Offset = "0x382CC10", VA = "0x18382DA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x382DA50", Offset = "0x382CC50", VA = "0x18382DA50")]
	protected OGDDBKOGOHK(bool HLPHPKGJJAM, bool JJBAGMMPCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x382D670", Offset = "0x382C870", VA = "0x18382D670")]
	protected bool FBIAKOHGPMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x382D460", Offset = "0x382C660", VA = "0x18382D460")]
	protected void EDFJDFBGMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x382D710", Offset = "0x382C910", VA = "0x18382D710")]
	protected void IDGABLINANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x210F030", Offset = "0x210E230", VA = "0x18210F030")]
	private static void OFPKMDIDHLD<U>(ref List<U> AAMGMIAPLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x382D8C0", Offset = "0x382CAC0", VA = "0x18382D8C0", Slot = "4")]
	public void OAGNENAKIKD(T HIOFDPALGPA, bool BFICEJFJOHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x382D320", Offset = "0x382C520", VA = "0x18382D320", Slot = "5")]
	public void ANHDIGNDBJL(T HIOFDPALGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x382D540", Offset = "0x382C740", VA = "0x18382D540")]
	public void EGONGNAPLEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OCNAHFDBONF : global::OGDDBKOGOHK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x409E790", Offset = "0x409D990", VA = "0x18409E790")]
	public OCNAHFDBONF(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x409E5E0", Offset = "0x409D7E0", VA = "0x18409E5E0")]
	public void OPBHMBDEFOF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x409E580", Offset = "0x409D780", VA = "0x18409E580")]
	public static OCNAHFDBONF LJIBPGIACAP(OCNAHFDBONF LPFHPJDOJGE, Action HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x409E520", Offset = "0x409D720", VA = "0x18409E520")]
	public static OCNAHFDBONF CHACNKPMFNC(OCNAHFDBONF LPFHPJDOJGE, Action HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EOGKBHELPOM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAGNENAKIKD(Action<T> HIOFDPALGPA, bool BFICEJFJOHC = false);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANHDIGNDBJL(Action<T> HIOFDPALGPA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class BELDOFNFAOO<T> : global::OGDDBKOGOHK<Action<T>>, global::EOGKBHELPOM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x233FD60", Offset = "0x233EF60", VA = "0x18233FD60")]
	public BELDOFNFAOO(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x29E94A0", Offset = "0x29E86A0", VA = "0x1829E94A0")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x233F6A0", Offset = "0x233E8A0", VA = "0x18233F6A0")]
	public static global::BELDOFNFAOO<T> LJIBPGIACAP(global::BELDOFNFAOO<T> LPFHPJDOJGE, Action<T> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x233F600", Offset = "0x233E800", VA = "0x18233F600")]
	public static global::BELDOFNFAOO<T> CHACNKPMFNC(global::BELDOFNFAOO<T> LPFHPJDOJGE, Action<T> HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HMOPHIPMGJD<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JCOEEDKDIHM<T, U> : global::OGDDBKOGOHK<Action<T, U>>, global::HMOPHIPMGJD<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x233FD60", Offset = "0x233EF60", VA = "0x18233FD60")]
	public JCOEEDKDIHM(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE720", Offset = "0x2EED920", VA = "0x182EEE720")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x233F6A0", Offset = "0x233E8A0", VA = "0x18233F6A0")]
	public static global::JCOEEDKDIHM<T, U> LJIBPGIACAP(global::JCOEEDKDIHM<T, U> LPFHPJDOJGE, Action<T, U> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x233F600", Offset = "0x233E800", VA = "0x18233F600")]
	public static global::JCOEEDKDIHM<T, U> CHACNKPMFNC(global::JCOEEDKDIHM<T, U> LPFHPJDOJGE, Action<T, U> HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DIMAOPNHCAH<T, U, V> : global::OGDDBKOGOHK<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x233FD60", Offset = "0x233EF60", VA = "0x18233FD60")]
	public DIMAOPNHCAH(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E6C0", Offset = "0x2B7D8C0", VA = "0x182B7E6C0")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN, V HANBAFFFIKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x233F6A0", Offset = "0x233E8A0", VA = "0x18233F6A0")]
	public static global::DIMAOPNHCAH<T, U, V> LJIBPGIACAP(global::DIMAOPNHCAH<T, U, V> LPFHPJDOJGE, Action<T, U, V> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x233F600", Offset = "0x233E800", VA = "0x18233F600")]
	public static global::DIMAOPNHCAH<T, U, V> CHACNKPMFNC(global::DIMAOPNHCAH<T, U, V> LPFHPJDOJGE, Action<T, U, V> HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LANNOPCNBAA<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class MLJGELKBOMA<T, U, V, W> : global::OGDDBKOGOHK<Action<T, U, V, W>>, global::LANNOPCNBAA<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x233FD60", Offset = "0x233EF60", VA = "0x18233FD60")]
	public MLJGELKBOMA(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x256EEB0", Offset = "0x256E0B0", VA = "0x18256EEB0")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN, V HANBAFFFIKF, W FBKNPHALAHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x233F6A0", Offset = "0x233E8A0", VA = "0x18233F6A0")]
	public static global::MLJGELKBOMA<T, U, V, W> LJIBPGIACAP(global::MLJGELKBOMA<T, U, V, W> LPFHPJDOJGE, Action<T, U, V, W> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x233F600", Offset = "0x233E800", VA = "0x18233F600")]
	public static global::MLJGELKBOMA<T, U, V, W> CHACNKPMFNC(global::MLJGELKBOMA<T, U, V, W> LPFHPJDOJGE, Action<T, U, V, W> HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class COHKENHLIMP<T, U, V, W, X> : global::OGDDBKOGOHK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x233FD60", Offset = "0x233EF60", VA = "0x18233FD60")]
	public COHKENHLIMP(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9320", Offset = "0x2CE8520", VA = "0x182CE9320")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN, V HANBAFFFIKF, W FBKNPHALAHG, X ICGPCBEABPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x233F6A0", Offset = "0x233E8A0", VA = "0x18233F6A0")]
	public static global::COHKENHLIMP<T, U, V, W, X> LJIBPGIACAP(global::COHKENHLIMP<T, U, V, W, X> LPFHPJDOJGE, Action<T, U, V, W, X> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x233F600", Offset = "0x233E800", VA = "0x18233F600")]
	public static global::COHKENHLIMP<T, U, V, W, X> CHACNKPMFNC(global::COHKENHLIMP<T, U, V, W, X> LPFHPJDOJGE, Action<T, U, V, W, X> HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class MDBFOHODFCJ<T, U, V, W, X, Y> : global::OGDDBKOGOHK<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x233FD60", Offset = "0x233EF60", VA = "0x18233FD60")]
	public MDBFOHODFCJ(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x233F740", Offset = "0x233E940", VA = "0x18233F740")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN, V HANBAFFFIKF, W FBKNPHALAHG, X ICGPCBEABPG, Y DBMFKAAHNFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x233F6A0", Offset = "0x233E8A0", VA = "0x18233F6A0")]
	public static global::MDBFOHODFCJ<T, U, V, W, X, Y> LJIBPGIACAP(global::MDBFOHODFCJ<T, U, V, W, X, Y> LPFHPJDOJGE, Action<T, U, V, W, X, Y> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x233F600", Offset = "0x233E800", VA = "0x18233F600")]
	public static global::MDBFOHODFCJ<T, U, V, W, X, Y> CHACNKPMFNC(global::MDBFOHODFCJ<T, U, V, W, X, Y> LPFHPJDOJGE, Action<T, U, V, W, X, Y> HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EGEGLONFOAN<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool EBJLAABMFKJ(global::EGEGLONFOAN<T> GPJGBHEEPON);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class AJINKGEIBGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public global::EGEGLONFOAN<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public AJINKGEIBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2185C40", Offset = "0x2184E40", VA = "0x182185C40")]
		internal bool <FindNode>b__0(global::EGEGLONFOAN<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public T NOPEPBNDIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LinkedList<global::EGEGLONFOAN<T>> EBMOBKJKALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public global::EGEGLONFOAN<T> DIBIIDEGGDN;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::EGEGLONFOAN<T> MMMLMPMKHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x4A6F70", Offset = "0x4A6170", VA = "0x1804A6F70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2190F50", Offset = "0x2190150", VA = "0x182190F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CJIBNPMIMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x218FC10", Offset = "0x218EE10", VA = "0x18218FC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LGJNJNMDEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x218FC80", Offset = "0x218EE80", VA = "0x18218FC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::EGEGLONFOAN<T> BDEIDGDAJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x218F770", Offset = "0x218E970", VA = "0x18218F770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2191160", Offset = "0x2190360", VA = "0x182191160")]
	public EGEGLONFOAN(T LJAFIJCKCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x218F560", Offset = "0x218E760", VA = "0x18218F560")]
	public global::EGEGLONFOAN<T> FFCMIOBKNPE(T IIINCMJELBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x218EBF0", Offset = "0x218DDF0", VA = "0x18218EBF0")]
	public global::EGEGLONFOAN<T> AIFKGHMBIFG(T IHPEINDCGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x218EF80", Offset = "0x218E180", VA = "0x18218EF80")]
	public global::EGEGLONFOAN<T> ANHDIGNDBJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x218F0C0", Offset = "0x218E2C0", VA = "0x18218F0C0")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2190D70", Offset = "0x218FF70", VA = "0x182190D70")]
	public global::EGEGLONFOAN<T> PCOCLJCHJBO(T IHIMBABOFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2190A30", Offset = "0x218FC30", VA = "0x182190A30")]
	public static void MGACBMEHAGB(global::EGEGLONFOAN<T> GIKCDFMNACC, EBJLAABMFKJ KKEJGPCILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x20FEB00", Offset = "0x20FDD00", VA = "0x1820FEB00")]
	public static void MGACBMEHAGB<A>(global::EGEGLONFOAN<T> GIKCDFMNACC, Func<global::EGEGLONFOAN<T>, A, bool> KKEJGPCILBL, A BPEDJNGDDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x218FCC0", Offset = "0x218EEC0", VA = "0x18218FCC0")]
	public static string LJCIPEMOEDM(global::EGEGLONFOAN<T> GIKCDFMNACC, int JNBLOKOIGCP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x218F9F0", Offset = "0x218EBF0", VA = "0x18218F9F0")]
	public static global::EGEGLONFOAN<T> JHPEOHGPGMA(global::EGEGLONFOAN<T> GIKCDFMNACC, T KAHDJODJLBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DefaultMember("Item")]
public class MPKPPMOMDBD<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate int KAJOILDPEAJ(TKey KPLFFOGJEBN, TVal DIDEMEECIEC);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class KHEMNLNPOHB
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey KABLCJJGPDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal NMGCHANKNIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x538780", Offset = "0x537980", VA = "0x180538780")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x538AD0", Offset = "0x537CD0", VA = "0x180538AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FDKNNMCLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x56B4C0", Offset = "0x56A6C0", VA = "0x18056B4C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x56B4F0", Offset = "0x56A6F0", VA = "0x18056B4F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime DGIJFAKHFIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x44BCF0", Offset = "0x44AEF0", VA = "0x18044BCF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x4727D0", Offset = "0x4719D0", VA = "0x1804727D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2568820", Offset = "0x2567A20", VA = "0x182568820")]
		public KHEMNLNPOHB(TKey KPLFFOGJEBN, TVal HKPKIJKKGDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const int JGNEDJCPLCC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly Dictionary<TKey, LinkedListNode<KHEMNLNPOHB>> FHNCDLNNOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly LinkedList<KHEMNLNPOHB> EMLGNFOPDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly KAJOILDPEAJ OILKJKKNDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly TimeSpan BFGNGADCLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JIMEIMFGIGC ABPFOLMBCAC;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int ACACANFNENP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x56FA20", Offset = "0x56EC20", VA = "0x18056FA20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool AAIOBNPGEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x25752A0", Offset = "0x25744A0", VA = "0x1825752A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int OEOGBPIMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x56FA30", Offset = "0x56EC30", VA = "0x18056FA30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x569640", Offset = "0x568840", VA = "0x180569640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey PHLIBLBIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2575670", Offset = "0x2574870", VA = "0x182575670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2575F90", Offset = "0x2575190", VA = "0x182575F90")]
	public MPKPPMOMDBD(int PLJFHAMCAMK, [Optional] KAJOILDPEAJ OILKJKKNDJG, [Optional] IEqualityComparer<TKey> OKLNNLJGLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2576060", Offset = "0x2575260", VA = "0x182576060")]
	public MPKPPMOMDBD(int PLJFHAMCAMK, KAJOILDPEAJ OILKJKKNDJG, TimeSpan BFGNGADCLGC, [Optional] IEqualityComparer<TKey> OKLNNLJGLPJ, [Optional] JIMEIMFGIGC ABPFOLMBCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2575B40", Offset = "0x2574D40", VA = "0x182575B40")]
	public void MMFJHDFCHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2574CE0", Offset = "0x2573EE0", VA = "0x182574CE0")]
	public void BCKFLFBECFJ(TKey KPLFFOGJEBN, TVal DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2574690", Offset = "0x2573890", VA = "0x182574690")]
	public bool ANHDIGNDBJL(TKey KPLFFOGJEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x25759F0", Offset = "0x2574BF0", VA = "0x1825759F0")]
	public bool KLBAJGAHLAH(TKey BCKHJDJHJEK, out TVal DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x25756A0", Offset = "0x25748A0", VA = "0x1825756A0")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2575720", Offset = "0x2574920", VA = "0x182575720")]
	private bool GCODJACKPNO(KHEMNLNPOHB EPOKGOKEJLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2575020", Offset = "0x2574220", VA = "0x182575020")]
	private void COPDIODJHOB(LinkedListNode<KHEMNLNPOHB> LBNKDKEJNFF, TVal CFMONMCILIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2574810", Offset = "0x2573A10", VA = "0x182574810")]
	private void BBNAHOCBBPI(TKey KPLFFOGJEBN, TVal DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2575330", Offset = "0x2574530", VA = "0x182575330")]
	private void DGIOLCCKHCP(KHEMNLNPOHB EPOKGOKEJLO, TVal CFMONMCILIL, int JJENKIBNIKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class LCILIBEBDKL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly List<T> AAMGMIAPLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private HashSet<T> NOPNHKAKAEG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JHLGEIGBNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x27CCAA0", Offset = "0x27CBCA0", VA = "0x1827CCAA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool MHFEAIHMEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x449E40", Offset = "0x449040", VA = "0x180449E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T PHLIBLBIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3160", Offset = "0x2FC2360", VA = "0x182FC3160", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2FC3190", Offset = "0x2FC2390", VA = "0x182FC3190", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3F40", Offset = "0x1FE3140", VA = "0x181FE3F40", Slot = "11")]
	public void Add(T LFJGKCMJBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2B30", Offset = "0x2FC1D30", VA = "0x182FC2B30")]
	public bool FOAMNGNMEKG(T LFJGKCMJBNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3010", Offset = "0x2FC2210", VA = "0x182FC3010", Slot = "15")]
	public bool Remove(T LFJGKCMJBNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2BD0", Offset = "0x2FC1DD0", VA = "0x182FC2BD0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29F3260", Offset = "0x29F2460", VA = "0x1829F3260", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2FC29F0", Offset = "0x2FC1BF0", VA = "0x182FC29F0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2B8AB50", Offset = "0x2B89D50", VA = "0x182B8AB50", Slot = "13")]
	public bool Contains(T LFJGKCMJBNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2A50", Offset = "0x2FC1C50", VA = "0x182FC2A50", Slot = "14")]
	public void CopyTo(T[] OBEKMDCFBAG, int LONGPOIKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x233ED50", Offset = "0x233DF50", VA = "0x18233ED50", Slot = "6")]
	public int IndexOf(T LFJGKCMJBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2D20", Offset = "0x2FC1F20", VA = "0x182FC2D20", Slot = "7")]
	public void Insert(int DLGFKHPJLDA, T LFJGKCMJBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2FC2DE0", Offset = "0x2FC1FE0", VA = "0x182FC2DE0", Slot = "8")]
	public void RemoveAt(int DLGFKHPJLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3090", Offset = "0x2FC2290", VA = "0x182FC3090")]
	public LCILIBEBDKL()
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
			[Cpp2IlInjected.Address(RVA = "0x22CBE60", Offset = "0x22CB060", VA = "0x1822CBE60")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x409FC40", Offset = "0x409EE40", VA = "0x18409FC40")]
		public SerializedGuid(in Guid NJIMCOMIGOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x409FB00", Offset = "0x409ED00", VA = "0x18409FB00")]
		public static SerializedGuid ONLJHHLCMAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x409FA80", Offset = "0x409EC80", VA = "0x18409FA80")]
		public static SerializedGuid OFNAFBINHFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x409F9F0", Offset = "0x409EBF0", VA = "0x18409F9F0")]
		public bool HLMFFNKFFHN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x409FC20", Offset = "0x409EE20", VA = "0x18409FC20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x409FB80", Offset = "0x409ED80", VA = "0x18409FB80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x409F860", Offset = "0x409EA60", VA = "0x18409F860", Slot = "7")]
		public bool Equals(SerializedGuid JJPLNCEMCNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x409F900", Offset = "0x409EB00", VA = "0x18409F900", Slot = "0")]
		public override bool Equals(object LBCPAPMBFKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x409F9E0", Offset = "0x409EBE0", VA = "0x18409F9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x409F830", Offset = "0x409EA30", VA = "0x18409F830", Slot = "6")]
		public int CompareTo(SerializedGuid JJPLNCEMCNC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class IENPEJAMINM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly Type CADDBBIKBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string PBOJBKEAIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool KAABEPAILBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool MADGNNEKDFG;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x409D780", Offset = "0x409C980", VA = "0x18409D780")]
	public IENPEJAMINM(Type CCHDHKPFNLJ, string MFPBNOKOLHM, bool PJMNOMEKKFA = false, bool BEJEDEIMBPO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface NHMAHKFFBLL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T NMGCHANKNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool BHFJDOLCDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::NHMAHKFFBLL<T> HMBAGGKALBC(Action<T> ENCCFIMHHCL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::NHMAHKFFBLL<T> IJDGAGACDJH(Action<T> ENCCFIMHHCL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LOKEPBLIADG<T> : global::NHMAHKFFBLL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private global::JCOEEDKDIHM<T, T> HOEAJPMEDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private global::BELDOFNFAOO<T> LEPOAPFLEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private global::BELDOFNFAOO<string> MKNPCFFFLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private string HEEKCGODMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private T LEFCDNPGKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool JPOIIHMBOBM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T NMGCHANKNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x470670", Offset = "0x46F870", VA = "0x180470670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x233E540", Offset = "0x233D740", VA = "0x18233E540", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool BHFJDOLCDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5387C0", Offset = "0x5379C0", VA = "0x1805387C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x233E620", Offset = "0x233D820", VA = "0x18233E620")]
	private void OKIBAGHLIJI(T MKMAEMEOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x233E570", Offset = "0x233D770", VA = "0x18233E570", Slot = "4")]
	public global::NHMAHKFFBLL<T> HMBAGGKALBC(Action<T> PDDMOLJDABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x233E5F0", Offset = "0x233D7F0", VA = "0x18233E5F0", Slot = "5")]
	public global::NHMAHKFFBLL<T> IJDGAGACDJH(Action<T> ENCCFIMHHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x233E6A0", Offset = "0x233D8A0", VA = "0x18233E6A0")]
	public LOKEPBLIADG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HJFJDDDJIFA
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KCKFCHBBIFL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public global::NHMAHKFFBLL<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public global::MIIAPOFCBNK<T> promise;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public KCKFCHBBIFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2A95E50", Offset = "0x2A95050", VA = "0x182A95E50")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x23DA850", Offset = "0x23D9A50", VA = "0x1823DA850")]
	public static global::IJNOJIGJDDE<T> GBAHAGCNPHG<T>(this global::NHMAHKFFBLL<T> NIDPJAOADGB, Action<T> JHEAOCMILMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public abstract class JIMEIMFGIGC
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private class LIPEOGNKOII : JIMEIMFGIGC
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static JIMEIMFGIGC PBJALEFDLAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x409DA50", Offset = "0x409CC50", VA = "0x18409DA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime JHKHJFILABL
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x409DA00", Offset = "0x409CC00", VA = "0x18409DA00", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x409DB40", Offset = "0x409CD40", VA = "0x18409DB40")]
		public LIPEOGNKOII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static JIMEIMFGIGC OKILAGMAOOE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static JIMEIMFGIGC DCKAENMPEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x409D890", Offset = "0x409CA90", VA = "0x18409D890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime JHKHJFILABL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
	protected JIMEIMFGIGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class OPGCHDOFIOG : global::OPHCILJCMAG<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x409E7F0", Offset = "0x409D9F0", VA = "0x18409E7F0")]
	public OPGCHDOFIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OPHCILJCMAG<T> : global::BPABBDKHPHH<T>, HONOHKABIJH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> AGMEELMNBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::IJNOJIGJDDE<T> BHIEBGDEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private NIIPAOBAIGP PPBGBLGELHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x19F5040", Offset = "0x19F4240", VA = "0x1819F5040", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x364C360", Offset = "0x364B560", VA = "0x18364C360")]
	public OPHCILJCMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ONLAGMGKJGM<T> : global::BPABBDKHPHH<T>, HONOHKABIJH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> AGMEELMNBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::IJNOJIGJDDE<T> BHIEBGDEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private NIIPAOBAIGP PPBGBLGELHB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x19F5040", Offset = "0x19F4240", VA = "0x1819F5040", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x364C270", Offset = "0x364B470", VA = "0x18364C270")]
	public ONLAGMGKJGM(Exception BIDEGMIFHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HONOHKABIJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	NIIPAOBAIGP BHIEBGDEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BPABBDKHPHH<T> : HONOHKABIJH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> AGMEELMNBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::IJNOJIGJDDE<T> BHIEBGDEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class FDOANGHHPGL<TTask, T> : global::BPABBDKHPHH<T>, HONOHKABIJH, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HFBHBOCDBIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public global::FDOANGHHPGL<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public HFBHBOCDBIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class FMEIGJBCHEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public HFBHBOCDBIK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		public FMEIGJBCHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x329FA30", Offset = "0x329EC30", VA = "0x18329FA30")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static bool HENHIICBEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly global::MIIAPOFCBNK<T> NJCFBAOLAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Task<T> IFAGDJPBIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly CancellationTokenSource JPAGLDADOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private bool BOJHCNOPAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private SynchronizationContext LJHMKPMPIBB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> AGMEELMNBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::IJNOJIGJDDE<T> BHIEBGDEIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private NIIPAOBAIGP PPBGBLGELHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool FDHIGOLGKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x641ED0", Offset = "0x6410D0", VA = "0x180641ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x329DDA0", Offset = "0x329CFA0", VA = "0x18329DDA0")]
	static FDOANGHHPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x329E2D0", Offset = "0x329D4D0", VA = "0x18329E2D0")]
	protected FDOANGHHPGL(TTask IFAGDJPBIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x329D910", Offset = "0x329CB10", VA = "0x18329D910", Slot = "1")]
	~FDOANGHHPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x329D840", Offset = "0x329CA40", VA = "0x18329D840", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x329DB20", Offset = "0x329CD20", VA = "0x18329DB20")]
	private void HHNMAMPPGJL(bool EJNGALPNGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T DBBJHJEGMJK(TTask BDMMFKPDOKN);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void NEFCAONHDKE();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x329DD10", Offset = "0x329CF10", VA = "0x18329DD10")]
	protected void NODKMOFMLAL(T MKMAEMEOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x329D680", Offset = "0x329C880", VA = "0x18329D680")]
	protected void CFEPPKCJOND(string HEEKCGODMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x329D700", Offset = "0x329C900", VA = "0x18329D700")]
	[CompilerGenerated]
	private void DEFAFFOLGIC(object EOFGINCPLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MPGOBBODILK<T> : IEnumerable<global::MPGOBBODILK<T>.DPILHGHPDGO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct DPILHGHPDGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public T DIDEMEECIEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int DLGFKHPJLDA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KGNMENDNBOI : IEnumerator<DPILHGHPDGO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private global::MPGOBBODILK<T> ACMOLLPOGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int DLGFKHPJLDA;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2568610", Offset = "0x2567810", VA = "0x182568610", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DPILHGHPDGO NLIOFICPEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x2568680", Offset = "0x2567880", VA = "0x182568680", Slot = "4")]
			get
			{
				return default(DPILHGHPDGO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BD0", Offset = "0x6F2DD0", VA = "0x1806F3BD0")]
		public KGNMENDNBOI(global::MPGOBBODILK<T> ACMOLLPOGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2568580", Offset = "0x2567780", VA = "0x182568580", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BC0", Offset = "0x6F2DC0", VA = "0x1806F3BC0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x754A40", Offset = "0x753C40", VA = "0x180754A40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private struct NOJLGAJEJFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public bool BEELLPBDPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public T DIDEMEECIEC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private const int FEADALOMPDO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Dictionary<T, int> HHHBOGFLHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NOJLGAJEJFD[] OBOJHNPFEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private int FIMGDMOBODG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int JHLGEIGBNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x25744E0", Offset = "0x25736E0", VA = "0x1825744E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2573D30", Offset = "0x2572F30", VA = "0x182573D30")]
	public static global::MPGOBBODILK<T> EPILAMFGPCH(DPILHGHPDGO[] GAOBDNEMKDI, bool MHFDFBPFJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x25745D0", Offset = "0x25737D0", VA = "0x1825745D0")]
	public MPGOBBODILK(int PLJFHAMCAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2574350", Offset = "0x2573550", VA = "0x182574350")]
	public int GIJMLJONIAA(T DIDEMEECIEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x25742E0", Offset = "0x25734E0", VA = "0x1825742E0")]
	public T GBAHAGCNPHG(int DLGFKHPJLDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x25740F0", Offset = "0x25732F0", VA = "0x1825740F0")]
	public bool FOAMNGNMEKG(T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2574110", Offset = "0x2573310", VA = "0x182574110")]
	public bool FOAMNGNMEKG(T DIDEMEECIEC, int DLGFKHPJLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x25743A0", Offset = "0x25735A0", VA = "0x1825743A0")]
	public DPILHGHPDGO[] HOCFHOPNBGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2574510", Offset = "0x2573710", VA = "0x182574510")]
	private int LPHCOIJDBBC(int BEAMIBGJJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2574560", Offset = "0x2573760", VA = "0x182574560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2574560", Offset = "0x2573760", VA = "0x182574560", Slot = "4")]
	private IEnumerator<DPILHGHPDGO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class DANLHBAJKIN<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<T> PKJJBFPODNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<T> EMLNCCMOOKO;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x347B510", Offset = "0x347A710", VA = "0x18347B510")]
	public DANLHBAJKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x347B3B0", Offset = "0x347A5B0", VA = "0x18347B3B0")]
	public DANLHBAJKIN(int PLJFHAMCAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x347B190", Offset = "0x347A390", VA = "0x18347B190")]
	public T CLKBMDDDHEO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x347B290", Offset = "0x347A490", VA = "0x18347B290")]
	public void JNOAJGEKHPH(T FCALECJCMKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PCAEHJGOLON<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Dictionary<int, T> IEJPIEAPJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private T DAOLKHNAELD;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual T NAEGPEGMIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x449190", Offset = "0x448390", VA = "0x180449190", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x449450", Offset = "0x448650", VA = "0x180449450", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3655BE0", Offset = "0x3654DE0", VA = "0x183655BE0")]
	public bool BBNAHOCBBPI(T DIDEMEECIEC, int DEHBNGCHCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3655CA0", Offset = "0x3654EA0", VA = "0x183655CA0")]
	public bool FJGMKFKENHJ(int DEHBNGCHCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3655FA0", Offset = "0x36551A0", VA = "0x183655FA0")]
	public T MHJGPOBCNCC(int PJIHIPODFDI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3656310", Offset = "0x3655510", VA = "0x183656310")]
	private bool PLLCFLBDKFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3655D00", Offset = "0x3654F00", VA = "0x183655D00")]
	public bool KLBAJGAHLAH(int DEHBNGCHCHD, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x36563A0", Offset = "0x36555A0", VA = "0x1836563A0")]
	public PCAEHJGOLON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DHJGPAOIDDP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	protected struct FOFOFPGMENG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public T NMGCHANKNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int BIEBADAOLPD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	protected readonly List<FOFOFPGMENG> GHFGMGKKCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private T JACDEAEJIJD;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int JHLGEIGBNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x27CCAA0", Offset = "0x27CBCA0", VA = "0x1827CCAA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D370", Offset = "0x2B7C570", VA = "0x182B7D370")]
	public bool LHBMLPKDBPE(T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D5C0", Offset = "0x2B7C7C0", VA = "0x182B7D5C0")]
	public void OAGNENAKIKD(T DIDEMEECIEC, int DEHBNGCHCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D160", Offset = "0x2B7C360", VA = "0x182B7D160")]
	public bool ANHDIGNDBJL(T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D280", Offset = "0x2B7C480", VA = "0x182B7D280")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D2E0", Offset = "0x2B7C4E0", VA = "0x182B7D2E0")]
	public T GALNALFFPDK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D640", Offset = "0x2B7C840", VA = "0x182B7D640")]
	private void OFJBPFGNBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D850", Offset = "0x2B7CA50", VA = "0x182B7D850")]
	public DHJGPAOIDDP()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1A061F0", Offset = "0x1A053F0", VA = "0x181A061F0", Slot = "4")]
		public virtual T LAIHHBCLCDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BE0", Offset = "0x19F3DE0", VA = "0x1819F4BE0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class PHENBJBFAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<byte, MPPNLPJCOCL> FLCIIGGPOFD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MPPNLPJCOCL MNOEDBDOKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4491A0", Offset = "0x4483A0", VA = "0x1804491A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x449440", Offset = "0x448640", VA = "0x180449440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Vector2 EGOAGCCDINI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1805B60", Offset = "0x1804D60", VA = "0x181805B60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x29E65D0", Offset = "0x29E57D0", VA = "0x1829E65D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector2 PCOPGJFBHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x60FC10", Offset = "0x60EE10", VA = "0x18060FC10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Vector2 OKCCHGILHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x322DD60", Offset = "0x322CF60", VA = "0x18322DD60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x322DD80", Offset = "0x322CF80", VA = "0x18322DD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KJHDNECNHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4731B0", Offset = "0x4723B0", VA = "0x1804731B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x498360", Offset = "0x497560", VA = "0x180498360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x409EFD0", Offset = "0x409E1D0", VA = "0x18409EFD0")]
	public PHENBJBFAGL(Bounds MDNBHLJHLKC, Vector2[] EPBBIEMAAMJ, int HEAPJLGLMDG, byte BEAMIBGJJFC, float INCKPEAKFPO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x409EA50", Offset = "0x409DC50", VA = "0x18409EA50")]
	public MPPNLPJCOCL MPOEJONDIBP(byte DLGFKHPJLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x409E850", Offset = "0x409DA50", VA = "0x18409E850")]
	public void DKKKPPONLHK(Vector3 JHNKAIDOAJL, float APOECGJGIEI, float BOOOONNDIKG, ref List<byte> LBNLJFEPICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x409E830", Offset = "0x409DA30", VA = "0x18409E830")]
	public void BBNLCEHAKOF(MPPNLPJCOCL.AOHMBIHDDHG ILOFOLIOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x409E930", Offset = "0x409DB30", VA = "0x18409E930")]
	private MPPNLPJCOCL GKFJHCDFGGA(byte DLGFKHPJLDA, MPPNLPJCOCL.HJEMEHMOFMO IMDACAJCDGN, MPPNLPJCOCL KJKCKFBOOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x409EAB0", Offset = "0x409DCB0", VA = "0x18409EAB0")]
	private void PCGGOOBNJPI(MPPNLPJCOCL KJKCKFBOOEM, Vector2[] EPBBIEMAAMJ, int CGFKPHPPIJI, int LKBKKJGJOMM, int KOIADFCFDFD, int EJBNDHIIHFC, float INCKPEAKFPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class MPPNLPJCOCL
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum HJEMEHMOFMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public enum AOHMBIHDDHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public byte KIHFBOAFKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 NJBNOBKAELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Vector3 FDKNNMCLKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Vector3 NHAMODFGMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Vector3 BGJGDLAPPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public HJEMEHMOFMO POGCPOONHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public MPPNLPJCOCL MMMLMPMKHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public List<MPPNLPJCOCL> CCIDONEFDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public bool HPHCFJEEDJM;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x409E1D0", Offset = "0x409D3D0", VA = "0x18409E1D0")]
	public MPPNLPJCOCL(byte HNDJNNFIENP, HJEMEHMOFMO IMDACAJCDGN, MPPNLPJCOCL KJKCKFBOOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x409E0E0", Offset = "0x409D2E0", VA = "0x18409E0E0")]
	public void FFCMIOBKNPE(MPPNLPJCOCL DICGFHBNIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00")]
	public void BBNLCEHAKOF(int FJJECBKABEH, AOHMBIHDDHG ILOFOLIOECB, int JLAJLAAACIM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x409DE50", Offset = "0x409D050", VA = "0x18409DE50")]
	public void DKKKPPONLHK(List<byte> LBNLJFEPICN, Vector3 JHNKAIDOAJL, float APOECGJGIEI, float BOOOONNDIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x409E170", Offset = "0x409D370", VA = "0x18409E170")]
	public bool IJGPLHFNPEN(Vector3 GCKOJPEPDIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x409DE10", Offset = "0x409D010", VA = "0x18409DE10")]
	public bool AILCLEMAJME(Vector3 GCKOJPEPDIK, float AHBNLDEIPKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class IPIEAOMADAO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int PLJFHAMCAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int EIDAOAMEMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private List<T> OKGPBCHANEN;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T LHHMDGEIEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2EEA1C0", Offset = "0x2EE93C0", VA = "0x182EEA1C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T PIHOKIPHKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2EE9DF0", Offset = "0x2EE8FF0", VA = "0x182EE9DF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T BPPOMIIKJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2EEA350", Offset = "0x2EE9550", VA = "0x182EEA350")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA3A0", Offset = "0x2EE95A0", VA = "0x182EEA3A0")]
	public IPIEAOMADAO(int PLJFHAMCAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA080", Offset = "0x2EE9280", VA = "0x182EEA080")]
	public void OAGNENAKIKD(T HPBMPMHGEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2EE9EF0", Offset = "0x2EE90F0", VA = "0x182EE9EF0")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2EE9EA0", Offset = "0x2EE90A0", VA = "0x182EE9EA0")]
	public void CKKCCNHBBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2EE9F30", Offset = "0x2EE9130", VA = "0x182EE9F30")]
	public void LPLELAANJED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KCLNCPBNJMO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct LMKNAAOBOJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int BIEBADAOLPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public T NMGCHANKNIG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Dictionary<object, LMKNAAOBOJE> IEJPIEAPJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private T DAOLKHNAELD;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T NAEGPEGMIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1805B60", Offset = "0x1804D60", VA = "0x181805B60", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x29E65D0", Offset = "0x29E57D0", VA = "0x1829E65D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KGHNCNFOCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1FDB680", Offset = "0x1FDA880", VA = "0x181FDB680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public object BOOFGBBMJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x44BCF0", Offset = "0x44AEF0", VA = "0x18044BCF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4727D0", Offset = "0x4719D0", VA = "0x1804727D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1FDAE80", Offset = "0x1FDA080", VA = "0x181FDAE80")]
	public bool BBNAHOCBBPI(T DIDEMEECIEC, object KFBPOACAFGF, int DEHBNGCHCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB190", Offset = "0x1FDA390", VA = "0x181FDB190")]
	public bool FJGMKFKENHJ(object KFBPOACAFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3070D70", Offset = "0x306FF70", VA = "0x183070D70")]
	public bool KLBAJGAHLAH(object KFBPOACAFGF, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB160", Offset = "0x1FDA360", VA = "0x181FDB160")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3071170", Offset = "0x3070370", VA = "0x183071170")]
	private bool PLLCFLBDKFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE6D0", Offset = "0x1FDD8D0", VA = "0x181FDE6D0")]
	public KCLNCPBNJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MGNBLNHOAJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Dictionary<object, float> IEJPIEAPJLG;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float LIOFGDFMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA21DD0", Offset = "0xA20FD0", VA = "0x180A21DD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA21DE0", Offset = "0xA20FE0", VA = "0x180A21DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x409DBA0", Offset = "0x409CDA0", VA = "0x18409DBA0")]
	public void BBNAHOCBBPI(float DIDEMEECIEC, object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x409DC10", Offset = "0x409CE10", VA = "0x18409DC10")]
	public void FJGMKFKENHJ(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x409DC80", Offset = "0x409CE80", VA = "0x18409DC80")]
	private void IHNFFHCPKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x409DDA0", Offset = "0x409CFA0", VA = "0x18409DDA0")]
	public MGNBLNHOAJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public sealed class PHIJAMFFMFH
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class GMIOKMMCINP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly string OAFDFDNMOJJ;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
		private GMIOKMMCINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x54EC10", Offset = "0x54DE10", VA = "0x18054EC10")]
		public GMIOKMMCINP(string OAFDFDNMOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x409CEF0", Offset = "0x409C0F0", VA = "0x18409CEF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class JIMCFDAFPMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x44B9D0", Offset = "0x44ABD0", VA = "0x18044B9D0")]
		public JIMCFDAFPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x409D7E0", Offset = "0x409C9E0", VA = "0x18409D7E0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HashSet<object> NEPCPNDPBPK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool MLLMBAGHEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x409F4C0", Offset = "0x409E6C0", VA = "0x18409F4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x409F610", Offset = "0x409E810", VA = "0x18409F610")]
	public void OAGNENAKIKD(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x409F500", Offset = "0x409E700", VA = "0x18409F500")]
	public void ANHDIGNDBJL(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x409F560", Offset = "0x409E760", VA = "0x18409F560")]
	public bool LHBMLPKDBPE(object KFBPOACAFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x409F5C0", Offset = "0x409E7C0", VA = "0x18409F5C0")]
	public void LJLBMEMDJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x409F670", Offset = "0x409E870", VA = "0x18409F670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x409F7D0", Offset = "0x409E9D0", VA = "0x18409F7D0")]
	public PHIJAMFFMFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class BDOAKMDLCEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private struct PKDDNIOPAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public float PEFNIAHHMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public T NMGCHANKNIG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Dictionary<object, PKDDNIOPAFG> IEJPIEAPJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private T CBGCJFHCBNP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public virtual T FMGKBFFDBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x12E6AE0", Offset = "0x12E5CE0", VA = "0x1812E6AE0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x29E65F0", Offset = "0x29E57F0", VA = "0x1829E65F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public object BPDDNNOLOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x470670", Offset = "0x46F870", VA = "0x180470670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4E71A0", Offset = "0x4E63A0", VA = "0x1804E71A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool KGHNCNFOCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x29E6920", Offset = "0x29E5B20", VA = "0x1829E6920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x29E5FC0", Offset = "0x29E51C0", VA = "0x1829E5FC0")]
	public bool BBNAHOCBBPI(T DIDEMEECIEC, object KFBPOACAFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x29E6550", Offset = "0x29E5750", VA = "0x1829E6550")]
	public bool FJGMKFKENHJ(object KFBPOACAFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDB160", Offset = "0x1FDA360", VA = "0x181FDB160")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x29E66B0", Offset = "0x29E58B0", VA = "0x1829E66B0")]
	public bool KLBAJGAHLAH(object KFBPOACAFGF, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x29E6960", Offset = "0x29E5B60", VA = "0x1829E6960")]
	private bool PLLCFLBDKFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x29E8610", Offset = "0x29E7810", VA = "0x1829E8610")]
	public BDOAKMDLCEE()
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
