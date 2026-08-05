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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB1850", Offset = "0x7EB0250", VA = "0x187EB1850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class KOBDCLICANJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	protected KOBDCLICANJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class KKECEFNNDJN<T> : KOBDCLICANJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct FCFGLNHAHFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum EALMGLANOEN
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
		public EALMGLANOEN HHCAOFMCNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T KPGBPPBMJJK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int AMJGKOEPIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool KCKKFGKHPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool CGNDDFGIKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? NACKGAOLIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<FCFGLNHAHFP>? AIPDOCLENLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OABJDGENMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51CE3D0", Offset = "0x51CCDD0", VA = "0x1851CE3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x51CEAE0", Offset = "0x51CD4E0", VA = "0x1851CEAE0")]
	protected KKECEFNNDJN(bool CGNDDFGIKPD, bool KCKKFGKHPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x51CE230", Offset = "0x51CCC30", VA = "0x1851CE230")]
	protected bool AKLJDCJEIBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x51CE2D0", Offset = "0x51CCCD0", VA = "0x1851CE2D0")]
	protected void BODPJPCAHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x51CE5D0", Offset = "0x51CCFD0", VA = "0x1851CE5D0")]
	protected void GJPHMCPEGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x41D5990", Offset = "0x41D4390", VA = "0x1841D5990")]
	private static void BMGNNMKIFCI<U>(List<U>? IBKFNAMHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x51CE910", Offset = "0x51CD310", VA = "0x1851CE910", Slot = "4")]
	public void PBDMKLNODMP(T KPGBPPBMJJK, bool IDDMGLCKKCM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x51CE420", Offset = "0x51CCE20", VA = "0x1851CE420", Slot = "5")]
	public void DAAFLACHELB(T KPGBPPBMJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x51CE7A0", Offset = "0x51CD1A0", VA = "0x1851CE7A0")]
	public void MPMJEFEEPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class CNBOOGKDGFE : KKECEFNNDJN<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFF10", Offset = "0x7EAE910", VA = "0x187EAFF10")]
	public CNBOOGKDGFE(bool CGNDDFGIKPD = false, bool KCKKFGKHPGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFC50", Offset = "0x7EAE650", VA = "0x187EAFC50")]
	public void LPGMHIBJMOO()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFEB0", Offset = "0x7EAE8B0", VA = "0x187EAFEB0")]
	public static CNBOOGKDGFE MPNPGLJFKLJ(CNBOOGKDGFE COPJHCJMJGN, Action KPGBPPBMJJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFE50", Offset = "0x7EAE850", VA = "0x187EAFE50")]
	public static CNBOOGKDGFE MMPBDILPKIA(CNBOOGKDGFE COPJHCJMJGN, Action KPGBPPBMJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IIGPIHDFHHB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBDMKLNODMP(Action<T> KPGBPPBMJJK, bool IDDMGLCKKCM = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAAFLACHELB(Action<T> KPGBPPBMJJK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class NBHKBEPCJOC<T> : KKECEFNNDJN<Action<T>>, IIGPIHDFHHB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x46864F0", Offset = "0x4684EF0", VA = "0x1846864F0")]
	public NBHKBEPCJOC(bool CGNDDFGIKPD = false, bool KCKKFGKHPGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x54EE900", Offset = "0x54ED300", VA = "0x1854EE900")]
	public void LPGMHIBJMOO(T ANAFNAJGANI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4686460", Offset = "0x4684E60", VA = "0x184686460")]
	public static NBHKBEPCJOC<T> MPNPGLJFKLJ(NBHKBEPCJOC<T> COPJHCJMJGN, Action<T> KPGBPPBMJJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x46863D0", Offset = "0x4684DD0", VA = "0x1846863D0")]
	public static NBHKBEPCJOC<T> MMPBDILPKIA(NBHKBEPCJOC<T> COPJHCJMJGN, Action<T> KPGBPPBMJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DPLNOICGEPO<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBDMKLNODMP(Action<T, U> KPGBPPBMJJK, bool IDDMGLCKKCM = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAAFLACHELB(Action<T, U> KPGBPPBMJJK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class KGOFKGCFJHJ<T, U> : KKECEFNNDJN<Action<T, U>>, DPLNOICGEPO<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x46864F0", Offset = "0x4684EF0", VA = "0x1846864F0")]
	public KGOFKGCFJHJ(bool CGNDDFGIKPD = false, bool KCKKFGKHPGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x51BECE0", Offset = "0x51BD6E0", VA = "0x1851BECE0")]
	public void LPGMHIBJMOO(T ANAFNAJGANI, U FGOCNNDGEDL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4686460", Offset = "0x4684E60", VA = "0x184686460")]
	public static KGOFKGCFJHJ<T, U> MPNPGLJFKLJ(KGOFKGCFJHJ<T, U> COPJHCJMJGN, Action<T, U> KPGBPPBMJJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x46863D0", Offset = "0x4684DD0", VA = "0x1846863D0")]
	public static KGOFKGCFJHJ<T, U> MMPBDILPKIA(KGOFKGCFJHJ<T, U> COPJHCJMJGN, Action<T, U> KPGBPPBMJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class AHMKLKJJKLJ<T, U, V> : KKECEFNNDJN<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x46864F0", Offset = "0x4684EF0", VA = "0x1846864F0")]
	public AHMKLKJJKLJ(bool CGNDDFGIKPD = false, bool KCKKFGKHPGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D96270", Offset = "0x4D94C70", VA = "0x184D96270")]
	public void LPGMHIBJMOO(T ANAFNAJGANI, U FGOCNNDGEDL, V GEHEADBMGDC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4686460", Offset = "0x4684E60", VA = "0x184686460")]
	public static AHMKLKJJKLJ<T, U, V> MPNPGLJFKLJ(AHMKLKJJKLJ<T, U, V> COPJHCJMJGN, Action<T, U, V> KPGBPPBMJJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x46863D0", Offset = "0x4684DD0", VA = "0x1846863D0")]
	public static AHMKLKJJKLJ<T, U, V> MMPBDILPKIA(AHMKLKJJKLJ<T, U, V> COPJHCJMJGN, Action<T, U, V> KPGBPPBMJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IKCECEJIFBI<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class ODKBOOABNBM<T, U, V, W> : KKECEFNNDJN<Action<T, U, V, W>>, IKCECEJIFBI<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x46864F0", Offset = "0x4684EF0", VA = "0x1846864F0")]
	public ODKBOOABNBM(bool CGNDDFGIKPD = false, bool KCKKFGKHPGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5659000", Offset = "0x5657A00", VA = "0x185659000")]
	public void LPGMHIBJMOO(T ANAFNAJGANI, U FGOCNNDGEDL, V GEHEADBMGDC, W KEOEKIBOANH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4686460", Offset = "0x4684E60", VA = "0x184686460")]
	public static ODKBOOABNBM<T, U, V, W> MPNPGLJFKLJ(ODKBOOABNBM<T, U, V, W> COPJHCJMJGN, Action<T, U, V, W> KPGBPPBMJJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x46863D0", Offset = "0x4684DD0", VA = "0x1846863D0")]
	public static ODKBOOABNBM<T, U, V, W> MMPBDILPKIA(ODKBOOABNBM<T, U, V, W> COPJHCJMJGN, Action<T, U, V, W> KPGBPPBMJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class EBOGMHIHOCD<T, U, V, W, X> : KKECEFNNDJN<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x46864F0", Offset = "0x4684EF0", VA = "0x1846864F0")]
	public EBOGMHIHOCD(bool CGNDDFGIKPD = false, bool KCKKFGKHPGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4686040", Offset = "0x4684A40", VA = "0x184686040")]
	public void LPGMHIBJMOO(T ANAFNAJGANI, U FGOCNNDGEDL, V GEHEADBMGDC, W KEOEKIBOANH, X CBPCNABIALH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4686460", Offset = "0x4684E60", VA = "0x184686460")]
	public static EBOGMHIHOCD<T, U, V, W, X> MPNPGLJFKLJ(EBOGMHIHOCD<T, U, V, W, X> COPJHCJMJGN, Action<T, U, V, W, X> KPGBPPBMJJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x46863D0", Offset = "0x4684DD0", VA = "0x1846863D0")]
	public static EBOGMHIHOCD<T, U, V, W, X> MMPBDILPKIA(EBOGMHIHOCD<T, U, V, W, X> COPJHCJMJGN, Action<T, U, V, W, X> KPGBPPBMJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class CAMILDCBBIC<T, U, V, W, X, Y> : KKECEFNNDJN<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46864F0", Offset = "0x4684EF0", VA = "0x1846864F0")]
	public CAMILDCBBIC(bool CGNDDFGIKPD = false, bool KCKKFGKHPGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x64B7D00", Offset = "0x64B6700", VA = "0x1864B7D00")]
	public void LPGMHIBJMOO(T ANAFNAJGANI, U FGOCNNDGEDL, V GEHEADBMGDC, W KEOEKIBOANH, X CBPCNABIALH, Y CBOHEKOGGHJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4686460", Offset = "0x4684E60", VA = "0x184686460")]
	public static CAMILDCBBIC<T, U, V, W, X, Y> MPNPGLJFKLJ(CAMILDCBBIC<T, U, V, W, X, Y> COPJHCJMJGN, Action<T, U, V, W, X, Y> KPGBPPBMJJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x46863D0", Offset = "0x4684DD0", VA = "0x1846863D0")]
	public static CAMILDCBBIC<T, U, V, W, X, Y> MMPBDILPKIA(CAMILDCBBIC<T, U, V, W, X, Y> COPJHCJMJGN, Action<T, U, V, W, X, Y> KPGBPPBMJJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HKDKLMJLJEH<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NLGJDJPALEH<TKey, TVal> EMBDMKDJINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> GBIKELAGHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NLGJDJPALEH<TKey, TVal>.MOJOJGCIOHN? KKICOAKCIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int CCAALMJBKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NLGJDJPALEH<TKey, TVal>.KOHABHNCCCD? BDCFLFNNFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int OJHHJDIPHMA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int JHKJFGICCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4D02A30", Offset = "0x4D01430", VA = "0x184D02A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NJBAMFMNNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D02EC0", Offset = "0x4D018C0", VA = "0x184D02EC0")]
	public HKDKLMJLJEH(int CCAALMJBKCD, [Optional] NLGJDJPALEH<TKey, TVal>.KOHABHNCCCD? BDCFLFNNFEC, [Optional] IEqualityComparer<TKey>? MOGHEIPOEOH, [Optional] NLGJDJPALEH<TKey, TVal>.MOJOJGCIOHN? KKICOAKCIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4D02BF0", Offset = "0x4D015F0", VA = "0x184D02BF0")]
	public void OJHKCFCHEEP(TKey KJNEHANBOBO, TVal PCDAHJCDHHF, bool JKBGCJDBCBH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D02AD0", Offset = "0x4D014D0", VA = "0x184D02AD0")]
	public bool NFJIFLCOMMK(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D02650", Offset = "0x4D01050", VA = "0x184D02650")]
	public bool EHEIJGNBGFA(TKey HFGGEJCIMIJ, [Out] TVal PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D02800", Offset = "0x4D01200", VA = "0x184D02800")]
	private void JBBDEPOEFIL(TKey KJNEHANBOBO, TVal PCDAHJCDHHF, int OPKPFANIILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D01F50", Offset = "0x4D00950", VA = "0x184D01F50")]
	public bool AFHGADEDGJC(TKey KJNEHANBOBO, TVal PCDAHJCDHHF, bool JKBGCJDBCBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D02A70", Offset = "0x4D01470", VA = "0x184D02A70")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D020C0", Offset = "0x4D00AC0", VA = "0x184D020C0")]
	private void BOOEECBNBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4D02720", Offset = "0x4D01120", VA = "0x184D02720")]
	private bool GIPEDCLFHDI(TKey KJNEHANBOBO, GCBIKMLIFAK CHGJGNFMEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4D02580", Offset = "0x4D00F80", VA = "0x184D02580")]
	private void DLLLFGGALLC(TKey KJNEHANBOBO, TVal PCDAHJCDHHF, GCBIKMLIFAK CHGJGNFMEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D02DA0", Offset = "0x4D017A0", VA = "0x184D02DA0")]
	private void OOOBGBNBNCB(TKey KJNEHANBOBO, TVal KPILPFEAJHA, GCBIKMLIFAK CHGJGNFMEJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ADDCKLGEBCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action NBDIEELKKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MBBJKNNMILI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public ADDCKLGEBCI(Action KJODHAENABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE690", Offset = "0x7EAD090", VA = "0x187EAE690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3000800", Offset = "0x2FFF200", VA = "0x183000800")]
	public static BBBOLEBKOCP<T> JEBOFNEMEAN<T>(T PCDAHJCDHHF, Action KJODHAENABA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BBBOLEBKOCP<T> : ADDCKLGEBCI where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6022140", Offset = "0x6020B40", VA = "0x186022140")]
	public BBBOLEBKOCP(T PCDAHJCDHHF, Action KJODHAENABA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class IMFOONOHPMA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly ILNGCDALHHL<T>? FNLJBHDMMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> MJFOLNGHLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool MBBJKNNMILI;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly IMFOONOHPMA<T> BOAAIAHJNJN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> PDMHKLCACMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4E73840", Offset = "0x4E72240", VA = "0x184E73840")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4E73270", Offset = "0x4E71C70", VA = "0x184E73270")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LFELJFCAJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4E73780", Offset = "0x4E72180", VA = "0x184E73780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4E73A70", Offset = "0x4E72470", VA = "0x184E73A70")]
	public IMFOONOHPMA(ILNGCDALHHL<T> EMGHJJBJJLO, ILNGCDALHHL<T> ABEDOHJBKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4E73B30", Offset = "0x4E72530", VA = "0x184E73B30")]
	public IMFOONOHPMA(ILNGCDALHHL<T> EMGHJJBJJLO, int OBKGKEGIECO, ILNGCDALHHL<T> ABEDOHJBKJL, int OFHENEEBPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4E74250", Offset = "0x4E72C50", VA = "0x184E74250")]
	private IMFOONOHPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E733F0", Offset = "0x4E71DF0", VA = "0x184E733F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4E73510", Offset = "0x4E71F10", VA = "0x184E73510")]
	public T[] GHLGFMMOBOL()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4E735B0", Offset = "0x4E71FB0", VA = "0x184E735B0")]
	public static ReadOnlySequence<T> HNONLACFBHP(IMFOONOHPMA<T>? KFNMNKPGOMI)
	{
		return default(ReadOnlySequence<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CJININGKPAM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly IDisposable IPCKBKAKDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public T AMCECKEAKLL;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6675090", Offset = "0x6673A90", VA = "0x186675090")]
	public CJININGKPAM(IDisposable BBAFJLLBENK, [In] T PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7710", Offset = "0x3BD6110", VA = "0x183BD7710")]
	public static CJININGKPAM<U> PMGJANBCJKD<U>([In] CJININGKPAM<T> BBAFJLLBENK, [In] U PCDAHJCDHHF) where U : notnull
	{
		return default(CJININGKPAM<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6674F10", Offset = "0x6673910", VA = "0x186674F10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DKPPLMMGPOA
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x38D2600", Offset = "0x38D1000", VA = "0x1838D2600")]
	public static CJININGKPAM<T> FMDOFBCLPJB<T>(IDisposable BBAFJLLBENK, [In] T PCDAHJCDHHF) where T : notnull
	{
		return default(CJININGKPAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x38D2660", Offset = "0x38D1060", VA = "0x1838D2660")]
	public static CJININGKPAM<T> NLCKBKFNLAF<T>([In] this CJININGKPAM<T> NMEFAPBBOCD, [Out] T PCDAHJCDHHF) where T : notnull
	{
		return default(CJININGKPAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2FF30B0", Offset = "0x2FF1AB0", VA = "0x182FF30B0")]
	public static CJININGKPAM<U?> PMGJANBCJKD<U, T>([In] CJININGKPAM<T> BMBCHFCBNAD, [In] U PCDAHJCDHHF)
	{
		return default(CJININGKPAM<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct ONKIACMKPLC : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct AOMBIBMAIMI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
		public static AOMBIBMAIMI FMDOFBCLPJB()
		{
			return default(AOMBIBMAIMI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7EB19A0", Offset = "0x7EB03A0", VA = "0x187EB19A0")]
	public static string KPNHJFMOGKJ(Type HHCAOFMCNLG, [Optional] string? MNNGINICBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3C01560", Offset = "0x3BFFF60", VA = "0x183C01560")]
	public static string? KPNHJFMOGKJ<T>([Optional] string? MNNGINICBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3C014E0", Offset = "0x3BFFEE0", VA = "0x183C014E0")]
	public static string? EGMEEFLKGDB<T>([Optional] string? JHDGHJDKJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
	public static ONKIACMKPLC ALHLPHFCPPN(string MNNGINICBMO, string? JHDGHJDKJOM)
	{
		return default(ONKIACMKPLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BECPOFPPNAB
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate bool IFFOFOJKFNN(string JDAJGGCJDCG, BECPOFPPNAB IPDBFMOHJPF);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DOINJAHFMLD<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public DOINJAHFMLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6B15230", Offset = "0x6B13C30", VA = "0x186B15230")]
		internal void CAIGFPGIENC(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public int MIMNBICPMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public string OBBCJFCKOIF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE770", Offset = "0x7EAD170", VA = "0x187EAE770")]
	public static Dictionary<string, BECPOFPPNAB> FMNKCOMGDKN(Type HDKNAAMEFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37F04E0", Offset = "0x37EEEE0", VA = "0x1837F04E0")]
	public static Dictionary<string, BECPOFPPNAB> FMNKCOMGDKN<T>(Type HDKNAAMEFKN, IReadOnlyDictionary<T, string> KDANMNDJEDM) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x37EFE10", Offset = "0x37EE810", VA = "0x1837EFE10")]
	public static Dictionary<string, BECPOFPPNAB> ACKAMLBFKNJ<T>(List<T> PIBGDDODLPK) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEAB0", Offset = "0x7EAD4B0", VA = "0x187EAEAB0")]
	public static Dictionary<string, BECPOFPPNAB> GLKCBBPNCEL(Type HDKNAAMEFKN, IFFOFOJKFNN DPOEOHGADJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7EAEE70", Offset = "0x7EAD870", VA = "0x187EAEE70")]
	public static Dictionary<int, string> PFCDPCKLDDF(Dictionary<string, BECPOFPPNAB> CHCCOOMJKLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class GJIFJLKDAGC : NCGHLGNIAEG
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static bool FNINJLIIPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly string? ANKNCCPFKMC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual NCGHLGNIAEG? OOLPEKOPGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0860", Offset = "0x7EAF260", VA = "0x187EB0860")]
	protected GJIFJLKDAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string BKOEAJIGHJJ();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0500", Offset = "0x7EAEF00", VA = "0x187EB0500", Slot = "8")]
	public virtual string INKCPGFOHDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0250", Offset = "0x7EAEC50", VA = "0x187EB0250", Slot = "9")]
	public void GOGHOMKHBJH(StringBuilder AAHIKOCBPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0580", Offset = "0x7EAEF80", VA = "0x187EB0580", Slot = "10")]
	public void LJOILCKPEDN(StringBuilder AAHIKOCBPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7EB05E0", Offset = "0x7EAEFE0", VA = "0x187EB05E0", Slot = "11")]
	public void MANFJBJOGBE(StringBuilder AAHIKOCBPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0700", Offset = "0x7EAF100", VA = "0x187EB0700", Slot = "12")]
	public void MKIBPFPEFDL(StringBuilder AAHIKOCBPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7EB01B0", Offset = "0x7EAEBB0", VA = "0x187EB01B0")]
	public static void APFFOKGIOCM(StringBuilder AAHIKOCBPHO, string EEOCHCICMNA, string IPEBECECFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0D80", Offset = "0x6DEF780", VA = "0x186DF0D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FHNMKKPMLPD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0150", Offset = "0x7EAEB50", VA = "0x187EB0150")]
	public FHNMKKPMLPD(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GALJMJPMNKA<TErr> : FHNMKKPMLPD where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly TErr HPCLDFMIDHH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4C30430", Offset = "0x4C2EE30", VA = "0x184C30430")]
	private GALJMJPMNKA([In] TErr JDDLFGKMAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4C30370", Offset = "0x4C2ED70", VA = "0x184C30370")]
	public static GALJMJPMNKA<TErr> FMDOFBCLPJB([In] TErr JDDLFGKMAKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PPPELEKNLFK : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashAlgorithm MCNGHICCIEK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool FCFLNDJENLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool EOCJOLENBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool INLCBINLDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1D10", Offset = "0x7EB0710", VA = "0x187EB1D10", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long ICJIGFAHILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1D80", Offset = "0x7EB0780", VA = "0x187EB1D80", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1DF0", Offset = "0x7EB07F0", VA = "0x187EB1DF0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1CA0", Offset = "0x7EB06A0", VA = "0x187EB1CA0")]
	public PPPELEKNLFK(HashAlgorithm MCNGHICCIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1AD0", Offset = "0x7EB04D0", VA = "0x187EB1AD0", Slot = "35")]
	public override int Read(byte[] NNHDOHEKGEG, int BACDJHJBLPL, int IMCIONKBBCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1C70", Offset = "0x7EB0670", VA = "0x187EB1C70", Slot = "38")]
	public override void Write(byte[] NNHDOHEKGEG, int BACDJHJBLPL, int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1B70", Offset = "0x7EB0570", VA = "0x187EB1B70", Slot = "33")]
	public override long Seek(long BACDJHJBLPL, SeekOrigin CHGCFNILDNG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1C00", Offset = "0x7EB0600", VA = "0x187EB1C00", Slot = "34")]
	public override void SetLength(long PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1A00", Offset = "0x7EB0400", VA = "0x187EB1A00")]
	public byte[] ADDNLGDBAPC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NCGHLGNIAEG
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string INKCPGFOHDF();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string BKOEAJIGHJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DMAIMHDJNEK<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface KFJBNJPGKNN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string AKJEKGJFPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class ILNGCDALHHL<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static ILNGCDALHHL<T>? LJMMENLPCDP;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static object EDAHBAKBPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IMemoryOwner<T>? CGBNNLMLDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool MBBJKNNMILI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MCFAHADANHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF60", Offset = "0xA5E960", VA = "0x180A5FF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F630", Offset = "0x4E6E030", VA = "0x184E6F630")]
	private static ILNGCDALHHL<T> GNOOBIGBBNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FA90", Offset = "0x4E6E490", VA = "0x184E6FA90")]
	private static void HBCEFLPOHNL(ILNGCDALHHL<T> FJCJJKMKFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x467DD70", Offset = "0x467C770", VA = "0x18467DD70")]
	private ILNGCDALHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FFD0", Offset = "0x4E6E9D0", VA = "0x184E6FFD0")]
	public static ILNGCDALHHL<T> JEBOFNEMEAN(ReadOnlyMemory<T> IKIGJPENHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4E70180", Offset = "0x4E6EB80", VA = "0x184E70180")]
	public static ILNGCDALHHL<T> JEBOFNEMEAN(IMemoryOwner<T> GOGKGHNFIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4E705E0", Offset = "0x4E6EFE0", VA = "0x184E705E0")]
	public static void NMFANHPPPON(ILNGCDALHHL<T> EMGHJJBJJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F210", Offset = "0x4E6DC10", VA = "0x184E6F210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E70520", Offset = "0x4E6EF20", VA = "0x184E70520")]
	public ILNGCDALHHL<T> MIPLJCFCNGM(IMemoryOwner<T> GOGKGHNFIGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E6F050", Offset = "0x4E6DA50", VA = "0x184E6F050")]
	private void DDPCPBODANE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4E6EF50", Offset = "0x4E6D950", VA = "0x184E6EF50")]
	private ILNGCDALHHL<T> BOGMCHCLAAG(ILNGCDALHHL<T> FJCJJKMKFBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ENKKKCCENOI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB00A0", Offset = "0x7EAEAA0", VA = "0x187EB00A0")]
	public ENKKKCCENOI(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FOIFMFDJAOE<TOk> : ENKKKCCENOI where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TOk JDFPCIMIJBJ;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4B5EE30", Offset = "0x4B5D830", VA = "0x184B5EE30")]
	private FOIFMFDJAOE([In] TOk DEKOPGELPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4B5EB90", Offset = "0x4B5D590", VA = "0x184B5EB90")]
	public static FOIFMFDJAOE<TOk> FMDOFBCLPJB([In] TOk DEKOPGELPCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct KAFLOHEKGBO<TOk, TErr> : IEquatable<KAFLOHEKGBO<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly EqualityComparer<TErr> GGJJBBPPELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal readonly TErr HPCLDFMIDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal readonly TOk JDFPCIMIJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GEAKHACPMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x516EF40", Offset = "0x516D940", VA = "0x18516EF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool KGKDJBDAEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x516F640", Offset = "0x516E040", VA = "0x18516F640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x51740C0", Offset = "0x5172AC0", VA = "0x1851740C0")]
	internal KAFLOHEKGBO([In] TErr JDDLFGKMAKO, [In] TOk DEKOPGELPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5170270", Offset = "0x516EC70", VA = "0x185170270")]
	public static KAFLOHEKGBO<TOk, TErr> OBPDHKPILCJ([In] TErr JDDLFGKMAKO)
	{
		return default(KAFLOHEKGBO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x516B630", Offset = "0x516A030", VA = "0x18516B630")]
	public static KAFLOHEKGBO<TOk, TErr> GBOJJBLDHKI([In] TOk DEKOPGELPCC)
	{
		return default(KAFLOHEKGBO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4141A80", Offset = "0x4140480", VA = "0x184141A80")]
	public KAFLOHEKGBO<TOk?, UErr?> DFMBOIILPMN<UErr>()
	{
		return default(KAFLOHEKGBO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x41427D0", Offset = "0x41411D0", VA = "0x1841427D0")]
	public KAFLOHEKGBO<UOk?, TErr?> FDIPHAHKKAJ<UOk>()
	{
		return default(KAFLOHEKGBO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4143740", Offset = "0x4142140", VA = "0x184143740")]
	public KAFLOHEKGBO<UOk?, TErr?> PADBONONBAP<UOk>()
	{
		return default(KAFLOHEKGBO<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x41414A0", Offset = "0x413FEA0", VA = "0x1841414A0")]
	public KAFLOHEKGBO<TOk?, UErr?> CPJNNGBOHMB<UErr>()
	{
		return default(KAFLOHEKGBO<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5169F70", Offset = "0x5168970", VA = "0x185169F70")]
	public KAFLOHEKGBO<NOHGHNIBNOG, TErr> ENDAJKOIKIK()
	{
		return default(KAFLOHEKGBO<NOHGHNIBNOG, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x516DDC0", Offset = "0x516C7C0", VA = "0x18516DDC0")]
	public static bool IDFALDDOLDN([In] KAFLOHEKGBO<TOk, TErr> OCPABDEGAMF, [In] KAFLOHEKGBO<TOk, TErr> MAMEIEKFKPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x516A420", Offset = "0x5168E20", VA = "0x18516A420", Slot = "4")]
	public bool Equals(KAFLOHEKGBO<TOk, TErr> NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x516A8C0", Offset = "0x51692C0", VA = "0x18516A8C0", Slot = "0")]
	public override bool Equals(object NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x516CAD0", Offset = "0x516B4D0", VA = "0x18516CAD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x51714D0", Offset = "0x516FED0", VA = "0x1851714D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class IDPGHJFHEJA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct JGDAHKLOBDF<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Task<KAFLOHEKGBO<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<KAFLOHEKGBO<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5090B10", Offset = "0x508F510", VA = "0x185090B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5091110", Offset = "0x508FB10", VA = "0x185091110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0440", Offset = "0x3A9EE40", VA = "0x183AA0440")]
	public static KAFLOHEKGBO<TOk?, TErr?> JDFPCIMIJBJ<TOk, TErr>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [In] TOk DEKOPGELPCC)
	{
		return default(KAFLOHEKGBO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA05F0", Offset = "0x3A9EFF0", VA = "0x183AA05F0")]
	public static KAFLOHEKGBO<NOHGHNIBNOG, TErr?> JDFPCIMIJBJ<TErr>([In] this KAFLOHEKGBO<NOHGHNIBNOG, TErr> NMEFAPBBOCD)
	{
		return default(KAFLOHEKGBO<NOHGHNIBNOG, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0440", Offset = "0x3A9EE40", VA = "0x183AA0440")]
	public static KAFLOHEKGBO<TOk?, TErr?> HPCLDFMIDHH<TOk, TErr>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [In] TErr JDDLFGKMAKO)
	{
		return default(KAFLOHEKGBO<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F2E0", Offset = "0x3A9DCE0", VA = "0x183A9F2E0")]
	public static TOk? DIFANIFENEL<TOk, TErr>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2AE0", Offset = "0x3AA14E0", VA = "0x183AA2AE0")]
	[AsyncStateMachine(typeof(JGDAHKLOBDF<, >))]
	public static Task<TOk?>? NINCKHKIBBE<TOk, TErr>(this Task<KAFLOHEKGBO<TOk, TErr>> NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2550", Offset = "0x3AA0F50", VA = "0x183AA2550")]
	public static TErr? LGCJLDADGMP<TErr, TOk>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0DE0", Offset = "0x3A9F7E0", VA = "0x183AA0DE0")]
	public static bool JMOCFMLCEKK<TOk, TErr, UErr, UOk>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [Out] KAFLOHEKGBO<UOk, UErr> OCDOMHCMAKG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F000", Offset = "0x3A9DA00", VA = "0x183A9F000")]
	public static bool BMFOJFLPKEA<TOk, TErr>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [Out] TOk DEKOPGELPCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3AA28C0", Offset = "0x3AA12C0", VA = "0x183AA28C0")]
	public static bool LLBPLEIAMKB<TOk, TErr>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [Out][NotNullWhen(true)] TErr JDDLFGKMAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0240", Offset = "0x3A9EC40", VA = "0x183AA0240")]
	public static bool GMAHKOOLNFB<TOk, TErr>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [Out][NotNullWhen(true)] TOk DEKOPGELPCC, [Out][NotNullWhen(false)] TErr JDDLFGKMAKO) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0660", Offset = "0x3A9F060", VA = "0x183AA0660")]
	public static bool JFGEIPIALIK<TOk, TErr>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [Out][NotNullWhen(true)] TOk DEKOPGELPCC, [Out] KAFLOHEKGBO<TOk, TErr> OCDOMHCMAKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0B90", Offset = "0x3A9F590", VA = "0x183AA0B90")]
	public static bool JMOCFMLCEKK<TOk, TErr, UErr, UOk>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [Out][NotNullWhen(true)] TOk DEKOPGELPCC, [Out] KAFLOHEKGBO<UOk, UErr> OCDOMHCMAKG) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0830", Offset = "0x3A9F230", VA = "0x183AA0830")]
	public static bool JJEBIOCMEAN<TOk, TErr>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [Out][NotNullWhen(true)] TOk DEKOPGELPCC, [Out] KAFLOHEKGBO<NOHGHNIBNOG, TErr> OCDOMHCMAKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F9B0", Offset = "0x3A9E3B0", VA = "0x183A9F9B0")]
	public static KAFLOHEKGBO<UOk, UErr> EGJNJADECHN<UOk, UErr, TOk, TErr>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, [In] KAFLOHEKGBO<UOk, UErr> FHFGMILAALL) where TOk : UOk where TErr : UErr
	{
		return default(KAFLOHEKGBO<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3AA20A0", Offset = "0x3AA0AA0", VA = "0x183AA20A0")]
	public static KAFLOHEKGBO<TOk?[]?, TErr?> LFPNPHEHLPN<TOk, TErr>(this IEnumerable<KAFLOHEKGBO<TOk, TErr>> NMEFAPBBOCD)
	{
		return default(KAFLOHEKGBO<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2E60", Offset = "0x3AA1860", VA = "0x183AA2E60")]
	public static KAFLOHEKGBO<UOk?, TErr?> PLCDOLHELKJ<UOk, TErr, TOk>([In] this KAFLOHEKGBO<TOk, TErr> NMEFAPBBOCD, Func<TOk, UOk> CGJGLNMKOCK)
	{
		return default(KAFLOHEKGBO<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class KNIELABJGCD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x41D5A10", Offset = "0x41D4410", VA = "0x1841D5A10")]
	public static KAFLOHEKGBO<TOk, T> JDFPCIMIJBJ<TOk>([In] TOk DEKOPGELPCC) where TOk : notnull
	{
		return default(KAFLOHEKGBO<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x51E3180", Offset = "0x51E1B80", VA = "0x1851E3180")]
	public static KAFLOHEKGBO<NOHGHNIBNOG, T> JDFPCIMIJBJ()
	{
		return default(KAFLOHEKGBO<NOHGHNIBNOG, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x41D5A10", Offset = "0x41D4410", VA = "0x1841D5A10")]
	public static KAFLOHEKGBO<T, TErr> HPCLDFMIDHH<TErr>([In] TErr JDDLFGKMAKO) where TErr : notnull
	{
		return default(KAFLOHEKGBO<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct KKKKBMIJGEL<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly LDMMBIOBDBN DPLNPKEPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TKey, TValue> MPMCEIDDGOF;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAB70", Offset = "0x4CF9570", VA = "0x184CFAB70")]
	public static KKKKBMIJGEL<TKey, TValue> FMDOFBCLPJB(string GJIMIGJJJKI)
	{
		return default(KKKKBMIJGEL<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAD20", Offset = "0x4CF9720", VA = "0x184CFAD20")]
	internal KKKKBMIJGEL(Dictionary<TKey, TValue> PCDAHJCDHHF, LDMMBIOBDBN OPKJGIBHPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAC80", Offset = "0x4CF9680", VA = "0x184CFAC80")]
	public OLKHFPECPPG<TKey, TValue> GBICALGHAOO([Out] Dictionary<TKey, TValue> PCDAHJCDHHF)
	{
		return default(OLKHFPECPPG<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct OLKHFPECPPG<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TValue> MPMCEIDDGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly PEKFMABJKON HPLFELGDDIL;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B650", Offset = "0x2B1A050", VA = "0x182B1B650")]
	internal OLKHFPECPPG(Dictionary<TKey, TValue> PCDAHJCDHHF, PEKFMABJKON NIEBHJDFDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x51BDE60", Offset = "0x51BC860", VA = "0x1851BDE60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct HJDICCFALGF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly LDMMBIOBDBN DPLNPKEPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly HashSet<T> MPMCEIDDGOF;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAB70", Offset = "0x4CF9570", VA = "0x184CFAB70")]
	public static HJDICCFALGF<T> FMDOFBCLPJB(string GJIMIGJJJKI)
	{
		return default(HJDICCFALGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAD20", Offset = "0x4CF9720", VA = "0x184CFAD20")]
	internal HJDICCFALGF(HashSet<T> PCDAHJCDHHF, LDMMBIOBDBN OPKJGIBHPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAC80", Offset = "0x4CF9680", VA = "0x184CFAC80")]
	public DCKJLHGJCNO<T> GBICALGHAOO([Out] HashSet<T> PCDAHJCDHHF)
	{
		return default(DCKJLHGJCNO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DCKJLHGJCNO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<T> MPMCEIDDGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly PEKFMABJKON HPLFELGDDIL;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B650", Offset = "0x2B1A050", VA = "0x182B1B650")]
	internal DCKJLHGJCNO(HashSet<T> PCDAHJCDHHF, PEKFMABJKON NIEBHJDFDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x51BDE60", Offset = "0x51BC860", VA = "0x1851BDE60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LAOLMADDEJJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly LDMMBIOBDBN DPLNPKEPEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Stack<T> MPMCEIDDGOF;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAB70", Offset = "0x4CF9570", VA = "0x184CFAB70")]
	public static LAOLMADDEJJ<T> FMDOFBCLPJB(string GJIMIGJJJKI)
	{
		return default(LAOLMADDEJJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAD20", Offset = "0x4CF9720", VA = "0x184CFAD20")]
	internal LAOLMADDEJJ(Stack<T> PCDAHJCDHHF, LDMMBIOBDBN OPKJGIBHPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAC80", Offset = "0x4CF9680", VA = "0x184CFAC80")]
	public KGHLLHDBPLG<T> GBICALGHAOO([Out] Stack<T> PCDAHJCDHHF)
	{
		return default(KGHLLHDBPLG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct KGHLLHDBPLG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Stack<T> MPMCEIDDGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly PEKFMABJKON HPLFELGDDIL;

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B1B650", Offset = "0x2B1A050", VA = "0x182B1B650")]
	internal KGHLLHDBPLG(Stack<T> PCDAHJCDHHF, PEKFMABJKON NIEBHJDFDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x51BDE60", Offset = "0x51BC860", VA = "0x1851BDE60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[DefaultMember("Item")]
public sealed class IHCIIHCKIAD<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct BDCDDMIMDML : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly IHCIIHCKIAD<T> HMIMLECNHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int KOJLFIFCHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly bool CKKGBJNHGCE;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x27AC8B0", Offset = "0x27AB2B0", VA = "0x1827AC8B0")]
		public BDCDDMIMDML(IHCIIHCKIAD<T> LALBBHEFJAE, int LAMPOLGKHFA, bool NNIHDDCLGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6024E80", Offset = "0x6023880", VA = "0x186024E80")]
		public IHCIIHCKIAD<T>.FJJNDIELHKG ICNPOCIJNJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6024F60", Offset = "0x6023960", VA = "0x186024F60", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6024F60", Offset = "0x6023960", VA = "0x186024F60", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class FJJNDIELHKG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly IHCIIHCKIAD<T> HMIMLECNHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int BAAGOBDKPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int PMHNNCIPMBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly bool CKKGBJNHGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool GNFAFEAHDIH;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x4B488F0", Offset = "0x4B472F0", VA = "0x184B488F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4B48A80", Offset = "0x4B47480", VA = "0x184B48A80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x4B48CB0", Offset = "0x4B476B0", VA = "0x184B48CB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B49100", Offset = "0x4B47B00", VA = "0x184B49100")]
		public FJJNDIELHKG(IHCIIHCKIAD<T> LALBBHEFJAE, int LAMPOLGKHFA, bool NNIHDDCLGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4B48930", Offset = "0x4B47330", VA = "0x184B48930", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4B489B0", Offset = "0x4B473B0", VA = "0x184B489B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class JGPKNDPDGDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public JGPKNDPDGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5097400", Offset = "0x5095E00", VA = "0x185097400")]
		internal T HKNPEBJEBAB(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly T[] NNNBCOPAALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private int PMHNNCIPMBM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int APAPOCHNIGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4E517C0", Offset = "0x4E501C0", VA = "0x184E517C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T NBBAKIJBGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4B25300", Offset = "0x4B23D00", VA = "0x184B25300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T HMMJEOMFOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4E518B0", Offset = "0x4E502B0", VA = "0x184E518B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4E51760", Offset = "0x4E50160", VA = "0x184E51760")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int DNLMLJALHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2737DA0", Offset = "0x27367A0", VA = "0x182737DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1BD08F0", Offset = "0x1BCF2F0", VA = "0x181BD08F0")]
	private static int DJAFGAAPNAI(int MNFHMLCLFEB, int EIJGIDNMHGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4E51B00", Offset = "0x4E50500", VA = "0x184E51B00")]
	public IHCIIHCKIAD(int OPKPFANIILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4E519A0", Offset = "0x4E503A0", VA = "0x184E519A0")]
	public IHCIIHCKIAD(int OPKPFANIILK, Func<T> PKCOPHDNDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4E51C10", Offset = "0x4E50610", VA = "0x184E51C10")]
	public IHCIIHCKIAD(T[] PCNLBIOPFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4E51800", Offset = "0x4E50200", VA = "0x184E51800")]
	public void DOKKAJBPFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E518E0", Offset = "0x4E502E0", VA = "0x184E518E0")]
	public IEnumerable<T> PEGOCIPPJME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4E51830", Offset = "0x4E50230", VA = "0x184E51830")]
	public IHCIIHCKIAD<T>.FJJNDIELHKG ICNPOCIJNJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4C0B0F0", Offset = "0x4C09AF0", VA = "0x184C0B0F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4C0B0F0", Offset = "0x4C09AF0", VA = "0x184C0B0F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class JMMKCNLKNKE
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDF20", Offset = "0x3ACC920", VA = "0x183ACDF20")]
	public static IHCIIHCKIAD<T> FMDOFBCLPJB<T>(int OPKPFANIILK, Func<T> PKCOPHDNDLG) where T : notnull
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
			[Cpp2IlInjected.Address(RVA = "0x7EB2830", Offset = "0x7EB1230", VA = "0x187EB2830")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static RRColor Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7EB27F0", Offset = "0x7EB11F0", VA = "0x187EB27F0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RRColor Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7EB2810", Offset = "0x7EB1210", VA = "0x187EB2810")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static RRColor Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7EB2850", Offset = "0x7EB1250", VA = "0x187EB2850")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static RRColor Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7EB27D0", Offset = "0x7EB11D0", VA = "0x187EB27D0")]
			get
			{
				return default(RRColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x28DE980", Offset = "0x28DD380", VA = "0x1828DE980")]
		public RRColor(float FGEFHKAEIPE, float FEGNDEJPMLD, float LJDEEJKPAEN, float MJGADEGDMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D320B0", Offset = "0x7D30AB0", VA = "0x187D320B0", Slot = "4")]
		public bool Equals(RRColor NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EB2410", Offset = "0x7EB0E10", VA = "0x187EB2410", Slot = "0")]
		public override bool Equals(object NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7EB2510", Offset = "0x7EB0F10", VA = "0x187EB2510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7EB2590", Offset = "0x7EB0F90", VA = "0x187EB2590", Slot = "5")]
		public string ToString(string DFJIALHJPBA, IFormatProvider FGDNBAHEDKA)
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
			[Cpp2IlInjected.Address(RVA = "0x7EB23B0", Offset = "0x7EB0DB0", VA = "0x187EB23B0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RRColor32 Green
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7EB2350", Offset = "0x7EB0D50", VA = "0x187EB2350")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static RRColor32 Red
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7EB2380", Offset = "0x7EB0D80", VA = "0x187EB2380")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static RRColor32 Yellow
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7EB23E0", Offset = "0x7EB0DE0", VA = "0x187EB23E0")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static RRColor32 Cyan
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x7EB2320", Offset = "0x7EB0D20", VA = "0x187EB2320")]
			get
			{
				return default(RRColor32);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5DC0310", Offset = "0x5DBED10", VA = "0x185DC0310")]
		public RRColor32(byte FGEFHKAEIPE, byte FEGNDEJPMLD, byte LJDEEJKPAEN, byte MJGADEGDMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x22D9F40", Offset = "0x22D8940", VA = "0x1822D9F40", Slot = "4")]
		public bool Equals(RRColor32 NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1E60", Offset = "0x7EB0860", VA = "0x187EB1E60", Slot = "0")]
		public override bool Equals(object NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1425070", Offset = "0x1423A70", VA = "0x181425070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1F60", Offset = "0x7EB0960", VA = "0x187EB1F60")]
		public static RRColor32 HNONLACFBHP(RRColor CIBCGCDEGFN)
		{
			return default(RRColor32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1EF0", Offset = "0x7EB08F0", VA = "0x187EB1EF0")]
		public static RRColor HNONLACFBHP(RRColor32 CIBCGCDEGFN)
		{
			return default(RRColor);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7EB20B0", Offset = "0x7EB0AB0", VA = "0x187EB20B0", Slot = "5")]
		public string ToString(string DFJIALHJPBA, IFormatProvider FGDNBAHEDKA)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PCIMMNLKGGJ<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct FBOPBBEANIE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly PCIMMNLKGGJ<T> DINOMMHAEDL;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T AMCECKEAKLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x4B31460", Offset = "0x4B2FE60", VA = "0x184B31460")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4B31430", Offset = "0x4B2FE30", VA = "0x184B31430", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
		public FBOPBBEANIE(PCIMMNLKGGJ<T> DINOMMHAEDL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct ACDACJDDHDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<FBOPBBEANIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public PCIMMNLKGGJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4C9D770", Offset = "0x4C9C170", VA = "0x184C9D770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4694260", Offset = "0x4692C60", VA = "0x184694260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly SemaphoreSlim KMDGCFHOMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private T IEBGOKLBDGB;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x57586A0", Offset = "0x57570A0", VA = "0x1857586A0")]
	public PCIMMNLKGGJ([In] T IEBGOKLBDGB, int IDKEMGGKDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5758530", Offset = "0x5756F30", VA = "0x185758530")]
	public PCIMMNLKGGJ([In] T IEBGOKLBDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5757FB0", Offset = "0x57569B0", VA = "0x185757FB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5758430", Offset = "0x5756E30", VA = "0x185758430")]
	public FBOPBBEANIE KJLHFKGNDHK()
	{
		return default(FBOPBBEANIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5758100", Offset = "0x5756B00", VA = "0x185758100")]
	[AsyncStateMachine(typeof(PCIMMNLKGGJ<>.ACDACJDDHDF))]
	public Task<PCIMMNLKGGJ<T>.FBOPBBEANIE> EIFJNIHMDOM(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5758470", Offset = "0x5756E70", VA = "0x185758470")]
	public void MCPHAJIMCAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class MIIABLLBCJG
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1110", Offset = "0x7EAFB10", VA = "0x187EB1110")]
	public static PCIMMNLKGGJ<NOHGHNIBNOG> FMDOFBCLPJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x30000B0", Offset = "0x2FFEAB0", VA = "0x1830000B0")]
	public static PCIMMNLKGGJ<T> FMDOFBCLPJB<T>([In] T IEBGOKLBDGB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class OOMJAFMPGBF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct LDIBHBPDEGL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly OOMJAFMPGBF<T> FFBOCMCFLEC;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T AMCECKEAKLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4B5E650", Offset = "0x4B5D050", VA = "0x184B5E650")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5277630", Offset = "0x5276030", VA = "0x185277630", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
		internal LDIBHBPDEGL(OOMJAFMPGBF<T> DINOMMHAEDL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public readonly struct FODAPDKEMLJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly OOMJAFMPGBF<T> FFBOCMCFLEC;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public T AMCECKEAKLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4B5E650", Offset = "0x4B5D050", VA = "0x184B5E650")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4B5E5B0", Offset = "0x4B5CFB0", VA = "0x184B5E5B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
		internal FODAPDKEMLJ(OOMJAFMPGBF<T> DINOMMHAEDL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct AIBNDOCHILN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public AsyncTaskMethodBuilder<FODAPDKEMLJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public OOMJAFMPGBF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private PCIMMNLKGGJ<NOHGHNIBNOG>.FBOPBBEANIE <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<PCIMMNLKGGJ<NOHGHNIBNOG>.FBOPBBEANIE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4D99150", Offset = "0x4D97B50", VA = "0x184D99150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4694260", Offset = "0x4692C60", VA = "0x184694260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PCIMMNLKGGJ<int> AKMINMCBMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PCIMMNLKGGJ<NOHGHNIBNOG> HKDHAPPCAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PCIMMNLKGGJ<NOHGHNIBNOG> ODHMMIDCPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private T FBENFOKKFLD;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x56A2BB0", Offset = "0x56A15B0", VA = "0x1856A2BB0")]
	internal OOMJAFMPGBF(PCIMMNLKGGJ<int> BBLOMNFFPDH, PCIMMNLKGGJ<NOHGHNIBNOG> DFLPJGCNNNA, PCIMMNLKGGJ<NOHGHNIBNOG> DAHFDPDGENG, [In] T IEBGOKLBDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x56A2220", Offset = "0x56A0C20", VA = "0x1856A2220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x56A25F0", Offset = "0x56A0FF0", VA = "0x1856A25F0")]
	public LDIBHBPDEGL NHDANIJBDLK()
	{
		return default(LDIBHBPDEGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x56A2500", Offset = "0x56A0F00", VA = "0x1856A2500")]
	public FODAPDKEMLJ EDMCADMCJAO()
	{
		return default(FODAPDKEMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x56A1E40", Offset = "0x56A0840", VA = "0x1856A1E40")]
	[AsyncStateMachine(typeof(OOMJAFMPGBF<>.AIBNDOCHILN))]
	public Task<OOMJAFMPGBF<T>.FODAPDKEMLJ> AGADCGGAMAB(CancellationToken JKPNCAGHEDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OEEMKECKGMC
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB18D0", Offset = "0x7EB02D0", VA = "0x187EB18D0")]
	public static OOMJAFMPGBF<NOHGHNIBNOG> FMDOFBCLPJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3BF31F0", Offset = "0x3BF1BF0", VA = "0x183BF31F0")]
	public static OOMJAFMPGBF<T> FMDOFBCLPJB<T>([In] T IEBGOKLBDGB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class EPDNBKHJEFH<TData> : GJIFJLKDAGC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly string PGOOIHNHDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly TData JLKLNDPHPHM;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
	public override string BKOEAJIGHJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x46BE890", Offset = "0x46BD290", VA = "0x1846BE890")]
	internal EPDNBKHJEFH(string IJOJGNJMCGP, [In] TData HPGIDELCODH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DNAMJMLBGDE
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFF70", Offset = "0x7EAE970", VA = "0x187EAFF70")]
	public static EPDNBKHJEFH<NOHGHNIBNOG> FMDOFBCLPJB(string IJOJGNJMCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3000800", Offset = "0x2FFF200", VA = "0x183000800")]
	public static EPDNBKHJEFH<TData> FMDOFBCLPJB<TData>(string IJOJGNJMCGP, [In] TData HPGIDELCODH) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class LDMMBIOBDBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal bool BBICPIIMEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly string PDIDAJEODFC;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xEB4170", Offset = "0xEB2B70", VA = "0x180EB4170")]
	private LDMMBIOBDBN(bool MOCLPPLLHOO, string LDAOBLKAAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0F00", Offset = "0x7EAF900", VA = "0x187EB0F00")]
	public static LDMMBIOBDBN FMDOFBCLPJB(string LDAOBLKAAHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0F70", Offset = "0x7EAF970", VA = "0x187EB0F70")]
	public PEKFMABJKON GBICALGHAOO()
	{
		return default(PEKFMABJKON);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct PEKFMABJKON : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LDMMBIOBDBN ADKDGLJBLJH;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
	internal PEKFMABJKON(LDMMBIOBDBN GJIMIGJJJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7EB19E0", Offset = "0x7EB03E0", VA = "0x187EB19E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class PGCBMANNDHK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class KPEIMJIHPNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KPEIMJIHPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x51F15D0", Offset = "0x51EFFD0", VA = "0x1851F15D0")]
		internal int PGBFNJFNKOE(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private HashSet<T>? NHBKCOMEJCK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyCollection<T> HOAPPGFANMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x57611A0", Offset = "0x575FBA0", VA = "0x1857611A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LHCFBCPMIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x547D060", Offset = "0x547BA60", VA = "0x18547D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA16630", Offset = "0xA15030", VA = "0x180A16630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x57611D0", Offset = "0x575FBD0", VA = "0x1857611D0")]
	public bool PBDMKLNODMP(T BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5761090", Offset = "0x575FA90", VA = "0x185761090")]
	public bool DAAFLACHELB(T BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5761320", Offset = "0x575FD20", VA = "0x185761320")]
	public bool PFLPBNAMPLH(T BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5761010", Offset = "0x575FA10", VA = "0x185761010")]
	public void BLIDLECNKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5761360", Offset = "0x575FD60", VA = "0x185761360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public PGCBMANNDHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class MJPGDJKBEEA
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class DNKDMBJMJDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public DNKDMBJMJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7EAFFF0", Offset = "0x7EAE9F0", VA = "0x187EAFFF0")]
		internal int PGBFNJFNKOE(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<object>? NHBKCOMEJCK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyCollection<object> HOAPPGFANMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7EB12A0", Offset = "0x7EAFCA0", VA = "0x187EB12A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool LHCFBCPMIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1290", Offset = "0x7EAFC90", VA = "0x187EB1290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA16630", Offset = "0xA15030", VA = "0x180A16630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1330", Offset = "0x7EAFD30", VA = "0x187EB1330")]
	public bool PBDMKLNODMP(object BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7EB11F0", Offset = "0x7EAFBF0", VA = "0x187EB11F0")]
	public bool DAAFLACHELB(object BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1410", Offset = "0x7EAFE10", VA = "0x187EB1410")]
	public bool PFLPBNAMPLH(object BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1180", Offset = "0x7EAFB80", VA = "0x187EB1180")]
	public void BLIDLECNKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB1470", Offset = "0x7EAFE70", VA = "0x187EB1470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public MJPGDJKBEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class NIGIGJLAPAC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private struct PDBPLCGFNOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float INCMCCHBPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public T AMCECKEAKLL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, PDBPLCGFNOD> FHONBPKKLIE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public virtual T LDCOIDNBEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1146780", Offset = "0x1145180", VA = "0x181146780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1ABBCC0", Offset = "0x1ABA6C0", VA = "0x181ABBCC0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public object? CEEBOHIEMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EHCPOOFICLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4BA3AC0", Offset = "0x4BA24C0", VA = "0x184BA3AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5507970", Offset = "0x5506370", VA = "0x185507970")]
	public bool GOOFDNOKNFF(T PCDAHJCDHHF, object BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4B31C90", Offset = "0x4B30690", VA = "0x184B31C90")]
	public bool JLGGFHOHDHO(object BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4300", Offset = "0x4BA2D00", VA = "0x184BA4300")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5505DC0", Offset = "0x55047C0", VA = "0x185505DC0")]
	public bool EHEIJGNBGFA(object BECBHDDLOHA, [Out] T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5506160", Offset = "0x5504B60", VA = "0x185506160")]
	[FOCICBLMCCE("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FIFIFOIPDKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4B320D0", Offset = "0x4B30AD0", VA = "0x184B320D0")]
	public NIGIGJLAPAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class AACKCAKFOFI : MGFEKHFOJDF<EPPGEGDDHJJ>
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	internal class KCKJFPPAOKM : IEqualityComparer<EPPGEGDDHJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		internal static readonly KCKJFPPAOKM FDCAMNOGINK;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0CE0", Offset = "0x7EAF6E0", VA = "0x187EB0CE0", Slot = "4")]
		public bool Equals(EPPGEGDDHJJ CBPCNABIALH, EPPGEGDDHJJ CBOHEKOGGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6FDA620", Offset = "0x6FD9020", VA = "0x186FDA620", Slot = "5")]
		public int GetHashCode(EPPGEGDDHJJ OJDHMKOBKLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KCKJFPPAOKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE620", Offset = "0x7EAD020", VA = "0x187EAE620")]
	public AACKCAKFOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE570", Offset = "0x7EACF70", VA = "0x187EAE570", Slot = "4")]
	public override bool PBDMKLNODMP(EPPGEGDDHJJ BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE430", Offset = "0x7EACE30", VA = "0x187EAE430", Slot = "5")]
	public override bool DAAFLACHELB(EPPGEGDDHJJ BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7EAE4E0", Offset = "0x7EACEE0", VA = "0x187EAE4E0")]
	private static void NBADKOPHLOC(EPPGEGDDHJJ BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA71700", Offset = "0xA70100", VA = "0x180A71700", Slot = "6")]
	protected override string TokenToString(EPPGEGDDHJJ BECBHDDLOHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class EPPGEGDDHJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly string CDPCBOLAGAF;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public EPPGEGDDHJJ(string CDPCBOLAGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0100", Offset = "0x7EAEB00", VA = "0x187EB0100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public abstract class MGFEKHFOJDF<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IEqualityComparer<T> CHDLIFCANLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HashSet<T>? NHBKCOMEJCK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public IReadOnlyCollection<T> HOAPPGFANMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x547D090", Offset = "0x547BA90", VA = "0x18547D090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LHCFBCPMIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x547D060", Offset = "0x547BA60", VA = "0x18547D060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA58560", Offset = "0xA56F60", VA = "0x180A58560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x547D9D0", Offset = "0x547C3D0", VA = "0x18547D9D0")]
	public MGFEKHFOJDF(IEqualityComparer<T> CHDLIFCANLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x547D220", Offset = "0x547BC20", VA = "0x18547D220", Slot = "4")]
	public virtual bool PBDMKLNODMP(T BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x547CF50", Offset = "0x547B950", VA = "0x18547CF50", Slot = "5")]
	public virtual bool DAAFLACHELB(T BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x547CDC0", Offset = "0x547B7C0", VA = "0x18547CDC0")]
	public void BLIDLECNKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string TokenToString(T BECBHDDLOHA);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x547D650", Offset = "0x547C050", VA = "0x18547D650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public sealed class LGNNFODMHBB<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<WeakReference<T>>? NHBKCOMEJCK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LHCFBCPMIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5288BB0", Offset = "0x52875B0", VA = "0x185288BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5288910", Offset = "0x5287310", VA = "0x185288910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5288CA0", Offset = "0x52876A0", VA = "0x185288CA0")]
	public void PBDMKLNODMP(T BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5288A70", Offset = "0x5287470", VA = "0x185288A70")]
	public void DAAFLACHELB(T BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5288A50", Offset = "0x5287450", VA = "0x185288A50")]
	public void BLIDLECNKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5288EA0", Offset = "0x52878A0", VA = "0x185288EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public LGNNFODMHBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class LLFAENNCDND
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3B21FD0", Offset = "0x3B209D0", VA = "0x183B21FD0")]
	public static void LHCPPDPHBMJ<T>(this List<T> IBKFNAMHILN, int MNFHMLCLFEB) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FPNCFKGEPAI<T> where T : notnull, IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct NBINFJPACGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float INCMCCHBPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T AMCECKEAKLL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<EPPGEGDDHJJ, NBINFJPACGD> FHONBPKKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EqualityComparer<T> LOJPPCHOGKG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public virtual T LDCOIDNBEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA10D60", Offset = "0xA0F760", VA = "0x180A10D60", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private EPPGEGDDHJJ? CEEBOHIEMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool EHCPOOFICLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4BA3AC0", Offset = "0x4BA24C0", VA = "0x184BA3AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4220", Offset = "0x4BA2C20", VA = "0x184BA4220")]
	public bool GOOFDNOKNFF(T PCDAHJCDHHF, EPPGEGDDHJJ BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4B31C90", Offset = "0x4B30690", VA = "0x184B31C90")]
	public bool JLGGFHOHDHO(EPPGEGDDHJJ BECBHDDLOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4300", Offset = "0x4BA2D00", VA = "0x184BA4300")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3B00", Offset = "0x4BA2500", VA = "0x184BA3B00")]
	public bool EHEIJGNBGFA(EPPGEGDDHJJ BECBHDDLOHA, [Out] T PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3BE0", Offset = "0x4BA25E0", VA = "0x184BA3BE0")]
	[FOCICBLMCCE("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool FIFIFOIPDKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4BA4330", Offset = "0x4BA2D30", VA = "0x184BA4330")]
	public FPNCFKGEPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class CCOHPKDFAKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<object, float> FHONBPKKLIE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float KINBJCCIFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA66550", Offset = "0xA64F50", VA = "0x180A66550")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x128CEE0", Offset = "0x128B8E0", VA = "0x18128CEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF960", Offset = "0x7EAE360", VA = "0x187EAF960")]
	public void GOOFDNOKNFF(float PCDAHJCDHHF, object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF9D0", Offset = "0x7EAE3D0", VA = "0x187EAF9D0")]
	public void JLGGFHOHDHO(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFB70", Offset = "0x7EAE570", VA = "0x187EAFB70")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFA40", Offset = "0x7EAE440", VA = "0x187EAFA40")]
	private void KHCHAMEBJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7EAFBC0", Offset = "0x7EAE5C0", VA = "0x187EAFBC0")]
	public CCOHPKDFAKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LGPLOLBMAEK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event KANDEFNDKGP NFNEIEHDMJK;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class BMDFAIOFFAL : LGPLOLBMAEK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct HLPIJGFAIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float OAPJNMIFIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly float EKDNODFNLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal readonly bool HBILGBNKLDB;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float HMADEMCLCIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7EB08D0", Offset = "0x7EAF2D0", VA = "0x187EB08D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7EB0A50", Offset = "0x7EAF450", VA = "0x187EB0A50")]
		public HLPIJGFAIHK(float HKECPJKDGLJ, float EMHKONLCKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7EB08E0", Offset = "0x7EAF2E0", VA = "0x187EB08E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class AIFOAFEDDPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BMDFAIOFFAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public AIFOAFEDDPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7EAE6D0", Offset = "0x7EAD0D0", VA = "0x187EAE6D0")]
		internal void FEIMPMLGKDI(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int OOPBDBFKCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int LNHGFAGJGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly LGPLOLBMAEK[] IACOMEJMNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly KANDEFNDKGP[] FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly HLPIJGFAIHK[] GKDOPJEIPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private HLPIJGFAIHK HPDBINDLMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly NEKLIGKEFGE PIBCAKDBNKI;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event KANDEFNDKGP NFNEIEHDMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF140", Offset = "0x7EADB40", VA = "0x187EAF140", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7EAF290", Offset = "0x7EADC90", VA = "0x187EAF290", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF7D0", Offset = "0x7EAE1D0", VA = "0x187EAF7D0")]
	public BMDFAIOFFAL(int OOPBDBFKCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF200", Offset = "0x7EADC00", VA = "0x187EAF200")]
	public NEKLIGKEFGE FLKBKHDINGB(HLPIJGFAIHK GMBPOMFEMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF350", Offset = "0x7EADD50", VA = "0x187EAF350")]
	public void OMMEGLKFMKB(LGPLOLBMAEK FFNGOOHDFFC, [Optional] HLPIJGFAIHK DIDPIHMJOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7EAF030", Offset = "0x7EADA30", VA = "0x187EAF030", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate void KANDEFNDKGP(float NCHGAFOGNCM);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class INLMCCCCNJL
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class LEMEGLJJHDL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly LGPLOLBMAEK IBJFBGHFOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly KANDEFNDKGP DMDJELFGCKJ;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1080", Offset = "0x7EAFA80", VA = "0x187EB1080")]
		public LEMEGLJJHDL(LGPLOLBMAEK IBJFBGHFOAJ, KANDEFNDKGP DMDJELFGCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1030", Offset = "0x7EAFA30", VA = "0x187EB1030", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0BB0", Offset = "0x7EAF5B0", VA = "0x187EB0BB0")]
	internal static bool ELGJFMFGMPL(float MJGADEGDMOP, float LJDEEJKPAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7E9DC50", Offset = "0x7E9C650", VA = "0x187E9DC50")]
	internal static float NFLKIMEKPMG(float MJGADEGDMOP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0C20", Offset = "0x7EAF620", VA = "0x187EB0C20")]
	public static IDisposable PCFBIIFPJFD(this LGPLOLBMAEK IBJFBGHFOAJ, KANDEFNDKGP DMDJELFGCKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NEKLIGKEFGE : LGPLOLBMAEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float NCHGAFOGNCM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float BFKGEMMGJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1620", Offset = "0x7EB0020", VA = "0x187EB1620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event KANDEFNDKGP? NFNEIEHDMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB1710", Offset = "0x7EB0110", VA = "0x187EB1710", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB17B0", Offset = "0x7EB01B0", VA = "0x187EB17B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public NEKLIGKEFGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface KCELDFCNLPN<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKHBOCLLMKO<T> LPOPHENMMHM([Out] T PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPMJEFEEPDP();
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class OFNJMAONNMM<T> : KCELDFCNLPN<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ConcurrentStack<T> DEECDPHEDJM;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x565C910", Offset = "0x565B310", VA = "0x18565C910", Slot = "4")]
	public DKHBOCLLMKO<T> LPOPHENMMHM([Out] T PCDAHJCDHHF)
	{
		return default(DKHBOCLLMKO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x565C830", Offset = "0x565B230", VA = "0x18565C830")]
	public void DKAGEAADPDL(T HLNDADLKJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x52904A0", Offset = "0x528EEA0", VA = "0x1852904A0", Slot = "5")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
	protected virtual void OCIIBIOICAK(T GKJHJBEHIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x565C890", Offset = "0x565B290", VA = "0x18565C890")]
	private T IBPMNADNGOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x565C9A0", Offset = "0x565B3A0", VA = "0x18565C9A0")]
	public OFNJMAONNMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public readonly struct DKHBOCLLMKO<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly T HLNDADLKJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OFNJMAONNMM<T> EDCLKKJAJPG;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
	internal DKHBOCLLMKO(T PCDAHJCDHHF, OFNJMAONNMM<T> EDCLKKJAJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6AFCD20", Offset = "0x6AFB720", VA = "0x186AFCD20", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KLOOHDNJFOM : OFNJMAONNMM<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly KLOOHDNJFOM FDCAMNOGINK;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0D70", Offset = "0x7EAF770", VA = "0x187EB0D70")]
	public static DKHBOCLLMKO<StringBuilder> IBPMNADNGOO([Out] StringBuilder PCDAHJCDHHF)
	{
		return default(DKHBOCLLMKO<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0E10", Offset = "0x7EAF810", VA = "0x187EB0E10", Slot = "6")]
	protected override void OCIIBIOICAK(StringBuilder GKJHJBEHIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0EC0", Offset = "0x7EAF8C0", VA = "0x187EB0EC0")]
	public KLOOHDNJFOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class DFNOEMNBDCE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x77385F0", Offset = "0x7736FF0", VA = "0x1877385F0")]
	public DFNOEMNBDCE(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class JGEAMHLEDFI<TKey, TValue> : HNCCLIDNIEO<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, FDLFDFMJMAH where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class GHGKLOLHHGI : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public JGEAMHLEDFI<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x1146780", Offset = "0x1145180", VA = "0x181146780", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x4BD3C90", Offset = "0x4BD2690", VA = "0x184BD3C90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public GHGKLOLHHGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4BD3CE0", Offset = "0x4BD26E0", VA = "0x184BD3CE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4C4DF80", Offset = "0x4C4C980", VA = "0x184C4DF80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4C4DEE0", Offset = "0x4C4C8E0", VA = "0x184C4DEE0")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4C4EBF0", Offset = "0x4C4D5F0", VA = "0x184C4EBF0")]
		private void NODCBNAELMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4C4ECE0", Offset = "0x4C4D6E0", VA = "0x184C4ECE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly HNCCLIDNIEO<TKey, TValue> MFEONLIGBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IDictionary<TKey, TValue> GINCBALONLG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5093CE0", Offset = "0x50926E0", VA = "0x185093CE0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HDMPHDAENOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public TValue OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5093F70", Offset = "0x5092970", VA = "0x185093F70", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x50941B0", Offset = "0x5092BB0", VA = "0x1850941B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public ICollection<TKey> DFDJBNMBJHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5093FB0", Offset = "0x50929B0", VA = "0x185093FB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICollection<TValue> GMPKHGAGCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x50940B0", Offset = "0x5092AB0", VA = "0x1850940B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5093C30", Offset = "0x5092630", VA = "0x185093C30")]
	public JGEAMHLEDFI(HNCCLIDNIEO<TKey, TValue> MFEONLIGBDD, [Optional] IDictionary<TKey, TValue>? GINCBALONLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x50919C0", Offset = "0x50903C0", VA = "0x1850919C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5092690", Offset = "0x5091090", VA = "0x185092690")]
	public void ILLAIFPPACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x50912C0", Offset = "0x508FCC0", VA = "0x1850912C0", Slot = "9")]
	public void Add(TKey KJNEHANBOBO, TValue PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5091830", Offset = "0x5090230", VA = "0x185091830")]
	public void BCDOLDNHMDM(TKey KJNEHANBOBO, TValue PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x50921F0", Offset = "0x5090BF0", VA = "0x1850921F0")]
	public void EJBLHDHGOAI(TKey KJNEHANBOBO, TValue PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5092810", Offset = "0x5091210", VA = "0x185092810")]
	public void KCONDEHIJDE(TKey KJNEHANBOBO, TValue PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5092570", Offset = "0x5090F70", VA = "0x185092570")]
	public void HJLIPKNHOHE(TKey KJNEHANBOBO, TValue PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x50932A0", Offset = "0x5091CA0", VA = "0x1850932A0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5093470", Offset = "0x5091E70", VA = "0x185093470", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x50937D0", Offset = "0x50921D0", VA = "0x1850937D0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5091A30", Offset = "0x5090430", VA = "0x185091A30", Slot = "8")]
	public bool ContainsKey(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5092F60", Offset = "0x5091960", VA = "0x185092F60")]
	public bool PGNHCKCMCPE(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5091200", Offset = "0x508FC00", VA = "0x185091200")]
	public bool AKNKHNHIKDD(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5093020", Offset = "0x5091A20", VA = "0x185093020", Slot = "10")]
	public bool Remove(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5093A90", Offset = "0x5092490", VA = "0x185093A90", Slot = "11")]
	public bool TryGetValue(TKey KJNEHANBOBO, [Out] TValue PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5091D90", Offset = "0x5090790", VA = "0x185091D90", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] KLDOGKPLNJA, int KFFMGEMIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5093990", Offset = "0x5092390", VA = "0x185093990", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x50924E0", Offset = "0x5090EE0", VA = "0x1850924E0", Slot = "19")]
	[IteratorStateMachine(typeof(JGEAMHLEDFI<, >.GHGKLOLHHGI))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5092B80", Offset = "0x5091580", VA = "0x185092B80", Slot = "21")]
	public bool NCBLMCJBMMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5092C70", Offset = "0x5091670", VA = "0x185092C70")]
	private TValue NNMOMMDNMDN(TKey KJNEHANBOBO)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface KONFDKPGEPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string AOBKHHFNBDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface FDLFDFMJMAH
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCBLMCJBMMB();
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface HNCCLIDNIEO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FDLFDFMJMAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public sealed class NLGJDJPALEH<TKey, TVal> : HNCCLIDNIEO<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FDLFDFMJMAH where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate int KOHABHNCCCD(TKey KJNEHANBOBO, TVal PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate void MOJOJGCIOHN(TKey KJNEHANBOBO, TVal PCDAHJCDHHF, GCBIKMLIFAK CHGJGNFMEJJ);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class JMEFPGFMAKH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public TKey PKHCDEJLLNL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xDCB0C0", Offset = "0xDC9AC0", VA = "0x180DCB0C0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public TVal AMCECKEAKLL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA58560", Offset = "0xA56F60", VA = "0x180A58560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int HMADEMCLCIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA6EB80", Offset = "0xA6D580", VA = "0x180A6EB80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xF69880", Offset = "0xF68280", VA = "0x180F69880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public DateTimeOffset NMBCENBLOLE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x12D5200", Offset = "0x12D3C00", VA = "0x1812D5200")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x13D8F60", Offset = "0x13D7960", VA = "0x1813D8F60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x50ABDE0", Offset = "0x50AA7E0", VA = "0x1850ABDE0")]
		public JMEFPGFMAKH(TKey KJNEHANBOBO, TVal KPILPFEAJHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class DABHIEGFHLB : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public NLGJDJPALEH<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private LinkedList<JMEFPGFMAKH>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x1146780", Offset = "0x1145180", VA = "0x181146780", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x6AD1C80", Offset = "0x6AD0680", VA = "0x186AD1C80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public DABHIEGFHLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4BCEAF0", Offset = "0x4BCD4F0", VA = "0x184BCEAF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6AD0F40", Offset = "0x6ACF940", VA = "0x186AD0F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6ACF330", Offset = "0x6ACDD30", VA = "0x186ACF330")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6AD1BE0", Offset = "0x6AD05E0", VA = "0x186AD1BE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public const int EDJFHMMOAJO = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly Dictionary<TKey, LinkedListNode<JMEFPGFMAKH>> INHDEMIOOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly LinkedList<JMEFPGFMAKH> DOAOLEBKNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly KOHABHNCCCD? BDCFLFNNFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly TimeSpan DDGBFOJJJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly MOJOJGCIOHN? KKICOAKCIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly FBMKJPBIMJP GNNDGNCJDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool PNHPOAPGJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly List<TKey> CAFLNEALBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly List<TVal> LCCJHBHIFAF;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int NJBAMFMNNHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xC82E30", Offset = "0xC81830", VA = "0x180C82E30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	internal int JHKJFGICCMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xDC95C0", Offset = "0xDC7FC0", VA = "0x180DC95C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xF01250", Offset = "0xEFFC50", VA = "0x180F01250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x551ADA0", Offset = "0x55197A0", VA = "0x18551ADA0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	internal int GIILCLLACNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4C8CEF0", Offset = "0x4C8B8F0", VA = "0x184C8CEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public ICollection<TVal> GMPKHGAGCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x551AE30", Offset = "0x5519830", VA = "0x18551AE30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ICollection<TKey> IDictionary<TKey, TVal>.JNPNIPHJAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x551A660", Offset = "0x5519060", VA = "0x18551A660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool HDMPHDAENOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public TVal OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x551ADF0", Offset = "0x55197F0", VA = "0x18551ADF0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x551AE60", Offset = "0x5519860", VA = "0x18551AE60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5518DB0", Offset = "0x55177B0", VA = "0x185518DB0")]
	private bool DBIGILHIAAA(int OOPBDBFKCBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5519720", Offset = "0x5518120", VA = "0x185519720")]
	private void KIKAMLEAONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x551A8F0", Offset = "0x55192F0", VA = "0x18551A8F0")]
	public NLGJDJPALEH(int OOPBDBFKCBI, [Optional] KOHABHNCCCD? BDCFLFNNFEC, [Optional] IEqualityComparer<TKey>? MOGHEIPOEOH, [Optional] MOJOJGCIOHN? KKICOAKCIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x551A850", Offset = "0x5519250", VA = "0x18551A850")]
	public NLGJDJPALEH(TimeSpan DDGBFOJJJEK, [Optional] IEqualityComparer<TKey>? MOGHEIPOEOH, [Optional] MOJOJGCIOHN? KKICOAKCIDN, [Optional] FBMKJPBIMJP? GNNDGNCJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x551A8A0", Offset = "0x55192A0", VA = "0x18551A8A0")]
	public NLGJDJPALEH(int OOPBDBFKCBI, TimeSpan DDGBFOJJJEK, [Optional] IEqualityComparer<TKey>? MOGHEIPOEOH, [Optional] MOJOJGCIOHN? KKICOAKCIDN, [Optional] FBMKJPBIMJP? GNNDGNCJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x551A9B0", Offset = "0x55193B0", VA = "0x18551A9B0")]
	public NLGJDJPALEH(int OOPBDBFKCBI, KOHABHNCCCD? BDCFLFNNFEC, TimeSpan DDGBFOJJJEK, [Optional] IEqualityComparer<TKey>? MOGHEIPOEOH, [Optional] MOJOJGCIOHN? KKICOAKCIDN, [Optional] FBMKJPBIMJP? GNNDGNCJDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5519B10", Offset = "0x5518510", VA = "0x185519B10", Slot = "21")]
	public bool NCBLMCJBMMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x55187A0", Offset = "0x55171A0", VA = "0x1855187A0", Slot = "22")]
	public bool BMGPENKAJCE(int OPKPFANIILK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5519D70", Offset = "0x5518770", VA = "0x185519D70")]
	private bool OBEDJCGJONF(int OPKPFANIILK, GCBIKMLIFAK CHGJGNFMEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5518E00", Offset = "0x5517800", VA = "0x185518E00")]
	public void DGDFODDEBEH(TKey KJNEHANBOBO, TVal PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5518630", Offset = "0x5517030", VA = "0x185518630", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HMJJODPHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5518660", Offset = "0x5517060", VA = "0x185518660", Slot = "9")]
	public void Add(TKey KJNEHANBOBO, TVal PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5518A30", Offset = "0x5517430", VA = "0x185518A30", Slot = "8")]
	public bool ContainsKey(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x551A470", Offset = "0x5518E70", VA = "0x18551A470", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x551A3A0", Offset = "0x5518DA0", VA = "0x18551A3A0", Slot = "10")]
	public bool Remove(TKey KJNEHANBOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x551A530", Offset = "0x5518F30", VA = "0x18551A530", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> HMJJODPHKCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5519B70", Offset = "0x5518570", VA = "0x185519B70")]
	private bool NPEPDGMNLIL(TKey KJNEHANBOBO, [Out] TVal PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5519200", Offset = "0x5517C00", VA = "0x185519200")]
	private TVal IBPMNADNGOO(TKey HFGGEJCIMIJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x551A6C0", Offset = "0x55190C0", VA = "0x18551A6C0", Slot = "11")]
	public bool TryGetValue(TKey HFGGEJCIMIJ, [Out] TVal PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5518990", Offset = "0x5517390", VA = "0x185518990", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5518A80", Offset = "0x5517480", VA = "0x185518A80", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KLDOGKPLNJA, int KFFMGEMIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x551A270", Offset = "0x5518C70", VA = "0x18551A270")]
	private void OOOBGBNBNCB(TKey KJNEHANBOBO, TVal KPILPFEAJHA, GCBIKMLIFAK CHGJGNFMEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5518830", Offset = "0x5517230", VA = "0x185518830")]
	private bool CHLFEKIIJKL(JMEFPGFMAKH EMICBPKMDNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x55192F0", Offset = "0x5517CF0", VA = "0x1855192F0")]
	private void JOGBMGFHOEP(LinkedListNode<JMEFPGFMAKH> EDIELEFNCLP, TVal OIEALMJHDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5518EE0", Offset = "0x55178E0", VA = "0x185518EE0")]
	private void GOOFDNOKNFF(TKey KJNEHANBOBO, TVal PCDAHJCDHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5518400", Offset = "0x5516E00", VA = "0x185518400")]
	private void ADENBFHHINL(JMEFPGFMAKH EMICBPKMDNM, TVal OIEALMJHDLB, int FPOEBBHABIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5519170", Offset = "0x5517B70", VA = "0x185519170", Slot = "19")]
	[IteratorStateMachine(typeof(NLGJDJPALEH<, >.DABHIEGFHLB))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x551A690", Offset = "0x5519090", VA = "0x18551A690", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum GCBIKMLIFAK : byte
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
public class CHEKBCMNHOC<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly TKey LDBNLEIHMID;

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6586A50", Offset = "0x6585450", VA = "0x186586A50")]
	public CHEKBCMNHOC(TKey FIENNPFIFNL, Exception ANDPNKJGGKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MGIJFAFECLI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F6C600", Offset = "0x6F6B000", VA = "0x186F6C600")]
	public MGIJFAFECLI(string IJOJGNJMCGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class DDNEPEFALOO<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class NIBLGBFHNGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public DDNEPEFALOO<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NIBLGBFHNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5505AA0", Offset = "0x55044A0", VA = "0x185505AA0")]
		internal Task<TResource> AHNNEBICOHA(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct NFJCJOEHPJD : IAsyncStateMachine
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
		public DDNEPEFALOO<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x54FFC60", Offset = "0x54FE660", VA = "0x1854FFC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5500820", Offset = "0x54FF220", VA = "0x185500820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct OKLFIKEKEGN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5679140", Offset = "0x5677B40", VA = "0x185679140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5679820", Offset = "0x5678220", VA = "0x185679820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly CDDEMKNAAOK<TId, Task<TResource>> FGJMDLPPCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> GBOPFDBJDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? ELIGLCEKCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TResource>? BJAKOPNMFCO;

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6AEA120", Offset = "0x6AE8B20", VA = "0x186AEA120")]
	public DDNEPEFALOO(int MJKAOEIBCPE = 0, [Optional] IEqualityComparer<TId>? EFCMIHAOPOI, [Optional] Func<TId, CancellationToken, Task<TResource>>? DAJHLFINBGA, [Optional] Action<TResource>? CJIHCJMKNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8FF0", Offset = "0x6AE79F0", VA = "0x186AE8FF0")]
	public BBBOLEBKOCP<Task<TResource>> LIIJGAECNHF(TId KHNIMGKFPOO, [Optional] Func<TId, CancellationToken, Task<TResource>>? DAJHLFINBGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9D60", Offset = "0x6AE8760", VA = "0x186AE9D60")]
	private void PBKNHAODEBA(Task<TResource> HAAEKADIBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8BA0", Offset = "0x6AE75A0", VA = "0x186AE8BA0")]
	[AsyncStateMachine(typeof(DDNEPEFALOO<, >.NFJCJOEHPJD))]
	private Task CKPFMHNGCJB(Task<TResource> HAAEKADIBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9670", Offset = "0x6AE8070", VA = "0x186AE9670")]
	public void NBOCJIHKCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8F80", Offset = "0x6AE7980", VA = "0x186AE8F80")]
	public CDDEMKNAAOK<TId, Task<TResource>>.GAPLCGGCIMC ICNPOCIJNJG()
	{
		return default(CDDEMKNAAOK<TId, Task<TResource>>.GAPLCGGCIMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9F60", Offset = "0x6AE8960", VA = "0x186AE9F60", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9F60", Offset = "0x6AE8960", VA = "0x186AE9F60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9A30", Offset = "0x6AE8430", VA = "0x186AE9A30")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DDNEPEFALOO<, >.OKLFIKEKEGN))]
	internal static Task PAGGOGDBLPP(Task<TResource> HAAEKADIBMM, CancellationTokenSource LCAAPFCGOMH, Dictionary<Task<TResource>, CancellationTokenSource> OENPPKCNIBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class CDDEMKNAAOK<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private sealed class FKGLMJKOEEM : IEquatable<FKGLMJKOEEM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly TValue AMCECKEAKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int GLLLBEILHDB;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x122B680", Offset = "0x122A080", VA = "0x18122B680")]
		public FKGLMJKOEEM(TValue PCDAHJCDHHF, int DECJLGANKGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x4B4E220", Offset = "0x4B4CC20", VA = "0x184B4E220", Slot = "4")]
		public bool Equals(FKGLMJKOEEM? NDNHELJMDCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4B4E190", Offset = "0x4B4CB90", VA = "0x184B4E190", Slot = "0")]
		public override bool Equals(object? OJDHMKOBKLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4B4E420", Offset = "0x4B4CE20", VA = "0x184B4E420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public struct GAPLCGGCIMC : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private Dictionary<TKey, FKGLMJKOEEM>.Enumerator OJMKBGEJMOK;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x4C30830", Offset = "0x4C2F230", VA = "0x184C30830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public (TKey Key, TValue Value, int RefCount) NBBAKIJBGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x4C30C60", Offset = "0x4C2F660", VA = "0x184C30C60", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4C30A20", Offset = "0x4C2F420", VA = "0x184C30A20")]
		public GAPLCGGCIMC(CDDEMKNAAOK<TKey, TValue> FHONBPKKLIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4C30490", Offset = "0x4C2EE90", VA = "0x184C30490", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4C30510", Offset = "0x4C2EF10", VA = "0x184C30510", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x4C30790", Offset = "0x4C2F190", VA = "0x184C30790", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class KCIPEDMHKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public CDDEMKNAAOK<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public FKGLMJKOEEM refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public KCIPEDMHKHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x51AF590", Offset = "0x51ADF90", VA = "0x1851AF590")]
		internal void AHNNEBICOHA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Dictionary<TKey, FKGLMJKOEEM> AEDOPOIKNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Func<TKey, TValue>? IKGOKFPDEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TValue>? PKDLMIAJHDA;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x64BDA70", Offset = "0x64BC470", VA = "0x1864BDA70")]
	public CDDEMKNAAOK(int MJKAOEIBCPE = 0, [Optional] IEqualityComparer<TKey>? MOGHEIPOEOH, [Optional] Func<TKey, TValue>? NPLBGCEANJP, [Optional] Action<TValue>? MGMJOCKLCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x64BD050", Offset = "0x64BBA50", VA = "0x1864BD050")]
	public BBBOLEBKOCP<TValue> LIIJGAECNHF(TKey KJNEHANBOBO, [Optional] Func<TKey, TValue>? CBFBANHHMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x64BC590", Offset = "0x64BAF90", VA = "0x1864BC590")]
	private void DKAGEAADPDL(TKey KJNEHANBOBO, FKGLMJKOEEM GFMPMGPLFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x64BD300", Offset = "0x64BBD00", VA = "0x1864BD300")]
	public void NBOCJIHKCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x64BC7C0", Offset = "0x64BB1C0", VA = "0x1864BC7C0")]
	public GAPLCGGCIMC ICNPOCIJNJG()
	{
		return default(GAPLCGGCIMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x64BD9E0", Offset = "0x64BC3E0", VA = "0x1864BD9E0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x64BD9E0", Offset = "0x64BC3E0", VA = "0x1864BD9E0", Slot = "5")]
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
