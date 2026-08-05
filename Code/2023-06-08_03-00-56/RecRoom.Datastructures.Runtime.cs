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
		[Cpp2IlInjected.Address(RVA = "0x7F1060", Offset = "0x7EFE60", VA = "0x1807F1060")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F20A0", Offset = "0x7F0EA0", VA = "0x1807F20A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC52480", Offset = "0xC51280", VA = "0x180C52480")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC52630", Offset = "0xC51430", VA = "0x180C52630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "4")]
	public virtual void ENJCLEGPHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
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
	[ANMFEHHGFOB]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x43DB440", Offset = "0x43DA240", VA = "0x1843DB440", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43DAB70", Offset = "0x43D9970", VA = "0x1843DAB70", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43DB980", Offset = "0x43DA780", VA = "0x1843DB980")]
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
	private sealed class ECPJMIBMOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public ECPJMIBMOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x344B560", Offset = "0x344A360", VA = "0x18344B560")]
		internal int NIOHJBBAKPP(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[ANMFEHHGFOB]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x237A1F0", Offset = "0x2378FF0", VA = "0x18237A1F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x237A220", Offset = "0x2379020", VA = "0x18237A220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x237A140", Offset = "0x2378F40", VA = "0x18237A140", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TVal this[TKey LGKPJAJAOLI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x237A1A0", Offset = "0x2378FA0", VA = "0x18237A1A0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x237A040", Offset = "0x2378E40", VA = "0x18237A040", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2379B90", Offset = "0x2378990", VA = "0x182379B90", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x23793B0", Offset = "0x23781B0", VA = "0x1823793B0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2378F70", Offset = "0x2377D70", VA = "0x182378F70", Slot = "14")]
	protected virtual string EFPKJIAIEJK(TKeyVal KFFCILDONJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2378F40", Offset = "0x2377D40", VA = "0x182378F40", Slot = "4")]
	public bool ContainsKey(TKey LGKPJAJAOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2379F30", Offset = "0x2378D30", VA = "0x182379F30", Slot = "5")]
	public bool TryGetValue(TKey LGKPJAJAOLI, out TVal KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2379000", Offset = "0x2377E00", VA = "0x182379000", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2379000", Offset = "0x2377E00", VA = "0x182379000", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2379F60", Offset = "0x2378D60", VA = "0x182379F60")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MMLCKOGMFHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class KKNENABHGGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public KKNENABHGGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x44AC970", Offset = "0x44AB770", VA = "0x1844AC970")]
		internal bool DFEGECECKCI(BMODNCKLICN<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float AKELFDFOIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float INDHMLIIFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<BMODNCKLICN<float, T>> HDDHMLHCJHC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NHFCFIIOGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x361D060", Offset = "0x361BE60", VA = "0x18361D060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x361D0E0", Offset = "0x361BEE0", VA = "0x18361D0E0")]
	public MMLCKOGMFHA(float GDOEMMHKLLE, float BOOIJNMMLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x361C6B0", Offset = "0x361B4B0", VA = "0x18361C6B0")]
	public bool CEOEIJCLGPJ(float NNAJPCMFKJE, T KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x361CF50", Offset = "0x361BD50", VA = "0x18361CF50")]
	public int HOPDHEFFIHD(float NNAJPCMFKJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x361CB50", Offset = "0x361B950", VA = "0x18361CB50")]
	public IEnumerable<T> ENLJGFJFIFH(float NNAJPCMFKJE, [Optional] float? GADOMDDBFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x361CFB0", Offset = "0x361BDB0", VA = "0x18361CFB0")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x361CE90", Offset = "0x361BC90", VA = "0x18361CE90")]
	private void HAKHCMBBKAP(float NNAJPCMFKJE)
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
	public T ODIKHJJHMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4808690", Offset = "0x4807490", VA = "0x184808690")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xBF4A00", Offset = "0xBF3800", VA = "0x180BF4A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float FMPAABEBEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD5A980", Offset = "0xD59780", VA = "0x180D5A980")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4808470", Offset = "0x4807270", VA = "0x184808470")]
	public T KBPKLKOFGPH(float FHCFEADADAC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4808280", Offset = "0x4807080", VA = "0x184808280")]
	public T BOAELIJPFJF(float FHCFEADADAC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EGEIGBLGCLL(T AEFFKJDEELO, T CPGPPMFIMKK, float FHCFEADADAC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x41481E0", Offset = "0x4146FE0", VA = "0x1841481E0", Slot = "4")]
	protected override float EGEIGBLGCLL(float AEFFKJDEELO, float CPGPPMFIMKK, float FHCFEADADAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F640", Offset = "0x6F6E440", VA = "0x186F6F640")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B591C0", Offset = "0x2B57FC0", VA = "0x182B591C0", Slot = "4")]
	protected override Vector3 EGEIGBLGCLL(Vector3 AEFFKJDEELO, Vector3 CPGPPMFIMKK, float FHCFEADADAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F757C0", Offset = "0x6F745C0", VA = "0x186F757C0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x18AE660", Offset = "0x18AD460", VA = "0x1818AE660", Slot = "4")]
	protected override Color EGEIGBLGCLL(Color AEFFKJDEELO, Color CPGPPMFIMKK, float FHCFEADADAC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EB50", Offset = "0x6F6D950", VA = "0x186F6EB50")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GCIMLAKDGED
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PEBHGMJPCOI<T1, T2> : IEnumerable<BMODNCKLICN<T1, T2>>, IEnumerable, IEnumerator<BMODNCKLICN<T1, T2>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BMODNCKLICN<T1, T2> <>2__current;

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
		BMODNCKLICN<T1, T2> IEnumerator<Tuple<T1, T2>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2AC38C0", Offset = "0x2AC26C0", VA = "0x182AC38C0")]
		[DebuggerHidden]
		public PEBHGMJPCOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x35F8760", Offset = "0x35F7560", VA = "0x1835F8760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x35F8AE0", Offset = "0x35F78E0", VA = "0x1835F8AE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x35F89F0", Offset = "0x35F77F0", VA = "0x1835F89F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<BMODNCKLICN<T1, T2>> IEnumerable<Tuple<T1, T2>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x35F8AB0", Offset = "0x35F78B0", VA = "0x1835F8AB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class ADAPKNFHDFD<T1, T2, T3> : IEnumerable<GNONOHANGHO<T1, T2, T3>>, IEnumerable, IEnumerator<GNONOHANGHO<T1, T2, T3>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private GNONOHANGHO<T1, T2, T3> <>2__current;

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
		GNONOHANGHO<T1, T2, T3> IEnumerator<Tuple<T1, T2, T3>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC38C0", Offset = "0x2AC26C0", VA = "0x182AC38C0")]
		[DebuggerHidden]
		public ADAPKNFHDFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x457C3B0", Offset = "0x457B1B0", VA = "0x18457C3B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x457C790", Offset = "0x457B590", VA = "0x18457C790", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4192B80", Offset = "0x4191980", VA = "0x184192B80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<GNONOHANGHO<T1, T2, T3>> IEnumerable<Tuple<T1, T2, T3>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x33FCC70", Offset = "0x33FBA70", VA = "0x1833FCC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2339E20", Offset = "0x2338C20", VA = "0x182339E20")]
	public static JNNBCBJFHMF<T1> FLOGCKGNDEE<T1>(T1 PBGCNAOKBNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3468240", Offset = "0x3467040", VA = "0x183468240")]
	public static BMODNCKLICN<T1, T2> FLOGCKGNDEE<T1, T2>(T1 PBGCNAOKBNP, T2 BADLCIAEHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x34682B0", Offset = "0x34670B0", VA = "0x1834682B0")]
	public static GNONOHANGHO<T1, T2, T3> FLOGCKGNDEE<T1, T2, T3>(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x301FAA0", Offset = "0x301E8A0", VA = "0x18301FAA0")]
	public static IGDPEHCFLIH<T1, T2, T3, T4> FLOGCKGNDEE<T1, T2, T3, T4>(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3468580", Offset = "0x3467380", VA = "0x183468580")]
	public static DDKLLAGBNKL<T1, T2, T3, T4, T5> FLOGCKGNDEE<T1, T2, T3, T4, T5>(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO, T5 AMMMGIEAFPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x34684D0", Offset = "0x34672D0", VA = "0x1834684D0")]
	public static POHMIBHINIE<T1, T2, T3, T4, T5, T6> FLOGCKGNDEE<T1, T2, T3, T4, T5, T6>(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO, T5 AMMMGIEAFPM, T6 MGHIBLBCEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3468410", Offset = "0x3467210", VA = "0x183468410")]
	public static PBNBMLKGFFJ<T1, T2, T3, T4, T5, T6, T7> FLOGCKGNDEE<T1, T2, T3, T4, T5, T6, T7>(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO, T5 AMMMGIEAFPM, T6 MGHIBLBCEOO, T7 DNOBAIFBDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3468340", Offset = "0x3467140", VA = "0x183468340")]
	public static OPCIMBGHLAO<T1, T2, T3, T4, T5, T6, T7, T8> FLOGCKGNDEE<T1, T2, T3, T4, T5, T6, T7, T8>(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO, T5 AMMMGIEAFPM, T6 MGHIBLBCEOO, T7 DNOBAIFBDON, T8 BBJMBCOOLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F76760", Offset = "0x1F75560", VA = "0x181F76760")]
	[IteratorStateMachine(typeof(PEBHGMJPCOI<, >))]
	public static IEnumerable<BMODNCKLICN<T1, T2>> HGMKFIGCMAB<T1, T2>(IEnumerable<T1> IKGMJGNOMBA, IEnumerable<T2> GOEPIJCAGGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1F76800", Offset = "0x1F75600", VA = "0x181F76800")]
	[IteratorStateMachine(typeof(ADAPKNFHDFD<, , >))]
	public static IEnumerable<GNONOHANGHO<T1, T2, T3>> HGMKFIGCMAB<T1, T2, T3>(IEnumerable<T1> IKGMJGNOMBA, IEnumerable<T2> GOEPIJCAGGA, IEnumerable<T3> GIDHMIEAOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F770", Offset = "0x6F6E570", VA = "0x186F6F770")]
	internal static int GDOPBBCNIFH(int CNDMMAFBKOE, int ADENBBIMCKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F710", Offset = "0x6F6E510", VA = "0x186F6F710")]
	internal static int GDOPBBCNIFH(int CNDMMAFBKOE, int ADENBBIMCKB, int PAKMEFHOMGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F780", Offset = "0x6F6E580", VA = "0x186F6F780")]
	internal static int GDOPBBCNIFH(int CNDMMAFBKOE, int ADENBBIMCKB, int PAKMEFHOMGO, int EPBGCAOAGCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F750", Offset = "0x6F6E550", VA = "0x186F6F750")]
	internal static int GDOPBBCNIFH(int CNDMMAFBKOE, int ADENBBIMCKB, int PAKMEFHOMGO, int EPBGCAOAGCE, int EIKAFJNJOLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F6E0", Offset = "0x6F6E4E0", VA = "0x186F6F6E0")]
	internal static int GDOPBBCNIFH(int CNDMMAFBKOE, int ADENBBIMCKB, int PAKMEFHOMGO, int EPBGCAOAGCE, int EIKAFJNJOLP, int CDDMDJDBDIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F7A0", Offset = "0x6F6E5A0", VA = "0x186F6F7A0")]
	internal static int GDOPBBCNIFH(int CNDMMAFBKOE, int ADENBBIMCKB, int PAKMEFHOMGO, int EPBGCAOAGCE, int EIKAFJNJOLP, int CDDMDJDBDIO, int JMBDGBIOLNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F720", Offset = "0x6F6E520", VA = "0x186F6F720")]
	internal static int GDOPBBCNIFH(int CNDMMAFBKOE, int ADENBBIMCKB, int PAKMEFHOMGO, int EPBGCAOAGCE, int EIKAFJNJOLP, int CDDMDJDBDIO, int JMBDGBIOLNG, int DDKDFJBIPMM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JNNBCBJFHMF<T1> : IComparable<JNNBCBJFHMF<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T1 DBBADGLBOOI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2372190", Offset = "0x2370F90", VA = "0x182372190")]
	public JNNBCBJFHMF(T1 PBGCNAOKBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3E77E70", Offset = "0x3E76C70", VA = "0x183E77E70", Slot = "4")]
	public int CompareTo(JNNBCBJFHMF<T1> FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3E77EE0", Offset = "0x3E76CE0", VA = "0x183E77EE0", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xABDD90", Offset = "0xABCB90", VA = "0x180ABDD90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3E77F80", Offset = "0x3E76D80", VA = "0x183E77F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BMODNCKLICN<T1, T2> : IComparable<BMODNCKLICN<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T1 DBBADGLBOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T2 DECNHNAFJOK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A510", Offset = "0x2A29310", VA = "0x182A2A510")]
	public BMODNCKLICN(T1 PBGCNAOKBNP, T2 BADLCIAEHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3CD60F0", Offset = "0x3CD4EF0", VA = "0x183CD60F0", Slot = "4")]
	public int CompareTo(BMODNCKLICN<T1, T2> FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD6DB0", Offset = "0x3CD5BB0", VA = "0x183CD6DB0", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7120", Offset = "0x3CD5F20", VA = "0x183CD7120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7E20", Offset = "0x3CD6C20", VA = "0x183CD7E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GNONOHANGHO<T1, T2, T3> : IComparable<GNONOHANGHO<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly T1 DBBADGLBOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly T2 DECNHNAFJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T3 OCOFNBNDNAC;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x467C7D0", Offset = "0x467B5D0", VA = "0x18467C7D0")]
	public GNONOHANGHO(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x467BF90", Offset = "0x467AD90", VA = "0x18467BF90", Slot = "4")]
	public int CompareTo(GNONOHANGHO<T1, T2, T3> FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x467C190", Offset = "0x467AF90", VA = "0x18467C190", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x467C4B0", Offset = "0x467B2B0", VA = "0x18467C4B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x467C620", Offset = "0x467B420", VA = "0x18467C620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IGDPEHCFLIH<T1, T2, T3, T4> : IComparable<IGDPEHCFLIH<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 DBBADGLBOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T2 DECNHNAFJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T3 OCOFNBNDNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T4 GIGCHFGJLFF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2A271F0", Offset = "0x2A25FF0", VA = "0x182A271F0")]
	public IGDPEHCFLIH(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2A26D80", Offset = "0x2A25B80", VA = "0x182A26D80", Slot = "4")]
	public int CompareTo(IGDPEHCFLIH<T1, T2, T3, T4> FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2A26EC0", Offset = "0x2A25CC0", VA = "0x182A26EC0", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A27000", Offset = "0x2A25E00", VA = "0x182A27000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2A270C0", Offset = "0x2A25EC0", VA = "0x182A270C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DDKLLAGBNKL<T1, T2, T3, T4, T5> : IComparable<DDKLLAGBNKL<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T1 DBBADGLBOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T2 DECNHNAFJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T3 OCOFNBNDNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T4 GIGCHFGJLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T5 LBOCEKBDDOD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB620", Offset = "0x2ACA420", VA = "0x182ACB620")]
	public DDKLLAGBNKL(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO, T5 AMMMGIEAFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB0E0", Offset = "0x2AC9EE0", VA = "0x182ACB0E0", Slot = "4")]
	public int CompareTo(DDKLLAGBNKL<T1, T2, T3, T4, T5> FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB260", Offset = "0x2ACA060", VA = "0x182ACB260", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB3D0", Offset = "0x2ACA1D0", VA = "0x182ACB3D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB4D0", Offset = "0x2ACA2D0", VA = "0x182ACB4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class POHMIBHINIE<T1, T2, T3, T4, T5, T6> : IComparable<POHMIBHINIE<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T1 DBBADGLBOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T2 DECNHNAFJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T3 OCOFNBNDNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T4 GIGCHFGJLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T5 LBOCEKBDDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T6 BFEMNJCPJMJ;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x41879C0", Offset = "0x41867C0", VA = "0x1841879C0")]
	public POHMIBHINIE(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO, T5 AMMMGIEAFPM, T6 MGHIBLBCEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x511C960", Offset = "0x511B760", VA = "0x18511C960", Slot = "4")]
	public int CompareTo(POHMIBHINIE<T1, T2, T3, T4, T5, T6> FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x511CB20", Offset = "0x511B920", VA = "0x18511CB20", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x511CCB0", Offset = "0x511BAB0", VA = "0x18511CCB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x511CDD0", Offset = "0x511BBD0", VA = "0x18511CDD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PBNBMLKGFFJ<T1, T2, T3, T4, T5, T6, T7> : IComparable<PBNBMLKGFFJ<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 DBBADGLBOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 DECNHNAFJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 OCOFNBNDNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 GIGCHFGJLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 LBOCEKBDDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 BFEMNJCPJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T7 DCLGDKKKMML;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x35EB140", Offset = "0x35E9F40", VA = "0x1835EB140")]
	public PBNBMLKGFFJ(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO, T5 AMMMGIEAFPM, T6 MGHIBLBCEOO, T7 DNOBAIFBDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x35EAAA0", Offset = "0x35E98A0", VA = "0x1835EAAA0", Slot = "4")]
	public int CompareTo(PBNBMLKGFFJ<T1, T2, T3, T4, T5, T6, T7> FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x35EACA0", Offset = "0x35E9AA0", VA = "0x1835EACA0", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x35EAE60", Offset = "0x35E9C60", VA = "0x1835EAE60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x35EAFB0", Offset = "0x35E9DB0", VA = "0x1835EAFB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OPCIMBGHLAO<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<OPCIMBGHLAO<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T1 DBBADGLBOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T2 DECNHNAFJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T3 OCOFNBNDNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T4 GIGCHFGJLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T5 LBOCEKBDDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T6 BFEMNJCPJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T7 DCLGDKKKMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T8 DFOLODBAIBM;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5968730", Offset = "0x5967530", VA = "0x185968730")]
	public OPCIMBGHLAO(T1 PBGCNAOKBNP, T2 BADLCIAEHKO, T3 AMAHNPLMGLH, T4 IBAJOMMGMEO, T5 AMMMGIEAFPM, T6 MGHIBLBCEOO, T7 DNOBAIFBDON, T8 BBJMBCOOLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5967FE0", Offset = "0x5966DE0", VA = "0x185967FE0", Slot = "4")]
	public int CompareTo(OPCIMBGHLAO<T1, T2, T3, T4, T5, T6, T7, T8> FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5968230", Offset = "0x5967030", VA = "0x185968230", Slot = "0")]
	public override bool Equals(object FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5968410", Offset = "0x5967210", VA = "0x185968410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5968580", Offset = "0x5967380", VA = "0x185968580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ANMFEHHGFOB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9B3AA0", Offset = "0x9B28A0", VA = "0x1809B3AA0")]
	public ANMFEHHGFOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HashableScriptableObject : ScriptableObject, FHPFOJCGIFK, BDPJCONNNMD, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x903350", Offset = "0x902150", VA = "0x180903350", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash JBJGEACIMDC);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xD69BC0", Offset = "0xD689C0", VA = "0x180D69BC0")]
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
	[NKMEAMOKJLF]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[SerializeField]
	[NKMEAMOKJLF]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F746A0", Offset = "0x6F734A0", VA = "0x186F746A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F74660", Offset = "0x6F73460", VA = "0x186F74660")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F746E0", Offset = "0x6F734E0", VA = "0x186F746E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F748B0", Offset = "0x6F736B0", VA = "0x186F748B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F74820", Offset = "0x6F73620", VA = "0x186F74820")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x952E10", Offset = "0x951C10", VA = "0x180952E10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xC54A00", Offset = "0xC53800", VA = "0x180C54A00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F74620", Offset = "0x6F73420", VA = "0x186F74620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F74790", Offset = "0x6F73590", VA = "0x186F74790")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F74060", Offset = "0x6F72E60", VA = "0x186F74060")]
	public void CopyBounds(SavedExtents FGBEDAPNDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F74580", Offset = "0x6F73380", VA = "0x186F74580")]
	public void SetLocalSpaceBounds(Bounds AMLBCFMFMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F73A00", Offset = "0x6F72800", VA = "0x186F73A00")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6F74570", Offset = "0x6F73370", VA = "0x186F74570")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F74150", Offset = "0x6F72F50", VA = "0x186F74150")]
	private void KKNLMLIEGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F74340", Offset = "0x6F73140", VA = "0x186F74340")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F73A20", Offset = "0x6F72820", VA = "0x186F73A20")]
	public static void CalculateLocalBoundsFor(GameObject KKHNMHOFPEF, out Bounds AMLBCFMFMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F74090", Offset = "0x6F72E90", VA = "0x186F74090")]
	private static void JAIOFDKEFPH(Bounds GOEPIJCAGGA, Color GIDHMIEAOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F745A0", Offset = "0x6F733A0", VA = "0x186F745A0")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class DNGLMLHAHAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct AEALJHKJDLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public T ODIKHJJHMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float FJFALIJLGMA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static float HINNHJMJNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<T> GBAFJJHBCJN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const int HHOAJCOPMGA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private AEALJHKJDLF[] PKPHLPFOPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int HNGDENFEEHH;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float ALDCCMEIPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9D8010", Offset = "0x9D6E10", VA = "0x1809D8010")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9D8020", Offset = "0x9D6E20", VA = "0x1809D8020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0D40", Offset = "0x3B9FB40", VA = "0x183BA0D40")]
	public DNGLMLHAHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0D70", Offset = "0x3B9FB70", VA = "0x183BA0D70")]
	public DNGLMLHAHAG(int IBDNNEMEJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B9FE20", Offset = "0x3B9EC20", VA = "0x183B9FE20")]
	public void IMFFJGIMDFG(float NNAJPCMFKJE, T KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BA00E0", Offset = "0x3B9EEE0", VA = "0x183BA00E0")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F890", Offset = "0x3B9E690", VA = "0x183B9F890")]
	public bool GHFGAIJEIEJ(float JLEJFHHIDGA, float HPDBGEHLNLP, out T KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0630", Offset = "0x3B9F430", VA = "0x183BA0630")]
	public bool OLLPAGDOOJD(float JLEJFHHIDGA, float HPDBGEHLNLP, out T KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0AA0", Offset = "0x3B9F8A0", VA = "0x183BA0AA0")]
	public void PPGOENCPMBG(float JLEJFHHIDGA, float HPDBGEHLNLP, List<T> PLHMHNJGNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F860", Offset = "0x3B9E660", VA = "0x183B9F860")]
	private int BAODGPAIIFD(int KAHJBJDLAHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3BA00A0", Offset = "0x3B9EEA0", VA = "0x183BA00A0")]
	private void LEEMBPHEDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FLLOEEIPOLF();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T EGEIGBLGCLL(T AEFFKJDEELO, T CPGPPMFIMKK, float FHCFEADADAC);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T ILCMFMIJAME(T KKLNCEHOHED, float FHCFEADADAC);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T AAKLJNJEEBD(T AEFFKJDEELO, T CPGPPMFIMKK);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T LNAKPCHDKHJ(T AEFFKJDEELO, T CPGPPMFIMKK);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DGDLGLBCFEP : DNGLMLHAHAG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1859620", Offset = "0x1858420", VA = "0x181859620", Slot = "4")]
	protected override Vector3 FLLOEEIPOLF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2B591C0", Offset = "0x2B57FC0", VA = "0x182B591C0", Slot = "5")]
	protected override Vector3 EGEIGBLGCLL(Vector3 AEFFKJDEELO, Vector3 CPGPPMFIMKK, float FHCFEADADAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EC10", Offset = "0x6F6DA10", VA = "0x186F6EC10", Slot = "6")]
	protected override Vector3 ILCMFMIJAME(Vector3 KKLNCEHOHED, float FHCFEADADAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EB90", Offset = "0x6F6D990", VA = "0x186F6EB90", Slot = "7")]
	protected override Vector3 AAKLJNJEEBD(Vector3 AEFFKJDEELO, Vector3 CPGPPMFIMKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EC70", Offset = "0x6F6DA70", VA = "0x186F6EC70", Slot = "8")]
	protected override Vector3 LNAKPCHDKHJ(Vector3 AEFFKJDEELO, Vector3 CPGPPMFIMKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F6ECE0", Offset = "0x6F6DAE0", VA = "0x186F6ECE0")]
	public DGDLGLBCFEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CCKHHKHNCGD : DNGLMLHAHAG<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E810", Offset = "0x6F6D610", VA = "0x186F6E810")]
	public CCKHHKHNCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E7A0", Offset = "0x6F6D5A0", VA = "0x186F6E7A0")]
	public CCKHHKHNCGD(int IBDNNEMEJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xF83540", Offset = "0xF82340", VA = "0x180F83540", Slot = "4")]
	protected override float FLLOEEIPOLF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x41481E0", Offset = "0x4146FE0", VA = "0x1841481E0", Slot = "5")]
	protected override float EGEIGBLGCLL(float AEFFKJDEELO, float CPGPPMFIMKK, float FHCFEADADAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5C5BDF0", Offset = "0x5C5ABF0", VA = "0x185C5BDF0", Slot = "6")]
	protected override float ILCMFMIJAME(float KKLNCEHOHED, float FHCFEADADAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E780", Offset = "0x6F6D580", VA = "0x186F6E780", Slot = "7")]
	protected override float AAKLJNJEEBD(float AEFFKJDEELO, float CPGPPMFIMKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E790", Offset = "0x6F6D590", VA = "0x186F6E790", Slot = "8")]
	protected override float LNAKPCHDKHJ(float AEFFKJDEELO, float CPGPPMFIMKK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FMMJFBHEPCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IDisposable LNABDBHCENK;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public FMMJFBHEPCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KMEEDEAAMDP : GBHACGAOKCI<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F715F0", Offset = "0x6F703F0", VA = "0x186F715F0")]
	public KMEEDEAAMDP(int OFPPAGPDNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F71590", Offset = "0x6F70390", VA = "0x186F71590")]
	public KMEEDEAAMDP(NGJPBLACNBN[] NDIIJFKNOMA, bool HJLHFAFCFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F71520", Offset = "0x6F70320", VA = "0x186F71520", Slot = "6")]
	protected override uint JFIHADKLCMK(uint JBJGEACIMDC, string KKLNCEHOHED)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class ICAJNIFHNKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct EGLDLBGJFEF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly ICAJNIFHNKG<T> DDLKJMLAPFC;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T ODIKHJJHMMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x30D82D0", Offset = "0x30D70D0", VA = "0x1830D82D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x30D82A0", Offset = "0x30D70A0", VA = "0x1830D82A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
		public EGLDLBGJFEF(ICAJNIFHNKG<T> DDLKJMLAPFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DFILPILOLEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<EGLDLBGJFEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public ICAJNIFHNKG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public DFILPILOLEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD650", Offset = "0x2ACC450", VA = "0x182ACD650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class DFNPDPLJBCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<EGLDLBGJFEF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public ICAJNIFHNKG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public DFNPDPLJBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACDDD0", Offset = "0x2ACCBD0", VA = "0x182ACDDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly SemaphoreSlim MJLGDFMNOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T DNKBKEJDAPM;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int ABPAFCJOAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3664380", Offset = "0x3663180", VA = "0x183664380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3664B20", Offset = "0x3663920", VA = "0x183664B20")]
	public ICAJNIFHNKG(in T DNKBKEJDAPM, int LMNOAFAHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3664C60", Offset = "0x3663A60", VA = "0x183664C60")]
	public ICAJNIFHNKG(in T DNKBKEJDAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x36643A0", Offset = "0x36631A0", VA = "0x1836643A0")]
	public EGLDLBGJFEF EEBEJMDKIJP()
	{
		return default(EGLDLBGJFEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x36643E0", Offset = "0x36631E0", VA = "0x1836643E0")]
	public EGLDLBGJFEF EEBEJMDKIJP(CancellationToken KIMBGNGMOGB)
	{
		return default(EGLDLBGJFEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3664420", Offset = "0x3663220", VA = "0x183664420")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICAJNIFHNKG<>.DFILPILOLEP))]
	public Task<EGLDLBGJFEF> EMDPLHKGFEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x36647A0", Offset = "0x36635A0", VA = "0x1836647A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ICAJNIFHNKG<>.DFNPDPLJBCN))]
	public Task<EGLDLBGJFEF> EMDPLHKGFEM(CancellationToken KIMBGNGMOGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class FJFBNFPICCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F510", Offset = "0x6F6E310", VA = "0x186F6F510")]
	public static ICAJNIFHNKG<MELLEHNAKNA> PKJHFAGPFPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F570", Offset = "0x6F6E370", VA = "0x186F6F570")]
	public static ICAJNIFHNKG<MELLEHNAKNA> PKJHFAGPFPD(int LMNOAFAHBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2339E20", Offset = "0x2338C20", VA = "0x182339E20")]
	public static ICAJNIFHNKG<T> PKJHFAGPFPD<T>(in T DNKBKEJDAPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2339E80", Offset = "0x2338C80", VA = "0x182339E80")]
	public static ICAJNIFHNKG<T> PKJHFAGPFPD<T>(in T DNKBKEJDAPM, int LMNOAFAHBDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class HECGKKODJHF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private HECGKKODJHF<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x7F1D80", Offset = "0x7F0B80", VA = "0x1807F1D80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3B20FE0", Offset = "0x3B1FDE0", VA = "0x183B20FE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x36CA640", Offset = "0x36C9440", VA = "0x1836CA640")]
		public Enumerator(HECGKKODJHF<T> PLHMHNJGNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3B20160", Offset = "0x3B1EF60", VA = "0x183B20160", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3B20D80", Offset = "0x3B1FB80", VA = "0x183B20D80", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DF20", Offset = "0x3B1CD20", VA = "0x183B1DF20")]
		private void JDODJPKLCIG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private T[] ABIKDGNONGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int DIDHGEABMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int GDBDGHNEKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private int OAFCEFJIFII;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x373D1C0", Offset = "0x373BFC0", VA = "0x18373D1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x373E1E0", Offset = "0x373CFE0", VA = "0x18373E1E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x373D140", Offset = "0x373BF40", VA = "0x18373D140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x373E950", Offset = "0x373D750", VA = "0x18373E950")]
	public HECGKKODJHF(int OFPPAGPDNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x373D200", Offset = "0x373C000", VA = "0x18373D200")]
	public void IMFFJGIMDFG(T FHCFEADADAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x373DB10", Offset = "0x373C910", VA = "0x18373DB10")]
	public void JLFFFFDBMNL(IEnumerable<T> LLMAEEFJLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x373E360", Offset = "0x373D160", VA = "0x18373E360")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x373E380", Offset = "0x373D180", VA = "0x18373E380")]
	public void MJEFCNJCLOI(int FNLBOMKPGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x373CA10", Offset = "0x373B810", VA = "0x18373CA10")]
	public void EGBAABHDGPE(int FNLBOMKPGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x373CD20", Offset = "0x373BB20", VA = "0x18373CD20")]
	public void GAIHPJLIEGF(T[] PKPHLPFOPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x373E140", Offset = "0x373CF40", VA = "0x18373E140")]
	public Enumerator JOJADCJMMBH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x373E7D0", Offset = "0x373D5D0", VA = "0x18373E7D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x373E7D0", Offset = "0x373D5D0", VA = "0x18373E7D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x373E500", Offset = "0x373D300", VA = "0x18373E500")]
	private int NCMIDIOJFFH(int FHOMILACEHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x373CFA0", Offset = "0x373BDA0", VA = "0x18373CFA0")]
	private int GKBPFFGJNKI(int FHOMILACEHB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class JEKNCCBHIOL
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PJCBHLKHAKC(object[] DCPGFNKOIOA);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	protected JEKNCCBHIOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class LIDNCNKBOPE<T> : JEKNCCBHIOL
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	protected struct HHINOIOOGHK
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum DMKNEJDOLKA
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
		public DMKNEJDOLKA LKLFHGBOOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public T EHPEOJCHKEM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int BHLNOIDBMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly bool IKHNDGOICDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly bool JOMJJAELECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	protected List<T> OBPMHHOBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<HHINOIOOGHK> DEKMMBCDFOI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool LINPANFHAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x37D14B0", Offset = "0x37D02B0", VA = "0x1837D14B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x37D14F0", Offset = "0x37D02F0", VA = "0x1837D14F0")]
	protected LIDNCNKBOPE(bool JOMJJAELECB, bool IKHNDGOICDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x37D1220", Offset = "0x37D0020", VA = "0x1837D1220")]
	protected bool LONJKFPBOIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x37D12A0", Offset = "0x37D00A0", VA = "0x1837D12A0")]
	protected void MGOFAJDICPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x37D0E00", Offset = "0x37CFC00", VA = "0x1837D0E00")]
	protected void HDBOHIGPAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AAD0E0", Offset = "0x2AABEE0", VA = "0x182AAD0E0")]
	private static void KGJJAIOPHAH<U>(ref List<U> IPGDFFNNILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x37D0FB0", Offset = "0x37CFDB0", VA = "0x1837D0FB0", Slot = "5")]
	public void IMFFJGIMDFG(T EHPEOJCHKEM, bool IJAJBLCPJLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x37D1360", Offset = "0x37D0160", VA = "0x1837D1360", Slot = "6")]
	public void OIPPMFBKPAM(T EHPEOJCHKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x37D1110", Offset = "0x37CFF10", VA = "0x1837D1110")]
	public void LEKENBMMMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface POKNKOICOGG
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMFFJGIMDFG(Action EHPEOJCHKEM, bool IJAJBLCPJLJ = false);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIPPMFBKPAM(Action EHPEOJCHKEM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class PGDADKMBOJE : LIDNCNKBOPE<Action>, POKNKOICOGG
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F733A0", Offset = "0x6F721A0", VA = "0x186F733A0")]
	public PGDADKMBOJE(bool JOMJJAELECB = false, bool IKHNDGOICDJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F730D0", Offset = "0x6F71ED0", VA = "0x186F730D0")]
	public void KEFABPFMPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F73330", Offset = "0x6F72130", VA = "0x186F73330", Slot = "4")]
	public override void PJCBHLKHAKC(object[] DCPGFNKOIOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F73070", Offset = "0x6F71E70", VA = "0x186F73070")]
	public static PGDADKMBOJE COHLNPJMOAO(PGDADKMBOJE INNPKNIAIGH, Action EHPEOJCHKEM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F732D0", Offset = "0x6F720D0", VA = "0x186F732D0")]
	public static PGDADKMBOJE MGKHCIABADO(PGDADKMBOJE INNPKNIAIGH, Action EHPEOJCHKEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface LOKKLDIHBPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMFFJGIMDFG(Action<T> EHPEOJCHKEM, bool IJAJBLCPJLJ = false);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIPPMFBKPAM(Action<T> EHPEOJCHKEM);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class ONLGFGHLFCK<T> : LIDNCNKBOPE<Action<T>>, LOKKLDIHBPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x319F4E0", Offset = "0x319E2E0", VA = "0x18319F4E0")]
	public ONLGFGHLFCK(bool JOMJJAELECB = false, bool IKHNDGOICDJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4AFD4F0", Offset = "0x4AFC2F0", VA = "0x184AFD4F0")]
	public void KEFABPFMPEM(T FHCFEADADAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4AFFE70", Offset = "0x4AFEC70", VA = "0x184AFFE70", Slot = "4")]
	public override void PJCBHLKHAKC(object[] DCPGFNKOIOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4AFCD90", Offset = "0x4AFBB90", VA = "0x184AFCD90")]
	public static ONLGFGHLFCK<T> COHLNPJMOAO(ONLGFGHLFCK<T> INNPKNIAIGH, Action<T> EHPEOJCHKEM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4AFEC50", Offset = "0x4AFDA50", VA = "0x184AFEC50")]
	public static ONLGFGHLFCK<T> MGKHCIABADO(ONLGFGHLFCK<T> INNPKNIAIGH, Action<T> EHPEOJCHKEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CNPMGNGNKKB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMFFJGIMDFG(Action<T, U> EHPEOJCHKEM, bool IJAJBLCPJLJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIPPMFBKPAM(Action<T, U> EHPEOJCHKEM);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class JGGFBJAFCNG<T, U> : LIDNCNKBOPE<Action<T, U>>, CNPMGNGNKKB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x319F4E0", Offset = "0x319E2E0", VA = "0x18319F4E0")]
	public JGGFBJAFCNG(bool JOMJJAELECB = false, bool IKHNDGOICDJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x319A420", Offset = "0x3199220", VA = "0x18319A420")]
	public void KEFABPFMPEM(T FHCFEADADAC, U IBKNLPKKBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x319D9D0", Offset = "0x319C7D0", VA = "0x18319D9D0", Slot = "4")]
	public override void PJCBHLKHAKC(object[] DCPGFNKOIOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x31997C0", Offset = "0x31985C0", VA = "0x1831997C0")]
	public static JGGFBJAFCNG<T, U> COHLNPJMOAO(JGGFBJAFCNG<T, U> INNPKNIAIGH, Action<T, U> EHPEOJCHKEM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x319C2A0", Offset = "0x319B0A0", VA = "0x18319C2A0")]
	public static JGGFBJAFCNG<T, U> MGKHCIABADO(JGGFBJAFCNG<T, U> INNPKNIAIGH, Action<T, U> EHPEOJCHKEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface BLOBNOEKJBG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMFFJGIMDFG(Action<T, U, V> EHPEOJCHKEM, bool IJAJBLCPJLJ = false);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIPPMFBKPAM(Action<T, U, V> EHPEOJCHKEM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class BLNDDACEALJ<T, U, V> : LIDNCNKBOPE<Action<T, U, V>>, BLOBNOEKJBG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x319F4E0", Offset = "0x319E2E0", VA = "0x18319F4E0")]
	public BLNDDACEALJ(bool JOMJJAELECB = false, bool IKHNDGOICDJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0280", Offset = "0x3CCF080", VA = "0x183CD0280")]
	public void KEFABPFMPEM(T FHCFEADADAC, U IBKNLPKKBNL, V KNGGHDKEDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD1920", Offset = "0x3CD0720", VA = "0x183CD1920", Slot = "4")]
	public override void PJCBHLKHAKC(object[] DCPGFNKOIOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE860", Offset = "0x3CCD660", VA = "0x183CCE860")]
	public static BLNDDACEALJ<T, U, V> COHLNPJMOAO(BLNDDACEALJ<T, U, V> INNPKNIAIGH, Action<T, U, V> EHPEOJCHKEM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3CD0990", Offset = "0x3CCF790", VA = "0x183CD0990")]
	public static BLNDDACEALJ<T, U, V> MGKHCIABADO(BLNDDACEALJ<T, U, V> INNPKNIAIGH, Action<T, U, V> EHPEOJCHKEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface EDMGELKHFOK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMFFJGIMDFG(Action<T, U, V, W> EHPEOJCHKEM, bool IJAJBLCPJLJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIPPMFBKPAM(Action<T, U, V, W> EHPEOJCHKEM);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class JPFDHGDJFIN<T, U, V, W> : LIDNCNKBOPE<Action<T, U, V, W>>, EDMGELKHFOK<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x319F4E0", Offset = "0x319E2E0", VA = "0x18319F4E0")]
	public JPFDHGDJFIN(bool JOMJJAELECB = false, bool IKHNDGOICDJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3E797A0", Offset = "0x3E785A0", VA = "0x183E797A0")]
	public void KEFABPFMPEM(T FHCFEADADAC, U IBKNLPKKBNL, V KNGGHDKEDNP, W GNALOLLNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B130", Offset = "0x3E79F30", VA = "0x183E7B130", Slot = "4")]
	public override void PJCBHLKHAKC(object[] DCPGFNKOIOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3E78960", Offset = "0x3E77760", VA = "0x183E78960")]
	public static JPFDHGDJFIN<T, U, V, W> COHLNPJMOAO(JPFDHGDJFIN<T, U, V, W> INNPKNIAIGH, Action<T, U, V, W> EHPEOJCHKEM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3E79EF0", Offset = "0x3E78CF0", VA = "0x183E79EF0")]
	public static JPFDHGDJFIN<T, U, V, W> MGKHCIABADO(JPFDHGDJFIN<T, U, V, W> INNPKNIAIGH, Action<T, U, V, W> EHPEOJCHKEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HGGBEEJJMMJ<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMFFJGIMDFG(Action<T, U, V, W, X> EHPEOJCHKEM, bool IJAJBLCPJLJ = false);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIPPMFBKPAM(Action<T, U, V, W, X> EHPEOJCHKEM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class ICILDEKIGJD<T, U, V, W, X> : LIDNCNKBOPE<Action<T, U, V, W, X>>, HGGBEEJJMMJ<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x319F4E0", Offset = "0x319E2E0", VA = "0x18319F4E0")]
	public ICILDEKIGJD(bool JOMJJAELECB = false, bool IKHNDGOICDJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3669880", Offset = "0x3668680", VA = "0x183669880")]
	public void KEFABPFMPEM(T FHCFEADADAC, U IBKNLPKKBNL, V KNGGHDKEDNP, W GNALOLLNLNL, X ELAKNHNBHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3669BB0", Offset = "0x36689B0", VA = "0x183669BB0", Slot = "4")]
	public override void PJCBHLKHAKC(object[] DCPGFNKOIOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x36694B0", Offset = "0x36682B0", VA = "0x1836694B0")]
	public static ICILDEKIGJD<T, U, V, W, X> COHLNPJMOAO(ICILDEKIGJD<T, U, V, W, X> INNPKNIAIGH, Action<T, U, V, W, X> EHPEOJCHKEM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3669B10", Offset = "0x3668910", VA = "0x183669B10")]
	public static ICILDEKIGJD<T, U, V, W, X> MGKHCIABADO(ICILDEKIGJD<T, U, V, W, X> INNPKNIAIGH, Action<T, U, V, W, X> EHPEOJCHKEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface LJBDDFEILGH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMFFJGIMDFG(Action<T, U, V, W, X, Y> EHPEOJCHKEM, bool IJAJBLCPJLJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIPPMFBKPAM(Action<T, U, V, W, X, Y> EHPEOJCHKEM);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class BGBJMEEMEJG<T, U, V, W, X, Y> : LIDNCNKBOPE<Action<T, U, V, W, X, Y>>, LJBDDFEILGH<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x319F4E0", Offset = "0x319E2E0", VA = "0x18319F4E0")]
	public BGBJMEEMEJG(bool JOMJJAELECB = false, bool IKHNDGOICDJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3DE7E50", Offset = "0x3DE6C50", VA = "0x183DE7E50")]
	public void KEFABPFMPEM(T FHCFEADADAC, U IBKNLPKKBNL, V KNGGHDKEDNP, W GNALOLLNLNL, X ELAKNHNBHMF, Y MNMNIIAFFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8870", Offset = "0x3DE7670", VA = "0x183DE8870", Slot = "4")]
	public override void PJCBHLKHAKC(object[] DCPGFNKOIOA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3DE77E0", Offset = "0x3DE65E0", VA = "0x183DE77E0")]
	public static BGBJMEEMEJG<T, U, V, W, X, Y> COHLNPJMOAO(BGBJMEEMEJG<T, U, V, W, X, Y> INNPKNIAIGH, Action<T, U, V, W, X, Y> EHPEOJCHKEM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8110", Offset = "0x3DE6F10", VA = "0x183DE8110")]
	public static BGBJMEEMEJG<T, U, V, W, X, Y> MGKHCIABADO(BGBJMEEMEJG<T, U, V, W, X, Y> INNPKNIAIGH, Action<T, U, V, W, X, Y> EHPEOJCHKEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct FGBIGHGBAGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class FMHKNCOCGLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public FMHKNCOCGLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x36D5510", Offset = "0x36D4310", VA = "0x1836D5510")]
		internal void AJAELOJEPJF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BCIAKFCDGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int HIDKJMNFFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int LGGOGDICIGG;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x130C070", Offset = "0x130AE70", VA = "0x18130C070")]
	private FGBIGHGBAGF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> JAOAJMKGCFI, int ICIABGMBHDL, int CDFPGBAKLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4673220", Offset = "0x4672020", VA = "0x184673220")]
	public static FGBIGHGBAGF<T> PKJHFAGPFPD()
	{
		return default(FGBIGHGBAGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4671C60", Offset = "0x4670A60", VA = "0x184671C60")]
	public (int, int, Task<T>) NKDFNFBANDM(int DOGONGHFDJN, [Optional] CancellationToken KIMBGNGMOGB, double PFNOEDNDKJB = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4671A90", Offset = "0x4670890", VA = "0x184671A90")]
	public void EHLINAGEDMJ(int DOGONGHFDJN, int CDFPGBAKLGM, in T IFKOGMJAAJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EMJFFJFJDLJ
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F4C0", Offset = "0x6F6E2C0", VA = "0x186F6F4C0")]
	public static FGBIGHGBAGF<MELLEHNAKNA> PKJHFAGPFPD()
	{
		return default(FGBIGHGBAGF<MELLEHNAKNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F440", Offset = "0x6F6E240", VA = "0x186F6F440")]
	public static void EHLINAGEDMJ(this in FGBIGHGBAGF<MELLEHNAKNA> FEEMIHFJMDK, int DOGONGHFDJN, int CDFPGBAKLGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public class LGNPNOJOALO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, TVal> BNLKAELIOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Dictionary<TVal, TKey> EHDAEEBFPLF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2372160", Offset = "0x2370F60", VA = "0x182372160", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool CKPLHALPLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> NJCKEOKINHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2C3A2A0", Offset = "0x2C390A0", VA = "0x182C3A2A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TVal> LNGOFLECNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2373530", Offset = "0x2372330", VA = "0x182373530", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TVal MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x43F9D10", Offset = "0x43F8B10", VA = "0x1843F9D10", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x43F9D80", Offset = "0x43F8B80", VA = "0x1843F9D80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TKey MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x43F9300", Offset = "0x43F8100", VA = "0x1843F9300")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x43F8F70", Offset = "0x43F7D70", VA = "0x1843F8F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x43F8BA0", Offset = "0x43F79A0", VA = "0x1843F8BA0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x43F9AE0", Offset = "0x43F88E0", VA = "0x1843F9AE0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x43F8A50", Offset = "0x43F7850", VA = "0x1843F8A50", Slot = "9")]
	public void Add(TKey LGKPJAJAOLI, TVal KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x43F8AC0", Offset = "0x43F78C0", VA = "0x1843F8AC0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IGAFFKCMBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x43F8C00", Offset = "0x43F7A00", VA = "0x1843F8C00", Slot = "8")]
	public bool ContainsKey(TKey LGKPJAJAOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x43F8C60", Offset = "0x43F7A60", VA = "0x1843F8C60", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x343E040", Offset = "0x343CE40", VA = "0x18343E040", Slot = "10")]
	public bool Remove(TKey LGKPJAJAOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x43F9AB0", Offset = "0x43F88B0", VA = "0x1843F9AB0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x43F9BD0", Offset = "0x43F89D0", VA = "0x1843F9BD0", Slot = "11")]
	public bool TryGetValue(TKey LGKPJAJAOLI, out TVal KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x36D3280", Offset = "0x36D2080", VA = "0x1836D3280", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x43F8C90", Offset = "0x43F7A90", VA = "0x1843F8C90", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PKPHLPFOPGM, int GIDMKIFNOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x43F8FE0", Offset = "0x43F7DE0", VA = "0x1843F8FE0")]
	public void IMFFJGIMDFG(TVal IEGGAJNPOJC, TKey LGKPJAJAOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x43F9020", Offset = "0x43F7E20", VA = "0x1843F9020")]
	public void IMFFJGIMDFG(KeyValuePair<TVal, TKey> IGAFFKCMBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x43F8D20", Offset = "0x43F7B20", VA = "0x1843F8D20")]
	public bool DGCKGGHBOIO(TVal LGKPJAJAOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x43F8B00", Offset = "0x43F7900", VA = "0x1843F8B00")]
	public bool BBJPLADBJND(KeyValuePair<TVal, TKey> IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x43F9A10", Offset = "0x43F8810", VA = "0x1843F9A10")]
	public bool OIPPMFBKPAM(TVal LGKPJAJAOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x43F9A10", Offset = "0x43F8810", VA = "0x1843F9A10")]
	public bool OIPPMFBKPAM(KeyValuePair<TVal, TKey> IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x43F9520", Offset = "0x43F8320", VA = "0x1843F9520")]
	public bool NENMDMPJEFC(TVal LGKPJAJAOLI, out TKey KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x43F8D60", Offset = "0x43F7B60", VA = "0x1843F8D60")]
	public IEnumerator<KeyValuePair<TVal, TKey>> DMBNDMDLDKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x43F9230", Offset = "0x43F8030", VA = "0x1843F9230")]
	private void JNBLKJKNIJG(TKey LGKPJAJAOLI, TVal IEGGAJNPOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x43F93C0", Offset = "0x43F81C0", VA = "0x1843F93C0")]
	private void MGNHKIJHKEF(TKey LGKPJAJAOLI, TVal IEGGAJNPOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x43F9700", Offset = "0x43F8500", VA = "0x1843F9700")]
	private bool NHFPLJELIBF(TKey LGKPJAJAOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x43F9620", Offset = "0x43F8420", VA = "0x1843F9620")]
	private bool NHFPLJELIBF(TVal IEGGAJNPOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x43F9C00", Offset = "0x43F8A00", VA = "0x1843F9C00")]
	public LGNPNOJOALO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DefaultMember("Item")]
public class FHJCEOJPHAD<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Func<Internal, External> JFHPDFFKJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<External, Internal> FBPFGFMBBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private IList<Internal> IPGDFFNNILJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IList<Internal> CBGCIFFFEKH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x903350", Offset = "0x902150", VA = "0x180903350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CKPLHALPLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9D2F60", Offset = "0x9D1D60", VA = "0x1809D2F60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9D30A0", Offset = "0x9D1EA0", VA = "0x1809D30A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4675400", Offset = "0x4674200", VA = "0x184675400", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x46754A0", Offset = "0x46742A0", VA = "0x1846754A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x46753A0", Offset = "0x46741A0", VA = "0x1846753A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x43F8880", Offset = "0x43F7680", VA = "0x1843F8880")]
	public FHJCEOJPHAD(Func<Internal, External> JFHPDFFKJDJ, Func<External, Internal> FBPFGFMBBCP, bool NCMJFNEGFHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x46750C0", Offset = "0x4673EC0", VA = "0x1846750C0", Slot = "6")]
	public int IndexOf(External IGAFFKCMBEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4674D40", Offset = "0x4673B40", VA = "0x184674D40", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4674DA0", Offset = "0x4673BA0", VA = "0x184674DA0", Slot = "13")]
	public bool Contains(External IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4674E30", Offset = "0x4673C30", VA = "0x184674E30", Slot = "14")]
	public void CopyTo(External[] PKPHLPFOPGM, int GIDMKIFNOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4674C50", Offset = "0x4673A50", VA = "0x184674C50", Slot = "11")]
	public void Add(External IGAFFKCMBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x46751B0", Offset = "0x4673FB0", VA = "0x1846751B0", Slot = "7")]
	public void Insert(int FHOMILACEHB, External IGAFFKCMBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4675310", Offset = "0x4674110", VA = "0x184675310", Slot = "15")]
	public bool Remove(External IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4675250", Offset = "0x4674050", VA = "0x184675250", Slot = "8")]
	public void RemoveAt(int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4675050", Offset = "0x4673E50", VA = "0x184675050", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x35F8AB0", Offset = "0x35F78B0", VA = "0x1835F8AB0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class KMLIHKJDAGE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Func<Internal, External> JFHPDFFKJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IReadOnlyList<Internal> IPGDFFNNILJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> CBGCIFFFEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool CKPLHALPLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x44C36E0", Offset = "0x44C24E0", VA = "0x1844C36E0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x44C3680", Offset = "0x44C2480", VA = "0x1844C3680", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2372190", Offset = "0x2370F90", VA = "0x182372190")]
	public KMLIHKJDAGE(Func<Internal, External> JFHPDFFKJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x44C3630", Offset = "0x44C2430", VA = "0x1844C3630")]
	public KMLIHKJDAGE(IReadOnlyList<Internal> IPGDFFNNILJ, Func<Internal, External> JFHPDFFKJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x44C33A0", Offset = "0x44C21A0", VA = "0x1844C33A0")]
	public void GAIHPJLIEGF(External[] PKPHLPFOPGM, int GIDMKIFNOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x44C35C0", Offset = "0x44C23C0", VA = "0x1844C35C0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x236DE80", Offset = "0x236CC80", VA = "0x18236DE80", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DefaultMember("Item")]
public class MNJBGIJCPOK<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> IPGDFFNNILJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IReadOnlyList<Internal> CBGCIFFFEKH
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool CKPLHALPLKL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public External MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x361F500", Offset = "0x361E300", VA = "0x18361F500", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x361F4A0", Offset = "0x361E2A0", VA = "0x18361F4A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2372190", Offset = "0x2370F90", VA = "0x182372190")]
	public MNJBGIJCPOK(IReadOnlyList<Internal> IPGDFFNNILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x361F160", Offset = "0x361DF60", VA = "0x18361F160")]
	public bool BBJPLADBJND(External IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x361F200", Offset = "0x361E000", VA = "0x18361F200")]
	public void GAIHPJLIEGF(External[] PKPHLPFOPGM, int GIDMKIFNOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x361F430", Offset = "0x361E230", VA = "0x18361F430", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x35F8AB0", Offset = "0x35F78B0", VA = "0x1835F8AB0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JGOBHBHFKIP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> IALKGBEKBNN(TRequest IDLLMGEFFMF, CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum CENAMGFGLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class ALKNDEODKOF
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const float OAFFDAMFDCO = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TimeSpan DEFCNOOKFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int FKMOJHKCOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CENAMGFGLIJ FDFPIPFMFCG;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly ALKNDEODKOF KBEILLGFBKH;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float KBKJJKEMEEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3CB6560", Offset = "0x3CB5360", VA = "0x183CB6560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan KDELIGBPFCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3CB66B0", Offset = "0x3CB54B0", VA = "0x183CB66B0")]
		public ALKNDEODKOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct ICABJHJNPGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly TRequest IDLLMGEFFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly CancellationToken KIMBGNGMOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly TaskCompletionSource<TResult> MNALLFLJAJA;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3664260", Offset = "0x3663060", VA = "0x183664260")]
		public ICABJHJNPGN(TRequest IDLLMGEFFMF, TaskCompletionSource<TResult> MNALLFLJAJA, CancellationToken KIMBGNGMOGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CEAKCNFJBOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public CEAKCNFJBOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2372160", Offset = "0x2370F60", VA = "0x182372160")]
		internal void HPLMJOFDGPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class BCOJKBMENEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public JGOBHBHFKIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public BCOJKBMENEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3DE41B0", Offset = "0x3DE2FB0", VA = "0x183DE41B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class EEIEGBKMHDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public JGOBHBHFKIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private ICABJHJNPGN <req>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private Task<TResult> <processTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TResult <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TResult <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private OperationCanceledException <oce>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public EEIEGBKMHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x30C1100", Offset = "0x30BFF00", VA = "0x1830C1100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CancellationTokenSource CPDGIOLAKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<ICABJHJNPGN> IHJGJLAOECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly ALKNDEODKOF PHKMJIIEJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly IALKGBEKBNN NLDKBAJHHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Task ELPCGIMKECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int BENEAMHCKMG;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x347CAB0", Offset = "0x347B8B0", VA = "0x18347CAB0")]
	public JGOBHBHFKIP(IALKGBEKBNN NLDKBAJHHGG, [Optional] ALKNDEODKOF PHKMJIIEJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x347B790", Offset = "0x347A590", VA = "0x18347B790")]
	public Task<TResult> LEFPIIDANBG(TRequest IDLLMGEFFMF, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x347C8E0", Offset = "0x347B6E0", VA = "0x18347C8E0")]
	private void PIJHPIPJMPK(ICABJHJNPGN COPNIMAPJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x347B640", Offset = "0x347A440", VA = "0x18347B640")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGOBHBHFKIP<, >.BCOJKBMENEM))]
	private Task KMBMCIOHLOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x347C160", Offset = "0x347AF60", VA = "0x18347C160")]
	private ICABJHJNPGN LGIHAIGGOBA()
	{
		return default(ICABJHJNPGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x347AF70", Offset = "0x3479D70", VA = "0x18347AF70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JGOBHBHFKIP<, >.EEIEGBKMHDC))]
	private Task BHKKHMALBPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x347C640", Offset = "0x347B440", VA = "0x18347C640")]
	private void LHLNLOCIOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x347B360", Offset = "0x347A160", VA = "0x18347B360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface OKPMFOHOJGO
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface DKBDCACGIOF<T> : OKPMFOHOJGO
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T ODIKHJJHMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool FPPLFAFEPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string EOPNOLGNFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKBDCACGIOF<T> MIMHLJBGJKN(Action<T> OHDMPDJPPKJ);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DKBDCACGIOF<T> HHGKOOENNBP(Action<T> OHDMPDJPPKJ);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DKBDCACGIOF<T> GADBOMIFDOI(Action<T, T> JAEOJKDJNFK);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DKBDCACGIOF<T> FLHEFIEMCJM(Action<T, T> JAEOJKDJNFK);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DKBDCACGIOF<T> EJOGCBMKCNL(Action<string> PHGLCAFGNBP);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DKBDCACGIOF<T> DHLHMHCPONE(Action<string> PHGLCAFGNBP);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class ILFCNKPCBBD<T> : DKBDCACGIOF<T>, OKPMFOHOJGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private JGGFBJAFCNG<T, T> EIJNDIPAKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private ONLGFGHLFCK<T> BKNGNKKAFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private ONLGFGHLFCK<string> BGJKGHOHMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private string JKCLFNEEMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private T IFKOGMJAAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool PIJLAEEOFDH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T ODIKHJJHMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8FD610", Offset = "0x8FC410", VA = "0x1808FD610", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FPPLFAFEPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9D8000", Offset = "0x9D6E00", VA = "0x1809D8000", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string EOPNOLGNFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9086E0", Offset = "0x9074E0", VA = "0x1809086E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x1C22C80", Offset = "0x1C21A80", VA = "0x181C22C80", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D380", Offset = "0x2C3C180", VA = "0x182C3D380")]
	private void LOFJCELKDGG(T GNCDGJDGENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D2D0", Offset = "0x2C3C0D0", VA = "0x182C3D2D0")]
	private void KPGHHCNGPHD(string CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D220", Offset = "0x2C3C020", VA = "0x182C3D220")]
	public void HKOMOLJGOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D180", Offset = "0x2C3BF80", VA = "0x182C3D180", Slot = "6")]
	public DKBDCACGIOF<T> GADBOMIFDOI(Action<T, T> JAEOJKDJNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D130", Offset = "0x2C3BF30", VA = "0x182C3D130", Slot = "7")]
	public DKBDCACGIOF<T> FLHEFIEMCJM(Action<T, T> JAEOJKDJNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D420", Offset = "0x2C3C220", VA = "0x182C3D420", Slot = "4")]
	public DKBDCACGIOF<T> MIMHLJBGJKN(Action<T> JAEOJKDJNFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D1D0", Offset = "0x2C3BFD0", VA = "0x182C3D1D0", Slot = "5")]
	public DKBDCACGIOF<T> HHGKOOENNBP(Action<T> OHDMPDJPPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D090", Offset = "0x2C3BE90", VA = "0x182C3D090", Slot = "8")]
	public DKBDCACGIOF<T> EJOGCBMKCNL(Action<string> PHGLCAFGNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D020", Offset = "0x2C3BE20", VA = "0x182C3D020", Slot = "9")]
	public DKBDCACGIOF<T> DHLHMHCPONE(Action<string> PHGLCAFGNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D4B0", Offset = "0x2C3C2B0", VA = "0x182C3D4B0")]
	public ILFCNKPCBBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GPFIIDHLMPD
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OIMJNNEPMNA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public DKBDCACGIOF<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public EAELMMECBND<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public OIMJNNEPMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4AF1690", Offset = "0x4AF0490", VA = "0x184AF1690")]
		internal void ANGDECEKNKO(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3471D40", Offset = "0x3470B40", VA = "0x183471D40")]
	public static AHPDIJDJLKD<T> HHABJGGFENE<T>(this DKBDCACGIOF<T> JBCOGHOIBBD, Action<T> IIPKIDOCHMK)
	{
		return null;
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3F46540", Offset = "0x3F45340", VA = "0x183F46540")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8300", Offset = "0x6EF7100", VA = "0x186EF8300")]
		public SerializedGuid(in Guid LOOGPKNLJEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F74940", Offset = "0x6F73740", VA = "0x186F74940")]
		public static SerializedGuid CNIHENJJBGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F749D0", Offset = "0x6F737D0", VA = "0x186F749D0")]
		public static SerializedGuid EFKGIJJBFMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F74BF0", Offset = "0x6F739F0", VA = "0x186F74BF0")]
		public bool KDDGCCJAMHP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6EF82D0", Offset = "0x6EF70D0", VA = "0x186EF82D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F74D10", Offset = "0x6F73B10", VA = "0x186F74D10", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F74C80", Offset = "0x6F73A80", VA = "0x186F74C80")]
		public bool OCABIOPIOAG(in Guid LOOGPKNLJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F74A60", Offset = "0x6F73860", VA = "0x186F74A60", Slot = "7")]
		public bool Equals(SerializedGuid FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F74B10", Offset = "0x6F73910", VA = "0x186F74B10", Slot = "0")]
		public override bool Equals(object GNOEFMFMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8220", Offset = "0x6EF7020", VA = "0x186EF8220", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8060", Offset = "0x6EF6E60", VA = "0x186EF8060", Slot = "6")]
		public int CompareTo(SerializedGuid FGBEDAPNDEP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class IGALDKGLJBO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly Type NHFJLOJDEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly string AKDKCCAAAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool GCNJMLHAFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly bool NKJMBIBNBPK;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F71350", Offset = "0x6F70150", VA = "0x186F71350")]
	public IGALDKGLJBO(Type HFDABFJKJCP, string DCLENJNCCKN, bool FIFJPOFJPMI = false, bool NJEOPOMCDAN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DefaultMember("Item")]
public class HPENBCCONIM<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<T> IPGDFFNNILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private HashSet<T> LFPKJINAOPL;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2372160", Offset = "0x2370F60", VA = "0x182372160", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CKPLHALPLKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x81CAB0", Offset = "0x81B8B0", VA = "0x18081CAB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2C4D360", Offset = "0x2C4C160", VA = "0x182C4D360", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9020", Offset = "0x4EA7E20", VA = "0x184EA9020", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x37D4CA0", Offset = "0x37D3AA0", VA = "0x1837D4CA0", Slot = "11")]
	public void Add(T IGAFFKCMBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8910", Offset = "0x4EA7710", VA = "0x184EA8910")]
	public bool CBMPBAPEBLM(T IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8E00", Offset = "0x4EA7C00", VA = "0x184EA8E00", Slot = "15")]
	public bool Remove(T IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x467C880", Offset = "0x467B680", VA = "0x18467C880", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3188B40", Offset = "0x3187940", VA = "0x183188B40", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4EA89B0", Offset = "0x4EA77B0", VA = "0x184EA89B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x348EDF0", Offset = "0x348DBF0", VA = "0x18348EDF0", Slot = "13")]
	public bool Contains(T IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8A10", Offset = "0x4EA7810", VA = "0x184EA8A10", Slot = "14")]
	public void CopyTo(T[] PKPHLPFOPGM, int GIDMKIFNOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x43F9CE0", Offset = "0x43F8AE0", VA = "0x1843F9CE0", Slot = "6")]
	public int IndexOf(T IGAFFKCMBEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8B10", Offset = "0x4EA7910", VA = "0x184EA8B10", Slot = "7")]
	public void Insert(int FHOMILACEHB, T IGAFFKCMBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8CA0", Offset = "0x4EA7AA0", VA = "0x184EA8CA0", Slot = "8")]
	public void RemoveAt(int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8790", Offset = "0x4EA7590", VA = "0x184EA8790")]
	public void AFCEDNLJLHD(Predicate<T> JFKPNAODGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x27D4090", Offset = "0x27D2E90", VA = "0x1827D4090")]
	public void JHFCCAIPKJM(Comparison<T> IKMBOMKGGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8E80", Offset = "0x4EA7C80", VA = "0x184EA8E80")]
	public HPENBCCONIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CNEJHBNPDKG
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E880", Offset = "0x6F6D680", VA = "0x186F6E880")]
	public static Vector3 BALPABEEGAL(this GameObject KKHNMHOFPEF, float HBNLAGLPKIM)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GAEPKFILIBN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Type NHFJLOJDEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly string AKDKCCAAAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool GCNJMLHAFMM;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F680", Offset = "0x6F6E480", VA = "0x186F6F680")]
	public GAEPKFILIBN(Type HFDABFJKJCP, string DCLENJNCCKN, bool FIFJPOFJPMI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GJEGHJAAOGF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F850", Offset = "0x6F6E650", VA = "0x186F6F850")]
	public GJEGHJAAOGF(string CAJMIGKHKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F7D0", Offset = "0x6F6E5D0", VA = "0x186F6F7D0")]
	public GJEGHJAAOGF(string CAJMIGKHKEC, Exception BBLOKKGMIAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class DPFMGMNOCIN
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F1C0", Offset = "0x6F6DFC0", VA = "0x186F6F1C0")]
	[NotNull]
	public static byte[] BOBCPIGDCDO(this BDPJCONNNMD FJJDLHHMDLK, byte[] DMNKIINEALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EF80", Offset = "0x6F6DD80", VA = "0x186F6EF80")]
	[NotNull]
	public static byte[] BOBCPIGDCDO(this BDPJCONNNMD FJJDLHHMDLK, HashAlgorithmName BBCHBCMHECO, byte[] DMNKIINEALL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface BDPJCONNNMD
{
	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash JBJGEACIMDC);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface FHPFOJCGIFK : BDPJCONNNMD
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] LPEJACKFPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[CanBeNull]
	byte[] NOCCADIIHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	UnityEngine.Object EHJLJEGBOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class LHINNGFJJHP
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class OOKBCECFCJM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F72FB0", Offset = "0x6F71DB0", VA = "0x186F72FB0")]
		public OOKBCECFCJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F72F50", Offset = "0x6F71D50", VA = "0x186F72F50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private const byte OMCHEOMIPMC = 1;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const byte KGCDMOIKOHP = 0;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ArrayPool<byte> KADLJPKIHJD;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static bool LONAPDEGODC;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x301BF50", Offset = "0x301AD50", VA = "0x18301BF50")]
	[Conditional("UNITY_EDITOR")]
	private static void EFLKCCDKLDI<T>(params T[] DNNPOKDINFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F71F20", Offset = "0x6F70D20", VA = "0x186F71F20")]
	public static IDisposable GNBMPGGPHCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F72980", Offset = "0x6F71780", VA = "0x186F72980")]
	public static void PJHJEJAJOCK(this IncrementalHash LIKKBBHPEAK, [CanBeNull] GameObject KKHNMHOFPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x301C6A0", Offset = "0x301B4A0", VA = "0x18301C6A0")]
	public static void PJHJEJAJOCK<T>(this IncrementalHash LIKKBBHPEAK, [CanBeNull] T AMMGBKBHPFA) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x301BEC0", Offset = "0x301ACC0", VA = "0x18301BEC0")]
	public static void DPFJBMKCCEM<T>(this IncrementalHash LIKKBBHPEAK, [CanBeNull] T FJJDLHHMDLK) where T : BDPJCONNNMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x301C240", Offset = "0x301B040", VA = "0x18301C240")]
	public static void HAJCFLCBDNJ<T>(this IncrementalHash LIKKBBHPEAK, [CanBeNull] IList<T> BJMBICJAGFP) where T : BDPJCONNNMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F720F0", Offset = "0x6F70EF0", VA = "0x186F720F0")]
	private static bool KPJFGAACGCA([CanBeNull] BDPJCONNNMD FJJDLHHMDLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F72020", Offset = "0x6F70E20", VA = "0x186F72020")]
	public static void KOFIBBGJEFL(this IncrementalHash JBJGEACIMDC, [CanBeNull] string EGDHCOHDMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F72250", Offset = "0x6F71050", VA = "0x186F72250")]
	public static void NMGPALMFMEL(this IncrementalHash JBJGEACIMDC, long PPKOGNPNACA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F727B0", Offset = "0x6F715B0", VA = "0x186F727B0")]
	public static void PJCMMHIGEBN(this IncrementalHash JBJGEACIMDC, int KOLPKJLAKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F72420", Offset = "0x6F71220", VA = "0x186F72420")]
	public static void NNBGDJMFNIK(this IncrementalHash JBJGEACIMDC, short OIHJJEIEMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F71DB0", Offset = "0x6F70BB0", VA = "0x186F71DB0")]
	public static void FEHDJALEKLI(this IncrementalHash JBJGEACIMDC, byte KIBIBCJLMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F71BE0", Offset = "0x6F709E0", VA = "0x186F71BE0")]
	public static void EALPOLMCDGF(this IncrementalHash JBJGEACIMDC, bool OIGEGACCEMM, bool IHHGJKJBCJD = false, bool LOJLMFOKIHL = false, bool NNOEONOMEHF = false, bool HCPMFLCPENC = false, bool EKJGEFIDELK = false, bool CHKEKHKFCBO = false, bool HMIOJLAADHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x301B7D0", Offset = "0x301A5D0", VA = "0x18301B7D0")]
	public static void BDHLFNCCPEF<T>(this IncrementalHash JBJGEACIMDC, T KAPFFDGHCGG) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F721F0", Offset = "0x6F70FF0", VA = "0x186F721F0")]
	public static void NFJOMJCBHOG(this IncrementalHash JBJGEACIMDC, float PNFJHKEHAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F71FC0", Offset = "0x6F70DC0", VA = "0x186F71FC0")]
	public static void KKAFFCFBGHG(this IncrementalHash JBJGEACIMDC, double LNJJHGFDIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F72180", Offset = "0x6F70F80", VA = "0x186F72180")]
	public static void LAJFNNDCDPB(this IncrementalHash JBJGEACIMDC, ulong PGICDFGLKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F72BE0", Offset = "0x6F719E0", VA = "0x186F72BE0")]
	public static void PPBCOCIBFIA(this IncrementalHash JBJGEACIMDC, uint OMHLLJKAMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F72080", Offset = "0x6F70E80", VA = "0x186F72080")]
	public static void KPDKJMKMILA(this IncrementalHash JBJGEACIMDC, ushort ADMNOHNFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F72A70", Offset = "0x6F71870", VA = "0x186F72A70")]
	public static void PLLDFDGOBFJ(this IncrementalHash JBJGEACIMDC, Vector3 BLJCBNGNNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F725F0", Offset = "0x6F713F0", VA = "0x186F725F0")]
	public static void PDBBOMNBEGJ(this IncrementalHash JBJGEACIMDC, Quaternion HMGOECPFMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class KOLODNCBDLM
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F719E0", Offset = "0x6F707E0", VA = "0x186F719E0")]
	[NotNull]
	public static byte[] BOBCPIGDCDO(this FHPFOJCGIFK HJNFABKHDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F71970", Offset = "0x6F70770", VA = "0x186F71970")]
	[NotNull]
	public static byte[] BOBCPIGDCDO(this FHPFOJCGIFK HJNFABKHDAG, HashAlgorithmName BBCHBCMHECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F71640", Offset = "0x6F70440", VA = "0x186F71640")]
	public static bool BDHKLKJHADG([CanBeNull] this FHPFOJCGIFK HJNFABKHDAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F717D0", Offset = "0x6F705D0", VA = "0x186F717D0")]
	public static bool BDHKLKJHADG([CanBeNull] this FHPFOJCGIFK HJNFABKHDAG, out string JKCLFNEEMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F71B70", Offset = "0x6F70970", VA = "0x186F71B70")]
	private static string LHNLDIMKADM([CanBeNull] byte[] KIIAPAPHICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F71A50", Offset = "0x6F70850", VA = "0x186F71A50")]
	private static bool IJKNNOFJDLE([NotNull] FHPFOJCGIFK HJNFABKHDAG, [CanBeNull] out byte[] PGKOGDNBCFE, [CanBeNull] out byte[] JJPHHBAONEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class BHNEHHJBIOP<TTask, T> : GGADDACMMKK<T>, PDJBOIBDJHI, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class ICFHCIIFHPO
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		private sealed class <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public ICFHCIIFHPO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2BAAA00", Offset = "0x2BA9800", VA = "0x182BAAA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public BHNEHHJBIOP<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public ICFHCIIFHPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x36685A0", Offset = "0x36673A0", VA = "0x1836685A0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(BHNEHHJBIOP<, >.ICFHCIIFHPO.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> LLIOMLKKNCE(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static bool NADIPHDNNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Task<T> OGICGLLMMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	protected readonly CancellationTokenSource DHPHKDAADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool BLMLHEIKNME;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Task<T> JGPPEGPPDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Task NPJBNIGJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public AHPDIJDJLKD<T> CFCKFGNBBBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private NONMCJIBNII HKLDOAOFCPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3186F70", Offset = "0x3185D70", VA = "0x183186F70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool CGHLOCINKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9D2F60", Offset = "0x9D1D60", VA = "0x1809D2F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2A90", Offset = "0x3DF1890", VA = "0x183DF2A90")]
	static BHNEHHJBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2DB0", Offset = "0x3DF1BB0", VA = "0x183DF2DB0")]
	protected BHNEHHJBIOP(TTask OGICGLLMMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3DF24D0", Offset = "0x3DF12D0", VA = "0x183DF24D0", Slot = "1")]
	~BHNEHHJBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3DF24A0", Offset = "0x3DF12A0", VA = "0x183DF24A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2540", Offset = "0x3DF1340", VA = "0x183DF2540")]
	private void LLJCJCMKKGD(bool AFLJJGBPDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T MAGANPIOJGP(TTask BOLNGICCEBO);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void NPAPENFHFOD();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MGIIEFKPHNE : MMAIKGGEIOM<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6F72F00", Offset = "0x6F71D00", VA = "0x186F72F00")]
	public MGIIEFKPHNE(Exception PHNKODCCLFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MMAIKGGEIOM<T> : GGADDACMMKK<T>, PDJBOIBDJHI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public Task<T> JGPPEGPPDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private Task NPJBNIGJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1C4E3D0", Offset = "0x1C4D1D0", VA = "0x181C4E3D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public AHPDIJDJLKD<T> CFCKFGNBBBF
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private NONMCJIBNII HKLDOAOFCPF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1C221D0", Offset = "0x1C20FD0", VA = "0x181C221D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x361B630", Offset = "0x361A430", VA = "0x18361B630")]
	public MMAIKGGEIOM(Exception PHNKODCCLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface PDJBOIBDJHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[NotNull]
	Task JGPPEGPPDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[NotNull]
	NONMCJIBNII CFCKFGNBBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface GGADDACMMKK<T> : PDJBOIBDJHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[NotNull]
	new Task<T> JGPPEGPPDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	new AHPDIJDJLKD<T> CFCKFGNBBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PAGHMKEDFIK : KDHODFFJFAH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F73030", Offset = "0x6F71E30", VA = "0x186F73030")]
	public PAGHMKEDFIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class KDHODFFJFAH<T> : GGADDACMMKK<T>, PDJBOIBDJHI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Task<T> JGPPEGPPDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private Task NPJBNIGJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1C4E3D0", Offset = "0x1C4D1D0", VA = "0x181C4E3D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public AHPDIJDJLKD<T> CFCKFGNBBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private NONMCJIBNII HKLDOAOFCPF
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1C221D0", Offset = "0x1C20FD0", VA = "0x181C221D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4191DE0", Offset = "0x4190BE0", VA = "0x184191DE0")]
	public KDHODFFJFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class DHHEIPPNHIN : FDDOEOCLMPL<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class KADEJNLBBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action<DHHEIPPNHIN> callback;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KADEJNLBBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6F71490", Offset = "0x6F70290", VA = "0x186F71490")]
		internal void NMLCIELPJEI(FDDOEOCLMPL<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F6EE30", Offset = "0x6F6DC30", VA = "0x186F6EE30")]
	public DHHEIPPNHIN([Optional] string JEPPNDDOBEI, [Optional] int? EHEANLDPMIG, [Optional] Stopwatch JOLLOICFHBL, [Optional] Action<string, KJPGNMMPELH> JLFKJICPHPF, [Optional] Action<string, KJPGNMMPELH> KIIPNOMFOBF, [Optional] Action<DHHEIPPNHIN> NDJMOKJPBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F6ED50", Offset = "0x6F6DB50", VA = "0x186F6ED50")]
	private static Action<FDDOEOCLMPL<string>> JLBEGNNBLGL(Action<DHHEIPPNHIN> IIPKIDOCHMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class BLLJKJDAEMM<TKey> : POKOHFNIHMH<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class FGHEFPHFDFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public KMJLKDNGMIH keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public FGHEFPHFDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x2A2C930", Offset = "0x2A2B730", VA = "0x182A2C930")]
		internal string FJJACBKLNAG(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDF40", Offset = "0x3CCCD40", VA = "0x183CCDF40", Slot = "5")]
	protected override string IPMIKCNHCPE(FDDOEOCLMPL<TKey> HKGIHMIPOMF, KMJLKDNGMIH HKKIOFHANGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3CCE830", Offset = "0x3CCD630", VA = "0x183CCE830")]
	public BLLJKJDAEMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class MAOPDCLCAAI<TKey> : KHFLGOPGNFD<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate string MJDJMJOKNMP(TKey LGKPJAJAOLI);

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private const int HMGKCNHNAIM = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly string JKMOMOPPIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly double NCNAGIKEHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly bool LNGBKHGJMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly int LNBGOCAACPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly ISet<string> KICKNIJCLLL;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x387B9D0", Offset = "0x387A7D0", VA = "0x18387B9D0")]
	private static string CFDBMBCEMML(TKey LGKPJAJAOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x387C410", Offset = "0x387B210", VA = "0x18387C410")]
	public MAOPDCLCAAI(string JKMOMOPPIGG = "F2", double NCNAGIKEHCD = double.MaxValue, bool LNGBKHGJMGO = false, int LNBGOCAACPP = int.MaxValue, [Optional] ISet<string> KICKNIJCLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x387BC70", Offset = "0x387AA70", VA = "0x18387BC70", Slot = "4")]
	public override Dictionary<string, string> HIJMMJHCMFA(FDDOEOCLMPL<TKey> HKGIHMIPOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x387BA10", Offset = "0x387A810", VA = "0x18387BA10")]
	private bool DJJAGPFKNNA(string ADIELPPAOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x387BD20", Offset = "0x387AB20", VA = "0x18387BD20")]
	public Dictionary<string, string> HIJMMJHCMFA(FDDOEOCLMPL<TKey> HKGIHMIPOMF, MJDJMJOKNMP HKKIOFHANGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x387C260", Offset = "0x387B060", VA = "0x18387C260")]
	private string JGLILNJFLCK(StringBuilder HPMCCNGIEHJ, List<TKey> FHONPJMHNMO, MJDJMJOKNMP HKKIOFHANGB, bool GMNLLFGHNBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x387BAF0", Offset = "0x387A8F0", VA = "0x18387BAF0")]
	private static void DPAIPNJEJPD(StringBuilder GDMNBENOFOM, string ONCMDGGGNFH, bool HKNFMDCEGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class KHFLGOPGNFD<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut HIJMMJHCMFA(FDDOEOCLMPL<TKey> HKGIHMIPOMF);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
	protected KHFLGOPGNFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class POKOHFNIHMH<TKey> : KHFLGOPGNFD<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public delegate string KMJLKDNGMIH(TKey LGKPJAJAOLI);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x511CF80", Offset = "0x511BD80", VA = "0x18511CF80")]
	protected string GBNFBGMICPH(double COFFIFDDEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x511D1D0", Offset = "0x511BFD0", VA = "0x18511D1D0")]
	protected string KJEICGBPPIJ(int KNGACPIPMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x511CF40", Offset = "0x511BD40", VA = "0x18511CF40")]
	private static string CFDBMBCEMML(TKey LGKPJAJAOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x511CFF0", Offset = "0x511BDF0", VA = "0x18511CFF0", Slot = "4")]
	public override string HIJMMJHCMFA(FDDOEOCLMPL<TKey> HKGIHMIPOMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x511D0A0", Offset = "0x511BEA0", VA = "0x18511D0A0")]
	public string HIJMMJHCMFA(FDDOEOCLMPL<TKey> HKGIHMIPOMF, [NotNull] KMJLKDNGMIH HKKIOFHANGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string IPMIKCNHCPE(FDDOEOCLMPL<TKey> HKGIHMIPOMF, [NotNull] KMJLKDNGMIH HKKIOFHANGB);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x35F8AB0", Offset = "0x35F78B0", VA = "0x1835F8AB0")]
	protected POKOHFNIHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class EJMODHFKBMH
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class MEOFMBELKLO : EJMODHFKBMH
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static EJMODHFKBMH LNABDBHCENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6F72DA0", Offset = "0x6F71BA0", VA = "0x186F72DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override DateTime FIFIDFHNOCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x6F72D50", Offset = "0x6F71B50", VA = "0x186F72D50", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override float HEPJNOJOPGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x1943CB0", Offset = "0x1942AB0", VA = "0x181943CB0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6F72EA0", Offset = "0x6F71CA0", VA = "0x186F72EA0")]
		public MEOFMBELKLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static EJMODHFKBMH CIMKAPCBPKA;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static EJMODHFKBMH KBEILLGFBKH
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F2B0", Offset = "0x6F6E0B0", VA = "0x186F6F2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public abstract DateTime FIFIDFHNOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public abstract float HEPJNOJOPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	protected EJMODHFKBMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class PCAHJJFOBOD<TKey> : POKOHFNIHMH<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct NKIKJKEOKIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public KMJLKDNGMIH keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static PCAHJJFOBOD<TKey> LNABDBHCENK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private const int KGGLMLJAOAB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly string[] KBGPFKNGLCL;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x35EC7E0", Offset = "0x35EB5E0", VA = "0x1835EC7E0")]
	private PCAHJJFOBOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x35EB710", Offset = "0x35EA510", VA = "0x1835EB710", Slot = "5")]
	protected override string IPMIKCNHCPE(FDDOEOCLMPL<TKey> HKGIHMIPOMF, KMJLKDNGMIH HKKIOFHANGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x35EC5F0", Offset = "0x35EB3F0", VA = "0x1835EC5F0")]
	[CompilerGenerated]
	internal static string OFDBFHDKBGN(string IEMOMMLMHFL, TKey LGKPJAJAOLI, ref NKIKJKEOKIK P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class FDDOEOCLMPL<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public readonly struct KJPGNMMPELH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly long LKHIFNHNLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly long EMMKDHBDDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly int EHEANLDPMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly int OJHNPJGEGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly bool BDFDIDAAHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly string KFHHFJPBGEJ;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x44AB600", Offset = "0x44AA400", VA = "0x1844AB600")]
		public KJPGNMMPELH(long LKHIFNHNLJC, int EHEANLDPMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x44AB5D0", Offset = "0x44AA3D0", VA = "0x1844AB5D0")]
		public KJPGNMMPELH(long LKHIFNHNLJC, long EMMKDHBDDGN, int EHEANLDPMIG, int OJHNPJGEGAK, bool BDFDIDAAHFO, string KFHHFJPBGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x44AB3B0", Offset = "0x44AA1B0", VA = "0x1844AB3B0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void BFGMMOKBLNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x44AB560", Offset = "0x44AA360", VA = "0x1844AB560")]
		public int OIFNPNGGPLO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x44AB5B0", Offset = "0x44AA3B0", VA = "0x1844AB5B0")]
		public int OMOICJANAJG(int OEHCAGHLDHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x44AB430", Offset = "0x44AA230", VA = "0x1844AB430")]
		public double BPJACFKJGEM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x44AB4A0", Offset = "0x44AA2A0", VA = "0x1844AB4A0")]
		public KJPGNMMPELH ECAFKIHEFGB(long EMMKDHBDDGN, int OJHNPJGEGAK)
		{
			return default(KJPGNMMPELH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class JCNILKDNLCM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class BPKOKJIIBED<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public Func<JCNILKDNLCM, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public JCNILKDNLCM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private JCNILKDNLCM <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
			public BPKOKJIIBED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x33F7810", Offset = "0x33F6610", VA = "0x1833F7810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly TKey JIFALOFFGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly FDDOEOCLMPL<TKey> HKGIHMIPOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private List<JCNILKDNLCM> KADPJKIBFGC;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string MFMIFMGNDBE
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x27CF350", Offset = "0x27CE150", VA = "0x1827CF350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x318DF70", Offset = "0x318CD70", VA = "0x18318DF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEnumerable<JCNILKDNLCM> JPOCNGPAMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x318DFA0", Offset = "0x318CDA0", VA = "0x18318DFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public KJPGNMMPELH DIJOKIIKJBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2387EC0", Offset = "0x2386CC0", VA = "0x182387EC0")]
			[CompilerGenerated]
			get
			{
				return default(KJPGNMMPELH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x318DD50", Offset = "0x318CB50", VA = "0x18318DD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x318DFC0", Offset = "0x318CDC0", VA = "0x18318DFC0")]
		internal JCNILKDNLCM(FDDOEOCLMPL<TKey> HKGIHMIPOMF, TKey LGKPJAJAOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x318DD80", Offset = "0x318CB80", VA = "0x18318DD80")]
		public JCNILKDNLCM HCPDNOMMHOP(TKey LGKPJAJAOLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x318DE90", Offset = "0x318CC90", VA = "0x18318DE90")]
		public void JLBEGNNBLGL(TKey LGKPJAJAOLI, Action<JCNILKDNLCM> EHPEOJCHKEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E200", Offset = "0x2A9D000", VA = "0x182A9E200")]
		public T JLBEGNNBLGL<T>(TKey LGKPJAJAOLI, Func<JCNILKDNLCM, T> KKHBGBDKDEI)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E040", Offset = "0x2A9CE40", VA = "0x182A9E040")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(BPKOKJIIBED<>))]
		public Task<T> FMDIOLNNCHJ<T>(TKey LGKPJAJAOLI, Func<JCNILKDNLCM, Task<T>> KKHBGBDKDEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x318DBA0", Offset = "0x318C9A0", VA = "0x18318DBA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class KLEELAEINBJ : IEnumerable<(TKey, List<TKey>, KJPGNMMPELH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KJPGNMMPELH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private (TKey key, List<TKey> path, KJPGNMMPELH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public FDDOEOCLMPL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private IEnumerator<(TKey key, List<TKey> path, KJPGNMMPELH timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private (TKey key, List<TKey> path, KJPGNMMPELH timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private (TKey, List<TKey>, KJPGNMMPELH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x3B26010", Offset = "0x3B24E10", VA = "0x183B26010", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KJPGNMMPELH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x44AD3C0", Offset = "0x44AC1C0", VA = "0x1844AD3C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3B261A0", Offset = "0x3B24FA0", VA = "0x183B261A0")]
		[DebuggerHidden]
		public KLEELAEINBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2A2A010", Offset = "0x2A28E10", VA = "0x182A2A010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x44ACF90", Offset = "0x44ABD90", VA = "0x1844ACF90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x44ACF40", Offset = "0x44ABD40", VA = "0x1844ACF40")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x44AD380", Offset = "0x44AC180", VA = "0x1844AD380", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x44AD2C0", Offset = "0x44AC0C0", VA = "0x1844AD2C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KJPGNMMPELH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x3CEF5D0", Offset = "0x3CEE3D0", VA = "0x183CEF5D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class CIEKNKPHJJN : IEnumerable<(TKey, List<TKey>, KJPGNMMPELH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KJPGNMMPELH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private (TKey key, List<TKey> path, KJPGNMMPELH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private JCNILKDNLCM timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JCNILKDNLCM <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FDDOEOCLMPL<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private IEnumerator<JCNILKDNLCM> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private JCNILKDNLCM <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private IEnumerator<(TKey key, List<TKey> path, KJPGNMMPELH timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private (TKey key, List<TKey> path, KJPGNMMPELH timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private (TKey, List<TKey>, KJPGNMMPELH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x3B26010", Offset = "0x3B24E10", VA = "0x183B26010", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KJPGNMMPELH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x3B260B0", Offset = "0x3B24EB0", VA = "0x183B260B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x3B261A0", Offset = "0x3B24FA0", VA = "0x183B261A0")]
		[DebuggerHidden]
		public CIEKNKPHJJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x3B26110", Offset = "0x3B24F10", VA = "0x183B26110", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x3B25910", Offset = "0x3B24710", VA = "0x183B25910", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x3B258B0", Offset = "0x3B246B0", VA = "0x183B258B0")]
		private void KJLKGHHLDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x3B25850", Offset = "0x3B24650", VA = "0x183B25850")]
		private void HMDILAAEAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x3B26070", Offset = "0x3B24E70", VA = "0x183B26070", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x3B25F30", Offset = "0x3B24D30", VA = "0x183B25F30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KJPGNMMPELH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x3B26040", Offset = "0x3B24E40", VA = "0x183B26040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<TKey, KJPGNMMPELH> JLFKJICPHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly Action<TKey, KJPGNMMPELH> KIIPNOMFOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Action<FDDOEOCLMPL<TKey>> NDJMOKJPBLD;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const string MAMAADPHMFI = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly JCNILKDNLCM BLLCMPKBIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool BLMLHEIKNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int PFFJBGFKEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Stopwatch JOLLOICFHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly int MDPPDPGBMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private string FBMJEOKNFHL;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public JCNILKDNLCM JBKGGDPMEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	public string MFMIFMGNDBE
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x27DCB90", Offset = "0x27DB990", VA = "0x1827DCB90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public long OCBHOPAAONA
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x27DCB70", Offset = "0x27DB970", VA = "0x1827DCB70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int JNNLCINALLC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x27DCA90", Offset = "0x27DB890", VA = "0x1827DCA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x27DCD70", Offset = "0x27DBB70", VA = "0x1827DCD70")]
	public FDDOEOCLMPL(TKey EMKNKNPIDNC, [Optional] int? EHEANLDPMIG, [Optional][CanBeNull] Stopwatch JOLLOICFHBL, [Optional] Action<TKey, KJPGNMMPELH> JLFKJICPHPF, [Optional] Action<TKey, KJPGNMMPELH> KIIPNOMFOBF, [Optional] Action<FDDOEOCLMPL<TKey>> NDJMOKJPBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x27DCAE0", Offset = "0x27DB8E0", VA = "0x1827DCAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x27DCD50", Offset = "0x27DBB50", VA = "0x1827DCD50")]
	public void PEMLLALPCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x27DCAC0", Offset = "0x27DB8C0", VA = "0x1827DCAC0")]
	public void COFOKNFMCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x27DCBF0", Offset = "0x27DB9F0", VA = "0x1827DCBF0")]
	[IteratorStateMachine(typeof(FDDOEOCLMPL<>.KLEELAEINBJ))]
	public IEnumerable<(TKey, List<TKey>, KJPGNMMPELH)> MMNOHDAJFFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x27DCC80", Offset = "0x27DBA80", VA = "0x1827DCC80")]
	[IteratorStateMachine(typeof(FDDOEOCLMPL<>.CIEKNKPHJJN))]
	private IEnumerable<(TKey, List<TKey>, KJPGNMMPELH)> MMNOHDAJFFH(List<TKey> EMNEBALMLGH, JCNILKDNLCM BLHBBFGDNBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x27DCA10", Offset = "0x27DB810", VA = "0x1827DCA10")]
	private (long, int) ABAAABMOBIA()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class HBFEDCLPEEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Dictionary<byte, AIEDBKMKAII> IPOMEMGLBPH;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public AIEDBKMKAII CIHPNJAFFDA
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 HCFHNLDLDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x149B390", Offset = "0x149A190", VA = "0x18149B390")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x97C580", Offset = "0x97B380", VA = "0x18097C580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 ABAGMHDPKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x30B9270", Offset = "0x30B8070", VA = "0x1830B9270")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x91A160", Offset = "0x918F60", VA = "0x18091A160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 LLNGCCNAGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6F70ED0", Offset = "0x6F6FCD0", VA = "0x186F70ED0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x916A40", Offset = "0x915840", VA = "0x180916A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int KFPFFDNOAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x91A270", Offset = "0x919070", VA = "0x18091A270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x958740", Offset = "0x957540", VA = "0x180958740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F70EF0", Offset = "0x6F6FCF0", VA = "0x186F70EF0")]
	public HBFEDCLPEEF(Bounds ECBDFJEKPDF, Vector2[] DMHHKODCODC, int JJFAFHENNHB, byte DIDHGEABMII, float KPGBKEJJGOI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F707F0", Offset = "0x6F6F5F0", VA = "0x186F707F0")]
	public AIEDBKMKAII ADLLGIACGPG(byte FHOMILACEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F70850", Offset = "0x6F6F650", VA = "0x186F70850")]
	public void AFNKFENNPOK(Vector3 IHHJAKDKGPC, float HGMAPCFNAND, float NEOMBINPFHM, ref List<byte> FFJBHEHPNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F70950", Offset = "0x6F6F750", VA = "0x186F70950")]
	public void COKIBFDBHDB(AIEDBKMKAII.BBGPFKLPAAO PJBBDPLJHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6F70D70", Offset = "0x6F6FB70", VA = "0x186F70D70")]
	private AIEDBKMKAII IILAIPAGEFO(byte FHOMILACEHB, AIEDBKMKAII.MGECFJKONAB BNDMHDIOOAF, AIEDBKMKAII GMBPOBACJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6F70970", Offset = "0x6F6F770", VA = "0x186F70970")]
	private void ELCODHNLOGF(AIEDBKMKAII GMBPOBACJJI, Vector2[] DMHHKODCODC, int FNFNOPDDIJO, int APGBDGJCBFM, int CCHPBFGCHGI, int EEFHBAPDLML, float KPGBKEJJGOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class AIEDBKMKAII
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum MGECFJKONAB
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum BBGPFKLPAAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte JMLLMANMBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 NDDDPDHHGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3 MEOPDGLHJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3 BEIGANPLDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 JEFIOKMNOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public MGECFJKONAB NNAKEGPHCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public AIEDBKMKAII ELDFLCOHEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public List<AIEDBKMKAII> KLBLJBLMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool APOPGNDAKEA;

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E6A0", Offset = "0x6F6D4A0", VA = "0x186F6E6A0")]
	public AIEDBKMKAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E6C0", Offset = "0x6F6D4C0", VA = "0x186F6E6C0")]
	public AIEDBKMKAII(byte PJCEAFJNLLG, MGECFJKONAB BNDMHDIOOAF, AIEDBKMKAII GMBPOBACJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E540", Offset = "0x6F6D340", VA = "0x186F6E540")]
	public void JGLPKFEFEPD(AIEDBKMKAII IBGFFODDGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public void COKIBFDBHDB(int MCOOMMGODMG, BBGPFKLPAAO PJBBDPLJHPC, int MPNGFHGKNMP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E300", Offset = "0x6F6D100", VA = "0x186F6E300")]
	public void AFNKFENNPOK(List<byte> FFJBHEHPNBE, Vector3 IHHJAKDKGPC, float HGMAPCFNAND, float NEOMBINPFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E600", Offset = "0x6F6D400", VA = "0x186F6E600")]
	public bool LELLLJKCAOD(Vector3 PICIOEJJELN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F6E660", Offset = "0x6F6D460", VA = "0x186F6E660")]
	public bool MMPBDGOHMCC(Vector3 PICIOEJJELN, float ODLEHLHKEAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class NCGOPHHHCBF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly Stack<T> OGJPKAMOCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<T> LGKLCLMHLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly int ODEHLNDMLBL;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int CFJAKHIGGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x27CF350", Offset = "0x27CE150", VA = "0x1827CF350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int LCNOAEFKPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2C52630", Offset = "0x2C51430", VA = "0x182C52630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x38A6540", Offset = "0x38A5340", VA = "0x1838A6540")]
	public static NCGOPHHHCBF<T> GBKJHFIHHAE(int OFPPAGPDNCI = 0, int ODEHLNDMLBL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x38A6760", Offset = "0x38A5560", VA = "0x1838A6760")]
	public static NCGOPHHHCBF<T> MGKODGJAMED(int OFPPAGPDNCI = 0, int ODEHLNDMLBL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x38A6A10", Offset = "0x38A5810", VA = "0x1838A6A10")]
	public NCGOPHHHCBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x38A6A50", Offset = "0x38A5850", VA = "0x1838A6A50")]
	public NCGOPHHHCBF(int OFPPAGPDNCI, int ODEHLNDMLBL = int.MaxValue, bool KEFBFMCOAGJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x38A6900", Offset = "0x38A5700", VA = "0x1838A6900")]
	public T NCFDFHPKNJJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x38A66C0", Offset = "0x38A54C0", VA = "0x1838A66C0")]
	public void IEDCBLOCEND(T KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x38A6830", Offset = "0x38A5630", VA = "0x1838A6830")]
	private void MHJFOKNANPK(T KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x38A6610", Offset = "0x38A5410", VA = "0x1838A6610")]
	private void GFGCDAKPFKE(T KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x38A6230", Offset = "0x38A5030", VA = "0x1838A6230")]
	[Conditional("DEBUG_BUILD")]
	private void AFAAEDJDEKF(T DMAJMJFGPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x38A6630", Offset = "0x38A5430", VA = "0x1838A6630")]
	[Conditional("DEBUG_BUILD")]
	private void GLJPACPNOJD(T DMAJMJFGPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x38A6450", Offset = "0x38A5250", VA = "0x1838A6450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x38A62B0", Offset = "0x38A50B0", VA = "0x1838A62B0")]
	private void AIFENKIMFOJ(IEnumerable<T> PFPIGLEBEEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class HADPLKJCBAG
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private enum MACDFBALBEM : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private int JBJGEACIMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private bool LJEHPOCLHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private MACDFBALBEM BKDHMCPKLPF;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool GLDKKHCFJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F6FD90", Offset = "0x6F6EB90", VA = "0x186F6FD90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool ELIFLKABBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F930", Offset = "0x6F6E730", VA = "0x186F6F930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F707B0", Offset = "0x6F6F5B0", VA = "0x186F707B0")]
	public HADPLKJCBAG(bool LJEHPOCLHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FF60", Offset = "0x6F6ED60", VA = "0x186F6FF60")]
	public void FCDPJHHLFCF(object GNOEFMFMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FCB0", Offset = "0x6F6EAB0", VA = "0x186F6FCB0")]
	public void BMNLONNIBLE(int KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F707A0", Offset = "0x6F6F5A0", VA = "0x186F707A0")]
	public void NPOOAGOBLDD(uint CILCGDJCJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F706A0", Offset = "0x6F6F4A0", VA = "0x186F706A0")]
	public void LEOCGFIGAKA(bool AIGFJALNKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F705E0", Offset = "0x6F6F3E0", VA = "0x186F705E0")]
	public void ILEKEOGEAOA(long EPAGDECBPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FD50", Offset = "0x6F6EB50", VA = "0x186F6FD50")]
	public void COAMPKMCOAL(ulong AEGAGBHKMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F70620", Offset = "0x6F6F420", VA = "0x186F70620")]
	public void JNGBNCJACFA(string PAAKDHAMJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FED0", Offset = "0x6F6ECD0", VA = "0x186F6FED0")]
	public void EFAADKMMMJM(Enum PHNKODCCLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F6FDA0", Offset = "0x6F6EBA0", VA = "0x186F6FDA0")]
	public void EBJNFEICJDD(IList IPGDFFNNILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3473F90", Offset = "0x3472D90", VA = "0x183473F90")]
	public void DLGNGICGACB<T, U>(Dictionary<T, U> ANMNCLLFFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F940", Offset = "0x6F6E740", VA = "0x186F6F940")]
	private void BDLNLBMJCBK(IDictionary ANMNCLLFFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F8C0", Offset = "0x6F6E6C0", VA = "0x186F6F8C0")]
	public int AAIKLMKGJPC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F706C0", Offset = "0x6F6F4C0", VA = "0x186F706C0")]
	public short LKLMLKMKHNO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F70690", Offset = "0x6F6F490", VA = "0x186F70690")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F70730", Offset = "0x6F6F530", VA = "0x186F70730")]
	private void NALGBBKKBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface HCBOLGEPJOM
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class ResourcePrefabReference<T> : HCBOLGEPJOM where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x3864750", Offset = "0x3863550", VA = "0x183864750", Slot = "4")]
		public virtual T HFLOABEPDEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class GBHACGAOKCI<T> : IEnumerable<GBHACGAOKCI<T>.NGJPBLACNBN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public struct NGJPBLACNBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public T KKLNCEHOHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int FHOMILACEHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class CINGCFDJCAD : IEnumerator<NGJPBLACNBN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private GBHACGAOKCI<T> BFOFBGJCGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private int FHOMILACEHB;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x1C19990", Offset = "0x1C18790", VA = "0x181C19990", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public NGJPBLACNBN CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x3B27090", Offset = "0x3B25E90", VA = "0x183B27090", Slot = "4")]
			get
			{
				return default(NGJPBLACNBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x91F760", Offset = "0x91E560", VA = "0x18091F760")]
		public CINGCFDJCAD(GBHACGAOKCI<T> BFOFBGJCGFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x3B27010", Offset = "0x3B25E10", VA = "0x183B27010", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x91F750", Offset = "0x91E550", VA = "0x18091F750", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x12E8170", Offset = "0x12E6F70", VA = "0x1812E8170", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private struct AAIGAHBLDHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public bool FBEJNKINNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public T KKLNCEHOHED;
	}

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private const int EONAIJMFEOF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Dictionary<T, int> OMHAOMIPLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private AAIGAHBLDHM[] KODPOPAEAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int AOEFCNEOBFC;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int NMKDLBGCGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x93BE30", Offset = "0x93AC30", VA = "0x18093BE30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x952E20", Offset = "0x951C20", VA = "0x180952E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x2372160", Offset = "0x2370F60", VA = "0x182372160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x393B090", Offset = "0x3939E90", VA = "0x18393B090")]
	public GBHACGAOKCI(int OFPPAGPDNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x393B160", Offset = "0x3939F60", VA = "0x18393B160")]
	public GBHACGAOKCI(NGJPBLACNBN[] NDIIJFKNOMA, bool HJLHFAFCFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x393A7D0", Offset = "0x39395D0", VA = "0x18393A7D0")]
	public int MPNCMCLKEIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3939800", Offset = "0x3938600", VA = "0x183939800")]
	private int ABHAMCLKFAA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x393A700", Offset = "0x3939500", VA = "0x18393A700", Slot = "6")]
	protected virtual uint JFIHADKLCMK(uint JBJGEACIMDC, T KKLNCEHOHED)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x393ABD0", Offset = "0x39399D0", VA = "0x18393ABD0")]
	public bool PHJGANFKIDM(T KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x393A240", Offset = "0x3939040", VA = "0x18393A240")]
	public bool GGAEHEIKDMC(int FHOMILACEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x3939CA0", Offset = "0x3938AA0", VA = "0x183939CA0")]
	public bool BBJPLADBJND(Func<T, bool> FAMINLNBNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x393AA60", Offset = "0x3939860", VA = "0x18393AA60")]
	public int OAMKDBMPPAM(T KKLNCEHOHED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x393A380", Offset = "0x3939180", VA = "0x18393A380")]
	public T HHABJGGFENE(int FHOMILACEHB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x393A750", Offset = "0x3939550", VA = "0x18393A750")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x3939F80", Offset = "0x3938D80", VA = "0x183939F80")]
	public bool CBMPBAPEBLM(T KKLNCEHOHED, bool NADOAHJICKJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x3939FF0", Offset = "0x3938DF0", VA = "0x183939FF0")]
	public bool CBMPBAPEBLM(T KKLNCEHOHED, int FHOMILACEHB, bool NADOAHJICKJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x393AAC0", Offset = "0x39398C0", VA = "0x18393AAC0")]
	public bool OIPPMFBKPAM(T KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x393A1F0", Offset = "0x3938FF0", VA = "0x18393A1F0")]
	public bool FOPGPDPHJCG(int FHOMILACEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x393A840", Offset = "0x3939640", VA = "0x18393A840")]
	private void NHFPLJELIBF(int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x393A450", Offset = "0x3939250", VA = "0x18393A450")]
	public NGJPBLACNBN[] HOFIGAGGNKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x393A330", Offset = "0x3939130", VA = "0x18393A330")]
	private int GHFJHOJIHFO(int DIDHGEABMII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x393AC10", Offset = "0x3939A10", VA = "0x18393AC10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x393AC10", Offset = "0x3939A10", VA = "0x18393AC10", Slot = "4")]
	private IEnumerator<NGJPBLACNBN> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		[CAILPCABGNE(PNNHMCGEKHG.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x6F735D0", Offset = "0x6F723D0", VA = "0x186F735D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x6F73860", Offset = "0x6F72660", VA = "0x186F73860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x6F73790", Offset = "0x6F72590", VA = "0x186F73790")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x6F739C0", Offset = "0x6F727C0", VA = "0x186F739C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F73540", Offset = "0x6F72340", VA = "0x186F73540")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x6F737D0", Offset = "0x6F725D0", VA = "0x186F737D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x6F73700", Offset = "0x6F72500", VA = "0x186F73700")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F734E0", Offset = "0x6F722E0", VA = "0x186F734E0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class DFPHHHDGMLF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int OFPPAGPDNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int EJLFPKKLGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private List<T> BAHBPPHMFLI;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x27CF350", Offset = "0x27CE150", VA = "0x1827CF350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T DMFLBEPFMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE1B0", Offset = "0x2ACCFB0", VA = "0x182ACE1B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T LPPBKNOEFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE240", Offset = "0x2ACD040", VA = "0x182ACE240")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T AHFIGBFIFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2ACE490", Offset = "0x2ACD290", VA = "0x182ACE490")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE620", Offset = "0x2ACD420", VA = "0x182ACE620")]
	public DFPHHHDGMLF(int OFPPAGPDNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE2E0", Offset = "0x2ACD0E0", VA = "0x182ACE2E0")]
	public void IMFFJGIMDFG(T BDGIOBBFLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE540", Offset = "0x2ACD340", VA = "0x182ACE540")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE580", Offset = "0x2ACD380", VA = "0x182ACE580")]
	public void PHMBHFKFMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE0D0", Offset = "0x2ACCED0", VA = "0x182ACE0D0")]
	public void BOHFAPLAMND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE120", Offset = "0x2ACCF20", VA = "0x182ACE120")]
	public void EGIONFMMMOJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public struct NAGNFLAMEJN<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private readonly List<Component> IPGDFFNNILJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private readonly bool JMAEPDOIGIO;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xD21EF0", Offset = "0xD20CF0", VA = "0x180D21EF0")]
			public NAGNFLAMEJN(List<Component> IPGDFFNNILJ, bool JMAEPDOIGIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x3896900", Offset = "0x3895700", VA = "0x183896900")]
			public JKOBEHNBALF<T> JOJADCJMMBH()
			{
				return default(JKOBEHNBALF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x3896970", Offset = "0x3895770", VA = "0x183896970", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x3896970", Offset = "0x3895770", VA = "0x183896970", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct JKOBEHNBALF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private readonly List<Component> IPGDFFNNILJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private readonly bool JMAEPDOIGIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private int FHOMILACEHB;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public T CFKFFOLONBC
			{
				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x3492910", Offset = "0x3491710", VA = "0x183492910", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x34928A0", Offset = "0x34916A0", VA = "0x1834928A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x34928E0", Offset = "0x34916E0", VA = "0x1834928E0")]
			public JKOBEHNBALF(List<Component> IPGDFFNNILJ, bool JMAEPDOIGIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x34927C0", Offset = "0x34915C0", VA = "0x1834927C0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x34927D0", Offset = "0x34915D0", VA = "0x1834927D0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x3492890", Offset = "0x3491690", VA = "0x183492890", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x6F75660", Offset = "0x6F74460", VA = "0x186F75660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F75620", Offset = "0x6F74420", VA = "0x186F75620")]
		public ToolHierarchyCache(GameObject CJDEFKBLNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F75020", Offset = "0x6F73E20", VA = "0x186F75020")]
		private void HFKECJNCAPE(GameObject CJDEFKBLNIP, bool CONMELFNDPK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F74F90", Offset = "0x6F73D90", VA = "0x186F74F90")]
		public static void HFKECJNCAPE(GameObject CJDEFKBLNIP, ref ToolHierarchyCache NDOKNNIIGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F74E80", Offset = "0x6F73C80", VA = "0x186F74E80")]
		public void DMPIGBLFNJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F75200", Offset = "0x6F74000", VA = "0x186F75200")]
		public void LKGDBJBDCMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x4A3F6E0", Offset = "0x4A3E4E0", VA = "0x184A3F6E0")]
		public void DHCLHHGBDGI<T>(Action<T> EHPEOJCHKEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F74DB0", Offset = "0x6F73BB0", VA = "0x186F74DB0")]
		public Component CJLGFBFJMJH(Type LKLFHGBOOLP, bool JMAEPDOIGIO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x4A3F660", Offset = "0x4A3E460", VA = "0x184A3F660")]
		public T CJLGFBFJMJH<T>(bool JMAEPDOIGIO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F75180", Offset = "0x6F73F80", VA = "0x186F75180")]
		public NAGNFLAMEJN<Component> LBCKGGKIJPK(Type LKLFHGBOOLP, bool JMAEPDOIGIO = false)
		{
			return default(NAGNFLAMEJN<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x4A3F970", Offset = "0x4A3E770", VA = "0x184A3F970")]
		public NAGNFLAMEJN<T> LBCKGGKIJPK<T>(bool JMAEPDOIGIO = false) where T : class
		{
			return default(NAGNFLAMEJN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F75250", Offset = "0x6F74050", VA = "0x186F75250")]
		public List<Component> NAPFIFIMBIL(Type LKLFHGBOOLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F74E90", Offset = "0x6F73C90", VA = "0x186F74E90", Slot = "4")]
		public bool Equals(ToolHierarchyCache ELAKNHNBHMF, ToolHierarchyCache MNMNIIAFFPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F74F10", Offset = "0x6F73D10", VA = "0x186F74F10", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GNOEFMFMEOO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class OLPPIMELNNA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Dictionary<int, T> FCBFEOILBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private T DGFPJGMHCBO;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public virtual T BCECJEMCJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7F6290", Offset = "0x7F5090", VA = "0x1807F6290", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool AILEMGAHGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4AFB060", Offset = "0x4AF9E60", VA = "0x184AFB060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB000", Offset = "0x4AF9E00", VA = "0x184AFB000")]
	public bool IPOHJHICNJK(T KKLNCEHOHED, int IOLDIKGMLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2C3A200", Offset = "0x2C39000", VA = "0x182C3A200")]
	public bool KKLBNNBEHJB(int IOLDIKGMLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x4AFAB90", Offset = "0x4AF9990", VA = "0x184AFAB90")]
	public T EDANJHPFAOL(int NFLODBCOHFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB0A0", Offset = "0x4AF9EA0", VA = "0x184AFB0A0")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB240", Offset = "0x4AFA040", VA = "0x184AFB240")]
	private bool PPDGJDIPCBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB100", Offset = "0x4AF9F00", VA = "0x184AFB100")]
	public bool NENMDMPJEFC(int IOLDIKGMLCK, out T KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB2D0", Offset = "0x4AFA0D0", VA = "0x184AFB2D0")]
	public OLPPIMELNNA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7F1060", Offset = "0x7EFE60", VA = "0x1807F1060")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x838BE0", Offset = "0x8379E0", VA = "0x180838BE0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public T this[int EFGAFPEAGGO, int BEAKPHPNBOP]
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x43CEC90", Offset = "0x43CDA90", VA = "0x1843CEC90")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x43CED30", Offset = "0x43CDB30", VA = "0x1843CED30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x43CEC00", Offset = "0x43CDA00", VA = "0x1843CEC00")]
		public Array2D(uint OAIIPMIIANM, uint JGPNGKDAHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x43CEB80", Offset = "0x43CD980", VA = "0x1843CEB80")]
		public void LEKENBMMMEI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E720", Offset = "0x6F6D520", VA = "0x186F6E720")]
		public Array2DVector3(uint OAIIPMIIANM, uint JGPNGKDAHKB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class IJCFDEIKFGA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	internal class OLMGEOJBIJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public TNode FEEMIHFJMDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TNode GMBPOBACJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public EPFENAMPHDJ GHIJFOFIFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public List<EPFENAMPHDJ> BOBJJAAGFHB;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public OLMGEOJBIJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	internal struct EPFENAMPHDJ : IComparable<EPFENAMPHDJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int IOLDIKGMLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public TClaimant PJFJMOJFAMF;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9460E0", Offset = "0x944EE0", VA = "0x1809460E0")]
		public EPFENAMPHDJ(int IOLDIKGMLCK, TClaimant PJFJMOJFAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2372D10", Offset = "0x2371B10", VA = "0x182372D10")]
		public bool PLGKPGBBMMG(in EPFENAMPHDJ FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2372CF0", Offset = "0x2371AF0", VA = "0x182372CF0")]
		public bool AMLBJNCHHOB(in EPFENAMPHDJ FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2372D00", Offset = "0x2371B00", VA = "0x182372D00", Slot = "4")]
		public int CompareTo(EPFENAMPHDJ FGBEDAPNDEP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2372D70", Offset = "0x2371B70", VA = "0x182372D70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum PHKCGFLEKGO
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class EAOKLPGKLIO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public IJCFDEIKFGA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC38C0", Offset = "0x2AC26C0", VA = "0x182AC38C0")]
		[DebuggerHidden]
		public EAOKLPGKLIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x3446DF0", Offset = "0x3445BF0", VA = "0x183446DF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x3446FB0", Offset = "0x3445DB0", VA = "0x183446FB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x3446ED0", Offset = "0x3445CD0", VA = "0x183446ED0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2A2C5A0", Offset = "0x2A2B3A0", VA = "0x182A2C5A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly NCGOPHHHCBF<OLMGEOJBIJF> DMGFDKKABOM;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly NCGOPHHHCBF<List<EPFENAMPHDJ>> GHOBKHCHNOK;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int NFBNLPKDNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	internal readonly Dictionary<TClaimant, TNode> FKANLNPHFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	internal readonly Dictionary<TNode, OLMGEOJBIJF> CLIHAHMPCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private PHKCGFLEKGO MCDJPGPBKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private bool GIFMINJHMEH;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode CKKAENBKGMB(TNode OIGMCOAHFGF);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NIIPDKHIBMI(TNode OIGMCOAHFGF, TClaimant CBNEPCLKJKL, TClaimant CCKEKAEIIBD);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2A2C180", Offset = "0x2A2AF80", VA = "0x182A2C180")]
	public IJCFDEIKFGA(PHKCGFLEKGO MCDJPGPBKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B880", Offset = "0x2A2A680", VA = "0x182A2B880")]
	public void OBLMPDADJLP(TNode OIGMCOAHFGF, TNode DOJCGKKDJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B780", Offset = "0x2A2A580", VA = "0x182A2B780")]
	public void MNMLADAKGNK(TClaimant PJFJMOJFAMF, TNode MNBEFECAPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B140", Offset = "0x2A29F40", VA = "0x182A2B140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BF80", Offset = "0x2A2AD80", VA = "0x182A2BF80")]
	private void PODPDPMOEJN(TClaimant PJFJMOJFAMF, TNode JMOFHJGLEBJ, TNode MNBEFECAPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BA10", Offset = "0x2A2A810", VA = "0x182A2BA10")]
	private int ONKNLJBFKOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BA70", Offset = "0x2A2A870", VA = "0x182A2BA70")]
	private void PGPEPKDNJBP(TClaimant PJFJMOJFAMF, TNode KFGMHAMIIHC, TNode KMPLFHBLGCG, int CFMBODPMKPP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B530", Offset = "0x2A2A330", VA = "0x182A2B530")]
	private void IDPKPHNLLGM(EPFENAMPHDJ MACJDDMABHG, OLMGEOJBIJF FDFAEJGHNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BD20", Offset = "0x2A2AB20", VA = "0x182A2BD20")]
	private void PLFMJJGOJIN(TClaimant PJFJMOJFAMF, TNode KFGMHAMIIHC, TNode KMPLFHBLGCG, int CFMBODPMKPP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B900", Offset = "0x2A2A700", VA = "0x182A2B900")]
	private void OMFLAABDCPJ(EPFENAMPHDJ MACJDDMABHG, TNode OIGMCOAHFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2AB80", Offset = "0x2A29980", VA = "0x182A2AB80")]
	private void BMABMOCEIJJ(EPFENAMPHDJ MACJDDMABHG, OLMGEOJBIJF FDFAEJGHNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2AC80", Offset = "0x2A29A80", VA = "0x182A2AC80")]
	private void DBHANDNAPHD(OLMGEOJBIJF FDFAEJGHNFH, bool LNFPOGFMFDD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2A2AD90", Offset = "0x2A29B90", VA = "0x182A2AD90")]
	private void DOKKLLHKHCN(OLMGEOJBIJF FDFAEJGHNFH, TNode DOJCGKKDJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B460", Offset = "0x2A2A260", VA = "0x182A2B460")]
	[IteratorStateMachine(typeof(IJCFDEIKFGA<, >.EAOKLPGKLIO))]
	private IEnumerable<TNode> GJODKPMKEFI(TNode KFGMHAMIIHC, TNode KMPLFHBLGCG, bool EIOIFLNEJMM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B3A0", Offset = "0x2A2A1A0", VA = "0x182A2B3A0")]
	private OLMGEOJBIJF EPPFGEHPNEM(TNode OIGMCOAHFGF, TNode GMBPOBACJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2A2A9F0", Offset = "0x2A297F0", VA = "0x182A2A9F0")]
	private OLMGEOJBIJF AJDCFHHCELN(TNode OIGMCOAHFGF, TNode GMBPOBACJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2A2B5C0", Offset = "0x2A2A3C0", VA = "0x182A2B5C0")]
	private void MIIFJNBEMID(OLMGEOJBIJF FDFAEJGHNFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class FJKGHANPDLO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	protected struct JJDBLOPDPBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T ODIKHJJHMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int KJABAPGACCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<JJDBLOPDPBI> ABIKDGNONGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T HKONIEHDHEM;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2372160", Offset = "0x2370F60", VA = "0x182372160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x46775D0", Offset = "0x46763D0", VA = "0x1846775D0")]
	public bool BBJPLADBJND(T KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x46777E0", Offset = "0x46765E0", VA = "0x1846777E0")]
	public void IMFFJGIMDFG(T KKLNCEHOHED, int IOLDIKGMLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4677B80", Offset = "0x4676980", VA = "0x184677B80")]
	public bool OIPPMFBKPAM(T KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x4677AB0", Offset = "0x46768B0", VA = "0x184677AB0")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x4677A40", Offset = "0x4676840", VA = "0x184677A40")]
	public T KKFKMDICJHD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4677B10", Offset = "0x4676910", VA = "0x184677B10")]
	public T LGIHAIGGOBA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4677880", Offset = "0x4676680", VA = "0x184677880")]
	private void JPANJOOBDNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x4677CA0", Offset = "0x4676AA0", VA = "0x184677CA0")]
	public FJKGHANPDLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class MAAOJNFJBML<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct BNFKKBPHJHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int KJABAPGACCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public T ODIKHJJHMMN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<object, BNFKKBPHJHI> FCBFEOILBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly EqualityComparer<T> MEPJFFMDPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private T DGFPJGMHCBO;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public virtual T BCECJEMCJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x3873320", Offset = "0x3872120", VA = "0x183873320", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x35E2A10", Offset = "0x35E1810", VA = "0x1835E2A10", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool AILEMGAHGPK
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3873C70", Offset = "0x3872A70", VA = "0x183873C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public object DBPHMELKBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x952E30", Offset = "0x951C30", VA = "0x180952E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x3873A90", Offset = "0x3872890", VA = "0x183873A90")]
	public bool IPOHJHICNJK(T KKLNCEHOHED, object GKNJCIECGND, int IOLDIKGMLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x3873C00", Offset = "0x3872A00", VA = "0x183873C00")]
	public bool KKLBNNBEHJB(object GKNJCIECGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x3873DB0", Offset = "0x3872BB0", VA = "0x183873DB0")]
	public bool NENMDMPJEFC(object GKNJCIECGND, out T KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x3873CA0", Offset = "0x3872AA0", VA = "0x183873CA0")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x3875A80", Offset = "0x3874880", VA = "0x183875A80")]
	private bool PPDGJDIPCBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x38783D0", Offset = "0x38771D0", VA = "0x1838783D0")]
	public MAAOJNFJBML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class JBGIJBODOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6F713C0", Offset = "0x6F701C0", VA = "0x186F713C0")]
	public static void NJGDAMCDBIK(LHKDGCOKKGC CDMJMAILEKC, string EFHBJLLKKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
	public static void NJGDAMCDBIK(IEnumerable<object> BHFJCLMFJAL, string EFHBJLLKKMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class POPCEKHPDHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private bool BALFBEBPNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private Action EHPEOJCHKEM;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public static POPCEKHPDHO GJCMEMJDPII
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6F73400", Offset = "0x6F72200", VA = "0x186F73400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool AFDJCBGMJPE
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x83B610", Offset = "0x83A410", VA = "0x18083B610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6F734A0", Offset = "0x6F722A0", VA = "0x186F734A0")]
	public POPCEKHPDHO(Action EHPEOJCHKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6F73480", Offset = "0x6F72280", VA = "0x186F73480")]
	public void NMCJFPPLLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6F73480", Offset = "0x6F72280", VA = "0x186F73480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class EIGJHDKIBLP : MKAPBHKEDAL
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6F6F200", Offset = "0x6F6E000", VA = "0x186F6F200")]
	public EIGJHDKIBLP(UnityEngine.Object IHDJGEKCNFG)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
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
