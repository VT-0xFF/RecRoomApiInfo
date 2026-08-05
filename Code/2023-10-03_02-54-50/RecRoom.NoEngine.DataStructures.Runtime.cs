using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D1E080", Offset = "0x5D1C880", VA = "0x185D1E080")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78AB20", VA = "0x18078C320")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C360", Offset = "0x78AB60", VA = "0x18078C360")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GBDMLLLEICI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected GBDMLLLEICI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class BCCGEJEDJEH<T> : GBDMLLLEICI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct CLCFAHFHHDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum EFBBHMNOKMD
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
		public EFBBHMNOKMD BJKOKHNAAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T POMIBLHGGHJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int FNOPFBAEAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool JMFDIJGPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool MKDCBNNMINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? KPDJEAMJMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<CLCFAHFHHDF>? IAMFNKDDEII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BBPGJMMADDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x45B2130", Offset = "0x45B0930", VA = "0x1845B2130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x45B2180", Offset = "0x45B0980", VA = "0x1845B2180")]
	protected BCCGEJEDJEH(bool MKDCBNNMINL, bool JMFDIJGPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x45B2090", Offset = "0x45B0890", VA = "0x1845B2090")]
	protected bool PBKFEJAKELH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x45B1E10", Offset = "0x45B0610", VA = "0x1845B1E10")]
	protected void ONMDHNKPEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x45B18A0", Offset = "0x45B00A0", VA = "0x1845B18A0")]
	protected void ACCEDFGMOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9BA0", Offset = "0x2BE83A0", VA = "0x182BE9BA0")]
	private static void EOHBOPANHJH<U>(List<U>? KAEOEAACCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x45B1A80", Offset = "0x45B0280", VA = "0x1845B1A80", Slot = "4")]
	public void EIGFNHEIDIC(T POMIBLHGGHJ, bool GBCGIMMPHCL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x45B1C60", Offset = "0x45B0460", VA = "0x1845B1C60", Slot = "5")]
	public void OICBJJIPNIH(T POMIBLHGGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x45B1F10", Offset = "0x45B0710", VA = "0x1845B1F10")]
	public void PAMPKEGOCOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OONPFNOAGKA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIGFNHEIDIC(Action POMIBLHGGHJ, bool GBCGIMMPHCL = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OICBJJIPNIH(Action POMIBLHGGHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class CAPEMHJDAJL : BCCGEJEDJEH<Action>, OONPFNOAGKA
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BC70", Offset = "0x5D1A470", VA = "0x185D1BC70")]
	public CAPEMHJDAJL(bool MKDCBNNMINL = false, bool JMFDIJGPLEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B9B0", Offset = "0x5D1A1B0", VA = "0x185D1B9B0")]
	public void AOLJJLOPFJO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BBB0", Offset = "0x5D1A3B0", VA = "0x185D1BBB0")]
	public static CAPEMHJDAJL EJKNLBJGLML(CAPEMHJDAJL LCKNOBGODAO, Action POMIBLHGGHJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BC10", Offset = "0x5D1A410", VA = "0x185D1BC10")]
	public static CAPEMHJDAJL HHBBDIHEKMH(CAPEMHJDAJL LCKNOBGODAO, Action POMIBLHGGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NADCIELGEHN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIGFNHEIDIC(Action<T> POMIBLHGGHJ, bool GBCGIMMPHCL = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OICBJJIPNIH(Action<T> POMIBLHGGHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class KACIPEPFJMN<T> : BCCGEJEDJEH<Action<T>>, NADCIELGEHN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x30165D0", Offset = "0x3014DD0", VA = "0x1830165D0")]
	public KACIPEPFJMN(bool MKDCBNNMINL = false, bool JMFDIJGPLEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3887B70", Offset = "0x3886370", VA = "0x183887B70")]
	public void AOLJJLOPFJO(T KIDCMEILBJC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3388480", Offset = "0x3386C80", VA = "0x183388480")]
	public static KACIPEPFJMN<T> EJKNLBJGLML(KACIPEPFJMN<T> LCKNOBGODAO, Action<T> POMIBLHGGHJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3388510", Offset = "0x3386D10", VA = "0x183388510")]
	public static KACIPEPFJMN<T> HHBBDIHEKMH(KACIPEPFJMN<T> LCKNOBGODAO, Action<T> POMIBLHGGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GGHGMCJBKOO<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class HCEMLEPIKPN<T, U> : BCCGEJEDJEH<Action<T, U>>, GGHGMCJBKOO<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x30165D0", Offset = "0x3014DD0", VA = "0x1830165D0")]
	public HCEMLEPIKPN(bool MKDCBNNMINL = false, bool JMFDIJGPLEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3513B80", Offset = "0x3512380", VA = "0x183513B80")]
	public void AOLJJLOPFJO(T KIDCMEILBJC, U KBDNNIDFEPH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3388480", Offset = "0x3386C80", VA = "0x183388480")]
	public static HCEMLEPIKPN<T, U> EJKNLBJGLML(HCEMLEPIKPN<T, U> LCKNOBGODAO, Action<T, U> POMIBLHGGHJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3388510", Offset = "0x3386D10", VA = "0x183388510")]
	public static HCEMLEPIKPN<T, U> HHBBDIHEKMH(HCEMLEPIKPN<T, U> LCKNOBGODAO, Action<T, U> POMIBLHGGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class FFKBLJBPHHC<T, U, V> : BCCGEJEDJEH<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x30165D0", Offset = "0x3014DD0", VA = "0x1830165D0")]
	public FFKBLJBPHHC(bool MKDCBNNMINL = false, bool JMFDIJGPLEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x33858F0", Offset = "0x33840F0", VA = "0x1833858F0")]
	public void AOLJJLOPFJO(T KIDCMEILBJC, U KBDNNIDFEPH, V LONCAANPFDA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3388480", Offset = "0x3386C80", VA = "0x183388480")]
	public static FFKBLJBPHHC<T, U, V> EJKNLBJGLML(FFKBLJBPHHC<T, U, V> LCKNOBGODAO, Action<T, U, V> POMIBLHGGHJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3388510", Offset = "0x3386D10", VA = "0x183388510")]
	public static FFKBLJBPHHC<T, U, V> HHBBDIHEKMH(FFKBLJBPHHC<T, U, V> LCKNOBGODAO, Action<T, U, V> POMIBLHGGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BDGNDIPFCOO<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MOECOAMNIEE<T, U, V, W> : BCCGEJEDJEH<Action<T, U, V, W>>, BDGNDIPFCOO<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x30165D0", Offset = "0x3014DD0", VA = "0x1830165D0")]
	public MOECOAMNIEE(bool MKDCBNNMINL = false, bool JMFDIJGPLEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3BF1460", Offset = "0x3BEFC60", VA = "0x183BF1460")]
	public void AOLJJLOPFJO(T KIDCMEILBJC, U KBDNNIDFEPH, V LONCAANPFDA, W ELBAMOGBINL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3388480", Offset = "0x3386C80", VA = "0x183388480")]
	public static MOECOAMNIEE<T, U, V, W> EJKNLBJGLML(MOECOAMNIEE<T, U, V, W> LCKNOBGODAO, Action<T, U, V, W> POMIBLHGGHJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3388510", Offset = "0x3386D10", VA = "0x183388510")]
	public static MOECOAMNIEE<T, U, V, W> HHBBDIHEKMH(MOECOAMNIEE<T, U, V, W> LCKNOBGODAO, Action<T, U, V, W> POMIBLHGGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OHDJOEBHHBJ<T, U, V, W, X> : BCCGEJEDJEH<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30165D0", Offset = "0x3014DD0", VA = "0x1830165D0")]
	public OHDJOEBHHBJ(bool MKDCBNNMINL = false, bool JMFDIJGPLEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3DA6C10", Offset = "0x3DA5410", VA = "0x183DA6C10")]
	public void AOLJJLOPFJO(T KIDCMEILBJC, U KBDNNIDFEPH, V LONCAANPFDA, W ELBAMOGBINL, X GEKAGOANEHP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3388480", Offset = "0x3386C80", VA = "0x183388480")]
	public static OHDJOEBHHBJ<T, U, V, W, X> EJKNLBJGLML(OHDJOEBHHBJ<T, U, V, W, X> LCKNOBGODAO, Action<T, U, V, W, X> POMIBLHGGHJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3388510", Offset = "0x3386D10", VA = "0x183388510")]
	public static OHDJOEBHHBJ<T, U, V, W, X> HHBBDIHEKMH(OHDJOEBHHBJ<T, U, V, W, X> LCKNOBGODAO, Action<T, U, V, W, X> POMIBLHGGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class JGIOBDMHMOH<T, U, V, W, X, Y> : BCCGEJEDJEH<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x30165D0", Offset = "0x3014DD0", VA = "0x1830165D0")]
	public JGIOBDMHMOH(bool MKDCBNNMINL = false, bool JMFDIJGPLEK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3847550", Offset = "0x3845D50", VA = "0x183847550")]
	public void AOLJJLOPFJO(T KIDCMEILBJC, U KBDNNIDFEPH, V LONCAANPFDA, W ELBAMOGBINL, X GEKAGOANEHP, Y KFCLHHAJEPI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3388480", Offset = "0x3386C80", VA = "0x183388480")]
	public static JGIOBDMHMOH<T, U, V, W, X, Y> EJKNLBJGLML(JGIOBDMHMOH<T, U, V, W, X, Y> LCKNOBGODAO, Action<T, U, V, W, X, Y> POMIBLHGGHJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3388510", Offset = "0x3386D10", VA = "0x183388510")]
	public static JGIOBDMHMOH<T, U, V, W, X, Y> HHBBDIHEKMH(JGIOBDMHMOH<T, U, V, W, X, Y> LCKNOBGODAO, Action<T, U, V, W, X, Y> POMIBLHGGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MEHLOHGPKKM<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BGGFJEOIJEE<TKey, TVal> HBLDKILFFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> BLAFKKCLKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int NDPNHODOHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly BGGFJEOIJEE<TKey, TVal>.FAPAIJFPOIP? JAOJGGLNBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int AMGJJCEKEJK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int JNFJEEFOBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BA0730", Offset = "0x3B9EF30", VA = "0x183BA0730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NAPGODGMHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x807520", Offset = "0x805D20", VA = "0x180807520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0DE0", Offset = "0x3B9F5E0", VA = "0x183BA0DE0")]
	public MEHLOHGPKKM(int NDPNHODOHDF, [Optional] BGGFJEOIJEE<TKey, TVal>.FAPAIJFPOIP? JAOJGGLNBDO, [Optional] IEqualityComparer<TKey>? JNMBKMGPHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0C10", Offset = "0x3B9F410", VA = "0x183BA0C10")]
	public void NAONMCOIBHG(TKey EBICOEDOGKC, TVal IFKKLLBODIE, bool DCENKGHDOMJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3BA05D0", Offset = "0x3B9EDD0", VA = "0x183BA05D0")]
	public bool HDKMMECAIDI(TKey EBICOEDOGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0B30", Offset = "0x3B9F330", VA = "0x183BA0B30")]
	public bool MENMFPJMHKC(TKey OPHCLNGDKCK, [Out] TVal IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0780", Offset = "0x3B9EF80", VA = "0x183BA0780")]
	private void JAMCMINGEJI(TKey EBICOEDOGKC, TVal IFKKLLBODIE, int NBNELMONDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3BA09A0", Offset = "0x3B9F1A0", VA = "0x183BA09A0")]
	public bool KMLDFEJECFP(TKey EBICOEDOGKC, TVal IFKKLLBODIE, bool DCENKGHDOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0670", Offset = "0x3B9EE70", VA = "0x183BA0670")]
	private bool IBHOOKJEAFN(TKey EBICOEDOGKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public sealed class BGGFJEOIJEE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate int FAPAIJFPOIP(TKey EBICOEDOGKC, TVal IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class PJCKMONIAOI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TKey MOOCGHOLMGB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TVal GNAEIIEFOAF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int PHCALFNEHHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x76A350", Offset = "0x768B50", VA = "0x18076A350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x76A390", Offset = "0x768B90", VA = "0x18076A390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DateTime NIEFGOKJGFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x762C80", Offset = "0x761480", VA = "0x180762C80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3E86730", Offset = "0x3E84F30", VA = "0x183E86730")]
		public PJCKMONIAOI(TKey EBICOEDOGKC, TVal HBAHLIBAHIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class AICDKFPHCJH : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public BGGFJEOIJEE<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private LinkedList<PJCKMONIAOI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD3C770", Offset = "0xD3AF70", VA = "0x180D3C770", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x35A6910", Offset = "0x35A5110", VA = "0x1835A6910", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public AICDKFPHCJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3013E30", Offset = "0x3012630", VA = "0x183013E30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x35A5E70", Offset = "0x35A4670", VA = "0x1835A5E70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x35A54A0", Offset = "0x35A3CA0", VA = "0x1835A54A0")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x35A67D0", Offset = "0x35A4FD0", VA = "0x1835A67D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int KPHFNGJCJCA = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Dictionary<TKey, LinkedListNode<PJCKMONIAOI>> PAAPGJNCCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly LinkedList<PJCKMONIAOI> IBLLPPJIGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FAPAIJFPOIP? JAOJGGLNBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly TimeSpan IAGNBEPJCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly GBGJCDHBKNF LABAAPNOPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool CHFFDOMJODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly List<TKey> CELLBHCOPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly List<TVal> DLMKKDHDABA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NAPGODGMHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77F540", Offset = "0x77DD40", VA = "0x18077F540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal int JNFJEEFOBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77F550", Offset = "0x77DD50", VA = "0x18077F550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD32310", Offset = "0xD30B10", VA = "0x180D32310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x36BC780", Offset = "0x36BAF80", VA = "0x1836BC780", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ICollection<TVal> KBMIBCAJDHF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x46B0580", Offset = "0x46AED80", VA = "0x1846B0580", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	ICollection<TKey> IDictionary<TKey, TVal>.NEBCFAJJANC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x46ADEA0", Offset = "0x46AC6A0", VA = "0x1846ADEA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FCEGNANDKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TVal NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x46B0530", Offset = "0x46AED30", VA = "0x1846B0530", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x46B05D0", Offset = "0x46AEDD0", VA = "0x1846B05D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x46A6430", Offset = "0x46A4C30", VA = "0x1846A6430")]
	private bool AHEJLMOFJEK(int OLEHEDGFINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x46A9ED0", Offset = "0x46A86D0", VA = "0x1846A9ED0")]
	private void GFFECGGDFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x46AF190", Offset = "0x46AD990", VA = "0x1846AF190")]
	public BGGFJEOIJEE(int OLEHEDGFINF, [Optional] FAPAIJFPOIP? JAOJGGLNBDO, [Optional] IEqualityComparer<TKey>? JNMBKMGPHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x46AF150", Offset = "0x46AD950", VA = "0x1846AF150")]
	public BGGFJEOIJEE(int OLEHEDGFINF, TimeSpan IAGNBEPJCEL, [Optional] IEqualityComparer<TKey>? JNMBKMGPHOK, [Optional] GBGJCDHBKNF? LABAAPNOPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x46B0090", Offset = "0x46AE890", VA = "0x1846B0090")]
	public BGGFJEOIJEE(int OLEHEDGFINF, FAPAIJFPOIP? JAOJGGLNBDO, TimeSpan IAGNBEPJCEL, [Optional] IEqualityComparer<TKey>? JNMBKMGPHOK, [Optional] GBGJCDHBKNF? LABAAPNOPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x46A9980", Offset = "0x46A8180", VA = "0x1846A9980")]
	public bool DPFKGHPKHIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x46A6730", Offset = "0x46A4F30", VA = "0x1846A6730")]
	public bool AMEBLPFMAEJ(int NBNELMONDLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x46A6210", Offset = "0x46A4A10", VA = "0x1846A6210")]
	public void ABNCEPDOIJI(TKey EBICOEDOGKC, TVal IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x46A7610", Offset = "0x46A5E10", VA = "0x1846A7610", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> AKPEBFBEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x46A7940", Offset = "0x46A6140", VA = "0x1846A7940", Slot = "9")]
	public void Add(TKey EBICOEDOGKC, TVal IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x46A8490", Offset = "0x46A6C90", VA = "0x1846A8490", Slot = "8")]
	public bool ContainsKey(TKey EBICOEDOGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x46A8490", Offset = "0x46A6C90", VA = "0x1846A8490", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x46AD7D0", Offset = "0x46ABFD0", VA = "0x1846AD7D0", Slot = "10")]
	public bool Remove(TKey EBICOEDOGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x46AD780", Offset = "0x46ABF80", VA = "0x1846AD780", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x46A7FB0", Offset = "0x46A67B0", VA = "0x1846A7FB0")]
	private TVal BCFBOGKIONB(TKey OPHCLNGDKCK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46AE600", Offset = "0x46ACE00", VA = "0x1846AE600", Slot = "11")]
	public bool TryGetValue(TKey OPHCLNGDKCK, [Out] TVal IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x46A82F0", Offset = "0x46A6AF0", VA = "0x1846A82F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x46A9640", Offset = "0x46A7E40", VA = "0x1846A9640", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] JMHHCKCLFBI, int HPIBLFHGGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x46A9B90", Offset = "0x46A8390", VA = "0x1846A9B90")]
	private bool EBIPGLMLCAE(PJCKMONIAOI KLMKLPMIBPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x46AC680", Offset = "0x46AAE80", VA = "0x1846AC680")]
	private void MIFONCJGPMB(LinkedListNode<PJCKMONIAOI> DDGHHGFGPLK, TVal EPKJMINCAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x46AB2A0", Offset = "0x46A9AA0", VA = "0x1846AB2A0")]
	private void ILFJPJIHKEG(TKey EBICOEDOGKC, TVal IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x46ABBE0", Offset = "0x46AA3E0", VA = "0x1846ABBE0")]
	private void LHGGNIOJMPH(PJCKMONIAOI KLMKLPMIBPB, TVal EPKJMINCAGG, int LJIBLBPKJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x46AA3B0", Offset = "0x46A8BB0", VA = "0x1846AA3B0", Slot = "19")]
	[IteratorStateMachine(typeof(BGGFJEOIJEE<, >.AICDKFPHCJH))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4472360", Offset = "0x4470B60", VA = "0x184472360", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct PJPBBBFNADB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
	public static PJPBBBFNADB KPKHGEOEKHP(Type BJKOKHNAAID, [Optional] string? BPFHOIJAPBD, [Optional] string? OKLCNIJADLM, bool BBANIJDKHLI = false)
	{
		return default(PJPBBBFNADB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
	public static PJPBBBFNADB KPKHGEOEKHP<T>([Optional] string? BPFHOIJAPBD, [Optional] string? OKLCNIJADLM, bool BBANIJDKHLI = false)
	{
		return default(PJPBBBFNADB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IJIOFCOGOFL
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool ILNFHBLPMFK(string JFLMAJEPJIA, IJIOFCOGOFL OOJFHAEFNKD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int CGJOJNFDJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public string KALOCKOFMEK;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D2F0", Offset = "0x5D1BAF0", VA = "0x185D1D2F0")]
	public static Dictionary<string, IJIOFCOGOFL> FOBAJLFEIAN(Type GMDNKINLLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CE00", Offset = "0x5D1B600", VA = "0x185D1CE00")]
	public static Dictionary<string, IJIOFCOGOFL> CGPGNHLLMNF(Type GMDNKINLLHN, ILNFHBLPMFK DLNDGEOEOIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CC40", Offset = "0x5D1B440", VA = "0x185D1CC40")]
	public static Dictionary<int, string> AMEMFIKFNAF(Dictionary<string, IJIOFCOGOFL> MOHHJLIGFPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AttributeUsage(AttributeTargets.Enum)]
public abstract class GDCPDFHJCNB : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string FKHKJNCPLEN(string OCFMFKJKCPM);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	protected GDCPDFHJCNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class OFFEGPLAFGN : OPCAMIHAIIG
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static bool GDDMMJIFONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly string? FBIAPBBKPOD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public virtual OPCAMIHAIIG? KFCPJCLOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E7B0", Offset = "0x5D1CFB0", VA = "0x185D1E7B0")]
	protected OFFEGPLAFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GLHFGNJEPCL();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E2C0", Offset = "0x5D1CAC0", VA = "0x185D1E2C0", Slot = "8")]
	public virtual string HANAIBGHPNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E4A0", Offset = "0x5D1CCA0", VA = "0x185D1E4A0", Slot = "9")]
	public void OCFCHOGODID(StringBuilder LLBNLBPJEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E750", Offset = "0x5D1CF50", VA = "0x185D1E750", Slot = "10")]
	public void PBCNGDKNCNH(StringBuilder LLBNLBPJEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E1A0", Offset = "0x5D1C9A0", VA = "0x185D1E1A0", Slot = "11")]
	public void EDNHEOAOOCG(StringBuilder LLBNLBPJEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E340", Offset = "0x5D1CB40", VA = "0x185D1E340", Slot = "12")]
	public void MGJAMCBGFOH(StringBuilder LLBNLBPJEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E100", Offset = "0x5D1C900", VA = "0x185D1E100")]
	public static void DDCOCMJHKKC(StringBuilder LLBNLBPJEBP, string CDONPALIHJC, string HLEDBOOCHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50BBFC0", Offset = "0x50BA7C0", VA = "0x1850BBFC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DOPMLJIMLFH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C5F0", Offset = "0x5D1ADF0", VA = "0x185D1C5F0")]
	public DOPMLJIMLFH(string LACIBLEADOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CDCAOHLJENI<TErr> : DOPMLJIMLFH where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly TErr ABAACLHBHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4A49B00", Offset = "0x4A48300", VA = "0x184A49B00")]
	private CDCAOHLJENI([In] TErr PBKDFIFKNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4A49A30", Offset = "0x4A48230", VA = "0x184A49A30")]
	public static CDCAOHLJENI<TErr> MJLGMKKAMEE([In] TErr PBKDFIFKNPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OPCAMIHAIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HANAIBGHPNN();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GLHFGNJEPCL();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JMNGDPCCELD<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	TOptions GNAEIIEFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface LOGFNDDELIF
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string NPNHMDOFLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LLIPLHDBCGE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D8F0", Offset = "0x5D1C0F0", VA = "0x185D1D8F0")]
	public LLIPLHDBCGE(string LACIBLEADOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NIJECNHOFAI<TOk> : LLIPLHDBCGE where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly TOk FPJBPMFENPE;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3CA2CD0", Offset = "0x3CA14D0", VA = "0x183CA2CD0")]
	private NIJECNHOFAI([In] TOk GHMHIEJFPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3398DE0", Offset = "0x33975E0", VA = "0x183398DE0")]
	public static NIJECNHOFAI<TOk> MJLGMKKAMEE([In] TOk GHMHIEJFPPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct ENHODGJKDIF<TOk, TErr> : IEquatable<ENHODGJKDIF<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly EqualityComparer<TErr> MHHNFEKLGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal readonly TErr ABAACLHBHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly TOk FPJBPMFENPE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool HFEJCKPOPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x302A3C0", Offset = "0x3028BC0", VA = "0x18302A3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IEFMMFCGJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x302D3A0", Offset = "0x302BBA0", VA = "0x18302D3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x302FB50", Offset = "0x302E350", VA = "0x18302FB50")]
	internal ENHODGJKDIF([In] TErr PBKDFIFKNPI, [In] TOk GHMHIEJFPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3028F70", Offset = "0x3027770", VA = "0x183028F70")]
	public static ENHODGJKDIF<TOk, TErr> CODDCMFMPCE([In] TErr PBKDFIFKNPI)
	{
		return default(ENHODGJKDIF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x302BEA0", Offset = "0x302A6A0", VA = "0x18302BEA0")]
	public static ENHODGJKDIF<TOk, TErr> IJGEFBLAGEH([In] TOk GHMHIEJFPPK)
	{
		return default(ENHODGJKDIF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0230", Offset = "0x2BEEA30", VA = "0x182BF0230")]
	public ENHODGJKDIF<UOk?, TErr?> CJOEIENHOPM<UOk>()
	{
		return default(ENHODGJKDIF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0C20", Offset = "0x2BEF420", VA = "0x182BF0C20")]
	public ENHODGJKDIF<UOk?, TErr?> EDPGEEHLKJJ<UOk>()
	{
		return default(ENHODGJKDIF<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1240", Offset = "0x2BEFA40", VA = "0x182BF1240")]
	public ENHODGJKDIF<TOk?, UErr?> MPPLBJKPICI<UErr>()
	{
		return default(ENHODGJKDIF<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x302A9C0", Offset = "0x30291C0", VA = "0x18302A9C0")]
	public ENHODGJKDIF<NLDGBPLBGDN, TErr> GIIFFAFNLOB()
	{
		return default(ENHODGJKDIF<NLDGBPLBGDN, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x302D130", Offset = "0x302B930", VA = "0x18302D130")]
	public static bool PEFPHNLEPOM([In] ENHODGJKDIF<TOk, TErr> MANEBEMOKEE, [In] ENHODGJKDIF<TOk, TErr> HOCFNIKGEJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x30294F0", Offset = "0x3027CF0", VA = "0x1830294F0", Slot = "4")]
	public bool Equals(ENHODGJKDIF<TOk, TErr> GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3029760", Offset = "0x3027F60", VA = "0x183029760", Slot = "0")]
	public override bool Equals(object GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x302B8D0", Offset = "0x302A0D0", VA = "0x18302B8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x302DA60", Offset = "0x302C260", VA = "0x18302DA60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class MMHOIOILIAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GDFMKNFBJCP<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Task<ENHODGJKDIF<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<ENHODGJKDIF<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x345F190", Offset = "0x345D990", VA = "0x18345F190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x345FAF0", Offset = "0x345E2F0", VA = "0x18345FAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EKGKPMIAKGA<TOk, TErr> : IEnumerable<TOk>, IEnumerable, IEnumerator<TOk>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TOk <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IEnumerable<ENHODGJKDIF<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IEnumerable<ENHODGJKDIF<TOk, TErr>> <>3__self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<ENHODGJKDIF<TOk, TErr>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		TOk? IEnumerator<TOk>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (TOk?)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public EKGKPMIAKGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3013E30", Offset = "0x3012630", VA = "0x183013E30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x30139C0", Offset = "0x30121C0", VA = "0x1830139C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3013970", Offset = "0x3012170", VA = "0x183013970")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3013DE0", Offset = "0x30125E0", VA = "0x183013DE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3013CF0", Offset = "0x30124F0", VA = "0x183013CF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TOk?>? IEnumerable<TOk>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3013DB0", Offset = "0x30125B0", VA = "0x183013DB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator? IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2370A60", Offset = "0x236F260", VA = "0x182370A60")]
	public static ENHODGJKDIF<TOk?, TErr?> FPJBPMFENPE<TOk, TErr>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [In] TOk GHMHIEJFPPK)
	{
		return default(ENHODGJKDIF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x24765E0", Offset = "0x2474DE0", VA = "0x1824765E0")]
	public static ENHODGJKDIF<NLDGBPLBGDN, TErr?> FPJBPMFENPE<TErr>([In] this ENHODGJKDIF<NLDGBPLBGDN, TErr> CLEGCKJMIEA)
	{
		return default(ENHODGJKDIF<NLDGBPLBGDN, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2370A60", Offset = "0x236F260", VA = "0x182370A60")]
	public static ENHODGJKDIF<TOk?, TErr?> ABAACLHBHCJ<TOk, TErr>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [In] TErr PBKDFIFKNPI)
	{
		return default(ENHODGJKDIF<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x24755F0", Offset = "0x2473DF0", VA = "0x1824755F0")]
	public static TOk? BAJANKHNLJM<TOk, TErr>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2475130", Offset = "0x2473930", VA = "0x182475130")]
	[AsyncStateMachine(typeof(GDFMKNFBJCP<, >))]
	public static Task<TOk?>? BAFHONDLOCN<TOk, TErr>(this Task<ENHODGJKDIF<TOk, TErr>> CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2476C60", Offset = "0x2475460", VA = "0x182476C60")]
	public static TErr? NAEOHCEALIA<TErr, TOk>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2475820", Offset = "0x2474020", VA = "0x182475820")]
	public static bool BJOBMKBGGGC<TOk, TErr, UErr, UOk>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [Out] ENHODGJKDIF<UOk, UErr> LFAFGALAHLH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x24767F0", Offset = "0x2474FF0", VA = "0x1824767F0")]
	public static bool MNNENIGNGJD<TOk, TErr>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [Out][NotNullWhen(true)] TOk GHMHIEJFPPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2476610", Offset = "0x2474E10", VA = "0x182476610")]
	public static bool JBMOEMBJDIK<TOk, TErr>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [Out][NotNullWhen(true)] TErr PBKDFIFKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x24764F0", Offset = "0x2474CF0", VA = "0x1824764F0")]
	public static bool EAAJIMCPBNF<TOk, TErr>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [Out][NotNullWhen(true)] TOk GHMHIEJFPPK, [Out][NotNullWhen(false)] TErr PBKDFIFKNPI) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x24766F0", Offset = "0x2474EF0", VA = "0x1824766F0")]
	public static bool JNOHOAGJBNO<TOk, TErr>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [Out][NotNullWhen(true)] TOk GHMHIEJFPPK, [Out] ENHODGJKDIF<TOk, TErr> LFAFGALAHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2475930", Offset = "0x2474130", VA = "0x182475930")]
	public static bool BJOBMKBGGGC<TOk, TErr, UErr, UOk>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [Out][NotNullWhen(true)] TOk GHMHIEJFPPK, [Out] ENHODGJKDIF<UOk, UErr> LFAFGALAHLH) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2476930", Offset = "0x2475130", VA = "0x182476930")]
	public static bool MPIJICBMDIE<TOk, TErr>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [Out][NotNullWhen(true)] TOk GHMHIEJFPPK, [Out] ENHODGJKDIF<NLDGBPLBGDN, TErr> LFAFGALAHLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2474E10", Offset = "0x2473610", VA = "0x182474E10")]
	public static ENHODGJKDIF<UOk, UErr> ABNHOKPNDLB<UOk, UErr, TOk, TErr>([In] this ENHODGJKDIF<TOk, TErr> CLEGCKJMIEA, [In] ENHODGJKDIF<UOk, UErr> JJPCCHMLAMH) where TOk : UOk where TErr : UErr
	{
		return default(ENHODGJKDIF<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2476F20", Offset = "0x2475720", VA = "0x182476F20")]
	public static ENHODGJKDIF<TOk?[]?, TErr?> NENPGGEPCLN<TOk, TErr>(this IEnumerable<ENHODGJKDIF<TOk, TErr>> CLEGCKJMIEA)
	{
		return default(ENHODGJKDIF<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2203E00", Offset = "0x2202600", VA = "0x182203E00")]
	[IteratorStateMachine(typeof(EKGKPMIAKGA<, >))]
	public static IEnumerable<TOk?>? EDJGBGODEIM<TOk, TErr>(this IEnumerable<ENHODGJKDIF<TOk, TErr>> CLEGCKJMIEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HBKCGFENCEP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2BF7AE0", Offset = "0x2BF62E0", VA = "0x182BF7AE0")]
	public static ENHODGJKDIF<TOk, T> FPJBPMFENPE<TOk>([In] TOk GHMHIEJFPPK) where TOk : notnull
	{
		return default(ENHODGJKDIF<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3510230", Offset = "0x350EA30", VA = "0x183510230")]
	public static ENHODGJKDIF<NLDGBPLBGDN, T> FPJBPMFENPE()
	{
		return default(ENHODGJKDIF<NLDGBPLBGDN, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2BF7AE0", Offset = "0x2BF62E0", VA = "0x182BF7AE0")]
	public static ENHODGJKDIF<T, TErr> ABAACLHBHCJ<TErr>([In] TErr PBKDFIFKNPI) where TErr : notnull
	{
		return default(ENHODGJKDIF<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public sealed class AJIELPGPAMD<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private readonly struct NKHCMEAPKKD : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly AJIELPGPAMD<T> KCPCDEJOIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int KKEOLJFBLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool HGFFINOIFDA;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1B52A40", Offset = "0x1B51240", VA = "0x181B52A40")]
		public NKHCMEAPKKD(AJIELPGPAMD<T> HJDEGHPGGHF, int HNOOPFEFPGO, bool FKJDAKDGICF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3CAC200", Offset = "0x3CAAA00", VA = "0x183CAC200")]
		public AJIELPGPAMD<T>.PIFHGOBPAJM NNHLEKOBGNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3CAC2F0", Offset = "0x3CAAAF0", VA = "0x183CAC2F0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3CAC2F0", Offset = "0x3CAAAF0", VA = "0x183CAC2F0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class PIFHGOBPAJM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly AJIELPGPAMD<T> KCPCDEJOIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int EMGFMOGHKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int AMHLDCKKKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool HGFFINOIFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool HODGHDKAKGO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3E84FE0", Offset = "0x3E837E0", VA = "0x183E84FE0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3E850C0", Offset = "0x3E838C0", VA = "0x183E850C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x3E85170", Offset = "0x3E83970", VA = "0x183E85170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3E857D0", Offset = "0x3E83FD0", VA = "0x183E857D0")]
		public PIFHGOBPAJM(AJIELPGPAMD<T> HJDEGHPGGHF, int HNOOPFEFPGO, bool FKJDAKDGICF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3E84F10", Offset = "0x3E83710", VA = "0x183E84F10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3E850A0", Offset = "0x3E838A0", VA = "0x183E850A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EJGECNBGEMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public EJGECNBGEMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3004DD0", Offset = "0x30035D0", VA = "0x183004DD0")]
		internal T GCCBPAJHLKB(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] IPMCACLEKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int AMHLDCKKKED;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int DHHEPFLADMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x36BE7B0", Offset = "0x36BCFB0", VA = "0x1836BE7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T IODFMFKEHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x336B4C0", Offset = "0x3369CC0", VA = "0x18336B4C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T KHHFJDADMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x36BE780", Offset = "0x36BCF80", VA = "0x1836BE780")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x36BE680", Offset = "0x36BCE80", VA = "0x1836BE680")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int FPGKKKADJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x14F7080", Offset = "0x14F5880", VA = "0x1814F7080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xE1BAE0", Offset = "0xE1A2E0", VA = "0x180E1BAE0")]
	private static int ANJGBPDLBLK(int ADMJKDLHPCI, int OOHKMCMOCLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x36BEBA0", Offset = "0x36BD3A0", VA = "0x1836BEBA0")]
	public AJIELPGPAMD(int NBNELMONDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x36BEA20", Offset = "0x36BD220", VA = "0x1836BEA20")]
	public AJIELPGPAMD(int NBNELMONDLK, Func<T> ILPPDFODFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x36BED50", Offset = "0x36BD550", VA = "0x1836BED50")]
	public AJIELPGPAMD(T[] GBFGDEFHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x36BE800", Offset = "0x36BD000", VA = "0x1836BE800")]
	public void IHGMOGDLOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x36BE830", Offset = "0x36BD030", VA = "0x1836BE830")]
	public IEnumerable<T> LEBIAOMJLBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x36BE8F0", Offset = "0x36BD0F0", VA = "0x1836BE8F0")]
	public AJIELPGPAMD<T>.PIFHGOBPAJM NNHLEKOBGNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3402D20", Offset = "0x3401520", VA = "0x183402D20", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3402D20", Offset = "0x3401520", VA = "0x183402D20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PGGNMCONEMK
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2503270", Offset = "0x2501A70", VA = "0x182503270")]
	public static AJIELPGPAMD<T> MJLGMKKAMEE<T>(int NBNELMONDLK, Func<T> ILPPDFODFIA) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private const float kEpsilon = 1E-05f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1C32140", Offset = "0x1C30940", VA = "0x181C32140")]
		public RRColor(float LLIOFJLHJFC, float PKHEGKMOOGK, float FCOICCIGANJ, float FABNAGLLOKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E820", Offset = "0x5D1D020", VA = "0x185D1E820", Slot = "4")]
		public bool Equals(RRColor GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E8A0", Offset = "0x5D1D0A0", VA = "0x185D1E8A0", Slot = "0")]
		public override bool Equals(object GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E9A0", Offset = "0x5D1D1A0", VA = "0x185D1E9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EA20", Offset = "0x5D1D220", VA = "0x185D1EA20", Slot = "5")]
		public string ToString(string NODJEJKFPPC, IFormatProvider FHPGHGGFHIO)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class KBMLOHNKBCG<TData> : OFFEGPLAFGN where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly string IMLLLDFFNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly TData KJPNLGBHIKP;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
	public override string GLHFGNJEPCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x388B570", Offset = "0x3889D70", VA = "0x18388B570")]
	internal KBMLOHNKBCG(string LACIBLEADOC, [In] TData KOIMDAJNDOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class CHGDHPAEBML
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x21FD170", Offset = "0x21FB970", VA = "0x1821FD170")]
	public static KBMLOHNKBCG<TData> MJLGMKKAMEE<TData>(string LACIBLEADOC, [In] TData KOIMDAJNDOD) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class MEJBHHIKLFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly Dictionary<object, float> KDNBIEKMCCL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float GFOAMJJMOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7EEE70", Offset = "0x7ED670", VA = "0x1807EEE70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EEF10", Offset = "0x7ED710", VA = "0x1807EEF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DA80", Offset = "0x5D1C280", VA = "0x185D1DA80")]
	public void ILFJPJIHKEG(float IFKKLLBODIE, object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DAF0", Offset = "0x5D1C2F0", VA = "0x185D1DAF0")]
	public void PKADHLMMDID(object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D950", Offset = "0x5D1C150", VA = "0x185D1D950")]
	private void EOKHJJDPDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DB60", Offset = "0x5D1C360", VA = "0x185D1DB60")]
	public MEJBHHIKLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class NELEHEIHCBI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class KNKLPOGPCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public KNKLPOGPCOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x38EBFB0", Offset = "0x38EA7B0", VA = "0x1838EBFB0")]
		internal int BPBBHLNNCBC(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private HashSet<T>? KBHMBCGILAG;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<T> OMIDDCKBIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0310", Offset = "0x3C9EB10", VA = "0x183CA0310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool FAHMMLLCJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3CA04B0", Offset = "0x3C9ECB0", VA = "0x183CA04B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x76CBA0", Offset = "0x76B3A0", VA = "0x18076CBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x76C460", Offset = "0x76AC60", VA = "0x18076C460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0340", Offset = "0x3C9EB40", VA = "0x183CA0340")]
	public bool EIGFNHEIDIC(T PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3CA04F0", Offset = "0x3C9ECF0", VA = "0x183CA04F0")]
	public bool OICBJJIPNIH(T PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3CA02D0", Offset = "0x3C9EAD0", VA = "0x183CA02D0")]
	public bool ADJIAADNNIO(T PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3CA0610", Offset = "0x3C9EE10", VA = "0x183CA0610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public NELEHEIHCBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MICACFBJMJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly string OIIJBLKMBHE;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	public MICACFBJMJM(string OIIJBLKMBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DE00", Offset = "0x5D1C600", VA = "0x185D1DE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class EHNBFHMIMBB
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class HKDMBAHCCIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public HKDMBAHCCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5D1CAF0", Offset = "0x5D1B2F0", VA = "0x185D1CAF0")]
		internal int BPBBHLNNCBC(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<object>? KBHMBCGILAG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public IReadOnlyCollection<object> OMIDDCKBIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C720", Offset = "0x5D1AF20", VA = "0x185D1C720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FAHMMLLCJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C890", Offset = "0x5D1B090", VA = "0x185D1C890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x76CBA0", Offset = "0x76B3A0", VA = "0x18076CBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x76C460", Offset = "0x76AC60", VA = "0x18076C460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C7B0", Offset = "0x5D1AFB0", VA = "0x185D1C7B0")]
	public bool EIGFNHEIDIC(object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C8A0", Offset = "0x5D1B0A0", VA = "0x185D1C8A0")]
	public bool OICBJJIPNIH(object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C650", Offset = "0x5D1AE50", VA = "0x185D1C650")]
	public bool ADJIAADNNIO(object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C6B0", Offset = "0x5D1AEB0", VA = "0x185D1C6B0")]
	public void AOPGNDMPPCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C940", Offset = "0x5D1B140", VA = "0x185D1C940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public EHNBFHMIMBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class APNBCEAKKAE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct KNLMHNLLNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float CLLPKPBFFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public T GNAEIIEFOAF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<object, KNLMHNLLNCJ> KDNBIEKMCCL;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public virtual T BDLIIOCMMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xD3C770", Offset = "0xD3AF70", VA = "0x180D3C770", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD3BD50", Offset = "0xD3A550", VA = "0x180D3BD50", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public object? JICONLEEIKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HKJJLGAHODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x38AA5E0", Offset = "0x38A8DE0", VA = "0x1838AA5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x38AA810", Offset = "0x38A9010", VA = "0x1838AA810")]
	public bool ILFJPJIHKEG(T IFKKLLBODIE, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3039600", Offset = "0x3037E00", VA = "0x183039600")]
	public bool PKADHLMMDID(object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x38AC7C0", Offset = "0x38AAFC0", VA = "0x1838AC7C0")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x38AC520", Offset = "0x38AAD20", VA = "0x1838AC520")]
	public bool MENMFPJMHKC(object PIPCHJCEPPJ, [Out] T IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x38AAE30", Offset = "0x38A9630", VA = "0x1838AAE30")]
	[CNPEGLLENCJ("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool MBBCFLDLHPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x38AC7F0", Offset = "0x38AAFF0", VA = "0x1838AC7F0")]
	public APNBCEAKKAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface IDDPBALIJFA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event GFCOEMPEOME NADBLLBKOEK;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class CIFBALEPACJ : IDDPBALIJFA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct KNCFLODJFEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public readonly float KCFNLKKNBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly float EOKLOOHPCNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		internal readonly bool NLJMBAJEDED;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float PHCALFNEHHF
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5D1D620", Offset = "0x5D1BE20", VA = "0x185D1D620")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D790", Offset = "0x5D1BF90", VA = "0x185D1D790")]
		public KNCFLODJFEK(float IAIBEBECMJB, float BMNCKBBLELB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D630", Offset = "0x5D1BE30", VA = "0x185D1D630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class ICFBPOJKHHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CIFBALEPACJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public ICFBPOJKHHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D1CBA0", Offset = "0x5D1B3A0", VA = "0x185D1CBA0")]
		internal void FKPDIDGCFEE(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly int OLEHEDGFINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int OCDFNJCHKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly IDDPBALIJFA[] FOLMOLLDEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GFCOEMPEOME[] PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly KNCFLODJFEK[] DIPGNPBMBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private KNCFLODJFEK LOJACMBCFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NLICGJDEPPG HPKMHKNEFFP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event GFCOEMPEOME NADBLLBKOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BF30", Offset = "0x5D1A730", VA = "0x185D1BF30", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BDE0", Offset = "0x5D1A5E0", VA = "0x185D1BDE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C460", Offset = "0x5D1AC60", VA = "0x185D1C460")]
	public CIFBALEPACJ(int OLEHEDGFINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BEA0", Offset = "0x5D1A6A0", VA = "0x185D1BEA0")]
	public NLICGJDEPPG GNILMDLLJGG(KNCFLODJFEK FCJNLPFLEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BFF0", Offset = "0x5D1A7F0", VA = "0x185D1BFF0")]
	public void PJMILEMBGBG(IDDPBALIJFA NLPDKJIOBPD, [Optional] KNCFLODJFEK LOBEJFDFIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BCD0", Offset = "0x5D1A4D0", VA = "0x185D1BCD0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public delegate void GFCOEMPEOME(float OHGIGMABAEG);
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MFBGAIBHPGA
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class MGHIJHDNGCJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly IDDPBALIJFA AANFIHJPKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly GFCOEMPEOME ELLFKJCIDIE;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DD70", Offset = "0x5D1C570", VA = "0x185D1DD70")]
		public MGHIJHDNGCJ(IDDPBALIJFA AANFIHJPKNA, GFCOEMPEOME ELLFKJCIDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DD20", Offset = "0x5D1C520", VA = "0x185D1DD20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DBF0", Offset = "0x5D1C3F0", VA = "0x185D1DBF0")]
	internal static bool DEJKENPEJPA(float FABNAGLLOKN, float FCOICCIGANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D14E60", Offset = "0x5D13660", VA = "0x185D14E60")]
	internal static float JFMKFEHFFFG(float FABNAGLLOKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DC60", Offset = "0x5D1C460", VA = "0x185D1DC60")]
	public static IDisposable MFOKDMMNPCB(this IDDPBALIJFA AANFIHJPKNA, GFCOEMPEOME ELLFKJCIDIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NLICGJDEPPG : IDDPBALIJFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private float OHGIGMABAEG;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float MBKJBDKIBAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DEF0", Offset = "0x5D1C6F0", VA = "0x185D1DEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event GFCOEMPEOME? NADBLLBKOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DFE0", Offset = "0x5D1C7E0", VA = "0x185D1DFE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DE50", Offset = "0x5D1C650", VA = "0x185D1DE50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public NLICGJDEPPG()
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
