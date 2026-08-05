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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EC2510", Offset = "0x6EC1910", VA = "0x186EC2510")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ECODMEBOHDM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	protected ECODMEBOHDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class EACJGHLAODK<T> : ECODMEBOHDM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct LAONKIOJOIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum HIIPBIJCJHD
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
		public HIIPBIJCJHD LGJDMOCCBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T MDOOJHKFGMP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int PKOMLKICNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool DDCOCBHFPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool GDLMCMPOHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? LOGJGOMGIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<LAONKIOJOIH>? IAKAEHPJKKH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MCAGHOLNAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3B18080", Offset = "0x3B17480", VA = "0x183B18080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B18830", Offset = "0x3B17C30", VA = "0x183B18830")]
	protected EACJGHLAODK(bool GDLMCMPOHMI, bool DDCOCBHFPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B180F0", Offset = "0x3B174F0", VA = "0x183B180F0")]
	protected bool KEKNAICJNMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3B17D90", Offset = "0x3B17190", VA = "0x183B17D90")]
	protected void AGJBAGKENNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3B18370", Offset = "0x3B17770", VA = "0x183B18370")]
	protected void MFHIJMDCNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F1E370", Offset = "0x2F1D770", VA = "0x182F1E370")]
	private static void KPHHPIICGKI<U>(List<U>? HGMKHDHJCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3B18610", Offset = "0x3B17A10", VA = "0x183B18610", Slot = "4")]
	public void PJLPMKJIOFF(T MDOOJHKFGMP, bool CKDHLDJCCJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3B18190", Offset = "0x3B17590", VA = "0x183B18190", Slot = "5")]
	public void MAHJHHAHNPL(T MDOOJHKFGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3B17EC0", Offset = "0x3B172C0", VA = "0x183B17EC0")]
	public void FLFDAJFNFLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LKILNMKOKHH : EACJGHLAODK<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC24B0", Offset = "0x6EC18B0", VA = "0x186EC24B0")]
	public LKILNMKOKHH(bool GDLMCMPOHMI = false, bool DDCOCBHFPCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EC22B0", Offset = "0x6EC16B0", VA = "0x186EC22B0")]
	public void JNFLGGLMFJH()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EC21F0", Offset = "0x6EC15F0", VA = "0x186EC21F0")]
	public static LKILNMKOKHH HNEMGPDCNIA(LKILNMKOKHH HICIBLJOEFD, Action MDOOJHKFGMP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2250", Offset = "0x6EC1650", VA = "0x186EC2250")]
	public static LKILNMKOKHH IIHGEALBPLC(LKILNMKOKHH HICIBLJOEFD, Action MDOOJHKFGMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EHPGPCCPJAD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJLPMKJIOFF(Action<T> MDOOJHKFGMP, bool CKDHLDJCCJN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHJHHAHNPL(Action<T> MDOOJHKFGMP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class JEIAMONHOFF<T> : EACJGHLAODK<Action<T>>, EHPGPCCPJAD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5C00", Offset = "0x3EE5000", VA = "0x183EE5C00")]
	public JEIAMONHOFF(bool GDLMCMPOHMI = false, bool DDCOCBHFPCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x44239B0", Offset = "0x4422DB0", VA = "0x1844239B0")]
	public void JNFLGGLMFJH(T HIKBGGAGLAA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4F60", Offset = "0x3EE4360", VA = "0x183EE4F60")]
	public static JEIAMONHOFF<T> HNEMGPDCNIA(JEIAMONHOFF<T> HICIBLJOEFD, Action<T> MDOOJHKFGMP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5010", Offset = "0x3EE4410", VA = "0x183EE5010")]
	public static JEIAMONHOFF<T> IIHGEALBPLC(JEIAMONHOFF<T> HICIBLJOEFD, Action<T> MDOOJHKFGMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LNEDBDAGCND<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class GFIOHNKJPFA<T, U> : EACJGHLAODK<Action<T, U>>, LNEDBDAGCND<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5C00", Offset = "0x3EE5000", VA = "0x183EE5C00")]
	public GFIOHNKJPFA(bool GDLMCMPOHMI = false, bool DDCOCBHFPCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3FDE880", Offset = "0x3FDDC80", VA = "0x183FDE880")]
	public void JNFLGGLMFJH(T HIKBGGAGLAA, U JLPPICDFEJF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4F60", Offset = "0x3EE4360", VA = "0x183EE4F60")]
	public static GFIOHNKJPFA<T, U> HNEMGPDCNIA(GFIOHNKJPFA<T, U> HICIBLJOEFD, Action<T, U> MDOOJHKFGMP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5010", Offset = "0x3EE4410", VA = "0x183EE5010")]
	public static GFIOHNKJPFA<T, U> IIHGEALBPLC(GFIOHNKJPFA<T, U> HICIBLJOEFD, Action<T, U> MDOOJHKFGMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FEIOHBLDMOM<T, U, V> : EACJGHLAODK<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5C00", Offset = "0x3EE5000", VA = "0x183EE5C00")]
	public FEIOHBLDMOM(bool GDLMCMPOHMI = false, bool DDCOCBHFPCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5500", Offset = "0x3EF4900", VA = "0x183EF5500")]
	public void JNFLGGLMFJH(T HIKBGGAGLAA, U JLPPICDFEJF, V IDIHIILANOF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4F60", Offset = "0x3EE4360", VA = "0x183EE4F60")]
	public static FEIOHBLDMOM<T, U, V> HNEMGPDCNIA(FEIOHBLDMOM<T, U, V> HICIBLJOEFD, Action<T, U, V> MDOOJHKFGMP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5010", Offset = "0x3EE4410", VA = "0x183EE5010")]
	public static FEIOHBLDMOM<T, U, V> IIHGEALBPLC(FEIOHBLDMOM<T, U, V> HICIBLJOEFD, Action<T, U, V> MDOOJHKFGMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DHIMALELCEE<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class NLGMKKDOJOI<T, U, V, W> : EACJGHLAODK<Action<T, U, V, W>>, DHIMALELCEE<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5C00", Offset = "0x3EE5000", VA = "0x183EE5C00")]
	public NLGMKKDOJOI(bool GDLMCMPOHMI = false, bool DDCOCBHFPCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x48D32A0", Offset = "0x48D26A0", VA = "0x1848D32A0")]
	public void JNFLGGLMFJH(T HIKBGGAGLAA, U JLPPICDFEJF, V IDIHIILANOF, W AFOFNIJDOHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4F60", Offset = "0x3EE4360", VA = "0x183EE4F60")]
	public static NLGMKKDOJOI<T, U, V, W> HNEMGPDCNIA(NLGMKKDOJOI<T, U, V, W> HICIBLJOEFD, Action<T, U, V, W> MDOOJHKFGMP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5010", Offset = "0x3EE4410", VA = "0x183EE5010")]
	public static NLGMKKDOJOI<T, U, V, W> IIHGEALBPLC(NLGMKKDOJOI<T, U, V, W> HICIBLJOEFD, Action<T, U, V, W> MDOOJHKFGMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class ALGKHEBLIOE<T, U, V, W, X> : EACJGHLAODK<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5C00", Offset = "0x3EE5000", VA = "0x183EE5C00")]
	public ALGKHEBLIOE(bool GDLMCMPOHMI = false, bool DDCOCBHFPCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x402DE30", Offset = "0x402D230", VA = "0x18402DE30")]
	public void JNFLGGLMFJH(T HIKBGGAGLAA, U JLPPICDFEJF, V IDIHIILANOF, W AFOFNIJDOHO, X CFANGCOBGCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4F60", Offset = "0x3EE4360", VA = "0x183EE4F60")]
	public static ALGKHEBLIOE<T, U, V, W, X> HNEMGPDCNIA(ALGKHEBLIOE<T, U, V, W, X> HICIBLJOEFD, Action<T, U, V, W, X> MDOOJHKFGMP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5010", Offset = "0x3EE4410", VA = "0x183EE5010")]
	public static ALGKHEBLIOE<T, U, V, W, X> IIHGEALBPLC(ALGKHEBLIOE<T, U, V, W, X> HICIBLJOEFD, Action<T, U, V, W, X> MDOOJHKFGMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class FABMMNDIDFM<T, U, V, W, X, Y> : EACJGHLAODK<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5C00", Offset = "0x3EE5000", VA = "0x183EE5C00")]
	public FABMMNDIDFM(bool GDLMCMPOHMI = false, bool DDCOCBHFPCB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3EE50B0", Offset = "0x3EE44B0", VA = "0x183EE50B0")]
	public void JNFLGGLMFJH(T HIKBGGAGLAA, U JLPPICDFEJF, V IDIHIILANOF, W AFOFNIJDOHO, X CFANGCOBGCF, Y HHLCHNICLGA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EE4F60", Offset = "0x3EE4360", VA = "0x183EE4F60")]
	public static FABMMNDIDFM<T, U, V, W, X, Y> HNEMGPDCNIA(FABMMNDIDFM<T, U, V, W, X, Y> HICIBLJOEFD, Action<T, U, V, W, X, Y> MDOOJHKFGMP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5010", Offset = "0x3EE4410", VA = "0x183EE5010")]
	public static FABMMNDIDFM<T, U, V, W, X, Y> IIHGEALBPLC(FABMMNDIDFM<T, U, V, W, X, Y> HICIBLJOEFD, Action<T, U, V, W, X, Y> MDOOJHKFGMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CFMFJBPEHOF<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IODPKOFCJPG<TKey, TVal> BOAPKCFBCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> JEINLMLMANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IODPKOFCJPG<TKey, TVal>.GILDKGLMFJM? NHJKFKEOLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int PLBHLGOEOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly IODPKOFCJPG<TKey, TVal>.KJIMHPHPAGD? OEBMELFBPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int PPACGEJHMLJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int GMMOAKIKDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x53187E0", Offset = "0x5317BE0", VA = "0x1853187E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OGMNDHJBABK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC60", Offset = "0x8AE060", VA = "0x1808AEC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5318840", Offset = "0x5317C40", VA = "0x185318840")]
	public CFMFJBPEHOF(int PLBHLGOEOLO, [Optional] IODPKOFCJPG<TKey, TVal>.KJIMHPHPAGD? OEBMELFBPMP, [Optional] IEqualityComparer<TKey>? POGJGFCGKMP, [Optional] IODPKOFCJPG<TKey, TVal>.GILDKGLMFJM? NHJKFKEOLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5317710", Offset = "0x5316B10", VA = "0x185317710")]
	public void CNNFOGGLKIM(TKey GMJINMLEEAC, TVal LIHHDPOHLDK, bool FNBBFCJCGOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x53175A0", Offset = "0x53169A0", VA = "0x1853175A0")]
	public bool CHMJFAFOPDP(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5317960", Offset = "0x5316D60", VA = "0x185317960")]
	public bool FDPJDJCOJAH(TKey PBCLNIAADPK, [Out] TVal LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5317B10", Offset = "0x5316F10", VA = "0x185317B10")]
	private void FNODLPAJKAN(TKey GMJINMLEEAC, TVal LIHHDPOHLDK, int MFKKELONDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5318390", Offset = "0x5317790", VA = "0x185318390")]
	public bool HLEIKNJDNAM(TKey GMJINMLEEAC, TVal LIHHDPOHLDK, bool FNBBFCJCGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5317A60", Offset = "0x5316E60", VA = "0x185317A60")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5317DF0", Offset = "0x53171F0", VA = "0x185317DF0")]
	private void HHMLEKOAEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5318560", Offset = "0x5317960", VA = "0x185318560")]
	private bool ICGIIEKOMLP(TKey GMJINMLEEAC, IPAIEEIALLN POKPBEJPBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5317470", Offset = "0x5316870", VA = "0x185317470")]
	private void ABCPOKNOMND(TKey GMJINMLEEAC, TVal LIHHDPOHLDK, IPAIEEIALLN POKPBEJPBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x53186B0", Offset = "0x5317AB0", VA = "0x1853186B0")]
	private void IMNIJHOJIPD(TKey GMJINMLEEAC, TVal HMBPNLCBEEJ, IPAIEEIALLN POKPBEJPBMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KFELCCKDMLO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action MHJMIOGFFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PHOLBOHJECE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public KFELCCKDMLO(Action FEMGHJNBLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1490", Offset = "0x6EC0890", VA = "0x186EC1490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDC10", Offset = "0x2BED010", VA = "0x182BEDC10")]
	public static CCELPPEDKLE<T> LIDOGEGODKP<T>(T LIHHDPOHLDK, Action FEMGHJNBLNC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CCELPPEDKLE<T> : KFELCCKDMLO where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T JKEIFELLNME
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5305880", Offset = "0x5304C80", VA = "0x185305880")]
	public CCELPPEDKLE(T LIHHDPOHLDK, Action FEMGHJNBLNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class CGAOAIABPMF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly EPDCNBPAMIJ<T>? NFBOMDGFACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> MKOHOHIMHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool PHOLBOHJECE;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CGAOAIABPMF<T> NHLFLGLAPGF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> PICMAIOLHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x531A830", Offset = "0x5319C30", VA = "0x18531A830")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long AKNNAFCACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x531A8B0", Offset = "0x5319CB0", VA = "0x18531A8B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KGFOOIOHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x531A570", Offset = "0x5319970", VA = "0x18531A570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x531AB80", Offset = "0x5319F80", VA = "0x18531AB80")]
	public CGAOAIABPMF(EPDCNBPAMIJ<T> OCMOPCPCHIE, EPDCNBPAMIJ<T> KPFNFAGCMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x531B100", Offset = "0x531A500", VA = "0x18531B100")]
	public CGAOAIABPMF(EPDCNBPAMIJ<T> OCMOPCPCHIE, int IHLILPEDKCL, EPDCNBPAMIJ<T> KPFNFAGCMPH, int EKBMPDBILAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x531AC80", Offset = "0x531A080", VA = "0x18531AC80")]
	private CGAOAIABPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x531A2F0", Offset = "0x53196F0", VA = "0x18531A2F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x531A630", Offset = "0x5319A30", VA = "0x18531A630")]
	public T[] KDAGEAEPDAP()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x531A380", Offset = "0x5319780", VA = "0x18531A380")]
	public static ReadOnlySequence<T> ICFKEBCLOFF(CGAOAIABPMF<T>? CIALNDLMFDM)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct ALFOLKGPCLL : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct KGAGMBLNBPE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
		public static KGAGMBLNBPE AALKPJMFIHM()
		{
			return default(KGAGMBLNBPE);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3574D60", Offset = "0x3574160", VA = "0x183574D60")]
	public static string? BJDOCHEIKBK<T>([Optional] string? PLDHGOMOCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3574DE0", Offset = "0x35741E0", VA = "0x183574DE0")]
	public static string? LADLFAIMPAI<T>([Optional] string? LCINDDIGIDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
	public static ALFOLKGPCLL JJFGKJCEFJO(string PLDHGOMOCDA, string? LCINDDIGIDM)
	{
		return default(ALFOLKGPCLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LDCIFMJMAPN
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool LNBBNDNEAEJ(string DBHFFJDHMCM, LDCIFMJMAPN IOJIABGPMON);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ODJBDDLCICM<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ODJBDDLCICM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4A5B240", Offset = "0x4A5A640", VA = "0x184A5B240")]
		internal void MHKIGJOHMGB(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int CCLPDLLIEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string OIKFCIAHIPC;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1E40", Offset = "0x6EC1240", VA = "0x186EC1E40")]
	public static Dictionary<string, LDCIFMJMAPN> PNHFPAIFNHB(Type PPKDMHECOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2F0D0E0", Offset = "0x2F0C4E0", VA = "0x182F0D0E0")]
	public static Dictionary<string, LDCIFMJMAPN> PNHFPAIFNHB<T>(Type PPKDMHECOJN, IReadOnlyDictionary<T, string> MDHFOMKNGFJ) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F0C960", Offset = "0x2F0BD60", VA = "0x182F0C960")]
	public static Dictionary<string, LDCIFMJMAPN> NDIICACPFPL<T>(List<T> APBBLAJJDMD) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EC18C0", Offset = "0x6EC0CC0", VA = "0x186EC18C0")]
	public static Dictionary<string, LDCIFMJMAPN> ACEENCJBKJK(Type PPKDMHECOJN, LNBBNDNEAEJ FEPIHJAKIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1C80", Offset = "0x6EC1080", VA = "0x186EC1C80")]
	public static Dictionary<int, string> PHDCINAPECD(Dictionary<string, LDCIFMJMAPN> PPIMIKDHEBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class IDBHBLPOJHF : JPHFAKFKMJL
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool MKEEKBIAEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? PFJMJPEAIOG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual JPHFAKFKMJL? CHLAGEGCGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EC13D0", Offset = "0x6EC07D0", VA = "0x186EC13D0")]
	protected IDBHBLPOJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KIGPPELGDEG();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0E30", Offset = "0x6EC0230", VA = "0x186EC0E30", Slot = "8")]
	public virtual string IEBIMMFKOHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1130", Offset = "0x6EC0530", VA = "0x186EC1130", Slot = "9")]
	public void OPMNHHDPGGA(StringBuilder LFFEENAGBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0DD0", Offset = "0x6EC01D0", VA = "0x186EC0DD0", Slot = "10")]
	public void CDLNPDODLID(StringBuilder LFFEENAGBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1010", Offset = "0x6EC0410", VA = "0x186EC1010", Slot = "11")]
	public void JHLNEOODCMA(StringBuilder LFFEENAGBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0EB0", Offset = "0x6EC02B0", VA = "0x186EC0EB0", Slot = "12")]
	public void JEJFEDMNIGE(StringBuilder LFFEENAGBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0D30", Offset = "0x6EC0130", VA = "0x186EC0D30")]
	public static void BAHPEKPBMIL(StringBuilder LFFEENAGBIF, string KKCDLFBGBIP, string NCEFLOELJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60651B0", Offset = "0x60645B0", VA = "0x1860651B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DGKEKLPFFKK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0840", Offset = "0x6EBFC40", VA = "0x186EC0840")]
	public DGKEKLPFFKK(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KELBIIGIKIH<TErr> : DGKEKLPFFKK where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr FOMKNLOLJAI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x452B1B0", Offset = "0x452A5B0", VA = "0x18452B1B0")]
	private KELBIIGIKIH([In] TErr NLKGINEKMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x452B0D0", Offset = "0x452A4D0", VA = "0x18452B0D0")]
	public static KELBIIGIKIH<TErr> AALKPJMFIHM([In] TErr NLKGINEKMPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PKNJCOHOIDL : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm MMLPEKHPDMJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool EHJGGENMNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool COAKODFKKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool HIJHFDHIGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long AKNNAFCACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6EC2DD0", Offset = "0x6EC21D0", VA = "0x186EC2DD0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long KHBHMHPABCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6EC2E40", Offset = "0x6EC2240", VA = "0x186EC2E40", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6EC2EB0", Offset = "0x6EC22B0", VA = "0x186EC2EB0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2D60", Offset = "0x6EC2160", VA = "0x186EC2D60")]
	public PKNJCOHOIDL(HashAlgorithm MMLPEKHPDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2B90", Offset = "0x6EC1F90", VA = "0x186EC2B90", Slot = "35")]
	public override int Read(byte[] FIJBJOBOOEA, int GMCJIJBLJPF, int MGEMHICLKEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2D30", Offset = "0x6EC2130", VA = "0x186EC2D30", Slot = "38")]
	public override void Write(byte[] FIJBJOBOOEA, int GMCJIJBLJPF, int MGEMHICLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2C30", Offset = "0x6EC2030", VA = "0x186EC2C30", Slot = "33")]
	public override long Seek(long GMCJIJBLJPF, SeekOrigin ONLDCANPGJN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2CC0", Offset = "0x6EC20C0", VA = "0x186EC2CC0", Slot = "34")]
	public override void SetLength(long LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2AC0", Offset = "0x6EC1EC0", VA = "0x186EC2AC0")]
	public byte[] MNDNNEMFDAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JPHFAKFKMJL
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IEBIMMFKOHN();

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KIGPPELGDEG();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface INMOCPMHGNM<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions JKEIFELLNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KGAAEDPLPNC
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string FKGJBGCEMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EPDCNBPAMIJ<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static EPDCNBPAMIJ<T>? BACCLOBBCNO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object NIBAJOGBHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? IKNJEGGAFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool PHOLBOHJECE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool IMHJEBACLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x96BBB0", Offset = "0x96AFB0", VA = "0x18096BBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3B75940", Offset = "0x3B74D40", VA = "0x183B75940")]
	private static EPDCNBPAMIJ<T> BGLDNNPDMNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3B75340", Offset = "0x3B74740", VA = "0x183B75340")]
	private static void ADFMFINIAJL(EPDCNBPAMIJ<T> NJANANONHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3B77180", Offset = "0x3B76580", VA = "0x183B77180")]
	private EPDCNBPAMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3B76900", Offset = "0x3B75D00", VA = "0x183B76900")]
	public static EPDCNBPAMIJ<T> LIDOGEGODKP(ReadOnlyMemory<T> EMNCIELHGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3B76CC0", Offset = "0x3B760C0", VA = "0x183B76CC0")]
	public static EPDCNBPAMIJ<T> LIDOGEGODKP(IMemoryOwner<T> NLIIPCDNHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3B767C0", Offset = "0x3B75BC0", VA = "0x183B767C0")]
	public static void LEHHBPMMKPB(EPDCNBPAMIJ<T> OCMOPCPCHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3B760B0", Offset = "0x3B754B0", VA = "0x183B760B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3B764A0", Offset = "0x3B758A0", VA = "0x183B764A0")]
	public EPDCNBPAMIJ<T> GIEFCFNIIEO(IMemoryOwner<T> NLIIPCDNHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3B765C0", Offset = "0x3B759C0", VA = "0x183B765C0")]
	private void GIOIKOPIGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3B76340", Offset = "0x3B75740", VA = "0x183B76340")]
	private EPDCNBPAMIJ<T> EPCEAGGJEOJ(EPDCNBPAMIJ<T> NJANANONHMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KIHBFBEEOOC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1730", Offset = "0x6EC0B30", VA = "0x186EC1730")]
	public KIHBFBEEOOC(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LIPCDFEDONE<TOk> : KIHBFBEEOOC where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk FDBOOANPLPI;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4611E30", Offset = "0x4611230", VA = "0x184611E30")]
	private LIPCDFEDONE([In] TOk NHHAKCEIKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x41669F0", Offset = "0x4165DF0", VA = "0x1841669F0")]
	public static LIPCDFEDONE<TOk> AALKPJMFIHM([In] TOk NHHAKCEIKFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MLIDCCDLMIE<TOk, TErr> : IEquatable<MLIDCCDLMIE<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> CPIBKCCPDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr FOMKNLOLJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk FDBOOANPLPI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool GDGHBKBJLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x483B350", Offset = "0x483A750", VA = "0x18483B350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HCENEIECPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4838290", Offset = "0x4837690", VA = "0x184838290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4841020", Offset = "0x4840420", VA = "0x184841020")]
	internal MLIDCCDLMIE([In] TErr NLKGINEKMPH, [In] TOk NHHAKCEIKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x483D730", Offset = "0x483CB30", VA = "0x18483D730")]
	public static MLIDCCDLMIE<TOk, TErr> PFGNICHJOBF([In] TErr NLKGINEKMPH)
	{
		return default(MLIDCCDLMIE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x483CF60", Offset = "0x483C360", VA = "0x18483CF60")]
	public static MLIDCCDLMIE<TOk, TErr> NNJFLPOPOAP([In] TOk NHHAKCEIKFB)
	{
		return default(MLIDCCDLMIE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x304D400", Offset = "0x304C800", VA = "0x18304D400")]
	public MLIDCCDLMIE<TOk?, UErr?> FCBGPMHMHMN<UErr>()
	{
		return default(MLIDCCDLMIE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x304ED60", Offset = "0x304E160", VA = "0x18304ED60")]
	public MLIDCCDLMIE<UOk?, TErr?> IKCJKFBGEMC<UOk>()
	{
		return default(MLIDCCDLMIE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x304E2F0", Offset = "0x304D6F0", VA = "0x18304E2F0")]
	public MLIDCCDLMIE<UOk?, TErr?> FGDLDDADHNF<UOk>()
	{
		return default(MLIDCCDLMIE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x304EFA0", Offset = "0x304E3A0", VA = "0x18304EFA0")]
	public MLIDCCDLMIE<TOk?, UErr?> LDPOLOPEGCB<UErr>()
	{
		return default(MLIDCCDLMIE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4839880", Offset = "0x4838C80", VA = "0x184839880")]
	public MLIDCCDLMIE<OKFEIOHLOGM, TErr> FIEPDFLCDCM()
	{
		return default(MLIDCCDLMIE<OKFEIOHLOGM, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4839DD0", Offset = "0x48391D0", VA = "0x184839DD0")]
	public static bool GBDINLJCMBD([In] MLIDCCDLMIE<TOk, TErr> EHOEECMJEAD, [In] MLIDCCDLMIE<TOk, TErr> CPKKNGGFDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x48389D0", Offset = "0x4837DD0", VA = "0x1848389D0", Slot = "4")]
	public bool Equals(MLIDCCDLMIE<TOk, TErr> OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4838830", Offset = "0x4837C30", VA = "0x184838830", Slot = "0")]
	public override bool Equals(object OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x483BA30", Offset = "0x483AE30", VA = "0x18483BA30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x483E8A0", Offset = "0x483DCA0", VA = "0x18483E8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GLGOCLPCPNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct JCIONBAFCFK<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<MLIDCCDLMIE<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<MLIDCCDLMIE<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x44180C0", Offset = "0x44174C0", VA = "0x1844180C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4418740", Offset = "0x4417B40", VA = "0x184418740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C430", Offset = "0x2E6B830", VA = "0x182E6C430")]
	public static MLIDCCDLMIE<TOk?, TErr?> FDBOOANPLPI<TOk, TErr>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [In] TOk NHHAKCEIKFB)
	{
		return default(MLIDCCDLMIE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C4F0", Offset = "0x2E6B8F0", VA = "0x182E6C4F0")]
	public static MLIDCCDLMIE<OKFEIOHLOGM, TErr?> FDBOOANPLPI<TErr>([In] this MLIDCCDLMIE<OKFEIOHLOGM, TErr> MBGHIKEGJAA)
	{
		return default(MLIDCCDLMIE<OKFEIOHLOGM, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C430", Offset = "0x2E6B830", VA = "0x182E6C430")]
	public static MLIDCCDLMIE<TOk?, TErr?> FOMKNLOLJAI<TOk, TErr>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [In] TErr NLKGINEKMPH)
	{
		return default(MLIDCCDLMIE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2E6BFA0", Offset = "0x2E6B3A0", VA = "0x182E6BFA0")]
	public static TOk? FAHAPNEJIFD<TOk, TErr>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2E6CDD0", Offset = "0x2E6C1D0", VA = "0x182E6CDD0")]
	[AsyncStateMachine(typeof(JCIONBAFCFK<, >))]
	public static Task<TOk?>? MPDJPGGFEAE<TOk, TErr>(this Task<MLIDCCDLMIE<TOk, TErr>> MBGHIKEGJAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A3C0", Offset = "0x2E697C0", VA = "0x182E6A3C0")]
	public static TErr? AHFPKDPKCMK<TErr, TOk>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A680", Offset = "0x2E69A80", VA = "0x182E6A680")]
	public static bool APPAIBLOLEG<TOk, TErr, UErr, UOk>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [Out] MLIDCCDLMIE<UOk, UErr> MGEEFBEIAOI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2E6CCE0", Offset = "0x2E6C0E0", VA = "0x182E6CCE0")]
	public static bool JACPGEPCHBA<TOk, TErr>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [Out][NotNullWhen(true)] TOk NHHAKCEIKFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2E6B860", Offset = "0x2E6AC60", VA = "0x182E6B860")]
	public static bool CCHJEIBPBNK<TOk, TErr>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [Out][NotNullWhen(true)] TErr NLKGINEKMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2E6CB60", Offset = "0x2E6BF60", VA = "0x182E6CB60")]
	public static bool HAKBKMLNEPG<TOk, TErr>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [Out][NotNullWhen(true)] TOk NHHAKCEIKFB, [Out][NotNullWhen(false)] TErr NLKGINEKMPH) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2E6CBE0", Offset = "0x2E6BFE0", VA = "0x182E6CBE0")]
	public static bool HCBGGICMCPH<TOk, TErr>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [Out][NotNullWhen(true)] TOk NHHAKCEIKFB, [Out] MLIDCCDLMIE<TOk, TErr> MGEEFBEIAOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E6A7B0", Offset = "0x2E69BB0", VA = "0x182E6A7B0")]
	public static bool APPAIBLOLEG<TOk, TErr, UErr, UOk>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [Out][NotNullWhen(true)] TOk NHHAKCEIKFB, [Out] MLIDCCDLMIE<UOk, UErr> MGEEFBEIAOI) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E6BA80", Offset = "0x2E6AE80", VA = "0x182E6BA80")]
	public static bool EIADAGAPAPI<TOk, TErr>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [Out][NotNullWhen(true)] TOk NHHAKCEIKFB, [Out] MLIDCCDLMIE<OKFEIOHLOGM, TErr> MGEEFBEIAOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E6D1C0", Offset = "0x2E6C5C0", VA = "0x182E6D1C0")]
	public static MLIDCCDLMIE<UOk, UErr> OFFNDOCOFNN<UOk, UErr, TOk, TErr>([In] this MLIDCCDLMIE<TOk, TErr> MBGHIKEGJAA, [In] MLIDCCDLMIE<UOk, UErr> PAHNKMKPPCD) where TOk : UOk where TErr : UErr
	{
		return default(MLIDCCDLMIE<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2E6C650", Offset = "0x2E6BA50", VA = "0x182E6C650")]
	public static MLIDCCDLMIE<TOk?[]?, TErr?> FLMJGKGMPMB<TOk, TErr>(this IEnumerable<MLIDCCDLMIE<TOk, TErr>> MBGHIKEGJAA)
	{
		return default(MLIDCCDLMIE<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class EJHKGINCACP<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F20030", Offset = "0x2F1F430", VA = "0x182F20030")]
	public static MLIDCCDLMIE<TOk, T> FDBOOANPLPI<TOk>([In] TOk NHHAKCEIKFB) where TOk : notnull
	{
		return default(MLIDCCDLMIE<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3B36000", Offset = "0x3B35400", VA = "0x183B36000")]
	public static MLIDCCDLMIE<OKFEIOHLOGM, T> FDBOOANPLPI()
	{
		return default(MLIDCCDLMIE<OKFEIOHLOGM, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2F20030", Offset = "0x2F1F430", VA = "0x182F20030")]
	public static MLIDCCDLMIE<T, TErr> FOMKNLOLJAI<TErr>([In] TErr NLKGINEKMPH) where TErr : notnull
	{
		return default(MLIDCCDLMIE<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct KNAFCGEDIAM<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly GBDKPILPCEM OAAOKPDEFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> KIBEGAAJFCL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x45425C0", Offset = "0x45419C0", VA = "0x1845425C0")]
	public static KNAFCGEDIAM<TKey, TValue> AALKPJMFIHM(string JCPOMHNJOIE)
	{
		return default(KNAFCGEDIAM<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x45427A0", Offset = "0x4541BA0", VA = "0x1845427A0")]
	internal KNAFCGEDIAM(Dictionary<TKey, TValue> LIHHDPOHLDK, GBDKPILPCEM FGJDHEELDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x45426F0", Offset = "0x4541AF0", VA = "0x1845426F0")]
	public FCKIOLCJFPB<TKey, TValue> BOOELHJACHF([Out] Dictionary<TKey, TValue> LIHHDPOHLDK)
	{
		return default(FCKIOLCJFPB<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct FCKIOLCJFPB<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> KIBEGAAJFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly ODJNIHDCEPN MGKGPEFFCCD;

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x23E46F0", Offset = "0x23E3AF0", VA = "0x1823E46F0")]
	internal FCKIOLCJFPB(Dictionary<TKey, TValue> LIHHDPOHLDK, ODJNIHDCEPN HFJFLJCDBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB180", Offset = "0x3EEA580", VA = "0x183EEB180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct KJKNBMHFLNJ<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly GBDKPILPCEM OAAOKPDEFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> KIBEGAAJFCL;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x45425C0", Offset = "0x45419C0", VA = "0x1845425C0")]
	public static KJKNBMHFLNJ<T> AALKPJMFIHM(string JCPOMHNJOIE)
	{
		return default(KJKNBMHFLNJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x45427A0", Offset = "0x4541BA0", VA = "0x1845427A0")]
	internal KJKNBMHFLNJ(HashSet<T> LIHHDPOHLDK, GBDKPILPCEM FGJDHEELDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x45426F0", Offset = "0x4541AF0", VA = "0x1845426F0")]
	public DGGKJCHJAGN<T> BOOELHJACHF([Out] HashSet<T> LIHHDPOHLDK)
	{
		return default(DGGKJCHJAGN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct DGGKJCHJAGN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> KIBEGAAJFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ODJNIHDCEPN MGKGPEFFCCD;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x23E46F0", Offset = "0x23E3AF0", VA = "0x1823E46F0")]
	internal DGGKJCHJAGN(HashSet<T> LIHHDPOHLDK, ODJNIHDCEPN HFJFLJCDBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB180", Offset = "0x3EEA580", VA = "0x183EEB180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct NEJACOBFLHP<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GBDKPILPCEM OAAOKPDEFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> KIBEGAAJFCL;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x45425C0", Offset = "0x45419C0", VA = "0x1845425C0")]
	public static NEJACOBFLHP<T> AALKPJMFIHM(string JCPOMHNJOIE)
	{
		return default(NEJACOBFLHP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x45427A0", Offset = "0x4541BA0", VA = "0x1845427A0")]
	internal NEJACOBFLHP(Stack<T> LIHHDPOHLDK, GBDKPILPCEM FGJDHEELDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x45426F0", Offset = "0x4541AF0", VA = "0x1845426F0")]
	public DELLOHKFMLG<T> BOOELHJACHF([Out] Stack<T> LIHHDPOHLDK)
	{
		return default(DELLOHKFMLG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DELLOHKFMLG<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> KIBEGAAJFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly ODJNIHDCEPN MGKGPEFFCCD;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x23E46F0", Offset = "0x23E3AF0", VA = "0x1823E46F0")]
	internal DELLOHKFMLG(Stack<T> LIHHDPOHLDK, ODJNIHDCEPN HFJFLJCDBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3EEB180", Offset = "0x3EEA580", VA = "0x183EEB180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class IDGNMDLNIIO<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct EHPBDMNMFPL : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly IDGNMDLNIIO<T> KECJEOHFKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int LOJACCKFOGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool CHKOJPOBJGB;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x211B300", Offset = "0x211A700", VA = "0x18211B300")]
		public EHPBDMNMFPL(IDGNMDLNIIO<T> GDIPKBJJCBL, int MPLOBDHCJDA, bool OHHIMLNAENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3B33710", Offset = "0x3B32B10", VA = "0x183B33710")]
		public IDGNMDLNIIO<T>.BPFJIMJDPGE MKNNDFMGFGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3B33810", Offset = "0x3B32C10", VA = "0x183B33810", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B33810", Offset = "0x3B32C10", VA = "0x183B33810", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class BPFJIMJDPGE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly IDGNMDLNIIO<T> KECJEOHFKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int EIONIJJAIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int JKEDFKLHOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool CHKOJPOBJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool MKLHPHPLLMG;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5286AC0", Offset = "0x5285EC0", VA = "0x185286AC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5286C50", Offset = "0x5286050", VA = "0x185286C50", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x5286DD0", Offset = "0x52861D0", VA = "0x185286DD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x52872C0", Offset = "0x52866C0", VA = "0x1852872C0")]
		public BPFJIMJDPGE(IDGNMDLNIIO<T> GDIPKBJJCBL, int MPLOBDHCJDA, bool OHHIMLNAENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5286B40", Offset = "0x5285F40", VA = "0x185286B40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5286BE0", Offset = "0x5285FE0", VA = "0x185286BE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class JEDIACDOJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JEDIACDOJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4420BB0", Offset = "0x441FFB0", VA = "0x184420BB0")]
		internal T LCKJGALHHIK(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] JOCFJALNHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int JKEDFKLHOCP;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int OLLGAGNFNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x41D52E0", Offset = "0x41D46E0", VA = "0x1841D52E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T BLKMEFCLAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3EE1FD0", Offset = "0x3EE13D0", VA = "0x183EE1FD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T HFOIJEAEKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x41D5340", Offset = "0x41D4740", VA = "0x1841D5340")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x41D54F0", Offset = "0x41D48F0", VA = "0x1841D54F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int AKNNAFCACJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E11130", Offset = "0x1E10530", VA = "0x181E11130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x14A86A0", Offset = "0x14A7AA0", VA = "0x1814A86A0")]
	private static int MIKNCIKMOOO(int AEAHMAMPNLO, int IDHDBIDGMFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x41D56E0", Offset = "0x41D4AE0", VA = "0x1841D56E0")]
	public IDGNMDLNIIO(int MFKKELONDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x41D5770", Offset = "0x41D4B70", VA = "0x1841D5770")]
	public IDGNMDLNIIO(int MFKKELONDCC, Func<T> LICPAHGFKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x41D5A80", Offset = "0x41D4E80", VA = "0x1841D5A80")]
	public IDGNMDLNIIO(T[] AAKOLIDMFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x41D56B0", Offset = "0x41D4AB0", VA = "0x1841D56B0")]
	public void OLJKCCHNANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x41D5380", Offset = "0x41D4780", VA = "0x1841D5380")]
	public IEnumerable<T> JCKLELGHAJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x41D5450", Offset = "0x41D4850", VA = "0x1841D5450")]
	public IDGNMDLNIIO<T>.BPFJIMJDPGE MKNNDFMGFGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3EF3D50", Offset = "0x3EF3150", VA = "0x183EF3D50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3EF3D50", Offset = "0x3EF3150", VA = "0x183EF3D50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class MFIFIPOILGL
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F5FC90", Offset = "0x2F5F090", VA = "0x182F5FC90")]
	public static IDGNMDLNIIO<T> AALKPJMFIHM<T>(int MFKKELONDCC, Func<T> LICPAHGFKLF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class DBNAEIHMJLO<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct EKOOJOBJNGC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly DBNAEIHMJLO<T> NAGFCBCAHNF;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T JKEIFELLNME
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x3B415D0", Offset = "0x3B409D0", VA = "0x183B415D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3B415A0", Offset = "0x3B409A0", VA = "0x183B415A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
		public EKOOJOBJNGC(DBNAEIHMJLO<T> NAGFCBCAHNF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct IEEPKGFIGBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<EKOOJOBJNGC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public DBNAEIHMJLO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x41D8A70", Offset = "0x41D7E70", VA = "0x1841D8A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB0E0", Offset = "0x3EEA4E0", VA = "0x183EEB0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim HBJCOPEDJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T EHFHDBPLLGN;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5BF34D0", Offset = "0x5BF28D0", VA = "0x185BF34D0")]
	public DBNAEIHMJLO([In] T EHFHDBPLLGN, int EBHIHOIGPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5BF36C0", Offset = "0x5BF2AC0", VA = "0x185BF36C0")]
	public DBNAEIHMJLO([In] T EHFHDBPLLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2F90", Offset = "0x5BF2390", VA = "0x185BF2F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5BF3490", Offset = "0x5BF2890", VA = "0x185BF3490")]
	public EKOOJOBJNGC IIAIFPMKBCM()
	{
		return default(EKOOJOBJNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2FD0", Offset = "0x5BF23D0", VA = "0x185BF2FD0")]
	[AsyncStateMachine(typeof(DBNAEIHMJLO<>.IEEPKGFIGBB))]
	public Task<DBNAEIHMJLO<T>.EKOOJOBJNGC> EKKMNFPJGKI(CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2F70", Offset = "0x5BF2370", VA = "0x185BF2F70")]
	public void CCFAFMPPKAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class FKJODLLLHEE
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6EC08A0", Offset = "0x6EBFCA0", VA = "0x186EC08A0")]
	public static DBNAEIHMJLO<OKFEIOHLOGM> AALKPJMFIHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2E503D0", Offset = "0x2E4F7D0", VA = "0x182E503D0")]
	public static DBNAEIHMJLO<T> AALKPJMFIHM<T>([In] T EHFHDBPLLGN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BBIDDMGLKJF<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct FOLBFKEPECN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly BBIDDMGLKJF<T> NBDPBLJNJGD;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T JKEIFELLNME
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x3F39FA0", Offset = "0x3F393A0", VA = "0x183F39FA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F39D60", Offset = "0x3F39160", VA = "0x183F39D60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
		internal FOLBFKEPECN(BBIDDMGLKJF<T> NAGFCBCAHNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct DPLIIADHDEM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly BBIDDMGLKJF<T> NBDPBLJNJGD;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T JKEIFELLNME
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x3F39FA0", Offset = "0x3F393A0", VA = "0x183F39FA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5CA63D0", Offset = "0x5CA57D0", VA = "0x185CA63D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
		internal DPLIIADHDEM(BBIDDMGLKJF<T> NAGFCBCAHNF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct DIJDIBAHNEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<DPLIIADHDEM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public BBIDDMGLKJF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private DBNAEIHMJLO<OKFEIOHLOGM>.EKOOJOBJNGC <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<DBNAEIHMJLO<OKFEIOHLOGM>.EKOOJOBJNGC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5C30830", Offset = "0x5C2FC30", VA = "0x185C30830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB0E0", Offset = "0x3EEA4E0", VA = "0x183EEB0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly DBNAEIHMJLO<int> AMLJHDOLCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly DBNAEIHMJLO<OKFEIOHLOGM> HBFNCEADLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly DBNAEIHMJLO<OKFEIOHLOGM> GKOEKFKJOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T CHNBFPNODAH;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x525B3E0", Offset = "0x525A7E0", VA = "0x18525B3E0")]
	internal BBIDDMGLKJF(DBNAEIHMJLO<int> LNOMPBECKGD, DBNAEIHMJLO<OKFEIOHLOGM> BGDDODNEJIC, DBNAEIHMJLO<OKFEIOHLOGM> FHPLHDHMDHI, [In] T EHFHDBPLLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x525A740", Offset = "0x5259B40", VA = "0x18525A740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x525AB40", Offset = "0x5259F40", VA = "0x18525AB40")]
	public FOLBFKEPECN EDHOKJPEEDB()
	{
		return default(FOLBFKEPECN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x525AEE0", Offset = "0x525A2E0", VA = "0x18525AEE0")]
	public DPLIIADHDEM FAEJLNAGKKJ()
	{
		return default(DPLIIADHDEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x525B230", Offset = "0x525A630", VA = "0x18525B230")]
	[AsyncStateMachine(typeof(BBIDDMGLKJF<>.DIJDIBAHNEN))]
	public Task<BBIDDMGLKJF<T>.DPLIIADHDEM> FOJFJHJDIKH(CancellationToken EEHACKMODLA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KGFEEHDCLOF
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6EC14D0", Offset = "0x6EC08D0", VA = "0x186EC14D0")]
	public static BBIDDMGLKJF<OKFEIOHLOGM> AALKPJMFIHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2EFA7B0", Offset = "0x2EF9BB0", VA = "0x182EFA7B0")]
	public static BBIDDMGLKJF<T> AALKPJMFIHM<T>([In] T EHFHDBPLLGN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class LFGPIALNGOL<TData> : IDBHBLPOJHF where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string APMJJEAFGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData BAFNFCIODAA;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
	public override string KIGPPELGDEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x45D7290", Offset = "0x45D6690", VA = "0x1845D7290")]
	internal LFGPIALNGOL(string ADPAIBGIHMB, [In] TData MPMEGOKIEPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class LFHBJLIHIGJ
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2170", Offset = "0x6EC1570", VA = "0x186EC2170")]
	public static LFGPIALNGOL<OKFEIOHLOGM> AALKPJMFIHM(string ADPAIBGIHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDC10", Offset = "0x2BED010", VA = "0x182BEDC10")]
	public static LFGPIALNGOL<TData> AALKPJMFIHM<TData>(string ADPAIBGIHMB, [In] TData MPMEGOKIEPF) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class GBDKPILPCEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool PDIMEAIPJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string CKPPAMJNEKO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x9A0BD0", Offset = "0x99FFD0", VA = "0x1809A0BD0")]
	private GBDKPILPCEM(bool DILOALPJEDB, string BMABEGHMGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0C00", Offset = "0x6EC0000", VA = "0x186EC0C00")]
	public static GBDKPILPCEM AALKPJMFIHM(string BMABEGHMGDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0C70", Offset = "0x6EC0070", VA = "0x186EC0C70")]
	public ODJNIHDCEPN BOOELHJACHF()
	{
		return default(ODJNIHDCEPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct ODJNIHDCEPN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GBDKPILPCEM HPIOHJGDAJI;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x93EE00", Offset = "0x93E200", VA = "0x18093EE00")]
	internal ODJNIHDCEPN(GBDKPILPCEM JCPOMHNJOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2590", Offset = "0x6EC1990", VA = "0x186EC2590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class CPAKANOPJNO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class CDACEENOBIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CDACEENOBIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x53085B0", Offset = "0x53079B0", VA = "0x1853085B0")]
		internal int LJJBDHBIABJ(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? PMOIBKPOKAO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> FADKHFAEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x53E43C0", Offset = "0x53E37C0", VA = "0x1853E43C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool GFNFJEHIFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x53E4400", Offset = "0x53E3800", VA = "0x1853E4400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8AE520", Offset = "0x8AD920", VA = "0x1808AE520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x53E45D0", Offset = "0x53E39D0", VA = "0x1853E45D0")]
	public bool PJLPMKJIOFF(T FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x53E4450", Offset = "0x53E3850", VA = "0x1853E4450")]
	public bool MAHJHHAHNPL(T FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x53E4280", Offset = "0x53E3680", VA = "0x1853E4280")]
	public bool FCCKHINNPHJ(T FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x53E42D0", Offset = "0x53E36D0", VA = "0x1853E42D0")]
	public void KOFKNDMCICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x53E47B0", Offset = "0x53E3BB0", VA = "0x1853E47B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public CPAKANOPJNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class BLJEMJOJOGI
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class PFAHJHPAILJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PFAHJHPAILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6EC2A10", Offset = "0x6EC1E10", VA = "0x186EC2A10")]
		internal int LJJBDHBIABJ(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? PMOIBKPOKAO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> FADKHFAEIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6EBF910", Offset = "0x6EBED10", VA = "0x186EBF910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool GFNFJEHIFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6EBF9A0", Offset = "0x6EBEDA0", VA = "0x186EBF9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8AE520", Offset = "0x8AD920", VA = "0x1808AE520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFA50", Offset = "0x6EBEE50", VA = "0x186EBFA50")]
	public bool PJLPMKJIOFF(object FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF9B0", Offset = "0x6EBEDB0", VA = "0x186EBF9B0")]
	public bool MAHJHHAHNPL(object FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF840", Offset = "0x6EBEC40", VA = "0x186EBF840")]
	public bool FCCKHINNPHJ(object FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF8A0", Offset = "0x6EBECA0", VA = "0x186EBF8A0")]
	public void KOFKNDMCICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFB30", Offset = "0x6EBEF30", VA = "0x186EBFB30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public BLJEMJOJOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class EDLOJEAHDJH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct BFCOMKJLPEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float CCGFCDKJBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T JKEIFELLNME;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, BFCOMKJLPEO> KFEJHMHFKIB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T JDDBBAFOMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1395BB0", Offset = "0x1394FB0", VA = "0x181395BB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x13951A0", Offset = "0x13945A0", VA = "0x1813951A0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? NIECPEDOHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool GJJKPHFHOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3B28140", Offset = "0x3B27540", VA = "0x183B28140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B25BF0", Offset = "0x3B24FF0", VA = "0x183B25BF0")]
	public bool ABPBJIKCHMH(T LIHHDPOHLDK, object FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B26340", Offset = "0x3B25740", VA = "0x183B26340")]
	public bool CKCBFAMPDJB(object FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B26820", Offset = "0x3B25C20", VA = "0x183B26820")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B264A0", Offset = "0x3B258A0", VA = "0x183B264A0")]
	public bool FDPJDJCOJAH(object FDAIGOGAKMH, [Out] T LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3B26880", Offset = "0x3B25C80", VA = "0x183B26880")]
	[JIOMAKBLFNI("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool IODKMNKMHON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3B281A0", Offset = "0x3B275A0", VA = "0x183B281A0")]
	public EDLOJEAHDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class JEGFLDIDKCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly string KEBPAEDPJCC;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public JEGFLDIDKCF(string KEBPAEDPJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1440", Offset = "0x6EC0840", VA = "0x186EC1440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public sealed class MDOHCEHHCAF<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private List<WeakReference<T>>? PMOIBKPOKAO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GFNFJEHIFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4816730", Offset = "0x4815B30", VA = "0x184816730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4816530", Offset = "0x4815930", VA = "0x184816530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4816A10", Offset = "0x4815E10", VA = "0x184816A10")]
	public void PJLPMKJIOFF(T FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4816860", Offset = "0x4815C60", VA = "0x184816860")]
	public void MAHJHHAHNPL(T FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x48166E0", Offset = "0x4815AE0", VA = "0x1848166E0")]
	public void KOFKNDMCICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4816CA0", Offset = "0x48160A0", VA = "0x184816CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public MDOHCEHHCAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class BJEBCPOFPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDFD0", Offset = "0x2BED3D0", VA = "0x182BEDFD0")]
	public static void CAKFPLKKIFP<T>(this List<T> HGMKHDHJCFJ, int AEAHMAMPNLO) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class FPFHLGEIFPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Dictionary<object, float> KFEJHMHFKIB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public float IIPJDPBFIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1B0", Offset = "0xA795B0", VA = "0x180A7A1B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA79C60", Offset = "0xA79060", VA = "0x180A79C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0910", Offset = "0x6EBFD10", VA = "0x186EC0910")]
	public void ABPBJIKCHMH(float LIHHDPOHLDK, object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0980", Offset = "0x6EBFD80", VA = "0x186EC0980")]
	public void CKCBFAMPDJB(object FDAIGOGAKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6EC09F0", Offset = "0x6EBFDF0", VA = "0x186EC09F0")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0A40", Offset = "0x6EBFE40", VA = "0x186EC0A40")]
	private void NBMKPAAAKIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0B70", Offset = "0x6EBFF70", VA = "0x186EC0B70")]
	public FPFHLGEIFPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface HHHHJGPJOOF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event FDKDILPPKAF OFPPPAICECB;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DCJBJJMPFFF : HHHHJGPJOOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public readonly struct PEBNAPENGMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly float IOGIABOPHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly float ABKGAJKKDCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		internal readonly bool OOLCMFGMABL;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float NDEEOPEAONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6EC2730", Offset = "0x6EC1B30", VA = "0x186EC2730")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6EC28B0", Offset = "0x6EC1CB0", VA = "0x186EC28B0")]
		public PEBNAPENGMD(float AKMLIMIBFHO, float LFHCJICMNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6EC2740", Offset = "0x6EC1B40", VA = "0x186EC2740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class OHKOMOAADEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DCJBJJMPFFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OHKOMOAADEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6EC25B0", Offset = "0x6EC19B0", VA = "0x186EC25B0")]
		internal void FBMOBPAKDHC(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int MLLKNBDHHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int FGPBNABIAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HHHHJGPJOOF[] MBINBKOJCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly FDKDILPPKAF[] AJKICPHDFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly PEBNAPENGMD[] EAPMALKHELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private PEBNAPENGMD CMFALAGAMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly CNFGJKAIGBN OGINHFHIMPK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event FDKDILPPKAF OFPPPAICECB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC05F0", Offset = "0x6EBF9F0", VA = "0x186EC05F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6EC0530", Offset = "0x6EBF930", VA = "0x186EC0530", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6EC06B0", Offset = "0x6EBFAB0", VA = "0x186EC06B0")]
	public DCJBJJMPFFF(int MLLKNBDHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6EC04A0", Offset = "0x6EBF8A0", VA = "0x186EC04A0")]
	public CNFGJKAIGBN GGJBCELPAJL(PEBNAPENGMD JBJDGFHGGAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFF10", Offset = "0x6EBF310", VA = "0x186EBFF10")]
	public void DKLGODFANAJ(HHHHJGPJOOF KCJCIEEIMKK, [Optional] PEBNAPENGMD BOJDFHMOOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0390", Offset = "0x6EBF790", VA = "0x186EC0390", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void FDKDILPPKAF(float ONLJCHACJEP);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class KNBJLLCEPOO
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PEBNAAOOCNO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly HHHHJGPJOOF MOAAHANPCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly FDKDILPPKAF BNNBDLHMCLC;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC26A0", Offset = "0x6EC1AA0", VA = "0x186EC26A0")]
		public PEBNAAOOCNO(HHHHJGPJOOF MOAAHANPCJI, FDKDILPPKAF BNNBDLHMCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6EC2650", Offset = "0x6EC1A50", VA = "0x186EC2650", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1850", Offset = "0x6EC0C50", VA = "0x186EC1850")]
	internal static bool GILOLCOODOP(float NOPDIJFELMF, float PMGMHFIMGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0600", Offset = "0x6EAFA00", VA = "0x186EB0600")]
	internal static float LCFJMJFPAJM(float NOPDIJFELMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC1790", Offset = "0x6EC0B90", VA = "0x186EC1790")]
	public static IDisposable CBPMBALGHOO(this HHHHJGPJOOF MOAAHANPCJI, FDKDILPPKAF BNNBDLHMCLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CNFGJKAIGBN : HHHHJGPJOOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private float ONLJCHACJEP;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float KMMJDIDOPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6EBFCE0", Offset = "0x6EBF0E0", VA = "0x186EBFCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event FDKDILPPKAF? OFPPPAICECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6EBFE70", Offset = "0x6EBF270", VA = "0x186EBFE70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6EBFDD0", Offset = "0x6EBF1D0", VA = "0x186EBFDD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public CNFGJKAIGBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface JKIPJICOKBL<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LCPBKOBBENP<T> KGLKHOLMLDN([Out] T LIHHDPOHLDK);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLFDAJFNFLK();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class GPBBBJHINAG<T> : JKIPJICOKBL<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly ConcurrentStack<T> LCOIJNHCGAE;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4025170", Offset = "0x4024570", VA = "0x184025170", Slot = "4")]
	public LCPBKOBBENP<T> KGLKHOLMLDN([Out] T LIHHDPOHLDK)
	{
		return default(LCPBKOBBENP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x4025210", Offset = "0x4024610", VA = "0x184025210")]
	public void PHDJEGBOJIB(T JKOFBABOGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4025060", Offset = "0x4024460", VA = "0x184025060", Slot = "5")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
	protected virtual void ENPFCEEJKEO(T AMENHKILLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x40250C0", Offset = "0x40244C0", VA = "0x1840250C0")]
	private T JEMJOLBMCNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4025290", Offset = "0x4024690", VA = "0x184025290")]
	public GPBBBJHINAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct LCPBKOBBENP<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly T JKOFBABOGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly GPBBBJHINAG<T> GOBLLDAPGMO;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
	internal LCPBKOBBENP(T LIHHDPOHLDK, GPBBBJHINAG<T> GOBLLDAPGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x45D44B0", Offset = "0x45D38B0", VA = "0x1845D44B0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class KGIFKDHHGJO : GPBBBJHINAG<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly KGIFKDHHGJO FKMJLLKHOAH;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6EC15C0", Offset = "0x6EC09C0", VA = "0x186EC15C0")]
	public static LCPBKOBBENP<StringBuilder> JEMJOLBMCNL([Out] StringBuilder LIHHDPOHLDK)
	{
		return default(LCPBKOBBENP<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6EC15A0", Offset = "0x6EC09A0", VA = "0x186EC15A0", Slot = "6")]
	protected override void ENPFCEEJKEO(StringBuilder AMENHKILLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6EC16F0", Offset = "0x6EC0AF0", VA = "0x186EC16F0")]
	public KGIFKDHHGJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class HKNAACGEHKE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x690FB10", Offset = "0x690EF10", VA = "0x18690FB10")]
	public HKNAACGEHKE(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DefaultMember("Item")]
public class GFBEPJGFCFG<TKey, TValue> : BOELPIHIBLN<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, HKILPOMONMD where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class BADDDPBNDDD : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GFBEPJGFCFG<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1395BB0", Offset = "0x1394FB0", VA = "0x181395BB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x52523C0", Offset = "0x52517C0", VA = "0x1852523C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public BADDDPBNDDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2B00", Offset = "0x3DC1F00", VA = "0x183DC2B00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5251DF0", Offset = "0x52511F0", VA = "0x185251DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x52521E0", Offset = "0x52515E0", VA = "0x1852521E0")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x52515D0", Offset = "0x52509D0", VA = "0x1852515D0")]
		private void EMBCDMFMIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x52522D0", Offset = "0x52516D0", VA = "0x1852522D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly BOELPIHIBLN<TKey, TValue> BAMLMPCGLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IDictionary<TKey, TValue> FCMIHOPPMEC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB760", Offset = "0x3FDAB60", VA = "0x183FDB760", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OGEBMIKLHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public TValue CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB900", Offset = "0x3FDAD00", VA = "0x183FDB900", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3FDBC30", Offset = "0x3FDB030", VA = "0x183FDBC30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICollection<TKey> HBJADEMOOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB990", Offset = "0x3FDAD90", VA = "0x183FDB990", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public ICollection<TValue> FMMJAAJNCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3FDBAC0", Offset = "0x3FDAEC0", VA = "0x183FDBAC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB5C0", Offset = "0x3FDA9C0", VA = "0x183FDB5C0")]
	public GFBEPJGFCFG(BOELPIHIBLN<TKey, TValue> BAMLMPCGLJH, [Optional] IDictionary<TKey, TValue>? FCMIHOPPMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8FC0", Offset = "0x3FD83C0", VA = "0x183FD8FC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9B10", Offset = "0x3FD8F10", VA = "0x183FD9B10")]
	public void HNNGGJDPLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8B90", Offset = "0x3FD7F90", VA = "0x183FD8B90", Slot = "9")]
	public void Add(TKey GMJINMLEEAC, TValue LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3FDA6B0", Offset = "0x3FD9AB0", VA = "0x183FDA6B0")]
	public void PBCPHFKKMKL(TKey GMJINMLEEAC, TValue LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3FDA430", Offset = "0x3FD9830", VA = "0x183FDA430")]
	public void NHFNHOKAFFO(TKey GMJINMLEEAC, TValue LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3FDA1F0", Offset = "0x3FD95F0", VA = "0x183FDA1F0")]
	public void KMDCFHOELCN(TKey GMJINMLEEAC, TValue LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8DD0", Offset = "0x3FD81D0", VA = "0x183FD8DD0")]
	public void BCCBDPJELKO(TKey GMJINMLEEAC, TValue LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3FDAB90", Offset = "0x3FD9F90", VA = "0x183FDAB90", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3FDADD0", Offset = "0x3FDA1D0", VA = "0x183FDADD0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> BNDEDHKBDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB130", Offset = "0x3FDA530", VA = "0x183FDB130", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> BNDEDHKBDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9100", Offset = "0x3FD8500", VA = "0x183FD9100", Slot = "8")]
	public bool ContainsKey(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9B60", Offset = "0x3FD8F60", VA = "0x183FD9B60")]
	public bool KAAJOBKOCIL(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8840", Offset = "0x3FD7C40", VA = "0x183FD8840")]
	public bool ADIIBOOCCPJ(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3FDA9F0", Offset = "0x3FD9DF0", VA = "0x183FDA9F0", Slot = "10")]
	public bool Remove(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB410", Offset = "0x3FDA810", VA = "0x183FDB410", Slot = "11")]
	public bool TryGetValue(TKey GMJINMLEEAC, [Out] TValue LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9420", Offset = "0x3FD8820", VA = "0x183FD9420", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] AFBDFGIDJPF, int IFBAABIFFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB2F0", Offset = "0x3FDA6F0", VA = "0x183FDB2F0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9A60", Offset = "0x3FD8E60", VA = "0x183FD9A60", Slot = "19")]
	[IteratorStateMachine(typeof(GFBEPJGFCFG<, >.BADDDPBNDDD))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9960", Offset = "0x3FD8D60", VA = "0x183FD9960", Slot = "21")]
	public bool DBBGGCFGPNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3FD9D90", Offset = "0x3FD9190", VA = "0x183FD9D90")]
	private TValue KHNCIHOEHNA(TKey GMJINMLEEAC)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface HKILPOMONMD
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DBBGGCFGPNJ();
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface BOELPIHIBLN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HKILPOMONMD
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[DefaultMember("Item")]
public sealed class IODPKOFCJPG<TKey, TVal> : BOELPIHIBLN<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, HKILPOMONMD where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate int KJIMHPHPAGD(TKey GMJINMLEEAC, TVal LIHHDPOHLDK);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void GILDKGLMFJM(TKey GMJINMLEEAC, TVal LIHHDPOHLDK, IPAIEEIALLN POKPBEJPBMH);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class LKKJDGBKFBE
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public TKey NDKJAMPIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xACF380", Offset = "0xACE780", VA = "0x180ACF380")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TVal JKEIFELLNME
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x952F70", Offset = "0x952370", VA = "0x180952F70")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA8F190", Offset = "0xA8E590", VA = "0x180A8F190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int NDEEOPEAONL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8EA370", VA = "0x1808EAF70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8EA560", Offset = "0x8E9960", VA = "0x1808EA560")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public DateTimeOffset HJPGPKFHNGG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xF4BA90", Offset = "0xF4AE90", VA = "0x180F4BA90")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x19BBB30", Offset = "0x19BAF30", VA = "0x1819BBB30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4615350", Offset = "0x4614750", VA = "0x184615350")]
		public LKKJDGBKFBE(TKey GMJINMLEEAC, TVal HMBPNLCBEEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class KKFIGMKOIPI : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public IODPKOFCJPG<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private LinkedList<LKKJDGBKFBE>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x1395BB0", Offset = "0x1394FB0", VA = "0x181395BB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x4549510", Offset = "0x4548910", VA = "0x184549510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public KKFIGMKOIPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD6E0", Offset = "0x3DBCAE0", VA = "0x183DBD6E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x45488A0", Offset = "0x4547CA0", VA = "0x1845488A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4549210", Offset = "0x4548610", VA = "0x184549210")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x45494C0", Offset = "0x45488C0", VA = "0x1845494C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int DMBHIANFOIG = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Dictionary<TKey, LinkedListNode<LKKJDGBKFBE>> NILGKMLFELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LinkedList<LKKJDGBKFBE> GKFFOJOEOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly KJIMHPHPAGD? OEBMELFBPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly TimeSpan ACEBAFFEPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly GILDKGLMFJM? NHJKFKEOLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly BDAKMCMKMDO GANKLOIFEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool JKILDMICKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<TKey> JBHANDBPBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly List<TVal> HEGAIELBLCD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OGMNDHJBABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1F0", Offset = "0x8B95F0", VA = "0x1808BA1F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	internal int GMMOAKIKDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9F06C0", Offset = "0x9EFAC0", VA = "0x1809F06C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9EFD60", Offset = "0x9EF160", VA = "0x1809EFD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4228EF0", Offset = "0x42282F0", VA = "0x184228EF0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int AFPACIDBGGI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3B26820", Offset = "0x3B25C20", VA = "0x183B26820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICollection<TVal> FMMJAAJNCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x42290A0", Offset = "0x42284A0", VA = "0x1842290A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ICollection<TKey> IDictionary<TKey, TVal>.GKPJPKMPDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4225D40", Offset = "0x4225140", VA = "0x184225D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool OGEBMIKLHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public TVal CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4229000", Offset = "0x4228400", VA = "0x184229000", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4229150", Offset = "0x4228550", VA = "0x184229150", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4224A70", Offset = "0x4223E70", VA = "0x184224A70")]
	private bool KJMNMGHKFMP(int MLLKNBDHHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x421CDE0", Offset = "0x421C1E0", VA = "0x18421CDE0")]
	private void GCMKLNBCNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x42274F0", Offset = "0x42268F0", VA = "0x1842274F0")]
	public IODPKOFCJPG(int MLLKNBDHHFM, [Optional] KJIMHPHPAGD? OEBMELFBPMP, [Optional] IEqualityComparer<TKey>? POGJGFCGKMP, [Optional] GILDKGLMFJM? NHJKFKEOLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x42272B0", Offset = "0x42266B0", VA = "0x1842272B0")]
	public IODPKOFCJPG(TimeSpan ACEBAFFEPFE, [Optional] IEqualityComparer<TKey>? POGJGFCGKMP, [Optional] GILDKGLMFJM? NHJKFKEOLHI, [Optional] BDAKMCMKMDO? GANKLOIFEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4226CD0", Offset = "0x42260D0", VA = "0x184226CD0")]
	public IODPKOFCJPG(int MLLKNBDHHFM, TimeSpan ACEBAFFEPFE, [Optional] IEqualityComparer<TKey>? POGJGFCGKMP, [Optional] GILDKGLMFJM? NHJKFKEOLHI, [Optional] BDAKMCMKMDO? GANKLOIFEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4228510", Offset = "0x4227910", VA = "0x184228510")]
	public IODPKOFCJPG(int MLLKNBDHHFM, KJIMHPHPAGD? OEBMELFBPMP, TimeSpan ACEBAFFEPFE, [Optional] IEqualityComparer<TKey>? POGJGFCGKMP, [Optional] GILDKGLMFJM? NHJKFKEOLHI, [Optional] BDAKMCMKMDO? GANKLOIFEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x421BF90", Offset = "0x421B390", VA = "0x18421BF90", Slot = "21")]
	public bool DBBGGCFGPNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4224CD0", Offset = "0x42240D0", VA = "0x184224CD0", Slot = "22")]
	public bool NJMFEHBPLKM(int MFKKELONDCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x421F430", Offset = "0x421E830", VA = "0x18421F430")]
	private bool HAGAINKKHHI(int MFKKELONDCC, IPAIEEIALLN POKPBEJPBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4223BC0", Offset = "0x4222FC0", VA = "0x184223BC0")]
	public void JOJCHNFNPDL(TKey GMJINMLEEAC, TVal LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4219390", Offset = "0x4218790", VA = "0x184219390", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x4218A20", Offset = "0x4217E20", VA = "0x184218A20", Slot = "9")]
	public void Add(TKey GMJINMLEEAC, TVal LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x421A780", Offset = "0x4219B80", VA = "0x18421A780", Slot = "8")]
	public bool ContainsKey(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x42256E0", Offset = "0x4224AE0", VA = "0x1842256E0", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> BNDEDHKBDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4224F90", Offset = "0x4224390", VA = "0x184224F90", Slot = "10")]
	public bool Remove(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4225C00", Offset = "0x4225000", VA = "0x184225C00", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> BNDEDHKBDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x421C2E0", Offset = "0x421B6E0", VA = "0x18421C2E0")]
	private bool DLNDJLCBFFE(TKey GMJINMLEEAC, [Out] TVal LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x42231A0", Offset = "0x42225A0", VA = "0x1842231A0")]
	private TVal JEMJOLBMCNL(TKey PBCLNIAADPK)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x4226640", Offset = "0x4225A40", VA = "0x184226640", Slot = "11")]
	public bool TryGetValue(TKey PBCLNIAADPK, [Out] TVal LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x421A4B0", Offset = "0x42198B0", VA = "0x18421A4B0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x421AB60", Offset = "0x4219F60", VA = "0x18421AB60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] AFBDFGIDJPF, int IFBAABIFFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4222C70", Offset = "0x4222070", VA = "0x184222C70")]
	private void IMNIJHOJIPD(TKey GMJINMLEEAC, TVal HMBPNLCBEEJ, IPAIEEIALLN POKPBEJPBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4224430", Offset = "0x4223830", VA = "0x184224430")]
	private bool KCENHNHNMJA(LKKJDGBKFBE PBBBDKAFENF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x42222D0", Offset = "0x42216D0", VA = "0x1842222D0")]
	private void HOOKCPIKHEM(LinkedListNode<LKKJDGBKFBE> ANNJDMFGCEM, TVal FFAPBOEDPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4217C00", Offset = "0x4217000", VA = "0x184217C00")]
	private void ABPBJIKCHMH(TKey GMJINMLEEAC, TVal LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x421A070", Offset = "0x4219470", VA = "0x18421A070")]
	private void CDEPCJNHIAK(LKKJDGBKFBE PBBBDKAFENF, TVal FFAPBOEDPIG, int CKFFDMFLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x421D2E0", Offset = "0x421C6E0", VA = "0x18421D2E0", Slot = "19")]
	[IteratorStateMachine(typeof(IODPKOFCJPG<, >.KKFIGMKOIPI))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4225D90", Offset = "0x4225190", VA = "0x184225D90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public enum IPAIEEIALLN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Evicted,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	RemovedViaRemove,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RemovedViaClear,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Overwritten
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class MPIBHLIFAKD<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly TKey AMBIADMJNCM;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4852A30", Offset = "0x4851E30", VA = "0x184852A30")]
	public MPIBHLIFAKD(TKey JJKJGCECHGF, Exception JHBBMCGELMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CJGIOPNDLCD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x61DDE40", Offset = "0x61DD240", VA = "0x1861DDE40")]
	public CJGIOPNDLCD(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class CFHDIMIAJNN<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class IDJHJNEGPOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CFHDIMIAJNN<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public IDJHJNEGPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x41D6140", Offset = "0x41D5540", VA = "0x1841D6140")]
		internal Task<TResource> LOBCIOAMNBP(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct BLILGBNHEPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CFHDIMIAJNN<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x527BDE0", Offset = "0x527B1E0", VA = "0x18527BDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x527C500", Offset = "0x527B900", VA = "0x18527C500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct LMJLEBAGLBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Task<TResource> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Dictionary<Task<TResource>, CancellationTokenSource> cancellationTokenSources;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4624020", Offset = "0x4623420", VA = "0x184624020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x46249E0", Offset = "0x4623DE0", VA = "0x1846249E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly PPOBMEEHFNJ<TId, Task<TResource>> GBOMGAEIONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> ICFFOPHINNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? MMPKGGDGIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly Action<TResource>? GPFMLBAICBD;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5311B20", Offset = "0x5310F20", VA = "0x185311B20")]
	public CFHDIMIAJNN(int NBBKLECJEBP = 0, [Optional] IEqualityComparer<TId>? HEAHOPMJIPC, [Optional] Func<TId, CancellationToken, Task<TResource>>? HMLGBNNCOGJ, [Optional] Action<TResource>? BKJJEHHBIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5310DF0", Offset = "0x53101F0", VA = "0x185310DF0")]
	public CCELPPEDKLE<Task<TResource>> JIPJNCDLAMO(TId IHELCOHOCAM, [Optional] Func<TId, CancellationToken, Task<TResource>>? HMLGBNNCOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x53109A0", Offset = "0x530FDA0", VA = "0x1853109A0")]
	private void GOIEHLKKJDP(Task<TResource> BIDGKFLMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x53116B0", Offset = "0x5310AB0", VA = "0x1853116B0")]
	[AsyncStateMachine(typeof(CFHDIMIAJNN<, >.BLILGBNHEPB))]
	private Task KFBLEGEAOJC(Task<TResource> BIDGKFLMMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x53106E0", Offset = "0x530FAE0", VA = "0x1853106E0")]
	public void GFHJFDEAGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x53117B0", Offset = "0x5310BB0", VA = "0x1853117B0")]
	public PPOBMEEHFNJ<TId, Task<TResource>>.LOBFCPPJNKC MKNNDFMGFGD()
	{
		return default(PPOBMEEHFNJ<TId, Task<TResource>>.LOBFCPPJNKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5311A80", Offset = "0x5310E80", VA = "0x185311A80", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5311A80", Offset = "0x5310E80", VA = "0x185311A80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5310350", Offset = "0x530F750", VA = "0x185310350")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(CFHDIMIAJNN<, >.LMJLEBAGLBJ))]
	internal static Task DHJILNFDDHG(Task<TResource> BIDGKFLMMBN, CancellationTokenSource GEGHHLKPJGN, Dictionary<Task<TResource>, CancellationTokenSource> IFIIADAJAGP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class PPOBMEEHFNJ<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private sealed class PJCGNMENOAO : IEquatable<PJCGNMENOAO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly TValue JKEIFELLNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int IINOMABHNGM;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xC6E0E0", Offset = "0xC6D4E0", VA = "0x180C6E0E0")]
		public PJCGNMENOAO(TValue LIHHDPOHLDK, int GOAINKDNLEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4B6ACF0", Offset = "0x4B6A0F0", VA = "0x184B6ACF0", Slot = "4")]
		public bool Equals(PJCGNMENOAO? OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4B6AD80", Offset = "0x4B6A180", VA = "0x184B6AD80", Slot = "0")]
		public override bool Equals(object? PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4B6AEC0", Offset = "0x4B6A2C0", VA = "0x184B6AEC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct LOBFCPPJNKC : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<TKey, PJCGNMENOAO>.Enumerator CAPMOGAGCHH;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x462AF80", Offset = "0x462A380", VA = "0x18462AF80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public (TKey Key, TValue Value, int RefCount) BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x462B610", Offset = "0x462AA10", VA = "0x18462B610", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x462B320", Offset = "0x462A720", VA = "0x18462B320")]
		public LOBFCPPJNKC(PPOBMEEHFNJ<TKey, TValue> KFEJHMHFKIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x462ABC0", Offset = "0x4629FC0", VA = "0x18462ABC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x462AC40", Offset = "0x462A040", VA = "0x18462AC40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x462AD70", Offset = "0x462A170", VA = "0x18462AD70", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class EBECKKDJELB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public PPOBMEEHFNJ<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public PJCGNMENOAO refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public EBECKKDJELB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3B1BB10", Offset = "0x3B1AF10", VA = "0x183B1BB10")]
		internal void LOBCIOAMNBP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Dictionary<TKey, PJCGNMENOAO> FFEMBLNIIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly Func<TKey, TValue>? LKFGHIBGNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Action<TValue>? MKJJLLMOHFG;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CB20", Offset = "0x4B7BF20", VA = "0x184B7CB20")]
	public PPOBMEEHFNJ(int NBBKLECJEBP = 0, [Optional] IEqualityComparer<TKey>? POGJGFCGKMP, [Optional] Func<TKey, TValue>? EOBEPGCFJIL, [Optional] Action<TValue>? FMKEMNOLKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B7E0", Offset = "0x4B7ABE0", VA = "0x184B7B7E0")]
	public CCELPPEDKLE<TValue> JIPJNCDLAMO(TKey GMJINMLEEAC, [Optional] Func<TKey, TValue>? KEEMANHNPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C560", Offset = "0x4B7B960", VA = "0x184B7C560")]
	private void PHDJEGBOJIB(TKey GMJINMLEEAC, PJCGNMENOAO PGHKCFGOMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B5B0", Offset = "0x4B7A9B0", VA = "0x184B7B5B0")]
	public void GFHJFDEAGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C4E0", Offset = "0x4B7B8E0", VA = "0x184B7C4E0")]
	public LOBFCPPJNKC MKNNDFMGFGD()
	{
		return default(LOBFCPPJNKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C930", Offset = "0x4B7BD30", VA = "0x184B7C930", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C930", Offset = "0x4B7BD30", VA = "0x184B7C930", Slot = "5")]
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
