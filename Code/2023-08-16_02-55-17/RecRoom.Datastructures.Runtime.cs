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
		[Cpp2IlInjected.Address(RVA = "0x7E2180", Offset = "0x7E1380", VA = "0x1807E2180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB4F8A0", Offset = "0xB4EAA0", VA = "0x180B4F8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB09AC0", Offset = "0xB08CC0", VA = "0x180B09AC0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB0A140", Offset = "0xB09340", VA = "0x180B0A140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
	public virtual void AGAEKGMOMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
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
	[PJEEBJFABDP]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x46AA3C0", Offset = "0x46A95C0", VA = "0x1846AA3C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x46A9B20", Offset = "0x46A8D20", VA = "0x1846A9B20", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x46AA8F0", Offset = "0x46A9AF0", VA = "0x1846AA8F0")]
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
	private sealed class EJOFFKCLIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public EJOFFKCLIFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3140920", Offset = "0x313FB20", VA = "0x183140920")]
		internal int EJGIFPGEGBG(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[PJEEBJFABDP]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBB8990", Offset = "0xBB7B90", VA = "0x180BB8990", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xBB89C0", Offset = "0xBB7BC0", VA = "0x180BB89C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xBB88E0", Offset = "0xBB7AE0", VA = "0x180BB88E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey JCEGKCPOPDM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xBB8940", Offset = "0xBB7B40", VA = "0x180BB8940", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBB87E0", Offset = "0xBB79E0", VA = "0x180BB87E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xBB8300", Offset = "0xBB7500", VA = "0x180BB8300", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xBB7B20", Offset = "0xBB6D20", VA = "0x180BB7B20", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xBB76B0", Offset = "0xBB68B0", VA = "0x180BB76B0", Slot = "14")]
	protected virtual string BAMCCFABDOP(TKeyVal OFPNHDJDNPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xBB7740", Offset = "0xBB6940", VA = "0x180BB7740", Slot = "4")]
	public bool ContainsKey(TKey JCEGKCPOPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0xBB86C0", Offset = "0xBB78C0", VA = "0x180BB86C0", Slot = "5")]
	public bool TryGetValue(TKey JCEGKCPOPDM, out TVal NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xBB7770", Offset = "0xBB6970", VA = "0x180BB7770", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xBB7770", Offset = "0xBB6970", VA = "0x180BB7770", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xBB86F0", Offset = "0xBB78F0", VA = "0x180BB86F0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BCBHAOLEIPA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IJKHKJHIJHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public IJKHKJHIJHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x256EC40", Offset = "0x256DE40", VA = "0x18256EC40")]
		internal bool FBMBAJMGAHE(KKKJJIOCNBF<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float HHBMKGPNHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float OKIPAEPPMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<KKKJJIOCNBF<float, T>> DJEFJBAFIHL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int COCNKAAMOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x50808E0", Offset = "0x507FAE0", VA = "0x1850808E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5080A20", Offset = "0x507FC20", VA = "0x185080A20")]
	public BCBHAOLEIPA(float PGGMOKKEFLC, float BDJCNMJGDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5080700", Offset = "0x507F900", VA = "0x185080700")]
	public bool JCGMLIBNLLM(float BNIHPJCDFCP, T NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x507FEF0", Offset = "0x507F0F0", VA = "0x18507FEF0")]
	public IEnumerable<T> GBHFGGPDAMN(float BNIHPJCDFCP, [Optional] float? FCFGFMEHKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5080570", Offset = "0x507F770", VA = "0x185080570")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5080960", Offset = "0x507FB60", VA = "0x185080960")]
	private void MKFFDKGPEBE(float BNIHPJCDFCP)
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
	public T HDFPEMDEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3878CE0", Offset = "0x3877EE0", VA = "0x183878CE0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3878CF0", Offset = "0x3877EF0", VA = "0x183878CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float JICHKAHLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA3F270", Offset = "0xA3E470", VA = "0x180A3F270")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3878BF0", Offset = "0x3877DF0", VA = "0x183878BF0")]
	public T GMCJCGJGJBD(float APIDLMAPAPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3878D90", Offset = "0x3877F90", VA = "0x183878D90")]
	public T MNKALKLPJPM(float APIDLMAPAPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LNDKIJIMGEN(T MHFLHKLCNGM, T NKPGENLIMOI, float APIDLMAPAPO);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4F36820", Offset = "0x4F35A20", VA = "0x184F36820", Slot = "4")]
	protected override float LNDKIJIMGEN(float MHFLHKLCNGM, float NKPGENLIMOI, float APIDLMAPAPO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E61860", Offset = "0x6E60A60", VA = "0x186E61860")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x9F2D20", Offset = "0x9F1F20", VA = "0x1809F2D20", Slot = "4")]
	protected override Vector3 LNDKIJIMGEN(Vector3 MHFLHKLCNGM, Vector3 NKPGENLIMOI, float APIDLMAPAPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E65960", Offset = "0x6E64B60", VA = "0x186E65960")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E60410", Offset = "0x6E5F610", VA = "0x186E60410", Slot = "4")]
	protected override Color LNDKIJIMGEN(Color MHFLHKLCNGM, Color NKPGENLIMOI, float APIDLMAPAPO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E60470", Offset = "0x6E5F670", VA = "0x186E60470")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PBLFBFIADEL
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2342780", Offset = "0x2341980", VA = "0x182342780")]
	public static KKKJJIOCNBF<T1, T2> JKAAGGANCJG<T1, T2>(T1 HPFEHEFCMLL, T2 CMCMKKBHGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x23427F0", Offset = "0x23419F0", VA = "0x1823427F0")]
	public static HEHIPHCJOEE<T1, T2, T3> JKAAGGANCJG<T1, T2, T3>(T1 HPFEHEFCMLL, T2 CMCMKKBHGGG, T3 KBBNKHBFIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E629F0", Offset = "0x6E61BF0", VA = "0x186E629F0")]
	internal static int HPFOLEIBFOO(int HBCPHCJAAEE, int FHILIIJBBPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E629E0", Offset = "0x6E61BE0", VA = "0x186E629E0")]
	internal static int HPFOLEIBFOO(int HBCPHCJAAEE, int FHILIIJBBPO, int EHEBHHDFPPP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KKKJJIOCNBF<T1, T2> : IComparable<KKKJJIOCNBF<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T1 HFDKCDIHHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly T2 PBODGMJDNNE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2E569E0", Offset = "0x2E55BE0", VA = "0x182E569E0")]
	public KKKJJIOCNBF(T1 HPFEHEFCMLL, T2 CMCMKKBHGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x327C000", Offset = "0x327B200", VA = "0x18327C000", Slot = "4")]
	public int CompareTo(KKKJJIOCNBF<T1, T2> JMNBIHILIIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x327C750", Offset = "0x327B950", VA = "0x18327C750", Slot = "0")]
	public override bool Equals(object JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x327CE20", Offset = "0x327C020", VA = "0x18327CE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x327D740", Offset = "0x327C940", VA = "0x18327D740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HEHIPHCJOEE<T1, T2, T3> : IComparable<HEHIPHCJOEE<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly T1 HFDKCDIHHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T2 PBODGMJDNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T3 GFJPMDIBMMD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2094780", Offset = "0x2093980", VA = "0x182094780")]
	public HEHIPHCJOEE(T1 HPFEHEFCMLL, T2 CMCMKKBHGGG, T3 KBBNKHBFIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2093EC0", Offset = "0x20930C0", VA = "0x182093EC0", Slot = "4")]
	public int CompareTo(HEHIPHCJOEE<T1, T2, T3> JMNBIHILIIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x20940C0", Offset = "0x20932C0", VA = "0x1820940C0", Slot = "0")]
	public override bool Equals(object JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x20943E0", Offset = "0x20935E0", VA = "0x1820943E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2094550", Offset = "0x2093750", VA = "0x182094550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PJEEBJFABDP : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	public PJEEBJFABDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class HashableScriptableObject : ScriptableObject, PNDNNDBPIOF, PPPKCBIDPMP, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x94C6C0", Offset = "0x94B8C0", VA = "0x18094C6C0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IDCDAKKLOPN);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x99A150", Offset = "0x999350", VA = "0x18099A150")]
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
	[OLFNKEDKIDF]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[HideInInspector]
	[SerializeField]
	[OLFNKEDKIDF]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E649F0", Offset = "0x6E63BF0", VA = "0x186E649F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E649B0", Offset = "0x6E63BB0", VA = "0x186E649B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E64A30", Offset = "0x6E63C30", VA = "0x186E64A30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E64BE0", Offset = "0x6E63DE0", VA = "0x186E64BE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E64B50", Offset = "0x6E63D50", VA = "0x186E64B50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99B890", Offset = "0x99AA90", VA = "0x18099B890")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x893F50", Offset = "0x893150", VA = "0x180893F50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6E64970", Offset = "0x6E63B70", VA = "0x186E64970")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6E64AC0", Offset = "0x6E63CC0", VA = "0x186E64AC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E643C0", Offset = "0x6E635C0", VA = "0x186E643C0")]
	public void CopyBounds(SavedExtents JMNBIHILIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E648D0", Offset = "0x6E63AD0", VA = "0x186E648D0")]
	public void SetLocalSpaceBounds(Bounds HGHMKMLADOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E63D60", Offset = "0x6E62F60", VA = "0x186E63D60")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E648C0", Offset = "0x6E63AC0", VA = "0x186E648C0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E644B0", Offset = "0x6E636B0", VA = "0x186E644B0")]
	private void MOIHONAJKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E64690", Offset = "0x6E63890", VA = "0x186E64690")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E63D80", Offset = "0x6E62F80", VA = "0x186E63D80")]
	public static void CalculateLocalBoundsFor(GameObject HAAGKPEGEHP, out Bounds HGHMKMLADOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E643F0", Offset = "0x6E635F0", VA = "0x186E643F0")]
	private static void IPECPGOINAC(Bounds PIINDHALINJ, Color MGJAHLJBKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E648F0", Offset = "0x6E63AF0", VA = "0x186E648F0")]
	public SavedExtents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PJKHCNLPPON<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct EPBINKHHFCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public T HDFPEMDEFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public float FIMACEEHAOE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static float EPOPEEFOKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private List<T> LJGJHAFHHLG;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const int HIBODDEODKP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EPBINKHHFCI[] LMFDNLBGHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private int HDADNABOODC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float HFCDMHGKFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xC31D40", Offset = "0xC30F40", VA = "0x180C31D40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1056BA0", Offset = "0x1055DA0", VA = "0x181056BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AAE0", Offset = "0x4C29CE0", VA = "0x184C2AAE0")]
	public PJKHCNLPPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AB10", Offset = "0x4C29D10", VA = "0x184C2AB10")]
	public PJKHCNLPPON(int JPJMMBFGIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4C29C40", Offset = "0x4C28E40", VA = "0x184C29C40")]
	public void CKPKOIJGHLD(float BNIHPJCDFCP, T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A120", Offset = "0x4C29320", VA = "0x184C2A120")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A650", Offset = "0x4C29850", VA = "0x184C2A650")]
	public bool OJIOGDEOEDI(float DNDEMKMKCAH, float HEBJFKIKIGG, out T NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4C29E00", Offset = "0x4C29000", VA = "0x184C29E00")]
	public bool DKCJNDOOAJK(float DNDEMKMKCAH, float HEBJFKIKIGG, out T NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A810", Offset = "0x4C29A10", VA = "0x184C2A810")]
	public void PAFANFLPMKE(float DNDEMKMKCAH, float HEBJFKIKIGG, List<T> JEDMILCBKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A400", Offset = "0x4C29600", VA = "0x184C2A400")]
	private int NEKFMJIAHMJ(int PDHAAIHEIMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A3C0", Offset = "0x4C295C0", VA = "0x184C2A3C0")]
	private void MGMFOKGBNKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OOGAPPPJDAL();

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T KJDNNIPOMLM(T NABCGCEIEGG, float APIDLMAPAPO);

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T NNNHEGPMJAF(T MHFLHKLCNGM, T NKPGENLIMOI);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JOLGJKIIJHI(T MHFLHKLCNGM, T NKPGENLIMOI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class INEFPEHIAIM : PJKHCNLPPON<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xD51560", Offset = "0xD50760", VA = "0x180D51560", Slot = "4")]
	protected override Vector3 OOGAPPPJDAL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E61E40", Offset = "0x6E61040", VA = "0x186E61E40", Slot = "5")]
	protected override Vector3 KJDNNIPOMLM(Vector3 NABCGCEIEGG, float APIDLMAPAPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E61E80", Offset = "0x6E61080", VA = "0x186E61E80", Slot = "6")]
	protected override Vector3 NNNHEGPMJAF(Vector3 MHFLHKLCNGM, Vector3 NKPGENLIMOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E61DD0", Offset = "0x6E60FD0", VA = "0x186E61DD0", Slot = "7")]
	protected override Vector3 JOLGJKIIJHI(Vector3 MHFLHKLCNGM, Vector3 NKPGENLIMOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E61ED0", Offset = "0x6E610D0", VA = "0x186E61ED0")]
	public INEFPEHIAIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FKKAMKKOJDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable JHOAALADPKE;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public FKKAMKKOJDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HBFHOKKPDPN : FGDECKOODIN<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E61910", Offset = "0x6E60B10", VA = "0x186E61910")]
	public HBFHOKKPDPN(int HCKHKGKDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E618A0", Offset = "0x6E60AA0", VA = "0x186E618A0", Slot = "6")]
	protected override uint HCJANKDNEOP(uint IDCDAKKLOPN, string NABCGCEIEGG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DefaultMember("Item")]
public class HDANEPNBHIH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private HDANEPNBHIH<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x7E9420", Offset = "0x7E8620", VA = "0x1807E9420", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2875560", Offset = "0x2874760", VA = "0x182875560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2877670", Offset = "0x2876870", VA = "0x182877670")]
		public Enumerator(HDANEPNBHIH<T> JEDMILCBKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28730E0", Offset = "0x28722E0", VA = "0x1828730E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2874EB0", Offset = "0x28740B0", VA = "0x182874EB0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2872970", Offset = "0x2871B70", VA = "0x182872970")]
		private void FIDCEOINHGB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private T[] AKCKPAIDKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ILJCPGHFJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int PHJMKIJHKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int KBIJDJHCEBH;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2434410", Offset = "0x2433610", VA = "0x182434410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2434580", Offset = "0x2433780", VA = "0x182434580")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2434390", Offset = "0x2433590", VA = "0x182434390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2434C80", Offset = "0x2433E80", VA = "0x182434C80")]
	public HDANEPNBHIH(int HCKHKGKDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2433EE0", Offset = "0x24330E0", VA = "0x182433EE0")]
	public void CKPKOIJGHLD(T APIDLMAPAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2434200", Offset = "0x2433400", VA = "0x182434200")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2433D90", Offset = "0x2432F90", VA = "0x182433D90")]
	public void CGLNPCNIIDE(int BKHJHJOLNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2434710", Offset = "0x2433910", VA = "0x182434710")]
	public void NHJBPEIGKJH(T[] LMFDNLBGHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2434160", Offset = "0x2433360", VA = "0x182434160")]
	public Enumerator EEOIHAEEMHN()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2434C00", Offset = "0x2433E00", VA = "0x182434C00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2434C00", Offset = "0x2433E00", VA = "0x182434C00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2433CA0", Offset = "0x2432EA0", VA = "0x182433CA0")]
	private int BKHHFDMCDKE(int NNAODBDJDNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2434AD0", Offset = "0x2433CD0", VA = "0x182434AD0")]
	private int ONCBGJHDNNE(int NNAODBDJDNJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class FFGLCLEOJJK
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	protected FFGLCLEOJJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class MBCPNBDDLAC<T> : FFGLCLEOJJK
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	protected struct DFDCFCNABAE
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum GKLCOABAIDO
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
		public GKLCOABAIDO FBNKHAJKFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public T AMEKOPCKNIK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int OKDOAAGIIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly bool ACKONIKHOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	protected readonly bool POPIBDDBHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	protected List<T> HLGIOANOHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<DFDCFCNABAE> LCKAPFLGPNA;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool MAEHLEDABAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF09F0", Offset = "0x2AEFBF0", VA = "0x182AF09F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0BE0", Offset = "0x2AEFDE0", VA = "0x182AF0BE0")]
	protected MBCPNBDDLAC(bool POPIBDDBHMK, bool ACKONIKHOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0650", Offset = "0x2AEF850", VA = "0x182AF0650")]
	protected bool DLDKPHHJABG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2AF06D0", Offset = "0x2AEF8D0", VA = "0x182AF06D0")]
	protected void GEDAIJFCJGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0A30", Offset = "0x2AEFC30", VA = "0x182AF0A30")]
	protected void LJEMJAAKGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x236BBB0", Offset = "0x236ADB0", VA = "0x18236BBB0")]
	private static void COBAPBNLDDL<U>(ref List<U> MLEOGHHEJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2AF04F0", Offset = "0x2AEF6F0", VA = "0x182AF04F0", Slot = "4")]
	public void CKPKOIJGHLD(T AMEKOPCKNIK, bool CJBAINJNPNI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0790", Offset = "0x2AEF990", VA = "0x182AF0790", Slot = "5")]
	public void HCICIMHFKFM(T AMEKOPCKNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2AF08E0", Offset = "0x2AEFAE0", VA = "0x182AF08E0")]
	public void HNOBOGMOMNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KFAJAJKAPJK
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKPKOIJGHLD(Action AMEKOPCKNIK, bool CJBAINJNPNI = false);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCICIMHFKFM(Action AMEKOPCKNIK);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class HFMPGNIBJKD : MBCPNBDDLAC<Action>, KFAJAJKAPJK
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E61C30", Offset = "0x6E60E30", VA = "0x186E61C30")]
	public HFMPGNIBJKD(bool POPIBDDBHMK = false, bool ACKONIKHOEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E61A20", Offset = "0x6E60C20", VA = "0x186E61A20")]
	public void LDFPBHJMNFE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E61960", Offset = "0x6E60B60", VA = "0x186E61960")]
	public static HFMPGNIBJKD IHPBIBCICGK(HFMPGNIBJKD JLMLPFMNMHP, Action AMEKOPCKNIK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E619C0", Offset = "0x6E60BC0", VA = "0x186E619C0")]
	public static HFMPGNIBJKD JFKBDLPLABC(HFMPGNIBJKD JLMLPFMNMHP, Action AMEKOPCKNIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LAIIIINMFPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKPKOIJGHLD(Action<T> AMEKOPCKNIK, bool CJBAINJNPNI = false);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCICIMHFKFM(Action<T> AMEKOPCKNIK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class CHBPAJLHAAD<T> : MBCPNBDDLAC<Action<T>>, LAIIIINMFPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x163E470", Offset = "0x163D670", VA = "0x18163E470")]
	public CHBPAJLHAAD(bool POPIBDDBHMK = false, bool ACKONIKHOEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CD7740", Offset = "0x3CD6940", VA = "0x183CD7740")]
	public void LDFPBHJMNFE(T APIDLMAPAPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x163DA80", Offset = "0x163CC80", VA = "0x18163DA80")]
	public static CHBPAJLHAAD<T> IHPBIBCICGK(CHBPAJLHAAD<T> JLMLPFMNMHP, Action<T> AMEKOPCKNIK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x163DB10", Offset = "0x163CD10", VA = "0x18163DB10")]
	public static CHBPAJLHAAD<T> JFKBDLPLABC(CHBPAJLHAAD<T> JLMLPFMNMHP, Action<T> AMEKOPCKNIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FEKGBKDBBFI<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JNEFBENJBGD<T, U> : MBCPNBDDLAC<Action<T, U>>, FEKGBKDBBFI<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x163E470", Offset = "0x163D670", VA = "0x18163E470")]
	public JNEFBENJBGD(bool POPIBDDBHMK = false, bool ACKONIKHOEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2931B00", Offset = "0x2930D00", VA = "0x182931B00")]
	public void LDFPBHJMNFE(T APIDLMAPAPO, U JCLNDFMBPFE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x163DA80", Offset = "0x163CC80", VA = "0x18163DA80")]
	public static JNEFBENJBGD<T, U> IHPBIBCICGK(JNEFBENJBGD<T, U> JLMLPFMNMHP, Action<T, U> AMEKOPCKNIK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x163DB10", Offset = "0x163CD10", VA = "0x18163DB10")]
	public static JNEFBENJBGD<T, U> JFKBDLPLABC(JNEFBENJBGD<T, U> JLMLPFMNMHP, Action<T, U> AMEKOPCKNIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OLNNONJGCMF<T, U, V> : MBCPNBDDLAC<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x163E470", Offset = "0x163D670", VA = "0x18163E470")]
	public OLNNONJGCMF(bool POPIBDDBHMK = false, bool ACKONIKHOEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x202D450", Offset = "0x202C650", VA = "0x18202D450")]
	public void LDFPBHJMNFE(T APIDLMAPAPO, U JCLNDFMBPFE, V DGJKEMKCNIO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x163DA80", Offset = "0x163CC80", VA = "0x18163DA80")]
	public static OLNNONJGCMF<T, U, V> IHPBIBCICGK(OLNNONJGCMF<T, U, V> JLMLPFMNMHP, Action<T, U, V> AMEKOPCKNIK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x163DB10", Offset = "0x163CD10", VA = "0x18163DB10")]
	public static OLNNONJGCMF<T, U, V> JFKBDLPLABC(OLNNONJGCMF<T, U, V> JLMLPFMNMHP, Action<T, U, V> AMEKOPCKNIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GAKHMBAJCOF<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GJAHAMFOLIA<T, U, V, W> : MBCPNBDDLAC<Action<T, U, V, W>>, GAKHMBAJCOF<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x163E470", Offset = "0x163D670", VA = "0x18163E470")]
	public GJAHAMFOLIA(bool POPIBDDBHMK = false, bool ACKONIKHOEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x26FECD0", Offset = "0x26FDED0", VA = "0x1826FECD0")]
	public void LDFPBHJMNFE(T APIDLMAPAPO, U JCLNDFMBPFE, V DGJKEMKCNIO, W PAOCKMKCBDM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x163DA80", Offset = "0x163CC80", VA = "0x18163DA80")]
	public static GJAHAMFOLIA<T, U, V, W> IHPBIBCICGK(GJAHAMFOLIA<T, U, V, W> JLMLPFMNMHP, Action<T, U, V, W> AMEKOPCKNIK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x163DB10", Offset = "0x163CD10", VA = "0x18163DB10")]
	public static GJAHAMFOLIA<T, U, V, W> JFKBDLPLABC(GJAHAMFOLIA<T, U, V, W> JLMLPFMNMHP, Action<T, U, V, W> AMEKOPCKNIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class HJPLEELNLHO<T, U, V, W, X> : MBCPNBDDLAC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x163E470", Offset = "0x163D670", VA = "0x18163E470")]
	public HJPLEELNLHO(bool POPIBDDBHMK = false, bool ACKONIKHOEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x20AAC40", Offset = "0x20A9E40", VA = "0x1820AAC40")]
	public void LDFPBHJMNFE(T APIDLMAPAPO, U JCLNDFMBPFE, V DGJKEMKCNIO, W PAOCKMKCBDM, X JPBGAMDOIJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x163DA80", Offset = "0x163CC80", VA = "0x18163DA80")]
	public static HJPLEELNLHO<T, U, V, W, X> IHPBIBCICGK(HJPLEELNLHO<T, U, V, W, X> JLMLPFMNMHP, Action<T, U, V, W, X> AMEKOPCKNIK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x163DB10", Offset = "0x163CD10", VA = "0x18163DB10")]
	public static HJPLEELNLHO<T, U, V, W, X> JFKBDLPLABC(HJPLEELNLHO<T, U, V, W, X> JLMLPFMNMHP, Action<T, U, V, W, X> AMEKOPCKNIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class EODAGJGPGIK<T, U, V, W, X, Y> : MBCPNBDDLAC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x163E470", Offset = "0x163D670", VA = "0x18163E470")]
	public EODAGJGPGIK(bool POPIBDDBHMK = false, bool ACKONIKHOEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x163DE70", Offset = "0x163D070", VA = "0x18163DE70")]
	public void LDFPBHJMNFE(T APIDLMAPAPO, U JCLNDFMBPFE, V DGJKEMKCNIO, W PAOCKMKCBDM, X JPBGAMDOIJA, Y IIJHAMIHIMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x163DA80", Offset = "0x163CC80", VA = "0x18163DA80")]
	public static EODAGJGPGIK<T, U, V, W, X, Y> IHPBIBCICGK(EODAGJGPGIK<T, U, V, W, X, Y> JLMLPFMNMHP, Action<T, U, V, W, X, Y> AMEKOPCKNIK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x163DB10", Offset = "0x163CD10", VA = "0x18163DB10")]
	public static EODAGJGPGIK<T, U, V, W, X, Y> JFKBDLPLABC(EODAGJGPGIK<T, U, V, W, X, Y> JLMLPFMNMHP, Action<T, U, V, W, X, Y> AMEKOPCKNIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct HLJPHFJFLFA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MKHOGNOEFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int GHMDMFMGLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private int DFKMICEACBN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1C43EE0", Offset = "0x1C430E0", VA = "0x181C43EE0")]
	private HLJPHFJFLFA(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BOEIHCKHMPC, int ALBCMHPOEIC, int OMNMGKOLIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x20AC5C0", Offset = "0x20AB7C0", VA = "0x1820AC5C0")]
	public static HLJPHFJFLFA<T> HBHNAKPOBBF()
	{
		return default(HLJPHFJFLFA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x20AC6B0", Offset = "0x20AB8B0", VA = "0x1820AC6B0")]
	public (int, int, Task<T>) MNPLHOGJGCJ(int OMMCHNLHKPF, [Optional] CancellationToken MELLLMEKJLC, double IDAEOLGPOPH = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x20AC400", Offset = "0x20AB600", VA = "0x1820AC400")]
	public void GPLFIONOFEC(int OMMCHNLHKPF, int OMNMGKOLIOD, in T GAMJEJDMFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class IHAILBEEHKG
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E61D80", Offset = "0x6E60F80", VA = "0x186E61D80")]
	public static HLJPHFJFLFA<CKDLGNFJNCJ> HBHNAKPOBBF()
	{
		return default(HLJPHFJFLFA<CKDLGNFJNCJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E61D00", Offset = "0x6E60F00", VA = "0x186E61D00")]
	public static void GPLFIONOFEC(this in HLJPHFJFLFA<CKDLGNFJNCJ> KPIHKJNPOFH, int OMMCHNLHKPF, int OMNMGKOLIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class EFDLCENOCIB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<TKey, TVal> ONJNBHNIFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly Dictionary<TVal, TKey> CPKNBOGBMEJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1BC1560", Offset = "0x1BC0760", VA = "0x181BC1560", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HPJMOKLCNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E30B0", Offset = "0x7E22B0", VA = "0x1807E30B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GICOMCGGNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FE30", Offset = "0x2C0F030", VA = "0x182C0FE30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> OFAPHBGLMAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2710B80", Offset = "0x270FD80", VA = "0x182710B80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x312C4C0", Offset = "0x312B6C0", VA = "0x18312C4C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x312C530", Offset = "0x312B730", VA = "0x18312C530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x312C210", Offset = "0x312B410", VA = "0x18312C210")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x312BA20", Offset = "0x312AC20", VA = "0x18312BA20", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x312C2E0", Offset = "0x312B4E0", VA = "0x18312C2E0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x312B9B0", Offset = "0x312ABB0", VA = "0x18312B9B0", Slot = "9")]
	public void Add(TKey JCEGKCPOPDM, TVal NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x312B970", Offset = "0x312AB70", VA = "0x18312B970", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JJJLNAPHHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x312BA80", Offset = "0x312AC80", VA = "0x18312BA80", Slot = "8")]
	public bool ContainsKey(TKey JCEGKCPOPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x312BAB0", Offset = "0x312ACB0", VA = "0x18312BAB0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JJJLNAPHHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x312C250", Offset = "0x312B450", VA = "0x18312C250", Slot = "10")]
	public bool Remove(TKey JCEGKCPOPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x312C2B0", Offset = "0x312B4B0", VA = "0x18312C2B0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JJJLNAPHHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C640", Offset = "0x2A1B840", VA = "0x182A1C640", Slot = "11")]
	public bool TryGetValue(TKey JCEGKCPOPDM, out TVal NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C0F920", Offset = "0x2C0EB20", VA = "0x182C0F920", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x312BB10", Offset = "0x312AD10", VA = "0x18312BB10", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LMFDNLBGHBA, int PAENDODKMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x312BBA0", Offset = "0x312ADA0", VA = "0x18312BBA0")]
	public bool DABKEEJNCNK(TVal JCEGKCPOPDM, out TKey NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x312BEB0", Offset = "0x312B0B0", VA = "0x18312BEB0")]
	private void HICKDPGOGPB(TKey JCEGKCPOPDM, TVal OGOIFONOCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x312C0E0", Offset = "0x312B2E0", VA = "0x18312C0E0")]
	private void KGMILHIHHBJ(TKey JCEGKCPOPDM, TVal OGOIFONOCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x312BD60", Offset = "0x312AF60", VA = "0x18312BD60")]
	private bool DAPJGMDKGHD(TKey JCEGKCPOPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x312C3D0", Offset = "0x312B5D0", VA = "0x18312C3D0")]
	public EFDLCENOCIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DefaultMember("Item")]
public class PBCHANMLDDA<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly Func<Internal, External> BNMBBNKGCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private IReadOnlyList<Internal> MLEOGHHEJOI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public External JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A1C850", Offset = "0x2A1BA50", VA = "0x182A1C850", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2A1C7F0", Offset = "0x2A1B9F0", VA = "0x182A1C7F0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1C453A0", Offset = "0x1C445A0", VA = "0x181C453A0")]
	public PBCHANMLDDA(Func<Internal, External> BNMBBNKGCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C7A0", Offset = "0x2A1B9A0", VA = "0x182A1C7A0")]
	public PBCHANMLDDA(IReadOnlyList<Internal> MLEOGHHEJOI, Func<Internal, External> BNMBBNKGCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C730", Offset = "0x2A1B930", VA = "0x182A1C730", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x21C81F0", Offset = "0x21C73F0", VA = "0x1821C81F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HMFFJAPKCNP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate Task<TResult> HDCENJACHMI(TRequest DMFMJBFFPPI, CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum CNJACJFOCMK
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class MHOGPEPEOLN
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const float NHKDAEOIJJJ = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TimeSpan CFDNGPADBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int ILMOBGGEHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CNJACJFOCMK DEMGLJAPINF;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly MHOGPEPEOLN NBIAOCJLGIM;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float DJGOCPFCOID
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3F80", Offset = "0x3AA3180", VA = "0x183AA3F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TimeSpan EDMJBBKALMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4140", Offset = "0x3AA3340", VA = "0x183AA4140")]
		public MHOGPEPEOLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct MEAIIMMECCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly TRequest DMFMJBFFPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly CancellationToken MELLLMEKJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly TaskCompletionSource<TResult> BHFMDEGDAIH;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D80", Offset = "0x2AF7F80", VA = "0x182AF8D80")]
		public MEAIIMMECCN(TRequest DMFMJBFFPPI, TaskCompletionSource<TResult> BHFMDEGDAIH, CancellationToken MELLLMEKJLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class EMBIDIMGDAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public HMFFJAPKCNP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public EMBIDIMGDAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1634BF0", Offset = "0x1633DF0", VA = "0x181634BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class PHAFHFBELDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public HMFFJAPKCNP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private MEAIIMMECCN <req>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public PHAFHFBELDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x36756B0", Offset = "0x36748B0", VA = "0x1836756B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly CancellationTokenSource IEPABDBOKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly List<MEAIIMMECCN> MMAHNDMKLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MHOGPEPEOLN JCMCHMNOPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly HDCENJACHMI CAIMBEFEJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private Task GMEJIKJGKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int DLPPIOECABB;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x20B24A0", Offset = "0x20B16A0", VA = "0x1820B24A0")]
	public HMFFJAPKCNP(HDCENJACHMI CAIMBEFEJOB, [Optional] MHOGPEPEOLN JCMCHMNOPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x20B1F30", Offset = "0x20B1130", VA = "0x1820B1F30")]
	public Task<TResult> GEGMMIIDHDJ(TRequest DMFMJBFFPPI, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x20B20E0", Offset = "0x20B12E0", VA = "0x1820B20E0")]
	private void MDOAHDGHAEN(MEAIIMMECCN BKMHEEFLAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x20B1DE0", Offset = "0x20B0FE0", VA = "0x1820B1DE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HMFFJAPKCNP<, >.EMBIDIMGDAD))]
	private Task FLDANKKGMLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x20B2170", Offset = "0x20B1370", VA = "0x1820B2170")]
	private MEAIIMMECCN NKIHGIDGLFG()
	{
		return default(MEAIIMMECCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x20B1C50", Offset = "0x20B0E50", VA = "0x1820B1C50")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HMFFJAPKCNP<, >.PHAFHFBELDC))]
	private Task DLBDFCCDBDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x20B23D0", Offset = "0x20B15D0", VA = "0x1820B23D0")]
	private void OLHLNGLMGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x20B1DA0", Offset = "0x20B0FA0", VA = "0x1820B1DA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1E54640", Offset = "0x1E53840", VA = "0x181E54640")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A5D0", Offset = "0x6D397D0", VA = "0x186D3A5D0")]
		public SerializedGuid(in Guid BHKAMCELBPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6E64F20", Offset = "0x6E64120", VA = "0x186E64F20")]
		public static SerializedGuid JIKNBGIPALI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6E64D00", Offset = "0x6E63F00", VA = "0x186E64D00")]
		public static SerializedGuid CKLBFIAKAMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E64C70", Offset = "0x6E63E70", VA = "0x186E64C70")]
		public bool AIIPHFCAOIP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A5A0", Offset = "0x6D397A0", VA = "0x186D3A5A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E64FB0", Offset = "0x6E641B0", VA = "0x186E64FB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E64D90", Offset = "0x6E63F90", VA = "0x186E64D90", Slot = "7")]
		public bool Equals(SerializedGuid JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E64E40", Offset = "0x6E64040", VA = "0x186E64E40", Slot = "0")]
		public override bool Equals(object PPNJOAJJOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A4F0", Offset = "0x6D396F0", VA = "0x186D3A4F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A330", Offset = "0x6D39530", VA = "0x186D3A330", Slot = "6")]
		public int CompareTo(SerializedGuid JMNBIHILIIC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class FKOLPKDHCDB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly Type FDDIMHGKACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly string CHPIPNDPNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly bool AAJPHFLFNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly bool FNGILIEHIJF;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E617F0", Offset = "0x6E609F0", VA = "0x186E617F0")]
	public FKOLPKDHCDB(Type DAMPMEJACHI, string BEMDKOJLPDC, bool MIHEPDCHBEP = false, bool BFHBKFLANCD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[DefaultMember("Item")]
public class MCHKDBBPAOC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly List<T> MLEOGHHEJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private HashSet<T> PCGDJFIABMK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1BC1560", Offset = "0x1BC0760", VA = "0x181BC1560", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HPJMOKLCNEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x929790", Offset = "0x928990", VA = "0x180929790", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xF73E80", Offset = "0xF73080", VA = "0x180F73E80", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1EE0", Offset = "0x2AF10E0", VA = "0x182AF1EE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1770", Offset = "0x2AF0970", VA = "0x182AF1770", Slot = "11")]
	public void Add(T JJJLNAPHHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2AF19F0", Offset = "0x2AF0BF0", VA = "0x182AF19F0")]
	public bool OIGPBDDOPEF(T JJJLNAPHHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1CE0", Offset = "0x2AF0EE0", VA = "0x182AF1CE0", Slot = "15")]
	public bool Remove(T JJJLNAPHHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C5C0", Offset = "0x2A1B7C0", VA = "0x182A1C5C0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1E511E0", Offset = "0x1E503E0", VA = "0x181E511E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2AF17A0", Offset = "0x2AF09A0", VA = "0x182AF17A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x229A8B0", Offset = "0x2299AB0", VA = "0x18229A8B0", Slot = "13")]
	public bool Contains(T JJJLNAPHHCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1800", Offset = "0x2AF0A00", VA = "0x182AF1800", Slot = "14")]
	public void CopyTo(T[] LMFDNLBGHBA, int PAENDODKMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1830", Offset = "0x2AF0A30", VA = "0x182AF1830", Slot = "6")]
	public int IndexOf(T JJJLNAPHHCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1860", Offset = "0x2AF0A60", VA = "0x182AF1860", Slot = "7")]
	public void Insert(int NNAODBDJDNJ, T JJJLNAPHHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1C10", Offset = "0x2AF0E10", VA = "0x182AF1C10", Slot = "8")]
	public void RemoveAt(int NNAODBDJDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1DF0", Offset = "0x2AF0FF0", VA = "0x182AF1DF0")]
	public MCHKDBBPAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class HKAMKBPFDBN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6E61C90", Offset = "0x6E60E90", VA = "0x186E61C90")]
	public HKAMKBPFDBN(string JPOEHOENKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class JGBAGAPFMHL
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6E61F40", Offset = "0x6E61140", VA = "0x186E61F40")]
	[NotNull]
	public static byte[] LMLIDCFIHNI(this PPPKCBIDPMP BBNNABFLDNO, HashAlgorithmName KNFODDPNPON, byte[] LPCPKENGBPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface PPPKCBIDPMP
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IDCDAKKLOPN);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PNDNNDBPIOF : PPPKCBIDPMP
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[CanBeNull]
	byte[] BAHPCLOCNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	[CanBeNull]
	byte[] AKABFPELHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class ECIDMJHENIH
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly ArrayPool<byte> PLPOAODCLFA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static bool DJCPIOHJIAA;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E61090", Offset = "0x6E60290", VA = "0x186E61090")]
	public static void JCMEKHDMDIC(this IncrementalHash CADMOFKIMBE, [CanBeNull] GameObject HAAGKPEGEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xF10500", Offset = "0xF0F700", VA = "0x180F10500")]
	public static void JCMEKHDMDIC<T>(this IncrementalHash CADMOFKIMBE, [CanBeNull] T HPFFEAJFMNI) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xF10470", Offset = "0xF0F670", VA = "0x180F10470")]
	public static void EHMGIAEIEPO<T>(this IncrementalHash CADMOFKIMBE, [CanBeNull] T BBNNABFLDNO) where T : PPPKCBIDPMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0xF105D0", Offset = "0xF0F7D0", VA = "0x180F105D0")]
	public static void LNHJGGNCIOI<T>(this IncrementalHash CADMOFKIMBE, [CanBeNull] IList<T> MCMEOGJHNMD) where T : PPPKCBIDPMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6E60EA0", Offset = "0x6E600A0", VA = "0x186E60EA0")]
	private static bool GIBDNPLOMOA([CanBeNull] PPPKCBIDPMP BBNNABFLDNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E60E40", Offset = "0x6E60040", VA = "0x186E60E40")]
	public static void GADOLBOLCID(this IncrementalHash IDCDAKKLOPN, [CanBeNull] string HKILNKJDJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E608C0", Offset = "0x6E5FAC0", VA = "0x186E608C0")]
	public static void AGEFMGKJBOM(this IncrementalHash IDCDAKKLOPN, long MMONBDPEFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E60C70", Offset = "0x6E5FE70", VA = "0x186E60C70")]
	public static void ECJBMOGEFNB(this IncrementalHash IDCDAKKLOPN, int FHNDOFLGIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E61480", Offset = "0x6E60680", VA = "0x186E61480")]
	public static void PPKDCAKBAPH(this IncrementalHash IDCDAKKLOPN, short FBAFCDMLGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E60A90", Offset = "0x6E5FC90", VA = "0x186E60A90")]
	public static void APGBLFKKOKF(this IncrementalHash IDCDAKKLOPN, byte JNKMLINFJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E61180", Offset = "0x6E60380", VA = "0x186E61180")]
	public static void LLHGEFNHOIH(this IncrementalHash IDCDAKKLOPN, bool LABAJMMNHML, bool BJIGDIHIKBF = false, bool FAHFMFFIENN = false, bool NPPKJFNILFG = false, bool IBINGGFPNCD = false, bool JKFFNHEFDGE = false, bool DHLHMHIDHCJ = false, bool KHNMAAKGLJP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xF10A20", Offset = "0xF0FC20", VA = "0x180F10A20")]
	public static void PGMHPLCOOAO<T>(this IncrementalHash IDCDAKKLOPN, T BLKCNPDCACN) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6E613B0", Offset = "0x6E605B0", VA = "0x186E613B0")]
	public static void MPHHACADAJN(this IncrementalHash IDCDAKKLOPN, float BHMMEGIELAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E60C00", Offset = "0x6E5FE00", VA = "0x186E60C00")]
	public static void CAICNBFLPFP(this IncrementalHash IDCDAKKLOPN, ulong ANFDPMNENKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6E61350", Offset = "0x6E60550", VA = "0x186E61350")]
	public static void MEMBOBMLFPM(this IncrementalHash IDCDAKKLOPN, uint OBEGHEPPHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6E61410", Offset = "0x6E60610", VA = "0x186E61410")]
	public static void OJFDOMHLDHG(this IncrementalHash IDCDAKKLOPN, ushort NKPMGHEBCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E60F30", Offset = "0x6E60130", VA = "0x186E60F30")]
	public static void HMHLNEKMGPG(this IncrementalHash IDCDAKKLOPN, Vector3 PFONBBKEHEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LMGKPPLPDOA
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E626C0", Offset = "0x6E618C0", VA = "0x186E626C0")]
	[NotNull]
	public static byte[] LMLIDCFIHNI(this PNDNNDBPIOF JCNICPJHPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E62730", Offset = "0x6E61930", VA = "0x186E62730")]
	[NotNull]
	public static byte[] LMLIDCFIHNI(this PNDNNDBPIOF JCNICPJHPPL, HashAlgorithmName KNFODDPNPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E62410", Offset = "0x6E61610", VA = "0x186E62410")]
	public static bool BHGJKDFBGMA([CanBeNull] this PNDNNDBPIOF JCNICPJHPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E62270", Offset = "0x6E61470", VA = "0x186E62270")]
	public static bool BHGJKDFBGMA([CanBeNull] this PNDNNDBPIOF JCNICPJHPPL, out string BMNKLBFFLLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E625A0", Offset = "0x6E617A0", VA = "0x186E625A0")]
	private static bool CAENMDHABII([NotNull] PNDNNDBPIOF JCNICPJHPPL, [CanBeNull] out byte[] FBMAPFLLAKC, [CanBeNull] out byte[] FFHKIOGNFPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class HGEKNGBCEFL<TTask, T> : ODOCIMMOCAD<T>, LAFIHHFBOFA, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HGENAJENJKA
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
			public HGENAJENJKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public <<-ctor>g__AwaitThenTransformTaskResult|0>d()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x1A4CEA0", Offset = "0x1A4C0A0", VA = "0x181A4CEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
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
		public HGEKNGBCEFL<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public HGENAJENJKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x20A4240", Offset = "0x20A3440", VA = "0x1820A4240")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HGEKNGBCEFL<, >.HGENAJENJKA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> GIDGDGIJDKC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static bool BFANFNNCMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Task<T> EEILDIKJMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	protected readonly CancellationTokenSource OEIHHLAPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool IFCDFOBKGCM;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Task<T> HPADJMKFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public OOMFLHAHLDK<T> OBNMHPONIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool IFJLJEPJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAC0", Offset = "0x7EACC0", VA = "0x1807EBAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x20A3BE0", Offset = "0x20A2DE0", VA = "0x1820A3BE0")]
	static HGEKNGBCEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x20A3D90", Offset = "0x20A2F90", VA = "0x1820A3D90")]
	protected HGEKNGBCEFL(TTask EEILDIKJMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x20A39C0", Offset = "0x20A2BC0", VA = "0x1820A39C0", Slot = "1")]
	~HGEKNGBCEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x20A3990", Offset = "0x20A2B90", VA = "0x1820A3990", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x20A35F0", Offset = "0x20A27F0", VA = "0x1820A35F0")]
	private void DFBADGMPLED(bool AEFLCJODLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HCJPAEHEGGF(TTask KAGMKEPJEOK);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void HGLIEEPFJEP();
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LCOMMKELNNB<T> : ODOCIMMOCAD<T>, LAFIHHFBOFA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Task<T> HPADJMKFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public OOMFLHAHLDK<T> OBNMHPONIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2C38010", Offset = "0x2C37210", VA = "0x182C38010")]
	public LCOMMKELNNB(Exception IPCCCBDDHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface LAFIHHFBOFA : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface ODOCIMMOCAD<T> : LAFIHHFBOFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	[NotNull]
	Task<T> HPADJMKFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	OOMFLHAHLDK<T> OBNMHPONIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class EENCCLDMICL : MBIFIDFCLGL<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E61750", Offset = "0x6E60950", VA = "0x186E61750")]
	public EENCCLDMICL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class MBIFIDFCLGL<T> : ODOCIMMOCAD<T>, LAFIHHFBOFA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Task<T> HPADJMKFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public OOMFLHAHLDK<T> OBNMHPONIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1360", Offset = "0x2AF0560", VA = "0x182AF1360")]
	public MBIFIDFCLGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public sealed class OIHENDAIDID : GAKPIOFBDII<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class LJLPPHFPHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action<OIHENDAIDID, PEKDFCFCENH> callback;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LJLPPHFPHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6E621D0", Offset = "0x6E613D0", VA = "0x186E621D0")]
		internal void KCMDFAJIKPF(GAKPIOFBDII<string> timer, PEKDFCFCENH log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6E62880", Offset = "0x6E61A80", VA = "0x186E62880")]
	public OIHENDAIDID(PEKDFCFCENH LHCMKIAHBCL, [Optional] string GGGDNPJJLME, [Optional] int? OBEDELIGIKN, [Optional] Stopwatch JOOKLBMOOAJ, [Optional] Action<string, EOFLJJKLNAB, PEKDFCFCENH> JLHMBPFEPFF, [Optional] Action<string, EOFLJJKLNAB, PEKDFCFCENH> OBAHGLKEECO, [Optional] Action<OIHENDAIDID, PEKDFCFCENH> PFGCEDBDCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6E627A0", Offset = "0x6E619A0", VA = "0x186E627A0")]
	private static Action<GAKPIOFBDII<string>, PEKDFCFCENH> KCNIKNPPOEO(Action<OIHENDAIDID, PEKDFCFCENH> JHGMNDBGFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HOLLHEEACGI<TKey> : NLOIFFLCGAP<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate string MDANFLFDILJ(TKey JCEGKCPOPDM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly string PANINEHOKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly double CLPELBOHKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly bool PNHFACLNICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int GPPAHJBNLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly ISet<string> GEFHDBNELFB;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x25A0E20", Offset = "0x25A0020", VA = "0x1825A0E20")]
	private static string DNDEOEDBDGN(TKey JCEGKCPOPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x25A0FE0", Offset = "0x25A01E0", VA = "0x1825A0FE0")]
	public HOLLHEEACGI(string PANINEHOKGI = "F2", double CLPELBOHKKP = double.MaxValue, bool PNHFACLNICB = false, int GPPAHJBNLAE = int.MaxValue, [Optional] ISet<string> GEFHDBNELFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x25A0D70", Offset = "0x259FF70", VA = "0x1825A0D70", Slot = "4")]
	public override Dictionary<string, string> DDJCOPEGIEO(GAKPIOFBDII<TKey> ENNBBCEBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x25A05A0", Offset = "0x259F7A0", VA = "0x1825A05A0")]
	private bool CGGNHOBOMAG(string MJBAGLFOMMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x25A0830", Offset = "0x259FA30", VA = "0x1825A0830")]
	public Dictionary<string, string> DDJCOPEGIEO(GAKPIOFBDII<TKey> ENNBBCEBKAC, MDANFLFDILJ AKOEFFIMPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x25A0680", Offset = "0x259F880", VA = "0x1825A0680")]
	private string CHMMECJGEHF(StringBuilder HBLHIKGONIB, List<TKey> BJOKPGJONDJ, MDANFLFDILJ AKOEFFIMPOM, bool JLGNLAABJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x25A0E60", Offset = "0x25A0060", VA = "0x1825A0E60")]
	private static void NCPCANOFDPG(StringBuilder LPFOMOGAKKB, string BBLGPKLKAKK, bool OLGCAOOKKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class NLOIFFLCGAP<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut DDJCOPEGIEO(GAKPIOFBDII<TKey> ENNBBCEBKAC);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
	protected NLOIFFLCGAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class CBIGPAGLKFF<TKey> : NLOIFFLCGAP<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public delegate string FIMPNGHGPBM(TKey JCEGKCPOPDM);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C8F0", Offset = "0x1E4BAF0", VA = "0x181E4C8F0")]
	private static string DNDEOEDBDGN(TKey JCEGKCPOPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C710", Offset = "0x1E4B910", VA = "0x181E4C710", Slot = "4")]
	public override string DDJCOPEGIEO(GAKPIOFBDII<TKey> ENNBBCEBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C7C0", Offset = "0x1E4B9C0", VA = "0x181E4C7C0")]
	public string DDJCOPEGIEO(GAKPIOFBDII<TKey> ENNBBCEBKAC, [NotNull] FIMPNGHGPBM AKOEFFIMPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EBGLLKBPLMH(GAKPIOFBDII<TKey> ENNBBCEBKAC, [NotNull] FIMPNGHGPBM AKOEFFIMPOM);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C930", Offset = "0x1E4BB30", VA = "0x181E4C930")]
	protected CBIGPAGLKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class AKCGFBCAEEG<TKey> : CBIGPAGLKFF<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct OMJHMFENKPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public FIMPNGHGPBM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static AKCGFBCAEEG<TKey> JHOAALADPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly string[] JEIAFBPBBAI;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x28FB540", Offset = "0x28FA740", VA = "0x1828FB540")]
	private AKCGFBCAEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x28FA580", Offset = "0x28F9780", VA = "0x1828FA580", Slot = "5")]
	protected override string EBGLLKBPLMH(GAKPIOFBDII<TKey> ENNBBCEBKAC, FIMPNGHGPBM AKOEFFIMPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x28FA490", Offset = "0x28F9690", VA = "0x1828FA490")]
	[CompilerGenerated]
	internal static string DPICMEJJGCI(string IFHPPIDLLFD, TKey JCEGKCPOPDM, ref OMJHMFENKPB P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GAKPIOFBDII<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct EOFLJJKLNAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly long JFPCHPNHCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly long HLKJHIOHNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly int OBEDELIGIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly int CODKNAAPHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly bool JBFFPIBHFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly string JHNMGBAMHMJ;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x163EDC0", Offset = "0x163DFC0", VA = "0x18163EDC0")]
		public EOFLJJKLNAB(long JFPCHPNHCNJ, int OBEDELIGIKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x163EE30", Offset = "0x163E030", VA = "0x18163EE30")]
		public EOFLJJKLNAB(long JFPCHPNHCNJ, long HLKJHIOHNNA, int OBEDELIGIKN, int CODKNAAPHKF, bool JBFFPIBHFEE, string JHNMGBAMHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x163EC40", Offset = "0x163DE40", VA = "0x18163EC40")]
		public int KOFDJHKPJIH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x163EC20", Offset = "0x163DE20", VA = "0x18163EC20")]
		public int JELLMEEBLEP(int MHBDPLNKGFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x163EC90", Offset = "0x163DE90", VA = "0x18163EC90")]
		public double LILPGAPHKAO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x163ED00", Offset = "0x163DF00", VA = "0x18163ED00")]
		public EOFLJJKLNAB PPOACHJEGBM(long HLKJHIOHNNA, int CODKNAAPHKF)
		{
			return default(EOFLJJKLNAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class JOKPHMHCDCF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class MJNINAIANNB<T> : IAsyncStateMachine
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
			public Func<JOKPHMHCDCF, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public JOKPHMHCDCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private JOKPHMHCDCF <internalTimer>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private T <>s__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
			public MJNINAIANNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3AAEA60", Offset = "0x3AADC60", VA = "0x183AAEA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly TKey GJDAAKMEFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly GAKPIOFBDII<TKey> ENNBBCEBKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly PEKDFCFCENH LHCMKIAHBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private List<JOKPHMHCDCF> FLDMEAPOMPD;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public string FIBPLELAOCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x2310E90", Offset = "0x2310090", VA = "0x182310E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public IEnumerable<JOKPHMHCDCF> IELDKDGLEJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x3C668F0", Offset = "0x3C65AF0", VA = "0x183C668F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public EOFLJJKLNAB OPHINHJMJIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x3C66C40", Offset = "0x3C65E40", VA = "0x183C66C40")]
			[CompilerGenerated]
			get
			{
				return default(EOFLJJKLNAB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x3C66A60", Offset = "0x3C65C60", VA = "0x183C66A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3C66C60", Offset = "0x3C65E60", VA = "0x183C66C60")]
		internal JOKPHMHCDCF(GAKPIOFBDII<TKey> ENNBBCEBKAC, TKey JCEGKCPOPDM, PEKDFCFCENH LHCMKIAHBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3C66910", Offset = "0x3C65B10", VA = "0x183C66910")]
		public JOKPHMHCDCF BGHCPKPEMKG(TKey JCEGKCPOPDM, [Optional] PEKDFCFCENH? IMNFOKAJBEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x301B0F0", Offset = "0x301A2F0", VA = "0x18301B0F0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MJNINAIANNB<>))]
		public Task<T> POAAHJKJFOG<T>(TKey JCEGKCPOPDM, Func<JOKPHMHCDCF, Task<T>> JLLIOKOLDJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3C66A90", Offset = "0x3C65C90", VA = "0x183C66A90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class BJKDNGFLJEG : IEnumerable<(TKey, List<TKey>, EOFLJJKLNAB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EOFLJJKLNAB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private (TKey key, List<TKey> path, EOFLJJKLNAB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public GAKPIOFBDII<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private List<TKey> <path>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private IEnumerator<(TKey key, List<TKey> path, EOFLJJKLNAB timerEntry)> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private (TKey key, List<TKey> path, EOFLJJKLNAB timerEntry) <rootTuple>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private (TKey, List<TKey>, EOFLJJKLNAB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x21C6750", Offset = "0x21C5950", VA = "0x1821C6750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EOFLJJKLNAB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x2E568E0", Offset = "0x2E55AE0", VA = "0x182E568E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x21C6AE0", Offset = "0x21C5CE0", VA = "0x1821C6AE0")]
		[DebuggerHidden]
		public BJKDNGFLJEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2007660", Offset = "0x2006860", VA = "0x182007660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2E564B0", Offset = "0x2E556B0", VA = "0x182E564B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2E56460", Offset = "0x2E55660", VA = "0x182E56460")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2E568A0", Offset = "0x2E55AA0", VA = "0x182E568A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2E567E0", Offset = "0x2E559E0", VA = "0x182E567E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EOFLJJKLNAB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2096BF0", Offset = "0x2095DF0", VA = "0x182096BF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EGAGCDEOEEO : IEnumerable<(TKey, List<TKey>, EOFLJJKLNAB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EOFLJJKLNAB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private (TKey key, List<TKey> path, EOFLJJKLNAB timerEntry) <>2__current;

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
		private JOKPHMHCDCF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public JOKPHMHCDCF <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public GAKPIOFBDII<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private IEnumerator<JOKPHMHCDCF> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private JOKPHMHCDCF <timerScopeChild>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IEnumerator<(TKey key, List<TKey> path, EOFLJJKLNAB timerEntry)> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private (TKey key, List<TKey> path, EOFLJJKLNAB timerEntry) <childTuple>5__4;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private (TKey, List<TKey>, EOFLJJKLNAB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x21C6750", Offset = "0x21C5950", VA = "0x1821C6750", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EOFLJJKLNAB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x312CF90", Offset = "0x312C190", VA = "0x18312CF90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x21C6AE0", Offset = "0x21C5CE0", VA = "0x1821C6AE0")]
		[DebuggerHidden]
		public EGAGCDEOEEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x312CFF0", Offset = "0x312C1F0", VA = "0x18312CFF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x312C800", Offset = "0x312BA00", VA = "0x18312C800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x312C7A0", Offset = "0x312B9A0", VA = "0x18312C7A0")]
		private void DNBEPMOBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x312CE10", Offset = "0x312C010", VA = "0x18312CE10")]
		private void OGHDDOHNOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x312CF50", Offset = "0x312C150", VA = "0x18312CF50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x312CE70", Offset = "0x312C070", VA = "0x18312CE70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EOFLJJKLNAB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x22909D0", Offset = "0x228FBD0", VA = "0x1822909D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Action<TKey, EOFLJJKLNAB, PEKDFCFCENH> JLHMBPFEPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Action<TKey, EOFLJJKLNAB, PEKDFCFCENH> OBAHGLKEECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Action<GAKPIOFBDII<TKey>, PEKDFCFCENH> PFGCEDBDCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly PEKDFCFCENH LHCMKIAHBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly JOKPHMHCDCF EODGJDLNANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool IFCDFOBKGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private int JODPAGCKGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly Stopwatch JOOKLBMOOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly int ABFHMKLGIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private string JLJJMCHOOIM;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public JOKPHMHCDCF CKIPIAKBBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	public string FIBPLELAOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x903CB0", Offset = "0x902EB0", VA = "0x180903CB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x331FBF0", Offset = "0x331EDF0", VA = "0x18331FBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x331FDB0", Offset = "0x331EFB0", VA = "0x18331FDB0")]
	public GAKPIOFBDII(TKey MPFDBECGKMK, PEKDFCFCENH LHCMKIAHBCL, [Optional] int? OBEDELIGIKN, [Optional][CanBeNull] Stopwatch JOOKLBMOOAJ, [Optional] Action<TKey, EOFLJJKLNAB, PEKDFCFCENH> JLHMBPFEPFF, [Optional] Action<TKey, EOFLJJKLNAB, PEKDFCFCENH> OBAHGLKEECO, [Optional] Action<GAKPIOFBDII<TKey>, PEKDFCFCENH> PFGCEDBDCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x331FAE0", Offset = "0x331ECE0", VA = "0x18331FAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x331FC50", Offset = "0x331EE50", VA = "0x18331FC50")]
	[IteratorStateMachine(typeof(GAKPIOFBDII<>.BJKDNGFLJEG))]
	public IEnumerable<(TKey, List<TKey>, EOFLJJKLNAB)> KEHFDINAHGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x331FCE0", Offset = "0x331EEE0", VA = "0x18331FCE0")]
	[IteratorStateMachine(typeof(GAKPIOFBDII<>.EGAGCDEOEEO))]
	private IEnumerable<(TKey, List<TKey>, EOFLJJKLNAB)> KEHFDINAHGG(List<TKey> NOFBJAIDPEL, JOKPHMHCDCF HHIHBKDPMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x331FB70", Offset = "0x331ED70", VA = "0x18331FB70")]
	private (long, int) IBFGAPNPDMO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class PIHHCHOLANL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Dictionary<byte, DDLGPJLJLAD> NDDHOMAAPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly MHNFMIKMEDO<DDLGPJLJLAD> IPNKOFIFDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly bool HLDHNHEMAEF;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DDLGPJLJLAD BGGKFBIAKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Vector2 EDCDKMDMEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1845C80", Offset = "0x1844E80", VA = "0x181845C80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xFC2AB0", Offset = "0xFC1CB0", VA = "0x180FC2AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private Vector2 DNLNOENKJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xD6B2E0", Offset = "0xD6A4E0", VA = "0x180D6B2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Vector2 GBMLPPHHECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6E63230", Offset = "0x6E62430", VA = "0x186E63230")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xD6B320", Offset = "0xD6A520", VA = "0x180D6B320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int FGPMLFMILID
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9E7BA0", Offset = "0x9E6DA0", VA = "0x1809E7BA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xBB0690", Offset = "0xBAF890", VA = "0x180BB0690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6E63440", Offset = "0x6E62640", VA = "0x186E63440")]
	public PIHHCHOLANL(Bounds ENAFFLNIBDE, Vector2[] MBKFEPANEPP, int CMBEKDPBPMP, byte ILJCPGHFJPN, float HEIIANJMMNF = 0f, [Optional] MHNFMIKMEDO<DDLGPJLJLAD> IPNKOFIFDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6E633E0", Offset = "0x6E625E0", VA = "0x186E633E0")]
	public DDLGPJLJLAD PBFMLAEMLJE(byte NNAODBDJDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6E62A00", Offset = "0x6E61C00", VA = "0x186E62A00")]
	public void BPLNPDALANE(Vector3 BOEKENJNLKP, float GHKOIICECNH, float PHPHLCKAKMK, ref List<byte> CLIKONBBCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6E62AD0", Offset = "0x6E61CD0", VA = "0x186E62AD0")]
	public void CPHLMPBIFMB(DDLGPJLJLAD.NPFHIGIODFA LKDLMPBHMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6E62BA0", Offset = "0x6E61DA0", VA = "0x186E62BA0")]
	public static int GCJLEGHHDJI(Vector2[] MBKFEPANEPP, int CMBEKDPBPMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6E63250", Offset = "0x6E62450", VA = "0x186E63250")]
	private DDLGPJLJLAD NPCJMFMDGPB(byte NNAODBDJDNJ, DDLGPJLJLAD.GCMNEFAOEKE HCGJCHKGOJL, DDLGPJLJLAD OJEMCPHOKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E62E50", Offset = "0x6E62050", VA = "0x186E62E50")]
	private void LCLLAHOOAHB(DDLGPJLJLAD OJEMCPHOKBP, Vector2[] MBKFEPANEPP, int GOPCLAMLAKB, int FMIPMOPNBNI, int HOOGEDKMKBN, int PCLBHKHEDBH, float HEIIANJMMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E62C50", Offset = "0x6E61E50", VA = "0x186E62C50")]
	private void JDEEGPLHBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E62AF0", Offset = "0x6E61CF0", VA = "0x186E62AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E62B50", Offset = "0x6E61D50", VA = "0x186E62B50", Slot = "1")]
	~PIHHCHOLANL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class DDLGPJLJLAD
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public enum GCMNEFAOEKE
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum NPFHIGIODFA
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
	public byte BGDCEHONODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Vector3 EMOFIOFINKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3 EGAKMGBHOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Vector3 BPCJFOPBEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Vector3 NKEBDLCPCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public GCMNEFAOEKE LLFFIGLECOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public DDLGPJLJLAD OBEGGMICJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public List<DDLGPJLJLAD> LINFCKLEDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool KKKONCGJGCA;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E608A0", Offset = "0x6E5FAA0", VA = "0x186E608A0")]
	public DDLGPJLJLAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6E604B0", Offset = "0x6E5F6B0", VA = "0x186E604B0")]
	public void BIBGAGBKMNG(DDLGPJLJLAD PPANDIPJOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410")]
	public void CPHLMPBIFMB(int EKGOECNKDIO, NPFHIGIODFA LKDLMPBHMLG, int FOAHHPBHMAF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E60570", Offset = "0x6E5F770", VA = "0x186E60570")]
	public void BPLNPDALANE(List<byte> CLIKONBBCAO, Vector3 BOEKENJNLKP, float GHKOIICECNH, float PHPHLCKAKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E607A0", Offset = "0x6E5F9A0", VA = "0x186E607A0")]
	public bool HDBIBFDLMLF(Vector3 GKENIDGAHNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E60870", Offset = "0x6E5FA70", VA = "0x186E60870")]
	public bool OELIBPLPBIB(Vector3 GKENIDGAHNF, float JDBNOCHLAEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E607F0", Offset = "0x6E5F9F0", VA = "0x186E607F0")]
	public void KCEHONPEIFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MHNFMIKMEDO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Stack<T> OFJOEMIJADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly List<T> FICBCNHCKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly int AGJHACAEAMJ;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3520", Offset = "0x3AA2720", VA = "0x183AA3520")]
	public static MHNFMIKMEDO<T> ALPFHMHEHJN(int HCKHKGKDPCJ = 0, int AGJHACAEAMJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3CB0", Offset = "0x3AA2EB0", VA = "0x183AA3CB0")]
	public MHNFMIKMEDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3B20", Offset = "0x3AA2D20", VA = "0x183AA3B20")]
	public MHNFMIKMEDO(int HCKHKGKDPCJ, int AGJHACAEAMJ = int.MaxValue, bool JELPKKAJOIK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA35F0", Offset = "0x3AA27F0", VA = "0x183AA35F0")]
	public T BECEPNMHICJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3AA39B0", Offset = "0x3AA2BB0", VA = "0x183AA39B0")]
	public void KOGPOOGFLGD(T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3A50", Offset = "0x3AA2C50", VA = "0x183AA3A50")]
	private void MKLIJNBNGAE(T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3700", Offset = "0x3AA2900", VA = "0x183AA3700")]
	private void DHHICGBJILE(T NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3720", Offset = "0x3AA2920", VA = "0x183AA3720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3810", Offset = "0x3AA2A10", VA = "0x183AA3810")]
	private void GPIFGLGOHBN(IEnumerable<T> DGPLNKPEMNF)
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
		[Cpp2IlInjected.Address(RVA = "0x2652B20", Offset = "0x2651D20", VA = "0x182652B20", Slot = "4")]
		public virtual T PDMFLPPANIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FGDECKOODIN<T> : IEnumerable<FGDECKOODIN<T>.ANPGJAGJMJK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct ANPGJAGJMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public T NABCGCEIEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int NNAODBDJDNJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class ONFHMFJDNIH : IEnumerator<ANPGJAGJMJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private FGDECKOODIN<T> JODMKJKDNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int NNAODBDJDNJ;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x9CDFF0", Offset = "0x9CD1F0", VA = "0x1809CDFF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public ANPGJAGJMJK JLCKGMHIDAB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x338A680", Offset = "0x3389880", VA = "0x18338A680", Slot = "4")]
			get
			{
				return default(ANPGJAGJMJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2EEBC30", Offset = "0x2EEAE30", VA = "0x182EEBC30")]
		public ONFHMFJDNIH(FGDECKOODIN<T> JODMKJKDNCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x338A600", Offset = "0x3389800", VA = "0x18338A600", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x2874D20", Offset = "0x2873F20", VA = "0x182874D20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7E9430", Offset = "0x7E8630", VA = "0x1807E9430", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	private struct HPOKIJPDNOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public bool JEFMOMLIBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public T NABCGCEIEGG;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private const int COKEEPDNECJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Dictionary<T, int> KNNMFNIAJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private HPOKIJPDNOL[] NMINCMEFEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int NPABJILKEJO;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int ACCENINFBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B1370", Offset = "0x8B0570", VA = "0x1808B1370")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9298D0", Offset = "0x928AD0", VA = "0x1809298D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1BC1560", Offset = "0x1BC0760", VA = "0x181BC1560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D3C0", Offset = "0x2C0C5C0", VA = "0x182C0D3C0")]
	public FGDECKOODIN(int HCKHKGKDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D490", Offset = "0x2C0C690", VA = "0x182C0D490")]
	public FGDECKOODIN(ANPGJAGJMJK[] ENCNJGAIEGO, bool BNINKMGNPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C0CDD0", Offset = "0x2C0BFD0", VA = "0x182C0CDD0")]
	public int IIAEDLINBNL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C810", Offset = "0x2C0BA10", VA = "0x182C0C810")]
	private int EHOPCLIKECJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C0CCC0", Offset = "0x2C0BEC0", VA = "0x182C0CCC0", Slot = "6")]
	protected virtual uint HCJANKDNEOP(uint IDCDAKKLOPN, T NABCGCEIEGG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C7D0", Offset = "0x2C0B9D0", VA = "0x182C0C7D0")]
	public bool EBPPBGDGGCF(T NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C0CBE0", Offset = "0x2C0BDE0", VA = "0x182C0CBE0")]
	public int FHMBBANJKKB(T NABCGCEIEGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C0CCE0", Offset = "0x2C0BEE0", VA = "0x182C0CCE0")]
	public T HOMBDFEEBBF(int NNAODBDJDNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D110", Offset = "0x2C0C310", VA = "0x182C0D110")]
	public bool OIGPBDDOPEF(T NABCGCEIEGG, bool DAPBFBOKPDG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D150", Offset = "0x2C0C350", VA = "0x182C0D150")]
	public bool OIGPBDDOPEF(T NABCGCEIEGG, int NNAODBDJDNJ, bool DAPBFBOKPDG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C0CE40", Offset = "0x2C0C040", VA = "0x182C0CE40")]
	private int KFNHPGODALL(int ILJCPGHFJPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D340", Offset = "0x2C0C540", VA = "0x182C0D340", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C0D340", Offset = "0x2C0C540", VA = "0x182C0D340", Slot = "4")]
	private IEnumerator<ANPGJAGJMJK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
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
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x6E63980", Offset = "0x6E62B80", VA = "0x186E63980")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x6E63C10", Offset = "0x6E62E10", VA = "0x186E63C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6E63B40", Offset = "0x6E62D40", VA = "0x186E63B40")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x6E638F0", Offset = "0x6E62AF0", VA = "0x186E638F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6E63B80", Offset = "0x6E62D80", VA = "0x186E63B80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6E63AB0", Offset = "0x6E62CB0", VA = "0x186E63AB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6E63890", Offset = "0x6E62A90", VA = "0x186E63890")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class JNOPKBHKAPG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int HCKHKGKDPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int DGBPGIEBICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private List<T> FBIMPHNMCAK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1C62880", Offset = "0x1C61A80", VA = "0x181C62880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public T BPFOLHNLIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2939E40", Offset = "0x2939040", VA = "0x182939E40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public T GFEDLMALHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2939A90", Offset = "0x2938C90", VA = "0x182939A90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T FIDICMKHAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2939CF0", Offset = "0x2938EF0", VA = "0x182939CF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2939F50", Offset = "0x2939150", VA = "0x182939F50")]
	public JNOPKBHKAPG(int HCKHKGKDPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2939BC0", Offset = "0x2938DC0", VA = "0x182939BC0")]
	public void CKPKOIJGHLD(T CPEKIFMPMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2939D50", Offset = "0x2938F50", VA = "0x182939D50")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2939DA0", Offset = "0x2938FA0", VA = "0x182939DA0")]
	public void JJEHEICHIHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2939A00", Offset = "0x2938C00", VA = "0x182939A00")]
	public void BAIBPOHMMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2939D90", Offset = "0x2938F90", VA = "0x182939D90")]
	public void HPGBHIIBGHP()
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
		public struct IODNBMMCCFG<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			private readonly List<Component> MLEOGHHEJOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private readonly bool PBLAGJFIKPG;

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x15BD010", Offset = "0x15BC210", VA = "0x1815BD010")]
			public IODNBMMCCFG(List<Component> MLEOGHHEJOI, bool PBLAGJFIKPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2548E60", Offset = "0x2548060", VA = "0x182548E60")]
			public NGMJNBDCODH<T> EEOIHAEEMHN()
			{
				return default(NGMJNBDCODH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2548ED0", Offset = "0x25480D0", VA = "0x182548ED0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2548ED0", Offset = "0x25480D0", VA = "0x182548ED0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public struct NGMJNBDCODH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private readonly List<Component> MLEOGHHEJOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private readonly bool PBLAGJFIKPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private int NNAODBDJDNJ;

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public T JLCKGMHIDAB
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x2C9B7B0", Offset = "0x2C9A9B0", VA = "0x182C9B7B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x2C9B740", Offset = "0x2C9A940", VA = "0x182C9B740", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B780", Offset = "0x2C9A980", VA = "0x182C9B780")]
			public NGMJNBDCODH(List<Component> MLEOGHHEJOI, bool PBLAGJFIKPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B670", Offset = "0x2C9A870", VA = "0x182C9B670", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x2C9B680", Offset = "0x2C9A880", VA = "0x182C9B680", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x280B100", Offset = "0x280A300", VA = "0x18280B100", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6E65150", Offset = "0x6E64350", VA = "0x186E65150")]
		private void KCEHONPEIFO(GameObject AEMIIPGDKOE, bool BEIAPGFNLDJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E652C0", Offset = "0x6E644C0", VA = "0x186E652C0")]
		public static void KCEHONPEIFO(GameObject AEMIIPGDKOE, ref ToolHierarchyCache LAJNGMGNGED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4F98AF0", Offset = "0x4F97CF0", VA = "0x184F98AF0")]
		public void BNOKHNKABDM<T>(Action<T> AMEKOPCKNIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4F98D80", Offset = "0x4F97F80", VA = "0x184F98D80")]
		public T IJEBEMBMECB<T>(bool PBLAGJFIKPG = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4F98E00", Offset = "0x4F98000", VA = "0x184F98E00")]
		public IODNBMMCCFG<T> KLGEMOKNDCH<T>(bool PBLAGJFIKPG = false) where T : class
		{
			return default(IODNBMMCCFG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6E65470", Offset = "0x6E64670", VA = "0x186E65470")]
		public List<Component> OHKOFGHCCEK(Type FBNKHAJKFLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E65050", Offset = "0x6E64250", VA = "0x186E65050", Slot = "4")]
		public bool Equals(ToolHierarchyCache JPBGAMDOIJA, ToolHierarchyCache IIJHAMIHIMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E650D0", Offset = "0x6E642D0", VA = "0x186E650D0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache PPNJOAJJOFF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GLCIOEMHNJE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Dictionary<int, T> JLHBIMEGIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private T PEHDNCGJPAH;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T KDIBFMBFFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xA3F300", Offset = "0xA3E500", VA = "0x180A3F300", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x27028D0", Offset = "0x2701AD0", VA = "0x1827028D0")]
	public bool OBBMPBHHKOO(T NABCGCEIEGG, int HCNPNMCCHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2702870", Offset = "0x2701A70", VA = "0x182702870")]
	public bool NIGILHCAMDM(int HCNPNMCCHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2702670", Offset = "0x2701870", VA = "0x182702670")]
	public T GNJBDEMFGGL(int ALLOMCLAHNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2702280", Offset = "0x2701480", VA = "0x182702280")]
	private bool BHHAMALBAPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2702420", Offset = "0x2701620", VA = "0x182702420")]
	public bool DABKEEJNCNK(int HCNPNMCCHAA, out T NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2702990", Offset = "0x2701B90", VA = "0x182702990")]
	public GLCIOEMHNJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class ODEBAPLGAOO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class FJJGBNGJMJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TNode KPIHKJNPOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public TNode OJEMCPHOKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public KOPLLAMBJKL GDGDHFAMEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<KOPLLAMBJKL> DLKJMBGHEFJ;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x9CF3C0", Offset = "0x9CE5C0", VA = "0x1809CF3C0")]
		public FJJGBNGJMJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct KOPLLAMBJKL : IComparable<KOPLLAMBJKL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int HCNPNMCCHAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public TClaimant FMBMCCDGEMP;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA98E0", Offset = "0xAA8AE0", VA = "0x180AA98E0")]
		public KOPLLAMBJKL(int HCNPNMCCHAA, TClaimant FMBMCCDGEMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x37D79C0", Offset = "0x37D6BC0", VA = "0x1837D79C0")]
		public bool IKBNOFGPICL(in KOPLLAMBJKL JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x37D79A0", Offset = "0x37D6BA0", VA = "0x1837D79A0")]
		public bool ABMEBNFLAAD(in KOPLLAMBJKL JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x37D79B0", Offset = "0x37D6BB0", VA = "0x1837D79B0", Slot = "4")]
		public int CompareTo(KOPLLAMBJKL JMNBIHILIIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x37D7A20", Offset = "0x37D6C20", VA = "0x1837D7A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum HICPMJKFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DHKDKIPFKBI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public ODEBAPLGAOO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1E512F0", Offset = "0x1E504F0", VA = "0x181E512F0")]
		[DebuggerHidden]
		public DHKDKIPFKBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x21CA260", Offset = "0x21C9460", VA = "0x1821CA260", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x21CA430", Offset = "0x21C9630", VA = "0x1821CA430", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x21CA350", Offset = "0x21C9550", VA = "0x1821CA350", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1C45880", Offset = "0x1C44A80", VA = "0x181C45880", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly MHNFMIKMEDO<FJJGBNGJMJI> HJCMDOPKLOH;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly MHNFMIKMEDO<List<KOPLLAMBJKL>> HCACJOJEIPA;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int EEDDNAGNBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	internal readonly Dictionary<TClaimant, TNode> BHCIPKOFEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal readonly Dictionary<TNode, FJJGBNGJMJI> ADFLBIILNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private HICPMJKFNHO KEDBGMBBPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool OLAIFPCFFLF;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FOMIAGBPCIG(TNode MEMCJAOBNAO);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void AMDIIBBGNPN(TNode MEMCJAOBNAO, TClaimant OLBALGIEDCG, TClaimant ANNLAENCLIM);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3380", Offset = "0x2DA2580", VA = "0x182DA3380")]
	public ODEBAPLGAOO(HICPMJKFNHO KEDBGMBBPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2640", Offset = "0x2DA1840", VA = "0x182DA2640")]
	public void FHIKCNDKFHG(TNode MEMCJAOBNAO, TNode PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2F30", Offset = "0x2DA2130", VA = "0x182DA2F30")]
	public void LAOGBIDKKKO(TClaimant FMBMCCDGEMP, TNode DCHFFAMMBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2000", Offset = "0x2DA1200", VA = "0x182DA2000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2DA26C0", Offset = "0x2DA18C0", VA = "0x182DA26C0")]
	private void FJIFKDBIPHD(TClaimant FMBMCCDGEMP, TNode OIDNHNOJMID, TNode DCHFFAMMBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2DA30F0", Offset = "0x2DA22F0", VA = "0x182DA30F0")]
	private int MENBGHNLIGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2380", Offset = "0x2DA1580", VA = "0x182DA2380")]
	private void EJDGPBHFHAE(TClaimant FMBMCCDGEMP, TNode MHDNGMAOCLM, TNode FMMAMOIMPOM, int MNJLHBPOEOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x2DA29C0", Offset = "0x2DA1BC0", VA = "0x182DA29C0")]
	private void GNJFGKFMNDE(KOPLLAMBJKL JHCLAPLHCEF, FJJGBNGJMJI CILEHNGCLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2760", Offset = "0x2DA1960", VA = "0x182DA2760")]
	private void FPBGGDMBGKJ(TClaimant FMBMCCDGEMP, TNode MHDNGMAOCLM, TNode FMMAMOIMPOM, int MNJLHBPOEOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2A50", Offset = "0x2DA1C50", VA = "0x182DA2A50")]
	private void IODOOEPOBGE(KOPLLAMBJKL JHCLAPLHCEF, TNode MEMCJAOBNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1D40", Offset = "0x2DA0F40", VA = "0x182DA1D40")]
	private void BKGOPBACHDB(KOPLLAMBJKL JHCLAPLHCEF, FJJGBNGJMJI CILEHNGCLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2260", Offset = "0x2DA1460", VA = "0x182DA2260")]
	private void EEMEDJELONL(FJJGBNGJMJI CILEHNGCLBH, bool LLBLGGOAGLI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2DA2B60", Offset = "0x2DA1D60", VA = "0x182DA2B60")]
	private void KLKNMMIMAJJ(FJJGBNGJMJI CILEHNGCLBH, TNode PCCOHMIFFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3150", Offset = "0x2DA2350", VA = "0x182DA3150")]
	[IteratorStateMachine(typeof(ODEBAPLGAOO<, >.DHKDKIPFKBI))]
	private IEnumerable<TNode> NJIFKOMIKJN(TNode MHDNGMAOCLM, TNode FMMAMOIMPOM, bool JCHCCGLACLM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2DA3030", Offset = "0x2DA2230", VA = "0x182DA3030")]
	private FJJGBNGJMJI LHMCNOGKEKI(TNode MEMCJAOBNAO, TNode OJEMCPHOKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1BB0", Offset = "0x2DA0DB0", VA = "0x182DA1BB0")]
	private FJJGBNGJMJI BFOOODFPAEM(TNode MEMCJAOBNAO, TNode OJEMCPHOKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1E40", Offset = "0x2DA1040", VA = "0x182DA1E40")]
	private void COPOHNHMPAB(FJJGBNGJMJI CILEHNGCLBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class LNDBBHOKFGP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	protected struct JGDILANLMIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public T HDFPEMDEFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int MALJGDEJNBJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	protected readonly List<JGDILANLMIK> AKCKPAIDKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private T EKOPPHENLJL;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1BC1560", Offset = "0x1BC0760", VA = "0x181BC1560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3C03A00", Offset = "0x3C02C00", VA = "0x183C03A00")]
	public bool NOBHIKHJOLD(T NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3C035C0", Offset = "0x3C027C0", VA = "0x183C035C0")]
	public void CKPKOIJGHLD(T NABCGCEIEGG, int HCNPNMCCHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3C036D0", Offset = "0x3C028D0", VA = "0x183C036D0")]
	public bool HCICIMHFKFM(T NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3C037F0", Offset = "0x3C029F0", VA = "0x183C037F0")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3C03660", Offset = "0x3C02860", VA = "0x183C03660")]
	public T FCEFFECCMJB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3C03850", Offset = "0x3C02A50", VA = "0x183C03850")]
	private void IPDODLMOKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3C03C00", Offset = "0x3C02E00", VA = "0x183C03C00")]
	public LNDBBHOKFGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class DBPCHAHAHIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct IHEMLNEJDON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int MALJGDEJNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public T HDFPEMDEFEE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly Dictionary<object, IHEMLNEJDON> JLHBIMEGIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly EqualityComparer<T> OAJEDMEFGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private T PEHDNCGJPAH;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public virtual T KDIBFMBFFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x29969C0", Offset = "0x2995BC0", VA = "0x1829969C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x20B9C10", Offset = "0x20B8E10", VA = "0x1820B9C10", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool PIIENPCLEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x2996A20", Offset = "0x2995C20", VA = "0x182996A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public object INJMCGLOHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DD0", Offset = "0x8D2FD0", VA = "0x1808D3DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x29972B0", Offset = "0x29964B0", VA = "0x1829972B0")]
	public bool OBBMPBHHKOO(T NABCGCEIEGG, object FDCOCHLAHJD, int HCNPNMCCHAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x2996AD0", Offset = "0x2995CD0", VA = "0x182996AD0")]
	public bool NIGILHCAMDM(object FDCOCHLAHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x2996660", Offset = "0x2995860", VA = "0x182996660")]
	public bool DABKEEJNCNK(object FDCOCHLAHJD, out T NABCGCEIEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2996930", Offset = "0x2995B30", VA = "0x182996930")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x29929D0", Offset = "0x2991BD0", VA = "0x1829929D0")]
	private bool BHHAMALBAPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x29973C0", Offset = "0x29965C0", VA = "0x1829973C0")]
	public DBPCHAHAHIO()
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
