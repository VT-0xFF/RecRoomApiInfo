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
public class CCDEDOLONAE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5424C0", Offset = "0x5414C0", VA = "0x1805424C0")]
	public CCDEDOLONAE()
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
		[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x428E60", Offset = "0x427E60", VA = "0x180428E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x428450", Offset = "0x427450", VA = "0x180428450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "4")]
	public virtual void HLPBPPGBJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
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
	[CCDEDOLONAE]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B8F0", Offset = "0x2D0A8F0", VA = "0x182D0B8F0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B430", Offset = "0x2D0A430", VA = "0x182D0B430", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2D0BEF0", Offset = "0x2D0AEF0", VA = "0x182D0BEF0")]
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
	private sealed class PNJMCBOJNKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public PNJMCBOJNKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2080370", Offset = "0x207F370", VA = "0x182080370")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[CCDEDOLONAE]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x207A930", Offset = "0x2079930", VA = "0x18207A930", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x207A960", Offset = "0x2079960", VA = "0x18207A960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x207A880", Offset = "0x2079880", VA = "0x18207A880", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey FNHMPFHLGJM]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x207A8B0", Offset = "0x20798B0", VA = "0x18207A8B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x207A790", Offset = "0x2079790", VA = "0x18207A790", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x207A000", Offset = "0x2079000", VA = "0x18207A000", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2079970", Offset = "0x2078970", VA = "0x182079970", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x20795D0", Offset = "0x20785D0", VA = "0x1820795D0", Slot = "14")]
	protected virtual string KLFFOEOKGKO(TKeyVal NDGFLDGNBAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F3F020", Offset = "0x1F3E020", VA = "0x181F3F020", Slot = "4")]
	public bool ContainsKey(TKey FNHMPFHLGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x207A690", Offset = "0x2079690", VA = "0x18207A690", Slot = "5")]
	public bool TryGetValue(TKey FNHMPFHLGJM, out TVal DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20794E0", Offset = "0x20784E0", VA = "0x1820794E0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x20794E0", Offset = "0x20784E0", VA = "0x1820794E0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x207A6C0", Offset = "0x20796C0", VA = "0x18207A6C0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CGMAMLOLPOF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ODBHMFNANAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public ODBHMFNANAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FB10", Offset = "0x1F3EB10", VA = "0x181F3FB10")]
		internal bool <GetSamples>b__0(global::JBEDGAJIMHP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float NMHILIDABBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float BJNDFBOOLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::JBEDGAJIMHP<float, T>> KMBOOMFOJFJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int AONJPJMKKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F368E0", Offset = "0x1F358E0", VA = "0x181F368E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1F369E0", Offset = "0x1F359E0", VA = "0x181F369E0")]
	public CGMAMLOLPOF(float CHCGELCKJDE, float LLEGJDMBJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1F366C0", Offset = "0x1F356C0", VA = "0x181F366C0")]
	public bool ENIGIFDLAII(float MONEJMHANCI, T DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1F36230", Offset = "0x1F35230", VA = "0x181F36230")]
	public IEnumerable<T> EIMEEAIPNHO(float MONEJMHANCI, [Optional] float? AFIPGOCNFBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1F35ED0", Offset = "0x1F34ED0", VA = "0x181F35ED0")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1F36820", Offset = "0x1F35820", VA = "0x181F36820")]
	private void HHAMBKJIBDF(float MONEJMHANCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class CIIMFGDFNAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MDFIJNIKDKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T MJMAKEDLBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float NNDDCENAGCE;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float EHCHABNMEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> ODPGBADDBEP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int LCNAKLJGIGC = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MDFIJNIKDKL[] HDKKHNDIOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int ICHIGGGAAFE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float DKBDILJNLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD543D0", Offset = "0xD533D0", VA = "0x180D543D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xC346C0", Offset = "0xC336C0", VA = "0x180C346C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2985E80", Offset = "0x2984E80", VA = "0x182985E80")]
	public CIIMFGDFNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2985EB0", Offset = "0x2984EB0", VA = "0x182985EB0")]
	public CIIMFGDFNAI(int JMGGFMEEKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29856A0", Offset = "0x29846A0", VA = "0x1829856A0")]
	public void KGODAIEOADL(float MONEJMHANCI, T DAPPHEJJLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2984FE0", Offset = "0x2983FE0", VA = "0x182984FE0")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2985990", Offset = "0x2984990", VA = "0x182985990")]
	public bool KLOABPCEGJD(float LHGOELFJINM, float OPKKIKPOIHD, out T DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29852B0", Offset = "0x29842B0", VA = "0x1829852B0")]
	public bool JIEIJJIOJGM(float LHGOELFJINM, float OPKKIKPOIHD, out T DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2985CE0", Offset = "0x2984CE0", VA = "0x182985CE0")]
	public void OEGGNFJDLHN(float LHGOELFJINM, float OPKKIKPOIHD, List<T> NDLNEAFOOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2985280", Offset = "0x2984280", VA = "0x182985280")]
	private int CJPIICJHFIO(int BCNDPNIIDIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2985B40", Offset = "0x2984B40", VA = "0x182985B40")]
	private void MIHOPBKLMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MIEHDBPCKFL();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MMGOLKLBLKM(T DAPPHEJJLEB, float FKCKCIEHDDN);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GNBNLPMPMBD(T GKKJAOAKBGM, T OPOBDFLPDDC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OALHCAPMFPA(T GKKJAOAKBGM, T OPOBDFLPDDC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NKANIOBCEFK : global::CIIMFGDFNAI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C540", Offset = "0x3D6B540", VA = "0x183D6C540", Slot = "4")]
	protected override Vector3 MIEHDBPCKFL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C5B0", Offset = "0x3D6B5B0", VA = "0x183D6C5B0", Slot = "5")]
	protected override Vector3 MMGOLKLBLKM(Vector3 DAPPHEJJLEB, float FKCKCIEHDDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C490", Offset = "0x3D6B490", VA = "0x183D6C490", Slot = "6")]
	protected override Vector3 GNBNLPMPMBD(Vector3 GKKJAOAKBGM, Vector3 OPOBDFLPDDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C650", Offset = "0x3D6B650", VA = "0x183D6C650", Slot = "7")]
	protected override Vector3 OALHCAPMFPA(Vector3 GKKJAOAKBGM, Vector3 OPOBDFLPDDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C6C0", Offset = "0x3D6B6C0", VA = "0x183D6C6C0")]
	public NKANIOBCEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class AKJLNOPBBHB
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3420", Offset = "0x1CB2420", VA = "0x181CB3420")]
	public static global::JBEDGAJIMHP<T1, T2> FIOHCBANLKE<T1, T2>(T1 DDEBAKMKACJ, T2 PFPGAAJEIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CB3490", Offset = "0x1CB2490", VA = "0x181CB3490")]
	public static global::FGNBLLKBNJG<T1, T2, T3> FIOHCBANLKE<T1, T2, T3>(T1 DDEBAKMKACJ, T2 PFPGAAJEIGO, T3 AEBCPADGJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C8BCD0", Offset = "0x2C8ACD0", VA = "0x182C8BCD0")]
	internal static int LAFOPMGJLHL(int LAMGEEIABBK, int FJBFBNLPMLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x38E7510", Offset = "0x38E6510", VA = "0x1838E7510")]
	internal static int LAFOPMGJLHL(int LAMGEEIABBK, int FJBFBNLPMLM, int CHHOHCFLEIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JBEDGAJIMHP<T1, T2> : IComparable<global::JBEDGAJIMHP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 KHIDKFCIFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 LAIDFMOLAGD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1BFAEA0", Offset = "0x1BF9EA0", VA = "0x181BFAEA0")]
	public JBEDGAJIMHP(T1 DDEBAKMKACJ, T2 PFPGAAJEIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1BF9740", Offset = "0x1BF8740", VA = "0x181BF9740", Slot = "4")]
	public int CompareTo(global::JBEDGAJIMHP<T1, T2> AIJMKPMALLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1BFA040", Offset = "0x1BF9040", VA = "0x181BFA040", Slot = "0")]
	public override bool Equals(object AIJMKPMALLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1BFA4D0", Offset = "0x1BF94D0", VA = "0x181BFA4D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1BFAA00", Offset = "0x1BF9A00", VA = "0x181BFAA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FGNBLLKBNJG<T1, T2, T3> : IComparable<global::FGNBLLKBNJG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 KHIDKFCIFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 LAIDFMOLAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 IOMFADBBFPD;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2E50740", Offset = "0x2E4F740", VA = "0x182E50740")]
	public FGNBLLKBNJG(T1 DDEBAKMKACJ, T2 PFPGAAJEIGO, T3 AEBCPADGJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2E50060", Offset = "0x2E4F060", VA = "0x182E50060", Slot = "4")]
	public int CompareTo(global::FGNBLLKBNJG<T1, T2, T3> AIJMKPMALLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2E50250", Offset = "0x2E4F250", VA = "0x182E50250", Slot = "0")]
	public override bool Equals(object AIJMKPMALLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2E503C0", Offset = "0x2E4F3C0", VA = "0x182E503C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2E504C0", Offset = "0x2E4F4C0", VA = "0x182E504C0", Slot = "3")]
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
	public T MJMAKEDLBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x44F670", Offset = "0x44E670", VA = "0x18044F670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x517DD0", Offset = "0x516DD0", VA = "0x180517DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float JEEDFPICGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xBA3AE0", Offset = "0xBA2AE0", VA = "0x180BA3AE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2F369C0", Offset = "0x2F359C0", VA = "0x182F369C0")]
	public T LFEGHDFFOCL(float FKCKCIEHDDN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2F36760", Offset = "0x2F35760", VA = "0x182F36760")]
	public T ENDFGJHDFAK(float FKCKCIEHDDN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BKFNFCBAKEE(T GKKJAOAKBGM, T OPOBDFLPDDC, float FKCKCIEHDDN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D6BD00", Offset = "0x3D6AD00", VA = "0x183D6BD00", Slot = "4")]
	protected override float BKFNFCBAKEE(float GKKJAOAKBGM, float OPOBDFLPDDC, float FKCKCIEHDDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3D6BD80", Offset = "0x3D6AD80", VA = "0x183D6BD80")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D6CB60", Offset = "0x3D6BB60", VA = "0x183D6CB60", Slot = "4")]
	protected override Vector3 BKFNFCBAKEE(Vector3 GKKJAOAKBGM, Vector3 OPOBDFLPDDC, float FKCKCIEHDDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D6CC20", Offset = "0x3D6BC20", VA = "0x183D6CC20")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D51070", Offset = "0x3D50070", VA = "0x183D51070", Slot = "4")]
	protected override Color BKFNFCBAKEE(Color GKKJAOAKBGM, Color OPOBDFLPDDC, float FKCKCIEHDDN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AC20", Offset = "0x3D69C20", VA = "0x183D6AC20")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class OBBLPFJCNCD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> IIGFIAMNJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> JGOFPHGMDPB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DINAJDNNPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1B08E10", Offset = "0x1B07E10", VA = "0x181B08E10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NIFICALGCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x428E40", Offset = "0x427E40", VA = "0x180428E40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> LMFPANKGGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1C01A60", Offset = "0x1C00A60", VA = "0x181C01A60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> JGGMKPOCLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1C036E0", Offset = "0x1C026E0", VA = "0x181C036E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal IANIKNGKGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1B08750", Offset = "0x1B07750", VA = "0x181B08750", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2A2F170", Offset = "0x2A2E170", VA = "0x182A2F170", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EB50", Offset = "0x2A2DB50", VA = "0x182A2EB50", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EFD0", Offset = "0x2A2DFD0", VA = "0x182A2EFD0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E9A0", Offset = "0x2A2D9A0", VA = "0x182A2E9A0", Slot = "9")]
	public void Add(TKey FNHMPFHLGJM, TVal DAPPHEJJLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E970", Offset = "0x2A2D970", VA = "0x182A2E970", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PJMKALJFKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EBB0", Offset = "0x2A2DBB0", VA = "0x182A2EBB0", Slot = "8")]
	public bool ContainsKey(TKey FNHMPFHLGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EBE0", Offset = "0x2A2DBE0", VA = "0x182A2EBE0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> PJMKALJFKLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EF70", Offset = "0x2A2DF70", VA = "0x182A2EF70", Slot = "10")]
	public bool Remove(TKey FNHMPFHLGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EF70", Offset = "0x2A2DF70", VA = "0x182A2EF70", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> PJMKALJFKLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F070", Offset = "0x2A2E070", VA = "0x182A2F070", Slot = "11")]
	public bool TryGetValue(TKey FNHMPFHLGJM, out TVal DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2A2ECA0", Offset = "0x2A2DCA0", VA = "0x182A2ECA0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EC40", Offset = "0x2A2DC40", VA = "0x182A2EC40", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HDKKHNDIOBM, int BBFDPANNOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2A2ED20", Offset = "0x2A2DD20", VA = "0x182A2ED20")]
	public bool IKDFAGNOIFG(TVal FNHMPFHLGJM, out TKey DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EE60", Offset = "0x2A2DE60", VA = "0x182A2EE60")]
	private void OBBHKHDCLLH(TKey FNHMPFHLGJM, TVal CIIDGEOMGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2A2EDE0", Offset = "0x2A2DDE0", VA = "0x182A2EDE0")]
	private void LNHAJLNPBHJ(TKey FNHMPFHLGJM, TVal CIIDGEOMGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E9D0", Offset = "0x2A2D9D0", VA = "0x182A2E9D0")]
	private bool COHHNHHOGHA(TKey FNHMPFHLGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2F0A0", Offset = "0x2A2E0A0", VA = "0x182A2F0A0")]
	public OBBLPFJCNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class GIAKCAKFMLK<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::GIAKCAKFMLK<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0xD543D0", Offset = "0xD533D0", VA = "0x180D543D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1F9DED0", Offset = "0x1F9CED0", VA = "0x181F9DED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E290", Offset = "0x1F9D290", VA = "0x181F9E290")]
		public Enumerator(global::GIAKCAKFMLK<T> NDLNEAFOOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D760", Offset = "0x1F9C760", VA = "0x181F9D760", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F9DC40", Offset = "0x1F9CC40", VA = "0x181F9DC40", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1F9D560", Offset = "0x1F9C560", VA = "0x181F9D560")]
		private void DAHADIMBKBD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] JGDKKOFPFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int JNNCFGOKOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int PJLFCINGKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int CGMBLHAMNGM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int DINAJDNNPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1EE0", Offset = "0x1FA0EE0", VA = "0x181FA1EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T IANIKNGKGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2560", Offset = "0x1FA1560", VA = "0x181FA2560")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2B70", Offset = "0x1FA1B70", VA = "0x181FA2B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2D70", Offset = "0x1FA1D70", VA = "0x181FA2D70")]
	public GIAKCAKFMLK(int FLHMGHOMCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA26F0", Offset = "0x1FA16F0", VA = "0x181FA26F0")]
	public void KGODAIEOADL(T FKCKCIEHDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2460", Offset = "0x1FA1460", VA = "0x181FA2460")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1A90", Offset = "0x1FA0A90", VA = "0x181FA1A90")]
	public void AOKBAPNHMNH(int EBJHAIHBKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1FA21C0", Offset = "0x1FA11C0", VA = "0x181FA21C0")]
	public void CBODMMFABBG(T[] HDKKHNDIOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2910", Offset = "0x1FA1910", VA = "0x181FA2910")]
	public Enumerator LBAILFKCPJG()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2C70", Offset = "0x1FA1C70", VA = "0x181FA2C70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2C70", Offset = "0x1FA1C70", VA = "0x181FA2C70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1DF0", Offset = "0x1FA0DF0", VA = "0x181FA1DF0")]
	private int BAICDGKMBPI(int JPADDGNBPOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2480", Offset = "0x1FA1480", VA = "0x181FA2480")]
	private int EEOFJPJLJOJ(int JPADDGNBPOA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class FIMMLICPGOB
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
	protected FIMMLICPGOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class LFJAOBMHMDH<T> : FIMMLICPGOB
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct HKLIFDAOBBD
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum GGJOLKCFDBA
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
		public GGJOLKCFDBA OGJIHDMNCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T HMDBAELNEEE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int NLBPNIIINOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool EAAINPEDCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool HKOMFNEMPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> IEOKDCBKOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<HKLIFDAOBBD> HGMLCCKOOGF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PJIHOIIBOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1D93D00", Offset = "0x1D92D00", VA = "0x181D93D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D94150", Offset = "0x1D93150", VA = "0x181D94150")]
	protected LFJAOBMHMDH(bool HKOMFNEMPED, bool EAAINPEDCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D93E80", Offset = "0x1D92E80", VA = "0x181D93E80")]
	protected bool GNEGAACOKJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D93F20", Offset = "0x1D92F20", VA = "0x181D93F20")]
	protected void IEBEPMIHBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D93A20", Offset = "0x1D92A20", VA = "0x181D93A20")]
	protected void BIMDDMDFMDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C860", Offset = "0x1C0B860", VA = "0x181C0C860")]
	private static void MCKCOHPLPOL<U>(ref List<U> KFCDAMJPHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1D94000", Offset = "0x1D93000", VA = "0x181D94000", Slot = "4")]
	public void KGODAIEOADL(T HMDBAELNEEE, bool CJJMJGPFPBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1D93D40", Offset = "0x1D92D40", VA = "0x181D93D40", Slot = "5")]
	public void DFMMJKLLKMC(T HMDBAELNEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1D93BD0", Offset = "0x1D92BD0", VA = "0x181D93BD0")]
	public void CIIJOJFGHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class IDIKKKGOEOH : global::LFJAOBMHMDH<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C1F0", Offset = "0x3D6B1F0", VA = "0x183D6C1F0")]
	public IDIKKKGOEOH(bool HKOMFNEMPED = false, bool EAAINPEDCHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C040", Offset = "0x3D6B040", VA = "0x183D6C040")]
	public void MMJDKDNGBNI()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D6BFE0", Offset = "0x3D6AFE0", VA = "0x183D6BFE0")]
	public static IDIKKKGOEOH KGPCDFLIDLC(IDIKKKGOEOH MAFDMOHIMBN, Action HMDBAELNEEE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3D6BF80", Offset = "0x3D6AF80", VA = "0x183D6BF80")]
	public static IDIKKKGOEOH FCHOKIPJENF(IDIKKKGOEOH MAFDMOHIMBN, Action HMDBAELNEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MMIKEHEKIDL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGODAIEOADL(Action<T> HMDBAELNEEE, bool CJJMJGPFPBF = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFMMJKLLKMC(Action<T> HMDBAELNEEE);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class GEJNJACEKKG<T> : global::LFJAOBMHMDH<Action<T>>, global::MMIKEHEKIDL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1B07B40", Offset = "0x1B06B40", VA = "0x181B07B40")]
	public GEJNJACEKKG(bool HKOMFNEMPED = false, bool EAAINPEDCHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FF10", Offset = "0x1F9EF10", VA = "0x181F9FF10")]
	public void MMJDKDNGBNI(T FKCKCIEHDDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1B07480", Offset = "0x1B06480", VA = "0x181B07480")]
	public static global::GEJNJACEKKG<T> KGPCDFLIDLC(global::GEJNJACEKKG<T> MAFDMOHIMBN, Action<T> HMDBAELNEEE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1B073E0", Offset = "0x1B063E0", VA = "0x181B073E0")]
	public static global::GEJNJACEKKG<T> FCHOKIPJENF(global::GEJNJACEKKG<T> MAFDMOHIMBN, Action<T> HMDBAELNEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BEDFOPFNKHK<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class ECBHJKBDKHH<T, U> : global::LFJAOBMHMDH<Action<T, U>>, global::BEDFOPFNKHK<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1B07B40", Offset = "0x1B06B40", VA = "0x181B07B40")]
	public ECBHJKBDKHH(bool HKOMFNEMPED = false, bool EAAINPEDCHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x22E8CC0", Offset = "0x22E7CC0", VA = "0x1822E8CC0")]
	public void MMJDKDNGBNI(T FKCKCIEHDDN, U EBLIEAFPDNI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1B07480", Offset = "0x1B06480", VA = "0x181B07480")]
	public static global::ECBHJKBDKHH<T, U> KGPCDFLIDLC(global::ECBHJKBDKHH<T, U> MAFDMOHIMBN, Action<T, U> HMDBAELNEEE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1B073E0", Offset = "0x1B063E0", VA = "0x181B073E0")]
	public static global::ECBHJKBDKHH<T, U> FCHOKIPJENF(global::ECBHJKBDKHH<T, U> MAFDMOHIMBN, Action<T, U> HMDBAELNEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OAOIPEDJJKB<T, U, V> : global::LFJAOBMHMDH<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1B07B40", Offset = "0x1B06B40", VA = "0x181B07B40")]
	public OAOIPEDJJKB(bool HKOMFNEMPED = false, bool EAAINPEDCHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D630", Offset = "0x2A2C630", VA = "0x182A2D630")]
	public void MMJDKDNGBNI(T FKCKCIEHDDN, U EBLIEAFPDNI, V ONLDHOHBDND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1B07480", Offset = "0x1B06480", VA = "0x181B07480")]
	public static global::OAOIPEDJJKB<T, U, V> KGPCDFLIDLC(global::OAOIPEDJJKB<T, U, V> MAFDMOHIMBN, Action<T, U, V> HMDBAELNEEE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1B073E0", Offset = "0x1B063E0", VA = "0x181B073E0")]
	public static global::OAOIPEDJJKB<T, U, V> FCHOKIPJENF(global::OAOIPEDJJKB<T, U, V> MAFDMOHIMBN, Action<T, U, V> HMDBAELNEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NCFPALIAMGF<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OCKEMKFMEJI<T, U, V, W> : global::LFJAOBMHMDH<Action<T, U, V, W>>, global::NCFPALIAMGF<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1B07B40", Offset = "0x1B06B40", VA = "0x181B07B40")]
	public OCKEMKFMEJI(bool HKOMFNEMPED = false, bool EAAINPEDCHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2A31150", Offset = "0x2A30150", VA = "0x182A31150")]
	public void MMJDKDNGBNI(T FKCKCIEHDDN, U EBLIEAFPDNI, V ONLDHOHBDND, W JMBFFBABLMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1B07480", Offset = "0x1B06480", VA = "0x181B07480")]
	public static global::OCKEMKFMEJI<T, U, V, W> KGPCDFLIDLC(global::OCKEMKFMEJI<T, U, V, W> MAFDMOHIMBN, Action<T, U, V, W> HMDBAELNEEE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1B073E0", Offset = "0x1B063E0", VA = "0x181B073E0")]
	public static global::OCKEMKFMEJI<T, U, V, W> FCHOKIPJENF(global::OCKEMKFMEJI<T, U, V, W> MAFDMOHIMBN, Action<T, U, V, W> HMDBAELNEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class APDFPPOEPIC<T, U, V, W, X> : global::LFJAOBMHMDH<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1B07B40", Offset = "0x1B06B40", VA = "0x181B07B40")]
	public APDFPPOEPIC(bool HKOMFNEMPED = false, bool EAAINPEDCHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1B0B1F0", Offset = "0x1B0A1F0", VA = "0x181B0B1F0")]
	public void MMJDKDNGBNI(T FKCKCIEHDDN, U EBLIEAFPDNI, V ONLDHOHBDND, W JMBFFBABLMJ, X OAEOFMJBBBF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1B07480", Offset = "0x1B06480", VA = "0x181B07480")]
	public static global::APDFPPOEPIC<T, U, V, W, X> KGPCDFLIDLC(global::APDFPPOEPIC<T, U, V, W, X> MAFDMOHIMBN, Action<T, U, V, W, X> HMDBAELNEEE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1B073E0", Offset = "0x1B063E0", VA = "0x181B073E0")]
	public static global::APDFPPOEPIC<T, U, V, W, X> FCHOKIPJENF(global::APDFPPOEPIC<T, U, V, W, X> MAFDMOHIMBN, Action<T, U, V, W, X> HMDBAELNEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class AJPBCKLCFEK<T, U, V, W, X, Y> : global::LFJAOBMHMDH<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1B07B40", Offset = "0x1B06B40", VA = "0x181B07B40")]
	public AJPBCKLCFEK(bool HKOMFNEMPED = false, bool EAAINPEDCHA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1B07520", Offset = "0x1B06520", VA = "0x181B07520")]
	public void MMJDKDNGBNI(T FKCKCIEHDDN, U EBLIEAFPDNI, V ONLDHOHBDND, W JMBFFBABLMJ, X OAEOFMJBBBF, Y ICAAGKKPPGJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1B07480", Offset = "0x1B06480", VA = "0x181B07480")]
	public static global::AJPBCKLCFEK<T, U, V, W, X, Y> KGPCDFLIDLC(global::AJPBCKLCFEK<T, U, V, W, X, Y> MAFDMOHIMBN, Action<T, U, V, W, X, Y> HMDBAELNEEE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1B073E0", Offset = "0x1B063E0", VA = "0x181B073E0")]
	public static global::AJPBCKLCFEK<T, U, V, W, X, Y> FCHOKIPJENF(global::AJPBCKLCFEK<T, U, V, W, X, Y> MAFDMOHIMBN, Action<T, U, V, W, X, Y> HMDBAELNEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PEHEGHFBACI<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool CKNABCMGHAE(global::PEHEGHFBACI<T> AKEDKOIMGHG);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class CFJPFOPLKPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public global::PEHEGHFBACI<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public CFJPFOPLKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2A41DE0", Offset = "0x2A40DE0", VA = "0x182A41DE0")]
		internal bool <FindNode>b__0(global::PEHEGHFBACI<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public T BEKPPLPNAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public LinkedList<global::PEHEGHFBACI<T>> FOCDMCIKEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public global::PEHEGHFBACI<T> CAHBNGKOKBB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public global::PEHEGHFBACI<T> FGANEJLKPND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x478A20", Offset = "0x477A20", VA = "0x180478A20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2A4DCE0", Offset = "0x2A4CCE0", VA = "0x182A4DCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AECDBEMBEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FB10", Offset = "0x2A4EB10", VA = "0x182A4FB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool CCBDDNEIEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FAD0", Offset = "0x2A4EAD0", VA = "0x182A4FAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public global::PEHEGHFBACI<T> MMCGKDGDFGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A4E280", Offset = "0x2A4D280", VA = "0x182A4E280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A50250", Offset = "0x2A4F250", VA = "0x182A50250")]
	public PEHEGHFBACI(T EDHOGDJJFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EBB0", Offset = "0x2A4DBB0", VA = "0x182A4EBB0")]
	public global::PEHEGHFBACI<T> HJCNPDBHLBJ(T KNOFEOANIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2A4ECD0", Offset = "0x2A4DCD0", VA = "0x182A4ECD0")]
	public global::PEHEGHFBACI<T> IEHBHDJKDNN(T CKMODHKCJBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E830", Offset = "0x2A4D830", VA = "0x182A4E830")]
	public global::PEHEGHFBACI<T> DFMMJKLLKMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E550", Offset = "0x2A4D550", VA = "0x182A4E550")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E8E0", Offset = "0x2A4D8E0", VA = "0x182A4E8E0")]
	public global::PEHEGHFBACI<T> HFKHIDOHPEL(T KHBBGILCDDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A4FB40", Offset = "0x2A4EB40", VA = "0x182A4FB40")]
	public static void OODLNHKECPD(global::PEHEGHFBACI<T> EDODKGOINHK, CKNABCMGHAE ONDHJOGNEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1C11930", Offset = "0x1C10930", VA = "0x181C11930")]
	public static void OODLNHKECPD<A>(global::PEHEGHFBACI<T> EDODKGOINHK, Func<global::PEHEGHFBACI<T>, A, bool> ONDHJOGNEGG, A PBIALNDLKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A4F580", Offset = "0x2A4E580", VA = "0x182A4F580")]
	public static string KGFJJGIAIGN(global::PEHEGHFBACI<T> EDODKGOINHK, int PEAJNJDBLJK = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A4DE60", Offset = "0x2A4CE60", VA = "0x182A4DE60")]
	public static global::PEHEGHFBACI<T> APDFEKKAHGJ(global::PEHEGHFBACI<T> EDODKGOINHK, T GPKNCCCBCEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class CEOFLOCOIPC<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate int CCEOKGPLJGC(TKey FNHMPFHLGJM, TVal DAPPHEJJLEB);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private class IPEHKKFFPPM
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TKey IMOMDNMFBED
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TVal MJMAKEDLBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5B4F80", Offset = "0x5B3F80", VA = "0x1805B4F80")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x626720", Offset = "0x625720", VA = "0x180626720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int ILAKLJFBOGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x531730", Offset = "0x530730", VA = "0x180531730")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x531760", Offset = "0x530760", VA = "0x180531760")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DateTime FKCNAINDBMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x42ACF0", Offset = "0x429CF0", VA = "0x18042ACF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4517D0", Offset = "0x4507D0", VA = "0x1804517D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E290", Offset = "0x1F3D290", VA = "0x181F3E290")]
		public IPEHKKFFPPM(TKey FNHMPFHLGJM, TVal CIIDGEOMGCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const int GGFHJFPJCNC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Dictionary<TKey, LinkedListNode<IPEHKKFFPPM>> LLAAGPLGLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly LinkedList<IPEHKKFFPPM> OGMOHKCPFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CCEOKGPLJGC AOFFBPMMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly TimeSpan FCGMIFLABFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HDJAIMNFNGF EMIIOFNJPPC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int LMPBBEIGONP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x53A860", Offset = "0x539860", VA = "0x18053A860")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool KBDPMJJFCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1F35000", Offset = "0x1F34000", VA = "0x181F35000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal int EFECDLJFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x53A870", Offset = "0x539870", VA = "0x18053A870")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x52F8B0", Offset = "0x52E8B0", VA = "0x18052F8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey IANIKNGKGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1F35090", Offset = "0x1F34090", VA = "0x181F35090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F35C50", Offset = "0x1F34C50", VA = "0x181F35C50")]
	public CEOFLOCOIPC(int FLHMGHOMCFP, [Optional] CCEOKGPLJGC AOFFBPMMKPO, [Optional] IEqualityComparer<TKey> PJFCDPFJNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F35740", Offset = "0x1F34740", VA = "0x181F35740")]
	public CEOFLOCOIPC(int FLHMGHOMCFP, CCEOKGPLJGC AOFFBPMMKPO, TimeSpan FCGMIFLABFG, [Optional] IEqualityComparer<TKey> PJFCDPFJNJC, [Optional] HDJAIMNFNGF EMIIOFNJPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F347F0", Offset = "0x1F337F0", VA = "0x181F347F0")]
	public void HMAPFHBEPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F34330", Offset = "0x1F33330", VA = "0x181F34330")]
	public void FCPHIFCOHOD(TKey FNHMPFHLGJM, TVal DAPPHEJJLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F341B0", Offset = "0x1F331B0", VA = "0x181F341B0")]
	public bool DFMMJKLLKMC(TKey FNHMPFHLGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F34D60", Offset = "0x1F33D60", VA = "0x181F34D60")]
	public bool IKDFAGNOIFG(TKey HAABDDIHFPI, out TVal DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F34130", Offset = "0x1F33130", VA = "0x181F34130")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F35680", Offset = "0x1F34680", VA = "0x181F35680")]
	private bool MIEKBOEGEDJ(IPEHKKFFPPM PEIGBGEIBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F35340", Offset = "0x1F34340", VA = "0x181F35340")]
	private void MAMNPMBCCDC(LinkedListNode<IPEHKKFFPPM> CHMKKJEPOOK, TVal DNFFJBLOIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F34B50", Offset = "0x1F33B50", VA = "0x181F34B50")]
	private void IDAHADAEMPD(TKey FNHMPFHLGJM, TVal DAPPHEJJLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F34650", Offset = "0x1F33650", VA = "0x181F34650")]
	private void HBJJMCPHIFB(IPEHKKFFPPM PEIGBGEIBDO, TVal DNFFJBLOIAE, int NHJBDADPNGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class ALILFHGDPCC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly List<T> KFCDAMJPHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private HashSet<T> FHGBEDNLCFM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int DINAJDNNPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1B08E10", Offset = "0x1B07E10", VA = "0x181B08E10", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool NIFICALGCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x428E40", Offset = "0x427E40", VA = "0x180428E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T IANIKNGKGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1B08E40", Offset = "0x1B07E40", VA = "0x181B08E40", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1B08E70", Offset = "0x1B07E70", VA = "0x181B08E70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1B085E0", Offset = "0x1B075E0", VA = "0x181B085E0", Slot = "11")]
	public void Add(T PJMKALJFKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1B089C0", Offset = "0x1B079C0", VA = "0x181B089C0")]
	public bool JDMMABJMGCC(T PJMKALJFKLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1B08C90", Offset = "0x1B07C90", VA = "0x181B08C90", Slot = "15")]
	public bool Remove(T PJMKALJFKLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1B086D0", Offset = "0x1B076D0", VA = "0x181B086D0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1B08D10", Offset = "0x1B07D10", VA = "0x181B08D10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1B08610", Offset = "0x1B07610", VA = "0x181B08610", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1B08670", Offset = "0x1B07670", VA = "0x181B08670", Slot = "13")]
	public bool Contains(T PJMKALJFKLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1B086A0", Offset = "0x1B076A0", VA = "0x181B086A0", Slot = "14")]
	public void CopyTo(T[] HDKKHNDIOBM, int BBFDPANNOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1B08750", Offset = "0x1B07750", VA = "0x181B08750", Slot = "6")]
	public int IndexOf(T PJMKALJFKLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1B08850", Offset = "0x1B07850", VA = "0x181B08850", Slot = "7")]
	public void Insert(int JPADDGNBPOA, T PJMKALJFKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1B08A60", Offset = "0x1B07A60", VA = "0x181B08A60", Slot = "8")]
	public void RemoveAt(int JPADDGNBPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1B08D40", Offset = "0x1B07D40", VA = "0x181B08D40")]
	public ALILFHGDPCC()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1C8F460", Offset = "0x1C8E460", VA = "0x181C8F460")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CB30", Offset = "0x3D6BB30", VA = "0x183D6CB30")]
		public SerializedGuid(in Guid FEPNFDDDGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CAB0", Offset = "0x3D6BAB0", VA = "0x183D6CAB0")]
		public static SerializedGuid PFOCMEOLMJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C970", Offset = "0x3D6B970", VA = "0x183D6C970")]
		public static SerializedGuid IDIDGLOOOPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C8D0", Offset = "0x3D6B8D0", VA = "0x183D6C8D0")]
		public bool GBLAKAGJEHC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D6CA90", Offset = "0x3D6BA90", VA = "0x183D6CA90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C9F0", Offset = "0x3D6B9F0", VA = "0x183D6C9F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C750", Offset = "0x3D6B750", VA = "0x183D6C750", Slot = "7")]
		public bool Equals(SerializedGuid AIJMKPMALLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C7F0", Offset = "0x3D6B7F0", VA = "0x183D6C7F0", Slot = "0")]
		public override bool Equals(object KFEIKGNAKCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C960", Offset = "0x3D6B960", VA = "0x183D6C960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C720", Offset = "0x3D6B720", VA = "0x183D6C720", Slot = "6")]
		public int CompareTo(SerializedGuid AIJMKPMALLK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KLMDDAOIJNP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly Type KDGHMMJDPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly string LPHLJPGHOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool LFDACPLDBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool IJKLPALBOOL;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C290", Offset = "0x3D6B290", VA = "0x183D6C290")]
	public KLMDDAOIJNP(Type HLLKKBMBOFM, string OGFALJNKJBK, bool DGBKOMMJMCP = false, bool EMOBOACEKOA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DDNDBLFPJDC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T MJMAKEDLBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool APJMMCDALCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::DDNDBLFPJDC<T> PHNJMBPDADO(Action<T> BNPNDMGJIAB);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DDNDBLFPJDC<T> LJEOIBMMHME(Action<T> BNPNDMGJIAB);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LBIDGONCCLB<T> : global::DDNDBLFPJDC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private global::ECBHJKBDKHH<T, T> KMKONANCDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private global::GEJNJACEKKG<T> BKDNCKLGEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private global::GEJNJACEKKG<string> PDFMBKGCILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private string MCGGOOFMGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T KFPDCJGFCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool GJPADFKDIGD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T MJMAKEDLBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x44F670", Offset = "0x44E670", VA = "0x18044F670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1B0D9D0", Offset = "0x1B0C9D0", VA = "0x181B0D9D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool APJMMCDALCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x52F690", Offset = "0x52E690", VA = "0x18052F690", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1D917C0", Offset = "0x1D907C0", VA = "0x181D917C0")]
	private void DKLBCKPLLMN(T CABLJJAAJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1D91870", Offset = "0x1D90870", VA = "0x181D91870", Slot = "4")]
	public global::DDNDBLFPJDC<T> PHNJMBPDADO(Action<T> AGHEJFGNDCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1D91840", Offset = "0x1D90840", VA = "0x181D91840", Slot = "5")]
	public global::DDNDBLFPJDC<T> LJEOIBMMHME(Action<T> BNPNDMGJIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1D918F0", Offset = "0x1D908F0", VA = "0x181D918F0")]
	public LBIDGONCCLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KPBGMHNEGHP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OHAOPKPIPGH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public global::DDNDBLFPJDC<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public global::EDPCHJECIEG<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public OHAOPKPIPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0C90", Offset = "0x1D9FC90", VA = "0x181DA0C90")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1AC8170", Offset = "0x1AC7170", VA = "0x181AC8170")]
	public static global::CFGAGIADBID<T> JOGLLPHDJCN<T>(this global::DDNDBLFPJDC<T> JMEGHKFEAGG, Action<T> PBCLPMFCHNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class HDJAIMNFNGF
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class NBPAANMFNEC : HDJAIMNFNGF
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static HDJAIMNFNGF KKBAOLHCPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3D6C340", Offset = "0x3D6B340", VA = "0x183D6C340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override DateTime HOMNOJMINNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3D6C2F0", Offset = "0x3D6B2F0", VA = "0x183D6C2F0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C430", Offset = "0x3D6B430", VA = "0x183D6C430")]
		public NBPAANMFNEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static HDJAIMNFNGF AEOPJJPJHGK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static HDJAIMNFNGF ENLGDIOICAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3D6BE10", Offset = "0x3D6AE10", VA = "0x183D6BE10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract DateTime HOMNOJMINNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
	protected HDJAIMNFNGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KJBABGBCCPF : global::BCFNBKGDLGB<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C250", Offset = "0x3D6B250", VA = "0x183D6C250")]
	public KJBABGBCCPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BCFNBKGDLGB<T> : global::DFJCBGAPBEF<T>, EGNDMBDIJIM, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task<T> JNAOJPJEKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public global::CFGAGIADBID<T> BEPEFONIDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private EBJFPPEJHJH PBGIEGPDBKL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1767D00", Offset = "0x1766D00", VA = "0x181767D00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1B0E340", Offset = "0x1B0D340", VA = "0x181B0E340")]
	public BCFNBKGDLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class HGAJAMCNILP<T> : global::DFJCBGAPBEF<T>, EGNDMBDIJIM, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Task<T> JNAOJPJEKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public global::CFGAGIADBID<T> BEPEFONIDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private EBJFPPEJHJH PBGIEGPDBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1767D00", Offset = "0x1766D00", VA = "0x181767D00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3690270", Offset = "0x368F270", VA = "0x183690270")]
	public HGAJAMCNILP(Exception GNHMBININJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface EGNDMBDIJIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	[NotNull]
	EBJFPPEJHJH BEPEFONIDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface DFJCBGAPBEF<T> : EGNDMBDIJIM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	Task<T> JNAOJPJEKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	new global::CFGAGIADBID<T> BEPEFONIDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class MFEOBPJKOLJ<TTask, T> : global::DFJCBGAPBEF<T>, EGNDMBDIJIM, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class AGFHKPMPNBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public global::MFEOBPJKOLJ<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public AGFHKPMPNBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class BPHINOOLOIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AGFHKPMPNBN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		public BPHINOOLOIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2399860", Offset = "0x2398860", VA = "0x182399860")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static bool CDEEKAGNFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly global::EDPCHJECIEG<T> FPFGAOOHILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Task<T> GHMGPLGBFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly CancellationTokenSource BIODNBLKAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool JMENAGHLHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private SynchronizationContext EOOMFMFPLKG;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> JNAOJPJEKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::CFGAGIADBID<T> BEPEFONIDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private EBJFPPEJHJH PBGIEGPDBKL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool INBKJGKAHFP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4EBA20", Offset = "0x4EAA20", VA = "0x1804EBA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x23AA580", Offset = "0x23A9580", VA = "0x1823AA580")]
	static MFEOBPJKOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x23AA6F0", Offset = "0x23A96F0", VA = "0x1823AA6F0")]
	protected MFEOBPJKOLJ(TTask GHMGPLGBFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x23AA240", Offset = "0x23A9240", VA = "0x1823AA240", Slot = "1")]
	~MFEOBPJKOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x23AA210", Offset = "0x23A9210", VA = "0x1823AA210", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x23AA410", Offset = "0x23A9410", VA = "0x1823AA410")]
	private void PFGPAPCIHGP(bool MBEMHLHEKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BPJNMHJDKPD(TTask OGMPCOANBMB);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void ODHHKPKCNOF();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x23AA2E0", Offset = "0x23A92E0", VA = "0x1823AA2E0")]
	protected void HKLFGGKEGBG(T CABLJJAAJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x23AA190", Offset = "0x23A9190", VA = "0x1823AA190")]
	protected void DPJNFMMAMAO(string MCGGOOFMGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x23AA370", Offset = "0x23A9370", VA = "0x1823AA370")]
	[CompilerGenerated]
	private void OAGMIGHDNIN(object FJCDAFBAEAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class OJEPFOJOLNK<T> : IEnumerable<global::OJEPFOJOLNK<T>.FBPPIGEJBBB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct FBPPIGEJBBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public T DAPPHEJJLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int JPADDGNBPOA;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class EHNJBDAHPJC : IEnumerator<FBPPIGEJBBB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::OJEPFOJOLNK<T> BEOFMIDOPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int JPADDGNBPOA;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x237E730", Offset = "0x237D730", VA = "0x18237E730", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public FBPPIGEJBBB HFOPJDLMNLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x2A29B80", Offset = "0x2A28B80", VA = "0x182A29B80", Slot = "4")]
			get
			{
				return default(FBPPIGEJBBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x69CC60", Offset = "0x69BC60", VA = "0x18069CC60")]
		public EHNJBDAHPJC(global::OJEPFOJOLNK<T> BEOFMIDOPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2A29AF0", Offset = "0x2A28AF0", VA = "0x182A29AF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x588290", Offset = "0x587290", VA = "0x180588290", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x70E1D0", Offset = "0x70D1D0", VA = "0x18070E1D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct PPCPAMLCAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public bool EIIDHOHBDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T DAPPHEJJLEB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private const int CLLNPBDFMHN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private Dictionary<T, int> LKCDJCJKABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private PPCPAMLCAIM[] DANOADMJIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int MGGIOOHGBDE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int DINAJDNNPFE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1C01A60", Offset = "0x1C00A60", VA = "0x181C01A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2A32F00", Offset = "0x2A31F00", VA = "0x182A32F00")]
	public static global::OJEPFOJOLNK<T> JPLKCFGKNGN(FBPPIGEJBBB[] OBLOCLMKEHJ, bool OBNNFPNIODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2A33380", Offset = "0x2A32380", VA = "0x182A33380")]
	public OJEPFOJOLNK(int FLHMGHOMCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2A32B10", Offset = "0x2A31B10", VA = "0x182A32B10")]
	public int HJCGAEDNEAN(T DAPPHEJJLEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2A32E90", Offset = "0x2A31E90", VA = "0x182A32E90")]
	public T JOGLLPHDJCN(int JPADDGNBPOA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2A32D30", Offset = "0x2A31D30", VA = "0x182A32D30")]
	public bool JDMMABJMGCC(T DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2A32B60", Offset = "0x2A31B60", VA = "0x182A32B60")]
	public bool JDMMABJMGCC(T DAPPHEJJLEB, int JPADDGNBPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2A32D50", Offset = "0x2A31D50", VA = "0x182A32D50")]
	public FBPPIGEJBBB[] JFKOBPCJGOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2A332C0", Offset = "0x2A322C0", VA = "0x182A332C0")]
	private int KOINMLPMCNG(int JNNCFGOKOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2A33310", Offset = "0x2A32310", VA = "0x182A33310", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2A33310", Offset = "0x2A32310", VA = "0x182A33310", Slot = "4")]
	private IEnumerator<FBPPIGEJBBB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class GKJGNHKGBPH<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private List<T> DGHFGFEKKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<T> HNFJJGIAMHP;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3660", Offset = "0x1FA2660", VA = "0x181FA3660")]
	public GKJGNHKGBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3690", Offset = "0x1FA2690", VA = "0x181FA3690")]
	public GKJGNHKGBPH(int FLHMGHOMCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3560", Offset = "0x1FA2560", VA = "0x181FA3560")]
	public T GLBMPDNMNGA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3440", Offset = "0x1FA2440", VA = "0x181FA3440")]
	public void BECFAHICGJB(T KBLDJBPBPHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class DDOIJBEKIPE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<int, T> AHGJJEHPLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private T MJMNKIHFBHP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public virtual T OODFOGBMAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x428190", Offset = "0x427190", VA = "0x180428190", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x428450", Offset = "0x427450", VA = "0x180428450", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x22DF380", Offset = "0x22DE380", VA = "0x1822DF380")]
	public bool IDAHADAEMPD(T DAPPHEJJLEB, int LKGCAMKHBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x22DEDF0", Offset = "0x22DDDF0", VA = "0x1822DEDF0")]
	public bool EIBCNDFJPEH(int LKGCAMKHBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x22DF0C0", Offset = "0x22DE0C0", VA = "0x1822DF0C0")]
	public T FAPIHDGJEHO(int HJNGAKMJBPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x22DF410", Offset = "0x22DE410", VA = "0x1822DF410")]
	private bool ONHBHLOAGEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x22DF3E0", Offset = "0x22DE3E0", VA = "0x1822DF3E0")]
	public bool IKDFAGNOIFG(int LKGCAMKHBCM, out T DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x22DF5B0", Offset = "0x22DE5B0", VA = "0x1822DF5B0")]
	public DDOIJBEKIPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class PHLCHAKGMOD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	protected struct ELBDEACCHEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public T MJMAKEDLBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int COKFKHCLNMI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	protected readonly List<ELBDEACCHEA> JGDKKOFPFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private T KEDPLKFDOJI;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DINAJDNNPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1B08E10", Offset = "0x1B07E10", VA = "0x181B08E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2A502F0", Offset = "0x2A4F2F0", VA = "0x182A502F0")]
	public bool BMAILDILANG(T DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2A50750", Offset = "0x2A4F750", VA = "0x182A50750")]
	public void KGODAIEOADL(T DAPPHEJJLEB, int LKGCAMKHBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2A505A0", Offset = "0x2A4F5A0", VA = "0x182A505A0")]
	public bool DFMMJKLLKMC(T DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2A50540", Offset = "0x2A4F540", VA = "0x182A50540")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2A506C0", Offset = "0x2A4F6C0", VA = "0x182A506C0")]
	public T FJBJCNCBPDM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2A507D0", Offset = "0x2A4F7D0", VA = "0x182A507D0")]
	private void NNDKKPAEAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2A509E0", Offset = "0x2A4F9E0", VA = "0x182A509E0")]
	public PHLCHAKGMOD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x177B1D0", Offset = "0x177A1D0", VA = "0x18177B1D0", Slot = "4")]
		public virtual T JKDEIDJBJJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x17681B0", Offset = "0x17671B0", VA = "0x1817681B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class FJLBMJAGJJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<byte, FONHBDLPNOF> DCEMNFPIMMO;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FONHBDLPNOF NIFHNHLPCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4281A0", Offset = "0x4271A0", VA = "0x1804281A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x428440", Offset = "0x427440", VA = "0x180428440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 BHHDIMANKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x100E500", Offset = "0x100D500", VA = "0x18100E500")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1B0D970", Offset = "0x1B0C970", VA = "0x181B0D970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector2 LKDOCOCDGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x13577B0", Offset = "0x13567B0", VA = "0x1813577B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 KNOHFDCIOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7A00", Offset = "0x2DB6A00", VA = "0x182DB7A00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7A20", Offset = "0x2DB6A20", VA = "0x182DB7A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int PACLJOAKJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4521B0", Offset = "0x4511B0", VA = "0x1804521B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x477360", Offset = "0x476360", VA = "0x180477360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B400", Offset = "0x3D6A400", VA = "0x183D6B400")]
	public FJLBMJAGJJE(Bounds PMLHPIAMLCM, Vector2[] HJHDMEDNJMK, int CAIDMEPKCFA, byte JNNCFGOKOBC, float CGMIGHCAIJF = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B3A0", Offset = "0x3D6A3A0", VA = "0x183D6B3A0")]
	public FONHBDLPNOF OALJDEKIFBJ(byte JPADDGNBPOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B2C0", Offset = "0x3D6A2C0", VA = "0x183D6B2C0")]
	public void LNMDJLJEDGE(Vector3 NJOLPKLIKMN, float KOCFDHFHMNG, float BGJPMDALNGK, ref List<byte> FPJEPHBFMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AC60", Offset = "0x3D69C60", VA = "0x183D6AC60")]
	public void AAHKFDFDPMB(FONHBDLPNOF.BNHLLFMKKNB ELEECGOFCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B1A0", Offset = "0x3D6A1A0", VA = "0x183D6B1A0")]
	private FONHBDLPNOF BMIKLLMJOHB(byte JPADDGNBPOA, FONHBDLPNOF.KHEKIAAEGKO JBIHNOBBOMC, FONHBDLPNOF IJIGCJIFIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AC80", Offset = "0x3D69C80", VA = "0x183D6AC80")]
	private void AKLKBIBIMEI(FONHBDLPNOF IJIGCJIFIBA, Vector2[] HJHDMEDNJMK, int KJOIEJKCFPC, int ACNHCLBKCPP, int KMONEEBBCGA, int FIDPFJEFDJL, float CGMIGHCAIJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class FONHBDLPNOF
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum KHEKIAAEGKO
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum BNHLLFMKKNB
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte EDIHCCFHHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Vector3 PKDBMCGGDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Vector3 ILAKLJFBOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Vector3 BCKOBFBDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Vector3 PJAKHODAJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public KHEKIAAEGKO IOEFPJBGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public FONHBDLPNOF FGANEJLKPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<FONHBDLPNOF> NGAHGLKFOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool IMOCAOMDHGE;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3D6BCB0", Offset = "0x3D6ACB0", VA = "0x183D6BCB0")]
	public FONHBDLPNOF(byte JLIONFOJGGD, KHEKIAAEGKO JBIHNOBBOMC, FONHBDLPNOF IJIGCJIFIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B930", Offset = "0x3D6A930", VA = "0x183D6B930")]
	public void HJCNPDBHLBJ(FONHBDLPNOF CLGCFDGCNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00")]
	public void AAHKFDFDPMB(int EMCPLMCEECC, BNHLLFMKKNB ELEECGOFCDD, int EPCOHJDIGFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3D6BA20", Offset = "0x3D6AA20", VA = "0x183D6BA20")]
	public void LNMDJLJEDGE(List<byte> FPJEPHBFMCB, Vector3 NJOLPKLIKMN, float KOCFDHFHMNG, float BGJPMDALNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B9C0", Offset = "0x3D6A9C0", VA = "0x183D6B9C0")]
	public bool ILFDDJLJCBI(Vector3 FBLIDLGDANB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3D6B8F0", Offset = "0x3D6A8F0", VA = "0x183D6B8F0")]
	public bool FJIJKODDLBF(Vector3 FBLIDLGDANB, float NEHJAEMHONB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GLFHDICKKDD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private int FLHMGHOMCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int NAIJGFGLFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private List<T> GJOIMGADKAB;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public T FPNKPINDNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3B10", Offset = "0x1FA2B10", VA = "0x181FA3B10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T NCPFEAGLIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3CF0", Offset = "0x1FA2CF0", VA = "0x181FA3CF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T PADCGLKNHPA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3C30", Offset = "0x1FA2C30", VA = "0x181FA3C30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3DA0", Offset = "0x1FA2DA0", VA = "0x181FA3DA0")]
	public GLFHDICKKDD(int FLHMGHOMCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3890", Offset = "0x1FA2890", VA = "0x181FA3890")]
	public void KGODAIEOADL(T ECJLCOEKFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3850", Offset = "0x1FA2850", VA = "0x181FA3850")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA37F0", Offset = "0x1FA27F0", VA = "0x181FA37F0")]
	public void BKGLEIMBJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3840", Offset = "0x1FA2840", VA = "0x181FA3840")]
	public void BOCJDCFCMCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class CMOICNMOIOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct IOGNPPNJDGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int COKFKHCLNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public T MJMAKEDLBNJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<object, IOGNPPNJDGB> AHGJJEHPLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private T MJMNKIHFBHP;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T OODFOGBMAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x100E500", Offset = "0x100D500", VA = "0x18100E500", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1B0D970", Offset = "0x1B0C970", VA = "0x181B0D970", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool CEBKEOBDGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x298DB80", Offset = "0x298CB80", VA = "0x18298DB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object DCHIJCLKGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x42ACF0", Offset = "0x429CF0", VA = "0x18042ACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4517D0", Offset = "0x4507D0", VA = "0x1804517D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x29888E0", Offset = "0x29878E0", VA = "0x1829888E0")]
	public bool IDAHADAEMPD(T DAPPHEJJLEB, object DONHNNGDPOF, int LKGCAMKHBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2988190", Offset = "0x2987190", VA = "0x182988190")]
	public bool EIBCNDFJPEH(object DONHNNGDPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2988CB0", Offset = "0x2987CB0", VA = "0x182988CB0")]
	public bool IKDFAGNOIFG(object DONHNNGDPOF, out T DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x1BF2950", Offset = "0x1BF1950", VA = "0x181BF2950")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x298D0F0", Offset = "0x298C0F0", VA = "0x18298D0F0")]
	private bool ONHBHLOAGEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x298DBB0", Offset = "0x298CBB0", VA = "0x18298DBB0")]
	public CMOICNMOIOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class ABIHFDHDODO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Dictionary<object, float> AHGJJEHPLPB;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float KLEFMAFOGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xC70520", Offset = "0xC6F520", VA = "0x180C70520")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xB6B960", Offset = "0xB6A960", VA = "0x180B6B960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A600", Offset = "0x3D69600", VA = "0x183D6A600")]
	public void IDAHADAEMPD(float DAPPHEJJLEB, object DONHNNGDPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A590", Offset = "0x3D69590", VA = "0x183D6A590")]
	public void EIBCNDFJPEH(object DONHNNGDPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A670", Offset = "0x3D69670", VA = "0x183D6A670")]
	private void LHCLFJKIDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A790", Offset = "0x3D69790", VA = "0x183D6A790")]
	public ABIHFDHDODO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class CMGOOBPEHDP
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class GLPKLNKNCHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly string ABIJJJNLBJF;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
		private GLPKLNKNCHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x514D10", Offset = "0x513D10", VA = "0x180514D10")]
		public GLPKLNKNCHB(string ABIJJJNLBJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3D6BDC0", Offset = "0x3D6ADC0", VA = "0x183D6BDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class BAADFIHALKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D0", Offset = "0x4299D0", VA = "0x18042A9D0")]
		public BAADFIHALKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3D6A800", Offset = "0x3D69800", VA = "0x183D6A800")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly HashSet<object> LBCIKNCMAAL;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool MDEOAIPCFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3D6AA20", Offset = "0x3D69A20", VA = "0x183D6AA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A9C0", Offset = "0x3D699C0", VA = "0x183D6A9C0")]
	public void KGODAIEOADL(object DONHNNGDPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A960", Offset = "0x3D69960", VA = "0x183D6A960")]
	public void DFMMJKLLKMC(object DONHNNGDPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A900", Offset = "0x3D69900", VA = "0x183D6A900")]
	public bool BMAILDILANG(object DONHNNGDPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A8B0", Offset = "0x3D698B0", VA = "0x183D6A8B0")]
	public void BFBEMHDDDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3D6AA60", Offset = "0x3D69A60", VA = "0x183D6AA60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3D6ABC0", Offset = "0x3D69BC0", VA = "0x183D6ABC0")]
	public CMGOOBPEHDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class IDDPLNILMGP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct HCENHBDNDFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float NNDDCENAGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public T MJMAKEDLBNJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Dictionary<object, HCENHBDNDFK> AHGJJEHPLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T AJILHJMKMNB;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T BAKLOHAFDAE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x109A300", Offset = "0x1099300", VA = "0x18109A300", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1BF5080", Offset = "0x1BF4080", VA = "0x181BF5080", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object FKCOGDFBKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x44F670", Offset = "0x44E670", VA = "0x18044F670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x517DD0", Offset = "0x516DD0", VA = "0x180517DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CEBKEOBDGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1BF50A0", Offset = "0x1BF40A0", VA = "0x181BF50A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x1BF2BA0", Offset = "0x1BF1BA0", VA = "0x181BF2BA0")]
	public bool IDAHADAEMPD(T DAPPHEJJLEB, object DONHNNGDPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1BF2980", Offset = "0x1BF1980", VA = "0x181BF2980")]
	public bool EIBCNDFJPEH(object DONHNNGDPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x1BF2950", Offset = "0x1BF1950", VA = "0x181BF2950")]
	public void CIIJOJFGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x1BF3160", Offset = "0x1BF2160", VA = "0x181BF3160")]
	public bool IKDFAGNOIFG(object DONHNNGDPOF, out T DAPPHEJJLEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1BF4530", Offset = "0x1BF3530", VA = "0x181BF4530")]
	private bool ONHBHLOAGEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1BF50E0", Offset = "0x1BF40E0", VA = "0x181BF50E0")]
	public IDDPLNILMGP()
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
