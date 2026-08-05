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
	[Cpp2IlInjected.Address(RVA = "0x5B5CB0", Offset = "0x5B50B0", VA = "0x1805B5CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x400970", Offset = "0x3FFD70", VA = "0x180400970")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x46CC50", Offset = "0x46C050", VA = "0x18046CC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3FFE70", Offset = "0x3FF270", VA = "0x1803FFE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "4")]
	public virtual void COBDCEFIEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D38100", Offset = "0x1D37500", VA = "0x181D38100", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D37C40", Offset = "0x1D37040", VA = "0x181D37C40", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D38700", Offset = "0x1D37B00", VA = "0x181D38700")]
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
	private sealed class KFFBMKAJEHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public KFFBMKAJEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D13700", Offset = "0x1D12B00", VA = "0x181D13700")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[CJOEKDOBHDG]
	public List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F390", Offset = "0x1D0E790", VA = "0x181D0F390", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F3C0", Offset = "0x1D0E7C0", VA = "0x181D0F3C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F2E0", Offset = "0x1D0E6E0", VA = "0x181D0F2E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey DNGKIAJLLHG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F340", Offset = "0x1D0E740", VA = "0x181D0F340", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F1F0", Offset = "0x1D0E5F0", VA = "0x181D0F1F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EA60", Offset = "0x1D0DE60", VA = "0x181D0EA60", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E3D0", Offset = "0x1D0D7D0", VA = "0x181D0E3D0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E030", Offset = "0x1D0D430", VA = "0x181D0E030", Slot = "14")]
	protected virtual string LKCOLBMMLKA(TKeyVal GALGADHFCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DF10", Offset = "0x1D0D310", VA = "0x181D0DF10", Slot = "4")]
	public bool ContainsKey(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F0F0", Offset = "0x1D0E4F0", VA = "0x181D0F0F0", Slot = "5")]
	public bool TryGetValue(TKey DNGKIAJLLHG, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DF40", Offset = "0x1D0D340", VA = "0x181D0DF40", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D0DF40", Offset = "0x1D0D340", VA = "0x181D0DF40", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F120", Offset = "0x1D0E520", VA = "0x181D0F120")]
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

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public FIOCHCGPCBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x358E2C0", Offset = "0x358D6C0", VA = "0x18358E2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x358E340", Offset = "0x358D740", VA = "0x18358E340", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x358E690", Offset = "0x358DA90", VA = "0x18358E690")]
	public static void RegisterDontDestroyOnLoad(GameObject NNNMGKGMIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x358E4B0", Offset = "0x358D8B0", VA = "0x18358E4B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x358E730", Offset = "0x358DB30", VA = "0x18358E730")]
	[IteratorStateMachine(typeof(FIOCHCGPCBF))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "6")]
	protected virtual void BFNKJCLBGIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x358E7F0", Offset = "0x358DBF0", VA = "0x18358E7F0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CGINBDPPLIO
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x146B2E0", Offset = "0x146A6E0", VA = "0x18146B2E0")]
	public static void DFFNGCIAOME<T>(this T CKCMODJNCNF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x358E030", Offset = "0x358D430", VA = "0x18358E030")]
	public static void DFFNGCIAOME(this GameObject DOJCFCINALC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : MonoBehaviour where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static TImpl GCCLEJOGCCE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected static TImpl ONCPNMDGGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0D0", Offset = "0x3DD4D0", VA = "0x1803DE0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC630", Offset = "0x1DBBA30", VA = "0x181DBC630", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1DBCB00", Offset = "0x1DBBF00", VA = "0x181DBCB00", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F3F0", Offset = "0x1D0E7F0", VA = "0x181D0F3F0")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GameObject KGFPNIMJHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x95C440", Offset = "0x95B840", VA = "0x18095C440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x358EF00", Offset = "0x358E300", VA = "0x18358EF00")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x358F120", Offset = "0x358E520", VA = "0x18358F120")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E9770", Offset = "0x3E8B70", VA = "0x1803E9770")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static T GCCLEJOGCCE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static T ONCPNMDGGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0D0", Offset = "0x3DD4D0", VA = "0x1803DE0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool FFNIFALJLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D39540", Offset = "0x1D38940", VA = "0x181D39540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1D39000", Offset = "0x1D38400", VA = "0x181D39000", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1D39380", Offset = "0x1D38780", VA = "0x181D39380", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F3F0", Offset = "0x1D0E7F0", VA = "0x181D0F3F0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public NMKBADGNEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x22C0240", Offset = "0x22BF640", VA = "0x1822C0240")]
		internal bool <GetSamples>b__0(global::DHKPBIAHMHG<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float DHMHIHCJCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float CMCMIOPCFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private List<global::DHKPBIAHMHG<float, T>> PDACILKHJJG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BFMBCJLAKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x22B8500", Offset = "0x22B7900", VA = "0x1822B8500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x22B8980", Offset = "0x22B7D80", VA = "0x1822B8980")]
	public HKMGKEPIIGN(float sampleInterval, float windowLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x22B8600", Offset = "0x22B7A00", VA = "0x1822B8600")]
	public bool NNLAEHCFGLO(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x22B81A0", Offset = "0x22B75A0", VA = "0x1822B81A0")]
	public IEnumerable<T> BKGJKBJPEID(float MOPKOPOKKEE, [Optional] float? DJJCAALEIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22B84D0", Offset = "0x22B78D0", VA = "0x1822B84D0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22B88C0", Offset = "0x22B7CC0", VA = "0x1822B88C0")]
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
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T DMLIOOCLKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float NJNCDDAIBCM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static float MMAOMABFHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<T> FOBMBNCDNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const int KDCFAAKILOA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private PBCEHIBDGKN[] OPEBNMBKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private int DHDKFNGOPAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float LCJLABPBGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x400040", Offset = "0x3FF440", VA = "0x180400040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x400190", Offset = "0x3FF590", VA = "0x180400190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1906090", Offset = "0x1905490", VA = "0x181906090")]
	public GMNJGMLCABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x19060C0", Offset = "0x19054C0", VA = "0x1819060C0")]
	public GMNJGMLCABC(int size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1905230", Offset = "0x1904630", VA = "0x181905230")]
	public void BPAJKKAGPKB(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1905AF0", Offset = "0x1904EF0", VA = "0x181905AF0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1905600", Offset = "0x1904A00", VA = "0x181905600")]
	public bool IMMBIFHODMF(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1905990", Offset = "0x1904D90", VA = "0x181905990")]
	public bool KJPECKDEGGL(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1905EF0", Offset = "0x19052F0", VA = "0x181905EF0")]
	public void OCCODBALDOD(float JODPOANPJNK, float BCANLCHBKJE, List<T> NKHPHBOPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x19057B0", Offset = "0x1904BB0", VA = "0x1819057B0")]
	private int JDDBKHEGJHN(int NPDLAJLCALI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x19051F0", Offset = "0x19045F0", VA = "0x1819051F0")]
	private void BCADCIPJGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KPKMNLDBMEH();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T PIFFNJDGHDE(T ONGBFDACHHG, float LIMOILDIGKF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CAPOCJJJJIB(T LONDCJPNKKN, T PCEJJILDLGD);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JIODMOCKLKL(T LONDCJPNKKN, T PCEJJILDLGD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class APDBOLKPCBO : global::GMNJGMLCABC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x358DEC0", Offset = "0x358D2C0", VA = "0x18358DEC0", Slot = "4")]
	protected override Vector3 KPKMNLDBMEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x358DF30", Offset = "0x358D330", VA = "0x18358DF30", Slot = "5")]
	protected override Vector3 PIFFNJDGHDE(Vector3 ONGBFDACHHG, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x358DDA0", Offset = "0x358D1A0", VA = "0x18358DDA0", Slot = "6")]
	protected override Vector3 CAPOCJJJJIB(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x358DE50", Offset = "0x358D250", VA = "0x18358DE50", Slot = "7")]
	protected override Vector3 JIODMOCKLKL(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x358DFD0", Offset = "0x358D3D0", VA = "0x18358DFD0")]
	public APDBOLKPCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DLPGJKJFNCM
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x13BB7F0", Offset = "0x13BABF0", VA = "0x1813BB7F0")]
	public static global::DHKPBIAHMHG<T1, T2> NFHADFCEMML<T1, T2>(T1 OFCHPINAEEE, T2 NLNENAIDOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x13BB860", Offset = "0x13BAC60", VA = "0x1813BB860")]
	public static global::ELGBCKDBOED<T1, T2, T3> NFHADFCEMML<T1, T2, T3>(T1 OFCHPINAEEE, T2 NLNENAIDOJD, T3 FGPNPLGENDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2269FC0", Offset = "0x22693C0", VA = "0x182269FC0")]
	internal static int FBNEHNPAJDI(int JGPNKFEDCDB, int EDGDLDGIIMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29CA140", Offset = "0x29C9540", VA = "0x1829CA140")]
	internal static int FBNEHNPAJDI(int JGPNKFEDCDB, int EDGDLDGIIMI, int BLAJFLKDFED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DHKPBIAHMHG<T1, T2> : IComparable<global::DHKPBIAHMHG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 LBOPKDHLCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 JGIEIIFCNKP;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x14B01F0", Offset = "0x14AF5F0", VA = "0x1814B01F0")]
	public DHKPBIAHMHG(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x343D0B0", Offset = "0x343C4B0", VA = "0x18343D0B0", Slot = "4")]
	public int CompareTo(global::DHKPBIAHMHG<T1, T2> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x343D2E0", Offset = "0x343C6E0", VA = "0x18343D2E0", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x343D530", Offset = "0x343C930", VA = "0x18343D530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x343D750", Offset = "0x343CB50", VA = "0x18343D750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ELGBCKDBOED<T1, T2, T3> : IComparable<global::ELGBCKDBOED<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 LBOPKDHLCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 JGIEIIFCNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 KKMJPCLKNHO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B1C0", Offset = "0x1D0A5C0", VA = "0x181D0B1C0")]
	public ELGBCKDBOED(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AAE0", Offset = "0x1D09EE0", VA = "0x181D0AAE0", Slot = "4")]
	public int CompareTo(global::ELGBCKDBOED<T1, T2, T3> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1D0ACD0", Offset = "0x1D0A0D0", VA = "0x181D0ACD0", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AED0", Offset = "0x1D0A2D0", VA = "0x181D0AED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AF40", Offset = "0x1D0A340", VA = "0x181D0AF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x401420", Offset = "0x400820", VA = "0x180401420")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x400F00", Offset = "0x400300", VA = "0x180400F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float BPHIOMBNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2E0", Offset = "0x4EC6E0", VA = "0x1804ED2E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2DB1E80", Offset = "0x2DB1280", VA = "0x182DB1E80")]
	public T DHEIFNLDBKN(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2DB2120", Offset = "0x2DB1520", VA = "0x182DB2120")]
	public T NICCICAFMDM(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ADPELJHGHKK(T LONDCJPNKKN, T PCEJJILDLGD, float LIMOILDIGKF);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x358E390", Offset = "0x358D790", VA = "0x18358E390", Slot = "4")]
	protected override float ADPELJHGHKK(float LONDCJPNKKN, float PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x358E410", Offset = "0x358D810", VA = "0x18358E410")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3590940", Offset = "0x358FD40", VA = "0x183590940", Slot = "4")]
	protected override Vector3 ADPELJHGHKK(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3590A00", Offset = "0x358FE00", VA = "0x183590A00")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x357B0D0", Offset = "0x357A4D0", VA = "0x18357B0D0", Slot = "4")]
	protected override Color ADPELJHGHKK(Color LONDCJPNKKN, Color PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x358E280", Offset = "0x358D680", VA = "0x18358E280")]
	public ColorValueCurve()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MFDNONGFNNG
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct LAGCKEEFJFE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private T ONGBFDACHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private bool KJDHMJPNDCK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KOIKDFBKFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x16DA9F0", Offset = "0x16D9DF0", VA = "0x1816DA9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T DMLIOOCLKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4676F0", Offset = "0x466AF0", VA = "0x1804676F0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x231B6B0", Offset = "0x231AAB0", VA = "0x18231B6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x231B640", Offset = "0x231AA40", VA = "0x18231B640")]
		public void LKLKGDMFMCC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class GPFLNFOKEIA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private global::GPFLNFOKEIA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x400040", Offset = "0x3FF440", VA = "0x180400040", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x18FA270", Offset = "0x18F9670", VA = "0x1818FA270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x18FA660", Offset = "0x18F9A60", VA = "0x1818FA660")]
		public Enumerator(global::GPFLNFOKEIA<T> buffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x18F9900", Offset = "0x18F8D00", VA = "0x1818F9900", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x18FA080", Offset = "0x18F9480", VA = "0x1818FA080", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x18F9DE0", Offset = "0x18F91E0", VA = "0x1818F9DE0")]
		private void PKKNLKAHILA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] IKHCBHDLNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int HKPHMBLKPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int DJICGHFJJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int HNPBHLIOFNC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x19073B0", Offset = "0x19067B0", VA = "0x1819073B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1906CA0", Offset = "0x19060A0", VA = "0x181906CA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1906AD0", Offset = "0x1905ED0", VA = "0x181906AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1907940", Offset = "0x1906D40", VA = "0x181907940")]
	public GPFLNFOKEIA(int capacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1906750", Offset = "0x1905B50", VA = "0x181906750")]
	public void BPAJKKAGPKB(T LIMOILDIGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1906DC0", Offset = "0x19061C0", VA = "0x181906DC0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1906DE0", Offset = "0x19061E0", VA = "0x181906DE0")]
	public void NAJLLGFNIKC(int MNIJHBJDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1906E70", Offset = "0x1906270", VA = "0x181906E70")]
	public void NPAGGFDPFJK(T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1906A10", Offset = "0x1905E10", VA = "0x181906A10")]
	public Enumerator CINCGNABFNK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x19077B0", Offset = "0x1906BB0", VA = "0x1819077B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x19077B0", Offset = "0x1906BB0", VA = "0x1819077B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x19074E0", Offset = "0x19068E0", VA = "0x1819074E0")]
	private int PLMBLHMDABK(int EFBDCIJMFGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1906660", Offset = "0x1905A60", VA = "0x181906660")]
	private int BCDNPPPABOI(int EFBDCIJMFGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class KBNAHLKGDBF
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
	protected KBNAHLKGDBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class PPKEKBLDDIK<T> : KBNAHLKGDBF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	protected struct DBMLEBCMBFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
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
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	protected bool PGHLNJOLDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	protected readonly bool JNIOEAEOGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	protected readonly List<T> GGDHHMGKOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly List<DBMLEBCMBFG> JFKJECNEMEH;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MENDGJKDBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D1B0", Offset = "0x2E1C5B0", VA = "0x182E1D1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D4A0", Offset = "0x2E1C8A0", VA = "0x182E1D4A0")]
	public PPKEKBLDDIK(int capacity, bool useTryCatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D140", Offset = "0x2E1C540", VA = "0x182E1D140", Slot = "1")]
	~PPKEKBLDDIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D2F0", Offset = "0x2E1C6F0", VA = "0x182E1D2F0")]
	protected void MPOMLFNCCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D020", Offset = "0x2E1C420", VA = "0x182E1D020", Slot = "4")]
	public void BPAJKKAGPKB(T JJGHIEJCCDA, bool GLAMKMBICFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2E1CF00", Offset = "0x2E1C300", VA = "0x182E1CF00", Slot = "5")]
	public void BIHKNNPGGKP(T JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D1E0", Offset = "0x2E1C5E0", VA = "0x182E1D1E0")]
	public void LKLKGDMFMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OKNNKFGFODL : global::PPKEKBLDDIK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x35901A0", Offset = "0x358F5A0", VA = "0x1835901A0")]
	public OKNNKFGFODL(int capacity = 32, bool useTryCatch = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x358FEF0", Offset = "0x358F2F0", VA = "0x18358FEF0")]
	public void CNFDGDEOPPF(bool NOLKFLLKNOO = false)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x358FE90", Offset = "0x358F290", VA = "0x18358FE90")]
	public static OKNNKFGFODL BPJDFPACLMK(OKNNKFGFODL CMLAHPHDOHI, Action JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3590140", Offset = "0x358F540", VA = "0x183590140")]
	public static OKNNKFGFODL GMNMHGMFGOL(OKNNKFGFODL CMLAHPHDOHI, Action JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface AGHMNFKGBEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPAJKKAGPKB(Action<T> JJGHIEJCCDA, bool GLAMKMBICFD = false);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIHKNNPGGKP(Action<T> JJGHIEJCCDA);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MFBGLIHGCGO<T> : global::PPKEKBLDDIK<Action<T>>, global::AGHMNFKGBEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x14B9F60", Offset = "0x14B9360", VA = "0x1814B9F60")]
	public MFBGLIHGCGO(int capacity = 4, bool useTryCatch = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2323C40", Offset = "0x2323040", VA = "0x182323C40")]
	public void CNFDGDEOPPF(T LIMOILDIGKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x14B9420", Offset = "0x14B8820", VA = "0x1814B9420")]
	public static global::MFBGLIHGCGO<T> BPJDFPACLMK(global::MFBGLIHGCGO<T> CMLAHPHDOHI, Action<T> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EC0", Offset = "0x14B92C0", VA = "0x1814B9EC0")]
	public static global::MFBGLIHGCGO<T> GMNMHGMFGOL(global::MFBGLIHGCGO<T> CMLAHPHDOHI, Action<T> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PLMKONNFGHB<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class IILCGFIHJLP<T, U> : global::PPKEKBLDDIK<Action<T, U>>, global::PLMKONNFGHB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x14B9F60", Offset = "0x14B9360", VA = "0x1814B9F60")]
	public IILCGFIHJLP(int capacity = 32, bool useTryCatch = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x22BF310", Offset = "0x22BE710", VA = "0x1822BF310")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x14B9420", Offset = "0x14B8820", VA = "0x1814B9420")]
	public static global::IILCGFIHJLP<T, U> BPJDFPACLMK(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EC0", Offset = "0x14B92C0", VA = "0x1814B9EC0")]
	public static global::IILCGFIHJLP<T, U> GMNMHGMFGOL(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class NBPOLJHGGLE<T, U, V> : global::PPKEKBLDDIK<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x14B9F60", Offset = "0x14B9360", VA = "0x1814B9F60")]
	public NBPOLJHGGLE(int capacity = 32, bool useTryCatch = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x20BDB40", Offset = "0x20BCF40", VA = "0x1820BDB40")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x14B9420", Offset = "0x14B8820", VA = "0x1814B9420")]
	public static global::NBPOLJHGGLE<T, U, V> BPJDFPACLMK(global::NBPOLJHGGLE<T, U, V> CMLAHPHDOHI, Action<T, U, V> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EC0", Offset = "0x14B92C0", VA = "0x1814B9EC0")]
	public static global::NBPOLJHGGLE<T, U, V> GMNMHGMFGOL(global::NBPOLJHGGLE<T, U, V> CMLAHPHDOHI, Action<T, U, V> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ENNICJBIMKP<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class AAPEGDHKHJI<T, U, V, W> : global::PPKEKBLDDIK<Action<T, U, V, W>>, global::ENNICJBIMKP<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x14B9F60", Offset = "0x14B9360", VA = "0x1814B9F60")]
	public AAPEGDHKHJI(int capacity = 32, bool useTryCatch = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x154B6B0", Offset = "0x154AAB0", VA = "0x18154B6B0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x14B9420", Offset = "0x14B8820", VA = "0x1814B9420")]
	public static global::AAPEGDHKHJI<T, U, V, W> BPJDFPACLMK(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EC0", Offset = "0x14B92C0", VA = "0x1814B9EC0")]
	public static global::AAPEGDHKHJI<T, U, V, W> GMNMHGMFGOL(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class EAHPNACBLDD<T, U, V, W, X> : global::PPKEKBLDDIK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x14B9F60", Offset = "0x14B9360", VA = "0x1814B9F60")]
	public EAHPNACBLDD(int capacity = 32, bool useTryCatch = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x14B94C0", Offset = "0x14B88C0", VA = "0x1814B94C0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND, X NDILEEFABJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x14B9420", Offset = "0x14B8820", VA = "0x1814B9420")]
	public static global::EAHPNACBLDD<T, U, V, W, X> BPJDFPACLMK(global::EAHPNACBLDD<T, U, V, W, X> CMLAHPHDOHI, Action<T, U, V, W, X> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EC0", Offset = "0x14B92C0", VA = "0x1814B9EC0")]
	public static global::EAHPNACBLDD<T, U, V, W, X> GMNMHGMFGOL(global::EAHPNACBLDD<T, U, V, W, X> CMLAHPHDOHI, Action<T, U, V, W, X> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DJEFEGOJFPA<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool IJPAKLJLNOI(global::DJEFEGOJFPA<T> IKFLAODDALD);

	[Cpp2IlInjected.Token(Token = "0x200002D")]
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
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public IHHEENOOOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x14BEB10", Offset = "0x14BDF10", VA = "0x1814BEB10")]
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

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public global::DJEFEGOJFPA<T> MEHAAMLFBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3E24D0", Offset = "0x3E18D0", VA = "0x1803E24D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x14B08A0", Offset = "0x14AFCA0", VA = "0x1814B08A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool DGHLKNONJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x14B07F0", Offset = "0x14AFBF0", VA = "0x1814B07F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool FKGBKNHFJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x14B0A20", Offset = "0x14AFE20", VA = "0x1814B0A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public global::DJEFEGOJFPA<T> FFDEELPIEJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x14B0820", Offset = "0x14AFC20", VA = "0x1814B0820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x14B2800", Offset = "0x14B1C00", VA = "0x1814B2800")]
	public DJEFEGOJFPA(T nodeContent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x14B1030", Offset = "0x14B0430", VA = "0x1814B1030")]
	public global::DJEFEGOJFPA<T> NBIOIKFGOLK(T BLEIKCEPEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x14B1150", Offset = "0x14B0550", VA = "0x1814B1150")]
	public global::DJEFEGOJFPA<T> NIHHKMAKGGP(T MJJAEOPELND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x14B0290", Offset = "0x14AF690", VA = "0x1814B0290")]
	public global::DJEFEGOJFPA<T> BIHKNNPGGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x14B0CF0", Offset = "0x14B00F0", VA = "0x1814B0CF0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x14B1C30", Offset = "0x14B1030", VA = "0x1814B1C30")]
	public global::DJEFEGOJFPA<T> ONEGNLENCDK(T ICJLNPKIMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x14B14E0", Offset = "0x14B08E0", VA = "0x1814B14E0")]
	public static void ONBECCDMLGM(global::DJEFEGOJFPA<T> MPGOABMOIAA, IJPAKLJLNOI BDNPNGGCFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x146B6E0", Offset = "0x146AAE0", VA = "0x18146B6E0")]
	public static void ONBECCDMLGM<A>(global::DJEFEGOJFPA<T> MPGOABMOIAA, Func<global::DJEFEGOJFPA<T>, A, bool> BDNPNGGCFPN, A OHFMPKJCLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x14B2260", Offset = "0x14B1660", VA = "0x1814B2260")]
	public static string PODKJCBOELP(global::DJEFEGOJFPA<T> MPGOABMOIAA, int MBLPPLGFEAE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x14B05D0", Offset = "0x14AF9D0", VA = "0x1814B05D0")]
	public static global::DJEFEGOJFPA<T> CDAKJDLNDOI(global::DJEFEGOJFPA<T> MPGOABMOIAA, T EDMDPOICPON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[DefaultMember("Item")]
public class CPHIIFBLCDH<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate int MPDHPMIIDDC(TKey DNGKIAJLLHG, TVal ONGBFDACHHG);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class NAGHLDJNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public TKey AKFDMGLACLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x400970", Offset = "0x3FFD70", VA = "0x180400970")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public TVal DMLIOOCLKKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x4006D0", Offset = "0x3FFAD0", VA = "0x1804006D0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x400750", Offset = "0x3FFB50", VA = "0x180400750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int DBLCENPKMBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x4F1E20", Offset = "0x4F1220", VA = "0x1804F1E20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x4F1A90", Offset = "0x4F0E90", VA = "0x1804F1A90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public DateTime JKNPCOLJCFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3ED0F0", Offset = "0x3EC4F0", VA = "0x1803ED0F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x40D6B0", Offset = "0x40CAB0", VA = "0x18040D6B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x18BA710", Offset = "0x18B9B10", VA = "0x1818BA710")]
		public NAGHLDJNNAJ(TKey key, TVal val)
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

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GNJACFKGBGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E5760", Offset = "0x3E4B60", VA = "0x1803E5760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool DPNLGBNIPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x18B8200", Offset = "0x18B7600", VA = "0x1818B8200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal int BIIJACLJEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x40D920", Offset = "0x40CD20", VA = "0x18040D920")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x40D940", Offset = "0x40CD40", VA = "0x18040D940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TKey ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x18B8290", Offset = "0x18B7690", VA = "0x1818B8290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x18B9010", Offset = "0x18B8410", VA = "0x1818B9010")]
	public CPHIIFBLCDH(int capacity, [Optional] MPDHPMIIDDC sizeOfFunc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x18B9190", Offset = "0x18B8590", VA = "0x1818B9190")]
	public CPHIIFBLCDH(int capacity, MPDHPMIIDDC sizeOfFunc, TimeSpan timeToExpire, [Optional] CJHBFCGNJFA timeProvider)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x18B7C90", Offset = "0x18B7090", VA = "0x1818B7C90")]
	public void CHMGPFLMEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x18B78D0", Offset = "0x18B6CD0", VA = "0x1818B78D0")]
	public void BDJFGEJFPPO(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x18B7990", Offset = "0x18B6D90", VA = "0x1818B7990")]
	public bool BIHKNNPGGKP(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x18B8410", Offset = "0x18B7810", VA = "0x1818B8410")]
	public bool IMCPFLDKEOH(TKey LFHKOFIPIEK, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x18B88A0", Offset = "0x18B7CA0", VA = "0x1818B88A0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x18B7B10", Offset = "0x18B6F10", VA = "0x1818B7B10")]
	private bool CHGILPBCJJD(NAGHLDJNNAJ KNAIJICNDHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x18B8BA0", Offset = "0x18B7FA0", VA = "0x1818B8BA0")]
	private void NMABOMIEHEE(LinkedListNode<NAGHLDJNNAJ> CDGLMCIFCBO, TVal BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x18B7FF0", Offset = "0x18B73F0", VA = "0x1818B7FF0")]
	private void DOEHAPOJMON(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x18B8700", Offset = "0x18B7B00", VA = "0x1818B8700")]
	private void LEOHCFPGCKH(NAGHLDJNNAJ KNAIJICNDHB, TVal BCEFAKDFEMM, int LNABDPGDHED)
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static SerializedGuid Empty
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x3590830", Offset = "0x358FC30", VA = "0x183590830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static SerializedGuid Random
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x35908C0", Offset = "0x358FCC0", VA = "0x1835908C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x47E490", Offset = "0x47D890", VA = "0x18047E490")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x47E4A0", Offset = "0x47D8A0", VA = "0x18047E4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public SerializedGuid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3590800", Offset = "0x358FC00", VA = "0x183590800")]
		public SerializedGuid(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x35906B0", Offset = "0x358FAB0", VA = "0x1835906B0")]
		public bool MEBGJGNMIMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x35907E0", Offset = "0x358FBE0", VA = "0x1835907E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3590740", Offset = "0x358FB40", VA = "0x183590740", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x35904E0", Offset = "0x358F8E0", VA = "0x1835904E0", Slot = "7")]
		public bool Equals(SerializedGuid HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3590580", Offset = "0x358F980", VA = "0x183590580", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3590690", Offset = "0x358FA90", VA = "0x183590690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x35904A0", Offset = "0x358F8A0", VA = "0x1835904A0", Slot = "6")]
		public int CompareTo(SerializedGuid HPKICPNGMDJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GHNKMPMKPPL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly Type GKNKEKPPLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly string PLJKDMKPGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly bool PJFHNKEINDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly bool GFHGEHPLIDC;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x358E450", Offset = "0x358D850", VA = "0x18358E450")]
	public GHNKMPMKPPL(Type valueRetrieveMethodType, string valueRetrieveMethod, bool insertEmptyChoice = false, bool disabled = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JDGADLJCIJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool KOIKDFBKFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JDGADLJCIJC<T> LHHAHBBBDOA(Action<T> CIBJIOPEHOJ);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::JDGADLJCIJC<T> ONIEADDFNIG(Action<T> CIBJIOPEHOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LNGJEDLLFHG<T> : global::JDGADLJCIJC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private global::IILCGFIHJLP<T, T> DLDIJOMCDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private global::MFBGLIHGCGO<T> GOEJCGOLDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private global::MFBGLIHGCGO<string> FFIBBFANJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private string MOPOMPHBHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private T GIAOBLMEMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool NEEKOHCDENC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x401420", Offset = "0x400820", VA = "0x180401420", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1A76D10", Offset = "0x1A76110", VA = "0x181A76D10", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool KOIKDFBKFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4BFB80", Offset = "0x4BEF80", VA = "0x1804BFB80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x231E930", Offset = "0x231DD30", VA = "0x18231E930")]
	private void CPDEMFAEBMA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x231E9B0", Offset = "0x231DDB0", VA = "0x18231E9B0", Slot = "4")]
	public global::JDGADLJCIJC<T> LHHAHBBBDOA(Action<T> COCKCCFIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x231EA30", Offset = "0x231DE30", VA = "0x18231EA30", Slot = "5")]
	public global::JDGADLJCIJC<T> ONIEADDFNIG(Action<T> CIBJIOPEHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x231EA60", Offset = "0x231DE60", VA = "0x18231EA60")]
	public LNGJEDLLFHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class PNGLIKCFGDE
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class COCCCIAHGPA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public global::JDGADLJCIJC<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public global::CBLLFJEDOII<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public COCCCIAHGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E06160", Offset = "0x2E05560", VA = "0x182E06160")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2F90", Offset = "0x1CE2390", VA = "0x181CE2F90")]
	public static global::PMGCJEPKFOF<T> DDGIPHJPODB<T>(this global::JDGADLJCIJC<T> BOPFDMGIMPK, Action<T> AFLPGGJMPOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public abstract class CJHBFCGNJFA
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private class HIKPHEBEPCE : CJHBFCGNJFA
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static CJHBFCGNJFA ONCPNMDGGKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x358E950", Offset = "0x358DD50", VA = "0x18358E950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override DateTime GJMKMFNGGDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x358E900", Offset = "0x358DD00", VA = "0x18358E900", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x358EA40", Offset = "0x358DE40", VA = "0x18358EA40")]
		public HIKPHEBEPCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static CJHBFCGNJFA AKAMNPLKANB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public static CJHBFCGNJFA EDLIKGJFHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x358E110", Offset = "0x358D510", VA = "0x18358E110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public abstract DateTime GJMKMFNGGDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
	protected CJHBFCGNJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class PIDMLFKAEJP : global::AFLBJKBIMFL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3590200", Offset = "0x358F600", VA = "0x183590200")]
	public PIDMLFKAEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class AFLBJKBIMFL<T> : global::IKAEDJBFIMM<T>, LMNJIGBCDFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x400970", Offset = "0x3FFD70", VA = "0x180400970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xF9EAA0", Offset = "0xF9DEA0", VA = "0x180F9EAA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x15544A0", Offset = "0x15538A0", VA = "0x1815544A0")]
	public AFLBJKBIMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class COOJEJBKMJN<T> : global::IKAEDJBFIMM<T>, LMNJIGBCDFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x400970", Offset = "0x3FFD70", VA = "0x180400970", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xF9EAA0", Offset = "0xF9DEA0", VA = "0x180F9EAA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x18B7730", Offset = "0x18B6B30", VA = "0x1818B7730")]
	public COOJEJBKMJN(Exception e)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LMNJIGBCDFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	DABKFAIHBBP BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IKAEDJBFIMM<T> : LMNJIGBCDFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	new global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class GPMPDFCGLHC<TTask, T> : global::IKAEDJBFIMM<T>, LMNJIGBCDFB, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EKGLBOJPFMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public global::GPMPDFCGLHC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public EKGLBOJPFMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class IHHLCBAJHHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public EKGLBOJPFMP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public IHHLCBAJHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1908B90", Offset = "0x1907F90", VA = "0x181908B90")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static bool GNLEBJGHBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly global::CBLLFJEDOII<T> CBJFAFPEEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Task<T> CFNPEPPKEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly CancellationTokenSource HJBPDABGMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool KGACOELMNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private SynchronizationContext KBBHKPGPKOL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x400970", Offset = "0x3FFD70", VA = "0x180400970", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x400970", Offset = "0x3FFD70", VA = "0x180400970", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1908260", Offset = "0x1907660", VA = "0x181908260")]
	static GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x19083D0", Offset = "0x19077D0", VA = "0x1819083D0")]
	protected GPMPDFCGLHC(TTask task)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1907C50", Offset = "0x1907050", VA = "0x181907C50", Slot = "1")]
	~GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1907C20", Offset = "0x1907020", VA = "0x181907C20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1907E10", Offset = "0x1907210", VA = "0x181907E10")]
	private void MDDAPCCABNK(bool CNDHCDEIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KMLPECLHIFN(TTask LIPAKCCDNKD);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void CFMNLNIIPIF();

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1907B10", Offset = "0x1906F10", VA = "0x181907B10")]
	protected void COCHLMCDGCA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1907D90", Offset = "0x1907190", VA = "0x181907D90")]
	protected void GGLDPDNDEHO(string MOPOMPHBHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1907A70", Offset = "0x1906E70", VA = "0x181907A70")]
	[CompilerGenerated]
	private void CFMBCOAHJFB(object BMEGDKCCBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EFHMLIMBKPE<T> : IEnumerable<global::EFHMLIMBKPE<T>.KANNECPCOLP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct KANNECPCOLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T ONGBFDACHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int EFBDCIJMFGD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KCNNGNNFBDL : IEnumerator<KANNECPCOLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::EFHMLIMBKPE<T> FLLHBFDLKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int EFBDCIJMFGD;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x14BF8C0", Offset = "0x14BECC0", VA = "0x1814BF8C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public KANNECPCOLP KAFEDPEFLOI
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x14BF930", Offset = "0x14BED30", VA = "0x1814BF930", Slot = "4")]
			get
			{
				return default(KANNECPCOLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x11EEB00", Offset = "0x11EDF00", VA = "0x1811EEB00")]
		public KCNNGNNFBDL(global::EFHMLIMBKPE<T> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x14BF830", Offset = "0x14BEC30", VA = "0x1814BF830", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4C5F70", Offset = "0x4C5370", VA = "0x1804C5F70", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8E7B40", Offset = "0x8E6F40", VA = "0x1808E7B40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private struct LIBGGEJODOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public bool KNLALBPCPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public T ONGBFDACHHG;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private const int NHJIENICHMB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private Dictionary<T, int> IBPECDLABOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private LIBGGEJODOA[] EPEPLHDAKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int GLKDNFHHAOE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x14BB950", Offset = "0x14BAD50", VA = "0x1814BB950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x14BB590", Offset = "0x14BA990", VA = "0x1814BB590")]
	public static global::EFHMLIMBKPE<T> OGGMCNEPMDA(KANNECPCOLP[] PPCOBBGKGCP, bool DBGPHICABDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x14BB9F0", Offset = "0x14BADF0", VA = "0x1814BB9F0")]
	public EFHMLIMBKPE(int capacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x14BB540", Offset = "0x14BA940", VA = "0x1814BB540")]
	public int KNHMLMKIOCH(T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x14BB290", Offset = "0x14BA690", VA = "0x1814BB290")]
	public T DDGIPHJPODB(int EFBDCIJMFGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x14BB4D0", Offset = "0x14BA8D0", VA = "0x1814BB4D0")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x14BB300", Offset = "0x14BA700", VA = "0x1814BB300")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG, int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x14BB150", Offset = "0x14BA550", VA = "0x1814BB150")]
	public KANNECPCOLP[] CAPGKOJNBIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x14BB4F0", Offset = "0x14BA8F0", VA = "0x1814BB4F0")]
	private int KJMAGDFHGOD(int HKPHMBLKPFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x14BB980", Offset = "0x14BAD80", VA = "0x1814BB980", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x14BB980", Offset = "0x14BAD80", VA = "0x1814BB980", Slot = "4")]
	private IEnumerator<KANNECPCOLP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class BDMFLDBGOFG<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private List<T> KEOFINNFAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<T> OJKMJBCKGFJ;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x16F1010", Offset = "0x16F0410", VA = "0x1816F1010")]
	public BDMFLDBGOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x16F1040", Offset = "0x16F0440", VA = "0x1816F1040")]
	public BDMFLDBGOFG(int capacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x16F0F10", Offset = "0x16F0310", VA = "0x1816F0F10")]
	public T OBCMOHDGJNN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x16F0DF0", Offset = "0x16F01F0", VA = "0x1816F0DF0")]
	public void IOFOFLHIJGM(T IOKKOEMCNPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class LEOCHCLDMME<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	protected struct IFDCGAONOCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public T DMLIOOCLKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public int LNEDNNJCPMG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	protected readonly List<IFDCGAONOCC> IKHCBHDLNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private T FINCIIOMABG;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xFA2370", Offset = "0xFA1770", VA = "0x180FA2370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x24CCA60", Offset = "0x24CBE60", VA = "0x1824CCA60")]
	public bool KCFPIEEMJON(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x24CC950", Offset = "0x24CBD50", VA = "0x1824CC950")]
	public void BPAJKKAGPKB(T ONGBFDACHHG, int JMHKMOACHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x24CC830", Offset = "0x24CBC30", VA = "0x1824CC830")]
	public bool BIHKNNPGGKP(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x24CCCB0", Offset = "0x24CC0B0", VA = "0x1824CCCB0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x24CC9D0", Offset = "0x24CBDD0", VA = "0x1824CC9D0")]
	public T HMBMDDOFIKL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x24CC620", Offset = "0x24CBA20", VA = "0x1824CC620")]
	private void ABKEBNFHIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x24CCD10", Offset = "0x24CC110", VA = "0x1824CCD10")]
	public LEOCHCLDMME()
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
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xFAF6F0", Offset = "0xFAEAF0", VA = "0x180FAF6F0", Slot = "4")]
		public virtual T EDMOPEPBEHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class OHFHKIPINGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<byte, MHJBJPJHPFD> KDGPABMFDAP;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MHJBJPJHPFD FGCPPNAGAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x400970", Offset = "0x3FFD70", VA = "0x180400970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0C0", Offset = "0x3DD4C0", VA = "0x1803DE0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 JKPGFDOGKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x79A960", Offset = "0x799D60", VA = "0x18079A960")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x16F3E60", Offset = "0x16F3260", VA = "0x1816F3E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector2 JECNPCKFHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x740B00", Offset = "0x73FF00", VA = "0x180740B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 KIBOLBPKFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x264A8B0", Offset = "0x2649CB0", VA = "0x18264A8B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x264A8D0", Offset = "0x2649CD0", VA = "0x18264A8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int BPOLFMEDCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4671A0", Offset = "0x4665A0", VA = "0x1804671A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4671C0", Offset = "0x4665C0", VA = "0x1804671C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x358F9A0", Offset = "0x358EDA0", VA = "0x18358F9A0")]
	public OHFHKIPINGN(Bounds treeBounds, Vector2[] subdivisionsByDepth, int maxDepth, byte startIndex, float gizmoDepth = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x358F740", Offset = "0x358EB40", VA = "0x18358F740")]
	public MHJBJPJHPFD HLCKAFHGBDM(byte EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x358F8C0", Offset = "0x358ECC0", VA = "0x18358F8C0")]
	public void NGKNKJMGCJO(Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE, ref List<byte> NPAGJNGHOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x358F720", Offset = "0x358EB20", VA = "0x18358F720")]
	public void GEPJEOGAEEH(MHJBJPJHPFD.HCMDPIPMANH KICELKEADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x358F7A0", Offset = "0x358EBA0", VA = "0x18358F7A0")]
	private MHJBJPJHPFD MOLJJAEIFLF(byte EFBDCIJMFGD, MHJBJPJHPFD.ENGKDHJBBKF OHEHDIDHCFP, MHJBJPJHPFD HICENEOPGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x358F200", Offset = "0x358E600", VA = "0x18358F200")]
	private void AIDPBIKEJGM(MHJBJPJHPFD HICENEOPGOF, Vector2[] JJBMIAKPNFM, int MJCNPBEHJKC, int LBLOCDFALDE, int MFNBLGJBBJP, int OKBDDEDMDOB, float IKIIJCMDBLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class MHJBJPJHPFD
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum ENGKDHJBBKF
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum HCMDPIPMANH
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public byte JPOHGBCEJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Vector3 EFDKABIFNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Vector3 DBLCENPKMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Vector3 PIKANCCKHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Vector3 HMIBLLANHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ENGKDHJBBKF DPDNBLNNCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public MHJBJPJHPFD MEHAAMLFBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public List<MHJBJPJHPFD> DMJMAGENMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool LAMKCBNADPI;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x358EEB0", Offset = "0x358E2B0", VA = "0x18358EEB0")]
	public MHJBJPJHPFD(byte id, ENGKDHJBBKF nodeType, MHJBJPJHPFD parent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x358EB90", Offset = "0x358DF90", VA = "0x18358EB90")]
	public void NBIOIKFGOLK(MHJBJPJHPFD MLDKMIGAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0")]
	public void GEPJEOGAEEH(int IDMAJACDJMF, HCMDPIPMANH KICELKEADCI, int NIIDNDCGMDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x358EC20", Offset = "0x358E020", VA = "0x18358EC20")]
	public void NGKNKJMGCJO(List<byte> NPAGJNGHOAE, Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x358EAF0", Offset = "0x358DEF0", VA = "0x18358EAF0")]
	public bool BJFFCFNIFNF(Vector3 KPLDEODOJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x358EB50", Offset = "0x358DF50", VA = "0x18358EB50")]
	public bool IKJGCMKLGKF(Vector3 KPLDEODOJID, float BIMDOAEJMPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class BEPMBLAHCML<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private int NPKCAEOBEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int ONGEGPPEIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private List<T> FEBHFIMEJPN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public T FLAGPNDNLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x16F2BC0", Offset = "0x16F1FC0", VA = "0x1816F2BC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T ENONEADFACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x16F2B80", Offset = "0x16F1F80", VA = "0x1816F2B80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T IBDJAKGMLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x16F2780", Offset = "0x16F1B80", VA = "0x1816F2780")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x16F2D30", Offset = "0x16F2130", VA = "0x1816F2D30")]
	public BEPMBLAHCML(int capacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x16F2980", Offset = "0x16F1D80", VA = "0x1816F2980")]
	public void BPAJKKAGPKB(T LMJGGCEBDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x16F2AD0", Offset = "0x16F1ED0", VA = "0x1816F2AD0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x16F2CE0", Offset = "0x16F20E0", VA = "0x1816F2CE0")]
	public void OOAIDMBHDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x16F2AC0", Offset = "0x16F1EC0", VA = "0x1816F2AC0")]
	public void HEBIFJELCPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BJOIBBBOIKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct OPALEOIDFEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public int LNEDNNJCPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public T DMLIOOCLKKP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Dictionary<object, OPALEOIDFEP> IOHBEHECBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private T LEDAAPCCHHA;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T FNCFALEFNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x79A960", Offset = "0x799D60", VA = "0x18079A960", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x16F3E60", Offset = "0x16F3260", VA = "0x1816F3E60", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x16F3EC0", Offset = "0x16F32C0", VA = "0x1816F3EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object KJFJIIDJCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0F0", Offset = "0x3EC4F0", VA = "0x1803ED0F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x40D6B0", Offset = "0x40CAB0", VA = "0x18040D6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x16F3C60", Offset = "0x16F3060", VA = "0x1816F3C60")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI, int JMHKMOACHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x16F3EF0", Offset = "0x16F32F0", VA = "0x1816F3EF0")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x16F4220", Offset = "0x16F3620", VA = "0x1816F4220")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x16F44F0", Offset = "0x16F38F0", VA = "0x1816F44F0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x16F6EF0", Offset = "0x16F62F0", VA = "0x1816F6EF0")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x16F9530", Offset = "0x16F8930", VA = "0x1816F9530")]
	public BJOIBBBOIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class POJFBLMLAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Dictionary<object, float> IOHBEHECBGL;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float JABPFAJNKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4ED340", Offset = "0x4EC740", VA = "0x1804ED340")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4ED310", Offset = "0x4EC710", VA = "0x1804ED310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3590360", Offset = "0x358F760", VA = "0x183590360")]
	public void DOEHAPOJMON(float ONGBFDACHHG, object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x35903D0", Offset = "0x358F7D0", VA = "0x1835903D0")]
	public void HAHBGOMEMEE(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3590240", Offset = "0x358F640", VA = "0x183590240")]
	private void BHHBAENFOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3590430", Offset = "0x358F830", VA = "0x183590430")]
	public POJFBLMLAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class AOLMGGAPKEH
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class INIIDHCNCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly string BIELLBOJOCP;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		private INIIDHCNCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x40D770", Offset = "0x40CB70", VA = "0x18040D770")]
		public INIIDHCNCLK(string tokenName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x358EAA0", Offset = "0x358DEA0", VA = "0x18358EAA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HHHAHKJKNHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public HHHAHKJKNHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x358E850", Offset = "0x358DC50", VA = "0x18358E850")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly HashSet<object> BGKNMHEJLMM;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool CFLJGNJLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x358DBA0", Offset = "0x358CFA0", VA = "0x18358DBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x358DA90", Offset = "0x358CE90", VA = "0x18358DA90")]
	public void BPAJKKAGPKB(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x358DA30", Offset = "0x358CE30", VA = "0x18358DA30")]
	public void BIHKNNPGGKP(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x358DAF0", Offset = "0x358CEF0", VA = "0x18358DAF0")]
	public bool KCFPIEEMJON(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x358DB50", Offset = "0x358CF50", VA = "0x18358DB50")]
	public void KFKPHICNHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x358DBE0", Offset = "0x358CFE0", VA = "0x18358DBE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x358DD40", Offset = "0x358D140", VA = "0x18358DD40")]
	public AOLMGGAPKEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HHIINKNOKNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private struct NNOOBABINMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float NJNCDDAIBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public T DMLIOOCLKKP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Dictionary<object, NNOOBABINMN> IOHBEHECBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private T MAJHCJGJKPN;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T NKIEOKALHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA493F0", Offset = "0xA487F0", VA = "0x180A493F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x16F3E40", Offset = "0x16F3240", VA = "0x1816F3E40", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object GEDFELNLNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x401420", Offset = "0x400820", VA = "0x180401420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x400F00", Offset = "0x400300", VA = "0x180400F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x22B5460", Offset = "0x22B4860", VA = "0x1822B5460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x22B4CA0", Offset = "0x22B40A0", VA = "0x1822B4CA0")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x22B54A0", Offset = "0x22B48A0", VA = "0x1822B54A0")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x16F44F0", Offset = "0x16F38F0", VA = "0x1816F44F0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x22B5620", Offset = "0x22B4A20", VA = "0x1822B5620")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x22B6440", Offset = "0x22B5840", VA = "0x1822B6440")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x22B7520", Offset = "0x22B6920", VA = "0x1822B7520")]
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
