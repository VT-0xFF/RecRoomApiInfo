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
		[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F33D0", Offset = "0x7F1FD0", VA = "0x1807F33D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA19F80", Offset = "0xA18B80", VA = "0x180A19F80")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1A130", Offset = "0xA18D30", VA = "0x180A1A130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "4")]
	public virtual void JFMEPFIDBGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
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
	[GGOALGOKAII]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x42A7B00", Offset = "0x42A6700", VA = "0x1842A7B00", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x42A7230", Offset = "0x42A5E30", VA = "0x1842A7230", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x42A8040", Offset = "0x42A6C40", VA = "0x1842A8040")]
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
	private sealed class MMJMINFFNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public MMJMINFFNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2C87D40", Offset = "0x2C86940", VA = "0x182C87D40")]
		internal int BFMJKLDOFHH(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[GGOALGOKAII]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1B150C0", Offset = "0x1B13CC0", VA = "0x181B150C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1B150F0", Offset = "0x1B13CF0", VA = "0x181B150F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1B15010", Offset = "0x1B13C10", VA = "0x181B15010", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TVal this[TKey BDFCACLHAFA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1B15070", Offset = "0x1B13C70", VA = "0x181B15070", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1B14F10", Offset = "0x1B13B10", VA = "0x181B14F10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1B14A60", Offset = "0x1B13660", VA = "0x181B14A60", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1B14280", Offset = "0x1B12E80", VA = "0x181B14280", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1B13F30", Offset = "0x1B12B30", VA = "0x181B13F30", Slot = "14")]
	protected virtual string NEFECHKBEFL(TKeyVal BNDCFAJLFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1B13E10", Offset = "0x1B12A10", VA = "0x181B13E10", Slot = "4")]
	public bool ContainsKey(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1B14E00", Offset = "0x1B13A00", VA = "0x181B14E00", Slot = "5")]
	public bool TryGetValue(TKey BDFCACLHAFA, out TVal ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1B13E40", Offset = "0x1B12A40", VA = "0x181B13E40", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1B13E40", Offset = "0x1B12A40", VA = "0x181B13E40", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1B14E30", Offset = "0x1B13A30", VA = "0x181B14E30")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CNNIIPPIOPJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GCJNOLKLMPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public GCJNOLKLMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x25FC5B0", Offset = "0x25FB1B0", VA = "0x1825FC5B0")]
		internal bool FAENIIHPBOI(DKKIFMJJILM<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float EIBCHBCFBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float OKOJMDPOAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<DKKIFMJJILM<float, T>> PELCAIHKCCE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JOKICCHKEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3DDBD40", Offset = "0x3DDA940", VA = "0x183DDBD40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC0E0", Offset = "0x3DDACE0", VA = "0x183DDC0E0")]
	public CNNIIPPIOPJ(float DKKFNKOOCJP, float IPJBOBKGHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DDBDC0", Offset = "0x3DDA9C0", VA = "0x183DDBDC0")]
	public bool LMBLOMODHDD(float EAJNKPCKLBB, T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC080", Offset = "0x3DDAC80", VA = "0x183DDC080")]
	public int OLCBCPFMDCE(float EAJNKPCKLBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB980", Offset = "0x3DDA580", VA = "0x183DDB980")]
	public IEnumerable<T> JJMGPPHLILD(float EAJNKPCKLBB, [Optional] float? LMJBKPCPDMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB610", Offset = "0x3DDA210", VA = "0x183DDB610")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB550", Offset = "0x3DDA150", VA = "0x183DDB550")]
	private void BNPCLNEKCJI(float EAJNKPCKLBB)
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
	public T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E34450", Offset = "0x3E33050", VA = "0x183E34450")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E34460", Offset = "0x3E33060", VA = "0x183E34460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float KCJJFHHFMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE71250", Offset = "0xE6FE50", VA = "0x180E71250")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3E34180", Offset = "0x3E32D80", VA = "0x183E34180")]
	public T AMDGGMCPAGC(float NFOHJNABMAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3E34470", Offset = "0x3E33070", VA = "0x183E34470")]
	public T GHIOHNJFFFC(float NFOHJNABMAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GAIKGPLFBOK(T EOEOFNCKKHJ, T AOEAFBFCPPC, float NFOHJNABMAP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x39E0630", Offset = "0x39DF230", VA = "0x1839E0630", Slot = "4")]
	protected override float GAIKGPLFBOK(float EOEOFNCKKHJ, float AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B810", Offset = "0x6F0A410", VA = "0x186F0B810")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1D31DC0", Offset = "0x1D309C0", VA = "0x181D31DC0", Slot = "4")]
	protected override Vector3 GAIKGPLFBOK(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F10DE0", Offset = "0x6F0F9E0", VA = "0x186F10DE0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B260", Offset = "0x6F09E60", VA = "0x186F0B260", Slot = "4")]
	protected override Color GAIKGPLFBOK(Color EOEOFNCKKHJ, Color AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B2C0", Offset = "0x6F09EC0", VA = "0x186F0B2C0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HKFGBLBDDNE
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PNGEMDOFCPN<T1, T2> : IEnumerable<DKKIFMJJILM<T1, T2>>, IEnumerable, IEnumerator<DKKIFMJJILM<T1, T2>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DKKIFMJJILM<T1, T2> <>2__current;

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
		DKKIFMJJILM<T1, T2> IEnumerator<Tuple<T1, T2>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1FC23F0", Offset = "0x1FC0FF0", VA = "0x181FC23F0")]
		[DebuggerHidden]
		public PNGEMDOFCPN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2D3EE60", Offset = "0x2D3DA60", VA = "0x182D3EE60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F1E0", Offset = "0x2D3DDE0", VA = "0x182D3F1E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F0F0", Offset = "0x2D3DCF0", VA = "0x182D3F0F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<DKKIFMJJILM<T1, T2>> IEnumerable<Tuple<T1, T2>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2D3F1B0", Offset = "0x2D3DDB0", VA = "0x182D3F1B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class DGHBLAMNHLE<T1, T2, T3> : IEnumerable<HOMFIJMJJHM<T1, T2, T3>>, IEnumerable, IEnumerator<HOMFIJMJJHM<T1, T2, T3>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HOMFIJMJJHM<T1, T2, T3> <>2__current;

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
		HOMFIJMJJHM<T1, T2, T3> IEnumerator<Tuple<T1, T2, T3>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC23F0", Offset = "0x1FC0FF0", VA = "0x181FC23F0")]
		[DebuggerHidden]
		public DGHBLAMNHLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x52E2C30", Offset = "0x52E1830", VA = "0x1852E2C30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x52E3010", Offset = "0x52E1C10", VA = "0x1852E3010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2A48CF0", Offset = "0x2A478F0", VA = "0x182A48CF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<HOMFIJMJJHM<T1, T2, T3>> IEnumerable<Tuple<T1, T2, T3>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x26DF740", Offset = "0x26DE340", VA = "0x1826DF740", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1E70190", Offset = "0x1E6ED90", VA = "0x181E70190")]
	public static JNBEGEHKKJM<T1> JLAKJAPJOGA<T1>(T1 JOIOHBCDFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x291AB80", Offset = "0x2919780", VA = "0x18291AB80")]
	public static DKKIFMJJILM<T1, T2> JLAKJAPJOGA<T1, T2>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x291ABF0", Offset = "0x29197F0", VA = "0x18291ABF0")]
	public static HOMFIJMJJHM<T1, T2, T3> JLAKJAPJOGA<T1, T2, T3>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BCD0", Offset = "0x1E0A8D0", VA = "0x181E0BCD0")]
	public static CDDKCCPIDDP<T1, T2, T3, T4> JLAKJAPJOGA<T1, T2, T3, T4>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x291AEC0", Offset = "0x2919AC0", VA = "0x18291AEC0")]
	public static ADGBDOJBFMC<T1, T2, T3, T4, T5> JLAKJAPJOGA<T1, T2, T3, T4, T5>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x291AE10", Offset = "0x2919A10", VA = "0x18291AE10")]
	public static GEOAJILLIMF<T1, T2, T3, T4, T5, T6> JLAKJAPJOGA<T1, T2, T3, T4, T5, T6>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x291AD50", Offset = "0x2919950", VA = "0x18291AD50")]
	public static ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7> JLAKJAPJOGA<T1, T2, T3, T4, T5, T6, T7>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x291AC80", Offset = "0x2919880", VA = "0x18291AC80")]
	public static OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8> JLAKJAPJOGA<T1, T2, T3, T4, T5, T6, T7, T8>(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH, T8 BLDJGMBLIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F15580", Offset = "0x1F14180", VA = "0x181F15580")]
	[IteratorStateMachine(typeof(PNGEMDOFCPN<, >))]
	public static IEnumerable<DKKIFMJJILM<T1, T2>> IIONLKHJGPM<T1, T2>(IEnumerable<T1> NBLDAOBEAEA, IEnumerable<T2> PAJLLFKCBBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x22E0ED0", Offset = "0x22DFAD0", VA = "0x1822E0ED0")]
	[IteratorStateMachine(typeof(DGHBLAMNHLE<, , >))]
	public static IEnumerable<HOMFIJMJJHM<T1, T2, T3>> IIONLKHJGPM<T1, T2, T3>(IEnumerable<T1> NBLDAOBEAEA, IEnumerable<T2> PAJLLFKCBBD, IEnumerable<T3> CKEDCDKNDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BF20", Offset = "0x6F0AB20", VA = "0x186F0BF20")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BF80", Offset = "0x6F0AB80", VA = "0x186F0BF80")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BF60", Offset = "0x6F0AB60", VA = "0x186F0BF60")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BFC0", Offset = "0x6F0ABC0", VA = "0x186F0BFC0")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BF30", Offset = "0x6F0AB30", VA = "0x186F0BF30")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO, int AKHLOFDPCJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BEF0", Offset = "0x6F0AAF0", VA = "0x186F0BEF0")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO, int AKHLOFDPCJO, int GAJHMIDDLHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BF90", Offset = "0x6F0AB90", VA = "0x186F0BF90")]
	internal static int LGKODIFOLJA(int PMBDJGMHKEL, int FPPGIJAPGLA, int HPCKIBLPPLG, int LMGFBGGABJK, int FKFGAJKGKKO, int AKHLOFDPCJO, int GAJHMIDDLHL, int IAFFEMADAAG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JNBEGEHKKJM<T1> : IComparable<JNBEGEHKKJM<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AF70", Offset = "0x1D59B70", VA = "0x181D5AF70")]
	public JNBEGEHKKJM(T1 JOIOHBCDFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2991BA0", Offset = "0x29907A0", VA = "0x182991BA0", Slot = "4")]
	public int CompareTo(JNBEGEHKKJM<T1> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2991C10", Offset = "0x2990810", VA = "0x182991C10", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xE4DB40", Offset = "0xE4C740", VA = "0x180E4DB40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2991CB0", Offset = "0x29908B0", VA = "0x182991CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DKKIFMJJILM<T1, T2> : IComparable<DKKIFMJJILM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2953AB0", Offset = "0x29526B0", VA = "0x182953AB0")]
	public DKKIFMJJILM(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A43EF0", Offset = "0x2A42AF0", VA = "0x182A43EF0", Slot = "4")]
	public int CompareTo(DKKIFMJJILM<T1, T2> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A44240", Offset = "0x2A42E40", VA = "0x182A44240", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A44CA0", Offset = "0x2A438A0", VA = "0x182A44CA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A45400", Offset = "0x2A44000", VA = "0x182A45400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HOMFIJMJJHM<T1, T2, T3> : IComparable<HOMFIJMJJHM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DF20", Offset = "0x2E7CB20", VA = "0x182E7DF20")]
	public HOMFIJMJJHM(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D6E0", Offset = "0x2E7C2E0", VA = "0x182E7D6E0", Slot = "4")]
	public int CompareTo(HOMFIJMJJHM<T1, T2, T3> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D8E0", Offset = "0x2E7C4E0", VA = "0x182E7D8E0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DC00", Offset = "0x2E7C800", VA = "0x182E7DC00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DD70", Offset = "0x2E7C970", VA = "0x182E7DD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CDDKCCPIDDP<T1, T2, T3, T4> : IComparable<CDDKCCPIDDP<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1C85EA0", Offset = "0x1C84AA0", VA = "0x181C85EA0")]
	public CDDKCCPIDDP(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x295D050", Offset = "0x295BC50", VA = "0x18295D050", Slot = "4")]
	public int CompareTo(CDDKCCPIDDP<T1, T2, T3, T4> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x295D190", Offset = "0x295BD90", VA = "0x18295D190", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x295D2D0", Offset = "0x295BED0", VA = "0x18295D2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x295D390", Offset = "0x295BF90", VA = "0x18295D390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ADGBDOJBFMC<T1, T2, T3, T4, T5> : IComparable<ADGBDOJBFMC<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T5 IIENJDPJBMD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2C8CF70", Offset = "0x2C8BB70", VA = "0x182C8CF70")]
	public ADGBDOJBFMC(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x377BC20", Offset = "0x377A820", VA = "0x18377BC20", Slot = "4")]
	public int CompareTo(ADGBDOJBFMC<T1, T2, T3, T4, T5> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x377BDA0", Offset = "0x377A9A0", VA = "0x18377BDA0", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x377BF10", Offset = "0x377AB10", VA = "0x18377BF10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x377C010", Offset = "0x377AC10", VA = "0x18377C010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GEOAJILLIMF<T1, T2, T3, T4, T5, T6> : IComparable<GEOAJILLIMF<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T5 IIENJDPJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T6 JFBLCIDLNCG;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x26014A0", Offset = "0x26000A0", VA = "0x1826014A0")]
	public GEOAJILLIMF(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2600EC0", Offset = "0x25FFAC0", VA = "0x182600EC0", Slot = "4")]
	public int CompareTo(GEOAJILLIMF<T1, T2, T3, T4, T5, T6> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2601080", Offset = "0x25FFC80", VA = "0x182601080", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2601210", Offset = "0x25FFE10", VA = "0x182601210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2601330", Offset = "0x25FFF30", VA = "0x182601330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7> : IComparable<ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 IIENJDPJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 JFBLCIDLNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T7 AHKLAPOGIEA;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4757DC0", Offset = "0x47569C0", VA = "0x184757DC0")]
	public ICIIMIDMKDJ(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4757720", Offset = "0x4756320", VA = "0x184757720", Slot = "4")]
	public int CompareTo(ICIIMIDMKDJ<T1, T2, T3, T4, T5, T6, T7> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4757920", Offset = "0x4756520", VA = "0x184757920", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4757AE0", Offset = "0x47566E0", VA = "0x184757AE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4757C30", Offset = "0x4756830", VA = "0x184757C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T1 OOBAPIBDNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T2 NEDEEMBHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T3 PDJIKFHNIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T4 MNAHNNCCKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T5 IIENJDPJBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T6 JFBLCIDLNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T7 AHKLAPOGIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T8 MGGEGLLBIIB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4077970", Offset = "0x4076570", VA = "0x184077970")]
	public OFIAOOPFNIN(T1 JOIOHBCDFJK, T2 EHEGOMHMOBN, T3 KHLJNMGMCNK, T4 GMMGFFAADPG, T5 FFPJNPJPHPJ, T6 EMIINFLAGLO, T7 IEGCJACCDDH, T8 BLDJGMBLIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4077220", Offset = "0x4075E20", VA = "0x184077220", Slot = "4")]
	public int CompareTo(OFIAOOPFNIN<T1, T2, T3, T4, T5, T6, T7, T8> MDHJAFNLPON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4077470", Offset = "0x4076070", VA = "0x184077470", Slot = "0")]
	public override bool Equals(object MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4077650", Offset = "0x4076250", VA = "0x184077650", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x40777C0", Offset = "0x40763C0", VA = "0x1840777C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GGOALGOKAII : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8A3CC0", Offset = "0x8A28C0", VA = "0x1808A3CC0")]
	public GGOALGOKAII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HashableScriptableObject : ScriptableObject, IEEAIAKPCEK, INPIODOCMAF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85E2C0", Offset = "0x85CEC0", VA = "0x18085E2C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9C6D70", Offset = "0x9C5970", VA = "0x1809C6D70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DKKDLHLFHOF);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x10C7230", Offset = "0x10C5E30", VA = "0x1810C7230")]
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
	[LBBBOIMCAIE]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[SerializeField]
	[LBBBOIMCAIE]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FCC0", Offset = "0x6F0E8C0", VA = "0x186F0FCC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FC80", Offset = "0x6F0E880", VA = "0x186F0FC80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FD00", Offset = "0x6F0E900", VA = "0x186F0FD00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FED0", Offset = "0x6F0EAD0", VA = "0x186F0FED0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FE40", Offset = "0x6F0EA40", VA = "0x186F0FE40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x128EBB0", Offset = "0x128D7B0", VA = "0x18128EBB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x128EB30", Offset = "0x128D730", VA = "0x18128EB30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FC40", Offset = "0x6F0E840", VA = "0x186F0FC40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FDB0", Offset = "0x6F0E9B0", VA = "0x186F0FDB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F870", Offset = "0x6F0E470", VA = "0x186F0F870")]
	public void CopyBounds(SavedExtents MDHJAFNLPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FBA0", Offset = "0x6F0E7A0", VA = "0x186F0FBA0")]
	public void SetLocalSpaceBounds(Bounds PDOKDMEPNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F210", Offset = "0x6F0DE10", VA = "0x186F0F210")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FB90", Offset = "0x6F0E790", VA = "0x186F0FB90")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F020", Offset = "0x6F0DC20", VA = "0x186F0F020")]
	private void AMFJDGCNLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F960", Offset = "0x6F0E560", VA = "0x186F0F960")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F230", Offset = "0x6F0DE30", VA = "0x186F0F230")]
	public static void CalculateLocalBoundsFor(GameObject ALBKEDBKENG, out Bounds PDOKDMEPNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6F0F8A0", Offset = "0x6F0E4A0", VA = "0x186F0F8A0")]
	private static void MMDCCKHCKON(Bounds PAJLLFKCBBD, Color CKEDCDKNDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6F0FBC0", Offset = "0x6F0E7C0", VA = "0x186F0FBC0")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class FGGONGOBJMA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct LELAEELIAPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public T MHGNIJCIFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float CNINICBHKIE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static float MGJJPDPIMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<T> AINCAOMCLBE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const int ACNLCFDBDJJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private LELAEELIAPD[] EABDNHJFDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int BAPAIKADPMC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float DCPNKAMOCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1623790", Offset = "0x1622390", VA = "0x181623790")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x176C510", Offset = "0x176B110", VA = "0x18176C510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x32B4720", Offset = "0x32B3320", VA = "0x1832B4720")]
	public FGGONGOBJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x32B4620", Offset = "0x32B3220", VA = "0x1832B4620")]
	public FGGONGOBJMA(int GEFPLPIBMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x32B3140", Offset = "0x32B1D40", VA = "0x1832B3140")]
	public void CAILCKFFJIK(float EAJNKPCKLBB, T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x32B3510", Offset = "0x32B2110", VA = "0x1832B3510")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x32B3C70", Offset = "0x32B2870", VA = "0x1832B3C70")]
	public bool LDONHAGGEGK(float JINIMOJBGDF, float LMCEDNNCHKG, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x32B37B0", Offset = "0x32B23B0", VA = "0x1832B37B0")]
	public bool FEGGBFBCJPA(float JINIMOJBGDF, float LMCEDNNCHKG, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x32B4200", Offset = "0x32B2E00", VA = "0x1832B4200")]
	public void MHMAJDPNOML(float JINIMOJBGDF, float LMCEDNNCHKG, List<T> NLANKBLAOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x32B45A0", Offset = "0x32B31A0", VA = "0x1832B45A0")]
	private int MOBMDCJCEJA(int CFJGKJHIILK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x32B3C30", Offset = "0x32B2830", VA = "0x1832B3C30")]
	private void GMIFGBMNEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AHFJOCGODJH();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GAIKGPLFBOK(T EOEOFNCKKHJ, T AOEAFBFCPPC, float NFOHJNABMAP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BOIJDEBEJHH(T ECNGHFJBIJL, float NFOHJNABMAP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GHONKFPHFFA(T EOEOFNCKKHJ, T AOEAFBFCPPC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T GIBLADJBOON(T EOEOFNCKKHJ, T AOEAFBFCPPC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AEKEOHGLNID : FGGONGOBJMA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x10C3070", Offset = "0x10C1C70", VA = "0x1810C3070", Slot = "4")]
	protected override Vector3 AHFJOCGODJH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D31DC0", Offset = "0x1D309C0", VA = "0x181D31DC0", Slot = "5")]
	protected override Vector3 GAIKGPLFBOK(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F098C0", Offset = "0x6F084C0", VA = "0x186F098C0", Slot = "6")]
	protected override Vector3 BOIJDEBEJHH(Vector3 ECNGHFJBIJL, float NFOHJNABMAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F09920", Offset = "0x6F08520", VA = "0x186F09920", Slot = "7")]
	protected override Vector3 GHONKFPHFFA(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F099A0", Offset = "0x6F085A0", VA = "0x186F099A0", Slot = "8")]
	protected override Vector3 GIBLADJBOON(Vector3 EOEOFNCKKHJ, Vector3 AOEAFBFCPPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F09A10", Offset = "0x6F08610", VA = "0x186F09A10")]
	public AEKEOHGLNID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GPEJKPPFPKA : FGGONGOBJMA<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B8E0", Offset = "0x6F0A4E0", VA = "0x186F0B8E0")]
	public GPEJKPPFPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B870", Offset = "0x6F0A470", VA = "0x186F0B870")]
	public GPEJKPPFPKA(int GEFPLPIBMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xC0B210", Offset = "0xC09E10", VA = "0x180C0B210", Slot = "4")]
	protected override float AHFJOCGODJH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x39E0630", Offset = "0x39DF230", VA = "0x1839E0630", Slot = "5")]
	protected override float GAIKGPLFBOK(float EOEOFNCKKHJ, float AOEAFBFCPPC, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5940740", Offset = "0x593F340", VA = "0x185940740", Slot = "6")]
	protected override float BOIJDEBEJHH(float ECNGHFJBIJL, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B850", Offset = "0x6F0A450", VA = "0x186F0B850", Slot = "7")]
	protected override float GHONKFPHFFA(float EOEOFNCKKHJ, float AOEAFBFCPPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B860", Offset = "0x6F0A460", VA = "0x186F0B860", Slot = "8")]
	protected override float GIBLADJBOON(float EOEOFNCKKHJ, float AOEAFBFCPPC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KIGJBHHMGOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IDisposable EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public KIGJBHHMGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ILMMOMFFIAJ : ODDMALFOGNH<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C140", Offset = "0x6F0AD40", VA = "0x186F0C140")]
	public ILMMOMFFIAJ(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C0E0", Offset = "0x6F0ACE0", VA = "0x186F0C0E0")]
	public ILMMOMFFIAJ(DANOALJMLDD[] LMHLDELFGFA, bool BFBLJDNFJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C070", Offset = "0x6F0AC70", VA = "0x186F0C070", Slot = "6")]
	protected override uint NOOACFKFHCM(uint DKKDLHLFHOF, string ECNGHFJBIJL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class AMPEKBKFHNB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct MNLBNIGKPHB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly AMPEKBKFHNB<T> GFKFIAALCBF;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T MHGNIJCIFFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C520", Offset = "0x2C8B120", VA = "0x182C8C520")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C540", Offset = "0x2C8B140", VA = "0x182C8C540", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xB1CC20", Offset = "0xB1B820", VA = "0x180B1CC20")]
		public MNLBNIGKPHB(AMPEKBKFHNB<T> GFKFIAALCBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class AEHHDLLFEFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<MNLBNIGKPHB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AMPEKBKFHNB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public AEHHDLLFEFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x38067D0", Offset = "0x38053D0", VA = "0x1838067D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IOHBJBKOCFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<MNLBNIGKPHB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AMPEKBKFHNB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public IOHBJBKOCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3871AA0", Offset = "0x38706A0", VA = "0x183871AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly SemaphoreSlim HLKNAPHLMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T GIFKGKNAFME;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GJAANALIPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3228910", Offset = "0x3227510", VA = "0x183228910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3228960", Offset = "0x3227560", VA = "0x183228960")]
	public AMPEKBKFHNB(in T GIFKGKNAFME, int AOMOMCDDNBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3228930", Offset = "0x3227530", VA = "0x183228930")]
	public AMPEKBKFHNB(in T GIFKGKNAFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3228190", Offset = "0x3226D90", VA = "0x183228190")]
	public MNLBNIGKPHB DJCIPMFGKEI()
	{
		return default(MNLBNIGKPHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x32281D0", Offset = "0x3226DD0", VA = "0x1832281D0")]
	public MNLBNIGKPHB DJCIPMFGKEI(CancellationToken GFFFFCALMCA)
	{
		return default(MNLBNIGKPHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3228760", Offset = "0x3227360", VA = "0x183228760")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMPEKBKFHNB<>.AEHHDLLFEFK))]
	public Task<MNLBNIGKPHB> KPABIKOBAPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3228210", Offset = "0x3226E10", VA = "0x183228210")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AMPEKBKFHNB<>.IOHBJBKOCFP))]
	public Task<MNLBNIGKPHB> KPABIKOBAPK(CancellationToken GFFFFCALMCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CODPNHOLMNA
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B200", Offset = "0x6F09E00", VA = "0x186F0B200")]
	public static AMPEKBKFHNB<DPIJIKFEAOC> DOBPLOGGNLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B190", Offset = "0x6F09D90", VA = "0x186F0B190")]
	public static AMPEKBKFHNB<DPIJIKFEAOC> DOBPLOGGNLM(int AOMOMCDDNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E70190", Offset = "0x1E6ED90", VA = "0x181E70190")]
	public static AMPEKBKFHNB<T> DOBPLOGGNLM<T>(in T GIFKGKNAFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x268C190", Offset = "0x268AD90", VA = "0x18268C190")]
	public static AMPEKBKFHNB<T> DOBPLOGGNLM<T>(in T GIFKGKNAFME, int AOMOMCDDNBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class PGDLNHIILLB<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private PGDLNHIILLB<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x9897D0", Offset = "0x9883D0", VA = "0x1809897D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x33FFEE0", Offset = "0x33FEAE0", VA = "0x1833FFEE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2E6FB80", Offset = "0x2E6E780", VA = "0x182E6FB80")]
		public Enumerator(PGDLNHIILLB<T> NLANKBLAOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x33FC820", Offset = "0x33FB420", VA = "0x1833FC820", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x33FE450", Offset = "0x33FD050", VA = "0x1833FE450", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x33FB600", Offset = "0x33FA200", VA = "0x1833FB600")]
		private void LBPMHNCKNKL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private T[] FFPFEFDNOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int GOGKDEGLBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int JBOMFIHOBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private int FPBNFBFIPHI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3A7A6B0", Offset = "0x3A792B0", VA = "0x183A7A6B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3A79030", Offset = "0x3A77C30", VA = "0x183A79030")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3A79240", Offset = "0x3A77E40", VA = "0x183A79240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A7AC60", Offset = "0x3A79860", VA = "0x183A7AC60")]
	public PGDLNHIILLB(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3A78DE0", Offset = "0x3A779E0", VA = "0x183A78DE0")]
	public void CAILCKFFJIK(T NFOHJNABMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A7A090", Offset = "0x3A78C90", VA = "0x183A7A090")]
	public void MIEPPGEFOLJ(IEnumerable<T> OMCHMPJJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A79010", Offset = "0x3A77C10", VA = "0x183A79010")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A79930", Offset = "0x3A78530", VA = "0x183A79930")]
	public void LENIFPHCDAG(int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A791B0", Offset = "0x3A77DB0", VA = "0x183A791B0")]
	public void GECMALKHHPP(int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A796B0", Offset = "0x3A782B0", VA = "0x183A796B0")]
	public void IMKOGLOMGAJ(T[] EABDNHJFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A79A60", Offset = "0x3A78660", VA = "0x183A79A60")]
	public Enumerator MEOEHOBEEMI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3A7AAE0", Offset = "0x3A796E0", VA = "0x183A7AAE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A7AAE0", Offset = "0x3A796E0", VA = "0x183A7AAE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3A7A6F0", Offset = "0x3A792F0", VA = "0x183A7A6F0")]
	private int OBAPAMDGAKF(int NHHNPPKPBIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A7AAB0", Offset = "0x3A796B0", VA = "0x183A7AAB0")]
	private int PDCILPABJMN(int NHHNPPKPBIA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class KJFMDBFPCPL
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NACLKOJNEAO(object[] PFFFGKKOEPM);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	protected KJFMDBFPCPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class PEMOMEOLKEJ<T> : KJFMDBFPCPL
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	protected struct DHFLHMBJFFD
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum KNNDCFDIGKB
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
		public KNNDCFDIGKB FIJCKHKKDCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public T FOGMDOMFJBB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int KNBILKDKKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly bool IHLCILHELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly bool CICPIOFKENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	protected List<T> EGKNAOOFGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<DHFLHMBJFFD> HCIOCPBELBH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool BOFOJEMFJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A77900", Offset = "0x3A76500", VA = "0x183A77900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A77A80", Offset = "0x3A76680", VA = "0x183A77A80")]
	protected PEMOMEOLKEJ(bool CICPIOFKENJ, bool IHLCILHELIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A77A00", Offset = "0x3A76600", VA = "0x183A77A00")]
	protected bool KNGMDNHCGFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3A77940", Offset = "0x3A76540", VA = "0x183A77940")]
	protected void KBBPAIDBMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A77390", Offset = "0x3A75F90", VA = "0x183A77390")]
	protected void ABDCADBEJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3349AA0", Offset = "0x33486A0", VA = "0x183349AA0")]
	private static void OGPPOMJFBOH<U>(ref List<U> IFADMANLNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A77540", Offset = "0x3A76140", VA = "0x183A77540", Slot = "5")]
	public void CAILCKFFJIK(T FOGMDOMFJBB, bool AKPODJDOLHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A776A0", Offset = "0x3A762A0", VA = "0x183A776A0", Slot = "6")]
	public void CPPHPNNFPKL(T FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A777F0", Offset = "0x3A763F0", VA = "0x183A777F0")]
	public void ELJLHOEKJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface CFELNKMGIIB
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class KBJOPGEOOCH : PEMOMEOLKEJ<Action>, CFELNKMGIIB
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C570", Offset = "0x6F0B170", VA = "0x186F0C570")]
	public KBJOPGEOOCH(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C2A0", Offset = "0x6F0AEA0", VA = "0x186F0C2A0")]
	public void MKOHINBGHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C4A0", Offset = "0x6F0B0A0", VA = "0x186F0C4A0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C510", Offset = "0x6F0B110", VA = "0x186F0C510")]
	public static KBJOPGEOOCH OGNHPCPAOIL(KBJOPGEOOCH GJLGCDFBOPB, Action FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C240", Offset = "0x6F0AE40", VA = "0x186F0C240")]
	public static KBJOPGEOOCH EPKAGIOEOFM(KBJOPGEOOCH GJLGCDFBOPB, Action FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JEMMICINFPD<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class NAOGJOJMPFD<T> : PEMOMEOLKEJ<Action<T>>, JEMMICINFPD<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1DE0", Offset = "0x1FC09E0", VA = "0x181FC1DE0")]
	public NAOGJOJMPFD(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2F82CB0", Offset = "0x2F818B0", VA = "0x182F82CB0")]
	public void MKOHINBGHOB(T NFOHJNABMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2F849A0", Offset = "0x2F835A0", VA = "0x182F849A0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2F851F0", Offset = "0x2F83DF0", VA = "0x182F851F0")]
	public static NAOGJOJMPFD<T> OGNHPCPAOIL(NAOGJOJMPFD<T> GJLGCDFBOPB, Action<T> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2F81510", Offset = "0x2F80110", VA = "0x182F81510")]
	public static NAOGJOJMPFD<T> EPKAGIOEOFM(NAOGJOJMPFD<T> GJLGCDFBOPB, Action<T> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MKOCEIDPNEN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HJMCHKIHGED<T, U> : PEMOMEOLKEJ<Action<T, U>>, MKOCEIDPNEN<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1DE0", Offset = "0x1FC09E0", VA = "0x181FC1DE0")]
	public HJMCHKIHGED(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x40047A0", Offset = "0x40033A0", VA = "0x1840047A0")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x40056D0", Offset = "0x40042D0", VA = "0x1840056D0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4007E40", Offset = "0x4006A40", VA = "0x184007E40")]
	public static HJMCHKIHGED<T, U> OGNHPCPAOIL(HJMCHKIHGED<T, U> GJLGCDFBOPB, Action<T, U> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x40021C0", Offset = "0x4000DC0", VA = "0x1840021C0")]
	public static HJMCHKIHGED<T, U> EPKAGIOEOFM(HJMCHKIHGED<T, U> GJLGCDFBOPB, Action<T, U> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface FEBNCCLAJPG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U, V> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U, V> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class KJIOPDDOALH<T, U, V> : PEMOMEOLKEJ<Action<T, U, V>>, FEBNCCLAJPG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1DE0", Offset = "0x1FC09E0", VA = "0x181FC1DE0")]
	public KJIOPDDOALH(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2C43020", Offset = "0x2C41C20", VA = "0x182C43020")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2C45880", Offset = "0x2C44480", VA = "0x182C45880", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2C46750", Offset = "0x2C45350", VA = "0x182C46750")]
	public static KJIOPDDOALH<T, U, V> OGNHPCPAOIL(KJIOPDDOALH<T, U, V> GJLGCDFBOPB, Action<T, U, V> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2C42870", Offset = "0x2C41470", VA = "0x182C42870")]
	public static KJIOPDDOALH<T, U, V> EPKAGIOEOFM(KJIOPDDOALH<T, U, V> GJLGCDFBOPB, Action<T, U, V> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CDKHBNHOIDE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U, V, W> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U, V, W> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class KBBANGGGBBP<T, U, V, W> : PEMOMEOLKEJ<Action<T, U, V, W>>, CDKHBNHOIDE<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1DE0", Offset = "0x1FC09E0", VA = "0x181FC1DE0")]
	public KBBANGGGBBP(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x26A8F00", Offset = "0x26A7B00", VA = "0x1826A8F00")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM, W OJBIOMHAGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x26AA5D0", Offset = "0x26A91D0", VA = "0x1826AA5D0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x26AB230", Offset = "0x26A9E30", VA = "0x1826AB230")]
	public static KBBANGGGBBP<T, U, V, W> OGNHPCPAOIL(KBBANGGGBBP<T, U, V, W> GJLGCDFBOPB, Action<T, U, V, W> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x26A8830", Offset = "0x26A7430", VA = "0x1826A8830")]
	public static KBBANGGGBBP<T, U, V, W> EPKAGIOEOFM(KBBANGGGBBP<T, U, V, W> GJLGCDFBOPB, Action<T, U, V, W> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface AIIOBBAJEGA<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U, V, W, X> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U, V, W, X> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class KPGINHGLGBA<T, U, V, W, X> : PEMOMEOLKEJ<Action<T, U, V, W, X>>, AIIOBBAJEGA<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1DE0", Offset = "0x1FC09E0", VA = "0x181FC1DE0")]
	public KPGINHGLGBA(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4034380", Offset = "0x4032F80", VA = "0x184034380")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM, W OJBIOMHAGBL, X OLGJDFCIILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4034940", Offset = "0x4033540", VA = "0x184034940", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4034F50", Offset = "0x4033B50", VA = "0x184034F50")]
	public static KPGINHGLGBA<T, U, V, W, X> OGNHPCPAOIL(KPGINHGLGBA<T, U, V, W, X> GJLGCDFBOPB, Action<T, U, V, W, X> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x40342E0", Offset = "0x4032EE0", VA = "0x1840342E0")]
	public static KPGINHGLGBA<T, U, V, W, X> EPKAGIOEOFM(KPGINHGLGBA<T, U, V, W, X> GJLGCDFBOPB, Action<T, U, V, W, X> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PCHKEHAPBBA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAILCKFFJIK(Action<T, U, V, W, X, Y> FOGMDOMFJBB, bool AKPODJDOLHD = false);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPPHPNNFPKL(Action<T, U, V, W, X, Y> FOGMDOMFJBB);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class CDNDLCKKIIJ<T, U, V, W, X, Y> : PEMOMEOLKEJ<Action<T, U, V, W, X, Y>>, PCHKEHAPBBA<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1DE0", Offset = "0x1FC09E0", VA = "0x181FC1DE0")]
	public CDNDLCKKIIJ(bool CICPIOFKENJ = false, bool IHLCILHELIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x295D970", Offset = "0x295C570", VA = "0x18295D970")]
	public void MKOHINBGHOB(T NFOHJNABMAP, U CFKHIDLOGCG, V KNLEJKEBOMM, W OJBIOMHAGBL, X OLGJDFCIILF, Y IKFJLOPMKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x295E2B0", Offset = "0x295CEB0", VA = "0x18295E2B0", Slot = "4")]
	public override void NACLKOJNEAO(object[] PFFFGKKOEPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x295E940", Offset = "0x295D540", VA = "0x18295E940")]
	public static CDNDLCKKIIJ<T, U, V, W, X, Y> OGNHPCPAOIL(CDNDLCKKIIJ<T, U, V, W, X, Y> GJLGCDFBOPB, Action<T, U, V, W, X, Y> FOGMDOMFJBB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x295D610", Offset = "0x295C210", VA = "0x18295D610")]
	public static CDNDLCKKIIJ<T, U, V, W, X, Y> EPKAGIOEOFM(CDNDLCKKIIJ<T, U, V, W, X, Y> GJLGCDFBOPB, Action<T, U, V, W, X, Y> FOGMDOMFJBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct PBHEEDKBLDK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class IDAFJEIGMIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public IDAFJEIGMIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1C73770", Offset = "0x1C72370", VA = "0x181C73770")]
		internal void NHFCKJJIIKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OLCFPOMJGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int LEKEBEOLEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int HANFGKPEECM;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xE5EA50", Offset = "0xE5D650", VA = "0x180E5EA50")]
	private PBHEEDKBLDK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MLICDOOHGLO, int BFEDDGBJLGL, int NLBBJHJNDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DC00", Offset = "0x3A6C800", VA = "0x183A6DC00")]
	public static PBHEEDKBLDK<T> DOBPLOGGNLM()
	{
		return default(PBHEEDKBLDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3A6D4C0", Offset = "0x3A6C0C0", VA = "0x183A6D4C0")]
	public (int, int, Task<T>) DFFBOIKCNMM(int JIKEGDDBPDP, [Optional] CancellationToken GFFFFCALMCA, double JJEEOOEDFIC = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6DCF0", Offset = "0x3A6C8F0", VA = "0x183A6DCF0")]
	public void IMNICMNPGDG(int JIKEGDDBPDP, int NLBBJHJNDIP, in T IIMBBHEIGGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ENAPBGFAADC
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B4B0", Offset = "0x6F0A0B0", VA = "0x186F0B4B0")]
	public static PBHEEDKBLDK<DPIJIKFEAOC> DOBPLOGGNLM()
	{
		return default(PBHEEDKBLDK<DPIJIKFEAOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B500", Offset = "0x6F0A100", VA = "0x186F0B500")]
	public static void IMNICMNPGDG(this in PBHEEDKBLDK<DPIJIKFEAOC> GPOCLJBKMHA, int JIKEGDDBPDP, int NLBBJHJNDIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public class CIHALCFMIHM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, TVal> KMCJMFMLCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Dictionary<TVal, TKey> EICIDPKNFLH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA650", Offset = "0x1FB9250", VA = "0x181FBA650", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CA0", Offset = "0x7F48A0", VA = "0x1807F5CA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> NJNAPAHAGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x294C290", Offset = "0x294AE90", VA = "0x18294C290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TVal> OCFAGHJFNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x29A3B30", Offset = "0x29A2730", VA = "0x1829A3B30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TVal OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x29A3AF0", Offset = "0x29A26F0", VA = "0x1829A3AF0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x29A3B60", Offset = "0x29A2760", VA = "0x1829A3B60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TKey OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x29A2BC0", Offset = "0x29A17C0", VA = "0x1829A2BC0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x29A2EC0", Offset = "0x29A1AC0", VA = "0x1829A2EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x29A2A70", Offset = "0x29A1670", VA = "0x1829A2A70", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x29A3990", Offset = "0x29A2590", VA = "0x1829A3990", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x29A27C0", Offset = "0x29A13C0", VA = "0x1829A27C0", Slot = "9")]
	public void Add(TKey BDFCACLHAFA, TVal ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x29A2780", Offset = "0x29A1380", VA = "0x1829A2780", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x29A2AD0", Offset = "0x29A16D0", VA = "0x1829A2AD0", Slot = "8")]
	public bool ContainsKey(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x29A2B30", Offset = "0x29A1730", VA = "0x1829A2B30", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x25F9D00", Offset = "0x25F8900", VA = "0x1825F9D00", Slot = "10")]
	public bool Remove(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x29A38C0", Offset = "0x29A24C0", VA = "0x1829A38C0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA430", Offset = "0x1FB9030", VA = "0x181FBA430", Slot = "11")]
	public bool TryGetValue(TKey BDFCACLHAFA, out TVal ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x29A2D40", Offset = "0x29A1940", VA = "0x1829A2D40", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x29A2B60", Offset = "0x29A1760", VA = "0x1829A2B60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x29A2950", Offset = "0x29A1550", VA = "0x1829A2950")]
	public void CAILCKFFJIK(TVal FOHLJCNEPNC, TKey BDFCACLHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x29A2990", Offset = "0x29A1590", VA = "0x1829A2990")]
	public void CAILCKFFJIK(KeyValuePair<TVal, TKey> FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x29A33A0", Offset = "0x29A1FA0", VA = "0x1829A33A0")]
	public bool PBFMMEHNOBJ(TVal BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x29A3300", Offset = "0x29A1F00", VA = "0x1829A3300")]
	public bool ODOLPHCGINH(KeyValuePair<TVal, TKey> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x29A2A00", Offset = "0x29A1600", VA = "0x1829A2A00")]
	public bool CPPHPNNFPKL(TVal BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x29A2A00", Offset = "0x29A1600", VA = "0x1829A2A00")]
	public bool CPPHPNNFPKL(KeyValuePair<TVal, TKey> FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x29A30E0", Offset = "0x29A1CE0", VA = "0x1829A30E0")]
	public bool KFBGNHHGLGM(TVal BDFCACLHAFA, out TKey ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x29A2C30", Offset = "0x29A1830", VA = "0x1829A2C30")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FOPHCKACLHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x29A3010", Offset = "0x29A1C10", VA = "0x1829A3010")]
	private void HMAODFLOOLI(TKey BDFCACLHAFA, TVal FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x29A3120", Offset = "0x29A1D20", VA = "0x1829A3120")]
	private void MCIJLJCKBNK(TKey BDFCACLHAFA, TVal FOHLJCNEPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x29A3700", Offset = "0x29A2300", VA = "0x1829A3700")]
	private bool PLKEILCEGJN(TKey BDFCACLHAFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x29A3620", Offset = "0x29A2220", VA = "0x1829A3620")]
	private bool PLKEILCEGJN(TVal FOHLJCNEPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x29A39E0", Offset = "0x29A25E0", VA = "0x1829A39E0")]
	public CIHALCFMIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DefaultMember("Item")]
public class HEKPBOBAIDI<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Func<Internal, External> OOFAJPBIDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly Func<External, Internal> HHEDOLCCPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private IList<Internal> IFADMANLNLG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IList<Internal> CNDMAIFAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x85E2C0", Offset = "0x85CEC0", VA = "0x18085E2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x95ED60", Offset = "0x95D960", VA = "0x18095ED60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x927C10", Offset = "0x926810", VA = "0x180927C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x44F5B30", Offset = "0x44F4730", VA = "0x1844F5B30", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x44F5BD0", Offset = "0x44F47D0", VA = "0x1844F5BD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x44F5AD0", Offset = "0x44F46D0", VA = "0x1844F5AD0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3A78180", Offset = "0x3A76D80", VA = "0x183A78180")]
	public HEKPBOBAIDI(Func<Internal, External> OOFAJPBIDBP, Func<External, Internal> HHEDOLCCPGA, bool INCMGOFNCLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x44F58A0", Offset = "0x44F44A0", VA = "0x1844F58A0", Slot = "6")]
	public int IndexOf(External FHJBBMIILLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x44F5520", Offset = "0x44F4120", VA = "0x1844F5520", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x44F5580", Offset = "0x44F4180", VA = "0x1844F5580", Slot = "13")]
	public bool Contains(External FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x44F5610", Offset = "0x44F4210", VA = "0x1844F5610", Slot = "14")]
	public void CopyTo(External[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x44F5430", Offset = "0x44F4030", VA = "0x1844F5430", Slot = "11")]
	public void Add(External FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x44F5930", Offset = "0x44F4530", VA = "0x1844F5930", Slot = "7")]
	public void Insert(int NHHNPPKPBIA, External FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x44F5A40", Offset = "0x44F4640", VA = "0x1844F5A40", Slot = "15")]
	public bool Remove(External FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x44F59D0", Offset = "0x44F45D0", VA = "0x1844F59D0", Slot = "8")]
	public void RemoveAt(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x44F5830", Offset = "0x44F4430", VA = "0x1844F5830", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F1B0", Offset = "0x2D3DDB0", VA = "0x182D3F1B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class KEEHLMDHALL<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Func<Internal, External> OOFAJPBIDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IReadOnlyList<Internal> IFADMANLNLG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> CNDMAIFAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D00", Offset = "0x7F4900", VA = "0x1807F5D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x26AE480", Offset = "0x26AD080", VA = "0x1826AE480", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x26AE420", Offset = "0x26AD020", VA = "0x1826AE420", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AF70", Offset = "0x1D59B70", VA = "0x181D5AF70")]
	public KEEHLMDHALL(Func<Internal, External> OOFAJPBIDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x26AE3D0", Offset = "0x26ACFD0", VA = "0x1826AE3D0")]
	public KEEHLMDHALL(IReadOnlyList<Internal> IFADMANLNLG, Func<Internal, External> OOFAJPBIDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x26AE1B0", Offset = "0x26ACDB0", VA = "0x1826AE1B0")]
	public void IMKOGLOMGAJ(External[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x26AE0E0", Offset = "0x26ACCE0", VA = "0x1826AE0E0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1C739F0", Offset = "0x1C725F0", VA = "0x181C739F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[DefaultMember("Item")]
public class HBPOIIBKJNC<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyList<Internal> IFADMANLNLG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IReadOnlyList<Internal> CNDMAIFAHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x842A50", Offset = "0x841650", VA = "0x180842A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D00", Offset = "0x7F4900", VA = "0x1807F5D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public External OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3324D20", Offset = "0x3323920", VA = "0x183324D20", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3324CC0", Offset = "0x33238C0", VA = "0x183324CC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AF70", Offset = "0x1D59B70", VA = "0x181D5AF70")]
	public HBPOIIBKJNC(IReadOnlyList<Internal> IFADMANLNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3324C20", Offset = "0x3323820", VA = "0x183324C20")]
	public bool ODOLPHCGINH(External FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x33249F0", Offset = "0x33235F0", VA = "0x1833249F0")]
	public void IMKOGLOMGAJ(External[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3324980", Offset = "0x3323580", VA = "0x183324980", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F1B0", Offset = "0x2D3DDB0", VA = "0x182D3F1B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EKFJNFEBJEA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> AGJCFAKOHDC(TRequest PAJPFFIMEFB, CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum BJPDCCEEFFL
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class GHLNPONKHGM
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const float DDCCCCEHDDE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private TimeSpan NNOONHOMBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int OIFGLAEGACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public BJPDCCEEFFL ACEAOIPODJF;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public static readonly GHLNPONKHGM OAEIAFEPBFB;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float IIECNIAHEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x2606EB0", Offset = "0x2605AB0", VA = "0x182606EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan BIMGNANIFOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x26070E0", Offset = "0x2605CE0", VA = "0x1826070E0")]
		public GHLNPONKHGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct GHIOCHKBJNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly TRequest PAJPFFIMEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly CancellationToken GFFFFCALMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly TaskCompletionSource<TResult> BFLDPIIJLEC;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x26043D0", Offset = "0x2602FD0", VA = "0x1826043D0")]
		public GHIOCHKBJNP(TRequest PAJPFFIMEFB, TaskCompletionSource<TResult> BFLDPIIJLEC, CancellationToken GFFFFCALMCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DDILHEOKIPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public DDILHEOKIPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA650", Offset = "0x1FB9250", VA = "0x181FBA650")]
		internal void NJPMBAKGOBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class GKIFLIHNBJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public EKFJNFEBJEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public GKIFLIHNBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x260A820", Offset = "0x2609420", VA = "0x18260A820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class IGJPIEGAOEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public EKFJNFEBJEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private GHIOCHKBJNP <req>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public IGJPIEGAOEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1C78A10", Offset = "0x1C77610", VA = "0x181C78A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CancellationTokenSource DEPPNCOAKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<GHIOCHKBJNP> ADJLFKKCAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly GHLNPONKHGM DKMEANFNLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly AGJCFAKOHDC BGBEHENHJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Task EIKDEJFCDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private int BJJLKHFGGDL;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3295100", Offset = "0x3293D00", VA = "0x183295100")]
	public EKFJNFEBJEA(AGJCFAKOHDC BGBEHENHJEK, [Optional] GHLNPONKHGM DKMEANFNLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3293A80", Offset = "0x3292680", VA = "0x183293A80")]
	public Task<TResult> AIDOFGLCCHD(TRequest PAJPFFIMEFB, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3294B40", Offset = "0x3293740", VA = "0x183294B40")]
	private void KHEGKMJBODH(GHIOCHKBJNP FIPDHKGPCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3294D10", Offset = "0x3293910", VA = "0x183294D10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EKFJNFEBJEA<, >.GKIFLIHNBJP))]
	private Task LGMAMEGNNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3294660", Offset = "0x3293260", VA = "0x183294660")]
	private GHIOCHKBJNP GJLDCBJIJID()
	{
		return default(GHIOCHKBJNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3293F70", Offset = "0x3292B70", VA = "0x183293F70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EKFJNFEBJEA<, >.IGJPIEGAOEE))]
	private Task CANCAKFOEIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3294280", Offset = "0x3292E80", VA = "0x183294280")]
	private void CMLPNALAHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3294360", Offset = "0x3292F60", VA = "0x183294360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface DDGAGPGNFPJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface AACICHIEKPH<T> : DDGAGPGNFPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool PNJODNOGGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string DFFLLHDOFCE
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
	AACICHIEKPH<T> OPNLGLFHHJA(Action<T> EJHEMANGOEK);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AACICHIEKPH<T> CEDGGHAFJKO(Action<T> EJHEMANGOEK);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AACICHIEKPH<T> LIFJBAKHMEG(Action<T, T> FOOMJEJICME);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AACICHIEKPH<T> ENLLKKOMPDO(Action<T, T> FOOMJEJICME);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AACICHIEKPH<T> GFAGJPBHKLG(Action<string> LKICEHJCLKB);

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AACICHIEKPH<T> APPBPNLCCGB(Action<string> LKICEHJCLKB);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class DHALFLDNIDD<T> : AACICHIEKPH<T>, DDGAGPGNFPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private HJMCHKIHGED<T, T> MNLOIFBIJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NAOGJOJMPFD<T> BONMDADOCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NAOGJOJMPFD<string> BEKJAKGICEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private string FKPBDLDGFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private T IIMBBHEIGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool PHLPDICNKFG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T MHGNIJCIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA56850", Offset = "0xA55450", VA = "0x180A56850", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57A10", VA = "0x181D58E10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PNJODNOGGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x938FE0", Offset = "0x937BE0", VA = "0x180938FE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string DFFLLHDOFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B0A0", Offset = "0xA29CA0", VA = "0x180A2B0A0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x15D4BD0", Offset = "0x15D37D0", VA = "0x1815D4BD0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2A40D90", Offset = "0x2A3F990", VA = "0x182A40D90")]
	private void MNBHKBFFHBK(T MEKBNGFFPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2A40C90", Offset = "0x2A3F890", VA = "0x182A40C90")]
	private void LCADPBBFAGG(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A40E30", Offset = "0x2A3FA30", VA = "0x182A40E30")]
	public void NHGHFKAFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A40D40", Offset = "0x2A3F940", VA = "0x182A40D40", Slot = "6")]
	public AACICHIEKPH<T> LIFJBAKHMEG(Action<T, T> FOOMJEJICME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A40BA0", Offset = "0x2A3F7A0", VA = "0x182A40BA0", Slot = "7")]
	public AACICHIEKPH<T> ENLLKKOMPDO(Action<T, T> FOOMJEJICME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A40EE0", Offset = "0x2A3FAE0", VA = "0x182A40EE0", Slot = "4")]
	public AACICHIEKPH<T> OPNLGLFHHJA(Action<T> FOOMJEJICME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A40B50", Offset = "0x2A3F750", VA = "0x182A40B50", Slot = "5")]
	public AACICHIEKPH<T> CEDGGHAFJKO(Action<T> EJHEMANGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A40BF0", Offset = "0x2A3F7F0", VA = "0x182A40BF0", Slot = "8")]
	public AACICHIEKPH<T> GFAGJPBHKLG(Action<string> LKICEHJCLKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A40AE0", Offset = "0x2A3F6E0", VA = "0x182A40AE0", Slot = "9")]
	public AACICHIEKPH<T> APPBPNLCCGB(Action<string> LKICEHJCLKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A40F70", Offset = "0x2A3FB70", VA = "0x182A40F70")]
	public DHALFLDNIDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FJJKDFGAIAO
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class APGBOGNLDIM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AACICHIEKPH<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public GBNOCCBNCBC<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public APGBOGNLDIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x322C130", Offset = "0x322AD30", VA = "0x18322C130")]
		internal void GLMMHMOIHJG(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1E0DAC0", Offset = "0x1E0C6C0", VA = "0x181E0DAC0")]
	public static NBFPPJGKGOH<T> GCHGIFGBMBE<T>(this AACICHIEKPH<T> GFFJLKBKGKP, Action<T> IACLOIAOHJF)
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
			[Cpp2IlInjected.Address(RVA = "0x375C270", Offset = "0x375AE70", VA = "0x18375C270")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E787A0", Offset = "0x6E773A0", VA = "0x186E787A0")]
		public SerializedGuid(in Guid PCFHAIHNKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F10210", Offset = "0x6F0EE10", VA = "0x186F10210")]
		public static SerializedGuid OFDHHOGOACB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F10180", Offset = "0x6F0ED80", VA = "0x186F10180")]
		public static SerializedGuid JFNFONDAPFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F102A0", Offset = "0x6F0EEA0", VA = "0x186F102A0")]
		public bool OKHCPHKNICN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E78770", Offset = "0x6E77370", VA = "0x186E78770", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F10330", Offset = "0x6F0EF30", VA = "0x186F10330", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F100F0", Offset = "0x6F0ECF0", VA = "0x186F100F0")]
		public bool FMOLALLCICL(in Guid PCFHAIHNKAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FF60", Offset = "0x6F0EB60", VA = "0x186F0FF60", Slot = "7")]
		public bool Equals(SerializedGuid MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6F10010", Offset = "0x6F0EC10", VA = "0x186F10010", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E786C0", Offset = "0x6E772C0", VA = "0x186E786C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E78500", Offset = "0x6E77100", VA = "0x186E78500", Slot = "6")]
		public int CompareTo(SerializedGuid MDHJAFNLPON)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class NNJFCKNKHBA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly Type MGEPNNKCKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly string LAKGEPFEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool JHDJEAPEEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly bool AMELPFAIPOL;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EA30", Offset = "0x6F0D630", VA = "0x186F0EA30")]
	public NNJFCKNKHBA(Type HGBBHGHBLFE, string GHDKOMENMKC, bool FOBNDAAIBNH = false, bool NNHFFLPCIGL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DefaultMember("Item")]
public class JBEMIBHHCAC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<T> IFADMANLNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private HashSet<T> JAEDJOIGJCA;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA650", Offset = "0x1FB9250", VA = "0x181FBA650", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JKOPFKMGHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3460", Offset = "0x7F2060", VA = "0x1807F3460", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2838FF0", Offset = "0x2837BF0", VA = "0x182838FF0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x35700A0", Offset = "0x356ECA0", VA = "0x1835700A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x356F710", Offset = "0x356E310", VA = "0x18356F710", Slot = "11")]
	public void Add(T FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x356FBB0", Offset = "0x356E7B0", VA = "0x18356FBB0")]
	public bool JCOHIHLGEAI(T FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x356FE80", Offset = "0x356EA80", VA = "0x18356FE80", Slot = "15")]
	public bool Remove(T FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA380", Offset = "0x1FB8F80", VA = "0x181FBA380", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2983E90", Offset = "0x2982A90", VA = "0x182983E90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x356F740", Offset = "0x356E340", VA = "0x18356F740", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D6F0", Offset = "0x2A4C2F0", VA = "0x182A4D6F0", Slot = "13")]
	public bool Contains(T FHJBBMIILLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x356F7A0", Offset = "0x356E3A0", VA = "0x18356F7A0", Slot = "14")]
	public void CopyTo(T[] EABDNHJFDCB, int KHLMLDANMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x29A3AC0", Offset = "0x29A26C0", VA = "0x1829A3AC0", Slot = "6")]
	public int IndexOf(T FHJBBMIILLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x356FA40", Offset = "0x356E640", VA = "0x18356FA40", Slot = "7")]
	public void Insert(int NHHNPPKPBIA, T FHJBBMIILLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x356FC50", Offset = "0x356E850", VA = "0x18356FC50", Slot = "8")]
	public void RemoveAt(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x356F8A0", Offset = "0x356E4A0", VA = "0x18356F8A0")]
	public void IHBIIKDAKOI(Predicate<T> LDNIBEBMKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0400", Offset = "0x1FBF000", VA = "0x181FC0400")]
	public void HOIHKHFBLLG(Comparison<T> OBDHEPNLMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x356FF00", Offset = "0x356EB00", VA = "0x18356FF00")]
	public JBEMIBHHCAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class NGNEDPOIMFM
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DC00", Offset = "0x6F0C800", VA = "0x186F0DC00")]
	public static Vector3 DBEDDMGMBIL(this GameObject ALBKEDBKENG, float NKMLOAFCLKE)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class PFLOOOBDIHA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly Type MGEPNNKCKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly string LAKGEPFEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly bool JHDJEAPEEEL;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6F0EAA0", Offset = "0x6F0D6A0", VA = "0x186F0EAA0")]
	public PFLOOOBDIHA(Type HGBBHGHBLFE, string GHDKOMENMKC, bool FOBNDAAIBNH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KNLEPHMPGDG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C6B0", Offset = "0x6F0B2B0", VA = "0x186F0C6B0")]
	public KNLEPHMPGDG(string DKIECHCHJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C630", Offset = "0x6F0B230", VA = "0x186F0C630")]
	public KNLEPHMPGDG(string DKIECHCHJFL, Exception NCFNHKNLKKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CLDJFIHFHLI
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B100", Offset = "0x6F09D00", VA = "0x186F0B100")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this INPIODOCMAF EKNEHDJHLJF, byte[] IDKBGDBOHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AEC0", Offset = "0x6F09AC0", VA = "0x186F0AEC0")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this INPIODOCMAF EKNEHDJHLJF, HashAlgorithmName INMIEOBOCOF, byte[] IDKBGDBOHNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface INPIODOCMAF
{
	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash DKKDLHLFHOF);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface IEEAIAKPCEK : INPIODOCMAF
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] LKOCLPINJLF
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
	byte[] KKGKKCLGPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	UnityEngine.Object BGNPIGCBKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class BJAEKPDMJHC
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class DNMAGGAJLEO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B360", Offset = "0x6F09F60", VA = "0x186F0B360")]
		public DNMAGGAJLEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B300", Offset = "0x6F09F00", VA = "0x186F0B300", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private const byte NABDKGFPOGC = 1;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const byte BCPOFEJIFNL = 0;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ArrayPool<byte> OEGBGGGCCAF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static bool LOLMGOLOCEO;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2FF9730", Offset = "0x2FF8330", VA = "0x182FF9730")]
	[Conditional("UNITY_EDITOR")]
	private static void MBMMEKELBLE<T>(params T[] ENBMDODBPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AC70", Offset = "0x6F09870", VA = "0x186F0AC70")]
	public static IDisposable PBCBAJOHDLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A360", Offset = "0x6F08F60", VA = "0x186F0A360")]
	public static void GBHCEDAGLCB(this IncrementalHash ALNNPHJMFIL, [CanBeNull] GameObject ALBKEDBKENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2FF9660", Offset = "0x2FF8260", VA = "0x182FF9660")]
	public static void GBHCEDAGLCB<T>(this IncrementalHash ALNNPHJMFIL, [CanBeNull] T DPLEBJGMEDE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2FF95D0", Offset = "0x2FF81D0", VA = "0x182FF95D0")]
	public static void FMMGOBKJECI<T>(this IncrementalHash ALNNPHJMFIL, [CanBeNull] T EKNEHDJHLJF) where T : INPIODOCMAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2FF9A20", Offset = "0x2FF8620", VA = "0x182FF9A20")]
	public static void NDNBOLDFGLE<T>(this IncrementalHash ALNNPHJMFIL, [CanBeNull] IList<T> CFBEPOFGJFK) where T : INPIODOCMAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A450", Offset = "0x6F09050", VA = "0x186F0A450")]
	private static bool GCKEMAFCIAH([CanBeNull] INPIODOCMAF EKNEHDJHLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AD10", Offset = "0x6F09910", VA = "0x186F0AD10")]
	public static void PMGHKCKLIBJ(this IncrementalHash DKKDLHLFHOF, [CanBeNull] string IHEIAPOCOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A930", Offset = "0x6F09530", VA = "0x186F0A930")]
	public static void NMKMPNACABA(this IncrementalHash DKKDLHLFHOF, long AAACKIAOAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A540", Offset = "0x6F09140", VA = "0x186F0A540")]
	public static void IFMPIFADCCK(this IncrementalHash DKKDLHLFHOF, int CPOCCBGJOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F09D10", Offset = "0x6F08910", VA = "0x186F09D10")]
	public static void AFNDAMCPINI(this IncrementalHash DKKDLHLFHOF, short DLAMMDHENLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AB00", Offset = "0x6F09700", VA = "0x186F0AB00")]
	public static void OCIDBOPAICL(this IncrementalHash DKKDLHLFHOF, byte AOJNFIFCAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F09EE0", Offset = "0x6F08AE0", VA = "0x186F09EE0")]
	public static void BAIKMMKLGPJ(this IncrementalHash DKKDLHLFHOF, bool COGGBAODFBM, bool BDOIJAHLIIP = false, bool GHIKJHJAJPB = false, bool JDPFAHHEEFL = false, bool FMMJIPDCINK = false, bool IBKPNFDDOFP = false, bool MHOKCHELOKC = false, bool FLBPMBPBADC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2FF9E80", Offset = "0x2FF8A80", VA = "0x182FF9E80")]
	public static void ODHKCPGHCOH<T>(this IncrementalHash DKKDLHLFHOF, T AMNNIMCNJDH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A120", Offset = "0x6F08D20", VA = "0x186F0A120")]
	public static void DFHBBDKPEKE(this IncrementalHash DKKDLHLFHOF, float GHHIHMFDJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A4E0", Offset = "0x6F090E0", VA = "0x186F0A4E0")]
	public static void HBJHNEMPALP(this IncrementalHash DKKDLHLFHOF, double JEHKHBEKMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A2F0", Offset = "0x6F08EF0", VA = "0x186F0A2F0")]
	public static void FNOAJHGKFOB(this IncrementalHash DKKDLHLFHOF, ulong ADHLDIBIHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A8D0", Offset = "0x6F094D0", VA = "0x186F0A8D0")]
	public static void JJCIOFHLIBI(this IncrementalHash DKKDLHLFHOF, uint LFNGHAPJAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A0B0", Offset = "0x6F08CB0", VA = "0x186F0A0B0")]
	public static void BMJLAHDIFEC(this IncrementalHash DKKDLHLFHOF, ushort BLNNHACDOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A180", Offset = "0x6F08D80", VA = "0x186F0A180")]
	public static void EABJBLKANBE(this IncrementalHash DKKDLHLFHOF, Vector3 IKBGLOMGGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A710", Offset = "0x6F09310", VA = "0x186F0A710")]
	public static void JELCMHAHCCG(this IncrementalHash DKKDLHLFHOF, Quaternion IKJHPFLGHKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class HIGINMENPKE
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B950", Offset = "0x6F0A550", VA = "0x186F0B950")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this IEEAIAKPCEK OHIFKEKKGBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B9C0", Offset = "0x6F0A5C0", VA = "0x186F0B9C0")]
	[NotNull]
	public static byte[] EKPELJIKGFA(this IEEAIAKPCEK OHIFKEKKGBE, HashAlgorithmName INMIEOBOCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BBC0", Offset = "0x6F0A7C0", VA = "0x186F0BBC0")]
	public static bool JLECPPEIGPM([CanBeNull] this IEEAIAKPCEK OHIFKEKKGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BD50", Offset = "0x6F0A950", VA = "0x186F0BD50")]
	public static bool JLECPPEIGPM([CanBeNull] this IEEAIAKPCEK OHIFKEKKGBE, out string FKPBDLDGFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BA30", Offset = "0x6F0A630", VA = "0x186F0BA30")]
	private static string GNELJCECGNF([CanBeNull] byte[] ENEAOCDMOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F0BAA0", Offset = "0x6F0A6A0", VA = "0x186F0BAA0")]
	private static bool JHHKFIOLDMP([NotNull] IEEAIAKPCEK OHIFKEKKGBE, [CanBeNull] out byte[] DBOIMFAIFIH, [CanBeNull] out byte[] ELGLFFLEHII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public abstract class OPMDLAPLJBA<TTask, T> : BMMLLBKLJDM<T>, FNEGELMJDBM, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class KGNBKCHGPKO
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
			public KGNBKCHGPKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x22CCCD0", Offset = "0x22CB8D0", VA = "0x1822CCCD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
		public OPMDLAPLJBA<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public KGNBKCHGPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2C3AF30", Offset = "0x2C39B30", VA = "0x182C3AF30")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OPMDLAPLJBA<, >.KGNBKCHGPKO.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> GFHPBEBEGFA(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static bool JKPPEODFBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly Task<T> GAKDIIFBLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	protected readonly CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool GHKACLCDPMJ;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Task<T> DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Task NMOONEGGGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EILHPPDHBHH LOKNNCIAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x26024D0", Offset = "0x26010D0", VA = "0x1826024D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool JHFNJCFMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x95ED60", Offset = "0x95D960", VA = "0x18095ED60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x489EB00", Offset = "0x489D700", VA = "0x18489EB00")]
	static OPMDLAPLJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x489EFD0", Offset = "0x489DBD0", VA = "0x18489EFD0")]
	protected OPMDLAPLJBA(TTask GAKDIIFBLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x489E6F0", Offset = "0x489D2F0", VA = "0x18489E6F0", Slot = "1")]
	~OPMDLAPLJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x489E6C0", Offset = "0x489D2C0", VA = "0x18489E6C0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x489E930", Offset = "0x489D530", VA = "0x18489E930")]
	private void LIEFKNGBAEG(bool MDEOJBFAIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T JLNNKDEAEDL(TTask CNOKCNJONIB);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JAMCMKIDADE();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class CNIIHJDMKOI : PLHBFOCCPAO<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B140", Offset = "0x6F09D40", VA = "0x186F0B140")]
	public CNIIHJDMKOI(Exception KIEMAGPGLGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PLHBFOCCPAO<T> : BMMLLBKLJDM<T>, FNEGELMJDBM, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public Task<T> DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private Task NMOONEGGGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x14FE3C0", Offset = "0x14FCFC0", VA = "0x1814FE3C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private EILHPPDHBHH LOKNNCIAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x15D45D0", Offset = "0x15D31D0", VA = "0x1815D45D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2D389C0", Offset = "0x2D375C0", VA = "0x182D389C0")]
	public PLHBFOCCPAO(Exception KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface FNEGELMJDBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[NotNull]
	Task DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[NotNull]
	EILHPPDHBHH NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface BMMLLBKLJDM<T> : FNEGELMJDBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[NotNull]
	new Task<T> DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	new NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class BPEANJCACFL : PBFOOBDDNHD<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6F0AE80", Offset = "0x6F09A80", VA = "0x186F0AE80")]
	public BPEANJCACFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class PBFOOBDDNHD<T> : BMMLLBKLJDM<T>, FNEGELMJDBM, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Task<T> DAKHKMPDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private Task NMOONEGGGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x14FE3C0", Offset = "0x14FCFC0", VA = "0x1814FE3C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public NBFPPJGKGOH<T> NFMMEGLCENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private EILHPPDHBHH LOKNNCIAKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x15D45D0", Offset = "0x15D31D0", VA = "0x1815D45D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3A64FB0", Offset = "0x3A63BB0", VA = "0x183A64FB0")]
	public PBFOOBDDNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class BDPOMAKGMDN : JAPPGKMKBNF<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IKCGLDBLFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action<BDPOMAKGMDN> callback;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public IKCGLDBLFAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BFE0", Offset = "0x6F0ABE0", VA = "0x186F0BFE0")]
		internal void PKFOHKCNHGL(JAPPGKMKBNF<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6F09BC0", Offset = "0x6F087C0", VA = "0x186F09BC0")]
	public BDPOMAKGMDN([Optional] string EKLNNMKJFJE, [Optional] int? FENNDHCJJPL, [Optional] Stopwatch NGBOPHHNHAL, [Optional] Action<string, PKDKPIIHBOC> MGOLJMIHAJI, [Optional] Action<string, PKDKPIIHBOC> ENMNJFPNDPE, [Optional] Action<BDPOMAKGMDN> PHAGACJHDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6F09AE0", Offset = "0x6F086E0", VA = "0x186F09AE0")]
	private static Action<JAPPGKMKBNF<string>> KMBKEDOPFCG(Action<BDPOMAKGMDN> IACLOIAOHJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class PGFIODPNGPE<TKey> : DPNILAIBCPB<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class EPFECJABJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public EKNONCNMHGH keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public EPFECJABJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1B10B00", Offset = "0x1B0F700", VA = "0x181B10B00")]
		internal string EDJOIBDDLEL(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3A7AD00", Offset = "0x3A79900", VA = "0x183A7AD00", Slot = "5")]
	protected override string KLFBMEGCMOO(JAPPGKMKBNF<TKey> IDIJCJCNEPO, EKNONCNMHGH LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA620", Offset = "0x1FB9220", VA = "0x181FBA620")]
	public PGFIODPNGPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class NDNNEJNANJD<TKey> : MFDHBKFONEG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate string IEKDKKDPLNF(TKey BDFCACLHAFA);

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private const int OBBFNPFJIFM = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly string AGOMEPFMNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly double ACMHMPFHEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly bool MFMOBLBGILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly int OELNLLDOMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly ISet<string> IEKBODLLLOH;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA6E0", Offset = "0x1FB92E0", VA = "0x181FBA6E0")]
	private static string DHNMLCJPLHP(TKey BDFCACLHAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x1FBB120", Offset = "0x1FB9D20", VA = "0x181FBB120")]
	public NDNNEJNANJD(string AGOMEPFMNMI = "F2", double ACMHMPFHEGL = double.MaxValue, bool MFMOBLBGILH = false, int OELNLLDOMIP = int.MaxValue, [Optional] ISet<string> IEKBODLLLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA980", Offset = "0x1FB9580", VA = "0x181FBA980", Slot = "4")]
	public override Dictionary<string, string> GBBAFINFGIO(JAPPGKMKBNF<TKey> IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA720", Offset = "0x1FB9320", VA = "0x181FBA720")]
	private bool DIOMMJEIOBB(string LPCDIMOBLNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAA30", Offset = "0x1FB9630", VA = "0x181FBAA30")]
	public Dictionary<string, string> GBBAFINFGIO(JAPPGKMKBNF<TKey> IDIJCJCNEPO, IEKDKKDPLNF LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1FBAF70", Offset = "0x1FB9B70", VA = "0x181FBAF70")]
	private string ONJCLHAIGLE(StringBuilder IOBIMBJLCJB, List<TKey> PGEPAHPIDFO, IEKDKKDPLNF LGDBOJKCHND, bool DKEIJDLIPDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBA800", Offset = "0x1FB9400", VA = "0x181FBA800")]
	private static void FAOBNEGEOBP(StringBuilder DOAKNDKFOJJ, string MIOGHELNGNI, bool OHIBDAHDNAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class MFDHBKFONEG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut GBBAFINFGIO(JAPPGKMKBNF<TKey> IDIJCJCNEPO);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
	protected MFDHBKFONEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class DPNILAIBCPB<TKey> : MFDHBKFONEG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public delegate string EKNONCNMHGH(TKey BDFCACLHAFA);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3B588B0", Offset = "0x3B574B0", VA = "0x183B588B0")]
	protected string JFHAPFGKJPB(double MBPEFNOIKNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3B58670", Offset = "0x3B57270", VA = "0x183B58670")]
	protected string EPAIEBGHBDC(int NBGDFKLHLOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3B58630", Offset = "0x3B57230", VA = "0x183B58630")]
	private static string DHNMLCJPLHP(TKey BDFCACLHAFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3B586D0", Offset = "0x3B572D0", VA = "0x183B586D0", Slot = "4")]
	public override string GBBAFINFGIO(JAPPGKMKBNF<TKey> IDIJCJCNEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3B58780", Offset = "0x3B57380", VA = "0x183B58780")]
	public string GBBAFINFGIO(JAPPGKMKBNF<TKey> IDIJCJCNEPO, [NotNull] EKNONCNMHGH LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string KLFBMEGCMOO(JAPPGKMKBNF<TKey> IDIJCJCNEPO, [NotNull] EKNONCNMHGH LGDBOJKCHND);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2D3F1B0", Offset = "0x2D3DDB0", VA = "0x182D3F1B0")]
	protected DPNILAIBCPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public abstract class NAJOFKHOGHM
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class FFPGKPCBMGB : NAJOFKHOGHM
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static NAJOFKHOGHM EABDDJEADPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x6F0B580", Offset = "0x6F0A180", VA = "0x186F0B580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override DateTime NOOMFHNGOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x6F0B5E0", Offset = "0x6F0A1E0", VA = "0x186F0B5E0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override float LGNCOMMFFDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x6F092B0", Offset = "0x6F07EB0", VA = "0x186F092B0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B6D0", Offset = "0x6F0A2D0", VA = "0x186F0B6D0")]
		public FFPGKPCBMGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static NAJOFKHOGHM FKACPJJDDIO;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static NAJOFKHOGHM OAEIAFEPBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DA70", Offset = "0x6F0C670", VA = "0x186F0DA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public abstract DateTime NOOMFHNGOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public abstract float LGNCOMMFFDP
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	protected NAJOFKHOGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HKFCPNLCEIC<TKey> : DPNILAIBCPB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct AFLGCOANFEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public EKNONCNMHGH keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static HKFCPNLCEIC<TKey> EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private const int GMKCGFCDFEE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly string[] MJHFLMBNMMO;

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2E73C10", Offset = "0x2E72810", VA = "0x182E73C10")]
	private HKFCPNLCEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2E72C30", Offset = "0x2E71830", VA = "0x182E72C30", Slot = "5")]
	protected override string KLFBMEGCMOO(JAPPGKMKBNF<TKey> IDIJCJCNEPO, EKNONCNMHGH LGDBOJKCHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x2E72B40", Offset = "0x2E71740", VA = "0x182E72B40")]
	[CompilerGenerated]
	internal static string JCIMNOPKPPN(string LIJPLFFEDOP, TKey BDFCACLHAFA, ref AFLGCOANFEN P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class JAPPGKMKBNF<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public readonly struct PKDKPIIHBOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly long BAHOEHOOJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly long NHIEONFMGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly int FENNDHCJJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly int APIDBNJMOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly bool HONBDECDNIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly string HOEMMCAKAAG;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x42EBFF0", Offset = "0x42EABF0", VA = "0x1842EBFF0")]
		public PKDKPIIHBOC(long BAHOEHOOJGF, int FENNDHCJJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x42EC060", Offset = "0x42EAC60", VA = "0x1842EC060")]
		public PKDKPIIHBOC(long BAHOEHOOJGF, long NHIEONFMGLD, int FENNDHCJJPL, int APIDBNJMOJD, bool HONBDECDNIP, string HOEMMCAKAAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x42EBF50", Offset = "0x42EAB50", VA = "0x1842EBF50")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ONMAAIJMEKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x42EBF00", Offset = "0x42EAB00", VA = "0x1842EBF00")]
		public int NFHAOHLLALE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x42EBFD0", Offset = "0x42EABD0", VA = "0x1842EBFD0")]
		public int PMCLDDHPBCH(int OBNGPCHGBMF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x42EBE90", Offset = "0x42EAA90", VA = "0x1842EBE90")]
		public double MLCGGBPAPHJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x42EBDD0", Offset = "0x42EA9D0", VA = "0x1842EBDD0")]
		public PKDKPIIHBOC EABKMEAPNDD(long NHIEONFMGLD, int APIDBNJMOJD)
		{
			return default(PKDKPIIHBOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class KLCBHAGBNOA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class CCKBKDFMLGH<T> : IAsyncStateMachine
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
			public Func<KLCBHAGBNOA, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public KLCBHAGBNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private KLCBHAGBNOA <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
			public CCKBKDFMLGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x295CD70", Offset = "0x295B970", VA = "0x18295CD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly TKey JKHFJODHGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly JAPPGKMKBNF<TKey> IDIJCJCNEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private List<KLCBHAGBNOA> PPGKEPMFCLE;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string AMMJLBNDGMI
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x1C745E0", Offset = "0x1C731E0", VA = "0x181C745E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x1C741F0", Offset = "0x1C72DF0", VA = "0x181C741F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEnumerable<KLCBHAGBNOA> GLGFKAIAEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2C53A50", Offset = "0x2C52650", VA = "0x182C53A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public PKDKPIIHBOC ICCFEAONLLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1B3E860", Offset = "0x1B3D460", VA = "0x181B3E860")]
			[CompilerGenerated]
			get
			{
				return default(PKDKPIIHBOC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x2C53940", Offset = "0x2C52540", VA = "0x182C53940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2C53A70", Offset = "0x2C52670", VA = "0x182C53A70")]
		internal KLCBHAGBNOA(JAPPGKMKBNF<TKey> IDIJCJCNEPO, TKey BDFCACLHAFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2C53680", Offset = "0x2C52280", VA = "0x182C53680")]
		public KLCBHAGBNOA AMICMCIKJKC(TKey BDFCACLHAFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2C53970", Offset = "0x2C52570", VA = "0x182C53970")]
		public void KMBKEDOPFCG(TKey BDFCACLHAFA, Action<KLCBHAGBNOA> FOGMDOMFJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2DC67B0", Offset = "0x2DC53B0", VA = "0x182DC67B0")]
		public T KMBKEDOPFCG<T>(TKey BDFCACLHAFA, Func<KLCBHAGBNOA, T> ELKBEDCOHFJ)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2DC65F0", Offset = "0x2DC51F0", VA = "0x182DC65F0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CCKBKDFMLGH<>))]
		public Task<T> JHEGKLHHLAN<T>(TKey BDFCACLHAFA, Func<KLCBHAGBNOA, Task<T>> ELKBEDCOHFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2C53790", Offset = "0x2C52390", VA = "0x182C53790", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class PCDDOMNLABE : IEnumerable<(TKey, List<TKey>, PKDKPIIHBOC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PKDKPIIHBOC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private (TKey key, List<TKey> path, PKDKPIIHBOC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public JAPPGKMKBNF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private IEnumerator<(TKey key, List<TKey> path, PKDKPIIHBOC timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private (TKey key, List<TKey> path, PKDKPIIHBOC timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private (TKey, List<TKey>, PKDKPIIHBOC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x322B5E0", Offset = "0x322A1E0", VA = "0x18322B5E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PKDKPIIHBOC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x3A6E620", Offset = "0x3A6D220", VA = "0x183A6E620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x322B970", Offset = "0x322A570", VA = "0x18322B970")]
		[DebuggerHidden]
		public PCDDOMNLABE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x29A7EF0", Offset = "0x29A6AF0", VA = "0x1829A7EF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E250", Offset = "0x3A6CE50", VA = "0x183A6E250", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E200", Offset = "0x3A6CE00", VA = "0x183A6E200")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E5E0", Offset = "0x3A6D1E0", VA = "0x183A6E5E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x3A6E520", Offset = "0x3A6D120", VA = "0x183A6E520", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PKDKPIIHBOC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2901200", Offset = "0x28FFE00", VA = "0x182901200", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class LKHEBDICKIB : IEnumerable<(TKey, List<TKey>, PKDKPIIHBOC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PKDKPIIHBOC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private (TKey key, List<TKey> path, PKDKPIIHBOC timerEntry) <>2__current;

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
		private KLCBHAGBNOA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public KLCBHAGBNOA <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public JAPPGKMKBNF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private IEnumerator<KLCBHAGBNOA> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private KLCBHAGBNOA <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private IEnumerator<(TKey key, List<TKey> path, PKDKPIIHBOC timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private (TKey key, List<TKey> path, PKDKPIIHBOC timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private (TKey, List<TKey>, PKDKPIIHBOC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x322B5E0", Offset = "0x322A1E0", VA = "0x18322B5E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PKDKPIIHBOC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x34C3390", Offset = "0x34C1F90", VA = "0x1834C3390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x322B970", Offset = "0x322A570", VA = "0x18322B970")]
		[DebuggerHidden]
		public LKHEBDICKIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x34C33F0", Offset = "0x34C1FF0", VA = "0x1834C33F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x34C2BC0", Offset = "0x34C17C0", VA = "0x1834C2BC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x34C2B60", Offset = "0x34C1760", VA = "0x1834C2B60")]
		private void EHFOANOMIIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x34C31E0", Offset = "0x34C1DE0", VA = "0x1834C31E0")]
		private void NDPBPNJDDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x34C3350", Offset = "0x34C1F50", VA = "0x1834C3350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x34C3240", Offset = "0x34C1E40", VA = "0x1834C3240", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PKDKPIIHBOC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x34C3320", Offset = "0x34C1F20", VA = "0x1834C3320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<TKey, PKDKPIIHBOC> MGOLJMIHAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly Action<TKey, PKDKPIIHBOC> ENMNJFPNDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Action<JAPPGKMKBNF<TKey>> PHAGACJHDKJ;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const string JMMJAHODMHK = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly KLCBHAGBNOA DCGEHADKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool GHKACLCDPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int JPNGHIHINAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Stopwatch NGBOPHHNHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly int BBMFKGICJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private string CABNFDFLEJF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public KLCBHAGBNOA AABDNGDDMML
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3240", Offset = "0x7F1E40", VA = "0x1807F3240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	public string AMMJLBNDGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8390B0", Offset = "0x837CB0", VA = "0x1808390B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x356F340", Offset = "0x356DF40", VA = "0x18356F340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public long JLABMGHGBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x356F3C0", Offset = "0x356DFC0", VA = "0x18356F3C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int PAMGGJEPCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x356F3E0", Offset = "0x356DFE0", VA = "0x18356F3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x356F590", Offset = "0x356E190", VA = "0x18356F590")]
	public JAPPGKMKBNF(TKey DOFEACJBFLN, [Optional] int? FENNDHCJJPL, [Optional][CanBeNull] Stopwatch NGBOPHHNHAL, [Optional] Action<TKey, PKDKPIIHBOC> MGOLJMIHAJI, [Optional] Action<TKey, PKDKPIIHBOC> ENMNJFPNDPE, [Optional] Action<JAPPGKMKBNF<TKey>> PHAGACJHDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x356F2B0", Offset = "0x356DEB0", VA = "0x18356F2B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x356F570", Offset = "0x356E170", VA = "0x18356F570")]
	public void NEDAAMABCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x356F3A0", Offset = "0x356DFA0", VA = "0x18356F3A0")]
	public void IKGIICDJABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x356F410", Offset = "0x356E010", VA = "0x18356F410")]
	[IteratorStateMachine(typeof(JAPPGKMKBNF<>.PCDDOMNLABE))]
	public IEnumerable<(TKey, List<TKey>, PKDKPIIHBOC)> NCKIECPAKPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x356F4A0", Offset = "0x356E0A0", VA = "0x18356F4A0")]
	[IteratorStateMachine(typeof(JAPPGKMKBNF<>.LKHEBDICKIB))]
	private IEnumerable<(TKey, List<TKey>, PKDKPIIHBOC)> NCKIECPAKPF(List<TKey> FMALCPACLGP, KLCBHAGBNOA MPOFGPPJKDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x356F230", Offset = "0x356DE30", VA = "0x18356F230")]
	private (long, int) DMNOPEMNDFO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class NNDAHABCPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Dictionary<byte, MJLLOGCLAHK> KLFGJONGGEG;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MJLLOGCLAHK HJEBMDOFADN
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x842A50", Offset = "0x841650", VA = "0x180842A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 FIMHFHEPMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x15392D0", Offset = "0x1537ED0", VA = "0x1815392D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x86C6B0", Offset = "0x86B2B0", VA = "0x18086C6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 LMHJNKIBKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1C79A00", Offset = "0x1C78600", VA = "0x181C79A00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA58090", Offset = "0xA56C90", VA = "0x180A58090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 EPFGMMNIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DED0", Offset = "0x6F0CAD0", VA = "0x186F0DED0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1CB52A0", Offset = "0x1CB3EA0", VA = "0x181CB52A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int APEIDHOMMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898450", VA = "0x180899850")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8A3620", Offset = "0x8A2220", VA = "0x1808A3620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E5D0", Offset = "0x6F0D1D0", VA = "0x186F0E5D0")]
	public NNDAHABCPBF(Bounds HPDFBJOLJPK, Vector2[] MEKPDIJBFHD, int DIGDPOPOLAN, byte GOGKDEGLBIL, float LPFICPPOAOL = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E410", Offset = "0x6F0D010", VA = "0x186F0E410")]
	public MJLLOGCLAHK LFEINNEAFNP(byte NHHNPPKPBIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DF10", Offset = "0x6F0CB10", VA = "0x186F0DF10")]
	public void ICCMCFLBNJE(Vector3 NABPHMOHNDG, float DDHPBADLENH, float JNFDEPAMMBN, ref List<byte> BEEKMCIHMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DEF0", Offset = "0x6F0CAF0", VA = "0x186F0DEF0")]
	public void FEHOKBLMJPE(MJLLOGCLAHK.KOILCJIOKNP KKIFBMFOGLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E470", Offset = "0x6F0D070", VA = "0x186F0E470")]
	private MJLLOGCLAHK PNPBOFGNLHL(byte NHHNPPKPBIA, MJLLOGCLAHK.OPMMNHJPGMG KDIGJFOIKJP, MJLLOGCLAHK ONIJEEBBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E010", Offset = "0x6F0CC10", VA = "0x186F0E010")]
	private void IFADBHFFDNE(MJLLOGCLAHK ONIJEEBBCHK, Vector2[] MEKPDIJBFHD, int CILMBPKFFCE, int EAFEPBDFDIM, int GJJEPMBFAAA, int OPFCBHMHGAL, float LPFICPPOAOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MJLLOGCLAHK
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public enum OPMMNHJPGMG
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum KOILCJIOKNP
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
	public byte FKAHMJGAGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 PNELKCHEAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3 NPEKKJBJFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3 JBCADIHHLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 EBPPKLNOGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public OPMMNHJPGMG CCPNOJKNAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public MJLLOGCLAHK PANFGPHKOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public List<MJLLOGCLAHK> LAJEILDOCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool JHBAPHFFLAF;

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0DA50", Offset = "0x6F0C650", VA = "0x186F0DA50")]
	public MJLLOGCLAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D9F0", Offset = "0x6F0C5F0", VA = "0x186F0D9F0")]
	public MJLLOGCLAHK(byte EDPPELMHBFA, OPMMNHJPGMG KDIGJFOIKJP, MJLLOGCLAHK ONIJEEBBCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D6B0", Offset = "0x6F0C2B0", VA = "0x186F0D6B0")]
	public void ANNGLPCKBKA(MJLLOGCLAHK PIKIEEICNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public void FEHOKBLMJPE(int KBFDDKIHGJG, KOILCJIOKNP KKIFBMFOGLE, int HMAPHJEJDII = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D770", Offset = "0x6F0C370", VA = "0x186F0D770")]
	public void ICCMCFLBNJE(List<byte> BEEKMCIHMLL, Vector3 NABPHMOHNDG, float DDHPBADLENH, float JNFDEPAMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D650", Offset = "0x6F0C250", VA = "0x186F0D650")]
	public bool ADHBNDPDEMC(Vector3 DBMHGAAIFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D9B0", Offset = "0x6F0C5B0", VA = "0x186F0D9B0")]
	public bool IFFGLHKMHOG(Vector3 DBMHGAAIFOA, float OMLGCLHOMLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class PELPFEPHMAD<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly Stack<T> IJBEJNBKLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<T> INABOCOMNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly int MIFKLGGGFMB;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int MLOGCOBMICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1C745E0", Offset = "0x1C731E0", VA = "0x181C745E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int ANAACLAKIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2608440", Offset = "0x2607040", VA = "0x182608440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x3A769E0", Offset = "0x3A755E0", VA = "0x183A769E0")]
	public static PELPFEPHMAD<T> BAFOHBINEOF(int CABFJBCMJEP = 0, int MIFKLGGGFMB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x3A76C60", Offset = "0x3A75860", VA = "0x183A76C60")]
	public static PELPFEPHMAD<T> GGJPEOJFGOE(int CABFJBCMJEP = 0, int MIFKLGGGFMB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x3A77350", Offset = "0x3A75F50", VA = "0x183A77350")]
	public PELPFEPHMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x3A771C0", Offset = "0x3A75DC0", VA = "0x183A771C0")]
	public PELPFEPHMAD(int CABFJBCMJEP, int MIFKLGGGFMB = int.MaxValue, bool LENKKJLEHGG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x3A76D30", Offset = "0x3A75930", VA = "0x183A76D30")]
	public T HOMPIJPBAAK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x3A76BC0", Offset = "0x3A757C0", VA = "0x183A76BC0")]
	public void GCNLFMGFLMB(T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x3A76E40", Offset = "0x3A75A40", VA = "0x183A76E40")]
	private void JPPJPDMPFBO(T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x3A76BA0", Offset = "0x3A757A0", VA = "0x183A76BA0")]
	private void FLIPLIMLBHB(T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A770B0", Offset = "0x3A75CB0", VA = "0x183A770B0")]
	[Conditional("DEBUG_BUILD")]
	private void LIPHCFDHODM(T PECELBJIIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A77130", Offset = "0x3A75D30", VA = "0x183A77130")]
	[Conditional("DEBUG_BUILD")]
	private void NJPCOOFGIDN(T PECELBJIIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A76AB0", Offset = "0x3A756B0", VA = "0x183A76AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A76F10", Offset = "0x3A75B10", VA = "0x183A76F10")]
	private void LHHFPKAJLKC(IEnumerable<T> EFLCMDHDGNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class MENGMGNCHAD
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private enum MOEANLDJBFP : byte
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
	private int DKKDLHLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private bool DKEIPANPPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private MOEANLDJBFP LLBKKANHBEL;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DGAPNEIIHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F0CBD0", Offset = "0x6F0B7D0", VA = "0x186F0CBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool JBKFDKKFIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C790", Offset = "0x6F0B390", VA = "0x186F0C790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D610", Offset = "0x6F0C210", VA = "0x186F0D610")]
	public MENGMGNCHAD(bool DKEIPANPPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CD40", Offset = "0x6F0B940", VA = "0x186F0CD40")]
	public void MHGICPEJBKI(object HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CCA0", Offset = "0x6F0B8A0", VA = "0x186F0CCA0")]
	public void LNLODCAJFHL(int ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CC90", Offset = "0x6F0B890", VA = "0x186F0CC90")]
	public void KMFGLNICOCG(uint LMBKKGHKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D430", Offset = "0x6F0C030", VA = "0x186F0D430")]
	public void MNGIKHHHMNH(bool ICCLFAJGICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CBE0", Offset = "0x6F0B7E0", VA = "0x186F0CBE0")]
	public void HPKJALIKPBO(long EMIHEDBEOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CB10", Offset = "0x6F0B710", VA = "0x186F0CB10")]
	public void EICJDPNCLCN(ulong PEMMBHLEMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CC20", Offset = "0x6F0B820", VA = "0x186F0CC20")]
	public void KKOBPEEALOP(string EIJFOGFJFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D450", Offset = "0x6F0C050", VA = "0x186F0D450")]
	public void MNLNBHNMAGF(Enum KIEMAGPGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D4E0", Offset = "0x6F0C0E0", VA = "0x186F0D4E0")]
	public void NGCBDFBKNCC(IList IFADMANLNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x26792F0", Offset = "0x2677EF0", VA = "0x1826792F0")]
	public void MNLMDMKNKPH<T, U>(Dictionary<T, U> HFKHBPEFOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C7A0", Offset = "0x6F0B3A0", VA = "0x186F0C7A0")]
	private void DDCMKJDKNOK(IDictionary HFKHBPEFOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CB60", Offset = "0x6F0B760", VA = "0x186F0CB60")]
	public int GGAILEDDGEJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F0D3C0", Offset = "0x6F0BFC0", VA = "0x186F0D3C0")]
	public short MLFCMGHNNBG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F0CB50", Offset = "0x6F0B750", VA = "0x186F0CB50")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C720", Offset = "0x6F0B320", VA = "0x186F0C720")]
	private void AIIBHFDFMLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface FNNMNCCHNGH
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class ResourcePrefabReference<T> : FNNMNCCHNGH where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2F397F0", Offset = "0x2F383F0", VA = "0x182F397F0", Slot = "4")]
		public virtual T EJDINAAHLDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class ODDMALFOGNH<T> : IEnumerable<ODDMALFOGNH<T>.DANOALJMLDD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public struct DANOALJMLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public T ECNGHFJBIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public int NHHNPPKPBIA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class KJPLOPMDGMN : IEnumerator<DANOALJMLDD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private ODDMALFOGNH<T> GNJLJGGMKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private int NHHNPPKPBIA;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x14FCF20", Offset = "0x14FBB20", VA = "0x1814FCF20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public DANOALJMLDD NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x2C468F0", Offset = "0x2C454F0", VA = "0x182C468F0", Slot = "4")]
			get
			{
				return default(DANOALJMLDD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x91C920", Offset = "0x91B520", VA = "0x18091C920")]
		public KJPLOPMDGMN(ODDMALFOGNH<T> GNJLJGGMKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C467F0", Offset = "0x2C453F0", VA = "0x182C467F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x91C910", Offset = "0x91B510", VA = "0x18091C910", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xE4C8E0", Offset = "0xE4B4E0", VA = "0x180E4C8E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private struct BGNGHKPBDPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public bool IOMDHHNPFPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public T ECNGHFJBIJL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private const int GEFPLMHDKPO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly Dictionary<T, int> KDKMLBIHINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private BGNGHKPBDPO[] JBBDGCLGNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int POAAGMGMFLG;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int ACPNKHONGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8436A0", Offset = "0x8422A0", VA = "0x1808436A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA35F40", Offset = "0xA34B40", VA = "0x180A35F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA650", Offset = "0x1FB9250", VA = "0x181FBA650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4878D80", Offset = "0x4877980", VA = "0x184878D80")]
	public ODDMALFOGNH(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4878990", Offset = "0x4877590", VA = "0x184878990")]
	public ODDMALFOGNH(DANOALJMLDD[] LMHLDELFGFA, bool BFBLJDNFJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4877B40", Offset = "0x4876740", VA = "0x184877B40")]
	public int HKMEJEIBDMP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x48782B0", Offset = "0x4876EB0", VA = "0x1848782B0")]
	private int MCIKOHNCKFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x48784E0", Offset = "0x48770E0", VA = "0x1848784E0", Slot = "6")]
	protected virtual uint NOOACFKFHCM(uint DKKDLHLFHOF, T ECNGHFJBIJL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x48776B0", Offset = "0x48762B0", VA = "0x1848776B0")]
	public bool EJCEIGEMLDE(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x4878020", Offset = "0x4876C20", VA = "0x184878020")]
	public bool LKGBCPBLPKL(int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x4878500", Offset = "0x4877100", VA = "0x184878500")]
	public bool ODOLPHCGINH(Func<T, bool> GPMFMCCDAKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x4878690", Offset = "0x4877290", VA = "0x184878690")]
	public int OKNGNIBBBIN(T ECNGHFJBIJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4877820", Offset = "0x4876420", VA = "0x184877820")]
	public T GCHGIFGBMBE(int NHHNPPKPBIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x48776F0", Offset = "0x48762F0", VA = "0x1848776F0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x4877BB0", Offset = "0x48767B0", VA = "0x184877BB0")]
	public bool JCOHIHLGEAI(T ECNGHFJBIJL, bool MBBKNCOABPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x4877E20", Offset = "0x4876A20", VA = "0x184877E20")]
	public bool JCOHIHLGEAI(T ECNGHFJBIJL, int NHHNPPKPBIA, bool MBBKNCOABPJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x4877620", Offset = "0x4876220", VA = "0x184877620")]
	public bool CPPHPNNFPKL(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x4877770", Offset = "0x4876370", VA = "0x184877770")]
	public bool FLLDAADPLON(int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x4878740", Offset = "0x4877340", VA = "0x184878740")]
	private void PLKEILCEGJN(int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x4877A00", Offset = "0x4876600", VA = "0x184877A00")]
	public DANOALJMLDD[] GMJCFHAOGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x4877550", Offset = "0x4876150", VA = "0x184877550")]
	private int BNIANHFGIEL(int GOGKDEGLBIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x4878910", Offset = "0x4877510", VA = "0x184878910", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x4878910", Offset = "0x4877510", VA = "0x184878910", Slot = "4")]
	private IEnumerator<DANOALJMLDD> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
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
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x6F0EBF0", Offset = "0x6F0D7F0", VA = "0x186F0EBF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x6F0EE80", Offset = "0x6F0DA80", VA = "0x186F0EE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x6F0EDB0", Offset = "0x6F0D9B0", VA = "0x186F0EDB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x6F0EFE0", Offset = "0x6F0DBE0", VA = "0x186F0EFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6F0EB60", Offset = "0x6F0D760", VA = "0x186F0EB60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x6F0EDF0", Offset = "0x6F0D9F0", VA = "0x186F0EDF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x6F0ED20", Offset = "0x6F0D920", VA = "0x186F0ED20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F0EB00", Offset = "0x6F0D700", VA = "0x186F0EB00")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class PHHJDALPKOO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int CABFJBCMJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int AIHECMHOMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private List<T> CHCFPJJJGHE;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1C745E0", Offset = "0x1C731E0", VA = "0x181C745E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T FGBCPLCCPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x3A7CA70", Offset = "0x3A7B670", VA = "0x183A7CA70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T IHFHFPJDIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A7CA10", Offset = "0x3A7B610", VA = "0x183A7CA10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T IEFOFNHJPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A7C680", Offset = "0x3A7B280", VA = "0x183A7C680")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3A7CB80", Offset = "0x3A7B780", VA = "0x183A7CB80")]
	public PHHJDALPKOO(int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C7B0", Offset = "0x3A7B3B0", VA = "0x183A7C7B0")]
	public void CAILCKFFJIK(T PELNFFOMEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C890", Offset = "0x3A7B490", VA = "0x183A7C890")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C930", Offset = "0x3A7B530", VA = "0x183A7C930")]
	public void LGIJHOHKAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C8E0", Offset = "0x3A7B4E0", VA = "0x183A7C8E0")]
	public void KAHJOMCPNBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A7C8D0", Offset = "0x3A7B4D0", VA = "0x183A7C8D0")]
	public void GNNOECBFBEH()
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
		public struct AOIFHMHEOBD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private readonly List<Component> IFADMANLNLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private readonly bool NIIBMIPCAIP;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xDC4020", Offset = "0xDC2C20", VA = "0x180DC4020")]
			public AOIFHMHEOBD(List<Component> IFADMANLNLG, bool NIIBMIPCAIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x322A060", Offset = "0x3228C60", VA = "0x18322A060")]
			public ILPKPLJCBEG<T> MEOEHOBEEMI()
			{
				return default(ILPKPLJCBEG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x322A0D0", Offset = "0x3228CD0", VA = "0x18322A0D0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x322A0D0", Offset = "0x3228CD0", VA = "0x18322A0D0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct ILPKPLJCBEG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private readonly List<Component> IFADMANLNLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private readonly bool NIIBMIPCAIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private int NHHNPPKPBIA;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public T NIBFGHDNPCH
			{
				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x346D0B0", Offset = "0x346BCB0", VA = "0x18346D0B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x346D040", Offset = "0x346BC40", VA = "0x18346D040", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x346D080", Offset = "0x346BC80", VA = "0x18346D080")]
			public ILPKPLJCBEG(List<Component> IFADMANLNLG, bool NIIBMIPCAIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x346CF70", Offset = "0x346BB70", VA = "0x18346CF70", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x346CF80", Offset = "0x346BB80", VA = "0x18346CF80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2E688B0", Offset = "0x2E674B0", VA = "0x182E688B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F10C80", Offset = "0x6F0F880", VA = "0x186F10C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6F10C40", Offset = "0x6F0F840", VA = "0x186F10C40")]
		public ToolHierarchyCache(GameObject NBIMDBPEIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6F109D0", Offset = "0x6F0F5D0", VA = "0x186F109D0")]
		private void PBAELFIBGFO(GameObject NBIMDBPEIEO, bool HCKNDFMIDDI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F10B30", Offset = "0x6F0F730", VA = "0x186F10B30")]
		public static void PBAELFIBGFO(GameObject NBIMDBPEIEO, ref ToolHierarchyCache LFMIPHMBPFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6F103D0", Offset = "0x6F0EFD0", VA = "0x186F103D0")]
		public void ANPJJMKPGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6F10880", Offset = "0x6F0F480", VA = "0x186F10880")]
		public void GKIIAEKNGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E71C90", Offset = "0x1E70890", VA = "0x181E71C90")]
		public void EEAGIEBGMCO<T>(Action<T> FOGMDOMFJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x6F103E0", Offset = "0x6F0EFE0", VA = "0x186F103E0")]
		public Component DCCFLCNADKN(Type FIJCKHKKDCC, bool NIIBMIPCAIP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E71C10", Offset = "0x1E70810", VA = "0x181E71C10")]
		public T DCCFLCNADKN<T>(bool NIIBMIPCAIP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6F10950", Offset = "0x6F0F550", VA = "0x186F10950")]
		public AOIFHMHEOBD<Component> KAFLFGBEGNK(Type FIJCKHKKDCC, bool NIIBMIPCAIP = false)
		{
			return default(AOIFHMHEOBD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1E71F20", Offset = "0x1E70B20", VA = "0x181E71F20")]
		public AOIFHMHEOBD<T> KAFLFGBEGNK<T>(bool NIIBMIPCAIP = false) where T : class
		{
			return default(AOIFHMHEOBD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F104B0", Offset = "0x6F0F0B0", VA = "0x186F104B0")]
		public List<Component> ECLFANLFHCP(Type FIJCKHKKDCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6F10800", Offset = "0x6F0F400", VA = "0x186F10800", Slot = "4")]
		public bool Equals(ToolHierarchyCache OLGJDFCIILF, ToolHierarchyCache IKFJLOPMKHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F108D0", Offset = "0x6F0F4D0", VA = "0x186F108D0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HHNPCHNMLMA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class ONOCFLKCDJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Dictionary<int, T> BAOLHJKGDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private T JIJJCBMAPHG;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public virtual T FJMEJLGHOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9897A0", Offset = "0x9883A0", VA = "0x1809897A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool LKOPKHPHBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x489AF30", Offset = "0x4899B30", VA = "0x18489AF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x489ACA0", Offset = "0x48998A0", VA = "0x18489ACA0")]
	public bool JKMEINBJGBN(T ECNGHFJBIJL, int KPEDMKNLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x29BC2E0", Offset = "0x29BAEE0", VA = "0x1829BC2E0")]
	public bool CBLDDCBDCPG(int KPEDMKNLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x489A830", Offset = "0x4899430", VA = "0x18489A830")]
	public T BKLJFFBODNE(int ILGDIFFHGJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x489AC40", Offset = "0x4899840", VA = "0x18489AC40")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x489AD90", Offset = "0x4899990", VA = "0x18489AD90")]
	private bool KOEJMAALIAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x489AD60", Offset = "0x4899960", VA = "0x18489AD60")]
	public bool KFBGNHHGLGM(int KPEDMKNLCKL, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x489AF70", Offset = "0x4899B70", VA = "0x18489AF70")]
	public ONOCFLKCDJK()
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
			[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F1E20", VA = "0x1807F3220")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public T this[int OCIFJAIBHIA, int BJBICJAGAJI]
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x447A140", Offset = "0x4478D40", VA = "0x18447A140")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x447A1E0", Offset = "0x4478DE0", VA = "0x18447A1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x447A0B0", Offset = "0x4478CB0", VA = "0x18447A0B0")]
		public Array2D(uint JJJHCGPEBDK, uint BABILIHBNMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x447A030", Offset = "0x4478C30", VA = "0x18447A030")]
		public void ELJLHOEKJGC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6F09A80", Offset = "0x6F08680", VA = "0x186F09A80")]
		public Array2DVector3(uint JJJHCGPEBDK, uint BABILIHBNMO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class EKNDDHLLNAF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	internal class NADDEJFHFCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public TNode GPOCLJBKMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TNode ONIJEEBBCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public DDHKABKFEAN IAHKGFLACPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public List<DDHKABKFEAN> ANODFGDANPC;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
		public NADDEJFHFCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	internal struct DDHKABKFEAN : IComparable<DDHKABKFEAN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int KPEDMKNLCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public TClaimant EGEEGBMEGLE;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x84D9C0", Offset = "0x84C5C0", VA = "0x18084D9C0")]
		public DDHKABKFEAN(int KPEDMKNLCKL, TClaimant EGEEGBMEGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x3A1FD90", Offset = "0x3A1E990", VA = "0x183A1FD90")]
		public bool GPEADCLPDIN(in DDHKABKFEAN MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3A1FDF0", Offset = "0x3A1E9F0", VA = "0x183A1FDF0")]
		public bool KEJEEAFEICO(in DDHKABKFEAN MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3A1FD80", Offset = "0x3A1E980", VA = "0x183A1FD80", Slot = "4")]
		public int CompareTo(DDHKABKFEAN MDHJAFNLPON)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3A1FE00", Offset = "0x3A1EA00", VA = "0x183A1FE00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum PGMBCHKEBLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class PJGPCMCEMPE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public EKNDDHLLNAF<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1FC23F0", Offset = "0x1FC0FF0", VA = "0x181FC23F0")]
		[DebuggerHidden]
		public PJGPCMCEMPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x42EBA90", Offset = "0x42EA690", VA = "0x1842EBA90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x42EBC50", Offset = "0x42EA850", VA = "0x1842EBC50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x42EBB70", Offset = "0x42EA770", VA = "0x1842EBB70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE870", Offset = "0x1FBD470", VA = "0x181FBE870", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly PELPFEPHMAD<NADDEJFHFCO> EELCAEBOFFM;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly PELPFEPHMAD<List<DDHKABKFEAN>> MFEGPLFNDDJ;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int CHBMPNJIEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	internal readonly Dictionary<TClaimant, TNode> HGCNNOPPNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	internal readonly Dictionary<TNode, NADDEJFHFCO> IJEMPJFPEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private PGMBCHKEBLI JBENBACJFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private bool FNDAICJNELC;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DMFKJLCKIIE(TNode KGOMINCBAMA);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CHIPGINFBJC(TNode KGOMINCBAMA, TClaimant PJOIPLFMOAI, TClaimant CALJEIEACGE);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3299810", Offset = "0x3298410", VA = "0x183299810")]
	public EKNDDHLLNAF(PGMBCHKEBLI JBENBACJFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3298940", Offset = "0x3297540", VA = "0x183298940")]
	public void FKGJDDAEGLK(TNode KGOMINCBAMA, TNode PBNMPICADBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3299230", Offset = "0x3297E30", VA = "0x183299230")]
	public void JPCDDCFOIGI(TClaimant EGEEGBMEGLE, TNode CLJGCEOPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3298330", Offset = "0x3296F30", VA = "0x183298330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3298180", Offset = "0x3296D80", VA = "0x183298180")]
	private void CPAJAOFAAFJ(TClaimant EGEEGBMEGLE, TNode POMMEIPFPHP, TNode CLJGCEOPLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3298C10", Offset = "0x3297810", VA = "0x183298C10")]
	private int HEJMHANDCGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3299330", Offset = "0x3297F30", VA = "0x183299330")]
	private void KHCOABMANLN(TClaimant EGEEGBMEGLE, TNode IMPGKOHBIPN, TNode ILLJGBKEOAD, int BMIEHFOKELI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3298FE0", Offset = "0x3297BE0", VA = "0x183298FE0")]
	private void IMBAJJGHDCD(DDHKABKFEAN OPJLAOONFEH, NADDEJFHFCO OHMGDMICHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3298C70", Offset = "0x3297870", VA = "0x183298C70")]
	private void HPBCIBBKMPL(TClaimant EGEEGBMEGLE, TNode IMPGKOHBIPN, TNode ILLJGBKEOAD, int BMIEHFOKELI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3298220", Offset = "0x3296E20", VA = "0x183298220")]
	private void DFCGKHFBIDA(DDHKABKFEAN OPJLAOONFEH, TNode KGOMINCBAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x3298080", Offset = "0x3296C80", VA = "0x183298080")]
	private void COLCFPHPLDE(DDHKABKFEAN OPJLAOONFEH, NADDEJFHFCO OHMGDMICHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x3298ED0", Offset = "0x3297AD0", VA = "0x183298ED0")]
	private void IHILHNKOHNP(NADDEJFHFCO OHMGDMICHJP, bool BGGLIBKOBCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x3298590", Offset = "0x3297190", VA = "0x183298590")]
	private void FFFEOJFGAIG(NADDEJFHFCO OHMGDMICHJP, TNode PBNMPICADBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x32995E0", Offset = "0x32981E0", VA = "0x1832995E0")]
	[IteratorStateMachine(typeof(EKNDDHLLNAF<, >.PJGPCMCEMPE))]
	private IEnumerable<TNode> MNIDAKMNMJF(TNode IMPGKOHBIPN, TNode ILLJGBKEOAD, bool KFHLMAACNGD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3298B50", Offset = "0x3297750", VA = "0x183298B50")]
	private NADDEJFHFCO GDCGDMODFFD(TNode KGOMINCBAMA, TNode ONIJEEBBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x32989C0", Offset = "0x32975C0", VA = "0x1832989C0")]
	private NADDEJFHFCO GANJBHGFBOM(TNode KGOMINCBAMA, TNode ONIJEEBBCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3299070", Offset = "0x3297C70", VA = "0x183299070")]
	private void JBDCLPHMMEJ(NADDEJFHFCO OHMGDMICHJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class EIIPLGIKDAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	protected struct FMBOLLOJHGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T MHGNIJCIFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int FEBAPKLGMEF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<FMBOLLOJHGO> FFPFEFDNOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T AHKMPCAKAAP;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1FBA650", Offset = "0x1FB9250", VA = "0x181FBA650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x328E480", Offset = "0x328D080", VA = "0x18328E480")]
	public bool ODOLPHCGINH(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x328DFC0", Offset = "0x328CBC0", VA = "0x18328DFC0")]
	public void CAILCKFFJIK(T ECNGHFJBIJL, int KPEDMKNLCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x328E0D0", Offset = "0x328CCD0", VA = "0x18328E0D0")]
	public bool CPPHPNNFPKL(T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x328E1F0", Offset = "0x328CDF0", VA = "0x18328E1F0")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x328E060", Offset = "0x328CC60", VA = "0x18328E060")]
	public T CNIMANKOCJI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x328E250", Offset = "0x328CE50", VA = "0x18328E250")]
	public T GJLDCBJIJID()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x328E2C0", Offset = "0x328CEC0", VA = "0x18328E2C0")]
	private void LPOKGMLFAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x328E690", Offset = "0x328D290", VA = "0x18328E690")]
	public EIIPLGIKDAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class IGKFDGODDKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct LFPCENABHOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int FEBAPKLGMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public T MHGNIJCIFFL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<object, LFPCENABHOB> BAOLHJKGDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly EqualityComparer<T> EPMCDJFENIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private T JIJJCBMAPHG;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public virtual T FJMEJLGHOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1C79960", Offset = "0x1C78560", VA = "0x181C79960", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1C79A80", Offset = "0x1C78680", VA = "0x181C79A80", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool LKOPKHPHBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1C7E9F0", Offset = "0x1C7D5F0", VA = "0x181C7E9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public object IGIAPBEOOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x88FE20", Offset = "0x88EA20", VA = "0x18088FE20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1C79B00", Offset = "0x1C78700", VA = "0x181C79B00")]
	public bool JKMEINBJGBN(T ECNGHFJBIJL, object FLDJLPKNKKO, int KPEDMKNLCKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x1C798D0", Offset = "0x1C784D0", VA = "0x181C798D0")]
	public bool CBLDDCBDCPG(object FLDJLPKNKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1C7A890", Offset = "0x1C79490", VA = "0x181C7A890")]
	public bool KFBGNHHGLGM(object FLDJLPKNKKO, out T ECNGHFJBIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1C79A20", Offset = "0x1C78620", VA = "0x181C79A20")]
	public void ELJLHOEKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1C7C9D0", Offset = "0x1C7B5D0", VA = "0x181C7C9D0")]
	private bool KOEJMAALIAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1C7EA20", Offset = "0x1C7D620", VA = "0x181C7EA20")]
	public IGKFDGODDKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class EDOHCHPDFEG
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B3E0", Offset = "0x6F09FE0", VA = "0x186F0B3E0")]
	public static void AEJPPLPBPDK(FMDOKKBAPOM AOCJDBLPGHC, string ALGKPJEIDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010")]
	public static void AEJPPLPBPDK(IEnumerable<object> APMAFHMKLGB, string ALGKPJEIDOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class FGBDFJACAML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private bool DGJLKLLEJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private Action FOGMDOMFJBB;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public static FGBDFJACAML LNLMHDNBOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B750", Offset = "0x6F0A350", VA = "0x186F0B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool BCIDLILPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CB0", Offset = "0x7F48B0", VA = "0x1807F5CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B7D0", Offset = "0x6F0A3D0", VA = "0x186F0B7D0")]
	public FGBDFJACAML(Action FOGMDOMFJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B730", Offset = "0x6F0A330", VA = "0x186F0B730")]
	public void KOGMCNBOFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0B730", Offset = "0x6F0A330", VA = "0x186F0B730", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class JPPAIIMIMHD : PKHKKGNCOIB
{
	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6F0C190", Offset = "0x6F0AD90", VA = "0x186F0C190")]
	public JPPAIIMIMHD(UnityEngine.Object ICENKGBLLMO)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
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
