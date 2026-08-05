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
public class AGLGHPOGGBL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E4C10", Offset = "0x4E3A10", VA = "0x1804E4C10")]
	public AGLGHPOGGBL()
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
		[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x41FE60", Offset = "0x41EC60", VA = "0x18041FE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x41F450", Offset = "0x41E250", VA = "0x18041F450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "4")]
	public virtual void AOGNDIBDLLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
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
	[AGLGHPOGGBL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x32D9340", Offset = "0x32D8140", VA = "0x1832D9340", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x32D8E80", Offset = "0x32D7C80", VA = "0x1832D8E80", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x32D9940", Offset = "0x32D8740", VA = "0x1832D9940")]
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
	private sealed class GJGMIBFGGCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public GJGMIBFGGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8620", Offset = "0x2BA7420", VA = "0x182BA8620")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[AGLGHPOGGBL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2BA75B0", Offset = "0x2BA63B0", VA = "0x182BA75B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2BA75E0", Offset = "0x2BA63E0", VA = "0x182BA75E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7500", Offset = "0x2BA6300", VA = "0x182BA7500", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey JEAOBHPGMKJ]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7530", Offset = "0x2BA6330", VA = "0x182BA7530", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7410", Offset = "0x2BA6210", VA = "0x182BA7410", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6C80", Offset = "0x2BA5A80", VA = "0x182BA6C80", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA65F0", Offset = "0x2BA53F0", VA = "0x182BA65F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6160", Offset = "0x2BA4F60", VA = "0x182BA6160", Slot = "14")]
	protected virtual string FAJAFLEJEAJ(TKeyVal IBHDBNAHGCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2030BE0", Offset = "0x202F9E0", VA = "0x182030BE0", Slot = "4")]
	public bool ContainsKey(TKey JEAOBHPGMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7310", Offset = "0x2BA6110", VA = "0x182BA7310", Slot = "5")]
	public bool TryGetValue(TKey JEAOBHPGMKJ, out TVal NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2BA61F0", Offset = "0x2BA4FF0", VA = "0x182BA61F0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BA61F0", Offset = "0x2BA4FF0", VA = "0x182BA61F0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7340", Offset = "0x2BA6140", VA = "0x182BA7340")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ANADGAJIDKJ : IEnumerator<object>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x583720", Offset = "0x582520", VA = "0x180583720")]
		[DebuggerHidden]
		public ANADGAJIDKJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4FB0", Offset = "0x3CC3DB0", VA = "0x183CC4FB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4E60", Offset = "0x3CC3C60", VA = "0x183CC4E60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5020", Offset = "0x3CC3E20", VA = "0x183CC5020")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4F60", Offset = "0x3CC3D60", VA = "0x183CC4F60", Slot = "8")]
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
	private static HashSet<GameObject> ABLKMGMIOCM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC62B0", Offset = "0x3CC50B0", VA = "0x183CC62B0")]
	public static void RegisterDontDestroyOnLoad(GameObject LFAMFABNHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC60D0", Offset = "0x3CC4ED0", VA = "0x183CC60D0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6350", Offset = "0x3CC5150", VA = "0x183CC6350")]
	[IteratorStateMachine(typeof(ANADGAJIDKJ))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "6")]
	protected virtual void LJFBFJPLGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6410", Offset = "0x3CC5210", VA = "0x183CC6410")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ADPIMEONOEB
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA8A0", Offset = "0x1CC96A0", VA = "0x181CCA8A0")]
	public static void PMNPJODPBCB<T>(this T ECDJLNJFPPK) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4D80", Offset = "0x3CC3B80", VA = "0x183CC4D80")]
	public static void PMNPJODPBCB(this GameObject HKJJBODHHGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : MonoBehaviour where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static TImpl CNGBIJGBIDB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	protected static TImpl LELDKBAOHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAA2520", Offset = "0xAA1320", VA = "0x180AA2520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1699310", Offset = "0x1698110", VA = "0x181699310", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x16997E0", Offset = "0x16985E0", VA = "0x1816997E0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1699A30", Offset = "0x1698830", VA = "0x181699A30")]
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
	public GameObject MKJMMACGHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xC89D80", Offset = "0xC88B80", VA = "0x180C89D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6860", Offset = "0x3CC5660", VA = "0x183CC6860")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6A80", Offset = "0x3CC5880", VA = "0x183CC6A80")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0xAA44D0", Offset = "0xAA32D0", VA = "0x180AA44D0")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static T CNGBIJGBIDB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static T LELDKBAOHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA2520", Offset = "0xAA1320", VA = "0x180AA2520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool CGCOEAGALAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x32D9F10", Offset = "0x32D8D10", VA = "0x1832D9F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x32D99D0", Offset = "0x32D87D0", VA = "0x1832D99D0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x32D9D50", Offset = "0x32D8B50", VA = "0x1832D9D50", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1699A30", Offset = "0x1698830", VA = "0x181699A30")]
	public SingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LLAEDGJCDHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class GBKKPGIOGEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public GBKKPGIOGEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x20311B0", Offset = "0x202FFB0", VA = "0x1820311B0")]
		internal bool <GetSamples>b__0(global::NBDABCHLADD<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float MMILIIGCAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float DOHMFGAFCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::NBDABCHLADD<float, T>> MEGGJJHJBGD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int HFHIJLBDBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x20356F0", Offset = "0x20344F0", VA = "0x1820356F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2035770", Offset = "0x2034570", VA = "0x182035770")]
	public LLAEDGJCDHF(float KDLMENFKKON, float BGAILOHLFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2035450", Offset = "0x2034250", VA = "0x182035450")]
	public bool IENLIAEIAFO(float ICFHIECDJLN, T NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2034C90", Offset = "0x2033A90", VA = "0x182034C90")]
	public IEnumerable<T> HMCCONFLJBH(float ICFHIECDJLN, [Optional] float? EJMCPHMCGDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2034C60", Offset = "0x2033A60", VA = "0x182034C60")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x20355B0", Offset = "0x20343B0", VA = "0x1820355B0")]
	private void KEBCONHEFGH(float ICFHIECDJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class IPNJKDOMPNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct KLMCADGNNKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T FJILFHOHJHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float EDNJFDNEOBG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float NBFNGLGGAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> GHFDLGJCOBL;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int KDDDKFBCGMB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private KLMCADGNNKI[] HICCBIOADHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int JAFOFLPDMEO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public float HGKEEPGHJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xADECA0", Offset = "0xADDAA0", VA = "0x180ADECA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xADEB30", Offset = "0xADD930", VA = "0x180ADEB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1699180", Offset = "0x1697F80", VA = "0x181699180")]
	public IPNJKDOMPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x16991B0", Offset = "0x1697FB0", VA = "0x1816991B0")]
	public IPNJKDOMPNH(int PGNDNMPLNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1698C70", Offset = "0x1697A70", VA = "0x181698C70")]
	public void KMKDPFABOFI(float ICFHIECDJLN, T NAHKACCDOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16982E0", Offset = "0x16970E0", VA = "0x1816982E0")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1698580", Offset = "0x1697380", VA = "0x181698580")]
	public bool CKKKOIOILNF(float GBGHKHPBBFG, float EBEOFAIEDKP, out T NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1698E20", Offset = "0x1697C20", VA = "0x181698E20")]
	public bool LMAAGPDENAO(float GBGHKHPBBFG, float EBEOFAIEDKP, out T NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1698B20", Offset = "0x1697920", VA = "0x181698B20")]
	public void KFPLPNHCPBK(float GBGHKHPBBFG, float EBEOFAIEDKP, List<T> AFLHEGECPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1698990", Offset = "0x1697790", VA = "0x181698990")]
	private int KELPHFCJDOE(int AMPJAMLAHMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1698950", Offset = "0x1697750", VA = "0x181698950")]
	private void FFECKJPDIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NFANPBCCMFA();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LJKALNIIEGL(T NAHKACCDOIA, float MJGPGFAACCA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T MACJGLHDKMF(T EHBHGOKLOCE, T PCCAHCCHHEK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JBOBKHNJJOK(T EHBHGOKLOCE, T PCCAHCCHHEK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JKEGJMFHCPJ : global::IPNJKDOMPNH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6740", Offset = "0x3CC5540", VA = "0x183CC6740", Slot = "4")]
	protected override Vector3 NFANPBCCMFA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3CC65F0", Offset = "0x3CC53F0", VA = "0x183CC65F0", Slot = "5")]
	protected override Vector3 LJKALNIIEGL(Vector3 NAHKACCDOIA, float MJGPGFAACCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6690", Offset = "0x3CC5490", VA = "0x183CC6690", Slot = "6")]
	protected override Vector3 MACJGLHDKMF(Vector3 EHBHGOKLOCE, Vector3 PCCAHCCHHEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6580", Offset = "0x3CC5380", VA = "0x183CC6580", Slot = "7")]
	protected override Vector3 JBOBKHNJJOK(Vector3 EHBHGOKLOCE, Vector3 PCCAHCCHHEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3CC67B0", Offset = "0x3CC55B0", VA = "0x183CC67B0")]
	public JKEGJMFHCPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HDEAKEOAHOP
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1B09FA0", Offset = "0x1B08DA0", VA = "0x181B09FA0")]
	public static global::NBDABCHLADD<T1, T2> IHJCHFBBHFH<T1, T2>(T1 KFLLGHOHOCD, T2 HECKCFOPGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1B0A010", Offset = "0x1B08E10", VA = "0x181B0A010")]
	public static global::LLFLFGBODNO<T1, T2, T3> IHJCHFBBHFH<T1, T2, T3>(T1 KFLLGHOHOCD, T2 HECKCFOPGOI, T3 MDNMIKDFJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8F5680", Offset = "0x8F4480", VA = "0x1808F5680")]
	internal static int PGEJKALKLCE(int OBKEKJNELBH, int NFCOCLLBDDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8F5690", Offset = "0x8F4490", VA = "0x1808F5690")]
	internal static int PGEJKALKLCE(int OBKEKJNELBH, int NFCOCLLBDDO, int BDLENHDLOEJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NBDABCHLADD<T1, T2> : IComparable<global::NBDABCHLADD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 KIDCJDCDOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 APHLNLFJIFA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2D87CA0", Offset = "0x2D86AA0", VA = "0x182D87CA0")]
	public NBDABCHLADD(T1 KFLLGHOHOCD, T2 HECKCFOPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2D86610", Offset = "0x2D85410", VA = "0x182D86610", Slot = "4")]
	public int CompareTo(global::NBDABCHLADD<T1, T2> GGDENAHKICG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2D86E00", Offset = "0x2D85C00", VA = "0x182D86E00", Slot = "0")]
	public override bool Equals(object GGDENAHKICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2D87350", Offset = "0x2D86150", VA = "0x182D87350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2D879C0", Offset = "0x2D867C0", VA = "0x182D879C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LLFLFGBODNO<T1, T2, T3> : IComparable<global::LLFLFGBODNO<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 KIDCJDCDOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 APHLNLFJIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 CNECPFKBDNM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2038CC0", Offset = "0x2037AC0", VA = "0x182038CC0")]
	public LLFLFGBODNO(T1 KFLLGHOHOCD, T2 HECKCFOPGOI, T3 MDNMIKDFJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x20384E0", Offset = "0x20372E0", VA = "0x1820384E0", Slot = "4")]
	public int CompareTo(global::LLFLFGBODNO<T1, T2, T3> GGDENAHKICG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x20386E0", Offset = "0x20374E0", VA = "0x1820386E0", Slot = "0")]
	public override bool Equals(object GGDENAHKICG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2038940", Offset = "0x2037740", VA = "0x182038940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2038A40", Offset = "0x2037840", VA = "0x182038A40", Slot = "3")]
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
	public T FJILFHOHJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x446670", Offset = "0x445470", VA = "0x180446670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4BA620", Offset = "0x4B9420", VA = "0x1804BA620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public float CLGPBMBMLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBE9220", Offset = "0xBE8020", VA = "0x180BE9220")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x356D440", Offset = "0x356C240", VA = "0x18356D440")]
	public T GLBJMMCEDBD(float MJGPGFAACCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x356D850", Offset = "0x356C650", VA = "0x18356D850")]
	public T GNLCAAKKHCO(float MJGPGFAACCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EBHNMGAHFOL(T EHBHGOKLOCE, T PCCAHCCHHEK, float MJGPGFAACCA);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6010", Offset = "0x3CC4E10", VA = "0x183CC6010", Slot = "4")]
	protected override float EBHNMGAHFOL(float EHBHGOKLOCE, float PCCAHCCHHEK, float MJGPGFAACCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6090", Offset = "0x3CC4E90", VA = "0x183CC6090")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7D40", Offset = "0x3CC6B40", VA = "0x183CC7D40", Slot = "4")]
	protected override Vector3 EBHNMGAHFOL(Vector3 EHBHGOKLOCE, Vector3 PCCAHCCHHEK, float MJGPGFAACCA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7E00", Offset = "0x3CC6C00", VA = "0x183CC7E00")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE8F0", Offset = "0x3CAD6F0", VA = "0x183CAE8F0", Slot = "4")]
	protected override Color EBHNMGAHFOL(Color EHBHGOKLOCE, Color PCCAHCCHHEK, float MJGPGFAACCA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3CC50E0", Offset = "0x3CC3EE0", VA = "0x183CC50E0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DefaultMember("Item")]
public class EFDBDMNAABI<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private global::EFDBDMNAABI<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0xADECA0", Offset = "0xADDAA0", VA = "0x180ADECA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2BA8480", Offset = "0x2BA7280", VA = "0x182BA8480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2BA8590", Offset = "0x2BA7390", VA = "0x182BA8590")]
		public Enumerator(global::EFDBDMNAABI<T> AFLHEGECPHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7E10", Offset = "0x2BA6C10", VA = "0x182BA7E10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7F90", Offset = "0x2BA6D90", VA = "0x182BA7F90", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7960", Offset = "0x2BA6760", VA = "0x182BA7960")]
		private void BFNOLFPHPFJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private T[] NJAJDJFIJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int MMOFFBNAIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int JFPPEEAPFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int HCIEIPIJONO;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HMLDEJFKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0F20", Offset = "0x2B9FD20", VA = "0x182BA0F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public T OMCHAOCHNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0460", Offset = "0x2B9F260", VA = "0x182BA0460")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2BA06E0", Offset = "0x2B9F4E0", VA = "0x182BA06E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2BA11E0", Offset = "0x2B9FFE0", VA = "0x182BA11E0")]
	public EFDBDMNAABI(int CPENFPNBDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0D00", Offset = "0x2B9FB00", VA = "0x182BA0D00")]
	public void KMKDPFABOFI(T MJGPGFAACCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2B9FF00", Offset = "0x2B9ED00", VA = "0x182B9FF00")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA07F0", Offset = "0x2B9F5F0", VA = "0x182BA07F0")]
	public void ILNJHKNNFHM(int NCDECDGGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA01C0", Offset = "0x2B9EFC0", VA = "0x182BA01C0")]
	public void CECNMNICIDA(T[] HICCBIOADHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0FB0", Offset = "0x2B9FDB0", VA = "0x182BA0FB0")]
	public Enumerator PBBKGKLPJOJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1050", Offset = "0x2B9FE50", VA = "0x182BA1050", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1050", Offset = "0x2B9FE50", VA = "0x182BA1050", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0880", Offset = "0x2B9F680", VA = "0x182BA0880")]
	private int KJKCNMBJCHL(int LEPJFDHOFMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2BA07C0", Offset = "0x2B9F5C0", VA = "0x182BA07C0")]
	private int HJKGKGEJDHH(int LEPJFDHOFMF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class MOGOPABBGNA
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
	protected MOGOPABBGNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class LCDPOFIHHBJ<T> : MOGOPABBGNA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	protected struct KCACKJLAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum CPFFNFJBHNP
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
		public CPFFNFJBHNP HOBGMLIPHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public T PBMHOLJNIIA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int NEPCJBBBMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly bool HJPIKODAMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	protected readonly bool BHBPFIKAPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	protected List<T> IDEMPOBKFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<KCACKJLAJDJ> IDFHKOCDJHJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JOMFIMBKIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2327800", Offset = "0x2326600", VA = "0x182327800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2327840", Offset = "0x2326640", VA = "0x182327840")]
	protected LCDPOFIHHBJ(bool BHBPFIKAPEN, bool HJPIKODAMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2327760", Offset = "0x2326560", VA = "0x182327760")]
	protected bool MHNAIPNIAPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2327240", Offset = "0x2326040", VA = "0x182327240")]
	protected void BGIEKBEDODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x23275B0", Offset = "0x23263B0", VA = "0x1823275B0")]
	protected void LNCHDDBDHKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2292D10", Offset = "0x2291B10", VA = "0x182292D10")]
	private static void DOOHCJHPKFL<U>(ref List<U> NJOMLILJNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2327460", Offset = "0x2326260", VA = "0x182327460", Slot = "4")]
	public void KMKDPFABOFI(T PBMHOLJNIIA, bool LAEEIBDJBAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2327320", Offset = "0x2326120", VA = "0x182327320", Slot = "5")]
	public void IPBNHGALMCN(T PBMHOLJNIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2327110", Offset = "0x2325F10", VA = "0x182327110")]
	public void BANKNLGGGFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class NBFJNPGBICP : global::LCDPOFIHHBJ<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6DD0", Offset = "0x3CC5BD0", VA = "0x183CC6DD0")]
	public NBFJNPGBICP(bool BHBPFIKAPEN = false, bool HJPIKODAMJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6C20", Offset = "0x3CC5A20", VA = "0x183CC6C20")]
	public void NEJFELDLIDE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6B60", Offset = "0x3CC5960", VA = "0x183CC6B60")]
	public static NBFJNPGBICP EIJCHJNCJNI(NBFJNPGBICP HDDONHGOFDK, Action PBMHOLJNIIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6BC0", Offset = "0x3CC59C0", VA = "0x183CC6BC0")]
	public static NBFJNPGBICP IPNIBLMCLJC(NBFJNPGBICP HDDONHGOFDK, Action PBMHOLJNIIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KLFANELKCDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KMKDPFABOFI(Action<T> PBMHOLJNIIA, bool LAEEIBDJBAN = false);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPBNHGALMCN(Action<T> PBMHOLJNIIA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class NAMLIIIPNBG<T> : global::LCDPOFIHHBJ<Action<T>>, global::KLFANELKCDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x203C650", Offset = "0x203B450", VA = "0x18203C650")]
	public NAMLIIIPNBG(bool BHBPFIKAPEN = false, bool HJPIKODAMJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D834A0", Offset = "0x2D822A0", VA = "0x182D834A0")]
	public void NEJFELDLIDE(T MJGPGFAACCA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2041AB0", Offset = "0x20408B0", VA = "0x182041AB0")]
	public static global::NAMLIIIPNBG<T> EIJCHJNCJNI(global::NAMLIIIPNBG<T> HDDONHGOFDK, Action<T> PBMHOLJNIIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2041B50", Offset = "0x2040950", VA = "0x182041B50")]
	public static global::NAMLIIIPNBG<T> IPNIBLMCLJC(global::NAMLIIIPNBG<T> HDDONHGOFDK, Action<T> PBMHOLJNIIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FCGHIKAOJIO<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MOMPHOHCMGD<T, U> : global::LCDPOFIHHBJ<Action<T, U>>, global::FCGHIKAOJIO<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x203C650", Offset = "0x203B450", VA = "0x18203C650")]
	public MOMPHOHCMGD(bool BHBPFIKAPEN = false, bool HJPIKODAMJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D7FEA0", Offset = "0x2D7ECA0", VA = "0x182D7FEA0")]
	public void NEJFELDLIDE(T MJGPGFAACCA, U DLMLGGPMECK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2041AB0", Offset = "0x20408B0", VA = "0x182041AB0")]
	public static global::MOMPHOHCMGD<T, U> EIJCHJNCJNI(global::MOMPHOHCMGD<T, U> HDDONHGOFDK, Action<T, U> PBMHOLJNIIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2041B50", Offset = "0x2040950", VA = "0x182041B50")]
	public static global::MOMPHOHCMGD<T, U> IPNIBLMCLJC(global::MOMPHOHCMGD<T, U> HDDONHGOFDK, Action<T, U> PBMHOLJNIIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DPADDOEAHJF<T, U, V> : global::LCDPOFIHHBJ<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x203C650", Offset = "0x203B450", VA = "0x18203C650")]
	public DPADDOEAHJF(bool BHBPFIKAPEN = false, bool HJPIKODAMJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x322D980", Offset = "0x322C780", VA = "0x18322D980")]
	public void NEJFELDLIDE(T MJGPGFAACCA, U DLMLGGPMECK, V BNILMNCBHHH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2041AB0", Offset = "0x20408B0", VA = "0x182041AB0")]
	public static global::DPADDOEAHJF<T, U, V> EIJCHJNCJNI(global::DPADDOEAHJF<T, U, V> HDDONHGOFDK, Action<T, U, V> PBMHOLJNIIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2041B50", Offset = "0x2040950", VA = "0x182041B50")]
	public static global::DPADDOEAHJF<T, U, V> IPNIBLMCLJC(global::DPADDOEAHJF<T, U, V> HDDONHGOFDK, Action<T, U, V> PBMHOLJNIIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface IINDOEEMNBP<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class CHMBJKGDMFF<T, U, V, W> : global::LCDPOFIHHBJ<Action<T, U, V, W>>, global::IINDOEEMNBP<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x203C650", Offset = "0x203B450", VA = "0x18203C650")]
	public CHMBJKGDMFF(bool BHBPFIKAPEN = false, bool HJPIKODAMJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x21C3790", Offset = "0x21C2590", VA = "0x1821C3790")]
	public void NEJFELDLIDE(T MJGPGFAACCA, U DLMLGGPMECK, V BNILMNCBHHH, W FJEMJKEANGO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2041AB0", Offset = "0x20408B0", VA = "0x182041AB0")]
	public static global::CHMBJKGDMFF<T, U, V, W> EIJCHJNCJNI(global::CHMBJKGDMFF<T, U, V, W> HDDONHGOFDK, Action<T, U, V, W> PBMHOLJNIIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2041B50", Offset = "0x2040950", VA = "0x182041B50")]
	public static global::CHMBJKGDMFF<T, U, V, W> IPNIBLMCLJC(global::CHMBJKGDMFF<T, U, V, W> HDDONHGOFDK, Action<T, U, V, W> PBMHOLJNIIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class IEIFNMLIKAN<T, U, V, W, X> : global::LCDPOFIHHBJ<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x203C650", Offset = "0x203B450", VA = "0x18203C650")]
	public IEIFNMLIKAN(bool BHBPFIKAPEN = false, bool HJPIKODAMJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD520", Offset = "0x2BDC320", VA = "0x182BDD520")]
	public void NEJFELDLIDE(T MJGPGFAACCA, U DLMLGGPMECK, V BNILMNCBHHH, W FJEMJKEANGO, X NELLMJBPELE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2041AB0", Offset = "0x20408B0", VA = "0x182041AB0")]
	public static global::IEIFNMLIKAN<T, U, V, W, X> EIJCHJNCJNI(global::IEIFNMLIKAN<T, U, V, W, X> HDDONHGOFDK, Action<T, U, V, W, X> PBMHOLJNIIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2041B50", Offset = "0x2040950", VA = "0x182041B50")]
	public static global::IEIFNMLIKAN<T, U, V, W, X> IPNIBLMCLJC(global::IEIFNMLIKAN<T, U, V, W, X> HDDONHGOFDK, Action<T, U, V, W, X> PBMHOLJNIIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class KJOKEMCHDHC<T, U, V, W, X, Y> : global::LCDPOFIHHBJ<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x203C650", Offset = "0x203B450", VA = "0x18203C650")]
	public KJOKEMCHDHC(bool BHBPFIKAPEN = false, bool HJPIKODAMJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2323E80", Offset = "0x2322C80", VA = "0x182323E80")]
	public void NEJFELDLIDE(T MJGPGFAACCA, U DLMLGGPMECK, V BNILMNCBHHH, W FJEMJKEANGO, X NELLMJBPELE, Y CFLEFCHLBDP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2041AB0", Offset = "0x20408B0", VA = "0x182041AB0")]
	public static global::KJOKEMCHDHC<T, U, V, W, X, Y> EIJCHJNCJNI(global::KJOKEMCHDHC<T, U, V, W, X, Y> HDDONHGOFDK, Action<T, U, V, W, X, Y> PBMHOLJNIIA)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2041B50", Offset = "0x2040950", VA = "0x182041B50")]
	public static global::KJOKEMCHDHC<T, U, V, W, X, Y> IPNIBLMCLJC(global::KJOKEMCHDHC<T, U, V, W, X, Y> HDDONHGOFDK, Action<T, U, V, W, X, Y> PBMHOLJNIIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MOBOPLNNPFI<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool FFJLOJIBPFL(global::MOBOPLNNPFI<T> JNCENDBKKMF);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class PHJLLALDKNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public global::MOBOPLNNPFI<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public PHJLLALDKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2043F00", Offset = "0x2042D00", VA = "0x182043F00")]
		internal bool <FindNode>b__0(global::MOBOPLNNPFI<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public T JPHOICHJLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public LinkedList<global::MOBOPLNNPFI<T>> HLGCACJNPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public global::MOBOPLNNPFI<T> MANEKPBJBJJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::MOBOPLNNPFI<T> FEHNGPGCPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x47BD30", Offset = "0x47AB30", VA = "0x18047BD30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x203FB00", Offset = "0x203E900", VA = "0x18203FB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool BICLIIFALHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x203FAD0", Offset = "0x203E8D0", VA = "0x18203FAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JDJBOAEGONA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x203FCC0", Offset = "0x203EAC0", VA = "0x18203FCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::MOBOPLNNPFI<T> FPMPDBDPBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x203F630", Offset = "0x203E430", VA = "0x18203F630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x20407C0", Offset = "0x203F5C0", VA = "0x1820407C0")]
	public MOBOPLNNPFI(T APMOEEHPOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x203EC60", Offset = "0x203DA60", VA = "0x18203EC60")]
	public global::MOBOPLNNPFI<T> EIPNFBCFNOD(T DAEJCHDOGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x203E8D0", Offset = "0x203D6D0", VA = "0x18203E8D0")]
	public global::MOBOPLNNPFI<T> CMEKHNDEEPJ(T MONFLBMPNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x203F580", Offset = "0x203E380", VA = "0x18203F580")]
	public global::MOBOPLNNPFI<T> IPBNHGALMCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x203E4A0", Offset = "0x203D2A0", VA = "0x18203E4A0")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x203E7C0", Offset = "0x203D5C0", VA = "0x18203E7C0")]
	public global::MOBOPLNNPFI<T> BCAPAAEKMID(T KNBIJOPFFMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x203F1B0", Offset = "0x203DFB0", VA = "0x18203F1B0")]
	public static void FNNCNGAFKJF(global::MOBOPLNNPFI<T> MNJKKICPOJN, FFJLOJIBPFL FDJGIJLEEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2298A70", Offset = "0x2297870", VA = "0x182298A70")]
	public static void FNNCNGAFKJF<A>(global::MOBOPLNNPFI<T> MNJKKICPOJN, Func<global::MOBOPLNNPFI<T>, A, bool> FDJGIJLEEPI, A OIJJMDCENJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x203FD00", Offset = "0x203EB00", VA = "0x18203FD00")]
	public static string PMGHKONLGDD(global::MOBOPLNNPFI<T> MNJKKICPOJN, int OPDKMMHHIJN = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x203F6B0", Offset = "0x203E4B0", VA = "0x18203F6B0")]
	public static global::MOBOPLNNPFI<T> JFCKOAMPDKA(global::MOBOPLNNPFI<T> MNJKKICPOJN, T MOHINFEELOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DefaultMember("Item")]
public class EDCMCCBFCMD<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate int JEENLDKGMMM(TKey JEAOBHPGMKJ, TVal NAHKACCDOIA);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class AABCOBGEDHF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey GBAAKJMCCDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal FJILFHOHJHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5861D0", Offset = "0x584FD0", VA = "0x1805861D0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x843EA0", Offset = "0x842CA0", VA = "0x180843EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int JCLCCCMGJJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x4D3E80", Offset = "0x4D2C80", VA = "0x1804D3E80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4D3EB0", Offset = "0x4D2CB0", VA = "0x1804D3EB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime FOHJIMCGMCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x421CF0", Offset = "0x420AF0", VA = "0x180421CF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x4487D0", Offset = "0x4475D0", VA = "0x1804487D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x322CAC0", Offset = "0x322B8C0", VA = "0x18322CAC0")]
		public AABCOBGEDHF(TKey JEAOBHPGMKJ, TVal CLPKDFPMGGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public const int IGPJPDKPAKK = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Dictionary<TKey, LinkedListNode<AABCOBGEDHF>> ONBFEPNKHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly LinkedList<AABCOBGEDHF> ONHJECACIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JEENLDKGMMM KFMPHJPGPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly TimeSpan PAEMMMJFJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ONJMFAPJBEM BHBHNPPBIEG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int DNDPHHINJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4DCFB0", Offset = "0x4DBDB0", VA = "0x1804DCFB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool BEEOCJNNIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3232410", Offset = "0x3231210", VA = "0x183232410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int MFMFEIBBEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4DCFC0", Offset = "0x4DBDC0", VA = "0x1804DCFC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4D2000", Offset = "0x4D0E00", VA = "0x1804D2000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey OMCHAOCHNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x32323E0", Offset = "0x32311E0", VA = "0x1832323E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x32333F0", Offset = "0x32321F0", VA = "0x1832333F0")]
	public EDCMCCBFCMD(int CPENFPNBDAK, [Optional] JEENLDKGMMM KFMPHJPGPOF, [Optional] IEqualityComparer<TKey> FEEBDPPJKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3232EE0", Offset = "0x3231CE0", VA = "0x183232EE0")]
	public EDCMCCBFCMD(int CPENFPNBDAK, JEENLDKGMMM KFMPHJPGPOF, TimeSpan PAEMMMJFJNC, [Optional] IEqualityComparer<TKey> FEEBDPPJKPJ, [Optional] ONJMFAPJBEM BHBHNPPBIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3232C00", Offset = "0x3231A00", VA = "0x183232C00")]
	public void MNOMICKIHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3232D60", Offset = "0x3231B60", VA = "0x183232D60")]
	public void ODJEMBKCBAO(TKey JEAOBHPGMKJ, TVal NAHKACCDOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x32324A0", Offset = "0x32312A0", VA = "0x1832324A0")]
	public bool IPBNHGALMCN(TKey JEAOBHPGMKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3232960", Offset = "0x3231760", VA = "0x183232960")]
	public bool KNKNOCIIPGD(TKey EBFNIMFMDKO, out TVal NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3231A50", Offset = "0x3230850", VA = "0x183231A50")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x32318D0", Offset = "0x32306D0", VA = "0x1832318D0")]
	private bool AOBBPEHAEKF(AABCOBGEDHF ONHKFBDBOAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3231D50", Offset = "0x3230B50", VA = "0x183231D50")]
	private void EDOBCOFCHLO(LinkedListNode<AABCOBGEDHF> BJLEGKIGBNA, TVal OFHDGBDDOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x32321D0", Offset = "0x3230FD0", VA = "0x1832321D0")]
	private void ELKECNODCAF(TKey JEAOBHPGMKJ, TVal NAHKACCDOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3232620", Offset = "0x3231420", VA = "0x183232620")]
	private void JNPHHNCCDKN(AABCOBGEDHF ONHKFBDBOAK, TVal OFHDGBDDOJA, int EGGJKOPMFHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public class OGFIBABCDGE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly List<T> NJOMLILJNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private HashSet<T> AANKLDICFKG;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HMLDEJFKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1917B40", Offset = "0x1916940", VA = "0x181917B40", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool PJJBGONCBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x41FE40", Offset = "0x41EC40", VA = "0x18041FE40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T OMCHAOCHNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x206FFA0", Offset = "0x206EDA0", VA = "0x18206FFA0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x206FFD0", Offset = "0x206EDD0", VA = "0x18206FFD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x206F820", Offset = "0x206E620", VA = "0x18206F820", Slot = "11")]
	public void Add(T NJIEMDNFLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x206F9C0", Offset = "0x206E7C0", VA = "0x18206F9C0")]
	public bool FOJBOFADAMC(T NJIEMDNFLGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x206FE20", Offset = "0x206EC20", VA = "0x18206FE20", Slot = "15")]
	public bool Remove(T NJIEMDNFLGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C3F0", Offset = "0x1D3B1F0", VA = "0x181D3C3F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x206FEA0", Offset = "0x206ECA0", VA = "0x18206FEA0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x206F850", Offset = "0x206E650", VA = "0x18206F850", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x206F8B0", Offset = "0x206E6B0", VA = "0x18206F8B0", Slot = "13")]
	public bool Contains(T NJIEMDNFLGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x206F8E0", Offset = "0x206E6E0", VA = "0x18206F8E0", Slot = "14")]
	public void CopyTo(T[] HICCBIOADHD, int LNOEJIPNBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2039450", Offset = "0x2038250", VA = "0x182039450", Slot = "6")]
	public int IndexOf(T NJIEMDNFLGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x206FB30", Offset = "0x206E930", VA = "0x18206FB30", Slot = "7")]
	public void Insert(int LEPJFDHOFMF, T NJIEMDNFLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x206FBF0", Offset = "0x206E9F0", VA = "0x18206FBF0", Slot = "8")]
	public void RemoveAt(int LEPJFDHOFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x206FED0", Offset = "0x206ECD0", VA = "0x18206FED0")]
	public OGFIBABCDGE()
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
			[Cpp2IlInjected.Address(RVA = "0x241C780", Offset = "0x241B580", VA = "0x18241C780")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7D10", Offset = "0x3CC6B10", VA = "0x183CC7D10")]
		public SerializedGuid(in Guid OJNJBGDLLEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7900", Offset = "0x3CC6700", VA = "0x183CC7900")]
		public static SerializedGuid ACGNOOLHHEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7980", Offset = "0x3CC6780", VA = "0x183CC7980")]
		public static SerializedGuid BLCGNEOCMKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7BB0", Offset = "0x3CC69B0", VA = "0x183CC7BB0")]
		public bool FOHPFIFNBLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7CF0", Offset = "0x3CC6AF0", VA = "0x183CC7CF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7C50", Offset = "0x3CC6A50", VA = "0x183CC7C50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7A30", Offset = "0x3CC6830", VA = "0x183CC7A30", Slot = "7")]
		public bool Equals(SerializedGuid GGDENAHKICG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7AD0", Offset = "0x3CC68D0", VA = "0x183CC7AD0", Slot = "0")]
		public override bool Equals(object NMIBNAJICKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7C40", Offset = "0x3CC6A40", VA = "0x183CC7C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7A00", Offset = "0x3CC6800", VA = "0x183CC7A00", Slot = "6")]
		public int CompareTo(SerializedGuid GGDENAHKICG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class HGEOKLIIAMF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly Type IMCEABENNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly string LKKOPGPKOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly bool MMFFLCNBHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool JEEMMKOBMIF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6470", Offset = "0x3CC5270", VA = "0x183CC6470")]
	public HGEOKLIIAMF(Type PLFONCKLJHB, string CJCMFIILMIL, bool KPNMOFABLEK = false, bool JFAIBOLAHEE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JELKIOBDNOK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T FJILFHOHJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool EFFOGOBODOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::JELKIOBDNOK<T> EFKDPDDKCMF(Action<T> FLEBEGEBLHA);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::JELKIOBDNOK<T> EMLCDKDNCOP(Action<T> FLEBEGEBLHA);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OGLKMCKMJFE<T> : global::JELKIOBDNOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private global::MOMPHOHCMGD<T, T> FCIJDHOINIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private global::NAMLIIIPNBG<T> LFKCDFMGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private global::NAMLIIIPNBG<string> ELJOGDNKDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private string NBCCKCOEGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T IKMNANMINNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool JGGHJLNCAKI;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T FJILFHOHJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x446670", Offset = "0x445470", VA = "0x180446670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x16A1330", Offset = "0x16A0130", VA = "0x1816A1330", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool EFFOGOBODOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4D1DE0", Offset = "0x4D0BE0", VA = "0x1804D1DE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2070150", Offset = "0x206EF50", VA = "0x182070150")]
	private void AOACAHMFPOC(T PCBKHMIDALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x20701D0", Offset = "0x206EFD0", VA = "0x1820701D0", Slot = "4")]
	public global::JELKIOBDNOK<T> EFKDPDDKCMF(Action<T> NMFKMAFEOIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2070250", Offset = "0x206F050", VA = "0x182070250", Slot = "5")]
	public global::JELKIOBDNOK<T> EMLCDKDNCOP(Action<T> FLEBEGEBLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2070280", Offset = "0x206F080", VA = "0x182070280")]
	public OGLKMCKMJFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DGJCMOGLFAI
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class DIDCGJEHPDO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public global::JELKIOBDNOK<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public global::CPKBDGHLMFF<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public DIDCGJEHPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x32E3BA0", Offset = "0x32E29A0", VA = "0x1832E3BA0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2150500", Offset = "0x214F300", VA = "0x182150500")]
	public static global::BGNOPMFAGGO<T> NBJPFINDNPH<T>(this global::JELKIOBDNOK<T> MPNLPEOKCLM, Action<T> CNAECKKILBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public abstract class ONJMFAPJBEM
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private class NFMEOKDMGIM : ONJMFAPJBEM
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static ONJMFAPJBEM LELDKBAOHMK
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3CC6E30", Offset = "0x3CC5C30", VA = "0x183CC6E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime AGJEMCNNCEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3CC6E90", Offset = "0x3CC5C90", VA = "0x183CC6E90", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6F70", Offset = "0x3CC5D70", VA = "0x183CC6F70")]
		public NFMEOKDMGIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ONJMFAPJBEM HNCCDKFEIGP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static ONJMFAPJBEM CGOANJJEABO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7420", Offset = "0x3CC6220", VA = "0x183CC7420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime AGJEMCNNCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
	protected ONJMFAPJBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class OJGCLCCCAMM : global::DMEGMLNIDBP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3CC73E0", Offset = "0x3CC61E0", VA = "0x183CC73E0")]
	public OJGCLCCCAMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DMEGMLNIDBP<T> : global::KIOMPDAFPEF<T>, MECJJMGACOG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> LEPCGHEGDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::BGNOPMFAGGO<T> LKEJMPKDENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private DCLDNCDAGBP BJNCEJCPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1696DF0", Offset = "0x1695BF0", VA = "0x181696DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x32E91F0", Offset = "0x32E7FF0", VA = "0x1832E91F0")]
	public DMEGMLNIDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class IOFDGFILPGF<T> : global::KIOMPDAFPEF<T>, MECJJMGACOG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> LEPCGHEGDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::BGNOPMFAGGO<T> LKEJMPKDENP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private DCLDNCDAGBP BJNCEJCPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1696DF0", Offset = "0x1695BF0", VA = "0x181696DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1696E20", Offset = "0x1695C20", VA = "0x181696E20")]
	public IOFDGFILPGF(Exception ACIOKHEIABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MECJJMGACOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	DCLDNCDAGBP LKEJMPKDENP
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KIOMPDAFPEF<T> : MECJJMGACOG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> LEPCGHEGDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::BGNOPMFAGGO<T> LKEJMPKDENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class KMFKDKJMHLC<TTask, T> : global::KIOMPDAFPEF<T>, MECJJMGACOG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ECALDMHBOAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public global::KMFKDKJMHLC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public ECALDMHBOAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class PCEIOMPKPLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public ECALDMHBOAF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		public PCEIOMPKPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x232EF10", Offset = "0x232DD10", VA = "0x18232EF10")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static bool CKKELHOOJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly global::CPKBDGHLMFF<T> CHHEFABIBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Task<T> DMJEIMBHDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly CancellationTokenSource PFCBGMECJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private bool LKKCEJKELCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private SynchronizationContext CMLCDIFAJNK;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> LEPCGHEGDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x41F190", Offset = "0x41DF90", VA = "0x18041F190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::BGNOPMFAGGO<T> LKEJMPKDENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private DCLDNCDAGBP BJNCEJCPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool ADEBICKLJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x55FD70", Offset = "0x55EB70", VA = "0x18055FD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x23250B0", Offset = "0x2323EB0", VA = "0x1823250B0")]
	static KMFKDKJMHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2325220", Offset = "0x2324020", VA = "0x182325220")]
	protected KMFKDKJMHLC(TTask DMJEIMBHDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2324960", Offset = "0x2323760", VA = "0x182324960", Slot = "1")]
	~KMFKDKJMHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2324930", Offset = "0x2323730", VA = "0x182324930", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2324D50", Offset = "0x2323B50", VA = "0x182324D50")]
	private void MLLPMCGLDML(bool LALKJDJMHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T GNMNPFKCKEB(TTask ILCOGPODDEJ);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void PDFFCGFAJGM();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2324820", Offset = "0x2323620", VA = "0x182324820")]
	protected void CEIENBKENNC(T PCBKHMIDALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2324EC0", Offset = "0x2323CC0", VA = "0x182324EC0")]
	protected void PLJECJJHHLA(string NBCCKCOEGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2324B40", Offset = "0x2323940", VA = "0x182324B40")]
	[CompilerGenerated]
	private void JCIJMIJDMCJ(object BHBCJFPFNCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EOLCHBECGFA<T> : IEnumerable<global::EOLCHBECGFA<T>.KBICIHDPJCO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct KBICIHDPJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public T NAHKACCDOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int LEPJFDHOFMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class DENBIACPJAN : IEnumerator<KBICIHDPJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private global::EOLCHBECGFA<T> MEBCOGPHHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int LEPJFDHOFMF;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2482560", Offset = "0x2481360", VA = "0x182482560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public KBICIHDPJCO CDLDHFPDHIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2B9F4D0", Offset = "0x2B9E2D0", VA = "0x182B9F4D0", Slot = "4")]
			get
			{
				return default(KBICIHDPJCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F40", Offset = "0x5B3D40", VA = "0x1805B4F40")]
		public DENBIACPJAN(global::EOLCHBECGFA<T> MEBCOGPHHGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2B9F440", Offset = "0x2B9E240", VA = "0x182B9F440", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F30", Offset = "0x5B3D30", VA = "0x1805B4F30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7525D0", Offset = "0x7513D0", VA = "0x1807525D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private struct BOEIIPDAABM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public bool BPCNNJKMLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public T NAHKACCDOIA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private const int LPDNIAMGIFK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private Dictionary<T, int> MJFFLAKMNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private BOEIIPDAABM[] MEDGOLHPFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int KPJIDPFELCP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int HMLDEJFKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2AE1320", Offset = "0x2AE0120", VA = "0x182AE1320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2BA47F0", Offset = "0x2BA35F0", VA = "0x182BA47F0")]
	public static global::EOLCHBECGFA<T> FGEPLCJBAGH(KBICIHDPJCO[] HOIFOCMKNCM, bool FLJOGMFJGAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5060", Offset = "0x2BA3E60", VA = "0x182BA5060")]
	public EOLCHBECGFA(int CPENFPNBDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4FA0", Offset = "0x2BA3DA0", VA = "0x182BA4FA0")]
	public int OENAHKKEGMF(T NAHKACCDOIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4F30", Offset = "0x2BA3D30", VA = "0x182BA4F30")]
	public T NBJPFINDNPH(int LEPJFDHOFMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4BB0", Offset = "0x2BA39B0", VA = "0x182BA4BB0")]
	public bool FOJBOFADAMC(T NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4BD0", Offset = "0x2BA39D0", VA = "0x182BA4BD0")]
	public bool FOJBOFADAMC(T NAHKACCDOIA, int LEPJFDHOFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4DA0", Offset = "0x2BA3BA0", VA = "0x182BA4DA0")]
	public KBICIHDPJCO[] GPEECFJFKBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4EE0", Offset = "0x2BA3CE0", VA = "0x182BA4EE0")]
	private int HHNDONNKNAB(int MMOFFBNAIBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4FF0", Offset = "0x2BA3DF0", VA = "0x182BA4FF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4FF0", Offset = "0x2BA3DF0", VA = "0x182BA4FF0", Slot = "4")]
	private IEnumerator<KBICIHDPJCO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class KJMAEOAPEGH<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private List<T> KKGEHFBLNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<T> IHBEJBGNIBI;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2323A10", Offset = "0x2322810", VA = "0x182323A10")]
	public KJMAEOAPEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2323A40", Offset = "0x2322840", VA = "0x182323A40")]
	public KJMAEOAPEGH(int CPENFPNBDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2323910", Offset = "0x2322710", VA = "0x182323910")]
	public T KFCMFLJHMIF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x23237F0", Offset = "0x23225F0", VA = "0x1823237F0")]
	public void GMKFJPPMOHK(T AHEOBGKNHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class AMCOJJOMMJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	protected struct CKOEMAENKBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public T FJILFHOHJHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int NJPPPOFICOC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected readonly List<CKOEMAENKBK> NJAJDJFIJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private T PFIIDNIEHJL;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int HMLDEJFKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x1917B40", Offset = "0x1916940", VA = "0x181917B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CB40", Offset = "0x1D3B940", VA = "0x181D3CB40")]
	public bool NOJJGEPDEHE(T NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CAC0", Offset = "0x1D3B8C0", VA = "0x181D3CAC0")]
	public void KMKDPFABOFI(T NAHKACCDOIA, int KNMDCDEOBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C910", Offset = "0x1D3B710", VA = "0x181D3C910")]
	public bool IPBNHGALMCN(T NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C6A0", Offset = "0x1D3B4A0", VA = "0x181D3C6A0")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CA30", Offset = "0x1D3B830", VA = "0x181D3CA30")]
	public T JMKNIHPPMLJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C700", Offset = "0x1D3B500", VA = "0x181D3C700")]
	private void FEOGKHKCHDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CD90", Offset = "0x1D3BB90", VA = "0x181D3CD90")]
	public AMCOJJOMMJD()
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
		[Cpp2IlInjected.Address(RVA = "0x1923090", Offset = "0x1921E90", VA = "0x181923090", Slot = "4")]
		public virtual T MNGDFAPCALH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1690560", Offset = "0x168F360", VA = "0x181690560")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class FFJMLEIBEHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Dictionary<byte, NHEDJKNCHGG> FPEMOMOFKKM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NHEDJKNCHGG EMDHOBIGIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x41F1A0", Offset = "0x41DFA0", VA = "0x18041F1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x41F440", Offset = "0x41E240", VA = "0x18041F440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 ECMEFCIPHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xBE8950", Offset = "0xBE7750", VA = "0x180BE8950")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x16A13D0", Offset = "0x16A01D0", VA = "0x1816A13D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector2 MFOEBHOLEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x1126790", Offset = "0x1125590", VA = "0x181126790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 KOFOOGFCNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6700", Offset = "0x2DF5500", VA = "0x182DF6700")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6720", Offset = "0x2DF5520", VA = "0x182DF6720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int FLDFJMHALPG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4491B0", Offset = "0x447FB0", VA = "0x1804491B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x46E360", Offset = "0x46D160", VA = "0x18046E360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5B20", Offset = "0x3CC4920", VA = "0x183CC5B20")]
	public FFJMLEIBEHP(Bounds MLIKAPLPLHP, Vector2[] DLAHIJDKBEM, int PIJGFILENPL, byte MMOFFBNAIBK, float EKEJGBGMPEG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC59E0", Offset = "0x3CC47E0", VA = "0x183CC59E0")]
	public NHEDJKNCHGG NEIDPGJMIFI(byte LEPJFDHOFMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5A40", Offset = "0x3CC4840", VA = "0x183CC5A40")]
	public void NJLFJFCLJIG(Vector3 KHOIOAIFBAD, float KABEMALIGMA, float IBKNKFDPCMH, ref List<byte> GHFMGLPPCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5380", Offset = "0x3CC4180", VA = "0x183CC5380")]
	public void CJENDDIBLMF(NHEDJKNCHGG.INBPECAHOLF GNPFNFNDBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3CC53A0", Offset = "0x3CC41A0", VA = "0x183CC53A0")]
	private NHEDJKNCHGG FELIOKOHNLL(byte LEPJFDHOFMF, NHEDJKNCHGG.POCEFNENCPF MNBOPGBPHLM, NHEDJKNCHGG EPKFCLLFPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3CC54C0", Offset = "0x3CC42C0", VA = "0x183CC54C0")]
	private void HAKDEJDMCPP(NHEDJKNCHGG EPKFCLLFPEH, Vector2[] DLAHIJDKBEM, int BDNLJPIHDJB, int KOIDHMINNLO, int NEBDPJAMMCF, int IEFLLIPLCMK, float EKEJGBGMPEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class NHEDJKNCHGG
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum POCEFNENCPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum INBPECAHOLF
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
	public byte DACLCAFBMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Vector3 AFDFDGAFLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Vector3 JCLCCCMGJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Vector3 NMHPBFAAANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 CJCGHOPMCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public POCEFNENCPF JEHCMPDDJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NHEDJKNCHGG FEHNGPGCPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public List<NHEDJKNCHGG> OAPJHCCCGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool GJPCFNLEJKB;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7390", Offset = "0x3CC6190", VA = "0x183CC7390")]
	public NHEDJKNCHGG(byte LOOMKMDLKEO, POCEFNENCPF MNBOPGBPHLM, NHEDJKNCHGG EPKFCLLFPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3CC6FD0", Offset = "0x3CC5DD0", VA = "0x183CC6FD0")]
	public void EIPNFBCFNOD(NHEDJKNCHGG AJCJNFLNNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00")]
	public void CJENDDIBLMF(int JECOENFLNFO, INBPECAHOLF GNPFNFNDBDK, int GLAJBGDOJEJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3CC70C0", Offset = "0x3CC5EC0", VA = "0x183CC70C0")]
	public void NJLFJFCLJIG(List<byte> GHFMGLPPCKM, Vector3 KHOIOAIFBAD, float KABEMALIGMA, float IBKNKFDPCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7060", Offset = "0x3CC5E60", VA = "0x183CC7060")]
	public bool MFBDOCDACOD(Vector3 ELMPACCCOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7350", Offset = "0x3CC6150", VA = "0x183CC7350")]
	public bool OMOEOJOPNMH(Vector3 ELMPACCCOLA, float OACJPHBCCAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class FLMDLNAIOPB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private int CPENFPNBDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int PAICJKEFHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private List<T> LFBLBLBOHFH;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public T CHHFPPNPNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0300", Offset = "0x2ADF100", VA = "0x182AE0300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T DILMENMDBJL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2AE0220", Offset = "0x2ADF020", VA = "0x182AE0220")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T GJFFCHECFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2AE00F0", Offset = "0x2ADEEF0", VA = "0x182AE00F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0660", Offset = "0x2ADF460", VA = "0x182AE0660")]
	public FLMDLNAIOPB(int CPENFPNBDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0390", Offset = "0x2ADF190", VA = "0x182AE0390")]
	public void KMKDPFABOFI(T FIGJFHBMAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE00B0", Offset = "0x2ADEEB0", VA = "0x182AE00B0")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0610", Offset = "0x2ADF410", VA = "0x182AE0610")]
	public void OKKEEGFANCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2AE0380", Offset = "0x2ADF180", VA = "0x182AE0380")]
	public void HLMEGLJOCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class CGLBJGAKMGM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct MACBCHJNMPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int NJPPPOFICOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public T FJILFHOHJHF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Dictionary<object, MACBCHJNMPG> DLPLBOKFPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private T DFIAAOGKDOJ;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T NGGOHIMAJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xBE8950", Offset = "0xBE7750", VA = "0x180BE8950", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x16A13D0", Offset = "0x16A01D0", VA = "0x1816A13D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool KOMDDOHBAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x21C1910", Offset = "0x21C0710", VA = "0x1821C1910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object BHAELKBCGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x421CF0", Offset = "0x420AF0", VA = "0x180421CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4487D0", Offset = "0x4475D0", VA = "0x1804487D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x21C1050", Offset = "0x21BFE50", VA = "0x1821C1050")]
	public bool ELKECNODCAF(T NAHKACCDOIA, object DJIIHFDLHHP, int KNMDCDEOBBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x21C1960", Offset = "0x21C0760", VA = "0x1821C1960")]
	public bool OGCOGMPGAMH(object DJIIHFDLHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x21C13F0", Offset = "0x21C01F0", VA = "0x1821C13F0")]
	public bool KNKNOCIIPGD(object DJIIHFDLHHP, out T NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x21BB1F0", Offset = "0x21B9FF0", VA = "0x1821BB1F0")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x21BBF90", Offset = "0x21BAD90", VA = "0x1821BBF90")]
	private bool AOAAGAKMGDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x21C19D0", Offset = "0x21C07D0", VA = "0x1821C19D0")]
	public CGLBJGAKMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DGPNENEFMAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Dictionary<object, float> DLPLBOKFPBL;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float BJOBCFHPNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA77C30", Offset = "0xA76A30", VA = "0x180A77C30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA52F30", Offset = "0xA51D30", VA = "0x180A52F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5240", Offset = "0x3CC4040", VA = "0x183CC5240")]
	public void ELKECNODCAF(float NAHKACCDOIA, object DJIIHFDLHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC52B0", Offset = "0x3CC40B0", VA = "0x183CC52B0")]
	public void OGCOGMPGAMH(object DJIIHFDLHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5120", Offset = "0x3CC3F20", VA = "0x183CC5120")]
	private void BEDFGDGDGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5310", Offset = "0x3CC4110", VA = "0x183CC5310")]
	public DGPNENEFMAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class OOLOGBNMEOF
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class MBJHCEJKGHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly string KNMDEKMNIMI;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
		private MBJHCEJKGHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4B7560", Offset = "0x4B6360", VA = "0x1804B7560")]
		public MBJHCEJKGHH(string KNMDEKMNIMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6810", Offset = "0x3CC5610", VA = "0x183CC6810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HJHPKPOEIHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4219D0", Offset = "0x4207D0", VA = "0x1804219D0")]
		public HJHPKPOEIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3CC64D0", Offset = "0x3CC52D0", VA = "0x183CC64D0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly HashSet<object> LFJLHFCKOGI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool CAHFMGPBODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3CC75E0", Offset = "0x3CC63E0", VA = "0x183CC75E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7680", Offset = "0x3CC6480", VA = "0x183CC7680")]
	public void KMKDPFABOFI(object DJIIHFDLHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7620", Offset = "0x3CC6420", VA = "0x183CC7620")]
	public void IPBNHGALMCN(object DJIIHFDLHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3CC76E0", Offset = "0x3CC64E0", VA = "0x183CC76E0")]
	public bool NOJJGEPDEHE(object DJIIHFDLHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7590", Offset = "0x3CC6390", VA = "0x183CC7590")]
	public void BHBNJLIJPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7740", Offset = "0x3CC6540", VA = "0x183CC7740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3CC78A0", Offset = "0x3CC66A0", VA = "0x183CC78A0")]
	public OOLOGBNMEOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class CFGCPFOCOHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private struct GKJCJEBCHNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float EDNJFDNEOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public T FJILFHOHJHF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<object, GKJCJEBCHNM> DLPLBOKFPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private T MNKIKGPEKID;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T NJPBDPCPKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x12A2C50", Offset = "0x12A1A50", VA = "0x1812A2C50", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x21BBC30", Offset = "0x21BAA30", VA = "0x1821BBC30", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object CJOMDAIMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x446670", Offset = "0x445470", VA = "0x180446670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4BA620", Offset = "0x4B9420", VA = "0x1804BA620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool KOMDDOHBAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x21BBBF0", Offset = "0x21BA9F0", VA = "0x1821BBBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x21BB420", Offset = "0x21BA220", VA = "0x1821BB420")]
	public bool ELKECNODCAF(T NAHKACCDOIA, object DJIIHFDLHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x21BBC70", Offset = "0x21BAA70", VA = "0x1821BBC70")]
	public bool OGCOGMPGAMH(object DJIIHFDLHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x21BB1F0", Offset = "0x21B9FF0", VA = "0x1821BB1F0")]
	public void BANKNLGGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x21BBA40", Offset = "0x21BA840", VA = "0x1821BBA40")]
	public bool KNKNOCIIPGD(object DJIIHFDLHHP, out T NAHKACCDOIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x21B9920", Offset = "0x21B8720", VA = "0x1821B9920")]
	private bool AOAAGAKMGDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x21BBCD0", Offset = "0x21BAAD0", VA = "0x1821BBCD0")]
	public CFGCPFOCOHH()
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
