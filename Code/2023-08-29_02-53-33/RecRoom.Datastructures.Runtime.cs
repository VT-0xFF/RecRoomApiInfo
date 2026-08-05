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
		[Cpp2IlInjected.Address(RVA = "0x7E8250", Offset = "0x7E7650", VA = "0x1807E8250")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x902B60", Offset = "0x901F60", VA = "0x180902B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1A88270", Offset = "0x1A87670", VA = "0x181A88270")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x20CCCF0", Offset = "0x20CC0F0", VA = "0x1820CCCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
	public virtual void KNDFFADEHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
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
	[ICJFMLJFLIJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x43B5660", Offset = "0x43B4A60", VA = "0x1843B5660", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43B4DC0", Offset = "0x43B41C0", VA = "0x1843B4DC0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43B5B90", Offset = "0x43B4F90", VA = "0x1843B5B90")]
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
	private sealed class ALDCDKMEJLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public ALDCDKMEJLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x30F2680", Offset = "0x30F1A80", VA = "0x1830F2680")]
		internal int ADAFANCALGO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[ICJFMLJFLIJ]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9270D0", Offset = "0x9264D0", VA = "0x1809270D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x927100", Offset = "0x926500", VA = "0x180927100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x927020", Offset = "0x926420", VA = "0x180927020", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey KOFPKIJDAMC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x927080", Offset = "0x926480", VA = "0x180927080", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x926F20", Offset = "0x926320", VA = "0x180926F20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x926A40", Offset = "0x925E40", VA = "0x180926A40", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x926260", Offset = "0x925660", VA = "0x180926260", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x925EB0", Offset = "0x9252B0", VA = "0x180925EB0", Slot = "14")]
	protected virtual string JKHILKLLNGI(TKeyVal EBOIPNKJEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x925DF0", Offset = "0x9251F0", VA = "0x180925DF0", Slot = "4")]
	public bool ContainsKey(TKey KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x926E00", Offset = "0x926200", VA = "0x180926E00", Slot = "5")]
	public bool TryGetValue(TKey KOFPKIJDAMC, out TVal KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x925E20", Offset = "0x925220", VA = "0x180925E20", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x925E20", Offset = "0x925220", VA = "0x180925E20", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x926E30", Offset = "0x926230", VA = "0x180926E30")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GGFMIPMKPPJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CNAJFJBMJDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public CNAJFJBMJDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3296AD0", Offset = "0x3295ED0", VA = "0x183296AD0")]
		internal bool JAKDEEDPFJF(JHOILMFFPHI<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float JMLLEOFEPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float BLFIHDMJODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<JHOILMFFPHI<float, T>> OPODGEJGFLC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NDGONMBJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x212C780", Offset = "0x212BB80", VA = "0x18212C780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x212C830", Offset = "0x212BC30", VA = "0x18212C830")]
	public GGFMIPMKPPJ(float EOCOMOJILAI, float EHPNFBKDHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x212C4E0", Offset = "0x212B8E0", VA = "0x18212C4E0")]
	public bool EGAOCFKDAPF(float FEDAMNGKFGH, T KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x212C040", Offset = "0x212B440", VA = "0x18212C040")]
	public IEnumerable<T> BGBMICHGCDF(float FEDAMNGKFGH, [Optional] float? ECEDNECLHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x212C800", Offset = "0x212BC00", VA = "0x18212C800")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x212C640", Offset = "0x212BA40", VA = "0x18212C640")]
	private void LIFDGGJFMPC(float FEDAMNGKFGH)
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
	public T EEMAOFBHODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2F61110", Offset = "0x2F60510", VA = "0x182F61110")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2F61030", Offset = "0x2F60430", VA = "0x182F61030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float DAAFNKIBGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA751B0", Offset = "0xA745B0", VA = "0x180A751B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x387A4B0", Offset = "0x38798B0", VA = "0x18387A4B0")]
	public T KPDBCFJFIKL(float CECLOGMADIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x387A3B0", Offset = "0x38797B0", VA = "0x18387A3B0")]
	public T GCBCJCFPGID(float CECLOGMADIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GNIBJIOBLIH(T LLKHFJFGFIB, T LDJLPHFLLEO, float CECLOGMADIP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4FA3F90", Offset = "0x4FA3390", VA = "0x184FA3F90", Slot = "4")]
	protected override float GNIBJIOBLIH(float LLKHFJFGFIB, float LDJLPHFLLEO, float CECLOGMADIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7970", Offset = "0x6EA6D70", VA = "0x186EA7970")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xA70960", Offset = "0xA6FD60", VA = "0x180A70960", Slot = "4")]
	protected override Vector3 GNIBJIOBLIH(Vector3 LLKHFJFGFIB, Vector3 LDJLPHFLLEO, float CECLOGMADIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB620", Offset = "0x6EAAA20", VA = "0x186EAB620")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA74D0", Offset = "0x6EA68D0", VA = "0x186EA74D0", Slot = "4")]
	protected override Color GNIBJIOBLIH(Color LLKHFJFGFIB, Color LDJLPHFLLEO, float CECLOGMADIP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7530", Offset = "0x6EA6930", VA = "0x186EA7530")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JKAEOIFOFHE
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x20241A0", Offset = "0x20235A0", VA = "0x1820241A0")]
	public static JHOILMFFPHI<T1, T2> OBPHLOEIGIJ<T1, T2>(T1 NOPPEFEOOCG, T2 MHFCLEPBBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2024210", Offset = "0x2023610", VA = "0x182024210")]
	public static EDAMDFDKBLB<T1, T2, T3> OBPHLOEIGIJ<T1, T2, T3>(T1 NOPPEFEOOCG, T2 MHFCLEPBBLK, T3 CKADCMJDDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8D80", Offset = "0x6EA8180", VA = "0x186EA8D80")]
	internal static int BFPLCONFKFC(int GEFECEPJGFH, int GPONJMOKBKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8D90", Offset = "0x6EA8190", VA = "0x186EA8D90")]
	internal static int BFPLCONFKFC(int GEFECEPJGFH, int GPONJMOKBKC, int IAPMEFNILFJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JHOILMFFPHI<T1, T2> : IComparable<JHOILMFFPHI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T1 PFKEBMFFLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly T2 PLLEJCNCEIB;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D840", Offset = "0x2B2CC40", VA = "0x182B2D840")]
	public JHOILMFFPHI(T1 NOPPEFEOOCG, T2 MHFCLEPBBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D23CF0", Offset = "0x2D230F0", VA = "0x182D23CF0", Slot = "4")]
	public int CompareTo(JHOILMFFPHI<T1, T2> LNOOAJJNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D244D0", Offset = "0x2D238D0", VA = "0x182D244D0", Slot = "0")]
	public override bool Equals(object LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D249A0", Offset = "0x2D23DA0", VA = "0x182D249A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D24EF0", Offset = "0x2D242F0", VA = "0x182D24EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EDAMDFDKBLB<T1, T2, T3> : IComparable<EDAMDFDKBLB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly T1 PFKEBMFFLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T2 PLLEJCNCEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T3 AEAIFGACFOA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E5FFA0", Offset = "0x2E5F3A0", VA = "0x182E5FFA0")]
	public EDAMDFDKBLB(T1 NOPPEFEOOCG, T2 MHFCLEPBBLK, T3 CKADCMJDDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2E5F860", Offset = "0x2E5EC60", VA = "0x182E5F860", Slot = "4")]
	public int CompareTo(EDAMDFDKBLB<T1, T2, T3> LNOOAJJNCAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2E5FA80", Offset = "0x2E5EE80", VA = "0x182E5FA80", Slot = "0")]
	public override bool Equals(object LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2E5FC80", Offset = "0x2E5F080", VA = "0x182E5FC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2E5FDF0", Offset = "0x2E5F1F0", VA = "0x182E5FDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ICJFMLJFLIJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xD17B50", Offset = "0xD16F50", VA = "0x180D17B50")]
	public ICJFMLJFLIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HashableScriptableObject : ScriptableObject, LMAKPGJHEAP, JCJMCHELALL, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DKFONLPAIAJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x992770", Offset = "0x991B70", VA = "0x180992770")]
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
	[SerializeField]
	[PICDKMBLKJO]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[PICDKMBLKJO]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA6B0", Offset = "0x6EA9AB0", VA = "0x186EAA6B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA670", Offset = "0x6EA9A70", VA = "0x186EAA670")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA6F0", Offset = "0x6EA9AF0", VA = "0x186EAA6F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA8A0", Offset = "0x6EA9CA0", VA = "0x186EAA8A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA810", Offset = "0x6EA9C10", VA = "0x186EAA810")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9CDAA0", Offset = "0x9CCEA0", VA = "0x1809CDAA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x94EDA0", Offset = "0x94E1A0", VA = "0x18094EDA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA630", Offset = "0x6EA9A30", VA = "0x186EAA630")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA780", Offset = "0x6EA9B80", VA = "0x186EAA780")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA080", Offset = "0x6EA9480", VA = "0x186EAA080")]
	public void CopyBounds(SavedExtents LNOOAJJNCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA590", Offset = "0x6EA9990", VA = "0x186EAA590")]
	public void SetLocalSpaceBounds(Bounds PAACDBOBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9A20", Offset = "0x6EA8E20", VA = "0x186EA9A20")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA580", Offset = "0x6EA9980", VA = "0x186EAA580")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA170", Offset = "0x6EA9570", VA = "0x186EAA170")]
	private void KIHJCOLCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA350", Offset = "0x6EA9750", VA = "0x186EAA350")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9A40", Offset = "0x6EA8E40", VA = "0x186EA9A40")]
	public static void CalculateLocalBoundsFor(GameObject GACFHLOJJGF, out Bounds PAACDBOBDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA0B0", Offset = "0x6EA94B0", VA = "0x186EAA0B0")]
	private static void IADHBFLIAGN(Bounds CMACFBOCONA, Color NCIBDKIMCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA5B0", Offset = "0x6EA99B0", VA = "0x186EAA5B0")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class EKAAAOCGAAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct MNJCMLKOFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public T EEMAOFBHODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public float NAADMGLOHKG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static float AJJKIHOPPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private List<T> DMPNOKKBDNH;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const int PIBALLKFLID = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private MNJCMLKOFPL[] KGHLGBOMEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int MPAGADIGDMP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float KPJLJKMKPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xB7AC70", Offset = "0xB7A070", VA = "0x180B7AC70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xB7AC80", Offset = "0xB7A080", VA = "0x180B7AC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D800", Offset = "0x2E7CC00", VA = "0x182E7D800")]
	public EKAAAOCGAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D830", Offset = "0x2E7CC30", VA = "0x182E7D830")]
	public EKAAAOCGAAG(int JECAINLJFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C990", Offset = "0x2E7BD90", VA = "0x182E7C990")]
	public void EBOHBLNDMAL(float FEDAMNGKFGH, T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D510", Offset = "0x2E7C910", VA = "0x182E7D510")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E7CDD0", Offset = "0x2E7C1D0", VA = "0x182E7CDD0")]
	public bool EPEBDLCHGIM(float HKHMFAHPKCM, float PIMHKHGNIGI, out T KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D1F0", Offset = "0x2E7C5F0", VA = "0x182E7D1F0")]
	public bool OEOICLIJDGP(float HKHMFAHPKCM, float PIMHKHGNIGI, out T KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2E7CCA0", Offset = "0x2E7C0A0", VA = "0x182E7CCA0")]
	public void EKIPCPLHOOD(float HKHMFAHPKCM, float PIMHKHGNIGI, List<T> GMNLDOEDEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C960", Offset = "0x2E7BD60", VA = "0x182E7C960")]
	private int DMABAHNDJML(int OFNJKCEEDJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D1B0", Offset = "0x2E7C5B0", VA = "0x182E7D1B0")]
	private void GFOKHOMPOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T COAPAANCKBC();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T CJIDOIOBCHO(T KKIAKNLLHIO, float CECLOGMADIP);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T PLPMPAHKKHE(T LLKHFJFGFIB, T LDJLPHFLLEO);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MBFCBBACEGB(T LLKHFJFGFIB, T LDJLPHFLLEO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DJJBMIBFALN : EKAAAOCGAAG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xF1BE50", Offset = "0xF1B250", VA = "0x180F1BE50", Slot = "4")]
	protected override Vector3 COAPAANCKBC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7800", Offset = "0x6EA6C00", VA = "0x186EA7800", Slot = "5")]
	protected override Vector3 CJIDOIOBCHO(Vector3 KKIAKNLLHIO, float CECLOGMADIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6EA78B0", Offset = "0x6EA6CB0", VA = "0x186EA78B0", Slot = "6")]
	protected override Vector3 PLPMPAHKKHE(Vector3 LLKHFJFGFIB, Vector3 LDJLPHFLLEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7840", Offset = "0x6EA6C40", VA = "0x186EA7840", Slot = "7")]
	protected override Vector3 MBFCBBACEGB(Vector3 LLKHFJFGFIB, Vector3 LDJLPHFLLEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7900", Offset = "0x6EA6D00", VA = "0x186EA7900")]
	public DJJBMIBFALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HIDPIOMOKME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable HLFGGJBLCBK;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public HIDPIOMOKME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BNINGMBFCBL : KGMJJGLPGPD<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EA64E0", Offset = "0x6EA58E0", VA = "0x186EA64E0")]
	public BNINGMBFCBL(int EPMEDFGLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6470", Offset = "0x6EA5870", VA = "0x186EA6470", Slot = "6")]
	protected override uint HPDAHMPPDNF(uint DKFONLPAIAJ, string KKIAKNLLHIO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public class PIIEICHMKFJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private PIIEICHMKFJ<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x10687F0", Offset = "0x1067BF0", VA = "0x1810687F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x26A0B90", Offset = "0x269FF90", VA = "0x1826A0B90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x26A1360", Offset = "0x26A0760", VA = "0x1826A1360")]
		public Enumerator(PIIEICHMKFJ<T> GMNLDOEDEPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x269CD40", Offset = "0x269C140", VA = "0x18269CD40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x269E340", Offset = "0x269D740", VA = "0x18269E340", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x269D7E0", Offset = "0x269CBE0", VA = "0x18269D7E0")]
		private void NCEACJIFJMC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] IDMGKIDLCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int MIICGJCNLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int FGALENKFDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int HEGEMCIFGEI;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x26AE9E0", Offset = "0x26ADDE0", VA = "0x1826AE9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x26AD9A0", Offset = "0x26ACDA0", VA = "0x1826AD9A0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x26ADF70", Offset = "0x26AD370", VA = "0x1826ADF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x26AEC50", Offset = "0x26AE050", VA = "0x1826AEC50")]
	public PIIEICHMKFJ(int EPMEDFGLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x26ADBE0", Offset = "0x26ACFE0", VA = "0x1826ADBE0")]
	public void EBOHBLNDMAL(T CECLOGMADIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x26AEA20", Offset = "0x26ADE20", VA = "0x1826AEA20")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x26AEA40", Offset = "0x26ADE40", VA = "0x1826AEA40")]
	public void PGCEDOGPAEF(int ECOAGJBCGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26AE8A0", Offset = "0x26ADCA0", VA = "0x1826AE8A0")]
	public void JFACJLNGHIA(T[] KGHLGBOMEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26ADE10", Offset = "0x26AD210", VA = "0x1826ADE10")]
	public Enumerator FNKOJPGNHJL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x26AEAD0", Offset = "0x26ADED0", VA = "0x1826AEAD0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x26AEAD0", Offset = "0x26ADED0", VA = "0x1826AEAD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x26AE300", Offset = "0x26AD700", VA = "0x1826AE300")]
	private int HGKOGCJPDPB(int NANJAGEOPJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26AE0F0", Offset = "0x26AD4F0", VA = "0x1826AE0F0")]
	private int GIJDGGOBFBC(int NANJAGEOPJI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DFABKIBNKIL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KFPOCAOMGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int ABLLCAIHIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int EJCOEJEHIKJ;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1F5C5E0", Offset = "0x1F5B9E0", VA = "0x181F5C5E0")]
	private DFABKIBNKIL(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MFKOHIDBJCK, int IODFGNEBOIP, int ADPNGDMADAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x304DB50", Offset = "0x304CF50", VA = "0x18304DB50")]
	public static DFABKIBNKIL<T> OHIOHLNJBHE()
	{
		return default(DFABKIBNKIL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x304D520", Offset = "0x304C920", VA = "0x18304D520")]
	public (int, int, Task<T>) MEFKKDECGFL(int NMELICPCGCF, [Optional] CancellationToken DNKHCCGNODC, double FBDCHBAJFIH = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x304C700", Offset = "0x304BB00", VA = "0x18304C700")]
	public void EGPEEPDDLIL(int NMELICPCGCF, int ADPNGDMADAG, in T OHCLGKAJOMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IKJDCDCCJNP
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8D30", Offset = "0x6EA8130", VA = "0x186EA8D30")]
	public static DFABKIBNKIL<GPBBNBCMMCG> OHIOHLNJBHE()
	{
		return default(DFABKIBNKIL<GPBBNBCMMCG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8CB0", Offset = "0x6EA80B0", VA = "0x186EA8CB0")]
	public static void EGPEEPDDLIL(this in DFABKIBNKIL<GPBBNBCMMCG> JCOLBAAGCGE, int NMELICPCGCF, int ADPNGDMADAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class DOEPLLLHIPG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> EGBNILHKOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> JBDDNKJKBCH;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xEF36D0", Offset = "0xEF2AD0", VA = "0x180EF36D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool PAJHIMACICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D20", Offset = "0x7F2120", VA = "0x1807F2D20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> BJBNGGOBGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x204E0E0", Offset = "0x204D4E0", VA = "0x18204E0E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> KHKNKHMLPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x211EA90", Offset = "0x211DE90", VA = "0x18211EA90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2E2E1E0", Offset = "0x2E2D5E0", VA = "0x182E2E1E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2E2E220", Offset = "0x2E2D620", VA = "0x182E2E220", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2E2D740", Offset = "0x2E2CB40", VA = "0x182E2D740")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D930", Offset = "0x2E2CD30", VA = "0x182E2D930", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DFD0", Offset = "0x2E2D3D0", VA = "0x182E2DFD0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D6D0", Offset = "0x2E2CAD0", VA = "0x182E2D6D0", Slot = "9")]
	public void Add(TKey KOFPKIJDAMC, TVal KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D690", Offset = "0x2E2CA90", VA = "0x182E2D690", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ADJFAODNAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D990", Offset = "0x2E2CD90", VA = "0x182E2D990", Slot = "8")]
	public bool ContainsKey(TKey KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D9C0", Offset = "0x2E2CDC0", VA = "0x182E2D9C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x221B170", Offset = "0x221A570", VA = "0x18221B170", Slot = "10")]
	public bool Remove(TKey KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DFA0", Offset = "0x2E2D3A0", VA = "0x182E2DFA0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1949470", Offset = "0x1948870", VA = "0x181949470", Slot = "11")]
	public bool TryGetValue(TKey KOFPKIJDAMC, out TVal KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2108CC0", Offset = "0x21080C0", VA = "0x182108CC0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DA20", Offset = "0x2E2CE20", VA = "0x182E2DA20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KGHLGBOMEFA, int BHHKGKOCFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DCE0", Offset = "0x2E2D0E0", VA = "0x182E2DCE0")]
	public bool HPMOKKNEDOE(TVal KOFPKIJDAMC, out TKey KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D780", Offset = "0x2E2CB80", VA = "0x182E2D780")]
	private void CHFDKGOOGOM(TKey KOFPKIJDAMC, TVal CPAHGHLMHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DC10", Offset = "0x2E2D010", VA = "0x182E2DC10")]
	private void HABHFGGDHCI(TKey KOFPKIJDAMC, TVal CPAHGHLMHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DEA0", Offset = "0x2E2D2A0", VA = "0x182E2DEA0")]
	private bool PJAGBONPMDN(TKey KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E2E0C0", Offset = "0x2E2D4C0", VA = "0x182E2E0C0")]
	public DOEPLLLHIPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class JCGBIEPPBFK<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> IABGFIOJHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> OCCNFAKIALD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4FC4F00", Offset = "0x4FC4300", VA = "0x184FC4F00", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4FC4E50", Offset = "0x4FC4250", VA = "0x184FC4E50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x16C90C0", Offset = "0x16C84C0", VA = "0x1816C90C0")]
	public JCGBIEPPBFK(Func<Internal, External> IABGFIOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4FC4E00", Offset = "0x4FC4200", VA = "0x184FC4E00")]
	public JCGBIEPPBFK(IReadOnlyList<Internal> OCCNFAKIALD, Func<Internal, External> IABGFIOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4FC4D90", Offset = "0x4FC4190", VA = "0x184FC4D90", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x194BAF0", Offset = "0x194AEF0", VA = "0x18194BAF0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IGOEMHGCPBC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> DGLCCMDLGNI(TRequest IPCJOMPDMMM, CancellationToken DNKHCCGNODC);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum NDOPCFPPEGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DKKNKJKPKMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float COECGPCKDKH = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan JPEJCLBAAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int LLLLICIIMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NDOPCFPPEGK BABDKECLAGG;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly DKKNKJKPKMH DEEICBABDMJ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float EPIAICBAAME
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x24F3070", Offset = "0x24F2470", VA = "0x1824F3070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan KIOKOJJIOAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x24F32A0", Offset = "0x24F26A0", VA = "0x1824F32A0")]
		public DKKNKJKPKMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct GIDFOCPALDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest IPCJOMPDMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken DNKHCCGNODC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> HAJKLOBCDKB;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x273DBA0", Offset = "0x273CFA0", VA = "0x18273DBA0")]
		public GIDFOCPALDL(TRequest IPCJOMPDMMM, TaskCompletionSource<TResult> HAJKLOBCDKB, CancellationToken DNKHCCGNODC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GJEKMKICODN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IGOEMHGCPBC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public GJEKMKICODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2742A70", Offset = "0x2741E70", VA = "0x182742A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PEOOPDGDHIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IGOEMHGCPBC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private GIDFOCPALDL <req>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public PEOOPDGDHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB190", Offset = "0x2CEA590", VA = "0x182CEB190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource KPNMEIIBKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<GIDFOCPALDL> EJGAFBPAJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly DKKNKJKPKMH IHEJDGPDGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly DGLCCMDLGNI MMOKMMAMKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task IBLLBDMKAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int EHGPCONODIP;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xEFF480", Offset = "0xEFE880", VA = "0x180EFF480")]
	public IGOEMHGCPBC(DGLCCMDLGNI MMOKMMAMKJK, [Optional] DKKNKJKPKMH IHEJDGPDGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xEFE960", Offset = "0xEFDD60", VA = "0x180EFE960")]
	public Task<TResult> KPAHOGFBMHN(TRequest IPCJOMPDMMM, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xEFE420", Offset = "0xEFD820", VA = "0x180EFE420")]
	private void JNDNCMMIAEI(GIDFOCPALDL ELGKEFPBCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xEFDCA0", Offset = "0xEFD0A0", VA = "0x180EFDCA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IGOEMHGCPBC<, >.GJEKMKICODN))]
	private Task DGAEPLDGKLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xEFEFC0", Offset = "0xEFE3C0", VA = "0x180EFEFC0")]
	private GIDFOCPALDL OOMIBGGFFEF()
	{
		return default(GIDFOCPALDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xEFE220", Offset = "0xEFD620", VA = "0x180EFE220")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IGOEMHGCPBC<, >.PEOOPDGDHIK))]
	private Task FJDJGHBCMEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xEFE6E0", Offset = "0xEFDAE0", VA = "0x180EFE6E0")]
	private void KBGGNNJHPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xEFDF40", Offset = "0xEFD340", VA = "0x180EFDF40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BB21B0", Offset = "0x2BB15B0", VA = "0x182BB21B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E040", Offset = "0x6D2D440", VA = "0x186D2E040")]
		public SerializedGuid(in Guid EBABBHGKMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAB50", Offset = "0x6EA9F50", VA = "0x186EAAB50")]
		public static SerializedGuid LKAGDJJLKJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA930", Offset = "0x6EA9D30", VA = "0x186EAA930")]
		public static SerializedGuid AMELMNBGJKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EAABE0", Offset = "0x6EA9FE0", VA = "0x186EAABE0")]
		public bool NGKCNIJNPNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6D2E010", Offset = "0x6D2D410", VA = "0x186D2E010", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAC70", Offset = "0x6EAA070", VA = "0x186EAAC70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA9C0", Offset = "0x6EA9DC0", VA = "0x186EAA9C0", Slot = "7")]
		public bool Equals(SerializedGuid LNOOAJJNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAA70", Offset = "0x6EA9E70", VA = "0x186EAAA70", Slot = "0")]
		public override bool Equals(object ICNDEPGFBMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6D2DF60", Offset = "0x6D2D360", VA = "0x186D2DF60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6D2DDA0", Offset = "0x6D2D1A0", VA = "0x186D2DDA0", Slot = "6")]
		public int CompareTo(SerializedGuid LNOOAJJNCAE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CLDGEBIKAAG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type ANDIENBEINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string NJGLKPHFMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool POLJMNNHIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool PEBALINKIDC;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7460", Offset = "0x6EA6860", VA = "0x186EA7460")]
	public CLDGEBIKAAG(Type ABNDEIHMBMJ, string CLKFBHDNNCF, bool HACHJHMIAAO = false, bool MFCLPAMACCF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class JCPCBOGCEDN<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly List<T> OCCNFAKIALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private HashSet<T> NDJHNKNNCHI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xEF36D0", Offset = "0xEF2AD0", VA = "0x180EF36D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PAJHIMACICC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E8C00", Offset = "0x7E8000", VA = "0x1807E8C00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x194B340", Offset = "0x194A740", VA = "0x18194B340", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4FC8B90", Offset = "0x4FC7F90", VA = "0x184FC8B90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x24CE590", Offset = "0x24CD990", VA = "0x1824CE590", Slot = "11")]
	public void Add(T ADJFAODNAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4FC83C0", Offset = "0x4FC77C0", VA = "0x184FC83C0")]
	public bool CCKFLLFIEGA(T ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4FC88D0", Offset = "0x4FC7CD0", VA = "0x184FC88D0", Slot = "15")]
	public bool Remove(T ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x19493F0", Offset = "0x19487F0", VA = "0x1819493F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x24F3B50", Offset = "0x24F2F50", VA = "0x1824F3B50", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4FC8510", Offset = "0x4FC7910", VA = "0x184FC8510", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0xEF97A0", Offset = "0xEF8BA0", VA = "0x180EF97A0", Slot = "13")]
	public bool Contains(T ADJFAODNAMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4FC8570", Offset = "0x4FC7970", VA = "0x184FC8570", Slot = "14")]
	public void CopyTo(T[] KGHLGBOMEFA, int BHHKGKOCFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2E2E1B0", Offset = "0x2E2D5B0", VA = "0x182E2E1B0", Slot = "6")]
	public int IndexOf(T ADJFAODNAMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4FC85A0", Offset = "0x4FC79A0", VA = "0x184FC85A0", Slot = "7")]
	public void Insert(int NANJAGEOPJI, T ADJFAODNAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4FC8800", Offset = "0x4FC7C00", VA = "0x184FC8800", Slot = "8")]
	public void RemoveAt(int NANJAGEOPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4FC89E0", Offset = "0x4FC7DE0", VA = "0x184FC89E0")]
	public JCPCBOGCEDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AOAJPNNGCIB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6400", Offset = "0x6EA5800", VA = "0x186EA6400")]
	public AOAJPNNGCIB(string HGJHDPGFLKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DCLFIGHDHFA
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7570", Offset = "0x6EA6970", VA = "0x186EA7570")]
	[NotNull]
	public static byte[] MIGLBIMJMIL(this JCJMCHELALL HDJAMAAKLPK, HashAlgorithmName PBMIAGPDEBD, byte[] KFLOEDOHKKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JCJMCHELALL
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash DKFONLPAIAJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LMAKPGJHEAP : JCJMCHELALL
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	[CanBeNull]
	byte[] NDHHELADMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[CanBeNull]
	byte[] MPHMKLPDACN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class CACEDGCMCOG
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly ArrayPool<byte> JMCBGELDJAI;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static bool LCFMEDNEFIA;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6E70", Offset = "0x6EA6270", VA = "0x186EA6E70")]
	public static void JAENPLHHEOA(this IncrementalHash BMCMKAKBGEG, [CanBeNull] GameObject GACFHLOJJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D75900", Offset = "0x4D74D00", VA = "0x184D75900")]
	public static void JAENPLHHEOA<T>(this IncrementalHash BMCMKAKBGEG, [CanBeNull] T DDPBEGBOLIH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4D75E20", Offset = "0x4D75220", VA = "0x184D75E20")]
	public static void MMIIIEJDOEH<T>(this IncrementalHash BMCMKAKBGEG, [CanBeNull] T HDJAMAAKLPK) where T : JCJMCHELALL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4D759D0", Offset = "0x4D74DD0", VA = "0x184D759D0")]
	public static void JOHGCMMBODD<T>(this IncrementalHash BMCMKAKBGEG, [CanBeNull] IList<T> KKCAALJAPDP) where T : JCJMCHELALL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6C10", Offset = "0x6EA6010", VA = "0x186EA6C10")]
	private static bool GELBMDOGAEO([CanBeNull] JCJMCHELALL HDJAMAAKLPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6FD0", Offset = "0x6EA63D0", VA = "0x186EA6FD0")]
	public static void JNLKHLLHEHO(this IncrementalHash DKFONLPAIAJ, [CanBeNull] string OBHHCFNHHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6EA69D0", Offset = "0x6EA5DD0", VA = "0x186EA69D0")]
	public static void BNAMEKGDCEI(this IncrementalHash DKFONLPAIAJ, long LJLMDICAEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7090", Offset = "0x6EA6490", VA = "0x186EA7090")]
	public static void MMECKPBNFGE(this IncrementalHash DKFONLPAIAJ, int EIJHBAGMILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6CA0", Offset = "0x6EA60A0", VA = "0x186EA6CA0")]
	public static void IDBEPIJPHFB(this IncrementalHash DKFONLPAIAJ, short LLHGPFAOCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6700", Offset = "0x6EA5B00", VA = "0x186EA6700")]
	public static void AEHFHCCMKIO(this IncrementalHash DKFONLPAIAJ, byte IIFLPAPKEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6530", Offset = "0x6EA5930", VA = "0x186EA6530")]
	public static void ADAFBKAIOLJ(this IncrementalHash DKFONLPAIAJ, bool PPDJICFIFHO, bool OPINLJIBKGJ = false, bool LCDABKOIADK = false, bool PPHALCAFIGF = false, bool LKDJFBLMPGM = false, bool OJPONHOLGOA = false, bool PCEDDKKHPNK = false, bool CEJIGOJIKNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4D75EB0", Offset = "0x4D752B0", VA = "0x184D75EB0")]
	public static void NEHNLIAAKJC<T>(this IncrementalHash DKFONLPAIAJ, T EALIBHBPMAH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7030", Offset = "0x6EA6430", VA = "0x186EA7030")]
	public static void LKDHICFIGGF(this IncrementalHash DKFONLPAIAJ, float IFJBGCEPEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6F60", Offset = "0x6EA6360", VA = "0x186EA6F60")]
	public static void JMLJDJKMGPP(this IncrementalHash DKFONLPAIAJ, ulong NMMJINJNOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7260", Offset = "0x6EA6660", VA = "0x186EA7260")]
	public static void NEKLCDPHAMM(this IncrementalHash DKFONLPAIAJ, uint BKMFCBJGLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6BA0", Offset = "0x6EA5FA0", VA = "0x186EA6BA0")]
	public static void EPIINDGBLIL(this IncrementalHash DKFONLPAIAJ, ushort OOACJIJMIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6870", Offset = "0x6EA5C70", VA = "0x186EA6870")]
	public static void BMOOILCINDF(this IncrementalHash DKFONLPAIAJ, Vector3 HAGNHBLFAKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PHGGNBLNNII
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6EA93C0", Offset = "0x6EA87C0", VA = "0x186EA93C0")]
	[NotNull]
	public static byte[] MIGLBIMJMIL(this LMAKPGJHEAP MDGMLECIIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9350", Offset = "0x6EA8750", VA = "0x186EA9350")]
	[NotNull]
	public static byte[] MIGLBIMJMIL(this LMAKPGJHEAP MDGMLECIIDP, HashAlgorithmName PBMIAGPDEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9020", Offset = "0x6EA8420", VA = "0x186EA9020")]
	public static bool BOLHKKBOLIK([CanBeNull] this LMAKPGJHEAP MDGMLECIIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6EA91B0", Offset = "0x6EA85B0", VA = "0x186EA91B0")]
	public static bool BOLHKKBOLIK([CanBeNull] this LMAKPGJHEAP MDGMLECIIDP, out string KDPCEEMNMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9430", Offset = "0x6EA8830", VA = "0x186EA9430")]
	private static bool NCNLNGFBGJF([NotNull] LMAKPGJHEAP MDGMLECIIDP, [CanBeNull] out byte[] DLHIKEFNIKO, [CanBeNull] out byte[] IHMJLKHFFCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class JHJFJCKIMEJ<TTask, T> : DLPGPDLDMKF<T>, KLDANHPIBBC, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DNDBJIOCFKN
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
			public DNDBJIOCFKN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x1A3C230", Offset = "0x1A3B630", VA = "0x181A3C230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
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
		public JHJFJCKIMEJ<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public DNDBJIOCFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2507710", Offset = "0x2506B10", VA = "0x182507710")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(JHJFJCKIMEJ<, >.DNDBJIOCFKN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> CCPAOEGLPLG(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static bool GHNEFIGOOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Task<T> LPNIBKGOBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly CancellationTokenSource LNHAMGDDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool NEOLAOAJOPA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task<T> MGJJAPOBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MCFFIFIPNKE<T> IJGFLNEKLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MPIAMCJMFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x977980", Offset = "0x976D80", VA = "0x180977980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2D20310", Offset = "0x2D1F710", VA = "0x182D20310")]
	static JHJFJCKIMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2D204C0", Offset = "0x2D1F8C0", VA = "0x182D204C0")]
	protected JHJFJCKIMEJ(TTask LPNIBKGOBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FD50", Offset = "0x2D1F150", VA = "0x182D1FD50", Slot = "1")]
	~JHJFJCKIMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FD20", Offset = "0x2D1F120", VA = "0x182D1FD20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2D1FDC0", Offset = "0x2D1F1C0", VA = "0x182D1FDC0")]
	private void NEAHAFKMCLG(bool GDGFPJALPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T KLPIBMNHION(TTask AOKJEODFBLK);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void BHPBLJCLJAI();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class CJFFJDEPDGE<T> : DLPGPDLDMKF<T>, KLDANHPIBBC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> MGJJAPOBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public MCFFIFIPNKE<T> IJGFLNEKLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3288FD0", Offset = "0x32883D0", VA = "0x183288FD0")]
	public CJFFJDEPDGE(Exception MHKCFPODLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KLDANHPIBBC : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface DLPGPDLDMKF<T> : KLDANHPIBBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	[NotNull]
	Task<T> MGJJAPOBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	[NotNull]
	MCFFIFIPNKE<T> IJGFLNEKLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LELMKHEEBKC : JAKCBGHPNIJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8DA0", Offset = "0x6EA81A0", VA = "0x186EA8DA0")]
	public LELMKHEEBKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JAKCBGHPNIJ<T> : DLPGPDLDMKF<T>, KLDANHPIBBC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task<T> MGJJAPOBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MCFFIFIPNKE<T> IJGFLNEKLLE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4FC1690", Offset = "0x4FC0A90", VA = "0x184FC1690")]
	public JAKCBGHPNIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class PECKACNDMMI : KHDPAGPOPHE<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class CHLMEMBGGBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action<PECKACNDMMI, PILIJFIMAJF> callback;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public CHLMEMBGGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6EA73C0", Offset = "0x6EA67C0", VA = "0x186EA73C0")]
		internal void BAPKDLGBPPD(KHDPAGPOPHE<string> timer, PILIJFIMAJF log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8EC0", Offset = "0x6EA82C0", VA = "0x186EA8EC0")]
	public PECKACNDMMI(PILIJFIMAJF FDJKGAAPBBG, [Optional] string GAPJOEOAKHB, [Optional] int? FDPJJACLPGB, [Optional] Stopwatch AFDFOBICFFM, [Optional] Action<string, KMAILICAKAC, PILIJFIMAJF> MEGAJMMOAOO, [Optional] Action<string, KMAILICAKAC, PILIJFIMAJF> AKCKLIGOPDG, [Optional] Action<PECKACNDMMI, PILIJFIMAJF> FJLJJHDHPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8DE0", Offset = "0x6EA81E0", VA = "0x186EA8DE0")]
	private static Action<KHDPAGPOPHE<string>, PILIJFIMAJF> COEFPGGHEMC(Action<PECKACNDMMI, PILIJFIMAJF> GBCKPIBLKJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GJALDDMEABK<TKey> : GFNAFGCMBEM<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string CIDAMFINNBD(TKey KOFPKIJDAMC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly string NMACHDFHNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly double JMDLANKPNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly bool OCPPAHJDEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly int IEEIAAMIFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly ISet<string> NFBMNJKMLNF;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2741200", Offset = "0x2740600", VA = "0x182741200")]
	private static string EFIJKFDDDMA(TKey KOFPKIJDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2741C40", Offset = "0x2741040", VA = "0x182741C40")]
	public GJALDDMEABK(string NMACHDFHNMM = "F2", double JMDLANKPNPL = double.MaxValue, bool OCPPAHJDEHJ = false, int IEEIAAMIFCE = int.MaxValue, [Optional] ISet<string> NFBMNJKMLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x27414D0", Offset = "0x27408D0", VA = "0x1827414D0", Slot = "4")]
	public override Dictionary<string, string> MABPHNCIMFL(KHDPAGPOPHE<TKey> ADGMBKKGEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2741240", Offset = "0x2740640", VA = "0x182741240")]
	private bool GGGINIMAJJB(string IJJHOCAJNMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2741580", Offset = "0x2740980", VA = "0x182741580")]
	public Dictionary<string, string> MABPHNCIMFL(KHDPAGPOPHE<TKey> ADGMBKKGEOK, CIDAMFINNBD JFBFNHONLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2741320", Offset = "0x2740720", VA = "0x182741320")]
	private string HANEIIHBLOO(StringBuilder PBOPFDOEABA, List<TKey> BEIPBPOGFLK, CIDAMFINNBD JFBFNHONLIO, bool LAPDLOLDKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2741AC0", Offset = "0x2740EC0", VA = "0x182741AC0")]
	private static void PNILAGNHLDB(StringBuilder HEHGFPPDALG, string GELPKONMBFA, bool GKPOEIMHEHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public abstract class GFNAFGCMBEM<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut MABPHNCIMFL(KHDPAGPOPHE<TKey> ADGMBKKGEOK);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
	protected GFNAFGCMBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class IMBPDICNIFP<TKey> : GFNAFGCMBEM<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string ILBDBCMBINA(TKey KOFPKIJDAMC);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2592520", Offset = "0x2591920", VA = "0x182592520")]
	private static string EFIJKFDDDMA(TKey KOFPKIJDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2592560", Offset = "0x2591960", VA = "0x182592560", Slot = "4")]
	public override string MABPHNCIMFL(KHDPAGPOPHE<TKey> ADGMBKKGEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2592610", Offset = "0x2591A10", VA = "0x182592610")]
	public string MABPHNCIMFL(KHDPAGPOPHE<TKey> ADGMBKKGEOK, [NotNull] ILBDBCMBINA JFBFNHONLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string OFIDPLIOABH(KHDPAGPOPHE<TKey> ADGMBKKGEOK, [NotNull] ILBDBCMBINA JFBFNHONLIO);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1F00380", Offset = "0x1EFF780", VA = "0x181F00380")]
	protected IMBPDICNIFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MCDJOMEGFMD<TKey> : IMBPDICNIFP<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct IGKBOBLFFNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public ILBDBCMBINA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static MCDJOMEGFMD<TKey> HLFGGJBLCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly string[] IGIEEHCCAGB;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2DCEB80", Offset = "0x2DCDF80", VA = "0x182DCEB80")]
	private MCDJOMEGFMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDB70", Offset = "0x2DCCF70", VA = "0x182DCDB70", Slot = "5")]
	protected override string OFIDPLIOABH(KHDPAGPOPHE<TKey> ADGMBKKGEOK, ILBDBCMBINA JFBFNHONLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2DCDA80", Offset = "0x2DCCE80", VA = "0x182DCDA80")]
	[CompilerGenerated]
	internal static string LIMDGAKAHKH(string CONAGEOFDHI, TKey KOFPKIJDAMC, ref IGKBOBLFFNB P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KHDPAGPOPHE<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct KMAILICAKAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly long ACODPPEDFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly long EGEIIDOAFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly int FDPJJACLPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly int AKADGJHJEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly bool OKDAGMCFCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly string PNPPGODILIF;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2219BE0", Offset = "0x2218FE0", VA = "0x182219BE0")]
		public KMAILICAKAC(long ACODPPEDFCI, int FDPJJACLPGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2219BB0", Offset = "0x2218FB0", VA = "0x182219BB0")]
		public KMAILICAKAC(long ACODPPEDFCI, long EGEIIDOAFPC, int FDPJJACLPGB, int AKADGJHJEBD, bool OKDAGMCFCKD, string PNPPGODILIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2219A10", Offset = "0x2218E10", VA = "0x182219A10")]
		public int CFBIKHGAMCO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2219A60", Offset = "0x2218E60", VA = "0x182219A60")]
		public int IKPDIACFJLP(int LOINLLADNIM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2219A80", Offset = "0x2218E80", VA = "0x182219A80")]
		public double IMNJONIJJPG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2219AF0", Offset = "0x2218EF0", VA = "0x182219AF0")]
		public KMAILICAKAC JOALLFPHAAM(long EGEIIDOAFPC, int AKADGJHJEBD)
		{
			return default(KMAILICAKAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class BCFFPJECEKP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class NMIINNHBDHA<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public Func<BCFFPJECEKP, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public BCFFPJECEKP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private BCFFPJECEKP <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
			public NMIINNHBDHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x2A9EA50", Offset = "0x2A9DE50", VA = "0x182A9EA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly TKey HFAPGGDMKBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly KHDPAGPOPHE<TKey> ADGMBKKGEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly PILIJFIMAJF FDJKGAAPBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private List<BCFFPJECEKP> PMHNIHODAGA;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string BIPJNBIOOME
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x2372EA0", Offset = "0x23722A0", VA = "0x182372EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public IEnumerable<BCFFPJECEKP> MNIKMGFJGLN
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x24C51F0", Offset = "0x24C45F0", VA = "0x1824C51F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public KMAILICAKAC PMBFJEBKPPH
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x24C51A0", Offset = "0x24C45A0", VA = "0x1824C51A0")]
			[CompilerGenerated]
			get
			{
				return default(KMAILICAKAC);
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x24C51C0", Offset = "0x24C45C0", VA = "0x1824C51C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x24C5360", Offset = "0x24C4760", VA = "0x1824C5360")]
		internal BCFFPJECEKP(KHDPAGPOPHE<TKey> ADGMBKKGEOK, TKey KOFPKIJDAMC, PILIJFIMAJF FDJKGAAPBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x24C5210", Offset = "0x24C4610", VA = "0x1824C5210")]
		public BCFFPJECEKP OIGAMGBNCDP(TKey KOFPKIJDAMC, [Optional] PILIJFIMAJF? KHGLPBAAHKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2493EE0", Offset = "0x24932E0", VA = "0x182493EE0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(NMIINNHBDHA<>))]
		public Task<T> KDMFHJIMECN<T>(TKey KOFPKIJDAMC, Func<BCFFPJECEKP, Task<T>> NLBPDHIJABN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x24C4FF0", Offset = "0x24C43F0", VA = "0x1824C4FF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class KFNGCFOIJML : IEnumerable<(TKey, List<TKey>, KMAILICAKAC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KMAILICAKAC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private (TKey key, List<TKey> path, KMAILICAKAC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public KHDPAGPOPHE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private IEnumerator<(TKey key, List<TKey> path, KMAILICAKAC timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private (TKey key, List<TKey> path, KMAILICAKAC timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private (TKey, List<TKey>, KMAILICAKAC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x2203110", Offset = "0x2202510", VA = "0x182203110", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KMAILICAKAC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x220CE50", Offset = "0x220C250", VA = "0x18220CE50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2203460", Offset = "0x2202860", VA = "0x182203460")]
		[DebuggerHidden]
		public KFNGCFOIJML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2027A50", Offset = "0x2026E50", VA = "0x182027A50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x220CA20", Offset = "0x220BE20", VA = "0x18220CA20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x220C9D0", Offset = "0x220BDD0", VA = "0x18220C9D0")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x220CE10", Offset = "0x220C210", VA = "0x18220CE10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x220CD50", Offset = "0x220C150", VA = "0x18220CD50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KMAILICAKAC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xF00130", Offset = "0xEFF530", VA = "0x180F00130", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class FIKGBDMEFKK : IEnumerable<(TKey, List<TKey>, KMAILICAKAC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KMAILICAKAC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private (TKey key, List<TKey> path, KMAILICAKAC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private BCFFPJECEKP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public BCFFPJECEKP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public KHDPAGPOPHE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private IEnumerator<BCFFPJECEKP> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private BCFFPJECEKP <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IEnumerator<(TKey key, List<TKey> path, KMAILICAKAC timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private (TKey key, List<TKey> path, KMAILICAKAC timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		private (TKey, List<TKey>, KMAILICAKAC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x2203110", Offset = "0x2202510", VA = "0x182203110", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KMAILICAKAC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3478380", Offset = "0x3477780", VA = "0x183478380", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2203460", Offset = "0x2202860", VA = "0x182203460")]
		[DebuggerHidden]
		public FIKGBDMEFKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x34783E0", Offset = "0x34777E0", VA = "0x1834783E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3477C50", Offset = "0x3477050", VA = "0x183477C50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3477BF0", Offset = "0x3476FF0", VA = "0x183477BF0")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3477B90", Offset = "0x3476F90", VA = "0x183477B90")]
		private void HHNPGKLOEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3478340", Offset = "0x3477740", VA = "0x183478340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3478260", Offset = "0x3477660", VA = "0x183478260", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KMAILICAKAC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x2557F20", Offset = "0x2557320", VA = "0x182557F20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly Action<TKey, KMAILICAKAC, PILIJFIMAJF> MEGAJMMOAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Action<TKey, KMAILICAKAC, PILIJFIMAJF> AKCKLIGOPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Action<KHDPAGPOPHE<TKey>, PILIJFIMAJF> FJLJJHDHPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly PILIJFIMAJF FDJKGAAPBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly BCFFPJECEKP EHGKFKAFNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool NEOLAOAJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int OIGDJBFJOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly Stopwatch AFDFOBICFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public readonly int NGDBEKELILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private string COGFNNCDCJB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BCFFPJECEKP BGIGPBGFABN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	public string BIPJNBIOOME
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2211D40", Offset = "0x2211140", VA = "0x182211D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2211DA0", Offset = "0x22111A0", VA = "0x182211DA0")]
	public KHDPAGPOPHE(TKey IHAIKJEPEEP, PILIJFIMAJF FDJKGAAPBBG, [Optional] int? FDPJJACLPGB, [Optional][CanBeNull] Stopwatch AFDFOBICFFM, [Optional] Action<TKey, KMAILICAKAC, PILIJFIMAJF> MEGAJMMOAOO, [Optional] Action<TKey, KMAILICAKAC, PILIJFIMAJF> AKCKLIGOPDG, [Optional] Action<KHDPAGPOPHE<TKey>, PILIJFIMAJF> FJLJJHDHPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2211AD0", Offset = "0x2210ED0", VA = "0x182211AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2211C30", Offset = "0x2211030", VA = "0x182211C30")]
	[IteratorStateMachine(typeof(KHDPAGPOPHE<>.KFNGCFOIJML))]
	public IEnumerable<(TKey, List<TKey>, KMAILICAKAC)> ECKHPGJKEKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2211B60", Offset = "0x2210F60", VA = "0x182211B60")]
	[IteratorStateMachine(typeof(KHDPAGPOPHE<>.FIKGBDMEFKK))]
	private IEnumerable<(TKey, List<TKey>, KMAILICAKAC)> ECKHPGJKEKO(List<TKey> EKHKAHMLNOP, BCFFPJECEKP BKHOHBDFOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2211CC0", Offset = "0x22110C0", VA = "0x182211CC0")]
	private (long, int) KIAABILNFEH()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class HDEENLJOOJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly Dictionary<byte, IAOHAHFELPO> KFCJMHEDBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly KLNGOOBCKHF<IAOHAHFELPO> JACCKHFKIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly bool EHEAOKMECMK;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IAOHAHFELPO KLADJEPKLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Vector2 HPJPLPILKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xC636D0", Offset = "0xC62AD0", VA = "0x180C636D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1062210", Offset = "0x1061610", VA = "0x181062210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private Vector2 PMHHKKHLKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x10EE000", Offset = "0x10ED400", VA = "0x1810EE000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 LJNBMMEBABB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7E50", Offset = "0x6EA7250", VA = "0x186EA7E50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x17C30F0", Offset = "0x17C24F0", VA = "0x1817C30F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int LIJILPPGNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x976C20", Offset = "0x976020", VA = "0x180976C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x976BE0", Offset = "0x975FE0", VA = "0x180976BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6EA83F0", Offset = "0x6EA77F0", VA = "0x186EA83F0")]
	public HDEENLJOOJA(Bounds BEOAGNFHKOB, Vector2[] ABLCCPOPMLJ, int FGPLPOBINGJ, byte MIICGJCNLLL, float GBMFPIPBMDJ = 0f, [Optional] KLNGOOBCKHF<IAOHAHFELPO> JACCKHFKIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6EA79B0", Offset = "0x6EA6DB0", VA = "0x186EA79B0")]
	public IAOHAHFELPO CJBIACBBGFC(byte NANJAGEOPJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7E90", Offset = "0x6EA7290", VA = "0x186EA7E90")]
	public void KGIKMCDNEIE(Vector3 OMFIFBMFGMG, float FOOHALNJABN, float MEAEOPIHKFE, ref List<byte> OAJMCFIAALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7E70", Offset = "0x6EA7270", VA = "0x186EA7E70")]
	public void KEGAJBPIMHE(IAOHAHFELPO.IEFJKOBLJBE HCNECJCDLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7F60", Offset = "0x6EA7360", VA = "0x186EA7F60")]
	public static int MJNDOBJMFCH(Vector2[] ABLCCPOPMLJ, int FGPLPOBINGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7CC0", Offset = "0x6EA70C0", VA = "0x186EA7CC0")]
	private IAOHAHFELPO GJPDPHIOLMN(byte NANJAGEOPJI, IAOHAHFELPO.ANFHGGLKIPH JLJKODJMDOC, IAOHAHFELPO ILDFJHMNOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8010", Offset = "0x6EA7410", VA = "0x186EA8010")]
	private void PGHOHGEJEBL(IAOHAHFELPO ILDFJHMNOPJ, Vector2[] ABLCCPOPMLJ, int HMFGBEFHONA, int IFADIPLADPA, int AKKMCOLGCDE, int JINFPEHAGBB, float GBMFPIPBMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7A70", Offset = "0x6EA6E70", VA = "0x186EA7A70")]
	private void FBABFFOHJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7A10", Offset = "0x6EA6E10", VA = "0x186EA7A10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7C70", Offset = "0x6EA7070", VA = "0x186EA7C70", Slot = "1")]
	~HDEENLJOOJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class IAOHAHFELPO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum ANFHGGLKIPH
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum IEFJKOBLJBE
	{
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public byte MNMNLKIGNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Vector3 IOMMPDGKHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Vector3 FMHNBEKGHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Vector3 NIGOPILDJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Vector3 HIGDEDGNCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public ANFHGGLKIPH OMDJLFAOLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public IAOHAHFELPO CECPGAGDNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public List<IAOHAHFELPO> EPJFKAKOHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool GAFBHKFNGEF;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8C90", Offset = "0x6EA8090", VA = "0x186EA8C90")]
	public IAOHAHFELPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8920", Offset = "0x6EA7D20", VA = "0x186EA8920")]
	public void DHPKFCEIGDC(IAOHAHFELPO CDFHGECAPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
	public void KEGAJBPIMHE(int CFKFHACOEKO, IEFJKOBLJBE HCNECJCDLOO, int NKHPLECBDLN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8A30", Offset = "0x6EA7E30", VA = "0x186EA8A30")]
	public void KGIKMCDNEIE(List<byte> OAJMCFIAALG, Vector3 OMFIFBMFGMG, float FOOHALNJABN, float MEAEOPIHKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA89E0", Offset = "0x6EA7DE0", VA = "0x186EA89E0")]
	public bool FFHCPMBIGHK(Vector3 GAKPKGDNIKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8C60", Offset = "0x6EA8060", VA = "0x186EA8C60")]
	public bool LBOAOGNBEPO(Vector3 GAKPKGDNIKB, float AFGPPHDNPFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6EA88A0", Offset = "0x6EA7CA0", VA = "0x186EA88A0")]
	public void BEFDPLAELIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class KLNGOOBCKHF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly Stack<T> BCMPJNJCHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly List<T> GALMOKIJGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly int EIDPELIFKHB;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x22191A0", Offset = "0x22185A0", VA = "0x1822191A0")]
	public static KLNGOOBCKHF<T> AKGAICDFKCM(int EPMEDFGLJOE = 0, int EIDPELIFKHB = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x22197A0", Offset = "0x2218BA0", VA = "0x1822197A0")]
	public KLNGOOBCKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x22197E0", Offset = "0x2218BE0", VA = "0x1822197E0")]
	public KLNGOOBCKHF(int EPMEDFGLJOE, int EIDPELIFKHB = int.MaxValue, bool LGEMNFBKJGD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2219270", Offset = "0x2218670", VA = "0x182219270")]
	public T DJEGIKLMIAN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2219470", Offset = "0x2218870", VA = "0x182219470")]
	public void GGFEFJPGMCL(T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2219510", Offset = "0x2218910", VA = "0x182219510")]
	private void HJLFJDBCFPN(T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2219780", Offset = "0x2218B80", VA = "0x182219780")]
	private void PAAIALKOOIB(T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2219380", Offset = "0x2218780", VA = "0x182219380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x22195E0", Offset = "0x22189E0", VA = "0x1822195E0")]
	private void NEDGBLECOJM(IEnumerable<T> FHJNGFFBLOE)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x26141D0", Offset = "0x26135D0", VA = "0x1826141D0", Slot = "4")]
		public virtual T ALJOLKPDPNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KGMJJGLPGPD<T> : IEnumerable<KGMJJGLPGPD<T>.CILMIDPDAJK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct CILMIDPDAJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public T KKIAKNLLHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int NANJAGEOPJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class DLPHAJIEECG : IEnumerator<CILMIDPDAJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private KGMJJGLPGPD<T> MPJINGGNEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int NANJAGEOPJI;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x927610", Offset = "0x926A10", VA = "0x180927610", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public CILMIDPDAJK NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x24F4820", Offset = "0x24F3C20", VA = "0x1824F4820", Slot = "4")]
			get
			{
				return default(CILMIDPDAJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x24F4720", Offset = "0x24F3B20", VA = "0x1824F4720")]
		public DLPHAJIEECG(KGMJJGLPGPD<T> MPJINGGNEFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x24F4690", Offset = "0x24F3A90", VA = "0x1824F4690", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x24F4710", Offset = "0x24F3B10", VA = "0x1824F4710", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA2EC30", Offset = "0xA2E030", VA = "0x180A2EC30", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct GEGDBAMJPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public bool HEOOOGDFOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public T KKIAKNLLHIO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int CNKLMMNIOFF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<T, int> OJKGFMBGOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private GEGDBAMJPAH[] ECEINPCKFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private int KCINKPBLAMJ;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int NHPJEDCPAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1190BC0", Offset = "0x118FFC0", VA = "0x181190BC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x12BA4D0", Offset = "0x12B98D0", VA = "0x1812BA4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xEF36D0", Offset = "0xEF2AD0", VA = "0x180EF36D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2211230", Offset = "0x2210630", VA = "0x182211230")]
	public KGMJJGLPGPD(int EPMEDFGLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2211300", Offset = "0x2210700", VA = "0x182211300")]
	public KGMJJGLPGPD(CILMIDPDAJK[] LGDDFNCMAIL, bool FLAAGMHLEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x22110A0", Offset = "0x22104A0", VA = "0x1822110A0")]
	public int KLHBKNGNBOJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2210CD0", Offset = "0x22100D0", VA = "0x182210CD0")]
	private int IBGPHMGHPCE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2210CB0", Offset = "0x22100B0", VA = "0x182210CB0", Slot = "6")]
	protected virtual uint HPDAHMPPDNF(uint DKFONLPAIAJ, T KKIAKNLLHIO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2210C40", Offset = "0x2210040", VA = "0x182210C40")]
	public bool EJHIKFDLBAN(T KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2210610", Offset = "0x220FA10", VA = "0x182210610")]
	public int BGNBOEOKNEH(T KKIAKNLLHIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x22106C0", Offset = "0x220FAC0", VA = "0x1822106C0")]
	public T BMFFBKGOGNK(int NANJAGEOPJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2210BD0", Offset = "0x220FFD0", VA = "0x182210BD0")]
	public bool CCKFLLFIEGA(T KKIAKNLLHIO, bool NCELPGJECJG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x22109B0", Offset = "0x220FDB0", VA = "0x1822109B0")]
	public bool CCKFLLFIEGA(T KKIAKNLLHIO, int NANJAGEOPJI, bool NCELPGJECJG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2211110", Offset = "0x2210510", VA = "0x182211110")]
	private int MMHNHONJBIC(int MIICGJCNLLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x22111B0", Offset = "0x22105B0", VA = "0x1822111B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x22111B0", Offset = "0x22105B0", VA = "0x1822111B0", Slot = "4")]
	private IEnumerator<CILMIDPDAJK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		[ODADJIGNFAB(NKLEIIOOMFD.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6EA9640", Offset = "0x6EA8A40", VA = "0x186EA9640")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6EA98D0", Offset = "0x6EA8CD0", VA = "0x186EA98D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x6EA9800", Offset = "0x6EA8C00", VA = "0x186EA9800")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x6EA95B0", Offset = "0x6EA89B0", VA = "0x186EA95B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x6EA9840", Offset = "0x6EA8C40", VA = "0x186EA9840")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x6EA9770", Offset = "0x6EA8B70", VA = "0x186EA9770")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9550", Offset = "0x6EA8950", VA = "0x186EA9550")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class JOKHMPCAHBH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int EPMEDFGLJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int DJKFGOAIPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private List<T> KHFPKPBIJME;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1937CC0", Offset = "0x19370C0", VA = "0x181937CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T GJEEICJJLDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3276860", Offset = "0x3275C60", VA = "0x183276860")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public T BJBBJBILINC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x32765E0", Offset = "0x32759E0", VA = "0x1832765E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public T KFCFGPOFHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3276730", Offset = "0x3275B30", VA = "0x183276730")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3276930", Offset = "0x3275D30", VA = "0x183276930")]
	public JOKHMPCAHBH(int EPMEDFGLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x32763F0", Offset = "0x32757F0", VA = "0x1832763F0")]
	public void EBOHBLNDMAL(T KEPJALMFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x32768F0", Offset = "0x3275CF0", VA = "0x1832768F0")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3276690", Offset = "0x3275A90", VA = "0x183276690")]
	public void LIEIBFKMBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3276640", Offset = "0x3275A40", VA = "0x183276640")]
	public void LDJJJOIACNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x32763E0", Offset = "0x32757E0", VA = "0x1832763E0")]
	public void AHLLMDHPGMA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct PJKPDJBJECH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private readonly List<Component> OCCNFAKIALD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private readonly bool BCGIOOCBECJ;

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x16CF090", Offset = "0x16CE490", VA = "0x1816CF090")]
			public PJKPDJBJECH(List<Component> OCCNFAKIALD, bool BCGIOOCBECJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x26B49D0", Offset = "0x26B3DD0", VA = "0x1826B49D0")]
			public PHPDJHOFPBP<T> FNKOJPGNHJL()
			{
				return default(PHPDJHOFPBP<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x26B4A30", Offset = "0x26B3E30", VA = "0x1826B4A30", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x26B4A30", Offset = "0x26B3E30", VA = "0x1826B4A30", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public struct PHPDJHOFPBP<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private readonly List<Component> OCCNFAKIALD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private readonly bool BCGIOOCBECJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private int NANJAGEOPJI;

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public T NEGPJPJCKFH
			{
				[Cpp2IlInjected.Token(Token = "0x60001C2")]
				[Cpp2IlInjected.Address(RVA = "0x26AD6D0", Offset = "0x26ACAD0", VA = "0x1826AD6D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0x26AD660", Offset = "0x26ACA60", VA = "0x1826AD660", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x26AD6A0", Offset = "0x26ACAA0", VA = "0x1826AD6A0")]
			public PHPDJHOFPBP(List<Component> OCCNFAKIALD, bool BCGIOOCBECJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x26AD590", Offset = "0x26AC990", VA = "0x1826AD590", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x26AD5A0", Offset = "0x26AC9A0", VA = "0x1826AD5A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x240A5F0", Offset = "0x24099F0", VA = "0x18240A5F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAEC0", Offset = "0x6EAA2C0", VA = "0x186EAAEC0")]
		private void BEFDPLAELIH(GameObject BKJBFAHBGJH, bool FCCLLNHHFFA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAD10", Offset = "0x6EAA110", VA = "0x186EAAD10")]
		public static void BEFDPLAELIH(GameObject BKJBFAHBGJH, ref ToolHierarchyCache ILGBPFIMIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC2D0", Offset = "0x2DDB6D0", VA = "0x182DDC2D0")]
		public void EDHCGFKIHAA<T>(Action<T> FJBAKNFCPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC630", Offset = "0x2DDBA30", VA = "0x182DDC630")]
		public T ONDNBLHDLHO<T>(bool BCGIOOCBECJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2DDC560", Offset = "0x2DDB960", VA = "0x182DDC560")]
		public PJKPDJBJECH<T> FHNHNMHNFGM<T>(bool BCGIOOCBECJ = false) where T : class
		{
			return default(PJKPDJBJECH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB030", Offset = "0x6EAA430", VA = "0x186EAB030")]
		public List<Component> DEALFOLFGEI(Type JLNNFEOBAMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB380", Offset = "0x6EAA780", VA = "0x186EAB380", Slot = "4")]
		public bool Equals(ToolHierarchyCache GEAEMIOLNKK, ToolHierarchyCache KFMHCNGHPHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB400", Offset = "0x6EAA800", VA = "0x186EAB400", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ICNDEPGFBMI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JHHNNKKHDMD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Dictionary<int, T> CEDFPOKBHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private T KJAKPLPNHNG;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public virtual T JKCALPOOOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x98CB30", Offset = "0x98BF30", VA = "0x18098CB30", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DC90", Offset = "0x2D1D090", VA = "0x182D1DC90")]
	public bool NMLCIHAMFBM(T KKIAKNLLHIO, int MPPIPNLCJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x204C930", Offset = "0x204BD30", VA = "0x18204C930")]
	public bool AHKPFGCGLCO(int MPPIPNLCJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2D1D8C0", Offset = "0x2D1CCC0", VA = "0x182D1D8C0")]
	public T CMFAPLFDHOE(int LPPKNDHGLKJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DC00", Offset = "0x2D1D000", VA = "0x182D1DC00")]
	private bool JDOLJKHFLJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DAC0", Offset = "0x2D1CEC0", VA = "0x182D1DAC0")]
	public bool HPMOKKNEDOE(int MPPIPNLCJMN, out T KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D1DD50", Offset = "0x2D1D150", VA = "0x182D1DD50")]
	public JHHNNKKHDMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class OLGDMHKCIHP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class JBGDOEKBIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public TNode JCOLBAAGCGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public TNode ILDFJHMNOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public IJPKCJDJCOE IOEMOEOMBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public List<IJPKCJDJCOE> LKGAKHOGJOJ;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public JBGDOEKBIJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	internal struct IJPKCJDJCOE : IComparable<IJPKCJDJCOE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int MPPIPNLCJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TClaimant NEBMFKKFCGB;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xB96660", Offset = "0xB95A60", VA = "0x180B96660")]
		public IJPKCJDJCOE(int MPPIPNLCJMN, TClaimant NEBMFKKFCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x25840D0", Offset = "0x25834D0", VA = "0x1825840D0")]
		public bool GHEFMAEAJFH(in IJPKCJDJCOE LNOOAJJNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x25840B0", Offset = "0x25834B0", VA = "0x1825840B0")]
		public bool CLCCEJFIFKK(in IJPKCJDJCOE LNOOAJJNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x25840C0", Offset = "0x25834C0", VA = "0x1825840C0", Slot = "4")]
		public int CompareTo(IJPKCJDJCOE LNOOAJJNCAE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2584130", Offset = "0x2583530", VA = "0x182584130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum ODAFOOOALHN
	{
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LKCCAMBENBG : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public OLGDMHKCIHP<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x204C140", Offset = "0x204B540", VA = "0x18204C140")]
		[DebuggerHidden]
		public LKCCAMBENBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x204BF30", Offset = "0x204B330", VA = "0x18204BF30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x204C100", Offset = "0x204B500", VA = "0x18204C100", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x204C020", Offset = "0x204B420", VA = "0x18204C020", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F5DF40", Offset = "0x1F5D340", VA = "0x181F5DF40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly KLNGOOBCKHF<JBGDOEKBIJM> FIFKJHBHBJP;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly KLNGOOBCKHF<List<IJPKCJDJCOE>> IGIOBLBFOOC;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static int OOFMBKOKOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	internal readonly Dictionary<TClaimant, TNode> NGJFFMHHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	internal readonly Dictionary<TNode, JBGDOEKBIJM> ENIGJHGOFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private ODAFOOOALHN MMGKIPGKNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool MMLDFGNKLLJ;

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode BGOPCJKFHEJ(TNode GJCCBHONDAB);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DDLBLDBFNOM(TNode GJCCBHONDAB, TClaimant NEFJFKKLAEN, TClaimant HADDNGNMGDN);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3372B50", Offset = "0x3371F50", VA = "0x183372B50")]
	public OLGDMHKCIHP(ODAFOOOALHN MMGKIPGKNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3372910", Offset = "0x3371D10", VA = "0x183372910")]
	public void MKLMHBGEGKB(TNode GJCCBHONDAB, TNode GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3371CF0", Offset = "0x33710F0", VA = "0x183371CF0")]
	public void EAEAFJBKGND(TClaimant NEBMFKKFCGB, TNode BALLAMIJFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3371A90", Offset = "0x3370E90", VA = "0x183371A90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x33724A0", Offset = "0x33718A0", VA = "0x1833724A0")]
	private void JLOANDCIMOG(TClaimant NEBMFKKFCGB, TNode OMFLJHPNDKK, TNode BALLAMIJFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3372990", Offset = "0x3371D90", VA = "0x183372990")]
	private int OMFCGGFGFEK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3371380", Offset = "0x3370780", VA = "0x183371380")]
	private void ACJNILOMKPA(TClaimant NEBMFKKFCGB, TNode BEBKIKANBAO, TNode MODHKGGCBAP, int GKIKFNANNPH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3371A00", Offset = "0x3370E00", VA = "0x183371A00")]
	private void BMFICDEHGOC(IJPKCJDJCOE GOFIDCBOEOA, JBGDOEKBIJM OHLCDEFMLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3372180", Offset = "0x3371580", VA = "0x183372180")]
	private void FOJDDNAOLJC(TClaimant NEBMFKKFCGB, TNode BEBKIKANBAO, TNode MODHKGGCBAP, int GKIKFNANNPH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3371640", Offset = "0x3370A40", VA = "0x183371640")]
	private void AFEFLPONPNA(IJPKCJDJCOE GOFIDCBOEOA, TNode GJCCBHONDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3372080", Offset = "0x3371480", VA = "0x183372080")]
	private void FJAMIFCCOED(IJPKCJDJCOE GOFIDCBOEOA, JBGDOEKBIJM OHLCDEFMLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x33718E0", Offset = "0x3370CE0", VA = "0x1833718E0")]
	private void AMJHAFKEEEF(JBGDOEKBIJM OHLCDEFMLHM, bool LIICHFLPDAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3372540", Offset = "0x3371940", VA = "0x183372540")]
	private void KBNNNFFBMEB(JBGDOEKBIJM OHLCDEFMLHM, TNode GHLIBENNEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3371DF0", Offset = "0x33711F0", VA = "0x183371DF0")]
	[IteratorStateMachine(typeof(OLGDMHKCIHP<, >.LKCCAMBENBG))]
	private IEnumerable<TNode> EGNBOMOFBLE(TNode BEBKIKANBAO, TNode MODHKGGCBAP, bool LHBIDJHNCPP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x33723E0", Offset = "0x33717E0", VA = "0x1833723E0")]
	private JBGDOEKBIJM GPGOHFKKDMA(TNode GJCCBHONDAB, TNode ILDFJHMNOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3371750", Offset = "0x3370B50", VA = "0x183371750")]
	private JBGDOEKBIJM AIDKIGCCLCC(TNode GJCCBHONDAB, TNode ILDFJHMNOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3371EC0", Offset = "0x33712C0", VA = "0x183371EC0")]
	private void FAKANFANEEF(JBGDOEKBIJM OHLCDEFMLHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class OENKMMELKFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	protected struct COMJCLLOCIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T EEMAOFBHODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int HLLFDJFBAPB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	protected readonly List<COMJCLLOCIF> IDMGKIDLCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private T LODFGBOHMJO;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xEF36D0", Offset = "0xEF2AD0", VA = "0x180EF36D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2F2E1F0", Offset = "0x2F2D5F0", VA = "0x182F2E1F0")]
	public bool KBBBHMHGNAB(T KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2F2DFA0", Offset = "0x2F2D3A0", VA = "0x182F2DFA0")]
	public void EBOHBLNDMAL(T KKIAKNLLHIO, int MPPIPNLCJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2F2E460", Offset = "0x2F2D860", VA = "0x182F2E460")]
	public bool PBDAKCGNFND(T KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2F2E580", Offset = "0x2F2D980", VA = "0x182F2E580")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2F2E3F0", Offset = "0x2F2D7F0", VA = "0x182F2E3F0")]
	public T LJDKDICAGPD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2F2E040", Offset = "0x2F2D440", VA = "0x182F2E040")]
	private void IMOIJEPJAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2F2E5E0", Offset = "0x2F2D9E0", VA = "0x182F2E5E0")]
	public OENKMMELKFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class PJJJNBPABEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private struct NOOAGMGBIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int HLLFDJFBAPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public T EEMAOFBHODN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly Dictionary<object, NOOAGMGBIJN> CEDFPOKBHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly EqualityComparer<T> NBAAEFMGNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private T KJAKPLPNHNG;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual T JKCALPOOOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x26AF980", Offset = "0x26AED80", VA = "0x1826AF980", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x26AF910", Offset = "0x26AED10", VA = "0x1826AF910", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool NAANDMNLDAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x26B4820", Offset = "0x26B3C20", VA = "0x1826B4820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public object HHLLCJBBFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x26B4420", Offset = "0x26B3820", VA = "0x1826B4420")]
	public bool NMLCIHAMFBM(T KKIAKNLLHIO, object GAOLOMEJCOK, int MPPIPNLCJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x26AF870", Offset = "0x26AEC70", VA = "0x1826AF870")]
	public bool AHKPFGCGLCO(object GAOLOMEJCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x26AFD70", Offset = "0x26AF170", VA = "0x1826AFD70")]
	public bool HPMOKKNEDOE(object GAOLOMEJCOK, out T KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x26B4850", Offset = "0x26B3C50", VA = "0x1826B4850")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x26B0070", Offset = "0x26AF470", VA = "0x1826B0070")]
	private bool JDOLJKHFLJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x26B4880", Offset = "0x26B3C80", VA = "0x1826B4880")]
	public PJJJNBPABEA()
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
