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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x738B900", Offset = "0x738A700", VA = "0x18738B900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IMMDGIGODCO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected IMMDGIGODCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class EFEOKHOCPAM<T> : IMMDGIGODCO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct OCNICBDDGMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum HJKBBBCDOMJ
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
		public HJKBBBCDOMJ OBDHBADPJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T OOCJAOHFGJK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int NHBIHNAMJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool EBJJLFEHCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool DHAGHPPDDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? CBHJPFDDHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OCNICBDDGMN>? MJOAJAPMCLD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KAFNKNOOGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3FDB910", Offset = "0x3FDA710", VA = "0x183FDB910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3FDC330", Offset = "0x3FDB130", VA = "0x183FDC330")]
	protected EFEOKHOCPAM(bool DHAGHPPDDOK, bool EBJJLFEHCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3FDC0E0", Offset = "0x3FDAEE0", VA = "0x183FDC0E0")]
	protected bool NBDBJFIHIMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3FDBDB0", Offset = "0x3FDABB0", VA = "0x183FDBDB0")]
	protected void LPMHCCFBNDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3FDB970", Offset = "0x3FDA770", VA = "0x183FDB970")]
	protected void HDPJLGMBJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x35A5B10", Offset = "0x35A4910", VA = "0x1835A5B10")]
	private static void KPBIPEMIFEN<U>(List<U>? BJCKKCNKPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3FDBED0", Offset = "0x3FDACD0", VA = "0x183FDBED0", Slot = "4")]
	public void MDGAONDGEMG(T OOCJAOHFGJK, bool LCGAAMEAOPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3FDBBE0", Offset = "0x3FDA9E0", VA = "0x183FDBBE0", Slot = "5")]
	public void IEINLEAGPOE(T OOCJAOHFGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FDC180", Offset = "0x3FDAF80", VA = "0x183FDC180")]
	public void NCEIDOKFHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GAMKKEJCIBM : EFEOKHOCPAM<Action>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7389450", Offset = "0x7388250", VA = "0x187389450")]
	public GAMKKEJCIBM(bool DHAGHPPDDOK = false, bool EBJJLFEHCEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7389250", Offset = "0x7388050", VA = "0x187389250")]
	public void GAFILCALGLM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x73891F0", Offset = "0x7387FF0", VA = "0x1873891F0")]
	public static GAMKKEJCIBM FGBMGJFOFOB(GAMKKEJCIBM ALFHHFLOKCJ, Action OOCJAOHFGJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7389190", Offset = "0x7387F90", VA = "0x187389190")]
	public static GAMKKEJCIBM CECKNIEOKMB(GAMKKEJCIBM ALFHHFLOKCJ, Action OOCJAOHFGJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LGOHDDOMJIE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDGAONDGEMG(Action<T> OOCJAOHFGJK, bool LCGAAMEAOPP = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEINLEAGPOE(Action<T> OOCJAOHFGJK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class OJCBODLGMBO<T> : EFEOKHOCPAM<Action<T>>, LGOHDDOMJIE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x44803C0", Offset = "0x447F1C0", VA = "0x1844803C0")]
	public OJCBODLGMBO(bool DHAGHPPDDOK = false, bool EBJJLFEHCEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E4AD00", Offset = "0x4E49B00", VA = "0x184E4AD00")]
	public void GAFILCALGLM(T DHJLEBFEJME)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x452A520", Offset = "0x4529320", VA = "0x18452A520")]
	public static OJCBODLGMBO<T> FGBMGJFOFOB(OJCBODLGMBO<T> ALFHHFLOKCJ, Action<T> OOCJAOHFGJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x452A480", Offset = "0x4529280", VA = "0x18452A480")]
	public static OJCBODLGMBO<T> CECKNIEOKMB(OJCBODLGMBO<T> ALFHHFLOKCJ, Action<T> OOCJAOHFGJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OODKHPOFHAN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDGAONDGEMG(Action<T, U> OOCJAOHFGJK, bool LCGAAMEAOPP = false);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEINLEAGPOE(Action<T, U> OOCJAOHFGJK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class HPCPKCGMACP<T, U> : EFEOKHOCPAM<Action<T, U>>, OODKHPOFHAN<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x44803C0", Offset = "0x447F1C0", VA = "0x1844803C0")]
	public HPCPKCGMACP(bool DHAGHPPDDOK = false, bool EBJJLFEHCEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4638350", Offset = "0x4637150", VA = "0x184638350")]
	public void GAFILCALGLM(T DHJLEBFEJME, U JMPBLIAIGDC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x452A520", Offset = "0x4529320", VA = "0x18452A520")]
	public static HPCPKCGMACP<T, U> FGBMGJFOFOB(HPCPKCGMACP<T, U> ALFHHFLOKCJ, Action<T, U> OOCJAOHFGJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x452A480", Offset = "0x4529280", VA = "0x18452A480")]
	public static HPCPKCGMACP<T, U> CECKNIEOKMB(HPCPKCGMACP<T, U> ALFHHFLOKCJ, Action<T, U> OOCJAOHFGJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class COCBDDCHECL<T, U, V> : EFEOKHOCPAM<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x44803C0", Offset = "0x447F1C0", VA = "0x1844803C0")]
	public COCBDDCHECL(bool DHAGHPPDDOK = false, bool EBJJLFEHCEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5A52270", Offset = "0x5A51070", VA = "0x185A52270")]
	public void GAFILCALGLM(T DHJLEBFEJME, U JMPBLIAIGDC, V MFHMIEFHEKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x452A520", Offset = "0x4529320", VA = "0x18452A520")]
	public static COCBDDCHECL<T, U, V> FGBMGJFOFOB(COCBDDCHECL<T, U, V> ALFHHFLOKCJ, Action<T, U, V> OOCJAOHFGJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x452A480", Offset = "0x4529280", VA = "0x18452A480")]
	public static COCBDDCHECL<T, U, V> CECKNIEOKMB(COCBDDCHECL<T, U, V> ALFHHFLOKCJ, Action<T, U, V> OOCJAOHFGJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GCPGPFLBINM<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class HBJFFELDNHL<T, U, V, W> : EFEOKHOCPAM<Action<T, U, V, W>>, GCPGPFLBINM<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x44803C0", Offset = "0x447F1C0", VA = "0x1844803C0")]
	public HBJFFELDNHL(bool DHAGHPPDDOK = false, bool EBJJLFEHCEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4551050", Offset = "0x454FE50", VA = "0x184551050")]
	public void GAFILCALGLM(T DHJLEBFEJME, U JMPBLIAIGDC, V MFHMIEFHEKN, W DMBNCEPMGLK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x452A520", Offset = "0x4529320", VA = "0x18452A520")]
	public static HBJFFELDNHL<T, U, V, W> FGBMGJFOFOB(HBJFFELDNHL<T, U, V, W> ALFHHFLOKCJ, Action<T, U, V, W> OOCJAOHFGJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x452A480", Offset = "0x4529280", VA = "0x18452A480")]
	public static HBJFFELDNHL<T, U, V, W> CECKNIEOKMB(HBJFFELDNHL<T, U, V, W> ALFHHFLOKCJ, Action<T, U, V, W> OOCJAOHFGJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HNGEMMNNAGP<T, U, V, W, X> : EFEOKHOCPAM<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x44803C0", Offset = "0x447F1C0", VA = "0x1844803C0")]
	public HNGEMMNNAGP(bool DHAGHPPDDOK = false, bool EBJJLFEHCEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x45A7950", Offset = "0x45A6750", VA = "0x1845A7950")]
	public void GAFILCALGLM(T DHJLEBFEJME, U JMPBLIAIGDC, V MFHMIEFHEKN, W DMBNCEPMGLK, X LBONEMFCDEA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x452A520", Offset = "0x4529320", VA = "0x18452A520")]
	public static HNGEMMNNAGP<T, U, V, W, X> FGBMGJFOFOB(HNGEMMNNAGP<T, U, V, W, X> ALFHHFLOKCJ, Action<T, U, V, W, X> OOCJAOHFGJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x452A480", Offset = "0x4529280", VA = "0x18452A480")]
	public static HNGEMMNNAGP<T, U, V, W, X> CECKNIEOKMB(HNGEMMNNAGP<T, U, V, W, X> ALFHHFLOKCJ, Action<T, U, V, W, X> OOCJAOHFGJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ANNNFFJJDFG<T, U, V, W, X, Y> : EFEOKHOCPAM<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x44803C0", Offset = "0x447F1C0", VA = "0x1844803C0")]
	public ANNNFFJJDFG(bool DHAGHPPDDOK = false, bool EBJJLFEHCEG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x452A5C0", Offset = "0x45293C0", VA = "0x18452A5C0")]
	public void GAFILCALGLM(T DHJLEBFEJME, U JMPBLIAIGDC, V MFHMIEFHEKN, W DMBNCEPMGLK, X LBONEMFCDEA, Y IOKFBHNPJAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x452A520", Offset = "0x4529320", VA = "0x18452A520")]
	public static ANNNFFJJDFG<T, U, V, W, X, Y> FGBMGJFOFOB(ANNNFFJJDFG<T, U, V, W, X, Y> ALFHHFLOKCJ, Action<T, U, V, W, X, Y> OOCJAOHFGJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x452A480", Offset = "0x4529280", VA = "0x18452A480")]
	public static ANNNFFJJDFG<T, U, V, W, X, Y> CECKNIEOKMB(ANNNFFJJDFG<T, U, V, W, X, Y> ALFHHFLOKCJ, Action<T, U, V, W, X, Y> OOCJAOHFGJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CIFNOCKIFOB<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ECKFKDNALJK<TKey, TVal> MCBDLHPCKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> HOLKBNGPHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly ECKFKDNALJK<TKey, TVal>.BFLDECMNFHG? DGJEHECFJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly int GBIJICPDLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ECKFKDNALJK<TKey, TVal>.CHJDAOMLKOP? CPIGODGPICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int KBAEPPNBOJK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int MCGGALMPJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5963640", Offset = "0x5962440", VA = "0x185963640")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EONCJEIOJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F70", Offset = "0x8F7D70", VA = "0x1808F8F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5964540", Offset = "0x5963340", VA = "0x185964540")]
	public CIFNOCKIFOB(int GBIJICPDLFC, [Optional] ECKFKDNALJK<TKey, TVal>.CHJDAOMLKOP? CPIGODGPICP, [Optional] IEqualityComparer<TKey>? CMONDDCHEIN, [Optional] ECKFKDNALJK<TKey, TVal>.BFLDECMNFHG? DGJEHECFJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5963C70", Offset = "0x5962A70", VA = "0x185963C70")]
	public void NKIKKKPFOMN(TKey FFOHLCGHDKA, TVal IPHILEOFJLB, bool FJPLPIFMFMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x59637B0", Offset = "0x59625B0", VA = "0x1859637B0")]
	public bool IHLCGIOPHHN(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5963910", Offset = "0x5962710", VA = "0x185963910")]
	public bool MHAMFDPPPMK(TKey PADNBEPNLIP, [Out] TVal IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5963250", Offset = "0x5962050", VA = "0x185963250")]
	private void CKFNKJPOJBM(TKey FFOHLCGHDKA, TVal IPHILEOFJLB, int IECADCKMGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5963A10", Offset = "0x5962810", VA = "0x185963A10")]
	public bool MJBCOKOBMGP(TKey FFOHLCGHDKA, TVal IPHILEOFJLB, bool FJPLPIFMFMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5963BC0", Offset = "0x59629C0", VA = "0x185963BC0")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5963EA0", Offset = "0x5962CA0", VA = "0x185963EA0")]
	private void OIFCBFFKEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5964400", Offset = "0x5963200", VA = "0x185964400")]
	private bool OPBBNELIPPK(TKey FFOHLCGHDKA, MPDAKHGFNDF ADJDIHDFFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5963690", Offset = "0x5962490", VA = "0x185963690")]
	private void GJMGCDOFCDC(TKey FFOHLCGHDKA, TVal IPHILEOFJLB, MPDAKHGFNDF ADJDIHDFFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5963510", Offset = "0x5962310", VA = "0x185963510")]
	private void DENGJPEGDMA(TKey FFOHLCGHDKA, TVal OAJCPHOOFGC, MPDAKHGFNDF ADJDIHDFFBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OHBFFPDDILP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly Action FHAHMEKJIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LIIBBFKLOJC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public OHBFFPDDILP(Action PKAFAHJDEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x738B980", Offset = "0x738A780", VA = "0x18738B980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3100440", Offset = "0x30FF240", VA = "0x183100440")]
	public static DHBMCMEBKMG<T> DCMOGLEGFAE<T>(T IPHILEOFJLB, Action PKAFAHJDEEN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class DHBMCMEBKMG<T> : OHBFFPDDILP where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60FEAC0", Offset = "0x60FD8C0", VA = "0x1860FEAC0")]
	public DHBMCMEBKMG(T IPHILEOFJLB, Action PKAFAHJDEEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class HNMFKCPDLBM<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly FBIBDFBKOCC<T>? ILHODJNMJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ReadOnlySequence<T> MGENGIAGNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool LIIBBFKLOJC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly HNMFKCPDLBM<T> JBBIPKIKKBB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ReadOnlySequence<T> ACBNJBJPOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x45ABD50", Offset = "0x45AAB50", VA = "0x1845ABD50")]
		get
		{
			return default(ReadOnlySequence<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x45AB930", Offset = "0x45AA730", VA = "0x1845AB930")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HDHDIACPLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x45ABBD0", Offset = "0x45AA9D0", VA = "0x1845ABBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x45AC560", Offset = "0x45AB360", VA = "0x1845AC560")]
	public HNMFKCPDLBM(FBIBDFBKOCC<T> JIGCKHPMBHO, FBIBDFBKOCC<T> MPGELAJCAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x45AC650", Offset = "0x45AB450", VA = "0x1845AC650")]
	public HNMFKCPDLBM(FBIBDFBKOCC<T> JIGCKHPMBHO, int GJCOHOCILFF, FBIBDFBKOCC<T> MPGELAJCAEO, int BGNNHGHIKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x45AC100", Offset = "0x45AAF00", VA = "0x1845AC100")]
	private HNMFKCPDLBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x45AB8A0", Offset = "0x45AA6A0", VA = "0x1845AB8A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x45ABE50", Offset = "0x45AAC50", VA = "0x1845ABE50")]
	public T[] OBAGPKOJJNI()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x45ABAB0", Offset = "0x45AA8B0", VA = "0x1845ABAB0")]
	public static ReadOnlySequence<T> JCHCBNMNCNP(HNMFKCPDLBM<T>? GBJBOGFDKGP)
	{
		return default(ReadOnlySequence<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct PJHHGAKMFFO : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct FCNDDMOFADH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
		public static FCNDDMOFADH MKHEJJEDOII()
		{
			return default(FCNDDMOFADH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x738BFD0", Offset = "0x738ADD0", VA = "0x18738BFD0")]
	public static string NOGKKLNDIFF(Type OBDHBADPJNM, [Optional] string? KOPNMOADGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x34A06D0", Offset = "0x349F4D0", VA = "0x1834A06D0")]
	public static string? NOGKKLNDIFF<T>([Optional] string? KOPNMOADGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x34A0650", Offset = "0x349F450", VA = "0x1834A0650")]
	public static string? MJNKCCKPJPJ<T>([Optional] string? PMNNGPDBMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
	public static PJHHGAKMFFO IFANBOIGHJP(string KOPNMOADGFD, string? PMNNGPDBMPP)
	{
		return default(PJHHGAKMFFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NNDGLBEAKFC
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool FILDPDCEIEP(string GALLAMOOJEF, NNDGLBEAKFC FKKAIAEJKCL);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OGEFDOCENGF<T> where T : notnull, Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public List<int> enumValuesSubset;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OGEFDOCENGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4E39A50", Offset = "0x4E38850", VA = "0x184E39A50")]
		internal void MOJEEFCJKJC(T x)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int LJGAMICHBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public string AMEAEGHDALB;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x738B050", Offset = "0x7389E50", VA = "0x18738B050")]
	public static Dictionary<string, NNDGLBEAKFC> CDHIEOPDPBL(Type BAIAAKMEPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34617F0", Offset = "0x34605F0", VA = "0x1834617F0")]
	public static Dictionary<string, NNDGLBEAKFC> CDHIEOPDPBL<T>(Type BAIAAKMEPDO, IReadOnlyDictionary<T, string> DBIDMBCBGIE) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3461070", Offset = "0x345FE70", VA = "0x183461070")]
	public static Dictionary<string, NNDGLBEAKFC> BOABFDCAENA<T>(List<T> AAJBJNPCBOP) where T : notnull, Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x738B540", Offset = "0x738A340", VA = "0x18738B540")]
	public static Dictionary<string, NNDGLBEAKFC> PBGMMCCEOJK(Type BAIAAKMEPDO, FILDPDCEIEP CEGHOGPGCLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x738B380", Offset = "0x738A180", VA = "0x18738B380")]
	public static Dictionary<int, string> CJIKGDKBJKJ(Dictionary<string, NNDGLBEAKFC> EDLHCINOAKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class MFMDDJMMGHP : EOABGNINGBC
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static bool LBIKNCLMNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly string? EBBCNPIIBED;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual EOABGNINGBC? DHBLLBIHHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x738AF40", Offset = "0x7389D40", VA = "0x18738AF40")]
	protected MFMDDJMMGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string KMIKCFPGPHL();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x738A8A0", Offset = "0x73896A0", VA = "0x18738A8A0", Slot = "8")]
	public virtual string AFEABOAHPNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x738A920", Offset = "0x7389720", VA = "0x18738A920", Slot = "9")]
	public void BPOKPHHLIOE(StringBuilder HKJLHFFJLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x738AC60", Offset = "0x7389A60", VA = "0x18738AC60", Slot = "10")]
	public void HIBMCJKAMEG(StringBuilder HKJLHFFJLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x738ACC0", Offset = "0x7389AC0", VA = "0x18738ACC0", Slot = "11")]
	public void KGKBLGJIHJD(StringBuilder HKJLHFFJLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x738ADE0", Offset = "0x7389BE0", VA = "0x18738ADE0", Slot = "12")]
	public void PHMKBIGEIFI(StringBuilder HKJLHFFJLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x738ABC0", Offset = "0x73899C0", VA = "0x18738ABC0")]
	public static void DOLPDBEDMAJ(StringBuilder HKJLHFFJLGP, string NDKKADCKLPM, string NIMDEPDFOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x647EB60", Offset = "0x647D960", VA = "0x18647EB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EJNGHKJAJKB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7388EB0", Offset = "0x7387CB0", VA = "0x187388EB0")]
	public EJNGHKJAJKB(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FBJLPPEMMFK<TErr> : EJNGHKJAJKB where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly TErr AHMKNFHGODJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4383780", Offset = "0x4382580", VA = "0x184383780")]
	private FBJLPPEMMFK([In] TErr HIGKDLHPFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x43836B0", Offset = "0x43824B0", VA = "0x1843836B0")]
	public static FBJLPPEMMFK<TErr> MKHEJJEDOII([In] TErr HIGKDLHPFBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OJOPBPMDIBE : Stream
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashAlgorithm AENOICMBFKM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public override bool BMNGOGFGEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public override bool PNHDGAPDPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override bool HFPCEMJLFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override long BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x738BDC0", Offset = "0x738ABC0", VA = "0x18738BDC0", Slot = "12")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override long FJDJKDCINHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x738BE30", Offset = "0x738AC30", VA = "0x18738BE30", Slot = "13")]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x738BEA0", Offset = "0x738ACA0", VA = "0x18738BEA0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x738BD50", Offset = "0x738AB50", VA = "0x18738BD50")]
	public OJOPBPMDIBE(HashAlgorithm AENOICMBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x738BB70", Offset = "0x738A970", VA = "0x18738BB70", Slot = "35")]
	public override int Read(byte[] FBEHCHGAOLI, int DACBEFNKNPO, int BMGBDLLODJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x738BD20", Offset = "0x738AB20", VA = "0x18738BD20", Slot = "38")]
	public override void Write(byte[] FBEHCHGAOLI, int DACBEFNKNPO, int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x738BC10", Offset = "0x738AA10", VA = "0x18738BC10", Slot = "33")]
	public override long Seek(long DACBEFNKNPO, SeekOrigin JBEADJDOHMN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x738BCA0", Offset = "0x738AAA0", VA = "0x18738BCA0", Slot = "34")]
	public override void SetLength(long IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "23")]
	public override void Flush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x738BA90", Offset = "0x738A890", VA = "0x18738BA90")]
	public byte[] MAPMLGBPNLE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EOABGNINGBC
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AFEABOAHPNF();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KMIKCFPGPHL();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HGDALPBEPLL<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	TOptions HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DDCAMJJEEGI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string IBCFOFLBCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FBIBDFBKOCC<T> : ReadOnlySequenceSegment<T>, IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static FBIBDFBKOCC<T>? CHMCBOIEFFL;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static object HELEDJPHPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IMemoryOwner<T>? EFLDHPPMDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool LIIBBFKLOJC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OBOEGBKEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC2CA50", Offset = "0xC2B850", VA = "0x180C2CA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4381900", Offset = "0x4380700", VA = "0x184381900")]
	private static FBIBDFBKOCC<T> ACJHFBPJIKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4382E10", Offset = "0x4381C10", VA = "0x184382E10")]
	private static void MOKMPEADGEI(FBIBDFBKOCC<T> CICKFBFLHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4383670", Offset = "0x4382470", VA = "0x184383670")]
	private FBIBDFBKOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x43822B0", Offset = "0x43810B0", VA = "0x1843822B0")]
	public static FBIBDFBKOCC<T> DCMOGLEGFAE(ReadOnlyMemory<T> MLMGKCHOEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x43820A0", Offset = "0x4380EA0", VA = "0x1843820A0")]
	public static FBIBDFBKOCC<T> DCMOGLEGFAE(IMemoryOwner<T> NGFPNBHBPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4382CD0", Offset = "0x4381AD0", VA = "0x184382CD0")]
	public static void LKHGJBHHDHO(FBIBDFBKOCC<T> JIGCKHPMBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4382700", Offset = "0x4381500", VA = "0x184382700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4381DC0", Offset = "0x4380BC0", VA = "0x184381DC0")]
	public FBIBDFBKOCC<T> BDHIDIGOKNL(IMemoryOwner<T> NGFPNBHBPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4382AD0", Offset = "0x43818D0", VA = "0x184382AD0")]
	private void LAHIKIGCPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4382980", Offset = "0x4381780", VA = "0x184382980")]
	private FBIBDFBKOCC<T> KKKOLAINPOC(FBIBDFBKOCC<T> CICKFBFLHJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OIANFLINKDG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x738BA30", Offset = "0x738A830", VA = "0x18738BA30")]
	public OIANFLINKDG(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DNDMNCKCCNL<TOk> : OIANFLINKDG where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly TOk BLHPJEOKAHJ;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6128D10", Offset = "0x6127B10", VA = "0x186128D10")]
	private DNDMNCKCCNL([In] TOk IJDOOMNJNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x454F180", Offset = "0x454DF80", VA = "0x18454F180")]
	public static DNDMNCKCCNL<TOk> MKHEJJEDOII([In] TOk IJDOOMNJNDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct PGOLMGNGGBM<TOk, TErr> : IEquatable<PGOLMGNGGBM<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly EqualityComparer<TErr> LLGJMGLDHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal readonly TErr AHMKNFHGODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal readonly TOk BLHPJEOKAHJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool FNFHCNDCDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4F1B780", Offset = "0x4F1A580", VA = "0x184F1B780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MEJNCHBOPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4F1E260", Offset = "0x4F1D060", VA = "0x184F1E260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4F22E20", Offset = "0x4F21C20", VA = "0x184F22E20")]
	internal PGOLMGNGGBM([In] TErr HIGKDLHPFBO, [In] TOk IJDOOMNJNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4F1E860", Offset = "0x4F1D660", VA = "0x184F1E860")]
	public static PGOLMGNGGBM<TOk, TErr> NOJBNAPGOBD([In] TErr HIGKDLHPFBO)
	{
		return default(PGOLMGNGGBM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4F1F040", Offset = "0x4F1DE40", VA = "0x184F1F040")]
	public static PGOLMGNGGBM<TOk, TErr> PBPKFFPGHFO([In] TOk IJDOOMNJNDC)
	{
		return default(PGOLMGNGGBM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3879E00", Offset = "0x3878C00", VA = "0x183879E00")]
	public PGOLMGNGGBM<TOk?, UErr?> LEKKPNIAHGI<UErr>()
	{
		return default(PGOLMGNGGBM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x38784A0", Offset = "0x38772A0", VA = "0x1838784A0")]
	public PGOLMGNGGBM<UOk?, TErr?> ANBIFLOOLHK<UOk>()
	{
		return default(PGOLMGNGGBM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x38787E0", Offset = "0x38775E0", VA = "0x1838787E0")]
	public PGOLMGNGGBM<UOk?, TErr?> CHGOFOHLIDE<UOk>()
	{
		return default(PGOLMGNGGBM<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3879920", Offset = "0x3878720", VA = "0x183879920")]
	public PGOLMGNGGBM<TOk?, UErr?> GGJJBFMFOKN<UErr>()
	{
		return default(PGOLMGNGGBM<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4F1B3B0", Offset = "0x4F1A1B0", VA = "0x184F1B3B0")]
	public PGOLMGNGGBM<ENLEGHEGALI, TErr> CCKDKFKMJAJ()
	{
		return default(PGOLMGNGGBM<ENLEGHEGALI, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4F1A120", Offset = "0x4F18F20", VA = "0x184F1A120")]
	public static bool BHDCHHANDIG([In] PGOLMGNGGBM<TOk, TErr> PMKFIDCMLAN, [In] PGOLMGNGGBM<TOk, TErr> BFOIKIBAAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4F1C300", Offset = "0x4F1B100", VA = "0x184F1C300", Slot = "4")]
	public bool Equals(PGOLMGNGGBM<TOk, TErr> LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4F1BE50", Offset = "0x4F1AC50", VA = "0x184F1BE50", Slot = "0")]
	public override bool Equals(object LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4F1CE80", Offset = "0x4F1BC80", VA = "0x184F1CE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4F21620", Offset = "0x4F20420", VA = "0x184F21620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GGBOKCDGHGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MONDGBFPODN<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Task<PGOLMGNGGBM<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<PGOLMGNGGBM<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4CD2D20", Offset = "0x4CD1B20", VA = "0x184CD2D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4CD3680", Offset = "0x4CD2480", VA = "0x184CD3680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x32AF1B0", Offset = "0x32ADFB0", VA = "0x1832AF1B0")]
	public static PGOLMGNGGBM<TOk?, TErr?> BLHPJEOKAHJ<TOk, TErr>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [In] TOk IJDOOMNJNDC)
	{
		return default(PGOLMGNGGBM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x32AFB10", Offset = "0x32AE910", VA = "0x1832AFB10")]
	public static PGOLMGNGGBM<ENLEGHEGALI, TErr?> BLHPJEOKAHJ<TErr>([In] this PGOLMGNGGBM<ENLEGHEGALI, TErr> DJAJDIFOIHP)
	{
		return default(PGOLMGNGGBM<ENLEGHEGALI, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x32AF1B0", Offset = "0x32ADFB0", VA = "0x1832AF1B0")]
	public static PGOLMGNGGBM<TOk?, TErr?> AHMKNFHGODJ<TOk, TErr>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [In] TErr HIGKDLHPFBO)
	{
		return default(PGOLMGNGGBM<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x32B09B0", Offset = "0x32AF7B0", VA = "0x1832B09B0")]
	public static TOk? HFKHCOOBEFK<TOk, TErr>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x32AFDE0", Offset = "0x32AEBE0", VA = "0x1832AFDE0")]
	[AsyncStateMachine(typeof(MONDGBFPODN<, >))]
	public static Task<TOk?>? CFIHDLBPPJL<TOk, TErr>(this Task<PGOLMGNGGBM<TOk, TErr>> DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x32AF900", Offset = "0x32AE700", VA = "0x1832AF900")]
	public static TErr? BGGHFLLFDBJ<TErr, TOk>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x32B13F0", Offset = "0x32B01F0", VA = "0x1832B13F0")]
	public static bool KGMJALOBIIC<TOk, TErr, UErr, UOk>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [Out] PGOLMGNGGBM<UOk, UErr> DHPMOEBAONK) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x32AFBB0", Offset = "0x32AE9B0", VA = "0x1832AFBB0")]
	public static bool BNNFBKJFFFK<TOk, TErr>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [Out] TOk IJDOOMNJNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x32B2B00", Offset = "0x32B1900", VA = "0x1832B2B00")]
	public static bool NJAFPNJNBIH<TOk, TErr>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [Out][NotNullWhen(true)] TErr HIGKDLHPFBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x32B2A20", Offset = "0x32B1820", VA = "0x1832B2A20")]
	public static bool NIFGCHEBBOC<TOk, TErr>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [Out][NotNullWhen(true)] TOk IJDOOMNJNDC, [Out][NotNullWhen(false)] TErr HIGKDLHPFBO) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x32B08B0", Offset = "0x32AF6B0", VA = "0x1832B08B0")]
	public static bool HBHKHMCPNGC<TOk, TErr>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [Out][NotNullWhen(true)] TOk IJDOOMNJNDC, [Out] PGOLMGNGGBM<TOk, TErr> DHPMOEBAONK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x32B1650", Offset = "0x32B0450", VA = "0x1832B1650")]
	public static bool KGMJALOBIIC<TOk, TErr, UErr, UOk>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [Out][NotNullWhen(true)] TOk IJDOOMNJNDC, [Out] PGOLMGNGGBM<UOk, UErr> DHPMOEBAONK) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x32B1040", Offset = "0x32AFE40", VA = "0x1832B1040")]
	public static bool JPIOJJAFFFA<TOk, TErr>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [Out][NotNullWhen(true)] TOk IJDOOMNJNDC, [Out] PGOLMGNGGBM<ENLEGHEGALI, TErr> DHPMOEBAONK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x32B02F0", Offset = "0x32AF0F0", VA = "0x1832B02F0")]
	public static PGOLMGNGGBM<UOk, UErr> GNKFJCPPDMB<UOk, UErr, TOk, TErr>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, [In] PGOLMGNGGBM<UOk, UErr> BHICHJIFLJC) where TOk : UOk where TErr : UErr
	{
		return default(PGOLMGNGGBM<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x32AF380", Offset = "0x32AE180", VA = "0x1832AF380")]
	public static PGOLMGNGGBM<TOk?[]?, TErr?> AJGGLIOCGFN<TOk, TErr>(this IEnumerable<PGOLMGNGGBM<TOk, TErr>> DJAJDIFOIHP)
	{
		return default(PGOLMGNGGBM<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x32B25D0", Offset = "0x32B13D0", VA = "0x1832B25D0")]
	public static PGOLMGNGGBM<UOk?, TErr?> KJLNIMNJKIG<UOk, TErr, TOk>([In] this PGOLMGNGGBM<TOk, TErr> DJAJDIFOIHP, Func<TOk, UOk> OGAAGANFPMH)
	{
		return default(PGOLMGNGGBM<UOk, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class CMEDKMEIOEJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x32FADF0", Offset = "0x32F9BF0", VA = "0x1832FADF0")]
	public static PGOLMGNGGBM<TOk, T> BLHPJEOKAHJ<TOk>([In] TOk IJDOOMNJNDC) where TOk : notnull
	{
		return default(PGOLMGNGGBM<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x596CC90", Offset = "0x596BA90", VA = "0x18596CC90")]
	public static PGOLMGNGGBM<ENLEGHEGALI, T> BLHPJEOKAHJ()
	{
		return default(PGOLMGNGGBM<ENLEGHEGALI, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x32FADF0", Offset = "0x32F9BF0", VA = "0x1832FADF0")]
	public static PGOLMGNGGBM<T, TErr> AHMKNFHGODJ<TErr>([In] TErr HIGKDLHPFBO) where TErr : notnull
	{
		return default(PGOLMGNGGBM<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct OAMCKCGAMBG<TKey, TValue> where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly GAGNCLFMPKK HLABDPFFGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<TKey, TValue> PABPLDHKJJD;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4E204B0", Offset = "0x4E1F2B0", VA = "0x184E204B0")]
	public static OAMCKCGAMBG<TKey, TValue> MKHEJJEDOII(string MOBMLKIIAJP)
	{
		return default(OAMCKCGAMBG<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4E20670", Offset = "0x4E1F470", VA = "0x184E20670")]
	internal OAMCKCGAMBG(Dictionary<TKey, TValue> IPHILEOFJLB, GAGNCLFMPKK GIHNPGKKNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4E205D0", Offset = "0x4E1F3D0", VA = "0x184E205D0")]
	public MOGPLDMLNBF<TKey, TValue> OCJDMOMBDHH([Out] Dictionary<TKey, TValue> IPHILEOFJLB)
	{
		return default(MOGPLDMLNBF<TKey, TValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct MOGPLDMLNBF<TKey, TValue> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TValue> PABPLDHKJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly ENPIAOLJNCN NBPAHNGGNLP;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x27376F0", Offset = "0x27364F0", VA = "0x1827376F0")]
	internal MOGPLDMLNBF(Dictionary<TKey, TValue> IPHILEOFJLB, ENPIAOLJNCN AGKGDFEFEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4CC4B60", Offset = "0x4CC3960", VA = "0x184CC4B60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct PHBKNONABEM<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly GAGNCLFMPKK HLABDPFFGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HashSet<T> PABPLDHKJJD;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4E204B0", Offset = "0x4E1F2B0", VA = "0x184E204B0")]
	public static PHBKNONABEM<T> MKHEJJEDOII(string MOBMLKIIAJP)
	{
		return default(PHBKNONABEM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4E20670", Offset = "0x4E1F470", VA = "0x184E20670")]
	internal PHBKNONABEM(HashSet<T> IPHILEOFJLB, GAGNCLFMPKK GIHNPGKKNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4E205D0", Offset = "0x4E1F3D0", VA = "0x184E205D0")]
	public CCGCGEENIFN<T> OCJDMOMBDHH([Out] HashSet<T> IPHILEOFJLB)
	{
		return default(CCGCGEENIFN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct CCGCGEENIFN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HashSet<T> PABPLDHKJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ENPIAOLJNCN NBPAHNGGNLP;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x27376F0", Offset = "0x27364F0", VA = "0x1827376F0")]
	internal CCGCGEENIFN(HashSet<T> IPHILEOFJLB, ENPIAOLJNCN AGKGDFEFEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4CC4B60", Offset = "0x4CC3960", VA = "0x184CC4B60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct DEAMCDPHBAO<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly GAGNCLFMPKK HLABDPFFGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Stack<T> PABPLDHKJJD;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4E204B0", Offset = "0x4E1F2B0", VA = "0x184E204B0")]
	public static DEAMCDPHBAO<T> MKHEJJEDOII(string MOBMLKIIAJP)
	{
		return default(DEAMCDPHBAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4E20670", Offset = "0x4E1F470", VA = "0x184E20670")]
	internal DEAMCDPHBAO(Stack<T> IPHILEOFJLB, GAGNCLFMPKK GIHNPGKKNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4E205D0", Offset = "0x4E1F3D0", VA = "0x184E205D0")]
	public PNOEJKCMJAK<T> OCJDMOMBDHH([Out] Stack<T> IPHILEOFJLB)
	{
		return default(PNOEJKCMJAK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct PNOEJKCMJAK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Stack<T> PABPLDHKJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly ENPIAOLJNCN NBPAHNGGNLP;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x27376F0", Offset = "0x27364F0", VA = "0x1827376F0")]
	internal PNOEJKCMJAK(Stack<T> IPHILEOFJLB, ENPIAOLJNCN AGKGDFEFEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4CC4B60", Offset = "0x4CC3960", VA = "0x184CC4B60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
public sealed class GNFPFPHGAPI<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct GIBLAMPJNLE : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly GNFPFPHGAPI<T> IFFADEBAIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int GDOFIGKCPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly bool EAPHFLBKBHN;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x241ED70", Offset = "0x241DB70", VA = "0x18241ED70")]
		public GIBLAMPJNLE(GNFPFPHGAPI<T> MNCBDJMAFIF, int LFECLHNECLM, bool GAPEBAPGOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x44C2B10", Offset = "0x44C1910", VA = "0x1844C2B10")]
		public GNFPFPHGAPI<T>.HAKGBJEGLEM NAPBKLICNNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x44C2C00", Offset = "0x44C1A00", VA = "0x1844C2C00", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x44C2C00", Offset = "0x44C1A00", VA = "0x1844C2C00", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class HAKGBJEGLEM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly GNFPFPHGAPI<T> IFFADEBAIFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly int DOLGDGMILGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private int JFGKLPPOBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly bool EAPHFLBKBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool EJOFCDLHGPC;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public T ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x454CC50", Offset = "0x454BA50", VA = "0x18454CC50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x454CD80", Offset = "0x454BB80", VA = "0x18454CD80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x454CFA0", Offset = "0x454BDA0", VA = "0x18454CFA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x454D6C0", Offset = "0x454C4C0", VA = "0x18454D6C0")]
		public HAKGBJEGLEM(GNFPFPHGAPI<T> MNCBDJMAFIF, int LFECLHNECLM, bool GAPEBAPGOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x454CCD0", Offset = "0x454BAD0", VA = "0x18454CCD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x454CD60", Offset = "0x454BB60", VA = "0x18454CD60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class OOFCJPAFDEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OOFCJPAFDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4E57DB0", Offset = "0x4E56BB0", VA = "0x184E57DB0")]
		internal T HKOLEGPFFOA(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly T[] KPNMNDCMEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int JFGKLPPOBEB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int DJIPGHOGOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x450A5B0", Offset = "0x45093B0", VA = "0x18450A5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public T ABCAFDPDGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x437B7B0", Offset = "0x437A5B0", VA = "0x18437B7B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public T HGAKFPEEOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x450A4D0", Offset = "0x45092D0", VA = "0x18450A4D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x450A760", Offset = "0x4509560", VA = "0x18450A760")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2295CB0", Offset = "0x2294AB0", VA = "0x182295CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x18375D0", Offset = "0x18363D0", VA = "0x1818375D0")]
	private static int JJJCBKKHHGM(int KNCPCNBMDNF, int AIIKLGOLFIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x450A9C0", Offset = "0x45097C0", VA = "0x18450A9C0")]
	public GNFPFPHGAPI(int IECADCKMGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x450A800", Offset = "0x4509600", VA = "0x18450A800")]
	public GNFPFPHGAPI(int IECADCKMGOP, Func<T> CALCHMEIKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x450AB80", Offset = "0x4509980", VA = "0x18450AB80")]
	public GNFPFPHGAPI(T[] CMEOIDEONPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x450A7D0", Offset = "0x45095D0", VA = "0x18450A7D0")]
	public void PNCJGHGHNDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x450A410", Offset = "0x4509210", VA = "0x18450A410")]
	public IEnumerable<T> ADDFIHNHDEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x450A510", Offset = "0x4509310", VA = "0x18450A510")]
	public GNFPFPHGAPI<T>.HAKGBJEGLEM NAPBKLICNNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x445C150", Offset = "0x445AF50", VA = "0x18445C150", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x445C150", Offset = "0x445AF50", VA = "0x18445C150", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GMKOKIMIJDI
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x32B6550", Offset = "0x32B5350", VA = "0x1832B6550")]
	public static GNFPFPHGAPI<T> MKHEJJEDOII<T>(int IECADCKMGOP, Func<T> CALCHMEIKDK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class OHGNIKBLOCN<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct NKDCMEIPBNN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly OHGNIKBLOCN<T> PGOIHOLJLFO;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T HKHKCHJEPKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4D2F0E0", Offset = "0x4D2DEE0", VA = "0x184D2F0E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4D2F0B0", Offset = "0x4D2DEB0", VA = "0x184D2F0B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
		public NKDCMEIPBNN(OHGNIKBLOCN<T> PGOIHOLJLFO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ALHNHLLBODB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public AsyncTaskMethodBuilder<NKDCMEIPBNN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OHGNIKBLOCN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4527050", Offset = "0x4525E50", VA = "0x184527050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x44CAEF0", Offset = "0x44C9CF0", VA = "0x1844CAEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly SemaphoreSlim GAOCKAAMNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private T BFICKAGANDC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4E43980", Offset = "0x4E42780", VA = "0x184E43980")]
	public OHGNIKBLOCN([In] T BFICKAGANDC, int CBDBIBDFKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4E43750", Offset = "0x4E42550", VA = "0x184E43750")]
	public OHGNIKBLOCN([In] T BFICKAGANDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4E43230", Offset = "0x4E42030", VA = "0x184E43230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4E43290", Offset = "0x4E42090", VA = "0x184E43290")]
	public NKDCMEIPBNN KNJGOLHNJIJ()
	{
		return default(NKDCMEIPBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E433F0", Offset = "0x4E421F0", VA = "0x184E433F0")]
	[AsyncStateMachine(typeof(OHGNIKBLOCN<>.ALHNHLLBODB))]
	public Task<OHGNIKBLOCN<T>.NKDCMEIPBNN> OEBOFLFCNDB(CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E43270", Offset = "0x4E42070", VA = "0x184E43270")]
	public void JCNLFCDIICN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class OHFFDNMLPEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x738B9C0", Offset = "0x738A7C0", VA = "0x18738B9C0")]
	public static OHGNIKBLOCN<ENLEGHEGALI> MKHEJJEDOII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3161CF0", Offset = "0x3160AF0", VA = "0x183161CF0")]
	public static OHGNIKBLOCN<T> MKHEJJEDOII<T>([In] T BFICKAGANDC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class GAIFPODPIAP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct MPNNOEBPLCK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly GAIFPODPIAP<T> ONIMKGKLDPG;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public T HKHKCHJEPKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x44B5970", Offset = "0x44B4770", VA = "0x1844B5970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4CD6BF0", Offset = "0x4CD59F0", VA = "0x184CD6BF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
		internal MPNNOEBPLCK(GAIFPODPIAP<T> PGOIHOLJLFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct GFJOEHPMDCI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly GAIFPODPIAP<T> ONIMKGKLDPG;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public T HKHKCHJEPKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x44B5970", Offset = "0x44B4770", VA = "0x1844B5970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x44B5880", Offset = "0x44B4680", VA = "0x1844B5880", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
		internal GFJOEHPMDCI(GAIFPODPIAP<T> PGOIHOLJLFO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct JIKPBFEDMOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<GFJOEHPMDCI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public GAIFPODPIAP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private OHGNIKBLOCN<ENLEGHEGALI>.NKDCMEIPBNN <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<OHGNIKBLOCN<ENLEGHEGALI>.NKDCMEIPBNN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x48C68A0", Offset = "0x48C56A0", VA = "0x1848C68A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x44CAEF0", Offset = "0x44C9CF0", VA = "0x1844CAEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly OHGNIKBLOCN<int> EKJPDOBHDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OHGNIKBLOCN<ENLEGHEGALI> JKLPNFIKKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OHGNIKBLOCN<ENLEGHEGALI> NAGEPFKAPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private T JKJFCBNBALI;

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x44A0DA0", Offset = "0x449FBA0", VA = "0x1844A0DA0")]
	internal GAIFPODPIAP(OHGNIKBLOCN<int> PBGAPHLNONG, OHGNIKBLOCN<ENLEGHEGALI> HNHJEBABBHG, OHGNIKBLOCN<ENLEGHEGALI> EPDHFAGICHB, [In] T BFICKAGANDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x44A0510", Offset = "0x449F310", VA = "0x1844A0510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x44A0750", Offset = "0x449F550", VA = "0x1844A0750")]
	public MPNNOEBPLCK EJOFNMKAHAB()
	{
		return default(MPNNOEBPLCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x44A0BC0", Offset = "0x449F9C0", VA = "0x1844A0BC0")]
	public GFJOEHPMDCI NAJLPFPGFAP()
	{
		return default(GFJOEHPMDCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x44A00B0", Offset = "0x449EEB0", VA = "0x1844A00B0")]
	[AsyncStateMachine(typeof(GAIFPODPIAP<>.JIKPBFEDMOL))]
	public Task<GAIFPODPIAP<T>.GFJOEHPMDCI> BMNCGCHBFPH(CancellationToken FEHCANHDGHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KJOGJKCEINC
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x73894B0", Offset = "0x73882B0", VA = "0x1873894B0")]
	public static GAIFPODPIAP<ENLEGHEGALI> MKHEJJEDOII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x338D5E0", Offset = "0x338C3E0", VA = "0x18338D5E0")]
	public static GAIFPODPIAP<T> MKHEJJEDOII<T>([In] T BFICKAGANDC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class ENHENMDMEBO<TData> : MFMDDJMMGHP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly TData COGAKILOFHK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
	public override string KMIKCFPGPHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4003EC0", Offset = "0x4002CC0", VA = "0x184003EC0")]
	internal ENHENMDMEBO(string KKBJAPCBOHH, [In] TData JOAPLPPIFPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class LGINAMPFHON
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7389860", Offset = "0x7388660", VA = "0x187389860")]
	public static ENHENMDMEBO<ENLEGHEGALI> MKHEJJEDOII(string KKBJAPCBOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3100440", Offset = "0x30FF240", VA = "0x183100440")]
	public static ENHENMDMEBO<TData> MKHEJJEDOII<TData>(string KKBJAPCBOHH, [In] TData JOAPLPPIFPC) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class GAGNCLFMPKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal bool EAIIHFBNHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly string NFNJGLCEEEC;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xCD8AE0", Offset = "0xCD78E0", VA = "0x180CD8AE0")]
	private GAGNCLFMPKK(bool JMLNJICPAGL, string GNJOOHFNPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7389060", Offset = "0x7387E60", VA = "0x187389060")]
	public static GAGNCLFMPKK MKHEJJEDOII(string GNJOOHFNPMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x73890D0", Offset = "0x7387ED0", VA = "0x1873890D0")]
	public ENPIAOLJNCN OCJDMOMBDHH()
	{
		return default(ENPIAOLJNCN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct ENPIAOLJNCN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GAGNCLFMPKK FIFMHLBOICL;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	internal ENPIAOLJNCN(GAGNCLFMPKK MOBMLKIIAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7388F10", Offset = "0x7387D10", VA = "0x187388F10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[Obsolete("Use SimpleTokenFlag or WeakTokenFlag<T> instead")]
public sealed class KJCHFGEFOPE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MELNBHEEGDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MELNBHEEGDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4C95140", Offset = "0x4C93F40", VA = "0x184C95140")]
		internal int JOGCIDMOHDN(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private HashSet<T>? HMHMJJNIAMJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyCollection<T> BGPNPKLCFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x49C1520", Offset = "0x49C0320", VA = "0x1849C1520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CLNIBENAJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x49C1970", Offset = "0x49C0770", VA = "0x1849C1970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE10", Offset = "0x8F9C10", VA = "0x1808FAE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x49C17B0", Offset = "0x49C05B0", VA = "0x1849C17B0")]
	public bool MDGAONDGEMG(T HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x49C1560", Offset = "0x49C0360", VA = "0x1849C1560")]
	public bool IEINLEAGPOE(T HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x49C14D0", Offset = "0x49C02D0", VA = "0x1849C14D0")]
	public bool AMMEABLHNKI(T HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x49C16D0", Offset = "0x49C04D0", VA = "0x1849C16D0")]
	public void LLIIAOKDMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x49C19C0", Offset = "0x49C07C0", VA = "0x1849C19C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public KJCHFGEFOPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class LKPBNFNIBPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class PHPFMEDGKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PHPFMEDGKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x738BF20", Offset = "0x738AD20", VA = "0x18738BF20")]
		internal int JOGCIDMOHDN(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private HashSet<object>? HMHMJJNIAMJ;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IReadOnlyCollection<object> BGPNPKLCFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7389AE0", Offset = "0x73888E0", VA = "0x187389AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CLNIBENAJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7389D60", Offset = "0x7388B60", VA = "0x187389D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE10", Offset = "0x8F9C10", VA = "0x1808FAE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7389C80", Offset = "0x7388A80", VA = "0x187389C80")]
	public bool MDGAONDGEMG(object HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7389B70", Offset = "0x7388970", VA = "0x187389B70")]
	public bool IEINLEAGPOE(object HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7389A80", Offset = "0x7388880", VA = "0x187389A80")]
	public bool AMMEABLHNKI(object HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7389C10", Offset = "0x7388A10", VA = "0x187389C10")]
	public void LLIIAOKDMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7389D70", Offset = "0x7388B70", VA = "0x187389D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public LKPBNFNIBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class IBPJDCCBOAD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private struct EFLJHNJOEAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float PFEBOINBCHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public T HKHKCHJEPKB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Dictionary<object, EFLJHNJOEAJ> BLCDMBCGKIJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public virtual T LMHGFELDAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x16FB640", Offset = "0x16FA440", VA = "0x1816FB640", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x16FA1C0", Offset = "0x16F8FC0", VA = "0x1816FA1C0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public object? KFEMDAFDFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B30", Offset = "0x8F6930", VA = "0x1808F7B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OFOFOJHAONE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x46CD580", Offset = "0x46CC380", VA = "0x1846CD580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x46CDC10", Offset = "0x46CCA10", VA = "0x1846CDC10")]
	public bool MILLFGFJJFB(T IPHILEOFJLB, object HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x46CD4E0", Offset = "0x46CC2E0", VA = "0x1846CD4E0")]
	public bool LBFCCEACMDE(object HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3F8E190", Offset = "0x3F8CF90", VA = "0x183F8E190")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x46CD710", Offset = "0x46CC510", VA = "0x1846CD710")]
	public bool MHAMFDPPPMK(object HACFGBHNOCC, [Out] T IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x46CBCE0", Offset = "0x46CAAE0", VA = "0x1846CBCE0")]
	[NPOJMFOGALI("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool KLBOLHNIBGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x46CE330", Offset = "0x46CD130", VA = "0x1846CE330")]
	public IBPJDCCBOAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class AMGCBJDGBGM : EGLNCPIIHNB<LNJPDINAFGA>
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	internal class EFHKFANOAEA : IEqualityComparer<LNJPDINAFGA>
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		internal static readonly EFHKFANOAEA GGJCMHODIEM;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7388E10", Offset = "0x7387C10", VA = "0x187388E10", Slot = "4")]
		public bool Equals(LNJPDINAFGA LBONEMFCDEA, LNJPDINAFGA IOKFBHNPJAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x666B020", Offset = "0x6669E20", VA = "0x18666B020", Slot = "5")]
		public int GetHashCode(LNJPDINAFGA JOOHPPHJKMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EFHKFANOAEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x73889D0", Offset = "0x73877D0", VA = "0x1873889D0")]
	public AMGCBJDGBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7388890", Offset = "0x7387690", VA = "0x187388890", Slot = "4")]
	public override bool MDGAONDGEMG(LNJPDINAFGA HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x73887E0", Offset = "0x73875E0", VA = "0x1873887E0", Slot = "5")]
	public override bool IEINLEAGPOE(LNJPDINAFGA HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7388940", Offset = "0x7387740", VA = "0x187388940")]
	private static void OCLKMAEHBND(LNJPDINAFGA HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x16024F0", Offset = "0x16012F0", VA = "0x1816024F0", Slot = "6")]
	protected override string HKKFIGGFCMA(LNJPDINAFGA HACFGBHNOCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class LNJPDINAFGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly string EPLJEDHKMBA;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public LNJPDINAFGA(string EPLJEDHKMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7389F20", Offset = "0x7388D20", VA = "0x187389F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class EGLNCPIIHNB<T> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly IEqualityComparer<T> LKDCBGBNMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private HashSet<T>? HMHMJJNIAMJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CLNIBENAJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3FDEE70", Offset = "0x3FDDC70", VA = "0x183FDEE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xB4A980", Offset = "0xB49780", VA = "0x180B4A980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3FDF1A0", Offset = "0x3FDDFA0", VA = "0x183FDF1A0")]
	internal EGLNCPIIHNB(IEqualityComparer<T> LKDCBGBNMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3FDECA0", Offset = "0x3FDDAA0", VA = "0x183FDECA0", Slot = "4")]
	public virtual bool MDGAONDGEMG(T HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3FDEA50", Offset = "0x3FDD850", VA = "0x183FDEA50", Slot = "5")]
	public virtual bool IEINLEAGPOE(T HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3FDEBC0", Offset = "0x3FDD9C0", VA = "0x183FDEBC0")]
	public void LLIIAOKDMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract string HKKFIGGFCMA(T HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3FDEEB0", Offset = "0x3FDDCB0", VA = "0x183FDEEB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class GJJMJJCAJKH<T> where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<WeakReference<T>>? HMHMJJNIAMJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CLNIBENAJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x44CA3A0", Offset = "0x44C91A0", VA = "0x1844CA3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x44C9DB0", Offset = "0x44C8BB0", VA = "0x1844C9DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x44CA130", Offset = "0x44C8F30", VA = "0x1844CA130")]
	public void MDGAONDGEMG(T HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x44C9F50", Offset = "0x44C8D50", VA = "0x1844C9F50")]
	public void IEINLEAGPOE(T HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x44CA0F0", Offset = "0x44C8EF0", VA = "0x1844CA0F0")]
	public void LLIIAOKDMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x44CA4C0", Offset = "0x44C92C0", VA = "0x1844CA4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public GJJMJJCAJKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal static class GKOOCNNHFFN
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x32B5B10", Offset = "0x32B4910", VA = "0x1832B5B10")]
	public static void PENIHPJNMJH<T>(this List<T> BJCKKCNKPEK, int KNCPCNBMDNF) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class DAFBMPAJEHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<object, float> BLCDMBCGKIJ;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public float CNIMGEEOEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xD9F810", Offset = "0xD9E610", VA = "0x180D9F810")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xD9F820", Offset = "0xD9E620", VA = "0x180D9F820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7388BE0", Offset = "0x73879E0", VA = "0x187388BE0")]
	public void MILLFGFJJFB(float IPHILEOFJLB, object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7388B70", Offset = "0x7387970", VA = "0x187388B70")]
	public void LBFCCEACMDE(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7388C50", Offset = "0x7387A50", VA = "0x187388C50")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7388A40", Offset = "0x7387840", VA = "0x187388A40")]
	private void ILCBCBFHCHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7388CA0", Offset = "0x7387AA0", VA = "0x187388CA0")]
	public DAFBMPAJEHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface HNGNINPDPHG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event PCMAJNECMBE NFBIIFHINHC;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class MCPOMHOMLBH : HNGNINPDPHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public readonly struct LDKOAGKNGGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly float ODCOABNFDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly float CHGKKDHAAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		internal readonly bool JJCPGCBCCEF;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float JCGPAOIEEDH
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x7389580", Offset = "0x7388380", VA = "0x187389580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7389700", Offset = "0x7388500", VA = "0x187389700")]
		public LDKOAGKNGGA(float EBKPEOBONHB, float GJDJJJOJIJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7389590", Offset = "0x7388390", VA = "0x187389590", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class NMAIKFLOBDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public MCPOMHOMLBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NMAIKFLOBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x738AFB0", Offset = "0x7389DB0", VA = "0x18738AFB0")]
		internal void ADJFAPHNEJH(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly int MLAKJOPIGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private int FDNMPHFHFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly HNGNINPDPHG[] HGFFDBHKLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly PCMAJNECMBE[] BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly LDKOAGKNGGA[] PFIEPLCPMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private LDKOAGKNGGA HBHKELGKCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly AGMBFHBBGEH JFGMDKIOLKN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event PCMAJNECMBE NFBIIFHINHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x738A590", Offset = "0x7389390", VA = "0x18738A590", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x738A650", Offset = "0x7389450", VA = "0x18738A650", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x738A710", Offset = "0x7389510", VA = "0x18738A710")]
	public MCPOMHOMLBH(int MLAKJOPIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7389F70", Offset = "0x7388D70", VA = "0x187389F70")]
	public AGMBFHBBGEH BNPAFNIPACH(LDKOAGKNGGA OIHMOLOEHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x738A000", Offset = "0x7388E00", VA = "0x18738A000")]
	public void DNCAKLIBJDE(HNGNINPDPHG GBCCMNDBBKF, [Optional] LDKOAGKNGGA JOFCDMLFAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x738A480", Offset = "0x7389280", VA = "0x18738A480", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public delegate void PCMAJNECMBE(float OCOHPHKFBOI);
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FAANFMIICPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class DCIEOGNMHDH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly HNGNINPDPHG BFKHOOHDKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly PCMAJNECMBE JMGOMJNPFIN;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7388D80", Offset = "0x7387B80", VA = "0x187388D80")]
		public DCIEOGNMHDH(HNGNINPDPHG BFKHOOHDKLE, PCMAJNECMBE JMGOMJNPFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7388D30", Offset = "0x7387B30", VA = "0x187388D30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7388F30", Offset = "0x7387D30", VA = "0x187388F30")]
	internal static bool HBEIGCGDKGC(float HJGGLHBFMKO, float AGAPPIBJJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7376810", Offset = "0x7375610", VA = "0x187376810")]
	internal static float OIBEPDNCFJH(float HJGGLHBFMKO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7388FA0", Offset = "0x7387DA0", VA = "0x187388FA0")]
	public static IDisposable OPIBHCIONPH(this HNGNINPDPHG BFKHOOHDKLE, PCMAJNECMBE JMGOMJNPFIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class AGMBFHBBGEH : HNGNINPDPHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private float OCOHPHKFBOI;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float ENKFDHFEMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x73886F0", Offset = "0x73874F0", VA = "0x1873886F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event PCMAJNECMBE? NFBIIFHINHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x73885B0", Offset = "0x73873B0", VA = "0x1873885B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7388650", Offset = "0x7387450", VA = "0x187388650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public AGMBFHBBGEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface LCALMGBPCHO<T> where T : class, new()
{
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FOADNFIJBGK<T> ECBHJOIKIMH([Out] T IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCEIDOKFHPG();
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class JMPMKDDHJEO<T> : LCALMGBPCHO<T> where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly ConcurrentStack<T> FPGPAMDLGDL;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x48D3DC0", Offset = "0x48D2BC0", VA = "0x1848D3DC0", Slot = "4")]
	public FOADNFIJBGK<T> ECBHJOIKIMH([Out] T IPHILEOFJLB)
	{
		return default(FOADNFIJBGK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x48D3E60", Offset = "0x48D2C60", VA = "0x1848D3E60")]
	public void PBAOHHFJIIL(T EAGDCDCLPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x44D1270", Offset = "0x44D0070", VA = "0x1844D1270", Slot = "5")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "6")]
	protected virtual void NGEIEMBAOEE(T BKIGMHIAKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x48D3D20", Offset = "0x48D2B20", VA = "0x1848D3D20")]
	private T ANFJBBFMPMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x48D3EE0", Offset = "0x48D2CE0", VA = "0x1848D3EE0")]
	public JMPMKDDHJEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public readonly struct FOADNFIJBGK<T> : IDisposable where T : class, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly T EAGDCDCLPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly JMPMKDDHJEO<T> AEDLDLDGAAC;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
	internal FOADNFIJBGK(T IPHILEOFJLB, JMPMKDDHJEO<T> AEDLDLDGAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x43D20A0", Offset = "0x43D0EA0", VA = "0x1843D20A0", Slot = "4")]
	void IDisposable.Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LILIIAJDMBI : JMPMKDDHJEO<StringBuilder>
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly LILIIAJDMBI GGJCMHODIEM;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x73898E0", Offset = "0x73886E0", VA = "0x1873898E0")]
	public static FOADNFIJBGK<StringBuilder> ANFJBBFMPMK([Out] StringBuilder IPHILEOFJLB)
	{
		return default(FOADNFIJBGK<StringBuilder>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7389980", Offset = "0x7388780", VA = "0x187389980", Slot = "6")]
	protected override void NGEIEMBAOEE(StringBuilder BKIGMHIAKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7389A40", Offset = "0x7388840", VA = "0x187389A40")]
	public LILIIAJDMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class MALGCLMEIKD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6D46700", Offset = "0x6D45500", VA = "0x186D46700")]
	public MALGCLMEIKD(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DefaultMember("Item")]
public class IEFHNLIILPH<TKey, TValue> : IEMCLDOBHFK<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, FINPKGLHLOI where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class CFFFDFICLGB : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public IEFHNLIILPH<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x16FB640", Offset = "0x16FA440", VA = "0x1816FB640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x58691A0", Offset = "0x5867FA0", VA = "0x1858691A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public CFFFDFICLGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4355D40", Offset = "0x4354B40", VA = "0x184355D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x58687D0", Offset = "0x58675D0", VA = "0x1858687D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5868230", Offset = "0x5867030", VA = "0x185868230")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5868280", Offset = "0x5867080", VA = "0x185868280")]
		private void HHOEFEHKFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x5869150", Offset = "0x5867F50", VA = "0x185869150", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly IEMCLDOBHFK<TKey, TValue> EEDLBFNJKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly IDictionary<TKey, TValue> JLNNOKOGDHM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x46D7B60", Offset = "0x46D6960", VA = "0x1846D7B60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HPHENKFIHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public TValue FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x46D7D40", Offset = "0x46D6B40", VA = "0x1846D7D40", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x46D8010", Offset = "0x46D6E10", VA = "0x1846D8010", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public ICollection<TKey> DCFFKNPGHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x46D7D90", Offset = "0x46D6B90", VA = "0x1846D7D90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICollection<TValue> EGMHGJAMKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x46D7EB0", Offset = "0x46D6CB0", VA = "0x1846D7EB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x46D79D0", Offset = "0x46D67D0", VA = "0x1846D79D0")]
	public IEFHNLIILPH(IEMCLDOBHFK<TKey, TValue> EEDLBFNJKIJ, [Optional] IDictionary<TKey, TValue>? JLNNOKOGDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x46D55C0", Offset = "0x46D43C0", VA = "0x1846D55C0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x46D6D20", Offset = "0x46D5B20", VA = "0x1846D6D20")]
	public void PNGAKINGJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x46D4D20", Offset = "0x46D3B20", VA = "0x1846D4D20", Slot = "9")]
	public void Add(TKey FFOHLCGHDKA, TValue IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x46D5F70", Offset = "0x46D4D70", VA = "0x1846D5F70")]
	public void EKCDNJAEJNJ(TKey FFOHLCGHDKA, TValue IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x46D65D0", Offset = "0x46D53D0", VA = "0x1846D65D0")]
	public void IPHNEPHHLDI(TKey FFOHLCGHDKA, TValue IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x46D69C0", Offset = "0x46D57C0", VA = "0x1846D69C0")]
	public void MCFJOGMFPMN(TKey FFOHLCGHDKA, TValue IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x46D62B0", Offset = "0x46D50B0", VA = "0x1846D62B0")]
	public void FINLGFAJMFE(TKey FFOHLCGHDKA, TValue IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x46D6FD0", Offset = "0x46D5DD0", VA = "0x1846D6FD0", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x46D7200", Offset = "0x46D6000", VA = "0x1846D7200", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x46D73C0", Offset = "0x46D61C0", VA = "0x1846D73C0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x46D5700", Offset = "0x46D4500", VA = "0x1846D5700", Slot = "8")]
	public bool ContainsKey(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x46D5220", Offset = "0x46D4020", VA = "0x1846D5220")]
	public bool BCBLOPELMBB(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x46D6760", Offset = "0x46D5560", VA = "0x1846D6760")]
	public bool KFKPMLKJJAM(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x46D6E30", Offset = "0x46D5C30", VA = "0x1846D6E30", Slot = "10")]
	public bool Remove(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x46D7830", Offset = "0x46D6630", VA = "0x1846D7830", Slot = "11")]
	public bool TryGetValue(TKey FFOHLCGHDKA, [Out] TValue IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x46D57C0", Offset = "0x46D45C0", VA = "0x1846D57C0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] EOOCBMPNEML, int FJBNAIEDHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x46D7720", Offset = "0x46D6520", VA = "0x1846D7720", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x46D6450", Offset = "0x46D5250", VA = "0x1846D6450", Slot = "19")]
	[IteratorStateMachine(typeof(IEFHNLIILPH<, >.CFFFDFICLGB))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x46D5E80", Offset = "0x46D4C80", VA = "0x1846D5E80", Slot = "21")]
	public bool DJOCBDOJMNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x46D52E0", Offset = "0x46D40E0", VA = "0x1846D52E0")]
	private TValue BDOJBPKGFEH(TKey FFOHLCGHDKA)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface FINPKGLHLOI
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DJOCBDOJMNK();
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface IEMCLDOBHFK<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FINPKGLHLOI
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public sealed class ECKFKDNALJK<TKey, TVal> : IEMCLDOBHFK<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, FINPKGLHLOI where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate int CHJDAOMLKOP(TKey FFOHLCGHDKA, TVal IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate void BFLDECMNFHG(TKey FFOHLCGHDKA, TVal IPHILEOFJLB, MPDAKHGFNDF ADJDIHDFFBH);

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private class OMGCHMIOLGD
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public TKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xB21E50", Offset = "0xB20C50", VA = "0x180B21E50")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public TVal HKHKCHJEPKB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xB4A980", Offset = "0xB49780", VA = "0x180B4A980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int JCGPAOIEEDH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x935800", Offset = "0x934600", VA = "0x180935800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x9353A0", Offset = "0x9341A0", VA = "0x1809353A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public DateTimeOffset OLCCKALHMIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x10D98B0", Offset = "0x10D86B0", VA = "0x1810D98B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x10D98C0", Offset = "0x10D86C0", VA = "0x1810D98C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E4DA50", Offset = "0x4E4C850", VA = "0x184E4DA50")]
		public OMGCHMIOLGD(TKey FFOHLCGHDKA, TVal OAJCPHOOFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class IAIOPIPJDGI : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public ECKFKDNALJK<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private LinkedList<OMGCHMIOLGD>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x16FB640", Offset = "0x16FA440", VA = "0x1816FB640", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x46C6560", Offset = "0x46C5360", VA = "0x1846C6560", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public IAIOPIPJDGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x43522B0", Offset = "0x43510B0", VA = "0x1843522B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x46C6110", Offset = "0x46C4F10", VA = "0x1846C6110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x46C5AA0", Offset = "0x46C48A0", VA = "0x1846C5AA0")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x46C6420", Offset = "0x46C5220", VA = "0x1846C6420", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public const int MKEBMBOCIAD = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<TKey, LinkedListNode<OMGCHMIOLGD>> KPGCEJGNLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<OMGCHMIOLGD> DOLNJOHMKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CHJDAOMLKOP? CPIGODGPICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly TimeSpan AKKPCGCHMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly BFLDECMNFHG? DGJEHECFJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly NEJIHKJGMOP EMLPBBOLNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool OHBCCOKGMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly List<TKey> OOPFIBBCFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<TVal> NNICCJNGCMD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int EONCJEIOJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x905060", Offset = "0x903E60", VA = "0x180905060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	internal int MCGGALMPJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xAA79C0", Offset = "0xAA67C0", VA = "0x180AA79C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xAA79A0", Offset = "0xAA67A0", VA = "0x180AA79A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F99B10", Offset = "0x3F98910", VA = "0x183F99B10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal int BMEKBHGCGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F8E190", Offset = "0x3F8CF90", VA = "0x183F8E190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ICollection<TVal> EGMHGJAMKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F99C90", Offset = "0x3F98A90", VA = "0x183F99C90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ICollection<TKey> IDictionary<TKey, TVal>.AIIANHGGDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F94370", Offset = "0x3F93170", VA = "0x183F94370", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HPHENKFIHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public TVal FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3F99BE0", Offset = "0x3F989E0", VA = "0x183F99BE0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F99D20", Offset = "0x3F98B20", VA = "0x183F99D20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D9B0", Offset = "0x3F8C7B0", VA = "0x183F8D9B0")]
	private bool EBIDMIOAOKA(int MLAKJOPIGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3F8DA00", Offset = "0x3F8C800", VA = "0x183F8DA00")]
	private void GHPBOANDMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3F97570", Offset = "0x3F96370", VA = "0x183F97570")]
	public ECKFKDNALJK(int MLAKJOPIGGN, [Optional] CHJDAOMLKOP? CPIGODGPICP, [Optional] IEqualityComparer<TKey>? CMONDDCHEIN, [Optional] BFLDECMNFHG? DGJEHECFJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3F95BA0", Offset = "0x3F949A0", VA = "0x183F95BA0")]
	public ECKFKDNALJK(TimeSpan AKKPCGCHMFL, [Optional] IEqualityComparer<TKey>? CMONDDCHEIN, [Optional] BFLDECMNFHG? DGJEHECFJGA, [Optional] NEJIHKJGMOP? EMLPBBOLNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3F956C0", Offset = "0x3F944C0", VA = "0x183F956C0")]
	public ECKFKDNALJK(int MLAKJOPIGGN, TimeSpan AKKPCGCHMFL, [Optional] IEqualityComparer<TKey>? CMONDDCHEIN, [Optional] BFLDECMNFHG? DGJEHECFJGA, [Optional] NEJIHKJGMOP? EMLPBBOLNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3F95740", Offset = "0x3F94540", VA = "0x183F95740")]
	public ECKFKDNALJK(int MLAKJOPIGGN, CHJDAOMLKOP? CPIGODGPICP, TimeSpan AKKPCGCHMFL, [Optional] IEqualityComparer<TKey>? CMONDDCHEIN, [Optional] BFLDECMNFHG? DGJEHECFJGA, [Optional] NEJIHKJGMOP? EMLPBBOLNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D910", Offset = "0x3F8C710", VA = "0x183F8D910", Slot = "21")]
	public bool DJOCBDOJMNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3F91300", Offset = "0x3F90100", VA = "0x183F91300", Slot = "22")]
	public bool NHAFMCCPMFE(int IECADCKMGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3F80D90", Offset = "0x3F7FB90", VA = "0x183F80D90")]
	private bool CKGMEHKCDHJ(int IECADCKMGOP, MPDAKHGFNDF ADJDIHDFFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3F8D7D0", Offset = "0x3F8C5D0", VA = "0x183F8D7D0")]
	public void DJKOKNNCNMK(TKey FFOHLCGHDKA, TVal IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3F7DEC0", Offset = "0x3F7CCC0", VA = "0x183F7DEC0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3F7D510", Offset = "0x3F7C310", VA = "0x183F7D510", Slot = "9")]
	public void Add(TKey FFOHLCGHDKA, TVal IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3F84AA0", Offset = "0x3F838A0", VA = "0x183F84AA0", Slot = "8")]
	public bool ContainsKey(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3F93B00", Offset = "0x3F92900", VA = "0x183F93B00", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3F934B0", Offset = "0x3F922B0", VA = "0x183F934B0", Slot = "10")]
	public bool Remove(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3F93EC0", Offset = "0x3F92CC0", VA = "0x183F93EC0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3F915C0", Offset = "0x3F903C0", VA = "0x183F915C0")]
	private bool PJENCCPHFEL(TKey FFOHLCGHDKA, [Out] TVal IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3F7C5E0", Offset = "0x3F7B3E0", VA = "0x183F7C5E0")]
	private TVal ANFJBBFMPMK(TKey PADNBEPNLIP)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3F953E0", Offset = "0x3F941E0", VA = "0x183F953E0", Slot = "11")]
	public bool TryGetValue(TKey PADNBEPNLIP, [Out] TVal IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F84810", Offset = "0x3F83610", VA = "0x183F84810", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3F87110", Offset = "0x3F85F10", VA = "0x183F87110", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EOOCBMPNEML, int FJBNAIEDHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3F88620", Offset = "0x3F87420", VA = "0x183F88620")]
	private void DENGJPEGDMA(TKey FFOHLCGHDKA, TVal OAJCPHOOFGC, MPDAKHGFNDF ADJDIHDFFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F7E900", Offset = "0x3F7D700", VA = "0x183F7E900")]
	private bool CGKLGGKEOGA(OMGCHMIOLGD BNPBIDMKGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B870", Offset = "0x3F8A670", VA = "0x183F8B870")]
	private void DHFGEMIBKCL(LinkedListNode<OMGCHMIOLGD> AAEGNOJBKJH, TVal PIOEIDCNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3F8EF80", Offset = "0x3F8DD80", VA = "0x183F8EF80")]
	private void MILLFGFJJFB(TKey FFOHLCGHDKA, TVal IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3F7BD60", Offset = "0x3F7AB60", VA = "0x183F7BD60")]
	private void ALOIELPIKCD(OMGCHMIOLGD BNPBIDMKGKH, TVal PIOEIDCNELN, int KIKANACJFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3F8DF80", Offset = "0x3F8CD80", VA = "0x183F8DF80", Slot = "19")]
	[IteratorStateMachine(typeof(ECKFKDNALJK<, >.IAIOPIPJDGI))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3F943C0", Offset = "0x3F931C0", VA = "0x183F943C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public enum MPDAKHGFNDF : byte
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
public class ALEMKFBCENG<TKey> : Exception where TKey : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public readonly TKey GLOJBAECGAL;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4525FA0", Offset = "0x4524DA0", VA = "0x184525FA0")]
	public ALEMKFBCENG(TKey EKFJMIIMNBP, Exception KHOADBPHPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class KFAGKBCGBLJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x65F6930", Offset = "0x65F5730", VA = "0x1865F6930")]
	public KFAGKBCGBLJ(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DJBHOJIJLJO<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class OHBCHHOCLIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public DJBHOJIJLJO<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public OHBCHHOCLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4E42F50", Offset = "0x4E41D50", VA = "0x184E42F50")]
		internal Task<TResource> FFCIAIILGNO(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private struct KFMLNGDCCOP : IAsyncStateMachine
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
		public DJBHOJIJLJO<TId, TResource> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter<TResource> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x49A9CF0", Offset = "0x49A8AF0", VA = "0x1849A9CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x49AA990", Offset = "0x49A9790", VA = "0x1849AA990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct JLBMOOJKJKG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x48D1000", Offset = "0x48CFE00", VA = "0x1848D1000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x48D19C0", Offset = "0x48D07C0", VA = "0x1848D19C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly OINOAHFNHGC<TId, Task<TResource>> INCGLDKMCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> MODKHBPLJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? EIKPNJOPPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly Action<TResource>? JAEPGKKGCPN;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x610D5B0", Offset = "0x610C3B0", VA = "0x18610D5B0")]
	public DJBHOJIJLJO(int JODNHNBMFGB = 0, [Optional] IEqualityComparer<TId>? GHHHOHMNMHN, [Optional] Func<TId, CancellationToken, Task<TResource>>? IJCGOJFLGGH, [Optional] Action<TResource>? IHLDLGIEGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x610C170", Offset = "0x610AF70", VA = "0x18610C170")]
	public DHBMCMEBKMG<Task<TResource>> BNADELAIFIP(TId MIFPCBFGGLI, [Optional] Func<TId, CancellationToken, Task<TResource>>? IJCGOJFLGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x610CBC0", Offset = "0x610B9C0", VA = "0x18610CBC0")]
	private void NKDMBLAIKCO(Task<TResource> BDCCICFJHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x610C530", Offset = "0x610B330", VA = "0x18610C530")]
	[AsyncStateMachine(typeof(DJBHOJIJLJO<, >.KFMLNGDCCOP))]
	private Task MJKDMPMKCFB(Task<TResource> BDCCICFJHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4D3CC80", Offset = "0x4D3BA80", VA = "0x184D3CC80")]
	public void DBNFEHEBFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x610C9B0", Offset = "0x610B7B0", VA = "0x18610C9B0")]
	public OINOAHFNHGC<TId, Task<TResource>>.CPCLEJIMBDM NAPBKLICNNH()
	{
		return default(OINOAHFNHGC<TId, Task<TResource>>.CPCLEJIMBDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x610D3E0", Offset = "0x610C1E0", VA = "0x18610D3E0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x610D3E0", Offset = "0x610C1E0", VA = "0x18610D3E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x610CF20", Offset = "0x610BD20", VA = "0x18610CF20")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(DJBHOJIJLJO<, >.JLBMOOJKJKG))]
	internal static Task PFJNNBCGCHP(Task<TResource> BDCCICFJHCL, CancellationTokenSource AKBBMCGDFBN, Dictionary<Task<TResource>, CancellationTokenSource> AADJLNGCCJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OINOAHFNHGC<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private sealed class ELHLHFHHLFJ : IEquatable<ELHLHFHHLFJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly TValue HKHKCHJEPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public int CCDLGNKGOEC;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xFB9DC0", Offset = "0xFB8BC0", VA = "0x180FB9DC0")]
		public ELHLHFHHLFJ(TValue IPHILEOFJLB, int IOPDPEKOFOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3FF83B0", Offset = "0x3FF71B0", VA = "0x183FF83B0", Slot = "4")]
		public bool Equals(ELHLHFHHLFJ? LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8440", Offset = "0x3FF7240", VA = "0x183FF8440", Slot = "0")]
		public override bool Equals(object? JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8690", Offset = "0x3FF7490", VA = "0x183FF8690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct CPCLEJIMBDM : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Dictionary<TKey, ELHLHFHHLFJ>.Enumerator EKHDCNBFLPL;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x5A562C0", Offset = "0x5A550C0", VA = "0x185A562C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public (TKey Key, TValue Value, int RefCount) ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x5A56680", Offset = "0x5A55480", VA = "0x185A56680", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5A564E0", Offset = "0x5A552E0", VA = "0x185A564E0")]
		public CPCLEJIMBDM(OINOAHFNHGC<TKey, TValue> BLCDMBCGKIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5A55E80", Offset = "0x5A54C80", VA = "0x185A55E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5A55EC0", Offset = "0x5A54CC0", VA = "0x185A55EC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5A560D0", Offset = "0x5A54ED0", VA = "0x185A560D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class PCODFAIHGHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public OINOAHFNHGC<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public ELHLHFHHLFJ refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PCODFAIHGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4F075A0", Offset = "0x4F063A0", VA = "0x184F075A0")]
		internal void FFCIAIILGNO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Dictionary<TKey, ELHLHFHHLFJ> AIBBCOLLAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Func<TKey, TValue>? NBEANLONDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly Action<TValue>? ENOMKBDCGDI;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4E48480", Offset = "0x4E47280", VA = "0x184E48480")]
	public OINOAHFNHGC(int JODNHNBMFGB = 0, [Optional] IEqualityComparer<TKey>? CMONDDCHEIN, [Optional] Func<TKey, TValue>? NGHBOJLOOJH, [Optional] Action<TValue>? FKPPJDOBMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E46EC0", Offset = "0x4E45CC0", VA = "0x184E46EC0")]
	public DHBMCMEBKMG<TValue> BNADELAIFIP(TKey FFOHLCGHDKA, [Optional] Func<TKey, TValue>? MHAPIBNDBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4E47F10", Offset = "0x4E46D10", VA = "0x184E47F10")]
	private void PBAOHHFJIIL(TKey FFOHLCGHDKA, ELHLHFHHLFJ ECGCGNGOPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4E477D0", Offset = "0x4E465D0", VA = "0x184E477D0")]
	public void DBNFEHEBFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4E47E90", Offset = "0x4E46C90", VA = "0x184E47E90")]
	public CPCLEJIMBDM NAPBKLICNNH()
	{
		return default(CPCLEJIMBDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4E482B0", Offset = "0x4E470B0", VA = "0x184E482B0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E482B0", Offset = "0x4E470B0", VA = "0x184E482B0", Slot = "5")]
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
