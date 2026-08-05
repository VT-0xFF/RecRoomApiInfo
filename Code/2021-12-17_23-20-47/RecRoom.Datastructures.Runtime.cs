using System;
using System.Collections;
using System.Collections.Generic;
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
public class CHCJPFEJJDB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0F0", Offset = "0x5C8CF0", VA = "0x1805CA0F0")]
	public CHCJPFEJJDB()
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
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E60", Offset = "0x4BFA60", VA = "0x1804C0E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4C0450", Offset = "0x4BF050", VA = "0x1804C0450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "4")]
	public virtual void MHJHKLCGEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
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
	[CHCJPFEJJDB]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x374C370", Offset = "0x374AF70", VA = "0x18374C370", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x374BEB0", Offset = "0x374AAB0", VA = "0x18374BEB0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x374C970", Offset = "0x374B570", VA = "0x18374C970")]
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
	private sealed class HAPBJCNDCKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public HAPBJCNDCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3017540", Offset = "0x3016140", VA = "0x183017540")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[CHCJPFEJJDB]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3016A80", Offset = "0x3015680", VA = "0x183016A80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3016AB0", Offset = "0x30156B0", VA = "0x183016AB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x30169D0", Offset = "0x30155D0", VA = "0x1830169D0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey FHJAGMPOINB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3016A00", Offset = "0x3015600", VA = "0x183016A00", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x30168E0", Offset = "0x30154E0", VA = "0x1830168E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3016150", Offset = "0x3014D50", VA = "0x183016150", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3015AC0", Offset = "0x30146C0", VA = "0x183015AC0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x30156C0", Offset = "0x30142C0", VA = "0x1830156C0", Slot = "14")]
	protected virtual string MBCDPOEONLI(TKeyVal NCMHNEFDDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D75570", Offset = "0x1D74170", VA = "0x181D75570", Slot = "4")]
	public bool ContainsKey(TKey FHJAGMPOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x30167E0", Offset = "0x30153E0", VA = "0x1830167E0", Slot = "5")]
	public bool TryGetValue(TKey FHJAGMPOINB, out TVal CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3015630", Offset = "0x3014230", VA = "0x183015630", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3015630", Offset = "0x3014230", VA = "0x183015630", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3016810", Offset = "0x3015410", VA = "0x183016810")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NFLCKDALBEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CMONCBFAMAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public CMONCBFAMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEE00", Offset = "0x2AEDA00", VA = "0x182AEEE00")]
		internal bool <GetSamples>b__0(global::KPEBOKMCEKJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float ABLGNODJNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float GCGHDAOBFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::KPEBOKMCEKJ<float, T>> NMECNAMKLOL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LAGGAKLHFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFB760", Offset = "0x2AFA360", VA = "0x182AFB760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB7E0", Offset = "0x2AFA3E0", VA = "0x182AFB7E0")]
	public NFLCKDALBEE(float BBLDMPHCNMB, float MENACMEMLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAF20", Offset = "0x2AF9B20", VA = "0x182AFAF20")]
	public bool FEHMMODIIPP(float IGNACMIFJAF, T CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB3B0", Offset = "0x2AF9FB0", VA = "0x182AFB3B0")]
	public IEnumerable<T> LEKGFLKDGEB(float IGNACMIFJAF, [Optional] float? JINJECIAOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAD90", Offset = "0x2AF9990", VA = "0x182AFAD90")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2AFACD0", Offset = "0x2AF98D0", VA = "0x182AFACD0")]
	private void BALIDBJDCIA(float IGNACMIFJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class GBCNFFKFFGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BKFKCBEAEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T PDHGPELKFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float OLIGOKBLILC;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float NDCLMLDLKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> NBEOFCNECAF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int DNBLIADEAIL = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private BKFKCBEAEIE[] KFPJHHDGLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int JGMEKCJGBBK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float BBBDDHBKEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD4B6E0", Offset = "0xD4A2E0", VA = "0x180D4B6E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xF184A0", Offset = "0xF170A0", VA = "0x180F184A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B32DC0", Offset = "0x1B319C0", VA = "0x181B32DC0")]
	public GBCNFFKFFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B32CF0", Offset = "0x1B318F0", VA = "0x181B32CF0")]
	public GBCNFFKFFGF(int JAOGIBPIKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B32AF0", Offset = "0x1B316F0", VA = "0x181B32AF0")]
	public void ONPEBFNMAMA(float IGNACMIFJAF, T CKGFDBLPDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1B32450", Offset = "0x1B31050", VA = "0x181B32450")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1B32940", Offset = "0x1B31540", VA = "0x181B32940")]
	public bool NONIBHPJFGO(float KFBFODOADNH, float AKNCFFINPHE, out T CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1B31E50", Offset = "0x1B30A50", VA = "0x181B31E50")]
	public bool AADLENDKIDP(float KFBFODOADNH, float AKNCFFINPHE, out T CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1B322C0", Offset = "0x1B30EC0", VA = "0x181B322C0")]
	public void AJKDMJCDMJC(float KFBFODOADNH, float AKNCFFINPHE, List<T> MEAJMDEDFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1B326F0", Offset = "0x1B312F0", VA = "0x181B326F0")]
	private int HBILKCEHGAI(int FFDMCPKLLNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B32410", Offset = "0x1B31010", VA = "0x181B32410")]
	private void BDAIONMPKDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BCAKANFHJLH();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T CFNNJJKJCCC(T CKGFDBLPDNJ, float EDCJELBDLFP);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T KOCNNPCOHFJ(T HICEAFHEOML, T AMNCIONNMLF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T KEAOAGAPHGL(T HICEAFHEOML, T AMNCIONNMLF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CDENGBDAILH : global::GBCNFFKFFGF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x43B3A50", Offset = "0x43B2650", VA = "0x1843B3A50", Slot = "4")]
	protected override Vector3 BCAKANFHJLH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x43B3AC0", Offset = "0x43B26C0", VA = "0x1843B3AC0", Slot = "5")]
	protected override Vector3 CFNNJJKJCCC(Vector3 CKGFDBLPDNJ, float EDCJELBDLFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x43B3BD0", Offset = "0x43B27D0", VA = "0x1843B3BD0", Slot = "6")]
	protected override Vector3 KOCNNPCOHFJ(Vector3 HICEAFHEOML, Vector3 AMNCIONNMLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x43B3B60", Offset = "0x43B2760", VA = "0x1843B3B60", Slot = "7")]
	protected override Vector3 KEAOAGAPHGL(Vector3 HICEAFHEOML, Vector3 AMNCIONNMLF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43B3C80", Offset = "0x43B2880", VA = "0x1843B3C80")]
	public CDENGBDAILH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IDJOJKNIOMD
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1B89EE0", Offset = "0x1B88AE0", VA = "0x181B89EE0")]
	public static global::KPEBOKMCEKJ<T1, T2> EOHCEIKEHFP<T1, T2>(T1 EAIMCNIDPFF, T2 JCPLACKAFMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x243AE60", Offset = "0x2439A60", VA = "0x18243AE60")]
	public static global::GLJGLOFKPBG<T1, T2, T3> EOHCEIKEHFP<T1, T2, T3>(T1 EAIMCNIDPFF, T2 JCPLACKAFMM, T3 HEJGOEGKEHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEBC70", Offset = "0x1FEA870", VA = "0x181FEBC70")]
	internal static int OMLEDACDLJD(int NDAKLMJMPDH, int EDJOIGENPNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3EA6AB0", Offset = "0x3EA56B0", VA = "0x183EA6AB0")]
	internal static int OMLEDACDLJD(int NDAKLMJMPDH, int EDJOIGENPNN, int AKIIOIIJNJA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KPEBOKMCEKJ<T1, T2> : IComparable<global::KPEBOKMCEKJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 LGCEPDCBEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 HLGIEPBKDKP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23C0B70", Offset = "0x23BF770", VA = "0x1823C0B70")]
	public KPEBOKMCEKJ(T1 EAIMCNIDPFF, T2 JCPLACKAFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x23BF190", Offset = "0x23BDD90", VA = "0x1823BF190", Slot = "4")]
	public int CompareTo(global::KPEBOKMCEKJ<T1, T2> AIGGKBBOAOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x23BF400", Offset = "0x23BE000", VA = "0x1823BF400", Slot = "0")]
	public override bool Equals(object AIGGKBBOAOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x23BFF30", Offset = "0x23BEB30", VA = "0x1823BFF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23C01C0", Offset = "0x23BEDC0", VA = "0x1823C01C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GLJGLOFKPBG<T1, T2, T3> : IComparable<global::GLJGLOFKPBG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 LGCEPDCBEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 HLGIEPBKDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 BKMPANLKHGG;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2159F00", Offset = "0x2158B00", VA = "0x182159F00")]
	public GLJGLOFKPBG(T1 EAIMCNIDPFF, T2 JCPLACKAFMM, T3 HEJGOEGKEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2159820", Offset = "0x2158420", VA = "0x182159820", Slot = "4")]
	public int CompareTo(global::GLJGLOFKPBG<T1, T2, T3> AIGGKBBOAOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2159A10", Offset = "0x2158610", VA = "0x182159A10", Slot = "0")]
	public override bool Equals(object AIGGKBBOAOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2159B80", Offset = "0x2158780", VA = "0x182159B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2159D70", Offset = "0x2158970", VA = "0x182159D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T PDHGPELKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4E7670", Offset = "0x4E6270", VA = "0x1804E7670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x59F9E0", Offset = "0x59E5E0", VA = "0x18059F9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float LMIILHGPCGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xC96860", Offset = "0xC95460", VA = "0x180C96860")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D50D50", Offset = "0x3D4F950", VA = "0x183D50D50")]
	public T HPLOFEEJIDJ(float EDCJELBDLFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3D50B20", Offset = "0x3D4F720", VA = "0x183D50B20")]
	public T FHBNKJJCABO(float EDCJELBDLFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CNMMIJOOOAD(T HICEAFHEOML, T AMNCIONNMLF, float EDCJELBDLFP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x43B4690", Offset = "0x43B3290", VA = "0x1843B4690", Slot = "4")]
	protected override float CNMMIJOOOAD(float HICEAFHEOML, float AMNCIONNMLF, float EDCJELBDLFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x43B4710", Offset = "0x43B3310", VA = "0x1843B4710")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x43B5E30", Offset = "0x43B4A30", VA = "0x1843B5E30", Slot = "4")]
	protected override Vector3 CNMMIJOOOAD(Vector3 HICEAFHEOML, Vector3 AMNCIONNMLF, float EDCJELBDLFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x43B5EF0", Offset = "0x43B4AF0", VA = "0x1843B5EF0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4396300", Offset = "0x4394F00", VA = "0x184396300", Slot = "4")]
	protected override Color CNMMIJOOOAD(Color HICEAFHEOML, Color AMNCIONNMLF, float EDCJELBDLFP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x43B4200", Offset = "0x43B2E00", VA = "0x1843B4200")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class HFOPBBLCGEM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> MLHEBDMACKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> GBNEAEEGNIB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EIKCLJIDIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA2D0", Offset = "0x1AA8ED0", VA = "0x181AAA2D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IHCLLDNIEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4BFA40", VA = "0x1804C0E40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> LALPKOOBGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E00", Offset = "0x2AF1A00", VA = "0x182AF2E00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> BLIPOPBOKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2DBA1E0", Offset = "0x2DB8DE0", VA = "0x182DBA1E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal NGKNGLDJJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2FB3180", Offset = "0x2FB1D80", VA = "0x182FB3180", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x38A93C0", Offset = "0x38A7FC0", VA = "0x1838A93C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x38A8C00", Offset = "0x38A7800", VA = "0x1838A8C00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38A9250", Offset = "0x38A7E50", VA = "0x1838A9250", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x38A8B70", Offset = "0x38A7770", VA = "0x1838A8B70", Slot = "9")]
	public void Add(TKey FHJAGMPOINB, TVal CKGFDBLPDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x38A8BD0", Offset = "0x38A77D0", VA = "0x1838A8BD0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DGBNADBMPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x38A8C60", Offset = "0x38A7860", VA = "0x1838A8C60", Slot = "8")]
	public bool ContainsKey(TKey FHJAGMPOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x21380C0", Offset = "0x2136CC0", VA = "0x1821380C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DGBNADBMPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x38A91F0", Offset = "0x38A7DF0", VA = "0x1838A91F0", Slot = "10")]
	public bool Remove(TKey FHJAGMPOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x38A91F0", Offset = "0x38A7DF0", VA = "0x1838A91F0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DGBNADBMPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6FE0", Offset = "0x2BA5BE0", VA = "0x182BA6FE0", Slot = "11")]
	public bool TryGetValue(TKey FHJAGMPOINB, out TVal CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x38A8EE0", Offset = "0x38A7AE0", VA = "0x1838A8EE0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x38A8CC0", Offset = "0x38A78C0", VA = "0x1838A8CC0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KFPJHHDGLAI, int PPKBGADLMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x38A8D20", Offset = "0x38A7920", VA = "0x1838A8D20")]
	public bool DEELIMOLEHE(TVal FHJAGMPOINB, out TKey CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x38A8DE0", Offset = "0x38A79E0", VA = "0x1838A8DE0")]
	private void FOHHNDOMHGE(TKey FHJAGMPOINB, TVal JBIHNBPKHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x38A8FF0", Offset = "0x38A7BF0", VA = "0x1838A8FF0")]
	private void JEBFDLELAJP(TKey FHJAGMPOINB, TVal JBIHNBPKHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x38A9070", Offset = "0x38A7C70", VA = "0x1838A9070")]
	private bool LJOOAOPBLNJ(TKey FHJAGMPOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x38A92F0", Offset = "0x38A7EF0", VA = "0x1838A92F0")]
	public HFOPBBLCGEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class KNBKBMFBDCD<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::KNBKBMFBDCD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD4B6E0", Offset = "0xD4A2E0", VA = "0x180D4B6E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x344B830", Offset = "0x344A430", VA = "0x18344B830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x344BDA0", Offset = "0x344A9A0", VA = "0x18344BDA0")]
		public Enumerator(global::KNBKBMFBDCD<T> MEAJMDEDFEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x344B350", Offset = "0x3449F50", VA = "0x18344B350", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x344B6F0", Offset = "0x344A2F0", VA = "0x18344B6F0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x344B010", Offset = "0x3449C10", VA = "0x18344B010")]
		private void MGKGJLCKLFP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] NOCOIGLAGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int MIJFAJPIKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int IKMHPFFLFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int CHIJKFCCJLI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EIKCLJIDIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x344DE90", Offset = "0x344CA90", VA = "0x18344DE90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T NGKNGLDJJGL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x344DED0", Offset = "0x344CAD0", VA = "0x18344DED0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x344E750", Offset = "0x344D350", VA = "0x18344E750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x344EC30", Offset = "0x344D830", VA = "0x18344EC30")]
	public KNBKBMFBDCD(int FNDGLMJFLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x344E870", Offset = "0x344D470", VA = "0x18344E870")]
	public void ONPEBFNMAMA(T EDCJELBDLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x344E050", Offset = "0x344CC50", VA = "0x18344E050")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x344E160", Offset = "0x344CD60", VA = "0x18344E160")]
	public void KLFAHALLIHI(int JKLNJDDKIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x344DAA0", Offset = "0x344C6A0", VA = "0x18344DAA0")]
	public void BKJBLMOMGFC(T[] KFPJHHDGLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x344E110", Offset = "0x344CD10", VA = "0x18344E110")]
	public Enumerator FPCCHKLLBEA()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x344EAA0", Offset = "0x344D6A0", VA = "0x18344EAA0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x344EAA0", Offset = "0x344D6A0", VA = "0x18344EAA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x344E2E0", Offset = "0x344CEE0", VA = "0x18344E2E0")]
	private int LGLHNNEEINM(int AOPIKBGIANA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x344E5B0", Offset = "0x344D1B0", VA = "0x18344E5B0")]
	private int MHKMFGHPGNK(int AOPIKBGIANA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class HCIHLGNENHI
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
	protected HCIHLGNENHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class PDNEIINKKPN<T> : HCIHLGNENHI
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct OPJELDJOGIL
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum HEMBFAMHLIF
		{
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public HEMBFAMHLIF KJIFPOAFBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T EPGIBOENJMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int PKDDNGABDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool LIGBKFBDOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool OGJAHOPPGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> GDNMOGEEEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<OPJELDJOGIL> KFDLHLJCJCH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HLJCAMKMJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2E586C0", Offset = "0x2E572C0", VA = "0x182E586C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2E58CC0", Offset = "0x2E578C0", VA = "0x182E58CC0")]
	protected PDNEIINKKPN(bool OGJAHOPPGKI, bool LIGBKFBDOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2E58C20", Offset = "0x2E57820", VA = "0x182E58C20")]
	protected bool PLFABBKMLFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2E58700", Offset = "0x2E57300", VA = "0x182E58700")]
	protected void MCLNGPIKDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2E58920", Offset = "0x2E57520", VA = "0x182E58920")]
	protected void ODKEBNBBGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2B646D0", Offset = "0x2B632D0", VA = "0x182B646D0")]
	private static void MLAMGGBEGJF<U>(ref List<U> LECLKFBNECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2E58AD0", Offset = "0x2E576D0", VA = "0x182E58AD0", Slot = "4")]
	public void ONPEBFNMAMA(T EPGIBOENJMJ, bool JJHOOEOJGLJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2E587E0", Offset = "0x2E573E0", VA = "0x182E587E0", Slot = "5")]
	public void NGAMBELFHAP(T EPGIBOENJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2E58590", Offset = "0x2E57190", VA = "0x182E58590")]
	public void DJMOCJEOBAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class CMKPDMCLCCC : global::PDNEIINKKPN<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x43B41A0", Offset = "0x43B2DA0", VA = "0x1843B41A0")]
	public CMKPDMCLCCC(bool OGJAHOPPGKI = false, bool LIGBKFBDOBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x43B3F30", Offset = "0x43B2B30", VA = "0x1843B3F30")]
	public void BINFEFCKBOC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x43B4140", Offset = "0x43B2D40", VA = "0x1843B4140")]
	public static CMKPDMCLCCC NMJJKGAGBCO(CMKPDMCLCCC IILNNHLPCLL, Action EPGIBOENJMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x43B40E0", Offset = "0x43B2CE0", VA = "0x1843B40E0")]
	public static CMKPDMCLCCC KDFDAJJNAHN(CMKPDMCLCCC IILNNHLPCLL, Action EPGIBOENJMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DDBEACGLLDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONPEBFNMAMA(Action<T> EPGIBOENJMJ, bool JJHOOEOJGLJ = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NGAMBELFHAP(Action<T> EPGIBOENJMJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class BFLOCGMDDIM<T> : global::PDNEIINKKPN<Action<T>>, global::DDBEACGLLDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1D73050", Offset = "0x1D71C50", VA = "0x181D73050")]
	public BFLOCGMDDIM(bool OGJAHOPPGKI = false, bool LIGBKFBDOBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA670", Offset = "0x1DC9270", VA = "0x181DCA670")]
	public void BINFEFCKBOC(T EDCJELBDLFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1D72FB0", Offset = "0x1D71BB0", VA = "0x181D72FB0")]
	public static global::BFLOCGMDDIM<T> NMJJKGAGBCO(global::BFLOCGMDDIM<T> IILNNHLPCLL, Action<T> EPGIBOENJMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1D72F10", Offset = "0x1D71B10", VA = "0x181D72F10")]
	public static global::BFLOCGMDDIM<T> KDFDAJJNAHN(global::BFLOCGMDDIM<T> IILNNHLPCLL, Action<T> EPGIBOENJMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MGBHODOBJKM<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class LLPJDBNPJMC<T, U> : global::PDNEIINKKPN<Action<T, U>>, global::MGBHODOBJKM<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1D73050", Offset = "0x1D71C50", VA = "0x181D73050")]
	public LLPJDBNPJMC(bool OGJAHOPPGKI = false, bool LIGBKFBDOBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x235C920", Offset = "0x235B520", VA = "0x18235C920")]
	public void BINFEFCKBOC(T EDCJELBDLFP, U CBAOLPBIOOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1D72FB0", Offset = "0x1D71BB0", VA = "0x181D72FB0")]
	public static global::LLPJDBNPJMC<T, U> NMJJKGAGBCO(global::LLPJDBNPJMC<T, U> IILNNHLPCLL, Action<T, U> EPGIBOENJMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1D72F10", Offset = "0x1D71B10", VA = "0x181D72F10")]
	public static global::LLPJDBNPJMC<T, U> KDFDAJJNAHN(global::LLPJDBNPJMC<T, U> IILNNHLPCLL, Action<T, U> EPGIBOENJMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class ODFLKBHICBA<T, U, V> : global::PDNEIINKKPN<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1D73050", Offset = "0x1D71C50", VA = "0x181D73050")]
	public ODFLKBHICBA(bool OGJAHOPPGKI = false, bool LIGBKFBDOBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31E4570", Offset = "0x31E3170", VA = "0x1831E4570")]
	public void BINFEFCKBOC(T EDCJELBDLFP, U CBAOLPBIOOO, V HGEDMDFIJMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1D72FB0", Offset = "0x1D71BB0", VA = "0x181D72FB0")]
	public static global::ODFLKBHICBA<T, U, V> NMJJKGAGBCO(global::ODFLKBHICBA<T, U, V> IILNNHLPCLL, Action<T, U, V> EPGIBOENJMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1D72F10", Offset = "0x1D71B10", VA = "0x181D72F10")]
	public static global::ODFLKBHICBA<T, U, V> KDFDAJJNAHN(global::ODFLKBHICBA<T, U, V> IILNNHLPCLL, Action<T, U, V> EPGIBOENJMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MKNEFJNEHEF<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class AEFNLAJMNHC<T, U, V, W> : global::PDNEIINKKPN<Action<T, U, V, W>>, global::MKNEFJNEHEF<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1D73050", Offset = "0x1D71C50", VA = "0x181D73050")]
	public AEFNLAJMNHC(bool OGJAHOPPGKI = false, bool LIGBKFBDOBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x27638F0", Offset = "0x27624F0", VA = "0x1827638F0")]
	public void BINFEFCKBOC(T EDCJELBDLFP, U CBAOLPBIOOO, V HGEDMDFIJMF, W JFFLPOHOIKM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D72FB0", Offset = "0x1D71BB0", VA = "0x181D72FB0")]
	public static global::AEFNLAJMNHC<T, U, V, W> NMJJKGAGBCO(global::AEFNLAJMNHC<T, U, V, W> IILNNHLPCLL, Action<T, U, V, W> EPGIBOENJMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1D72F10", Offset = "0x1D71B10", VA = "0x181D72F10")]
	public static global::AEFNLAJMNHC<T, U, V, W> KDFDAJJNAHN(global::AEFNLAJMNHC<T, U, V, W> IILNNHLPCLL, Action<T, U, V, W> EPGIBOENJMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MHAEGDINCJH<T, U, V, W, X> : global::PDNEIINKKPN<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1D73050", Offset = "0x1D71C50", VA = "0x181D73050")]
	public MHAEGDINCJH(bool OGJAHOPPGKI = false, bool LIGBKFBDOBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2139420", Offset = "0x2138020", VA = "0x182139420")]
	public void BINFEFCKBOC(T EDCJELBDLFP, U CBAOLPBIOOO, V HGEDMDFIJMF, W JFFLPOHOIKM, X OPBDHHKCDJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1D72FB0", Offset = "0x1D71BB0", VA = "0x181D72FB0")]
	public static global::MHAEGDINCJH<T, U, V, W, X> NMJJKGAGBCO(global::MHAEGDINCJH<T, U, V, W, X> IILNNHLPCLL, Action<T, U, V, W, X> EPGIBOENJMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1D72F10", Offset = "0x1D71B10", VA = "0x181D72F10")]
	public static global::MHAEGDINCJH<T, U, V, W, X> KDFDAJJNAHN(global::MHAEGDINCJH<T, U, V, W, X> IILNNHLPCLL, Action<T, U, V, W, X> EPGIBOENJMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class EIHIMKDHFOM<T, U, V, W, X, Y> : global::PDNEIINKKPN<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1D73050", Offset = "0x1D71C50", VA = "0x181D73050")]
	public EIHIMKDHFOM(bool OGJAHOPPGKI = false, bool LIGBKFBDOBP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BAE4B0", Offset = "0x2BAD0B0", VA = "0x182BAE4B0")]
	public void BINFEFCKBOC(T EDCJELBDLFP, U CBAOLPBIOOO, V HGEDMDFIJMF, W JFFLPOHOIKM, X OPBDHHKCDJG, Y LJNMNIILEKH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1D72FB0", Offset = "0x1D71BB0", VA = "0x181D72FB0")]
	public static global::EIHIMKDHFOM<T, U, V, W, X, Y> NMJJKGAGBCO(global::EIHIMKDHFOM<T, U, V, W, X, Y> IILNNHLPCLL, Action<T, U, V, W, X, Y> EPGIBOENJMJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1D72F10", Offset = "0x1D71B10", VA = "0x181D72F10")]
	public static global::EIHIMKDHFOM<T, U, V, W, X, Y> KDFDAJJNAHN(global::EIHIMKDHFOM<T, U, V, W, X, Y> IILNNHLPCLL, Action<T, U, V, W, X, Y> EPGIBOENJMJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct GLPFNPIOEFF
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class OHBNJNCMOEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct PMLJBEHFAOP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly global::OHBNJNCMOEO<T> LDOPKKBPBOI;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public T PDHGPELKFGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x31F3220", Offset = "0x31F1E20", VA = "0x1831F3220")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x31F31F0", Offset = "0x31F1DF0", VA = "0x1831F31F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A83E0", Offset = "0x5A6FE0", VA = "0x1805A83E0")]
		public PMLJBEHFAOP(global::OHBNJNCMOEO<T> LDOPKKBPBOI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim ENHLGJOJGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T IHKOBMLDMEP;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x31F23D0", Offset = "0x31F0FD0", VA = "0x1831F23D0")]
	public OHBNJNCMOEO(in T IHKOBMLDMEP, int IDLDEDLKAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x31B1340", Offset = "0x31AFF40", VA = "0x1831B1340")]
	public OHBNJNCMOEO(in T IHKOBMLDMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x31F2310", Offset = "0x31F0F10", VA = "0x1831F2310")]
	public PMLJBEHFAOP POMFJIBNAME()
	{
		return default(PMLJBEHFAOP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CAGKEMEBMKF
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x43B3990", Offset = "0x43B2590", VA = "0x1843B3990")]
	public static global::OHBNJNCMOEO<GLPFNPIOEFF> PGCDENNLPAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1C5A5D0", Offset = "0x1C591D0", VA = "0x181C5A5D0")]
	public static global::OHBNJNCMOEO<T> PGCDENNLPAA<T>(in T IHKOBMLDMEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GFHHNOLHLJL<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate bool CALACIFOAGH(global::GFHHNOLHLJL<T> OMDNMBDEGFB);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EBLPKCPBIHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public global::GFHHNOLHLJL<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public EBLPKCPBIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1B2C560", Offset = "0x1B2B160", VA = "0x181B2C560")]
		internal bool <FindNode>b__0(global::GFHHNOLHLJL<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public T NCJFFJCELFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LinkedList<global::GFHHNOLHLJL<T>> CEDPFMGNKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public global::GFHHNOLHLJL<T> IEPJHNGPLEO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::GFHHNOLHLJL<T> IHAFALAAILA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x510A20", Offset = "0x50F620", VA = "0x180510A20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1B38BE0", Offset = "0x1B377E0", VA = "0x181B38BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DCBNGHNIMDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1B38D60", Offset = "0x1B37960", VA = "0x181B38D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JAIHCLHHFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1B38A20", Offset = "0x1B37620", VA = "0x181B38A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::GFHHNOLHLJL<T> JIDEDOCPKOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1B37C70", Offset = "0x1B36870", VA = "0x181B37C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1B39C70", Offset = "0x1B38870", VA = "0x181B39C70")]
	public GFHHNOLHLJL(T GIIBAJBOAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1B38280", Offset = "0x1B36E80", VA = "0x181B38280")]
	public global::GFHHNOLHLJL<T> EDOKFJCIGIP(T HGIDKDMKAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1B378C0", Offset = "0x1B364C0", VA = "0x181B378C0")]
	public global::GFHHNOLHLJL<T> BIBAAJFDAFN(T DMJKFBGGILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1B38AA0", Offset = "0x1B376A0", VA = "0x181B38AA0")]
	public global::GFHHNOLHLJL<T> NGAMBELFHAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1B37CF0", Offset = "0x1B368F0", VA = "0x181B37CF0")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1B37A90", Offset = "0x1B36690", VA = "0x181B37A90")]
	public global::GFHHNOLHLJL<T> CJLNFGPBGJI(T DDAMJLOEEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1B383A0", Offset = "0x1B36FA0", VA = "0x181B383A0")]
	public static void LGDKOEABLKE(global::GFHHNOLHLJL<T> HBHAAMACDCG, CALACIFOAGH IEFECEDNPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2143E30", Offset = "0x2142A30", VA = "0x182143E30")]
	public static void LGDKOEABLKE<A>(global::GFHHNOLHLJL<T> HBHAAMACDCG, Func<global::GFHHNOLHLJL<T>, A, bool> IEFECEDNPNL, A KOBLAAOGJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1B38D90", Offset = "0x1B37990", VA = "0x181B38D90")]
	public static string PMNEEMNIIPI(global::GFHHNOLHLJL<T> HBHAAMACDCG, int LFNDGJEOOEH = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1B397C0", Offset = "0x1B383C0", VA = "0x181B397C0")]
	public static global::GFHHNOLHLJL<T> PNIHFEHCFJE(global::GFHHNOLHLJL<T> HBHAAMACDCG, T BCPBMAGGPMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class AKJAPGOBFGA<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate int PMAKOCKKAOC(TKey FHJAGMPOINB, TVal CKGFDBLPDNJ);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class LKKLCFHHPJC
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey NOPHMIOAHBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal PDHGPELKFGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x63CB90", Offset = "0x63B790", VA = "0x18063CB90")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x679770", Offset = "0x678370", VA = "0x180679770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int HCFGEGPKPCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5B9380", Offset = "0x5B7F80", VA = "0x1805B9380")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5B93B0", Offset = "0x5B7FB0", VA = "0x1805B93B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime NOBBCOBPGOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4C2CF0", Offset = "0x4C18F0", VA = "0x1804C2CF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4E97D0", Offset = "0x4E83D0", VA = "0x1804E97D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x31DB230", Offset = "0x31D9E30", VA = "0x1831DB230")]
		public LKKLCFHHPJC(TKey FHJAGMPOINB, TVal JBIHNBPKHCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const int LGHLBJODOJM = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Dictionary<TKey, LinkedListNode<LKKLCFHHPJC>> PDEJIAMBBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LinkedList<LKKLCFHHPJC> DBBIPPNDMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PMAKOCKKAOC DIPDPNCNEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly TimeSpan LFBOPOGPNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JPJLICNAGNL BPCPBFPDLJG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int IHHDKIIJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C2490", Offset = "0x5C1090", VA = "0x1805C2490")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool PNEDKLCBMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x31D4CC0", Offset = "0x31D38C0", VA = "0x1831D4CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int HCDDOGAPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C24A0", Offset = "0x5C10A0", VA = "0x1805C24A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B7500", Offset = "0x5B6100", VA = "0x1805B7500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey NGKNGLDJJGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x31D5390", Offset = "0x31D3F90", VA = "0x1831D5390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x31D5540", Offset = "0x31D4140", VA = "0x1831D5540")]
	public AKJAPGOBFGA(int FNDGLMJFLAE, [Optional] PMAKOCKKAOC DIPDPNCNEHE, [Optional] IEqualityComparer<TKey> JFCBJKHDLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x31D5900", Offset = "0x31D4500", VA = "0x1831D5900")]
	public AKJAPGOBFGA(int FNDGLMJFLAE, PMAKOCKKAOC DIPDPNCNEHE, TimeSpan LFBOPOGPNHI, [Optional] IEqualityComparer<TKey> JFCBJKHDLNJ, [Optional] JPJLICNAGNL BPCPBFPDLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x31D4660", Offset = "0x31D3260", VA = "0x1831D4660")]
	public void EDGLIGFOMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x31D53C0", Offset = "0x31D3FC0", VA = "0x1831D53C0")]
	public void OHBMCBALBKC(TKey FHJAGMPOINB, TVal CKGFDBLPDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x31D5210", Offset = "0x31D3E10", VA = "0x1831D5210")]
	public bool NGAMBELFHAP(TKey FHJAGMPOINB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x31D4490", Offset = "0x31D3090", VA = "0x1831D4490")]
	public bool DEELIMOLEHE(TKey COCIHDCPJHJ, out TVal CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x31D45E0", Offset = "0x31D31E0", VA = "0x1831D45E0")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x31D5090", Offset = "0x31D3C90", VA = "0x1831D5090")]
	private bool MNHLPHOOOLF(LKKLCFHHPJC JPHFFEMCENF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x31D47C0", Offset = "0x31D33C0", VA = "0x1831D47C0")]
	private void EPMBMMJDHAI(LinkedListNode<LKKLCFHHPJC> OLFOJMKBIAP, TVal BDMINDPHCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x31D3F30", Offset = "0x31D2B30", VA = "0x1831D3F30")]
	private void BIBACEFCHAA(TKey FHJAGMPOINB, TVal CKGFDBLPDNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x31D4EF0", Offset = "0x31D3AF0", VA = "0x1831D4EF0")]
	private void KMPKDEIBJOJ(LKKLCFHHPJC JPHFFEMCENF, TVal BDMINDPHCKG, int NJFPHGEPECN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class KJDPEGJNLHK<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<T> LECLKFBNECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private HashSet<T> OGDOMFLOJCO;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EIKCLJIDIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA2D0", Offset = "0x1AA8ED0", VA = "0x181AAA2D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool IHCLLDNIEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4BFA40", VA = "0x1804C0E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T NGKNGLDJJGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2E8C4D0", Offset = "0x2E8B0D0", VA = "0x182E8C4D0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x39B6CF0", Offset = "0x39B58F0", VA = "0x1839B6CF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x215A380", Offset = "0x2158F80", VA = "0x18215A380", Slot = "11")]
	public void Add(T DGBNADBMPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x39B68F0", Offset = "0x39B54F0", VA = "0x1839B68F0")]
	public bool LPBGIPIDFMA(T DGBNADBMPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x39B6BE0", Offset = "0x39B57E0", VA = "0x1839B6BE0", Slot = "15")]
	public bool Remove(T DGBNADBMPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6EF0", Offset = "0x2BA5AF0", VA = "0x182BA6EF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2137830", Offset = "0x2136430", VA = "0x182137830", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x39B66D0", Offset = "0x39B52D0", VA = "0x1839B66D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D080", Offset = "0x2E4BC80", VA = "0x182E4D080", Slot = "13")]
	public bool Contains(T DGBNADBMPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x39B6730", Offset = "0x39B5330", VA = "0x1839B6730", Slot = "14")]
	public void CopyTo(T[] KFPJHHDGLAI, int PPKBGADLMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2FB3180", Offset = "0x2FB1D80", VA = "0x182FB3180", Slot = "6")]
	public int IndexOf(T DGBNADBMPHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x39B6830", Offset = "0x39B5430", VA = "0x1839B6830", Slot = "7")]
	public void Insert(int AOPIKBGIANA, T DGBNADBMPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x39B6B10", Offset = "0x39B5710", VA = "0x1839B6B10", Slot = "8")]
	public void RemoveAt(int AOPIKBGIANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x337E550", Offset = "0x337D150", VA = "0x18337E550")]
	public KJDPEGJNLHK()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1CA8BB0", Offset = "0x1CA77B0", VA = "0x181CA8BB0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x43B5E00", Offset = "0x43B4A00", VA = "0x1843B5E00")]
		public SerializedGuid(in Guid FPIODBBNDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x43B59F0", Offset = "0x43B45F0", VA = "0x1843B59F0")]
		public static SerializedGuid BCFJGDFKGAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x43B5A70", Offset = "0x43B4670", VA = "0x1843B5A70")]
		public static SerializedGuid CCEAOPOJFLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x43B5CA0", Offset = "0x43B48A0", VA = "0x1843B5CA0")]
		public bool FBJKCBCNKND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x43B5DE0", Offset = "0x43B49E0", VA = "0x1843B5DE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x43B5D40", Offset = "0x43B4940", VA = "0x1843B5D40", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x43B5B20", Offset = "0x43B4720", VA = "0x1843B5B20", Slot = "7")]
		public bool Equals(SerializedGuid AIGGKBBOAOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x43B5BC0", Offset = "0x43B47C0", VA = "0x1843B5BC0", Slot = "0")]
		public override bool Equals(object JPFPDMFLBGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x43B5D30", Offset = "0x43B4930", VA = "0x1843B5D30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x43B5AF0", Offset = "0x43B46F0", VA = "0x1843B5AF0", Slot = "6")]
		public int CompareTo(SerializedGuid AIGGKBBOAOI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class CCBPDACIBHN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Type KDICGPAPMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string KKCCOOCMCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool HKCAFLJPJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool IAMGEBOOLPL;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x43B39F0", Offset = "0x43B25F0", VA = "0x1843B39F0")]
	public CCBPDACIBHN(Type ELABLLPGBIC, string GCAJJGEPNII, bool BDOBPNPOCIC = false, bool JKKBIHDJOON = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface OJMBBDPGJIG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T PDHGPELKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool PNPHFDIOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::OJMBBDPGJIG<T> KEFLPANFFCJ(Action<T> NJKOGIPEDPM);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OJMBBDPGJIG<T> DCKNNPADLGM(Action<T> NJKOGIPEDPM);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GMKBDOBOCIC<T> : global::OJMBBDPGJIG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private global::LLPJDBNPJMC<T, T> LGMDAHOAPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private global::BFLOCGMDDIM<T> HMOBIPPCFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private global::BFLOCGMDDIM<string> ENKFBIOHCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string FPODCKNNJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private T PKOHMGJOJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool OANLNPCMKKJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T PDHGPELKFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4E7670", Offset = "0x4E6270", VA = "0x1804E7670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1B3FC00", Offset = "0x1B3E800", VA = "0x181B3FC00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PNPHFDIOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x562D60", Offset = "0x561960", VA = "0x180562D60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x215A620", Offset = "0x2159220", VA = "0x18215A620")]
	private void MDFLNAJAJDN(T EFFAKKDCCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x215A5A0", Offset = "0x21591A0", VA = "0x18215A5A0", Slot = "4")]
	public global::OJMBBDPGJIG<T> KEFLPANFFCJ(Action<T> MDCHNEIOHBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x215A570", Offset = "0x2159170", VA = "0x18215A570", Slot = "5")]
	public global::OJMBBDPGJIG<T> DCKNNPADLGM(Action<T> NJKOGIPEDPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x215A6A0", Offset = "0x21592A0", VA = "0x18215A6A0")]
	public GMKBDOBOCIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class BNGPHKIKHPP
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class PKIBGEHHHNI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public global::OJMBBDPGJIG<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public global::LPMDECKDEDF<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public PKIBGEHHHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1DDE770", Offset = "0x1DDD370", VA = "0x181DDE770")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x20E8220", Offset = "0x20E6E20", VA = "0x1820E8220")]
	public static global::JLPBMLKOEIK<T> BFNFEFOJIIF<T>(this global::OJMBBDPGJIG<T> FBNLAADMFLI, Action<T> HOOMNAEGALB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class JPJLICNAGNL
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class CLGFHJCJKGB : JPJLICNAGNL
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static JPJLICNAGNL CEDFFLANLFL
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x43B3D90", Offset = "0x43B2990", VA = "0x1843B3D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime IIAPCPPKEJC
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x43B3DF0", Offset = "0x43B29F0", VA = "0x1843B3DF0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x43B3ED0", Offset = "0x43B2AD0", VA = "0x1843B3ED0")]
		public CLGFHJCJKGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static JPJLICNAGNL FGJHKAPEFCB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static JPJLICNAGNL JHLCBNHJMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x43B5430", Offset = "0x43B4030", VA = "0x1843B5430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime IIAPCPPKEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
	protected JPJLICNAGNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class OJCMELLLGKP : global::LMEFDBLEMJE<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x43B55A0", Offset = "0x43B41A0", VA = "0x1843B55A0")]
	public OJCMELLLGKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class LMEFDBLEMJE<T> : global::JGCNBKKEKJO<T>, NMBKMBMMHGJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> LOHJDBJKOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::JLPBMLKOEIK<T> HPJFGJMLKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private DPJKDCDGPPB OOPLFDBLCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x185C8F0", Offset = "0x185B4F0", VA = "0x18185C8F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x235F630", Offset = "0x235E230", VA = "0x18235F630")]
	public LMEFDBLEMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class AMIAJIADMCL<T> : global::JGCNBKKEKJO<T>, NMBKMBMMHGJ, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> LOHJDBJKOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::JLPBMLKOEIK<T> HPJFGJMLKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private DPJKDCDGPPB OOPLFDBLCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x185C8F0", Offset = "0x185B4F0", VA = "0x18185C8F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x31D5D70", Offset = "0x31D4970", VA = "0x1831D5D70")]
	public AMIAJIADMCL(Exception EMFHNCOFDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface NMBKMBMMHGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	DPJKDCDGPPB HPJFGJMLKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface JGCNBKKEKJO<T> : NMBKMBMMHGJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> LOHJDBJKOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::JLPBMLKOEIK<T> HPJFGJMLKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class FFDBNLIPNFA<TTask, T> : global::JGCNBKKEKJO<T>, NMBKMBMMHGJ, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class AOCHIJCOALF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public global::FFDBNLIPNFA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public AOCHIJCOALF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BEMDAHBGPON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AOCHIJCOALF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		public BEMDAHBGPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x30105E0", Offset = "0x300F1E0", VA = "0x1830105E0")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static bool FDPBIDPANBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly global::LPMDECKDEDF<T> OCDAJANHFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Task<T> AHANOPALGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly CancellationTokenSource MCDOCEDBHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool FPMIKEKHGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private SynchronizationContext GKBNELIJPGO;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> LOHJDBJKOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::JLPBMLKOEIK<T> HPJFGJMLKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private DPJKDCDGPPB OOPLFDBLCGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool NIIEFEEKAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x561E90", Offset = "0x560A90", VA = "0x180561E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x30170E0", Offset = "0x3015CE0", VA = "0x1830170E0")]
	static FFDBNLIPNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3017250", Offset = "0x3015E50", VA = "0x183017250")]
	protected FFDBNLIPNFA(TTask AHANOPALGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3016DA0", Offset = "0x30159A0", VA = "0x183016DA0", Slot = "1")]
	~FFDBNLIPNFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1AAB280", Offset = "0x1AA9E80", VA = "0x181AAB280", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3016EE0", Offset = "0x3015AE0", VA = "0x183016EE0")]
	private void IGOHHICEBGI(bool EJEOCGKEEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T JPINMGDPDKA(TTask DIFLEKEEHGL);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void IILNDKJLPHF();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3017050", Offset = "0x3015C50", VA = "0x183017050")]
	protected void JMNOEHIEJAG(T EFFAKKDCCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1AAB200", Offset = "0x1AA9E00", VA = "0x181AAB200")]
	protected void APMDFJKNGPD(string FPODCKNNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3016E40", Offset = "0x3015A40", VA = "0x183016E40")]
	[CompilerGenerated]
	private void GKOAMCHMHKD(object INMIDJALPMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PCHIMEBKEHM<T> : IEnumerable<global::PCHIMEBKEHM<T>.BFJPCEAFFCC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct BFJPCEAFFCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public T CKGFDBLPDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int AOPIKBGIANA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class NFEMACAHOBP : IEnumerator<BFJPCEAFFCC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private global::PCHIMEBKEHM<T> KAMKEPLONIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int AOPIKBGIANA;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x227B130", Offset = "0x2279D30", VA = "0x18227B130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public BFJPCEAFFCC BMBEKKPNJGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2E4C7D0", Offset = "0x2E4B3D0", VA = "0x182E4C7D0", Slot = "4")]
			get
			{
				return default(BFJPCEAFFCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x758190", Offset = "0x756D90", VA = "0x180758190")]
		public NFEMACAHOBP(global::PCHIMEBKEHM<T> KAMKEPLONIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2E4C740", Offset = "0x2E4B340", VA = "0x182E4C740", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x60FE80", Offset = "0x60EA80", VA = "0x18060FE80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7244D0", Offset = "0x7230D0", VA = "0x1807244D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct HLKLDBMJCOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool ADMHDPHHOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public T CKGFDBLPDNJ;
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private const int FPNEKFHMLKP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<T, int> EHIHBFKEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private HLKLDBMJCOB[] EEDLAKIODPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int EMBAAGGCDBL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int EIKCLJIDIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E00", Offset = "0x2AF1A00", VA = "0x182AF2E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2E562D0", Offset = "0x2E54ED0", VA = "0x182E562D0")]
	public static global::PCHIMEBKEHM<T> OAGNCBMPMOC(BFJPCEAFFCC[] BFGHDAJICDE, bool GOCELNOPALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2E56700", Offset = "0x2E55300", VA = "0x182E56700")]
	public PCHIMEBKEHM(int FNDGLMJFLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2E55F00", Offset = "0x2E54B00", VA = "0x182E55F00")]
	public int HCBFEGFCNFM(T CKGFDBLPDNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2E55E90", Offset = "0x2E54A90", VA = "0x182E55E90")]
	public T BFNFEFOJIIF(int AOPIKBGIANA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2E560E0", Offset = "0x2E54CE0", VA = "0x182E560E0")]
	public bool LPBGIPIDFMA(T CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2E56100", Offset = "0x2E54D00", VA = "0x182E56100")]
	public bool LPBGIPIDFMA(T CKGFDBLPDNJ, int AOPIKBGIANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2E55F50", Offset = "0x2E54B50", VA = "0x182E55F50")]
	public BFJPCEAFFCC[] HLJAACBHJLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2E56090", Offset = "0x2E54C90", VA = "0x182E56090")]
	private int IBEEKKIOHDK(int MIJFAJPIKJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2E56690", Offset = "0x2E55290", VA = "0x182E56690", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2E56690", Offset = "0x2E55290", VA = "0x182E56690", Slot = "4")]
	private IEnumerator<BFJPCEAFFCC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class EOAEMELCILA<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private List<T> KGGKAOHDDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private List<T> ANFAIGMIJNP;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3015450", Offset = "0x3014050", VA = "0x183015450")]
	public EOAEMELCILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x30152F0", Offset = "0x3013EF0", VA = "0x1830152F0")]
	public EOAEMELCILA(int FNDGLMJFLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x30150D0", Offset = "0x3013CD0", VA = "0x1830150D0")]
	public T ANOJGJIKDGO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x30151D0", Offset = "0x3013DD0", VA = "0x1830151D0")]
	public void NEIAKLBGBGK(T FFGFDLGNIBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GJCJFNEJANA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Dictionary<int, T> LHMHNOFLELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private T KGDDJJILMAJ;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual T LIHIGOAOFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BED90", VA = "0x1804C0190", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4C0450", Offset = "0x4BF050", VA = "0x1804C0450", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x21580C0", Offset = "0x2156CC0", VA = "0x1821580C0")]
	public bool BIBACEFCHAA(T CKGFDBLPDNJ, int OPFBNHGJJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2158120", Offset = "0x2156D20", VA = "0x182158120")]
	public bool BPFHKBMPBGB(int OPFBNHGJJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x21585C0", Offset = "0x21571C0", VA = "0x1821585C0")]
	public T NHADCHGPLKB(int FFOKODKMMFP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x21581B0", Offset = "0x2156DB0", VA = "0x1821581B0")]
	private bool MCDCDAKOLFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2158180", Offset = "0x2156D80", VA = "0x182158180")]
	public bool DEELIMOLEHE(int OPFBNHGJJFP, out T CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2158820", Offset = "0x2157420", VA = "0x182158820")]
	public GJCJFNEJANA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class ELAHKHJIELM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	protected struct FFCGPBJDMEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public T PDHGPELKFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int GJDECGFNJPG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	protected readonly List<FFCGPBJDMEH> NOCOIGLAGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private T CLBNOFFGNPC;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int EIKCLJIDIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA2D0", Offset = "0x1AA8ED0", VA = "0x181AAA2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3010C50", Offset = "0x300F850", VA = "0x183010C50")]
	public bool KNFNNNAADCG(T CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3011050", Offset = "0x300FC50", VA = "0x183011050")]
	public void ONPEBFNMAMA(T CKGFDBLPDNJ, int OPFBNHGJJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3010F30", Offset = "0x300FB30", VA = "0x183010F30")]
	public bool NGAMBELFHAP(T CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x30109E0", Offset = "0x300F5E0", VA = "0x1830109E0")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3010EA0", Offset = "0x300FAA0", VA = "0x183010EA0")]
	public T LOIMFCDBDPN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3010A40", Offset = "0x300F640", VA = "0x183010A40")]
	private void GGIMLDCBJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x30110D0", Offset = "0x300FCD0", VA = "0x1830110D0")]
	public ELAHKHJIELM()
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
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1B14D80", Offset = "0x1B13980", VA = "0x181B14D80", Slot = "4")]
		public virtual T GJFOOBIJFDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x185CA00", Offset = "0x185B600", VA = "0x18185CA00")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GHIABFIBFHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly Dictionary<byte, OMJKDCADAPJ> MCALCEHNFPC;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public OMJKDCADAPJ HELFLJGMGID
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BEDA0", VA = "0x1804C01A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4C0440", Offset = "0x4BF040", VA = "0x1804C0440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Vector2 BPEDFNGKBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x16EAB50", Offset = "0x16E9750", VA = "0x1816EAB50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2F36580", Offset = "0x2F35180", VA = "0x182F36580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector2 JCMPDBFGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1167F10", Offset = "0x1166B10", VA = "0x181167F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Vector2 CLHFOOGDEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x311DCD0", Offset = "0x311C8D0", VA = "0x18311DCD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x311DCF0", Offset = "0x311C8F0", VA = "0x18311DCF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GMHBBGIPGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1B0", Offset = "0x4E8DB0", VA = "0x1804EA1B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x50F360", Offset = "0x50DF60", VA = "0x18050F360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x43B4EF0", Offset = "0x43B3AF0", VA = "0x1843B4EF0")]
	public GHIABFIBFHE(Bounds KPONGGMGMBL, Vector2[] GCBKFEKILNA, int AGLOKNGKNHH, byte MIJFAJPIKJH, float IELIJEKKJEA = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x43B4750", Offset = "0x43B3350", VA = "0x1843B4750")]
	public OMJKDCADAPJ AIGJMEMOFOB(byte AOPIKBGIANA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x43B4DF0", Offset = "0x43B39F0", VA = "0x1843B4DF0")]
	public void LABLKKFOOAH(Vector3 GONMOODGFLI, float CBHOKCNBEJC, float KOGMOBADJHD, ref List<byte> KCJABNHCECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x43B4ED0", Offset = "0x43B3AD0", VA = "0x1843B4ED0")]
	public void LGJDKOPJGOG(OMJKDCADAPJ.GOAMJNJIMOI COJDJIFDOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x43B4CD0", Offset = "0x43B38D0", VA = "0x1843B4CD0")]
	private OMJKDCADAPJ JLOABKBKOIO(byte AOPIKBGIANA, OMJKDCADAPJ.IDAJPMOJKMC DJJCACHOPCP, OMJKDCADAPJ DHGONCCILCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x43B47B0", Offset = "0x43B33B0", VA = "0x1843B47B0")]
	private void BBIIJAMGNPH(OMJKDCADAPJ DHGONCCILCM, Vector2[] GCBKFEKILNA, int CPGEIGBMFBB, int ALANOAAGBCG, int AJILGNBHFJC, int JJAPLJNBFJA, float IELIJEKKJEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class OMJKDCADAPJ
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum IDAJPMOJKMC
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum GOAMJNJIMOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public byte PBJKGPAPGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Vector3 PFADFGAIFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Vector3 HCFGEGPKPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Vector3 JAMMAMCHKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Vector3 BMHIMAIHHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public IDAJPMOJKMC IBIAPCALDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public OMJKDCADAPJ IHAFALAAILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public List<OMJKDCADAPJ> NHOJIKMAJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public bool HEOJJJDDFGM;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x43B59A0", Offset = "0x43B45A0", VA = "0x1843B59A0")]
	public OMJKDCADAPJ(byte EKFMAMHCIBC, IDAJPMOJKMC DJJCACHOPCP, OMJKDCADAPJ DHGONCCILCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x43B5680", Offset = "0x43B4280", VA = "0x1843B5680")]
	public void EDOKFJCIGIP(OMJKDCADAPJ EODPGMPNJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00")]
	public void LGJDKOPJGOG(int MKAJAPLHBCA, GOAMJNJIMOI COJDJIFDOJJ, int FPANLDKNAHH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x43B5710", Offset = "0x43B4310", VA = "0x1843B5710")]
	public void LABLKKFOOAH(List<byte> KCJABNHCECB, Vector3 GONMOODGFLI, float CBHOKCNBEJC, float KOGMOBADJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x43B55E0", Offset = "0x43B41E0", VA = "0x1843B55E0")]
	public bool ALEEIDKEGFE(Vector3 COJAIINNBNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x43B5640", Offset = "0x43B4240", VA = "0x1843B5640")]
	public bool BBKIICJNJKG(Vector3 COJAIINNBNF, float IELHCBFPDNK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class EBJGJIPKGEI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int FNDGLMJFLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private int LLLFMCHACMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private List<T> KCMLLCBLMFB;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T JPELOKEJBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7380", Offset = "0x2BA5F80", VA = "0x182BA7380")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T OPEEMAMDNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2BA7280", Offset = "0x2BA5E80", VA = "0x182BA7280")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T JHAMMKLJMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2BA72C0", Offset = "0x2BA5EC0", VA = "0x182BA72C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7720", Offset = "0x2BA6320", VA = "0x182BA7720")]
	public EBJGJIPKGEI(int FNDGLMJFLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2BA74A0", Offset = "0x2BA60A0", VA = "0x182BA74A0")]
	public void ONPEBFNMAMA(T NOJKBNKICBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2BA71D0", Offset = "0x2BA5DD0", VA = "0x182BA71D0")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7170", Offset = "0x2BA5D70", VA = "0x182BA7170")]
	public void BGAEKNMNLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2BA71C0", Offset = "0x2BA5DC0", VA = "0x182BA71C0")]
	public void CGIOBDFALFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class HIJNDEPKBCE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct MLFLAPPKNEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int GJDECGFNJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public T PDHGPELKFGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Dictionary<object, MLFLAPPKNEC> LHMHNOFLELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private T KGDDJJILMAJ;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T LIHIGOAOFHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x16EAB50", Offset = "0x16E9750", VA = "0x1816EAB50", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2F36580", Offset = "0x2F35180", VA = "0x182F36580", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool JHJIODGBJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2F365F0", Offset = "0x2F351F0", VA = "0x182F365F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public object AOCOCFDFEGC
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4C2CF0", Offset = "0x4C18F0", VA = "0x1804C2CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4E97D0", Offset = "0x4E83D0", VA = "0x1804E97D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2F367E0", Offset = "0x2F353E0", VA = "0x182F367E0")]
	public bool BIBACEFCHAA(T CKGFDBLPDNJ, object AIGCPEIHNCB, int OPFBNHGJJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2F36D50", Offset = "0x2F35950", VA = "0x182F36D50")]
	public bool BPFHKBMPBGB(object AIGCPEIHNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2F37000", Offset = "0x2F35C00", VA = "0x182F37000")]
	public bool DEELIMOLEHE(object AIGCPEIHNCB, out T CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2F37370", Offset = "0x2F35F70", VA = "0x182F37370")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2F3B590", Offset = "0x2F3A190", VA = "0x182F3B590")]
	private bool MCDCDAKOLFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C030", Offset = "0x2F3AC30", VA = "0x182F3C030")]
	public HIJNDEPKBCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class AIBDKDAGIAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Dictionary<object, float> LHMHNOFLELN;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float AHNIKDCNOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xCEBD90", Offset = "0xCEA990", VA = "0x180CEBD90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1281C90", Offset = "0x1280890", VA = "0x181281C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x43B3720", Offset = "0x43B2320", VA = "0x1843B3720")]
	public void BIBACEFCHAA(float CKGFDBLPDNJ, object AIGCPEIHNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x43B3790", Offset = "0x43B2390", VA = "0x1843B3790")]
	public void BPFHKBMPBGB(object AIGCPEIHNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x43B3800", Offset = "0x43B2400", VA = "0x1843B3800")]
	private void PNNIPJCNJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x43B3920", Offset = "0x43B2520", VA = "0x1843B3920")]
	public AIBDKDAGIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class DBCAIMMEBCB
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class JFOPGMKBMJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly string HAIAIFJDLMF;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
		private JFOPGMKBMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x59C930", Offset = "0x59B530", VA = "0x18059C930")]
		public JFOPGMKBMJB(string HAIAIFJDLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x43B53E0", Offset = "0x43B3FE0", VA = "0x1843B53E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class CJOJHBOIHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
		public CJOJHBOIHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x43B3CE0", Offset = "0x43B28E0", VA = "0x1843B3CE0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HashSet<object> CEPDIOBLFLJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool LPBPDPKHIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x43B42D0", Offset = "0x43B2ED0", VA = "0x1843B42D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int EIKCLJIDIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x43B4240", Offset = "0x43B2E40", VA = "0x1843B4240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x43B4420", Offset = "0x43B3020", VA = "0x1843B4420")]
	public bool ONPEBFNMAMA(object AIGCPEIHNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x43B4370", Offset = "0x43B2F70", VA = "0x1843B4370")]
	public bool NGAMBELFHAP(object AIGCPEIHNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x43B4310", Offset = "0x43B2F10", VA = "0x1843B4310")]
	public bool KNFNNNAADCG(object AIGCPEIHNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x43B4280", Offset = "0x43B2E80", VA = "0x1843B4280")]
	public void HPKJHONEFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x43B44D0", Offset = "0x43B30D0", VA = "0x1843B44D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x43B4630", Offset = "0x43B3230", VA = "0x1843B4630")]
	public DBCAIMMEBCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EMBDJBFDEGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private struct EALHHGELGMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public float OLIGOKBLILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public T PDHGPELKFGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Dictionary<object, EALHHGELGMH> LHMHNOFLELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private T MDMCJFJHILP;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public virtual T MEKDGCICIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xEAFFB0", Offset = "0xEAEBB0", VA = "0x180EAFFB0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2F365B0", Offset = "0x2F351B0", VA = "0x182F365B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public object AJNEBBIEOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4E7670", Offset = "0x4E6270", VA = "0x1804E7670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x59F9E0", Offset = "0x59E5E0", VA = "0x18059F9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool JHJIODGBJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3011150", Offset = "0x300FD50", VA = "0x183011150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3011580", Offset = "0x3010180", VA = "0x183011580")]
	public bool BIBACEFCHAA(T CKGFDBLPDNJ, object AIGCPEIHNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3011850", Offset = "0x3010450", VA = "0x183011850")]
	public bool BPFHKBMPBGB(object AIGCPEIHNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2F37370", Offset = "0x2F35F70", VA = "0x182F37370")]
	public void DJMOCJEOBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x30119C0", Offset = "0x30105C0", VA = "0x1830119C0")]
	public bool DEELIMOLEHE(object AIGCPEIHNCB, out T CKGFDBLPDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3011FA0", Offset = "0x3010BA0", VA = "0x183011FA0")]
	private bool MCDCDAKOLFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3013870", Offset = "0x3012470", VA = "0x183013870")]
	public EMBDJBFDEGA()
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
