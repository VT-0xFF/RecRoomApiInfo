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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D3DC20", Offset = "0x6D3C820", VA = "0x186D3DC20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IBDPHAMHLKF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	protected IBDPHAMHLKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class GJPCCPGIHCP<T> : IBDPHAMHLKF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct NOPGAIJOGAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum HIEPIPJENFF
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
		public HIEPIPJENFF FIFJJNIIAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T FNGNLBJEBKM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int NPALHEGAAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool KLEIDOLMOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool LMNANAKIMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? JDNIBKGMAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<NOPGAIJOGAB>? DDKGNIPLAHL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BCFNJJGLGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC1E0", Offset = "0x3EEADE0", VA = "0x183EEC1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC670", Offset = "0x3EEB270", VA = "0x183EEC670")]
	protected GJPCCPGIHCP(bool LMNANAKIMOB, bool KLEIDOLMOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC240", Offset = "0x3EEAE40", VA = "0x183EEC240")]
	protected bool FNJOHBEJJIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC2E0", Offset = "0x3EEAEE0", VA = "0x183EEC2E0")]
	protected void MHAIBLEDDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEC400", Offset = "0x3EEB000", VA = "0x183EEC400")]
	protected void OFAIFBBGOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C88300", Offset = "0x2C86F00", VA = "0x182C88300")]
	private static void EKOHLBPHPNB<U>(List<U>? APGPCFDNGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBFD0", Offset = "0x3EEABD0", VA = "0x183EEBFD0", Slot = "4")]
	public void CMCAIIEBGOH(T FNGNLBJEBKM, bool LBIEHDHGDON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBE00", Offset = "0x3EEAA00", VA = "0x183EEBE00", Slot = "5")]
	public void CEFMELNJEMA(T FNGNLBJEBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3EEBC50", Offset = "0x3EEA850", VA = "0x183EEBC50")]
	public void ANKOMBFBDGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DBHLBOFDKDO : GJPCCPGIHCP<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C3A0", Offset = "0x6D3AFA0", VA = "0x186D3C3A0")]
	public DBHLBOFDKDO(bool LMNANAKIMOB = false, bool KLEIDOLMOHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C1A0", Offset = "0x6D3ADA0", VA = "0x186D3C1A0")]
	public void JFCFICAEHOH()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C0E0", Offset = "0x6D3ACE0", VA = "0x186D3C0E0")]
	public static DBHLBOFDKDO ENMMCEPCKOE(DBHLBOFDKDO CFPMGBEGDGK, Action FNGNLBJEBKM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C140", Offset = "0x6D3AD40", VA = "0x186D3C140")]
	public static DBHLBOFDKDO FNMMKGANOIJ(DBHLBOFDKDO CFPMGBEGDGK, Action FNGNLBJEBKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GEGKBDLKNEN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMCAIIEBGOH(Action<T> FNGNLBJEBKM, bool LBIEHDHGDON = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEFMELNJEMA(Action<T> FNGNLBJEBKM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CBECGFLMOCG<T> : GJPCCPGIHCP<Action<T>>, GEGKBDLKNEN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8870", Offset = "0x3DE7470", VA = "0x183DE8870")]
	public CBECGFLMOCG(bool LMNANAKIMOB = false, bool KLEIDOLMOHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5237D90", Offset = "0x5236990", VA = "0x185237D90")]
	public void JFCFICAEHOH(T APOGBJPOAAH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6300", Offset = "0x3DF4F00", VA = "0x183DF6300")]
	public static CBECGFLMOCG<T> ENMMCEPCKOE(CBECGFLMOCG<T> CFPMGBEGDGK, Action<T> FNGNLBJEBKM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DF63A0", Offset = "0x3DF4FA0", VA = "0x183DF63A0")]
	public static CBECGFLMOCG<T> FNMMKGANOIJ(CBECGFLMOCG<T> CFPMGBEGDGK, Action<T> FNGNLBJEBKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JIEIHNEILKA<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class OKECIPBPIAC<T, U> : GJPCCPGIHCP<Action<T, U>>, JIEIHNEILKA<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8870", Offset = "0x3DE7470", VA = "0x183DE8870")]
	public OKECIPBPIAC(bool LMNANAKIMOB = false, bool KLEIDOLMOHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x47BE070", Offset = "0x47BCC70", VA = "0x1847BE070")]
	public void JFCFICAEHOH(T APOGBJPOAAH, U MHDIGFLBGML)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6300", Offset = "0x3DF4F00", VA = "0x183DF6300")]
	public static OKECIPBPIAC<T, U> ENMMCEPCKOE(OKECIPBPIAC<T, U> CFPMGBEGDGK, Action<T, U> FNGNLBJEBKM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF63A0", Offset = "0x3DF4FA0", VA = "0x183DF63A0")]
	public static OKECIPBPIAC<T, U> FNMMKGANOIJ(OKECIPBPIAC<T, U> CFPMGBEGDGK, Action<T, U> FNGNLBJEBKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BOHHPOGCOJJ<T, U, V> : GJPCCPGIHCP<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8870", Offset = "0x3DE7470", VA = "0x183DE8870")]
	public BOHHPOGCOJJ(bool LMNANAKIMOB = false, bool KLEIDOLMOHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x50CF800", Offset = "0x50CE400", VA = "0x1850CF800")]
	public void JFCFICAEHOH(T APOGBJPOAAH, U MHDIGFLBGML, V PPIEANOJMKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6300", Offset = "0x3DF4F00", VA = "0x183DF6300")]
	public static BOHHPOGCOJJ<T, U, V> ENMMCEPCKOE(BOHHPOGCOJJ<T, U, V> CFPMGBEGDGK, Action<T, U, V> FNGNLBJEBKM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DF63A0", Offset = "0x3DF4FA0", VA = "0x183DF63A0")]
	public static BOHHPOGCOJJ<T, U, V> FNMMKGANOIJ(BOHHPOGCOJJ<T, U, V> CFPMGBEGDGK, Action<T, U, V> FNGNLBJEBKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HMHCJPEEFMO<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class FDPKBNCOMCI<T, U, V, W> : GJPCCPGIHCP<Action<T, U, V, W>>, HMHCJPEEFMO<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8870", Offset = "0x3DE7470", VA = "0x183DE8870")]
	public FDPKBNCOMCI(bool LMNANAKIMOB = false, bool KLEIDOLMOHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3DF7C40", Offset = "0x3DF6840", VA = "0x183DF7C40")]
	public void JFCFICAEHOH(T APOGBJPOAAH, U MHDIGFLBGML, V PPIEANOJMKF, W HPBFBIICGCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6300", Offset = "0x3DF4F00", VA = "0x183DF6300")]
	public static FDPKBNCOMCI<T, U, V, W> ENMMCEPCKOE(FDPKBNCOMCI<T, U, V, W> CFPMGBEGDGK, Action<T, U, V, W> FNGNLBJEBKM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3DF63A0", Offset = "0x3DF4FA0", VA = "0x183DF63A0")]
	public static FDPKBNCOMCI<T, U, V, W> FNMMKGANOIJ(FDPKBNCOMCI<T, U, V, W> CFPMGBEGDGK, Action<T, U, V, W> FNGNLBJEBKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MAAJGIDFALB<T, U, V, W, X> : GJPCCPGIHCP<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8870", Offset = "0x3DE7470", VA = "0x183DE8870")]
	public MAAJGIDFALB(bool LMNANAKIMOB = false, bool KLEIDOLMOHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x45817A0", Offset = "0x45803A0", VA = "0x1845817A0")]
	public void JFCFICAEHOH(T APOGBJPOAAH, U MHDIGFLBGML, V PPIEANOJMKF, W HPBFBIICGCP, X MBJABMPNEHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6300", Offset = "0x3DF4F00", VA = "0x183DF6300")]
	public static MAAJGIDFALB<T, U, V, W, X> ENMMCEPCKOE(MAAJGIDFALB<T, U, V, W, X> CFPMGBEGDGK, Action<T, U, V, W, X> FNGNLBJEBKM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3DF63A0", Offset = "0x3DF4FA0", VA = "0x183DF63A0")]
	public static MAAJGIDFALB<T, U, V, W, X> FNMMKGANOIJ(MAAJGIDFALB<T, U, V, W, X> CFPMGBEGDGK, Action<T, U, V, W, X> FNGNLBJEBKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class MHKIDNPCHNG<T, U, V, W, X, Y> : GJPCCPGIHCP<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3DE8870", Offset = "0x3DE7470", VA = "0x183DE8870")]
	public MHKIDNPCHNG(bool LMNANAKIMOB = false, bool KLEIDOLMOHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x45BE7E0", Offset = "0x45BD3E0", VA = "0x1845BE7E0")]
	public void JFCFICAEHOH(T APOGBJPOAAH, U MHDIGFLBGML, V PPIEANOJMKF, W HPBFBIICGCP, X MBJABMPNEHF, Y MNMGCDILGBO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF6300", Offset = "0x3DF4F00", VA = "0x183DF6300")]
	public static MHKIDNPCHNG<T, U, V, W, X, Y> ENMMCEPCKOE(MHKIDNPCHNG<T, U, V, W, X, Y> CFPMGBEGDGK, Action<T, U, V, W, X, Y> FNGNLBJEBKM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF63A0", Offset = "0x3DF4FA0", VA = "0x183DF63A0")]
	public static MHKIDNPCHNG<T, U, V, W, X, Y> FNMMKGANOIJ(MHKIDNPCHNG<T, U, V, W, X, Y> CFPMGBEGDGK, Action<T, U, V, W, X, Y> FNGNLBJEBKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IMGALKEFMJH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CPCFBGMIICB<TKey, TVal> LMNGLKIACMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> NABCOPOELPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CPCFBGMIICB<TKey, TVal>.MPLJKMEPEKE? AIBNOHNHHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int FNLBIBPNJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CPCFBGMIICB<TKey, TVal>.ILPBECONAJN? IKLKGJBCLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int DKAEGCEDHEF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int BCKGPECONPP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4036420", Offset = "0x4035020", VA = "0x184036420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HAKLGKNKAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x887AC0", Offset = "0x8866C0", VA = "0x180887AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4036BF0", Offset = "0x40357F0", VA = "0x184036BF0")]
	public IMGALKEFMJH(int FNLBIBPNJKB, [Optional] CPCFBGMIICB<TKey, TVal>.ILPBECONAJN? IKLKGJBCLCE, [Optional] IEqualityComparer<TKey>? PFAKHFIEDDE, [Optional] CPCFBGMIICB<TKey, TVal>.MPLJKMEPEKE? AIBNOHNHHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x40361F0", Offset = "0x4034DF0", VA = "0x1840361F0")]
	public void FGJDACNOIAD(TKey NONKDEOLPHL, TVal CABLCDOIFFL, bool CMKDLAMOBIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x40359B0", Offset = "0x40345B0", VA = "0x1840359B0")]
	public bool BBABPPMHICF(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4036AF0", Offset = "0x40356F0", VA = "0x184036AF0")]
	public bool NNAAPMJPMIH(TKey EFGPCFMPHGL, [Out] TVal CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4035B10", Offset = "0x4034710", VA = "0x184035B10")]
	private void BIHHANIJIEB(TKey NONKDEOLPHL, TVal CABLCDOIFFL, int OLKJNOHMJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4035DD0", Offset = "0x40349D0", VA = "0x184035DD0")]
	public bool CLAMPKAGJMH(TKey NONKDEOLPHL, TVal CABLCDOIFFL, bool CMKDLAMOBIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4035900", Offset = "0x4034500", VA = "0x184035900")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4036590", Offset = "0x4035190", VA = "0x184036590")]
	private void NJAHAFFLALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x40360B0", Offset = "0x4034CB0", VA = "0x1840360B0")]
	private bool FEJBIBCIDHP(TKey NONKDEOLPHL, JLGIHACEOBD CKHPKJLILHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4036470", Offset = "0x4035070", VA = "0x184036470")]
	private void NEPIHJELCIP(TKey NONKDEOLPHL, TVal CABLCDOIFFL, JLGIHACEOBD CKHPKJLILHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4035F80", Offset = "0x4034B80", VA = "0x184035F80")]
	private void FCKBBFJOEIN(TKey NONKDEOLPHL, TVal JEODFFDGHHF, JLGIHACEOBD CKHPKJLILHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CFOIFCANHLD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action DGEMPIMCEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool OPDKOEAPFLH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public CFOIFCANHLD(Action DFCOBDBBLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BFD0", Offset = "0x6D3ABD0", VA = "0x186D3BFD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B240", Offset = "0x2B89E40", VA = "0x182B8B240")]
	public static LFNFGMGFLKN<T> ELGDCMPCLII<T>(T CABLCDOIFFL, Action DFCOBDBBLMK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class LFNFGMGFLKN<T> : CFOIFCANHLD where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T PPPKGAOABBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x43774F0", Offset = "0x43760F0", VA = "0x1843774F0")]
	public LFNFGMGFLKN(T CABLCDOIFFL, Action DFCOBDBBLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class LLLPICLKHPA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly BKGOPAFFNPE<T>? JCOCOGJOEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> GNIFKLGHHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool OPDKOEAPFLH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly LLLPICLKHPA<T> EHFCNKAFHAH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> CFHLENOEACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x43BD2E0", Offset = "0x43BBEE0", VA = "0x1843BD2E0")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x43BD7B0", Offset = "0x43BC3B0", VA = "0x1843BD7B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PEBIHPCGOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x43BD870", Offset = "0x43BC470", VA = "0x1843BD870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x43BDB30", Offset = "0x43BC730", VA = "0x1843BDB30")]
	public LLLPICLKHPA(BKGOPAFFNPE<T> EFACJIJPJDK, BKGOPAFFNPE<T> PJFHOPNLAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x43BE070", Offset = "0x43BCC70", VA = "0x1843BE070")]
	public LLLPICLKHPA(BKGOPAFFNPE<T> EFACJIJPJDK, int HAOCJMNINJC, BKGOPAFFNPE<T> PJFHOPNLAJO, int MNLLLHOHODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x43BDC20", Offset = "0x43BC820", VA = "0x1843BDC20")]
	private LLLPICLKHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x43BD3E0", Offset = "0x43BBFE0", VA = "0x1843BD3E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x43BD590", Offset = "0x43BC190", VA = "0x1843BD590")]
	public T[] GAPKACFFPLK()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x43BD470", Offset = "0x43BC070", VA = "0x1843BD470")]
	public static ReadOnlySequence<T> FGDKAMMLLCN(LLLPICLKHPA<T>? IIKKIIMGLPE)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct KBDLCKKEKFO : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct AMLCGEIIEIJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0")]
		public static AMLCGEIIEIJ LMDPPDEOAIA()
		{
			return default(AMLCGEIIEIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CEC0", Offset = "0x6D3BAC0", VA = "0x186D3CEC0")]
	public static string CHBHGNHAPLE(Type FIFJJNIIAPF, [Optional] string? PEBJPBJCCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2DB0", Offset = "0x2EC19B0", VA = "0x182EC2DB0")]
	public static string? CHBHGNHAPLE<T>([Optional] string? PEBJPBJCCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2E30", Offset = "0x2EC1A30", VA = "0x182EC2E30")]
	public static string? MHKIPJIMLPJ<T>([Optional] string? ECBOFDHHCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0")]
	public static KBDLCKKEKFO CMADEOBHKDI(string PEBJPBJCCGK, string? ECBOFDHHCOK)
	{
		return default(KBDLCKKEKFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LGLIHOABELM
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool BPAHHMGIMEK(string FHBBOKHOCMJ, LGLIHOABELM GCJKHPNFLLI);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class IPGBILEAEIH<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public IPGBILEAEIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x403D150", Offset = "0x403BD50", VA = "0x18403D150")]
		internal void ALJHMLPIIOO(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int DIBAENLMLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string HFBNNNBLAEN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D520", Offset = "0x6D3C120", VA = "0x186D3D520")]
	public static Dictionary<string, LGLIHOABELM> NCPPMHCNBIF(Type GDHBPGJCJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0310", Offset = "0x2ECEF10", VA = "0x182ED0310")]
	public static Dictionary<string, LGLIHOABELM> NCPPMHCNBIF<T>(Type GDHBPGJCJPD, IReadOnlyDictionary<T, string> KENOGLMGAFN) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0B40", Offset = "0x2ECF740", VA = "0x182ED0B40")]
	public static Dictionary<string, LGLIHOABELM> OEJFLBHPMEC<T>(List<T> KJLIHCDIOJM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CFA0", Offset = "0x6D3BBA0", VA = "0x186D3CFA0")]
	public static Dictionary<string, LGLIHOABELM> FPKJOHFOLKJ(Type GDHBPGJCJPD, BPAHHMGIMEK PGNLIKDACMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D360", Offset = "0x6D3BF60", VA = "0x186D3D360")]
	public static Dictionary<int, string> LFDEACDJKLD(Dictionary<string, LGLIHOABELM> DOHADELBNEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class BGGNEHOKNAC : OILOBAEJEDE
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool INFHKIONKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? LOGKCIPDKGF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual OILOBAEJEDE? HHJLGJBOHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AE50", Offset = "0x6D39A50", VA = "0x186D3AE50")]
	protected BGGNEHOKNAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string GCHBDOEJPND();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3ADD0", Offset = "0x6D399D0", VA = "0x186D3ADD0", Slot = "8")]
	public virtual string ONJCECDOMEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AB20", Offset = "0x6D39720", VA = "0x186D3AB20", Slot = "9")]
	public void KJLJBIMCDFL(StringBuilder LEOMGMHHBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A900", Offset = "0x6D39500", VA = "0x186D3A900", Slot = "10")]
	public void GIHMNCMOGAE(StringBuilder LEOMGMHHBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AA00", Offset = "0x6D39600", VA = "0x186D3AA00", Slot = "11")]
	public void IAJNDMLPELB(StringBuilder LEOMGMHHBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A7A0", Offset = "0x6D393A0", VA = "0x186D3A7A0", Slot = "12")]
	public void AJPKOEDCGCD(StringBuilder LEOMGMHHBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A960", Offset = "0x6D39560", VA = "0x186D3A960")]
	public static void HOFLFFLBKKM(StringBuilder LEOMGMHHBOP, string APPDBKNJBIE, string EDPGBANJBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E84F00", Offset = "0x5E83B00", VA = "0x185E84F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class GOABBMFKBKF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CAC0", Offset = "0x6D3B6C0", VA = "0x186D3CAC0")]
	public GOABBMFKBKF(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GILBKPFEMDM<TErr> : GOABBMFKBKF where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr DFJPHCJKDLB;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3EEA3D0", Offset = "0x3EE8FD0", VA = "0x183EEA3D0")]
	private GILBKPFEMDM([In] TErr GPAPIFNJOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3EEA300", Offset = "0x3EE8F00", VA = "0x183EEA300")]
	public static GILBKPFEMDM<TErr> LMDPPDEOAIA([In] TErr GPAPIFNJOLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class AMAJJOCGEJM : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm MCMAICGBGOF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool PBGCMHKJKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool PFKHJOMGNPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool DENJBFKEEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8A3350", Offset = "0x8A1F50", VA = "0x1808A3350", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A5D0", Offset = "0x6D391D0", VA = "0x186D3A5D0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long FIKECJKJAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A640", Offset = "0x6D39240", VA = "0x186D3A640", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6D3A6B0", Offset = "0x6D392B0", VA = "0x186D3A6B0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A560", Offset = "0x6D39160", VA = "0x186D3A560")]
	public AMAJJOCGEJM(HashAlgorithm MCMAICGBGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A390", Offset = "0x6D38F90", VA = "0x186D3A390", Slot = "35")]
	public override int Read(byte[] OFBCPBHPLBK, int APMEPKJBNGD, int KNHHBEFLJAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A530", Offset = "0x6D39130", VA = "0x186D3A530", Slot = "38")]
	public override void Write(byte[] OFBCPBHPLBK, int APMEPKJBNGD, int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A430", Offset = "0x6D39030", VA = "0x186D3A430", Slot = "33")]
	public override long Seek(long APMEPKJBNGD, SeekOrigin NLLHBHEGIHB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A4C0", Offset = "0x6D390C0", VA = "0x186D3A4C0", Slot = "34")]
	public override void SetLength(long CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A2C0", Offset = "0x6D38EC0", VA = "0x186D3A2C0")]
	public byte[] PHDPCLMFFMK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OILOBAEJEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ONJCECDOMEL();

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GCHBDOEJPND();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DGPJCKMIHCC<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions PPPKGAOABBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LGDLKOGGOMD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string CGBDCAAHPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class BKGOPAFFNPE<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static BKGOPAFFNPE<T>? CPKFCIHLOLJ;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object LKNFDABHHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? CAMGONFOAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool OPDKOEAPFLH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool KIIJDPHLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA22400", Offset = "0xA21000", VA = "0x180A22400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x50B4850", Offset = "0x50B3450", VA = "0x1850B4850")]
	private static BKGOPAFFNPE<T> IEIAMEBHIEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x50B3250", Offset = "0x50B1E50", VA = "0x1850B3250")]
	private static void AAMOPLOOCPH(BKGOPAFFNPE<T> PHKDKADEGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3E20760", Offset = "0x3E1F360", VA = "0x183E20760")]
	private BKGOPAFFNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x50B4220", Offset = "0x50B2E20", VA = "0x1850B4220")]
	public static BKGOPAFFNPE<T> ELGDCMPCLII(ReadOnlyMemory<T> MFKBNFMCENH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x50B4010", Offset = "0x50B2C10", VA = "0x1850B4010")]
	public static BKGOPAFFNPE<T> ELGDCMPCLII(IMemoryOwner<T> BOBEEJHGLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x50B45C0", Offset = "0x50B31C0", VA = "0x1850B45C0")]
	public static void GFFFHIJCAHG(BKGOPAFFNPE<T> EFACJIJPJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x50B3B10", Offset = "0x50B2710", VA = "0x1850B3B10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x50B3A00", Offset = "0x50B2600", VA = "0x1850B3A00")]
	public BKGOPAFFNPE<T> DLDIDIHBEBF(IMemoryOwner<T> BOBEEJHGLOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x50B3900", Offset = "0x50B2500", VA = "0x1850B3900")]
	private void AMIHHMHIPLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x50B4700", Offset = "0x50B3300", VA = "0x1850B4700")]
	private BKGOPAFFNPE<T> HJAPANHNGNL(BKGOPAFFNPE<T> PHKDKADEGJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FPCNPIIKHGK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C490", Offset = "0x6D3B090", VA = "0x186D3C490")]
	public FPCNPIIKHGK(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JFPEHDLFCFM<TOk> : FPCNPIIKHGK where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk ENOECEGONEN;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x41E87C0", Offset = "0x41E73C0", VA = "0x1841E87C0")]
	private JFPEHDLFCFM([In] TOk EOHKFDIHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3F31800", Offset = "0x3F30400", VA = "0x183F31800")]
	public static JFPEHDLFCFM<TOk> LMDPPDEOAIA([In] TOk EOHKFDIHJLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct OAMIPODNNBO<TOk, TErr> : IEquatable<OAMIPODNNBO<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> GFNKFPJPIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr DFJPHCJKDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk ENOECEGONEN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool PJBMHKLENCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x478A320", Offset = "0x4788F20", VA = "0x18478A320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool FIODDGOPABK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x478D0C0", Offset = "0x478BCC0", VA = "0x18478D0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4791020", Offset = "0x478FC20", VA = "0x184791020")]
	internal OAMIPODNNBO([In] TErr GPAPIFNJOLF, [In] TOk EOHKFDIHJLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x478C980", Offset = "0x478B580", VA = "0x18478C980")]
	public static OAMIPODNNBO<TOk, TErr> IOHHDFMFOJG([In] TErr GPAPIFNJOLF)
	{
		return default(OAMIPODNNBO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x478D940", Offset = "0x478C540", VA = "0x18478D940")]
	public static OAMIPODNNBO<TOk, TErr> KCOGBHELGFH([In] TOk EOHKFDIHJLG)
	{
		return default(OAMIPODNNBO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2E8C5F0", Offset = "0x2E8B1F0", VA = "0x182E8C5F0")]
	public OAMIPODNNBO<TOk?, UErr?> HMLGKCHMAKP<UErr>()
	{
		return default(OAMIPODNNBO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D1F0", Offset = "0x2E8BDF0", VA = "0x182E8D1F0")]
	public OAMIPODNNBO<UOk?, TErr?> IKDFMPFDLOC<UOk>()
	{
		return default(OAMIPODNNBO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2E8DF30", Offset = "0x2E8CB30", VA = "0x182E8DF30")]
	public OAMIPODNNBO<UOk?, TErr?> IPCOIEJIADA<UOk>()
	{
		return default(OAMIPODNNBO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2E8E9A0", Offset = "0x2E8D5A0", VA = "0x182E8E9A0")]
	public OAMIPODNNBO<TOk?, UErr?> LCHNDBFBDBI<UErr>()
	{
		return default(OAMIPODNNBO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x478CCE0", Offset = "0x478B8E0", VA = "0x18478CCE0")]
	public OAMIPODNNBO<FKMCALNFICP, TErr> JDJNGNNHEJD()
	{
		return default(OAMIPODNNBO<FKMCALNFICP, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x478DC90", Offset = "0x478C890", VA = "0x18478DC90")]
	public static bool PCHFOHOKDFG([In] OAMIPODNNBO<TOk, TErr> KFIDOCPNAED, [In] OAMIPODNNBO<TOk, TErr> AMMLBECACOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x478A900", Offset = "0x4789500", VA = "0x18478A900", Slot = "4")]
	public bool Equals(OAMIPODNNBO<TOk, TErr> FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x478AF30", Offset = "0x4789B30", VA = "0x18478AF30", Slot = "0")]
	public override bool Equals(object FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x478C2A0", Offset = "0x478AEA0", VA = "0x18478C2A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x47904D0", Offset = "0x478F0D0", VA = "0x1847904D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class NGGEDMCHEAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MNGCKEKEDBO<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<OAMIPODNNBO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<OAMIPODNNBO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x45CAF10", Offset = "0x45C9B10", VA = "0x1845CAF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x45CB870", Offset = "0x45CA470", VA = "0x1845CB870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2F62D20", Offset = "0x2F61920", VA = "0x182F62D20")]
	public static OAMIPODNNBO<TOk?, TErr?> ENOECEGONEN<TOk, TErr>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [In] TOk EOHKFDIHJLG)
	{
		return default(OAMIPODNNBO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2F63670", Offset = "0x2F62270", VA = "0x182F63670")]
	public static OAMIPODNNBO<FKMCALNFICP, TErr?> ENOECEGONEN<TErr>([In] this OAMIPODNNBO<FKMCALNFICP, TErr> GMNCELIMKIF)
	{
		return default(OAMIPODNNBO<FKMCALNFICP, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2F62D20", Offset = "0x2F61920", VA = "0x182F62D20")]
	public static OAMIPODNNBO<TOk?, TErr?> DFJPHCJKDLB<TOk, TErr>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [In] TErr GPAPIFNJOLF)
	{
		return default(OAMIPODNNBO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2F63D10", Offset = "0x2F62910", VA = "0x182F63D10")]
	public static TOk? HCMBBPMKELP<TOk, TErr>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2F64400", Offset = "0x2F63000", VA = "0x182F64400")]
	[AsyncStateMachine(typeof(MNGCKEKEDBO<, >))]
	public static Task<TOk?>? JHJGKFCNBCG<TOk, TErr>(this Task<OAMIPODNNBO<TOk, TErr>> GMNCELIMKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2F64140", Offset = "0x2F62D40", VA = "0x182F64140")]
	public static TErr? JHDNMPCKANM<TErr, TOk>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2F64B60", Offset = "0x2F63760", VA = "0x182F64B60")]
	public static bool KCDAPNEJFHJ<TOk, TErr, UErr, UOk>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [Out] OAMIPODNNBO<UOk, UErr> PNFKECDOJBA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2F629C0", Offset = "0x2F615C0", VA = "0x182F629C0")]
	public static bool AMFOLNLEAKD<TOk, TErr>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [Out][NotNullWhen(true)] TOk EOHKFDIHJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2F62B80", Offset = "0x2F61780", VA = "0x182F62B80")]
	public static bool BIMJCOIMNNK<TOk, TErr>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [Out][NotNullWhen(true)] TErr GPAPIFNJOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2F638B0", Offset = "0x2F624B0", VA = "0x182F638B0")]
	public static bool GAFNCMDLGDN<TOk, TErr>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [Out][NotNullWhen(true)] TOk EOHKFDIHJLG, [Out][NotNullWhen(false)] TErr GPAPIFNJOLF) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2F63930", Offset = "0x2F62530", VA = "0x182F63930")]
	public static bool GJNFJDHPOGC<TOk, TErr>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [Out][NotNullWhen(true)] TOk EOHKFDIHJLG, [Out] OAMIPODNNBO<TOk, TErr> PNFKECDOJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F64DD0", Offset = "0x2F639D0", VA = "0x182F64DD0")]
	public static bool KCDAPNEJFHJ<TOk, TErr, UErr, UOk>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [Out][NotNullWhen(true)] TOk EOHKFDIHJLG, [Out] OAMIPODNNBO<UOk, UErr> PNFKECDOJBA) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2F647B0", Offset = "0x2F633B0", VA = "0x182F647B0")]
	public static bool KCBKNLAABIP<TOk, TErr>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [Out][NotNullWhen(true)] TOk EOHKFDIHJLG, [Out] OAMIPODNNBO<FKMCALNFICP, TErr> PNFKECDOJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2F630D0", Offset = "0x2F61CD0", VA = "0x182F630D0")]
	public static OAMIPODNNBO<UOk, UErr> EHHGPGBOKNN<UOk, UErr, TOk, TErr>([In] this OAMIPODNNBO<TOk, TErr> GMNCELIMKIF, [In] OAMIPODNNBO<UOk, UErr> AEBBBFCJHJO) where TOk : UOk where TErr : UErr
	{
		return default(OAMIPODNNBO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2F65D40", Offset = "0x2F64940", VA = "0x182F65D40")]
	public static OAMIPODNNBO<TOk?[]?, TErr?> MJJMOPAPPLJ<TOk, TErr>(this IEnumerable<OAMIPODNNBO<TOk, TErr>> GMNCELIMKIF)
	{
		return default(OAMIPODNNBO<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DENOJPGEGLJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F0E0", Offset = "0x2C7DCE0", VA = "0x182C7F0E0")]
	public static OAMIPODNNBO<TOk, T> ENOECEGONEN<TOk>([In] TOk EOHKFDIHJLG) where TOk : notnull
	{
		return default(OAMIPODNNBO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5AC3F30", Offset = "0x5AC2B30", VA = "0x185AC3F30")]
	public static OAMIPODNNBO<FKMCALNFICP, T> ENOECEGONEN()
	{
		return default(OAMIPODNNBO<FKMCALNFICP, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F050", Offset = "0x2C7DC50", VA = "0x182C7F050")]
	public static OAMIPODNNBO<T, TErr> DFJPHCJKDLB<TErr>([In] TErr GPAPIFNJOLF) where TErr : notnull
	{
		return default(OAMIPODNNBO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct CLPJGLEIAEN<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly HIFNMCJCJIE KCOHDGIAPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> CNNGNHBHECA;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x46B11A0", Offset = "0x46AFDA0", VA = "0x1846B11A0")]
	public static CLPJGLEIAEN<TKey, TValue> LMDPPDEOAIA(string PDMONEGPHPK)
	{
		return default(CLPJGLEIAEN<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x46B1360", Offset = "0x46AFF60", VA = "0x1846B1360")]
	internal CLPJGLEIAEN(Dictionary<TKey, TValue> CABLCDOIFFL, HIFNMCJCJIE ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x46B12C0", Offset = "0x46AFEC0", VA = "0x1846B12C0")]
	public KJAIALKKHHB<TKey, TValue> MKFIMIHLLJF([Out] Dictionary<TKey, TValue> CABLCDOIFFL)
	{
		return default(KJAIALKKHHB<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct KJAIALKKHHB<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> CNNGNHBHECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly PFLKNJMIDLC LBJJNMPPFPF;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x231EA80", Offset = "0x231D680", VA = "0x18231EA80")]
	internal KJAIALKKHHB(Dictionary<TKey, TValue> CABLCDOIFFL, PFLKNJMIDLC NGNBNFDDONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3E09E50", Offset = "0x3E08A50", VA = "0x183E09E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct CHECCLHCMIL<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly HIFNMCJCJIE KCOHDGIAPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> CNNGNHBHECA;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x46B11A0", Offset = "0x46AFDA0", VA = "0x1846B11A0")]
	public static CHECCLHCMIL<T> LMDPPDEOAIA(string PDMONEGPHPK)
	{
		return default(CHECCLHCMIL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x46B1360", Offset = "0x46AFF60", VA = "0x1846B1360")]
	internal CHECCLHCMIL(HashSet<T> CABLCDOIFFL, HIFNMCJCJIE ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46B12C0", Offset = "0x46AFEC0", VA = "0x1846B12C0")]
	public LHNOLJLHNBD<T> MKFIMIHLLJF([Out] HashSet<T> CABLCDOIFFL)
	{
		return default(LHNOLJLHNBD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct LHNOLJLHNBD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> CNNGNHBHECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly PFLKNJMIDLC LBJJNMPPFPF;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x231EA80", Offset = "0x231D680", VA = "0x18231EA80")]
	internal LHNOLJLHNBD(HashSet<T> CABLCDOIFFL, PFLKNJMIDLC NGNBNFDDONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3E09E50", Offset = "0x3E08A50", VA = "0x183E09E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NOHBNBKLLDN<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HIFNMCJCJIE KCOHDGIAPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> CNNGNHBHECA;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x46B11A0", Offset = "0x46AFDA0", VA = "0x1846B11A0")]
	public static NOHBNBKLLDN<T> LMDPPDEOAIA(string PDMONEGPHPK)
	{
		return default(NOHBNBKLLDN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x46B1360", Offset = "0x46AFF60", VA = "0x1846B1360")]
	internal NOHBNBKLLDN(Stack<T> CABLCDOIFFL, HIFNMCJCJIE ILIBGKIHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x46B12C0", Offset = "0x46AFEC0", VA = "0x1846B12C0")]
	public FJBKIENLEJC<T> MKFIMIHLLJF([Out] Stack<T> CABLCDOIFFL)
	{
		return default(FJBKIENLEJC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct FJBKIENLEJC<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> CNNGNHBHECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly PFLKNJMIDLC LBJJNMPPFPF;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x231EA80", Offset = "0x231D680", VA = "0x18231EA80")]
	internal FJBKIENLEJC(Stack<T> CABLCDOIFFL, PFLKNJMIDLC NGNBNFDDONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3E09E50", Offset = "0x3E08A50", VA = "0x183E09E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class NAKKOJICPNM<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct JCMIDHNCJDL : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly NAKKOJICPNM<T> AEENIKHNMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int ODJGDAIDFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool DKONLMBHEAP;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x204FA00", Offset = "0x204E600", VA = "0x18204FA00")]
		public JCMIDHNCJDL(NAKKOJICPNM<T> GMBKDDMMMLD, int IJBMGMKMPIP, bool MOGDEIMHCED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x41E02D0", Offset = "0x41DEED0", VA = "0x1841E02D0")]
		public NAKKOJICPNM<T>.DLFIOAMGJCP NEGBLLIJCNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x41E03C0", Offset = "0x41DEFC0", VA = "0x1841E03C0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x41E03C0", Offset = "0x41DEFC0", VA = "0x1841E03C0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class DLFIOAMGJCP : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly NAKKOJICPNM<T> AEENIKHNMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int LEHDFECJLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int OMPIGJLMFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool DKONLMBHEAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool IMKJKBFBABN;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5B025F0", Offset = "0x5B011F0", VA = "0x185B025F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x5B027A0", Offset = "0x5B013A0", VA = "0x185B027A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x5B028D0", Offset = "0x5B014D0", VA = "0x185B028D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5B02FF0", Offset = "0x5B01BF0", VA = "0x185B02FF0")]
		public DLFIOAMGJCP(NAKKOJICPNM<T> GMBKDDMMMLD, int IJBMGMKMPIP, bool MOGDEIMHCED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5B026F0", Offset = "0x5B012F0", VA = "0x185B026F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5B02780", Offset = "0x5B01380", VA = "0x185B02780", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class ECGNMMNCLCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ECGNMMNCLCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D2C0", Offset = "0x3A5BEC0", VA = "0x183A5D2C0")]
		internal T LPJHGCEDCFM(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] JNMMPOAOHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int OMPIGJLMFCI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int CLBNAKNHACF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x463EBF0", Offset = "0x463D7F0", VA = "0x18463EBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T FFEGLPIJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1BF0", Offset = "0x3DE07F0", VA = "0x183DE1BF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T JIBIMLHAGAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x463EC50", Offset = "0x463D850", VA = "0x18463EC50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x463EAE0", Offset = "0x463D6E0", VA = "0x18463EAE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1BB5D10", Offset = "0x1BB4910", VA = "0x181BB5D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x13664A0", Offset = "0x13650A0", VA = "0x1813664A0")]
	private static int KDPGOGJKFPF(int MFJLAMOCOBC, int OLBMNABBGHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x463F030", Offset = "0x463DC30", VA = "0x18463F030")]
	public NAKKOJICPNM(int OLKJNOHMJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x463ED30", Offset = "0x463D930", VA = "0x18463ED30")]
	public NAKKOJICPNM(int OLKJNOHMJPI, Func<T> MPJEDKEIMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x463F150", Offset = "0x463DD50", VA = "0x18463F150")]
	public NAKKOJICPNM(T[] AIOEIPPJKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x463EBC0", Offset = "0x463D7C0", VA = "0x18463EBC0")]
	public void KJCDKNOLAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x463E940", Offset = "0x463D540", VA = "0x18463E940")]
	public IEnumerable<T> AHLHKEDEJGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x463EC90", Offset = "0x463D890", VA = "0x18463EC90")]
	public NAKKOJICPNM<T>.DLFIOAMGJCP NEGBLLIJCNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3E83460", Offset = "0x3E82060", VA = "0x183E83460", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3E83460", Offset = "0x3E82060", VA = "0x183E83460", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class ADFLLLOALKN
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x34B3430", Offset = "0x34B2030", VA = "0x1834B3430")]
	public static NAKKOJICPNM<T> LMDPPDEOAIA<T>(int OLKJNOHMJPI, Func<T> MPJEDKEIMOF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class LJGPDADMJJD<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct GAJADCNFAPM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly LJGPDADMJJD<T> PIKAJGICBKD;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T PPPKGAOABBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3ED07B0", Offset = "0x3ECF3B0", VA = "0x183ED07B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0780", Offset = "0x3ECF380", VA = "0x183ED0780", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
		public GAJADCNFAPM(LJGPDADMJJD<T> PIKAJGICBKD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct CFGHPAJPNPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<GAJADCNFAPM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LJGPDADMJJD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5502DD0", Offset = "0x55019D0", VA = "0x185502DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3DF92C0", Offset = "0x3DF7EC0", VA = "0x183DF92C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim PLFHHEPCGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T NDBPGFIPMNE;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4383B20", Offset = "0x4382720", VA = "0x184383B20")]
	public LJGPDADMJJD([In] T NDBPGFIPMNE, int ELKADGDOFKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4383990", Offset = "0x4382590", VA = "0x184383990")]
	public LJGPDADMJJD([In] T NDBPGFIPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4383470", Offset = "0x4382070", VA = "0x184383470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x43834B0", Offset = "0x43820B0", VA = "0x1843834B0")]
	public GAJADCNFAPM ICONAEGIKKO()
	{
		return default(GAJADCNFAPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4383510", Offset = "0x4382110", VA = "0x184383510")]
	[AsyncStateMachine(typeof(LJGPDADMJJD<>.CFGHPAJPNPL))]
	public Task<LJGPDADMJJD<T>.GAJADCNFAPM> PMIBFEMOLFB(CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x43834F0", Offset = "0x43820F0", VA = "0x1843834F0")]
	public void KHAECNLNEGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class NNINEGMGGCG
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DBB0", Offset = "0x6D3C7B0", VA = "0x186D3DBB0")]
	public static LJGPDADMJJD<FKMCALNFICP> LMDPPDEOAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5CD0", Offset = "0x2BF48D0", VA = "0x182BF5CD0")]
	public static LJGPDADMJJD<T> LMDPPDEOAIA<T>([In] T NDBPGFIPMNE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class IFMLNLKJGKN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LIJJCBFFOIK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly IFMLNLKJGKN<T> LIAPDANNMKD;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T PPPKGAOABBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x437CD20", Offset = "0x437B920", VA = "0x18437CD20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x437C930", Offset = "0x437B530", VA = "0x18437C930", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
		internal LIJJCBFFOIK(IFMLNLKJGKN<T> PIKAJGICBKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct LMKLPCFLJGB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly IFMLNLKJGKN<T> LIAPDANNMKD;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T PPPKGAOABBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x437CD20", Offset = "0x437B920", VA = "0x18437CD20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x43C2760", Offset = "0x43C1360", VA = "0x1843C2760", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
		internal LMKLPCFLJGB(IFMLNLKJGKN<T> PIKAJGICBKD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct FECJLMKDJOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<LMKLPCFLJGB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public IFMLNLKJGKN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LJGPDADMJJD<FKMCALNFICP>.GAJADCNFAPM <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<LJGPDADMJJD<FKMCALNFICP>.GAJADCNFAPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8880", Offset = "0x3DF7480", VA = "0x183DF8880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x3DF92C0", Offset = "0x3DF7EC0", VA = "0x183DF92C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly LJGPDADMJJD<int> GAOBFGAJOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly LJGPDADMJJD<FKMCALNFICP> OANFBLJOIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly LJGPDADMJJD<FKMCALNFICP> NANFOOKGAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T BBHJOFPOBFD;

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4027980", Offset = "0x4026580", VA = "0x184027980")]
	internal IFMLNLKJGKN(LJGPDADMJJD<int> LHGKIIFJEJM, LJGPDADMJJD<FKMCALNFICP> PMNPIJBNEGD, LJGPDADMJJD<FKMCALNFICP> OEFJNALKLFB, [In] T NDBPGFIPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4027250", Offset = "0x4025E50", VA = "0x184027250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4027010", Offset = "0x4025C10", VA = "0x184027010")]
	public LIJJCBFFOIK DNEPMNIMLAE()
	{
		return default(LIJJCBFFOIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4027350", Offset = "0x4025F50", VA = "0x184027350")]
	public LMKLPCFLJGB KEFHONGLMJL()
	{
		return default(LMKLPCFLJGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4027860", Offset = "0x4026460", VA = "0x184027860")]
	[AsyncStateMachine(typeof(IFMLNLKJGKN<>.FECJLMKDJOJ))]
	public Task<IFMLNLKJGKN<T>.LMKLPCFLJGB> OAKBFFGAEBL(CancellationToken CKKFHABGBNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CIOPDPAIHJF
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C010", Offset = "0x6D3AC10", VA = "0x186D3C010")]
	public static IFMLNLKJGKN<FKMCALNFICP> LMDPPDEOAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C04390", Offset = "0x2C02F90", VA = "0x182C04390")]
	public static IFMLNLKJGKN<T> LMDPPDEOAIA<T>([In] T NDBPGFIPMNE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class AFNKNFFEACM<TData> : BGGNEHOKNAC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string LDONEJPFOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData HCNDAPMGMCI;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
	public override string GCHBDOEJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9B80", Offset = "0x3EA8780", VA = "0x183EA9B80")]
	internal AFNKNFFEACM(string LFKIGNHCOID, [In] TData BFLLAIFBMAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BBHGOGPCPIM
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A720", Offset = "0x6D39320", VA = "0x186D3A720")]
	public static AFNKNFFEACM<FKMCALNFICP> LMDPPDEOAIA(string LFKIGNHCOID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B240", Offset = "0x2B89E40", VA = "0x182B8B240")]
	public static AFNKNFFEACM<TData> LMDPPDEOAIA<TData>(string LFKIGNHCOID, [In] TData BFLLAIFBMAJ) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class HIFNMCJCJIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool DAIDMLNCPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string GLOBADLPEGA;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1264070", Offset = "0x1262C70", VA = "0x181264070")]
	private HIFNMCJCJIE(bool FFEOOEEMEHO, string FJOIBFFDEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CB20", Offset = "0x6D3B720", VA = "0x186D3CB20")]
	public static HIFNMCJCJIE LMDPPDEOAIA(string FJOIBFFDEHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CB90", Offset = "0x6D3B790", VA = "0x186D3CB90")]
	public PFLKNJMIDLC MKFIMIHLLJF()
	{
		return default(PFLKNJMIDLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct PFLKNJMIDLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HIFNMCJCJIE GMAEEEDPLGJ;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xAE4B40", Offset = "0xAE3740", VA = "0x180AE4B40")]
	internal PFLKNJMIDLC(HIFNMCJCJIE PDMONEGPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DCA0", Offset = "0x6D3C8A0", VA = "0x186D3DCA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class HJAOIKMJHCN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class FBBAKDJKDNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public FBBAKDJKDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7230", Offset = "0x3DE5E30", VA = "0x183DE7230")]
		internal int GHJDMOMEOIL(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? AMHAMAMOFPG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> DFJIMMOMIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F41160", Offset = "0x3F3FD60", VA = "0x183F41160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NGFGCBMMFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F411F0", Offset = "0x3F3FDF0", VA = "0x183F411F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8866B0", VA = "0x180887AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x887AD0", Offset = "0x8866D0", VA = "0x180887AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3F40FA0", Offset = "0x3F3FBA0", VA = "0x183F40FA0")]
	public bool CMCAIIEBGOH(T DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3F40E30", Offset = "0x3F3FA30", VA = "0x183F40E30")]
	public bool CEFMELNJEMA(T DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3F411A0", Offset = "0x3F3FDA0", VA = "0x183F411A0")]
	public bool IFELPNGNEIG(T DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3F40D50", Offset = "0x3F3F950", VA = "0x183F40D50")]
	public void BBLBGFNHGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3F41240", Offset = "0x3F3FE40", VA = "0x183F41240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public HJAOIKMJHCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class GFFNOHKJGNM
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class MHJAGBKAKMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MHJAGBKAKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D8A0", Offset = "0x6D3C4A0", VA = "0x186D3D8A0")]
		internal int GHJDMOMEOIL(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? AMHAMAMOFPG;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> DFJIMMOMIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6D3C810", Offset = "0x6D3B410", VA = "0x186D3C810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool NGFGCBMMFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6D3C900", Offset = "0x6D3B500", VA = "0x186D3C900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8866B0", VA = "0x180887AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x887AD0", Offset = "0x8866D0", VA = "0x180887AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C730", Offset = "0x6D3B330", VA = "0x186D3C730")]
	public bool CMCAIIEBGOH(object DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C690", Offset = "0x6D3B290", VA = "0x186D3C690")]
	public bool CEFMELNJEMA(object DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C8A0", Offset = "0x6D3B4A0", VA = "0x186D3C8A0")]
	public bool IFELPNGNEIG(object DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C620", Offset = "0x6D3B220", VA = "0x186D3C620")]
	public void BBLBGFNHGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C910", Offset = "0x6D3B510", VA = "0x186D3C910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public GFFNOHKJGNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class FNCCECNEFBI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct KOKPDBIKFGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float INIDHEPNPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T PPPKGAOABBC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, KOKPDBIKFGJ> MPMLAHPFKKM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T NCFGMGEHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1252C60", Offset = "0x1251860", VA = "0x181252C60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1252250", Offset = "0x1250E50", VA = "0x181252250", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? DCFIMCMHPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OBGEOLNFJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E480", Offset = "0x3E1D080", VA = "0x183E1E480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3E1C140", Offset = "0x3E1AD40", VA = "0x183E1C140")]
	public bool FHJKMILGDEP(T CABLCDOIFFL, object DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BE70", Offset = "0x3E1AA70", VA = "0x183E1BE70")]
	public bool FFMOGGPFHLA(object DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BE20", Offset = "0x3E1AA20", VA = "0x183E1BE20")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3E1C900", Offset = "0x3E1B500", VA = "0x183E1C900")]
	public bool NNAAPMJPMIH(object DGGGDIFONNG, [Out] T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3E1D6C0", Offset = "0x3E1C2C0", VA = "0x183E1D6C0")]
	[PLDOCHCINLH("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OEJMNNPDFDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E4E0", Offset = "0x3E1D0E0", VA = "0x183E1E4E0")]
	public FNCCECNEFBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class NJIJOMFFCCK : HFBLOALIILG<LNPIEMBFDPP>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal class EEDLMKNHGFN : IEqualityComparer<LNPIEMBFDPP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal static readonly EEDLMKNHGFN AAGIFLNDKEI;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6D3C400", Offset = "0x6D3B000", VA = "0x186D3C400", Slot = "4")]
		public bool Equals(LNPIEMBFDPP MBJABMPNEHF, LNPIEMBFDPP MNMGCDILGBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x606ED00", Offset = "0x606D900", VA = "0x18606ED00", Slot = "5")]
		public int GetHashCode(LNPIEMBFDPP PLAMADMDGIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public EEDLMKNHGFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DB40", Offset = "0x6D3C740", VA = "0x186D3DB40")]
	public NJIJOMFFCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DA00", Offset = "0x6D3C600", VA = "0x186D3DA00", Slot = "4")]
	public override bool CMCAIIEBGOH(LNPIEMBFDPP DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D950", Offset = "0x6D3C550", VA = "0x186D3D950", Slot = "5")]
	public override bool CEFMELNJEMA(LNPIEMBFDPP DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DAB0", Offset = "0x6D3C6B0", VA = "0x186D3DAB0")]
	private static void ODPOBLAFDEL(LNPIEMBFDPP DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xEAA1D0", Offset = "0xEA8DD0", VA = "0x180EAA1D0", Slot = "6")]
	protected override string DNKFFIEAICN(LNPIEMBFDPP DGGGDIFONNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class LNPIEMBFDPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly string AFIFDCMNALI;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x889010", Offset = "0x887C10", VA = "0x180889010")]
	public LNPIEMBFDPP(string AFIFDCMNALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D850", Offset = "0x6D3C450", VA = "0x186D3D850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class HFBLOALIILG<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IEqualityComparer<T> DMMDHIPDEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<T>? AMHAMAMOFPG;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool NGFGCBMMFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3F391E0", Offset = "0x3F37DE0", VA = "0x183F391E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x921740", Offset = "0x920340", VA = "0x180921740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3F39510", Offset = "0x3F38110", VA = "0x183F39510")]
	internal HFBLOALIILG(IEqualityComparer<T> DMMDHIPDEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3F39010", Offset = "0x3F37C10", VA = "0x183F39010", Slot = "4")]
	public virtual bool CMCAIIEBGOH(T DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3F38EA0", Offset = "0x3F37AA0", VA = "0x183F38EA0", Slot = "5")]
	public virtual bool CEFMELNJEMA(T DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3F38DC0", Offset = "0x3F379C0", VA = "0x183F38DC0")]
	public void BBLBGFNHGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string DNKFFIEAICN(T DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3F39220", Offset = "0x3F37E20", VA = "0x183F39220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class LDEHHKLHPDI<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? AMHAMAMOFPG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NGFGCBMMFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x436C440", Offset = "0x436B040", VA = "0x18436C440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x436C030", Offset = "0x436AC30", VA = "0x18436C030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x436C1D0", Offset = "0x436ADD0", VA = "0x18436C1D0")]
	public void CMCAIIEBGOH(T DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x436BE90", Offset = "0x436AA90", VA = "0x18436BE90")]
	public void CEFMELNJEMA(T DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x436BE50", Offset = "0x436AA50", VA = "0x18436BE50")]
	public void BBLBGFNHGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x436C560", Offset = "0x436B160", VA = "0x18436C560", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public LDEHHKLHPDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class DMCEKDAGGCB
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2C3FA70", Offset = "0x2C3E670", VA = "0x182C3FA70")]
	public static void BEAJIEAJJGC<T>(this List<T> APGPCFDNGCA, int MFJLAMOCOBC) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class CDHLDKKCDJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, float> MPMLAHPFKKM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float JOJFKDOGAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x918F20", Offset = "0x917B20", VA = "0x180918F20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x918F10", Offset = "0x917B10", VA = "0x180918F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BDA0", Offset = "0x6D3A9A0", VA = "0x186D3BDA0")]
	public void FHJKMILGDEP(float CABLCDOIFFL, object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BD30", Offset = "0x6D3A930", VA = "0x186D3BD30")]
	public void FFMOGGPFHLA(object DGGGDIFONNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BCE0", Offset = "0x6D3A8E0", VA = "0x186D3BCE0")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BE10", Offset = "0x6D3AA10", VA = "0x186D3BE10")]
	private void JMKHKJJAJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BF40", Offset = "0x6D3AB40", VA = "0x186D3BF40")]
	public CDHLDKKCDJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface PDIMKNNFFLD
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LDOFJCEIIOP JMDAFOFANJN;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class BNBKMBMBJJG : PDIMKNNFFLD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct BLIIEMMLDMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly float LMFNDHIOLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly float IJIDNBHBGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal readonly bool OFMFOLKKKLF;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float DMCOCMMDKIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x6D3AEC0", Offset = "0x6D39AC0", VA = "0x186D3AEC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B030", Offset = "0x6D39C30", VA = "0x186D3B030")]
		public BLIIEMMLDMN(float GMEOEMGBEED, float DAKCGLGCCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3AED0", Offset = "0x6D39AD0", VA = "0x186D3AED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class KBKKMFGPBHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public BNBKMBMBJJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public KBKKMFGPBHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6D3CF00", Offset = "0x6D3BB00", VA = "0x186D3CF00")]
		internal void GHLLFODKFPM(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int KPFLHEHNDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int IPNGGBPMNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly PDIMKNNFFLD[] DHONLBNEMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly LDOFJCEIIOP[] CPKOIOKIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly BLIIEMMLDMN[] HAIOGCCPCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private BLIIEMMLDMN AIOMBKPKFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly BMFNFICELBE CPLOAIGCEMA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event LDOFJCEIIOP JMDAFOFANJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B590", Offset = "0x6D3A190", VA = "0x186D3B590", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B4D0", Offset = "0x6D3A0D0", VA = "0x186D3B4D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BB50", Offset = "0x6D3A750", VA = "0x186D3BB50")]
	public BNBKMBMBJJG(int KPFLHEHNDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6D3BAC0", Offset = "0x6D3A6C0", VA = "0x186D3BAC0")]
	public BMFNFICELBE OBLCCJBDHHH(BLIIEMMLDMN KNJGLEAPDIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B650", Offset = "0x6D3A250", VA = "0x186D3B650")]
	public void NHOLNNCMFBC(PDIMKNNFFLD GGKCJGMPDBG, [Optional] BLIIEMMLDMN AHJLJCPBIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B3C0", Offset = "0x6D39FC0", VA = "0x186D3B3C0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate void LDOFJCEIIOP(float NNBHKCLOCPP);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class GEMCGKEPJEN
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class HLEEOLEPFKC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly PDIMKNNFFLD GBKOLNCHHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly LDOFJCEIIOP NNGDIBHFMBF;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6D3CCA0", Offset = "0x6D3B8A0", VA = "0x186D3CCA0")]
		public HLEEOLEPFKC(PDIMKNNFFLD GBKOLNCHHFJ, LDOFJCEIIOP NNGDIBHFMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6D3CC50", Offset = "0x6D3B850", VA = "0x186D3CC50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C4F0", Offset = "0x6D3B0F0", VA = "0x186D3C4F0")]
	internal static bool DJKCAPABIDK(float ALHLFNOAFIL, float AFHCIMLJCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D2AEB0", Offset = "0x6D29AB0", VA = "0x186D2AEB0")]
	internal static float PMBGKBLIDBE(float ALHLFNOAFIL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C560", Offset = "0x6D3B160", VA = "0x186D3C560")]
	public static IDisposable NFGKIOBHJDA(this PDIMKNNFFLD GBKOLNCHHFJ, LDOFJCEIIOP NNGDIBHFMBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class BMFNFICELBE : PDIMKNNFFLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private float NNBHKCLOCPP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float GAIKOLFEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B190", Offset = "0x6D39D90", VA = "0x186D3B190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LDOFJCEIIOP? JMDAFOFANJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B320", Offset = "0x6D39F20", VA = "0x186D3B320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B280", Offset = "0x6D39E80", VA = "0x186D3B280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public BMFNFICELBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface JEMLMKNOHCJ<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EOMKJMHEGPF<T> DGNCLAFGAIG([Out] T CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANKOMBFBDGF();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class CNICDFGCLJD<T> : JEMLMKNOHCJ<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly ConcurrentStack<T> CKCPEFDADAF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x55E7EC0", Offset = "0x55E6AC0", VA = "0x1855E7EC0", Slot = "4")]
	public EOMKJMHEGPF<T> DGNCLAFGAIG([Out] T CABLCDOIFFL)
	{
		return default(EOMKJMHEGPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x55E7E40", Offset = "0x55E6A40", VA = "0x1855E7E40")]
	public void BIODNPDBBKO(T FKADPJNGCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x41E71D0", Offset = "0x41E5DD0", VA = "0x1841E71D0", Slot = "5")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "6")]
	protected virtual void MHHHIIEBPDK(T MMBNHPHCDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x55E7F60", Offset = "0x55E6B60", VA = "0x1855E7F60")]
	private T IBIJBNAFKLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x55E8000", Offset = "0x55E6C00", VA = "0x1855E8000")]
	public CNICDFGCLJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct EOMKJMHEGPF<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly T FKADPJNGCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CNICDFGCLJD<T> AKNBIKOODEF;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0xC7E130", Offset = "0xC7CD30", VA = "0x180C7E130")]
	internal EOMKJMHEGPF(T CABLCDOIFFL, CNICDFGCLJD<T> AKNBIKOODEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3A93C10", Offset = "0x3A92810", VA = "0x183A93C10", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class IPFHAPMEIEF : CNICDFGCLJD<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly IPFHAPMEIEF AAGIFLNDKEI;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CD30", Offset = "0x6D3B930", VA = "0x186D3CD30")]
	public static EOMKJMHEGPF<StringBuilder> IBIJBNAFKLE([Out] StringBuilder CABLCDOIFFL)
	{
		return default(EOMKJMHEGPF<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CDD0", Offset = "0x6D3B9D0", VA = "0x186D3CDD0", Slot = "6")]
	protected override void MHHHIIEBPDK(StringBuilder MMBNHPHCDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6D3CE80", Offset = "0x6D3BA80", VA = "0x186D3CE80")]
	public IPFHAPMEIEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class GPLGENNGPEF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x67333F0", Offset = "0x6731FF0", VA = "0x1867333F0")]
	public GPLGENNGPEF(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DefaultMember("Item")]
public class OPICECODFBP<TKey, TValue> : KADAJNJMNDG<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, NMABGOMAJGK where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class FINOEDKAMGM : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public OPICECODFBP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1252C60", Offset = "0x1251860", VA = "0x181252C60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x3E09A90", Offset = "0x3E08690", VA = "0x183E09A90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
		[DebuggerHidden]
		public FINOEDKAMGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3E09B20", Offset = "0x3E08720", VA = "0x183E09B20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3E08E60", Offset = "0x3E07A60", VA = "0x183E08E60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3E08D70", Offset = "0x3E07970", VA = "0x183E08D70")]
		private void GOOHPDHLOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3E08CD0", Offset = "0x3E078D0", VA = "0x183E08CD0")]
		private void BLMKNMDJMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3E09A40", Offset = "0x3E08640", VA = "0x183E09A40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly KADAJNJMNDG<TKey, TValue> MAEAONAJKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IDictionary<TKey, TValue> GCGGFFPPLBE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x47D72C0", Offset = "0x47D5EC0", VA = "0x1847D72C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool POMDFADBODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public TValue CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x47D74A0", Offset = "0x47D60A0", VA = "0x1847D74A0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x47D7730", Offset = "0x47D6330", VA = "0x1847D7730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ICollection<TKey> DGBOKIIJPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x47D74F0", Offset = "0x47D60F0", VA = "0x1847D74F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICollection<TValue> NAIAACHGNHK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x47D7610", Offset = "0x47D6210", VA = "0x1847D7610", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x47D7130", Offset = "0x47D5D30", VA = "0x1847D7130")]
	public OPICECODFBP(KADAJNJMNDG<TKey, TValue> MAEAONAJKOA, [Optional] IDictionary<TKey, TValue>? GCGGFFPPLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x47D4C90", Offset = "0x47D3890", VA = "0x1847D4C90", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x47D5D40", Offset = "0x47D4940", VA = "0x1847D5D40")]
	public void LGPMIPDPACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x47D44A0", Offset = "0x47D30A0", VA = "0x1847D44A0", Slot = "9")]
	public void Add(TKey NONKDEOLPHL, TValue CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x47D4B00", Offset = "0x47D3700", VA = "0x1847D4B00")]
	public void CEGNAPIAAOC(TKey NONKDEOLPHL, TValue CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x47D5680", Offset = "0x47D4280", VA = "0x1847D5680")]
	public void GHIMGNBMFGA(TKey NONKDEOLPHL, TValue CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x47D5D90", Offset = "0x47D4990", VA = "0x1847D5D90")]
	public void LIEELCBEDJG(TKey NONKDEOLPHL, TValue CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x47D5A40", Offset = "0x47D4640", VA = "0x1847D5A40")]
	public void ILCJIBCHIFN(TKey NONKDEOLPHL, TValue CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x47D6770", Offset = "0x47D5370", VA = "0x1847D6770", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x47D69A0", Offset = "0x47D55A0", VA = "0x1847D69A0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x47D6D00", Offset = "0x47D5900", VA = "0x1847D6D00", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x47D4DD0", Offset = "0x47D39D0", VA = "0x1847D4DD0", Slot = "8")]
	public bool ContainsKey(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x47D5550", Offset = "0x47D4150", VA = "0x1847D5550")]
	public bool FPACHCNMLGD(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x47D5C70", Offset = "0x47D4870", VA = "0x1847D5C70")]
	public bool KMEKLHCIJMF(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x47D65D0", Offset = "0x47D51D0", VA = "0x1847D65D0", Slot = "10")]
	public bool Remove(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x47D6F90", Offset = "0x47D5B90", VA = "0x1847D6F90", Slot = "11")]
	public bool TryGetValue(TKey NONKDEOLPHL, [Out] TValue CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x47D50D0", Offset = "0x47D3CD0", VA = "0x1847D50D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] BFDOCKABCPN, int GAPDNNJAGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x427A640", Offset = "0x4279240", VA = "0x18427A640", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x47D5990", Offset = "0x47D4590", VA = "0x1847D5990", Slot = "19")]
	[IteratorStateMachine(typeof(OPICECODFBP<, >.FINOEDKAMGM))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x47D49E0", Offset = "0x47D35E0", VA = "0x1847D49E0", Slot = "21")]
	public bool BOBGLELGCHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x47D6330", Offset = "0x47D4F30", VA = "0x1847D6330")]
	private TValue MBGHEAEEIOL(TKey NONKDEOLPHL)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface NMABGOMAJGK
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BOBGLELGCHG();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface KADAJNJMNDG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, NMABGOMAJGK
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public sealed class CPCFBGMIICB<TKey, TVal> : KADAJNJMNDG<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, NMABGOMAJGK where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate int ILPBECONAJN(TKey NONKDEOLPHL, TVal CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate void MPLJKMEPEKE(TKey NONKDEOLPHL, TVal CABLCDOIFFL, JLGIHACEOBD CKHPKJLILHH);

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class KKOICIMKOCE
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public TKey EIDDFPPJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x9624D0", Offset = "0x9610D0", VA = "0x1809624D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public TVal PPPKGAOABBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x921740", Offset = "0x920340", VA = "0x180921740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int DMCOCMMDKIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x8C8DC0", Offset = "0x8C79C0", VA = "0x1808C8DC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x8C8970", Offset = "0x8C7570", VA = "0x1808C8970")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public DateTimeOffset APDKOBJKNIK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xDF9600", Offset = "0xDF8200", VA = "0x180DF9600")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x175CCA0", Offset = "0x175B8A0", VA = "0x18175CCA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x42CEAD0", Offset = "0x42CD6D0", VA = "0x1842CEAD0")]
		public KKOICIMKOCE(TKey NONKDEOLPHL, TVal JEODFFDGHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class NCGAOEIPDBO : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public CPCFBGMIICB<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private LinkedList<KKOICIMKOCE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x1252C60", Offset = "0x1251860", VA = "0x181252C60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x464B1B0", Offset = "0x4649DB0", VA = "0x18464B1B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
		[DebuggerHidden]
		public NCGAOEIPDBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B830", Offset = "0x3D5A430", VA = "0x183D5B830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4649170", Offset = "0x4647D70", VA = "0x184649170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4648580", Offset = "0x4647180", VA = "0x184648580")]
		private void GOOHPDHLOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x464AD00", Offset = "0x4649900", VA = "0x18464AD00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int CGONKLKNALD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, LinkedListNode<KKOICIMKOCE>> GJKGKCDDLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<KKOICIMKOCE> ALHCGPNFDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly ILPBECONAJN? IKLKGJBCLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly TimeSpan CHJJGJPECNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MPLJKMEPEKE? AIBNOHNHHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly DBKKEODFJKB LLKLLPDMMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool PKOHKILGCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly List<TKey> PFOAINGADHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<TVal> IDDKCFEKNAJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int HAKLGKNKAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x897F00", Offset = "0x896B00", VA = "0x180897F00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int BCKGPECONPP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xCDF830", Offset = "0xCDE430", VA = "0x180CDF830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xCDF440", Offset = "0xCDE040", VA = "0x180CDF440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x56E3BD0", Offset = "0x56E27D0", VA = "0x1856E3BD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal int CLIIPEMPAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BE20", Offset = "0x3E1AA20", VA = "0x183E1BE20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ICollection<TVal> NAIAACHGNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x56E3D10", Offset = "0x56E2910", VA = "0x1856E3D10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ICollection<TKey> IDictionary<TKey, TVal>.JEANPMFEGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x56DD9B0", Offset = "0x56DC5B0", VA = "0x1856DD9B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool POMDFADBODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TVal CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x56E3CC0", Offset = "0x56E28C0", VA = "0x1856E3CC0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x56E3E00", Offset = "0x56E2A00", VA = "0x1856E3E00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x56C0E90", Offset = "0x56BFA90", VA = "0x1856C0E90")]
	private bool AGFBGLIAKGK(int KPFLHEHNDFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x56DBE20", Offset = "0x56DAA20", VA = "0x1856DBE20")]
	private void LFICPINGHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x56DF5C0", Offset = "0x56DE1C0", VA = "0x1856DF5C0")]
	public CPCFBGMIICB(int KPFLHEHNDFJ, [Optional] ILPBECONAJN? IKLKGJBCLCE, [Optional] IEqualityComparer<TKey>? PFAKHFIEDDE, [Optional] MPLJKMEPEKE? AIBNOHNHHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x56DF6A0", Offset = "0x56DE2A0", VA = "0x1856DF6A0")]
	public CPCFBGMIICB(TimeSpan CHJJGJPECNC, [Optional] IEqualityComparer<TKey>? PFAKHFIEDDE, [Optional] MPLJKMEPEKE? AIBNOHNHHFE, [Optional] DBKKEODFJKB? LLKLLPDMMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x56E0510", Offset = "0x56DF110", VA = "0x1856E0510")]
	public CPCFBGMIICB(int KPFLHEHNDFJ, TimeSpan CHJJGJPECNC, [Optional] IEqualityComparer<TKey>? PFAKHFIEDDE, [Optional] MPLJKMEPEKE? AIBNOHNHHFE, [Optional] DBKKEODFJKB? LLKLLPDMMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x56DFC50", Offset = "0x56DE850", VA = "0x1856DFC50")]
	public CPCFBGMIICB(int KPFLHEHNDFJ, ILPBECONAJN? IKLKGJBCLCE, TimeSpan CHJJGJPECNC, [Optional] IEqualityComparer<TKey>? PFAKHFIEDDE, [Optional] MPLJKMEPEKE? AIBNOHNHHFE, [Optional] DBKKEODFJKB? LLKLLPDMMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x56C25A0", Offset = "0x56C11A0", VA = "0x1856C25A0", Slot = "21")]
	public bool BOBGLELGCHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x56D2640", Offset = "0x56D1240", VA = "0x1856D2640", Slot = "22")]
	public bool HEIJMLOOCFF(int OLKJNOHMJPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x56D6650", Offset = "0x56D5250", VA = "0x1856D6650")]
	private bool JLKNJFFADJL(int OLKJNOHMJPI, JLGIHACEOBD CKHPKJLILHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x56CC800", Offset = "0x56CB400", VA = "0x1856CC800")]
	public void GAOLHIMCFIN(TKey NONKDEOLPHL, TVal CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x56C1160", Offset = "0x56BFD60", VA = "0x1856C1160", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x56C1340", Offset = "0x56BFF40", VA = "0x1856C1340", Slot = "9")]
	public void Add(TKey NONKDEOLPHL, TVal CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x56C2980", Offset = "0x56C1580", VA = "0x1856C2980", Slot = "8")]
	public bool ContainsKey(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x56DCF30", Offset = "0x56DBB30", VA = "0x1856DCF30", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x56DC7A0", Offset = "0x56DB3A0", VA = "0x1856DC7A0", Slot = "10")]
	public bool Remove(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x56DD3A0", Offset = "0x56DBFA0", VA = "0x1856DD3A0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x56D3CE0", Offset = "0x56D28E0", VA = "0x1856D3CE0")]
	private bool IGMKNHBMJOL(TKey NONKDEOLPHL, [Out] TVal CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x56D2ED0", Offset = "0x56D1AD0", VA = "0x1856D2ED0")]
	private TVal IBIJBNAFKLE(TKey EFGPCFMPHGL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x56DE010", Offset = "0x56DCC10", VA = "0x1856DE010", Slot = "11")]
	public bool TryGetValue(TKey EFGPCFMPHGL, [Out] TVal CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x56C2640", Offset = "0x56C1240", VA = "0x1856C2640", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x56C29E0", Offset = "0x56C15E0", VA = "0x1856C29E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BFDOCKABCPN, int GAPDNNJAGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x56C8CE0", Offset = "0x56C78E0", VA = "0x1856C8CE0")]
	private void FCKBBFJOEIN(TKey NONKDEOLPHL, TVal JEODFFDGHHF, JLGIHACEOBD CKHPKJLILHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x56D5520", Offset = "0x56D4120", VA = "0x1856D5520")]
	private bool JAJGAMGOALO(KKOICIMKOCE NMFCAGNJPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x56D0660", Offset = "0x56CF260", VA = "0x1856D0660")]
	private void GPOFAHBAAEJ(LinkedListNode<KKOICIMKOCE> LMHAKGDKIGG, TVal NJDPFLEAPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x56CBC20", Offset = "0x56CA820", VA = "0x1856CBC20")]
	private void FHJKMILGDEP(TKey NONKDEOLPHL, TVal CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x56C6350", Offset = "0x56C4F50", VA = "0x1856C6350")]
	private void EGMCIIAFOKK(KKOICIMKOCE NMFCAGNJPOH, TVal NJDPFLEAPBF, int LLFNIKDNAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x56D1CA0", Offset = "0x56D08A0", VA = "0x1856D1CA0", Slot = "19")]
	[IteratorStateMachine(typeof(CPCFBGMIICB<, >.NCGAOEIPDBO))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x56DDA00", Offset = "0x56DC600", VA = "0x1856DDA00", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum JLGIHACEOBD : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class DKIAJINFHDO<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly TKey EJDHFKOKKBL;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5AFDC80", Offset = "0x5AFC880", VA = "0x185AFDC80")]
	public DKIAJINFHDO(TKey LLJPIIJMFGP, Exception NPMCDNGADCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class JPBFNBCDGLI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD110", Offset = "0x5FFBD10", VA = "0x185FFD110")]
	public JPBFNBCDGLI(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class AKKGBCJBMHJ<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class ONBCBPGBIOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AKKGBCJBMHJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ONBCBPGBIOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x47CD5F0", Offset = "0x47CC1F0", VA = "0x1847CD5F0")]
		internal Task<TResource> MKBHPCMLNHD(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct NIJOKPFFKHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AKKGBCJBMHJ<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4671130", Offset = "0x466FD30", VA = "0x184671130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x46717B0", Offset = "0x46703B0", VA = "0x1846717B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct CIIFKOBDAHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x55DAF80", Offset = "0x55D9B80", VA = "0x1855DAF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x55DB5C0", Offset = "0x55DA1C0", VA = "0x1855DB5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly ABPDKKEOBLP<TId, Task<TResource>> DFFBMPPCFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> ALBEAFGOJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? ANDHJGBHAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Action<TResource>? BGCAKBGMPNA;

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3F18510", Offset = "0x3F17110", VA = "0x183F18510")]
	public AKKGBCJBMHJ(int GLJHBGHNEOE = 0, [Optional] IEqualityComparer<TId>? CEFMOGEFAIG, [Optional] Func<TId, CancellationToken, Task<TResource>>? FHEFKDOFPBL, [Optional] Action<TResource>? MJFDODGEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3F17250", Offset = "0x3F15E50", VA = "0x183F17250")]
	public LFNFGMGFLKN<Task<TResource>> BACNPOGNLCL(TId MJDOIIBKEKN, [Optional] Func<TId, CancellationToken, Task<TResource>>? FHEFKDOFPBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3F17670", Offset = "0x3F16270", VA = "0x183F17670")]
	private void EBFIFEDLDIP(Task<TResource> NEEKHCPCAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3F17BB0", Offset = "0x3F167B0", VA = "0x183F17BB0")]
	[AsyncStateMachine(typeof(AKKGBCJBMHJ<, >.NIJOKPFFKHB))]
	private Task FFBHGGGMBFK(Task<TResource> NEEKHCPCAAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3F182E0", Offset = "0x3F16EE0", VA = "0x183F182E0")]
	public void ONCBGJCMNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3F17CB0", Offset = "0x3F168B0", VA = "0x183F17CB0")]
	public ABPDKKEOBLP<TId, Task<TResource>>.IGHDENIFEMN NEGBLLIJCNA()
	{
		return default(ABPDKKEOBLP<TId, Task<TResource>>.IGHDENIFEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F18340", Offset = "0x3F16F40", VA = "0x183F18340", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3F18340", Offset = "0x3F16F40", VA = "0x183F18340", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3F17E20", Offset = "0x3F16A20", VA = "0x183F17E20")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(AKKGBCJBMHJ<, >.CIIFKOBDAHA))]
	internal static Task NOIDHIADIJM(Task<TResource> NEEKHCPCAAC, CancellationTokenSource CFDMNBAPLEI, Dictionary<Task<TResource>, CancellationTokenSource> OAPFBCMGGPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class ABPDKKEOBLP<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class IHDECIOJMLE : IEquatable<IHDECIOJMLE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly TValue PPPKGAOABBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int HECBLBOONPN;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xB103E0", Offset = "0xB0EFE0", VA = "0x180B103E0")]
		public IHDECIOJMLE(TValue CABLCDOIFFL, int JPNOCCDGDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x402AA80", Offset = "0x4029680", VA = "0x18402AA80", Slot = "4")]
		public bool Equals(IHDECIOJMLE? FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x402AB10", Offset = "0x4029710", VA = "0x18402AB10", Slot = "0")]
		public override bool Equals(object? PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x402AC40", Offset = "0x4029840", VA = "0x18402AC40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct IGHDENIFEMN : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Dictionary<TKey, IHDECIOJMLE>.Enumerator FLCFFIMLJNA;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x4028320", Offset = "0x4026F20", VA = "0x184028320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public (TKey Key, TValue Value, int RefCount) FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x4028840", Offset = "0x4027440", VA = "0x184028840", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4028560", Offset = "0x4027160", VA = "0x184028560")]
		public IGHDENIFEMN(ABPDKKEOBLP<TKey, TValue> MPMLAHPFKKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4027E30", Offset = "0x4026A30", VA = "0x184027E30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4027EB0", Offset = "0x4026AB0", VA = "0x184027EB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4028130", Offset = "0x4026D30", VA = "0x184028130", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class NBFFLHGNOCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public ABPDKKEOBLP<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public IHDECIOJMLE refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public NBFFLHGNOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4644430", Offset = "0x4643030", VA = "0x184644430")]
		internal void MKBHPCMLNHD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Dictionary<TKey, IHDECIOJMLE> IMGJGHKEJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Func<TKey, TValue>? KMGALOHMKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Action<TValue>? CCCIGHKDCKC;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F070", Offset = "0x3E9DC70", VA = "0x183E9F070")]
	public ABPDKKEOBLP(int GLJHBGHNEOE = 0, [Optional] IEqualityComparer<TKey>? PFAKHFIEDDE, [Optional] Func<TKey, TValue>? GGGOAHGIKEB, [Optional] Action<TValue>? DDOCIJMLEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E0B0", Offset = "0x3E9CCB0", VA = "0x183E9E0B0")]
	public LFNFGMGFLKN<TValue> BACNPOGNLCL(TKey NONKDEOLPHL, [Optional] Func<TKey, TValue>? LBOMCEHIIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E3C0", Offset = "0x3E9CFC0", VA = "0x183E9E3C0")]
	private void BIODNPDBBKO(TKey NONKDEOLPHL, IHDECIOJMLE IPDJCNMGEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E820", Offset = "0x3E9D420", VA = "0x183E9E820")]
	public void ONCBGJCMNME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E9E7E0", Offset = "0x3E9D3E0", VA = "0x183E9E7E0")]
	public IGHDENIFEMN NEGBLLIJCNA()
	{
		return default(IGHDENIFEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E9EEA0", Offset = "0x3E9DAA0", VA = "0x183E9EEA0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E9EEA0", Offset = "0x3E9DAA0", VA = "0x183E9EEA0", Slot = "5")]
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
