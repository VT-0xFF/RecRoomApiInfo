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
	[Cpp2IlInjected.Address(RVA = "0x50EC10", Offset = "0x50DE10", VA = "0x18050EC10")]
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
	[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2FFB430", Offset = "0x2FFA630", VA = "0x182FFB430", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FFAF70", Offset = "0x2FFA170", VA = "0x182FFAF70", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2FFBA30", Offset = "0x2FFAC30", VA = "0x182FFBA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
		public JNAODEILDKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1EB4E70", Offset = "0x1EB4070", VA = "0x181EB4E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1EB37D0", Offset = "0x1EB29D0", VA = "0x181EB37D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3800", Offset = "0x1EB2A00", VA = "0x181EB3800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3720", Offset = "0x1EB2920", VA = "0x181EB3720", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey KPLFFOGJEBN]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3750", Offset = "0x1EB2950", VA = "0x181EB3750", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3630", Offset = "0x1EB2830", VA = "0x181EB3630", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2EA0", Offset = "0x1EB20A0", VA = "0x181EB2EA0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2810", Offset = "0x1EB1A10", VA = "0x181EB2810", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2410", Offset = "0x1EB1610", VA = "0x181EB2410", Slot = "14")]
	protected virtual string MEOBPCINACO(TKeyVal OMCDBPNABIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2350", Offset = "0x1EB1550", VA = "0x181EB2350", Slot = "4")]
	public bool ContainsKey(TKey KPLFFOGJEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3530", Offset = "0x1EB2730", VA = "0x181EB3530", Slot = "5")]
	public bool TryGetValue(TKey KPLFFOGJEBN, out TVal DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2380", Offset = "0x1EB1580", VA = "0x181EB2380", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1EB2380", Offset = "0x1EB1580", VA = "0x181EB2380", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3560", Offset = "0x1EB2760", VA = "0x181EB3560")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ADC80", Offset = "0x5ACE80", VA = "0x1805ADC80")]
		[DebuggerHidden]
		public HNJLNAIDHHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x408D1E0", Offset = "0x408C3E0", VA = "0x18408D1E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x408D090", Offset = "0x408C290", VA = "0x18408D090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x408D250", Offset = "0x408C450", VA = "0x18408D250")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x408D190", Offset = "0x408C390", VA = "0x18408D190", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x408CE20", Offset = "0x408C020", VA = "0x18408CE20")]
	public static void RegisterDontDestroyOnLoad(GameObject AAHEJJAIDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x408CEC0", Offset = "0x408C0C0", VA = "0x18408CEC0")]
	public static void RegisterHideFlagsDontSaveObejct(UnityEngine.Object LBCPAPMBFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x408CAD0", Offset = "0x408BCD0", VA = "0x18408CAD0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x408CF40", Offset = "0x408C140", VA = "0x18408CF40")]
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
	[Cpp2IlInjected.Address(RVA = "0x408D030", Offset = "0x408C230", VA = "0x18408D030")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GJFOOIFOIIM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1E05430", Offset = "0x1E04630", VA = "0x181E05430")]
	public static void KDIFMLHGFNA<T>(this T JOKPACJLGPE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x408C9A0", Offset = "0x408BBA0", VA = "0x18408C9A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF27C0", Offset = "0xAF19C0", VA = "0x180AF27C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2D6E550", Offset = "0x2D6D750", VA = "0x182D6E550", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2D6EA20", Offset = "0x2D6DC20", VA = "0x182D6EA20", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3830", Offset = "0x1EB2A30", VA = "0x181EB3830")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AE0", Offset = "0xD33CE0", VA = "0x180D34AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x408DDB0", Offset = "0x408CFB0", VA = "0x18408DDB0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x408DFD0", Offset = "0x408D1D0", VA = "0x18408DFD0")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xACA3F0", Offset = "0xAC95F0", VA = "0x180ACA3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF27C0", Offset = "0xAF19C0", VA = "0x180AF27C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool GBGNMJCIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC910", Offset = "0x2FFBB10", VA = "0x182FFC910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC3D0", Offset = "0x2FFB5D0", VA = "0x182FFC3D0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC750", Offset = "0x2FFB950", VA = "0x182FFC750", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3830", Offset = "0x1EB2A30", VA = "0x181EB3830")]
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
		[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
		public LKMJDFFDIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3623230", Offset = "0x3622430", VA = "0x183623230")]
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
		[Cpp2IlInjected.Address(RVA = "0x36208A0", Offset = "0x361FAA0", VA = "0x1836208A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3621040", Offset = "0x3620240", VA = "0x183621040")]
	public IKLNBNBEHIK(float FHAMBIHJFMD, float APLDBEKKOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36206C0", Offset = "0x361F8C0", VA = "0x1836206C0")]
	public bool JBNACOJAJGJ(float NKHOKGGOHMI, T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3620C50", Offset = "0x361FE50", VA = "0x183620C50")]
	public IEnumerable<T> LDOJDIFHLAK(float NKHOKGGOHMI, [Optional] float? BMNENLFEJCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3620530", Offset = "0x361F730", VA = "0x183620530")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3620F80", Offset = "0x3620180", VA = "0x183620F80")]
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
		[Cpp2IlInjected.Address(RVA = "0xBB0860", Offset = "0xBAFA60", VA = "0x180BB0860")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xC29CC0", Offset = "0xC28EC0", VA = "0x180C29CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x29645E0", Offset = "0x29637E0", VA = "0x1829645E0")]
	public FJJNGGDCDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2964510", Offset = "0x2963710", VA = "0x182964510")]
	public FJJNGGDCDEL(int LMCPNDFGEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x29643F0", Offset = "0x29635F0", VA = "0x1829643F0")]
	public void OAGNENAKIKD(float NKHOKGGOHMI, T DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2963BC0", Offset = "0x2962DC0", VA = "0x182963BC0")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29638C0", Offset = "0x2962AC0", VA = "0x1829638C0")]
	public bool DCLJLJHIHFM(float NPMPGFDNGOJ, float KHFHIBDLKNJ, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2964000", Offset = "0x2963200", VA = "0x182964000")]
	public bool NPFOIMIKHLE(float NPMPGFDNGOJ, float KHFHIBDLKNJ, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2963D10", Offset = "0x2962F10", VA = "0x182963D10")]
	public void FIPJKCLBHPE(float NPMPGFDNGOJ, float KHFHIBDLKNJ, List<T> MMHBGLAEGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2963670", Offset = "0x2962870", VA = "0x182963670")]
	private int BDIIKLJGEPA(int PCKMBBPGBHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2963FC0", Offset = "0x29631C0", VA = "0x182963FC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x408C710", Offset = "0x408B910", VA = "0x18408C710", Slot = "4")]
	protected override Vector3 BLPHPHFDKAP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x408C830", Offset = "0x408BA30", VA = "0x18408C830", Slot = "5")]
	protected override Vector3 IEJLIGOLGLB(Vector3 DIDEMEECIEC, float EAJMLGJNCKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x408C780", Offset = "0x408B980", VA = "0x18408C780", Slot = "6")]
	protected override Vector3 FEMMHAALNND(Vector3 GEDCCIPGINO, Vector3 HBHGMAMLFGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x408C8D0", Offset = "0x408BAD0", VA = "0x18408C8D0", Slot = "7")]
	protected override Vector3 PKGAOFIMBPJ(Vector3 GEDCCIPGINO, Vector3 HBHGMAMLFGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x408C940", Offset = "0x408BB40", VA = "0x18408C940")]
	public GCMCGCHFLOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JPIAGLCOGNJ
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1D6DE20", Offset = "0x1D6D020", VA = "0x181D6DE20")]
	public static global::AOFBLJDNDEO<T1, T2> BAHAJJMALOP<T1, T2>(T1 CGJJGNKDFMD, T2 MLBFPNHBDFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x22A76E0", Offset = "0x22A68E0", VA = "0x1822A76E0")]
	public static global::KIFDKCKPDCM<T1, T2, T3> BAHAJJMALOP<T1, T2, T3>(T1 CGJJGNKDFMD, T2 MLBFPNHBDFF, T3 PDGHFNOBNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x937D30", Offset = "0x936F30", VA = "0x180937D30")]
	internal static int CEGDPFANOAG(int DDAPFLADAMO, int GHNPMJAILAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x937D40", Offset = "0x936F40", VA = "0x180937D40")]
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
	[Cpp2IlInjected.Address(RVA = "0x248CE10", Offset = "0x248C010", VA = "0x18248CE10")]
	public AOFBLJDNDEO(T1 CGJJGNKDFMD, T2 MLBFPNHBDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x248B830", Offset = "0x248AA30", VA = "0x18248B830", Slot = "4")]
	public int CompareTo(global::AOFBLJDNDEO<T1, T2> JJPLNCEMCNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x248BFB0", Offset = "0x248B1B0", VA = "0x18248BFB0", Slot = "0")]
	public override bool Equals(object JJPLNCEMCNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x248C270", Offset = "0x248B470", VA = "0x18248C270", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x248C900", Offset = "0x248BB00", VA = "0x18248C900", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CE3930", Offset = "0x1CE2B30", VA = "0x181CE3930")]
	public KIFDKCKPDCM(T1 CGJJGNKDFMD, T2 MLBFPNHBDFF, T3 PDGHFNOBNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3150", Offset = "0x1CE2350", VA = "0x181CE3150", Slot = "4")]
	public int CompareTo(global::KIFDKCKPDCM<T1, T2, T3> JJPLNCEMCNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3440", Offset = "0x1CE2640", VA = "0x181CE3440", Slot = "0")]
	public override bool Equals(object JJPLNCEMCNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1CE35B0", Offset = "0x1CE27B0", VA = "0x181CE35B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1CE36B0", Offset = "0x1CE28B0", VA = "0x181CE36B0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E4620", Offset = "0x4E3820", VA = "0x1804E4620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float PMIEBFEGJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xCC6600", Offset = "0xCC5800", VA = "0x180CC6600")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34CB510", Offset = "0x34CA710", VA = "0x1834CB510")]
	public T LJGEHOGMNCF(float EAJMLGJNCKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x34CB270", Offset = "0x34CA470", VA = "0x1834CB270")]
	public T BHKDLDOKNNI(float EAJMLGJNCKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EBMJHDBFACJ(T GEDCCIPGINO, T HBHGMAMLFGI, float EAJMLGJNCKN);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x408C650", Offset = "0x408B850", VA = "0x18408C650", Slot = "4")]
	protected override float EBMJHDBFACJ(float GEDCCIPGINO, float HBHGMAMLFGI, float EAJMLGJNCKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x408C6D0", Offset = "0x408B8D0", VA = "0x18408C6D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x408F800", Offset = "0x408EA00", VA = "0x18408F800", Slot = "4")]
	protected override Vector3 EBMJHDBFACJ(Vector3 GEDCCIPGINO, Vector3 HBHGMAMLFGI, float EAJMLGJNCKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x408F8C0", Offset = "0x408EAC0", VA = "0x18408F8C0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x40764B0", Offset = "0x40756B0", VA = "0x1840764B0", Slot = "4")]
	protected override Color EBMJHDBFACJ(Color GEDCCIPGINO, Color HBHGMAMLFGI, float EAJMLGJNCKN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x408C610", Offset = "0x408B810", VA = "0x18408C610")]
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
			[Cpp2IlInjected.Address(RVA = "0xBB0860", Offset = "0xBAFA60", VA = "0x180BB0860", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x28744A0", Offset = "0x28736A0", VA = "0x1828744A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28745B0", Offset = "0x28737B0", VA = "0x1828745B0")]
		public Enumerator(global::HPMODOKJBAP<T> MMHBGLAEGGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2874320", Offset = "0x2873520", VA = "0x182874320", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2874450", Offset = "0x2873650", VA = "0x182874450", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28742A0", Offset = "0x28734A0", VA = "0x1828742A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3617980", Offset = "0x3616B80", VA = "0x183617980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T PHLIBLBIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3617AF0", Offset = "0x3616CF0", VA = "0x183617AF0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3617240", Offset = "0x3616440", VA = "0x183617240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x36183F0", Offset = "0x36175F0", VA = "0x1836183F0")]
	public HPMODOKJBAP(int PLJFHAMCAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3617D70", Offset = "0x3616F70", VA = "0x183617D70")]
	public void OAGNENAKIKD(T EAJMLGJNCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x36172B0", Offset = "0x36164B0", VA = "0x1836172B0")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3617040", Offset = "0x3616240", VA = "0x183617040")]
	public void DIIJPBGJCHO(int CLGAFDJGDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3617590", Offset = "0x3616790", VA = "0x183617590")]
	public void ICEMKAABKIJ(T[] OBEKMDCFBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3617370", Offset = "0x3616570", VA = "0x183617370")]
	public Enumerator GINCIBHFNPP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3618260", Offset = "0x3617460", VA = "0x183618260", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3618260", Offset = "0x3617460", VA = "0x183618260", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3618000", Offset = "0x3617200", VA = "0x183618000")]
	private int OMPOBGGABCI(int DLGFKHPJLDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3617410", Offset = "0x3616610", VA = "0x183617410")]
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
		[Cpp2IlInjected.Address(RVA = "0x37C0320", Offset = "0x37BF520", VA = "0x1837C0320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37C0360", Offset = "0x37BF560", VA = "0x1837C0360")]
	protected OGDDBKOGOHK(bool HLPHPKGJJAM, bool JJBAGMMPCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37BFF80", Offset = "0x37BF180", VA = "0x1837BFF80")]
	protected bool FBIAKOHGPMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37BFD70", Offset = "0x37BEF70", VA = "0x1837BFD70")]
	protected void EDFJDFBGMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37C0020", Offset = "0x37BF220", VA = "0x1837C0020")]
	protected void IDGABLINANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0E1D0", Offset = "0x1E0D3D0", VA = "0x181E0E1D0")]
	private static void OFPKMDIDHLD<U>(ref List<U> AAMGMIAPLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x37C01D0", Offset = "0x37BF3D0", VA = "0x1837C01D0", Slot = "4")]
	public void OAGNENAKIKD(T HIOFDPALGPA, bool BFICEJFJOHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x37BFC30", Offset = "0x37BEE30", VA = "0x1837BFC30", Slot = "5")]
	public void ANHDIGNDBJL(T HIOFDPALGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x37BFE50", Offset = "0x37BF050", VA = "0x1837BFE50")]
	public void EGONGNAPLEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OCNAHFDBONF : global::OGDDBKOGOHK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x408E320", Offset = "0x408D520", VA = "0x18408E320")]
	public OCNAHFDBONF(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x408E170", Offset = "0x408D370", VA = "0x18408E170")]
	public void OPBHMBDEFOF()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x408E110", Offset = "0x408D310", VA = "0x18408E110")]
	public static OCNAHFDBONF LJIBPGIACAP(OCNAHFDBONF LPFHPJDOJGE, Action HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x408E0B0", Offset = "0x408D2B0", VA = "0x18408E0B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2078060", Offset = "0x2077260", VA = "0x182078060")]
	public BELDOFNFAOO(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x27942E0", Offset = "0x27934E0", VA = "0x1827942E0")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x20779A0", Offset = "0x2076BA0", VA = "0x1820779A0")]
	public static global::BELDOFNFAOO<T> LJIBPGIACAP(global::BELDOFNFAOO<T> LPFHPJDOJGE, Action<T> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2077900", Offset = "0x2076B00", VA = "0x182077900")]
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
	[Cpp2IlInjected.Address(RVA = "0x2078060", Offset = "0x2077260", VA = "0x182078060")]
	public JCOEEDKDIHM(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D727B0", Offset = "0x2D719B0", VA = "0x182D727B0")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x20779A0", Offset = "0x2076BA0", VA = "0x1820779A0")]
	public static global::JCOEEDKDIHM<T, U> LJIBPGIACAP(global::JCOEEDKDIHM<T, U> LPFHPJDOJGE, Action<T, U> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2077900", Offset = "0x2076B00", VA = "0x182077900")]
	public static global::JCOEEDKDIHM<T, U> CHACNKPMFNC(global::JCOEEDKDIHM<T, U> LPFHPJDOJGE, Action<T, U> HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DIMAOPNHCAH<T, U, V> : global::OGDDBKOGOHK<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2078060", Offset = "0x2077260", VA = "0x182078060")]
	public DIMAOPNHCAH(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x29912A0", Offset = "0x29904A0", VA = "0x1829912A0")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN, V HANBAFFFIKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x20779A0", Offset = "0x2076BA0", VA = "0x1820779A0")]
	public static global::DIMAOPNHCAH<T, U, V> LJIBPGIACAP(global::DIMAOPNHCAH<T, U, V> LPFHPJDOJGE, Action<T, U, V> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2077900", Offset = "0x2076B00", VA = "0x182077900")]
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
	[Cpp2IlInjected.Address(RVA = "0x2078060", Offset = "0x2077260", VA = "0x182078060")]
	public MLJGELKBOMA(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22D90D0", Offset = "0x22D82D0", VA = "0x1822D90D0")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN, V HANBAFFFIKF, W FBKNPHALAHG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x20779A0", Offset = "0x2076BA0", VA = "0x1820779A0")]
	public static global::MLJGELKBOMA<T, U, V, W> LJIBPGIACAP(global::MLJGELKBOMA<T, U, V, W> LPFHPJDOJGE, Action<T, U, V, W> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2077900", Offset = "0x2076B00", VA = "0x182077900")]
	public static global::MLJGELKBOMA<T, U, V, W> CHACNKPMFNC(global::MLJGELKBOMA<T, U, V, W> LPFHPJDOJGE, Action<T, U, V, W> HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class COHKENHLIMP<T, U, V, W, X> : global::OGDDBKOGOHK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2078060", Offset = "0x2077260", VA = "0x182078060")]
	public COHKENHLIMP(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B570", Offset = "0x2B1A770", VA = "0x182B1B570")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN, V HANBAFFFIKF, W FBKNPHALAHG, X ICGPCBEABPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x20779A0", Offset = "0x2076BA0", VA = "0x1820779A0")]
	public static global::COHKENHLIMP<T, U, V, W, X> LJIBPGIACAP(global::COHKENHLIMP<T, U, V, W, X> LPFHPJDOJGE, Action<T, U, V, W, X> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2077900", Offset = "0x2076B00", VA = "0x182077900")]
	public static global::COHKENHLIMP<T, U, V, W, X> CHACNKPMFNC(global::COHKENHLIMP<T, U, V, W, X> LPFHPJDOJGE, Action<T, U, V, W, X> HIOFDPALGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class MDBFOHODFCJ<T, U, V, W, X, Y> : global::OGDDBKOGOHK<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2078060", Offset = "0x2077260", VA = "0x182078060")]
	public MDBFOHODFCJ(bool HLPHPKGJJAM = false, bool JJBAGMMPCHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2077A40", Offset = "0x2076C40", VA = "0x182077A40")]
	public void OPBHMBDEFOF(T EAJMLGJNCKN, U OPHHHCDIEDN, V HANBAFFFIKF, W FBKNPHALAHG, X ICGPCBEABPG, Y DBMFKAAHNFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x20779A0", Offset = "0x2076BA0", VA = "0x1820779A0")]
	public static global::MDBFOHODFCJ<T, U, V, W, X, Y> LJIBPGIACAP(global::MDBFOHODFCJ<T, U, V, W, X, Y> LPFHPJDOJGE, Action<T, U, V, W, X, Y> HIOFDPALGPA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2077900", Offset = "0x2076B00", VA = "0x182077900")]
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
		[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
		public AJINKGEIBGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3090", Offset = "0x1EA2290", VA = "0x181EA3090")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A5D30", Offset = "0x4A4F30", VA = "0x1804A5D30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1EAE3A0", Offset = "0x1EAD5A0", VA = "0x181EAE3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CJIBNPMIMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1EAD060", Offset = "0x1EAC260", VA = "0x181EAD060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LGJNJNMDEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1EAD0D0", Offset = "0x1EAC2D0", VA = "0x181EAD0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::EGEGLONFOAN<T> BDEIDGDAJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1EACBC0", Offset = "0x1EABDC0", VA = "0x181EACBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1EAE5B0", Offset = "0x1EAD7B0", VA = "0x181EAE5B0")]
	public EGEGLONFOAN(T LJAFIJCKCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC9B0", Offset = "0x1EABBB0", VA = "0x181EAC9B0")]
	public global::EGEGLONFOAN<T> FFCMIOBKNPE(T IIINCMJELBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC040", Offset = "0x1EAB240", VA = "0x181EAC040")]
	public global::EGEGLONFOAN<T> AIFKGHMBIFG(T IHPEINDCGJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC3D0", Offset = "0x1EAB5D0", VA = "0x181EAC3D0")]
	public global::EGEGLONFOAN<T> ANHDIGNDBJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC510", Offset = "0x1EAB710", VA = "0x181EAC510")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1EAE1C0", Offset = "0x1EAD3C0", VA = "0x181EAE1C0")]
	public global::EGEGLONFOAN<T> PCOCLJCHJBO(T IHIMBABOFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1EADE80", Offset = "0x1EAD080", VA = "0x181EADE80")]
	public static void MGACBMEHAGB(global::EGEGLONFOAN<T> GIKCDFMNACC, EBJLAABMFKJ KKEJGPCILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1DFDCA0", Offset = "0x1DFCEA0", VA = "0x181DFDCA0")]
	public static void MGACBMEHAGB<A>(global::EGEGLONFOAN<T> GIKCDFMNACC, Func<global::EGEGLONFOAN<T>, A, bool> KKEJGPCILBL, A BPEDJNGDDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1EAD110", Offset = "0x1EAC310", VA = "0x181EAD110")]
	public static string LJCIPEMOEDM(global::EGEGLONFOAN<T> GIKCDFMNACC, int JNBLOKOIGCP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1EACE40", Offset = "0x1EAC040", VA = "0x181EACE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B0730", Offset = "0x5AF930", VA = "0x1805B0730")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x886550", Offset = "0x885750", VA = "0x180886550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FDKNNMCLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4FDE80", Offset = "0x4FD080", VA = "0x1804FDE80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4FDEB0", Offset = "0x4FD0B0", VA = "0x1804FDEB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22D2A40", Offset = "0x22D1C40", VA = "0x1822D2A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x506FB0", Offset = "0x5061B0", VA = "0x180506FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22DF4C0", Offset = "0x22DE6C0", VA = "0x1822DF4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int OEOGBPIMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x506FC0", Offset = "0x5061C0", VA = "0x180506FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4FC000", Offset = "0x4FB200", VA = "0x1804FC000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey PHLIBLBIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x22DF890", Offset = "0x22DEA90", VA = "0x1822DF890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x22E01B0", Offset = "0x22DF3B0", VA = "0x1822E01B0")]
	public MPKPPMOMDBD(int PLJFHAMCAMK, [Optional] KAJOILDPEAJ OILKJKKNDJG, [Optional] IEqualityComparer<TKey> OKLNNLJGLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x22E0280", Offset = "0x22DF480", VA = "0x1822E0280")]
	public MPKPPMOMDBD(int PLJFHAMCAMK, KAJOILDPEAJ OILKJKKNDJG, TimeSpan BFGNGADCLGC, [Optional] IEqualityComparer<TKey> OKLNNLJGLPJ, [Optional] JIMEIMFGIGC ABPFOLMBCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x22DFD60", Offset = "0x22DEF60", VA = "0x1822DFD60")]
	public void MMFJHDFCHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x22DEF00", Offset = "0x22DE100", VA = "0x1822DEF00")]
	public void BCKFLFBECFJ(TKey KPLFFOGJEBN, TVal DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x22DE8B0", Offset = "0x22DDAB0", VA = "0x1822DE8B0")]
	public bool ANHDIGNDBJL(TKey KPLFFOGJEBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x22DFC10", Offset = "0x22DEE10", VA = "0x1822DFC10")]
	public bool KLBAJGAHLAH(TKey BCKHJDJHJEK, out TVal DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x22DF8C0", Offset = "0x22DEAC0", VA = "0x1822DF8C0")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22DF940", Offset = "0x22DEB40", VA = "0x1822DF940")]
	private bool GCODJACKPNO(KHEMNLNPOHB EPOKGOKEJLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x22DF240", Offset = "0x22DE440", VA = "0x1822DF240")]
	private void COPDIODJHOB(LinkedListNode<KHEMNLNPOHB> LBNKDKEJNFF, TVal CFMONMCILIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x22DEA30", Offset = "0x22DDC30", VA = "0x1822DEA30")]
	private void BBNAHOCBBPI(TKey KPLFFOGJEBN, TVal DIDEMEECIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x22DF550", Offset = "0x22DE750", VA = "0x1822DF550")]
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
		[Cpp2IlInjected.Address(RVA = "0x256E600", Offset = "0x256D800", VA = "0x18256E600", Slot = "19")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E1DC30", Offset = "0x2E1CE30", VA = "0x182E1DC30", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2E1DC60", Offset = "0x2E1CE60", VA = "0x182E1DC60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3030", Offset = "0x1CE2230", VA = "0x181CE3030", Slot = "11")]
	public void Add(T LFJGKCMJBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D600", Offset = "0x2E1C800", VA = "0x182E1D600")]
	public bool FOAMNGNMEKG(T LFJGKCMJBNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E1DAE0", Offset = "0x2E1CCE0", VA = "0x182E1DAE0", Slot = "15")]
	public bool Remove(T LFJGKCMJBNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D6A0", Offset = "0x2E1C8A0", VA = "0x182E1D6A0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x279E0A0", Offset = "0x279D2A0", VA = "0x18279E0A0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D4C0", Offset = "0x2E1C6C0", VA = "0x182E1D4C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x299D9F0", Offset = "0x299CBF0", VA = "0x18299D9F0", Slot = "13")]
	public bool Contains(T LFJGKCMJBNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D520", Offset = "0x2E1C720", VA = "0x182E1D520", Slot = "14")]
	public void CopyTo(T[] OBEKMDCFBAG, int LONGPOIKMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2077050", Offset = "0x2076250", VA = "0x182077050", Slot = "6")]
	public int IndexOf(T LFJGKCMJBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D7F0", Offset = "0x2E1C9F0", VA = "0x182E1D7F0", Slot = "7")]
	public void Insert(int DLGFKHPJLDA, T LFJGKCMJBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D8B0", Offset = "0x2E1CAB0", VA = "0x182E1D8B0", Slot = "8")]
	public void RemoveAt(int DLGFKHPJLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2E1DB60", Offset = "0x2E1CD60", VA = "0x182E1DB60")]
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
			[Cpp2IlInjected.Address(RVA = "0x2004130", Offset = "0x2003330", VA = "0x182004130")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x408F7D0", Offset = "0x408E9D0", VA = "0x18408F7D0")]
		public SerializedGuid(in Guid NJIMCOMIGOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x408F690", Offset = "0x408E890", VA = "0x18408F690")]
		public static SerializedGuid ONLJHHLCMAO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x408F610", Offset = "0x408E810", VA = "0x18408F610")]
		public static SerializedGuid OFNAFBINHFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x408F580", Offset = "0x408E780", VA = "0x18408F580")]
		public bool HLMFFNKFFHN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x408F7B0", Offset = "0x408E9B0", VA = "0x18408F7B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x408F710", Offset = "0x408E910", VA = "0x18408F710", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x408F3F0", Offset = "0x408E5F0", VA = "0x18408F3F0", Slot = "7")]
		public bool Equals(SerializedGuid JJPLNCEMCNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x408F490", Offset = "0x408E690", VA = "0x18408F490", Slot = "0")]
		public override bool Equals(object LBCPAPMBFKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x408F570", Offset = "0x408E770", VA = "0x18408F570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x408F3C0", Offset = "0x408E5C0", VA = "0x18408F3C0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x408D310", Offset = "0x408C510", VA = "0x18408D310")]
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
		[Cpp2IlInjected.Address(RVA = "0x2076840", Offset = "0x2075A40", VA = "0x182076840", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool BHFJDOLCDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4FBDE0", Offset = "0x4FAFE0", VA = "0x1804FBDE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2076920", Offset = "0x2075B20", VA = "0x182076920")]
	private void OKIBAGHLIJI(T MKMAEMEOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2076870", Offset = "0x2075A70", VA = "0x182076870", Slot = "4")]
	public global::NHMAHKFFBLL<T> HMBAGGKALBC(Action<T> PDDMOLJDABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x20768F0", Offset = "0x2075AF0", VA = "0x1820768F0", Slot = "5")]
	public global::NHMAHKFFBLL<T> IJDGAGACDJH(Action<T> ENCCFIMHHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x20769A0", Offset = "0x2075BA0", VA = "0x1820769A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
		public KCKFCHBBIFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x288A190", Offset = "0x2889390", VA = "0x18288A190")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2123880", Offset = "0x2122A80", VA = "0x182123880")]
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
			[Cpp2IlInjected.Address(RVA = "0x408D5E0", Offset = "0x408C7E0", VA = "0x18408D5E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x408D590", Offset = "0x408C790", VA = "0x18408D590", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x408D6D0", Offset = "0x408C8D0", VA = "0x18408D6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x408D420", Offset = "0x408C620", VA = "0x18408D420")]
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
	[Cpp2IlInjected.Address(RVA = "0x408E380", Offset = "0x408D580", VA = "0x18408E380")]
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
		[Cpp2IlInjected.Address(RVA = "0x16F2F40", Offset = "0x16F2140", VA = "0x1816F2F40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3554E40", Offset = "0x3554040", VA = "0x183554E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x16F2F40", Offset = "0x16F2140", VA = "0x1816F2F40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3554D50", Offset = "0x3553F50", VA = "0x183554D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
		public FMEIGJBCHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3157E70", Offset = "0x3157070", VA = "0x183157E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x589D70", Offset = "0x588F70", VA = "0x180589D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x31561E0", Offset = "0x31553E0", VA = "0x1831561E0")]
	static FDOANGHHPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3156710", Offset = "0x3155910", VA = "0x183156710")]
	protected FDOANGHHPGL(TTask IFAGDJPBIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3155D50", Offset = "0x3154F50", VA = "0x183155D50", Slot = "1")]
	~FDOANGHHPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3155C80", Offset = "0x3154E80", VA = "0x183155C80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3155F60", Offset = "0x3155160", VA = "0x183155F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x3156150", Offset = "0x3155350", VA = "0x183156150")]
	protected void NODKMOFMLAL(T MKMAEMEOLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3155AC0", Offset = "0x3154CC0", VA = "0x183155AC0")]
	protected void CFEPPKCJOND(string HEEKCGODMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3155B40", Offset = "0x3154D40", VA = "0x183155B40")]
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
			[Cpp2IlInjected.Address(RVA = "0x22D2830", Offset = "0x22D1A30", VA = "0x1822D2830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DPILHGHPDGO NLIOFICPEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x22D28A0", Offset = "0x22D1AA0", VA = "0x1822D28A0", Slot = "4")]
			get
			{
				return default(DPILHGHPDGO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4A0", Offset = "0x5DE6A0", VA = "0x1805DF4A0")]
		public KGNMENDNBOI(global::MPGOBBODILK<T> ACMOLLPOGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x22D27A0", Offset = "0x22D19A0", VA = "0x1822D27A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5DF490", Offset = "0x5DE690", VA = "0x1805DF490", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FC90", VA = "0x180760A90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x22DE700", Offset = "0x22DD900", VA = "0x1822DE700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x22DDF50", Offset = "0x22DD150", VA = "0x1822DDF50")]
	public static global::MPGOBBODILK<T> EPILAMFGPCH(DPILHGHPDGO[] GAOBDNEMKDI, bool MHFDFBPFJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x22DE7F0", Offset = "0x22DD9F0", VA = "0x1822DE7F0")]
	public MPGOBBODILK(int PLJFHAMCAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x22DE570", Offset = "0x22DD770", VA = "0x1822DE570")]
	public int GIJMLJONIAA(T DIDEMEECIEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x22DE500", Offset = "0x22DD700", VA = "0x1822DE500")]
	public T GBAHAGCNPHG(int DLGFKHPJLDA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x22DE310", Offset = "0x22DD510", VA = "0x1822DE310")]
	public bool FOAMNGNMEKG(T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x22DE330", Offset = "0x22DD530", VA = "0x1822DE330")]
	public bool FOAMNGNMEKG(T DIDEMEECIEC, int DLGFKHPJLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x22DE5C0", Offset = "0x22DD7C0", VA = "0x1822DE5C0")]
	public DPILHGHPDGO[] HOCFHOPNBGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x22DE730", Offset = "0x22DD930", VA = "0x1822DE730")]
	private int LPHCOIJDBBC(int BEAMIBGJJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x22DE780", Offset = "0x22DD980", VA = "0x1822DE780", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x22DE780", Offset = "0x22DD980", VA = "0x1822DE780", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x335B990", Offset = "0x335AB90", VA = "0x18335B990")]
	public DANLHBAJKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x335B830", Offset = "0x335AA30", VA = "0x18335B830")]
	public DANLHBAJKIN(int PLJFHAMCAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x335B610", Offset = "0x335A810", VA = "0x18335B610")]
	public T CLKBMDDDHEO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x335B710", Offset = "0x335A910", VA = "0x18335B710")]
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
	[Cpp2IlInjected.Address(RVA = "0x355E6C0", Offset = "0x355D8C0", VA = "0x18355E6C0")]
	public bool BBNAHOCBBPI(T DIDEMEECIEC, int DEHBNGCHCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x355E780", Offset = "0x355D980", VA = "0x18355E780")]
	public bool FJGMKFKENHJ(int DEHBNGCHCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x355EA80", Offset = "0x355DC80", VA = "0x18355EA80")]
	public T MHJGPOBCNCC(int PJIHIPODFDI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x355EDF0", Offset = "0x355DFF0", VA = "0x18355EDF0")]
	private bool PLLCFLBDKFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x355E7E0", Offset = "0x355D9E0", VA = "0x18355E7E0")]
	public bool KLBAJGAHLAH(int DEHBNGCHCHD, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x355EE80", Offset = "0x355E080", VA = "0x18355EE80")]
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
		[Cpp2IlInjected.Address(RVA = "0x256E600", Offset = "0x256D800", VA = "0x18256E600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x298FF50", Offset = "0x298F150", VA = "0x18298FF50")]
	public bool LHBMLPKDBPE(T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x29901A0", Offset = "0x298F3A0", VA = "0x1829901A0")]
	public void OAGNENAKIKD(T DIDEMEECIEC, int DEHBNGCHCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x298FD40", Offset = "0x298EF40", VA = "0x18298FD40")]
	public bool ANHDIGNDBJL(T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x298FE60", Offset = "0x298F060", VA = "0x18298FE60")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x298FEC0", Offset = "0x298F0C0", VA = "0x18298FEC0")]
	public T GALNALFFPDK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2990220", Offset = "0x298F420", VA = "0x182990220")]
	private void OFJBPFGNBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2990430", Offset = "0x298F630", VA = "0x182990430")]
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
		[Cpp2IlInjected.Address(RVA = "0x17040F0", Offset = "0x17032F0", VA = "0x1817040F0", Slot = "4")]
		public virtual T LAIHHBCLCDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x16F2AE0", Offset = "0x16F1CE0", VA = "0x1816F2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15037C0", Offset = "0x15029C0", VA = "0x1815037C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2791410", Offset = "0x2790610", VA = "0x182791410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector2 PCOPGJFBHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x11C50F0", Offset = "0x11C42F0", VA = "0x1811C50F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Vector2 OKCCHGILHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x30B4CD0", Offset = "0x30B3ED0", VA = "0x1830B4CD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x30B4CF0", Offset = "0x30B3EF0", VA = "0x1830B4CF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x408EB60", Offset = "0x408DD60", VA = "0x18408EB60")]
	public PHENBJBFAGL(Bounds MDNBHLJHLKC, Vector2[] EPBBIEMAAMJ, int HEAPJLGLMDG, byte BEAMIBGJJFC, float INCKPEAKFPO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x408E5E0", Offset = "0x408D7E0", VA = "0x18408E5E0")]
	public MPPNLPJCOCL MPOEJONDIBP(byte DLGFKHPJLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x408E3E0", Offset = "0x408D5E0", VA = "0x18408E3E0")]
	public void DKKKPPONLHK(Vector3 JHNKAIDOAJL, float APOECGJGIEI, float BOOOONNDIKG, ref List<byte> LBNLJFEPICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x408E3C0", Offset = "0x408D5C0", VA = "0x18408E3C0")]
	public void BBNLCEHAKOF(MPPNLPJCOCL.AOHMBIHDDHG ILOFOLIOECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x408E4C0", Offset = "0x408D6C0", VA = "0x18408E4C0")]
	private MPPNLPJCOCL GKFJHCDFGGA(byte DLGFKHPJLDA, MPPNLPJCOCL.HJEMEHMOFMO IMDACAJCDGN, MPPNLPJCOCL KJKCKFBOOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x408E640", Offset = "0x408D840", VA = "0x18408E640")]
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
	[Cpp2IlInjected.Address(RVA = "0x408DD60", Offset = "0x408CF60", VA = "0x18408DD60")]
	public MPPNLPJCOCL(byte HNDJNNFIENP, HJEMEHMOFMO IMDACAJCDGN, MPPNLPJCOCL KJKCKFBOOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x408DC70", Offset = "0x408CE70", VA = "0x18408DC70")]
	public void FFCMIOBKNPE(MPPNLPJCOCL DICGFHBNIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00")]
	public void BBNLCEHAKOF(int FJJECBKABEH, AOHMBIHDDHG ILOFOLIOECB, int JLAJLAAACIM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x408D9E0", Offset = "0x408CBE0", VA = "0x18408D9E0")]
	public void DKKKPPONLHK(List<byte> LBNLJFEPICN, Vector3 JHNKAIDOAJL, float APOECGJGIEI, float BOOOONNDIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x408DD00", Offset = "0x408CF00", VA = "0x18408DD00")]
	public bool IJGPLHFNPEN(Vector3 GCKOJPEPDIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x408D9A0", Offset = "0x408CBA0", VA = "0x18408D9A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D6E250", Offset = "0x2D6D450", VA = "0x182D6E250")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T PIHOKIPHKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DE80", Offset = "0x2D6D080", VA = "0x182D6DE80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T BPPOMIIKJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E3E0", Offset = "0x2D6D5E0", VA = "0x182D6E3E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2D6E430", Offset = "0x2D6D630", VA = "0x182D6E430")]
	public IPIEAOMADAO(int PLJFHAMCAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2D6E110", Offset = "0x2D6D310", VA = "0x182D6E110")]
	public void OAGNENAKIKD(T HPBMPMHGEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2D6DF80", Offset = "0x2D6D180", VA = "0x182D6DF80")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2D6DF30", Offset = "0x2D6D130", VA = "0x182D6DF30")]
	public void CKKCCNHBBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2D6DFC0", Offset = "0x2D6D1C0", VA = "0x182D6DFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15037C0", Offset = "0x15029C0", VA = "0x1815037C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2791410", Offset = "0x2790610", VA = "0x182791410", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KGHNCNFOCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1CDA770", Offset = "0x1CD9970", VA = "0x181CDA770")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CD9F70", Offset = "0x1CD9170", VA = "0x181CD9F70")]
	public bool BBNAHOCBBPI(T DIDEMEECIEC, object KFBPOACAFGF, int DEHBNGCHCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1CDA280", Offset = "0x1CD9480", VA = "0x181CDA280")]
	public bool FJGMKFKENHJ(object KFBPOACAFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBAA0", Offset = "0x2ECACA0", VA = "0x182ECBAA0")]
	public bool KLBAJGAHLAH(object KFBPOACAFGF, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1CDA250", Offset = "0x1CD9450", VA = "0x181CDA250")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBEA0", Offset = "0x2ECB0A0", VA = "0x182ECBEA0")]
	private bool PLLCFLBDKFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x1CDD7C0", Offset = "0x1CDC9C0", VA = "0x181CDD7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB4D720", Offset = "0xB4C920", VA = "0x180B4D720")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAAD320", Offset = "0xAAC520", VA = "0x180AAD320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x408D730", Offset = "0x408C930", VA = "0x18408D730")]
	public void BBNAHOCBBPI(float DIDEMEECIEC, object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x408D7A0", Offset = "0x408C9A0", VA = "0x18408D7A0")]
	public void FJGMKFKENHJ(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x408D810", Offset = "0x408CA10", VA = "0x18408D810")]
	private void IHNFFHCPKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x408D930", Offset = "0x408CB30", VA = "0x18408D930")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E1560", Offset = "0x4E0760", VA = "0x1804E1560")]
		public GMIOKMMCINP(string OAFDFDNMOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x408CA80", Offset = "0x408BC80", VA = "0x18408CA80", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x408D370", Offset = "0x408C570", VA = "0x18408D370")]
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
		[Cpp2IlInjected.Address(RVA = "0x408F050", Offset = "0x408E250", VA = "0x18408F050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x408F1A0", Offset = "0x408E3A0", VA = "0x18408F1A0")]
	public void OAGNENAKIKD(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x408F090", Offset = "0x408E290", VA = "0x18408F090")]
	public void ANHDIGNDBJL(object KFBPOACAFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x408F0F0", Offset = "0x408E2F0", VA = "0x18408F0F0")]
	public bool LHBMLPKDBPE(object KFBPOACAFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x408F150", Offset = "0x408E350", VA = "0x18408F150")]
	public void LJLBMEMDJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x408F200", Offset = "0x408E400", VA = "0x18408F200", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x408F360", Offset = "0x408E560", VA = "0x18408F360")]
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
		[Cpp2IlInjected.Address(RVA = "0xFE2850", Offset = "0xFE1A50", VA = "0x180FE2850", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2791430", Offset = "0x2790630", VA = "0x182791430", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E4620", Offset = "0x4E3820", VA = "0x1804E4620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool KGHNCNFOCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2791760", Offset = "0x2790960", VA = "0x182791760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2790E00", Offset = "0x2790000", VA = "0x182790E00")]
	public bool BBNAHOCBBPI(T DIDEMEECIEC, object KFBPOACAFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2791390", Offset = "0x2790590", VA = "0x182791390")]
	public bool FJGMKFKENHJ(object KFBPOACAFGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1CDA250", Offset = "0x1CD9450", VA = "0x181CDA250")]
	public void EGONGNAPLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x27914F0", Offset = "0x27906F0", VA = "0x1827914F0")]
	public bool KLBAJGAHLAH(object KFBPOACAFGF, out T DIDEMEECIEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x27917A0", Offset = "0x27909A0", VA = "0x1827917A0")]
	private bool PLLCFLBDKFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2793450", Offset = "0x2792650", VA = "0x182793450")]
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
