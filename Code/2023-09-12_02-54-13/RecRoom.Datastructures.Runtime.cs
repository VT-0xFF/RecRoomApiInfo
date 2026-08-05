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
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9C1170", Offset = "0x9C0570", VA = "0x1809C1170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x182BB80", Offset = "0x182AF80", VA = "0x18182BB80")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2EE9A20", Offset = "0x2EE8E20", VA = "0x182EE9A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public virtual void KKAIGILNJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
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
	[NFOPPCFKCBN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x44C4FC0", Offset = "0x44C43C0", VA = "0x1844C4FC0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x44C3B00", Offset = "0x44C2F00", VA = "0x1844C3B00", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x44C5830", Offset = "0x44C4C30", VA = "0x1844C5830")]
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
	private sealed class DPFBHDGCAHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public DPFBHDGCAHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2E77070", Offset = "0x2E76470", VA = "0x182E77070")]
		internal int LHJCCMHLFLD(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[NFOPPCFKCBN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x92D0B0", Offset = "0x92C4B0", VA = "0x18092D0B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x92D0E0", Offset = "0x92C4E0", VA = "0x18092D0E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x92D000", Offset = "0x92C400", VA = "0x18092D000", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey PMMAAICOJOP]
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x92D060", Offset = "0x92C460", VA = "0x18092D060", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x92CF00", Offset = "0x92C300", VA = "0x18092CF00", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x92C990", Offset = "0x92BD90", VA = "0x18092C990", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x92C1B0", Offset = "0x92B5B0", VA = "0x18092C1B0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x92CD50", Offset = "0x92C150", VA = "0x18092CD50", Slot = "14")]
	protected virtual string PEPJNNMMHFH(TKeyVal FBDCILKGOIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x92BDD0", Offset = "0x92B1D0", VA = "0x18092BDD0", Slot = "4")]
	public bool ContainsKey(TKey PMMAAICOJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x92CDE0", Offset = "0x92C1E0", VA = "0x18092CDE0", Slot = "5")]
	public bool TryGetValue(TKey PMMAAICOJOP, out TVal AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x92BE00", Offset = "0x92B200", VA = "0x18092BE00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x92BE00", Offset = "0x92B200", VA = "0x18092BE00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x92CE10", Offset = "0x92C210", VA = "0x18092CE10")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MNAFPJLILMB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IGIBINIJHHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public IGIBINIJHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x29DFC20", Offset = "0x29DF020", VA = "0x1829DFC20")]
		internal bool DLGGKHPLCCD(HJGJDPGFLKA<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float AJJCDOKILCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float DLCILIFAFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<HJGJDPGFLKA<float, T>> PGJHEOJPLFD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OHADIIENBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F4A0", Offset = "0x2C0E8A0", VA = "0x182C0F4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FF50", Offset = "0x2C0F350", VA = "0x182C0FF50")]
	public MNAFPJLILMB(float OHCEBDPBEGB, float APCIGIDPLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FDC0", Offset = "0x2C0F1C0", VA = "0x182C0FDC0")]
	public bool OALAFBIKEMA(float OPPCDFFPFGD, T AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C0F860", Offset = "0x2C0EC60", VA = "0x182C0F860")]
	public IEnumerable<T> BFBFIPJGFBI(float OPPCDFFPFGD, [Optional] float? NFBJFIBNJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FF20", Offset = "0x2C0F320", VA = "0x182C0FF20")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C0FBA0", Offset = "0x2C0EFA0", VA = "0x182C0FBA0")]
	private void NLBLEHGLKNI(float OPPCDFFPFGD)
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

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x36A6300", Offset = "0x36A5700", VA = "0x1836A6300")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x36A6490", Offset = "0x36A5890", VA = "0x1836A6490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float NHIJNDLKKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9BA6A0", Offset = "0x9B9AA0", VA = "0x1809BA6A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B4A0", Offset = "0x3D1A8A0", VA = "0x183D1B4A0")]
	public T CDGHACMPKKJ(float NINFMGLENJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D1B6F0", Offset = "0x3D1AAF0", VA = "0x183D1B6F0")]
	public T FMOAKCBNCOI(float NINFMGLENJD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GHOMKHHNDGF(T CAOIKBDHEDK, T ELHFHDBGEMK, float NINFMGLENJD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51FD450", Offset = "0x51FC850", VA = "0x1851FD450", Slot = "4")]
	protected override float GHOMKHHNDGF(float CAOIKBDHEDK, float ELHFHDBGEMK, float NINFMGLENJD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7119F70", Offset = "0x7119370", VA = "0x187119F70")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xAB9F30", Offset = "0xAB9330", VA = "0x180AB9F30", Slot = "4")]
	protected override Vector3 GHOMKHHNDGF(Vector3 CAOIKBDHEDK, Vector3 ELHFHDBGEMK, float NINFMGLENJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x711DE90", Offset = "0x711D290", VA = "0x18711DE90")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7119040", Offset = "0x7118440", VA = "0x187119040", Slot = "4")]
	protected override Color GHOMKHHNDGF(Color CAOIKBDHEDK, Color ELHFHDBGEMK, float NINFMGLENJD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x71190A0", Offset = "0x71184A0", VA = "0x1871190A0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NCLEAKDEAAG
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2401B40", Offset = "0x2400F40", VA = "0x182401B40")]
	public static HJGJDPGFLKA<T1, T2> DEDAFMGEJMH<T1, T2>(T1 NBHAPEJDMKJ, T2 OBIIAGDEBJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2401BB0", Offset = "0x2400FB0", VA = "0x182401BB0")]
	public static BPLEAKIILAP<T1, T2, T3> DEDAFMGEJMH<T1, T2, T3>(T1 NBHAPEJDMKJ, T2 OBIIAGDEBJC, T3 MPNLBMMKFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x711B6A0", Offset = "0x711AAA0", VA = "0x18711B6A0")]
	internal static int FBDIOLHELHB(int OJCICPJLMLD, int JLHIGHAKIEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x711B6B0", Offset = "0x711AAB0", VA = "0x18711B6B0")]
	internal static int FBDIOLHELHB(int OJCICPJLMLD, int JLHIGHAKIEI, int BJGBBMCJOEA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HJGJDPGFLKA<T1, T2> : IComparable<HJGJDPGFLKA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T1 JPKKPOJFGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly T2 EGJPIGICJOP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C580", Offset = "0x2C0B980", VA = "0x182C0C580")]
	public HJGJDPGFLKA(T1 NBHAPEJDMKJ, T2 OBIIAGDEBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x20851E0", Offset = "0x20845E0", VA = "0x1820851E0", Slot = "4")]
	public int CompareTo(HJGJDPGFLKA<T1, T2> ICELKIGIKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2085610", Offset = "0x2084A10", VA = "0x182085610", Slot = "0")]
	public override bool Equals(object ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2085B60", Offset = "0x2084F60", VA = "0x182085B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2085FD0", Offset = "0x20853D0", VA = "0x182085FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BPLEAKIILAP<T1, T2, T3> : IComparable<BPLEAKIILAP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly T1 JPKKPOJFGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T2 EGJPIGICJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T3 KFLDEEGOJKE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x34DD8D0", Offset = "0x34DCCD0", VA = "0x1834DD8D0")]
	public BPLEAKIILAP(T1 NBHAPEJDMKJ, T2 OBIIAGDEBJC, T3 MPNLBMMKFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x34DD090", Offset = "0x34DC490", VA = "0x1834DD090", Slot = "4")]
	public int CompareTo(BPLEAKIILAP<T1, T2, T3> ICELKIGIKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x34DD3B0", Offset = "0x34DC7B0", VA = "0x1834DD3B0", Slot = "0")]
	public override bool Equals(object ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x34DD520", Offset = "0x34DC920", VA = "0x1834DD520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x34DD610", Offset = "0x34DCA10", VA = "0x1834DD610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NFOPPCFKCBN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x823850", Offset = "0x822C50", VA = "0x180823850")]
	public NFOPPCFKCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HashableScriptableObject : ScriptableObject, HJGPFLEMJGE, KDFFCBBDPNK, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8C40A0", Offset = "0x8C34A0", VA = "0x1808C40A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash LEMKICMKGLB);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9840D0", Offset = "0x9834D0", VA = "0x1809840D0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[FHGKKMHFEJI]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[FHGKKMHFEJI]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x711CF20", Offset = "0x711C320", VA = "0x18711CF20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x711CEE0", Offset = "0x711C2E0", VA = "0x18711CEE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x711CF60", Offset = "0x711C360", VA = "0x18711CF60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x711D110", Offset = "0x711C510", VA = "0x18711D110")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x711D080", Offset = "0x711C480", VA = "0x18711D080")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x985820", Offset = "0x984C20", VA = "0x180985820")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x985810", Offset = "0x984C10", VA = "0x180985810")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x711CEA0", Offset = "0x711C2A0", VA = "0x18711CEA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x711CFF0", Offset = "0x711C3F0", VA = "0x18711CFF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x711C8F0", Offset = "0x711BCF0", VA = "0x18711C8F0")]
	public void CopyBounds(SavedExtents ICELKIGIKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x711CE00", Offset = "0x711C200", VA = "0x18711CE00")]
	public void SetLocalSpaceBounds(Bounds LNJHCLOAELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x711C290", Offset = "0x711B690", VA = "0x18711C290")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x711CDF0", Offset = "0x711C1F0", VA = "0x18711CDF0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x711C9E0", Offset = "0x711BDE0", VA = "0x18711C9E0")]
	private void OOIDNAHGAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x711CBC0", Offset = "0x711BFC0", VA = "0x18711CBC0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x711C2B0", Offset = "0x711B6B0", VA = "0x18711C2B0")]
	public static void CalculateLocalBoundsFor(GameObject NNAKJIJAOJG, out Bounds LNJHCLOAELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x711C920", Offset = "0x711BD20", VA = "0x18711C920")]
	private static void FILNEKBLJJN(Bounds KBAEKPMBMFG, Color MLPEACFGKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x711CE20", Offset = "0x711C220", VA = "0x18711CE20")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class HCMPOAJCEDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct FBIDMCAICGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public T EKGBCCDIAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public float PIMAMNNFCBE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static float IIAMIHCLIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private List<T> IBOALJDFIIP;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const int FODIFJIJFAI = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private FBIDMCAICGK[] EACKPMFPNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int MAAPABDIAPI;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float KEGNDNJPJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xBDE2F0", Offset = "0xBDD6F0", VA = "0x180BDE2F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF4680", VA = "0x180BF5280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2075E50", Offset = "0x2075250", VA = "0x182075E50")]
	public HCMPOAJCEDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2075D50", Offset = "0x2075150", VA = "0x182075D50")]
	public HCMPOAJCEDD(int AJCINIIEJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x20758A0", Offset = "0x2074CA0", VA = "0x1820758A0")]
	public void NNFBEGDMHOD(float OPPCDFFPFGD, T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2075BB0", Offset = "0x2074FB0", VA = "0x182075BB0")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x20750D0", Offset = "0x20744D0", VA = "0x1820750D0")]
	public bool IPPNNANLBEG(float OFCMFJJGAGN, float FLGGJOKCCOM, out T AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2075290", Offset = "0x2074690", VA = "0x182075290")]
	public bool LHGCIKJBPMP(float OFCMFJJGAGN, float FLGGJOKCCOM, out T AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2075730", Offset = "0x2074B30", VA = "0x182075730")]
	public void LONODFELNMC(float OFCMFJJGAGN, float FLGGJOKCCOM, List<T> BCGCPPBLPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x20755B0", Offset = "0x20749B0", VA = "0x1820755B0")]
	private int LJNKKCPLHDE(int ENJNGJKOBJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2075860", Offset = "0x2074C60", VA = "0x182075860")]
	private void MHOECAJNLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MPAABODCMMC();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T CFPFGEHPDPO(T AGLCIEKHLEE, float NINFMGLENJD);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T PCPNMHEPPDC(T CAOIKBDHEDK, T ELHFHDBGEMK);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T DHBAIBMHDGP(T CAOIKBDHEDK, T ELHFHDBGEMK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NBJBKCLFECG : HCMPOAJCEDD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xE567C0", Offset = "0xE55BC0", VA = "0x180E567C0", Slot = "4")]
	protected override Vector3 MPAABODCMMC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x711B530", Offset = "0x711A930", VA = "0x18711B530", Slot = "5")]
	protected override Vector3 CFPFGEHPDPO(Vector3 AGLCIEKHLEE, float NINFMGLENJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x711B5E0", Offset = "0x711A9E0", VA = "0x18711B5E0", Slot = "6")]
	protected override Vector3 PCPNMHEPPDC(Vector3 CAOIKBDHEDK, Vector3 ELHFHDBGEMK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x711B570", Offset = "0x711A970", VA = "0x18711B570", Slot = "7")]
	protected override Vector3 DHBAIBMHDGP(Vector3 CAOIKBDHEDK, Vector3 ELHFHDBGEMK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x711B630", Offset = "0x711AA30", VA = "0x18711B630")]
	public NBJBKCLFECG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CGPNMNBMCKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable FNGGPKJOCFE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public CGPNMNBMCKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LGOGNNPPBFB : CHHHHGELJHF<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x711B430", Offset = "0x711A830", VA = "0x18711B430")]
	public LGOGNNPPBFB(int GLDHDJHPIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x711B3C0", Offset = "0x711A7C0", VA = "0x18711B3C0", Slot = "6")]
	protected override uint CAIIFOMAGCH(uint LEMKICMKGLB, string AGLCIEKHLEE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public class LDFFHHNOOFC<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private LDFFHHNOOFC<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9FC8D0", Offset = "0x9FBCD0", VA = "0x1809FC8D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x287FC10", Offset = "0x287F010", VA = "0x18287FC10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28811D0", Offset = "0x28805D0", VA = "0x1828811D0")]
		public Enumerator(LDFFHHNOOFC<T> BCGCPPBLPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x287ADE0", Offset = "0x287A1E0", VA = "0x18287ADE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x287D970", Offset = "0x287CD70", VA = "0x18287D970", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28799E0", Offset = "0x2878DE0", VA = "0x1828799E0")]
		private void EFIAMOFGKLO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] CKDPDEINCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ILIPJAOBBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int BOAEBANBENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int LJJHJABONIO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x233BD90", Offset = "0x233B190", VA = "0x18233BD90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x233BC10", Offset = "0x233B010", VA = "0x18233BC10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x233BE40", Offset = "0x233B240", VA = "0x18233BE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x233CEC0", Offset = "0x233C2C0", VA = "0x18233CEC0")]
	public LDFFHHNOOFC(int GLDHDJHPIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x233CC60", Offset = "0x233C060", VA = "0x18233CC60")]
	public void NNFBEGDMHOD(T NINFMGLENJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x233CD20", Offset = "0x233C120", VA = "0x18233CD20")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x233C380", Offset = "0x233B780", VA = "0x18233C380")]
	public void LEFJDJKDOOO(int FJFMKNIHPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x233C410", Offset = "0x233B810", VA = "0x18233C410")]
	public void LJOMJACBJIM(T[] EACKPMFPNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x233C9B0", Offset = "0x233BDB0", VA = "0x18233C9B0")]
	public Enumerator MHIEAIINAGJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x233CD40", Offset = "0x233C140", VA = "0x18233CD40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x233CD40", Offset = "0x233C140", VA = "0x18233CD40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x233C1A0", Offset = "0x233B5A0", VA = "0x18233C1A0")]
	private int KKFHAOFGNDB(int BNOAGGNAMKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x233CA00", Offset = "0x233BE00", VA = "0x18233CA00")]
	private int NIMDAENBILH(int BNOAGGNAMKG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BNPNOAIDOIK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BKCGICPPPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int MOKCPJCDBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int CLICPEBDAIA;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1D307B0", Offset = "0x1D2FBB0", VA = "0x181D307B0")]
	private BNPNOAIDOIK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IBCLJIKIJAL, int MGJIEOJANPK, int KPOKKOJBKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x34D2D50", Offset = "0x34D2150", VA = "0x1834D2D50")]
	public static BNPNOAIDOIK<T> NAILOIKCJEC()
	{
		return default(BNPNOAIDOIK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x34D15C0", Offset = "0x34D09C0", VA = "0x1834D15C0")]
	public (int, int, Task<T>) GGKODHPDJAK(int AKJBJOFNELL, [Optional] CancellationToken ODBDCIFDKPJ, double KEGCBGNJKBP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x34D29F0", Offset = "0x34D1DF0", VA = "0x1834D29F0")]
	public void HMINIFEODNE(int AKJBJOFNELL, int KPOKKOJBKDB, in T MOOEDNDCGLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LBGAEDKFOPM
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x711B370", Offset = "0x711A770", VA = "0x18711B370")]
	public static BNPNOAIDOIK<PNGLJAGHHDL> NAILOIKCJEC()
	{
		return default(BNPNOAIDOIK<PNGLJAGHHDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x711B2F0", Offset = "0x711A6F0", VA = "0x18711B2F0")]
	public static void HMINIFEODNE(this in BNPNOAIDOIK<PNGLJAGHHDL> ODBHDBFBMOB, int AKJBJOFNELL, int KPOKKOJBKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class IMGGOGIEJFC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> IKDBPEGOLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> BDHHHMDCAKI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1C906B0", Offset = "0x1C8FAB0", VA = "0x181C906B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool BAJNPCIAOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> BKNLAJAFHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2082650", Offset = "0x2081A50", VA = "0x182082650", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> EAIAEMNCFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x29F5290", Offset = "0x29F4690", VA = "0x1829F5290", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x29F5250", Offset = "0x29F4650", VA = "0x1829F5250", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x29F52F0", Offset = "0x29F46F0", VA = "0x1829F52F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x29F4CC0", Offset = "0x29F40C0", VA = "0x1829F4CC0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x29F4990", Offset = "0x29F3D90", VA = "0x1829F4990", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x29F50E0", Offset = "0x29F44E0", VA = "0x1829F50E0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x29F45C0", Offset = "0x29F39C0", VA = "0x1829F45C0", Slot = "9")]
	public void Add(TKey PMMAAICOJOP, TVal AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x29F4690", Offset = "0x29F3A90", VA = "0x1829F4690", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> CFHFBNLLHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x29F49F0", Offset = "0x29F3DF0", VA = "0x1829F49F0", Slot = "8")]
	public bool ContainsKey(TKey PMMAAICOJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x29F4A20", Offset = "0x29F3E20", VA = "0x1829F4A20", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x29F4FB0", Offset = "0x29F43B0", VA = "0x1829F4FB0", Slot = "10")]
	public bool Remove(TKey PMMAAICOJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x29F5010", Offset = "0x29F4410", VA = "0x1829F5010", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x29F5130", Offset = "0x29F4530", VA = "0x1829F5130", Slot = "11")]
	public bool TryGetValue(TKey PMMAAICOJOP, out TVal AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x29F4D80", Offset = "0x29F4180", VA = "0x1829F4D80", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x29F4AB0", Offset = "0x29F3EB0", VA = "0x1829F4AB0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EACKPMFPNLH, int LKNMOMDDHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x29F4950", Offset = "0x29F3D50", VA = "0x1829F4950")]
	public bool CLFAJBNDMHA(TVal PMMAAICOJOP, out TKey AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x29F4C20", Offset = "0x29F4020", VA = "0x1829F4C20")]
	private void EAEFMMMLDDB(TKey PMMAAICOJOP, TVal GBFJPNOAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x29F4F10", Offset = "0x29F4310", VA = "0x1829F4F10")]
	private void LKOEDNJKJKH(TKey PMMAAICOJOP, TVal GBFJPNOAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x29F4790", Offset = "0x29F3B90", VA = "0x1829F4790")]
	private bool CCEPPFKJGGC(TKey PMMAAICOJOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x29F5160", Offset = "0x29F4560", VA = "0x1829F5160")]
	public IMGGOGIEJFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class IIOCOHHCNJB<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> AGHGFPLOCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> FIONHDMDJNK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x29E90B0", Offset = "0x29E84B0", VA = "0x1829E90B0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x29E9050", Offset = "0x29E8450", VA = "0x1829E9050", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1314980", Offset = "0x1313D80", VA = "0x181314980")]
	public IIOCOHHCNJB(Func<Internal, External> AGHGFPLOCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x29E9000", Offset = "0x29E8400", VA = "0x1829E9000")]
	public IIOCOHHCNJB(IReadOnlyList<Internal> FIONHDMDJNK, Func<Internal, External> AGHGFPLOCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x29E8F90", Offset = "0x29E8390", VA = "0x1829E8F90", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x23DD780", Offset = "0x23DCB80", VA = "0x1823DD780", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FBCMANEJHMD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> MOELPAGDALG(TRequest OALKBFHLHKE, CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum MPMKKBLOPGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class HNNENNCKOOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float IMDHOCFGHIH = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan DCKBJCKJJPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int KECPHNIEHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public MPMKKBLOPGK POJLKOCJLKK;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly HNNENNCKOOO KCIIGNIKLNC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float BELDCHAGJHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2D236C0", Offset = "0x2D22AC0", VA = "0x182D236C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan KLKPICFOFFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D23730", Offset = "0x2D22B30", VA = "0x182D23730")]
		public HNNENNCKOOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct NOOMDAOFLGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest OALKBFHLHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken ODBDCIFDKPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> MBCLGDFFCMD;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B320", Offset = "0x2D8A720", VA = "0x182D8B320")]
		public NOOMDAOFLGO(TRequest OALKBFHLHKE, TaskCompletionSource<TResult> MBCLGDFFCMD, CancellationToken ODBDCIFDKPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JPDOFPLFAPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public FBCMANEJHMD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public JPDOFPLFAPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x24655D0", Offset = "0x24649D0", VA = "0x1824655D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MKCGHIJEJOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public FBCMANEJHMD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private NOOMDAOFLGO <req>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Task<TResult> <processTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TResult <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TResult <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private OperationCanceledException <oce>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public MKCGHIJEJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C08E50", Offset = "0x2C08250", VA = "0x182C08E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource FDMBNIPANPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<NOOMDAOFLGO> LFPKOOGDFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HNNENNCKOOO GJBHBADJDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly MOELPAGDALG DNDELHJPEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task DKAPKKIMDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int GAAEHDPFENB;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x13196B0", Offset = "0x1318AB0", VA = "0x1813196B0")]
	public FBCMANEJHMD(MOELPAGDALG DNDELHJPEFA, [Optional] HNNENNCKOOO GJBHBADJDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1318360", Offset = "0x1317760", VA = "0x181318360")]
	public Task<TResult> FMAKKNKIBNO(TRequest OALKBFHLHKE, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x13187C0", Offset = "0x1317BC0", VA = "0x1813187C0")]
	private void GGJJFLEANAI(NOOMDAOFLGO CBOPAIKFDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1318DF0", Offset = "0x13181F0", VA = "0x181318DF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FBCMANEJHMD<, >.JPDOFPLFAPP))]
	private Task ICIJNJMKBFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1317F10", Offset = "0x1317310", VA = "0x181317F10")]
	private NOOMDAOFLGO DDJLJKKHFJP()
	{
		return default(NOOMDAOFLGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1319090", Offset = "0x1318490", VA = "0x181319090")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FBCMANEJHMD<, >.MKCGHIJEJOF))]
	private Task NMENDJMBILN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x13189B0", Offset = "0x1317DB0", VA = "0x1813189B0")]
	private void HMDDLGGFHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1318170", Offset = "0x1317570", VA = "0x181318170", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2B6A300", Offset = "0x2B69700", VA = "0x182B6A300")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CDA0", Offset = "0x6C7C1A0", VA = "0x186C7CDA0")]
		public SerializedGuid(in Guid DDJMKPCJBFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x711D1A0", Offset = "0x711C5A0", VA = "0x18711D1A0")]
		public static SerializedGuid BCDNDNHIEEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x711D450", Offset = "0x711C850", VA = "0x18711D450")]
		public static SerializedGuid NEGBCPOAABA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x711D230", Offset = "0x711C630", VA = "0x18711D230")]
		public bool CGCNKCIPCIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CD70", Offset = "0x6C7C170", VA = "0x186C7CD70", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x711D4E0", Offset = "0x711C8E0", VA = "0x18711D4E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x711D2C0", Offset = "0x711C6C0", VA = "0x18711D2C0", Slot = "7")]
		public bool Equals(SerializedGuid ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x711D370", Offset = "0x711C770", VA = "0x18711D370", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CCC0", Offset = "0x6C7C0C0", VA = "0x186C7CCC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CB00", Offset = "0x6C7BF00", VA = "0x186C7CB00", Slot = "6")]
		public int CompareTo(SerializedGuid ICELKIGIKKP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MBKMBAJNJII : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type HLFIBIJCLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string BLNJNLFIGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool JFIMFMHJLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool IGKNFICEHNJ;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x711B4C0", Offset = "0x711A8C0", VA = "0x18711B4C0")]
	public MBKMBAJNJII(Type FAAKLOHPNJG, string MDFEBDEMPMO, bool EGNOMPAPDBE = false, bool FNOGPOLLDCJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class BIDMPFCKING<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly List<T> FIONHDMDJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private HashSet<T> EMNKKCOBDEI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1C906B0", Offset = "0x1C8FAB0", VA = "0x181C906B0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BAJNPCIAOLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8228B0", Offset = "0x821CB0", VA = "0x1808228B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2061CC0", Offset = "0x20610C0", VA = "0x182061CC0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2061CF0", Offset = "0x20610F0", VA = "0x182061CF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x20614A0", Offset = "0x20608A0", VA = "0x1820614A0", Slot = "11")]
	public void Add(T CFHFBNLLHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2061850", Offset = "0x2060C50", VA = "0x182061850")]
	public bool PLCLGNFCBMP(T CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2061B20", Offset = "0x2060F20", VA = "0x182061B20", Slot = "15")]
	public bool Remove(T CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2061560", Offset = "0x2060960", VA = "0x182061560", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2061BA0", Offset = "0x2060FA0", VA = "0x182061BA0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x20614D0", Offset = "0x20608D0", VA = "0x1820614D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1CA8B50", Offset = "0x1CA7F50", VA = "0x181CA8B50", Slot = "13")]
	public bool Contains(T CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2061530", Offset = "0x2060930", VA = "0x182061530", Slot = "14")]
	public void CopyTo(T[] EACKPMFPNLH, int LKNMOMDDHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x20615E0", Offset = "0x20609E0", VA = "0x1820615E0", Slot = "6")]
	public int IndexOf(T CFHFBNLLHPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2061610", Offset = "0x2060A10", VA = "0x182061610", Slot = "7")]
	public void Insert(int BNOAGGNAMKG, T CFHFBNLLHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x20618F0", Offset = "0x2060CF0", VA = "0x1820618F0", Slot = "8")]
	public void RemoveAt(int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2061BD0", Offset = "0x2060FD0", VA = "0x182061BD0")]
	public BIDMPFCKING()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PLMNICFJKMK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x711BD50", Offset = "0x711B150", VA = "0x18711BD50")]
	public PLMNICFJKMK(string FHDJIGKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CIINNODFFKK
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7118B70", Offset = "0x7117F70", VA = "0x187118B70")]
	[NotNull]
	public static byte[] KFMKBHOMEGE(this KDFFCBBDPNK KABFLJNPHKD, HashAlgorithmName FADELCPLFDE, byte[] IPAKNPNEDBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KDFFCBBDPNK
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash LEMKICMKGLB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HJGPFLEMJGE : KDFFCBBDPNK
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	[CanBeNull]
	byte[] ANKENFGNIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[CanBeNull]
	byte[] OAGHBLKIKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class HEKMIBAJKDE
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly ArrayPool<byte> PMJOGONJCMH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static bool FMNKEDIJDBE;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x711A950", Offset = "0x7119D50", VA = "0x18711A950")]
	public static void NBELMBEIGFA(this IncrementalHash IPPGHFCJFEL, [CanBeNull] GameObject NNAKJIJAOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2439E90", Offset = "0x2439290", VA = "0x182439E90")]
	public static void NBELMBEIGFA<T>(this IncrementalHash IPPGHFCJFEL, [CanBeNull] T EGEAFOFCJOI) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x24399B0", Offset = "0x2438DB0", VA = "0x1824399B0")]
	public static void HOKPIIDANCE<T>(this IncrementalHash IPPGHFCJFEL, [CanBeNull] T KABFLJNPHKD) where T : KDFFCBBDPNK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2439A40", Offset = "0x2438E40", VA = "0x182439A40")]
	public static void IKMBHJBPIIA<T>(this IncrementalHash IPPGHFCJFEL, [CanBeNull] IList<T> OEAOHEPAHKA) where T : KDFFCBBDPNK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x711A520", Offset = "0x7119920", VA = "0x18711A520")]
	private static bool JMNKLGHNAAN([CanBeNull] KDFFCBBDPNK KABFLJNPHKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x711A050", Offset = "0x7119450", VA = "0x18711A050")]
	public static void BGELMAEGHDL(this IncrementalHash LEMKICMKGLB, [CanBeNull] string GGHBKGGHKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x711A610", Offset = "0x7119A10", VA = "0x18711A610")]
	public static void MFGDADDBMAF(this IncrementalHash LEMKICMKGLB, long LHPIBJPBBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x711A350", Offset = "0x7119750", VA = "0x18711A350")]
	public static void INKEDPKDLMG(this IncrementalHash LEMKICMKGLB, int LMAOHFFCJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x711AC10", Offset = "0x711A010", VA = "0x18711AC10")]
	public static void PKEHIHNEMMB(this IncrementalHash LEMKICMKGLB, short CBDAINBHOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x711A7E0", Offset = "0x7119BE0", VA = "0x18711A7E0")]
	public static void MJMNFIIELJG(this IncrementalHash LEMKICMKGLB, byte LJBCLBEBAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x711AA40", Offset = "0x7119E40", VA = "0x18711AA40")]
	public static void PDFFDLNKAAN(this IncrementalHash LEMKICMKGLB, bool AFGDOJPGNPB, bool MHEEHDDGONJ = false, bool BPHMBFONBJB = false, bool KAFAPCPFNDO = false, bool CDFGMBJLLKK = false, bool MMGBBABCDGC = false, bool GJPGMIPDFDP = false, bool KBBNOBOEFCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2439F60", Offset = "0x2439360", VA = "0x182439F60")]
	public static void PGFPOADEAMI<T>(this IncrementalHash LEMKICMKGLB, T HIMOPIMKOMB) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x711A2F0", Offset = "0x71196F0", VA = "0x18711A2F0")]
	public static void FPICEJNEGEL(this IncrementalHash LEMKICMKGLB, float EFAHFAKBJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x711A210", Offset = "0x7119610", VA = "0x18711A210")]
	public static void EGKMOOALOLN(this IncrementalHash LEMKICMKGLB, ulong OLJAOOKGPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x711A5B0", Offset = "0x71199B0", VA = "0x18711A5B0")]
	public static void KEBMMGDKCKE(this IncrementalHash LEMKICMKGLB, uint BPEGEKKDCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x711A280", Offset = "0x7119680", VA = "0x18711A280")]
	public static void FPFNCLHHLIG(this IncrementalHash LEMKICMKGLB, ushort NGKAKAKBCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x711A0B0", Offset = "0x71194B0", VA = "0x18711A0B0")]
	public static void ECOPHIBKABM(this IncrementalHash LEMKICMKGLB, Vector3 MELJNADAGBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NOIHGMPHGBK
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x711BA60", Offset = "0x711AE60", VA = "0x18711BA60")]
	[NotNull]
	public static byte[] KFMKBHOMEGE(this HJGPFLEMJGE LELIICBCPFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x711B9F0", Offset = "0x711ADF0", VA = "0x18711B9F0")]
	[NotNull]
	public static byte[] KFMKBHOMEGE(this HJGPFLEMJGE LELIICBCPFL, HashAlgorithmName FADELCPLFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x711B6C0", Offset = "0x711AAC0", VA = "0x18711B6C0")]
	public static bool CLGPHIPGIMM([CanBeNull] this HJGPFLEMJGE LELIICBCPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x711B850", Offset = "0x711AC50", VA = "0x18711B850")]
	public static bool CLGPHIPGIMM([CanBeNull] this HJGPFLEMJGE LELIICBCPFL, out string FOMNCGOADBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x711BAD0", Offset = "0x711AED0", VA = "0x18711BAD0")]
	private static bool MILGEGABOIA([NotNull] HJGPFLEMJGE LELIICBCPFL, [CanBeNull] out byte[] JCFEMDPFAJI, [CanBeNull] out byte[] BBHLKDHLEHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class FLHLIFCBAAA<TTask, T> : IBBDJDIFPNE<T>, GLADGLPLHBG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BFFGMHKEHAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private sealed class <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public BFFGMHKEHAH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x19E2480", Offset = "0x19E1880", VA = "0x1819E2480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public FLHLIFCBAAA<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public BFFGMHKEHAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2D037B0", Offset = "0x2D02BB0", VA = "0x182D037B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(FLHLIFCBAAA<, >.BFFGMHKEHAH.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> FHGCFAHIPEN(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static bool MFNJJPMFHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Task<T> NOKNMHIKNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly CancellationTokenSource OCLAFKPHAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool IAEKIDJDAJF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task<T> JFAGMJGDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public KDCMFGDLEKL<T> BLNJFOLBIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8C8440", Offset = "0x8C7840", VA = "0x1808C8440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x380C730", Offset = "0x380BB30", VA = "0x18380C730")]
	static FLHLIFCBAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x380CA90", Offset = "0x380BE90", VA = "0x18380CA90")]
	protected FLHLIFCBAAA(TTask NOKNMHIKNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x380C320", Offset = "0x380B720", VA = "0x18380C320", Slot = "1")]
	~FLHLIFCBAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x380C2F0", Offset = "0x380B6F0", VA = "0x18380C2F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x380C390", Offset = "0x380B790", VA = "0x18380C390")]
	private void KAEENGGDABJ(bool GHKDBKMHPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T AFFBBJFKBOP(TTask EJCIAILMLCA);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void JICKEAMNCFL();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class ACMLFODONEB<T> : IBBDJDIFPNE<T>, GLADGLPLHBG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> JFAGMJGDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public KDCMFGDLEKL<T> BLNJFOLBIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x31379B0", Offset = "0x3136DB0", VA = "0x1831379B0")]
	public ACMLFODONEB(Exception ONGNPCCGCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GLADGLPLHBG : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IBBDJDIFPNE<T> : GLADGLPLHBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	[NotNull]
	Task<T> JFAGMJGDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	[NotNull]
	KDCMFGDLEKL<T> BLNJFOLBIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LJECFFGOFMC : ANGPEENPFED<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x711B480", Offset = "0x711A880", VA = "0x18711B480")]
	public LJECFFGOFMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class ANGPEENPFED<T> : IBBDJDIFPNE<T>, GLADGLPLHBG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task<T> JFAGMJGDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KDCMFGDLEKL<T> BLNJFOLBIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x30D3940", Offset = "0x30D2D40", VA = "0x1830D3940")]
	public ANGPEENPFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class CNCFPMNNGFM : CPMEPPENFLB<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class GKDLIOCPEJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action<CNCFPMNNGFM, EHKEPJIBENP> callback;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GKDLIOCPEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7119FB0", Offset = "0x71193B0", VA = "0x187119FB0")]
		internal void AHIAABCIMGO(CPMEPPENFLB<string> timer, EHKEPJIBENP log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7118EE0", Offset = "0x71182E0", VA = "0x187118EE0")]
	public CNCFPMNNGFM(EHKEPJIBENP IGCLICKKCHJ, [Optional] string EAECOJLBJDH, [Optional] int? EIKLGDCHFPJ, [Optional] Stopwatch EOFHIAKKIIN, [Optional] Action<string, KJFIDKHALEE, EHKEPJIBENP> ADIBOCMCHII, [Optional] Action<string, KJFIDKHALEE, EHKEPJIBENP> FCBKKKELNHP, [Optional] Action<CNCFPMNNGFM, EHKEPJIBENP> KOCBHCIBMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7118E00", Offset = "0x7118200", VA = "0x187118E00")]
	private static Action<CPMEPPENFLB<string>, EHKEPJIBENP> LLCMIPFHAEH(Action<CNCFPMNNGFM, EHKEPJIBENP> IPDGCBIIEII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class AMNFFFINOJH<TKey> : MEODPCBMKMG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string JEIPNIIJBLI(TKey PMMAAICOJOP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly string PKNJGENGBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly double DDGGBENMLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly bool POKEJJHBLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly int OKOAJKDMNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly ISet<string> CBPJEIIPIKM;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x30D2E80", Offset = "0x30D2280", VA = "0x1830D2E80")]
	private static string JIJBDLEOCHL(TKey PMMAAICOJOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x30D3040", Offset = "0x30D2440", VA = "0x1830D3040")]
	public AMNFFFINOJH(string PKNJGENGBOG = "F2", double DDGGBENMLAG = double.MaxValue, bool POKEJJHBLEC = false, int OKOAJKDMNOI = int.MaxValue, [Optional] ISet<string> CBPJEIIPIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x30D2890", Offset = "0x30D1C90", VA = "0x1830D2890", Slot = "4")]
	public override Dictionary<string, string> IIPNGNPGJBG(CPMEPPENFLB<TKey> INJHLEJHFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x30D2600", Offset = "0x30D1A00", VA = "0x1830D2600")]
	private bool EGNFKPOPGKF(string CMAENNBMJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x30D2940", Offset = "0x30D1D40", VA = "0x1830D2940")]
	public Dictionary<string, string> IIPNGNPGJBG(CPMEPPENFLB<TKey> INJHLEJHFLF, JEIPNIIJBLI DLJNEEOCKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x30D26E0", Offset = "0x30D1AE0", VA = "0x1830D26E0")]
	private string IGEJICNLFPD(StringBuilder GBDDHFOICKO, List<TKey> PPBGLDOBAEF, JEIPNIIJBLI DLJNEEOCKIB, bool BPJFMFJPMKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x30D2EC0", Offset = "0x30D22C0", VA = "0x1830D2EC0")]
	private static void OABOHGBNGBE(StringBuilder MILHMKCJFGN, string GJCCKPDDMOP, bool KLHFKGHPFJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public abstract class MEODPCBMKMG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut IIPNGNPGJBG(CPMEPPENFLB<TKey> INJHLEJHFLF);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
	protected MEODPCBMKMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class HMKAIDCCMGI<TKey> : MEODPCBMKMG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string CCEEJAJDLNJ(TKey PMMAAICOJOP);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x31E25C0", Offset = "0x31E19C0", VA = "0x1831E25C0")]
	private static string JIJBDLEOCHL(TKey PMMAAICOJOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x31E2510", Offset = "0x31E1910", VA = "0x1831E2510", Slot = "4")]
	public override string IIPNGNPGJBG(CPMEPPENFLB<TKey> INJHLEJHFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x31E23E0", Offset = "0x31E17E0", VA = "0x1831E23E0")]
	public string IIPNGNPGJBG(CPMEPPENFLB<TKey> INJHLEJHFLF, [NotNull] CCEEJAJDLNJ DLJNEEOCKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string FMHKGCDAFMN(CPMEPPENFLB<TKey> INJHLEJHFLF, [NotNull] CCEEJAJDLNJ DLJNEEOCKIB);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFBD0", Offset = "0x1FFEFD0", VA = "0x181FFFBD0")]
	protected HMKAIDCCMGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class AAMOGMPCEIG
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private class PAGKONBHMDN : AAMOGMPCEIG
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static AAMOGMPCEIG FNGGPKJOCFE
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x711BBF0", Offset = "0x711AFF0", VA = "0x18711BBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override float GPDDMOHGDEK
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x70A5CB0", Offset = "0x70A50B0", VA = "0x1870A5CB0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x711BCF0", Offset = "0x711B0F0", VA = "0x18711BCF0")]
		public PAGKONBHMDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static AAMOGMPCEIG AGEKPPHCOHL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static AAMOGMPCEIG KCIIGNIKLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7118980", Offset = "0x7117D80", VA = "0x187118980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public abstract float GPDDMOHGDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	protected AAMOGMPCEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IDPPGKFJBND<TKey> : HMKAIDCCMGI<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct DBFALPBHAHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CCEEJAJDLNJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static IDPPGKFJBND<TKey> FNGGPKJOCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly string[] OMILILDJFND;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x15D4990", Offset = "0x15D3D90", VA = "0x1815D4990")]
	private IDPPGKFJBND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x15D39D0", Offset = "0x15D2DD0", VA = "0x1815D39D0", Slot = "5")]
	protected override string FMHKGCDAFMN(CPMEPPENFLB<TKey> INJHLEJHFLF, CCEEJAJDLNJ DLJNEEOCKIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x15D38E0", Offset = "0x15D2CE0", VA = "0x1815D38E0")]
	[CompilerGenerated]
	internal static string AIPGPFJMPKF(string CIDJDDDGPJO, TKey PMMAAICOJOP, ref DBFALPBHAHA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class CPMEPPENFLB<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public readonly struct KJFIDKHALEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly long HMAJLLPJHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly long BHIEFGICJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly int EIKLGDCHFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly int HCFKNANLJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly bool AOFKHMNLOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly string EDCMBLMIHNA;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3B912A0", Offset = "0x3B906A0", VA = "0x183B912A0")]
		public KJFIDKHALEE(long HMAJLLPJHPK, int EIKLGDCHFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3B91310", Offset = "0x3B90710", VA = "0x183B91310")]
		public KJFIDKHALEE(long HMAJLLPJHPK, long BHIEFGICJIL, int EIKLGDCHFPJ, int HCFKNANLJDO, bool AOFKHMNLOBH, string EDCMBLMIHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3B91170", Offset = "0x3B90570", VA = "0x183B91170")]
		public int HCBAJDAJDGG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3B911C0", Offset = "0x3B905C0", VA = "0x183B911C0")]
		public int HFIAGHFAHKJ(int JBGDGOIFPME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3B91100", Offset = "0x3B90500", VA = "0x183B91100")]
		public double BOHMAIJAPME()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3B911E0", Offset = "0x3B905E0", VA = "0x183B911E0")]
		public KJFIDKHALEE INBDJODPPGP(long BHIEFGICJIL, int HCFKNANLJDO)
		{
			return default(KJFIDKHALEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class PEFDMNJICBO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class LNLJKBCMOJJ<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Func<PEFDMNJICBO, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public PEFDMNJICBO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private PEFDMNJICBO <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
			public LNLJKBCMOJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x27190B0", Offset = "0x27184B0", VA = "0x1827190B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly TKey JGJPKDIBNOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly CPMEPPENFLB<TKey> INJHLEJHFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly EHKEPJIBENP IGCLICKKCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private List<PEFDMNJICBO> HMPIAMDODKJ;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string MDEEFOLOKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x20E02A0", Offset = "0x20DF6A0", VA = "0x1820E02A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public IEnumerable<PEFDMNJICBO> DDHIFCMPLOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2C32BF0", Offset = "0x2C31FF0", VA = "0x182C32BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public KJFIDKHALEE FHEPNNDOLMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x2C32BD0", Offset = "0x2C31FD0", VA = "0x182C32BD0")]
			[CompilerGenerated]
			get
			{
				return default(KJFIDKHALEE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x2C329F0", Offset = "0x2C31DF0", VA = "0x182C329F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2C32D60", Offset = "0x2C32160", VA = "0x182C32D60")]
		internal PEFDMNJICBO(CPMEPPENFLB<TKey> INJHLEJHFLF, TKey PMMAAICOJOP, EHKEPJIBENP IGCLICKKCHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2C32C10", Offset = "0x2C32010", VA = "0x182C32C10")]
		public PEFDMNJICBO OOCLDAJLMAB(TKey PMMAAICOJOP, [Optional] EHKEPJIBENP? JOJFHCDPDDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1BC63F0", Offset = "0x1BC57F0", VA = "0x181BC63F0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(LNLJKBCMOJJ<>))]
		public Task<T> PPBKCMFAPDM<T>(TKey PMMAAICOJOP, Func<PEFDMNJICBO, Task<T>> IHEKINJBFIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2C32A20", Offset = "0x2C31E20", VA = "0x182C32A20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DNMMMMNEBLL : IEnumerable<(TKey, List<TKey>, KJFIDKHALEE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KJFIDKHALEE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private (TKey key, List<TKey> path, KJFIDKHALEE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CPMEPPENFLB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private IEnumerator<(TKey key, List<TKey> path, KJFIDKHALEE timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private (TKey key, List<TKey> path, KJFIDKHALEE timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		private (TKey, List<TKey>, KJFIDKHALEE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x2E73790", Offset = "0x2E72B90", VA = "0x182E73790", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KJFIDKHALEE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2E73800", Offset = "0x2E72C00", VA = "0x182E73800", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2E73860", Offset = "0x2E72C60", VA = "0x182E73860")]
		[DebuggerHidden]
		public DNMMMMNEBLL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x22FB570", Offset = "0x22FA970", VA = "0x1822FB570", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2E73350", Offset = "0x2E72750", VA = "0x182E73350", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2E73680", Offset = "0x2E72A80", VA = "0x182E73680")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2E737C0", Offset = "0x2E72BC0", VA = "0x182E737C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2E736D0", Offset = "0x2E72AD0", VA = "0x182E736D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KJFIDKHALEE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x1765D20", Offset = "0x1765120", VA = "0x181765D20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PJOBGIKCKJL : IEnumerable<(TKey, List<TKey>, KJFIDKHALEE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KJFIDKHALEE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private (TKey key, List<TKey> path, KJFIDKHALEE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private PEFDMNJICBO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public PEFDMNJICBO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public CPMEPPENFLB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private IEnumerator<PEFDMNJICBO> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private PEFDMNJICBO <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private IEnumerator<(TKey key, List<TKey> path, KJFIDKHALEE timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private (TKey key, List<TKey> path, KJFIDKHALEE timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private (TKey, List<TKey>, KJFIDKHALEE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x2E73790", Offset = "0x2E72B90", VA = "0x182E73790", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KJFIDKHALEE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3D006C0", Offset = "0x3CFFAC0", VA = "0x183D006C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2E73860", Offset = "0x2E72C60", VA = "0x182E73860")]
		[DebuggerHidden]
		public PJOBGIKCKJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3D00720", Offset = "0x3CFFB20", VA = "0x183D00720", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFF30", Offset = "0x3CFF330", VA = "0x183CFFF30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3D00540", Offset = "0x3CFF940", VA = "0x183D00540")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFED0", Offset = "0x3CFF2D0", VA = "0x183CFFED0")]
		private void MKCFKGNFONF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3D00680", Offset = "0x3CFFA80", VA = "0x183D00680", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3D005A0", Offset = "0x3CFF9A0", VA = "0x183D005A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KJFIDKHALEE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3136FD0", Offset = "0x31363D0", VA = "0x183136FD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Action<TKey, KJFIDKHALEE, EHKEPJIBENP> ADIBOCMCHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Action<TKey, KJFIDKHALEE, EHKEPJIBENP> FCBKKKELNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action<CPMEPPENFLB<TKey>, EHKEPJIBENP> KOCBHCIBMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly PEFDMNJICBO HHLLEOCLBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private bool IAEKIDJDAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int JLHCDJJMNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Stopwatch EOFHIAKKIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public readonly int PKNGEAEHLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private string PEMIEOGKBNB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public PEFDMNJICBO LIPGDDAOMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	[NotNull]
	public string MDEEFOLOKFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8A50", Offset = "0x2AE7E50", VA = "0x182AE8A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8C10", Offset = "0x2AE8010", VA = "0x182AE8C10")]
	public CPMEPPENFLB(TKey CKGBCGFCPMD, EHKEPJIBENP IGCLICKKCHJ, [Optional] int? EIKLGDCHFPJ, [Optional][CanBeNull] Stopwatch EOFHIAKKIIN, [Optional] Action<TKey, KJFIDKHALEE, EHKEPJIBENP> ADIBOCMCHII, [Optional] Action<TKey, KJFIDKHALEE, EHKEPJIBENP> FCBKKKELNHP, [Optional] Action<CPMEPPENFLB<TKey>, EHKEPJIBENP> KOCBHCIBMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2AE89C0", Offset = "0x2AE7DC0", VA = "0x182AE89C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8AB0", Offset = "0x2AE7EB0", VA = "0x182AE8AB0")]
	[IteratorStateMachine(typeof(CPMEPPENFLB<>.DNMMMMNEBLL))]
	public IEnumerable<(TKey, List<TKey>, KJFIDKHALEE)> NBGDCNEEDHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8B40", Offset = "0x2AE7F40", VA = "0x182AE8B40")]
	[IteratorStateMachine(typeof(CPMEPPENFLB<>.PJOBGIKCKJL))]
	private IEnumerable<(TKey, List<TKey>, KJFIDKHALEE)> NBGDCNEEDHC(List<TKey> GBGNJPBFOBA, PEFDMNJICBO LKGABMHOMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8940", Offset = "0x2AE7D40", VA = "0x182AE8940")]
	private (long, int) ABDPIDJLMEG()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class FPFPEEDOFPB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<byte, IDDLCCHPFEO> AJOAOOABLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly BGPEDGDLFDA<IDDLCCHPFEO> IDEIDJMHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly bool LNOMAEHAGKK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IDDLCCHPFEO HDJMKLOPHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 BPNGCJKBEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1CBB9C0", Offset = "0x1CBADC0", VA = "0x181CBB9C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xCE9A60", Offset = "0xCE8E60", VA = "0x180CE9A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private Vector2 LIKKLKFGNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xF8A9E0", Offset = "0xF89DE0", VA = "0x180F8A9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Vector2 CMHGLCINNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7119700", Offset = "0x7118B00", VA = "0x187119700")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x139C090", Offset = "0x139B490", VA = "0x18139C090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int IOMCFMAEIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABD510", VA = "0x180ABE110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xD9E490", Offset = "0xD9D890", VA = "0x180D9E490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7119B20", Offset = "0x7118F20", VA = "0x187119B20")]
	public FPFPEEDOFPB(Bounds GBPFNKANIAI, Vector2[] DPEBHEOPEJD, int EHGHGNMGAAI, byte ILIPJAOBBJM, float PNGOMPOONGL = 0f, [Optional] BGPEDGDLFDA<IDDLCCHPFEO> IDEIDJMHAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7119460", Offset = "0x7118860", VA = "0x187119460")]
	public IDDLCCHPFEO GAGDPCHOGKC(byte BNOAGGNAMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x71190E0", Offset = "0x71184E0", VA = "0x1871190E0")]
	public void DEKKINLEPDN(Vector3 FGLOAKJBDBO, float DOCEGNHJALH, float JAHKFJANPEB, ref List<byte> PMFIIBBFBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7119B00", Offset = "0x7118F00", VA = "0x187119B00")]
	public void PGPNEPCHNCO(IDDLCCHPFEO.EDLBILCCAKF BKNOMKPLAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7119650", Offset = "0x7118A50", VA = "0x187119650")]
	public static int IMLDDJLOAAC(Vector2[] DPEBHEOPEJD, int EHGHGNMGAAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x71194C0", Offset = "0x71188C0", VA = "0x1871194C0")]
	private IDDLCCHPFEO ICGMBOEONFM(byte BNOAGGNAMKG, IDDLCCHPFEO.EDIMPJDIDIG LAKIFBOJNKL, IDDLCCHPFEO OJBGDMNECON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7119720", Offset = "0x7118B20", VA = "0x187119720")]
	private void JFJGEMHNDLP(IDDLCCHPFEO OJBGDMNECON, Vector2[] DPEBHEOPEJD, int JJOBKJHBKHC, int NEEFLMJDLBI, int HGOFEOOMBPL, int JGECHPIOIEN, float PNGOMPOONGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x71191B0", Offset = "0x71185B0", VA = "0x1871191B0")]
	private void DHAEPDGAALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x71193B0", Offset = "0x71187B0", VA = "0x1871193B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7119410", Offset = "0x7118810", VA = "0x187119410", Slot = "1")]
	~FPFPEEDOFPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class IDDLCCHPFEO
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum EDIMPJDIDIG
	{
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum EDLBILCCAKF
	{
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public byte MCOMIPJPJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Vector3 DDMOOCEJBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3 MMHHHCFJGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Vector3 KLFNIOGFHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Vector3 OOMLGCDBCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public EDIMPJDIDIG KAPLNNHGBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public IDDLCCHPFEO BDHKOBIGIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public List<IDDLCCHPFEO> PPGMNIALKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool DHNCPDLKIJC;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x711B2D0", Offset = "0x711A6D0", VA = "0x18711B2D0")]
	public IDDLCCHPFEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x711B110", Offset = "0x711A510", VA = "0x18711B110")]
	public void GKKELJKGEHE(IDDLCCHPFEO KEGFIDMGBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
	public void PGPNEPCHNCO(int ODHOOGGKEKK, EDLBILCCAKF BKNOMKPLAPE, int GECDOOBIMGM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x711AEE0", Offset = "0x711A2E0", VA = "0x18711AEE0")]
	public void DEKKINLEPDN(List<byte> PMFIIBBFBKF, Vector3 FGLOAKJBDBO, float DOCEGNHJALH, float JAHKFJANPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x711B200", Offset = "0x711A600", VA = "0x18711B200")]
	public bool LLMPMGGOEIO(Vector3 EDCHAMDBOGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x711B1D0", Offset = "0x711A5D0", VA = "0x18711B1D0")]
	public bool JFELGCKMALF(Vector3 EDCHAMDBOGG, float AMBPEFLHNIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x711B250", Offset = "0x711A650", VA = "0x18711B250")]
	public void MHIDNOPDKCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BGPEDGDLFDA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Stack<T> DJOEGFNLABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly List<T> KAOEDMBMOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly int NMMOOMNFFBC;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x205D590", Offset = "0x205C990", VA = "0x18205D590")]
	public static BGPEDGDLFDA<T> GHIGPFILDPJ(int GLDHDJHPIPL = 0, int NMMOOMNFFBC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x205D990", Offset = "0x205CD90", VA = "0x18205D990")]
	public BGPEDGDLFDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x205D800", Offset = "0x205CC00", VA = "0x18205D800")]
	public BGPEDGDLFDA(int GLDHDJHPIPL, int NMMOOMNFFBC = int.MaxValue, bool MBDKKNJNIMP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x205D220", Offset = "0x205C620", VA = "0x18205D220")]
	public T DBEECCLLOJJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x205D330", Offset = "0x205C730", VA = "0x18205D330")]
	public void DODJNFMPKBN(T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x205D4C0", Offset = "0x205C8C0", VA = "0x18205D4C0")]
	private void FMAFIHKBNJG(T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x205D200", Offset = "0x205C600", VA = "0x18205D200")]
	private void BKEFIFGCCAO(T AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x205D3D0", Offset = "0x205C7D0", VA = "0x18205D3D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x205D660", Offset = "0x205CA60", VA = "0x18205D660")]
	private void LMIIFLLICHE(IEnumerable<T> IKBLLODDBLI)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x25D2FE0", Offset = "0x25D23E0", VA = "0x1825D2FE0", Slot = "4")]
		public virtual T ICEOPPCPABO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class CHHHHGELJHF<T> : IEnumerable<CHHHHGELJHF<T>.HDIBAAAFNDK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct HDIBAAAFNDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public T AGLCIEKHLEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int BNOAGGNAMKG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class PLGAAEBGIPD : IEnumerator<HDIBAAAFNDK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private CHHHHGELJHF<T> BJIHAMCKFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int BNOAGGNAMKG;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x92D730", Offset = "0x92CB30", VA = "0x18092D730", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public HDIBAAAFNDK AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3D09520", Offset = "0x3D08920", VA = "0x183D09520", Slot = "4")]
			get
			{
				return default(HDIBAAAFNDK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3081160", Offset = "0x3080560", VA = "0x183081160")]
		public PLGAAEBGIPD(CHHHHGELJHF<T> BJIHAMCKFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D09420", Offset = "0x3D08820", VA = "0x183D09420", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x287D220", Offset = "0x287C620", VA = "0x18287D220", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA9CB00", Offset = "0xA9BF00", VA = "0x180A9CB00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct KMAIGLJFIEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public bool BLODGGMNMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public T AGLCIEKHLEE;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private const int DECHMKBMCFE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Dictionary<T, int> BICHLMJCNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private KMAIGLJFIEN[] DHCNNMELHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private int MKEKGAJDIJC;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int DODOJBCJEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1062550", Offset = "0x1061950", VA = "0x181062550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1578940", Offset = "0x1577D40", VA = "0x181578940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1C906B0", Offset = "0x1C8FAB0", VA = "0x181C906B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x30A15B0", Offset = "0x30A09B0", VA = "0x1830A15B0")]
	public CHHHHGELJHF(int GLDHDJHPIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x30A1680", Offset = "0x30A0A80", VA = "0x1830A1680")]
	public CHHHHGELJHF(HDIBAAAFNDK[] HGCJACCDKMF, bool KNBLDPGJGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x30A0A10", Offset = "0x309FE10", VA = "0x1830A0A10")]
	public int DJGFBBBIOJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x30A0DF0", Offset = "0x30A01F0", VA = "0x1830A0DF0")]
	private int NFHABEHJIHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x30A09C0", Offset = "0x309FDC0", VA = "0x1830A09C0", Slot = "6")]
	protected virtual uint CAIIFOMAGCH(uint LEMKICMKGLB, T AGLCIEKHLEE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x30A0BD0", Offset = "0x309FFD0", VA = "0x1830A0BD0")]
	public bool HHCAPJEIIKO(T AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x30A0A80", Offset = "0x309FE80", VA = "0x1830A0A80")]
	public int DLMFMKDMKBE(T AGLCIEKHLEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x30A1050", Offset = "0x30A0450", VA = "0x1830A1050")]
	public T OIHEHOMKKLI(int BNOAGGNAMKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x30A14F0", Offset = "0x30A08F0", VA = "0x1830A14F0")]
	public bool PLCLGNFCBMP(T AGLCIEKHLEE, bool CBINDKCEMHJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x30A1300", Offset = "0x30A0700", VA = "0x1830A1300")]
	public bool PLCLGNFCBMP(T AGLCIEKHLEE, int BNOAGGNAMKG, bool CBINDKCEMHJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x30A0B30", Offset = "0x309FF30", VA = "0x1830A0B30")]
	private int GPPJECNDIPD(int ILIPJAOBBJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x30A1530", Offset = "0x30A0930", VA = "0x1830A1530", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x30A1530", Offset = "0x30A0930", VA = "0x1830A1530", Slot = "4")]
	private IEnumerator<HDIBAAAFNDK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x711BEB0", Offset = "0x711B2B0", VA = "0x18711BEB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x711C140", Offset = "0x711B540", VA = "0x18711C140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x711C070", Offset = "0x711B470", VA = "0x18711C070")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x711BE20", Offset = "0x711B220", VA = "0x18711BE20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x711C0B0", Offset = "0x711B4B0", VA = "0x18711C0B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x711BFE0", Offset = "0x711B3E0", VA = "0x18711BFE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x711BDC0", Offset = "0x711B1C0", VA = "0x18711BDC0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class BAHOAACAOFD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int GLDHDJHPIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private int JJKECDAEKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private List<T> JFJPDDKMGLD;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1315BD0", Offset = "0x1314FD0", VA = "0x181315BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public T BFFIOPALDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x40C9BA0", Offset = "0x40C8FA0", VA = "0x1840C9BA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public T PBCKKCMKANH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x40C9D50", Offset = "0x40C9150", VA = "0x1840C9D50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T ODCAADABHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x40C9B40", Offset = "0x40C8F40", VA = "0x1840C9B40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x40CA040", Offset = "0x40C9440", VA = "0x1840CA040")]
	public BAHOAACAOFD(int GLDHDJHPIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x40C9F10", Offset = "0x40C9310", VA = "0x1840C9F10")]
	public void NNFBEGDMHOD(T KLNMEEKKCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x40CA000", Offset = "0x40C9400", VA = "0x1840CA000")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x40C9CB0", Offset = "0x40C90B0", VA = "0x1840C9CB0")]
	public void FBGDFAHNKPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x40C9DF0", Offset = "0x40C91F0", VA = "0x1840C9DF0")]
	public void NKOEJDNACEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x40C9FF0", Offset = "0x40C93F0", VA = "0x1840C9FF0")]
	public void OLOCMHNKBIN()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct OBLIIOMLPEC<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private readonly List<Component> FIONHDMDJNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private readonly bool DJJIKMFEPPM;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x176ADF0", Offset = "0x176A1F0", VA = "0x18176ADF0")]
			public OBLIIOMLPEC(List<Component> FIONHDMDJNK, bool DJJIKMFEPPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x23D0150", Offset = "0x23CF550", VA = "0x1823D0150")]
			public APCBMLFFEDH<T> MHIEAIINAGJ()
			{
				return default(APCBMLFFEDH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x23D01C0", Offset = "0x23CF5C0", VA = "0x1823D01C0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x23D01C0", Offset = "0x23CF5C0", VA = "0x1823D01C0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct APCBMLFFEDH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private readonly List<Component> FIONHDMDJNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private readonly bool DJJIKMFEPPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private int BNOAGGNAMKG;

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public T AOPJILKHAOB
			{
				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0x30D7D30", Offset = "0x30D7130", VA = "0x1830D7D30", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x30D7CC0", Offset = "0x30D70C0", VA = "0x1830D7CC0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x30D7D00", Offset = "0x30D7100", VA = "0x1830D7D00")]
			public APCBMLFFEDH(List<Component> FIONHDMDJNK, bool DJJIKMFEPPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x30D7BF0", Offset = "0x30D6FF0", VA = "0x1830D7BF0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x30D7C00", Offset = "0x30D7000", VA = "0x1830D7C00", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x28799B0", Offset = "0x2878DB0", VA = "0x1828799B0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x711DB80", Offset = "0x711CF80", VA = "0x18711DB80")]
		private void MHIDNOPDKCM(GameObject OEHOBCLILGI, bool DGLCECEILBL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x711D9D0", Offset = "0x711CDD0", VA = "0x18711D9D0")]
		public static void MHIDNOPDKCM(GameObject OEHOBCLILGI, ref ToolHierarchyCache PDBOIFOGFCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1B238D0", Offset = "0x1B22CD0", VA = "0x181B238D0")]
		public void FBBBCAOKDCL<T>(Action<T> NDPBOAHDPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1B23850", Offset = "0x1B22C50", VA = "0x181B23850")]
		public T DDHJPCMCJIC<T>(bool DJJIKMFEPPM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1B23B60", Offset = "0x1B22F60", VA = "0x181B23B60")]
		public OBLIIOMLPEC<T> FNIDAHBCAGF<T>(bool DJJIKMFEPPM = false) where T : class
		{
			return default(OBLIIOMLPEC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x711D600", Offset = "0x711CA00", VA = "0x18711D600")]
		public List<Component> FPJJFAPMNKB(Type GANFKPHKNKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x711D580", Offset = "0x711C980", VA = "0x18711D580", Slot = "4")]
		public bool Equals(ToolHierarchyCache EOMIKPKMCAG, ToolHierarchyCache PPNFDCNFKFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x711D950", Offset = "0x711CD50", VA = "0x18711D950", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HFAGBIOODHL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class NGAMKPFGBFF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Dictionary<int, T> IOKFOMHMAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private T LFAMLBONOBK;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual T DNNGEDKJKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9C56F0", Offset = "0x9C4AF0", VA = "0x1809C56F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x278CCB0", Offset = "0x278C0B0", VA = "0x18278CCB0")]
	public bool PPPGPECFDDD(T AGLCIEKHLEE, int DDFBJCJBGLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2080CA0", Offset = "0x20800A0", VA = "0x182080CA0")]
	public bool LPAOHDMOPAN(int DDFBJCJBGLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x278C910", Offset = "0x278BD10", VA = "0x18278C910")]
	public T MAJPEFHHBKF(int KNEAANMACEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x278CB10", Offset = "0x278BF10", VA = "0x18278CB10")]
	private bool OEBMIELIOIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x278C6C0", Offset = "0x278BAC0", VA = "0x18278C6C0")]
	public bool CLFAJBNDMHA(int DDFBJCJBGLB, out T AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x278CD70", Offset = "0x278C170", VA = "0x18278CD70")]
	public NGAMKPFGBFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class DNPEKKBONMP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class GEHOKFFBJFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public TNode ODBHDBFBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TNode OJBGDMNECON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public MOGNAJALGCC PPBHHNGAHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<MOGNAJALGCC> DFBBHFBCEAE;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public GEHOKFFBJFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct MOGNAJALGCC : IComparable<MOGNAJALGCC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int DDFBJCJBGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public TClaimant HEBIHDFLCAJ;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xBF1A50", Offset = "0xBF0E50", VA = "0x180BF1A50")]
		public MOGNAJALGCC(int DDFBJCJBGLB, TClaimant HEBIHDFLCAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C13E80", Offset = "0x2C13280", VA = "0x182C13E80")]
		public bool OBCNEINDBOI(in MOGNAJALGCC ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C13E70", Offset = "0x2C13270", VA = "0x182C13E70")]
		public bool JJICCICOMDM(in MOGNAJALGCC ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C13E60", Offset = "0x2C13260", VA = "0x182C13E60", Slot = "4")]
		public int CompareTo(MOGNAJALGCC ICELKIGIKKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C13EE0", Offset = "0x2C132E0", VA = "0x182C13EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum AOEMHJOGBFB
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CCHKCMIFIEE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public DNPEKKBONMP<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1CB05A0", Offset = "0x1CAF9A0", VA = "0x181CB05A0")]
		[DebuggerHidden]
		public CCHKCMIFIEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3149710", Offset = "0x3148B10", VA = "0x183149710", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x31498E0", Offset = "0x3148CE0", VA = "0x1831498E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3149800", Offset = "0x3148C00", VA = "0x183149800", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1D32680", Offset = "0x1D31A80", VA = "0x181D32680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly BGPEDGDLFDA<GEHOKFFBJFA> BJOOGEOPLPA;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly BGPEDGDLFDA<List<MOGNAJALGCC>> HFKNJIIPCNE;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int CFCOLGCDNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	internal readonly Dictionary<TClaimant, TNode> PBGFOEMOIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	internal readonly Dictionary<TNode, GEHOKFFBJFA> CLIBKBNCCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private AOEMHJOGBFB ADMMGKCBODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool JOEDCLMPFFI;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OPCIHBBNLKJ(TNode HBBENJBLANN);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void AKBONPNMCBN(TNode HBBENJBLANN, TClaimant OJDLCPNHPHP, TClaimant NJOLCNJHHBM);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E75D50", Offset = "0x2E75150", VA = "0x182E75D50")]
	public DNPEKKBONMP(AOEMHJOGBFB ADMMGKCBODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E75010", Offset = "0x2E74410", VA = "0x182E75010")]
	public void HBPDFIJCOHP(TNode HBBENJBLANN, TNode ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E75830", Offset = "0x2E74C30", VA = "0x182E75830")]
	public void OGMCCGOMPND(TClaimant HEBIHDFLCAJ, TNode MMEJCFEBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2E749E0", Offset = "0x2E73DE0", VA = "0x182E749E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E74940", Offset = "0x2E73D40", VA = "0x182E74940")]
	private void DBGIJGLHDFN(TClaimant HEBIHDFLCAJ, TNode BPBKMFOMCCG, TNode MMEJCFEBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2E757D0", Offset = "0x2E74BD0", VA = "0x182E757D0")]
	private int NCCLMNPNFDM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2E75930", Offset = "0x2E74D30", VA = "0x182E75930")]
	private void POKEOGNCMJD(TClaimant HEBIHDFLCAJ, TNode DPAPINJJILF, TNode BGACBDKLDPA, int HGBEJBGMOMO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2E75090", Offset = "0x2E74490", VA = "0x182E75090")]
	private void HCMAGMKGLFH(MOGNAJALGCC LPIKFOCKBJL, GEHOKFFBJFA BJCJAPGFHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2E75120", Offset = "0x2E74520", VA = "0x182E75120")]
	private void JFCFDOLOEGG(TClaimant HEBIHDFLCAJ, TNode DPAPINJJILF, TNode BGACBDKLDPA, int HGBEJBGMOMO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2E74580", Offset = "0x2E73980", VA = "0x182E74580")]
	private void AAINMNGOLBH(MOGNAJALGCC LPIKFOCKBJL, TNode HBBENJBLANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2E756D0", Offset = "0x2E74AD0", VA = "0x182E756D0")]
	private void LOCHFALMHAL(MOGNAJALGCC LPIKFOCKBJL, GEHOKFFBJFA BJCJAPGFHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2E74820", Offset = "0x2E73C20", VA = "0x182E74820")]
	private void CEJOELBPONC(GEHOKFFBJFA BJCJAPGFHNP, bool PIBBLOHMMLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E74C40", Offset = "0x2E74040", VA = "0x182E74C40")]
	private void GILGKGALPFD(GEHOKFFBJFA BJCJAPGFHNP, TNode ICPFLJENDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E75380", Offset = "0x2E74780", VA = "0x182E75380")]
	[IteratorStateMachine(typeof(DNPEKKBONMP<, >.CCHKCMIFIEE))]
	private IEnumerable<TNode> JHNAMFPCHMI(TNode DPAPINJJILF, TNode BGACBDKLDPA, bool BDHKMNJCBPO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E75610", Offset = "0x2E74A10", VA = "0x182E75610")]
	private GEHOKFFBJFA KNOEMLLAPLL(TNode HBBENJBLANN, TNode OJBGDMNECON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E74690", Offset = "0x2E73A90", VA = "0x182E74690")]
	private GEHOKFFBJFA BJHDDDNHEIA(TNode HBBENJBLANN, TNode OJBGDMNECON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E75450", Offset = "0x2E74850", VA = "0x182E75450")]
	private void JICFKAPBFCN(GEHOKFFBJFA BJCJAPGFHNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class FKPJDIDPEAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	protected struct HMJGCKPAALG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public T EKGBCCDIAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int NKHPDOMIFDG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	protected readonly List<HMJGCKPAALG> CKDPDEINCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private T PMPIDFMANJC;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1C906B0", Offset = "0x1C8FAB0", VA = "0x181C906B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x380BB70", Offset = "0x380AF70", VA = "0x18380BB70")]
	public bool NDHLGOCFLHK(T AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x380BD70", Offset = "0x380B170", VA = "0x18380BD70")]
	public void NNFBEGDMHOD(T AGLCIEKHLEE, int DDFBJCJBGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x380BA50", Offset = "0x380AE50", VA = "0x18380BA50")]
	public bool LOBOHMPHNJE(T AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x380BE10", Offset = "0x380B210", VA = "0x18380BE10")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x380B9E0", Offset = "0x380ADE0", VA = "0x18380B9E0")]
	public T JDCBEGIIGLN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x380B830", Offset = "0x380AC30", VA = "0x18380B830")]
	private void CNAJNLBPJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x380BE70", Offset = "0x380B270", VA = "0x18380BE70")]
	public FKPJDIDPEAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class JGKJANBMOHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct KFOIFLPGPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int NKHPDOMIFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public T EKGBCCDIAJC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<object, KFOIFLPGPEP> IOKFOMHMAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly EqualityComparer<T> BADDIMNKCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private T LFAMLBONOBK;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public virtual T DNNGEDKJKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6AD0", Offset = "0x2BA5ED0", VA = "0x182BA6AD0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x25F1430", Offset = "0x25F0830", VA = "0x1825F1430", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool MFLIJOIMCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x2BA43F0", Offset = "0x2BA37F0", VA = "0x182BA43F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public object AHJNIFAKFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6B40", Offset = "0x2BA5F40", VA = "0x182BA6B40")]
	public bool PPPGPECFDDD(T AGLCIEKHLEE, object AEMEEHLIDCM, int DDFBJCJBGLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4380", Offset = "0x2BA3780", VA = "0x182BA4380")]
	public bool LPAOHDMOPAN(object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2BA42B0", Offset = "0x2BA36B0", VA = "0x182BA42B0")]
	public bool CLFAJBNDMHA(object AEMEEHLIDCM, out T AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6B10", Offset = "0x2BA5F10", VA = "0x182BA6B10")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA5590", Offset = "0x2BA4990", VA = "0x182BA5590")]
	private bool OEBMIELIOIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7070", Offset = "0x2BA6470", VA = "0x182BA7070")]
	public JGKJANBMOHD()
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
