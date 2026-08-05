using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000002")]
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
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x954A40", Offset = "0x953040", VA = "0x180954A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xFE6930", Offset = "0xFE4F30", VA = "0x180FE6930")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1038FB0", Offset = "0x10375B0", VA = "0x181038FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "4")]
	public virtual void IKCMNHGBLFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	[JGOLHFADPFD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37F80D0", Offset = "0x37F66D0", VA = "0x1837F80D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37F7830", Offset = "0x37F5E30", VA = "0x1837F7830", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37F8600", Offset = "0x37F6C00", VA = "0x1837F8600")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FNOMFLDBAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public FNOMFLDBAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2B61A70", Offset = "0x2B60070", VA = "0x182B61A70")]
		internal int CHGIDIKEAIJ(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[JGOLHFADPFD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x122D720", Offset = "0x122BD20", VA = "0x18122D720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x122D750", Offset = "0x122BD50", VA = "0x18122D750", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x122D670", Offset = "0x122BC70", VA = "0x18122D670", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TVal this[TKey NAJDAPHOGEH]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x122D6D0", Offset = "0x122BCD0", VA = "0x18122D6D0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x122D570", Offset = "0x122BB70", VA = "0x18122D570", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x122D090", Offset = "0x122B690", VA = "0x18122D090", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x122C8B0", Offset = "0x122AEB0", VA = "0x18122C8B0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x122C560", Offset = "0x122AB60", VA = "0x18122C560", Slot = "14")]
	protected virtual string HFMBHBKGDBJ(TKeyVal KNPIEOHILCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x122C440", Offset = "0x122AA40", VA = "0x18122C440", Slot = "4")]
	public bool ContainsKey(TKey NAJDAPHOGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x122D450", Offset = "0x122BA50", VA = "0x18122D450", Slot = "5")]
	public bool TryGetValue(TKey NAJDAPHOGEH, out TVal FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x122C470", Offset = "0x122AA70", VA = "0x18122C470", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x122C470", Offset = "0x122AA70", VA = "0x18122C470", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x122D480", Offset = "0x122BA80", VA = "0x18122D480")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AFOEBKBHAMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PCDEFAHNCLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public PCDEFAHNCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6300", Offset = "0x2DE4900", VA = "0x182DE6300")]
		internal bool MNNHDGFAOJA(GDLIAFLNCEG<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float PMBKEJAECBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float AILLEPIIENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<GDLIAFLNCEG<float, T>> KPIOFAHLKBA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int FHMPJNDCBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x26E5890", Offset = "0x26E3E90", VA = "0x1826E5890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26E5910", Offset = "0x26E3F10", VA = "0x1826E5910")]
	public AFOEBKBHAMC(float PNFCAMAOKFC, float FPDIBKHKKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26E56B0", Offset = "0x26E3CB0", VA = "0x1826E56B0")]
	public bool JAMAHMFCJFC(float EKIGKJOOCNK, T FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26E4DB0", Offset = "0x26E33B0", VA = "0x1826E4DB0")]
	public int FKNOBCOHJNH(float EKIGKJOOCNK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26E4E10", Offset = "0x26E3410", VA = "0x1826E4E10")]
	public IEnumerable<T> HKDJCJBGMCP(float EKIGKJOOCNK, [Optional] float? OFJFBACFBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x26E4D80", Offset = "0x26E3380", VA = "0x1826E4D80")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x26E5490", Offset = "0x26E3A90", VA = "0x1826E5490")]
	private void ICPNGEIECIC(float EKIGKJOOCNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T CNODGJBIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D59B70", Offset = "0x3D58170", VA = "0x183D59B70")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D59B80", Offset = "0x3D58180", VA = "0x183D59B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float DLDHBILLKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA46F00", Offset = "0xA45500", VA = "0x180A46F00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D59D70", Offset = "0x3D58370", VA = "0x183D59D70")]
	public T FHKMBFPFJJK(float KIJLBFEDEPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D5A010", Offset = "0x3D58610", VA = "0x183D5A010")]
	public T GHMBMLBEOIK(float KIJLBFEDEPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GOPDGEEIENO(T NNCBKOEDDGO, T IHJFFGMGNME, float KIJLBFEDEPN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3399180", Offset = "0x3397780", VA = "0x183399180", Slot = "4")]
	protected override float GOPDGEEIENO(float NNCBKOEDDGO, float IHJFFGMGNME, float KIJLBFEDEPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7106760", Offset = "0x7104D60", VA = "0x187106760")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x18C6AC0", Offset = "0x18C50C0", VA = "0x1818C6AC0", Slot = "4")]
	protected override Vector3 GOPDGEEIENO(Vector3 NNCBKOEDDGO, Vector3 IHJFFGMGNME, float KIJLBFEDEPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x710AE00", Offset = "0x7109400", VA = "0x18710AE00")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7105180", Offset = "0x7103780", VA = "0x187105180", Slot = "4")]
	protected override Color GOPDGEEIENO(Color NNCBKOEDDGO, Color IHJFFGMGNME, float KIJLBFEDEPN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71051E0", Offset = "0x71037E0", VA = "0x1871051E0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DDCICJOGAFD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OGMCBPKMGNB<T1, T2> : IEnumerable<GDLIAFLNCEG<T1, T2>>, IEnumerable, IEnumerator<GDLIAFLNCEG<T1, T2>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GDLIAFLNCEG<T1, T2> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IEnumerable<T1> a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IEnumerable<T1> <>3__a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private IEnumerable<T2> b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public IEnumerable<T2> <>3__b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private IEnumerator<T1> <itrA>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<T2> <itrB>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool <itrAContinue>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool <itrBContinue>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private T1 <elementA>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private T2 <elementB>5__6;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		GDLIAFLNCEG<T1, T2> IEnumerator<Tuple<T1, T2>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1224AF0", Offset = "0x12230F0", VA = "0x181224AF0")]
		[DebuggerHidden]
		public OGMCBPKMGNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x36ABC10", Offset = "0x36AA210", VA = "0x1836ABC10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x36ABEC0", Offset = "0x36AA4C0", VA = "0x1836ABEC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1226880", Offset = "0x1224E80", VA = "0x181226880", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<GDLIAFLNCEG<T1, T2>> IEnumerable<Tuple<T1, T2>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1226940", Offset = "0x1224F40", VA = "0x181226940", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GEOKAPAGEKA<T1, T2, T3> : IEnumerable<IAGCFBGDDJE<T1, T2, T3>>, IEnumerable, IEnumerator<IAGCFBGDDJE<T1, T2, T3>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private IAGCFBGDDJE<T1, T2, T3> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private IEnumerable<T1> a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public IEnumerable<T1> <>3__a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IEnumerable<T2> b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public IEnumerable<T2> <>3__b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private IEnumerable<T3> c;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public IEnumerable<T3> <>3__c;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private IEnumerator<T1> <itrA>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<T2> <itrB>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private IEnumerator<T3> <itrC>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool <itrAContinue>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool <itrBContinue>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool <itrCContinue>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private T1 <elementA>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private T2 <elementB>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private T3 <elementC>5__9;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		IAGCFBGDDJE<T1, T2, T3> IEnumerator<Tuple<T1, T2, T3>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1224AF0", Offset = "0x12230F0", VA = "0x181224AF0")]
		[DebuggerHidden]
		public GEOKAPAGEKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2DBB5E0", Offset = "0x2DB9BE0", VA = "0x182DBB5E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2DBB9F0", Offset = "0x2DB9FF0", VA = "0x182DBB9F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2627C90", Offset = "0x2626290", VA = "0x182627C90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<IAGCFBGDDJE<T1, T2, T3>> IEnumerable<Tuple<T1, T2, T3>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x213ACC0", Offset = "0x21392C0", VA = "0x18213ACC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x15F9BA0", Offset = "0x15F81A0", VA = "0x1815F9BA0")]
	public static KLPMNPNHNED<T1> PJDMJLOGMBM<T1>(T1 LDIKBIIFBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x29998B0", Offset = "0x2997EB0", VA = "0x1829998B0")]
	public static GDLIAFLNCEG<T1, T2> PJDMJLOGMBM<T1, T2>(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2999920", Offset = "0x2997F20", VA = "0x182999920")]
	public static IAGCFBGDDJE<T1, T2, T3> PJDMJLOGMBM<T1, T2, T3>(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x16AA9E0", Offset = "0x16A8FE0", VA = "0x1816AA9E0")]
	public static IDALBAGJJGG<T1, T2, T3, T4> PJDMJLOGMBM<T1, T2, T3, T4>(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2999BF0", Offset = "0x29981F0", VA = "0x182999BF0")]
	public static DJKKNPIHCMF<T1, T2, T3, T4, T5> PJDMJLOGMBM<T1, T2, T3, T4, T5>(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN, T5 BKLAFGNHPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2999B40", Offset = "0x2998140", VA = "0x182999B40")]
	public static FIJOOMEHLGJ<T1, T2, T3, T4, T5, T6> PJDMJLOGMBM<T1, T2, T3, T4, T5, T6>(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN, T5 BKLAFGNHPIC, T6 NAEDAECEKBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2999A80", Offset = "0x2998080", VA = "0x182999A80")]
	public static EDLFEOFLJKF<T1, T2, T3, T4, T5, T6, T7> PJDMJLOGMBM<T1, T2, T3, T4, T5, T6, T7>(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN, T5 BKLAFGNHPIC, T6 NAEDAECEKBM, T7 MICDHHCEONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29999B0", Offset = "0x2997FB0", VA = "0x1829999B0")]
	public static HBFLBMBGIKI<T1, T2, T3, T4, T5, T6, T7, T8> PJDMJLOGMBM<T1, T2, T3, T4, T5, T6, T7, T8>(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN, T5 BKLAFGNHPIC, T6 NAEDAECEKBM, T7 MICDHHCEONH, T8 KBOEJDLENDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x10269C0", Offset = "0x1024FC0", VA = "0x1810269C0")]
	[IteratorStateMachine(typeof(OGMCBPKMGNB<, >))]
	public static IEnumerable<GDLIAFLNCEG<T1, T2>> MENKKPKAJPK<T1, T2>(IEnumerable<T1> LLAFGJINMOA, IEnumerable<T2> LKIHFBEPDMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x14B5B60", Offset = "0x14B4160", VA = "0x1814B5B60")]
	[IteratorStateMachine(typeof(GEOKAPAGEKA<, , >))]
	public static IEnumerable<IAGCFBGDDJE<T1, T2, T3>> MENKKPKAJPK<T1, T2, T3>(IEnumerable<T1> LLAFGJINMOA, IEnumerable<T2> LKIHFBEPDMH, IEnumerable<T3> HFOHBFLEBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7105340", Offset = "0x7103940", VA = "0x187105340")]
	internal static int DPIDPEPECBJ(int LFDKLIGIILJ, int DOEGMAMHNNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7105380", Offset = "0x7103980", VA = "0x187105380")]
	internal static int DPIDPEPECBJ(int LFDKLIGIILJ, int DOEGMAMHNNP, int ILCHDCHIMED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x71053E0", Offset = "0x71039E0", VA = "0x1871053E0")]
	internal static int DPIDPEPECBJ(int LFDKLIGIILJ, int DOEGMAMHNNP, int ILCHDCHIMED, int COAJAJHECIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7105390", Offset = "0x7103990", VA = "0x187105390")]
	internal static int DPIDPEPECBJ(int LFDKLIGIILJ, int DOEGMAMHNNP, int ILCHDCHIMED, int COAJAJHECIJ, int CBMCBAFMOBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7105400", Offset = "0x7103A00", VA = "0x187105400")]
	internal static int DPIDPEPECBJ(int LFDKLIGIILJ, int DOEGMAMHNNP, int ILCHDCHIMED, int COAJAJHECIJ, int CBMCBAFMOBA, int GPMCMAGGCKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7105350", Offset = "0x7103950", VA = "0x187105350")]
	internal static int DPIDPEPECBJ(int LFDKLIGIILJ, int DOEGMAMHNNP, int ILCHDCHIMED, int COAJAJHECIJ, int CBMCBAFMOBA, int GPMCMAGGCKK, int ALPIDCKADPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x71053B0", Offset = "0x71039B0", VA = "0x1871053B0")]
	internal static int DPIDPEPECBJ(int LFDKLIGIILJ, int DOEGMAMHNNP, int ILCHDCHIMED, int COAJAJHECIJ, int CBMCBAFMOBA, int GPMCMAGGCKK, int ALPIDCKADPE, int NJHJDEAIEBI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KLPMNPNHNED<T1> : IComparable<KLPMNPNHNED<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T1 EEFKDJFCGEG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x15BDFA0", Offset = "0x15BC5A0", VA = "0x1815BDFA0")]
	public KLPMNPNHNED(T1 LDIKBIIFBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2622F40", Offset = "0x2621540", VA = "0x182622F40", Slot = "4")]
	public int CompareTo(KLPMNPNHNED<T1> EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2622FB0", Offset = "0x26215B0", VA = "0x182622FB0", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2623050", Offset = "0x2621650", VA = "0x182623050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2623080", Offset = "0x2621680", VA = "0x182623080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GDLIAFLNCEG<T1, T2> : IComparable<GDLIAFLNCEG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T1 EEFKDJFCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T2 PEGOJLEPJNI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2267C00", Offset = "0x2266200", VA = "0x182267C00")]
	public GDLIAFLNCEG(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B53BA0", Offset = "0x3B521A0", VA = "0x183B53BA0", Slot = "4")]
	public int CompareTo(GDLIAFLNCEG<T1, T2> EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3B541E0", Offset = "0x3B527E0", VA = "0x183B541E0", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3B54B70", Offset = "0x3B53170", VA = "0x183B54B70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3B54EA0", Offset = "0x3B534A0", VA = "0x183B54EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IAGCFBGDDJE<T1, T2, T3> : IComparable<IAGCFBGDDJE<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly T1 EEFKDJFCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly T2 PEGOJLEPJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T3 JEIKOIEPFAI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1AC6CF0", Offset = "0x1AC52F0", VA = "0x181AC6CF0")]
	public IAGCFBGDDJE(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1AC6430", Offset = "0x1AC4A30", VA = "0x181AC6430", Slot = "4")]
	public int CompareTo(IAGCFBGDDJE<T1, T2, T3> EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1AC6630", Offset = "0x1AC4C30", VA = "0x181AC6630", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1AC6950", Offset = "0x1AC4F50", VA = "0x181AC6950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1AC69B0", Offset = "0x1AC4FB0", VA = "0x181AC69B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IDALBAGJJGG<T1, T2, T3, T4> : IComparable<IDALBAGJJGG<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 EEFKDJFCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T2 PEGOJLEPJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T3 JEIKOIEPFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T4 FDDACHPAIIC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1ACEDC0", Offset = "0x1ACD3C0", VA = "0x181ACEDC0")]
	public IDALBAGJJGG(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1ACE950", Offset = "0x1ACCF50", VA = "0x181ACE950", Slot = "4")]
	public int CompareTo(IDALBAGJJGG<T1, T2, T3, T4> EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1ACEA90", Offset = "0x1ACD090", VA = "0x181ACEA90", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1ACEBD0", Offset = "0x1ACD1D0", VA = "0x181ACEBD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1ACEC90", Offset = "0x1ACD290", VA = "0x181ACEC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DJKKNPIHCMF<T1, T2, T3, T4, T5> : IComparable<DJKKNPIHCMF<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T1 EEFKDJFCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T2 PEGOJLEPJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T3 JEIKOIEPFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T4 FDDACHPAIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T5 MOPGPKAGPBA;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1657FE0", Offset = "0x16565E0", VA = "0x181657FE0")]
	public DJKKNPIHCMF(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN, T5 BKLAFGNHPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2F1CA20", Offset = "0x2F1B020", VA = "0x182F1CA20", Slot = "4")]
	public int CompareTo(DJKKNPIHCMF<T1, T2, T3, T4, T5> EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2F1CBA0", Offset = "0x2F1B1A0", VA = "0x182F1CBA0", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2F1CD10", Offset = "0x2F1B310", VA = "0x182F1CD10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2F1CE10", Offset = "0x2F1B410", VA = "0x182F1CE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FIJOOMEHLGJ<T1, T2, T3, T4, T5, T6> : IComparable<FIJOOMEHLGJ<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T1 EEFKDJFCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T2 PEGOJLEPJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T3 JEIKOIEPFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T4 FDDACHPAIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T5 MOPGPKAGPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T6 PGHPHNGGNDG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x21FA900", Offset = "0x21F8F00", VA = "0x1821FA900")]
	public FIJOOMEHLGJ(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN, T5 BKLAFGNHPIC, T6 NAEDAECEKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x21FA320", Offset = "0x21F8920", VA = "0x1821FA320", Slot = "4")]
	public int CompareTo(FIJOOMEHLGJ<T1, T2, T3, T4, T5, T6> EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x21FA4E0", Offset = "0x21F8AE0", VA = "0x1821FA4E0", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x21FA670", Offset = "0x21F8C70", VA = "0x1821FA670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x21FA790", Offset = "0x21F8D90", VA = "0x1821FA790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EDLFEOFLJKF<T1, T2, T3, T4, T5, T6, T7> : IComparable<EDLFEOFLJKF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 EEFKDJFCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 PEGOJLEPJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 JEIKOIEPFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 FDDACHPAIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 MOPGPKAGPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 PGHPHNGGNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T7 KOFDOHOCEHH;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D2F0", Offset = "0x2A4B8F0", VA = "0x182A4D2F0")]
	public EDLFEOFLJKF(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN, T5 BKLAFGNHPIC, T6 NAEDAECEKBM, T7 MICDHHCEONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2A4CC50", Offset = "0x2A4B250", VA = "0x182A4CC50", Slot = "4")]
	public int CompareTo(EDLFEOFLJKF<T1, T2, T3, T4, T5, T6, T7> EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2A4CE50", Offset = "0x2A4B450", VA = "0x182A4CE50", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D010", Offset = "0x2A4B610", VA = "0x182A4D010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D160", Offset = "0x2A4B760", VA = "0x182A4D160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HBFLBMBGIKI<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<HBFLBMBGIKI<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T1 EEFKDJFCGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T2 PEGOJLEPJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T3 JEIKOIEPFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T4 FDDACHPAIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T5 MOPGPKAGPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T6 PGHPHNGGNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T7 KOFDOHOCEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T8 OFCNNGBNJFI;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x39009D0", Offset = "0x38FEFD0", VA = "0x1839009D0")]
	public HBFLBMBGIKI(T1 LDIKBIIFBAD, T2 DBEAIDPJCHO, T3 BGGKIDAKEGD, T4 PDNDCIPIOCN, T5 BKLAFGNHPIC, T6 NAEDAECEKBM, T7 MICDHHCEONH, T8 KBOEJDLENDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3900280", Offset = "0x38FE880", VA = "0x183900280", Slot = "4")]
	public int CompareTo(HBFLBMBGIKI<T1, T2, T3, T4, T5, T6, T7, T8> EJECOGCICOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x39004D0", Offset = "0x38FEAD0", VA = "0x1839004D0", Slot = "0")]
	public override bool Equals(object EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x39006B0", Offset = "0x38FECB0", VA = "0x1839006B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3900820", Offset = "0x38FEE20", VA = "0x183900820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JGOLHFADPFD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9BED80", Offset = "0x9BD380", VA = "0x1809BED80")]
	public JGOLHFADPFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HashableScriptableObject : ScriptableObject, GEBDHJJBGIO, LMAAFGFGLNP, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x920EA0", Offset = "0x91F4A0", VA = "0x180920EA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9989D0", Offset = "0x996FD0", VA = "0x1809989D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash PFEGKNHPDEP);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9A2FF0", Offset = "0x9A15F0", VA = "0x1809A2FF0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NCJKFHACIBG]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NCJKFHACIBG]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7109BD0", Offset = "0x71081D0", VA = "0x187109BD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7109B90", Offset = "0x7108190", VA = "0x187109B90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7109C10", Offset = "0x7108210", VA = "0x187109C10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7109DC0", Offset = "0x71083C0", VA = "0x187109DC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7109D30", Offset = "0x7108330", VA = "0x187109D30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9A4790", Offset = "0x9A2D90", VA = "0x1809A4790")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9A4780", Offset = "0x9A2D80", VA = "0x1809A4780")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7109B50", Offset = "0x7108150", VA = "0x187109B50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7109CA0", Offset = "0x71082A0", VA = "0x187109CA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x71095A0", Offset = "0x7107BA0", VA = "0x1871095A0")]
	public void CopyBounds(SavedExtents EJECOGCICOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7109AB0", Offset = "0x71080B0", VA = "0x187109AB0")]
	public void SetLocalSpaceBounds(Bounds LAGPBEBBJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7108F40", Offset = "0x7107540", VA = "0x187108F40")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7109AA0", Offset = "0x71080A0", VA = "0x187109AA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7109690", Offset = "0x7107C90", VA = "0x187109690")]
	private void JENLFOGKKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7109870", Offset = "0x7107E70", VA = "0x187109870")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7108F60", Offset = "0x7107560", VA = "0x187108F60")]
	public static void CalculateLocalBoundsFor(GameObject CGLKMGEDNPH, out Bounds LAGPBEBBJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x71095D0", Offset = "0x7107BD0", VA = "0x1871095D0")]
	private static void HGMKCPKJLAC(Bounds LKIHFBEPDMH, Color HFOHBFLEBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7109AD0", Offset = "0x71080D0", VA = "0x187109AD0")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class CJKFAAGKCCD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct KBCBHKBDMNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public T CNODGJBIHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float KIPKMPDKGKM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static float BDANOJCBHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<T> KIEKKENAKLC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const int GPKJDANFFHE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private KBCBHKBDMNN[] JHKFLJIAOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int GPICNIHIGBI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FHMDHFHOPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xC011B0", Offset = "0xBFF7B0", VA = "0x180C011B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC20B20", Offset = "0xC1F120", VA = "0x180C20B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7190", Offset = "0x2BB5790", VA = "0x182BB7190")]
	public CJKFAAGKCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7090", Offset = "0x2BB5690", VA = "0x182BB7090")]
	public CJKFAAGKCCD(int BMEHIBKNEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6EA0", Offset = "0x2BB54A0", VA = "0x182BB6EA0")]
	public void PEECNHFNIGK(float EKIGKJOOCNK, T FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5E50", Offset = "0x2BB4450", VA = "0x182BB5E50")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5FD0", Offset = "0x2BB45D0", VA = "0x182BB5FD0")]
	public bool EPMFOEBICHB(float BALBDAAMGGG, float JIDHFHPDFKK, out T FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6C10", Offset = "0x2BB5210", VA = "0x182BB6C10")]
	public bool GBEPCDHNKMJ(float BALBDAAMGGG, float JIDHFHPDFKK, out T FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6680", Offset = "0x2BB4C80", VA = "0x182BB6680")]
	public void FHJBFGDMLBB(float BALBDAAMGGG, float JIDHFHPDFKK, List<T> IOBPFDIOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5FA0", Offset = "0x2BB45A0", VA = "0x182BB5FA0")]
	private int DABABEEJDAJ(int DOLDAPDGBEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6D80", Offset = "0x2BB5380", VA = "0x182BB6D80")]
	private void NLLFHKJDECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BCICONGNPFD();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GOPDGEEIENO(T NNCBKOEDDGO, T IHJFFGMGNME, float KIJLBFEDEPN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JGDGLINFJAO(T FEBHELIDNED, float KIJLBFEDEPN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T DLBMKHMEEHG(T NNCBKOEDDGO, T IHJFFGMGNME);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T MCJJBONCDID(T NNCBKOEDDGO, T IHJFFGMGNME);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ALEGMDKFCCE : CJKFAAGKCCD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xE66170", Offset = "0xE64770", VA = "0x180E66170", Slot = "4")]
	protected override Vector3 BCICONGNPFD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x18C6AC0", Offset = "0x18C50C0", VA = "0x1818C6AC0", Slot = "5")]
	protected override Vector3 GOPDGEEIENO(Vector3 NNCBKOEDDGO, Vector3 IHJFFGMGNME, float KIJLBFEDEPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7103C80", Offset = "0x7102280", VA = "0x187103C80", Slot = "6")]
	protected override Vector3 JGDGLINFJAO(Vector3 FEBHELIDNED, float KIJLBFEDEPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7103C30", Offset = "0x7102230", VA = "0x187103C30", Slot = "7")]
	protected override Vector3 DLBMKHMEEHG(Vector3 NNCBKOEDDGO, Vector3 IHJFFGMGNME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7103CC0", Offset = "0x71022C0", VA = "0x187103CC0", Slot = "8")]
	protected override Vector3 MCJJBONCDID(Vector3 NNCBKOEDDGO, Vector3 IHJFFGMGNME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7103D30", Offset = "0x7102330", VA = "0x187103D30")]
	public ALEGMDKFCCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ABCOEGHACCH : CJKFAAGKCCD<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x71039A0", Offset = "0x7101FA0", VA = "0x1871039A0")]
	public ABCOEGHACCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7103A10", Offset = "0x7102010", VA = "0x187103A10")]
	public ABCOEGHACCH(int BMEHIBKNEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xE673D0", Offset = "0xE659D0", VA = "0x180E673D0", Slot = "4")]
	protected override float BCICONGNPFD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3399180", Offset = "0x3397780", VA = "0x183399180", Slot = "5")]
	protected override float GOPDGEEIENO(float NNCBKOEDDGO, float IHJFFGMGNME, float KIJLBFEDEPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x577D0D0", Offset = "0x577B6D0", VA = "0x18577D0D0", Slot = "6")]
	protected override float JGDGLINFJAO(float FEBHELIDNED, float KIJLBFEDEPN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7103980", Offset = "0x7101F80", VA = "0x187103980", Slot = "7")]
	protected override float DLBMKHMEEHG(float NNCBKOEDDGO, float IHJFFGMGNME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7103990", Offset = "0x7101F90", VA = "0x187103990", Slot = "8")]
	protected override float MCJJBONCDID(float NNCBKOEDDGO, float IHJFFGMGNME)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PLLBPPDNICC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IDisposable FBBAELKBDJK;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public PLLBPPDNICC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DACIFCAJLBF : GDGOKBDMNBN<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7105290", Offset = "0x7103890", VA = "0x187105290")]
	public DACIFCAJLBF(int IOKNIDFIOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x71052E0", Offset = "0x71038E0", VA = "0x1871052E0")]
	public DACIFCAJLBF(MENFBMHBFHC[] CMEPIEECLAH, bool ENBILCKCCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7105220", Offset = "0x7103820", VA = "0x187105220", Slot = "6")]
	protected override uint ONHIKLLJFJL(uint PFEGKNHPDEP, string FEBHELIDNED)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OAHICMLDLCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct POGGIBDPCNA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly OAHICMLDLCN<T> KPGJNMKJCFJ;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T CNODGJBIHLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x1EEF4E0", Offset = "0x1EEDAE0", VA = "0x181EEF4E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1EEF500", Offset = "0x1EEDB00", VA = "0x181EEF500", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
		public POGGIBDPCNA(OAHICMLDLCN<T> KPGJNMKJCFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PLKONDMIIKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<POGGIBDPCNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public OAHICMLDLCN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public PLKONDMIIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1EE88A0", Offset = "0x1EE6EA0", VA = "0x181EE88A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KNGHPEBNJNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<POGGIBDPCNA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OAHICMLDLCN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public KNGHPEBNJNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2626F80", Offset = "0x2625580", VA = "0x182626F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly SemaphoreSlim HOBANEDOFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T CDJLIJKLHLH;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int ELHGHENEENO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2414B40", Offset = "0x2413140", VA = "0x182414B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2415310", Offset = "0x2413910", VA = "0x182415310")]
	public OAHICMLDLCN(in T CDJLIJKLHLH, int EPEHJAIAGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x24152E0", Offset = "0x24138E0", VA = "0x1824152E0")]
	public OAHICMLDLCN(in T CDJLIJKLHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2414BA0", Offset = "0x24131A0", VA = "0x182414BA0")]
	public POGGIBDPCNA BLLDNIPICIO()
	{
		return default(POGGIBDPCNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2414B60", Offset = "0x2413160", VA = "0x182414B60")]
	public POGGIBDPCNA BLLDNIPICIO(CancellationToken OOAGLCBNIOG)
	{
		return default(POGGIBDPCNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2414BE0", Offset = "0x24131E0", VA = "0x182414BE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OAHICMLDLCN<>.PLKONDMIIKN))]
	public Task<POGGIBDPCNA> JKEBPAPBBPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2415110", Offset = "0x2413710", VA = "0x182415110")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OAHICMLDLCN<>.KNGHPEBNJNH))]
	public Task<POGGIBDPCNA> JKEBPAPBBPP(CancellationToken OOAGLCBNIOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LOFJKGIHNMK
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7108690", Offset = "0x7106C90", VA = "0x187108690")]
	public static OAHICMLDLCN<DABEAPPDAMA> JBGFDEKBNPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x71086F0", Offset = "0x7106CF0", VA = "0x1871086F0")]
	public static OAHICMLDLCN<DABEAPPDAMA> JBGFDEKBNPE(int EPEHJAIAGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x15F9BA0", Offset = "0x15F81A0", VA = "0x1815F9BA0")]
	public static OAHICMLDLCN<T> JBGFDEKBNPE<T>(in T CDJLIJKLHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x233ADF0", Offset = "0x23393F0", VA = "0x18233ADF0")]
	public static OAHICMLDLCN<T> JBGFDEKBNPE<T>(in T CDJLIJKLHLH, int EPEHJAIAGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class GPPGCDLGOCA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private GPPGCDLGOCA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9584E0", Offset = "0x956AE0", VA = "0x1809584E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2773560", Offset = "0x2771B60", VA = "0x182773560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2774960", Offset = "0x2772F60", VA = "0x182774960")]
		public Enumerator(GPPGCDLGOCA<T> IOBPFDIOONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x276FE70", Offset = "0x276E470", VA = "0x18276FE70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x27712A0", Offset = "0x276F8A0", VA = "0x1827712A0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x276D950", Offset = "0x276BF50", VA = "0x18276D950")]
		private void LDJKEIJEBBD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private T[] JFDLGHHNKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int DGHDJOAODLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int OMKALOFOOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private int BOBBHCFAPPK;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3DA0180", Offset = "0x3D9E780", VA = "0x183DA0180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F4C0", Offset = "0x3D9DAC0", VA = "0x183D9F4C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3DA0070", Offset = "0x3D9E670", VA = "0x183DA0070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3DA12E0", Offset = "0x3D9F8E0", VA = "0x183DA12E0")]
	public GPPGCDLGOCA(int IOKNIDFIOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DA0FB0", Offset = "0x3D9F5B0", VA = "0x183DA0FB0")]
	public void PEECNHFNIGK(T KIJLBFEDEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DA01C0", Offset = "0x3D9E7C0", VA = "0x183DA01C0")]
	public void LNIIODIKDBH(IEnumerable<T> NBJMBPAGFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F590", Offset = "0x3D9DB90", VA = "0x183D9F590")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3DA00F0", Offset = "0x3D9E6F0", VA = "0x183DA00F0")]
	public void LEMADFLEAFL(int EGIKAKGFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F5B0", Offset = "0x3D9DBB0", VA = "0x183D9F5B0")]
	public void HBKOOAKDJII(int EGIKAKGFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F780", Offset = "0x3D9DD80", VA = "0x183D9F780")]
	public void HIHPLECEEBI(T[] JHKFLJIAOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3DA1070", Offset = "0x3D9F670", VA = "0x183DA1070")]
	public Enumerator PFBFKEIKCCB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3DA1260", Offset = "0x3D9F860", VA = "0x183DA1260", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3DA1260", Offset = "0x3D9F860", VA = "0x183DA1260", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D9FC30", Offset = "0x3D9E230", VA = "0x183D9FC30")]
	private int HOCBHLLJJIK(int IIOMOLKAONM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F560", Offset = "0x3D9DB60", VA = "0x183D9F560")]
	private int ANOBBNBLHKG(int IIOMOLKAONM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class LOEGFDJKKMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void GJDCCMFCHPP(object[] GDDHAFPALIL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	protected LOEGFDJKKMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class HIBGCDMKNKM<T> : LOEGFDJKKMJ
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	protected struct MHGEAJONJPB
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum LLOKGEACBEK
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public LLOKGEACBEK LFBJHCMDIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public T INJMGBDPOBO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int DGLNFHNMMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly bool KHFBKFEGNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly bool LKOFDNGEIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	protected List<T> NNBGPFJDPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<MHGEAJONJPB> KOJDKLFJJAA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool DCDNKDOCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DF50", Offset = "0x2D9C550", VA = "0x182D9DF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E1B0", Offset = "0x2D9C7B0", VA = "0x182D9E1B0")]
	protected HIBGCDMKNKM(bool LKOFDNGEIII, bool KHFBKFEGNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2D9DD80", Offset = "0x2D9C380", VA = "0x182D9DD80")]
	protected bool CLLHDDPLOHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2D9DF90", Offset = "0x2D9C590", VA = "0x182D9DF90")]
	protected void OPIFPGIFJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2D9DAC0", Offset = "0x2D9C0C0", VA = "0x182D9DAC0")]
	protected void BMAOHAEOBII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1997BD0", Offset = "0x19961D0", VA = "0x181997BD0")]
	private static void IGAADGGBGLG<U>(ref List<U> EKFNNDEBOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2D9E050", Offset = "0x2D9C650", VA = "0x182D9E050", Slot = "5")]
	public void PEECNHFNIGK(T INJMGBDPOBO, bool DHPJLCLMLLL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2D9DE00", Offset = "0x2D9C400", VA = "0x182D9DE00", Slot = "6")]
	public void FAKCPBGGFBC(T INJMGBDPOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D9DC70", Offset = "0x2D9C270", VA = "0x182D9DC70")]
	public void CCIICLEBIPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface IAEFHFNMGLF
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEECNHFNIGK(Action INJMGBDPOBO, bool DHPJLCLMLLL = false);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAKCPBGGFBC(Action INJMGBDPOBO);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class BOBAGNNLEHP : HIBGCDMKNKM<Action>, IAEFHFNMGLF
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x71041F0", Offset = "0x71027F0", VA = "0x1871041F0")]
	public BOBAGNNLEHP(bool LKOFDNGEIII = false, bool KHFBKFEGNPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7103F80", Offset = "0x7102580", VA = "0x187103F80")]
	public void HDLCFALLNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7103EB0", Offset = "0x71024B0", VA = "0x187103EB0", Slot = "4")]
	public override void GJDCCMFCHPP(object[] GDDHAFPALIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7103F20", Offset = "0x7102520", VA = "0x187103F20")]
	public static BOBAGNNLEHP HDDBLAAJMND(BOBAGNNLEHP GHKMNBJAFIK, Action INJMGBDPOBO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7104190", Offset = "0x7102790", VA = "0x187104190")]
	public static BOBAGNNLEHP KIHOACEIGGN(BOBAGNNLEHP GHKMNBJAFIK, Action INJMGBDPOBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KCCOKHMNLNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEECNHFNIGK(Action<T> INJMGBDPOBO, bool DHPJLCLMLLL = false);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAKCPBGGFBC(Action<T> INJMGBDPOBO);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class NGNHBGJPOEA<T> : HIBGCDMKNKM<Action<T>>, KCCOKHMNLNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x205B310", Offset = "0x2059910", VA = "0x18205B310")]
	public NGNHBGJPOEA(bool LKOFDNGEIII = false, bool KHFBKFEGNPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x26C4650", Offset = "0x26C2C50", VA = "0x1826C4650")]
	public void HDLCFALLNOK(T KIJLBFEDEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x26C2690", Offset = "0x26C0C90", VA = "0x1826C2690", Slot = "4")]
	public override void GJDCCMFCHPP(object[] GDDHAFPALIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x26C3E40", Offset = "0x26C2440", VA = "0x1826C3E40")]
	public static NGNHBGJPOEA<T> HDDBLAAJMND(NGNHBGJPOEA<T> GHKMNBJAFIK, Action<T> INJMGBDPOBO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x26C5DA0", Offset = "0x26C43A0", VA = "0x1826C5DA0")]
	public static NGNHBGJPOEA<T> KIHOACEIGGN(NGNHBGJPOEA<T> GHKMNBJAFIK, Action<T> INJMGBDPOBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface PNPDPCCCOGN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEECNHFNIGK(Action<T, U> INJMGBDPOBO, bool DHPJLCLMLLL = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAKCPBGGFBC(Action<T, U> INJMGBDPOBO);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class MKGJAENGAJB<T, U> : HIBGCDMKNKM<Action<T, U>>, PNPDPCCCOGN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x205B310", Offset = "0x2059910", VA = "0x18205B310")]
	public MKGJAENGAJB(bool LKOFDNGEIII = false, bool KHFBKFEGNPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3482750", Offset = "0x3480D50", VA = "0x183482750")]
	public void HDLCFALLNOK(T KIJLBFEDEPN, U OIKBFCHMBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3481380", Offset = "0x347F980", VA = "0x183481380", Slot = "4")]
	public override void GJDCCMFCHPP(object[] GDDHAFPALIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3481D10", Offset = "0x3480310", VA = "0x183481D10")]
	public static MKGJAENGAJB<T, U> HDDBLAAJMND(MKGJAENGAJB<T, U> GHKMNBJAFIK, Action<T, U> INJMGBDPOBO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3484800", Offset = "0x3482E00", VA = "0x183484800")]
	public static MKGJAENGAJB<T, U> KIHOACEIGGN(MKGJAENGAJB<T, U> GHKMNBJAFIK, Action<T, U> INJMGBDPOBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface ABJCMPHEKMN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEECNHFNIGK(Action<T, U, V> INJMGBDPOBO, bool DHPJLCLMLLL = false);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAKCPBGGFBC(Action<T, U, V> INJMGBDPOBO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class LJCNJFONIBP<T, U, V> : HIBGCDMKNKM<Action<T, U, V>>, ABJCMPHEKMN<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x205B310", Offset = "0x2059910", VA = "0x18205B310")]
	public LJCNJFONIBP(bool LKOFDNGEIII = false, bool KHFBKFEGNPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2E083F0", Offset = "0x2E069F0", VA = "0x182E083F0")]
	public void HDLCFALLNOK(T KIJLBFEDEPN, U OIKBFCHMBBA, V PENAIOHMHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2E06450", Offset = "0x2E04A50", VA = "0x182E06450", Slot = "4")]
	public override void GJDCCMFCHPP(object[] GDDHAFPALIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2E06B90", Offset = "0x2E05190", VA = "0x182E06B90")]
	public static LJCNJFONIBP<T, U, V> HDDBLAAJMND(LJCNJFONIBP<T, U, V> GHKMNBJAFIK, Action<T, U, V> INJMGBDPOBO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2E08D80", Offset = "0x2E07380", VA = "0x182E08D80")]
	public static LJCNJFONIBP<T, U, V> KIHOACEIGGN(LJCNJFONIBP<T, U, V> GHKMNBJAFIK, Action<T, U, V> INJMGBDPOBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MLGHEEAOPHM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEECNHFNIGK(Action<T, U, V, W> INJMGBDPOBO, bool DHPJLCLMLLL = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAKCPBGGFBC(Action<T, U, V, W> INJMGBDPOBO);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class HBBEHIBNHKC<T, U, V, W> : HIBGCDMKNKM<Action<T, U, V, W>>, MLGHEEAOPHM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x205B310", Offset = "0x2059910", VA = "0x18205B310")]
	public HBBEHIBNHKC(bool LKOFDNGEIII = false, bool KHFBKFEGNPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x38FED70", Offset = "0x38FD370", VA = "0x1838FED70")]
	public void HDLCFALLNOK(T KIJLBFEDEPN, U OIKBFCHMBBA, V PENAIOHMHFM, W NPCNEKJOJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x38FD650", Offset = "0x38FBC50", VA = "0x1838FD650", Slot = "4")]
	public override void GJDCCMFCHPP(object[] GDDHAFPALIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x38FDC60", Offset = "0x38FC260", VA = "0x1838FDC60")]
	public static HBBEHIBNHKC<T, U, V, W> HDDBLAAJMND(HBBEHIBNHKC<T, U, V, W> GHKMNBJAFIK, Action<T, U, V, W> INJMGBDPOBO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x38FF270", Offset = "0x38FD870", VA = "0x1838FF270")]
	public static HBBEHIBNHKC<T, U, V, W> KIHOACEIGGN(HBBEHIBNHKC<T, U, V, W> GHKMNBJAFIK, Action<T, U, V, W> INJMGBDPOBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GNCNFIBDGPH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEECNHFNIGK(Action<T, U, V, W, X> INJMGBDPOBO, bool DHPJLCLMLLL = false);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAKCPBGGFBC(Action<T, U, V, W, X> INJMGBDPOBO);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class BDFKEPPJKGA<T, U, V, W, X> : HIBGCDMKNKM<Action<T, U, V, W, X>>, GNCNFIBDGPH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x205B310", Offset = "0x2059910", VA = "0x18205B310")]
	public BDFKEPPJKGA(bool LKOFDNGEIII = false, bool KHFBKFEGNPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x307CEB0", Offset = "0x307B4B0", VA = "0x18307CEB0")]
	public void HDLCFALLNOK(T KIJLBFEDEPN, U OIKBFCHMBBA, V PENAIOHMHFM, W NPCNEKJOJLD, X HMINFBNCMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x307C3D0", Offset = "0x307A9D0", VA = "0x18307C3D0", Slot = "4")]
	public override void GJDCCMFCHPP(object[] GDDHAFPALIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x307CAE0", Offset = "0x307B0E0", VA = "0x18307CAE0")]
	public static BDFKEPPJKGA<T, U, V, W, X> HDDBLAAJMND(BDFKEPPJKGA<T, U, V, W, X> GHKMNBJAFIK, Action<T, U, V, W, X> INJMGBDPOBO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x307D150", Offset = "0x307B750", VA = "0x18307D150")]
	public static BDFKEPPJKGA<T, U, V, W, X> KIHOACEIGGN(BDFKEPPJKGA<T, U, V, W, X> GHKMNBJAFIK, Action<T, U, V, W, X> INJMGBDPOBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BODCAKCMLFA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEECNHFNIGK(Action<T, U, V, W, X, Y> INJMGBDPOBO, bool DHPJLCLMLLL = false);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAKCPBGGFBC(Action<T, U, V, W, X, Y> INJMGBDPOBO);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class BHJGDMMCLGC<T, U, V, W, X, Y> : HIBGCDMKNKM<Action<T, U, V, W, X, Y>>, BODCAKCMLFA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x205B310", Offset = "0x2059910", VA = "0x18205B310")]
	public BHJGDMMCLGC(bool LKOFDNGEIII = false, bool KHFBKFEGNPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2E2BD80", Offset = "0x2E2A380", VA = "0x182E2BD80")]
	public void HDLCFALLNOK(T KIJLBFEDEPN, U OIKBFCHMBBA, V PENAIOHMHFM, W NPCNEKJOJLD, X HMINFBNCMPL, Y MPEHLADJKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2E2B1E0", Offset = "0x2E297E0", VA = "0x182E2B1E0", Slot = "4")]
	public override void GJDCCMFCHPP(object[] GDDHAFPALIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2E2B9C0", Offset = "0x2E29FC0", VA = "0x182E2B9C0")]
	public static BHJGDMMCLGC<T, U, V, W, X, Y> HDDBLAAJMND(BHJGDMMCLGC<T, U, V, W, X, Y> GHKMNBJAFIK, Action<T, U, V, W, X, Y> INJMGBDPOBO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2E2C320", Offset = "0x2E2A920", VA = "0x182E2C320")]
	public static BHJGDMMCLGC<T, U, V, W, X, Y> KIHOACEIGGN(BHJGDMMCLGC<T, U, V, W, X, Y> GHKMNBJAFIK, Action<T, U, V, W, X, Y> INJMGBDPOBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct KFFIJEDDECI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MIIENOMNLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int NFDNMIJCNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int JKAAHIMEBJE;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2064FD0", Offset = "0x20635D0", VA = "0x182064FD0")]
	private KFFIJEDDECI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HNFLDGKCMOI, int DBJDIGNDMEO, int CMGGAOILMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x34A2050", Offset = "0x34A0650", VA = "0x1834A2050")]
	public static KFFIJEDDECI<T> JBGFDEKBNPE()
	{
		return default(KFFIJEDDECI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x34A32A0", Offset = "0x34A18A0", VA = "0x1834A32A0")]
	public (int, int, Task<T>) OAKIONABNJA(int IJBMFBKGJBM, [Optional] CancellationToken OOAGLCBNIOG, double HCHPBOOIDPB = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x34A2140", Offset = "0x34A0740", VA = "0x1834A2140")]
	public void MHNPNDCIPPO(int IJBMFBKGJBM, int CMGGAOILMDM, in T COGPMIAOIBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class KLOODHIHIGO
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7108300", Offset = "0x7106900", VA = "0x187108300")]
	public static KFFIJEDDECI<DABEAPPDAMA> JBGFDEKBNPE()
	{
		return default(KFFIJEDDECI<DABEAPPDAMA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7108350", Offset = "0x7106950", VA = "0x187108350")]
	public static void MHNPNDCIPPO(this in KFFIJEDDECI<DABEAPPDAMA> PBJDHAKDMFG, int IJBMFBKGJBM, int CMGGAOILMDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DefaultMember("Item")]
public class HBGABLNHDDA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<TKey, TVal> PNAKLOMLIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<TVal, TKey> MCDKLJPCIEE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0FB0", Offset = "0x1ACF5B0", VA = "0x181AD0FB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool ICHMNNBEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> EFDMFNKGNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x201EF80", Offset = "0x201D580", VA = "0x18201EF80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TVal> AKLPMGMPMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x265F270", Offset = "0x265D870", VA = "0x18265F270", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TVal KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3901D40", Offset = "0x3900340", VA = "0x183901D40", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3901DB0", Offset = "0x39003B0", VA = "0x183901DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TKey KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3900AD0", Offset = "0x38FF0D0", VA = "0x183900AD0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x39017C0", Offset = "0x38FFDC0", VA = "0x1839017C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3900BF0", Offset = "0x38FF1F0", VA = "0x183900BF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3901C00", Offset = "0x3900200", VA = "0x183901C00", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3900B40", Offset = "0x38FF140", VA = "0x183900B40", Slot = "9")]
	public void Add(TKey NAJDAPHOGEH, TVal FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3900B80", Offset = "0x38FF180", VA = "0x183900B80", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> CDIFGMFCFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3900C50", Offset = "0x38FF250", VA = "0x183900C50", Slot = "8")]
	public bool ContainsKey(TKey NAJDAPHOGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3900CB0", Offset = "0x38FF2B0", VA = "0x183900CB0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x32F4420", Offset = "0x32F2A20", VA = "0x1832F4420", Slot = "10")]
	public bool Remove(TKey NAJDAPHOGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3901B30", Offset = "0x3900130", VA = "0x183901B30", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x28F1FB0", Offset = "0x28F05B0", VA = "0x1828F1FB0", Slot = "11")]
	public bool TryGetValue(TKey NAJDAPHOGEH, out TVal FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2053230", Offset = "0x2051830", VA = "0x182053230", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3900CE0", Offset = "0x38FF2E0", VA = "0x183900CE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] JHKFLJIAOGC, int AELLNPMJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3901A40", Offset = "0x3900040", VA = "0x183901A40")]
	public void PEECNHFNIGK(TVal CHEGNIOHCDA, TKey NAJDAPHOGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3901A80", Offset = "0x3900080", VA = "0x183901A80")]
	public void PEECNHFNIGK(KeyValuePair<TVal, TKey> CDIFGMFCFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3900FD0", Offset = "0x38FF5D0", VA = "0x183900FD0")]
	public bool GBLPAFIJCMF(TVal NAJDAPHOGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3901040", Offset = "0x38FF640", VA = "0x183901040")]
	public bool GGHKDEOPGPN(KeyValuePair<TVal, TKey> CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3900DE0", Offset = "0x38FF3E0", VA = "0x183900DE0")]
	public bool FAKCPBGGFBC(TVal NAJDAPHOGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3900DE0", Offset = "0x38FF3E0", VA = "0x183900DE0")]
	public bool FAKCPBGGFBC(KeyValuePair<TVal, TKey> CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3900D40", Offset = "0x38FF340", VA = "0x183900D40")]
	public bool DJABJOJOKLP(TVal NAJDAPHOGEH, out TKey FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3901880", Offset = "0x38FFE80", VA = "0x183901880")]
	public IEnumerator<KeyValuePair<TVal, TKey>> MFAOEBALFLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3900F30", Offset = "0x38FF530", VA = "0x183900F30")]
	private void FGIOLEFPBDK(TKey NAJDAPHOGEH, TVal CHEGNIOHCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3901160", Offset = "0x38FF760", VA = "0x183901160")]
	private void ILBLCPGFEHL(TKey NAJDAPHOGEH, TVal CHEGNIOHCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x39013D0", Offset = "0x38FF9D0", VA = "0x1839013D0")]
	private bool JEHGDDHMKGJ(TKey NAJDAPHOGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x39016E0", Offset = "0x38FFCE0", VA = "0x1839016E0")]
	private bool JEHGDDHMKGJ(TVal CHEGNIOHCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3901C50", Offset = "0x3900250", VA = "0x183901C50")]
	public HBGABLNHDDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public class NAGJLMNIJJN<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<Internal, External> NMBDNEAMMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Func<External, Internal> MHBGGMNCHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private IList<Internal> EKFNNDEBOAK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IList<Internal> MMMKOAIIHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9989D0", Offset = "0x996FD0", VA = "0x1809989D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool ICHMNNBEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA62EC0", Offset = "0xA614C0", VA = "0x180A62EC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA63250", Offset = "0xA61850", VA = "0x180A63250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2852970", Offset = "0x2850F70", VA = "0x182852970", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2852A10", Offset = "0x2851010", VA = "0x182852A10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2852910", Offset = "0x2850F10", VA = "0x182852910", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2852880", Offset = "0x2850E80", VA = "0x182852880")]
	public NAGJLMNIJJN(Func<Internal, External> NMBDNEAMMEM, Func<External, Internal> MHBGGMNCHHL, bool ELNCOGPNOCM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x28525B0", Offset = "0x2850BB0", VA = "0x1828525B0", Slot = "6")]
	public int IndexOf(External CDIFGMFCFLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2852240", Offset = "0x2850840", VA = "0x182852240", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x28522A0", Offset = "0x28508A0", VA = "0x1828522A0", Slot = "13")]
	public bool Contains(External CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2852330", Offset = "0x2850930", VA = "0x182852330", Slot = "14")]
	public void CopyTo(External[] JHKFLJIAOGC, int AELLNPMJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2852160", Offset = "0x2850760", VA = "0x182852160", Slot = "11")]
	public void Add(External CDIFGMFCFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2852690", Offset = "0x2850C90", VA = "0x182852690", Slot = "7")]
	public void Insert(int IIOMOLKAONM, External CDIFGMFCFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x28527F0", Offset = "0x2850DF0", VA = "0x1828527F0", Slot = "15")]
	public bool Remove(External CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2852730", Offset = "0x2850D30", VA = "0x182852730", Slot = "8")]
	public void RemoveAt(int IIOMOLKAONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2852540", Offset = "0x2850B40", VA = "0x182852540", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x1226940", Offset = "0x1224F40", VA = "0x181226940", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DefaultMember("Item")]
public class NANKNPGJEBH<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<Internal, External> NMBDNEAMMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IReadOnlyList<Internal> EKFNNDEBOAK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> MMMKOAIIHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x920EA0", Offset = "0x91F4A0", VA = "0x180920EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ICHMNNBEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x24E7520", Offset = "0x24E5B20", VA = "0x1824E7520", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x24E74C0", Offset = "0x24E5AC0", VA = "0x1824E74C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x15BDFA0", Offset = "0x15BC5A0", VA = "0x1815BDFA0")]
	public NANKNPGJEBH(Func<Internal, External> NMBDNEAMMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x24E7470", Offset = "0x24E5A70", VA = "0x1824E7470")]
	public NANKNPGJEBH(IReadOnlyList<Internal> EKFNNDEBOAK, Func<Internal, External> NMBDNEAMMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x24E7260", Offset = "0x24E5860", VA = "0x1824E7260")]
	public void HIHPLECEEBI(External[] JHKFLJIAOGC, int AELLNPMJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x24E71F0", Offset = "0x24E57F0", VA = "0x1824E71F0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2135D80", Offset = "0x2134380", VA = "0x182135D80", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class CLLPNLLHFID<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private IReadOnlyList<Internal> EKFNNDEBOAK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IReadOnlyList<Internal> MMMKOAIIHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ICHMNNBEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public External KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC0A0", Offset = "0x2BBA6A0", VA = "0x182BBC0A0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC040", Offset = "0x2BBA640", VA = "0x182BBC040", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x15BDFA0", Offset = "0x15BC5A0", VA = "0x1815BDFA0")]
	public CLLPNLLHFID(IReadOnlyList<Internal> EKFNNDEBOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBD10", Offset = "0x2BBA310", VA = "0x182BBBD10")]
	public bool GGHKDEOPGPN(External CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBE20", Offset = "0x2BBA420", VA = "0x182BBBE20")]
	public void HIHPLECEEBI(External[] JHKFLJIAOGC, int AELLNPMJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBDB0", Offset = "0x2BBA3B0", VA = "0x182BBBDB0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1226940", Offset = "0x1224F40", VA = "0x181226940", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class AOGPKIGEJNN<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> NKPHHFNFOGI(TRequest PKNENDONMCN, CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum JOCFOIMMIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class NGFHEJHMDAD
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private const float CCNHIJBINGG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TimeSpan IBPAJPPJGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int CMBCNILEDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public JOCFOIMMIMJ BCFNKHGBPIF;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly NGFHEJHMDAD EDEKLFBDJFC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float JNFDIOLAPLO
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x26BCCA0", Offset = "0x26BB2A0", VA = "0x1826BCCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan PKENGNEJBDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x26BCD10", Offset = "0x26BB310", VA = "0x1826BCD10")]
		public NGFHEJHMDAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct FHOOGHFFAGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly TRequest PKNENDONMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly CancellationToken OOAGLCBNIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly TaskCompletionSource<TResult> PIOIJHMDOGD;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x21F9480", Offset = "0x21F7A80", VA = "0x1821F9480")]
		public FHOOGHFFAGC(TRequest PKNENDONMCN, TaskCompletionSource<TResult> PIOIJHMDOGD, CancellationToken OOAGLCBNIOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class GJFENDNIJLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public AOGPKIGEJNN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public GJFENDNIJLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2DCAC60", Offset = "0x2DC9260", VA = "0x182DCAC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class AACECBOCGBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AOGPKIGEJNN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private FHOOGHFFAGC <req>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private Task<TResult> <processTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TResult <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TResult <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private OperationCanceledException <oce>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public AACECBOCGBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x26C9D20", Offset = "0x26C8320", VA = "0x1826C9D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CancellationTokenSource JKFCILAHPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly List<FHOOGHFFAGC> IDPHDGMPAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly NGFHEJHMDAD GPAFDOJMCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly NKPHHFNFOGI BMCECGKIGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Task PIHOACNFJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int HADJHHHIJID;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3C68720", Offset = "0x3C66D20", VA = "0x183C68720")]
	public AOGPKIGEJNN(NKPHHFNFOGI BMCECGKIGBE, [Optional] NGFHEJHMDAD GPAFDOJMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3C67A40", Offset = "0x3C66040", VA = "0x183C67A40")]
	public Task<TResult> JGNKKGJDEDD(TRequest PKNENDONMCN, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3C684D0", Offset = "0x3C66AD0", VA = "0x183C684D0")]
	private void POMNMBLPEAI(FHOOGHFFAGC LGOOFKMOMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3C678F0", Offset = "0x3C65EF0", VA = "0x183C678F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOGPKIGEJNN<, >.GJFENDNIJLK))]
	private Task HEGACNKGKPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3C673F0", Offset = "0x3C659F0", VA = "0x183C673F0")]
	private FHOOGHFFAGC EFFKHCOBEBE()
	{
		return default(FHOOGHFFAGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3C680F0", Offset = "0x3C666F0", VA = "0x183C680F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AOGPKIGEJNN<, >.AACECBOCGBD))]
	private Task KHAPAIKBNHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3C66DD0", Offset = "0x3C653D0", VA = "0x183C66DD0")]
	private void BNDILPFKNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3C66EA0", Offset = "0x3C654A0", VA = "0x183C66EA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface EEHMDHLCLLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface EMOEKDEJGED<T> : EEHMDHLCLLD
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T CNODGJBIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GKGOFPOKIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string JGLIBLIFPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMOEKDEJGED<T> BKELMOJDFFB(Action<T> CFGIBFFHJMB);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EMOEKDEJGED<T> AOINAPBKLNK(Action<T> CFGIBFFHJMB);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMOEKDEJGED<T> CJGKKNCBJMN(Action<T, T> KKGPDNGGFMC);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EMOEKDEJGED<T> KKDCFNFNFGB(Action<T, T> KKGPDNGGFMC);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EMOEKDEJGED<T> IHKPKKJACJE(Action<string> PKKHCINGAMB);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EMOEKDEJGED<T> GEAHMOIIMFA(Action<string> PKKHCINGAMB);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class OJHLMLIDFKL<T> : EMOEKDEJGED<T>, EEHMDHLCLLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private MKGJAENGAJB<T, T> EHGEIMHOLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private NGNHBGJPOEA<T> FODLFJALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private NGNHBGJPOEA<string> KMAIMBIDOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private string KAEDNDEPIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private T COGPMIAOIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool BGINCEAGADP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T CNODGJBIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9A2F20", Offset = "0x9A1520", VA = "0x1809A2F20", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x121C940", Offset = "0x121AF40", VA = "0x18121C940", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GKGOFPOKIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA75420", Offset = "0xA73A20", VA = "0x180A75420", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string JGLIBLIFPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA61590", Offset = "0xA5FB90", VA = "0x180A61590", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x98A7B0", Offset = "0x988DB0", VA = "0x18098A7B0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2658250", Offset = "0x2656850", VA = "0x182658250")]
	private void BHPLEEDKOEH(T OGLJJNFALNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x26581A0", Offset = "0x26567A0", VA = "0x1826581A0")]
	private void BHDGIOEICMG(string JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x26580F0", Offset = "0x26566F0", VA = "0x1826580F0")]
	public void BCFKLBADKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2658380", Offset = "0x2656980", VA = "0x182658380", Slot = "6")]
	public EMOEKDEJGED<T> CJGKKNCBJMN(Action<T, T> KKGPDNGGFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x26584E0", Offset = "0x2656AE0", VA = "0x1826584E0", Slot = "7")]
	public EMOEKDEJGED<T> KKDCFNFNFGB(Action<T, T> KKGPDNGGFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x26582F0", Offset = "0x26568F0", VA = "0x1826582F0", Slot = "4")]
	public EMOEKDEJGED<T> BKELMOJDFFB(Action<T> KKGPDNGGFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x26580A0", Offset = "0x26566A0", VA = "0x1826580A0", Slot = "5")]
	public EMOEKDEJGED<T> AOINAPBKLNK(Action<T> CFGIBFFHJMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2658440", Offset = "0x2656A40", VA = "0x182658440", Slot = "8")]
	public EMOEKDEJGED<T> IHKPKKJACJE(Action<string> PKKHCINGAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x26583D0", Offset = "0x26569D0", VA = "0x1826583D0", Slot = "9")]
	public EMOEKDEJGED<T> GEAHMOIIMFA(Action<string> PKKHCINGAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2658530", Offset = "0x2656B30", VA = "0x182658530")]
	public OJHLMLIDFKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class CBPLGJFJLHH
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class NIDOIHOLFDG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public EMOEKDEJGED<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public CDOEGNNFKFF<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public NIDOIHOLFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x26C7B50", Offset = "0x26C6150", VA = "0x1826C7B50")]
		internal void JIKIEHBLJGK(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x169F8C0", Offset = "0x169DEC0", VA = "0x18169F8C0")]
	public static LEKACFEIBBA<T> ODJMIGNPKED<T>(this EMOEKDEJGED<T> AAKDPEOKDNK, Action<T> OIBMDOLHJFJ)
	{
		return null;
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x2F6BB20", Offset = "0x2F6A120", VA = "0x182F6BB20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7027220", Offset = "0x7025820", VA = "0x187027220")]
		public SerializedGuid(in Guid IKGPBILBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x710A190", Offset = "0x7108790", VA = "0x18710A190")]
		public static SerializedGuid KHKBEGPKPDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7109E50", Offset = "0x7108450", VA = "0x187109E50")]
		public static SerializedGuid BDOFLBMGACM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7109EE0", Offset = "0x71084E0", VA = "0x187109EE0")]
		public bool DDCPNIBOGHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x70271F0", Offset = "0x70257F0", VA = "0x1870271F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x710A220", Offset = "0x7108820", VA = "0x18710A220", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x710A100", Offset = "0x7108700", VA = "0x18710A100")]
		public bool FCJJJAFBLNE(in Guid IKGPBILBBIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7109F70", Offset = "0x7108570", VA = "0x187109F70", Slot = "7")]
		public bool Equals(SerializedGuid EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x710A020", Offset = "0x7108620", VA = "0x18710A020", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7027140", Offset = "0x7025740", VA = "0x187027140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7026F80", Offset = "0x7025580", VA = "0x187026F80", Slot = "6")]
		public int CompareTo(SerializedGuid EJECOGCICOM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class CPHJCJPNPDD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Type KGKDNDOIGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string NOHHEAOBJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool FOECNCGCNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool FIMCJMBFFNB;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7105110", Offset = "0x7103710", VA = "0x187105110")]
	public CPHJCJPNPDD(Type JBOAFCICBPL, string GLLEMEFJADE, bool BIIFJEOMOIP = false, bool HCJNIJOKDHE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class NLELJIEANCE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<T> EKFNNDEBOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private HashSet<T> IAHJIJDLLOL;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0FB0", Offset = "0x1ACF5B0", VA = "0x181AD0FB0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ICHMNNBEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x921810", Offset = "0x91FE10", VA = "0x180921810", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T KCHGKMPBAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1A4B330", Offset = "0x1A49930", VA = "0x181A4B330", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2FB31E0", Offset = "0x2FB17E0", VA = "0x182FB31E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2CF0B20", Offset = "0x2CEF120", VA = "0x182CF0B20", Slot = "11")]
	public void Add(T CDIFGMFCFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2CE0", Offset = "0x2FB12E0", VA = "0x182FB2CE0")]
	public bool OBNDLHFELBO(T CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2FB0", Offset = "0x2FB15B0", VA = "0x182FB2FB0", Slot = "15")]
	public bool Remove(T CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x28F1F30", Offset = "0x28F0530", VA = "0x1828F1F30", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1ACDF90", Offset = "0x1ACC590", VA = "0x181ACDF90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2840", Offset = "0x2FB0E40", VA = "0x182FB2840", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x21EFEB0", Offset = "0x21EE4B0", VA = "0x1821EFEB0", Slot = "13")]
	public bool Contains(T CDIFGMFCFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2FB28A0", Offset = "0x2FB0EA0", VA = "0x182FB28A0", Slot = "14")]
	public void CopyTo(T[] JHKFLJIAOGC, int AELLNPMJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2FB28D0", Offset = "0x2FB0ED0", VA = "0x182FB28D0", Slot = "6")]
	public int IndexOf(T CDIFGMFCFLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2900", Offset = "0x2FB0F00", VA = "0x182FB2900", Slot = "7")]
	public void Insert(int IIOMOLKAONM, T CDIFGMFCFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2D80", Offset = "0x2FB1380", VA = "0x182FB2D80", Slot = "8")]
	public void RemoveAt(int IIOMOLKAONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2A90", Offset = "0x2FB1090", VA = "0x182FB2A90")]
	public void NJNNHBCGMEG(Predicate<T> NCFEICGKGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C63060", Offset = "0x2C61660", VA = "0x182C63060")]
	public void FDNONIHFKFJ(Comparison<T> JOEBNGPKAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2FB3030", Offset = "0x2FB1630", VA = "0x182FB3030")]
	public NLELJIEANCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class JGIMCOCANDJ
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7107C10", Offset = "0x7106210", VA = "0x187107C10")]
	public static Vector3 PNNJGJKPOPD(this GameObject CGLKMGEDNPH, float OJHGFFGCKBJ)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EONKDOCNJDJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Type KGKDNDOIGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly string NOHHEAOBJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool FOECNCGCNFL;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x71055A0", Offset = "0x7103BA0", VA = "0x1871055A0")]
	public EONKDOCNJDJ(Type JBOAFCICBPL, string GLLEMEFJADE, bool BIIFJEOMOIP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GCAHBMGEOCN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x71067A0", Offset = "0x7104DA0", VA = "0x1871067A0")]
	public GCAHBMGEOCN(string JIEHBANCLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7106810", Offset = "0x7104E10", VA = "0x187106810")]
	public GCAHBMGEOCN(string JIEHBANCLJP, Exception CLMDDJKOHJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LDJLGPFGDIC
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x71083D0", Offset = "0x71069D0", VA = "0x1871083D0")]
	[NotNull]
	public static byte[] GDHCNAFHOFF(this LMAAFGFGLNP FFEJJCLEBCB, byte[] KBCJLCIGOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7108410", Offset = "0x7106A10", VA = "0x187108410")]
	[NotNull]
	public static byte[] GDHCNAFHOFF(this LMAAFGFGLNP FFEJJCLEBCB, HashAlgorithmName MKLJHHBDDJE, byte[] KBCJLCIGOKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface LMAAFGFGLNP
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash PFEGKNHPDEP);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface GEBDHJJBGIO : LMAAFGFGLNP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] BODIBHFMIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[CanBeNull]
	byte[] FOPPAFJMHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	UnityEngine.Object JICEIOLAEDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JGDHPDANOHP
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MEABGDMENFL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7108950", Offset = "0x7106F50", VA = "0x187108950")]
		public MEABGDMENFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x71088F0", Offset = "0x7106EF0", VA = "0x1871088F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const byte PHCLJJHEENL = 1;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const byte FINMGAMBHAH = 0;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> AHIFKLEOBJI;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static bool EMHKHCNGNJK;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x19F3740", Offset = "0x19F1D40", VA = "0x1819F3740")]
	[Conditional("UNITY_EDITOR")]
	private static void IEBLPDMPGLO<T>(params T[] FLGFFMEHAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7106AC0", Offset = "0x71050C0", VA = "0x187106AC0")]
	public static IDisposable CENDKHHNPPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7107530", Offset = "0x7105B30", VA = "0x187107530")]
	public static void HJJDJBCNPDF(this IncrementalHash FDBHFGIPGKI, [CanBeNull] GameObject CGLKMGEDNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x19F3670", Offset = "0x19F1C70", VA = "0x1819F3670")]
	public static void HJJDJBCNPDF<T>(this IncrementalHash FDBHFGIPGKI, [CanBeNull] T AEKHFLGBLPB) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x19F3E80", Offset = "0x19F2480", VA = "0x1819F3E80")]
	public static void NILFMBFPHCC<T>(this IncrementalHash FDBHFGIPGKI, [CanBeNull] T FFEJJCLEBCB) where T : LMAAFGFGLNP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x19F3A30", Offset = "0x19F2030", VA = "0x1819F3A30")]
	public static void LBFAALMEJGD<T>(this IncrementalHash FDBHFGIPGKI, [CanBeNull] IList<T> OHFJMHLINJO) where T : LMAAFGFGLNP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x71074A0", Offset = "0x7105AA0", VA = "0x1871074A0")]
	private static bool GPDKBPNEFJK([CanBeNull] LMAAFGFGLNP FFEJJCLEBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7106ED0", Offset = "0x71054D0", VA = "0x187106ED0")]
	public static void FEDFKMEJEAA(this IncrementalHash PFEGKNHPDEP, [CanBeNull] string LLNHEPAKPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7107940", Offset = "0x7105F40", VA = "0x187107940")]
	public static void ONJHPDKPHBB(this IncrementalHash PFEGKNHPDEP, long OAMGKGOBBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7106F30", Offset = "0x7105530", VA = "0x187106F30")]
	public static void FLPINKOPKFA(this IncrementalHash PFEGKNHPDEP, int NAEOMFDLPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x71072D0", Offset = "0x71058D0", VA = "0x1871072D0")]
	public static void GKIFPLLJHNA(this IncrementalHash PFEGKNHPDEP, short ALHCCCOHOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7106D60", Offset = "0x7105360", VA = "0x187106D60")]
	public static void FAPJDJFLPGK(this IncrementalHash PFEGKNHPDEP, byte MJCGPOKNJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7107100", Offset = "0x7105700", VA = "0x187107100")]
	public static void GGEKIADEDMH(this IncrementalHash PFEGKNHPDEP, bool CGAAALEAMFJ, bool EIDLOLLKMHH = false, bool EKKBOLBDNPC = false, bool PGNAJNKEIPI = false, bool LCDKPKIJAFK = false, bool MBGKANOLKJP = false, bool NBIPIAJCKDO = false, bool FBEBPIDKDKJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x19F2F80", Offset = "0x19F1580", VA = "0x1819F2F80")]
	public static void DHJDFFHGMLL<T>(this IncrementalHash PFEGKNHPDEP, T ABAPMJBNCAL) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7106BD0", Offset = "0x71051D0", VA = "0x187106BD0")]
	public static void DFCBLKDMBAM(this IncrementalHash PFEGKNHPDEP, float DNACLOFEHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7106C30", Offset = "0x7105230", VA = "0x187106C30")]
	public static void DIACJLFKFLH(this IncrementalHash PFEGKNHPDEP, double FENEEHNEJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7106C90", Offset = "0x7105290", VA = "0x187106C90")]
	public static void DLGJIIJEACC(this IncrementalHash PFEGKNHPDEP, ulong GAHFDEOLHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7106D00", Offset = "0x7105300", VA = "0x187106D00")]
	public static void ELOGOKHEKEA(this IncrementalHash PFEGKNHPDEP, uint AEAKMAFAJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7106B60", Offset = "0x7105160", VA = "0x187106B60")]
	public static void CJCAIOCAPOF(this IncrementalHash PFEGKNHPDEP, ushort DFHJAIHLIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7107620", Offset = "0x7105C20", VA = "0x187107620")]
	public static void ODEOPMIHGAF(this IncrementalHash PFEGKNHPDEP, Vector3 NMIBKNGLJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7107780", Offset = "0x7105D80", VA = "0x187107780")]
	public static void OEPLKFKCHGH(this IncrementalHash PFEGKNHPDEP, Quaternion EMGILMIMADF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FMBDKHFBLJH
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7106230", Offset = "0x7104830", VA = "0x187106230")]
	[NotNull]
	public static byte[] GDHCNAFHOFF(this GEBDHJJBGIO BCENMECLFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x71062A0", Offset = "0x71048A0", VA = "0x1871062A0")]
	[NotNull]
	public static byte[] GDHCNAFHOFF(this GEBDHJJBGIO BCENMECLFIE, HashAlgorithmName MKLJHHBDDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7106430", Offset = "0x7104A30", VA = "0x187106430")]
	public static bool NBNCGAJFMCO([CanBeNull] this GEBDHJJBGIO BCENMECLFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x71065C0", Offset = "0x7104BC0", VA = "0x1871065C0")]
	public static bool NBNCGAJFMCO([CanBeNull] this GEBDHJJBGIO BCENMECLFIE, out string KAEDNDEPIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x71061C0", Offset = "0x71047C0", VA = "0x1871061C0")]
	private static string ECIHKJIAMAL([CanBeNull] byte[] FBHPMOOILJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7106310", Offset = "0x7104910", VA = "0x187106310")]
	private static bool IDGJAPLFEBN([NotNull] GEBDHJJBGIO BCENMECLFIE, [CanBeNull] out byte[] MDJPBKINLLN, [CanBeNull] out byte[] CFONCONPNOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class KONLFNKIMAF<TTask, T> : MPMJDGKIEHM<T>, JELHGAIFJPP, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GDOCEPGKLEG
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private sealed class <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public GDOCEPGKLEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1B5CFE0", Offset = "0x1B5B5E0", VA = "0x181B5CFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public KONLFNKIMAF<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public GDOCEPGKLEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2DBA060", Offset = "0x2DB8660", VA = "0x182DBA060")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KONLFNKIMAF<, >.GDOCEPGKLEG.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> LAMCHDIPOJN(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static bool ECPFPMIGGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Task<T> DNEHMOFNGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly CancellationTokenSource NAANFKJBCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool EAOOMFEELLL;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Task<T> KDFGPGKGOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Task IGIPLNCOJED
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public LEKACFEIBBA<T> GNNAGCKPGGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private ADCACBFKFKM OGODKKJBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1EF0D40", Offset = "0x1EEF340", VA = "0x181EF0D40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool PGDNGHJKGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA62EC0", Offset = "0xA614C0", VA = "0x180A62EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x334D530", Offset = "0x334BB30", VA = "0x18334D530")]
	static KONLFNKIMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x334D890", Offset = "0x334BE90", VA = "0x18334D890")]
	protected KONLFNKIMAF(TTask DNEHMOFNGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x334D120", Offset = "0x334B720", VA = "0x18334D120", Slot = "1")]
	~KONLFNKIMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x334D0F0", Offset = "0x334B6F0", VA = "0x18334D0F0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x334D360", Offset = "0x334B960", VA = "0x18334D360")]
	private void IBHEPNJODHL(bool IDABDNFABCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T FIIGDEHKIDK(TTask GNBCMMJFCAO);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void NMGKJHEBEOO();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KAHBNKECOKA : HFMKDMIJLPP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7107EC0", Offset = "0x71064C0", VA = "0x187107EC0")]
	public KAHBNKECOKA(Exception OHPJJHOMFKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HFMKDMIJLPP<T> : MPMJDGKIEHM<T>, JELHGAIFJPP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public Task<T> KDFGPGKGOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private Task IGIPLNCOJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xCE1E80", Offset = "0xCE0480", VA = "0x180CE1E80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public LEKACFEIBBA<T> GNNAGCKPGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private ADCACBFKFKM OGODKKJBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x98A030", Offset = "0x988630", VA = "0x18098A030", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2D93320", Offset = "0x2D91920", VA = "0x182D93320")]
	public HFMKDMIJLPP(Exception OHPJJHOMFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface JELHGAIFJPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[NotNull]
	Task KDFGPGKGOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[NotNull]
	ADCACBFKFKM GNNAGCKPGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface MPMJDGKIEHM<T> : JELHGAIFJPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[NotNull]
	new Task<T> KDFGPGKGOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	new LEKACFEIBBA<T> GNNAGCKPGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class LHJGGINMGJB : IMMPCLEHMIB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7108650", Offset = "0x7106C50", VA = "0x187108650")]
	public LHJGGINMGJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IMMPCLEHMIB<T> : MPMJDGKIEHM<T>, JELHGAIFJPP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Task<T> KDFGPGKGOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private Task IGIPLNCOJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCE1E80", Offset = "0xCE0480", VA = "0x180CE1E80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public LEKACFEIBBA<T> GNNAGCKPGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private ADCACBFKFKM OGODKKJBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x98A030", Offset = "0x988630", VA = "0x18098A030", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE2E0", Offset = "0x1FFC8E0", VA = "0x181FFE2E0")]
	public IMMPCLEHMIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public sealed class GLGLBCADGJK : NHNLOHOBNME<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class ELPFOCCMLCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action<GLGLBCADGJK> callback;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ELPFOCCMLCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7105430", Offset = "0x7103A30", VA = "0x187105430")]
		internal void FNNLMDKIBHJ(NHNLOHOBNME<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7106970", Offset = "0x7104F70", VA = "0x187106970")]
	public GLGLBCADGJK([Optional] string BLGFPHFOPDG, [Optional] int? NGFICIADCNJ, [Optional] Stopwatch ODKKIBMBPEN, [Optional] Action<string, GPGKHJOCCPD> LMENDDBMPBJ, [Optional] Action<string, GPGKHJOCCPD> OEOINJAPFFG, [Optional] Action<GLGLBCADGJK> KCDHAMPAMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7106890", Offset = "0x7104E90", VA = "0x187106890")]
	private static Action<NHNLOHOBNME<string>> NMNEKAMPBMF(Action<GLGLBCADGJK> OIBMDOLHJFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MNAGENDIIIJ<TKey> : GHMEODICDBF<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class GCMLMFIDCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public EIKEAKGFALO keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public GCMLMFIDCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x15BD420", Offset = "0x15BBA20", VA = "0x1815BD420")]
		internal string MBJDNDFAPGJ(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x29860E0", Offset = "0x29846E0", VA = "0x1829860E0", Slot = "5")]
	protected override string ADOBFCPCHCJ(NHNLOHOBNME<TKey> BCLLAMGBKIH, EIKEAKGFALO FIBOKKFNNCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x28F20A0", Offset = "0x28F06A0", VA = "0x1828F20A0")]
	public MNAGENDIIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class MHNAPELELNB<TKey> : NGDJDMCGNBE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate string HNPMLEHIGBP(TKey NAJDAPHOGEH);

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private const int DJLOKFJEIPC = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly string GCODMJFMJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly double NMOBLNGEFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool CEOHEAGBIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly int KPLFCLKCKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly ISet<string> MAKEHNLPHKL;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x25E3320", Offset = "0x25E1920", VA = "0x1825E3320")]
	private static string PMJPAOGAAEJ(TKey NAJDAPHOGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x25E3360", Offset = "0x25E1960", VA = "0x1825E3360")]
	public MHNAPELELNB(string GCODMJFMJIN = "F2", double NMOBLNGEFKF = double.MaxValue, bool CEOHEAGBIJK = false, int KPLFCLKCKGL = int.MaxValue, [Optional] ISet<string> MAKEHNLPHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x25E2920", Offset = "0x25E0F20", VA = "0x1825E2920", Slot = "4")]
	public override Dictionary<string, string> CNBEGMNDIFH(NHNLOHOBNME<TKey> BCLLAMGBKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x25E3240", Offset = "0x25E1840", VA = "0x1825E3240")]
	private bool JKCNELKGKIB(string EBEMFPIEMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x25E29D0", Offset = "0x25E0FD0", VA = "0x1825E29D0")]
	public Dictionary<string, string> CNBEGMNDIFH(NHNLOHOBNME<TKey> BCLLAMGBKIH, HNPMLEHIGBP FIBOKKFNNCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x25E2F10", Offset = "0x25E1510", VA = "0x1825E2F10")]
	private string IPJEOGDEFNC(StringBuilder PDKJCELOPNI, List<TKey> FFGIMKBNOME, HNPMLEHIGBP FIBOKKFNNCH, bool BIEJJPDEIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x25E30C0", Offset = "0x25E16C0", VA = "0x1825E30C0")]
	private static void JGEJIPNJMBD(StringBuilder AGJEFFJHLEA, string IOLPLGCFFKP, bool PJOJAOOMPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class NGDJDMCGNBE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut CNBEGMNDIFH(NHNLOHOBNME<TKey> BCLLAMGBKIH);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
	protected NGDJDMCGNBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class GHMEODICDBF<TKey> : NGDJDMCGNBE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate string EIKEAKGFALO(TKey NAJDAPHOGEH);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2FF0", Offset = "0x2DC15F0", VA = "0x182DC2FF0")]
	protected string PFABBLOCOBO(double JJCGEKOAILP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2F90", Offset = "0x2DC1590", VA = "0x182DC2F90")]
	protected string IJHOJAHOEFP(int FGIPKGLIHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2DC3060", Offset = "0x2DC1660", VA = "0x182DC3060")]
	private static string PMJPAOGAAEJ(TKey NAJDAPHOGEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2EE0", Offset = "0x2DC14E0", VA = "0x182DC2EE0", Slot = "4")]
	public override string CNBEGMNDIFH(NHNLOHOBNME<TKey> BCLLAMGBKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2DB0", Offset = "0x2DC13B0", VA = "0x182DC2DB0")]
	public string CNBEGMNDIFH(NHNLOHOBNME<TKey> BCLLAMGBKIH, [NotNull] EIKEAKGFALO FIBOKKFNNCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string ADOBFCPCHCJ(NHNLOHOBNME<TKey> BCLLAMGBKIH, [NotNull] EIKEAKGFALO FIBOKKFNNCH);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1226940", Offset = "0x1224F40", VA = "0x181226940")]
	protected GHMEODICDBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class MCPFFGAHDHE
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private class AJIGDAKFCCE : MCPFFGAHDHE
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static MCPFFGAHDHE FBBAELKBDJK
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7103AD0", Offset = "0x71020D0", VA = "0x187103AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override DateTime EGIFJMIKAJB
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x7103A80", Offset = "0x7102080", VA = "0x187103A80", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override float AKPCNBJFGFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7103400", Offset = "0x7101A00", VA = "0x187103400", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7103BD0", Offset = "0x71021D0", VA = "0x187103BD0")]
		public AJIGDAKFCCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static MCPFFGAHDHE IHHADDEKCNE;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static MCPFFGAHDHE EDEKLFBDJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7108760", Offset = "0x7106D60", VA = "0x187108760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public abstract DateTime EGIFJMIKAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public abstract float AKPCNBJFGFA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	protected MCPFFGAHDHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class PJPEDKCCEHI<TKey> : GHMEODICDBF<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct PLIJIHACDFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public EIKEAKGFALO keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static PJPEDKCCEHI<TKey> FBBAELKBDJK;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private const int KJBJKFPHNCL = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly string[] FNNJEJIBKKG;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D250", Offset = "0x2C5B850", VA = "0x182C5D250")]
	private PJPEDKCCEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2C5C1A0", Offset = "0x2C5A7A0", VA = "0x182C5C1A0", Slot = "5")]
	protected override string ADOBFCPCHCJ(NHNLOHOBNME<TKey> BCLLAMGBKIH, EIKEAKGFALO FIBOKKFNNCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D070", Offset = "0x2C5B670", VA = "0x182C5D070")]
	[CompilerGenerated]
	internal static string ECLKNGPIEFM(string MMHNGOEPIKL, TKey NAJDAPHOGEH, ref PLIJIHACDFA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class NHNLOHOBNME<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public readonly struct GPGKHJOCCPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly long GFOKIDOPAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly long JHGNFCMINBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly int NGFICIADCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly int PLFLCDDNHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly bool NJMDFEBFCNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly string PPLOKKILHMD;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E970", Offset = "0x3D9CF70", VA = "0x183D9E970")]
		public GPGKHJOCCPD(long GFOKIDOPAAE, int NGFICIADCNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E9E0", Offset = "0x3D9CFE0", VA = "0x183D9E9E0")]
		public GPGKHJOCCPD(long GFOKIDOPAAE, long JHGNFCMINBF, int NGFICIADCNJ, int PLFLCDDNHCC, bool NJMDFEBFCNH, string PPLOKKILHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E750", Offset = "0x3D9CD50", VA = "0x183D9E750")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ANDAKOGOHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E860", Offset = "0x3D9CE60", VA = "0x183D9E860")]
		public int JEHMFHAJPFN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E840", Offset = "0x3D9CE40", VA = "0x183D9E840")]
		public int EIJNFANMALI(int HFFLFGCPMFJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E7D0", Offset = "0x3D9CDD0", VA = "0x183D9E7D0")]
		public double DPJEFJKIMIN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E8B0", Offset = "0x3D9CEB0", VA = "0x183D9E8B0")]
		public GPGKHJOCCPD PMBPOBOPBIJ(long JHGNFCMINBF, int PLFLCDDNHCC)
		{
			return default(GPGKHJOCCPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class NOELMCIDFEB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class OLMFILOBAPH<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<NOELMCIDFEB, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public NOELMCIDFEB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private NOELMCIDFEB <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
			public OLMFILOBAPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2663050", Offset = "0x2661650", VA = "0x182663050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly TKey BMFMEFAJFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly NHNLOHOBNME<TKey> BCLLAMGBKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private List<NOELMCIDFEB> ODFABMHIHPK;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string MAFMPAELGNF
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1225030", Offset = "0x1223630", VA = "0x181225030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x1224BB0", Offset = "0x12231B0", VA = "0x181224BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEnumerable<NOELMCIDFEB> PPNNCBGGBIA
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x2F68BF0", Offset = "0x2F671F0", VA = "0x182F68BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public GPGKHJOCCPD DGJDEAPHDBE
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1186AC0", Offset = "0x11850C0", VA = "0x181186AC0")]
			[CompilerGenerated]
			get
			{
				return default(GPGKHJOCCPD);
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x2F68AB0", Offset = "0x2F670B0", VA = "0x182F68AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2F68CF0", Offset = "0x2F672F0", VA = "0x182F68CF0")]
		internal NOELMCIDFEB(NHNLOHOBNME<TKey> BCLLAMGBKIH, TKey NAJDAPHOGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2F68AE0", Offset = "0x2F670E0", VA = "0x182F68AE0")]
		public NOELMCIDFEB GACBJJDNBMN(TKey NAJDAPHOGEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2F68C10", Offset = "0x2F67210", VA = "0x182F68C10")]
		public void NMNEKAMPBMF(TKey NAJDAPHOGEH, Action<NOELMCIDFEB> INJMGBDPOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x26F3020", Offset = "0x26F1620", VA = "0x1826F3020")]
		public T NMNEKAMPBMF<T>(TKey NAJDAPHOGEH, Func<NOELMCIDFEB, T> NPLMCEHNFJK)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x26F3110", Offset = "0x26F1710", VA = "0x1826F3110")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OLMFILOBAPH<>))]
		public Task<T> PCLDHPJFFAO<T>(TKey NAJDAPHOGEH, Func<NOELMCIDFEB, Task<T>> NPLMCEHNFJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2F68900", Offset = "0x2F66F00", VA = "0x182F68900", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class GFANKLNGKHD : IEnumerable<(TKey, List<TKey>, GPGKHJOCCPD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GPGKHJOCCPD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private (TKey key, List<TKey> path, GPGKHJOCCPD timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NHNLOHOBNME<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private IEnumerator<(TKey key, List<TKey> path, GPGKHJOCCPD timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private (TKey key, List<TKey> path, GPGKHJOCCPD timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private (TKey, List<TKey>, GPGKHJOCCPD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2DBC150", Offset = "0x2DBA750", VA = "0x182DBC150", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GPGKHJOCCPD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2DBC1C0", Offset = "0x2DBA7C0", VA = "0x182DBC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC220", Offset = "0x2DBA820", VA = "0x182DBC220")]
		[DebuggerHidden]
		public GFANKLNGKHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x12269B0", Offset = "0x1224FB0", VA = "0x1812269B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2DBBD10", Offset = "0x2DBA310", VA = "0x182DBBD10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC040", Offset = "0x2DBA640", VA = "0x182DBC040")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC180", Offset = "0x2DBA780", VA = "0x182DBC180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC090", Offset = "0x2DBA690", VA = "0x182DBC090", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GPGKHJOCCPD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x15BEF90", Offset = "0x15BD590", VA = "0x1815BEF90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class LMIBCIHAAKA : IEnumerable<(TKey, List<TKey>, GPGKHJOCCPD)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GPGKHJOCCPD)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private (TKey key, List<TKey> path, GPGKHJOCCPD timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private NOELMCIDFEB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public NOELMCIDFEB <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public NHNLOHOBNME<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IEnumerator<NOELMCIDFEB> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private NOELMCIDFEB <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private IEnumerator<(TKey key, List<TKey> path, GPGKHJOCCPD timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private (TKey key, List<TKey> path, GPGKHJOCCPD timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private (TKey, List<TKey>, GPGKHJOCCPD) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x2DBC150", Offset = "0x2DBA750", VA = "0x182DBC150", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GPGKHJOCCPD));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x3D3E8C0", Offset = "0x3D3CEC0", VA = "0x183D3E8C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2DBC220", Offset = "0x2DBA820", VA = "0x182DBC220")]
		[DebuggerHidden]
		public LMIBCIHAAKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E920", Offset = "0x3D3CF20", VA = "0x183D3E920", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E130", Offset = "0x3D3C730", VA = "0x183D3E130", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E740", Offset = "0x3D3CD40", VA = "0x183D3E740")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E0D0", Offset = "0x3D3C6D0", VA = "0x183D3E0D0")]
		private void MIAFNIDKODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E880", Offset = "0x3D3CE80", VA = "0x183D3E880", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E7A0", Offset = "0x3D3CDA0", VA = "0x183D3E7A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GPGKHJOCCPD)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x28B52D0", Offset = "0x28B38D0", VA = "0x1828B52D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<TKey, GPGKHJOCCPD> LMENDDBMPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action<TKey, GPGKHJOCCPD> OEOINJAPFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Action<NHNLOHOBNME<TKey>> KCDHAMPAMDJ;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private const string KNLFMPJGHPC = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly NOELMCIDFEB FBFNHLPDLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool EAOOMFEELLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private int FHFNIOAPNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly Stopwatch ODKKIBMBPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly int KGPFEPIHGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private string CAJPPBFCDII;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public NOELMCIDFEB GLFOMIFLJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	public string MAFMPAELGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x944010", Offset = "0x942610", VA = "0x180944010")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x26C6C20", Offset = "0x26C5220", VA = "0x1826C6C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public long FLHHKPDHKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x26C6A60", Offset = "0x26C5060", VA = "0x1826C6A60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int IINKHLMHAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x26C6920", Offset = "0x26C4F20", VA = "0x1826C6920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x26C6C80", Offset = "0x26C5280", VA = "0x1826C6C80")]
	public NHNLOHOBNME(TKey HGAJDFAGILI, [Optional] int? NGFICIADCNJ, [Optional][CanBeNull] Stopwatch ODKKIBMBPEN, [Optional] Action<TKey, GPGKHJOCCPD> LMENDDBMPBJ, [Optional] Action<TKey, GPGKHJOCCPD> OEOINJAPFFG, [Optional] Action<NHNLOHOBNME<TKey>> KCDHAMPAMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x26C6950", Offset = "0x26C4F50", VA = "0x1826C6950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x26C6C00", Offset = "0x26C5200", VA = "0x1826C6C00")]
	public void LJHLCMHAPJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x26C6A80", Offset = "0x26C5080", VA = "0x1826C6A80")]
	public void IFFOEHAPCOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x26C6B70", Offset = "0x26C5170", VA = "0x1826C6B70")]
	[IteratorStateMachine(typeof(NHNLOHOBNME<>.GFANKLNGKHD))]
	public IEnumerable<(TKey, List<TKey>, GPGKHJOCCPD)> LCOEFKJBDML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x26C6AA0", Offset = "0x26C50A0", VA = "0x1826C6AA0")]
	[IteratorStateMachine(typeof(NHNLOHOBNME<>.LMIBCIHAAKA))]
	private IEnumerable<(TKey, List<TKey>, GPGKHJOCCPD)> LCOEFKJBDML(List<TKey> PCCHHIAICLC, NOELMCIDFEB IGIEAFIAACI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x26C69E0", Offset = "0x26C4FE0", VA = "0x1826C69E0")]
	private (long, int) GMHDEAHJDCM()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class FGKINMIMEKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<byte, KGNLACAJEPC> EGBNHNLDAIN;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public KGNLACAJEPC FNJAKPEKNHC
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 NCHFHKAOAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x18D83C0", Offset = "0x18D69C0", VA = "0x1818D83C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xDD9E70", Offset = "0xDD8470", VA = "0x180DD9E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 PIPHPOAGOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x22563E0", Offset = "0x22549E0", VA = "0x1822563E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9440D0", Offset = "0x9426D0", VA = "0x1809440D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 BOBEMCPGNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7105D90", Offset = "0x7104390", VA = "0x187105D90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xAD30C0", Offset = "0xAD16C0", VA = "0x180AD30C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int EOIAPIGABCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x942BB0", Offset = "0x9411B0", VA = "0x180942BB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x942C30", Offset = "0x941230", VA = "0x180942C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x7105DB0", Offset = "0x71043B0", VA = "0x187105DB0")]
	public FGKINMIMEKO(Bounds GOMEHHGJEKH, Vector2[] HEJKHKKLHEO, int MDNDGONGOII, byte DGHDJOAODLO, float PPGPAGAKGBP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x71057F0", Offset = "0x7103DF0", VA = "0x1871057F0")]
	public KGNLACAJEPC GFNAMLCCONM(byte IIOMOLKAONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x71056D0", Offset = "0x7103CD0", VA = "0x1871056D0")]
	public void CMCNPCEOJBL(Vector3 FADCMIMHMJH, float MFCIHHLDNFD, float HDIEIBGNBGF, ref List<byte> LOJLMIEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x71057D0", Offset = "0x7103DD0", VA = "0x1871057D0")]
	public void GAKEOILGKPK(KGNLACAJEPC.DGKFNABFPHG AHHIMKJHDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7105850", Offset = "0x7103E50", VA = "0x187105850")]
	private KGNLACAJEPC HPEJNCCJGDF(byte IIOMOLKAONM, KGNLACAJEPC.JHDLHHFECFF NIGJOHCKBIH, KGNLACAJEPC KHJHJOOPMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x71059B0", Offset = "0x7103FB0", VA = "0x1871059B0")]
	private void ICBGPGOCJCE(KGNLACAJEPC KHJHJOOPMKP, Vector2[] HEJKHKKLHEO, int EMOLIDBFFME, int DBDNJJGGEFK, int JKKHFLBDBHG, int DBOPOEMLKJF, float PPGPAGAKGBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class KGNLACAJEPC
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum JHDLHHFECFF
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum DGKFNABFPHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public byte NEAPDBBCPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3 NAHDNNJKKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Vector3 MFIPBJCKMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3 IGLCNDJCMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 OCKPBKBHFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public JHDLHHFECFF GPBKAEGJOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public KGNLACAJEPC IHLKEFDBIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public List<KGNLACAJEPC> CLAPGEGBJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool AJACFNOMPPA;

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x71082E0", Offset = "0x71068E0", VA = "0x1871082E0")]
	public KGNLACAJEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7108280", Offset = "0x7106880", VA = "0x187108280")]
	public KGNLACAJEPC(byte LNHACNHDILG, JHDLHHFECFF NIGJOHCKBIH, KGNLACAJEPC KHJHJOOPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x71081C0", Offset = "0x71067C0", VA = "0x1871081C0")]
	public void OHKLDBMINNB(KGNLACAJEPC AIMPELPKDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public void GAKEOILGKPK(int EKAFNNFLLAA, DGKFNABFPHG AHHIMKJHDAM, int JOGCILJBKII = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7107F10", Offset = "0x7106510", VA = "0x187107F10")]
	public void CMCNPCEOJBL(List<byte> LOJLMIEIOHB, Vector3 FADCMIMHMJH, float MFCIHHLDNFD, float HDIEIBGNBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7108140", Offset = "0x7106740", VA = "0x187108140")]
	public bool FMFBKPHHMCO(Vector3 DEGODPDOPJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7108190", Offset = "0x7106790", VA = "0x187108190")]
	public bool JDGEMMMFCGP(Vector3 DEGODPDOPJM, float DMBNDIIKMOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class MDCDEEAHPHN<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly Stack<T> MFNHFHHKEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly List<T> OJHFDEMHLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly int GDKPBJLHKCF;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int FIGBIGDMOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1225030", Offset = "0x1223630", VA = "0x181225030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int BEHMGBHPEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x25D4BE0", Offset = "0x25D31E0", VA = "0x1825D4BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x25D4880", Offset = "0x25D2E80", VA = "0x1825D4880")]
	public static MDCDEEAHPHN<T> ACOKEBLGOLM(int IOKNIDFIOPP = 0, int GDKPBJLHKCF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x25D4E10", Offset = "0x25D3410", VA = "0x1825D4E10")]
	public static MDCDEEAHPHN<T> JLGIELPPMPD(int IOKNIDFIOPP = 0, int GDKPBJLHKCF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x25D51A0", Offset = "0x25D37A0", VA = "0x1825D51A0")]
	public MDCDEEAHPHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x25D5010", Offset = "0x25D3610", VA = "0x1825D5010")]
	public MDCDEEAHPHN(int IOKNIDFIOPP, int GDKPBJLHKCF = int.MaxValue, bool BHKHEFPFECA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x25D4D00", Offset = "0x25D3300", VA = "0x1825D4D00")]
	public T IMPHPKEMCBH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x25D4F70", Offset = "0x25D3570", VA = "0x1825D4F70")]
	public void PIDBAINCDOB(T FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x25D4B10", Offset = "0x25D3110", VA = "0x1825D4B10")]
	private void DBGHHBNOAIB(T FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x25D4AF0", Offset = "0x25D30F0", VA = "0x1825D4AF0")]
	private void CIIMNDHFFHD(T FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x25D47F0", Offset = "0x25D2DF0", VA = "0x1825D47F0")]
	[Conditional("DEBUG_BUILD")]
	private void ACNDDCJCLAG(T EMIGHEAGLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x25D4EE0", Offset = "0x25D34E0", VA = "0x1825D4EE0")]
	[Conditional("DEBUG_BUILD")]
	private void LPPHDKBFBGF(T EMIGHEAGLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x25D4C10", Offset = "0x25D3210", VA = "0x1825D4C10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x25D4950", Offset = "0x25D2F50", VA = "0x1825D4950")]
	private void AFIEJJALFPH(IEnumerable<T> BCDJFNKOFCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class CLFPODNLOFE
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private enum CACNALPMBHI : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private int PFEGKNHPDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private bool PDAJCHICOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private CACNALPMBHI EHDAGCNJKHK;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool JKPLIBNKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x71050C0", Offset = "0x71036C0", VA = "0x1871050C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KOIJCFILAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7104B30", Offset = "0x7103130", VA = "0x187104B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x71050D0", Offset = "0x71036D0", VA = "0x1871050D0")]
	public CLFPODNLOFE(bool PDAJCHICOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7104310", Offset = "0x7102910", VA = "0x187104310")]
	public void CDKAMMFLAIE(object IAMEECMGPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7105020", Offset = "0x7103620", VA = "0x187105020")]
	public void OHFOGOODAEG(int FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7104A70", Offset = "0x7103070", VA = "0x187104A70")]
	public void HLAEIEODAOB(uint PGHNHHDFFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7104A50", Offset = "0x7103050", VA = "0x187104A50")]
	public void HJOPLANDLGL(bool JENNAAGDMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7104250", Offset = "0x7102850", VA = "0x187104250")]
	public void ANNKANPMGOF(long IHIPOJJDJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7104AF0", Offset = "0x71030F0", VA = "0x187104AF0")]
	public void IGOILHFOPKI(ulong BGIJEHCOHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7104A80", Offset = "0x7103080", VA = "0x187104A80")]
	public void IAPBFPFDHLM(string CCOKELEMEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7104950", Offset = "0x7102F50", VA = "0x187104950")]
	public void FKFKMLLGCGN(Enum OHPJJHOMFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7104BB0", Offset = "0x71031B0", VA = "0x187104BB0")]
	public void NAJPOELEPNB(IList EKFNNDEBOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x16A9ED0", Offset = "0x16A84D0", VA = "0x1816A9ED0")]
	public void BBFCIPJPBHG<T, U>(Dictionary<T, U> JCCEJGOBBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7104CD0", Offset = "0x71032D0", VA = "0x187104CD0")]
	private void ODBNOCBCAKC(IDictionary JCCEJGOBBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x71049E0", Offset = "0x7102FE0", VA = "0x1871049E0")]
	public int GHPIJPKONBF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7104B40", Offset = "0x7103140", VA = "0x187104B40")]
	public short MBNNOEPNIFJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7104300", Offset = "0x7102900", VA = "0x187104300")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7104290", Offset = "0x7102890", VA = "0x187104290")]
	private void BJMIMCJNFMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface HGIMEFMINFP
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class ResourcePrefabReference<T> : HGIMEFMINFP where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B38D00", Offset = "0x2B37300", VA = "0x182B38D00", Slot = "4")]
		public virtual T FMLHHBPDFLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GDGOKBDMNBN<T> : IEnumerable<GDGOKBDMNBN<T>.MENFBMHBFHC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct MENFBMHBFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public T FEBHELIDNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int IIOMOLKAONM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class IAHPPCEPPPG : IEnumerator<MENFBMHBFHC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private GDGOKBDMNBN<T> FLBCJEFNHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int IIOMOLKAONM;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x97E420", Offset = "0x97CA20", VA = "0x18097E420", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public MENFBMHBFHC PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x1AC76C0", Offset = "0x1AC5CC0", VA = "0x181AC76C0", Slot = "4")]
			get
			{
				return default(MENFBMHBFHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1AC75C0", Offset = "0x1AC5BC0", VA = "0x181AC75C0")]
		public IAHPPCEPPPG(GDGOKBDMNBN<T> FLBCJEFNHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1AC74C0", Offset = "0x1AC5AC0", VA = "0x181AC74C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0A0", Offset = "0xA3B6A0", VA = "0x180A3D0A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xC30510", Offset = "0xC2EB10", VA = "0x180C30510", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct PHDDPKDGPNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public bool BFKAELOOGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public T FEBHELIDNED;
	}

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private const int KPGHKPLLIFB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly Dictionary<T, int> NBMMPAJFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private PHDDPKDGPNG[] NGOJGCHEJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int GGMIJENCKHB;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int OANADPLGFEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9B6140", Offset = "0x9B4740", VA = "0x1809B6140")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x11C1700", Offset = "0x11BFD00", VA = "0x1811C1700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0FB0", Offset = "0x1ACF5B0", VA = "0x181AD0FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DF20", Offset = "0x3B4C520", VA = "0x183B4DF20")]
	public GDGOKBDMNBN(int IOKNIDFIOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DFF0", Offset = "0x3B4C5F0", VA = "0x183B4DFF0")]
	public GDGOKBDMNBN(MENFBMHBFHC[] CMEPIEECLAH, bool ENBILCKCCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CCE0", Offset = "0x3B4B2E0", VA = "0x183B4CCE0")]
	public int GFGANELFCGM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C930", Offset = "0x3B4AF30", VA = "0x183B4C930")]
	private int DEBLPELMEHJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DAA0", Offset = "0x3B4C0A0", VA = "0x183B4DAA0", Slot = "6")]
	protected virtual uint ONHIKLLJFJL(uint PFEGKNHPDEP, T FEBHELIDNED)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D350", Offset = "0x3B4B950", VA = "0x183B4D350")]
	public bool KEJFMNBGEKJ(T FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DA20", Offset = "0x3B4C020", VA = "0x183B4DA20")]
	public bool OHOHPBICNND(int IIOMOLKAONM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CD50", Offset = "0x3B4B350", VA = "0x183B4CD50")]
	public bool GGHKDEOPGPN(Func<T, bool> GHPPJEFLOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CB70", Offset = "0x3B4B170", VA = "0x183B4CB70")]
	public int DMJOENDHLHC(T FEBHELIDNED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D950", Offset = "0x3B4BF50", VA = "0x183B4D950")]
	public T ODJMIGNPKED(int IIOMOLKAONM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x3B4C6D0", Offset = "0x3B4ACD0", VA = "0x183B4C6D0")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D4B0", Offset = "0x3B4BAB0", VA = "0x183B4D4B0")]
	public bool OBNDLHFELBO(T FEBHELIDNED, bool HALGEHGDLNM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D4F0", Offset = "0x3B4BAF0", VA = "0x183B4D4F0")]
	public bool OBNDLHFELBO(T FEBHELIDNED, int IIOMOLKAONM, bool HALGEHGDLNM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CC50", Offset = "0x3B4B250", VA = "0x183B4CC50")]
	public bool FAKCPBGGFBC(T FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D390", Offset = "0x3B4B990", VA = "0x183B4D390")]
	public bool KHMDPDLENDM(int IIOMOLKAONM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D260", Offset = "0x3B4B860", VA = "0x183B4D260")]
	private void JEHGDDHMKGJ(int IIOMOLKAONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D040", Offset = "0x3B4B640", VA = "0x183B4D040")]
	public MENFBMHBFHC[] GMDJGJMHLJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D430", Offset = "0x3B4BA30", VA = "0x183B4D430")]
	private int NBPECAAJFCN(int DGHDJOAODLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DAC0", Offset = "0x3B4C0C0", VA = "0x183B4DAC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DAC0", Offset = "0x3B4C0C0", VA = "0x183B4DAC0", Slot = "4")]
	private IEnumerator<MENFBMHBFHC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x7108B20", Offset = "0x7107120", VA = "0x187108B20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x7108DB0", Offset = "0x71073B0", VA = "0x187108DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x7108CE0", Offset = "0x71072E0", VA = "0x187108CE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x7108F00", Offset = "0x7107500", VA = "0x187108F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x7108A90", Offset = "0x7107090", VA = "0x187108A90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x7108D20", Offset = "0x7107320", VA = "0x187108D20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x7108C50", Offset = "0x7107250", VA = "0x187108C50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7108A30", Offset = "0x7107030", VA = "0x187108A30")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class NCNDMGPJBAM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int IOKNIDFIOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int CCKDOJGHMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private List<T> CINKNDJPGAB;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1225030", Offset = "0x1223630", VA = "0x181225030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T LAKAHLBPAGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x24EE220", Offset = "0x24EC820", VA = "0x1824EE220")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T OMKJMMLCPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x24EDF50", Offset = "0x24EC550", VA = "0x1824EDF50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T BFADOJOCBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x24EE0F0", Offset = "0x24EC6F0", VA = "0x1824EE0F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x24EE460", Offset = "0x24ECA60", VA = "0x1824EE460")]
	public NCNDMGPJBAM(int IOKNIDFIOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x24EE380", Offset = "0x24EC980", VA = "0x1824EE380")]
	public void PEECNHFNIGK(T HEGMNECKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x24EDFB0", Offset = "0x24EC5B0", VA = "0x1824EDFB0")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x24EE000", Offset = "0x24EC600", VA = "0x1824EE000")]
	public void EHIPIGBKIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x24EE150", Offset = "0x24EC750", VA = "0x1824EE150")]
	public void OBJBPFJFJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x24EDFF0", Offset = "0x24EC5F0", VA = "0x1824EDFF0")]
	public void DCNPANEBIFK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		public struct HJOMEJOGPNL<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private readonly List<Component> EKFNNDEBOAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private readonly bool NJMPPCOPNAC;

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xFA9D10", Offset = "0xFA8310", VA = "0x180FA9D10")]
			public HJOMEJOGPNL(List<Component> EKFNNDEBOAK, bool NJMPPCOPNAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4560", Offset = "0x2DA2B60", VA = "0x182DA4560")]
			public ILPDJHBCHBP<T> PFBFKEIKCCB()
			{
				return default(ILPDJHBCHBP<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2DA45D0", Offset = "0x2DA2BD0", VA = "0x182DA45D0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2DA45D0", Offset = "0x2DA2BD0", VA = "0x182DA45D0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public struct ILPDJHBCHBP<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private readonly List<Component> EKFNNDEBOAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private readonly bool NJMPPCOPNAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int IIOMOLKAONM;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public T PGNBHIOAFDF
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x1FF7260", Offset = "0x1FF5860", VA = "0x181FF7260", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0x1FF71F0", Offset = "0x1FF57F0", VA = "0x181FF71F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x1FF7230", Offset = "0x1FF5830", VA = "0x181FF7230")]
			public ILPDJHBCHBP(List<Component> EKFNNDEBOAK, bool NJMPPCOPNAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x1FF7110", Offset = "0x1FF5710", VA = "0x181FF7110", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x1FF7120", Offset = "0x1FF5720", VA = "0x181FF7120", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x1FF71E0", Offset = "0x1FF57E0", VA = "0x181FF71E0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x710AC90", Offset = "0x7109290", VA = "0x18710AC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x710AC50", Offset = "0x7109250", VA = "0x18710AC50")]
		public ToolHierarchyCache(GameObject GMNIHJDBJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x710A900", Offset = "0x7108F00", VA = "0x18710A900")]
		private void KGHKJOCLFMF(GameObject GMNIHJDBJGJ, bool PNPIPMIPGBD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x710AA70", Offset = "0x7109070", VA = "0x18710AA70")]
		public static void KGHKJOCLFMF(GameObject GMNIHJDBJGJ, ref ToolHierarchyCache FBKIEMHDLKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x710A7E0", Offset = "0x7108DE0", VA = "0x18710A7E0")]
		public void HAKAOAFEAKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x710A2C0", Offset = "0x71088C0", VA = "0x18710A2C0")]
		public void BCKPANAIODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x39859D0", Offset = "0x3983FD0", VA = "0x1839859D0")]
		public void MFOOPFBMJHO<T>(Action<T> INJMGBDPOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x710AB00", Offset = "0x7109100", VA = "0x18710AB00")]
		public Component NCCNPDLIPAM(Type LFBJHCMDIAE, bool NJMPPCOPNAC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3985C60", Offset = "0x3984260", VA = "0x183985C60")]
		public T NCCNPDLIPAM<T>(bool NJMPPCOPNAC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x710A310", Offset = "0x7108910", VA = "0x18710A310")]
		public HJOMEJOGPNL<Component> DJOJHIIJLHI(Type LFBJHCMDIAE, bool NJMPPCOPNAC = false)
		{
			return default(HJOMEJOGPNL<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x3985900", Offset = "0x3983F00", VA = "0x183985900")]
		public HJOMEJOGPNL<T> DJOJHIIJLHI<T>(bool NJMPPCOPNAC = false) where T : class
		{
			return default(HJOMEJOGPNL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x710A410", Offset = "0x7108A10", VA = "0x18710A410")]
		public List<Component> FMKOFPNENEF(Type LFBJHCMDIAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x710A390", Offset = "0x7108990", VA = "0x18710A390", Slot = "4")]
		public bool Equals(ToolHierarchyCache HMINFBNCMPL, ToolHierarchyCache MPEHLADJKCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x710A760", Offset = "0x7108D60", VA = "0x18710A760", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache IAMEECMGPIF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class OGLKEOELHBJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Dictionary<int, T> FIHDOLNBAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private T JCEHMJLNBLK;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public virtual T JIHCIHOHEGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA46F90", Offset = "0xA45590", VA = "0x180A46F90", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x920EA0", Offset = "0x91F4A0", VA = "0x180920EA0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool DNKHEJHIDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x36ABB30", Offset = "0x36AA130", VA = "0x1836ABB30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x36AB420", Offset = "0x36A9A20", VA = "0x1836AB420")]
	public bool ALOLPDOLNOL(T FEBHELIDNED, int HFBMOEGOMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2FB51D0", Offset = "0x2FB37D0", VA = "0x182FB51D0")]
	public bool OJOADDBKBHJ(int HFBMOEGOMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x36AB540", Offset = "0x36A9B40", VA = "0x1836AB540")]
	public T CGCELGDFOLJ(int PDHNGGCAMMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x36AB4E0", Offset = "0x36A9AE0", VA = "0x1836AB4E0")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x36AB990", Offset = "0x36A9F90", VA = "0x1836AB990")]
	private bool IBCGGIHGKHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x36AB960", Offset = "0x36A9F60", VA = "0x1836AB960")]
	public bool DJABJOJOKLP(int HFBMOEGOMPE, out T FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x36ABB70", Offset = "0x36AA170", VA = "0x1836ABB70")]
	public OGLKEOELHBJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x954B80", Offset = "0x953180", VA = "0x180954B80")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public T this[int JMCLMPHOKNG, int KDHPDIKCHGK]
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x3DE1B10", Offset = "0x3DE0110", VA = "0x183DE1B10")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x3DE1BB0", Offset = "0x3DE01B0", VA = "0x183DE1BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1A80", Offset = "0x3DE0080", VA = "0x183DE1A80")]
		public Array2D(uint GMHFIKBCJHC, uint DBCMKHOADFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1A00", Offset = "0x3DE0000", VA = "0x183DE1A00")]
		public void CCIICLEBIPJ()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7103DA0", Offset = "0x71023A0", VA = "0x187103DA0")]
		public Array2DVector3(uint GMHFIKBCJHC, uint DBCMKHOADFM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public abstract class CBEKMFEPANC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class GEGCJCNAHKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public TNode PBJDHAKDMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public TNode KHJHJOOPMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public DIFFCOPGPLB LIKCDKHGNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public List<DIFFCOPGPLB> FLGGBGLODDO;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public GEGCJCNAHKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal struct DIFFCOPGPLB : IComparable<DIFFCOPGPLB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int HFBMOEGOMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public TClaimant LCJCAKGPNNF;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xC3D540", Offset = "0xC3BB40", VA = "0x180C3D540")]
		public DIFFCOPGPLB(int HFBMOEGOMPE, TClaimant LCJCAKGPNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2F179E0", Offset = "0x2F15FE0", VA = "0x182F179E0")]
		public bool EOHHIIJJPJE(in DIFFCOPGPLB EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2F17A40", Offset = "0x2F16040", VA = "0x182F17A40")]
		public bool PIBKIFLHMJF(in DIFFCOPGPLB EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2F179D0", Offset = "0x2F15FD0", VA = "0x182F179D0", Slot = "4")]
		public int CompareTo(DIFFCOPGPLB EJECOGCICOM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2F17A50", Offset = "0x2F16050", VA = "0x182F17A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum MCAFEFEKLIA
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class NHKABGIOEBI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public CBEKMFEPANC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x1224AF0", Offset = "0x12230F0", VA = "0x181224AF0")]
		[DebuggerHidden]
		public NHKABGIOEBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x26C6710", Offset = "0x26C4D10", VA = "0x1826C6710", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x26C68E0", Offset = "0x26C4EE0", VA = "0x1826C68E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x26C6800", Offset = "0x26C4E00", VA = "0x1826C6800", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1EE90E0", Offset = "0x1EE76E0", VA = "0x181EE90E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly MDCDEEAHPHN<GEGCJCNAHKP> PJCDBNIBILA;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly MDCDEEAHPHN<List<DIFFCOPGPLB>> BAEEPNMAOFO;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static int IPGJLAOFJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	internal readonly Dictionary<TClaimant, TNode> ENLMNPOKNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	internal readonly Dictionary<TNode, GEGCJCNAHKP> DAFBAADIAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private MCAFEFEKLIA MBKPCEEDDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private bool OCBEMDEOMOL;

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DILEMILBDPF(TNode CLBHJIDEJIB);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JCAIGFPJJPL(TNode CLBHJIDEJIB, TClaimant FJKIDAJDDJO, TClaimant FAMJMEHHJAL);

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x32F3250", Offset = "0x32F1850", VA = "0x1832F3250")]
	public CBEKMFEPANC(MCAFEFEKLIA MBKPCEEDDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x32F28F0", Offset = "0x32F0EF0", VA = "0x1832F28F0")]
	public void KJIPAMPJBND(TNode CLBHJIDEJIB, TNode BMPJGPJDGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x32F2970", Offset = "0x32F0F70", VA = "0x1832F2970")]
	public void KJNIFGMEPCC(TClaimant LCJCAKGPNNF, TNode JFNNHLOEDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x32F1E70", Offset = "0x32F0470", VA = "0x1832F1E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x32F2D30", Offset = "0x32F1330", VA = "0x1832F2D30")]
	private void LCLMPMAMOCL(TClaimant LCJCAKGPNNF, TNode HHLOLKLECAF, TNode JFNNHLOEDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x32F25C0", Offset = "0x32F0BC0", VA = "0x1832F25C0")]
	private int GKAOKIBPCBO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x32F2A70", Offset = "0x32F1070", VA = "0x1832F2A70")]
	private void LBJOEFDPIEE(TClaimant LCJCAKGPNNF, TNode OMIAIPNIKHE, TNode PGGIOMMDBAK, int MLKMLLAEFPI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x32F3060", Offset = "0x32F1660", VA = "0x1832F3060")]
	private void OKKHGDLCOBG(DIFFCOPGPLB GNLKPKLDIAL, GEGCJCNAHKP BBBKBNPMKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x32F1C10", Offset = "0x32F0210", VA = "0x1832F1C10")]
	private void DPLBDPIGKKJ(TClaimant LCJCAKGPNNF, TNode OMIAIPNIKHE, TNode PGGIOMMDBAK, int MLKMLLAEFPI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x32F27E0", Offset = "0x32F0DE0", VA = "0x1832F27E0")]
	private void KEFOOGIJAID(DIFFCOPGPLB GNLKPKLDIAL, TNode CLBHJIDEJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x32F2DD0", Offset = "0x32F13D0", VA = "0x1832F2DD0")]
	private void MCKACIKEGGP(DIFFCOPGPLB GNLKPKLDIAL, GEGCJCNAHKP BBBKBNPMKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x32F20D0", Offset = "0x32F06D0", VA = "0x1832F20D0")]
	private void FHMIEJPFIHA(GEGCJCNAHKP BBBKBNPMKEJ, bool FAPLLHBIKOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x32F21F0", Offset = "0x32F07F0", VA = "0x1832F21F0")]
	private void FIOGFLFLPLO(GEGCJCNAHKP BBBKBNPMKEJ, TNode BMPJGPJDGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x32F1B40", Offset = "0x32F0140", VA = "0x1832F1B40")]
	[IteratorStateMachine(typeof(CBEKMFEPANC<, >.NHKABGIOEBI))]
	private IEnumerable<TNode> BKFNMPJGDMB(TNode OMIAIPNIKHE, TNode PGGIOMMDBAK, bool APAAHEFNHPI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x32F1A80", Offset = "0x32F0080", VA = "0x1832F1A80")]
	private GEGCJCNAHKP AGKDMJBMMJB(TNode CLBHJIDEJIB, TNode KHJHJOOPMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x32F2ED0", Offset = "0x32F14D0", VA = "0x1832F2ED0")]
	private GEGCJCNAHKP MICGMPKEFBD(TNode CLBHJIDEJIB, TNode KHJHJOOPMKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x32F2620", Offset = "0x32F0C20", VA = "0x1832F2620")]
	private void ILBJGODDDME(GEGCJCNAHKP BBBKBNPMKEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class JGJCFMGCHKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	protected struct NIDKEEEIKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public T CNODGJBIHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int GCBAEJGNGCK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected readonly List<NIDKEEEIKOO> JFDLGHHNKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T APHFGKOJBJG;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x1AD0FB0", Offset = "0x1ACF5B0", VA = "0x181AD0FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2A09E90", Offset = "0x2A08490", VA = "0x182A09E90")]
	public bool GGHKDEOPGPN(T FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A090", Offset = "0x2A08690", VA = "0x182A0A090")]
	public void PEECNHFNIGK(T FEBHELIDNED, int HFBMOEGOMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2A09D00", Offset = "0x2A08300", VA = "0x182A09D00")]
	public bool FAKCPBGGFBC(T FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2A09C30", Offset = "0x2A08230", VA = "0x182A09C30")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2A09E20", Offset = "0x2A08420", VA = "0x182A09E20")]
	public T GEGGCOMELNB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2A09C90", Offset = "0x2A08290", VA = "0x182A09C90")]
	public T EFFKHCOBEBE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A130", Offset = "0x2A08730", VA = "0x182A0A130")]
	private void PLEKFDBCFMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2A0A2E0", Offset = "0x2A088E0", VA = "0x182A0A2E0")]
	public JGJCFMGCHKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class EGFIAAKMAPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private struct KFDMGFJIOBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int GCBAEJGNGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public T CNODGJBIHLH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<object, KFDMGFJIOBC> FIHDOLNBAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly EqualityComparer<T> DOHGHCIOCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private T JCEHMJLNBLK;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public virtual T JIHCIHOHEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2A54DC0", Offset = "0x2A533C0", VA = "0x182A54DC0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2A54C90", Offset = "0x2A53290", VA = "0x182A54C90", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool DNKHEJHIDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2A54C40", Offset = "0x2A53240", VA = "0x182A54C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public object KMNKJCOOJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD70", Offset = "0xA3B370", VA = "0x180A3CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2A500D0", Offset = "0x2A4E6D0", VA = "0x182A500D0")]
	public bool ALOLPDOLNOL(T FEBHELIDNED, object LODBJLOKBLP, int HFBMOEGOMPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2A54DD0", Offset = "0x2A533D0", VA = "0x182A54DD0")]
	public bool OJOADDBKBHJ(object LODBJLOKBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x2A50980", Offset = "0x2A4EF80", VA = "0x182A50980")]
	public bool DJABJOJOKLP(object LODBJLOKBLP, out T FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2A506D0", Offset = "0x2A4ECD0", VA = "0x182A506D0")]
	public void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x2A54390", Offset = "0x2A52990", VA = "0x182A54390")]
	private bool IBCGGIHGKHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2A54E40", Offset = "0x2A53440", VA = "0x182A54E40")]
	public EGFIAAKMAPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class FEDAOKIOPCE
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7105600", Offset = "0x7103C00", VA = "0x187105600")]
	public static void FPJFEEHALOO(HMOFDMCMMHE LGEAECDPGKJ, string JKHEGEDBMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void FPJFEEHALOO(IEnumerable<object> AMPNHODFOMD, string JKHEGEDBMFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class EMHPKCAENCN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private bool IDAIBAKLEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private Action INJMGBDPOBO;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public static EMHPKCAENCN DDAMFCPIGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x71054C0", Offset = "0x7103AC0", VA = "0x1871054C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool BFKAMJIJPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA33AD0", Offset = "0xA320D0", VA = "0x180A33AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7105560", Offset = "0x7103B60", VA = "0x187105560")]
	public EMHPKCAENCN(Action INJMGBDPOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7105540", Offset = "0x7103B40", VA = "0x187105540")]
	public void LOJGLKLMFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7105540", Offset = "0x7103B40", VA = "0x187105540", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class BNKKELLMLDH : KMGFNNFFDCD
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7103E00", Offset = "0x7102400", VA = "0x187103E00")]
	public BNKKELLMLDH(UnityEngine.Object JDBMEMNIHGD)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
