using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
public class FLHKMOJAEED : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DA570", Offset = "0x5D9370", VA = "0x1805DA570")]
	public FLHKMOJAEED()
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
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EE0", Offset = "0x4E8CE0", VA = "0x1804E9EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4E94A0", Offset = "0x4E82A0", VA = "0x1804E94A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "4")]
	public virtual void FMKJHGIDFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
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
	[FLHKMOJAEED]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x31CE5E0", Offset = "0x31CD3E0", VA = "0x1831CE5E0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x31CE120", Offset = "0x31CCF20", VA = "0x1831CE120", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x31CEBE0", Offset = "0x31CD9E0", VA = "0x1831CEBE0")]
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
	private sealed class FHPJNEMAJDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public FHPJNEMAJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x34404B0", Offset = "0x343F2B0", VA = "0x1834404B0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[FLHKMOJAEED]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x343D320", Offset = "0x343C120", VA = "0x18343D320", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x343D350", Offset = "0x343C150", VA = "0x18343D350", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x343D270", Offset = "0x343C070", VA = "0x18343D270", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey MLBLCDKAFED]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x343D2A0", Offset = "0x343C0A0", VA = "0x18343D2A0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x343D170", Offset = "0x343BF70", VA = "0x18343D170", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x343C9D0", Offset = "0x343B7D0", VA = "0x18343C9D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x343C340", Offset = "0x343B140", VA = "0x18343C340", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x343BF40", Offset = "0x343AD40", VA = "0x18343BF40", Slot = "14")]
	protected virtual string JMEMBPMPFJK(TKeyVal DFMKCOFOKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x343BE80", Offset = "0x343AC80", VA = "0x18343BE80", Slot = "4")]
	public bool ContainsKey(TKey MLBLCDKAFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x343D060", Offset = "0x343BE60", VA = "0x18343D060", Slot = "5")]
	public bool TryGetValue(TKey MLBLCDKAFED, out TVal LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x343BEB0", Offset = "0x343ACB0", VA = "0x18343BEB0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x343BEB0", Offset = "0x343ACB0", VA = "0x18343BEB0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x343D090", Offset = "0x343BE90", VA = "0x18343D090")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KJJNKAMHCJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LLDMHFAKFLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public LLDMHFAKFLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2F60", Offset = "0x3CD1D60", VA = "0x183CD2F60")]
		internal bool <GetSamples>b__0(global::HCFKNBPBOCD<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float GDDCNGBDBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float DKFCOJPJMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::HCFKNBPBOCD<float, T>> NLBDHAPAKIN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OGMCIGIKJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD21A0", Offset = "0x3CD0FA0", VA = "0x183CD21A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2CD0", Offset = "0x3CD1AD0", VA = "0x183CD2CD0")]
	public KJJNKAMHCJL(float BGCFLKGJFND, float MNOAHHELJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CD29E0", Offset = "0x3CD17E0", VA = "0x183CD29E0")]
	public bool LFAGPDIKDDE(float LJNKAEFAAAO, T LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2360", Offset = "0x3CD1160", VA = "0x183CD2360")]
	public IEnumerable<T> JECFILCMAKD(float LJNKAEFAAAO, [Optional] float? IHMPLBPIIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3CD2CA0", Offset = "0x3CD1AA0", VA = "0x183CD2CA0")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3CD22A0", Offset = "0x3CD10A0", VA = "0x183CD22A0")]
	private void GJCOAKBCJOG(float LJNKAEFAAAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class GMIDJNMMCEL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ABMOGMBNKMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T KIKNELACDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float AAGDPBAFMKD;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float EAGIKNPDAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> HDEKBHCEHNC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int FLJCEFINNFK = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private ABMOGMBNKMG[] GJIJDBFDOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int AJOHKAFMPJK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float KPFLGCJDHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE33CA0", Offset = "0xE32AA0", VA = "0x180E33CA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xE33CD0", Offset = "0xE32AD0", VA = "0x180E33CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1C66D60", Offset = "0x1C65B60", VA = "0x181C66D60")]
	public GMIDJNMMCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1C66C80", Offset = "0x1C65A80", VA = "0x181C66C80")]
	public GMIDJNMMCEL(int AHCNLPEMKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1C65DB0", Offset = "0x1C64BB0", VA = "0x181C65DB0")]
	public void EFHDBFNBKGH(float LJNKAEFAAAO, T LNPFAODMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1C66700", Offset = "0x1C65500", VA = "0x181C66700")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1C66850", Offset = "0x1C65650", VA = "0x181C66850")]
	public bool OKLMHJJGGJF(float IGIFHOFNDPF, float CGOOLHNBHEP, out T LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1C65FA0", Offset = "0x1C64DA0", VA = "0x181C65FA0")]
	public bool KBMBEADIMGA(float IGIFHOFNDPF, float CGOOLHNBHEP, out T LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1C66420", Offset = "0x1C65220", VA = "0x181C66420")]
	public void LKGLGKLFCLD(float IGIFHOFNDPF, float CGOOLHNBHEP, List<T> IPCKBHAMEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1C65F70", Offset = "0x1C64D70", VA = "0x181C65F70")]
	private int FIPIFCEHDPJ(int MNJHNKFANMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1C66570", Offset = "0x1C65370", VA = "0x181C66570")]
	private void MLAAIKHEGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HMCOEBMPCJD();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T KOBGFEFICIK(T LNPFAODMJGO, float KONCOPNEPEO);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CGDDCDDPACD(T HFCEPEKJIKJ, T GOPCHANOFFP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T FKCCAPPBMFO(T HFCEPEKJIKJ, T GOPCHANOFFP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IDBPNALLHMK : global::GMIDJNMMCEL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46D2530", Offset = "0x46D1330", VA = "0x1846D2530", Slot = "4")]
	protected override Vector3 HMCOEBMPCJD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x46D25A0", Offset = "0x46D13A0", VA = "0x1846D25A0", Slot = "5")]
	protected override Vector3 KOBGFEFICIK(Vector3 LNPFAODMJGO, float KONCOPNEPEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46D2410", Offset = "0x46D1210", VA = "0x1846D2410", Slot = "6")]
	protected override Vector3 CGDDCDDPACD(Vector3 HFCEPEKJIKJ, Vector3 GOPCHANOFFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x46D24C0", Offset = "0x46D12C0", VA = "0x1846D24C0", Slot = "7")]
	protected override Vector3 FKCCAPPBMFO(Vector3 HFCEPEKJIKJ, Vector3 GOPCHANOFFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46D2640", Offset = "0x46D1440", VA = "0x1846D2640")]
	public IDBPNALLHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OMPPGNDCMCN
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2847BE0", Offset = "0x28469E0", VA = "0x182847BE0")]
	public static global::HCFKNBPBOCD<T1, T2> MEJCIEELJNL<T1, T2>(T1 COAMCJJDBHE, T2 FLFFBCAGPJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2847C50", Offset = "0x2846A50", VA = "0x182847C50")]
	public static global::NBGCJPKAOHK<T1, T2, T3> MEJCIEELJNL<T1, T2, T3>(T1 COAMCJJDBHE, T2 FLFFBCAGPJA, T3 BNEBJPBFPBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x21B5450", Offset = "0x21B4250", VA = "0x1821B5450")]
	internal static int IJFIFNDJPKI(int JGLIFAGMCLE, int GFFDPEEAABL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5930", Offset = "0x3ED4730", VA = "0x183ED5930")]
	internal static int IJFIFNDJPKI(int JGLIFAGMCLE, int GFFDPEEAABL, int ODCBBPAMBML)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HCFKNBPBOCD<T1, T2> : IComparable<global::HCFKNBPBOCD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 AAILJIOLGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 PIBOMGJAHNG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x37D9A40", Offset = "0x37D8840", VA = "0x1837D9A40")]
	public HCFKNBPBOCD(T1 COAMCJJDBHE, T2 FLFFBCAGPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37D7E90", Offset = "0x37D6C90", VA = "0x1837D7E90", Slot = "4")]
	public int CompareTo(global::HCFKNBPBOCD<T1, T2> KJGIPMMHJFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37D87C0", Offset = "0x37D75C0", VA = "0x1837D87C0", Slot = "0")]
	public override bool Equals(object KJGIPMMHJFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37D8CA0", Offset = "0x37D7AA0", VA = "0x1837D8CA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x37D93E0", Offset = "0x37D81E0", VA = "0x1837D93E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NBGCJPKAOHK<T1, T2, T3> : IComparable<global::NBGCJPKAOHK<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 AAILJIOLGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 PIBOMGJAHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 BLLCIEDBIKD;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28C2A70", Offset = "0x28C1870", VA = "0x1828C2A70")]
	public NBGCJPKAOHK(T1 COAMCJJDBHE, T2 FLFFBCAGPJA, T3 BNEBJPBFPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x28C2390", Offset = "0x28C1190", VA = "0x1828C2390", Slot = "4")]
	public int CompareTo(global::NBGCJPKAOHK<T1, T2, T3> KJGIPMMHJFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x28C2490", Offset = "0x28C1290", VA = "0x1828C2490", Slot = "0")]
	public override bool Equals(object KJGIPMMHJFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x28C2780", Offset = "0x28C1580", VA = "0x1828C2780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x28C27F0", Offset = "0x28C15F0", VA = "0x1828C27F0", Slot = "3")]
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
	public T KIKNELACDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x511A30", Offset = "0x510830", VA = "0x180511A30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5AE660", Offset = "0x5AD460", VA = "0x1805AE660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float CEGEOHECEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xF3BC00", Offset = "0xF3AA00", VA = "0x180F3BC00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x30D2B90", Offset = "0x30D1990", VA = "0x1830D2B90")]
	public T HOHPJIMLJLC(float KONCOPNEPEO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x30D2730", Offset = "0x30D1530", VA = "0x1830D2730")]
	public T EBDPFBFAFGK(float KONCOPNEPEO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LBNJKNFGHEA(T HFCEPEKJIKJ, T GOPCHANOFFP, float KONCOPNEPEO);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46D21A0", Offset = "0x46D0FA0", VA = "0x1846D21A0", Slot = "4")]
	protected override float LBNJKNFGHEA(float HFCEPEKJIKJ, float GOPCHANOFFP, float KONCOPNEPEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46D2220", Offset = "0x46D1020", VA = "0x1846D2220")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46D3900", Offset = "0x46D2700", VA = "0x1846D3900", Slot = "4")]
	protected override Vector3 LBNJKNFGHEA(Vector3 HFCEPEKJIKJ, Vector3 GOPCHANOFFP, float KONCOPNEPEO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x46D39C0", Offset = "0x46D27C0", VA = "0x1846D39C0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x46BDE90", Offset = "0x46BCC90", VA = "0x1846BDE90", Slot = "4")]
	protected override Color LBNJKNFGHEA(Color HFCEPEKJIKJ, Color GOPCHANOFFP, float KONCOPNEPEO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x46D0D00", Offset = "0x46CFB00", VA = "0x1846D0D00")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class OKHKLJMEOGG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> GFPFLDDHOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> IPKPNFMPOLE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KBMMNCEALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1C76480", Offset = "0x1C75280", VA = "0x181C76480", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IPCFOPHIFJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EC0", Offset = "0x4E8CC0", VA = "0x1804E9EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> LBOCEFMJIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AA40", Offset = "0x1F79840", VA = "0x181F7AA40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> FPIIPPDPGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA3D70", Offset = "0x1FA2B70", VA = "0x181FA3D70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal BGHEIJJCJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x251A1A0", Offset = "0x2518FA0", VA = "0x18251A1A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x251A1D0", Offset = "0x2518FD0", VA = "0x18251A1D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2519A20", Offset = "0x2518820", VA = "0x182519A20", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x251A020", Offset = "0x2518E20", VA = "0x18251A020", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2519990", Offset = "0x2518790", VA = "0x182519990", Slot = "9")]
	public void Add(TKey MLBLCDKAFED, TVal LNPFAODMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25199F0", Offset = "0x25187F0", VA = "0x1825199F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> CCJNGIFKMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2519A80", Offset = "0x2518880", VA = "0x182519A80", Slot = "8")]
	public bool ContainsKey(TKey MLBLCDKAFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2519AB0", Offset = "0x25188B0", VA = "0x182519AB0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> CCJNGIFKMLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2519FC0", Offset = "0x2518DC0", VA = "0x182519FC0", Slot = "10")]
	public bool Remove(TKey MLBLCDKAFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2519FC0", Offset = "0x2518DC0", VA = "0x182519FC0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> CCJNGIFKMLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2518000", Offset = "0x2516E00", VA = "0x182518000", Slot = "11")]
	public bool TryGetValue(TKey MLBLCDKAFED, out TVal LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2519CF0", Offset = "0x2518AF0", VA = "0x182519CF0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2519B10", Offset = "0x2518910", VA = "0x182519B10", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GJIJDBFDOGB, int JFBDLGMCKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2519F90", Offset = "0x2518D90", VA = "0x182519F90")]
	public bool NCPOAGFPNBI(TVal MLBLCDKAFED, out TKey LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2519E00", Offset = "0x2518C00", VA = "0x182519E00")]
	private void JMCBBMPCMDH(TKey MLBLCDKAFED, TVal GKDBLEANOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2519F10", Offset = "0x2518D10", VA = "0x182519F10")]
	private void MAAHCJBCMKA(TKey MLBLCDKAFED, TVal GKDBLEANOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2519B70", Offset = "0x2518970", VA = "0x182519B70")]
	private bool FPHJCBDGPME(TKey MLBLCDKAFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x251A0C0", Offset = "0x2518EC0", VA = "0x18251A0C0")]
	public OKHKLJMEOGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class AMKIIAFKBOO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::AMKIIAFKBOO<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0xE33CA0", Offset = "0xE32AA0", VA = "0x180E33CA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1CE63F0", Offset = "0x1CE51F0", VA = "0x181CE63F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1CE67F0", Offset = "0x1CE55F0", VA = "0x181CE67F0")]
		public Enumerator(global::AMKIIAFKBOO<T> IPCKBHAMEMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5C70", Offset = "0x1CE4A70", VA = "0x181CE5C70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6240", Offset = "0x1CE5040", VA = "0x181CE6240", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5A70", Offset = "0x1CE4870", VA = "0x181CE5A70")]
		private void CCCOKGDKIAM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] NDMGLHHJNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int DDMFICCMNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int DDALJNIOFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int AKAHKICKIGA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KBMMNCEALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2350", Offset = "0x1CE1150", VA = "0x181CE2350")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T BGHEIJJCJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE24C0", Offset = "0x1CE12C0", VA = "0x181CE24C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2250", Offset = "0x1CE1050", VA = "0x181CE2250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2D20", Offset = "0x1CE1B20", VA = "0x181CE2D20")]
	public AMKIIAFKBOO(int IFGNJEPLBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1F30", Offset = "0x1CE0D30", VA = "0x181CE1F30")]
	public void EFHDBFNBKGH(T KONCOPNEPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1CE25D0", Offset = "0x1CE13D0", VA = "0x181CE25D0")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2510", Offset = "0x1CE1310", VA = "0x181CE2510")]
	public void LLLIGKCCOIM(int NJNIKNLNLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1CE29E0", Offset = "0x1CE17E0", VA = "0x181CE29E0")]
	public void OFMKEDMPLIA(T[] GJIJDBFDOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1CE19C0", Offset = "0x1CE07C0", VA = "0x181CE19C0")]
	public Enumerator CEAFABCEENE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2B30", Offset = "0x1CE1930", VA = "0x181CE2B30", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2B30", Offset = "0x1CE1930", VA = "0x181CE2B30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1CE1D80", Offset = "0x1CE0B80", VA = "0x181CE1D80")]
	private int DOGLHBPCJBA(int NCKDNOGOLME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1CE25A0", Offset = "0x1CE13A0", VA = "0x181CE25A0")]
	private int NAICCHOIALL(int NCKDNOGOLME)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class CNMCCOBBFFK
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	protected CNMCCOBBFFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class JLNGIMFHCFM<T> : CNMCCOBBFFK
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct IDCBHJDMCFN
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum IDMGEOEAJIJ
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
		public IDMGEOEAJIJ FKELJAJFEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T ILFANDGNKPL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int FPLJCJDLFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool MPAJDCILHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool JIKKLFJBJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> LNCMFLFGKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<IDCBHJDMCFN> IIAIAHHBECK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KKPKFJBJMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x25B4D20", Offset = "0x25B3B20", VA = "0x1825B4D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25B54A0", Offset = "0x25B42A0", VA = "0x1825B54A0")]
	protected JLNGIMFHCFM(bool JIKKLFJBJIL, bool MPAJDCILHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x25B4EE0", Offset = "0x25B3CE0", VA = "0x1825B4EE0")]
	protected bool HGGCLOHDECM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x25B53C0", Offset = "0x25B41C0", VA = "0x1825B53C0")]
	protected void PELPNEGDJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x25B50E0", Offset = "0x25B3EE0", VA = "0x1825B50E0")]
	protected void KPIHBNLEAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1F15320", Offset = "0x1F14120", VA = "0x181F15320")]
	private static void CFALBPLEGEH<U>(ref List<U> FPCGFNEPLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x25B4D60", Offset = "0x25B3B60", VA = "0x1825B4D60", Slot = "4")]
	public void EFHDBFNBKGH(T ILFANDGNKPL, bool NEEIEIJGGJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x25B4F80", Offset = "0x25B3D80", VA = "0x1825B4F80", Slot = "5")]
	public void KGKIHAGANBK(T ILFANDGNKPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x25B5290", Offset = "0x25B4090", VA = "0x1825B5290")]
	public void NDPIBEPLAFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class MHDMOBBLODF : global::JLNGIMFHCFM<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x46D2D80", Offset = "0x46D1B80", VA = "0x1846D2D80")]
	public MHDMOBBLODF(bool JIKKLFJBJIL = false, bool MPAJDCILHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46D2BC0", Offset = "0x46D19C0", VA = "0x1846D2BC0")]
	public void KPCBKAEDGBJ()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x46D2B60", Offset = "0x46D1960", VA = "0x1846D2B60")]
	public static MHDMOBBLODF FJCDFADIHBE(MHDMOBBLODF GIFBHINKOEP, Action ILFANDGNKPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x46D2B00", Offset = "0x46D1900", VA = "0x1846D2B00")]
	public static MHDMOBBLODF EFJAPGJFBGL(MHDMOBBLODF GIFBHINKOEP, Action ILFANDGNKPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GACDHNMCLIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFHDBFNBKGH(Action<T> ILFANDGNKPL, bool NEEIEIJGGJA = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGKIHAGANBK(Action<T> ILFANDGNKPL);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class KLOCFKFOFMJ<T> : global::JLNGIMFHCFM<Action<T>>, global::GACDHNMCLIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2180", Offset = "0x1FA0F80", VA = "0x181FA2180")]
	public KLOCFKFOFMJ(bool JIKKLFJBJIL = false, bool MPAJDCILHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x392CF80", Offset = "0x392BD80", VA = "0x18392CF80")]
	public void KPCBKAEDGBJ(T KONCOPNEPEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x21B36E0", Offset = "0x21B24E0", VA = "0x1821B36E0")]
	public static global::KLOCFKFOFMJ<T> FJCDFADIHBE(global::KLOCFKFOFMJ<T> GIFBHINKOEP, Action<T> ILFANDGNKPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x21B3640", Offset = "0x21B2440", VA = "0x1821B3640")]
	public static global::KLOCFKFOFMJ<T> EFJAPGJFBGL(global::KLOCFKFOFMJ<T> GIFBHINKOEP, Action<T> ILFANDGNKPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FFINKHCKFJI<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class IGPDEBHHLJI<T, U> : global::JLNGIMFHCFM<Action<T, U>>, global::FFINKHCKFJI<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2180", Offset = "0x1FA0F80", VA = "0x181FA2180")]
	public IGPDEBHHLJI(bool JIKKLFJBJIL = false, bool MPAJDCILHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3494C70", Offset = "0x3493A70", VA = "0x183494C70")]
	public void KPCBKAEDGBJ(T KONCOPNEPEO, U LAAJMJAMEBL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x21B36E0", Offset = "0x21B24E0", VA = "0x1821B36E0")]
	public static global::IGPDEBHHLJI<T, U> FJCDFADIHBE(global::IGPDEBHHLJI<T, U> GIFBHINKOEP, Action<T, U> ILFANDGNKPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x21B3640", Offset = "0x21B2440", VA = "0x1821B3640")]
	public static global::IGPDEBHHLJI<T, U> EFJAPGJFBGL(global::IGPDEBHHLJI<T, U> GIFBHINKOEP, Action<T, U> ILFANDGNKPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class EICCGGFJPJJ<T, U, V> : global::JLNGIMFHCFM<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2180", Offset = "0x1FA0F80", VA = "0x181FA2180")]
	public EICCGGFJPJJ(bool JIKKLFJBJIL = false, bool MPAJDCILHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38E39E0", Offset = "0x38E27E0", VA = "0x1838E39E0")]
	public void KPCBKAEDGBJ(T KONCOPNEPEO, U LAAJMJAMEBL, V KOPJGCADJNN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x21B36E0", Offset = "0x21B24E0", VA = "0x1821B36E0")]
	public static global::EICCGGFJPJJ<T, U, V> FJCDFADIHBE(global::EICCGGFJPJJ<T, U, V> GIFBHINKOEP, Action<T, U, V> ILFANDGNKPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x21B3640", Offset = "0x21B2440", VA = "0x1821B3640")]
	public static global::EICCGGFJPJJ<T, U, V> EFJAPGJFBGL(global::EICCGGFJPJJ<T, U, V> GIFBHINKOEP, Action<T, U, V> ILFANDGNKPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IGHMDKJGIPM<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PMHFHJPAICD<T, U, V, W> : global::JLNGIMFHCFM<Action<T, U, V, W>>, global::IGHMDKJGIPM<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2180", Offset = "0x1FA0F80", VA = "0x181FA2180")]
	public PMHFHJPAICD(bool JIKKLFJBJIL = false, bool MPAJDCILHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x21B4C80", Offset = "0x21B3A80", VA = "0x1821B4C80")]
	public void KPCBKAEDGBJ(T KONCOPNEPEO, U LAAJMJAMEBL, V KOPJGCADJNN, W JBAGFJNJFHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x21B36E0", Offset = "0x21B24E0", VA = "0x1821B36E0")]
	public static global::PMHFHJPAICD<T, U, V, W> FJCDFADIHBE(global::PMHFHJPAICD<T, U, V, W> GIFBHINKOEP, Action<T, U, V, W> ILFANDGNKPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x21B3640", Offset = "0x21B2440", VA = "0x1821B3640")]
	public static global::PMHFHJPAICD<T, U, V, W> EFJAPGJFBGL(global::PMHFHJPAICD<T, U, V, W> GIFBHINKOEP, Action<T, U, V, W> ILFANDGNKPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class IILBGMFFNAC<T, U, V, W, X> : global::JLNGIMFHCFM<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2180", Offset = "0x1FA0F80", VA = "0x181FA2180")]
	public IILBGMFFNAC(bool JIKKLFJBJIL = false, bool MPAJDCILHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x349ADF0", Offset = "0x3499BF0", VA = "0x18349ADF0")]
	public void KPCBKAEDGBJ(T KONCOPNEPEO, U LAAJMJAMEBL, V KOPJGCADJNN, W JBAGFJNJFHJ, X EDNAGLDPNGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x21B36E0", Offset = "0x21B24E0", VA = "0x1821B36E0")]
	public static global::IILBGMFFNAC<T, U, V, W, X> FJCDFADIHBE(global::IILBGMFFNAC<T, U, V, W, X> GIFBHINKOEP, Action<T, U, V, W, X> ILFANDGNKPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x21B3640", Offset = "0x21B2440", VA = "0x1821B3640")]
	public static global::IILBGMFFNAC<T, U, V, W, X> EFJAPGJFBGL(global::IILBGMFFNAC<T, U, V, W, X> GIFBHINKOEP, Action<T, U, V, W, X> ILFANDGNKPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class IGFDEIJHBGL<T, U, V, W, X, Y> : global::JLNGIMFHCFM<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2180", Offset = "0x1FA0F80", VA = "0x181FA2180")]
	public IGFDEIJHBGL(bool JIKKLFJBJIL = false, bool MPAJDCILHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3494110", Offset = "0x3492F10", VA = "0x183494110")]
	public void KPCBKAEDGBJ(T KONCOPNEPEO, U LAAJMJAMEBL, V KOPJGCADJNN, W JBAGFJNJFHJ, X EDNAGLDPNGD, Y HJDKKMBJJBB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x21B36E0", Offset = "0x21B24E0", VA = "0x1821B36E0")]
	public static global::IGFDEIJHBGL<T, U, V, W, X, Y> FJCDFADIHBE(global::IGFDEIJHBGL<T, U, V, W, X, Y> GIFBHINKOEP, Action<T, U, V, W, X, Y> ILFANDGNKPL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x21B3640", Offset = "0x21B2440", VA = "0x1821B3640")]
	public static global::IGFDEIJHBGL<T, U, V, W, X, Y> EFJAPGJFBGL(global::IGFDEIJHBGL<T, U, V, W, X, Y> GIFBHINKOEP, Action<T, U, V, W, X, Y> ILFANDGNKPL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct AFBEHDBBDNN
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class LLJINMONAIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct EDJCDBKIOKM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly global::LLJINMONAIF<T> NMLAPJGBDEF;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public T KIKNELACDKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2FBF9C0", Offset = "0x2FBE7C0", VA = "0x182FBF9C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF9E0", Offset = "0x2FBE7E0", VA = "0x182FBF9E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5B72A0", Offset = "0x5B60A0", VA = "0x1805B72A0")]
		public EDJCDBKIOKM(global::LLJINMONAIF<T> NMLAPJGBDEF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim DAIKDNCCNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T BNGAKIFONDA;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA400", Offset = "0x2FC9200", VA = "0x182FCA400")]
	public LLJINMONAIF(in T BNGAKIFONDA, int MBKHBIFMCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA3D0", Offset = "0x2FC91D0", VA = "0x182FCA3D0")]
	public LLJINMONAIF(in T BNGAKIFONDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2FCA390", Offset = "0x2FC9190", VA = "0x182FCA390")]
	public EDJCDBKIOKM GGHDOBCMCNF()
	{
		return default(EDJCDBKIOKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DHNBNAELEME
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x46D1A90", Offset = "0x46D0890", VA = "0x1846D1A90")]
	public static global::LLJINMONAIF<AFBEHDBBDNN> PCGFCMPJOEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1CBDAA0", Offset = "0x1CBC8A0", VA = "0x181CBDAA0")]
	public static global::LLJINMONAIF<T> PCGFCMPJOEI<T>(in T BNGAKIFONDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HOELAHEDGOH<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate bool BFFPFJANMAA(global::HOELAHEDGOH<T> JBDLAIAOJCN);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EEOGCBMCKLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public global::HOELAHEDGOH<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public EEOGCBMCKLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3972030", Offset = "0x3970E30", VA = "0x183972030")]
		internal bool <FindNode>b__0(global::HOELAHEDGOH<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public T FDCFFLMLENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LinkedList<global::HOELAHEDGOH<T>> PAFPIANJDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public global::HOELAHEDGOH<T> LCKGMENEALP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::HOELAHEDGOH<T> PKNMLCMPIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x53C130", Offset = "0x53AF30", VA = "0x18053C130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3978400", Offset = "0x3977200", VA = "0x183978400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool NGBIEAMDCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x39787A0", Offset = "0x39775A0", VA = "0x1839787A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JNFKPBFOEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3977930", Offset = "0x3976730", VA = "0x183977930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::HOELAHEDGOH<T> KAKHKOLAJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3979200", Offset = "0x3978000", VA = "0x183979200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3979EA0", Offset = "0x3978CA0", VA = "0x183979EA0")]
	public HOELAHEDGOH(T CPODCKHHPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3979C90", Offset = "0x3978A90", VA = "0x183979C90")]
	public global::HOELAHEDGOH<T> PIBOPDNDBMF(T KBGHAMLGKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3979900", Offset = "0x3978700", VA = "0x183979900")]
	public global::HOELAHEDGOH<T> OIPHMAAGFOL(T IGDDCHJJBHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3978C90", Offset = "0x3977A90", VA = "0x183978C90")]
	public global::HOELAHEDGOH<T> KGKIHAGANBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3978D40", Offset = "0x3977B40", VA = "0x183978D40")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3978690", Offset = "0x3977490", VA = "0x183978690")]
	public global::HOELAHEDGOH<T> DGHAPFFIEKG(T KIJCEOMCPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3979280", Offset = "0x3978080", VA = "0x183979280")]
	public static void OIBPLNMLJMI(global::HOELAHEDGOH<T> NBHOFDHDJCH, BFFPFJANMAA BAGAEOPOAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F11AD0", Offset = "0x1F108D0", VA = "0x181F11AD0")]
	public static void OIBPLNMLJMI<A>(global::HOELAHEDGOH<T> NBHOFDHDJCH, Func<global::HOELAHEDGOH<T>, A, bool> BAGAEOPOAJP, A DHMPJLILGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3977EC0", Offset = "0x3976CC0", VA = "0x183977EC0")]
	public static string AOCHHPIFBKK(global::HOELAHEDGOH<T> NBHOFDHDJCH, int CLAMJJFEMKM = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x39789E0", Offset = "0x39777E0", VA = "0x1839789E0")]
	public static global::HOELAHEDGOH<T> JFNAMPOEGCA(global::HOELAHEDGOH<T> NBHOFDHDJCH, T NLALABGOPAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class GBBKGDFAJCN<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate int AHHLHOHIIHN(TKey MLBLCDKAFED, TVal LNPFAODMJGO);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class JGMPLEDJMJG
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey FCPKEJOIGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal KIKNELACDKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x60B5E0", Offset = "0x60A3E0", VA = "0x18060B5E0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x60B600", Offset = "0x60A400", VA = "0x18060B600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int GPDBHLFLLEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5C8750", Offset = "0x5C7550", VA = "0x1805C8750")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5C8780", Offset = "0x5C7580", VA = "0x1805C8780")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime PGDKIIPEMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4EBDF0", Offset = "0x4EABF0", VA = "0x1804EBDF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x102D060", Offset = "0x102BE60", VA = "0x18102D060")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x32B2720", Offset = "0x32B1520", VA = "0x1832B2720")]
		public JGMPLEDJMJG(TKey MLBLCDKAFED, TVal GKDBLEANOLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const int HPJIGCPLEGD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Dictionary<TKey, LinkedListNode<JGMPLEDJMJG>> OFNKPCDCPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LinkedList<JGMPLEDJMJG> NAGGJOPNEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly AHHLHOHIIHN PHLMDKHOJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly TimeSpan GPONNGANBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly BDMLDGDKBCG OGLDMFNPGIE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int AAJOLDHJMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B60", Offset = "0x5D0960", VA = "0x1805D1B60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool MKGHPPKCEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x32A7FD0", Offset = "0x32A6DD0", VA = "0x1832A7FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int IFIMGIHNFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B70", Offset = "0x5D0970", VA = "0x1805D1B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C6870", Offset = "0x5C5670", VA = "0x1805C6870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey BGHEIJJCJJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x32A7B40", Offset = "0x32A6940", VA = "0x1832A7B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x32A8AE0", Offset = "0x32A78E0", VA = "0x1832A8AE0")]
	public GBBKGDFAJCN(int IFGNJEPLBPF, [Optional] AHHLHOHIIHN PHLMDKHOJGM, [Optional] IEqualityComparer<TKey> BLDNJOCOJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x32A8BB0", Offset = "0x32A79B0", VA = "0x1832A8BB0")]
	public GBBKGDFAJCN(int IFGNJEPLBPF, AHHLHOHIIHN PHLMDKHOJGM, TimeSpan GPONNGANBKP, [Optional] IEqualityComparer<TKey> BLDNJOCOJJK, [Optional] BDMLDGDKBCG OGLDMFNPGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x32A7CF0", Offset = "0x32A6AF0", VA = "0x1832A7CF0")]
	public void KCPOHJBONHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x32A79C0", Offset = "0x32A67C0", VA = "0x1832A79C0")]
	public void FEALLIJDLLO(TKey MLBLCDKAFED, TVal LNPFAODMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x32A7E50", Offset = "0x32A6C50", VA = "0x1832A7E50")]
	public bool KGKIHAGANBK(TKey MLBLCDKAFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x32A83A0", Offset = "0x32A71A0", VA = "0x1832A83A0")]
	public bool NCPOAGFPNBI(TKey HEPBIBHIOCP, out TVal LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x32A8650", Offset = "0x32A7450", VA = "0x1832A8650")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x32A7B70", Offset = "0x32A6970", VA = "0x1832A7B70")]
	private bool JJMBABMBADP(JGMPLEDJMJG PJCEHLLAJAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x32A74C0", Offset = "0x32A62C0", VA = "0x1832A74C0")]
	private void BIIOIHDFKLM(LinkedListNode<JGMPLEDJMJG> CGEDBGJKJHK, TVal CODKHPDCHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x32A86D0", Offset = "0x32A74D0", VA = "0x1832A86D0")]
	private void OJLFPNOENOE(TKey MLBLCDKAFED, TVal LNPFAODMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x32A8060", Offset = "0x32A6E60", VA = "0x1832A8060")]
	private void NAIIMEEIHLG(JGMPLEDJMJG PJCEHLLAJAM, TVal CODKHPDCHFF, int AACJCLDLDON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class KHMBPCFGLKH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<T> FPCGFNEPLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private HashSet<T> PAIPHEKGBLN;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int KBMMNCEALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1C76480", Offset = "0x1C75280", VA = "0x181C76480", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool IPCFOPHIFJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EC0", Offset = "0x4E8CC0", VA = "0x1804E9EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T BGHEIJJCJJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3231280", Offset = "0x3230080", VA = "0x183231280", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3231370", Offset = "0x3230170", VA = "0x183231370", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x30A7B50", Offset = "0x30A6950", VA = "0x1830A7B50", Slot = "11")]
	public void Add(T CCJNGIFKMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3230E50", Offset = "0x322FC50", VA = "0x183230E50")]
	public bool JIEAHNLCMGG(T CCJNGIFKMLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3231090", Offset = "0x322FE90", VA = "0x183231090", Slot = "15")]
	public bool Remove(T CCJNGIFKMLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2517F50", Offset = "0x2516D50", VA = "0x182517F50", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E700", Offset = "0x2A7D500", VA = "0x182A7E700", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3230B80", Offset = "0x322F980", VA = "0x183230B80", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F6BAF0", Offset = "0x1F6A8F0", VA = "0x181F6BAF0", Slot = "13")]
	public bool Contains(T CCJNGIFKMLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3230BE0", Offset = "0x322F9E0", VA = "0x183230BE0", Slot = "14")]
	public void CopyTo(T[] GJIJDBFDOGB, int JFBDLGMCKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x251A1A0", Offset = "0x2518FA0", VA = "0x18251A1A0", Slot = "6")]
	public int IndexOf(T CCJNGIFKMLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3230CE0", Offset = "0x322FAE0", VA = "0x183230CE0", Slot = "7")]
	public void Insert(int NCKDNOGOLME, T CCJNGIFKMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3230EF0", Offset = "0x322FCF0", VA = "0x183230EF0", Slot = "8")]
	public void RemoveAt(int NCKDNOGOLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x32311A0", Offset = "0x322FFA0", VA = "0x1832311A0")]
	public KHMBPCFGLKH()
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
			[Cpp2IlInjected.Address(RVA = "0x1EEF2A0", Offset = "0x1EEE0A0", VA = "0x181EEF2A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x46D3240", Offset = "0x46D2040", VA = "0x1846D3240")]
		public SerializedGuid(in Guid COJIELKHKIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x46D2FD0", Offset = "0x46D1DD0", VA = "0x1846D2FD0")]
		public static SerializedGuid FCCBLHPHFKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x46D30F0", Offset = "0x46D1EF0", VA = "0x1846D30F0")]
		public static SerializedGuid NBJJPGMPJOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x46D3060", Offset = "0x46D1E60", VA = "0x1846D3060")]
		public bool JBMBDGFCKED()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x46D3210", Offset = "0x46D2010", VA = "0x1846D3210", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x46D3170", Offset = "0x46D1F70", VA = "0x1846D3170", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x46D2E50", Offset = "0x46D1C50", VA = "0x1846D2E50", Slot = "7")]
		public bool Equals(SerializedGuid KJGIPMMHJFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x46D2EF0", Offset = "0x46D1CF0", VA = "0x1846D2EF0", Slot = "0")]
		public override bool Equals(object OBJNDDPFMFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x46D3050", Offset = "0x46D1E50", VA = "0x1846D3050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x46D2E20", Offset = "0x46D1C20", VA = "0x1846D2E20", Slot = "6")]
		public int CompareTo(SerializedGuid KJGIPMMHJFB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class DHLDDECEGDJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Type BNLCKFOPLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string ICGJAGBDAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool AGJINAHNHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool BDFOAOLKIGF;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x46D1A20", Offset = "0x46D0820", VA = "0x1846D1A20")]
	public DHLDDECEGDJ(Type FHAMPOBJGIO, string IKADGCMACAP, bool JNMPADLMLPN = false, bool HCCDGLJKFBD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface MKMCPGAEKID<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T KIKNELACDKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool EBFBJBBBKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MKMCPGAEKID<T> HFLJJOGPMHG(Action<T> PBEJOEHFCNH);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MKMCPGAEKID<T> AMOHIBFBLKN(Action<T> PBEJOEHFCNH);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BOGONLBMIHE<T> : global::MKMCPGAEKID<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private global::IGPDEBHHLJI<T, T> FGDBIFHNCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private global::KLOCFKFOFMJ<T> KIHJCGMLNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private global::KLOCFKFOFMJ<string> DGPNDNGHLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string DKOKBNBNGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private T NCEOJLFBEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool JNAPHMOHBFK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T KIKNELACDKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x511A30", Offset = "0x510830", VA = "0x180511A30", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1FA02D0", Offset = "0x1F9F0D0", VA = "0x181FA02D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool EBFBJBBBKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5C6630", Offset = "0x5C5430", VA = "0x1805C6630", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1FA01A0", Offset = "0x1F9EFA0", VA = "0x181FA01A0")]
	private void HCCCOANOFLH(T HFCKLNDJMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0240", Offset = "0x1F9F040", VA = "0x181FA0240", Slot = "4")]
	public global::MKMCPGAEKID<T> HFLJJOGPMHG(Action<T> COGIIAAOLFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0150", Offset = "0x1F9EF50", VA = "0x181FA0150", Slot = "5")]
	public global::MKMCPGAEKID<T> AMOHIBFBLKN(Action<T> PBEJOEHFCNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0300", Offset = "0x1F9F100", VA = "0x181FA0300")]
	public BOGONLBMIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class MHHNAOAGJBC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class EDFFIKMIECM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public global::MKMCPGAEKID<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public global::PHMCHJKELPF<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public EDFFIKMIECM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2FBF920", Offset = "0x2FBE720", VA = "0x182FBF920")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x267BE00", Offset = "0x267AC00", VA = "0x18267BE00")]
	public static global::DIPKCKEGDMM<T> LPEJEDDFLHH<T>(this global::MKMCPGAEKID<T> FFDPAOAOJAH, Action<T> GMDMDOLDPBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class BDMLDGDKBCG
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class GCBJFJDACIK : BDMLDGDKBCG
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static BDMLDGDKBCG OPFHHPKJOHK
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x46D2260", Offset = "0x46D1060", VA = "0x1846D2260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime GOHBMJCPLBM
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x46D22C0", Offset = "0x46D10C0", VA = "0x1846D22C0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x46D23B0", Offset = "0x46D11B0", VA = "0x1846D23B0")]
		public GCBJFJDACIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static BDMLDGDKBCG GPEBECKEBHO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static BDMLDGDKBCG ACGGIODHIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x46D0B80", Offset = "0x46CF980", VA = "0x1846D0B80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime GOHBMJCPLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
	protected BDMLDGDKBCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MJLLOELKPBN : global::HIPGAFMBGLO<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x46D2DE0", Offset = "0x46D1BE0", VA = "0x1846D2DE0")]
	public MJLLOELKPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class HIPGAFMBGLO<T> : global::IHLGAILMJEK<T>, IMGLNHLMEAD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> NJHFKHILFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::DIPKCKEGDMM<T> OAONOBHIPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private CFGFLPOGNPH EEMPBHMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x18193A0", Offset = "0x18181A0", VA = "0x1818193A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x39721B0", Offset = "0x3970FB0", VA = "0x1839721B0")]
	public HIPGAFMBGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BLLNAHLBMHE<T> : global::IHLGAILMJEK<T>, IMGLNHLMEAD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> NJHFKHILFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::DIPKCKEGDMM<T> OAONOBHIPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private CFGFLPOGNPH EEMPBHMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x18193A0", Offset = "0x18181A0", VA = "0x1818193A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DD10", Offset = "0x1F9CB10", VA = "0x181F9DD10")]
	public BLLNAHLBMHE(Exception KCOCMOEHLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface IMGLNHLMEAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	CFGFLPOGNPH OAONOBHIPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IHLGAILMJEK<T> : IMGLNHLMEAD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> NJHFKHILFEL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::DIPKCKEGDMM<T> OAONOBHIPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class AFCKOFGOHFN<TTask, T> : global::IHLGAILMJEK<T>, IMGLNHLMEAD, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class PAFODLBMPGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public global::AFCKOFGOHFN<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public PAFODLBMPGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static bool BGLKKMHDJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Task<T> BJKAOLLGFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly CancellationTokenSource DNANBOOHFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool HNGENBNLPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private SynchronizationContext HHADGPHPFHO;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> NJHFKHILFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::DIPKCKEGDMM<T> OAONOBHIPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private CFGFLPOGNPH EEMPBHMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1E50260", Offset = "0x1E4F060", VA = "0x181E50260", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool KCOLNJCEOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5AE7A0", Offset = "0x5AD5A0", VA = "0x1805AE7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3414CE0", Offset = "0x3413AE0", VA = "0x183414CE0")]
	static AFCKOFGOHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3414E50", Offset = "0x3413C50", VA = "0x183414E50")]
	protected AFCKOFGOHFN(TTask BJKAOLLGFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3414A80", Offset = "0x3413880", VA = "0x183414A80", Slot = "1")]
	~AFCKOFGOHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x34149B0", Offset = "0x34137B0", VA = "0x1834149B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3414840", Offset = "0x3413640", VA = "0x183414840")]
	private void DGIEOJPLMLL(bool BFCOBHAIAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T ENILOIICCEA(TTask PHFBJOMCAGO);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void HIGKAKBCAAL();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3414B20", Offset = "0x3413920", VA = "0x183414B20")]
	[CompilerGenerated]
	private void JOEBCOCEMCA(object ONJJNJCJFKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class JOMNGFNEFEE<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal class DOIJJNNPBNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TNode MGLIJCBDEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public TNode EBLJNNNHKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CIDAEGFEOEI MKLINLGDHPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public List<CIDAEGFEOEI> FMJHIJPMIOE;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		public DOIJJNNPBNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	internal struct CIDAEGFEOEI : IComparable<CIDAEGFEOEI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public int PBJPHIMOIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public TClaimant DIJNFNHJBHG;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4F1CF0", Offset = "0x4F0AF0", VA = "0x1804F1CF0")]
		public CIDAEGFEOEI(int PBJPHIMOIPA, TClaimant DIJNFNHJBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x32208B0", Offset = "0x321F6B0", VA = "0x1832208B0")]
		public bool AFANLBELOHD(in CIDAEGFEOEI KJGIPMMHJFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3220920", Offset = "0x321F720", VA = "0x183220920")]
		public bool GBCANLFENAO(in CIDAEGFEOEI KJGIPMMHJFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3220910", Offset = "0x321F710", VA = "0x183220910", Slot = "4")]
		public int CompareTo(CIDAEGFEOEI KJGIPMMHJFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3220930", Offset = "0x321F730", VA = "0x183220930", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum OLPDLLHKAJO
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class EGLDJLKOEKM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public global::JOMNGFNEFEE<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1C6E9B0", Offset = "0x1C6D7B0", VA = "0x181C6E9B0")]
		[DebuggerHidden]
		public EGLDJLKOEKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3220A20", Offset = "0x321F820", VA = "0x183220A20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3220BE0", Offset = "0x321F9E0", VA = "0x183220BE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3220B00", Offset = "0x321F900", VA = "0x183220B00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x182B8E0", Offset = "0x182A6E0", VA = "0x18182B8E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly global::DEFFCLJDCKC<DOIJJNNPBNP> IFOCCEHGCGO;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly global::DEFFCLJDCKC<List<CIDAEGFEOEI>> KKJPAMHFCJH;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int HKBOHPMLAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	internal readonly Dictionary<TClaimant, TNode> IPOBJPLBHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	internal readonly Dictionary<TNode, DOIJJNNPBNP> CIOPCCCGFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HashSet<TNode> ADPFCKDCABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private OLPDLLHKAJO CFLMMDNLBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool JKLNMPMAAPM;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode JABPNEFOGLC(TNode JBDLAIAOJCN);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void KMLAADCDBJI(TNode JBDLAIAOJCN, TClaimant NHAACOODHHI, TClaimant NPKNHLNOAMN);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x32289B0", Offset = "0x32277B0", VA = "0x1832289B0")]
	public JOMNGFNEFEE(OLPDLLHKAJO CFLMMDNLBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3227A50", Offset = "0x3226850", VA = "0x183227A50")]
	public void FGPANOKFEJM(TNode JBDLAIAOJCN, TNode KIJCEOMCPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3227BD0", Offset = "0x32269D0", VA = "0x183227BD0")]
	public void HGLDHMHODKH(TClaimant DIJNFNHJBHG, TNode HICINDEBGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x32277C0", Offset = "0x32265C0", VA = "0x1832277C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3227120", Offset = "0x3225F20", VA = "0x183227120")]
	private void AALELLDBLKH(TClaimant DIJNFNHJBHG, TNode FOEAHHCOAAM, TNode HICINDEBGIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x32281D0", Offset = "0x3226FD0", VA = "0x1832281D0")]
	private int KKIBGJPCKLF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3227380", Offset = "0x3226180", VA = "0x183227380")]
	private void DBCPDONAIFC(TClaimant DIJNFNHJBHG, TNode ECFFENNAONM, TNode PPJGEMKDNKN, int ICONKMAIMIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3228480", Offset = "0x3227280", VA = "0x183228480")]
	private void PEDGDPNIHFJ(CIDAEGFEOEI ALPMBCCCOPE, DOIJJNNPBNP LGBIANFJCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x32285E0", Offset = "0x32273E0", VA = "0x1832285E0")]
	private void PLLIIFMCFMP(TClaimant DIJNFNHJBHG, TNode ECFFENNAONM, TNode PPJGEMKDNKN, int ICONKMAIMIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3228380", Offset = "0x3227180", VA = "0x183228380")]
	private void MIOKOFEPADC(CIDAEGFEOEI ALPMBCCCOPE, TNode JBDLAIAOJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3227AD0", Offset = "0x32268D0", VA = "0x183227AD0")]
	private void GCIEAOIGHLP(CIDAEGFEOEI ALPMBCCCOPE, DOIJJNNPBNP LGBIANFJCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3228240", Offset = "0x3227040", VA = "0x183228240")]
	private void MGMMMFGGMLH(DOIJJNNPBNP LGBIANFJCLH, bool GJBEEPBKJEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3227CD0", Offset = "0x3226AD0", VA = "0x183227CD0")]
	private void HJENIDAGPMD(DOIJJNNPBNP LGBIANFJCLH, TNode KIJCEOMCPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3228510", Offset = "0x3227310", VA = "0x183228510")]
	[IteratorStateMachine(typeof(global::JOMNGFNEFEE<, >.EGLDJLKOEKM))]
	private IEnumerable<TNode> PEJNNGEBFNP(TNode ECFFENNAONM, TNode PPJGEMKDNKN, bool IFPOFGMKPPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3228110", Offset = "0x3226F10", VA = "0x183228110")]
	private DOIJJNNPBNP IACHPNJJMBA(TNode JBDLAIAOJCN, TNode EBLJNNNHKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3227630", Offset = "0x3226430", VA = "0x183227630")]
	private DOIJJNNPBNP DOBDCCHGFGC(TNode JBDLAIAOJCN, TNode EBLJNNNHKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x32271C0", Offset = "0x3225FC0", VA = "0x1832271C0")]
	private void DANDIMMOMCO(DOIJJNNPBNP LGBIANFJCLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class BBFMHPAIFJG<T> : IEnumerable<global::BBFMHPAIFJG<T>.BKAOCPLDEOF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct BKAOCPLDEOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public T LNPFAODMJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int NCKDNOGOLME;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class GAIFEDLGPAE : IEnumerator<BKAOCPLDEOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private global::BBFMHPAIFJG<T> JEJMAGDGHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int NCKDNOGOLME;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x26D0210", Offset = "0x26CF010", VA = "0x1826D0210", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public BKAOCPLDEOF GBJFNDIAHCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x2A88D40", Offset = "0x2A87B40", VA = "0x182A88D40", Slot = "4")]
			get
			{
				return default(BKAOCPLDEOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7A9250", Offset = "0x7A8050", VA = "0x1807A9250")]
		public GAIFEDLGPAE(global::BBFMHPAIFJG<T> JEJMAGDGHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2A88CB0", Offset = "0x2A87AB0", VA = "0x182A88CB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x63D9F0", Offset = "0x63C7F0", VA = "0x18063D9F0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x741220", Offset = "0x740020", VA = "0x180741220", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct JKBODNPDOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public bool COGJJKAEBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public T LNPFAODMJGO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int DHAFHIGMKEG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<T, int> DJEJOJDPOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private JKBODNPDOFH[] MGMJPICHNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private int FNKIIBMIAEI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int KBMMNCEALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1F7AA40", Offset = "0x1F79840", VA = "0x181F7AA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D4E0", Offset = "0x2A7C2E0", VA = "0x182A7D4E0")]
	public static global::BBFMHPAIFJG<T> BLCKNKHLNBM(BKAOCPLDEOF[] NOIEJAENMIF, bool LNFJONGCMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DE00", Offset = "0x2A7CC00", VA = "0x182A7DE00")]
	public BBFMHPAIFJG(int IFGNJEPLBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DD40", Offset = "0x2A7CB40", VA = "0x182A7DD40")]
	public int MOBOMDGIMKA(T LNPFAODMJGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DC80", Offset = "0x2A7CA80", VA = "0x182A7DC80")]
	public T LPEJEDDFLHH(int NCKDNOGOLME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DC60", Offset = "0x2A7CA60", VA = "0x182A7DC60")]
	public bool JIEAHNLCMGG(T LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DA30", Offset = "0x2A7C830", VA = "0x182A7DA30")]
	public bool JIEAHNLCMGG(T LNPFAODMJGO, int NCKDNOGOLME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D8C0", Offset = "0x2A7C6C0", VA = "0x182A7D8C0")]
	public BKAOCPLDEOF[] HPHDCOLKKOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DCF0", Offset = "0x2A7CAF0", VA = "0x182A7DCF0")]
	private int MBOLFIAJJJA(int DDMFICCMNLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DD90", Offset = "0x2A7CB90", VA = "0x182A7DD90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DD90", Offset = "0x2A7CB90", VA = "0x182A7DD90", Slot = "4")]
	private IEnumerator<BKAOCPLDEOF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class DEFFCLJDCKC<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Stack<T> HNHOCENGEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly List<T> HFAGKJNBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly int FIJJCPEEHKP;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x225A9A0", Offset = "0x22597A0", VA = "0x18225A9A0")]
	public static global::DEFFCLJDCKC<T> HHKPEFAFGJL(int IFGNJEPLBPF = 0, int FIJJCPEEHKP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x225ACF0", Offset = "0x2259AF0", VA = "0x18225ACF0")]
	public DEFFCLJDCKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x225AD30", Offset = "0x2259B30", VA = "0x18225AD30")]
	public DEFFCLJDCKC(int IFGNJEPLBPF, int FIJJCPEEHKP = int.MaxValue, bool EMHGEOCOCLB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x225A6A0", Offset = "0x22594A0", VA = "0x18225A6A0")]
	public T ANCKAGGEMAB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x225A7D0", Offset = "0x22595D0", VA = "0x18225A7D0")]
	public void BGNKEDALLHD(T LNPFAODMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x225AA70", Offset = "0x2259870", VA = "0x18225AA70")]
	private void LODJEOCCEOH(T LNPFAODMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x225A680", Offset = "0x2259480", VA = "0x18225A680")]
	private void AEEJGGGDFND(T LNPFAODMJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x225A890", Offset = "0x2259690", VA = "0x18225A890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x225AB30", Offset = "0x2259930", VA = "0x18225AB30")]
	private void NMKBGOILPGC(IEnumerable<T> OHOGMBOEBEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class KPGPNOCFHDE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<int, T> AEEBENOMIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private T JALCHKBFLBM;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public virtual T KLACMLDBIME
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4E91C0", Offset = "0x4E7FC0", VA = "0x1804E91C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4E94A0", Offset = "0x4E82A0", VA = "0x1804E94A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x392EBB0", Offset = "0x392D9B0", VA = "0x18392EBB0")]
	public bool OJLFPNOENOE(T LNPFAODMJGO, int PBJPHIMOIPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x392EAF0", Offset = "0x392D8F0", VA = "0x18392EAF0")]
	public bool NGDJPPKILJF(int PBJPHIMOIPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x392E830", Offset = "0x392D630", VA = "0x18392E830")]
	public T AGBIHJCOJAP(int FLMKFDMGABM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x392EA90", Offset = "0x392D890", VA = "0x18392EA90")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x392E420", Offset = "0x392D220", VA = "0x18392E420")]
	private bool ABHEMLCDGEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3230BE0", Offset = "0x322F9E0", VA = "0x183230BE0")]
	public bool NCPOAGFPNBI(int PBJPHIMOIPA, out T LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x392EC10", Offset = "0x392DA10", VA = "0x18392EC10")]
	public KPGPNOCFHDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class CKGBLPHPAHE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	protected struct EBBMGKJHPAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public T KIKNELACDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int PBPNMCBCONH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	protected readonly List<EBBMGKJHPAF> NDMGLHHJNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private T GOGLLHPPJND;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int KBMMNCEALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1C76480", Offset = "0x1C75280", VA = "0x181C76480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x1FA93B0", Offset = "0x1FA81B0", VA = "0x181FA93B0")]
	public bool EAIPFKCBEMJ(T LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9600", Offset = "0x1FA8400", VA = "0x181FA9600")]
	public void EFHDBFNBKGH(T LNPFAODMJGO, int PBJPHIMOIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9730", Offset = "0x1FA8530", VA = "0x181FA9730")]
	public bool KGKIHAGANBK(T LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9850", Offset = "0x1FA8650", VA = "0x181FA9850")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA96A0", Offset = "0x1FA84A0", VA = "0x181FA96A0")]
	public T GCCDJLDJMPK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA91A0", Offset = "0x1FA7FA0", VA = "0x181FA91A0")]
	private void DNNPCMOJIJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA98B0", Offset = "0x1FA86B0", VA = "0x181FA98B0")]
	public CKGBLPHPAHE()
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
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x182B570", Offset = "0x182A370", VA = "0x18182B570", Slot = "4")]
		public virtual T LOFNDDNPFGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1819380", Offset = "0x1818180", VA = "0x181819380")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class DHJIGEMKEMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Dictionary<byte, FHKPHLDEJGB> MILPCPANGAG;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FHKPHLDEJGB KPPEHHKKCMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4E91D0", Offset = "0x4E7FD0", VA = "0x1804E91D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4E9490", Offset = "0x4E8290", VA = "0x1804E9490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Vector2 AGILKCABLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xEBAC00", Offset = "0xEB9A00", VA = "0x180EBAC00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2351C40", Offset = "0x2350A40", VA = "0x182351C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private Vector2 IBGOLKKNDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x136D060", Offset = "0x136BE60", VA = "0x18136D060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public Vector2 HGOALAMLNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x32E3F00", Offset = "0x32E2D00", VA = "0x1832E3F00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x32E3F20", Offset = "0x32E2D20", VA = "0x1832E3F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int EDJGJKFNMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5147E0", Offset = "0x5135E0", VA = "0x1805147E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x53A9A0", Offset = "0x5397A0", VA = "0x18053A9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x46D1500", Offset = "0x46D0300", VA = "0x1846D1500")]
	public DHJIGEMKEMN(Bounds LHEEFAGLIPB, Vector2[] IIGJNHPPJDA, int CPNHCGMAPLC, byte DDMFICCMNLL, float BPKDMPKAGJD = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x46D0D40", Offset = "0x46CFB40", VA = "0x1846D0D40")]
	public FHKPHLDEJGB AMNBPKKPBAH(byte NCKDNOGOLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x46D1410", Offset = "0x46D0210", VA = "0x1846D1410")]
	public void JJBEPBEIKKJ(Vector3 LONECLIELEO, float ANCBONHFCAG, float CKCNNDPIKDA, ref List<byte> KKNBJHGMKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x46D13F0", Offset = "0x46D01F0", VA = "0x1846D13F0")]
	public void IDAGHOPACBK(FHKPHLDEJGB.JABHLGJFALH MKDFGJKJLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x46D0DA0", Offset = "0x46CFBA0", VA = "0x1846D0DA0")]
	private FHKPHLDEJGB CJGOLFDKINI(byte NCKDNOGOLME, FHKPHLDEJGB.CCDFCHBCBKP MJFKNMMDINB, FHKPHLDEJGB EBLJNNNHKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x46D0ED0", Offset = "0x46CFCD0", VA = "0x1846D0ED0")]
	private void HFICBJJAKBC(FHKPHLDEJGB EBLJNNNHKDK, Vector2[] IIGJNHPPJDA, int BCNPGDEOCIO, int CANOPKLOOPP, int JOGIGGMNFJC, int HNGDKMGECMA, float BPKDMPKAGJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FHKPHLDEJGB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum CCDFCHBCBKP
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public enum JABHLGJFALH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public byte BNNNLOHAPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3 EFKNHNECOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3 GPDBHLFLLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3 JAEFAMHCPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Vector3 JDJIHLICGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public CCDFCHBCBKP PGGBEEMIBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public FHKPHLDEJGB PKNMLCMPIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public List<FHKPHLDEJGB> PHMELAHKLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool HCGLBEGGOCJ;

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x46D2140", Offset = "0x46D0F40", VA = "0x1846D2140")]
	public FHKPHLDEJGB(byte JODGPNEIOOF, CCDFCHBCBKP MJFKNMMDINB, FHKPHLDEJGB EBLJNNNHKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x46D20A0", Offset = "0x46D0EA0", VA = "0x1846D20A0")]
	public void PIBOPDNDBMF(FHKPHLDEJGB HCOMBMCGHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E80", Offset = "0x4E8C80", VA = "0x1804E9E80")]
	public void IDAGHOPACBK(int HDGEABAGAEP, JABHLGJFALH MKDFGJKJLHD, int NEPELKDONFO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x46D1E10", Offset = "0x46D0C10", VA = "0x1846D1E10")]
	public void JJBEPBEIKKJ(List<byte> KKNBJHGMKDO, Vector3 LONECLIELEO, float ANCBONHFCAG, float CKCNNDPIKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x46D1DB0", Offset = "0x46D0BB0", VA = "0x1846D1DB0")]
	public bool HPNDJKKEENM(Vector3 EDHNEJPHPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x46D1D70", Offset = "0x46D0B70", VA = "0x1846D1D70")]
	public bool HFADCJNEFKB(Vector3 EDHNEJPHPIH, float HGEGAPIPPMO)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct DFJBFKHBADI<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private readonly List<Component> FPCGFNEPLHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private readonly bool BBDJMHJKNFA;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6CF1A0", Offset = "0x6CDFA0", VA = "0x1806CF1A0")]
			public DFJBFKHBADI(List<Component> FPCGFNEPLHD, bool BBDJMHJKNFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x181B2D0", Offset = "0x181A0D0", VA = "0x18181B2D0")]
			public PBKAMINNHEH<T> CEAFABCEENE()
			{
				return default(PBKAMINNHEH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x181B340", Offset = "0x181A140", VA = "0x18181B340", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x181B340", Offset = "0x181A140", VA = "0x18181B340", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public struct PBKAMINNHEH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private readonly List<Component> FPCGFNEPLHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private readonly bool BBDJMHJKNFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int NCKDNOGOLME;

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public T GBJFNDIAHCL
			{
				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x1827EE0", Offset = "0x1826CE0", VA = "0x181827EE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x1827E70", Offset = "0x1826C70", VA = "0x181827E70", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1827EB0", Offset = "0x1826CB0", VA = "0x181827EB0")]
			public PBKAMINNHEH(List<Component> FPCGFNEPLHD, bool BBDJMHJKNFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x1827DA0", Offset = "0x1826BA0", VA = "0x181827DA0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x1827DB0", Offset = "0x1826BB0", VA = "0x181827DB0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x1827E60", Offset = "0x1826C60", VA = "0x181827E60", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x46D33E0", Offset = "0x46D21E0", VA = "0x1846D33E0")]
		private void BDHCIKJGEKI(GameObject PIDCKJECOII, bool DCDMHGCJNKM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x46D3270", Offset = "0x46D2070", VA = "0x1846D3270")]
		public static void BDHCIKJGEKI(GameObject PIDCKJECOII, ref ToolHierarchyCache DJHFGKBBFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1EB5FC0", Offset = "0x1EB4DC0", VA = "0x181EB5FC0")]
		public void JKJOIKGDIDB<T>(Action<T> ILFANDGNKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x28493C0", Offset = "0x28481C0", VA = "0x1828493C0")]
		public DFJBFKHBADI<T> OKGHECBCCEC<T>(bool BBDJMHJKNFA = false) where T : class
		{
			return default(DFJBFKHBADI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x46D3500", Offset = "0x46D2300", VA = "0x1846D3500")]
		public List<Component> BNNHFHKOEDF(Type FKELJAJFEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x46D37B0", Offset = "0x46D25B0", VA = "0x1846D37B0", Slot = "4")]
		public bool Equals(ToolHierarchyCache EDNAGLDPNGD, ToolHierarchyCache HJDKKMBJJBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x46D3830", Offset = "0x46D2630", VA = "0x1846D3830", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache OBJNDDPFMFI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class IKBPMABIOLB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private int IFGNJEPLBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int NIJHKLJFJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private List<T> ABBJDCCJFEJ;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public T JKOBGPIBCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x349B4B0", Offset = "0x349A2B0", VA = "0x18349B4B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T ECFFPJJKNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x349B800", Offset = "0x349A600", VA = "0x18349B800")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T HJGOJEAIEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x349B8B0", Offset = "0x349A6B0", VA = "0x18349B8B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x349B9C0", Offset = "0x349A7C0", VA = "0x18349B9C0")]
	public IKBPMABIOLB(int IFGNJEPLBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x349B530", Offset = "0x349A330", VA = "0x18349B530")]
	public void EFHDBFNBKGH(T KFDAOBEOEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x349B980", Offset = "0x349A780", VA = "0x18349B980")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x349B7B0", Offset = "0x349A5B0", VA = "0x18349B7B0")]
	public void FLALDDIGELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x349B970", Offset = "0x349A770", VA = "0x18349B970")]
	public void LAPFMMCNKMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class EHNLAOJEHLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct BGJMFIIPECA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int PBPNMCBCONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public T KIKNELACDKF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Dictionary<object, BGJMFIIPECA> AEEBENOMIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private T JALCHKBFLBM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T KLACMLDBIME
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xEBAC00", Offset = "0xEB9A00", VA = "0x180EBAC00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2351C40", Offset = "0x2350A40", VA = "0x182351C40", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool KJJMNGIMEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3547C50", Offset = "0x3546A50", VA = "0x183547C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public object HPPFLIOEEJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDF0", Offset = "0x4EABF0", VA = "0x1804EBDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x513D70", Offset = "0x512B70", VA = "0x180513D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3548B30", Offset = "0x3547930", VA = "0x183548B30")]
	public bool OJLFPNOENOE(T LNPFAODMJGO, object FADBOIIBKLG, int PBJPHIMOIPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x35482D0", Offset = "0x35470D0", VA = "0x1835482D0")]
	public bool NGDJPPKILJF(object FADBOIIBKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3548200", Offset = "0x3547000", VA = "0x183548200")]
	public bool NCPOAGFPNBI(object FADBOIIBKLG, out T LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2352000", Offset = "0x2350E00", VA = "0x182352000")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x35432A0", Offset = "0x35420A0", VA = "0x1835432A0")]
	private bool ABHEMLCDGEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3548BA0", Offset = "0x35479A0", VA = "0x183548BA0")]
	public EHNLAOJEHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class FFKAAGEOJOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<object, float> AEEBENOMIMN;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float MLLPJEMOCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xDB99D0", Offset = "0xDB87D0", VA = "0x180DB99D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xC03FE0", Offset = "0xC02DE0", VA = "0x180C03FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x46D1C80", Offset = "0x46D0A80", VA = "0x1846D1C80")]
	public void OJLFPNOENOE(float LNPFAODMJGO, object FADBOIIBKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x46D1C10", Offset = "0x46D0A10", VA = "0x1846D1C10")]
	public void NGDJPPKILJF(object FADBOIIBKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x46D1AF0", Offset = "0x46D08F0", VA = "0x1846D1AF0")]
	private void JAKLAFEIECO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x46D1CF0", Offset = "0x46D0AF0", VA = "0x1846D1CF0")]
	public FFKAAGEOJOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class JHJCMIAJFEL
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public sealed class BDBOAMBHOJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly string LJLMNCNGCMM;

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		private BDBOAMBHOJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5AB430", Offset = "0x5AA230", VA = "0x1805AB430")]
		public BDBOAMBHOJB(string LJLMNCNGCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x46D0B30", Offset = "0x46CF930", VA = "0x1846D0B30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class MCJPONJHPFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
		public MCJPONJHPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x46D2A50", Offset = "0x46D1850", VA = "0x1846D2A50")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly HashSet<object> PHILLGMFNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int CAFDAPNBLNC;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool HJPJEOOFIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x46D2700", Offset = "0x46D1500", VA = "0x1846D2700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int KBMMNCEALDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x570BE0", Offset = "0x56F9E0", VA = "0x180570BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x46D2770", Offset = "0x46D1570", VA = "0x1846D2770")]
	public bool EFHDBFNBKGH(object FADBOIIBKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x46D27F0", Offset = "0x46D15F0", VA = "0x1846D27F0")]
	public bool KGKIHAGANBK(object FADBOIIBKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x46D2710", Offset = "0x46D1510", VA = "0x1846D2710")]
	public bool EAIPFKCBEMJ(object FADBOIIBKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x46D26A0", Offset = "0x46D14A0", VA = "0x1846D26A0")]
	public void AGFJAAMNHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x46D2870", Offset = "0x46D1670", VA = "0x1846D2870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x46D29E0", Offset = "0x46D17E0", VA = "0x1846D29E0")]
	public JHJCMIAJFEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class LDFECLMBBJK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct FFEAJILFJKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float AAGDPBAFMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public T KIKNELACDKF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Dictionary<object, FFEAJILFJKI> AEEBENOMIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private T MLBGHIMIKIO;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T CMKAEJEKANN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xE1ACF0", Offset = "0xE19AF0", VA = "0x180E1ACF0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2351C60", Offset = "0x2350A60", VA = "0x182351C60", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public object HHKDMAOOMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x511A30", Offset = "0x510830", VA = "0x180511A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5AE660", Offset = "0x5AD460", VA = "0x1805AE660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool KJJMNGIMEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2351C00", Offset = "0x2350A00", VA = "0x182351C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x23524D0", Offset = "0x23512D0", VA = "0x1823524D0")]
	public bool OJLFPNOENOE(T LNPFAODMJGO, object FADBOIIBKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2352030", Offset = "0x2350E30", VA = "0x182352030")]
	public bool NGDJPPKILJF(object FADBOIIBKLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2352000", Offset = "0x2350E00", VA = "0x182352000")]
	public void NDPIBEPLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2351CD0", Offset = "0x2350AD0", VA = "0x182351CD0")]
	public bool NCPOAGFPNBI(object FADBOIIBKLG, out T LNPFAODMJGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x234FF50", Offset = "0x234ED50", VA = "0x18234FF50")]
	private bool ABHEMLCDGEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x23527D0", Offset = "0x23515D0", VA = "0x1823527D0")]
	public LDFECLMBBJK()
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
