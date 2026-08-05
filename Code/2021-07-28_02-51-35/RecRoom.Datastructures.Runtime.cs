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
	[Cpp2IlInjected.Address(RVA = "0x5C97F0", Offset = "0x5C85F0", VA = "0x1805C97F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F5530", Offset = "0x3F4330", VA = "0x1803F5530")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5323A0", Offset = "0x5311A0", VA = "0x1805323A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3F97F0", Offset = "0x3F85F0", VA = "0x1803F97F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0", Slot = "4")]
	public virtual void COBDCEFIEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CC9720", Offset = "0x2CC8520", VA = "0x182CC9720", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2CC9260", Offset = "0x2CC8060", VA = "0x182CC9260", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2CC9D20", Offset = "0x2CC8B20", VA = "0x182CC9D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
		public AEAKOHFPLFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28A39A0", Offset = "0x28A27A0", VA = "0x1828A39A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28A8610", Offset = "0x28A7410", VA = "0x1828A8610", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28A8640", Offset = "0x28A7440", VA = "0x1828A8640", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28A8560", Offset = "0x28A7360", VA = "0x1828A8560", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey DNGKIAJLLHG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28A85C0", Offset = "0x28A73C0", VA = "0x1828A85C0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28A8470", Offset = "0x28A7270", VA = "0x1828A8470", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28A7CE0", Offset = "0x28A6AE0", VA = "0x1828A7CE0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x28A7650", Offset = "0x28A6450", VA = "0x1828A7650", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28A72B0", Offset = "0x28A60B0", VA = "0x1828A72B0", Slot = "14")]
	protected virtual string LKCOLBMMLKA(TKeyVal GALGADHFCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x279EFC0", Offset = "0x279DDC0", VA = "0x18279EFC0", Slot = "4")]
	public bool ContainsKey(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x28A8370", Offset = "0x28A7170", VA = "0x1828A8370", Slot = "5")]
	public bool TryGetValue(TKey DNGKIAJLLHG, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x28A71C0", Offset = "0x28A5FC0", VA = "0x1828A71C0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x28A71C0", Offset = "0x28A5FC0", VA = "0x1828A71C0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x28A83A0", Offset = "0x28A71A0", VA = "0x1828A83A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x433040", Offset = "0x431E40", VA = "0x180433040")]
		[DebuggerHidden]
		public FIOCHCGPCBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x38AB120", Offset = "0x38A9F20", VA = "0x1838AB120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x38AAFD0", Offset = "0x38A9DD0", VA = "0x1838AAFD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x38AB190", Offset = "0x38A9F90", VA = "0x1838AB190")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38AB0D0", Offset = "0x38A9ED0", VA = "0x1838AB0D0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x38AB550", Offset = "0x38AA350", VA = "0x1838AB550")]
	public static void RegisterDontDestroyOnLoad(GameObject NNNMGKGMIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38AB370", Offset = "0x38AA170", VA = "0x1838AB370", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x38AB5F0", Offset = "0x38AA3F0", VA = "0x1838AB5F0")]
	[IteratorStateMachine(typeof(FIOCHCGPCBF))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0", Slot = "6")]
	protected virtual void BFNKJCLBGIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38AB6B0", Offset = "0x38AA4B0", VA = "0x1838AB6B0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CGINBDPPLIO
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x22D45B0", Offset = "0x22D33B0", VA = "0x1822D45B0")]
	public static void DFFNGCIAOME<T>(this T CKCMODJNCNF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x38AAD40", Offset = "0x38A9B40", VA = "0x1838AAD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x530AF0", Offset = "0x52F8F0", VA = "0x180530AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2DC0", Offset = "0x2AF1BC0", VA = "0x182AF2DC0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3290", Offset = "0x2AF2090", VA = "0x182AF3290", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x28A8670", Offset = "0x28A7470", VA = "0x1828A8670")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0C270", Offset = "0xD0B070", VA = "0x180D0C270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x38ABDC0", Offset = "0x38AABC0", VA = "0x1838ABDC0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38ABFE0", Offset = "0x38AADE0", VA = "0x1838ABFE0")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40CAD0", Offset = "0x40B8D0", VA = "0x18040CAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x530AF0", Offset = "0x52F8F0", VA = "0x180530AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool FFNIFALJLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2CCAC00", Offset = "0x2CC9A00", VA = "0x182CCAC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2CCA6C0", Offset = "0x2CC94C0", VA = "0x182CCA6C0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2CCAA40", Offset = "0x2CC9840", VA = "0x182CCAA40", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x28A8670", Offset = "0x28A7470", VA = "0x1828A8670")]
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
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
		public NMKBADGNEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4110", Offset = "0x2AF2F10", VA = "0x182AF4110")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AE6AC0", Offset = "0x2AE58C0", VA = "0x182AE6AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6F40", Offset = "0x2AE5D40", VA = "0x182AE6F40")]
	public HKMGKEPIIGN(float EBNPDDOHPII, float PDNBGEMGHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6BC0", Offset = "0x2AE59C0", VA = "0x182AE6BC0")]
	public bool NNLAEHCFGLO(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6760", Offset = "0x2AE5560", VA = "0x182AE6760")]
	public IEnumerable<T> BKGJKBJPEID(float MOPKOPOKKEE, [Optional] float? DJJCAALEIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6A90", Offset = "0x2AE5890", VA = "0x182AE6A90")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6E80", Offset = "0x2AE5C80", VA = "0x182AE6E80")]
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
		[Cpp2IlInjected.Address(RVA = "0x531B90", Offset = "0x530990", VA = "0x180531B90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x531C60", Offset = "0x530A60", VA = "0x180531C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x26C0170", Offset = "0x26BEF70", VA = "0x1826C0170")]
	public GMNJGMLCABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x26C01A0", Offset = "0x26BEFA0", VA = "0x1826C01A0")]
	public GMNJGMLCABC(int OJJOHDIFMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x26BF310", Offset = "0x26BE110", VA = "0x1826BF310")]
	public void BPAJKKAGPKB(float MOPKOPOKKEE, T ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x26BFBD0", Offset = "0x26BE9D0", VA = "0x1826BFBD0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x26BF6E0", Offset = "0x26BE4E0", VA = "0x1826BF6E0")]
	public bool IMMBIFHODMF(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x26BFA70", Offset = "0x26BE870", VA = "0x1826BFA70")]
	public bool KJPECKDEGGL(float JODPOANPJNK, float BCANLCHBKJE, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x26BFFD0", Offset = "0x26BEDD0", VA = "0x1826BFFD0")]
	public void OCCODBALDOD(float JODPOANPJNK, float BCANLCHBKJE, List<T> NKHPHBOPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x26BF890", Offset = "0x26BE690", VA = "0x1826BF890")]
	private int JDDBKHEGJHN(int NPDLAJLCALI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x26BF2D0", Offset = "0x26BE0D0", VA = "0x1826BF2D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x38AABD0", Offset = "0x38A99D0", VA = "0x1838AABD0", Slot = "4")]
	protected override Vector3 KPKMNLDBMEH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x38AAC40", Offset = "0x38A9A40", VA = "0x1838AAC40", Slot = "5")]
	protected override Vector3 PIFFNJDGHDE(Vector3 ONGBFDACHHG, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x38AAAB0", Offset = "0x38A98B0", VA = "0x1838AAAB0", Slot = "6")]
	protected override Vector3 CAPOCJJJJIB(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38AAB60", Offset = "0x38A9960", VA = "0x1838AAB60", Slot = "7")]
	protected override Vector3 JIODMOCKLKL(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38AACE0", Offset = "0x38A9AE0", VA = "0x1838AACE0")]
	public APDBOLKPCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DLPGJKJFNCM
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x221DE50", Offset = "0x221CC50", VA = "0x18221DE50")]
	public static global::DHKPBIAHMHG<T1, T2> NFHADFCEMML<T1, T2>(T1 OFCHPINAEEE, T2 NLNENAIDOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x221DEC0", Offset = "0x221CCC0", VA = "0x18221DEC0")]
	public static global::ELGBCKDBOED<T1, T2, T3> NFHADFCEMML<T1, T2, T3>(T1 OFCHPINAEEE, T2 NLNENAIDOJD, T3 FGPNPLGENDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xAE0300", Offset = "0xADF100", VA = "0x180AE0300")]
	internal static int FBNEHNPAJDI(int JGPNKFEDCDB, int EDGDLDGIIMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x10C5D00", Offset = "0x10C4B00", VA = "0x1810C5D00")]
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
	[Cpp2IlInjected.Address(RVA = "0x2344FE0", Offset = "0x2343DE0", VA = "0x182344FE0")]
	public DHKPBIAHMHG(T1 OFCHPINAEEE, T2 NLNENAIDOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3868CC0", Offset = "0x3867AC0", VA = "0x183868CC0", Slot = "4")]
	public int CompareTo(global::DHKPBIAHMHG<T1, T2> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3868D80", Offset = "0x3867B80", VA = "0x183868D80", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3868F30", Offset = "0x3867D30", VA = "0x183868F30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3869000", Offset = "0x3867E00", VA = "0x183869000", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2353420", Offset = "0x2352220", VA = "0x182353420")]
	public ELGBCKDBOED(T1 OFCHPINAEEE, T2 NLNENAIDOJD, T3 FGPNPLGENDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2352FB0", Offset = "0x2351DB0", VA = "0x182352FB0", Slot = "4")]
	public int CompareTo(global::ELGBCKDBOED<T1, T2, T3> HPKICPNGMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x23530B0", Offset = "0x2351EB0", VA = "0x1823530B0", Slot = "0")]
	public override bool Equals(object HPKICPNGMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2353220", Offset = "0x2352020", VA = "0x182353220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2353290", Offset = "0x2352090", VA = "0x182353290", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F97E0", Offset = "0x3F85E0", VA = "0x1803F97E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3F9830", Offset = "0x3F8630", VA = "0x1803F9830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float BPHIOMBNAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x513B00", Offset = "0x512900", VA = "0x180513B00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB960", Offset = "0x2DFA760", VA = "0x182DFB960")]
	public T DHEIFNLDBKN(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBC00", Offset = "0x2DFAA00", VA = "0x182DFBC00")]
	public T NICCICAFMDM(float LIMOILDIGKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ADPELJHGHKK(T LONDCJPNKKN, T PCEJJILDLGD, float LIMOILDIGKF);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x38AB250", Offset = "0x38AA050", VA = "0x1838AB250", Slot = "4")]
	protected override float ADPELJHGHKK(float LONDCJPNKKN, float PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x38AB2D0", Offset = "0x38AA0D0", VA = "0x1838AB2D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x38AD710", Offset = "0x38AC510", VA = "0x1838AD710", Slot = "4")]
	protected override Vector3 ADPELJHGHKK(Vector3 LONDCJPNKKN, Vector3 PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x38AD7D0", Offset = "0x38AC5D0", VA = "0x1838AD7D0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x122DBF0", Offset = "0x122C9F0", VA = "0x18122DBF0", Slot = "4")]
	protected override Color ADPELJHGHKK(Color LONDCJPNKKN, Color PCEJJILDLGD, float LIMOILDIGKF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x38AAF90", Offset = "0x38A9D90", VA = "0x1838AAF90")]
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
			[Cpp2IlInjected.Address(RVA = "0x531B90", Offset = "0x530990", VA = "0x180531B90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x26B9670", Offset = "0x26B8470", VA = "0x1826B9670", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x26B9A60", Offset = "0x26B8860", VA = "0x1826B9A60")]
		public Enumerator(global::GPFLNFOKEIA<T> NKHPHBOPPEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x26B8D00", Offset = "0x26B7B00", VA = "0x1826B8D00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x26B9480", Offset = "0x26B8280", VA = "0x1826B9480", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x26B91E0", Offset = "0x26B7FE0", VA = "0x1826B91E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x26C1490", Offset = "0x26C0290", VA = "0x1826C1490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x26C0D80", Offset = "0x26BFB80", VA = "0x1826C0D80")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x26C0BB0", Offset = "0x26BF9B0", VA = "0x1826C0BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x26C1A20", Offset = "0x26C0820", VA = "0x1826C1A20")]
	public GPFLNFOKEIA(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26C0830", Offset = "0x26BF630", VA = "0x1826C0830")]
	public void BPAJKKAGPKB(T LIMOILDIGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26C0EA0", Offset = "0x26BFCA0", VA = "0x1826C0EA0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26C0EC0", Offset = "0x26BFCC0", VA = "0x1826C0EC0")]
	public void NAJLLGFNIKC(int MNIJHBJDPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26C0F50", Offset = "0x26BFD50", VA = "0x1826C0F50")]
	public void NPAGGFDPFJK(T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x26C0AF0", Offset = "0x26BF8F0", VA = "0x1826C0AF0")]
	public Enumerator CINCGNABFNK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x26C1890", Offset = "0x26C0690", VA = "0x1826C1890", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x26C1890", Offset = "0x26C0690", VA = "0x1826C1890", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x26C15C0", Offset = "0x26C03C0", VA = "0x1826C15C0")]
	private int PLMBLHMDABK(int EFBDCIJMFGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26C0740", Offset = "0x26BF540", VA = "0x1826C0740")]
	private int BCDNPPPABOI(int EFBDCIJMFGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KBNAHLKGDBF
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F6370", Offset = "0x3F5170", VA = "0x1803F6370")]
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
		[Cpp2IlInjected.Address(RVA = "0x31459D0", Offset = "0x31447D0", VA = "0x1831459D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3145DA0", Offset = "0x3144BA0", VA = "0x183145DA0")]
	public PPKEKBLDDIK(int NPKCAEOBEMO, bool JNIOEAEOGFI, bool NOLKFLLKNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3145960", Offset = "0x3144760", VA = "0x183145960", Slot = "1")]
	~PPKEKBLDDIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x31458D0", Offset = "0x31446D0", VA = "0x1831458D0")]
	protected void FIAILKDOPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3145CC0", Offset = "0x3144AC0", VA = "0x183145CC0")]
	protected void NBBNPIGEGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3145B10", Offset = "0x3144910", VA = "0x183145B10")]
	protected void MPOMLFNCCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x31457B0", Offset = "0x31445B0", VA = "0x1831457B0", Slot = "4")]
	public void BPAJKKAGPKB(T JJGHIEJCCDA, bool GLAMKMBICFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3145690", Offset = "0x3144490", VA = "0x183145690", Slot = "5")]
	public void BIHKNNPGGKP(T JJGHIEJCCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3145A00", Offset = "0x3144800", VA = "0x183145A00")]
	public void LKLKGDMFMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OKNNKFGFODL : global::PPKEKBLDDIK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x38ACFC0", Offset = "0x38ABDC0", VA = "0x1838ACFC0")]
	public OKNNKFGFODL(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x38ACDB0", Offset = "0x38ABBB0", VA = "0x1838ACDB0")]
	public void CNFDGDEOPPF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x38ACD50", Offset = "0x38ABB50", VA = "0x1838ACD50")]
	public static OKNNKFGFODL BPJDFPACLMK(OKNNKFGFODL CMLAHPHDOHI, Action JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x38ACF60", Offset = "0x38ABD60", VA = "0x1838ACF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x234EF70", Offset = "0x234DD70", VA = "0x18234EF70")]
	public MFBGLIHGCGO(int NPKCAEOBEMO = 4, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x29EEFB0", Offset = "0x29EDDB0", VA = "0x1829EEFB0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x234E530", Offset = "0x234D330", VA = "0x18234E530")]
	public static global::MFBGLIHGCGO<T> BPJDFPACLMK(global::MFBGLIHGCGO<T> CMLAHPHDOHI, Action<T> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x234EED0", Offset = "0x234DCD0", VA = "0x18234EED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x234EF70", Offset = "0x234DD70", VA = "0x18234EF70")]
	public IILCGFIHJLP(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2AED5C0", Offset = "0x2AEC3C0", VA = "0x182AED5C0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x234E530", Offset = "0x234D330", VA = "0x18234E530")]
	public static global::IILCGFIHJLP<T, U> BPJDFPACLMK(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x234EED0", Offset = "0x234DCD0", VA = "0x18234EED0")]
	public static global::IILCGFIHJLP<T, U> GMNMHGMFGOL(global::IILCGFIHJLP<T, U> CMLAHPHDOHI, Action<T, U> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NBPOLJHGGLE<T, U, V> : global::PPKEKBLDDIK<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x234EF70", Offset = "0x234DD70", VA = "0x18234EF70")]
	public NBPOLJHGGLE(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x29F58B0", Offset = "0x29F46B0", VA = "0x1829F58B0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x234E530", Offset = "0x234D330", VA = "0x18234E530")]
	public static global::NBPOLJHGGLE<T, U, V> BPJDFPACLMK(global::NBPOLJHGGLE<T, U, V> CMLAHPHDOHI, Action<T, U, V> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x234EED0", Offset = "0x234DCD0", VA = "0x18234EED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x234EF70", Offset = "0x234DD70", VA = "0x18234EF70")]
	public AAPEGDHKHJI(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x25EEF60", Offset = "0x25EDD60", VA = "0x1825EEF60")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x234E530", Offset = "0x234D330", VA = "0x18234E530")]
	public static global::AAPEGDHKHJI<T, U, V, W> BPJDFPACLMK(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x234EED0", Offset = "0x234DCD0", VA = "0x18234EED0")]
	public static global::AAPEGDHKHJI<T, U, V, W> GMNMHGMFGOL(global::AAPEGDHKHJI<T, U, V, W> CMLAHPHDOHI, Action<T, U, V, W> JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EAHPNACBLDD<T, U, V, W, X> : global::PPKEKBLDDIK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x234EF70", Offset = "0x234DD70", VA = "0x18234EF70")]
	public EAHPNACBLDD(int NPKCAEOBEMO = 32, bool JNIOEAEOGFI = false, bool NOLKFLLKNOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x234E5D0", Offset = "0x234D3D0", VA = "0x18234E5D0")]
	public void CNFDGDEOPPF(T LIMOILDIGKF, U MGHEBJEJGJI, V DINHOLEGEMB, W AIKPCOLLNND, X NDILEEFABJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x234E530", Offset = "0x234D330", VA = "0x18234E530")]
	public static global::EAHPNACBLDD<T, U, V, W, X> BPJDFPACLMK(global::EAHPNACBLDD<T, U, V, W, X> CMLAHPHDOHI, Action<T, U, V, W, X> JJGHIEJCCDA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x234EED0", Offset = "0x234DCD0", VA = "0x18234EED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
		public IHHEENOOOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2354510", Offset = "0x2353310", VA = "0x182354510")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F1540", Offset = "0x4F0340", VA = "0x1804F1540")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2345690", Offset = "0x2344490", VA = "0x182345690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DGHLKNONJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x23455E0", Offset = "0x23443E0", VA = "0x1823455E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FKGBKNHFJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2345810", Offset = "0x2344610", VA = "0x182345810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::DJEFEGOJFPA<T> FFDEELPIEJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2345610", Offset = "0x2344410", VA = "0x182345610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x23475F0", Offset = "0x23463F0", VA = "0x1823475F0")]
	public DJEFEGOJFPA(T KEPEHMMFIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2345E20", Offset = "0x2344C20", VA = "0x182345E20")]
	public global::DJEFEGOJFPA<T> NBIOIKFGOLK(T BLEIKCEPEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2345F40", Offset = "0x2344D40", VA = "0x182345F40")]
	public global::DJEFEGOJFPA<T> NIHHKMAKGGP(T MJJAEOPELND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2345080", Offset = "0x2343E80", VA = "0x182345080")]
	public global::DJEFEGOJFPA<T> BIHKNNPGGKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2345AE0", Offset = "0x23448E0", VA = "0x182345AE0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2346A20", Offset = "0x2345820", VA = "0x182346A20")]
	public global::DJEFEGOJFPA<T> ONEGNLENCDK(T ICJLNPKIMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x23462D0", Offset = "0x23450D0", VA = "0x1823462D0")]
	public static void ONBECCDMLGM(global::DJEFEGOJFPA<T> MPGOABMOIAA, IJPAKLJLNOI BDNPNGGCFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x22D49B0", Offset = "0x22D37B0", VA = "0x1822D49B0")]
	public static void ONBECCDMLGM<A>(global::DJEFEGOJFPA<T> MPGOABMOIAA, Func<global::DJEFEGOJFPA<T>, A, bool> BDNPNGGCFPN, A OHFMPKJCLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2347050", Offset = "0x2345E50", VA = "0x182347050")]
	public static string PODKJCBOELP(global::DJEFEGOJFPA<T> MPGOABMOIAA, int MBLPPLGFEAE = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x23453C0", Offset = "0x23441C0", VA = "0x1823453C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F5530", Offset = "0x3F4330", VA = "0x1803F5530")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EBB40", Offset = "0x5EA940", VA = "0x1805EBB40")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x68F7C0", Offset = "0x68E5C0", VA = "0x18068F7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DBLCENPKMBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x5B6510", Offset = "0x5B5310", VA = "0x1805B6510")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x4AD5C0", Offset = "0x4AC3C0", VA = "0x1804AD5C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime JKNPCOLJCFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x3F97C0", Offset = "0x3F85C0", VA = "0x1803F97C0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3F9810", Offset = "0x3F8610", VA = "0x1803F9810")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2612870", Offset = "0x2611670", VA = "0x182612870")]
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
		[Cpp2IlInjected.Address(RVA = "0x40F830", Offset = "0x40E630", VA = "0x18040F830")]
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
		[Cpp2IlInjected.Address(RVA = "0x26102E0", Offset = "0x260F0E0", VA = "0x1826102E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int BIIJACLJEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5997E0", Offset = "0x5985E0", VA = "0x1805997E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x698F90", Offset = "0x697D90", VA = "0x180698F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey ACOEGFLBMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2610370", Offset = "0x260F170", VA = "0x182610370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2610FD0", Offset = "0x260FDD0", VA = "0x182610FD0")]
	public CPHIIFBLCDH(int NPKCAEOBEMO, [Optional] MPDHPMIIDDC OFPCFKKBIFN, [Optional] IEqualityComparer<TKey> HDCCPNMDACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x26112C0", Offset = "0x26100C0", VA = "0x1826112C0")]
	public CPHIIFBLCDH(int NPKCAEOBEMO, MPDHPMIIDDC OFPCFKKBIFN, TimeSpan CHAADHJMNPA, [Optional] IEqualityComparer<TKey> HDCCPNMDACM, [Optional] CJHBFCGNJFA MFMGHDDBPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x260FD70", Offset = "0x260EB70", VA = "0x18260FD70")]
	public void CHMGPFLMEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x260F9B0", Offset = "0x260E7B0", VA = "0x18260F9B0")]
	public void BDJFGEJFPPO(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x260FA70", Offset = "0x260E870", VA = "0x18260FA70")]
	public bool BIHKNNPGGKP(TKey DNGKIAJLLHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x26104F0", Offset = "0x260F2F0", VA = "0x1826104F0")]
	public bool IMCPFLDKEOH(TKey LFHKOFIPIEK, out TVal ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2610980", Offset = "0x260F780", VA = "0x182610980")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x260FBF0", Offset = "0x260E9F0", VA = "0x18260FBF0")]
	private bool CHGILPBCJJD(NAGHLDJNNAJ KNAIJICNDHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2610C80", Offset = "0x260FA80", VA = "0x182610C80")]
	private void NMABOMIEHEE(LinkedListNode<NAGHLDJNNAJ> CDGLMCIFCBO, TVal BCEFAKDFEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x26100D0", Offset = "0x260EED0", VA = "0x1826100D0")]
	private void DOEHAPOJMON(TKey DNGKIAJLLHG, TVal ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x26107E0", Offset = "0x260F5E0", VA = "0x1826107E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2559AF0", Offset = "0x25588F0", VA = "0x182559AF0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x38AD6E0", Offset = "0x38AC4E0", VA = "0x1838AD6E0")]
		public SerializedGuid(in Guid COFLAJFOPEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x38AD660", Offset = "0x38AC460", VA = "0x1838AD660")]
		public static SerializedGuid PECEFFJNJCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x38AD490", Offset = "0x38AC290", VA = "0x1838AD490")]
		public static SerializedGuid KEBCJKEKCLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x38AD510", Offset = "0x38AC310", VA = "0x1838AD510")]
		public bool MEBGJGNMIMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x38AD640", Offset = "0x38AC440", VA = "0x1838AD640", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x38AD5A0", Offset = "0x38AC3A0", VA = "0x1838AD5A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x38AD300", Offset = "0x38AC100", VA = "0x1838AD300", Slot = "7")]
		public bool Equals(SerializedGuid HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x38AD3A0", Offset = "0x38AC1A0", VA = "0x1838AD3A0", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x38AD480", Offset = "0x38AC280", VA = "0x1838AD480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x38AD2D0", Offset = "0x38AC0D0", VA = "0x1838AD2D0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x38AB310", Offset = "0x38AA110", VA = "0x1838AB310")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F97E0", Offset = "0x3F85E0", VA = "0x1803F97E0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x27AA610", Offset = "0x27A9410", VA = "0x1827AA610", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KOIKDFBKFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3FB650", Offset = "0x3FA450", VA = "0x1803FB650", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x27AA510", Offset = "0x27A9310", VA = "0x1827AA510")]
	private void CPDEMFAEBMA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x27AA590", Offset = "0x27A9390", VA = "0x1827AA590", Slot = "4")]
	public global::JDGADLJCIJC<T> LHHAHBBBDOA(Action<T> COCKCCFIFGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x27AA640", Offset = "0x27A9440", VA = "0x1827AA640", Slot = "5")]
	public global::JDGADLJCIJC<T> ONIEADDFNIG(Action<T> CIBJIOPEHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x27AA670", Offset = "0x27A9470", VA = "0x1827AA670")]
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
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
		public COCCCIAHGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3133450", Offset = "0x3132250", VA = "0x183133450")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x26314C0", Offset = "0x26302C0", VA = "0x1826314C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AB810", Offset = "0x38AA610", VA = "0x1838AB810")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AB7C0", Offset = "0x38AA5C0", VA = "0x1838AB7C0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x38AB900", Offset = "0x38AA700", VA = "0x1838AB900")]
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
		[Cpp2IlInjected.Address(RVA = "0x38AAE20", Offset = "0x38A9C20", VA = "0x1838AAE20")]
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
	[Cpp2IlInjected.Address(RVA = "0x3F6370", Offset = "0x3F5170", VA = "0x1803F6370")]
	protected CJHBFCGNJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class PIDMLFKAEJP : global::AFLBJKBIMFL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x38AD030", Offset = "0x38ABE30", VA = "0x1838AD030")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F5530", Offset = "0x3F4330", VA = "0x1803F5530", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x520A40", Offset = "0x51F840", VA = "0x180520A40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x520A70", Offset = "0x51F870", VA = "0x180520A70")]
	public AFLBJKBIMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F5530", Offset = "0x3F4330", VA = "0x1803F5530", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x520A40", Offset = "0x51F840", VA = "0x180520A40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x260F800", Offset = "0x260E600", VA = "0x18260F800")]
	public COOJEJBKMJN(Exception CHKKEHOKPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
		public IHHLCBAJHHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x26C2BD0", Offset = "0x26C19D0", VA = "0x1826C2BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F97B0", Offset = "0x3F85B0", VA = "0x1803F97B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public global::PMGCJEPKFOF<T> BGLLNLIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F5530", Offset = "0x3F4330", VA = "0x1803F5530", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private DABKFAIHBBP ADHPOMOAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3F5530", Offset = "0x3F4330", VA = "0x1803F5530", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x26C2340", Offset = "0x26C1140", VA = "0x1826C2340")]
	static GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x26C24B0", Offset = "0x26C12B0", VA = "0x1826C24B0")]
	protected GPMPDFCGLHC(TTask CFNPEPPKEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x26C1D30", Offset = "0x26C0B30", VA = "0x1826C1D30", Slot = "1")]
	~GPMPDFCGLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x26C1D00", Offset = "0x26C0B00", VA = "0x1826C1D00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x26C1EF0", Offset = "0x26C0CF0", VA = "0x1826C1EF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x26C1BF0", Offset = "0x26C09F0", VA = "0x1826C1BF0")]
	protected void COCHLMCDGCA(T AJNGCKJHBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x26C1E70", Offset = "0x26C0C70", VA = "0x1826C1E70")]
	protected void GGLDPDNDEHO(string MOPOMPHBHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x26C1B50", Offset = "0x26C0950", VA = "0x1826C1B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x2355720", Offset = "0x2354520", VA = "0x182355720", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public KANNECPCOLP KAFEDPEFLOI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2355790", Offset = "0x2354590", VA = "0x182355790", Slot = "4")]
			get
			{
				return default(KANNECPCOLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x491160", Offset = "0x48FF60", VA = "0x180491160")]
		public KCNNGNNFBDL(global::EFHMLIMBKPE<T> FLLHBFDLKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2355690", Offset = "0x2354490", VA = "0x182355690", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x491150", Offset = "0x48FF50", VA = "0x180491150", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x624DE0", Offset = "0x623BE0", VA = "0x180624DE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F22950", Offset = "0x1F21750", VA = "0x181F22950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x23508D0", Offset = "0x234F6D0", VA = "0x1823508D0")]
	public static global::EFHMLIMBKPE<T> OGGMCNEPMDA(KANNECPCOLP[] PPCOBBGKGCP, bool DBGPHICABDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2350D00", Offset = "0x234FB00", VA = "0x182350D00")]
	public EFHMLIMBKPE(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2350880", Offset = "0x234F680", VA = "0x182350880")]
	public int KNHMLMKIOCH(T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x23505D0", Offset = "0x234F3D0", VA = "0x1823505D0")]
	public T DDGIPHJPODB(int EFBDCIJMFGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2350810", Offset = "0x234F610", VA = "0x182350810")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2350640", Offset = "0x234F440", VA = "0x182350640")]
	public bool JPIFKHDPKLD(T ONGBFDACHHG, int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2350490", Offset = "0x234F290", VA = "0x182350490")]
	public KANNECPCOLP[] CAPGKOJNBIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2350830", Offset = "0x234F630", VA = "0x182350830")]
	private int KJMAGDFHGOD(int HKPHMBLKPFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2350C90", Offset = "0x234FA90", VA = "0x182350C90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2350C90", Offset = "0x234FA90", VA = "0x182350C90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x24B9FA0", Offset = "0x24B8DA0", VA = "0x1824B9FA0")]
	public BDMFLDBGOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x24B9FD0", Offset = "0x24B8DD0", VA = "0x1824B9FD0")]
	public BDMFLDBGOFG(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x24B9EA0", Offset = "0x24B8CA0", VA = "0x1824B9EA0")]
	public T OBCMOHDGJNN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x24B9D80", Offset = "0x24B8B80", VA = "0x1824B9D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F22920", Offset = "0x1F21720", VA = "0x181F22920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x27A23A0", Offset = "0x27A11A0", VA = "0x1827A23A0")]
	public bool KCFPIEEMJON(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x27A2290", Offset = "0x27A1090", VA = "0x1827A2290")]
	public void BPAJKKAGPKB(T ONGBFDACHHG, int JMHKMOACHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x27A2170", Offset = "0x27A0F70", VA = "0x1827A2170")]
	public bool BIHKNNPGGKP(T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x27A25F0", Offset = "0x27A13F0", VA = "0x1827A25F0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x27A2310", Offset = "0x27A1110", VA = "0x1827A2310")]
	public T HMBMDDOFIKL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x27A1F60", Offset = "0x27A0D60", VA = "0x1827A1F60")]
	private void ABKEBNFHIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x27A2650", Offset = "0x27A1450", VA = "0x1827A2650")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C75D0", Offset = "0x28C63D0", VA = "0x1828C75D0", Slot = "4")]
		public virtual T EDMOPEPBEHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5240F0", Offset = "0x522EF0", VA = "0x1805240F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F5530", Offset = "0x3F4330", VA = "0x1803F5530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3F9800", Offset = "0x3F8600", VA = "0x1803F9800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Vector2 JKPGFDOGKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9F8BE0", Offset = "0x9F79E0", VA = "0x1809F8BE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x10B3FE0", Offset = "0x10B2DE0", VA = "0x1810B3FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private Vector2 JECNPCKFHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x764620", Offset = "0x763420", VA = "0x180764620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Vector2 KIBOLBPKFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xD78720", Offset = "0xD77520", VA = "0x180D78720")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xD78740", Offset = "0xD77540", VA = "0x180D78740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int BPOLFMEDCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4097C0", Offset = "0x4085C0", VA = "0x1804097C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4098B0", Offset = "0x4086B0", VA = "0x1804098B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x38AC860", Offset = "0x38AB660", VA = "0x1838AC860")]
	public OHFHKIPINGN(Bounds HEJCIPIONHD, Vector2[] JJBMIAKPNFM, int ANHJMJFBOGC, byte HKPHMBLKPFI, float IKIIJCMDBLG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x38AC600", Offset = "0x38AB400", VA = "0x1838AC600")]
	public MHJBJPJHPFD HLCKAFHGBDM(byte EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x38AC780", Offset = "0x38AB580", VA = "0x1838AC780")]
	public void NGKNKJMGCJO(Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE, ref List<byte> NPAGJNGHOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x38AC5E0", Offset = "0x38AB3E0", VA = "0x1838AC5E0")]
	public void GEPJEOGAEEH(MHJBJPJHPFD.HCMDPIPMANH KICELKEADCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x38AC660", Offset = "0x38AB460", VA = "0x1838AC660")]
	private MHJBJPJHPFD MOLJJAEIFLF(byte EFBDCIJMFGD, MHJBJPJHPFD.ENGKDHJBBKF OHEHDIDHCFP, MHJBJPJHPFD HICENEOPGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x38AC0C0", Offset = "0x38AAEC0", VA = "0x1838AC0C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x38ABD70", Offset = "0x38AAB70", VA = "0x1838ABD70")]
	public MHJBJPJHPFD(byte ENJEOLBEALP, ENGKDHJBBKF OHEHDIDHCFP, MHJBJPJHPFD HICENEOPGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x38ABA50", Offset = "0x38AA850", VA = "0x1838ABA50")]
	public void NBIOIKFGOLK(MHJBJPJHPFD MLDKMIGAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0")]
	public void GEPJEOGAEEH(int IDMAJACDJMF, HCMDPIPMANH KICELKEADCI, int NIIDNDCGMDD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x38ABAE0", Offset = "0x38AA8E0", VA = "0x1838ABAE0")]
	public void NGKNKJMGCJO(List<byte> NPAGJNGHOAE, Vector3 DDHPAFKBMON, float IBCLLOOMPLJ, float KCCKPCDDFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x38AB9B0", Offset = "0x38AA7B0", VA = "0x1838AB9B0")]
	public bool BJFFCFNIFNF(Vector3 KPLDEODOJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x38ABA10", Offset = "0x38AA810", VA = "0x1838ABA10")]
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
		[Cpp2IlInjected.Address(RVA = "0x24BBC60", Offset = "0x24BAA60", VA = "0x1824BBC60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public T ENONEADFACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x24BBC20", Offset = "0x24BAA20", VA = "0x1824BBC20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public T IBDJAKGMLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x24BB820", Offset = "0x24BA620", VA = "0x1824BB820")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x24BBDD0", Offset = "0x24BABD0", VA = "0x1824BBDD0")]
	public BEPMBLAHCML(int NPKCAEOBEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x24BBA20", Offset = "0x24BA820", VA = "0x1824BBA20")]
	public void BPAJKKAGPKB(T LMJGGCEBDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x24BBB70", Offset = "0x24BA970", VA = "0x1824BBB70")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x24BBD80", Offset = "0x24BAB80", VA = "0x1824BBD80")]
	public void OOAIDMBHDKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x24BBB60", Offset = "0x24BA960", VA = "0x1824BBB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F8BE0", Offset = "0x9F79E0", VA = "0x1809F8BE0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x10B3FE0", Offset = "0x10B2DE0", VA = "0x1810B3FE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x24BC8F0", Offset = "0x24BB6F0", VA = "0x1824BC8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public object KJFJIIDJCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3F97C0", Offset = "0x3F85C0", VA = "0x1803F97C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3F9810", Offset = "0x3F8610", VA = "0x1803F9810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x24BC610", Offset = "0x24BB410", VA = "0x1824BC610")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI, int JMHKMOACHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x24BC920", Offset = "0x24BB720", VA = "0x1824BC920")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x24BCCD0", Offset = "0x24BBAD0", VA = "0x1824BCCD0")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x24BCFA0", Offset = "0x24BBDA0", VA = "0x1824BCFA0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x24BFD60", Offset = "0x24BEB60", VA = "0x1824BFD60")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x24C2000", Offset = "0x24C0E00", VA = "0x1824C2000")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FD6B0", Offset = "0x6FC4B0", VA = "0x1806FD6B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6D0", Offset = "0x6FC4D0", VA = "0x1806FD6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x38AD190", Offset = "0x38ABF90", VA = "0x1838AD190")]
	public void DOEHAPOJMON(float ONGBFDACHHG, object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x38AD200", Offset = "0x38AC000", VA = "0x1838AD200")]
	public void HAHBGOMEMEE(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x38AD070", Offset = "0x38ABE70", VA = "0x1838AD070")]
	private void BHHBAENFOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x38AD260", Offset = "0x38AC060", VA = "0x1838AD260")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F6370", Offset = "0x3F5170", VA = "0x1803F6370")]
		private INIIDHCNCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x44F250", Offset = "0x44E050", VA = "0x18044F250")]
		public INIIDHCNCLK(string BIELLBOJOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x38AB960", Offset = "0x38AA760", VA = "0x1838AB960", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F6370", Offset = "0x3F5170", VA = "0x1803F6370")]
		public HHHAHKJKNHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x38AB710", Offset = "0x38AA510", VA = "0x1838AB710")]
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
		[Cpp2IlInjected.Address(RVA = "0x38AA8B0", Offset = "0x38A96B0", VA = "0x1838AA8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x38AA7A0", Offset = "0x38A95A0", VA = "0x1838AA7A0")]
	public void BPAJKKAGPKB(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x38AA740", Offset = "0x38A9540", VA = "0x1838AA740")]
	public void BIHKNNPGGKP(object PIHIPPPPEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x38AA800", Offset = "0x38A9600", VA = "0x1838AA800")]
	public bool KCFPIEEMJON(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x38AA860", Offset = "0x38A9660", VA = "0x1838AA860")]
	public void KFKPHICNHEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x38AA8F0", Offset = "0x38A96F0", VA = "0x1838AA8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38AAA50", Offset = "0x38A9850", VA = "0x1838AAA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1362130", Offset = "0x1360F30", VA = "0x181362130", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x24BC890", Offset = "0x24BB690", VA = "0x1824BC890", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object GEDFELNLNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3F97E0", Offset = "0x3F85E0", VA = "0x1803F97E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F9830", Offset = "0x3F8630", VA = "0x1803F9830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool HFHFEJMMDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2AE3AB0", Offset = "0x2AE28B0", VA = "0x182AE3AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE33F0", Offset = "0x2AE21F0", VA = "0x182AE33F0")]
	public bool DOEHAPOJMON(T ONGBFDACHHG, object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3AF0", Offset = "0x2AE28F0", VA = "0x182AE3AF0")]
	public bool HAHBGOMEMEE(object PIHIPPPPEBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x24BCFA0", Offset = "0x24BBDA0", VA = "0x1824BCFA0")]
	public void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3BB0", Offset = "0x2AE29B0", VA = "0x182AE3BB0")]
	public bool IMCPFLDKEOH(object PIHIPPPPEBI, out T ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2AE4630", Offset = "0x2AE3430", VA = "0x182AE4630")]
	private bool NIOBILHPMFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5B10", Offset = "0x2AE4910", VA = "0x182AE5B10")]
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
