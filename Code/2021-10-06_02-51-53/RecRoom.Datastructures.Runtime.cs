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
public class DJPOGBNFEHL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x629D60", Offset = "0x628D60", VA = "0x180629D60")]
	public DJPOGBNFEHL()
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
		[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x446F60", Offset = "0x445F60", VA = "0x180446F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x426030", Offset = "0x425030", VA = "0x180426030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "4")]
	public virtual void MBDFCBCHKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
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
	[DJPOGBNFEHL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x34939A0", Offset = "0x34929A0", VA = "0x1834939A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x34934E0", Offset = "0x34924E0", VA = "0x1834934E0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3493FA0", Offset = "0x3492FA0", VA = "0x183493FA0")]
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
	private sealed class NDPCIJGFBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public NDPCIJGFBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x26A95D0", Offset = "0x26A85D0", VA = "0x1826A95D0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[DJPOGBNFEHL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x26A8830", Offset = "0x26A7830", VA = "0x1826A8830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x26A8860", Offset = "0x26A7860", VA = "0x1826A8860", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x26A8780", Offset = "0x26A7780", VA = "0x1826A8780", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey PFPLGCLHCBM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x26A87B0", Offset = "0x26A77B0", VA = "0x1826A87B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x26A8690", Offset = "0x26A7690", VA = "0x1826A8690", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26A7F00", Offset = "0x26A6F00", VA = "0x1826A7F00", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x26A7870", Offset = "0x26A6870", VA = "0x1826A7870", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x26A7410", Offset = "0x26A6410", VA = "0x1826A7410", Slot = "14")]
	protected virtual string COICAAPDBEA(TKeyVal JKKJKECOINP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26A7440", Offset = "0x26A6440", VA = "0x1826A7440", Slot = "4")]
	public bool ContainsKey(TKey PFPLGCLHCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26A8590", Offset = "0x26A7590", VA = "0x1826A8590", Slot = "5")]
	public bool TryGetValue(TKey PFPLGCLHCBM, out TVal MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26A7470", Offset = "0x26A6470", VA = "0x1826A7470", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26A7470", Offset = "0x26A6470", VA = "0x1826A7470", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26A85C0", Offset = "0x26A75C0", VA = "0x1826A85C0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CALBKAEALGG : IEnumerator<object>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x446090", Offset = "0x445090", VA = "0x180446090")]
		[DebuggerHidden]
		public CALBKAEALGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CEE780", Offset = "0x3CED780", VA = "0x183CEE780", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CEE630", Offset = "0x3CED630", VA = "0x183CEE630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3CEE7F0", Offset = "0x3CED7F0", VA = "0x183CEE7F0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3CEE730", Offset = "0x3CED730", VA = "0x183CEE730", Slot = "8")]
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
	private static HashSet<GameObject> GKAILOKIDLD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0180", Offset = "0x3CEF180", VA = "0x183CF0180")]
	public static void RegisterDontDestroyOnLoad(GameObject LEDCOFKICEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3CEFFA0", Offset = "0x3CEEFA0", VA = "0x183CEFFA0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0220", Offset = "0x3CEF220", VA = "0x183CF0220")]
	[IteratorStateMachine(typeof(CALBKAEALGG))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "6")]
	protected virtual void LIGIEIKOBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3CF02E0", Offset = "0x3CEF2E0", VA = "0x183CF02E0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ELLKBPBHLCF
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x28B8AA0", Offset = "0x28B7AA0", VA = "0x1828B8AA0")]
	public static void ENIAKODEFKJ<T>(this T APBHEDIIPNA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3CEFC90", Offset = "0x3CEEC90", VA = "0x183CEFC90")]
	public static void ENIAKODEFKJ(this GameObject KMOLMBPFHHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : MonoBehaviour where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static TImpl ADIONEBLIHB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected static TImpl HBMGMANAGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1317440", Offset = "0x1316440", VA = "0x181317440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1F2AA00", Offset = "0x1F29A00", VA = "0x181F2AA00", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1F2AED0", Offset = "0x1F29ED0", VA = "0x181F2AED0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B120", Offset = "0x1F2A120", VA = "0x181F2B120")]
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
	public GameObject IDPPKECBMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD6B3C0", Offset = "0xD6A3C0", VA = "0x180D6B3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CF07B0", Offset = "0x3CEF7B0", VA = "0x183CF07B0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CF09D0", Offset = "0x3CEF9D0", VA = "0x183CF09D0")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x41FA40", Offset = "0x41EA40", VA = "0x18041FA40")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static T ADIONEBLIHB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static T HBMGMANAGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1317440", Offset = "0x1316440", VA = "0x181317440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool HNFJBBELAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3494570", Offset = "0x3493570", VA = "0x183494570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3494030", Offset = "0x3493030", VA = "0x183494030", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x34943B0", Offset = "0x34933B0", VA = "0x1834943B0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1F2B120", Offset = "0x1F2A120", VA = "0x181F2B120")]
	public SingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HOJDCOFJDJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JMBHEJMGKLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public JMBHEJMGKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F30670", Offset = "0x1F2F670", VA = "0x181F30670")]
		internal bool <GetSamples>b__0(global::CIDFHFDHJHI<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float NDMHHHONLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float MAAKLECIIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::CIDFHFDHJHI<float, T>> MPLNGIANIBP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JNKGCEKADCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1F209C0", Offset = "0x1F1F9C0", VA = "0x181F209C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F21390", Offset = "0x1F20390", VA = "0x181F21390")]
	public HOJDCOFJDJC(float HLEIKDBFLLE, float JABDMPKJLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F20A40", Offset = "0x1F1FA40", VA = "0x181F20A40")]
	public bool DHJINABNEDM(float CNHGKIFCOBI, T MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1F20D30", Offset = "0x1F1FD30", VA = "0x181F20D30")]
	public IEnumerable<T> JFCLEJPJPJC(float CNHGKIFCOBI, [Optional] float? JAOEIKDMJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1F20D00", Offset = "0x1F1FD00", VA = "0x181F20D00")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1F20880", Offset = "0x1F1F880", VA = "0x181F20880")]
	private void AKGHFNKOONE(float CNHGKIFCOBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class GLKAGEOBHLC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct IPALLKIBCAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T BFJAJBGCPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float LOPAKHFOHGL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float KMAEKJCLHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> DAPFCEAIJPM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int JAFGNFIKKMP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private IPALLKIBCAM[] JEKGLADIOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int MCOACOJOOMK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float GEJAKMBOPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x56C630", Offset = "0x56B630", VA = "0x18056C630")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x56C700", Offset = "0x56B700", VA = "0x18056C700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x32B3540", Offset = "0x32B2540", VA = "0x1832B3540")]
	public GLKAGEOBHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x32B3570", Offset = "0x32B2570", VA = "0x1832B3570")]
	public GLKAGEOBHLC(int DFDGHCFEOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x32B26A0", Offset = "0x32B16A0", VA = "0x1832B26A0")]
	public void AIJJCOHLNPC(float CNHGKIFCOBI, T MNEBKBGCGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x32B2B60", Offset = "0x32B1B60", VA = "0x1832B2B60")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x32B3120", Offset = "0x32B2120", VA = "0x1832B3120")]
	public bool PAKPEJMNMFE(float FCCPFFHLCGF, float FEOHKIDEKJA, out T MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x32B2850", Offset = "0x32B1850", VA = "0x1832B2850")]
	public bool FELPKHOMOLK(float FCCPFFHLCGF, float FEOHKIDEKJA, out T MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x32B2F60", Offset = "0x32B1F60", VA = "0x1832B2F60")]
	public void KJIANDBAMJK(float FCCPFFHLCGF, float FEOHKIDEKJA, List<T> GANPMABGPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x32B30F0", Offset = "0x32B20F0", VA = "0x1832B30F0")]
	private int OMPFBCIGHPE(int BIBPNEOJIBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x32B30B0", Offset = "0x32B20B0", VA = "0x1832B30B0")]
	private void NNCBNLDJAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GHOFIKGKMGO();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T JDPFPJNDDAF(T MNEBKBGCGHD, float DCLCIEOKEFI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JIKEFCDINGG(T IHNLLEKMOKL, T FPBHDBABJKF);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T CPHJFALMHMI(T IHNLLEKMOKL, T FPBHDBABJKF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PECPJKHCAFD : global::GLKAGEOBHLC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0CC0", Offset = "0x3CEFCC0", VA = "0x183CF0CC0", Slot = "4")]
	protected override Vector3 GHOFIKGKMGO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0D30", Offset = "0x3CEFD30", VA = "0x183CF0D30", Slot = "5")]
	protected override Vector3 JDPFPJNDDAF(Vector3 MNEBKBGCGHD, float DCLCIEOKEFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0DD0", Offset = "0x3CEFDD0", VA = "0x183CF0DD0", Slot = "6")]
	protected override Vector3 JIKEFCDINGG(Vector3 IHNLLEKMOKL, Vector3 FPBHDBABJKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0C50", Offset = "0x3CEFC50", VA = "0x183CF0C50", Slot = "7")]
	protected override Vector3 CPHJFALMHMI(Vector3 IHNLLEKMOKL, Vector3 FPBHDBABJKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0E80", Offset = "0x3CEFE80", VA = "0x183CF0E80")]
	public PECPJKHCAFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BPOOBMGOGIA
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25E8AD0", Offset = "0x25E7AD0", VA = "0x1825E8AD0")]
	public static global::CIDFHFDHJHI<T1, T2> KCCOLOKOAMM<T1, T2>(T1 JEFALKGFMFP, T2 ADDKHIBNHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24A4AB0", Offset = "0x24A3AB0", VA = "0x1824A4AB0")]
	public static global::HJJNIAHCMOD<T1, T2, T3> KCCOLOKOAMM<T1, T2, T3>(T1 JEFALKGFMFP, T2 ADDKHIBNHEM, T3 DFENLBPINHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA781C0", Offset = "0xA771C0", VA = "0x180A781C0")]
	internal static int NBADGBADHIE(int KEINJOFNMOA, int AMOMGAEDLBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xF67390", Offset = "0xF66390", VA = "0x180F67390")]
	internal static int NBADGBADHIE(int KEINJOFNMOA, int AMOMGAEDLBL, int INMMEOOGOBB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CIDFHFDHJHI<T1, T2> : IComparable<global::CIDFHFDHJHI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 GBHNBNOHFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 GEJFEDIGMPL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E398F0", Offset = "0x2E388F0", VA = "0x182E398F0")]
	public CIDFHFDHJHI(T1 JEFALKGFMFP, T2 ADDKHIBNHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2F0A230", Offset = "0x2F09230", VA = "0x182F0A230", Slot = "4")]
	public int CompareTo(global::CIDFHFDHJHI<T1, T2> JNEOAAICJDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AA60", Offset = "0x2F09A60", VA = "0x182F0AA60", Slot = "0")]
	public override bool Equals(object JNEOAAICJDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AD40", Offset = "0x2F09D40", VA = "0x182F0AD40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B710", Offset = "0x2F0A710", VA = "0x182F0B710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HJJNIAHCMOD<T1, T2, T3> : IComparable<global::HJJNIAHCMOD<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 GBHNBNOHFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 GEJFEDIGMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 NPIMBDLANEL;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1F20810", Offset = "0x1F1F810", VA = "0x181F20810")]
	public HJJNIAHCMOD(T1 JEFALKGFMFP, T2 ADDKHIBNHEM, T3 DFENLBPINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1F200D0", Offset = "0x1F1F0D0", VA = "0x181F200D0", Slot = "4")]
	public int CompareTo(global::HJJNIAHCMOD<T1, T2, T3> JNEOAAICJDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1F201D0", Offset = "0x1F1F1D0", VA = "0x181F201D0", Slot = "0")]
	public override bool Equals(object JNEOAAICJDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1F20430", Offset = "0x1F1F430", VA = "0x181F20430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1F20530", Offset = "0x1F1F530", VA = "0x181F20530", Slot = "3")]
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
	public T BFJAJBGCPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4227E0", Offset = "0x4217E0", VA = "0x1804227E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4DF530", Offset = "0x4DE530", VA = "0x1804DF530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float CDLNJGAIEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4E5F10", Offset = "0x4E4F10", VA = "0x1804E5F10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x301CC70", Offset = "0x301BC70", VA = "0x18301CC70")]
	public T IDDMFKLNHAJ(float DCLCIEOKEFI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x301CEF0", Offset = "0x301BEF0", VA = "0x18301CEF0")]
	public T LFFBKFEIKEP(float DCLCIEOKEFI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GLDFMOHDIAF(T IHNLLEKMOKL, T FPBHDBABJKF, float DCLCIEOKEFI);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3CEFEE0", Offset = "0x3CEEEE0", VA = "0x183CEFEE0", Slot = "4")]
	protected override float GLDFMOHDIAF(float IHNLLEKMOKL, float FPBHDBABJKF, float DCLCIEOKEFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3CEFF60", Offset = "0x3CEEF60", VA = "0x183CEFF60")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3CF1320", Offset = "0x3CF0320", VA = "0x183CF1320", Slot = "4")]
	protected override Vector3 GLDFMOHDIAF(Vector3 IHNLLEKMOKL, Vector3 FPBHDBABJKF, float DCLCIEOKEFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3CF13E0", Offset = "0x3CF03E0", VA = "0x183CF13E0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3CDDCD0", Offset = "0x3CDCCD0", VA = "0x183CDDCD0", Slot = "4")]
	protected override Color GLDFMOHDIAF(Color IHNLLEKMOKL, Color FPBHDBABJKF, float DCLCIEOKEFI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEB50", Offset = "0x3CEDB50", VA = "0x183CEEB50")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class NDDACPEJLPE<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private global::NDDACPEJLPE<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x56C630", Offset = "0x56B630", VA = "0x18056C630", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2E93910", Offset = "0x2E92910", VA = "0x182E93910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2E93D30", Offset = "0x2E92D30", VA = "0x182E93D30")]
		public Enumerator(global::NDDACPEJLPE<T> GANPMABGPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2E931A0", Offset = "0x2E921A0", VA = "0x182E931A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2E936D0", Offset = "0x2E926D0", VA = "0x182E936D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2E93020", Offset = "0x2E92020", VA = "0x182E93020")]
		private void JMNLGCCEGPC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] KONMLHBKNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int OFGNLHOGGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int LANHDPNIGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int JMGPPINBPMH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MFJPBNLJGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2E9CFF0", Offset = "0x2E9BFF0", VA = "0x182E9CFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T FOHFHOFKGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2E9C250", Offset = "0x2E9B250", VA = "0x182E9C250")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2E9CE90", Offset = "0x2E9BE90", VA = "0x182E9CE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D1C0", Offset = "0x2E9C1C0", VA = "0x182E9D1C0")]
	public NDDACPEJLPE(int JGJJNCMMGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2E9BEE0", Offset = "0x2E9AEE0", VA = "0x182E9BEE0")]
	public void AIJJCOHLNPC(T DCLCIEOKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C730", Offset = "0x2E9B730", VA = "0x182E9C730")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CD80", Offset = "0x2E9BD80", VA = "0x182E9CD80")]
	public void IDBGKBOFDPI(int EFBKKCLPALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C8A0", Offset = "0x2E9B8A0", VA = "0x182E9C8A0")]
	public void HAIOGPKCFGL(T[] JEKGLADIOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CC90", Offset = "0x2E9BC90", VA = "0x182E9CC90")]
	public Enumerator HOOEJLNHGKE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D0C0", Offset = "0x2E9C0C0", VA = "0x182E9D0C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D0C0", Offset = "0x2E9C0C0", VA = "0x182E9D0C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C550", Offset = "0x2E9B550", VA = "0x182E9C550")]
	private int FBMKFEMHHBJ(int DKJKEBPJDEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C1C0", Offset = "0x2E9B1C0", VA = "0x182E9C1C0")]
	private int BKHNIPNCPFJ(int DKJKEBPJDEF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class AELNGMDJCJO
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
	protected AELNGMDJCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class GLJNICAGNFE<T> : AELNGMDJCJO
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	protected struct COBOJNCHBJD
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum DILFKENLBOA
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
		public DILFKENLBOA PBECNPPNGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public T MMBIEGLGGJN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int FCMOEGFDMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly bool PFGEAMEGBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	protected readonly bool JCMLDMMOMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	protected List<T> POCHDIEDBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<COBOJNCHBJD> OOGEDBIOAPL;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JHHILHCHEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x32B2430", Offset = "0x32B1430", VA = "0x1832B2430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x32B2650", Offset = "0x32B1650", VA = "0x1832B2650")]
	protected GLJNICAGNFE(bool JCMLDMMOMKJ, bool PFGEAMEGBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x32B2470", Offset = "0x32B1470", VA = "0x1832B2470")]
	protected bool OIAIBKCDNBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x32B2350", Offset = "0x32B1350", VA = "0x1832B2350")]
	protected void HPHDOMAKCNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x32B21A0", Offset = "0x32B11A0", VA = "0x1832B21A0")]
	protected void GCNLKJPFICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x28BC9A0", Offset = "0x28BB9A0", VA = "0x1828BC9A0")]
	private static void BHKABILICJM<U>(ref List<U> LOPGLBDJGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x32B1F20", Offset = "0x32B0F20", VA = "0x1832B1F20", Slot = "4")]
	public void AIJJCOHLNPC(T MMBIEGLGGJN, bool GCHGNNBCDOI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x32B2510", Offset = "0x32B1510", VA = "0x1832B2510", Slot = "5")]
	public void OLMCAFOCELO(T MMBIEGLGGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x32B2070", Offset = "0x32B1070", VA = "0x1832B2070")]
	public void FMCAHCCFHCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class BMLBBOJCOFN : global::GLJNICAGNFE<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE5D0", Offset = "0x3CED5D0", VA = "0x183CEE5D0")]
	public BMLBBOJCOFN(bool JCMLDMMOMKJ = false, bool PFGEAMEGBLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE3C0", Offset = "0x3CED3C0", VA = "0x183CEE3C0")]
	public void HOACHECPLMO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE360", Offset = "0x3CED360", VA = "0x183CEE360")]
	public static BMLBBOJCOFN CANHPEGEPNH(BMLBBOJCOFN OMMMBLEDPJN, Action MMBIEGLGGJN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE570", Offset = "0x3CED570", VA = "0x183CEE570")]
	public static BMLBBOJCOFN PFJADNLCPNG(BMLBBOJCOFN OMMMBLEDPJN, Action MMBIEGLGGJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IGNNIOIEOIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIJJCOHLNPC(Action<T> MMBIEGLGGJN, bool GCHGNNBCDOI = false);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLMCAFOCELO(Action<T> MMBIEGLGGJN);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class DLOGNCHNMOH<T> : global::GLJNICAGNFE<Action<T>>, global::IGNNIOIEOIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x29E0990", Offset = "0x29DF990", VA = "0x1829E0990")]
	public DLOGNCHNMOH(bool JCMLDMMOMKJ = false, bool PFGEAMEGBLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2FFEF80", Offset = "0x2FFDF80", VA = "0x182FFEF80")]
	public void HOACHECPLMO(T DCLCIEOKEFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x29DECC0", Offset = "0x29DDCC0", VA = "0x1829DECC0")]
	public static global::DLOGNCHNMOH<T> CANHPEGEPNH(global::DLOGNCHNMOH<T> OMMMBLEDPJN, Action<T> MMBIEGLGGJN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x29E08F0", Offset = "0x29DF8F0", VA = "0x1829E08F0")]
	public static global::DLOGNCHNMOH<T> PFJADNLCPNG(global::DLOGNCHNMOH<T> OMMMBLEDPJN, Action<T> MMBIEGLGGJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KAFPNLNKPOB<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NDOOJGEDILP<T, U> : global::GLJNICAGNFE<Action<T, U>>, global::KAFPNLNKPOB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x29E0990", Offset = "0x29DF990", VA = "0x1829E0990")]
	public NDOOJGEDILP(bool JCMLDMMOMKJ = false, bool PFGEAMEGBLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F9D0", Offset = "0x2E9E9D0", VA = "0x182E9F9D0")]
	public void HOACHECPLMO(T DCLCIEOKEFI, U PMPLAICIIAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x29DECC0", Offset = "0x29DDCC0", VA = "0x1829DECC0")]
	public static global::NDOOJGEDILP<T, U> CANHPEGEPNH(global::NDOOJGEDILP<T, U> OMMMBLEDPJN, Action<T, U> MMBIEGLGGJN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x29E08F0", Offset = "0x29DF8F0", VA = "0x1829E08F0")]
	public static global::NDOOJGEDILP<T, U> PFJADNLCPNG(global::NDOOJGEDILP<T, U> OMMMBLEDPJN, Action<T, U> MMBIEGLGGJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class ACGNMLBFHHO<T, U, V> : global::GLJNICAGNFE<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x29E0990", Offset = "0x29DF990", VA = "0x1829E0990")]
	public ACGNMLBFHHO(bool JCMLDMMOMKJ = false, bool PFGEAMEGBLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x29DF630", Offset = "0x29DE630", VA = "0x1829DF630")]
	public void HOACHECPLMO(T DCLCIEOKEFI, U PMPLAICIIAN, V NDLEACBMNBM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x29DECC0", Offset = "0x29DDCC0", VA = "0x1829DECC0")]
	public static global::ACGNMLBFHHO<T, U, V> CANHPEGEPNH(global::ACGNMLBFHHO<T, U, V> OMMMBLEDPJN, Action<T, U, V> MMBIEGLGGJN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x29E08F0", Offset = "0x29DF8F0", VA = "0x1829E08F0")]
	public static global::ACGNMLBFHHO<T, U, V> PFJADNLCPNG(global::ACGNMLBFHHO<T, U, V> OMMMBLEDPJN, Action<T, U, V> MMBIEGLGGJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EIPGKPJMFKL<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KOCBNFMEFEL<T, U, V, W> : global::GLJNICAGNFE<Action<T, U, V, W>>, global::EIPGKPJMFKL<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x29E0990", Offset = "0x29DF990", VA = "0x1829E0990")]
	public KOCBNFMEFEL(bool JCMLDMMOMKJ = false, bool PFGEAMEGBLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2F61700", Offset = "0x2F60700", VA = "0x182F61700")]
	public void HOACHECPLMO(T DCLCIEOKEFI, U PMPLAICIIAN, V NDLEACBMNBM, W OIMNCIEOGJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x29DECC0", Offset = "0x29DDCC0", VA = "0x1829DECC0")]
	public static global::KOCBNFMEFEL<T, U, V, W> CANHPEGEPNH(global::KOCBNFMEFEL<T, U, V, W> OMMMBLEDPJN, Action<T, U, V, W> MMBIEGLGGJN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x29E08F0", Offset = "0x29DF8F0", VA = "0x1829E08F0")]
	public static global::KOCBNFMEFEL<T, U, V, W> PFJADNLCPNG(global::KOCBNFMEFEL<T, U, V, W> OMMMBLEDPJN, Action<T, U, V, W> MMBIEGLGGJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class LNGIEOABMJN<T, U, V, W, X> : global::GLJNICAGNFE<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x29E0990", Offset = "0x29DF990", VA = "0x1829E0990")]
	public LNGIEOABMJN(bool JCMLDMMOMKJ = false, bool PFGEAMEGBLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E40560", Offset = "0x2E3F560", VA = "0x182E40560")]
	public void HOACHECPLMO(T DCLCIEOKEFI, U PMPLAICIIAN, V NDLEACBMNBM, W OIMNCIEOGJN, X NMIBMCCJCMC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x29DECC0", Offset = "0x29DDCC0", VA = "0x1829DECC0")]
	public static global::LNGIEOABMJN<T, U, V, W, X> CANHPEGEPNH(global::LNGIEOABMJN<T, U, V, W, X> OMMMBLEDPJN, Action<T, U, V, W, X> MMBIEGLGGJN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x29E08F0", Offset = "0x29DF8F0", VA = "0x1829E08F0")]
	public static global::LNGIEOABMJN<T, U, V, W, X> PFJADNLCPNG(global::LNGIEOABMJN<T, U, V, W, X> OMMMBLEDPJN, Action<T, U, V, W, X> MMBIEGLGGJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class FMMPEMIKNHA<T, U, V, W, X, Y> : global::GLJNICAGNFE<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x29E0990", Offset = "0x29DF990", VA = "0x1829E0990")]
	public FMMPEMIKNHA(bool JCMLDMMOMKJ = false, bool PFGEAMEGBLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x32A9540", Offset = "0x32A8540", VA = "0x1832A9540")]
	public void HOACHECPLMO(T DCLCIEOKEFI, U PMPLAICIIAN, V NDLEACBMNBM, W OIMNCIEOGJN, X NMIBMCCJCMC, Y DGEGAPNLFOP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x29DECC0", Offset = "0x29DDCC0", VA = "0x1829DECC0")]
	public static global::FMMPEMIKNHA<T, U, V, W, X, Y> CANHPEGEPNH(global::FMMPEMIKNHA<T, U, V, W, X, Y> OMMMBLEDPJN, Action<T, U, V, W, X, Y> MMBIEGLGGJN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x29E08F0", Offset = "0x29DF8F0", VA = "0x1829E08F0")]
	public static global::FMMPEMIKNHA<T, U, V, W, X, Y> PFJADNLCPNG(global::FMMPEMIKNHA<T, U, V, W, X, Y> OMMMBLEDPJN, Action<T, U, V, W, X, Y> MMBIEGLGGJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DGNNJFMGBGD<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool CPMJGKNJEFE(global::DGNNJFMGBGD<T> HHIBDBGMFAP);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class ABIECLKINDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public global::DGNNJFMGBGD<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public ABIECLKINDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2FF9610", Offset = "0x2FF8610", VA = "0x182FF9610")]
		internal bool <FindNode>b__0(global::DGNNJFMGBGD<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public T MHELOONJKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public LinkedList<global::DGNNJFMGBGD<T>> BGKJODAKGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public global::DGNNJFMGBGD<T> OHDKEOLANHH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::DGNNJFMGBGD<T> BCAACCDFMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4BC5D0", Offset = "0x4BB5D0", VA = "0x1804BC5D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2FFE370", Offset = "0x2FFD370", VA = "0x182FFE370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool MPICIAFPLAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2FFC860", Offset = "0x2FFB860", VA = "0x182FFC860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PIAOCHOELOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2FFBF90", Offset = "0x2FFAF90", VA = "0x182FFBF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::DGNNJFMGBGD<T> PPPHKMBNCJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2FFD6C0", Offset = "0x2FFC6C0", VA = "0x182FFD6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2FFE430", Offset = "0x2FFD430", VA = "0x182FFE430")]
	public DGNNJFMGBGD(T MHJLAKHGIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC650", Offset = "0x2FFB650", VA = "0x182FFC650")]
	public global::DGNNJFMGBGD<T> FEGCJNOKFBA(T PGCOGFNBJHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD4F0", Offset = "0x2FFC4F0", VA = "0x182FFD4F0")]
	public global::DGNNJFMGBGD<T> KPPMGJDMJAK(T EDBHMGHOCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2FFE200", Offset = "0x2FFD200", VA = "0x182FFE200")]
	public global::DGNNJFMGBGD<T> OLMCAFOCELO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC890", Offset = "0x2FFB890", VA = "0x182FFC890")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD220", Offset = "0x2FFC220", VA = "0x182FFD220")]
	public global::DGNNJFMGBGD<T> KHAPNOIMAPA(T KLHJHKANPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2FFBFD0", Offset = "0x2FFAFD0", VA = "0x182FFBFD0")]
	public static void DILDOBINBGO(global::DGNNJFMGBGD<T> BGKDPIGAFOK, CPMJGKNJEFE OABBOIOHIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x28B7070", Offset = "0x28B6070", VA = "0x1828B7070")]
	public static void DILDOBINBGO<A>(global::DGNNJFMGBGD<T> BGKDPIGAFOK, Func<global::DGNNJFMGBGD<T>, A, bool> OABBOIOHIJA, A FDEJCAKNDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD740", Offset = "0x2FFC740", VA = "0x182FFD740")]
	public static string OIFMBBJIEBJ(global::DGNNJFMGBGD<T> BGKDPIGAFOK, int ICBPEDEHHBJ = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2FFCD30", Offset = "0x2FFBD30", VA = "0x182FFCD30")]
	public static global::DGNNJFMGBGD<T> JAIOBIFPECA(global::DGNNJFMGBGD<T> BGKDPIGAFOK, T OGBFDBFKAIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DefaultMember("Item")]
public class ABBFONMIMDI<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate int GGKEDKJIIKB(TKey PFPLGCLHCBM, TVal MNEBKBGCGHD);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class MEEOKKCHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey NGAHLDIBNFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal BFJAJBGCPNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x52A930", Offset = "0x529930", VA = "0x18052A930")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5AF060", Offset = "0x5AE060", VA = "0x1805AF060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int FAKLEMDNDMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5E8990", Offset = "0x5E7990", VA = "0x1805E8990")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4AB770", Offset = "0x4AA770", VA = "0x1804AB770")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime PGBNPEHNDFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x423230", Offset = "0x422230", VA = "0x180423230")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x4260F0", Offset = "0x4250F0", VA = "0x1804260F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x29E3FF0", Offset = "0x29E2FF0", VA = "0x1829E3FF0")]
		public MEEOKKCHHOG(TKey PFPLGCLHCBM, TVal FNLDCACDFHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public const int KBJALBEDHOL = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Dictionary<TKey, LinkedListNode<MEEOKKCHHOG>> ABMELLMEJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly LinkedList<MEEOKKCHHOG> NGIKJLMDIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GGKEDKJIIKB FCJDCNMAPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly TimeSpan AAJOIFBAMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FGGKBOKOMCN BDFOFEJOBKF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int HHABPEKOOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4227D0", Offset = "0x4217D0", VA = "0x1804227D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool MDKICNBBPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x29DCE80", Offset = "0x29DBE80", VA = "0x1829DCE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int EABHIODKDCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x529560", Offset = "0x528560", VA = "0x180529560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x617220", Offset = "0x616220", VA = "0x180617220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey FOHFHOFKGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x29DD2D0", Offset = "0x29DC2D0", VA = "0x1829DD2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x29DE1F0", Offset = "0x29DD1F0", VA = "0x1829DE1F0")]
	public ABBFONMIMDI(int JGJJNCMMGMH, [Optional] GGKEDKJIIKB FCJDCNMAPFO, [Optional] IEqualityComparer<TKey> OOOJOLLKFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x29DE2C0", Offset = "0x29DD2C0", VA = "0x1829DE2C0")]
	public ABBFONMIMDI(int JGJJNCMMGMH, GGKEDKJIIKB FCJDCNMAPFO, TimeSpan AAJOIFBAMOB, [Optional] IEqualityComparer<TKey> OOOJOLLKFJP, [Optional] FGGKBOKOMCN BDFOFEJOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x29DE090", Offset = "0x29DD090", VA = "0x1829DE090")]
	public void PCJLPGFFDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x29DD7D0", Offset = "0x29DC7D0", VA = "0x1829DD7D0")]
	public void NJJMBFKJEFN(TKey PFPLGCLHCBM, TVal MNEBKBGCGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x29DDF10", Offset = "0x29DCF10", VA = "0x1829DDF10")]
	public bool OLMCAFOCELO(TKey PFPLGCLHCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x29DCBE0", Offset = "0x29DBBE0", VA = "0x1829DCBE0")]
	public bool BBDPMHCKIED(TKey KMFLLNGLEEN, out TVal MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x29DCF10", Offset = "0x29DBF10", VA = "0x1829DCF10")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x29DDE50", Offset = "0x29DCE50", VA = "0x1829DDE50")]
	private bool OJOOEHEFGCC(MEEOKKCHHOG CLOMJODBLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x29DDB10", Offset = "0x29DCB10", VA = "0x1829DDB10")]
	private void OGMNPAEFCPP(LinkedListNode<MEEOKKCHHOG> LOEAPABCPEN, TVal DMAHAENCAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x29DD500", Offset = "0x29DC500", VA = "0x1829DD500")]
	private void KNBNOKBALNC(TKey PFPLGCLHCBM, TVal MNEBKBGCGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x29DCF90", Offset = "0x29DBF90", VA = "0x1829DCF90")]
	private void GEHOCDMGCKN(MEEOKKCHHOG CLOMJODBLPN, TVal DMAHAENCAKE, int DCELEMAEIAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class CAICOBPEHOO<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly List<T> LOPGLBDJGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private HashSet<T> HCHNHGEAFND;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int MFJPBNLJGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1F29900", Offset = "0x1F28900", VA = "0x181F29900", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool DPIIMFJGHLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x446F50", Offset = "0x445F50", VA = "0x180446F50", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T FOHFHOFKGOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E8BAE0", Offset = "0x2E8AAE0", VA = "0x182E8BAE0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2E8BBD0", Offset = "0x2E8ABD0", VA = "0x182E8BBD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F1F270", Offset = "0x1F1E270", VA = "0x181F1F270", Slot = "11")]
	public void Add(T ANJHLAODMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B470", Offset = "0x2E8A470", VA = "0x182E8B470")]
	public bool AIIPKNFAMMG(T ANJHLAODMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B8D0", Offset = "0x2E8A8D0", VA = "0x182E8B8D0", Slot = "15")]
	public bool Remove(T ANJHLAODMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F296C0", Offset = "0x1F286C0", VA = "0x181F296C0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B9E0", Offset = "0x2E8A9E0", VA = "0x182E8B9E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B510", Offset = "0x2E8A510", VA = "0x182E8B510", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x10D0BD0", Offset = "0x10CFBD0", VA = "0x1810D0BD0", Slot = "13")]
	public bool Contains(T ANJHLAODMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B570", Offset = "0x2E8A570", VA = "0x182E8B570", Slot = "14")]
	public void CopyTo(T[] JEKGLADIOFP, int JGFBCCLPOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E419D0", Offset = "0x2E409D0", VA = "0x182E419D0", Slot = "6")]
	public int IndexOf(T ANJHLAODMAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B5A0", Offset = "0x2E8A5A0", VA = "0x182E8B5A0", Slot = "7")]
	public void Insert(int DKJKEBPJDEF, T ANJHLAODMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2E8B730", Offset = "0x2E8A730", VA = "0x182E8B730", Slot = "8")]
	public void RemoveAt(int DKJKEBPJDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2E8BA10", Offset = "0x2E8AA10", VA = "0x182E8BA10")]
	public CAICOBPEHOO()
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
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x2916920", Offset = "0x2915920", VA = "0x182916920")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3CF12F0", Offset = "0x3CF02F0", VA = "0x183CF12F0")]
		public SerializedGuid(in Guid MIJIHOBNLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3CF11F0", Offset = "0x3CF01F0", VA = "0x183CF11F0")]
		public static SerializedGuid PHGBJNGOAFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1270", Offset = "0x3CF0270", VA = "0x183CF1270")]
		public static SerializedGuid PNPDMMAPHJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CF10A0", Offset = "0x3CF00A0", VA = "0x183CF10A0")]
		public bool OPAODOHAHDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CF11D0", Offset = "0x3CF01D0", VA = "0x183CF11D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1130", Offset = "0x3CF0130", VA = "0x183CF1130", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0F10", Offset = "0x3CEFF10", VA = "0x183CF0F10", Slot = "7")]
		public bool Equals(SerializedGuid JNEOAAICJDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0FB0", Offset = "0x3CEFFB0", VA = "0x183CF0FB0", Slot = "0")]
		public override bool Equals(object BLBFEBCDCJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1090", Offset = "0x3CF0090", VA = "0x183CF1090", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0EE0", Offset = "0x3CEFEE0", VA = "0x183CF0EE0", Slot = "6")]
		public int CompareTo(SerializedGuid JNEOAAICJDJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class DLNJFNOGCIK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly Type NLKGNECKICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly string JDHLNMGINAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly bool BPLEBKLNPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool IHEHMHFCAHA;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEB90", Offset = "0x3CEDB90", VA = "0x183CEEB90")]
	public DLNJFNOGCIK(Type IKOJNBABMNG, string LMKCNFNKAHM, bool JLPFCHDPJLB = false, bool NCPOKEOJKCK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MEPIKPHDNMP<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T BFJAJBGCPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MKBHBJMFOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MEPIKPHDNMP<T> OHDEAIPNLNO(Action<T> INLJKHPFPNK);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MEPIKPHDNMP<T> LJIBBMFNEAP(Action<T> INLJKHPFPNK);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class MEJFAINLLNJ<T> : global::MEPIKPHDNMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private global::NDOOJGEDILP<T, T> KKPFAMNOGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private global::DLOGNCHNMOH<T> FOCLBNPIBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private global::DLOGNCHNMOH<string> ADGPIFLBFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private string FODJEJOHFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T EKJFGINBNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool HFGFGIPIEEO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T BFJAJBGCPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4227E0", Offset = "0x4217E0", VA = "0x1804227E0", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x27682D0", Offset = "0x27672D0", VA = "0x1827682D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MKBHBJMFOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x529440", Offset = "0x528440", VA = "0x180529440", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E48F40", Offset = "0x2E47F40", VA = "0x182E48F40")]
	private void NNIOLMMJEIP(T HKJJEIBDHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2E48FC0", Offset = "0x2E47FC0", VA = "0x182E48FC0", Slot = "4")]
	public global::MEPIKPHDNMP<T> OHDEAIPNLNO(Action<T> NIOCLGCBBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2E48F10", Offset = "0x2E47F10", VA = "0x182E48F10", Slot = "5")]
	public global::MEPIKPHDNMP<T> LJIBBMFNEAP(Action<T> INLJKHPFPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2E49040", Offset = "0x2E48040", VA = "0x182E49040")]
	public MEJFAINLLNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class ECPEFKIICFF
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class OEEMKCPIPBN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public global::MEPIKPHDNMP<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public global::GLKLOOCIFIF<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public OEEMKCPIPBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x26AB2A0", Offset = "0x26AA2A0", VA = "0x1826AB2A0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x25EAFC0", Offset = "0x25E9FC0", VA = "0x1825EAFC0")]
	public static global::GBEKKLLKIMD<T> JPPACOIBELJ<T>(this global::MEPIKPHDNMP<T> MECADLMMPKD, Action<T> GAMOMGCMAHI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public abstract class FGGKBOKOMCN
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private class NOKINIDLCKO : FGGKBOKOMCN
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static FGGKBOKOMCN HBMGMANAGKC
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3CF0B00", Offset = "0x3CEFB00", VA = "0x183CF0B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime COILLGKKDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3CF0AB0", Offset = "0x3CEFAB0", VA = "0x183CF0AB0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0BF0", Offset = "0x3CEFBF0", VA = "0x183CF0BF0")]
		public NOKINIDLCKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static FGGKBOKOMCN DIEJCHCEFJK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static FGGKBOKOMCN MHCLHFPDOMC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3CEFD70", Offset = "0x3CEED70", VA = "0x183CEFD70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime COILLGKKDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
	protected FGGKBOKOMCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class CJLMLAIABFH : global::PMDEILCNIKC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEB10", Offset = "0x3CEDB10", VA = "0x183CEEB10")]
	public CJLMLAIABFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class PMDEILCNIKC<T> : global::GHDHJGHMELD<T>, FNKOJOCEJME, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> FDDKAMNHPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::GBEKKLLKIMD<T> KMJMFDOCILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private BNIMEGFNNGI LINEGNHIALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1F224F0", Offset = "0x1F214F0", VA = "0x181F224F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2A007E0", Offset = "0x29FF7E0", VA = "0x182A007E0")]
	public PMDEILCNIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class OHPKHICFMMH<T> : global::GHDHJGHMELD<T>, FNKOJOCEJME, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> FDDKAMNHPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::GBEKKLLKIMD<T> KMJMFDOCILA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private BNIMEGFNNGI LINEGNHIALE
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1F224F0", Offset = "0x1F214F0", VA = "0x181F224F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DE60", Offset = "0x2E2CE60", VA = "0x182E2DE60")]
	public OHPKHICFMMH(Exception OGNEAGPEDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FNKOJOCEJME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	BNIMEGFNNGI KMJMFDOCILA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GHDHJGHMELD<T> : FNKOJOCEJME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> FDDKAMNHPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::GBEKKLLKIMD<T> KMJMFDOCILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class BFLOIPLFAHB<TTask, T> : global::GHDHJGHMELD<T>, FNKOJOCEJME, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ILJPEODDGIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::BFLOIPLFAHB<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public ILJPEODDGIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class INOAEACPJLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public ILJPEODDGIF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		public INOAEACPJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2792D40", Offset = "0x2791D40", VA = "0x182792D40")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static bool ABILDKBELKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly global::GLKLOOCIFIF<T> DMDCKLNLEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Task<T> IJHEPHBCONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly CancellationTokenSource KNGJAKBBJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private bool PCONJOHGKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private SynchronizationContext HPLFKEGCJNN;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> FDDKAMNHPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x422E70", Offset = "0x421E70", VA = "0x180422E70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::GBEKKLLKIMD<T> KMJMFDOCILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private BNIMEGFNNGI LINEGNHIALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LLPHNPLGNOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x51CE00", Offset = "0x51BE00", VA = "0x18051CE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2790C60", Offset = "0x278FC60", VA = "0x182790C60")]
	static BFLOIPLFAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2790F40", Offset = "0x278FF40", VA = "0x182790F40")]
	protected BFLOIPLFAHB(TTask IJHEPHBCONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2790720", Offset = "0x278F720", VA = "0x182790720", Slot = "1")]
	~BFLOIPLFAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2790650", Offset = "0x278F650", VA = "0x182790650", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2790A70", Offset = "0x278FA70", VA = "0x182790A70")]
	private void JPMIADIJNBP(bool FOOGLHAMBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KELKKCDBEIA(TTask HAKEGFKPKFL);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void HOKMMCOOMPC();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x27905C0", Offset = "0x278F5C0", VA = "0x1827905C0")]
	protected void AJCDMAHBFOK(T HKJJEIBDHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2790BE0", Offset = "0x278FBE0", VA = "0x182790BE0")]
	protected void PHMPIGFNFFC(string FODJEJOHFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2790860", Offset = "0x278F860", VA = "0x182790860")]
	[CompilerGenerated]
	private void GGMEFKHDABF(object LLLDDABNBON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BLNLPLONACP<T> : IEnumerable<global::BLNLPLONACP<T>.JHFJCCGGLAJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct JHFJCCGGLAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public T MNEBKBGCGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int DKJKEBPJDEF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class FFFLFDJIHEC : IEnumerator<JHFJCCGGLAJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private global::BLNLPLONACP<T> NLDJGAIFJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int DKJKEBPJDEF;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2BB1450", Offset = "0x2BB0450", VA = "0x182BB1450", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public JHFJCCGGLAJ PNMLNCLEENN
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2E8C370", Offset = "0x2E8B370", VA = "0x182E8C370", Slot = "4")]
			get
			{
				return default(JHFJCCGGLAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x84DAC0", Offset = "0x84CAC0", VA = "0x18084DAC0")]
		public FFFLFDJIHEC(global::BLNLPLONACP<T> NLDJGAIFJJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2E8C2E0", Offset = "0x2E8B2E0", VA = "0x182E8C2E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x84DAB0", Offset = "0x84CAB0", VA = "0x18084DAB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7CCD00", Offset = "0x7CBD00", VA = "0x1807CCD00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private struct NDLDAAEJBAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public bool FCJOLFKJEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public T MNEBKBGCGHD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private const int LEANGFMDCCN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Dictionary<T, int> KODACKLEIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NDLDAAEJBAP[] EKELGLLDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int GJLIKDPOMAN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int MFJPBNLJGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2E8A0E0", Offset = "0x2E890E0", VA = "0x182E8A0E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2E89930", Offset = "0x2E88930", VA = "0x182E89930")]
	public static global::BLNLPLONACP<T> ACKNABFDKPP(JHFJCCGGLAJ[] NACIKBMJLCF, bool IJHCJMOBIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2E8A1D0", Offset = "0x2E891D0", VA = "0x182E8A1D0")]
	public BLNLPLONACP(int JGJJNCMMGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2E8A110", Offset = "0x2E89110", VA = "0x182E8A110")]
	public int MNKNALEAFOM(T MNEBKBGCGHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2E8A070", Offset = "0x2E89070", VA = "0x182E8A070")]
	public T JPPACOIBELJ(int DKJKEBPJDEF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2E89CF0", Offset = "0x2E88CF0", VA = "0x182E89CF0")]
	public bool AIIPKNFAMMG(T MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2E89D10", Offset = "0x2E88D10", VA = "0x182E89D10")]
	public bool AIIPKNFAMMG(T MNEBKBGCGHD, int DKJKEBPJDEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2E89EE0", Offset = "0x2E88EE0", VA = "0x182E89EE0")]
	public JHFJCCGGLAJ[] FNHJOCFLGMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2E8A020", Offset = "0x2E89020", VA = "0x182E8A020")]
	private int GNJFIHNPJCJ(int OFGNLHOGGCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2E8A160", Offset = "0x2E89160", VA = "0x182E8A160", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2E8A160", Offset = "0x2E89160", VA = "0x182E8A160", Slot = "4")]
	private IEnumerator<JHFJCCGGLAJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class HBFMDFBHGPH<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private List<T> PGLIDEJNMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<T> ADLKFJHCDEJ;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x359AEB0", Offset = "0x3599EB0", VA = "0x18359AEB0")]
	public HBFMDFBHGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x359AD50", Offset = "0x3599D50", VA = "0x18359AD50")]
	public HBFMDFBHGPH(int JGJJNCMMGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x359AC50", Offset = "0x3599C50", VA = "0x18359AC50")]
	public T POFEDOPAOGJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x359AB30", Offset = "0x3599B30", VA = "0x18359AB30")]
	public void AMAKBJMLEKE(T OCLDMPCNKOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class HGDEAIDKDHJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	protected struct GBFHFMJBAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public T BFJAJBGCPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int DGFPIDJJEEF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected readonly List<GBFHFMJBAAF> KONMLHBKNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private T AFHBHBNLJDE;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MFJPBNLJGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1F29900", Offset = "0x1F28900", VA = "0x181F29900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x359AFF0", Offset = "0x3599FF0", VA = "0x18359AFF0")]
	public bool FABHJNJNFIC(T MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x359AEE0", Offset = "0x3599EE0", VA = "0x18359AEE0")]
	public void AIJJCOHLNPC(T MNEBKBGCGHD, int OPELIALOMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x359B4B0", Offset = "0x359A4B0", VA = "0x18359B4B0")]
	public bool OLMCAFOCELO(T MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x359B240", Offset = "0x359A240", VA = "0x18359B240")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x359AF60", Offset = "0x3599F60", VA = "0x18359AF60")]
	public T DIJIGIOINMK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x359B2A0", Offset = "0x359A2A0", VA = "0x18359B2A0")]
	private void JOCJCMMOBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x359B5D0", Offset = "0x359A5D0", VA = "0x18359B5D0")]
	public HGDEAIDKDHJ()
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
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x21EAFE0", Offset = "0x21E9FE0", VA = "0x1821EAFE0", Slot = "4")]
		public virtual T EMKPOJEFDGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x10D8140", Offset = "0x10D7140", VA = "0x1810D8140")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class EAEFJIMPKEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Dictionary<byte, DPGOPOLCHKK> AHNPKHFIOME;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DPGOPOLCHKK BELFPCHDKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x423200", Offset = "0x422200", VA = "0x180423200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x446570", Offset = "0x445570", VA = "0x180446570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 HHIHKIJBENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9E3BE0", Offset = "0x9E2BE0", VA = "0x1809E3BE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1F305D0", Offset = "0x1F2F5D0", VA = "0x181F305D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector2 ILPJGIJAOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6A2670", Offset = "0x6A1670", VA = "0x1806A2670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 BHBKKDFPKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xDDB960", Offset = "0xDDA960", VA = "0x180DDB960")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xDDB980", Offset = "0xDDA980", VA = "0x180DDB980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int ENLEKMLIANP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x470220", Offset = "0x46F220", VA = "0x180470220")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x495390", Offset = "0x494390", VA = "0x180495390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3CEF7A0", Offset = "0x3CEE7A0", VA = "0x183CEF7A0")]
	public EAEFJIMPKEL(Bounds OEEDIGHKDHJ, Vector2[] NABKKKKCFBE, int AECCECKDDJO, byte OFGNLHOGGCK, float PMGBNPFPLHG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3CEF200", Offset = "0x3CEE200", VA = "0x183CEF200")]
	public DPGOPOLCHKK MEHDMLALINK(byte DKJKEBPJDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3CEF000", Offset = "0x3CEE000", VA = "0x183CEF000")]
	public void AMLJIBCPNIA(Vector3 EDLMFIJACDL, float COFCJJEKPGD, float IAFJHHNADLG, ref List<byte> FOGHEDMHHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3CEF780", Offset = "0x3CEE780", VA = "0x183CEF780")]
	public void PDMNONHPILI(DPGOPOLCHKK.AOJDIIENLGB IKNJFFIINNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3CEF0E0", Offset = "0x3CEE0E0", VA = "0x183CEF0E0")]
	private DPGOPOLCHKK KBNFDGMNJGB(byte DKJKEBPJDEF, DPGOPOLCHKK.ALDIPJAFEIG EABIHHELKDG, DPGOPOLCHKK MLOCIIICABC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3CEF260", Offset = "0x3CEE260", VA = "0x183CEF260")]
	private void OEHAPMCGBHO(DPGOPOLCHKK MLOCIIICABC, Vector2[] NABKKKKCFBE, int PEDMIJPKPOI, int PFHDOOIMLNE, int AJCOLCIAFLM, int OCGPDENIPAH, float PMGBNPFPLHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class DPGOPOLCHKK
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum ALDIPJAFEIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum AOJDIIENLGB
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
	public byte LEFAOGHHBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Vector3 BNBBLKAMBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Vector3 FAKLEMDNDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Vector3 AHCJAEDIHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 EPJFFHILFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public ALDIPJAFEIG GBJPBHJKCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public DPGOPOLCHKK BCAACCDFMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public List<DPGOPOLCHKK> IIJAEKELAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool ABGNMICACDM;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEFB0", Offset = "0x3CEDFB0", VA = "0x183CEEFB0")]
	public DPGOPOLCHKK(byte KOCMKCCBGOB, ALDIPJAFEIG EABIHHELKDG, DPGOPOLCHKK MLOCIIICABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEE80", Offset = "0x3CEDE80", VA = "0x183CEEE80")]
	public void FEGCJNOKFBA(DPGOPOLCHKK LNCFPOEAMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10")]
	public void PDMNONHPILI(int HEOMDJFMPEK, AOJDIIENLGB IKNJFFIINNN, int FJAHNNKHNLB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEBF0", Offset = "0x3CEDBF0", VA = "0x183CEEBF0")]
	public void AMLJIBCPNIA(List<byte> FOGHEDMHHPI, Vector3 EDLMFIJACDL, float COFCJJEKPGD, float IAFJHHNADLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEF10", Offset = "0x3CEDF10", VA = "0x183CEEF10")]
	public bool MDDJLIEICJP(Vector3 KCOCHMFCDKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEF70", Offset = "0x3CEDF70", VA = "0x183CEEF70")]
	public bool PANBPCDNCHD(Vector3 KCOCHMFCDKN, float MMPNIBOJKEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class MOPHAPIAJAM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int JGJJNCMMGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int NGCCDHBDKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<T> KCAOMPAODIL;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public T IFHIKEELACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2E50790", Offset = "0x2E4F790", VA = "0x182E50790")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T BPMEHCPPNPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2E506B0", Offset = "0x2E4F6B0", VA = "0x182E506B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T BIMELNPFCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2E50860", Offset = "0x2E4F860", VA = "0x182E50860")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2E50970", Offset = "0x2E4F970", VA = "0x182E50970")]
	public MOPHAPIAJAM(int JGJJNCMMGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2E50500", Offset = "0x2E4F500", VA = "0x182E50500")]
	public void AIJJCOHLNPC(T IIDGMEBPPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2E50810", Offset = "0x2E4F810", VA = "0x182E50810")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2E50920", Offset = "0x2E4F920", VA = "0x182E50920")]
	public void PGBIFEDEING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2E50850", Offset = "0x2E4F850", VA = "0x182E50850")]
	public void HCNMPJMCKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class AJCLNBBPAED<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct MAMHLMKKLGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int DGFPIDJJEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public T BFJAJBGCPNN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Dictionary<object, MAMHLMKKLGO> APLAEJEJHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private T FAAAACLMECM;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T DBMPCHDDJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9E3BE0", Offset = "0x9E2BE0", VA = "0x1809E3BE0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1F305D0", Offset = "0x1F2F5D0", VA = "0x181F305D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool PNLMMDBHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x303AF30", Offset = "0x3039F30", VA = "0x18303AF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object AICKOICAGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x423230", Offset = "0x422230", VA = "0x180423230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4260F0", Offset = "0x4250F0", VA = "0x1804260F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x303FC20", Offset = "0x303EC20", VA = "0x18303FC20")]
	public bool KNBNOKBALNC(T MNEBKBGCGHD, object CCGNJIBBJFD, int OPELIALOMEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x303A930", Offset = "0x3039930", VA = "0x18303A930")]
	public bool AMKPJGJHILO(object CCGNJIBBJFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x303AA80", Offset = "0x3039A80", VA = "0x18303AA80")]
	public bool BBDPMHCKIED(object CCGNJIBBJFD, out T MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E1F0", Offset = "0x1F2D1F0", VA = "0x181F2E1F0")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x303AF60", Offset = "0x3039F60", VA = "0x18303AF60")]
	private bool GNHEHEIFADH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3040370", Offset = "0x303F370", VA = "0x183040370")]
	public AJCLNBBPAED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class CEMMKLLDIGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Dictionary<object, float> APLAEJEJHHA;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float MDKAHNDAEOA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x692090", Offset = "0x691090", VA = "0x180692090")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6920C0", Offset = "0x6910C0", VA = "0x1806920C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE910", Offset = "0x3CED910", VA = "0x183CEE910")]
	public void KNBNOKBALNC(float MNEBKBGCGHD, object CCGNJIBBJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE8B0", Offset = "0x3CED8B0", VA = "0x183CEE8B0")]
	public void AMKPJGJHILO(object CCGNJIBBJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3CEE980", Offset = "0x3CED980", VA = "0x183CEE980")]
	private void LLKOOIAGGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3CEEAA0", Offset = "0x3CEDAA0", VA = "0x183CEEAA0")]
	public CEMMKLLDIGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class KIEOLBAKDII
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class MOCCEEDMLJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly string GMPLNEGOMNI;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
		private MOCCEEDMLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x52A960", Offset = "0x529960", VA = "0x18052A960")]
		public MOCCEEDMLJB(string GMPLNEGOMNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0760", Offset = "0x3CEF760", VA = "0x183CF0760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JDAIDOFPBLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x41F000", Offset = "0x41E000", VA = "0x18041F000")]
		public JDAIDOFPBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0340", Offset = "0x3CEF340", VA = "0x183CF0340")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly HashSet<object> IONGMMDEMON;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool LCCHFMAIAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0560", Offset = "0x3CEF560", VA = "0x183CF0560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3CF03F0", Offset = "0x3CEF3F0", VA = "0x183CF03F0")]
	public void AIJJCOHLNPC(object CCGNJIBBJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0500", Offset = "0x3CEF500", VA = "0x183CF0500")]
	public void OLMCAFOCELO(object CCGNJIBBJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3CF04A0", Offset = "0x3CEF4A0", VA = "0x183CF04A0")]
	public bool FABHJNJNFIC(object CCGNJIBBJFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0450", Offset = "0x3CEF450", VA = "0x183CF0450")]
	public void CIDBNPDNADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3CF05A0", Offset = "0x3CEF5A0", VA = "0x183CF05A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3CF0700", Offset = "0x3CEF700", VA = "0x183CF0700")]
	public KIEOLBAKDII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class JLLLJLMMNJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private struct AMKFDNGEOGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float LOPAKHFOHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public T BFJAJBGCPNN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<object, AMKFDNGEOGK> APLAEJEJHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private T MIENAHKHKDA;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T GGCAJJCGDMN
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1B62CC0", Offset = "0x1B61CC0", VA = "0x181B62CC0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1F305B0", Offset = "0x1F2F5B0", VA = "0x181F305B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object KAJGEJKMGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4227E0", Offset = "0x4217E0", VA = "0x1804227E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4DF530", Offset = "0x4DE530", VA = "0x1804DF530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool PNLMMDBHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1F2E1B0", Offset = "0x1F2D1B0", VA = "0x181F2E1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1F302E0", Offset = "0x1F2F2E0", VA = "0x181F302E0")]
	public bool KNBNOKBALNC(T MNEBKBGCGHD, object CCGNJIBBJFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DE40", Offset = "0x1F2CE40", VA = "0x181F2DE40")]
	public bool AMKPJGJHILO(object CCGNJIBBJFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E1F0", Offset = "0x1F2D1F0", VA = "0x181F2E1F0")]
	public void FMCAHCCFHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DEA0", Offset = "0x1F2CEA0", VA = "0x181F2DEA0")]
	public bool BBDPMHCKIED(object CCGNJIBBJFD, out T MNEBKBGCGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1F2E220", Offset = "0x1F2D220", VA = "0x181F2E220")]
	private bool GNHEHEIFADH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x1F305F0", Offset = "0x1F2F5F0", VA = "0x181F305F0")]
	public JLLLJLMMNJC()
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
