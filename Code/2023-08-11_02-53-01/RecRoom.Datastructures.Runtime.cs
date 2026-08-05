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
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xBE1D20", Offset = "0xBE0520", VA = "0x180BE1D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBB10C0", Offset = "0xBAF8C0", VA = "0x180BB10C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xBB1160", Offset = "0xBAF960", VA = "0x180BB1160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
	public virtual void MLJIDAGLHIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
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
	[JMBDDOFODOF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x343F340", Offset = "0x343DB40", VA = "0x18343F340", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x343EAA0", Offset = "0x343D2A0", VA = "0x18343EAA0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x343F870", Offset = "0x343E070", VA = "0x18343F870")]
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
	private sealed class HDFELIEJKAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public HDFELIEJKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3967710", Offset = "0x3965F10", VA = "0x183967710")]
		internal int NPMHMEFIOMK(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[JMBDDOFODOF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC35870", Offset = "0xC34070", VA = "0x180C35870", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC358A0", Offset = "0xC340A0", VA = "0x180C358A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xC357C0", Offset = "0xC33FC0", VA = "0x180C357C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey EECINICJCLK]
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC35820", Offset = "0xC34020", VA = "0x180C35820", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC356C0", Offset = "0xC33EC0", VA = "0x180C356C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xC351E0", Offset = "0xC339E0", VA = "0x180C351E0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xC34A00", Offset = "0xC33200", VA = "0x180C34A00", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xC34650", Offset = "0xC32E50", VA = "0x180C34650", Slot = "14")]
	protected virtual string MBILDBHPKCL(TKeyVal DCLOJPPBKCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xC34590", Offset = "0xC32D90", VA = "0x180C34590", Slot = "4")]
	public bool ContainsKey(TKey EECINICJCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xC355A0", Offset = "0xC33DA0", VA = "0x180C355A0", Slot = "5")]
	public bool TryGetValue(TKey EECINICJCLK, out TVal MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xC345C0", Offset = "0xC32DC0", VA = "0x180C345C0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xC345C0", Offset = "0xC32DC0", VA = "0x180C345C0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xC355D0", Offset = "0xC33DD0", VA = "0x180C355D0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AOCEKNCILDF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PJLPGHPPCOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public PJLPGHPPCOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x21B41F0", Offset = "0x21B29F0", VA = "0x1821B41F0")]
		internal bool OMONIDLEHIH(CEFFMLKIGGJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float KLLKPFAPADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float NNBGGFIMFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<CEFFMLKIGGJ<float, T>> CKLAAEABOLP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OIIAJECIEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2705250", Offset = "0x2703A50", VA = "0x182705250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27052D0", Offset = "0x2703AD0", VA = "0x1827052D0")]
	public AOCEKNCILDF(float EDNJGIFBDAJ, float EPJOGKMODKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2704860", Offset = "0x2703060", VA = "0x182704860")]
	public bool BHINGKJGEHK(float MJLKABMFGJA, T MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2704E90", Offset = "0x2703690", VA = "0x182704E90")]
	public IEnumerable<T> HGFACACHIFH(float MJLKABMFGJA, [Optional] float? BAGAIPNKGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2704B20", Offset = "0x2703320", VA = "0x182704B20")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x27047A0", Offset = "0x2702FA0", VA = "0x1827047A0")]
	private void BFPOCIKBHAB(float MJLKABMFGJA)
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
	public T PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x18C1B70", Offset = "0x18C0370", VA = "0x1818C1B70")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x18C1940", Offset = "0x18C0140", VA = "0x1818C1940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float HKHHCGJBOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA48B50", Offset = "0xA47350", VA = "0x180A48B50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3731E40", Offset = "0x3730640", VA = "0x183731E40")]
	public T PMKMOBFOGBI(float CIIALCPCBIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3731B20", Offset = "0x3730320", VA = "0x183731B20")]
	public T MKBKIJMPNKD(float CIIALCPCBIG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NIPOOMLKNCA(T BENALFHNIOG, T EMAOEIAIOHA, float CIIALCPCBIG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4FA2320", Offset = "0x4FA0B20", VA = "0x184FA2320", Slot = "4")]
	protected override float NIPOOMLKNCA(float BENALFHNIOG, float EMAOEIAIOHA, float CIIALCPCBIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A3A0", Offset = "0x6E08BA0", VA = "0x186E0A3A0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8B2510", Offset = "0x8B0D10", VA = "0x1808B2510", Slot = "4")]
	protected override Vector3 NIPOOMLKNCA(Vector3 BENALFHNIOG, Vector3 EMAOEIAIOHA, float CIIALCPCBIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0E8B0", Offset = "0x6E0D0B0", VA = "0x186E0E8B0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E09F80", Offset = "0x6E08780", VA = "0x186E09F80", Slot = "4")]
	protected override Color NIPOOMLKNCA(Color BENALFHNIOG, Color EMAOEIAIOHA, float CIIALCPCBIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E09FE0", Offset = "0x6E087E0", VA = "0x186E09FE0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FIBKEPMCILP
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1B87CD0", Offset = "0x1B864D0", VA = "0x181B87CD0")]
	public static CEFFMLKIGGJ<T1, T2> OIAKNFDBOOD<T1, T2>(T1 FKCMHDJNLCL, T2 IOCDPMLEPIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1B87D40", Offset = "0x1B86540", VA = "0x181B87D40")]
	public static PAOHCOJGNME<T1, T2, T3> OIAKNFDBOOD<T1, T2, T3>(T1 FKCMHDJNLCL, T2 IOCDPMLEPIM, T3 IFJJAAMJOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A380", Offset = "0x6E08B80", VA = "0x186E0A380")]
	internal static int IMOKOJODCEA(int BBLPPBCFFJN, int OGBKIFJMJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A390", Offset = "0x6E08B90", VA = "0x186E0A390")]
	internal static int IMOKOJODCEA(int BBLPPBCFFJN, int OGBKIFJMJPC, int HFEJKGPJKII)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CEFFMLKIGGJ<T1, T2> : IComparable<CEFFMLKIGGJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T1 MHKBOOGFEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly T2 HPCGJGKKCKO;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29523A0", Offset = "0x2950BA0", VA = "0x1829523A0")]
	public CEFFMLKIGGJ(T1 FKCMHDJNLCL, T2 IOCDPMLEPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x29504A0", Offset = "0x294ECA0", VA = "0x1829504A0", Slot = "4")]
	public int CompareTo(CEFFMLKIGGJ<T1, T2> OALEAAIPGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2950E40", Offset = "0x294F640", VA = "0x182950E40", Slot = "0")]
	public override bool Equals(object OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x29515E0", Offset = "0x294FDE0", VA = "0x1829515E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29518D0", Offset = "0x29500D0", VA = "0x1829518D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PAOHCOJGNME<T1, T2, T3> : IComparable<PAOHCOJGNME<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly T1 MHKBOOGFEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T2 HPCGJGKKCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T3 LAMFCIJAFNK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2C64730", Offset = "0x2C62F30", VA = "0x182C64730")]
	public PAOHCOJGNME(T1 FKCMHDJNLCL, T2 IOCDPMLEPIM, T3 IFJJAAMJOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2C63FF0", Offset = "0x2C627F0", VA = "0x182C63FF0", Slot = "4")]
	public int CompareTo(PAOHCOJGNME<T1, T2, T3> OALEAAIPGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C64210", Offset = "0x2C62A10", VA = "0x182C64210", Slot = "0")]
	public override bool Equals(object OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2C64410", Offset = "0x2C62C10", VA = "0x182C64410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2C64470", Offset = "0x2C62C70", VA = "0x182C64470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JMBDDOFODOF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	public JMBDDOFODOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HashableScriptableObject : ScriptableObject, MHOMABBFFOL, GLMPCJJDOLB, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash OBMLCMEKPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x9176C0", Offset = "0x915EC0", VA = "0x1809176C0")]
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
	[PAEAJOGLJAD]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[HideInInspector]
	[SerializeField]
	[PAEAJOGLJAD]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D940", Offset = "0x6E0C140", VA = "0x186E0D940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D900", Offset = "0x6E0C100", VA = "0x186E0D900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D980", Offset = "0x6E0C180", VA = "0x186E0D980")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DB30", Offset = "0x6E0C330", VA = "0x186E0DB30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DAA0", Offset = "0x6E0C2A0", VA = "0x186E0DAA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x918E10", Offset = "0x917610", VA = "0x180918E10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x918E00", Offset = "0x917600", VA = "0x180918E00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6E0D8C0", Offset = "0x6E0C0C0", VA = "0x186E0D8C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DA10", Offset = "0x6E0C210", VA = "0x186E0DA10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D3D0", Offset = "0x6E0BBD0", VA = "0x186E0D3D0")]
	public void CopyBounds(SavedExtents OALEAAIPGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D820", Offset = "0x6E0C020", VA = "0x186E0D820")]
	public void SetLocalSpaceBounds(Bounds FPAKJIJOMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CD70", Offset = "0x6E0B570", VA = "0x186E0CD70")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D810", Offset = "0x6E0C010", VA = "0x186E0D810")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D400", Offset = "0x6E0BC00", VA = "0x186E0D400")]
	private void KKMGAHIDOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D5E0", Offset = "0x6E0BDE0", VA = "0x186E0D5E0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CD90", Offset = "0x6E0B590", VA = "0x186E0CD90")]
	public static void CalculateLocalBoundsFor(GameObject OAOEKKJFJKH, out Bounds FPAKJIJOMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CCB0", Offset = "0x6E0B4B0", VA = "0x186E0CCB0")]
	private static void AMMJAFFBADL(Bounds NBEGIGNBOIE, Color OEDICJGOJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D840", Offset = "0x6E0C040", VA = "0x186E0D840")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class LDOALBKBIDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct DLBAHMPMACN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public T PGHJLABHLGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public float EMJOGFMFCFK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static float DGBGNABILLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private List<T> BEABHOMLDKC;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const int GKLDCEGIAHA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private DLBAHMPMACN[] DLLMPOAIBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int AJNDPLPCGAL;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float FBKKCOFOCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xCC17E0", Offset = "0xCBFFE0", VA = "0x180CC17E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xCC17F0", Offset = "0xCBFFF0", VA = "0x180CC17F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24D6AD0", Offset = "0x24D52D0", VA = "0x1824D6AD0")]
	public LDOALBKBIDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24D69D0", Offset = "0x24D51D0", VA = "0x1824D69D0")]
	public LDOALBKBIDN(int JIAHBEIKEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x24D6540", Offset = "0x24D4D40", VA = "0x1824D6540")]
	public void GLILACFFLBJ(float MJLKABMFGJA, T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24D63F0", Offset = "0x24D4BF0", VA = "0x1824D63F0")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24D5B30", Offset = "0x24D4330", VA = "0x1824D5B30")]
	public bool AIDLGAJGNEM(float MJALINOKJHE, float GALGKKADBOH, out T MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24D5F80", Offset = "0x24D4780", VA = "0x1824D5F80")]
	public bool DPLHPGADLFG(float MJALINOKJHE, float GALGKKADBOH, out T MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24D6850", Offset = "0x24D5050", VA = "0x1824D6850")]
	public void JDKMJMECEJF(float MJALINOKJHE, float GALGKKADBOH, List<T> CEEEFJEILLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24D5F50", Offset = "0x24D4750", VA = "0x1824D5F50")]
	private int DOAHPDAEEHA(int IECGCMEIDDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24D5F10", Offset = "0x24D4710", VA = "0x1824D5F10")]
	private void CBODDBFEFFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CCDIKIJGJAD();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T IMMOCFIBCJM(T MENBIMCLIOI, float CIIALCPCBIG);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BAKEJKFEDLJ(T BENALFHNIOG, T EMAOEIAIOHA);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HKGNGAOFDJK(T BENALFHNIOG, T EMAOEIAIOHA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KFDFABFNFBE : LDOALBKBIDN<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xDCD1C0", Offset = "0xDCB9C0", VA = "0x180DCD1C0", Slot = "4")]
	protected override Vector3 CCDIKIJGJAD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A4A0", Offset = "0x6E08CA0", VA = "0x186E0A4A0", Slot = "5")]
	protected override Vector3 IMMOCFIBCJM(Vector3 MENBIMCLIOI, float CIIALCPCBIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A3E0", Offset = "0x6E08BE0", VA = "0x186E0A3E0", Slot = "6")]
	protected override Vector3 BAKEJKFEDLJ(Vector3 BENALFHNIOG, Vector3 EMAOEIAIOHA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A430", Offset = "0x6E08C30", VA = "0x186E0A430", Slot = "7")]
	protected override Vector3 HKGNGAOFDJK(Vector3 BENALFHNIOG, Vector3 EMAOEIAIOHA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A4E0", Offset = "0x6E08CE0", VA = "0x186E0A4E0")]
	public KFDFABFNFBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PLMBLOBHGGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable OEFAOPMNMGM;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PLMBLOBHGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PLBHHJBPLID : DCFEJDBMOEN<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C6C0", Offset = "0x6E0AEC0", VA = "0x186E0C6C0")]
	public PLBHHJBPLID(int LNKEFEELODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C650", Offset = "0x6E0AE50", VA = "0x186E0C650", Slot = "6")]
	protected override uint GBCLAEBIHBA(uint OBMLCMEKPMJ, string MENBIMCLIOI)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public class MJCGCDEOFMJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private MJCGCDEOFMJ<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x979150", Offset = "0x977950", VA = "0x180979150", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BBC0", Offset = "0x2B8A3C0", VA = "0x182B8BBC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x291CB80", Offset = "0x291B380", VA = "0x18291CB80")]
		public Enumerator(MJCGCDEOFMJ<T> CEEEFJEILLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B88A40", Offset = "0x2B87240", VA = "0x182B88A40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A8F0", Offset = "0x2B890F0", VA = "0x182B8A8F0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B887A0", Offset = "0x2B86FA0", VA = "0x182B887A0")]
		private void MNAEPHKGGPL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] FHCMCIEEMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ODFELLLMBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int PDMIFOCHBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int MNJCDKNLLPF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2121AB0", Offset = "0x21202B0", VA = "0x182121AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x21216C0", Offset = "0x211FEC0", VA = "0x1821216C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2121C70", Offset = "0x2120470", VA = "0x182121C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x21224B0", Offset = "0x2120CB0", VA = "0x1821224B0")]
	public MJCGCDEOFMJ(int LNKEFEELODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x21219F0", Offset = "0x21201F0", VA = "0x1821219F0")]
	public void GLILACFFLBJ(T CIIALCPCBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x21217C0", Offset = "0x211FFC0", VA = "0x1821217C0")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2121AF0", Offset = "0x21202F0", VA = "0x182121AF0")]
	public void HIBCBMJADHP(int JMKNAPEFDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2121CF0", Offset = "0x21204F0", VA = "0x182121CF0")]
	public void MALDCJKMAGP(T[] DLLMPOAIBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2121830", Offset = "0x2120030", VA = "0x182121830")]
	public Enumerator GAACJCPNEFN()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2122430", Offset = "0x2120C30", VA = "0x182122430", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2122430", Offset = "0x2120C30", VA = "0x182122430", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x21220B0", Offset = "0x21208B0", VA = "0x1821220B0")]
	private int OCAHKBFLNPG(int AMOEKOMGDLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2122380", Offset = "0x2120B80", VA = "0x182122380")]
	private int PMJPMKKCNMO(int AMOEKOMGDLG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class AAJNHLNMLPE
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	protected AAJNHLNMLPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class MJGMFHJNPGA<T> : AAJNHLNMLPE
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	protected struct DMFNNJIKGPL
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum PLLECLCHHLK
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
		public PLLECLCHHLK EIOLDDJPDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public T COPPLLLOGLG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int OJLJAEMBCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly bool ABCJHKDGMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	protected readonly bool HAKLCEPNCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	protected List<T> KPJGBNNFAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<DMFNNJIKGPL> EEAIHCKJFGO;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool LDIJGOLOOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x23A89B0", Offset = "0x23A71B0", VA = "0x1823A89B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x23A8EF0", Offset = "0x23A76F0", VA = "0x1823A8EF0")]
	protected MJGMFHJNPGA(bool HAKLCEPNCNM, bool ABCJHKDGMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x23A8B00", Offset = "0x23A7300", VA = "0x1823A8B00")]
	protected bool FEHOMFDDOCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x23A8E30", Offset = "0x23A7630", VA = "0x1823A8E30")]
	protected void LLBMLKICCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x23A8800", Offset = "0x23A7000", VA = "0x1823A8800")]
	protected void DEGKMAADJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x377E270", Offset = "0x377CA70", VA = "0x18377E270")]
	private static void HCGGJADDIFB<U>(ref List<U> DFMKDLJIHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x23A8CD0", Offset = "0x23A74D0", VA = "0x1823A8CD0", Slot = "4")]
	public void GLILACFFLBJ(T COPPLLLOGLG, bool KJGLKIAGDIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x23A8B80", Offset = "0x23A7380", VA = "0x1823A8B80", Slot = "5")]
	public void FNJGHMKCCPI(T COPPLLLOGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x23A89F0", Offset = "0x23A71F0", VA = "0x1823A89F0")]
	public void EEMEPIGIECC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BODKKBFJNNE
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLILACFFLBJ(Action COPPLLLOGLG, bool KJGLKIAGDIM = false);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNJGHMKCCPI(Action COPPLLLOGLG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class NJDLJLDNKHA : MJGMFHJNPGA<Action>, BODKKBFJNNE
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A8D0", Offset = "0x6E090D0", VA = "0x186E0A8D0")]
	public NJDLJLDNKHA(bool HAKLCEPNCNM = false, bool ABCJHKDGMEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A6C0", Offset = "0x6E08EC0", VA = "0x186E0A6C0")]
	public void MADELAMLLLM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A660", Offset = "0x6E08E60", VA = "0x186E0A660")]
	public static NJDLJLDNKHA INLOCBKJPHG(NJDLJLDNKHA CGHHKPMLBKL, Action COPPLLLOGLG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A600", Offset = "0x6E08E00", VA = "0x186E0A600")]
	public static NJDLJLDNKHA DBELBPPBBGP(NJDLJLDNKHA CGHHKPMLBKL, Action COPPLLLOGLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FKPBFFBDCJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLILACFFLBJ(Action<T> COPPLLLOGLG, bool KJGLKIAGDIM = false);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNJGHMKCCPI(Action<T> COPPLLLOGLG);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class BPPINFIIDCE<T> : MJGMFHJNPGA<Action<T>>, FKPBFFBDCJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2186960", Offset = "0x2185160", VA = "0x182186960")]
	public BPPINFIIDCE(bool HAKLCEPNCNM = false, bool ABCJHKDGMEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2328D40", Offset = "0x2327540", VA = "0x182328D40")]
	public void MADELAMLLLM(T CIIALCPCBIG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2184770", Offset = "0x2182F70", VA = "0x182184770")]
	public static BPPINFIIDCE<T> INLOCBKJPHG(BPPINFIIDCE<T> CGHHKPMLBKL, Action<T> COPPLLLOGLG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x21846E0", Offset = "0x2182EE0", VA = "0x1821846E0")]
	public static BPPINFIIDCE<T> DBELBPPBBGP(BPPINFIIDCE<T> CGHHKPMLBKL, Action<T> COPPLLLOGLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FGBJADDIDIK<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class APIEBAMEOKL<T, U> : MJGMFHJNPGA<Action<T, U>>, FGBJADDIDIK<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2186960", Offset = "0x2185160", VA = "0x182186960")]
	public APIEBAMEOKL(bool HAKLCEPNCNM = false, bool ABCJHKDGMEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C00820", Offset = "0x2BFF020", VA = "0x182C00820")]
	public void MADELAMLLLM(T CIIALCPCBIG, U MOHKJMJAMIK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2184770", Offset = "0x2182F70", VA = "0x182184770")]
	public static APIEBAMEOKL<T, U> INLOCBKJPHG(APIEBAMEOKL<T, U> CGHHKPMLBKL, Action<T, U> COPPLLLOGLG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x21846E0", Offset = "0x2182EE0", VA = "0x1821846E0")]
	public static APIEBAMEOKL<T, U> DBELBPPBBGP(APIEBAMEOKL<T, U> CGHHKPMLBKL, Action<T, U> COPPLLLOGLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class BCGDODDOBPE<T, U, V> : MJGMFHJNPGA<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2186960", Offset = "0x2185160", VA = "0x182186960")]
	public BCGDODDOBPE(bool HAKLCEPNCNM = false, bool ABCJHKDGMEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2185990", Offset = "0x2184190", VA = "0x182185990")]
	public void MADELAMLLLM(T CIIALCPCBIG, U MOHKJMJAMIK, V LAEIDNKAKOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2184770", Offset = "0x2182F70", VA = "0x182184770")]
	public static BCGDODDOBPE<T, U, V> INLOCBKJPHG(BCGDODDOBPE<T, U, V> CGHHKPMLBKL, Action<T, U, V> COPPLLLOGLG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x21846E0", Offset = "0x2182EE0", VA = "0x1821846E0")]
	public static BCGDODDOBPE<T, U, V> DBELBPPBBGP(BCGDODDOBPE<T, U, V> CGHHKPMLBKL, Action<T, U, V> COPPLLLOGLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AANMOCCKOCH<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class KNJMHCEJKPP<T, U, V, W> : MJGMFHJNPGA<Action<T, U, V, W>>, AANMOCCKOCH<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2186960", Offset = "0x2185160", VA = "0x182186960")]
	public KNJMHCEJKPP(bool HAKLCEPNCNM = false, bool ABCJHKDGMEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2283590", Offset = "0x2281D90", VA = "0x182283590")]
	public void MADELAMLLLM(T CIIALCPCBIG, U MOHKJMJAMIK, V LAEIDNKAKOO, W BBDFFBIEBJH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2184770", Offset = "0x2182F70", VA = "0x182184770")]
	public static KNJMHCEJKPP<T, U, V, W> INLOCBKJPHG(KNJMHCEJKPP<T, U, V, W> CGHHKPMLBKL, Action<T, U, V, W> COPPLLLOGLG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x21846E0", Offset = "0x2182EE0", VA = "0x1821846E0")]
	public static KNJMHCEJKPP<T, U, V, W> DBELBPPBBGP(KNJMHCEJKPP<T, U, V, W> CGHHKPMLBKL, Action<T, U, V, W> COPPLLLOGLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class EEIFDLIMEDC<T, U, V, W, X> : MJGMFHJNPGA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2186960", Offset = "0x2185160", VA = "0x182186960")]
	public EEIFDLIMEDC(bool HAKLCEPNCNM = false, bool ABCJHKDGMEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE980", Offset = "0x2DAD180", VA = "0x182DAE980")]
	public void MADELAMLLLM(T CIIALCPCBIG, U MOHKJMJAMIK, V LAEIDNKAKOO, W BBDFFBIEBJH, X FBGKLELIKCG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2184770", Offset = "0x2182F70", VA = "0x182184770")]
	public static EEIFDLIMEDC<T, U, V, W, X> INLOCBKJPHG(EEIFDLIMEDC<T, U, V, W, X> CGHHKPMLBKL, Action<T, U, V, W, X> COPPLLLOGLG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x21846E0", Offset = "0x2182EE0", VA = "0x1821846E0")]
	public static EEIFDLIMEDC<T, U, V, W, X> DBELBPPBBGP(EEIFDLIMEDC<T, U, V, W, X> CGHHKPMLBKL, Action<T, U, V, W, X> COPPLLLOGLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class AHEOONBPBAN<T, U, V, W, X, Y> : MJGMFHJNPGA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2186960", Offset = "0x2185160", VA = "0x182186960")]
	public AHEOONBPBAN(bool HAKLCEPNCNM = false, bool ABCJHKDGMEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8260", Offset = "0x2BA6A60", VA = "0x182BA8260")]
	public void MADELAMLLLM(T CIIALCPCBIG, U MOHKJMJAMIK, V LAEIDNKAKOO, W BBDFFBIEBJH, X FBGKLELIKCG, Y LFJEFFKGLOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2184770", Offset = "0x2182F70", VA = "0x182184770")]
	public static AHEOONBPBAN<T, U, V, W, X, Y> INLOCBKJPHG(AHEOONBPBAN<T, U, V, W, X, Y> CGHHKPMLBKL, Action<T, U, V, W, X, Y> COPPLLLOGLG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x21846E0", Offset = "0x2182EE0", VA = "0x1821846E0")]
	public static AHEOONBPBAN<T, U, V, W, X, Y> DBELBPPBBGP(AHEOONBPBAN<T, U, V, W, X, Y> CGHHKPMLBKL, Action<T, U, V, W, X, Y> COPPLLLOGLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct EAJGHKBENNK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GIOBMGLAFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int NIDCMEHBOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private int ANJGNPFDJFI;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x22E8D90", Offset = "0x22E7590", VA = "0x1822E8D90")]
	private EAJGHKBENNK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> ECJEHAIPFBH, int OHOHNAOEEAG, int BHMEJEMHABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D91B80", Offset = "0x2D90380", VA = "0x182D91B80")]
	public static EAJGHKBENNK<T> NKAIHPJAMOL()
	{
		return default(EAJGHKBENNK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D908F0", Offset = "0x2D8F0F0", VA = "0x182D908F0")]
	public (int, int, Task<T>) IEADPONMDFI(int LJCAAKGDCPF, [Optional] CancellationToken NNLBJPBEHPF, double MDHEGNJEGJG = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D91FB0", Offset = "0x2D907B0", VA = "0x182D91FB0")]
	public void PMIBCGOKOAG(int LJCAAKGDCPF, int BHMEJEMHABD, in T LACIMGIMLFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DOEILOHFBND
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A020", Offset = "0x6E08820", VA = "0x186E0A020")]
	public static EAJGHKBENNK<GADODCKGMOI> NKAIHPJAMOL()
	{
		return default(EAJGHKBENNK<GADODCKGMOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A070", Offset = "0x6E08870", VA = "0x186E0A070")]
	public static void PMIBCGOKOAG(this in EAJGHKBENNK<GADODCKGMOI> PECDBPPMOJP, int LJCAAKGDCPF, int BHMEJEMHABD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class CCKPCFBJMIL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<TKey, TVal> DCGLELLCFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Dictionary<TVal, TKey> BOGMKJJKKEG;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C5F220", Offset = "0x1C5DA20", VA = "0x181C5F220", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OAJKOPLILBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> JFPFNANLODO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x294DA80", Offset = "0x294C280", VA = "0x18294DA80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> FHOOMHGOKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x208DA20", Offset = "0x208C220", VA = "0x18208DA20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x294E6A0", Offset = "0x294CEA0", VA = "0x18294E6A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x294E710", Offset = "0x294CF10", VA = "0x18294E710", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x294DAF0", Offset = "0x294C2F0", VA = "0x18294DAF0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x294DE30", Offset = "0x294C630", VA = "0x18294DE30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x294E4B0", Offset = "0x294CCB0", VA = "0x18294E4B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x294DB60", Offset = "0x294C360", VA = "0x18294DB60", Slot = "9")]
	public void Add(TKey EECINICJCLK, TVal MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x294DBA0", Offset = "0x294C3A0", VA = "0x18294DBA0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> AMBKJGJJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x294DE90", Offset = "0x294C690", VA = "0x18294DE90", Slot = "8")]
	public bool ContainsKey(TKey EECINICJCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x294DEF0", Offset = "0x294C6F0", VA = "0x18294DEF0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> AMBKJGJJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x243CA90", Offset = "0x243B290", VA = "0x18243CA90", Slot = "10")]
	public bool Remove(TKey EECINICJCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x294E400", Offset = "0x294CC00", VA = "0x18294E400", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> AMBKJGJJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x294E550", Offset = "0x294CD50", VA = "0x18294E550", Slot = "11")]
	public bool TryGetValue(TKey EECINICJCLK, out TVal MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x294D7E0", Offset = "0x294BFE0", VA = "0x18294D7E0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x294DF20", Offset = "0x294C720", VA = "0x18294DF20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DLLMPOAIBGN, int NIPJDFBICLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x294DDF0", Offset = "0x294C5F0", VA = "0x18294DDF0")]
	public bool CBDOACFHBEA(TVal EECINICJCLK, out TKey MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x294DC10", Offset = "0x294C410", VA = "0x18294DC10")]
	private void BLGPMCOCADO(TKey EECINICJCLK, TVal BNMGNDJJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x294E360", Offset = "0x294CB60", VA = "0x18294E360")]
	private void KNIPCKPPALK(TKey EECINICJCLK, TVal BNMGNDJJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x294E040", Offset = "0x294C840", VA = "0x18294E040")]
	private bool FLKLJMLOEAM(TKey EECINICJCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x294E580", Offset = "0x294CD80", VA = "0x18294E580")]
	public CCKPCFBJMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DefaultMember("Item")]
public class LFCMJCJOKPC<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Func<Internal, External> BALILHNHLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private IReadOnlyList<Internal> DFMKDLJIHMN;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public External ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3172F60", Offset = "0x3171760", VA = "0x183172F60", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3172EB0", Offset = "0x31716B0", VA = "0x183172EB0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x18FBCA0", Offset = "0x18FA4A0", VA = "0x1818FBCA0")]
	public LFCMJCJOKPC(Func<Internal, External> BALILHNHLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3172E60", Offset = "0x3171660", VA = "0x183172E60")]
	public LFCMJCJOKPC(IReadOnlyList<Internal> DFMKDLJIHMN, Func<Internal, External> BALILHNHLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3172DF0", Offset = "0x31715F0", VA = "0x183172DF0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6870", Offset = "0x1FA5070", VA = "0x181FA6870", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AIPCCPPOHIA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate Task<TResult> AOHABFOMBOJ(TRequest AJNIDCPPJGC, CancellationToken NNLBJPBEHPF);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum AJGCGGHANMI
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class BMNGKLCIEJM
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const float CCJNGOOLCPA = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TimeSpan EAGBFPOADPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int MPLEFKOJIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AJGCGGHANMI JJIJCKKHCLK;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly BMNGKLCIEJM GDCPNJEFLGI;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float MNLNHOFAGGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x2710B80", Offset = "0x270F380", VA = "0x182710B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TimeSpan MDFINFAMFBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2710CD0", Offset = "0x270F4D0", VA = "0x182710CD0")]
		public BMNGKLCIEJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct JJLCIGJNMLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly TRequest AJNIDCPPJGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly CancellationToken NNLBJPBEHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly TaskCompletionSource<TResult> GMKLILNJJNF;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x27C6C70", Offset = "0x27C5470", VA = "0x1827C6C70")]
		public JJLCIGJNMLM(TRequest AJNIDCPPJGC, TaskCompletionSource<TResult> GMKLILNJJNF, CancellationToken NNLBJPBEHPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class BHLGOJEOCIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AIPCCPPOHIA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public BHLGOJEOCIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2198270", Offset = "0x2196A70", VA = "0x182198270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class ENBHJBOCJDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AIPCCPPOHIA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private JJLCIGJNMLM <req>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Task<TResult> <processTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private TResult <result>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TResult <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private OperationCanceledException <oce>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Exception <ex>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public ENBHJBOCJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2486320", Offset = "0x2484B20", VA = "0x182486320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly CancellationTokenSource AJNLANHABCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly List<JJLCIGJNMLM> PNGKJCPHMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly BMNGKLCIEJM GDKOAEHNLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly AOHABFOMBOJ LGHHJGEOHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private Task HLFNCGBANBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int ILKPJNOCJCL;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB63E0", Offset = "0x2BB4BE0", VA = "0x182BB63E0")]
	public AIPCCPPOHIA(AOHABFOMBOJ LGHHJGEOHJI, [Optional] BMNGKLCIEJM GDKOAEHNLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4900", Offset = "0x2BB3100", VA = "0x182BB4900")]
	public Task<TResult> CCGFLCIOMPK(TRequest AJNIDCPPJGC, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4730", Offset = "0x2BB2F30", VA = "0x182BB4730")]
	private void AAHKNHNCBMP(JJLCIGJNMLM FBJBJIHICCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5530", Offset = "0x2BB3D30", VA = "0x182BB5530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AIPCCPPOHIA<, >.BHLGOJEOCIB))]
	private Task NFKPPBAIJFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5B90", Offset = "0x2BB4390", VA = "0x182BB5B90")]
	private JJLCIGJNMLM PCNLHHJJMLN()
	{
		return default(JJLCIGJNMLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4EA0", Offset = "0x2BB36A0", VA = "0x182BB4EA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AIPCCPPOHIA<, >.ENBHJBOCJDD))]
	private Task GFLDBONKCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5EC0", Offset = "0x2BB46C0", VA = "0x182BB5EC0")]
	private void PEIHPLHLIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4E60", Offset = "0x2BB3660", VA = "0x182BB4E60", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x24A7A20", Offset = "0x24A6220", VA = "0x1824A7A20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D23D30", Offset = "0x6D22530", VA = "0x186D23D30")]
		public SerializedGuid(in Guid IBLFHKFALNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DBC0", Offset = "0x6E0C3C0", VA = "0x186E0DBC0")]
		public static SerializedGuid AOLENGGLIIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DCE0", Offset = "0x6E0C4E0", VA = "0x186E0DCE0")]
		public static SerializedGuid EAOHBHPKCBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DC50", Offset = "0x6E0C450", VA = "0x186E0DC50")]
		public bool BCALMCDLPAM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D23D00", Offset = "0x6D22500", VA = "0x186D23D00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DF00", Offset = "0x6E0C700", VA = "0x186E0DF00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DD70", Offset = "0x6E0C570", VA = "0x186E0DD70", Slot = "7")]
		public bool Equals(SerializedGuid OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DE20", Offset = "0x6E0C620", VA = "0x186E0DE20", Slot = "0")]
		public override bool Equals(object CEPDEAHBHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D23C50", Offset = "0x6D22450", VA = "0x186D23C50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D23A90", Offset = "0x6D22290", VA = "0x186D23A90", Slot = "6")]
		public int CompareTo(SerializedGuid OALEAAIPGBP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class PNGLEEEHECK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Type HOHHBHNIDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly string MHMPGNJOIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool MJNOJCCDMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool IILKBGHLFLN;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C770", Offset = "0x6E0AF70", VA = "0x186E0C770")]
	public PNGLEEEHECK(Type LLMNFFAJHJF, string BHFAEFLDECE, bool EMJICBEOAPF = false, bool EAHIKNNJOPA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[DefaultMember("Item")]
public class NAGLHKAABNO<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly List<T> DFMKDLJIHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private HashSet<T> PCOEPPKNGNA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1C5F220", Offset = "0x1C5DA20", VA = "0x181C5F220", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OAJKOPLILBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8A3C30", Offset = "0x8A2430", VA = "0x1808A3C30", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1F5F270", Offset = "0x1F5DA70", VA = "0x181F5F270", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2E369A0", Offset = "0x2E351A0", VA = "0x182E369A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x211BDB0", Offset = "0x211A5B0", VA = "0x18211BDB0", Slot = "11")]
	public void Add(T AMBKJGJJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2E364A0", Offset = "0x2E34CA0", VA = "0x182E364A0")]
	public bool KHFBCLPGPPL(T AMBKJGJJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2E36770", Offset = "0x2E34F70", VA = "0x182E36770", Slot = "15")]
	public bool Remove(T AMBKJGJJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2E361E0", Offset = "0x2E349E0", VA = "0x182E361E0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2710B50", Offset = "0x270F350", VA = "0x182710B50", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2E36150", Offset = "0x2E34950", VA = "0x182E36150", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2089420", Offset = "0x2087C20", VA = "0x182089420", Slot = "13")]
	public bool Contains(T AMBKJGJJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2E361B0", Offset = "0x2E349B0", VA = "0x182E361B0", Slot = "14")]
	public void CopyTo(T[] DLLMPOAIBGN, int NIPJDFBICLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x294E670", Offset = "0x294CE70", VA = "0x18294E670", Slot = "6")]
	public int IndexOf(T AMBKJGJJFNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2E36260", Offset = "0x2E34A60", VA = "0x182E36260", Slot = "7")]
	public void Insert(int AMOEKOMGDLG, T AMBKJGJJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2E36540", Offset = "0x2E34D40", VA = "0x182E36540", Slot = "8")]
	public void RemoveAt(int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2E367F0", Offset = "0x2E34FF0", VA = "0x182E367F0")]
	public NAGLHKAABNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LHDAPIPFPDA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A550", Offset = "0x6E08D50", VA = "0x186E0A550")]
	public LHDAPIPFPDA(string AKADEFDGONP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class EHPEPDODBBG
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A0F0", Offset = "0x6E088F0", VA = "0x186E0A0F0")]
	[NotNull]
	public static byte[] HANDGBKEBKL(this GLMPCJJDOLB OKIMKOPAHAB, HashAlgorithmName HDMPFOADMOE, byte[] CEHMHAFIAFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GLMPCJJDOLB
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash OBMLCMEKPMJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface MHOMABBFFOL : GLMPCJJDOLB
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[CanBeNull]
	byte[] JHDBKJBGFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	[CanBeNull]
	byte[] DMOMFCPAOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OLFGIOMMECD
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly ArrayPool<byte> CNOFNHLPABD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static bool NBBODBNJOEA;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AA60", Offset = "0x6E09260", VA = "0x186E0AA60")]
	public static void CBAIMCJJBIE(this IncrementalHash PJLNLIOKHNJ, [CanBeNull] GameObject OAOEKKJFJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2BFA780", Offset = "0x2BF8F80", VA = "0x182BFA780")]
	public static void CBAIMCJJBIE<T>(this IncrementalHash PJLNLIOKHNJ, [CanBeNull] T CAOCJIHJELH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2BFA850", Offset = "0x2BF9050", VA = "0x182BFA850")]
	public static void HJHFFBFDJEM<T>(this IncrementalHash PJLNLIOKHNJ, [CanBeNull] T OKIMKOPAHAB) where T : GLMPCJJDOLB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2BFA8E0", Offset = "0x2BF90E0", VA = "0x182BFA8E0")]
	public static void KGDOCMAFHHK<T>(this IncrementalHash PJLNLIOKHNJ, [CanBeNull] IList<T> OHKHCADEFLB) where T : GLMPCJJDOLB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AC20", Offset = "0x6E09420", VA = "0x186E0AC20")]
	private static bool EJPIPAKPCMJ([CanBeNull] GLMPCJJDOLB OKIMKOPAHAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A990", Offset = "0x6E09190", VA = "0x186E0A990")]
	public static void BIJAHGHPBGH(this IncrementalHash OBMLCMEKPMJ, [CanBeNull] string OAPFIHJPIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AE10", Offset = "0x6E09610", VA = "0x186E0AE10")]
	public static void HCCJNMFIGBP(this IncrementalHash OBMLCMEKPMJ, long HNKJCPPFGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AFE0", Offset = "0x6E097E0", VA = "0x186E0AFE0")]
	public static void HGJMOIBNKNK(this IncrementalHash OBMLCMEKPMJ, int JJDPJCIHODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B320", Offset = "0x6E09B20", VA = "0x186E0B320")]
	public static void MLGHCCDHJPC(this IncrementalHash OBMLCMEKPMJ, short LCAAAMCMCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B1B0", Offset = "0x6E099B0", VA = "0x186E0B1B0")]
	public static void LBLDCGGGKAD(this IncrementalHash OBMLCMEKPMJ, byte MBBLFMOKGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B4F0", Offset = "0x6E09CF0", VA = "0x186E0B4F0")]
	public static void NELPNDBNBLA(this IncrementalHash OBMLCMEKPMJ, bool EPCMBLNODAO, bool HCLPBAPLJLI = false, bool CCDHMLKFACC = false, bool FFKJHHGOPGB = false, bool PMACLMNJJCE = false, bool EFAHPJCAAPC = false, bool HAKBMJGJEEI = false, bool NIOAACNHLEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2BFAD30", Offset = "0x2BF9530", VA = "0x182BFAD30")]
	public static void OBEJHJDNGAK<T>(this IncrementalHash OBMLCMEKPMJ, T FANCHJFFEEE) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A930", Offset = "0x6E09130", VA = "0x186E0A930")]
	public static void BHLBPOGEFNG(this IncrementalHash OBMLCMEKPMJ, float AMJFGINHCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A9F0", Offset = "0x6E091F0", VA = "0x186E0A9F0")]
	public static void BOBBKKALMIJ(this IncrementalHash OBMLCMEKPMJ, ulong BOBGAENDLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AB50", Offset = "0x6E09350", VA = "0x186E0AB50")]
	public static void CMIBFCKIDEG(this IncrementalHash OBMLCMEKPMJ, uint CLIDJJFDFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6E0ABB0", Offset = "0x6E093B0", VA = "0x186E0ABB0")]
	public static void EGLPAJHEAGE(this IncrementalHash OBMLCMEKPMJ, ushort HEOFOPFFDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E0ACB0", Offset = "0x6E094B0", VA = "0x186E0ACB0")]
	public static void ELNDIGELDLC(this IncrementalHash OBMLCMEKPMJ, Vector3 OKIDMNHPPFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BHLCGBJCLKK
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E095A0", Offset = "0x6E07DA0", VA = "0x186E095A0")]
	[NotNull]
	public static byte[] HANDGBKEBKL(this MHOMABBFFOL DKKDLJCLCDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E09610", Offset = "0x6E07E10", VA = "0x186E09610")]
	[NotNull]
	public static byte[] HANDGBKEBKL(this MHOMABBFFOL DKKDLJCLCDM, HashAlgorithmName HDMPFOADMOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E09820", Offset = "0x6E08020", VA = "0x186E09820")]
	public static bool ILNFANFAIBE([CanBeNull] this MHOMABBFFOL DKKDLJCLCDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E09680", Offset = "0x6E07E80", VA = "0x186E09680")]
	public static bool ILNFANFAIBE([CanBeNull] this MHOMABBFFOL DKKDLJCLCDM, out string OABOGFOJNOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E099B0", Offset = "0x6E081B0", VA = "0x186E099B0")]
	private static bool KMHKFPOLFGL([NotNull] MHOMABBFFOL DKKDLJCLCDM, [CanBeNull] out byte[] BIKDHNPNOJE, [CanBeNull] out byte[] NPEDNKGMJCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class OEIGIGEMCKG<TTask, T> : NMAKHDNAMLE<T>, MLNMOGMEOOE, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HMAMLJMAOEO
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		private sealed class <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public HMAMLJMAOEO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x19556F0", Offset = "0x1953EF0", VA = "0x1819556F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public OEIGIGEMCKG<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public HMAMLJMAOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x3FA0940", Offset = "0x3F9F140", VA = "0x183FA0940")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(OEIGIGEMCKG<, >.HMAMLJMAOEO.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> CCDLBCJPKOM(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static bool AAAFFGIJHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Task<T> KOOMIGAFDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	protected readonly CancellationTokenSource EFIOOPGMKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool DGDBOBKJJDN;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Task<T> BHHOIJLGAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JJMNNLLBAJO<T> HHILEEBKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x951EF0", Offset = "0x9506F0", VA = "0x180951EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x21F3230", Offset = "0x21F1A30", VA = "0x1821F3230")]
	static OEIGIGEMCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x21F3700", Offset = "0x21F1F00", VA = "0x1821F3700")]
	protected OEIGIGEMCKG(TTask KOOMIGAFDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x21F31C0", Offset = "0x21F19C0", VA = "0x1821F31C0", Slot = "1")]
	~OEIGIGEMCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x21F2DF0", Offset = "0x21F15F0", VA = "0x1821F2DF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x21F2FF0", Offset = "0x21F17F0", VA = "0x1821F2FF0")]
	private void FEIFDLJJPLA(bool JGAGNNJIAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T FIGJPPLBEPE(TTask CBJLFGKEGEJ);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HPMGNPEIDAC();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BCHKPHMOOFA<T> : NMAKHDNAMLE<T>, MLNMOGMEOOE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Task<T> BHHOIJLGAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public JJMNNLLBAJO<T> HHILEEBKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2186990", Offset = "0x2185190", VA = "0x182186990")]
	public BCHKPHMOOFA(Exception BMGPOKGJALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface MLNMOGMEOOE : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface NMAKHDNAMLE<T> : MLNMOGMEOOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	[NotNull]
	Task<T> BHHOIJLGAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	JJMNNLLBAJO<T> HHILEEBKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class NGCECCPHAJP : OHHCKANGGNC<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A5C0", Offset = "0x6E08DC0", VA = "0x186E0A5C0")]
	public NGCECCPHAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class OHHCKANGGNC<T> : NMAKHDNAMLE<T>, MLNMOGMEOOE, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Task<T> BHHOIJLGAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public JJMNNLLBAJO<T> HHILEEBKNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x21FAE90", Offset = "0x21F9690", VA = "0x1821FAE90")]
	public OHHCKANGGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public sealed class BDOLGIFCNLA : CINMLNOINGA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class CNEAAHOFFEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action<BDOLGIFCNLA, JNGNMMOLKFF> callback;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public CNEAAHOFFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6E09EE0", Offset = "0x6E086E0", VA = "0x186E09EE0")]
		internal void EMHBPALPDPB(CINMLNOINGA<string> timer, JNGNMMOLKFF log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6E09440", Offset = "0x6E07C40", VA = "0x186E09440")]
	public BDOLGIFCNLA(JNGNMMOLKFF MBNJNNGOKFP, [Optional] string FPPCBOPEDNO, [Optional] int? KCCCNOGEMOF, [Optional] Stopwatch EAAMKHNFGMG, [Optional] Action<string, LBICACCNAMJ, JNGNMMOLKFF> CNLOLODJEPA, [Optional] Action<string, LBICACCNAMJ, JNGNMMOLKFF> AOBODNJIDIK, [Optional] Action<BDOLGIFCNLA, JNGNMMOLKFF> BMPPBENNJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6E09360", Offset = "0x6E07B60", VA = "0x186E09360")]
	private static Action<CINMLNOINGA<string>, JNGNMMOLKFF> BHCKFOGIDJB(Action<BDOLGIFCNLA, JNGNMMOLKFF> JJFOLBCEJBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GFPEPMABEKO<TKey> : EBPNFFKDPIB<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate string CBLCFIJJFPJ(TKey EECINICJCLK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly string OKLDIEHELBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly double GCDBHMFPCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly bool HJMBLEANDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int JIFNMGDKHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly ISet<string> FHOAPMJIJJO;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2782410", Offset = "0x2780C10", VA = "0x182782410")]
	private static string DKJFGPADKPD(TKey EECINICJCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2782640", Offset = "0x2780E40", VA = "0x182782640")]
	public GFPEPMABEKO(string OKLDIEHELBP = "F2", double GCDBHMFPCLB = double.MaxValue, bool HJMBLEANDDJ = false, int JIFNMGDKHAC = int.MaxValue, [Optional] ISet<string> FHOAPMJIJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2781C70", Offset = "0x2780470", VA = "0x182781C70", Slot = "4")]
	public override Dictionary<string, string> AIEGBKFCHBG(CINMLNOINGA<TKey> FMGNKDAMMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2782450", Offset = "0x2780C50", VA = "0x182782450")]
	private bool EGJLMHMMACF(string LAKHBCAAEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2781D20", Offset = "0x2780520", VA = "0x182781D20")]
	public Dictionary<string, string> AIEGBKFCHBG(CINMLNOINGA<TKey> FMGNKDAMMIM, CBLCFIJJFPJ AFGHKFMPEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2782260", Offset = "0x2780A60", VA = "0x182782260")]
	private string DGFEOPMHOAO(StringBuilder MDHCHEGFMDN, List<TKey> KCOHCAPCODP, CBLCFIJJFPJ AFGHKFMPEDJ, bool DOKFEAPNHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x27824C0", Offset = "0x2780CC0", VA = "0x1827824C0")]
	private static void FDLKEGHMGFH(StringBuilder OEGJEFODMEH, string PFJDDCHNPBB, bool CKEPFKCBCJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class EBPNFFKDPIB<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut AIEGBKFCHBG(CINMLNOINGA<TKey> FMGNKDAMMIM);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
	protected EBPNFFKDPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class ECELIAMKKOO<TKey> : EBPNFFKDPIB<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public delegate string BLNKAHEIMDC(TKey EECINICJCLK);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2D981D0", Offset = "0x2D969D0", VA = "0x182D981D0")]
	private static string DKJFGPADKPD(TKey EECINICJCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2D98120", Offset = "0x2D96920", VA = "0x182D98120", Slot = "4")]
	public override string AIEGBKFCHBG(CINMLNOINGA<TKey> FMGNKDAMMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2D97FF0", Offset = "0x2D967F0", VA = "0x182D97FF0")]
	public string AIEGBKFCHBG(CINMLNOINGA<TKey> FMGNKDAMMIM, [NotNull] BLNKAHEIMDC AFGHKFMPEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DEPHCKJAFDE(CINMLNOINGA<TKey> FMGNKDAMMIM, [NotNull] BLNKAHEIMDC AFGHKFMPEDJ);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x21F1B60", Offset = "0x21F0360", VA = "0x1821F1B60")]
	protected ECELIAMKKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class CGFAEPMEIJN<TKey> : ECELIAMKKOO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct GPCKEOLCNBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public BLNKAHEIMDC keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static CGFAEPMEIJN<TKey> OEFAOPMNMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly string[] JBKGFBJBFGM;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2956B60", Offset = "0x2955360", VA = "0x182956B60")]
	private CGFAEPMEIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2955AB0", Offset = "0x29542B0", VA = "0x182955AB0", Slot = "5")]
	protected override string DEPHCKJAFDE(CINMLNOINGA<TKey> FMGNKDAMMIM, BLNKAHEIMDC AFGHKFMPEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2956980", Offset = "0x2955180", VA = "0x182956980")]
	[CompilerGenerated]
	internal static string KJMNDHEAHAD(string HGOGPNLNDAB, TKey EECINICJCLK, ref GPCKEOLCNBE P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CINMLNOINGA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct LBICACCNAMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly long CBMCKBIFJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly long INOKDDCLIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly int KCCCNOGEMOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly int PBNNDEHBADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly bool IBNPKGNIILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly string KEJMOMJJABN;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x24D02F0", Offset = "0x24CEAF0", VA = "0x1824D02F0")]
		public LBICACCNAMJ(long CBMCKBIFJFO, int KCCCNOGEMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x24D02C0", Offset = "0x24CEAC0", VA = "0x1824D02C0")]
		public LBICACCNAMJ(long CBMCKBIFJFO, long INOKDDCLIEJ, int KCCCNOGEMOF, int PBNNDEHBADF, bool IBNPKGNIILI, string KEJMOMJJABN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x24D0120", Offset = "0x24CE920", VA = "0x1824D0120")]
		public int AKMECMPFEBD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x24D0170", Offset = "0x24CE970", VA = "0x1824D0170")]
		public int IKBAOEGBPJD(int PPJHDJJIOLK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x24D0190", Offset = "0x24CE990", VA = "0x1824D0190")]
		public double OGIPMBBAPAN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x24D0200", Offset = "0x24CEA00", VA = "0x1824D0200")]
		public LBICACCNAMJ PEEIDPJPMAA(long INOKDDCLIEJ, int PBNNDEHBADF)
		{
			return default(LBICACCNAMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class BIMPMJLMAHG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class GLDIACIGJOI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public Func<BIMPMJLMAHG, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public BIMPMJLMAHG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private BIMPMJLMAHG <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
			public GLDIACIGJOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x208AA30", Offset = "0x2089230", VA = "0x18208AA30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly TKey ADLHPEIHCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CINMLNOINGA<TKey> FMGNKDAMMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly JNGNMMOLKFF MBNJNNGOKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private List<BIMPMJLMAHG> KGIHOMCJGOL;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public string JFFOEGCCEJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x219CD20", Offset = "0x219B520", VA = "0x18219CD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public IEnumerable<BIMPMJLMAHG> LIHHNICJHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x219CF20", Offset = "0x219B720", VA = "0x18219CF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public LBICACCNAMJ GGNPJFKBBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x219CF00", Offset = "0x219B700", VA = "0x18219CF00")]
			[CompilerGenerated]
			get
			{
				return default(LBICACCNAMJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x219D090", Offset = "0x219B890", VA = "0x18219D090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x219D0C0", Offset = "0x219B8C0", VA = "0x18219D0C0")]
		internal BIMPMJLMAHG(CINMLNOINGA<TKey> FMGNKDAMMIM, TKey EECINICJCLK, JNGNMMOLKFF MBNJNNGOKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x219CF40", Offset = "0x219B740", VA = "0x18219CF40")]
		public BIMPMJLMAHG NDMIEAGELND(TKey EECINICJCLK, [Optional] JNGNMMOLKFF? OIKNJGKAPJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1F59900", Offset = "0x1F58100", VA = "0x181F59900")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(GLDIACIGJOI<>))]
		public Task<T> ELNAJDADKLF<T>(TKey EECINICJCLK, Func<BIMPMJLMAHG, Task<T>> FJNHKBBJCJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x219CD50", Offset = "0x219B550", VA = "0x18219CD50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class OEBAHKIDFBE : IEnumerable<(TKey, List<TKey>, LBICACCNAMJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LBICACCNAMJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private (TKey key, List<TKey> path, LBICACCNAMJ timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CINMLNOINGA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerator<(TKey key, List<TKey> path, LBICACCNAMJ timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private (TKey key, List<TKey> path, LBICACCNAMJ timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private (TKey, List<TKey>, LBICACCNAMJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x21F21F0", Offset = "0x21F09F0", VA = "0x1821F21F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LBICACCNAMJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x21F2260", Offset = "0x21F0A60", VA = "0x1821F2260", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x21F22C0", Offset = "0x21F0AC0", VA = "0x1821F22C0")]
		[DebuggerHidden]
		public OEBAHKIDFBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x211B430", Offset = "0x2119C30", VA = "0x18211B430", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x21F1D40", Offset = "0x21F0540", VA = "0x1821F1D40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x21F2070", Offset = "0x21F0870", VA = "0x1821F2070")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x21F2220", Offset = "0x21F0A20", VA = "0x1821F2220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x21F2130", Offset = "0x21F0930", VA = "0x1821F2130", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LBICACCNAMJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1AAB720", Offset = "0x1AA9F20", VA = "0x181AAB720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class MNBIMDELCHH : IEnumerable<(TKey, List<TKey>, LBICACCNAMJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LBICACCNAMJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private (TKey key, List<TKey> path, LBICACCNAMJ timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private BIMPMJLMAHG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public BIMPMJLMAHG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CINMLNOINGA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private IEnumerator<BIMPMJLMAHG> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private BIMPMJLMAHG <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IEnumerator<(TKey key, List<TKey> path, LBICACCNAMJ timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private (TKey key, List<TKey> path, LBICACCNAMJ timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private (TKey, List<TKey>, LBICACCNAMJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x21F21F0", Offset = "0x21F09F0", VA = "0x1821F21F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LBICACCNAMJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x23BD300", Offset = "0x23BBB00", VA = "0x1823BD300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x21F22C0", Offset = "0x21F0AC0", VA = "0x1821F22C0")]
		[DebuggerHidden]
		public MNBIMDELCHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x23BD360", Offset = "0x23BBB60", VA = "0x1823BD360", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x23BCAE0", Offset = "0x23BB2E0", VA = "0x1823BCAE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x23BD150", Offset = "0x23BB950", VA = "0x1823BD150")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x23BD0F0", Offset = "0x23BB8F0", VA = "0x1823BD0F0")]
		private void OFDJPHBKOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x23BD2C0", Offset = "0x23BBAC0", VA = "0x1823BD2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x23BD1B0", Offset = "0x23BB9B0", VA = "0x1823BD1B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LBICACCNAMJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x23BD290", Offset = "0x23BBA90", VA = "0x1823BD290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Action<TKey, LBICACCNAMJ, JNGNMMOLKFF> CNLOLODJEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Action<TKey, LBICACCNAMJ, JNGNMMOLKFF> AOBODNJIDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Action<CINMLNOINGA<TKey>, JNGNMMOLKFF> BMPPBENNJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly BIMPMJLMAHG GIMBHCMONEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool DGDBOBKJJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private int LGGDFALFECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Stopwatch EAAMKHNFGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly int HNDMHPMMMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private string KCEJMALBBKN;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BIMPMJLMAHG OHNJKFFEICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	public string JFFOEGCCEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x243CF00", Offset = "0x243B700", VA = "0x18243CF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x243D1D0", Offset = "0x243B9D0", VA = "0x18243D1D0")]
	public CINMLNOINGA(TKey GBEDPOCCOFA, JNGNMMOLKFF MBNJNNGOKFP, [Optional] int? KCCCNOGEMOF, [Optional][CanBeNull] Stopwatch EAAMKHNFGMG, [Optional] Action<TKey, LBICACCNAMJ, JNGNMMOLKFF> CNLOLODJEPA, [Optional] Action<TKey, LBICACCNAMJ, JNGNMMOLKFF> AOBODNJIDIK, [Optional] Action<CINMLNOINGA<TKey>, JNGNMMOLKFF> BMPPBENNJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x243CF60", Offset = "0x243B760", VA = "0x18243CF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x243D070", Offset = "0x243B870", VA = "0x18243D070")]
	[IteratorStateMachine(typeof(CINMLNOINGA<>.OEBAHKIDFBE))]
	public IEnumerable<(TKey, List<TKey>, LBICACCNAMJ)> NEBDOGMHFIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x243D100", Offset = "0x243B900", VA = "0x18243D100")]
	[IteratorStateMachine(typeof(CINMLNOINGA<>.MNBIMDELCHH))]
	private IEnumerable<(TKey, List<TKey>, LBICACCNAMJ)> NEBDOGMHFIB(List<TKey> NFJIPFJDKNL, BIMPMJLMAHG LALDEOFDMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x243CFF0", Offset = "0x243B7F0", VA = "0x18243CFF0")]
	private (long, int) FIAOEFDLJJL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PKFODIICJDI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Dictionary<byte, BPBHDNBAPOP> BIGKAKFNGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly KBAIBLKMDFI<BPBHDNBAPOP> GJGGOIPDGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly bool MILABFDOBPA;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BPBHDNBAPOP FNBDJIHDELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Vector2 NGILCCFPCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xF221C0", Offset = "0xF209C0", VA = "0x180F221C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1154060", Offset = "0x1152860", VA = "0x181154060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private Vector2 CHCMIPDIDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xAE54A0", Offset = "0xAE3CA0", VA = "0x180AE54A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Vector2 EIIAGBJLNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BF10", Offset = "0x6E0A710", VA = "0x186E0BF10")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xAE54D0", Offset = "0xAE3CD0", VA = "0x180AE54D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int JJCPLMHOLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B70", Offset = "0x8E7370", VA = "0x1808E8B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xBBF230", Offset = "0xBBDA30", VA = "0x180BBF230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C200", Offset = "0x6E0AA00", VA = "0x186E0C200")]
	public PKFODIICJDI(Bounds HLMOMHCGDKC, Vector2[] JFIAKCADOJF, int FALJJNGLDJF, byte ODFELLLMBAO, float OGJBAKGBKHB = 0f, [Optional] KBAIBLKMDFI<BPBHDNBAPOP> GJGGOIPDGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BA20", Offset = "0x6E0A220", VA = "0x186E0BA20")]
	public BPBHDNBAPOP JMKLGKKHLIO(byte AMOEKOMGDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C130", Offset = "0x6E0A930", VA = "0x186E0C130")]
	public void OKJDFJHNBED(Vector3 PAOMABBDKAH, float IPDCONIDAJI, float MJGIKHDOAFN, ref List<byte> LKIJMELIEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B7C0", Offset = "0x6E09FC0", VA = "0x186E0B7C0")]
	public void BOPFCLGBKAB(BPBHDNBAPOP.AJODKMNHCKI HMFBLGEKCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BE60", Offset = "0x6E0A660", VA = "0x186E0BE60")]
	public static int KHLEMNMDHDP(Vector2[] JFIAKCADOJF, int FALJJNGLDJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B7E0", Offset = "0x6E09FE0", VA = "0x186E0B7E0")]
	private BPBHDNBAPOP DOEEAJMGLDI(byte AMOEKOMGDLG, BPBHDNBAPOP.CALPNMDNHDC JKCJGACANEJ, BPBHDNBAPOP GJPBCFJDGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BA80", Offset = "0x6E0A280", VA = "0x186E0BA80")]
	private void KDOFIBIEABK(BPBHDNBAPOP GJPBCFJDGCH, Vector2[] JFIAKCADOJF, int FJHFJDDDMJB, int GPCPPNEDCBD, int JEJKDLDPALP, int HIMNGDNKIHM, float OGJBAKGBKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BF30", Offset = "0x6E0A730", VA = "0x186E0BF30")]
	private void NFJGHJOPKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B970", Offset = "0x6E0A170", VA = "0x186E0B970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B9D0", Offset = "0x6E0A1D0", VA = "0x186E0B9D0", Slot = "1")]
	~PKFODIICJDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class BPBHDNBAPOP
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public enum CALPNMDNHDC
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum AJODKMNHCKI
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public byte LFODACJMPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Vector3 HOAMNAPFJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3 EFKFFCAGHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Vector3 GPOIDKDOLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Vector3 NAKLFFIJDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public CALPNMDNHDC EHPNBCNLBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public BPBHDNBAPOP PCBLKPOAMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<BPBHDNBAPOP> EIPEDNMLFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool FEPENKJFBPF;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E09EC0", Offset = "0x6E086C0", VA = "0x186E09EC0")]
	public BPBHDNBAPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6E09BD0", Offset = "0x6E083D0", VA = "0x186E09BD0")]
	public void IFGNKHDPNPM(BPBHDNBAPOP CICDHHEGIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	public void BOPFCLGBKAB(int NLFHDLPJDJE, AJODKMNHCKI HMFBLGEKCDH, int PPPEIODGPMH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E09C90", Offset = "0x6E08490", VA = "0x186E09C90")]
	public void OKJDFJHNBED(List<byte> LKIJMELIEJP, Vector3 PAOMABBDKAH, float IPDCONIDAJI, float MJGIKHDOAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E09B80", Offset = "0x6E08380", VA = "0x186E09B80")]
	public bool ENENNKLMACD(Vector3 PKBCOAILGDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E09B50", Offset = "0x6E08350", VA = "0x186E09B50")]
	public bool DICDPAAAPPE(Vector3 PKBCOAILGDK, float NIDFOMKNDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E09AD0", Offset = "0x6E082D0", VA = "0x186E09AD0")]
	public void BDCEDMLOOPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KBAIBLKMDFI<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Stack<T> BGGGEBEJGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly List<T> CCNBGJJAHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly int CLFPDPADPJM;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3059C40", Offset = "0x3058440", VA = "0x183059C40")]
	public static KBAIBLKMDFI<T> GICHFFBKLGC(int LNKEFEELODK = 0, int CLFPDPADPJM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x305A0A0", Offset = "0x30588A0", VA = "0x18305A0A0")]
	public KBAIBLKMDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3059F10", Offset = "0x3058710", VA = "0x183059F10")]
	public KBAIBLKMDFI(int LNKEFEELODK, int CLFPDPADPJM = int.MaxValue, bool BDIHPKGJNMM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3059E00", Offset = "0x3058600", VA = "0x183059E00")]
	public T PPBDMLEBJHI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x30598A0", Offset = "0x30580A0", VA = "0x1830598A0")]
	public void CEEMIOIEFPP(T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3059D30", Offset = "0x3058530", VA = "0x183059D30")]
	private void PHJBGECPMPG(T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3059D10", Offset = "0x3058510", VA = "0x183059D10")]
	private void KHJJHNAIBPO(T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3059940", Offset = "0x3058140", VA = "0x183059940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3059A30", Offset = "0x3058230", VA = "0x183059A30")]
	private void FMFIFMMNAMP(IEnumerable<T> ONNFNOJDECI)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x283F2C0", Offset = "0x283DAC0", VA = "0x18283F2C0", Slot = "4")]
		public virtual T OCDHAOMIICD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class DCFEJDBMOEN<T> : IEnumerable<DCFEJDBMOEN<T>.OMCNOHACLIP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct OMCNOHACLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public T MENBIMCLIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int AMOEKOMGDLG;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class LCLFBMNNADB : IEnumerator<OMCNOHACLIP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private DCFEJDBMOEN<T> HEIOLDOFBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int AMOEKOMGDLG;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xC35E50", Offset = "0xC34650", VA = "0x180C35E50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public OMCNOHACLIP PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x24D4DF0", Offset = "0x24D35F0", VA = "0x1824D4DF0", Slot = "4")]
			get
			{
				return default(OMCNOHACLIP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x24D4DB0", Offset = "0x24D35B0", VA = "0x1824D4DB0")]
		public LCLFBMNNADB(DCFEJDBMOEN<T> HEIOLDOFBJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x24D4D20", Offset = "0x24D3520", VA = "0x1824D4D20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x24D4DA0", Offset = "0x24D35A0", VA = "0x1824D4DA0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x979010", Offset = "0x977810", VA = "0x180979010", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private struct KKHNICGHCPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public bool PEDMJBPJIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public T MENBIMCLIOI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private const int KBPCFEOCELA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Dictionary<T, int> PHHJCIHLNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private KKHNICGHCPD[] KIMCNOFPLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int GBGPEAKFAJD;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int MEFPPDNBOML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xB7C7C0", Offset = "0xB7AFC0", VA = "0x180B7C7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xF6D980", Offset = "0xF6C180", VA = "0x180F6D980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1C5F220", Offset = "0x1C5DA20", VA = "0x181C5F220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2408710", Offset = "0x2406F10", VA = "0x182408710")]
	public DCFEJDBMOEN(int LNKEFEELODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2408320", Offset = "0x2406B20", VA = "0x182408320")]
	public DCFEJDBMOEN(OMCNOHACLIP[] DBBFLENDKPJ, bool AOFEMOAEKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2407C80", Offset = "0x2406480", VA = "0x182407C80")]
	public int JGLMKNDKDBH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2407870", Offset = "0x2406070", VA = "0x182407870")]
	private int ILPEKOLKIJB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2407820", Offset = "0x2406020", VA = "0x182407820", Slot = "6")]
	protected virtual uint GBCLAEBIHBA(uint OBMLCMEKPMJ, T MENBIMCLIOI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2407C40", Offset = "0x2406440", VA = "0x182407C40")]
	public bool INGPOKBKKKP(T MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2408240", Offset = "0x2406A40", VA = "0x182408240")]
	public int PGCPIIFHDDI(T MENBIMCLIOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x24077A0", Offset = "0x2405FA0", VA = "0x1824077A0")]
	public T CANLNBNDEBD(int AMOEKOMGDLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2407CF0", Offset = "0x24064F0", VA = "0x182407CF0")]
	public bool KHFBCLPGPPL(T MENBIMCLIOI, bool JBJGJCDPOLL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2407F30", Offset = "0x2406730", VA = "0x182407F30")]
	public bool KHFBCLPGPPL(T MENBIMCLIOI, int AMOEKOMGDLG, bool JBJGJCDPOLL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x24081A0", Offset = "0x24069A0", VA = "0x1824081A0")]
	private int OFHJFDLFLIB(int ODFELLLMBAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x24082A0", Offset = "0x2406AA0", VA = "0x1824082A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x24082A0", Offset = "0x2406AA0", VA = "0x1824082A0", Slot = "4")]
	private IEnumerator<OMCNOHACLIP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		[DOJBOPNDCNN(OBCONDONEKN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6E0C8D0", Offset = "0x6E0B0D0", VA = "0x186E0C8D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6E0CB60", Offset = "0x6E0B360", VA = "0x186E0CB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6E0CA90", Offset = "0x6E0B290", VA = "0x186E0CA90")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x6E0C840", Offset = "0x6E0B040", VA = "0x186E0C840")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6E0CAD0", Offset = "0x6E0B2D0", VA = "0x186E0CAD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6E0CA00", Offset = "0x6E0B200", VA = "0x186E0CA00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C7E0", Offset = "0x6E0AFE0", VA = "0x186E0C7E0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PDOFAHGAOOO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int LNKEFEELODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int GIFCOANBAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private List<T> BODGCAEFMPH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x18FCEF0", Offset = "0x18FB6F0", VA = "0x1818FCEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public T HKNPIAMEEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x21A5070", Offset = "0x21A3870", VA = "0x1821A5070")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public T BNBLLAPDBBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x21A5300", Offset = "0x21A3B00", VA = "0x1821A5300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T EFHOAGAIAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x21A53B0", Offset = "0x21A3BB0", VA = "0x1821A53B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x21A5500", Offset = "0x21A3D00", VA = "0x1821A5500")]
	public PDOFAHGAOOO(int LNKEFEELODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x21A5110", Offset = "0x21A3910", VA = "0x1821A5110")]
	public void GLILACFFLBJ(T DHLOEHOBPFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x21A4FB0", Offset = "0x21A37B0", VA = "0x1821A4FB0")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x21A5460", Offset = "0x21A3C60", VA = "0x1821A5460")]
	public void MIKNHMPLOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x21A5360", Offset = "0x21A3B60", VA = "0x1821A5360")]
	public void ILGIAPKIFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x21A5100", Offset = "0x21A3900", VA = "0x1821A5100")]
	public void GDHPPOHDCPI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public struct LLBAPFMICGP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly List<Component> DFMKDLJIHMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly bool IKKKMEBEPJE;

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x1AAFE90", Offset = "0x1AAE690", VA = "0x181AAFE90")]
			public LLBAPFMICGP(List<Component> DFMKDLJIHMN, bool IKKKMEBEPJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2074A00", Offset = "0x2073200", VA = "0x182074A00")]
			public BODHMANGFIG<T> GAACJCPNEFN()
			{
				return default(BODHMANGFIG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2074A70", Offset = "0x2073270", VA = "0x182074A70", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2074A70", Offset = "0x2073270", VA = "0x182074A70", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public struct BODHMANGFIG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private readonly List<Component> DFMKDLJIHMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private readonly bool IKKKMEBEPJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private int AMOEKOMGDLG;

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public T PDEEINOIIEF
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x271E960", Offset = "0x271D160", VA = "0x18271E960", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x271E8F0", Offset = "0x271D0F0", VA = "0x18271E8F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x271E930", Offset = "0x271D130", VA = "0x18271E930")]
			public BODHMANGFIG(List<Component> DFMKDLJIHMN, bool IKKKMEBEPJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x271E810", Offset = "0x271D010", VA = "0x18271E810", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x271E820", Offset = "0x271D020", VA = "0x18271E820", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x271E8E0", Offset = "0x271D0E0", VA = "0x18271E8E0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0DFA0", Offset = "0x6E0C7A0", VA = "0x186E0DFA0")]
		private void BDCEDMLOOPD(GameObject HBPFJCNENNP, bool BJDJJEPMPIM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E110", Offset = "0x6E0C910", VA = "0x186E0E110")]
		public static void BDCEDMLOOPD(GameObject HBPFJCNENNP, ref ToolHierarchyCache LOEBLGMOKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1AEFA30", Offset = "0x1AEE230", VA = "0x181AEFA30")]
		public void HKNIPBHCOIA<T>(Action<T> COPPLLLOGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1AEFD90", Offset = "0x1AEE590", VA = "0x181AEFD90")]
		public T LAGHMLKGBAD<T>(bool IKKKMEBEPJE = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1AEFCC0", Offset = "0x1AEE4C0", VA = "0x181AEFCC0")]
		public LLBAPFMICGP<T> KGFFKECMKLB<T>(bool IKKKMEBEPJE = false) where T : class
		{
			return default(LLBAPFMICGP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E3C0", Offset = "0x6E0CBC0", VA = "0x186E0E3C0")]
		public List<Component> OBEEFPJLAPH(Type EIOLDDJPDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E2C0", Offset = "0x6E0CAC0", VA = "0x186E0E2C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FBGKLELIKCG, ToolHierarchyCache LFJEFFKGLOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0E340", Offset = "0x6E0CB40", VA = "0x186E0E340", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CEPDEAHBHLF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CPNBNNMDNBH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Dictionary<int, T> DFAKGEGFEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private T BOLEICNPIFH;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T LMKOEENGMJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xA48BE0", Offset = "0xA473E0", VA = "0x180A48BE0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2447AD0", Offset = "0x24462D0", VA = "0x182447AD0")]
	public bool CIAGOAJLCNF(T MENBIMCLIOI, int IOJGIALNGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x24480F0", Offset = "0x24468F0", VA = "0x1824480F0")]
	public bool OIMLKAJCHAC(int IOJGIALNGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2447EF0", Offset = "0x24466F0", VA = "0x182447EF0")]
	public T NCDKIEHGJAP(int OMLMICKMMLN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2447B30", Offset = "0x2446330", VA = "0x182447B30")]
	private bool EPCOKMJGDIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2447A40", Offset = "0x2446240", VA = "0x182447A40")]
	public bool CBDOACFHBEA(int IOJGIALNGIJ, out T MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2448150", Offset = "0x2446950", VA = "0x182448150")]
	public CPNBNNMDNBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class MJLOFEBLGND<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class IPGHMKFPMAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TNode PECDBPPMOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public TNode GJPBCFJDGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public JAAKCKHGHCJ IGMMIIIPDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<JAAKCKHGHCJ> LGOAAHFCEGN;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public IPGHMKFPMAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct JAAKCKHGHCJ : IComparable<JAAKCKHGHCJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int IOJGIALNGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public TClaimant LODAAEFIPHK;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCB4DA0", Offset = "0xCB35A0", VA = "0x180CB4DA0")]
		public JAAKCKHGHCJ(int IOJGIALNGIJ, TClaimant LODAAEFIPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x369D910", Offset = "0x369C110", VA = "0x18369D910")]
		public bool EEGLGKEDLNG(in JAAKCKHGHCJ OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x369D970", Offset = "0x369C170", VA = "0x18369D970")]
		public bool GNKLPLKKICC(in JAAKCKHGHCJ OALEAAIPGBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x369D900", Offset = "0x369C100", VA = "0x18369D900", Slot = "4")]
		public int CompareTo(JAAKCKHGHCJ OALEAAIPGBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x369D980", Offset = "0x369C180", VA = "0x18369D980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum OKBKHELHAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class LKAOJFACEJK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public MJLOFEBLGND<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2073B20", Offset = "0x2072320", VA = "0x182073B20")]
		[DebuggerHidden]
		public LKAOJFACEJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x20738E0", Offset = "0x20720E0", VA = "0x1820738E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2073AE0", Offset = "0x20722E0", VA = "0x182073AE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x20739D0", Offset = "0x20721D0", VA = "0x1820739D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2073AB0", Offset = "0x20722B0", VA = "0x182073AB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly KBAIBLKMDFI<IPGHMKFPMAG> PCOCBMFEGPP;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly KBAIBLKMDFI<List<JAAKCKHGHCJ>> CEFNJDAEIPJ;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int KMBAIMBKLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	internal readonly Dictionary<TClaimant, TNode> CIJFGIMEMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal readonly Dictionary<TNode, IPGHMKFPMAG> HJAEMOFKCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private OKBKHELHAGJ EDGJKPJHBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool PMADFOMNIPK;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DFDIEMMHEBB(TNode LJMPFLMBPKN);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void FJAPGLJAPHD(TNode LJMPFLMBPKN, TClaimant CGNPPIDDGFO, TClaimant BIDIILJNHNF);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x23AA710", Offset = "0x23A8F10", VA = "0x1823AA710")]
	public MJLOFEBLGND(OKBKHELHAGJ EDGJKPJHBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x23A9A00", Offset = "0x23A8200", VA = "0x1823A9A00")]
	public void ENIHADCIKIN(TNode LJMPFLMBPKN, TNode ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x23A9740", Offset = "0x23A7F40", VA = "0x1823A9740")]
	public void EAJCJGABBBK(TClaimant LODAAEFIPHK, TNode JABAMLAKCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x23A94E0", Offset = "0x23A7CE0", VA = "0x1823A94E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x23A9F50", Offset = "0x23A8750", VA = "0x1823A9F50")]
	private void IKBMDMPPEGH(TClaimant LODAAEFIPHK, TNode LKCGNLFEFPK, TNode JABAMLAKCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x23A9A80", Offset = "0x23A8280", VA = "0x1823A9A80")]
	private int HAGJIHCLDLP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x23A9C00", Offset = "0x23A8400", VA = "0x1823A9C00")]
	private void IJDEOGLKEIC(TClaimant LODAAEFIPHK, TNode IBAIDLIOHDE, TNode IKDGFEDODNH, int ELFNNGMBFJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x23A9EC0", Offset = "0x23A86C0", VA = "0x1823A9EC0")]
	private void IJLMMGDBDCD(JAAKCKHGHCJ OGMBKMAHILI, IPGHMKFPMAG NDOKJJDGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x23AA100", Offset = "0x23A8900", VA = "0x1823AA100")]
	private void KAKIMHIHFGN(TClaimant LODAAEFIPHK, TNode IBAIDLIOHDE, TNode IKDGFEDODNH, int ELFNNGMBFJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x23A9FF0", Offset = "0x23A87F0", VA = "0x1823A9FF0")]
	private void JODKDDLNGIF(JAAKCKHGHCJ OGMBKMAHILI, TNode LJMPFLMBPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x23A93E0", Offset = "0x23A7BE0", VA = "0x1823A93E0")]
	private void DCEFOBLGBEG(JAAKCKHGHCJ OGMBKMAHILI, IPGHMKFPMAG NDOKJJDGKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x23A9AE0", Offset = "0x23A82E0", VA = "0x1823A9AE0")]
	private void HEGMPOIKKPC(IPGHMKFPMAG NDOKJJDGKBP, bool AHOCMDLKLOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x23A9010", Offset = "0x23A7810", VA = "0x1823A9010")]
	private void BGCMAMGGGDD(IPGHMKFPMAG NDOKJJDGKBP, TNode ILLDOGNGNOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x23A8F40", Offset = "0x23A7740", VA = "0x1823A8F40")]
	[IteratorStateMachine(typeof(MJLOFEBLGND<, >.LKAOJFACEJK))]
	private IEnumerable<TNode> ACILFHKDNDI(TNode IBAIDLIOHDE, TNode IKDGFEDODNH, bool HDLOMPAJPPB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x23AA360", Offset = "0x23A8B60", VA = "0x1823AA360")]
	private IPGHMKFPMAG OGJIKCKMAII(TNode LJMPFLMBPKN, TNode GJPBCFJDGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x23AA420", Offset = "0x23A8C20", VA = "0x1823AA420")]
	private IPGHMKFPMAG PDGJDBLHGNN(TNode LJMPFLMBPKN, TNode GJPBCFJDGCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x23A9840", Offset = "0x23A8040", VA = "0x1823A9840")]
	private void EGPHAJMPBJB(IPGHMKFPMAG NDOKJJDGKBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class IPGAEAEJJLB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	protected struct MEAHIOLGGIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public T PGHJLABHLGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int PMIPHMBCIBE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	protected readonly List<MEAHIOLGGIB> FHCMCIEEMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private T FAIFJNHDHHL;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1C5F220", Offset = "0x1C5DA20", VA = "0x181C5F220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x28649E0", Offset = "0x28631E0", VA = "0x1828649E0")]
	public bool GFHBPLMLDGI(T MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2864BE0", Offset = "0x28633E0", VA = "0x182864BE0")]
	public void GLILACFFLBJ(T MENBIMCLIOI, int IOJGIALNGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x28648C0", Offset = "0x28630C0", VA = "0x1828648C0")]
	public bool FNJGHMKCCPI(T MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2864860", Offset = "0x2863060", VA = "0x182864860")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2864C80", Offset = "0x2863480", VA = "0x182864C80")]
	public T JPPINFNOOMH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x2864CF0", Offset = "0x28634F0", VA = "0x182864CF0")]
	private void MEBNALHNFGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x2864EA0", Offset = "0x28636A0", VA = "0x182864EA0")]
	public IPGAEAEJJLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class FOICFLMBKGJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct DPJJOFNCDBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int PMIPHMBCIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public T PGHJLABHLGJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly Dictionary<object, DPJJOFNCDBD> DFAKGEGFEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly EqualityComparer<T> NGAIPAKKOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private T BOLEICNPIFH;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public virtual T LMKOEENGMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2249650", Offset = "0x2247E50", VA = "0x182249650", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x20E5070", Offset = "0x20E3870", VA = "0x1820E5070", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool EIJPPGGPANH
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x2249570", Offset = "0x2247D70", VA = "0x182249570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public object OMPCLOJMMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x95DB30", Offset = "0x95C330", VA = "0x18095DB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x2244EC0", Offset = "0x22436C0", VA = "0x182244EC0")]
	public bool CIAGOAJLCNF(T MENBIMCLIOI, object AMCDGOPKAOE, int IOJGIALNGIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2249680", Offset = "0x2247E80", VA = "0x182249680")]
	public bool OIMLKAJCHAC(object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2244A70", Offset = "0x2243270", VA = "0x182244A70")]
	public bool CBDOACFHBEA(object AMCDGOPKAOE, out T MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2245590", Offset = "0x2243D90", VA = "0x182245590")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x2246DF0", Offset = "0x22455F0", VA = "0x182246DF0")]
	private bool EPCOKMJGDIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x22496F0", Offset = "0x2247EF0", VA = "0x1822496F0")]
	public FOICFLMBKGJ()
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
