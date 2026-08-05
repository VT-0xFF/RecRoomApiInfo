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
	[Cpp2IlInjected.Address(RVA = "0x85F4A0", Offset = "0x85E8A0", VA = "0x18085F4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4059D0", Offset = "0x404DD0", VA = "0x1804059D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4055D0", Offset = "0x4049D0", VA = "0x1804055D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "4")]
	public virtual void COBDCEFIEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
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
	[CJOEKDOBHDG]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A46DF0", Offset = "0x2A461F0", VA = "0x182A46DF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A46930", Offset = "0x2A45D30", VA = "0x182A46930", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A473F0", Offset = "0x2A467F0", VA = "0x182A473F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
		public AEAKOHFPLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x221F1C0", Offset = "0x221E5C0", VA = "0x18221F1C0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[CJOEKDOBHDG]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2223EC0", Offset = "0x22232C0", VA = "0x182223EC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2223EF0", Offset = "0x22232F0", VA = "0x182223EF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2223E10", Offset = "0x2223210", VA = "0x182223E10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey DNGKIAJLLHG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2223E70", Offset = "0x2223270", VA = "0x182223E70", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2223D20", Offset = "0x2223120", VA = "0x182223D20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2223590", Offset = "0x2222990", VA = "0x182223590", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2222F00", Offset = "0x2222300", VA = "0x182222F00", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2222B60", Offset = "0x2221F60", VA = "0x182222B60", Slot = "14")]
	protected virtual string LKCOLBMMLKA(TKeyVal GALGADHFCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1FF52B0", Offset = "0x1FF46B0", VA = "0x181FF52B0", Slot = "4")]
	public bool ContainsKey(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2223C20", Offset = "0x2223020", VA = "0x182223C20", Slot = "5")]
	public bool TryGetValue(TKey DNGKIAJLLHG, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2222A70", Offset = "0x2221E70", VA = "0x182222A70", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2222A70", Offset = "0x2221E70", VA = "0x182222A70", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2223C50", Offset = "0x2223050", VA = "0x182223C50")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x464680", Offset = "0x463A80", VA = "0x180464680")]
		[DebuggerHidden]
		public FIOCHCGPCBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x38BFF70", Offset = "0x38BF370", VA = "0x1838BFF70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x38BFE20", Offset = "0x38BF220", VA = "0x1838BFE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x38BFFE0", Offset = "0x38BF3E0", VA = "0x1838BFFE0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38BFF20", Offset = "0x38BF320", VA = "0x1838BFF20", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x38C03A0", Offset = "0x38BF7A0", VA = "0x1838C03A0")]
	public static void RegisterDontDestroyOnLoad(GameObject NNNMGKGMIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38C01C0", Offset = "0x38BF5C0", VA = "0x1838C01C0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38C0440", Offset = "0x38BF840", VA = "0x1838C0440")]
	[IteratorStateMachine(typeof(FIOCHCGPCBF))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "6")]
	protected virtual void BFNKJCLBGIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38C0500", Offset = "0x38BF900", VA = "0x1838C0500")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CGINBDPPLIO
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x197D1F0", Offset = "0x197C5F0", VA = "0x18197D1F0")]
	public static void DFFNGCIAOME<T>(this T CKCMODJNCNF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38BFB90", Offset = "0x38BEF90", VA = "0x1838BFB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x89A8D0", Offset = "0x899CD0", VA = "0x18089A8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A10640", Offset = "0x2A0FA40", VA = "0x182A10640", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A10B10", Offset = "0x2A0FF10", VA = "0x182A10B10", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2223F20", Offset = "0x2223320", VA = "0x182223F20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB5470", Offset = "0xAB4870", VA = "0x180AB5470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x38C0C10", Offset = "0x38C0010", VA = "0x1838C0C10")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38C0E30", Offset = "0x38C0230", VA = "0x1838C0E30")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x896940", Offset = "0x895D40", VA = "0x180896940")]
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
		[Cpp2IlInjected.Address(RVA = "0x89A8D0", Offset = "0x899CD0", VA = "0x18089A8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool FFNIFALJLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A482B0", Offset = "0x2A476B0", VA = "0x182A482B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2A47D70", Offset = "0x2A47170", VA = "0x182A47D70", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A480F0", Offset = "0x2A474F0", VA = "0x182A480F0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2223F20", Offset = "0x2223320", VA = "0x182223F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
		public NMKBADGNEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x28B1A00", Offset = "0x28B0E00", VA = "0x1828B1A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x28A49E0", Offset = "0x28A3DE0", VA = "0x1828A49E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28A4E60", Offset = "0x28A4260", VA = "0x1828A4E60")]
	public HKMGKEPIIGN(float EBNPDDOHPII, float PDNBGEMGHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x28A4AE0", Offset = "0x28A3EE0", VA = "0x1828A4AE0")]
	public bool NNLAEHCFGLO(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28A4680", Offset = "0x28A3A80", VA = "0x1828A4680")]
	public IEnumerable<T> BKGJKBJPEID(float MOPKOPOKKEE, [Optional] float? DJJCAALEIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x28A49B0", Offset = "0x28A3DB0", VA = "0x1828A49B0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28A4DA0", Offset = "0x28A41A0", VA = "0x1828A4DA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CEBC0", Offset = "0x8CDFC0", VA = "0x1808CEBC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBD0", Offset = "0x8CDFD0", VA = "0x1808CEBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1F28D90", Offset = "0x1F28190", VA = "0x181F28D90")]
	public GMNJGMLCABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1F28DC0", Offset = "0x1F281C0", VA = "0x181F28DC0")]
	public GMNJGMLCABC(int OJJOHDIFMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1F27F30", Offset = "0x1F27330", VA = "0x181F27F30")]
	public void BPAJKKAGPKB(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1F287F0", Offset = "0x1F27BF0", VA = "0x181F287F0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1F28300", Offset = "0x1F27700", VA = "0x181F28300")]
	public bool IMMBIFHODMF(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1F28690", Offset = "0x1F27A90", VA = "0x181F28690")]
	public bool KJPECKDEGGL(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1F28BF0", Offset = "0x1F27FF0", VA = "0x181F28BF0")]
	public void OCCODBALDOD(float JODPOANPJNK, float BCANLCHBKJE, List<T> NKHPHBOPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1F284B0", Offset = "0x1F278B0", VA = "0x181F284B0")]
	private int JDDBKHEGJHN(int NPDLAJLCALI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1F27EF0", Offset = "0x1F272F0", VA = "0x181F27EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x38BFA20", Offset = "0x38BEE20", VA = "0x1838BFA20", Slot = "4")]
	protected override Vector3 KPKMNLDBMEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x38BFA90", Offset = "0x38BEE90", VA = "0x1838BFA90", Slot = "5")]
	protected override Vector3 PIFFNJDGHDE(Vector3 ONGBFDACHHG, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x38BF900", Offset = "0x38BED00", VA = "0x1838BF900", Slot = "6")]
	protected override Vector3 CAPOCJJJJIB(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38BF9B0", Offset = "0x38BEDB0", VA = "0x1838BF9B0", Slot = "7")]
	protected override Vector3 JIODMOCKLKL(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38BFB30", Offset = "0x38BEF30", VA = "0x1838BFB30")]
	public APDBOLKPCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DLPGJKJFNCM
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1880AC0", Offset = "0x187FEC0", VA = "0x181880AC0")]
	public static global::DHKPBIAHMHG<T1, T2> NFHADFCEMML<T1, T2>(T1 OFCHPINAEEE, T2 NLNENAIDOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1880B30", Offset = "0x187FF30", VA = "0x181880B30")]
	public static global::ELGBCKDBOED<T1, T2, T3> NFHADFCEMML<T1, T2, T3>(T1 OFCHPINAEEE, T2 NLNENAIDOJD, T3 FGPNPLGENDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x703520", Offset = "0x702920", VA = "0x180703520")]
	internal static int FBNEHNPAJDI(int JGPNKFEDCDB, int EDGDLDGIIMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x703530", Offset = "0x702930", VA = "0x180703530")]
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
	[Cpp2IlInjected.Address(RVA = "0x1A044B0", Offset = "0x1A038B0", VA = "0x181A044B0")]
	public DHKPBIAHMHG(T1 OFCHPINAEEE, T2 NLNENAIDOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x37F8670", Offset = "0x37F7A70", VA = "0x1837F8670", Slot = "4")]
	public int CompareTo(global::DHKPBIAHMHG<T1, T2> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37F8730", Offset = "0x37F7B30", VA = "0x1837F8730", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37F88E0", Offset = "0x37F7CE0", VA = "0x1837F88E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37F89B0", Offset = "0x37F7DB0", VA = "0x1837F89B0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1A12900", Offset = "0x1A11D00", VA = "0x181A12900")]
	public ELGBCKDBOED(T1 OFCHPINAEEE, T2 NLNENAIDOJD, T3 FGPNPLGENDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1A12490", Offset = "0x1A11890", VA = "0x181A12490", Slot = "4")]
	public int CompareTo(global::ELGBCKDBOED<T1, T2, T3> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1A12590", Offset = "0x1A11990", VA = "0x181A12590", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1A12700", Offset = "0x1A11B00", VA = "0x181A12700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1A12770", Offset = "0x1A11B70", VA = "0x181A12770", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x4129C0", Offset = "0x411DC0", VA = "0x1804129C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4059F0", Offset = "0x404DF0", VA = "0x1804059F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float BPHIOMBNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8CF000", Offset = "0x8CE400", VA = "0x1808CF000")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2EB3610", Offset = "0x2EB2A10", VA = "0x182EB3610")]
	public T DHEIFNLDBKN(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2EB38B0", Offset = "0x2EB2CB0", VA = "0x182EB38B0")]
	public T NICCICAFMDM(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ADPELJHGHKK(T LONDCJPNKKN, T PCEJJILDLGD, float LIMOILDIGKF);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x38C00A0", Offset = "0x38BF4A0", VA = "0x1838C00A0", Slot = "4")]
	protected override float ADPELJHGHKK(float LONDCJPNKKN, float PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x38C0120", Offset = "0x38BF520", VA = "0x1838C0120")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x38C2560", Offset = "0x38C1960", VA = "0x1838C2560", Slot = "4")]
	protected override Vector3 ADPELJHGHKK(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x38C2620", Offset = "0x38C1A20", VA = "0x1838C2620")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x38B74E0", Offset = "0x38B68E0", VA = "0x1838B74E0", Slot = "4")]
	protected override Color ADPELJHGHKK(Color LONDCJPNKKN, Color PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x38BFDE0", Offset = "0x38BF1E0", VA = "0x1838BFDE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8CEBC0", Offset = "0x8CDFC0", VA = "0x1808CEBC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1F22DA0", Offset = "0x1F221A0", VA = "0x181F22DA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1F23190", Offset = "0x1F22590", VA = "0x181F23190")]
		public Enumerator(global::GPFLNFOKEIA<T> NKHPHBOPPEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1F22430", Offset = "0x1F21830", VA = "0x181F22430", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F22BB0", Offset = "0x1F21FB0", VA = "0x181F22BB0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1F22910", Offset = "0x1F21D10", VA = "0x181F22910")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F2A0B0", Offset = "0x1F294B0", VA = "0x181F2A0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1F299A0", Offset = "0x1F28DA0", VA = "0x181F299A0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1F297D0", Offset = "0x1F28BD0", VA = "0x181F297D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F2A640", Offset = "0x1F29A40", VA = "0x181F2A640")]
	public GPFLNFOKEIA(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1F29450", Offset = "0x1F28850", VA = "0x181F29450")]
	public void BPAJKKAGPKB(T LIMOILDIGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1F29AC0", Offset = "0x1F28EC0", VA = "0x181F29AC0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1F29AE0", Offset = "0x1F28EE0", VA = "0x181F29AE0")]
	public void NAJLLGFNIKC(int MNIJHBJDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1F29B70", Offset = "0x1F28F70", VA = "0x181F29B70")]
	public void NPAGGFDPFJK(T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1F29710", Offset = "0x1F28B10", VA = "0x181F29710")]
	public Enumerator CINCGNABFNK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1F2A4B0", Offset = "0x1F298B0", VA = "0x181F2A4B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1F2A4B0", Offset = "0x1F298B0", VA = "0x181F2A4B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2A1E0", Offset = "0x1F295E0", VA = "0x181F2A1E0")]
	private int PLMBLHMDABK(int EFBDCIJMFGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F29360", Offset = "0x1F28760", VA = "0x181F29360")]
	private int BCDNPPPABOI(int EFBDCIJMFGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KBNAHLKGDBF
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
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
	protected readonly List<T> GGDHHMGKOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly List<DBMLEBCMBFG> JFKJECNEMEH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MENDGJKDBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x304CF80", Offset = "0x304C380", VA = "0x18304CF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x304D350", Offset = "0x304C750", VA = "0x18304D350")]
	public PPKEKBLDDIK(int NPKCAEOBEMO, bool JNIOEAEOGFI, bool NOLKFLLKNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x304CF10", Offset = "0x304C310", VA = "0x18304CF10", Slot = "1")]
	~PPKEKBLDDIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x304CE80", Offset = "0x304C280", VA = "0x18304CE80")]
	protected void FIAILKDOPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x304D270", Offset = "0x304C670", VA = "0x18304D270")]
	protected void NBBNPIGEGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x304D0C0", Offset = "0x304C4C0", VA = "0x18304D0C0")]
	protected void MPOMLFNCCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x304CD60", Offset = "0x304C160", VA = "0x18304CD60", Slot = "4")]
	public void BPAJKKAGPKB(T JJGHIEJCCDA, bool GLAMKMBICFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x304CC40", Offset = "0x304C040", VA = "0x18304CC40", Slot = "5")]
	public void BIHKNNPGGKP(T JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x304CFB0", Offset = "0x304C3B0", VA = "0x18304CFB0")]
	public void LKLKGDMFMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OKNNKFGFODL : global::PPKEKBLDDIK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38C1E10", Offset = "0x38C1210", VA = "0x1838C1E10")]
	public OKNNKFGFODL(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x38C1C00", Offset = "0x38C1000", VA = "0x1838C1C00")]
	public void CNFDGDEOPPF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x38C1BA0", Offset = "0x38C0FA0", VA = "0x1838C1BA0")]
	public static OKNNKFGFODL BPJDFPACLMK(OKNNKFGFODL CMLAHPHDOHI, Action JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38C1DB0", Offset = "0x38C11B0", VA = "0x1838C1DB0")]
	public static OKNNKFGFODL GMNMHGMFGOL(OKNNKFGFODL CMLAHPHDOHI, Action JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AGHMNFKGBEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPAJKKAGPKB(Action<T> JJGHIEJCCDA, bool GLAMKMBICFD = false);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIHKNNPGGKP(Action<T> JJGHIEJCCDA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class MFBGLIHGCGO<T> : global::PPKEKBLDDIK<Action<T>>, global::AGHMNFKGBEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E450", Offset = "0x1A0D850", VA = "0x181A0E450")]
	public MFBGLIHGCGO(int NPKCAEOBEMO = 4, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x23DED60", Offset = "0x23DE160", VA = "0x1823DED60")]
	public void CNFDGDEOPPF(T LIMOILDIGKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1A0DA10", Offset = "0x1A0CE10", VA = "0x181A0DA10")]
	public static global::MFBGLIHGCGO<T> BPJDFPACLMK(global::MFBGLIHGCGO<T> CMLAHPHDOHI, Action<T> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E3B0", Offset = "0x1A0D7B0", VA = "0x181A0E3B0")]
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
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E450", Offset = "0x1A0D850", VA = "0x181A0E450")]
	public IILCGFIHJLP(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x28AB4E0", Offset = "0x28AA8E0", VA = "0x1828AB4E0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1A0DA10", Offset = "0x1A0CE10", VA = "0x181A0DA10")]
	public static global::IILCGFIHJLP<T, U> BPJDFPACLMK(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E3B0", Offset = "0x1A0D7B0", VA = "0x181A0E3B0")]
	public static global::IILCGFIHJLP<T, U> GMNMHGMFGOL(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NBPOLJHGGLE<T, U, V> : global::PPKEKBLDDIK<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E450", Offset = "0x1A0D850", VA = "0x181A0E450")]
	public NBPOLJHGGLE(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x23E53B0", Offset = "0x23E47B0", VA = "0x1823E53B0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1A0DA10", Offset = "0x1A0CE10", VA = "0x181A0DA10")]
	public static global::NBPOLJHGGLE<T, U, V> BPJDFPACLMK(global::NBPOLJHGGLE<T, U, V> CMLAHPHDOHI, Action<T, U, V> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E3B0", Offset = "0x1A0D7B0", VA = "0x181A0E3B0")]
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
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E450", Offset = "0x1A0D850", VA = "0x181A0E450")]
	public AAPEGDHKHJI(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1E125E0", Offset = "0x1E119E0", VA = "0x181E125E0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1A0DA10", Offset = "0x1A0CE10", VA = "0x181A0DA10")]
	public static global::AAPEGDHKHJI<T, U, V, W> BPJDFPACLMK(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E3B0", Offset = "0x1A0D7B0", VA = "0x181A0E3B0")]
	public static global::AAPEGDHKHJI<T, U, V, W> GMNMHGMFGOL(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EAHPNACBLDD<T, U, V, W, X> : global::PPKEKBLDDIK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E450", Offset = "0x1A0D850", VA = "0x181A0E450")]
	public EAHPNACBLDD(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1A0DAB0", Offset = "0x1A0CEB0", VA = "0x181A0DAB0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND, X NDILEEFABJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1A0DA10", Offset = "0x1A0CE10", VA = "0x181A0DA10")]
	public static global::EAHPNACBLDD<T, U, V, W, X> BPJDFPACLMK(global::EAHPNACBLDD<T, U, V, W, X> CMLAHPHDOHI, Action<T, U, V, W, X> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1A0E3B0", Offset = "0x1A0D7B0", VA = "0x181A0E3B0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
		public IHHEENOOOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1A139F0", Offset = "0x1A12DF0", VA = "0x181A139F0")]
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
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x418D80", Offset = "0x418180", VA = "0x180418D80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1A04B60", Offset = "0x1A03F60", VA = "0x181A04B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DGHLKNONJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1A04AB0", Offset = "0x1A03EB0", VA = "0x181A04AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FKGBKNHFJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1A04CE0", Offset = "0x1A040E0", VA = "0x181A04CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::DJEFEGOJFPA<T> FFDEELPIEJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1A04AE0", Offset = "0x1A03EE0", VA = "0x181A04AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1A06AC0", Offset = "0x1A05EC0", VA = "0x181A06AC0")]
	public DJEFEGOJFPA(T KEPEHMMFIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1A052F0", Offset = "0x1A046F0", VA = "0x181A052F0")]
	public global::DJEFEGOJFPA<T> NBIOIKFGOLK(T BLEIKCEPEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1A05410", Offset = "0x1A04810", VA = "0x181A05410")]
	public global::DJEFEGOJFPA<T> NIHHKMAKGGP(T MJJAEOPELND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1A04550", Offset = "0x1A03950", VA = "0x181A04550")]
	public global::DJEFEGOJFPA<T> BIHKNNPGGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1A04FB0", Offset = "0x1A043B0", VA = "0x181A04FB0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1A05EF0", Offset = "0x1A052F0", VA = "0x181A05EF0")]
	public global::DJEFEGOJFPA<T> ONEGNLENCDK(T ICJLNPKIMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1A057A0", Offset = "0x1A04BA0", VA = "0x181A057A0")]
	public static void ONBECCDMLGM(global::DJEFEGOJFPA<T> MPGOABMOIAA, IJPAKLJLNOI BDNPNGGCFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x197D5F0", Offset = "0x197C9F0", VA = "0x18197D5F0")]
	public static void ONBECCDMLGM<A>(global::DJEFEGOJFPA<T> MPGOABMOIAA, Func<global::DJEFEGOJFPA<T>, A, bool> BDNPNGGCFPN, A OHFMPKJCLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1A06520", Offset = "0x1A05920", VA = "0x181A06520")]
	public static string PODKJCBOELP(global::DJEFEGOJFPA<T> MPGOABMOIAA, int MBLPPLGFEAE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1A04890", Offset = "0x1A03C90", VA = "0x181A04890")]
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
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal DMLIOOCLKKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x44AE00", Offset = "0x44A200", VA = "0x18044AE00")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x45C9A0", Offset = "0x45BDA0", VA = "0x18045C9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DBLCENPKMBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x43E100", Offset = "0x43D500", VA = "0x18043E100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x43E280", Offset = "0x43D680", VA = "0x18043E280")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime JKNPCOLJCFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x4055C0", Offset = "0x4049C0", VA = "0x1804055C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x47FA20", Offset = "0x47EE20", VA = "0x18047FA20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1C34D60", Offset = "0x1C34160", VA = "0x181C34D60")]
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
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x42EB30", Offset = "0x42DF30", VA = "0x18042EB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool DPNLGBNIPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1C327D0", Offset = "0x1C31BD0", VA = "0x181C327D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int BIIJACLJEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5AFFE0", Offset = "0x5AF3E0", VA = "0x1805AFFE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x670470", VA = "0x180671070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1C32860", Offset = "0x1C31C60", VA = "0x181C32860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1C334C0", Offset = "0x1C328C0", VA = "0x181C334C0")]
	public CPHIIFBLCDH(int NPKCAEOBEMO, [Optional] MPDHPMIIDDC OFPCFKKBIFN, [Optional] IEqualityComparer<TKey> HDCCPNMDACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1C337B0", Offset = "0x1C32BB0", VA = "0x181C337B0")]
	public CPHIIFBLCDH(int NPKCAEOBEMO, MPDHPMIIDDC OFPCFKKBIFN, TimeSpan CHAADHJMNPA, [Optional] IEqualityComparer<TKey> HDCCPNMDACM, [Optional] CJHBFCGNJFA MFMGHDDBPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1C32260", Offset = "0x1C31660", VA = "0x181C32260")]
	public void CHMGPFLMEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C31EA0", Offset = "0x1C312A0", VA = "0x181C31EA0")]
	public void BDJFGEJFPPO(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C31F60", Offset = "0x1C31360", VA = "0x181C31F60")]
	public bool BIHKNNPGGKP(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1C329E0", Offset = "0x1C31DE0", VA = "0x181C329E0")]
	public bool IMCPFLDKEOH(TKey LFHKOFIPIEK, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C32E70", Offset = "0x1C32270", VA = "0x181C32E70")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1C320E0", Offset = "0x1C314E0", VA = "0x181C320E0")]
	private bool CHGILPBCJJD(NAGHLDJNNAJ KNAIJICNDHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1C33170", Offset = "0x1C32570", VA = "0x181C33170")]
	private void NMABOMIEHEE(LinkedListNode<NAGHLDJNNAJ> CDGLMCIFCBO, TVal BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1C325C0", Offset = "0x1C319C0", VA = "0x181C325C0")]
	private void DOEHAPOJMON(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1C32CD0", Offset = "0x1C320D0", VA = "0x181C32CD0")]
	private void LEOHCFPGCKH(NAGHLDJNNAJ KNAIJICNDHB, TVal BCEFAKDFEMM, int LNABDPGDHED)
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1D767B0", Offset = "0x1D75BB0", VA = "0x181D767B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x38C2530", Offset = "0x38C1930", VA = "0x1838C2530")]
		public SerializedGuid(in Guid COFLAJFOPEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x38C24B0", Offset = "0x38C18B0", VA = "0x1838C24B0")]
		public static SerializedGuid PECEFFJNJCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x38C22E0", Offset = "0x38C16E0", VA = "0x1838C22E0")]
		public static SerializedGuid KEBCJKEKCLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x38C2360", Offset = "0x38C1760", VA = "0x1838C2360")]
		public bool MEBGJGNMIMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x38C2490", Offset = "0x38C1890", VA = "0x1838C2490", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x38C23F0", Offset = "0x38C17F0", VA = "0x1838C23F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x38C2150", Offset = "0x38C1550", VA = "0x1838C2150", Slot = "7")]
		public bool Equals(SerializedGuid HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x38C21F0", Offset = "0x38C15F0", VA = "0x1838C21F0", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x38C22D0", Offset = "0x38C16D0", VA = "0x1838C22D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x38C2120", Offset = "0x38C1520", VA = "0x1838C2120", Slot = "6")]
		public int CompareTo(SerializedGuid HPKICPNGMDJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
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

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x38C0160", Offset = "0x38BF560", VA = "0x1838C0160")]
	public GHNKMPMKPPL(Type JMFLBLMBNKK, string KECHIFBPPED, bool JAIKKDFAMGK = false, bool KCOKJMBLCHE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JDGADLJCIJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool KOIKDFBKFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JDGADLJCIJC<T> LHHAHBBBDOA(Action<T> CIBJIOPEHOJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::JDGADLJCIJC<T> ONIEADDFNIG(Action<T> CIBJIOPEHOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
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

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T DMLIOOCLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4129C0", Offset = "0x411DC0", VA = "0x1804129C0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1DBE6E0", Offset = "0x1DBDAE0", VA = "0x181DBE6E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KOIKDFBKFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x459480", Offset = "0x458880", VA = "0x180459480", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFED0", Offset = "0x1FFF2D0", VA = "0x181FFFED0")]
	private void CPDEMFAEBMA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFF50", Offset = "0x1FFF350", VA = "0x181FFFF50", Slot = "4")]
	public global::JDGADLJCIJC<T> LHHAHBBBDOA(Action<T> COCKCCFIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFFD0", Offset = "0x1FFF3D0", VA = "0x181FFFFD0", Slot = "5")]
	public global::JDGADLJCIJC<T> ONIEADDFNIG(Action<T> CIBJIOPEHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2000000", Offset = "0x1FFF400", VA = "0x182000000")]
	public LNGJEDLLFHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PNGLIKCFGDE
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
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

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
		public COCCCIAHGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3038080", Offset = "0x3037480", VA = "0x183038080")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1EFA790", Offset = "0x1EF9B90", VA = "0x181EFA790")]
	public static global::PMGCJEPKFOF<T> DDGIPHJPODB<T>(this global::JDGADLJCIJC<T> BOPFDMGIMPK, Action<T> AFLPGGJMPOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class CJHBFCGNJFA
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private class HIKPHEBEPCE : CJHBFCGNJFA
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static CJHBFCGNJFA ONCPNMDGGKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x38C0660", Offset = "0x38BFA60", VA = "0x1838C0660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override DateTime GJMKMFNGGDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x38C0610", Offset = "0x38BFA10", VA = "0x1838C0610", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x38C0750", Offset = "0x38BFB50", VA = "0x1838C0750")]
		public HIKPHEBEPCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static CJHBFCGNJFA AKAMNPLKANB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static CJHBFCGNJFA EDLIKGJFHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x38BFC70", Offset = "0x38BF070", VA = "0x1838BFC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract DateTime GJMKMFNGGDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
	protected CJHBFCGNJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class PIDMLFKAEJP : global::AFLBJKBIMFL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x38C1E80", Offset = "0x38C1280", VA = "0x1838C1E80")]
	public PIDMLFKAEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class AFLBJKBIMFL<T> : global::IKAEDJBFIMM<T>, LMNJIGBCDFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x12B5E20", Offset = "0x12B5220", VA = "0x1812B5E20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1C78FC0", Offset = "0x1C783C0", VA = "0x181C78FC0")]
	public AFLBJKBIMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class COOJEJBKMJN<T> : global::IKAEDJBFIMM<T>, LMNJIGBCDFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x12B5E20", Offset = "0x12B5220", VA = "0x1812B5E20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1C31CF0", Offset = "0x1C310F0", VA = "0x181C31CF0")]
	public COOJEJBKMJN(Exception CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LMNJIGBCDFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	[NotNull]
	DABKFAIHBBP BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface IKAEDJBFIMM<T> : LMNJIGBCDFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	[NotNull]
	new global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public abstract class GPMPDFCGLHC<TTask, T> : global::IKAEDJBFIMM<T>, LMNJIGBCDFB, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class OIDNALEJNEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public global::GPMPDFCGLHC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
		public OIDNALEJNEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LIGEKDBLAPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public OIDNALEJNEK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
		public LIGEKDBLAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1F2B930", Offset = "0x1F2AD30", VA = "0x181F2B930")]
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

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Task<T> MODANKMBCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4055B0", Offset = "0x4049B0", VA = "0x1804055B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool OANHDHKALEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4B27F0", Offset = "0x4B1BF0", VA = "0x1804B27F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1F2AF60", Offset = "0x1F2A360", VA = "0x181F2AF60")]
	static GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B0D0", Offset = "0x1F2A4D0", VA = "0x181F2B0D0")]
	protected GPMPDFCGLHC(TTask CFNPEPPKEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1F2A950", Offset = "0x1F29D50", VA = "0x181F2A950", Slot = "1")]
	~GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1F2A7E0", Offset = "0x1F29BE0", VA = "0x181F2A7E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1F2AB10", Offset = "0x1F29F10", VA = "0x181F2AB10")]
	private void MDDAPCCABNK(bool CNDHCDEIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KMLPECLHIFN(TTask LIPAKCCDNKD);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void CFMNLNIIPIF();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1F2A6D0", Offset = "0x1F29AD0", VA = "0x181F2A6D0")]
	protected void COCHLMCDGCA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1F2AA90", Offset = "0x1F29E90", VA = "0x181F2AA90")]
	protected void GGLDPDNDEHO(string MOPOMPHBHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1F2A8B0", Offset = "0x1F29CB0", VA = "0x181F2A8B0")]
	[CompilerGenerated]
	private void EPHFENKGCHO(object BMEGDKCCBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class EFHMLIMBKPE<T> : IEnumerable<global::EFHMLIMBKPE<T>.KANNECPCOLP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct KANNECPCOLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T ONGBFDACHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int EFBDCIJMFGD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class KCNNGNNFBDL : IEnumerator<KANNECPCOLP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::EFHMLIMBKPE<T> FLLHBFDLKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int EFBDCIJMFGD;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x1A14C30", Offset = "0x1A14030", VA = "0x181A14C30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public KANNECPCOLP KAFEDPEFLOI
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1A14CA0", Offset = "0x1A140A0", VA = "0x181A14CA0", Slot = "4")]
			get
			{
				return default(KANNECPCOLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x47A680", Offset = "0x479A80", VA = "0x18047A680")]
		public KCNNGNNFBDL(global::EFHMLIMBKPE<T> FLLHBFDLKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1A14BA0", Offset = "0x1A13FA0", VA = "0x181A14BA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x47A670", Offset = "0x479A70", VA = "0x18047A670", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x53B3F0", Offset = "0x53A7F0", VA = "0x18053B3F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
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

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x163A090", Offset = "0x1639490", VA = "0x18163A090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1A0FDB0", Offset = "0x1A0F1B0", VA = "0x181A0FDB0")]
	public static global::EFHMLIMBKPE<T> OGGMCNEPMDA(KANNECPCOLP[] PPCOBBGKGCP, bool DBGPHICABDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1A101E0", Offset = "0x1A0F5E0", VA = "0x181A101E0")]
	public EFHMLIMBKPE(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1A0FD60", Offset = "0x1A0F160", VA = "0x181A0FD60")]
	public int KNHMLMKIOCH(T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1A0FAB0", Offset = "0x1A0EEB0", VA = "0x181A0FAB0")]
	public T DDGIPHJPODB(int EFBDCIJMFGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1A0FCF0", Offset = "0x1A0F0F0", VA = "0x181A0FCF0")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1A0FB20", Offset = "0x1A0EF20", VA = "0x181A0FB20")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG, int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1A0F970", Offset = "0x1A0ED70", VA = "0x181A0F970")]
	public KANNECPCOLP[] CAPGKOJNBIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1A0FD10", Offset = "0x1A0F110", VA = "0x181A0FD10")]
	private int KJMAGDFHGOD(int HKPHMBLKPFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1A10170", Offset = "0x1A0F570", VA = "0x181A10170", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1A10170", Offset = "0x1A0F570", VA = "0x181A10170", Slot = "4")]
	private IEnumerator<KANNECPCOLP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class BDMFLDBGOFG<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private List<T> KEOFINNFAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<T> OJKMJBCKGFJ;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1B31F40", Offset = "0x1B31340", VA = "0x181B31F40")]
	public BDMFLDBGOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1B31F70", Offset = "0x1B31370", VA = "0x181B31F70")]
	public BDMFLDBGOFG(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1B31E40", Offset = "0x1B31240", VA = "0x181B31E40")]
	public T OBCMOHDGJNN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1B31D20", Offset = "0x1B31120", VA = "0x181B31D20")]
	public void IOFOFLHIJGM(T IOKKOEMCNPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class LEOCHCLDMME<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
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

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x163A060", Offset = "0x1639460", VA = "0x18163A060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1FF8420", Offset = "0x1FF7820", VA = "0x181FF8420")]
	public bool KCFPIEEMJON(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x1FF8310", Offset = "0x1FF7710", VA = "0x181FF8310")]
	public void BPAJKKAGPKB(T ONGBFDACHHG, int JMHKMOACHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1FF81F0", Offset = "0x1FF75F0", VA = "0x181FF81F0")]
	public bool BIHKNNPGGKP(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF8670", Offset = "0x1FF7A70", VA = "0x181FF8670")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1FF8390", Offset = "0x1FF7790", VA = "0x181FF8390")]
	public T HMBMDDOFIKL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF7FE0", Offset = "0x1FF73E0", VA = "0x181FF7FE0")]
	private void ABKEBNFHIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF86D0", Offset = "0x1FF7AD0", VA = "0x181FF86D0")]
	public LEOCHCLDMME()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2250C50", Offset = "0x2250050", VA = "0x182250C50", Slot = "4")]
		public virtual T EDMOPEPBEHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x12B5D40", Offset = "0x12B5140", VA = "0x1812B5D40")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class OHFHKIPINGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<byte, MHJBJPJHPFD> KDGPABMFDAP;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public MHJBJPJHPFD FGCPPNAGAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3F6000", Offset = "0x3F5400", VA = "0x1803F6000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4055E0", Offset = "0x4049E0", VA = "0x1804055E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Vector2 JKPGFDOGKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xF29B60", Offset = "0xF28F60", VA = "0x180F29B60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1B33F70", Offset = "0x1B33370", VA = "0x181B33F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private Vector2 JECNPCKFHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB3E100", Offset = "0xB3D500", VA = "0x180B3E100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Vector2 KIBOLBPKFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5AC0", Offset = "0x2AC4EC0", VA = "0x182AC5AC0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2AC5AE0", Offset = "0x2AC4EE0", VA = "0x182AC5AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int BPOLFMEDCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x491B40", Offset = "0x490F40", VA = "0x180491B40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4F0130", Offset = "0x4EF530", VA = "0x1804F0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x38C16B0", Offset = "0x38C0AB0", VA = "0x1838C16B0")]
	public OHFHKIPINGN(Bounds HEJCIPIONHD, Vector2[] JJBMIAKPNFM, int ANHJMJFBOGC, byte HKPHMBLKPFI, float IKIIJCMDBLG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x38C1450", Offset = "0x38C0850", VA = "0x1838C1450")]
	public MHJBJPJHPFD HLCKAFHGBDM(byte EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x38C15D0", Offset = "0x38C09D0", VA = "0x1838C15D0")]
	public void NGKNKJMGCJO(Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE, ref List<byte> NPAGJNGHOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x38C1430", Offset = "0x38C0830", VA = "0x1838C1430")]
	public void GEPJEOGAEEH(MHJBJPJHPFD.HCMDPIPMANH KICELKEADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x38C14B0", Offset = "0x38C08B0", VA = "0x1838C14B0")]
	private MHJBJPJHPFD MOLJJAEIFLF(byte EFBDCIJMFGD, MHJBJPJHPFD.ENGKDHJBBKF OHEHDIDHCFP, MHJBJPJHPFD HICENEOPGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x38C0F10", Offset = "0x38C0310", VA = "0x1838C0F10")]
	private void AIDPBIKEJGM(MHJBJPJHPFD HICENEOPGOF, Vector2[] JJBMIAKPNFM, int MJCNPBEHJKC, int LBLOCDFALDE, int MFNBLGJBBJP, int OKBDDEDMDOB, float IKIIJCMDBLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class MHJBJPJHPFD
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum ENGKDHJBBKF
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
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

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x38C0BC0", Offset = "0x38BFFC0", VA = "0x1838C0BC0")]
	public MHJBJPJHPFD(byte ENJEOLBEALP, ENGKDHJBBKF OHEHDIDHCFP, MHJBJPJHPFD HICENEOPGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x38C08A0", Offset = "0x38BFCA0", VA = "0x1838C08A0")]
	public void NBIOIKFGOLK(MHJBJPJHPFD MLDKMIGAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x407640", Offset = "0x406A40", VA = "0x180407640")]
	public void GEPJEOGAEEH(int IDMAJACDJMF, HCMDPIPMANH KICELKEADCI, int NIIDNDCGMDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x38C0930", Offset = "0x38BFD30", VA = "0x1838C0930")]
	public void NGKNKJMGCJO(List<byte> NPAGJNGHOAE, Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x38C0800", Offset = "0x38BFC00", VA = "0x1838C0800")]
	public bool BJFFCFNIFNF(Vector3 KPLDEODOJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x38C0860", Offset = "0x38BFC60", VA = "0x1838C0860")]
	public bool IKJGCMKLGKF(Vector3 KPLDEODOJID, float BIMDOAEJMPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
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

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public T FLAGPNDNLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1B33320", Offset = "0x1B32720", VA = "0x181B33320")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public T ENONEADFACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1B332E0", Offset = "0x1B326E0", VA = "0x181B332E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public T IBDJAKGMLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1B32EE0", Offset = "0x1B322E0", VA = "0x181B32EE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1B33490", Offset = "0x1B32890", VA = "0x181B33490")]
	public BEPMBLAHCML(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1B330E0", Offset = "0x1B324E0", VA = "0x181B330E0")]
	public void BPAJKKAGPKB(T LMJGGCEBDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1B33230", Offset = "0x1B32630", VA = "0x181B33230")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x1B33440", Offset = "0x1B32840", VA = "0x181B33440")]
	public void OOAIDMBHDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1B33220", Offset = "0x1B32620", VA = "0x181B33220")]
	public void HEBIFJELCPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BJOIBBBOIKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
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

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public virtual T FNCFALEFNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xF29B60", Offset = "0xF28F60", VA = "0x180F29B60", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1B33F70", Offset = "0x1B33370", VA = "0x181B33F70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1B33FD0", Offset = "0x1B333D0", VA = "0x181B33FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public object KJFJIIDJCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4055C0", Offset = "0x4049C0", VA = "0x1804055C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x47FA20", Offset = "0x47EE20", VA = "0x18047FA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1B33CD0", Offset = "0x1B330D0", VA = "0x181B33CD0")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI, int JMHKMOACHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1B34000", Offset = "0x1B33400", VA = "0x181B34000")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x1B343B0", Offset = "0x1B337B0", VA = "0x181B343B0")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x1B34680", Offset = "0x1B33A80", VA = "0x181B34680")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x1B37440", Offset = "0x1B36840", VA = "0x181B37440")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1B396E0", Offset = "0x1B38AE0", VA = "0x181B396E0")]
	public BJOIBBBOIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class POJFBLMLAIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Dictionary<object, float> IOHBEHECBGL;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float JABPFAJNKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFF0", Offset = "0x8CE3F0", VA = "0x1808CEFF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x879A20", Offset = "0x878E20", VA = "0x180879A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x38C1FE0", Offset = "0x38C13E0", VA = "0x1838C1FE0")]
	public void DOEHAPOJMON(float ONGBFDACHHG, object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x38C2050", Offset = "0x38C1450", VA = "0x1838C2050")]
	public void HAHBGOMEMEE(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x38C1EC0", Offset = "0x38C12C0", VA = "0x1838C1EC0")]
	private void BHHBAENFOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x38C20B0", Offset = "0x38C14B0", VA = "0x1838C20B0")]
	public POJFBLMLAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class AOLMGGAPKEH
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class INIIDHCNCLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly string BIELLBOJOCP;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
		private INIIDHCNCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x41E770", Offset = "0x41DB70", VA = "0x18041E770")]
		public INIIDHCNCLK(string BIELLBOJOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x38C07B0", Offset = "0x38BFBB0", VA = "0x1838C07B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class HHHAHKJKNHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3FE660", Offset = "0x3FDA60", VA = "0x1803FE660")]
		public HHHAHKJKNHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x38C0560", Offset = "0x38BF960", VA = "0x1838C0560")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly HashSet<object> BGKNMHEJLMM;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool CFLJGNJLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x38BF700", Offset = "0x38BEB00", VA = "0x1838BF700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x38BF5F0", Offset = "0x38BE9F0", VA = "0x1838BF5F0")]
	public void BPAJKKAGPKB(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x38BF590", Offset = "0x38BE990", VA = "0x1838BF590")]
	public void BIHKNNPGGKP(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x38BF650", Offset = "0x38BEA50", VA = "0x1838BF650")]
	public bool KCFPIEEMJON(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x38BF6B0", Offset = "0x38BEAB0", VA = "0x1838BF6B0")]
	public void KFKPHICNHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38BF740", Offset = "0x38BEB40", VA = "0x1838BF740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x38BF8A0", Offset = "0x38BECA0", VA = "0x1838BF8A0")]
	public AOLMGGAPKEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HHIINKNOKNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
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

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public virtual T NKIEOKALHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA9A320", Offset = "0xA99720", VA = "0x180A9A320", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1B33F50", Offset = "0x1B33350", VA = "0x181B33F50", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public object GEDFELNLNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4129C0", Offset = "0x411DC0", VA = "0x1804129C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4059F0", Offset = "0x404DF0", VA = "0x1804059F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x28A16A0", Offset = "0x28A0AA0", VA = "0x1828A16A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x28A1310", Offset = "0x28A0710", VA = "0x1828A1310")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x28A16E0", Offset = "0x28A0AE0", VA = "0x1828A16E0")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1B34680", Offset = "0x1B33A80", VA = "0x181B34680")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2ECFE00", Offset = "0x2ECF200", VA = "0x182ECFE00")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0760", Offset = "0x2ECFB60", VA = "0x182ED0760")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x28A25E0", Offset = "0x28A19E0", VA = "0x1828A25E0")]
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
