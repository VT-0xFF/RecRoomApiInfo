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
		[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91AF80", Offset = "0x919F80", VA = "0x18091AF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xF72F20", Offset = "0xF71F20", VA = "0x180F72F20")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1A269B0", Offset = "0x1A259B0", VA = "0x181A269B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "4")]
	public virtual void JNKBHMKJMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
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
	[FMKPEFJPJEF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4AAA720", Offset = "0x4AA9720", VA = "0x184AAA720", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4AA9E80", Offset = "0x4AA8E80", VA = "0x184AA9E80", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4AAAC50", Offset = "0x4AA9C50", VA = "0x184AAAC50")]
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
	private sealed class HKLNKHBJFMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public HKLNKHBJFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2846870", Offset = "0x2845870", VA = "0x182846870")]
		internal int IENPJHBFJOP(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[FMKPEFJPJEF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC46BB0", Offset = "0xC45BB0", VA = "0x180C46BB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC46BE0", Offset = "0xC45BE0", VA = "0x180C46BE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC46B00", Offset = "0xC45B00", VA = "0x180C46B00", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public TVal this[TKey LOHIKDGDMPP]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xC46B60", Offset = "0xC45B60", VA = "0x180C46B60", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xC46A00", Offset = "0xC45A00", VA = "0x180C46A00", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xC46520", Offset = "0xC45520", VA = "0x180C46520", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xC45D40", Offset = "0xC44D40", VA = "0x180C45D40", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xC45960", Offset = "0xC44960", VA = "0x180C45960", Slot = "14")]
	protected virtual string EEACBOOENBA(TKeyVal MIOCFCBHCLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xC458D0", Offset = "0xC448D0", VA = "0x180C458D0", Slot = "4")]
	public bool ContainsKey(TKey LOHIKDGDMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xC468E0", Offset = "0xC458E0", VA = "0x180C468E0", Slot = "5")]
	public bool TryGetValue(TKey LOHIKDGDMPP, out TVal CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xC45990", Offset = "0xC44990", VA = "0x180C45990", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xC45990", Offset = "0xC44990", VA = "0x180C45990", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xC46910", Offset = "0xC45910", VA = "0x180C46910")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JEIMNBHJBDL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JLPKAKFNAKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public JLPKAKFNAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA970", Offset = "0x2DF9970", VA = "0x182DFA970")]
		internal bool GMOIDEGHMDM(CKLNBAMINBE<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float AFFCCKOPNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float FMHKKBAHGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<CKLNBAMINBE<float, T>> GBLNCJMPJFB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int PCAEHPIENFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2440F90", Offset = "0x243FF90", VA = "0x182440F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x24411E0", Offset = "0x24401E0", VA = "0x1824411E0")]
	public JEIMNBHJBDL(float OKIAIGLPMLC, float JNDPHPFMMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x24407B0", Offset = "0x243F7B0", VA = "0x1824407B0")]
	public bool BMLHJKODDFJ(float AILHHDAIAFL, T CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2441090", Offset = "0x2440090", VA = "0x182441090")]
	public int KPAEDHEHGJD(float AILHHDAIAFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2440910", Offset = "0x243F910", VA = "0x182440910")]
	public IEnumerable<T> EFMAOEFHKOG(float AILHHDAIAFL, [Optional] float? IGINOMCCDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x24411B0", Offset = "0x24401B0", VA = "0x1824411B0")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x24410F0", Offset = "0x24400F0", VA = "0x1824410F0")]
	private void OPOJMOGJMCO(float AILHHDAIAFL)
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
	public T FNCIDNAOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3A26930", Offset = "0x3A25930", VA = "0x183A26930")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3A26E50", Offset = "0x3A25E50", VA = "0x183A26E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float DCDNAKOCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xBC2B40", Offset = "0xBC1B40", VA = "0x180BC2B40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A26A70", Offset = "0x3A25A70", VA = "0x183A26A70")]
	public T BLGAOABNGHG(float EBIGDBKBHOG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A26DC0", Offset = "0x3A25DC0", VA = "0x183A26DC0")]
	public T GDMGDBENAAJ(float EBIGDBKBHOG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MLGCGMNCGKL(T JMKFPOOBMEL, T OIMIHNAHPGP, float EBIGDBKBHOG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3400DA0", Offset = "0x33FFDA0", VA = "0x183400DA0", Slot = "4")]
	protected override float MLGCGMNCGKL(float JMKFPOOBMEL, float OIMIHNAHPGP, float EBIGDBKBHOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x71802E0", Offset = "0x717F2E0", VA = "0x1871802E0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xED1140", Offset = "0xED0140", VA = "0x180ED1140", Slot = "4")]
	protected override Vector3 MLGCGMNCGKL(Vector3 JMKFPOOBMEL, Vector3 OIMIHNAHPGP, float EBIGDBKBHOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x71843F0", Offset = "0x71833F0", VA = "0x1871843F0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x717E860", Offset = "0x717D860", VA = "0x18717E860", Slot = "4")]
	protected override Color MLGCGMNCGKL(Color JMKFPOOBMEL, Color OIMIHNAHPGP, float EBIGDBKBHOG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x717E8C0", Offset = "0x717D8C0", VA = "0x18717E8C0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HIAGAJBDLJO
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class KFPELGBKCBN<T1, T2> : IEnumerable<CKLNBAMINBE<T1, T2>>, IEnumerable, IEnumerator<CKLNBAMINBE<T1, T2>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CKLNBAMINBE<T1, T2> <>2__current;

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
		CKLNBAMINBE<T1, T2> IEnumerator<Tuple<T1, T2>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2060080", Offset = "0x205F080", VA = "0x182060080")]
		[DebuggerHidden]
		public KFPELGBKCBN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x353F4C0", Offset = "0x353E4C0", VA = "0x18353F4C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x353F770", Offset = "0x353E770", VA = "0x18353F770", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x230C8D0", Offset = "0x230B8D0", VA = "0x18230C8D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<CKLNBAMINBE<T1, T2>> IEnumerable<Tuple<T1, T2>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xC40680", Offset = "0xC3F680", VA = "0x180C40680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class OPFDIFEFPJD<T1, T2, T3> : IEnumerable<PBMHJCCIHNF<T1, T2, T3>>, IEnumerable, IEnumerator<PBMHJCCIHNF<T1, T2, T3>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private PBMHJCCIHNF<T1, T2, T3> <>2__current;

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
		PBMHJCCIHNF<T1, T2, T3> IEnumerator<Tuple<T1, T2, T3>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2060080", Offset = "0x205F080", VA = "0x182060080")]
		[DebuggerHidden]
		public OPFDIFEFPJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3089EF0", Offset = "0x3088EF0", VA = "0x183089EF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x308A300", Offset = "0x3089300", VA = "0x18308A300", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2D93C90", Offset = "0x2D92C90", VA = "0x182D93C90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<PBMHJCCIHNF<T1, T2, T3>> IEnumerable<Tuple<T1, T2, T3>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2208860", Offset = "0x2207860", VA = "0x182208860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1074000", Offset = "0x1073000", VA = "0x181074000")]
	public static ONJIAGBHHOD<T1> HFOCJEBDOBL<T1>(T1 HLLDFLEKOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1073A90", Offset = "0x1072A90", VA = "0x181073A90")]
	public static CKLNBAMINBE<T1, T2> HFOCJEBDOBL<T1, T2>(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1073B00", Offset = "0x1072B00", VA = "0x181073B00")]
	public static PBMHJCCIHNF<T1, T2, T3> HFOCJEBDOBL<T1, T2, T3>(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1073E70", Offset = "0x1072E70", VA = "0x181073E70")]
	public static KPJENCEHCGM<T1, T2, T3, T4> HFOCJEBDOBL<T1, T2, T3, T4>(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1073DD0", Offset = "0x1072DD0", VA = "0x181073DD0")]
	public static KCDKLDAILAP<T1, T2, T3, T4, T5> HFOCJEBDOBL<T1, T2, T3, T4, T5>(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN, T5 KAPPNJPLMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1073D20", Offset = "0x1072D20", VA = "0x181073D20")]
	public static LEDHCJGHAEO<T1, T2, T3, T4, T5, T6> HFOCJEBDOBL<T1, T2, T3, T4, T5, T6>(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN, T5 KAPPNJPLMFC, T6 IGAANJLNKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1073C60", Offset = "0x1072C60", VA = "0x181073C60")]
	public static DKLONGHFKDH<T1, T2, T3, T4, T5, T6, T7> HFOCJEBDOBL<T1, T2, T3, T4, T5, T6, T7>(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN, T5 KAPPNJPLMFC, T6 IGAANJLNKPF, T7 IOEDIHKNHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1073B90", Offset = "0x1072B90", VA = "0x181073B90")]
	public static LLFNKOPJCGM<T1, T2, T3, T4, T5, T6, T7, T8> HFOCJEBDOBL<T1, T2, T3, T4, T5, T6, T7, T8>(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN, T5 KAPPNJPLMFC, T6 IGAANJLNKPF, T7 IOEDIHKNHEN, T8 JJOPDOHGOKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xE031A0", Offset = "0xE021A0", VA = "0x180E031A0")]
	[IteratorStateMachine(typeof(KFPELGBKCBN<, >))]
	public static IEnumerable<CKLNBAMINBE<T1, T2>> OPKHOKIMEJM<T1, T2>(IEnumerable<T1> LFEMLKHNBHE, IEnumerable<T2> CNOAFMMFDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xE03240", Offset = "0xE02240", VA = "0x180E03240")]
	[IteratorStateMachine(typeof(OPFDIFEFPJD<, , >))]
	public static IEnumerable<PBMHJCCIHNF<T1, T2, T3>> OPKHOKIMEJM<T1, T2, T3>(IEnumerable<T1> LFEMLKHNBHE, IEnumerable<T2> CNOAFMMFDKH, IEnumerable<T3> MCBIILGICKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x71803F0", Offset = "0x717F3F0", VA = "0x1871803F0")]
	internal static int JCJNAFHFOEL(int CBKGEPHOEOC, int NELCBDANOGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7180400", Offset = "0x717F400", VA = "0x187180400")]
	internal static int JCJNAFHFOEL(int CBKGEPHOEOC, int NELCBDANOGM, int PFMGGJNGPIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7180430", Offset = "0x717F430", VA = "0x187180430")]
	internal static int JCJNAFHFOEL(int CBKGEPHOEOC, int NELCBDANOGM, int PFMGGJNGPIC, int EACNKLOBCIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7180410", Offset = "0x717F410", VA = "0x187180410")]
	internal static int JCJNAFHFOEL(int CBKGEPHOEOC, int NELCBDANOGM, int PFMGGJNGPIC, int EACNKLOBCIH, int DBOMNMODAKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71803C0", Offset = "0x717F3C0", VA = "0x1871803C0")]
	internal static int JCJNAFHFOEL(int CBKGEPHOEOC, int NELCBDANOGM, int PFMGGJNGPIC, int EACNKLOBCIH, int DBOMNMODAKH, int LNIAKMNIOKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7180480", Offset = "0x717F480", VA = "0x187180480")]
	internal static int JCJNAFHFOEL(int CBKGEPHOEOC, int NELCBDANOGM, int PFMGGJNGPIC, int EACNKLOBCIH, int DBOMNMODAKH, int LNIAKMNIOKE, int HMNIIJFHPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7180450", Offset = "0x717F450", VA = "0x187180450")]
	internal static int JCJNAFHFOEL(int CBKGEPHOEOC, int NELCBDANOGM, int PFMGGJNGPIC, int EACNKLOBCIH, int DBOMNMODAKH, int LNIAKMNIOKE, int HMNIIJFHPEO, int CGMDOBAEKFI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ONJIAGBHHOD<T1> : IComparable<ONJIAGBHHOD<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T1 AEGJKGBJLCC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xBFE350", Offset = "0xBFD350", VA = "0x180BFE350")]
	public ONJIAGBHHOD(T1 HLLDFLEKOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3294A50", Offset = "0x3293A50", VA = "0x183294A50", Slot = "4")]
	public int CompareTo(ONJIAGBHHOD<T1> BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3294AC0", Offset = "0x3293AC0", VA = "0x183294AC0", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2134990", Offset = "0x2133990", VA = "0x182134990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3294B60", Offset = "0x3293B60", VA = "0x183294B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CKLNBAMINBE<T1, T2> : IComparable<CKLNBAMINBE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T1 AEGJKGBJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T2 DIFBBKAOGFL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x202DFF0", Offset = "0x202CFF0", VA = "0x18202DFF0")]
	public CKLNBAMINBE(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3454C20", Offset = "0x3453C20", VA = "0x183454C20", Slot = "4")]
	public int CompareTo(CKLNBAMINBE<T1, T2> BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x34550F0", Offset = "0x34540F0", VA = "0x1834550F0", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3455C50", Offset = "0x3454C50", VA = "0x183455C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3456590", Offset = "0x3455590", VA = "0x183456590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PBMHJCCIHNF<T1, T2, T3> : IComparable<PBMHJCCIHNF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly T1 AEGJKGBJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly T2 DIFBBKAOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly T3 MOGDMFLIOKK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A89600", Offset = "0x2A88600", VA = "0x182A89600")]
	public PBMHJCCIHNF(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A88DC0", Offset = "0x2A87DC0", VA = "0x182A88DC0", Slot = "4")]
	public int CompareTo(PBMHJCCIHNF<T1, T2, T3> BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A890E0", Offset = "0x2A880E0", VA = "0x182A890E0", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A892E0", Offset = "0x2A882E0", VA = "0x182A892E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A89340", Offset = "0x2A88340", VA = "0x182A89340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KPJENCEHCGM<T1, T2, T3, T4> : IComparable<KPJENCEHCGM<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 AEGJKGBJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T2 DIFBBKAOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T3 MOGDMFLIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T4 EKMLHCAPHCL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2434E80", Offset = "0x2433E80", VA = "0x182434E80")]
	public KPJENCEHCGM(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x30E5400", Offset = "0x30E4400", VA = "0x1830E5400", Slot = "4")]
	public int CompareTo(KPJENCEHCGM<T1, T2, T3, T4> BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x30E5540", Offset = "0x30E4540", VA = "0x1830E5540", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x30E5680", Offset = "0x30E4680", VA = "0x1830E5680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x30E5740", Offset = "0x30E4740", VA = "0x1830E5740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KCDKLDAILAP<T1, T2, T3, T4, T5> : IComparable<KCDKLDAILAP<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T1 AEGJKGBJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T2 DIFBBKAOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T3 MOGDMFLIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T4 EKMLHCAPHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T5 DKIPPLKMICP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x25DA5F0", Offset = "0x25D95F0", VA = "0x1825DA5F0")]
	public KCDKLDAILAP(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN, T5 KAPPNJPLMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC000", Offset = "0x2AAB000", VA = "0x182AAC000", Slot = "4")]
	public int CompareTo(KCDKLDAILAP<T1, T2, T3, T4, T5> BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC180", Offset = "0x2AAB180", VA = "0x182AAC180", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC2F0", Offset = "0x2AAB2F0", VA = "0x182AAC2F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC3F0", Offset = "0x2AAB3F0", VA = "0x182AAC3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LEDHCJGHAEO<T1, T2, T3, T4, T5, T6> : IComparable<LEDHCJGHAEO<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T1 AEGJKGBJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T2 DIFBBKAOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T3 MOGDMFLIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T4 EKMLHCAPHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T5 DKIPPLKMICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T6 OOIEJBOAFLJ;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2686AD0", Offset = "0x2685AD0", VA = "0x182686AD0")]
	public LEDHCJGHAEO(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN, T5 KAPPNJPLMFC, T6 IGAANJLNKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26864F0", Offset = "0x26854F0", VA = "0x1826864F0", Slot = "4")]
	public int CompareTo(LEDHCJGHAEO<T1, T2, T3, T4, T5, T6> BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x26866B0", Offset = "0x26856B0", VA = "0x1826866B0", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2686840", Offset = "0x2685840", VA = "0x182686840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2686960", Offset = "0x2685960", VA = "0x182686960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DKLONGHFKDH<T1, T2, T3, T4, T5, T6, T7> : IComparable<DKLONGHFKDH<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 AEGJKGBJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 DIFBBKAOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 MOGDMFLIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 EKMLHCAPHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 DKIPPLKMICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 OOIEJBOAFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T7 JIBICHPHBCB;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2BA90D0", Offset = "0x2BA80D0", VA = "0x182BA90D0")]
	public DKLONGHFKDH(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN, T5 KAPPNJPLMFC, T6 IGAANJLNKPF, T7 IOEDIHKNHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8A30", Offset = "0x2BA7A30", VA = "0x182BA8A30", Slot = "4")]
	public int CompareTo(DKLONGHFKDH<T1, T2, T3, T4, T5, T6, T7> BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8C30", Offset = "0x2BA7C30", VA = "0x182BA8C30", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8DF0", Offset = "0x2BA7DF0", VA = "0x182BA8DF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8F40", Offset = "0x2BA7F40", VA = "0x182BA8F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LLFNKOPJCGM<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<LLFNKOPJCGM<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T1 AEGJKGBJLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T2 DIFBBKAOGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T3 MOGDMFLIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T4 EKMLHCAPHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T5 DKIPPLKMICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T6 OOIEJBOAFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T7 JIBICHPHBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T8 GIIGOPDCOOP;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2508E40", Offset = "0x2507E40", VA = "0x182508E40")]
	public LLFNKOPJCGM(T1 HLLDFLEKOLC, T2 FAEKDOLBGGH, T3 JDIHFMHHDLN, T4 KACJNMAEJEN, T5 KAPPNJPLMFC, T6 IGAANJLNKPF, T7 IOEDIHKNHEN, T8 JJOPDOHGOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x25086F0", Offset = "0x25076F0", VA = "0x1825086F0", Slot = "4")]
	public int CompareTo(LLFNKOPJCGM<T1, T2, T3, T4, T5, T6, T7, T8> BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2508940", Offset = "0x2507940", VA = "0x182508940", Slot = "0")]
	public override bool Equals(object BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2508B20", Offset = "0x2507B20", VA = "0x182508B20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2508C90", Offset = "0x2507C90", VA = "0x182508C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FMKPEFJPJEF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAAA3B0", Offset = "0xAA93B0", VA = "0x180AAA3B0")]
	public FMKPEFJPJEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HashableScriptableObject : ScriptableObject, FAPJGJIPKGE, EIAPCOLJCNP, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash HFGGAOHBKDG);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
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
	[ECEGGLIIJGM]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[ECEGGLIIJGM]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x71831C0", Offset = "0x71821C0", VA = "0x1871831C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7183180", Offset = "0x7182180", VA = "0x187183180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7183200", Offset = "0x7182200", VA = "0x187183200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71833B0", Offset = "0x71823B0", VA = "0x1871833B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7183320", Offset = "0x7182320", VA = "0x187183320")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA76E90", Offset = "0xA75E90", VA = "0x180A76E90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA76E80", Offset = "0xA75E80", VA = "0x180A76E80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7183140", Offset = "0x7182140", VA = "0x187183140")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7183290", Offset = "0x7182290", VA = "0x187183290")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7182B90", Offset = "0x7181B90", VA = "0x187182B90")]
	public void CopyBounds(SavedExtents BKLMLPFOMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x71830A0", Offset = "0x71820A0", VA = "0x1871830A0")]
	public void SetLocalSpaceBounds(Bounds GHMKADDOLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7182530", Offset = "0x7181530", VA = "0x187182530")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7183090", Offset = "0x7182090", VA = "0x187183090")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7182C80", Offset = "0x7181C80", VA = "0x187182C80")]
	private void HLEBJEHOHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7182E60", Offset = "0x7181E60", VA = "0x187182E60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7182550", Offset = "0x7181550", VA = "0x187182550")]
	public static void CalculateLocalBoundsFor(GameObject LAPEIFCGFLM, out Bounds GHMKADDOLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7182BC0", Offset = "0x7181BC0", VA = "0x187182BC0")]
	private static void GHMKPKIEJEC(Bounds CNOAFMMFDKH, Color MCBIILGICKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x71830C0", Offset = "0x71820C0", VA = "0x1871830C0")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class HMFHEDEADEP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct IPHIIPHIGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public T FNCIDNAOCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float BEIMBOLGFIO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static float DFFCFBAFBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private List<T> OHMKKOEFAEE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private const int HMKHHCHOPKJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private IPHIIPHIGFJ[] GJAKHOONFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int NMELJJICKEL;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float BAHHMHLHEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCD9BB0", Offset = "0xCD8BB0", VA = "0x180CD9BB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xCD9BC0", Offset = "0xCD8BC0", VA = "0x180CD9BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2D8B4E0", Offset = "0x2D8A4E0", VA = "0x182D8B4E0")]
	public HMFHEDEADEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D8B510", Offset = "0x2D8A510", VA = "0x182D8B510")]
	public HMFHEDEADEP(int BKMCHKCIDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A0C0", Offset = "0x2D890C0", VA = "0x182D8A0C0")]
	public void AMLBOIMHPGF(float AILHHDAIAFL, T CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D8B340", Offset = "0x2D8A340", VA = "0x182D8B340")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D8AEA0", Offset = "0x2D89EA0", VA = "0x182D8AEA0")]
	public bool FLBEDDKELHF(float ONMGEGGIKGD, float DAHJPKHEDMA, out T CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A930", Offset = "0x2D89930", VA = "0x182D8A930")]
	public bool CFACNGEBGOB(float ONMGEGGIKGD, float DAHJPKHEDMA, out T CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A280", Offset = "0x2D89280", VA = "0x182D8A280")]
	public void BMDHANPHEHJ(float ONMGEGGIKGD, float DAHJPKHEDMA, List<T> FNLIPLLPDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D8AAA0", Offset = "0x2D89AA0", VA = "0x182D8AAA0")]
	private int ENEPHHAFIOC(int IKDGFAEONLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2D8B060", Offset = "0x2D8A060", VA = "0x182D8B060")]
	private void GJCAPNDHPDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EFKEPABHPFF();

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MLGCGMNCGKL(T JMKFPOOBMEL, T OIMIHNAHPGP, float EBIGDBKBHOG);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DCIGGAMPNAM(T CKDFGEALFAK, float EBIGDBKBHOG);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IDFKFDPKCIK(T JMKFPOOBMEL, T OIMIHNAHPGP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T NNFMDIFOFLK(T JMKFPOOBMEL, T OIMIHNAHPGP);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EGDCLADPLNL : HMFHEDEADEP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0xFAEC20", Offset = "0xFADC20", VA = "0x180FAEC20", Slot = "4")]
	protected override Vector3 EFKEPABHPFF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xED1140", Offset = "0xED0140", VA = "0x180ED1140", Slot = "5")]
	protected override Vector3 MLGCGMNCGKL(Vector3 JMKFPOOBMEL, Vector3 OIMIHNAHPGP, float EBIGDBKBHOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x717EF90", Offset = "0x717DF90", VA = "0x18717EF90", Slot = "6")]
	protected override Vector3 DCIGGAMPNAM(Vector3 CKDFGEALFAK, float EBIGDBKBHOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x717EFD0", Offset = "0x717DFD0", VA = "0x18717EFD0", Slot = "7")]
	protected override Vector3 IDFKFDPKCIK(Vector3 JMKFPOOBMEL, Vector3 OIMIHNAHPGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x717F020", Offset = "0x717E020", VA = "0x18717F020", Slot = "8")]
	protected override Vector3 NNFMDIFOFLK(Vector3 JMKFPOOBMEL, Vector3 OIMIHNAHPGP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x717F090", Offset = "0x717E090", VA = "0x18717F090")]
	public EGDCLADPLNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OPOILPDBIEE : HMFHEDEADEP<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7181FB0", Offset = "0x7180FB0", VA = "0x187181FB0")]
	public OPOILPDBIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7181F40", Offset = "0x7180F40", VA = "0x187181F40")]
	public OPOILPDBIEE(int BKMCHKCIDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xFAEBD0", Offset = "0xFADBD0", VA = "0x180FAEBD0", Slot = "4")]
	protected override float EFKEPABHPFF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3400DA0", Offset = "0x33FFDA0", VA = "0x183400DA0", Slot = "5")]
	protected override float MLGCGMNCGKL(float JMKFPOOBMEL, float OIMIHNAHPGP, float EBIGDBKBHOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x58CA320", Offset = "0x58C9320", VA = "0x1858CA320", Slot = "6")]
	protected override float DCIGGAMPNAM(float CKDFGEALFAK, float EBIGDBKBHOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7181F20", Offset = "0x7180F20", VA = "0x187181F20", Slot = "7")]
	protected override float IDFKFDPKCIK(float JMKFPOOBMEL, float OIMIHNAHPGP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7181F30", Offset = "0x7180F30", VA = "0x187181F30", Slot = "8")]
	protected override float NNFMDIFOFLK(float JMKFPOOBMEL, float OIMIHNAHPGP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GHMGLMONJEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IDisposable HIEJPGCOIBA;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public GHMGLMONJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DOFJPGIKHJF : NCIMMGBAJMN<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x717EDB0", Offset = "0x717DDB0", VA = "0x18717EDB0")]
	public DOFJPGIKHJF(int OENKBEGLEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x717EE00", Offset = "0x717DE00", VA = "0x18717EE00")]
	public DOFJPGIKHJF(BBFKDPJOCOG[] BAJKBGFGOKG, bool EOMBCPNFAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x717ED40", Offset = "0x717DD40", VA = "0x18717ED40", Slot = "6")]
	protected override uint MOIIGNIELEL(uint HFGGAOHBKDG, string CKDFGEALFAK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class EPEPMOCDCHO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct NNCENHLDKPI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly EPEPMOCDCHO<T> NPMPGBFKBNH;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T FNCIDNAOCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2A78050", Offset = "0x2A77050", VA = "0x182A78050")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2A78070", Offset = "0x2A77070", VA = "0x182A78070", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA2BF10", Offset = "0xA2AF10", VA = "0x180A2BF10")]
		public NNCENHLDKPI(EPEPMOCDCHO<T> NPMPGBFKBNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IHFPCLCEBPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<NNCENHLDKPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public EPEPMOCDCHO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public IHFPCLCEBPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xBE3090", Offset = "0xBE2090", VA = "0x180BE3090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class EONICCIOECD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<NNCENHLDKPI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public EPEPMOCDCHO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public EONICCIOECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xC41720", Offset = "0xC40720", VA = "0x180C41720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly SemaphoreSlim CBPIAMGLIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private T DOHIHLOMLKE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int LKKEGNOFCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xC41940", Offset = "0xC40940", VA = "0x180C41940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0xC42130", Offset = "0xC41130", VA = "0x180C42130")]
	public EPEPMOCDCHO(in T DOHIHLOMLKE, int NBJDACHGMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xC42060", Offset = "0xC41060", VA = "0x180C42060")]
	public EPEPMOCDCHO(in T DOHIHLOMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0xC41900", Offset = "0xC40900", VA = "0x180C41900")]
	public NNCENHLDKPI EDJNMBHALDF()
	{
		return default(NNCENHLDKPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0xC418C0", Offset = "0xC408C0", VA = "0x180C418C0")]
	public NNCENHLDKPI EDJNMBHALDF(CancellationToken OAGBBBCDIGC)
	{
		return default(NNCENHLDKPI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0xC41B30", Offset = "0xC40B30", VA = "0x180C41B30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EPEPMOCDCHO<>.IHFPCLCEBPG))]
	public Task<NNCENHLDKPI> OHLLGIMFPAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0xC41CE0", Offset = "0xC40CE0", VA = "0x180C41CE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EPEPMOCDCHO<>.EONICCIOECD))]
	public Task<NNCENHLDKPI> OHLLGIMFPAK(CancellationToken OAGBBBCDIGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class CFBPKFAMHII
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x717D240", Offset = "0x717C240", VA = "0x18717D240")]
	public static EPEPMOCDCHO<MPPFCKMNLHP> DAABCIFNKOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x717D1D0", Offset = "0x717C1D0", VA = "0x18717D1D0")]
	public static EPEPMOCDCHO<MPPFCKMNLHP> DAABCIFNKOF(int NBJDACHGMBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1074000", Offset = "0x1073000", VA = "0x181074000")]
	public static EPEPMOCDCHO<T> DAABCIFNKOF<T>(in T DOHIHLOMLKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BD00", Offset = "0x2C8AD00", VA = "0x182C8BD00")]
	public static EPEPMOCDCHO<T> DAABCIFNKOF<T>(in T DOHIHLOMLKE, int NBJDACHGMBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class IEAEDJCLPPJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private IEAEDJCLPPJ<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x90AAB0", Offset = "0x909AB0", VA = "0x18090AAB0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0460", Offset = "0x2BCF460", VA = "0x182BD0460", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2876960", Offset = "0x2875960", VA = "0x182876960")]
		public Enumerator(IEAEDJCLPPJ<T> FNLIPLLPDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BCD840", Offset = "0x2BCC840", VA = "0x182BCD840", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE250", Offset = "0x2BCD250", VA = "0x182BCE250", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BCC6A0", Offset = "0x2BCB6A0", VA = "0x182BCC6A0")]
		private void JHFJMDPIBJM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private T[] LGFGDGJHKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int PDAGAKEPNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private int CNBKBHMOMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private int ELKCHAMAHHH;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x157EAC0", Offset = "0x157DAC0", VA = "0x18157EAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public T CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x157FFA0", Offset = "0x157EFA0", VA = "0x18157FFA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x157E940", Offset = "0x157D940", VA = "0x18157E940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x15807D0", Offset = "0x157F7D0", VA = "0x1815807D0")]
	public IEAEDJCLPPJ(int OENKBEGLEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x157EB00", Offset = "0x157DB00", VA = "0x18157EB00")]
	public void AMLBOIMHPGF(T EBIGDBKBHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x157EE20", Offset = "0x157DE20", VA = "0x18157EE20")]
	public void CPBFHNMHJPM(IEnumerable<T> EICFKDEBBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1580630", Offset = "0x157F630", VA = "0x181580630")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x15805A0", Offset = "0x157F5A0", VA = "0x1815805A0")]
	public void NPAMGDGKOGE(int LEOAEOJMCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x157FE90", Offset = "0x157EE90", VA = "0x18157FE90")]
	public void EFHHBLOFNME(int LEOAEOJMCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x15800A0", Offset = "0x157F0A0", VA = "0x1815800A0")]
	public void IKLJBDDMDDK(T[] GJAKHOONFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x157FDA0", Offset = "0x157EDA0", VA = "0x18157FDA0")]
	public Enumerator EFCEFGGNIIL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1580650", Offset = "0x157F650", VA = "0x181580650", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1580650", Offset = "0x157F650", VA = "0x181580650", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x157FBC0", Offset = "0x157EBC0", VA = "0x18157FBC0")]
	private int DBKELIGPGFI(int CCELBNKPBGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x157EDF0", Offset = "0x157DDF0", VA = "0x18157EDF0")]
	private int CHNGBOFPICI(int CCELBNKPBGB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class MBPCALPHCFI
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KENMLBBJGIB(object[] CIIMHINGMLG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	protected MBPCALPHCFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class JMBCFGEDJEI<T> : MBPCALPHCFI
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	protected struct OKJNEOOLHBG
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum OECANLOAJEI
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
		public OECANLOAJEI DPPJBLOOGOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public T OKCPFPFJOFL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int OIDBGBOLJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly bool KMMFNECKING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	protected readonly bool POMCGIOPJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	protected List<T> OBDEEFHGNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<OKJNEOOLHBG> ICADGGHLMPM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool IECHPLEMEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB7E0", Offset = "0x2DFA7E0", VA = "0x182DFB7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB930", Offset = "0x2DFA930", VA = "0x182DFB930")]
	protected JMBCFGEDJEI(bool POMCGIOPJLH, bool KMMFNECKING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB6A0", Offset = "0x2DFA6A0", VA = "0x182DFB6A0")]
	protected bool NMLPNNANKGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB720", Offset = "0x2DFA720", VA = "0x182DFB720")]
	protected void ONCDLGGJEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB4F0", Offset = "0x2DFA4F0", VA = "0x182DFB4F0")]
	protected void LDMBANHGLON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x22A6CE0", Offset = "0x22A5CE0", VA = "0x1822A6CE0")]
	private static void IBFALNECEPI<U>(ref List<U> BHINNEMAJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB240", Offset = "0x2DFA240", VA = "0x182DFB240", Slot = "5")]
	public void AMLBOIMHPGF(T OKCPFPFJOFL, bool KHHGCOAGIIL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB3A0", Offset = "0x2DFA3A0", VA = "0x182DFB3A0", Slot = "6")]
	public void DNDEJFPIDIA(T OKCPFPFJOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2DFB820", Offset = "0x2DFA820", VA = "0x182DFB820")]
	public void PPNJFNMKMCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PDNFMIEGDOK
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLBOIMHPGF(Action OKCPFPFJOFL, bool KHHGCOAGIIL = false);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNDEJFPIDIA(Action OKCPFPFJOFL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class NHBIDAMCDOH : JMBCFGEDJEI<Action>, PDNFMIEGDOK
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x7180DD0", Offset = "0x717FDD0", VA = "0x187180DD0")]
	public NHBIDAMCDOH(bool POMCGIOPJLH = false, bool KMMFNECKING = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7180B50", Offset = "0x717FB50", VA = "0x187180B50")]
	public void KAEAMPPMANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7180D60", Offset = "0x717FD60", VA = "0x187180D60", Slot = "4")]
	public override void KENMLBBJGIB(object[] CIIMHINGMLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7180A90", Offset = "0x717FA90", VA = "0x187180A90")]
	public static NHBIDAMCDOH GFLICAMBIGB(NHBIDAMCDOH JKGBENJNDJG, Action OKCPFPFJOFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7180AF0", Offset = "0x717FAF0", VA = "0x187180AF0")]
	public static NHBIDAMCDOH JGIJBODPEKJ(NHBIDAMCDOH JKGBENJNDJG, Action OKCPFPFJOFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KLCLDFOIBJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLBOIMHPGF(Action<T> OKCPFPFJOFL, bool KHHGCOAGIIL = false);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNDEJFPIDIA(Action<T> OKCPFPFJOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class EAFMEKAHDGH<T> : JMBCFGEDJEI<Action<T>>, KLCLDFOIBJJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x25086C0", Offset = "0x25076C0", VA = "0x1825086C0")]
	public EAFMEKAHDGH(bool POMCGIOPJLH = false, bool KMMFNECKING = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3916960", Offset = "0x3915960", VA = "0x183916960")]
	public void KAEAMPPMANC(T EBIGDBKBHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3918730", Offset = "0x3917730", VA = "0x183918730", Slot = "4")]
	public override void KENMLBBJGIB(object[] CIIMHINGMLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x39152C0", Offset = "0x39142C0", VA = "0x1839152C0")]
	public static EAFMEKAHDGH<T> GFLICAMBIGB(EAFMEKAHDGH<T> JKGBENJNDJG, Action<T> OKCPFPFJOFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3915350", Offset = "0x3914350", VA = "0x183915350")]
	public static EAFMEKAHDGH<T> JGIJBODPEKJ(EAFMEKAHDGH<T> JKGBENJNDJG, Action<T> OKCPFPFJOFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FOGDOOLGEGC<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLBOIMHPGF(Action<T, U> OKCPFPFJOFL, bool KHHGCOAGIIL = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNDEJFPIDIA(Action<T, U> OKCPFPFJOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class EHNEPKABPOO<T, U> : JMBCFGEDJEI<Action<T, U>>, FOGDOOLGEGC<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x25086C0", Offset = "0x25076C0", VA = "0x1825086C0")]
	public EHNEPKABPOO(bool POMCGIOPJLH = false, bool KMMFNECKING = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x32263D0", Offset = "0x32253D0", VA = "0x1832263D0")]
	public void KAEAMPPMANC(T EBIGDBKBHOG, U JFMBJGAJCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3227620", Offset = "0x3226620", VA = "0x183227620", Slot = "4")]
	public override void KENMLBBJGIB(object[] CIIMHINGMLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x32246E0", Offset = "0x32236E0", VA = "0x1832246E0")]
	public static EHNEPKABPOO<T, U> GFLICAMBIGB(EHNEPKABPOO<T, U> JKGBENJNDJG, Action<T, U> OKCPFPFJOFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3224770", Offset = "0x3223770", VA = "0x183224770")]
	public static EHNEPKABPOO<T, U> JGIJBODPEKJ(EHNEPKABPOO<T, U> JKGBENJNDJG, Action<T, U> OKCPFPFJOFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MCKLGKBOKLM<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLBOIMHPGF(Action<T, U, V> OKCPFPFJOFL, bool KHHGCOAGIIL = false);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNDEJFPIDIA(Action<T, U, V> OKCPFPFJOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class FNODECFLFIK<T, U, V> : JMBCFGEDJEI<Action<T, U, V>>, MCKLGKBOKLM<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x25086C0", Offset = "0x25076C0", VA = "0x1825086C0")]
	public FNODECFLFIK(bool POMCGIOPJLH = false, bool KMMFNECKING = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x32BA810", Offset = "0x32B9810", VA = "0x1832BA810")]
	public void KAEAMPPMANC(T EBIGDBKBHOG, U JFMBJGAJCIC, V KEAONMJJPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x32BBC50", Offset = "0x32BAC50", VA = "0x1832BBC50", Slot = "4")]
	public override void KENMLBBJGIB(object[] CIIMHINGMLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x32B9260", Offset = "0x32B8260", VA = "0x1832B9260")]
	public static FNODECFLFIK<T, U, V> GFLICAMBIGB(FNODECFLFIK<T, U, V> JKGBENJNDJG, Action<T, U, V> OKCPFPFJOFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x32B92F0", Offset = "0x32B82F0", VA = "0x1832B92F0")]
	public static FNODECFLFIK<T, U, V> JGIJBODPEKJ(FNODECFLFIK<T, U, V> JKGBENJNDJG, Action<T, U, V> OKCPFPFJOFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BPHMNHMJEPG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLBOIMHPGF(Action<T, U, V, W> OKCPFPFJOFL, bool KHHGCOAGIIL = false);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNDEJFPIDIA(Action<T, U, V, W> OKCPFPFJOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class NJKMOKDNKJE<T, U, V, W> : JMBCFGEDJEI<Action<T, U, V, W>>, BPHMNHMJEPG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x25086C0", Offset = "0x25076C0", VA = "0x1825086C0")]
	public NJKMOKDNKJE(bool POMCGIOPJLH = false, bool KMMFNECKING = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2A69970", Offset = "0x2A68970", VA = "0x182A69970")]
	public void KAEAMPPMANC(T EBIGDBKBHOG, U JFMBJGAJCIC, V KEAONMJJPKL, W IPDEMIKFKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AFD0", Offset = "0x2A69FD0", VA = "0x182A6AFD0", Slot = "4")]
	public override void KENMLBBJGIB(object[] CIIMHINGMLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2A69040", Offset = "0x2A68040", VA = "0x182A69040")]
	public static NJKMOKDNKJE<T, U, V, W> GFLICAMBIGB(NJKMOKDNKJE<T, U, V, W> JKGBENJNDJG, Action<T, U, V, W> OKCPFPFJOFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2A690D0", Offset = "0x2A680D0", VA = "0x182A690D0")]
	public static NJKMOKDNKJE<T, U, V, W> JGIJBODPEKJ(NJKMOKDNKJE<T, U, V, W> JKGBENJNDJG, Action<T, U, V, W> OKCPFPFJOFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ONAKLMIMPNG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLBOIMHPGF(Action<T, U, V, W, X> OKCPFPFJOFL, bool KHHGCOAGIIL = false);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNDEJFPIDIA(Action<T, U, V, W, X> OKCPFPFJOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class LLCDDHICHEJ<T, U, V, W, X> : JMBCFGEDJEI<Action<T, U, V, W, X>>, ONAKLMIMPNG<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x25086C0", Offset = "0x25076C0", VA = "0x1825086C0")]
	public LLCDDHICHEJ(bool POMCGIOPJLH = false, bool KMMFNECKING = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x25079D0", Offset = "0x25069D0", VA = "0x1825079D0")]
	public void KAEAMPPMANC(T EBIGDBKBHOG, U JFMBJGAJCIC, V KEAONMJJPKL, W IPDEMIKFKME, X FKPADFHIFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2508350", Offset = "0x2507350", VA = "0x182508350", Slot = "4")]
	public override void KENMLBBJGIB(object[] CIIMHINGMLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x25078B0", Offset = "0x25068B0", VA = "0x1825078B0")]
	public static LLCDDHICHEJ<T, U, V, W, X> GFLICAMBIGB(LLCDDHICHEJ<T, U, V, W, X> JKGBENJNDJG, Action<T, U, V, W, X> OKCPFPFJOFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2507940", Offset = "0x2506940", VA = "0x182507940")]
	public static LLCDDHICHEJ<T, U, V, W, X> JGIJBODPEKJ(LLCDDHICHEJ<T, U, V, W, X> JKGBENJNDJG, Action<T, U, V, W, X> OKCPFPFJOFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PDDFDEINOLJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLBOIMHPGF(Action<T, U, V, W, X, Y> OKCPFPFJOFL, bool KHHGCOAGIIL = false);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNDEJFPIDIA(Action<T, U, V, W, X, Y> OKCPFPFJOFL);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class PDODJBKJMAA<T, U, V, W, X, Y> : JMBCFGEDJEI<Action<T, U, V, W, X, Y>>, PDDFDEINOLJ<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x25086C0", Offset = "0x25076C0", VA = "0x1825086C0")]
	public PDODJBKJMAA(bool POMCGIOPJLH = false, bool KMMFNECKING = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2A90550", Offset = "0x2A8F550", VA = "0x182A90550")]
	public void KAEAMPPMANC(T EBIGDBKBHOG, U JFMBJGAJCIC, V KEAONMJJPKL, W IPDEMIKFKME, X FKPADFHIFHA, Y NAFGCLHKJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2A90E20", Offset = "0x2A8FE20", VA = "0x182A90E20", Slot = "4")]
	public override void KENMLBBJGIB(object[] CIIMHINGMLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2A90430", Offset = "0x2A8F430", VA = "0x182A90430")]
	public static PDODJBKJMAA<T, U, V, W, X, Y> GFLICAMBIGB(PDODJBKJMAA<T, U, V, W, X, Y> JKGBENJNDJG, Action<T, U, V, W, X, Y> OKCPFPFJOFL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2A904C0", Offset = "0x2A8F4C0", VA = "0x182A904C0")]
	public static PDODJBKJMAA<T, U, V, W, X, Y> JGIJBODPEKJ(PDODJBKJMAA<T, U, V, W, X, Y> JKGBENJNDJG, Action<T, U, V, W, X, Y> OKCPFPFJOFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct HLNHHGHHIEG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FLIFFGDMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int DDGGAHBKCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int NNHCDLBFBNC;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1F65ED0", Offset = "0x1F64ED0", VA = "0x181F65ED0")]
	private HLNHHGHHIEG(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PHGJHCGDCLD, int HAHAPJBHOJG, int HAMOPGGOFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2D87560", Offset = "0x2D86560", VA = "0x182D87560")]
	public static HLNHHGHHIEG<T> DAABCIFNKOF()
	{
		return default(HLNHHGHHIEG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2D862D0", Offset = "0x2D852D0", VA = "0x182D862D0")]
	public (int, int, Task<T>) AALABIBMNND(int EFPEBPIJPBF, [Optional] CancellationToken OAGBBBCDIGC, double DKNLAFMNLEI = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2D87650", Offset = "0x2D86650", VA = "0x182D87650")]
	public void MOBHGAKFBIE(int EFPEBPIJPBF, int HAMOPGGOFPI, in T ALIHEMGMHCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FEJCAHBGBAD
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x717F100", Offset = "0x717E100", VA = "0x18717F100")]
	public static HLNHHGHHIEG<MPPFCKMNLHP> DAABCIFNKOF()
	{
		return default(HLNHHGHHIEG<MPPFCKMNLHP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x717F150", Offset = "0x717E150", VA = "0x18717F150")]
	public static void MOBHGAKFBIE(this in HLNHHGHHIEG<MPPFCKMNLHP> FKGCCPKFEDE, int EFPEBPIJPBF, int HAMOPGGOFPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DefaultMember("Item")]
public class JJAMBKNFNEK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<TKey, TVal> FAJNPMKIIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<TVal, TKey> AOBPDLJHGIE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xBFE320", Offset = "0xBFD320", VA = "0x180BFE320", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool DFLKEFAELDF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ICollection<TKey> HDHMNADNDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x227A3E0", Offset = "0x22793E0", VA = "0x18227A3E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ICollection<TVal> IHIBACLJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x227A180", Offset = "0x2279180", VA = "0x18227A180", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public TVal CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x244F0E0", Offset = "0x244E0E0", VA = "0x18244F0E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x244F120", Offset = "0x244E120", VA = "0x18244F120", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TKey CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x244EDA0", Offset = "0x244DDA0", VA = "0x18244EDA0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x244E2B0", Offset = "0x244D2B0", VA = "0x18244E2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x244E5F0", Offset = "0x244D5F0", VA = "0x18244E5F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x244EF70", Offset = "0x244DF70", VA = "0x18244EF70", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x244E3F0", Offset = "0x244D3F0", VA = "0x18244E3F0", Slot = "9")]
	public void Add(TKey LOHIKDGDMPP, TVal CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x244E430", Offset = "0x244D430", VA = "0x18244E430", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JFJFAONKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x244E650", Offset = "0x244D650", VA = "0x18244E650", Slot = "8")]
	public bool ContainsKey(TKey LOHIKDGDMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x244E680", Offset = "0x244D680", VA = "0x18244E680", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x244EEC0", Offset = "0x244DEC0", VA = "0x18244EEC0", Slot = "10")]
	public bool Remove(TKey LOHIKDGDMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x244EEF0", Offset = "0x244DEF0", VA = "0x18244EEF0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x244EFC0", Offset = "0x244DFC0", VA = "0x18244EFC0", Slot = "11")]
	public bool TryGetValue(TKey LOHIKDGDMPP, out TVal CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x244E940", Offset = "0x244D940", VA = "0x18244E940", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x244E6E0", Offset = "0x244D6E0", VA = "0x18244E6E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GJAKHOONFBO, int JGFMCOEDOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x244E330", Offset = "0x244D330", VA = "0x18244E330")]
	public void AMLBOIMHPGF(TVal HLLJGNGJMBM, TKey LOHIKDGDMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x244E3B0", Offset = "0x244D3B0", VA = "0x18244E3B0")]
	public void AMLBOIMHPGF(KeyValuePair<TVal, TKey> JFJFAONKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x244E770", Offset = "0x244D770", VA = "0x18244E770")]
	public bool DMLFOHBGBHN(TVal LOHIKDGDMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x244EE50", Offset = "0x244DE50", VA = "0x18244EE50")]
	public bool KAKGJPJGEDI(KeyValuePair<TVal, TKey> JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x244E7B0", Offset = "0x244D7B0", VA = "0x18244E7B0")]
	public bool DNDEJFPIDIA(TVal LOHIKDGDMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x244E7B0", Offset = "0x244D7B0", VA = "0x18244E7B0")]
	public bool DNDEJFPIDIA(KeyValuePair<TVal, TKey> JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x244EDE0", Offset = "0x244DDE0", VA = "0x18244EDE0")]
	public bool JLLAOJKGHMF(TVal LOHIKDGDMPP, out TKey CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x244E160", Offset = "0x244D160", VA = "0x18244E160")]
	public IEnumerator<KeyValuePair<TVal, TKey>> AHOFPKMMEED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x244E820", Offset = "0x244D820", VA = "0x18244E820")]
	private void GKIJBILPKKG(TKey LOHIKDGDMPP, TVal HLLJGNGJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x244E4D0", Offset = "0x244D4D0", VA = "0x18244E4D0")]
	private void CPFIFJMNILG(TKey LOHIKDGDMPP, TVal HLLJGNGJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x244ECA0", Offset = "0x244DCA0", VA = "0x18244ECA0")]
	private bool HJBAJMFKKCB(TKey LOHIKDGDMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x244EA40", Offset = "0x244DA40", VA = "0x18244EA40")]
	private bool HJBAJMFKKCB(TVal HLLJGNGJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x244EFF0", Offset = "0x244DFF0", VA = "0x18244EFF0")]
	public JJAMBKNFNEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public class EOFCIKKHONG<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Func<Internal, External> DKAICJGCNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly Func<External, Internal> LPFAOHADDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private IList<Internal> BHINNEMAJAD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IList<Internal> JFDJKMPHPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DFLKEFAELDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x967710", Offset = "0x966710", VA = "0x180967710", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x967960", Offset = "0x966960", VA = "0x180967960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xC407A0", Offset = "0xC3F7A0", VA = "0x180C407A0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xC40840", Offset = "0xC3F840", VA = "0x180C40840", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xC40740", Offset = "0xC3F740", VA = "0x180C40740", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0xC406B0", Offset = "0xC3F6B0", VA = "0x180C406B0")]
	public EOFCIKKHONG(Func<Internal, External> DKAICJGCNNO, Func<External, Internal> LPFAOHADDJE, bool JPCODLKAKEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xC403B0", Offset = "0xC3F3B0", VA = "0x180C403B0", Slot = "6")]
	public int IndexOf(External JFJFAONKKJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xC40040", Offset = "0xC3F040", VA = "0x180C40040", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xC400A0", Offset = "0xC3F0A0", VA = "0x180C400A0", Slot = "13")]
	public bool Contains(External JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xC40130", Offset = "0xC3F130", VA = "0x180C40130", Slot = "14")]
	public void CopyTo(External[] GJAKHOONFBO, int JGFMCOEDOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0xC3FF60", Offset = "0xC3EF60", VA = "0x180C3FF60", Slot = "11")]
	public void Add(External JFJFAONKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xC40490", Offset = "0xC3F490", VA = "0x180C40490", Slot = "7")]
	public void Insert(int CCELBNKPBGB, External JFJFAONKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0xC405F0", Offset = "0xC3F5F0", VA = "0x180C405F0", Slot = "15")]
	public bool Remove(External JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0xC40530", Offset = "0xC3F530", VA = "0x180C40530", Slot = "8")]
	public void RemoveAt(int CCELBNKPBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0xC40340", Offset = "0xC3F340", VA = "0x180C40340", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xC40680", Offset = "0xC3F680", VA = "0x180C40680", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DefaultMember("Item")]
public class CGFGGAOGFFI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Func<Internal, External> DKAICJGCNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private IReadOnlyList<Internal> BHINNEMAJAD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> JFDJKMPHPOK
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DFLKEFAELDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x217B970", Offset = "0x217A970", VA = "0x18217B970", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x217B910", Offset = "0x217A910", VA = "0x18217B910", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xBFE350", Offset = "0xBFD350", VA = "0x180BFE350")]
	public CGFGGAOGFFI(Func<Internal, External> DKAICJGCNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x217B8C0", Offset = "0x217A8C0", VA = "0x18217B8C0")]
	public CGFGGAOGFFI(IReadOnlyList<Internal> BHINNEMAJAD, Func<Internal, External> DKAICJGCNNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x217B6B0", Offset = "0x217A6B0", VA = "0x18217B6B0")]
	public void IKLJBDDMDDK(External[] GJAKHOONFBO, int JGFMCOEDOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x217B640", Offset = "0x217A640", VA = "0x18217B640", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0xC01970", Offset = "0xC00970", VA = "0x180C01970", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public class ECDFAJEOMDC<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private IReadOnlyList<Internal> BHINNEMAJAD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IReadOnlyList<Internal> JFDJKMPHPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool DFLKEFAELDF
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public External CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x391DDF0", Offset = "0x391CDF0", VA = "0x18391DDF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x391DD90", Offset = "0x391CD90", VA = "0x18391DD90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0xBFE350", Offset = "0xBFD350", VA = "0x180BFE350")]
	public ECDFAJEOMDC(IReadOnlyList<Internal> BHINNEMAJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x391DCF0", Offset = "0x391CCF0", VA = "0x18391DCF0")]
	public bool KAKGJPJGEDI(External JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x391DAD0", Offset = "0x391CAD0", VA = "0x18391DAD0")]
	public void IKLJBDDMDDK(External[] GJAKHOONFBO, int JGFMCOEDOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x391DA00", Offset = "0x391CA00", VA = "0x18391DA00", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xC40680", Offset = "0xC3F680", VA = "0x180C40680", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class JCABIFMMAGJ<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> MMJPPBMDBCB(TRequest CFOFEENKFCN, CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum NIJLJCANALA
	{
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class BMIOHLIDJCP
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private const float PLOPGGJGMOP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private TimeSpan IPFJLEJPJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int JMGKKKLAOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public NIJLJCANALA HFFPDCKIDGF;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly BMIOHLIDJCP JCGFDJGGMMP;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float KBBPICFCIMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x23C8780", Offset = "0x23C7780", VA = "0x1823C8780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan JONNBDKJMLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x23C88D0", Offset = "0x23C78D0", VA = "0x1823C88D0")]
		public BMIOHLIDJCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct LNDODOFDJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public readonly TRequest CFOFEENKFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly CancellationToken OAGBBBCDIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly TaskCompletionSource<TResult> GCHDOHEOJIB;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2510540", Offset = "0x250F540", VA = "0x182510540")]
		public LNDODOFDJCO(TRequest CFOFEENKFCN, TaskCompletionSource<TResult> GCHDOHEOJIB, CancellationToken OAGBBBCDIGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class JIMBBPOGNGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public JCABIFMMAGJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public JIMBBPOGNGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2448BA0", Offset = "0x2447BA0", VA = "0x182448BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class FKKEKNCKMBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public JCABIFMMAGJ<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private LNDODOFDJCO <req>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public FKKEKNCKMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2FBB170", Offset = "0x2FBA170", VA = "0x182FBB170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CancellationTokenSource LLODKHMBJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly List<LNDODOFDJCO> ECFCHBDAODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly BMIOHLIDJCP FJBJBBMLCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly MMJPPBMDBCB PDAOCOFPLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Task HJNPIOBALEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int IOJHCDKDFAC;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x36D18E0", Offset = "0x36D08E0", VA = "0x1836D18E0")]
	public JCABIFMMAGJ(MMJPPBMDBCB PDAOCOFPLGA, [Optional] BMIOHLIDJCP FJBJBBMLCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x36D0360", Offset = "0x36CF360", VA = "0x1836D0360")]
	public Task<TResult> ALPGGFHGDAI(TRequest CFOFEENKFCN, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x36D1710", Offset = "0x36D0710", VA = "0x1836D1710")]
	private void HIFEBEBLKJJ(LNDODOFDJCO CDEAGIHHKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x36D07B0", Offset = "0x36CF7B0", VA = "0x1836D07B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCABIFMMAGJ<, >.JIMBBPOGNGO))]
	private Task DDMGKLLNJBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x36D0940", Offset = "0x36CF940", VA = "0x1836D0940")]
	private LNDODOFDJCO EKAGJIHBDMH()
	{
		return default(LNDODOFDJCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x36D1350", Offset = "0x36D0350", VA = "0x1836D1350")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JCABIFMMAGJ<, >.FKKEKNCKMBP))]
	private Task FABAGFECBIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x36D1640", Offset = "0x36D0640", VA = "0x1836D1640")]
	private void GNNJGOFJKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x36D0900", Offset = "0x36CF900", VA = "0x1836D0900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface KGJMOMCODCP
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface HPCJOHCCOFE<T> : KGJMOMCODCP
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	T FNCIDNAOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool CPDJIFNOHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string JLFNKOBPLIN
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
	HPCJOHCCOFE<T> PJPLMKAKOKL(Action<T> ICIEOJDIPKB);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HPCJOHCCOFE<T> ABGDIAIPPFJ(Action<T> ICIEOJDIPKB);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HPCJOHCCOFE<T> HAIICJGPKAH(Action<T, T> JAEKFJLOFNG);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HPCJOHCCOFE<T> PLKBCJHGDFE(Action<T, T> JAEKFJLOFNG);

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HPCJOHCCOFE<T> AODCCAANGMP(Action<string> PLCJFBIJAFL);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HPCJOHCCOFE<T> DECHPJFBOGN(Action<string> PLCJFBIJAFL);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class BAOEJEKEMGF<T> : HPCJOHCCOFE<T>, KGJMOMCODCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private EHNEPKABPOO<T, T> OGOLDBMHEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private EAFMEKAHDGH<T> MNGHKMJCEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private EAFMEKAHDGH<string> FBKAGMFNLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private string AOLOOCNDGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private T ALIHEMGMHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool ADHNKIPMBPA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T FNCIDNAOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA75610", Offset = "0xA74610", VA = "0x180A75610", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x168D8A0", Offset = "0x168C8A0", VA = "0x18168D8A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CPDJIFNOHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x913220", Offset = "0x912220", VA = "0x180913220", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string JLFNKOBPLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xBDD0B0", Offset = "0xBDC0B0", VA = "0x180BDD0B0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xEB27E0", Offset = "0xEB17E0", VA = "0x180EB27E0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6594530", Offset = "0x6593530", VA = "0x186594530")]
	private void NJLHKOGPPIM(T EMBONFDCNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x65943D0", Offset = "0x65933D0", VA = "0x1865943D0")]
	private void KGGJGPMOFGO(string HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6594480", Offset = "0x6593480", VA = "0x186594480")]
	public void NJJHHEGPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6594380", Offset = "0x6593380", VA = "0x186594380", Slot = "6")]
	public HPCJOHCCOFE<T> HAIICJGPKAH(Action<T, T> JAEKFJLOFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6594660", Offset = "0x6593660", VA = "0x186594660", Slot = "7")]
	public HPCJOHCCOFE<T> PLKBCJHGDFE(Action<T, T> JAEKFJLOFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x65945D0", Offset = "0x65935D0", VA = "0x1865945D0", Slot = "4")]
	public HPCJOHCCOFE<T> PJPLMKAKOKL(Action<T> JAEKFJLOFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6594220", Offset = "0x6593220", VA = "0x186594220", Slot = "5")]
	public HPCJOHCCOFE<T> ABGDIAIPPFJ(Action<T> ICIEOJDIPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6594270", Offset = "0x6593270", VA = "0x186594270", Slot = "8")]
	public HPCJOHCCOFE<T> AODCCAANGMP(Action<string> PLCJFBIJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6594310", Offset = "0x6593310", VA = "0x186594310", Slot = "9")]
	public HPCJOHCCOFE<T> DECHPJFBOGN(Action<string> PLCJFBIJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x65946B0", Offset = "0x65936B0", VA = "0x1865946B0")]
	public BAOEJEKEMGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class NEKNLPOGLAC
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class HPFEFLEBIJL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public HPCJOHCCOFE<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public FPHCELGDGAI<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public HPFEFLEBIJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D94330", Offset = "0x2D93330", VA = "0x182D94330")]
		internal void ADBDHMNDGHL(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x251CBC0", Offset = "0x251BBC0", VA = "0x18251CBC0")]
	public static IBHBGBJGJHP<T> ACFOFJDLAHB<T>(this HPCJOHCCOFE<T> DCGJELMJPAD, Action<T> ELHFOIEJAFO)
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
			[Cpp2IlInjected.Address(RVA = "0x2C35260", Offset = "0x2C34260", VA = "0x182C35260")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x70A3350", Offset = "0x70A2350", VA = "0x1870A3350")]
		public SerializedGuid(in Guid PLBICILNGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7183780", Offset = "0x7182780", VA = "0x187183780")]
		public static SerializedGuid OMCKPOBPNMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x71836F0", Offset = "0x71826F0", VA = "0x1871836F0")]
		public static SerializedGuid NDPAJFLINMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x71835D0", Offset = "0x71825D0", VA = "0x1871835D0")]
		public bool LBFIGGIBIMI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x70A3320", Offset = "0x70A2320", VA = "0x1870A3320", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7183810", Offset = "0x7182810", VA = "0x187183810", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7183660", Offset = "0x7182660", VA = "0x187183660")]
		public bool LPGOAMJEJHA(in Guid PLBICILNGEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7183440", Offset = "0x7182440", VA = "0x187183440", Slot = "7")]
		public bool Equals(SerializedGuid BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x71834F0", Offset = "0x71824F0", VA = "0x1871834F0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x70A3270", Offset = "0x70A2270", VA = "0x1870A3270", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x70A30B0", Offset = "0x70A20B0", VA = "0x1870A30B0", Slot = "6")]
		public int CompareTo(SerializedGuid BKLMLPFOMCO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class OILKEFAIDEN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly Type LEONJBELMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string HPGNLNJAGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool FCHBANFDMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly bool NILGFLIHCIA;

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7180E30", Offset = "0x717FE30", VA = "0x187180E30")]
	public OILKEFAIDEN(Type NFPJPAFDKGA, string HICCJALNAFG, bool NJKAJOAKBMK = false, bool LNCENFKKIJE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class HDDLBAIEHCG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<T> BHINNEMAJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private HashSet<T> CIKMOFJNOHB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xBFE320", Offset = "0xBFD320", VA = "0x180BFE320", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool DFLKEFAELDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x98E270", Offset = "0x98D270", VA = "0x18098E270", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public T CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xE5AF70", Offset = "0xE59F70", VA = "0x180E5AF70", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x203C630", Offset = "0x203B630", VA = "0x18203C630", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x203BC10", Offset = "0x203AC10", VA = "0x18203BC10", Slot = "11")]
	public void Add(T JFJFAONKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x203C1C0", Offset = "0x203B1C0", VA = "0x18203C1C0")]
	public bool NNGGEKFJMHE(T JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x203C490", Offset = "0x203B490", VA = "0x18203C490", Slot = "15")]
	public bool Remove(T JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x203BD30", Offset = "0x203AD30", VA = "0x18203BD30", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x203C510", Offset = "0x203B510", VA = "0x18203C510", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x203BC70", Offset = "0x203AC70", VA = "0x18203BC70", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x203BCD0", Offset = "0x203ACD0", VA = "0x18203BCD0", Slot = "13")]
	public bool Contains(T JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x203BD00", Offset = "0x203AD00", VA = "0x18203BD00", Slot = "14")]
	public void CopyTo(T[] GJAKHOONFBO, int JGFMCOEDOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x203BF50", Offset = "0x203AF50", VA = "0x18203BF50", Slot = "6")]
	public int IndexOf(T JFJFAONKKJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x203C050", Offset = "0x203B050", VA = "0x18203C050", Slot = "7")]
	public void Insert(int CCELBNKPBGB, T JFJFAONKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x203C330", Offset = "0x203B330", VA = "0x18203C330", Slot = "8")]
	public void RemoveAt(int CCELBNKPBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x203BE80", Offset = "0x203AE80", VA = "0x18203BE80")]
	public void HCKGLHJOFKH(Predicate<T> ANLNEGECBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x203BC40", Offset = "0x203AC40", VA = "0x18203BC40")]
	public void BBDJIBMOAAJ(Comparison<T> MCMGMBFHAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x203C540", Offset = "0x203B540", VA = "0x18203C540")]
	public HDDLBAIEHCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class DENLJHOIOBB
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x717E9F0", Offset = "0x717D9F0", VA = "0x18717E9F0")]
	public static Vector3 GPIOLKNBCGC(this GameObject LAPEIFCGFLM, float KFPLCNOPLCI)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class JOCCHKKEBFB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly Type LEONJBELMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly string HPGNLNJAGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool FCHBANFDMEE;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7180710", Offset = "0x717F710", VA = "0x187180710")]
	public JOCCHKKEBFB(Type NFPJPAFDKGA, string HICCJALNAFG, bool NJKAJOAKBMK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class DCBFBFNLCAF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x717E980", Offset = "0x717D980", VA = "0x18717E980")]
	public DCBFBFNLCAF(string HJJLMCEMDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x717E900", Offset = "0x717D900", VA = "0x18717E900")]
	public DCBFBFNLCAF(string HJJLMCEMDKN, Exception MPKLHKDLKCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class FNBCGPEGPOB
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x71802A0", Offset = "0x717F2A0", VA = "0x1871802A0")]
	[NotNull]
	public static byte[] HIPECIEMLGE(this EIAPCOLJCNP DDACIGDPIOP, byte[] IDFNBIGJHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7180060", Offset = "0x717F060", VA = "0x187180060")]
	[NotNull]
	public static byte[] HIPECIEMLGE(this EIAPCOLJCNP DDACIGDPIOP, HashAlgorithmName BAOPPCGFGCA, byte[] IDFNBIGJHLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface EIAPCOLJCNP
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash HFGGAOHBKDG);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface FAPJGJIPKGE : EIAPCOLJCNP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] CONNFEHLCNF
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
	byte[] LENFGIBIOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	UnityEngine.Object LELNGPCGIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class CHPDFKIDAMO
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class ECPNEPEJMHN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x717EEC0", Offset = "0x717DEC0", VA = "0x18717EEC0")]
		public ECPNEPEJMHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x717EE60", Offset = "0x717DE60", VA = "0x18717EE60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const byte IPCIDPJOPML = 1;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const byte OFIGCMGAHIN = 0;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> DBMNKCIDGLO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static bool KPEEKAPOOAO;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C8D2D0", Offset = "0x2C8C2D0", VA = "0x182C8D2D0")]
	[Conditional("UNITY_EDITOR")]
	private static void JAKJGAHNPIL<T>(params T[] HACCCKNMFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x717D9A0", Offset = "0x717C9A0", VA = "0x18717D9A0")]
	public static IDisposable IGDPEGLHEMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x717DAA0", Offset = "0x717CAA0", VA = "0x18717DAA0")]
	public static void JPBHGBKMEPA(this IncrementalHash GKCNEPLLOHP, [CanBeNull] GameObject LAPEIFCGFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C8DCB0", Offset = "0x2C8CCB0", VA = "0x182C8DCB0")]
	public static void JPBHGBKMEPA<T>(this IncrementalHash GKCNEPLLOHP, [CanBeNull] T GDOIACLJEDE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C8CDF0", Offset = "0x2C8BDF0", VA = "0x182C8CDF0")]
	public static void CCLHGMMIJHB<T>(this IncrementalHash GKCNEPLLOHP, [CanBeNull] T DDACIGDPIOP) where T : EIAPCOLJCNP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C8CE80", Offset = "0x2C8BE80", VA = "0x182C8CE80")]
	public static void FGBFDODAOND<T>(this IncrementalHash GKCNEPLLOHP, [CanBeNull] IList<T> LGCOMCFAMIL) where T : EIAPCOLJCNP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x717DE60", Offset = "0x717CE60", VA = "0x18717DE60")]
	private static bool MNOLKIHONLH([CanBeNull] EIAPCOLJCNP DDACIGDPIOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x717D540", Offset = "0x717C540", VA = "0x18717D540")]
	public static void FPLBKJMPAGP(this IncrementalHash HFGGAOHBKDG, [CanBeNull] string PKGKPIIJMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x717D7D0", Offset = "0x717C7D0", VA = "0x18717D7D0")]
	public static void HNIFEMJMNNC(this IncrementalHash HFGGAOHBKDG, long IGBCGICCDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x717DEF0", Offset = "0x717CEF0", VA = "0x18717DEF0")]
	public static void OLIOAMPFJKD(this IncrementalHash HFGGAOHBKDG, int CFBIGFJEBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x717D2A0", Offset = "0x717C2A0", VA = "0x18717D2A0")]
	public static void BGHAGONMBOP(this IncrementalHash HFGGAOHBKDG, short HBGEOIHKCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x717DB90", Offset = "0x717CB90", VA = "0x18717DB90")]
	public static void KEILLBLHAAJ(this IncrementalHash HFGGAOHBKDG, byte AOADPADDDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x717D5A0", Offset = "0x717C5A0", VA = "0x18717D5A0")]
	public static void GCLAJGJDGAK(this IncrementalHash HFGGAOHBKDG, bool ODOLEAGNEOM, bool GEFOIGJCNOP = false, bool DNFLFAFNFJM = false, bool MFLPAMMEEKE = false, bool BADGICIMFIB = false, bool ADOEHDMIDPF = false, bool PDFCDFJMAHO = false, bool BLHCAFANJIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C8D5C0", Offset = "0x2C8C5C0", VA = "0x182C8D5C0")]
	public static void JGMMPNAJKPA<T>(this IncrementalHash HFGGAOHBKDG, T NICLHEEPPOH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x717D4E0", Offset = "0x717C4E0", VA = "0x18717D4E0")]
	public static void FKAADJIFHEC(this IncrementalHash HFGGAOHBKDG, float KBPPKKLHPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x717D770", Offset = "0x717C770", VA = "0x18717D770")]
	public static void HNGOHIMDEDJ(this IncrementalHash HFGGAOHBKDG, double ALINEJIJDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x717E0C0", Offset = "0x717D0C0", VA = "0x18717E0C0")]
	public static void ONNOIJAFLHB(this IncrementalHash HFGGAOHBKDG, ulong AMPMBNGOFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x717DA40", Offset = "0x717CA40", VA = "0x18717DA40")]
	public static void IOMNOPDEOKM(this IncrementalHash HFGGAOHBKDG, uint MFHHFDNPJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x717D470", Offset = "0x717C470", VA = "0x18717D470")]
	public static void DDAOGKEIDPC(this IncrementalHash HFGGAOHBKDG, ushort IABPHFCNHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x717DD00", Offset = "0x717CD00", VA = "0x18717DD00")]
	public static void KGNPOAILNII(this IncrementalHash HFGGAOHBKDG, Vector3 MFBMENAPNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x717E130", Offset = "0x717D130", VA = "0x18717E130")]
	public static void PLBGEIGMMOH(this IncrementalHash HFGGAOHBKDG, Quaternion ONLAMMPAEFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class BPJCMCAHAOP
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x717CEB0", Offset = "0x717BEB0", VA = "0x18717CEB0")]
	[NotNull]
	public static byte[] HIPECIEMLGE(this FAPJGJIPKGE HCIKFNDHEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x717CF20", Offset = "0x717BF20", VA = "0x18717CF20")]
	[NotNull]
	public static byte[] HIPECIEMLGE(this FAPJGJIPKGE HCIKFNDHEMJ, HashAlgorithmName BAOPPCGFGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x717CD20", Offset = "0x717BD20", VA = "0x18717CD20")]
	public static bool GNBPFFDMNNC([CanBeNull] this FAPJGJIPKGE HCIKFNDHEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x717CB80", Offset = "0x717BB80", VA = "0x18717CB80")]
	public static bool GNBPFFDMNNC([CanBeNull] this FAPJGJIPKGE HCIKFNDHEMJ, out string AOLOOCNDGPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x717CF90", Offset = "0x717BF90", VA = "0x18717CF90")]
	private static string HLBCADEPBLK([CanBeNull] byte[] KMJIEGIBFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x717D000", Offset = "0x717C000", VA = "0x18717D000")]
	private static bool PFLNCNHMLFK([NotNull] FAPJGJIPKGE HCIKFNDHEMJ, [CanBeNull] out byte[] ONIPMJNBNFM, [CanBeNull] out byte[] EBCCEBBIKCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class IMALAGIJPHB<TTask, T> : ODMBHKBFLMB<T>, EEODJMNJAJN, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LAKBHAHFDBD
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
			public LAKBHAHFDBD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1B5FCF0", Offset = "0x1B5ECF0", VA = "0x181B5FCF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
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
		public IMALAGIJPHB<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public LAKBHAHFDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2681520", Offset = "0x2680520", VA = "0x182681520")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(IMALAGIJPHB<, >.LAKBHAHFDBD.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> OPCNHLNOBEC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static bool OKJFBFNMNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Task<T> IJOJNMAHKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly CancellationTokenSource IGGNLLGJDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool NBJIGGJMNPH;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Task<T> OMMAKDBEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private Task ACPPNALHHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IBHBGBJGJHP<T> IABNJDEAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private GAEMIFNLIHB COIDHFLHKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xBF8270", Offset = "0xBF7270", VA = "0x180BF8270", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool EDGMLIFNIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x967710", Offset = "0x966710", VA = "0x180967710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0xBF87F0", Offset = "0xBF77F0", VA = "0x180BF87F0")]
	static IMALAGIJPHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0xBF8B10", Offset = "0xBF7B10", VA = "0x180BF8B10")]
	protected IMALAGIJPHB(TTask IJOJNMAHKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0xBF8200", Offset = "0xBF7200", VA = "0x180BF8200", Slot = "1")]
	~IMALAGIJPHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0xBF81D0", Offset = "0xBF71D0", VA = "0x180BF81D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0xBF82A0", Offset = "0xBF72A0", VA = "0x180BF82A0")]
	private void OJEHGLDDBNK(bool FAIJCBABMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T NLCINDMMGIG(TTask PNOIKLOJMIM);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KADDMKGIFHN();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EFOIAGAMHAM : BPKFHGCHJJD<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x717EF40", Offset = "0x717DF40", VA = "0x18717EF40")]
	public EFOIAGAMHAM(Exception PJPDEBBCODN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class BPKFHGCHJJD<T> : ODMBHKBFLMB<T>, EEODJMNJAJN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public Task<T> OMMAKDBEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private Task ACPPNALHHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xBDEA00", Offset = "0xBDDA00", VA = "0x180BDEA00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public IBHBGBJGJHP<T> IABNJDEAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private GAEMIFNLIHB COIDHFLHKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xEB18E0", Offset = "0xEB08E0", VA = "0x180EB18E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2203580", Offset = "0x2202580", VA = "0x182203580")]
	public BPKFHGCHJJD(Exception PJPDEBBCODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface EEODJMNJAJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	[NotNull]
	Task OMMAKDBEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[NotNull]
	GAEMIFNLIHB IABNJDEAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface ODMBHKBFLMB<T> : EEODJMNJAJN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[NotNull]
	new Task<T> OMMAKDBEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	new IBHBGBJGJHP<T> IABNJDEAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GDEMCCECEIG : NDCEBBMEKKP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7180320", Offset = "0x717F320", VA = "0x187180320")]
	public GDEMCCECEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NDCEBBMEKKP<T> : ODMBHKBFLMB<T>, EEODJMNJAJN, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Task<T> OMMAKDBEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private Task ACPPNALHHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xBDEA00", Offset = "0xBDDA00", VA = "0x180BDEA00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IBHBGBJGJHP<T> IABNJDEAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private GAEMIFNLIHB COIDHFLHKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xEB18E0", Offset = "0xEB08E0", VA = "0x180EB18E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x297E890", Offset = "0x297D890", VA = "0x18297E890")]
	public NDCEBBMEKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public sealed class LILHCJDBOKI : MNKIABAIHBN<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class DHFINLCHKBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action<LILHCJDBOKI, HPPHLHFLMDP> callback;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public DHFINLCHKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x717ECA0", Offset = "0x717DCA0", VA = "0x18717ECA0")]
		internal void ONAOKMGGBMA(MNKIABAIHBN<string> timer, HPPHLHFLMDP log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7180850", Offset = "0x717F850", VA = "0x187180850")]
	public LILHCJDBOKI(HPPHLHFLMDP CGJPMMKJEHF, [Optional] string MBNDFLFKJMA, [Optional] int? MMKHGOGGNPJ, [Optional] Stopwatch HFJHLAPGKCO, [Optional] Action<string, NAPCOPMAIGI, HPPHLHFLMDP> ELGKLHOFNAE, [Optional] Action<string, NAPCOPMAIGI, HPPHLHFLMDP> COECOKAHNCM, [Optional] Action<LILHCJDBOKI, HPPHLHFLMDP> IKDOKIHPGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7180770", Offset = "0x717F770", VA = "0x187180770")]
	private static Action<MNKIABAIHBN<string>, HPPHLHFLMDP> ONOLAONKGNC(Action<LILHCJDBOKI, HPPHLHFLMDP> ELHFOIEJAFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MNGHMAIGFOB<TKey> : HLLKADPNONF<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class OKOLMEKIBIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public DHMHGJPBOPE keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public OKOLMEKIBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x12E4890", Offset = "0x12E3890", VA = "0x1812E4890")]
		internal string EJBMNKPGIMI(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x272E530", Offset = "0x272D530", VA = "0x18272E530", Slot = "5")]
	protected override string NJMMEEEOBLK(MNKIABAIHBN<TKey> PPHNMHNDCPA, DHMHGJPBOPE OGBAHPJEOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x272EE10", Offset = "0x272DE10", VA = "0x18272EE10")]
	public MNGHMAIGFOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class AKPEEDDJLKB<TKey> : NIEOLLEGGGA<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate string PMMIFIDCMBJ(TKey LOHIKDGDMPP);

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private const int IMFGIEKAEKF = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly string NJFOOHJEFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly double BDHEBGHHKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool MMBGFCKMFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly int IJGEDKFIGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly ISet<string> BMKFLPCDAJJ;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x340CE20", Offset = "0x340BE20", VA = "0x18340CE20")]
	private static string CCJNOPPINJJ(TKey LOHIKDGDMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x340D860", Offset = "0x340C860", VA = "0x18340D860")]
	public AKPEEDDJLKB(string NJFOOHJEFPH = "F2", double BDHEBGHHKBE = double.MaxValue, bool MMBGFCKMFOA = false, int IJGEDKFIGNA = int.MaxValue, [Optional] ISet<string> BMKFLPCDAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x340D270", Offset = "0x340C270", VA = "0x18340D270", Slot = "4")]
	public override Dictionary<string, string> NJHHMPECDPK(MNKIABAIHBN<TKey> PPHNMHNDCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x340D190", Offset = "0x340C190", VA = "0x18340D190")]
	private bool LOLHELPJKHI(string LLIDCNBPOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x340D320", Offset = "0x340C320", VA = "0x18340D320")]
	public Dictionary<string, string> NJHHMPECDPK(MNKIABAIHBN<TKey> PPHNMHNDCPA, PMMIFIDCMBJ OGBAHPJEOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x340CFE0", Offset = "0x340BFE0", VA = "0x18340CFE0")]
	private string LADHFKPAIIN(StringBuilder FEAOGPECEDC, List<TKey> IGKNKBBJOBI, PMMIFIDCMBJ OGBAHPJEOMH, bool JNFDHBMDGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x340CE60", Offset = "0x340BE60", VA = "0x18340CE60")]
	private static void DLDEDAAFKLE(StringBuilder NBOCFLOFPJI, string GFMFNBLIIGB, bool HGKAFJJOOBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class NIEOLLEGGGA<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut NJHHMPECDPK(MNKIABAIHBN<TKey> PPHNMHNDCPA);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
	protected NIEOLLEGGGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public abstract class HLLKADPNONF<TKey> : NIEOLLEGGGA<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate string DHMHGJPBOPE(TKey LOHIKDGDMPP);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x2D85F20", Offset = "0x2D84F20", VA = "0x182D85F20")]
	protected string DPJGLDMKIIB(double JANFICIMAKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x2D85EC0", Offset = "0x2D84EC0", VA = "0x182D85EC0")]
	protected string CKAAMHDDBOB(int ANJLEKPNFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x2D85E80", Offset = "0x2D84E80", VA = "0x182D85E80")]
	private static string CCJNOPPINJJ(TKey LOHIKDGDMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2D860C0", Offset = "0x2D850C0", VA = "0x182D860C0", Slot = "4")]
	public override string NJHHMPECDPK(MNKIABAIHBN<TKey> PPHNMHNDCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2D85F90", Offset = "0x2D84F90", VA = "0x182D85F90")]
	public string NJHHMPECDPK(MNKIABAIHBN<TKey> PPHNMHNDCPA, [NotNull] DHMHGJPBOPE OGBAHPJEOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string NJMMEEEOBLK(MNKIABAIHBN<TKey> PPHNMHNDCPA, [NotNull] DHMHGJPBOPE OGBAHPJEOMH);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0xC40680", Offset = "0xC3F680", VA = "0x180C40680")]
	protected HLLKADPNONF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class HNIGAOLMAEP
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private class OJAFGJHFAJF : HNIGAOLMAEP
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static HNIGAOLMAEP HIEJPGCOIBA
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7180F00", Offset = "0x717FF00", VA = "0x187180F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override DateTime NEGCPJOCGNH
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x7180EB0", Offset = "0x717FEB0", VA = "0x187180EB0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override float NMFGLGEELPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7180EA0", Offset = "0x717FEA0", VA = "0x187180EA0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7181000", Offset = "0x7180000", VA = "0x187181000")]
		public OJAFGJHFAJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static HNIGAOLMAEP DLCAFLMKAHJ;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static HNIGAOLMAEP JCGFDJGGMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x71804B0", Offset = "0x717F4B0", VA = "0x1871804B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public abstract DateTime NEGCPJOCGNH
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public abstract float NMFGLGEELPN
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	protected HNIGAOLMAEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class GLGCPLKKKEP<TKey> : HLLKADPNONF<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct BLODAMIKNLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public DHMHGJPBOPE keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static GLGCPLKKKEP<TKey> HIEJPGCOIBA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private const int BCPBKMMMCOA = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly string[] LDIIGHNHENM;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x322D360", Offset = "0x322C360", VA = "0x18322D360")]
	private GLGCPLKKKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x322C3A0", Offset = "0x322B3A0", VA = "0x18322C3A0", Slot = "5")]
	protected override string NJMMEEEOBLK(MNKIABAIHBN<TKey> PPHNMHNDCPA, DHMHGJPBOPE OGBAHPJEOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x322C2B0", Offset = "0x322B2B0", VA = "0x18322C2B0")]
	[CompilerGenerated]
	internal static string BFMBDNJJCKH(string EGBHLNPLPKO, TKey LOHIKDGDMPP, ref BLODAMIKNLB P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class MNKIABAIHBN<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public readonly struct NAPCOPMAIGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly long ONBGLOMMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly long NCGFIEKDIOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly int MMKHGOGGNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly int AHIBAGNNNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly bool JDCIOJHBHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly string POIMFPJCPOJ;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2976EC0", Offset = "0x2975EC0", VA = "0x182976EC0")]
		public NAPCOPMAIGI(long ONBGLOMMAME, int MMKHGOGGNPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2976E90", Offset = "0x2975E90", VA = "0x182976E90")]
		public NAPCOPMAIGI(long ONBGLOMMAME, long NCGFIEKDIOP, int MMKHGOGGNPJ, int AHIBAGNNNJK, bool JDCIOJHBHJM, string POIMFPJCPOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2976D50", Offset = "0x2975D50", VA = "0x182976D50")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GMPPKECPHMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2976C70", Offset = "0x2975C70", VA = "0x182976C70")]
		public int AAFKNCGDEFG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2976D30", Offset = "0x2975D30", VA = "0x182976D30")]
		public int GHACKOHJLCI(int FCAIGLHEBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2976CC0", Offset = "0x2975CC0", VA = "0x182976CC0")]
		public double CHMHALEKLID()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2976DD0", Offset = "0x2975DD0", VA = "0x182976DD0")]
		public NAPCOPMAIGI PGCOKOBHALI(long NCGFIEKDIOP, int AHIBAGNNNJK)
		{
			return default(NAPCOPMAIGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class JJAEKMMDGKH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class KEMGKPCGAHB<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public Func<JJAEKMMDGKH, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public JJAEKMMDGKH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private JJAEKMMDGKH <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public KEMGKPCGAHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x353E430", Offset = "0x353D430", VA = "0x18353E430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly TKey MJKKBFJJOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly MNKIABAIHBN<TKey> PPHNMHNDCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private readonly HPPHLHFLMDP CGJPMMKJEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private List<JJAEKMMDGKH> DBLKPLMOFMI;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string NNBHPGJONHL
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x1690C30", Offset = "0x168FC30", VA = "0x181690C30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x244DB40", Offset = "0x244CB40", VA = "0x18244DB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IEnumerable<JJAEKMMDGKH> LJMGCPOELKA
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x244DB20", Offset = "0x244CB20", VA = "0x18244DB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public NAPCOPMAIGI LKCAMCEFHDO
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x244DD20", Offset = "0x244CD20", VA = "0x18244DD20")]
			[CompilerGenerated]
			get
			{
				return default(NAPCOPMAIGI);
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x244DD40", Offset = "0x244CD40", VA = "0x18244DD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x244DFA0", Offset = "0x244CFA0", VA = "0x18244DFA0")]
		internal JJAEKMMDGKH(MNKIABAIHBN<TKey> PPHNMHNDCPA, TKey LOHIKDGDMPP, HPPHLHFLMDP CGJPMMKJEHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x244DD70", Offset = "0x244CD70", VA = "0x18244DD70")]
		public JJAEKMMDGKH OKOMBFEIPHN(TKey LOHIKDGDMPP, [Optional] HPPHLHFLMDP? OPJHONAPMGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x244DEC0", Offset = "0x244CEC0", VA = "0x18244DEC0")]
		public void ONOLAONKGNC(TKey LOHIKDGDMPP, Action<JJAEKMMDGKH> OKCPFPFJOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x22A6980", Offset = "0x22A5980", VA = "0x1822A6980")]
		public T ONOLAONKGNC<T>(TKey LOHIKDGDMPP, Func<JJAEKMMDGKH, T> KMHHEENKEHH)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x22A67C0", Offset = "0x22A57C0", VA = "0x1822A67C0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KEMGKPCGAHB<>))]
		public Task<T> GIOJHBKCGPO<T>(TKey LOHIKDGDMPP, Func<JJAEKMMDGKH, Task<T>> KMHHEENKEHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x244DB70", Offset = "0x244CB70", VA = "0x18244DB70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class PKAEAIIGJDB : IEnumerable<(TKey, List<TKey>, NAPCOPMAIGI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NAPCOPMAIGI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private (TKey key, List<TKey> path, NAPCOPMAIGI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public MNKIABAIHBN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private IEnumerator<(TKey key, List<TKey> path, NAPCOPMAIGI timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private (TKey key, List<TKey> path, NAPCOPMAIGI timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private (TKey, List<TKey>, NAPCOPMAIGI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x20627B0", Offset = "0x20617B0", VA = "0x1820627B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NAPCOPMAIGI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2062820", Offset = "0x2061820", VA = "0x182062820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x20628E0", Offset = "0x20618E0", VA = "0x1820628E0")]
		[DebuggerHidden]
		public PKAEAIIGJDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2062880", Offset = "0x2061880", VA = "0x182062880", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x20623C0", Offset = "0x20613C0", VA = "0x1820623C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2062370", Offset = "0x2061370", VA = "0x182062370")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x20627E0", Offset = "0x20617E0", VA = "0x1820627E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x20626F0", Offset = "0x20616F0", VA = "0x1820626F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NAPCOPMAIGI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x12E63C0", Offset = "0x12E53C0", VA = "0x1812E63C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class JHEAPIGGNJA : IEnumerable<(TKey, List<TKey>, NAPCOPMAIGI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NAPCOPMAIGI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private (TKey key, List<TKey> path, NAPCOPMAIGI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private JJAEKMMDGKH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JJAEKMMDGKH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public MNKIABAIHBN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private IEnumerator<JJAEKMMDGKH> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private JJAEKMMDGKH <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private IEnumerator<(TKey key, List<TKey> path, NAPCOPMAIGI timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private (TKey key, List<TKey> path, NAPCOPMAIGI timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private (TKey, List<TKey>, NAPCOPMAIGI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x20627B0", Offset = "0x20617B0", VA = "0x1820627B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NAPCOPMAIGI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2447EB0", Offset = "0x2446EB0", VA = "0x182447EB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x20628E0", Offset = "0x20618E0", VA = "0x1820628E0")]
		[DebuggerHidden]
		public JHEAPIGGNJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2447F10", Offset = "0x2446F10", VA = "0x182447F10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2447750", Offset = "0x2446750", VA = "0x182447750", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x24476F0", Offset = "0x24466F0", VA = "0x1824476F0")]
		private void MHEJAKKMIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2447690", Offset = "0x2446690", VA = "0x182447690")]
		private void CAIKJCDFNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2447E70", Offset = "0x2446E70", VA = "0x182447E70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2447D60", Offset = "0x2446D60", VA = "0x182447D60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NAPCOPMAIGI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2447E40", Offset = "0x2446E40", VA = "0x182447E40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Action<TKey, NAPCOPMAIGI, HPPHLHFLMDP> ELGKLHOFNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Action<TKey, NAPCOPMAIGI, HPPHLHFLMDP> COECOKAHNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Action<MNKIABAIHBN<TKey>, HPPHLHFLMDP> IKDOKIHPGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private const string ICPNEHFNOLJ = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly JJAEKMMDGKH IBFAKIGHGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool NBJIGGJMNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int IHHIEOJOKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly Stopwatch HFJHLAPGKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly int JGOAMFJKANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string MEEHAFJNHCI;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public JJAEKMMDGKH NJAAOIEKBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	public string NNBHPGJONHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x97E580", Offset = "0x97D580", VA = "0x18097E580")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x272F770", Offset = "0x272E770", VA = "0x18272F770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public long PIGHPNJIFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x272F9C0", Offset = "0x272E9C0", VA = "0x18272F9C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int ELNKMIJGPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x272F720", Offset = "0x272E720", VA = "0x18272F720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x272FA80", Offset = "0x272EA80", VA = "0x18272FA80")]
	public MNKIABAIHBN(TKey MDOGAHANDOH, HPPHLHFLMDP CGJPMMKJEHF, [Optional] int? MMKHGOGGNPJ, [Optional][CanBeNull] Stopwatch HFJHLAPGKCO, [Optional] Action<TKey, NAPCOPMAIGI, HPPHLHFLMDP> ELGKLHOFNAE, [Optional] Action<TKey, NAPCOPMAIGI, HPPHLHFLMDP> COECOKAHNCM, [Optional] Action<MNKIABAIHBN<TKey>, HPPHLHFLMDP> IKDOKIHPGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x272F7D0", Offset = "0x272E7D0", VA = "0x18272F7D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x272F750", Offset = "0x272E750", VA = "0x18272F750")]
	public void AIBFNNGIPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x272FA60", Offset = "0x272EA60", VA = "0x18272FA60")]
	public void OELFAFCKHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x272F860", Offset = "0x272E860", VA = "0x18272F860")]
	[IteratorStateMachine(typeof(MNKIABAIHBN<>.PKAEAIIGJDB))]
	public IEnumerable<(TKey, List<TKey>, NAPCOPMAIGI)> FKHEDMCCMCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x272F8F0", Offset = "0x272E8F0", VA = "0x18272F8F0")]
	[IteratorStateMachine(typeof(MNKIABAIHBN<>.JHEAPIGGNJA))]
	private IEnumerable<(TKey, List<TKey>, NAPCOPMAIGI)> FKHEDMCCMCA(List<TKey> CDLBCMHHGDO, JJAEKMMDGKH MAPNFCDGNLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x272F9E0", Offset = "0x272E9E0", VA = "0x18272F9E0")]
	private (long, int) LOOCGAFGPFP()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class FHBCAKFNCNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<byte, CMNHPCEGMEP> KNGGKNFBKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly NPIHINIPENO<CMNHPCEGMEP> CJKOGKJMNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly bool MKEFGHJNHLJ;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CMNHPCEGMEP AGIMCNFKJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector2 OMMMCOCFKGP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x11BDFB0", Offset = "0x11BCFB0", VA = "0x1811BDFB0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1034720", Offset = "0x1033720", VA = "0x181034720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 CAOGHAEGLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF520", Offset = "0x2BDE520", VA = "0x182BDF520")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA2BFC0", Offset = "0xA2AFC0", VA = "0x180A2BFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector2 JDLAOMACELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x717F660", Offset = "0x717E660", VA = "0x18717F660")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xF342A0", Offset = "0xF332A0", VA = "0x180F342A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int NMOOPOACBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8B0", Offset = "0xA1D8B0", VA = "0x180A1E8B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA49D20", Offset = "0xA48D20", VA = "0x180A49D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x717FC10", Offset = "0x717EC10", VA = "0x18717FC10")]
	public FHBCAKFNCNM(Bounds OICJPLHGHEL, Vector2[] GIJFANFEFJA, int FJILALKMPPM, byte PDAGAKEPNHP, float DKFBADJECGO = 0f, [Optional] NPIHINIPENO<CMNHPCEGMEP> CJKOGKJMNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x717F9B0", Offset = "0x717E9B0", VA = "0x18717F9B0")]
	public CMNHPCEGMEP LDAKJKMLNIC(byte CCELBNKPBGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x717F870", Offset = "0x717E870", VA = "0x18717F870")]
	public void FDFPAACIGCN(Vector3 NKMKMKDMOMJ, float FGPCLCMFDKA, float BAFMDAKGILE, ref List<byte> GMGNEFPDIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x717F990", Offset = "0x717E990", VA = "0x18717F990")]
	public void KCNIAIIJLAH(CMNHPCEGMEP.FLCICMAFHLJ AIBCGCPGBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x717F5B0", Offset = "0x717E5B0", VA = "0x18717F5B0")]
	public static int BOIBIEGONPH(Vector2[] GIJFANFEFJA, int FJILALKMPPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x717F6E0", Offset = "0x717E6E0", VA = "0x18717F6E0")]
	private CMNHPCEGMEP ECBOHBGJNIH(byte CCELBNKPBGB, CMNHPCEGMEP.JMHHJEPFDMO BIGCBHPCAMA, CMNHPCEGMEP DJAGPEDCGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x717F1D0", Offset = "0x717E1D0", VA = "0x18717F1D0")]
	private void BIEKCBCECPO(CMNHPCEGMEP DJAGPEDCGHG, Vector2[] GIJFANFEFJA, int KDCIJAPGFIC, int PAPKLIEFJJN, int BJBLGDCKHKP, int DCIKNPGEOLB, float DKFBADJECGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x717FA10", Offset = "0x717EA10", VA = "0x18717FA10")]
	private void OHLMPJPPGJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x717F680", Offset = "0x717E680", VA = "0x18717F680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x717F940", Offset = "0x717E940", VA = "0x18717F940", Slot = "1")]
	~FHBCAKFNCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class CMNHPCEGMEP
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum JMHHJEPFDMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public enum FLCICMAFHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte FLJAKEAGLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3 FFPNGLKMLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3 FALJKMDLBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 LJNEEKJCJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 HCIKONKMJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public JMHHJEPFDMO HOPPCKAFOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public CMNHPCEGMEP HHNIJBILDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public List<CMNHPCEGMEP> APIIECKKJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool JHKMFIPEBJI;

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x717E840", Offset = "0x717D840", VA = "0x18717E840")]
	public CMNHPCEGMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x717E7E0", Offset = "0x717D7E0", VA = "0x18717E7E0")]
	public CMNHPCEGMEP(byte IACOMDKJFAL, JMHHJEPFDMO BIGCBHPCAMA, CMNHPCEGMEP DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x717E720", Offset = "0x717D720", VA = "0x18717E720")]
	public void MDHEGCDPHGI(CMNHPCEGMEP IGJGLIJGINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public void KCNIAIIJLAH(int JFOIOIHLKHH, FLCICMAFHLJ AIBCGCPGBHN, int IAKJCAAOEIB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x717E3F0", Offset = "0x717D3F0", VA = "0x18717E3F0")]
	public void FDFPAACIGCN(List<byte> GMGNEFPDIPB, Vector3 NKMKMKDMOMJ, float FGPCLCMFDKA, float BAFMDAKGILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x717E650", Offset = "0x717D650", VA = "0x18717E650")]
	public bool IJBGIEMLPCN(Vector3 HNEGIGNBMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x717E620", Offset = "0x717D620", VA = "0x18717E620")]
	public bool FOELOOJICGD(Vector3 HNEGIGNBMJE, float GPNIHMFEIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x717E6A0", Offset = "0x717D6A0", VA = "0x18717E6A0")]
	public void LLEBBJIFEDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class NPIHINIPENO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly Stack<T> APMOKJFBGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<T> EFDJEGGDHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly int EEPFLHICADH;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int JMGLKAMNEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1690C30", Offset = "0x168FC30", VA = "0x181690C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int APJIIGMJGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xC01A90", Offset = "0xC00A90", VA = "0x180C01A90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A7E0", Offset = "0x2A797E0", VA = "0x182A7A7E0")]
	public static NPIHINIPENO<T> MDIFPPAONEH(int OENKBEGLEDJ = 0, int EEPFLHICADH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A640", Offset = "0x2A79640", VA = "0x182A7A640")]
	public static NPIHINIPENO<T> LFFPOFGHCEM(int OENKBEGLEDJ = 0, int EEPFLHICADH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AA40", Offset = "0x2A79A40", VA = "0x182A7AA40")]
	public NPIHINIPENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A8B0", Offset = "0x2A798B0", VA = "0x182A7A8B0")]
	public NPIHINIPENO(int OENKBEGLEDJ, int EEPFLHICADH = int.MaxValue, bool JBPMMJIHFEK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A530", Offset = "0x2A79530", VA = "0x182A7A530")]
	public T HKLNJDIFBOK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A400", Offset = "0x2A79400", VA = "0x182A7A400")]
	public void FMLBILFGLCO(T CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A710", Offset = "0x2A79710", VA = "0x182A7A710")]
	private void LGGFFIPMNIA(T CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A0C0", Offset = "0x2A790C0", VA = "0x182A7A0C0")]
	private void BCCMHCJKBDF(T CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A0E0", Offset = "0x2A790E0", VA = "0x182A7A0E0")]
	[Conditional("DEBUG_BUILD")]
	private void BGAKKFMOJDG(T GPLBPEBFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A4A0", Offset = "0x2A794A0", VA = "0x182A7A4A0")]
	[Conditional("DEBUG_BUILD")]
	private void HEMDKBDNAOI(T GPLBPEBFHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A170", Offset = "0x2A79170", VA = "0x182A7A170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A260", Offset = "0x2A79260", VA = "0x182A7A260")]
	private void EGKLPAECJNG(IEnumerable<T> LGIIOJHKOLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class ONDIJMJCBJO
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private enum OGEOGCNPKCE : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int HFGGAOHBKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private bool LHLHCKNFMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private OGEOGCNPKCE CILNOBBJOLD;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool OINHJLGKBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7181200", Offset = "0x7180200", VA = "0x187181200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool KNHHFCGLAPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x71811F0", Offset = "0x71801F0", VA = "0x1871811F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7181EE0", Offset = "0x7180EE0", VA = "0x187181EE0")]
	public ONDIJMJCBJO(bool LHLHCKNFMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7181890", Offset = "0x7180890", VA = "0x187181890")]
	public void PALJBLOPPHA(object EOHGDDIECBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x71810E0", Offset = "0x71800E0", VA = "0x1871810E0")]
	public void DFBELEFGBLA(int CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7181060", Offset = "0x7180060", VA = "0x187181060")]
	public void AKPBEIHABHC(uint IJGDOPEJJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7181630", Offset = "0x7180630", VA = "0x187181630")]
	public void LFHFKNAAGGO(bool EGMKNKLKFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7181650", Offset = "0x7180650", VA = "0x187181650")]
	public void LNIIAAHOHJA(long JHMGJHFONNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x71815F0", Offset = "0x71805F0", VA = "0x1871815F0")]
	public void KNHGOJJJNCE(ulong MPGICIIEBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7181690", Offset = "0x7180690", VA = "0x187181690")]
	public void MFPDPNGKKKH(string OBCOBGBCLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7181560", Offset = "0x7180560", VA = "0x187181560")]
	public void KHOANCEKPLD(Enum PJPDEBBCODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7181770", Offset = "0x7180770", VA = "0x187181770")]
	public void OKPFLONLMMP(IList BHINNEMAJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3371320", Offset = "0x3370320", VA = "0x183371320")]
	public void BFHKIENCPOG<T, U>(Dictionary<T, U> PCAAFKBKPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7181210", Offset = "0x7180210", VA = "0x187181210")]
	private void KEJBPEKBAJA(IDictionary PCAAFKBKPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7181180", Offset = "0x7180180", VA = "0x187181180")]
	public int ECMLOMMFJBF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7181700", Offset = "0x7180700", VA = "0x187181700")]
	public short NCEIFDGLHDF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7181ED0", Offset = "0x7180ED0", VA = "0x187181ED0")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x7181070", Offset = "0x7180070", VA = "0x187181070")]
	private void BCKBAALAMEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface BLJCAPOPLNO
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class ResourcePrefabReference<T> : BLJCAPOPLNO where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x269AE80", Offset = "0x2699E80", VA = "0x18269AE80", Slot = "4")]
		public virtual T KKPOLKCBBEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class NCIMMGBAJMN<T> : IEnumerable<NCIMMGBAJMN<T>.BBFKDPJOCOG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public struct BBFKDPJOCOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public T CKDFGEALFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int CCELBNKPBGB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class KPEMDACDPII : IEnumerator<BBFKDPJOCOG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NCIMMGBAJMN<T> HIKFPKGBIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private int CCELBNKPBGB;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xC471A0", Offset = "0xC461A0", VA = "0x180C471A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public BBFKDPJOCOG LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x30E4AB0", Offset = "0x30E3AB0", VA = "0x1830E4AB0", Slot = "4")]
			get
			{
				return default(BBFKDPJOCOG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D35160", Offset = "0x2D34160", VA = "0x182D35160")]
		public KPEMDACDPII(NCIMMGBAJMN<T> HIKFPKGBIMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x30E48F0", Offset = "0x30E38F0", VA = "0x1830E48F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA70", Offset = "0x9ADA70", VA = "0x1809AEA70", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA8F430", Offset = "0xA8E430", VA = "0x180A8F430", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private struct CEEMFPPOJHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public bool FOFFDFNDHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public T CKDFGEALFAK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private const int LAGKGIMGKIP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly Dictionary<T, int> JJJLIPGLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private CEEMFPPOJHE[] AKBCEPACPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int PCHEPPEBAGC;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int FMOONLKCIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xD76220", Offset = "0xD75220", VA = "0x180D76220")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x11BE2F0", Offset = "0x11BD2F0", VA = "0x1811BE2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xBFE320", Offset = "0xBFD320", VA = "0x180BFE320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x297E240", Offset = "0x297D240", VA = "0x18297E240")]
	public NCIMMGBAJMN(int OENKBEGLEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x297DA70", Offset = "0x297CA70", VA = "0x18297DA70")]
	public NCIMMGBAJMN(BBFKDPJOCOG[] BAJKBGFGOKG, bool EOMBCPNFAAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x297C880", Offset = "0x297B880", VA = "0x18297C880")]
	public int DAFGBGPJFOE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x297D320", Offset = "0x297C320", VA = "0x18297D320")]
	private int NFPCMOCLHDF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x297D050", Offset = "0x297C050", VA = "0x18297D050", Slot = "6")]
	protected virtual uint MOIIGNIELEL(uint HFGGAOHBKDG, T CKDFGEALFAK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x297C790", Offset = "0x297B790", VA = "0x18297C790")]
	public bool AHIJJJJOMOF(T CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x297D0F0", Offset = "0x297C0F0", VA = "0x18297D0F0")]
	public bool NDNNHJDFBIN(int CCELBNKPBGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x297CF30", Offset = "0x297BF30", VA = "0x18297CF30")]
	public bool KAKGJPJGEDI(Func<T, bool> CECBKJKJGNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x297C820", Offset = "0x297B820", VA = "0x18297C820")]
	public int BIIIAPGOMOG(T CKDFGEALFAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x297C640", Offset = "0x297B640", VA = "0x18297C640")]
	public T ACFOFJDLAHB(int CCELBNKPBGB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x297D970", Offset = "0x297C970", VA = "0x18297D970")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x297D510", Offset = "0x297C510", VA = "0x18297D510")]
	public bool NNGGEKFJMHE(T CKDFGEALFAK, bool OEAOMMELDLL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x297D780", Offset = "0x297C780", VA = "0x18297D780")]
	public bool NNGGEKFJMHE(T CKDFGEALFAK, int CCELBNKPBGB, bool OEAOMMELDLL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x297C8F0", Offset = "0x297B8F0", VA = "0x18297C8F0")]
	public bool DNDEJFPIDIA(T CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x297D000", Offset = "0x297C000", VA = "0x18297D000")]
	public bool KPMKGKJAOFN(int CCELBNKPBGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x297CAE0", Offset = "0x297BAE0", VA = "0x18297CAE0")]
	private void HJBAJMFKKCB(int CCELBNKPBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x297CBD0", Offset = "0x297BBD0", VA = "0x18297CBD0")]
	public BBFKDPJOCOG[] JDDMHIOJJOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x297C6C0", Offset = "0x297B6C0", VA = "0x18297C6C0")]
	private int ADODGAFGHMI(int PDAGAKEPNHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x297D9F0", Offset = "0x297C9F0", VA = "0x18297D9F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x297D9F0", Offset = "0x297C9F0", VA = "0x18297D9F0", Slot = "4")]
	private IEnumerator<BBFKDPJOCOG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
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
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x7182110", Offset = "0x7181110", VA = "0x187182110")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x71823A0", Offset = "0x71813A0", VA = "0x1871823A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x71822D0", Offset = "0x71812D0", VA = "0x1871822D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x71824F0", Offset = "0x71814F0", VA = "0x1871824F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x7182080", Offset = "0x7181080", VA = "0x187182080")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x7182310", Offset = "0x7181310", VA = "0x187182310")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x7182240", Offset = "0x7181240", VA = "0x187182240")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7182020", Offset = "0x7181020", VA = "0x187182020")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GLDMDPEBAMM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int OENKBEGLEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private int PFJFOGJPBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private List<T> DLHPGJHCOIO;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1690C30", Offset = "0x168FC30", VA = "0x181690C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T MIOMIFPCBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B2D0", Offset = "0x2A4A2D0", VA = "0x182A4B2D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T MKCOOFGDOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B410", Offset = "0x2A4A410", VA = "0x182A4B410")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T CLHGIAHNMGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2A4B3B0", Offset = "0x2A4A3B0", VA = "0x182A4B3B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B540", Offset = "0x2A4A540", VA = "0x182A4B540")]
	public GLDMDPEBAMM(int OENKBEGLEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A4AFF0", Offset = "0x2A49FF0", VA = "0x182A4AFF0")]
	public void AMLBOIMHPGF(T CKEOFMNIMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B500", Offset = "0x2A4A500", VA = "0x182A4B500")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B1A0", Offset = "0x2A4A1A0", VA = "0x182A4B1A0")]
	public void FBCCBJEIJEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B4B0", Offset = "0x2A4A4B0", VA = "0x182A4B4B0")]
	public void PPFOCFNCHPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B240", Offset = "0x2A4A240", VA = "0x182A4B240")]
	public void FDMBCJNIJHL()
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
		public struct IBDLHBPMPKO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private readonly List<Component> BHINNEMAJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private readonly bool OGBHNDALLII;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0xF26520", Offset = "0xF25520", VA = "0x180F26520")]
			public IBDLHBPMPKO(List<Component> BHINNEMAJAD, bool OGBHNDALLII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x1573860", Offset = "0x1572860", VA = "0x181573860")]
			public NDEDMDMBBFG<T> EFCEFGGNIIL()
			{
				return default(NDEDMDMBBFG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x15738D0", Offset = "0x15728D0", VA = "0x1815738D0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x15738D0", Offset = "0x15728D0", VA = "0x1815738D0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public struct NDEDMDMBBFG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private readonly List<Component> BHINNEMAJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private readonly bool OGBHNDALLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int CCELBNKPBGB;

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public T LMEBIHANEPB
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x4B22340", Offset = "0x4B21340", VA = "0x184B22340", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x4B222D0", Offset = "0x4B212D0", VA = "0x184B222D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x4B22310", Offset = "0x4B21310", VA = "0x184B22310")]
			public NDEDMDMBBFG(List<Component> BHINNEMAJAD, bool OGBHNDALLII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x4B22200", Offset = "0x4B21200", VA = "0x184B22200", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x4B22210", Offset = "0x4B21210", VA = "0x184B22210", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x2184AE0", Offset = "0x2183AE0", VA = "0x182184AE0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x7184280", Offset = "0x7183280", VA = "0x187184280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7184240", Offset = "0x7183240", VA = "0x187184240")]
		public ToolHierarchyCache(GameObject AMMCILJDEFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7183F70", Offset = "0x7182F70", VA = "0x187183F70")]
		private void LLEBBJIFEDK(GameObject AMMCILJDEFM, bool HNGHLFFJCGK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x71840E0", Offset = "0x71830E0", VA = "0x1871840E0")]
		public static void LLEBBJIFEDK(GameObject AMMCILJDEFM, ref ToolHierarchyCache MJNADKLHKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x71838B0", Offset = "0x71828B0", VA = "0x1871838B0")]
		public void BBOHIDNIJHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7184170", Offset = "0x7183170", VA = "0x187184170")]
		public void OMIDDMFADKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2E55FD0", Offset = "0x2E54FD0", VA = "0x182E55FD0")]
		public void EFGHIPPLGIJ<T>(Action<T> OKCPFPFJOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7183A50", Offset = "0x7182A50", VA = "0x187183A50")]
		public Component EHDKECJHHDH(Type DPPJBLOOGOO, bool OGBHNDALLII = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x2E56260", Offset = "0x2E55260", VA = "0x182E56260")]
		public T EHDKECJHHDH<T>(bool OGBHNDALLII = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x71839D0", Offset = "0x71829D0", VA = "0x1871839D0")]
		public IBDLHBPMPKO<Component> EBLHNMDJBHO(Type DPPJBLOOGOO, bool OGBHNDALLII = false)
		{
			return default(IBDLHBPMPKO<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2E55F00", Offset = "0x2E54F00", VA = "0x182E55F00")]
		public IBDLHBPMPKO<T> EBLHNMDJBHO<T>(bool OGBHNDALLII = false) where T : class
		{
			return default(IBDLHBPMPKO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7183BA0", Offset = "0x7182BA0", VA = "0x187183BA0")]
		public List<Component> GEPFHBDOKGA(Type DPPJBLOOGOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7183B20", Offset = "0x7182B20", VA = "0x187183B20", Slot = "4")]
		public bool Equals(ToolHierarchyCache FKPADFHIFHA, ToolHierarchyCache NAFGCLHKJEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7183EF0", Offset = "0x7182EF0", VA = "0x187183EF0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache EOHGDDIECBJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class KEENIHMPCCJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Dictionary<int, T> NAHIDMOBGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private T NFGCOPAIHMH;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public virtual T AOBIAFGKGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x85E990", Offset = "0x85D990", VA = "0x18085E990", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool NGCDBIEGIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x3538BD0", Offset = "0x3537BD0", VA = "0x183538BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3538DB0", Offset = "0x3537DB0", VA = "0x183538DB0")]
	public bool EMJBIEFIIMD(T CKDFGEALFAK, int FGJNCOCMMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x23CA760", Offset = "0x23C9760", VA = "0x1823CA760")]
	public bool EGPLDBHNAGL(int FGJNCOCMMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x35389D0", Offset = "0x35379D0", VA = "0x1835389D0")]
	public T AHOIBBFGHND(int EPFPHJLLOEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3538EA0", Offset = "0x3537EA0", VA = "0x183538EA0")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x3538D20", Offset = "0x3537D20", VA = "0x183538D20")]
	private bool EABOJBAHHON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3538E70", Offset = "0x3537E70", VA = "0x183538E70")]
	public bool JLLAOJKGHMF(int FGJNCOCMMCF, out T CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x3538F00", Offset = "0x3537F00", VA = "0x183538F00")]
	public KEENIHMPCCJ()
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
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x91B190", Offset = "0x91A190", VA = "0x18091B190")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public T this[int KJPGMJFNNHE, int GNDBEEGAOAG]
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x40D28C0", Offset = "0x40D18C0", VA = "0x1840D28C0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x40D2960", Offset = "0x40D1960", VA = "0x1840D2960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x40D2830", Offset = "0x40D1830", VA = "0x1840D2830")]
		public Array2D(uint CAFDPIOMONE, uint LGDEBCOFIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x40D27B0", Offset = "0x40D17B0", VA = "0x1840D27B0")]
		public void PPNJFNMKMCA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x717CB20", Offset = "0x717BB20", VA = "0x18717CB20")]
		public Array2DVector3(uint CAFDPIOMONE, uint LGDEBCOFIOG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public abstract class DIFKIMJIMBB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class EAMDBJFAPPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public TNode FKGCCPKFEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public TNode DJAGPEDCGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public GKNGDBONLFI CPJMENEJDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public List<GKNGDBONLFI> LHHPGALDOGD;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public EAMDBJFAPPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal struct GKNGDBONLFI : IComparable<GKNGDBONLFI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int FGJNCOCMMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public TClaimant LFJENLEDBOA;

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xFDAA40", Offset = "0xFD9A40", VA = "0x180FDAA40")]
		public GKNGDBONLFI(int FGJNCOCMMCF, TClaimant LFJENLEDBOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2A431B0", Offset = "0x2A421B0", VA = "0x182A431B0")]
		public bool BCAEFDNLLCG(in GKNGDBONLFI BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2A431A0", Offset = "0x2A421A0", VA = "0x182A431A0")]
		public bool ACOKLMJAOHA(in GKNGDBONLFI BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2A43210", Offset = "0x2A42210", VA = "0x182A43210", Slot = "4")]
		public int CompareTo(GKNGDBONLFI BKLMLPFOMCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2A43220", Offset = "0x2A42220", VA = "0x182A43220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum EBPCMJKHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class GBKJMGKDLJC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public DIFKIMJIMBB<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2060080", Offset = "0x205F080", VA = "0x182060080")]
		[DebuggerHidden]
		public GBKJMGKDLJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3A84300", Offset = "0x3A83300", VA = "0x183A84300", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x3A844D0", Offset = "0x3A834D0", VA = "0x183A844D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x3A843F0", Offset = "0x3A833F0", VA = "0x183A843F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x21837C0", Offset = "0x21827C0", VA = "0x1821837C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly NPIHINIPENO<EAMDBJFAPPJ> KILKAHBJAAD;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly NPIHINIPENO<List<GKNGDBONLFI>> PLFGHBJCMMD;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int ABKBAOGEPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	internal readonly Dictionary<TClaimant, TNode> LBIFENMDOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	internal readonly Dictionary<TNode, EAMDBJFAPPJ> COIINPLBFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private EBPCMJKHFAH LPLFJNECDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FGBAEAHBLGF(TNode IKGBLMLJFLF);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HJADBICGEOM(TNode IKGBLMLJFLF, TClaimant GCMFOKBHKJP, TClaimant BEOFKOBHAOI);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7160", Offset = "0x2BA6160", VA = "0x182BA7160")]
	public DIFKIMJIMBB(EBPCMJKHFAH LPLFJNECDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6670", Offset = "0x2BA5670", VA = "0x182BA6670")]
	public void GFBOCGDHPOL(TNode IKGBLMLJFLF, TNode GFJHNOHABFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6DE0", Offset = "0x2BA5DE0", VA = "0x182BA6DE0")]
	public void NIDCEJNKKFA(TClaimant LFJENLEDBOA, TNode JJFGFJMNBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2BA62B0", Offset = "0x2BA52B0", VA = "0x182BA62B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2BA65D0", Offset = "0x2BA55D0", VA = "0x182BA65D0")]
	private void FLLGLDBHLCG(TClaimant LFJENLEDBOA, TNode JDBEPDODOPB, TNode JJFGFJMNBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA68B0", Offset = "0x2BA58B0", VA = "0x182BA68B0")]
	private int IDGMGENGJKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6B20", Offset = "0x2BA5B20", VA = "0x182BA6B20")]
	private void KCNPBLGCMEK(TClaimant LFJENLEDBOA, TNode PHJOLDBPJKO, TNode MCABOIDDKCM, int MPLMHILLCBI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5FC0", Offset = "0x2BA4FC0", VA = "0x182BA5FC0")]
	private void DGMCOHPMIOP(GKNGDBONLFI FAEAMNGEOKG, EAMDBJFAPPJ HIIBLJABEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6050", Offset = "0x2BA5050", VA = "0x182BA6050")]
	private void DJNIGJHEOKE(TClaimant LFJENLEDBOA, TNode PHJOLDBPJKO, TNode MCABOIDDKCM, int MPLMHILLCBI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6910", Offset = "0x2BA5910", VA = "0x182BA6910")]
	private void IJNLOLAICPK(GKNGDBONLFI FAEAMNGEOKG, TNode IKGBLMLJFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6A20", Offset = "0x2BA5A20", VA = "0x182BA6A20")]
	private void IPKECMHHOND(GKNGDBONLFI FAEAMNGEOKG, EAMDBJFAPPJ HIIBLJABEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6EE0", Offset = "0x2BA5EE0", VA = "0x182BA6EE0")]
	private void NOCPHPKMMIM(EAMDBJFAPPJ HIIBLJABEPH, bool HCHDBOMDNGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5B20", Offset = "0x2BA4B20", VA = "0x182BA5B20")]
	private void BKGMPMMIOLB(EAMDBJFAPPJ HIIBLJABEPH, TNode GFJHNOHABFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5EF0", Offset = "0x2BA4EF0", VA = "0x182BA5EF0")]
	[IteratorStateMachine(typeof(DIFKIMJIMBB<, >.GBKJMGKDLJC))]
	private IEnumerable<TNode> BMKEFFAMPAI(TNode PHJOLDBPJKO, TNode MCABOIDDKCM, bool IICHGGPHEAD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6510", Offset = "0x2BA5510", VA = "0x182BA6510")]
	private EAMDBJFAPPJ EGCOJGFKMKK(TNode IKGBLMLJFLF, TNode DJAGPEDCGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5990", Offset = "0x2BA4990", VA = "0x182BA5990")]
	private EAMDBJFAPPJ AGADBCANNDM(TNode IKGBLMLJFLF, TNode DJAGPEDCGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x2BA66F0", Offset = "0x2BA56F0", VA = "0x182BA66F0")]
	private void GPGFCCAFLOP(EAMDBJFAPPJ HIIBLJABEPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class LCJPFJBLDDP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	protected struct JOEEBCCFHLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public T FNCIDNAOCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int GPOCBGFAAFK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly List<JOEEBCCFHLG> LGFGDGJHKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private T GGIGNAFNHKF;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xBFE320", Offset = "0xBFD320", VA = "0x180BFE320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2683A40", Offset = "0x2682A40", VA = "0x182683A40")]
	public bool KAKGJPJGEDI(T CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x26837A0", Offset = "0x26827A0", VA = "0x1826837A0")]
	public void AMLBOIMHPGF(T CKDFGEALFAK, int FGJNCOCMMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2683840", Offset = "0x2682840", VA = "0x182683840")]
	public bool DNDEJFPIDIA(T CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2683DF0", Offset = "0x2682DF0", VA = "0x182683DF0")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2683960", Offset = "0x2682960", VA = "0x182683960")]
	public T EIJLBAHLJBG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x26839D0", Offset = "0x26829D0", VA = "0x1826839D0")]
	public T EKAGJIHBDMH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2683C40", Offset = "0x2682C40", VA = "0x182683C40")]
	private void POODOOIDEJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2683E50", Offset = "0x2682E50", VA = "0x182683E50")]
	public LCJPFJBLDDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class BEFOIDGIAOD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private struct AKPENCMFHOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int GPOCBGFAAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public T FNCIDNAOCJJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly Dictionary<object, AKPENCMFHOO> NAHIDMOBGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly EqualityComparer<T> AEGOEMFJFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private T NFGCOPAIHMH;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public virtual T AOBIAFGKGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF540", Offset = "0x2BDE540", VA = "0x182BDF540", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x24DC980", Offset = "0x24DB980", VA = "0x1824DC980", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool NGCDBIEGIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2BDACB0", Offset = "0x2BD9CB0", VA = "0x182BDACB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public object EBJOCOOHKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x2BDED80", Offset = "0x2BDDD80", VA = "0x182BDED80")]
	public bool EMJBIEFIIMD(T CKDFGEALFAK, object FFKJLIDBALM, int FGJNCOCMMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x2BDEC10", Offset = "0x2BDDC10", VA = "0x182BDEC10")]
	public bool EGPLDBHNAGL(object FFKJLIDBALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFAB0", Offset = "0x2BDEAB0", VA = "0x182BDFAB0")]
	public bool JLLAOJKGHMF(object FFKJLIDBALM, out T CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFC70", Offset = "0x2BDEC70", VA = "0x182BDFC70")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x2BDB220", Offset = "0x2BDA220", VA = "0x182BDB220")]
	private bool EABOJBAHHON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFCA0", Offset = "0x2BDECA0", VA = "0x182BDFCA0")]
	public BEFOIDGIAOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class IJNGLKJHBNB
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x7180640", Offset = "0x717F640", VA = "0x187180640")]
	public static void PGGFEDBFPJK(FPCHIOCGOJB PMEFJLJOGPP, string EEFKHJOLMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
	public static void PGGFEDBFPJK(IEnumerable<object> OCCDCEPJMIK, string EEFKHJOLMID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class MKDBKONEEHM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private bool JHBFNCKBGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private Action OKCPFPFJOFL;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public static MKDBKONEEHM PHMLJPGJDGN
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x71809D0", Offset = "0x717F9D0", VA = "0x1871809D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool OLALHFPGCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x9127F0", Offset = "0x9117F0", VA = "0x1809127F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7180A50", Offset = "0x717FA50", VA = "0x187180A50")]
	public MKDBKONEEHM(Action OKCPFPFJOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x71809B0", Offset = "0x717F9B0", VA = "0x1871809B0")]
	public void DGCOAPBJKNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x71809B0", Offset = "0x717F9B0", VA = "0x1871809B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class BPKLICJEMKD : DPLHGKBKOHE
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x717D120", Offset = "0x717C120", VA = "0x18717D120")]
	public BPKLICJEMKD(UnityEngine.Object LINODIEDLFA)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
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
