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
		[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x841E20", Offset = "0x841020", VA = "0x180841E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99AF50", Offset = "0x99A150", VA = "0x18099AF50")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99AF10", Offset = "0x99A110", VA = "0x18099AF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "4")]
	public virtual void COFBKHMFBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
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
	[OFJEFHAIHLK]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7870", Offset = "0x3CB6A70", VA = "0x183CB7870", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CB6FD0", Offset = "0x3CB61D0", VA = "0x183CB6FD0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3CB7DA0", Offset = "0x3CB6FA0", VA = "0x183CB7DA0")]
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
	private sealed class OJGJPDGLMAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public OJGJPDGLMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3E3AFC0", Offset = "0x3E3A1C0", VA = "0x183E3AFC0")]
		internal int ABDHDKOEELH(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[OFJEFHAIHLK]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1918DC0", Offset = "0x1917FC0", VA = "0x181918DC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1918DF0", Offset = "0x1917FF0", VA = "0x181918DF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1918D10", Offset = "0x1917F10", VA = "0x181918D10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TVal this[TKey PPNIGBBPGOI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1918D70", Offset = "0x1917F70", VA = "0x181918D70", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1918C10", Offset = "0x1917E10", VA = "0x181918C10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1918730", Offset = "0x1917930", VA = "0x181918730", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1917F50", Offset = "0x1917150", VA = "0x181917F50", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1917BD0", Offset = "0x1916DD0", VA = "0x181917BD0", Slot = "14")]
	protected virtual string JLMKNHBJLOP(TKeyVal FLCHOPDKNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1917AE0", Offset = "0x1916CE0", VA = "0x181917AE0", Slot = "4")]
	public bool ContainsKey(TKey PPNIGBBPGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1918AF0", Offset = "0x1917CF0", VA = "0x181918AF0", Slot = "5")]
	public bool TryGetValue(TKey PPNIGBBPGOI, out TVal ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1917B10", Offset = "0x1916D10", VA = "0x181917B10", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1917B10", Offset = "0x1916D10", VA = "0x181917B10", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1918B20", Offset = "0x1917D20", VA = "0x181918B20")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KCMLBGDKGGI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BCOBLGBBNFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public BCOBLGBBNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4443130", Offset = "0x4442330", VA = "0x184443130")]
		internal bool IMHKFAIBDMF(CKOLBNLDHJH<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float PFDLIFGNDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float BBBPDCNPPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<CKOLBNLDHJH<float, T>> JLJPBONODCI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int KKMDFLHFBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE390", Offset = "0x2DCD590", VA = "0x182DCE390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE970", Offset = "0x2DCDB70", VA = "0x182DCE970")]
	public KCMLBGDKGGI(float DJFMMKLANCP, float NFAPCHJCMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE4D0", Offset = "0x2DCD6D0", VA = "0x182DCE4D0")]
	public bool MCAKCKODKNE(float LNBMFKNJEDF, T ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE300", Offset = "0x2DCD500", VA = "0x182DCE300")]
	public int ALADNLMPBFN(float LNBMFKNJEDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE630", Offset = "0x2DCD830", VA = "0x182DCE630")]
	public IEnumerable<T> MLHDGINMCJP(float LNBMFKNJEDF, [Optional] float? AGGDDAPOIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE360", Offset = "0x2DCD560", VA = "0x182DCE360")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2DCE410", Offset = "0x2DCD610", VA = "0x182DCE410")]
	private void GBNKJJKGEKC(float LNBMFKNJEDF)
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
	public T IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x44D30E0", Offset = "0x44D22E0", VA = "0x1844D30E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x44D30D0", Offset = "0x44D22D0", VA = "0x1844D30D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float ELPHJKOHFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x10F69B0", Offset = "0x10F5BB0", VA = "0x1810F69B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x44D2D20", Offset = "0x44D1F20", VA = "0x1844D2D20")]
	public T DHIMIFJJNDF(float NIKDBMNECCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x44D3040", Offset = "0x44D2240", VA = "0x1844D3040")]
	public T FMHMHHCLIFI(float NIKDBMNECCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NNFNIDCMBDE(T JFHIJPMPOBA, T LPNFMADJDAF, float NIKDBMNECCB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA450", Offset = "0x3ED9650", VA = "0x183EDA450", Slot = "4")]
	protected override float NNFNIDCMBDE(float JFHIJPMPOBA, float LPNFMADJDAF, float NIKDBMNECCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7050800", Offset = "0x704FA00", VA = "0x187050800")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2779C80", Offset = "0x2778E80", VA = "0x182779C80", Slot = "4")]
	protected override Vector3 NNFNIDCMBDE(Vector3 JFHIJPMPOBA, Vector3 LPNFMADJDAF, float NIKDBMNECCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7055B20", Offset = "0x7054D20", VA = "0x187055B20")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x151BB80", Offset = "0x151AD80", VA = "0x18151BB80", Slot = "4")]
	protected override Color NNFNIDCMBDE(Color JFHIJPMPOBA, Color LPNFMADJDAF, float NIKDBMNECCB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7050140", Offset = "0x704F340", VA = "0x187050140")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PMMGJOONIHJ
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EDHDBGNKLHM<T1, T2> : IEnumerable<CKOLBNLDHJH<T1, T2>>, IEnumerable, IEnumerator<CKOLBNLDHJH<T1, T2>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CKOLBNLDHJH<T1, T2> <>2__current;

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
		CKOLBNLDHJH<T1, T2> IEnumerator<Tuple<T1, T2>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2A070F0", Offset = "0x2A062F0", VA = "0x182A070F0")]
		[DebuggerHidden]
		public EDHDBGNKLHM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x447BAF0", Offset = "0x447ACF0", VA = "0x18447BAF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x447BDA0", Offset = "0x447AFA0", VA = "0x18447BDA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2DC6590", Offset = "0x2DC5790", VA = "0x182DC6590", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<CKOLBNLDHJH<T1, T2>> IEnumerable<Tuple<T1, T2>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2DC6650", Offset = "0x2DC5850", VA = "0x182DC6650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IFBCKKJNILP<T1, T2, T3> : IEnumerable<AAJKANLFLKD<T1, T2, T3>>, IEnumerable, IEnumerator<AAJKANLFLKD<T1, T2, T3>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private AAJKANLFLKD<T1, T2, T3> <>2__current;

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
		AAJKANLFLKD<T1, T2, T3> IEnumerator<Tuple<T1, T2, T3>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2A070F0", Offset = "0x2A062F0", VA = "0x182A070F0")]
		[DebuggerHidden]
		public IFBCKKJNILP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2A06BA0", Offset = "0x2A05DA0", VA = "0x182A06BA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2A070B0", Offset = "0x2A062B0", VA = "0x182A070B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2A06FB0", Offset = "0x2A061B0", VA = "0x182A06FB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<AAJKANLFLKD<T1, T2, T3>> IEnumerable<Tuple<T1, T2, T3>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2A07080", Offset = "0x2A06280", VA = "0x182A07080", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x268FC40", Offset = "0x268EE40", VA = "0x18268FC40")]
	public static EKHKPOABGMA<T1> LNIGJBIDADO<T1>(T1 FANHPJOKIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4302290", Offset = "0x4301490", VA = "0x184302290")]
	public static CKOLBNLDHJH<T1, T2> LNIGJBIDADO<T1, T2>(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4302300", Offset = "0x4301500", VA = "0x184302300")]
	public static AAJKANLFLKD<T1, T2, T3> LNIGJBIDADO<T1, T2, T3>(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEC30", Offset = "0x2AFDE30", VA = "0x182AFEC30")]
	public static GEMAMMIFMDJ<T1, T2, T3, T4> LNIGJBIDADO<T1, T2, T3, T4>(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3515790", Offset = "0x3514990", VA = "0x183515790")]
	public static NIEIIKFJGAB<T1, T2, T3, T4, T5> LNIGJBIDADO<T1, T2, T3, T4, T5>(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA, T5 CLODBNEMKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4302520", Offset = "0x4301720", VA = "0x184302520")]
	public static BECHMPKPBNF<T1, T2, T3, T4, T5, T6> LNIGJBIDADO<T1, T2, T3, T4, T5, T6>(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA, T5 CLODBNEMKJL, T6 BHPEMEJILMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4302460", Offset = "0x4301660", VA = "0x184302460")]
	public static BPIEGKKCKAM<T1, T2, T3, T4, T5, T6, T7> LNIGJBIDADO<T1, T2, T3, T4, T5, T6, T7>(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA, T5 CLODBNEMKJL, T6 BHPEMEJILMA, T7 LHLIELAODMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4302390", Offset = "0x4301590", VA = "0x184302390")]
	public static LHAEBHFJPKF<T1, T2, T3, T4, T5, T6, T7, T8> LNIGJBIDADO<T1, T2, T3, T4, T5, T6, T7, T8>(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA, T5 CLODBNEMKJL, T6 BHPEMEJILMA, T7 LHLIELAODMK, T8 EJGHKFHLLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27D6980", Offset = "0x27D5B80", VA = "0x1827D6980")]
	[IteratorStateMachine(typeof(EDHDBGNKLHM<, >))]
	public static IEnumerable<CKOLBNLDHJH<T1, T2>> HGOFAFPDKMD<T1, T2>(IEnumerable<T1> KCJELMMMDCA, IEnumerable<T2> NMKMEIDKGEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27D6A20", Offset = "0x27D5C20", VA = "0x1827D6A20")]
	[IteratorStateMachine(typeof(IFBCKKJNILP<, , >))]
	public static IEnumerable<AAJKANLFLKD<T1, T2, T3>> HGOFAFPDKMD<T1, T2, T3>(IEnumerable<T1> KCJELMMMDCA, IEnumerable<T2> NMKMEIDKGEO, IEnumerable<T3> AODGGHOKMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7053710", Offset = "0x7052910", VA = "0x187053710")]
	internal static int FGPHNMOAFLI(int LBNDFCFDFCI, int KMLCPJLCDMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7053700", Offset = "0x7052900", VA = "0x187053700")]
	internal static int FGPHNMOAFLI(int LBNDFCFDFCI, int KMLCPJLCDMM, int BKGOOKBENDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70536E0", Offset = "0x70528E0", VA = "0x1870536E0")]
	internal static int FGPHNMOAFLI(int LBNDFCFDFCI, int KMLCPJLCDMM, int BKGOOKBENDB, int JIIDHDFOLOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7053690", Offset = "0x7052890", VA = "0x187053690")]
	internal static int FGPHNMOAFLI(int LBNDFCFDFCI, int KMLCPJLCDMM, int BKGOOKBENDB, int JIIDHDFOLOC, int DLNNFAMAABA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x70536B0", Offset = "0x70528B0", VA = "0x1870536B0")]
	internal static int FGPHNMOAFLI(int LBNDFCFDFCI, int KMLCPJLCDMM, int BKGOOKBENDB, int JIIDHDFOLOC, int DLNNFAMAABA, int LIJBBDMDLFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7053720", Offset = "0x7052920", VA = "0x187053720")]
	internal static int FGPHNMOAFLI(int LBNDFCFDFCI, int KMLCPJLCDMM, int BKGOOKBENDB, int JIIDHDFOLOC, int DLNNFAMAABA, int LIJBBDMDLFF, int MBMNINCCEIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7053660", Offset = "0x7052860", VA = "0x187053660")]
	internal static int FGPHNMOAFLI(int LBNDFCFDFCI, int KMLCPJLCDMM, int BKGOOKBENDB, int JIIDHDFOLOC, int DLNNFAMAABA, int LIJBBDMDLFF, int MBMNINCCEIC, int GHOEOGGHOGG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EKHKPOABGMA<T1> : IComparable<EKHKPOABGMA<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T1 FJLMANHEPEN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC600", Offset = "0x1CCB800", VA = "0x181CCC600")]
	public EKHKPOABGMA(T1 FANHPJOKIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36697D0", Offset = "0x36689D0", VA = "0x1836697D0", Slot = "4")]
	public int CompareTo(EKHKPOABGMA<T1> HPOECFLNEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3669840", Offset = "0x3668A40", VA = "0x183669840", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA37810", Offset = "0xA36A10", VA = "0x180A37810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x36698E0", Offset = "0x3668AE0", VA = "0x1836698E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CKOLBNLDHJH<T1, T2> : IComparable<CKOLBNLDHJH<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T1 FJLMANHEPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T2 AKPAEEJCELD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2F83160", Offset = "0x2F82360", VA = "0x182F83160")]
	public CKOLBNLDHJH(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A530", Offset = "0x3F59730", VA = "0x183F5A530", Slot = "4")]
	public int CompareTo(CKOLBNLDHJH<T1, T2> HPOECFLNEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A830", Offset = "0x3F59A30", VA = "0x183F5A830", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F5B490", Offset = "0x3F5A690", VA = "0x183F5B490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F5BF70", Offset = "0x3F5B170", VA = "0x183F5BF70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AAJKANLFLKD<T1, T2, T3> : IComparable<AAJKANLFLKD<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly T1 FJLMANHEPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly T2 AKPAEEJCELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T3 IOAGKOCEIIE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x42DAAE0", Offset = "0x42D9CE0", VA = "0x1842DAAE0")]
	public AAJKANLFLKD(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x42DA3A0", Offset = "0x42D95A0", VA = "0x1842DA3A0", Slot = "4")]
	public int CompareTo(AAJKANLFLKD<T1, T2, T3> HPOECFLNEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x42DA4A0", Offset = "0x42D96A0", VA = "0x1842DA4A0", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x42DA7C0", Offset = "0x42D99C0", VA = "0x1842DA7C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x42DA930", Offset = "0x42D9B30", VA = "0x1842DA930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GEMAMMIFMDJ<T1, T2, T3, T4> : IComparable<GEMAMMIFMDJ<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 FJLMANHEPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T2 AKPAEEJCELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T3 IOAGKOCEIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T4 PJGBPPGIPBG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3132900", Offset = "0x3131B00", VA = "0x183132900")]
	public GEMAMMIFMDJ(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3EE71F0", Offset = "0x3EE63F0", VA = "0x183EE71F0", Slot = "4")]
	public int CompareTo(GEMAMMIFMDJ<T1, T2, T3, T4> HPOECFLNEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7330", Offset = "0x3EE6530", VA = "0x183EE7330", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7470", Offset = "0x3EE6670", VA = "0x183EE7470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3EE7530", Offset = "0x3EE6730", VA = "0x183EE7530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NIEIIKFJGAB<T1, T2, T3, T4, T5> : IComparable<NIEIIKFJGAB<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T1 FJLMANHEPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T2 AKPAEEJCELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T3 IOAGKOCEIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T4 PJGBPPGIPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T5 ODJIBEICMHJ;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2F68B50", Offset = "0x2F67D50", VA = "0x182F68B50")]
	public NIEIIKFJGAB(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA, T5 CLODBNEMKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2F68610", Offset = "0x2F67810", VA = "0x182F68610", Slot = "4")]
	public int CompareTo(NIEIIKFJGAB<T1, T2, T3, T4, T5> HPOECFLNEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2F68790", Offset = "0x2F67990", VA = "0x182F68790", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2F68900", Offset = "0x2F67B00", VA = "0x182F68900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2F68A00", Offset = "0x2F67C00", VA = "0x182F68A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BECHMPKPBNF<T1, T2, T3, T4, T5, T6> : IComparable<BECHMPKPBNF<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T1 FJLMANHEPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T2 AKPAEEJCELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T3 IOAGKOCEIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T4 PJGBPPGIPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T5 ODJIBEICMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T6 NBKMEBLANFA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x387FD40", Offset = "0x387EF40", VA = "0x18387FD40")]
	public BECHMPKPBNF(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA, T5 CLODBNEMKJL, T6 BHPEMEJILMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4446EF0", Offset = "0x44460F0", VA = "0x184446EF0", Slot = "4")]
	public int CompareTo(BECHMPKPBNF<T1, T2, T3, T4, T5, T6> HPOECFLNEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x44470B0", Offset = "0x44462B0", VA = "0x1844470B0", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4447240", Offset = "0x4446440", VA = "0x184447240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4447360", Offset = "0x4446560", VA = "0x184447360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BPIEGKKCKAM<T1, T2, T3, T4, T5, T6, T7> : IComparable<BPIEGKKCKAM<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 FJLMANHEPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 AKPAEEJCELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 IOAGKOCEIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 PJGBPPGIPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 ODJIBEICMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 NBKMEBLANFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T7 GLBKGHCOCNI;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2F90F60", Offset = "0x2F90160", VA = "0x182F90F60")]
	public BPIEGKKCKAM(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA, T5 CLODBNEMKJL, T6 BHPEMEJILMA, T7 LHLIELAODMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2F908C0", Offset = "0x2F8FAC0", VA = "0x182F908C0", Slot = "4")]
	public int CompareTo(BPIEGKKCKAM<T1, T2, T3, T4, T5, T6, T7> HPOECFLNEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2F90AC0", Offset = "0x2F8FCC0", VA = "0x182F90AC0", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2F90C80", Offset = "0x2F8FE80", VA = "0x182F90C80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2F90DD0", Offset = "0x2F8FFD0", VA = "0x182F90DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LHAEBHFJPKF<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<LHAEBHFJPKF<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T1 FJLMANHEPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T2 AKPAEEJCELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T3 IOAGKOCEIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T4 PJGBPPGIPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T5 ODJIBEICMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T6 NBKMEBLANFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T7 GLBKGHCOCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T8 GAFKAMCJEIG;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x38DDFC0", Offset = "0x38DD1C0", VA = "0x1838DDFC0")]
	public LHAEBHFJPKF(T1 FANHPJOKIPO, T2 IDEGFDOEAMJ, T3 HAKLIFKNDDJ, T4 FCIKCHFEDAA, T5 CLODBNEMKJL, T6 BHPEMEJILMA, T7 LHLIELAODMK, T8 EJGHKFHLLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x38DD870", Offset = "0x38DCA70", VA = "0x1838DD870", Slot = "4")]
	public int CompareTo(LHAEBHFJPKF<T1, T2, T3, T4, T5, T6, T7, T8> HPOECFLNEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x38DDAC0", Offset = "0x38DCCC0", VA = "0x1838DDAC0", Slot = "0")]
	public override bool Equals(object HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x38DDCA0", Offset = "0x38DCEA0", VA = "0x1838DDCA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x38DDE10", Offset = "0x38DD010", VA = "0x1838DDE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OFJEFHAIHLK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x956D50", Offset = "0x955F50", VA = "0x180956D50")]
	public OFJEFHAIHLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HashableScriptableObject : ScriptableObject, MHKMPHFAJMJ, NONFCAAACAJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C10", Offset = "0x8D6E10", VA = "0x1808D7C10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9A16E0", Offset = "0x9A08E0", VA = "0x1809A16E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash AMEEDJNJKBN);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xC7A8A0", Offset = "0xC79AA0", VA = "0x180C7A8A0")]
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
	[CKFGDNEKDDK]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[CKFGDNEKDDK]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x70548F0", Offset = "0x7053AF0", VA = "0x1870548F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x70548B0", Offset = "0x7053AB0", VA = "0x1870548B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7054930", Offset = "0x7053B30", VA = "0x187054930")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7054AE0", Offset = "0x7053CE0", VA = "0x187054AE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7054A50", Offset = "0x7053C50", VA = "0x187054A50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x981930", Offset = "0x980B30", VA = "0x180981930")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xC7A8D0", Offset = "0xC79AD0", VA = "0x180C7A8D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7054870", Offset = "0x7053A70", VA = "0x187054870")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x70549C0", Offset = "0x7053BC0", VA = "0x1870549C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x70542C0", Offset = "0x70534C0", VA = "0x1870542C0")]
	public void CopyBounds(SavedExtents HPOECFLNEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x70547D0", Offset = "0x70539D0", VA = "0x1870547D0")]
	public void SetLocalSpaceBounds(Bounds LNFJFKNMOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7053C60", Offset = "0x7052E60", VA = "0x187053C60")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7054700", Offset = "0x7053900", VA = "0x187054700")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x70542F0", Offset = "0x70534F0", VA = "0x1870542F0")]
	private void NGKPPBOMLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x70544D0", Offset = "0x70536D0", VA = "0x1870544D0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7053C80", Offset = "0x7052E80", VA = "0x187053C80")]
	public static void CalculateLocalBoundsFor(GameObject JBOGCBPFIGA, out Bounds LNFJFKNMOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7054710", Offset = "0x7053910", VA = "0x187054710")]
	private static void PDABFHDEFLH(Bounds NMKMEIDKGEO, Color AODGGHOKMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x70547F0", Offset = "0x70539F0", VA = "0x1870547F0")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class EGKNGDHKOPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct JCNMJHPKKPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public T IHPKAGOHFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float PCDHGGLBPDG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static float ACMHNAJCKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<T> GBOJCANHCLC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const int IOIOHBEHONA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private JCNMJHPKKPC[] BGBPILICHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int ADFDPCGJFAI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GCGGEGKKIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xC7C8B0", Offset = "0xC7BAB0", VA = "0x180C7C8B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x113C690", Offset = "0x113B890", VA = "0x18113C690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4486900", Offset = "0x4485B00", VA = "0x184486900")]
	public EGKNGDHKOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4486800", Offset = "0x4485A00", VA = "0x184486800")]
	public EGKNGDHKOPH(int KOIBEABAMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4486610", Offset = "0x4485810", VA = "0x184486610")]
	public void PPMBLONPHPF(float LNBMFKNJEDF, T ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4485A00", Offset = "0x4484C00", VA = "0x184485A00")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4485320", Offset = "0x4484520", VA = "0x184485320")]
	public bool BOMNNPPPHAK(float KIGKDLBBLOO, float PINLBGCLAHM, out T ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4485CD0", Offset = "0x4484ED0", VA = "0x184485CD0")]
	public bool HIDIKMCDLAK(float KIGKDLBBLOO, float PINLBGCLAHM, out T ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x44863C0", Offset = "0x44855C0", VA = "0x1844863C0")]
	public void MDGMJCPDNKL(float KIGKDLBBLOO, float PINLBGCLAHM, List<T> HEENIHIEKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4485CA0", Offset = "0x4484EA0", VA = "0x184485CA0")]
	private int GBGJPAEAJLP(int IKNHBCHHDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x44864F0", Offset = "0x44856F0", VA = "0x1844864F0")]
	private void OEEICKMAELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GBPEHAPEPBL();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NNFNIDCMBDE(T JFHIJPMPOBA, T LPNFMADJDAF, float NIKDBMNECCB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T OBDPABMOAJF(T ACKOJNNBEBO, float NIKDBMNECCB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MODOGFDEFOI(T JFHIJPMPOBA, T LPNFMADJDAF);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T FHJGJPBACDJ(T JFHIJPMPOBA, T LPNFMADJDAF);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CNKMFJKHDHP : EGKNGDHKOPH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x14D4EA0", Offset = "0x14D40A0", VA = "0x1814D4EA0", Slot = "4")]
	protected override Vector3 GBPEHAPEPBL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2779C80", Offset = "0x2778E80", VA = "0x182779C80", Slot = "5")]
	protected override Vector3 NNFNIDCMBDE(Vector3 JFHIJPMPOBA, Vector3 LPNFMADJDAF, float NIKDBMNECCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7050090", Offset = "0x704F290", VA = "0x187050090", Slot = "6")]
	protected override Vector3 OBDPABMOAJF(Vector3 ACKOJNNBEBO, float NIKDBMNECCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7050040", Offset = "0x704F240", VA = "0x187050040", Slot = "7")]
	protected override Vector3 MODOGFDEFOI(Vector3 JFHIJPMPOBA, Vector3 LPNFMADJDAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x704FFD0", Offset = "0x704F1D0", VA = "0x18704FFD0", Slot = "8")]
	protected override Vector3 FHJGJPBACDJ(Vector3 JFHIJPMPOBA, Vector3 LPNFMADJDAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x70500D0", Offset = "0x704F2D0", VA = "0x1870500D0")]
	public CNKMFJKHDHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HCHNGJKOCJK : EGKNGDHKOPH<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x70508D0", Offset = "0x704FAD0", VA = "0x1870508D0")]
	public HCHNGJKOCJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7050860", Offset = "0x704FA60", VA = "0x187050860")]
	public HCHNGJKOCJK(int KOIBEABAMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xE19670", Offset = "0xE18870", VA = "0x180E19670", Slot = "4")]
	protected override float GBPEHAPEPBL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3EDA450", Offset = "0x3ED9650", VA = "0x183EDA450", Slot = "5")]
	protected override float NNFNIDCMBDE(float JFHIJPMPOBA, float LPNFMADJDAF, float NIKDBMNECCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5A930A0", Offset = "0x5A922A0", VA = "0x185A930A0", Slot = "6")]
	protected override float OBDPABMOAJF(float ACKOJNNBEBO, float NIKDBMNECCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7050850", Offset = "0x704FA50", VA = "0x187050850", Slot = "7")]
	protected override float MODOGFDEFOI(float JFHIJPMPOBA, float LPNFMADJDAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7050840", Offset = "0x704FA40", VA = "0x187050840", Slot = "8")]
	protected override float FHJGJPBACDJ(float JFHIJPMPOBA, float LPNFMADJDAF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BIFMFIJPGJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IDisposable EBEPLDELFOG;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public BIFMFIJPGJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FDPIFHNGNDB : GLDPNECOOLK<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x70506A0", Offset = "0x704F8A0", VA = "0x1870506A0")]
	public FDPIFHNGNDB(int HBHBCIIAIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x70506F0", Offset = "0x704F8F0", VA = "0x1870506F0")]
	public FDPIFHNGNDB(BOMHCKJOAPB[] NIHGMDMPKHO, bool GGDNCMDFBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7050630", Offset = "0x704F830", VA = "0x187050630", Slot = "6")]
	protected override uint ICBFHOMDOOL(uint AMEEDJNJKBN, string ACKOJNNBEBO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class AGGEAMNFOME<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct OGEMPJANAFM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly AGGEAMNFOME<T> GINGLOFDFPP;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T IHPKAGOHFMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3E30F30", Offset = "0x3E30130", VA = "0x183E30F30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E30F00", Offset = "0x3E30100", VA = "0x183E30F00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
		public OGEMPJANAFM(AGGEAMNFOME<T> GINGLOFDFPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NNOOELPNILO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<OGEMPJANAFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AGGEAMNFOME<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public NNOOELPNILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4671A30", Offset = "0x4670C30", VA = "0x184671A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LOHNLCOHBKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<OGEMPJANAFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AGGEAMNFOME<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public LOHNLCOHBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x42A8580", Offset = "0x42A7780", VA = "0x1842A8580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly SemaphoreSlim JBDLFCOIDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T BPAAHELFHHH;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EJEGDADLOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4C72C60", Offset = "0x4C71E60", VA = "0x184C72C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4C734D0", Offset = "0x4C726D0", VA = "0x184C734D0")]
	public AGGEAMNFOME(in T BPAAHELFHHH, int BABCMMNOONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4C73400", Offset = "0x4C72600", VA = "0x184C73400")]
	public AGGEAMNFOME(in T BPAAHELFHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4C73380", Offset = "0x4C72580", VA = "0x184C73380")]
	public OGEMPJANAFM KBHJHBFDHPH()
	{
		return default(OGEMPJANAFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4C733C0", Offset = "0x4C725C0", VA = "0x184C733C0")]
	public OGEMPJANAFM KBHJHBFDHPH(CancellationToken PLEKJLHDOLP)
	{
		return default(OGEMPJANAFM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4C72C80", Offset = "0x4C71E80", VA = "0x184C72C80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGGEAMNFOME<>.NNOOELPNILO))]
	public Task<OGEMPJANAFM> KABIDAHONLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4C731B0", Offset = "0x4C723B0", VA = "0x184C731B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGGEAMNFOME<>.LOHNLCOHBKA))]
	public Task<OGEMPJANAFM> KABIDAHONLJ(CancellationToken PLEKJLHDOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class NCNPLGEEFHI
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7052430", Offset = "0x7051630", VA = "0x187052430")]
	public static AGGEAMNFOME<HHFDPGOJPDI> NMBJFIHLDEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7052490", Offset = "0x7051690", VA = "0x187052490")]
	public static AGGEAMNFOME<HHFDPGOJPDI> NMBJFIHLDEO(int BABCMMNOONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x268FC40", Offset = "0x268EE40", VA = "0x18268FC40")]
	public static AGGEAMNFOME<T> NMBJFIHLDEO<T>(in T BPAAHELFHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2FE5240", Offset = "0x2FE4440", VA = "0x182FE5240")]
	public static AGGEAMNFOME<T> NMBJFIHLDEO<T>(in T BPAAHELFHHH, int BABCMMNOONA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class KOLGDPNPKEN<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private KOLGDPNPKEN<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x8D44A0", Offset = "0x8D36A0", VA = "0x1808D44A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x35C3E80", Offset = "0x35C3080", VA = "0x1835C3E80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x32CAE80", Offset = "0x32CA080", VA = "0x1832CAE80")]
		public Enumerator(KOLGDPNPKEN<T> HEENIHIEKKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x35C02A0", Offset = "0x35BF4A0", VA = "0x1835C02A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x35C23C0", Offset = "0x35C15C0", VA = "0x1835C23C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x35BF0B0", Offset = "0x35BE2B0", VA = "0x1835BF0B0")]
		private void IMCEHACNKCH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private T[] HJHCGFFCFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int PFBJKNIILDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int FEHIJPHCAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private int EJEDLELNMDA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x35F9C30", Offset = "0x35F8E30", VA = "0x1835F9C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x35F9B50", Offset = "0x35F8D50", VA = "0x1835F9B50")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x35F8970", Offset = "0x35F7B70", VA = "0x1835F8970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x35FA030", Offset = "0x35F9230", VA = "0x1835FA030")]
	public KOLGDPNPKEN(int HBHBCIIAIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x35F9D00", Offset = "0x35F8F00", VA = "0x1835F9D00")]
	public void PPMBLONPHPF(T NIKDBMNECCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x35F9720", Offset = "0x35F8920", VA = "0x1835F9720")]
	public void KCFEDKFMPOF(IEnumerable<T> KBELBHAMCGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x35F8E60", Offset = "0x35F8060", VA = "0x1835F8E60")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x35F9BA0", Offset = "0x35F8DA0", VA = "0x1835F9BA0")]
	public void NOAKKFHLIEH(int IGDJHHPIJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x35F9C70", Offset = "0x35F8E70", VA = "0x1835F9C70")]
	public void OJDBGEJGCPE(int IGDJHHPIJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x35F8CF0", Offset = "0x35F7EF0", VA = "0x1835F8CF0")]
	public void APKNHGOFJJG(T[] BGBPILICHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x35F9A50", Offset = "0x35F8C50", VA = "0x1835F9A50")]
	public Enumerator KECFEFHENMC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x35F9FB0", Offset = "0x35F91B0", VA = "0x1835F9FB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x35F9FB0", Offset = "0x35F91B0", VA = "0x1835F9FB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x35F9060", Offset = "0x35F8260", VA = "0x1835F9060")]
	private int ECNLLGINHKB(int MMFFFGBLCAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x35F8E30", Offset = "0x35F8030", VA = "0x1835F8E30")]
	private int CGPEFCHDOFP(int MMFFFGBLCAP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class LCDMIMHGCKI
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FHJGONLDOEF(object[] AHLCEBMCJMF);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	protected LCDMIMHGCKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class FNHJJLEHPLI<T> : LCDMIMHGCKI
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	protected struct MMGMPKKBEML
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum GDPODBJHHBK
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
		public GDPODBJHHBK JAACLLLIGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public T JFFMHPNGJBK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int BANCCKEEMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly bool EHBEJONAGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly bool IELFHIPGLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	protected List<T> KLKGPBFENGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<MMGMPKKBEML> HIHHDFMPMDL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool OPKCOGGKOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F510", Offset = "0x3A9E710", VA = "0x183A9F510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A9FA70", Offset = "0x3A9EC70", VA = "0x183A9FA70")]
	protected FNHJJLEHPLI(bool IELFHIPGLNP, bool EHBEJONAGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F380", Offset = "0x3A9E580", VA = "0x183A9F380")]
	protected bool ADBKEPGPEKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F550", Offset = "0x3A9E750", VA = "0x183A9F550")]
	protected void JAPPOGCDCIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F610", Offset = "0x3A9E810", VA = "0x183A9F610")]
	protected void JBCJLDKCNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x262A470", Offset = "0x2629670", VA = "0x18262A470")]
	private static void JCDKCIGJGPC<U>(ref List<U> IEKCFDAIBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F910", Offset = "0x3A9EB10", VA = "0x183A9F910", Slot = "5")]
	public void PPMBLONPHPF(T JFFMHPNGJBK, bool LBMIMMLLGNP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F7C0", Offset = "0x3A9E9C0", VA = "0x183A9F7C0", Slot = "6")]
	public void PLKCAALIKKA(T JFFMHPNGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F400", Offset = "0x3A9E600", VA = "0x183A9F400")]
	public void DAFFCKIEONE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface ABODPNCIFEA
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPMBLONPHPF(Action JFFMHPNGJBK, bool LBMIMMLLGNP = false);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLKCAALIKKA(Action JFFMHPNGJBK);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class CJPPGPOGFKM : FNHJJLEHPLI<Action>, ABODPNCIFEA
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x704FDE0", Offset = "0x704EFE0", VA = "0x18704FDE0")]
	public CJPPGPOGFKM(bool IELFHIPGLNP = false, bool EHBEJONAGNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x704FB70", Offset = "0x704ED70", VA = "0x18704FB70")]
	public void OGNFCKBDNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x704FAA0", Offset = "0x704ECA0", VA = "0x18704FAA0", Slot = "4")]
	public override void FHJGONLDOEF(object[] AHLCEBMCJMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x704FB10", Offset = "0x704ED10", VA = "0x18704FB10")]
	public static CJPPGPOGFKM ILKGCPLNHIM(CJPPGPOGFKM AOEOEFOKJON, Action JFFMHPNGJBK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x704FD80", Offset = "0x704EF80", VA = "0x18704FD80")]
	public static CJPPGPOGFKM PAOPECLIJAE(CJPPGPOGFKM AOEOEFOKJON, Action JFFMHPNGJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface LBDKJAFNMAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPMBLONPHPF(Action<T> JFFMHPNGJBK, bool LBMIMMLLGNP = false);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLKCAALIKKA(Action<T> JFFMHPNGJBK);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class KODDBGBLBCG<T> : FNHJJLEHPLI<Action<T>>, LBDKJAFNMAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2755CA0", Offset = "0x2754EA0", VA = "0x182755CA0")]
	public KODDBGBLBCG(bool IELFHIPGLNP = false, bool EHBEJONAGNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x35F6AC0", Offset = "0x35F5CC0", VA = "0x1835F6AC0")]
	public void OGNFCKBDNLK(T NIKDBMNECCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x35F4F70", Offset = "0x35F4170", VA = "0x1835F4F70", Slot = "4")]
	public override void FHJGONLDOEF(object[] AHLCEBMCJMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x35F6580", Offset = "0x35F5780", VA = "0x1835F6580")]
	public static KODDBGBLBCG<T> ILKGCPLNHIM(KODDBGBLBCG<T> AOEOEFOKJON, Action<T> JFFMHPNGJBK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x35F84E0", Offset = "0x35F76E0", VA = "0x1835F84E0")]
	public static KODDBGBLBCG<T> PAOPECLIJAE(KODDBGBLBCG<T> AOEOEFOKJON, Action<T> JFFMHPNGJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface ADFCCPCEOKI<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPMBLONPHPF(Action<T, U> JFFMHPNGJBK, bool LBMIMMLLGNP = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLKCAALIKKA(Action<T, U> JFFMHPNGJBK);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class PDLBGMFECHE<T, U> : FNHJJLEHPLI<Action<T, U>>, ADFCCPCEOKI<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2755CA0", Offset = "0x2754EA0", VA = "0x182755CA0")]
	public PDLBGMFECHE(bool IELFHIPGLNP = false, bool EHBEJONAGNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x358D8F0", Offset = "0x358CAF0", VA = "0x18358D8F0")]
	public void OGNFCKBDNLK(T NIKDBMNECCB, U IBAPKFAHKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x35E0C60", Offset = "0x35DFE60", VA = "0x1835E0C60", Slot = "4")]
	public override void FHJGONLDOEF(object[] AHLCEBMCJMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x358D860", Offset = "0x358CA60", VA = "0x18358D860")]
	public static PDLBGMFECHE<T, U> ILKGCPLNHIM(PDLBGMFECHE<T, U> AOEOEFOKJON, Action<T, U> JFFMHPNGJBK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x358FC40", Offset = "0x358EE40", VA = "0x18358FC40")]
	public static PDLBGMFECHE<T, U> PAOPECLIJAE(PDLBGMFECHE<T, U> AOEOEFOKJON, Action<T, U> JFFMHPNGJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface GONAAEFOIMH<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPMBLONPHPF(Action<T, U, V> JFFMHPNGJBK, bool LBMIMMLLGNP = false);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLKCAALIKKA(Action<T, U, V> JFFMHPNGJBK);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class CBFDCKFJGDP<T, U, V> : FNHJJLEHPLI<Action<T, U, V>>, GONAAEFOIMH<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2755CA0", Offset = "0x2754EA0", VA = "0x182755CA0")]
	public CBFDCKFJGDP(bool IELFHIPGLNP = false, bool EHBEJONAGNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3695C00", Offset = "0x3694E00", VA = "0x183695C00")]
	public void OGNFCKBDNLK(T NIKDBMNECCB, U IBAPKFAHKOC, V HECDHLBDMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3692FD0", Offset = "0x36921D0", VA = "0x183692FD0", Slot = "4")]
	public override void FHJGONLDOEF(object[] AHLCEBMCJMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3694F50", Offset = "0x3694150", VA = "0x183694F50")]
	public static CBFDCKFJGDP<T, U, V> ILKGCPLNHIM(CBFDCKFJGDP<T, U, V> AOEOEFOKJON, Action<T, U, V> JFFMHPNGJBK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3697140", Offset = "0x3696340", VA = "0x183697140")]
	public static CBFDCKFJGDP<T, U, V> PAOPECLIJAE(CBFDCKFJGDP<T, U, V> AOEOEFOKJON, Action<T, U, V> JFFMHPNGJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface GKCOMECDCBP<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPMBLONPHPF(Action<T, U, V, W> JFFMHPNGJBK, bool LBMIMMLLGNP = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLKCAALIKKA(Action<T, U, V, W> JFFMHPNGJBK);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class BMHBIJDEEIF<T, U, V, W> : FNHJJLEHPLI<Action<T, U, V, W>>, GKCOMECDCBP<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2755CA0", Offset = "0x2754EA0", VA = "0x182755CA0")]
	public BMHBIJDEEIF(bool IELFHIPGLNP = false, bool EHBEJONAGNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x47759F0", Offset = "0x4774BF0", VA = "0x1847759F0")]
	public void OGNFCKBDNLK(T NIKDBMNECCB, U IBAPKFAHKOC, V HECDHLBDMDJ, W ALNKHNEGNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4773CB0", Offset = "0x4772EB0", VA = "0x184773CB0", Slot = "4")]
	public override void FHJGONLDOEF(object[] AHLCEBMCJMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4775440", Offset = "0x4774640", VA = "0x184775440")]
	public static BMHBIJDEEIF<T, U, V, W> ILKGCPLNHIM(BMHBIJDEEIF<T, U, V, W> AOEOEFOKJON, Action<T, U, V, W> JFFMHPNGJBK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4776A50", Offset = "0x4775C50", VA = "0x184776A50")]
	public static BMHBIJDEEIF<T, U, V, W> PAOPECLIJAE(BMHBIJDEEIF<T, U, V, W> AOEOEFOKJON, Action<T, U, V, W> JFFMHPNGJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface OHBBFNOOFOF<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPMBLONPHPF(Action<T, U, V, W, X> JFFMHPNGJBK, bool LBMIMMLLGNP = false);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLKCAALIKKA(Action<T, U, V, W, X> JFFMHPNGJBK);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class OAFPCGBBODJ<T, U, V, W, X> : FNHJJLEHPLI<Action<T, U, V, W, X>>, OHBBFNOOFOF<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2755CA0", Offset = "0x2754EA0", VA = "0x182755CA0")]
	public OAFPCGBBODJ(bool IELFHIPGLNP = false, bool EHBEJONAGNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3561830", Offset = "0x3560A30", VA = "0x183561830")]
	public void OGNFCKBDNLK(T NIKDBMNECCB, U IBAPKFAHKOC, V HECDHLBDMDJ, W ALNKHNEGNCO, X JNIPLDLJAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3561430", Offset = "0x3560630", VA = "0x183561430", Slot = "4")]
	public override void FHJGONLDOEF(object[] AHLCEBMCJMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x35617A0", Offset = "0x35609A0", VA = "0x1835617A0")]
	public static OAFPCGBBODJ<T, U, V, W, X> ILKGCPLNHIM(OAFPCGBBODJ<T, U, V, W, X> AOEOEFOKJON, Action<T, U, V, W, X> JFFMHPNGJBK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3561E10", Offset = "0x3561010", VA = "0x183561E10")]
	public static OAFPCGBBODJ<T, U, V, W, X> PAOPECLIJAE(OAFPCGBBODJ<T, U, V, W, X> AOEOEFOKJON, Action<T, U, V, W, X> JFFMHPNGJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface FGJNGHMOGIC<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PPMBLONPHPF(Action<T, U, V, W, X, Y> JFFMHPNGJBK, bool LBMIMMLLGNP = false);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLKCAALIKKA(Action<T, U, V, W, X, Y> JFFMHPNGJBK);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class JKGIENDDENB<T, U, V, W, X, Y> : FNHJJLEHPLI<Action<T, U, V, W, X, Y>>, FGJNGHMOGIC<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2755CA0", Offset = "0x2754EA0", VA = "0x182755CA0")]
	public JKGIENDDENB(bool IELFHIPGLNP = false, bool EHBEJONAGNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x360FE70", Offset = "0x360F070", VA = "0x18360FE70")]
	public void OGNFCKBDNLK(T NIKDBMNECCB, U IBAPKFAHKOC, V HECDHLBDMDJ, W ALNKHNEGNCO, X JNIPLDLJAIJ, Y GEADFOLNEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x360EC10", Offset = "0x360DE10", VA = "0x18360EC10", Slot = "4")]
	public override void FHJGONLDOEF(object[] AHLCEBMCJMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x360F7E0", Offset = "0x360E9E0", VA = "0x18360F7E0")]
	public static JKGIENDDENB<T, U, V, W, X, Y> ILKGCPLNHIM(JKGIENDDENB<T, U, V, W, X, Y> AOEOEFOKJON, Action<T, U, V, W, X, Y> JFFMHPNGJBK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3610140", Offset = "0x360F340", VA = "0x183610140")]
	public static JKGIENDDENB<T, U, V, W, X, Y> PAOPECLIJAE(JKGIENDDENB<T, U, V, W, X, Y> AOEOEFOKJON, Action<T, U, V, W, X, Y> JFFMHPNGJBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct GMNGLOODEPP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GOKCACKOABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int KJNBBEDODHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int PACHOPFCGEB;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x10E4580", Offset = "0x10E3780", VA = "0x1810E4580")]
	private GMNGLOODEPP(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AFGEDDEIAJK, int GLKJINFPLND, int KNDAKNLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3F043D0", Offset = "0x3F035D0", VA = "0x183F043D0")]
	public static GMNGLOODEPP<T> NMBJFIHLDEO()
	{
		return default(GMNGLOODEPP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3F049C0", Offset = "0x3F03BC0", VA = "0x183F049C0")]
	public (int, int, Task<T>) OMHJBANIFMG(int FKBMPNHLDOO, [Optional] CancellationToken PLEKJLHDOLP, double KFAABCMFLLA = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3F04660", Offset = "0x3F03860", VA = "0x183F04660")]
	public void NPNFBBGDOHO(int FKBMPNHLDOO, int KNDAKNLFNCF, in T GAFKIBJKPNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HFOJAGPJOKA
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7050940", Offset = "0x704FB40", VA = "0x187050940")]
	public static GMNGLOODEPP<HHFDPGOJPDI> NMBJFIHLDEO()
	{
		return default(GMNGLOODEPP<HHFDPGOJPDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7050990", Offset = "0x704FB90", VA = "0x187050990")]
	public static void NPNFBBGDOHO(this in GMNGLOODEPP<HHFDPGOJPDI> DCMHODHEGEC, int FKBMPNHLDOO, int KNDAKNLFNCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DefaultMember("Item")]
public class DNFLOEAJHPJ<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<TKey, TVal> PNPKEGAPJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<TVal, TKey> ALNLCMBDEOK;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2904080", Offset = "0x2903280", VA = "0x182904080", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool NPDFLFDHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> EPELCDMANGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C5D0", Offset = "0x2D5B7D0", VA = "0x182D5C5D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TVal> BFJNENONLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2D5C370", Offset = "0x2D5B570", VA = "0x182D5C370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TVal LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3788DE0", Offset = "0x3787FE0", VA = "0x183788DE0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3788E20", Offset = "0x3788020", VA = "0x183788E20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TKey LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x37888B0", Offset = "0x3787AB0", VA = "0x1837888B0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3787B50", Offset = "0x3786D50", VA = "0x183787B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3787E60", Offset = "0x3787060", VA = "0x183787E60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3788C20", Offset = "0x3787E20", VA = "0x183788C20", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3787C00", Offset = "0x3786E00", VA = "0x183787C00", Slot = "9")]
	public void Add(TKey PPNIGBBPGOI, TVal ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3787C40", Offset = "0x3786E40", VA = "0x183787C40", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> FNPJDMFCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3787EC0", Offset = "0x37870C0", VA = "0x183787EC0", Slot = "8")]
	public bool ContainsKey(TKey PPNIGBBPGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3787F20", Offset = "0x3787120", VA = "0x183787F20", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x34ED370", Offset = "0x34EC570", VA = "0x1834ED370", Slot = "10")]
	public bool Remove(TKey PPNIGBBPGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3788BA0", Offset = "0x3787DA0", VA = "0x183788BA0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3563A40", Offset = "0x3562C40", VA = "0x183563A40", Slot = "11")]
	public bool TryGetValue(TKey PPNIGBBPGOI, out TVal ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x36154E0", Offset = "0x36146E0", VA = "0x1836154E0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3787F50", Offset = "0x3787150", VA = "0x183787F50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BGBPILICHHA, int AAOCMLFBPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3788A80", Offset = "0x3787C80", VA = "0x183788A80")]
	public void PPMBLONPHPF(TVal HKPIHPOEJGA, TKey PPNIGBBPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3788AF0", Offset = "0x3787CF0", VA = "0x183788AF0")]
	public void PPMBLONPHPF(KeyValuePair<TVal, TKey> FNPJDMFCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3788810", Offset = "0x3787A10", VA = "0x183788810")]
	public bool KIBDODDKDKH(TVal PPNIGBBPGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3788960", Offset = "0x3787B60", VA = "0x183788960")]
	public bool PLLNGOBMPBN(KeyValuePair<TVal, TKey> FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x37888F0", Offset = "0x3787AF0", VA = "0x1837888F0")]
	public bool PLKCAALIKKA(TVal PPNIGBBPGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x37888F0", Offset = "0x3787AF0", VA = "0x1837888F0")]
	public bool PLKCAALIKKA(KeyValuePair<TVal, TKey> FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3787FE0", Offset = "0x37871E0", VA = "0x183787FE0")]
	public bool EIKCLBLFBCB(TVal PPNIGBBPGOI, out TKey ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3788680", Offset = "0x3787880", VA = "0x183788680")]
	public IEnumerator<KeyValuePair<TVal, TKey>> FCGHMDKGCIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3787D40", Offset = "0x3786F40", VA = "0x183787D40")]
	private void BJEBNGDJCGE(TKey PPNIGBBPGOI, TVal HKPIHPOEJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x37884D0", Offset = "0x37876D0", VA = "0x1837884D0")]
	private void FBIDPNCDHGA(TKey PPNIGBBPGOI, TVal HKPIHPOEJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3788020", Offset = "0x3787220", VA = "0x183788020")]
	private bool ENAFLNAHFKI(TKey PPNIGBBPGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x37883F0", Offset = "0x37875F0", VA = "0x1837883F0")]
	private bool ENAFLNAHFKI(TVal HKPIHPOEJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3788CC0", Offset = "0x3787EC0", VA = "0x183788CC0")]
	public DNFLOEAJHPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public class EKFJLIBFKNI<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<Internal, External> IOKIOGBPNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Func<External, Internal> ILOOGCLIGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private IList<Internal> IEKCFDAIBOJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IList<Internal> AGFHBDOEEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C10", Offset = "0x8D6E10", VA = "0x1808D7C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NPDFLFDHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x98C9A0", Offset = "0x98BBA0", VA = "0x18098C9A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x98C990", Offset = "0x98BB90", VA = "0x18098C990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3669690", Offset = "0x3668890", VA = "0x183669690", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3669730", Offset = "0x3668930", VA = "0x183669730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3669630", Offset = "0x3668830", VA = "0x183669630", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x36695A0", Offset = "0x36687A0", VA = "0x1836695A0")]
	public EKFJLIBFKNI(Func<Internal, External> IOKIOGBPNEO, Func<External, Internal> ILOOGCLIGLC, bool OCDKNNEJFOH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x36692D0", Offset = "0x36684D0", VA = "0x1836692D0", Slot = "6")]
	public int IndexOf(External FNPJDMFCFGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3668F60", Offset = "0x3668160", VA = "0x183668F60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3668FC0", Offset = "0x36681C0", VA = "0x183668FC0", Slot = "13")]
	public bool Contains(External FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3669050", Offset = "0x3668250", VA = "0x183669050", Slot = "14")]
	public void CopyTo(External[] BGBPILICHHA, int AAOCMLFBPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3668ED0", Offset = "0x36680D0", VA = "0x183668ED0", Slot = "11")]
	public void Add(External FNPJDMFCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x36693B0", Offset = "0x36685B0", VA = "0x1836693B0", Slot = "7")]
	public void Insert(int MMFFFGBLCAP, External FNPJDMFCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3669510", Offset = "0x3668710", VA = "0x183669510", Slot = "15")]
	public bool Remove(External FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3669450", Offset = "0x3668650", VA = "0x183669450", Slot = "8")]
	public void RemoveAt(int MMFFFGBLCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3669260", Offset = "0x3668460", VA = "0x183669260", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2DC6650", Offset = "0x2DC5850", VA = "0x182DC6650", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DefaultMember("Item")]
public class LOJMCFBKMNM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<Internal, External> IOKIOGBPNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IReadOnlyList<Internal> IEKCFDAIBOJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> AGFHBDOEEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NPDFLFDHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x42A8BF0", Offset = "0x42A7DF0", VA = "0x1842A8BF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x42A8B90", Offset = "0x42A7D90", VA = "0x1842A8B90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC600", Offset = "0x1CCB800", VA = "0x181CCC600")]
	public LOJMCFBKMNM(Func<Internal, External> IOKIOGBPNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x42A8B40", Offset = "0x42A7D40", VA = "0x1842A8B40")]
	public LOJMCFBKMNM(IReadOnlyList<Internal> IEKCFDAIBOJ, Func<Internal, External> IOKIOGBPNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x42A88C0", Offset = "0x42A7AC0", VA = "0x1842A88C0")]
	public void APKNHGOFJJG(External[] BGBPILICHHA, int AAOCMLFBPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x42A8AD0", Offset = "0x42A7CD0", VA = "0x1842A8AD0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x27663F0", Offset = "0x27655F0", VA = "0x1827663F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class BEPFJJMMMME<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private IReadOnlyList<Internal> IEKCFDAIBOJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IReadOnlyList<Internal> AGFHBDOEEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool NPDFLFDHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public External LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x33E9550", Offset = "0x33E8750", VA = "0x1833E9550", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x33E94F0", Offset = "0x33E86F0", VA = "0x1833E94F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC600", Offset = "0x1CCB800", VA = "0x181CCC600")]
	public BEPFJJMMMME(IReadOnlyList<Internal> IEKCFDAIBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x33E9450", Offset = "0x33E8650", VA = "0x1833E9450")]
	public bool PLLNGOBMPBN(External FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x33E91C0", Offset = "0x33E83C0", VA = "0x1833E91C0")]
	public void APKNHGOFJJG(External[] BGBPILICHHA, int AAOCMLFBPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x33E93E0", Offset = "0x33E85E0", VA = "0x1833E93E0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2DC6650", Offset = "0x2DC5850", VA = "0x182DC6650", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LLNGBCKEOML<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> DCOKLAOKIAO(TRequest JFILJIAPEEP, CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum CCOFIHNALEM
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class KOFLDPGJPJK
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private const float JJKCOBGCDMG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TimeSpan ODJCBDFHDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int CLMKNKOHDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CCOFIHNALEM DCECHNLFMHK;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly KOFLDPGJPJK OONGDIKAKHH;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EIPCMOFPAEM
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x35F86D0", Offset = "0x35F78D0", VA = "0x1835F86D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan KCPPPDOPNKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x35F8890", Offset = "0x35F7A90", VA = "0x1835F8890")]
		public KOFLDPGJPJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct HPKJIEFIGKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly TRequest JFILJIAPEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly CancellationToken PLEKJLHDOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly TaskCompletionSource<TResult> FIMLJLMBECG;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2DDD0B0", Offset = "0x2DDC2B0", VA = "0x182DDD0B0")]
		public HPKJIEFIGKN(TRequest JFILJIAPEEP, TaskCompletionSource<TResult> FIMLJLMBECG, CancellationToken PLEKJLHDOLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class PEIFELAIGOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public LLNGBCKEOML<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public PEIFELAIGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3595F50", Offset = "0x3595150", VA = "0x183595F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LFMAAKLPIGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public LLNGBCKEOML<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private HPKJIEFIGKN <req>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public LFMAAKLPIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x354D0D0", Offset = "0x354C2D0", VA = "0x18354D0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CancellationTokenSource ONJAOCECMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly List<HPKJIEFIGKN> EMENGDAHPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly KOFLDPGJPJK GDGEOAPILMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly DCOKLAOKIAO MJKLAAFBPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Task CMCFNINFPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int HMOHILJCLMF;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C220", Offset = "0x3E9B420", VA = "0x183E9C220")]
	public LLNGBCKEOML(DCOKLAOKIAO MJKLAAFBPFA, [Optional] KOFLDPGJPJK GDGEOAPILMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BCC0", Offset = "0x3E9AEC0", VA = "0x183E9BCC0")]
	public Task<TResult> PNGNHDCICJG(TRequest JFILJIAPEEP, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3E9ACE0", Offset = "0x3E99EE0", VA = "0x183E9ACE0")]
	private void GKIHJFJNFNL(HPKJIEFIGKN BOHCAELCJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B2B0", Offset = "0x3E9A4B0", VA = "0x183E9B2B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLNGBCKEOML<, >.PEIFELAIGOI))]
	private Task LJOMKNMEOFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3E9BA60", Offset = "0x3E9AC60", VA = "0x183E9BA60")]
	private HPKJIEFIGKN LMDLIBMOEDG()
	{
		return default(HPKJIEFIGKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B010", Offset = "0x3E9A210", VA = "0x183E9B010")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LLNGBCKEOML<, >.LFMAAKLPIGG))]
	private Task JCOKPOKEKCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3E9A8F0", Offset = "0x3E99AF0", VA = "0x183E9A8F0")]
	private void CCKBFDMMDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3E9AB60", Offset = "0x3E99D60", VA = "0x183E9AB60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface AMNNFCPDMAF
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface JOPHPPHJHDD<T> : AMNNFCPDMAF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool ANJBNIOOCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string BNBIONAAEJG
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
	JOPHPPHJHDD<T> DJOOFBLJGLG(Action<T> DKEPHKCEMEJ);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JOPHPPHJHDD<T> CJLIEDPKNJN(Action<T> DKEPHKCEMEJ);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JOPHPPHJHDD<T> FHGKNNPPBCF(Action<T, T> JJFKFBADBGC);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JOPHPPHJHDD<T> DGOHPBHANNM(Action<T, T> JJFKFBADBGC);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JOPHPPHJHDD<T> IIJOEHIFDIA(Action<string> DGLOEHMKNII);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JOPHPPHJHDD<T> HKLLAALAHGK(Action<string> DGLOEHMKNII);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class INKOPHGKLDJ<T> : JOPHPPHJHDD<T>, AMNNFCPDMAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private PDLBGMFECHE<T, T> MJJMBJHOFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private KODDBGBLBCG<T> ODDAAGMECAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private KODDBGBLBCG<string> ELNKIDCHDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private string KLEKJFJOCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private T GAFKIBJKPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool CPDMJONBHPE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D30", Offset = "0x9F2F30", VA = "0x1809F3D30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1CBDE20", Offset = "0x1CBD020", VA = "0x181CBDE20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool ANJBNIOOCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x991CB0", Offset = "0x990EB0", VA = "0x180991CB0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string BNBIONAAEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x96E290", Offset = "0x96D490", VA = "0x18096E290", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1CBDE50", Offset = "0x1CBD050", VA = "0x181CBDE50", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x275CAC0", Offset = "0x275BCC0", VA = "0x18275CAC0")]
	private void FAEEFOMAPPM(T DGLHFPEOHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x275CBB0", Offset = "0x275BDB0", VA = "0x18275CBB0")]
	private void HDHICNBDOHB(string CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x275C8E0", Offset = "0x275BAE0", VA = "0x18275C8E0")]
	public void BLKLFBLJHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x275CB60", Offset = "0x275BD60", VA = "0x18275CB60", Slot = "6")]
	public JOPHPPHJHDD<T> FHGKNNPPBCF(Action<T, T> JJFKFBADBGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x275C9E0", Offset = "0x275BBE0", VA = "0x18275C9E0", Slot = "7")]
	public JOPHPPHJHDD<T> DGOHPBHANNM(Action<T, T> JJFKFBADBGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x275CA30", Offset = "0x275BC30", VA = "0x18275CA30", Slot = "4")]
	public JOPHPPHJHDD<T> DJOOFBLJGLG(Action<T> JJFKFBADBGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x275C990", Offset = "0x275BB90", VA = "0x18275C990", Slot = "5")]
	public JOPHPPHJHDD<T> CJLIEDPKNJN(Action<T> DKEPHKCEMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x275CCD0", Offset = "0x275BED0", VA = "0x18275CCD0", Slot = "8")]
	public JOPHPPHJHDD<T> IIJOEHIFDIA(Action<string> DGLOEHMKNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x275CC60", Offset = "0x275BE60", VA = "0x18275CC60", Slot = "9")]
	public JOPHPPHJHDD<T> HKLLAALAHGK(Action<string> DGLOEHMKNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x275CD70", Offset = "0x275BF70", VA = "0x18275CD70")]
	public INKOPHGKLDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class AMAGBJBKJDL
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class GCKLHDJEOEI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public JOPHPPHJHDD<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public JFMAKJPJKJA<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public GCKLHDJEOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3EDAB00", Offset = "0x3ED9D00", VA = "0x183EDAB00")]
		internal void IBHGOPLKFPE(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2AF4EA0", Offset = "0x2AF40A0", VA = "0x182AF4EA0")]
	public static NHJDNADPIAN<T> APPLNLCEBGC<T>(this JOPHPPHJHDD<T> CKMFAFPJJKB, Action<T> NMCNKNBHPHF)
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
			[Cpp2IlInjected.Address(RVA = "0x3A51030", Offset = "0x3A50230", VA = "0x183A51030")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8EC0", Offset = "0x6FD80C0", VA = "0x186FD8EC0")]
		public SerializedGuid(in Guid CNDCJIFNLGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7054D00", Offset = "0x7053F00", VA = "0x187054D00")]
		public static SerializedGuid GICNFEGBEKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7054EB0", Offset = "0x70540B0", VA = "0x187054EB0")]
		public static SerializedGuid NBECHMJBCAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7054D90", Offset = "0x7053F90", VA = "0x187054D90")]
		public bool JNICLPBNKND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8E90", Offset = "0x6FD8090", VA = "0x186FD8E90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7054F40", Offset = "0x7054140", VA = "0x187054F40", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7054E20", Offset = "0x7054020", VA = "0x187054E20")]
		public bool KKBGDLBHIFL(in Guid CNDCJIFNLGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7054B70", Offset = "0x7053D70", VA = "0x187054B70", Slot = "7")]
		public bool Equals(SerializedGuid HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7054C20", Offset = "0x7053E20", VA = "0x187054C20", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8DE0", Offset = "0x6FD7FE0", VA = "0x186FD8DE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FD8C20", Offset = "0x6FD7E20", VA = "0x186FD8C20", Slot = "6")]
		public int CompareTo(SerializedGuid HPOECFLNEOJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class DIPIGEHMONF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Type NAEDGGFCFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string HFNNJCGIGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool NCCKPDAKDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool IGOKICLAKNC;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7050180", Offset = "0x704F380", VA = "0x187050180")]
	public DIPIGEHMONF(Type KAJMMOAGCEK, string KHNGECPLOBO, bool KFJEICDOIIH = false, bool DHCHDBDDJPB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class PADBHJODHGH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<T> IEKCFDAIBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private HashSet<T> BOLFPABEECJ;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2904080", Offset = "0x2903280", VA = "0x182904080", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NPDFLFDHFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x826280", Offset = "0x825480", VA = "0x180826280", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2626560", Offset = "0x2625760", VA = "0x182626560", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A28730", Offset = "0x3A27930", VA = "0x183A28730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A27D60", Offset = "0x3A26F60", VA = "0x183A27D60", Slot = "11")]
	public void Add(T FNPJDMFCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A27ED0", Offset = "0x3A270D0", VA = "0x183A27ED0")]
	public bool GAHDPKFJOAE(T FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A28500", Offset = "0x3A27700", VA = "0x183A28500", Slot = "15")]
	public bool Remove(T FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3563980", Offset = "0x3562B80", VA = "0x183563980", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F5EB10", Offset = "0x2F5DD10", VA = "0x182F5EB10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A27D90", Offset = "0x3A26F90", VA = "0x183A27D90", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A07870", Offset = "0x2A06A70", VA = "0x182A07870", Slot = "13")]
	public bool Contains(T FNPJDMFCFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A27DF0", Offset = "0x3A26FF0", VA = "0x183A27DF0", Slot = "14")]
	public void CopyTo(T[] BGBPILICHHA, int AAOCMLFBPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3788DB0", Offset = "0x3787FB0", VA = "0x183788DB0", Slot = "6")]
	public int IndexOf(T FNPJDMFCFGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3A27F70", Offset = "0x3A27170", VA = "0x183A27F70", Slot = "7")]
	public void Insert(int MMFFFGBLCAP, T FNPJDMFCFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3A282D0", Offset = "0x3A274D0", VA = "0x183A282D0", Slot = "8")]
	public void RemoveAt(int MMFFFGBLCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3A28200", Offset = "0x3A27400", VA = "0x183A28200")]
	public void PGLKDBJAHNO(Predicate<T> CGMEGCMIEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3A28100", Offset = "0x3A27300", VA = "0x183A28100")]
	public void MPGBILMCMBH(Comparison<T> GJOMOBPAAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3A28580", Offset = "0x3A27780", VA = "0x183A28580")]
	public PADBHJODHGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class ILNFECEPGHG
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7050C90", Offset = "0x704FE90", VA = "0x187050C90")]
	public static Vector3 OLLODEMOJFG(this GameObject JBOGCBPFIGA, float IMFDPLEGAAL)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class BDHMCMOMLMO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Type NAEDGGFCFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly string HFNNJCGIGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool NCCKPDAKDAM;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x704E890", Offset = "0x704DA90", VA = "0x18704E890")]
	public BDHMCMOMLMO(Type KAJMMOAGCEK, string KHNGECPLOBO, bool KFJEICDOIIH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class BBAJEOJEEBH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x704E7A0", Offset = "0x704D9A0", VA = "0x18704E7A0")]
	public BBAJEOJEEBH(string CEOMJLPEFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x704E810", Offset = "0x704DA10", VA = "0x18704E810")]
	public BBAJEOJEEBH(string CEOMJLPEFPB, Exception EKEFPFGKHCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class HOLOADHCDJN
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7050C50", Offset = "0x704FE50", VA = "0x187050C50")]
	[NotNull]
	public static byte[] EDGGNGEMHGD(this NONFCAAACAJ NJJADDJNOHJ, byte[] BCILDAKHBAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7050A10", Offset = "0x704FC10", VA = "0x187050A10")]
	[NotNull]
	public static byte[] EDGGNGEMHGD(this NONFCAAACAJ NJJADDJNOHJ, HashAlgorithmName DAJHMPBENIB, byte[] BCILDAKHBAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface NONFCAAACAJ
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash AMEEDJNJKBN);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface MHKMPHFAJMJ : NONFCAAACAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] NHNPHCCFAKH
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
	byte[] DHADIJBMMKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	UnityEngine.Object MLEJIKFBGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class CICGKFBEKJO
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MNFCFPPJMAF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x70523B0", Offset = "0x70515B0", VA = "0x1870523B0")]
		public MNFCFPPJMAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7052350", Offset = "0x7051550", VA = "0x187052350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const byte LMGKDHIJNPD = 1;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const byte KBOEPFOGMGL = 0;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> CJHIBEPPMOJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static bool OBJPHHFEPHJ;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3231F20", Offset = "0x3231120", VA = "0x183231F20")]
	[Conditional("UNITY_EDITOR")]
	private static void OCMLOGLFLBH<T>(params T[] NCAOKALGGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x704E950", Offset = "0x704DB50", VA = "0x18704E950")]
	public static IDisposable AIEGMEJNKAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x704F400", Offset = "0x704E600", VA = "0x18704F400")]
	public static void LMKEENNIKNH(this IncrementalHash PBGBDHDAIAA, [CanBeNull] GameObject JBOGCBPFIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3231E50", Offset = "0x3231050", VA = "0x183231E50")]
	public static void LMKEENNIKNH<T>(this IncrementalHash PBGBDHDAIAA, [CanBeNull] T FEFGGGJBLPM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3232210", Offset = "0x3231410", VA = "0x183232210")]
	public static void OKMAMDCGAHE<T>(this IncrementalHash PBGBDHDAIAA, [CanBeNull] T NJJADDJNOHJ) where T : NONFCAAACAJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3231A00", Offset = "0x3230C00", VA = "0x183231A00")]
	public static void IHGOFKKFFAM<T>(this IncrementalHash PBGBDHDAIAA, [CanBeNull] IList<T> ECDGGJCNHLJ) where T : NONFCAAACAJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x704F310", Offset = "0x704E510", VA = "0x18704F310")]
	private static bool LGMJOFJFJHK([CanBeNull] NONFCAAACAJ NJJADDJNOHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x704F6B0", Offset = "0x704E8B0", VA = "0x18704F6B0")]
	public static void NGEPDHNKNHP(this IncrementalHash AMEEDJNJKBN, [CanBeNull] string MJFCGLJJIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x704EF60", Offset = "0x704E160", VA = "0x18704EF60")]
	public static void INNBHPPLEOL(this IncrementalHash AMEEDJNJKBN, long LDBEJDBPLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x704EBC0", Offset = "0x704DDC0", VA = "0x18704EBC0")]
	public static void HLEBONHMLAG(this IncrementalHash AMEEDJNJKBN, int OFNGIHKLCIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x704ED90", Offset = "0x704DF90", VA = "0x18704ED90")]
	public static void IJGGECFLFIC(this IncrementalHash AMEEDJNJKBN, short KOGAAKCKFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x704F130", Offset = "0x704E330", VA = "0x18704F130")]
	public static void KJOIOBNCLBN(this IncrementalHash AMEEDJNJKBN, byte EGAFAOHODNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x704E9F0", Offset = "0x704DBF0", VA = "0x18704E9F0")]
	public static void CPPBDNPPBLG(this IncrementalHash AMEEDJNJKBN, bool LPMKDBOIIOF, bool HBIBNFJAJFJ = false, bool BOKAGGGFIJJ = false, bool NLPFIPANPKP = false, bool CAOJEOKPGGA = false, bool DBCCPEEENKO = false, bool AAAJDNKPLEB = false, bool PEJHEKANCJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3231310", Offset = "0x3230510", VA = "0x183231310")]
	public static void BMNBHLDHADO<T>(this IncrementalHash AMEEDJNJKBN, T PLDCKCJJIHJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x704F3A0", Offset = "0x704E5A0", VA = "0x18704F3A0")]
	public static void LJEADPALEIJ(this IncrementalHash AMEEDJNJKBN, float AJJEPNKKOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x704F710", Offset = "0x704E910", VA = "0x18704F710")]
	public static void OGCGJKJCHLG(this IncrementalHash AMEEDJNJKBN, double EOEDGMMJDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x704F930", Offset = "0x704EB30", VA = "0x18704F930")]
	public static void PJCODLIHNFH(this IncrementalHash AMEEDJNJKBN, ulong NCLBFJIHANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x704F4F0", Offset = "0x704E6F0", VA = "0x18704F4F0")]
	public static void MHMFFHOGMKN(this IncrementalHash AMEEDJNJKBN, uint NODKKGCEJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x704F2A0", Offset = "0x704E4A0", VA = "0x18704F2A0")]
	public static void LBKLLEDLHJA(this IncrementalHash AMEEDJNJKBN, ushort JMLLGMCGGED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x704F550", Offset = "0x704E750", VA = "0x18704F550")]
	public static void MJJLNJNECGH(this IncrementalHash AMEEDJNJKBN, Vector3 FGHILJPOAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x704F770", Offset = "0x704E970", VA = "0x18704F770")]
	public static void PCHNPNAMCDF(this IncrementalHash AMEEDJNJKBN, Quaternion PLECDCOLAIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class PHMAKHCDOFN
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x70534D0", Offset = "0x70526D0", VA = "0x1870534D0")]
	[NotNull]
	public static byte[] EDGGNGEMHGD(this MHKMPHFAJMJ MIMLMHJMNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7053460", Offset = "0x7052660", VA = "0x187053460")]
	[NotNull]
	public static byte[] EDGGNGEMHGD(this MHKMPHFAJMJ MIMLMHJMNID, HashAlgorithmName DAJHMPBENIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x70530C0", Offset = "0x70522C0", VA = "0x1870530C0")]
	public static bool AHFDLJGKMIK([CanBeNull] this MHKMPHFAJMJ MIMLMHJMNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7053250", Offset = "0x7052450", VA = "0x187053250")]
	public static bool AHFDLJGKMIK([CanBeNull] this MHKMPHFAJMJ MIMLMHJMNID, out string KLEKJFJOCHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x70533F0", Offset = "0x70525F0", VA = "0x1870533F0")]
	private static string CJBELEDDECG([CanBeNull] byte[] KJNADKBIDLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7053540", Offset = "0x7052740", VA = "0x187053540")]
	private static bool HPEIGCLMCBA([NotNull] MHKMPHFAJMJ MIMLMHJMNID, [CanBeNull] out byte[] BHPCGLHEMOJ, [CanBeNull] out byte[] ALEFKOCDIOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class EGGJLDCBMLG<TTask, T> : GHFDPPJAELF<T>, AEAAPGKBHMO, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class GPFAHFILBIN
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
			public GPFAHFILBIN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2785D30", Offset = "0x2784F30", VA = "0x182785D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
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
		public EGGJLDCBMLG<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public GPFAHFILBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x435E750", Offset = "0x435D950", VA = "0x18435E750")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(EGGJLDCBMLG<, >.GPFAHFILBIN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> DCDANKDBFFO(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static bool AEABJMFHKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Task<T> ONPFLGLLMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly CancellationTokenSource AKHLKBFAFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool PFALPCMNDEH;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Task<T> CMLFGHHIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Task KCBMFLPLCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NHJDNADPIAN<T> GJKBIGEEPND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private OOPPNGPPPLE LBPPKDMGKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1CBDF40", Offset = "0x1CBD140", VA = "0x181CBDF40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool FKBOPHAPEKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x98C9A0", Offset = "0x98BBA0", VA = "0x18098C9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4484E90", Offset = "0x4484090", VA = "0x184484E90")]
	static EGGJLDCBMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x44851B0", Offset = "0x44843B0", VA = "0x1844851B0")]
	protected EGGJLDCBMLG(TTask ONPFLGLLMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x44848D0", Offset = "0x4483AD0", VA = "0x1844848D0", Slot = "1")]
	~EGGJLDCBMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x44848A0", Offset = "0x4483AA0", VA = "0x1844848A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4484940", Offset = "0x4483B40", VA = "0x184484940")]
	private void JKAFMKKGOFG(bool MBCCAJBGDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T JEHHDBBMLMF(TTask PFJAIBNPAAG);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DFFAFFJMOHP();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ECKMBJIMCNO : LKLPNOOJGDG<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x70501F0", Offset = "0x704F3F0", VA = "0x1870501F0")]
	public ECKMBJIMCNO(Exception DFGDJPCDEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class LKLPNOOJGDG<T> : GHFDPPJAELF<T>, AEAAPGKBHMO, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public Task<T> CMLFGHHIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private Task KCBMFLPLCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x19D5A50", Offset = "0x19D4C50", VA = "0x1819D5A50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NHJDNADPIAN<T> GJKBIGEEPND
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private OOPPNGPPPLE LBPPKDMGKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1CCDC40", Offset = "0x1CCCE40", VA = "0x181CCDC40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x3E91270", Offset = "0x3E90470", VA = "0x183E91270")]
	public LKLPNOOJGDG(Exception DFGDJPCDEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface AEAAPGKBHMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[NotNull]
	Task CMLFGHHIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[NotNull]
	OOPPNGPPPLE GJKBIGEEPND
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface GHFDPPJAELF<T> : AEAAPGKBHMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[NotNull]
	new Task<T> CMLFGHHIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	new NHJDNADPIAN<T> GJKBIGEEPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class ANPMDOGBOHP : ACLCPINGGBG<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x704E700", Offset = "0x704D900", VA = "0x18704E700")]
	public ANPMDOGBOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ACLCPINGGBG<T> : GHFDPPJAELF<T>, AEAAPGKBHMO, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Task<T> CMLFGHHIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private Task KCBMFLPLCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x19D5A50", Offset = "0x19D4C50", VA = "0x1819D5A50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public NHJDNADPIAN<T> GJKBIGEEPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private OOPPNGPPPLE LBPPKDMGKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1CCDC40", Offset = "0x1CCCE40", VA = "0x181CCDC40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x42E75A0", Offset = "0x42E67A0", VA = "0x1842E75A0")]
	public ACLCPINGGBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public sealed class JJCILEKGKNO : FDMIABHIEGI<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class IMLOPCIKEON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action<JJCILEKGKNO> callback;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public IMLOPCIKEON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7050F40", Offset = "0x7050140", VA = "0x187050F40")]
		internal void IFOONFCBGMN(FDMIABHIEGI<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7051260", Offset = "0x7050460", VA = "0x187051260")]
	public JJCILEKGKNO([Optional] string DIFHJJLNJAD, [Optional] int? CJLCCBCMJMJ, [Optional] Stopwatch EPHPKLLOIMP, [Optional] Action<string, AGKEECKOJAL> GKAJEMLIAMA, [Optional] Action<string, AGKEECKOJAL> NHGFJDDBBCG, [Optional] Action<JJCILEKGKNO> HGAFBJEAPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7051180", Offset = "0x7050380", VA = "0x187051180")]
	private static Action<FDMIABHIEGI<string>> GDJCGPLABPD(Action<JJCILEKGKNO> NMCNKNBHPHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class PBKBMJELNMD<TKey> : CIHBFAIMGJD<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IJCJDLKAGBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public NDMABMFIIAH keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public IJCJDLKAGBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2754CF0", Offset = "0x2753EF0", VA = "0x182754CF0")]
		internal string GMGDPPDIFKI(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x35D2CA0", Offset = "0x35D1EA0", VA = "0x1835D2CA0", Slot = "5")]
	protected override string KOIDLGBEPDF(FDMIABHIEGI<TKey> FIIEBNCLKIG, NDMABMFIIAH ONIEKKCMKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3563B30", Offset = "0x3562D30", VA = "0x183563B30")]
	public PBKBMJELNMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class KOMKCEJKLMB<TKey> : NGKKKGMLDEB<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate string ADKMMOJKJPO(TKey PPNIGBBPGOI);

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private const int BPPJAJIODJD = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly string JIDOFBOHBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly double JNKGNGFFMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool GLAAOPNLGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly int CKLOEGJJIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly ISet<string> MFAEMLAEGCM;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4162600", Offset = "0x4161800", VA = "0x184162600")]
	private static string HMFKOENCMNL(TKey PPNIGBBPGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x41628D0", Offset = "0x4161AD0", VA = "0x1841628D0")]
	public KOMKCEJKLMB(string JIDOFBOHBIK = "F2", double JNKGNGFFMIB = double.MaxValue, bool GLAAOPNLGHI = false, int CKLOEGJJIJC = int.MaxValue, [Optional] ISet<string> MFAEMLAEGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4162550", Offset = "0x4161750", VA = "0x184162550", Slot = "4")]
	public override Dictionary<string, string> BMKEOOEIBFN(FDMIABHIEGI<TKey> FIIEBNCLKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x41627F0", Offset = "0x41619F0", VA = "0x1841627F0")]
	private bool MPDBANAJMFL(string LGKJBPHKGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4162010", Offset = "0x4161210", VA = "0x184162010")]
	public Dictionary<string, string> BMKEOOEIBFN(FDMIABHIEGI<TKey> FIIEBNCLKIG, ADKMMOJKJPO ONIEKKCMKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4162640", Offset = "0x4161840", VA = "0x184162640")]
	private string KADDLNJHFJD(StringBuilder BKCLLPJKFBD, List<TKey> CDHAFCBBPFP, ADKMMOJKJPO ONIEKKCMKAF, bool BHFFAJNLJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4161E90", Offset = "0x4161090", VA = "0x184161E90")]
	private static void ALODGHJBGJL(StringBuilder FCHEHFNMIFM, string BGJPGAFDHFB, bool HDKPGAAHMKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class NGKKKGMLDEB<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BMKEOOEIBFN(FDMIABHIEGI<TKey> FIIEBNCLKIG);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
	protected NGKKKGMLDEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class CIHBFAIMGJD<TKey> : NGKKKGMLDEB<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate string NDMABMFIIAH(TKey PPNIGBBPGOI);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5063490", Offset = "0x5062690", VA = "0x185063490")]
	protected string COFCAPJIKIE(double POHCFECJIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5063540", Offset = "0x5062740", VA = "0x185063540")]
	protected string MKLPDPHFGDF(int MFALIHBNCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5063500", Offset = "0x5062700", VA = "0x185063500")]
	private static string HMFKOENCMNL(TKey PPNIGBBPGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x50632B0", Offset = "0x50624B0", VA = "0x1850632B0", Slot = "4")]
	public override string BMKEOOEIBFN(FDMIABHIEGI<TKey> FIIEBNCLKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5063360", Offset = "0x5062560", VA = "0x185063360")]
	public string BMKEOOEIBFN(FDMIABHIEGI<TKey> FIIEBNCLKIG, [NotNull] NDMABMFIIAH ONIEKKCMKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string KOIDLGBEPDF(FDMIABHIEGI<TKey> FIIEBNCLKIG, [NotNull] NDMABMFIIAH ONIEKKCMKAF);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2DC6650", Offset = "0x2DC5850", VA = "0x182DC6650")]
	protected CIHBFAIMGJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class CNDNDDEGDIP
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private class JBONGHEFADG : CNDNDDEGDIP
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static CNDNDDEGDIP EBEPLDELFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7051020", Offset = "0x7050220", VA = "0x187051020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override DateTime IECNEGFGECD
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x7050FD0", Offset = "0x70501D0", VA = "0x187050FD0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override float NANOOMHBJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x15AECF0", Offset = "0x15ADEF0", VA = "0x1815AECF0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7051120", Offset = "0x7050320", VA = "0x187051120")]
		public JBONGHEFADG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static CNDNDDEGDIP FKGGNCFMKPH;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static CNDNDDEGDIP OONGDIKAKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x704FE40", Offset = "0x704F040", VA = "0x18704FE40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public abstract DateTime IECNEGFGECD
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public abstract float NANOOMHBJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	protected CNDNDDEGDIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class FFOGBFLAOKK<TKey> : CIHBFAIMGJD<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct JJPAIOCIPKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public NDMABMFIIAH keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static FFOGBFLAOKK<TKey> EBEPLDELFOG;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private const int CJHOFDLCKJL = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly string[] HJLCOIMPMEP;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x4C48AA0", Offset = "0x4C47CA0", VA = "0x184C48AA0")]
	private FFOGBFLAOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x4C47AE0", Offset = "0x4C46CE0", VA = "0x184C47AE0", Slot = "5")]
	protected override string KOIDLGBEPDF(FDMIABHIEGI<TKey> FIIEBNCLKIG, NDMABMFIIAH ONIEKKCMKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x4C479F0", Offset = "0x4C46BF0", VA = "0x184C479F0")]
	[CompilerGenerated]
	internal static string EKGMFLLCHDE(string MIAPLFPNFMC, TKey PPNIGBBPGOI, ref JJPAIOCIPKC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FDMIABHIEGI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public readonly struct AGKEECKOJAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly long DHGHOEGBHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly long MAIJHOKAENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly int CJLCCBCMJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly int DAFMKIOOIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly bool ENPKCAJJKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly string JFGABLLOHLE;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x4C73C10", Offset = "0x4C72E10", VA = "0x184C73C10")]
		public AGKEECKOJAL(long DHGHOEGBHAA, int CJLCCBCMJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x4C73BE0", Offset = "0x4C72DE0", VA = "0x184C73BE0")]
		public AGKEECKOJAL(long DHGHOEGBHAA, long MAIJHOKAENM, int CJLCCBCMJMJ, int DAFMKIOOIDI, bool ENPKCAJJKCH, string JFGABLLOHLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x4C73B40", Offset = "0x4C72D40", VA = "0x184C73B40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void JKGDILJCPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x4C73AF0", Offset = "0x4C72CF0", VA = "0x184C73AF0")]
		public int FPOEDMHKDNH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x4C73BC0", Offset = "0x4C72DC0", VA = "0x184C73BC0")]
		public int NCBJKHGFKGN(int DODAIOPDFEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x4C739C0", Offset = "0x4C72BC0", VA = "0x184C739C0")]
		public double FLOIIMHBOGC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x4C73A30", Offset = "0x4C72C30", VA = "0x184C73A30")]
		public AGKEECKOJAL FPCEIJPPNDG(long MAIJHOKAENM, int DAFMKIOOIDI)
		{
			return default(AGKEECKOJAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class JOOBNAKNCND : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class KAEKHHLKHIO<T> : IAsyncStateMachine
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
			public Func<JOOBNAKNCND, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public JOOBNAKNCND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private JOOBNAKNCND <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
			public KAEKHHLKHIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5F30", Offset = "0x2DC5130", VA = "0x182DC5F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly TKey EGHHJNNLLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly FDMIABHIEGI<TKey> FIIEBNCLKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private List<JOOBNAKNCND> GKGLPNFCILC;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string EGKEADLEDBH
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1913FA0", Offset = "0x19131A0", VA = "0x181913FA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x3617AE0", Offset = "0x3616CE0", VA = "0x183617AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEnumerable<JOOBNAKNCND> HBAAOHAMFOH
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x3617C20", Offset = "0x3616E20", VA = "0x183617C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public AGKEECKOJAL CIPBNLJOEKF
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x1E22C70", Offset = "0x1E21E70", VA = "0x181E22C70")]
			[CompilerGenerated]
			get
			{
				return default(AGKEECKOJAL);
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x3617AB0", Offset = "0x3616CB0", VA = "0x183617AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3617C40", Offset = "0x3616E40", VA = "0x183617C40")]
		internal JOOBNAKNCND(FDMIABHIEGI<TKey> FIIEBNCLKIG, TKey PPNIGBBPGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3617B10", Offset = "0x3616D10", VA = "0x183617B10")]
		public JOOBNAKNCND MNGJKKEPDDK(TKey PPNIGBBPGOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x36179D0", Offset = "0x3616BD0", VA = "0x1836179D0")]
		public void GDJCGPLABPD(TKey PPNIGBBPGOI, Action<JOOBNAKNCND> JFFMHPNGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3D20A80", Offset = "0x3D1FC80", VA = "0x183D20A80")]
		public T GDJCGPLABPD<T>(TKey PPNIGBBPGOI, Func<JOOBNAKNCND, T> MKHLEPDKFPF)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3D20BD0", Offset = "0x3D1FDD0", VA = "0x183D20BD0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KAEKHHLKHIO<>))]
		public Task<T> IAKMKICBNIC<T>(TKey PPNIGBBPGOI, Func<JOOBNAKNCND, Task<T>> MKHLEPDKFPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3617820", Offset = "0x3616A20", VA = "0x183617820", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class PMBKLMGJNOB : IEnumerable<(TKey, List<TKey>, AGKEECKOJAL)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AGKEECKOJAL)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private (TKey key, List<TKey> path, AGKEECKOJAL timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public FDMIABHIEGI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private IEnumerator<(TKey key, List<TKey> path, AGKEECKOJAL timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private (TKey key, List<TKey> path, AGKEECKOJAL timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private (TKey, List<TKey>, AGKEECKOJAL) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x31CC8A0", Offset = "0x31CBAA0", VA = "0x1831CC8A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AGKEECKOJAL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x31CC910", Offset = "0x31CBB10", VA = "0x1831CC910", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x31CC970", Offset = "0x31CBB70", VA = "0x1831CC970")]
		[DebuggerHidden]
		public PMBKLMGJNOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2DC66C0", Offset = "0x2DC58C0", VA = "0x182DC66C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x31CC450", Offset = "0x31CB650", VA = "0x1831CC450", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x31CC400", Offset = "0x31CB600", VA = "0x1831CC400")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x31CC8D0", Offset = "0x31CBAD0", VA = "0x1831CC8D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x31CC7E0", Offset = "0x31CB9E0", VA = "0x1831CC7E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AGKEECKOJAL)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2F5E3C0", Offset = "0x2F5D5C0", VA = "0x182F5E3C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class DJGKLJOENNF : IEnumerable<(TKey, List<TKey>, AGKEECKOJAL)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AGKEECKOJAL)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private (TKey key, List<TKey> path, AGKEECKOJAL timerEntry) <>2__current;

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
		private JOOBNAKNCND timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public JOOBNAKNCND <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public FDMIABHIEGI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private IEnumerator<JOOBNAKNCND> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private JOOBNAKNCND <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private IEnumerator<(TKey key, List<TKey> path, AGKEECKOJAL timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private (TKey key, List<TKey> path, AGKEECKOJAL timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private (TKey, List<TKey>, AGKEECKOJAL) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x31CC8A0", Offset = "0x31CBAA0", VA = "0x1831CC8A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AGKEECKOJAL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x437F020", Offset = "0x437E220", VA = "0x18437F020", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x31CC970", Offset = "0x31CBB70", VA = "0x1831CC970")]
		[DebuggerHidden]
		public DJGKLJOENNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x437F080", Offset = "0x437E280", VA = "0x18437F080", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x437E890", Offset = "0x437DA90", VA = "0x18437E890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x437E830", Offset = "0x437DA30", VA = "0x18437E830")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x437EEA0", Offset = "0x437E0A0", VA = "0x18437EEA0")]
		private void PKFPAMEJFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x437EFE0", Offset = "0x437E1E0", VA = "0x18437EFE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x437EF00", Offset = "0x437E100", VA = "0x18437EF00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AGKEECKOJAL)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x3A19B40", Offset = "0x3A18D40", VA = "0x183A19B40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<TKey, AGKEECKOJAL> GKAJEMLIAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action<TKey, AGKEECKOJAL> NHGFJDDBBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Action<FDMIABHIEGI<TKey>> HGAFBJEAPKB;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private const string NHMOJPLGCFN = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly JOOBNAKNCND PJMIAIHELAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool PFALPCMNDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private int BPLNNBEHHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly Stopwatch EPHPKLLOIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly int MLJBBLDLHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private string JLMBGPEHMCA;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public JOOBNAKNCND GIPFBKMLFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	public string EGKEADLEDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BF0", Offset = "0x8D5DF0", VA = "0x1808D6BF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x4C447D0", Offset = "0x4C439D0", VA = "0x184C447D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public long DKJKJOJGJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x4C447B0", Offset = "0x4C439B0", VA = "0x184C447B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int IKHNHNLPIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x4C44990", Offset = "0x4C43B90", VA = "0x184C44990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x4C449E0", Offset = "0x4C43BE0", VA = "0x184C449E0")]
	public FDMIABHIEGI(TKey FMFMCBEHKBM, [Optional] int? CJLCCBCMJMJ, [Optional][CanBeNull] Stopwatch EPHPKLLOIMP, [Optional] Action<TKey, AGKEECKOJAL> GKAJEMLIAMA, [Optional] Action<TKey, AGKEECKOJAL> NHGFJDDBBCG, [Optional] Action<FDMIABHIEGI<TKey>> HGAFBJEAPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x4C44700", Offset = "0x4C43900", VA = "0x184C44700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x4C449C0", Offset = "0x4C43BC0", VA = "0x184C449C0")]
	public void OPIKCMHHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x4C44790", Offset = "0x4C43990", VA = "0x184C44790")]
	public void ECGCMEELJCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x4C44900", Offset = "0x4C43B00", VA = "0x184C44900")]
	[IteratorStateMachine(typeof(FDMIABHIEGI<>.PMBKLMGJNOB))]
	public IEnumerable<(TKey, List<TKey>, AGKEECKOJAL)> KPLIAKEFPKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4C44830", Offset = "0x4C43A30", VA = "0x184C44830")]
	[IteratorStateMachine(typeof(FDMIABHIEGI<>.DJGKLJOENNF))]
	private IEnumerable<(TKey, List<TKey>, AGKEECKOJAL)> KPLIAKEFPKI(List<TKey> KMBFNDAPCGA, JOOBNAKNCND MNHLDBJPMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4C44680", Offset = "0x4C43880", VA = "0x184C44680")]
	private (long, int) ANBNAKAALJJ()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class NDKMEJDBIDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<byte, EMACOMLFMJO> FPNDEAKKKCO;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public EMACOMLFMJO KEALKMMNLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 EOHCMEFJLPE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x125EED0", Offset = "0x125E0D0", VA = "0x18125EED0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x91FA50", Offset = "0x91EC50", VA = "0x18091FA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 FMMACNBOAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1CCE350", Offset = "0x1CCD550", VA = "0x181CCE350")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x98C980", Offset = "0x98BB80", VA = "0x18098C980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 NADLCBCGOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7052680", Offset = "0x7051880", VA = "0x187052680")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9966D0", Offset = "0x9958D0", VA = "0x1809966D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int ONFEODGCFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C00", Offset = "0x8D5E00", VA = "0x1808D6C00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x9568B0", Offset = "0x955AB0", VA = "0x1809568B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x7052BE0", Offset = "0x7051DE0", VA = "0x187052BE0")]
	public NDKMEJDBIDD(Bounds LKMGHLKBGEB, Vector2[] DGICOBCLLOP, int JBFFGNJAGGA, byte PFBJKNIILDN, float EICFKAFGHJE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7052B80", Offset = "0x7051D80", VA = "0x187052B80")]
	public EMACOMLFMJO KDHGOOLLPFM(byte MMFFFGBLCAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x70526A0", Offset = "0x70518A0", VA = "0x1870526A0")]
	public void GGLHMLMLEBG(Vector3 FNDKHLEFPKD, float OGDMHOJKOGL, float BDHGDIGOEOI, ref List<byte> IIAOPFDLAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7052660", Offset = "0x7051860", VA = "0x187052660")]
	public void BJHMKALGBIK(EMACOMLFMJO.NGHBJKEGMOG CNLDKDPDADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7052500", Offset = "0x7051700", VA = "0x187052500")]
	private EMACOMLFMJO BBEOCAMHEMD(byte MMFFFGBLCAP, EMACOMLFMJO.KKEKNKGCMCI NPGHLNFEILH, EMACOMLFMJO BLFIAOLNAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x70527A0", Offset = "0x70519A0", VA = "0x1870527A0")]
	private void JPILFDJPCJI(EMACOMLFMJO BLFIAOLNAKG, Vector2[] DGICOBCLLOP, int LONAHPKPOPN, int IKDBCNEMDGC, int GGAIHAMIBJB, int HCHCCHNLOIM, float EICFKAFGHJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class EMACOMLFMJO
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum KKEKNKGCMCI
	{
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum NGHBJKEGMOG
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
	public byte IDOFGLOHIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3 HLEPPDKPGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Vector3 DAIIDNNJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3 JNIMBACOFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector3 AIHOGBBLFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public KKEKNKGCMCI OIGOBHPLNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public EMACOMLFMJO JBMONCCPLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public List<EMACOMLFMJO> EAJBOKKKEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool ABENNLEOLDO;

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x70505B0", Offset = "0x704F7B0", VA = "0x1870505B0")]
	public EMACOMLFMJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x70505D0", Offset = "0x704F7D0", VA = "0x1870505D0")]
	public EMACOMLFMJO(byte OOLLEDEIDOE, KKEKNKGCMCI NPGHLNFEILH, EMACOMLFMJO BLFIAOLNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x70504A0", Offset = "0x704F6A0", VA = "0x1870504A0")]
	public void KPDBLCMOHKN(EMACOMLFMJO DGKHGILMPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public void BJHMKALGBIK(int KHCBOPHFLFJ, NGHBJKEGMOG CNLDKDPDADF, int IIOPOIMDCED = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7050270", Offset = "0x704F470", VA = "0x187050270")]
	public void GGLHMLMLEBG(List<byte> IIAOPFDLAHB, Vector3 FNDKHLEFPKD, float OGDMHOJKOGL, float BDHGDIGOEOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7050560", Offset = "0x704F760", VA = "0x187050560")]
	public bool MKHPJKHOFPO(Vector3 EAHAAFIPGDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7050240", Offset = "0x704F440", VA = "0x187050240")]
	public bool FBBJNIEPKOH(Vector3 EAHAAFIPGDC, float GEJHBGODFNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class EPKHAMBBLCH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly Stack<T> OFDHKOKKHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly List<T> PANKJLCFKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly int PGPGBFDDDCI;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int NBCBMMFOOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1913FA0", Offset = "0x19131A0", VA = "0x181913FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int DMGIBHJIDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x19142C0", Offset = "0x19134C0", VA = "0x1819142C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x19142F0", Offset = "0x19134F0", VA = "0x1819142F0")]
	public static EPKHAMBBLCH<T> GDKMOJHLHOA(int HBHBCIIAIII = 0, int PGPGBFDDDCI = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x19143C0", Offset = "0x19135C0", VA = "0x1819143C0")]
	public static EPKHAMBBLCH<T> IDPDFHCMOIC(int HBHBCIIAIII = 0, int PGPGBFDDDCI = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1914860", Offset = "0x1913A60", VA = "0x181914860")]
	public EPKHAMBBLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x19148A0", Offset = "0x1913AA0", VA = "0x1819148A0")]
	public EPKHAMBBLCH(int HBHBCIIAIII, int PGPGBFDDDCI = int.MaxValue, bool OMDHCHLKPHH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x19141B0", Offset = "0x19133B0", VA = "0x1819141B0")]
	public T EFFDEGLHNCL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1914490", Offset = "0x1913690", VA = "0x181914490")]
	public void JJIPAOHMDGA(T ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1913FF0", Offset = "0x19131F0", VA = "0x181913FF0")]
	private void DDIHMBHIMME(T ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x1913FD0", Offset = "0x19131D0", VA = "0x181913FD0")]
	private void BOFGHFOFEMI(T ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1914530", Offset = "0x1913730", VA = "0x181914530")]
	[Conditional("DEBUG_BUILD")]
	private void KFAMNBJLGMJ(T CDBPJPHHEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x19147D0", Offset = "0x19139D0", VA = "0x1819147D0")]
	[Conditional("DEBUG_BUILD")]
	private void OMKODJGDEJO(T CDBPJPHHEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x19140C0", Offset = "0x19132C0", VA = "0x1819140C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x19145C0", Offset = "0x19137C0", VA = "0x1819145C0")]
	private void NKKCFOLEEPL(IEnumerable<T> DNDGJFJKDEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class JLJGCLFPKJM
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private enum KFMMDECFLBE : byte
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
	private int AMEEDJNJKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private bool KDCHJDMGHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private KFMMDECFLBE OJBGFLKOHML;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool GKMFIPLKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x70513B0", Offset = "0x70505B0", VA = "0x1870513B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool AMLAFCKBEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x70516C0", Offset = "0x70508C0", VA = "0x1870516C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7052230", Offset = "0x7051430", VA = "0x187052230")]
	public JLJGCLFPKJM(bool KDCHJDMGHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7051BF0", Offset = "0x7050DF0", VA = "0x187051BF0")]
	public void OKCAHPLEJOG(object BHEOHCEHIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x70516E0", Offset = "0x70508E0", VA = "0x1870516E0")]
	public void LAOGCKBOPNH(int ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x70516D0", Offset = "0x70508D0", VA = "0x1870516D0")]
	public void KIEMOJOEBDK(uint MGKHOLFHOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7051B60", Offset = "0x7050D60", VA = "0x187051B60")]
	public void ODMGCFFBFFM(bool PEFKDNLCLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x70515A0", Offset = "0x70507A0", VA = "0x1870515A0")]
	public void FPENFAEGEAP(long HFMINFFOABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x70513C0", Offset = "0x70505C0", VA = "0x1870513C0")]
	public void CHNKEAEDFLP(ulong AIOIFPJLNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x70515E0", Offset = "0x70507E0", VA = "0x1870515E0")]
	public void HLFGALAPBKJ(string MKPBIBAIDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7051780", Offset = "0x7050980", VA = "0x187051780")]
	public void MPGJAFCBKOO(Enum DFGDJPCDEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7051480", Offset = "0x7050680", VA = "0x187051480")]
	public void DFDPAEJDIJH(IList IEKCFDAIBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2579800", Offset = "0x2578A00", VA = "0x182579800")]
	public void GEFCKEIOBKJ<T, U>(Dictionary<T, U> GLAKBFAJMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7051810", Offset = "0x7050A10", VA = "0x187051810")]
	private void NLGBALGNNCD(IDictionary GLAKBFAJMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7051B80", Offset = "0x7050D80", VA = "0x187051B80")]
	public int OFDNMPJABEN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7051650", Offset = "0x7050850", VA = "0x187051650")]
	public short IAAHPBCNOOK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7051470", Offset = "0x7050670", VA = "0x187051470")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7051400", Offset = "0x7050600", VA = "0x187051400")]
	private void CPGDOIGHIEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface BDAOIPGEHMP
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class ResourcePrefabReference<T> : BDAOIPGEHMP where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A144F0", Offset = "0x3A136F0", VA = "0x183A144F0", Slot = "4")]
		public virtual T CPHGFJDPFOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GLDPNECOOLK<T> : IEnumerable<GLDPNECOOLK<T>.BOMHCKJOAPB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct BOMHCKJOAPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public T ACKOJNNBEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int MMFFFGBLCAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class IDFDJJCHMID : IEnumerator<BOMHCKJOAPB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private GLDPNECOOLK<T> DADDIMDIKMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int MMFFFGBLCAP;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x1919280", Offset = "0x1918480", VA = "0x181919280", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public BOMHCKJOAPB HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x29FF440", Offset = "0x29FE640", VA = "0x1829FF440", Slot = "4")]
			get
			{
				return default(BOMHCKJOAPB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DC140", Offset = "0x8DB340", VA = "0x1808DC140")]
		public IDFDJJCHMID(GLDPNECOOLK<T> DADDIMDIKMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x29FF3C0", Offset = "0x29FE5C0", VA = "0x1829FF3C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DC130", Offset = "0x8DB330", VA = "0x1808DC130", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x10C0640", Offset = "0x10BF840", VA = "0x1810C0640", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct NADOKDJJMNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public bool KCMMJEHFFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public T ACKOJNNBEBO;
	}

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private const int PJAGGHJCANM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly Dictionary<T, int> JMCMPFHDKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private NADOKDJJMNF[] GCAOLBHCHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int EFLAEOAOABC;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int BOHOEOMPJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8F8970", Offset = "0x8F7B70", VA = "0x1808F8970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x981950", Offset = "0x980B50", VA = "0x180981950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2904080", Offset = "0x2903280", VA = "0x182904080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x41B4E50", Offset = "0x41B4050", VA = "0x1841B4E50")]
	public GLDPNECOOLK(int HBHBCIIAIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x41B4F20", Offset = "0x41B4120", VA = "0x1841B4F20")]
	public GLDPNECOOLK(BOMHCKJOAPB[] NIHGMDMPKHO, bool GGDNCMDFBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x41B3BB0", Offset = "0x41B2DB0", VA = "0x1841B3BB0")]
	public int CPNDCGMKFLG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x41B4950", Offset = "0x41B3B50", VA = "0x1841B4950")]
	private int OEIGAKKKCMA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x41B4630", Offset = "0x41B3830", VA = "0x1841B4630", Slot = "6")]
	protected virtual uint ICBFHOMDOOL(uint AMEEDJNJKBN, T ACKOJNNBEBO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x41B3B70", Offset = "0x41B2D70", VA = "0x1841B3B70")]
	public bool BNLINIFLGKC(T ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x41B4720", Offset = "0x41B3920", VA = "0x1841B4720")]
	public bool ODNHCOOIOFN(int MMFFFGBLCAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x41B4D00", Offset = "0x41B3F00", VA = "0x1841B4D00")]
	public bool PLLNGOBMPBN(Func<T, bool> KKHDHHGCHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x41B45D0", Offset = "0x41B37D0", VA = "0x1841B45D0")]
	public int HFKAPKGGBOP(T ACKOJNNBEBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x41B3A50", Offset = "0x41B2C50", VA = "0x1841B3A50")]
	public T APPLNLCEBGC(int MMFFFGBLCAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x41B3C20", Offset = "0x41B2E20", VA = "0x1841B3C20")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x41B4120", Offset = "0x41B3320", VA = "0x1841B4120")]
	public bool GAHDPKFJOAE(T ACKOJNNBEBO, bool JHPBBJKMLLL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x41B4390", Offset = "0x41B3590", VA = "0x1841B4390")]
	public bool GAHDPKFJOAE(T ACKOJNNBEBO, int MMFFFGBLCAP, bool JHPBBJKMLLL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x41B4BC0", Offset = "0x41B3DC0", VA = "0x1841B4BC0")]
	public bool PLKCAALIKKA(T ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x41B4680", Offset = "0x41B3880", VA = "0x1841B4680")]
	public bool LIDGMIKDKFG(int MMFFFGBLCAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x41B4030", Offset = "0x41B3230", VA = "0x1841B4030")]
	private void ENAFLNAHFKI(int MMFFFGBLCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x41B3CA0", Offset = "0x41B2EA0", VA = "0x1841B3CA0")]
	public BOMHCKJOAPB[] DHJGLBPNNHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x41B39B0", Offset = "0x41B2BB0", VA = "0x1841B39B0")]
	private int ABHGPJMCBHD(int PFBJKNIILDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x41B4DD0", Offset = "0x41B3FD0", VA = "0x1841B4DD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x41B4DD0", Offset = "0x41B3FD0", VA = "0x1841B4DD0", Slot = "4")]
	private IEnumerator<BOMHCKJOAPB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x7053840", Offset = "0x7052A40", VA = "0x187053840")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x7053AD0", Offset = "0x7052CD0", VA = "0x187053AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x7053A00", Offset = "0x7052C00", VA = "0x187053A00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x7053C20", Offset = "0x7052E20", VA = "0x187053C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x70537B0", Offset = "0x70529B0", VA = "0x1870537B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x7053A40", Offset = "0x7052C40", VA = "0x187053A40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x7053970", Offset = "0x7052B70", VA = "0x187053970")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7053750", Offset = "0x7052950", VA = "0x187053750")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class FIMFKGOKPGK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int HBHBCIIAIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int JAFAHFEJMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private List<T> HMNOPGDGOJJ;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1913FA0", Offset = "0x19131A0", VA = "0x181913FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T DGJHKAHKEON
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4C4FE90", Offset = "0x4C4F090", VA = "0x184C4FE90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T JFDLPCEMMAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x4C4FDE0", Offset = "0x4C4EFE0", VA = "0x184C4FDE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T BCNBMDEJAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4C50040", Offset = "0x4C4F240", VA = "0x184C50040")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4C502F0", Offset = "0x4C4F4F0", VA = "0x184C502F0")]
	public FIMFKGOKPGK(int HBHBCIIAIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4C50210", Offset = "0x4C4F410", VA = "0x184C50210")]
	public void PPMBLONPHPF(T NLMMINGGOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x4C4FFA0", Offset = "0x4C4F1A0", VA = "0x184C4FFA0")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x4C500A0", Offset = "0x4C4F2A0", VA = "0x184C500A0")]
	public void MCBPBEDJHAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x4C4FE40", Offset = "0x4C4F040", VA = "0x184C4FE40")]
	public void BCLIGKBIILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x4C4FFE0", Offset = "0x4C4F1E0", VA = "0x184C4FFE0")]
	public void JIEEOJIBEHA()
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
		public struct JEKLBGLJIAO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private readonly List<Component> IEKCFDAIBOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private readonly bool PAIOAFKKKJA;

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x1023490", Offset = "0x1022690", VA = "0x181023490")]
			public JEKLBGLJIAO(List<Component> IEKCFDAIBOJ, bool PAIOAFKKKJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x34EB790", Offset = "0x34EA990", VA = "0x1834EB790")]
			public NNFMFLCCOBC<T> KECFEFHENMC()
			{
				return default(NNFMFLCCOBC<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x34EB800", Offset = "0x34EAA00", VA = "0x1834EB800", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x34EB800", Offset = "0x34EAA00", VA = "0x1834EB800", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public struct NNFMFLCCOBC<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private readonly List<Component> IEKCFDAIBOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private readonly bool PAIOAFKKKJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int MMFFFGBLCAP;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public T HMPLADJAFAK
			{
				[Cpp2IlInjected.Token(Token = "0x60002F8")]
				[Cpp2IlInjected.Address(RVA = "0x4664BC0", Offset = "0x4663DC0", VA = "0x184664BC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0x4664B50", Offset = "0x4663D50", VA = "0x184664B50", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x4664B90", Offset = "0x4663D90", VA = "0x184664B90")]
			public NNFMFLCCOBC(List<Component> IEKCFDAIBOJ, bool PAIOAFKKKJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x4664A80", Offset = "0x4663C80", VA = "0x184664A80", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x4664A90", Offset = "0x4663C90", VA = "0x184664A90", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x2C81D80", Offset = "0x2C80F80", VA = "0x182C81D80", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x70559B0", Offset = "0x7054BB0", VA = "0x1870559B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7055970", Offset = "0x7054B70", VA = "0x187055970")]
		public ToolHierarchyCache(GameObject HHFCGHHBGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x70556B0", Offset = "0x70548B0", VA = "0x1870556B0")]
		private void OHLMLHJNBAL(GameObject HHFCGHHBGCH, bool PPHFAHHOGGC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7055620", Offset = "0x7054820", VA = "0x187055620")]
		public static void OHLMLHJNBAL(GameObject HHFCGHHBGCH, ref ToolHierarchyCache NJDJIKKDMOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7055160", Offset = "0x7054360", VA = "0x187055160")]
		public void HKNNCKBJNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x70555D0", Offset = "0x70547D0", VA = "0x1870555D0")]
		public void MOHBPCGLPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x3511CF0", Offset = "0x3510EF0", VA = "0x183511CF0")]
		public void NEBDCHMJDMB<T>(Action<T> JFFMHPNGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7055820", Offset = "0x7054A20", VA = "0x187055820")]
		public Component PJCFOFAHLAL(Type JAACLLLIGMF, bool PAIOAFKKKJA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x3511F80", Offset = "0x3511180", VA = "0x183511F80")]
		public T PJCFOFAHLAL<T>(bool PAIOAFKKKJA = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7054FE0", Offset = "0x70541E0", VA = "0x187054FE0")]
		public JEKLBGLJIAO<Component> BHOGHDHHHEA(Type JAACLLLIGMF, bool PAIOAFKKKJA = false)
		{
			return default(JEKLBGLJIAO<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x3511C20", Offset = "0x3510E20", VA = "0x183511C20")]
		public JEKLBGLJIAO<T> BHOGHDHHHEA<T>(bool PAIOAFKKKJA = false) where T : class
		{
			return default(JEKLBGLJIAO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7055280", Offset = "0x7054480", VA = "0x187055280")]
		public List<Component> JPPFJBHFCBC(Type JAACLLLIGMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7055060", Offset = "0x7054260", VA = "0x187055060", Slot = "4")]
		public bool Equals(ToolHierarchyCache JNIPLDLJAIJ, ToolHierarchyCache GEADFOLNEOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x70550E0", Offset = "0x70542E0", VA = "0x1870550E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BHEOHCEHIBM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class JAKEKNKOPOK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Dictionary<int, T> FIPHIMEAJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private T FAAPLBIOLEA;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public virtual T AHBBBNLLHED
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x96EA60", Offset = "0x96DC60", VA = "0x18096EA60", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool PFADPBMFDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x34D9C70", Offset = "0x34D8E70", VA = "0x1834D9C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x34D9CB0", Offset = "0x34D8EB0", VA = "0x1834D9CB0")]
	public bool ONOJKJCDILP(T ACKOJNNBEBO, int JPBBCHDLKHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x34D9760", Offset = "0x34D8960", VA = "0x1834D9760")]
	public bool ABEGNBDCKCP(int JPBBCHDLKHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x34D97C0", Offset = "0x34D89C0", VA = "0x1834D97C0")]
	public T BNMNKDNHIIL(int PGCMLLCAKGG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x34D9BE0", Offset = "0x34D8DE0", VA = "0x1834D9BE0")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x34D9D70", Offset = "0x34D8F70", VA = "0x1834D9D70")]
	private bool PLNFJKJKKHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x34D9C40", Offset = "0x34D8E40", VA = "0x1834D9C40")]
	public bool EIKCLBLFBCB(int JPBBCHDLKHJ, out T ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x34D9F10", Offset = "0x34D9110", VA = "0x1834D9F10")]
	public JAKEKNKOPOK()
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
			[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x841C80", Offset = "0x840E80", VA = "0x180841C80")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public T this[int PPKKHBJMHLB, int GDMBBNPDFKJ]
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x46B7610", Offset = "0x46B6810", VA = "0x1846B7610")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x46B76B0", Offset = "0x46B68B0", VA = "0x1846B76B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x46B7580", Offset = "0x46B6780", VA = "0x1846B7580")]
		public Array2D(uint MBFLADEHOFK, uint ONCHOOACJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x46B7500", Offset = "0x46B6700", VA = "0x1846B7500")]
		public void DAFFCKIEONE()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x704E740", Offset = "0x704D940", VA = "0x18704E740")]
		public Array2DVector3(uint MBFLADEHOFK, uint ONCHOOACJKO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public abstract class HNICPHBNJBI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class LAHBIEHLPHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public TNode DCMHODHEGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public TNode BLFIAOLNAKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public ELAGLBLHOMO ALDLAHDGHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public List<ELAGLBLHOMO> OCJKCMGFAKN;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public LAHBIEHLPHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal struct ELAGLBLHOMO : IComparable<ELAGLBLHOMO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public int JPBBCHDLKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public TClaimant HEMGJCNHLGP;

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x902C30", Offset = "0x901E30", VA = "0x180902C30")]
		public ELAGLBLHOMO(int JPBBCHDLKHJ, TClaimant HEMGJCNHLGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x366BFC0", Offset = "0x366B1C0", VA = "0x18366BFC0")]
		public bool BJBLGGIEMDP(in ELAGLBLHOMO HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x366C030", Offset = "0x366B230", VA = "0x18366C030")]
		public bool MNJADHEMBHO(in ELAGLBLHOMO HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x366C020", Offset = "0x366B220", VA = "0x18366C020", Slot = "4")]
		public int CompareTo(ELAGLBLHOMO HPOECFLNEOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x366C040", Offset = "0x366B240", VA = "0x18366C040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum DFADHKCJIFM
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class GHDHBLDKLPC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public HNICPHBNJBI<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2A070F0", Offset = "0x2A062F0", VA = "0x182A070F0")]
		[DebuggerHidden]
		public GHDHBLDKLPC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x41ACDB0", Offset = "0x41ABFB0", VA = "0x1841ACDB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x41ACF80", Offset = "0x41AC180", VA = "0x1841ACF80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x41ACEA0", Offset = "0x41AC0A0", VA = "0x1841ACEA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2A0B910", Offset = "0x2A0AB10", VA = "0x182A0B910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly EPKHAMBBLCH<LAHBIEHLPHC> EOEOJGMENHI;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly EPKHAMBBLCH<List<ELAGLBLHOMO>> DDMOCAALIHO;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static int IGPALNACDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	internal readonly Dictionary<TClaimant, TNode> HMHJBMNPKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	internal readonly Dictionary<TNode, LAHBIEHLPHC> GHINLKAPCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private DFADHKCJIFM LLKIENGKJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private bool MIGKAMNMNKG;

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode MCOPDEBMCLA(TNode EAEBGCCKBIG);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BENFHDILLLG(TNode EAEBGCCKBIG, TClaimant JHEIHHAAKJF, TClaimant FLIEKAODLFD);

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2DD60A0", Offset = "0x2DD52A0", VA = "0x182DD60A0")]
	public HNICPHBNJBI(DFADHKCJIFM LLKIENGKJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2DD56F0", Offset = "0x2DD48F0", VA = "0x182DD56F0")]
	public void GGBKOKFGCCD(TNode EAEBGCCKBIG, TNode AENILMDGHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2DD57D0", Offset = "0x2DD49D0", VA = "0x182DD57D0")]
	public void IAGONECICLJ(TClaimant HEMGJCNHLGP, TNode CNBGFMNJJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4F00", Offset = "0x2DD4100", VA = "0x182DD4F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5A20", Offset = "0x2DD4C20", VA = "0x182DD5A20")]
	private void KMOMCDDMPEM(TClaimant HEMGJCNHLGP, TNode HKOFIOFOKLP, TNode CNBGFMNJJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5770", Offset = "0x2DD4970", VA = "0x182DD5770")]
	private int GMHIPODMIPO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5430", Offset = "0x2DD4630", VA = "0x182DD5430")]
	private void FEJINKFCNOA(TClaimant HEMGJCNHLGP, TNode GMEMNEDOKIK, TNode NAANOAKLEBN, int ABHNLOEFGAO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5990", Offset = "0x2DD4B90", VA = "0x182DD5990")]
	private void KILPAAPLHEE(ELAGLBLHOMO MMKJMFNLHPG, LAHBIEHLPHC CHMEGHGPCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4CA0", Offset = "0x2DD3EA0", VA = "0x182DD4CA0")]
	private void DDNNFECOCIE(TClaimant HEMGJCNHLGP, TNode GMEMNEDOKIK, TNode NAANOAKLEBN, int ABHNLOEFGAO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5160", Offset = "0x2DD4360", VA = "0x182DD5160")]
	private void EOAKNNCCKGB(ELAGLBLHOMO MMKJMFNLHPG, TNode EAEBGCCKBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5AC0", Offset = "0x2DD4CC0", VA = "0x182DD5AC0")]
	private void LNHPBKBNALL(ELAGLBLHOMO MMKJMFNLHPG, LAHBIEHLPHC CHMEGHGPCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5BC0", Offset = "0x2DD4DC0", VA = "0x182DD5BC0")]
	private void MNPKNEACIHG(LAHBIEHLPHC CHMEGHGPCNM, bool ENKFFLDFJLB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2DD48D0", Offset = "0x2DD3AD0", VA = "0x182DD48D0")]
	private void BFLFEEPIOPF(LAHBIEHLPHC CHMEGHGPCNM, TNode AENILMDGHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5E70", Offset = "0x2DD5070", VA = "0x182DD5E70")]
	[IteratorStateMachine(typeof(HNICPHBNJBI<, >.GHDHBLDKLPC))]
	private IEnumerable<TNode> PLOLDNJOFEC(TNode GMEMNEDOKIK, TNode NAANOAKLEBN, bool DIJLNJGCGDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD58D0", Offset = "0x2DD4AD0", VA = "0x182DD58D0")]
	private LAHBIEHLPHC KHJFLCOPOAN(TNode EAEBGCCKBIG, TNode BLFIAOLNAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5CE0", Offset = "0x2DD4EE0", VA = "0x182DD5CE0")]
	private LAHBIEHLPHC NJKIOJLALIA(TNode EAEBGCCKBIG, TNode BLFIAOLNAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2DD5270", Offset = "0x2DD4470", VA = "0x182DD5270")]
	private void FCJECGGJDFC(LAHBIEHLPHC CHMEGHGPCNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class DGIEMPDPFJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	protected struct LGDALEFLHJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public T IHPKAGOHFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int GIAHOLBDHFI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected readonly List<LGDALEFLHJN> HJHCGFFCFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T IHDJHAEDDKJ;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x2904080", Offset = "0x2903280", VA = "0x182904080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x4372BE0", Offset = "0x4371DE0", VA = "0x184372BE0")]
	public bool PLLNGOBMPBN(T ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x4372DE0", Offset = "0x4371FE0", VA = "0x184372DE0")]
	public void PPMBLONPHPF(T ACKOJNNBEBO, int JPBBCHDLKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x4372AC0", Offset = "0x4371CC0", VA = "0x184372AC0")]
	public bool PLKCAALIKKA(T ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4372980", Offset = "0x4371B80", VA = "0x184372980")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x4372A50", Offset = "0x4371C50", VA = "0x184372A50")]
	public T MPDCCGJFKPA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x43729E0", Offset = "0x4371BE0", VA = "0x1843729E0")]
	public T LMDLIBMOEDG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x43727D0", Offset = "0x43719D0", VA = "0x1843727D0")]
	private void CAIILBDKKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x4372E80", Offset = "0x4372080", VA = "0x184372E80")]
	public DGIEMPDPFJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class CFAOGIHNGKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private struct OHIICNJBJCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int GIAHOLBDHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public T IHPKAGOHFMA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<object, OHIICNJBJCJ> FIPHIMEAJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly EqualityComparer<T> GNGFHDBOKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private T FAAPLBIOLEA;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public virtual T AHBBBNLLHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x36D3460", Offset = "0x36D2660", VA = "0x1836D3460", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x36D3340", Offset = "0x36D2540", VA = "0x1836D3340", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool PFADPBMFDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x36D33E0", Offset = "0x36D25E0", VA = "0x1836D33E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public object DEOMGHOAAKO
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x943020", Offset = "0x942220", VA = "0x180943020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x36D3B70", Offset = "0x36D2D70", VA = "0x1836D3B70")]
	public bool ONOJKJCDILP(T ACKOJNNBEBO, object IBIKCCMDMHA, int JPBBCHDLKHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x36D2CC0", Offset = "0x36D1EC0", VA = "0x1836D2CC0")]
	public bool ABEGNBDCKCP(object IBIKCCMDMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x36D2EE0", Offset = "0x36D20E0", VA = "0x1836D2EE0")]
	public bool EIKCLBLFBCB(object IBIKCCMDMHA, out T ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x2F7BBD0", Offset = "0x2F7ADD0", VA = "0x182F7BBD0")]
	public void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x36D4540", Offset = "0x36D3740", VA = "0x1836D4540")]
	private bool PLNFJKJKKHP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x36D7C80", Offset = "0x36D6E80", VA = "0x1836D7C80")]
	public CFAOGIHNGKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class PGGICDGKHCC
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7052FF0", Offset = "0x70521F0", VA = "0x187052FF0")]
	public static void EKLCKAENCNC(COJCOIOHKKE MBAJNGADACE, string AKEDLBHFOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void EKLCKAENCNC(IEnumerable<object> IDAKNDEONMG, string AKEDLBHFOFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class KCOLBFGBIIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private bool MOIICADHAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private Action JFFMHPNGJBK;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public static KCOLBFGBIIP BNAHKBIAKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x7052290", Offset = "0x7051490", VA = "0x187052290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool NBCMKFJCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x844720", Offset = "0x843920", VA = "0x180844720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x7052310", Offset = "0x7051510", VA = "0x187052310")]
	public KCOLBFGBIIP(Action JFFMHPNGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7052270", Offset = "0x7051470", VA = "0x187052270")]
	public void HEEDEOJNDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7052270", Offset = "0x7051470", VA = "0x187052270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class FMCLHNBJINA : NNFJPPGGOPL
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7050750", Offset = "0x704F950", VA = "0x187050750")]
	public FMCLHNBJINA(UnityEngine.Object FHOBIMJNFAK)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
