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

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x609DFA0", Offset = "0x609CDA0", VA = "0x18609DFA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CFKPGCEBFED
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	protected CFKPGCEBFED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class AHIOLIBHANN<T> : CFKPGCEBFED
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	protected struct OJGLLEGMALG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum ECPOIHMAHPN
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
		public ECPOIHMAHPN HFFNCGFKMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public T ENHEBPDFNME;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private int KBCFCOMPOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool LPFJEFGKLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly bool JIGGHECGMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	protected List<T>? DMJFBPKNGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<OJGLLEGMALG>? JLCFAJELGNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FMEHIOPNNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x367B0E0", Offset = "0x3679EE0", VA = "0x18367B0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x367B380", Offset = "0x367A180", VA = "0x18367B380")]
	protected AHIOLIBHANN(bool JIGGHECGMGF, bool LPFJEFGKLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x367B130", Offset = "0x3679F30", VA = "0x18367B130")]
	protected bool EMIDBALBDIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x367AFE0", Offset = "0x3679DE0", VA = "0x18367AFE0")]
	protected void BMGBDBOIOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x367AAA0", Offset = "0x36798A0", VA = "0x18367AAA0")]
	protected void ADKGCFEDPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22432C0", Offset = "0x22420C0", VA = "0x1822432C0")]
	private static void MPFJCLJNBJE<U>(List<U>? FOKGGJDBEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x367AC80", Offset = "0x3679A80", VA = "0x18367AC80", Slot = "4")]
	public void ANMBPKAMKOK(T ENHEBPDFNME, bool NFBJFIMEDKB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x367B1D0", Offset = "0x3679FD0", VA = "0x18367B1D0", Slot = "5")]
	public void JJGPDDBMEBN(T ENHEBPDFNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x367AE60", Offset = "0x3679C60", VA = "0x18367AE60")]
	public void BBGCGJHDDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KOCBIDFICIE
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANMBPKAMKOK(Action ENHEBPDFNME, bool NFBJFIMEDKB = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJGPDDBMEBN(Action ENHEBPDFNME);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class BHHPLLLFBGO : AHIOLIBHANN<Action>, KOCBIDFICIE
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x609B7B0", Offset = "0x609A5B0", VA = "0x18609B7B0")]
	public BHHPLLLFBGO(bool JIGGHECGMGF = false, bool LPFJEFGKLCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x609B550", Offset = "0x609A350", VA = "0x18609B550")]
	public void EIPDNFJIBDM()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x609B750", Offset = "0x609A550", VA = "0x18609B750")]
	public static BHHPLLLFBGO FKIIBOICILH(BHHPLLLFBGO NMJPFIEPAGH, Action ENHEBPDFNME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x609B4F0", Offset = "0x609A2F0", VA = "0x18609B4F0")]
	public static BHHPLLLFBGO AOAJJLHDPJD(BHHPLLLFBGO NMJPFIEPAGH, Action ENHEBPDFNME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AEKCEACIMCG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANMBPKAMKOK(Action<T> ENHEBPDFNME, bool NFBJFIMEDKB = false);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJGPDDBMEBN(Action<T> ENHEBPDFNME);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class EOPEMIILONN<T> : AHIOLIBHANN<Action<T>>, AEKCEACIMCG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3257860", Offset = "0x3256660", VA = "0x183257860")]
	public EOPEMIILONN(bool JIGGHECGMGF = false, bool LPFJEFGKLCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x32627D0", Offset = "0x32615D0", VA = "0x1832627D0")]
	public void EIPDNFJIBDM(T GBMCNPIMCLE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x32577D0", Offset = "0x32565D0", VA = "0x1832577D0")]
	public static EOPEMIILONN<T> FKIIBOICILH(EOPEMIILONN<T> NMJPFIEPAGH, Action<T> ENHEBPDFNME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3256B40", Offset = "0x3255940", VA = "0x183256B40")]
	public static EOPEMIILONN<T> AOAJJLHDPJD(EOPEMIILONN<T> NMJPFIEPAGH, Action<T> ENHEBPDFNME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CBEGLMPADEH<T, U> where T : notnull where U : notnull
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FOEHHLKMAJF<T, U> : AHIOLIBHANN<Action<T, U>>, CBEGLMPADEH<T, U> where T : notnull where U : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3257860", Offset = "0x3256660", VA = "0x183257860")]
	public FOEHHLKMAJF(bool JIGGHECGMGF = false, bool LPFJEFGKLCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x35E4820", Offset = "0x35E3620", VA = "0x1835E4820")]
	public void EIPDNFJIBDM(T GBMCNPIMCLE, U LDDFEDEOICJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x32577D0", Offset = "0x32565D0", VA = "0x1832577D0")]
	public static FOEHHLKMAJF<T, U> FKIIBOICILH(FOEHHLKMAJF<T, U> NMJPFIEPAGH, Action<T, U> ENHEBPDFNME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3256B40", Offset = "0x3255940", VA = "0x183256B40")]
	public static FOEHHLKMAJF<T, U> AOAJJLHDPJD(FOEHHLKMAJF<T, U> NMJPFIEPAGH, Action<T, U> ENHEBPDFNME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class BHDPFIKFABK<T, U, V> : AHIOLIBHANN<Action<T, U, V>> where T : notnull where U : notnull where V : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3257860", Offset = "0x3256660", VA = "0x183257860")]
	public BHDPFIKFABK(bool JIGGHECGMGF = false, bool LPFJEFGKLCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x467EA60", Offset = "0x467D860", VA = "0x18467EA60")]
	public void EIPDNFJIBDM(T GBMCNPIMCLE, U LDDFEDEOICJ, V HHLJIMLHKAO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x32577D0", Offset = "0x32565D0", VA = "0x1832577D0")]
	public static BHDPFIKFABK<T, U, V> FKIIBOICILH(BHDPFIKFABK<T, U, V> NMJPFIEPAGH, Action<T, U, V> ENHEBPDFNME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3256B40", Offset = "0x3255940", VA = "0x183256B40")]
	public static BHDPFIKFABK<T, U, V> AOAJJLHDPJD(BHDPFIKFABK<T, U, V> NMJPFIEPAGH, Action<T, U, V> ENHEBPDFNME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HHHNGLHPGIG<T, U, V, W>
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JAPMJPEGFDC<T, U, V, W> : AHIOLIBHANN<Action<T, U, V, W>>, HHHNGLHPGIG<T, U, V, W> where T : notnull where U : notnull where V : notnull where W : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3257860", Offset = "0x3256660", VA = "0x183257860")]
	public JAPMJPEGFDC(bool JIGGHECGMGF = false, bool LPFJEFGKLCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3A16D30", Offset = "0x3A15B30", VA = "0x183A16D30")]
	public void EIPDNFJIBDM(T GBMCNPIMCLE, U LDDFEDEOICJ, V HHLJIMLHKAO, W JMEBBPBFDEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32577D0", Offset = "0x32565D0", VA = "0x1832577D0")]
	public static JAPMJPEGFDC<T, U, V, W> FKIIBOICILH(JAPMJPEGFDC<T, U, V, W> NMJPFIEPAGH, Action<T, U, V, W> ENHEBPDFNME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3256B40", Offset = "0x3255940", VA = "0x183256B40")]
	public static JAPMJPEGFDC<T, U, V, W> AOAJJLHDPJD(JAPMJPEGFDC<T, U, V, W> NMJPFIEPAGH, Action<T, U, V, W> ENHEBPDFNME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NDJHHPMOFIJ<T, U, V, W, X> : AHIOLIBHANN<Action<T, U, V, W, X>>
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3257860", Offset = "0x3256660", VA = "0x183257860")]
	public NDJHHPMOFIJ(bool JIGGHECGMGF = false, bool LPFJEFGKLCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3E616B0", Offset = "0x3E604B0", VA = "0x183E616B0")]
	public void EIPDNFJIBDM(T GBMCNPIMCLE, U LDDFEDEOICJ, V HHLJIMLHKAO, W JMEBBPBFDEK, X AHPBAINPGNA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x32577D0", Offset = "0x32565D0", VA = "0x1832577D0")]
	public static NDJHHPMOFIJ<T, U, V, W, X> FKIIBOICILH(NDJHHPMOFIJ<T, U, V, W, X> NMJPFIEPAGH, Action<T, U, V, W, X> ENHEBPDFNME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3256B40", Offset = "0x3255940", VA = "0x183256B40")]
	public static NDJHHPMOFIJ<T, U, V, W, X> AOAJJLHDPJD(NDJHHPMOFIJ<T, U, V, W, X> NMJPFIEPAGH, Action<T, U, V, W, X> ENHEBPDFNME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class EMJIMDGKBBJ<T, U, V, W, X, Y> : AHIOLIBHANN<Action<T, U, V, W, X, Y>>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3257860", Offset = "0x3256660", VA = "0x183257860")]
	public EMJIMDGKBBJ(bool JIGGHECGMGF = false, bool LPFJEFGKLCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3256FB0", Offset = "0x3255DB0", VA = "0x183256FB0")]
	public void EIPDNFJIBDM(T GBMCNPIMCLE, U LDDFEDEOICJ, V HHLJIMLHKAO, W JMEBBPBFDEK, X AHPBAINPGNA, Y KMGCEBLELOI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x32577D0", Offset = "0x32565D0", VA = "0x1832577D0")]
	public static EMJIMDGKBBJ<T, U, V, W, X, Y> FKIIBOICILH(EMJIMDGKBBJ<T, U, V, W, X, Y> NMJPFIEPAGH, Action<T, U, V, W, X, Y> ENHEBPDFNME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3256B40", Offset = "0x3255940", VA = "0x183256B40")]
	public static EMJIMDGKBBJ<T, U, V, W, X, Y> AOAJJLHDPJD(EMJIMDGKBBJ<T, U, V, W, X, Y> NMJPFIEPAGH, Action<T, U, V, W, X, Y> ENHEBPDFNME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BHDOLGKAOCN<TKey, TVal> where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HJNBIJIMEDB<TKey, TVal> GJJCMLHGMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly Dictionary<TKey, (TVal value, int size)> LJDJBLCNCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly int KIKLLGCPOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HJNBIJIMEDB<TKey, TVal>.GANLNFPIFNK? HDMNMKNAHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int FBBCFMNBAMK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal int OKNLNGLHBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x467D4E0", Offset = "0x467C2E0", VA = "0x18467D4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EHGOKDCAHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x467D750", Offset = "0x467C550", VA = "0x18467D750")]
	public BHDOLGKAOCN(int KIKLLGCPOII, [Optional] HJNBIJIMEDB<TKey, TVal>.GANLNFPIFNK? HDMNMKNAHII, [Optional] IEqualityComparer<TKey>? FEEPCLNDDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x467CFE0", Offset = "0x467BDE0", VA = "0x18467CFE0")]
	public void BNPOAHKOAIC(TKey JCMGBFKGKLO, TVal NKKIECLCEML, bool KHNGLEFBFFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x467CF40", Offset = "0x467BD40", VA = "0x18467CF40")]
	public bool ALLEPBBALPJ(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x467D340", Offset = "0x467C140", VA = "0x18467D340")]
	public bool GNMCOJGNPDP(TKey ICMGPMFJFCH, [Out] TVal NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x467D530", Offset = "0x467C330", VA = "0x18467D530")]
	private void POKBBGOCMJE(TKey JCMGBFKGKLO, TVal NKKIECLCEML, int DDGPJFNNFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x467D1B0", Offset = "0x467BFB0", VA = "0x18467D1B0")]
	public bool EGDEMELCCPH(TKey JCMGBFKGKLO, TVal NKKIECLCEML, bool KHNGLEFBFFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x467D420", Offset = "0x467C220", VA = "0x18467D420")]
	private bool LEOELEHJDIF(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EDMPECHEACB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Action DFAPAMFPPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool PBJDEACBJDB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public EDMPECHEACB(Action MHKMOBJEBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x609B9E0", Offset = "0x609A7E0", VA = "0x18609B9E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x25C62C0", Offset = "0x25C50C0", VA = "0x1825C62C0")]
	public static PPOFINEEFFF<T> IKNJBMGGGFK<T>(T NKKIECLCEML, Action MHKMOBJEBCN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class PPOFINEEFFF<T> : EDMPECHEACB where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x405E0E0", Offset = "0x405CEE0", VA = "0x18405E0E0")]
	public PPOFINEEFFF(T NKKIECLCEML, Action MHKMOBJEBCN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct EHEIKHGHOCA : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct OADIIGGMBMK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
		public static OADIIGGMBMK KJKFMOENPNA()
		{
			return default(OADIIGGMBMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	public static EHEIKHGHOCA OJBFBHLICAF(Type HFFNCGFKMBJ, [Optional] string? IANMONBIIHI, [Optional] string? CBBBMGLLIKK, bool HIGNCNOMNMJ = false)
	{
		return default(EHEIKHGHOCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	public static EHEIKHGHOCA OJBFBHLICAF<T>([Optional] string? IANMONBIIHI, [Optional] string? CBBBMGLLIKK, bool HIGNCNOMNMJ = false)
	{
		return default(EHEIKHGHOCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IKAGPFCJJND
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool JHGODKLBEEN(string IONAIPEENBE, IKAGPFCJJND DKIAKJCFOHO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public int BLFMPLMBDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public string EDEKFAGFNME;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x609CEC0", Offset = "0x609BCC0", VA = "0x18609CEC0")]
	public static Dictionary<string, IKAGPFCJJND> NGJMPKEDBKB(Type MIOGAEAHLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x609CB00", Offset = "0x609B900", VA = "0x18609CB00")]
	public static Dictionary<string, IKAGPFCJJND> BGCMAPMHOJH(Type MIOGAEAHLIK, JHGODKLBEEN OIMHNHGIEPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x609D1F0", Offset = "0x609BFF0", VA = "0x18609D1F0")]
	public static Dictionary<int, string> PDAFHBJKAIN(Dictionary<string, IKAGPFCJJND> DIIPJIMFFMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class KOAMPGHKKDA : LNKCFDGMPAP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool HDMLJNFFJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly string? OOMHKIPKGDM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual LNKCFDGMPAP? CIFECMDABGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x609DA60", Offset = "0x609C860", VA = "0x18609DA60")]
	protected KOAMPGHKKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract string EMIBBFOKDML();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x609D820", Offset = "0x609C620", VA = "0x18609D820", Slot = "8")]
	public virtual string KBOJEFPLGFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x609D410", Offset = "0x609C210", VA = "0x18609D410", Slot = "9")]
	public void JAMFGMGFMJO(StringBuilder KODDMLAGOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x609D3B0", Offset = "0x609C1B0", VA = "0x18609D3B0", Slot = "10")]
	public void CPOCMBAEMLL(StringBuilder KODDMLAGOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x609D940", Offset = "0x609C740", VA = "0x18609D940", Slot = "11")]
	public void NNKJHILKOED(StringBuilder KODDMLAGOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x609D6C0", Offset = "0x609C4C0", VA = "0x18609D6C0", Slot = "12")]
	public void JKIDGOIBPNG(StringBuilder KODDMLAGOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x609D8A0", Offset = "0x609C6A0", VA = "0x18609D8A0")]
	public static void KHEMKOALPPB(StringBuilder KODDMLAGOPL, string LOMGONJDMAK, string JCHBAILCPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x531EC80", Offset = "0x531DA80", VA = "0x18531EC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DBGCNFMHBOI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x609B870", Offset = "0x609A670", VA = "0x18609B870")]
	public DBGCNFMHBOI(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OEGCLJCIACF<TErr> : DBGCNFMHBOI where TErr : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly TErr IGFHCLIFGLC;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3F60620", Offset = "0x3F5F420", VA = "0x183F60620")]
	private OEGCLJCIACF([In] TErr MFHOHHMHIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3F60550", Offset = "0x3F5F350", VA = "0x183F60550")]
	public static OEGCLJCIACF<TErr> KJKFMOENPNA([In] TErr MFHOHHMHIOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface LNKCFDGMPAP
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KBOJEFPLGFN();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EMIBBFOKDML();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DANCBNPBEAB<out TOptions> where TOptions : notnull
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TOptions DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HGCHFKFDEEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string NANGOOFKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CGEPJJPAEJC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x609B810", Offset = "0x609A610", VA = "0x18609B810")]
	public CGEPJJPAEJC(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GHKNLGCJAPJ<TOk> : CGEPJJPAEJC where TOk : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly TOk KKGNLIGEALC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x36BB7D0", Offset = "0x36BA5D0", VA = "0x1836BB7D0")]
	private GHKNLGCJAPJ([In] TOk DKNAHBFFJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x36BB580", Offset = "0x36BA380", VA = "0x1836BB580")]
	public static GHKNLGCJAPJ<TOk> KJKFMOENPNA([In] TOk DKNAHBFFJBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct FBEPHKHKLJE<TOk, TErr> : IEquatable<FBEPHKHKLJE<TOk, TErr>> where TOk : notnull where TErr : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static readonly EqualityComparer<TErr> NBCAHNKNLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly TErr IGFHCLIFGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly TOk KKGNLIGEALC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HIKHEMBIABK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x35A4D30", Offset = "0x35A3B30", VA = "0x1835A4D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool NBKAIHKFODA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x35A4000", Offset = "0x35A2E00", VA = "0x1835A4000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x35A7C50", Offset = "0x35A6A50", VA = "0x1835A7C50")]
	internal FBEPHKHKLJE([In] TErr MFHOHHMHIOF, [In] TOk DKNAHBFFJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x35A0640", Offset = "0x359F440", VA = "0x1835A0640")]
	public static FBEPHKHKLJE<TOk, TErr> CJJJLBOFJFE([In] TErr MFHOHHMHIOF)
	{
		return default(FBEPHKHKLJE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x35A45D0", Offset = "0x35A33D0", VA = "0x1835A45D0")]
	public static FBEPHKHKLJE<TOk, TErr> NIGAOMPALDM([In] TOk DKNAHBFFJBM)
	{
		return default(FBEPHKHKLJE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24100A0", Offset = "0x240EEA0", VA = "0x1824100A0")]
	public FBEPHKHKLJE<TOk?, UErr?> PCOKOKJFEBF<UErr>()
	{
		return default(FBEPHKHKLJE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x240FA30", Offset = "0x240E830", VA = "0x18240FA30")]
	public FBEPHKHKLJE<UOk?, TErr?> OJIJJFPLNHC<UOk>()
	{
		return default(FBEPHKHKLJE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2410BE0", Offset = "0x240F9E0", VA = "0x182410BE0")]
	public FBEPHKHKLJE<UOk?, TErr?> PFIPAKLPMEO<UOk>()
	{
		return default(FBEPHKHKLJE<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x240F700", Offset = "0x240E500", VA = "0x18240F700")]
	public FBEPHKHKLJE<TOk?, UErr?> DGLIFGEBHKC<UErr>()
	{
		return default(FBEPHKHKLJE<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x35A2900", Offset = "0x35A1700", VA = "0x1835A2900")]
	public FBEPHKHKLJE<JEGFFGGMBEH, TErr> IEMIALKFJAG()
	{
		return default(FBEPHKHKLJE<JEGFFGGMBEH, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x35A31D0", Offset = "0x35A1FD0", VA = "0x1835A31D0")]
	public static bool JACCNGOPODK([In] FBEPHKHKLJE<TOk, TErr> DPMPIPDPNFG, [In] FBEPHKHKLJE<TOk, TErr> DJCBILALFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x35A0C10", Offset = "0x359FA10", VA = "0x1835A0C10", Slot = "4")]
	public bool Equals(FBEPHKHKLJE<TOk, TErr> FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x35A0A90", Offset = "0x359F890", VA = "0x1835A0A90", Slot = "0")]
	public override bool Equals(object FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x35A1FD0", Offset = "0x35A0DD0", VA = "0x1835A1FD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x35A5FA0", Offset = "0x35A4DA0", VA = "0x1835A5FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HDHDJKCGGDB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct MPDANDOBKJH<TOk, TErr> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AsyncTaskMethodBuilder<TOk> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Task<FBEPHKHKLJE<TOk, TErr>> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<FBEPHKHKLJE<TOk, TErr>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3E00D80", Offset = "0x3DFFB80", VA = "0x183E00D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3E010A0", Offset = "0x3DFFEA0", VA = "0x183E010A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x270FAE0", Offset = "0x270E8E0", VA = "0x18270FAE0")]
	public static FBEPHKHKLJE<TOk?, TErr?> KKGNLIGEALC<TOk, TErr>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [In] TOk DKNAHBFFJBM)
	{
		return default(FBEPHKHKLJE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27100F0", Offset = "0x270EEF0", VA = "0x1827100F0")]
	public static FBEPHKHKLJE<JEGFFGGMBEH, TErr?> KKGNLIGEALC<TErr>([In] this FBEPHKHKLJE<JEGFFGGMBEH, TErr> CNFBJPGPBBJ)
	{
		return default(FBEPHKHKLJE<JEGFFGGMBEH, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x270FAE0", Offset = "0x270E8E0", VA = "0x18270FAE0")]
	public static FBEPHKHKLJE<TOk?, TErr?> IGFHCLIFGLC<TOk, TErr>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [In] TErr MFHOHHMHIOF)
	{
		return default(FBEPHKHKLJE<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x270FED0", Offset = "0x270ECD0", VA = "0x18270FED0")]
	public static TOk? KHOPOAJBFFH<TOk, TErr>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ)
	{
		return (TOk?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2710630", Offset = "0x270F430", VA = "0x182710630")]
	[AsyncStateMachine(typeof(MPDANDOBKJH<, >))]
	public static Task<TOk?>? MICFNCOFMDN<TOk, TErr>(this Task<FBEPHKHKLJE<TOk, TErr>> CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2710980", Offset = "0x270F780", VA = "0x182710980")]
	public static TErr? OLDFJGLLAJB<TErr, TOk>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ)
	{
		return (TErr?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x270E9D0", Offset = "0x270D7D0", VA = "0x18270E9D0")]
	public static bool GPCGBHLBIFD<TOk, TErr, UErr, UOk>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [Out] FBEPHKHKLJE<UOk, UErr> FEJIKEFNBAE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x270FA20", Offset = "0x270E820", VA = "0x18270FA20")]
	public static bool HCLDKEHMLMN<TOk, TErr>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [Out][NotNullWhen(true)] TOk DKNAHBFFJBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27105C0", Offset = "0x270F3C0", VA = "0x1827105C0")]
	public static bool MHJLGGBPLEM<TOk, TErr>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [Out][NotNullWhen(true)] TErr MFHOHHMHIOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x270E4A0", Offset = "0x270D2A0", VA = "0x18270E4A0")]
	public static bool CDALNOBIMDA<TOk, TErr>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [Out][NotNullWhen(true)] TOk DKNAHBFFJBM, [Out][NotNullWhen(false)] TErr MFHOHHMHIOF) where TOk : notnull where TErr : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x270E8D0", Offset = "0x270D6D0", VA = "0x18270E8D0")]
	public static bool GLKDLGLDEJH<TOk, TErr>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [Out][NotNullWhen(true)] TOk DKNAHBFFJBM, [Out] FBEPHKHKLJE<TOk, TErr> FEJIKEFNBAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x270EAE0", Offset = "0x270D8E0", VA = "0x18270EAE0")]
	public static bool GPCGBHLBIFD<TOk, TErr, UErr, UOk>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [Out][NotNullWhen(true)] TOk DKNAHBFFJBM, [Out] FBEPHKHKLJE<UOk, UErr> FEJIKEFNBAE) where TErr : UErr?
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27101F0", Offset = "0x270EFF0", VA = "0x1827101F0")]
	public static bool LNMNDFJALKL<TOk, TErr>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [Out][NotNullWhen(true)] TOk DKNAHBFFJBM, [Out] FBEPHKHKLJE<JEGFFGGMBEH, TErr> FEJIKEFNBAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2710E10", Offset = "0x270FC10", VA = "0x182710E10")]
	public static FBEPHKHKLJE<UOk, UErr> PEMLIHKMJJF<UOk, UErr, TOk, TErr>([In] this FBEPHKHKLJE<TOk, TErr> CNFBJPGPBBJ, [In] FBEPHKHKLJE<UOk, UErr> AIFJDDMPMMF) where TOk : UOk where TErr : UErr
	{
		return default(FBEPHKHKLJE<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x270E590", Offset = "0x270D390", VA = "0x18270E590")]
	public static FBEPHKHKLJE<TOk?[]?, TErr?> CILJBOFOIGK<TOk, TErr>(this IEnumerable<FBEPHKHKLJE<TOk, TErr>> CNFBJPGPBBJ)
	{
		return default(FBEPHKHKLJE<TOk[], TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class IJHEDLCIFPE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2416550", Offset = "0x2415350", VA = "0x182416550")]
	public static FBEPHKHKLJE<TOk, T> KKGNLIGEALC<TOk>([In] TOk DKNAHBFFJBM) where TOk : notnull
	{
		return default(FBEPHKHKLJE<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x385E050", Offset = "0x385CE50", VA = "0x18385E050")]
	public static FBEPHKHKLJE<JEGFFGGMBEH, T> KKGNLIGEALC()
	{
		return default(FBEPHKHKLJE<JEGFFGGMBEH, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2416550", Offset = "0x2415350", VA = "0x182416550")]
	public static FBEPHKHKLJE<T, TErr> IGFHCLIFGLC<TErr>([In] TErr MFHOHHMHIOF) where TErr : notnull
	{
		return default(FBEPHKHKLJE<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public sealed class CODLGIMBNFP<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private readonly struct OBBBFILJKGP : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly CODLGIMBNFP<T> CKHDHJCLJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly int OAFENDIIIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly bool HFDNGGNKPDO;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1C945D0", Offset = "0x1C933D0", VA = "0x181C945D0")]
		public OBBBFILJKGP(CODLGIMBNFP<T> HBHLLIKFPMD, int LCEFBFKBMOE, bool PFHFEECLAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3F50430", Offset = "0x3F4F230", VA = "0x183F50430")]
		public CODLGIMBNFP<T>.JLPEHNOHAGI OOEEFIELKKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3F50520", Offset = "0x3F4F320", VA = "0x183F50520", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3F50520", Offset = "0x3F4F320", VA = "0x183F50520", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class JLPEHNOHAGI : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly CODLGIMBNFP<T> CKHDHJCLJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly int JCJOLHHDPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int DFPCKHJCOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly bool HFDNGGNKPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool KHEJBIMIKMO;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3A5D690", Offset = "0x3A5C490", VA = "0x183A5D690")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3A5D7C0", Offset = "0x3A5C5C0", VA = "0x183A5D7C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3A5D950", Offset = "0x3A5C750", VA = "0x183A5D950", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DDD0", Offset = "0x3A5CBD0", VA = "0x183A5DDD0")]
		public JLPEHNOHAGI(CODLGIMBNFP<T> HBHLLIKFPMD, int LCEFBFKBMOE, bool PFHFEECLAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D710", Offset = "0x3A5C510", VA = "0x183A5D710", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D7A0", Offset = "0x3A5C5A0", VA = "0x183A5D7A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NLAGODMNFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NLAGODMNFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3E75EF0", Offset = "0x3E74CF0", VA = "0x183E75EF0")]
		internal T IAAMCOOOKCL(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly T[] LEGFNKEDBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int DFPCKHJCOAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ADPDEMHKHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4A5F600", Offset = "0x4A5E400", VA = "0x184A5F600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T ODMJFPGIBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x359C750", Offset = "0x359B550", VA = "0x18359C750")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T HPALBOJMJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4A5F300", Offset = "0x4A5E100", VA = "0x184A5F300")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4A5F3D0", Offset = "0x4A5E1D0", VA = "0x184A5F3D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AAKPPKIKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1659C60", Offset = "0x1658A60", VA = "0x181659C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xF43CB0", Offset = "0xF42AB0", VA = "0x180F43CB0")]
	private static int EIJFKNAJFCM(int ENPOKNEMOMH, int FAPCCJLFBAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F910", Offset = "0x4A5E710", VA = "0x184A5F910")]
	public CODLGIMBNFP(int DDGPJFNNFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F6F0", Offset = "0x4A5E4F0", VA = "0x184A5F6F0")]
	public CODLGIMBNFP(int DDGPJFNNFJK, Func<T> ECMCBDHBCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4A5FA20", Offset = "0x4A5E820", VA = "0x184A5FA20")]
	public CODLGIMBNFP(T[] CHPHEMNFCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F480", Offset = "0x4A5E280", VA = "0x184A5F480")]
	public void IOKCJDPNHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F4B0", Offset = "0x4A5E2B0", VA = "0x184A5F4B0")]
	public IEnumerable<T> LCKMAOINLOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4A5F570", Offset = "0x4A5E370", VA = "0x184A5F570")]
	public CODLGIMBNFP<T>.JLPEHNOHAGI OOEEFIELKKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x363A1D0", Offset = "0x3638FD0", VA = "0x18363A1D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x363A1D0", Offset = "0x3638FD0", VA = "0x18363A1D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class BFDAKDJLBIP
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x24E6B50", Offset = "0x24E5950", VA = "0x1824E6B50")]
	public static CODLGIMBNFP<T> KJKFMOENPNA<T>(int DDGPJFNNFJK, Func<T> ECMCBDHBCMM) where T : notnull
	{
		return null;
	}
}
namespace RecRoom.NoEngine.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
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

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1D7CA90", Offset = "0x1D7B890", VA = "0x181D7CA90")]
		public RRColor(float KEGMCPHLHED, float JDJJHOAGFHK, float LGCDJBDIEJC, float GCMDJKOKHCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x609E300", Offset = "0x609D100", VA = "0x18609E300", Slot = "4")]
		public bool Equals(RRColor FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x609E380", Offset = "0x609D180", VA = "0x18609E380", Slot = "0")]
		public override bool Equals(object FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x609E480", Offset = "0x609D280", VA = "0x18609E480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x609E500", Offset = "0x609D300", VA = "0x18609E500", Slot = "5")]
		public string ToString(string GDBGIPNHFLM, IFormatProvider KIHJGIMJCIP)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class MCDLMADDFNA<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public readonly struct KBBNBGAPLIJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly MCDLMADDFNA<T> EEJBEJKLOMI;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public T DFPHMDCMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3A9A7A0", Offset = "0x3A995A0", VA = "0x183A9A7A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A9A770", Offset = "0x3A99570", VA = "0x183A9A770", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
		public KBBNBGAPLIJ(MCDLMADDFNA<T> EEJBEJKLOMI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JNHFHNPOCNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<KBBNBGAPLIJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MCDLMADDFNA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A60D80", Offset = "0x3A5FB80", VA = "0x183A60D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x304C800", Offset = "0x304B600", VA = "0x18304C800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly SemaphoreSlim BENDFLCKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T ILGIHLOMABO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA200", Offset = "0x3DD9000", VA = "0x183DDA200")]
	public MCDLMADDFNA([In] T ILGIHLOMABO, int DLNGJINCDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA1E0", Offset = "0x3DD8FE0", VA = "0x183DDA1E0")]
	public MCDLMADDFNA([In] T ILGIHLOMABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9C30", Offset = "0x3DD8A30", VA = "0x183DD9C30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA0F0", Offset = "0x3DD8EF0", VA = "0x183DDA0F0")]
	public KBBNBGAPLIJ KDLPKIMIFAM()
	{
		return default(KBBNBGAPLIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9D70", Offset = "0x3DD8B70", VA = "0x183DD9D70")]
	[AsyncStateMachine(typeof(MCDLMADDFNA<>.JNHFHNPOCNI))]
	public Task<MCDLMADDFNA<T>.KBBNBGAPLIJ> ECIMDGIGNDD(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA0D0", Offset = "0x3DD8ED0", VA = "0x183DDA0D0")]
	public void FBGFPPPLBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class DOFJNLGLHLO
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x609B970", Offset = "0x609A770", VA = "0x18609B970")]
	public static MCDLMADDFNA<JEGFFGGMBEH> KJKFMOENPNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x259ACE0", Offset = "0x2599AE0", VA = "0x18259ACE0")]
	public static MCDLMADDFNA<T> KJKFMOENPNA<T>([In] T ILGIHLOMABO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class AOPGJIHDMLP<T> : IDisposable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public readonly struct BFDCCBPGAGC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly AOPGJIHDMLP<T> NOJFMCELFLI;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public T DFPHMDCMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x35D13E0", Offset = "0x35D01E0", VA = "0x1835D13E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x46750A0", Offset = "0x4673EA0", VA = "0x1846750A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
		internal BFDCCBPGAGC(AOPGJIHDMLP<T> EEJBEJKLOMI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct FJBJMIIOBMN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly AOPGJIHDMLP<T> NOJFMCELFLI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public T DFPHMDCMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x35D13E0", Offset = "0x35D01E0", VA = "0x1835D13E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x35D12F0", Offset = "0x35D00F0", VA = "0x1835D12F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
		internal FJBJMIIOBMN(AOPGJIHDMLP<T> EEJBEJKLOMI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct ECGCBMJEHCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<FJBJMIIOBMN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AOPGJIHDMLP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private MCDLMADDFNA<JEGFFGGMBEH>.KBBNBGAPLIJ <writeLock>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<MCDLMADDFNA<JEGFFGGMBEH>.KBBNBGAPLIJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3227950", Offset = "0x3226750", VA = "0x183227950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x304C800", Offset = "0x304B600", VA = "0x18304C800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly MCDLMADDFNA<int> OKOKGCNFMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly MCDLMADDFNA<JEGFFGGMBEH> FADPNKEFEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly MCDLMADDFNA<JEGFFGGMBEH> NEAMGNMFMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private T LPHJBIFFHEA;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x373B630", Offset = "0x373A430", VA = "0x18373B630")]
	internal AOPGJIHDMLP(MCDLMADDFNA<int> GEFPHDDHEJK, MCDLMADDFNA<JEGFFGGMBEH> LHLGHEFFFLA, MCDLMADDFNA<JEGFFGGMBEH> KBKHBJJJLAK, [In] T ILGIHLOMABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x373A910", Offset = "0x3739710", VA = "0x18373A910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x373B3F0", Offset = "0x373A1F0", VA = "0x18373B3F0")]
	public BFDCCBPGAGC LBOGEFKGOMK()
	{
		return default(BFDCCBPGAGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x373ABF0", Offset = "0x37399F0", VA = "0x18373ABF0")]
	public FJBJMIIOBMN KIKABBCJOMK()
	{
		return default(FJBJMIIOBMN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x373AF40", Offset = "0x3739D40", VA = "0x18373AF40")]
	[AsyncStateMachine(typeof(AOPGJIHDMLP<>.ECGCBMJEHCD))]
	public Task<AOPGJIHDMLP<T>.FJBJMIIOBMN> KLGHGNOBJKF(CancellationToken HHBHDBLGMFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class MJCHPDBDDOK
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x609DC30", Offset = "0x609CA30", VA = "0x18609DC30")]
	public static AOPGJIHDMLP<JEGFFGGMBEH> KJKFMOENPNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x27CFF10", Offset = "0x27CED10", VA = "0x1827CFF10")]
	public static AOPGJIHDMLP<T> KJKFMOENPNA<T>([In] T ILGIHLOMABO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class LKDCNBBAJNH<TData> : KOAMPGHKKDA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly string EPAABOBMNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly TData GHKHBJDIPKA;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
	public override string EMIBBFOKDML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3C10E90", Offset = "0x3C0FC90", VA = "0x183C10E90")]
	internal LKDCNBBAJNH(string EMKENBOOEOH, [In] TData OMHIFBJFAGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MIJIPHBIGMN
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x609DBB0", Offset = "0x609C9B0", VA = "0x18609DBB0")]
	public static LKDCNBBAJNH<JEGFFGGMBEH> KJKFMOENPNA(string EMKENBOOEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x25C62C0", Offset = "0x25C50C0", VA = "0x1825C62C0")]
	public static LKDCNBBAJNH<TData> KJKFMOENPNA<TData>(string EMKENBOOEOH, [In] TData OMHIFBJFAGA) where TData : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MKNGJDJDOEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly Dictionary<object, float> BNNBPKMEFEP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float PEADJHGCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CF010", Offset = "0x8CDE10", VA = "0x1808CF010")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0B0", Offset = "0x8CDEB0", VA = "0x1808CF0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x609DD70", Offset = "0x609CB70", VA = "0x18609DD70")]
	public void FMOCGEPCGJE(float NKKIECLCEML, object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x609DD00", Offset = "0x609CB00", VA = "0x18609DD00")]
	public void AJOKBCANKKO(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x609DDE0", Offset = "0x609CBE0", VA = "0x18609DDE0")]
	private void MJLNIMCLDFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x609DF10", Offset = "0x609CD10", VA = "0x18609DF10")]
	public MKNGJDJDOEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class HPDNKHJABPG<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JMINHDKEFBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JMINHDKEFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3A5FDA0", Offset = "0x3A5EBA0", VA = "0x183A5FDA0")]
		internal int BAPNGBDLFAP(int i, T token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private HashSet<T>? INCHECHCGGH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IReadOnlyCollection<T> FCOFDNFDIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x37C0130", Offset = "0x37BEF30", VA = "0x1837C0130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool ECGOFBAILAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x37C0280", Offset = "0x37BF080", VA = "0x1837C0280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B77F0", Offset = "0x7B65F0", VA = "0x1807B77F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37BFF80", Offset = "0x37BED80", VA = "0x1837BFF80")]
	public bool ANMBPKAMKOK(T NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x37C0160", Offset = "0x37BEF60", VA = "0x1837C0160")]
	public bool JJGPDDBMEBN(T NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37C00F0", Offset = "0x37BEEF0", VA = "0x1837C00F0")]
	public bool BOPPHNBAJLP(T NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x37C02C0", Offset = "0x37BF0C0", VA = "0x1837C02C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HPDNKHJABPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EOHKIDCJHLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly string FEHMEDJDCNN;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public EOHKIDCJHLO(string FEHMEDJDCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x609BA20", Offset = "0x609A820", VA = "0x18609BA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class HENOHJNKMME
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PGNFEOKGECF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public PGNFEOKGECF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x609E250", Offset = "0x609D050", VA = "0x18609E250")]
		internal int BAPNGBDLFAP(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private HashSet<object>? INCHECHCGGH;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IReadOnlyCollection<object> FCOFDNFDIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x609C810", Offset = "0x609B610", VA = "0x18609C810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool ECGOFBAILAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x609C940", Offset = "0x609B740", VA = "0x18609C940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B77F0", Offset = "0x7B65F0", VA = "0x1807B77F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x609C6D0", Offset = "0x609B4D0", VA = "0x18609C6D0")]
	public bool ANMBPKAMKOK(object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x609C8A0", Offset = "0x609B6A0", VA = "0x18609C8A0")]
	public bool JJGPDDBMEBN(object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x609C7B0", Offset = "0x609B5B0", VA = "0x18609C7B0")]
	public bool BOPPHNBAJLP(object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x609C660", Offset = "0x609B460", VA = "0x18609C660")]
	public void AEBAGFPEHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x609C950", Offset = "0x609B750", VA = "0x18609C950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HENOHJNKMME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class AECCJKFPEMF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private struct IMDDCOKBOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float CGOKFIJIKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public T DFPHMDCMPIO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly Dictionary<object, IMDDCOKBOGG> BNNBPKMEFEP;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public virtual T APCPBAJKMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xE63CC0", Offset = "0xE62AC0", VA = "0x180E63CC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xE626C0", Offset = "0xE614C0", VA = "0x180E626C0", Slot = "5")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public object? GFKMGHELEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BLJNLKOKFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3672A00", Offset = "0x3671800", VA = "0x183672A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3673130", Offset = "0x3671F30", VA = "0x183673130")]
	public bool FMOCGEPCGJE(T NKKIECLCEML, object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3672960", Offset = "0x3671760", VA = "0x183672960")]
	public bool AJOKBCANKKO(object NBGOKNOECBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x36729D0", Offset = "0x36717D0", VA = "0x1836729D0")]
	public void BBGCGJHDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3673340", Offset = "0x3672140", VA = "0x183673340")]
	public bool GNMCOJGNPDP(object NBGOKNOECBH, [Out] T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3673950", Offset = "0x3672750", VA = "0x183673950")]
	[CLIBOIKMCKH("T can be T?, `default!` shouldn't be necessary in C# 9")]
	private bool OBFBMIGADME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3674C00", Offset = "0x3673A00", VA = "0x183674C00")]
	public AECCJKFPEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GGBPLCLBGEG
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LJHDLCEKKCK HPGGPGNCECM;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class GPACFPBPMNF : GGBPLCLBGEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public readonly struct FMEKIHIBPKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly float KJBAIGHFNON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float HICJPHFMNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		internal readonly bool MEKBGLMALDK;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MLMGACONFEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x609BA70", Offset = "0x609A870", VA = "0x18609BA70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x609BBE0", Offset = "0x609A9E0", VA = "0x18609BBE0")]
		public FMEKIHIBPKO(float IFADIJDFJBM, float DBFFCPMHGNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x609BA80", Offset = "0x609A880", VA = "0x18609BA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DJLCICOGPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public GPACFPBPMNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DJLCICOGPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x609B8D0", Offset = "0x609A6D0", VA = "0x18609B8D0")]
		internal void PFMKKNFCNHD(float innerProgress)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly int BKPALGGNBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private int DNLDILPHPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly GGBPLCLBGEG[] KJEMMMENGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LJHDLCEKKCK[] ADOCEOOMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FMEKIHIBPKO[] LHPKBOMPLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private FMEKIHIBPKO HJJFNGNPPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly OBCFLGGKGFN COIGKKFCIJD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event LJHDLCEKKCK HPGGPGNCECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x609C2C0", Offset = "0x609B0C0", VA = "0x18609C2C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x609C410", Offset = "0x609B210", VA = "0x18609C410", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x609C4D0", Offset = "0x609B2D0", VA = "0x18609C4D0")]
	public GPACFPBPMNF(int BKPALGGNBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x609C380", Offset = "0x609B180", VA = "0x18609C380")]
	public OBCFLGGKGFN LOIHOIAIOGO(FMEKIHIBPKO BECGMOEEJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x609BD40", Offset = "0x609AB40", VA = "0x18609BD40")]
	public void AIJPBJGJJGA(GGBPLCLBGEG LLMLLCFPIPJ, [Optional] FMEKIHIBPKO MEPJCJDDOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x609C1B0", Offset = "0x609AFB0", VA = "0x18609C1B0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void LJHDLCEKKCK(float OPMMDEBAKIH);
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BBEKDICBFGN
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private class LCHDMDJPHIF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly GGBPLCLBGEG LLJPMHNPHHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly LJHDLCEKKCK IDFHKFHMFGD;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x609DB20", Offset = "0x609C920", VA = "0x18609DB20")]
		public LCHDMDJPHIF(GGBPLCLBGEG LLJPMHNPHHG, LJHDLCEKKCK IDFHKFHMFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x609DAD0", Offset = "0x609C8D0", VA = "0x18609DAD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x609B3C0", Offset = "0x609A1C0", VA = "0x18609B3C0")]
	internal static bool HKIOHMOBCNG(float GCMDJKOKHCO, float LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6090CD0", Offset = "0x608FAD0", VA = "0x186090CD0")]
	internal static float EBILFAIKNIH(float GCMDJKOKHCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x609B430", Offset = "0x609A230", VA = "0x18609B430")]
	public static IDisposable IJGGLFOJJED(this GGBPLCLBGEG LLJPMHNPHHG, LJHDLCEKKCK IDFHKFHMFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class OBCFLGGKGFN : GGBPLCLBGEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float OPMMDEBAKIH;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public float AHPEJABPJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x609E160", Offset = "0x609CF60", VA = "0x18609E160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event LJHDLCEKKCK? HPGGPGNCECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x609E020", Offset = "0x609CE20", VA = "0x18609E020", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x609E0C0", Offset = "0x609CEC0", VA = "0x18609E0C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public OBCFLGGKGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class BGLOFBIDDOE : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5B84510", Offset = "0x5B83310", VA = "0x185B84510")]
	public BGLOFBIDDOE(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public class EPHLCPPENDC<TKey, TValue> : GHBEDGLDHBJ<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, GIKLOGMLPCO where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class PAKFACDFJEE : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private KeyValuePair<TKey, TValue> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public EPHLCPPENDC<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private IEnumerator<KeyValuePair<TKey, TValue>> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xE63CC0", Offset = "0xE62AC0", VA = "0x180E63CC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TValue>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4010A40", Offset = "0x400F840", VA = "0x184010A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public PAKFACDFJEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x34E6D50", Offset = "0x34E5B50", VA = "0x1834E6D50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4010480", Offset = "0x400F280", VA = "0x184010480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4010900", Offset = "0x400F700", VA = "0x184010900")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x400FC80", Offset = "0x400EA80", VA = "0x18400FC80")]
		private void AGDCIDILFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x40109F0", Offset = "0x400F7F0", VA = "0x1840109F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly GHBEDGLDHBJ<TKey, TValue> FFFGMMAIHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IDictionary<TKey, TValue> KPOKGKEMLGH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x326AAC0", Offset = "0x32698C0", VA = "0x18326AAC0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool JPJFNMHJCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TValue LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x326ABC0", Offset = "0x32699C0", VA = "0x18326ABC0", Slot = "4")]
		get
		{
			return (TValue)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x326AE40", Offset = "0x3269C40", VA = "0x18326AE40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ICollection<TKey> PCKCIKFNJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x326AC00", Offset = "0x3269A00", VA = "0x18326AC00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public ICollection<TValue> BOEKFJCDIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x326AD10", Offset = "0x3269B10", VA = "0x18326AD10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x326A940", Offset = "0x3269740", VA = "0x18326A940")]
	public EPHLCPPENDC(GHBEDGLDHBJ<TKey, TValue> FFFGMMAIHFO, [Optional] IDictionary<TKey, TValue>? KPOKGKEMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3268B50", Offset = "0x3267950", VA = "0x183268B50", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3269AB0", Offset = "0x32688B0", VA = "0x183269AB0")]
	public void LJHCNAPKHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x32682E0", Offset = "0x32670E0", VA = "0x1832682E0", Slot = "9")]
	public void Add(TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3269280", Offset = "0x3268080", VA = "0x183269280")]
	public void ENLDDPJILHI(TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x32687A0", Offset = "0x32675A0", VA = "0x1832687A0")]
	public void CFEELGDJAEB(TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3269430", Offset = "0x3268230", VA = "0x183269430")]
	public void FPKIMBFEMJG(TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3269A10", Offset = "0x3268810", VA = "0x183269A10")]
	public void HHHKKHNFCPO(TKey JCMGBFKGKLO, TValue NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3269F80", Offset = "0x3268D80", VA = "0x183269F80", Slot = "14")]
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> PEFIMPHEJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x326A160", Offset = "0x3268F60", VA = "0x18326A160", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x326A4C0", Offset = "0x32692C0", VA = "0x18326A4C0", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3268C60", Offset = "0x3267A60", VA = "0x183268C60", Slot = "8")]
	public bool ContainsKey(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3268A20", Offset = "0x3267820", VA = "0x183268A20")]
	public bool CLAHJECPKHG(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3268670", Offset = "0x3267470", VA = "0x183268670")]
	public bool BLEAJMCILPG(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3269CF0", Offset = "0x3268AF0", VA = "0x183269CF0", Slot = "10")]
	public bool Remove(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x326A790", Offset = "0x3269590", VA = "0x18326A790", Slot = "11")]
	public bool TryGetValue(TKey JCMGBFKGKLO, [Out] TValue NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3268F60", Offset = "0x3267D60", VA = "0x183268F60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] AAKJIOEDOGA, int LNFNDNMPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x326A680", Offset = "0x3269480", VA = "0x18326A680", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3269860", Offset = "0x3268660", VA = "0x183269860", Slot = "19")]
	[IteratorStateMachine(typeof(EPHLCPPENDC<, >.PAKFACDFJEE))]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3269810", Offset = "0x3268610", VA = "0x183269810", Slot = "21")]
	public bool GMLHDKFPDEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3269BF0", Offset = "0x32689F0", VA = "0x183269BF0")]
	private TValue OLJKIHCNMOE(TKey JCMGBFKGKLO)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface GIKLOGMLPCO
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMLHDKFPDEL();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface GHBEDGLDHBJ<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GIKLOGMLPCO
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public sealed class HJNBIJIMEDB<TKey, TVal> : GHBEDGLDHBJ<TKey, TVal>, IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, GIKLOGMLPCO where TKey : notnull where TVal : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate int GANLNFPIFNK(TKey JCMGBFKGKLO, TVal NKKIECLCEML);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class BHILIDGCHHB
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public TKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xB6E440", Offset = "0xB6D240", VA = "0x180B6E440")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public TVal DFPHMDCMPIO
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8CBDC0", Offset = "0x8CABC0", VA = "0x1808CBDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int MLMGACONFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7E8AA0", Offset = "0x7E78A0", VA = "0x1807E8AA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7E85E0", Offset = "0x7E73E0", VA = "0x1807E85E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DateTimeOffset AJMHFCKNLOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA34F50", Offset = "0xA33D50", VA = "0x180A34F50")]
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x1269910", Offset = "0x1268710", VA = "0x181269910")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x46A3360", Offset = "0x46A2160", VA = "0x1846A3360")]
		public BHILIDGCHHB(TKey JCMGBFKGKLO, TVal NGFDKOKHGLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class ILJCOICEBDH : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private KeyValuePair<TKey, TVal> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public HJNBIJIMEDB<TKey, TVal> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private LinkedList<BHILIDGCHHB>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		KeyValuePair<TKey, TVal> IEnumerator<KeyValuePair<TKey, TVal>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xE63CC0", Offset = "0xE62AC0", VA = "0x180E63CC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(KeyValuePair<TKey, TVal>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x386E070", Offset = "0x386CE70", VA = "0x18386E070", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public ILJCOICEBDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x34E4DB0", Offset = "0x34E3BB0", VA = "0x1834E4DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x386D870", Offset = "0x386C670", VA = "0x18386D870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x386DB80", Offset = "0x386C980", VA = "0x18386DB80")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x386DEE0", Offset = "0x386CCE0", VA = "0x18386DEE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public const int LMEOFMNDFAL = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<TKey, LinkedListNode<BHILIDGCHHB>> EGFOANHKELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly LinkedList<BHILIDGCHHB> NLCLKOGJCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GANLNFPIFNK? HDMNMKNAHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly TimeSpan MHFCHNAJDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly GJLLBINFGLA EDLKKEIFAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool KAMKEPOOKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly List<TKey> JADALLCGOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly List<TVal> AGJGNOCGALJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int EHGOKDCAHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7C72D0", Offset = "0x7C60D0", VA = "0x1807C72D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	internal int OKNLNGLHBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C72E0", Offset = "0x7C60E0", VA = "0x1807C72E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xE7F570", Offset = "0xE7E370", VA = "0x180E7F570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x37A22C0", Offset = "0x37A10C0", VA = "0x1837A22C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	internal int KGIKHMGELIO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3798090", Offset = "0x3796E90", VA = "0x183798090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICollection<TVal> BOEKFJCDIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x37A2470", Offset = "0x37A1270", VA = "0x1837A2470", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	ICollection<TKey> IDictionary<TKey, TVal>.JHIFMIFOPCD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x379CF60", Offset = "0x379BD60", VA = "0x18379CF60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JPJFNMHJCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public TVal LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x37A2350", Offset = "0x37A1150", VA = "0x1837A2350", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x37A24A0", Offset = "0x37A12A0", VA = "0x1837A24A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3799E60", Offset = "0x3798C60", VA = "0x183799E60")]
	private bool IDDKFGCLMGO(int BKPALGGNBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3794130", Offset = "0x3792F30", VA = "0x183794130")]
	private void EHGBPPPCJNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x37A0580", Offset = "0x379F380", VA = "0x1837A0580")]
	public HJNBIJIMEDB(int BKPALGGNBEN, [Optional] GANLNFPIFNK? HDMNMKNAHII, [Optional] IEqualityComparer<TKey>? FEEPCLNDDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x379E000", Offset = "0x379CE00", VA = "0x18379E000")]
	public HJNBIJIMEDB(TimeSpan MHFCHNAJDKE, [Optional] IEqualityComparer<TKey>? FEEPCLNDDAC, [Optional] GJLLBINFGLA? EDLKKEIFAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x379DFC0", Offset = "0x379CDC0", VA = "0x18379DFC0")]
	public HJNBIJIMEDB(int BKPALGGNBEN, TimeSpan MHFCHNAJDKE, [Optional] IEqualityComparer<TKey>? FEEPCLNDDAC, [Optional] GJLLBINFGLA? EDLKKEIFAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x37A0BC0", Offset = "0x379F9C0", VA = "0x1837A0BC0")]
	public HJNBIJIMEDB(int BKPALGGNBEN, GANLNFPIFNK? HDMNMKNAHII, TimeSpan MHFCHNAJDKE, [Optional] IEqualityComparer<TKey>? FEEPCLNDDAC, [Optional] GJLLBINFGLA? EDLKKEIFAHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3799B10", Offset = "0x3798910", VA = "0x183799B10", Slot = "21")]
	public bool GMLHDKFPDEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x379B7B0", Offset = "0x379A5B0", VA = "0x18379B7B0", Slot = "22")]
	public bool NENNPBNEIBJ(int DDGPJFNNFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3794F30", Offset = "0x3793D30", VA = "0x183794F30")]
	private bool FGCIFPDCLJI(int DDGPJFNNFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3797830", Offset = "0x3796630", VA = "0x183797830")]
	public void FOBLAMHLHCD(TKey JCMGBFKGKLO, TVal NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x378F0E0", Offset = "0x378DEE0", VA = "0x18378F0E0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PEFIMPHEJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x378F3C0", Offset = "0x378E1C0", VA = "0x18378F3C0", Slot = "9")]
	public void Add(TKey JCMGBFKGKLO, TVal NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x378FD10", Offset = "0x378EB10", VA = "0x18378FD10", Slot = "8")]
	public bool ContainsKey(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x379C160", Offset = "0x379AF60", VA = "0x18379C160", Slot = "16")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Contains(KeyValuePair<TKey, TVal> PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x379BE60", Offset = "0x379AC60", VA = "0x18379BE60", Slot = "10")]
	public bool Remove(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x379C920", Offset = "0x379B720", VA = "0x18379C920", Slot = "18")]
	bool ICollection<KeyValuePair<TKey, TVal>>.Remove(KeyValuePair<TKey, TVal> PEFIMPHEJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x379AC50", Offset = "0x3799A50", VA = "0x18379AC50")]
	private bool MCOMBJNJIOF(TKey JCMGBFKGKLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3799FA0", Offset = "0x3798DA0", VA = "0x183799FA0")]
	private TVal IKJEAFPPDKF(TKey ICMGPMFJFCH)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x379CFC0", Offset = "0x379BDC0", VA = "0x18379CFC0", Slot = "11")]
	public bool TryGetValue(TKey ICMGPMFJFCH, [Out] TVal NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x378FA70", Offset = "0x378E870", VA = "0x18378FA70", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3792280", Offset = "0x3791080", VA = "0x183792280", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] AAKJIOEDOGA, int LNFNDNMPKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3793830", Offset = "0x3792630", VA = "0x183793830")]
	private bool DADJDMHDLLK(BHILIDGCHHB JAJFJIJNMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x378C390", Offset = "0x378B190", VA = "0x18378C390")]
	private void AMEGELBEKME(LinkedListNode<BHILIDGCHHB> MEHOEPFJIBG, TVal OAIFDBCCKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3796D70", Offset = "0x3795B70", VA = "0x183796D70")]
	private void FMOCGEPCGJE(TKey JCMGBFKGKLO, TVal NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3798670", Offset = "0x3797470", VA = "0x183798670")]
	private void GGINDHFPBGD(BHILIDGCHHB JAJFJIJNMFI, TVal OAIFDBCCKDL, int LLIGBPJDKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3799C10", Offset = "0x3798A10", VA = "0x183799C10", Slot = "19")]
	[IteratorStateMachine(typeof(HJNBIJIMEDB<, >.ILJCOICEBDH))]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x379CF90", Offset = "0x379BD90", VA = "0x18379CF90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class INMKHCLBMGI<TId, TResource> : IEnumerable<(TId, Task<TResource>, int)>, IEnumerable where TId : notnull where TResource : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class IJFCCMHCBAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Func<TId, CancellationToken, Task<TResource>> factory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public INMKHCLBMGI<TId, TResource> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IJFCCMHCBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x385C970", Offset = "0x385B770", VA = "0x18385C970")]
		internal Task<TResource> CEEMPEKNGIE(TId _id)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct NDLIEEMNDCK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3E62510", Offset = "0x3E61310", VA = "0x183E62510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3E628F0", Offset = "0x3E616F0", VA = "0x183E628F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct OJLFMGOHIIK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3F782B0", Offset = "0x3F770B0", VA = "0x183F782B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3F78A30", Offset = "0x3F77830", VA = "0x183F78A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly IKKLNFMEEKL<TId, Task<TResource>> NHCAKBMIDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<Task<TResource>, CancellationTokenSource> IKAEKDLAFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Func<TId, CancellationToken, Task<TResource>>? FNOHKOPNFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Action<TResource>? ILINIAHBHGI;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x38777F0", Offset = "0x38765F0", VA = "0x1838777F0")]
	public INMKHCLBMGI(int ILMMPAFNNBE = 0, [Optional] IEqualityComparer<TId>? JKHLJJODGDP, [Optional] Func<TId, CancellationToken, Task<TResource>>? BBIABFCCDFF, [Optional] Action<TResource>? MKNBEOGOIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3876AC0", Offset = "0x38758C0", VA = "0x183876AC0")]
	public PPOFINEEFFF<Task<TResource>> JBIMBFCKBJC(TId DGIBOINMLED, [Optional] Func<TId, CancellationToken, Task<TResource>>? BBIABFCCDFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x38773C0", Offset = "0x38761C0", VA = "0x1838773C0")]
	private void MBHCGDGKOEH(Task<TResource> IMKKNGNMOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x38765A0", Offset = "0x38753A0", VA = "0x1838765A0")]
	public void EECIBLFBFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3877540", Offset = "0x3876340", VA = "0x183877540")]
	public IKKLNFMEEKL<TId, Task<TResource>>.LNKCLLPLGAN OOEEFIELKKG()
	{
		return default(IKKLNFMEEKL<TId, Task<TResource>>.LNKCLLPLGAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x38776C0", Offset = "0x38764C0", VA = "0x1838776C0", Slot = "4")]
	private IEnumerator<(TId, Task<TResource>, int)> System.Collections.Generic.IEnumerable<(TIdId,System.Threading.Tasks.Task<TResource>LoadResourceTask,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x38776C0", Offset = "0x38764C0", VA = "0x1838776C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3876E10", Offset = "0x3875C10", VA = "0x183876E10")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(INMKHCLBMGI<, >.NDLIEEMNDCK))]
	internal static Task KDBLHMCCAPL(Task<TResource> IMKKNGNMOEA, CancellationTokenSource MGJDBNCICDK, Dictionary<Task<TResource>, CancellationTokenSource> OOEHKBHHABD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x38765D0", Offset = "0x38753D0", VA = "0x1838765D0")]
	[AsyncStateMachine(typeof(INMKHCLBMGI<, >.OJLFMGOHIIK))]
	[CompilerGenerated]
	internal static Task GDEONOFKLDF(Task<TResource> IMKKNGNMOEA, Action<TResource> MCPCBOBFHJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class IKKLNFMEEKL<TKey, TValue> : IEnumerable<(TKey, TValue, int)>, IEnumerable where TKey : notnull where TValue : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private sealed class COOINPADPBA : IEquatable<COOINPADPBA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly TValue DFPHMDCMPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int EBBOEAOIGII;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1BEC250", Offset = "0x1BEB050", VA = "0x181BEC250")]
		public COOINPADPBA(TValue NKKIECLCEML, int BHPLABHPOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4A64280", Offset = "0x4A63080", VA = "0x184A64280", Slot = "4")]
		public bool Equals(COOINPADPBA? FPEEGIOMOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4A64310", Offset = "0x4A63110", VA = "0x184A64310", Slot = "0")]
		public override bool Equals(object? NHLNHJGAONN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4A64440", Offset = "0x4A63240", VA = "0x184A64440", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct LNKCLLPLGAN : IEnumerator<(TKey, TValue, int)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private Dictionary<TKey, COOINPADPBA>.Enumerator ONJJHLJPDAD;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3C29E70", Offset = "0x3C28C70", VA = "0x183C29E70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public (TKey Key, TValue Value, int RefCount) ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3C2A2B0", Offset = "0x3C290B0", VA = "0x183C2A2B0", Slot = "4")]
			get
			{
				return default((TKey, TValue, int));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3C2A060", Offset = "0x3C28E60", VA = "0x183C2A060")]
		public LNKCLLPLGAN(IKKLNFMEEKL<TKey, TValue> BNNBPKMEFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3C29B60", Offset = "0x3C28960", VA = "0x183C29B60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3C29BE0", Offset = "0x3C289E0", VA = "0x183C29BE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C29D10", Offset = "0x3C28B10", VA = "0x183C29D10", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class LEPHPMEGGFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IKKLNFMEEKL<TKey, TValue> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public COOINPADPBA refCountedValue;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LEPHPMEGGFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3BE4BC0", Offset = "0x3BE39C0", VA = "0x183BE4BC0")]
		internal void CEEMPEKNGIE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<TKey, COOINPADPBA> KFEOBMICBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Func<TKey, TValue>? AABLBDCPGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly Action<TValue>? AJPKPGKAIHG;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3867470", Offset = "0x3866270", VA = "0x183867470")]
	public IKKLNFMEEKL(int ILMMPAFNNBE = 0, [Optional] IEqualityComparer<TKey>? FEEPCLNDDAC, [Optional] Func<TKey, TValue>? JJLLEJIGKFD, [Optional] Action<TValue>? LGGHNMIBDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3866670", Offset = "0x3865470", VA = "0x183866670")]
	public PPOFINEEFFF<TValue> JBIMBFCKBJC(TKey JCMGBFKGKLO, [Optional] Func<TKey, TValue>? PPGIHHECDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3866FB0", Offset = "0x3865DB0", VA = "0x183866FB0")]
	private void PHNBJIDPAFI(TKey JCMGBFKGKLO, COOINPADPBA ELNOBAGLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3866490", Offset = "0x3865290", VA = "0x183866490")]
	public void EECIBLFBFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3866EF0", Offset = "0x3865CF0", VA = "0x183866EF0")]
	public LNKCLLPLGAN OOEEFIELKKG()
	{
		return default(LNKCLLPLGAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x38673D0", Offset = "0x38661D0", VA = "0x1838673D0", Slot = "4")]
	private IEnumerator<(TKey, TValue, int)> System.Collections.Generic.IEnumerable<(TKeyKey,TValueValue,System.Int32RefCount)>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x38673D0", Offset = "0x38661D0", VA = "0x1838673D0", Slot = "5")]
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
