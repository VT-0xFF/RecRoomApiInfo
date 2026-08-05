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
public class BAHDBCBGCMB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x559DB0", Offset = "0x558FB0", VA = "0x180559DB0")]
	public BAHDBCBGCMB()
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
		[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x46FE60", Offset = "0x46F060", VA = "0x18046FE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x46F450", Offset = "0x46E650", VA = "0x18046F450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "4")]
	public virtual void CAGNCAIFNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
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
	[BAHDBCBGCMB]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x33F82B0", Offset = "0x33F74B0", VA = "0x1833F82B0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x33F7DF0", Offset = "0x33F6FF0", VA = "0x1833F7DF0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x33F88B0", Offset = "0x33F7AB0", VA = "0x1833F88B0")]
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
	private sealed class MCGPGMJKJBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public MCGPGMJKJBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x20C45A0", Offset = "0x20C37A0", VA = "0x1820C45A0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[BAHDBCBGCMB]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x20C33B0", Offset = "0x20C25B0", VA = "0x1820C33B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x20C33E0", Offset = "0x20C25E0", VA = "0x1820C33E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x20C3300", Offset = "0x20C2500", VA = "0x1820C3300", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey FIIDMDOOCIB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x20C3330", Offset = "0x20C2530", VA = "0x1820C3330", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x20C3210", Offset = "0x20C2410", VA = "0x1820C3210", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x20C2A80", Offset = "0x20C1C80", VA = "0x1820C2A80", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x20C23F0", Offset = "0x20C15F0", VA = "0x1820C23F0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x20C1FC0", Offset = "0x20C11C0", VA = "0x1820C1FC0", Slot = "14")]
	protected virtual string CMDCFNEMCNK(TKeyVal ICENHNBIOIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2074A80", Offset = "0x2073C80", VA = "0x182074A80", Slot = "4")]
	public bool ContainsKey(TKey FIIDMDOOCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x20C3110", Offset = "0x20C2310", VA = "0x1820C3110", Slot = "5")]
	public bool TryGetValue(TKey FIIDMDOOCIB, out TVal LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20C1FF0", Offset = "0x20C11F0", VA = "0x1820C1FF0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x20C1FF0", Offset = "0x20C11F0", VA = "0x1820C1FF0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20C3140", Offset = "0x20C2340", VA = "0x1820C3140")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PDLEEHKPBEF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OLLPCDDOABO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public OLLPCDDOABO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2C78790", Offset = "0x2C77990", VA = "0x182C78790")]
		internal bool <GetSamples>b__0(global::IJPAEFGICEK<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float DAPPOCFOJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float GCMBCBNLIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::IJPAEFGICEK<float, T>> OFOIFBJDIEE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ODEJFAOCJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2C7B130", Offset = "0x2C7A330", VA = "0x182C7B130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B230", Offset = "0x2C7A430", VA = "0x182C7B230")]
	public PDLEEHKPBEF(float GDOBFFPKMAB, float OJIBFNNIOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AFD0", Offset = "0x2C7A1D0", VA = "0x182C7AFD0")]
	public bool IMMPDFMEMMD(float JEGFFEGEPFH, T LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AB40", Offset = "0x2C79D40", VA = "0x182C7AB40")]
	public IEnumerable<T> HCCKAAALJEA(float JEGFFEGEPFH, [Optional] float? CCDPGAELEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A720", Offset = "0x2C79920", VA = "0x182C7A720")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A750", Offset = "0x2C79950", VA = "0x182C7A750")]
	private void FODJGDIIPEN(float JEGFFEGEPFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class DIKHLLONMIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct OFNNALLHNIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T NAHOADDLJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float JGCPJPBAAJC;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float PIMDBNJHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> OPNEJNMLHOA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int GGAOEIFGFCH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OFNNALLHNIB[] GLHMKLACBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int IILLKLFGDIC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float NDKANECALMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD9DAE0", Offset = "0xD9CCE0", VA = "0x180D9DAE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD9DB00", Offset = "0xD9CD00", VA = "0x180D9DB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1A03140", Offset = "0x1A02340", VA = "0x181A03140")]
	public DIKHLLONMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1A03170", Offset = "0x1A02370", VA = "0x181A03170")]
	public DIKHLLONMIE(int AEFLDANFMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1A02900", Offset = "0x1A01B00", VA = "0x181A02900")]
	public void GNHAFJPCAEK(float JEGFFEGEPFH, T LNFKIKOILLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1A02580", Offset = "0x1A01780", VA = "0x181A02580")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1A02F40", Offset = "0x1A02140", VA = "0x181A02F40")]
	public bool OEMMOHFEFPO(float HEMMAKNJOMB, float FLAONHKLIPP, out T LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1A02BC0", Offset = "0x1A01DC0", VA = "0x181A02BC0")]
	public bool MIPHIIELNLG(float HEMMAKNJOMB, float FLAONHKLIPP, out T LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1A02430", Offset = "0x1A01630", VA = "0x181A02430")]
	public void EJMFKFDCINP(float HEMMAKNJOMB, float FLAONHKLIPP, List<T> EJHDHKEAACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1A022A0", Offset = "0x1A014A0", VA = "0x181A022A0")]
	private int APGCJCPOFEI(int AFGKLALLMPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1A029D0", Offset = "0x1A01BD0", VA = "0x181A029D0")]
	private void HPBMHIKOJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OBCIPEMLEFB();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T DHFBJFPGHHA(T LNFKIKOILLL, float DICCPJIFLAH);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T KOOHIGGKANB(T MJOPEHEKEJC, T BCMBPFEHKKA);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NEJHEDHIIHL(T MJOPEHEKEJC, T BCMBPFEHKKA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KAEEKLFKAKE : global::DIKHLLONMIE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3F687A0", Offset = "0x3F679A0", VA = "0x183F687A0", Slot = "4")]
	protected override Vector3 OBCIPEMLEFB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3F685E0", Offset = "0x3F677E0", VA = "0x183F685E0", Slot = "5")]
	protected override Vector3 DHFBJFPGHHA(Vector3 LNFKIKOILLL, float DICCPJIFLAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3F68680", Offset = "0x3F67880", VA = "0x183F68680", Slot = "6")]
	protected override Vector3 KOOHIGGKANB(Vector3 MJOPEHEKEJC, Vector3 BCMBPFEHKKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3F68730", Offset = "0x3F67930", VA = "0x183F68730", Slot = "7")]
	protected override Vector3 NEJHEDHIIHL(Vector3 MJOPEHEKEJC, Vector3 BCMBPFEHKKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3F68810", Offset = "0x3F67A10", VA = "0x183F68810")]
	public KAEEKLFKAKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FMELEDIHKAB
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1B16440", Offset = "0x1B15640", VA = "0x181B16440")]
	public static global::IJPAEFGICEK<T1, T2> BNELFEDOIHI<T1, T2>(T1 BCAJKADMOKL, T2 EHFKHHPBGNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x19F2230", Offset = "0x19F1430", VA = "0x1819F2230")]
	public static global::CGAFDKCKLGJ<T1, T2, T3> BNELFEDOIHI<T1, T2, T3>(T1 BCAJKADMOKL, T2 EHFKHHPBGNB, T3 LAAMDMBLPHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA04D0", Offset = "0x2A9F6D0", VA = "0x182AA04D0")]
	internal static int PKJKPBIFDEC(int OPBMMGJNHOK, int GNDAKJCNDBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2FE0", Offset = "0x3AB21E0", VA = "0x183AB2FE0")]
	internal static int PKJKPBIFDEC(int OPBMMGJNHOK, int GNDAKJCNDBI, int JACBDFHCMAJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IJPAEFGICEK<T1, T2> : IComparable<global::IJPAEFGICEK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 KCPMIEEKHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 PIMJBNOHHBK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x196C550", Offset = "0x196B750", VA = "0x18196C550")]
	public IJPAEFGICEK(T1 BCAJKADMOKL, T2 EHFKHHPBGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x196AD60", Offset = "0x1969F60", VA = "0x18196AD60", Slot = "4")]
	public int CompareTo(global::IJPAEFGICEK<T1, T2> FDPANPCNJEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x196B380", Offset = "0x196A580", VA = "0x18196B380", Slot = "0")]
	public override bool Equals(object FDPANPCNJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x196BB30", Offset = "0x196AD30", VA = "0x18196BB30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x196C040", Offset = "0x196B240", VA = "0x18196C040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CGAFDKCKLGJ<T1, T2, T3> : IComparable<global::CGAFDKCKLGJ<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 KCPMIEEKHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 PIMJBNOHHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 ONFKKJDIHON;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C202E0", Offset = "0x1C1F4E0", VA = "0x181C202E0")]
	public CGAFDKCKLGJ(T1 BCAJKADMOKL, T2 EHFKHHPBGNB, T3 LAAMDMBLPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FC00", Offset = "0x1C1EE00", VA = "0x181C1FC00", Slot = "4")]
	public int CompareTo(global::CGAFDKCKLGJ<T1, T2, T3> FDPANPCNJEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FDF0", Offset = "0x1C1EFF0", VA = "0x181C1FDF0", Slot = "0")]
	public override bool Equals(object FDPANPCNJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1C1FFF0", Offset = "0x1C1F1F0", VA = "0x181C1FFF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1C20150", Offset = "0x1C1F350", VA = "0x181C20150", Slot = "3")]
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
	public T NAHOADDLJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x496670", Offset = "0x495870", VA = "0x180496670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x52F650", Offset = "0x52E850", VA = "0x18052F650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float JNMAGEPKNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB7BD80", Offset = "0xB7AF80", VA = "0x180B7BD80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2F2C1C0", Offset = "0x2F2B3C0", VA = "0x182F2C1C0")]
	public T FDALLNNCNAC(float DICCPJIFLAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2F2C680", Offset = "0x2F2B880", VA = "0x182F2C680")]
	public T PKDCCFIEIFL(float DICCPJIFLAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GCGLMIBFFMD(T MJOPEHEKEJC, T BCMBPFEHKKA, float DICCPJIFLAH);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3F683D0", Offset = "0x3F675D0", VA = "0x183F683D0", Slot = "4")]
	protected override float GCGLMIBFFMD(float MJOPEHEKEJC, float BCMBPFEHKKA, float DICCPJIFLAH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3F68450", Offset = "0x3F67650", VA = "0x183F68450")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3F69700", Offset = "0x3F68900", VA = "0x183F69700", Slot = "4")]
	protected override Vector3 GCGLMIBFFMD(Vector3 MJOPEHEKEJC, Vector3 BCMBPFEHKKA, float DICCPJIFLAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3F697C0", Offset = "0x3F689C0", VA = "0x183F697C0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3F47590", Offset = "0x3F46790", VA = "0x183F47590", Slot = "4")]
	protected override Color GCGLMIBFFMD(Color MJOPEHEKEJC, Color BCMBPFEHKKA, float DICCPJIFLAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3F67560", Offset = "0x3F66760", VA = "0x183F67560")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class MMPOFKHEINE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> CAKAEPIDDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> LOFHEPAHPOH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HACPMJMLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1A021D0", Offset = "0x1A013D0", VA = "0x181A021D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DFPFKFAEGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> HEPLEIHKNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1C208F0", Offset = "0x1C1FAF0", VA = "0x181C208F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> FEIBLAIGKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x206B740", Offset = "0x206A940", VA = "0x18206B740", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal CNKKHPPKHGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2C71420", Offset = "0x2C70620", VA = "0x182C71420", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC7C0", Offset = "0x2DFB9C0", VA = "0x182DFC7C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC080", Offset = "0x2DFB280", VA = "0x182DFC080", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC650", Offset = "0x2DFB850", VA = "0x182DFC650", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2DFBFF0", Offset = "0x2DFB1F0", VA = "0x182DFBFF0", Slot = "9")]
	public void Add(TKey FIIDMDOOCIB, TVal LNFKIKOILLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC050", Offset = "0x2DFB250", VA = "0x182DFC050", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LGCFGKDMFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC0E0", Offset = "0x2DFB2E0", VA = "0x182DFC0E0", Slot = "8")]
	public bool ContainsKey(TKey FIIDMDOOCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1C22FF0", Offset = "0x1C221F0", VA = "0x181C22FF0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LGCFGKDMFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC5F0", Offset = "0x2DFB7F0", VA = "0x182DFC5F0", Slot = "10")]
	public bool Remove(TKey FIIDMDOOCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC5F0", Offset = "0x2DFB7F0", VA = "0x182DFC5F0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LGCFGKDMFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE1D0", Offset = "0x2BFD3D0", VA = "0x182BFE1D0", Slot = "11")]
	public bool TryGetValue(TKey FIIDMDOOCIB, out TVal LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC1A0", Offset = "0x2DFB3A0", VA = "0x182DFC1A0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC140", Offset = "0x2DFB340", VA = "0x182DFC140", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GLHMKLACBDN, int KPGIHIHOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC4B0", Offset = "0x2DFB6B0", VA = "0x182DFC4B0")]
	public bool JPLPMIGCINJ(TVal FIIDMDOOCIB, out TKey LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC570", Offset = "0x2DFB770", VA = "0x182DFC570")]
	private void PMMANGECJIK(TKey FIIDMDOOCIB, TVal KKGCJBKLPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC2B0", Offset = "0x2DFB4B0", VA = "0x182DFC2B0")]
	private void HLGFBDKKIIL(TKey FIIDMDOOCIB, TVal KKGCJBKLPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC3F0", Offset = "0x2DFB5F0", VA = "0x182DFC3F0")]
	private bool IKADKAHMNIG(TKey FIIDMDOOCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC6F0", Offset = "0x2DFB8F0", VA = "0x182DFC6F0")]
	public MMPOFKHEINE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class NMNLPICFBPC<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::NMNLPICFBPC<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0xD9DAE0", Offset = "0xD9CCE0", VA = "0x180D9DAE0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1BB61C0", Offset = "0x1BB53C0", VA = "0x181BB61C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6580", Offset = "0x1BB5780", VA = "0x181BB6580")]
		public Enumerator(global::NMNLPICFBPC<T> EJHDHKEAACE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5C00", Offset = "0x1BB4E00", VA = "0x181BB5C00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5FD0", Offset = "0x1BB51D0", VA = "0x181BB5FD0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5EB0", Offset = "0x1BB50B0", VA = "0x181BB5EB0")]
		private void NMNAABAMLCO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] CHLAPFOINPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int IENLBGHKBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int KMBFOIAEKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int PBJKBDFKJND;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HACPMJMLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1BC1E90", Offset = "0x1BC1090", VA = "0x181BC1E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T CNKKHPPKHGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1BC27F0", Offset = "0x1BC19F0", VA = "0x181BC27F0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1BC2F70", Offset = "0x1BC2170", VA = "0x181BC2F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1BC3170", Offset = "0x1BC2370", VA = "0x181BC3170")]
	public NMNLPICFBPC(int KLLMEICHFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2490", Offset = "0x1BC1690", VA = "0x181BC2490")]
	public void GNHAFJPCAEK(T DICCPJIFLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1BC22C0", Offset = "0x1BC14C0", VA = "0x181BC22C0")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1BC26B0", Offset = "0x1BC18B0", VA = "0x181BC26B0")]
	public void KMMIJINFHJP(int LOPNMMNMIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2CB0", Offset = "0x1BC1EB0", VA = "0x181BC2CB0")]
	public void MHKAHLGAKGG(T[] GLHMKLACBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1BC2380", Offset = "0x1BC1580", VA = "0x181BC2380")]
	public Enumerator FOLGOHIENLB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1BC30F0", Offset = "0x1BC22F0", VA = "0x181BC30F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1BC30F0", Offset = "0x1BC22F0", VA = "0x181BC30F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1BC1FF0", Offset = "0x1BC11F0", VA = "0x181BC1FF0")]
	private int CNEFNGPBGID(int GOIONDNCAOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1BC1ED0", Offset = "0x1BC10D0", VA = "0x181BC1ED0")]
	private int CKIKCCIGCOC(int GOIONDNCAOG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class JPCHHFBNEAM
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
	protected JPCHHFBNEAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class BJPAJFPDJNA<T> : JPCHHFBNEAM
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct JFNNFNLBFIF
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum OLOICBOHCEK
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
		public OLOICBOHCEK FPLGNMDKNAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T DMBCNIHDJBD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int NPHPDMPEJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool IECAMFLNNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool AEACJHOGPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> BBLPLMIHKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<JFNNFNLBFIF> DBLKIGFCPIC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IJJKHFPCLJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2BFDB80", Offset = "0x2BFCD80", VA = "0x182BFDB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE030", Offset = "0x2BFD230", VA = "0x182BFE030")]
	protected BJPAJFPDJNA(bool AEACJHOGPMN, bool IECAMFLNNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDBC0", Offset = "0x2BFCDC0", VA = "0x182BFDBC0")]
	protected bool IBNGELFPPAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDC60", Offset = "0x2BFCE60", VA = "0x182BFDC60")]
	protected void IOPEHAEAKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDE80", Offset = "0x2BFD080", VA = "0x182BFDE80")]
	protected void KNOHGCPOIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1BC5270", Offset = "0x1BC4470", VA = "0x181BC5270")]
	private static void HJCKCPMJLKG<U>(ref List<U> ANAGMAGHBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDA30", Offset = "0x2BFCC30", VA = "0x182BFDA30", Slot = "4")]
	public void GNHAFJPCAEK(T DMBCNIHDJBD, bool NDEMFEFOIOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2BFDD40", Offset = "0x2BFCF40", VA = "0x182BFDD40", Slot = "5")]
	public void KKEHNCMNHLE(T DMBCNIHDJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2BFD900", Offset = "0x2BFCB00", VA = "0x182BFD900")]
	public void FDPJNEGBNGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class MAEEJHBHLJC : global::BJPAJFPDJNA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F68AE0", Offset = "0x3F67CE0", VA = "0x183F68AE0")]
	public MAEEJHBHLJC(bool AEACJHOGPMN = false, bool IECAMFLNNEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3F68930", Offset = "0x3F67B30", VA = "0x183F68930")]
	public void PPJOHBCNPLC()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3F68870", Offset = "0x3F67A70", VA = "0x183F68870")]
	public static MAEEJHBHLJC CELKDBLFGOK(MAEEJHBHLJC MNPJMFOPLPL, Action DMBCNIHDJBD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3F688D0", Offset = "0x3F67AD0", VA = "0x183F688D0")]
	public static MAEEJHBHLJC KMHPMPJKPMF(MAEEJHBHLJC MNPJMFOPLPL, Action DMBCNIHDJBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MCFFPFCAJPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNHAFJPCAEK(Action<T> DMBCNIHDJBD, bool NDEMFEFOIOJ = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKEHNCMNHLE(Action<T> DMBCNIHDJBD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class PMJJDDOFAFI<T> : global::BJPAJFPDJNA<Action<T>>, global::MCFFPFCAJPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1963490", Offset = "0x1962690", VA = "0x181963490")]
	public PMJJDDOFAFI(bool AEACJHOGPMN = false, bool IECAMFLNNEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x29583F0", Offset = "0x29575F0", VA = "0x1829583F0")]
	public void PPJOHBCNPLC(T DICCPJIFLAH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1961770", Offset = "0x1960970", VA = "0x181961770")]
	public static global::PMJJDDOFAFI<T> CELKDBLFGOK(global::PMJJDDOFAFI<T> MNPJMFOPLPL, Action<T> DMBCNIHDJBD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1961810", Offset = "0x1960A10", VA = "0x181961810")]
	public static global::PMJJDDOFAFI<T> KMHPMPJKPMF(global::PMJJDDOFAFI<T> MNPJMFOPLPL, Action<T> DMBCNIHDJBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JJKFCIPKFHG<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class DJFMOKINCEB<T, U> : global::BJPAJFPDJNA<Action<T, U>>, global::JJKFCIPKFHG<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1963490", Offset = "0x1962690", VA = "0x181963490")]
	public DJFMOKINCEB(bool AEACJHOGPMN = false, bool IECAMFLNNEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1A05570", Offset = "0x1A04770", VA = "0x181A05570")]
	public void PPJOHBCNPLC(T DICCPJIFLAH, U MCBCFKMIAJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1961770", Offset = "0x1960970", VA = "0x181961770")]
	public static global::DJFMOKINCEB<T, U> CELKDBLFGOK(global::DJFMOKINCEB<T, U> MNPJMFOPLPL, Action<T, U> DMBCNIHDJBD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1961810", Offset = "0x1960A10", VA = "0x181961810")]
	public static global::DJFMOKINCEB<T, U> KMHPMPJKPMF(global::DJFMOKINCEB<T, U> MNPJMFOPLPL, Action<T, U> DMBCNIHDJBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class KAJGDKLBFPO<T, U, V> : global::BJPAJFPDJNA<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1963490", Offset = "0x1962690", VA = "0x181963490")]
	public KAJGDKLBFPO(bool AEACJHOGPMN = false, bool IECAMFLNNEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2566240", Offset = "0x2565440", VA = "0x182566240")]
	public void PPJOHBCNPLC(T DICCPJIFLAH, U MCBCFKMIAJA, V IJMNPEOLEOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1961770", Offset = "0x1960970", VA = "0x181961770")]
	public static global::KAJGDKLBFPO<T, U, V> CELKDBLFGOK(global::KAJGDKLBFPO<T, U, V> MNPJMFOPLPL, Action<T, U, V> DMBCNIHDJBD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1961810", Offset = "0x1960A10", VA = "0x181961810")]
	public static global::KAJGDKLBFPO<T, U, V> KMHPMPJKPMF(global::KAJGDKLBFPO<T, U, V> MNPJMFOPLPL, Action<T, U, V> DMBCNIHDJBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IHDBMNHLCMB<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class IIABFCMOGFK<T, U, V, W> : global::BJPAJFPDJNA<Action<T, U, V, W>>, global::IHDBMNHLCMB<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1963490", Offset = "0x1962690", VA = "0x181963490")]
	public IIABFCMOGFK(bool AEACJHOGPMN = false, bool IECAMFLNNEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1961E10", Offset = "0x1961010", VA = "0x181961E10")]
	public void PPJOHBCNPLC(T DICCPJIFLAH, U MCBCFKMIAJA, V IJMNPEOLEOG, W DOHOOGIDJEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1961770", Offset = "0x1960970", VA = "0x181961770")]
	public static global::IIABFCMOGFK<T, U, V, W> CELKDBLFGOK(global::IIABFCMOGFK<T, U, V, W> MNPJMFOPLPL, Action<T, U, V, W> DMBCNIHDJBD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1961810", Offset = "0x1960A10", VA = "0x181961810")]
	public static global::IIABFCMOGFK<T, U, V, W> KMHPMPJKPMF(global::IIABFCMOGFK<T, U, V, W> MNPJMFOPLPL, Action<T, U, V, W> DMBCNIHDJBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PKDCOJKIGGG<T, U, V, W, X> : global::BJPAJFPDJNA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1963490", Offset = "0x1962690", VA = "0x181963490")]
	public PKDCOJKIGGG(bool AEACJHOGPMN = false, bool IECAMFLNNEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x29529E0", Offset = "0x2951BE0", VA = "0x1829529E0")]
	public void PPJOHBCNPLC(T DICCPJIFLAH, U MCBCFKMIAJA, V IJMNPEOLEOG, W DOHOOGIDJEK, X HFHNJJJOCHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1961770", Offset = "0x1960970", VA = "0x181961770")]
	public static global::PKDCOJKIGGG<T, U, V, W, X> CELKDBLFGOK(global::PKDCOJKIGGG<T, U, V, W, X> MNPJMFOPLPL, Action<T, U, V, W, X> DMBCNIHDJBD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1961810", Offset = "0x1960A10", VA = "0x181961810")]
	public static global::PKDCOJKIGGG<T, U, V, W, X> KMHPMPJKPMF(global::PKDCOJKIGGG<T, U, V, W, X> MNPJMFOPLPL, Action<T, U, V, W, X> DMBCNIHDJBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NBJGJILFOGI<T, U, V, W, X, Y> : global::BJPAJFPDJNA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1963490", Offset = "0x1962690", VA = "0x181963490")]
	public NBJGJILFOGI(bool AEACJHOGPMN = false, bool IECAMFLNNEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x206C040", Offset = "0x206B240", VA = "0x18206C040")]
	public void PPJOHBCNPLC(T DICCPJIFLAH, U MCBCFKMIAJA, V IJMNPEOLEOG, W DOHOOGIDJEK, X HFHNJJJOCHJ, Y OCFCJMCJMEC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1961770", Offset = "0x1960970", VA = "0x181961770")]
	public static global::NBJGJILFOGI<T, U, V, W, X, Y> CELKDBLFGOK(global::NBJGJILFOGI<T, U, V, W, X, Y> MNPJMFOPLPL, Action<T, U, V, W, X, Y> DMBCNIHDJBD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1961810", Offset = "0x1960A10", VA = "0x181961810")]
	public static global::NBJGJILFOGI<T, U, V, W, X, Y> KMHPMPJKPMF(global::NBJGJILFOGI<T, U, V, W, X, Y> MNPJMFOPLPL, Action<T, U, V, W, X, Y> DMBCNIHDJBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MOFHJABHNMJ<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool FNPLCHMJBEH(global::MOFHJABHNMJ<T> MKKFNDABMKC);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OAMEMCNCIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public global::MOFHJABHNMJ<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public OAMEMCNCIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2074660", Offset = "0x2073860", VA = "0x182074660")]
		internal bool <FindNode>b__0(global::MOFHJABHNMJ<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public T KFLNEDKKMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public LinkedList<global::MOFHJABHNMJ<T>> KEOABADMDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public global::MOFHJABHNMJ<T> KDFJJFCLHMP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public global::MOFHJABHNMJ<T> OOOKGLJEJHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4BFA20", Offset = "0x4BEC20", VA = "0x1804BFA20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2065240", Offset = "0x2064440", VA = "0x182065240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CKIOBKEIAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2065EE0", Offset = "0x20650E0", VA = "0x182065EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool PPEGHLDPPHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2064580", Offset = "0x2063780", VA = "0x182064580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public global::MOFHJABHNMJ<T> OOIIBNHPEFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x20669E0", Offset = "0x2065BE0", VA = "0x1820669E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2066AF0", Offset = "0x2065CF0", VA = "0x182066AF0")]
	public MOFHJABHNMJ(T HHKPOCEOAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2065030", Offset = "0x2064230", VA = "0x182065030")]
	public global::MOFHJABHNMJ<T> BJMLDNPDJKM(T ODGLMDHGOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2066230", Offset = "0x2065430", VA = "0x182066230")]
	public global::MOFHJABHNMJ<T> LOADFMMDANM(T CINAIKAHEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2065FA0", Offset = "0x20651A0", VA = "0x182065FA0")]
	public global::MOFHJABHNMJ<T> KKEHNCMNHLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2065A40", Offset = "0x2064C40", VA = "0x182065A40")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2066050", Offset = "0x2065250", VA = "0x182066050")]
	public global::MOFHJABHNMJ<T> LJKJCIINJFE(T CGEAPKHGDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2065700", Offset = "0x2064900", VA = "0x182065700")]
	public static void DCELJGJAOJF(global::MOFHJABHNMJ<T> GMCEIKGMAGI, FNPLCHMJBEH LCNOAONJHLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1C0AF90", Offset = "0x1C0A190", VA = "0x181C0AF90")]
	public static void DCELJGJAOJF<A>(global::MOFHJABHNMJ<T> GMCEIKGMAGI, Func<global::MOFHJABHNMJ<T>, A, bool> LCNOAONJHLM, A LECBAPAFHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2064B20", Offset = "0x2063D20", VA = "0x182064B20")]
	public static string BGBHDGLLCDD(global::MOFHJABHNMJ<T> GMCEIKGMAGI, int MEJGCLJFMFK = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x20665C0", Offset = "0x20657C0", VA = "0x1820665C0")]
	public static global::MOFHJABHNMJ<T> NDLNFLPDMNE(global::MOFHJABHNMJ<T> GMCEIKGMAGI, T CKCNKBJBAGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class DLGJFJDOMIL<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate int PNENLEPPLJP(TKey FIIDMDOOCIB, TVal LNFKIKOILLL);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private class IFOJBBFGPBC
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TKey BODKPPKNCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TVal NAHOADDLJAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5CC890", Offset = "0x5CBA90", VA = "0x1805CC890")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x602BC0", Offset = "0x601DC0", VA = "0x180602BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int CBMNGOEFPGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x549020", Offset = "0x548220", VA = "0x180549020")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x549050", Offset = "0x548250", VA = "0x180549050")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DateTime FGOFFEHJIBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x471CF0", Offset = "0x470EF0", VA = "0x180471CF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4987D0", Offset = "0x4979D0", VA = "0x1804987D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1A0FA50", Offset = "0x1A0EC50", VA = "0x181A0FA50")]
		public IFOJBBFGPBC(TKey FIIDMDOOCIB, TVal KKGCJBKLPEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const int JEPNDOIJCFH = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Dictionary<TKey, LinkedListNode<IFOJBBFGPBC>> DLOONGFBFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly LinkedList<IFOJBBFGPBC> NCIJHFJPPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly PNENLEPPLJP LFOMGHPLIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly TimeSpan GHOPCEKNNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BJDBDHKOIHG PGLBNJCIAGD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int JFHCKLJKMNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x552150", Offset = "0x551350", VA = "0x180552150")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool NPPHDEMMOED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1A06F60", Offset = "0x1A06160", VA = "0x181A06F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal int JIBKDNPNIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x552160", Offset = "0x551360", VA = "0x180552160")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5471A0", Offset = "0x5463A0", VA = "0x1805471A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey CNKKHPPKHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A08130", Offset = "0x1A07330", VA = "0x181A08130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1A08A80", Offset = "0x1A07C80", VA = "0x181A08A80")]
	public DLGJFJDOMIL(int KLLMEICHFCA, [Optional] PNENLEPPLJP LFOMGHPLIIO, [Optional] IEqualityComparer<TKey> APFELOPGBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1A08790", Offset = "0x1A07990", VA = "0x181A08790")]
	public DLGJFJDOMIL(int KLLMEICHFCA, PNENLEPPLJP LFOMGHPLIIO, TimeSpan GHOPCEKNNPI, [Optional] IEqualityComparer<TKey> APFELOPGBOB, [Optional] BJDBDHKOIHG PGLBNJCIAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1A076B0", Offset = "0x1A068B0", VA = "0x181A076B0")]
	public void JBLNNAOMKFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1A071F0", Offset = "0x1A063F0", VA = "0x181A071F0")]
	public void IBBOFMEHKOO(TKey FIIDMDOOCIB, TVal LNFKIKOILLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1A07AB0", Offset = "0x1A06CB0", VA = "0x181A07AB0")]
	public bool KKEHNCMNHLE(TKey FIIDMDOOCIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1A07810", Offset = "0x1A06A10", VA = "0x181A07810")]
	public bool JPLPMIGCINJ(TKey FOGGMEDMCPM, out TVal LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1A07170", Offset = "0x1A06370", VA = "0x181A07170")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1A06FF0", Offset = "0x1A061F0", VA = "0x181A06FF0")]
	private bool EKLDJFOFONP(IFOJBBFGPBC PDMGBNIOPMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1A07EB0", Offset = "0x1A070B0", VA = "0x181A07EB0")]
	private void MBELBKOEGPL(LinkedListNode<IFOJBBFGPBC> LAJLPCNJFDA, TVal CJDOMIBLFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1A08360", Offset = "0x1A07560", VA = "0x181A08360")]
	private void ONELEHNCBEP(TKey FIIDMDOOCIB, TVal LNFKIKOILLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1A07370", Offset = "0x1A06570", VA = "0x181A07370")]
	private void IOJPHCOOAFI(IFOJBBFGPBC PDMGBNIOPMD, TVal CJDOMIBLFBA, int EGNCPHLJLEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class OFGCALFEGHA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly List<T> ANAGMAGHBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private HashSet<T> MOJMNMCBLEJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int HACPMJMLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A021D0", Offset = "0x1A013D0", VA = "0x181A021D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool DFPFKFAEGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T CNKKHPPKHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x21A5590", Offset = "0x21A4790", VA = "0x1821A5590", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2C71A20", Offset = "0x2C70C20", VA = "0x182C71A20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1A06E40", Offset = "0x1A06040", VA = "0x181A06E40", Slot = "11")]
	public void Add(T LGCFGKDMFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C71210", Offset = "0x2C70410", VA = "0x182C71210")]
	public bool BHBKOHFPJJM(T LGCFGKDMFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C71810", Offset = "0x2C70A10", VA = "0x182C71810", Slot = "15")]
	public bool Remove(T LGCFGKDMFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2BFE120", Offset = "0x2BFD320", VA = "0x182BFE120", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x256EE20", Offset = "0x256E020", VA = "0x18256EE20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C71360", Offset = "0x2C70560", VA = "0x182C71360", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C713C0", Offset = "0x2C705C0", VA = "0x182C713C0", Slot = "13")]
	public bool Contains(T LGCFGKDMFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C713F0", Offset = "0x2C705F0", VA = "0x182C713F0", Slot = "14")]
	public void CopyTo(T[] GLHMKLACBDN, int KPGIHIHOAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C71420", Offset = "0x2C70620", VA = "0x182C71420", Slot = "6")]
	public int IndexOf(T LGCFGKDMFCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2C71450", Offset = "0x2C70650", VA = "0x182C71450", Slot = "7")]
	public void Insert(int GOIONDNCAOG, T LGCFGKDMFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2C715E0", Offset = "0x2C707E0", VA = "0x182C715E0", Slot = "8")]
	public void RemoveAt(int GOIONDNCAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2C71890", Offset = "0x2C70A90", VA = "0x182C71890")]
	public OFGCALFEGHA()
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
			[Cpp2IlInjected.Address(RVA = "0x1B41E30", Offset = "0x1B41030", VA = "0x181B41E30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F696D0", Offset = "0x3F688D0", VA = "0x183F696D0")]
		public SerializedGuid(in Guid MCCMKJDAFBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F69510", Offset = "0x3F68710", VA = "0x183F69510")]
		public static SerializedGuid JLPHDFCALBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F69590", Offset = "0x3F68790", VA = "0x183F69590")]
		public static SerializedGuid LNHGKLONLDB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F69470", Offset = "0x3F68670", VA = "0x183F69470")]
		public bool GPFLNKGGGJA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F696B0", Offset = "0x3F688B0", VA = "0x183F696B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F69610", Offset = "0x3F68810", VA = "0x183F69610", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F692F0", Offset = "0x3F684F0", VA = "0x183F692F0", Slot = "7")]
		public bool Equals(SerializedGuid FDPANPCNJEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F69390", Offset = "0x3F68590", VA = "0x183F69390", Slot = "0")]
		public override bool Equals(object NLPBLPBCJHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F69500", Offset = "0x3F68700", VA = "0x183F69500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F692C0", Offset = "0x3F684C0", VA = "0x183F692C0", Slot = "6")]
		public int CompareTo(SerializedGuid FDPANPCNJEH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JCBCKHHPBKG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly Type APNICLCHADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly string FDLHODAEPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly bool DMBDOLMPCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly bool CJANFLKOJFK;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F68580", Offset = "0x3F67780", VA = "0x183F68580")]
	public JCBCKHHPBKG(Type ANDMGGOCDLP, string NOEJDPEIGMA, bool CGDCCBJHCBL = false, bool DFLLFFDHIGJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface IKAANANPNMP<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	T NAHOADDLJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool FONNLPPIALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::IKAANANPNMP<T> ONJFACOKDNK(Action<T> KDDNANHBDAM);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::IKAANANPNMP<T> OKDEJNEFBDP(Action<T> KDDNANHBDAM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FIHGFOOMOHG<T> : global::IKAANANPNMP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private global::DJFMOKINCEB<T, T> JJFDAMCOIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private global::PMJJDDOFAFI<T> IJGJLIGBHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private global::PMJJDDOFAFI<string> FPGMNIBGIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private string IKNIEMKPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T DKJBHJBBAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool OCDMMNCIMCB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T NAHOADDLJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x496670", Offset = "0x495870", VA = "0x180496670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1F19900", Offset = "0x1F18B00", VA = "0x181F19900", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FONNLPPIALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x546F80", Offset = "0x546180", VA = "0x180546F80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x21A8F20", Offset = "0x21A8120", VA = "0x1821A8F20")]
	private void EHIDOAEMAAH(T AJFFBOLKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x21A8FD0", Offset = "0x21A81D0", VA = "0x1821A8FD0", Slot = "4")]
	public global::IKAANANPNMP<T> ONJFACOKDNK(Action<T> IGCKCKHFGGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x21A8FA0", Offset = "0x21A81A0", VA = "0x1821A8FA0", Slot = "5")]
	public global::IKAANANPNMP<T> OKDEJNEFBDP(Action<T> KDDNANHBDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x21A9050", Offset = "0x21A8250", VA = "0x1821A9050")]
	public FIHGFOOMOHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HEACCEDJALI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FJJEAAPFBEP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public global::IKAANANPNMP<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public global::FLNHJFLHBAN<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public FJJEAAPFBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x34C1580", Offset = "0x34C0780", VA = "0x1834C1580")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x19F3CD0", Offset = "0x19F2ED0", VA = "0x1819F3CD0")]
	public static global::GFAADABKIAG<T> MDJDMMJKMJF<T>(this global::IKAANANPNMP<T> EEPDNJGANLO, Action<T> BILBMIBDIIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class BJDBDHKOIHG
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private class FLCMBBOAGJE : BJDBDHKOIHG
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static BJDBDHKOIHG PBEAOIDHOIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3F68230", Offset = "0x3F67430", VA = "0x183F68230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override DateTime DKFJLJJFHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3F68290", Offset = "0x3F67490", VA = "0x183F68290", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3F68370", Offset = "0x3F67570", VA = "0x183F68370")]
		public FLCMBBOAGJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static BJDBDHKOIHG NOAMFHBPNJE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static BJDBDHKOIHG EGBJFPEAHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F67130", Offset = "0x3F66330", VA = "0x183F67130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract DateTime DKFJLJJFHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
	protected BJDBDHKOIHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class IBABLNBJKOE : global::NJHEKMALIMP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3F68490", Offset = "0x3F67690", VA = "0x183F68490")]
	public IBABLNBJKOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NJHEKMALIMP<T> : global::HNADIMHJLDA<T>, CPIDGBNANPI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task<T> DGEDEOGKEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public global::GFAADABKIAG<T> JAANKAHHBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private MLALFLMLHEI BHGKMHCAIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x16A1CC0", Offset = "0x16A0EC0", VA = "0x1816A1CC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1BB98B0", Offset = "0x1BB8AB0", VA = "0x181BB98B0")]
	public NJHEKMALIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class CMKDGPGEGCP<T> : global::HNADIMHJLDA<T>, CPIDGBNANPI, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Task<T> DGEDEOGKEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public global::GFAADABKIAG<T> JAANKAHHBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MLALFLMLHEI BHGKMHCAIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x16A1CC0", Offset = "0x16A0EC0", VA = "0x1816A1CC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1C213F0", Offset = "0x1C205F0", VA = "0x181C213F0")]
	public CMKDGPGEGCP(Exception HHEDDBLEJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CPIDGBNANPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	[NotNull]
	MLALFLMLHEI JAANKAHHBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HNADIMHJLDA<T> : CPIDGBNANPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	Task<T> DGEDEOGKEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	new global::GFAADABKIAG<T> JAANKAHHBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class BGJKIGDOHPO<TTask, T> : global::HNADIMHJLDA<T>, CPIDGBNANPI, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class ENDBLBJLCMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public global::BGJKIGDOHPO<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public ENDBLBJLCMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class IKJNINAONAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public ENDBLBJLCMB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		public IKJNINAONAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2C01D80", Offset = "0x2C00F80", VA = "0x182C01D80")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static bool OELIPNGPBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly global::FLNHJFLHBAN<T> FJEJHCIMODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Task<T> GLHJDIFMFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly CancellationTokenSource LLHNEENMCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool ONLFFCIEFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private SynchronizationContext HOCIIJMHALB;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> DGEDEOGKEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::GFAADABKIAG<T> JAANKAHHBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private MLALFLMLHEI BHGKMHCAIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KNDAAGPHDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x52F760", Offset = "0x52E960", VA = "0x18052F760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB350", Offset = "0x2BFA550", VA = "0x182BFB350")]
	static BGJKIGDOHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB710", Offset = "0x2BFA910", VA = "0x182BFB710")]
	protected BGJKIGDOHPO(TTask GLHJDIFMFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2BFACA0", Offset = "0x2BF9EA0", VA = "0x182BFACA0", Slot = "1")]
	~BGJKIGDOHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFABD0", Offset = "0x2BF9DD0", VA = "0x182BFABD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2BFAD40", Offset = "0x2BF9F40", VA = "0x182BFAD40")]
	private void HJKEOFHMIOG(bool ACFPJHDEIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T LOKOOFEFNMK(TTask PGJIMOJCKOO);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void CPPCJEPFHBF();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2BFAAC0", Offset = "0x2BF9CC0", VA = "0x182BFAAC0")]
	protected void BECPBJJPGND(T AJFFBOLKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB020", Offset = "0x2BFA220", VA = "0x182BFB020")]
	protected void JLLKKGBPFCJ(string IKNIEMKPGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB140", Offset = "0x2BFA340", VA = "0x182BFB140")]
	[CompilerGenerated]
	private void LKCEFIJJIJO(object ABBDPEFLNMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class IPCJKEOJCMM<T> : IEnumerable<global::IPCJKEOJCMM<T>.FIBEOBDIPBA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct FIBEOBDIPBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public T LNFKIKOILLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public int GOIONDNCAOG;
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class GJDKPGAGLNA : IEnumerator<FIBEOBDIPBA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::IPCJKEOJCMM<T> HEDNIJAHECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int GOIONDNCAOG;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1FA4740", Offset = "0x1FA3940", VA = "0x181FA4740", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public FIBEOBDIPBA BHCJONKKDLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x220BAE0", Offset = "0x220ACE0", VA = "0x18220BAE0", Slot = "4")]
			get
			{
				return default(FIBEOBDIPBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x662080", Offset = "0x661280", VA = "0x180662080")]
		public GJDKPGAGLNA(global::IPCJKEOJCMM<T> HEDNIJAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x220BA50", Offset = "0x220AC50", VA = "0x18220BA50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x59FB80", Offset = "0x59ED80", VA = "0x18059FB80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE680", Offset = "0x7AD880", VA = "0x1807AE680", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct KIPEJEHOFJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public bool KPLGLPHFJGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T LNFKIKOILLL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private const int AGDIGIODGON = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private Dictionary<T, int> OLCNNAADBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private KIPEJEHOFJC[] EOHBJILHKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int AOKMFHHPGIP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HACPMJMLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1C208F0", Offset = "0x1C1FAF0", VA = "0x181C208F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2215DD0", Offset = "0x2214FD0", VA = "0x182215DD0")]
	public static global::IPCJKEOJCMM<T> OBGPDPAKLFB(FIBEOBDIPBA[] EMAECKOANOH, bool HGEHDGJHNEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2216200", Offset = "0x2215400", VA = "0x182216200")]
	public IPCJKEOJCMM(int KLLMEICHFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2215D80", Offset = "0x2214F80", VA = "0x182215D80")]
	public int OACNNCFKFFC(T LNFKIKOILLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2215D10", Offset = "0x2214F10", VA = "0x182215D10")]
	public T MDJDMMJKMJF(int GOIONDNCAOG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2215990", Offset = "0x2214B90", VA = "0x182215990")]
	public bool BHBKOHFPJJM(T LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x22159B0", Offset = "0x2214BB0", VA = "0x1822159B0")]
	public bool BHBKOHFPJJM(T LNFKIKOILLL, int GOIONDNCAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2215B80", Offset = "0x2214D80", VA = "0x182215B80")]
	public FIBEOBDIPBA[] JCPAOOJALOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2215CC0", Offset = "0x2214EC0", VA = "0x182215CC0")]
	private int LPCLDKOIJHP(int IENLBGHKBJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2216190", Offset = "0x2215390", VA = "0x182216190", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2216190", Offset = "0x2215390", VA = "0x182216190", Slot = "4")]
	private IEnumerator<FIBEOBDIPBA> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class FBLGOBPDDNM<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private List<T> FMECFGJHJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<T> JANJMOJGKPP;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x21A6800", Offset = "0x21A5A00", VA = "0x1821A6800")]
	public FBLGOBPDDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x21A66A0", Offset = "0x21A58A0", VA = "0x1821A66A0")]
	public FBLGOBPDDNM(int KLLMEICHFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x21A6480", Offset = "0x21A5680", VA = "0x1821A6480")]
	public T LNAGILCIJKA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x21A6580", Offset = "0x21A5780", VA = "0x1821A6580")]
	public void OGACCFLGIIN(T LNBNFELKOMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BGKFHLHPDAB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<int, T> OKCCJNDJJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private T EOFNLABFPLF;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public virtual T NFKMGPHCAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x46F190", Offset = "0x46E390", VA = "0x18046F190", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x46F450", Offset = "0x46E650", VA = "0x18046F450", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC0C0", Offset = "0x2BFB2C0", VA = "0x182BFC0C0")]
	public bool ONELEHNCBEP(T LNFKIKOILLL, int LMDHIDLMFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x2BFBE30", Offset = "0x2BFB030", VA = "0x182BFBE30")]
	public bool DOHEHPNELPG(int LMDHIDLMFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2BFBBD0", Offset = "0x2BFADD0", VA = "0x182BFBBD0")]
	public T DGPCMANKHLB(int LMDCPMEBJEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2BFBEC0", Offset = "0x2BFB0C0", VA = "0x182BFBEC0")]
	private bool KDNDLLIEIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2BFBE90", Offset = "0x2BFB090", VA = "0x182BFBE90")]
	public bool JPLPMIGCINJ(int LMDHIDLMFPO, out T LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2BFC120", Offset = "0x2BFB320", VA = "0x182BFC120")]
	public BGKFHLHPDAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NGEOLAGHIFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	protected struct NGHCGAKGGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public T NAHOADDLJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int GDDDJIJHILP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	protected readonly List<NGHCGAKGGPD> CHLAPFOINPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private T LHDMNKIEIAF;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int HACPMJMLJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1A021D0", Offset = "0x1A013D0", VA = "0x181A021D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2070620", Offset = "0x206F820", VA = "0x182070620")]
	public bool LCLMDANBHBC(T LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x20703F0", Offset = "0x206F5F0", VA = "0x1820703F0")]
	public void GNHAFJPCAEK(T LNFKIKOILLL, int LMDHIDLMFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2070470", Offset = "0x206F670", VA = "0x182070470")]
	public bool KKEHNCMNHLE(T LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2070390", Offset = "0x206F590", VA = "0x182070390")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2070590", Offset = "0x206F790", VA = "0x182070590")]
	public T LAHMGJOHPEG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2070870", Offset = "0x206FA70", VA = "0x182070870")]
	private void LHMGBJOOJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2070A80", Offset = "0x206FC80", VA = "0x182070A80")]
	public NGEOLAGHIFG()
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
		[Cpp2IlInjected.Address(RVA = "0x1A25A20", Offset = "0x1A24C20", VA = "0x181A25A20", Slot = "4")]
		public virtual T ANFDFAFIGIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x16A1F20", Offset = "0x16A1120", VA = "0x1816A1F20")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class FEBDCHBNCIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<byte, PIPNAPJDBPO> ABLHJCNEDAN;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public PIPNAPJDBPO PPLIOOFAGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x46F1A0", Offset = "0x46E3A0", VA = "0x18046F1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x46F440", Offset = "0x46E640", VA = "0x18046F440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Vector2 BBMEGKKPMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xE4F650", Offset = "0xE4E850", VA = "0x180E4F650")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x1BBAC20", Offset = "0x1BB9E20", VA = "0x181BBAC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Vector2 AGNPJHMHAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x12E7400", Offset = "0x12E6600", VA = "0x1812E7400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Vector2 HKOMGDAPPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2F52180", Offset = "0x2F51380", VA = "0x182F52180")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2F521A0", Offset = "0x2F513A0", VA = "0x182F521A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int NJDFCMFHIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4991B0", Offset = "0x4983B0", VA = "0x1804991B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4BE360", Offset = "0x4BD560", VA = "0x1804BE360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3F67D40", Offset = "0x3F66F40", VA = "0x183F67D40")]
	public FEBDCHBNCIN(Bounds GJGCBBBMABD, Vector2[] PFKAEMAFGHG, int HIFGEDKLMHL, byte IENLBGHKBJM, float NAJBCHIOHFG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3F67CE0", Offset = "0x3F66EE0", VA = "0x183F67CE0")]
	public PIPNAPJDBPO JPHPKGEAFAB(byte GOIONDNCAOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3F67C00", Offset = "0x3F66E00", VA = "0x183F67C00")]
	public void HBOBMMIMDJN(Vector3 MHPCLJDHABF, float BHBBHPHBDEF, float DMMNOAALBEN, ref List<byte> HNGCOEOOLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3F67BE0", Offset = "0x3F66DE0", VA = "0x183F67BE0")]
	public void FMHIGLOPMDA(PIPNAPJDBPO.NBHPBKABKEE JNDAOCGGLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3F67AC0", Offset = "0x3F66CC0", VA = "0x183F67AC0")]
	private PIPNAPJDBPO FHHJIBKNGDJ(byte GOIONDNCAOG, PIPNAPJDBPO.NPHNGNLHBHP PNPHAOGLMCK, PIPNAPJDBPO AJIKAKHMHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3F675A0", Offset = "0x3F667A0", VA = "0x183F675A0")]
	private void FAODFLNHOHJ(PIPNAPJDBPO AJIKAKHMHEA, Vector2[] PFKAEMAFGHG, int DGDMNJFNFJA, int HICOFALBLOB, int HMFNNMNANPA, int GENHBPNGGDC, float NAJBCHIOHFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class PIPNAPJDBPO
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public enum NPHNGNLHBHP
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum NBHPBKABKEE
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
	public byte BFNDBHMFDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Vector3 BCMCLKHLOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Vector3 CBMNGOEFPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Vector3 BPIOBMGNPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Vector3 JJIKNKEEEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public NPHNGNLHBHP EONHNENLGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public PIPNAPJDBPO OOOKGLJEJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public List<PIPNAPJDBPO> PKOKPDFNJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool HEOKAHPMNOL;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3F69270", Offset = "0x3F68470", VA = "0x183F69270")]
	public PIPNAPJDBPO(byte EAOOANIBOHM, NPHNGNLHBHP PNPHAOGLMCK, PIPNAPJDBPO AJIKAKHMHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3F68F10", Offset = "0x3F68110", VA = "0x183F68F10")]
	public void BJMLDNPDJKM(PIPNAPJDBPO PFPGCJEDDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
	public void FMHIGLOPMDA(int NALEKGBNLOB, NBHPBKABKEE JNDAOCGGLIO, int GFJBAHOOLJF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3F68FE0", Offset = "0x3F681E0", VA = "0x183F68FE0")]
	public void HBOBMMIMDJN(List<byte> HNGCOEOOLGG, Vector3 MHPCLJDHABF, float BHBBHPHBDEF, float DMMNOAALBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3F68EB0", Offset = "0x3F680B0", VA = "0x183F68EB0")]
	public bool AMBEAIGFCOC(Vector3 BOJNJOJAFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3F68FA0", Offset = "0x3F681A0", VA = "0x183F68FA0")]
	public bool CBJJGLMMGDO(Vector3 BOJNJOJAFHF, float FKGNHOFFHKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CIJEJOMKBFB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private int KLLMEICHFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int KALFNEJLFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private List<T> AAHBOAGNCIN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public T MAKNOOPEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x1C212E0", Offset = "0x1C204E0", VA = "0x181C212E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T CEIJKPGJENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x1C20DB0", Offset = "0x1C1FFB0", VA = "0x181C20DB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T DJEOJOCADMN
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1C211F0", Offset = "0x1C203F0", VA = "0x181C211F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1C21360", Offset = "0x1C20560", VA = "0x181C21360")]
	public CIJEJOMKBFB(int KLLMEICHFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1C20F00", Offset = "0x1C20100", VA = "0x181C20F00")]
	public void GNHAFJPCAEK(T KIJAGKGPPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1C20EC0", Offset = "0x1C200C0", VA = "0x181C20EC0")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1C20E60", Offset = "0x1C20060", VA = "0x181C20E60")]
	public void CPHGGBAHKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1C20EB0", Offset = "0x1C200B0", VA = "0x181C20EB0")]
	public void DNIFLEJIMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class NMFCKKFKEEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct NLHFKFMJPPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int GDDDJIJHILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public T NAHOADDLJAD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<object, NLHFKFMJPPB> OKCCJNDJJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private T EOFNLABFPLF;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public virtual T NFKMGPHCAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xE4F650", Offset = "0xE4E850", VA = "0x180E4F650", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1BBAC20", Offset = "0x1BB9E20", VA = "0x181BBAC20", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool GDOHIBHCDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1BBFF50", Offset = "0x1BBF150", VA = "0x181BBFF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public object ECFFJNOGNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x471CF0", Offset = "0x470EF0", VA = "0x180471CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4987D0", Offset = "0x4979D0", VA = "0x1804987D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1BBFF80", Offset = "0x1BBF180", VA = "0x181BBFF80")]
	public bool ONELEHNCBEP(T LNFKIKOILLL, object GJGIGHJFMLI, int LMDHIDLMFPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1BBAC90", Offset = "0x1BB9E90", VA = "0x181BBAC90")]
	public bool DOHEHPNELPG(object GJGIGHJFMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1BBAE10", Offset = "0x1BBA010", VA = "0x181BBAE10")]
	public bool JPLPMIGCINJ(object GJGIGHJFMLI, out T LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x1BBAD00", Offset = "0x1BB9F00", VA = "0x181BBAD00")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x1BBCB30", Offset = "0x1BBBD30", VA = "0x181BBCB30")]
	private bool KDNDLLIEIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1BC06F0", Offset = "0x1BBF8F0", VA = "0x181BC06F0")]
	public NMFCKKFKEEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BNCFMMMGNNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Dictionary<object, float> OKCCJNDJJAF;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float FHICMODOHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xB12C40", Offset = "0xB11E40", VA = "0x180B12C40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA53EA0", Offset = "0xA530A0", VA = "0x180A53EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3F67480", Offset = "0x3F66680", VA = "0x183F67480")]
	public void ONELEHNCBEP(float LNFKIKOILLL, object GJGIGHJFMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3F672F0", Offset = "0x3F664F0", VA = "0x183F672F0")]
	public void DOHEHPNELPG(object GJGIGHJFMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3F67360", Offset = "0x3F66560", VA = "0x183F67360")]
	private void JDCJHGLPCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3F674F0", Offset = "0x3F666F0", VA = "0x183F674F0")]
	public BNCFMMMGNNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class NNHPBNCCJEM
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public sealed class BLHBHHHCOCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly string PHMMHFOCGJE;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		private BLHBHHHCOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x52C590", Offset = "0x52B790", VA = "0x18052C590")]
		public BLHBHHHCOCB(string PHMMHFOCGJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3F672A0", Offset = "0x3F664A0", VA = "0x183F672A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class JAJLPMFHHLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
		public JAJLPMFHHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3F684D0", Offset = "0x3F676D0", VA = "0x183F684D0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly HashSet<object> NIGNKKOJCOJ;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool MEMDAGOMMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3F68CB0", Offset = "0x3F67EB0", VA = "0x183F68CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3F68B40", Offset = "0x3F67D40", VA = "0x183F68B40")]
	public void GNHAFJPCAEK(object GJGIGHJFMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3F68BF0", Offset = "0x3F67DF0", VA = "0x183F68BF0")]
	public void KKEHNCMNHLE(object GJGIGHJFMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3F68C50", Offset = "0x3F67E50", VA = "0x183F68C50")]
	public bool LCLMDANBHBC(object GJGIGHJFMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3F68BA0", Offset = "0x3F67DA0", VA = "0x183F68BA0")]
	public void IFMIJCENIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3F68CF0", Offset = "0x3F67EF0", VA = "0x183F68CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3F68E50", Offset = "0x3F68050", VA = "0x183F68E50")]
	public NNHPBNCCJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GCNKENFNCKD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct PNKJKCKKGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float JGCPJPBAAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public T NAHOADDLJAD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Dictionary<object, PNKJKCKKGAC> OKCCJNDJJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private T JDINBMLOEDD;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T EGBKKGDJFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xF04FA0", Offset = "0xF041A0", VA = "0x180F04FA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1BBAC70", Offset = "0x1BB9E70", VA = "0x181BBAC70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public object ABPIBPDFMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x496670", Offset = "0x495870", VA = "0x180496670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x52F650", Offset = "0x52E850", VA = "0x18052F650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GDOHIBHCDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2B6DC70", Offset = "0x2B6CE70", VA = "0x182B6DC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DCB0", Offset = "0x2B6CEB0", VA = "0x182B6DCB0")]
	public bool ONELEHNCBEP(T LNFKIKOILLL, object GJGIGHJFMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C880", Offset = "0x2B6BA80", VA = "0x182B6C880")]
	public bool DOHEHPNELPG(object GJGIGHJFMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x1BBAD00", Offset = "0x1BB9F00", VA = "0x181BBAD00")]
	public void FDPJNEGBNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2F3EC80", Offset = "0x2F3DE80", VA = "0x182F3EC80")]
	public bool JPLPMIGCINJ(object GJGIGHJFMLI, out T LNFKIKOILLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2F3F4D0", Offset = "0x2F3E6D0", VA = "0x182F3F4D0")]
	private bool KDNDLLIEIDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E170", Offset = "0x2B6D370", VA = "0x182B6E170")]
	public GCNKENFNCKD()
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
