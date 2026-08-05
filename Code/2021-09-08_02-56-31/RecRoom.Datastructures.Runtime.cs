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
public class CJOEKDOBHDG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D7C10", Offset = "0x4D7010", VA = "0x1804D7C10")]
	public CJOEKDOBHDG()
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
		[Cpp2IlInjected.Address(RVA = "0x4121A0", Offset = "0x4115A0", VA = "0x1804121A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x412E60", Offset = "0x412260", VA = "0x180412E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x412190", Offset = "0x411590", VA = "0x180412190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x412450", Offset = "0x411850", VA = "0x180412450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x412E00", Offset = "0x412200", VA = "0x180412E00", Slot = "4")]
	public virtual void COBDCEFIEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1730760", Offset = "0x172FB60", VA = "0x181730760")]
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
	[CJOEKDOBHDG]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C6C0", Offset = "0x2C6BAC0", VA = "0x182C6C6C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C6C200", Offset = "0x2C6B600", VA = "0x182C6C200", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CCC0", Offset = "0x2C6C0C0", VA = "0x182C6CCC0")]
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
	private sealed class AEAKOHFPLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1730760", Offset = "0x172FB60", VA = "0x181730760")]
		public AEAKOHFPLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x299E460", Offset = "0x299D860", VA = "0x18299E460")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[CJOEKDOBHDG]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x29A20F0", Offset = "0x29A14F0", VA = "0x1829A20F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x29A2120", Offset = "0x29A1520", VA = "0x1829A2120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x29A2040", Offset = "0x29A1440", VA = "0x1829A2040", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey DNGKIAJLLHG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29A20A0", Offset = "0x29A14A0", VA = "0x1829A20A0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x29A1F50", Offset = "0x29A1350", VA = "0x1829A1F50", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29A17C0", Offset = "0x29A0BC0", VA = "0x1829A17C0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x29A1130", Offset = "0x29A0530", VA = "0x1829A1130", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29A0D90", Offset = "0x29A0190", VA = "0x1829A0D90", Slot = "14")]
	protected virtual string LKCOLBMMLKA(TKeyVal GALGADHFCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x21F0530", Offset = "0x21EF930", VA = "0x1821F0530", Slot = "4")]
	public bool ContainsKey(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x29A1E50", Offset = "0x29A1250", VA = "0x1829A1E50", Slot = "5")]
	public bool TryGetValue(TKey DNGKIAJLLHG, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29A0CA0", Offset = "0x29A00A0", VA = "0x1829A0CA0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x29A0CA0", Offset = "0x29A00A0", VA = "0x1829A0CA0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x29A1E80", Offset = "0x29A1280", VA = "0x1829A1E80")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class FIOCHCGPCBF : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GameRoot <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x412190", Offset = "0x411590", VA = "0x180412190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x412190", Offset = "0x411590", VA = "0x180412190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x576720", Offset = "0x575B20", VA = "0x180576720")]
		[DebuggerHidden]
		public FIOCHCGPCBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC2E0", Offset = "0x3BEB6E0", VA = "0x183BEC2E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC190", Offset = "0x3BEB590", VA = "0x183BEC190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC350", Offset = "0x3BEB750", VA = "0x183BEC350")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC290", Offset = "0x3BEB690", VA = "0x183BEC290", Slot = "8")]
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
	private static HashSet<GameObject> CJJFGOEDHEM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC710", Offset = "0x3BEBB10", VA = "0x183BEC710")]
	public static void RegisterDontDestroyOnLoad(GameObject NNNMGKGMIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC530", Offset = "0x3BEB930", VA = "0x183BEC530", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC7B0", Offset = "0x3BEBBB0", VA = "0x183BEC7B0")]
	[IteratorStateMachine(typeof(FIOCHCGPCBF))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x412E00", Offset = "0x412200", VA = "0x180412E00", Slot = "6")]
	protected virtual void BFNKJCLBGIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC870", Offset = "0x3BEBC70", VA = "0x183BEC870")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CGINBDPPLIO
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1C8BEE0", Offset = "0x1C8B2E0", VA = "0x181C8BEE0")]
	public static void DFFNGCIAOME<T>(this T CKCMODJNCNF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBF00", Offset = "0x3BEB300", VA = "0x183BEBF00")]
	public static void DFFNGCIAOME(this GameObject DOJCFCINALC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : MonoBehaviour where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static TImpl GCCLEJOGCCE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected static TImpl ONCPNMDGGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA7FA80", Offset = "0xA7EE80", VA = "0x180A7FA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B0DFA0", Offset = "0x2B0D3A0", VA = "0x182B0DFA0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B0E470", Offset = "0x2B0D870", VA = "0x182B0E470", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29A2150", Offset = "0x29A1550", VA = "0x1829A2150")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GameObject KGFPNIMJHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA82FB0", Offset = "0xA823B0", VA = "0x180A82FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3BECF80", Offset = "0x3BEC380", VA = "0x183BECF80")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3BED1A0", Offset = "0x3BEC5A0", VA = "0x183BED1A0")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xA7C080", Offset = "0xA7B480", VA = "0x180A7C080")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static T GCCLEJOGCCE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static T ONCPNMDGGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA7FA80", Offset = "0xA7EE80", VA = "0x180A7FA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool FFNIFALJLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2C6DBA0", Offset = "0x2C6CFA0", VA = "0x182C6DBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D660", Offset = "0x2C6CA60", VA = "0x182C6D660", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C6D9E0", Offset = "0x2C6CDE0", VA = "0x182C6D9E0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x29A2150", Offset = "0x29A1550", VA = "0x1829A2150")]
	public SingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HKMGKEPIIGN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NMKBADGNEBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1730760", Offset = "0x172FB60", VA = "0x181730760")]
		public NMKBADGNEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2B9CC10", Offset = "0x2B9C010", VA = "0x182B9CC10")]
		internal bool <GetSamples>b__0(global::DHKPBIAHMHG<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float DHMHIHCJCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float CMCMIOPCFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::DHKPBIAHMHG<float, T>> PDACILKHJJG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BFMBCJLAKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B97F20", Offset = "0x2B97320", VA = "0x182B97F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B983A0", Offset = "0x2B977A0", VA = "0x182B983A0")]
	public HKMGKEPIIGN(float EBNPDDOHPII, float PDNBGEMGHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B98020", Offset = "0x2B97420", VA = "0x182B98020")]
	public bool NNLAEHCFGLO(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B97BC0", Offset = "0x2B96FC0", VA = "0x182B97BC0")]
	public IEnumerable<T> BKGJKBJPEID(float MOPKOPOKKEE, [Optional] float? DJJCAALEIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B97EF0", Offset = "0x2B972F0", VA = "0x182B97EF0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B982E0", Offset = "0x2B976E0", VA = "0x182B982E0")]
	private void PCAHGHKBMMN(float MOPKOPOKKEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class GMNJGMLCABC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct PBCEHIBDGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T DMLIOOCLKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float NJNCDDAIBCM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float MMAOMABFHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> FOBMBNCDNOJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int KDCFAAKILOA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PBCEHIBDGKN[] OPEBNMBKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int DHDKFNGOPAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float LCJLABPBGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xB34FF0", Offset = "0xB343F0", VA = "0x180B34FF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB35140", Offset = "0xB34540", VA = "0x180B35140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1F94490", Offset = "0x1F93890", VA = "0x181F94490")]
	public GMNJGMLCABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1F944C0", Offset = "0x1F938C0", VA = "0x181F944C0")]
	public GMNJGMLCABC(int OJJOHDIFMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F93630", Offset = "0x1F92A30", VA = "0x181F93630")]
	public void BPAJKKAGPKB(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1F93EF0", Offset = "0x1F932F0", VA = "0x181F93EF0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1F93A00", Offset = "0x1F92E00", VA = "0x181F93A00")]
	public bool IMMBIFHODMF(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1F93D90", Offset = "0x1F93190", VA = "0x181F93D90")]
	public bool KJPECKDEGGL(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1F942F0", Offset = "0x1F936F0", VA = "0x181F942F0")]
	public void OCCODBALDOD(float JODPOANPJNK, float BCANLCHBKJE, List<T> NKHPHBOPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1F93BB0", Offset = "0x1F92FB0", VA = "0x181F93BB0")]
	private int JDDBKHEGJHN(int NPDLAJLCALI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1F935F0", Offset = "0x1F929F0", VA = "0x181F935F0")]
	private void BCADCIPJGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KPKMNLDBMEH();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T PIFFNJDGHDE(T ONGBFDACHHG, float LIMOILDIGKF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CAPOCJJJJIB(T LONDCJPNKKN, T PCEJJILDLGD);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JIODMOCKLKL(T LONDCJPNKKN, T PCEJJILDLGD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class APDBOLKPCBO : global::GMNJGMLCABC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBD90", Offset = "0x3BEB190", VA = "0x183BEBD90", Slot = "4")]
	protected override Vector3 KPKMNLDBMEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBE00", Offset = "0x3BEB200", VA = "0x183BEBE00", Slot = "5")]
	protected override Vector3 PIFFNJDGHDE(Vector3 ONGBFDACHHG, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBC70", Offset = "0x3BEB070", VA = "0x183BEBC70", Slot = "6")]
	protected override Vector3 CAPOCJJJJIB(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBD20", Offset = "0x3BEB120", VA = "0x183BEBD20", Slot = "7")]
	protected override Vector3 JIODMOCKLKL(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBEA0", Offset = "0x3BEB2A0", VA = "0x183BEBEA0")]
	public APDBOLKPCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DLPGJKJFNCM
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1ABA670", Offset = "0x1AB9A70", VA = "0x181ABA670")]
	public static global::DHKPBIAHMHG<T1, T2> NFHADFCEMML<T1, T2>(T1 OFCHPINAEEE, T2 NLNENAIDOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1ABA6E0", Offset = "0x1AB9AE0", VA = "0x181ABA6E0")]
	public static global::ELGBCKDBOED<T1, T2, T3> NFHADFCEMML<T1, T2, T3>(T1 OFCHPINAEEE, T2 NLNENAIDOJD, T3 FGPNPLGENDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8E8540", Offset = "0x8E7940", VA = "0x1808E8540")]
	internal static int FBNEHNPAJDI(int JGPNKFEDCDB, int EDGDLDGIIMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8E8550", Offset = "0x8E7950", VA = "0x1808E8550")]
	internal static int FBNEHNPAJDI(int JGPNKFEDCDB, int EDGDLDGIIMI, int BLAJFLKDFED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DHKPBIAHMHG<T1, T2> : IComparable<global::DHKPBIAHMHG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 LBOPKDHLCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 JGIEIIFCNKP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x19172A0", Offset = "0x19166A0", VA = "0x1819172A0")]
	public DHKPBIAHMHG(T1 OFCHPINAEEE, T2 NLNENAIDOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x19159F0", Offset = "0x1914DF0", VA = "0x1819159F0", Slot = "4")]
	public int CompareTo(global::DHKPBIAHMHG<T1, T2> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1916090", Offset = "0x1915490", VA = "0x181916090", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1916800", Offset = "0x1915C00", VA = "0x181916800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1916E70", Offset = "0x1916270", VA = "0x181916E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ELGBCKDBOED<T1, T2, T3> : IComparable<global::ELGBCKDBOED<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 LBOPKDHLCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 JGIEIIFCNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 KKMJPCLKNHO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1924580", Offset = "0x1923980", VA = "0x181924580")]
	public ELGBCKDBOED(T1 OFCHPINAEEE, T2 NLNENAIDOJD, T3 FGPNPLGENDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1923EA0", Offset = "0x19232A0", VA = "0x181923EA0", Slot = "4")]
	public int CompareTo(global::ELGBCKDBOED<T1, T2, T3> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1924090", Offset = "0x1923490", VA = "0x181924090", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1924290", Offset = "0x1923690", VA = "0x181924290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1924300", Offset = "0x1923700", VA = "0x181924300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x439670", Offset = "0x438A70", VA = "0x180439670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4AD620", Offset = "0x4ACA20", VA = "0x1804AD620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float BPHIOMBNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB70640", Offset = "0xB6FA40", VA = "0x180B70640")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x34998C0", Offset = "0x3498CC0", VA = "0x1834998C0")]
	public T DHEIFNLDBKN(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3499B60", Offset = "0x3498F60", VA = "0x183499B60")]
	public T NICCICAFMDM(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ADPELJHGHKK(T LONDCJPNKKN, T PCEJJILDLGD, float LIMOILDIGKF);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1730760", Offset = "0x172FB60", VA = "0x181730760")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC410", Offset = "0x3BEB810", VA = "0x183BEC410", Slot = "4")]
	protected override float ADPELJHGHKK(float LONDCJPNKKN, float PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC490", Offset = "0x3BEB890", VA = "0x183BEC490")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE8C0", Offset = "0x3BEDCC0", VA = "0x183BEE8C0", Slot = "4")]
	protected override Vector3 ADPELJHGHKK(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE980", Offset = "0x3BEDD80", VA = "0x183BEE980")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8810", Offset = "0x3BD7C10", VA = "0x183BD8810", Slot = "4")]
	protected override Color ADPELJHGHKK(Color LONDCJPNKKN, Color PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC150", Offset = "0x3BEB550", VA = "0x183BEC150")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class GPFLNFOKEIA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private global::GPFLNFOKEIA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xB34FF0", Offset = "0xB343F0", VA = "0x180B34FF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1F89390", Offset = "0x1F88790", VA = "0x181F89390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1F89780", Offset = "0x1F88B80", VA = "0x181F89780")]
		public Enumerator(global::GPFLNFOKEIA<T> NKHPHBOPPEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x412E00", Offset = "0x412200", VA = "0x180412E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1F88A20", Offset = "0x1F87E20", VA = "0x181F88A20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F891A0", Offset = "0x1F885A0", VA = "0x181F891A0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1F88F00", Offset = "0x1F88300", VA = "0x181F88F00")]
		private void PKKNLKAHILA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] IKHCBHDLNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int HKPHMBLKPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int DJICGHFJJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int HNPBHLIOFNC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1F957B0", Offset = "0x1F94BB0", VA = "0x181F957B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1F950A0", Offset = "0x1F944A0", VA = "0x181F950A0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1F94ED0", Offset = "0x1F942D0", VA = "0x181F94ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F95D40", Offset = "0x1F95140", VA = "0x181F95D40")]
	public GPFLNFOKEIA(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1F94B50", Offset = "0x1F93F50", VA = "0x181F94B50")]
	public void BPAJKKAGPKB(T LIMOILDIGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1F951C0", Offset = "0x1F945C0", VA = "0x181F951C0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1F951E0", Offset = "0x1F945E0", VA = "0x181F951E0")]
	public void NAJLLGFNIKC(int MNIJHBJDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1F95270", Offset = "0x1F94670", VA = "0x181F95270")]
	public void NPAGGFDPFJK(T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1F94E10", Offset = "0x1F94210", VA = "0x181F94E10")]
	public Enumerator CINCGNABFNK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1F95BB0", Offset = "0x1F94FB0", VA = "0x181F95BB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1F95BB0", Offset = "0x1F94FB0", VA = "0x181F95BB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1F958E0", Offset = "0x1F94CE0", VA = "0x181F958E0")]
	private int PLMBLHMDABK(int EFBDCIJMFGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F94A60", Offset = "0x1F93E60", VA = "0x181F94A60")]
	private int BCDNPPPABOI(int EFBDCIJMFGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KBNAHLKGDBF
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4149D0", Offset = "0x413DD0", VA = "0x1804149D0")]
	protected KBNAHLKGDBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class PPKEKBLDDIK<T> : KBNAHLKGDBF
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	protected struct DBMLEBCMBFG
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum AJMGPEJEOJD
		{
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AJMGPEJEOJD GEDCEIDOKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public T JJGHIEJCCDA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int OLOFIKOIGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly bool NOLKFLLKNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	protected readonly bool JNIOEAEOGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	protected List<T> GGDHHMGKOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<DBMLEBCMBFG> JFKJECNEMEH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MENDGJKDBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3208970", Offset = "0x3207D70", VA = "0x183208970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3208D70", Offset = "0x3208170", VA = "0x183208D70")]
	protected PPKEKBLDDIK(bool JNIOEAEOGFI, bool NOLKFLLKNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3208900", Offset = "0x3207D00", VA = "0x183208900", Slot = "1")]
	~PPKEKBLDDIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3208860", Offset = "0x3207C60", VA = "0x183208860")]
	protected bool FIAILKDOPGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3208C90", Offset = "0x3208090", VA = "0x183208C90")]
	protected void NBBNPIGEGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3208AE0", Offset = "0x3207EE0", VA = "0x183208AE0")]
	protected void MPOMLFNCCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x28FE6F0", Offset = "0x28FDAF0", VA = "0x1828FE6F0")]
	private static void KNMLPACHLAE<U>(ref List<U> DAAFDLFCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3208710", Offset = "0x3207B10", VA = "0x183208710", Slot = "4")]
	public void BPAJKKAGPKB(T JJGHIEJCCDA, bool GLAMKMBICFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x32085D0", Offset = "0x32079D0", VA = "0x1832085D0", Slot = "5")]
	public void BIHKNNPGGKP(T JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x32089B0", Offset = "0x3207DB0", VA = "0x1832089B0")]
	public void LKLKGDMFMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OKNNKFGFODL : global::PPKEKBLDDIK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE180", Offset = "0x3BED580", VA = "0x183BEE180")]
	public OKNNKFGFODL(bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDF70", Offset = "0x3BED370", VA = "0x183BEDF70")]
	public void CNFDGDEOPPF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDF10", Offset = "0x3BED310", VA = "0x183BEDF10")]
	public static OKNNKFGFODL BPJDFPACLMK(OKNNKFGFODL CMLAHPHDOHI, Action JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE120", Offset = "0x3BED520", VA = "0x183BEE120")]
	public static OKNNKFGFODL GMNMHGMFGOL(OKNNKFGFODL CMLAHPHDOHI, Action JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AGHMNFKGBEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPAJKKAGPKB(Action<T> JJGHIEJCCDA, bool GLAMKMBICFD = false);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIHKNNPGGKP(Action<T> JJGHIEJCCDA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MFBGLIHGCGO<T> : global::PPKEKBLDDIK<Action<T>>, global::AGHMNFKGBEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1921100", Offset = "0x1920500", VA = "0x181921100")]
	public MFBGLIHGCGO(bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x21FBB60", Offset = "0x21FAF60", VA = "0x1821FBB60")]
	public void CNFDGDEOPPF(T LIMOILDIGKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x19206C0", Offset = "0x191FAC0", VA = "0x1819206C0")]
	public static global::MFBGLIHGCGO<T> BPJDFPACLMK(global::MFBGLIHGCGO<T> CMLAHPHDOHI, Action<T> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1921060", Offset = "0x1920460", VA = "0x181921060")]
	public static global::MFBGLIHGCGO<T> GMNMHGMFGOL(global::MFBGLIHGCGO<T> CMLAHPHDOHI, Action<T> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface PLMKONNFGHB<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IILCGFIHJLP<T, U> : global::PPKEKBLDDIK<Action<T, U>>, global::PLMKONNFGHB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1921100", Offset = "0x1920500", VA = "0x181921100")]
	public IILCGFIHJLP(bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2B08600", Offset = "0x2B07A00", VA = "0x182B08600")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x19206C0", Offset = "0x191FAC0", VA = "0x1819206C0")]
	public static global::IILCGFIHJLP<T, U> BPJDFPACLMK(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1921060", Offset = "0x1920460", VA = "0x181921060")]
	public static global::IILCGFIHJLP<T, U> GMNMHGMFGOL(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NBPOLJHGGLE<T, U, V> : global::PPKEKBLDDIK<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1921100", Offset = "0x1920500", VA = "0x181921100")]
	public NBPOLJHGGLE(bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x24A5B40", Offset = "0x24A4F40", VA = "0x1824A5B40")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x19206C0", Offset = "0x191FAC0", VA = "0x1819206C0")]
	public static global::NBPOLJHGGLE<T, U, V> BPJDFPACLMK(global::NBPOLJHGGLE<T, U, V> CMLAHPHDOHI, Action<T, U, V> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1921060", Offset = "0x1920460", VA = "0x181921060")]
	public static global::NBPOLJHGGLE<T, U, V> GMNMHGMFGOL(global::NBPOLJHGGLE<T, U, V> CMLAHPHDOHI, Action<T, U, V> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ENNICJBIMKP<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class AAPEGDHKHJI<T, U, V, W> : global::PPKEKBLDDIK<Action<T, U, V, W>>, global::ENNICJBIMKP<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1921100", Offset = "0x1920500", VA = "0x181921100")]
	public AAPEGDHKHJI(bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE7A0", Offset = "0x1FADBA0", VA = "0x181FAE7A0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x19206C0", Offset = "0x191FAC0", VA = "0x1819206C0")]
	public static global::AAPEGDHKHJI<T, U, V, W> BPJDFPACLMK(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1921060", Offset = "0x1920460", VA = "0x181921060")]
	public static global::AAPEGDHKHJI<T, U, V, W> GMNMHGMFGOL(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EAHPNACBLDD<T, U, V, W, X> : global::PPKEKBLDDIK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1921100", Offset = "0x1920500", VA = "0x181921100")]
	public EAHPNACBLDD(bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1920760", Offset = "0x191FB60", VA = "0x181920760")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND, X NDILEEFABJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x19206C0", Offset = "0x191FAC0", VA = "0x1819206C0")]
	public static global::EAHPNACBLDD<T, U, V, W, X> BPJDFPACLMK(global::EAHPNACBLDD<T, U, V, W, X> CMLAHPHDOHI, Action<T, U, V, W, X> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1921060", Offset = "0x1920460", VA = "0x181921060")]
	public static global::EAHPNACBLDD<T, U, V, W, X> GMNMHGMFGOL(global::EAHPNACBLDD<T, U, V, W, X> CMLAHPHDOHI, Action<T, U, V, W, X> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DJEFEGOJFPA<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate bool IJPAKLJLNOI(global::DJEFEGOJFPA<T> IKFLAODDALD);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class IHHEENOOOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public global::DJEFEGOJFPA<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1730760", Offset = "0x172FB60", VA = "0x181730760")]
		public IHHEENOOOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1927040", Offset = "0x1926440", VA = "0x181927040")]
		internal bool <FindNode>b__0(global::DJEFEGOJFPA<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public T KMNOCFGOOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public LinkedList<global::DJEFEGOJFPA<T>> OLPMOFBKJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public global::DJEFEGOJFPA<T> KGCFPFPDJPM;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::DJEFEGOJFPA<T> MEHAAMLFBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x46ED30", Offset = "0x46E130", VA = "0x18046ED30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x19179A0", Offset = "0x1916DA0", VA = "0x1819179A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DGHLKNONJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x19178F0", Offset = "0x1916CF0", VA = "0x1819178F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FKGBKNHFJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1917B20", Offset = "0x1916F20", VA = "0x181917B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::DJEFEGOJFPA<T> FFDEELPIEJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1917920", Offset = "0x1916D20", VA = "0x181917920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1919900", Offset = "0x1918D00", VA = "0x181919900")]
	public DJEFEGOJFPA(T KEPEHMMFIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1918130", Offset = "0x1917530", VA = "0x181918130")]
	public global::DJEFEGOJFPA<T> NBIOIKFGOLK(T BLEIKCEPEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1918250", Offset = "0x1917650", VA = "0x181918250")]
	public global::DJEFEGOJFPA<T> NIHHKMAKGGP(T MJJAEOPELND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1917390", Offset = "0x1916790", VA = "0x181917390")]
	public global::DJEFEGOJFPA<T> BIHKNNPGGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1917DF0", Offset = "0x19171F0", VA = "0x181917DF0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1918D30", Offset = "0x1918130", VA = "0x181918D30")]
	public global::DJEFEGOJFPA<T> ONEGNLENCDK(T ICJLNPKIMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x19185E0", Offset = "0x19179E0", VA = "0x1819185E0")]
	public static void ONBECCDMLGM(global::DJEFEGOJFPA<T> MPGOABMOIAA, IJPAKLJLNOI BDNPNGGCFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1C8C220", Offset = "0x1C8B620", VA = "0x181C8C220")]
	public static void ONBECCDMLGM<A>(global::DJEFEGOJFPA<T> MPGOABMOIAA, Func<global::DJEFEGOJFPA<T>, A, bool> BDNPNGGCFPN, A OHFMPKJCLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1919360", Offset = "0x1918760", VA = "0x181919360")]
	public static string PODKJCBOELP(global::DJEFEGOJFPA<T> MPGOABMOIAA, int MBLPPLGFEAE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x19176D0", Offset = "0x1916AD0", VA = "0x1819176D0")]
	public static global::DJEFEGOJFPA<T> CDAKJDLNDOI(global::DJEFEGOJFPA<T> MPGOABMOIAA, T EDMDPOICPON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class CPHIIFBLCDH<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate int MPDHPMIIDDC(TKey DNGKIAJLLHG, TVal ONGBFDACHHG);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class NAGHLDJNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey AKFDMGLACLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4121A0", Offset = "0x4115A0", VA = "0x1804121A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal DMLIOOCLKKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x5791D0", Offset = "0x5785D0", VA = "0x1805791D0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x836D60", Offset = "0x836160", VA = "0x180836D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DBLCENPKMBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x4C6E80", Offset = "0x4C6280", VA = "0x1804C6E80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x4C6EB0", Offset = "0x4C62B0", VA = "0x1804C6EB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime JKNPCOLJCFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x414CF0", Offset = "0x4140F0", VA = "0x180414CF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x43B7D0", Offset = "0x43ABD0", VA = "0x18043B7D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E120A0", Offset = "0x1E114A0", VA = "0x181E120A0")]
		public NAGHLDJNNAJ(TKey DNGKIAJLLHG, TVal MBJCIBHEOMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public const int KMGLNDMLDGP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Dictionary<TKey, LinkedListNode<NAGHLDJNNAJ>> LIAHAAIFHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly LinkedList<NAGHLDJNNAJ> OCFDPNPCFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly MPDHPMIIDDC OFPCFKKBIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly TimeSpan CHAADHJMNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CJHBFCGNJFA MFMGHDDBPAB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int GNJACFKGBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4CFFB0", Offset = "0x4CF3B0", VA = "0x1804CFFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool DPNLGBNIPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F5F0", Offset = "0x1E0E9F0", VA = "0x181E0F5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int BIIJACLJEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4CFFC0", Offset = "0x4CF3C0", VA = "0x1804CFFC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4C5000", Offset = "0x4C4400", VA = "0x1804C5000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F680", Offset = "0x1E0EA80", VA = "0x181E0F680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E102E0", Offset = "0x1E0F6E0", VA = "0x181E102E0")]
	public CPHIIFBLCDH(int NPKCAEOBEMO, [Optional] MPDHPMIIDDC OFPCFKKBIFN, [Optional] IEqualityComparer<TKey> HDCCPNMDACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E105D0", Offset = "0x1E0F9D0", VA = "0x181E105D0")]
	public CPHIIFBLCDH(int NPKCAEOBEMO, MPDHPMIIDDC OFPCFKKBIFN, TimeSpan CHAADHJMNPA, [Optional] IEqualityComparer<TKey> HDCCPNMDACM, [Optional] CJHBFCGNJFA MFMGHDDBPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E0F080", Offset = "0x1E0E480", VA = "0x181E0F080")]
	public void CHMGPFLMEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E0ECC0", Offset = "0x1E0E0C0", VA = "0x181E0ECC0")]
	public void BDJFGEJFPPO(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E0ED80", Offset = "0x1E0E180", VA = "0x181E0ED80")]
	public bool BIHKNNPGGKP(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E0F800", Offset = "0x1E0EC00", VA = "0x181E0F800")]
	public bool IMCPFLDKEOH(TKey LFHKOFIPIEK, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FC90", Offset = "0x1E0F090", VA = "0x181E0FC90")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E0EF00", Offset = "0x1E0E300", VA = "0x181E0EF00")]
	private bool CHGILPBCJJD(NAGHLDJNNAJ KNAIJICNDHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FF90", Offset = "0x1E0F390", VA = "0x181E0FF90")]
	private void NMABOMIEHEE(LinkedListNode<NAGHLDJNNAJ> CDGLMCIFCBO, TVal BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E0F3E0", Offset = "0x1E0E7E0", VA = "0x181E0F3E0")]
	private void DOEHAPOJMON(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FAF0", Offset = "0x1E0EEF0", VA = "0x181E0FAF0")]
	private void LEOHCFPGCKH(NAGHLDJNNAJ KNAIJICNDHB, TVal BCEFAKDFEMM, int LNABDPGDHED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class MOJKPPDFFGJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly List<T> DAAFDLFCOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private HashSet<T> PGEAGKHLMIG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x17349E0", Offset = "0x1733DE0", VA = "0x1817349E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool PCENHAOIBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x412E40", Offset = "0x412240", VA = "0x180412E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x24A50C0", Offset = "0x24A44C0", VA = "0x1824A50C0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x24A51B0", Offset = "0x24A45B0", VA = "0x1824A51B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1B700E0", Offset = "0x1B6F4E0", VA = "0x181B700E0", Slot = "11")]
	public void Add(T IOBEPGLJNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x24A4CA0", Offset = "0x24A40A0", VA = "0x1824A4CA0")]
	public bool JPIFKHDPKLD(T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x24A4EE0", Offset = "0x24A42E0", VA = "0x1824A4EE0", Slot = "15")]
	public bool Remove(T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x24A49E0", Offset = "0x24A3DE0", VA = "0x1824A49E0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9A570", Offset = "0x1F99970", VA = "0x181F9A570", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x24A4920", Offset = "0x24A3D20", VA = "0x1824A4920", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x24A4980", Offset = "0x24A3D80", VA = "0x1824A4980", Slot = "13")]
	public bool Contains(T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x24A49B0", Offset = "0x24A3DB0", VA = "0x1824A49B0", Slot = "14")]
	public void CopyTo(T[] OPEBNMBKJJA, int JJBEHBJNJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x21F73A0", Offset = "0x21F67A0", VA = "0x1821F73A0", Slot = "6")]
	public int IndexOf(T IOBEPGLJNIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x24A4B30", Offset = "0x24A3F30", VA = "0x1824A4B30", Slot = "7")]
	public void Insert(int EFBDCIJMFGD, T IOBEPGLJNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x24A4E10", Offset = "0x24A4210", VA = "0x1824A4E10", Slot = "8")]
	public void RemoveAt(int EFBDCIJMFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x24A4FF0", Offset = "0x24A43F0", VA = "0x1824A4FF0")]
	public MOJKPPDFFGJ()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x22C70F0", Offset = "0x22C64F0", VA = "0x1822C70F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE890", Offset = "0x3BEDC90", VA = "0x183BEE890")]
		public SerializedGuid(in Guid COFLAJFOPEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE810", Offset = "0x3BEDC10", VA = "0x183BEE810")]
		public static SerializedGuid PECEFFJNJCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE640", Offset = "0x3BEDA40", VA = "0x183BEE640")]
		public static SerializedGuid KEBCJKEKCLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE6C0", Offset = "0x3BEDAC0", VA = "0x183BEE6C0")]
		public bool MEBGJGNMIMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE7F0", Offset = "0x3BEDBF0", VA = "0x183BEE7F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE750", Offset = "0x3BEDB50", VA = "0x183BEE750", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE4B0", Offset = "0x3BED8B0", VA = "0x183BEE4B0", Slot = "7")]
		public bool Equals(SerializedGuid HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE550", Offset = "0x3BED950", VA = "0x183BEE550", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE630", Offset = "0x3BEDA30", VA = "0x183BEE630", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3BEE480", Offset = "0x3BED880", VA = "0x183BEE480", Slot = "6")]
		public int CompareTo(SerializedGuid HPKICPNGMDJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class GHNKMPMKPPL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly Type GKNKEKPPLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly string PLJKDMKPGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly bool PJFHNKEINDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool GFHGEHPLIDC;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC4D0", Offset = "0x3BEB8D0", VA = "0x183BEC4D0")]
	public GHNKMPMKPPL(Type JMFLBLMBNKK, string KECHIFBPPED, bool JAIKKDFAMGK = false, bool KCOKJMBLCHE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface JDGADLJCIJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool KOIKDFBKFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JDGADLJCIJC<T> LHHAHBBBDOA(Action<T> CIBJIOPEHOJ);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::JDGADLJCIJC<T> ONIEADDFNIG(Action<T> CIBJIOPEHOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class LNGJEDLLFHG<T> : global::JDGADLJCIJC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private global::IILCGFIHJLP<T, T> DLDIJOMCDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private global::MFBGLIHGCGO<T> GOEJCGOLDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private global::MFBGLIHGCGO<string> FFIBBFANJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private string MOPOMPHBHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T GIAOBLMEMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool NEEKOHCDENC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x439670", Offset = "0x438A70", VA = "0x180439670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x21F4E50", Offset = "0x21F4250", VA = "0x1821F4E50", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KOIKDFBKFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4C4DE0", Offset = "0x4C41E0", VA = "0x1804C4DE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x21F4D50", Offset = "0x21F4150", VA = "0x1821F4D50")]
	private void CPDEMFAEBMA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x21F4DD0", Offset = "0x21F41D0", VA = "0x1821F4DD0", Slot = "4")]
	public global::JDGADLJCIJC<T> LHHAHBBBDOA(Action<T> COCKCCFIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x21F4E80", Offset = "0x21F4280", VA = "0x1821F4E80", Slot = "5")]
	public global::JDGADLJCIJC<T> ONIEADDFNIG(Action<T> CIBJIOPEHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x21F4EB0", Offset = "0x21F42B0", VA = "0x1821F4EB0")]
	public LNGJEDLLFHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class PNGLIKCFGDE
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class COCCCIAHGPA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public global::JDGADLJCIJC<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public global::CBLLFJEDOII<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1730760", Offset = "0x172FB60", VA = "0x181730760")]
		public COCCCIAHGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x31FA9F0", Offset = "0x31F9DF0", VA = "0x1831FA9F0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x20E4A30", Offset = "0x20E3E30", VA = "0x1820E4A30")]
	public static global::PMGCJEPKFOF<T> DDGIPHJPODB<T>(this global::JDGADLJCIJC<T> BOPFDMGIMPK, Action<T> AFLPGGJMPOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class CJHBFCGNJFA
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class HIKPHEBEPCE : CJHBFCGNJFA
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static CJHBFCGNJFA ONCPNMDGGKG
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x3BEC9D0", Offset = "0x3BEBDD0", VA = "0x183BEC9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime GJMKMFNGGDF
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x3BEC980", Offset = "0x3BEBD80", VA = "0x183BEC980", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3BECAC0", Offset = "0x3BEBEC0", VA = "0x183BECAC0")]
		public HIKPHEBEPCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static CJHBFCGNJFA AKAMNPLKANB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static CJHBFCGNJFA EDLIKGJFHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3BEBFE0", Offset = "0x3BEB3E0", VA = "0x183BEBFE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime GJMKMFNGGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4149D0", Offset = "0x413DD0", VA = "0x1804149D0")]
	protected CJHBFCGNJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class PIDMLFKAEJP : global::AFLBJKBIMFL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE1E0", Offset = "0x3BED5E0", VA = "0x183BEE1E0")]
	public PIDMLFKAEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class AFLBJKBIMFL<T> : global::IKAEDJBFIMM<T>, LMNJIGBCDFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4121A0", Offset = "0x4115A0", VA = "0x1804121A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x412190", Offset = "0x411590", VA = "0x180412190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1730780", Offset = "0x172FB80", VA = "0x181730780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1EAEE70", Offset = "0x1EAE270", VA = "0x181EAEE70")]
	public AFLBJKBIMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x412E00", Offset = "0x412200", VA = "0x180412E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class COOJEJBKMJN<T> : global::IKAEDJBFIMM<T>, LMNJIGBCDFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4121A0", Offset = "0x4115A0", VA = "0x1804121A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x412190", Offset = "0x411590", VA = "0x180412190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1730780", Offset = "0x172FB80", VA = "0x181730780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1E0EB10", Offset = "0x1E0DF10", VA = "0x181E0EB10")]
	public COOJEJBKMJN(Exception CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x412E00", Offset = "0x412200", VA = "0x180412E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface LMNJIGBCDFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	DABKFAIHBBP BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IKAEDJBFIMM<T> : LMNJIGBCDFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class GPMPDFCGLHC<TTask, T> : global::IKAEDJBFIMM<T>, LMNJIGBCDFB, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OIDNALEJNEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::GPMPDFCGLHC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1730760", Offset = "0x172FB60", VA = "0x181730760")]
		public OIDNALEJNEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LIGEKDBLAPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public OIDNALEJNEK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1730760", Offset = "0x172FB60", VA = "0x181730760")]
		public LIGEKDBLAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1F98110", Offset = "0x1F97510", VA = "0x181F98110")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static bool GNLEBJGHBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly global::CBLLFJEDOII<T> CBJFAFPEEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Task<T> CFNPEPPKEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly CancellationTokenSource HJBPDABGMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private bool KGACOELMNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private SynchronizationContext KBBHKPGPKOL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x412190", Offset = "0x411590", VA = "0x180412190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4121A0", Offset = "0x4115A0", VA = "0x1804121A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4121A0", Offset = "0x4115A0", VA = "0x1804121A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OANHDHKALEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x552D70", Offset = "0x552170", VA = "0x180552D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1F96660", Offset = "0x1F95A60", VA = "0x181F96660")]
	static GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1F967D0", Offset = "0x1F95BD0", VA = "0x181F967D0")]
	protected GPMPDFCGLHC(TTask CFNPEPPKEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1F96050", Offset = "0x1F95450", VA = "0x181F96050", Slot = "1")]
	~GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1F95EE0", Offset = "0x1F952E0", VA = "0x181F95EE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1F96210", Offset = "0x1F95610", VA = "0x181F96210")]
	private void MDDAPCCABNK(bool CNDHCDEIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KMLPECLHIFN(TTask LIPAKCCDNKD);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void CFMNLNIIPIF();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1F95DD0", Offset = "0x1F951D0", VA = "0x181F95DD0")]
	protected void COCHLMCDGCA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1F96190", Offset = "0x1F95590", VA = "0x181F96190")]
	protected void GGLDPDNDEHO(string MOPOMPHBHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1F95FB0", Offset = "0x1F953B0", VA = "0x181F95FB0")]
	[CompilerGenerated]
	private void EPHFENKGCHO(object BMEGDKCCBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EFHMLIMBKPE<T> : IEnumerable<global::EFHMLIMBKPE<T>.KANNECPCOLP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct KANNECPCOLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public T ONGBFDACHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int EFBDCIJMFGD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class KCNNGNNFBDL : IEnumerator<KANNECPCOLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private global::EFHMLIMBKPE<T> FLLHBFDLKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int EFBDCIJMFGD;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x1928280", Offset = "0x1927680", VA = "0x181928280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public KANNECPCOLP KAFEDPEFLOI
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x19282F0", Offset = "0x19276F0", VA = "0x1819282F0", Slot = "4")]
			get
			{
				return default(KANNECPCOLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5A7F40", Offset = "0x5A7340", VA = "0x1805A7F40")]
		public KCNNGNNFBDL(global::EFHMLIMBKPE<T> FLLHBFDLKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x19281F0", Offset = "0x19275F0", VA = "0x1819281F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5A7F30", Offset = "0x5A7330", VA = "0x1805A7F30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x745660", Offset = "0x744A60", VA = "0x180745660", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct LIBGGEJODOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public bool KNLALBPCPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public T ONGBFDACHHG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private const int NHJIENICHMB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Dictionary<T, int> IBPECDLABOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private LIBGGEJODOA[] EPEPLHDAKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int GLKDNFHHAOE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x18442D0", Offset = "0x18436D0", VA = "0x1818442D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1922A60", Offset = "0x1921E60", VA = "0x181922A60")]
	public static global::EFHMLIMBKPE<T> OGGMCNEPMDA(KANNECPCOLP[] PPCOBBGKGCP, bool DBGPHICABDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1922E90", Offset = "0x1922290", VA = "0x181922E90")]
	public EFHMLIMBKPE(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1922A10", Offset = "0x1921E10", VA = "0x181922A10")]
	public int KNHMLMKIOCH(T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1922760", Offset = "0x1921B60", VA = "0x181922760")]
	public T DDGIPHJPODB(int EFBDCIJMFGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x19229A0", Offset = "0x1921DA0", VA = "0x1819229A0")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x19227D0", Offset = "0x1921BD0", VA = "0x1819227D0")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG, int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1922620", Offset = "0x1921A20", VA = "0x181922620")]
	public KANNECPCOLP[] CAPGKOJNBIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x19229C0", Offset = "0x1921DC0", VA = "0x1819229C0")]
	private int KJMAGDFHGOD(int HKPHMBLKPFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1922E20", Offset = "0x1922220", VA = "0x181922E20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1922E20", Offset = "0x1922220", VA = "0x181922E20", Slot = "4")]
	private IEnumerator<KANNECPCOLP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class BDMFLDBGOFG<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private List<T> KEOFINNFAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<T> OJKMJBCKGFJ;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F410", Offset = "0x1D3E810", VA = "0x181D3F410")]
	public BDMFLDBGOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F440", Offset = "0x1D3E840", VA = "0x181D3F440")]
	public BDMFLDBGOFG(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F310", Offset = "0x1D3E710", VA = "0x181D3F310")]
	public T OBCMOHDGJNN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1D3F1F0", Offset = "0x1D3E5F0", VA = "0x181D3F1F0")]
	public void IOFOFLHIJGM(T IOKKOEMCNPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class LEOCHCLDMME<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	protected struct IFDCGAONOCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public T DMLIOOCLKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int LNEDNNJCPMG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected readonly List<IFDCGAONOCC> IKHCBHDLNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private T FINCIIOMABG;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x17349E0", Offset = "0x1733DE0", VA = "0x1817349E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x26B9B00", Offset = "0x26B8F00", VA = "0x1826B9B00")]
	public bool KCFPIEEMJON(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x26B99F0", Offset = "0x26B8DF0", VA = "0x1826B99F0")]
	public void BPAJKKAGPKB(T ONGBFDACHHG, int JMHKMOACHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x26B98D0", Offset = "0x26B8CD0", VA = "0x1826B98D0")]
	public bool BIHKNNPGGKP(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x26B9D50", Offset = "0x26B9150", VA = "0x1826B9D50")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x26B9A70", Offset = "0x26B8E70", VA = "0x1826B9A70")]
	public T HMBMDDOFIKL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x26B96C0", Offset = "0x26B8AC0", VA = "0x1826B96C0")]
	private void ABKEBNFHIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x26B9DB0", Offset = "0x26B91B0", VA = "0x1826B9DB0")]
	public LEOCHCLDMME()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1743990", Offset = "0x1742D90", VA = "0x181743990", Slot = "4")]
		public virtual T EDMOPEPBEHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1730760", Offset = "0x172FB60", VA = "0x181730760")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class OHFHKIPINGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Dictionary<byte, MHJBJPJHPFD> KDGPABMFDAP;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MHJBJPJHPFD FGCPPNAGAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4121A0", Offset = "0x4115A0", VA = "0x1804121A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x412440", Offset = "0x411840", VA = "0x180412440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 JKPGFDOGKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1012CD0", Offset = "0x10120D0", VA = "0x181012CD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1D417B0", Offset = "0x1D40BB0", VA = "0x181D417B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector2 JECNPCKFHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x16382D0", Offset = "0x16376D0", VA = "0x1816382D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 KIBOLBPKFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6820", Offset = "0x2DB5C20", VA = "0x182DB6820")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6840", Offset = "0x2DB5C40", VA = "0x182DB6840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int BPOLFMEDCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x43C1B0", Offset = "0x43B5B0", VA = "0x18043C1B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x461360", Offset = "0x460760", VA = "0x180461360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDA20", Offset = "0x3BECE20", VA = "0x183BEDA20")]
	public OHFHKIPINGN(Bounds HEJCIPIONHD, Vector2[] JJBMIAKPNFM, int ANHJMJFBOGC, byte HKPHMBLKPFI, float IKIIJCMDBLG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3BED7C0", Offset = "0x3BECBC0", VA = "0x183BED7C0")]
	public MHJBJPJHPFD HLCKAFHGBDM(byte EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3BED940", Offset = "0x3BECD40", VA = "0x183BED940")]
	public void NGKNKJMGCJO(Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE, ref List<byte> NPAGJNGHOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3BED7A0", Offset = "0x3BECBA0", VA = "0x183BED7A0")]
	public void GEPJEOGAEEH(MHJBJPJHPFD.HCMDPIPMANH KICELKEADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3BED820", Offset = "0x3BECC20", VA = "0x183BED820")]
	private MHJBJPJHPFD MOLJJAEIFLF(byte EFBDCIJMFGD, MHJBJPJHPFD.ENGKDHJBBKF OHEHDIDHCFP, MHJBJPJHPFD HICENEOPGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3BED280", Offset = "0x3BEC680", VA = "0x183BED280")]
	private void AIDPBIKEJGM(MHJBJPJHPFD HICENEOPGOF, Vector2[] JJBMIAKPNFM, int MJCNPBEHJKC, int LBLOCDFALDE, int MFNBLGJBBJP, int OKBDDEDMDOB, float IKIIJCMDBLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class MHJBJPJHPFD
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum ENGKDHJBBKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum HCMDPIPMANH
	{
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public byte JPOHGBCEJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Vector3 EFDKABIFNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Vector3 DBLCENPKMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Vector3 PIKANCCKHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 HMIBLLANHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public ENGKDHJBBKF DPDNBLNNCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public MHJBJPJHPFD MEHAAMLFBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public List<MHJBJPJHPFD> DMJMAGENMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool LAMKCBNADPI;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3BECF30", Offset = "0x3BEC330", VA = "0x183BECF30")]
	public MHJBJPJHPFD(byte ENJEOLBEALP, ENGKDHJBBKF OHEHDIDHCFP, MHJBJPJHPFD HICENEOPGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3BECC10", Offset = "0x3BEC010", VA = "0x183BECC10")]
	public void NBIOIKFGOLK(MHJBJPJHPFD MLDKMIGAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x412E00", Offset = "0x412200", VA = "0x180412E00")]
	public void GEPJEOGAEEH(int IDMAJACDJMF, HCMDPIPMANH KICELKEADCI, int NIIDNDCGMDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3BECCA0", Offset = "0x3BEC0A0", VA = "0x183BECCA0")]
	public void NGKNKJMGCJO(List<byte> NPAGJNGHOAE, Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3BECB70", Offset = "0x3BEBF70", VA = "0x183BECB70")]
	public bool BJFFCFNIFNF(Vector3 KPLDEODOJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3BECBD0", Offset = "0x3BEBFD0", VA = "0x183BECBD0")]
	public bool IKJGCMKLGKF(Vector3 KPLDEODOJID, float BIMDOAEJMPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BEPMBLAHCML<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int NPKCAEOBEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int ONGEGPPEIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<T> FEBHFIMEJPN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public T FLAGPNDNLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1D40B60", Offset = "0x1D3FF60", VA = "0x181D40B60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T ENONEADFACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x1D40B20", Offset = "0x1D3FF20", VA = "0x181D40B20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T IBDJAKGMLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1D40720", Offset = "0x1D3FB20", VA = "0x181D40720")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x1D40CD0", Offset = "0x1D400D0", VA = "0x181D40CD0")]
	public BEPMBLAHCML(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1D40920", Offset = "0x1D3FD20", VA = "0x181D40920")]
	public void BPAJKKAGPKB(T LMJGGCEBDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1D40A70", Offset = "0x1D3FE70", VA = "0x181D40A70")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1D40C80", Offset = "0x1D40080", VA = "0x181D40C80")]
	public void OOAIDMBHDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1D40A60", Offset = "0x1D3FE60", VA = "0x181D40A60")]
	public void HEBIFJELCPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class BJOIBBBOIKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct OPALEOIDFEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int LNEDNNJCPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public T DMLIOOCLKKP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Dictionary<object, OPALEOIDFEP> IOHBEHECBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private T LEDAAPCCHHA;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T FNCFALEFNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1012CD0", Offset = "0x10120D0", VA = "0x181012CD0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1D417B0", Offset = "0x1D40BB0", VA = "0x181D417B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1D41810", Offset = "0x1D40C10", VA = "0x181D41810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object KJFJIIDJCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x414CF0", Offset = "0x4140F0", VA = "0x180414CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x43B7D0", Offset = "0x43ABD0", VA = "0x18043B7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1D41510", Offset = "0x1D40910", VA = "0x181D41510")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI, int JMHKMOACHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1D41840", Offset = "0x1D40C40", VA = "0x181D41840")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1D41BF0", Offset = "0x1D40FF0", VA = "0x181D41BF0")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1D41EC0", Offset = "0x1D412C0", VA = "0x181D41EC0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1D44C80", Offset = "0x1D44080", VA = "0x181D44C80")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x1D46F20", Offset = "0x1D46320", VA = "0x181D46F20")]
	public BJOIBBBOIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class POJFBLMLAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Dictionary<object, float> IOHBEHECBGL;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float JABPFAJNKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xB47A90", Offset = "0xB46E90", VA = "0x180B47A90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DA80", Offset = "0xA5CE80", VA = "0x180A5DA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE340", Offset = "0x3BED740", VA = "0x183BEE340")]
	public void DOEHAPOJMON(float ONGBFDACHHG, object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE3B0", Offset = "0x3BED7B0", VA = "0x183BEE3B0")]
	public void HAHBGOMEMEE(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE220", Offset = "0x3BED620", VA = "0x183BEE220")]
	private void BHHBAENFOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE410", Offset = "0x3BED810", VA = "0x183BEE410")]
	public POJFBLMLAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class AOLMGGAPKEH
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class INIIDHCNCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly string BIELLBOJOCP;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4149D0", Offset = "0x413DD0", VA = "0x1804149D0")]
		private INIIDHCNCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4AA560", Offset = "0x4A9960", VA = "0x1804AA560")]
		public INIIDHCNCLK(string BIELLBOJOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3BECB20", Offset = "0x3BEBF20", VA = "0x183BECB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class HHHAHKJKNHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4149D0", Offset = "0x413DD0", VA = "0x1804149D0")]
		public HHHAHKJKNHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC8D0", Offset = "0x3BEBCD0", VA = "0x183BEC8D0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly HashSet<object> BGKNMHEJLMM;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool CFLJGNJLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3BEBA70", Offset = "0x3BEAE70", VA = "0x183BEBA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3BEB960", Offset = "0x3BEAD60", VA = "0x183BEB960")]
	public void BPAJKKAGPKB(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3BEB900", Offset = "0x3BEAD00", VA = "0x183BEB900")]
	public void BIHKNNPGGKP(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3BEB9C0", Offset = "0x3BEADC0", VA = "0x183BEB9C0")]
	public bool KCFPIEEMJON(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBA20", Offset = "0x3BEAE20", VA = "0x183BEBA20")]
	public void KFKPHICNHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBAB0", Offset = "0x3BEAEB0", VA = "0x183BEBAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBC10", Offset = "0x3BEB010", VA = "0x183BEBC10")]
	public AOLMGGAPKEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HHIINKNOKNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private struct NNOOBABINMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float NJNCDDAIBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public T DMLIOOCLKKP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<object, NNOOBABINMN> IOHBEHECBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private T MAJHCJGJKPN;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T NKIEOKALHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xC94CF0", Offset = "0xC940F0", VA = "0x180C94CF0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1D41790", Offset = "0x1D40B90", VA = "0x181D41790", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object GEDFELNLNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x439670", Offset = "0x438A70", VA = "0x180439670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4AD620", Offset = "0x4ACA20", VA = "0x1804AD620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2B93A50", Offset = "0x2B92E50", VA = "0x182B93A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2B93390", Offset = "0x2B92790", VA = "0x182B93390")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2B93A90", Offset = "0x2B92E90", VA = "0x182B93A90")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x1D41EC0", Offset = "0x1D412C0", VA = "0x181D41EC0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2B93B50", Offset = "0x2B92F50", VA = "0x182B93B50")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2B945D0", Offset = "0x2B939D0", VA = "0x182B945D0")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2B95AB0", Offset = "0x2B94EB0", VA = "0x182B95AB0")]
	public HHIINKNOKNL()
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
