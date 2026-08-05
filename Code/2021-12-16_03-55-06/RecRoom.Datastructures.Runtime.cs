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
public class DHBMNNEDHNN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D94B0", Offset = "0x5D88B0", VA = "0x1805D94B0")]
	public DHBMNNEDHNN()
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
		[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE60", Offset = "0x4BF260", VA = "0x1804BFE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4BF450", Offset = "0x4BE850", VA = "0x1804BF450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "4")]
	public virtual void DEFCIGGEBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
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
	[DHBMNNEDHNN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3816E70", Offset = "0x3816270", VA = "0x183816E70", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38169B0", Offset = "0x3815DB0", VA = "0x1838169B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3817470", Offset = "0x3816870", VA = "0x183817470")]
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
	private sealed class GFKGPACAODP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public GFKGPACAODP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x27400A0", Offset = "0x273F4A0", VA = "0x1827400A0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[DHBMNNEDHNN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x273FDF0", Offset = "0x273F1F0", VA = "0x18273FDF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x273FE20", Offset = "0x273F220", VA = "0x18273FE20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x273FD40", Offset = "0x273F140", VA = "0x18273FD40", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey KFLAFLPOCPA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x273FD70", Offset = "0x273F170", VA = "0x18273FD70", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x273FC50", Offset = "0x273F050", VA = "0x18273FC50", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x273F4C0", Offset = "0x273E8C0", VA = "0x18273F4C0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x273EE30", Offset = "0x273E230", VA = "0x18273EE30", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x273EA90", Offset = "0x273DE90", VA = "0x18273EA90", Slot = "14")]
	protected virtual string INFILFIPIEN(TKeyVal GDKPINMGOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x273E970", Offset = "0x273DD70", VA = "0x18273E970", Slot = "4")]
	public bool ContainsKey(TKey KFLAFLPOCPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x273FB50", Offset = "0x273EF50", VA = "0x18273FB50", Slot = "5")]
	public bool TryGetValue(TKey KFLAFLPOCPA, out TVal DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x273E9A0", Offset = "0x273DDA0", VA = "0x18273E9A0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x273E9A0", Offset = "0x273DDA0", VA = "0x18273E9A0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x273FB80", Offset = "0x273EF80", VA = "0x18273FB80")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KPNBKPLAIFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LCOBCPALCFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public LCOBCPALCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x324BC90", Offset = "0x324B090", VA = "0x18324BC90")]
		internal bool <GetSamples>b__0(global::OGBIKIGLBLP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float FLFCKJODOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float AKMKPLPMDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::OGBIKIGLBLP<float, T>> LKIOPPCKNNP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KBNKEDOHLLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3249210", Offset = "0x3248610", VA = "0x183249210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3249310", Offset = "0x3248710", VA = "0x183249310")]
	public KPNBKPLAIFC(float OANCMOIGOFE, float EAIELAPLNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3248960", Offset = "0x3247D60", VA = "0x183248960")]
	public bool HHDLAAIPGGN(float KLDELJKHMFI, T DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3248B80", Offset = "0x3247F80", VA = "0x183248B80")]
	public IEnumerable<T> JJIENBBNICD(float KLDELJKHMFI, [Optional] float? KEIADPCMPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32491E0", Offset = "0x32485E0", VA = "0x1832491E0")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3248AC0", Offset = "0x3247EC0", VA = "0x183248AC0")]
	private void HHPKNCNELDL(float KLDELJKHMFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class OPAOKAOHNEP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct HABNGAIFAIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T HDOIMHJBCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float CNEDJKMEOOL;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float IEKOMBEMLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> PKCGEJEMKLI;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int KMPBKKNJMJK = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private HABNGAIFAIL[] HMDONCJONHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int ENIBPGODMJF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float EKABCIBGOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE1ADE0", Offset = "0xE1A1E0", VA = "0x180E1ADE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xB9D140", Offset = "0xB9C540", VA = "0x180B9D140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1F56F60", Offset = "0x1F56360", VA = "0x181F56F60")]
	public OPAOKAOHNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1F56E90", Offset = "0x1F56290", VA = "0x181F56E90")]
	public OPAOKAOHNEP(int BLFDIIPJAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1F56380", Offset = "0x1F55780", VA = "0x181F56380")]
	public void HOKAIAEDNBH(float KLDELJKHMFI, T DOLIKBJJDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1F569E0", Offset = "0x1F55DE0", VA = "0x181F569E0")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1F56480", Offset = "0x1F55880", VA = "0x181F56480")]
	public bool KHMJBNOIEPG(float NCPEFDAANNC, float DDAPCNLABHN, out T DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1F56CE0", Offset = "0x1F560E0", VA = "0x181F56CE0")]
	public bool OADALGNCGKM(float NCPEFDAANNC, float DDAPCNLABHN, out T DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1F56150", Offset = "0x1F55550", VA = "0x181F56150")]
	public void EHLPNKKPAGI(float NCPEFDAANNC, float DDAPCNLABHN, List<T> EGFOHHMMBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1F56450", Offset = "0x1F55850", VA = "0x181F56450")]
	private int IBMGGKKHHBA(int NHOHGGMHKDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1F56850", Offset = "0x1F55C50", VA = "0x181F56850")]
	private void LDFELNJBDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CGDAGKHMPKB();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T ICKFEBPAGPF(T DOLIKBJJDJE, float PHCIJGLCCKN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T ENICKAOBOKN(T OJMCEMLKDIK, T HDIPEJDAODD);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T LMCGOBMPECH(T OJMCEMLKDIK, T HDIPEJDAODD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DEPMLPEHBCL : global::OPAOKAOHNEP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x43AE6A0", Offset = "0x43ADAA0", VA = "0x1843AE6A0", Slot = "4")]
	protected override Vector3 CGDAGKHMPKB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x43AE7C0", Offset = "0x43ADBC0", VA = "0x1843AE7C0", Slot = "5")]
	protected override Vector3 ICKFEBPAGPF(Vector3 DOLIKBJJDJE, float PHCIJGLCCKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x43AE710", Offset = "0x43ADB10", VA = "0x1843AE710", Slot = "6")]
	protected override Vector3 ENICKAOBOKN(Vector3 OJMCEMLKDIK, Vector3 HDIPEJDAODD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x43AE860", Offset = "0x43ADC60", VA = "0x1843AE860", Slot = "7")]
	protected override Vector3 LMCGOBMPECH(Vector3 OJMCEMLKDIK, Vector3 HDIPEJDAODD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43AE8D0", Offset = "0x43ADCD0", VA = "0x1843AE8D0")]
	public DEPMLPEHBCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GBEDFAKIEIH
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x201F600", Offset = "0x201EA00", VA = "0x18201F600")]
	public static global::OGBIKIGLBLP<T1, T2> PPKMIALMIPA<T1, T2>(T1 JLDGBLIMIGN, T2 INHKCPIPIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D0A0", Offset = "0x1B5C4A0", VA = "0x181B5D0A0")]
	public static global::IBMJGCDHOEL<T1, T2, T3> PPKMIALMIPA<T1, T2, T3>(T1 JLDGBLIMIGN, T2 INHKCPIPIFL, T3 DIAJGGHEJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x204AD90", Offset = "0x204A190", VA = "0x18204AD90")]
	internal static int KMOHCEGIMNJ(int PJJNJBHLEOF, int MEOAHJHGINN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3E76990", Offset = "0x3E75D90", VA = "0x183E76990")]
	internal static int KMOHCEGIMNJ(int PJJNJBHLEOF, int MEOAHJHGINN, int DCKDAMJPAIF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OGBIKIGLBLP<T1, T2> : IComparable<global::OGBIKIGLBLP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 KCNMONGFOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 FHPHNGKMLLP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24EBFC0", Offset = "0x24EB3C0", VA = "0x1824EBFC0")]
	public OGBIKIGLBLP(T1 JLDGBLIMIGN, T2 INHKCPIPIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24EA680", Offset = "0x24E9A80", VA = "0x1824EA680", Slot = "4")]
	public int CompareTo(global::OGBIKIGLBLP<T1, T2> DGBPCHLONNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x24EA7A0", Offset = "0x24E9BA0", VA = "0x1824EA7A0", Slot = "0")]
	public override bool Equals(object DGBPCHLONNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24EB2F0", Offset = "0x24EA6F0", VA = "0x1824EB2F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x24EB930", Offset = "0x24EAD30", VA = "0x1824EB930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IBMJGCDHOEL<T1, T2, T3> : IComparable<global::IBMJGCDHOEL<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 KCNMONGFOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 FHPHNGKMLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 AIPIPJAHOBF;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D102A0", Offset = "0x2D0F6A0", VA = "0x182D102A0")]
	public IBMJGCDHOEL(T1 JLDGBLIMIGN, T2 INHKCPIPIFL, T3 DIAJGGHEJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FBC0", Offset = "0x2D0EFC0", VA = "0x182D0FBC0", Slot = "4")]
	public int CompareTo(global::IBMJGCDHOEL<T1, T2, T3> DGBPCHLONNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FDB0", Offset = "0x2D0F1B0", VA = "0x182D0FDB0", Slot = "0")]
	public override bool Equals(object DGBPCHLONNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D0FFB0", Offset = "0x2D0F3B0", VA = "0x182D0FFB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D10110", Offset = "0x2D0F510", VA = "0x182D10110", Slot = "3")]
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
	public T HDOIMHJBCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4E6670", Offset = "0x4E5A70", VA = "0x1804E6670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDD0", Offset = "0x5AE1D0", VA = "0x1805AEDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float OFEPJMOOKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB4F420", Offset = "0xB4E820", VA = "0x180B4F420")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x30F8D20", Offset = "0x30F8120", VA = "0x1830F8D20")]
	public T IKPGNMIBDHO(float PHCIJGLCCKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x30F8A70", Offset = "0x30F7E70", VA = "0x1830F8A70")]
	public T CHFFFLDNNNH(float PHCIJGLCCKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EPDJAFCIONH(T OJMCEMLKDIK, T HDIPEJDAODD, float PHCIJGLCCKN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x43AED80", Offset = "0x43AE180", VA = "0x1843AED80", Slot = "4")]
	protected override float EPDJAFCIONH(float OJMCEMLKDIK, float HDIPEJDAODD, float PHCIJGLCCKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x43AEE00", Offset = "0x43AE200", VA = "0x1843AEE00")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x43AFDC0", Offset = "0x43AF1C0", VA = "0x1843AFDC0", Slot = "4")]
	protected override Vector3 EPDJAFCIONH(Vector3 OJMCEMLKDIK, Vector3 HDIPEJDAODD, float PHCIJGLCCKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x43AFE80", Offset = "0x43AF280", VA = "0x1843AFE80")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4391B60", Offset = "0x4390F60", VA = "0x184391B60", Slot = "4")]
	protected override Color EPDJAFCIONH(Color OJMCEMLKDIK, Color HDIPEJDAODD, float PHCIJGLCCKN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x43AE600", Offset = "0x43ADA00", VA = "0x1843AE600")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class IMAFLJACAOB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> ADOGPMCHPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> EJLBJEKJJPP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OGGICMHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1879990", Offset = "0x1878D90", VA = "0x181879990", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool LGOOAHABKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE40", Offset = "0x4BF240", VA = "0x1804BFE40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> ODKIBGPDEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1EB18E0", Offset = "0x1EB0CE0", VA = "0x181EB18E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> HEHJCBKBLID
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1F0DA50", Offset = "0x1F0CE50", VA = "0x181F0DA50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal OGDAEEHFBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2CC6B20", Offset = "0x2CC5F20", VA = "0x182CC6B20", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D18410", Offset = "0x2D17810", VA = "0x182D18410", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2D17EB0", Offset = "0x2D172B0", VA = "0x182D17EB0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2D182F0", Offset = "0x2D176F0", VA = "0x182D182F0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2D17D70", Offset = "0x2D17170", VA = "0x182D17D70", Slot = "9")]
	public void Add(TKey KFLAFLPOCPA, TVal DOLIKBJJDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D17D10", Offset = "0x2D17110", VA = "0x182D17D10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MGCFLGFDJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2D17F10", Offset = "0x2D17310", VA = "0x182D17F10", Slot = "8")]
	public bool ContainsKey(TKey KFLAFLPOCPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2D17F40", Offset = "0x2D17340", VA = "0x182D17F40", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MGCFLGFDJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2D18240", Offset = "0x2D17640", VA = "0x182D18240", Slot = "10")]
	public bool Remove(TKey KFLAFLPOCPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2D18240", Offset = "0x2D17640", VA = "0x182D18240", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MGCFLGFDJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC6E0", Offset = "0x1EBBAE0", VA = "0x181EBC6E0", Slot = "11")]
	public bool TryGetValue(TKey KFLAFLPOCPA, out TVal DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2D18110", Offset = "0x2D17510", VA = "0x182D18110", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2D17FA0", Offset = "0x2D173A0", VA = "0x182D17FA0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HMDONCJONHL, int LKOKCHONCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2D18210", Offset = "0x2D17610", VA = "0x182D18210")]
	public bool PGFOGJEBOPM(TVal KFLAFLPOCPA, out TKey DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2D18000", Offset = "0x2D17400", VA = "0x182D18000")]
	private void GJLKNNNIHFM(TKey KFLAFLPOCPA, TVal NHMLFAJFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2D17DA0", Offset = "0x2D171A0", VA = "0x182D17DA0")]
	private void BBPDDEFIAIC(TKey KFLAFLPOCPA, TVal NHMLFAJFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2D17B90", Offset = "0x2D16F90", VA = "0x182D17B90")]
	private bool AEMODHHCGPE(TKey KFLAFLPOCPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2D18340", Offset = "0x2D17740", VA = "0x182D18340")]
	public IMAFLJACAOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class PLDIDJNDDGO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::PLDIDJNDDGO<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0xE1ADE0", Offset = "0xE1A1E0", VA = "0x180E1ADE0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1D00860", Offset = "0x1CFFC60", VA = "0x181D00860", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1D00D70", Offset = "0x1D00170", VA = "0x181D00D70")]
		public Enumerator(global::PLDIDJNDDGO<T> EGFOHHMMBPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1D005F0", Offset = "0x1CFF9F0", VA = "0x181D005F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1D00720", Offset = "0x1CFFB20", VA = "0x181D00720", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1D001C0", Offset = "0x1CFF5C0", VA = "0x181D001C0")]
		private void HKBBHBMIBJM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] OMDIPGLNFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int NHDEFBCIPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int PGALINJKGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int IEDEMIPOAGB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int OGGICMHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1D14710", Offset = "0x1D13B10", VA = "0x181D14710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T OGDAEEHFBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1D147D0", Offset = "0x1D13BD0", VA = "0x181D147D0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1D151E0", Offset = "0x1D145E0", VA = "0x181D151E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D159F0", Offset = "0x1D14DF0", VA = "0x181D159F0")]
	public PLDIDJNDDGO(int DGFCMKBONEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", VA = "0x181D14EC0")]
	public void HOKAIAEDNBH(T PHCIJGLCCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D15810", Offset = "0x1D14C10", VA = "0x181D15810")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1D152D0", Offset = "0x1D146D0", VA = "0x181D152D0")]
	public void JPIDABHKKEK(int LLIBIDENMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1D14A20", Offset = "0x1D13E20", VA = "0x181D14A20")]
	public void DNGIIPHJLHC(T[] HMDONCJONHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D157C0", Offset = "0x1D14BC0", VA = "0x181D157C0")]
	public Enumerator LECMODBKOJH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D158E0", Offset = "0x1D14CE0", VA = "0x181D158E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D158E0", Offset = "0x1D14CE0", VA = "0x181D158E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D15630", Offset = "0x1D14A30", VA = "0x181D15630")]
	private int KPGDOPJHELK(int LDIPPAHPHBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D15830", Offset = "0x1D14C30", VA = "0x181D15830")]
	private int OCKOJPCEKBK(int LDIPPAHPHBL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class GELOHKOJAJD
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
	protected GELOHKOJAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class EKAODCPPNDF<T> : GELOHKOJAJD
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct FBFOBFKGJLI
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum BDFCJNJNECA
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
		public BDFCJNJNECA KIIMCIKBPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T AHNIOOAKOAF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int LFBGFEFFFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool NALAPGOAAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool OFCLFAPLNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> LMBPJEPEOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<FBFOBFKGJLI> KFECLILIOPE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DNEMCENPOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2738CD0", Offset = "0x27380D0", VA = "0x182738CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2739400", Offset = "0x2738800", VA = "0x182739400")]
	protected EKAODCPPNDF(bool OFCLFAPLNAA, bool NALAPGOAAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2739360", Offset = "0x2738760", VA = "0x182739360")]
	protected bool PMLHECJNFHD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2739280", Offset = "0x2738680", VA = "0x182739280")]
	protected void NHEOGLAPGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2738D10", Offset = "0x2738110", VA = "0x182738D10")]
	protected void HMADIOEFFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1BDD7C0", Offset = "0x1BDCBC0", VA = "0x181BDD7C0")]
	private static void DCFGFPFCIFE<U>(ref List<U> NFLIKNKCKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2738EC0", Offset = "0x27382C0", VA = "0x182738EC0", Slot = "4")]
	public void HOKAIAEDNBH(T AHNIOOAKOAF, bool ILJKMJPFNBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2739010", Offset = "0x2738410", VA = "0x182739010", Slot = "5")]
	public void IBJELHEEHJF(T AHNIOOAKOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2739150", Offset = "0x2738550", VA = "0x182739150")]
	public void MEHOAGGHOJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class LGMCBKMFAFH : global::EKAODCPPNDF<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x43AF5B0", Offset = "0x43AE9B0", VA = "0x1843AF5B0")]
	public LGMCBKMFAFH(bool OFCLFAPLNAA = false, bool NALAPGOAAIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x43AF3A0", Offset = "0x43AE7A0", VA = "0x1843AF3A0")]
	public void LKMEDKMODLH()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x43AF550", Offset = "0x43AE950", VA = "0x1843AF550")]
	public static LGMCBKMFAFH PELPIAKGDIC(LGMCBKMFAFH ADIKKFMDNLJ, Action AHNIOOAKOAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x43AF340", Offset = "0x43AE740", VA = "0x1843AF340")]
	public static LGMCBKMFAFH KKEOIDHPHKK(LGMCBKMFAFH ADIKKFMDNLJ, Action AHNIOOAKOAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface ALCDOFBPPDK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HOKAIAEDNBH(Action<T> AHNIOOAKOAF, bool ILJKMJPFNBD = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBJELHEEHJF(Action<T> AHNIOOAKOAF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class LPGEMNIJNEI<T> : global::EKAODCPPNDF<Action<T>>, global::ALCDOFBPPDK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1D079E0", Offset = "0x1D06DE0", VA = "0x181D079E0")]
	public LPGEMNIJNEI(bool OFCLFAPLNAA = false, bool NALAPGOAAIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x34C59B0", Offset = "0x34C4DB0", VA = "0x1834C59B0")]
	public void LKMEDKMODLH(T PHCIJGLCCKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1D07940", Offset = "0x1D06D40", VA = "0x181D07940")]
	public static global::LPGEMNIJNEI<T> PELPIAKGDIC(global::LPGEMNIJNEI<T> ADIKKFMDNLJ, Action<T> AHNIOOAKOAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1D06C20", Offset = "0x1D06020", VA = "0x181D06C20")]
	public static global::LPGEMNIJNEI<T> KKEOIDHPHKK(global::LPGEMNIJNEI<T> ADIKKFMDNLJ, Action<T> AHNIOOAKOAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BMJCGEGLCLG<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class PIFPOGKHMJG<T, U> : global::EKAODCPPNDF<Action<T, U>>, global::BMJCGEGLCLG<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1D079E0", Offset = "0x1D06DE0", VA = "0x181D079E0")]
	public PIFPOGKHMJG(bool OFCLFAPLNAA = false, bool NALAPGOAAIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1F63860", Offset = "0x1F62C60", VA = "0x181F63860")]
	public void LKMEDKMODLH(T PHCIJGLCCKN, U PCJMOGNJMIG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1D07940", Offset = "0x1D06D40", VA = "0x181D07940")]
	public static global::PIFPOGKHMJG<T, U> PELPIAKGDIC(global::PIFPOGKHMJG<T, U> ADIKKFMDNLJ, Action<T, U> AHNIOOAKOAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1D06C20", Offset = "0x1D06020", VA = "0x181D06C20")]
	public static global::PIFPOGKHMJG<T, U> KKEOIDHPHKK(global::PIFPOGKHMJG<T, U> ADIKKFMDNLJ, Action<T, U> AHNIOOAKOAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class KJIOIGAIPEI<T, U, V> : global::EKAODCPPNDF<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1D079E0", Offset = "0x1D06DE0", VA = "0x181D079E0")]
	public KJIOIGAIPEI(bool OFCLFAPLNAA = false, bool NALAPGOAAIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3247050", Offset = "0x3246450", VA = "0x183247050")]
	public void LKMEDKMODLH(T PHCIJGLCCKN, U PCJMOGNJMIG, V LEHHBCDENEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1D07940", Offset = "0x1D06D40", VA = "0x181D07940")]
	public static global::KJIOIGAIPEI<T, U, V> PELPIAKGDIC(global::KJIOIGAIPEI<T, U, V> ADIKKFMDNLJ, Action<T, U, V> AHNIOOAKOAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1D06C20", Offset = "0x1D06020", VA = "0x181D06C20")]
	public static global::KJIOIGAIPEI<T, U, V> KKEOIDHPHKK(global::KJIOIGAIPEI<T, U, V> ADIKKFMDNLJ, Action<T, U, V> AHNIOOAKOAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MAEJIBGLBBP<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class CBCJHDPIGKE<T, U, V, W> : global::EKAODCPPNDF<Action<T, U, V, W>>, global::MAEJIBGLBBP<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1D079E0", Offset = "0x1D06DE0", VA = "0x181D079E0")]
	public CBCJHDPIGKE(bool OFCLFAPLNAA = false, bool NALAPGOAAIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x22AD8C0", Offset = "0x22ACCC0", VA = "0x1822AD8C0")]
	public void LKMEDKMODLH(T PHCIJGLCCKN, U PCJMOGNJMIG, V LEHHBCDENEO, W IBDFNBHFLMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D07940", Offset = "0x1D06D40", VA = "0x181D07940")]
	public static global::CBCJHDPIGKE<T, U, V, W> PELPIAKGDIC(global::CBCJHDPIGKE<T, U, V, W> ADIKKFMDNLJ, Action<T, U, V, W> AHNIOOAKOAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1D06C20", Offset = "0x1D06020", VA = "0x181D06C20")]
	public static global::CBCJHDPIGKE<T, U, V, W> KKEOIDHPHKK(global::CBCJHDPIGKE<T, U, V, W> ADIKKFMDNLJ, Action<T, U, V, W> AHNIOOAKOAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FAPNGCIMEAN<T, U, V, W, X> : global::EKAODCPPNDF<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1D079E0", Offset = "0x1D06DE0", VA = "0x181D079E0")]
	public FAPNGCIMEAN(bool OFCLFAPLNAA = false, bool NALAPGOAAIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3338320", Offset = "0x3337720", VA = "0x183338320")]
	public void LKMEDKMODLH(T PHCIJGLCCKN, U PCJMOGNJMIG, V LEHHBCDENEO, W IBDFNBHFLMJ, X FDNDJJDHFEF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1D07940", Offset = "0x1D06D40", VA = "0x181D07940")]
	public static global::FAPNGCIMEAN<T, U, V, W, X> PELPIAKGDIC(global::FAPNGCIMEAN<T, U, V, W, X> ADIKKFMDNLJ, Action<T, U, V, W, X> AHNIOOAKOAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1D06C20", Offset = "0x1D06020", VA = "0x181D06C20")]
	public static global::FAPNGCIMEAN<T, U, V, W, X> KKEOIDHPHKK(global::FAPNGCIMEAN<T, U, V, W, X> ADIKKFMDNLJ, Action<T, U, V, W, X> AHNIOOAKOAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class FAOACBJLEGM<T, U, V, W, X, Y> : global::EKAODCPPNDF<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1D079E0", Offset = "0x1D06DE0", VA = "0x181D079E0")]
	public FAOACBJLEGM(bool OFCLFAPLNAA = false, bool NALAPGOAAIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3337D10", Offset = "0x3337110", VA = "0x183337D10")]
	public void LKMEDKMODLH(T PHCIJGLCCKN, U PCJMOGNJMIG, V LEHHBCDENEO, W IBDFNBHFLMJ, X FDNDJJDHFEF, Y KILEPAPFHJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1D07940", Offset = "0x1D06D40", VA = "0x181D07940")]
	public static global::FAOACBJLEGM<T, U, V, W, X, Y> PELPIAKGDIC(global::FAOACBJLEGM<T, U, V, W, X, Y> ADIKKFMDNLJ, Action<T, U, V, W, X, Y> AHNIOOAKOAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1D06C20", Offset = "0x1D06020", VA = "0x181D06C20")]
	public static global::FAOACBJLEGM<T, U, V, W, X, Y> KKEOIDHPHKK(global::FAOACBJLEGM<T, U, V, W, X, Y> ADIKKFMDNLJ, Action<T, U, V, W, X, Y> AHNIOOAKOAF)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct KFANBDMJLOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class DCNHHHDNNPA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct BJAANPJMOEE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly global::DCNHHHDNNPA<T> DHOJJNGMFKM;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public T HDOIMHJBCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2DF92E0", Offset = "0x2DF86E0", VA = "0x182DF92E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2DF92B0", Offset = "0x2DF86B0", VA = "0x182DF92B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5B7790", Offset = "0x5B6B90", VA = "0x1805B7790")]
		public BJAANPJMOEE(global::DCNHHHDNNPA<T> DHOJJNGMFKM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim JEHCCBJLNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T BCBNMGIOOHP;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC1E0", Offset = "0x2DFB5E0", VA = "0x182DFC1E0")]
	public DCNHHHDNNPA(in T BCBNMGIOOHP, int PAOFNILNOHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC0D0", Offset = "0x2DFB4D0", VA = "0x182DFC0D0")]
	public DCNHHHDNNPA(in T BCBNMGIOOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC120", Offset = "0x2DFB520", VA = "0x182DFC120")]
	public BJAANPJMOEE NGOHCNJEOIK()
	{
		return default(BJAANPJMOEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NPKDLBJMLCD
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x43AF7B0", Offset = "0x43AEBB0", VA = "0x1843AF7B0")]
	public static global::DCNHHHDNNPA<KFANBDMJLOG> OHGMCKHNLGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1B4ACD0", Offset = "0x1B4A0D0", VA = "0x181B4ACD0")]
	public static global::DCNHHHDNNPA<T> OHGMCKHNLGP<T>(in T BCBNMGIOOHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FDFMBPIPKJB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate bool PGJKOJGLEKL(global::FDFMBPIPKJB<T> MLPEBCPBICD);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class JPJGGDDFMHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public global::FDFMBPIPKJB<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public JPJGGDDFMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x33443D0", Offset = "0x33437D0", VA = "0x1833443D0")]
		internal bool <FindNode>b__0(global::FDFMBPIPKJB<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public T PNIABOPNCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LinkedList<global::FDFMBPIPKJB<T>> CIMMODDOJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public global::FDFMBPIPKJB<T> EBDDNDJIAFF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::FDFMBPIPKJB<T> DAAAJNDLOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x50FA20", Offset = "0x50EE20", VA = "0x18050FA20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x33399A0", Offset = "0x3338DA0", VA = "0x1833399A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LJPNPELOJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x3339970", Offset = "0x3338D70", VA = "0x183339970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KJKGJFIOKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3339130", Offset = "0x3338530", VA = "0x183339130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::FDFMBPIPKJB<T> KJBHONODBAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3338D20", Offset = "0x3338120", VA = "0x183338D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x333AE70", Offset = "0x333A270", VA = "0x18333AE70")]
	public FDFMBPIPKJB(T OPNEKNIJBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x333A820", Offset = "0x3339C20", VA = "0x18333A820")]
	public global::FDFMBPIPKJB<T> LHEMAAAIPPO(T GHDCNKGJLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3338DA0", Offset = "0x33381A0", VA = "0x183338DA0")]
	public global::FDFMBPIPKJB<T> EKEDNHEIIPH(T PNPMCBCJMCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3339830", Offset = "0x3338C30", VA = "0x183339830")]
	public global::FDFMBPIPKJB<T> IBJELHEEHJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x333AB90", Offset = "0x3339F90", VA = "0x18333AB90")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3339BF0", Offset = "0x3338FF0", VA = "0x183339BF0")]
	public global::FDFMBPIPKJB<T> LAKAFHFDEFB(T JMAHIMONHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x33391B0", Offset = "0x33385B0", VA = "0x1833391B0")]
	public static void HMNPMGCOODB(global::FDFMBPIPKJB<T> EKMJNJOMBCC, PGJKOJGLEKL GPPHBFLLKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1BE2E60", Offset = "0x1BE2260", VA = "0x181BE2E60")]
	public static void HMNPMGCOODB<A>(global::FDFMBPIPKJB<T> EKMJNJOMBCC, Func<global::FDFMBPIPKJB<T>, A, bool> GPPHBFLLKKH, A KCKGMLPOMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x333A220", Offset = "0x3339620", VA = "0x18333A220")]
	public static string LCBAMFHJKOB(global::FDFMBPIPKJB<T> EKMJNJOMBCC, int PHKAHLBDNEB = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3338900", Offset = "0x3337D00", VA = "0x183338900")]
	public static global::FDFMBPIPKJB<T> CMLNECEKGPD(global::FDFMBPIPKJB<T> EKMJNJOMBCC, T MHDBALLCOBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class NDLJCBOPMFM<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate int GEIKDMKKBNF(TKey KFLAFLPOCPA, TVal DOLIKBJJDJE);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class BMPLEBNJJMK
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey EENGHLBINJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal HDOIMHJBCMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x64BF70", Offset = "0x64B370", VA = "0x18064BF70")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x682270", Offset = "0x681670", VA = "0x180682270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int CKGFJBIMIKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5C8730", Offset = "0x5C7B30", VA = "0x1805C8730")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C8760", Offset = "0x5C7B60", VA = "0x1805C8760")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime JDMDPIBGHDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4C1CF0", Offset = "0x4C10F0", VA = "0x1804C1CF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4E87D0", Offset = "0x4E7BD0", VA = "0x1804E87D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F76E20", Offset = "0x1F76220", VA = "0x181F76E20")]
		public BMPLEBNJJMK(TKey KFLAFLPOCPA, TVal NHMLFAJFKPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const int IOEICOIHKBN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Dictionary<TKey, LinkedListNode<BMPLEBNJJMK>> IKFMGDNONFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LinkedList<BMPLEBNJJMK> OLPJNDIFKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly GEIKDMKKBNF ABCHJNLDIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly TimeSpan BIIHPJAFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OKNDJJPELFP MDNMMLLCMGO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int AOHFOJBGHKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D1850", Offset = "0x5D0C50", VA = "0x1805D1850")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool HECFDGHCGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1F88440", Offset = "0x1F87840", VA = "0x181F88440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int GEEIAHGNNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D1860", Offset = "0x5D0C60", VA = "0x1805D1860")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C68B0", Offset = "0x5C5CB0", VA = "0x1805C68B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey OGDAEEHFBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1F88AE0", Offset = "0x1F87EE0", VA = "0x181F88AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2D38D40", Offset = "0x2D38140", VA = "0x182D38D40")]
	public NDLJCBOPMFM(int DGFCMKBONEM, [Optional] GEIKDMKKBNF ABCHJNLDIKJ, [Optional] IEqualityComparer<TKey> MLCNMKNJMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F88E70", Offset = "0x1F88270", VA = "0x181F88E70")]
	public NDLJCBOPMFM(int DGFCMKBONEM, GEIKDMKKBNF ABCHJNLDIKJ, TimeSpan BIIHPJAFJFM, [Optional] IEqualityComparer<TKey> MLCNMKNJMBJ, [Optional] OKNDJJPELFP MDNMMLLCMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F882E0", Offset = "0x1F876E0", VA = "0x181F882E0")]
	public void BHKHJMKKEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F88220", Offset = "0x1F87620", VA = "0x181F88220")]
	public void ANLMLKAMMDK(TKey KFLAFLPOCPA, TVal DOLIKBJJDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F88960", Offset = "0x1F87D60", VA = "0x181F88960")]
	public bool IBJELHEEHJF(TKey KFLAFLPOCPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2D38980", Offset = "0x2D37D80", VA = "0x182D38980")]
	public bool PGFOGJEBOPM(TKey KLBPKFDCHAB, out TVal DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F88BD0", Offset = "0x1F87FD0", VA = "0x181F88BD0")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F88B10", Offset = "0x1F87F10", VA = "0x181F88B10")]
	private bool LDCBNIMEMMM(BMPLEBNJJMK MCIPAAGGBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F884D0", Offset = "0x1F878D0", VA = "0x181F884D0")]
	private void GNMKJOILEIP(LinkedListNode<BMPLEBNJJMK> BHGKAAAAOIE, TVal KHKCPMEMGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F88750", Offset = "0x1F87B50", VA = "0x181F88750")]
	private void HNKGKMLJMNG(TKey KFLAFLPOCPA, TVal DOLIKBJJDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F88080", Offset = "0x1F87480", VA = "0x181F88080")]
	private void AADDABFEPJD(BMPLEBNJJMK MCIPAAGGBKH, TVal KHKCPMEMGPI, int OICJJIHKIMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class LLIHLDCJNPJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<T> NFLIKNKCKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private HashSet<T> EEPANEFKENH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OGGICMHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1879990", Offset = "0x1878D90", VA = "0x181879990", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool LGOOAHABKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE40", Offset = "0x4BF240", VA = "0x1804BFE40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T OGDAEEHFBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2CC71B0", Offset = "0x2CC65B0", VA = "0x182CC71B0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2CC72A0", Offset = "0x2CC66A0", VA = "0x182CC72A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1EB3E80", Offset = "0x1EB3280", VA = "0x181EB3E80", Slot = "11")]
	public void Add(T MGCFLGFDJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6CE0", Offset = "0x2CC60E0", VA = "0x182CC6CE0")]
	public bool LFANHNBBHLG(T MGCFLGFDJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2CC7060", Offset = "0x2CC6460", VA = "0x182CC7060", Slot = "15")]
	public bool Remove(T MGCFLGFDJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC630", Offset = "0x1EBBA30", VA = "0x181EBC630", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x24E8310", Offset = "0x24E7710", VA = "0x1824E8310", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6A60", Offset = "0x2CC5E60", VA = "0x182CC6A60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6AC0", Offset = "0x2CC5EC0", VA = "0x182CC6AC0", Slot = "13")]
	public bool Contains(T MGCFLGFDJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6AF0", Offset = "0x2CC5EF0", VA = "0x182CC6AF0", Slot = "14")]
	public void CopyTo(T[] HMDONCJONHL, int LKOKCHONCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6B20", Offset = "0x2CC5F20", VA = "0x182CC6B20", Slot = "6")]
	public int IndexOf(T MGCFLGFDJEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6B50", Offset = "0x2CC5F50", VA = "0x182CC6B50", Slot = "7")]
	public void Insert(int LDIPPAHPHBL, T MGCFLGFDJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6F00", Offset = "0x2CC6300", VA = "0x182CC6F00", Slot = "8")]
	public void RemoveAt(int LDIPPAHPHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2CC70E0", Offset = "0x2CC64E0", VA = "0x182CC70E0")]
	public LLIHLDCJNPJ()
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
			[Cpp2IlInjected.Address(RVA = "0x1C4D2A0", Offset = "0x1C4C6A0", VA = "0x181C4D2A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x43AFD90", Offset = "0x43AF190", VA = "0x1843AFD90")]
		public SerializedGuid(in Guid IEOJCFLLCMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x43AFBC0", Offset = "0x43AEFC0", VA = "0x1843AFBC0")]
		public static SerializedGuid JCILMIPFCHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x43AFB30", Offset = "0x43AEF30", VA = "0x1843AFB30")]
		public static SerializedGuid FEHFOPKBCMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x43AFC40", Offset = "0x43AF040", VA = "0x1843AFC40")]
		public bool LCADMFHNELH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x43AFD70", Offset = "0x43AF170", VA = "0x1843AFD70", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x43AFCD0", Offset = "0x43AF0D0", VA = "0x1843AFCD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x43AF9B0", Offset = "0x43AEDB0", VA = "0x1843AF9B0", Slot = "7")]
		public bool Equals(SerializedGuid DGBPCHLONNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x43AFA50", Offset = "0x43AEE50", VA = "0x1843AFA50", Slot = "0")]
		public override bool Equals(object JLOFPPFANIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x43AFBB0", Offset = "0x43AEFB0", VA = "0x1843AFBB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x43AF980", Offset = "0x43AED80", VA = "0x1843AF980", Slot = "6")]
		public int CompareTo(SerializedGuid DGBPCHLONNH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class DBIMDCKGJBB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Type AJKODLHCEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string MADHBBJBEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool NBNFALDGPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool JIIOGJBPKJI;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x43AE640", Offset = "0x43ADA40", VA = "0x1843AE640")]
	public DBIMDCKGJBB(Type LIOAPBPGOOD, string KPDEJDEDEGE, bool CBAEICCALPK = false, bool OIPHEIPBALB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface KLDCFOIMEHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T HDOIMHJBCMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool DLFLFMELJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::KLDCFOIMEHH<T> CJKOGBKMLIB(Action<T> CBGPPHDMNFM);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::KLDCFOIMEHH<T> AMPPACKIBGD(Action<T> CBGPPHDMNFM);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class ECBJHHCCMEG<T> : global::KLDCFOIMEHH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private global::PIFPOGKHMJG<T, T> MHFNBDKDEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private global::LPGEMNIJNEI<T> JDCNOKPHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private global::LPGEMNIJNEI<string> IEHCBNGLMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string NMLBEMGFEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private T LLLNMLKNOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool MPINKGGKKHM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T HDOIMHJBCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4E6670", Offset = "0x4E5A70", VA = "0x1804E6670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2484B30", Offset = "0x2483F30", VA = "0x182484B30", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DLFLFMELJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5C6690", Offset = "0x5C5A90", VA = "0x1805C6690", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2484B60", Offset = "0x2483F60", VA = "0x182484B60")]
	private void LCIBEMOONMF(T BOGLABLICIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2484AB0", Offset = "0x2483EB0", VA = "0x182484AB0", Slot = "4")]
	public global::KLDCFOIMEHH<T> CJKOGBKMLIB(Action<T> FFLPPAOKEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2484A80", Offset = "0x2483E80", VA = "0x182484A80", Slot = "5")]
	public global::KLDCFOIMEHH<T> AMPPACKIBGD(Action<T> CBGPPHDMNFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2484BE0", Offset = "0x2483FE0", VA = "0x182484BE0")]
	public ECBJHHCCMEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CPPLGKDMMOM
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class GJPFAHHIBKO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public global::KLDCFOIMEHH<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public global::EDILJINBHIG<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public GJPFAHHIBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x22BC110", Offset = "0x22BB510", VA = "0x1822BC110")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2121190", Offset = "0x2120590", VA = "0x182121190")]
	public static global::GMNMGKEAFFO<T> LNOGDFBDIKN<T>(this global::KLDCFOIMEHH<T> LHKCJBNEJMM, Action<T> KPMKLLFNKEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class OKNDJJPELFP
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class LLHJJDIJHLD : OKNDJJPELFP
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static OKNDJJPELFP HECCAOFHEAD
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x43AF610", Offset = "0x43AEA10", VA = "0x1843AF610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime JMLJMEAMMLP
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x43AF670", Offset = "0x43AEA70", VA = "0x1843AF670", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x43AF750", Offset = "0x43AEB50", VA = "0x1843AF750")]
		public LLHJJDIJHLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static OKNDJJPELFP PKAOKONAFEC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static OKNDJJPELFP IADOCOMMKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x43AF810", Offset = "0x43AEC10", VA = "0x1843AF810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime JMLJMEAMMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
	protected OKNDJJPELFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class IICOBIDCIKA : global::IKADBDNCHPH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x43AF250", Offset = "0x43AE650", VA = "0x1843AF250")]
	public IICOBIDCIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class IKADBDNCHPH<T> : global::AFFMJIGIHBN<T>, KFOPMLILOOB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> ILICPNIOPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::GMNMGKEAFFO<T> EPMHMIFPJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private BJPFHFGNMKO IPDIGIOBOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1871330", Offset = "0x1870730", VA = "0x181871330", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2D15B50", Offset = "0x2D14F50", VA = "0x182D15B50")]
	public IKADBDNCHPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class ILPLKEHILEH<T> : global::AFFMJIGIHBN<T>, KFOPMLILOOB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> ILICPNIOPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::GMNMGKEAFFO<T> EPMHMIFPJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private BJPFHFGNMKO IPDIGIOBOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1871330", Offset = "0x1870730", VA = "0x181871330", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2D17AA0", Offset = "0x2D16EA0", VA = "0x182D17AA0")]
	public ILPLKEHILEH(Exception MGJAPINLAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface KFOPMLILOOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	BJPFHFGNMKO EPMHMIFPJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AFFMJIGIHBN<T> : KFOPMLILOOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> ILICPNIOPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::GMNMGKEAFFO<T> EPMHMIFPJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class PPHLBDHICNG<TTask, T> : global::AFFMJIGIHBN<T>, KFOPMLILOOB, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class IEBIFPCBBIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public global::PPHLBDHICNG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public IEBIFPCBBIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NMNEFBDJGLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public IEBIFPCBBIA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		public NMNEFBDJGLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3436860", Offset = "0x3435C60", VA = "0x183436860")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static bool BPGBJDDOLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly global::EDILJINBHIG<T> OGOOLDMCPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Task<T> FDFEKEAFLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly CancellationTokenSource OPOBJOJHNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool AGCPBGAIDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private SynchronizationContext KPPCBLLBDGJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> ILICPNIOPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::GMNMGKEAFFO<T> EPMHMIFPJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private BJPFHFGNMKO IPDIGIOBOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BIGIELFBFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x582A20", Offset = "0x581E20", VA = "0x180582A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x343AEF0", Offset = "0x343A2F0", VA = "0x18343AEF0")]
	static PPHLBDHICNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x343B1D0", Offset = "0x343A5D0", VA = "0x18343B1D0")]
	protected PPHLBDHICNG(TTask FDFEKEAFLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x343AD40", Offset = "0x343A140", VA = "0x18343AD40", Slot = "1")]
	~PPHLBDHICNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x343AAB0", Offset = "0x3439EB0", VA = "0x18343AAB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x343A940", Offset = "0x3439D40", VA = "0x18343A940")]
	private void BBBKNPPFDNA(bool CAIJCNGPFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T ILDODCGJGPL(TTask AFBHMIKNOCI);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void ODOOEEONDPC();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x343ADE0", Offset = "0x343A1E0", VA = "0x18343ADE0")]
	protected void GHLAFKAMMHF(T BOGLABLICIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x343AAE0", Offset = "0x3439EE0", VA = "0x18343AAE0")]
	protected void EIHMMNDPKAC(string NMLBEMGFEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x343AB60", Offset = "0x3439F60", VA = "0x18343AB60")]
	[CompilerGenerated]
	private void FOGIFJDEFJB(object DGNKDAMICGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BFLJMJBCDHP<T> : IEnumerable<global::BFLJMJBCDHP<T>.BGGANHOBIJI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct BGGANHOBIJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public T DOLIKBJJDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int LDIPPAHPHBL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class LEKEDDLLHNB : IEnumerator<BGGANHOBIJI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private global::BFLJMJBCDHP<T> CBLFKCDCOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int LDIPPAHPHBL;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x2080CD0", Offset = "0x20800D0", VA = "0x182080CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public BGGANHOBIJI NDEAAMBEDFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x36D6120", Offset = "0x36D5520", VA = "0x1836D6120", Slot = "4")]
			get
			{
				return default(BGGANHOBIJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6E1730", Offset = "0x6E0B30", VA = "0x1806E1730")]
		public LEKEDDLLHNB(global::BFLJMJBCDHP<T> CBLFKCDCOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x36D6090", Offset = "0x36D5490", VA = "0x1836D6090", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x61F280", Offset = "0x61E680", VA = "0x18061F280", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x80C300", Offset = "0x80B700", VA = "0x18080C300", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct IMNJCFOPHJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool FAIMONCDNOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public T DOLIKBJJDJE;
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private const int PFHLIHGHHGK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<T, int> GFLHOEBGJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private IMNJCFOPHJJ[] GMJACKOAAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int IFEPLMIPNKM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OGGICMHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1EB18E0", Offset = "0x1EB0CE0", VA = "0x181EB18E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x36CCE30", Offset = "0x36CC230", VA = "0x1836CCE30")]
	public static global::BFLJMJBCDHP<T> FKGEKIAKOFO(BGGANHOBIJI[] IAGJFCOGDCJ, bool HLDLAPLDFED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x36CD560", Offset = "0x36CC960", VA = "0x1836CD560")]
	public BFLJMJBCDHP(int DGFCMKBONEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x36CD4A0", Offset = "0x36CC8A0", VA = "0x1836CD4A0")]
	public int NLODAHLIFLE(T DOLIKBJJDJE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x36CD430", Offset = "0x36CC830", VA = "0x1836CD430")]
	public T LNOGDFBDIKN(int LDIPPAHPHBL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x36CD410", Offset = "0x36CC810", VA = "0x1836CD410")]
	public bool LFANHNBBHLG(T DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x36CD240", Offset = "0x36CC640", VA = "0x1836CD240")]
	public bool LFANHNBBHLG(T DOLIKBJJDJE, int LDIPPAHPHBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x36CCCF0", Offset = "0x36CC0F0", VA = "0x1836CCCF0")]
	public BGGANHOBIJI[] DGHJBCKHJFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x36CD1F0", Offset = "0x36CC5F0", VA = "0x1836CD1F0")]
	private int JBHFGIONKHG(int NHDEFBCIPOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x36CD4F0", Offset = "0x36CC8F0", VA = "0x1836CD4F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x36CD4F0", Offset = "0x36CC8F0", VA = "0x1836CD4F0", Slot = "4")]
	private IEnumerator<BGGANHOBIJI> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class BLCEKKPFMPK<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private List<T> EPLJKOFBBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private List<T> FAKOFFEPAEP;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x36CE470", Offset = "0x36CD870", VA = "0x1836CE470")]
	public BLCEKKPFMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x36CE4A0", Offset = "0x36CD8A0", VA = "0x1836CE4A0")]
	public BLCEKKPFMPK(int DGFCMKBONEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x36CE250", Offset = "0x36CD650", VA = "0x1836CE250")]
	public T IFAJIIFODJJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x36CE350", Offset = "0x36CD750", VA = "0x1836CE350")]
	public void LACELBGICLN(T KHNDOFBHNJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class MEDEKEJLMLA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Dictionary<int, T> HOHOACLOALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private T GOCMKGJPKHB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual T PLDDJFOPAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4BF190", Offset = "0x4BE590", VA = "0x1804BF190", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4BF450", Offset = "0x4BE850", VA = "0x1804BF450", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D500", Offset = "0x1F7C900", VA = "0x181F7D500")]
	public bool HNKGKMLJMNG(T DOLIKBJJDJE, int NPHAFEPFAAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D4A0", Offset = "0x1F7C8A0", VA = "0x181F7D4A0")]
	public bool HJPMGANCLDO(int NPHAFEPFAAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D830", Offset = "0x1F7CC30", VA = "0x181F7D830")]
	public T MGPKKJKNODO(int AOBGMGGCPJP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D410", Offset = "0x1F7C810", VA = "0x181F7D410")]
	private bool HAFILKLLECB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DA90", Offset = "0x1F7CE90", VA = "0x181F7DA90")]
	public bool PGFOGJEBOPM(int NPHAFEPFAAD, out T DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DAC0", Offset = "0x1F7CEC0", VA = "0x181F7DAC0")]
	public MEDEKEJLMLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class BCKJKOEBBAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	protected struct OKCCPDNGEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public T HDOIMHJBCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int JLBCFOANFBN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	protected readonly List<OKCCPDNGEOP> OMDIPGLNFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private T LCMOBJPCDPB;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int OGGICMHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1879990", Offset = "0x1878D90", VA = "0x181879990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1EBCC70", Offset = "0x1EBC070", VA = "0x181EBCC70")]
	public bool LJGFFNACIAD(T DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC830", Offset = "0x1EBBC30", VA = "0x181EBC830")]
	public void HOKAIAEDNBH(T DOLIKBJJDJE, int NPHAFEPFAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC8B0", Offset = "0x1EBBCB0", VA = "0x181EBC8B0")]
	public bool IBJELHEEHJF(T DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1EBCEC0", Offset = "0x1EBC2C0", VA = "0x181EBCEC0")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1EBCBE0", Offset = "0x1EBBFE0", VA = "0x181EBCBE0")]
	public T KHCBHHOOKLB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1EBC9D0", Offset = "0x1EBBDD0", VA = "0x181EBC9D0")]
	private void KFGJEDKAFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1EBCF20", Offset = "0x1EBC320", VA = "0x181EBCF20")]
	public BCKJKOEBBAO()
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
		[Cpp2IlInjected.Address(RVA = "0x1884040", Offset = "0x1883440", VA = "0x181884040", Slot = "4")]
		public virtual T OOEFMPMGLCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x18717E0", Offset = "0x1870BE0", VA = "0x1818717E0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class AOIBJMMPOHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly Dictionary<byte, HABAAEFGFNA> MLNMNPKPGIH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public HABAAEFGFNA LCFEGJOMAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4BF1A0", Offset = "0x4BE5A0", VA = "0x1804BF1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4BF440", Offset = "0x4BE840", VA = "0x1804BF440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Vector2 CLDNGFCKHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x10916B0", Offset = "0x1090AB0", VA = "0x1810916B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x1EBA7A0", Offset = "0x1EB9BA0", VA = "0x181EBA7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector2 HHPKIEAHCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1053B70", Offset = "0x1052F70", VA = "0x181053B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Vector2 FKNBBCMJDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3108F80", Offset = "0x3108380", VA = "0x183108F80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3108FA0", Offset = "0x31083A0", VA = "0x183108FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int BJDFEPLPEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x4E91B0", Offset = "0x4E85B0", VA = "0x1804E91B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x50E360", Offset = "0x50D760", VA = "0x18050E360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x43ADE50", Offset = "0x43AD250", VA = "0x1843ADE50")]
	public AOIBJMMPOHM(Bounds PKDLACJFIAB, Vector2[] PLKIGDILFDI, int ANGJEODPFGN, byte NHDEFBCIPOC, float MFBAOMPJPNA = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x43ADBD0", Offset = "0x43ACFD0", VA = "0x1843ADBD0")]
	public HABAAEFGFNA DBHGFJLFHKD(byte LDIPPAHPHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x43ADC50", Offset = "0x43AD050", VA = "0x1843ADC50")]
	public void OIEDOKPLIMB(Vector3 LADGHIOFKNM, float HGLNJMEECLL, float PPKDMAJJBKN, ref List<byte> DMOIPOPEKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x43ADC30", Offset = "0x43AD030", VA = "0x1843ADC30")]
	public void ENHFBEHLOPH(HABAAEFGFNA.KFJNKOLLAAJ NJFIPDBHNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x43ADD30", Offset = "0x43AD130", VA = "0x1843ADD30")]
	private HABAAEFGFNA PDECFKAOAAG(byte LDIPPAHPHBL, HABAAEFGFNA.ALCGPNDOHJC DNJOKLIJLPG, HABAAEFGFNA JFPEDHFGIID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x43AD6B0", Offset = "0x43ACAB0", VA = "0x1843AD6B0")]
	private void BIFMFJFONON(HABAAEFGFNA JFPEDHFGIID, Vector2[] PLKIGDILFDI, int BHPBIDPAAHB, int ABFCLKAADGB, int EMNBAIBHGNE, int CPIBIALEKAO, float MFBAOMPJPNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class HABAAEFGFNA
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum ALCGPNDOHJC
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum KFJNKOLLAAJ
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
	public byte NFEIDLAPGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Vector3 HDKNFHPNBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Vector3 CKGFJBIMIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Vector3 FNMPLDMLNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Vector3 OINABLIBFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public ALCGPNDOHJC HADEEHJGMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public HABAAEFGFNA DAAAJNDLOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public List<HABAAEFGFNA> IBKDIGFMCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public bool MIFJKLAFHOK;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x43AF200", Offset = "0x43AE600", VA = "0x1843AF200")]
	public HABAAEFGFNA(byte GABNOGEDINC, ALCGPNDOHJC DNJOKLIJLPG, HABAAEFGFNA JFPEDHFGIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x43AEE80", Offset = "0x43AE280", VA = "0x1843AEE80")]
	public void LHEMAAAIPPO(HABAAEFGFNA HFAKECJAGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00")]
	public void ENHFBEHLOPH(int EBKHMNOGAGN, KFJNKOLLAAJ NJFIPDBHNBP, int JMJOBPIBEKF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x43AEF70", Offset = "0x43AE370", VA = "0x1843AEF70")]
	public void OIEDOKPLIMB(List<byte> DMOIPOPEKON, Vector3 LADGHIOFKNM, float HGLNJMEECLL, float PPKDMAJJBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x43AEF10", Offset = "0x43AE310", VA = "0x1843AEF10")]
	public bool LLJOFNBGFLE(Vector3 AALDEJJMJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x43AEE40", Offset = "0x43AE240", VA = "0x1843AEE40")]
	public bool IHLDIFDDGNM(Vector3 AALDEJJMJCE, float FDMLIAHKNEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class MPBMOPMNPNP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int DGFCMKBONEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private int MCDEGMMNPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private List<T> BHNDFBGJOPJ;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T AIFGDMDLFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x1F842F0", Offset = "0x1F836F0", VA = "0x181F842F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T HDLNAPDPIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1F83EA0", Offset = "0x1F832A0", VA = "0x181F83EA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T JPKMJPPOMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1F84230", Offset = "0x1F83630", VA = "0x181F84230")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1F84450", Offset = "0x1F83850", VA = "0x181F84450")]
	public MPBMOPMNPNP(int DGFCMKBONEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1F83FB0", Offset = "0x1F833B0", VA = "0x181F83FB0")]
	public void HOKAIAEDNBH(T CLGENMAKILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1F84410", Offset = "0x1F83810", VA = "0x181F84410")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1F83F50", Offset = "0x1F83350", VA = "0x181F83F50")]
	public void BDMNOLPCOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1F83FA0", Offset = "0x1F833A0", VA = "0x181F83FA0")]
	public void EAGBHICKPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class AMFEDMEMCGE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct MGCFDFICCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int JLBCFOANFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public T HDOIMHJBCMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Dictionary<object, MGCFDFICCIB> HOHOACLOALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private T GOCMKGJPKHB;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T PLDDJFOPAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x10916B0", Offset = "0x1090AB0", VA = "0x1810916B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1EBA7A0", Offset = "0x1EB9BA0", VA = "0x181EBA7A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool PBGDHMKFGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1EBA7C0", Offset = "0x1EB9BC0", VA = "0x181EBA7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public object FIMNKMAEHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4C1CF0", Offset = "0x4C10F0", VA = "0x1804C1CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4E87D0", Offset = "0x4E7BD0", VA = "0x1804E87D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA690", Offset = "0x1EB9A90", VA = "0x181EBA690")]
	public bool HNKGKMLJMNG(T DOLIKBJJDJE, object BHIHAMFNBEN, int NPHAFEPFAAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1EB9F70", Offset = "0x1EB9370", VA = "0x181EB9F70")]
	public bool HJPMGANCLDO(object BHIHAMFNBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBAB00", Offset = "0x1EB9F00", VA = "0x181EBAB00")]
	public bool PGFOGJEBOPM(object BHIHAMFNBEN, out T DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA710", Offset = "0x1EB9B10", VA = "0x181EBA710")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x1EB59B0", Offset = "0x1EB4DB0", VA = "0x181EB59B0")]
	private bool HAFILKLLECB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1EBAD80", Offset = "0x1EBA180", VA = "0x181EBAD80")]
	public AMFEDMEMCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class COOHNBPGFCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Dictionary<object, float> HOHOACLOALI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float PGKIBDEBGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB8ABE0", Offset = "0xB89FE0", VA = "0x180B8ABE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAAFE30", Offset = "0xAAF230", VA = "0x180AAFE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x43AE400", Offset = "0x43AD800", VA = "0x1843AE400")]
	public void HNKGKMLJMNG(float DOLIKBJJDJE, object BHIHAMFNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x43AE390", Offset = "0x43AD790", VA = "0x1843AE390")]
	public void HJPMGANCLDO(object BHIHAMFNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x43AE470", Offset = "0x43AD870", VA = "0x1843AE470")]
	private void PNCDEFIBGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x43AE590", Offset = "0x43AD990", VA = "0x1843AE590")]
	public COOHNBPGFCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class EDMLKNPOMDN
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class BBBKJLGNLEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly string KHBOKKKEEDH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		private BBBKJLGNLEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5ABD10", Offset = "0x5AB110", VA = "0x1805ABD10")]
		public BBBKJLGNLEP(string KHBOKKKEEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x43AE340", Offset = "0x43AD740", VA = "0x1843AE340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JMLJKJJDMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
		public JMLJKJJDMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x43AF290", Offset = "0x43AE690", VA = "0x1843AF290")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HashSet<object> NGKNAHIBILL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool NPOBOFIHMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x43AE970", Offset = "0x43ADD70", VA = "0x1843AE970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int OGGICMHADKF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x43AE930", Offset = "0x43ADD30", VA = "0x1843AE930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x43AE9B0", Offset = "0x43ADDB0", VA = "0x1843AE9B0")]
	public bool HOKAIAEDNBH(object BHIHAMFNBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x43AEA60", Offset = "0x43ADE60", VA = "0x1843AEA60")]
	public bool IBJELHEEHJF(object BHIHAMFNBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x43AEB60", Offset = "0x43ADF60", VA = "0x1843AEB60")]
	public bool LJGFFNACIAD(object BHIHAMFNBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x43AEB10", Offset = "0x43ADF10", VA = "0x1843AEB10")]
	public void IMONCDJPGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x43AEBC0", Offset = "0x43ADFC0", VA = "0x1843AEBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x43AED20", Offset = "0x43AE120", VA = "0x1843AED20")]
	public EDMLKNPOMDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class OJMDLALPOJE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private struct HBNCFEOPCHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public float CNEDJKMEOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public T HDOIMHJBCMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Dictionary<object, HBNCFEOPCHE> HOHOACLOALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private T AAIIDEKCDID;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public virtual T KKMFCLBJKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xD983A0", Offset = "0xD977A0", VA = "0x180D983A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1EBA770", Offset = "0x1EB9B70", VA = "0x181EBA770", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public object ABBBNHCMOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4E6670", Offset = "0x4E5A70", VA = "0x1804E6670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDD0", Offset = "0x5AE1D0", VA = "0x1805AEDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool PBGDHMKFGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x1F53330", Offset = "0x1F52730", VA = "0x181F53330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1F52F20", Offset = "0x1F52320", VA = "0x181F52F20")]
	public bool HNKGKMLJMNG(T DOLIKBJJDJE, object BHIHAMFNBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1F52DF0", Offset = "0x1F521F0", VA = "0x181F52DF0")]
	public bool HJPMGANCLDO(object BHIHAMFNBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA710", Offset = "0x1EB9B10", VA = "0x181EBA710")]
	public void MEHOAGGHOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x24F0890", Offset = "0x24EFC90", VA = "0x1824F0890")]
	public bool PGFOGJEBOPM(object BHIHAMFNBEN, out T DOLIKBJJDJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x24F0240", Offset = "0x24EF640", VA = "0x1824F0240")]
	private bool HAFILKLLECB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F53590", Offset = "0x1F52990", VA = "0x181F53590")]
	public OJMDLALPOJE()
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
