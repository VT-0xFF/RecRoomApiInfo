using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F06B40", Offset = "0x7F05940", VA = "0x187F06B40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GIJKHGBDFAK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected GIJKHGBDFAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class JDDJCBHKLNO<T> : GIJKHGBDFAK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct KLCBNNAAFID
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum GDDEMMILCNF
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
		public GDDEMMILCNF AAFMBEEMJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T CFDGGKIIHOI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int FBGOIINLILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool GEBLBONJJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool BOPDGACMGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? AMBEIOJJCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<KLCBNNAAFID>? MEJOMBJKJJA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EJADEBNBMCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4F70020", Offset = "0x4F6EE20", VA = "0x184F70020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4F70080", Offset = "0x4F6EE80", VA = "0x184F70080")]
	protected JDDJCBHKLNO(bool BOPDGACMGHH, bool GEBLBONJJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FA20", Offset = "0x4F6E820", VA = "0x184F6FA20")]
	protected bool CDDCBLJLNJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FAC0", Offset = "0x4F6E8C0", VA = "0x184F6FAC0")]
	protected void DKDJBGHHHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FDB0", Offset = "0x4F6EBB0", VA = "0x184F6FDB0")]
	protected void LOJDLEHMPPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB240", Offset = "0x3BAA040", VA = "0x183BAB240")]
	private static void AAJCNPJPHMH<U>(List<U>? COKPAJOONAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4F6F660", Offset = "0x4F6E460", VA = "0x184F6F660", Slot = "4")]
	public void AIKICPLLADB(T CFDGGKIIHOI, bool NIAAGJMEOJD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4F6FBE0", Offset = "0x4F6E9E0", VA = "0x184F6FBE0", Slot = "5")]
	public void FKCGDELNEED(T CFDGGKIIHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4F6F870", Offset = "0x4F6E670", VA = "0x184F6F870")]
	public void CCLJDABAPHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LLEAAEBCCKF : JDDJCBHKLNO<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F05AE0", Offset = "0x7F048E0", VA = "0x187F05AE0")]
	public LLEAAEBCCKF(bool BOPDGACMGHH = false, bool GEBLBONJJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F05880", Offset = "0x7F04680", VA = "0x187F05880")]
	public void HDKOJPGLKCE()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F05A80", Offset = "0x7F04880", VA = "0x187F05A80")]
	public static LLEAAEBCCKF IMOCCLOLMAG(LLEAAEBCCKF DGKLJAAOIJM, Action CFDGGKIIHOI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F05820", Offset = "0x7F04620", VA = "0x187F05820")]
	public static LLEAAEBCCKF CCBFCPLHMMI(LLEAAEBCCKF DGKLJAAOIJM, Action CFDGGKIIHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KAOANOLMBEI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIKICPLLADB(Action<T> CFDGGKIIHOI, bool NIAAGJMEOJD = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKCGDELNEED(Action<T> CFDGGKIIHOI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class IMAAKJGDPMH<T> : JDDJCBHKLNO<Action<T>>, KAOANOLMBEI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45D9DD0", Offset = "0x45D8BD0", VA = "0x1845D9DD0")]
	public IMAAKJGDPMH(bool BOPDGACMGHH = false, bool GEBLBONJJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D4D6B0", Offset = "0x4D4C4B0", VA = "0x184D4D6B0")]
	public void HDKOJPGLKCE(T JIJABGNNHPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E070", Offset = "0x4D4CE70", VA = "0x184D4E070")]
	public static IMAAKJGDPMH<T> IMOCCLOLMAG(IMAAKJGDPMH<T> DGKLJAAOIJM, Action<T> CFDGGKIIHOI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D4B760", Offset = "0x4D4A560", VA = "0x184D4B760")]
	public static IMAAKJGDPMH<T> CCBFCPLHMMI(IMAAKJGDPMH<T> DGKLJAAOIJM, Action<T> CFDGGKIIHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BMBFOKPPNEL<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIKICPLLADB(Action<T, U> CFDGGKIIHOI, bool NIAAGJMEOJD = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKCGDELNEED(Action<T, U> CFDGGKIIHOI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class DPJKFCBILHL<T, U> : JDDJCBHKLNO<Action<T, U>>, BMBFOKPPNEL<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x45D9DD0", Offset = "0x45D8BD0", VA = "0x1845D9DD0")]
	public DPJKFCBILHL(bool BOPDGACMGHH = false, bool GEBLBONJJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B366B0", Offset = "0x6B354B0", VA = "0x186B366B0")]
	public void HDKOJPGLKCE(T JIJABGNNHPJ, U FCCPCHEBIGA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E070", Offset = "0x4D4CE70", VA = "0x184D4E070")]
	public static DPJKFCBILHL<T, U> IMOCCLOLMAG(DPJKFCBILHL<T, U> DGKLJAAOIJM, Action<T, U> CFDGGKIIHOI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D4B760", Offset = "0x4D4A560", VA = "0x184D4B760")]
	public static DPJKFCBILHL<T, U> CCBFCPLHMMI(DPJKFCBILHL<T, U> DGKLJAAOIJM, Action<T, U> CFDGGKIIHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class NAHDPOOOHFB<T, U, V> : JDDJCBHKLNO<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x45D9DD0", Offset = "0x45D8BD0", VA = "0x1845D9DD0")]
	public NAHDPOOOHFB(bool BOPDGACMGHH = false, bool GEBLBONJJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5429A40", Offset = "0x5428840", VA = "0x185429A40")]
	public void HDKOJPGLKCE(T JIJABGNNHPJ, U FCCPCHEBIGA, V LCFJFNFOMKB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E070", Offset = "0x4D4CE70", VA = "0x184D4E070")]
	public static NAHDPOOOHFB<T, U, V> IMOCCLOLMAG(NAHDPOOOHFB<T, U, V> DGKLJAAOIJM, Action<T, U, V> CFDGGKIIHOI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4D4B760", Offset = "0x4D4A560", VA = "0x184D4B760")]
	public static NAHDPOOOHFB<T, U, V> CCBFCPLHMMI(NAHDPOOOHFB<T, U, V> DGKLJAAOIJM, Action<T, U, V> CFDGGKIIHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HJMEHCBHHNG<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class NLJFNNDJHCI<T, U, V, W> : JDDJCBHKLNO<Action<T, U, V, W>>, HJMEHCBHHNG<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x45D9DD0", Offset = "0x45D8BD0", VA = "0x1845D9DD0")]
	public NLJFNNDJHCI(bool BOPDGACMGHH = false, bool GEBLBONJJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x54D19B0", Offset = "0x54D07B0", VA = "0x1854D19B0")]
	public void HDKOJPGLKCE(T JIJABGNNHPJ, U FCCPCHEBIGA, V LCFJFNFOMKB, W OHGAFHDMJBG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E070", Offset = "0x4D4CE70", VA = "0x184D4E070")]
	public static NLJFNNDJHCI<T, U, V, W> IMOCCLOLMAG(NLJFNNDJHCI<T, U, V, W> DGKLJAAOIJM, Action<T, U, V, W> CFDGGKIIHOI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4D4B760", Offset = "0x4D4A560", VA = "0x184D4B760")]
	public static NLJFNNDJHCI<T, U, V, W> CCBFCPLHMMI(NLJFNNDJHCI<T, U, V, W> DGKLJAAOIJM, Action<T, U, V, W> CFDGGKIIHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LGFLMNBMOKF<T, U, V, W, X> : JDDJCBHKLNO<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x45D9DD0", Offset = "0x45D8BD0", VA = "0x1845D9DD0")]
	public LGFLMNBMOKF(bool BOPDGACMGHH = false, bool GEBLBONJJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x515FBB0", Offset = "0x515E9B0", VA = "0x18515FBB0")]
	public void HDKOJPGLKCE(T JIJABGNNHPJ, U FCCPCHEBIGA, V LCFJFNFOMKB, W OHGAFHDMJBG, X AJEEBBBAOKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E070", Offset = "0x4D4CE70", VA = "0x184D4E070")]
	public static LGFLMNBMOKF<T, U, V, W, X> IMOCCLOLMAG(LGFLMNBMOKF<T, U, V, W, X> DGKLJAAOIJM, Action<T, U, V, W, X> CFDGGKIIHOI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4D4B760", Offset = "0x4D4A560", VA = "0x184D4B760")]
	public static LGFLMNBMOKF<T, U, V, W, X> CCBFCPLHMMI(LGFLMNBMOKF<T, U, V, W, X> DGKLJAAOIJM, Action<T, U, V, W, X> CFDGGKIIHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class POACCPFALNN<T, U, V, W, X, Y> : JDDJCBHKLNO<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x45D9DD0", Offset = "0x45D8BD0", VA = "0x1845D9DD0")]
	public POACCPFALNN(bool BOPDGACMGHH = false, bool GEBLBONJJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x57BA190", Offset = "0x57B8F90", VA = "0x1857BA190")]
	public void HDKOJPGLKCE(T JIJABGNNHPJ, U FCCPCHEBIGA, V LCFJFNFOMKB, W OHGAFHDMJBG, X AJEEBBBAOKG, Y GJPKMHAOJHB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D4E070", Offset = "0x4D4CE70", VA = "0x184D4E070")]
	public static POACCPFALNN<T, U, V, W, X, Y> IMOCCLOLMAG(POACCPFALNN<T, U, V, W, X, Y> DGKLJAAOIJM, Action<T, U, V, W, X, Y> CFDGGKIIHOI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D4B760", Offset = "0x4D4A560", VA = "0x184D4B760")]
	public static POACCPFALNN<T, U, V, W, X, Y> CCBFCPLHMMI(POACCPFALNN<T, U, V, W, X, Y> DGKLJAAOIJM, Action<T, U, V, W, X, Y> CFDGGKIIHOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IILFGHKPAPA<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NDJENDDAKLA<TKey, TVal> OHGLIIPJGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> JMHAMBDICKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NDJENDDAKLA<TKey, TVal>.GNJCMOGDOOG? NAMLOPMJFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int BDLDBJNJKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NDJENDDAKLA<TKey, TVal>.LGEGMKICFID? OBDGHAHLKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int DDJFFBMKKHE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int HMHHOHIMAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4D3DCA0", Offset = "0x4D3CAA0", VA = "0x184D3DCA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HFLLAFNJABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D3DCF0", Offset = "0x4D3CAF0", VA = "0x184D3DCF0")]
	public IILFGHKPAPA(int BDLDBJNJKHB, [Optional] NDJENDDAKLA<TKey, TVal>.LGEGMKICFID? OBDGHAHLKGB, [Optional] IEqualityComparer<TKey>? DLFJGFJJMCP, [Optional] NDJENDDAKLA<TKey, TVal>.GNJCMOGDOOG? NAMLOPMJFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4D3CEF0", Offset = "0x4D3BCF0", VA = "0x184D3CEF0")]
	public void CHLNGPEGKIN(TKey MAKJJJECHHB, TVal OAIIHELJHLG, bool COGFOFMCHJP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D3CD90", Offset = "0x4D3BB90", VA = "0x184D3CD90")]
	public bool CHBHGCDANBP(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D3D260", Offset = "0x4D3C060", VA = "0x184D3D260")]
	public bool GNFCCDJDLII(TKey PACALLJHMNM, [Out] TVal OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D3D360", Offset = "0x4D3C160", VA = "0x184D3D360")]
	private void KCCMMEJHHDC(TKey MAKJJJECHHB, TVal OAIIHELJHLG, int ACINDEOBNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D3CA00", Offset = "0x4D3B800", VA = "0x184D3CA00")]
	public bool ACAAFGKFOBK(TKey MAKJJJECHHB, TVal OAIIHELJHLG, bool COGFOFMCHJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D3CBB0", Offset = "0x4D3B9B0", VA = "0x184D3CBB0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D3D620", Offset = "0x4D3C420", VA = "0x184D3D620")]
	private void MELKNKEGGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4D3D120", Offset = "0x4D3BF20", VA = "0x184D3D120")]
	private bool DKJOJILBKMH(TKey MAKJJJECHHB, FNDCLKENOOB KLOPBEMIGAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4D3DB80", Offset = "0x4D3C980", VA = "0x184D3DB80")]
	private void MHIAOCGHCBD(TKey MAKJJJECHHB, TVal OAIIHELJHLG, FNDCLKENOOB KLOPBEMIGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D3CC60", Offset = "0x4D3BA60", VA = "0x184D3CC60")]
	private void CEJCBNPJPGA(TKey MAKJJJECHHB, TVal AFBDJBIOHNP, FNDCLKENOOB KLOPBEMIGAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KJMIGJPDIEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action OMHEKKOGFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool DLKPKDCCEFD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public KJMIGJPDIEG(Action JDNGNIOHEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F05670", Offset = "0x7F04470", VA = "0x187F05670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x371BB90", Offset = "0x371A990", VA = "0x18371BB90")]
	public static MMLLOANHJIJ<T> BHEMCOAOOEF<T>(T OAIIHELJHLG, Action JDNGNIOHEPB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class MMLLOANHJIJ<T> : KJMIGJPDIEG where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x53D6AF0", Offset = "0x53D58F0", VA = "0x1853D6AF0")]
	public MMLLOANHJIJ(T OAIIHELJHLG, Action JDNGNIOHEPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class DLPMDCLAJGO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DMHOOEKHDDP<T>? DEEDLCKILPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> KPPJKOJBFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool DLKPKDCCEFD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DLPMDCLAJGO<T> LJAJAMKHAJN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> AGKDCDKFGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6B233B0", Offset = "0x6B221B0", VA = "0x186B233B0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6B23080", Offset = "0x6B21E80", VA = "0x186B23080")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DAEKNHIBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6B23570", Offset = "0x6B22370", VA = "0x186B23570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6B23F90", Offset = "0x6B22D90", VA = "0x186B23F90")]
	public DLPMDCLAJGO(DMHOOEKHDDP<T> DGAAJGABFAO, DMHOOEKHDDP<T> PKEPJLCIINJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B23780", Offset = "0x6B22580", VA = "0x186B23780")]
	public DLPMDCLAJGO(DMHOOEKHDDP<T> DGAAJGABFAO, int AJOJFAFFHHF, DMHOOEKHDDP<T> PKEPJLCIINJ, int PBECAFEFCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B23B30", Offset = "0x6B22930", VA = "0x186B23B30")]
	private DLPMDCLAJGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B23200", Offset = "0x6B22000", VA = "0x186B23200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6B22F20", Offset = "0x6B21D20", VA = "0x186B22F20")]
	public T[] ABDKJFIDJKI()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6B23290", Offset = "0x6B22090", VA = "0x186B23290")]
	public static ReadOnlySequence<T> HEKJAOMNHLJ(DLPMDCLAJGO<T>? ABOPFECFFGC)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct EKFLBFBLJAN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable MBFONMAHDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T COJGBJGNJFM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x460E870", Offset = "0x460D670", VA = "0x18460E870")]
	public EKFLBFBLJAN(IDisposable EALBMDJEHIA, [In] T OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3A74BC0", Offset = "0x3A739C0", VA = "0x183A74BC0")]
	public static EKFLBFBLJAN<U> LGJIFBLOEDF<U>([In] EKFLBFBLJAN<T> EALBMDJEHIA, [In] U OAIIHELJHLG) where U : notnull
	{
		return default(EKFLBFBLJAN<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x460E6F0", Offset = "0x460D4F0", VA = "0x18460E6F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HGCKDFDKFOD
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x391D260", Offset = "0x391C060", VA = "0x18391D260")]
	public static EKFLBFBLJAN<T> NBEICDCLFEE<T>(IDisposable EALBMDJEHIA, [In] T OAIIHELJHLG) where T : notnull
	{
		return default(EKFLBFBLJAN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x391D200", Offset = "0x391C000", VA = "0x18391D200")]
	public static EKFLBFBLJAN<T> MCAOKIJGDCB<T>([In] this EKFLBFBLJAN<T> FPFHIDBMBMI, [Out] T OAIIHELJHLG) where T : notnull
	{
		return default(EKFLBFBLJAN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x36A7810", Offset = "0x36A6610", VA = "0x1836A7810")]
	public static EKFLBFBLJAN<U?> LGJIFBLOEDF<U, T>([In] EKFLBFBLJAN<T> EEDKDLDCPFE, [In] U OAIIHELJHLG)
	{
		return default(EKFLBFBLJAN<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct KPBNFJAGDEP : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct HDLIHKIDIKG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
		public static HDLIHKIDIKG NBEICDCLFEE()
		{
			return default(HDLIHKIDIKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F056B0", Offset = "0x7F044B0", VA = "0x187F056B0")]
	public static string LPPKAPLPMBE(Type AAFMBEEMJAC, [Optional] string? NFMKJBCKLDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x39E24F0", Offset = "0x39E12F0", VA = "0x1839E24F0")]
	public static string? LPPKAPLPMBE<T>([Optional] string? NFMKJBCKLDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x39E2570", Offset = "0x39E1370", VA = "0x1839E2570")]
	public static string? NFNHPEFHEJC<T>([Optional] string? DHFFOOBGOPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	public static KPBNFJAGDEP CAOJKMJCLDE(string NFMKJBCKLDM, string? DHFFOOBGOPC)
	{
		return default(KPBNFJAGDEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FIBJHCAOCDK
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool LGBOLNPCOHN(string JAJPEAMFGKA, FIBJHCAOCDK IFFMPGGKPNP);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EPDECKNMHBE<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EPDECKNMHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4614FD0", Offset = "0x4613DD0", VA = "0x184614FD0")]
		internal void CEMCPJODBFG(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int JMDMECFGMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string BGKGIIPFPBO;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F04480", Offset = "0x7F03280", VA = "0x187F04480")]
	public static Dictionary<string, FIBJHCAOCDK> JKBCLJBAGNH(Type KHGGMDCPNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38E66A0", Offset = "0x38E54A0", VA = "0x1838E66A0")]
	public static Dictionary<string, FIBJHCAOCDK> JKBCLJBAGNH<T>(Type KHGGMDCPNJJ, IReadOnlyDictionary<T, string> KGOKGOOFAJC) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x38E6EE0", Offset = "0x38E5CE0", VA = "0x1838E6EE0")]
	public static Dictionary<string, FIBJHCAOCDK> MBBOJKCKFJK<T>(List<T> POLFGAMGJOM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F040C0", Offset = "0x7F02EC0", VA = "0x187F040C0")]
	public static Dictionary<string, FIBJHCAOCDK> IBPDEBMLDLO(Type KHGGMDCPNJJ, LGBOLNPCOHN JOJMCOGGDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F03F00", Offset = "0x7F02D00", VA = "0x187F03F00")]
	public static Dictionary<int, string> BBIJMIANDHF(Dictionary<string, FIBJHCAOCDK> EEDJPELJDDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class DDPPOHMMKFK : LPPJEHMJDEA
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool LLNOAAFPFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? PCOLIAOAKJO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual LPPJEHMJDEA? DKBLDDPPINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F03B90", Offset = "0x7F02990", VA = "0x187F03B90")]
	protected DDPPOHMMKFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string EEHOEKHGKPK();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F036E0", Offset = "0x7F024E0", VA = "0x187F036E0", Slot = "8")]
	public virtual string JJFFIJLIMEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F038E0", Offset = "0x7F026E0", VA = "0x187F038E0", Slot = "9")]
	public void OOPHJAMADDM(StringBuilder KHOLMDNEKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F03760", Offset = "0x7F02560", VA = "0x187F03760", Slot = "10")]
	public void MMAFBPNLKDB(StringBuilder KHOLMDNEKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F037C0", Offset = "0x7F025C0", VA = "0x187F037C0", Slot = "11")]
	public void OLOENDDMJKL(StringBuilder KHOLMDNEKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F03580", Offset = "0x7F02380", VA = "0x187F03580", Slot = "12")]
	public void FGOLKCJIJBH(StringBuilder KHOLMDNEKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F034E0", Offset = "0x7F022E0", VA = "0x187F034E0")]
	public static void CJNFGMNNPIH(StringBuilder KHOLMDNEKOP, string GINDFOHMNIK, string CEILODFHPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E67AA0", Offset = "0x6E668A0", VA = "0x186E67AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CGKENJGHBHH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F033A0", Offset = "0x7F021A0", VA = "0x187F033A0")]
	public CGKENJGHBHH(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MEBHIMPAAPJ<TErr> : CGKENJGHBHH where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr MCEKDIJOCMH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x53B19D0", Offset = "0x53B07D0", VA = "0x1853B19D0")]
	private MEBHIMPAAPJ([In] TErr NJOJLCMMPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x53B1900", Offset = "0x53B0700", VA = "0x1853B1900")]
	public static MEBHIMPAAPJ<TErr> NBEICDCLFEE([In] TErr NJOJLCMMPDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HACBMLIPDAM : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm MOEPBDAEPHH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool HJDLFLLPBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool ILCBFNIBOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool NLHLPIKDJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F051E0", Offset = "0x7F03FE0", VA = "0x187F051E0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long HKMBNCFKKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F05250", Offset = "0x7F04050", VA = "0x187F05250", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F052C0", Offset = "0x7F040C0", VA = "0x187F052C0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7F05170", Offset = "0x7F03F70", VA = "0x187F05170")]
	public HACBMLIPDAM(HashAlgorithm MOEPBDAEPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7F04F90", Offset = "0x7F03D90", VA = "0x187F04F90", Slot = "35")]
	public override int Read(byte[] GLBDCBGACGO, int PPPFIBNDOMK, int ALFGNAHPKIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7F05140", Offset = "0x7F03F40", VA = "0x187F05140", Slot = "38")]
	public override void Write(byte[] GLBDCBGACGO, int PPPFIBNDOMK, int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7F05030", Offset = "0x7F03E30", VA = "0x187F05030", Slot = "33")]
	public override long Seek(long PPPFIBNDOMK, SeekOrigin NECPJOOPKDH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F050C0", Offset = "0x7F03EC0", VA = "0x187F050C0", Slot = "34")]
	public override void SetLength(long OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F04EB0", Offset = "0x7F03CB0", VA = "0x187F04EB0")]
	public byte[] FPLNJDHGCMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LPPJEHMJDEA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JJFFIJLIMEE();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EEHOEKHGKPK();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface NCACABFENMC<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface EKPBKPCNNBH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string MGLEIHKPELI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DMHOOEKHDDP<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static DMHOOEKHDDP<T>? JOHNDGLCOHC;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object NDFEHKKJNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? DKLNOLOCBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool DLKPKDCCEFD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool PIFBNBODPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xDA8E40", Offset = "0xDA7C40", VA = "0x180DA8E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EED0", Offset = "0x6B2DCD0", VA = "0x186B2EED0")]
	private static DMHOOEKHDDP<T> DMJNMMNHFMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E910", Offset = "0x6B2D710", VA = "0x186B2E910")]
	private static void CGBNFLBBEAE(DMHOOEKHDDP<T> JLICNKNOLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F990", Offset = "0x4C8E790", VA = "0x184C8F990")]
	private DMHOOEKHDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E740", Offset = "0x6B2D540", VA = "0x186B2E740")]
	public static DMHOOEKHDDP<T> BHEMCOAOOEF(ReadOnlyMemory<T> OJGHKHPIHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E360", Offset = "0x6B2D160", VA = "0x186B2E360")]
	public static DMHOOEKHDDP<T> BHEMCOAOOEF(IMemoryOwner<T> JDCEBKJEOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FCF0", Offset = "0x6B2EAF0", VA = "0x186B2FCF0")]
	public static void NFPNKJJMNIP(DMHOOEKHDDP<T> DGAAJGABFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F610", Offset = "0x6B2E410", VA = "0x186B2F610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F890", Offset = "0x6B2E690", VA = "0x186B2F890")]
	public DMHOOEKHDDP<T> FHLMBJOLLCJ(IMemoryOwner<T> JDCEBKJEOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FAF0", Offset = "0x6B2E8F0", VA = "0x186B2FAF0")]
	private void LOLHCACAPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F9A0", Offset = "0x6B2E7A0", VA = "0x186B2F9A0")]
	private DMHOOEKHDDP<T> JFHPLCIHIED(DMHOOEKHDDP<T> JLICNKNOLBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HMMPJCHDAEA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7F053F0", Offset = "0x7F041F0", VA = "0x187F053F0")]
	public HMMPJCHDAEA(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FEAOBBMIOHL<TOk> : HMMPJCHDAEA where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk LCDCIGKFNNB;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4A4DEA0", Offset = "0x4A4CCA0", VA = "0x184A4DEA0")]
	private FEAOBBMIOHL([In] TOk LHCNBKKOMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4A4DDD0", Offset = "0x4A4CBD0", VA = "0x184A4DDD0")]
	public static FEAOBBMIOHL<TOk> NBEICDCLFEE([In] TOk LHCNBKKOMAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct JKEBLLKKBOM<TOk, TErr> : IEquatable<JKEBLLKKBOM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> EKKGPBLMLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr MCEKDIJOCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk LCDCIGKFNNB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool AFNEGMNDKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4FC83D0", Offset = "0x4FC71D0", VA = "0x184FC83D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DJHDOEBBKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4FC6590", Offset = "0x4FC5390", VA = "0x184FC6590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4FCC040", Offset = "0x4FCAE40", VA = "0x184FCC040")]
	internal JKEBLLKKBOM([In] TErr NJOJLCMMPDO, [In] TOk LHCNBKKOMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4FC2740", Offset = "0x4FC1540", VA = "0x184FC2740")]
	public static JKEBLLKKBOM<TOk, TErr> DHOLDLDOKFH([In] TErr NJOJLCMMPDO)
	{
		return default(JKEBLLKKBOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4FC5B90", Offset = "0x4FC4990", VA = "0x184FC5B90")]
	public static JKEBLLKKBOM<TOk, TErr> MFHIFDHAICF([In] TOk LHCNBKKOMAK)
	{
		return default(JKEBLLKKBOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE590", Offset = "0x3BAD390", VA = "0x183BAE590")]
	public JKEBLLKKBOM<TOk?, UErr?> KCPCBMLMLIO<UErr>()
	{
		return default(JKEBLLKKBOM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE470", Offset = "0x3BAD270", VA = "0x183BAE470")]
	public JKEBLLKKBOM<UOk?, TErr?> FHCGAOFNGEB<UOk>()
	{
		return default(JKEBLLKKBOM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFF00", Offset = "0x3BAED00", VA = "0x183BAFF00")]
	public JKEBLLKKBOM<UOk?, TErr?> LDFICHNBKMF<UOk>()
	{
		return default(JKEBLLKKBOM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3BAED10", Offset = "0x3BADB10", VA = "0x183BAED10")]
	public JKEBLLKKBOM<TOk?, UErr?> KNHDEDJPNKE<UErr>()
	{
		return default(JKEBLLKKBOM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4FC6100", Offset = "0x4FC4F00", VA = "0x184FC6100")]
	public JKEBLLKKBOM<NICNPLCGCEF, TErr> MLFGDJBGFIN()
	{
		return default(JKEBLLKKBOM<NICNPLCGCEF, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4FC7A70", Offset = "0x4FC6870", VA = "0x184FC7A70")]
	public static bool PBEBFPKJKLO([In] JKEBLLKKBOM<TOk, TErr> EFOOGHNHGNH, [In] JKEBLLKKBOM<TOk, TErr> IFJAPBHAPEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4FC3420", Offset = "0x4FC2220", VA = "0x184FC3420", Slot = "4")]
	public bool Equals(JKEBLLKKBOM<TOk, TErr> HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4FC37F0", Offset = "0x4FC25F0", VA = "0x184FC37F0", Slot = "0")]
	public override bool Equals(object HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4FC4910", Offset = "0x4FC3710", VA = "0x184FC4910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4FC8A60", Offset = "0x4FC7860", VA = "0x184FC8A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FEHJEJLIHPO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct JNONJAOOEFB<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<JKEBLLKKBOM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<JKEBLLKKBOM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4FD6520", Offset = "0x4FD5320", VA = "0x184FD6520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4FD6E80", Offset = "0x4FD5C80", VA = "0x184FD6E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x38E30A0", Offset = "0x38E1EA0", VA = "0x1838E30A0")]
	public static JKEBLLKKBOM<TOk?, TErr?> LCDCIGKFNNB<TOk, TErr>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [In] TOk LHCNBKKOMAK)
	{
		return default(JKEBLLKKBOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x38E30F0", Offset = "0x38E1EF0", VA = "0x1838E30F0")]
	public static JKEBLLKKBOM<NICNPLCGCEF, TErr?> LCDCIGKFNNB<TErr>([In] this JKEBLLKKBOM<NICNPLCGCEF, TErr> FPFHIDBMBMI)
	{
		return default(JKEBLLKKBOM<NICNPLCGCEF, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x38E30A0", Offset = "0x38E1EA0", VA = "0x1838E30A0")]
	public static JKEBLLKKBOM<TOk?, TErr?> MCEKDIJOCMH<TOk, TErr>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [In] TErr NJOJLCMMPDO)
	{
		return default(JKEBLLKKBOM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x38E35C0", Offset = "0x38E23C0", VA = "0x1838E35C0")]
	public static TOk? PHGOMIMJAAH<TOk, TErr>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x38DFC80", Offset = "0x38DEA80", VA = "0x1838DFC80")]
	[AsyncStateMachine(typeof(JNONJAOOEFB<, >))]
	public static Task<TOk?>? AELCMFFHIEG<TOk, TErr>(this Task<JKEBLLKKBOM<TOk, TErr>> FPFHIDBMBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x38E14C0", Offset = "0x38E02C0", VA = "0x1838E14C0")]
	public static TErr? ICLNGJIIPLD<TErr, TOk>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x38E1FF0", Offset = "0x38E0DF0", VA = "0x1838E1FF0")]
	public static bool KCNAPEODPJJ<TOk, TErr, UErr, UOk>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [Out] JKEBLLKKBOM<UOk, UErr> KCCJKKAJEBM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x38E0B70", Offset = "0x38DF970", VA = "0x1838E0B70")]
	public static bool CMFDFCOOAIJ<TOk, TErr>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [Out] TOk LHCNBKKOMAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x38E0130", Offset = "0x38DEF30", VA = "0x1838E0130")]
	public static bool BDMDIJPCFAO<TOk, TErr>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [Out][NotNullWhen(true)] TErr NJOJLCMMPDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x38E1230", Offset = "0x38E0030", VA = "0x1838E1230")]
	public static bool FHPHCBOEMNL<TOk, TErr>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [Out][NotNullWhen(true)] TOk LHCNBKKOMAK, [Out][NotNullWhen(false)] TErr NJOJLCMMPDO) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x38E3C20", Offset = "0x38E2A20", VA = "0x1838E3C20")]
	public static bool PMFIABNBDNO<TOk, TErr>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [Out][NotNullWhen(true)] TOk LHCNBKKOMAK, [Out] JKEBLLKKBOM<TOk, TErr> KCCJKKAJEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x38E1C50", Offset = "0x38E0A50", VA = "0x1838E1C50")]
	public static bool KCNAPEODPJJ<TOk, TErr, UErr, UOk>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [Out][NotNullWhen(true)] TOk LHCNBKKOMAK, [Out] JKEBLLKKBOM<UOk, UErr> KCCJKKAJEBM) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x38E0E80", Offset = "0x38DFC80", VA = "0x1838E0E80")]
	public static bool CNFCANJCLGF<TOk, TErr>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [Out][NotNullWhen(true)] TOk LHCNBKKOMAK, [Out] JKEBLLKKBOM<NICNPLCGCEF, TErr> KCCJKKAJEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x38E0270", Offset = "0x38DF070", VA = "0x1838E0270")]
	public static JKEBLLKKBOM<UOk, UErr> BOBJNDDHMDM<UOk, UErr, TOk, TErr>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, [In] JKEBLLKKBOM<UOk, UErr> AOJFFKDCAKJ) where TOk : UOk where TErr : UErr
	{
		return default(JKEBLLKKBOM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x38E18E0", Offset = "0x38E06E0", VA = "0x1838E18E0")]
	public static JKEBLLKKBOM<TOk?[]?, TErr?> JOLHGCCHDKH<TOk, TErr>(this IEnumerable<JKEBLLKKBOM<TOk, TErr>> FPFHIDBMBMI)
	{
		return default(JKEBLLKKBOM<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x38E3310", Offset = "0x38E2110", VA = "0x1838E3310")]
	public static JKEBLLKKBOM<UOk?, TErr?> LJDLCLCJELO<UOk, TErr, TOk>([In] this JKEBLLKKBOM<TOk, TErr> FPFHIDBMBMI, Func<TOk, UOk> MKOJMCHOFPC)
	{
		return default(JKEBLLKKBOM<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DJKGOGJEAPN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A71730", Offset = "0x3A70530", VA = "0x183A71730")]
	public static JKEBLLKKBOM<TOk, T> LCDCIGKFNNB<TOk>([In] TOk LHCNBKKOMAK) where TOk : notnull
	{
		return default(JKEBLLKKBOM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B17EE0", Offset = "0x6B16CE0", VA = "0x186B17EE0")]
	public static JKEBLLKKBOM<NICNPLCGCEF, T> LCDCIGKFNNB()
	{
		return default(JKEBLLKKBOM<NICNPLCGCEF, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A716A0", Offset = "0x3A704A0", VA = "0x183A716A0")]
	public static JKEBLLKKBOM<T, TErr> MCEKDIJOCMH<TErr>([In] TErr NJOJLCMMPDO) where TErr : notnull
	{
		return default(JKEBLLKKBOM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct LMBBIGPNMGL<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly LBKEIDNCKEI LJJFJAHDJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> ENDBCPPONLD;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E93DC0", Offset = "0x4E92BC0", VA = "0x184E93DC0")]
	public static LMBBIGPNMGL<TKey, TValue> NBEICDCLFEE(string JAPGNGDBBIF)
	{
		return default(LMBBIGPNMGL<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4E93EE0", Offset = "0x4E92CE0", VA = "0x184E93EE0")]
	internal LMBBIGPNMGL(Dictionary<TKey, TValue> OAIIHELJHLG, LBKEIDNCKEI CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4E93D20", Offset = "0x4E92B20", VA = "0x184E93D20")]
	public GFGCHNAHFOL<TKey, TValue> FIGHMLAJDFA([Out] Dictionary<TKey, TValue> OAIIHELJHLG)
	{
		return default(GFGCHNAHFOL<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct GFGCHNAHFOL<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> ENDBCPPONLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KABPOOHPANC HKDIFNAFMEE;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A1FB50", Offset = "0x2A1E950", VA = "0x182A1FB50")]
	internal GFGCHNAHFOL(Dictionary<TKey, TValue> OAIIHELJHLG, KABPOOHPANC LOBFFAIOFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4BC2010", Offset = "0x4BC0E10", VA = "0x184BC2010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct ANNJJKGABLF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly LBKEIDNCKEI LJJFJAHDJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> ENDBCPPONLD;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4E93DC0", Offset = "0x4E92BC0", VA = "0x184E93DC0")]
	public static ANNJJKGABLF<T> NBEICDCLFEE(string JAPGNGDBBIF)
	{
		return default(ANNJJKGABLF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4E93EE0", Offset = "0x4E92CE0", VA = "0x184E93EE0")]
	internal ANNJJKGABLF(HashSet<T> OAIIHELJHLG, LBKEIDNCKEI CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4E93D20", Offset = "0x4E92B20", VA = "0x184E93D20")]
	public DLACHIIGIFK<T> FIGHMLAJDFA([Out] HashSet<T> OAIIHELJHLG)
	{
		return default(DLACHIIGIFK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DLACHIIGIFK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> ENDBCPPONLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KABPOOHPANC HKDIFNAFMEE;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A1FB50", Offset = "0x2A1E950", VA = "0x182A1FB50")]
	internal DLACHIIGIFK(HashSet<T> OAIIHELJHLG, KABPOOHPANC LOBFFAIOFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4BC2010", Offset = "0x4BC0E10", VA = "0x184BC2010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct JNDDEKNFGLI<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LBKEIDNCKEI LJJFJAHDJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> ENDBCPPONLD;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4E93DC0", Offset = "0x4E92BC0", VA = "0x184E93DC0")]
	public static JNDDEKNFGLI<T> NBEICDCLFEE(string JAPGNGDBBIF)
	{
		return default(JNDDEKNFGLI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4E93EE0", Offset = "0x4E92CE0", VA = "0x184E93EE0")]
	internal JNDDEKNFGLI(Stack<T> OAIIHELJHLG, LBKEIDNCKEI CHGHHGBBNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E93D20", Offset = "0x4E92B20", VA = "0x184E93D20")]
	public LBJOFKIKPPH<T> FIGHMLAJDFA([Out] Stack<T> OAIIHELJHLG)
	{
		return default(LBJOFKIKPPH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct LBJOFKIKPPH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> ENDBCPPONLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly KABPOOHPANC HKDIFNAFMEE;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A1FB50", Offset = "0x2A1E950", VA = "0x182A1FB50")]
	internal LBJOFKIKPPH(Stack<T> OAIIHELJHLG, KABPOOHPANC LOBFFAIOFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4BC2010", Offset = "0x4BC0E10", VA = "0x184BC2010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class FIABOCPOCPL<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct BJCCNJMMAKG : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly FIABOCPOCPL<T> CKAKNAJCEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int DGMFPHKMCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool NGCONHDOFLP;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x26EAB00", Offset = "0x26E9900", VA = "0x1826EAB00")]
		public BJCCNJMMAKG(FIABOCPOCPL<T> OMKBHAHHOCG, int NANPEPGPGCJ, bool MDBOPEGLJFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6090460", Offset = "0x608F260", VA = "0x186090460")]
		public FIABOCPOCPL<T>.INHHEEFPGPK PHEMDOOJNPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6090550", Offset = "0x608F350", VA = "0x186090550", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6090550", Offset = "0x608F350", VA = "0x186090550", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class INHHEEFPGPK : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly FIABOCPOCPL<T> CKAKNAJCEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int ILAHMMJOMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int CPJNKGMDIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool NGCONHDOFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool MGONCAMPNOE;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4D53BB0", Offset = "0x4D529B0", VA = "0x184D53BB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4D53D60", Offset = "0x4D52B60", VA = "0x184D53D60", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x4D53F80", Offset = "0x4D52D80", VA = "0x184D53F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4D545A0", Offset = "0x4D533A0", VA = "0x184D545A0")]
		public INHHEEFPGPK(FIABOCPOCPL<T> OMKBHAHHOCG, int NANPEPGPGCJ, bool MDBOPEGLJFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4D53CB0", Offset = "0x4D52AB0", VA = "0x184D53CB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4D53D40", Offset = "0x4D52B40", VA = "0x184D53D40", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class ADEGDKPBKDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public ADEGDKPBKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4B9EFB0", Offset = "0x4B9DDB0", VA = "0x184B9EFB0")]
		internal T IOAIKFNLDIN(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] LKNKCFJKKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int CPJNKGMDIOB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int AECAGCDLBAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4ACD600", Offset = "0x4ACC400", VA = "0x184ACD600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T CKHLHELFBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4A3F700", Offset = "0x4A3E500", VA = "0x184A3F700")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T MKDDBDEOMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4ACD310", Offset = "0x4ACC110", VA = "0x184ACD310")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4ACD520", Offset = "0x4ACC320", VA = "0x184ACD520")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PIMHGEALGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x260ABF0", Offset = "0x26099F0", VA = "0x18260ABF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1ADC9C0", Offset = "0x1ADB7C0", VA = "0x181ADC9C0")]
	private static int DMIBNEEMCLH(int GLAOLHCPLLG, int NPCJGIOCILE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4ACDA00", Offset = "0x4ACC800", VA = "0x184ACDA00")]
	public FIABOCPOCPL(int ACINDEOBNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4ACD700", Offset = "0x4ACC500", VA = "0x184ACD700")]
	public FIABOCPOCPL(int ACINDEOBNPO, Func<T> NKDEPFHAPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4ACD8C0", Offset = "0x4ACC6C0", VA = "0x184ACD8C0")]
	public FIABOCPOCPL(T[] CPGOGHNJEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4ACD350", Offset = "0x4ACC150", VA = "0x184ACD350")]
	public void DEBLMDGECMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4ACD380", Offset = "0x4ACC180", VA = "0x184ACD380")]
	public IEnumerable<T> FIOLIGADBOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4ACD660", Offset = "0x4ACC460", VA = "0x184ACD660")]
	public FIABOCPOCPL<T>.INHHEEFPGPK PHEMDOOJNPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4A61E90", Offset = "0x4A60C90", VA = "0x184A61E90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4A61E90", Offset = "0x4A60C90", VA = "0x184A61E90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class KGOBNOEOGOH
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x39CA790", Offset = "0x39C9590", VA = "0x1839CA790")]
	public static FIABOCPOCPL<T> NBEICDCLFEE<T>(int ACINDEOBNPO, Func<T> NKDEPFHAPGJ) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7F07560", Offset = "0x7F06360", VA = "0x187F07560")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7F07520", Offset = "0x7F06320", VA = "0x187F07520")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7F07540", Offset = "0x7F06340", VA = "0x187F07540")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7F07580", Offset = "0x7F06380", VA = "0x187F07580")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7F07500", Offset = "0x7F06300", VA = "0x187F07500")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2816690", Offset = "0x2815490", VA = "0x182816690")]
		public RRColor(float JGFHGJBECJA, float CLMGFBJCLOK, float MDEAIGKHMKE, float CHIPBNNCPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D87050", Offset = "0x7D85E50", VA = "0x187D87050", Slot = "4")]
		public bool Equals(RRColor HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F07150", Offset = "0x7F05F50", VA = "0x187F07150", Slot = "0")]
		public override bool Equals(object HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F07250", Offset = "0x7F06050", VA = "0x187F07250", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F072D0", Offset = "0x7F060D0", VA = "0x187F072D0", Slot = "5")]
		public string ToString(string HONGJHADKJH, IFormatProvider NMMLIKIJEEF)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7F070F0", Offset = "0x7F05EF0", VA = "0x187F070F0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7F07090", Offset = "0x7F05E90", VA = "0x187F07090")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7F070C0", Offset = "0x7F05EC0", VA = "0x187F070C0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7F07120", Offset = "0x7F05F20", VA = "0x187F07120")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7F07060", Offset = "0x7F05E60", VA = "0x187F07060")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E12820", Offset = "0x5E11620", VA = "0x185E12820")]
		public RRColor32(byte JGFHGJBECJA, byte CLMGFBJCLOK, byte MDEAIGKHMKE, byte CHIPBNNCPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x21CB070", Offset = "0x21C9E70", VA = "0x1821CB070", Slot = "4")]
		public bool Equals(RRColor32 HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F06BC0", Offset = "0x7F059C0", VA = "0x187F06BC0", Slot = "0")]
		public override bool Equals(object HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1341930", Offset = "0x1340730", VA = "0x181341930", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F06CB0", Offset = "0x7F05AB0", VA = "0x187F06CB0")]
		public static RRColor32 HEKJAOMNHLJ(RRColor KMBJNMDOLGN)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F06C40", Offset = "0x7F05A40", VA = "0x187F06C40")]
		public static RRColor HEKJAOMNHLJ(RRColor32 KMBJNMDOLGN)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F06E00", Offset = "0x7F05C00", VA = "0x187F06E00", Slot = "5")]
		public string ToString(string HONGJHADKJH, IFormatProvider NMMLIKIJEEF)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class GDOANICDJLN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct MOFFADGLJNO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly GDOANICDJLN<T> NHADINCKMFE;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T COJGBJGNJFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x53DAFE0", Offset = "0x53D9DE0", VA = "0x1853DAFE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x53DAFB0", Offset = "0x53D9DB0", VA = "0x1853DAFB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
		public MOFFADGLJNO(GDOANICDJLN<T> NHADINCKMFE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct MHJEMBKJJNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<MOFFADGLJNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public GDOANICDJLN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x53C49B0", Offset = "0x53C37B0", VA = "0x1853C49B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x45D4020", Offset = "0x45D2E20", VA = "0x1845D4020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim NLGBFLAEAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T OFDGCGBJAJI;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4B86ED0", Offset = "0x4B85CD0", VA = "0x184B86ED0")]
	public GDOANICDJLN([In] T OFDGCGBJAJI, int IFFPKFBCEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4B86F70", Offset = "0x4B85D70", VA = "0x184B86F70")]
	public GDOANICDJLN([In] T OFDGCGBJAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4B867C0", Offset = "0x4B855C0", VA = "0x184B867C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4B86CA0", Offset = "0x4B85AA0", VA = "0x184B86CA0")]
	public MOFFADGLJNO POPDPKOFGOK()
	{
		return default(MOFFADGLJNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4B86820", Offset = "0x4B85620", VA = "0x184B86820")]
	[AsyncStateMachine(typeof(GDOANICDJLN<>.MHJEMBKJJNI))]
	public Task<GDOANICDJLN<T>.MOFFADGLJNO> PCBMHEKJFLP(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4B86800", Offset = "0x4B85600", VA = "0x184B86800")]
	public void INHOGEENKEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class EENMELMDFJF
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F03C50", Offset = "0x7F02A50", VA = "0x187F03C50")]
	public static GDOANICDJLN<NICNPLCGCEF> NBEICDCLFEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3776EB0", Offset = "0x3775CB0", VA = "0x183776EB0")]
	public static GDOANICDJLN<T> NBEICDCLFEE<T>([In] T OFDGCGBJAJI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class KDHMGMEAJEN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct NGJMCJEHODA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly KDHMGMEAJEN<T> IDNFIDGHGAM;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T COJGBJGNJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x46145E0", Offset = "0x46133E0", VA = "0x1846145E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x54B2730", Offset = "0x54B1530", VA = "0x1854B2730", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
		internal NGJMCJEHODA(KDHMGMEAJEN<T> NHADINCKMFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct EOLBDFBBNAB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly KDHMGMEAJEN<T> IDNFIDGHGAM;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T COJGBJGNJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x46145E0", Offset = "0x46133E0", VA = "0x1846145E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4614540", Offset = "0x4613340", VA = "0x184614540", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
		internal EOLBDFBBNAB(KDHMGMEAJEN<T> NHADINCKMFE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct NIOLINMDNLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<EOLBDFBBNAB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KDHMGMEAJEN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private GDOANICDJLN<NICNPLCGCEF>.MOFFADGLJNO <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<GDOANICDJLN<NICNPLCGCEF>.MOFFADGLJNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x54C50F0", Offset = "0x54C3EF0", VA = "0x1854C50F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x45D4020", Offset = "0x45D2E20", VA = "0x1845D4020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GDOANICDJLN<int> JNKIGBFHEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly GDOANICDJLN<NICNPLCGCEF> FGNPONLNNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GDOANICDJLN<NICNPLCGCEF> ANNDGLCBPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T MBGJGLGBJEC;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x50A1220", Offset = "0x50A0020", VA = "0x1850A1220")]
	internal KDHMGMEAJEN(GDOANICDJLN<int> HIOELACBEGP, GDOANICDJLN<NICNPLCGCEF> KDCEHDALONA, GDOANICDJLN<NICNPLCGCEF> NPNOHJMEPOM, [In] T OFDGCGBJAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x50A0AF0", Offset = "0x509F8F0", VA = "0x1850A0AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x50A0830", Offset = "0x509F630", VA = "0x1850A0830")]
	public NGJMCJEHODA DCFINHBGJDA()
	{
		return default(NGJMCJEHODA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x50A0D50", Offset = "0x509FB50", VA = "0x1850A0D50")]
	public EOLBDFBBNAB KNLEDDADFAC()
	{
		return default(EOLBDFBBNAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x50A1080", Offset = "0x509FE80", VA = "0x1850A1080")]
	[AsyncStateMachine(typeof(KDHMGMEAJEN<>.NIOLINMDNLD))]
	public Task<KDHMGMEAJEN<T>.EOLBDFBBNAB> PPEKHLAHJEF(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KBBDIAANHKF
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7F055A0", Offset = "0x7F043A0", VA = "0x187F055A0")]
	public static KDHMGMEAJEN<NICNPLCGCEF> NBEICDCLFEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x39C2810", Offset = "0x39C1610", VA = "0x1839C2810")]
	public static KDHMGMEAJEN<T> NBEICDCLFEE<T>([In] T OFDGCGBJAJI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class AKBPKLBDLGF<TData> : DDPPOHMMKFK where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string BGIMHHCKDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData NOKLNLDMACL;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
	public override string EEHOEKHGKPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2BE0", Offset = "0x4DC19E0", VA = "0x184DC2BE0")]
	internal AKBPKLBDLGF(string NJJDPBHNDPA, [In] TData FFEMKICJPKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class MAJDGMDJGMD
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7F05B40", Offset = "0x7F04940", VA = "0x187F05B40")]
	public static AKBPKLBDLGF<NICNPLCGCEF> NBEICDCLFEE(string NJJDPBHNDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x371BB90", Offset = "0x371A990", VA = "0x18371BB90")]
	public static AKBPKLBDLGF<TData> NBEICDCLFEE<TData>(string NJJDPBHNDPA, [In] TData FFEMKICJPKP) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class LBKEIDNCKEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool GFLEFDKHIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string GCJOHKBPNAJ;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xE37510", Offset = "0xE36310", VA = "0x180E37510")]
	private LBKEIDNCKEI(bool GCCFPMLCLLP, string MOBBBNKKEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7F057B0", Offset = "0x7F045B0", VA = "0x187F057B0")]
	public static LBKEIDNCKEI NBEICDCLFEE(string MOBBBNKKEKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7F056F0", Offset = "0x7F044F0", VA = "0x187F056F0")]
	public KABPOOHPANC FIGHMLAJDFA()
	{
		return default(KABPOOHPANC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct KABPOOHPANC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LBKEIDNCKEI NMLPDOCNMNM;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	internal KABPOOHPANC(LBKEIDNCKEI JAPGNGDBBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7F05580", Offset = "0x7F04380", VA = "0x187F05580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class NJKPLOFPION<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class COBIHPHHDBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public COBIHPHHDBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x671C170", Offset = "0x671AF70", VA = "0x18671C170")]
		internal int PGGGFBEPLPK(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? HJOJIKKHCHL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> FNMNAKIKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x54C8070", Offset = "0x54C6E70", VA = "0x1854C8070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IHCMKFAADEC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x54C80B0", Offset = "0x54C6EB0", VA = "0x1854C80B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x54C7CF0", Offset = "0x54C6AF0", VA = "0x1854C7CF0")]
	public bool AIKICPLLADB(T JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x54C7F00", Offset = "0x54C6D00", VA = "0x1854C7F00")]
	public bool FKCGDELNEED(T JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x54C7EB0", Offset = "0x54C6CB0", VA = "0x1854C7EB0")]
	public bool CIMEKDDIMAF(T JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x54C7C10", Offset = "0x54C6A10", VA = "0x1854C7C10")]
	public void ABNJIEJICJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54C8100", Offset = "0x54C6F00", VA = "0x1854C8100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public NJKPLOFPION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class GHLDACEJKIG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class HBIHHGJLILH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public HBIHHGJLILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F05340", Offset = "0x7F04140", VA = "0x187F05340")]
		internal int PGGGFBEPLPK(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? HJOJIKKHCHL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> FNMNAKIKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7F04C60", Offset = "0x7F03A60", VA = "0x187F04C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool IHCMKFAADEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7F04CF0", Offset = "0x7F03AF0", VA = "0x187F04CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7F04A80", Offset = "0x7F03880", VA = "0x187F04A80")]
	public bool AIKICPLLADB(object JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7F04BC0", Offset = "0x7F039C0", VA = "0x187F04BC0")]
	public bool FKCGDELNEED(object JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7F04B60", Offset = "0x7F03960", VA = "0x187F04B60")]
	public bool CIMEKDDIMAF(object JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7F04A10", Offset = "0x7F03810", VA = "0x187F04A10")]
	public void ABNJIEJICJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7F04D00", Offset = "0x7F03B00", VA = "0x187F04D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GHLDACEJKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class JHOPGPBCAJJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct ODDNICNBPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float EDFHGDOADIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T COJGBJGNJFM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, ODDNICNBPMA> HLNAGBKDKBG;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T EOBHNEKFNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x111AD00", Offset = "0x1119B00", VA = "0x18111AD00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x19D7C50", Offset = "0x19D6A50", VA = "0x1819D7C50", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? FIFCNMEHAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool ELLLHODOKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7F30", Offset = "0x4FB6D30", VA = "0x184FB7F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4FBA100", Offset = "0x4FB8F00", VA = "0x184FBA100")]
	public bool PKOECEEOIDM(T OAIIHELJHLG, object JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4FB7F90", Offset = "0x4FB6D90", VA = "0x184FB7F90")]
	public bool DGJFOFCPLFN(object JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2FD0", Offset = "0x4BA1DD0", VA = "0x184BA2FD0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4FB80C0", Offset = "0x4FB6EC0", VA = "0x184FB80C0")]
	public bool GNFCCDJDLII(object JLFLGDNCANL, [Out] T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4FB87A0", Offset = "0x4FB75A0", VA = "0x184FB87A0")]
	[FBGGHAJGOHK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OFKDLNIPCMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4FBA580", Offset = "0x4FB9380", VA = "0x184FBA580")]
	public JHOPGPBCAJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class GHDFENKGPPP : FCBAJLLPFCL<DPBIDJALKLM>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class NKABCMLJBKH : IEqualityComparer<DPBIDJALKLM>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly NKABCMLJBKH ICOFMPPJNFC;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7F067B0", Offset = "0x7F055B0", VA = "0x187F067B0", Slot = "4")]
		public bool Equals(DPBIDJALKLM AJEEBBBAOKG, DPBIDJALKLM GJPKMHAOJHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7051050", Offset = "0x704FE50", VA = "0x187051050", Slot = "5")]
		public int GetHashCode(DPBIDJALKLM GLEBGNJJOHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NKABCMLJBKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F049A0", Offset = "0x7F037A0", VA = "0x187F049A0")]
	public GHDFENKGPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7F047B0", Offset = "0x7F035B0", VA = "0x187F047B0", Slot = "4")]
	public override bool AIKICPLLADB(DPBIDJALKLM JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7F04860", Offset = "0x7F03660", VA = "0x187F04860", Slot = "5")]
	public override bool FKCGDELNEED(DPBIDJALKLM JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7F04910", Offset = "0x7F03710", VA = "0x187F04910")]
	private static void PJBCGFJGDLC(DPBIDJALKLM JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x18D58A0", Offset = "0x18D46A0", VA = "0x1818D58A0", Slot = "6")]
	protected override string TokenToString(DPBIDJALKLM JLFLGDNCANL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class DPBIDJALKLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string KDHIEDFAFDL;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public DPBIDJALKLM(string KDHIEDFAFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7F03C00", Offset = "0x7F02A00", VA = "0x187F03C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class FCBAJLLPFCL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> EDPFJJMAPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? HJOJIKKHCHL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IHCMKFAADEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4A44B90", Offset = "0x4A43990", VA = "0x184A44B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4A45260", Offset = "0x4A44060", VA = "0x184A45260")]
	public FCBAJLLPFCL(IEqualityComparer<T> EDPFJJMAPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4A446E0", Offset = "0x4A434E0", VA = "0x184A446E0", Slot = "4")]
	public virtual bool AIKICPLLADB(T JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4A44A20", Offset = "0x4A43820", VA = "0x184A44A20", Slot = "5")]
	public virtual bool FKCGDELNEED(T JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4A44430", Offset = "0x4A43230", VA = "0x184A44430")]
	public void ABNJIEJICJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x4A44BD0", Offset = "0x4A439D0", VA = "0x184A44BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class PPPCEKHNJDN<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? HJOJIKKHCHL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IHCMKFAADEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x57C3630", Offset = "0x57C2430", VA = "0x1857C3630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x57C32F0", Offset = "0x57C20F0", VA = "0x1857C32F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x57C3080", Offset = "0x57C1E80", VA = "0x1857C3080")]
	public void AIKICPLLADB(T JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x57C3490", Offset = "0x57C2290", VA = "0x1857C3490")]
	public void FKCGDELNEED(T JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x57C3040", Offset = "0x57C1E40", VA = "0x1857C3040")]
	public void ABNJIEJICJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x57C3750", Offset = "0x57C2550", VA = "0x1857C3750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PPPCEKHNJDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class NIADCPFMPPC
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3A0AB40", Offset = "0x3A09940", VA = "0x183A0AB40")]
	public static void BIMJJOKKJKF<T>(this List<T> COKPAJOONAO, int GLAOLHCPLLG) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MCBPPOLBONJ<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct HHKBEHEMOHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float EDFHGDOADIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T COJGBJGNJFM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<DPBIDJALKLM, HHKBEHEMOHL> HLNAGBKDKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> EHCBCJCPNKC;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T EOBHNEKFNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private DPBIDJALKLM? FIFCNMEHAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ELLLHODOKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7F30", Offset = "0x4FB6D30", VA = "0x184FB7F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x539A280", Offset = "0x5399080", VA = "0x18539A280")]
	public bool PKOECEEOIDM(T OAIIHELJHLG, DPBIDJALKLM JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4FB7F90", Offset = "0x4FB6D90", VA = "0x184FB7F90")]
	public bool DGJFOFCPLFN(DPBIDJALKLM JLFLGDNCANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2FD0", Offset = "0x4BA1DD0", VA = "0x184BA2FD0")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4FB8030", Offset = "0x4FB6E30", VA = "0x184FB8030")]
	public bool GNFCCDJDLII(DPBIDJALKLM JLFLGDNCANL, [Out] T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5399BC0", Offset = "0x53989C0", VA = "0x185399BC0")]
	[FBGGHAJGOHK("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OFKDLNIPCMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x539A380", Offset = "0x5399180", VA = "0x18539A380")]
	public MCBPPOLBONJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NLOJPENCFEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> HLNAGBKDKBG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float CKGHHOBJAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xF09910", Offset = "0xF08710", VA = "0x180F09910")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xF09920", Offset = "0xF08720", VA = "0x180F09920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7F06A40", Offset = "0x7F05840", VA = "0x187F06A40")]
	public void PKOECEEOIDM(float OAIIHELJHLG, object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7F068A0", Offset = "0x7F056A0", VA = "0x187F068A0")]
	public void DGJFOFCPLFN(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7F06850", Offset = "0x7F05650", VA = "0x187F06850")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7F06910", Offset = "0x7F05710", VA = "0x187F06910")]
	private void MHODEMKKJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7F06AB0", Offset = "0x7F058B0", VA = "0x187F06AB0")]
	public NLOJPENCFEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface AIKJEOAMDOK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event MGLIPIHJPBA JJPHPJNAAMI;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class NDJMODJJIEA : AIKJEOAMDOK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct MELMBNDDCOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float CBHIJBFDGNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float JPGAHJPOIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool JOCIPIGBAHE;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float KBBILNDKGJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x7F05BC0", Offset = "0x7F049C0", VA = "0x187F05BC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7F05D30", Offset = "0x7F04B30", VA = "0x187F05D30")]
		public MELMBNDDCOD(float GNMMLFONKNO, float ONOFHBPOEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7F05BD0", Offset = "0x7F049D0", VA = "0x187F05BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class FCJOODFLDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public NDJMODJJIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public FCJOODFLDBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7F03E60", Offset = "0x7F02C60", VA = "0x187F03E60")]
		internal void KFJMODDOLBP(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int KIOMCEJDGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int NDGHPMNJDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly AIKJEOAMDOK[] NBKDMAINFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MGLIPIHJPBA[] LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly MELMBNDDCOD[] OELHBPGKEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private MELMBNDDCOD DKJEIKOJLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CFKPBECMIBP GNODGNDLHJD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event MGLIPIHJPBA JJPHPJNAAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7F06060", Offset = "0x7F04E60", VA = "0x187F06060", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7F05E90", Offset = "0x7F04C90", VA = "0x187F05E90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7F06620", Offset = "0x7F05420", VA = "0x187F06620")]
	public NDJMODJJIEA(int KIOMCEJDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7F06590", Offset = "0x7F05390", VA = "0x187F06590")]
	public CFKPBECMIBP MECKNPPOFAI(MELMBNDDCOD MIBGBKPCNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7F06120", Offset = "0x7F04F20", VA = "0x187F06120")]
	public void LGNGGAFBOIN(AIKJEOAMDOK GECMODDMPPI, [Optional] MELMBNDDCOD KIFFIFMGILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7F05F50", Offset = "0x7F04D50", VA = "0x187F05F50", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void MGLIPIHJPBA(float LAOLBIOBMCC);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class IPNPHDGLCCI
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class CPIBCMAKJGO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly AIKJEOAMDOK FMOHNDGMJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly MGLIPIHJPBA LDLIMOGOGBF;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7F03450", Offset = "0x7F02250", VA = "0x187F03450")]
		public CPIBCMAKJGO(AIKJEOAMDOK FMOHNDGMJNB, MGLIPIHJPBA LDLIMOGOGBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7F03400", Offset = "0x7F02200", VA = "0x187F03400", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7F05450", Offset = "0x7F04250", VA = "0x187F05450")]
	internal static bool DAPDJJNIJOC(float CHIPBNNCPBF, float MDEAIGKHMKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7EF27C0", Offset = "0x7EF15C0", VA = "0x187EF27C0")]
	internal static float HJENEIEEJJP(float CHIPBNNCPBF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7F054C0", Offset = "0x7F042C0", VA = "0x187F054C0")]
	public static IDisposable GNLLMCFEOBK(this AIKJEOAMDOK FMOHNDGMJNB, MGLIPIHJPBA LDLIMOGOGBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CFKPBECMIBP : AIKJEOAMDOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float LAOLBIOBMCC;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float BBEFABAAFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7F032B0", Offset = "0x7F020B0", VA = "0x187F032B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event MGLIPIHJPBA? JJPHPJNAAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7F03210", Offset = "0x7F02010", VA = "0x187F03210", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7F03170", Offset = "0x7F01F70", VA = "0x187F03170", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CFKPBECMIBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface MBLHPLDJKBP<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DHIJAGFCGAN<T> IGFEPLMMLKP([Out] T OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCLJDABAPHP();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DCFFGFEHPAP<T> : MBLHPLDJKBP<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> MOFFNEHMFBF;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7520", Offset = "0x6AE6320", VA = "0x186AE7520", Slot = "4")]
	public DHIJAGFCGAN<T> IGFEPLMMLKP([Out] T OAIIHELJHLG)
	{
		return default(DHIJAGFCGAN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7660", Offset = "0x6AE6460", VA = "0x186AE7660")]
	public void OJKDNIEEGBG(T OLCBHEDBBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4FD11E0", Offset = "0x4FCFFE0", VA = "0x184FD11E0", Slot = "5")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "6")]
	protected virtual void HFEBMEMCKBI(T HFENHCLEIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6AE75C0", Offset = "0x6AE63C0", VA = "0x186AE75C0")]
	private T MBFFDPKOBBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6AE76E0", Offset = "0x6AE64E0", VA = "0x186AE76E0")]
	public DCFFGFEHPAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct DHIJAGFCGAN<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T OLCBHEDBBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly DCFFGFEHPAP<T> CEJJHFEJOGM;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
	internal DHIJAGFCGAN(T OAIIHELJHLG, DCFFGFEHPAP<T> CEJJHFEJOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6B11C50", Offset = "0x6B10A50", VA = "0x186B11C50", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class ENAKBJIIDKB : DCFFGFEHPAP<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly ENAKBJIIDKB ICOFMPPJNFC;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7F03CE0", Offset = "0x7F02AE0", VA = "0x187F03CE0")]
	public static DHIJAGFCGAN<StringBuilder> MBFFDPKOBBN([Out] StringBuilder OAIIHELJHLG)
	{
		return default(DHIJAGFCGAN<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7F03CC0", Offset = "0x7F02AC0", VA = "0x187F03CC0", Slot = "6")]
	protected override void HFEBMEMCKBI(StringBuilder HFENHCLEIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7F03E20", Offset = "0x7F02C20", VA = "0x187F03E20")]
	public ENAKBJIIDKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AJNMNJCMILN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x77ABA60", Offset = "0x77AA860", VA = "0x1877ABA60")]
	public AJNMNJCMILN(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class LPHLLPEAGGJ<TKey, TValue> : ECJBPDDPOEB<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, OLAIIFJDODN where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class BPPFICFEMLP : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public LPHLLPEAGGJ<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x111AD00", Offset = "0x1119B00", VA = "0x18111AD00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x4B1A6A0", Offset = "0x4B194A0", VA = "0x184B1A6A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public BPPFICFEMLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4B1A890", Offset = "0x4B19690", VA = "0x184B1A890", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x626B850", Offset = "0x626A650", VA = "0x18626B850", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x626BFE0", Offset = "0x626ADE0", VA = "0x18626BFE0")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x626B450", Offset = "0x626A250", VA = "0x18626B450")]
		private void IMLDEFFNBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x626C120", Offset = "0x626AF20", VA = "0x18626C120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ECJBPDDPOEB<TKey, TValue> KFMEGAHCIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> KNEPKKPPMDB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x51B8320", Offset = "0x51B7120", VA = "0x1851B8320", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LHOLHNBADAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x51B83F0", Offset = "0x51B71F0", VA = "0x1851B83F0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x51B86C0", Offset = "0x51B74C0", VA = "0x1851B86C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> FJHHIONJFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x51B8480", Offset = "0x51B7280", VA = "0x1851B8480", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> HFKBMCLKGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x51B85A0", Offset = "0x51B73A0", VA = "0x1851B85A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x51B80C0", Offset = "0x51B6EC0", VA = "0x1851B80C0")]
	public LPHLLPEAGGJ(ECJBPDDPOEB<TKey, TValue> KFMEGAHCIBN, [Optional] IDictionary<TKey, TValue>? KNEPKKPPMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x51B5A00", Offset = "0x51B4800", VA = "0x1851B5A00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x51B6580", Offset = "0x51B5380", VA = "0x1851B6580")]
	public void FIFOAONJLMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x51B5430", Offset = "0x51B4230", VA = "0x1851B5430", Slot = "9")]
	public void Add(TKey MAKJJJECHHB, TValue OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x51B66A0", Offset = "0x51B54A0", VA = "0x1851B66A0")]
	public void FJBDGEFINEP(TKey MAKJJJECHHB, TValue OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x51B7310", Offset = "0x51B6110", VA = "0x1851B7310")]
	public void PAHLEBAJPII(TKey MAKJJJECHHB, TValue OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x51B6DA0", Offset = "0x51B5BA0", VA = "0x1851B6DA0")]
	public void OEJAEDBHEGM(TKey MAKJJJECHHB, TValue OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x51B6490", Offset = "0x51B5290", VA = "0x1851B6490")]
	public void EHLDAONCAIP(TKey MAKJJJECHHB, TValue OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x51B7740", Offset = "0x51B6540", VA = "0x1851B7740", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x51B7930", Offset = "0x51B6730", VA = "0x1851B7930", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x51B7C90", Offset = "0x51B6A90", VA = "0x1851B7C90", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x51B5A90", Offset = "0x51B4890", VA = "0x1851B5A90", Slot = "8")]
	public bool ContainsKey(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x51B69F0", Offset = "0x51B57F0", VA = "0x1851B69F0")]
	public bool HNPFELALEBC(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x51B58D0", Offset = "0x51B46D0", VA = "0x1851B58D0")]
	public bool CPHKNJNGFPG(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x51B7560", Offset = "0x51B6360", VA = "0x1851B7560", Slot = "10")]
	public bool Remove(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x51B7F20", Offset = "0x51B6D20", VA = "0x1851B7F20", Slot = "11")]
	public bool TryGetValue(TKey MAKJJJECHHB, [Out] TValue OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x51B5E40", Offset = "0x51B4C40", VA = "0x1851B5E40", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] KNDCNOIHMGO, int PIJHOBEHDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5067350", Offset = "0x5066150", VA = "0x185067350", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x51B6830", Offset = "0x51B5630", VA = "0x1851B6830", Slot = "19")]
	[IteratorStateMachine(typeof(LPHLLPEAGGJ<, >.BPPFICFEMLP))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x51B6310", Offset = "0x51B5110", VA = "0x1851B6310", Slot = "21")]
	public bool DJNCOAIMNGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x51B6C90", Offset = "0x51B5A90", VA = "0x1851B6C90")]
	private TValue IFBEBPCKHJP(TKey MAKJJJECHHB)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface EJODHBFGIMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string OABFOKAGDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface OLAIIFJDODN
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJNCOAIMNGC();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface ECJBPDDPOEB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, OLAIIFJDODN
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class NDJENDDAKLA<TKey, TVal> : ECJBPDDPOEB<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, OLAIIFJDODN where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int LGEGMKICFID(TKey MAKJJJECHHB, TVal OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void GNJCMOGDOOG(TKey MAKJJJECHHB, TVal OAIIHELJHLG, FNDCLKENOOB KLOPBEMIGAO);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class PHMOKPMLLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal COJGBJGNJFM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xCA8290", Offset = "0xCA7090", VA = "0x180CA8290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int KBBILNDKGJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xD521D0", Offset = "0xD50FD0", VA = "0x180D521D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xF5E9F0", Offset = "0xF5D7F0", VA = "0x180F5E9F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset DFJODMLLHDB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x12E0300", Offset = "0x12DF100", VA = "0x1812E0300")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x12E0BD0", Offset = "0x12DF9D0", VA = "0x1812E0BD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5779440", Offset = "0x5778240", VA = "0x185779440")]
		public PHMOKPMLLKJ(TKey MAKJJJECHHB, TVal AFBDJBIOHNP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class PEHANAFLIHD : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NDJENDDAKLA<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<PHMOKPMLLKJ>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x111AD00", Offset = "0x1119B00", VA = "0x18111AD00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x5773C20", Offset = "0x5772A20", VA = "0x185773C20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public PEHANAFLIHD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4AD3700", Offset = "0x4AD2500", VA = "0x184AD3700", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5772AD0", Offset = "0x57718D0", VA = "0x185772AD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x57736A0", Offset = "0x57724A0", VA = "0x1857736A0")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5773A90", Offset = "0x5772890", VA = "0x185773A90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int PGICMEIPHOP = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<PHMOKPMLLKJ>> FBDIIMGILAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<PHMOKPMLLKJ> CKOLAAICHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly LGEGMKICFID? OBDGHAHLKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan BPLOGJBINPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GNJCMOGDOOG? NAMLOPMJFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ENLBBEJIIBF HFGKFKKIKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool ILKGKBCKLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> KCPPGPICADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> PPIJLNODJMA;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int HFLLAFNJABA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xC15DC0", Offset = "0xC14BC0", VA = "0x180C15DC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int HMHHOHIMAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xD55D10", Offset = "0xD54B10", VA = "0x180D55D10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xE8C3C0", Offset = "0xE8B1C0", VA = "0x180E8C3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5496460", Offset = "0x5495260", VA = "0x185496460", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int CAEFKLLJAMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2FD0", Offset = "0x4BA1DD0", VA = "0x184BA2FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> HFKBMCLKGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x54965E0", Offset = "0x54953E0", VA = "0x1854965E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.FGLPNLBNJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x5491B30", Offset = "0x5490930", VA = "0x185491B30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool LHOLHNBADAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal ANMDDLMJFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x54964F0", Offset = "0x54952F0", VA = "0x1854964F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5496670", Offset = "0x5495470", VA = "0x185496670", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x548A8D0", Offset = "0x54896D0", VA = "0x18548A8D0")]
	private bool GNNAFMBMKDC(int KIOMCEJDGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x548C730", Offset = "0x548B530", VA = "0x18548C730")]
	private void NLCCACFBMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5494160", Offset = "0x5492F60", VA = "0x185494160")]
	public NDJENDDAKLA(int KIOMCEJDGPM, [Optional] LGEGMKICFID? OBDGHAHLKGB, [Optional] IEqualityComparer<TKey>? DLFJGFJJMCP, [Optional] GNJCMOGDOOG? NAMLOPMJFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5492E90", Offset = "0x5491C90", VA = "0x185492E90")]
	public NDJENDDAKLA(TimeSpan BPLOGJBINPA, [Optional] IEqualityComparer<TKey>? DLFJGFJJMCP, [Optional] GNJCMOGDOOG? NAMLOPMJFJL, [Optional] ENLBBEJIIBF? HFGKFKKIKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5492E10", Offset = "0x5491C10", VA = "0x185492E10")]
	public NDJENDDAKLA(int KIOMCEJDGPM, TimeSpan BPLOGJBINPA, [Optional] IEqualityComparer<TKey>? DLFJGFJJMCP, [Optional] GNJCMOGDOOG? NAMLOPMJFJL, [Optional] ENLBBEJIIBF? HFGKFKKIKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5495740", Offset = "0x5494540", VA = "0x185495740")]
	public NDJENDDAKLA(int KIOMCEJDGPM, LGEGMKICFID? OBDGHAHLKGB, TimeSpan BPLOGJBINPA, [Optional] IEqualityComparer<TKey>? DLFJGFJJMCP, [Optional] GNJCMOGDOOG? NAMLOPMJFJL, [Optional] ENLBBEJIIBF? HFGKFKKIKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5482B50", Offset = "0x5481950", VA = "0x185482B50", Slot = "21")]
	public bool DJNCOAIMNGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x548AF50", Offset = "0x5489D50", VA = "0x18548AF50", Slot = "22")]
	public bool JGMADHJJEHG(int ACINDEOBNPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5482BF0", Offset = "0x54819F0", VA = "0x185482BF0")]
	private bool EHIEDIKLBFA(int ACINDEOBNPO, FNDCLKENOOB KLOPBEMIGAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x548B5F0", Offset = "0x548A3F0", VA = "0x18548B5F0")]
	public void KDAEEABIJCL(TKey MAKJJJECHHB, TVal OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x547DBD0", Offset = "0x547C9D0", VA = "0x18547DBD0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HHHFHHLBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x547E1A0", Offset = "0x547CFA0", VA = "0x18547E1A0", Slot = "9")]
	public void Add(TKey MAKJJJECHHB, TVal OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5480450", Offset = "0x547F250", VA = "0x185480450", Slot = "8")]
	public bool ContainsKey(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5491360", Offset = "0x5490160", VA = "0x185491360", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5490C00", Offset = "0x548FA00", VA = "0x185490C00", Slot = "10")]
	public bool Remove(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x54919F0", Offset = "0x54907F0", VA = "0x1854919F0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> HHHFHHLBBIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x547F060", Offset = "0x547DE60", VA = "0x18547F060")]
	private bool CJBGJMGELEG(TKey MAKJJJECHHB, [Out] TVal OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x548C1F0", Offset = "0x548AFF0", VA = "0x18548C1F0")]
	private TVal MBFFDPKOBBN(TKey PACALLJHMNM)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5491BC0", Offset = "0x54909C0", VA = "0x185491BC0", Slot = "11")]
	public bool TryGetValue(TKey PACALLJHMNM, [Out] TVal OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5480270", Offset = "0x547F070", VA = "0x185480270", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5482130", Offset = "0x5480F30", VA = "0x185482130", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KNDCNOIHMGO, int PIJHOBEHDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x547E310", Offset = "0x547D110", VA = "0x18547E310")]
	private void CEJCBNPJPGA(TKey MAKJJJECHHB, TVal AFBDJBIOHNP, FNDCLKENOOB KLOPBEMIGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x547C6E0", Offset = "0x547B4E0", VA = "0x18547C6E0")]
	private bool AFAJGNDNBLA(PHMOKPMLLKJ JFIAIHCFEPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5486CC0", Offset = "0x5485AC0", VA = "0x185486CC0")]
	private void GGLFJHCHJOD(LinkedListNode<PHMOKPMLLKJ> JHBEFCDDGIK, TVal OHCLPCBAJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x548FE00", Offset = "0x548EC00", VA = "0x18548FE00")]
	private void PKOECEEOIDM(TKey MAKJJJECHHB, TVal OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x548D260", Offset = "0x548C060", VA = "0x18548D260")]
	private void OMMEKCCDBOG(PHMOKPMLLKJ JFIAIHCFEPJ, TVal OHCLPCBAJPD, int ENHAFBAANHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x548AA80", Offset = "0x5489880", VA = "0x18548AA80", Slot = "19")]
	[IteratorStateMachine(typeof(NDJENDDAKLA<, >.PEHANAFLIHD))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5491B80", Offset = "0x5490980", VA = "0x185491B80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum FNDCLKENOOB : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class AGBNACACOCJ<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey HLJPOEPEIBF;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CA60", Offset = "0x4C8B860", VA = "0x184C8CA60")]
	public AGBNACACOCJ(TKey GBJFMMGOOKA, Exception IGKCCLCOBDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class OKNIOPKBHCC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5EB0", Offset = "0x6FE4CB0", VA = "0x186FE5EB0")]
	public OKNIOPKBHCC(string NJJDPBHNDPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class GCCFCBBMFKB<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class CBNAPGNIDCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public GCCFCBBMFKB<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public CBNAPGNIDCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6549EB0", Offset = "0x6548CB0", VA = "0x186549EB0")]
		internal Task<TResource> ENPBKHNINDN(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct ICHBLNCHPCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public GCCFCBBMFKB<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4D28B00", Offset = "0x4D27900", VA = "0x184D28B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x4D294C0", Offset = "0x4D282C0", VA = "0x184D294C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct JIPCBELILJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4FBE4D0", Offset = "0x4FBD2D0", VA = "0x184FBE4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4FBEE30", Offset = "0x4FBDC30", VA = "0x184FBEE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly JAMLBKMMMEO<TId, Task<TResource>> PILINJFINDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> FPPJCLPIEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? BMLEIGHHHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? JPHPKOEOKLE;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4B818C0", Offset = "0x4B806C0", VA = "0x184B818C0")]
	public GCCFCBBMFKB(int NMACKFEHHPP = 0, [Optional] IEqualityComparer<TId>? NGPBGJPJMCH, [Optional] Func<TId, CancellationToken, Task<TResource>>? KBMOEEAIBCF, [Optional] Action<TResource>? CDPKIGCHHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4B80430", Offset = "0x4B7F230", VA = "0x184B80430")]
	public MMLLOANHJIJ<Task<TResource>> DDMFCGNGLKI(TId FONJFDCCINO, [Optional] Func<TId, CancellationToken, Task<TResource>>? KBMOEEAIBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4B80900", Offset = "0x4B7F700", VA = "0x184B80900")]
	private void EDHIJCBDECA(Task<TResource> JDEJDGHOHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4B81320", Offset = "0x4B80120", VA = "0x184B81320")]
	[AsyncStateMachine(typeof(GCCFCBBMFKB<, >.ICHBLNCHPCN))]
	private Task JHKBHLODEFN(Task<TResource> JDEJDGHOHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4B81520", Offset = "0x4B80320", VA = "0x184B81520")]
	public void NMDOMIGMDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4B81680", Offset = "0x4B80480", VA = "0x184B81680")]
	public JAMLBKMMMEO<TId, Task<TResource>>.ACLNNAHMELK PHEMDOOJNPF()
	{
		return default(JAMLBKMMMEO<TId, Task<TResource>>.ACLNNAHMELK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4B81790", Offset = "0x4B80590", VA = "0x184B81790", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4B81790", Offset = "0x4B80590", VA = "0x184B81790", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4B80D90", Offset = "0x4B7FB90", VA = "0x184B80D90")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GCCFCBBMFKB<, >.JIPCBELILJH))]
	internal static Task JFLANMHFNHI(Task<TResource> JDEJDGHOHNF, CancellationTokenSource JANOHMJCACE, Dictionary<Task<TResource>, CancellationTokenSource> ELCAEEAMGOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class JAMLBKMMMEO<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class GABNDMPENEC : IEquatable<GABNDMPENEC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue COJGBJGNJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int JENIIHANNJF;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x11DEB70", Offset = "0x11DD970", VA = "0x1811DEB70")]
		public GABNDMPENEC(TValue OAIIHELJHLG, int OHHGBIJLNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4B7B3B0", Offset = "0x4B7A1B0", VA = "0x184B7B3B0", Slot = "4")]
		public bool Equals(GABNDMPENEC? HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x4B7B440", Offset = "0x4B7A240", VA = "0x184B7B440", Slot = "0")]
		public override bool Equals(object? GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4B7B600", Offset = "0x4B7A400", VA = "0x184B7B600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct ACLNNAHMELK : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, GABNDMPENEC>.Enumerator HBJPPOHNBHO;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x4B9B960", Offset = "0x4B9A760", VA = "0x184B9B960", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) CKHLHELFBCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x4B9BDC0", Offset = "0x4B9ABC0", VA = "0x184B9BDC0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4B9BB50", Offset = "0x4B9A950", VA = "0x184B9BB50")]
		public ACLNNAHMELK(JAMLBKMMMEO<TKey, TValue> HLNAGBKDKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4B9B5C0", Offset = "0x4B9A3C0", VA = "0x184B9B5C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4B9B680", Offset = "0x4B9A480", VA = "0x184B9B680", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4B9B810", Offset = "0x4B9A610", VA = "0x184B9B810", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class IPKIAAAIEIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public JAMLBKMMMEO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public GABNDMPENEC refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IPKIAAAIEIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4D734A0", Offset = "0x4D722A0", VA = "0x184D734A0")]
		internal void ENPBKHNINDN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, GABNDMPENEC> EPFACFNCGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? BBJFJDFIMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? NBKBMIOGJCP;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4F65460", Offset = "0x4F64260", VA = "0x184F65460")]
	public JAMLBKMMMEO(int NMACKFEHHPP = 0, [Optional] IEqualityComparer<TKey>? DLFJGFJJMCP, [Optional] Func<TKey, TValue>? EEMNIONBNAD, [Optional] Action<TValue>? NHFILGLCFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4F641B0", Offset = "0x4F62FB0", VA = "0x184F641B0")]
	public MMLLOANHJIJ<TValue> DDMFCGNGLKI(TKey MAKJJJECHHB, [Optional] Func<TKey, TValue>? ECOIPEHJOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4F64E30", Offset = "0x4F63C30", VA = "0x184F64E30")]
	private void OJKDNIEEGBG(TKey MAKJJJECHHB, GABNDMPENEC GCODILMMCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4F647B0", Offset = "0x4F635B0", VA = "0x184F647B0")]
	public void NMDOMIGMDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4F65250", Offset = "0x4F64050", VA = "0x184F65250")]
	public ACLNNAHMELK PHEMDOOJNPF()
	{
		return default(ACLNNAHMELK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4F65290", Offset = "0x4F64090", VA = "0x184F65290", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4F65290", Offset = "0x4F64090", VA = "0x184F65290", Slot = "5")]
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
