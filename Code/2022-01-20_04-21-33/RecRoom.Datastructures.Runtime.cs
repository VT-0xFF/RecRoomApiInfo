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
public class PEAELACEOPK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9E4E70", Offset = "0x9E3670", VA = "0x1809E4E70")]
	public PEAELACEOPK()
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
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5B6330", Offset = "0x5B4B30", VA = "0x1805B6330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4D7820", Offset = "0x4D6020", VA = "0x1804D7820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "4")]
	public virtual void LKFIPLDHFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
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
	[PEAELACEOPK]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2DE4060", Offset = "0x2DE2860", VA = "0x182DE4060", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3BA0", Offset = "0x2DE23A0", VA = "0x182DE3BA0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2DE4660", Offset = "0x2DE2E60", VA = "0x182DE4660")]
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
	private sealed class BFGIPHNAPAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		public BFGIPHNAPAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D3F0", Offset = "0x1F6BBF0", VA = "0x181F6D3F0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[PEAELACEOPK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1F74EA0", Offset = "0x1F736A0", VA = "0x181F74EA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1F74ED0", Offset = "0x1F736D0", VA = "0x181F74ED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1F74DF0", Offset = "0x1F735F0", VA = "0x181F74DF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey PONAFPGHKNA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1F74E20", Offset = "0x1F73620", VA = "0x181F74E20", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1F74D00", Offset = "0x1F73500", VA = "0x181F74D00", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1F74570", Offset = "0x1F72D70", VA = "0x181F74570", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F73EE0", Offset = "0x1F726E0", VA = "0x181F73EE0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F73A80", Offset = "0x1F72280", VA = "0x181F73A80", Slot = "14")]
	protected virtual string ACKEGHJCOMF(TKeyVal OKKDOMBBLJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D530", Offset = "0x1F6BD30", VA = "0x181F6D530", Slot = "4")]
	public bool ContainsKey(TKey PONAFPGHKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1F74C00", Offset = "0x1F73400", VA = "0x181F74C00", Slot = "5")]
	public bool TryGetValue(TKey PONAFPGHKNA, out TVal IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F73AE0", Offset = "0x1F722E0", VA = "0x181F73AE0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F73AE0", Offset = "0x1F722E0", VA = "0x181F73AE0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F74C30", Offset = "0x1F73430", VA = "0x181F74C30")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OHJHAAKMNJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class GOAFNHEFMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		public GOAFNHEFMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2C94210", Offset = "0x2C92A10", VA = "0x182C94210")]
		internal bool <GetSamples>b__0(global::PEAPGKHMIMP<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float PJAGDKEPGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float KJDIHNPGKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::PEAPGKHMIMP<float, T>> ODHNOGHJPMN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EHKCCEBHKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3920", Offset = "0x2CA2120", VA = "0x182CA3920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4170", Offset = "0x2CA2970", VA = "0x182CA4170")]
	public OHJHAAKMNJH(float HABBIFIJBJI, float JDFAHJJOLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3660", Offset = "0x2CA1E60", VA = "0x182CA3660")]
	public bool AGEAEAHEGIE(float FPKGHGPKALB, T IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3B10", Offset = "0x2CA2310", VA = "0x182CA3B10")]
	public IEnumerable<T> HDCCBPHDGFI(float FPKGHGPKALB, [Optional] float? JGDAMIDNEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3AE0", Offset = "0x2CA22E0", VA = "0x182CA3AE0")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3A20", Offset = "0x2CA2220", VA = "0x182CA3A20")]
	private void FAFIDHCBOHD(float FPKGHGPKALB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class CDNPFFLPIEJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct NOBLDEOGAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T FAIFGLIBFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float DFHLKICNPGI;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float MHGPHHHDMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> GCBGJOMBDOF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int NAKKAPIABHP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private NOBLDEOGAAF[] PGLBLBGJMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int HECMAOGBNJC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float JELPHJBLOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5BB5F0", Offset = "0x5B9DF0", VA = "0x1805BB5F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7A0", Offset = "0x6C9FA0", VA = "0x1806CB7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E1C0", Offset = "0x2E1C9C0", VA = "0x182E1E1C0")]
	public CDNPFFLPIEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E0F0", Offset = "0x2E1C8F0", VA = "0x182E1E0F0")]
	public CDNPFFLPIEJ(int HMOCDAEHBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D910", Offset = "0x2E1C110", VA = "0x182E1D910")]
	public void GMBMAEFCBMN(float FPKGHGPKALB, T IJBLIGDNDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D6E0", Offset = "0x2E1BEE0", VA = "0x182E1D6E0")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2E1DCD0", Offset = "0x2E1C4D0", VA = "0x182E1DCD0")]
	public bool PDDDPAAGDBA(float BEDLAKBLIGC, float HOFLOEOJCIP, out T IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D280", Offset = "0x2E1BA80", VA = "0x182E1D280")]
	public bool DEFFEDBPNEA(float BEDLAKBLIGC, float HOFLOEOJCIP, out T IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2E1DA20", Offset = "0x2E1C220", VA = "0x182E1DA20")]
	public void KPBLIFFLFHG(float BEDLAKBLIGC, float HOFLOEOJCIP, List<T> EJJJCPNBKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D250", Offset = "0x2E1BA50", VA = "0x182E1D250")]
	private int DBAIGLLKGOO(int EBKLEHADLFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1D9E0", Offset = "0x2E1C1E0", VA = "0x182E1D9E0")]
	private void GPLINMGPOII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MOEMFCPIJPG();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GACPKMPJDEI(T IJBLIGDNDKF, float KMDDPMCKNCH);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T KAJLIFAGNKJ(T LAFNJPALCMB, T NDOKDNHCCLP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IMCNGFBMHFB(T LAFNJPALCMB, T NDOKDNHCCLP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JGBAJGPDLGA : global::CDNPFFLPIEJ<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x44AA5D0", Offset = "0x44A8DD0", VA = "0x1844AA5D0", Slot = "4")]
	protected override Vector3 MOEMFCPIJPG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x44AA410", Offset = "0x44A8C10", VA = "0x1844AA410", Slot = "5")]
	protected override Vector3 GACPKMPJDEI(Vector3 IJBLIGDNDKF, float KMDDPMCKNCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x44AA520", Offset = "0x44A8D20", VA = "0x1844AA520", Slot = "6")]
	protected override Vector3 KAJLIFAGNKJ(Vector3 LAFNJPALCMB, Vector3 NDOKDNHCCLP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x44AA4B0", Offset = "0x44A8CB0", VA = "0x1844AA4B0", Slot = "7")]
	protected override Vector3 IMCNGFBMHFB(Vector3 LAFNJPALCMB, Vector3 NDOKDNHCCLP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x44AA640", Offset = "0x44A8E40", VA = "0x1844AA640")]
	public JGBAJGPDLGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GKIOEFAIHKC
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1D110E0", Offset = "0x1D0F8E0", VA = "0x181D110E0")]
	public static global::PEAPGKHMIMP<T1, T2> MJCPAEDCHAE<T1, T2>(T1 OOAAKLGIDKI, T2 KOMANANCLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1428400", Offset = "0x1426C00", VA = "0x181428400")]
	public static global::MIKKOHGECEH<T1, T2, T3> MJCPAEDCHAE<T1, T2, T3>(T1 OOAAKLGIDKI, T2 KOMANANCLJL, T3 GMEDMMBFEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1AB79C0", Offset = "0x1AB61C0", VA = "0x181AB79C0")]
	internal static int DDFBNILFFBK(int HNOHMGFNIFK, int LMGIKKKAKKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD7C0", Offset = "0x3EFBFC0", VA = "0x183EFD7C0")]
	internal static int DDFBNILFFBK(int HNOHMGFNIFK, int LMGIKKKAKKE, int EFEGKBDFFAP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PEAPGKHMIMP<T1, T2> : IComparable<global::PEAPGKHMIMP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 OBECEAAKILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 GINJDAALFLP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x16A34B0", Offset = "0x16A1CB0", VA = "0x1816A34B0")]
	public PEAPGKHMIMP(T1 OOAAKLGIDKI, T2 KOMANANCLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x16A1BC0", Offset = "0x16A03C0", VA = "0x1816A1BC0", Slot = "4")]
	public int CompareTo(global::PEAPGKHMIMP<T1, T2> OPFAJKJIKKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x16A1DE0", Offset = "0x16A05E0", VA = "0x1816A1DE0", Slot = "0")]
	public override bool Equals(object OPFAJKJIKKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x16A28D0", Offset = "0x16A10D0", VA = "0x1816A28D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x16A3160", Offset = "0x16A1960", VA = "0x1816A3160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MIKKOHGECEH<T1, T2, T3> : IComparable<global::MIKKOHGECEH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 OBECEAAKILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 GINJDAALFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 JCMIEKPDCKA;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x151D050", Offset = "0x151B850", VA = "0x18151D050")]
	public MIKKOHGECEH(T1 OOAAKLGIDKI, T2 KOMANANCLJL, T3 GMEDMMBFEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x151C870", Offset = "0x151B070", VA = "0x18151C870", Slot = "4")]
	public int CompareTo(global::MIKKOHGECEH<T1, T2, T3> OPFAJKJIKKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x151CA70", Offset = "0x151B270", VA = "0x18151CA70", Slot = "0")]
	public override bool Equals(object OPFAJKJIKKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x151CCD0", Offset = "0x151B4D0", VA = "0x18151CCD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x151CDD0", Offset = "0x151B5D0", VA = "0x18151CDD0", Slot = "3")]
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
	public T FAIFGLIBFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD90", Offset = "0x4DA590", VA = "0x1804DBD90")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD70", Offset = "0x4DA570", VA = "0x1804DBD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float MALDBNHMLGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C8090", Offset = "0x7C6890", VA = "0x1807C8090")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3226060", Offset = "0x3224860", VA = "0x183226060")]
	public T DCPMNJDJBEL(float KMDDPMCKNCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3226340", Offset = "0x3224B40", VA = "0x183226340")]
	public T KFNDEHABONP(float KMDDPMCKNCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PMDJGJOJHPA(T LAFNJPALCMB, T NDOKDNHCCLP, float KMDDPMCKNCH);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x44A9660", Offset = "0x44A7E60", VA = "0x1844A9660", Slot = "4")]
	protected override float PMDJGJOJHPA(float LAFNJPALCMB, float NDOKDNHCCLP, float KMDDPMCKNCH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x44A96E0", Offset = "0x44A7EE0", VA = "0x1844A96E0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x44ABB20", Offset = "0x44AA320", VA = "0x1844ABB20", Slot = "4")]
	protected override Vector3 PMDJGJOJHPA(Vector3 LAFNJPALCMB, Vector3 NDOKDNHCCLP, float KMDDPMCKNCH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x44ABBE0", Offset = "0x44AA3E0", VA = "0x1844ABBE0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x448F6E0", Offset = "0x448DEE0", VA = "0x18448F6E0", Slot = "4")]
	protected override Color PMDJGJOJHPA(Color LAFNJPALCMB, Color NDOKDNHCCLP, float KMDDPMCKNCH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x44A9260", Offset = "0x44A7A60", VA = "0x1844A9260")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class CEJIJFDBFJD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> CGLEBINNHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> CEHKGOGEGMM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AMKHCNPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x12A30A0", Offset = "0x12A18A0", VA = "0x1812A30A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool KHJDFGOONOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5121A0", Offset = "0x5109A0", VA = "0x1805121A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> GCMPCHCFHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x12A3220", Offset = "0x12A1A20", VA = "0x1812A3220", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> MPLCHJOIKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5870", Offset = "0x2CA4070", VA = "0x182CA5870", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal GDNEKPPCOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1519A30", Offset = "0x1518230", VA = "0x181519A30", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2E20150", Offset = "0x2E1E950", VA = "0x182E20150", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E1F990", Offset = "0x2E1E190", VA = "0x182E1F990", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E20030", Offset = "0x2E1E830", VA = "0x182E20030", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2E1F900", Offset = "0x2E1E100", VA = "0x182E1F900", Slot = "9")]
	public void Add(TKey PONAFPGHKNA, TVal IJBLIGDNDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2E1F930", Offset = "0x2E1E130", VA = "0x182E1F930", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MMFOPFFGONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2E1F9F0", Offset = "0x2E1E1F0", VA = "0x182E1F9F0", Slot = "8")]
	public bool ContainsKey(TKey PONAFPGHKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7280", Offset = "0x2BC5A80", VA = "0x182BC7280", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MMFOPFFGONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FF80", Offset = "0x2E1E780", VA = "0x182E1FF80", Slot = "10")]
	public bool Remove(TKey PONAFPGHKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FF80", Offset = "0x2E1E780", VA = "0x182E1FF80", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MMFOPFFGONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7F80", Offset = "0x2BC6780", VA = "0x182BC7F80", Slot = "11")]
	public bool TryGetValue(TKey PONAFPGHKNA, out TVal IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FD70", Offset = "0x2E1E570", VA = "0x182E1FD70", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FA50", Offset = "0x2E1E250", VA = "0x182E1FA50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PGLBLBGJMNL, int JJKDHNLPGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FD40", Offset = "0x2E1E540", VA = "0x182E1FD40")]
	public bool GGBLFGCAADO(TVal PONAFPGHKNA, out TKey IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FF00", Offset = "0x2E1E700", VA = "0x182E1FF00")]
	private void LGKPPNMCMAB(TKey PONAFPGHKNA, TVal PHALGOPGPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FC30", Offset = "0x2E1E430", VA = "0x182E1FC30")]
	private void FEAHJAHIHKO(TKey PONAFPGHKNA, TVal PHALGOPGPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FB70", Offset = "0x2E1E370", VA = "0x182E1FB70")]
	private bool DFGIPIJOIDM(TKey PONAFPGHKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E20080", Offset = "0x2E1E880", VA = "0x182E20080")]
	public CEJIJFDBFJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class AKMMDMGNOLO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::AKMMDMGNOLO<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x5BB5F0", Offset = "0x5B9DF0", VA = "0x1805BB5F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x148F9A0", Offset = "0x148E1A0", VA = "0x18148F9A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x148FC40", Offset = "0x148E440", VA = "0x18148FC40")]
		public Enumerator(global::AKMMDMGNOLO<T> EJJJCPNBKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x148F0E0", Offset = "0x148D8E0", VA = "0x18148F0E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x148F660", Offset = "0x148DE60", VA = "0x18148F660", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x148EEE0", Offset = "0x148D6E0", VA = "0x18148EEE0")]
		private void EINDAFDKEEH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] FDMAKLICCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int CKGEEMEHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int LAAGILHHPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int LLLILKCIOIH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AMKHCNPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x14894E0", Offset = "0x1487CE0", VA = "0x1814894E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T GDNEKPPCOMM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1489490", Offset = "0x1487C90", VA = "0x181489490")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1489270", Offset = "0x1487A70", VA = "0x181489270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x14896B0", Offset = "0x1487EB0", VA = "0x1814896B0")]
	public AKMMDMGNOLO(int MGJIDFDCMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1488630", Offset = "0x1486E30", VA = "0x181488630")]
	public void GMBMAEFCBMN(T KMDDPMCKNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1488550", Offset = "0x1486D50", VA = "0x181488550")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x14883D0", Offset = "0x1486BD0", VA = "0x1814883D0")]
	public void BIKEFCEFJFG(int MICAHCBFICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1488D90", Offset = "0x1487590", VA = "0x181488D90")]
	public void MJDCGPCAANE(T[] PGLBLBGJMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1488500", Offset = "0x1486D00", VA = "0x181488500")]
	public Enumerator CBINNPLLCJE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1489520", Offset = "0x1487D20", VA = "0x181489520", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1489520", Offset = "0x1487D20", VA = "0x181489520", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1488940", Offset = "0x1487140", VA = "0x181488940")]
	private int JANINCMPOJJ(int MPFKOFCNLNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1488C10", Offset = "0x1487410", VA = "0x181488C10")]
	private int JHDFLJAAAON(int MPFKOFCNLNB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class JGJHEJDDMLN
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	protected JGJHEJDDMLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class HMJJJHDDLEE<T> : JGJHEJDDMLN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct GMFIDEMHBGL
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum LMDLDGAGBFA
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
		public LMDLDGAGBFA AOIJDDCBKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T PDPDEJOFENK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int JOHMMFMBPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool HMPPHPAGLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool HIBCHOKELLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> ICDMAEOAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<GMFIDEMHBGL> NKOHDNNHHJM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IJAICHJHLFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x31DE6B0", Offset = "0x31DCEB0", VA = "0x1831DE6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x31DE9E0", Offset = "0x31DD1E0", VA = "0x1831DE9E0")]
	protected HMJJJHDDLEE(bool HIBCHOKELLE, bool HMPPHPAGLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x31DE2B0", Offset = "0x31DCAB0", VA = "0x1831DE2B0")]
	protected bool ELACKHFNCDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x31DE5D0", Offset = "0x31DCDD0", VA = "0x1831DE5D0")]
	protected void HALOIBMFBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x31DE830", Offset = "0x31DD030", VA = "0x1831DE830")]
	protected void NAALIOMDIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3760", Offset = "0x1DE1F60", VA = "0x181DE3760")]
	private static void OGCHGOHALLE<U>(ref List<U> NAGMKKOONEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x31DE480", Offset = "0x31DCC80", VA = "0x1831DE480", Slot = "4")]
	public void GMBMAEFCBMN(T PDPDEJOFENK, bool AIJNNIAFJMH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x31DE6F0", Offset = "0x31DCEF0", VA = "0x1831DE6F0", Slot = "5")]
	public void MEHJLGGLJCP(T PDPDEJOFENK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x31DE350", Offset = "0x31DCB50", VA = "0x1831DE350")]
	public void GFLIGMLNIBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class DHPKBHAFIMD : global::HMJJJHDDLEE<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x44A9510", Offset = "0x44A7D10", VA = "0x1844A9510")]
	public DHPKBHAFIMD(bool HIBCHOKELLE = false, bool HMPPHPAGLMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x44A9300", Offset = "0x44A7B00", VA = "0x1844A9300")]
	public void BENNCNFFHML()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x44A94B0", Offset = "0x44A7CB0", VA = "0x1844A94B0")]
	public static DHPKBHAFIMD GEEIFHBIFJB(DHPKBHAFIMD LLPADDNLLLC, Action PDPDEJOFENK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x44A92A0", Offset = "0x44A7AA0", VA = "0x1844A92A0")]
	public static DHPKBHAFIMD APDCNPBNMGE(DHPKBHAFIMD LLPADDNLLLC, Action PDPDEJOFENK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface FCNEBKLCCAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMBMAEFCBMN(Action<T> PDPDEJOFENK, bool AIJNNIAFJMH = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEHJLGGLJCP(Action<T> PDPDEJOFENK);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class ELMFFFGIEKM<T> : global::HMJJJHDDLEE<Action<T>>, global::FCNEBKLCCAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x16A16C0", Offset = "0x169FEC0", VA = "0x1816A16C0")]
	public ELMFFFGIEKM(bool HIBCHOKELLE = false, bool HMPPHPAGLMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E680", Offset = "0x1F6CE80", VA = "0x181F6E680")]
	public void BENNCNFFHML(T KMDDPMCKNCH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x178DC00", Offset = "0x178C400", VA = "0x18178DC00")]
	public static global::ELMFFFGIEKM<T> GEEIFHBIFJB(global::ELMFFFGIEKM<T> LLPADDNLLLC, Action<T> PDPDEJOFENK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x178BF80", Offset = "0x178A780", VA = "0x18178BF80")]
	public static global::ELMFFFGIEKM<T> APDCNPBNMGE(global::ELMFFFGIEKM<T> LLPADDNLLLC, Action<T> PDPDEJOFENK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DAPKLIIMHGF<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class NAILFIBIJOL<T, U> : global::HMJJJHDDLEE<Action<T, U>>, global::DAPKLIIMHGF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x16A16C0", Offset = "0x169FEC0", VA = "0x1816A16C0")]
	public NAILFIBIJOL(bool HIBCHOKELLE = false, bool HMPPHPAGLMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3023940", Offset = "0x3022140", VA = "0x183023940")]
	public void BENNCNFFHML(T KMDDPMCKNCH, U JJPKFMHHOEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x178DC00", Offset = "0x178C400", VA = "0x18178DC00")]
	public static global::NAILFIBIJOL<T, U> GEEIFHBIFJB(global::NAILFIBIJOL<T, U> LLPADDNLLLC, Action<T, U> PDPDEJOFENK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x178BF80", Offset = "0x178A780", VA = "0x18178BF80")]
	public static global::NAILFIBIJOL<T, U> APDCNPBNMGE(global::NAILFIBIJOL<T, U> LLPADDNLLLC, Action<T, U> PDPDEJOFENK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class HJAJJEPCAHP<T, U, V> : global::HMJJJHDDLEE<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x16A16C0", Offset = "0x169FEC0", VA = "0x1816A16C0")]
	public HJAJJEPCAHP(bool HIBCHOKELLE = false, bool HMPPHPAGLMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x19FD570", Offset = "0x19FBD70", VA = "0x1819FD570")]
	public void BENNCNFFHML(T KMDDPMCKNCH, U JJPKFMHHOEP, V BMBKCHGKIDM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x178DC00", Offset = "0x178C400", VA = "0x18178DC00")]
	public static global::HJAJJEPCAHP<T, U, V> GEEIFHBIFJB(global::HJAJJEPCAHP<T, U, V> LLPADDNLLLC, Action<T, U, V> PDPDEJOFENK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x178BF80", Offset = "0x178A780", VA = "0x18178BF80")]
	public static global::HJAJJEPCAHP<T, U, V> APDCNPBNMGE(global::HJAJJEPCAHP<T, U, V> LLPADDNLLLC, Action<T, U, V> PDPDEJOFENK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JNFNDKALFJJ<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class JFPFOBCEADA<T, U, V, W> : global::HMJJJHDDLEE<Action<T, U, V, W>>, global::JNFNDKALFJJ<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x16A16C0", Offset = "0x169FEC0", VA = "0x1816A16C0")]
	public JFPFOBCEADA(bool HIBCHOKELLE = false, bool HMPPHPAGLMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x178D6A0", Offset = "0x178BEA0", VA = "0x18178D6A0")]
	public void BENNCNFFHML(T KMDDPMCKNCH, U JJPKFMHHOEP, V BMBKCHGKIDM, W MBFPBJEPPGO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x178DC00", Offset = "0x178C400", VA = "0x18178DC00")]
	public static global::JFPFOBCEADA<T, U, V, W> GEEIFHBIFJB(global::JFPFOBCEADA<T, U, V, W> LLPADDNLLLC, Action<T, U, V, W> PDPDEJOFENK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x178BF80", Offset = "0x178A780", VA = "0x18178BF80")]
	public static global::JFPFOBCEADA<T, U, V, W> APDCNPBNMGE(global::JFPFOBCEADA<T, U, V, W> LLPADDNLLLC, Action<T, U, V, W> PDPDEJOFENK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NGDFALIEEBG<T, U, V, W, X> : global::HMJJJHDDLEE<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x16A16C0", Offset = "0x169FEC0", VA = "0x1816A16C0")]
	public NGDFALIEEBG(bool HIBCHOKELLE = false, bool HMPPHPAGLMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3290550", Offset = "0x328ED50", VA = "0x183290550")]
	public void BENNCNFFHML(T KMDDPMCKNCH, U JJPKFMHHOEP, V BMBKCHGKIDM, W MBFPBJEPPGO, X MMPPHFIGGJG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x178DC00", Offset = "0x178C400", VA = "0x18178DC00")]
	public static global::NGDFALIEEBG<T, U, V, W, X> GEEIFHBIFJB(global::NGDFALIEEBG<T, U, V, W, X> LLPADDNLLLC, Action<T, U, V, W, X> PDPDEJOFENK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x178BF80", Offset = "0x178A780", VA = "0x18178BF80")]
	public static global::NGDFALIEEBG<T, U, V, W, X> APDCNPBNMGE(global::NGDFALIEEBG<T, U, V, W, X> LLPADDNLLLC, Action<T, U, V, W, X> PDPDEJOFENK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GLLIICMMFMO<T, U, V, W, X, Y> : global::HMJJJHDDLEE<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x16A16C0", Offset = "0x169FEC0", VA = "0x1816A16C0")]
	public GLLIICMMFMO(bool HIBCHOKELLE = false, bool HMPPHPAGLMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E210", Offset = "0x2A4CA10", VA = "0x182A4E210")]
	public void BENNCNFFHML(T KMDDPMCKNCH, U JJPKFMHHOEP, V BMBKCHGKIDM, W MBFPBJEPPGO, X MMPPHFIGGJG, Y CJNFJPHGPCE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x178DC00", Offset = "0x178C400", VA = "0x18178DC00")]
	public static global::GLLIICMMFMO<T, U, V, W, X, Y> GEEIFHBIFJB(global::GLLIICMMFMO<T, U, V, W, X, Y> LLPADDNLLLC, Action<T, U, V, W, X, Y> PDPDEJOFENK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x178BF80", Offset = "0x178A780", VA = "0x18178BF80")]
	public static global::GLLIICMMFMO<T, U, V, W, X, Y> APDCNPBNMGE(global::GLLIICMMFMO<T, U, V, W, X, Y> LLPADDNLLLC, Action<T, U, V, W, X, Y> PDPDEJOFENK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct ECOFLEGAMDC
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class CGKDCDJNFDA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct DKCCBMEPNNC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly global::CGKDCDJNFDA<T> GDIOECNGADJ;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public T FAIFGLIBFJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x30DA9E0", Offset = "0x30D91E0", VA = "0x1830DA9E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x30DA9B0", Offset = "0x30D91B0", VA = "0x1830DA9B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A4EF0", Offset = "0x5A36F0", VA = "0x1805A4EF0")]
		public DKCCBMEPNNC(global::CGKDCDJNFDA<T> GDIOECNGADJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim ELOKNCBMJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T OAJNIPNINIL;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30D01E0", Offset = "0x30CE9E0", VA = "0x1830D01E0")]
	public CGKDCDJNFDA(in T OAJNIPNINIL, int HHDCILIBJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x30D01B0", Offset = "0x30CE9B0", VA = "0x1830D01B0")]
	public CGKDCDJNFDA(in T OAJNIPNINIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x30D00F0", Offset = "0x30CE8F0", VA = "0x1830D00F0")]
	public DKCCBMEPNNC JGCPOOJFFJI()
	{
		return default(DKCCBMEPNNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class HHMAPANCNJP
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x44A9720", Offset = "0x44A7F20", VA = "0x1844A9720")]
	public static global::CGKDCDJNFDA<ECOFLEGAMDC> FMGDFIPIBPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x14283A0", Offset = "0x1426BA0", VA = "0x1814283A0")]
	public static global::CGKDCDJNFDA<T> FMGDFIPIBPP<T>(in T OAJNIPNINIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NIMPDMJAOIC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate bool DFOGDHFGOJB(global::NIMPDMJAOIC<T> BMIEINLMCHG);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KDMCAGHGFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public global::NIMPDMJAOIC<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		public KDMCAGHGFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x380E310", Offset = "0x380CB10", VA = "0x18380E310")]
		internal bool <FindNode>b__0(global::NIMPDMJAOIC<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public T HKOBAKPLPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LinkedList<global::NIMPDMJAOIC<T>> CCJHHLLKFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public global::NIMPDMJAOIC<T> JABLEDKJLHG;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::NIMPDMJAOIC<T> GBKDAHBJKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4D7A30", Offset = "0x4D6230", VA = "0x1804D7A30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3810890", Offset = "0x380F090", VA = "0x183810890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool OJEEPBDLAFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x380F920", Offset = "0x380E120", VA = "0x18380F920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GBCBLKMFHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3811B30", Offset = "0x3810330", VA = "0x183811B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::NIMPDMJAOIC<T> IOHEHEBKIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x380F690", Offset = "0x380DE90", VA = "0x18380F690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3811C00", Offset = "0x3810400", VA = "0x183811C00")]
	public NIMPDMJAOIC(T PLOKEAPKCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x380F800", Offset = "0x380E000", VA = "0x18380F800")]
	public global::NIMPDMJAOIC<T> DAJCAFBJBNJ(T CBCIECDKJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3811580", Offset = "0x380FD80", VA = "0x183811580")]
	public global::NIMPDMJAOIC<T> PBOECJMNBKN(T ELMNPEOHMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x38114D0", Offset = "0x380FCD0", VA = "0x1838114D0")]
	public global::NIMPDMJAOIC<T> MEHJLGGLJCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x380FBA0", Offset = "0x380E3A0", VA = "0x18380FBA0")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x38119E0", Offset = "0x38101E0", VA = "0x1838119E0")]
	public global::NIMPDMJAOIC<T> PGHBHFEJIJD(T AOEMKHEFPOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x380FDF0", Offset = "0x380E5F0", VA = "0x18380FDF0")]
	public static void IBJBLKOPPIF(global::NIMPDMJAOIC<T> KJMDKLKOKMP, DFOGDHFGOJB OGHIFJBFAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2220110", Offset = "0x221E910", VA = "0x182220110")]
	public static void IBJBLKOPPIF<A>(global::NIMPDMJAOIC<T> KJMDKLKOKMP, Func<global::NIMPDMJAOIC<T>, A, bool> OGHIFJBFAJI, A LAGBBMGKDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3810A10", Offset = "0x380F210", VA = "0x183810A10")]
	public static string KDGFNBPEINO(global::NIMPDMJAOIC<T> KJMDKLKOKMP, int AMPIGIOMCIP = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3810670", Offset = "0x380EE70", VA = "0x183810670")]
	public static global::NIMPDMJAOIC<T> IHCMBKGIGOD(global::NIMPDMJAOIC<T> KJMDKLKOKMP, T KJOEIDEENEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class HKHELPCECFI<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate int ONADNCNKNPL(TKey PONAFPGHKNA, TVal IJBLIGDNDKF);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class HEEMFBBLIJH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey JHBMCIBCLPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal FAIFGLIBFJG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x5B6350", Offset = "0x5B4B50", VA = "0x1805B6350")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5B62D0", Offset = "0x5B4AD0", VA = "0x1805B62D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int OJPKJHOJEIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x66E910", Offset = "0x66D110", VA = "0x18066E910")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x66E360", Offset = "0x66CB60", VA = "0x18066E360")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime CJKJNDCOCKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4D7840", Offset = "0x4D6040", VA = "0x1804D7840")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4D7830", Offset = "0x4D6030", VA = "0x1804D7830")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x19FA8F0", Offset = "0x19F90F0", VA = "0x1819FA8F0")]
		public HEEMFBBLIJH(TKey PONAFPGHKNA, TVal PHALGOPGPFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const int APPIPKLDOKC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Dictionary<TKey, LinkedListNode<HEEMFBBLIJH>> OEPPEBCJIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LinkedList<HEEMFBBLIJH> JNMFKECEOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly ONADNCNKNPL EPGEBENNEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly TimeSpan CBKHKBOMFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NLACLHNBION KIJCAOKHKIB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int NHCMAKPHMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x534120", Offset = "0x532920", VA = "0x180534120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool KOIIACLIKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1A00360", Offset = "0x19FEB60", VA = "0x181A00360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int OOKGGNELGCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60BD10", Offset = "0x60A510", VA = "0x18060BD10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x60BCB0", Offset = "0x60A4B0", VA = "0x18060BCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey GDNEKPPCOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1A00AF0", Offset = "0x19FF2F0", VA = "0x181A00AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x31D1B80", Offset = "0x31D0380", VA = "0x1831D1B80")]
	public HKHELPCECFI(int MGJIDFDCMAK, [Optional] ONADNCNKNPL EPGEBENNEOF, [Optional] IEqualityComparer<TKey> AKDDJMOPNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1A00C80", Offset = "0x19FF480", VA = "0x181A00C80")]
	public HKHELPCECFI(int MGJIDFDCMAK, ONADNCNKNPL EPGEBENNEOF, TimeSpan CBKHKBOMFFE, [Optional] IEqualityComparer<TKey> AKDDJMOPNDM, [Optional] NLACLHNBION KIJCAOKHKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1A00B20", Offset = "0x19FF320", VA = "0x181A00B20")]
	public void NHKHCAONGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1A001E0", Offset = "0x19FE9E0", VA = "0x181A001E0")]
	public void DHKGPHPMDFB(TKey PONAFPGHKNA, TVal IJBLIGDNDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1A00970", Offset = "0x19FF170", VA = "0x181A00970")]
	public bool MEHJLGGLJCP(TKey PONAFPGHKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x31D1690", Offset = "0x31CFE90", VA = "0x1831D1690")]
	public bool GGBLFGCAADO(TKey COHOADKHCMD, out TVal IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1A003F0", Offset = "0x19FEBF0", VA = "0x181A003F0")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1A002A0", Offset = "0x19FEAA0", VA = "0x181A002A0")]
	private bool DKEDKGOBNBF(HEEMFBBLIJH PHPKDBCMDGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x19FFF60", Offset = "0x19FE760", VA = "0x1819FFF60")]
	private void DDEGNBJJCAB(LinkedListNode<HEEMFBBLIJH> EABDHJBDJCE, TVal BKBGKDHNKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1A005C0", Offset = "0x19FEDC0", VA = "0x181A005C0")]
	private void JJLOLNHLODB(TKey PONAFPGHKNA, TVal IJBLIGDNDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1A007D0", Offset = "0x19FEFD0", VA = "0x181A007D0")]
	private void LKMEAJGAKDD(HEEMFBBLIJH PHPKDBCMDGB, TVal BKBGKDHNKHP, int OLOPHLIGBKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class LAJICINENPL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<T> NAGMKKOONEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private HashSet<T> CEDCCNMCODP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AMKHCNPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x12A30A0", Offset = "0x12A18A0", VA = "0x1812A30A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool KHJDFGOONOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5121A0", Offset = "0x5109A0", VA = "0x1805121A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T GDNEKPPCOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x25B9A90", Offset = "0x25B8290", VA = "0x1825B9A90", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x25B9B80", Offset = "0x25B8380", VA = "0x1825B9B80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x25AFB80", Offset = "0x25AE380", VA = "0x1825AFB80", Slot = "11")]
	public void Add(T MMFOPFFGONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x25B9670", Offset = "0x25B7E70", VA = "0x1825B9670")]
	public bool PMIDMHDBKKO(T MMFOPFFGONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x25B9940", Offset = "0x25B8140", VA = "0x1825B9940", Slot = "15")]
	public bool Remove(T MMFOPFFGONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x25B93B0", Offset = "0x25B7BB0", VA = "0x1825B93B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x151F240", Offset = "0x151DA40", VA = "0x18151F240", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x25B9320", Offset = "0x25B7B20", VA = "0x1825B9320", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1694F10", Offset = "0x1693710", VA = "0x181694F10", Slot = "13")]
	public bool Contains(T MMFOPFFGONI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x25B9380", Offset = "0x25B7B80", VA = "0x1825B9380", Slot = "14")]
	public void CopyTo(T[] PGLBLBGJMNL, int JJKDHNLPGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1519A30", Offset = "0x1518230", VA = "0x181519A30", Slot = "6")]
	public int IndexOf(T MMFOPFFGONI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x25B9430", Offset = "0x25B7C30", VA = "0x1825B9430", Slot = "7")]
	public void Insert(int MPFKOFCNLNB, T MMFOPFFGONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x25B97E0", Offset = "0x25B7FE0", VA = "0x1825B97E0", Slot = "8")]
	public void RemoveAt(int MPFKOFCNLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x25B99C0", Offset = "0x25B81C0", VA = "0x1825B99C0")]
	public LAJICINENPL()
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
			[Cpp2IlInjected.Address(RVA = "0x1741C90", Offset = "0x1740490", VA = "0x181741C90")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x44AB4F0", Offset = "0x44A9CF0", VA = "0x1844AB4F0")]
		public SerializedGuid(in Guid BEPLFPBNCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x44AB3B0", Offset = "0x44A9BB0", VA = "0x1844AB3B0")]
		public static SerializedGuid LDCMENNNJOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x44AB330", Offset = "0x44A9B30", VA = "0x1844AB330")]
		public static SerializedGuid INOENOKKHON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x44AB110", Offset = "0x44A9910", VA = "0x1844AB110")]
		public bool DHCFBGBNBJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x44AB4D0", Offset = "0x44A9CD0", VA = "0x1844AB4D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x44AB430", Offset = "0x44A9C30", VA = "0x1844AB430", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x44AB1A0", Offset = "0x44A99A0", VA = "0x1844AB1A0", Slot = "7")]
		public bool Equals(SerializedGuid OPFAJKJIKKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x44AB240", Offset = "0x44A9A40", VA = "0x1844AB240", Slot = "0")]
		public override bool Equals(object ANEGDOBGOJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x44AB320", Offset = "0x44A9B20", VA = "0x1844AB320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x44AB0E0", Offset = "0x44A98E0", VA = "0x1844AB0E0", Slot = "6")]
		public int CompareTo(SerializedGuid OPFAJKJIKKM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class KBNACOIMHON : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Type HCMABHEPCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string HCIBDOLELAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool CGEJLDOOHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool MGBFJICNFCK;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x44AA6A0", Offset = "0x44A8EA0", VA = "0x1844AA6A0")]
	public KBNACOIMHON(Type OGFKDEOJFCA, string HCIPBHGBDLJ, bool CAJFMAPFBBA = false, bool MPBOCGAHMBK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface GAIMOGPJANL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T FAIFGLIBFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FMGEFIJKMIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::GAIMOGPJANL<T> EGLGOJIJBIJ(Action<T> GNLDFPADOAJ);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::GAIMOGPJANL<T> NPINOEMFMEC(Action<T> GNLDFPADOAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GIFNGKIKKBE<T> : global::GAIMOGPJANL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private global::NAILFIBIJOL<T, T> LDILMOHGLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private global::ELMFFFGIEKM<T> JGPECNEOANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private global::ELMFFFGIEKM<string> CEMPGMOOKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string IKFKMGDIJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private T GBDMLAIBOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool KEHDJJMGBNK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T FAIFGLIBFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD90", Offset = "0x4DA590", VA = "0x1804DBD90", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x169C4A0", Offset = "0x169ACA0", VA = "0x18169C4A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FMGEFIJKMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E2900", Offset = "0x5E1100", VA = "0x1805E2900", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2A4DD70", Offset = "0x2A4C570", VA = "0x182A4DD70")]
	private void JMFPAALFGDI(T ONECPGALACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2A4DCF0", Offset = "0x2A4C4F0", VA = "0x182A4DCF0", Slot = "4")]
	public global::GAIMOGPJANL<T> EGLGOJIJBIJ(Action<T> AHCFPIDGJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2A4DDF0", Offset = "0x2A4C5F0", VA = "0x182A4DDF0", Slot = "5")]
	public global::GAIMOGPJANL<T> NPINOEMFMEC(Action<T> GNLDFPADOAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2A4DE20", Offset = "0x2A4C620", VA = "0x182A4DE20")]
	public GIFNGKIKKBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class CJCBEOKLGHD
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class ANKMIPKPKHJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public global::GAIMOGPJANL<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public global::BBIKMBOLBHD<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		public ANKMIPKPKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x30CE5D0", Offset = "0x30CCDD0", VA = "0x1830CE5D0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x18C3D40", Offset = "0x18C2540", VA = "0x1818C3D40")]
	public static global::GHMNNNIJAKN<T> NHJGGMOBGOE<T>(this global::GAIMOGPJANL<T> FBLKDLAPOEO, Action<T> DAGCGBINJLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class NLACLHNBION
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class MHKLIABELHD : NLACLHNBION
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static NLACLHNBION LFFPMMLBFND
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x44AA750", Offset = "0x44A8F50", VA = "0x1844AA750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime IMDEHOJKKJC
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x44AA7B0", Offset = "0x44A8FB0", VA = "0x1844AA7B0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x44AA890", Offset = "0x44A9090", VA = "0x1844AA890")]
		public MHKLIABELHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static NLACLHNBION FPKMADCBJIO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static NLACLHNBION CPKPCEMIEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x44AAD00", Offset = "0x44A9500", VA = "0x1844AAD00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime IMDEHOJKKJC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	protected NLACLHNBION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class DMCEGICFLIG : global::JENCHNFHPGG<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x44A9570", Offset = "0x44A7D70", VA = "0x1844A9570")]
	public DMCEGICFLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class JENCHNFHPGG<T> : global::EHKKGDICGNA<T>, PNICOPAJMPA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> LDBFMADOOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::GHMNNNIJAKN<T> KACICBIBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private JFNFLBIAFDM BALHILIBEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xFF0230", Offset = "0xFEEA30", VA = "0x180FF0230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x178A0D0", Offset = "0x17888D0", VA = "0x18178A0D0")]
	public JENCHNFHPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DNHJLEANAKM<T> : global::EHKKGDICGNA<T>, PNICOPAJMPA, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> LDBFMADOOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::GHMNNNIJAKN<T> KACICBIBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private JFNFLBIAFDM BALHILIBEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xFF0230", Offset = "0xFEEA30", VA = "0x180FF0230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x12A4F50", Offset = "0x12A3750", VA = "0x1812A4F50")]
	public DNHJLEANAKM(Exception LKMCNIANCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PNICOPAJMPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	JFNFLBIAFDM KACICBIBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EHKKGDICGNA<T> : PNICOPAJMPA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> LDBFMADOOHE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::GHMNNNIJAKN<T> KACICBIBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class MEAKPLAGIND<TTask, T> : global::EHKKGDICGNA<T>, PNICOPAJMPA, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class KIMKGEKNFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public global::MEAKPLAGIND<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		public KIMKGEKNFJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static bool KDCJAHHOEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Task<T> DPFCGPLFJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly CancellationTokenSource NBKIJPFNOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool KEIDMNCCLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private SynchronizationContext GMHIIBKCHID;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> LDBFMADOOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::GHMNNNIJAKN<T> KACICBIBLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private JFNFLBIAFDM BALHILIBEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x12AD5B0", Offset = "0x12ABDB0", VA = "0x1812AD5B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool PMOGDJPMBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4E11E0", Offset = "0x4DF9E0", VA = "0x1804E11E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x151B340", Offset = "0x1519B40", VA = "0x18151B340")]
	static MEAKPLAGIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x151B620", Offset = "0x1519E20", VA = "0x18151B620")]
	protected MEAKPLAGIND(TTask DPFCGPLFJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x151B200", Offset = "0x1519A00", VA = "0x18151B200", Slot = "1")]
	~MEAKPLAGIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x151B180", Offset = "0x1519980", VA = "0x18151B180", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x151AEA0", Offset = "0x15196A0", VA = "0x18151AEA0")]
	private void ADDJJGOGOME(bool HIJJIDKLOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KGAIAAGEPMO(TTask IPCJNHLHNJB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void CLMNHLEGIJM();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x151B1B0", Offset = "0x15199B0", VA = "0x18151B1B0")]
	[CompilerGenerated]
	private void FCCFJBEDDPB(object DJJODGDFELM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NLLNFLCAOPN<T> : IEnumerable<global::NLLNFLCAOPN<T>.AJHGPHGNCGB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct AJHGPHGNCGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public T IJBLIGDNDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int MPFKOFCNLNB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class KOGMDMCIHDG : IEnumerator<AJHGPHGNCGB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::NLLNFLCAOPN<T> MOFEKDNMJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int MPFKOFCNLNB;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1F0BB10", Offset = "0x1F0A310", VA = "0x181F0BB10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public AJHGPHGNCGB PGDHPONEBEL
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x380E4B0", Offset = "0x380CCB0", VA = "0x18380E4B0", Slot = "4")]
			get
			{
				return default(AJHGPHGNCGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x21455F0", Offset = "0x2143DF0", VA = "0x1821455F0")]
		public KOGMDMCIHDG(global::NLLNFLCAOPN<T> MOFEKDNMJGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x380E420", Offset = "0x380CC20", VA = "0x18380E420", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5907D0", Offset = "0x58EFD0", VA = "0x1805907D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x75DAF0", Offset = "0x75C2F0", VA = "0x18075DAF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct EAOHLPAOEJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public bool OKJLKLDJKFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public T IJBLIGDNDKF;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private const int FCJJFLDHBOD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private Dictionary<T, int> PMGBEKOFMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EAOHLPAOEJM[] NBLDBOEEMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private int LMIEGDPIEOP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int AMKHCNPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x12A3220", Offset = "0x12A1A20", VA = "0x1812A3220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3812120", Offset = "0x3810920", VA = "0x183812120")]
	public static global::NLLNFLCAOPN<T> PNLPCBBHFEE(AJHGPHGNCGB[] EHHDKEGPPEK, bool JNMDFCCMEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3812550", Offset = "0x3810D50", VA = "0x183812550")]
	public NLLNFLCAOPN(int MGJIDFDCMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3811E20", Offset = "0x3810620", VA = "0x183811E20")]
	public int JOIKIKNGEAG(T IJBLIGDNDKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3811E70", Offset = "0x3810670", VA = "0x183811E70")]
	public T NHJGGMOBGOE(int MPFKOFCNLNB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3811F30", Offset = "0x3810730", VA = "0x183811F30")]
	public bool PMIDMHDBKKO(T IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3811F50", Offset = "0x3810750", VA = "0x183811F50")]
	public bool PMIDMHDBKKO(T IJBLIGDNDKF, int MPFKOFCNLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3811CE0", Offset = "0x38104E0", VA = "0x183811CE0")]
	public AJHGPHGNCGB[] JCGAMCJPDJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3811EE0", Offset = "0x38106E0", VA = "0x183811EE0")]
	private int NKHDCOLMFFD(int CKGEEMEHNFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x38124E0", Offset = "0x3810CE0", VA = "0x1838124E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x38124E0", Offset = "0x3810CE0", VA = "0x1838124E0", Slot = "4")]
	private IEnumerator<AJHGPHGNCGB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class IAHFMHFCEKE<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private List<T> PNFJHPICBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<T> KNAMAFIBJID;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x31E0940", Offset = "0x31DF140", VA = "0x1831E0940")]
	public IAHFMHFCEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x31E07E0", Offset = "0x31DEFE0", VA = "0x1831E07E0")]
	public IAHFMHFCEKE(int MGJIDFDCMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x31E05C0", Offset = "0x31DEDC0", VA = "0x1831E05C0")]
	public T AOFNJLMIJJC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x31E06C0", Offset = "0x31DEEC0", VA = "0x1831E06C0")]
	public void BHLCJFMEMKG(T KCKCAIJIDOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class BLMAOGKAHLA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private Dictionary<int, T> KJIHFIGMCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private T HDFLEELLEPO;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual T IGGALFLIPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4D7820", Offset = "0x4D6020", VA = "0x1804D7820", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3D10", Offset = "0x2BC2510", VA = "0x182BC3D10")]
	public bool JJLOLNHLODB(T IJBLIGDNDKF, int FNEPEMJHJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3A80", Offset = "0x2BC2280", VA = "0x182BC3A80")]
	public bool ENAHMAFKDHN(int FNEPEMJHJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3820", Offset = "0x2BC2020", VA = "0x182BC3820")]
	public T AFAJAHPHFKD(int DNKIAGOMPNP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3B10", Offset = "0x2BC2310", VA = "0x182BC3B10")]
	private bool HLKHOOAOHON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3AE0", Offset = "0x2BC22E0", VA = "0x182BC3AE0")]
	public bool GGBLFGCAADO(int FNEPEMJHJEH, out T IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3D70", Offset = "0x2BC2570", VA = "0x182BC3D70")]
	public BLMAOGKAHLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MOOLNCDJGKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	protected struct IOKMAIOGNKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public T FAIFGLIBFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int KDKHHFDPIKD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected readonly List<IOKMAIOGNKL> FDMAKLICCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private T FKJLPIBAFAI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int AMKHCNPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x12A30A0", Offset = "0x12A18A0", VA = "0x1812A30A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x301DE30", Offset = "0x301C630", VA = "0x18301DE30")]
	public bool DAECMIACEAH(T IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x301E0E0", Offset = "0x301C8E0", VA = "0x18301E0E0")]
	public void GMBMAEFCBMN(T IJBLIGDNDKF, int FNEPEMJHJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x301E1F0", Offset = "0x301C9F0", VA = "0x18301E1F0")]
	public bool MEHJLGGLJCP(T IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x301E080", Offset = "0x301C880", VA = "0x18301E080")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x301E160", Offset = "0x301C960", VA = "0x18301E160")]
	public T IHGLCDFOPMP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x301E310", Offset = "0x301CB10", VA = "0x18301E310")]
	private void MOJAEFEENGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x301E520", Offset = "0x301CD20", VA = "0x18301E520")]
	public MOOLNCDJGKC()
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
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x10018C0", Offset = "0x10000C0", VA = "0x1810018C0", Slot = "4")]
		public virtual T HNACGADFNJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class IIKONMDLKKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Dictionary<byte, NJMLJJHEMIM> DGPHIIBDAHC;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public NJMLJJHEMIM LAMOHAMGIME
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4D7860", Offset = "0x4D6060", VA = "0x1804D7860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4D7850", Offset = "0x4D6050", VA = "0x1804D7850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Vector2 LJCFCMFJPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xC07A50", Offset = "0xC06250", VA = "0x180C07A50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x12A9BB0", Offset = "0x12A83B0", VA = "0x1812A9BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector2 OOLHDAECMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x14073B0", Offset = "0x1405BB0", VA = "0x1814073B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Vector2 AJICJFNLOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2F6EA40", Offset = "0x2F6D240", VA = "0x182F6EA40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2F6EA60", Offset = "0x2F6D260", VA = "0x182F6EA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int JENDPLHODOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A30", Offset = "0x5D2230", VA = "0x1805D3A30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A50", Offset = "0x5D2250", VA = "0x1805D3A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x44A9F20", Offset = "0x44A8720", VA = "0x1844A9F20")]
	public IIKONMDLKKG(Bounds NBMIKPOJCOP, Vector2[] AGDFANAFFAP, int DFGLCOILNGG, byte CKGEEMEHNFN, float FFOKIDCGBGI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x44A9780", Offset = "0x44A7F80", VA = "0x1844A9780")]
	public NJMLJJHEMIM BHFMEHCLLMG(byte MPFKOFCNLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x44A9D20", Offset = "0x44A8520", VA = "0x1844A9D20")]
	public void JMDNOIDPEPD(Vector3 LPGKEGGPIKC, float AFEAEPGKFJG, float CHBKNCDLOEJ, ref List<byte> OGBKMHEFLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x44A97E0", Offset = "0x44A7FE0", VA = "0x1844A97E0")]
	public void FAJGOKJBGFO(NJMLJJHEMIM.BHDCCLBAIFE HDDLICKFKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x44A9E00", Offset = "0x44A8600", VA = "0x1844A9E00")]
	private NJMLJJHEMIM MCIIHIHPDCL(byte MPFKOFCNLNB, NJMLJJHEMIM.EINDKGEFDDB HPNEEHKECGG, NJMLJJHEMIM PJIPIGLGNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x44A9800", Offset = "0x44A8000", VA = "0x1844A9800")]
	private void FBGFNEBNFHM(NJMLJJHEMIM PJIPIGLGNDL, Vector2[] AGDFANAFFAP, int GNCCHEEFLPK, int KKJFEHJCBID, int NHKCAFEHOPO, int FMJBDPLJCJC, float FFOKIDCGBGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class NJMLJJHEMIM
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum EINDKGEFDDB
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum BHDCCLBAIFE
	{
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public byte HMJPBMMFFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Vector3 BJMAONADAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Vector3 OJPKJHOJEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Vector3 LNGFALGCIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 ALEEDJNPLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public EINDKGEFDDB POLOJPELPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NJMLJJHEMIM GBKDAHBJKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public List<NJMLJJHEMIM> FJMLPHILDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool LDCAPKJDJGA;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x44AACB0", Offset = "0x44A94B0", VA = "0x1844AACB0")]
	public NJMLJJHEMIM(byte POBBJHJOENB, EINDKGEFDDB HPNEEHKECGG, NJMLJJHEMIM PJIPIGLGNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x44AA930", Offset = "0x44A9130", VA = "0x1844AA930")]
	public void DAJCAFBJBNJ(NJMLJJHEMIM GIJKOILBNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0")]
	public void FAJGOKJBGFO(int GAOBCMGEEGH, BHDCCLBAIFE HDDLICKFKAM, int OFKJCNIAJBJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x44AAA20", Offset = "0x44A9220", VA = "0x1844AAA20")]
	public void JMDNOIDPEPD(List<byte> OGBKMHEFLAB, Vector3 LPGKEGGPIKC, float AFEAEPGKFJG, float CHBKNCDLOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x44AA9C0", Offset = "0x44A91C0", VA = "0x1844AA9C0")]
	public bool DJMDAJJHCCO(Vector3 CEIKLBCBHDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x44AA8F0", Offset = "0x44A90F0", VA = "0x1844AA8F0")]
	public bool BJOLBNGGKJK(Vector3 CEIKLBCBHDB, float FLFAOGHKPHL)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public struct BKBKBAINDIF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private readonly List<Component> NAGMKKOONEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private readonly bool PCHICOLHJMH;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xFF0680", Offset = "0xFEEE80", VA = "0x180FF0680")]
			public BKBKBAINDIF(List<Component> NAGMKKOONEF, bool PCHICOLHJMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xFF0540", Offset = "0xFEED40", VA = "0x180FF0540")]
			public MDEBAHKOFHA<T> CBINNPLLCJE()
			{
				return default(MDEBAHKOFHA<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xFF05B0", Offset = "0xFEEDB0", VA = "0x180FF05B0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xFF05B0", Offset = "0xFEEDB0", VA = "0x180FF05B0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public struct MDEBAHKOFHA<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private readonly List<Component> NAGMKKOONEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private readonly bool PCHICOLHJMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private int MPFKOFCNLNB;

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public T PGDHPONEBEL
			{
				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0xFF8A50", Offset = "0xFF7250", VA = "0x180FF8A50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0xFF8A00", Offset = "0xFF7200", VA = "0x180FF8A00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xFF8A40", Offset = "0xFF7240", VA = "0x180FF8A40")]
			public MDEBAHKOFHA(List<Component> NAGMKKOONEF, bool PCHICOLHJMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xFF8930", Offset = "0xFF7130", VA = "0x180FF8930", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xFF8940", Offset = "0xFF7140", VA = "0x180FF8940", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xFF89F0", Offset = "0xFF71F0", VA = "0x180FF89F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x44AB8A0", Offset = "0x44AA0A0", VA = "0x1844AB8A0")]
		private void PFFHEPFDHJF(GameObject LGCHCBHLGAI, bool ECMFLMJNKPO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x44AB990", Offset = "0x44AA190", VA = "0x1844AB990")]
		public static void PFFHEPFDHJF(GameObject LGCHCBHLGAI, ref ToolHierarchyCache BPDBEEIMJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1572DF0", Offset = "0x15715F0", VA = "0x181572DF0")]
		public void JAFPDPGGGKM<T>(Action<T> PDPDEJOFENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1D179F0", Offset = "0x1D161F0", VA = "0x181D179F0")]
		public BKBKBAINDIF<T> FGMKOEKAAJE<T>(bool PCHICOLHJMH = false) where T : class
		{
			return default(BKBKBAINDIF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x44AB610", Offset = "0x44A9E10", VA = "0x1844AB610")]
		public List<Component> IAGJFOODHFA(Type AOIJDDCBKCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x44AB520", Offset = "0x44A9D20", VA = "0x1844AB520", Slot = "4")]
		public bool Equals(ToolHierarchyCache MMPPHFIGGJG, ToolHierarchyCache CJNFJPHGPCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x44AB5A0", Offset = "0x44A9DA0", VA = "0x1844AB5A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ANEGDOBGOJI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class HJHFKOOCCLH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int MGJIDFDCMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int JAEABFPHIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private List<T> LFMDABOELNG;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T PGPMIFHBGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x19FF1A0", Offset = "0x19FD9A0", VA = "0x1819FF1A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public T BABJLKCOJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x19FF600", Offset = "0x19FDE00", VA = "0x1819FF600")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public T IKGGHGGNMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x19FF4E0", Offset = "0x19FDCE0", VA = "0x1819FF4E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x19FF6B0", Offset = "0x19FDEB0", VA = "0x1819FF6B0")]
	public HJHFKOOCCLH(int MGJIDFDCMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x19FF3A0", Offset = "0x19FDBA0", VA = "0x1819FF3A0")]
	public void GMBMAEFCBMN(T GBMOCKDCEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x19FF220", Offset = "0x19FDA20", VA = "0x1819FF220")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x19FF5A0", Offset = "0x19FDDA0", VA = "0x1819FF5A0")]
	public void JCNFMCALNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x19FF5F0", Offset = "0x19FDDF0", VA = "0x1819FF5F0")]
	public void JOKKONDLOJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class CGAINOMDBFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct HBILIJFMDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int KDKHHFDPIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public T FAIFGLIBFJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<object, HBILIJFMDAC> KJIHFIGMCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T HDFLEELLEPO;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public virtual T IGGALFLIPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xC07A50", Offset = "0xC06250", VA = "0x180C07A50", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x12A9BB0", Offset = "0x12A83B0", VA = "0x1812A9BB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool CFAAHNKBLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2E20D10", Offset = "0x2E1F510", VA = "0x182E20D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public object JPFDIGHNPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4D7840", Offset = "0x4D6040", VA = "0x1804D7840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4D7830", Offset = "0x4D6030", VA = "0x1804D7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x30CFF10", Offset = "0x30CE710", VA = "0x1830CFF10")]
	public bool JJLOLNHLODB(T IJBLIGDNDKF, object CIEFJJALPDK, int FNEPEMJHJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2E20D40", Offset = "0x2E1F540", VA = "0x182E20D40")]
	public bool ENAHMAFKDHN(object CIEFJJALPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2E20DB0", Offset = "0x2E1F5B0", VA = "0x182E20DB0")]
	public bool GGBLFGCAADO(object CIEFJJALPDK, out T IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x12A9C50", Offset = "0x12A8450", VA = "0x1812A9C50")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2E21540", Offset = "0x2E1FD40", VA = "0x182E21540")]
	private bool HLKHOOAOHON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2E24D20", Offset = "0x2E23520", VA = "0x182E24D20")]
	public CGAINOMDBFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OFEHBBONBPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<object, float> KJIHFIGMCKJ;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public float JLONKMBKJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x513590", Offset = "0x511D90", VA = "0x180513590")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xABECB0", Offset = "0xABD4B0", VA = "0x180ABECB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x44AAEE0", Offset = "0x44A96E0", VA = "0x1844AAEE0")]
	public void JJLOLNHLODB(float IJBLIGDNDKF, object CIEFJJALPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x44AAE70", Offset = "0x44A9670", VA = "0x1844AAE70")]
	public void ENAHMAFKDHN(object CIEFJJALPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x44AAF50", Offset = "0x44A9750", VA = "0x1844AAF50")]
	private void JMPBADHDFJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x44AB070", Offset = "0x44A9870", VA = "0x1844AB070")]
	public OFEHBBONBPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public sealed class CHHBOKHJANM
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class KLPOBGOCMAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly string FAECKGOFFHH;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		private KLPOBGOCMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x59DDB0", Offset = "0x59C5B0", VA = "0x18059DDB0")]
		public KLPOBGOCMAL(string FAECKGOFFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x44AA700", Offset = "0x44A8F00", VA = "0x1844AA700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class EIOGHNPFHGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public EIOGHNPFHGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x44A95B0", Offset = "0x44A7DB0", VA = "0x1844A95B0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly HashSet<object> OHEDGALGNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int CFGNMALHFDL;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool ONFBGIGEKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x44A8F40", Offset = "0x44A7740", VA = "0x1844A8F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int AMKHCNPBLFH
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5907C0", Offset = "0x58EFC0", VA = "0x1805907C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x44A8F50", Offset = "0x44A7750", VA = "0x1844A8F50")]
	public bool GMBMAEFCBMN(object CIEFJJALPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x44A9030", Offset = "0x44A7830", VA = "0x1844A9030")]
	public bool MEHJLGGLJCP(object CIEFJJALPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x44A8EE0", Offset = "0x44A76E0", VA = "0x1844A8EE0")]
	public bool DAECMIACEAH(object CIEFJJALPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x44A8FD0", Offset = "0x44A77D0", VA = "0x1844A8FD0")]
	public void IHOILPFOAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x44A90B0", Offset = "0x44A78B0", VA = "0x1844A90B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x44A9200", Offset = "0x44A7A00", VA = "0x1844A9200")]
	public CHHBOKHJANM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EDNJCKFCJOF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private struct HFLOICOMJLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public float DFHLKICNPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public T FAIFGLIBFJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Dictionary<object, HFLOICOMJLC> KJIHFIGMCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private T IPCPAOMGKGK;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T FPFPNHEJNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xF31F40", Offset = "0xF30740", VA = "0x180F31F40", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x12A9BD0", Offset = "0x12A83D0", VA = "0x1812A9BD0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public object BJFNNKODBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD90", Offset = "0x4DA590", VA = "0x1804DBD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD70", Offset = "0x4DA570", VA = "0x1804DBD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool CFAAHNKBLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x12A9B70", Offset = "0x12A8370", VA = "0x1812A9B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x12AC000", Offset = "0x12AA800", VA = "0x1812AC000")]
	public bool JJLOLNHLODB(T IJBLIGDNDKF, object CIEFJJALPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x12A9BF0", Offset = "0x12A83F0", VA = "0x1812A9BF0")]
	public bool ENAHMAFKDHN(object CIEFJJALPDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x12A9C50", Offset = "0x12A8450", VA = "0x1812A9C50")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x12A9DA0", Offset = "0x12A85A0", VA = "0x1812A9DA0")]
	public bool GGBLFGCAADO(object CIEFJJALPDK, out T IJBLIGDNDKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x12AB190", Offset = "0x12A9990", VA = "0x1812AB190")]
	private bool HLKHOOAOHON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x12AC300", Offset = "0x12AAB00", VA = "0x1812AC300")]
	public EDNJCKFCJOF()
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
