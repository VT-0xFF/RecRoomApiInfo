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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C221C0", Offset = "0x7C215C0", VA = "0x187C221C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class KOABGHLHHNE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected KOABGHLHHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class IMPMGBNAAEB<T> : KOABGHLHHNE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct ANAKFPFFBNP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum JHDLPHGIBFO
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
		public JHDLPHGIBFO KHNCICOHHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T PDHMHKIHKPF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int PCCOCCICJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool MFONDJKMFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool OPLPOEJEJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? GNPOOFDDEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<ANAKFPFFBNP>? DGIPINLGGPD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HGCDOIDPKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4A698B0", Offset = "0x4A68CB0", VA = "0x184A698B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A69920", Offset = "0x4A68D20", VA = "0x184A69920")]
	protected IMPMGBNAAEB(bool OPLPOEJEJPL, bool MFONDJKMFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A69630", Offset = "0x4A68A30", VA = "0x184A69630")]
	protected bool MMBLIJDOAFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A69500", Offset = "0x4A68900", VA = "0x184A69500")]
	protected void HKJDCMPKJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A68E80", Offset = "0x4A68280", VA = "0x184A68E80")]
	protected void DKMCDOKPJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE0100", Offset = "0x3ADF500", VA = "0x183AE0100")]
	private static void OMCNGODPNID<U>(List<U>? ANHMDLEGCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A692E0", Offset = "0x4A686E0", VA = "0x184A692E0", Slot = "4")]
	public void FGAAHPGCDNG(T PDHMHKIHKPF, bool MKOBKIIEJIH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A696D0", Offset = "0x4A68AD0", VA = "0x184A696D0", Slot = "5")]
	public void NMPKBAOEGPN(T PDHMHKIHKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A69120", Offset = "0x4A68520", VA = "0x184A69120")]
	public void ENAIKFMHAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KFBDEOPEKLE : IMPMGBNAAEB<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C21880", Offset = "0x7C20C80", VA = "0x187C21880")]
	public KFBDEOPEKLE(bool OPLPOEJEJPL = false, bool MFONDJKMFEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C215C0", Offset = "0x7C209C0", VA = "0x187C215C0")]
	public void HFGDGIKOIHK()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C217C0", Offset = "0x7C20BC0", VA = "0x187C217C0")]
	public static KFBDEOPEKLE IHDKIKJKCIO(KFBDEOPEKLE NDJFHCFGJJO, Action PDHMHKIHKPF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C21820", Offset = "0x7C20C20", VA = "0x187C21820")]
	public static KFBDEOPEKLE MPAMHBGJFBO(KFBDEOPEKLE NDJFHCFGJJO, Action PDHMHKIHKPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JDOFHPKKJIH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGAAHPGCDNG(Action<T> PDHMHKIHKPF, bool MKOBKIIEJIH = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMPKBAOEGPN(Action<T> PDHMHKIHKPF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class MAAICPKGELE<T> : IMPMGBNAAEB<Action<T>>, JDOFHPKKJIH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x47EC630", Offset = "0x47EBA30", VA = "0x1847EC630")]
	public MAAICPKGELE(bool OPLPOEJEJPL = false, bool MFONDJKMFEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x509D5A0", Offset = "0x509C9A0", VA = "0x18509D5A0")]
	public void HFGDGIKOIHK(T DEEHPBDAIHI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x488A660", Offset = "0x4889A60", VA = "0x18488A660")]
	public static MAAICPKGELE<T> IHDKIKJKCIO(MAAICPKGELE<T> NDJFHCFGJJO, Action<T> PDHMHKIHKPF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x488A710", Offset = "0x4889B10", VA = "0x18488A710")]
	public static MAAICPKGELE<T> MPAMHBGJFBO(MAAICPKGELE<T> NDJFHCFGJJO, Action<T> PDHMHKIHKPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FBEJGFBHLEF<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGAAHPGCDNG(Action<T, U> PDHMHKIHKPF, bool MKOBKIIEJIH = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMPKBAOEGPN(Action<T, U> PDHMHKIHKPF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class DEBGLLPOJFA<T, U> : IMPMGBNAAEB<Action<T, U>>, FBEJGFBHLEF<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x47EC630", Offset = "0x47EBA30", VA = "0x1847EC630")]
	public DEBGLLPOJFA(bool OPLPOEJEJPL = false, bool MFONDJKMFEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6889540", Offset = "0x6888940", VA = "0x186889540")]
	public void HFGDGIKOIHK(T DEEHPBDAIHI, U LIJHIMPDKOO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x488A660", Offset = "0x4889A60", VA = "0x18488A660")]
	public static DEBGLLPOJFA<T, U> IHDKIKJKCIO(DEBGLLPOJFA<T, U> NDJFHCFGJJO, Action<T, U> PDHMHKIHKPF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x488A710", Offset = "0x4889B10", VA = "0x18488A710")]
	public static DEBGLLPOJFA<T, U> MPAMHBGJFBO(DEBGLLPOJFA<T, U> NDJFHCFGJJO, Action<T, U> PDHMHKIHKPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class PHJFNHOIGCK<T, U, V> : IMPMGBNAAEB<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x47EC630", Offset = "0x47EBA30", VA = "0x1847EC630")]
	public PHJFNHOIGCK(bool OPLPOEJEJPL = false, bool MFONDJKMFEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x54A0DB0", Offset = "0x54A01B0", VA = "0x1854A0DB0")]
	public void HFGDGIKOIHK(T DEEHPBDAIHI, U LIJHIMPDKOO, V LLEKGMDPLMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x488A660", Offset = "0x4889A60", VA = "0x18488A660")]
	public static PHJFNHOIGCK<T, U, V> IHDKIKJKCIO(PHJFNHOIGCK<T, U, V> NDJFHCFGJJO, Action<T, U, V> PDHMHKIHKPF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x488A710", Offset = "0x4889B10", VA = "0x18488A710")]
	public static PHJFNHOIGCK<T, U, V> MPAMHBGJFBO(PHJFNHOIGCK<T, U, V> NDJFHCFGJJO, Action<T, U, V> PDHMHKIHKPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GHIDJBGGBFN<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class GANAKBFNDNE<T, U, V, W> : IMPMGBNAAEB<Action<T, U, V, W>>, GHIDJBGGBFN<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x47EC630", Offset = "0x47EBA30", VA = "0x1847EC630")]
	public GANAKBFNDNE(bool OPLPOEJEJPL = false, bool MFONDJKMFEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4888D90", Offset = "0x4888190", VA = "0x184888D90")]
	public void HFGDGIKOIHK(T DEEHPBDAIHI, U LIJHIMPDKOO, V LLEKGMDPLMK, W LBBKKDPILOD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x488A660", Offset = "0x4889A60", VA = "0x18488A660")]
	public static GANAKBFNDNE<T, U, V, W> IHDKIKJKCIO(GANAKBFNDNE<T, U, V, W> NDJFHCFGJJO, Action<T, U, V, W> PDHMHKIHKPF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x488A710", Offset = "0x4889B10", VA = "0x18488A710")]
	public static GANAKBFNDNE<T, U, V, W> MPAMHBGJFBO(GANAKBFNDNE<T, U, V, W> NDJFHCFGJJO, Action<T, U, V, W> PDHMHKIHKPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MAFIJBEKJMM<T, U, V, W, X> : IMPMGBNAAEB<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x47EC630", Offset = "0x47EBA30", VA = "0x1847EC630")]
	public MAFIJBEKJMM(bool OPLPOEJEJPL = false, bool MFONDJKMFEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x509F340", Offset = "0x509E740", VA = "0x18509F340")]
	public void HFGDGIKOIHK(T DEEHPBDAIHI, U LIJHIMPDKOO, V LLEKGMDPLMK, W LBBKKDPILOD, X COBPEJEHIHC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x488A660", Offset = "0x4889A60", VA = "0x18488A660")]
	public static MAFIJBEKJMM<T, U, V, W, X> IHDKIKJKCIO(MAFIJBEKJMM<T, U, V, W, X> NDJFHCFGJJO, Action<T, U, V, W, X> PDHMHKIHKPF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x488A710", Offset = "0x4889B10", VA = "0x18488A710")]
	public static MAFIJBEKJMM<T, U, V, W, X> MPAMHBGJFBO(MAFIJBEKJMM<T, U, V, W, X> NDJFHCFGJJO, Action<T, U, V, W, X> PDHMHKIHKPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class HOGGNICKMFE<T, U, V, W, X, Y> : IMPMGBNAAEB<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x47EC630", Offset = "0x47EBA30", VA = "0x1847EC630")]
	public HOGGNICKMFE(bool OPLPOEJEJPL = false, bool MFONDJKMFEP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4979C20", Offset = "0x4979020", VA = "0x184979C20")]
	public void HFGDGIKOIHK(T DEEHPBDAIHI, U LIJHIMPDKOO, V LLEKGMDPLMK, W LBBKKDPILOD, X COBPEJEHIHC, Y CEJJJCAALLM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x488A660", Offset = "0x4889A60", VA = "0x18488A660")]
	public static HOGGNICKMFE<T, U, V, W, X, Y> IHDKIKJKCIO(HOGGNICKMFE<T, U, V, W, X, Y> NDJFHCFGJJO, Action<T, U, V, W, X, Y> PDHMHKIHKPF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x488A710", Offset = "0x4889B10", VA = "0x18488A710")]
	public static HOGGNICKMFE<T, U, V, W, X, Y> MPAMHBGJFBO(HOGGNICKMFE<T, U, V, W, X, Y> NDJFHCFGJJO, Action<T, U, V, W, X, Y> PDHMHKIHKPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FIBPCHMAKCH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly DBCKBHEENGK<TKey, TVal> MFBOKCCFHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> GNGBBJFBJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DBCKBHEENGK<TKey, TVal>.DCHBJLJABNJ? IDJDLPLNJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int BNFNMPGPLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DBCKBHEENGK<TKey, TVal>.FIHMCMBPEOG? EMHBGCNJIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int ICOGCOKMOJI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int DCPJDOAGFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x47DA0C0", Offset = "0x47D94C0", VA = "0x1847DA0C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int MMGEIDHINCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCD0", Offset = "0x9CF0D0", VA = "0x1809CFCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47DB490", Offset = "0x47DA890", VA = "0x1847DB490")]
	public FIBPCHMAKCH(int BNFNMPGPLMK, [Optional] DBCKBHEENGK<TKey, TVal>.FIHMCMBPEOG? EMHBGCNJIAP, [Optional] IEqualityComparer<TKey>? OFJPNJJCFGB, [Optional] DBCKBHEENGK<TKey, TVal>.DCHBJLJABNJ? IDJDLPLNJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x47DA870", Offset = "0x47D9C70", VA = "0x1847DA870")]
	public void GJFCIIBBJAN(TKey IICGAABOENK, TVal OOEMJLHLIHJ, bool IKCACAHNKEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x47DAC90", Offset = "0x47DA090", VA = "0x1847DAC90")]
	public bool HNEHFHOEGEF(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x47DA120", Offset = "0x47D9520", VA = "0x1847DA120")]
	public bool EHIFOHHFDPG(TKey GHJMAJOGKDG, [Out] TVal OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x47DB080", Offset = "0x47DA480", VA = "0x1847DB080")]
	private void LAJDDJJECDA(TKey IICGAABOENK, TVal OOEMJLHLIHJ, int LLBNOFGPNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x47DAAC0", Offset = "0x47D9EC0", VA = "0x1847DAAC0")]
	public bool HEHJFGIMNDN(TKey IICGAABOENK, TVal OOEMJLHLIHJ, bool IKCACAHNKEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x47DA220", Offset = "0x47D9620", VA = "0x1847DA220")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x47DA2D0", Offset = "0x47D96D0", VA = "0x1847DA2D0")]
	private void FOMOMANNNCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x47DAE00", Offset = "0x47DA200", VA = "0x1847DAE00")]
	private bool KCKHPPEBECO(TKey IICGAABOENK, CDPNACNMEPL HJCCPGPOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x47DAF50", Offset = "0x47DA350", VA = "0x1847DAF50")]
	private void KIDMKFEADNG(TKey IICGAABOENK, TVal OOEMJLHLIHJ, CDPNACNMEPL HJCCPGPOLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47DB360", Offset = "0x47DA760", VA = "0x1847DB360")]
	private void NEDCOJHFJFG(TKey IICGAABOENK, TVal DBALGCNBEDK, CDPNACNMEPL HJCCPGPOLBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DBJNCNCAIPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action HFOILBEEGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool DEOBMDFLEOO;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public DBJNCNCAIPC(Action PNIEGCAPKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FED0", Offset = "0x7C1F2D0", VA = "0x187C1FED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x34FC3B0", Offset = "0x34FB7B0", VA = "0x1834FC3B0")]
	public static BCNNKHLMADP<T> BPKMLDCMEGB<T>(T OOEMJLHLIHJ, Action PNIEGCAPKKL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BCNNKHLMADP<T> : DBJNCNCAIPC where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C980", Offset = "0x5E9BD80", VA = "0x185E9C980")]
	public BCNNKHLMADP(T OOEMJLHLIHJ, Action PNIEGCAPKKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class MLDEBEHMHGA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HOOFHGPDBAL<T>? LMDOHAMODGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> ELCBGMBLGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool DEOBMDFLEOO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly MLDEBEHMHGA<T> HGNIBOKIJFN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> DDGDIGJCIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50DC300", Offset = "0x50DB700", VA = "0x1850DC300")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long GHEOBFHNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x50DC440", Offset = "0x50DB840", VA = "0x1850DC440")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GHONCNALJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x50DBFD0", Offset = "0x50DB3D0", VA = "0x1850DBFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x50DC660", Offset = "0x50DBA60", VA = "0x1850DC660")]
	public MLDEBEHMHGA(HOOFHGPDBAL<T> IGOPBJIMFNL, HOOFHGPDBAL<T> JLFEEODCPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x50DC810", Offset = "0x50DBC10", VA = "0x1850DC810")]
	public MLDEBEHMHGA(HOOFHGPDBAL<T> IGOPBJIMFNL, int NHKONNPHPEL, HOOFHGPDBAL<T> JLFEEODCPKB, int BALEEEHNCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x50DC760", Offset = "0x50DBB60", VA = "0x1850DC760")]
	private MLDEBEHMHGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x50DBDC0", Offset = "0x50DB1C0", VA = "0x1850DBDC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x50DBE50", Offset = "0x50DB250", VA = "0x1850DBE50")]
	public T[] ECCHMOFPDMA()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x50DC150", Offset = "0x50DB550", VA = "0x1850DC150")]
	public static ReadOnlySequence<T> HIHFKEJHDAH(MLDEBEHMHGA<T>? JEMDCGMNCGI)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FMDNBBJKFJO : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct AIIJDPEBKKG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
		public static AIIJDPEBKKG FABCCGGAHMJ()
		{
			return default(AIIJDPEBKKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C20A90", Offset = "0x7C1FE90", VA = "0x187C20A90")]
	public static string KNJPFHHBIGN(Type KHNCICOHHHJ, [Optional] string? EFMHIPGDANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3691AC0", Offset = "0x3690EC0", VA = "0x183691AC0")]
	public static string? KNJPFHHBIGN<T>([Optional] string? EFMHIPGDANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3691A40", Offset = "0x3690E40", VA = "0x183691A40")]
	public static string? GGAGGFJMIGM<T>([Optional] string? JLNDLHJKPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0")]
	public static FMDNBBJKFJO AIJMHMNEAAE(string EFMHIPGDANG, string? JLNDLHJKPGD)
	{
		return default(FMDNBBJKFJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BGKHLJCAAGH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool BHDEMDHLBMP(string HGMIOHMFJLF, BGKHLJCAAGH EMNFKPOJAAL);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MNJBJJMNMJF<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MNJBJJMNMJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x50E7720", Offset = "0x50E6B20", VA = "0x1850E7720")]
		internal void DHJJANLACBO(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int AGBLNABJHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string ACPCCIBNMAK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F2A0", Offset = "0x7C1E6A0", VA = "0x187C1F2A0")]
	public static Dictionary<string, BGKHLJCAAGH> CFHBGHEJIDM(Type HGEDOBCBGLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3445260", Offset = "0x3444660", VA = "0x183445260")]
	public static Dictionary<string, BGKHLJCAAGH> CFHBGHEJIDM<T>(Type HGEDOBCBGLC, IReadOnlyDictionary<T, string> FKFDEOPOEJN) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3445AA0", Offset = "0x3444EA0", VA = "0x183445AA0")]
	public static Dictionary<string, BGKHLJCAAGH> DLFADHAHONA<T>(List<T> IJMIMMOJMBP) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F7A0", Offset = "0x7C1EBA0", VA = "0x187C1F7A0")]
	public static Dictionary<string, BGKHLJCAAGH> KJAAGOIFJHH(Type HGEDOBCBGLC, BHDEMDHLBMP OIHDPLOIECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F5E0", Offset = "0x7C1E9E0", VA = "0x187C1F5E0")]
	public static Dictionary<int, string> DNFFJKMOHBF(Dictionary<string, BGKHLJCAAGH> ILNONAAFECI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class IDMJKCLDJLO : HAPFLJDLPEC
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool GALIDNOCCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? CJNKGIMGPKD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual HAPFLJDLPEC? CPFDANEBFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C21320", Offset = "0x7C20720", VA = "0x187C21320")]
	protected IDMJKCLDJLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string CPMOFLNCDEP();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C21080", Offset = "0x7C20480", VA = "0x187C21080", Slot = "8")]
	public virtual string IENEHOJGOGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C20DD0", Offset = "0x7C201D0", VA = "0x187C20DD0", Slot = "9")]
	public void HPEILMCPFHL(StringBuilder BIMHAIOGKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C212C0", Offset = "0x7C206C0", VA = "0x187C212C0", Slot = "10")]
	public void PONJOEOHGPF(StringBuilder BIMHAIOGKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C21100", Offset = "0x7C20500", VA = "0x187C21100", Slot = "11")]
	public void NOAFPFBPPDK(StringBuilder BIMHAIOGKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C20C70", Offset = "0x7C20070", VA = "0x187C20C70", Slot = "12")]
	public void EFAPPKDKNML(StringBuilder BIMHAIOGKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C21220", Offset = "0x7C20620", VA = "0x187C21220")]
	public static void PFPGKGJEDKD(StringBuilder BIMHAIOGKKK, string EIFHMNNCFBD, string JICOGLHDBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDD70", Offset = "0x6BED170", VA = "0x186BEDD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NGCGOHIGJMA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C22160", Offset = "0x7C21560", VA = "0x187C22160")]
	public NGCGOHIGJMA(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HIGAPOHECCL<TErr> : NGCGOHIGJMA where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr BBPLEKDHCDJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4927F50", Offset = "0x4927350", VA = "0x184927F50")]
	private HIGAPOHECCL([In] TErr BJKKGGEDLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4927E70", Offset = "0x4927270", VA = "0x184927E70")]
	public static HIGAPOHECCL<TErr> FABCCGGAHMJ([In] TErr BJKKGGEDLPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PLFEAAPPNHJ : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm DDDGFGIBIAH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool LDFEILLDEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool LAEOFOMDHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool LIKDBHFJOOG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long GHEOBFHNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C226A0", Offset = "0x7C21AA0", VA = "0x187C226A0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long KHAINEMBOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C22710", Offset = "0x7C21B10", VA = "0x187C22710", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7C22780", Offset = "0x7C21B80", VA = "0x187C22780", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7C22630", Offset = "0x7C21A30", VA = "0x187C22630")]
	public PLFEAAPPNHJ(HashAlgorithm DDDGFGIBIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C22450", Offset = "0x7C21850", VA = "0x187C22450", Slot = "35")]
	public override int Read(byte[] HDBNDELHALH, int IALPEJIGIPD, int PCGLBCNIEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C22600", Offset = "0x7C21A00", VA = "0x187C22600", Slot = "38")]
	public override void Write(byte[] HDBNDELHALH, int IALPEJIGIPD, int PCGLBCNIEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C224F0", Offset = "0x7C218F0", VA = "0x187C224F0", Slot = "33")]
	public override long Seek(long IALPEJIGIPD, SeekOrigin JBGLGLFDDMH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C22580", Offset = "0x7C21980", VA = "0x187C22580", Slot = "34")]
	public override void SetLength(long OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C22370", Offset = "0x7C21770", VA = "0x187C22370")]
	public byte[] EDOCNNBDGCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HAPFLJDLPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IENEHOJGOGK();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string CPMOFLNCDEP();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ENNJPGHJDOB<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IKPPGOMFFEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string DJGAIKDFEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HOOFHGPDBAL<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static HOOFHGPDBAL<T>? JHGIFNNCNPO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object EBGDOIMCPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? POEEMGKGOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool DEOBMDFLEOO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool CMCDPHOIBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD4A610", Offset = "0xD49A10", VA = "0x180D4A610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x497B8A0", Offset = "0x497ACA0", VA = "0x18497B8A0")]
	private static HOOFHGPDBAL<T> MMEBBOMHOLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x497A7B0", Offset = "0x4979BB0", VA = "0x18497A7B0")]
	private static void CJPFHKFCCOI(HOOFHGPDBAL<T> FNEBLPMGKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x497C050", Offset = "0x497B450", VA = "0x18497C050")]
	private HOOFHGPDBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x497A1D0", Offset = "0x49795D0", VA = "0x18497A1D0")]
	public static HOOFHGPDBAL<T> BPKMLDCMEGB(ReadOnlyMemory<T> LGGBKAAMMEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x497A590", Offset = "0x4979990", VA = "0x18497A590")]
	public static HOOFHGPDBAL<T> BPKMLDCMEGB(IMemoryOwner<T> KEDBIDKCLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x497B400", Offset = "0x497A800", VA = "0x18497B400")]
	public static void IBAEBLLNOIO(HOOFHGPDBAL<T> IGOPBJIMFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x497ADC0", Offset = "0x497A1C0", VA = "0x18497ADC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x497B2E0", Offset = "0x497A6E0", VA = "0x18497B2E0")]
	public HOOFHGPDBAL<T> IAGEDJMCMMO(IMemoryOwner<T> KEDBIDKCLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x497B7A0", Offset = "0x497ABA0", VA = "0x18497B7A0")]
	private void LKADGGLGHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x497B540", Offset = "0x497A940", VA = "0x18497B540")]
	private HOOFHGPDBAL<T> JOLMIOELENJ(HOOFHGPDBAL<T> FNEBLPMGKDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BIGCGFCKPID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FC10", Offset = "0x7C1F010", VA = "0x187C1FC10")]
	public BIGCGFCKPID(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AEEGKAKBKLH<TOk> : BIGCGFCKPID where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk KFBHOMAFMMP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x48AE8F0", Offset = "0x48ADCF0", VA = "0x1848AE8F0")]
	private AEEGKAKBKLH([In] TOk GJMPBLINGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x48AE810", Offset = "0x48ADC10", VA = "0x1848AE810")]
	public static AEEGKAKBKLH<TOk> FABCCGGAHMJ([In] TOk GJMPBLINGOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct BECHBBIPIFM<TOk, TErr> : IEquatable<BECHBBIPIFM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> DBHEFDELEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr BBPLEKDHCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk KFBHOMAFMMP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool PMBEMJMKNJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0ED0", Offset = "0x5EA02D0", VA = "0x185EA0ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool GCABMECCEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6280", Offset = "0x5EA5680", VA = "0x185EA6280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9BC0", Offset = "0x5EA8FC0", VA = "0x185EA9BC0")]
	internal BECHBBIPIFM([In] TErr BJKKGGEDLPM, [In] TOk GJMPBLINGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1980", Offset = "0x5EA0D80", VA = "0x185EA1980")]
	public static BECHBBIPIFM<TOk, TErr> DKCHMMIGIOF([In] TErr BJKKGGEDLPM)
	{
		return default(BECHBBIPIFM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3830", Offset = "0x5EA2C30", VA = "0x185EA3830")]
	public static BECHBBIPIFM<TOk, TErr> FBKEMKGBHJL([In] TOk GJMPBLINGOE)
	{
		return default(BECHBBIPIFM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x36EAF00", Offset = "0x36EA300", VA = "0x1836EAF00")]
	public BECHBBIPIFM<TOk?, UErr?> EEDONDENMLA<UErr>()
	{
		return default(BECHBBIPIFM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x36ED5C0", Offset = "0x36EC9C0", VA = "0x1836ED5C0")]
	public BECHBBIPIFM<UOk?, TErr?> GLGAPCBCOHK<UOk>()
	{
		return default(BECHBBIPIFM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x36EB8C0", Offset = "0x36EACC0", VA = "0x1836EB8C0")]
	public BECHBBIPIFM<UOk?, TErr?> GDIKOBLGMHB<UOk>()
	{
		return default(BECHBBIPIFM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x36ED800", Offset = "0x36ECC00", VA = "0x1836ED800")]
	public BECHBBIPIFM<TOk?, UErr?> KMLMABDKMFA<UErr>()
	{
		return default(BECHBBIPIFM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0930", Offset = "0x5E9FD30", VA = "0x185EA0930")]
	public BECHBBIPIFM<FGGPIMEAIEJ, TErr> BGLBFKKJODB()
	{
		return default(BECHBBIPIFM<FGGPIMEAIEJ, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4FF0", Offset = "0x5EA43F0", VA = "0x185EA4FF0")]
	public static bool HGJBAFCOLON([In] BECHBBIPIFM<TOk, TErr> BGDONNBGCJK, [In] BECHBBIPIFM<TOk, TErr> DKEKGDBAIOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1F60", Offset = "0x5EA1360", VA = "0x185EA1F60", Slot = "4")]
	public bool Equals(BECHBBIPIFM<TOk, TErr> DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1DC0", Offset = "0x5EA11C0", VA = "0x185EA1DC0", Slot = "0")]
	public override bool Equals(object DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4140", Offset = "0x5EA3540", VA = "0x185EA4140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8480", Offset = "0x5EA7880", VA = "0x185EA8480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class DKOHMCFIDDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct JOOGAEFBKEK<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<BECHBBIPIFM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<BECHBBIPIFM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4CC7280", Offset = "0x4CC6680", VA = "0x184CC7280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4CC7900", Offset = "0x4CC6D00", VA = "0x184CC7900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x35053E0", Offset = "0x35047E0", VA = "0x1835053E0")]
	public static BECHBBIPIFM<TOk?, TErr?> KFBHOMAFMMP<TOk, TErr>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [In] TOk GJMPBLINGOE)
	{
		return default(BECHBBIPIFM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x35073A0", Offset = "0x35067A0", VA = "0x1835073A0")]
	public static BECHBBIPIFM<FGGPIMEAIEJ, TErr?> KFBHOMAFMMP<TErr>([In] this BECHBBIPIFM<FGGPIMEAIEJ, TErr> KBBJDOAJMAF)
	{
		return default(BECHBBIPIFM<FGGPIMEAIEJ, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x35053E0", Offset = "0x35047E0", VA = "0x1835053E0")]
	public static BECHBBIPIFM<TOk?, TErr?> BBPLEKDHCDJ<TOk, TErr>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [In] TErr BJKKGGEDLPM)
	{
		return default(BECHBBIPIFM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3507B40", Offset = "0x3506F40", VA = "0x183507B40")]
	public static TOk? NGNMCNPCFCL<TOk, TErr>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x35070D0", Offset = "0x35064D0", VA = "0x1835070D0")]
	[AsyncStateMachine(typeof(JOOGAEFBKEK<, >))]
	public static Task<TOk?>? KBFMJHEHKOH<TOk, TErr>(this Task<BECHBBIPIFM<TOk, TErr>> KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3506F70", Offset = "0x3506370", VA = "0x183506F70")]
	public static TErr? INNMNKIDKNC<TErr, TOk>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x35042D0", Offset = "0x35036D0", VA = "0x1835042D0")]
	public static bool APIIMPKNJEH<TOk, TErr, UErr, UOk>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [Out] BECHBBIPIFM<UOk, UErr> NJBEDFDFOPC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3505DB0", Offset = "0x35051B0", VA = "0x183505DB0")]
	public static bool DNNEPFJEFJH<TOk, TErr>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [Out] TOk GJMPBLINGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3505D40", Offset = "0x3505140", VA = "0x183505D40")]
	public static bool DLNJAKCHEBG<TOk, TErr>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [Out][NotNullWhen(true)] TErr BJKKGGEDLPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x35055E0", Offset = "0x35049E0", VA = "0x1835055E0")]
	public static bool CAIGAHPMPPM<TOk, TErr>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [Out][NotNullWhen(true)] TOk GJMPBLINGOE, [Out][NotNullWhen(false)] TErr BJKKGGEDLPM) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3505FE0", Offset = "0x35053E0", VA = "0x183505FE0")]
	public static bool FHPHBFJDGGM<TOk, TErr>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [Out][NotNullWhen(true)] TOk GJMPBLINGOE, [Out] BECHBBIPIFM<TOk, TErr> NJBEDFDFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3504540", Offset = "0x3503940", VA = "0x183504540")]
	public static bool APIIMPKNJEH<TOk, TErr, UErr, UOk>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [Out][NotNullWhen(true)] TOk GJMPBLINGOE, [Out] BECHBBIPIFM<UOk, UErr> NJBEDFDFOPC) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x35058C0", Offset = "0x3504CC0", VA = "0x1835058C0")]
	public static bool CKJHNDDMKHB<TOk, TErr>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [Out][NotNullWhen(true)] TOk GJMPBLINGOE, [Out] BECHBBIPIFM<FGGPIMEAIEJ, TErr> NJBEDFDFOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3506440", Offset = "0x3505840", VA = "0x183506440")]
	public static BECHBBIPIFM<UOk, UErr> GLABINFCKDI<UOk, UErr, TOk, TErr>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, [In] BECHBBIPIFM<UOk, UErr> PLCJAHDMBHK) where TOk : UOk where TErr : UErr
	{
		return default(BECHBBIPIFM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3507440", Offset = "0x3506840", VA = "0x183507440")]
	public static BECHBBIPIFM<TOk?[]?, TErr?> NCJALAMJHFA<TOk, TErr>(this IEnumerable<BECHBBIPIFM<TOk, TErr>> KBBJDOAJMAF)
	{
		return default(BECHBBIPIFM<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3506A00", Offset = "0x3505E00", VA = "0x183506A00")]
	public static BECHBBIPIFM<UOk?, TErr?> GMNPIGNGEHD<UOk, TErr, TOk>([In] this BECHBBIPIFM<TOk, TErr> KBBJDOAJMAF, Func<TOk, UOk> FACDMOPDHKC)
	{
		return default(BECHBBIPIFM<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class NLCOJBHEDPN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3D9D2B0", Offset = "0x3D9C6B0", VA = "0x183D9D2B0")]
	public static BECHBBIPIFM<TOk, T> KFBHOMAFMMP<TOk>([In] TOk GJMPBLINGOE) where TOk : notnull
	{
		return default(BECHBBIPIFM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x522A880", Offset = "0x5229C80", VA = "0x18522A880")]
	public static BECHBBIPIFM<FGGPIMEAIEJ, T> KFBHOMAFMMP()
	{
		return default(BECHBBIPIFM<FGGPIMEAIEJ, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D9D2B0", Offset = "0x3D9C6B0", VA = "0x183D9D2B0")]
	public static BECHBBIPIFM<T, TErr> BBPLEKDHCDJ<TErr>([In] TErr BJKKGGEDLPM) where TErr : notnull
	{
		return default(BECHBBIPIFM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct JMKFLEHLHLB<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly AFFDAGMLNGN HJKNNOHCOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> CGKOBDGMCLE;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4CBBF80", Offset = "0x4CBB380", VA = "0x184CBBF80")]
	public static JMKFLEHLHLB<TKey, TValue> FABCCGGAHMJ(string FAJBNOJIOHK)
	{
		return default(JMKFLEHLHLB<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4CBC160", Offset = "0x4CBB560", VA = "0x184CBC160")]
	internal JMKFLEHLHLB(Dictionary<TKey, TValue> OOEMJLHLIHJ, AFFDAGMLNGN LCDIFGOBHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4CBC0B0", Offset = "0x4CBB4B0", VA = "0x184CBC0B0")]
	public AIEHKKJMABL<TKey, TValue> JECEGPIMGKM([Out] Dictionary<TKey, TValue> OOEMJLHLIHJ)
	{
		return default(AIEHKKJMABL<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct AIEHKKJMABL<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> CGKOBDGMCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly DHOELMCHHNP FJOGBCJOCPM;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x28F06D0", Offset = "0x28EFAD0", VA = "0x1828F06D0")]
	internal AIEHKKJMABL(Dictionary<TKey, TValue> OOEMJLHLIHJ, DHOELMCHHNP PEAJBFJKDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4A64290", Offset = "0x4A63690", VA = "0x184A64290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct CJCPKKIDPHM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly AFFDAGMLNGN HJKNNOHCOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> CGKOBDGMCLE;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4CBBF80", Offset = "0x4CBB380", VA = "0x184CBBF80")]
	public static CJCPKKIDPHM<T> FABCCGGAHMJ(string FAJBNOJIOHK)
	{
		return default(CJCPKKIDPHM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4CBC160", Offset = "0x4CBB560", VA = "0x184CBC160")]
	internal CJCPKKIDPHM(HashSet<T> OOEMJLHLIHJ, AFFDAGMLNGN LCDIFGOBHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4CBC0B0", Offset = "0x4CBB4B0", VA = "0x184CBC0B0")]
	public IJLNGNCLHMD<T> JECEGPIMGKM([Out] HashSet<T> OOEMJLHLIHJ)
	{
		return default(IJLNGNCLHMD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct IJLNGNCLHMD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> CGKOBDGMCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DHOELMCHHNP FJOGBCJOCPM;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x28F06D0", Offset = "0x28EFAD0", VA = "0x1828F06D0")]
	internal IJLNGNCLHMD(HashSet<T> OOEMJLHLIHJ, DHOELMCHHNP PEAJBFJKDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4A64290", Offset = "0x4A63690", VA = "0x184A64290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct LCBFAHKPGFE<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AFFDAGMLNGN HJKNNOHCOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> CGKOBDGMCLE;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4CBBF80", Offset = "0x4CBB380", VA = "0x184CBBF80")]
	public static LCBFAHKPGFE<T> FABCCGGAHMJ(string FAJBNOJIOHK)
	{
		return default(LCBFAHKPGFE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4CBC160", Offset = "0x4CBB560", VA = "0x184CBC160")]
	internal LCBFAHKPGFE(Stack<T> OOEMJLHLIHJ, AFFDAGMLNGN LCDIFGOBHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4CBC0B0", Offset = "0x4CBB4B0", VA = "0x184CBC0B0")]
	public LOHJGEEHEBO<T> JECEGPIMGKM([Out] Stack<T> OOEMJLHLIHJ)
	{
		return default(LOHJGEEHEBO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct LOHJGEEHEBO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> CGKOBDGMCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly DHOELMCHHNP FJOGBCJOCPM;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x28F06D0", Offset = "0x28EFAD0", VA = "0x1828F06D0")]
	internal LOHJGEEHEBO(Stack<T> OOEMJLHLIHJ, DHOELMCHHNP PEAJBFJKDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4A64290", Offset = "0x4A63690", VA = "0x184A64290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class KCIJCJKFKDP<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct CLEFAADIHLO : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly KCIJCJKFKDP<T> CHOIFCDJHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int OAPIJKLFKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool MHIKCPNKOMH;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x25E60D0", Offset = "0x25E54D0", VA = "0x1825E60D0")]
		public CLEFAADIHLO(KCIJCJKFKDP<T> GDOONENKGAE, int JNIAHCILLIC, bool HNMDIMHOEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x66301B0", Offset = "0x662F5B0", VA = "0x1866301B0")]
		public KCIJCJKFKDP<T>.FHNOBDJJNGF PMMOLBDEIOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x66302B0", Offset = "0x662F6B0", VA = "0x1866302B0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x66302B0", Offset = "0x662F6B0", VA = "0x1866302B0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class FHNOBDJJNGF : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly KCIJCJKFKDP<T> CHOIFCDJHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int FJBFBOGGGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int OBBFHHADKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool MHIKCPNKOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool PGEEAMEBNJF;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x47D9280", Offset = "0x47D8680", VA = "0x1847D9280")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x47D9510", Offset = "0x47D8910", VA = "0x1847D9510", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x47D97A0", Offset = "0x47D8BA0", VA = "0x1847D97A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x47D9C90", Offset = "0x47D9090", VA = "0x1847D9C90")]
		public FHNOBDJJNGF(KCIJCJKFKDP<T> GDOONENKGAE, int JNIAHCILLIC, bool HNMDIMHOEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x47D9300", Offset = "0x47D8700", VA = "0x1847D9300", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x47D93A0", Offset = "0x47D87A0", VA = "0x1847D93A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NCNHJAMBGDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public NCNHJAMBGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5190C80", Offset = "0x5190080", VA = "0x185190C80")]
		internal T DHCBMCCGFFN(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] OKNPIEPNCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int OBBFHHADKND;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int CHNIHPGBMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4D75660", Offset = "0x4D74A60", VA = "0x184D75660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T CHOEFFOHNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x47C4A70", Offset = "0x47C3E70", VA = "0x1847C4A70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T GCFJBIFLLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4D75880", Offset = "0x4D74C80", VA = "0x184D75880")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4D75810", Offset = "0x4D74C10", VA = "0x184D75810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int GHEOBFHNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x24F59F0", Offset = "0x24F4DF0", VA = "0x1824F59F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x19E2A60", Offset = "0x19E1E60", VA = "0x1819E2A60")]
	private static int BNJFDGPNNBB(int COPLIEINKOF, int CFKBLDHNBAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4D75960", Offset = "0x4D74D60", VA = "0x184D75960")]
	public KCIJCJKFKDP(int LLBNOFGPNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D75A90", Offset = "0x4D74E90", VA = "0x184D75A90")]
	public KCIJCJKFKDP(int LLBNOFGPNDN, Func<T> OJIHJKGIEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D759F0", Offset = "0x4D74DF0", VA = "0x184D759F0")]
	public KCIJCJKFKDP(T[] IMPJLIJJJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D75560", Offset = "0x4D74960", VA = "0x184D75560")]
	public void EKCPAFEHGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D75590", Offset = "0x4D74990", VA = "0x184D75590")]
	public IEnumerable<T> GKDMMKMGENK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D758C0", Offset = "0x4D74CC0", VA = "0x184D758C0")]
	public KCIJCJKFKDP<T>.FHNOBDJJNGF PMMOLBDEIOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x485D0F0", Offset = "0x485C4F0", VA = "0x18485D0F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x485D0F0", Offset = "0x485C4F0", VA = "0x18485D0F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class EGCELHDLHCG
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3529C80", Offset = "0x3529080", VA = "0x183529C80")]
	public static KCIJCJKFKDP<T> FABCCGGAHMJ<T>(int LLBNOFGPNDN, Func<T> OJIHJKGIEOH) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct RRColor : IEquatable<RRColor>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public float r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float b;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float a;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static RRColor White
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7C23520", Offset = "0x7C22920", VA = "0x187C23520")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7C234E0", Offset = "0x7C228E0", VA = "0x187C234E0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7C23500", Offset = "0x7C22900", VA = "0x187C23500")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7C23540", Offset = "0x7C22940", VA = "0x187C23540")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7C234C0", Offset = "0x7C228C0", VA = "0x187C234C0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x26F42A0", Offset = "0x26F36A0", VA = "0x1826F42A0")]
		public RRColor(float DEBKLEONCCD, float MLJCKALDKNN, float MDCPFJBHOAB, float EHIMHGHKFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7AE8420", Offset = "0x7AE7820", VA = "0x187AE8420", Slot = "4")]
		public bool Equals(RRColor DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C23100", Offset = "0x7C22500", VA = "0x187C23100", Slot = "0")]
		public override bool Equals(object DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C23200", Offset = "0x7C22600", VA = "0x187C23200", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C23280", Offset = "0x7C22680", VA = "0x187C23280", Slot = "5")]
		public string ToString(string EIDACCNCFOG, IFormatProvider OEFNOANBGID)
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct RRColor32 : IEquatable<RRColor32>, IFormattable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int rgba;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public byte r;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public byte g;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public byte b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public byte a;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static RRColor32 White
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x7C230A0", Offset = "0x7C224A0", VA = "0x187C230A0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7C23040", Offset = "0x7C22440", VA = "0x187C23040")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7C23070", Offset = "0x7C22470", VA = "0x187C23070")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7C230D0", Offset = "0x7C224D0", VA = "0x187C230D0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7C23010", Offset = "0x7C22410", VA = "0x187C23010")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5B0CED0", Offset = "0x5B0C2D0", VA = "0x185B0CED0")]
		public RRColor32(byte DEBKLEONCCD, byte MLJCKALDKNN, byte MDCPFJBHOAB, byte EHIMHGHKFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x20CB7E0", Offset = "0x20CABE0", VA = "0x1820CB7E0", Slot = "4")]
		public bool Equals(RRColor32 DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C22B50", Offset = "0x7C21F50", VA = "0x187C22B50", Slot = "0")]
		public override bool Equals(object DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1240CC0", Offset = "0x12400C0", VA = "0x181240CC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C22C50", Offset = "0x7C22050", VA = "0x187C22C50")]
		public static RRColor32 HIHFKEJHDAH(RRColor NEIELBLPLNK)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C22BE0", Offset = "0x7C21FE0", VA = "0x187C22BE0")]
		public static RRColor HIHFKEJHDAH(RRColor32 NEIELBLPLNK)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C22DA0", Offset = "0x7C221A0", VA = "0x187C22DA0", Slot = "5")]
		public string ToString(string EIDACCNCFOG, IFormatProvider OEFNOANBGID)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class EOKABFFBJJB<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct GPKLDACLJPL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly EOKABFFBJJB<T> JGOIBNLGJNH;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T APFNDOMNAPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x48D9B90", Offset = "0x48D8F90", VA = "0x1848D9B90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x48D9BB0", Offset = "0x48D8FB0", VA = "0x1848D9BB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
		public GPKLDACLJPL(EOKABFFBJJB<T> JGOIBNLGJNH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HADDBNMGHFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder<GPKLDACLJPL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public EOKABFFBJJB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x49054F0", Offset = "0x49048F0", VA = "0x1849054F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4905C40", Offset = "0x4905040", VA = "0x184905C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly SemaphoreSlim OFDKGJKIBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private T KJFLMPPOCMG;

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x43BAAD0", Offset = "0x43B9ED0", VA = "0x1843BAAD0")]
	public EOKABFFBJJB([In] T KJFLMPPOCMG, int DDEFPCJLJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x43BA9F0", Offset = "0x43B9DF0", VA = "0x1843BA9F0")]
	public EOKABFFBJJB([In] T KJFLMPPOCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x43BA8B0", Offset = "0x43B9CB0", VA = "0x1843BA8B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x43BA910", Offset = "0x43B9D10", VA = "0x1843BA910")]
	public GPKLDACLJPL PNBODFOKPHK()
	{
		return default(GPKLDACLJPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x43BA520", Offset = "0x43B9920", VA = "0x1843BA520")]
	[AsyncStateMachine(typeof(EOKABFFBJJB<>.HADDBNMGHFG))]
	public Task<EOKABFFBJJB<T>.GPKLDACLJPL> DGGHOEAEOGP(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x43BA8F0", Offset = "0x43B9CF0", VA = "0x1843BA8F0")]
	public void EEOMLANPGDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class PMAGAOOJIMF
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7C22800", Offset = "0x7C21C00", VA = "0x187C22800")]
	public static EOKABFFBJJB<FGGPIMEAIEJ> FABCCGGAHMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x353FEB0", Offset = "0x353F2B0", VA = "0x18353FEB0")]
	public static EOKABFFBJJB<T> FABCCGGAHMJ<T>([In] T KJFLMPPOCMG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class ACGHIOINGBJ<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public readonly struct HNNJNIICCHN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly ACGHIOINGBJ<T> OEMLMNDKOGG;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T APFNDOMNAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x4896390", Offset = "0x4895790", VA = "0x184896390")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4978800", Offset = "0x4977C00", VA = "0x184978800", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
		internal HNNJNIICCHN(ACGHIOINGBJ<T> JGOIBNLGJNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct GEDCPMIFKHF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ACGHIOINGBJ<T> OEMLMNDKOGG;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T APFNDOMNAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x4896390", Offset = "0x4895790", VA = "0x184896390")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4896400", Offset = "0x4895800", VA = "0x184896400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
		internal GEDCPMIFKHF(ACGHIOINGBJ<T> JGOIBNLGJNH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct NOMLCBJACGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<GEDCPMIFKHF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public ACGHIOINGBJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private EOKABFFBJJB<FGGPIMEAIEJ>.GPKLDACLJPL <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private TaskAwaiter<EOKABFFBJJB<FGGPIMEAIEJ>.GPKLDACLJPL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x522F900", Offset = "0x522ED00", VA = "0x18522F900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4905C40", Offset = "0x4905040", VA = "0x184905C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly EOKABFFBJJB<int> INOCAPCBJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly EOKABFFBJJB<FGGPIMEAIEJ> HGIOMOIEGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly EOKABFFBJJB<FGGPIMEAIEJ> ENHALDMCLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private T LMKKPAFNKIO;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x48A4850", Offset = "0x48A3C50", VA = "0x1848A4850")]
	internal ACGHIOINGBJ(EOKABFFBJJB<int> CPDEHFPOMGI, EOKABFFBJJB<FGGPIMEAIEJ> HKLGIELNLKO, EOKABFFBJJB<FGGPIMEAIEJ> GDLFEFFJPEI, [In] T KJFLMPPOCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x48A3B20", Offset = "0x48A2F20", VA = "0x1848A3B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x48A43C0", Offset = "0x48A37C0", VA = "0x1848A43C0")]
	public HNNJNIICCHN PIILCCNLJDB()
	{
		return default(HNNJNIICCHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x48A3F30", Offset = "0x48A3330", VA = "0x1848A3F30")]
	public GEDCPMIFKHF NCDIIFOABOB()
	{
		return default(GEDCPMIFKHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x48A3E00", Offset = "0x48A3200", VA = "0x1848A3E00")]
	[AsyncStateMachine(typeof(ACGHIOINGBJ<>.NOMLCBJACGH))]
	public Task<ACGHIOINGBJ<T>.GEDCPMIFKHF> GPKDHOHIICG(CancellationToken JDDHIJBJNHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IOEGBACPBAM
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C21470", Offset = "0x7C20870", VA = "0x187C21470")]
	public static ACGHIOINGBJ<FGGPIMEAIEJ> FABCCGGAHMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3738600", Offset = "0x3737A00", VA = "0x183738600")]
	public static ACGHIOINGBJ<T> FABCCGGAHMJ<T>([In] T KJFLMPPOCMG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class AELKLDIEDNK<TData> : IDMJKCLDJLO where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly string FINCLBNLBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly TData ODKGCMKKMAA;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
	public override string CPMOFLNCDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x48B0100", Offset = "0x48AF500", VA = "0x1848B0100")]
	internal AELKLDIEDNK(string FGEBHLNNMNH, [In] TData AOFGGGKINCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JBDPMEMCGNA
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7C21540", Offset = "0x7C20940", VA = "0x187C21540")]
	public static AELKLDIEDNK<FGGPIMEAIEJ> FABCCGGAHMJ(string FGEBHLNNMNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x34FC3B0", Offset = "0x34FB7B0", VA = "0x1834FC3B0")]
	public static AELKLDIEDNK<TData> FABCCGGAHMJ<TData>(string FGEBHLNNMNH, [In] TData AOFGGGKINCN) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class AFFDAGMLNGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	internal bool HEBMOGAMNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly string JOPIAGHHBIC;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xDE2BC0", Offset = "0xDE1FC0", VA = "0x180DE2BC0")]
	private AFFDAGMLNGN(bool KKEEPKHCKAE, string GBKIIDJHBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F170", Offset = "0x7C1E570", VA = "0x187C1F170")]
	public static AFFDAGMLNGN FABCCGGAHMJ(string GBKIIDJHBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7C1F1E0", Offset = "0x7C1E5E0", VA = "0x187C1F1E0")]
	public DHOELMCHHNP JECEGPIMGKM()
	{
		return default(DHOELMCHHNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct DHOELMCHHNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly AFFDAGMLNGN LIDLEBGMDLD;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
	internal DHOELMCHHNP(AFFDAGMLNGN FAJBNOJIOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7C20140", Offset = "0x7C1F540", VA = "0x187C20140", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class LLBIAGIFJEB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class PBACICGFFMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public PBACICGFFMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x542C800", Offset = "0x542BC00", VA = "0x18542C800")]
		internal int LGKADLLNOCB(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private HashSet<T>? JFCJICEDFDM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> KPAGIKNFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4ECC6E0", Offset = "0x4ECBAE0", VA = "0x184ECC6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GONENFDIEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4ECC720", Offset = "0x4ECBB20", VA = "0x184ECC720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9D75F0", Offset = "0x9D69F0", VA = "0x1809D75F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4ECC500", Offset = "0x4ECB900", VA = "0x184ECC500")]
	public bool FGAAHPGCDNG(T PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4ECC8B0", Offset = "0x4ECBCB0", VA = "0x184ECC8B0")]
	public bool NMPKBAOEGPN(T PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4ECC770", Offset = "0x4ECBB70", VA = "0x184ECC770")]
	public bool HEMHPGJLPIO(T PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4ECC7C0", Offset = "0x4ECBBC0", VA = "0x184ECC7C0")]
	public void KLEFLBGJOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4ECCA30", Offset = "0x4ECBE30", VA = "0x184ECCA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public LLBIAGIFJEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class MPPAGCOCNOM
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class BHBKDODLPJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public BHBKDODLPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FB60", Offset = "0x7C1EF60", VA = "0x187C1FB60")]
		internal int LGKADLLNOCB(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private HashSet<object>? JFCJICEDFDM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> KPAGIKNFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7C21DA0", Offset = "0x7C211A0", VA = "0x187C21DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool GONENFDIEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7C21E30", Offset = "0x7C21230", VA = "0x187C21E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9D75F0", Offset = "0x9D69F0", VA = "0x1809D75F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7C21CC0", Offset = "0x7C210C0", VA = "0x187C21CC0")]
	public bool FGAAHPGCDNG(object PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7C21F10", Offset = "0x7C21310", VA = "0x187C21F10")]
	public bool NMPKBAOEGPN(object PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7C21E40", Offset = "0x7C21240", VA = "0x187C21E40")]
	public bool HEMHPGJLPIO(object PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7C21EA0", Offset = "0x7C212A0", VA = "0x187C21EA0")]
	public void KLEFLBGJOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7C21FB0", Offset = "0x7C213B0", VA = "0x187C21FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public MPPAGCOCNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class DAPKNDOMACJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private struct MIAJAOJHDNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float IJABIMOAFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public T APFNDOMNAPN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Dictionary<object, MIAJAOJHDNN> CGCBFDCMBPH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T MEHELIKBLHC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x18D64C0", Offset = "0x18D58C0", VA = "0x1818D64C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x18D5180", Offset = "0x18D4580", VA = "0x1818D5180", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? BMAJEPIHIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HCAOEIALIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x50DEA90", Offset = "0x50DDE90", VA = "0x1850DEA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6850CF0", Offset = "0x68500F0", VA = "0x186850CF0")]
	public bool NHKFLJLIHMM(T OOEMJLHLIHJ, object PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x50DE1D0", Offset = "0x50DD5D0", VA = "0x1850DE1D0")]
	public bool KGLIOHALILA(object PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FC50", Offset = "0x4A7F050", VA = "0x184A7FC50")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x684F1F0", Offset = "0x684E5F0", VA = "0x18684F1F0")]
	public bool EHIFOHHFDPG(object PAHPIGHLKFG, [Out] T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x684F600", Offset = "0x684EA00", VA = "0x18684F600")]
	[KGMEPOOFPPN("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool LNOJLCBDEFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x54A50D0", Offset = "0x54A44D0", VA = "0x1854A50D0")]
	public DAPKNDOMACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class CGINFLLJDDM : IHHDCCEAMCD<LIHEKALDDOB>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class ACMMPDEEBPE : IEqualityComparer<LIHEKALDDOB>
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		internal static readonly ACMMPDEEBPE IADGMEFIGGI;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F0D0", Offset = "0x7C1E4D0", VA = "0x187C1F0D0", Slot = "4")]
		public bool Equals(LIHEKALDDOB COBPEJEHIHC, LIHEKALDDOB CEJJJCAALLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD74C0", Offset = "0x6DD68C0", VA = "0x186DD74C0", Slot = "5")]
		public int GetHashCode(LIHEKALDDOB KLANNNFBLNB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public ACMMPDEEBPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FE60", Offset = "0x7C1F260", VA = "0x187C1FE60")]
	public CGINFLLJDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FC70", Offset = "0x7C1F070", VA = "0x187C1FC70", Slot = "4")]
	public override bool FGAAHPGCDNG(LIHEKALDDOB PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FDB0", Offset = "0x7C1F1B0", VA = "0x187C1FDB0", Slot = "5")]
	public override bool NMPKBAOEGPN(LIHEKALDDOB PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FD20", Offset = "0x7C1F120", VA = "0x187C1FD20")]
	private static void FJOAADAFAEF(LIHEKALDDOB PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x17B4A50", Offset = "0x17B3E50", VA = "0x1817B4A50", Slot = "6")]
	protected override string TokenToString(LIHEKALDDOB PAHPIGHLKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class LIHEKALDDOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly string DFJBCPLGBHF;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	public LIHEKALDDOB(string DFJBCPLGBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7C21BD0", Offset = "0x7C20FD0", VA = "0x187C21BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class IHHDCCEAMCD<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly IEqualityComparer<T> CIEFMHCOCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private HashSet<T>? JFCJICEDFDM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GONENFDIEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4A5C120", Offset = "0x4A5B520", VA = "0x184A5C120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xC46200", Offset = "0xC45600", VA = "0x180C46200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4A5CC20", Offset = "0x4A5C020", VA = "0x184A5CC20")]
	public IHHDCCEAMCD(IEqualityComparer<T> CIEFMHCOCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4A5BF30", Offset = "0x4A5B330", VA = "0x184A5BF30", Slot = "4")]
	public virtual bool FGAAHPGCDNG(T PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x4A5C3E0", Offset = "0x4A5B7E0", VA = "0x184A5C3E0", Slot = "5")]
	public virtual bool NMPKBAOEGPN(T PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4A5C170", Offset = "0x4A5B570", VA = "0x184A5C170")]
	public void KLEFLBGJOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4A5C870", Offset = "0x4A5BC70", VA = "0x184A5C870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class MECPPANJKED<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<WeakReference<T>>? JFCJICEDFDM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool GONENFDIEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x50B28D0", Offset = "0x50B1CD0", VA = "0x1850B28D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x50B2C00", Offset = "0x50B2000", VA = "0x1850B2C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x50B2640", Offset = "0x50B1A40", VA = "0x1850B2640")]
	public void FGAAHPGCDNG(T PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x50B2A50", Offset = "0x50B1E50", VA = "0x1850B2A50")]
	public void NMPKBAOEGPN(T PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x50B2A00", Offset = "0x50B1E00", VA = "0x1850B2A00")]
	public void KLEFLBGJOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x50B2DB0", Offset = "0x50B21B0", VA = "0x1850B2DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public MECPPANJKED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class GPFOAJLBIKA
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x36CB160", Offset = "0x36CA560", VA = "0x1836CB160")]
	public static void ADMEPAJDPKD<T>(this List<T> ANHMDLEGCDL, int COPLIEINKOF) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class MLOJMLOJNPD<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct AAJFBLJHPIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public float IJABIMOAFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public T APFNDOMNAPN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<LIHEKALDDOB, AAJFBLJHPIP> CGCBFDCMBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EqualityComparer<T> ODEEKFLHJPF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual T MEHELIKBLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9C91C0", Offset = "0x9C85C0", VA = "0x1809C91C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9C9250", Offset = "0x9C8650", VA = "0x1809C9250", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private LIHEKALDDOB? BMAJEPIHIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool HCAOEIALIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x50DEA90", Offset = "0x50DDE90", VA = "0x1850DEA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x50DE850", Offset = "0x50DDC50", VA = "0x1850DE850")]
	public bool NHKFLJLIHMM(T OOEMJLHLIHJ, LIHEKALDDOB PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x50DE1D0", Offset = "0x50DD5D0", VA = "0x1850DE1D0")]
	public bool KGLIOHALILA(LIHEKALDDOB PAHPIGHLKFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FC50", Offset = "0x4A7F050", VA = "0x184A7FC50")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x50DE140", Offset = "0x50DD540", VA = "0x1850DE140")]
	public bool EHIFOHHFDPG(LIHEKALDDOB PAHPIGHLKFG, [Out] T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x50DE580", Offset = "0x50DD980", VA = "0x1850DE580")]
	[KGMEPOOFPPN("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool LNOJLCBDEFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x50DEAF0", Offset = "0x50DDEF0", VA = "0x1850DEAF0")]
	public MLOJMLOJNPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class LGFCJFLDMJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Dictionary<object, float> CGCBFDCMBPH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float DEBMCLLNEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xEA4540", Offset = "0xEA3940", VA = "0x180EA4540")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xEA4550", Offset = "0xEA3950", VA = "0x180EA4550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C21AD0", Offset = "0x7C20ED0", VA = "0x187C21AD0")]
	public void NHKFLJLIHMM(float OOEMJLHLIHJ, object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7C21A60", Offset = "0x7C20E60", VA = "0x187C21A60")]
	public void KGLIOHALILA(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7C218E0", Offset = "0x7C20CE0", VA = "0x187C218E0")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7C21930", Offset = "0x7C20D30", VA = "0x187C21930")]
	private void IPKGPMKBLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7C21B40", Offset = "0x7C20F40", VA = "0x187C21B40")]
	public LGFCJFLDMJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface JOOCMKBCAMM
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event IIACEPHHMFF KJHJGNDJICK;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class DMFFGJNNEKN : JOOCMKBCAMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public readonly struct PMJHLAJMLLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float BOFHKCJPDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly float JKFMEKJLDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal readonly bool CMMDKLGDPDP;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float JFMOMNOKICG
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7C22870", Offset = "0x7C21C70", VA = "0x187C22870")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7C229F0", Offset = "0x7C21DF0", VA = "0x187C229F0")]
		public PMJHLAJMLLM(float KAHCMHKHPHM, float CBHCNOAGPIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7C22880", Offset = "0x7C21C80", VA = "0x187C22880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class MBCNFCOGGHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public DMFFGJNNEKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public MBCNFCOGGHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C20", Offset = "0x7C21020", VA = "0x187C21C20")]
		internal void NIELOLGEDGH(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly int NPKCINNDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private int HOBEABMJIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly JOOCMKBCAMM[] CJIBKDLDPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly IIACEPHHMFF[] HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly PMJHLAJMLLM[] JBDAOKDMMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private PMJHLAJMLLM GINNLACPODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly DHAJBAACLNK CALHFHIGDPO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event IIACEPHHMFF KJHJGNDJICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7C20270", Offset = "0x7C1F670", VA = "0x187C20270", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7C203C0", Offset = "0x7C1F7C0", VA = "0x187C203C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7C20900", Offset = "0x7C1FD00", VA = "0x187C20900")]
	public DMFFGJNNEKN(int NPKCINNDJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7C20330", Offset = "0x7C1F730", VA = "0x187C20330")]
	public DHAJBAACLNK HPBIAFHBKOO(PMJHLAJMLLM OGPEFHDLAJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7C20480", Offset = "0x7C1F880", VA = "0x187C20480")]
	public void NFNPPEAFFDP(JOOCMKBCAMM CGPDFAOJHPP, [Optional] PMJHLAJMLLM EEHPKINABGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7C20160", Offset = "0x7C1F560", VA = "0x187C20160", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public delegate void IIACEPHHMFF(float DPADJBEFPIN);
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class OOOPJBHLKKB
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class IIMDNCFEDBL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly JOOCMKBCAMM GLBJEECHPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly IIACEPHHMFF IBDCICFCEPJ;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7C213E0", Offset = "0x7C207E0", VA = "0x187C213E0")]
		public IIMDNCFEDBL(JOOCMKBCAMM GLBJEECHPKA, IIACEPHHMFF IBDCICFCEPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7C21390", Offset = "0x7C20790", VA = "0x187C21390", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7C22300", Offset = "0x7C21700", VA = "0x187C22300")]
	internal static bool OMNCIKKGKLP(float EHIMHGHKFCP, float MDCPFJBHOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C10280", Offset = "0x7C0F680", VA = "0x187C10280")]
	internal static float HEPHMAJEMND(float EHIMHGHKFCP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7C22240", Offset = "0x7C21640", VA = "0x187C22240")]
	public static IDisposable MIINDMAHLFD(this JOOCMKBCAMM GLBJEECHPKA, IIACEPHHMFF IBDCICFCEPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DHAJBAACLNK : JOOCMKBCAMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private float DPADJBEFPIN;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float PCOODEDIHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7C1FF10", Offset = "0x7C1F310", VA = "0x187C1FF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event IIACEPHHMFF? KJHJGNDJICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7C20000", Offset = "0x7C1F400", VA = "0x187C20000", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7C200A0", Offset = "0x7C1F4A0", VA = "0x187C200A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public DHAJBAACLNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface CMOHGAMBCMC<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HINNEHFLCMG<T> GEKLKKKAMOM([Out] T OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENAIKFMHAAL();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class CMDMCKGKMMP<T> : CMOHGAMBCMC<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ConcurrentStack<T> FDJOIJENIHD;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6632830", Offset = "0x6631C30", VA = "0x186632830", Slot = "4")]
	public HINNEHFLCMG<T> GEKLKKKAMOM([Out] T OOEMJLHLIHJ)
	{
		return default(HINNEHFLCMG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6632700", Offset = "0x6631B00", VA = "0x186632700")]
	public void AOLPCAOCNBA(T AFDHHEHCOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4979FC0", Offset = "0x49793C0", VA = "0x184979FC0", Slot = "5")]
	public void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "6")]
	protected virtual void OBICJOMFEON(T EKJOHPBDIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6632780", Offset = "0x6631B80", VA = "0x186632780")]
	private T DANLDNLMJMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x66328D0", Offset = "0x6631CD0", VA = "0x1866328D0")]
	public CMDMCKGKMMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct HINNEHFLCMG<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly T AFDHHEHCOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CMDMCKGKMMP<T> CJKIKLHHFMN;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
	internal HINNEHFLCMG(T OOEMJLHLIHJ, CMDMCKGKMMP<T> CJKIKLHHFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4928070", Offset = "0x4927470", VA = "0x184928070", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class GMDNBCIIFAP : CMDMCKGKMMP<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly GMDNBCIIFAP IADGMEFIGGI;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7C20AD0", Offset = "0x7C1FED0", VA = "0x187C20AD0")]
	public static HINNEHFLCMG<StringBuilder> DANLDNLMJMK([Out] StringBuilder OOEMJLHLIHJ)
	{
		return default(HINNEHFLCMG<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7C20B70", Offset = "0x7C1FF70", VA = "0x187C20B70", Slot = "6")]
	protected override void OBICJOMFEON(StringBuilder EKJOHPBDIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7C20C30", Offset = "0x7C20030", VA = "0x187C20C30")]
	public GMDNBCIIFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class LHHHKIOKDPM : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7523BB0", Offset = "0x7522FB0", VA = "0x187523BB0")]
	public LHHHKIOKDPM(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class CFPLAMNFLDE<TKey, TValue> : EDOIIKPOMOO<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, KKNBMIAMOJJ where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class OLAJLHAPBIA : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CFPLAMNFLDE<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x18D64C0", Offset = "0x18D58C0", VA = "0x1818D64C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x48256B0", Offset = "0x4824AB0", VA = "0x1848256B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public OLAJLHAPBIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x48258C0", Offset = "0x4824CC0", VA = "0x1848258C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5370840", Offset = "0x536FC40", VA = "0x185370840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x536FF30", Offset = "0x536F330", VA = "0x18536FF30")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x536FFD0", Offset = "0x536F3D0", VA = "0x18536FFD0")]
		private void LNCBGHLOKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x5370CD0", Offset = "0x53700D0", VA = "0x185370CD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly EDOIIKPOMOO<TKey, TValue> FGGDCLKLHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IDictionary<TKey, TValue> DIEDFKJGJKC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6472A40", Offset = "0x6471E40", VA = "0x186472A40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HGFLKIPPAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public TValue LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6472CF0", Offset = "0x64720F0", VA = "0x186472CF0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6472FA0", Offset = "0x64723A0", VA = "0x186472FA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ICollection<TKey> PDCDFPKJDDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6472D40", Offset = "0x6472140", VA = "0x186472D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TValue> KCNBNAHBCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6472E70", Offset = "0x6472270", VA = "0x186472E70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6472970", Offset = "0x6471D70", VA = "0x186472970")]
	public CFPLAMNFLDE(EDOIIKPOMOO<TKey, TValue> FGGDCLKLHIO, [Optional] IDictionary<TKey, TValue>? DIEDFKJGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6470080", Offset = "0x646F480", VA = "0x186470080", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6470D30", Offset = "0x6470130", VA = "0x186470D30")]
	public void GEGKANAGELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x646FD10", Offset = "0x646F110", VA = "0x18646FD10", Slot = "9")]
	public void Add(TKey IICGAABOENK, TValue OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6470980", Offset = "0x646FD80", VA = "0x186470980")]
	public void EBHLNGHPAJA(TKey IICGAABOENK, TValue OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6471A30", Offset = "0x6470E30", VA = "0x186471A30")]
	public void MLHBAAFGEBI(TKey IICGAABOENK, TValue OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x64713B0", Offset = "0x64707B0", VA = "0x1864713B0")]
	public void KDLDOAEJKAC(TKey IICGAABOENK, TValue OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6470E70", Offset = "0x6470270", VA = "0x186470E70")]
	public void GEJBAMDOMAK(TKey IICGAABOENK, TValue OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6471FD0", Offset = "0x64713D0", VA = "0x186471FD0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x64721C0", Offset = "0x64715C0", VA = "0x1864721C0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6472520", Offset = "0x6471920", VA = "0x186472520", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x64701C0", Offset = "0x646F5C0", VA = "0x1864701C0", Slot = "8")]
	public bool ContainsKey(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6471C40", Offset = "0x6471040", VA = "0x186471C40")]
	public bool PFPDHDFADFF(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6470C60", Offset = "0x6470060", VA = "0x186470C60")]
	public bool EEHIFHAFFNB(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6471D10", Offset = "0x6471110", VA = "0x186471D10", Slot = "10")]
	public bool Remove(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x64726E0", Offset = "0x6471AE0", VA = "0x1864726E0", Slot = "11")]
	public bool TryGetValue(TKey IICGAABOENK, [Out] TValue OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6470290", Offset = "0x646F690", VA = "0x186470290", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] IMLJIFPAFGH, int MCHPHAOBGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4D4AB10", Offset = "0x4D49F10", VA = "0x184D4AB10", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6471250", Offset = "0x6470650", VA = "0x186471250", Slot = "19")]
	[IteratorStateMachine(typeof(CFPLAMNFLDE<, >.OLAJLHAPBIA))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x6471910", Offset = "0x6470D10", VA = "0x186471910", Slot = "21")]
	public bool MALIEBJAGNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6471140", Offset = "0x6470540", VA = "0x186471140")]
	private TValue GOGIOONJAPB(TKey IICGAABOENK)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface LKKOOJGPKIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string NILILKMICJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface KKNBMIAMOJJ
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MALIEBJAGNG();
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface EDOIIKPOMOO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KKNBMIAMOJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DefaultMember("Item")]
public sealed class DBCKBHEENGK<TKey, TVal> : EDOIIKPOMOO<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, KKNBMIAMOJJ where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public delegate int FIHMCMBPEOG(TKey IICGAABOENK, TVal OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate void DCHBJLJABNJ(TKey IICGAABOENK, TVal OOEMJLHLIHJ, CDPNACNMEPL HJCCPGPOLBJ);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private class GCLPAANLKME
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public TKey HGAANBOBAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TVal APFNDOMNAPN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xC46200", Offset = "0xC45600", VA = "0x180C46200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int JFMOMNOKICG
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xCD7890", Offset = "0xCD6C90", VA = "0x180CD7890")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xEBE7C0", Offset = "0xEBDBC0", VA = "0x180EBE7C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DateTimeOffset CPMMOKEHFKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x120A900", Offset = "0x1209D00", VA = "0x18120A900")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x120A8F0", Offset = "0x1209CF0", VA = "0x18120A8F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x488F5C0", Offset = "0x488E9C0", VA = "0x18488F5C0")]
		public GCLPAANLKME(TKey IICGAABOENK, TVal DBALGCNBEDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class GPGKJABHNOL : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public DBCKBHEENGK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private LinkedList<GCLPAANLKME>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x18D64C0", Offset = "0x18D58C0", VA = "0x1818D64C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x48D99C0", Offset = "0x48D8DC0", VA = "0x1848D99C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
		[DebuggerHidden]
		public GPGKJABHNOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x481FFA0", Offset = "0x481F3A0", VA = "0x18481FFA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x48D7BF0", Offset = "0x48D6FF0", VA = "0x1848D7BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x48D6BB0", Offset = "0x48D5FB0", VA = "0x1848D6BB0")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x48D9880", Offset = "0x48D8C80", VA = "0x1848D9880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public const int IPIBLLPJAPM = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<TKey, LinkedListNode<GCLPAANLKME>> PBLHKLOGPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LinkedList<GCLPAANLKME> KJPKNLBNOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly FIHMCMBPEOG? EMHBGCNJIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly TimeSpan BBKINJFPBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly DCHBJLJABNJ? IDJDLPLNJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly IHPFFPOEDNM OAFIJBNJOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool AEAIKFBPBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly List<TKey> EJGHKJGPEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<TVal> OJIGKCFBGPC;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int MMGEIDHINCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DA090", Offset = "0x9D9490", VA = "0x1809DA090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	internal int DCPJDOAGFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xCDBA00", Offset = "0xCDAE00", VA = "0x180CDBA00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xE1BBB0", Offset = "0xE1AFB0", VA = "0x180E1BBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x686EFC0", Offset = "0x686E3C0", VA = "0x18686EFC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	internal int EDBMFHNKNOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4A7FC50", Offset = "0x4A7F050", VA = "0x184A7FC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public ICollection<TVal> KCNBNAHBCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x686F130", Offset = "0x686E530", VA = "0x18686F130", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ICollection<TKey> IDictionary<TKey, TVal>.IMKNAALLHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6869D00", Offset = "0x6869100", VA = "0x186869D00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool HGFLKIPPAKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public TVal LLPDOJHGAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x686F060", Offset = "0x686E460", VA = "0x18686F060", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x686F180", Offset = "0x686E580", VA = "0x18686F180", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6853FA0", Offset = "0x68533A0", VA = "0x186853FA0")]
	private bool CPNNOAPLHFF(int NPKCINNDJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x68604C0", Offset = "0x685F8C0", VA = "0x1868604C0")]
	private void NBBIMJICPIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x686BC20", Offset = "0x686B020", VA = "0x18686BC20")]
	public DBCKBHEENGK(int NPKCINNDJFE, [Optional] FIHMCMBPEOG? EMHBGCNJIAP, [Optional] IEqualityComparer<TKey>? OFJPNJJCFGB, [Optional] DCHBJLJABNJ? IDJDLPLNJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x686B560", Offset = "0x686A960", VA = "0x18686B560")]
	public DBCKBHEENGK(TimeSpan BBKINJFPBIN, [Optional] IEqualityComparer<TKey>? OFJPNJJCFGB, [Optional] DCHBJLJABNJ? IDJDLPLNJGB, [Optional] IHPFFPOEDNM? OAFIJBNJOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x686CB60", Offset = "0x686BF60", VA = "0x18686CB60")]
	public DBCKBHEENGK(int NPKCINNDJFE, TimeSpan BBKINJFPBIN, [Optional] IEqualityComparer<TKey>? OFJPNJJCFGB, [Optional] DCHBJLJABNJ? IDJDLPLNJGB, [Optional] IHPFFPOEDNM? OAFIJBNJOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x686C6E0", Offset = "0x686BAE0", VA = "0x18686C6E0")]
	public DBCKBHEENGK(int NPKCINNDJFE, FIHMCMBPEOG? EMHBGCNJIAP, TimeSpan BBKINJFPBIN, [Optional] IEqualityComparer<TKey>? OFJPNJJCFGB, [Optional] DCHBJLJABNJ? IDJDLPLNJGB, [Optional] IHPFFPOEDNM? OAFIJBNJOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6860410", Offset = "0x685F810", VA = "0x186860410", Slot = "21")]
	public bool MALIEBJAGNG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x685F680", Offset = "0x685EA80", VA = "0x18685F680", Slot = "22")]
	public bool JDBODCGJHNO(int LLBNOFGPNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6857900", Offset = "0x6856D00", VA = "0x186857900")]
	private bool FCOGGCOAMDM(int LLBNOFGPNDN, CDPNACNMEPL HJCCPGPOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x6860050", Offset = "0x685F450", VA = "0x186860050")]
	public void KFMFOPCGNHM(TKey IICGAABOENK, TVal OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6851C00", Offset = "0x6851000", VA = "0x186851C00", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NNAMOJMJBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x68520E0", Offset = "0x68514E0", VA = "0x1868520E0", Slot = "9")]
	public void Add(TKey IICGAABOENK, TVal OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6854260", Offset = "0x6853660", VA = "0x186854260", Slot = "8")]
	public bool ContainsKey(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6869420", Offset = "0x6868820", VA = "0x186869420", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6868E60", Offset = "0x6868260", VA = "0x186868E60", Slot = "10")]
	public bool Remove(TKey IICGAABOENK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6869830", Offset = "0x6868C30", VA = "0x186869830", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> NNAMOJMJBHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x68534F0", Offset = "0x68528F0", VA = "0x1868534F0")]
	private bool BCKMHKMPNLK(TKey IICGAABOENK, [Out] TVal OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6857390", Offset = "0x6856790", VA = "0x186857390")]
	private TVal DANLDNLMJMK(TKey GHJMAJOGKDG)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x686A810", Offset = "0x6869C10", VA = "0x18686A810", Slot = "11")]
	public bool TryGetValue(TKey GHJMAJOGKDG, [Out] TVal OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6853FF0", Offset = "0x68533F0", VA = "0x186853FF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6856920", Offset = "0x6855D20", VA = "0x186856920", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IMLJIFPAFGH, int MCHPHAOBGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6865370", Offset = "0x6864770", VA = "0x186865370")]
	private void NEDCOJHFJFG(TKey IICGAABOENK, TVal DBALGCNBEDK, CDPNACNMEPL HJCCPGPOLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x685C420", Offset = "0x685B820", VA = "0x18685C420")]
	private bool FELPHCGBDDN(GCLPAANLKME FOEKDMJHKIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x68631E0", Offset = "0x68625E0", VA = "0x1868631E0")]
	private void NDNDBDLEHIB(LinkedListNode<GCLPAANLKME> OOEGAJBKCMB, TVal IFDGCBGIKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6866BB0", Offset = "0x6865FB0", VA = "0x186866BB0")]
	private void NHKFLJLIHMM(TKey IICGAABOENK, TVal OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x685EF90", Offset = "0x685E390", VA = "0x18685EF90")]
	private void IMPCKFKBFEK(GCLPAANLKME FOEKDMJHKIO, TVal IFDGCBGIKDO, int FHFIKCKHPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x685D600", Offset = "0x685CA00", VA = "0x18685D600", Slot = "19")]
	[IteratorStateMachine(typeof(DBCKBHEENGK<, >.GPGKJABHNOL))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6869D50", Offset = "0x6869150", VA = "0x186869D50", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum CDPNACNMEPL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class HIBGONJPIOE<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly TKey GKPGKICOGBL;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4927A00", Offset = "0x4926E00", VA = "0x184927A00")]
	public HIBGONJPIOE(TKey PPHJLENHPDN, Exception BNECGNPLEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PKONLLDMKMG : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6D764C0", Offset = "0x6D758C0", VA = "0x186D764C0")]
	public PKONLLDMKMG(string FGEBHLNNMNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class GFGPLDJIGJO<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class IPCAPPCIPOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public GFGPLDJIGJO<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public IPCAPPCIPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4A7D920", Offset = "0x4A7CD20", VA = "0x184A7D920")]
		internal Task<TResource> MHKGHGLPEAH(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct OACKDEGPBLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public GFGPLDJIGJO<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x532B610", Offset = "0x532AA10", VA = "0x18532B610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x532BA30", Offset = "0x532AE30", VA = "0x18532BA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct NFIBKLMHEPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5196690", Offset = "0x5195A90", VA = "0x185196690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5196DD0", Offset = "0x51961D0", VA = "0x185196DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly HKFCAPGKOOH<TId, Task<TResource>> MPAHGGJBGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> CBBNGHGCPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? EJDGFJANPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Action<TResource>? AOECIIMDAAN;

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x48B90D0", Offset = "0x48B84D0", VA = "0x1848B90D0")]
	public GFGPLDJIGJO(int LFOHOAHFJHB = 0, [Optional] IEqualityComparer<TId>? ADOJPPHDNIO, [Optional] Func<TId, CancellationToken, Task<TResource>>? GJFDGLJHIFA, [Optional] Action<TResource>? JKENHJLKKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x48B8770", Offset = "0x48B7B70", VA = "0x1848B8770")]
	public BCNNKHLMADP<Task<TResource>> KCMPOCLEKNE(TId FBLIJIPJKFJ, [Optional] Func<TId, CancellationToken, Task<TResource>>? GJFDGLJHIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x48B7DC0", Offset = "0x48B71C0", VA = "0x1848B7DC0")]
	private void DIIFFIKCKMH(Task<TResource> OOCBIOLELBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x48B8960", Offset = "0x48B7D60", VA = "0x1848B8960")]
	[AsyncStateMachine(typeof(GFGPLDJIGJO<, >.OACKDEGPBLC))]
	private Task NCLCBKADKMJ(Task<TResource> OOCBIOLELBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x48B8150", Offset = "0x48B7550", VA = "0x1848B8150")]
	public void JLFHPJBPIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x48B8DE0", Offset = "0x48B81E0", VA = "0x1848B8DE0")]
	public HKFCAPGKOOH<TId, Task<TResource>>.HNOMHDOAEDL PMMOLBDEIOM()
	{
		return default(HKFCAPGKOOH<TId, Task<TResource>>.HNOMHDOAEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x48B8EE0", Offset = "0x48B82E0", VA = "0x1848B8EE0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x48B8EE0", Offset = "0x48B82E0", VA = "0x1848B8EE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x48B77D0", Offset = "0x48B6BD0", VA = "0x1848B77D0")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(GFGPLDJIGJO<, >.NFIBKLMHEPN))]
	internal static Task CAKFNBLPLGC(Task<TResource> OOCBIOLELBN, CancellationTokenSource FGGJCHOJHOA, Dictionary<Task<TResource>, CancellationTokenSource> PODHAAOMPAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class HKFCAPGKOOH<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private sealed class NNIADAOKDJL : IEquatable<NNIADAOKDJL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly TValue APFNDOMNAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int IDCBNEAGCIN;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1117350", Offset = "0x1116750", VA = "0x181117350")]
		public NNIADAOKDJL(TValue OOEMJLHLIHJ, int LJPAPEBPCFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x522D640", Offset = "0x522CA40", VA = "0x18522D640", Slot = "4")]
		public bool Equals(NNIADAOKDJL? DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x522D6D0", Offset = "0x522CAD0", VA = "0x18522D6D0", Slot = "0")]
		public override bool Equals(object? KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x522D810", Offset = "0x522CC10", VA = "0x18522D810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct HNOMHDOAEDL : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Dictionary<TKey, NNIADAOKDJL>.Enumerator MBLNIDDHEFB;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4978CE0", Offset = "0x49780E0", VA = "0x184978CE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public (TKey Key, TValue Value, int RefCount) CHOEFFOHNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4979370", Offset = "0x4978770", VA = "0x184979370", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x4978FA0", Offset = "0x49783A0", VA = "0x184978FA0")]
		public HNOMHDOAEDL(HKFCAPGKOOH<TKey, TValue> CGCBFDCMBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x4978920", Offset = "0x4977D20", VA = "0x184978920", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x4978960", Offset = "0x4977D60", VA = "0x184978960", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4978A20", Offset = "0x4977E20", VA = "0x184978A20", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class GKIGCFOKGPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public HKFCAPGKOOH<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public NNIADAOKDJL refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public GKIGCFOKGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x48C3A20", Offset = "0x48C2E20", VA = "0x1848C3A20")]
		internal void MHKGHGLPEAH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly Dictionary<TKey, NNIADAOKDJL> PNGHMBNFNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly Func<TKey, TValue>? JAEFNALPBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Action<TValue>? GGBHEHOMDDO;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x49445D0", Offset = "0x49439D0", VA = "0x1849445D0")]
	public HKFCAPGKOOH(int LFOHOAHFJHB = 0, [Optional] IEqualityComparer<TKey>? OFJPNJJCFGB, [Optional] Func<TKey, TValue>? MFLNCCDCEMK, [Optional] Action<TValue>? IIPAMHLBBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4943660", Offset = "0x4942A60", VA = "0x184943660")]
	public BCNNKHLMADP<TValue> KCMPOCLEKNE(TKey IICGAABOENK, [Optional] Func<TKey, TValue>? BDLPJGHJIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4942E60", Offset = "0x4942260", VA = "0x184942E60")]
	private void AOLPCAOCNBA(TKey IICGAABOENK, NNIADAOKDJL DDDBOAJKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x49431F0", Offset = "0x49425F0", VA = "0x1849431F0")]
	public void JLFHPJBPIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4944320", Offset = "0x4943720", VA = "0x184944320")]
	public HNOMHDOAEDL PMMOLBDEIOM()
	{
		return default(HNOMHDOAEDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x49443E0", Offset = "0x49437E0", VA = "0x1849443E0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x49443E0", Offset = "0x49437E0", VA = "0x1849443E0", Slot = "5")]
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
