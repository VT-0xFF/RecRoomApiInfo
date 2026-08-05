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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x866E2E0", Offset = "0x866C8E0", VA = "0x18866E2E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class KICJMIHPKND
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	protected KICJMIHPKND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class PIHJFEGNIKA<T> : KICJMIHPKND
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LNHLJBIDMFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum CDFOHPEOKOB
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
		public CDFOHPEOKOB GPEIAHGICNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T PMBBLAOPHON;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int AGKBJCGANCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool NDNFBMMFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool OJBOEMFNHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? CGHLAFOGEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LNHLJBIDMFO>? JBOJBIIKHHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EMGEDMBHGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CD5560", Offset = "0x5CD3B60", VA = "0x185CD5560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5A80", Offset = "0x5CD4080", VA = "0x185CD5A80")]
	protected PIHJFEGNIKA(bool OJBOEMFNHKD, bool NDNFBMMFMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5340", Offset = "0x5CD3940", VA = "0x185CD5340")]
	protected bool CIMPNNAAAJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5CD55B0", Offset = "0x5CD3BB0", VA = "0x185CD55B0")]
	protected void IGNCOJMKNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD56C0", Offset = "0x5CD3CC0", VA = "0x185CD56C0")]
	protected void JEJKIABKBBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x45448B0", Offset = "0x4542EB0", VA = "0x1845448B0")]
	private static void JBCIDHJIDGJ<U>(List<U>? BBBJHCKNPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD58A0", Offset = "0x5CD3EA0", VA = "0x185CD58A0", Slot = "4")]
	public void MEFAAGOGBHI(T PMBBLAOPHON, bool FLPBJDIFFIC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD5180", Offset = "0x5CD3780", VA = "0x185CD5180", Slot = "5")]
	public void CBELOMAGFLH(T PMBBLAOPHON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD53E0", Offset = "0x5CD39E0", VA = "0x185CD53E0")]
	public void ELFNJAKNOMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HLLOFHFLNHG : PIHJFEGNIKA<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x866C1B0", Offset = "0x866A7B0", VA = "0x18866C1B0")]
	public HLLOFHFLNHG(bool OJBOEMFNHKD = false, bool NDNFBMMFMFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x866BFB0", Offset = "0x866A5B0", VA = "0x18866BFB0")]
	public void MJPLNPACNDN()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x866BEF0", Offset = "0x866A4F0", VA = "0x18866BEF0")]
	public static HLLOFHFLNHG BGHMHPJMNJI(HLLOFHFLNHG JHAGHAOKEBF, Action PMBBLAOPHON)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x866BF50", Offset = "0x866A550", VA = "0x18866BF50")]
	public static HLLOFHFLNHG DEKCJECNCNM(HLLOFHFLNHG JHAGHAOKEBF, Action PMBBLAOPHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CFHDKOCLDFO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEFAAGOGBHI(Action<T> PMBBLAOPHON, bool FLPBJDIFFIC = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBELOMAGFLH(Action<T> PMBBLAOPHON);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class PKBDHHCMFJK<T> : PIHJFEGNIKA<Action<T>>, CFHDKOCLDFO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4FF38C0", Offset = "0x4FF1EC0", VA = "0x184FF38C0")]
	public PKBDHHCMFJK(bool OJBOEMFNHKD = false, bool NDNFBMMFMFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CDA580", Offset = "0x5CD8B80", VA = "0x185CDA580")]
	public void MJPLNPACNDN(T DHDFDKFCOJK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4FF14C0", Offset = "0x4FEFAC0", VA = "0x184FF14C0")]
	public static PKBDHHCMFJK<T> BGHMHPJMNJI(PKBDHHCMFJK<T> JHAGHAOKEBF, Action<T> PMBBLAOPHON)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1550", Offset = "0x4FEFB50", VA = "0x184FF1550")]
	public static PKBDHHCMFJK<T> DEKCJECNCNM(PKBDHHCMFJK<T> JHAGHAOKEBF, Action<T> PMBBLAOPHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DPFKNCBAICB<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEFAAGOGBHI(Action<T, U> PMBBLAOPHON, bool FLPBJDIFFIC = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBELOMAGFLH(Action<T, U> PMBBLAOPHON);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class FCCGMMLDHAB<T, U> : PIHJFEGNIKA<Action<T, U>>, DPFKNCBAICB<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4FF38C0", Offset = "0x4FF1EC0", VA = "0x184FF38C0")]
	public FCCGMMLDHAB(bool OJBOEMFNHKD = false, bool NDNFBMMFMFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4FF34F0", Offset = "0x4FF1AF0", VA = "0x184FF34F0")]
	public void MJPLNPACNDN(T DHDFDKFCOJK, U GLJBDGPDADB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF14C0", Offset = "0x4FEFAC0", VA = "0x184FF14C0")]
	public static FCCGMMLDHAB<T, U> BGHMHPJMNJI(FCCGMMLDHAB<T, U> JHAGHAOKEBF, Action<T, U> PMBBLAOPHON)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1550", Offset = "0x4FEFB50", VA = "0x184FF1550")]
	public static FCCGMMLDHAB<T, U> DEKCJECNCNM(FCCGMMLDHAB<T, U> JHAGHAOKEBF, Action<T, U> PMBBLAOPHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class KBNGHJAFOPM<T, U, V> : PIHJFEGNIKA<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4FF38C0", Offset = "0x4FF1EC0", VA = "0x184FF38C0")]
	public KBNGHJAFOPM(bool OJBOEMFNHKD = false, bool NDNFBMMFMFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55DE9C0", Offset = "0x55DCFC0", VA = "0x1855DE9C0")]
	public void MJPLNPACNDN(T DHDFDKFCOJK, U GLJBDGPDADB, V KMDIJJMODFC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4FF14C0", Offset = "0x4FEFAC0", VA = "0x184FF14C0")]
	public static KBNGHJAFOPM<T, U, V> BGHMHPJMNJI(KBNGHJAFOPM<T, U, V> JHAGHAOKEBF, Action<T, U, V> PMBBLAOPHON)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1550", Offset = "0x4FEFB50", VA = "0x184FF1550")]
	public static KBNGHJAFOPM<T, U, V> DEKCJECNCNM(KBNGHJAFOPM<T, U, V> JHAGHAOKEBF, Action<T, U, V> PMBBLAOPHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CLHIPNHDDKD<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class OOAGDELKNBO<T, U, V, W> : PIHJFEGNIKA<Action<T, U, V, W>>, CLHIPNHDDKD<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4FF38C0", Offset = "0x4FF1EC0", VA = "0x184FF38C0")]
	public OOAGDELKNBO(bool OJBOEMFNHKD = false, bool NDNFBMMFMFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BDFFE0", Offset = "0x5BDE5E0", VA = "0x185BDFFE0")]
	public void MJPLNPACNDN(T DHDFDKFCOJK, U GLJBDGPDADB, V KMDIJJMODFC, W KCJIIGKAPGH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4FF14C0", Offset = "0x4FEFAC0", VA = "0x184FF14C0")]
	public static OOAGDELKNBO<T, U, V, W> BGHMHPJMNJI(OOAGDELKNBO<T, U, V, W> JHAGHAOKEBF, Action<T, U, V, W> PMBBLAOPHON)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1550", Offset = "0x4FEFB50", VA = "0x184FF1550")]
	public static OOAGDELKNBO<T, U, V, W> DEKCJECNCNM(OOAGDELKNBO<T, U, V, W> JHAGHAOKEBF, Action<T, U, V, W> PMBBLAOPHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class GMOOGDBJMGO<T, U, V, W, X> : PIHJFEGNIKA<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4FF38C0", Offset = "0x4FF1EC0", VA = "0x184FF38C0")]
	public GMOOGDBJMGO(bool OJBOEMFNHKD = false, bool NDNFBMMFMFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x50FD6E0", Offset = "0x50FBCE0", VA = "0x1850FD6E0")]
	public void MJPLNPACNDN(T DHDFDKFCOJK, U GLJBDGPDADB, V KMDIJJMODFC, W KCJIIGKAPGH, X GBNAKFLHCOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4FF14C0", Offset = "0x4FEFAC0", VA = "0x184FF14C0")]
	public static GMOOGDBJMGO<T, U, V, W, X> BGHMHPJMNJI(GMOOGDBJMGO<T, U, V, W, X> JHAGHAOKEBF, Action<T, U, V, W, X> PMBBLAOPHON)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1550", Offset = "0x4FEFB50", VA = "0x184FF1550")]
	public static GMOOGDBJMGO<T, U, V, W, X> DEKCJECNCNM(GMOOGDBJMGO<T, U, V, W, X> JHAGHAOKEBF, Action<T, U, V, W, X> PMBBLAOPHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class INCNMIEOAAG<T, U, V, W, X, Y> : PIHJFEGNIKA<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4FF38C0", Offset = "0x4FF1EC0", VA = "0x184FF38C0")]
	public INCNMIEOAAG(bool OJBOEMFNHKD = false, bool NDNFBMMFMFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x52A0F70", Offset = "0x529F570", VA = "0x1852A0F70")]
	public void MJPLNPACNDN(T DHDFDKFCOJK, U GLJBDGPDADB, V KMDIJJMODFC, W KCJIIGKAPGH, X GBNAKFLHCOE, Y ODEKEFJCIIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4FF14C0", Offset = "0x4FEFAC0", VA = "0x184FF14C0")]
	public static INCNMIEOAAG<T, U, V, W, X, Y> BGHMHPJMNJI(INCNMIEOAAG<T, U, V, W, X, Y> JHAGHAOKEBF, Action<T, U, V, W, X, Y> PMBBLAOPHON)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1550", Offset = "0x4FEFB50", VA = "0x184FF1550")]
	public static INCNMIEOAAG<T, U, V, W, X, Y> DEKCJECNCNM(INCNMIEOAAG<T, U, V, W, X, Y> JHAGHAOKEBF, Action<T, U, V, W, X, Y> PMBBLAOPHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HLOFGBHHKNF<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EDLIELBBKKA<TKey, TVal> EPJLGLEKJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> NLOPFEBPMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EDLIELBBKKA<TKey, TVal>.KFHIEKIKDAA? AAGFNFPNDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int BDOJMLPNLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EDLIELBBKKA<TKey, TVal>.CACILHECDMA? AHGPAFKPODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int HMDEDDCIFLI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int CEJEIKHCFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5172D60", Offset = "0x5171360", VA = "0x185172D60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int MEPOLPJPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5172DB0", Offset = "0x51713B0", VA = "0x185172DB0")]
	public HLOFGBHHKNF(int BDOJMLPNLJC, [Optional] EDLIELBBKKA<TKey, TVal>.CACILHECDMA? AHGPAFKPODO, [Optional] IEqualityComparer<TKey>? LMLHBNLBBJD, [Optional] EDLIELBBKKA<TKey, TVal>.KFHIEKIKDAA? AAGFNFPNDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x51724A0", Offset = "0x5170AA0", VA = "0x1851724A0")]
	public void EGHABELGNOI(TKey HAELBKGFDIJ, TVal KOPHBHGIACG, bool ILEPPLHMDFB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x51729D0", Offset = "0x5170FD0", VA = "0x1851729D0")]
	public bool OJPNLIJEOEE(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x51723C0", Offset = "0x51709C0", VA = "0x1851723C0")]
	public bool DCJACLLMOIN(TKey KAIPGEJNEGO, [Out] TVal KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5172B00", Offset = "0x5171100", VA = "0x185172B00")]
	private void PHPDIPOCEHB(TKey HAELBKGFDIJ, TVal KOPHBHGIACG, int KCJLCGFEBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5172230", Offset = "0x5170830", VA = "0x185172230")]
	public bool CMFFLPGNLCO(TKey HAELBKGFDIJ, TVal KOPHBHGIACG, bool ILEPPLHMDFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5172670", Offset = "0x5170C70", VA = "0x185172670")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5171D20", Offset = "0x5170320", VA = "0x185171D20")]
	private void CKJCONFKFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x51726D0", Offset = "0x5170CD0", VA = "0x1851726D0")]
	private bool FFDNCGNAABB(TKey HAELBKGFDIJ, DABOAGHMIOC LEILDDGFOJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x51727C0", Offset = "0x5170DC0", VA = "0x1851727C0")]
	private void FGNMPAKHLAH(TKey HAELBKGFDIJ, TVal KOPHBHGIACG, DABOAGHMIOC LEILDDGFOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51728A0", Offset = "0x5170EA0", VA = "0x1851728A0")]
	private void FMMCPDDAIPA(TKey HAELBKGFDIJ, TVal IKJAADLGNCL, DABOAGHMIOC LEILDDGFOJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NLGCHIJPNNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DJBJNJCFMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool BEFLPMBHHOC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public NLGCHIJPNNM(Action JAIKONNCDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x866E2A0", Offset = "0x866C8A0", VA = "0x18866E2A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x330B660", Offset = "0x3309C60", VA = "0x18330B660")]
	public static GCAHIIHOLJP<T> CEAHGFMKGJD<T>(T KOPHBHGIACG, Action JAIKONNCDEB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GCAHIIHOLJP<T> : NLGCHIJPNNM where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50AEBD0", Offset = "0x50AD1D0", VA = "0x1850AEBD0")]
	public GCAHIIHOLJP(T KOPHBHGIACG, Action JAIKONNCDEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class GBOLJMJFPLE<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly LJPFNMAKOME<T>? HLKOPDEOGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> POHGCCEILHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool BEFLPMBHHOC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly GBOLJMJFPLE<T> HPOBBIFAPGN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> AMNNHFIAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50AE0D0", Offset = "0x50AC6D0", VA = "0x1850AE0D0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x50ADBB0", Offset = "0x50AC1B0", VA = "0x1850ADBB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DEKPKOANCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x50ADCF0", Offset = "0x50AC2F0", VA = "0x1850ADCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x50AE760", Offset = "0x50ACD60", VA = "0x1850AE760")]
	public GBOLJMJFPLE(LJPFNMAKOME<T> EGLCENFMMID, LJPFNMAKOME<T> FENBNGPMMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x50AE310", Offset = "0x50AC910", VA = "0x1850AE310")]
	public GBOLJMJFPLE(LJPFNMAKOME<T> EGLCENFMMID, int NDMFOILAFKD, LJPFNMAKOME<T> FENBNGPMMKP, int GNCMIFFAFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x50AE6B0", Offset = "0x50ACCB0", VA = "0x1850AE6B0")]
	private GBOLJMJFPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x50ADC70", Offset = "0x50AC270", VA = "0x1850ADC70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x50AE030", Offset = "0x50AC630", VA = "0x1850AE030")]
	public T[] NGACLBPFFMM()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x50ADE70", Offset = "0x50AC470", VA = "0x1850ADE70")]
	public static ReadOnlySequence<T> HNGLNPFKABH(GBOLJMJFPLE<T>? LAEKKNGHGBK)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GECDCPJKIPO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable NNKCBHNLPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T CECIKJNPCJO;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x50EB620", Offset = "0x50E9C20", VA = "0x1850EB620")]
	public GECDCPJKIPO(IDisposable PCLFJGMAHBI, [In] T KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x44A6CE0", Offset = "0x44A52E0", VA = "0x1844A6CE0")]
	public static GECDCPJKIPO<U> JINDHMOLMFE<U>([In] GECDCPJKIPO<T> PCLFJGMAHBI, [In] U KOPHBHGIACG) where U : notnull
	{
		return default(GECDCPJKIPO<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x50EB530", Offset = "0x50E9B30", VA = "0x1850EB530", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class OPELICMJCMM
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3F86230", Offset = "0x3F84830", VA = "0x183F86230")]
	public static GECDCPJKIPO<T> CPNHECDILPK<T>(IDisposable PCLFJGMAHBI, [In] T KOPHBHGIACG) where T : notnull
	{
		return default(GECDCPJKIPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3F86290", Offset = "0x3F84890", VA = "0x183F86290")]
	public static GECDCPJKIPO<T> JJNNKCJNPLD<T>([In] this GECDCPJKIPO<T> JNMMMBJNOND, [Out] T KOPHBHGIACG) where T : notnull
	{
		return default(GECDCPJKIPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3DBFDA0", Offset = "0x3DBE3A0", VA = "0x183DBFDA0")]
	public static GECDCPJKIPO<U?> JINDHMOLMFE<U, T>([In] GECDCPJKIPO<T> NEIOJGMEAGC, [In] U KOPHBHGIACG)
	{
		return default(GECDCPJKIPO<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct BIMENMEPEPN : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct IOLHHMLLFLG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
		public static IOLHHMLLFLG CPNHECDILPK()
		{
			return default(IOLHHMLLFLG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x866B850", Offset = "0x8669E50", VA = "0x18866B850")]
	public static string ILJNPPLHCCE(Type GPEIAHGICNA, [Optional] string? DDBPJLOKLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3B61410", Offset = "0x3B5FA10", VA = "0x183B61410")]
	public static string? ILJNPPLHCCE<T>([Optional] string? DDBPJLOKLME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3B61390", Offset = "0x3B5F990", VA = "0x183B61390")]
	public static string? BIPEEEMDNPF<T>([Optional] string? JGHGPAMKPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
	public static BIMENMEPEPN IJMKJHNKLOK(string DDBPJLOKLME, string? JGHGPAMKPFB)
	{
		return default(BIMENMEPEPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BBGBKPDDAHI
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool GCFCNADHKKD(string DMKACBHNBKJ, BBGBKPDDAHI FOHEODKIEHI);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class LGMILPHGLME<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LGMILPHGLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x57C8100", Offset = "0x57C6700", VA = "0x1857C8100")]
		internal void KFADAGKCBAD(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int KCKCBGONOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string PFFNJAFFEAK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x866AFD0", Offset = "0x86695D0", VA = "0x18866AFD0")]
	public static Dictionary<string, BBGBKPDDAHI> NONFABNAMHK(Type EFHHFOIKMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3B54DF0", Offset = "0x3B533F0", VA = "0x183B54DF0")]
	public static Dictionary<string, BBGBKPDDAHI> NONFABNAMHK<T>(Type EFHHFOIKMLM, IReadOnlyDictionary<T, string> LHMIAKNKNHB) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3B54730", Offset = "0x3B52D30", VA = "0x183B54730")]
	public static Dictionary<string, BBGBKPDDAHI> DDJHFEBBONF<T>(List<T> EOMHPFPEDME) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x866AC10", Offset = "0x8669210", VA = "0x18866AC10")]
	public static Dictionary<string, BBGBKPDDAHI> KCCDOFELKMF(Type EFHHFOIKMLM, GCFCNADHKKD HPLPIBIPHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x866AA50", Offset = "0x8669050", VA = "0x18866AA50")]
	public static Dictionary<int, string> FFPBDKMNKOE(Dictionary<string, BBGBKPDDAHI> NGOJMGCIOHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class OJGPKPIMJAI : EHNKGHFFBGH
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool KOAMPMDAODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? GHLNGFNEENL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual EHNKGHFFBGH? AJIFHCLOFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x866EAB0", Offset = "0x866D0B0", VA = "0x18866EAB0")]
	protected OJGPKPIMJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GAEFJPMCOGL();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x866E620", Offset = "0x866CC20", VA = "0x18866E620", Slot = "8")]
	public virtual string FJPEHIICMAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x866E800", Offset = "0x866CE00", VA = "0x18866E800", Slot = "9")]
	public void KNKMDOBANEN(StringBuilder GLBOAFALJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x866E5C0", Offset = "0x866CBC0", VA = "0x18866E5C0", Slot = "10")]
	public void EBKGEIFIFCD(StringBuilder GLBOAFALJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x866E4A0", Offset = "0x866CAA0", VA = "0x18866E4A0", Slot = "11")]
	public void DHBBIOLGHOA(StringBuilder GLBOAFALJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x866E6A0", Offset = "0x866CCA0", VA = "0x18866E6A0", Slot = "12")]
	public void GJBIPGBECKI(StringBuilder GLBOAFALJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x866E400", Offset = "0x866CA00", VA = "0x18866E400")]
	public static void CFMJDCJNCHO(StringBuilder GLBOAFALJBG, string PPIKFHNMOAN, string DKGOKOBOEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7517280", Offset = "0x7515880", VA = "0x187517280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JGBANPOGAPK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x866C2F0", Offset = "0x866A8F0", VA = "0x18866C2F0")]
	public JGBANPOGAPK(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class DGOMDFGDKHL<TErr> : JGBANPOGAPK where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr NLHGOEDHIIH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x465A710", Offset = "0x4658D10", VA = "0x18465A710")]
	private DGOMDFGDKHL([In] TErr HFADGGDNMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x465A640", Offset = "0x4658C40", VA = "0x18465A640")]
	public static DGOMDFGDKHL<TErr> CPNHECDILPK([In] TErr HFADGGDNMMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KFADJKKEEEE : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm MIPGPKCIFAN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool EFNKKHNNFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool JBIMDEPOBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool LJLAALFDDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x866C680", Offset = "0x866AC80", VA = "0x18866C680", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long PGBNPPMBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x866C6F0", Offset = "0x866ACF0", VA = "0x18866C6F0", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x866C760", Offset = "0x866AD60", VA = "0x18866C760", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x866C610", Offset = "0x866AC10", VA = "0x18866C610")]
	public KFADJKKEEEE(HashAlgorithm MIPGPKCIFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x866C430", Offset = "0x866AA30", VA = "0x18866C430", Slot = "35")]
	public override int Read(byte[] DNGAEEFBGGO, int PIOCNHLFCNE, int LMJBLNOIBOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x866C5E0", Offset = "0x866ABE0", VA = "0x18866C5E0", Slot = "38")]
	public override void Write(byte[] DNGAEEFBGGO, int PIOCNHLFCNE, int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x866C4D0", Offset = "0x866AAD0", VA = "0x18866C4D0", Slot = "33")]
	public override long Seek(long PIOCNHLFCNE, SeekOrigin BKLMKFANNGB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x866C560", Offset = "0x866AB60", VA = "0x18866C560", Slot = "34")]
	public override void SetLength(long KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x866C350", Offset = "0x866A950", VA = "0x18866C350")]
	public byte[] KKPBLEHEELE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface EHNKGHFFBGH
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FJPEHIICMAG();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GAEFJPMCOGL();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface AGMDMCDFNPP<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface CICLJCHHDKC
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string EBFEFJCNMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class LJPFNMAKOME<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static LJPFNMAKOME<T>? OCEJDPAPFAD;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object MGMODJOEHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? KAKOFFOIGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool BEFLPMBHHOC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JNKPFBIAHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAFF680", Offset = "0xAFDC80", VA = "0x180AFF680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x57CDAA0", Offset = "0x57CC0A0", VA = "0x1857CDAA0")]
	private static LJPFNMAKOME<T> IMCAAIAFNBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x57CDF40", Offset = "0x57CC540", VA = "0x1857CDF40")]
	private static void KAKJMEJAFAK(LJPFNMAKOME<T> OKONKGPFIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x52AED10", Offset = "0x52AD310", VA = "0x1852AED10")]
	private LJPFNMAKOME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x57CD180", Offset = "0x57CB780", VA = "0x1857CD180")]
	public static LJPFNMAKOME<T> CEAHGFMKGJD(ReadOnlyMemory<T> CAOLIPOOLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x57CCDB0", Offset = "0x57CB3B0", VA = "0x1857CCDB0")]
	public static LJPFNMAKOME<T> CEAHGFMKGJD(IMemoryOwner<T> DKHHDKMJLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x57CD340", Offset = "0x57CB940", VA = "0x1857CD340")]
	public static void CFKCFKGGIMC(LJPFNMAKOME<T> EGLCENFMMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x57CD690", Offset = "0x57CBC90", VA = "0x1857CD690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x57CD9D0", Offset = "0x57CBFD0", VA = "0x1857CD9D0")]
	public LJPFNMAKOME<T> HGBCLCOEBGB(IMemoryOwner<T> DKHHDKMJLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x57CCBD0", Offset = "0x57CB1D0", VA = "0x1857CCBD0")]
	private void CCMHAEDLIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x57CD8C0", Offset = "0x57CBEC0", VA = "0x1857CD8C0")]
	private LJPFNMAKOME<T> FJIELLOCEON(LJPFNMAKOME<T> OKONKGPFIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HNPLGGDJLDE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x866C210", Offset = "0x866A810", VA = "0x18866C210")]
	public HNPLGGDJLDE(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class ILNKBNDIHNO<TOk> : HNPLGGDJLDE where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk AODOELJHGCL;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x529E340", Offset = "0x529C940", VA = "0x18529E340")]
	private ILNKBNDIHNO([In] TOk PKNIKFNGJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x529E0F0", Offset = "0x529C6F0", VA = "0x18529E0F0")]
	public static ILNKBNDIHNO<TOk> CPNHECDILPK([In] TOk PKNIKFNGJHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MBLHOBJNMHG : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly ReadOnlySequence<byte> POHGCCEILHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private SequencePosition GGCEEAPMIDB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override bool EFNKKHNNFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override bool JBIMDEPOBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override bool LJLAALFDDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public override long AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x866DF00", Offset = "0x866C500", VA = "0x18866DF00", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override long PGBNPPMBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x866DF60", Offset = "0x866C560", VA = "0x18866DF60", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x866E030", Offset = "0x866C630", VA = "0x18866E030", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x866DE30", Offset = "0x866C430", VA = "0x18866DE30")]
	public MBLHOBJNMHG(ReadOnlySequence<byte> LAEKKNGHGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x866D9E0", Offset = "0x866BFE0", VA = "0x18866D9E0", Slot = "33")]
	public override long Seek(long PIOCNHLFCNE, SeekOrigin BKLMKFANNGB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x866D560", Offset = "0x866BB60", VA = "0x18866D560", Slot = "35")]
	public override int Read(byte[] DNGAEEFBGGO, int PIOCNHLFCNE, int LMJBLNOIBOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x866DD70", Offset = "0x866C370", VA = "0x18866DD70", Slot = "34")]
	public override void SetLength(long KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x866DDD0", Offset = "0x866C3D0", VA = "0x18866DDD0", Slot = "38")]
	public override void Write(byte[] DNGAEEFBGGO, int PIOCNHLFCNE, int LMJBLNOIBOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct CKPAOGHIJHA<TOk, TErr> : IEquatable<CKPAOGHIJHA<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly EqualityComparer<TErr> MFANGOBKANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly TErr NLHGOEDHIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal readonly TOk AODOELJHGCL;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NFNEIONOPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA1600", Offset = "0x6F9FC00", VA = "0x186FA1600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BNDJHDGAEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9FF60", Offset = "0x6F9E560", VA = "0x186F9FF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5560", Offset = "0x6FA3B60", VA = "0x186FA5560")]
	internal CKPAOGHIJHA([In] TErr HFADGGDNMMA, [In] TOk PKNIKFNGJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9FEA0", Offset = "0x6F9E4A0", VA = "0x186F9FEA0")]
	public static CKPAOGHIJHA<TOk, TErr> GHEHLKDNPFI([In] TErr HFADGGDNMMA)
	{
		return default(CKPAOGHIJHA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DBB0", Offset = "0x6F9C1B0", VA = "0x186F9DBB0")]
	public static CKPAOGHIJHA<TOk, TErr> ABCAAHDKMFA([In] TOk PKNIKFNGJHF)
	{
		return default(CKPAOGHIJHA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3F34F30", Offset = "0x3F33530", VA = "0x183F34F30")]
	public CKPAOGHIJHA<TOk?, UErr?> LFJDFKMDEEJ<UErr>()
	{
		return default(CKPAOGHIJHA<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3F35730", Offset = "0x3F33D30", VA = "0x183F35730")]
	public CKPAOGHIJHA<UOk?, TErr?> MMOBOBOIOPB<UOk>()
	{
		return default(CKPAOGHIJHA<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3F33DF0", Offset = "0x3F323F0", VA = "0x183F33DF0")]
	public CKPAOGHIJHA<UOk?, TErr?> HKBFDIMCGBC<UOk>()
	{
		return default(CKPAOGHIJHA<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3F35840", Offset = "0x3F33E40", VA = "0x183F35840")]
	public CKPAOGHIJHA<TOk?, UErr?> OCLJIHAKGLE<UErr>()
	{
		return default(CKPAOGHIJHA<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E280", Offset = "0x6F9C880", VA = "0x186F9E280")]
	public CKPAOGHIJHA<IHJGGHCFJKD, TErr> CJMMAPCCKOC()
	{
		return default(CKPAOGHIJHA<IHJGGHCFJKD, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FA2D40", Offset = "0x6FA1340", VA = "0x186FA2D40")]
	public static bool MGLHCKHANFO([In] CKPAOGHIJHA<TOk, TErr> NEOIFOEJGFD, [In] CKPAOGHIJHA<TOk, TErr> KNACFLNMNOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E6D0", Offset = "0x6F9CCD0", VA = "0x186F9E6D0", Slot = "4")]
	public bool Equals(CKPAOGHIJHA<TOk, TErr> AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F9ED30", Offset = "0x6F9D330", VA = "0x186F9ED30", Slot = "0")]
	public override bool Equals(object AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FA0920", Offset = "0x6F9EF20", VA = "0x186FA0920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FA4D70", Offset = "0x6FA3370", VA = "0x186FA4D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class GAFFHPHNIMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct JCLOLPIFHFL<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Task<CKPAOGHIJHA<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<CKPAOGHIJHA<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x54B6F50", Offset = "0x54B5550", VA = "0x1854B6F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4679950", Offset = "0x4677F50", VA = "0x184679950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private struct MMDANJIGOAI<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<IHJGGHCFJKD, TErr>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Task<CKPAOGHIJHA<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<CKPAOGHIJHA<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5A1C6F0", Offset = "0x5A1ACF0", VA = "0x185A1C6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4FFA6D0", Offset = "0x4FF8CD0", VA = "0x184FFA6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct OBPMIPGHCIM<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Task<CKPAOGHIJHA<TOk, TErr>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<CKPAOGHIJHA<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5B965F0", Offset = "0x5B94BF0", VA = "0x185B965F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5B96BE0", Offset = "0x5B951E0", VA = "0x185B96BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3840", Offset = "0x3DD1E40", VA = "0x183DD3840")]
	public static CKPAOGHIJHA<TOk?, TErr?> AODOELJHGCL<TOk, TErr>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [In] TOk PKNIKFNGJHF)
	{
		return default(CKPAOGHIJHA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3960", Offset = "0x3DD1F60", VA = "0x183DD3960")]
	public static CKPAOGHIJHA<IHJGGHCFJKD, TErr?> AODOELJHGCL<TErr>([In] this CKPAOGHIJHA<IHJGGHCFJKD, TErr> JNMMMBJNOND)
	{
		return default(CKPAOGHIJHA<IHJGGHCFJKD, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3840", Offset = "0x3DD1E40", VA = "0x183DD3840")]
	public static CKPAOGHIJHA<TOk?, TErr?> NLHGOEDHIIH<TOk, TErr>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [In] TErr HFADGGDNMMA)
	{
		return default(CKPAOGHIJHA<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5D20", Offset = "0x3DD4320", VA = "0x183DD5D20")]
	public static TOk? GEMMKGODOHF<TOk, TErr>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6C70", Offset = "0x3DD5270", VA = "0x183DD6C70")]
	[AsyncStateMachine(typeof(JCLOLPIFHFL<, >))]
	public static Task<TOk?>? IPGHINJOAHB<TOk, TErr>(this Task<CKPAOGHIJHA<TOk, TErr>> JNMMMBJNOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6690", Offset = "0x3DD4C90", VA = "0x183DD6690")]
	public static TErr? IEDPJEAJKMB<TErr, TOk>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4220", Offset = "0x3DD2820", VA = "0x183DD4220")]
	public static bool DKGMAGJFPCF<TOk, TErr, UErr, UOk>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [Out] CKPAOGHIJHA<UOk, UErr> DPJDNHFKCDJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5190", Offset = "0x3DD3790", VA = "0x183DD5190")]
	public static bool FMMOFDIFHMJ<TOk, TErr>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [Out] TOk PKNIKFNGJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3DD70D0", Offset = "0x3DD56D0", VA = "0x183DD70D0")]
	public static bool JFLJOPBDLJE<TOk, TErr>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [Out][NotNullWhen(true)] TErr HFADGGDNMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6400", Offset = "0x3DD4A00", VA = "0x183DD6400")]
	public static bool HCFCHDGNFPP<TOk, TErr>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [Out][NotNullWhen(true)] TOk PKNIKFNGJHF, [Out][NotNullWhen(false)] TErr HFADGGDNMMA) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6600", Offset = "0x3DD4C00", VA = "0x183DD6600")]
	public static bool HJOAPHLNDAH<TOk, TErr>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [Out][NotNullWhen(true)] TOk PKNIKFNGJHF, [Out] CKPAOGHIJHA<TOk, TErr> DPJDNHFKCDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3DA0", Offset = "0x3DD23A0", VA = "0x183DD3DA0")]
	public static bool DKGMAGJFPCF<TOk, TErr, UErr, UOk>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [Out][NotNullWhen(true)] TOk PKNIKFNGJHF, [Out] CKPAOGHIJHA<UOk, UErr> DPJDNHFKCDJ) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3DD72E0", Offset = "0x3DD58E0", VA = "0x183DD72E0")]
	public static bool JPENFNJHNDK<TOk, TErr>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [Out][NotNullWhen(true)] TOk PKNIKFNGJHF, [Out] CKPAOGHIJHA<IHJGGHCFJKD, TErr> DPJDNHFKCDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3DD5420", Offset = "0x3DD3A20", VA = "0x183DD5420")]
	public static CKPAOGHIJHA<UOk, UErr> GBMFCJBFJFJ<UOk, UErr, TOk, TErr>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, [In] CKPAOGHIJHA<UOk, UErr> APAPCLFINDP) where TOk : UOk where TErr : UErr
	{
		return default(CKPAOGHIJHA<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3A60", Offset = "0x3DD2060", VA = "0x183DD3A60")]
	public static CKPAOGHIJHA<TOk?[]?, TErr?> BAKNIEIMGPF<TOk, TErr>(this IEnumerable<CKPAOGHIJHA<TOk, TErr>> JNMMMBJNOND)
	{
		return default(CKPAOGHIJHA<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7820", Offset = "0x3DD5E20", VA = "0x183DD7820")]
	public static CKPAOGHIJHA<UOk?, TErr?> OGFENCLDCDN<UOk, TErr, TOk>([In] this CKPAOGHIJHA<TOk, TErr> JNMMMBJNOND, Func<TOk, UOk> NKMAKGKPOFA)
	{
		return default(CKPAOGHIJHA<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3DD6AB0", Offset = "0x3DD50B0", VA = "0x183DD6AB0")]
	[AsyncStateMachine(typeof(MMDANJIGOAI<, >))]
	public static Task<CKPAOGHIJHA<IHJGGHCFJKD, TErr?>>? IMPFDAPGDDO<TErr, TOk>(this Task<CKPAOGHIJHA<TOk, TErr>> JNMMMBJNOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7640", Offset = "0x3DD5C40", VA = "0x183DD7640")]
	[AsyncStateMachine(typeof(OBPMIPGHCIM<, >))]
	public static Task<bool>? NFNEIONOPLK<TOk, TErr>(this Task<CKPAOGHIJHA<TOk, TErr>> DIAHJIAKEPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LMMLGJCNABL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x453B4B0", Offset = "0x4539AB0", VA = "0x18453B4B0")]
	public static CKPAOGHIJHA<TOk, T> AODOELJHGCL<TOk>([In] TOk PKNIKFNGJHF) where TOk : notnull
	{
		return default(CKPAOGHIJHA<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x57D65F0", Offset = "0x57D4BF0", VA = "0x1857D65F0")]
	public static CKPAOGHIJHA<IHJGGHCFJKD, T> AODOELJHGCL()
	{
		return default(CKPAOGHIJHA<IHJGGHCFJKD, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x453B430", Offset = "0x4539A30", VA = "0x18453B430")]
	public static CKPAOGHIJHA<T, TErr> NLHGOEDHIIH<TErr>([In] TErr HFADGGDNMMA) where TErr : notnull
	{
		return default(CKPAOGHIJHA<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct PCDDBKHEBOL<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PDCCMHEHOGH MFPBNJIHLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly Dictionary<TKey, TValue> GDCBDAPGCLH;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4B34290", Offset = "0x4B32890", VA = "0x184B34290")]
	public static PCDDBKHEBOL<TKey, TValue> CPNHECDILPK(string JIFPJFGEAIK)
	{
		return default(PCDDBKHEBOL<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B34460", Offset = "0x4B32A60", VA = "0x184B34460")]
	internal PCDDBKHEBOL(Dictionary<TKey, TValue> KOPHBHGIACG, PDCCMHEHOGH GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B343B0", Offset = "0x4B329B0", VA = "0x184B343B0")]
	public MBNJHPLPPKP<TKey, TValue> FCEBBHANMIL([Out] Dictionary<TKey, TValue> KOPHBHGIACG)
	{
		return default(MBNJHPLPPKP<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct MBNJHPLPPKP<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly Dictionary<TKey, TValue> GDCBDAPGCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly LDOCEEKNGJG LOECHKCOHFA;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2DC1F30", Offset = "0x2DC0530", VA = "0x182DC1F30")]
	internal MBNJHPLPPKP(Dictionary<TKey, TValue> KOPHBHGIACG, LDOCEEKNGJG NHIGIHOCAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4AFEB10", Offset = "0x4AFD110", VA = "0x184AFEB10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct EGEALAFENLN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PDCCMHEHOGH MFPBNJIHLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<T> GDCBDAPGCLH;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B34290", Offset = "0x4B32890", VA = "0x184B34290")]
	public static EGEALAFENLN<T> CPNHECDILPK(string JIFPJFGEAIK)
	{
		return default(EGEALAFENLN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B34460", Offset = "0x4B32A60", VA = "0x184B34460")]
	internal EGEALAFENLN(HashSet<T> KOPHBHGIACG, PDCCMHEHOGH GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B343B0", Offset = "0x4B329B0", VA = "0x184B343B0")]
	public ECJPCAEHLHG<T> FCEBBHANMIL([Out] HashSet<T> KOPHBHGIACG)
	{
		return default(ECJPCAEHLHG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct ECJPCAEHLHG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly HashSet<T> GDCBDAPGCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LDOCEEKNGJG LOECHKCOHFA;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2DC1F30", Offset = "0x2DC0530", VA = "0x182DC1F30")]
	internal ECJPCAEHLHG(HashSet<T> KOPHBHGIACG, LDOCEEKNGJG NHIGIHOCAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4AFEB10", Offset = "0x4AFD110", VA = "0x184AFEB10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct AAHAIBEEMCF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly PDCCMHEHOGH MFPBNJIHLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly Stack<T> GDCBDAPGCLH;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B34290", Offset = "0x4B32890", VA = "0x184B34290")]
	public static AAHAIBEEMCF<T> CPNHECDILPK(string JIFPJFGEAIK)
	{
		return default(AAHAIBEEMCF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4B34460", Offset = "0x4B32A60", VA = "0x184B34460")]
	internal AAHAIBEEMCF(Stack<T> KOPHBHGIACG, PDCCMHEHOGH GNNBACCGFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4B343B0", Offset = "0x4B329B0", VA = "0x184B343B0")]
	public MEABIFEHMCI<T> FCEBBHANMIL([Out] Stack<T> KOPHBHGIACG)
	{
		return default(MEABIFEHMCI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct MEABIFEHMCI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly Stack<T> GDCBDAPGCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly LDOCEEKNGJG LOECHKCOHFA;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2DC1F30", Offset = "0x2DC0530", VA = "0x182DC1F30")]
	internal MEABIFEHMCI(Stack<T> KOPHBHGIACG, LDOCEEKNGJG NHIGIHOCAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4AFEB10", Offset = "0x4AFD110", VA = "0x184AFEB10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DefaultMember("Item")]
public sealed class DAJNKFFFGDM<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct AAKKOBMCICH : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly DAJNKFFFGDM<T> PIEDHHGPLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly int EKNLJCLFAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly bool ICLABFPFNJC;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x29E0DE0", Offset = "0x29DF3E0", VA = "0x1829E0DE0")]
		public AAKKOBMCICH(DAJNKFFFGDM<T> MFNKIFOCMAO, int EOIOFEHOOLF, bool OGDODDEDCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x531D730", Offset = "0x531BD30", VA = "0x18531D730")]
		public DAJNKFFFGDM<T>.ANAAMIHLFHL ABGODHCJODA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x531D820", Offset = "0x531BE20", VA = "0x18531D820", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x531D820", Offset = "0x531BE20", VA = "0x18531D820", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class ANAAMIHLFHL : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly DAJNKFFFGDM<T> PIEDHHGPLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly int FPOLOCKILFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private int DDBGNDNNLCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly bool ICLABFPFNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool BFMHELAHIFA;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x5836240", Offset = "0x5834840", VA = "0x185836240")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x58363F0", Offset = "0x58349F0", VA = "0x1858363F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x58365F0", Offset = "0x5834BF0", VA = "0x1858365F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5836800", Offset = "0x5834E00", VA = "0x185836800")]
		public ANAAMIHLFHL(DAJNKFFFGDM<T> MFNKIFOCMAO, int EOIOFEHOOLF, bool OGDODDEDCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5836340", Offset = "0x5834940", VA = "0x185836340", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x58363D0", Offset = "0x58349D0", VA = "0x1858363D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class ODPNEFOBEFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ODPNEFOBEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5BAA760", Offset = "0x5BA8D60", VA = "0x185BAA760")]
		internal T KJLMOGFJHPI(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly T[] BOIMMFJCHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private int DDBGNDNNLCH;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int BLFLGCBJGFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x462AE40", Offset = "0x4629440", VA = "0x18462AE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T MIECLPJBKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x462AEF0", Offset = "0x46294F0", VA = "0x18462AEF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T ELAEOJCGHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x462AE90", Offset = "0x4629490", VA = "0x18462AE90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x462B080", Offset = "0x4629680", VA = "0x18462B080")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x29A3DD0", Offset = "0x29A23D0", VA = "0x1829A3DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1DD3EA0", Offset = "0x1DD24A0", VA = "0x181DD3EA0")]
	private static int PPHEAHPKLIP(int PMIGBJGNLLP, int NODGHDHCBPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x462B4C0", Offset = "0x4629AC0", VA = "0x18462B4C0")]
	public DAJNKFFFGDM(int KCJLCGFEBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x462B2A0", Offset = "0x46298A0", VA = "0x18462B2A0")]
	public DAJNKFFFGDM(int KCJLCGFEBMJ, Func<T> ECPIMBBGIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x462B530", Offset = "0x4629B30", VA = "0x18462B530")]
	public DAJNKFFFGDM(T[] KBJJADJMHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x462AEC0", Offset = "0x46294C0", VA = "0x18462AEC0")]
	public void FKIPEBDJBLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x462AF20", Offset = "0x4629520", VA = "0x18462AF20")]
	public IEnumerable<T> NALKGACCOHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x462ADB0", Offset = "0x46293B0", VA = "0x18462ADB0")]
	public DAJNKFFFGDM<T>.ANAAMIHLFHL ABGODHCJODA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x462B130", Offset = "0x4629730", VA = "0x18462B130", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x462B130", Offset = "0x4629730", VA = "0x18462B130", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class IMGMIPICOBB
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3E26760", Offset = "0x3E24D60", VA = "0x183E26760")]
	public static DAJNKFFFGDM<T> CPNHECDILPK<T>(int KCJLCGFEBMJ, Func<T> ECPIMBBGIHG) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x72091C0", Offset = "0x72077C0", VA = "0x1872091C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x866FAC0", Offset = "0x866E0C0", VA = "0x18866FAC0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x866FAE0", Offset = "0x866E0E0", VA = "0x18866FAE0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x866FB00", Offset = "0x866E100", VA = "0x18866FB00")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x866FAA0", Offset = "0x866E0A0", VA = "0x18866FAA0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B490D0", Offset = "0x2B476D0", VA = "0x182B490D0")]
		public RRColor(float OCNJDNNPAAP, float GHFIGNBKOCG, float PDHHCOODKIC, float JGPEJMANNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84E6C70", Offset = "0x84E5270", VA = "0x1884E6C70", Slot = "4")]
		public bool Equals(RRColor AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x866F6F0", Offset = "0x866DCF0", VA = "0x18866F6F0", Slot = "0")]
		public override bool Equals(object AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x866F7F0", Offset = "0x866DDF0", VA = "0x18866F7F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x866F870", Offset = "0x866DE70", VA = "0x18866F870", Slot = "5")]
		public string ToString(string OFCLANOKPBA, IFormatProvider FLBMAMDHHCN)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x866F690", Offset = "0x866DC90", VA = "0x18866F690")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x866F630", Offset = "0x866DC30", VA = "0x18866F630")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x866F660", Offset = "0x866DC60", VA = "0x18866F660")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x866F6C0", Offset = "0x866DCC0", VA = "0x18866F6C0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x866F600", Offset = "0x866DC00", VA = "0x18866F600")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6391D30", Offset = "0x6390330", VA = "0x186391D30")]
		public RRColor32(byte OCNJDNNPAAP, byte GHFIGNBKOCG, byte PDHHCOODKIC, byte JGPEJMANNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x25282D0", Offset = "0x25268D0", VA = "0x1825282D0", Slot = "4")]
		public bool Equals(RRColor32 AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x866F160", Offset = "0x866D760", VA = "0x18866F160", Slot = "0")]
		public override bool Equals(object AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x15FD7A0", Offset = "0x15FBDA0", VA = "0x1815FD7A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x866F1E0", Offset = "0x866D7E0", VA = "0x18866F1E0")]
		public static RRColor32 HNGLNPFKABH(RRColor KGDLOJHDMHI)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x866F330", Offset = "0x866D930", VA = "0x18866F330")]
		public static RRColor HNGLNPFKABH(RRColor32 KGDLOJHDMHI)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x866F3A0", Offset = "0x866D9A0", VA = "0x18866F3A0", Slot = "5")]
		public string ToString(string OFCLANOKPBA, IFormatProvider FLBMAMDHHCN)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class OMLKJMOKAHF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct GDBKKLGNDNB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly OMLKJMOKAHF<T> APLFCKOJAKO;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public T CECIKJNPCJO
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x50E7C60", Offset = "0x50E6260", VA = "0x1850E7C60")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x50E7C30", Offset = "0x50E6230", VA = "0x1850E7C30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xECF2C0", Offset = "0xECD8C0", VA = "0x180ECF2C0")]
		public GDBKKLGNDNB(OMLKJMOKAHF<T> APLFCKOJAKO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct DPGBNPDPHJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public AsyncTaskMethodBuilder<GDBKKLGNDNB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public OMLKJMOKAHF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x467F510", Offset = "0x467DB10", VA = "0x18467F510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x467FED0", Offset = "0x467E4D0", VA = "0x18467FED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly SemaphoreSlim GIAMDGOJBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T DKKBNONALEH;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6740", Offset = "0x5BD4D40", VA = "0x185BD6740")]
	public OMLKJMOKAHF([In] T DKKBNONALEH, int KLFEEBDAOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6680", Offset = "0x5BD4C80", VA = "0x185BD6680")]
	public OMLKJMOKAHF([In] T DKKBNONALEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6160", Offset = "0x5BD4760", VA = "0x185BD6160", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5BD61C0", Offset = "0x5BD47C0", VA = "0x185BD61C0")]
	public GDBKKLGNDNB IBHAAPHODJE()
	{
		return default(GDBKKLGNDNB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6320", Offset = "0x5BD4920", VA = "0x185BD6320")]
	[AsyncStateMachine(typeof(OMLKJMOKAHF<>.DPGBNPDPHJA))]
	public Task<OMLKJMOKAHF<T>.GDBKKLGNDNB> PMFCPHBOJAG(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5BD61A0", Offset = "0x5BD47A0", VA = "0x185BD61A0")]
	public void FMLBEEPKPOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OLHAEBMDNKE
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x866EB20", Offset = "0x866D120", VA = "0x18866EB20")]
	public static OMLKJMOKAHF<IHJGGHCFJKD> CPNHECDILPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3310B10", Offset = "0x330F110", VA = "0x183310B10")]
	public static OMLKJMOKAHF<T> CPNHECDILPK<T>([In] T DKKBNONALEH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class LIBLBLCNAJJ<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public readonly struct AKOLFGAHFGH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly LIBLBLCNAJJ<T> IGCODBJMBHF;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public T CECIKJNPCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x5191ED0", Offset = "0x51904D0", VA = "0x185191ED0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x57A44D0", Offset = "0x57A2AD0", VA = "0x1857A44D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xECF2C0", Offset = "0xECD8C0", VA = "0x180ECF2C0")]
		internal AKOLFGAHFGH(LIBLBLCNAJJ<T> APLFCKOJAKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct HPPJCIFGCOA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly LIBLBLCNAJJ<T> IGCODBJMBHF;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public T CECIKJNPCJO
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x5191ED0", Offset = "0x51904D0", VA = "0x185191ED0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5191E30", Offset = "0x5190430", VA = "0x185191E30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xECF2C0", Offset = "0xECD8C0", VA = "0x180ECF2C0")]
		internal HPPJCIFGCOA(LIBLBLCNAJJ<T> APLFCKOJAKO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct HAEBHCMJCKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder<HPPJCIFGCOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public LIBLBLCNAJJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private OMLKJMOKAHF<IHJGGHCFJKD>.GDBKKLGNDNB <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter<OMLKJMOKAHF<IHJGGHCFJKD>.GDBKKLGNDNB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5148980", Offset = "0x5146F80", VA = "0x185148980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x467FED0", Offset = "0x467E4D0", VA = "0x18467FED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OMLKJMOKAHF<int> HANBBCJEOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly OMLKJMOKAHF<IHJGGHCFJKD> EOMCNFLKEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly OMLKJMOKAHF<IHJGGHCFJKD> OGOPEHDNDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private T OHEELJCBCIA;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x57CA380", Offset = "0x57C8980", VA = "0x1857CA380")]
	internal LIBLBLCNAJJ(OMLKJMOKAHF<int> ECBKOEFCOEJ, OMLKJMOKAHF<IHJGGHCFJKD> EDHDHFEIPLL, OMLKJMOKAHF<IHJGGHCFJKD> HIIBMECNCDM, [In] T DKKBNONALEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x57C95D0", Offset = "0x57C7BD0", VA = "0x1857C95D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x57C9DE0", Offset = "0x57C83E0", VA = "0x1857C9DE0")]
	public AKOLFGAHFGH LOKAKHLJJDB()
	{
		return default(AKOLFGAHFGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x57CA180", Offset = "0x57C8780", VA = "0x1857CA180")]
	public HPPJCIFGCOA OMIKOFLNMMP()
	{
		return default(HPPJCIFGCOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x57C9930", Offset = "0x57C7F30", VA = "0x1857C9930")]
	[AsyncStateMachine(typeof(LIBLBLCNAJJ<>.HAEBHCMJCKF))]
	public Task<LIBLBLCNAJJ<T>.HPPJCIFGCOA> KDPEOPJNPDJ(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LHLFHHOCGED
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x866D3F0", Offset = "0x866B9F0", VA = "0x18866D3F0")]
	public static LIBLBLCNAJJ<IHJGGHCFJKD> CPNHECDILPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3EB6640", Offset = "0x3EB4C40", VA = "0x183EB6640")]
	public static LIBLBLCNAJJ<T> CPNHECDILPK<T>([In] T DKKBNONALEH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class KBOFMKIIKFO<TData> : OJGPKPIMJAI where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly string ADPDLDMDHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly TData BJOBNNFAMFI;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
	public override string GAEFJPMCOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x55E0300", Offset = "0x55DE900", VA = "0x1855E0300")]
	internal KBOFMKIIKFO(string GKNICJPCIJJ, [In] TData CDDIADBJAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class JAIFOKBHIDI
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x866C270", Offset = "0x866A870", VA = "0x18866C270")]
	public static KBOFMKIIKFO<IHJGGHCFJKD> CPNHECDILPK(string GKNICJPCIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x330B660", Offset = "0x3309C60", VA = "0x18330B660")]
	public static KBOFMKIIKFO<TData> CPNHECDILPK<TData>(string GKNICJPCIJJ, [In] TData CDDIADBJAOB) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class DDGLNBLPPGF
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task ICJAFAGDNBM<in TArg>(TArg CGNPMBIJPEO, CancellationToken INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate Task<TResult> HIGKFOBJAFH<in TArg, TResult>(TArg CGNPMBIJPEO, CancellationToken INEEADCBMPK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct DFCHIJNCNPC<TArg> : IAsyncStateMachine where TArg : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public DDGLNBLPPGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public ICJAFAGDNBM<TArg> taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private CancellationTokenSource <newSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x464BA90", Offset = "0x464A090", VA = "0x18464BA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x464C0C0", Offset = "0x464A6C0", VA = "0x18464C0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct NHGKLABDFEL<TArg, TResult> : IAsyncStateMachine where TArg : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public DDGLNBLPPGF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public HIGKFOBJAFH<TArg, TResult> taskFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <newSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5A855D0", Offset = "0x5A83BD0", VA = "0x185A855D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4B54320", Offset = "0x4B52920", VA = "0x184B54320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private CancellationTokenSource? BGDFNECMDBO;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3C22CA0", Offset = "0x3C212A0", VA = "0x183C22CA0")]
	[AsyncStateMachine(typeof(DFCHIJNCNPC<>))]
	public Task CKKIIFJHCHE<TArg>(ICJAFAGDNBM<TArg> LKDNNMGKCOF, TArg CGNPMBIJPEO, [Optional] CancellationToken FMFKCOIOLLA) where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3C22DD0", Offset = "0x3C213D0", VA = "0x183C22DD0")]
	[AsyncStateMachine(typeof(NHGKLABDFEL<, >))]
	public Task<TResult> CKKIIFJHCHE<TResult, TArg>(HIGKFOBJAFH<TArg, TResult> LKDNNMGKCOF, TArg CGNPMBIJPEO, [Optional] CancellationToken FMFKCOIOLLA) where TResult : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x866BB60", Offset = "0x866A160", VA = "0x18866BB60")]
	private static void AJOMINEGOBN(CancellationTokenSource? BGDFNECMDBO, CancellationTokenSource FIPPCIBAELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x866BC80", Offset = "0x866A280", VA = "0x18866BC80")]
	private void PLHPLHKAJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x866BB80", Offset = "0x866A180", VA = "0x18866BB80")]
	private static CancellationTokenSource KNFDONMDHFP(CancellationToken FMFKCOIOLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DDGLNBLPPGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class PDCCMHEHOGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	internal bool LAOGGLDNBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly string KAPDJABNDKO;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xFC2850", Offset = "0xFC0E50", VA = "0x180FC2850")]
	private PDCCMHEHOGH(bool PNGPPAHAKBF, string NEAEJOPJHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x866F030", Offset = "0x866D630", VA = "0x18866F030")]
	public static PDCCMHEHOGH CPNHECDILPK(string NEAEJOPJHGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x866F0A0", Offset = "0x866D6A0", VA = "0x18866F0A0")]
	public LDOCEEKNGJG FCEBBHANMIL()
	{
		return default(LDOCEEKNGJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct LDOCEEKNGJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly PDCCMHEHOGH FGJKBNBIMAJ;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0xECF2C0", Offset = "0xECD8C0", VA = "0x180ECF2C0")]
	internal LDOCEEKNGJG(PDCCMHEHOGH JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x866D3D0", Offset = "0x866B9D0", VA = "0x18866D3D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class OBHIILPOOIA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OJJBAEBBNFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public OJJBAEBBNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5BB4B00", Offset = "0x5BB3100", VA = "0x185BB4B00")]
		internal int JGCLKMEOKFK(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private HashSet<T>? AMDFFAEAMFM;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyCollection<T> APIMIJKPDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5B96210", Offset = "0x5B94810", VA = "0x185B96210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool FADAEHCBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5A9D070", Offset = "0x5A9B670", VA = "0x185A9D070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5B96240", Offset = "0x5B94840", VA = "0x185B96240")]
	public bool MEFAAGOGBHI(T INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5B96060", Offset = "0x5B94660", VA = "0x185B96060")]
	public bool CBELOMAGFLH(T INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5B96020", Offset = "0x5B94620", VA = "0x185B96020")]
	public bool AOFBHNFGAFG(T INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5B96180", Offset = "0x5B94780", VA = "0x185B96180")]
	public void FHLAOPDNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5B963B0", Offset = "0x5B949B0", VA = "0x185B963B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public OBHIILPOOIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class PBCNGJENIAB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class AFOLEBKICGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AFOLEBKICGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x866A9A0", Offset = "0x8668FA0", VA = "0x18866A9A0")]
		internal int JGCLKMEOKFK(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private HashSet<object>? AMDFFAEAMFM;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public IReadOnlyCollection<object> APIMIJKPDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x866ED10", Offset = "0x866D310", VA = "0x18866ED10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FADAEHCBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x866ED00", Offset = "0x866D300", VA = "0x18866ED00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A20", Offset = "0xAB1020", VA = "0x180AB2A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x866EDA0", Offset = "0x866D3A0", VA = "0x18866EDA0")]
	public bool MEFAAGOGBHI(object INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x866EBF0", Offset = "0x866D1F0", VA = "0x18866EBF0")]
	public bool CBELOMAGFLH(object INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x866EB90", Offset = "0x866D190", VA = "0x18866EB90")]
	public bool AOFBHNFGAFG(object INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x866EC90", Offset = "0x866D290", VA = "0x18866EC90")]
	public void FHLAOPDNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x866EE80", Offset = "0x866D480", VA = "0x18866EE80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public PBCNGJENIAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FGOBJNPBLOO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct NKKDADBCJKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public float NDAPBLPIOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public T CECIKJNPCJO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<object, NKKDADBCJKP> LLNAAJAADDM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public virtual T LKMKMCDHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x12CB410", Offset = "0x12C9A10", VA = "0x1812CB410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x1CA7570", Offset = "0x1CA5B70", VA = "0x181CA7570", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public object? HNIENKBDEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xAB2A30", Offset = "0xAB1030", VA = "0x180AB2A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool OOFNGFGCBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4FFD460", Offset = "0x4FFBA60", VA = "0x184FFD460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD240", Offset = "0x4FFB840", VA = "0x184FFD240")]
	public bool KIHHIABHMFG(T KOPHBHGIACG, object INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4FFCBC0", Offset = "0x4FFB1C0", VA = "0x184FFCBC0")]
	public bool DNAKNINADLD(object INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4FFCC30", Offset = "0x4FFB230", VA = "0x184FFCC30")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4FFCB20", Offset = "0x4FFB120", VA = "0x184FFCB20")]
	public bool DCJACLLMOIN(object INEEADCBMPK, [Out] T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4FFB170", Offset = "0x4FF9770", VA = "0x184FFB170")]
	[FIBHNJGJFGF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BDHCAOCAAMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4FFD4B0", Offset = "0x4FFBAB0", VA = "0x184FFD4B0")]
	public FGOBJNPBLOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public sealed class BGICKGNAFMP : NPLMMICKBCJ<NBKBJBPEAPN>
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal class LMEIJJONFFN : IEqualityComparer<NBKBJBPEAPN>
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal static readonly LMEIJJONFFN EHBCEBDHHPE;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x866D4C0", Offset = "0x866BAC0", VA = "0x18866D4C0", Slot = "4")]
		public bool Equals(NBKBJBPEAPN GBNAKFLHCOE, NBKBJBPEAPN ODEKEFJCIIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7701840", Offset = "0x76FFE40", VA = "0x187701840", Slot = "5")]
		public int GetHashCode(NBKBJBPEAPN MPIDDJPOOMJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LMEIJJONFFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x866B4F0", Offset = "0x8669AF0", VA = "0x18866B4F0")]
	public BGICKGNAFMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x866B440", Offset = "0x8669A40", VA = "0x18866B440", Slot = "4")]
	public override bool MEFAAGOGBHI(NBKBJBPEAPN INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x866B300", Offset = "0x8669900", VA = "0x18866B300", Slot = "5")]
	public override bool CBELOMAGFLH(NBKBJBPEAPN INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x866B3B0", Offset = "0x86699B0", VA = "0x18866B3B0")]
	private static void IAIMINLFEOC(NBKBJBPEAPN INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0xB0AC60", Offset = "0xB09260", VA = "0x180B0AC60", Slot = "6")]
	protected override string TokenToString(NBKBJBPEAPN INEEADCBMPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class NBKBJBPEAPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly string AMPHNBALHIE;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0xAB22B0", Offset = "0xAB08B0", VA = "0x180AB22B0")]
	public NBKBJBPEAPN(string AMPHNBALHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x866E170", Offset = "0x866C770", VA = "0x18866E170", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class NPLMMICKBCJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly IEqualityComparer<T> HPIFCOACPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private HashSet<T>? AMDFFAEAMFM;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IReadOnlyCollection<T> APIMIJKPDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5A9D0B0", Offset = "0x5A9B6B0", VA = "0x185A9D0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool FADAEHCBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5A9D070", Offset = "0x5A9B670", VA = "0x185A9D070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xAFD490", Offset = "0xAFBA90", VA = "0x180AFD490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5A9DA70", Offset = "0x5A9C070", VA = "0x185A9DA70")]
	public NPLMMICKBCJ(IEqualityComparer<T> HPIFCOACPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5A9D260", Offset = "0x5A9B860", VA = "0x185A9D260", Slot = "4")]
	public virtual bool MEFAAGOGBHI(T INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5A9CEB0", Offset = "0x5A9B4B0", VA = "0x185A9CEB0", Slot = "5")]
	public virtual bool CBELOMAGFLH(T INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5A9CFE0", Offset = "0x5A9B5E0", VA = "0x185A9CFE0")]
	public void FHLAOPDNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5A9D6D0", Offset = "0x5A9BCD0", VA = "0x185A9D6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public sealed class EPJEHNABAGB<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private List<WeakReference<T>>? AMDFFAEAMFM;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool FADAEHCBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4B74470", Offset = "0x4B72A70", VA = "0x184B74470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4B74310", Offset = "0x4B72910", VA = "0x184B74310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4B74570", Offset = "0x4B72B70", VA = "0x184B74570")]
	public void MEFAAGOGBHI(T INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4B74190", Offset = "0x4B72790", VA = "0x184B74190")]
	public void CBELOMAGFLH(T INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4B74070", Offset = "0x4B72670", VA = "0x184B74070")]
	public bool AOFBHNFGAFG(T INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4B742F0", Offset = "0x4B728F0", VA = "0x184B742F0")]
	public void FHLAOPDNEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4B74790", Offset = "0x4B72D90", VA = "0x184B74790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public EPJEHNABAGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal static class EBAFBEEFKCE
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF7A0", Offset = "0x3BCDDA0", VA = "0x183BCF7A0")]
	public static void ABLCCENBDNE<T>(this List<T> BBBJHCKNPGO, int PMIGBJGNLLP) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HBEOBKBEAIN<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private struct EPNFKDGPPFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public float NDAPBLPIOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public T CECIKJNPCJO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<NBKBJBPEAPN, EPNFKDGPPFJ> LLNAAJAADDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly EqualityComparer<T> LMGMKJNOHFG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public virtual T LKMKMCDHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xAA54D0", Offset = "0xAA3AD0", VA = "0x180AA54D0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private NBKBJBPEAPN? HNIENKBDEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool OOFNGFGCBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4FFD460", Offset = "0x4FFBA60", VA = "0x184FFD460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5150F90", Offset = "0x514F590", VA = "0x185150F90")]
	public bool KIHHIABHMFG(T KOPHBHGIACG, NBKBJBPEAPN INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4FFCBC0", Offset = "0x4FFB1C0", VA = "0x184FFCBC0")]
	public bool DNAKNINADLD(NBKBJBPEAPN INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4FFCC30", Offset = "0x4FFB230", VA = "0x184FFCC30")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4FFC9B0", Offset = "0x4FFAFB0", VA = "0x184FFC9B0")]
	public bool DCJACLLMOIN(NBKBJBPEAPN INEEADCBMPK, [Out] T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5150BF0", Offset = "0x514F1F0", VA = "0x185150BF0")]
	[FIBHNJGJFGF("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool BDHCAOCAAMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5151070", Offset = "0x514F670", VA = "0x185151070")]
	public HBEOBKBEAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BHKBPIMJLDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<object, float> LLNAAJAADDM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public float LDEKDPAMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xB02260", Offset = "0xB00860", VA = "0x180B02260")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x13FF730", Offset = "0x13FDD30", VA = "0x1813FF730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x866B620", Offset = "0x8669C20", VA = "0x18866B620")]
	public void KIHHIABHMFG(float KOPHBHGIACG, object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x866B560", Offset = "0x8669B60", VA = "0x18866B560")]
	public void DNAKNINADLD(object INEEADCBMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x866B5D0", Offset = "0x8669BD0", VA = "0x18866B5D0")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x866B690", Offset = "0x8669C90", VA = "0x18866B690")]
	private void NNALEOOKDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x866B7C0", Offset = "0x8669DC0", VA = "0x18866B7C0")]
	public BHKBPIMJLDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface CKPIOOJBGDM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KNGNKAEBMGC KHDOPGJAFEA;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LBKFIFMFAEK : CKPIOOJBGDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct KJJFMAAJJCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly float PLMAAMEONBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly float KBLDJAMLPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		internal readonly bool GLJIKBGGLIL;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float FMLOJENFFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x866C7E0", Offset = "0x866ADE0", VA = "0x18866C7E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x866C950", Offset = "0x866AF50", VA = "0x18866C950")]
		public KJJFMAAJJCD(float GHOFJOJMCOI, float PAHJFGCGJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x866C7F0", Offset = "0x866ADF0", VA = "0x18866C7F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class ODMOHHFCGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public LBKFIFMFAEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public ODMOHHFCGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x866E360", Offset = "0x866C960", VA = "0x18866E360")]
		internal void FPDJONELICK(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly int AHIAOIDMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int PPGFPLBKDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CKPIOOJBGDM[] ANDNLOICNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly KNGNKAEBMGC[] OHPHIKCFIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly KJJFMAAJJCD[] NKNHPHIIBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private KJJFMAAJJCD NPEFCEGLHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly EOPLPHPLGNL AINFIFLEGMD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KNGNKAEBMGC KHDOPGJAFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x866D180", Offset = "0x866B780", VA = "0x18866D180", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x866CAB0", Offset = "0x866B0B0", VA = "0x18866CAB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x866D240", Offset = "0x866B840", VA = "0x18866D240")]
	public LBKFIFMFAEK(int AHIAOIDMGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x866CB70", Offset = "0x866B170", VA = "0x18866CB70")]
	public EOPLPHPLGNL ANNIMOLMONF(KJJFMAAJJCD ICKFEKPLGLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x866CD10", Offset = "0x866B310", VA = "0x18866CD10")]
	public void EHOMJHEFAIH(CKPIOOJBGDM DKMFDLDFAGO, [Optional] KJJFMAAJJCD EFINJDIGNBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x866CC00", Offset = "0x866B200", VA = "0x18866CC00", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public delegate void KNGNKAEBMGC(float ACDFBAHPKJI);
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class BMIOBAGEPBM
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class NIIPHNAFHGM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly CKPIOOJBGDM OBPAOLMFNGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly KNGNKAEBMGC LAOAAOBGDLL;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x866E210", Offset = "0x866C810", VA = "0x18866E210")]
		public NIIPHNAFHGM(CKPIOOJBGDM OBPAOLMFNGD, KNGNKAEBMGC LAOAAOBGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x866E1C0", Offset = "0x866C7C0", VA = "0x18866E1C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x866BA30", Offset = "0x866A030", VA = "0x18866BA30")]
	internal static bool AKALBKECAFL(float JGPEJMANNEB, float PDHHCOODKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8658130", Offset = "0x8656730", VA = "0x188658130")]
	internal static float LCPNDMKCFMF(float JGPEJMANNEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x866BAA0", Offset = "0x866A0A0", VA = "0x18866BAA0")]
	public static IDisposable LMJALFFHHBP(this CKPIOOJBGDM OBPAOLMFNGD, KNGNKAEBMGC LAOAAOBGDLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class EOPLPHPLGNL : CKPIOOJBGDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float ACDFBAHPKJI;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public float ACOMHOFIOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x866BD60", Offset = "0x866A360", VA = "0x18866BD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KNGNKAEBMGC? KHDOPGJAFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x866BE50", Offset = "0x866A450", VA = "0x18866BE50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x866BCC0", Offset = "0x866A2C0", VA = "0x18866BCC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public EOPLPHPLGNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface NJKFANDEADC<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HDIABMFJAIH<T> NPAODEBCNPN([Out] T KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELFNJAKNOMA();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class GKOIEIIMIME<T> : NJKFANDEADC<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly ConcurrentStack<T> IJAEJIGONPF;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x50FC230", Offset = "0x50FA830", VA = "0x1850FC230", Slot = "4")]
	public HDIABMFJAIH<T> NPAODEBCNPN([Out] T KOPHBHGIACG)
	{
		return default(HDIABMFJAIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x50FC110", Offset = "0x50FA710", VA = "0x1850FC110")]
	public void AMPHLDINMDF(T GDIPECPNBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x50FC170", Offset = "0x50FA770", VA = "0x1850FC170", Slot = "5")]
	public void ELFNJAKNOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "6")]
	protected virtual void OCAFKILPEFN(T MGEJOFGACGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x50FC1A0", Offset = "0x50FA7A0", VA = "0x1850FC1A0")]
	private T HBAOOBIPNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x50FC2C0", Offset = "0x50FA8C0", VA = "0x1850FC2C0")]
	public GKOIEIIMIME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct HDIABMFJAIH<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly T GDIPECPNBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly GKOIEIIMIME<T> BHPJDAFOMDP;

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
	internal HDIABMFJAIH(T KOPHBHGIACG, GKOIEIIMIME<T> BHPJDAFOMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x51553F0", Offset = "0x51539F0", VA = "0x1851553F0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class BMHHJEOFKAE : GKOIEIIMIME<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public static readonly BMHHJEOFKAE EHBCEBDHHPE;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x866B890", Offset = "0x8669E90", VA = "0x18866B890")]
	public static HDIABMFJAIH<StringBuilder> HBAOOBIPNDD([Out] StringBuilder KOPHBHGIACG)
	{
		return default(HDIABMFJAIH<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x866B930", Offset = "0x8669F30", VA = "0x18866B930", Slot = "6")]
	protected override void OCAFKILPEFN(StringBuilder MGEJOFGACGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x866B9F0", Offset = "0x8669FF0", VA = "0x18866B9F0")]
	public BMHHJEOFKAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class EKCKJGJOHKC : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7E90140", Offset = "0x7E8E740", VA = "0x187E90140")]
	public EKCKJGJOHKC(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[DefaultMember("Item")]
public class PBDHCPMNFFO<TKey, TValue> : HGAHCBDFLJM<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, FGLGMBIDNFH where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class KKKCDLLLDAD : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public PBDHCPMNFFO<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x12CB410", Offset = "0x12C9A10", VA = "0x1812CB410", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x5090290", Offset = "0x508E890", VA = "0x185090290", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public KKKCDLLLDAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5090340", Offset = "0x508E940", VA = "0x185090340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x56ED2F0", Offset = "0x56EB8F0", VA = "0x1856ED2F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x56ED2A0", Offset = "0x56EB8A0", VA = "0x1856ED2A0")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x56ED250", Offset = "0x56EB850", VA = "0x1856ED250")]
		private void FECGMFJNPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x56ED6D0", Offset = "0x56EBCD0", VA = "0x1856ED6D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly HGAHCBDFLJM<TKey, TValue> NMEJDGBOBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly IDictionary<TKey, TValue> EBFJKBHOOPD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA250", Offset = "0x5CA8850", VA = "0x185CAA250", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool BOFAKENAFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public TValue LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA320", Offset = "0x5CA8920", VA = "0x185CAA320", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA5B0", Offset = "0x5CA8BB0", VA = "0x185CAA5B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ICollection<TKey> OHEGHCIAIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA390", Offset = "0x5CA8990", VA = "0x185CAA390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public ICollection<TValue> FFNODFMPDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5CAA4A0", Offset = "0x5CA8AA0", VA = "0x185CAA4A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CAA000", Offset = "0x5CA8600", VA = "0x185CAA000")]
	public PBDHCPMNFFO(HGAHCBDFLJM<TKey, TValue> NMEJDGBOBLF, [Optional] IDictionary<TKey, TValue>? EBFJKBHOOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7B80", Offset = "0x5CA6180", VA = "0x185CA7B80", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8C70", Offset = "0x5CA7270", VA = "0x185CA8C70")]
	public void JEAFCKICECO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7560", Offset = "0x5CA5B60", VA = "0x185CA7560", Slot = "9")]
	public void Add(TKey HAELBKGFDIJ, TValue KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9070", Offset = "0x5CA7670", VA = "0x185CA9070")]
	public void OFKBKCBCPFC(TKey HAELBKGFDIJ, TValue KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8D90", Offset = "0x5CA7390", VA = "0x185CA8D90")]
	public void KHOKFLKIIME(TKey HAELBKGFDIJ, TValue KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8690", Offset = "0x5CA6C90", VA = "0x185CA8690")]
	public void EALKJLIPNDE(TKey HAELBKGFDIJ, TValue KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5CA84C0", Offset = "0x5CA6AC0", VA = "0x185CA84C0")]
	public void DGMFOMIAIPB(TKey HAELBKGFDIJ, TValue KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9670", Offset = "0x5CA7C70", VA = "0x185CA9670", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5CA96B0", Offset = "0x5CA7CB0", VA = "0x185CA96B0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9BB0", Offset = "0x5CA81B0", VA = "0x185CA9BB0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7C90", Offset = "0x5CA6290", VA = "0x185CA7C90", Slot = "8")]
	public bool ContainsKey(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8FA0", Offset = "0x5CA75A0", VA = "0x185CA8FA0")]
	public bool LFDJAJABEBH(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8A80", Offset = "0x5CA7080", VA = "0x185CA8A80")]
	public bool FLCNLKNKGMA(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5CA93E0", Offset = "0x5CA79E0", VA = "0x185CA93E0", Slot = "10")]
	public bool Remove(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5CA9D70", Offset = "0x5CA8370", VA = "0x185CA9D70", Slot = "11")]
	public bool TryGetValue(TKey HAELBKGFDIJ, [Out] TValue KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5CA81E0", Offset = "0x5CA67E0", VA = "0x185CA81E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] GHKPAFFMJAO, int MHIOAOJIPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5593440", Offset = "0x5591A40", VA = "0x185593440", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CA8BE0", Offset = "0x5CA71E0", VA = "0x185CA8BE0", Slot = "19")]
	[IteratorStateMachine(typeof(PBDHCPMNFFO<, >.KKKCDLLLDAD))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5CA92F0", Offset = "0x5CA78F0", VA = "0x185CA92F0", Slot = "21")]
	public bool PJOBLLHCFOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CA7990", Offset = "0x5CA5F90", VA = "0x185CA7990")]
	private TValue BEPOKFALKBG(TKey HAELBKGFDIJ)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface BPKGPBCBCOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string NLLKKEOBMFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface FGLGMBIDNFH
{
	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PJOBLLHCFOP();
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface HGAHCBDFLJM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FGLGMBIDNFH
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[DefaultMember("Item")]
public sealed class EDLIELBBKKA<TKey, TVal> : HGAHCBDFLJM<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FGLGMBIDNFH where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public delegate int CACILHECDMA(TKey HAELBKGFDIJ, TVal KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public delegate void KFHIEKIKDAA(TKey HAELBKGFDIJ, TVal KOPHBHGIACG, DABOAGHMIOC LEILDDGFOJJ);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private class MJFHMGEIGOF
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public TKey HPFJLGDHMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public TVal CECIKJNPCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xAFD490", Offset = "0xAFBA90", VA = "0x180AFD490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public int FMLOJENFFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0xC582A0", Offset = "0xC568A0", VA = "0x180C582A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x10B1C80", Offset = "0x10B0280", VA = "0x1810B1C80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public DateTimeOffset BADKEHIEGGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x1455470", Offset = "0x1453A70", VA = "0x181455470")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x15AC080", Offset = "0x15AA680", VA = "0x1815AC080")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5A17C20", Offset = "0x5A16220", VA = "0x185A17C20")]
		public MJFHMGEIGOF(TKey HAELBKGFDIJ, TVal IKJAADLGNCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class AAGIBOJENIJ : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public EDLIELBBKKA<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private LinkedList<MJFHMGEIGOF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x12CB410", Offset = "0x12C9A10", VA = "0x1812CB410", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x531D560", Offset = "0x531BB60", VA = "0x18531D560", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public AAGIBOJENIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x462E1E0", Offset = "0x462C7E0", VA = "0x18462E1E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x531B910", Offset = "0x5319F10", VA = "0x18531B910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x531A9F0", Offset = "0x5318FF0", VA = "0x18531A9F0")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x531D470", Offset = "0x531BA70", VA = "0x18531D470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const int AMHPCBBJPJD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<TKey, LinkedListNode<MJFHMGEIGOF>> HLOLJFKKBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly LinkedList<MJFHMGEIGOF> OLFONFELHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly CACILHECDMA? AHGPAFKPODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly TimeSpan EMNHCFAABOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly KFHIEKIKDAA? AAGFNFPNDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly NLHAHNGMGDL JHAAJPLHCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool ELCKGOKDAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<TKey> PJADJBFOAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<TVal> EJBMCCKKJPD;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int MEPOLPJPAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xB28EF0", Offset = "0xB274F0", VA = "0x180B28EF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	internal int CEJEIKHCFKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xEC0B20", Offset = "0xEBF120", VA = "0x180EC0B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1003BB0", Offset = "0x10021B0", VA = "0x181003BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4B13340", Offset = "0x4B11940", VA = "0x184B13340", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	internal int FCEDANCIOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4B06630", Offset = "0x4B04C30", VA = "0x184B06630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public ICollection<TVal> FFNODFMPDNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4B13470", Offset = "0x4B11A70", VA = "0x184B13470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	ICollection<TKey> IDictionary<TKey, TVal>.KGEEDABLCHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4B10980", Offset = "0x4B0EF80", VA = "0x184B10980", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool BOFAKENAFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public TVal LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4B133A0", Offset = "0x4B119A0", VA = "0x184B133A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4B134A0", Offset = "0x4B11AA0", VA = "0x184B134A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E2B0", Offset = "0x4B0C8B0", VA = "0x184B0E2B0")]
	private bool LOGKFANDJKG(int AHIAOIDMGDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4B0EBE0", Offset = "0x4B0D1E0", VA = "0x184B0EBE0")]
	private void MOIMPMLEBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4B11610", Offset = "0x4B0FC10", VA = "0x184B11610")]
	public EDLIELBBKKA(int AHIAOIDMGDN, [Optional] CACILHECDMA? AHGPAFKPODO, [Optional] IEqualityComparer<TKey>? LMLHBNLBBJD, [Optional] KFHIEKIKDAA? AAGFNFPNDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4B116D0", Offset = "0x4B0FCD0", VA = "0x184B116D0")]
	public EDLIELBBKKA(TimeSpan EMNHCFAABOP, [Optional] IEqualityComparer<TKey>? LMLHBNLBBJD, [Optional] KFHIEKIKDAA? AAGFNFPNDHC, [Optional] NLHAHNGMGDL? JHAAJPLHCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4B110F0", Offset = "0x4B0F6F0", VA = "0x184B110F0")]
	public EDLIELBBKKA(int AHIAOIDMGDN, TimeSpan EMNHCFAABOP, [Optional] IEqualityComparer<TKey>? LMLHBNLBBJD, [Optional] KFHIEKIKDAA? AAGFNFPNDHC, [Optional] NLHAHNGMGDL? JHAAJPLHCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4B12350", Offset = "0x4B10950", VA = "0x184B12350")]
	public EDLIELBBKKA(int AHIAOIDMGDN, CACILHECDMA? AHGPAFKPODO, TimeSpan EMNHCFAABOP, [Optional] IEqualityComparer<TKey>? LMLHBNLBBJD, [Optional] KFHIEKIKDAA? AAGFNFPNDHC, [Optional] NLHAHNGMGDL? JHAAJPLHCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4B0FF10", Offset = "0x4B0E510", VA = "0x184B0FF10", Slot = "21")]
	public bool PJOBLLHCFOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4B0F3F0", Offset = "0x4B0D9F0", VA = "0x184B0F3F0", Slot = "22")]
	public bool NBHNEPPIOAM(int KCJLCGFEBMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4B0BCA0", Offset = "0x4B0A2A0", VA = "0x184B0BCA0")]
	private bool KEKJPDBCBIB(int KCJLCGFEBMJ, DABOAGHMIOC LEILDDGFOJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4B07AE0", Offset = "0x4B060E0", VA = "0x184B07AE0")]
	public void IAMMACFOCIM(TKey HAELBKGFDIJ, TVal KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x4B04CD0", Offset = "0x4B032D0", VA = "0x184B04CD0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NANHMPOBBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4B04770", Offset = "0x4B02D70", VA = "0x184B04770", Slot = "9")]
	public void Add(TKey HAELBKGFDIJ, TVal KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4B04E70", Offset = "0x4B03470", VA = "0x184B04E70", Slot = "8")]
	public bool ContainsKey(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x4B10530", Offset = "0x4B0EB30", VA = "0x184B10530", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x4B10200", Offset = "0x4B0E800", VA = "0x184B10200", Slot = "10")]
	public bool Remove(TKey HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4B10710", Offset = "0x4B0ED10", VA = "0x184B10710", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> NANHMPOBBLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x4B0E300", Offset = "0x4B0C900", VA = "0x184B0E300")]
	private bool MGAHDLGJJIO(TKey HAELBKGFDIJ, [Out] TVal KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x4B071F0", Offset = "0x4B057F0", VA = "0x184B071F0")]
	private TVal HBAOOBIPNDD(TKey KAIPGEJNEGO)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4B10F30", Offset = "0x4B0F530", VA = "0x184B10F30", Slot = "11")]
	public bool TryGetValue(TKey KAIPGEJNEGO, [Out] TVal KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4B04D10", Offset = "0x4B03310", VA = "0x184B04D10", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4B05C70", Offset = "0x4B04270", VA = "0x184B05C70", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GHKPAFFMJAO, int MHIOAOJIPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4B06BB0", Offset = "0x4B051B0", VA = "0x184B06BB0")]
	private void FMMCPDDAIPA(TKey HAELBKGFDIJ, TVal IKJAADLGNCL, DABOAGHMIOC LEILDDGFOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4B0F790", Offset = "0x4B0DD90", VA = "0x184B0F790")]
	private bool NINOKGMFPII(MJFHMGEIGOF JHPEMBEDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4B084F0", Offset = "0x4B06AF0", VA = "0x184B084F0")]
	private void JIONHPOMHEH(LinkedListNode<MJFHMGEIGOF> DMHDIDMKHCO, TVal JCAFAFAHHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4B0DD30", Offset = "0x4B0C330", VA = "0x184B0DD30")]
	private void KIHHIABHMFG(TKey HAELBKGFDIJ, TVal KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C7A0", Offset = "0x4B0ADA0", VA = "0x184B0C7A0")]
	private void KICEDJJJAPH(MJFHMGEIGOF JHPEMBEDJLE, TVal JCAFAFAHHEP, int AKLCFBNOHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4B06F50", Offset = "0x4B05550", VA = "0x184B06F50", Slot = "19")]
	[IteratorStateMachine(typeof(EDLIELBBKKA<, >.AAGIBOJENIJ))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4B109B0", Offset = "0x4B0EFB0", VA = "0x184B109B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public enum DABOAGHMIOC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class DLBAPHPFCDB<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public readonly TKey DCEMOLMNAPP;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4677AF0", Offset = "0x46760F0", VA = "0x184677AF0")]
	public DLBAPHPFCDB(TKey CNKEMLOMFEA, Exception KJLAGGDJKHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class DPDJMGOJIMD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x76949D0", Offset = "0x7692FD0", VA = "0x1876949D0")]
	public DPDJMGOJIMD(string GKNICJPCIJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class DCHHBFDIKBJ<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class POJDANEBDOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public DCHHBFDIKBJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public POJDANEBDOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4570", Offset = "0x5CF2B70", VA = "0x185CF4570")]
		internal Task<TResource> GLCEDGGGNGG(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct INEPBFLGMHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public DCHHBFDIKBJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x52A1B80", Offset = "0x52A0180", VA = "0x1852A1B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x52A2B40", Offset = "0x52A1140", VA = "0x1852A2B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct DDIMBPOOEEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x46479D0", Offset = "0x4645FD0", VA = "0x1846479D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x46483F0", Offset = "0x46469F0", VA = "0x1846483F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly ANFDBKEIPDP<TId, Task<TResource>> DAGAPICMIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> IJCAFLOJNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? NOLOHBGDMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Action<TResource>? IAGIIBBBBPM;

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x463ABB0", Offset = "0x46391B0", VA = "0x18463ABB0")]
	public DCHHBFDIKBJ(int PFDNBMJFENE = 0, [Optional] IEqualityComparer<TId>? AMDIKCOEBIE, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACOFPNPJDBB, [Optional] Action<TResource>? CHNAPNCHKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x463A180", Offset = "0x4638780", VA = "0x18463A180")]
	public GCAHIIHOLJP<Task<TResource>> LPOKKBOJPBB(TId NMILEMOAODL, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACOFPNPJDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4639330", Offset = "0x4637930", VA = "0x184639330")]
	private void ACDKHOBEFKK(Task<TResource> DIAHJIAKEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4639890", Offset = "0x4637E90", VA = "0x184639890")]
	[AsyncStateMachine(typeof(DCHHBFDIKBJ<, >.INEPBFLGMHI))]
	private Task JHOIDHKNPNO(Task<TResource> DIAHJIAKEPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4639660", Offset = "0x4637C60", VA = "0x184639660")]
	public void GIJHAKBDGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4639030", Offset = "0x4637630", VA = "0x184639030")]
	public ANFDBKEIPDP<TId, Task<TResource>>.LAEDHJDHEJN ABGODHCJODA()
	{
		return default(ANFDBKEIPDP<TId, Task<TResource>>.LAEDHJDHEJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x463A9E0", Offset = "0x4638FE0", VA = "0x18463A9E0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x463A9E0", Offset = "0x4638FE0", VA = "0x18463A9E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4639B90", Offset = "0x4638190", VA = "0x184639B90")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DCHHBFDIKBJ<, >.DDIMBPOOEEB))]
	internal static Task LEJIIEIMINE(Task<TResource> DIAHJIAKEPB, CancellationTokenSource COAFJLBNMKC, Dictionary<Task<TResource>, CancellationTokenSource> NJJKCOBOBEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class ANFDBKEIPDP<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class HELEABCOEJO : IEquatable<HELEABCOEJO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly TValue CECIKJNPCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int PJJAAMNBKBG;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x10379A0", Offset = "0x1035FA0", VA = "0x1810379A0")]
		public HELEABCOEJO(TValue KOPHBHGIACG, int BCEJCBDEINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x515E200", Offset = "0x515C800", VA = "0x18515E200", Slot = "4")]
		public bool Equals(HELEABCOEJO? AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x515E290", Offset = "0x515C890", VA = "0x18515E290", Slot = "0")]
		public override bool Equals(object? MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x515E450", Offset = "0x515CA50", VA = "0x18515E450", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public struct LAEDHJDHEJN : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private Dictionary<TKey, HELEABCOEJO>.Enumerator KNPOICIMKCA;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x57B82F0", Offset = "0x57B68F0", VA = "0x1857B82F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public (TKey Key, TValue Value, int RefCount) MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x57B8950", Offset = "0x57B6F50", VA = "0x1857B8950", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x57B84E0", Offset = "0x57B6AE0", VA = "0x1857B84E0")]
		public LAEDHJDHEJN(ANFDBKEIPDP<TKey, TValue> LLNAAJAADDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x57B7F30", Offset = "0x57B6530", VA = "0x1857B7F30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x57B7FF0", Offset = "0x57B65F0", VA = "0x1857B7FF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x57B8030", Offset = "0x57B6630", VA = "0x1857B8030", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class CCIAGFIEODD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public ANFDBKEIPDP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public HELEABCOEJO refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CCIAGFIEODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9000", Offset = "0x6EA7600", VA = "0x186EA9000")]
		internal void GLCEDGGGNGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<TKey, HELEABCOEJO> PLODCBNJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly Func<TKey, TValue>? ICPJNBOCAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Action<TValue>? MILNNMKCECF;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5838880", Offset = "0x5836E80", VA = "0x185838880")]
	public ANFDBKEIPDP(int PFDNBMJFENE = 0, [Optional] IEqualityComparer<TKey>? LMLHBNLBBJD, [Optional] Func<TKey, TValue>? ODPFNHJMDEE, [Optional] Action<TValue>? KGDKCPAPMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5837E60", Offset = "0x5836460", VA = "0x185837E60")]
	public GCAHIIHOLJP<TValue> LPOKKBOJPBB(TKey HAELBKGFDIJ, [Optional] Func<TKey, TValue>? PIPPLKBCGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5837370", Offset = "0x5835970", VA = "0x185837370")]
	private void AMPHLDINMDF(TKey HAELBKGFDIJ, HELEABCOEJO NLPFJGAKFBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5837780", Offset = "0x5835D80", VA = "0x185837780")]
	public void GIJHAKBDGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5837210", Offset = "0x5835810", VA = "0x185837210")]
	public LAEDHJDHEJN ABGODHCJODA()
	{
		return default(LAEDHJDHEJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x58386B0", Offset = "0x5836CB0", VA = "0x1858386B0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x58386B0", Offset = "0x5836CB0", VA = "0x1858386B0", Slot = "5")]
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
