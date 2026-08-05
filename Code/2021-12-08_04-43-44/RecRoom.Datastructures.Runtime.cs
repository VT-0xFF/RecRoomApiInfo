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
public class BEEGIBDNDGK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CA0F0", Offset = "0x5C94F0", VA = "0x1805CA0F0")]
	public BEEGIBDNDGK()
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
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E60", Offset = "0x4C0260", VA = "0x1804C0E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4C0450", Offset = "0x4BF850", VA = "0x1804C0450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "4")]
	public virtual void POPPKPDHCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
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
	[BEEGIBDNDGK]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30432A0", Offset = "0x30426A0", VA = "0x1830432A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3042DE0", Offset = "0x30421E0", VA = "0x183042DE0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x30438A0", Offset = "0x3042CA0", VA = "0x1830438A0")]
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
	private sealed class LMDDHOFFBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public LMDDHOFFBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2ECDFD0", Offset = "0x2ECD3D0", VA = "0x182ECDFD0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[BEEGIBDNDGK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9E00", Offset = "0x2EC9200", VA = "0x182EC9E00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9E30", Offset = "0x2EC9230", VA = "0x182EC9E30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9D50", Offset = "0x2EC9150", VA = "0x182EC9D50", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TVal this[TKey NDLDFCGGHEC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9D80", Offset = "0x2EC9180", VA = "0x182EC9D80", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2EC9C60", Offset = "0x2EC9060", VA = "0x182EC9C60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2EC94D0", Offset = "0x2EC88D0", VA = "0x182EC94D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8E40", Offset = "0x2EC8240", VA = "0x182EC8E40", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2EC8AA0", Offset = "0x2EC7EA0", VA = "0x182EC8AA0", Slot = "14")]
	protected virtual string MIJAEKMGBLP(TKeyVal AOGCGGPIDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26EC3F0", Offset = "0x26EB7F0", VA = "0x1826EC3F0", Slot = "4")]
	public bool ContainsKey(TKey NDLDFCGGHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9B60", Offset = "0x2EC8F60", VA = "0x182EC9B60", Slot = "5")]
	public bool TryGetValue(TKey NDLDFCGGHEC, out TVal IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2EC89B0", Offset = "0x2EC7DB0", VA = "0x182EC89B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2EC89B0", Offset = "0x2EC7DB0", VA = "0x182EC89B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9B90", Offset = "0x2EC8F90", VA = "0x182EC9B90")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KEFPFEGKMJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PCJAIOOGOCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public PCJAIOOGOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x212A1C0", Offset = "0x21295C0", VA = "0x18212A1C0")]
		internal bool <GetSamples>b__0(global::HPBHBCOLGDM<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly float GBNGFOCJGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly float BBLOGEEPHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private List<global::HPBHBCOLGDM<float, T>> FNEGNODPILG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JCBJOJEOAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2113B60", Offset = "0x2112F60", VA = "0x182113B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2113F20", Offset = "0x2113320", VA = "0x182113F20")]
	public KEFPFEGKMJN(float NPGAAOOIAMM, float JBGNODIKDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2113DC0", Offset = "0x21131C0", VA = "0x182113DC0")]
	public bool PNCLAIGBDPI(float KBOFFHNBGFL, T IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2113440", Offset = "0x2112840", VA = "0x182113440")]
	public IEnumerable<T> FGCHEMDFHBE(float KBOFFHNBGFL, [Optional] float? MNPKEKNPBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2113410", Offset = "0x2112810", VA = "0x182113410")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2113AA0", Offset = "0x2112EA0", VA = "0x182113AA0")]
	private void LPNELINEODC(float KBOFFHNBGFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class MDFLNFMFEJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct JAGOEMNKDFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public T JLGPLOCBIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float BJJPNCGFJPK;
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static float HDCCPBDNDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private List<T> KMHOLFMJLCL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int EHGINHFOOCM = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private JAGOEMNKDFH[] LLNDHLNGMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int AJFNCCPPOLF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float NEELNKABCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xF998F0", Offset = "0xF98CF0", VA = "0x180F998F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xF99920", Offset = "0xF98D20", VA = "0x180F99920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x20E1C90", Offset = "0x20E1090", VA = "0x1820E1C90")]
	public MDFLNFMFEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x20E1BC0", Offset = "0x20E0FC0", VA = "0x1820E1BC0")]
	public MDFLNFMFEJG(int IANKEMBPHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20E1690", Offset = "0x20E0A90", VA = "0x1820E1690")]
	public void NAIBOGJCHDH(float KBOFFHNBGFL, T IFBOOLFAOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x20E1180", Offset = "0x20E0580", VA = "0x1820E1180")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x20E1760", Offset = "0x20E0B60", VA = "0x1820E1760")]
	public bool PGPPABOCPBK(float EBNOFDOOLAP, float IAFMHCLIHDL, out T IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x20E0ED0", Offset = "0x20E02D0", VA = "0x1820E0ED0")]
	public bool APHMAPKDBAD(float EBNOFDOOLAP, float IAFMHCLIHDL, out T IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x20E1430", Offset = "0x20E0830", VA = "0x1820E1430")]
	public void LPGLKMNCJCB(float EBNOFDOOLAP, float IAFMHCLIHDL, List<T> PAPLNOFONCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x20E1580", Offset = "0x20E0980", VA = "0x1820E1580")]
	private int MAPPFLLCLDB(int IDACDHEJKMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20E1B30", Offset = "0x20E0F30", VA = "0x1820E1B30")]
	private void POADCPMLPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AMDEPAIEINJ();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T EOOGHBAHDLH(T IFBOOLFAOLF, float ADFIFDODBHP);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T AEOICOELDFN(T JFBJOBILJBO, T LICLFNIGMBN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T DOOBAFNGGKJ(T JFBJOBILJBO, T LICLFNIGMBN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HCONBOILBHG : global::MDFLNFMFEJG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x43B3440", Offset = "0x43B2840", VA = "0x1843B3440", Slot = "4")]
	protected override Vector3 AMDEPAIEINJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x43B3520", Offset = "0x43B2920", VA = "0x1843B3520", Slot = "5")]
	protected override Vector3 EOOGHBAHDLH(Vector3 IFBOOLFAOLF, float ADFIFDODBHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x43B3390", Offset = "0x43B2790", VA = "0x1843B3390", Slot = "6")]
	protected override Vector3 AEOICOELDFN(Vector3 JFBJOBILJBO, Vector3 LICLFNIGMBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x43B34B0", Offset = "0x43B28B0", VA = "0x1843B34B0", Slot = "7")]
	protected override Vector3 DOOBAFNGGKJ(Vector3 JFBJOBILJBO, Vector3 LICLFNIGMBN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43B35C0", Offset = "0x43B29C0", VA = "0x1843B35C0")]
	public HCONBOILBHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JGNPEPHCKLK
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1B890E0", Offset = "0x1B884E0", VA = "0x181B890E0")]
	public static global::HPBHBCOLGDM<T1, T2> IDOEMBPAOBJ<T1, T2>(T1 JFCBLPBFBMH, T2 HCFMDKLDEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1B89150", Offset = "0x1B88550", VA = "0x181B89150")]
	public static global::JMNEEPGACON<T1, T2, T3> IDOEMBPAOBJ<T1, T2, T3>(T1 JFCBLPBFBMH, T2 HCFMDKLDEII, T3 OPCNEJFKOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x20971C0", Offset = "0x20965C0", VA = "0x1820971C0")]
	internal static int LHNCKDKKCFE(int HCNLCKPGKPF, int CDMLDEJLEFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3EF4DA0", Offset = "0x3EF41A0", VA = "0x183EF4DA0")]
	internal static int LHNCKDKKCFE(int HCNLCKPGKPF, int CDMLDEJLEFF, int MDAIFMNAMIG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HPBHBCOLGDM<T1, T2> : IComparable<global::HPBHBCOLGDM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T1 CILDLDAEKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T2 FGMDHGFBKAE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1B251C0", Offset = "0x1B245C0", VA = "0x181B251C0")]
	public HPBHBCOLGDM(T1 JFCBLPBFBMH, T2 HCFMDKLDEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2898260", Offset = "0x2897660", VA = "0x182898260", Slot = "4")]
	public int CompareTo(global::HPBHBCOLGDM<T1, T2> PCBLKBHNOAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28987B0", Offset = "0x2897BB0", VA = "0x1828987B0", Slot = "0")]
	public override bool Equals(object PCBLKBHNOAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x28990C0", Offset = "0x28984C0", VA = "0x1828990C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2899830", Offset = "0x2898C30", VA = "0x182899830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JMNEEPGACON<T1, T2, T3> : IComparable<global::JMNEEPGACON<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T1 CILDLDAEKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T2 FGMDHGFBKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T3 ANBJGFINBFH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x26F0830", Offset = "0x26EFC30", VA = "0x1826F0830")]
	public JMNEEPGACON(T1 JFCBLPBFBMH, T2 HCFMDKLDEII, T3 OPCNEJFKOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26F0150", Offset = "0x26EF550", VA = "0x1826F0150", Slot = "4")]
	public int CompareTo(global::JMNEEPGACON<T1, T2, T3> PCBLKBHNOAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x26F0340", Offset = "0x26EF740", VA = "0x1826F0340", Slot = "0")]
	public override bool Equals(object PCBLKBHNOAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x26F0540", Offset = "0x26EF940", VA = "0x1826F0540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x26F06A0", Offset = "0x26EFAA0", VA = "0x1826F06A0", Slot = "3")]
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
	public T JLGPLOCBIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4E7670", Offset = "0x4E6A70", VA = "0x1804E7670")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x59F9E0", Offset = "0x59EDE0", VA = "0x18059F9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float EOIHNCHEMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xD1B3B0", Offset = "0xD1A7B0", VA = "0x180D1B3B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x31913A0", Offset = "0x31907A0", VA = "0x1831913A0")]
	public T LLJFEHKCEOK(float ADFIFDODBHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x31916C0", Offset = "0x3190AC0", VA = "0x1831916C0")]
	public T MNKCFMPMAFE(float ADFIFDODBHP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NALBBEAKKEP(T JFBJOBILJBO, T LICLFNIGMBN, float ADFIFDODBHP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x43B3220", Offset = "0x43B2620", VA = "0x1843B3220", Slot = "4")]
	protected override float NALBBEAKKEP(float JFBJOBILJBO, float LICLFNIGMBN, float ADFIFDODBHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x43B32A0", Offset = "0x43B26A0", VA = "0x1843B32A0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x43B4530", Offset = "0x43B3930", VA = "0x1843B4530", Slot = "4")]
	protected override Vector3 NALBBEAKKEP(Vector3 JFBJOBILJBO, Vector3 LICLFNIGMBN, float ADFIFDODBHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x43B45F0", Offset = "0x43B39F0", VA = "0x1843B45F0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4399100", Offset = "0x4398500", VA = "0x184399100", Slot = "4")]
	protected override Color NALBBEAKKEP(Color JFBJOBILJBO, Color LICLFNIGMBN, float ADFIFDODBHP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x43B31E0", Offset = "0x43B25E0", VA = "0x1843B31E0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class GMGOLDKFAJK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<TKey, TVal> PFPCHHLENEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TVal, TKey> FJOJEMCJLCI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NMPIDIMNOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FA10", Offset = "0x1F3EE10", VA = "0x181F3FA10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool ANENDDMELNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4C0240", VA = "0x1804C0E40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ICollection<TKey> GEOELHJOFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F660", Offset = "0x1F3EA60", VA = "0x181F3F660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICollection<TVal> AKCPPMHCJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1A586C0", Offset = "0x1A57AC0", VA = "0x181A586C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal GNLAMIIIPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x20E0510", Offset = "0x20DF910", VA = "0x1820E0510", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x27673D0", Offset = "0x27667D0", VA = "0x1827673D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2766C90", Offset = "0x2766090", VA = "0x182766C90", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2767260", Offset = "0x2766660", VA = "0x182767260", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2766C00", Offset = "0x2766000", VA = "0x182766C00", Slot = "9")]
	public void Add(TKey NDLDFCGGHEC, TVal IFBOOLFAOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2766C30", Offset = "0x2766030", VA = "0x182766C30", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JDPMEFGIBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2766CF0", Offset = "0x27660F0", VA = "0x182766CF0", Slot = "8")]
	public bool ContainsKey(TKey NDLDFCGGHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1F3D730", Offset = "0x1F3CB30", VA = "0x181F3D730", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JDPMEFGIBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2767200", Offset = "0x2766600", VA = "0x182767200", Slot = "10")]
	public bool Remove(TKey NDLDFCGGHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2767200", Offset = "0x2766600", VA = "0x182767200", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JDPMEFGIBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26EF7E0", Offset = "0x26EEBE0", VA = "0x1826EF7E0", Slot = "11")]
	public bool TryGetValue(TKey NDLDFCGGHEC, out TVal IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2767070", Offset = "0x2766470", VA = "0x182767070", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2766D50", Offset = "0x2766150", VA = "0x182766D50", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LLNDHLNGMDC, int PFJCNMDCIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2766EC0", Offset = "0x27662C0", VA = "0x182766EC0")]
	public bool FDNNMHLHJCI(TVal NDLDFCGGHEC, out TKey IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2766E40", Offset = "0x2766240", VA = "0x182766E40")]
	private void FDDBOMEFGHK(TKey NDLDFCGGHEC, TVal LFCLBPPOOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27670F0", Offset = "0x27664F0", VA = "0x1827670F0")]
	private void HNGFIEOGIOK(TKey NDLDFCGGHEC, TVal LFCLBPPOOKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2766FB0", Offset = "0x27663B0", VA = "0x182766FB0")]
	private bool GFJOIFNKLHN(TKey NDLDFCGGHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2767300", Offset = "0x2766700", VA = "0x182767300")]
	public GMGOLDKFAJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class EAPGKCKNCGG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private global::EAPGKCKNCGG<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0xF998F0", Offset = "0xF98CF0", VA = "0x180F998F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x31B69E0", Offset = "0x31B5DE0", VA = "0x1831B69E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x31B6DA0", Offset = "0x31B61A0", VA = "0x1831B6DA0")]
		public Enumerator(global::EAPGKCKNCGG<T> PAPLNOFONCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x31B64E0", Offset = "0x31B58E0", VA = "0x1831B64E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x31B6840", Offset = "0x31B5C40", VA = "0x1831B6840", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x31B6170", Offset = "0x31B5570", VA = "0x1831B6170")]
		private void JHENDOOBLGC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private T[] EPLLLCMCLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int BKMDLFCCLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private int EOPHHKCLDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int DFOADPEAOBI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NMPIDIMNOND
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x31A6E00", Offset = "0x31A6200", VA = "0x1831A6E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public T GNLAMIIIPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x31A6690", Offset = "0x31A5A90", VA = "0x1831A6690")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x31A7250", Offset = "0x31A6650", VA = "0x1831A7250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x31A78A0", Offset = "0x31A6CA0", VA = "0x1831A78A0")]
	public EAPGKCKNCGG(int GODBNEEDLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x31A7430", Offset = "0x31A6830", VA = "0x1831A7430")]
	public void NAIBOGJCHDH(T ADFIFDODBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x31A6E40", Offset = "0x31A6240", VA = "0x1831A6E40")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x31A6D70", Offset = "0x31A6170", VA = "0x1831A6D70")]
	public void DNIENMGEFGD(int FAJAFOGAIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x31A6980", Offset = "0x31A5D80", VA = "0x1831A6980")]
	public void BBPBLJFAGMF(T[] LLNDHLNGMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x31A67E0", Offset = "0x31A5BE0", VA = "0x1831A67E0")]
	public Enumerator AOPHNLLEPHH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x31A77A0", Offset = "0x31A6BA0", VA = "0x1831A77A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x31A77A0", Offset = "0x31A6BA0", VA = "0x1831A77A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x31A6F80", Offset = "0x31A6380", VA = "0x1831A6F80")]
	private int JBOJHCGNIHB(int PJNLMJGFOGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x31A6E60", Offset = "0x31A6260", VA = "0x1831A6E60")]
	private int EMOLIECJHJC(int PJNLMJGFOGO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class BHEAMELGAKI
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
	protected BHEAMELGAKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public abstract class BALKELMDHNC<T> : BHEAMELGAKI
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	protected struct DLIPCNCLOAN
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum MPLILAGELGG
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
		public MPLILAGELGG ALJDBKKAGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public T LJDENNCKKFN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int LHEOGIKOAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly bool HLEFGBEKMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	protected readonly bool PMCCJKCAAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	protected List<T> CGLGLJBKHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<DLIPCNCLOAN> NMNNIIFAFJP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BNIKAJPCLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x26A1C30", Offset = "0x26A1030", VA = "0x1826A1C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26A1F90", Offset = "0x26A1390", VA = "0x1826A1F90")]
	protected BALKELMDHNC(bool PMCCJKCAAKC, bool HLEFGBEKMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x26A1DA0", Offset = "0x26A11A0", VA = "0x1826A1DA0")]
	protected bool JAAGMKLODBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x26A1B50", Offset = "0x26A0F50", VA = "0x1826A1B50")]
	protected void DOGGPAOHJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x26A19A0", Offset = "0x26A0DA0", VA = "0x1826A19A0")]
	protected void DHDCCALOOIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24FA950", Offset = "0x24F9D50", VA = "0x1824FA950")]
	private static void FGFJCJECKDJ<U>(ref List<U> GALEIDOLHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26A1E40", Offset = "0x26A1240", VA = "0x1826A1E40", Slot = "4")]
	public void NAIBOGJCHDH(T LJDENNCKKFN, bool OJBALPCEANG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26A1860", Offset = "0x26A0C60", VA = "0x1826A1860", Slot = "5")]
	public void AOJGMCBPBFH(T LJDENNCKKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x26A1C70", Offset = "0x26A1070", VA = "0x1826A1C70")]
	public void ELLPAGIADBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class CEOJNOHEPFJ : global::BALKELMDHNC<Action>
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x43B3130", Offset = "0x43B2530", VA = "0x1843B3130")]
	public CEOJNOHEPFJ(bool PMCCJKCAAKC = false, bool HLEFGBEKMDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x43B2EC0", Offset = "0x43B22C0", VA = "0x1843B2EC0")]
	public void IONHCDBIKGJ()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x43B30D0", Offset = "0x43B24D0", VA = "0x1843B30D0")]
	public static CEOJNOHEPFJ ODCMMDKJGFI(CEOJNOHEPFJ ABMJPDOLJPE, Action LJDENNCKKFN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x43B3070", Offset = "0x43B2470", VA = "0x1843B3070")]
	public static CEOJNOHEPFJ JCPMDOKBEGO(CEOJNOHEPFJ ABMJPDOLJPE, Action LJDENNCKKFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KJFBJEDABNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAIBOGJCHDH(Action<T> LJDENNCKKFN, bool OJBALPCEANG = false);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOJGMCBPBFH(Action<T> LJDENNCKKFN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public sealed class GJOMOAJDLFH<T> : global::BALKELMDHNC<Action<T>>, global::KJFBJEDABNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1A54940", Offset = "0x1A53D40", VA = "0x181A54940")]
	public GJOMOAJDLFH(bool PMCCJKCAAKC = false, bool HLEFGBEKMDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2D85B90", Offset = "0x2D84F90", VA = "0x182D85B90")]
	public void IONHCDBIKGJ(T ADFIFDODBHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1A548A0", Offset = "0x1A53CA0", VA = "0x181A548A0")]
	public static global::GJOMOAJDLFH<T> ODCMMDKJGFI(global::GJOMOAJDLFH<T> ABMJPDOLJPE, Action<T> LJDENNCKKFN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1A54800", Offset = "0x1A53C00", VA = "0x181A54800")]
	public static global::GJOMOAJDLFH<T> JCPMDOKBEGO(global::GJOMOAJDLFH<T> ABMJPDOLJPE, Action<T> LJDENNCKKFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface FNNAIKHJCAJ<T, U>
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class LOLOBJNINLN<T, U> : global::BALKELMDHNC<Action<T, U>>, global::FNNAIKHJCAJ<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1A54940", Offset = "0x1A53D40", VA = "0x181A54940")]
	public LOLOBJNINLN(bool PMCCJKCAAKC = false, bool HLEFGBEKMDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x20DBB40", Offset = "0x20DAF40", VA = "0x1820DBB40")]
	public void IONHCDBIKGJ(T ADFIFDODBHP, U IKGICEPHKIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1A548A0", Offset = "0x1A53CA0", VA = "0x181A548A0")]
	public static global::LOLOBJNINLN<T, U> ODCMMDKJGFI(global::LOLOBJNINLN<T, U> ABMJPDOLJPE, Action<T, U> LJDENNCKKFN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1A54800", Offset = "0x1A53C00", VA = "0x181A54800")]
	public static global::LOLOBJNINLN<T, U> JCPMDOKBEGO(global::LOLOBJNINLN<T, U> ABMJPDOLJPE, Action<T, U> LJDENNCKKFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class BDKNPDCHPPE<T, U, V> : global::BALKELMDHNC<Action<T, U, V>>
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1A54940", Offset = "0x1A53D40", VA = "0x181A54940")]
	public BDKNPDCHPPE(bool PMCCJKCAAKC = false, bool HLEFGBEKMDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26A7D40", Offset = "0x26A7140", VA = "0x1826A7D40")]
	public void IONHCDBIKGJ(T ADFIFDODBHP, U IKGICEPHKIL, V AKOPNFJKHIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1A548A0", Offset = "0x1A53CA0", VA = "0x181A548A0")]
	public static global::BDKNPDCHPPE<T, U, V> ODCMMDKJGFI(global::BDKNPDCHPPE<T, U, V> ABMJPDOLJPE, Action<T, U, V> LJDENNCKKFN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1A54800", Offset = "0x1A53C00", VA = "0x181A54800")]
	public static global::BDKNPDCHPPE<T, U, V> JCPMDOKBEGO(global::BDKNPDCHPPE<T, U, V> ABMJPDOLJPE, Action<T, U, V> LJDENNCKKFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NNHKPJCKNEI<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class OHABEDFMHLE<T, U, V, W> : global::BALKELMDHNC<Action<T, U, V, W>>, global::NNHKPJCKNEI<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1A54940", Offset = "0x1A53D40", VA = "0x181A54940")]
	public OHABEDFMHLE(bool PMCCJKCAAKC = false, bool HLEFGBEKMDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1A54550", Offset = "0x1A53950", VA = "0x181A54550")]
	public void IONHCDBIKGJ(T ADFIFDODBHP, U IKGICEPHKIL, V AKOPNFJKHIL, W MLPJAIJOOMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1A548A0", Offset = "0x1A53CA0", VA = "0x181A548A0")]
	public static global::OHABEDFMHLE<T, U, V, W> ODCMMDKJGFI(global::OHABEDFMHLE<T, U, V, W> ABMJPDOLJPE, Action<T, U, V, W> LJDENNCKKFN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1A54800", Offset = "0x1A53C00", VA = "0x181A54800")]
	public static global::OHABEDFMHLE<T, U, V, W> JCPMDOKBEGO(global::OHABEDFMHLE<T, U, V, W> ABMJPDOLJPE, Action<T, U, V, W> LJDENNCKKFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KIOAJEJGKMP<T, U, V, W, X> : global::BALKELMDHNC<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1A54940", Offset = "0x1A53D40", VA = "0x181A54940")]
	public KIOAJEJGKMP(bool PMCCJKCAAKC = false, bool HLEFGBEKMDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x211F7F0", Offset = "0x211EBF0", VA = "0x18211F7F0")]
	public void IONHCDBIKGJ(T ADFIFDODBHP, U IKGICEPHKIL, V AKOPNFJKHIL, W MLPJAIJOOMF, X JHHMBPGDMDJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1A548A0", Offset = "0x1A53CA0", VA = "0x181A548A0")]
	public static global::KIOAJEJGKMP<T, U, V, W, X> ODCMMDKJGFI(global::KIOAJEJGKMP<T, U, V, W, X> ABMJPDOLJPE, Action<T, U, V, W, X> LJDENNCKKFN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1A54800", Offset = "0x1A53C00", VA = "0x181A54800")]
	public static global::KIOAJEJGKMP<T, U, V, W, X> JCPMDOKBEGO(global::KIOAJEJGKMP<T, U, V, W, X> ABMJPDOLJPE, Action<T, U, V, W, X> LJDENNCKKFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NNDFLBKJNGK<T, U, V, W, X, Y> : global::BALKELMDHNC<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1A54940", Offset = "0x1A53D40", VA = "0x181A54940")]
	public NNDFLBKJNGK(bool PMCCJKCAAKC = false, bool HLEFGBEKMDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x36FFBE0", Offset = "0x36FEFE0", VA = "0x1836FFBE0")]
	public void IONHCDBIKGJ(T ADFIFDODBHP, U IKGICEPHKIL, V AKOPNFJKHIL, W MLPJAIJOOMF, X JHHMBPGDMDJ, Y FODPAODADFP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1A548A0", Offset = "0x1A53CA0", VA = "0x181A548A0")]
	public static global::NNDFLBKJNGK<T, U, V, W, X, Y> ODCMMDKJGFI(global::NNDFLBKJNGK<T, U, V, W, X, Y> ABMJPDOLJPE, Action<T, U, V, W, X, Y> LJDENNCKKFN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1A54800", Offset = "0x1A53C00", VA = "0x181A54800")]
	public static global::NNDFLBKJNGK<T, U, V, W, X, Y> JCPMDOKBEGO(global::NNDFLBKJNGK<T, U, V, W, X, Y> ABMJPDOLJPE, Action<T, U, V, W, X, Y> LJDENNCKKFN)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct GECNACIEMDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class IJMOEHCJMHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct CNDMMBLFMFE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly global::IJMOEHCJMHL<T> LFJNKLFGCPJ;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public T JLGPLOCBIGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x21F8E90", Offset = "0x21F8290", VA = "0x1821F8E90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x21F8E60", Offset = "0x21F8260", VA = "0x1821F8E60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A83E0", Offset = "0x5A77E0", VA = "0x1805A83E0")]
		public CNDMMBLFMFE(global::IJMOEHCJMHL<T> LFJNKLFGCPJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly SemaphoreSlim LFJGIAFELME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private T IPLIFECOJHD;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x21FC630", Offset = "0x21FBA30", VA = "0x1821FC630")]
	public IJMOEHCJMHL(in T IPLIFECOJHD, int BHPKONJGIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x21FC6C0", Offset = "0x21FBAC0", VA = "0x1821FC6C0")]
	public IJMOEHCJMHL(in T IPLIFECOJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x21FC600", Offset = "0x21FBA00", VA = "0x1821FC600")]
	public CNDMMBLFMFE EELHPKABDPI()
	{
		return default(CNDMMBLFMFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class OHFGMMJCBJA
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x43B4090", Offset = "0x43B3490", VA = "0x1843B4090")]
	public static global::IJMOEHCJMHL<GECNACIEMDO> KNCNOHANDGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1B7FC00", Offset = "0x1B7F000", VA = "0x181B7FC00")]
	public static global::IJMOEHCJMHL<T> KNCNOHANDGD<T>(in T IPLIFECOJHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BLBPLCEBNDA<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate bool CFNMNNBLAIA(global::BLBPLCEBNDA<T> KCECPCBFIOD);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class FONDCJCOHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public global::BLBPLCEBNDA<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public FONDCJCOHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x30BB160", Offset = "0x30BA560", VA = "0x1830BB160")]
		internal bool <FindNode>b__0(global::BLBPLCEBNDA<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public T EMEIPMNKEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LinkedList<global::BLBPLCEBNDA<T>> DCIHDIGPLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public global::BLBPLCEBNDA<T> IOJEMGMHMDH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public global::BLBPLCEBNDA<T> OKNEJABEION
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x510A20", Offset = "0x50FE20", VA = "0x180510A20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x30B59E0", Offset = "0x30B4DE0", VA = "0x1830B59E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool KJAGCLJDNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x30B4790", Offset = "0x30B3B90", VA = "0x1830B4790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool IBGHFOIDFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x30B6340", Offset = "0x30B5740", VA = "0x1830B6340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public global::BLBPLCEBNDA<T> DOCHKEFAALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x30B47C0", Offset = "0x30B3BC0", VA = "0x1830B47C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x30B6830", Offset = "0x30B5C30", VA = "0x1830B6830")]
	public BLBPLCEBNDA(T AEKFBBICPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x30B4DD0", Offset = "0x30B41D0", VA = "0x1830B4DD0")]
	public global::BLBPLCEBNDA<T> ENMENOHKOKM(T OBKKJKFODLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x30B4480", Offset = "0x30B3880", VA = "0x1830B4480")]
	public global::BLBPLCEBNDA<T> ALDFAHDMKPG(T ODELLOPBECL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x30B4650", Offset = "0x30B3A50", VA = "0x1830B4650")]
	public global::BLBPLCEBNDA<T> AOJGMCBPBFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x30B4A90", Offset = "0x30B3E90", VA = "0x1830B4A90")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x30B5AA0", Offset = "0x30B4EA0", VA = "0x1830B5AA0")]
	public global::BLBPLCEBNDA<T> HLBCHFJAKDJ(T AFKIDOLOLJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x30B5C80", Offset = "0x30B5080", VA = "0x1830B5C80")]
	public static void JNCLDKDACKA(global::BLBPLCEBNDA<T> ENNHJGEOMCH, CFNMNNBLAIA FOJAHBELFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x24FAD90", Offset = "0x24FA190", VA = "0x1824FAD90")]
	public static void JNCLDKDACKA<A>(global::BLBPLCEBNDA<T> ENNHJGEOMCH, Func<global::BLBPLCEBNDA<T>, A, bool> FOJAHBELFKN, A BENPCCIAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x30B5410", Offset = "0x30B4810", VA = "0x1830B5410")]
	public static string FDLPPILHJAP(global::BLBPLCEBNDA<T> ENNHJGEOMCH, int HFJFEJHPHGF = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x30B6580", Offset = "0x30B5980", VA = "0x1830B6580")]
	public static global::BLBPLCEBNDA<T> NCHPPEKEAJL(global::BLBPLCEBNDA<T> ENNHJGEOMCH, T IFAKMNJHOFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class EDMDEFHMPFA<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate int NJIJNHPLKPB(TKey NDLDFCGGHEC, TVal IFBOOLFAOLF);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class EHPODLCDJOE
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public TKey BIOOMABDFDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public TVal JLGPLOCBIGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x63CB90", Offset = "0x63BF90", VA = "0x18063CB90")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x679770", Offset = "0x678B70", VA = "0x180679770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int GPCJFDNIKDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5B9380", Offset = "0x5B8780", VA = "0x1805B9380")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5B93B0", Offset = "0x5B87B0", VA = "0x1805B93B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public DateTime JHMHLIPHOCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4C2CF0", Offset = "0x4C20F0", VA = "0x1804C2CF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4E97D0", Offset = "0x4E8BD0", VA = "0x1804E97D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x31AE750", Offset = "0x31ADB50", VA = "0x1831AE750")]
		public EHPODLCDJOE(TKey NDLDFCGGHEC, TVal LFCLBPPOOKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const int JAKEDHGNAOP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly Dictionary<TKey, LinkedListNode<EHPODLCDJOE>> KLHFEKDLFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly LinkedList<EHPODLCDJOE> DKDBOFDKDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NJIJNHPLKPB AKIMBBBKGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly TimeSpan GKAAJCEGLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IGMEPAGLILA LJFHECLPBBM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int FMCCBBBNOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C2490", Offset = "0x5C1890", VA = "0x1805C2490")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool MAMOIHGEHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x31A9B40", Offset = "0x31A8F40", VA = "0x1831A9B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal int MIBCCBDIIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C24A0", Offset = "0x5C18A0", VA = "0x1805C24A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B7500", Offset = "0x5B6900", VA = "0x1805B7500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TKey GNLAMIIIPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x31A9700", Offset = "0x31A8B00", VA = "0x1831A9700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x31A9DF0", Offset = "0x31A91F0", VA = "0x1831A9DF0")]
	public EDMDEFHMPFA(int GODBNEEDLBO, [Optional] NJIJNHPLKPB AKIMBBBKGPH, [Optional] IEqualityComparer<TKey> MIHFENEAAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x31A9BD0", Offset = "0x31A8FD0", VA = "0x1831A9BD0")]
	public EDMDEFHMPFA(int GODBNEEDLBO, NJIJNHPLKPB AKIMBBBKGPH, TimeSpan GKAAJCEGLNI, [Optional] IEqualityComparer<TKey> MIHFENEAAPO, [Optional] IGMEPAGLILA LJFHECLPBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x31A95A0", Offset = "0x31A89A0", VA = "0x1831A95A0")]
	public void LFHDBMFBIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x31A8FE0", Offset = "0x31A83E0", VA = "0x1831A8FE0")]
	public void GPPJNFLHPNC(TKey NDLDFCGGHEC, TVal IFBOOLFAOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x31A85C0", Offset = "0x31A79C0", VA = "0x1831A85C0")]
	public bool AOJGMCBPBFH(TKey NDLDFCGGHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x31A8C80", Offset = "0x31A8080", VA = "0x1831A8C80")]
	public bool FDNNMHLHJCI(TKey BPHKDFOLAEM, out TVal IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x31A8C00", Offset = "0x31A8000", VA = "0x1831A8C00")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x31A8B40", Offset = "0x31A7F40", VA = "0x1831A8B40")]
	private bool DBGEGIKHLLM(EHPODLCDJOE IFKDNNOGGKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x31A90A0", Offset = "0x31A84A0", VA = "0x1831A90A0")]
	private void KADNHGPOPKO(LinkedListNode<EHPODLCDJOE> KFHJALIGBMN, TVal DGCMBAFCDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x31A9730", Offset = "0x31A8B30", VA = "0x1831A9730")]
	private void PLJELGDMNFG(TKey NDLDFCGGHEC, TVal IFBOOLFAOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x31A88E0", Offset = "0x31A7CE0", VA = "0x1831A88E0")]
	private void BFHPIPOHHPN(EHPODLCDJOE IFKDNNOGGKK, TVal DGCMBAFCDKD, int HEJJNNLMANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DefaultMember("Item")]
public class BDKAKBOPGBA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly List<T> GALEIDOLHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private HashSet<T> JNCNJDCPAMF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int NMPIDIMNOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FA10", Offset = "0x1F3EE10", VA = "0x181F3FA10", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool ANENDDMELNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4C0240", VA = "0x1804C0E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T GNLAMIIIPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x26A6820", Offset = "0x26A5C20", VA = "0x1826A6820", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x26A6850", Offset = "0x26A5C50", VA = "0x1826A6850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F38370", Offset = "0x1F37770", VA = "0x181F38370", Slot = "11")]
	public void Add(T JDPMEFGIBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x26A6350", Offset = "0x26A5750", VA = "0x1826A6350")]
	public bool LODBEEEEFMI(T JDPMEFGIBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x26A66D0", Offset = "0x26A5AD0", VA = "0x1826A66D0", Slot = "15")]
	public bool Remove(T JDPMEFGIBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x26A6140", Offset = "0x26A5540", VA = "0x1826A6140", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1B23AC0", Offset = "0x1B22EC0", VA = "0x181B23AC0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x26A6080", Offset = "0x26A5480", VA = "0x1826A6080", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x26A60E0", Offset = "0x26A54E0", VA = "0x1826A60E0", Slot = "13")]
	public bool Contains(T JDPMEFGIBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x26A6110", Offset = "0x26A5510", VA = "0x1826A6110", Slot = "14")]
	public void CopyTo(T[] LLNDHLNGMDC, int PFJCNMDCIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x20E0510", Offset = "0x20DF910", VA = "0x1820E0510", Slot = "6")]
	public int IndexOf(T JDPMEFGIBKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x26A61C0", Offset = "0x26A55C0", VA = "0x1826A61C0", Slot = "7")]
	public void Insert(int PJNLMJGFOGO, T JDPMEFGIBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x26A6570", Offset = "0x26A5970", VA = "0x1826A6570", Slot = "8")]
	public void RemoveAt(int PJNLMJGFOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x26A6750", Offset = "0x26A5B50", VA = "0x1826A6750")]
	public BDKAKBOPGBA()
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
			[Cpp2IlInjected.Address(RVA = "0x1CE45C0", Offset = "0x1CE39C0", VA = "0x181CE45C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x43B4500", Offset = "0x43B3900", VA = "0x1843B4500")]
		public SerializedGuid(in Guid MMHILEPEJAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x43B4120", Offset = "0x43B3520", VA = "0x1843B4120")]
		public static SerializedGuid DBKPKANJPNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x43B4330", Offset = "0x43B3730", VA = "0x1843B4330")]
		public static SerializedGuid MLODKMHJBPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x43B43B0", Offset = "0x43B37B0", VA = "0x1843B43B0")]
		public bool NMNNKDECLNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x43B44E0", Offset = "0x43B38E0", VA = "0x1843B44E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x43B4440", Offset = "0x43B3840", VA = "0x1843B4440", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x43B41A0", Offset = "0x43B35A0", VA = "0x1843B41A0", Slot = "7")]
		public bool Equals(SerializedGuid PCBLKBHNOAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x43B4240", Offset = "0x43B3640", VA = "0x1843B4240", Slot = "0")]
		public override bool Equals(object IIGCLEONCAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x43B4320", Offset = "0x43B3720", VA = "0x1843B4320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x43B40F0", Offset = "0x43B34F0", VA = "0x1843B40F0", Slot = "6")]
		public int CompareTo(SerializedGuid PCBLKBHNOAC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class MPILJFIPLNC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly Type NIJFPBGFDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string IDCBDBMGPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly bool CFCOCOAPEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly bool IHHKIOOONLN;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x43B3DC0", Offset = "0x43B31C0", VA = "0x1843B3DC0")]
	public MPILJFIPLNC(Type PCJMCLCMBKH, string DEPGHNIHOOI, bool OMAMFGCGNBK = false, bool LPGFKLCDCCG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface AFDDAGJGOJK<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	T JLGPLOCBIGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool KEAOEHBNGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AFDDAGJGOJK<T> AJMNKJGAPAM(Action<T> AHIBIJBEKDI);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::AFDDAGJGOJK<T> JJLEGPJIGPP(Action<T> AHIBIJBEKDI);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class EHJGMMIKIHH<T> : global::AFDDAGJGOJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private global::LOLOBJNINLN<T, T> PLAAEPNDBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private global::GJOMOAJDLFH<T> MFDPPCKMDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private global::GJOMOAJDLFH<string> KDMEFMLCIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string EOFGEJBPEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private T HPFDPCFKNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool EFIHHCMEKLJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T JLGPLOCBIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4E7670", Offset = "0x4E6A70", VA = "0x1804E7670", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x26EA030", Offset = "0x26E9430", VA = "0x1826EA030", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KEAOEHBNGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x562D60", Offset = "0x562160", VA = "0x180562D60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x31AE5C0", Offset = "0x31AD9C0", VA = "0x1831AE5C0")]
	private void LJJDCFHNDCJ(T FJOCKKJAKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x31AE510", Offset = "0x31AD910", VA = "0x1831AE510", Slot = "4")]
	public global::AFDDAGJGOJK<T> AJMNKJGAPAM(Action<T> CAEKCDLPKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x31AE590", Offset = "0x31AD990", VA = "0x1831AE590", Slot = "5")]
	public global::AFDDAGJGOJK<T> JJLEGPJIGPP(Action<T> AHIBIJBEKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x31AE640", Offset = "0x31ADA40", VA = "0x1831AE640")]
	public EHJGMMIKIHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class BJBLJGKJJKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class KENAEEGIPKF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public global::AFDDAGJGOJK<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public global::BNCFDPPLNOJ<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public KENAEEGIPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x30BB1D0", Offset = "0x30BA5D0", VA = "0x1830BB1D0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x22BDBA0", Offset = "0x22BCFA0", VA = "0x1822BDBA0")]
	public static global::PMGAAIBIJNM<T> FHBDEAHPHAE<T>(this global::AFDDAGJGOJK<T> HPLMFNODPBD, Action<T> KENEHOJCGJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class IGMEPAGLILA
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class HHGKPJBJJFO : IGMEPAGLILA
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static IGMEPAGLILA IOCJCLEDPBG
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x43B3670", Offset = "0x43B2A70", VA = "0x1843B3670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override DateTime AAEJMPACEPG
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x43B3620", Offset = "0x43B2A20", VA = "0x1843B3620", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x43B3760", Offset = "0x43B2B60", VA = "0x1843B3760")]
		public HHGKPJBJJFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static IGMEPAGLILA CDBHMCKMHDP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static IGMEPAGLILA LELEJNBKBCK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x43B37C0", Offset = "0x43B2BC0", VA = "0x1843B37C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract DateTime AAEJMPACEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
	protected IGMEPAGLILA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class LJDDJDAEPFC : global::NBAMENJAGFD<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x43B3930", Offset = "0x43B2D30", VA = "0x1843B3930")]
	public LJDDJDAEPFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class NBAMENJAGFD<T> : global::KAEDDLOPLDP<T>, FFNFAHAKEFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task<T> MJADEDLDPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public global::PMGAAIBIJNM<T> JAABFMHLIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private IDJKGJMBBAG JHHMNEEKCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1612F70", Offset = "0x1612370", VA = "0x181612F70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x26DE5C0", Offset = "0x26DD9C0", VA = "0x1826DE5C0")]
	public NBAMENJAGFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GMPLENLOKOD<T> : global::KAEDDLOPLDP<T>, FFNFAHAKEFB, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Task<T> MJADEDLDPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public global::PMGAAIBIJNM<T> JAABFMHLIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private IDJKGJMBBAG JHHMNEEKCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1612F70", Offset = "0x1612370", VA = "0x181612F70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2767400", Offset = "0x2766800", VA = "0x182767400")]
	public GMPLENLOKOD(Exception LKGDCBMCJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FFNFAHAKEFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	[NotNull]
	IDJKGJMBBAG JAABFMHLIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface KAEDDLOPLDP<T> : FFNFAHAKEFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> MJADEDLDPHD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	new global::PMGAAIBIJNM<T> JAABFMHLIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public abstract class LPAGFDHNHGJ<TTask, T> : global::KAEDDLOPLDP<T>, FFNFAHAKEFB, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class GNLANDEEOCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public global::LPAGFDHNHGJ<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TTask task;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public GNLANDEEOCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class PIIOGNLENHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public GNLANDEEOCN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		public PIIOGNLENHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x20E9220", Offset = "0x20E8620", VA = "0x1820E9220")]
		internal T <.ctor>b__0(Task t)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static bool OGINBAOOHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly global::BNCFDPPLNOJ<T> MPCJDKIJGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Task<T> ECNAMABPIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly CancellationTokenSource IIHBGNHEKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool MLHANBCAPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private SynchronizationContext GIJMOPCDBLO;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task<T> MJADEDLDPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::PMGAAIBIJNM<T> JAABFMHLIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private IDJKGJMBBAG JHHMNEEKCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool FFBFPKJJNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x561E90", Offset = "0x561290", VA = "0x180561E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x20DE7D0", Offset = "0x20DDBD0", VA = "0x1820DE7D0")]
	static LPAGFDHNHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x20DEAB0", Offset = "0x20DDEB0", VA = "0x1820DEAB0")]
	protected LPAGFDHNHGJ(TTask ECNAMABPIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x20DE290", Offset = "0x20DD690", VA = "0x1820DE290", Slot = "1")]
	~LPAGFDHNHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x20DE0B0", Offset = "0x20DD4B0", VA = "0x1820DE0B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x20DE330", Offset = "0x20DD730", VA = "0x1820DE330")]
	private void GANOHKODJBF(bool NECLGGMBOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T IMBGBPGPKMA(TTask LOAIGKDCAED);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract void BPOCJGOHFDJ();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x20DE160", Offset = "0x20DD560", VA = "0x1820DE160")]
	protected void FGGHGNKKKFO(T FJOCKKJAKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x20DE750", Offset = "0x20DDB50", VA = "0x1820DE750")]
	protected void PGIIDNPJFMP(string EOFGEJBPEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x20DE6B0", Offset = "0x20DDAB0", VA = "0x1820DE6B0")]
	[CompilerGenerated]
	private void GHKFGNDJGOL(object PFANFLJEBMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class FKCFNGFMDDE<T> : IEnumerable<global::FKCFNGFMDDE<T>.IIMBDFFGHID>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct IIMBDFFGHID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public T IFBOOLFAOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public int PJNLMJGFOGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class KMENPKFMIGA : IEnumerator<IIMBDFFGHID>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private global::FKCFNGFMDDE<T> BKINHJABMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int PJNLMJGFOGO;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x23CC120", Offset = "0x23CB520", VA = "0x1823CC120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public IIMBDFFGHID EBJFFHPEJEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3543CF0", Offset = "0x35430F0", VA = "0x183543CF0", Slot = "4")]
			get
			{
				return default(IIMBDFFGHID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x758190", Offset = "0x757590", VA = "0x180758190")]
		public KMENPKFMIGA(global::FKCFNGFMDDE<T> BKINHJABMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3543C60", Offset = "0x3543060", VA = "0x183543C60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x60FE80", Offset = "0x60F280", VA = "0x18060FE80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7244D0", Offset = "0x7238D0", VA = "0x1807244D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct KCKPHNELHEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool KJMBNGDHOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public T IFBOOLFAOLF;
	}

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private const int EMLKJFOOFLO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<T, int> FGMEGLKJBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private KCKPHNELHEA[] NDCDMFNLAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int HBEALCDCOAO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int NMPIDIMNOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1F3F660", Offset = "0x1F3EA60", VA = "0x181F3F660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x35385B0", Offset = "0x35379B0", VA = "0x1835385B0")]
	public static global::FKCFNGFMDDE<T> JGOFOCKPNIN(IIMBDFFGHID[] DCNFNEEGFIO, bool JEFMILJKDIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3538D10", Offset = "0x3538110", VA = "0x183538D10")]
	public FKCFNGFMDDE(int GODBNEEDLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x35384A0", Offset = "0x35378A0", VA = "0x1835384A0")]
	public int CMHLKAJEFDO(T IFBOOLFAOLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x35384F0", Offset = "0x35378F0", VA = "0x1835384F0")]
	public T FHBDEAHPHAE(int PJNLMJGFOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3538970", Offset = "0x3537D70", VA = "0x183538970")]
	public bool LODBEEEEFMI(T IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3538990", Offset = "0x3537D90", VA = "0x183538990")]
	public bool LODBEEEEFMI(T IFBOOLFAOLF, int PJNLMJGFOGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3538B60", Offset = "0x3537F60", VA = "0x183538B60")]
	public IIMBDFFGHID[] OOOOPCHCLOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3538560", Offset = "0x3537960", VA = "0x183538560")]
	private int GHEELFIPPCI(int BKMDLFCCLBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3538CA0", Offset = "0x35380A0", VA = "0x183538CA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3538CA0", Offset = "0x35380A0", VA = "0x183538CA0", Slot = "4")]
	private IEnumerator<IIMBDFFGHID> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class LLLNBKADBEH<T> where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private List<T> PCHFCJIHGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private List<T> JAKLIOJKPNI;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2B29CB0", Offset = "0x2B290B0", VA = "0x182B29CB0")]
	public LLLNBKADBEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2B29CE0", Offset = "0x2B290E0", VA = "0x182B29CE0")]
	public LLLNBKADBEH(int GODBNEEDLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2B29BB0", Offset = "0x2B28FB0", VA = "0x182B29BB0")]
	public T MLLMIPALIMM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2B29A90", Offset = "0x2B28E90", VA = "0x182B29A90")]
	public void BPFCLJEKENM(T OGJECJLLNMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class JNAEPLEJADG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Dictionary<int, T> KEPDCHMPGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private T JNCKIOGCBNH;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual T JKBCNPOKOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4C0450", Offset = "0x4BF850", VA = "0x1804C0450", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x26F0FE0", Offset = "0x26F03E0", VA = "0x1826F0FE0")]
	public bool PLJELGDMNFG(T IFBOOLFAOLF, int MNEOJGLJNOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x26F0EF0", Offset = "0x26F02F0", VA = "0x1826F0EF0")]
	public bool FCBNLDKADOO(int MNEOJGLJNOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x26F0880", Offset = "0x26EFC80", VA = "0x1826F0880")]
	public T ALMKIBILBAN(int PIHCFGABLME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x26F0E60", Offset = "0x26F0260", VA = "0x1826F0E60")]
	private bool DDHBFJPIJGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x26F0F50", Offset = "0x26F0350", VA = "0x1826F0F50")]
	public bool FDNNMHLHJCI(int MNEOJGLJNOG, out T IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x26F1040", Offset = "0x26F0440", VA = "0x1826F1040")]
	public JNAEPLEJADG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class NINOPLCNPAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	protected struct NGAIIPMPDEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public T JLGPLOCBIGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int PHLCAOECDPJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	protected readonly List<NGAIIPMPDEE> EPLLLCMCLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private T HCHBBNPHPIK;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int NMPIDIMNOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x1F3FA10", Offset = "0x1F3EE10", VA = "0x181F3FA10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x26E6EC0", Offset = "0x26E62C0", VA = "0x1826E6EC0")]
	public bool PDGNNJCKANN(T IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x26E6E40", Offset = "0x26E6240", VA = "0x1826E6E40")]
	public void NAIBOGJCHDH(T IFBOOLFAOLF, int MNEOJGLJNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x26E6A20", Offset = "0x26E5E20", VA = "0x1826E6A20")]
	public bool AOJGMCBPBFH(T IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x26E6B40", Offset = "0x26E5F40", VA = "0x1826E6B40")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x26E6BA0", Offset = "0x26E5FA0", VA = "0x1826E6BA0")]
	public T HPEPAJEDAHC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x26E6C30", Offset = "0x26E6030", VA = "0x1826E6C30")]
	private void LCNEOJAFBIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x26E7110", Offset = "0x26E6510", VA = "0x1826E7110")]
	public NINOPLCNPAI()
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
		[Cpp2IlInjected.Address(RVA = "0x24B3270", Offset = "0x24B2670", VA = "0x1824B3270", Slot = "4")]
		public virtual T IEENLHLKLFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x1612F10", Offset = "0x1612310", VA = "0x181612F10")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class AFHOEBGBDPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly Dictionary<byte, ANJKLDIGAGG> BLJMAPDFENP;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public ANJKLDIGAGG AGHALOOMMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4C01A0", Offset = "0x4BF5A0", VA = "0x1804C01A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4C0440", Offset = "0x4BF840", VA = "0x1804C0440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Vector2 OPIGPEKEPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xDF9350", Offset = "0xDF8750", VA = "0x180DF9350")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2895730", Offset = "0x2894B30", VA = "0x182895730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Vector2 FCJGKDLOFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x11920F0", Offset = "0x11914F0", VA = "0x1811920F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Vector2 DIBJCOKAOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x31A1840", Offset = "0x31A0C40", VA = "0x1831A1840")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x31A1860", Offset = "0x31A0C60", VA = "0x1831A1860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int JEPIMLCJCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1B0", Offset = "0x4E95B0", VA = "0x1804EA1B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x50F360", Offset = "0x50E760", VA = "0x18050F360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x43B25C0", Offset = "0x43B19C0", VA = "0x1843B25C0")]
	public AFHOEBGBDPE(Bounds HEEIIKJBMIK, Vector2[] BONGCILFPGI, int PGHPILGMJAP, byte BKMDLFCCLBN, float EGAHFGLFPMO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x43B2560", Offset = "0x43B1960", VA = "0x1843B2560")]
	public ANJKLDIGAGG NAAOEIHNOAI(byte PJNLMJGFOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x43B1E20", Offset = "0x43B1220", VA = "0x1843B1E20")]
	public void HGJMGKKCEKH(Vector3 HBNPNDHEJKG, float ILOPNBGNKPO, float CGIAOKJEBMO, ref List<byte> HJCIDJGHFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x43B1F00", Offset = "0x43B1300", VA = "0x1843B1F00")]
	public void KBIFEAFOCOD(ANJKLDIGAGG.AIDKMKLBKLO GBGFPHDNFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x43B1F20", Offset = "0x43B1320", VA = "0x1843B1F20")]
	private ANJKLDIGAGG LMAMGMADOFO(byte PJNLMJGFOGO, ANJKLDIGAGG.GDGKAKDCAKG BCJNCPNFPKN, ANJKLDIGAGG CFLNPJDNDAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x43B2040", Offset = "0x43B1440", VA = "0x1843B2040")]
	private void MAAGPMFGMHL(ANJKLDIGAGG CFLNPJDNDAE, Vector2[] BONGCILFPGI, int DNHELLGJHMK, int KBACJKCCNCJ, int ELKOAHAMDFG, int HBDEKHLNFBO, float EGAHFGLFPMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class ANJKLDIGAGG
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public enum GDGKAKDCAKG
	{
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum AIDKMKLBKLO
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
	public byte FFKMNDKOFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Vector3 CAOOOAHPKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Vector3 GPCJFDNIKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Vector3 JPKELPGILJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Vector3 KAOLPOIIMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GDGKAKDCAKG ACJANOCNPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ANJKLDIGAGG OKNEJABEION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public List<ANJKLDIGAGG> ODAJHAGKNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public bool LIJFHGFJDFB;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x43B2E70", Offset = "0x43B2270", VA = "0x1843B2E70")]
	public ANJKLDIGAGG(byte KHLGBIBIKCB, GDGKAKDCAKG BCJNCPNFPKN, ANJKLDIGAGG CFLNPJDNDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x43B2B10", Offset = "0x43B1F10", VA = "0x1843B2B10")]
	public void ENMENOHKOKM(ANJKLDIGAGG CKJJKPAANNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00")]
	public void KBIFEAFOCOD(int IEMMPDJLCPP, AIDKMKLBKLO GBGFPHDNFLE, int ECKMALJDIPM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x43B2BA0", Offset = "0x43B1FA0", VA = "0x1843B2BA0")]
	public void HGJMGKKCEKH(List<byte> HJCIDJGHFOK, Vector3 HBNPNDHEJKG, float ILOPNBGNKPO, float CGIAOKJEBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x43B2AB0", Offset = "0x43B1EB0", VA = "0x1843B2AB0")]
	public bool ALLHLJCMJGE(Vector3 NKOCALOKDFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x43B2E30", Offset = "0x43B2230", VA = "0x1843B2E30")]
	public bool JPGOGDFJNNL(Vector3 NKOCALOKDFK, float CCHJMDGPGPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class GNJILIOLELM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int GODBNEEDLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private int FMNFAAKGCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private List<T> ELHBJHFMJCP;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public T KNOBNAMJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x27674F0", Offset = "0x27668F0", VA = "0x1827674F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T KHIFMPADHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2767680", Offset = "0x2766A80", VA = "0x182767680")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T AHEPPFIPHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x2767770", Offset = "0x2766B70", VA = "0x182767770")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2767AA0", Offset = "0x2766EA0", VA = "0x182767AA0")]
	public GNJILIOLELM(int GODBNEEDLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2767810", Offset = "0x2766C10", VA = "0x182767810")]
	public void NAIBOGJCHDH(T MFJINFADGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x27676C0", Offset = "0x2766AC0", VA = "0x1827676C0")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x27677C0", Offset = "0x2766BC0", VA = "0x1827677C0")]
	public void LIBAPJAODMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2767A90", Offset = "0x2766E90", VA = "0x182767A90")]
	public void OLBJGFPLEGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class IGBGKPNBMGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct BBNOHDBMBNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int PHLCAOECDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public T JLGPLOCBIGO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Dictionary<object, BBNOHDBMBNB> KEPDCHMPGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private T JNCKIOGCBNH;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T JKBCNPOKOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xDF9350", Offset = "0xDF8750", VA = "0x180DF9350", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2895730", Offset = "0x2894B30", VA = "0x182895730", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool MEBDIMCBOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2A52230", Offset = "0x2A51630", VA = "0x182A52230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public object JJFOJAKKKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4C2CF0", Offset = "0x4C20F0", VA = "0x1804C2CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4E97D0", Offset = "0x4E8BD0", VA = "0x1804E97D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2A52930", Offset = "0x2A51D30", VA = "0x182A52930")]
	public bool PLJELGDMNFG(T IFBOOLFAOLF, object BHDIPBIGOKK, int MNEOJGLJNOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2A51C30", Offset = "0x2A51030", VA = "0x182A51C30")]
	public bool FCBNLDKADOO(object BHDIPBIGOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2A52100", Offset = "0x2A51500", VA = "0x182A52100")]
	public bool FDNNMHLHJCI(object BHDIPBIGOKK, out T IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2A51C00", Offset = "0x2A51000", VA = "0x182A51C00")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2A4CF20", Offset = "0x2A4C320", VA = "0x182A4CF20")]
	private bool DDHBFJPIJGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2A529B0", Offset = "0x2A51DB0", VA = "0x182A529B0")]
	public IGBGKPNBMGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class NLHDAFKHAJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Dictionary<object, float> KEPDCHMPGGE;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float LONAHKDAIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xCC4E70", Offset = "0xCC4270", VA = "0x180CC4E70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xC0EC80", Offset = "0xC0E080", VA = "0x180C0EC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x43B3FB0", Offset = "0x43B33B0", VA = "0x1843B3FB0")]
	public void PLJELGDMNFG(float IFBOOLFAOLF, object BHDIPBIGOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x43B3E20", Offset = "0x43B3220", VA = "0x1843B3E20")]
	public void FCBNLDKADOO(object BHDIPBIGOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x43B3E90", Offset = "0x43B3290", VA = "0x1843B3E90")]
	private void HCJBGBPCBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x43B4020", Offset = "0x43B3420", VA = "0x1843B4020")]
	public NLHDAFKHAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class MFAOKOCIKKP
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class CFNMOEPDGGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly string HIOCMNIPENH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		private CFNMOEPDGGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x59C930", Offset = "0x59BD30", VA = "0x18059C930")]
		public CFNMOEPDGGC(string HIOCMNIPENH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x43B3190", Offset = "0x43B2590", VA = "0x1843B3190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class GMHPIPEJEJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
		public GMHPIPEJEJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x43B32E0", Offset = "0x43B26E0", VA = "0x1843B32E0")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HashSet<object> IMJFDEHGPLG;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool LLJBGDGEEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x43B3AB0", Offset = "0x43B2EB0", VA = "0x1843B3AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int NMPIDIMNOND
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x43B3A20", Offset = "0x43B2E20", VA = "0x1843B3A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x43B3AF0", Offset = "0x43B2EF0", VA = "0x1843B3AF0")]
	public bool NAIBOGJCHDH(object BHDIPBIGOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x43B3970", Offset = "0x43B2D70", VA = "0x1843B3970")]
	public bool AOJGMCBPBFH(object BHDIPBIGOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x43B3BA0", Offset = "0x43B2FA0", VA = "0x1843B3BA0")]
	public bool PDGNNJCKANN(object BHDIPBIGOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x43B3A60", Offset = "0x43B2E60", VA = "0x1843B3A60")]
	public void GFPJHDNBAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x43B3C00", Offset = "0x43B3000", VA = "0x1843B3C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x43B3D60", Offset = "0x43B3160", VA = "0x1843B3D60")]
	public MFAOKOCIKKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FIPBIECKDIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private struct APFNAPMMIPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public float BJJPNCGFJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public T JLGPLOCBIGO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Dictionary<object, APFNAPMMIPI> KEPDCHMPGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private T HOLNMOLAJKN;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public virtual T GLIHLELJEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xF50640", Offset = "0xF4FA40", VA = "0x180F50640", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x2A51BC0", Offset = "0x2A50FC0", VA = "0x182A51BC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public object IAIKHEJKMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4E7670", Offset = "0x4E6A70", VA = "0x1804E7670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x59F9E0", Offset = "0x59EDE0", VA = "0x18059F9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool MEBDIMCBOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x2ECD140", Offset = "0x2ECC540", VA = "0x182ECD140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3535CA0", Offset = "0x35350A0", VA = "0x183535CA0")]
	public bool PLJELGDMNFG(T IFBOOLFAOLF, object BHDIPBIGOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD060", Offset = "0x2ECC460", VA = "0x182ECD060")]
	public bool FCBNLDKADOO(object BHDIPBIGOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2A51C00", Offset = "0x2A51000", VA = "0x182A51C00")]
	public void ELLPAGIADBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD0C0", Offset = "0x2ECC4C0", VA = "0x182ECD0C0")]
	public bool FDNNMHLHJCI(object BHDIPBIGOKK, out T IFBOOLFAOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2ECCC80", Offset = "0x2ECC080", VA = "0x182ECCC80")]
	private bool DDHBFJPIJGE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2ECD290", Offset = "0x2ECC690", VA = "0x182ECD290")]
	public FIPBIECKDIN()
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
