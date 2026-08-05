using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6110020", Offset = "0x610F420", VA = "0x186110020")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class MCKHDBJIKGA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected MCKHDBJIKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class FFIPFCGNEJE<T> : MCKHDBJIKGA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct IKFLCBACHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JHAOJPBEHIP
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public JHAOJPBEHIP FICJMFBEBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T HKJBPIINLDG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int HDHKLFLMNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool ECFHDHBMOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool MPBMHFJLJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? LBFNPKILJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<IKFLCBACHIJ>? AIMHNOEAOCL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DMEBFCHFMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x363DCF0", Offset = "0x363D0F0", VA = "0x18363DCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x363DD40", Offset = "0x363D140", VA = "0x18363DD40")]
	protected FFIPFCGNEJE(bool MPBMHFJLJPD, bool ECFHDHBMOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x363DC50", Offset = "0x363D050", VA = "0x18363DC50")]
	protected bool PEFHFGHBDBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x363DB50", Offset = "0x363CF50", VA = "0x18363DB50")]
	protected void NOCEGACBFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x363D7C0", Offset = "0x363CBC0", VA = "0x18363D7C0")]
	protected void EDBLIPDCEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2216430", Offset = "0x2215830", VA = "0x182216430")]
	private static void PCOENOIGGOH<U>(List<U>? PHHAAPDMADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x363D460", Offset = "0x363C860", VA = "0x18363D460", Slot = "4")]
	public void AFPNFDHLNMK(T HKJBPIINLDG, bool EEJILBAJGJM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x363D9A0", Offset = "0x363CDA0", VA = "0x18363D9A0", Slot = "5")]
	public void JJHPGEAJNEC(T HKJBPIINLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x363D640", Offset = "0x363CA40", VA = "0x18363D640")]
	public void BILLODBOEME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KCJJJNFDHFE
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFPNFDHLNMK(Action HKJBPIINLDG, bool EEJILBAJGJM = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJHPGEAJNEC(Action HKJBPIINLDG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class DICJLHNIKOO : FFIPFCGNEJE<Action>, KCJJJNFDHFE
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x610E150", Offset = "0x610D550", VA = "0x18610E150")]
	public DICJLHNIKOO(bool MPBMHFJLJPD = false, bool ECFHDHBMOCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x610DE90", Offset = "0x610D290", VA = "0x18610DE90")]
	public void ECPBHENEKEG()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x610E0F0", Offset = "0x610D4F0", VA = "0x18610E0F0")]
	public static DICJLHNIKOO PDPBBGPBEOE(DICJLHNIKOO MAOCMDCFIGM, Action HKJBPIINLDG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x610E090", Offset = "0x610D490", VA = "0x18610E090")]
	public static DICJLHNIKOO IINPHPOEAGJ(DICJLHNIKOO MAOCMDCFIGM, Action HKJBPIINLDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FEMEEACPPDC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFPNFDHLNMK(Action<T> HKJBPIINLDG, bool EEJILBAJGJM = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJHPGEAJNEC(Action<T> HKJBPIINLDG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class EPDOKNAGJLN<T> : FFIPFCGNEJE<Action<T>>, FEMEEACPPDC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x32E8F10", Offset = "0x32E8310", VA = "0x1832E8F10")]
	public EPDOKNAGJLN(bool MPBMHFJLJPD = false, bool ECFHDHBMOCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x32E82E0", Offset = "0x32E76E0", VA = "0x1832E82E0")]
	public void ECPBHENEKEG(T MMKOHGNNHLF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32E8E80", Offset = "0x32E8280", VA = "0x1832E8E80")]
	public static EPDOKNAGJLN<T> PDPBBGPBEOE(EPDOKNAGJLN<T> MAOCMDCFIGM, Action<T> HKJBPIINLDG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x32E8DF0", Offset = "0x32E81F0", VA = "0x1832E8DF0")]
	public static EPDOKNAGJLN<T> IINPHPOEAGJ(EPDOKNAGJLN<T> MAOCMDCFIGM, Action<T> HKJBPIINLDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LPABBCJMCPD<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BDNCPNIGOBB<T, U> : FFIPFCGNEJE<Action<T, U>>, LPABBCJMCPD<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x32E8F10", Offset = "0x32E8310", VA = "0x1832E8F10")]
	public BDNCPNIGOBB(bool MPBMHFJLJPD = false, bool ECFHDHBMOCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x47191B0", Offset = "0x47185B0", VA = "0x1847191B0")]
	public void ECPBHENEKEG(T MMKOHGNNHLF, U KJJKOEACLDA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32E8E80", Offset = "0x32E8280", VA = "0x1832E8E80")]
	public static BDNCPNIGOBB<T, U> PDPBBGPBEOE(BDNCPNIGOBB<T, U> MAOCMDCFIGM, Action<T, U> HKJBPIINLDG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x32E8DF0", Offset = "0x32E81F0", VA = "0x1832E8DF0")]
	public static BDNCPNIGOBB<T, U> IINPHPOEAGJ(BDNCPNIGOBB<T, U> MAOCMDCFIGM, Action<T, U> HKJBPIINLDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class LJHNLLLDHAJ<T, U, V> : FFIPFCGNEJE<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32E8F10", Offset = "0x32E8310", VA = "0x1832E8F10")]
	public LJHNLLLDHAJ(bool MPBMHFJLJPD = false, bool ECFHDHBMOCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0320", Offset = "0x3BCF720", VA = "0x183BD0320")]
	public void ECPBHENEKEG(T MMKOHGNNHLF, U KJJKOEACLDA, V EOGGNGHJCKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x32E8E80", Offset = "0x32E8280", VA = "0x1832E8E80")]
	public static LJHNLLLDHAJ<T, U, V> PDPBBGPBEOE(LJHNLLLDHAJ<T, U, V> MAOCMDCFIGM, Action<T, U, V> HKJBPIINLDG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x32E8DF0", Offset = "0x32E81F0", VA = "0x1832E8DF0")]
	public static LJHNLLLDHAJ<T, U, V> IINPHPOEAGJ(LJHNLLLDHAJ<T, U, V> MAOCMDCFIGM, Action<T, U, V> HKJBPIINLDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KPPBPHDBDIO<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FFABJIHPBFO<T, U, V, W> : FFIPFCGNEJE<Action<T, U, V, W>>, KPPBPHDBDIO<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x32E8F10", Offset = "0x32E8310", VA = "0x1832E8F10")]
	public FFABJIHPBFO(bool MPBMHFJLJPD = false, bool ECFHDHBMOCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x363A040", Offset = "0x3639440", VA = "0x18363A040")]
	public void ECPBHENEKEG(T MMKOHGNNHLF, U KJJKOEACLDA, V EOGGNGHJCKF, W ILMPPGIJBNP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32E8E80", Offset = "0x32E8280", VA = "0x1832E8E80")]
	public static FFABJIHPBFO<T, U, V, W> PDPBBGPBEOE(FFABJIHPBFO<T, U, V, W> MAOCMDCFIGM, Action<T, U, V, W> HKJBPIINLDG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x32E8DF0", Offset = "0x32E81F0", VA = "0x1832E8DF0")]
	public static FFABJIHPBFO<T, U, V, W> IINPHPOEAGJ(FFABJIHPBFO<T, U, V, W> MAOCMDCFIGM, Action<T, U, V, W> HKJBPIINLDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NJOKLIGLHJA<T, U, V, W, X> : FFIPFCGNEJE<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x32E8F10", Offset = "0x32E8310", VA = "0x1832E8F10")]
	public NJOKLIGLHJA(bool MPBMHFJLJPD = false, bool ECFHDHBMOCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3ED6F00", Offset = "0x3ED6300", VA = "0x183ED6F00")]
	public void ECPBHENEKEG(T MMKOHGNNHLF, U KJJKOEACLDA, V EOGGNGHJCKF, W ILMPPGIJBNP, X NEEBEKKMNIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x32E8E80", Offset = "0x32E8280", VA = "0x1832E8E80")]
	public static NJOKLIGLHJA<T, U, V, W, X> PDPBBGPBEOE(NJOKLIGLHJA<T, U, V, W, X> MAOCMDCFIGM, Action<T, U, V, W, X> HKJBPIINLDG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32E8DF0", Offset = "0x32E81F0", VA = "0x1832E8DF0")]
	public static NJOKLIGLHJA<T, U, V, W, X> IINPHPOEAGJ(NJOKLIGLHJA<T, U, V, W, X> MAOCMDCFIGM, Action<T, U, V, W, X> HKJBPIINLDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class ICKMAINBLLO<T, U, V, W, X, Y> : FFIPFCGNEJE<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32E8F10", Offset = "0x32E8310", VA = "0x1832E8F10")]
	public ICKMAINBLLO(bool MPBMHFJLJPD = false, bool ECFHDHBMOCH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x381ECE0", Offset = "0x381E0E0", VA = "0x18381ECE0")]
	public void ECPBHENEKEG(T MMKOHGNNHLF, U KJJKOEACLDA, V EOGGNGHJCKF, W ILMPPGIJBNP, X NEEBEKKMNIB, Y IGHOLFEOMDB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32E8E80", Offset = "0x32E8280", VA = "0x1832E8E80")]
	public static ICKMAINBLLO<T, U, V, W, X, Y> PDPBBGPBEOE(ICKMAINBLLO<T, U, V, W, X, Y> MAOCMDCFIGM, Action<T, U, V, W, X, Y> HKJBPIINLDG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x32E8DF0", Offset = "0x32E81F0", VA = "0x1832E8DF0")]
	public static ICKMAINBLLO<T, U, V, W, X, Y> IINPHPOEAGJ(ICKMAINBLLO<T, U, V, W, X, Y> MAOCMDCFIGM, Action<T, U, V, W, X, Y> HKJBPIINLDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FLPDAPGIJBM<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DKDFOLFALNK<TKey, TVal> DOMBGKPKFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> IJEPMAONINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int JHMLLHPOCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly DKDFOLFALNK<TKey, TVal>.ACBHGHFIDEK? LKOENJCIGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int ANHPLLGIAFB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int BHAKECDNILO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x364AC40", Offset = "0x364A040", VA = "0x18364AC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LBMAEDLDEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x364B450", Offset = "0x364A850", VA = "0x18364B450")]
	public FLPDAPGIJBM(int JHMLLHPOCAO, [Optional] DKDFOLFALNK<TKey, TVal>.ACBHGHFIDEK? LKOENJCIGJH, [Optional] IEqualityComparer<TKey>? NNHMJPOJLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x364AC90", Offset = "0x364A090", VA = "0x18364AC90")]
	public void FBHEIHODJHM(TKey GPGELODKPOB, TVal ANJCCKHBJJO, bool AJPOHBEBAAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x364B210", Offset = "0x364A610", VA = "0x18364B210")]
	public bool LNKODABJNAA(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x364B2B0", Offset = "0x364A6B0", VA = "0x18364B2B0")]
	public bool NICDJPMLKAP(TKey FMMIOOAOPHB, [Out] TVal ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x364AFF0", Offset = "0x364A3F0", VA = "0x18364AFF0")]
	private void LHGOFJOMIBN(TKey GPGELODKPOB, TVal ANJCCKHBJJO, int HFPFBPPBALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x364AE60", Offset = "0x364A260", VA = "0x18364AE60")]
	public bool JDAOJFLEHKL(TKey GPGELODKPOB, TVal ANJCCKHBJJO, bool AJPOHBEBAAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x364B390", Offset = "0x364A790", VA = "0x18364B390")]
	private bool OJBKFLALPGL(TKey GPGELODKPOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DLFJOPDLHMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Action BBGFONLEOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool CLOIDJOGBEA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public DLFJOPDLHMI(Action MKAMNANGLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x610E1B0", Offset = "0x610D5B0", VA = "0x18610E1B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2455E00", Offset = "0x2455200", VA = "0x182455E00")]
	public static NJKEHFGOEOH<T> HDHFILGDDKG<T>(T ANJCCKHBJJO, Action MKAMNANGLOF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class NJKEHFGOEOH<T> : DLFJOPDLHMI where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T BDGBGLMDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3ED65B0", Offset = "0x3ED59B0", VA = "0x183ED65B0")]
	public NJKEHFGOEOH(T ANJCCKHBJJO, Action MKAMNANGLOF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LKOBEBLODOA : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DBBOJEKCPLI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780")]
		public static DBBOJEKCPLI CPLKLKACALP()
		{
			return default(DBBOJEKCPLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780")]
	public static LKOBEBLODOA DHIBDNKNHDD(Type FICJMFBEBIN, [Optional] string? ABJFMMEHDPA, [Optional] string? BEGGPCGHMOH, bool FPMMLDBFDGH = false)
	{
		return default(LKOBEBLODOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780")]
	public static LKOBEBLODOA DHIBDNKNHDD<T>([Optional] string? ABJFMMEHDPA, [Optional] string? BEGGPCGHMOH, bool FPMMLDBFDGH = false)
	{
		return default(LKOBEBLODOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KLKMDLGLEMA
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool ODMDGMOJINO(string LHKINJNIKGN, KLKMDLGLEMA JPLOMOJICDP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int DBNNOOCLLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public string LOGKFPNKENG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x610F3E0", Offset = "0x610E7E0", VA = "0x18610F3E0")]
	public static Dictionary<string, KLKMDLGLEMA> AICMNLFKLMK(Type EDOPCHLPFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x610F710", Offset = "0x610EB10", VA = "0x18610F710")]
	public static Dictionary<string, KLKMDLGLEMA> CNCFJABMDMC(Type EDOPCHLPFOF, ODMDGMOJINO FALGFCBBDEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x610FC00", Offset = "0x610F000", VA = "0x18610FC00")]
	public static Dictionary<int, string> IHKKDIMNJLB(Dictionary<string, KLKMDLGLEMA> HEKLPNHIOGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class JELHNABDLNM : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string MECCLMMNDHG(string MPJJCEJFHBK);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7AF100", Offset = "0x7AE500", VA = "0x1807AF100")]
	protected JELHNABDLNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class PKAEFJIJPHG : LKFFGCCEJDH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool AFHPKNGJBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly string? BFLHENJJHJP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual LKFFGCCEJDH? JFEBFFFFJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x61109E0", Offset = "0x610FDE0", VA = "0x1861109E0")]
	protected PKAEFJIJPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KHCKPFAHKDL();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61104F0", Offset = "0x610F8F0", VA = "0x1861104F0", Slot = "8")]
	public virtual string FBDMMKIIEII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6110730", Offset = "0x610FB30", VA = "0x186110730", Slot = "9")]
	public void PHGHOHEFFBI(StringBuilder DKIEIJINEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6110330", Offset = "0x610F730", VA = "0x186110330", Slot = "10")]
	public void APAHKADPECD(StringBuilder DKIEIJINEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6110570", Offset = "0x610F970", VA = "0x186110570", Slot = "11")]
	public void IBJHFNMGDPD(StringBuilder DKIEIJINEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6110390", Offset = "0x610F790", VA = "0x186110390", Slot = "12")]
	public void DBKIMFOJBBK(StringBuilder DKIEIJINEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6110690", Offset = "0x610FA90", VA = "0x186110690")]
	public static void JCHNALKOIBO(StringBuilder DKIEIJINEKM, string JHOAACICGPH, string CBAACJPEEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x53DF170", Offset = "0x53DE570", VA = "0x1853DF170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HELNFFJIFGO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x610EB10", Offset = "0x610DF10", VA = "0x18610EB10")]
	public HELNFFJIFGO(string CAIOIMEOMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GBIAMJNDLME<TErr> : HELNFFJIFGO where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr IFDDIOMBANC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x36F6650", Offset = "0x36F5A50", VA = "0x1836F6650")]
	private GBIAMJNDLME([In] TErr PFDKKELFKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x36F6580", Offset = "0x36F5980", VA = "0x1836F6580")]
	public static GBIAMJNDLME<TErr> CPLKLKACALP([In] TErr PFDKKELFKNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LKFFGCCEJDH
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FBDMMKIIEII();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KHCKPFAHKDL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface APDCEPCILFI<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions BDGBGLMDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NIHDDNPENCP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string EPNHACEBNOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OFDPBOAPJFH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61100A0", Offset = "0x610F4A0", VA = "0x1861100A0")]
	public OFDPBOAPJFH(string CAIOIMEOMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LGAHFPMFHPO<TOk> : OFDPBOAPJFH where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TOk POLHKBEDLIO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3B6C580", Offset = "0x3B6B980", VA = "0x183B6C580")]
	private LGAHFPMFHPO([In] TOk ADJNDOMGCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x32C1250", Offset = "0x32C0650", VA = "0x1832C1250")]
	public static LGAHFPMFHPO<TOk> CPLKLKACALP([In] TOk ADJNDOMGCJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct IAPKJCHKLLD<TOk, TErr> : IEquatable<IAPKJCHKLLD<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly EqualityComparer<TErr> HDHCGFDCMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly TErr IFDDIOMBANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TOk POLHKBEDLIO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BODFNKDNJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3810880", Offset = "0x380FC80", VA = "0x183810880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool OLGBDOMEELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3810290", Offset = "0x380F690", VA = "0x183810290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3813470", Offset = "0x3812870", VA = "0x183813470")]
	internal IAPKJCHKLLD([In] TErr PFDKKELFKNM, [In] TOk ADJNDOMGCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x380F980", Offset = "0x380ED80", VA = "0x18380F980")]
	public static IAPKJCHKLLD<TOk, TErr> INPILCILOFI([In] TErr PFDKKELFKNM)
	{
		return default(IAPKJCHKLLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x380BDD0", Offset = "0x380B1D0", VA = "0x18380BDD0")]
	public static IAPKJCHKLLD<TOk, TErr> ECEJIILFPJD([In] TOk ADJNDOMGCJA)
	{
		return default(IAPKJCHKLLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x239FF70", Offset = "0x239F370", VA = "0x18239FF70")]
	public IAPKJCHKLLD<TOk?, UErr?> ANLAEFIDEFE<UErr>()
	{
		return default(IAPKJCHKLLD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x23A09A0", Offset = "0x239FDA0", VA = "0x1823A09A0")]
	public IAPKJCHKLLD<UOk?, TErr?> CAKMMEABOAJ<UOk>()
	{
		return default(IAPKJCHKLLD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x23A17C0", Offset = "0x23A0BC0", VA = "0x1823A17C0")]
	public IAPKJCHKLLD<UOk?, TErr?> NAFDPCCCKNM<UOk>()
	{
		return default(IAPKJCHKLLD<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x23A0CD0", Offset = "0x23A00D0", VA = "0x1823A0CD0")]
	public IAPKJCHKLLD<TOk?, UErr?> MNLOJCJLJHO<UErr>()
	{
		return default(IAPKJCHKLLD<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x380FF70", Offset = "0x380F370", VA = "0x18380FF70")]
	public IAPKJCHKLLD<MKHCJDDCMIA, TErr> KLOELECNPEF()
	{
		return default(IAPKJCHKLLD<MKHCJDDCMIA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x380E780", Offset = "0x380DB80", VA = "0x18380E780")]
	public static bool HOHCACPHFGD([In] IAPKJCHKLLD<TOk, TErr> BGDKODNOBOD, [In] IAPKJCHKLLD<TOk, TErr> APAKCINIMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x380CCC0", Offset = "0x380C0C0", VA = "0x18380CCC0", Slot = "4")]
	public bool Equals(IAPKJCHKLLD<TOk, TErr> KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x380CD90", Offset = "0x380C190", VA = "0x18380CD90", Slot = "0")]
	public override bool Equals(object KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x380D900", Offset = "0x380CD00", VA = "0x18380D900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x38129A0", Offset = "0x3811DA0", VA = "0x1838129A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class JAEIAEMCFGI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct LOBPPKHIHPI<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Task<IAPKJCHKLLD<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<IAPKJCHKLLD<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3F00", Offset = "0x3BE3300", VA = "0x183BE3F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3BE4220", Offset = "0x3BE3620", VA = "0x183BE4220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x26CC920", Offset = "0x26CBD20", VA = "0x1826CC920")]
	public static IAPKJCHKLLD<TOk?, TErr?> POLHKBEDLIO<TOk, TErr>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [In] TOk ADJNDOMGCJA)
	{
		return default(IAPKJCHKLLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26CD6E0", Offset = "0x26CCAE0", VA = "0x1826CD6E0")]
	public static IAPKJCHKLLD<MKHCJDDCMIA, TErr?> POLHKBEDLIO<TErr>([In] this IAPKJCHKLLD<MKHCJDDCMIA, TErr> LOMPFKEACIP)
	{
		return default(IAPKJCHKLLD<MKHCJDDCMIA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x26CC920", Offset = "0x26CBD20", VA = "0x1826CC920")]
	public static IAPKJCHKLLD<TOk?, TErr?> IFDDIOMBANC<TOk, TErr>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [In] TErr PFDKKELFKNM)
	{
		return default(IAPKJCHKLLD<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x26CCB90", Offset = "0x26CBF90", VA = "0x1826CCB90")]
	public static TOk? IHMNGFMLKGI<TOk, TErr>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x26CD440", Offset = "0x26CC840", VA = "0x1826CD440")]
	[AsyncStateMachine(typeof(LOBPPKHIHPI<, >))]
	public static Task<TOk?>? PIKHCFIJBMI<TOk, TErr>(this Task<IAPKJCHKLLD<TOk, TErr>> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26CD140", Offset = "0x26CC540", VA = "0x1826CD140")]
	public static TErr? IMFHABBCEHM<TErr, TOk>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26CB7A0", Offset = "0x26CABA0", VA = "0x1826CB7A0")]
	public static bool FNPMEEMJHFF<TOk, TErr, UErr, UOk>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [Out] IAPKJCHKLLD<UOk, UErr> FKJHMECNNFN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x26CADA0", Offset = "0x26CA1A0", VA = "0x1826CADA0")]
	public static bool CLKCLDLEKJP<TOk, TErr>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [Out][NotNullWhen(true)] TOk ADJNDOMGCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26CC7F0", Offset = "0x26CBBF0", VA = "0x1826CC7F0")]
	public static bool FPCFMMECBGJ<TOk, TErr>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [Out][NotNullWhen(true)] TErr PFDKKELFKNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x26CD350", Offset = "0x26CC750", VA = "0x1826CD350")]
	public static bool OOAHBCBMLEG<TOk, TErr>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [Out][NotNullWhen(true)] TOk ADJNDOMGCJA, [Out][NotNullWhen(false)] TErr PFDKKELFKNM) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x26CA8A0", Offset = "0x26C9CA0", VA = "0x1826CA8A0")]
	public static bool ADHEFLGKNMM<TOk, TErr>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [Out][NotNullWhen(true)] TOk ADJNDOMGCJA, [Out] IAPKJCHKLLD<TOk, TErr> FKJHMECNNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x26CB9D0", Offset = "0x26CADD0", VA = "0x1826CB9D0")]
	public static bool FNPMEEMJHFF<TOk, TErr, UErr, UOk>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [Out][NotNullWhen(true)] TOk ADJNDOMGCJA, [Out] IAPKJCHKLLD<UOk, UErr> FKJHMECNNFN) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x26CB440", Offset = "0x26CA840", VA = "0x1826CB440")]
	public static bool FEAJDKILMBN<TOk, TErr>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [Out][NotNullWhen(true)] TOk ADJNDOMGCJA, [Out] IAPKJCHKLLD<MKHCJDDCMIA, TErr> FKJHMECNNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26CB050", Offset = "0x26CA450", VA = "0x1826CB050")]
	public static IAPKJCHKLLD<UOk, UErr> EMIPEJFDGND<UOk, UErr, TOk, TErr>([In] this IAPKJCHKLLD<TOk, TErr> LOMPFKEACIP, [In] IAPKJCHKLLD<UOk, UErr> OIGNJCHPDMC) where TOk : UOk where TErr : UErr
	{
		return default(IAPKJCHKLLD<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26CA9A0", Offset = "0x26C9DA0", VA = "0x1826CA9A0")]
	public static IAPKJCHKLLD<TOk?[]?, TErr?> AGPKANFAGLJ<TOk, TErr>(this IEnumerable<IAPKJCHKLLD<TOk, TErr>> LOMPFKEACIP)
	{
		return default(IAPKJCHKLLD<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class OLEDHDBHIFC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x25C9510", Offset = "0x25C8910", VA = "0x1825C9510")]
	public static IAPKJCHKLLD<TOk, T> POLHKBEDLIO<TOk>([In] TOk ADJNDOMGCJA) where TOk : notnull
	{
		return default(IAPKJCHKLLD<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3FDFB40", Offset = "0x3FDEF40", VA = "0x183FDFB40")]
	public static IAPKJCHKLLD<MKHCJDDCMIA, T> POLHKBEDLIO()
	{
		return default(IAPKJCHKLLD<MKHCJDDCMIA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25C9510", Offset = "0x25C8910", VA = "0x1825C9510")]
	public static IAPKJCHKLLD<T, TErr> IFDDIOMBANC<TErr>([In] TErr PFDKKELFKNM) where TErr : notnull
	{
		return default(IAPKJCHKLLD<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public sealed class KDHHLOKDLFP<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct DMJAOKBOOPO : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly KDHHLOKDLFP<T> FHNNDHGHDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int DOLCJBAGGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool EMMNJFMKDHA;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1C52B20", Offset = "0x1C51F20", VA = "0x181C52B20")]
		public DMJAOKBOOPO(KDHHLOKDLFP<T> FBIBFNALIEI, int FDFOOKBHEMA, bool HDIDOCLMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5017500", Offset = "0x5016900", VA = "0x185017500")]
		public KDHHLOKDLFP<T>.AABNDBMPPEH JLFJDPHFECC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x50175F0", Offset = "0x50169F0", VA = "0x1850175F0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x50175F0", Offset = "0x50169F0", VA = "0x1850175F0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class AABNDBMPPEH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly KDHHLOKDLFP<T> FHNNDHGHDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int BKHALOADJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int EEMOEFHBFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly bool EMMNJFMKDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool EHFLHBHHGHF;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x36B1500", Offset = "0x36B0900", VA = "0x1836B1500")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x36B15F0", Offset = "0x36B09F0", VA = "0x1836B15F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x36B1760", Offset = "0x36B0B60", VA = "0x1836B1760", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x36B19C0", Offset = "0x36B0DC0", VA = "0x1836B19C0")]
		public AABNDBMPPEH(KDHHLOKDLFP<T> FBIBFNALIEI, int FDFOOKBHEMA, bool HDIDOCLMLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x36B1540", Offset = "0x36B0940", VA = "0x1836B1540", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x36B15D0", Offset = "0x36B09D0", VA = "0x1836B15D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class EMEDIEDFOKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public EMEDIEDFOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x32C15C0", Offset = "0x32C09C0", VA = "0x1832C15C0")]
		internal T BOHAJKGCMGE(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly T[] GKDJJOCDIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int EEMOEFHBFJA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GGNLEBJOBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE9C0", Offset = "0x3ABDDC0", VA = "0x183ABE9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T PPPEJOJKNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3625F80", Offset = "0x3625380", VA = "0x183625F80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T NKLJCNFJDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3ABEA10", Offset = "0x3ABDE10", VA = "0x183ABEA10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE740", Offset = "0x3ABDB40", VA = "0x183ABE740")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BGGPFCEBPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x16251C0", Offset = "0x16245C0", VA = "0x1816251C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xF23C80", Offset = "0xF23080", VA = "0x180F23C80")]
	private static int AAFGDJAPIGG(int AHDNEIKOMIB, int FLCGLAMBOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEBC0", Offset = "0x3ABDFC0", VA = "0x183ABEBC0")]
	public KDHHLOKDLFP(int HFPFBPPBALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEA40", Offset = "0x3ABDE40", VA = "0x183ABEA40")]
	public KDHHLOKDLFP(int HFPFBPPBALK, Func<T> OJOCGADMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3ABECD0", Offset = "0x3ABE0D0", VA = "0x183ABECD0")]
	public KDHHLOKDLFP(T[] PGGCOHKMABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE990", Offset = "0x3ABDD90", VA = "0x183ABE990")]
	public void MLIGHHIHNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE840", Offset = "0x3ABDC40", VA = "0x183ABE840")]
	public IEnumerable<T> JFCCGGEMCLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE900", Offset = "0x3ABDD00", VA = "0x183ABE900")]
	public KDHHLOKDLFP<T>.AABNDBMPPEH JLFJDPHFECC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x369CB00", Offset = "0x369BF00", VA = "0x18369CB00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x369CB00", Offset = "0x369BF00", VA = "0x18369CB00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FKENAPHMHOO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x266E960", Offset = "0x266DD60", VA = "0x18266E960")]
	public static KDHHLOKDLFP<T> CPLKLKACALP<T>(int HFPFBPPBALK, Func<T> OJOCGADMMBN) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1D3ABD0", Offset = "0x1D39FD0", VA = "0x181D3ABD0")]
		public RRColor(float DMMNOJMKOEO, float DNAPFMHJFCB, float NFAPJGNODPK, float KHCOFGFJDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6110A50", Offset = "0x610FE50", VA = "0x186110A50", Slot = "4")]
		public bool Equals(RRColor KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6110AD0", Offset = "0x610FED0", VA = "0x186110AD0", Slot = "0")]
		public override bool Equals(object KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6110BD0", Offset = "0x610FFD0", VA = "0x186110BD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6110C50", Offset = "0x6110050", VA = "0x186110C50", Slot = "5")]
		public string ToString(string BBJFPPIECOB, IFormatProvider NHJAHNIKJMD)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class MAFPGMIGMBN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public readonly struct AEJNCKFEDDD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly MAFPGMIGMBN<T> JDFCJJFCEJO;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T BDGBGLMDOLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x36BBA70", Offset = "0x36BAE70", VA = "0x1836BBA70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x36BBA40", Offset = "0x36BAE40", VA = "0x1836BBA40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
		public AEJNCKFEDDD(MAFPGMIGMBN<T> JDFCJJFCEJO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct GCODIINMEEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<AEJNCKFEDDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MAFPGMIGMBN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x36FA740", Offset = "0x36F9B40", VA = "0x1836FA740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x30C67D0", Offset = "0x30C5BD0", VA = "0x1830C67D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly SemaphoreSlim APCFKFPCHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T CKFMKEFECJJ;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D990F0", Offset = "0x3D984F0", VA = "0x183D990F0")]
	public MAFPGMIGMBN([In] T CKFMKEFECJJ, int BFEEJGFGJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D99030", Offset = "0x3D98430", VA = "0x183D99030")]
	public MAFPGMIGMBN([In] T CKFMKEFECJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D98F20", Offset = "0x3D98320", VA = "0x183D98F20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D98F40", Offset = "0x3D98340", VA = "0x183D98F40")]
	public AEJNCKFEDDD OELKMCMNIIF()
	{
		return default(AEJNCKFEDDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D98AA0", Offset = "0x3D97EA0", VA = "0x183D98AA0")]
	[AsyncStateMachine(typeof(MAFPGMIGMBN<>.GCODIINMEEP))]
	public Task<MAFPGMIGMBN<T>.AEJNCKFEDDD> AJNIMDDHEHI(CancellationToken PPJMMMGPFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D98A80", Offset = "0x3D97E80", VA = "0x183D98A80")]
	public void AIIBGMNIBPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class CGAOKOCCHOO
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x610DD80", Offset = "0x610D180", VA = "0x18610DD80")]
	public static MAFPGMIGMBN<MKHCJDDCMIA> CPLKLKACALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x24EEE80", Offset = "0x24EE280", VA = "0x1824EEE80")]
	public static MAFPGMIGMBN<T> CPLKLKACALP<T>([In] T CKFMKEFECJJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CONHBFFJJJP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct LIOGLOPJKGP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly CONHBFFJJJP<T> BMDEPGMAHGB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T BDGBGLMDOLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x3BCB890", Offset = "0x3BCAC90", VA = "0x183BCB890")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3BCB770", Offset = "0x3BCAB70", VA = "0x183BCB770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
		internal LIOGLOPJKGP(CONHBFFJJJP<T> JDFCJJFCEJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct CFOMMOHOFIN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly CONHBFFJJJP<T> BMDEPGMAHGB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T BDGBGLMDOLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x3BCB890", Offset = "0x3BCAC90", VA = "0x183BCB890")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x492D010", Offset = "0x492C410", VA = "0x18492D010", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
		internal CFOMMOHOFIN(CONHBFFJJJP<T> JDFCJJFCEJO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct MIFGDNLODKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<CFOMMOHOFIN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CONHBFFJJJP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MAFPGMIGMBN<MKHCJDDCMIA>.AEJNCKFEDDD <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<MAFPGMIGMBN<MKHCJDDCMIA>.AEJNCKFEDDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3DEB2A0", Offset = "0x3DEA6A0", VA = "0x183DEB2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x30C67D0", Offset = "0x30C5BD0", VA = "0x1830C67D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MAFPGMIGMBN<int> FAFJJJCGKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly MAFPGMIGMBN<MKHCJDDCMIA> PKIDONDNNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly MAFPGMIGMBN<MKHCJDDCMIA> MGAPKOFIHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private T IELICDMLKKM;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4B0AF80", Offset = "0x4B0A380", VA = "0x184B0AF80")]
	internal CONHBFFJJJP(MAFPGMIGMBN<int> HBOAEGLCPND, MAFPGMIGMBN<MKHCJDDCMIA> KNBJDIJMOFL, MAFPGMIGMBN<MKHCJDDCMIA> NDHJMPHCEKL, [In] T CKFMKEFECJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B0A5B0", Offset = "0x4B099B0", VA = "0x184B0A5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B0A9B0", Offset = "0x4B09DB0", VA = "0x184B0A9B0")]
	public LIOGLOPJKGP FALEBMBGEKM()
	{
		return default(LIOGLOPJKGP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B0A1E0", Offset = "0x4B095E0", VA = "0x184B0A1E0")]
	public CFOMMOHOFIN DKGLIBKFBPG()
	{
		return default(CFOMMOHOFIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4B0AB70", Offset = "0x4B09F70", VA = "0x184B0AB70")]
	[AsyncStateMachine(typeof(CONHBFFJJJP<>.MIFGDNLODKP))]
	public Task<CONHBFFJJJP<T>.CFOMMOHOFIN> MBFMOKOKLOE(CancellationToken PPJMMMGPFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class ALLELACFPLK
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x610D9E0", Offset = "0x610CDE0", VA = "0x18610D9E0")]
	public static CONHBFFJJJP<MKHCJDDCMIA> CPLKLKACALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8090", Offset = "0x2CF7490", VA = "0x182CF8090")]
	public static CONHBFFJJJP<T> CPLKLKACALP<T>([In] T CKFMKEFECJJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class LJNPEJBBHHJ<TData> : PKAEFJIJPHG where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly string MHEEAEBIAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly TData NCANEPOJAJP;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
	public override string KHCKPFAHKDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1050", Offset = "0x3BD0450", VA = "0x183BD1050")]
	internal LJNPEJBBHHJ(string CAIOIMEOMNJ, [In] TData ALPLHOOHPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class KPAALLMFGFC
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x610FDC0", Offset = "0x610F1C0", VA = "0x18610FDC0")]
	public static LJNPEJBBHHJ<MKHCJDDCMIA> CPLKLKACALP(string CAIOIMEOMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2455E00", Offset = "0x2455200", VA = "0x182455E00")]
	public static LJNPEJBBHHJ<TData> CPLKLKACALP<TData>(string CAIOIMEOMNJ, [In] TData ALPLHOOHPEL) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class IAOGDCOLHLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly Dictionary<object, float> LGLDLFPPHKD;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float IIJJLMHGEBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BCF60", Offset = "0x8BC360", VA = "0x1808BCF60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BD000", Offset = "0x8BC400", VA = "0x1808BD000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x610EBE0", Offset = "0x610DFE0", VA = "0x18610EBE0")]
	public void KLFCHEOKNCD(float ANJCCKHBJJO, object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x610EB70", Offset = "0x610DF70", VA = "0x18610EB70")]
	public void DKBAFHHGGMJ(object BDHKJODLPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x610EC50", Offset = "0x610E050", VA = "0x18610EC50")]
	private void MFFINEPPPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x610ED80", Offset = "0x610E180", VA = "0x18610ED80")]
	public IAOGDCOLHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class NOLLMIFILDN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class BHIBPPAAGPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public BHIBPPAAGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4731560", Offset = "0x4730960", VA = "0x184731560")]
		internal int EOJHIJLHNJE(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HashSet<T>? BDEMAKIDJOJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> LNJGLPBFKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F06D30", Offset = "0x3F06130", VA = "0x183F06D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JDMPGFMPOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F06EC0", Offset = "0x3F062C0", VA = "0x183F06EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x79E7B0", Offset = "0x79DBB0", VA = "0x18079E7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DD0", Offset = "0x7A81D0", VA = "0x1807A8DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3F06BC0", Offset = "0x3F05FC0", VA = "0x183F06BC0")]
	public bool AFPNFDHLNMK(T BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3F06D60", Offset = "0x3F06160", VA = "0x183F06D60")]
	public bool JJHPGEAJNEC(T BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3F06E80", Offset = "0x3F06280", VA = "0x183F06E80")]
	public bool JKHAEKACGLL(T BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3F06F00", Offset = "0x3F06300", VA = "0x183F06F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public NOLLMIFILDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class MBEDGPOODKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly string DBCMCEINIJL;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7AA060", VA = "0x1807AAC60")]
	public MBEDGPOODKK(string DBCMCEINIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x610FEF0", Offset = "0x610F2F0", VA = "0x18610FEF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class JLFBFMMGKPJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class KPCMHFNLJJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public KPCMHFNLJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x610FE40", Offset = "0x610F240", VA = "0x18610FE40")]
		internal int EOJHIJLHNJE(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private HashSet<object>? BDEMAKIDJOJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> LNJGLPBFKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x610F020", Offset = "0x610E420", VA = "0x18610F020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool JDMPGFMPOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x610F220", Offset = "0x610E620", VA = "0x18610F220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x79E7B0", Offset = "0x79DBB0", VA = "0x18079E7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8DD0", Offset = "0x7A81D0", VA = "0x1807A8DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x610EF40", Offset = "0x610E340", VA = "0x18610EF40")]
	public bool AFPNFDHLNMK(object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x610F0B0", Offset = "0x610E4B0", VA = "0x18610F0B0")]
	public bool JJHPGEAJNEC(object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x610F150", Offset = "0x610E550", VA = "0x18610F150")]
	public bool JKHAEKACGLL(object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x610F1B0", Offset = "0x610E5B0", VA = "0x18610F1B0")]
	public void KCGAKFDMLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x610F230", Offset = "0x610E630", VA = "0x18610F230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public JLFBFMMGKPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GFMJKNFJHKM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private struct HGLFEPHFKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float GINOLNPNPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public T BDGBGLMDOLF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly Dictionary<object, HGLFEPHFKGA> LGLDLFPPHKD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T BCKHAIBIJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xE47360", Offset = "0xE46760", VA = "0x180E47360", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xE46930", Offset = "0xE45D30", VA = "0x180E46930", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? LBMKJFNMGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OJHOIMMPEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3709DE0", Offset = "0x37091E0", VA = "0x183709DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3709660", Offset = "0x3708A60", VA = "0x183709660")]
	public bool KLFCHEOKNCD(T ANJCCKHBJJO, object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x37091E0", Offset = "0x37085E0", VA = "0x1837091E0")]
	public bool DKBAFHHGGMJ(object BDHKJODLPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3707BB0", Offset = "0x3706FB0", VA = "0x183707BB0")]
	public void BILLODBOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3709AC0", Offset = "0x3708EC0", VA = "0x183709AC0")]
	public bool NICDJPMLKAP(object BDHKJODLPCL, [Out] T ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x37084D0", Offset = "0x37078D0", VA = "0x1837084D0")]
	[GLNHMJBGBDI("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool CMGIFAPDBLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3709E30", Offset = "0x3709230", VA = "0x183709E30")]
	public GFMJKNFJHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PPEFLGHALAN
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CPEMIOKIPNM PFCIGMDKAKG;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FADAODJAGJO : PPEFLGHALAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public readonly struct BJIDKHMNOOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly float MDMCIMIHPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float OHPJLJEBDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		internal readonly bool OPNBALCMBJK;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float COAOMNLBCOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x610DAB0", Offset = "0x610CEB0", VA = "0x18610DAB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x610DC20", Offset = "0x610D020", VA = "0x18610DC20")]
		public BJIDKHMNOOC(float PKHCCBJJMMB, float NDFFDHJCFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x610DAC0", Offset = "0x610CEC0", VA = "0x18610DAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class DGEEILGLGCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FADAODJAGJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public DGEEILGLGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x610DDF0", Offset = "0x610D1F0", VA = "0x18610DDF0")]
		internal void PMDOFDNOJIB(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly int LNJIGPAGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private int OEJBNJNCGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PPEFLGHALAN[] GGBFCCADJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CPEMIOKIPNM[] LBELJDFAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly BJIDKHMNOOC[] KFAMAKIKJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private BJIDKHMNOOC KHNAHMBPPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PJNAONFMIOG MIPKJLPDIJC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event CPEMIOKIPNM PFCIGMDKAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x610E450", Offset = "0x610D850", VA = "0x18610E450", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x610E280", Offset = "0x610D680", VA = "0x18610E280", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x610E980", Offset = "0x610DD80", VA = "0x18610E980")]
	public FADAODJAGJO(int LNJIGPAGCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x610E1F0", Offset = "0x610D5F0", VA = "0x18610E1F0")]
	public PJNAONFMIOG CPFFEJFBPDH(BJIDKHMNOOC LMCPEPEFDGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x610E510", Offset = "0x610D910", VA = "0x18610E510")]
	public void FOILDMNHCGK(PPEFLGHALAN MDHGKBNILKK, [Optional] BJIDKHMNOOC CLCPKJDBPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x610E340", Offset = "0x610D740", VA = "0x18610E340", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public delegate void CPEMIOKIPNM(float PNIKIAKEFED);
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class IGLLBJLKLLC
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private class MGFOPNJKGOM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly PPEFLGHALAN FOMJOAJHIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly CPEMIOKIPNM KNDPECEGMIA;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x610FF90", Offset = "0x610F390", VA = "0x18610FF90")]
		public MGFOPNJKGOM(PPEFLGHALAN FOMJOAJHIGD, CPEMIOKIPNM KNDPECEGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x610FF40", Offset = "0x610F340", VA = "0x18610FF40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x610EED0", Offset = "0x610E2D0", VA = "0x18610EED0")]
	internal static bool OGHCGBONNKF(float KHCOFGFJDMP, float NFAPJGNODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x61034A0", Offset = "0x61028A0", VA = "0x1861034A0")]
	internal static float MDBICNMOIFA(float KHCOFGFJDMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x610EE10", Offset = "0x610E210", VA = "0x18610EE10")]
	public static IDisposable EEGAHNEPCIF(this PPEFLGHALAN FOMJOAJHIGD, CPEMIOKIPNM KNDPECEGMIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class PJNAONFMIOG : PPEFLGHALAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float PNIKIAKEFED;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float EKKOCPFADOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6110240", Offset = "0x610F640", VA = "0x186110240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event CPEMIOKIPNM? PFCIGMDKAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x61101A0", Offset = "0x610F5A0", VA = "0x1861101A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6110100", Offset = "0x610F500", VA = "0x186110100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public PJNAONFMIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class NOALBCEOKIM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5C33130", Offset = "0x5C32530", VA = "0x185C33130")]
	public NOALBCEOKIM(string CAIOIMEOMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class FNELEIOCEKP<TKey, TValue> : HKBOOLPIHPI<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, OHKKIIHNDNJ where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class HKBMEDDBCJN : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public FNELEIOCEKP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xE47360", Offset = "0xE46760", VA = "0x180E47360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3762500", Offset = "0x3761900", VA = "0x183762500", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public HKBMEDDBCJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x353A630", Offset = "0x3539A30", VA = "0x18353A630", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x37618D0", Offset = "0x3760CD0", VA = "0x1837618D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3761830", Offset = "0x3760C30", VA = "0x183761830")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x3761740", Offset = "0x3760B40", VA = "0x183761740")]
		private void DNFFEPBIMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3762460", Offset = "0x3761860", VA = "0x183762460", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly HKBOOLPIHPI<TKey, TValue> LOHCNBJCNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IDictionary<TKey, TValue> LGIOJPHJGFO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x36512B0", Offset = "0x36506B0", VA = "0x1836512B0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool DKAJDONKALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3651480", Offset = "0x3650880", VA = "0x183651480", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x36516E0", Offset = "0x3650AE0", VA = "0x1836516E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> EACLPELBJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x36514C0", Offset = "0x36508C0", VA = "0x1836514C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> HJIKCNONOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x36515D0", Offset = "0x36509D0", VA = "0x1836515D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3651130", Offset = "0x3650530", VA = "0x183651130")]
	public FNELEIOCEKP(HKBOOLPIHPI<TKey, TValue> LOHCNBJCNNG, [Optional] IDictionary<TKey, TValue>? LGIOJPHJGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x364F110", Offset = "0x364E510", VA = "0x18364F110", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x364FC40", Offset = "0x364F040", VA = "0x18364FC40")]
	public void DOEJNPJMGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x364E790", Offset = "0x364DB90", VA = "0x18364E790", Slot = "9")]
	public void Add(TKey GPGELODKPOB, TValue ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x364FA90", Offset = "0x364EE90", VA = "0x18364FA90")]
	public void DAGMNMKCLEC(TKey GPGELODKPOB, TValue ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x364EAA0", Offset = "0x364DEA0", VA = "0x18364EAA0")]
	public void CBFHKPOGGCO(TKey GPGELODKPOB, TValue ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x364EC50", Offset = "0x364E050", VA = "0x18364EC50")]
	public void CKEJNLEADKP(TKey GPGELODKPOB, TValue ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3650280", Offset = "0x364F680", VA = "0x183650280")]
	public void MKGOJEBCEDO(TKey GPGELODKPOB, TValue ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3650770", Offset = "0x364FB70", VA = "0x183650770", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> IEEBNOOJIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3650950", Offset = "0x364FD50", VA = "0x183650950", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3650B10", Offset = "0x364FF10", VA = "0x183650B10", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x364F220", Offset = "0x364E620", VA = "0x18364F220", Slot = "8")]
	public bool ContainsKey(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3650060", Offset = "0x364F460", VA = "0x183650060")]
	public bool HIPMPBHGKIK(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x36503B0", Offset = "0x364F7B0", VA = "0x1836503B0")]
	public bool NOEPKCONHCL(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x36504E0", Offset = "0x364F8E0", VA = "0x1836504E0", Slot = "10")]
	public bool Remove(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3650EA0", Offset = "0x36502A0", VA = "0x183650EA0", Slot = "11")]
	public bool TryGetValue(TKey GPGELODKPOB, [Out] TValue ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x364F520", Offset = "0x364E920", VA = "0x18364F520", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] MGNOJHKHDPK, int PNCNANACKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3650E70", Offset = "0x3650270", VA = "0x183650E70", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x364FFD0", Offset = "0x364F3D0", VA = "0x18364FFD0", Slot = "19")]
	[IteratorStateMachine(typeof(FNELEIOCEKP<, >.HKBMEDDBCJN))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3650190", Offset = "0x364F590", VA = "0x183650190", Slot = "21")]
	public bool JFAFBCKDKDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x364FD50", Offset = "0x364F150", VA = "0x18364FD50")]
	private TValue EGAEGJJAOLM(TKey GPGELODKPOB)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface OHKKIIHNDNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JFAFBCKDKDL();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface HKBOOLPIHPI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, OHKKIIHNDNJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public sealed class DKDFOLFALNK<TKey, TVal> : HKBOOLPIHPI<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, OHKKIIHNDNJ where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate int ACBHGHFIDEK(TKey GPGELODKPOB, TVal ANJCCKHBJJO);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class CJMBEGFHACB
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey LGEKOOBGCAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xB51610", Offset = "0xB50A10", VA = "0x180B51610")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal BDGBGLMDOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8BDD90", Offset = "0x8BD190", VA = "0x1808BDD90")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8BDDA0", Offset = "0x8BD1A0", VA = "0x1808BDDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int COAOMNLBCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x7DEC20", Offset = "0x7DE020", VA = "0x1807DEC20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDE50", VA = "0x1807DEA50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset DLHKPAEGEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA1FBE0", Offset = "0xA1EFE0", VA = "0x180A1FBE0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x1243B00", Offset = "0x1242F00", VA = "0x181243B00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4A2B850", Offset = "0x4A2AC50", VA = "0x184A2B850")]
		public CJMBEGFHACB(TKey GPGELODKPOB, TVal LEPPJAEDELJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class LNKDAEDKDBP : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DKDFOLFALNK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private LinkedList<CJMBEGFHACB>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xE47360", Offset = "0xE46760", VA = "0x180E47360", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3BE2AF0", Offset = "0x3BE1EF0", VA = "0x183BE2AF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public LNKDAEDKDBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3534370", Offset = "0x3533770", VA = "0x183534370", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3BE07E0", Offset = "0x3BDFBE0", VA = "0x183BE07E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3BE01C0", Offset = "0x3BDF5C0", VA = "0x183BE01C0")]
		private void JIKMBFFNLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3BE28E0", Offset = "0x3BE1CE0", VA = "0x183BE28E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public const int ENLOLFFJKLC = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<TKey, LinkedListNode<CJMBEGFHACB>> OBCPCCPHEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LinkedList<CJMBEGFHACB> KFMMINACGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly ACBHGHFIDEK? LKOENJCIGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly TimeSpan LEDCEJIEKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly NLCEFGBEGHI CAOJHLKPHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool FDKCHNGBDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<TKey> ECKAILDIENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly List<TVal> MCIDFFBEGLN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int LBMAEDLDEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7BD470", Offset = "0x7BC870", VA = "0x1807BD470")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int BHAKECDNILO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD480", Offset = "0x7BC880", VA = "0x1807BD480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xE40D50", Offset = "0xE40150", VA = "0x180E40D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5003A00", Offset = "0x5002E00", VA = "0x185003A00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int LJEEEMBOPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x37295E0", Offset = "0x37289E0", VA = "0x1837295E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> HJIKCNONOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5003BA0", Offset = "0x5002FA0", VA = "0x185003BA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.OKPHCCCHDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4FFE6B0", Offset = "0x4FFDAB0", VA = "0x184FFE6B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool DKAJDONKALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5003A60", Offset = "0x5002E60", VA = "0x185003A60", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5003BF0", Offset = "0x5002FF0", VA = "0x185003BF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4FF77C0", Offset = "0x4FF6BC0", VA = "0x184FF77C0")]
	private bool EFKGDFHJHIK(int LNJIGPAGCFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0080", Offset = "0x4FEF480", VA = "0x184FF0080")]
	private void ALMJGMCIBDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x50005C0", Offset = "0x4FFF9C0", VA = "0x1850005C0")]
	public DKDFOLFALNK(int LNJIGPAGCFO, [Optional] ACBHGHFIDEK? LKOENJCIGJH, [Optional] IEqualityComparer<TKey>? NNHMJPOJLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x50004C0", Offset = "0x4FFF8C0", VA = "0x1850004C0")]
	public DKDFOLFALNK(TimeSpan LEDCEJIEKIP, [Optional] IEqualityComparer<TKey>? NNHMJPOJLEG, [Optional] NLCEFGBEGHI? CAOJHLKPHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF700", Offset = "0x4FFEB00", VA = "0x184FFF700")]
	public DKDFOLFALNK(int LNJIGPAGCFO, TimeSpan LEDCEJIEKIP, [Optional] IEqualityComparer<TKey>? NNHMJPOJLEG, [Optional] NLCEFGBEGHI? CAOJHLKPHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x50014C0", Offset = "0x50008C0", VA = "0x1850014C0")]
	public DKDFOLFALNK(int LNJIGPAGCFO, ACBHGHFIDEK? LKOENJCIGJH, TimeSpan LEDCEJIEKIP, [Optional] IEqualityComparer<TKey>? NNHMJPOJLEG, [Optional] NLCEFGBEGHI? CAOJHLKPHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8320", Offset = "0x4FF7720", VA = "0x184FF8320", Slot = "21")]
	public bool JFAFBCKDKDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7680", Offset = "0x4FF6A80", VA = "0x184FF7680", Slot = "22")]
	public bool DMMCNJNLPIH(int HFPFBPPBALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4FF36A0", Offset = "0x4FF2AA0", VA = "0x184FF36A0")]
	private bool CJNBOLFDBMB(int HFPFBPPBALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7CE0", Offset = "0x4FF70E0", VA = "0x184FF7CE0")]
	public void ENHGLNPEFHG(TKey GPGELODKPOB, TVal ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0730", Offset = "0x4FEFB30", VA = "0x184FF0730", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IEEBNOOJIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1550", Offset = "0x4FF0950", VA = "0x184FF1550", Slot = "9")]
	public void Add(TKey GPGELODKPOB, TVal ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4000", Offset = "0x4FF3400", VA = "0x184FF4000", Slot = "8")]
	public bool ContainsKey(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4FFDC30", Offset = "0x4FFD030", VA = "0x184FFDC30", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD580", Offset = "0x4FFC980", VA = "0x184FFD580", Slot = "10")]
	public bool Remove(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE1B0", Offset = "0x4FFD5B0", VA = "0x184FFE1B0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> IEEBNOOJIPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB7A0", Offset = "0x4FFABA0", VA = "0x184FFB7A0")]
	private bool NAILPGCJOGE(TKey GPGELODKPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8D70", Offset = "0x4FF8170", VA = "0x184FF8D70")]
	private TVal JJNOBLLAEFC(TKey FMMIOOAOPHB)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF390", Offset = "0x4FFE790", VA = "0x184FFF390", Slot = "11")]
	public bool TryGetValue(TKey FMMIOOAOPHB, [Out] TVal ANJCCKHBJJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3E00", Offset = "0x4FF3200", VA = "0x184FF3E00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4FF4780", Offset = "0x4FF3B80", VA = "0x184FF4780", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] MGNOJHKHDPK, int PNCNANACKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC680", Offset = "0x4FFBA80", VA = "0x184FFC680")]
	private bool OMAAJBFEBEA(CJMBEGFHACB CKIPCDOIDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE740", Offset = "0x4FEDB40", VA = "0x184FEE740")]
	private void ADHJNAPDAHH(LinkedListNode<CJMBEGFHACB> AGOPAHOOOOE, TVal IDOIAPJOEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x4FF9690", Offset = "0x4FF8A90", VA = "0x184FF9690")]
	private void KLFCHEOKNCD(TKey GPGELODKPOB, TVal ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4FF28A0", Offset = "0x4FF1CA0", VA = "0x184FF28A0")]
	private void CFEOODMPAMJ(CJMBEGFHACB CKIPCDOIDPD, TVal IDOIAPJOEJP, int CMNNOIEHNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8050", Offset = "0x4FF7450", VA = "0x184FF8050", Slot = "19")]
	[IteratorStateMachine(typeof(DKDFOLFALNK<, >.LNKDAEDKDBP))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4FFE6E0", Offset = "0x4FFDAE0", VA = "0x184FFE6E0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NBGFBJABEBO<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class EMMEHKCILLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NBGFBJABEBO<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public EMMEHKCILLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x32C27E0", Offset = "0x32C1BE0", VA = "0x1832C27E0")]
		internal Task<TResource> MCIBAJBJBEI(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct FJDOLBNFJIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3640AB0", Offset = "0x363FEB0", VA = "0x183640AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3641410", Offset = "0x3640810", VA = "0x183641410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct INFABMPGKFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Action<TResource> cleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x383C2B0", Offset = "0x383B6B0", VA = "0x18383C2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x383C570", Offset = "0x383B970", VA = "0x18383C570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly PCPIKOHKMKL<TId, Task<TResource>> MLFAAGPLAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> MGPBFPDNNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? CIJLDBPOELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Action<TResource>? JIHBIKOAEAJ;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3E870D0", Offset = "0x3E864D0", VA = "0x183E870D0")]
	public NBGFBJABEBO(int CKBMCCEJOMK = 0, [Optional] IEqualityComparer<TId>? MMNAABNDJJL, [Optional] Func<TId, CancellationToken, Task<TResource>>? FLDPDFGADFA, [Optional] Action<TResource>? JLKMLGECOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3E86850", Offset = "0x3E85C50", VA = "0x183E86850")]
	public NJKEHFGOEOH<Task<TResource>> LOFIHHKAGED(TId FNOGEAGAPLC, [Optional] Func<TId, CancellationToken, Task<TResource>>? FLDPDFGADFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3E86DF0", Offset = "0x3E861F0", VA = "0x183E86DF0")]
	private void OFLEEECIJLD(Task<TResource> CMOICIKGDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3E86BA0", Offset = "0x3E85FA0", VA = "0x183E86BA0")]
	public void NEEHPPMEFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3E865B0", Offset = "0x3E859B0", VA = "0x183E865B0")]
	public PCPIKOHKMKL<TId, Task<TResource>>.IBAOBDPOBMF JLFJDPHFECC()
	{
		return default(PCPIKOHKMKL<TId, Task<TResource>>.IBAOBDPOBMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3E86F00", Offset = "0x3E86300", VA = "0x183E86F00", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3E86F00", Offset = "0x3E86300", VA = "0x183E86F00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3E85FB0", Offset = "0x3E853B0", VA = "0x183E85FB0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(NBGFBJABEBO<, >.FJDOLBNFJIN))]
	internal static Task FKHIJKHMGPL(Task<TResource> CMOICIKGDPA, CancellationTokenSource CKDONFENBBD, Dictionary<Task<TResource>, CancellationTokenSource> EELPCOLAGHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3E86210", Offset = "0x3E85610", VA = "0x183E86210")]
	[AsyncStateMachine(typeof(NBGFBJABEBO<, >.INFABMPGKFI))]
	[CompilerGenerated]
	internal static Task JFGEIEMAAMA(Task<TResource> CMOICIKGDPA, Action<TResource> CFFDHAMEFLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class PCPIKOHKMKL<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class NPPOPKLACCA : IEquatable<NPPOPKLACCA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly TValue BDGBGLMDOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int NJGIJFBFLKI;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1BA5E60", Offset = "0x1BA5260", VA = "0x181BA5E60")]
		public NPPOPKLACCA(TValue ANJCCKHBJJO, int OPGFPCMFNDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3F0FE30", Offset = "0x3F0F230", VA = "0x183F0FE30", Slot = "4")]
		public bool Equals(NPPOPKLACCA? KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3F0FD90", Offset = "0x3F0F190", VA = "0x183F0FD90", Slot = "0")]
		public override bool Equals(object? BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3F0FF50", Offset = "0x3F0F350", VA = "0x183F0FF50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct IBAOBDPOBMF : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Dictionary<TKey, NPPOPKLACCA>.Enumerator KOCNHIMDPNE;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3813BA0", Offset = "0x3812FA0", VA = "0x183813BA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3813FE0", Offset = "0x38133E0", VA = "0x183813FE0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3813F20", Offset = "0x3813320", VA = "0x183813F20")]
		public IBAOBDPOBMF(PCPIKOHKMKL<TKey, TValue> LGLDLFPPHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3813890", Offset = "0x3812C90", VA = "0x183813890", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3813950", Offset = "0x3812D50", VA = "0x183813950", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3813A40", Offset = "0x3812E40", VA = "0x183813A40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class ODLOPGLIGLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public PCPIKOHKMKL<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public NPPOPKLACCA refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public ODLOPGLIGLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3FCE8B0", Offset = "0x3FCDCB0", VA = "0x183FCE8B0")]
		internal void MCIBAJBJBEI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<TKey, NPPOPKLACCA> DFKINKEKMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Func<TKey, TValue>? KOLJMPNOMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly Action<TValue>? KKODKBEJEBI;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4087440", Offset = "0x4086840", VA = "0x184087440")]
	public PCPIKOHKMKL(int CKBMCCEJOMK = 0, [Optional] IEqualityComparer<TKey>? NNHMJPOJLEG, [Optional] Func<TKey, TValue>? GMKDFOAACMN, [Optional] Action<TValue>? GGEIMJFKJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4086440", Offset = "0x4085840", VA = "0x184086440")]
	public NJKEHFGOEOH<TValue> LOFIHHKAGED(TKey GPGELODKPOB, [Optional] Func<TKey, TValue>? CAAMJBFDNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4086280", Offset = "0x4085680", VA = "0x184086280")]
	private void JGNAPAAMDNO(TKey GPGELODKPOB, NPPOPKLACCA HGECAIKAKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4087090", Offset = "0x4086490", VA = "0x184087090")]
	public void NEEHPPMEFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4086400", Offset = "0x4085800", VA = "0x184086400")]
	public IBAOBDPOBMF JLFJDPHFECC()
	{
		return default(IBAOBDPOBMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x40873A0", Offset = "0x40867A0", VA = "0x1840873A0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x40873A0", Offset = "0x40867A0", VA = "0x1840873A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
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
