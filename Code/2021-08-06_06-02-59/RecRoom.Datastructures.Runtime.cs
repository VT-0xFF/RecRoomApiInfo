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
	[Cpp2IlInjected.Address(RVA = "0x716AB0", Offset = "0x7158B0", VA = "0x180716AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F6E20", Offset = "0x3F5C20", VA = "0x1803F6E20")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x536480", Offset = "0x535280", VA = "0x180536480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F7210", Offset = "0x3F6010", VA = "0x1803F7210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "4")]
	public virtual void COBDCEFIEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2917280", Offset = "0x2916080", VA = "0x182917280", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2916DC0", Offset = "0x2915BC0", VA = "0x182916DC0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2917880", Offset = "0x2916680", VA = "0x182917880")]
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
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public AEAKOHFPLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x20E1460", Offset = "0x20E0260", VA = "0x1820E1460")]
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
		[Cpp2IlInjected.Address(RVA = "0x20E6130", Offset = "0x20E4F30", VA = "0x1820E6130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x20E6160", Offset = "0x20E4F60", VA = "0x1820E6160", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x20E6080", Offset = "0x20E4E80", VA = "0x1820E6080", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey DNGKIAJLLHG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x20E60E0", Offset = "0x20E4EE0", VA = "0x1820E60E0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x20E5F90", Offset = "0x20E4D90", VA = "0x1820E5F90", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x20E5800", Offset = "0x20E4600", VA = "0x1820E5800", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x20E5170", Offset = "0x20E3F70", VA = "0x1820E5170", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x20E4DD0", Offset = "0x20E3BD0", VA = "0x1820E4DD0", Slot = "14")]
	protected virtual string LKCOLBMMLKA(TKeyVal GALGADHFCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1EFC540", Offset = "0x1EFB340", VA = "0x181EFC540", Slot = "4")]
	public bool ContainsKey(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x20E5E90", Offset = "0x20E4C90", VA = "0x1820E5E90", Slot = "5")]
	public bool TryGetValue(TKey DNGKIAJLLHG, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20E4CE0", Offset = "0x20E3AE0", VA = "0x1820E4CE0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x20E4CE0", Offset = "0x20E3AE0", VA = "0x1820E4CE0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20E5EC0", Offset = "0x20E4CC0", VA = "0x1820E5EC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x445B90", Offset = "0x444990", VA = "0x180445B90")]
		[DebuggerHidden]
		public FIOCHCGPCBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3895990", Offset = "0x3894790", VA = "0x183895990", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3895840", Offset = "0x3894640", VA = "0x183895840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3895A00", Offset = "0x3894800", VA = "0x183895A00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3895940", Offset = "0x3894740", VA = "0x183895940", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x3895DC0", Offset = "0x3894BC0", VA = "0x183895DC0")]
	public static void RegisterDontDestroyOnLoad(GameObject NNNMGKGMIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3895BE0", Offset = "0x38949E0", VA = "0x183895BE0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3895E60", Offset = "0x3894C60", VA = "0x183895E60")]
	[IteratorStateMachine(typeof(FIOCHCGPCBF))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "6")]
	protected virtual void BFNKJCLBGIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3895F20", Offset = "0x3894D20", VA = "0x183895F20")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CGINBDPPLIO
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B4DE60", Offset = "0x1B4CC60", VA = "0x181B4DE60")]
	public static void DFFNGCIAOME<T>(this T CKCMODJNCNF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38955B0", Offset = "0x38943B0", VA = "0x1838955B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x769340", Offset = "0x768140", VA = "0x180769340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2513930", Offset = "0x2512730", VA = "0x182513930", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2513E00", Offset = "0x2512C00", VA = "0x182513E00", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x20E6190", Offset = "0x20E4F90", VA = "0x1820E6190")]
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
		[Cpp2IlInjected.Address(RVA = "0x981B80", Offset = "0x980980", VA = "0x180981B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3896630", Offset = "0x3895430", VA = "0x183896630")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3896850", Offset = "0x3895650", VA = "0x183896850")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74EA40", Offset = "0x74D840", VA = "0x18074EA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x769340", Offset = "0x768140", VA = "0x180769340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool FFNIFALJLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2918760", Offset = "0x2917560", VA = "0x182918760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2918220", Offset = "0x2917020", VA = "0x182918220", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x29185A0", Offset = "0x29173A0", VA = "0x1829185A0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x20E6190", Offset = "0x20E4F90", VA = "0x1820E6190")]
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
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public NMKBADGNEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2514C90", Offset = "0x2513A90", VA = "0x182514C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2507620", Offset = "0x2506420", VA = "0x182507620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2507AA0", Offset = "0x25068A0", VA = "0x182507AA0")]
	public HKMGKEPIIGN(float EBNPDDOHPII, float PDNBGEMGHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2507720", Offset = "0x2506520", VA = "0x182507720")]
	public bool NNLAEHCFGLO(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25072C0", Offset = "0x25060C0", VA = "0x1825072C0")]
	public IEnumerable<T> BKGJKBJPEID(float MOPKOPOKKEE, [Optional] float? DJJCAALEIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25075F0", Offset = "0x25063F0", VA = "0x1825075F0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25079E0", Offset = "0x25067E0", VA = "0x1825079E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7630B0", Offset = "0x761EB0", VA = "0x1807630B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7630C0", Offset = "0x761EC0", VA = "0x1807630C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1E15840", Offset = "0x1E14640", VA = "0x181E15840")]
	public GMNJGMLCABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1E15870", Offset = "0x1E14670", VA = "0x181E15870")]
	public GMNJGMLCABC(int OJJOHDIFMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1E149E0", Offset = "0x1E137E0", VA = "0x181E149E0")]
	public void BPAJKKAGPKB(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1E152A0", Offset = "0x1E140A0", VA = "0x181E152A0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1E14DB0", Offset = "0x1E13BB0", VA = "0x181E14DB0")]
	public bool IMMBIFHODMF(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1E15140", Offset = "0x1E13F40", VA = "0x181E15140")]
	public bool KJPECKDEGGL(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E156A0", Offset = "0x1E144A0", VA = "0x181E156A0")]
	public void OCCODBALDOD(float JODPOANPJNK, float BCANLCHBKJE, List<T> NKHPHBOPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1E14F60", Offset = "0x1E13D60", VA = "0x181E14F60")]
	private int JDDBKHEGJHN(int NPDLAJLCALI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1E149A0", Offset = "0x1E137A0", VA = "0x181E149A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3895440", Offset = "0x3894240", VA = "0x183895440", Slot = "4")]
	protected override Vector3 KPKMNLDBMEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x38954B0", Offset = "0x38942B0", VA = "0x1838954B0", Slot = "5")]
	protected override Vector3 PIFFNJDGHDE(Vector3 ONGBFDACHHG, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3895320", Offset = "0x3894120", VA = "0x183895320", Slot = "6")]
	protected override Vector3 CAPOCJJJJIB(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38953D0", Offset = "0x38941D0", VA = "0x1838953D0", Slot = "7")]
	protected override Vector3 JIODMOCKLKL(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3895550", Offset = "0x3894350", VA = "0x183895550")]
	public APDBOLKPCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DLPGJKJFNCM
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x17772A0", Offset = "0x17760A0", VA = "0x1817772A0")]
	public static global::DHKPBIAHMHG<T1, T2> NFHADFCEMML<T1, T2>(T1 OFCHPINAEEE, T2 NLNENAIDOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1777310", Offset = "0x1776110", VA = "0x181777310")]
	public static global::ELGBCKDBOED<T1, T2, T3> NFHADFCEMML<T1, T2, T3>(T1 OFCHPINAEEE, T2 NLNENAIDOJD, T3 FGPNPLGENDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x26C05C0", Offset = "0x26BF3C0", VA = "0x1826C05C0")]
	internal static int FBNEHNPAJDI(int JGPNKFEDCDB, int EDGDLDGIIMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x327DF00", Offset = "0x327CD00", VA = "0x18327DF00")]
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
	[Cpp2IlInjected.Address(RVA = "0x18BFE40", Offset = "0x18BEC40", VA = "0x1818BFE40")]
	public DHKPBIAHMHG(T1 OFCHPINAEEE, T2 NLNENAIDOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x37B0D00", Offset = "0x37AFB00", VA = "0x1837B0D00", Slot = "4")]
	public int CompareTo(global::DHKPBIAHMHG<T1, T2> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x37B0DC0", Offset = "0x37AFBC0", VA = "0x1837B0DC0", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37B0F70", Offset = "0x37AFD70", VA = "0x1837B0F70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37B1040", Offset = "0x37AFE40", VA = "0x1837B1040", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x18CE290", Offset = "0x18CD090", VA = "0x1818CE290")]
	public ELGBCKDBOED(T1 OFCHPINAEEE, T2 NLNENAIDOJD, T3 FGPNPLGENDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x18CDE20", Offset = "0x18CCC20", VA = "0x1818CDE20", Slot = "4")]
	public int CompareTo(global::ELGBCKDBOED<T1, T2, T3> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x18CDF20", Offset = "0x18CCD20", VA = "0x1818CDF20", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x18CE090", Offset = "0x18CCE90", VA = "0x1818CE090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x18CE100", Offset = "0x18CCF00", VA = "0x1818CE100", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FA180", Offset = "0x3F8F80", VA = "0x1803FA180")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4437E0", Offset = "0x4425E0", VA = "0x1804437E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float BPHIOMBNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7634F0", Offset = "0x7622F0", VA = "0x1807634F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x29D3570", Offset = "0x29D2370", VA = "0x1829D3570")]
	public T DHEIFNLDBKN(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x29D3810", Offset = "0x29D2610", VA = "0x1829D3810")]
	public T NICCICAFMDM(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ADPELJHGHKK(T LONDCJPNKKN, T PCEJJILDLGD, float LIMOILDIGKF);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3895AC0", Offset = "0x38948C0", VA = "0x183895AC0", Slot = "4")]
	protected override float ADPELJHGHKK(float LONDCJPNKKN, float PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3895B40", Offset = "0x3894940", VA = "0x183895B40")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3897F80", Offset = "0x3896D80", VA = "0x183897F80", Slot = "4")]
	protected override Vector3 ADPELJHGHKK(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3898040", Offset = "0x3896E40", VA = "0x183898040")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3888010", Offset = "0x3886E10", VA = "0x183888010", Slot = "4")]
	protected override Color ADPELJHGHKK(Color LONDCJPNKKN, Color PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3895800", Offset = "0x3894600", VA = "0x183895800")]
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
			[Cpp2IlInjected.Address(RVA = "0x7630B0", Offset = "0x761EB0", VA = "0x1807630B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x1E0ED40", Offset = "0x1E0DB40", VA = "0x181E0ED40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F130", Offset = "0x1E0DF30", VA = "0x181E0F130")]
		public Enumerator(global::GPFLNFOKEIA<T> NKHPHBOPPEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E3D0", Offset = "0x1E0D1D0", VA = "0x181E0E3D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EB50", Offset = "0x1E0D950", VA = "0x181E0EB50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E8B0", Offset = "0x1E0D6B0", VA = "0x181E0E8B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E16B60", Offset = "0x1E15960", VA = "0x181E16B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1E16450", Offset = "0x1E15250", VA = "0x181E16450")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1E16280", Offset = "0x1E15080", VA = "0x181E16280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1E170F0", Offset = "0x1E15EF0", VA = "0x181E170F0")]
	public GPFLNFOKEIA(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E15F00", Offset = "0x1E14D00", VA = "0x181E15F00")]
	public void BPAJKKAGPKB(T LIMOILDIGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1E16570", Offset = "0x1E15370", VA = "0x181E16570")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1E16590", Offset = "0x1E15390", VA = "0x181E16590")]
	public void NAJLLGFNIKC(int MNIJHBJDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1E16620", Offset = "0x1E15420", VA = "0x181E16620")]
	public void NPAGGFDPFJK(T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1E161C0", Offset = "0x1E14FC0", VA = "0x181E161C0")]
	public Enumerator CINCGNABFNK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1E16F60", Offset = "0x1E15D60", VA = "0x181E16F60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1E16F60", Offset = "0x1E15D60", VA = "0x181E16F60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1E16C90", Offset = "0x1E15A90", VA = "0x181E16C90")]
	private int PLMBLHMDABK(int EFBDCIJMFGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1E15E10", Offset = "0x1E14C10", VA = "0x181E15E10")]
	private int BCDNPPPABOI(int EFBDCIJMFGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KBNAHLKGDBF
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
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
		[Cpp2IlInjected.Address(RVA = "0x3043B90", Offset = "0x3042990", VA = "0x183043B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3043F60", Offset = "0x3042D60", VA = "0x183043F60")]
	public PPKEKBLDDIK(int NPKCAEOBEMO, bool JNIOEAEOGFI, bool NOLKFLLKNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3043B20", Offset = "0x3042920", VA = "0x183043B20", Slot = "1")]
	~PPKEKBLDDIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3043A90", Offset = "0x3042890", VA = "0x183043A90")]
	protected void FIAILKDOPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3043E80", Offset = "0x3042C80", VA = "0x183043E80")]
	protected void NBBNPIGEGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3043CD0", Offset = "0x3042AD0", VA = "0x183043CD0")]
	protected void MPOMLFNCCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3043970", Offset = "0x3042770", VA = "0x183043970", Slot = "4")]
	public void BPAJKKAGPKB(T JJGHIEJCCDA, bool GLAMKMBICFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3043850", Offset = "0x3042650", VA = "0x183043850", Slot = "5")]
	public void BIHKNNPGGKP(T JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3043BC0", Offset = "0x30429C0", VA = "0x183043BC0")]
	public void LKLKGDMFMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OKNNKFGFODL : global::PPKEKBLDDIK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3897830", Offset = "0x3896630", VA = "0x183897830")]
	public OKNNKFGFODL(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3897620", Offset = "0x3896420", VA = "0x183897620")]
	public void CNFDGDEOPPF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x38975C0", Offset = "0x38963C0", VA = "0x1838975C0")]
	public static OKNNKFGFODL BPJDFPACLMK(OKNNKFGFODL CMLAHPHDOHI, Action JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38977D0", Offset = "0x38965D0", VA = "0x1838977D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x18C9DE0", Offset = "0x18C8BE0", VA = "0x1818C9DE0")]
	public MFBGLIHGCGO(int NPKCAEOBEMO = 4, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x22036D0", Offset = "0x22024D0", VA = "0x1822036D0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x18C93A0", Offset = "0x18C81A0", VA = "0x1818C93A0")]
	public static global::MFBGLIHGCGO<T> BPJDFPACLMK(global::MFBGLIHGCGO<T> CMLAHPHDOHI, Action<T> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x18C9D40", Offset = "0x18C8B40", VA = "0x1818C9D40")]
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
	[Cpp2IlInjected.Address(RVA = "0x18C9DE0", Offset = "0x18C8BE0", VA = "0x1818C9DE0")]
	public IILCGFIHJLP(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x250E120", Offset = "0x250CF20", VA = "0x18250E120")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x18C93A0", Offset = "0x18C81A0", VA = "0x1818C93A0")]
	public static global::IILCGFIHJLP<T, U> BPJDFPACLMK(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x18C9D40", Offset = "0x18C8B40", VA = "0x1818C9D40")]
	public static global::IILCGFIHJLP<T, U> GMNMHGMFGOL(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NBPOLJHGGLE<T, U, V> : global::PPKEKBLDDIK<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x18C9DE0", Offset = "0x18C8BE0", VA = "0x1818C9DE0")]
	public NBPOLJHGGLE(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2209FD0", Offset = "0x2208DD0", VA = "0x182209FD0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x18C93A0", Offset = "0x18C81A0", VA = "0x1818C93A0")]
	public static global::NBPOLJHGGLE<T, U, V> BPJDFPACLMK(global::NBPOLJHGGLE<T, U, V> CMLAHPHDOHI, Action<T, U, V> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x18C9D40", Offset = "0x18C8B40", VA = "0x1818C9D40")]
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
	[Cpp2IlInjected.Address(RVA = "0x18C9DE0", Offset = "0x18C8BE0", VA = "0x1818C9DE0")]
	public AAPEGDHKHJI(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1C92BE0", Offset = "0x1C919E0", VA = "0x181C92BE0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x18C93A0", Offset = "0x18C81A0", VA = "0x1818C93A0")]
	public static global::AAPEGDHKHJI<T, U, V, W> BPJDFPACLMK(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x18C9D40", Offset = "0x18C8B40", VA = "0x1818C9D40")]
	public static global::AAPEGDHKHJI<T, U, V, W> GMNMHGMFGOL(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EAHPNACBLDD<T, U, V, W, X> : global::PPKEKBLDDIK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x18C9DE0", Offset = "0x18C8BE0", VA = "0x1818C9DE0")]
	public EAHPNACBLDD(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x18C9440", Offset = "0x18C8240", VA = "0x1818C9440")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND, X NDILEEFABJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x18C93A0", Offset = "0x18C81A0", VA = "0x1818C93A0")]
	public static global::EAHPNACBLDD<T, U, V, W, X> BPJDFPACLMK(global::EAHPNACBLDD<T, U, V, W, X> CMLAHPHDOHI, Action<T, U, V, W, X> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x18C9D40", Offset = "0x18C8B40", VA = "0x1818C9D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public IHHEENOOOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x18CF380", Offset = "0x18CE180", VA = "0x1818CF380")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FA170", Offset = "0x3F8F70", VA = "0x1803FA170")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x18C04F0", Offset = "0x18BF2F0", VA = "0x1818C04F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DGHLKNONJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x18C0440", Offset = "0x18BF240", VA = "0x1818C0440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FKGBKNHFJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x18C0670", Offset = "0x18BF470", VA = "0x1818C0670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::DJEFEGOJFPA<T> FFDEELPIEJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x18C0470", Offset = "0x18BF270", VA = "0x1818C0470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x18C2450", Offset = "0x18C1250", VA = "0x1818C2450")]
	public DJEFEGOJFPA(T KEPEHMMFIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x18C0C80", Offset = "0x18BFA80", VA = "0x1818C0C80")]
	public global::DJEFEGOJFPA<T> NBIOIKFGOLK(T BLEIKCEPEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x18C0DA0", Offset = "0x18BFBA0", VA = "0x1818C0DA0")]
	public global::DJEFEGOJFPA<T> NIHHKMAKGGP(T MJJAEOPELND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x18BFEE0", Offset = "0x18BECE0", VA = "0x1818BFEE0")]
	public global::DJEFEGOJFPA<T> BIHKNNPGGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x18C0940", Offset = "0x18BF740", VA = "0x1818C0940")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x18C1880", Offset = "0x18C0680", VA = "0x1818C1880")]
	public global::DJEFEGOJFPA<T> ONEGNLENCDK(T ICJLNPKIMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x18C1130", Offset = "0x18BFF30", VA = "0x1818C1130")]
	public static void ONBECCDMLGM(global::DJEFEGOJFPA<T> MPGOABMOIAA, IJPAKLJLNOI BDNPNGGCFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1B4E520", Offset = "0x1B4D320", VA = "0x181B4E520")]
	public static void ONBECCDMLGM<A>(global::DJEFEGOJFPA<T> MPGOABMOIAA, Func<global::DJEFEGOJFPA<T>, A, bool> BDNPNGGCFPN, A OHFMPKJCLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x18C1EB0", Offset = "0x18C0CB0", VA = "0x1818C1EB0")]
	public static string PODKJCBOELP(global::DJEFEGOJFPA<T> MPGOABMOIAA, int MBLPPLGFEAE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x18C0220", Offset = "0x18BF020", VA = "0x1818C0220")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6E20", Offset = "0x3F5C20", VA = "0x1803F6E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x42C2C0", Offset = "0x42B0C0", VA = "0x18042C2C0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x43DE90", Offset = "0x43CC90", VA = "0x18043DE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DBLCENPKMBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x41F5B0", Offset = "0x41E3B0", VA = "0x18041F5B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x41F730", Offset = "0x41E530", VA = "0x18041F730")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime JKNPCOLJCFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x3F6400", Offset = "0x3F5200", VA = "0x1803F6400")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x460F90", Offset = "0x45FD90", VA = "0x180460F90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDA10", Offset = "0x1CFC810", VA = "0x181CFDA10")]
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
		[Cpp2IlInjected.Address(RVA = "0x40FFE0", Offset = "0x40EDE0", VA = "0x18040FFE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CFB480", Offset = "0x1CFA280", VA = "0x181CFB480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int BIIJACLJEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x567E30", Offset = "0x566C30", VA = "0x180567E30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x567F70", Offset = "0x566D70", VA = "0x180567F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1CFB510", Offset = "0x1CFA310", VA = "0x181CFB510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC170", Offset = "0x1CFAF70", VA = "0x181CFC170")]
	public CPHIIFBLCDH(int NPKCAEOBEMO, [Optional] MPDHPMIIDDC OFPCFKKBIFN, [Optional] IEqualityComparer<TKey> HDCCPNMDACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC460", Offset = "0x1CFB260", VA = "0x181CFC460")]
	public CPHIIFBLCDH(int NPKCAEOBEMO, MPDHPMIIDDC OFPCFKKBIFN, TimeSpan CHAADHJMNPA, [Optional] IEqualityComparer<TKey> HDCCPNMDACM, [Optional] CJHBFCGNJFA MFMGHDDBPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAF10", Offset = "0x1CF9D10", VA = "0x181CFAF10")]
	public void CHMGPFLMEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAB50", Offset = "0x1CF9950", VA = "0x181CFAB50")]
	public void BDJFGEJFPPO(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAC10", Offset = "0x1CF9A10", VA = "0x181CFAC10")]
	public bool BIHKNNPGGKP(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB690", Offset = "0x1CFA490", VA = "0x181CFB690")]
	public bool IMCPFLDKEOH(TKey LFHKOFIPIEK, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1CFBB20", Offset = "0x1CFA920", VA = "0x181CFBB20")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAD90", Offset = "0x1CF9B90", VA = "0x181CFAD90")]
	private bool CHGILPBCJJD(NAGHLDJNNAJ KNAIJICNDHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1CFBE20", Offset = "0x1CFAC20", VA = "0x181CFBE20")]
	private void NMABOMIEHEE(LinkedListNode<NAGHLDJNNAJ> CDGLMCIFCBO, TVal BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB270", Offset = "0x1CFA070", VA = "0x181CFB270")]
	private void DOEHAPOJMON(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB980", Offset = "0x1CFA780", VA = "0x181CFB980")]
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
			[Cpp2IlInjected.Address(RVA = "0x1BFBEE0", Offset = "0x1BFACE0", VA = "0x181BFBEE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3897F50", Offset = "0x3896D50", VA = "0x183897F50")]
		public SerializedGuid(in Guid COFLAJFOPEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3897ED0", Offset = "0x3896CD0", VA = "0x183897ED0")]
		public static SerializedGuid PECEFFJNJCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3897D00", Offset = "0x3896B00", VA = "0x183897D00")]
		public static SerializedGuid KEBCJKEKCLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3897D80", Offset = "0x3896B80", VA = "0x183897D80")]
		public bool MEBGJGNMIMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3897EB0", Offset = "0x3896CB0", VA = "0x183897EB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3897E10", Offset = "0x3896C10", VA = "0x183897E10", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3897B70", Offset = "0x3896970", VA = "0x183897B70", Slot = "7")]
		public bool Equals(SerializedGuid HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3897C10", Offset = "0x3896A10", VA = "0x183897C10", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3897CF0", Offset = "0x3896AF0", VA = "0x183897CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3897B40", Offset = "0x3896940", VA = "0x183897B40", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x3895B80", Offset = "0x3894980", VA = "0x183895B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FA180", Offset = "0x3F8F80", VA = "0x1803FA180", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F07A70", Offset = "0x1F06870", VA = "0x181F07A70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KOIKDFBKFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x43A970", Offset = "0x439770", VA = "0x18043A970", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F07970", Offset = "0x1F06770", VA = "0x181F07970")]
	private void CPDEMFAEBMA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F079F0", Offset = "0x1F067F0", VA = "0x181F079F0", Slot = "4")]
	public global::JDGADLJCIJC<T> LHHAHBBBDOA(Action<T> COCKCCFIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1F07AA0", Offset = "0x1F068A0", VA = "0x181F07AA0", Slot = "5")]
	public global::JDGADLJCIJC<T> ONIEADDFNIG(Action<T> CIBJIOPEHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1F07AD0", Offset = "0x1F068D0", VA = "0x181F07AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public COCCCIAHGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3031610", Offset = "0x3030410", VA = "0x183031610")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C660", Offset = "0x1D1B460", VA = "0x181D1C660")]
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
			[Cpp2IlInjected.Address(RVA = "0x3896080", Offset = "0x3894E80", VA = "0x183896080")]
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
			[Cpp2IlInjected.Address(RVA = "0x3896030", Offset = "0x3894E30", VA = "0x183896030", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3896170", Offset = "0x3894F70", VA = "0x183896170")]
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
		[Cpp2IlInjected.Address(RVA = "0x3895690", Offset = "0x3894490", VA = "0x183895690")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
	protected CJHBFCGNJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class PIDMLFKAEJP : global::AFLBJKBIMFL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x38978A0", Offset = "0x38966A0", VA = "0x1838978A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F6E20", Offset = "0x3F5C20", VA = "0x1803F6E20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x118F680", Offset = "0x118E480", VA = "0x18118F680", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1AC5020", Offset = "0x1AC3E20", VA = "0x181AC5020")]
	public AFLBJKBIMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F6E20", Offset = "0x3F5C20", VA = "0x1803F6E20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x118F680", Offset = "0x118E480", VA = "0x18118F680", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA9A0", Offset = "0x1CF97A0", VA = "0x181CFA9A0")]
	public COOJEJBKMJN(Exception CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "7")]
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
	private sealed class EKGLBOJPFMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public global::GPMPDFCGLHC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public EKGLBOJPFMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class IHHLCBAJHHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public EKGLBOJPFMP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public IHHLCBAJHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1E182A0", Offset = "0x1E170A0", VA = "0x181E182A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6E20", Offset = "0x3F5C20", VA = "0x1803F6E20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3F6E20", Offset = "0x3F5C20", VA = "0x1803F6E20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1E17A10", Offset = "0x1E16810", VA = "0x181E17A10")]
	static GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1E17B80", Offset = "0x1E16980", VA = "0x181E17B80")]
	protected GPMPDFCGLHC(TTask CFNPEPPKEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1E17400", Offset = "0x1E16200", VA = "0x181E17400", Slot = "1")]
	~GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1E173D0", Offset = "0x1E161D0", VA = "0x181E173D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1E175C0", Offset = "0x1E163C0", VA = "0x181E175C0")]
	private void MDDAPCCABNK(bool CNDHCDEIOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KMLPECLHIFN(TTask LIPAKCCDNKD);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void CFMNLNIIPIF();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1E172C0", Offset = "0x1E160C0", VA = "0x181E172C0")]
	protected void COCHLMCDGCA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1E17540", Offset = "0x1E16340", VA = "0x181E17540")]
	protected void GGLDPDNDEHO(string MOPOMPHBHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1E17220", Offset = "0x1E16020", VA = "0x181E17220")]
	[CompilerGenerated]
	private void CFMBCOAHJFB(object BMEGDKCCBHH)
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

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x18D05C0", Offset = "0x18CF3C0", VA = "0x1818D05C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public KANNECPCOLP KAFEDPEFLOI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x18D0630", Offset = "0x18CF430", VA = "0x1818D0630", Slot = "4")]
			get
			{
				return default(KANNECPCOLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x45BBF0", Offset = "0x45A9F0", VA = "0x18045BBF0")]
		public KCNNGNNFBDL(global::EFHMLIMBKPE<T> FLLHBFDLKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x18D0530", Offset = "0x18CF330", VA = "0x1818D0530", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x45BBE0", Offset = "0x45A9E0", VA = "0x18045BBE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4ECBB0", Offset = "0x4EB9B0", VA = "0x1804ECBB0", Slot = "5")]
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

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x13FD630", Offset = "0x13FC430", VA = "0x1813FD630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x18CB740", Offset = "0x18CA540", VA = "0x1818CB740")]
	public static global::EFHMLIMBKPE<T> OGGMCNEPMDA(KANNECPCOLP[] PPCOBBGKGCP, bool DBGPHICABDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x18CBB70", Offset = "0x18CA970", VA = "0x1818CBB70")]
	public EFHMLIMBKPE(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x18CB6F0", Offset = "0x18CA4F0", VA = "0x1818CB6F0")]
	public int KNHMLMKIOCH(T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x18CB440", Offset = "0x18CA240", VA = "0x1818CB440")]
	public T DDGIPHJPODB(int EFBDCIJMFGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x18CB680", Offset = "0x18CA480", VA = "0x1818CB680")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x18CB4B0", Offset = "0x18CA2B0", VA = "0x1818CB4B0")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG, int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x18CB300", Offset = "0x18CA100", VA = "0x1818CB300")]
	public KANNECPCOLP[] CAPGKOJNBIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x18CB6A0", Offset = "0x18CA4A0", VA = "0x1818CB6A0")]
	private int KJMAGDFHGOD(int HKPHMBLKPFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x18CBB00", Offset = "0x18CA900", VA = "0x1818CBB00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x18CBB00", Offset = "0x18CA900", VA = "0x1818CBB00", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1A84060", Offset = "0x1A82E60", VA = "0x181A84060")]
	public BDMFLDBGOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1A84090", Offset = "0x1A82E90", VA = "0x181A84090")]
	public BDMFLDBGOFG(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1A83F60", Offset = "0x1A82D60", VA = "0x181A83F60")]
	public T OBCMOHDGJNN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1A83E40", Offset = "0x1A82C40", VA = "0x181A83E40")]
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

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MEPGPGKFENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x13FD600", Offset = "0x13FC400", VA = "0x1813FD600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1EFF920", Offset = "0x1EFE720", VA = "0x181EFF920")]
	public bool KCFPIEEMJON(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1EFF810", Offset = "0x1EFE610", VA = "0x181EFF810")]
	public void BPAJKKAGPKB(T ONGBFDACHHG, int JMHKMOACHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x1EFF6F0", Offset = "0x1EFE4F0", VA = "0x181EFF6F0")]
	public bool BIHKNNPGGKP(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1EFFB70", Offset = "0x1EFE970", VA = "0x181EFFB70")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1EFF890", Offset = "0x1EFE690", VA = "0x181EFF890")]
	public T HMBMDDOFIKL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1EFF4E0", Offset = "0x1EFE2E0", VA = "0x181EFF4E0")]
	private void ABKEBNFHIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1EFFBD0", Offset = "0x1EFE9D0", VA = "0x181EFFBD0")]
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

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x211A2A0", Offset = "0x21190A0", VA = "0x18211A2A0", Slot = "4")]
		public virtual T EDMOPEPBEHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
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

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MHJBJPJHPFD FGCPPNAGAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6E20", Offset = "0x3F5C20", VA = "0x1803F6E20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3F7200", Offset = "0x3F6000", VA = "0x1803F7200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Vector2 JKPGFDOGKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xD4E3D0", Offset = "0xD4D1D0", VA = "0x180D4E3D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1A86970", Offset = "0x1A85770", VA = "0x181A86970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector2 JECNPCKFHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9D6E00", Offset = "0x9D5C00", VA = "0x1809D6E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Vector2 KIBOLBPKFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x29FBBB0", Offset = "0x29FA9B0", VA = "0x1829FBBB0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x29FBBD0", Offset = "0x29FA9D0", VA = "0x1829FBBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int BPOLFMEDCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4730E0", Offset = "0x471EE0", VA = "0x1804730E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD90", Offset = "0x6CAB90", VA = "0x1806CBD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x38970D0", Offset = "0x3895ED0", VA = "0x1838970D0")]
	public OHFHKIPINGN(Bounds HEJCIPIONHD, Vector2[] JJBMIAKPNFM, int ANHJMJFBOGC, byte HKPHMBLKPFI, float IKIIJCMDBLG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3896E70", Offset = "0x3895C70", VA = "0x183896E70")]
	public MHJBJPJHPFD HLCKAFHGBDM(byte EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3896FF0", Offset = "0x3895DF0", VA = "0x183896FF0")]
	public void NGKNKJMGCJO(Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE, ref List<byte> NPAGJNGHOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3896E50", Offset = "0x3895C50", VA = "0x183896E50")]
	public void GEPJEOGAEEH(MHJBJPJHPFD.HCMDPIPMANH KICELKEADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3896ED0", Offset = "0x3895CD0", VA = "0x183896ED0")]
	private MHJBJPJHPFD MOLJJAEIFLF(byte EFBDCIJMFGD, MHJBJPJHPFD.ENGKDHJBBKF OHEHDIDHCFP, MHJBJPJHPFD HICENEOPGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3896930", Offset = "0x3895730", VA = "0x183896930")]
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

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x38965E0", Offset = "0x38953E0", VA = "0x1838965E0")]
	public MHJBJPJHPFD(byte ENJEOLBEALP, ENGKDHJBBKF OHEHDIDHCFP, MHJBJPJHPFD HICENEOPGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x38962C0", Offset = "0x38950C0", VA = "0x1838962C0")]
	public void NBIOIKFGOLK(MHJBJPJHPFD MLDKMIGAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080")]
	public void GEPJEOGAEEH(int IDMAJACDJMF, HCMDPIPMANH KICELKEADCI, int NIIDNDCGMDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3896350", Offset = "0x3895150", VA = "0x183896350")]
	public void NGKNKJMGCJO(List<byte> NPAGJNGHOAE, Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3896220", Offset = "0x3895020", VA = "0x183896220")]
	public bool BJFFCFNIFNF(Vector3 KPLDEODOJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3896280", Offset = "0x3895080", VA = "0x183896280")]
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

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T FLAGPNDNLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1A85D20", Offset = "0x1A84B20", VA = "0x181A85D20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public T ENONEADFACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1A85CE0", Offset = "0x1A84AE0", VA = "0x181A85CE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public T IBDJAKGMLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1A858E0", Offset = "0x1A846E0", VA = "0x181A858E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1A85E90", Offset = "0x1A84C90", VA = "0x181A85E90")]
	public BEPMBLAHCML(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1A85AE0", Offset = "0x1A848E0", VA = "0x181A85AE0")]
	public void BPAJKKAGPKB(T LMJGGCEBDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1A85C30", Offset = "0x1A84A30", VA = "0x181A85C30")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1A85E40", Offset = "0x1A84C40", VA = "0x181A85E40")]
	public void OOAIDMBHDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x1A85C20", Offset = "0x1A84A20", VA = "0x181A85C20")]
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

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public virtual T FNCFALEFNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xD4E3D0", Offset = "0xD4D1D0", VA = "0x180D4E3D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1A86970", Offset = "0x1A85770", VA = "0x181A86970", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1A869D0", Offset = "0x1A857D0", VA = "0x181A869D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public object KJFJIIDJCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6400", Offset = "0x3F5200", VA = "0x1803F6400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x460F90", Offset = "0x45FD90", VA = "0x180460F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1A866D0", Offset = "0x1A854D0", VA = "0x181A866D0")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI, int JMHKMOACHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1A86A00", Offset = "0x1A85800", VA = "0x181A86A00")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1A86DB0", Offset = "0x1A85BB0", VA = "0x181A86DB0")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x1A87080", Offset = "0x1A85E80", VA = "0x181A87080")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x1A89E40", Offset = "0x1A88C40", VA = "0x181A89E40")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x1A8C0E0", Offset = "0x1A8AEE0", VA = "0x181A8C0E0")]
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

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float JABPFAJNKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7634E0", Offset = "0x7622E0", VA = "0x1807634E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x731040", Offset = "0x72FE40", VA = "0x180731040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3897A00", Offset = "0x3896800", VA = "0x183897A00")]
	public void DOEHAPOJMON(float ONGBFDACHHG, object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3897A70", Offset = "0x3896870", VA = "0x183897A70")]
	public void HAHBGOMEMEE(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x38978E0", Offset = "0x38966E0", VA = "0x1838978E0")]
	private void BHHBAENFOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3897AD0", Offset = "0x38968D0", VA = "0x183897AD0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
		private INIIDHCNCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3FFB80", Offset = "0x3FE980", VA = "0x1803FFB80")]
		public INIIDHCNCLK(string BIELLBOJOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x38961D0", Offset = "0x3894FD0", VA = "0x1838961D0", Slot = "3")]
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

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
		public HHHAHKJKNHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3895F80", Offset = "0x3894D80", VA = "0x183895F80")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly HashSet<object> BGKNMHEJLMM;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool CFLJGNJLBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3895120", Offset = "0x3893F20", VA = "0x183895120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3895010", Offset = "0x3893E10", VA = "0x183895010")]
	public void BPAJKKAGPKB(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3894FB0", Offset = "0x3893DB0", VA = "0x183894FB0")]
	public void BIHKNNPGGKP(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3895070", Offset = "0x3893E70", VA = "0x183895070")]
	public bool KCFPIEEMJON(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x38950D0", Offset = "0x3893ED0", VA = "0x1838950D0")]
	public void KFKPHICNHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3895160", Offset = "0x3893F60", VA = "0x183895160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38952C0", Offset = "0x38940C0", VA = "0x1838952C0")]
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

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T NKIEOKALHLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x924380", Offset = "0x923180", VA = "0x180924380", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1A86950", Offset = "0x1A85750", VA = "0x181A86950", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object GEDFELNLNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3FA180", Offset = "0x3F8F80", VA = "0x1803FA180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4437E0", Offset = "0x4425E0", VA = "0x1804437E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2504610", Offset = "0x2503410", VA = "0x182504610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2503F50", Offset = "0x2502D50", VA = "0x182503F50")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2504650", Offset = "0x2503450", VA = "0x182504650")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1A87080", Offset = "0x1A85E80", VA = "0x181A87080")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2504710", Offset = "0x2503510", VA = "0x182504710")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2505190", Offset = "0x2503F90", VA = "0x182505190")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2506670", Offset = "0x2505470", VA = "0x182506670")]
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
